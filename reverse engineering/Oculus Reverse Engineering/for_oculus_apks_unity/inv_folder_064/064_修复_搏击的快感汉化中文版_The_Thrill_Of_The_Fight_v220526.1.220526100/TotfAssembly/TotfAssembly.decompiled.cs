using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Bhaptics.Tact;
using Bhaptics.Tact.Unity;
using Il2CppDummyDll;
using ProgressBar;
using RogoDigital.Lipsync;
using RootMotion.Dynamics;
using RootMotion.FinalIK;
using TMPro;
using TotF;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CE148", Offset = "0x6CE148")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CE148", Offset = "0x6CE148")]
public class PhotoshootController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class PhotoshootPose
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 lookAtPosition;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 leftHandPosition;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 leftHandRotation;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 leftShoulderPosition;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftArmBendGoal;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 rightHandPosition;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 rightHandRotation;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 rightShoulderPosition;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 rightArmBendGoal;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 bodyPosition;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Vector3 leftFootPosition;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Vector3 leftFootRotation;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 leftThighPosition;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Vector3 leftLegBendGoal;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Vector3 rightFootPosition;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 rightFootRotation;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector3 rightThighPosition;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public Vector3 rightLegBendGoal;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x8C9988", Offset = "0x8C9988", VA = "0x8C9988")]
		public PhotoshootPose()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private FullBodyBipedIK _ik;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LookAtIK _lik;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _lookAtTarget;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _leftHandTarget;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform _leftShoulderTarget;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform _leftElbowTarget;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform _rightHandTarget;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform _rightShoulderTarget;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform _rightElbowTarget;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform _bodyTarget;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform _leftFootTarget;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform _leftThighTarget;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform _leftKneeTarget;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform _rightFootTarget;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform _rightThighTarget;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Transform _rightKneeTarget;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool weGotPose;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int previousIndex;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public int poseIndex;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private PhotoshootPose currentPose;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public PhotoshootPose[] poses;

	[Token(Token = "0x17000001")]
	private FullBodyBipedIK ik
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x8C7AE8", Offset = "0x8C7AE8", VA = "0x8C7AE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	private LookAtIK lik
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x8C7B80", Offset = "0x8C7B80", VA = "0x8C7B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	private Transform lookAtTarget
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x8C7C18", Offset = "0x8C7C18", VA = "0x8C7C18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	private Transform leftHandTarget
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x8C7CFC", Offset = "0x8C7CFC", VA = "0x8C7CFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	private Transform leftShoulderTarget
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x8C7DEC", Offset = "0x8C7DEC", VA = "0x8C7DEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	private Transform leftElbowTarget
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x8C7EDC", Offset = "0x8C7EDC", VA = "0x8C7EDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	private Transform rightHandTarget
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x8C7FD4", Offset = "0x8C7FD4", VA = "0x8C7FD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	private Transform rightShoulderTarget
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x8C80C4", Offset = "0x8C80C4", VA = "0x8C80C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	private Transform rightElbowTarget
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x8C81B4", Offset = "0x8C81B4", VA = "0x8C81B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	private Transform bodyTarget
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x8C82AC", Offset = "0x8C82AC", VA = "0x8C82AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	private Transform leftFootTarget
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x8C839C", Offset = "0x8C839C", VA = "0x8C839C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000C")]
	private Transform leftThighTarget
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x8C848C", Offset = "0x8C848C", VA = "0x8C848C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	private Transform leftKneeTarget
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x8C857C", Offset = "0x8C857C", VA = "0x8C857C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	private Transform rightFootTarget
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x8C8674", Offset = "0x8C8674", VA = "0x8C8674")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	private Transform rightThighTarget
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x8C8764", Offset = "0x8C8764", VA = "0x8C8764")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	private Transform rightKneeTarget
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x8C8854", Offset = "0x8C8854", VA = "0x8C8854")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x8C894C", Offset = "0x8C894C", VA = "0x8C894C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x8C8D14", Offset = "0x8C8D14", VA = "0x8C8D14")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x8C8D38", Offset = "0x8C8D38", VA = "0x8C8D38")]
	private void MonitorPoseChanges()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x8C90E0", Offset = "0x8C90E0", VA = "0x8C90E0")]
	private void SetCurrentPose()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x8C93E8", Offset = "0x8C93E8", VA = "0x8C93E8")]
	[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6CFD00", Offset = "0x6CFD00")]
	public void SetInitialPose()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x8C9978", Offset = "0x8C9978", VA = "0x8C9978")]
	public PhotoshootController()
	{
	}
}
[Token(Token = "0x2000003")]
public class ArrayCopier : MonoBehaviour
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PunchStatsRightGenerator parent;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject redStraightsLanded;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject redStraightsTotal;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject redStraightsPercent;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject blueStraightsLanded;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject blueStraightsTotal;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject blueStraightsPercent;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject redHooksLanded;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject redHooksTotal;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject redHooksPercent;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject blueHooksLanded;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject blueHooksTotal;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject blueHooksPercent;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject redUppersLanded;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject redUppersTotal;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject redUppersPercent;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject blueUppersLanded;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject blueUppersTotal;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject blueUppersPercent;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool go;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x8C4430", Offset = "0x8C4430", VA = "0x8C4430")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x8C46BC", Offset = "0x8C46BC", VA = "0x8C46BC")]
	public ArrayCopier()
	{
	}
}
[Token(Token = "0x2000004")]
public class AudienceLoopStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int animationCount;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x8C46C4", Offset = "0x8C46C4", VA = "0x8C46C4", Slot = "9")]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x8C4740", Offset = "0x8C4740", VA = "0x8C4740", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x8C47BC", Offset = "0x8C47BC", VA = "0x8C47BC")]
	public AudienceLoopStateMachine()
	{
	}
}
[Token(Token = "0x2000005")]
public class AudioRandomizer : MonoBehaviour
{
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x8C47CC", Offset = "0x8C47CC", VA = "0x8C47CC")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x8C4858", Offset = "0x8C4858", VA = "0x8C4858")]
	public AudioRandomizer()
	{
	}
}
[Token(Token = "0x2000006")]
public class AutoLevelLoader : MonoBehaviour
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string levelName;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isLoading;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x8C4860", Offset = "0x8C4860", VA = "0x8C4860")]
	private void Update()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x8C498C", Offset = "0x8C498C", VA = "0x8C498C")]
	public AutoLevelLoader()
	{
	}
}
[Token(Token = "0x2000007")]
public class BhapticsMenuButtonEvents : MonoBehaviour
{
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x8C4C64", Offset = "0x8C4C64", VA = "0x8C4C64")]
	public BhapticsMenuButtonEvents()
	{
	}
}
[Token(Token = "0x2000008")]
public class BhapticsMenuUIUpdate : MonoBehaviour
{
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x8C4C6C", Offset = "0x8C4C6C", VA = "0x8C4C6C")]
	public BhapticsMenuUIUpdate()
	{
	}
}
[Token(Token = "0x2000009")]
public class CelebrateStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x8C4C74", Offset = "0x8C4C74", VA = "0x8C4C74", Slot = "9")]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x8C4CE4", Offset = "0x8C4CE4", VA = "0x8C4CE4")]
	public CelebrateStateMachine()
	{
	}
}
[Token(Token = "0x200000A")]
public class ClockController : MonoBehaviour
{
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject bigHand;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject littleHand;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int hour;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int minute;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float seconds;

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x8C4CEC", Offset = "0x8C4CEC", VA = "0x8C4CEC")]
	public void Start()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x8C4DB0", Offset = "0x8C4DB0", VA = "0x8C4DB0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x8C4F88", Offset = "0x8C4F88", VA = "0x8C4F88")]
	public ClockController()
	{
	}
}
[Token(Token = "0x200000B")]
public class CrowdCullingGroup : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class SphereDefinition
	{
		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 localCenter;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float radius;

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x8C51FC", Offset = "0x8C51FC", VA = "0x8C51FC")]
		public SphereDefinition()
		{
		}
	}

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereDefinition[] spheres;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CullingGroup cullingGroup;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x8C4F90", Offset = "0x8C4F90", VA = "0x8C4F90")]
	public void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x8C5148", Offset = "0x8C5148", VA = "0x8C5148")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x8C517C", Offset = "0x8C517C", VA = "0x8C517C")]
	private void StateChangedMethod(CullingGroupEvent evt)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x8C51F4", Offset = "0x8C51F4", VA = "0x8C51F4")]
	public CrowdCullingGroup()
	{
	}
}
[Token(Token = "0x200000C")]
public class DamageDisplayController : MonoBehaviour
{
	[Token(Token = "0x20000B8")]
	public class DamageText
	{
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextMeshProUGUI text;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isFree;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float lifetime;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float travelLifetime;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 startPosition;

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x8C5488", Offset = "0x8C5488", VA = "0x8C5488")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x8C5A54", Offset = "0x8C5A54", VA = "0x8C5A54")]
		public void Deinitialize()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x8C5480", Offset = "0x8C5480", VA = "0x8C5480")]
		public DamageText()
		{
		}
	}

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<DamageText> poolList;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<DamageText> textQueue;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLifetime;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int textSize;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color color;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int maxSlots;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float offsetSize;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float travelRate;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TMP_FontAsset font;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextAlignmentOptions alignment;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int slotsInUse;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x8C527C", Offset = "0x8C527C", VA = "0x8C527C")]
	private static DamageText GrabObjectFromPool()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x8C54C4", Offset = "0x8C54C4", VA = "0x8C54C4")]
	public void AddText(string text, Vector3 startPosition)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x8C58D8", Offset = "0x8C58D8", VA = "0x8C58D8")]
	public void ClearAllEntries()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x8C5784", Offset = "0x8C5784", VA = "0x8C5784")]
	public void PrepText(DamageText damageObject, string textValue, Vector3 startPosition)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x8C5914", Offset = "0x8C5914", VA = "0x8C5914")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x8C59CC", Offset = "0x8C59CC", VA = "0x8C59CC")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x8C5608", Offset = "0x8C5608", VA = "0x8C5608")]
	private void Dequeue()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x8C5698", Offset = "0x8C5698", VA = "0x8C5698")]
	private void MoveUpRestingSlots()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x8C5A90", Offset = "0x8C5A90", VA = "0x8C5A90")]
	public DamageDisplayController()
	{
	}
}
[Token(Token = "0x200000D")]
public class DisplayVersion : MonoBehaviour
{
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x8C5AD8", Offset = "0x8C5AD8", VA = "0x8C5AD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x8C5B70", Offset = "0x8C5B70", VA = "0x8C5B70")]
	public DisplayVersion()
	{
	}
}
[Token(Token = "0x200000E")]
public class DungeonScreams : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] screams;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource source;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x8C5E04", Offset = "0x8C5E04", VA = "0x8C5E04")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x8C5E5C", Offset = "0x8C5E5C", VA = "0x8C5E5C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x8C5F38", Offset = "0x8C5F38", VA = "0x8C5F38")]
	public DungeonScreams()
	{
	}
}
[Token(Token = "0x200000F")]
public class ElbowTarget : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject attachTo;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 position;

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x8C5F40", Offset = "0x8C5F40", VA = "0x8C5F40")]
	private void Start()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x8C5FB0", Offset = "0x8C5FB0", VA = "0x8C5FB0")]
	private void Update()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x8C5FB4", Offset = "0x8C5FB4", VA = "0x8C5FB4")]
	public ElbowTarget()
	{
	}
}
[Token(Token = "0x2000010")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CE1D4", Offset = "0x6CE1D4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CE1D4", Offset = "0x6CE1D4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CE1D4", Offset = "0x6CE1D4")]
public class FaceBlocker : MonoBehaviour
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material mat;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CapsuleCollider capsule;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshFilter meshFilter;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x8C62A4", Offset = "0x8C62A4", VA = "0x8C62A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x8C6314", Offset = "0x8C6314", VA = "0x8C6314")]
	private void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x8C63F4", Offset = "0x8C63F4", VA = "0x8C63F4")]
	public FaceBlocker()
	{
	}
}
[Token(Token = "0x2000011")]
public class FlipPlayspaceButton : MonoBehaviour
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int type;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Button button;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Text text;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FlipPlayspaceButton[] buttons;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x8C68FC", Offset = "0x8C68FC", VA = "0x8C68FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x8C69A0", Offset = "0x8C69A0", VA = "0x8C69A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x8C6AE4", Offset = "0x8C6AE4", VA = "0x8C6AE4")]
	private void OnTriggerEnter()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x8C6A14", Offset = "0x8C6A14", VA = "0x8C6A14")]
	public void Press()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x8C6B8C", Offset = "0x8C6B8C", VA = "0x8C6B8C")]
	public void Depress()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x8C6C44", Offset = "0x8C6C44", VA = "0x8C6C44")]
	public FlipPlayspaceButton()
	{
	}
}
[Token(Token = "0x2000012")]
public class HideOnConditions : MonoBehaviour
{
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] showConditions;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] hideConditions;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x8C6C4C", Offset = "0x8C6C4C", VA = "0x8C6C4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x8C6D60", Offset = "0x8C6D60", VA = "0x8C6D60")]
	public HideOnConditions()
	{
	}
}
[Token(Token = "0x2000013")]
[ExecuteInEditMode]
public class BWEffect : MonoBehaviour
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CE51C", Offset = "0x6CE51C")]
	public float intensity;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x17000011")]
	private Material m_Mat
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x8C49E4", Offset = "0x8C49E4", VA = "0x8C49E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x8C4AA8", Offset = "0x8C4AA8", VA = "0x8C4AA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x8C4AAC", Offset = "0x8C4AAC", VA = "0x8C4AAC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x8C4BAC", Offset = "0x8C4BAC", VA = "0x8C4BAC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x8C4C5C", Offset = "0x8C4C5C", VA = "0x8C4C5C")]
	public BWEffect()
	{
	}
}
[Token(Token = "0x2000014")]
[ExecuteInEditMode]
public class DoubleVisionEffect : MonoBehaviour
{
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CE534", Offset = "0x6CE534")]
	public float intensity;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x17000012")]
	private Material m_Mat
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x8C5B78", Offset = "0x8C5B78", VA = "0x8C5B78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x8C5C3C", Offset = "0x8C5C3C", VA = "0x8C5C3C")]
	private void Update()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x8C5C40", Offset = "0x8C5C40", VA = "0x8C5C40")]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x8C5D4C", Offset = "0x8C5D4C", VA = "0x8C5D4C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x8C5DFC", Offset = "0x8C5DFC", VA = "0x8C5DFC")]
	public DoubleVisionEffect()
	{
	}
}
[Token(Token = "0x2000015")]
[ExecuteInEditMode]
public class EyesClosedEffect : MonoBehaviour
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CE54C", Offset = "0x6CE54C")]
	public float intensity;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x17000013")]
	private Material m_Mat
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x8C5FBC", Offset = "0x8C5FBC", VA = "0x8C5FBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x8C6080", Offset = "0x8C6080", VA = "0x8C6080")]
	private void Update()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x8C6084", Offset = "0x8C6084", VA = "0x8C6084")]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x8C61EC", Offset = "0x8C61EC", VA = "0x8C61EC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x8C629C", Offset = "0x8C629C", VA = "0x8C629C")]
	public EyesClosedEffect()
	{
	}
}
[Token(Token = "0x2000016")]
[ExecuteInEditMode]
public class FadeToBlackEffect : MonoBehaviour
{
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CE564", Offset = "0x6CE564")]
	public float intensity;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x17000014")]
	private Material m_Mat
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x8C63FC", Offset = "0x8C63FC", VA = "0x8C63FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x8C64C0", Offset = "0x8C64C0", VA = "0x8C64C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x8C64C4", Offset = "0x8C64C4", VA = "0x8C64C4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x8C65C4", Offset = "0x8C65C4", VA = "0x8C65C4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x8C6674", Offset = "0x8C6674", VA = "0x8C6674")]
	public FadeToBlackEffect()
	{
	}
}
[Token(Token = "0x2000017")]
[ExecuteInEditMode]
public class FadeToWhiteEffect : MonoBehaviour
{
	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CE57C", Offset = "0x6CE57C")]
	public float intensity;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x17000015")]
	private Material m_Mat
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x8C667C", Offset = "0x8C667C", VA = "0x8C667C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x8C6740", Offset = "0x8C6740", VA = "0x8C6740")]
	private void Update()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x8C6744", Offset = "0x8C6744", VA = "0x8C6744")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x8C6844", Offset = "0x8C6844", VA = "0x8C6844")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x8C68F4", Offset = "0x8C68F4", VA = "0x8C68F4")]
	public FadeToWhiteEffect()
	{
	}
}
[Token(Token = "0x2000018")]
[ExecuteInEditMode]
public class HitToHeadEffect : MonoBehaviour
{
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CE594", Offset = "0x6CE594")]
	public float intensity;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float TimeX;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector4 ScreenResolution;

	[Token(Token = "0x17000016")]
	private Material m_Mat
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x8C6D68", Offset = "0x8C6D68", VA = "0x8C6D68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x8C6E2C", Offset = "0x8C6E2C", VA = "0x8C6E2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x8C6E30", Offset = "0x8C6E30", VA = "0x8C6E30")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x8C701C", Offset = "0x8C701C", VA = "0x8C701C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x8C70CC", Offset = "0x8C70CC", VA = "0x8C70CC")]
	public HitToHeadEffect()
	{
	}
}
[Token(Token = "0x2000019")]
[ExecuteInEditMode]
public class VignetteEffect : MonoBehaviour
{
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CE5AC", Offset = "0x6CE5AC")]
	public float intensity;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x17000017")]
	private Material m_Mat
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1378010", Offset = "0x1378010", VA = "0x1378010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x13780D4", Offset = "0x13780D4", VA = "0x13780D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x13780D8", Offset = "0x13780D8", VA = "0x13780D8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x13781D8", Offset = "0x13781D8", VA = "0x13781D8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1378288", Offset = "0x1378288", VA = "0x1378288")]
	public VignetteEffect()
	{
	}
}
[Token(Token = "0x200001A")]
public class LIVLoader : MonoBehaviour
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform stage;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform stageTransform;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Camera HMDCamera;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LayerMask spectatorLayerMask;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Camera MRCameraPrefab;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x8C70DC", Offset = "0x8C70DC", VA = "0x8C70DC")]
	public LIVLoader()
	{
	}
}
[Token(Token = "0x200001B")]
public class LevelLoader : MonoBehaviour
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static LevelLoader instance;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader canvasShader;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ShaderVariantCollection shaderCollectionSI;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ShaderVariantCollection shaderCollectionMV;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D defaultFront;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D defaultBack;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D defaultRight;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D defaultLeft;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture2D defaultTop;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture2D defaultBottom;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture2D loadingScreen;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Cubemap defaultCubemap;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x8C70E4", Offset = "0x8C70E4", VA = "0x8C70E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x8C71D0", Offset = "0x8C71D0", VA = "0x8C71D0")]
	private void Start()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x8C48D4", Offset = "0x8C48D4", VA = "0x8C48D4")]
	public static void LoadScene(string sceneName)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x8C7204", Offset = "0x8C7204", VA = "0x8C7204")]
	private void LoadSceneInstance(string sceneName)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x8C72D0", Offset = "0x8C72D0", VA = "0x8C72D0")]
	public LevelLoader()
	{
	}
}
[Token(Token = "0x200001C")]
public class LightFlicker : MonoBehaviour
{
	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float flickerChance;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float unflickerChance;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color flickerColor;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float initialIntensity;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool flickering;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color normalColor;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MeshRenderer mesh;

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x8C72D8", Offset = "0x8C72D8", VA = "0x8C72D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x8C7360", Offset = "0x8C7360", VA = "0x8C7360")]
	private void Update()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x8C743C", Offset = "0x8C743C", VA = "0x8C743C")]
	public LightFlicker()
	{
	}
}
[Token(Token = "0x200001D")]
[ExecuteAlways]
public class LightmapInfoSetter : MonoBehaviour
{
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int lightmapIndex;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 lightmapScaleOffset;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer r;

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x8C747C", Offset = "0x8C747C", VA = "0x8C747C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x8C74FC", Offset = "0x8C74FC", VA = "0x8C74FC")]
	public LightmapInfoSetter()
	{
	}
}
[Token(Token = "0x200001E")]
public class LoseStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x8C7504", Offset = "0x8C7504", VA = "0x8C7504", Slot = "9")]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x8C7598", Offset = "0x8C7598", VA = "0x8C7598")]
	public LoseStateMachine()
	{
	}
}
[Token(Token = "0x200001F")]
public class MRCCameraFlagger : MonoBehaviour
{
	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool init;

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x8C75A0", Offset = "0x8C75A0", VA = "0x8C75A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x8C7620", Offset = "0x8C7620", VA = "0x8C7620")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x8C7684", Offset = "0x8C7684", VA = "0x8C7684")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x8C76E8", Offset = "0x8C76E8", VA = "0x8C76E8")]
	public MRCCameraFlagger()
	{
	}
}
[Token(Token = "0x2000020")]
public class NormalDistributionGenetrator : MonoBehaviour
{
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x8C76F0", Offset = "0x8C76F0", VA = "0x8C76F0")]
	public static float Generate(float mu, float s)
	{
		return default(float);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x8C779C", Offset = "0x8C779C", VA = "0x8C779C")]
	public NormalDistributionGenetrator()
	{
	}
}
[Token(Token = "0x2000021")]
public class PMFixer : MonoBehaviour
{
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PuppetMaster pm;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int frameCounter;

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x8C77A4", Offset = "0x8C77A4", VA = "0x8C77A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x8C77FC", Offset = "0x8C77FC", VA = "0x8C77FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x8C7848", Offset = "0x8C7848", VA = "0x8C7848")]
	public PMFixer()
	{
	}
}
[Token(Token = "0x2000022")]
public class PMMaker : MonoBehaviour
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator animator;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int frameSkip;

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x8C7850", Offset = "0x8C7850", VA = "0x8C7850")]
	private void Start()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8C78A8", Offset = "0x8C78A8", VA = "0x8C78A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x8C7984", Offset = "0x8C7984", VA = "0x8C7984")]
	public PMMaker()
	{
	}
}
[Token(Token = "0x2000023")]
public class ParentToGameObject : MonoBehaviour
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform parentObject;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rotateWith;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 localPosition;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 localRotation;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool doRotate;

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x8C798C", Offset = "0x8C798C", VA = "0x8C798C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x8C7A78", Offset = "0x8C7A78", VA = "0x8C7A78")]
	private void Update()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x8C7AD8", Offset = "0x8C7AD8", VA = "0x8C7AD8")]
	public ParentToGameObject()
	{
	}
}
[Token(Token = "0x2000024")]
public class PlayAreaRotationTrigger : MonoBehaviour
{
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x8C9990", Offset = "0x8C9990", VA = "0x8C9990")]
	public PlayAreaRotationTrigger()
	{
	}
}
[Token(Token = "0x2000025")]
public class PlayerHeadPosition : MonoBehaviour
{
	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject followObject;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x8C9AEC", Offset = "0x8C9AEC", VA = "0x8C9AEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x8C9B84", Offset = "0x8C9B84", VA = "0x8C9B84")]
	public PlayerHeadPosition()
	{
	}
}
[Token(Token = "0x2000026")]
public class PlayerBodyTest : MonoBehaviour
{
	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform leftHand;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform rightHand;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x8C9998", Offset = "0x8C9998", VA = "0x8C9998", Slot = "4")]
	public virtual void OnAnimatorIK()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x8C9AE4", Offset = "0x8C9AE4", VA = "0x8C9AE4")]
	public PlayerBodyTest()
	{
	}
}
[Token(Token = "0x2000027")]
public class PostCelebrateStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x8C9B8C", Offset = "0x8C9B8C", VA = "0x8C9B8C", Slot = "9")]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x8C9C3C", Offset = "0x8C9C3C", VA = "0x8C9C3C")]
	public PostCelebrateStateMachine()
	{
	}
}
[Token(Token = "0x2000028")]
public class PumpkinLid : MonoBehaviour
{
	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool sleeping;

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x8C9C44", Offset = "0x8C9C44", VA = "0x8C9C44")]
	private void Awake()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x8C9C9C", Offset = "0x8C9C9C", VA = "0x8C9C9C")]
	private void OnChunkNotification()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x8C9CDC", Offset = "0x8C9CDC", VA = "0x8C9CDC")]
	public PumpkinLid()
	{
	}
}
[Token(Token = "0x2000029")]
public class ResonanceAudioPositionFixer : MonoBehaviour
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource _audioSource;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _needsToReset;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool _init;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x8C9CEC", Offset = "0x8C9CEC", VA = "0x8C9CEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x8C9D44", Offset = "0x8C9D44", VA = "0x8C9D44")]
	private void Update()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x8C9DAC", Offset = "0x8C9DAC", VA = "0x8C9DAC")]
	public ResonanceAudioPositionFixer()
	{
	}
}
[Token(Token = "0x200002A")]
public class RingController : MonoBehaviour
{
	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static RingController instance;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float halfRingSizeX;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float halfRingSizeZ;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform redCorner;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform blueCorner;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform[] neutralCorners;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform[] refereePositions;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform announcerPosition;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform redCornerWinnerPosition;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform blueCornerWinnerPosition;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x8C9DB4", Offset = "0x8C9DB4", VA = "0x8C9DB4")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x8C9E08", Offset = "0x8C9E08", VA = "0x8C9E08")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x8C9E58", Offset = "0x8C9E58", VA = "0x8C9E58")]
	public RingController()
	{
	}
}
[Token(Token = "0x200002B")]
public class Rotator : MonoBehaviour
{
	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float rate;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 eulerRotation;

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x8C9E68", Offset = "0x8C9E68", VA = "0x8C9E68")]
	private void Start()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8C9EC4", Offset = "0x8C9EC4", VA = "0x8C9EC4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x8C9FB8", Offset = "0x8C9FB8", VA = "0x8C9FB8")]
	public Rotator()
	{
	}
}
[Token(Token = "0x200002C")]
public class ShowOnDateRange : MonoBehaviour
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject objectToEnable;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int startMonth;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int startDay;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int endMonth;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int endDay;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x8CA52C", Offset = "0x8CA52C", VA = "0x8CA52C")]
	public void Awake()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x8CA620", Offset = "0x8CA620", VA = "0x8CA620")]
	public ShowOnDateRange()
	{
	}
}
[Token(Token = "0x200002D")]
[ExecuteInEditMode]
public class VRConfig : MonoBehaviour
{
	[Token(Token = "0x40000A2")]
	private const float defaultRenderScale = 1f;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static VRConfig instance;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CE5C4", Offset = "0x6CE5C4")]
	public int CPULevel;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int GPULevel;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CE5FC", Offset = "0x6CE5FC")]
	public int FFRLevel;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool overrideRenderScale;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CE634", Offset = "0x6CE634")]
	public float renderScale;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CE650", Offset = "0x6CE650")]
	public bool hideCoachDuringRounds;

	[Token(Token = "0x17000018")]
	public static bool shouldHideCoachDuringRounds
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x13733F8", Offset = "0x13733F8", VA = "0x13733F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1377470", Offset = "0x1377470", VA = "0x1377470")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x13774DC", Offset = "0x13774DC", VA = "0x13774DC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x137752C", Offset = "0x137752C", VA = "0x137752C")]
	private void Start()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x13775B4", Offset = "0x13775B4", VA = "0x13775B4")]
	public VRConfig()
	{
	}
}
[Token(Token = "0x200002E")]
public class VRInputModule : StandaloneInputModule
{
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static VRInputModule instance;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private GameObject currentDragging;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject currentPointedAt;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Ray customControllerRay;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool pressedDown;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
	private bool pressedLastFrame;

	[Token(Token = "0x17000019")]
	public static VRInputModule Instance
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1377EE0", Offset = "0x1377EE0", VA = "0x1377EE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1377F8C", Offset = "0x1377F8C", VA = "0x1377F8C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public static Ray CustomControllerRay
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x13758FC", Offset = "0x13758FC", VA = "0x13758FC")]
		get
		{
			return default(Ray);
		}
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1374FAC", Offset = "0x1374FAC", VA = "0x1374FAC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public static bool CustomControllerButtonDown
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1377FE0", Offset = "0x1377FE0", VA = "0x1377FE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1374FFC", Offset = "0x1374FFC", VA = "0x1374FFC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public GameObject CurrentPointedAt
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1378000", Offset = "0x1378000", VA = "0x1378000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x13775D4", Offset = "0x13775D4", VA = "0x13775D4", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x13777F0", Offset = "0x13777F0", VA = "0x13777F0", Slot = "31")]
	protected virtual void ProcessDownRelease(PointerEventData eventData, bool down, bool released)
	{
	}

	[Token(Token = "0x60000A2")]
	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1378008", Offset = "0x1378008", VA = "0x1378008")]
	public VRInputModule()
	{
	}
}
[Token(Token = "0x200002F")]
public class Talkbox : MonoBehaviour
{
	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LipSyncData[] clips;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LipSync mouth;

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x8CA628", Offset = "0x8CA628", VA = "0x8CA628")]
	[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6CFD10", Offset = "0x6CFD10")]
	public void Talk()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x8CA6A8", Offset = "0x8CA6A8", VA = "0x8CA6A8")]
	public Talkbox()
	{
	}
}
namespace Sealost
{
	[Token(Token = "0x2000030")]
	public class TonemapManager : MonoBehaviour
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader tonemapShader;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float contrast;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float shoulder;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE688", Offset = "0x6CE688")]
		public float HDRMax;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE6C0", Offset = "0x6CE6C0")]
		public float midIn;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CE6F8", Offset = "0x6CE6F8")]
		public float midOut;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float crosstalk;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float saturation;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float crossSaturation;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D colorGradeLUT;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture lut;

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x8C9FC0", Offset = "0x8C9FC0", VA = "0x8C9FC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x8C9FC4", Offset = "0x8C9FC4", VA = "0x8C9FC4")]
		private void SetTonemapValues()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x8CA2B4", Offset = "0x8CA2B4", VA = "0x8CA2B4")]
		private float ColToneB(float hdrMax, float contrast, float shoulder, float midIn, float midOut)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x8CA400", Offset = "0x8CA400", VA = "0x8CA400")]
		private float ColToneC(float hdrMax, float contrast, float shoulder, float midIn, float midOut)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x8CA510", Offset = "0x8CA510", VA = "0x8CA510")]
		public TonemapManager()
		{
		}
	}
}
namespace TotF
{
	[Token(Token = "0x2000031")]
	public class GhostEnemyController : EnemyController
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE730", Offset = "0x6CE730")]
		public Renderer[] ghostRenderers;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE768", Offset = "0x6CE768")]
		public float corporealValue;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D4")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE7A0", Offset = "0x6CE7A0")]
		public float incorporealValue;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		private Collider[] ghostColliders;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x8F7C84", Offset = "0x8F7C84", VA = "0x8F7C84", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x8F7E1C", Offset = "0x8F7E1C", VA = "0x8F7E1C", Slot = "54")]
		public override void StartPunch(string value = "", float predictedContactTime = 0f)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x8F7F84", Offset = "0x8F7F84", VA = "0x8F7F84", Slot = "55")]
		public override void PunchEnded(bool pauseOffense = true)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x8F7E5C", Offset = "0x8F7E5C", VA = "0x8F7E5C")]
		private void Corporeal()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x8F7CF4", Offset = "0x8F7CF4", VA = "0x8F7CF4")]
		private void Incorporeal()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x8F7FB0", Offset = "0x8F7FB0", VA = "0x8F7FB0")]
		private void EnableAllColliders()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x8F8020", Offset = "0x8F8020", VA = "0x8F8020")]
		private void DisableAllColliders()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x8F8090", Offset = "0x8F8090", VA = "0x8F8090")]
		public GhostEnemyController()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class TrainerController : MonoBehaviour
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float scowlRange;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float cheerChance;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float cheerTime;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float gettingLookedAtReactionTime;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float reactionAnimationTime;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float reactionCooldownTime;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float playerLookAngleForReaction;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform head;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LookAtIK lik;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayerController player;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Animator animator;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int hitLayerIndex;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int hitLayerIndex1;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int hitLayerIndex2;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool doBlinkCycle;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool blinking;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float blinkTimer;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected float expressPainTarget;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected float expressPainLevel;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		protected float expressConcernTarget;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected float expressConcernLevel;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public VertexSkinnedMeshRenderer bodyMesh;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public EnemyBlendshapes blendshapes;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string[] cheers;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string[] reactions;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool cheering;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float cheerTimer;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool foundPlayer;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		private bool isReacting;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		private bool isReactingCooldown;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float gettingLookedAtTimer;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float reactionTimer;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float reactionCooldownTimer;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TrainerController instance;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1373218", Offset = "0x1373218", VA = "0x1373218")]
		public static void Cheer()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1373350", Offset = "0x1373350", VA = "0x1373350")]
		public static void CheerSometimes()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1373500", Offset = "0x1373500", VA = "0x1373500")]
		public static void Hide()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x13735BC", Offset = "0x13735BC", VA = "0x13735BC")]
		public static void Show()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x13732B8", Offset = "0x13732B8", VA = "0x13732B8")]
		private void CheerLocal()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x13734A4", Offset = "0x13734A4", VA = "0x13734A4")]
		private void CheerSometimesLocal()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1373670", Offset = "0x1373670", VA = "0x1373670")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x13736C0", Offset = "0x13736C0", VA = "0x13736C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1373788", Offset = "0x1373788", VA = "0x1373788")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1373934", Offset = "0x1373934", VA = "0x1373934")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1373C50", Offset = "0x1373C50", VA = "0x1373C50")]
		private void React()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1374150", Offset = "0x1374150", VA = "0x1374150", Slot = "4")]
		protected virtual void StartBlinkCycle()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1374188", Offset = "0x1374188", VA = "0x1374188", Slot = "5")]
		protected virtual void StopBlinkCycle()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1373CF0", Offset = "0x1373CF0", VA = "0x1373CF0")]
		protected void HandleBlink()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1374198", Offset = "0x1374198", VA = "0x1374198", Slot = "6")]
		protected virtual void MakeBlink()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1374234", Offset = "0x1374234", VA = "0x1374234", Slot = "7")]
		protected virtual void StopBlink()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1374240", Offset = "0x1374240", VA = "0x1374240")]
		public void ExpressPain(float targetLevel)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1374248", Offset = "0x1374248", VA = "0x1374248")]
		public void ExpressConcern(float targetLevel)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1373D80", Offset = "0x1373D80", VA = "0x1373D80")]
		public void UpdateExpressions()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x13737B4", Offset = "0x13737B4", VA = "0x13737B4")]
		private void LoadBlendshapeIndexes()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1374368", Offset = "0x1374368", VA = "0x1374368")]
		private void FindBlendshapeIndexes(ref BlendshapeDefinition[] blendshapeDefinitions)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x137448C", Offset = "0x137448C", VA = "0x137448C")]
		public void ReceiveHurtboxCollision(float force, Hurtbox hurtbox, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x13749F4", Offset = "0x13749F4", VA = "0x13749F4")]
		protected void HurtboxCollisionAudioResult(float force, Hurtbox hurtbox, Collision collision)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x13744D4", Offset = "0x13744D4", VA = "0x13744D4")]
		protected void HurtboxCollisionVisualResult(float force, Hurtbox hurtbox, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1374250", Offset = "0x1374250", VA = "0x1374250")]
		private void SetPainBlendshape(float value)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1374A94", Offset = "0x1374A94", VA = "0x1374A94")]
		private void SetBlendShapeWeight(int index, float value)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x13741A8", Offset = "0x13741A8", VA = "0x13741A8")]
		private void SetBlinkBlendshape(float value)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x13742DC", Offset = "0x13742DC", VA = "0x13742DC")]
		private void SetFlinchBlendshape(float value)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1373F0C", Offset = "0x1373F0C", VA = "0x1373F0C")]
		public void HandleFlinch()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1374ABC", Offset = "0x1374ABC", VA = "0x1374ABC")]
		public TrainerController()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class ZombieEnemyController : EnemyController
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE7D8", Offset = "0x6CE7D8")]
		public float shakeoffDamageThreshold;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5CC")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE810", Offset = "0x6CE810")]
		public float shakeoffDamageMax;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE848", Offset = "0x6CE848")]
		public float biteDamage;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D4")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE880", Offset = "0x6CE880")]
		public float kdLightsOutDamageThresholdOverride;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE8B8", Offset = "0x6CE8B8")]
		public float swingRange;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5DC")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE8F0", Offset = "0x6CE8F0")]
		public float biteStartRange;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE928", Offset = "0x6CE928")]
		public float biteStopRange;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E4")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE960", Offset = "0x6CE960")]
		public float biteDistance;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CE998", Offset = "0x6CE998")]
		public int hitpoints;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CE9D0", Offset = "0x6CE9D0")]
		public LipSyncData[] biteSounds;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		private bool isBeingKnockedBack;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F9")]
		private bool isAttacking;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5FA")]
		private bool isBiting;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5FC")]
		private float knockbackTimer;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		private float biteTimer;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x604")]
		private float biteTime;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		private float actualBiteTimer;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60C")]
		private bool isActuallyBiting;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		private float biteTransitionTime;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x614")]
		private float outOfRangeTimer;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		private float outOfRangeTime;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1376628", Offset = "0x1376628", VA = "0x1376628", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x137665C", Offset = "0x137665C", VA = "0x137665C", Slot = "15")]
		protected override void HurtboxCollisionVisualResult(float damage, float force, bool wasKnockedDown, Hurtbox hurtbox, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x13769F4", Offset = "0x13769F4", VA = "0x13769F4", Slot = "20")]
		protected override void Knockdown(Hurtbox hurtbox, Hitbox hitbox)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1376B30", Offset = "0x1376B30", VA = "0x1376B30")]
		public void OnDeath()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1376B50", Offset = "0x1376B50", VA = "0x1376B50")]
		public void StartBiteSound()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1376BE0", Offset = "0x1376BE0", VA = "0x1376BE0")]
		public void StopBiteSound()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1376C20", Offset = "0x1376C20", VA = "0x1376C20")]
		public void StartBiting()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1376B18", Offset = "0x1376B18", VA = "0x1376B18")]
		public void StopBiting()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1376CB4", Offset = "0x1376CB4", VA = "0x1376CB4", Slot = "63")]
		protected override void HandleAttackBehavior()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1376E90", Offset = "0x1376E90", VA = "0x1376E90", Slot = "60")]
		protected override void HandlePursueBehavior()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x13770DC", Offset = "0x13770DC", VA = "0x13770DC")]
		private bool DoAttack()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x137706C", Offset = "0x137706C", VA = "0x137706C")]
		private void StopZombieAttack()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1377128", Offset = "0x1377128", VA = "0x1377128")]
		private void ZombieAttack()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1377258", Offset = "0x1377258", VA = "0x1377258")]
		public void RefreshPunch(string value = "")
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x137726C", Offset = "0x137726C", VA = "0x137726C", Slot = "61")]
		protected override void HandleKeepAwayBehavior()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1377280", Offset = "0x1377280", VA = "0x1377280", Slot = "62")]
		protected override void HandleRetreatBehavior()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1377294", Offset = "0x1377294", VA = "0x1377294", Slot = "59")]
		protected override void SetBehavior(BehaviorMode newMode)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1377398", Offset = "0x1377398", VA = "0x1377398", Slot = "56")]
		public override void PunchEnded(string endedPunchName)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1377038", Offset = "0x1377038", VA = "0x1377038")]
		public bool IsInSwingRange()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1376E74", Offset = "0x1376E74", VA = "0x1376E74")]
		public bool IsInBiteRange()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1376E58", Offset = "0x1376E58", VA = "0x1376E58")]
		public bool IsOutsideBiteRange()
		{
			return default(bool);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x13773C0", Offset = "0x13773C0", VA = "0x13773C0")]
		public ZombieEnemyController()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class AnnouncerController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public struct ClipGroup
		{
			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LipSyncData[] clips;
		}

		[Token(Token = "0x20000BA")]
		private enum ClipAction
		{
			[Token(Token = "0x40007A2")]
			NoAction,
			[Token(Token = "0x40007A3")]
			BlueWin,
			[Token(Token = "0x40007A4")]
			RedWin,
			[Token(Token = "0x40007A5")]
			Draw
		}

		[Token(Token = "0x20000BB")]
		private struct ClipQueueItem
		{
			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LipSyncData clip;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float delay;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ClipAction clipAction;

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x8CAC24", Offset = "0x8CAC24", VA = "0x8CAC24")]
			public ClipQueueItem(LipSyncData setClip, float setDelay = 0f, ClipAction setClipAction = ClipAction.NoAction)
			{
			}
		}

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LipSyncData[] introClips;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LipSyncData[] judgementUnanimousClips;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LipSyncData[] judgementMajorityClips;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LipSyncData[] judgementSplitClips;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LipSyncData[] judgementDrawClips;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LipSyncData[] judgementBlueClips;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LipSyncData[] judgementRedClips;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ClipGroup[] endAtRoundClips;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LipSyncData[] koClips;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LipSyncData[] tkoClips;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LipSyncData[] koRedClips;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LipSyncData[] koBlueClips;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private LipSync mouth;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioSource mouthAudioSource;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playQueue;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float delayTimer;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AnnouncerController instance;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<ClipQueueItem> clipQueue;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int clipQueueIndex;

		[Token(Token = "0x1700001D")]
		public static AnnouncerController Instance
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x8CA6B0", Offset = "0x8CA6B0", VA = "0x8CA6B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x8CA700", Offset = "0x8CA700", VA = "0x8CA700")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x8CA7AC", Offset = "0x8CA7AC", VA = "0x8CA7AC")]
		public void StopTalking()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x8CA7CC", Offset = "0x8CA7CC", VA = "0x8CA7CC")]
		public void StartWinnerAnnouncement()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x8CAC34", Offset = "0x8CAC34", VA = "0x8CAC34")]
		private void PlayNextClipInQueue()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x8CAD40", Offset = "0x8CAD40", VA = "0x8CAD40")]
		public void Update()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x8CADB4", Offset = "0x8CADB4", VA = "0x8CADB4")]
		public void GestureRight()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x8CAE10", Offset = "0x8CAE10", VA = "0x8CAE10")]
		public void GestureRightActions()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x8CAFC0", Offset = "0x8CAFC0", VA = "0x8CAFC0")]
		public void GestureLeft()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x8CB01C", Offset = "0x8CB01C", VA = "0x8CB01C")]
		public void GestureLeftActions()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x8CB07C", Offset = "0x8CB07C", VA = "0x8CB07C")]
		public AnnouncerController()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class AudienceBakeResult : MonoBehaviour
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x8CB084", Offset = "0x8CB084", VA = "0x8CB084")]
		public AudienceBakeResult()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class AudienceController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public struct CheerData
		{
			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int offset;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int maxIndex;
		}

		[Token(Token = "0x20000BD")]
		private struct Animator
		{
			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isCheering;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float cheerTimer;
		}

		[Token(Token = "0x400010C")]
		public const int NUMBER_OF_ANIMATORS = 32;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Bounds bounds;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Material material;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float fps;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float variance;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float crossfadeTime;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CheerData[] cheers;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] maxDurations;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ushort[] indexData;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator[] animators;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector4[] animations;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ComputeBuffer animationBuffer;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GraphicsBuffer indexBuffer;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int animatorCount;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float cheerCounter;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int uploadIndex;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x8CB08C", Offset = "0x8CB08C", VA = "0x8CB08C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x8CB22C", Offset = "0x8CB22C", VA = "0x8CB22C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x8CB2D8", Offset = "0x8CB2D8", VA = "0x8CB2D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x8CB320", Offset = "0x8CB320", VA = "0x8CB320")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x8CB390", Offset = "0x8CB390", VA = "0x8CB390")]
		public void UpdateCheering(float cheerRate)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x8CB440", Offset = "0x8CB440", VA = "0x8CB440")]
		private void Cheer(int animatorIndex)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x8CB59C", Offset = "0x8CB59C", VA = "0x8CB59C")]
		public void Cheer()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x8CB5A8", Offset = "0x8CB5A8", VA = "0x8CB5A8")]
		public ComputeBuffer GetAnimationBuffer()
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x8CB5B0", Offset = "0x8CB5B0", VA = "0x8CB5B0")]
		public int GetAnimationDataSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x8CB5D0", Offset = "0x8CB5D0", VA = "0x8CB5D0")]
		public GraphicsBuffer GetIndexBuffer()
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x8CB5D8", Offset = "0x8CB5D8", VA = "0x8CB5D8")]
		public AudienceController()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class AudienceGenerator : MonoBehaviour
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudienceController[] audienceData;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEA28", Offset = "0x6CEA28")]
		private AudienceController[] <audience>k__BackingField;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEA38", Offset = "0x6CEA38")]
		private int <audienceLayer>k__BackingField;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudienceGroup[] groups;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEA48", Offset = "0x6CEA48")]
		private static bool <drawAudience>k__BackingField;

		[Token(Token = "0x1700001E")]
		public AudienceController[] audience
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x8CB5FC", Offset = "0x8CB5FC", VA = "0x8CB5FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFD20", Offset = "0x6CFD20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x8CB604", Offset = "0x8CB604", VA = "0x8CB604")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFD30", Offset = "0x6CFD30")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public int audienceLayer
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x8CB60C", Offset = "0x8CB60C", VA = "0x8CB60C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFD40", Offset = "0x6CFD40")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x8CB614", Offset = "0x8CB614", VA = "0x8CB614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFD50", Offset = "0x6CFD50")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public static bool drawAudience
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x8CB61C", Offset = "0x8CB61C", VA = "0x8CB61C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFD60", Offset = "0x6CFD60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x8CB66C", Offset = "0x8CB66C", VA = "0x8CB66C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFD70", Offset = "0x6CFD70")]
			private set
			{
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x8CB6C4", Offset = "0x8CB6C4", VA = "0x8CB6C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x8CB94C", Offset = "0x8CB94C", VA = "0x8CB94C")]
		public AudienceGenerator()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class AudienceGroup : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		private struct InstanceData
		{
			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float fps;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int palette;
		}

		[Token(Token = "0x20000BF")]
		protected struct MinMaxPosition
		{
			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float minX;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float minY;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float minZ;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxX;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float maxY;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maxZ;
		}

		[Token(Token = "0x20000C0")]
		protected struct BufferArgs
		{
			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static int size;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int indexCountPerInstance;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int instanceCount;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int startIndexLocation;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int baseVertexLocation;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int startInstanceLocation;
		}

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected MaterialPropertyBlock[] props;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ComputeBuffer bufferWithArgs;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<AudienceGroup> _groups;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected bool init;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEA58", Offset = "0x6CEA58")]
		private AudienceGenerator <parent>k__BackingField;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Texture2D[] instanceDataTextures;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Bounds[] bounds;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ComputeBuffer[] matrixBuffers;

		[Token(Token = "0x17000021")]
		public static List<AudienceGroup> groups
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x8CB954", Offset = "0x8CB954", VA = "0x8CB954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public AudienceGenerator parent
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x8CB9E4", Offset = "0x8CB9E4", VA = "0x8CB9E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFD80", Offset = "0x6CFD80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x8CB9EC", Offset = "0x8CB9EC", VA = "0x8CB9EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFD90", Offset = "0x6CFD90")]
			set
			{
			}
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x8CB9F4", Offset = "0x8CB9F4", VA = "0x8CB9F4", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x8CBAF4", Offset = "0x8CBAF4", VA = "0x8CBAF4", Slot = "5")]
		public virtual void Initialize(AudienceGenerator generator)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x8CC51C", Offset = "0x8CC51C", VA = "0x8CC51C", Slot = "6")]
		protected virtual MinMaxPosition[] CreateMatrixSorter(ref List<Matrix4x4>[] matrixSorter)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x8CCA2C", Offset = "0x8CCA2C", VA = "0x8CCA2C", Slot = "7")]
		public virtual void Draw(Camera camera, Vector3 forward)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x8CCCDC", Offset = "0x8CCCDC", VA = "0x8CCCDC")]
		public AudienceGroup()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class AudioManager : MonoBehaviour
	{
		[Token(Token = "0x4000129")]
		private const float QuietSoundCutoffForce = 1584f;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioManager instance;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioMixerGroup ambientSound;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioMixerGroup externalSound;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioMixerGroup playerEcho;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioMixerGroup ringing;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip[] headHitSounds;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip[] bodyHitSounds;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip[] blockHitSounds;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip[] blockLightHitSounds;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip[] knockdownSounds;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<AudioSource> pooledObjects;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int pooledAmount;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x8CCD38", Offset = "0x8CCD38", VA = "0x8CCD38")]
		public static void SetEchoLevel(float intensity)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x8CCE98", Offset = "0x8CCE98", VA = "0x8CCE98")]
		public static void SetPlayerHearingLevel(float intensity)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x8CCFBC", Offset = "0x8CCFBC", VA = "0x8CCFBC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x8CD0D8", Offset = "0x8CD0D8", VA = "0x8CD0D8")]
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume, float pitch = 1f)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x8CD4F8", Offset = "0x8CD4F8", VA = "0x8CD4F8")]
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume, float pitchMinimum, float pitchMaximum)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x8CD674", Offset = "0x8CD674", VA = "0x8CD674")]
		public static void PlayKnockdownClipAtPoint(Vector3 position)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x8CD7C0", Offset = "0x8CD7C0", VA = "0x8CD7C0")]
		public static void PlayHeadHitAtPoint(Vector3 position, float volume)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x8CD954", Offset = "0x8CD954", VA = "0x8CD954")]
		public static void PlayBodyHitAtPoint(Vector3 position, float volume)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x8CDAE8", Offset = "0x8CDAE8", VA = "0x8CDAE8")]
		public static void PlayBlockHitAtPoint(Vector3 position, float force, bool isMajorHit)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x8CD1C8", Offset = "0x8CD1C8", VA = "0x8CD1C8")]
		public void GOPlayClipAtPoint(AudioClip clip, Vector3 position, float volume, float pitch = 1f)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x8CD604", Offset = "0x8CD604", VA = "0x8CD604")]
		public void GOPlayClipAtPoint(AudioClip clip, Vector3 position, float volume, float pitchMinimum, float pitchMaximum)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x8CDD58", Offset = "0x8CDD58", VA = "0x8CDD58")]
		private void InitAudioSource(AudioSource audioSource)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x8CDDB8", Offset = "0x8CDDB8", VA = "0x8CDDB8")]
		public static AudioMixerGroup GetAmbientSoundMixer()
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x8CDE14", Offset = "0x8CDE14", VA = "0x8CDE14")]
		public static AudioMixerGroup GetExternalSoundMixer()
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x8CDE70", Offset = "0x8CDE70", VA = "0x8CDE70")]
		public AudioManager()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class BHapticsHapticsSystem : IHapticsSystem
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static BHapticsHapticsSystem _instance;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ScaleOption defaultScale;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<TactSource> tactSourcePool;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<bool> tactSourceFree;

		[Token(Token = "0x17000023")]
		public static BHapticsHapticsSystem instance
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x8CDE78", Offset = "0x8CDE78", VA = "0x8CDE78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x8CDEF8", Offset = "0x8CDEF8", VA = "0x8CDEF8")]
		public BHapticsHapticsSystem()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x8CDF00", Offset = "0x8CDF00", VA = "0x8CDF00", Slot = "4")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x8CDF08", Offset = "0x8CDF08", VA = "0x8CDF08", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x8CDFE4", Offset = "0x8CDFE4", VA = "0x8CDFE4", Slot = "6")]
		public override void Unload()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x8CDFE8", Offset = "0x8CDFE8", VA = "0x8CDFE8")]
		private static void FreeTactSource(int index)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x8CE070", Offset = "0x8CE070", VA = "0x8CE070")]
		private static TactSource GetFreeTactSource(out int index)
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x8CE278", Offset = "0x8CE278", VA = "0x8CE278")]
		private static void ClearAllDots(TactSource tactSource)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x8CE2D0", Offset = "0x8CE2D0", VA = "0x8CE2D0")]
		private static void PopulateAllDots(TactSource tactSource, int strength)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x8CE32C", Offset = "0x8CE32C", VA = "0x8CE32C")]
		private static void PopulateHeadDots(TactSource tactSource, int strength, float x)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x8CE51C", Offset = "0x8CE51C", VA = "0x8CE51C")]
		private static void PopulateArmDots(TactSource tactSource, int strength, float y)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x8CE66C", Offset = "0x8CE66C", VA = "0x8CE66C")]
		private static void PopulateShoulderDots(TactSource tactSource, int strength, float y, bool isLeft)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x8CE7D8", Offset = "0x8CE7D8", VA = "0x8CE7D8")]
		private static void PopulateChestDots(TactSource tactSource, int strength, float x, float y)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x8CE7D0", Offset = "0x8CE7D0", VA = "0x8CE7D0")]
		private static int DimTwoToOne(int x, int y)
		{
			return default(int);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x8CEA30", Offset = "0x8CEA30", VA = "0x8CEA30", Slot = "7")]
		public override void Rumble(float intensity, BodyArea area)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x8CF144", Offset = "0x8CF144", VA = "0x8CF144", Slot = "8")]
		public override void RumbleAtLocation(float intensity, BodyArea area, float x, float y)
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class BhapticsMenuManager : ChildMenuManager
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEA68", Offset = "0x6CEA68")]
		private HomeMenuManager <homeManager>k__BackingField;

		[Token(Token = "0x17000024")]
		public HomeMenuManager homeManager
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x8CF984", Offset = "0x8CF984", VA = "0x8CF984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFDA0", Offset = "0x6CFDA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x8CF98C", Offset = "0x8CF98C", VA = "0x8CF98C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFDB0", Offset = "0x6CFDB0")]
			set
			{
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x8CF994", Offset = "0x8CF994", VA = "0x8CF994")]
		public void LoadMainMenu()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x8CFA9C", Offset = "0x8CFA9C", VA = "0x8CFA9C", Slot = "4")]
		public override void OpenMenu()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x8CFAA4", Offset = "0x8CFAA4", VA = "0x8CFAA4", Slot = "5")]
		public override void CloseMenu()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x8CFAAC", Offset = "0x8CFAAC", VA = "0x8CFAAC")]
		public BhapticsMenuManager()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class TactSource : HapticClip
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Point[] DefaultPoints;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HapticClipPositionType Position;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public SimpleHapticType Mode;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int[] DotPoints;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Point[] Points;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CEA88", Offset = "0x6CEA88")]
		public int TimeMillis;

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x920CDC", Offset = "0x920CDC", VA = "0x920CDC")]
		public void Play(ScaleOption scale)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x920FB8", Offset = "0x920FB8", VA = "0x920FB8", Slot = "12")]
		public override void Play(float intensity, float duration, float vestRotationAngleX, float vestRotationOffsetY, string identifier = "")
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x92136C", Offset = "0x92136C", VA = "0x92136C", Slot = "17")]
		public override void ResetValues()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x920EA8", Offset = "0x920EA8", VA = "0x920EA8")]
		private static List<DotPoint> Convert(int[] points)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x92124C", Offset = "0x92124C", VA = "0x92124C")]
		private static List<PathPoint> Convert(Point[] points)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x921400", Offset = "0x921400", VA = "0x921400")]
		public TactSource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class Point
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CEAA4", Offset = "0x6CEAA4")]
		public float X;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CEABC", Offset = "0x6CEABC")]
		public float Y;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CEAD4", Offset = "0x6CEAD4")]
		public int Intensity;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x90DFF0", Offset = "0x90DFF0", VA = "0x90DFF0")]
		public Point(float x, float y, int intensity)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public enum SimpleHapticType
	{
		[Token(Token = "0x4000145")]
		DotMode = 1,
		[Token(Token = "0x4000146")]
		PathMode
	}
	[Token(Token = "0x200003F")]
	public class BlobShadow : MonoBehaviour
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float yOffset;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float overshoot;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform[] shadowBaseTargets;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform shadowStretchTarget;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform yPositionTarget;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x8CFACC", Offset = "0x8CFACC", VA = "0x8CFACC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x8CFB1C", Offset = "0x8CFB1C", VA = "0x8CFB1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x8CFE88", Offset = "0x8CFE88", VA = "0x8CFE88")]
		public BlobShadow()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class Blockbox : MonoBehaviour
	{
		[Token(Token = "0x20000C1")]
		public enum BlockboxType
		{
			[Token(Token = "0x40007BC")]
			Unknown,
			[Token(Token = "0x40007BD")]
			Forearm,
			[Token(Token = "0x40007BE")]
			UpperArm
		}

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEAF0", Offset = "0x6CEAF0")]
		private BoxerController <owner>k__BackingField;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hitbox hitbox;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BlockboxType type;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isLeft;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float height;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float offsetY;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Rigidbody rb;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float rbMass;

		[Token(Token = "0x17000025")]
		public BoxerController owner
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x8CFE9C", Offset = "0x8CFE9C", VA = "0x8CFE9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFDC0", Offset = "0x6CFDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x8CFEA4", Offset = "0x8CFEA4", VA = "0x8CFEA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFDD0", Offset = "0x6CFDD0")]
			set
			{
			}
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x8CFEAC", Offset = "0x8CFEAC", VA = "0x8CFEAC", Slot = "4")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x8CFF68", Offset = "0x8CFF68", VA = "0x8CFF68")]
		public void SetOwner(BoxerController newOwner)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x8CFF70", Offset = "0x8CFF70", VA = "0x8CFF70", Slot = "5")]
		public virtual void ReceiveHitboxCollision(float force, Hitbox hitbox, Collision collision, bool isMajorHit)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x8D00B8", Offset = "0x8D00B8", VA = "0x8D00B8", Slot = "6")]
		public virtual void ReceiveParryboxCollision(float force, Hitbox hitbox, Blockbox otherParrybox, Collision collision, bool isMajorHit)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x8D0164", Offset = "0x8D0164", VA = "0x8D0164", Slot = "7")]
		public virtual void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x8D0570", Offset = "0x8D0570", VA = "0x8D0570", Slot = "8")]
		public virtual void ClearVelocity()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x8D0574", Offset = "0x8D0574", VA = "0x8D0574", Slot = "9")]
		public virtual Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x8D05D4", Offset = "0x8D05D4", VA = "0x8D05D4", Slot = "10")]
		public virtual float GetRigidbodyMass()
		{
			return default(float);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x8D05DC", Offset = "0x8D05DC", VA = "0x8D05DC", Slot = "11")]
		public virtual bool IsBlocking()
		{
			return default(bool);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x8D0600", Offset = "0x8D0600", VA = "0x8D0600")]
		public Blockbox()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class BoutController : MonoBehaviour
	{
		[Token(Token = "0x20000C2")]
		public delegate void TimerUpdateEvent(bool startCounting, bool isRound, float duration, int onRound, int numberOfRounds);

		[Token(Token = "0x20000C3")]
		private delegate void ActionDelegate();

		[Token(Token = "0x20000C4")]
		public enum Corner
		{
			[Token(Token = "0x40007C0")]
			Red,
			[Token(Token = "0x40007C1")]
			Blue
		}

		[Token(Token = "0x20000C5")]
		public enum Judge
		{
			[Token(Token = "0x40007C3")]
			First,
			[Token(Token = "0x40007C4")]
			Second,
			[Token(Token = "0x40007C5")]
			Third
		}

		[Token(Token = "0x20000C6")]
		public enum PunchStatus
		{
			[Token(Token = "0x40007C7")]
			Miss,
			[Token(Token = "0x40007C8")]
			Hit
		}

		[Token(Token = "0x4000154")]
		private const float defaultDamageDifferenceToWin = 0.05f;

		[Token(Token = "0x4000155")]
		private const float defaultJudgeDecisionFuzziness = 0.05f;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Texture2D opponentCutout;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool boutInit;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static BoutController instance;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TimerUpdateEvent OnTimerUpdate;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform redStart;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform blueStart;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject enemyPrefab;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject playerPrefab;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private EnemyController enemyObject;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrowdController soundsObject;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEB00", Offset = "0x6CEB00")]
		private BoxerController[] <boxers>k__BackingField;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int onRound;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool roundActive;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool breakActive;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool roundTimerCountingDown;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool breakTimerCountingDown;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool roundTimerBelowTen;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool roundTimerBelowZero;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool breakTimerBelowTen;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float roundTimer;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float breakTimer;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float damageDifferenceToWin;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float judgeDecisionFuzziness;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float roundTime;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int numberOfRounds;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float breakTime;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int knockdownLimit;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float judgeStrictness;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int[][][] roundScores;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int[] roundDamage;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int[] knockdownsThisRound;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int[][] knockdowns;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int[][][] damageTaken;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int[][] punchesTotal;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[][] punchesLanded;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int[][] damagingPunchesLanded;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int[][] leftStraightsLanded;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int[][] rightStraightsLanded;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int[][] leftHooksLanded;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[][] rightHooksLanded;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[][] leftUppersLanded;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int[][] rightUppersLanded;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int[][] leftStraightsLandedDamaging;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int[][] rightStraightsLandedDamaging;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int[][] leftHooksLandedDamaging;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int[][] rightHooksLandedDamaging;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int[][] leftUppersLandedDamaging;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int[][] rightUppersLandedDamaging;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float[] playerMultiplier;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float[] playerHookMultiplier;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float[] playerJabMultiplier;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float[] playerUpperMultiplier;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool isCountingDown;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private float knockdownTimer;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool boutActive;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		private bool boutOverByKO;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
		private bool boutOverByTKO;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool[] boxerDown;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private ActionDelegate DelayedEvent;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool isDelayedEvent;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float delayTimer;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private int[] scoreHolder;

		[Token(Token = "0x17000026")]
		public static BoxerController[] allBoxers
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x8D0614", Offset = "0x8D0614", VA = "0x8D0614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private BoxerController[] boxers
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x8D0688", Offset = "0x8D0688", VA = "0x8D0688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFDE0", Offset = "0x6CFDE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x8D0690", Offset = "0x8D0690", VA = "0x8D0690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFDF0", Offset = "0x6CFDF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		private AnnouncerController announcer
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x8D0698", Offset = "0x8D0698", VA = "0x8D0698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private RefereeController referee
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x8D06E8", Offset = "0x8D06E8", VA = "0x8D06E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x8D0738", Offset = "0x8D0738", VA = "0x8D0738")]
		public static float GetBreakTime()
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x8D07AC", Offset = "0x8D07AC", VA = "0x8D07AC")]
		public static float GetRound()
		{
			return default(float);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x8D0824", Offset = "0x8D0824", VA = "0x8D0824")]
		public static void AddDamage(Corner corner, float damage, float painThreshold)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x8D0988", Offset = "0x8D0988", VA = "0x8D0988")]
		public static void AddDamageToRed(float damage, float painThreshold)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x8D0A00", Offset = "0x8D0A00", VA = "0x8D0A00")]
		public static void AddDamageToBlue(float damage, float painThreshold)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x8D0A78", Offset = "0x8D0A78", VA = "0x8D0A78")]
		public static void Continue()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x8D0E24", Offset = "0x8D0E24", VA = "0x8D0E24")]
		public static void BoxerKnockedDown(Corner corner)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x8D15B8", Offset = "0x8D15B8", VA = "0x8D15B8")]
		public static void RedKnockedDown()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x8D1618", Offset = "0x8D1618", VA = "0x8D1618")]
		public static void BlueKnockedDown()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x8D1678", Offset = "0x8D1678", VA = "0x8D1678")]
		public void RedSwingTaken(Hitbox.PunchType punchType)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x8D1758", Offset = "0x8D1758", VA = "0x8D1758")]
		public void BlueSwingTaken(Hitbox.PunchType punchType)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x8D1680", Offset = "0x8D1680", VA = "0x8D1680")]
		public void BoxerSwingTaken(Hitbox.PunchType punchType, Corner corner)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x8D1760", Offset = "0x8D1760", VA = "0x8D1760")]
		public void RedSwingLanded(Hitbox.PunchType punchType, bool mirrored, float damage, float targetPainThreshold)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x8D1B20", Offset = "0x8D1B20", VA = "0x8D1B20")]
		public void BlueSwingLanded(Hitbox.PunchType punchType, bool mirrored, float damage, float targetPainThreshold)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x8D176C", Offset = "0x8D176C", VA = "0x8D176C")]
		public void BoxerSwingLanded(Hitbox.PunchType punchType, bool mirrored, Corner corner, float damage, float targetPainThreshold)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x8D1B2C", Offset = "0x8D1B2C", VA = "0x8D1B2C")]
		public static void RedKnockedDownMovement()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x8D1BE8", Offset = "0x8D1BE8", VA = "0x8D1BE8")]
		public static void BlueKnockedDownMovement()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x8D11EC", Offset = "0x8D11EC", VA = "0x8D11EC")]
		private static Transform FindFarthestNeutralCorner(Vector3 farthestFromPoint)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x8D1CA4", Offset = "0x8D1CA4", VA = "0x8D1CA4")]
		public static void Retire()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x8D229C", Offset = "0x8D229C", VA = "0x8D229C")]
		public static bool IsFightHappening()
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x8D2370", Offset = "0x8D2370", VA = "0x8D2370")]
		public static void DisqualifyPlayer()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x8D1DA4", Offset = "0x8D1DA4", VA = "0x8D1DA4")]
		public void PauseBout()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x8D0C18", Offset = "0x8D0C18", VA = "0x8D0C18")]
		public void StartBout()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x8D2D6C", Offset = "0x8D2D6C", VA = "0x8D2D6C")]
		public void EndBout()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x8D21B4", Offset = "0x8D21B4", VA = "0x8D21B4")]
		public static void ExitBout()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x8D1DAC", Offset = "0x8D1DAC", VA = "0x8D1DAC")]
		public void EndBoutByRetirement()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x8D31D4", Offset = "0x8D31D4", VA = "0x8D31D4")]
		public void EndBoutByDecision()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x8D3A60", Offset = "0x8D3A60", VA = "0x8D3A60")]
		private void EndBoutByKnockout(Corner loser)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x8D24E8", Offset = "0x8D24E8", VA = "0x8D24E8")]
		private void EndBoutByTKO(Corner loser)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x8D3060", Offset = "0x8D3060", VA = "0x8D3060")]
		private void PopulateBoutResults()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x8D430C", Offset = "0x8D430C", VA = "0x8D430C")]
		public void StartBreak()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x8D43D8", Offset = "0x8D43D8", VA = "0x8D43D8")]
		public void StartBreakMovement()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x8D0C94", Offset = "0x8D0C94", VA = "0x8D0C94")]
		public void EndBreak()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x8D0CA0", Offset = "0x8D0CA0", VA = "0x8D0CA0")]
		public void StartRound()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x8D4558", Offset = "0x8D4558", VA = "0x8D4558")]
		public void RefStartRound()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x8D46D0", Offset = "0x8D46D0", VA = "0x8D46D0")]
		public void StartRoundMovement()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x8D4744", Offset = "0x8D4744", VA = "0x8D4744")]
		public void EndRound()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x8D4A88", Offset = "0x8D4A88", VA = "0x8D4A88")]
		private void CalculateRoundScore()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x8D4D8C", Offset = "0x8D4D8C", VA = "0x8D4D8C")]
		private int[] CalculateRoundScoreForJudge(ref int redDamageTaken, ref int blueDamageTaken)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x8D4FFC", Offset = "0x8D4FFC", VA = "0x8D4FFC")]
		public static BoutResults.Winner GetCurrentWinner()
		{
			return default(BoutResults.Winner);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x8D50DC", Offset = "0x8D50DC", VA = "0x8D50DC")]
		public BoutResults.Winner GetCurrentWinnerInstance(bool debug = false)
		{
			return default(BoutResults.Winner);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x8D3914", Offset = "0x8D3914", VA = "0x8D3914")]
		private void CalculateBoutScoreForJudge(ref int[] score, int judge)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x8D39E8", Offset = "0x8D39E8", VA = "0x8D39E8")]
		private void PostMatchSetup()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x8D5268", Offset = "0x8D5268", VA = "0x8D5268")]
		public void PostMatchSetupAction()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x8D54EC", Offset = "0x8D54EC", VA = "0x8D54EC")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x8D6C80", Offset = "0x8D6C80", VA = "0x8D6C80")]
		public void Start()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x8D13D0", Offset = "0x8D13D0", VA = "0x8D13D0")]
		private void PrepareDelayedEvent(ActionDelegate eventFunction, float delay = 0f, bool prepareBoxers = true)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x8D6F34", Offset = "0x8D6F34", VA = "0x8D6F34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x8D6FA4", Offset = "0x8D6FA4", VA = "0x8D6FA4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x8D7840", Offset = "0x8D7840", VA = "0x8D7840")]
		private void PrepareGetUpMovement(Corner cornerGettingUp)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x8D7900", Offset = "0x8D7900", VA = "0x8D7900")]
		private void RefPrepareGetUpHoldBack()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x8D795C", Offset = "0x8D795C", VA = "0x8D795C")]
		private void RefPrepareGetUpRedHoldBack()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x8D7A10", Offset = "0x8D7A10", VA = "0x8D7A10")]
		private void RefPrepareGetUpBlueHoldBack()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x8D7AC4", Offset = "0x8D7AC4", VA = "0x8D7AC4")]
		private void RefPrepareGetUp()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x8D7B8C", Offset = "0x8D7B8C", VA = "0x8D7B8C")]
		private void RefPrepareGetUpRed()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x8D7C10", Offset = "0x8D7C10", VA = "0x8D7C10")]
		private void RefPrepareGetUpBlue()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x8D7C94", Offset = "0x8D7C94", VA = "0x8D7C94")]
		private void RedGettingUpMovement()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x8D7D10", Offset = "0x8D7D10", VA = "0x8D7D10")]
		private void BlueGettingUpMovement()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x8CAE70", Offset = "0x8CAE70", VA = "0x8CAE70")]
		public static void WinnerAnnounced(Corner corner)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x8D7D8C", Offset = "0x8D7D8C", VA = "0x8D7D8C")]
		public static bool InBoutScene()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x8D7E24", Offset = "0x8D7E24", VA = "0x8D7E24")]
		public BoutController()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class BoutResults
	{
		[Token(Token = "0x20000C7")]
		public enum WinCondition
		{
			[Token(Token = "0x40007CA")]
			Decision,
			[Token(Token = "0x40007CB")]
			Knockout,
			[Token(Token = "0x40007CC")]
			TKO,
			[Token(Token = "0x40007CD")]
			Retirement
		}

		[Token(Token = "0x20000C8")]
		public enum Winner
		{
			[Token(Token = "0x40007CF")]
			Draw,
			[Token(Token = "0x40007D0")]
			Red,
			[Token(Token = "0x40007D1")]
			Blue
		}

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool customizedBattle;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool extraBattle;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int wentToRound;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int roundsFought;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int redScoredCount;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int blueScoredCount;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int drawScoredCount;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static WinCondition winCondition;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Winner winner;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int[][][] scores;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static bool showScore;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public static bool justFinishedBout;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static int[][] scoreTally;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string defeatedBoxer;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static int[][] knockdowns;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static int[][][] damageTaken;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static int[][] punchesTotal;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static int[][] punchesLanded;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static int[][] damagingPunchesLanded;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static int[][] leftStraightsLanded;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int[][] rightStraightsLanded;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static int[][] leftHooksLanded;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static int[][] rightHooksLanded;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static int[][] leftUppersLanded;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static int[][] rightUppersLanded;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static int[][] leftStraightsLandedDamaging;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static int[][] rightStraightsLandedDamaging;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static int[][] leftHooksLandedDamaging;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static int[][] rightHooksLandedDamaging;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static int[][] leftUppersLandedDamaging;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static int[][] rightUppersLandedDamaging;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static float[] playerMultiplier;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static float[] playerHookMultiplier;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static float[] playerJabMultiplier;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static float[] playerUpperMultiplier;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static string redCornerName;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static string blueCornerName;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x8D7FA0", Offset = "0x8D7FA0", VA = "0x8D7FA0")]
		public BoutResults()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class BoutRules
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string boxerResourceName;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int numberOfRounds;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float roundTime;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static float breakTime;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int knockdownLimit;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static float damageDifferenceToWin;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static float judgeDecisionFuzziness;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool overrideBoxerStats;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static float chin;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static float power;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static float fistSpeed;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static float dodgeSpeed;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float blockSpeed;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float aggression;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float traumaGainRate;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static float judgeStrictness;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static float bodyRate;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static float jabRate;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static float leftCrossRate;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static float rightCrossRate;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static float leftHookRate;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static float rightHookRate;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static float leftUppercutRate;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static float rightUppercutRate;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static FightMenuManager.SelectedDifficulty difficulty;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static bool extraBattle;

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x8D8014", Offset = "0x8D8014", VA = "0x8D8014")]
		public BoutRules()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class BoxerController : MonoBehaviour
	{
		[Token(Token = "0x20000C9")]
		public delegate void SwingTakenEvent(Hitbox.PunchType punchType);

		[Token(Token = "0x20000CA")]
		public delegate void SwingLandedEvent(Hitbox.PunchType punchType, bool mirrored, float damage, float targetPainThreshold);

		[Token(Token = "0x20000CB")]
		public delegate void KnockedDownEvent();

		[Token(Token = "0x20000CC")]
		public delegate void TakeDamageEvent(float damage, float victimPainThreshold);

		[Serializable]
		[Token(Token = "0x20000CD")]
		public class DamageThreshold
		{
			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float damage;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool canRock;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float chanceToFloor;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float minimumFloorTime;

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x8ABA68", Offset = "0x8ABA68", VA = "0x8ABA68")]
			public DamageThreshold()
			{
			}
		}

		[Token(Token = "0x40001D3")]
		public const float MaxExpectedPunchForce = 3600f;

		[Token(Token = "0x40001D4")]
		public const float MaxExpectedPunchDamage = 4680f;

		[Token(Token = "0x40001D5")]
		public const float BaseEffectiveMass = 3.636f;

		[Token(Token = "0x40001D6")]
		public const float clinchRange = 0.35f;

		[Token(Token = "0x40001D7")]
		public const float bodyHitModifier = 1f;

		[Token(Token = "0x40001D8")]
		public const float otherHitModifier = 0.75f;

		[Token(Token = "0x40001D9")]
		public const float DefaultPainThreshold = 2700f;

		[Token(Token = "0x40001DA")]
		public const float DefaultLightsOutThreshold = 4280f;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SwingTakenEvent OnSwingTaken;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SwingLandedEvent OnSwingLanded;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEB10", Offset = "0x6CEB10")]
		private string <boxerName>k__BackingField;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D cutoutPhoto;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform head;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform eyes;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KnockedDownEvent OnKnockdown;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform headRotationPoint;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected float kdLightsOutDamageThreshold;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected float painThreshold;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected float outColdThreshold;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float minimumTimeOnFloor;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float baseLightsOutTimeOnFloor;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float extraTimeOnFloorPerDamage;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static float maxAdditionalTimeOnFloorFromTrauma;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float outColdTimeOnFloor;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected bool isBlocking;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TakeDamageEvent OnTakeDamage;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEB20", Offset = "0x6CEB20")]
		private int <collisionLayerMask>k__BackingField;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEB30", Offset = "0x6CEB30")]
		private int <blockboxLayerMask>k__BackingField;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float maxTimeBeforeKnockdownMovement;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected bool isFighting;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected float chinModifier;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float powerModifier;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected float fistSpeedModifier;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected float dodgeSpeedModifier;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected float blockSpeedModifier;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected float aggressionModifier;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEB40", Offset = "0x6CEB40")]
		private BoutController.Corner <corner>k__BackingField;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float PunchImpulseTime;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Transform rootParent;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CEB50", Offset = "0x6CEB50")]
		public bool canDizzy;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEB88", Offset = "0x6CEB88")]
		private float <dizzyLevel>k__BackingField;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected float slightlyDizzyThreshold;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		protected float veryDizzyThreshold;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CEB98", Offset = "0x6CEB98")]
		protected float dizzyMax;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		protected float dizzyRegen;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected float dizzyHitThreshold;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		protected float roundMultiplier;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CEBD0", Offset = "0x6CEBD0")]
		public float headTraumaMultiplier;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		protected float traumaDamage;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected float traumaCoefficient;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CEC08", Offset = "0x6CEC08")]
		public float bodyPainMultiplier;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected float painDamage;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		protected float painCoefficient;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public GameObject[] colliderIgnoreList;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private HitZone[] hitZones;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Hitbox[] hitboxes;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Hurtbox[] hurtboxes;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Blockbox[] blockboxes;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Collider[] colliders;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int[] colliderLayers;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEC40", Offset = "0x6CEC40")]
		private float <knockdownTimer>k__BackingField;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEC50", Offset = "0x6CEC50")]
		private bool <isDown>k__BackingField;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEC60", Offset = "0x6CEC60")]
		private bool <stayDown>k__BackingField;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEC70", Offset = "0x6CEC70")]
		private Transform <farthestNeutralCorner>k__BackingField;

		[Token(Token = "0x1700002A")]
		public string boxerName
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x8D8140", Offset = "0x8D8140", VA = "0x8D8140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE00", Offset = "0x6CFE00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x8D8148", Offset = "0x8D8148", VA = "0x8D8148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE10", Offset = "0x6CFE10")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int collisionLayerMask
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x8D8150", Offset = "0x8D8150", VA = "0x8D8150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE20", Offset = "0x6CFE20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x8D8158", Offset = "0x8D8158", VA = "0x8D8158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE30", Offset = "0x6CFE30")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public int blockboxLayerMask
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x8D8160", Offset = "0x8D8160", VA = "0x8D8160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE40", Offset = "0x6CFE40")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x8D8168", Offset = "0x8D8168", VA = "0x8D8168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE50", Offset = "0x6CFE50")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public BoutController.Corner corner
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x8D8170", Offset = "0x8D8170", VA = "0x8D8170")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE60", Offset = "0x6CFE60")]
			get
			{
				return default(BoutController.Corner);
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x8D8178", Offset = "0x8D8178", VA = "0x8D8178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE70", Offset = "0x6CFE70")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public float dizzyLevel
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x8D8180", Offset = "0x8D8180", VA = "0x8D8180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE80", Offset = "0x6CFE80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x8D8188", Offset = "0x8D8188", VA = "0x8D8188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFE90", Offset = "0x6CFE90")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public float knockdownTimer
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x8D8190", Offset = "0x8D8190", VA = "0x8D8190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFEA0", Offset = "0x6CFEA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x8D8198", Offset = "0x8D8198", VA = "0x8D8198")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFEB0", Offset = "0x6CFEB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool isDown
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x8D81A0", Offset = "0x8D81A0", VA = "0x8D81A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFEC0", Offset = "0x6CFEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x8D81A8", Offset = "0x8D81A8", VA = "0x8D81A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFED0", Offset = "0x6CFED0")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool stayDown
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x8D81B4", Offset = "0x8D81B4", VA = "0x8D81B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFEE0", Offset = "0x6CFEE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x8D81BC", Offset = "0x8D81BC", VA = "0x8D81BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFEF0", Offset = "0x6CFEF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public Transform farthestNeutralCorner
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x8D81C8", Offset = "0x8D81C8", VA = "0x8D81C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF00", Offset = "0x6CFF00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x8D81D0", Offset = "0x8D81D0", VA = "0x8D81D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF10", Offset = "0x6CFF10")]
			set
			{
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x8D81D8", Offset = "0x8D81D8", VA = "0x8D81D8")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6CFF20", Offset = "0x6CFF20")]
		public void DizzyMe()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x8D81E4", Offset = "0x8D81E4", VA = "0x8D81E4")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6CFF30", Offset = "0x6CFF30")]
		public void TraumatizeMe()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x8D81F4", Offset = "0x8D81F4", VA = "0x8D81F4")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x8D82F8", Offset = "0x8D82F8", VA = "0x8D82F8", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x8D8688", Offset = "0x8D8688", VA = "0x8D8688", Slot = "5")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x8D8694", Offset = "0x8D8694", VA = "0x8D8694", Slot = "6")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x8D8734", Offset = "0x8D8734", VA = "0x8D8734", Slot = "7")]
		protected virtual void InitializeBoxes()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x8D873C", Offset = "0x8D873C", VA = "0x8D873C")]
		protected void IgnoreInternalColliders([Optional] GameObject[] ignoreList)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x8D88D0", Offset = "0x8D88D0", VA = "0x8D88D0")]
		public void RunBoxVelocityUpdates()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x8D8988", Offset = "0x8D8988", VA = "0x8D8988", Slot = "8")]
		public virtual float CalculateMultiplierCorrection(Hitbox.PunchType punchType)
		{
			return default(float);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x8D8990", Offset = "0x8D8990", VA = "0x8D8990")]
		public void HandleHitboxCollision(Hitbox hitbox, Hurtbox hurtbox, Collision collision)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x8D8F2C", Offset = "0x8D8F2C", VA = "0x8D8F2C")]
		public void HandleHitboxCollision(Hitbox hitbox, Blockbox blockbox, Collision collision)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x8D9254", Offset = "0x8D9254", VA = "0x8D9254")]
		public void HandleHitboxCollision(Hitbox hitbox, Hitbox otherHitbox, Collision collision)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x8D96F0", Offset = "0x8D96F0", VA = "0x8D96F0")]
		public void HandleHitboxParryCollision(Hitbox hitbox, Blockbox parrybox, Collision collision)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x8D0240", Offset = "0x8D0240", VA = "0x8D0240")]
		public void HandleParryboxCollision(Blockbox parrybox, Blockbox otherParrybox, Collision collision)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x8D9B78", Offset = "0x8D9B78", VA = "0x8D9B78")]
		public void ReceiveHurtboxCollision(float force, Hurtbox hurtbox, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x8D0040", Offset = "0x8D0040", VA = "0x8D0040")]
		public void ReceiveBlock(float force, Hitbox hitbox, Collision collision, bool isMajorHit)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x8D9E00", Offset = "0x8D9E00", VA = "0x8D9E00")]
		public void TakeDamage(float damage, Hurtbox.HurtboxType type, bool hitWeakSpot)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x8D9E68", Offset = "0x8D9E68", VA = "0x8D9E68", Slot = "9")]
		public virtual void DirectDamageExternalResults(float damage, bool hitWeakSpot, Hurtbox.HurtboxType type, bool wasKnockedDown)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x8D9C88", Offset = "0x8D9C88", VA = "0x8D9C88")]
		private float CalculateHitZoneMultiplier(Hurtbox hurtbox, Hitbox hitbox)
		{
			return default(float);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x8D8D40", Offset = "0x8D8D40", VA = "0x8D8D40")]
		private static float CalculateForce(Vector3 hitboxVelocity, float hitboxMass, Vector3 targetVelocity, float targetMass, float multiplierCorrection = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x8D9DF8", Offset = "0x8D9DF8", VA = "0x8D9DF8")]
		private float CalculateDamage(float force, float multiplier)
		{
			return default(float);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x8D9E6C", Offset = "0x8D9E6C", VA = "0x8D9E6C", Slot = "10")]
		protected virtual bool ReceiveDamage(float damage, Hurtbox.HurtboxType hurtboxType, [Optional] Hurtbox hurtbox, [Optional] Hitbox hitbox)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x8DA170", Offset = "0x8DA170", VA = "0x8DA170")]
		public bool IsBehindOnScore()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x8DA1EC", Offset = "0x8DA1EC", VA = "0x8DA1EC")]
		public bool IsDizzy()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x8DA1FC", Offset = "0x8DA1FC", VA = "0x8DA1FC")]
		public bool IsSlightlyDizzy()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x8DA214", Offset = "0x8DA214", VA = "0x8DA214")]
		public bool IsVeryDizzy()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x8DA22C", Offset = "0x8DA22C", VA = "0x8DA22C")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x8DA2C0", Offset = "0x8DA2C0", VA = "0x8DA2C0")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x8DA33C", Offset = "0x8DA33C", VA = "0x8DA33C")]
		public Transform GetLookTarget()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x8DA3C4", Offset = "0x8DA3C4", VA = "0x8DA3C4", Slot = "11")]
		public virtual Transform GetPositionTransform()
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x8DA3CC", Offset = "0x8DA3CC", VA = "0x8DA3CC")]
		public HitZone[] GetHitZones()
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x8DA3D4", Offset = "0x8DA3D4", VA = "0x8DA3D4", Slot = "12")]
		public virtual string GetName()
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x8DA3F8", Offset = "0x8DA3F8", VA = "0x8DA3F8", Slot = "13")]
		public virtual string GetDefeatName()
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x8DA440", Offset = "0x8DA440", VA = "0x8DA440", Slot = "14")]
		public virtual bool CanTakeDamage()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x8DA460", Offset = "0x8DA460", VA = "0x8DA460", Slot = "15")]
		protected virtual void HurtboxCollisionVisualResult(float damage, float force, bool wasKnockedDown, Hurtbox hurtbox, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x8DA464", Offset = "0x8DA464", VA = "0x8DA464", Slot = "16")]
		protected virtual void HurtboxCollisionAudioResult(float damage, float force, bool wasKnockedDown, Hurtbox hurtbox, Hitbox hitbox, Collision collision, bool hitWeakSpot = false)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x8DA500", Offset = "0x8DA500", VA = "0x8DA500", Slot = "17")]
		protected virtual void BlockVisualResult(float force, Hitbox hitbox, Collision collision, bool isMajorHit)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x8DA504", Offset = "0x8DA504", VA = "0x8DA504", Slot = "18")]
		protected virtual void BlockAudioResult(float force, Collision collision, bool isMajorHit)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x8DA588", Offset = "0x8DA588", VA = "0x8DA588")]
		public void Footfall()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x8DA58C", Offset = "0x8DA58C", VA = "0x8DA58C", Slot = "19")]
		public virtual void PlayKnockdownSound()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x8DA5B4", Offset = "0x8DA5B4", VA = "0x8DA5B4", Slot = "20")]
		protected virtual void Knockdown(Hurtbox hurtbox, Hitbox hitbox)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x8DA5C8", Offset = "0x8DA5C8", VA = "0x8DA5C8", Slot = "21")]
		public virtual void PrepareForEvent(float delay)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x8DA5CC", Offset = "0x8DA5CC", VA = "0x8DA5CC", Slot = "22")]
		public virtual void PreMatchSetup()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x8DA5D0", Offset = "0x8DA5D0", VA = "0x8DA5D0", Slot = "23")]
		public virtual void PrepareToStartRound()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x8DA5D4", Offset = "0x8DA5D4", VA = "0x8DA5D4", Slot = "24")]
		public virtual void StartRound()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x8DA5D8", Offset = "0x8DA5D8", VA = "0x8DA5D8", Slot = "25")]
		public virtual void StartRoundMovement()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x8DA5DC", Offset = "0x8DA5DC", VA = "0x8DA5DC", Slot = "26")]
		public virtual void EndRound()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x8DA5E0", Offset = "0x8DA5E0", VA = "0x8DA5E0", Slot = "27")]
		public virtual void StartBreakMovement()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x8DA5E4", Offset = "0x8DA5E4", VA = "0x8DA5E4", Slot = "28")]
		public virtual void ScoredKnockdownAction()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x8DA5E8", Offset = "0x8DA5E8", VA = "0x8DA5E8", Slot = "29")]
		public virtual void KnockedDownMovement()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x8DA5EC", Offset = "0x8DA5EC", VA = "0x8DA5EC", Slot = "30")]
		public virtual void GoToFarthestNeutralCorner()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x8DA5F0", Offset = "0x8DA5F0", VA = "0x8DA5F0", Slot = "31")]
		public virtual void GetUpMovement()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x8DA5F4", Offset = "0x8DA5F4", VA = "0x8DA5F4", Slot = "32")]
		public virtual void ResumeFighting()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x8DA5F8", Offset = "0x8DA5F8", VA = "0x8DA5F8", Slot = "33")]
		public virtual void ResumeFightingMovement()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x8DA5FC", Offset = "0x8DA5FC", VA = "0x8DA5FC", Slot = "34")]
		public virtual void PostMatchMovement()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x8DA600", Offset = "0x8DA600", VA = "0x8DA600", Slot = "35")]
		public virtual void ReportMatchResults(bool isAWin, bool isADraw, string opponentDefeatName, FightMenuManager.SelectedDifficulty difficulty)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x8DA604", Offset = "0x8DA604", VA = "0x8DA604", Slot = "36")]
		public virtual void CelebrateWin()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x8DA608", Offset = "0x8DA608", VA = "0x8DA608", Slot = "37")]
		public virtual void MournLoss()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x8DA60C", Offset = "0x8DA60C", VA = "0x8DA60C", Slot = "38")]
		public virtual Vector3 PredictHitZoneMovement(float afterSeconds)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x8DA66C", Offset = "0x8DA66C", VA = "0x8DA66C", Slot = "39")]
		public virtual void HitTheRopes()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x8DA670", Offset = "0x8DA670", VA = "0x8DA670", Slot = "40")]
		public virtual bool IsBlocking()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x8DA678", Offset = "0x8DA678", VA = "0x8DA678", Slot = "41")]
		public virtual void SetHandicapValues(float chinValue, float powerValue, float fistSpeedValue, float dodgeSpeedValue, float blockSpeedValue, float aggressionValue)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x8DA6A4", Offset = "0x8DA6A4", VA = "0x8DA6A4", Slot = "42")]
		public virtual void SetPunchRatioValues(float bodyRate, float jabRate, float leftCrossRate, float rightCrossRate, float leftHookRate, float rightHookRate, float leftUppercutRate, float rightUppercutRate)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x8DA6A8", Offset = "0x8DA6A8", VA = "0x8DA6A8")]
		public void PunchThrown()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x8DA6AC", Offset = "0x8DA6AC", VA = "0x8DA6AC")]
		public void PunchLanded()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x8DA6B0", Offset = "0x8DA6B0", VA = "0x8DA6B0", Slot = "43")]
		public virtual float GetClosestAllowedDistance(Vector3 startPosition, Vector3 endPosition, float extraDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x8DA6B8", Offset = "0x8DA6B8", VA = "0x8DA6B8", Slot = "44")]
		public virtual void RecoverFatigue(float recoveryTime)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x8DA6BC", Offset = "0x8DA6BC", VA = "0x8DA6BC")]
		public void SetRoundMultiplier(float newMultiplier)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x8DA6C4", Offset = "0x8DA6C4", VA = "0x8DA6C4", Slot = "45")]
		public virtual void BlockCollisionVisualResult(float force, Blockbox blockbox, Collision collision)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x8DA6C8", Offset = "0x8DA6C8", VA = "0x8DA6C8")]
		public BoxerController()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class BoxingDummyCollider : Equipment, IFixedUpdateable
	{
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoxingDummyController controller;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEC80", Offset = "0x6CEC80")]
		private DummyHitZone[] <hitZones>k__BackingField;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform model;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEC90", Offset = "0x6CEC90")]
		private Vector3 <lastFixedUpdatePosition>k__BackingField;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CECA0", Offset = "0x6CECA0")]
		private Quaternion <lastFixedUpdateRotation>k__BackingField;

		[Token(Token = "0x17000033")]
		public DummyHitZone[] hitZones
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x8AC6E8", Offset = "0x8AC6E8", VA = "0x8AC6E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF40", Offset = "0x6CFF40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x8AC6F0", Offset = "0x8AC6F0", VA = "0x8AC6F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF50", Offset = "0x6CFF50")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Vector3 lastFixedUpdatePosition
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x8AC6F8", Offset = "0x8AC6F8", VA = "0x8AC6F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF60", Offset = "0x6CFF60")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x8AC704", Offset = "0x8AC704", VA = "0x8AC704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF70", Offset = "0x6CFF70")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Quaternion lastFixedUpdateRotation
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x8AC710", Offset = "0x8AC710", VA = "0x8AC710")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF80", Offset = "0x6CFF80")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x8AC71C", Offset = "0x8AC71C", VA = "0x8AC71C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFF90", Offset = "0x6CFF90")]
			set
			{
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x8AC728", Offset = "0x8AC728", VA = "0x8AC728")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x8AC730", Offset = "0x8AC730", VA = "0x8AC730")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x8AC738", Offset = "0x8AC738", VA = "0x8AC738", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x8AC7D4", Offset = "0x8AC7D4", VA = "0x8AC7D4", Slot = "5")]
		public void CustomFixedUpdate()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x8AC824", Offset = "0x8AC824", VA = "0x8AC824")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x8ACE48", Offset = "0x8ACE48", VA = "0x8ACE48")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x8AD024", Offset = "0x8AD024", VA = "0x8AD024")]
		public BoxingDummyCollider()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class BoxingDummyController : MonoBehaviour
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BoxingDummyController instance;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform trainer;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoxingDummyCollider colliderParent;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource audioSource;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SpectatorCamera spectatorCamera;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCanvas;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public HitRecapUI lastHitUI;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public HitRecapUI bestHitUI;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool initialized;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform trainerSmallSpacePosition;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform trainerLargeSpacePosition;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float trainerSmallPositionWidth;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float trainerSmallPositionDepth;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float bestDamage;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool eventOn;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x8AD02C", Offset = "0x8AD02C", VA = "0x8AD02C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x8AD114", Offset = "0x8AD114", VA = "0x8AD114")]
		public static void InitializeDummy()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x8AD358", Offset = "0x8AD358", VA = "0x8AD358")]
		private void Start()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x8AD1B8", Offset = "0x8AD1B8", VA = "0x8AD1B8")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x8AD6F0", Offset = "0x8AD6F0", VA = "0x8AD6F0")]
		public void DeinitializeDummy()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x8AD854", Offset = "0x8AD854", VA = "0x8AD854")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x8AD8BC", Offset = "0x8AD8BC", VA = "0x8AD8BC")]
		public void ResetBestHit()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x8AC8F4", Offset = "0x8AC8F4", VA = "0x8AC8F4")]
		public void ColliderHit(Collision collision, PlayerFist hitbox, BoxingDummyCollider dummyCollider)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x8ADA88", Offset = "0x8ADA88", VA = "0x8ADA88")]
		public void Exit()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x8ADA8C", Offset = "0x8ADA8C", VA = "0x8ADA8C")]
		public void CloseButtonPressed()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x8ADB94", Offset = "0x8ADB94", VA = "0x8ADB94")]
		public void PlaySpaceUpdated()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x8AD440", Offset = "0x8AD440", VA = "0x8AD440")]
		public void MovePlayer()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x8ADB98", Offset = "0x8ADB98", VA = "0x8ADB98")]
		public BoxingDummyController()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x20000CE")]
		private struct PositionStorage
		{
			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 positionDelta;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float time;

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x8AE5FC", Offset = "0x8AE5FC", VA = "0x8AE5FC")]
			public PositionStorage(Vector3 newPositionDelta, float newTime)
			{
			}
		}

		[Token(Token = "0x20000CF")]
		private struct RotationStorage
		{
			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float rotation;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float time;

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x8AE608", Offset = "0x8AE608", VA = "0x8AE608")]
			public RotationStorage(float newRotation, float newTime)
			{
			}
		}

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TotfImageEffects effects;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool fading;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool fadingOut;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int fadeBounceCount;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float targetBlink;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool fadingBlack;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		private bool fadingOutBlack;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int fadeBlackBounceCount;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float targetBlack;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fadingWhite;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool fadingOutWhite;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int fadeBounceCountWhite;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float targetWhite;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool fadingRedVignette;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool fadingOutRedVignette;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int fadeBounceCountRedVignette;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float targetRedVignette;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool shaking;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool shakingOut;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int shakeBounceCount;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float targetShake;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 velocity;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 positionLastUpdate;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float positionStorageTime;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<PositionStorage> positionStorage;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float rotationStorageTime;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<RotationStorage> rotationStorage;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x8ADBA8", Offset = "0x8ADBA8", VA = "0x8ADBA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x8ADC50", Offset = "0x8ADC50", VA = "0x8ADC50")]
		private void Start()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x8ADDCC", Offset = "0x8ADDCC", VA = "0x8ADDCC")]
		private void Update()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x8AE1C4", Offset = "0x8AE1C4", VA = "0x8AE1C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x8AE2A0", Offset = "0x8AE2A0", VA = "0x8AE2A0")]
		public Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x8AE2AC", Offset = "0x8AE2AC", VA = "0x8AE2AC")]
		public void UpdateVelocity()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x8AE610", Offset = "0x8AE610", VA = "0x8AE610")]
		public Vector3 RecentMovementAdjustment(float afterSeconds)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x8AEAEC", Offset = "0x8AEAEC", VA = "0x8AEAEC")]
		public float GetRecentRotationDelta()
		{
			return default(float);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x8AEBFC", Offset = "0x8AEBFC", VA = "0x8AEBFC")]
		public void SetBWLevel(float level)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x8AEC84", Offset = "0x8AEC84", VA = "0x8AEC84")]
		public void SetVignetteLevel(float level)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x8AED0C", Offset = "0x8AED0C", VA = "0x8AED0C")]
		public void SetBlurLevel(float level)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x8AED10", Offset = "0x8AED10", VA = "0x8AED10")]
		public void SetDizzyLevel(float level)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x8AED98", Offset = "0x8AED98", VA = "0x8AED98")]
		private void UpdateBlur()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x8AED9C", Offset = "0x8AED9C", VA = "0x8AED9C")]
		public void Blackout()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x8AEDC0", Offset = "0x8AEDC0", VA = "0x8AEDC0")]
		public void FadeOut()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x8AEDD4", Offset = "0x8AEDD4", VA = "0x8AEDD4")]
		public void FadeIn()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x8AEDE4", Offset = "0x8AEDE4", VA = "0x8AEDE4")]
		public void FadeOutIn()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x8ADDF8", Offset = "0x8ADDF8", VA = "0x8ADDF8")]
		private void handleFade()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x8AEDFC", Offset = "0x8AEDFC", VA = "0x8AEDFC")]
		public void FadeOutBlack()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x8AEE10", Offset = "0x8AEE10", VA = "0x8AEE10")]
		public void FadeInBlack()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x8AEE20", Offset = "0x8AEE20", VA = "0x8AEE20")]
		public void FadeOutInBlack()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x8AEE38", Offset = "0x8AEE38", VA = "0x8AEE38")]
		private void handleFadeBlack()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x8AEF78", Offset = "0x8AEF78", VA = "0x8AEF78")]
		public void FadeOutWhite(float intensity = 1f)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x8AF010", Offset = "0x8AF010", VA = "0x8AF010")]
		public void FadeInWhite()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x8AF020", Offset = "0x8AF020", VA = "0x8AF020")]
		public void FadeOutInWhite(float intensity = 1f)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x8ADF2C", Offset = "0x8ADF2C", VA = "0x8ADF2C")]
		private void handleFadeWhite()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x8AF02C", Offset = "0x8AF02C", VA = "0x8AF02C")]
		public void FadeOutRedVignette(float intensity = 1f)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x8AF0C4", Offset = "0x8AF0C4", VA = "0x8AF0C4")]
		public void FadeInRedVignette()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x8AF0D4", Offset = "0x8AF0D4", VA = "0x8AF0D4")]
		public void FadeOutInRedVignette(float intensity = 1f)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x8AE078", Offset = "0x8AE078", VA = "0x8AE078")]
		private void handleFadeRedVignette()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x8AF0E0", Offset = "0x8AF0E0", VA = "0x8AF0E0")]
		public void Shake(float intensity = 1f)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x8AF17C", Offset = "0x8AF17C", VA = "0x8AF17C")]
		private void handleShake()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x8AF0EC", Offset = "0x8AF0EC", VA = "0x8AF0EC")]
		public void ShakeOut(float intensity = 1f)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x8AF2C8", Offset = "0x8AF2C8", VA = "0x8AF2C8")]
		public void ShakeIn()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x8AF2D8", Offset = "0x8AF2D8", VA = "0x8AF2D8")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class CameraFlash : MonoBehaviour
	{
		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE4DC", Offset = "0x6CE4DC")]
		private sealed class <DoCameraFlash>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CameraFlash <>4__this;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <counter>5__2;

			[Token(Token = "0x170000C0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000708")]
				[Address(RVA = "0x8AF50C", Offset = "0x8AF50C", VA = "0x8AF50C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600070A")]
				[Address(RVA = "0x8AF574", Offset = "0x8AF574", VA = "0x8AF574", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x8AF40C", Offset = "0x8AF40C", VA = "0x8AF40C")]
			[DebuggerHidden]
			public <DoCameraFlash>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x8AF440", Offset = "0x8AF440", VA = "0x8AF440", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x8AF444", Offset = "0x8AF444", VA = "0x8AF444", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x8AF514", Offset = "0x8AF514", VA = "0x8AF514", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x8AF348", Offset = "0x8AF348", VA = "0x8AF348")]
		public void Camera()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x8AF39C", Offset = "0x8AF39C", VA = "0x8AF39C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CFFA0", Offset = "0x6CFFA0")]
		public IEnumerator DoCameraFlash()
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x8AF438", Offset = "0x8AF438", VA = "0x8AF438")]
		public CameraFlash()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class CharacterOutfitPicker : MonoBehaviour
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] faces;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] hairs;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x8AF57C", Offset = "0x8AF57C", VA = "0x8AF57C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x8AF6C4", Offset = "0x8AF6C4", VA = "0x8AF6C4")]
		public CharacterOutfitPicker()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class ChildMenuManager : MonoBehaviour
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CECB0", Offset = "0x6CECB0")]
		private MenuManager <manager>k__BackingField;

		[Token(Token = "0x17000036")]
		public MenuManager manager
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x8AF6CC", Offset = "0x8AF6CC", VA = "0x8AF6CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0004", Offset = "0x6D0004")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x8AF6D4", Offset = "0x8AF6D4", VA = "0x8AF6D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0014", Offset = "0x6D0014")]
			set
			{
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x8AF6DC", Offset = "0x8AF6DC", VA = "0x8AF6DC", Slot = "4")]
		public virtual void OpenMenu()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x8AF704", Offset = "0x8AF704", VA = "0x8AF704", Slot = "5")]
		public virtual void CloseMenu()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x8AF72C", Offset = "0x8AF72C", VA = "0x8AF72C")]
		public ChildMenuManager()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AdvancedInspectorAttribute", RVA = "0x6CE318", Offset = "0x6CE318")]
	public class ContinueTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ProgressRadialBehaviour ProgressBar;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isCounting;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float count;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float triggerTime;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isTriggered;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool triggerState;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x8AF734", Offset = "0x8AF734", VA = "0x8AF734")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x8AF7AC", Offset = "0x8AF7AC", VA = "0x8AF7AC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x8AF820", Offset = "0x8AF820", VA = "0x8AF820")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x8AF864", Offset = "0x8AF864", VA = "0x8AF864")]
		private void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x8AF9E8", Offset = "0x8AF9E8", VA = "0x8AF9E8")]
		private void StartTimer()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x8AF824", Offset = "0x8AF824", VA = "0x8AF824")]
		private void ResetTimer()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x8AF9F8", Offset = "0x8AF9F8", VA = "0x8AF9F8")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6D0024", Offset = "0x6D0024")]
		public void ContinueBout()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x8AFA58", Offset = "0x8AFA58", VA = "0x8AFA58")]
		public ContinueTrigger()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class CornerPositionMarker : MonoBehaviour, IFixedUpdateable
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject menu;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Renderer marker;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float markerFadeRate;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material markerMaterial;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TMP_Text messageText;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool playerIsInTrigger;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool playerWasInTrigger;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float currentMarkerTransparency;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float targetMarkerTransparency;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x8AFAB4", Offset = "0x8AFAB4", VA = "0x8AFAB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x8AFB88", Offset = "0x8AFB88", VA = "0x8AFB88")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x8AFB90", Offset = "0x8AFB90", VA = "0x8AFB90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x8AFBC4", Offset = "0x8AFBC4", VA = "0x8AFBC4", Slot = "4")]
		public void CustomFixedUpdate()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x8AFBCC", Offset = "0x8AFBCC", VA = "0x8AFBCC")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x8AFCA8", Offset = "0x8AFCA8", VA = "0x8AFCA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x8AFD04", Offset = "0x8AFD04", VA = "0x8AFD04")]
		private void PlayerEnteredTrigger()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x8AFD3C", Offset = "0x8AFD3C", VA = "0x8AFD3C")]
		private void PlayerExitedTrigger()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x8AFD78", Offset = "0x8AFD78", VA = "0x8AFD78")]
		private void HandleMarkerFade()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x8AFE78", Offset = "0x8AFE78", VA = "0x8AFE78")]
		public CornerPositionMarker()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class CrowdController : MonoBehaviour
	{
		[Token(Token = "0x20000D1")]
		private enum CrowdState
		{
			[Token(Token = "0x40007DF")]
			Init,
			[Token(Token = "0x40007E0")]
			Walla,
			[Token(Token = "0x40007E1")]
			Watch,
			[Token(Token = "0x40007E2")]
			Cheer
		}

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrowdState crowdState;

		[Token(Token = "0x4000255")]
		private const float cheerTransitionTime = 1.5f;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CrowdController instance;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool canCheer;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool ambisonicSound;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AudienceController[] audience;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float cheerCounter;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float cheerFactor;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int waitFramesBeforeStarting;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int framesToWait;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform soundParent;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxWallaVolume;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip wallaClip;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float maxWatchVolume;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip watchClip;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float maxCheerVolume;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioClip cheerClip;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float maxReactionVolume;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioClip[] reactionClips;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AudioSource wallaSource;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioSource watchSource;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioSource cheerSource;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioSource reactionSource;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool isPlayingWalla;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool isPlayingWatch;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool isPlayingCheer;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float wallaVolume;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float watchVolume;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float cheerVolume;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float cheerOverride;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool useAudienceSounds;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x8AFE8C", Offset = "0x8AFE8C", VA = "0x8AFE8C")]
		public static void Walla()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x8B0038", Offset = "0x8B0038", VA = "0x8B0038")]
		public static void Watch()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x8B01E4", Offset = "0x8B01E4", VA = "0x8B01E4")]
		public static void Cheer()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x8B0390", Offset = "0x8B0390", VA = "0x8B0390")]
		public static void React()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x8B04F8", Offset = "0x8B04F8", VA = "0x8B04F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x8B054C", Offset = "0x8B054C", VA = "0x8B054C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x8B0F04", Offset = "0x8B0F04", VA = "0x8B0F04")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x8B0F54", Offset = "0x8B0F54", VA = "0x8B0F54")]
		public void Update()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x8B0D94", Offset = "0x8B0D94", VA = "0x8B0D94")]
		private AudienceController[] findAudience()
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x8B0FAC", Offset = "0x8B0FAC", VA = "0x8B0FAC")]
		private void PlaySomeCheerAnimations()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x8B13E8", Offset = "0x8B13E8", VA = "0x8B13E8")]
		private void AllPlayCheerAnimations()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x8AFF30", Offset = "0x8AFF30", VA = "0x8AFF30")]
		private void StartWallaLoop()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x8B00DC", Offset = "0x8B00DC", VA = "0x8B00DC")]
		private void StartWatchLoop()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x8B0288", Offset = "0x8B0288", VA = "0x8B0288")]
		private void StartCheerLoop()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x8B0434", Offset = "0x8B0434", VA = "0x8B0434")]
		private void PlayReactionClip()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x8B1058", Offset = "0x8B1058", VA = "0x8B1058")]
		private void UpdateCrowdSounds()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x8B146C", Offset = "0x8B146C", VA = "0x8B146C")]
		public CrowdController()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class CrowdGroupController : MonoBehaviour
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float holdTime;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float maxDelayTime;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool onlyCrossFadeAcrossTiers;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CECC0", Offset = "0x6CECC0")]
		private float <crossFadeTime>k__BackingField;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CECD0", Offset = "0x6CECD0")]
		private float <spatialBlend>k__BackingField;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CECE0", Offset = "0x6CECE0")]
		private float <maxVolume>k__BackingField;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CECF0", Offset = "0x6CECF0")]
		private float <maxDistance>k__BackingField;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioClip[] crowdLoops;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int excitementTier;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int excitementTierLastFrame;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudienceController[] audience;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool crossfading;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource oldSource;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource newSource;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool delaying;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float delayTimer;

		[Token(Token = "0x17000037")]
		public float crossFadeTime
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x8B1494", Offset = "0x8B1494", VA = "0x8B1494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0034", Offset = "0x6D0034")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x8B149C", Offset = "0x8B149C", VA = "0x8B149C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0044", Offset = "0x6D0044")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public float spatialBlend
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x8B14A4", Offset = "0x8B14A4", VA = "0x8B14A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0054", Offset = "0x6D0054")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x8B14AC", Offset = "0x8B14AC", VA = "0x8B14AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0064", Offset = "0x6D0064")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public float maxVolume
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x8B14B4", Offset = "0x8B14B4", VA = "0x8B14B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0074", Offset = "0x6D0074")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x8B14BC", Offset = "0x8B14BC", VA = "0x8B14BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0084", Offset = "0x6D0084")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public float maxDistance
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x8B14C4", Offset = "0x8B14C4", VA = "0x8B14C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0094", Offset = "0x6D0094")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x8B14CC", Offset = "0x8B14CC", VA = "0x8B14CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00A4", Offset = "0x6D00A4")]
			set
			{
			}
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x8B14D4", Offset = "0x8B14D4", VA = "0x8B14D4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x8B168C", Offset = "0x8B168C", VA = "0x8B168C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x8B15F0", Offset = "0x8B15F0", VA = "0x8B15F0")]
		private void InitAudioSource(AudioSource source, float volume = 0f)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x8B1A04", Offset = "0x8B1A04", VA = "0x8B1A04")]
		public void AssignAudioClips(AudioClip[] clips)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x8B1A0C", Offset = "0x8B1A0C", VA = "0x8B1A0C")]
		public void SetExcitementTier(int tier)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x8B1994", Offset = "0x8B1994", VA = "0x8B1994")]
		public void ClipSwitched()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x8B1A14", Offset = "0x8B1A14", VA = "0x8B1A14")]
		public CrowdGroupController()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class CustomizeBoutMenu : ChildMenuManager
	{
		[Token(Token = "0x4000283")]
		private const string venuePref = "venuePref";

		[Token(Token = "0x4000284")]
		private const string roundCountPref = "roundCountPref";

		[Token(Token = "0x4000285")]
		private const string roundTimePref = "roundTimePref";

		[Token(Token = "0x4000286")]
		private const string breakTimePref = "breakTimePref";

		[Token(Token = "0x4000287")]
		private const string chinPref = "chinPref";

		[Token(Token = "0x4000288")]
		private const string powerPref = "powerPref";

		[Token(Token = "0x4000289")]
		private const string fistSpeedPref = "fistSpeedPref";

		[Token(Token = "0x400028A")]
		private const string dodgeSpeedPref = "dodgeSpeedPref";

		[Token(Token = "0x400028B")]
		private const string blockSpeedPref = "blockSpeedPref";

		[Token(Token = "0x400028C")]
		private const string judgeStrictnessPref = "judgeStrictnessPref";

		[Token(Token = "0x400028D")]
		private const string aggressionPref = "aggressionPref";

		[Token(Token = "0x400028E")]
		private const string knockdownLimitPref = "knockdownLimitPref";

		[Token(Token = "0x400028F")]
		private const string traumaGainPref = "traumaGainPref";

		[Token(Token = "0x4000290")]
		private const string bodyRatePref = "bodyRatePref";

		[Token(Token = "0x4000291")]
		private const string jabRatePref = "jabRatePref";

		[Token(Token = "0x4000292")]
		private const string leftCrossRatePref = "leftCrossRatePref";

		[Token(Token = "0x4000293")]
		private const string rightCrossRatePref = "rightCrossRatePref";

		[Token(Token = "0x4000294")]
		private const string leftHookRatePref = "leftHookRatePref";

		[Token(Token = "0x4000295")]
		private const string rightHookRatePref = "rightHookRatePref";

		[Token(Token = "0x4000296")]
		private const string leftUppercutRatePref = "leftUppercutRatePref";

		[Token(Token = "0x4000297")]
		private const string rightUppercutRatePref = "rightUppercutRatePref";

		[Token(Token = "0x4000298")]
		private const int venueDefault = 1;

		[Token(Token = "0x4000299")]
		private const int roundCountDefault = 3;

		[Token(Token = "0x400029A")]
		private const int roundTimeDefault = 180;

		[Token(Token = "0x400029B")]
		private const int breakTimeDefault = 60;

		[Token(Token = "0x400029C")]
		private const int chinDefault = 100;

		[Token(Token = "0x400029D")]
		private const int powerDefault = 100;

		[Token(Token = "0x400029E")]
		private const int fistSpeedDefault = 100;

		[Token(Token = "0x400029F")]
		private const int dodgeSpeedDefault = 100;

		[Token(Token = "0x40002A0")]
		private const int blockSpeedDefault = 100;

		[Token(Token = "0x40002A1")]
		private const int judgeStrictnessDefault = 100;

		[Token(Token = "0x40002A2")]
		private const int knockdownLimitDefault = 3;

		[Token(Token = "0x40002A3")]
		private const int traumaGainDefault = 0;

		[Token(Token = "0x40002A4")]
		private const int aggressionDefault = 100;

		[Token(Token = "0x40002A5")]
		private const int bodyRateDefault = 100;

		[Token(Token = "0x40002A6")]
		private const int jabRateDefault = 100;

		[Token(Token = "0x40002A7")]
		private const int leftCrossRateDefault = 100;

		[Token(Token = "0x40002A8")]
		private const int rightCrossRateDefault = 100;

		[Token(Token = "0x40002A9")]
		private const int leftHookRateDefault = 100;

		[Token(Token = "0x40002AA")]
		private const int rightHookRateDefault = 100;

		[Token(Token = "0x40002AB")]
		private const int leftUppercutRateDefault = 100;

		[Token(Token = "0x40002AC")]
		private const int rightUppercutRateDefault = 100;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CED00", Offset = "0x6CED00")]
		private bool <isOpen>k__BackingField;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject difficultyMenu;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TotFSlider venueSlider;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TotFSlider roundCountSlider;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TotFSlider roundTimeSlider;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TotFSlider breakTimeSlider;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TotFSlider chinSlider;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TotFSlider powerSlider;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TotFSlider fistSpeedSlider;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TotFSlider dodgeSpeedSlider;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TotFSlider blockSpeedSlider;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TotFSlider aggressionSlider;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TotFSlider knockdownLimitSlider;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TotFSlider judgeStrictnessSlider;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TotFSlider traumaGainSlider;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public TotFSlider bodyRateSlider;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public TotFSlider jabRateSlider;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public TotFSlider leftCrossRateSlider;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TotFSlider rightCrossRateSlider;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TotFSlider leftHookRateSlider;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public TotFSlider rightHookRateSlider;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public TotFSlider leftUppercutRateSlider;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public TotFSlider rightUppercutRateSlider;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CED10", Offset = "0x6CED10")]
		private FightMenuManager <fightMenu>k__BackingField;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CED20", Offset = "0x6CED20")]
		private int <venue>k__BackingField;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CED30", Offset = "0x6CED30")]
		private int <roundCount>k__BackingField;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CED40", Offset = "0x6CED40")]
		private int <roundTime>k__BackingField;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CED50", Offset = "0x6CED50")]
		private int <breakTime>k__BackingField;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CED60", Offset = "0x6CED60")]
		private int <chin>k__BackingField;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CED70", Offset = "0x6CED70")]
		private int <power>k__BackingField;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CED80", Offset = "0x6CED80")]
		private int <fistSpeed>k__BackingField;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CED90", Offset = "0x6CED90")]
		private int <dodgeSpeed>k__BackingField;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEDA0", Offset = "0x6CEDA0")]
		private int <blockSpeed>k__BackingField;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEDB0", Offset = "0x6CEDB0")]
		private int <judgeStrictness>k__BackingField;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEDC0", Offset = "0x6CEDC0")]
		private int <knockdownLimit>k__BackingField;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEDD0", Offset = "0x6CEDD0")]
		private int <aggression>k__BackingField;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEDE0", Offset = "0x6CEDE0")]
		private float <traumaGainRate>k__BackingField;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEDF0", Offset = "0x6CEDF0")]
		private int <bodyRate>k__BackingField;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEE00", Offset = "0x6CEE00")]
		private int <jabRate>k__BackingField;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEE10", Offset = "0x6CEE10")]
		private int <leftCrossRate>k__BackingField;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEE20", Offset = "0x6CEE20")]
		private int <rightCrossRate>k__BackingField;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEE30", Offset = "0x6CEE30")]
		private int <leftHookRate>k__BackingField;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEE40", Offset = "0x6CEE40")]
		private int <rightHookRate>k__BackingField;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEE50", Offset = "0x6CEE50")]
		private int <leftUppercutRate>k__BackingField;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEE60", Offset = "0x6CEE60")]
		private int <rightUppercutRate>k__BackingField;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private string[] venueNames;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEE70", Offset = "0x6CEE70")]
		private bool <initialized>k__BackingField;

		[Token(Token = "0x1700003B")]
		public bool isOpen
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x8B1A80", Offset = "0x8B1A80", VA = "0x8B1A80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00B4", Offset = "0x6D00B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x8B1A88", Offset = "0x8B1A88", VA = "0x8B1A88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00C4", Offset = "0x6D00C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public FightMenuManager fightMenu
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x8B1A94", Offset = "0x8B1A94", VA = "0x8B1A94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00D4", Offset = "0x6D00D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x8B1A9C", Offset = "0x8B1A9C", VA = "0x8B1A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00E4", Offset = "0x6D00E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public string venueName
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x8B1AA4", Offset = "0x8B1AA4", VA = "0x8B1AA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public int venue
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x8B1AE4", Offset = "0x8B1AE4", VA = "0x8B1AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D00F4", Offset = "0x6D00F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x8B1AEC", Offset = "0x8B1AEC", VA = "0x8B1AEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0104", Offset = "0x6D0104")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public int roundCount
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x8B1AF4", Offset = "0x8B1AF4", VA = "0x8B1AF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0114", Offset = "0x6D0114")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x8B1AFC", Offset = "0x8B1AFC", VA = "0x8B1AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0124", Offset = "0x6D0124")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public int roundTime
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x8B1B04", Offset = "0x8B1B04", VA = "0x8B1B04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0134", Offset = "0x6D0134")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x8B1B0C", Offset = "0x8B1B0C", VA = "0x8B1B0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0144", Offset = "0x6D0144")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public int breakTime
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x8B1B14", Offset = "0x8B1B14", VA = "0x8B1B14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0154", Offset = "0x6D0154")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x8B1B1C", Offset = "0x8B1B1C", VA = "0x8B1B1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0164", Offset = "0x6D0164")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public int chin
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x8B1B24", Offset = "0x8B1B24", VA = "0x8B1B24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0174", Offset = "0x6D0174")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x8B1B2C", Offset = "0x8B1B2C", VA = "0x8B1B2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0184", Offset = "0x6D0184")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int power
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x8B1B34", Offset = "0x8B1B34", VA = "0x8B1B34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0194", Offset = "0x6D0194")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x8B1B3C", Offset = "0x8B1B3C", VA = "0x8B1B3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01A4", Offset = "0x6D01A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public int fistSpeed
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x8B1B44", Offset = "0x8B1B44", VA = "0x8B1B44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01B4", Offset = "0x6D01B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x8B1B4C", Offset = "0x8B1B4C", VA = "0x8B1B4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01C4", Offset = "0x6D01C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public int dodgeSpeed
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x8B1B54", Offset = "0x8B1B54", VA = "0x8B1B54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01D4", Offset = "0x6D01D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x8B1B5C", Offset = "0x8B1B5C", VA = "0x8B1B5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01E4", Offset = "0x6D01E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public int blockSpeed
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x8B1B64", Offset = "0x8B1B64", VA = "0x8B1B64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D01F4", Offset = "0x6D01F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x8B1B6C", Offset = "0x8B1B6C", VA = "0x8B1B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0204", Offset = "0x6D0204")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public int judgeStrictness
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x8B1B74", Offset = "0x8B1B74", VA = "0x8B1B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0214", Offset = "0x6D0214")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x8B1B7C", Offset = "0x8B1B7C", VA = "0x8B1B7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0224", Offset = "0x6D0224")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public int knockdownLimit
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x8B1B84", Offset = "0x8B1B84", VA = "0x8B1B84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0234", Offset = "0x6D0234")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x8B1B8C", Offset = "0x8B1B8C", VA = "0x8B1B8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0244", Offset = "0x6D0244")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public int aggression
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x8B1B94", Offset = "0x8B1B94", VA = "0x8B1B94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0254", Offset = "0x6D0254")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x8B1B9C", Offset = "0x8B1B9C", VA = "0x8B1B9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0264", Offset = "0x6D0264")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public float traumaGainRate
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x8B1BA4", Offset = "0x8B1BA4", VA = "0x8B1BA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0274", Offset = "0x6D0274")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x8B1BAC", Offset = "0x8B1BAC", VA = "0x8B1BAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0284", Offset = "0x6D0284")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public int bodyRate
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x8B1BB4", Offset = "0x8B1BB4", VA = "0x8B1BB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0294", Offset = "0x6D0294")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x8B1BBC", Offset = "0x8B1BBC", VA = "0x8B1BBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D02A4", Offset = "0x6D02A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public int jabRate
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x8B1BC4", Offset = "0x8B1BC4", VA = "0x8B1BC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D02B4", Offset = "0x6D02B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x8B1BCC", Offset = "0x8B1BCC", VA = "0x8B1BCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D02C4", Offset = "0x6D02C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public int leftCrossRate
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x8B1BD4", Offset = "0x8B1BD4", VA = "0x8B1BD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D02D4", Offset = "0x6D02D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x8B1BDC", Offset = "0x8B1BDC", VA = "0x8B1BDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D02E4", Offset = "0x6D02E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public int rightCrossRate
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x8B1BE4", Offset = "0x8B1BE4", VA = "0x8B1BE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D02F4", Offset = "0x6D02F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x8B1BEC", Offset = "0x8B1BEC", VA = "0x8B1BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0304", Offset = "0x6D0304")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public int leftHookRate
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x8B1BF4", Offset = "0x8B1BF4", VA = "0x8B1BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0314", Offset = "0x6D0314")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x8B1BFC", Offset = "0x8B1BFC", VA = "0x8B1BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0324", Offset = "0x6D0324")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public int rightHookRate
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x8B1C04", Offset = "0x8B1C04", VA = "0x8B1C04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0334", Offset = "0x6D0334")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x8B1C0C", Offset = "0x8B1C0C", VA = "0x8B1C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0344", Offset = "0x6D0344")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public int leftUppercutRate
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x8B1C14", Offset = "0x8B1C14", VA = "0x8B1C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0354", Offset = "0x6D0354")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x8B1C1C", Offset = "0x8B1C1C", VA = "0x8B1C1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0364", Offset = "0x6D0364")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public int rightUppercutRate
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x8B1C24", Offset = "0x8B1C24", VA = "0x8B1C24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0374", Offset = "0x6D0374")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x8B1C2C", Offset = "0x8B1C2C", VA = "0x8B1C2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0384", Offset = "0x6D0384")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool initialized
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x8B1C34", Offset = "0x8B1C34", VA = "0x8B1C34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0394", Offset = "0x6D0394")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x8B1C3C", Offset = "0x8B1C3C", VA = "0x8B1C3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D03A4", Offset = "0x6D03A4")]
			set
			{
			}
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x8B1C48", Offset = "0x8B1C48", VA = "0x8B1C48")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x8B1DEC", Offset = "0x8B1DEC", VA = "0x8B1DEC")]
		private void Start()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x8B1DF0", Offset = "0x8B1DF0", VA = "0x8B1DF0")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x8B213C", Offset = "0x8B213C", VA = "0x8B213C")]
		public void SetVenueSlider(int value)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x8B2894", Offset = "0x8B2894", VA = "0x8B2894")]
		public void SetVenueValue(float floatValue)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x8B2184", Offset = "0x8B2184", VA = "0x8B2184")]
		public void SetRoundCountSlider(int value)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x8B29BC", Offset = "0x8B29BC", VA = "0x8B29BC")]
		public void SetRoundCountValue(float floatValue)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x8B21CC", Offset = "0x8B21CC", VA = "0x8B21CC")]
		public void SetRoundTimeSlider(int value)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x8B2AB8", Offset = "0x8B2AB8", VA = "0x8B2AB8")]
		public void SetRoundTimeValue(float floatValue)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x8B2230", Offset = "0x8B2230", VA = "0x8B2230")]
		public void SetBreakTimeSlider(int value)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x8B2BDC", Offset = "0x8B2BDC", VA = "0x8B2BDC")]
		public void SetBreakTimeValue(float floatValue)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x8B2294", Offset = "0x8B2294", VA = "0x8B2294")]
		public void SetChinSlider(int value)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x8B2D00", Offset = "0x8B2D00", VA = "0x8B2D00")]
		public void SetChinValue(float floatValue)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x8B22DC", Offset = "0x8B22DC", VA = "0x8B22DC")]
		public void SetPowerSlider(int value)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x8B2E08", Offset = "0x8B2E08", VA = "0x8B2E08")]
		public void SetPowerValue(float floatValue)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x8B2324", Offset = "0x8B2324", VA = "0x8B2324")]
		public void SetFistSpeedSlider(int value)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x8B2F10", Offset = "0x8B2F10", VA = "0x8B2F10")]
		public void SetFistSpeedValue(float floatValue)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x8B2384", Offset = "0x8B2384", VA = "0x8B2384")]
		public void SetDodgeSpeedSlider(int value)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x8B3018", Offset = "0x8B3018", VA = "0x8B3018")]
		public void SetDodgeSpeedValue(float floatValue)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x8B23E4", Offset = "0x8B23E4", VA = "0x8B23E4")]
		public void SetBlockSpeedSlider(int value)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x8B3120", Offset = "0x8B3120", VA = "0x8B3120")]
		public void SetBlockSpeedValue(float floatValue)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x8B2444", Offset = "0x8B2444", VA = "0x8B2444")]
		public void SetAggressionSlider(int value)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x8B3228", Offset = "0x8B3228", VA = "0x8B3228")]
		public void SetAggressionValue(float floatValue)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x8B24EC", Offset = "0x8B24EC", VA = "0x8B24EC")]
		public void SetJudgeStrictnessSlider(int value)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x8B3330", Offset = "0x8B3330", VA = "0x8B3330")]
		public void SetJudgeStrictnessValue(float floatValue)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x8B24A4", Offset = "0x8B24A4", VA = "0x8B24A4")]
		public void SetKnockdownLimitSlider(int value)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x8B3438", Offset = "0x8B3438", VA = "0x8B3438")]
		public void SetKnockdownLimitValue(float floatValue)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x8B254C", Offset = "0x8B254C", VA = "0x8B254C")]
		public void SetTraumaGainSlider(int value)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x8B352C", Offset = "0x8B352C", VA = "0x8B352C")]
		public void SetTraumaGainValue(float floatValue)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x8B2594", Offset = "0x8B2594", VA = "0x8B2594")]
		public void SetBodyRateSlider(int prefValue)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x8B3734", Offset = "0x8B3734", VA = "0x8B3734")]
		public void SetBodyRateValue(float sliderValue)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x8B25F4", Offset = "0x8B25F4", VA = "0x8B25F4")]
		public void SetJabRateSlider(int prefValue)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x8B392C", Offset = "0x8B392C", VA = "0x8B392C")]
		public void SetJabRateValue(float sliderValue)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x8B2654", Offset = "0x8B2654", VA = "0x8B2654")]
		public void SetLeftCrossRateSlider(int value)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x8B3A34", Offset = "0x8B3A34", VA = "0x8B3A34")]
		public void SetLeftCrossRateValue(float floatValue)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x8B26B4", Offset = "0x8B26B4", VA = "0x8B26B4")]
		public void SetRightCrossRateSlider(int value)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x8B3B3C", Offset = "0x8B3B3C", VA = "0x8B3B3C")]
		public void SetRightCrossRateValue(float floatValue)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x8B2714", Offset = "0x8B2714", VA = "0x8B2714")]
		public void SetLeftHookRateSlider(int value)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x8B3C44", Offset = "0x8B3C44", VA = "0x8B3C44")]
		public void SetLeftHookRateValue(float floatValue)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x8B2774", Offset = "0x8B2774", VA = "0x8B2774")]
		public void SetRightHookRateSlider(int value)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x8B3D4C", Offset = "0x8B3D4C", VA = "0x8B3D4C")]
		public void SetRightHookRateValue(float floatValue)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x8B27D4", Offset = "0x8B27D4", VA = "0x8B27D4")]
		public void SetLeftUppercutRateSlider(int value)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x8B3E54", Offset = "0x8B3E54", VA = "0x8B3E54")]
		public void SetLeftUppercutRateValue(float floatValue)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x8B2834", Offset = "0x8B2834", VA = "0x8B2834")]
		public void SetRightUppercutRateSlider(int value)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x8B3F5C", Offset = "0x8B3F5C", VA = "0x8B3F5C")]
		public void SetRightUppercutRateValue(float floatValue)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x8B4064", Offset = "0x8B4064", VA = "0x8B4064", Slot = "4")]
		public override void OpenMenu()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x8B40B8", Offset = "0x8B40B8", VA = "0x8B40B8", Slot = "5")]
		public override void CloseMenu()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x8B416C", Offset = "0x8B416C", VA = "0x8B416C")]
		public void JumpStartInit()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x8B41C4", Offset = "0x8B41C4", VA = "0x8B41C4")]
		public void CloseButtonPressed()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x8B42E0", Offset = "0x8B42E0", VA = "0x8B42E0")]
		public void ResetNonstatOptions()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x8B4378", Offset = "0x8B4378", VA = "0x8B4378")]
		public void ResetOpponentOptionsButtonPressed()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x8B44C0", Offset = "0x8B44C0", VA = "0x8B44C0")]
		public void ResetOpponentOptionsButtonPressedEasy()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x8B4694", Offset = "0x8B4694", VA = "0x8B4694")]
		public void ResetOpponentOptionsButtonPressedMedium()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x8B4858", Offset = "0x8B4858", VA = "0x8B4858")]
		public void ResetOpponentOptionsButtonPressedHard()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x8B4A28", Offset = "0x8B4A28", VA = "0x8B4A28")]
		public void ResetOpponentOptionsButtonPressedExtraHard()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x8B4BF8", Offset = "0x8B4BF8", VA = "0x8B4BF8")]
		public CustomizeBoutMenu()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class DecalController : MonoBehaviour
	{
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x8B4C00", Offset = "0x8B4C00", VA = "0x8B4C00")]
		public void ApplyDecal(Texture[] applyTo, Texture decal, Vector3 location, Mesh mesh)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x8B4C04", Offset = "0x8B4C04", VA = "0x8B4C04")]
		public DecalController()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class DefaultHapticsSystem : IHapticsSystem
	{
		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static DefaultHapticsSystem _instance;

		[Token(Token = "0x17000054")]
		public static DefaultHapticsSystem instance
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x8B4C0C", Offset = "0x8B4C0C", VA = "0x8B4C0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x8B4C8C", Offset = "0x8B4C8C", VA = "0x8B4C8C")]
		public DefaultHapticsSystem()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x8B4C94", Offset = "0x8B4C94", VA = "0x8B4C94", Slot = "4")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x8B4C9C", Offset = "0x8B4C9C", VA = "0x8B4C9C", Slot = "5")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x8B4CA0", Offset = "0x8B4CA0", VA = "0x8B4CA0", Slot = "6")]
		public override void Unload()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x8B4CA4", Offset = "0x8B4CA4", VA = "0x8B4CA4", Slot = "7")]
		public override void Rumble(float intensity, BodyArea area)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x8B4E48", Offset = "0x8B4E48", VA = "0x8B4E48", Slot = "8")]
		public override void RumbleAtLocation(float strength, BodyArea area, float x, float y)
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class DesktopCameraButton : MonoBehaviour
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int type;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Button button;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text text;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject desktopCamera;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DesktopCameraButton[] buttons;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x8B4E54", Offset = "0x8B4E54", VA = "0x8B4E54")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x8B4EF8", Offset = "0x8B4EF8", VA = "0x8B4EF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x8B505C", Offset = "0x8B505C", VA = "0x8B505C")]
		private void OnTriggerEnter()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x8B4F8C", Offset = "0x8B4F8C", VA = "0x8B4F8C")]
		public void Press()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x8B514C", Offset = "0x8B514C", VA = "0x8B514C")]
		public void Depress()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x8B5204", Offset = "0x8B5204", VA = "0x8B5204")]
		public DesktopCameraButton()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class DifficultyButton : MonoBehaviour
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x8B520C", Offset = "0x8B520C", VA = "0x8B520C")]
		public DifficultyButton()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class DisplayScreen : MonoBehaviour
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<DisplayScreen> screens;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer r;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x8B5214", Offset = "0x8B5214", VA = "0x8B5214")]
		public static void Enable()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x8B52D0", Offset = "0x8B52D0", VA = "0x8B52D0")]
		public static void Disable()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x8B538C", Offset = "0x8B538C", VA = "0x8B538C")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x8B53F8", Offset = "0x8B53F8", VA = "0x8B53F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x8B54AC", Offset = "0x8B54AC", VA = "0x8B54AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x8B5588", Offset = "0x8B5588", VA = "0x8B5588")]
		public DisplayScreen()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class DrawAudience : MonoBehaviour
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera cam;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<AudienceGroup> groups;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x8B5590", Offset = "0x8B5590", VA = "0x8B5590")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x8B55E8", Offset = "0x8B55E8", VA = "0x8B55E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x8B5610", Offset = "0x8B5610", VA = "0x8B5610")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x8B56D4", Offset = "0x8B56D4", VA = "0x8B56D4")]
		public DrawAudience()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class DummyHitZone : HitZone
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MeshRenderer lightRenderer;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock properties;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int emissionPropertyID;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool flashing;

		[Token(Token = "0x40002EA")]
		private const float flashTime = 1f;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float flashTimer;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool hasLight;

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x8B56DC", Offset = "0x8B56DC", VA = "0x8B56DC", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x8B57A0", Offset = "0x8B57A0", VA = "0x8B57A0")]
		public void Update()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x8AD67C", Offset = "0x8AD67C", VA = "0x8AD67C")]
		public void TurnOnLight()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x8AD3C8", Offset = "0x8AD3C8", VA = "0x8AD3C8")]
		public void TurnOffLight()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x8AD9C8", Offset = "0x8AD9C8", VA = "0x8AD9C8")]
		public void FlashLight(float bonus)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x8B5848", Offset = "0x8B5848", VA = "0x8B5848")]
		public DummyHitZone()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class BlendshapeDefinition
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxValue;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEE80", Offset = "0x6CEE80")]
		private int <index>k__BackingField;

		[Token(Token = "0x17000055")]
		public int index
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x8CFAB4", Offset = "0x8CFAB4", VA = "0x8CFAB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D03B4", Offset = "0x6D03B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x8CFABC", Offset = "0x8CFABC", VA = "0x8CFABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D03C4", Offset = "0x6D03C4")]
			set
			{
			}
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x8CFAC4", Offset = "0x8CFAC4", VA = "0x8CFAC4")]
		public BlendshapeDefinition()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class EnemyBlendshapes
	{
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BlendshapeDefinition[] bs_damage_eyeL;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BlendshapeDefinition[] bs_damage_eyeR;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BlendshapeDefinition[] bs_damage_lipL;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BlendshapeDefinition[] bs_damage_lipR;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BlendshapeDefinition[] bs_damage_lipC;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BlendshapeDefinition[] bs_damage_headL;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BlendshapeDefinition[] bs_damage_headR;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlendshapeDefinition[] bs_damage_headC;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BlendshapeDefinition[] bs_damage_cheekL;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BlendshapeDefinition[] bs_damage_cheekR;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BlendshapeDefinition[] bs_damage_chinC;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BlendshapeDefinition[] bs_damage_nose;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public BlendshapeDefinition[] bs_reaction_pain;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public BlendshapeDefinition[] bs_reaction_blink;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BlendshapeDefinition[] bs_reaction_dazed;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BlendshapeDefinition[] bs_reaction_flinch;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BlendshapeDefinition[] bs_reaction_effort;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BlendshapeDefinition[] bs_reaction_tired;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x8B5850", Offset = "0x8B5850", VA = "0x8B5850")]
		public EnemyBlendshapes()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public enum DodgeAction
	{
		[Token(Token = "0x4000303")]
		None,
		[Token(Token = "0x4000304")]
		SlipBack,
		[Token(Token = "0x4000305")]
		SlipLeft,
		[Token(Token = "0x4000306")]
		SlipRight,
		[Token(Token = "0x4000307")]
		DuckDown,
		[Token(Token = "0x4000308")]
		DuckLeft,
		[Token(Token = "0x4000309")]
		DuckRight
	}
	[Token(Token = "0x200005A")]
	public class EnemyController : BoxerController
	{
		[Token(Token = "0x20000D2")]
		public enum BehaviorMode
		{
			[Token(Token = "0x40007E4")]
			Idle,
			[Token(Token = "0x40007E5")]
			Pursue,
			[Token(Token = "0x40007E6")]
			KeepAway,
			[Token(Token = "0x40007E7")]
			Attack,
			[Token(Token = "0x40007E8")]
			Retreat,
			[Token(Token = "0x40007E9")]
			PostMatch
		}

		[Token(Token = "0x20000D3")]
		public enum PunchStaminaLevel
		{
			[Token(Token = "0x40007EB")]
			StepIn,
			[Token(Token = "0x40007EC")]
			Punch,
			[Token(Token = "0x40007ED")]
			Combo
		}

		[Token(Token = "0x20000D4")]
		protected enum HandRestriction
		{
			[Token(Token = "0x40007EF")]
			None,
			[Token(Token = "0x40007F0")]
			NoLead,
			[Token(Token = "0x40007F1")]
			NoRear
		}

		[Token(Token = "0x20000D5")]
		public struct PunchAction
		{
			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string punchName;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public HitZone target;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float weight;

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x8F1EF0", Offset = "0x8F1EF0", VA = "0x8F1EF0")]
			public PunchAction(string setPunchName = "", [Optional] HitZone setTarget, float setWeight = 0f)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public class BlockPositions
		{
			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CFBE8", Offset = "0x6CFBE8")]
			public Vector3 leftHandFront;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 leftHandFrontRotation;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 leftElbowFront;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 rightHandFront;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector3 rightHandFrontRotation;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Vector3 rightElbowFront;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CFC20", Offset = "0x6CFC20")]
			public Vector3 leftHandSide;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Vector3 leftHandSideRotation;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Vector3 leftElbowSide;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Vector3 rightHandSide;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Vector3 rightHandSideRotation;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public Vector3 rightElbowSide;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CFC58", Offset = "0x6CFC58")]
			public Vector3 leftHandBody;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			public Vector3 leftHandBodyRotation;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Vector3 leftElbowBody;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			public Vector3 rightHandBody;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public Vector3 rightHandBodyRotation;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			public Vector3 rightElbowBody;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CFC90", Offset = "0x6CFC90")]
			public Vector3 leftHandBodyChinLeft;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			public Vector3 leftHandBodyChinLeftRotation;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public Vector3 leftElbowBodyChinLeft;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			public Vector3 rightHandBodyChinLeft;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			public Vector3 rightHandBodyChinLeftRotation;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			public Vector3 rightElbowBodyChinLeft;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CFCC8", Offset = "0x6CFCC8")]
			public Vector3 leftHandBodyChinRight;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			public Vector3 leftHandBodyChinRightRotation;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			public Vector3 leftElbowBodyChinRight;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
			public Vector3 rightHandBodyChinRight;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			public Vector3 rightHandBodyChinRightRotation;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			public Vector3 rightElbowBodyChinRight;

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x8F1EDC", Offset = "0x8F1EDC", VA = "0x8F1EDC")]
			public BlockPositions()
			{
			}
		}

		[Token(Token = "0x20000D7")]
		private enum BlockLocation
		{
			[Token(Token = "0x4000814")]
			Front,
			[Token(Token = "0x4000815")]
			Sides,
			[Token(Token = "0x4000816")]
			Body,
			[Token(Token = "0x4000817")]
			BodyChinLeft,
			[Token(Token = "0x4000818")]
			BodyChinRight
		}

		[Token(Token = "0x20000D8")]
		private enum BleedLocation
		{
			[Token(Token = "0x400081A")]
			foreheadL,
			[Token(Token = "0x400081B")]
			foreheadR,
			[Token(Token = "0x400081C")]
			eyeL,
			[Token(Token = "0x400081D")]
			eyeR,
			[Token(Token = "0x400081E")]
			cheekL,
			[Token(Token = "0x400081F")]
			cheekR,
			[Token(Token = "0x4000820")]
			nose,
			[Token(Token = "0x4000821")]
			mouth
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public struct BloodDecal
		{
			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float x;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float y;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float width;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float height;
		}

		[Token(Token = "0x20000DA")]
		private struct OpponentPositionHistory
		{
			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float time;

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x8F1EE4", Offset = "0x8F1EE4", VA = "0x8F1EE4")]
			public OpponentPositionHistory(Vector3 setPosition, float setTime)
			{
			}
		}

		[Token(Token = "0x20000DB")]
		public enum Arm
		{
			[Token(Token = "0x4000829")]
			Left,
			[Token(Token = "0x400082A")]
			Right,
			[Token(Token = "0x400082B")]
			Both
		}

		[Token(Token = "0x400030A")]
		private const float roundStartRetreatTime = 1f;

		[Token(Token = "0x400030B")]
		private const float dodgeStaminaVariance = 0.1f;

		[Token(Token = "0x400030C")]
		private const float punchStaminaVariance = 0.25f;

		[Token(Token = "0x400030D")]
		private const float painReactionBlockChance = 0.85f;

		[Token(Token = "0x400030E")]
		public const float forceRequiredForSweat = 2000f;

		[Token(Token = "0x400030F")]
		private const float maxNegativeZSpeed = -0.08f;

		[Token(Token = "0x4000310")]
		public const float movementAccelerationMin = 2f;

		[Token(Token = "0x4000311")]
		public const float movementAccelerationMax = 2f;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool isLeftHanded;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public int bodyMaterialSlot;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Muscle[] leftArmMuscles;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Muscle[] rightArmMuscles;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public float reachModifier;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public bool canBeHeldBack;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x145")]
		public bool canBlock;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x146")]
		public bool canRetreat;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x147")]
		public bool canDodge;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool expertDodge;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public BehaviorMode behaviorMode;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3 opponentPosition;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		protected Vector3 distanceFromOpponentVector;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		protected float distanceFromOpponentMagnitude;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 trueOpponentPosition;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		protected Vector3 trueDistanceFromOpponentVector;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		protected float trueDistanceFromOpponentMagnitude;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float movementReactionTime;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public float baseMovementReactionTime;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private float targetObservationTime;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public float baseTargetObservationTime;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float targetSpeed;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float targetSpeedZ;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float targetSpeedX;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		public float closestDistance;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public float farthestDistance;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private float minDistance;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		protected float closeDistance;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private float closeRange;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private float jabDistance;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private float jabRange;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float attackRange;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float stopAttackRange;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private float stepInRange;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float stepInDistance;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private float opponentRange;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private float distanceOutsideOpponentsRange;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private float retreatTimer;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		protected bool adjustPunchX;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		protected bool adjustPunchY;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		protected bool adjustPunchZ;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		protected bool homePunchX;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		protected bool homePunchY;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		protected bool homePunchZ;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		protected bool isGettingUp;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		protected bool isRagdoll;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		protected bool isKneeling;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEE90", Offset = "0x6CEE90")]
		private bool <isSteppingIn>k__BackingField;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		protected bool leadHandPunching;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E7")]
		protected bool rearHandPunching;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		protected bool punchMatchedTarget;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEEA0", Offset = "0x6CEEA0")]
		private Hitbox.PunchType <currentPunch>k__BackingField;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEEB0", Offset = "0x6CEEB0")]
		private string <currentPunchName>k__BackingField;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private bool autoLook;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		public float throwFakeTendency;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public float stepInTendency;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		public float offenseTendency;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public float offenseTendencyWhenOpponentIsDizzy;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private float cautionWhenDizzyTendency;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private float pursueDizzyTendency;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		public float punchStaminaCostModifier;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public float dodgeStaminaCostModifier;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		public float dodgeSpeedMultiplier;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private float dodgeStaminaCost;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float punchStaminaCost;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private float stepInStaminaCost;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private float staminaNeededToStepIn;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private float staminaNeededToPunch;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private float staminaNeededToCombo;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private float staminaNeededToDodge;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private float staminaNeededToStepInWhenRallying;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private float staminaNeededToPunchWhenRallying;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		private float staminaNeededToComboWhenRallying;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private float staminaNeededToComboWhenDizzy;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private float staminaNeededToPunchWhenDizzy;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private float staminaNeededToStepInWhenDizzy;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		private float staminaDrainForNextPunch;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private List<PunchAction> storedPunchActions;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		protected HitZone punchTarget;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEEC0", Offset = "0x6CEEC0")]
		private float <punchTypeMassModifier>k__BackingField;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CEED0", Offset = "0x6CEED0")]
		private float <punchTypeVelocity>k__BackingField;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public string enemyName;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public string enemyDefeatName;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private float dontAttackHitTimer;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private float dontAttackSwingTimer;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CEEE0", Offset = "0x6CEEE0")]
		public Material bruiseMaterial;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private Material[] materials;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Material[] bruiseMaterials;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CEF18", Offset = "0x6CEF18")]
		public Texture2D bleedingDecalTexture;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public Texture2D cutDecalTexture;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public Texture2D baseCutsTexture;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private Texture2D cutsTexture;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private Texture2D bleedingTexture;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private RenderTexture bruiseTexture;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private int BruiseRenderLayer;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		private int BruiseRenderLayerMask;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private int groundLayers;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public Transform belly;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float turnSpeed;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		protected static float maxAngleDifferenceFromOpponent;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CEF50", Offset = "0x6CEF50")]
		public bool forceBlockHigh;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E9")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CEF88", Offset = "0x6CEF88")]
		public bool forceBlockSides;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2EA")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CEFC0", Offset = "0x6CEFC0")]
		public bool forceBlockBody;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2EB")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CEFF8", Offset = "0x6CEFF8")]
		public bool forceBlockBodyChinLeft;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF030", Offset = "0x6CF030")]
		public bool forceBlockBodyChinRight;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF068", Offset = "0x6CF068")]
		public BlockPositions blockPositions;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private float blockSpeed;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
		private float effectiveBlockSpeed;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private float dodgeLevel;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x304")]
		private float dodgeRate;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private float dodgeSuperFastAcceleration;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		private float dodgeFastAcceleration;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private float dodgeSlowAcceleration;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
		private float dodgeMaxSpeed;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6CF0A0", Offset = "0x6CF0A0")]
		private bool dodging;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
		private int dodgeDirection;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private BlockLocation blockLocation;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		private float blockTimer;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		protected Vector3 oldLeftHandPosition;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		protected Vector3 oldRightHandPosition;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		protected float leftHandIKVelocity;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		protected float leftHandIKVelocityWeight;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		protected float rightHandIKVelocity;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
		protected float rightHandIKVelocityWeight;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF0B0", Offset = "0x6CF0B0")]
		private BoxerController <opponent>k__BackingField;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		public bool canBruise;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x359")]
		public bool canBump;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35A")]
		public bool canBleed;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Color[] bruiseColors;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
		private float leadHookTendency;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private float rearHookTendency;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x364")]
		private float leadUppercutTendency;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private float rearUppercutTendency;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		private float rearCrossTendency;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private float leadCrossTendency;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		private float jabTendency;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private float headTendency;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
		private float bodyTendency;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private float stepLeadHookTendency;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
		private float stepRearHookTendency;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private float stepLeadUppercutTendency;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38C")]
		private float stepRearUppercutTendency;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private float stepRearCrossTendency;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x394")]
		private float stepJabTendency;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		public float attackSpeed;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF0C0", Offset = "0x6CF0C0")]
		private float <effectiveAttackSpeed>k__BackingField;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		public float effectiveMassModifier;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
		public float defenseModifier;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		protected bool canBackUp;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF0D0", Offset = "0x6CF0D0")]
		private EnemyFist <leftFist>k__BackingField;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF0E0", Offset = "0x6CF0E0")]
		private EnemyFist <rightFist>k__BackingField;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF0F0", Offset = "0x6CF0F0")]
		private Animator <bodyAnimation>k__BackingField;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF100", Offset = "0x6CF100")]
		private FullBodyBipedIK <ik>k__BackingField;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF110", Offset = "0x6CF110")]
		private LookAtIK <lik>k__BackingField;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF120", Offset = "0x6CF120")]
		public int readySoundChance;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF158", Offset = "0x6CF158")]
		public LipSyncData[] attackSounds;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF190", Offset = "0x6CF190")]
		public LipSyncData[] readySounds;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF1C8", Offset = "0x6CF1C8")]
		public LipSyncData[] getHitSounds;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private Vector3 lookAtPosition;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x404")]
		private float lookAtPositionWeight;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private Vector3 leftHandIKPosition;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x414")]
		private float leftHandIKPositionWeight;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private Vector3 rightHandIKPosition;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x424")]
		private float rightHandIKPositionWeight;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		protected bool sweating;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42C")]
		protected float damageForehead;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		protected float damageNose;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x434")]
		protected float damageLipCenter;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		protected float damageForeheadL;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43C")]
		protected float damageEyeL;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		protected float damageCheekL;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x444")]
		protected float damageMouthL;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		protected float damageForeheadR;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44C")]
		protected float damageEyeR;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		protected float damageCheekR;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x454")]
		protected float damageMouthR;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF200", Offset = "0x6CF200")]
		public float bumpLocationFrontZ;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45C")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF238", Offset = "0x6CF238")]
		public float bumpLocationRightX;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF270", Offset = "0x6CF270")]
		public float bumpLocationLeftX;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x464")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF2A8", Offset = "0x6CF2A8")]
		public float bumpLocationLipMinY;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF2E0", Offset = "0x6CF2E0")]
		public float bumpLocationCheekMinY;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46C")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF318", Offset = "0x6CF318")]
		public float bumpLocationEyeMinY;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF350", Offset = "0x6CF350")]
		public float bumpLocationBrowMinY;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x474")]
		protected float cutChance;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		protected float cutReopenChance;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47C")]
		protected bool cutNose;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47D")]
		protected bool cutLipCenter;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47E")]
		protected bool cutForeheadL;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47F")]
		protected bool cutEyeL;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		protected bool cutCheekL;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x481")]
		protected bool cutForeheadR;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x482")]
		protected bool cutEyeR;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x483")]
		protected bool cutCheekR;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x484")]
		protected bool bleedingNose;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x485")]
		protected bool bleedingLipCenter;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x486")]
		protected bool bleedingForeheadL;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x487")]
		protected bool bleedingEyeL;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		protected bool bleedingCheekL;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x489")]
		protected bool bleedingForeheadR;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48A")]
		protected bool bleedingEyeR;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48B")]
		protected bool bleedingCheekR;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48C")]
		protected float expressPainTarget;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		protected float expressPainLevel;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x494")]
		protected float expressConcernTarget;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		protected float expressConcernLevel;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49C")]
		protected float expressEffortTarget;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		protected float expressEffortLevel;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A4")]
		protected float facialVarianceTarget;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		protected float facialVarianceLevel;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4AC")]
		protected float facialVarianceDeltaSpeed;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		protected float dizzyLayerTarget;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
		protected float dizzyLayerLevel;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static float minThreatVelocity;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CF388", Offset = "0x6CF388")]
		public EnemyBlendshapes blendshapes;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		public VertexSkinnedMeshRenderer bodyMesh;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		private MeshFilter meshFilter;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF3C0", Offset = "0x6CF3C0")]
		private LipSync <mouth>k__BackingField;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		public GameObject body;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6CF3D0", Offset = "0x6CF3D0")]
		public bool canSweat;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E1")]
		public bool useArmIK;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E2")]
		public bool forceLook;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		public Transform lookAt;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		private bool initIK;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		protected PuppetMaster pm;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		private Vector3 hipsForward;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50C")]
		private Vector3 hipsUp;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		private Vector3 bodyPositionLastFrame;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x524")]
		private Quaternion bodyRotationLastFrame;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x534")]
		private bool restrictedMovement;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x535")]
		private bool doBlinkCycle;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x536")]
		private bool blinking;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		private float blinkTimer;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53C")]
		private int hitLayerIndex;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		private int hitLayerIndex1;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x544")]
		private int hitLayerIndex2;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		protected bool isStunned;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54C")]
		private float staminaLevel;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF408", Offset = "0x6CF408")]
		private float staminaMax;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x554")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF440", Offset = "0x6CF440")]
		private float staminaRegen;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		private float fatigueLevel;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF478", Offset = "0x6CF478")]
		private float fatigueMax;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6CF4B0", Offset = "0x6CF4B0")]
		private float fatigueThreshold;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x564")]
		private float fatigueModifier;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF4E8", Offset = "0x6CF4E8")]
		public bool sb_sides;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x569")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF520", Offset = "0x6CF520")]
		public bool sb_front;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56A")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF558", Offset = "0x6CF558")]
		public bool sb_body;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56B")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF590", Offset = "0x6CF590")]
		public bool sb_body_left;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56C")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6CF5C8", Offset = "0x6CF5C8")]
		public bool sb_body_right;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		private int sb_choice;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x574")]
		private bool wasSetBlockPositions;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		private Transform sb_leftHandEffector;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		private Transform sb_rightHandEffector;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		private Transform sb_leftElbowEffector;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		private Transform sb_rightElbowEffector;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		private bool isComboing;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		private HitZone[] targets;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		private float[] targetObservationTimes;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		private bool doApplyBruise;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		public BloodDecal[] bloodDecals;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		private List<OpponentPositionHistory> opponentPositionHistory;

		[Token(Token = "0x4000416")]
		private const float maxHistoryTime = 0.5f;

		[Token(Token = "0x17000056")]
		public bool isSteppingIn
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x8B5858", Offset = "0x8B5858", VA = "0x8B5858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D03D4", Offset = "0x6D03D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x8B5860", Offset = "0x8B5860", VA = "0x8B5860")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D03E4", Offset = "0x6D03E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public Hitbox.PunchType currentPunch
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x8B586C", Offset = "0x8B586C", VA = "0x8B586C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D03F4", Offset = "0x6D03F4")]
			get
			{
				return default(Hitbox.PunchType);
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x8B5874", Offset = "0x8B5874", VA = "0x8B5874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0404", Offset = "0x6D0404")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public string currentPunchName
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x8B587C", Offset = "0x8B587C", VA = "0x8B587C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0414", Offset = "0x6D0414")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x8B5884", Offset = "0x8B5884", VA = "0x8B5884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0424", Offset = "0x6D0424")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public float punchTypeMassModifier
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x8B588C", Offset = "0x8B588C", VA = "0x8B588C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0434", Offset = "0x6D0434")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x8B5894", Offset = "0x8B5894", VA = "0x8B5894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0444", Offset = "0x6D0444")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public float punchTypeVelocity
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x8B589C", Offset = "0x8B589C", VA = "0x8B589C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0454", Offset = "0x6D0454")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x8B58A4", Offset = "0x8B58A4", VA = "0x8B58A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0464", Offset = "0x6D0464")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		private float dontAttackTimer
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x8B58AC", Offset = "0x8B58AC", VA = "0x8B58AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005C")]
		public BoxerController opponent
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x8B5928", Offset = "0x8B5928", VA = "0x8B5928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0474", Offset = "0x6D0474")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x8B5930", Offset = "0x8B5930", VA = "0x8B5930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0484", Offset = "0x6D0484")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public float effectiveAttackSpeed
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x8B5938", Offset = "0x8B5938", VA = "0x8B5938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0494", Offset = "0x6D0494")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x8B5940", Offset = "0x8B5940", VA = "0x8B5940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D04A4", Offset = "0x6D04A4")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public EnemyFist leftFist
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x8B5948", Offset = "0x8B5948", VA = "0x8B5948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D04B4", Offset = "0x6D04B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x8B5950", Offset = "0x8B5950", VA = "0x8B5950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D04C4", Offset = "0x6D04C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public EnemyFist rightFist
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x8B5958", Offset = "0x8B5958", VA = "0x8B5958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D04D4", Offset = "0x6D04D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x8B5960", Offset = "0x8B5960", VA = "0x8B5960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D04E4", Offset = "0x6D04E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public Animator bodyAnimation
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x8B5968", Offset = "0x8B5968", VA = "0x8B5968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D04F4", Offset = "0x6D04F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x8B5970", Offset = "0x8B5970", VA = "0x8B5970")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0504", Offset = "0x6D0504")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x8B5978", Offset = "0x8B5978", VA = "0x8B5978")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0514", Offset = "0x6D0514")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x8B5980", Offset = "0x8B5980", VA = "0x8B5980")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0524", Offset = "0x6D0524")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public LookAtIK lik
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x8B5988", Offset = "0x8B5988", VA = "0x8B5988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0534", Offset = "0x6D0534")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x8B5990", Offset = "0x8B5990", VA = "0x8B5990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0544", Offset = "0x6D0544")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public LipSync mouth
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x8B5998", Offset = "0x8B5998", VA = "0x8B5998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0554", Offset = "0x6D0554")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x8B59A0", Offset = "0x8B59A0", VA = "0x8B59A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0564", Offset = "0x6D0564")]
			set
			{
			}
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x8B59A8", Offset = "0x8B59A8", VA = "0x8B59A8", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x8B5CEC", Offset = "0x8B5CEC", VA = "0x8B5CEC")]
		private void SetBlendShapeWeight(int index, float value)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x8B5D14", Offset = "0x8B5D14", VA = "0x8B5D14")]
		private void FindBlendshapeIndexes(ref BlendshapeDefinition[] blendshapeDefinitions)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x8B5E38", Offset = "0x8B5E38", VA = "0x8B5E38")]
		private void LoadBlendshapeIndexes()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x8B5FB8", Offset = "0x8B5FB8", VA = "0x8B5FB8", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x8B6918", Offset = "0x8B6918", VA = "0x8B6918")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x8B69D8", Offset = "0x8B69D8", VA = "0x8B69D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x8B6A98", Offset = "0x8B6A98", VA = "0x8B6A98", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x8B730C", Offset = "0x8B730C", VA = "0x8B730C")]
		private void SetDizzyBlendshape(float value)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x8B7734", Offset = "0x8B7734", VA = "0x8B7734")]
		private void SetTiredBlendshape(float value)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x8B7EAC", Offset = "0x8B7EAC", VA = "0x8B7EAC")]
		public void SolveIK()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x8BBDD8", Offset = "0x8BBDD8", VA = "0x8BBDD8")]
		private void ExpendStamina(float staminaCost, float variance = 0f)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x8BBE98", Offset = "0x8BBE98", VA = "0x8BBE98")]
		private void SetFatigue(float newFatigueLevel)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x8BBF3C", Offset = "0x8BBF3C", VA = "0x8BBF3C", Slot = "44")]
		public override void RecoverFatigue(float recoveryTime)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x8BBF70", Offset = "0x8BBF70", VA = "0x8BBF70", Slot = "46")]
		protected virtual void startBlinkCycle()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x8BBFA8", Offset = "0x8BBFA8", VA = "0x8BBFA8", Slot = "47")]
		protected virtual void StopBlinkCycle()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x8B6D2C", Offset = "0x8B6D2C", VA = "0x8B6D2C")]
		protected void HandleBlink()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x8BBFBC", Offset = "0x8BBFBC", VA = "0x8BBFBC", Slot = "48")]
		protected virtual void setActiveFists()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x8BC0F8", Offset = "0x8BC0F8", VA = "0x8BC0F8", Slot = "49")]
		protected virtual void MakeBlink()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x8BC194", Offset = "0x8BC194", VA = "0x8BC194", Slot = "50")]
		protected virtual void StopBlink()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x8BC108", Offset = "0x8BC108", VA = "0x8BC108")]
		private void SetBlinkBlendshape(float value)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x8BC1A0", Offset = "0x8BC1A0", VA = "0x8BC1A0")]
		public void ExpressPain(float targetLevel)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x8BC1A8", Offset = "0x8BC1A8", VA = "0x8BC1A8")]
		public void ExpressConcern(float targetLevel)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x8BC1B0", Offset = "0x8BC1B0", VA = "0x8BC1B0")]
		public void ExpressEffort(float targetLevel)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x8B7398", Offset = "0x8B7398", VA = "0x8B7398")]
		public void UpdateExpressions()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x8BC2D0", Offset = "0x8BC2D0", VA = "0x8BC2D0")]
		private void SetEffortBlendshape(float value)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x8BC1B8", Offset = "0x8BC1B8", VA = "0x8BC1B8")]
		private void SetPainBlendshape(float value)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x8BC244", Offset = "0x8BC244", VA = "0x8BC244")]
		private void SetFlinchBlendshape(float value)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x8B8A58", Offset = "0x8B8A58", VA = "0x8B8A58")]
		public bool PrepareDodgeIKTargets()
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x8B877C", Offset = "0x8B877C", VA = "0x8B877C")]
		public bool PreparePunchIKTargets()
		{
			return default(bool);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x8B8B3C", Offset = "0x8B8B3C", VA = "0x8B8B3C")]
		public bool PrepareLookIKTargets()
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x8B8DC0", Offset = "0x8B8DC0", VA = "0x8B8DC0")]
		public bool PrepareBlockIKTargets(Vector3 bodyMovementSinceLastFrame, Quaternion bodyAngleSinceLastFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x8BC3AC", Offset = "0x8BC3AC", VA = "0x8BC3AC")]
		private void LookAtOpponent()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x8BC484", Offset = "0x8BC484", VA = "0x8BC484")]
		protected bool IsFacingOpponent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x8BC588", Offset = "0x8BC588", VA = "0x8BC588")]
		protected void HandleTurning()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x8BC730", Offset = "0x8BC730", VA = "0x8BC730")]
		protected void HandleMovement(float targetDistance)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x8BCE0C", Offset = "0x8BCE0C", VA = "0x8BCE0C")]
		public void ResetMovement()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x8BCE18", Offset = "0x8BCE18", VA = "0x8BCE18", Slot = "51")]
		public virtual void TookASwing()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x8BE27C", Offset = "0x8BE27C", VA = "0x8BE27C")]
		public void AddBruise(ComputeBuffer bonePosesBuffer, int boneCount)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x8BE438", Offset = "0x8BE438", VA = "0x8BE438", Slot = "52")]
		protected virtual bool AddBattleDamage(float force, bool hitOnHead, Vector3 hitLocation, Vector3 globalHitLocation)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x8BEED8", Offset = "0x8BEED8", VA = "0x8BEED8")]
		private void AddBloodTexture(BleedLocation bleedLocation)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x8BF134", Offset = "0x8BF134", VA = "0x8BF134")]
		private void CleanUpCuts()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x8BED34", Offset = "0x8BED34", VA = "0x8BED34")]
		private void SetForeheadDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x8BEDC0", Offset = "0x8BEDC0", VA = "0x8BEDC0")]
		private void SetNoseDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x8BEE4C", Offset = "0x8BEE4C", VA = "0x8BEE4C")]
		private void SetLipCenterDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x8BEB04", Offset = "0x8BEB04", VA = "0x8BEB04")]
		private void SetTempleLDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x8BEB90", Offset = "0x8BEB90", VA = "0x8BEB90")]
		private void SetEyeLDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x8BEC1C", Offset = "0x8BEC1C", VA = "0x8BEC1C")]
		private void SetCheekLDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x8BECA8", Offset = "0x8BECA8", VA = "0x8BECA8")]
		private void SetMouthLDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x8BF1C4", Offset = "0x8BF1C4", VA = "0x8BF1C4")]
		private void SetTempleRDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x8BF250", Offset = "0x8BF250", VA = "0x8BF250")]
		private void SetEyeRDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x8BF2DC", Offset = "0x8BF2DC", VA = "0x8BF2DC")]
		private void SetCheekRDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x8BF368", Offset = "0x8BF368", VA = "0x8BF368")]
		private void SetMouthRDamageBlendshape(float value)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x8BF3F4", Offset = "0x8BF3F4", VA = "0x8BF3F4", Slot = "20")]
		protected override void Knockdown(Hurtbox hurtbox, Hitbox hitbox)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x8BF700", Offset = "0x8BF700", VA = "0x8BF700", Slot = "39")]
		public override void HitTheRopes()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x8B7800", Offset = "0x8B7800", VA = "0x8B7800")]
		public void StartGettingUp()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x8BFA8C", Offset = "0x8BFA8C", VA = "0x8BFA8C")]
		public void GetUp(bool fromKO = false)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x8BFAC8", Offset = "0x8BFAC8", VA = "0x8BFAC8")]
		public void AnimationGetUp()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x8BFAE8", Offset = "0x8BFAE8", VA = "0x8BFAE8", Slot = "53")]
		public virtual void Knockout()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x8BFB50", Offset = "0x8BFB50", VA = "0x8BFB50")]
		private bool CanDodge()
		{
			return default(bool);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x8BC35C", Offset = "0x8BC35C", VA = "0x8BC35C")]
		private bool CanBlockLeft()
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x8BC384", Offset = "0x8BC384", VA = "0x8BC384")]
		private bool CanBlockRight()
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x8BFB78", Offset = "0x8BFB78", VA = "0x8BFB78", Slot = "54")]
		public virtual void StartPunch(string hand = "", float predictedContactTime = 0f)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x8BFE50", Offset = "0x8BFE50", VA = "0x8BFE50")]
		public void UpdatePunchTarget()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x8BFFF4", Offset = "0x8BFFF4", VA = "0x8BFFF4")]
		public void PlayGetHitSound(float intensity = 1f)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x8C014C", Offset = "0x8C014C", VA = "0x8C014C")]
		public void PlayAttackSound()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x8C0244", Offset = "0x8C0244", VA = "0x8C0244")]
		public void PlayReadySound()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x8BFD90", Offset = "0x8BFD90", VA = "0x8BFD90")]
		public void SometimesPlayAttackSound()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x8C033C", Offset = "0x8C033C", VA = "0x8C033C")]
		public void SometimesPlayReadySound()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x8C0424", Offset = "0x8C0424", VA = "0x8C0424")]
		public void SendToCorner()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x8C05C0", Offset = "0x8C05C0", VA = "0x8C05C0")]
		public void SendToNeutralCorner()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x8C06D4", Offset = "0x8C06D4", VA = "0x8C06D4")]
		public void HandleDefenseBehavior()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x8C0F04", Offset = "0x8C0F04", VA = "0x8C0F04")]
		private void TriggerPunch(string punchName, bool isCombo = false)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x8C14E0", Offset = "0x8C14E0", VA = "0x8C14E0", Slot = "55")]
		public virtual void PunchEnded(bool pauseOffense = true)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x8C15CC", Offset = "0x8C15CC", VA = "0x8C15CC", Slot = "56")]
		public virtual void PunchEnded(string endedPunchName)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x8C1618", Offset = "0x8C1618", VA = "0x8C1618")]
		protected HitZone[] GetOpponentHitZones()
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x8BD0D8", Offset = "0x8BD0D8", VA = "0x8BD0D8")]
		private bool FoundAnOpening(PunchStaminaLevel punchType = PunchStaminaLevel.Punch, HandRestriction handRestriction = HandRestriction.None)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x8C1634", Offset = "0x8C1634", VA = "0x8C1634", Slot = "57")]
		public virtual void DodgeEvent()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x8C1638", Offset = "0x8C1638", VA = "0x8C1638", Slot = "36")]
		public override void CelebrateWin()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x8C1694", Offset = "0x8C1694", VA = "0x8C1694", Slot = "37")]
		public override void MournLoss()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x8C0EC0", Offset = "0x8C0EC0", VA = "0x8C0EC0")]
		private void StartBlocking(BlockLocation setBlockLocation, bool canBeLockedOut = false)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x8BF6E0", Offset = "0x8BF6E0", VA = "0x8BF6E0")]
		public void StopBlocking(bool checkTimer = false)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x8B77C0", Offset = "0x8B77C0", VA = "0x8B77C0")]
		private void UpdateBlock()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x8B7BA8", Offset = "0x8B7BA8", VA = "0x8B7BA8")]
		private void UpdateDodge()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x8C15B8", Offset = "0x8C15B8", VA = "0x8C15B8")]
		private void PauseOffenseSwing(float time)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x8C16F4", Offset = "0x8C16F4", VA = "0x8C16F4")]
		private void PauseOffenseHit(float time)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x8C04FC", Offset = "0x8C04FC", VA = "0x8C04FC")]
		public void Move(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x8C1708", Offset = "0x8C1708", VA = "0x8C1708")]
		public void Move(Vector3 newPosition, bool lookAtPlayer = true)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x8C18E8", Offset = "0x8C18E8", VA = "0x8C18E8")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x8C1990", Offset = "0x8C1990", VA = "0x8C1990", Slot = "10")]
		protected override bool ReceiveDamage(float damage, Hurtbox.HurtboxType hurtboxType, [Optional] Hurtbox hurtbox, [Optional] Hitbox hitbox)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x8C1AD0", Offset = "0x8C1AD0", VA = "0x8C1AD0", Slot = "17")]
		protected override void BlockVisualResult(float force, Hitbox hitbox, Collision collision, bool isMajorHit)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x8C1E7C", Offset = "0x8C1E7C", VA = "0x8C1E7C", Slot = "15")]
		protected override void HurtboxCollisionVisualResult(float damage, float force, bool wasKnockedDown, Hurtbox hurtbox, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x8C265C", Offset = "0x8C265C", VA = "0x8C265C", Slot = "58")]
		public virtual void LookForOpponents()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x8C2868", Offset = "0x8C2868", VA = "0x8C2868", Slot = "12")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x8C2870", Offset = "0x8C2870", VA = "0x8C2870", Slot = "13")]
		public override string GetDefeatName()
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x8C2878", Offset = "0x8C2878", VA = "0x8C2878")]
		private void HandleIdleBehavior()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x8C2888", Offset = "0x8C2888", VA = "0x8C2888", Slot = "59")]
		protected virtual void SetBehavior(BehaviorMode newMode)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x8C2A8C", Offset = "0x8C2A8C", VA = "0x8C2A8C", Slot = "60")]
		protected virtual void HandlePursueBehavior()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x8C2CC4", Offset = "0x8C2CC4", VA = "0x8C2CC4", Slot = "61")]
		protected virtual void HandleKeepAwayBehavior()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x8C2F48", Offset = "0x8C2F48", VA = "0x8C2F48", Slot = "62")]
		protected virtual void HandleRetreatBehavior()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x8C3134", Offset = "0x8C3134", VA = "0x8C3134", Slot = "63")]
		protected virtual void HandleAttackBehavior()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x8BE0C0", Offset = "0x8BE0C0", VA = "0x8BE0C0")]
		private void SwingAtOpening(bool isCombo = false)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x8C2A18", Offset = "0x8C2A18", VA = "0x8C2A18")]
		private bool IsWillingToSwing()
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x8BCF94", Offset = "0x8BCF94", VA = "0x8BCF94")]
		private bool IsWillingToCombo()
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x8C0E98", Offset = "0x8C0E98", VA = "0x8C0E98")]
		private bool IsInOpponentsRange()
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x8C33E8", Offset = "0x8C33E8", VA = "0x8C33E8")]
		protected bool IsInStepInRange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x8C33CC", Offset = "0x8C33CC", VA = "0x8C33CC")]
		private bool IsTooClose()
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x8C2CA8", Offset = "0x8C2CA8", VA = "0x8C2CA8")]
		protected bool IsInAttackRange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x8C3338", Offset = "0x8C3338", VA = "0x8C3338")]
		protected bool IsOutsideAttackRange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x8BCFE8", Offset = "0x8BCFE8", VA = "0x8BCFE8")]
		private bool HasStaminaForPunch(PunchStaminaLevel punchStaminaLevel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x8C0EAC", Offset = "0x8C0EAC", VA = "0x8C0EAC")]
		private bool HasStaminaForDodge()
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x8C3404", Offset = "0x8C3404", VA = "0x8C3404")]
		private float GetEffectiveStaminaLevel()
		{
			return default(float);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x8B6DC4", Offset = "0x8B6DC4", VA = "0x8B6DC4")]
		private void UpdateReactionInformation()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x8B78BC", Offset = "0x8B78BC", VA = "0x8B78BC")]
		private void HandleBehavior()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x8C340C", Offset = "0x8C340C", VA = "0x8C340C")]
		public void StepInStart(string punchName, float startTime, float endTime, int layerIndex)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x8C36DC", Offset = "0x8C36DC", VA = "0x8C36DC", Slot = "22")]
		public override void PreMatchSetup()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x8C36E0", Offset = "0x8C36E0", VA = "0x8C36E0", Slot = "24")]
		public override void StartRound()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x8C36FC", Offset = "0x8C36FC", VA = "0x8C36FC", Slot = "25")]
		public override void StartRoundMovement()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x8C377C", Offset = "0x8C377C", VA = "0x8C377C", Slot = "27")]
		public override void StartBreakMovement()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x8C37A0", Offset = "0x8C37A0", VA = "0x8C37A0", Slot = "26")]
		public override void EndRound()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x8C37C0", Offset = "0x8C37C0", VA = "0x8C37C0", Slot = "28")]
		public override void ScoredKnockdownAction()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x8C37D4", Offset = "0x8C37D4", VA = "0x8C37D4", Slot = "29")]
		public override void KnockedDownMovement()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x8C37D8", Offset = "0x8C37D8", VA = "0x8C37D8", Slot = "30")]
		public override void GoToFarthestNeutralCorner()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x8C37DC", Offset = "0x8C37DC", VA = "0x8C37DC", Slot = "31")]
		public override void GetUpMovement()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x8C385C", Offset = "0x8C385C", VA = "0x8C385C", Slot = "32")]
		public override void ResumeFighting()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x8C3870", Offset = "0x8C3870", VA = "0x8C3870", Slot = "33")]
		public override void ResumeFightingMovement()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x8C38F0", Offset = "0x8C38F0", VA = "0x8C38F0", Slot = "34")]
		public override void PostMatchMovement()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x8C3A58", Offset = "0x8C3A58", VA = "0x8C3A58")]
		public void UnpinArms(Arm arm)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x8BFCC4", Offset = "0x8BFCC4", VA = "0x8BFCC4")]
		public void RepinArms(Arm arm = Arm.Both)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x8B8530", Offset = "0x8B8530", VA = "0x8B8530")]
		protected Vector3 AdjustPunchTarget(Vector3 basePosition, Vector3 targetPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x8C3B10", Offset = "0x8C3B10", VA = "0x8C3B10", Slot = "16")]
		protected override void HurtboxCollisionAudioResult(float damage, float force, bool wasKnockedDown, Hurtbox hurtbox, Hitbox hitbox, Collision collision, bool hitWeakSpot = false)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x8C3C48", Offset = "0x8C3C48", VA = "0x8C3C48", Slot = "41")]
		public override void SetHandicapValues(float chinValue, float powerValue, float fistSpeedValue, float dodgeSpeedValue, float blockSpeedValue, float aggressionValue)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x8C3C8C", Offset = "0x8C3C8C", VA = "0x8C3C8C", Slot = "42")]
		public override void SetPunchRatioValues(float bodyRate, float jabRate, float leftCrossRate, float rightCrossRate, float leftHookRate, float rightHookRate, float leftUppercutRate, float rightUppercutRate)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x8BF778", Offset = "0x8BF778", VA = "0x8BF778")]
		protected bool Unragdoll()
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x8C3D14", Offset = "0x8C3D14", VA = "0x8C3D14")]
		protected bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x8C3E8C", Offset = "0x8C3E8C", VA = "0x8C3E8C")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x8C3EB4", Offset = "0x8C3EB4", VA = "0x8C3EB4")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x8C3EDC", Offset = "0x8C3EDC", VA = "0x8C3EDC")]
		protected void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x8C409C", Offset = "0x8C409C", VA = "0x8C409C")]
		public EnemyController()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class EnemyFist : Hitbox
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool leftHand;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private EnemyController enemy;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF600", Offset = "0x6CF600")]
		private bool <attacking>k__BackingField;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF610", Offset = "0x6CF610")]
		private bool <active>k__BackingField;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF620", Offset = "0x6CF620")]
		private bool <blocked>k__BackingField;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF630", Offset = "0x6CF630")]
		private Vector3 <targetPosition>k__BackingField;

		[Token(Token = "0x17000064")]
		public bool attacking
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x8F1EFC", Offset = "0x8F1EFC", VA = "0x8F1EFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0574", Offset = "0x6D0574")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x8F1F04", Offset = "0x8F1F04", VA = "0x8F1F04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0584", Offset = "0x6D0584")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public bool active
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x8F1F10", Offset = "0x8F1F10", VA = "0x8F1F10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0594", Offset = "0x6D0594")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x8F1F18", Offset = "0x8F1F18", VA = "0x8F1F18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D05A4", Offset = "0x6D05A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool blocked
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x8F1F24", Offset = "0x8F1F24", VA = "0x8F1F24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D05B4", Offset = "0x6D05B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x8F1F2C", Offset = "0x8F1F2C", VA = "0x8F1F2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D05C4", Offset = "0x6D05C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public Vector3 targetPosition
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x8F1F38", Offset = "0x8F1F38", VA = "0x8F1F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D05D4", Offset = "0x6D05D4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x8F1F44", Offset = "0x8F1F44", VA = "0x8F1F44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D05E4", Offset = "0x6D05E4")]
			set
			{
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x8F1F50", Offset = "0x8F1F50", VA = "0x8F1F50")]
		public void Start()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x8F1FB0", Offset = "0x8F1FB0", VA = "0x8F1FB0", Slot = "13")]
		public override bool IsActive(bool isMajorHit)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x8F1FD0", Offset = "0x8F1FD0", VA = "0x8F1FD0")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x8F1FF0", Offset = "0x8F1FF0", VA = "0x8F1FF0", Slot = "9")]
		public override Vector3 GetVelocity(bool allowSmoothing = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x8F20C4", Offset = "0x8F20C4", VA = "0x8F20C4", Slot = "11")]
		public override float GetEffectiveMass(Vector3 collisionPoint, bool calibrationHit = false, bool returnUnmodifiedForce = false)
		{
			return default(float);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x8F21C8", Offset = "0x8F21C8", VA = "0x8F21C8", Slot = "5")]
		public override void LandedHit(PunchType punchType, float damage, float targetPainThreshold)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x8F2290", Offset = "0x8F2290", VA = "0x8F2290", Slot = "14")]
		public override void Deactivate(bool isMajorHit)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x8F2318", Offset = "0x8F2318", VA = "0x8F2318", Slot = "17")]
		public override bool IsBlocking()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x8F2368", Offset = "0x8F2368", VA = "0x8F2368")]
		public EnemyFist()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class Equipment : MonoBehaviour
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Rigidbody rb;

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x8F2378", Offset = "0x8F2378", VA = "0x8F2378", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x8F23D0", Offset = "0x8F23D0", VA = "0x8F23D0")]
		public Equipment()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class FightCamera : SpectatorCamera
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float acceleration;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float heightOffset;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minFOV;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float targetSpacingToZoomRatio;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float lookAngleDeadzone;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float fovDifferenceDeadzone;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxBadCameraPositionTime;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3[] cameraPositions;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform firstTarget;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Transform secondTarget;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform refereeTarget;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool initTargets;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float turnSpeed;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int positionIndex;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float badCameraPositionTimer;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x8F23D8", Offset = "0x8F23D8", VA = "0x8F23D8")]
		public static void SetTargets(Transform targetOne, Transform targetTwo, Transform refPosition)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x8F24D4", Offset = "0x8F24D4", VA = "0x8F24D4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x8F2550", Offset = "0x8F2550", VA = "0x8F2550", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x8F25D4", Offset = "0x8F25D4", VA = "0x8F25D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x8F2FC0", Offset = "0x8F2FC0", VA = "0x8F2FC0")]
		private void SwitchPositions(int index)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x8F3030", Offset = "0x8F3030", VA = "0x8F3030")]
		public FightCamera()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class FightMenuManager : ChildMenuManager
	{
		[Token(Token = "0x20000DC")]
		public enum SelectedDifficulty
		{
			[Token(Token = "0x400082D")]
			Custom,
			[Token(Token = "0x400082E")]
			Easy,
			[Token(Token = "0x400082F")]
			Medium,
			[Token(Token = "0x4000830")]
			Hard,
			[Token(Token = "0x4000831")]
			ExtraHard
		}

		[Serializable]
		[Token(Token = "0x20000DD")]
		public class OpponentDetails
		{
			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string boxerName;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string boxerBio;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string boutRules;

			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture boxerImage;

			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string sceneName;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string boxerResourceName;

			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string unlockCondition;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string customizeCondition;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int numberOfRounds;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public int roundTime;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int breakTime;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public int knockdownLimit;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float damageDifferenceToWin;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float judgeDecisionFuzziness;

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x8F321C", Offset = "0x8F321C", VA = "0x8F321C")]
			public bool IsUnlocked()
			{
				return default(bool);
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x8F4D90", Offset = "0x8F4D90", VA = "0x8F4D90")]
			public bool HasDefeatedEasy()
			{
				return default(bool);
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x8F4E50", Offset = "0x8F4E50", VA = "0x8F4E50")]
			public bool HasDefeatedMedium()
			{
				return default(bool);
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x8F4F10", Offset = "0x8F4F10", VA = "0x8F4F10")]
			public bool HasDefeatedHard()
			{
				return default(bool);
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x8F4FD0", Offset = "0x8F4FD0", VA = "0x8F4FD0")]
			public bool HasDefeatedExtraHard()
			{
				return default(bool);
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x8F4CD0", Offset = "0x8F4CD0", VA = "0x8F4CD0")]
			public bool IsCustomizable()
			{
				return default(bool);
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x8F5C5C", Offset = "0x8F5C5C", VA = "0x8F5C5C")]
			public OpponentDetails()
			{
			}
		}

		[Token(Token = "0x400042D")]
		public const float defaultChinEasy = 0.9524f;

		[Token(Token = "0x400042E")]
		public const float defaultPowerEasy = 0.95f;

		[Token(Token = "0x400042F")]
		public const float defaultFistSpeedEasy = 0.6f;

		[Token(Token = "0x4000430")]
		public const float defaultDodgeSpeedEasy = 1f;

		[Token(Token = "0x4000431")]
		public const float defaultBlockSpeedEasy = 1f;

		[Token(Token = "0x4000432")]
		public const float defaultAggressionEasy = 0.9f;

		[Token(Token = "0x4000433")]
		public const float defaultChinMedium = 1f;

		[Token(Token = "0x4000434")]
		public const float defaultPowerMedium = 1f;

		[Token(Token = "0x4000435")]
		public const float defaultFistSpeedMedium = 1f;

		[Token(Token = "0x4000436")]
		public const float defaultDodgeSpeedMedium = 1f;

		[Token(Token = "0x4000437")]
		public const float defaultBlockSpeedMedium = 1f;

		[Token(Token = "0x4000438")]
		public const float defaultAggressionMedium = 1f;

		[Token(Token = "0x4000439")]
		public const float defaultChinHard = 1.05f;

		[Token(Token = "0x400043A")]
		public const float defaultPowerHard = 1.05f;

		[Token(Token = "0x400043B")]
		public const float defaultFistSpeedHard = 1f;

		[Token(Token = "0x400043C")]
		public const float defaultDodgeSpeedHard = 1f;

		[Token(Token = "0x400043D")]
		public const float defaultBlockSpeedHard = 1f;

		[Token(Token = "0x400043E")]
		public const float defaultAggressionHard = 1.1f;

		[Token(Token = "0x400043F")]
		public const float defaultChinExtraHard = 1.1f;

		[Token(Token = "0x4000440")]
		public const float defaultPowerExtraHard = 1.1f;

		[Token(Token = "0x4000441")]
		public const float defaultFistSpeedExtraHard = 1.15f;

		[Token(Token = "0x4000442")]
		public const float defaultDodgeSpeedExtraHard = 1.15f;

		[Token(Token = "0x4000443")]
		public const float defaultBlockSpeedExtraHard = 1.15f;

		[Token(Token = "0x4000444")]
		public const float defaultAggressionExtraHard = 1.25f;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject leftArrow;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject rightArrow;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RawImage posterUI;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI nameUI;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI bioUI;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI boutRulesUI;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF640", Offset = "0x6CF640")]
		private HomeMenuManager <homeManager>k__BackingField;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool opponentLoaded;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int index;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CustomizeBoutMenu customizeMenu;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject customizeMessage;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject difficultyMenu;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color disabledColor;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color selectedColor;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color defaultColor;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Sprite undefeatedIcon;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Sprite defeatedIcon;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Sprite lockedIcon;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Image customizeButton;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public TextMeshProUGUI customizeButtonText;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI customizeButtonDescription;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Image customizeButtonIcon;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Image easyButton;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public TextMeshProUGUI easyButtonText;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public TextMeshProUGUI easyButtonDescription;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Image easyButtonIcon;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Image mediumButton;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public TextMeshProUGUI mediumButtonText;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public TextMeshProUGUI mediumButtonDescription;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Image mediumButtonIcon;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Image hardButton;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public TextMeshProUGUI hardButtonText;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public TextMeshProUGUI hardButtonDescription;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Image hardButtonIcon;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Image extraHardButton;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public TextMeshProUGUI extraHardButtonText;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public TextMeshProUGUI extraHardButtonDescription;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Image extraHardButtonIcon;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private SelectedDifficulty currentDifficulty;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private SelectedDifficulty defaultDifficulty;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool easyUnlocked;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool mediumUnlocked;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A")]
		private bool hardUnlocked;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16B")]
		private bool extraHardUnlocked;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private bool customizeUnlocked;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool extraBattle;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public OpponentDetails[] opponents;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private List<OpponentDetails> unlockedOpponents;

		[Token(Token = "0x17000068")]
		public HomeMenuManager homeManager
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x8F30B4", Offset = "0x8F30B4", VA = "0x8F30B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D05F4", Offset = "0x6D05F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x8F30BC", Offset = "0x8F30BC", VA = "0x8F30BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0604", Offset = "0x6D0604")]
			set
			{
			}
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x8F30C4", Offset = "0x8F30C4", VA = "0x8F30C4")]
		public void Awake()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x8F32DC", Offset = "0x8F32DC", VA = "0x8F32DC")]
		public void Start()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x8F37C4", Offset = "0x8F37C4", VA = "0x8F37C4")]
		public void LoadMainMenu(GameObject menuToFadeIn)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x8F3984", Offset = "0x8F3984", VA = "0x8F3984")]
		public bool LoadOpponentByUnlockString(string unlockCondition)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x8F3A74", Offset = "0x8F3A74", VA = "0x8F3A74")]
		public void LoadOpponent(string boxerName)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x8F3B24", Offset = "0x8F3B24", VA = "0x8F3B24")]
		public void OpenCustomizeMenu()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x8F41D0", Offset = "0x8F41D0", VA = "0x8F41D0")]
		public void SelectDifficultyButton(int difficulty)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x8F42D8", Offset = "0x8F42D8", VA = "0x8F42D8")]
		public void UpdateRulesText()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x8F3C50", Offset = "0x8F3C50", VA = "0x8F3C50")]
		private void SelectDifficulty(SelectedDifficulty difficulty, bool updatePlayerPref = false)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x8F4534", Offset = "0x8F4534", VA = "0x8F4534")]
		private void EnableDifficultyButton(SelectedDifficulty difficulty, bool hasDefeatedDifficulty)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x8F4934", Offset = "0x8F4934", VA = "0x8F4934")]
		private void DisableDifficultyButton(SelectedDifficulty difficulty)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x8F3330", Offset = "0x8F3330", VA = "0x8F3330")]
		public void LoadOpponent(int newIndex = 0)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x8F5090", Offset = "0x8F5090", VA = "0x8F5090")]
		private void ScrollNext()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x8F5124", Offset = "0x8F5124", VA = "0x8F5124")]
		private void ScrollPrevious()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x8F51A0", Offset = "0x8F51A0", VA = "0x8F51A0")]
		public void ButtonNext()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x8F529C", Offset = "0x8F529C", VA = "0x8F529C")]
		public void ButtonPrevious()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x8F5398", Offset = "0x8F5398", VA = "0x8F5398")]
		public void LoadFight()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x8F5BA0", Offset = "0x8F5BA0", VA = "0x8F5BA0", Slot = "4")]
		public override void OpenMenu()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x8F5BEC", Offset = "0x8F5BEC", VA = "0x8F5BEC", Slot = "5")]
		public override void CloseMenu()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x8F5C4C", Offset = "0x8F5C4C", VA = "0x8F5C4C")]
		public FightMenuManager()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class Fist : MonoBehaviour
	{
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x8F5D08", Offset = "0x8F5D08", VA = "0x8F5D08")]
		public Fist()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class FloorManager : MonoBehaviour
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] footfallSounds;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float volume;

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x8F5D10", Offset = "0x8F5D10", VA = "0x8F5D10")]
		public void PlayFloorSound()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x8F5DA8", Offset = "0x8F5DA8", VA = "0x8F5DA8")]
		public FloorManager()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class FocusBallCollider : Equipment, IFixedUpdateable
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FocusBallController controller;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 lastFixedUpdatePosition;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion lastFixedUpdateRotation;

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x8F5DB8", Offset = "0x8F5DB8", VA = "0x8F5DB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x8F5DC0", Offset = "0x8F5DC0", VA = "0x8F5DC0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x8F5DC8", Offset = "0x8F5DC8", VA = "0x8F5DC8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x8F5E1C", Offset = "0x8F5E1C", VA = "0x8F5E1C", Slot = "5")]
		public void CustomFixedUpdate()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x8F5E6C", Offset = "0x8F5E6C", VA = "0x8F5E6C")]
		public void Update()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x8F6058", Offset = "0x8F6058", VA = "0x8F6058")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x8F66E8", Offset = "0x8F66E8", VA = "0x8F66E8")]
		public FocusBallCollider()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class FocusBallController : MonoBehaviour
	{
		[Token(Token = "0x400047A")]
		public const float MaxExpectedBallForce = 400f;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FocusBallController instance;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform trainer;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpectatorCamera spectatorCamera;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject uiCanvas;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rigidbody ballRb;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform ballModel;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initialized;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform trainerSmallSpacePosition;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform trainerLargeSpacePosition;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float trainerSmallPositionWidth;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float trainerSmallPositionDepth;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float hitRefreshTime;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioClip[] hitSounds;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LineRenderer topRope;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 ballTopRopeLocation;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public LineRenderer bottomRope;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 ballBottomRopeLocation;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3[] topRopePositions;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] bottomRopePositions;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool watchForDodge;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool approachingHead;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int dodgeCount;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int bestDodgeCount;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int hitCount;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int bestHitCount;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float hitTimer;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public TextMeshProUGUI dodgeCountText;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI bestDodgeCountText;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI hitCountText;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI bestHitCountText;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool eventOn;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 ballCenterPoint;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x8F66F0", Offset = "0x8F66F0", VA = "0x8F66F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x8F67DC", Offset = "0x8F67DC", VA = "0x8F67DC")]
		public static void InitializeFocusBall()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x8F6880", Offset = "0x8F6880", VA = "0x8F6880")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x8F6D90", Offset = "0x8F6D90", VA = "0x8F6D90")]
		public void DeinitializeFocusBall()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x8F6E98", Offset = "0x8F6E98", VA = "0x8F6E98")]
		public void Awake()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x8F6F7C", Offset = "0x8F6F7C", VA = "0x8F6F7C")]
		public void PostSimulation()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x8F6F80", Offset = "0x8F6F80", VA = "0x8F6F80")]
		public void Update()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x8F735C", Offset = "0x8F735C", VA = "0x8F735C")]
		public void ResetBestHit()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x8F619C", Offset = "0x8F619C", VA = "0x8F619C")]
		public void ColliderHit(Collision collision, PlayerFist hitbox)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x8F6570", Offset = "0x8F6570", VA = "0x8F6570")]
		public void ColliderHit(Collision collision, Hurtbox hurtbox)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x8F7570", Offset = "0x8F7570", VA = "0x8F7570")]
		public void Exit()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x8F7574", Offset = "0x8F7574", VA = "0x8F7574")]
		public void CloseButtonPressed()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x8F7714", Offset = "0x8F7714", VA = "0x8F7714")]
		public void PlaySpaceUpdated()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x8F6B64", Offset = "0x8F6B64", VA = "0x8F6B64")]
		public void MovePlayer()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x8F7AE4", Offset = "0x8F7AE4", VA = "0x8F7AE4")]
		public void ResetBestButton()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x8F7330", Offset = "0x8F7330", VA = "0x8F7330")]
		private void SetText(TextMeshProUGUI ui, string val)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x8F6A54", Offset = "0x8F6A54", VA = "0x8F6A54")]
		private void ResetCount()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x8F6ADC", Offset = "0x8F6ADC", VA = "0x8F6ADC")]
		private void ResetBestCount()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x8F7BE8", Offset = "0x8F7BE8", VA = "0x8F7BE8")]
		public FocusBallController()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class GetUpStateBehavior : StateMachineBehaviour
	{
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x8F7C00", Offset = "0x8F7C00", VA = "0x8F7C00", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x8F7C7C", Offset = "0x8F7C7C", VA = "0x8F7C7C")]
		public GetUpStateBehavior()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class GlobalShaderEffectTester : MonoBehaviour
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF650", Offset = "0x6CF650")]
		public float desaturationLevel;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF668", Offset = "0x6CF668")]
		public float whiteFlashLevel;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF680", Offset = "0x6CF680")]
		public float vignetteLevel;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF698", Offset = "0x6CF698")]
		public float whiteVignetteLevel;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF6B0", Offset = "0x6CF6B0")]
		public float blinkLevel;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF6C8", Offset = "0x6CF6C8")]
		public float fadeToBlackLevel;

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x8F8104", Offset = "0x8F8104", VA = "0x8F8104")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x8F81D0", Offset = "0x8F81D0", VA = "0x8F81D0")]
		public GlobalShaderEffectTester()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class GloveCalibration : MonoBehaviour
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isLeft;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject Target;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject GloveModel;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject ControllerPosition;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject TargetPlaceholder;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ProgressRadialBehaviour ProgressBar;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GloveCalibrationController controller;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool entered;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float timer;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float timeout;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PlayerController player;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool init;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x8F81D8", Offset = "0x8F81D8", VA = "0x8F81D8")]
		public void Start()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x8F81DC", Offset = "0x8F81DC", VA = "0x8F81DC")]
		private void Init()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x8F82D4", Offset = "0x8F82D4", VA = "0x8F82D4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x8F8308", Offset = "0x8F8308", VA = "0x8F8308")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x8F8818", Offset = "0x8F8818", VA = "0x8F8818")]
		public void TriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x8F890C", Offset = "0x8F890C", VA = "0x8F890C")]
		public void TriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x8F8A20", Offset = "0x8F8A20", VA = "0x8F8A20")]
		public void CalibrationComplete()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x8F8A6C", Offset = "0x8F8A6C", VA = "0x8F8A6C")]
		public GloveCalibration()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class GloveCalibrationButton : MonoBehaviour
	{
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x8F8A7C", Offset = "0x8F8A7C", VA = "0x8F8A7C")]
		public GloveCalibrationButton()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class GloveCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GloveCalibration[] calibrators;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF6E0", Offset = "0x6CF6E0")]
		private HomeMenuManager <homeManager>k__BackingField;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlayerController _player;

		[Token(Token = "0x17000069")]
		public HomeMenuManager homeManager
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x8F8A84", Offset = "0x8F8A84", VA = "0x8F8A84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0614", Offset = "0x6D0614")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x8F8A8C", Offset = "0x8F8A8C", VA = "0x8F8A8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0624", Offset = "0x6D0624")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		private PlayerController player
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x8F8A94", Offset = "0x8F8A94", VA = "0x8F8A94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x8F8548", Offset = "0x8F8548", VA = "0x8F8548")]
		public void GloveCalibrated(bool isLeft, float posX, float posY, float posZ, float rotX, float rotY, float rotZ)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x8F9468", Offset = "0x8F9468", VA = "0x8F9468")]
		public void ActivateCalibration()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x8F93BC", Offset = "0x8F93BC", VA = "0x8F93BC")]
		private void DeactivateCalibration()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x8F96CC", Offset = "0x8F96CC", VA = "0x8F96CC")]
		public void SetControlType(int type)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x8F9784", Offset = "0x8F9784", VA = "0x8F9784")]
		public GloveCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class GloveCalibrationReset : MonoBehaviour
	{
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x8F978C", Offset = "0x8F978C", VA = "0x8F978C")]
		public GloveCalibrationReset()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class GloveCalibrationTrigger : MonoBehaviour
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GloveCalibration calibrator;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x8F9794", Offset = "0x8F9794", VA = "0x8F9794")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x8F97AC", Offset = "0x8F97AC", VA = "0x8F97AC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x8F97C4", Offset = "0x8F97C4", VA = "0x8F97C4")]
		public GloveCalibrationTrigger()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class GymPlayerPositioner : MonoBehaviour
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GymPlayerPositioner instance;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform trainer;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trainerSmallSpacePosition;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform trainerLargeSpacePosition;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float trainerSmallPositionWidth;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float trainerSmallPositionDepth;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SpectatorCamera spectatorCamera;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public HomeMenuManager homeMenu;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool eventOn;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x8F97CC", Offset = "0x8F97CC", VA = "0x8F97CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x8F9820", Offset = "0x8F9820", VA = "0x8F9820")]
		private void Start()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x8F9954", Offset = "0x8F9954", VA = "0x8F9954")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x8F7674", Offset = "0x8F7674", VA = "0x8F7674")]
		public static void InitializeBoard()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x8F9824", Offset = "0x8F9824", VA = "0x8F9824")]
		private void InitializeBoardLocal()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x8F69B4", Offset = "0x8F69B4", VA = "0x8F69B4")]
		public static void DeinitializeBoard()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x8F9C74", Offset = "0x8F9C74", VA = "0x8F9C74")]
		private void DeinitializeBoardLocal()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x8F9D64", Offset = "0x8F9D64", VA = "0x8F9D64")]
		public void PlaySpaceUpdated()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x8F9A48", Offset = "0x8F9A48", VA = "0x8F9A48")]
		public void MovePlayer()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x8F9D9C", Offset = "0x8F9D9C", VA = "0x8F9D9C")]
		public GymPlayerPositioner()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class HapticsController
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool keepCheckingNS;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool loaded;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IHapticsSystem haptics;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static PlayerController _player;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool hardlightConnected;

		[Token(Token = "0x1700006B")]
		public static PlayerController player
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x8F9DAC", Offset = "0x8F9DAC", VA = "0x8F9DAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x8F9EC8", Offset = "0x8F9EC8", VA = "0x8F9EC8")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x8F9FF8", Offset = "0x8F9FF8", VA = "0x8F9FF8")]
		public static void CheckStatus()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x8F9FFC", Offset = "0x8F9FFC", VA = "0x8F9FFC")]
		public static void LoadDefault()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x8F9F68", Offset = "0x8F9F68", VA = "0x8F9F68")]
		public static void LoadBHaptics()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x8FA08C", Offset = "0x8FA08C", VA = "0x8FA08C")]
		public static void Rumble(float strength, IHapticsSystem.BodyArea area)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x8FA150", Offset = "0x8FA150", VA = "0x8FA150")]
		public static void RumbleAtLocation(float strength, IHapticsSystem.BodyArea area, float x = 0f, float y = 0f)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x8FA230", Offset = "0x8FA230", VA = "0x8FA230")]
		public HapticsController()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class HeavyBagCollider : Equipment, IFixedUpdateable
	{
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HeavyBagController controller;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 lastFixedUpdatePosition;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion lastFixedUpdateRotation;

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x8FA2A4", Offset = "0x8FA2A4", VA = "0x8FA2A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x8FA2AC", Offset = "0x8FA2AC", VA = "0x8FA2AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x8FA2B4", Offset = "0x8FA2B4", VA = "0x8FA2B4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x8FA308", Offset = "0x8FA308", VA = "0x8FA308", Slot = "5")]
		public void CustomFixedUpdate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x8FA3D4", Offset = "0x8FA3D4", VA = "0x8FA3D4")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x8FA99C", Offset = "0x8FA99C", VA = "0x8FA99C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x8FAB88", Offset = "0x8FAB88", VA = "0x8FAB88")]
		public HeavyBagCollider()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class HeavyBagController : MonoBehaviour
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HeavyBagController instance;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float chainJingleForce;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trainer;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SpectatorCamera spectatorCamera;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rigidbody bagRb;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform bagModel;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Rigidbody bagFollowRb;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject uiCanvas;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float maxSpeed;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public HitRecapUI lastHitUI;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public HitRecapUI bestHitUI;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioClip[] hitSounds;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioClip[] chainSounds;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioSource chainAudioSource;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool initialized;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform trainerSmallSpacePosition;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform trainerLargeSpacePosition;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float trainerSmallPositionWidth;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float trainerSmallPositionDepth;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float bestDamage;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool eventOn;

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x8FAB90", Offset = "0x8FAB90", VA = "0x8FAB90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x8FAC6C", Offset = "0x8FAC6C", VA = "0x8FAC6C")]
		public static void InitializeHeavyBag()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x8FAD10", Offset = "0x8FAD10", VA = "0x8FAD10")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x8FB250", Offset = "0x8FB250", VA = "0x8FB250")]
		public void DeinitializeHeavyBag()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x8FB358", Offset = "0x8FB358", VA = "0x8FB358")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x8FB3C0", Offset = "0x8FB3C0", VA = "0x8FB3C0")]
		public void ResetBestHit()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x8FA4A0", Offset = "0x8FA4A0", VA = "0x8FA4A0")]
		public void ColliderHit(Collision collision, PlayerFist hitbox)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x8FBC24", Offset = "0x8FBC24", VA = "0x8FBC24")]
		public void Exit()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x8FB4C4", Offset = "0x8FB4C4", VA = "0x8FB4C4")]
		private void ReceiveForceFromCollision(Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x8FBC28", Offset = "0x8FBC28", VA = "0x8FBC28")]
		public void CloseButtonPressed()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x8FBD28", Offset = "0x8FBD28", VA = "0x8FBD28")]
		public void PlaySpaceUpdated()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x8FB024", Offset = "0x8FB024", VA = "0x8FB024")]
		public void MovePlayer()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x8FBD2C", Offset = "0x8FBD2C", VA = "0x8FBD2C")]
		public HeavyBagController()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class HeavyBagExitButton : MonoBehaviour
	{
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HeavyBagController controller;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x8FBD50", Offset = "0x8FBD50", VA = "0x8FBD50")]
		public void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x8FBEA0", Offset = "0x8FBEA0", VA = "0x8FBEA0")]
		public void MoveToBoard()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x8FBEC0", Offset = "0x8FBEC0", VA = "0x8FBEC0")]
		public HeavyBagExitButton()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class HeavyBagPoster : MonoBehaviour
	{
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x8FBEC8", Offset = "0x8FBEC8", VA = "0x8FBEC8")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x8FBF94", Offset = "0x8FBF94", VA = "0x8FBF94")]
		public void MoveToHeavyBag()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x8FBF98", Offset = "0x8FBF98", VA = "0x8FBF98")]
		public HeavyBagPoster()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class HeightCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject message;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WeighInController calibrator;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x8FBFA0", Offset = "0x8FBFA0", VA = "0x8FBFA0")]
		public void ActivateCalibration()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x8FBFE4", Offset = "0x8FBFE4", VA = "0x8FBFE4")]
		public void DeactivateCalibration()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x8FC024", Offset = "0x8FC024", VA = "0x8FC024")]
		public HeightCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class HitRecapUI : MonoBehaviour
	{
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI rawForceText;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI velocityText;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI massTransferText;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI bonusText;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI punchTypeText;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string defaultVal;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string punchTypeJabVal;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string punchTypeRightCrossVal;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string punchTypeLeftCrossVal;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string punchTypeRightHookVal;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string punchTypeLeftHookVal;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string punchTypeRightUpperVal;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string punchTypeLeftUpperVal;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x8FC02C", Offset = "0x8FC02C", VA = "0x8FC02C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x8FAE48", Offset = "0x8FAE48", VA = "0x8FAE48")]
		public void ResetText()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x8FB4E0", Offset = "0x8FB4E0", VA = "0x8FB4E0")]
		public void UpdateText(bool isDamage, float rawForce, float velocity, float massTransfer, Hitbox.PunchType punchType, float bonus = -200f)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x8FC030", Offset = "0x8FC030", VA = "0x8FC030")]
		public HitRecapUI()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CE328", Offset = "0x6CE328")]
	public class HitZone : MonoBehaviour
	{
		[Token(Token = "0x20000DE")]
		public enum HitZoneType
		{
			[Token(Token = "0x4000841")]
			Chin,
			[Token(Token = "0x4000842")]
			Temple,
			[Token(Token = "0x4000843")]
			Uppercut,
			[Token(Token = "0x4000844")]
			Crown,
			[Token(Token = "0x4000845")]
			Liver,
			[Token(Token = "0x4000846")]
			SolarPlexus,
			[Token(Token = "0x4000847")]
			Custom
		}

		[Token(Token = "0x40004E7")]
		private const float blockCheckDistance = 0.46f;

		[Token(Token = "0x40004E8")]
		private const float blockCheckRadius = 0.1f;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF6F0", Offset = "0x6CF6F0")]
		private BoxerController <owner>k__BackingField;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float modifier;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float angleNeededToHit;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float leniency;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public HitZoneType type;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Hurtbox.HurtboxType forHurtboxType;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 checkBoxExtents;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoxCollider boxCollider;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider[] colliderCheckArray;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform blockCheckOverride;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF700", Offset = "0x6CF700")]
		private int <hitboxLayerMask>k__BackingField;

		[Token(Token = "0x1700006C")]
		public BoxerController owner
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x8FC0F8", Offset = "0x8FC0F8", VA = "0x8FC0F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0634", Offset = "0x6D0634")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x8FC100", Offset = "0x8FC100", VA = "0x8FC100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0644", Offset = "0x6D0644")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public int hitboxLayerMask
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x8FC108", Offset = "0x8FC108", VA = "0x8FC108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0654", Offset = "0x6D0654")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x8FC110", Offset = "0x8FC110", VA = "0x8FC110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0664", Offset = "0x6D0664")]
			set
			{
			}
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x8FC118", Offset = "0x8FC118", VA = "0x8FC118", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x8FC264", Offset = "0x8FC264", VA = "0x8FC264")]
		public float CalculateAlignment(Vector3 angleOfAttack)
		{
			return default(float);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x8FC394", Offset = "0x8FC394", VA = "0x8FC394")]
		public float CalculateEffectiveMultiplier(float alignment)
		{
			return default(float);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x8FC3A8", Offset = "0x8FC3A8", VA = "0x8FC3A8")]
		public bool IsBeingStruckBy(Hitbox hitbox, Hurtbox.HurtboxType hurtboxType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x8FC5CC", Offset = "0x8FC5CC", VA = "0x8FC5CC")]
		public bool IsBlocked()
		{
			return default(bool);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x8FC5D4", Offset = "0x8FC5D4", VA = "0x8FC5D4")]
		public void SetOwner(BoxerController newOwner)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x8FC5DC", Offset = "0x8FC5DC", VA = "0x8FC5DC")]
		public Vector3 PredictPosition(float afterSeconds)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x8FC6C4", Offset = "0x8FC6C4", VA = "0x8FC6C4")]
		public HitZone()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class Hitbox : MonoBehaviour
	{
		[Token(Token = "0x20000DF")]
		public enum PunchType
		{
			[Token(Token = "0x4000849")]
			None,
			[Token(Token = "0x400084A")]
			LeftJab,
			[Token(Token = "0x400084B")]
			RightJab,
			[Token(Token = "0x400084C")]
			LeftCross,
			[Token(Token = "0x400084D")]
			RightCross,
			[Token(Token = "0x400084E")]
			RightHook,
			[Token(Token = "0x400084F")]
			LeftHook,
			[Token(Token = "0x4000850")]
			RightUpper,
			[Token(Token = "0x4000851")]
			LeftUpper
		}

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Hitbox> _hitboxesInScene;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF710", Offset = "0x6CF710")]
		private BoxerController <owner>k__BackingField;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Vector3 velocity;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF720", Offset = "0x6CF720")]
		private Vector3 <positionLastUpdate>k__BackingField;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Rigidbody rb;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float rbMass;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF730", Offset = "0x6CF730")]
		private PunchType <lastPunchType>k__BackingField;

		[Token(Token = "0x1700006E")]
		private static List<Hitbox> hitboxesInScene
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x8FC74C", Offset = "0x8FC74C", VA = "0x8FC74C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public BoxerController owner
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x8FC7E0", Offset = "0x8FC7E0", VA = "0x8FC7E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0674", Offset = "0x6D0674")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x8FC7E8", Offset = "0x8FC7E8", VA = "0x8FC7E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0684", Offset = "0x6D0684")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public Vector3 positionLastUpdate
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x8FC7F0", Offset = "0x8FC7F0", VA = "0x8FC7F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0694", Offset = "0x6D0694")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x8FC7FC", Offset = "0x8FC7FC", VA = "0x8FC7FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D06A4", Offset = "0x6D06A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public PunchType lastPunchType
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x8FC808", Offset = "0x8FC808", VA = "0x8FC808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D06B4", Offset = "0x6D06B4")]
			get
			{
				return default(PunchType);
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x8FC810", Offset = "0x8FC810", VA = "0x8FC810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D06C4", Offset = "0x6D06C4")]
			set
			{
			}
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x8FC818", Offset = "0x8FC818", VA = "0x8FC818")]
		public static List<Hitbox> GetHitboxesInScene()
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x8FC81C", Offset = "0x8FC81C", VA = "0x8FC81C")]
		private void RegisterHitbox()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x8FC878", Offset = "0x8FC878", VA = "0x8FC878", Slot = "4")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x8FC8E8", Offset = "0x8FC8E8", VA = "0x8FC8E8")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x8FC940", Offset = "0x8FC940", VA = "0x8FC940")]
		public void SetOwner(BoxerController newOwner)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x8FC948", Offset = "0x8FC948", VA = "0x8FC948")]
		public bool IsOwner(BoxerController candidateOwner)
		{
			return default(bool);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x8FC9C4", Offset = "0x8FC9C4", VA = "0x8FC9C4", Slot = "5")]
		public virtual void LandedHit(PunchType punchType, float damage, float targetPainThreshold)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x8FC9C8", Offset = "0x8FC9C8", VA = "0x8FC9C8")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x8FCC2C", Offset = "0x8FCC2C", VA = "0x8FCC2C", Slot = "6")]
		public virtual void ReceiveHitboxCollision(float force, Hitbox otherHitbox, Collision collision, bool isMajorHit)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x8FCCC4", Offset = "0x8FCCC4", VA = "0x8FCCC4", Slot = "7")]
		public virtual bool CausedMajorCollision(Collider other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x8FCCCC", Offset = "0x8FCCCC", VA = "0x8FCCCC", Slot = "8")]
		public virtual void ReceiveForce(float force, bool isMajorHit, Collision collision)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x8FCCD0", Offset = "0x8FCCD0", VA = "0x8FCCD0", Slot = "9")]
		public virtual Vector3 GetVelocity(bool allowSmoothing = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x8FCCDC", Offset = "0x8FCCDC", VA = "0x8FCCDC", Slot = "10")]
		public virtual void UpdateVelocity()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x8FCDF8", Offset = "0x8FCDF8", VA = "0x8FCDF8", Slot = "11")]
		public virtual float GetEffectiveMass(Vector3 collisionPoint, bool calibrationHit = false, bool returnUnmodifiedForce = false)
		{
			return default(float);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x8FCE00", Offset = "0x8FCE00", VA = "0x8FCE00", Slot = "12")]
		public virtual float GetRigidbodyMass()
		{
			return default(float);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x8FCE08", Offset = "0x8FCE08", VA = "0x8FCE08", Slot = "13")]
		public virtual bool IsActive(bool majorHit)
		{
			return default(bool);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x8FCE10", Offset = "0x8FCE10", VA = "0x8FCE10", Slot = "14")]
		public virtual void Deactivate(bool majorHit)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x8FCE14", Offset = "0x8FCE14", VA = "0x8FCE14", Slot = "15")]
		public virtual void ClearVelocity()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x8FCEA8", Offset = "0x8FCEA8", VA = "0x8FCEA8", Slot = "16")]
		public virtual void DeactivateIfInactive(bool majorHit = true)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x8FCF00", Offset = "0x8FCF00", VA = "0x8FCF00", Slot = "17")]
		public virtual bool IsBlocking()
		{
			return default(bool);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x8F2370", Offset = "0x8F2370", VA = "0x8F2370")]
		public Hitbox()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class HomeMenuManager : MenuManager
	{
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool arcadeMode;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MainMenuManager mainMenu;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FightMenuManager opponentSelectMenu;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FightMenuManager extraBattleMenu;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ScoreCardGenerator scorecard;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SettingsMenu settingsMenu;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GloveCalibrationController gloveCalibration;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CustomizeBoutMenu customizeMenu;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BhapticsMenuManager bhapticsMenu;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x8FCF08", Offset = "0x8FCF08", VA = "0x8FCF08")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x8FD0A4", Offset = "0x8FD0A4", VA = "0x8FD0A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x8FD30C", Offset = "0x8FD30C", VA = "0x8FD30C")]
		public void CloseAllMenus()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x8F3950", Offset = "0x8F3950", VA = "0x8F3950")]
		public void OpenMainMenu()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x8FD3CC", Offset = "0x8FD3CC", VA = "0x8FD3CC")]
		public void OpenBhapticsMenu()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x8FD2A4", Offset = "0x8FD2A4", VA = "0x8FD2A4")]
		public void OpenFightMenu()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x8FD2D8", Offset = "0x8FD2D8", VA = "0x8FD2D8")]
		public void OpenExtraBattleMenu()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x8F9610", Offset = "0x8F9610", VA = "0x8F9610")]
		public void OpenSettingsMenu()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x8F9548", Offset = "0x8F9548", VA = "0x8F9548")]
		public void OpenGloveCalibration()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x8F9A30", Offset = "0x8F9A30", VA = "0x8F9A30")]
		public void UpdateMainMenuStats()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x8FD988", Offset = "0x8FD988", VA = "0x8FD988")]
		public HomeMenuManager()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class Hurtbox : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		public enum HurtboxType
		{
			[Token(Token = "0x4000853")]
			Head,
			[Token(Token = "0x4000854")]
			Body,
			[Token(Token = "0x4000855")]
			Other
		}

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float MaximumHurtboxVelocity;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HurtboxType type;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float width;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetX;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float height;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float offsetY;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF740", Offset = "0x6CF740")]
		private BoxerController <owner>k__BackingField;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 velocity;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody rb;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float rbMass;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 position;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected Vector3 positionLastUpdate;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected Quaternion rotation;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected Quaternion rotationLastUpdate;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected float deltaTimeLastUpdate;

		[Token(Token = "0x17000072")]
		public BoxerController owner
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x8FD9FC", Offset = "0x8FD9FC", VA = "0x8FD9FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D06D4", Offset = "0x6D06D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x8FDA04", Offset = "0x8FDA04", VA = "0x8FDA04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D06E4", Offset = "0x6D06E4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x8FDA0C", Offset = "0x8FDA0C", VA = "0x8FDA0C", Slot = "4")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x8FDAB8", Offset = "0x8FDAB8", VA = "0x8FDAB8", Slot = "5")]
		public virtual void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x8FDBD0", Offset = "0x8FDBD0", VA = "0x8FDBD0")]
		public void SetOwner(BoxerController newOwner)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x8FDBD8", Offset = "0x8FDBD8", VA = "0x8FDBD8", Slot = "6")]
		public virtual void ReceiveHitboxCollision(float force, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x8FDC00", Offset = "0x8FDC00", VA = "0x8FDC00", Slot = "7")]
		public virtual Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x8FDC0C", Offset = "0x8FDC0C", VA = "0x8FDC0C", Slot = "8")]
		public virtual Vector3 GetVelocity(Vector3 atPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x8FDE94", Offset = "0x8FDE94", VA = "0x8FDE94", Slot = "9")]
		public virtual float GetRigidbodyMass()
		{
			return default(float);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x8FDE9C", Offset = "0x8FDE9C", VA = "0x8FDE9C", Slot = "10")]
		public virtual bool CanTakeDamage()
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x8FDF3C", Offset = "0x8FDF3C", VA = "0x8FDF3C", Slot = "11")]
		public virtual void ClearVelocity()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x8FE030", Offset = "0x8FE030", VA = "0x8FE030", Slot = "12")]
		public virtual void UpdateVelocity()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x8FE184", Offset = "0x8FE184", VA = "0x8FE184")]
		public Hurtbox()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public abstract class IHapticsSystem
	{
		[Token(Token = "0x20000E1")]
		public enum BodyArea
		{
			[Token(Token = "0x4000857")]
			GetHitHead,
			[Token(Token = "0x4000858")]
			GetHitLeftHand,
			[Token(Token = "0x4000859")]
			GetHitLeftArm,
			[Token(Token = "0x400085A")]
			GetHitLeftShoulder,
			[Token(Token = "0x400085B")]
			GetHitRightHand,
			[Token(Token = "0x400085C")]
			GetHitRightArm,
			[Token(Token = "0x400085D")]
			GetHitRightShoulder,
			[Token(Token = "0x400085E")]
			GetHitChest,
			[Token(Token = "0x400085F")]
			GetHitStomach,
			[Token(Token = "0x4000860")]
			PunchLeftHand,
			[Token(Token = "0x4000861")]
			PunchRightHand,
			[Token(Token = "0x4000862")]
			HitTheMat,
			[Token(Token = "0x4000863")]
			HeartBeat,
			[Token(Token = "0x4000864")]
			HeartBeatHeavy,
			[Token(Token = "0x4000865")]
			UISelectLeft,
			[Token(Token = "0x4000866")]
			UISelectRight
		}

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool loaded;

		[Token(Token = "0x600047E")]
		public abstract bool IsActive();

		[Token(Token = "0x600047F")]
		public abstract void Initialize();

		[Token(Token = "0x6000480")]
		public abstract void Unload();

		[Token(Token = "0x6000481")]
		public abstract void Rumble(float strength, BodyArea area);

		[Token(Token = "0x6000482")]
		public abstract void RumbleAtLocation(float strength, BodyArea area, float x, float y);

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x8FE25C", Offset = "0x8FE25C", VA = "0x8FE25C")]
		protected IHapticsSystem()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CE38C", Offset = "0x6CE38C")]
	public class TotfImageEffects : MonoBehaviour
	{
		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TotfImageEffects instance;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF750", Offset = "0x6CF750")]
		public float shakeLevel;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF768", Offset = "0x6CF768")]
		public float whiteFlashLevel;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF780", Offset = "0x6CF780")]
		public float redVignetteLevel;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF798", Offset = "0x6CF798")]
		public float fadeToBlackLevel;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF7B0", Offset = "0x6CF7B0")]
		public float doubleVisionLevel;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF7C8", Offset = "0x6CF7C8")]
		public float desaturationLevel;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF7E0", Offset = "0x6CF7E0")]
		public float vignetteLevel;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF7F8", Offset = "0x6CF7F8")]
		public float blurLevel;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6CF810", Offset = "0x6CF810")]
		public float blinkLevel;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1372EBC", Offset = "0x1372EBC", VA = "0x1372EBC")]
		public static void SetBrightness(float val)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1372EC0", Offset = "0x1372EC0", VA = "0x1372EC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1372F8C", Offset = "0x1372F8C", VA = "0x1372F8C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1372FE4", Offset = "0x1372FE4", VA = "0x1372FE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1373098", Offset = "0x1373098", VA = "0x1373098")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1373144", Offset = "0x1373144", VA = "0x1373144")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x13731B8", Offset = "0x13731B8", VA = "0x13731B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1373208", Offset = "0x1373208", VA = "0x1373208")]
		public TotfImageEffects()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class LightClusterAudienceGroup : AudienceGroup
	{
		[Token(Token = "0x400051F")]
		private const float patchRadius = 4f;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int audienceCountX;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int audienceCountZ;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float colliderHalfSizeX;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float colliderHalfSizeZ;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float audienceSizeX;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float audienceSizeZ;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int patchHalfSizeX;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int patchHalfSizeZ;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Matrix4x4[] matrices;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Matrix4x4[,] audienceMatrices;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[,] audiencePositions;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float[,] lightIntensity;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int[,] audienceInstanceIDs;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector4[] propsPositionArray;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int activeCount;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int[] activeCol;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int[] activeRow;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] activeSpotlightPosition;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] activeSpotlightDirection;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private BufferArgs[] args;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ComputeBuffer propsPositions;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int matrixCount;

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x8FE264", Offset = "0x8FE264", VA = "0x8FE264", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x8FE2B8", Offset = "0x8FE2B8", VA = "0x8FE2B8", Slot = "5")]
		public override void Initialize(AudienceGenerator generator)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x8FEE44", Offset = "0x8FEE44", VA = "0x8FEE44")]
		private void Update()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x8FEE4C", Offset = "0x8FEE4C", VA = "0x8FEE4C")]
		protected void LateUpdate()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x8FF538", Offset = "0x8FF538", VA = "0x8FF538", Slot = "7")]
		public override void Draw(Camera camera, Vector3 forward)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x8FF770", Offset = "0x8FF770", VA = "0x8FF770")]
		public void RegisterLightHit(Vector3 worldPoint, Vector3 position, Vector3 direction)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x8FF99C", Offset = "0x8FF99C", VA = "0x8FF99C")]
		public LightClusterAudienceGroup()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class MainMenuManager : ChildMenuManager
	{
		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF828", Offset = "0x6CF828")]
		private HomeMenuManager <homeManager>k__BackingField;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject settingsButton;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform setHeightButton;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exitButtonTime;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI requiredAreaText;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI availableAreaText;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI turnDirectionText;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI massMultiplierText;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI hookMultiplierText;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI jabMultiplierText;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI upperMultiplierText;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI automaticMassAdjustmentText;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI controllerPositionText;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public ProgressRadialBehaviour exitProgressBar;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject multiplierResetButton;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject bhapticsButton;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool exitButtonDown;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool exitButtonHeldDown;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float exitButtonTimer;

		[Token(Token = "0x17000073")]
		public HomeMenuManager homeManager
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x8FF9C0", Offset = "0x8FF9C0", VA = "0x8FF9C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D06F4", Offset = "0x6D06F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x8FF9C8", Offset = "0x8FF9C8", VA = "0x8FF9C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0704", Offset = "0x6D0704")]
			set
			{
			}
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x8FF9D0", Offset = "0x8FF9D0", VA = "0x8FF9D0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x8FFA60", Offset = "0x8FFA60", VA = "0x8FFA60", Slot = "4")]
		public override void OpenMenu()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x8FFAF0", Offset = "0x8FFAF0", VA = "0x8FFAF0")]
		public void LoadBhapticsMenu()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x8FFBF0", Offset = "0x8FFBF0", VA = "0x8FFBF0")]
		public void LoadFightMenu()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x8FFCF0", Offset = "0x8FFCF0", VA = "0x8FFCF0")]
		public void LoadExtraBattleMenu()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x8FFDF0", Offset = "0x8FFDF0", VA = "0x8FFDF0")]
		public void InitializeHeavyBag()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x8FFF08", Offset = "0x8FFF08", VA = "0x8FFF08")]
		public void InitializeSpeedBag()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x900024", Offset = "0x900024", VA = "0x900024")]
		public void InitializeBoxingDummy()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x900140", Offset = "0x900140", VA = "0x900140")]
		public void InitializeFocusBall()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x900258", Offset = "0x900258", VA = "0x900258")]
		public void LoadSettings()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x900358", Offset = "0x900358", VA = "0x900358")]
		public void LoadHeightCalibration()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x900450", Offset = "0x900450", VA = "0x900450")]
		public void ExitGame()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x90058C", Offset = "0x90058C", VA = "0x90058C")]
		public void ExitGameUp()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x900594", Offset = "0x900594", VA = "0x900594")]
		public void ResetMultipliersButton()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x90098C", Offset = "0x90098C", VA = "0x90098C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x900784", Offset = "0x900784", VA = "0x900784")]
		private void LoadMultiplierValuesForConfig()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x8FD400", Offset = "0x8FD400", VA = "0x8FD400")]
		public void UpdateStats()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x900B2C", Offset = "0x900B2C", VA = "0x900B2C")]
		public MainMenuManager()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class MenuManager : MonoBehaviour
	{
		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE4EC", Offset = "0x6CE4EC")]
		private sealed class <FadeMenuIn>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CanvasGroup menu;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000718")]
				[Address(RVA = "0x9011BC", Offset = "0x9011BC", VA = "0x9011BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600071A")]
				[Address(RVA = "0x901224", Offset = "0x901224", VA = "0x901224", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x90100C", Offset = "0x90100C", VA = "0x90100C")]
			[DebuggerHidden]
			public <FadeMenuIn>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x9010BC", Offset = "0x9010BC", VA = "0x9010BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x9010C0", Offset = "0x9010C0", VA = "0x9010C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x9011C4", Offset = "0x9011C4", VA = "0x9011C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE4FC", Offset = "0x6CE4FC")]
		private sealed class <FadeMenuOut>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CanvasGroup menu;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600071E")]
				[Address(RVA = "0x901344", Offset = "0x901344", VA = "0x901344", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000720")]
				[Address(RVA = "0x9013AC", Offset = "0x9013AC", VA = "0x9013AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x901038", Offset = "0x901038", VA = "0x901038")]
			[DebuggerHidden]
			public <FadeMenuOut>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x90122C", Offset = "0x90122C", VA = "0x90122C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x901230", Offset = "0x901230", VA = "0x901230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x90134C", Offset = "0x90134C", VA = "0x90134C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float transitionTime;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static MenuManager instance;

		[Token(Token = "0x17000074")]
		public static PlayerUISelector lastHand
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x900B3C", Offset = "0x900B3C", VA = "0x900B3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x900BA4", Offset = "0x900BA4", VA = "0x900BA4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x8F38C4", Offset = "0x8F38C4", VA = "0x8F38C4")]
		public static void ButtonPressFeedback(bool deactivatePointer = true)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x900C0C", Offset = "0x900C0C", VA = "0x900C0C")]
		public static void PlayUISound()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x900D8C", Offset = "0x900D8C", VA = "0x900D8C")]
		public void LoadMenu(GameObject menuToLoad, [Optional] GameObject menuToUnload)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x900F2C", Offset = "0x900F2C", VA = "0x900F2C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0714", Offset = "0x6D0714")]
		private IEnumerator FadeMenuIn(CanvasGroup menu)
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x900F9C", Offset = "0x900F9C", VA = "0x900F9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D0778", Offset = "0x6D0778")]
		private IEnumerator FadeMenuOut(CanvasGroup menu)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x8FD9F0", Offset = "0x8FD9F0", VA = "0x8FD9F0")]
		public MenuManager()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class MonitorUIController : MonoBehaviour
	{
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x9013B4", Offset = "0x9013B4", VA = "0x9013B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x901430", Offset = "0x901430", VA = "0x901430")]
		public MonitorUIController()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class OpponentInfoUI : MonoBehaviour
	{
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x901438", Offset = "0x901438", VA = "0x901438")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x90143C", Offset = "0x90143C", VA = "0x90143C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x901440", Offset = "0x901440", VA = "0x901440")]
		public OpponentInfoUI()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class ParticleManager : MonoBehaviour
	{
		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ParticleManager instance;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject sweatPrefab;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleSystem> pooledSweatObjects;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int pooledSweatAmount;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject bloodPrefab;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<ParticleSystem> pooledBloodObjects;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int pooledBloodAmount;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject dustPrefab;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<ParticleSystem> pooledDustObjects;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int pooledDustAmount;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int allowDustEffect;

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x901448", Offset = "0x901448", VA = "0x901448")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x901564", Offset = "0x901564", VA = "0x901564")]
		public static void PlaySweatAtPoint(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x9018D0", Offset = "0x9018D0", VA = "0x9018D0")]
		public static void PlayBloodAtPoint(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x8F7440", Offset = "0x8F7440", VA = "0x8F7440")]
		public static void PlayDustAtPoint(Vector3 position, Quaternion rotation, float intensity, Transform parent, float damage = -1f)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x902220", Offset = "0x902220", VA = "0x902220")]
		public static void SetDustEffect(int value)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x901670", Offset = "0x901670", VA = "0x901670")]
		public void GOPlaySweatAtPoint(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x9019DC", Offset = "0x9019DC", VA = "0x9019DC")]
		public void GOPlayBloodAtPoint(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x901C3C", Offset = "0x901C3C", VA = "0x901C3C")]
		public void GOPlayDustAtPoint(Vector3 position, Quaternion rotation, float intensity, Transform parent, float damage = -1f)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x9022C8", Offset = "0x9022C8", VA = "0x9022C8")]
		public ParticleManager()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class PlatformSwitcher : MonoBehaviour
	{
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject steamObject;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject oculusObject;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x9022D8", Offset = "0x9022D8", VA = "0x9022D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x9022DC", Offset = "0x9022DC", VA = "0x9022DC")]
		public PlatformSwitcher()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class PlayAreaController : MonoBehaviour
	{
		[Token(Token = "0x20000E4")]
		public delegate void PlayAreaUpdateEvent();

		[Token(Token = "0x20000E5")]
		private struct UshortPosition
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ushort x;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public ushort y;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public ushort z;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public ushort w;
		}

		[Token(Token = "0x20000E6")]
		public enum PlayAreaEdge
		{
			[Token(Token = "0x4000872")]
			Center,
			[Token(Token = "0x4000873")]
			Left,
			[Token(Token = "0x4000874")]
			Right,
			[Token(Token = "0x4000875")]
			Front,
			[Token(Token = "0x4000876")]
			Back
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CE50C", Offset = "0x6CE50C")]
		private sealed class <UpdateBounds>d__90 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlayAreaController <>4__this;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000728")]
				[Address(RVA = "0x9051FC", Offset = "0x9051FC", VA = "0x9051FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072A")]
				[Address(RVA = "0x905264", Offset = "0x905264", VA = "0x905264", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x904698", Offset = "0x904698", VA = "0x904698")]
			[DebuggerHidden]
			public <UpdateBounds>d__90(int <>1__state)
			{
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x90510C", Offset = "0x90510C", VA = "0x90510C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x905110", Offset = "0x905110", VA = "0x905110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x905204", Offset = "0x905204", VA = "0x905204", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PlayAreaUpdateEvent OnPlayAreaUpdate;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material material;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float borderThickness;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float targetHeight;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool playAreaTurned;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform playerParent;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool loadedHeightRatio;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float heightRatio;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float playAreaScale;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float maxHeightRatio;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float minHeightRatio;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool overridePlayArea;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float overrideWidth;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float overrideDepth;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static PlayAreaController instance;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF838", Offset = "0x6CF838")]
		private float <FixedSafeDepth>k__BackingField;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF848", Offset = "0x6CF848")]
		private float <FixedSafeWidth>k__BackingField;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF858", Offset = "0x6CF858")]
		private float <TrueDepth>k__BackingField;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF868", Offset = "0x6CF868")]
		private float <TrueWidth>k__BackingField;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF878", Offset = "0x6CF878")]
		private float <SafeDepth>k__BackingField;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF888", Offset = "0x6CF888")]
		private float <SafeWidth>k__BackingField;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform headCamera;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float maxSafeZone;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float minSafeZone;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public PlayerController player;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool movePlayer;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private PlayAreaEdge targetEdgeX;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PlayAreaEdge targetEdgeY;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 targetFacing;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool gotSize;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool allowRecenterPress;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float recenterTimer;

		[Token(Token = "0x4000579")]
		private const float recenterTime = 1f;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float minComfortableDepth;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static float minComfortableWidth;

		[Token(Token = "0x17000075")]
		public static float depth
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x8F7944", Offset = "0x8F7944", VA = "0x8F7944")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000076")]
		public static float width
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x8F7A14", Offset = "0x8F7A14", VA = "0x8F7A14")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000077")]
		public static float scale
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x9022E4", Offset = "0x9022E4", VA = "0x9022E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000078")]
		public float FixedSafeDepth
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x9023B8", Offset = "0x9023B8", VA = "0x9023B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D07DC", Offset = "0x6D07DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x9023C0", Offset = "0x9023C0", VA = "0x9023C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D07EC", Offset = "0x6D07EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public float FixedSafeWidth
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x9023C8", Offset = "0x9023C8", VA = "0x9023C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D07FC", Offset = "0x6D07FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x9023D0", Offset = "0x9023D0", VA = "0x9023D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D080C", Offset = "0x6D080C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public float TrueDepth
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x9023D8", Offset = "0x9023D8", VA = "0x9023D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D081C", Offset = "0x6D081C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x9023E0", Offset = "0x9023E0", VA = "0x9023E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D082C", Offset = "0x6D082C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public float TrueWidth
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x9023E8", Offset = "0x9023E8", VA = "0x9023E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D083C", Offset = "0x6D083C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x9023F0", Offset = "0x9023F0", VA = "0x9023F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D084C", Offset = "0x6D084C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public float SafeDepth
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x9023F8", Offset = "0x9023F8", VA = "0x9023F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D085C", Offset = "0x6D085C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x902400", Offset = "0x902400", VA = "0x902400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D086C", Offset = "0x6D086C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public float SafeWidth
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x902408", Offset = "0x902408", VA = "0x902408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D087C", Offset = "0x6D087C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x902410", Offset = "0x902410", VA = "0x902410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D088C", Offset = "0x6D088C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public static bool Initialized
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x902418", Offset = "0x902418", VA = "0x902418")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		public bool GotSize
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x9024F8", Offset = "0x9024F8", VA = "0x9024F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x902500", Offset = "0x902500", VA = "0x902500")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x90256C", Offset = "0x90256C", VA = "0x90256C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x902BD0", Offset = "0x902BD0", VA = "0x902BD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x902DA0", Offset = "0x902DA0", VA = "0x902DA0")]
		public void HandleRecenterRequest()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x903038", Offset = "0x903038", VA = "0x903038")]
		public void HandleResizeRequest()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x9028F4", Offset = "0x9028F4", VA = "0x9028F4")]
		public void CalculateRotation()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x902A74", Offset = "0x902A74", VA = "0x902A74")]
		public void CalculateSize()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x903484", Offset = "0x903484", VA = "0x903484")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x9039A8", Offset = "0x9039A8", VA = "0x9039A8")]
		public void ManuallyCheckForRecenter()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x90303C", Offset = "0x90303C", VA = "0x90303C")]
		private void SetSpaceRotation(int newRotation)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x903A54", Offset = "0x903A54", VA = "0x903A54")]
		private void RescalePlayer()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x903ABC", Offset = "0x903ABC", VA = "0x903ABC")]
		public static void SetPlayerScaleWithCurrentHeight()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x903B60", Offset = "0x903B60", VA = "0x903B60")]
		private void SetPlayerScale(float newHeightRatio)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x9027E4", Offset = "0x9027E4", VA = "0x9027E4")]
		private float GetHeightRatio()
		{
			return default(float);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x902878", Offset = "0x902878", VA = "0x902878")]
		private void CalculateScale()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x903C00", Offset = "0x903C00", VA = "0x903C00")]
		public static void SendPlayerToPosition(Vector3 position, PlayAreaEdge edgeY = PlayAreaEdge.Center, PlayAreaEdge edgeX = PlayAreaEdge.Center)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x8F7800", Offset = "0x8F7800", VA = "0x8F7800")]
		public static void SendPlayerToPosition(Vector3 position, Vector3 facing, PlayAreaEdge edgeY = PlayAreaEdge.Center, PlayAreaEdge edgeX = PlayAreaEdge.Center)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x903D58", Offset = "0x903D58", VA = "0x903D58")]
		public void SendPlayerToPositionInstance(Vector3 position, Vector3 facing, PlayAreaEdge edgeY = PlayAreaEdge.Center, PlayAreaEdge edgeX = PlayAreaEdge.Center)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x9034C0", Offset = "0x9034C0", VA = "0x9034C0")]
		private void SendPlayerToPositionNow()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x903DF4", Offset = "0x903DF4", VA = "0x903DF4")]
		public static Vector3 GetEdgePosition(PlayAreaEdge edgeY = PlayAreaEdge.Center, PlayAreaEdge edgeX = PlayAreaEdge.Center, float extraDistanceY = 0f, float extraDistanceX = 0f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x903EFC", Offset = "0x903EFC", VA = "0x903EFC")]
		public Vector3 GetEdgePositionInstance(PlayAreaEdge edgeY = PlayAreaEdge.Center, PlayAreaEdge edgeX = PlayAreaEdge.Center, float extraDistanceY = 0f, float extraDistanceX = 0f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x904230", Offset = "0x904230", VA = "0x904230")]
		public static Vector3 GetPosition(PlayAreaEdge edgeY = PlayAreaEdge.Center, PlayAreaEdge edgeX = PlayAreaEdge.Center)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x904320", Offset = "0x904320", VA = "0x904320")]
		public Vector3 GetPositionInstance(PlayAreaEdge edgeY = PlayAreaEdge.Center, PlayAreaEdge edgeX = PlayAreaEdge.Center)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x904628", Offset = "0x904628", VA = "0x904628")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6D089C", Offset = "0x6D089C")]
		private IEnumerator UpdateBounds()
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x903104", Offset = "0x903104", VA = "0x903104")]
		public void SetPlayAreaSize(Vector3 playAreaSize, Vector3 centerOffset)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x9046C4", Offset = "0x9046C4", VA = "0x9046C4")]
		private void BuildMesh(float width, float depth)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x8F7718", Offset = "0x8F7718", VA = "0x8F7718")]
		public static bool IsCenterMode()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x90507C", Offset = "0x90507C", VA = "0x90507C")]
		public PlayAreaController()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class PlaySpaceRotator : MonoBehaviour
	{
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x9052A4", Offset = "0x9052A4", VA = "0x9052A4")]
		public PlaySpaceRotator()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class PlayerBlockbox : Blockbox
	{
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x9052B4", Offset = "0x9052B4", VA = "0x9052B4")]
		public PlayerBlockbox()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class PlayerController : BoxerController, IFixedUpdateable
	{
		[Token(Token = "0x20000E8")]
		public enum DriftProtectionMode
		{
			[Token(Token = "0x400087B")]
			Off,
			[Token(Token = "0x400087C")]
			SimulateWrappedWrist,
			[Token(Token = "0x400087D")]
			On
		}

		[Token(Token = "0x400057C")]
		private const float defaultCalibrationLevel = 1500f;

		[Token(Token = "0x400057D")]
		private const int punchesNeededToResetForceCeiling = 10;

		[Token(Token = "0x400057E")]
		private const int punchesNeededToIncreaseMultiplier = 5;

		[Token(Token = "0x400057F")]
		public const float maxVelocityForCalibration = 10f;

		[Token(Token = "0x4000580")]
		public const float maxHookVelocityForCalibration = 14f;

		[Token(Token = "0x4000581")]
		public const float maxJabVelocityForCalibration = 11f;

		[Token(Token = "0x4000582")]
		public const float maxUpperVelocityForCalibration = 10f;

		[Token(Token = "0x4000583")]
		private const float minVelocityForCalibration = 3f;

		[Token(Token = "0x4000584")]
		private const float maxAutomaticMultiplier = 2.4f;

		[Token(Token = "0x4000585")]
		private const float minAutomaticMultiplier = 1f;

		[Token(Token = "0x4000586")]
		private const float forearmLength = 0.28f;

		[Token(Token = "0x4000587")]
		private const float upperArmLength = 0.28f;

		[Token(Token = "0x4000588")]
		private const float maxShoulderHeight = 0.1f;

		[Token(Token = "0x4000589")]
		private const float smallGloveScale = 1f;

		[Token(Token = "0x400058A")]
		private const float mediumGloveScale = 1.1f;

		[Token(Token = "0x400058B")]
		private const float largeGloveScale = 1.2f;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PlayerController instance;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public GameObject exitMenu;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioClip[] headHitSounds;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioClip[] gruntSounds;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioClip[] knockdownSounds;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioClip[] uiSounds;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF898", Offset = "0x6CF898")]
		private bool <automaticallyCalibratePunchForce>k__BackingField;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private float maximumRecordedForceForCalibration;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float maximumRecordedTemporaryForce;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float calibrationForce;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float temporaryCalibrationForce;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int calibrationPunchCount;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int temporaryPunchCount;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int punchCountThisRound;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float maximumRecordedHookForceForCalibration;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float maximumRecordedJabForceForCalibration;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float maximumRecordedUpperForceForCalibration;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float maximumRecordedTemporaryHookForce;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private float maximumRecordedTemporaryJabForce;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private float maximumRecordedTemporaryUpperForce;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float calibrationHookForce;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float calibrationJabForce;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private float calibrationUpperForce;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private float temporaryCalibrationHookForce;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float temporaryCalibrationJabForce;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float temporaryCalibrationUpperForce;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private int calibrationHookCount;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private int calibrationJabCount;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int calibrationUpperCount;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private int temporaryHookCount;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private int temporaryJabCount;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private int temporaryUpperCount;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private int hookCountThisRound;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int jabCountThisRound;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private int upperCountThisRound;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private bool falling;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private float hitTheMatTimer;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF8A8", Offset = "0x6CF8A8")]
		private float <effectiveMassModifier>k__BackingField;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF8B8", Offset = "0x6CF8B8")]
		private float <effectiveHookMassModifier>k__BackingField;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF8C8", Offset = "0x6CF8C8")]
		private float <effectiveJabMassModifier>k__BackingField;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF8D8", Offset = "0x6CF8D8")]
		private float <effectiveUpperMassModifier>k__BackingField;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF8E8", Offset = "0x6CF8E8")]
		private bool <centerMode>k__BackingField;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF8F8", Offset = "0x6CF8F8")]
		private bool <openLeftFront>k__BackingField;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF908", Offset = "0x6CF908")]
		private bool <openRightFront>k__BackingField;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF918", Offset = "0x6CF918")]
		private bool <openLeftSide>k__BackingField;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF928", Offset = "0x6CF928")]
		private bool <openRightSide>k__BackingField;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF938", Offset = "0x6CF938")]
		private bool <openLeftBottom>k__BackingField;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF948", Offset = "0x6CF948")]
		private bool <openRightBottom>k__BackingField;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF958", Offset = "0x6CF958")]
		private bool <openLeftBody>k__BackingField;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF968", Offset = "0x6CF968")]
		private bool <openRightBody>k__BackingField;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF978", Offset = "0x6CF978")]
		private int <blockJawLeftCount>k__BackingField;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF988", Offset = "0x6CF988")]
		private int <blockJawRightCount>k__BackingField;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF998", Offset = "0x6CF998")]
		private int <blockTempleLeftCount>k__BackingField;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9A8", Offset = "0x6CF9A8")]
		private int <blockTempleRightCount>k__BackingField;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9B8", Offset = "0x6CF9B8")]
		private int <blockJawBottomCount>k__BackingField;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9C8", Offset = "0x6CF9C8")]
		private int <blockJawFrontCount>k__BackingField;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9D8", Offset = "0x6CF9D8")]
		private int <blockFaceFrontCount>k__BackingField;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9E8", Offset = "0x6CF9E8")]
		private int <blockHeadLeftCount>k__BackingField;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CF9F8", Offset = "0x6CF9F8")]
		private int <blockHeadRightCount>k__BackingField;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA08", Offset = "0x6CFA08")]
		private int <blockFrontCount>k__BackingField;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA18", Offset = "0x6CFA18")]
		private int <blockSideCount>k__BackingField;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public MeshRenderer shortsModel;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public MeshRenderer headgearModel;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public PlayerHandTracker LeftHandTarget;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public PlayerHandTracker RightHandTarget;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public Transform forearmLeft;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public Transform forearmRight;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public Transform upperArmLeft;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public Transform upperArmLeftTarget;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public Transform upperArmRight;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		public Transform upperArmRightTarget;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public CapsuleCollider upperArmLeftCollider;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public CapsuleCollider upperArmRightCollider;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public Transform LeftHandIKTarget;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public Transform RightHandIKTarget;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public GameObject LeftHandGloveModel;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public GameObject RightHandGloveModel;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public Transform leftHandScaler;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public Transform leftHandColliderScaler;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public Transform rightHandScaler;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public Transform rightHandColliderScaler;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA28", Offset = "0x6CFA28")]
		private BoxerIK <ik>k__BackingField;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public PlayerHead headHitbox;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public Transform headTarget;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public CameraController cameraEffects;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private bool doDizzyHaptics;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
		private float dizzyHapticsTimer;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA38", Offset = "0x6CFA38")]
		private PlayerFist <leftFist>k__BackingField;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA48", Offset = "0x6CFA48")]
		private PlayerFist <rightFist>k__BackingField;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private AudioSource hitAudioSource;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private AudioSource gruntAudioSource;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private float blinkDelayTimer;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float blinkTime;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x304")]
		private bool blinkActivated;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x305")]
		private bool blinking;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA58", Offset = "0x6CFA58")]
		private float <gloveScale>k__BackingField;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private PlayerCorner playerCornerObject;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private float dizzyEffectMax;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
		private float dizzyEffectsLevel;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA68", Offset = "0x6CFA68")]
		private float <dizzyEffectsTarget>k__BackingField;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA78", Offset = "0x6CFA78")]
		private DriftProtectionMode <driftProtection>k__BackingField;

		[Token(Token = "0x17000080")]
		public bool automaticallyCalibratePunchForce
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x9052BC", Offset = "0x9052BC", VA = "0x9052BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0900", Offset = "0x6D0900")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x9052C4", Offset = "0x9052C4", VA = "0x9052C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0910", Offset = "0x6D0910")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public float effectiveMassModifier
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x9052D0", Offset = "0x9052D0", VA = "0x9052D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0920", Offset = "0x6D0920")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x9052D8", Offset = "0x9052D8", VA = "0x9052D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0930", Offset = "0x6D0930")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public float effectiveHookMassModifier
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x9052E0", Offset = "0x9052E0", VA = "0x9052E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0940", Offset = "0x6D0940")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x9052E8", Offset = "0x9052E8", VA = "0x9052E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0950", Offset = "0x6D0950")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public float effectiveJabMassModifier
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x9052F0", Offset = "0x9052F0", VA = "0x9052F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0960", Offset = "0x6D0960")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x9052F8", Offset = "0x9052F8", VA = "0x9052F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0970", Offset = "0x6D0970")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public float effectiveUpperMassModifier
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x905300", Offset = "0x905300", VA = "0x905300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0980", Offset = "0x6D0980")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x905308", Offset = "0x905308", VA = "0x905308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0990", Offset = "0x6D0990")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool centerMode
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x905310", Offset = "0x905310", VA = "0x905310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D09A0", Offset = "0x6D09A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x905318", Offset = "0x905318", VA = "0x905318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D09B0", Offset = "0x6D09B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool openLeftFront
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x905324", Offset = "0x905324", VA = "0x905324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D09C0", Offset = "0x6D09C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x90532C", Offset = "0x90532C", VA = "0x90532C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D09D0", Offset = "0x6D09D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public bool openRightFront
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x905338", Offset = "0x905338", VA = "0x905338")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D09E0", Offset = "0x6D09E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x905340", Offset = "0x905340", VA = "0x905340")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D09F0", Offset = "0x6D09F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public bool openLeftSide
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x90534C", Offset = "0x90534C", VA = "0x90534C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A00", Offset = "0x6D0A00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x905354", Offset = "0x905354", VA = "0x905354")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A10", Offset = "0x6D0A10")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public bool openRightSide
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x905360", Offset = "0x905360", VA = "0x905360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A20", Offset = "0x6D0A20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x905368", Offset = "0x905368", VA = "0x905368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A30", Offset = "0x6D0A30")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public bool openLeftBottom
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x905374", Offset = "0x905374", VA = "0x905374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A40", Offset = "0x6D0A40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x90537C", Offset = "0x90537C", VA = "0x90537C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A50", Offset = "0x6D0A50")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public bool openRightBottom
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x905388", Offset = "0x905388", VA = "0x905388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A60", Offset = "0x6D0A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x905390", Offset = "0x905390", VA = "0x905390")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A70", Offset = "0x6D0A70")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public bool openLeftBody
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x90539C", Offset = "0x90539C", VA = "0x90539C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A80", Offset = "0x6D0A80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x9053A4", Offset = "0x9053A4", VA = "0x9053A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0A90", Offset = "0x6D0A90")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool openRightBody
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x9053B0", Offset = "0x9053B0", VA = "0x9053B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0AA0", Offset = "0x6D0AA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x9053B8", Offset = "0x9053B8", VA = "0x9053B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0AB0", Offset = "0x6D0AB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public int blockJawLeftCount
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x9053C4", Offset = "0x9053C4", VA = "0x9053C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0AC0", Offset = "0x6D0AC0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x9053CC", Offset = "0x9053CC", VA = "0x9053CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0AD0", Offset = "0x6D0AD0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public int blockJawRightCount
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x9053D4", Offset = "0x9053D4", VA = "0x9053D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0AE0", Offset = "0x6D0AE0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x9053DC", Offset = "0x9053DC", VA = "0x9053DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0AF0", Offset = "0x6D0AF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public int blockTempleLeftCount
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x9053E4", Offset = "0x9053E4", VA = "0x9053E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B00", Offset = "0x6D0B00")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x9053EC", Offset = "0x9053EC", VA = "0x9053EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B10", Offset = "0x6D0B10")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public int blockTempleRightCount
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x9053F4", Offset = "0x9053F4", VA = "0x9053F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B20", Offset = "0x6D0B20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x9053FC", Offset = "0x9053FC", VA = "0x9053FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B30", Offset = "0x6D0B30")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public int blockJawBottomCount
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x905404", Offset = "0x905404", VA = "0x905404")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B40", Offset = "0x6D0B40")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x90540C", Offset = "0x90540C", VA = "0x90540C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B50", Offset = "0x6D0B50")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public int blockJawFrontCount
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x905414", Offset = "0x905414", VA = "0x905414")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B60", Offset = "0x6D0B60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x90541C", Offset = "0x90541C", VA = "0x90541C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B70", Offset = "0x6D0B70")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public int blockFaceFrontCount
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x905424", Offset = "0x905424", VA = "0x905424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B80", Offset = "0x6D0B80")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x90542C", Offset = "0x90542C", VA = "0x90542C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B90", Offset = "0x6D0B90")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public int blockHeadLeftCount
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x905434", Offset = "0x905434", VA = "0x905434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0BA0", Offset = "0x6D0BA0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x90543C", Offset = "0x90543C", VA = "0x90543C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0BB0", Offset = "0x6D0BB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public int blockHeadRightCount
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x905444", Offset = "0x905444", VA = "0x905444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0BC0", Offset = "0x6D0BC0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x90544C", Offset = "0x90544C", VA = "0x90544C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0BD0", Offset = "0x6D0BD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public int blockFrontCount
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x905454", Offset = "0x905454", VA = "0x905454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0BE0", Offset = "0x6D0BE0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x90545C", Offset = "0x90545C", VA = "0x90545C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0BF0", Offset = "0x6D0BF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public int blockSideCount
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x905464", Offset = "0x905464", VA = "0x905464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C00", Offset = "0x6D0C00")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x90546C", Offset = "0x90546C", VA = "0x90546C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C10", Offset = "0x6D0C10")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public BoxerIK ik
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x905474", Offset = "0x905474", VA = "0x905474")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C20", Offset = "0x6D0C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x90547C", Offset = "0x90547C", VA = "0x90547C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C30", Offset = "0x6D0C30")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public CameraController hmd
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x905484", Offset = "0x905484", VA = "0x905484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public PlayerFist leftFist
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x90548C", Offset = "0x90548C", VA = "0x90548C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C40", Offset = "0x6D0C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x905494", Offset = "0x905494", VA = "0x905494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C50", Offset = "0x6D0C50")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public PlayerFist rightFist
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x90549C", Offset = "0x90549C", VA = "0x90549C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C60", Offset = "0x6D0C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x9054A4", Offset = "0x9054A4", VA = "0x9054A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C70", Offset = "0x6D0C70")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public float gloveScale
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x9054AC", Offset = "0x9054AC", VA = "0x9054AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C80", Offset = "0x6D0C80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x9054B4", Offset = "0x9054B4", VA = "0x9054B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C90", Offset = "0x6D0C90")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		private PlayerCorner playerCorner
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x9054BC", Offset = "0x9054BC", VA = "0x9054BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public float dizzyEffectsTarget
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x905548", Offset = "0x905548", VA = "0x905548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CA0", Offset = "0x6D0CA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x905550", Offset = "0x905550", VA = "0x905550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CB0", Offset = "0x6D0CB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public DriftProtectionMode driftProtection
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x905558", Offset = "0x905558", VA = "0x905558")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CC0", Offset = "0x6D0CC0")]
			get
			{
				return default(DriftProtectionMode);
			}
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x905560", Offset = "0x905560", VA = "0x905560")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CD0", Offset = "0x6D0CD0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x905568", Offset = "0x905568", VA = "0x905568")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x9056B0", Offset = "0x9056B0", VA = "0x9056B0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x9057F8", Offset = "0x9057F8", VA = "0x9057F8", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x905EA0", Offset = "0x905EA0", VA = "0x905EA0", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x905F98", Offset = "0x905F98", VA = "0x905F98")]
		public void ShowRenderers()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x905FDC", Offset = "0x905FDC", VA = "0x905FDC")]
		public void HideRenderers()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x8F9588", Offset = "0x8F9588", VA = "0x8F9588")]
		public void ShowControllerOutlines(bool updatePref = false)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x8F9644", Offset = "0x8F9644", VA = "0x8F9644")]
		public void HideControllerOutlines(bool updatePref = false)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x906020", Offset = "0x906020", VA = "0x906020")]
		public void SetDriftProtection(int value)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x906028", Offset = "0x906028", VA = "0x906028")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x905AC4", Offset = "0x905AC4", VA = "0x905AC4")]
		private void LoadForceMultiplier()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x900720", Offset = "0x900720", VA = "0x900720")]
		public void ResetMultipliers()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x906090", Offset = "0x906090", VA = "0x906090")]
		private void SetForceMultiplierByForce(float force, bool updatePlayerPref = false)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x90618C", Offset = "0x90618C", VA = "0x90618C")]
		private void SetHookForceMultiplierByForce(float force, bool updatePlayerPref = false)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x906288", Offset = "0x906288", VA = "0x906288")]
		private void SetJabForceMultiplierByForce(float force, bool updatePlayerPref = false)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x906384", Offset = "0x906384", VA = "0x906384")]
		private void SetUpperForceMultiplierByForce(float force, bool updatePlayerPref = false)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x906480", Offset = "0x906480", VA = "0x906480")]
		public void SetForceMultiplierByValue(float value, bool updatePlayerPref = false)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x90657C", Offset = "0x90657C", VA = "0x90657C")]
		public void SetHookForceMultiplierByValue(float value, bool updatePlayerPref = false)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x906678", Offset = "0x906678", VA = "0x906678")]
		public void SetJabForceMultiplierByValue(float value, bool updatePlayerPref = false)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x906774", Offset = "0x906774", VA = "0x906774")]
		public void SetUpperForceMultiplierByValue(float value, bool updatePlayerPref = false)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x906870", Offset = "0x906870", VA = "0x906870")]
		private void StoreCalibrationForce(float force)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x906914", Offset = "0x906914", VA = "0x906914")]
		private void StoreCalibrationHookForce(float force)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x9069B8", Offset = "0x9069B8", VA = "0x9069B8")]
		private void StoreCalibrationJabForce(float force)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x906A5C", Offset = "0x906A5C", VA = "0x906A5C")]
		private void StoreCalibrationUpperForce(float force)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x906B00", Offset = "0x906B00", VA = "0x906B00")]
		public void CheckIfForceMultiplierShouldIncrease()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x906C2C", Offset = "0x906C2C", VA = "0x906C2C", Slot = "8")]
		public override float CalculateMultiplierCorrection(Hitbox.PunchType punchType)
		{
			return default(float);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x906C80", Offset = "0x906C80", VA = "0x906C80")]
		public void ReportHurtboxHitForCalibration(Vector3 collisionPoint, Vector3 fistVelocity, float punchTypeCalibrationAdjustment, bool isArmWhip)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x906F18", Offset = "0x906F18", VA = "0x906F18")]
		public void ReportHurtboxHookHitForCalibration(Vector3 collisionPoint, Vector3 fistVelocity, float punchTypeCalibrationAdjustment, bool isArmWhip)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x9071B4", Offset = "0x9071B4", VA = "0x9071B4")]
		public void ReportHurtboxJabHitForCalibration(Vector3 collisionPoint, Vector3 fistVelocity, float punchTypeCalibrationAdjustment, bool isArmWhip)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x907450", Offset = "0x907450", VA = "0x907450")]
		public void ReportHurtboxUpperHitForCalibration(Vector3 collisionPoint, Vector3 fistVelocity, float punchTypeCalibrationAdjustment, bool isArmWhip)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x8F8B44", Offset = "0x8F8B44", VA = "0x8F8B44")]
		public void LoadHandCalibration()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x905F38", Offset = "0x905F38", VA = "0x905F38")]
		public void LoadGloveSize()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x9076EC", Offset = "0x9076EC", VA = "0x9076EC")]
		public void SetGloveScale(int size)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x90788C", Offset = "0x90788C", VA = "0x90788C", Slot = "46")]
		public void CustomFixedUpdate()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x907D4C", Offset = "0x907D4C", VA = "0x907D4C")]
		public void PostSimulation()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x907D50", Offset = "0x907D50", VA = "0x907D50", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x903D80", Offset = "0x903D80", VA = "0x903D80")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 pivot)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x908410", Offset = "0x908410", VA = "0x908410", Slot = "21")]
		public override void PrepareForEvent(float delay)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x9084A0", Offset = "0x9084A0", VA = "0x9084A0")]
		public void FadeToWhite(float intensity = 1f)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x9084BC", Offset = "0x9084BC", VA = "0x9084BC", Slot = "9")]
		public override void DirectDamageExternalResults(float damage, bool hitWeakSpot, Hurtbox.HurtboxType type, bool wasKnockedDown)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x9086E4", Offset = "0x9086E4", VA = "0x9086E4", Slot = "45")]
		public override void BlockCollisionVisualResult(float force, Blockbox blockbox, Collision collision)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x9088C4", Offset = "0x9088C4", VA = "0x9088C4", Slot = "15")]
		protected override void HurtboxCollisionVisualResult(float damage, float force, bool wasKnockedDown, Hurtbox hurtbox, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x908AE0", Offset = "0x908AE0", VA = "0x908AE0", Slot = "16")]
		protected override void HurtboxCollisionAudioResult(float damage, float force, bool wasKnockedDown, Hurtbox hurtbox, Hitbox hitbox, Collision collision, bool hitWeakSpot = false)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x908B2C", Offset = "0x908B2C", VA = "0x908B2C")]
		private void playGruntSound(float damage)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x9085AC", Offset = "0x9085AC", VA = "0x9085AC")]
		private void playHeadHitSound(float damage)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x900CE4", Offset = "0x900CE4", VA = "0x900CE4")]
		public void PlayUISound()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x908C74", Offset = "0x908C74", VA = "0x908C74", Slot = "20")]
		protected override void Knockdown(Hurtbox hurtbox, Hitbox hitbox)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x908CC8", Offset = "0x908CC8", VA = "0x908CC8")]
		private void WaitToHitTheMat()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x9083B0", Offset = "0x9083B0", VA = "0x9083B0")]
		private void HandleFalling()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x908CDC", Offset = "0x908CDC", VA = "0x908CDC")]
		private void HitTheMat()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x908380", Offset = "0x908380", VA = "0x908380")]
		public void GetUp(bool fromKO = false)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x908DC4", Offset = "0x908DC4", VA = "0x908DC4")]
		public bool CanAct()
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x908DD4", Offset = "0x908DD4", VA = "0x908DD4")]
		public void Blink()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x908DF0", Offset = "0x908DF0", VA = "0x908DF0")]
		public bool CanAttack()
		{
			return default(bool);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x908E00", Offset = "0x908E00", VA = "0x908E00")]
		public void Undizzy()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x908E08", Offset = "0x908E08", VA = "0x908E08", Slot = "22")]
		public override void PreMatchSetup()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x908E28", Offset = "0x908E28", VA = "0x908E28", Slot = "24")]
		public override void StartRound()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x908E34", Offset = "0x908E34", VA = "0x908E34", Slot = "23")]
		public override void PrepareToStartRound()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x908E54", Offset = "0x908E54", VA = "0x908E54", Slot = "25")]
		public override void StartRoundMovement()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x908E8C", Offset = "0x908E8C", VA = "0x908E8C", Slot = "26")]
		public override void EndRound()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x908E98", Offset = "0x908E98", VA = "0x908E98", Slot = "27")]
		public override void StartBreakMovement()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x908EE4", Offset = "0x908EE4", VA = "0x908EE4", Slot = "29")]
		public override void KnockedDownMovement()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x9090C0", Offset = "0x9090C0", VA = "0x9090C0", Slot = "30")]
		public override void GoToFarthestNeutralCorner()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x9090F0", Offset = "0x9090F0", VA = "0x9090F0", Slot = "31")]
		public override void GetUpMovement()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x9090F4", Offset = "0x9090F4", VA = "0x9090F4", Slot = "32")]
		public override void ResumeFighting()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x9090F8", Offset = "0x9090F8", VA = "0x9090F8", Slot = "33")]
		public override void ResumeFightingMovement()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x909118", Offset = "0x909118", VA = "0x909118", Slot = "34")]
		public override void PostMatchMovement()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x909328", Offset = "0x909328", VA = "0x909328", Slot = "35")]
		public override void ReportMatchResults(bool isAWin, bool isADraw, string opponentDefeatName, FightMenuManager.SelectedDifficulty difficulty)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x90955C", Offset = "0x90955C", VA = "0x90955C", Slot = "38")]
		public override Vector3 PredictHitZoneMovement(float afterSeconds)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x909578", Offset = "0x909578", VA = "0x909578", Slot = "11")]
		public override Transform GetPositionTransform()
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x909594", Offset = "0x909594", VA = "0x909594", Slot = "43")]
		public override float GetClosestAllowedDistance(Vector3 startPosition, Vector3 endPosition, float extraDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x903DB8", Offset = "0x903DB8", VA = "0x903DB8")]
		public void MoveFistsToTargets()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x9097C8", Offset = "0x9097C8", VA = "0x9097C8")]
		public PlayerController()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class PlayerFist : Hitbox, IFixedUpdateable
	{
		[Token(Token = "0x40005F1")]
		public const float ControllerExtendedFloorDistance = 0.3f;

		[Token(Token = "0x40005F2")]
		public const float ControllerFullExtensionFloorDistance = 0.6f;

		[Token(Token = "0x40005F3")]
		private const float smoothTime = 1f / 15f;

		[Token(Token = "0x40005F4")]
		private const float minimumPunchingSpeed = 1.5f;

		[Token(Token = "0x40005F5")]
		private const float minimumMovingSpeed = 0.2f;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA88", Offset = "0x6CFA88")]
		private Transform <handTarget>k__BackingField;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFA98", Offset = "0x6CFA98")]
		private Transform <controllerTarget>k__BackingField;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAA8", Offset = "0x6CFAA8")]
		private PlayerHandTracker <controller>k__BackingField;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform fistCenter;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform interpolator;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isFrozen;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool wasFrozen;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion frozenRotation;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ConfigurableJoint axisLockJoint;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool leftHand;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAB8", Offset = "0x6CFAB8")]
		private bool <isLeadingHand>k__BackingField;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAC8", Offset = "0x6CFAC8")]
		private bool <isPunching>k__BackingField;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAD8", Offset = "0x6CFAD8")]
		private bool <didLandHit>k__BackingField;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAE8", Offset = "0x6CFAE8")]
		private bool <handWasExtended>k__BackingField;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFAF8", Offset = "0x6CFAF8")]
		private float <punchTime>k__BackingField;

		[Token(Token = "0x4000605")]
		private const float teleportTime = 0.2f;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float teleportTimer;

		[Token(Token = "0x4000607")]
		private const float collisionCooldown = 0.075f;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float collisionCooldownCounter;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float minorCollisionCooldownCounter;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB08", Offset = "0x6CFB08")]
		private float <lastRotate>k__BackingField;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB18", Offset = "0x6CFB18")]
		private float <lastAngle>k__BackingField;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB28", Offset = "0x6CFB28")]
		private float <lastLean>k__BackingField;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB38", Offset = "0x6CFB38")]
		private float <lastSquareHit>k__BackingField;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB48", Offset = "0x6CFB48")]
		private float <lastJab>k__BackingField;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB58", Offset = "0x6CFB58")]
		private float <lastWhip>k__BackingField;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB68", Offset = "0x6CFB68")]
		private float <punchStartPalmAngle>k__BackingField;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB78", Offset = "0x6CFB78")]
		private float <punchStartForwardAngle>k__BackingField;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int pathHitsCount;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Collider[] pathHits;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Collider[] gcAvoidCollider;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Vector3 localTopDirection;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public Vector3 localForwardDirection;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Vector3 localPalmDirection;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3[] previousFixedPositions;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int currentFixedPositionIndex;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private bool isJabbing;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 latestFixedUpdatePosition;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Quaternion lastHandTargetRotation;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private bool velocityCachedThisFrame;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 cachedVelocity;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Vector3 cachedUnsmoothedVelocity;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool isGhosting;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 ghostStartPosition;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Quaternion ghostStartRotation;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float ghostTimer;

		[Token(Token = "0x4000624")]
		private const float ghostTime = 0.0625f;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB88", Offset = "0x6CFB88")]
		private PlayerController <player>k__BackingField;

		[Token(Token = "0x170000A1")]
		public Transform handTarget
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x90A080", Offset = "0x90A080", VA = "0x90A080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CE0", Offset = "0x6D0CE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x90A088", Offset = "0x90A088", VA = "0x90A088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CF0", Offset = "0x6D0CF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public Transform controllerTarget
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x90A090", Offset = "0x90A090", VA = "0x90A090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D00", Offset = "0x6D0D00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x90A098", Offset = "0x90A098", VA = "0x90A098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D10", Offset = "0x6D0D10")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public PlayerHandTracker controller
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x90A0A0", Offset = "0x90A0A0", VA = "0x90A0A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D20", Offset = "0x6D0D20")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x90A0A8", Offset = "0x90A0A8", VA = "0x90A0A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D30", Offset = "0x6D0D30")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool isLeadingHand
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x90A0B0", Offset = "0x90A0B0", VA = "0x90A0B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D40", Offset = "0x6D0D40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x90A0B8", Offset = "0x90A0B8", VA = "0x90A0B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D50", Offset = "0x6D0D50")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool isPunching
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x90A0C4", Offset = "0x90A0C4", VA = "0x90A0C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D60", Offset = "0x6D0D60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x90A0CC", Offset = "0x90A0CC", VA = "0x90A0CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D70", Offset = "0x6D0D70")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool didLandHit
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x90A0D8", Offset = "0x90A0D8", VA = "0x90A0D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D80", Offset = "0x6D0D80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x90A0E0", Offset = "0x90A0E0", VA = "0x90A0E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D90", Offset = "0x6D0D90")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool handWasExtended
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x90A0EC", Offset = "0x90A0EC", VA = "0x90A0EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DA0", Offset = "0x6D0DA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x90A0F4", Offset = "0x90A0F4", VA = "0x90A0F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DB0", Offset = "0x6D0DB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public float punchTime
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x90A100", Offset = "0x90A100", VA = "0x90A100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DC0", Offset = "0x6D0DC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x90A108", Offset = "0x90A108", VA = "0x90A108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DD0", Offset = "0x6D0DD0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public float lastRotate
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x90A110", Offset = "0x90A110", VA = "0x90A110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DE0", Offset = "0x6D0DE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x90A118", Offset = "0x90A118", VA = "0x90A118")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DF0", Offset = "0x6D0DF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public float lastAngle
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x90A120", Offset = "0x90A120", VA = "0x90A120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E00", Offset = "0x6D0E00")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x90A128", Offset = "0x90A128", VA = "0x90A128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E10", Offset = "0x6D0E10")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public float lastLean
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x90A130", Offset = "0x90A130", VA = "0x90A130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E20", Offset = "0x6D0E20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x90A138", Offset = "0x90A138", VA = "0x90A138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E30", Offset = "0x6D0E30")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public float lastSquareHit
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x90A140", Offset = "0x90A140", VA = "0x90A140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E40", Offset = "0x6D0E40")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x90A148", Offset = "0x90A148", VA = "0x90A148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E50", Offset = "0x6D0E50")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public float lastJab
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x90A150", Offset = "0x90A150", VA = "0x90A150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E60", Offset = "0x6D0E60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x90A158", Offset = "0x90A158", VA = "0x90A158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E70", Offset = "0x6D0E70")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public float lastWhip
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x90A160", Offset = "0x90A160", VA = "0x90A160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E80", Offset = "0x6D0E80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x90A168", Offset = "0x90A168", VA = "0x90A168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E90", Offset = "0x6D0E90")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public float punchStartPalmAngle
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x90A170", Offset = "0x90A170", VA = "0x90A170")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0EA0", Offset = "0x6D0EA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x90A178", Offset = "0x90A178", VA = "0x90A178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0EB0", Offset = "0x6D0EB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public float punchStartForwardAngle
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x90A180", Offset = "0x90A180", VA = "0x90A180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0EC0", Offset = "0x6D0EC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x90A188", Offset = "0x90A188", VA = "0x90A188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0ED0", Offset = "0x6D0ED0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public Vector3 topDirection
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x90A190", Offset = "0x90A190", VA = "0x90A190")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B2")]
		public Vector3 forwardDirection
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x90A278", Offset = "0x90A278", VA = "0x90A278")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B3")]
		public Vector3 palmDirection
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x90A360", Offset = "0x90A360", VA = "0x90A360")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B4")]
		public bool isActive
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x90A448", Offset = "0x90A448", VA = "0x90A448")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x90A478", Offset = "0x90A478", VA = "0x90A478")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public bool isActiveMinor
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x90A494", Offset = "0x90A494", VA = "0x90A494")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x90A4D0", Offset = "0x90A4D0", VA = "0x90A4D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public PlayerController player
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x90A4EC", Offset = "0x90A4EC", VA = "0x90A4EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0EE0", Offset = "0x6D0EE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x90A4F4", Offset = "0x90A4F4", VA = "0x90A4F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0EF0", Offset = "0x6D0EF0")]
			set
			{
			}
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x90A4FC", Offset = "0x90A4FC", VA = "0x90A4FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x90A504", Offset = "0x90A504", VA = "0x90A504")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x90A50C", Offset = "0x90A50C", VA = "0x90A50C", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x90A658", Offset = "0x90A658", VA = "0x90A658")]
		public void Start()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x90A6B8", Offset = "0x90A6B8", VA = "0x90A6B8")]
		private void CheckForImpactFreeze()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x90B05C", Offset = "0x90B05C", VA = "0x90B05C")]
		private void CalculateRigidbodyVelocities()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x90B1E0", Offset = "0x90B1E0", VA = "0x90B1E0")]
		private void UpdateControllerTarget(Vector3 newControllerTargetPosition, Quaternion newControllerTargetRotation)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x90B6C0", Offset = "0x90B6C0", VA = "0x90B6C0")]
		protected void OnCollisionStay()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x90B6D4", Offset = "0x90B6D4", VA = "0x90B6D4")]
		protected void OnCollisionExit()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x90B6E8", Offset = "0x90B6E8", VA = "0x90B6E8", Slot = "18")]
		public void CustomFixedUpdate()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x90BA6C", Offset = "0x90BA6C", VA = "0x90BA6C")]
		public void PostSimulation()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x90BA70", Offset = "0x90BA70", VA = "0x90BA70")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x90BD98", Offset = "0x90BD98", VA = "0x90BD98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x90BDA0", Offset = "0x90BDA0", VA = "0x90BDA0")]
		public void UpdateLeadingHand(bool isFarthestFromPlayer, bool handExtended, bool handFullyExtented)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x90C1C8", Offset = "0x90C1C8", VA = "0x90C1C8")]
		public void Vibrate(float intensity)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x90C190", Offset = "0x90C190", VA = "0x90C190")]
		private void StartPunching()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x90C138", Offset = "0x90C138", VA = "0x90C138")]
		private void StopPunching()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x90C318", Offset = "0x90C318", VA = "0x90C318", Slot = "5")]
		public override void LandedHit(PunchType punchType, float damage, float targetPainThreshold)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x90C3A8", Offset = "0x90C3A8", VA = "0x90C3A8", Slot = "9")]
		public override Vector3 GetVelocity(bool allowSmoothing = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x90C87C", Offset = "0x90C87C", VA = "0x90C87C", Slot = "15")]
		public override void ClearVelocity()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x90C9B4", Offset = "0x90C9B4", VA = "0x90C9B4")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x90C81C", Offset = "0x90C81C", VA = "0x90C81C")]
		private Vector3 GetPreviousFixedPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x90CA80", Offset = "0x90CA80", VA = "0x90CA80", Slot = "11")]
		public override float GetEffectiveMass(Vector3 collisionPoint, bool calibrationHit = false, bool returnUnmodifiedForce = false)
		{
			return default(float);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x90D5E0", Offset = "0x90D5E0", VA = "0x90D5E0", Slot = "8")]
		public override void ReceiveForce(float force, bool isMajorHit, Collision collision)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x90D6F4", Offset = "0x90D6F4", VA = "0x90D6F4", Slot = "13")]
		public override bool IsActive(bool majorHit)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x90D700", Offset = "0x90D700", VA = "0x90D700", Slot = "14")]
		public override void Deactivate(bool majorHit)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x90D71C", Offset = "0x90D71C", VA = "0x90D71C", Slot = "7")]
		public override bool CausedMajorCollision(Collider other)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x90D800", Offset = "0x90D800", VA = "0x90D800")]
		public PlayerFist()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class PlayerHandTracker : MonoBehaviour
	{
		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject controllerModel;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VRInputDevice device;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 currentPosition;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 previousPosition;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion currentRotation;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion previousRotation;

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x90D8EC", Offset = "0x90D8EC", VA = "0x90D8EC")]
		public void Start()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x90D944", Offset = "0x90D944", VA = "0x90D944")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x90DA20", Offset = "0x90DA20", VA = "0x90DA20")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x90DAFC", Offset = "0x90DAFC", VA = "0x90DAFC")]
		public void UpdatePosition()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x90B7D4", Offset = "0x90B7D4", VA = "0x90B7D4")]
		public Vector3 GetPhysicsPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x90B95C", Offset = "0x90B95C", VA = "0x90B95C")]
		public Quaternion GetPhysicsRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x90C26C", Offset = "0x90C26C", VA = "0x90C26C")]
		public void Vibrate(float intensity)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x90DC20", Offset = "0x90DC20", VA = "0x90DC20")]
		public void ShowModel()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x90DC40", Offset = "0x90DC40", VA = "0x90DC40")]
		public void HideModel()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x90DC60", Offset = "0x90DC60", VA = "0x90DC60")]
		public PlayerHandTracker()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class PlayerHead : Hurtbox
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PlayerController player;

		[Token(Token = "0x170000B7")]
		public float recentRotation
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x90D5B8", Offset = "0x90D5B8", VA = "0x90D5B8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x90DCE8", Offset = "0x90DCE8", VA = "0x90DCE8", Slot = "4")]
		public override void Start()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x90DD54", Offset = "0x90DD54", VA = "0x90DD54")]
		public Vector3 PredictMovement(float afterSeconds)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x90DD7C", Offset = "0x90DD7C", VA = "0x90DD7C")]
		public PlayerHead()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class PlayerBlockOpeningPositioner : MonoBehaviour
	{
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x9052AC", Offset = "0x9052AC", VA = "0x9052AC")]
		public PlayerBlockOpeningPositioner()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class PlayerCorner : MonoBehaviour
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayerController player;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool foundPlayer;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject roundMenu;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject positionMarker;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject cornerMessage;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject stool;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject breakMessage;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Text breakTitleText;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Text breakMessageText;

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x909890", Offset = "0x909890", VA = "0x909890")]
		private void Update()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x909944", Offset = "0x909944", VA = "0x909944")]
		public void HideCornerUI()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x9099B0", Offset = "0x9099B0", VA = "0x9099B0")]
		public void StartBreak()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x909A08", Offset = "0x909A08", VA = "0x909A08")]
		public void SendPlayerToFightPosition()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x909AC8", Offset = "0x909AC8", VA = "0x909AC8")]
		public void SendPlayerToCorner()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x909BD4", Offset = "0x909BD4", VA = "0x909BD4")]
		public void SendPlayerToWinPosition()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x909D8C", Offset = "0x909D8C", VA = "0x909D8C")]
		public void SendPlayerToNeutralCorner(Transform farthestNeutralCorner)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x909EB8", Offset = "0x909EB8", VA = "0x909EB8")]
		public void EndRound()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x909F24", Offset = "0x909F24", VA = "0x909F24")]
		public static PlayerCorner find()
		{
			return null;
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x90A078", Offset = "0x90A078", VA = "0x90A078")]
		public PlayerCorner()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class PlayerHurtbox : Hurtbox
	{
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IHapticsSystem.BodyArea area;

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x90DDE4", Offset = "0x90DDE4", VA = "0x90DDE4", Slot = "6")]
		public override void ReceiveHitboxCollision(float force, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x90DEC0", Offset = "0x90DEC0", VA = "0x90DEC0")]
		public PlayerHurtbox()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class PlayerUISelector : MonoBehaviour
	{
		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isLeftHand;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFB98", Offset = "0x6CFB98")]
		private bool <active>k__BackingField;

		[Token(Token = "0x170000B8")]
		public bool active
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x90DF28", Offset = "0x90DF28", VA = "0x90DF28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F00", Offset = "0x6D0F00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x90DF30", Offset = "0x90DF30", VA = "0x90DF30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F10", Offset = "0x6D0F10")]
			set
			{
			}
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x90DF3C", Offset = "0x90DF3C", VA = "0x90DF3C")]
		public void Awake()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x90DF48", Offset = "0x90DF48", VA = "0x90DF48")]
		public void Rumble(float strength)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x90DFE0", Offset = "0x90DFE0", VA = "0x90DFE0")]
		public bool IsClicking()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x90DFE8", Offset = "0x90DFE8", VA = "0x90DFE8")]
		public PlayerUISelector()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class PunchStateMachineBehavior : StateMachineBehaviour
	{
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string punchName;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool stepIn;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float startTime;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float endTime;

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x90E030", Offset = "0x90E030", VA = "0x90E030", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x90E0C8", Offset = "0x90E0C8", VA = "0x90E0C8", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x90E144", Offset = "0x90E144", VA = "0x90E144")]
		public PunchStateMachineBehavior()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class PunchStatsGenerator : MonoBehaviour
	{
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI redCornerName;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI blueCornerName;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI[] redLanded;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI[] redTotal;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI[] redHitPercent;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI[] redDamagingCount;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI[] redDamagingTotal;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI[] redDamagingPercent;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI[] blueLanded;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI[] blueTotal;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI[] blueHitPercent;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI[] blueDamagingCount;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI[] blueDamagingTotal;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI[] blueDamagingPercent;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI[] playerMultiplier;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI[] playerHookMultiplier;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI[] playerJabMultiplier;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI[] playerUpperMultiplier;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x90E14C", Offset = "0x90E14C", VA = "0x90E14C")]
		public void ShowBoutResults()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x90FDC4", Offset = "0x90FDC4", VA = "0x90FDC4")]
		public PunchStatsGenerator()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class PunchStatsLeftGenerator : MonoBehaviour
	{
		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI redCornerName;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI blueCornerName;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI[] redStraightsLanded;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI[] redStraightsTotal;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI[] redStraightsPercent;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI[] blueStraightsLanded;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI[] blueStraightsTotal;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI[] blueStraightsPercent;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI[] redHooksLanded;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI[] redHooksTotal;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI[] redHooksPercent;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI[] blueHooksLanded;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI[] blueHooksTotal;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI[] blueHooksPercent;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI[] redUppersLanded;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI[] redUppersTotal;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI[] redUppersPercent;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI[] blueUppersLanded;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public TextMeshProUGUI[] blueUppersTotal;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI[] blueUppersPercent;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x90FDCC", Offset = "0x90FDCC", VA = "0x90FDCC")]
		public void ShowBoutResults()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x9121C4", Offset = "0x9121C4", VA = "0x9121C4")]
		public PunchStatsLeftGenerator()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class PunchStatsRightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI redCornerName;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI blueCornerName;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI[] redStraightsLanded;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI[] redStraightsTotal;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI[] redStraightsPercent;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI[] blueStraightsLanded;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI[] blueStraightsTotal;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI[] blueStraightsPercent;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI[] redHooksLanded;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI[] redHooksTotal;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI[] redHooksPercent;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI[] blueHooksLanded;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI[] blueHooksTotal;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI[] blueHooksPercent;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI[] redUppersLanded;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI[] redUppersTotal;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI[] redUppersPercent;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI[] blueUppersLanded;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public TextMeshProUGUI[] blueUppersTotal;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI[] blueUppersPercent;

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x9121CC", Offset = "0x9121CC", VA = "0x9121CC")]
		public void ShowBoutResults()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x9145C4", Offset = "0x9145C4", VA = "0x9145C4")]
		public PunchStatsRightGenerator()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class QuitPoster : MonoBehaviour
	{
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x9145CC", Offset = "0x9145CC", VA = "0x9145CC")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x91469C", Offset = "0x91469C", VA = "0x91469C")]
		public QuitPoster()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class QuitTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ProgressRadialBehaviour ProgressBar;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isCounting;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float count;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float triggerTime;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isTriggered;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool triggerState;

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x9146A4", Offset = "0x9146A4", VA = "0x9146A4")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x91471C", Offset = "0x91471C", VA = "0x91471C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x914790", Offset = "0x914790", VA = "0x914790")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x9147D4", Offset = "0x9147D4", VA = "0x9147D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x914944", Offset = "0x914944", VA = "0x914944")]
		private void StartTimer()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x914794", Offset = "0x914794", VA = "0x914794")]
		private void ResetTimer()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x914954", Offset = "0x914954", VA = "0x914954")]
		public void QuitBout()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x9149B4", Offset = "0x9149B4", VA = "0x9149B4")]
		public QuitTrigger()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class RadioController : MonoBehaviour
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] songs;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int waitFramesBeforeStarting;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int framesToWait;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource source;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool useRadio;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int songIndex;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int playlistCount;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool foundSongs;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool attemptingToPlay;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RadioController instance;

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x914A10", Offset = "0x914A10", VA = "0x914A10")]
		public static void SetRadioVolume(float volume)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x914AD4", Offset = "0x914AD4", VA = "0x914AD4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x914BCC", Offset = "0x914BCC", VA = "0x914BCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x914C1C", Offset = "0x914C1C", VA = "0x914C1C")]
		private void PlaySong(int index)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x914C24", Offset = "0x914C24", VA = "0x914C24")]
		private void PlaySong()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x914CB4", Offset = "0x914CB4", VA = "0x914CB4")]
		private void PlayNextSong()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x914CD8", Offset = "0x914CD8", VA = "0x914CD8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x914D5C", Offset = "0x914D5C", VA = "0x914D5C")]
		public RadioController()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class RefereeController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E9")]
		public struct ClipGroup
		{
			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LipSyncData[] clips;
		}

		[Token(Token = "0x20000EA")]
		private enum Mode
		{
			[Token(Token = "0x4000880")]
			Idle,
			[Token(Token = "0x4000881")]
			Watching,
			[Token(Token = "0x4000882")]
			Counting
		}

		[Token(Token = "0x4000687")]
		private const float clinchDisqualificationTime = 5f;

		[Token(Token = "0x4000688")]
		private const float movementAcceleration = 2f;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float scowlRange;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RefereeController instance;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFBA8", Offset = "0x6CFBA8")]
		private bool <isCounting>k__BackingField;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float countdownTimer;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int onSecond;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform head;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion targetFacing;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool moveToSpecifiedPosition;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 turnToFacing;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 moveToPosition;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoutController.Corner lookingAtCorner;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private LookAtIK lik;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int hitLayerIndex;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int hitLayerIndex1;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int hitLayerIndex2;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private LipSync mouth;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform lookTarget;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool looking;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int numberIndex;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float backOffCooldown;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool doBlinkCycle;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool blinking;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float blinkTimer;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float timeToWaitBeforeStarting;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float timeToWait;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		protected float expressPainTarget;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected float expressPainLevel;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		protected float expressConcernTarget;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected float expressConcernLevel;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		protected float playerClinchCounter;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public VertexSkinnedMeshRenderer bodyMesh;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public ClipGroup[] countClips;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public LipSyncData[] instructionClips;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public LipSyncData[] backOffClips;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Mode mode;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public EnemyBlendshapes blendshapes;

		[Token(Token = "0x170000B9")]
		public static RefereeController Instance
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x914D6C", Offset = "0x914D6C", VA = "0x914D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public bool isCounting
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x914DBC", Offset = "0x914DBC", VA = "0x914DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F20", Offset = "0x6D0F20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x914DC4", Offset = "0x914DC4", VA = "0x914DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F30", Offset = "0x6D0F30")]
			set
			{
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x914DD0", Offset = "0x914DD0", VA = "0x914DD0")]
		public static RefereeController Find()
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x914F24", Offset = "0x914F24", VA = "0x914F24")]
		public void PlayBackOffClip()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x915040", Offset = "0x915040", VA = "0x915040")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x915184", Offset = "0x915184", VA = "0x915184")]
		public void Start()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x915458", Offset = "0x915458", VA = "0x915458")]
		public void Update()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x91686C", Offset = "0x91686C", VA = "0x91686C")]
		public void StartCounting()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x916918", Offset = "0x916918", VA = "0x916918")]
		public void LookAtBoxer(BoutController.Corner corner)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x916A24", Offset = "0x916A24", VA = "0x916A24")]
		public void LookAtNobody()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x916338", Offset = "0x916338", VA = "0x916338")]
		public void UpdateLook()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x9154E8", Offset = "0x9154E8", VA = "0x9154E8")]
		public void UpdateCount()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x916BD8", Offset = "0x916BD8", VA = "0x916BD8")]
		public void WaveFightEnd()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x916B4C", Offset = "0x916B4C", VA = "0x916B4C")]
		public void StopCounting(bool startWatching = true)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x915020", Offset = "0x915020", VA = "0x915020")]
		public void StopTalking()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x916A50", Offset = "0x916A50", VA = "0x916A50")]
		public void PlayCountClip(int onSecond)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x915368", Offset = "0x915368", VA = "0x915368")]
		public void PlayInstructions()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x916C4C", Offset = "0x916C4C", VA = "0x916C4C")]
		public void FocusOnBoxer(BoutController.Corner corner)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x916C3C", Offset = "0x916C3C", VA = "0x916C3C")]
		public void FocusOnMatch()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x916C78", Offset = "0x916C78", VA = "0x916C78")]
		public void HoldBack()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x916CD8", Offset = "0x916CD8", VA = "0x916CD8")]
		public void WaveStart()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x916D3C", Offset = "0x916D3C", VA = "0x916D3C")]
		public void MoveToNearestNeutralCorner()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x916F94", Offset = "0x916F94", VA = "0x916F94")]
		public void MoveToRoundStartPosition()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x91535C", Offset = "0x91535C", VA = "0x91535C")]
		public void GoIdle()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x9155B8", Offset = "0x9155B8", VA = "0x9155B8")]
		public void UpdateMovement()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x9171EC", Offset = "0x9171EC", VA = "0x9171EC")]
		public void ReceiveHurtboxCollision(float force, Hurtbox hurtbox, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x917748", Offset = "0x917748", VA = "0x917748")]
		protected void HurtboxCollisionAudioResult(float force, Hurtbox hurtbox, Collision collision)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x917228", Offset = "0x917228", VA = "0x917228")]
		protected void HurtboxCollisionVisualResult(float force, Hurtbox hurtbox, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x9177E8", Offset = "0x9177E8", VA = "0x9177E8", Slot = "4")]
		protected virtual void StartBlinkCycle()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x917820", Offset = "0x917820", VA = "0x917820", Slot = "5")]
		protected virtual void StopBlinkCycle()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x917830", Offset = "0x917830", VA = "0x917830")]
		protected void HandleBlink()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x9178C0", Offset = "0x9178C0", VA = "0x9178C0", Slot = "6")]
		protected virtual void MakeBlink()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x91795C", Offset = "0x91795C", VA = "0x91795C", Slot = "7")]
		protected virtual void StopBlink()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x917968", Offset = "0x917968", VA = "0x917968")]
		public void ExpressPain(float targetLevel)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x917970", Offset = "0x917970", VA = "0x917970")]
		public void ExpressConcern(float targetLevel)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x9164A8", Offset = "0x9164A8", VA = "0x9164A8")]
		public void UpdateExpressions()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x9151DC", Offset = "0x9151DC", VA = "0x9151DC")]
		private void LoadBlendshapeIndexes()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x917A90", Offset = "0x917A90", VA = "0x917A90")]
		private void FindBlendshapeIndexes(ref BlendshapeDefinition[] blendshapeDefinitions)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x917978", Offset = "0x917978", VA = "0x917978")]
		private void SetPainBlendshape(float value)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x917BB4", Offset = "0x917BB4", VA = "0x917BB4")]
		private void SetBlendShapeWeight(int index, float value)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x9178D0", Offset = "0x9178D0", VA = "0x9178D0")]
		private void SetBlinkBlendshape(float value)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x917A04", Offset = "0x917A04", VA = "0x917A04")]
		private void SetFlinchBlendshape(float value)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x916634", Offset = "0x916634", VA = "0x916634")]
		public void HandleFlinch()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x917BDC", Offset = "0x917BDC", VA = "0x917BDC")]
		public RefereeController()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class RefereeHurtbox : Hurtbox
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFBB8", Offset = "0x6CFBB8")]
		private RefereeController <referee>k__BackingField;

		[Token(Token = "0x170000BB")]
		public RefereeController referee
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x917BF8", Offset = "0x917BF8", VA = "0x917BF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F40", Offset = "0x6D0F40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x917C00", Offset = "0x917C00", VA = "0x917C00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F50", Offset = "0x6D0F50")]
			set
			{
			}
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x917C08", Offset = "0x917C08", VA = "0x917C08", Slot = "6")]
		public override void ReceiveHitboxCollision(float force, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x917C5C", Offset = "0x917C5C", VA = "0x917C5C")]
		public RefereeHurtbox()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CE3F0", Offset = "0x6CE3F0")]
	public class RoundBellController : MonoBehaviour
	{
		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RoundBellController instance;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AudioSource audioSource;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool spatialize;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip roundBellClip;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip tenSecondClip;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip roundEndClip;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x917CC4", Offset = "0x917CC4", VA = "0x917CC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x917DA0", Offset = "0x917DA0", VA = "0x917DA0")]
		public static void PlayRoundStartClip()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x917EE4", Offset = "0x917EE4", VA = "0x917EE4")]
		public static void PlayRoundEndClip()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x918028", Offset = "0x918028", VA = "0x918028")]
		public static void PlayTenSecondClip()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x91816C", Offset = "0x91816C", VA = "0x91816C")]
		public RoundBellController()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class RoundScoreUI : MonoBehaviour
	{
		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text[] rounds;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text[] redScores;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text[] blueScores;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x91817C", Offset = "0x91817C", VA = "0x91817C")]
		public void UpdateScores(int[][] scores, int round)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x918314", Offset = "0x918314", VA = "0x918314")]
		public RoundScoreUI()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class RoundTimerController : MonoBehaviour
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI timerText;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI roundText;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public char padder;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float timer;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool countdown;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isEnabled;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int storedMinutes;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int storedSeconds;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool registeredEventInAwake;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool countUp;

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x91831C", Offset = "0x91831C", VA = "0x91831C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x9184A0", Offset = "0x9184A0", VA = "0x9184A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x9185E4", Offset = "0x9185E4", VA = "0x9185E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x91864C", Offset = "0x91864C", VA = "0x91864C")]
		public void UpdateTimeValue()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x9187A0", Offset = "0x9187A0", VA = "0x9187A0")]
		public void TimerUpdate(bool startCounting, bool isRound, float duration, int onRound, int numberOfRounds)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x918840", Offset = "0x918840", VA = "0x918840")]
		public RoundTimerController()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class ScoreCardGenerator : MonoBehaviour
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI redCornerName;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI blueCornerName;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] scoreColumns;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI[] redTotalColumns;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI[] blueTotalColumns;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI winnerText;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI winReasonText;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color highScoreColor;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Color defaultScoreColor;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Color redCornerColor;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Color blueCornerColor;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject scorecard;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public ScoreDetailsGenerator detailsCard;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public PunchStatsGenerator statCard;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public PunchStatsLeftGenerator statCard2;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public PunchStatsRightGenerator statCard3;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Color selectedColor;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Color defaultColor;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Image scoreButton;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI scoreButtonText;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Image scoreButtonTextIcon;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Image detailsButton;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public TextMeshProUGUI detailsButtonText;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Image detailsButtonTextIcon;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Image punchesButton;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public TextMeshProUGUI punchesButtonText;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Image punchesButtonTextIcon;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Image stats2Button;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public TextMeshProUGUI stats2ButtonText;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Image stats2ButtonTextIcon;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Image stats3Button;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public TextMeshProUGUI stats3ButtonText;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Image stats3ButtonTextIcon;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private int showingCard;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x918860", Offset = "0x918860", VA = "0x918860")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x91A364", Offset = "0x91A364", VA = "0x91A364")]
		public void ToggleCardsButton(int card)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x91A46C", Offset = "0x91A46C", VA = "0x91A46C")]
		public void SwitchCard(int card)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x91A0C0", Offset = "0x91A0C0", VA = "0x91A0C0")]
		private void ShowScorecard()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x91A4B0", Offset = "0x91A4B0", VA = "0x91A4B0")]
		private void ShowScoreDetails()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x91A754", Offset = "0x91A754", VA = "0x91A754")]
		private void ShowPunchStats()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x91A9F8", Offset = "0x91A9F8", VA = "0x91A9F8")]
		private void ShowPunchStats2()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x91AC9C", Offset = "0x91AC9C", VA = "0x91AC9C")]
		private void ShowPunchStats3()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x9188D4", Offset = "0x9188D4", VA = "0x9188D4")]
		public void ShowBoutResults()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x91AF40", Offset = "0x91AF40", VA = "0x91AF40")]
		public ScoreCardGenerator()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class ScoreDetailsGenerator : MonoBehaviour
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI redCornerName;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI blueCornerName;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color highScoreColor;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color defaultScoreColor;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI[] redKnockdownsScored;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI[] blueKnockdownsScored;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI[] redDamageTotal1;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI[] blueDamageTotal1;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI[] redDamageTotal2;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI[] blueDamageTotal2;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI[] redDamageTotal3;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI[] blueDamageTotal3;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x9191A0", Offset = "0x9191A0", VA = "0x9191A0")]
		public void ShowBoutResults()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x91AF48", Offset = "0x91AF48", VA = "0x91AF48")]
		public ScoreDetailsGenerator()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class ScoreDisplay : MonoBehaviour
	{
		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RoundScoreUI roundScorePrefab;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject judgeHeadings;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject scores;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TotalScoreUI totals;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject winReason;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Text winReasonText;

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x91AF50", Offset = "0x91AF50", VA = "0x91AF50")]
		public ScoreDisplay()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class ScreenGrabber : MonoBehaviour
	{
		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D screenGrabTexture;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x91AF58", Offset = "0x91AF58", VA = "0x91AF58")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x91AFAC", Offset = "0x91AFAC", VA = "0x91AFAC")]
		public ScreenGrabber()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class ScreenUIController : MonoBehaviour
	{
		[Token(Token = "0x40006F8")]
		private const int charOffset = 48;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<ScreenUIController> screens;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI minutesText;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI secondsText;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI onRoundText;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI totalRoundsText;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RawImage cutoutPhoto;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float timer;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool countdown;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int storedMinutes;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int storedSeconds;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool registeredEventInAwake;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool countUp;

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x91AFB4", Offset = "0x91AFB4", VA = "0x91AFB4")]
		public static void Enable()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x91B070", Offset = "0x91B070", VA = "0x91B070")]
		public static void Disable()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x91B12C", Offset = "0x91B12C", VA = "0x91B12C")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x91B198", Offset = "0x91B198", VA = "0x91B198")]
		private void Awake()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x91B3BC", Offset = "0x91B3BC", VA = "0x91B3BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x91B61C", Offset = "0x91B61C", VA = "0x91B61C")]
		private void Update()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x91B684", Offset = "0x91B684", VA = "0x91B684")]
		public void UpdateTimeValue()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x91BB50", Offset = "0x91BB50", VA = "0x91BB50")]
		public void TimerUpdate(bool startCounting, bool isRound, float duration, int onRound, int numberOfRounds)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x91B7B0", Offset = "0x91B7B0", VA = "0x91B7B0")]
		private static string IntToString(int intVal, bool pad = false)
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x91BC94", Offset = "0x91BC94", VA = "0x91BC94")]
		public ScreenUIController()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class SensorPlacementButton : MonoBehaviour
	{
		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int type;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Button button;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text text;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject turnMenu;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SensorPlacementButton[] buttons;

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x91BCA4", Offset = "0x91BCA4", VA = "0x91BCA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x91BD48", Offset = "0x91BD48", VA = "0x91BD48")]
		private void Start()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x91BEB4", Offset = "0x91BEB4", VA = "0x91BEB4")]
		private void OnTriggerEnter()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x91BDBC", Offset = "0x91BDBC", VA = "0x91BDBC")]
		public void Press()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x91BF5C", Offset = "0x91BF5C", VA = "0x91BF5C")]
		public void Depress()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x91C014", Offset = "0x91C014", VA = "0x91C014")]
		public SensorPlacementButton()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class SettingsMenu : ChildMenuManager
	{
		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFBC8", Offset = "0x6CFBC8")]
		private HomeMenuManager <homeManager>k__BackingField;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject calibrateControllerButton;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject turnInOption;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject turnOutOption;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject punchForceSliderParent;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Slider punchForceSlider;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI multiplierText;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Slider hookForceSlider;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI hookMultiplierText;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Slider jabForceSlider;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI jabMultiplierText;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Slider upperForceSlider;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI upperMultiplierText;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public SettingsToggleGroup controllerPositionToggle;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public SettingsToggleGroup controllerOutlineToggle;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public SettingsToggleGroup cameraToggle;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public SettingsToggleGroup forwardToggle;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public SettingsToggleGroup turnToggle;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public SettingsToggleGroup driftProtectionToggle;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public SettingsToggleGroup impactEffectToggle;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public SettingsToggleGroup audienceToggle;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public TotFSlider radioSlider;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public TotFSlider crowdVolumeSlider;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public TotFSlider brightnessSlider;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public TotFSlider gloveSizeSlider;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Toggle autoPunchForceToggle;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool showCameraValue;

		[Token(Token = "0x170000BC")]
		public HomeMenuManager homeManager
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x91C01C", Offset = "0x91C01C", VA = "0x91C01C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F60", Offset = "0x6D0F60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x91C024", Offset = "0x91C024", VA = "0x91C024")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F70", Offset = "0x6D0F70")]
			set
			{
			}
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x91C02C", Offset = "0x91C02C", VA = "0x91C02C", Slot = "4")]
		public override void OpenMenu()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x91C478", Offset = "0x91C478", VA = "0x91C478")]
		private void Update()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x91C054", Offset = "0x91C054", VA = "0x91C054")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x91CB7C", Offset = "0x91CB7C", VA = "0x91CB7C")]
		public void SetControllerPosition(int value)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x91C5F4", Offset = "0x91C5F4", VA = "0x91C5F4")]
		public void ShowCalibrateButton(int value)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x91CBC0", Offset = "0x91CBC0", VA = "0x91CBC0")]
		public void SetControllerOutline(int value)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x91CC78", Offset = "0x91CC78", VA = "0x91CC78")]
		public void SetImpactEffect(int value)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x91CCD8", Offset = "0x91CCD8", VA = "0x91CCD8")]
		public void SetDisplayAudience(int value)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x91CD2C", Offset = "0x91CD2C", VA = "0x91CD2C")]
		public void SetDriftProtection(int value)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x91CDC0", Offset = "0x91CDC0", VA = "0x91CDC0")]
		public void SetThirdPersonCamera(int value)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x91C9D0", Offset = "0x91C9D0", VA = "0x91C9D0")]
		public void SetRadioVolumeSlider(int value)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x91D0D0", Offset = "0x91D0D0", VA = "0x91D0D0")]
		public void SetRadioVolumeValue(float floatValue)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x91CA40", Offset = "0x91CA40", VA = "0x91CA40")]
		public void SetCrowdVolumeSlider(int prefValue)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x91D208", Offset = "0x91D208", VA = "0x91D208")]
		public void SetCrowdVolumeValue(float sliderValue)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x91CAB0", Offset = "0x91CAB0", VA = "0x91CAB0")]
		public void SetBrightnessSlider(int prefValue)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x91D308", Offset = "0x91D308", VA = "0x91D308")]
		public void SetBrightnessValue(float sliderValue)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x91CB20", Offset = "0x91CB20", VA = "0x91CB20")]
		public void SetGloveSizeSlider(int value)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x91D408", Offset = "0x91D408", VA = "0x91D408")]
		public void SetGloveSizeValue(float floatValue)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x91D524", Offset = "0x91D524", VA = "0x91D524")]
		public void SetForceForwardFacing(int value)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x91C628", Offset = "0x91C628", VA = "0x91C628")]
		public void ShowTurnOptions(int value)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x91D590", Offset = "0x91D590", VA = "0x91D590")]
		public void SetTurnDirection(int value)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x91D5E4", Offset = "0x91D5E4", VA = "0x91D5E4")]
		public void SetPunchForceAutomatic()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x91C674", Offset = "0x91C674", VA = "0x91C674")]
		public void ShowForceSlider(int value)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x91D74C", Offset = "0x91D74C", VA = "0x91D74C")]
		public void SetManualPunchForceValue(float floatValue)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x91D9B4", Offset = "0x91D9B4", VA = "0x91D9B4")]
		public void SetManualHookForceValue(float floatValue)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x91DC1C", Offset = "0x91DC1C", VA = "0x91DC1C")]
		public void SetManualJabForceValue(float floatValue)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x91DE84", Offset = "0x91DE84", VA = "0x91DE84")]
		public void SetManualUpperForceValue(float floatValue)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x91E0EC", Offset = "0x91E0EC", VA = "0x91E0EC")]
		public void CloseButtonPressed()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x91E204", Offset = "0x91E204", VA = "0x91E204")]
		public void StartCalibration()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x91E314", Offset = "0x91E314", VA = "0x91E314")]
		public SettingsMenu()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6CE454", Offset = "0x6CE454")]
	public class SettingsToggle : MonoBehaviour
	{
		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int value;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle _toggle;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CFBD8", Offset = "0x6CFBD8")]
		private SettingsToggleGroup <toggleGroup>k__BackingField;

		[Token(Token = "0x170000BD")]
		public Toggle toggle
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x91E31C", Offset = "0x91E31C", VA = "0x91E31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public SettingsToggleGroup toggleGroup
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x91E3B4", Offset = "0x91E3B4", VA = "0x91E3B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F80", Offset = "0x6D0F80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x91E3BC", Offset = "0x91E3BC", VA = "0x91E3BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F90", Offset = "0x6D0F90")]
			set
			{
			}
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x91E3C4", Offset = "0x91E3C4", VA = "0x91E3C4")]
		public void Awake()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x91E4E8", Offset = "0x91E4E8", VA = "0x91E4E8")]
		public void FakePointerDownAsClick(PointerEventData data)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x91E614", Offset = "0x91E614", VA = "0x91E614")]
		public void ReportToToggleGroup()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x91E678", Offset = "0x91E678", VA = "0x91E678")]
		public SettingsToggle()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x91E680", Offset = "0x91E680", VA = "0x91E680")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0FA0", Offset = "0x6D0FA0")]
		private void <Awake>b__8_0(BaseEventData data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class SettingsToggleEvent : UnityEvent<int>
	{
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x91E710", Offset = "0x91E710", VA = "0x91E710")]
		public SettingsToggleEvent()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class SettingsToggleGroup : MonoBehaviour
	{
		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SettingsToggleEvent action;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SettingsToggle[] toggles;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x91E760", Offset = "0x91E760", VA = "0x91E760")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x91C53C", Offset = "0x91C53C", VA = "0x91C53C")]
		public void SetValue(int value)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x91E800", Offset = "0x91E800", VA = "0x91E800")]
		public SettingsToggleGroup()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class SkinnedAudienceController : AudienceController
	{
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x91E808", Offset = "0x91E808", VA = "0x91E808")]
		public SkinnedAudienceController()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class SliderScrollbar : MonoBehaviour
	{
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScrollRect scrollRect;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool vertical;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Slider slider;

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x91E810", Offset = "0x91E810", VA = "0x91E810")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x91E868", Offset = "0x91E868", VA = "0x91E868")]
		public void ChangeScrollPos()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x91E9F8", Offset = "0x91E9F8", VA = "0x91E9F8")]
		public SliderScrollbar()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class SpectatorCamera : MonoBehaviour
	{
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string prefLabel;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<SpectatorCamera> cameras;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool init;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public static bool camerasEnabled;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Camera cameraComponent;

		[Token(Token = "0x170000BF")]
		public static bool isInitialized
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x91EA08", Offset = "0x91EA08", VA = "0x91EA08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x91EAB0", Offset = "0x91EAB0", VA = "0x91EAB0")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x91CE60", Offset = "0x91CE60", VA = "0x91CE60")]
		public static void Enable()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x91CF88", Offset = "0x91CF88", VA = "0x91CF88")]
		public static void Disable()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x91EBDC", Offset = "0x91EBDC", VA = "0x91EBDC")]
		public static void Toggle()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x91EC90", Offset = "0x91EC90", VA = "0x91EC90", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x91ED64", Offset = "0x91ED64", VA = "0x91ED64", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x91EDE8", Offset = "0x91EDE8", VA = "0x91EDE8")]
		public void TurnOn()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x91EE10", Offset = "0x91EE10", VA = "0x91EE10")]
		public void TurnOff()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x91EB9C", Offset = "0x91EB9C", VA = "0x91EB9C")]
		public void EnableInstance()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x91EBBC", Offset = "0x91EBBC", VA = "0x91EBBC")]
		public void DisableInstance()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x91EE38", Offset = "0x91EE38", VA = "0x91EE38")]
		public SpectatorCamera()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class SpeedBagCollider : Equipment
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpeedBagController controller;

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x91EEB0", Offset = "0x91EEB0", VA = "0x91EEB0")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x91F490", Offset = "0x91F490", VA = "0x91F490")]
		public SpeedBagCollider()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class SpeedBagController : MonoBehaviour, IFixedUpdateable
	{
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SpeedBagController instance;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform trainer;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpectatorCamera spectatorCamera;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject uiCanvas;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool initialized;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string defaultVal;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform trainerSmallSpacePosition;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform trainerLargeSpacePosition;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float trainerSmallPositionWidth;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float trainerSmallPositionDepth;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip fistImpactClip;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioClip backstopImpactClip;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Rigidbody bagRb;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bagModel;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool hitFistThisUpdate;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float timeSinceLastHit;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool countTimeSinceLastHit;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int bestHpm1;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int bestHpm2;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float forceNeededForMaxVolume;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float bagRotation;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float bagVelocity;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float bagAngleLimit;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float bagVelocityWindResistance;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float bagKickVelocity;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fistBounceEnergy;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float backstopBounceEnergy;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float fistEnergyMultiplier;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float bagMpsToDps;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float timeLengthOne;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float timeLengthTwo;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI timeOneText;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public TextMeshProUGUI timeTwoText;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI bestTimeOneText;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI bestTimeTwoText;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<float> hitTimes1List;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<float> hitTimes2List;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool eventOn;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float lastFixedUpdateRotation;

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x91F498", Offset = "0x91F498", VA = "0x91F498")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x91F580", Offset = "0x91F580", VA = "0x91F580")]
		public static void InitializeSpeedBag()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x91F624", Offset = "0x91F624", VA = "0x91F624")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x91FA60", Offset = "0x91FA60", VA = "0x91FA60")]
		public void DeinitializeSpeedBag()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x91FB74", Offset = "0x91FB74", VA = "0x91FB74")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x91FB7C", Offset = "0x91FB7C", VA = "0x91FB7C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x91FB84", Offset = "0x91FB84", VA = "0x91FB84")]
		public void Awake()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x91FC34", Offset = "0x91FC34", VA = "0x91FC34")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x91FC3C", Offset = "0x91FC3C", VA = "0x91FC3C")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6D0FB0", Offset = "0x6D0FB0")]
		public void KickBag()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x91FC48", Offset = "0x91FC48", VA = "0x91FC48")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x6D0FC0", Offset = "0x6D0FC0")]
		public void KickBagBack()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x91FC58", Offset = "0x91FC58", VA = "0x91FC58", Slot = "4")]
		public void CustomFixedUpdate()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x920398", Offset = "0x920398", VA = "0x920398")]
		public void PostSimulation()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x92039C", Offset = "0x92039C", VA = "0x92039C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x91FFC8", Offset = "0x91FFC8", VA = "0x91FFC8")]
		private void BackstopHit(float intensity)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x9205F0", Offset = "0x9205F0", VA = "0x9205F0")]
		public void ResetBestHpmButton()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x91EF7C", Offset = "0x91EF7C", VA = "0x91EF7C")]
		public void ColliderHit(Collision collision, PlayerFist hitbox)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x92051C", Offset = "0x92051C", VA = "0x92051C")]
		private void SetText(TextMeshProUGUI ui, int val)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x91F764", Offset = "0x91F764", VA = "0x91F764")]
		private void ResetHpm()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x91F7EC", Offset = "0x91F7EC", VA = "0x91F7EC")]
		private void ResetBestHpm()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x9206F0", Offset = "0x9206F0", VA = "0x9206F0")]
		public void Exit()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x9206F4", Offset = "0x9206F4", VA = "0x9206F4")]
		public void CloseButtonPressed()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x9207FC", Offset = "0x9207FC", VA = "0x9207FC")]
		public void PlaySpaceUpdated()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x91F824", Offset = "0x91F824", VA = "0x91F824")]
		public void MovePlayer()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x920800", Offset = "0x920800", VA = "0x920800")]
		public SpeedBagController()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class SpeedBagFistCollider : MonoBehaviour
	{
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x92088C", Offset = "0x92088C", VA = "0x92088C")]
		public SpeedBagFistCollider()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x6CE4B8", Offset = "0x6CE4B8")]
	public class SpotlightMover : MonoBehaviour
	{
		[Token(Token = "0x400075A")]
		private const float lightDistance = 20f;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform lightBeam;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float xRange;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float yRange;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float zRange;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float frequency;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float verticalFrequency;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float counter;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float verticalCounter;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit[] results;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int audienceLayerMask;

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x920894", Offset = "0x920894", VA = "0x920894")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x92090C", Offset = "0x92090C", VA = "0x92090C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x920CCC", Offset = "0x920CCC", VA = "0x920CCC")]
		public SpotlightMover()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class TextureScroller : MonoBehaviour
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float scrollRate;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string textureName;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material material;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float xOffset;

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x9215E4", Offset = "0x9215E4", VA = "0x9215E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x92164C", Offset = "0x92164C", VA = "0x92164C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x9216E4", Offset = "0x9216E4", VA = "0x9216E4")]
		public TextureScroller()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class TotFSlider : MonoBehaviour
	{
		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshProUGUI label;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Slider slider;

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x92173C", Offset = "0x92173C", VA = "0x92173C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x91D1E4", Offset = "0x91D1E4", VA = "0x91D1E4")]
		public void SetLabel(string text)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x91D0AC", Offset = "0x91D0AC", VA = "0x91D0AC")]
		public void SetValue(float value)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x92181C", Offset = "0x92181C", VA = "0x92181C")]
		public TotFSlider()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class TotFTween : MonoBehaviour
	{
		[Token(Token = "0x400076B")]
		public const int controlNodeCount = 2;

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x921824", Offset = "0x921824", VA = "0x921824")]
		public TotFTween()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class TotalScoreUI : MonoBehaviour
	{
		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text[] redScores;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text[] blueScores;

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x92182C", Offset = "0x92182C", VA = "0x92182C")]
		public void UpdateScores(int[] redTotals, int[] blueTotals)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x9219DC", Offset = "0x9219DC", VA = "0x9219DC")]
		public TotalScoreUI()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class TotfSettings
	{
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1373210", Offset = "0x1373210", VA = "0x1373210")]
		public TotfSettings()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class TrainerHurtbox : Hurtbox
	{
		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrainerController trainer;

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1374AE4", Offset = "0x1374AE4", VA = "0x1374AE4", Slot = "6")]
		public override void ReceiveHitboxCollision(float force, Hitbox hitbox, Collision collision)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1374B44", Offset = "0x1374B44", VA = "0x1374B44")]
		public TrainerHurtbox()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class UICamera : MonoBehaviour
	{
		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static RenderTexture renderCopyTo;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera cam;

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1374BAC", Offset = "0x1374BAC", VA = "0x1374BAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1374CAC", Offset = "0x1374CAC", VA = "0x1374CAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1374CFC", Offset = "0x1374CFC", VA = "0x1374CFC")]
		public UICamera()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class UIPointerController : MonoBehaviour
	{
		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float readyTime;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static PlayerUISelector lastHand;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float readyTimer;

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1374D04", Offset = "0x1374D04", VA = "0x1374D04")]
		public void Update()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1374D44", Offset = "0x1374D44", VA = "0x1374D44")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1374DAC", Offset = "0x1374DAC", VA = "0x1374DAC")]
		public void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x137502C", Offset = "0x137502C", VA = "0x137502C")]
		public void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x137521C", Offset = "0x137521C", VA = "0x137521C")]
		public void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1374F9C", Offset = "0x1374F9C", VA = "0x1374F9C")]
		public bool IsReady()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1375404", Offset = "0x1375404", VA = "0x1375404")]
		public static void ButtonPressFeedback(bool deactivatePointer = true)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x13754A4", Offset = "0x13754A4", VA = "0x13754A4")]
		public UIPointerController()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class UnlockLevel : MonoBehaviour
	{
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] unlockConditions;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1375504", Offset = "0x1375504", VA = "0x1375504")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x137561C", Offset = "0x137561C", VA = "0x137561C")]
		public UnlockLevel()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class VRController : MonoBehaviour
	{
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1375624", Offset = "0x1375624", VA = "0x1375624")]
		public VRController()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class VREventSystem : EventSystem
	{
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x137562C", Offset = "0x137562C", VA = "0x137562C", Slot = "17")]
		protected override void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1375638", Offset = "0x1375638", VA = "0x1375638")]
		public VREventSystem()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class VRGraphicRaycaster : GraphicRaycaster
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Collider canvasCollider;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas myCanvas;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x13756A0", Offset = "0x13756A0", VA = "0x13756A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x13757C0", Offset = "0x13757C0", VA = "0x13757C0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x13757C4", Offset = "0x13757C4", VA = "0x13757C4", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1375BCC", Offset = "0x1375BCC", VA = "0x1375BCC")]
		private LayerMask GetLayerMaskForMyLayer()
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1375BEC", Offset = "0x1375BEC", VA = "0x1375BEC", Slot = "22")]
		public virtual bool RaycastToCanvas(Ray ray3D, out Vector2 o_canvasPos)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1375934", Offset = "0x1375934", VA = "0x1375934")]
		protected void UpdateSelectedObjects(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1375E40", Offset = "0x1375E40", VA = "0x1375E40")]
		public VRGraphicRaycaster()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class WeighInController : MonoBehaviour
	{
		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Display display;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject cameraObject;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource audioSource;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LayerMask cameraLookMask;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ProgressRadialBehaviour progressBar;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxWeight;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float cameraLookTime;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weightValue;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool exiting;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool inWeighStation;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		private bool playerLookingAtCamera;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PlayerController player;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float timer;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool isActive;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1375EA8", Offset = "0x1375EA8", VA = "0x1375EA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1375F18", Offset = "0x1375F18", VA = "0x1375F18")]
		private void Update()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1376368", Offset = "0x1376368", VA = "0x1376368")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1376444", Offset = "0x1376444", VA = "0x1376444")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x137651C", Offset = "0x137651C", VA = "0x137651C")]
		public void SetActive(bool active)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1376528", Offset = "0x1376528", VA = "0x1376528")]
		public WeighInController()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class WeighInMenuPositioner : MonoBehaviour
	{
		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool tryToPlaceMenu;

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1376544", Offset = "0x1376544", VA = "0x1376544")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1376550", Offset = "0x1376550", VA = "0x1376550")]
		public void Update()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1376620", Offset = "0x1376620", VA = "0x1376620")]
		public WeighInMenuPositioner()
		{
		}
	}
}
