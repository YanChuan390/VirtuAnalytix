using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using AnimalVR;
using AnimalVR.Animal;
using AnimalVR.Animal.AI;
using AnimalVR.Animal.Action;
using AnimalVR.Aquarium;
using AnimalVR.Chara;
using AnimalVR.Cultivation;
using Il2CppDummyDll;
using Language;
using Spline;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using Utility;
using VRLocomotion;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class RotateCamera : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float MouseRotateSpeed;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xD07C00", Offset = "0xD07C00", VA = "0xD07C00")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD07C04", Offset = "0xD07C04", VA = "0xD07C04")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xD07D2C", Offset = "0xD07D2C", VA = "0xD07D2C")]
	public RotateCamera()
	{
	}
}
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class MC_CreateMatCap : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera screenshotCamera;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material previewMaterial;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x43F578", Offset = "0x43F578")]
	public bool revealOnSave;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x92EED0", Offset = "0x92EED0", VA = "0x92EED0")]
	public MC_CreateMatCap()
	{
	}
}
[Token(Token = "0x2000004")]
public class MC_AutoRotate : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 rotation;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x92EE5C", Offset = "0x92EE5C", VA = "0x92EE5C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x92EEC8", Offset = "0x92EEC8", VA = "0x92EEC8")]
	public MC_AutoRotate()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43EC38", Offset = "0x43EC38")]
public class MC_SwitchTexture : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture[] textures;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material targetMaterial;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RawImage image;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int index;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x92EEE0", Offset = "0x92EEE0", VA = "0x92EEE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x92EFE4", Offset = "0x92EFE4", VA = "0x92EFE4", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x92F018", Offset = "0x92F018", VA = "0x92F018")]
	public void NextTexture()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x92F04C", Offset = "0x92F04C", VA = "0x92F04C")]
	public void PrevTexture()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x92EF44", Offset = "0x92EF44", VA = "0x92EF44")]
	private void ReloadTexture()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x92F084", Offset = "0x92F084", VA = "0x92F084")]
	public MC_SwitchTexture()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43EC98", Offset = "0x43EC98")]
public class EnableCameraDepthInForward : MonoBehaviour
{
	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD239C4", Offset = "0xD239C4", VA = "0xD239C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD239C8", Offset = "0xD239C8", VA = "0xD239C8")]
	private void Set()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD23A50", Offset = "0xD23A50", VA = "0xD23A50")]
	public EnableCameraDepthInForward()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43ECF8", Offset = "0x43ECF8")]
public class SoftNormalsToVertexColor : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	public enum Method
	{
		[Token(Token = "0x400000E")]
		Simple,
		[Token(Token = "0x400000F")]
		AngularDeviation
	}

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Method method;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool generateOnAwake;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool generateNow;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD0AFD8", Offset = "0xD0AFD8", VA = "0xD0AFD8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD0B1FC", Offset = "0xD0B1FC", VA = "0xD0B1FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD0AFEC", Offset = "0xD0AFEC", VA = "0xD0AFEC")]
	private void TryGenerate()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xD0B20C", Offset = "0xD0B20C", VA = "0xD0B20C")]
	private void Generate(Mesh m)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xD0BAF8", Offset = "0xD0BAF8", VA = "0xD0BAF8")]
	public SoftNormalsToVertexColor()
	{
	}
}
[Token(Token = "0x2000009")]
public class FlickeringLight : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light flickeringLight;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float[] smoothing;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x920D40", Offset = "0x920D40", VA = "0x920D40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x920D94", Offset = "0x920D94", VA = "0x920D94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x920EA4", Offset = "0x920EA4", VA = "0x920EA4")]
	public FlickeringLight()
	{
	}
}
[Token(Token = "0x200000A")]
public class OrbitCamera : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float speedMod;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 point;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xCFE35C", Offset = "0xCFE35C", VA = "0xCFE35C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xCFE3BC", Offset = "0xCFE3BC", VA = "0xCFE3BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xCFE43C", Offset = "0xCFE43C", VA = "0xCFE43C")]
	public OrbitCamera()
	{
	}
}
[Token(Token = "0x200000B")]
public class AnimalAnimatorStateMachine : StateMachineBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AnimalAnimation animalAnimation;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD2CE8C", Offset = "0xD2CE8C", VA = "0xD2CE8C", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD2CED4", Offset = "0xD2CED4", VA = "0xD2CED4", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD2CF1C", Offset = "0xD2CF1C", VA = "0xD2CF1C")]
	public void SetAnimalAnimation(AnimalAnimation animalAnimation)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xD2CF24", Offset = "0xD2CF24", VA = "0xD2CF24")]
	public AnimalAnimatorStateMachine()
	{
	}
}
[Token(Token = "0x200000C")]
public class AnimalLimbsSoundManager
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private LimbsSoundScriptableObject limbsSound;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SoundEffect3D soundEffect3D;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LimbsSoundScriptableObject.Sound? playSound;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xD12354", Offset = "0xD12354", VA = "0xD12354")]
	public AnimalLimbsSoundManager(AnimalChara owner, LimbsSoundScriptableObject limbsSound)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xD12538", Offset = "0xD12538", VA = "0xD12538")]
	public void PlaySound(LimbsSoundScriptableObject.Sound sound, bool loop = false)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xD1272C", Offset = "0xD1272C", VA = "0xD1272C")]
	public void StopSound()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xD12750", Offset = "0xD12750", VA = "0xD12750")]
	public void ChangeVolume(float volume)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xD1276C", Offset = "0xD1276C", VA = "0xD1276C")]
	public void FadeIn(LimbsSoundScriptableObject.Sound sound, float fadeTime, bool loop = false)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xD12840", Offset = "0xD12840", VA = "0xD12840")]
	public void FadeOut(float fadeTime)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xD12688", Offset = "0xD12688", VA = "0xD12688")]
	private bool TryGetAudioClip(LimbsSoundScriptableObject.Sound sound, out AudioClip audioClip)
	{
		return default(bool);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xD125FC", Offset = "0xD125FC", VA = "0xD125FC")]
	private bool CanChangeAudioClip(LimbsSoundScriptableObject.Sound sound)
	{
		return default(bool);
	}
}
[Token(Token = "0x200000D")]
public class AnimalMouthSoundManager
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private MouthSoundScriptableObject mouthSound;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SoundEffect3D soundEffect3D;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MouthSoundScriptableObject.Sound? playSound;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xD132EC", Offset = "0xD132EC", VA = "0xD132EC")]
	public AnimalMouthSoundManager(AnimalChara owner, MouthSoundScriptableObject mouthSound)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xD121D0", Offset = "0xD121D0", VA = "0xD121D0")]
	public void PlaySound(MouthSoundScriptableObject.Sound sound, bool loop = false)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xD134E0", Offset = "0xD134E0", VA = "0xD134E0")]
	public void StopSound()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xD13504", Offset = "0xD13504", VA = "0xD13504")]
	public void FadeIn(MouthSoundScriptableObject.Sound sound, float fadeTime, bool loop = false)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xD135D8", Offset = "0xD135D8", VA = "0xD135D8")]
	public void FadeOut(float fadeTime)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xD1343C", Offset = "0xD1343C", VA = "0xD1343C")]
	private bool TryGetAudioClip(MouthSoundScriptableObject.Sound sound, out AudioClip audioClip)
	{
		return default(bool);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xD133B0", Offset = "0xD133B0", VA = "0xD133B0")]
	private bool CanChangeAudioClip(MouthSoundScriptableObject.Sound sound)
	{
		return default(bool);
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x43ED58", Offset = "0x43ED58")]
public class AnimalLookHead : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	public enum AXIS
	{
		[Token(Token = "0x400002B")]
		PositiveX,
		[Token(Token = "0x400002C")]
		NegativeX,
		[Token(Token = "0x400002D")]
		PositiveY,
		[Token(Token = "0x400002E")]
		NegativeY,
		[Token(Token = "0x400002F")]
		PositiveZ,
		[Token(Token = "0x4000030")]
		NegativeZ
	}

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x43F5B0", Offset = "0x43F5B0")]
	private float weight;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float turnSpeedK;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform rotateTrans;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform rotateBase;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform targetTrans;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F630", Offset = "0x43F630")]
	private Vector3 <targetPos>k__BackingField;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private AXIS yawAxis;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AXIS pitchAxis;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float maxYaw;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float maxPitch;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float tooNearDistance;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float yaw;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float pitch;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F690", Offset = "0x43F690")]
	private float <PitchOffset>k__BackingField;

	[Token(Token = "0x17000001")]
	public Vector3 targetPos
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0xD12868", Offset = "0xD12868", VA = "0xD12868")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4426A8", Offset = "0x4426A8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xD12874", Offset = "0xD12874", VA = "0xD12874")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4426B8", Offset = "0x4426B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public float Weight
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0xD12880", Offset = "0xD12880", VA = "0xD12880")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000031")]
		[Address(RVA = "0xD12888", Offset = "0xD12888", VA = "0xD12888")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float PitchOffset
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0xD12890", Offset = "0xD12890", VA = "0xD12890")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4426C8", Offset = "0x4426C8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xD12898", Offset = "0xD12898", VA = "0xD12898")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4426D8", Offset = "0x4426D8")]
		set
		{
		}
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xD128A0", Offset = "0xD128A0", VA = "0xD128A0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xD12A28", Offset = "0xD12A28", VA = "0xD12A28")]
	private Vector3 CalcLocalLookVec()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xD12B14", Offset = "0xD12B14", VA = "0xD12B14")]
	private void UpdateYawPitch(Vector3 localLookVec)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xD12C04", Offset = "0xD12C04", VA = "0xD12C04")]
	private Quaternion MakeQutaernion()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xD12C28", Offset = "0xD12C28", VA = "0xD12C28")]
	private static Vector3 MakeEuler(AXIS yawAxis, float yaw, AXIS pitchAxis, float pitch)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xD12CF4", Offset = "0xD12CF4", VA = "0xD12CF4")]
	public static Vector3 EyeDirectionPoint(Vector3 eyePos, Vector3 eyeDir, float maxDistance)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xD12D58", Offset = "0xD12D58", VA = "0xD12D58")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xD12DA0", Offset = "0xD12DA0", VA = "0xD12DA0")]
	public AnimalLookHead()
	{
	}
}
[Token(Token = "0x2000010")]
public class BootScene : VRScene
{
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43ED6C", Offset = "0x43ED6C")]
	private sealed class <InSceneCoroutine>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BootScene <>4__this;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneInMessage;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xCCBF68", Offset = "0xCCBF68", VA = "0xCCBF68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xCCBFB0", Offset = "0xCCBFB0", VA = "0xCCBFB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xCCBE68", Offset = "0xCCBE68", VA = "0xCCBE68")]
		[DebuggerHidden]
		public <InSceneCoroutine>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xCCBE94", Offset = "0xCCBE94", VA = "0xCCBE94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xCCBE98", Offset = "0xCCBE98", VA = "0xCCBE98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xCCBF70", Offset = "0xCCBF70", VA = "0xCCBF70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xD1BC0C", Offset = "0xD1BC0C", VA = "0xD1BC0C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4426E8", Offset = "0x4426E8")]
	public override IEnumerator InSceneCoroutine(string sceneInMessage)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xD1BCA0", Offset = "0xD1BCA0", VA = "0xD1BCA0")]
	public BootScene()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xD1BCA8", Offset = "0xD1BCA8", VA = "0xD1BCA8")]
	[DebuggerHidden]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442748", Offset = "0x442748")]
	private IEnumerator <>n__0(string sceneInMessage)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class ConfigData
{
	[Token(Token = "0x2000013")]
	public enum ComfortVignette
	{
		[Token(Token = "0x4000044")]
		On,
		[Token(Token = "0x4000045")]
		Off
	}

	[Token(Token = "0x2000014")]
	public enum SnapDegrees
	{
		[Token(Token = "0x4000047")]
		Deg_15,
		[Token(Token = "0x4000048")]
		Deg_30,
		[Token(Token = "0x4000049")]
		Deg_45,
		[Token(Token = "0x400004A")]
		Deg_90
	}

	[Token(Token = "0x2000015")]
	public enum SmoothDegreesPerSecond
	{
		[Token(Token = "0x400004C")]
		Deg_45,
		[Token(Token = "0x400004D")]
		Deg_90,
		[Token(Token = "0x400004E")]
		Deg_180,
		[Token(Token = "0x400004F")]
		Deg_360
	}

	[Token(Token = "0x2000016")]
	public enum Language
	{
		[Token(Token = "0x4000051")]
		English,
		[Token(Token = "0x4000052")]
		Japanese
	}

	[Token(Token = "0x2000017")]
	public enum DominantHand
	{
		[Token(Token = "0x4000054")]
		Left,
		[Token(Token = "0x4000055")]
		Right
	}

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly float[] SnapDegreeArray;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly float[] SmoothDegreeArray;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static MovementStyle movementStyle;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static ComfortVignette comfortVignette;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static TurningStyle turningStyle;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static SnapDegrees snapDegrees;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static SmoothDegreesPerSecond smoothDegrees;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static ControllerAllocation controllerAllocation;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static Language language;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public static DominantHand dominantHand;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static int volume_Master;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static int volume_BGM;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static int volume_GameSE;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public static int volume_SystemSE;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xD1F4D4", Offset = "0xD1F4D4", VA = "0xD1F4D4")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xD1F5A0", Offset = "0xD1F5A0", VA = "0xD1F5A0")]
	public static void Save()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xD1F80C", Offset = "0xD1F80C", VA = "0xD1F80C")]
	public static void Load()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xD1FAA8", Offset = "0xD1FAA8", VA = "0xD1FAA8")]
	public static bool IsEnableComfortVignette()
	{
		return default(bool);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xD1FB14", Offset = "0xD1FB14", VA = "0xD1FB14")]
	public static float GetFloat_SnapDegrees()
	{
		return default(float);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xD1FC30", Offset = "0xD1FC30", VA = "0xD1FC30")]
	public static float GetFloat_SmoothDegrees()
	{
		return default(float);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xD1FD4C", Offset = "0xD1FD4C", VA = "0xD1FD4C")]
	public static float GetDecibel_Master()
	{
		return default(float);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xD1FE10", Offset = "0xD1FE10", VA = "0xD1FE10")]
	public static float GetDecibel_BGM()
	{
		return default(float);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xD1FE8C", Offset = "0xD1FE8C", VA = "0xD1FE8C")]
	public static float GetDecibel_GameSE()
	{
		return default(float);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD1FF08", Offset = "0xD1FF08", VA = "0xD1FF08")]
	public static float GetDecibel_SystemSE()
	{
		return default(float);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD1FDC8", Offset = "0xD1FDC8", VA = "0xD1FDC8")]
	public static float VolumeRateToDecibel(float rate, float dbMin = -80f)
	{
		return default(float);
	}
}
[Token(Token = "0x2000018")]
public class ConfigMenu : MonoBehaviour
{
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ToggleGroupEvent movementStyles;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ToggleGroupEvent comfortVignette;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ToggleGroupEvent turningStyles;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ToggleGroupEvent snapDegrees;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ToggleGroupEvent smoothDegreePerSecond;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ToggleGroupEvent controllerAllocation;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ToggleGroupEvent masterVolume;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ToggleGroupEvent bgmVolume;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ToggleGroupEvent gameSEVolume;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ToggleGroupEvent systemSEVolume;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ToggleGroupEvent language;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ToggleGroupEvent dominantHand;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Button close;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private AudioClip toggleSE;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private AudioClip closeSE;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private LanguageTexts languageTexts;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Action onCloseButtonAction;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xD200D8", Offset = "0xD200D8", VA = "0xD200D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xD20578", Offset = "0xD20578", VA = "0xD20578")]
	private void ApplyUIFromData()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xD20770", Offset = "0xD20770", VA = "0xD20770")]
	private void ShowDegreesUI()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD20824", Offset = "0xD20824", VA = "0xD20824")]
	private void ApplyLanguage()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD208F8", Offset = "0xD208F8", VA = "0xD208F8")]
	public void OpenMenu([Optional] Action onCloseButtonAction)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD20970", Offset = "0xD20970", VA = "0xD20970")]
	public void CloseMenu(bool playCloseSE = true)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD20AB0", Offset = "0xD20AB0", VA = "0xD20AB0")]
	private void OnChange_MovementStyles(int select)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD20BD4", Offset = "0xD20BD4", VA = "0xD20BD4")]
	private void OnChange_ComfortVignette(int select)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD20C80", Offset = "0xD20C80", VA = "0xD20C80")]
	private void OnChange_TurningStyles(int select)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD20D2C", Offset = "0xD20D2C", VA = "0xD20D2C")]
	private void OnChange_SnapDegrees(int select)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD20DCC", Offset = "0xD20DCC", VA = "0xD20DCC")]
	private void OnChange_SmoothDegreePerSecond(int select)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xD20E6C", Offset = "0xD20E6C", VA = "0xD20E6C")]
	private void OnChange_ControllerAllocation(int select)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD20F10", Offset = "0xD20F10", VA = "0xD20F10")]
	private void OnChange_MasterVolume(int select)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD20FDC", Offset = "0xD20FDC", VA = "0xD20FDC")]
	private void OnChange_BGMVolume(int select)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xD210A8", Offset = "0xD210A8", VA = "0xD210A8")]
	private void OnChange_GameSEVolume(int select)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xD21174", Offset = "0xD21174", VA = "0xD21174")]
	private void OnChange_SystemSEVolume(int select)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD21240", Offset = "0xD21240", VA = "0xD21240")]
	private void OnChange_Language(int select)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD212C0", Offset = "0xD212C0", VA = "0xD212C0")]
	private void OnChange_DominantHand(int select)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD21368", Offset = "0xD21368", VA = "0xD21368")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xD20B54", Offset = "0xD20B54", VA = "0xD20B54")]
	private void PlaySE_Toggle()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xD20A30", Offset = "0xD20A30", VA = "0xD20A30")]
	private void PlaySE_Close()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xD213A4", Offset = "0xD213A4", VA = "0xD213A4")]
	private VR_Input.SIDE GetMoveControllerSide()
	{
		return default(VR_Input.SIDE);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xD21410", Offset = "0xD21410", VA = "0xD21410")]
	public ConfigMenu()
	{
	}
}
[Token(Token = "0x2000019")]
public class ParticleAndSound : MonoBehaviour
{
	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem[] particles;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip clip;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SoundEffect3D sound;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private UnityEvent onParticleStopAction;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isFinishParticle;

	[Token(Token = "0x17000006")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0xCFE69C", Offset = "0xCFE69C", VA = "0xCFE69C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xCFE6D8", Offset = "0xCFE6D8", VA = "0xCFE6D8")]
	private void Start()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xCFE7BC", Offset = "0xCFE7BC", VA = "0xCFE7BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xCFE988", Offset = "0xCFE988", VA = "0xCFE988")]
	public void PlayEffect(ParticleSystemStopAction stopAction = ParticleSystemStopAction.None)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xCFEB58", Offset = "0xCFEB58", VA = "0xCFEB58")]
	private void OnParticleSystemStopped()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xCFE898", Offset = "0xCFE898", VA = "0xCFE898")]
	private void Destroy_Object()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xCFEB90", Offset = "0xCFEB90", VA = "0xCFEB90")]
	public void AddListener(UnityAction onParticleStopAction)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xCFEBAC", Offset = "0xCFEBAC", VA = "0xCFEBAC")]
	public ParticleAndSound()
	{
	}
}
[Token(Token = "0x200001A")]
public class Whale : MonoBehaviour
{
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43ED7C", Offset = "0x43ED7C")]
	private sealed class <HideCoroutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Whale <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xCCDF74", Offset = "0xCCDF74", VA = "0xCCDF74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xCCDFBC", Offset = "0xCCDFBC", VA = "0xCCDFBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xCCDE74", Offset = "0xCCDE74", VA = "0xCCDE74")]
		[DebuggerHidden]
		public <HideCoroutine>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xCCDEA0", Offset = "0xCCDEA0", VA = "0xCCDEA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xCCDEA4", Offset = "0xCCDEA4", VA = "0xCCDEA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xCCDF7C", Offset = "0xCCDF7C", VA = "0xCCDF7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float hideTime;

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xD10E9C", Offset = "0xD10E9C", VA = "0xD10E9C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xD10EC8", Offset = "0xD10EC8", VA = "0xD10EC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4427D0", Offset = "0x4427D0")]
	private IEnumerator HideCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xD10F40", Offset = "0xD10F40", VA = "0xD10F40")]
	public Whale()
	{
	}
}
[Token(Token = "0x200001C")]
public class WhaleAppearanceManager : MonoBehaviour
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject whale;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform[] points;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float minTime;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float maxTime;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float timer;

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xD10F50", Offset = "0xD10F50", VA = "0xD10F50")]
	private void Start()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xD10F9C", Offset = "0xD10F9C", VA = "0xD10F9C")]
	private void Update()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xD10F90", Offset = "0xD10F90", VA = "0xD10F90")]
	private float GetRandomTime()
	{
		return default(float);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xD10FF4", Offset = "0xD10FF4", VA = "0xD10FF4")]
	private void ShowWhalePrefab()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xD110F0", Offset = "0xD110F0", VA = "0xD110F0")]
	public WhaleAppearanceManager()
	{
	}
}
[Token(Token = "0x200001D")]
public class HomeDoor : MonoBehaviour
{
	[Token(Token = "0x4000075")]
	private const string PlayerTag = "Player";

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform mapPos;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameMenu gameMenu;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x929D78", Offset = "0x929D78", VA = "0x929D78")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x929F08", Offset = "0x929F08", VA = "0x929F08")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x929E50", Offset = "0x929E50", VA = "0x929E50")]
	private void ShowUI()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x929F90", Offset = "0x929F90", VA = "0x929F90")]
	private void HideUI()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x929FBC", Offset = "0x929FBC", VA = "0x929FBC")]
	public HomeDoor()
	{
	}
}
[Token(Token = "0x200001E")]
public class AudioControl : MonoBehaviour
{
	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioSource bgmSource;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string bgmAssetBundle;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float bgmFadeSpeed;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SoundEffect se2D;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SoundEffect3D se3D;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioMixer audioMixer;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private BGM_Control bgmCtrl;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioClip reserve2DClip;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F890", Offset = "0x43F890")]
	private string <BGM_Name>k__BackingField;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F8A0", Offset = "0x43F8A0")]
	private static AudioControl <Instance>k__BackingField;

	[Token(Token = "0x17000009")]
	public bool PlayingBGM
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xD19EE8", Offset = "0xD19EE8", VA = "0xD19EE8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000A")]
	public string BGM_Name
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0xD19F1C", Offset = "0xD19F1C", VA = "0xD19F1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442880", Offset = "0x442880")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0xD19F24", Offset = "0xD19F24", VA = "0xD19F24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442890", Offset = "0x442890")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public static AudioControl Instance
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xD19F2C", Offset = "0xD19F2C", VA = "0xD19F2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4428A0", Offset = "0x4428A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000087")]
		[Address(RVA = "0xD19F78", Offset = "0xD19F78", VA = "0xD19F78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4428B0", Offset = "0x4428B0")]
		private set
		{
		}
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xD19FCC", Offset = "0xD19FCC", VA = "0xD19FCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xD1A104", Offset = "0xD1A104", VA = "0xD1A104")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xD1A108", Offset = "0xD1A108", VA = "0xD1A108")]
	private void Update()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xD1A140", Offset = "0xD1A140", VA = "0xD1A140")]
	private void UpdateBGM(float updateTime = 0f)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xD1A158", Offset = "0xD1A158", VA = "0xD1A158")]
	private void Update2DSE()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xD1A3E4", Offset = "0xD1A3E4", VA = "0xD1A3E4")]
	public void BGM_Load(AudioClip clip)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xD1A418", Offset = "0xD1A418", VA = "0xD1A418")]
	public void BGM_LoadAndPlay(string file, bool sameRestart = false, bool forcePlay = false)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xD1A494", Offset = "0xD1A494", VA = "0xD1A494")]
	public void BGM_Play()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xD1A4C4", Offset = "0xD1A4C4", VA = "0xD1A4C4")]
	public void BGM_Stop()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xD1A4F8", Offset = "0xD1A4F8", VA = "0xD1A4F8")]
	public void Play2DSE(AudioClip clip)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xD12428", Offset = "0xD12428", VA = "0xD12428")]
	public SoundEffect3D Create3DSE(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xD1A500", Offset = "0xD1A500", VA = "0xD1A500")]
	public void SetDecibel_Master(float dB)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xD1A5C8", Offset = "0xD1A5C8", VA = "0xD1A5C8")]
	public void SetDecibel_BGM(float dB)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xD1A690", Offset = "0xD1A690", VA = "0xD1A690")]
	public void SetDecibel_GameSE(float dB)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xD1A758", Offset = "0xD1A758", VA = "0xD1A758")]
	public void SetDecibel_SystemSE(float dB)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xD1A820", Offset = "0xD1A820", VA = "0xD1A820")]
	public AudioControl()
	{
	}
}
[Token(Token = "0x200001F")]
public class BGM_Control
{
	[Token(Token = "0x2000020")]
	private enum COMMAND
	{
		[Token(Token = "0x4000089")]
		NONE,
		[Token(Token = "0x400008A")]
		PLAY,
		[Token(Token = "0x400008B")]
		PAUSE,
		[Token(Token = "0x400008C")]
		STOP,
		[Token(Token = "0x400008D")]
		CHANGE
	}

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AudioSource source;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float fadeVol;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioClip nextClip;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private COMMAND nowCommand;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private COMMAND goalCommand;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float fadeSpeed;

	[Token(Token = "0x1700000C")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0xD19F0C", Offset = "0xD19F0C", VA = "0xD19F0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xD1A090", Offset = "0xD1A090", VA = "0xD1A090")]
	public BGM_Control(AudioSource source)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xD1A29C", Offset = "0xD1A29C", VA = "0xD1A29C")]
	public void Update()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xD1AA10", Offset = "0xD1AA10", VA = "0xD1AA10")]
	private void UpdateVolume()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xD1AAB4", Offset = "0xD1AAB4", VA = "0xD1AAB4")]
	private void GoalVol(ref float goalVol)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xD1A4B4", Offset = "0xD1A4B4", VA = "0xD1A4B4")]
	public void Play(float speed)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xD1AB54", Offset = "0xD1AB54", VA = "0xD1AB54")]
	public void Pause(float speed)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xD1A4E8", Offset = "0xD1A4E8", VA = "0xD1A4E8")]
	public void Stop(float speed)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xD1A40C", Offset = "0xD1A40C", VA = "0xD1A40C")]
	public void ChangeClip(AudioClip clip, float speed)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xD1A8F4", Offset = "0xD1A8F4", VA = "0xD1A8F4")]
	private void Play()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xD1A9F4", Offset = "0xD1A9F4", VA = "0xD1A9F4")]
	private void Pause()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xD1A9D8", Offset = "0xD1A9D8", VA = "0xD1A9D8")]
	private void Stop()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xD1A884", Offset = "0xD1A884", VA = "0xD1A884")]
	private void ChangeClip(AudioClip clip)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xD1AB50", Offset = "0xD1AB50", VA = "0xD1AB50")]
	private float Volume(float vol)
	{
		return default(float);
	}
}
[Token(Token = "0x2000021")]
public class GameControl : MonoBehaviour
{
	[Token(Token = "0x400008E")]
	private const string LanguageDir = "Languages";

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string[] LanguageTypes;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color FadeColor;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float FadeTime;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int TargetFPS;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SceneControl sceneCtrl;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioControl audioCtrl;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float timeScale;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LanguageManager languageMgr;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static GameControl instance;

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x924D48", Offset = "0x924D48", VA = "0x924D48")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x925048", Offset = "0x925048", VA = "0x925048")]
	public void ApplyConfig()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x925060", Offset = "0x925060", VA = "0x925060")]
	private void ApplyAudioConfig()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x92512C", Offset = "0x92512C", VA = "0x92512C")]
	private void ApplyWorldUIConfig()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x925254", Offset = "0x925254", VA = "0x925254")]
	private void ApplyLocomotionConfig()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x925474", Offset = "0x925474", VA = "0x925474")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x925478", Offset = "0x925478", VA = "0x925478")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x92547C", Offset = "0x92547C", VA = "0x92547C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x925494", Offset = "0x925494", VA = "0x925494")]
	public void ChangeScene(string scene, string msg = "", float fadeTime = -1f)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x9254CC", Offset = "0x9254CC", VA = "0x9254CC")]
	public GameControl()
	{
	}
}
[Token(Token = "0x2000022")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43ED8C", Offset = "0x43ED8C")]
internal class SoundEffect : MonoBehaviour
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource audio;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool finishSuside;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float baseVolume;

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xD0BDE4", Offset = "0xD0BDE4", VA = "0xD0BDE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xD0BE40", Offset = "0xD0BE40", VA = "0xD0BE40")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xD0BEE8", Offset = "0xD0BEE8", VA = "0xD0BEE8")]
	public void Play(float vol = 1f, float pitch = 1f)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xD0BF2C", Offset = "0xD0BF2C", VA = "0xD0BF2C")]
	public void Play(AudioClip clip, float vol = 1f, float pitch = 1f)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xD0BEE4", Offset = "0xD0BEE4", VA = "0xD0BEE4")]
	private void Volume()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xD0BF88", Offset = "0xD0BF88", VA = "0xD0BF88")]
	public SoundEffect()
	{
	}
}
[Token(Token = "0x2000023")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43EDEC", Offset = "0x43EDEC")]
public class SoundEffect3D : MonoBehaviour
{
	[Token(Token = "0x2000024")]
	public enum PLAY_OPTION
	{
		[Token(Token = "0x40000A2")]
		LOOP,
		[Token(Token = "0x40000A3")]
		ONE_SHOT,
		[Token(Token = "0x40000A4")]
		NONE
	}

	[Token(Token = "0x2000025")]
	private enum FADE_TYPE
	{
		[Token(Token = "0x40000A6")]
		IN,
		[Token(Token = "0x40000A7")]
		OUT
	}

	[Token(Token = "0x400009B")]
	private const float DefaultHearingDistance = 15f;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource audio;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PLAY_OPTION playOption;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private FADE_TYPE fadeType;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float fadeTime;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float fadeTimeCounter;

	[Token(Token = "0x1700000D")]
	public bool IsPlaying
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xCFE804", Offset = "0xCFE804", VA = "0xCFE804")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xD0BF98", Offset = "0xD0BF98", VA = "0xD0BF98")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xD0BFF4", Offset = "0xD0BFF4", VA = "0xD0BFF4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xD0C0E4", Offset = "0xD0C0E4", VA = "0xD0C0E4")]
	private void Update_FadeIn()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xD0C1DC", Offset = "0xD0C1DC", VA = "0xD0C1DC")]
	private void Update_FadeOut()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xCFEAE4", Offset = "0xCFEAE4", VA = "0xCFEAE4")]
	public void Play(AudioClip clip, PLAY_OPTION playOption = PLAY_OPTION.NONE)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xD0C2E8", Offset = "0xD0C2E8", VA = "0xD0C2E8")]
	public void Play(AudioClip clip, float hearingDistance, PLAY_OPTION playOption = PLAY_OPTION.NONE)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xD04528", Offset = "0xD04528", VA = "0xD04528")]
	public void Stop()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xD0C368", Offset = "0xD0C368", VA = "0xD0C368")]
	public void FadeIn(AudioClip clip, float fadeTime, PLAY_OPTION playOption = PLAY_OPTION.NONE)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xD0C3E8", Offset = "0xD0C3E8", VA = "0xD0C3E8")]
	public void FadeIn(AudioClip clip, float hearingDistance, float fadeTime, PLAY_OPTION playOption = PLAY_OPTION.NONE)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xD0C46C", Offset = "0xD0C46C", VA = "0xD0C46C")]
	public void FadeOut(float fadeTime, bool oneShot = false)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xD04544", Offset = "0xD04544", VA = "0xD04544")]
	public void ChangeVolume(float volume)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xD04590", Offset = "0xD04590", VA = "0xD04590")]
	public void ChangePitch(float pitch)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xD0C484", Offset = "0xD0C484", VA = "0xD0C484")]
	public SoundEffect3D()
	{
	}
}
[Token(Token = "0x2000026")]
public class GameMenu : MonoBehaviour
{
	[Token(Token = "0x2000027")]
	public enum PAGE
	{
		[Token(Token = "0x40000BA")]
		NONE,
		[Token(Token = "0x40000BB")]
		ROOT,
		[Token(Token = "0x40000BC")]
		MAP,
		[Token(Token = "0x40000BD")]
		CONFIG,
		[Token(Token = "0x40000BE")]
		PLAYER_SETTING,
		[Token(Token = "0x40000BF")]
		HELP,
		[Token(Token = "0x40000C0")]
		QUIT
	}

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip openSE;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip changeSE;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip closeSE;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject menuRoot;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button button_map;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button button_config;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Button button_playerSetting;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Button button_help;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Button button_quit;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Button button_close;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private MapMenu map;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ConfigMenu config;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private PlayerSettingMenu playerSetting;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private HelpMenu help;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private QuitMenu quit;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private LanguageTexts languageTexts;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F9C0", Offset = "0x43F9C0")]
	private PAGE <NowPage>k__BackingField;

	[Token(Token = "0x1700000E")]
	public PAGE NowPage
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x925644", Offset = "0x925644", VA = "0x925644")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4428C0", Offset = "0x4428C0")]
		get
		{
			return default(PAGE);
		}
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x92564C", Offset = "0x92564C", VA = "0x92564C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4428D0", Offset = "0x4428D0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public bool IsOpen
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x925654", Offset = "0x925654", VA = "0x925654")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x925678", Offset = "0x925678", VA = "0x925678")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x9258A4", Offset = "0x9258A4", VA = "0x9258A4")]
	public void OpenMenu(Vector3 pos, Quaternion rot)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x925B28", Offset = "0x925B28", VA = "0x925B28")]
	public void OpenMap(Vector3 pos, Quaternion rot)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x925D4C", Offset = "0x925D4C", VA = "0x925D4C")]
	public void CloseMenu(bool playCloseSE = true)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x925FD8", Offset = "0x925FD8", VA = "0x925FD8")]
	private void OnClickMap()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x92608C", Offset = "0x92608C", VA = "0x92608C")]
	private void OnClickConfig()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x926144", Offset = "0x926144", VA = "0x926144")]
	private void OnClickPlayerSetting()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x9261FC", Offset = "0x9261FC", VA = "0x9261FC")]
	private void OnClickHelp()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x926330", Offset = "0x926330", VA = "0x926330")]
	private void OnClickQuit()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x9263E8", Offset = "0x9263E8", VA = "0x9263E8")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x925AA8", Offset = "0x925AA8", VA = "0x925AA8")]
	private void PlaySE_Open()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x9263F0", Offset = "0x9263F0", VA = "0x9263F0")]
	private void PlaySE_Change()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x925E28", Offset = "0x925E28", VA = "0x925E28")]
	private void PlaySE_Close()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x926470", Offset = "0x926470", VA = "0x926470")]
	private void OnClose()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x9259DC", Offset = "0x9259DC", VA = "0x9259DC")]
	private void ApplyLanguage()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x926560", Offset = "0x926560", VA = "0x926560")]
	public GameMenu()
	{
	}
}
[Token(Token = "0x2000028")]
public class QuitMenu : MonoBehaviour
{
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43EE4C", Offset = "0x43EE4C")]
	private sealed class <QuitCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xCCC8B0", Offset = "0xCCC8B0", VA = "0xCCC8B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xCCC8F8", Offset = "0xCCC8F8", VA = "0xCCC8F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xCCC7D8", Offset = "0xCCC7D8", VA = "0xCCC7D8")]
		[DebuggerHidden]
		public <QuitCoroutine>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xCCC804", Offset = "0xCCC804", VA = "0xCCC804", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xCCC808", Offset = "0xCCC808", VA = "0xCCC808", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xCCC8B8", Offset = "0xCCC8B8", VA = "0xCCC8B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C1")]
	private const float QuitDelay = 1.2f;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip chooseSE;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip closeSE;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button button_yes;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button button_no;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private LanguageTexts languageTexts;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action onCloseButton;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xD03B2C", Offset = "0xD03B2C", VA = "0xD03B2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xD03C18", Offset = "0xD03C18", VA = "0xD03C18")]
	public void OpenMenu(Action onCloseButton)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xD03D64", Offset = "0xD03D64", VA = "0xD03D64")]
	public void CloseMenu(bool playCloseSE = true)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xD03E50", Offset = "0xD03E50", VA = "0xD03E50")]
	private void OnClickYes()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xD03F94", Offset = "0xD03F94", VA = "0xD03F94")]
	private void OnClickNo()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xD03EB8", Offset = "0xD03EB8", VA = "0xD03EB8")]
	private void PlaySE_Choose()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xD03DD0", Offset = "0xD03DD0", VA = "0xD03DD0")]
	private void PlaySE_Close()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xD03FC8", Offset = "0xD03FC8", VA = "0xD03FC8")]
	private void OnClose()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xD03C90", Offset = "0xD03C90", VA = "0xD03C90")]
	private void ApplyLanguage()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xD03F38", Offset = "0xD03F38", VA = "0xD03F38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4428E0", Offset = "0x4428E0")]
	private IEnumerator QuitCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xD04004", Offset = "0xD04004", VA = "0xD04004")]
	public QuitMenu()
	{
	}
}
[Token(Token = "0x200002A")]
public static class GamePlayData
{
	[Token(Token = "0x40000CA")]
	private const string SaveKey_CompletedQuests = "CompletedQuests";

	[Token(Token = "0x40000CB")]
	private const string SaveKey_CaughtFishes = "CaughtFishes";

	[Token(Token = "0x40000CC")]
	private const string SaveKey_HarvestedFlowers = "HarvestedFlowers";

	[Token(Token = "0x40000CD")]
	private const string SaveKey_AquariumFishes = "AquariumFishes";

	[Token(Token = "0x40000CE")]
	private const string SaveKey_VaseFlowers = "VaseFlowers";

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static HashSet<FishInfo.Kind> caughtFishes;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static HashSet<FlowerInfo.ID> harvestedFlowers;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static HashSet<AnimalChara.AnimalKind> completedQuests;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static FlowerInfo.ID[] vaseFlowers;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static FishInfo.Kind[] aquariumFishes;

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x926568", Offset = "0x926568", VA = "0x926568")]
	public static void Init()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x926754", Offset = "0x926754", VA = "0x926754")]
	public static void Save()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x924F74", Offset = "0x924F74", VA = "0x924F74")]
	public static void Load()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x927CEC", Offset = "0x927CEC", VA = "0x927CEC")]
	public static bool AchieveCompletedQuest(AnimalChara.AnimalKind animalKind)
	{
		return default(bool);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x92422C", Offset = "0x92422C", VA = "0x92422C")]
	public static bool IsCompletedQuest(AnimalChara.AnimalKind animalKind)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x9267C4", Offset = "0x9267C4", VA = "0x9267C4")]
	private static void SaveCompletedQuests()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x927218", Offset = "0x927218", VA = "0x927218")]
	private static void LoadCompletedQuests()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x927DE0", Offset = "0x927DE0", VA = "0x927DE0")]
	private static bool StringToAnimalKind(string animalName, out AnimalChara.AnimalKind kind)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x927EC0", Offset = "0x927EC0", VA = "0x927EC0")]
	public static bool AchieveFishCapture(FishInfo.Kind fishKind)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x927FB4", Offset = "0x927FB4", VA = "0x927FB4")]
	public static bool IsCaughtFish(FishInfo.Kind fishKind)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x926A20", Offset = "0x926A20", VA = "0x926A20")]
	private static void SaveCaughtFishes()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x927414", Offset = "0x927414", VA = "0x927414")]
	private static void LoadCaughtFishes()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x928040", Offset = "0x928040", VA = "0x928040")]
	private static bool StringToFishKind(string fishName, out FishInfo.Kind kind)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x921204", Offset = "0x921204", VA = "0x921204")]
	public static bool AchieveHarvestedFlower(FlowerInfo.ID flowerID)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x928114", Offset = "0x928114", VA = "0x928114")]
	public static bool IsHarvestedFlower(FlowerInfo.ID flowerID)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x926C7C", Offset = "0x926C7C", VA = "0x926C7C")]
	private static void SaveHarvestedFlowers()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x927610", Offset = "0x927610", VA = "0x927610")]
	private static void LoadHarvestedFlowers()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x9281A0", Offset = "0x9281A0", VA = "0x9281A0")]
	private static bool StringToFlowerID(string flowerName, out FlowerInfo.ID id)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x928274", Offset = "0x928274", VA = "0x928274")]
	public static void RecordAquariumFishes(FishInfo.Kind[] fishes)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x92837C", Offset = "0x92837C", VA = "0x92837C")]
	public static FishInfo.Kind[] InquireAquariumFishes()
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x926ED8", Offset = "0x926ED8", VA = "0x926ED8")]
	private static void SaveAquariumFishes()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x92780C", Offset = "0x92780C", VA = "0x92780C")]
	private static void LoadAquariumFishes()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x928434", Offset = "0x928434", VA = "0x928434")]
	public static void RecordVaseFilowers(FlowerInfo.ID[] flowers)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x92853C", Offset = "0x92853C", VA = "0x92853C")]
	public static FlowerInfo.ID[] InquireVaseFlowers()
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x927078", Offset = "0x927078", VA = "0x927078")]
	private static void SaveVaseFlowers()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x927A7C", Offset = "0x927A7C", VA = "0x927A7C")]
	private static void LoadVaseFlowers()
	{
	}
}
[Token(Token = "0x200002B")]
public class AnimalCarryingGrabbable : BothHandsGrabbableObject
{
	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GrabOffset snapOneHandOffsetL;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GrabOffset snapOneHandOffsetR;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xD329F4", Offset = "0xD329F4", VA = "0xD329F4", Slot = "12")]
	protected override GrabOffset GetGrabOffset(GrabHand hand)
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xD32A60", Offset = "0xD32A60", VA = "0xD32A60")]
	public AnimalCarryingGrabbable()
	{
	}
}
[Token(Token = "0x200002C")]
public class BothHandsGrabbableObject : Grabbable
{
	[Serializable]
	[Token(Token = "0x200002D")]
	public class GrabOffset
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string animation;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xCCBFB8", Offset = "0xCCBFB8", VA = "0xCCBFB8")]
		public GrabOffset()
		{
		}
	}

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected GrabOffset snapBothHandOffsetL;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected GrabOffset snapBothHandOffsetR;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected Vector3 grabRotationOffset;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	protected Vector3 grabPositionOffset;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GrabOffset relativeGrabL;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GrabOffset relativeGrabR;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private OneShotVibrationParameter vibrationParam;

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xD1BCB0", Offset = "0xD1BCB0", VA = "0xD1BCB0", Slot = "8")]
	public override void Grab(GrabHand grabHand)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xD1BEC0", Offset = "0xD1BEC0", VA = "0xD1BEC0")]
	private void SnapGrabOneHand(GrabHand grabHand)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xD1BE24", Offset = "0xD1BE24", VA = "0xD1BE24")]
	private void SnapGrabBothHand(GrabHand grabHand)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xD1BFB4", Offset = "0xD1BFB4", VA = "0xD1BFB4", Slot = "9")]
	public override void Ungrab(GrabHand ungrabHand, Vector3 velocity, Vector3 angularVelocity)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xD1C0F0", Offset = "0xD1C0F0", VA = "0xD1C0F0", Slot = "11")]
	public override void UpdateGrabbing(GrabHand grabber)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xD1C0F4", Offset = "0xD1C0F4", VA = "0xD1C0F4", Slot = "10")]
	public override void ForceUngrab()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xD1C0FC", Offset = "0xD1C0FC", VA = "0xD1C0FC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xD1C138", Offset = "0xD1C138", VA = "0xD1C138")]
	private void Update_BothHands()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xD1C544", Offset = "0xD1C544", VA = "0xD1C544")]
	private Vector3 CalcPos(Vector3 handPosL, Vector3 handPosR)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xD1C564", Offset = "0xD1C564", VA = "0xD1C564", Slot = "12")]
	protected virtual GrabOffset GetGrabOffset(GrabHand hand)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xD1BF5C", Offset = "0xD1BF5C", VA = "0xD1BF5C")]
	private int GetGrabHandAnimation(GrabHand hand)
	{
		return default(int);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xD1C590", Offset = "0xD1C590", VA = "0xD1C590")]
	public BothHandsGrabbableObject()
	{
	}
}
[Token(Token = "0x200002E")]
public class HelpMenu : MonoBehaviour
{
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text controllerNameText;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject controllerImage_OculusTouch;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject controllerImage_Vive;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject controllerImage_Knuckles;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button close;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioClip closeSE;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LanguageTexts languageTexts;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Action onCloseButtonAction;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x9298DC", Offset = "0x9298DC", VA = "0x9298DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x929978", Offset = "0x929978", VA = "0x929978")]
	private void ApplyUIFromData()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x929A10", Offset = "0x929A10", VA = "0x929A10")]
	private void ApplyLanguage()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x9262B0", Offset = "0x9262B0", VA = "0x9262B0")]
	public void OpenMenu([Optional] Action onCloseButtonAction)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x925F14", Offset = "0x925F14", VA = "0x925F14")]
	public void CloseMenu(bool playCloseSE = true)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x92999C", Offset = "0x92999C", VA = "0x92999C")]
	private void ApplyController()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x929B5C", Offset = "0x929B5C", VA = "0x929B5C")]
	private void ApplyController_OculusPlatform()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x929B60", Offset = "0x929B60", VA = "0x929B60")]
	private void ApplyController_OculusTouch()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x929BFC", Offset = "0x929BFC", VA = "0x929BFC")]
	private void ApplyController_ViveController()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x929C98", Offset = "0x929C98", VA = "0x929C98")]
	private void ApplyController_Knuckles()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x929D34", Offset = "0x929D34", VA = "0x929D34")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x929ADC", Offset = "0x929ADC", VA = "0x929ADC")]
	private void PlaySE_Close()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x929D70", Offset = "0x929D70", VA = "0x929D70")]
	public HelpMenu()
	{
	}
}
[Token(Token = "0x200002F")]
public class AnalogueClock : MonoBehaviour
{
	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform hourHand;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform minuteHand;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform secondHand;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 axis;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool isSmoothTicking;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion defHour;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion defMinute;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Quaternion defSecond;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xD25B18", Offset = "0xD25B18", VA = "0xD25B18")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xD25B80", Offset = "0xD25B80", VA = "0xD25B80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xD25D40", Offset = "0xD25D40", VA = "0xD25D40")]
	private float HourAngle(DateTime t)
	{
		return default(float);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xD25DF8", Offset = "0xD25DF8", VA = "0xD25DF8")]
	private float MinuteAngle(DateTime t)
	{
		return default(float);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xD25E8C", Offset = "0xD25E8C", VA = "0xD25E8C")]
	private float SecondAngle(DateTime t)
	{
		return default(float);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xD25F0C", Offset = "0xD25F0C", VA = "0xD25F0C")]
	public AnalogueClock()
	{
	}
}
[Token(Token = "0x2000030")]
public class DartsArrow : MonoBehaviour
{
	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody rigidbody;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Grabbable grabbable;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip stabAudioClip;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private SoundEffect3D stabSE;

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xD21698", Offset = "0xD21698", VA = "0xD21698")]
	private void Start()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xD217DC", Offset = "0xD217DC", VA = "0xD217DC")]
	private void OnGrab(GrabHand hand)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xD217E0", Offset = "0xD217E0", VA = "0xD217E0")]
	private void OnUngrab(GrabHand hand)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xD21824", Offset = "0xD21824", VA = "0xD21824")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xD21988", Offset = "0xD21988", VA = "0xD21988")]
	private void OnCollisionTarget(DartsTarget target)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xD21C04", Offset = "0xD21C04", VA = "0xD21C04")]
	public DartsArrow()
	{
	}
}
[Token(Token = "0x2000031")]
public class DartsTarget : MonoBehaviour
{
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float stabMinDot;

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xD21A90", Offset = "0xD21A90", VA = "0xD21A90")]
	public bool OnCollisionArrow(Vector3 tipPos, Quaternion tipRot, out Vector3 fitPos)
	{
		return default(bool);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xD21C0C", Offset = "0xD21C0C", VA = "0xD21C0C")]
	public DartsTarget()
	{
	}
}
[Token(Token = "0x2000032")]
public abstract class DislikeItem : MonoBehaviour
{
	[Token(Token = "0x600012E")]
	public abstract bool IsAttentional();

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xD2242C", Offset = "0xD2242C", VA = "0xD2242C")]
	protected DislikeItem()
	{
	}
}
[Token(Token = "0x2000033")]
public class Fish : MonoBehaviour
{
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int AnmState_Stay;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int AnmState_Move;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int AnmState_Fishing;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int AnmParam_Turn;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int Field_Layer;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private FishInfo.Kind kind;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool isAlive;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody physic;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Collider collider;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Grabbable grabbable;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3 hookHoldPos;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private Vector3 hookHoldRote;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool grabbedAnmStay;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ParticleAndSound vanishEffect;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool isUnGrabed;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 vanishEffectPos;

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xD24D00", Offset = "0xD24D00", VA = "0xD24D00")]
	private void Start()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xD24EC4", Offset = "0xD24EC4", VA = "0xD24EC4")]
	public void OnGrab(GrabHand hand)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xD24FC4", Offset = "0xD24FC4", VA = "0xD24FC4")]
	private void OnUngrab(GrabHand hand)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xD25008", Offset = "0xD25008", VA = "0xD25008")]
	private void Update()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xD25020", Offset = "0xD25020", VA = "0xD25020")]
	private void Vanish(Vector3 position)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xD25180", Offset = "0xD25180", VA = "0xD25180")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xD25284", Offset = "0xD25284", VA = "0xD25284")]
	public void CaughtFish(Transform parent)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xD253C8", Offset = "0xD253C8", VA = "0xD253C8")]
	public void AchieveFishCapture()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xD25430", Offset = "0xD25430", VA = "0xD25430")]
	public Fish()
	{
	}
}
[Token(Token = "0x2000034")]
public class Fishhook : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000035")]
	public struct InstanceFishTime
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xCCC03C", Offset = "0xCCC03C", VA = "0xCCC03C")]
		public InstanceFishTime(float _min = 1f, float _max = 2f)
		{
		}
	}

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int Water_Layer;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int InvisibleWall_Layer;

	[Token(Token = "0x4000108")]
	private const float Hook_Wind_Speed = 2f;

	[Token(Token = "0x4000109")]
	private const float THROWCHECK_COUNT_UP = 0.05f;

	[Token(Token = "0x400010A")]
	private const float FISHING_LINE_LIMIT_MIN = 0.5f;

	[Token(Token = "0x400010B")]
	private const float FISHING_LINE_LIMIT_MIN_FISH_BITING = 1.8f;

	[Token(Token = "0x400010C")]
	private const float FISHING_LINE_LIMIT_MAX = 25f;

	[Token(Token = "0x400010D")]
	private const float HOOK_THROWN_ANGLE = 0.6f;

	[Token(Token = "0x400010E")]
	private const float HOOK_WINDING_ANGLE = -0.8f;

	[Token(Token = "0x400010F")]
	private const float HOOK_DISTANCE_SE = 20f;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private FishingRod fishingRod;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ConfigurableJoint fishingLinejoint;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private FishingLine fishingLine;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rigidbody physic;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private InstanceFishTime instanceFishTime;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float hookThrowPower;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 beforePlayerPos;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 throwPlayerPos;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 hookCenterOfMass;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private SoftJointLimit fishingLineLimit;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private FishingArea fishingArea;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Fish instanceFish;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform playerEye;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float instanceFishCreateTimeCount;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool isThrownHook;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FC80", Offset = "0x43FC80")]
	private bool <isFishBiting>k__BackingField;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private AudioClip bendRodSE;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private AudioClip throwFishingLineSE;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private AudioClip waterLandingSE;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private AudioClip waterTakeoffSE;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private SoundEffect3D fishRodSE3D;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private SoundEffect3D fishhookSE3D;

	[Token(Token = "0x17000012")]
	public bool isFishBiting
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x91E844", Offset = "0x91E844", VA = "0x91E844")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442990", Offset = "0x442990")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x91E84C", Offset = "0x91E84C", VA = "0x91E84C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4429A0", Offset = "0x4429A0")]
		private set
		{
		}
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x91E858", Offset = "0x91E858", VA = "0x91E858")]
	private void Start()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x91EB20", Offset = "0x91EB20", VA = "0x91EB20")]
	private void Update()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x91EDD4", Offset = "0x91EDD4", VA = "0x91EDD4")]
	private bool IsThrowHook()
	{
		return default(bool);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x91EFB4", Offset = "0x91EFB4", VA = "0x91EFB4")]
	private bool IsRestoreHook()
	{
		return default(bool);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x91EE78", Offset = "0x91EE78", VA = "0x91EE78")]
	private void ThrowHook()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x91F064", Offset = "0x91F064", VA = "0x91F064")]
	private void RestoreHook()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x91F16C", Offset = "0x91F16C", VA = "0x91F16C")]
	private void WindHook()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x91F2B4", Offset = "0x91F2B4", VA = "0x91F2B4")]
	private void InstantiateFish()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x91F424", Offset = "0x91F424", VA = "0x91F424")]
	private void CheckFishBiting()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x91F4E0", Offset = "0x91F4E0", VA = "0x91F4E0")]
	private bool CheckHookFallIsWater(Vector3 hookThrowForce)
	{
		return default(bool);
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x91F98C", Offset = "0x91F98C", VA = "0x91F98C")]
	private void OnCollisionEnter(Collision col)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x91FB70", Offset = "0x91FB70", VA = "0x91FB70")]
	private void OnCollisionExit(Collision col)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x91FC98", Offset = "0x91FC98", VA = "0x91FC98")]
	public Fishhook()
	{
	}
}
[Token(Token = "0x2000036")]
public class FishingArea : MonoBehaviour
{
	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int[] LotterRatios;

	[Token(Token = "0x4000129")]
	private const int FishType_Max = 4;

	[Token(Token = "0x400012A")]
	private const int Default_Fish = 0;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] catchOfFishTypes;

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x91F7E0", Offset = "0x91F7E0", VA = "0x91F7E0")]
	public GameObject LotteryCatchOfFish()
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x91FD74", Offset = "0x91FD74", VA = "0x91FD74")]
	public FishingArea()
	{
	}
}
[Token(Token = "0x2000037")]
public class FishingLine : MonoBehaviour
{
	[Token(Token = "0x400012C")]
	private const float FISHING_LINE_THICKNESS = 0.005f;

	[Token(Token = "0x400012D")]
	private const int FISHING_LINE_ROUNDNESS = 5;

	[Token(Token = "0x400012E")]
	private const int LINE_INTERPOLATION_COUNT = 10;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LineRenderer fishingLine;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform hookPos;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float fishingLineHeightMag;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] lineInterpolationPos;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isHookThrow;

	[Token(Token = "0x17000013")]
	private Vector3 FishingRod_TipPos
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x91FE70", Offset = "0x91FE70", VA = "0x91FE70")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000014")]
	private Vector3 HookPos
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x91FEF8", Offset = "0x91FEF8", VA = "0x91FEF8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x91FF74", Offset = "0x91FF74", VA = "0x91FF74")]
	private void Start()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x920064", Offset = "0x920064", VA = "0x920064")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x9200A0", Offset = "0x9200A0", VA = "0x9200A0")]
	private void SetFishingLineBezier()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x9203A4", Offset = "0x9203A4", VA = "0x9203A4")]
	private Vector3 CalcBezierPoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x920250", Offset = "0x920250", VA = "0x920250")]
	private void SetFishingLineInterpolation()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x920380", Offset = "0x920380", VA = "0x920380")]
	private void SetLineRendererPos()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x920458", Offset = "0x920458", VA = "0x920458")]
	public void SetHookThrow(bool _isHookThrow)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x920464", Offset = "0x920464", VA = "0x920464")]
	public FishingLine()
	{
	}
}
[Token(Token = "0x2000038")]
public class FishingRod : MonoBehaviour
{
	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 Rod_Center_Mass;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int AnmParameter_Bending;

	[Token(Token = "0x4000136")]
	private const float Player_Move_Distance_Threshold = 0.05f;

	[Token(Token = "0x4000137")]
	private const float Vib_Count_Time_Max = 1f;

	[Token(Token = "0x4000138")]
	private const int Buf_Rodtip_Pos_Count = 10;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Collider handleCollider;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform fishingRodTip;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] bufRodTipPos;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Grabbable grabbable;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform playerTrans;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 beforePos;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private VR_Input.SIDE vibGrabHandSide;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float vibCountTime;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool onesVib;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FD50", Offset = "0x43FD50")]
	private float <SwingForce>k__BackingField;

	[Token(Token = "0x17000015")]
	public Vector3 PlayerPos
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x91F298", Offset = "0x91F298", VA = "0x91F298")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000016")]
	public bool IsGrabbed
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x91EDB4", Offset = "0x91EDB4", VA = "0x91EDB4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public float SwingForce
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x9204CC", Offset = "0x9204CC", VA = "0x9204CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4429B0", Offset = "0x4429B0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x9204D4", Offset = "0x9204D4", VA = "0x9204D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4429C0", Offset = "0x4429C0")]
		private set
		{
		}
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x9204DC", Offset = "0x9204DC", VA = "0x9204DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x92068C", Offset = "0x92068C", VA = "0x92068C")]
	private void Update()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x920910", Offset = "0x920910", VA = "0x920910")]
	private void RodSwingForce()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x91F928", Offset = "0x91F928", VA = "0x91F928")]
	public void Vibration()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x920AA4", Offset = "0x920AA4", VA = "0x920AA4")]
	private void AnimationRodBending()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x920B2C", Offset = "0x920B2C", VA = "0x920B2C")]
	private void PushBufRodTipPos()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x920890", Offset = "0x920890", VA = "0x920890")]
	private void ResetBufRodTipPos()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x920BC4", Offset = "0x920BC4", VA = "0x920BC4")]
	private void OnGrab(GrabHand hand)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x920C04", Offset = "0x920C04", VA = "0x920C04")]
	private void OnUngrab(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x920C3C", Offset = "0x920C3C", VA = "0x920C3C")]
	public FishingRod()
	{
	}
}
[Token(Token = "0x2000039")]
public class FoodBagTop : MonoBehaviour
{
	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GrabbableFixture grabbable;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float openDistance;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip openBagSE;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform handTrans;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 startHandPos;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float grabSide;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float openRate;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FDA0", Offset = "0x43FDA0")]
	private bool <IsOpend>k__BackingField;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly int Param_OpenRate;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private SoundEffect3D se3d;

	[Token(Token = "0x17000018")]
	public bool IsOpend
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x922B0C", Offset = "0x922B0C", VA = "0x922B0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4429D0", Offset = "0x4429D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x922B14", Offset = "0x922B14", VA = "0x922B14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4429E0", Offset = "0x4429E0")]
		private set
		{
		}
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x922B20", Offset = "0x922B20", VA = "0x922B20")]
	private void Start()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x922C68", Offset = "0x922C68", VA = "0x922C68")]
	private void Update()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x922CB0", Offset = "0x922CB0", VA = "0x922CB0")]
	private void CheckIsOpen()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x922DA4", Offset = "0x922DA4", VA = "0x922DA4")]
	public void Close()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x922DD4", Offset = "0x922DD4", VA = "0x922DD4")]
	private void OnGrab(GrabHand grabHand)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x922E48", Offset = "0x922E48", VA = "0x922E48")]
	private void OnUngrab(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x922E78", Offset = "0x922E78", VA = "0x922E78")]
	public FoodBagTop()
	{
	}
}
[Token(Token = "0x200003A")]
public class PullTop : MonoBehaviour
{
	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GrabbableFixture grabbable;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float openDistance;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip openCannedSE;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform handTrans;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 startHandPos;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float openRate;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FDF0", Offset = "0x43FDF0")]
	private bool <IsOpend>k__BackingField;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private readonly int Param_OpenRate;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private SoundEffect3D se3d;

	[Token(Token = "0x17000019")]
	public bool IsOpend
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0xD02E34", Offset = "0xD02E34", VA = "0xD02E34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4429F0", Offset = "0x4429F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000171")]
		[Address(RVA = "0xD02E3C", Offset = "0xD02E3C", VA = "0xD02E3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442A00", Offset = "0x442A00")]
		private set
		{
		}
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xD02E48", Offset = "0xD02E48", VA = "0xD02E48")]
	private void Start()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xD02F90", Offset = "0xD02F90", VA = "0xD02F90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xD030BC", Offset = "0xD030BC", VA = "0xD030BC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xD030C0", Offset = "0xD030C0", VA = "0xD030C0")]
	private void OnGrab(GrabHand hand)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xD03110", Offset = "0xD03110", VA = "0xD03110")]
	private void OnUngrab(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xD02FD8", Offset = "0xD02FD8", VA = "0xD02FD8")]
	private void CheckIsOpen()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xD0311C", Offset = "0xD0311C", VA = "0xD0311C")]
	public void Close()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xD0314C", Offset = "0xD0314C", VA = "0xD0314C")]
	public PullTop()
	{
	}
}
[Token(Token = "0x200003B")]
public class ItemPutSE : MonoBehaviour
{
	[Token(Token = "0x4000159")]
	private const float PlayAudio_CollisionVelocity = 0.75f;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip putSE;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SoundEffect3D soundEffect3d;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Grabbable grabbable;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int Field_Layer;

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x92B97C", Offset = "0x92B97C", VA = "0x92B97C")]
	private void Start()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x92BA64", Offset = "0x92BA64", VA = "0x92BA64")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x92BB7C", Offset = "0x92BB7C", VA = "0x92BB7C")]
	public ItemPutSE()
	{
	}
}
[Token(Token = "0x200003C")]
public class Lever : MonoBehaviour
{
	[Token(Token = "0x200003D")]
	public enum AXIS
	{
		[Token(Token = "0x4000167")]
		X,
		[Token(Token = "0x4000168")]
		Y,
		[Token(Token = "0x4000169")]
		Z
	}

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GrabbableFixture grabbable;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AXIS axisType;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform centerPoint;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float minAngle;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float maxAngle;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 axis;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform handTrans;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 prevHandPos;

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x92CD98", Offset = "0x92CD98", VA = "0x92CD98")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x92CEE0", Offset = "0x92CEE0", VA = "0x92CEE0")]
	private void Update()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x92D124", Offset = "0x92D124", VA = "0x92D124")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x92CE84", Offset = "0x92CE84", VA = "0x92CE84")]
	private void SetupAxis()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x92D128", Offset = "0x92D128", VA = "0x92D128")]
	private void OnGrab(GrabHand hand)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x92D178", Offset = "0x92D178", VA = "0x92D178")]
	private void OnUngrab(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x92CF28", Offset = "0x92CF28", VA = "0x92CF28")]
	private void CalcGrabHinge()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x92D184", Offset = "0x92D184", VA = "0x92D184")]
	public Lever()
	{
	}
}
[Token(Token = "0x200003E")]
public class Match : MonoBehaviour
{
	[Token(Token = "0x400016A")]
	private const float Burning_Time_Max = 10f;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Grabbable grabbable;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Collider handleCollider;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ParticleSystem particle;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float burningTime;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private UnityEvent<Match> onSetMatch;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FE90", Offset = "0x43FE90")]
	private bool <Ignition>k__BackingField;

	[Token(Token = "0x1700001A")]
	public bool Ignition
	{
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x9310DC", Offset = "0x9310DC", VA = "0x9310DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442A10", Offset = "0x442A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x9310E4", Offset = "0x9310E4", VA = "0x9310E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442A20", Offset = "0x442A20")]
		private set
		{
		}
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x9310F0", Offset = "0x9310F0", VA = "0x9310F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x9311D4", Offset = "0x9311D4", VA = "0x9311D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x931284", Offset = "0x931284", VA = "0x931284")]
	public void IgnitionMatch()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x9312B4", Offset = "0x9312B4", VA = "0x9312B4")]
	public void SetGrabEnabled(bool enabled)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x93130C", Offset = "0x93130C", VA = "0x93130C")]
	public void AddListner(UnityAction<Match> onSetMatch)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x931384", Offset = "0x931384", VA = "0x931384")]
	private void InstanceMatch()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x931540", Offset = "0x931540", VA = "0x931540")]
	public void OnGrab(GrabHand grabHand)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x931590", Offset = "0x931590", VA = "0x931590")]
	public void OnUngrab(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x931230", Offset = "0x931230", VA = "0x931230")]
	private void ForceUngrab()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x931620", Offset = "0x931620", VA = "0x931620")]
	public Match()
	{
	}
}
[Token(Token = "0x200003F")]
public class MatchCase : MonoBehaviour
{
	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int AnmState_Open;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int AnmState_Close;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int AnmParam_Match;

	[Token(Token = "0x4000174")]
	private const float OpenSpeed = 2f;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Grabbable grabbable;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Match match;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float paramMatch;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool isOpen;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VR_Input.BUTTON openButton;

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xCFD0E8", Offset = "0xCFD0E8", VA = "0xCFD0E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xCFD254", Offset = "0xCFD254", VA = "0xCFD254")]
	private void Update()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xCFD328", Offset = "0xCFD328", VA = "0xCFD328")]
	private void SetFloat()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xCFD3C8", Offset = "0xCFD3C8", VA = "0xCFD3C8")]
	public void OnGrab(GrabHand grabHand)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xCFD3F0", Offset = "0xCFD3F0", VA = "0xCFD3F0")]
	public void OnUngrab(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xCFD418", Offset = "0xCFD418", VA = "0xCFD418")]
	public void OnSetMatch(Match match)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xCFD4EC", Offset = "0xCFD4EC", VA = "0xCFD4EC")]
	public MatchCase()
	{
	}
}
[Token(Token = "0x2000040")]
public class MatchCaseFile : MonoBehaviour
{
	[Token(Token = "0x400017B")]
	private const float Ignition_Distance = 0.03f;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 matchCollPos;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Match match;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isCollMatch;

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xCFD5C0", Offset = "0xCFD5C0", VA = "0xCFD5C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xCFD644", Offset = "0xCFD644", VA = "0xCFD644")]
	private void Ignition()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xCFD660", Offset = "0xCFD660", VA = "0xCFD660")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xCFD744", Offset = "0xCFD744", VA = "0xCFD744")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xCFD864", Offset = "0xCFD864", VA = "0xCFD864")]
	public MatchCaseFile()
	{
	}
}
[Token(Token = "0x2000041")]
public class CarryableStepladder : MonoBehaviour
{
	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GrabbableObject grabbable;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip grabAudioClip;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SoundEffect3D se;

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xD1CED0", Offset = "0xD1CED0", VA = "0xD1CED0")]
	private void Start()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xD1CFDC", Offset = "0xD1CFDC", VA = "0xD1CFDC")]
	private void OnGrab(GrabHand hand)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xD1D004", Offset = "0xD1D004", VA = "0xD1D004")]
	public CarryableStepladder()
	{
	}
}
[Token(Token = "0x2000042")]
public class ClimbableStepladder : MonoBehaviour
{
	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PlayerTeleportPoint stepInPoint;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PlayerTeleportPoint stepOutPoint;

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xD1E130", Offset = "0xD1E130", VA = "0xD1E130")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xD1E248", Offset = "0xD1E248", VA = "0xD1E248")]
	private void OnTeleportStepIn(Player player)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xD1E334", Offset = "0xD1E334", VA = "0xD1E334")]
	private void OnTeleportStepOut(Player player)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xD1E24C", Offset = "0xD1E24C", VA = "0xD1E24C")]
	private void StepInPlayer(VRPlayer player)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xD1E338", Offset = "0xD1E338", VA = "0xD1E338")]
	private void StepOutPlayer(VRPlayer player)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xD1E420", Offset = "0xD1E420", VA = "0xD1E420")]
	private void ChangeTeleportPoint(bool isStepOnPlayer)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xD1E484", Offset = "0xD1E484", VA = "0xD1E484")]
	public ClimbableStepladder()
	{
	}
}
[Token(Token = "0x2000043")]
public class StepladderPoint : MonoBehaviour
{
	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject iconObj;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Collider areaTrigger;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string carryableStepladderName;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClimbableStepladder climbableStepladder;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioClip putSEClip;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private SoundEffect3D putSE;

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xD0C694", Offset = "0xD0C694", VA = "0xD0C694")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xD0C7A0", Offset = "0xD0C7A0", VA = "0xD0C7A0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xD0C808", Offset = "0xD0C808", VA = "0xD0C808")]
	private void PlaceStepladder(GameObject carryableStepladder)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xD0C914", Offset = "0xD0C914", VA = "0xD0C914")]
	public StepladderPoint()
	{
	}
}
[Token(Token = "0x2000044")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43EE5C", Offset = "0x43EE5C")]
public class CameraZoomer : MonoBehaviour
{
	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float zoomSpeed;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float defFOV;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float minFOV;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float maxFOV;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Camera camera;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool zoomResetOnGrab;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Grabbable grabbable;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GrabHand hand;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float startZ;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float startFOV;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43FFC0", Offset = "0x43FFC0")]
	private float <ZoomRate>k__BackingField;

	[Token(Token = "0x1700001B")]
	public float ZoomRate
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xD1C648", Offset = "0xD1C648", VA = "0xD1C648")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442A30", Offset = "0x442A30")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xD1C650", Offset = "0xD1C650", VA = "0xD1C650")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442A40", Offset = "0x442A40")]
		private set
		{
		}
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xD1C658", Offset = "0xD1C658", VA = "0xD1C658")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xD1C7D4", Offset = "0xD1C7D4", VA = "0xD1C7D4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xD1C93C", Offset = "0xD1C93C", VA = "0xD1C93C")]
	private void OnGrab(GrabHand hand)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xD1CA30", Offset = "0xD1CA30", VA = "0xD1CA30")]
	private void OnUngrab(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xD1C790", Offset = "0xD1C790", VA = "0xD1C790")]
	private float CalcZoomRate()
	{
		return default(float);
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xD1CA3C", Offset = "0xD1CA3C", VA = "0xD1CA3C")]
	public void ResetZoom()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xD1CA60", Offset = "0xD1CA60", VA = "0xD1CA60")]
	public CameraZoomer()
	{
	}
}
[Token(Token = "0x2000045")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43EEBC", Offset = "0x43EEBC")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43EEBC", Offset = "0x43EEBC")]
public class PreviewPhotoCamera : MonoBehaviour
{
	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RenderTexture cameraRT;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CameraZoomer zoomer;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GrabbableObject grabbable;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ObjectHunger hunger;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GrabHand grabHand;

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xD021C8", Offset = "0xD021C8", VA = "0xD021C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xD0232C", Offset = "0xD0232C", VA = "0xD0232C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xD02374", Offset = "0xD02374", VA = "0xD02374")]
	private void Update_Grabbed()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xD0247C", Offset = "0xD0247C", VA = "0xD0247C")]
	private void SwitchGrabed(GrabHand hand)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xD024DC", Offset = "0xD024DC", VA = "0xD024DC")]
	private void SwitchHunged(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xD023C8", Offset = "0xD023C8", VA = "0xD023C8")]
	private void ShootPhoto()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xD0269C", Offset = "0xD0269C", VA = "0xD0269C")]
	private string GetSavePath()
	{
		return null;
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xD02540", Offset = "0xD02540", VA = "0xD02540")]
	public static Texture2D RenderTextureToTexture2D(RenderTexture renderTexture, TextureFormat textureFormat = TextureFormat.ARGB32)
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xD02BA4", Offset = "0xD02BA4", VA = "0xD02BA4")]
	public static void ExportPictures(Texture2D tex2D, string path)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xD02CE4", Offset = "0xD02CE4", VA = "0xD02CE4")]
	public static Texture2D ImportPictures(string path)
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xD02E2C", Offset = "0xD02E2C", VA = "0xD02E2C")]
	public PreviewPhotoCamera()
	{
	}
}
[Token(Token = "0x2000046")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43EF50", Offset = "0x43EF50")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x43EF50", Offset = "0x43EF50")]
public class ViewfinderPhotoCamera : MonoBehaviour
{
	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RenderTexture cameraRT;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Camera mainCamera;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject viewfinderCameraRoot;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CameraZoomer zoomer;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Color finderClearColor;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LayerMask finderCullingMask;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string playerHeadCollider;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GrabbableObject grabbable;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ObjectHunger hunger;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GrabHand grabHand;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private CameraClearFlags bkCameraCloearFlags;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Color bkCameraClearColor;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int bkCameraCullingMask;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440060", Offset = "0x440060")]
	private bool <IsLookThroughViewfinder>k__BackingField;

	[Token(Token = "0x1700001C")]
	public bool IsLookThroughViewfinder
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xD0EFA8", Offset = "0xD0EFA8", VA = "0xD0EFA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442A50", Offset = "0x442A50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xD0EFB0", Offset = "0xD0EFB0", VA = "0xD0EFB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442A60", Offset = "0x442A60")]
		private set
		{
		}
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xD0EFBC", Offset = "0xD0EFBC", VA = "0xD0EFBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xD0F120", Offset = "0xD0F120", VA = "0xD0F120")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xD0F174", Offset = "0xD0F174", VA = "0xD0F174")]
	private void Update_Grabbed()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xD0F1A8", Offset = "0xD0F1A8", VA = "0xD0F1A8")]
	private bool CheckShootInput()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xD0F298", Offset = "0xD0F298", VA = "0xD0F298")]
	private void SwitchGrabed(GrabHand hand)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xD0F2F8", Offset = "0xD0F2F8", VA = "0xD0F2F8")]
	private void SwitchHunged(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xD0F1E4", Offset = "0xD0F1E4", VA = "0xD0F1E4")]
	private void ShootPhoto()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xD0F4B8", Offset = "0xD0F4B8", VA = "0xD0F4B8")]
	private string GetSavePath()
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xD0F35C", Offset = "0xD0F35C", VA = "0xD0F35C")]
	public static Texture2D RenderTextureToTexture2D(RenderTexture renderTexture, TextureFormat textureFormat = TextureFormat.ARGB32)
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xD0F9C0", Offset = "0xD0F9C0", VA = "0xD0F9C0")]
	public static void ExportPictures(Texture2D tex2D, string path)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xD0FB00", Offset = "0xD0FB00", VA = "0xD0FB00")]
	public static Texture2D ImportPictures(string path)
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xD0FC48", Offset = "0xD0FC48", VA = "0xD0FC48")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xD0FD8C", Offset = "0xD0FD8C", VA = "0xD0FD8C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xD0FC98", Offset = "0xD0FC98", VA = "0xD0FC98")]
	private void OnTriggerEnter_PlayerHead()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xD0FDDC", Offset = "0xD0FDDC", VA = "0xD0FDDC")]
	private void OnTriggerExit_PlayerHead()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xD0FE5C", Offset = "0xD0FE5C", VA = "0xD0FE5C")]
	public ViewfinderPhotoCamera()
	{
	}
}
[Token(Token = "0x2000047")]
public class ViewfinderZoomHUD : MonoBehaviour
{
	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CameraZoomer zoomer;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform rectTrans;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float minRoll;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float maxRoll;

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xD0FEB8", Offset = "0xD0FEB8", VA = "0xD0FEB8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xD0FF14", Offset = "0xD0FF14", VA = "0xD0FF14")]
	public ViewfinderZoomHUD()
	{
	}
}
[Token(Token = "0x2000048")]
public class RabbitHoleBlockingRock : MonoBehaviour
{
	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private BothHandsGrabbableObject grabbableObj;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject breakEffect;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip breakAudioClip;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject questIcon;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool unGrabed;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action onBreakAction;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private SoundEffect3D breakSE;

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xD0642C", Offset = "0xD0642C", VA = "0xD0642C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xD06564", Offset = "0xD06564", VA = "0xD06564")]
	public void Setup(Action onBreakAction)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xD0656C", Offset = "0xD0656C", VA = "0xD0656C")]
	private void OnGrab(GrabHand hand)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xD065D4", Offset = "0xD065D4", VA = "0xD065D4")]
	private void OnUnGrab(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xD0663C", Offset = "0xD0663C", VA = "0xD0663C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xD06684", Offset = "0xD06684", VA = "0xD06684")]
	private void Break(Vector3 impulse)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xD0682C", Offset = "0xD0682C", VA = "0xD0682C")]
	public RabbitHoleBlockingRock()
	{
	}
}
[Token(Token = "0x2000049")]
public class SnowObstacle : MonoBehaviour
{
	[Token(Token = "0x40001B3")]
	private const string HandColliderName_L = "GrabColliderL";

	[Token(Token = "0x40001B4")]
	private const string HandColliderName_R = "GrabColliderR";

	[Token(Token = "0x40001B5")]
	private const float MaxBlendShape = 100f;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float[] blendShapeValues;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float brushTime;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SkinnedMeshRenderer renderer;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip brushingSEClip;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private OneShotVibrationParameter vibrationParameter;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private SoundEffect3D brushingSE;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int brushNum;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool isBrushing;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float brushingTimer;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool isFinished;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private UnityEvent onFinishedEvent;

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xD0AAB8", Offset = "0xD0AAB8", VA = "0xD0AAB8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xD0AB6C", Offset = "0xD0AB6C", VA = "0xD0AB6C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xD0AB88", Offset = "0xD0AB88", VA = "0xD0AB88")]
	private void Update_Brushing()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xD0AC84", Offset = "0xD0AC84", VA = "0xD0AC84")]
	private void Update_Finished()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xD0AD50", Offset = "0xD0AD50", VA = "0xD0AD50")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xD09A6C", Offset = "0xD09A6C", VA = "0xD09A6C")]
	public void AddListner(UnityAction onFinished)
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xD0AE28", Offset = "0xD0AE28", VA = "0xD0AE28")]
	private void Brush(VR_Input.SIDE handSide)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xD0AD1C", Offset = "0xD0AD1C", VA = "0xD0AD1C")]
	private void Finish()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xD0AEC0", Offset = "0xD0AEC0", VA = "0xD0AEC0")]
	public SnowObstacle()
	{
	}
}
[Token(Token = "0x200004A")]
public class RC_SteeringGrip : GrabbableFixture
{
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform pivot;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform rotator;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float maxAngle;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float prevHandRoll;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float totalGripRoll;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440170", Offset = "0x440170")]
	private float <SteeringRate>k__BackingField;

	[Token(Token = "0x1700001D")]
	public float SteeringRate
	{
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xD0573C", Offset = "0xD0573C", VA = "0xD0573C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442A70", Offset = "0x442A70")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xD05744", Offset = "0xD05744", VA = "0xD05744")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442A80", Offset = "0x442A80")]
		private set
		{
		}
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xD0574C", Offset = "0xD0574C", VA = "0xD0574C", Slot = "8")]
	public override void Grab(GrabHand grabHand)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xD05884", Offset = "0xD05884", VA = "0xD05884", Slot = "9")]
	public override void Ungrab(GrabHand ungrabHand, Vector3 velocity, Vector3 angularVelocity)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xD058F0", Offset = "0xD058F0", VA = "0xD058F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xD0592C", Offset = "0xD0592C", VA = "0xD0592C")]
	private void GrabbedUpdate()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xD05780", Offset = "0xD05780", VA = "0xD05780")]
	private float GetHandRoll()
	{
		return default(float);
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xD058B0", Offset = "0xD058B0", VA = "0xD058B0")]
	private void ApplyVisual()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xD059B4", Offset = "0xD059B4", VA = "0xD059B4")]
	public RC_SteeringGrip()
	{
	}
}
[Token(Token = "0x200004B")]
public class Oar : MonoBehaviour
{
	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GrabbableFixture grip;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform pivot;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float rowingDistance;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform grabController;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 prevRelativePos;

	[Token(Token = "0x1700001E")]
	public bool IsGrabbed
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xCFDA34", Offset = "0xCFDA34", VA = "0xCFDA34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xCFDA54", Offset = "0xCFDA54", VA = "0xCFDA54")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xCFDB38", Offset = "0xCFDB38", VA = "0xCFDB38")]
	public float Update_Rowing()
	{
		return default(float);
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xCFDBB0", Offset = "0xCFDBB0", VA = "0xCFDBB0")]
	private Vector2 RelativeHandPos()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xCFDBF0", Offset = "0xCFDBF0", VA = "0xCFDBF0")]
	private void OnGrip(GrabHand hand)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xCFDC90", Offset = "0xCFDC90", VA = "0xCFDC90")]
	private void OnUngrip(GrabHand ungrabHand)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xCFDC30", Offset = "0xCFDC30", VA = "0xCFDC30")]
	private Transform GetGrabControllerTransform()
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xCFDC94", Offset = "0xCFDC94", VA = "0xCFDC94")]
	public Oar()
	{
	}
}
[Token(Token = "0x200004C")]
public class OarPair : MonoBehaviour
{
	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Oar[] oars;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rowboat boat;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int Anime_Rotation;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int Anime_Stop;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int Param_Rowing;

	[Token(Token = "0x40001D2")]
	private const float BlendTime = 0.5f;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBothGrabbed;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotation;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float rowingAnimationNormalizedTime;

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xCFDCA4", Offset = "0xCFDCA4", VA = "0xCFDCA4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xCFDCC8", Offset = "0xCFDCC8", VA = "0xCFDCC8")]
	private void Update_Grab()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xCFDD18", Offset = "0xCFDD18", VA = "0xCFDD18")]
	private void Update_Row()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xCFDDEC", Offset = "0xCFDDEC", VA = "0xCFDDEC")]
	private bool CheckBothGrabbed()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xCFDF98", Offset = "0xCFDF98", VA = "0xCFDF98")]
	private float BothRowing()
	{
		return default(float);
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xCFDE74", Offset = "0xCFDE74", VA = "0xCFDE74")]
	private void OnGrabBothOars()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xCFDF00", Offset = "0xCFDF00", VA = "0xCFDF00")]
	private void OnUngrabBothOars()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xCFE230", Offset = "0xCFE230", VA = "0xCFE230")]
	public OarPair()
	{
	}
}
[Token(Token = "0x200004D")]
public class Rowboat : MonoBehaviour
{
	[Token(Token = "0x200004E")]
	public enum DIRECTION
	{
		[Token(Token = "0x40001E8")]
		TO_ISLET,
		[Token(Token = "0x40001E9")]
		TO_PIER
	}

	[Token(Token = "0x40001D6")]
	private const float StopRowing = 0.0001f;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform boat;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PlayerTeleportPoint seatPoint;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PlayerTeleportPoint pierExitPoint;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private PlayerTeleportPoint isletExitPoint;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform pierBoatPoint;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform isletBoatPoint;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AudioClip creakBoatSE;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AudioClip rowBoatSE;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isSeated;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private DIRECTION direction;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float moveRate;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private UnityEvent<DIRECTION> onSeatedEvent;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private UnityEvent<DIRECTION> onExitEvent;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private SoundEffect3D se3d;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool isPlayingSE;

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xD07D3C", Offset = "0xD07D3C", VA = "0xD07D3C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xCFE014", Offset = "0xCFE014", VA = "0xCFE014")]
	public void Move(float rowingValue)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xCFE1F4", Offset = "0xCFE1F4", VA = "0xCFE1F4")]
	public void StopRowBoatSE()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xD07FC8", Offset = "0xD07FC8", VA = "0xD07FC8")]
	private void OnSeated(Player player)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xD08068", Offset = "0xD08068", VA = "0xD08068")]
	private void OnPierExit(Player player)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xD080F8", Offset = "0xD080F8", VA = "0xD080F8")]
	private void OnIsletExit(Player player)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xD07F44", Offset = "0xD07F44", VA = "0xD07F44")]
	private void ChangeShowTeleportPoint()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xD07ED4", Offset = "0xD07ED4", VA = "0xD07ED4")]
	private void FixBoat_Pier()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xD081A0", Offset = "0xD081A0", VA = "0xD081A0")]
	private void FixBoat_Islet()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xD08214", Offset = "0xD08214", VA = "0xD08214")]
	public void AddListner(UnityAction<DIRECTION> onSeatedActino, UnityAction<DIRECTION> onExitAction)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xD082B0", Offset = "0xD082B0", VA = "0xD082B0")]
	public void RemoveListner(UnityAction<DIRECTION> onSeatedActino, UnityAction<DIRECTION> onExitAction)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xD0834C", Offset = "0xD0834C", VA = "0xD0834C")]
	public Rowboat()
	{
	}
}
[Token(Token = "0x200004F")]
public class PlayerTeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MainGameScene scene;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float teleportableDistance;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float showStartDistance;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private BillboardRotator textBillboard;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject pointHereText;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject pullTriggerText;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isPointed_L;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isPointed_R;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UnityEvent<Player> onTeleportEvent;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Collider[] colliders;

	[Token(Token = "0x1700001F")]
	private MainGameManager gameManager
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0xD017CC", Offset = "0xD017CC", VA = "0xD017CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xD017E8", Offset = "0xD017E8", VA = "0xD017E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xD01944", Offset = "0xD01944", VA = "0xD01944")]
	private void Update()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xD01DC4", Offset = "0xD01DC4", VA = "0xD01DC4")]
	private void Teleport()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xD01ED0", Offset = "0xD01ED0", VA = "0xD01ED0")]
	public void AddEventListener(UnityAction<Player> onTeleportAction)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xD01F34", Offset = "0xD01F34", VA = "0xD01F34")]
	private void OnStartScene()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xD019CC", Offset = "0xD019CC", VA = "0xD019CC")]
	private float CalcPlayerDistance()
	{
		return default(float);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xD01CA0", Offset = "0xD01CA0", VA = "0xD01CA0")]
	private void UpdateShow(float playerDistance)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xD01F70", Offset = "0xD01F70", VA = "0xD01F70")]
	private float CalcDummyAlpha(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xD01FA0", Offset = "0xD01FA0", VA = "0xD01FA0")]
	private void ApplyMaterialAlpha(Material material, float alpha)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xD01A60", Offset = "0xD01A60", VA = "0xD01A60")]
	private void UpdatePointing(bool isTeleportable)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xD01FE8", Offset = "0xD01FE8", VA = "0xD01FE8")]
	private static Ray TransformToRay(Transform transform)
	{
		return default(Ray);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xD01D6C", Offset = "0xD01D6C", VA = "0xD01D6C")]
	private bool InputTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xD020B4", Offset = "0xD020B4", VA = "0xD020B4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xD02138", Offset = "0xD02138", VA = "0xD02138")]
	public PlayerTeleportPoint()
	{
	}
}
[Token(Token = "0x2000050")]
public class MapMenu : MonoBehaviour
{
	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LanguageTexts languageTexts;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MapSelect[] mapSelects;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button goButton;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button closeButton;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioClip selectSE;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioClip goSE;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioClip closeSE;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int selectedMapNo;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int selectedTimeZoneNo;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string selectedSceneName;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Action onCloseButtonAction;

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x930660", Offset = "0x930660", VA = "0x930660")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x925CD4", Offset = "0x925CD4", VA = "0x925CD4")]
	public void OpenMenu([Optional] Action onCloseButtonAction)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x925EA8", Offset = "0x925EA8", VA = "0x925EA8")]
	public void CloseMenu(bool playCloseSE = true)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x930824", Offset = "0x930824", VA = "0x930824")]
	private void InitMapSelects()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x930B84", Offset = "0x930B84", VA = "0x930B84")]
	public void ChooseMapTimeZone(int mapNo, int timeZoneNo, string selectedSceneName)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x93092C", Offset = "0x93092C", VA = "0x93092C")]
	private void ApplyLanguage()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x930CAC", Offset = "0x930CAC", VA = "0x930CAC")]
	private void OnClickGoButton()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x930E04", Offset = "0x930E04", VA = "0x930E04")]
	private void OnClickCloseButton()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x930C2C", Offset = "0x930C2C", VA = "0x930C2C")]
	private void PlaySE_Select()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x930D84", Offset = "0x930D84", VA = "0x930D84")]
	private void PlaySE_Go()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x9309F8", Offset = "0x9309F8", VA = "0x9309F8")]
	private void PlaySE_Close()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x930E40", Offset = "0x930E40", VA = "0x930E40")]
	public MapMenu()
	{
	}
}
[Token(Token = "0x2000051")]
public class MapSelect : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000052")]
	public class TimeZoneInfo
	{
		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sceneName;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Button button;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image frame;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xCCC704", Offset = "0xCCC704", VA = "0xCCC704")]
		public void SetIsChosen(bool isChosen)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xCCC7A8", Offset = "0xCCC7A8", VA = "0xCCC7A8")]
		public void AddListener(UnityAction onClickButton)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xCCC7D0", Offset = "0xCCC7D0", VA = "0xCCC7D0")]
		public TimeZoneInfo()
		{
		}
	}

	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43EFE4", Offset = "0x43EFE4")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int timeZoneNo;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MapSelect <>4__this;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xCCC6D8", Offset = "0xCCC6D8", VA = "0xCCC6D8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xCCC6E0", Offset = "0xCCC6E0", VA = "0xCCC6E0")]
		internal void <Awake>b__0()
		{
		}
	}

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TimeZoneInfo[] infos;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int mapNo;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UnityAction<int, int, string> onChooseMapTimeZone;

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x930E9C", Offset = "0x930E9C", VA = "0x930E9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x930814", Offset = "0x930814", VA = "0x930814")]
	public void Setup(int mapNo, UnityAction<int, int, string> onChooseMapTimeZone)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x930FD0", Offset = "0x930FD0", VA = "0x930FD0")]
	private void OnClickTimeZoneButton(int timeZoneNo)
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x930B04", Offset = "0x930B04", VA = "0x930B04")]
	public void ChangeChosen(int no)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x930A78", Offset = "0x930A78", VA = "0x930A78")]
	public int CheckTimeZoneBySceneName(string sceneName)
	{
		return default(int);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x931074", Offset = "0x931074", VA = "0x931074")]
	public MapSelect()
	{
	}
}
[Token(Token = "0x2000054")]
public static class PlayerSettingData
{
	[Token(Token = "0x2000055")]
	public enum HandType
	{
		[Token(Token = "0x4000210")]
		A,
		[Token(Token = "0x4000211")]
		B,
		[Token(Token = "0x4000212")]
		C,
		[Token(Token = "0x4000213")]
		Length
	}

	[Token(Token = "0x4000207")]
	private const float HeightOffsetRate = 0.1f;

	[Token(Token = "0x4000208")]
	private const int HeightMin = -20;

	[Token(Token = "0x4000209")]
	private const int HeightMax = 20;

	[Token(Token = "0x400020A")]
	private const int StandingHeightOffset_Def = 0;

	[Token(Token = "0x400020B")]
	private const int CrouchingHeightOffset_Def = -10;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static HandType handType;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int standingHeightOffset;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int crouchingHeightOffset;

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xD00480", Offset = "0xD00480", VA = "0xD00480")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xD00504", Offset = "0xD00504", VA = "0xD00504")]
	public static void Save()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xD005E4", Offset = "0xD005E4", VA = "0xD005E4")]
	public static void Load()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xD006E8", Offset = "0xD006E8", VA = "0xD006E8")]
	public static float GetStandingHeightOffsetMeter()
	{
		return default(float);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xD0075C", Offset = "0xD0075C", VA = "0xD0075C")]
	public static bool IsStandingHeightMax()
	{
		return default(bool);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xD007C8", Offset = "0xD007C8", VA = "0xD007C8")]
	public static bool IsStandingHeightMin()
	{
		return default(bool);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xD00834", Offset = "0xD00834", VA = "0xD00834")]
	public static float GetCrouchingHeightOffsetMeter()
	{
		return default(float);
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xD008A8", Offset = "0xD008A8", VA = "0xD008A8")]
	public static bool IsCrouchingHeightMax()
	{
		return default(bool);
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xD00914", Offset = "0xD00914", VA = "0xD00914")]
	public static bool IsCrouchingHeightMin()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000056")]
public class PlayerSettingMenu : MonoBehaviour
{
	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ToggleGroupEvent handType;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text standingHeightOffsetText;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button standingHeightOffsetUpButton;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button standingHeightOffsetDownButton;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text crouchingHeightOffsetText;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button crouchingHeightOffsetUpButton;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Button crouchingHeightOffsetDownButton;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Button close;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AudioClip toggleSE;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AudioClip closeSE;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private LanguageTexts languageTexts;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Action onCloseButtonAction;

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xD009EC", Offset = "0xD009EC", VA = "0xD009EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xD00E2C", Offset = "0xD00E2C", VA = "0xD00E2C")]
	private void ApplyUIFromData()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xD00F7C", Offset = "0xD00F7C", VA = "0xD00F7C")]
	private void ApplyLanguage()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xD01050", Offset = "0xD01050", VA = "0xD01050")]
	public void OpenMenu([Optional] Action onCloseButtonAction)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xD010C8", Offset = "0xD010C8", VA = "0xD010C8")]
	public void CloseMenu(bool playCloseSE = true)
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xD01208", Offset = "0xD01208", VA = "0xD01208")]
	private void OnChange_HandType(int select)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xD01360", Offset = "0xD01360", VA = "0xD01360")]
	private void OnChange_StandingHeightOffsetUp()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xD01440", Offset = "0xD01440", VA = "0xD01440")]
	private void OnChange_StandingHeightOffsetDown()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xD01520", Offset = "0xD01520", VA = "0xD01520")]
	private void OnChange_CrouchingHeightOffsetUp()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xD01600", Offset = "0xD01600", VA = "0xD01600")]
	private void OnChange_CrouchingHeightOffsetDown()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xD016E0", Offset = "0xD016E0", VA = "0xD016E0")]
	private static string HeightOffsetString(float heightOffsetValue)
	{
		return null;
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xD00C64", Offset = "0xD00C64", VA = "0xD00C64")]
	private void ApplyStandingHeightUI()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xD00D48", Offset = "0xD00D48", VA = "0xD00D48")]
	private void ApplyCrouchingHeightUI()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xD01788", Offset = "0xD01788", VA = "0xD01788")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xD012E0", Offset = "0xD012E0", VA = "0xD012E0")]
	private void PlaySE_Toggle()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xD01188", Offset = "0xD01188", VA = "0xD01188")]
	private void PlaySE_Close()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xD017C4", Offset = "0xD017C4", VA = "0xD017C4")]
	public PlayerSettingMenu()
	{
	}
}
[Token(Token = "0x2000057")]
public class PenguinQuestProgressManager : MonoBehaviour
{
	[Token(Token = "0x2000058")]
	private enum STATE
	{
		[Token(Token = "0x400022B")]
		WAIT_START,
		[Token(Token = "0x400022C")]
		CAN_NOT_GET_DOWN,
		[Token(Token = "0x400022D")]
		CARRIED_TO_WARP,
		[Token(Token = "0x400022E")]
		WARP_TO_FINISH,
		[Token(Token = "0x400022F")]
		FINISHED
	}

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MainGameScene mainGame;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimalChara penguin;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject rope;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject icon;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform finPlayerPos;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform finPenguinPos;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float fadeSpeed;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float fadeWait;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private STATE state;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float waitTimer;

	[Token(Token = "0x17000020")]
	private Player player
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xCFEC4C", Offset = "0xCFEC4C", VA = "0xCFEC4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xCFEC74", Offset = "0xCFEC74", VA = "0xCFEC74")]
	private void Start()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xCFEDA0", Offset = "0xCFEDA0", VA = "0xCFEDA0")]
	private void OnStart()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xCFEDAC", Offset = "0xCFEDAC", VA = "0xCFEDAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xCFEDF4", Offset = "0xCFEDF4", VA = "0xCFEDF4")]
	private void Update_CanNotGetDown()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xCFEEB4", Offset = "0xCFEEB4", VA = "0xCFEEB4")]
	private void Update_CarriedToWarp()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xCFEF58", Offset = "0xCFEF58", VA = "0xCFEF58")]
	private void Update_WarpToFinish()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xCFF034", Offset = "0xCFF034", VA = "0xCFF034")]
	private void Warp()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xCFF224", Offset = "0xCFF224", VA = "0xCFF224")]
	private void Finish()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xCFF28C", Offset = "0xCFF28C", VA = "0xCFF28C")]
	private Vector3 GroundPos(Vector3 startPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xCFF358", Offset = "0xCFF358", VA = "0xCFF358")]
	public PenguinQuestProgressManager()
	{
	}
}
[Token(Token = "0x2000059")]
public class Rabbit02QuestProgressManager : MonoBehaviour
{
	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MainGameScene mainGame;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimalChara rabbit02;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RabbitHoleBlockingRock rock;

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xD062BC", Offset = "0xD062BC", VA = "0xD062BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xD063B8", Offset = "0xD063B8", VA = "0xD063B8")]
	private void OnRemoveObstacle()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xD06424", Offset = "0xD06424", VA = "0xD06424")]
	public Rabbit02QuestProgressManager()
	{
	}
}
[Token(Token = "0x200005A")]
public class Scene : MonoBehaviour
{
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43EFF4", Offset = "0x43EFF4")]
	private sealed class <InSceneCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene <>4__this;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneInMessage;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xCCCDB4", Offset = "0xCCCDB4", VA = "0xCCCDB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xCCCDFC", Offset = "0xCCCDFC", VA = "0xCCCDFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xCCCD2C", Offset = "0xCCCD2C", VA = "0xCCCD2C")]
		[DebuggerHidden]
		public <InSceneCoroutine>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xCCCD58", Offset = "0xCCCD58", VA = "0xCCCD58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xCCCD5C", Offset = "0xCCCD5C", VA = "0xCCCD5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xCCCDBC", Offset = "0xCCCDBC", VA = "0xCCCDBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000233")]
	protected const string gameCtrlResource = "CommonPrefabs/GameControl";

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected string sceneInMessage;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected GameControl gameCtrl;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected UnityEvent onSceneStart;

	[Token(Token = "0x17000021")]
	public GameControl GC
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xD08404", Offset = "0xD08404", VA = "0xD08404")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xD0840C", Offset = "0xD0840C", VA = "0xD0840C", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xD08638", Offset = "0xD08638", VA = "0xD08638")]
	protected void InScene(string sceneInMessage)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xD0873C", Offset = "0xD0873C", VA = "0xD0873C", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x442A90", Offset = "0x442A90")]
	public virtual IEnumerator InSceneCoroutine(string sceneInMessage)
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xD087D0", Offset = "0xD087D0", VA = "0xD087D0", Slot = "6")]
	public virtual void OutScene(string next)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xD08524", Offset = "0xD08524", VA = "0xD08524")]
	public void CreateGameControl()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xD03350", Offset = "0xD03350", VA = "0xD03350")]
	public void AddSceneStartListner(UnityAction action)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xD087D4", Offset = "0xD087D4", VA = "0xD087D4")]
	public Scene()
	{
	}
}
[Token(Token = "0x200005C")]
public class SceneControl
{
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F004", Offset = "0x43F004")]
	private sealed class <OnStartNextScene>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneControl <>4__this;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xCCCF90", Offset = "0xCCCF90", VA = "0xCCCF90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0xCCCFD8", Offset = "0xCCCFD8", VA = "0xCCCFD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xCCCE04", Offset = "0xCCCE04", VA = "0xCCCE04")]
		[DebuggerHidden]
		public <OnStartNextScene>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xCCCE30", Offset = "0xCCCE30", VA = "0xCCCE30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xCCCE34", Offset = "0xCCCE34", VA = "0xCCCE34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xCCCF98", Offset = "0xCCCF98", VA = "0xCCCF98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Scene nowScene;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string nextSceneMessage;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4404B0", Offset = "0x4404B0")]
	private string <NowSceneName>k__BackingField;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4404C0", Offset = "0x4404C0")]
	private string <PrevSceneName>k__BackingField;

	[Token(Token = "0x17000024")]
	public string NowSceneName
	{
		[Token(Token = "0x6000267")]
		[Address(RVA = "0xD08868", Offset = "0xD08868", VA = "0xD08868")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442B40", Offset = "0x442B40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xD08870", Offset = "0xD08870", VA = "0xD08870")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442B50", Offset = "0x442B50")]
		private set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public string PrevSceneName
	{
		[Token(Token = "0x6000269")]
		[Address(RVA = "0xD08878", Offset = "0xD08878", VA = "0xD08878")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442B60", Offset = "0x442B60")]
		get
		{
			return null;
		}
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xD08880", Offset = "0xD08880", VA = "0xD08880")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442B70", Offset = "0x442B70")]
		private set
		{
		}
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xD08888", Offset = "0xD08888", VA = "0xD08888")]
	public SceneControl()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xD08948", Offset = "0xD08948", VA = "0xD08948")]
	public void Change(string sceneName, string nextSceneMessage, Color color, float fadeTime)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xD08594", Offset = "0xD08594", VA = "0xD08594")]
	public void FirstStartScene(Scene scene)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xD08FE8", Offset = "0xD08FE8", VA = "0xD08FE8")]
	private void OnFinishPrevScene()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xD08B88", Offset = "0xD08B88", VA = "0xD08B88")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x442B80", Offset = "0x442B80")]
	private IEnumerator OnStartNextScene()
	{
		return null;
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xD09008", Offset = "0xD09008", VA = "0xD09008")]
	public bool IsTransitioning()
	{
		return default(bool);
	}
}
[Token(Token = "0x200005E")]
public class SceneTransition : MonoBehaviour
{
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F014", Offset = "0x43F014")]
	private sealed class <TransitionCoroutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneTransition <>4__this;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onEndPrevScene;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string nextSceneName;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IEnumerator onStartNextScene;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action onFinishTransition;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float <fadeSpeed>5__2;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private ThreadPriority <bkLoadingPriority>5__3;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AsyncOperation <ao>5__4;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0xCCD664", Offset = "0xCCD664", VA = "0xCCD664", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0xCCD6AC", Offset = "0xCCD6AC", VA = "0xCCD6AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xCCD2A0", Offset = "0xCCD2A0", VA = "0xCCD2A0")]
		[DebuggerHidden]
		public <TransitionCoroutine>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xCCD2CC", Offset = "0xCCD2CC", VA = "0xCCD2CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xCCD2D0", Offset = "0xCCD2D0", VA = "0xCCD2D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xCCD66C", Offset = "0xCCD66C", VA = "0xCCD66C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F024", Offset = "0x43F024")]
	private sealed class <FadeIn>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeSpeed;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SceneTransition <>4__this;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool changeAudio;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <alpha>5__2;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xCCD0F0", Offset = "0xCCD0F0", VA = "0xCCD0F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xCCD138", Offset = "0xCCD138", VA = "0xCCD138", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xCCCFE0", Offset = "0xCCCFE0", VA = "0xCCCFE0")]
		[DebuggerHidden]
		public <FadeIn>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xCCD00C", Offset = "0xCCD00C", VA = "0xCCD00C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xCCD010", Offset = "0xCCD010", VA = "0xCCD010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xCCD0F8", Offset = "0xCCD0F8", VA = "0xCCD0F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F034", Offset = "0x43F034")]
	private sealed class <FadeOut>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeSpeed;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SceneTransition <>4__this;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool changeAudio;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <alpha>5__2;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0xCCD250", Offset = "0xCCD250", VA = "0xCCD250", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0xCCD298", Offset = "0xCCD298", VA = "0xCCD298", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xCCD140", Offset = "0xCCD140", VA = "0xCCD140")]
		[DebuggerHidden]
		public <FadeOut>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xCCD16C", Offset = "0xCCD16C", VA = "0xCCD16C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xCCD170", Offset = "0xCCD170", VA = "0xCCD170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xCCD258", Offset = "0xCCD258", VA = "0xCCD258", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera nowLoadingCamera;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private EyeFader fader;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LayerMask fadingCameraCulling;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private LayerMask nowloadingCameraCulling;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CameraClearFlags nowloadingCameraClearFlags;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform loadingObjectRoot;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float loadingObjectDistance;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image loadingGage;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool fixedLoadingObj;

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xD090A4", Offset = "0xD090A4", VA = "0xD090A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xD092F0", Offset = "0xD092F0", VA = "0xD092F0")]
	public void TransitionAsync(string nextSceneName, Color fadeColor, float fadeTime, Action onEndPrevScene, IEnumerator onStartNextScene, Action onFinishTransition)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xD093AC", Offset = "0xD093AC", VA = "0xD093AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x442C30", Offset = "0x442C30")]
	private IEnumerator TransitionCoroutine(string nextSceneName, Color fadeColor, float fadeTime, Action onEndPrevScene, IEnumerator onStartNextScene, Action onFinishTransition)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xD09494", Offset = "0xD09494", VA = "0xD09494")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x442C90", Offset = "0x442C90")]
	private IEnumerator FadeIn(float fadeSpeed, bool changeAudio)
	{
		return null;
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xD09530", Offset = "0xD09530", VA = "0xD09530")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x442CF0", Offset = "0x442CF0")]
	private IEnumerator FadeOut(float fadeSpeed, bool changeAudio)
	{
		return null;
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xD09390", Offset = "0xD09390", VA = "0xD09390")]
	private void ApplyFadeColor(Color fadeColor)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xD09158", Offset = "0xD09158", VA = "0xD09158")]
	private void ChangeFadeAlpha(float alpha)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xD09174", Offset = "0xD09174", VA = "0xD09174")]
	private void FixLoadingObjectPosition()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xD095CC", Offset = "0xD095CC", VA = "0xD095CC")]
	private void AudioFade(float rate)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xD096F4", Offset = "0xD096F4", VA = "0xD096F4")]
	public SceneTransition()
	{
	}
}
[Token(Token = "0x2000062")]
public static class SceneTransitionManager
{
	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string resourcePath;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static SceneTransition instance;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440550", Offset = "0x440550")]
	private static bool <IsTransitioning>k__BackingField;

	[Token(Token = "0x1700002E")]
	public static bool IsTransitioning
	{
		[Token(Token = "0x6000293")]
		[Address(RVA = "0xD0970C", Offset = "0xD0970C", VA = "0xD0970C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442E40", Offset = "0x442E40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000294")]
		[Address(RVA = "0xD09770", Offset = "0xD09770", VA = "0xD09770")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442E50", Offset = "0x442E50")]
		private set
		{
		}
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xD08C00", Offset = "0xD08C00", VA = "0xD08C00")]
	public static void StartTransitionAsync(string nextSceneName, Color fadeColor, float fadeTime, Action onEndPrevScene, IEnumerator onStartNextScene)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xD097DC", Offset = "0xD097DC", VA = "0xD097DC")]
	public static void OnFinishTransition()
	{
	}
}
[Token(Token = "0x2000063")]
public class VRScene : Scene
{
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F044", Offset = "0x43F044")]
	private sealed class <InSceneCoroutine>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRScene <>4__this;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneInMessage;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xCCDCD4", Offset = "0xCCDCD4", VA = "0xCCDCD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xCCDD1C", Offset = "0xCCDD1C", VA = "0xCCDD1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xCCDBF8", Offset = "0xCCDBF8", VA = "0xCCDBF8")]
		[DebuggerHidden]
		public <InSceneCoroutine>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xCCDC24", Offset = "0xCCDC24", VA = "0xCCDC24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xCCDC28", Offset = "0xCCDC28", VA = "0xCCDC28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xCCDCDC", Offset = "0xCCDCDC", VA = "0xCCDCDC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F054", Offset = "0x43F054")]
	private sealed class <WaitInitializeVRCoroutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0xCCDE24", Offset = "0xCCDE24", VA = "0xCCDE24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xCCDE6C", Offset = "0xCCDE6C", VA = "0xCCDE6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xCCDD24", Offset = "0xCCDD24", VA = "0xCCDD24")]
		[DebuggerHidden]
		public <WaitInitializeVRCoroutine>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xCCDD50", Offset = "0xCCDD50", VA = "0xCCDD50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xCCDD54", Offset = "0xCCDD54", VA = "0xCCDD54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xCCDE2C", Offset = "0xCCDE2C", VA = "0xCCDE2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xD0EE10", Offset = "0xD0EE10", VA = "0xD0EE10", Slot = "5")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x442E60", Offset = "0x442E60")]
	public override IEnumerator InSceneCoroutine(string sceneInMessage)
	{
		return null;
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xD0EEA4", Offset = "0xD0EEA4", VA = "0xD0EEA4", Slot = "7")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x442EC0", Offset = "0x442EC0")]
	protected virtual IEnumerator WaitInitializeVRCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xD0EF00", Offset = "0xD0EF00", VA = "0xD0EF00", Slot = "6")]
	public override void OutScene(string next)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xD0D4DC", Offset = "0xD0D4DC", VA = "0xD0D4DC")]
	public VRScene()
	{
	}
}
[Token(Token = "0x2000066")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x43F064", Offset = "0x43F064")]
public class LimbsSoundScriptableObject : ScriptableObject
{
	[Token(Token = "0x2000067")]
	public enum Sound
	{
		[Token(Token = "0x4000271")]
		Work,
		[Token(Token = "0x4000272")]
		Run,
		[Token(Token = "0x4000273")]
		Grooming,
		[Token(Token = "0x4000274")]
		Flapping,
		[Token(Token = "0x4000275")]
		Digging
	}

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip work;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip run;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip grooming;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip flapping;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioClip digging;

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x92D7A8", Offset = "0x92D7A8", VA = "0x92D7A8")]
	public AudioClip GetAudioClip(Sound sound)
	{
		return null;
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x92D7FC", Offset = "0x92D7FC", VA = "0x92D7FC")]
	public LimbsSoundScriptableObject()
	{
	}
}
[Token(Token = "0x2000068")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x43F0C4", Offset = "0x43F0C4")]
public class MouthSoundScriptableObject : ScriptableObject
{
	[Token(Token = "0x2000069")]
	public enum Sound
	{
		[Token(Token = "0x400027B")]
		Normal,
		[Token(Token = "0x400027C")]
		Joy,
		[Token(Token = "0x400027D")]
		Like,
		[Token(Token = "0x400027E")]
		Sleep
	}

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioClip bark_normal;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip bark_joy;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bark_like;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip sleep;

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xCFD898", Offset = "0xCFD898", VA = "0xCFD898")]
	public AudioClip GetAudioClip(Sound sound)
	{
		return null;
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xCFD8E4", Offset = "0xCFD8E4", VA = "0xCFD8E4")]
	public MouthSoundScriptableObject()
	{
	}
}
[Token(Token = "0x200006A")]
public class SegmentSoundPositioner : MonoBehaviour
{
	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform segmentPointA;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform segmentPointB;

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xD0A7B0", Offset = "0xD0A7B0", VA = "0xD0A7B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xD0A8FC", Offset = "0xD0A8FC", VA = "0xD0A8FC")]
	public static void ClosestPointPointAndSegment(Vector3 point, Vector3 segmentStart, Vector3 segmentEnd, out float t, out Vector3 pos)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xD0A990", Offset = "0xD0A990", VA = "0xD0A990")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xD0AAB0", Offset = "0xD0AAB0", VA = "0xD0AAB0")]
	public SegmentSoundPositioner()
	{
	}
}
[Token(Token = "0x200006B")]
public class TitleScene : VRScene
{
	[Token(Token = "0x200006C")]
	private enum SE
	{
		[Token(Token = "0x4000293")]
		MENU,
		[Token(Token = "0x4000294")]
		CHOICE
	}

	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F124", Offset = "0x43F124")]
	private sealed class <LogoCoroutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TitleScene <>4__this;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <fadeSpeed>5__2;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xCCD90C", Offset = "0xCCD90C", VA = "0xCCD90C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xCCD954", Offset = "0xCCD954", VA = "0xCCD954", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xCCD6B4", Offset = "0xCCD6B4", VA = "0xCCD6B4")]
		[DebuggerHidden]
		public <LogoCoroutine>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xCCD6E0", Offset = "0xCCD6E0", VA = "0xCCD6E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xCCD6E4", Offset = "0xCCD6E4", VA = "0xCCD6E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xCCD914", Offset = "0xCCD914", VA = "0xCCD914", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F134", Offset = "0x43F134")]
	private sealed class <ShowTitleCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TitleScene <>4__this;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <fadeSpeed>5__2;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xCCDAE0", Offset = "0xCCDAE0", VA = "0xCCDAE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xCCDB28", Offset = "0xCCDB28", VA = "0xCCDB28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xCCD95C", Offset = "0xCCD95C", VA = "0xCCD95C")]
		[DebuggerHidden]
		public <ShowTitleCoroutine>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xCCD988", Offset = "0xCCD988", VA = "0xCCD988", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xCCD98C", Offset = "0xCCD98C", VA = "0xCCD98C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xCCDAE8", Offset = "0xCCDAE8", VA = "0xCCDAE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CanvasGroup brandGroup;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private CanvasGroup titleGroup;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float brandTime;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float fadeTime;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Button startButton;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Button configButton;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Button playerSettingButton;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Button helpButton;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Button exitButton;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AudioClip bgmClip;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private AudioClip se_menu;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private AudioClip se_choice;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private ConfigMenu configMenu;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private PlayerSettingMenu playerSettingMenu;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private HelpMenu helpMenu;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Material skyboxMaterial;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private string gameSceneName;

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xD0CAC4", Offset = "0xD0CAC4", VA = "0xD0CAC4", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xD0CE5C", Offset = "0xD0CE5C", VA = "0xD0CE5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x442FC0", Offset = "0x442FC0")]
	private IEnumerator LogoCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xD0CDE4", Offset = "0xD0CDE4", VA = "0xD0CDE4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x443020", Offset = "0x443020")]
	private IEnumerator ShowTitleCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xD0CD9C", Offset = "0xD0CD9C", VA = "0xD0CD9C")]
	private void SetEnableTitleGroup(bool enable)
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xD0CED4", Offset = "0xD0CED4", VA = "0xD0CED4")]
	private void PlaySE(SE se)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xD0CF30", Offset = "0xD0CF30", VA = "0xD0CF30")]
	private void OnSceneStart()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xD0D0B8", Offset = "0xD0D0B8", VA = "0xD0D0B8")]
	private void FixPlayerYaw()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xD0CFBC", Offset = "0xD0CFBC", VA = "0xD0CFBC")]
	private void ApplyStartPlayerSetting()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xD0D190", Offset = "0xD0D190", VA = "0xD0D190")]
	private void OnClickStartButton()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xD0D22C", Offset = "0xD0D22C", VA = "0xD0D22C")]
	private void OnClickConfigButton()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xD0D2D8", Offset = "0xD0D2D8", VA = "0xD0D2D8")]
	private void OnClickPlayerSettingButton()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xD0D380", Offset = "0xD0D380", VA = "0xD0D380")]
	private void OnClickHelpButton()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xD0D42C", Offset = "0xD0D42C", VA = "0xD0D42C")]
	private void OnCloseMenu()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xD0D434", Offset = "0xD0D434", VA = "0xD0D434")]
	private void OnClickExitButton()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xD0D47C", Offset = "0xD0D47C", VA = "0xD0D47C")]
	public TitleScene()
	{
	}
}
[Token(Token = "0x200006F")]
public class ToggleGroupEvent : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000070")]
	public class ToggleSelectEvent : UnityEvent<int>
	{
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xCCDB30", Offset = "0xCCDB30", VA = "0xCCDB30")]
		public ToggleSelectEvent()
		{
		}
	}

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ToggleSelectEvent selEvent;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Toggle[] toggles;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isChange;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool invoke;

	[Token(Token = "0x17000037")]
	public Toggle[] Toggles
	{
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xD0D4E0", Offset = "0xD0D4E0", VA = "0xD0D4E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xD0D4E8", Offset = "0xD0D4E8", VA = "0xD0D4E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xD0D5FC", Offset = "0xD0D5FC", VA = "0xD0D5FC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xD0D6B8", Offset = "0xD0D6B8", VA = "0xD0D6B8")]
	public void OnChange(bool flag)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xD0D6CC", Offset = "0xD0D6CC", VA = "0xD0D6CC")]
	public void SetToggles(Toggle[] toggles)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xD0D7FC", Offset = "0xD0D7FC", VA = "0xD0D7FC")]
	public void DestroyToggles()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xD00EC8", Offset = "0xD00EC8", VA = "0xD00EC8")]
	public void SetOn(int id, bool invoke)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xD0D8C4", Offset = "0xD0D8C4", VA = "0xD0D8C4")]
	public ToggleGroupEvent()
	{
	}
}
[Token(Token = "0x2000071")]
public class TouchButton : MonoBehaviour
{
	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string colliderNameL;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string colliderNameR;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private UnityEvent<VR_Input.SIDE> onTouchEvent;

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xD05B34", Offset = "0xD05B34", VA = "0xD05B34")]
	public void AddListener(UnityAction<VR_Input.SIDE> onTouchAction)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xD0D8D4", Offset = "0xD0D8D4", VA = "0xD0D8D4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xD0D9B8", Offset = "0xD0D9B8", VA = "0xD0D9B8")]
	public TouchButton()
	{
	}
}
[Token(Token = "0x2000072")]
public class DebugIsGrounded : MonoBehaviour
{
	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private VRScene scene;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CharacterController charaCtrl;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text text;

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xD21C1C", Offset = "0xD21C1C", VA = "0xD21C1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xD21CB0", Offset = "0xD21CB0", VA = "0xD21CB0")]
	public void Init()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xD21D38", Offset = "0xD21D38", VA = "0xD21D38")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xD21E18", Offset = "0xD21E18", VA = "0xD21E18")]
	public DebugIsGrounded()
	{
	}
}
[Token(Token = "0x2000073")]
public class CollisionDebugBullet : MonoBehaviour
{
	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody rigidbody;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float lifeTime;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float lifeTimer;

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xD1F318", Offset = "0xD1F318", VA = "0xD1F318")]
	public void Fire(Vector3 pos, Quaternion rot)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xD1F414", Offset = "0xD1F414", VA = "0xD1F414")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xD1F4C0", Offset = "0xD1F4C0", VA = "0xD1F4C0")]
	public CollisionDebugBullet()
	{
	}
}
[Token(Token = "0x2000074")]
public class DebugRifle : MonoBehaviour
{
	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform muzzle;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Grabbable grabbable;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CollisionDebugBullet bulletOriginal;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float fireSpan;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float fireTimer;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GrabHand grabHand;

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xD21E20", Offset = "0xD21E20", VA = "0xD21E20")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xD21F04", Offset = "0xD21F04", VA = "0xD21F04")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xD21FF8", Offset = "0xD21FF8", VA = "0xD21FF8")]
	private void UpdateTrigger()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xD22190", Offset = "0xD22190", VA = "0xD22190")]
	private void OnGrab(GrabHand hand)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xD22198", Offset = "0xD22198", VA = "0xD22198")]
	private void OnUngrab(GrabHand hand)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xD221A4", Offset = "0xD221A4", VA = "0xD221A4")]
	public DebugRifle()
	{
	}
}
[Token(Token = "0x2000075")]
public class FieldDebug : MonoBehaviour
{
	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Light[] lights;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem[] particles;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool enableLight;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool enableParticle;

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xD23F78", Offset = "0xD23F78", VA = "0xD23F78")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xD24508", Offset = "0xD24508", VA = "0xD24508")]
	private void SetupHz()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xD24030", Offset = "0xD24030", VA = "0xD24030")]
	private void PickupMaterials()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xD24740", Offset = "0xD24740", VA = "0xD24740")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xD248A4", Offset = "0xD248A4", VA = "0xD248A4")]
	public FieldDebug()
	{
	}
}
[Token(Token = "0x2000076")]
public class UITestScene : VRScene
{
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xD0ED48", Offset = "0xD0ED48", VA = "0xD0ED48", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xD0EDE4", Offset = "0xD0EDE4", VA = "0xD0EDE4")]
	private void Init()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xD0EE0C", Offset = "0xD0EE0C", VA = "0xD0EE0C")]
	public UITestScene()
	{
	}
}
[Token(Token = "0x2000077")]
public class VersionNumber : MonoBehaviour
{
	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text versionText;

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xD0EF28", Offset = "0xD0EF28", VA = "0xD0EF28")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xD0EFA0", Offset = "0xD0EFA0", VA = "0xD0EFA0")]
	public VersionNumber()
	{
	}
}
[Token(Token = "0x2000078")]
public class mParent : MonoBehaviour
{
	[Token(Token = "0x2000079")]
	private enum Mode
	{
		[Token(Token = "0x40002B9")]
		Idle,
		[Token(Token = "0x40002BA")]
		Ground,
		[Token(Token = "0x40002BB")]
		Hand,
		[Token(Token = "0x40002BC")]
		Back
	}

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject mParentCon;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mode m_Mode;

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xD11620", Offset = "0xD11620", VA = "0xD11620")]
	public void Update()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xD11768", Offset = "0xD11768", VA = "0xD11768")]
	public void Start()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xD117E8", Offset = "0xD117E8", VA = "0xD117E8")]
	public void hand()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xD11868", Offset = "0xD11868", VA = "0xD11868")]
	public void back()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xD118E8", Offset = "0xD118E8", VA = "0xD118E8")]
	public mParent()
	{
	}
}
[Token(Token = "0x200007A")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200007B")]
	public class Section
	{
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xCCC908", Offset = "0xCCC908", VA = "0xCCC908")]
		public Section()
		{
		}
	}

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xD06834", Offset = "0xD06834", VA = "0xD06834")]
	public Readme()
	{
	}
}
namespace SettingScene
{
	[Token(Token = "0x200007C")]
	public class AnimalCarryingGrabbableSetting : MonoBehaviour
	{
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xD32A68", Offset = "0xD32A68", VA = "0xD32A68")]
		public AnimalCarryingGrabbableSetting()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class AnimalSetting : MonoBehaviour
	{
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xD17E14", Offset = "0xD17E14", VA = "0xD17E14")]
		public AnimalSetting()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class BothHandsGrabbableSetting : MonoBehaviour
	{
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xD1C640", Offset = "0xD1C640", VA = "0xD1C640")]
		public BothHandsGrabbableSetting()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class GrabbableFixtureSetting : MonoBehaviour
	{
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x928790", Offset = "0x928790", VA = "0x928790")]
		public GrabbableFixtureSetting()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class GrabbableObjectSetting : MonoBehaviour
	{
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x928798", Offset = "0x928798", VA = "0x928798")]
		public GrabbableObjectSetting()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class HandPoseSetting : MonoBehaviour
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextAsset boneListText_L;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextAsset boneListText_R;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator animator_L;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator animator_R;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<string> boneList_L;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<string> boneList_R;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, Quaternion> boneDefRots_L;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, Quaternion> boneDefRots_R;

		[Token(Token = "0x17000038")]
		public bool IsSetuped
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x928FF0", Offset = "0x928FF0", VA = "0x928FF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x929070", Offset = "0x929070", VA = "0x929070")]
		public void Setup()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x929530", Offset = "0x929530", VA = "0x929530")]
		private void Clear()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x9290F0", Offset = "0x9290F0", VA = "0x9290F0")]
		private static List<string> LoadList(TextAsset text)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x92920C", Offset = "0x92920C", VA = "0x92920C")]
		private static Dictionary<string, Quaternion> SetupDefRot(Animator animator, List<string> list)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x9295C8", Offset = "0x9295C8", VA = "0x9295C8")]
		public void ResetPose()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x929600", Offset = "0x929600", VA = "0x929600")]
		private static void ResetPose(Animator animator, List<string> boneList, Dictionary<string, Quaternion> boneDefRots)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x9297BC", Offset = "0x9297BC", VA = "0x9297BC")]
		public HandPoseSetting()
		{
		}
	}
}
namespace Language
{
	[Token(Token = "0x2000082")]
	public class LanguageInfo
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string directoryName;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string englishName;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string localName;

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x92BB8C", Offset = "0x92BB8C", VA = "0x92BB8C")]
		public LanguageInfo(string directoryName, string englishName, string localName)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x92BBF0", Offset = "0x92BBF0", VA = "0x92BBF0")]
		public LanguageInfo(string directoryName)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x92BCDC", Offset = "0x92BCDC", VA = "0x92BCDC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	public abstract class LanguageManager
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected List<LanguageInfo> languages;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected SystemLanguage systemLanguage;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected LanguageInfo currentLanguage;

		[Token(Token = "0x17000039")]
		public LanguageInfo CurrentLanguage
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x92BCE4", Offset = "0x92BCE4", VA = "0x92BCE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x92BCEC", Offset = "0x92BCEC", VA = "0x92BCEC")]
		protected void CheckSystemLanguage()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x92BD20", Offset = "0x92BD20", VA = "0x92BD20")]
		protected void SetupDefaultLanguage()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x92BF18", Offset = "0x92BF18", VA = "0x92BF18")]
		public LanguageInfo[] GetLanguageList()
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x926478", Offset = "0x926478", VA = "0x926478")]
		public void ChangeLanguage(int id)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x92BF6C", Offset = "0x92BF6C", VA = "0x92BF6C")]
		public void ChangeLanguage(LanguageInfo language)
		{
		}

		[Token(Token = "0x600030B")]
		public abstract string GetFilePath(string file);

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x92BF74", Offset = "0x92BF74", VA = "0x92BF74")]
		protected LanguageManager()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class LanguageManager_Directory : LanguageManager
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string languageDirPath;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x92BFF8", Offset = "0x92BFF8", VA = "0x92BFF8")]
		public LanguageManager_Directory(string languageDirPath)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x92C050", Offset = "0x92C050", VA = "0x92C050")]
		private int ListupLanguage()
		{
			return default(int);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x92C30C", Offset = "0x92C30C", VA = "0x92C30C", Slot = "4")]
		public override string GetFilePath(string file)
		{
			return null;
		}
	}
	[Token(Token = "0x2000085")]
	public class LanguageManager_Resources : LanguageManager
	{
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string languageDirPath;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x924FE0", Offset = "0x924FE0", VA = "0x924FE0")]
		public LanguageManager_Resources(string languageDirPath, string[] languageNames)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x92C51C", Offset = "0x92C51C", VA = "0x92C51C")]
		private int ListupLanguage(string[] languageNames)
		{
			return default(int);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x92C6EC", Offset = "0x92C6EC", VA = "0x92C6EC", Slot = "4")]
		public override string GetFilePath(string file)
		{
			return null;
		}
	}
	[Token(Token = "0x2000086")]
	public class LanguageTexts : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000087")]
		public class UIAndID
		{
			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text ui;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string id;

			[Token(Token = "0x600031B")]
			[Address(RVA = "0xCCC060", Offset = "0xCCC060", VA = "0xCCC060")]
			public UIAndID()
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0xCCC068", Offset = "0xCCC068", VA = "0xCCC068")]
			public UIAndID(Text setText)
			{
			}
		}

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAndID[] texts;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string fileName;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x926518", Offset = "0x926518", VA = "0x926518")]
		public void ChangeLanguage(LanguageManager languageManager)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x92C778", Offset = "0x92C778", VA = "0x92C778")]
		private static Dictionary<string, string> LoadWordSets(string path)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x92CB7C", Offset = "0x92CB7C", VA = "0x92CB7C")]
		private static string ArrangeWord(string original)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x92CA7C", Offset = "0x92CA7C", VA = "0x92CA7C")]
		private void ApplyWords(UIAndID[] texts, Dictionary<string, string> wordSets)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x92CBEC", Offset = "0x92CBEC", VA = "0x92CBEC")]
		public void AddTexts(UIAndID[] addArray)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x92CC48", Offset = "0x92CC48", VA = "0x92CC48")]
		public void AddTexts(Text[] addTexts)
		{
		}

		[Token(Token = "0x6000319")]
		private static void AddRange<T>(ref T[] baseArray, T[] addArray)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x92CD90", Offset = "0x92CD90", VA = "0x92CD90")]
		public LanguageTexts()
		{
		}
	}
}
namespace AnimalVR
{
	[Token(Token = "0x2000088")]
	public class Field : MonoBehaviour
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalFavoritePlaceCollection animalFavoritePlaceCollection;

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xD23D9C", Offset = "0xD23D9C", VA = "0xD23D9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xD23E48", Offset = "0xD23E48", VA = "0xD23E48")]
		public void SetupMainGame(MainGameManager mainGame)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xD23EEC", Offset = "0xD23EEC", VA = "0xD23EEC")]
		public AnimalFavoritePlace[] GetAnimalFavoritePlaces(AnimalChara.AnimalKind kind)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xD23F08", Offset = "0xD23F08", VA = "0xD23F08")]
		public Field()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class NavMeshBakeRendererSwitcher : MonoBehaviour
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Renderer[] navmeshBakeRenderers;

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xCFD8EC", Offset = "0xCFD8EC", VA = "0xCFD8EC")]
		private void ShowNavMeshBakeRenderers()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xCFD95C", Offset = "0xCFD95C", VA = "0xCFD95C")]
		private void HideNavMeshBakeRenderers()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xCFD9CC", Offset = "0xCFD9CC", VA = "0xCFD9CC")]
		public NavMeshBakeRendererSwitcher()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class BlendShapeFood : Food
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string blendShapeName;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SkinnedMeshRenderer renderer;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int blendShapeNo;

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xD1BAF8", Offset = "0xD1BAF8", VA = "0xD1BAF8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xD1BB44", Offset = "0xD1BB44", VA = "0xD1BB44", Slot = "10")]
		protected override void ApplyAmount()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xD1BBA8", Offset = "0xD1BBA8", VA = "0xD1BBA8")]
		public BlendShapeFood()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class FeedingBottle : Food
	{
		[Token(Token = "0x6000327")]
		[Address(RVA = "0xD23CCC", Offset = "0xD23CCC", VA = "0xD23CCC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xD23D84", Offset = "0xD23D84", VA = "0xD23D84")]
		private new void OnGrab(GrabHand hand)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xD23D90", Offset = "0xD23D90", VA = "0xD23D90", Slot = "10")]
		protected override void ApplyAmount()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xD23D94", Offset = "0xD23D94", VA = "0xD23D94")]
		public FeedingBottle()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class Food : MonoBehaviour
	{
		[Token(Token = "0x200008D")]
		public enum Kind
		{
			[Token(Token = "0x40002EA")]
			BigAnimalFoodOnDish,
			[Token(Token = "0x40002EB")]
			LittleAnimalFoodOnDish,
			[Token(Token = "0x40002EC")]
			Radish,
			[Token(Token = "0x40002ED")]
			Fish,
			[Token(Token = "0x40002EE")]
			CutApple,
			[Token(Token = "0x40002EF")]
			FeedingBottole,
			[Token(Token = "0x40002F0")]
			Quest_Fox02_Fish,
			[Token(Token = "0x40002F1")]
			Quest_Bear_Honeycomb
		}

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Kind foodKind;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform eatPoint;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4408A0", Offset = "0x4408A0")]
		[SerializeField]
		protected float amount;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected AudioClip eatSE;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected ParticleAndSound vanishEffect;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected bool isUngrabVanish;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Grabbable grabbable;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected SoundEffect3D se3D;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected FindableElement findableElement;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected bool reserveVanish;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440910", Offset = "0x440910")]
		private bool <IsEatenNow>k__BackingField;

		[Token(Token = "0x1700003A")]
		public float Amount
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x921C40", Offset = "0x921C40", VA = "0x921C40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		public bool IsEdible
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x921C48", Offset = "0x921C48", VA = "0x921C48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public Kind FoodKind
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x921C58", Offset = "0x921C58", VA = "0x921C58")]
			get
			{
				return default(Kind);
			}
		}

		[Token(Token = "0x1700003D")]
		public bool IsEatenNow
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x921C60", Offset = "0x921C60", VA = "0x921C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443120", Offset = "0x443120")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x921C68", Offset = "0x921C68", VA = "0x921C68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443130", Offset = "0x443130")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public FindableElement FindableElement
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x921C74", Offset = "0x921C74", VA = "0x921C74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public bool IsGrabbed
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x921C7C", Offset = "0x921C7C", VA = "0x921C7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x921D14", Offset = "0x921D14", VA = "0x921D14", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x921E60", Offset = "0x921E60", VA = "0x921E60", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x921F24", Offset = "0x921F24", VA = "0x921F24", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x921FB0", Offset = "0x921FB0", VA = "0x921FB0", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x922074", Offset = "0x922074", VA = "0x922074")]
		private void Update()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x9221B8", Offset = "0x9221B8", VA = "0x9221B8", Slot = "8")]
		protected virtual void OnGrab(GrabHand hand)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x9221C0", Offset = "0x9221C0", VA = "0x9221C0", Slot = "9")]
		protected virtual void OnUngrab(GrabHand hand)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x922084", Offset = "0x922084", VA = "0x922084")]
		private void Vanish()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x9221D4", Offset = "0x9221D4", VA = "0x9221D4", Slot = "10")]
		protected virtual void ApplyAmount()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x9222A0", Offset = "0x9222A0", VA = "0x9222A0")]
		public void AddFoodAmount(float add)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x9222DC", Offset = "0x9222DC", VA = "0x9222DC")]
		public void SubtractFoodAmount(float sub)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x922318", Offset = "0x922318", VA = "0x922318")]
		public void StartEat()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x922378", Offset = "0x922378", VA = "0x922378")]
		public bool UpdateEat(float eatAmount)
		{
			return default(bool);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x9223C4", Offset = "0x9223C4", VA = "0x9223C4")]
		public void StopEat()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x922324", Offset = "0x922324", VA = "0x922324")]
		private void StartSE()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x9223E8", Offset = "0x9223E8", VA = "0x9223E8")]
		private void StopSE()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x922404", Offset = "0x922404", VA = "0x922404")]
		public Vector3 GetEatPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x922284", Offset = "0x922284", VA = "0x922284")]
		public bool IsEatOnDish()
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x922498", Offset = "0x922498", VA = "0x922498")]
		public bool IsAttentional(AnimalChara animal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x922510", Offset = "0x922510", VA = "0x922510")]
		public Food()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class FoodBag : MonoBehaviour
	{
		[Token(Token = "0x40002F2")]
		private const string CollFoodTypeName = "PetDish";

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FoodParticle foodParticleOriginal;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform direction;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float power;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float emitDot;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float emitRandomPos;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float emitRandomAngle;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float emitSpan;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int emitNum;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FoodBagTop bagTop;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioClip foodEmitterSE;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float emitTimer;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SoundEffect3D se3d;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playingSE;

		[Token(Token = "0x17000040")]
		public bool IsOpend
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x922520", Offset = "0x922520", VA = "0x922520")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x92253C", Offset = "0x92253C", VA = "0x92253C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x9226A8", Offset = "0x9226A8", VA = "0x9226A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x92271C", Offset = "0x92271C", VA = "0x92271C")]
		private void UpdateEmitter()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x9227EC", Offset = "0x9227EC", VA = "0x9227EC")]
		private void Emit()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x922864", Offset = "0x922864", VA = "0x922864")]
		private void EmitOne()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x922A80", Offset = "0x922A80", VA = "0x922A80")]
		private void OnGrab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x922AB0", Offset = "0x922AB0", VA = "0x922AB0")]
		private void OnUngrab(GrabHand ungrabHand)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x922AE0", Offset = "0x922AE0", VA = "0x922AE0")]
		public FoodBag()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class FoodCan : MonoBehaviour
	{
		[Token(Token = "0x4000301")]
		private const string CollFoodTypeName = "PetBowl";

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FoodParticle foodParticleOriginal;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform direction;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float power;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float emitDot;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float emitRandomPos;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float emitRandomAngle;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float emitSpan;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int emitNum;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PullTop pullTop;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip foodEmitterSE;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float emitTimer;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SoundEffect3D se3d;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool playingSE;

		[Token(Token = "0x17000041")]
		public bool IsOpend
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x922EE0", Offset = "0x922EE0", VA = "0x922EE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x922EFC", Offset = "0x922EFC", VA = "0x922EFC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x923068", Offset = "0x923068", VA = "0x923068")]
		private void Update()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x9230DC", Offset = "0x9230DC", VA = "0x9230DC")]
		private void Update_Emitter()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x9231AC", Offset = "0x9231AC", VA = "0x9231AC")]
		private void Emit()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x923224", Offset = "0x923224", VA = "0x923224")]
		private void EmitOne()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x923440", Offset = "0x923440", VA = "0x923440")]
		private void OnGrab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x923470", Offset = "0x923470", VA = "0x923470")]
		private void OnUngrab(GrabHand ungrabHand)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x9234A0", Offset = "0x9234A0", VA = "0x9234A0")]
		public FoodCan()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class FoodContainer : MonoBehaviour
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Food food;

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x9234CC", Offset = "0x9234CC", VA = "0x9234CC")]
		public FoodContainer()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x43F144", Offset = "0x43F144")]
	public class FoodParticle : MonoBehaviour
	{
		[Token(Token = "0x4000312")]
		private const string Tag_FoodDish = "FoodDish";

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Food.Kind foodKind;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject mainObj;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject splashObj;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isSplashed;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float maxLifeTime;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float addFoodAmount;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody rigidbody;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string collFoodTypeName;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x9234D4", Offset = "0x9234D4", VA = "0x9234D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x92355C", Offset = "0x92355C", VA = "0x92355C")]
		private void Update()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x923610", Offset = "0x923610", VA = "0x923610")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x9237A0", Offset = "0x9237A0", VA = "0x9237A0")]
		private void Splash()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x923878", Offset = "0x923878", VA = "0x923878")]
		public void SetCollFoodTypeName(string collFoodTypeName)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x923880", Offset = "0x923880", VA = "0x923880")]
		public FoodParticle()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class FruitKnife : MonoBehaviour
	{
		[Token(Token = "0x400031B")]
		private const string WholeAppleName = "WholeApple";

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x17000042")]
		public bool IsGrabbed
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x924BD0", Offset = "0x924BD0", VA = "0x924BD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x924BF0", Offset = "0x924BF0", VA = "0x924BF0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x924D40", Offset = "0x924D40", VA = "0x924D40")]
		public FruitKnife()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class WholeApple : DislikeItem
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject cutApple;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Collider collider;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip cutAudioClip;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SoundEffect3D sound;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected FindableElement findableElement;

		[Token(Token = "0x17000043")]
		public FindableElement FindableElement
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0xD11164", Offset = "0xD11164", VA = "0xD11164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public bool IsGrabbed
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0xD1116C", Offset = "0xD1116C", VA = "0xD1116C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xD1118C", Offset = "0xD1118C", VA = "0xD1118C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xD11214", Offset = "0xD11214", VA = "0xD11214")]
		private void Start()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xD11284", Offset = "0xD11284", VA = "0xD11284")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xD11330", Offset = "0xD11330", VA = "0xD11330")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xD113DC", Offset = "0xD113DC", VA = "0xD113DC", Slot = "4")]
		public override bool IsAttentional()
		{
			return default(bool);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xD113FC", Offset = "0xD113FC", VA = "0xD113FC")]
		public void OnCut()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xD11598", Offset = "0xD11598", VA = "0xD11598")]
		public WholeApple()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class Honeycomb : MonoBehaviour
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int Field_Layer;

		[Token(Token = "0x4000324")]
		private const float Food_Amount_Limit = 0.5f;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip clip;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SoundEffect3D sound;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isSoundPlayed;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isUnGrab;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x92B494", Offset = "0x92B494", VA = "0x92B494")]
		public Honeycomb()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x43F1A4", Offset = "0x43F1A4")]
	public class RC_Car : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000096")]
		public class Axel
		{
			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WheelCollider wheelColoder_L;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform wheelVisual_L;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WheelCollider wheelColoder_R;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform wheelVisual_R;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool motor;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool steering;

			[Token(Token = "0x6000384")]
			[Address(RVA = "0xCCC900", Offset = "0xCCC900", VA = "0xCCC900")]
			public Axel()
			{
			}
		}

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Axel[] axels;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float maxMotorTorque;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float maxBrakeTorque;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float maxSteerAngle;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float engineBrakeTorque;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 centerOfMass;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float attentionalKPH;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform[] chasingPoints;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool isDebug;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BillboardRotator debugBillboard;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text debugText;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ParticleSystem slipEffect;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float forwardSlipThreshold;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float sideSlipThreshold;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float slipEffectUpSpeed;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float effectSpan;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip motorAudioClip;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private SoundEffect3D motorSE;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float pitch;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float effectTimer;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Rigidbody rigidbody;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float motorTorque;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float brakeTorque;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float steerAngle;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float acceleratorInput;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float brakeInput;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float steerInput;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 prevPos;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440C80", Offset = "0x440C80")]
		private float <SpeedKPH>k__BackingField;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private FindableElement findableElement;

		[Token(Token = "0x17000045")]
		public float SpeedKPH
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0xD0400C", Offset = "0xD0400C", VA = "0xD0400C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443140", Offset = "0x443140")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0xD04014", Offset = "0xD04014", VA = "0xD04014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443150", Offset = "0x443150")]
			private set
			{
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xD0401C", Offset = "0xD0401C", VA = "0xD0401C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xD040A4", Offset = "0xD040A4", VA = "0xD040A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xD04258", Offset = "0xD04258", VA = "0xD04258")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xD04304", Offset = "0xD04304", VA = "0xD04304")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xD043B0", Offset = "0xD043B0", VA = "0xD043B0")]
		public void InputAccelerator(float input)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xD043B8", Offset = "0xD043B8", VA = "0xD043B8")]
		public void InputBrake(float input)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xD043E0", Offset = "0xD043E0", VA = "0xD043E0")]
		public void InputSteering(float input)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xD04410", Offset = "0xD04410", VA = "0xD04410")]
		private void Update()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xD0446C", Offset = "0xD0446C", VA = "0xD0446C")]
		private void Update_SE()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xD045AC", Offset = "0xD045AC", VA = "0xD045AC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xD04800", Offset = "0xD04800", VA = "0xD04800")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xD04804", Offset = "0xD04804", VA = "0xD04804")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xD046DC", Offset = "0xD046DC", VA = "0xD046DC")]
		private void UpdateAxel(Axel axel, float motorTorque, float brakeTorque, float steerAngle)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xD04CCC", Offset = "0xD04CCC", VA = "0xD04CCC")]
		private void UpdateSlipEffects()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xD04DAC", Offset = "0xD04DAC", VA = "0xD04DAC")]
		private bool UpdateWheelSlipEffect(WheelCollider wheel)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xD04C50", Offset = "0xD04C50", VA = "0xD04C50")]
		private static void ApplyWheelVisual(Transform visual, WheelCollider colider)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xD041F4", Offset = "0xD041F4", VA = "0xD041F4")]
		private void SetupCenterOfMass()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xD047AC", Offset = "0xD047AC", VA = "0xD047AC")]
		private static float CalcKPH(Vector3 prevPos, Vector3 nextPos)
		{
			return default(float);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xD0501C", Offset = "0xD0501C", VA = "0xD0501C")]
		public bool IsAttentional()
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xD05030", Offset = "0xD05030", VA = "0xD05030")]
		public Vector3 NearChasingPoint(Vector3 chaserPos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xD05164", Offset = "0xD05164", VA = "0xD05164")]
		public RC_Car()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class RC_CarDebug : MonoBehaviour
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RC_Car car;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera camera;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float offsetPitch;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 lookAtOffsetPos;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float accelInputK;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float brakeInputK;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float steeringInputK;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text kphText;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isReverse;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float accel;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float steering;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float brake;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationCurve steerEffectBySpeed;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xD051CC", Offset = "0xD051CC", VA = "0xD051CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xD051D0", Offset = "0xD051D0", VA = "0xD051D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xD05438", Offset = "0xD05438", VA = "0xD05438")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xD0543C", Offset = "0xD0543C", VA = "0xD0543C")]
		private void CalcCameraPosition()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xD055C0", Offset = "0xD055C0", VA = "0xD055C0")]
		public RC_CarDebug()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class RC_Transmitter : MonoBehaviour
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RC_Car car;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GrabbableObject grabObj;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RC_SteeringGrip steerGrip;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TouchButton reverseButton;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject unpushedReverseButtonMesh;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject pushedReverseButtonMesh;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip buttonAudio;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private OneShotVibrationParameter buttonVib;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabHand grabHand;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SoundEffect3D buttonSE;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isReverse;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xD059C4", Offset = "0xD059C4", VA = "0xD059C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xD05BE4", Offset = "0xD05BE4", VA = "0xD05BE4")]
		private void Start()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xD05C68", Offset = "0xD05C68", VA = "0xD05C68")]
		private void Update()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xD05D08", Offset = "0xD05D08", VA = "0xD05D08")]
		private void GrabUpdate()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xD05D90", Offset = "0xD05D90", VA = "0xD05D90")]
		private void Input(out float accelerator, out float brake)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xD05DEC", Offset = "0xD05DEC", VA = "0xD05DEC")]
		private void OnGrab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xD05E28", Offset = "0xD05E28", VA = "0xD05E28")]
		private void OnUngrab(GrabHand ungrabHand)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xD05EC8", Offset = "0xD05EC8", VA = "0xD05EC8")]
		private void OnSwitchReverse(VR_Input.SIDE side)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xD05B98", Offset = "0xD05B98", VA = "0xD05B98")]
		private void ApplyButtonMesh()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xD05F6C", Offset = "0xD05F6C", VA = "0xD05F6C")]
		public RC_Transmitter()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x200009A")]
		private enum State
		{
			[Token(Token = "0x4000370")]
			None,
			[Token(Token = "0x4000371")]
			Grab,
			[Token(Token = "0x4000372")]
			Threw,
			[Token(Token = "0x4000373")]
			Hold
		}

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Grabbable grabbable;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float radius;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private State state;

		[Token(Token = "0x400036A")]
		private const float ThrewSecond = 5f;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float threwTimer;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody rigidbody;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AnimalChara holdingAnimal;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FindableElement findableElement;

		[Token(Token = "0x17000046")]
		public float Radius
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0xD1AB64", Offset = "0xD1AB64", VA = "0xD1AB64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xD1AB6C", Offset = "0xD1AB6C", VA = "0xD1AB6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xD1AC48", Offset = "0xD1AC48", VA = "0xD1AC48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xD1ACF4", Offset = "0xD1ACF4", VA = "0xD1ACF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xD1AE08", Offset = "0xD1AE08", VA = "0xD1AE08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xD1AEB4", Offset = "0xD1AEB4", VA = "0xD1AEB4")]
		private void Update()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xD1AF08", Offset = "0xD1AF08", VA = "0xD1AF08")]
		private void OnGrab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xD1AF8C", Offset = "0xD1AF8C", VA = "0xD1AF8C")]
		private void OnUngrab(GrabHand ungrabHand)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xD1B010", Offset = "0xD1B010", VA = "0xD1B010")]
		public bool IsAttentional()
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xD1B020", Offset = "0xD1B020", VA = "0xD1B020")]
		public bool IsFree()
		{
			return default(bool);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xD1B034", Offset = "0xD1B034", VA = "0xD1B034")]
		public bool IsGrabbed()
		{
			return default(bool);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xD1B044", Offset = "0xD1B044", VA = "0xD1B044")]
		public bool IsHolded()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xD1B054", Offset = "0xD1B054", VA = "0xD1B054")]
		public bool CheckHoldingAnimal(AnimalChara animal)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xD1B0EC", Offset = "0xD1B0EC", VA = "0xD1B0EC")]
		public bool IsUnused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xD1B0FC", Offset = "0xD1B0FC", VA = "0xD1B0FC")]
		public Vector3 Position()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xD1B120", Offset = "0xD1B120", VA = "0xD1B120")]
		public void OnHold(AnimalChara animalChara, Transform holdTransform)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xD1B1CC", Offset = "0xD1B1CC", VA = "0xD1B1CC")]
		public void OnRelease()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xD1B240", Offset = "0xD1B240", VA = "0xD1B240")]
		public void ToKinematic()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xD1B260", Offset = "0xD1B260", VA = "0xD1B260")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xD1B2B0", Offset = "0xD1B2B0", VA = "0xD1B2B0")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class FindableElement
	{
		[Token(Token = "0x200009C")]
		public enum Kind
		{
			[Token(Token = "0x400037C")]
			None = -1,
			[Token(Token = "0x400037D")]
			PlayerFace,
			[Token(Token = "0x400037E")]
			PlayerHand,
			[Token(Token = "0x400037F")]
			Animal,
			[Token(Token = "0x4000380")]
			Food,
			[Token(Token = "0x4000381")]
			Ball,
			[Token(Token = "0x4000382")]
			RCCar,
			[Token(Token = "0x4000383")]
			DislikeItem
		}

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara animal;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Food food;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Ball ball;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RC_Car rc_car;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DislikeItem dislikeItem;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440DD0", Offset = "0x440DD0")]
		private Kind <kind>k__BackingField;

		[Token(Token = "0x17000047")]
		public Kind kind
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xD248B4", Offset = "0xD248B4", VA = "0xD248B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443160", Offset = "0x443160")]
			get
			{
				return default(Kind);
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xD248BC", Offset = "0xD248BC", VA = "0xD248BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443170", Offset = "0x443170")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Vector3 position
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xD16640", Offset = "0xD16640", VA = "0xD16640")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xD248C4", Offset = "0xD248C4", VA = "0xD248C4")]
		private FindableElement()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xD248CC", Offset = "0xD248CC", VA = "0xD248CC")]
		public FindableElement(Transform transform, AnimalChara animal)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xD24924", Offset = "0xD24924", VA = "0xD24924")]
		public FindableElement(Transform transform, Food food)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xD1ABF0", Offset = "0xD1ABF0", VA = "0xD1ABF0")]
		public FindableElement(Transform transform, Ball ball)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xD2497C", Offset = "0xD2497C", VA = "0xD2497C")]
		public FindableElement(Transform transform, RC_Car rc_car)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xD249D4", Offset = "0xD249D4", VA = "0xD249D4")]
		public FindableElement(Transform transform, DislikeItem dislikeItem)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xD24A2C", Offset = "0xD24A2C", VA = "0xD24A2C")]
		public FindableElement(Transform transform, Kind kind)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xD24B2C", Offset = "0xD24B2C", VA = "0xD24B2C")]
		public AnimalChara GetAnimal()
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xD24B34", Offset = "0xD24B34", VA = "0xD24B34")]
		public Ball GetBall()
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xD24B3C", Offset = "0xD24B3C", VA = "0xD24B3C")]
		public RC_Car GetRCCar()
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xD24B44", Offset = "0xD24B44", VA = "0xD24B44")]
		public Food GetFood()
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xD24B4C", Offset = "0xD24B4C", VA = "0xD24B4C")]
		public DislikeItem GetDislikeItem()
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xD24B54", Offset = "0xD24B54", VA = "0xD24B54")]
		public bool IsAttentional(AnimalChara animal)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xD24C7C", Offset = "0xD24C7C", VA = "0xD24C7C")]
		public bool IsAvailable()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009D")]
	public class FoundElementInfo
	{
		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440DE0", Offset = "0x440DE0")]
		private FindableElement <element>k__BackingField;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440DF0", Offset = "0x440DF0")]
		private float <distance>k__BackingField;

		[Token(Token = "0x17000049")]
		public FindableElement element
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x923F34", Offset = "0x923F34", VA = "0x923F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443180", Offset = "0x443180")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x923F3C", Offset = "0x923F3C", VA = "0x923F3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443190", Offset = "0x443190")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public float distance
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x923F44", Offset = "0x923F44", VA = "0x923F44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4431A0", Offset = "0x4431A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x923F4C", Offset = "0x923F4C", VA = "0x923F4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4431B0", Offset = "0x4431B0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public FindableElement.Kind kind
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x923CD8", Offset = "0x923CD8", VA = "0x923CD8")]
			get
			{
				return default(FindableElement.Kind);
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 position
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x923E94", Offset = "0x923E94", VA = "0x923E94")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x923F54", Offset = "0x923F54", VA = "0x923F54")]
		public FoundElementInfo(FindableElement element, float distance)
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class MainGameManager
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440E00", Offset = "0x440E00")]
		private bool <IsStarted>k__BackingField;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440E10", Offset = "0x440E10")]
		private Player <Player>k__BackingField;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440E20", Offset = "0x440E20")]
		private Field <Field>k__BackingField;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FindableElement[] playerFindableElements;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<AnimalChara> animals;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440E30", Offset = "0x440E30")]
		private List<FindableElement> <FindableElements>k__BackingField;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityEvent onStartEvent;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityEvent<AnimalChara> onCompletedQuest;

		[Token(Token = "0x1700004D")]
		public bool IsStarted
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x92F08C", Offset = "0x92F08C", VA = "0x92F08C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4431C0", Offset = "0x4431C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x92F094", Offset = "0x92F094", VA = "0x92F094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4431D0", Offset = "0x4431D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public Player Player
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x92F0A0", Offset = "0x92F0A0", VA = "0x92F0A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4431E0", Offset = "0x4431E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x92F0A8", Offset = "0x92F0A8", VA = "0x92F0A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4431F0", Offset = "0x4431F0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public Field Field
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x92F0B0", Offset = "0x92F0B0", VA = "0x92F0B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443200", Offset = "0x443200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x92F0B8", Offset = "0x92F0B8", VA = "0x92F0B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443210", Offset = "0x443210")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public List<FindableElement> FindableElements
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x92F0C0", Offset = "0x92F0C0", VA = "0x92F0C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443220", Offset = "0x443220")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x92F0C8", Offset = "0x92F0C8", VA = "0x92F0C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443230", Offset = "0x443230")]
			private set
			{
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x92F0D0", Offset = "0x92F0D0", VA = "0x92F0D0")]
		public void Setup(Player player, Material skyboxMaterial)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x92F1FC", Offset = "0x92F1FC", VA = "0x92F1FC")]
		private void SetupPlayer(Player player)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x92F3C0", Offset = "0x92F3C0", VA = "0x92F3C0")]
		public void AddAnimal(AnimalChara animal)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x92F47C", Offset = "0x92F47C", VA = "0x92F47C")]
		public void SetField(Field field)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x92F484", Offset = "0x92F484", VA = "0x92F484")]
		public void AddFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x92F524", Offset = "0x92F524", VA = "0x92F524")]
		public void RemoveFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x924110", Offset = "0x924110", VA = "0x924110")]
		public void AddOnStartEventListener(UnityAction onStartAction)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x92F6A0", Offset = "0x92F6A0", VA = "0x92F6A0")]
		public void OnStartScene()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x92F75C", Offset = "0x92F75C", VA = "0x92F75C")]
		public List<FoundElementInfo> FindInEyesight(AnimalChara animal, Vector3 eyePos, Vector3 eyeDir, float maxDistance, float maxAngle)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x92F978", Offset = "0x92F978", VA = "0x92F978")]
		public FindableElement FindNearElement(AnimalChara animal, FindableElement.Kind kind, Vector3 centerPos, float maxDistance, bool onlyAttentinal)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x92FAC4", Offset = "0x92FAC4", VA = "0x92FAC4")]
		public FindableElement FindNearElement(Func<FindableElement, bool> function, Vector3 centerPos, float maxDistance)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x92FC0C", Offset = "0x92FC0C", VA = "0x92FC0C")]
		public void AddQuestCompletedListner(UnityAction<AnimalChara> action)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x92FC70", Offset = "0x92FC70", VA = "0x92FC70")]
		public void OnCompletedQuest(AnimalChara animal)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x92FCD4", Offset = "0x92FCD4", VA = "0x92FCD4")]
		public MainGameManager()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class MainGameScene : VRScene
	{
		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F204", Offset = "0x43F204")]
		private sealed class <InSceneCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MainGameScene <>4__this;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string sceneInMessage;

			[Token(Token = "0x17000052")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003EC")]
				[Address(RVA = "0xCCC688", Offset = "0xCCC688", VA = "0xCCC688", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000053")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003EE")]
				[Address(RVA = "0xCCC6D0", Offset = "0xCCC6D0", VA = "0xCCC6D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xCCC5D8", Offset = "0xCCC5D8", VA = "0xCCC5D8")]
			[DebuggerHidden]
			public <InSceneCoroutine>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xCCC604", Offset = "0xCCC604", VA = "0xCCC604", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xCCC608", Offset = "0xCCC608", VA = "0xCCC608", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xCCC690", Offset = "0xCCC690", VA = "0xCCC690", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameMenu gameMenu;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float menuDistance;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform playerStartPosition;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip bgmClip;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Material skyboxMaterial;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MainGameManager mainGameManager;

		[Token(Token = "0x17000051")]
		public MainGameManager MainGameManager
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x92FE28", Offset = "0x92FE28", VA = "0x92FE28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x92FE30", Offset = "0x92FE30", VA = "0x92FE30", Slot = "5")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x443240", Offset = "0x443240")]
		public override IEnumerator InSceneCoroutine(string sceneInMessage)
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x92FEC4", Offset = "0x92FEC4", VA = "0x92FEC4")]
		private void InitScene()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x9301C8", Offset = "0x9301C8", VA = "0x9301C8", Slot = "6")]
		public override void OutScene(string next)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x9301B0", Offset = "0x9301B0", VA = "0x9301B0")]
		private void StartScene()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x9301F0", Offset = "0x9301F0", VA = "0x9301F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x92FFA8", Offset = "0x92FFA8", VA = "0x92FFA8")]
		private void ApplyPlayerStartPosition()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x9302B4", Offset = "0x9302B4", VA = "0x9302B4")]
		public void AddAnimal(AnimalChara animal)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x9302CC", Offset = "0x9302CC", VA = "0x9302CC")]
		public void SetField(Field field)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x921F0C", Offset = "0x921F0C", VA = "0x921F0C")]
		public void AddFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x92205C", Offset = "0x92205C", VA = "0x92205C")]
		public void RemoveFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x9301F4", Offset = "0x9301F4", VA = "0x9301F4")]
		private void UpdateConfigMenu()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x9302E8", Offset = "0x9302E8", VA = "0x9302E8")]
		private bool InputMenuButton()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x9304B0", Offset = "0x9304B0", VA = "0x9304B0")]
		private bool InputKnucklesMenuButton()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x930398", Offset = "0x930398", VA = "0x930398")]
		private void CalcMenuOpenPosition(out Vector3 out_pos, out Quaternion out_rot)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x9304B8", Offset = "0x9304B8", VA = "0x9304B8")]
		public void AddQuestCompletedListner(UnityAction<AnimalChara> action)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x9304D0", Offset = "0x9304D0", VA = "0x9304D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x9305E4", Offset = "0x9305E4", VA = "0x9305E4")]
		public MainGameScene()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x930658", Offset = "0x930658", VA = "0x930658")]
		[DebuggerHidden]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4432A0", Offset = "0x4432A0")]
		private IEnumerator <>n__0(string sceneInMessage)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A1")]
	public class Player : VRPlayer
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform eyeTrans;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private EyeFader eyeFader;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform handAttensionPointL;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform handAttensionPointR;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string[] handMaterialResources;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Renderer[] handRenderers;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Skybox skybox;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool isCrouchingDown;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float standingHeightOffset;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float crouchingOffset;

		[Token(Token = "0x17000054")]
		public Transform FaceAttensionPoint
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0xCFFE70", Offset = "0xCFFE70", VA = "0xCFFE70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public Transform HandAttensionPointL
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xCFFE78", Offset = "0xCFFE78", VA = "0xCFFE78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public Transform HandAttensionPointR
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0xCFFE80", Offset = "0xCFFE80", VA = "0xCFFE80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public EyeFader EyeFader
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xCFFE88", Offset = "0xCFFE88", VA = "0xCFFE88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public bool IsCrouchingDown
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xCFFE90", Offset = "0xCFFE90", VA = "0xCFFE90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xCFFE98", Offset = "0xCFFE98", VA = "0xCFFE98")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xCFFED8", Offset = "0xCFFED8", VA = "0xCFFED8")]
		private bool InputCrouch()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xCFFF74", Offset = "0xCFFF74", VA = "0xCFFF74")]
		private bool InputCrouch_VivePad()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xD00038", Offset = "0xD00038", VA = "0xD00038")]
		private bool InputCrouch_VivePadAxis(Vector2 padInput)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xD00064", Offset = "0xD00064", VA = "0xD00064")]
		public void ChangeHandMaterial(int handTypeNo)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xD00194", Offset = "0xD00194", VA = "0xD00194")]
		public void SetSkyboxEnable(bool enable)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xD002A8", Offset = "0xD002A8", VA = "0xD002A8")]
		public void SetSkyboxMaterial(Material skyboxMaterial)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xD00410", Offset = "0xD00410", VA = "0xD00410", Slot = "6")]
		public override void SetHeightOffset(float heightOffset)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xD00414", Offset = "0xD00414", VA = "0xD00414")]
		public void SetStandingHeightOffset(float heightOffset)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xD00454", Offset = "0xD00454", VA = "0xD00454")]
		public void SetCrouchingOffset(float crouchingOffset)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xCFFF68", Offset = "0xCFFF68", VA = "0xCFFF68")]
		public void SetCrouching(bool isCrouchingDown)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xD0041C", Offset = "0xD0041C", VA = "0xD0041C")]
		private void ApplyHeight()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xD0045C", Offset = "0xD0045C", VA = "0xD0045C")]
		private float CalcHeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xD00478", Offset = "0xD00478", VA = "0xD00478")]
		public Player()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class ClimbingRope : MonoBehaviour
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] ropePoints;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer lineRender;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lineWidth;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lineColliderWidth;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform climbBottomPoint;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform climbTopPoint;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float ropeToPlayerDistance;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float maxHeight;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PlayerTeleportPoint climbingStartTeleporter;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PlayerTeleportPoint climbingEndTeleporter;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GrabHand grabHand;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 prevHandPos;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Player player;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool isClimbing;

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xD1E48C", Offset = "0xD1E48C", VA = "0xD1E48C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xD1E65C", Offset = "0xD1E65C", VA = "0xD1E65C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xD1E73C", Offset = "0xD1E73C", VA = "0xD1E73C")]
		private void CreateRopeCollider()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xD1E7DC", Offset = "0xD1E7DC", VA = "0xD1E7DC")]
		private void CreateCollider(Transform start, Transform end, float radius)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xD1E9D8", Offset = "0xD1E9D8", VA = "0xD1E9D8")]
		private void ApplyLineRender()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xD1E66C", Offset = "0xD1E66C", VA = "0xD1E66C")]
		private void UpdateClimbingPlayer()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xD1EBC8", Offset = "0xD1EBC8", VA = "0xD1EBC8")]
		private void Clamb(Vector3 nowHandPos)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xD1EBE4", Offset = "0xD1EBE4", VA = "0xD1EBE4")]
		private void ClambRopeToPlayerPosition(float clambHeight)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xD1EE34", Offset = "0xD1EE34", VA = "0xD1EE34")]
		private static Vector3 CalcClosestPointOnLine(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xD1ED84", Offset = "0xD1ED84", VA = "0xD1ED84")]
		private static Vector3 CalcClosestPointOnLine_Unclamped(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xD1EF08", Offset = "0xD1EF08", VA = "0xD1EF08")]
		private void OnStartClimbing(Player player)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xD1EFA4", Offset = "0xD1EFA4", VA = "0xD1EFA4")]
		private void OnEndClimbing(Player player)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xD1F040", Offset = "0xD1F040", VA = "0xD1F040")]
		private void OnGrab(GrabHand hand)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xD1F090", Offset = "0xD1F090", VA = "0xD1F090")]
		private void OnUngrab(GrabHand ungrabHand)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xD1F12C", Offset = "0xD1F12C", VA = "0xD1F12C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xD1F2F4", Offset = "0xD1F2F4", VA = "0xD1F2F4")]
		public ClimbingRope()
		{
		}
	}
}
namespace AnimalVR.Chara
{
	[Token(Token = "0x20000A3")]
	public class LookAtRotator : LookAtRotator_Base
	{
		[Token(Token = "0x20000A4")]
		public enum TYPE
		{
			[Token(Token = "0x40003C5")]
			NO,
			[Token(Token = "0x40003C6")]
			TARGET,
			[Token(Token = "0x40003C7")]
			AWAY,
			[Token(Token = "0x40003C8")]
			FORWARD,
			[Token(Token = "0x40003C9")]
			DIRECTION,
			[Token(Token = "0x40003CA")]
			DIRECTION_UNLIMITED,
			[Token(Token = "0x40003CB")]
			HOLD,
			[Token(Token = "0x40003CC")]
			TARGET_ADD_ANIM
		}

		[Serializable]
		[Token(Token = "0x20000A5")]
		public class RotateBone
		{
			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float maxLeft;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float maxRight;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Quaternion baseRot;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 euler;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 prevEuler;

			[Token(Token = "0x1700005B")]
			public Vector3 Euler
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0xCCC0C8", Offset = "0xCCC0C8", VA = "0xCCC0C8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600041D")]
				[Address(RVA = "0xCCC0D4", Offset = "0xCCC0D4", VA = "0xCCC0D4")]
				set
				{
				}
			}

			[Token(Token = "0x1700005C")]
			public Vector3 PrevEuler
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0xCCC0E0", Offset = "0xCCC0E0", VA = "0xCCC0E0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600041F")]
				[Address(RVA = "0xCCC0EC", Offset = "0xCCC0EC", VA = "0xCCC0EC")]
				set
				{
				}
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0xCCC0F8", Offset = "0xCCC0F8", VA = "0xCCC0F8")]
			public void Init()
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0xCCC140", Offset = "0xCCC140", VA = "0xCCC140")]
			public void Change()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0xCCC154", Offset = "0xCCC154", VA = "0xCCC154")]
			public void Rotate(Quaternion rot)
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0xCCC1A8", Offset = "0xCCC1A8", VA = "0xCCC1A8")]
			public void ResetRotate()
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0xCCC1D0", Offset = "0xCCC1D0", VA = "0xCCC1D0")]
			public void LerpAngle(Vector3 rel, float noRate)
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0xCCC260", Offset = "0xCCC260", VA = "0xCCC260")]
			public void Interpolation(Vector3 rel, float speed, float min, float max)
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0xCCC350", Offset = "0xCCC350", VA = "0xCCC350")]
			public RotateBone()
			{
			}
		}

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform baseBone;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 targetPos;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RotateBone[] rotateBones;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3? prevTarget;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x440FE0", Offset = "0x440FE0")]
		private float maxUp;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x441024", Offset = "0x441024")]
		private float maxDown;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x441068", Offset = "0x441068")]
		[SerializeField]
		private float turnRate;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4410A8", Offset = "0x4410A8")]
		private float offsetPitch;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float turnPower;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float turnMinSpeed;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnMaxSpeed;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float ignoreYaw;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float awayIgnoreYaw;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion baseLocalRot;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private TYPE calcType;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float noRate;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] lastUpdateItemAngles;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] currentUpdateItemAngles;

		[Token(Token = "0x17000059")]
		public Vector3 TargetPos
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x92D804", Offset = "0x92D804", VA = "0x92D804")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x92D810", Offset = "0x92D810", VA = "0x92D810")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public TYPE CalcType
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x92D81C", Offset = "0x92D81C", VA = "0x92D81C")]
			get
			{
				return default(TYPE);
			}
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x92D824", Offset = "0x92D824", VA = "0x92D824", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x92D934", Offset = "0x92D934", VA = "0x92D934", Slot = "5")]
		public override void Calc()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x92E34C", Offset = "0x92E34C", VA = "0x92E34C")]
		public void Change(TYPE type, Transform tgt, bool force)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x92E468", Offset = "0x92E468", VA = "0x92E468")]
		public void Change(TYPE type, Vector3 tgt, bool force)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x92E50C", Offset = "0x92E50C", VA = "0x92E50C")]
		private void Start()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x92E518", Offset = "0x92E518", VA = "0x92E518")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x92E524", Offset = "0x92E524", VA = "0x92E524")]
		public LookAtRotator()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class LookAtRotatorSortManager : MonoBehaviour
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtRotator_Base[] rotators;

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x92E560", Offset = "0x92E560", VA = "0x92E560")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x92E5EC", Offset = "0x92E5EC", VA = "0x92E5EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x92E65C", Offset = "0x92E65C", VA = "0x92E65C")]
		public LookAtRotatorSortManager()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public abstract class LookAtRotator_Base : MonoBehaviour
	{
		[Token(Token = "0x600042A")]
		public abstract void Init();

		[Token(Token = "0x600042B")]
		public abstract void Calc();

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x92E558", Offset = "0x92E558", VA = "0x92E558")]
		protected LookAtRotator_Base()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class LookAtRotator_HierarchyRotate : LookAtRotator_Base
	{
		[Token(Token = "0x20000A9")]
		public enum TYPE
		{
			[Token(Token = "0x40003E6")]
			NO,
			[Token(Token = "0x40003E7")]
			TARGET,
			[Token(Token = "0x40003E8")]
			AWAY,
			[Token(Token = "0x40003E9")]
			FORWARD,
			[Token(Token = "0x40003EA")]
			DIRECTION,
			[Token(Token = "0x40003EB")]
			DIRECTION_UNLIMITED
		}

		[Serializable]
		[Token(Token = "0x20000AA")]
		private class RotateBone
		{
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float maxLeft;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float maxRight;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Quaternion baseRot;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 euler;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 prevEuler;

			[Token(Token = "0x1700005E")]
			public Vector3 Euler
			{
				[Token(Token = "0x6000435")]
				[Address(RVA = "0xCCC364", Offset = "0xCCC364", VA = "0xCCC364")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000436")]
				[Address(RVA = "0xCCC370", Offset = "0xCCC370", VA = "0xCCC370")]
				set
				{
				}
			}

			[Token(Token = "0x1700005F")]
			public Vector3 PrevEuler
			{
				[Token(Token = "0x6000437")]
				[Address(RVA = "0xCCC37C", Offset = "0xCCC37C", VA = "0xCCC37C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000438")]
				[Address(RVA = "0xCCC388", Offset = "0xCCC388", VA = "0xCCC388")]
				set
				{
				}
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0xCCC394", Offset = "0xCCC394", VA = "0xCCC394")]
			public void Init()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xCCC3DC", Offset = "0xCCC3DC", VA = "0xCCC3DC")]
			public void Change()
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xCCC3F0", Offset = "0xCCC3F0", VA = "0xCCC3F0")]
			public void Rotate(Quaternion rot)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0xCCC444", Offset = "0xCCC444", VA = "0xCCC444")]
			public void LerpAngle(Vector3 rel, float noRate)
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0xCCC4D4", Offset = "0xCCC4D4", VA = "0xCCC4D4")]
			public void Interpolation(Vector3 rel, float speed, float min, float max)
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0xCCC5C4", Offset = "0xCCC5C4", VA = "0xCCC5C4")]
			public RotateBone()
			{
			}
		}

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform baseBone;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 targetPos;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RotateBone[] rotateBones;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3? prevTarget;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x441190", Offset = "0x441190")]
		private float maxUp;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4411D4", Offset = "0x4411D4")]
		private float maxDown;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x441218", Offset = "0x441218")]
		private float turnRate;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x441258", Offset = "0x441258")]
		[SerializeField]
		private float offsetPitch;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float turnPower;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float turnMinSpeed;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnMaxSpeed;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float ignoreYaw;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float awayIgnoreYaw;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion baseLocalRot;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private TYPE calcType;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float noRate;

		[Token(Token = "0x1700005D")]
		public TYPE CalcType
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x92E664", Offset = "0x92E664", VA = "0x92E664")]
			get
			{
				return default(TYPE);
			}
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x92E66C", Offset = "0x92E66C", VA = "0x92E66C", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x92E70C", Offset = "0x92E70C", VA = "0x92E70C", Slot = "5")]
		public override void Calc()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x92ECB0", Offset = "0x92ECB0", VA = "0x92ECB0")]
		public void Change(TYPE type, Transform tgt, bool force)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x92ED6C", Offset = "0x92ED6C", VA = "0x92ED6C")]
		public void Change(TYPE type, Vector3 tgt, bool force)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x92EE10", Offset = "0x92EE10", VA = "0x92EE10")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x92EE1C", Offset = "0x92EE1C", VA = "0x92EE1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x92EE28", Offset = "0x92EE28", VA = "0x92EE28")]
		public LookAtRotator_HierarchyRotate()
		{
		}
	}
}
namespace AnimalVR.Quest
{
	[Token(Token = "0x20000AB")]
	public class AppleTree : MonoBehaviour
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<WholeApple> apples;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UnityEvent onPluckAppleEvent;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xD17E1C", Offset = "0xD17E1C", VA = "0xD17E1C")]
		public void AddListner(UnityAction onPluckAppleAction)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xD17E38", Offset = "0xD17E38", VA = "0xD17E38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xD17FB8", Offset = "0xD17FB8", VA = "0xD17FB8")]
		public AppleTree()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class Dirt : MonoBehaviour
	{
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UnityEvent onWashedDirt;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float timer;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool isWashing;

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xD221B8", Offset = "0xD221B8", VA = "0xD221B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xD22214", Offset = "0xD22214", VA = "0xD22214")]
		private void Washed_Dirt()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xD222A0", Offset = "0xD222A0", VA = "0xD222A0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xD22398", Offset = "0xD22398", VA = "0xD22398")]
		public void AddListener(UnityAction onWashedDirt)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xD223B4", Offset = "0xD223B4", VA = "0xD223B4")]
		public Dirt()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class Dropper : MonoBehaviour
	{
		[Token(Token = "0x40003F7")]
		private const float BlendSpeed = 2f;

		[Token(Token = "0x40003F8")]
		private const float BlendTimer_Max = 1f;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkinnedMeshRenderer renderer;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string blendShapeName;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WaterDrop waterDropOriginal;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform direction;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float blendTimer;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int blendShapeNum;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private VR_Input.BUTTON pipetteCrushButton;

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xD22F60", Offset = "0xD22F60", VA = "0xD22F60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xD23034", Offset = "0xD23034", VA = "0xD23034")]
		private void Update()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xD230D8", Offset = "0xD230D8", VA = "0xD230D8")]
		private void Emit()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xD23208", Offset = "0xD23208", VA = "0xD23208")]
		private void OnGrab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xD23230", Offset = "0xD23230", VA = "0xD23230")]
		public Dropper()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class FallenTree : MonoBehaviour
	{
		[Token(Token = "0x20000AF")]
		private enum State
		{
			[Token(Token = "0x400040B")]
			Standing,
			[Token(Token = "0x400040C")]
			Falling,
			[Token(Token = "0x400040D")]
			Fallen
		}

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int Anm_Standing;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly int Anm_Falling;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int Anm_Fallen;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip fallenSEClip;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem fallenEffect;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SoundEffect3D fallenSE;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action onFallenAction;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private State state;

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xD23A58", Offset = "0xD23A58", VA = "0xD23A58")]
		private void Update()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xD23A6C", Offset = "0xD23A6C", VA = "0xD23A6C")]
		private void Update_Falling()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xD23B0C", Offset = "0xD23B0C", VA = "0xD23B0C")]
		public void Fall(Action onFallenAction)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xD23BE0", Offset = "0xD23BE0", VA = "0xD23BE0")]
		public void Fallen()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xD23C28", Offset = "0xD23C28", VA = "0xD23C28")]
		public FallenTree()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class HoneyTree : Grabbable
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		private class TreePoint
		{
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float radius;

			[Token(Token = "0x6000465")]
			[Address(RVA = "0xCCC058", Offset = "0xCCC058", VA = "0xCCC058")]
			public TreePoint()
			{
			}
		}

		[Token(Token = "0x400040E")]
		private const float Honey_Fall_Anm_Time = 0.7f;

		[Token(Token = "0x400040F")]
		private const float Shaking_Distance = 0.1f;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int GrabHand_AnmState_Natural;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int AnmState_ShakeTree;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float snapGrabAngle;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float grab_Radius;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Rigidbody honeycomb;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ParticleAndSound effect;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TreePoint[] treeGrabPoints;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector3 positionOffsetsL;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 positionOffsetsR;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector3 rotationOffsetsL;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Vector3 rotationOffsetsR;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform grabPointL;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Transform grabPointR;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float shakeVibrationRate;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float shakeVibrationMax;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool isShaked;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] shakeStartHandPositions;

		[Token(Token = "0x17000060")]
		public bool IsAttachedHoneycomb
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x929FC4", Offset = "0x929FC4", VA = "0x929FC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x92A030", Offset = "0x92A030", VA = "0x92A030")]
		private void Start()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x92A0D4", Offset = "0x92A0D4", VA = "0x92A0D4")]
		public void Setup(bool isCompletedQuest)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x92A198", Offset = "0x92A198", VA = "0x92A198", Slot = "8")]
		public override void Grab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x92A34C", Offset = "0x92A34C", VA = "0x92A34C")]
		private void SettingGrabHand(GrabHand grabHand)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x92A688", Offset = "0x92A688", VA = "0x92A688", Slot = "9")]
		public override void Ungrab(GrabHand ungrabHand, Vector3 velocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x92A76C", Offset = "0x92A76C", VA = "0x92A76C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x92AB98", Offset = "0x92AB98", VA = "0x92AB98")]
		private void Update_ShakeVibration()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x92A7D0", Offset = "0x92A7D0", VA = "0x92A7D0")]
		private void Update_Shaking()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x92A854", Offset = "0x92A854", VA = "0x92A854")]
		private bool CheckShakeAnimationPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x92A91C", Offset = "0x92A91C", VA = "0x92A91C")]
		private void UpdateBothHands()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x92AC48", Offset = "0x92AC48", VA = "0x92AC48")]
		private void DetachHoneycomb()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x92A470", Offset = "0x92A470", VA = "0x92A470")]
		private void CalcGrabPos(Transform handTrans, Vector3 checkPos, GrabHand.SIDE side)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x92AD6C", Offset = "0x92AD6C", VA = "0x92AD6C")]
		private void FindNearTreeLinePos(Vector3 checkPos, out TreePoint startPoint, out TreePoint endPoint, out float rate)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x92AFC0", Offset = "0x92AFC0", VA = "0x92AFC0")]
		private static void ClosestPointPointAndSegment(Vector3 point, Vector3 segmentStart, Vector3 segmentEnd, out float t, out Vector3 closestPoint)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x92B054", Offset = "0x92B054", VA = "0x92B054")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x92B10C", Offset = "0x92B10C", VA = "0x92B10C")]
		private void DrawCircle(Vector3 center, float radius, int vertexNum)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x92B28C", Offset = "0x92B28C", VA = "0x92B28C")]
		private Vector3 CircleVertexPoint(float radius, float angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x92B310", Offset = "0x92B310", VA = "0x92B310")]
		public HoneyTree()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class IceAxe : MonoBehaviour
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OneShotVibrationParameter vibrationParameter;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x92B4EC", Offset = "0x92B4EC", VA = "0x92B4EC")]
		public void HitVibration()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x92B55C", Offset = "0x92B55C", VA = "0x92B55C")]
		public IceAxe()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class IceObstacle : MonoBehaviour
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string IceAxeName;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] differences;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ParticleAndSound hitParticle;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ParticleAndSound breakParticle;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int hitNum;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool isBroken;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityEvent onBreakedEvent;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x92B5DC", Offset = "0x92B5DC", VA = "0x92B5DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x92B658", Offset = "0x92B658", VA = "0x92B658")]
		private void Update()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x92B710", Offset = "0x92B710", VA = "0x92B710")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x9249FC", Offset = "0x9249FC", VA = "0x9249FC")]
		public void AddListner(UnityAction onBreaked)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x92B7C8", Offset = "0x92B7C8", VA = "0x92B7C8")]
		private void Hit(IceAxe iceAxe)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x92B85C", Offset = "0x92B85C", VA = "0x92B85C")]
		private void Break()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x92B5E0", Offset = "0x92B5E0", VA = "0x92B5E0")]
		private void ApplyVisual()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x92B8B8", Offset = "0x92B8B8", VA = "0x92B8B8")]
		public IceObstacle()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class Quest_Snap_Stone : MonoBehaviour
	{
		[Token(Token = "0x400042D")]
		private const string StoneName = "Throw_Stone";

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer renderer;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject throwingIcon;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ParticleAndSound effect;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityEvent OnSnapped;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isSnapped;

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xD035C8", Offset = "0xD035C8", VA = "0xD035C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xD035D0", Offset = "0xD035D0", VA = "0xD035D0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xD036E8", Offset = "0xD036E8", VA = "0xD036E8")]
		private void SnapStone(Quest_Throw_Stone stone)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xD037BC", Offset = "0xD037BC", VA = "0xD037BC")]
		private void Finish()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xD037FC", Offset = "0xD037FC", VA = "0xD037FC")]
		public void OnLoadSceneQuestCompleted()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xD0381C", Offset = "0xD0381C", VA = "0xD0381C")]
		public void AddListener(UnityAction OnSnapped)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xD03838", Offset = "0xD03838", VA = "0xD03838")]
		public Quest_Snap_Stone()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class Quest_Throw_Stone : MonoBehaviour
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int Field_Layer;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody physic;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Collider collider;

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xD038A8", Offset = "0xD038A8", VA = "0xD038A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xD039B8", Offset = "0xD039B8", VA = "0xD039B8")]
		public void OnCollisionEnter(Collision col)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xD03AB4", Offset = "0xD03AB4", VA = "0xD03AB4")]
		public void OnUngrab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xD03AD4", Offset = "0xD03AD4", VA = "0xD03AD4")]
		public Quest_Throw_Stone()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class Sponge : MonoBehaviour
	{
		[Token(Token = "0x4000437")]
		private const string DirtObjectName = "mud_dirt";

		[Token(Token = "0x4000438")]
		private const float Washing_Time = 1f;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Collider collider;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ParticleAndSound effect;

		[Token(Token = "0x17000061")]
		public bool IsGrabbed
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0xD0C48C", Offset = "0xD0C48C", VA = "0xD0C48C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xD0C4AC", Offset = "0xD0C4AC", VA = "0xD0C4AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xD0C590", Offset = "0xD0C590", VA = "0xD0C590")]
		private void OnGrab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xD0C5B0", Offset = "0xD0C5B0", VA = "0xD0C5B0")]
		private void OnUngrab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xD0C5D0", Offset = "0xD0C5D0", VA = "0xD0C5D0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xD0C68C", Offset = "0xD0C68C", VA = "0xD0C68C")]
		public Sponge()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class StoneGenerator : MonoBehaviour
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Grabbable stoneOriginal;

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xD0C970", Offset = "0xD0C970", VA = "0xD0C970")]
		private void Start()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xD0CA1C", Offset = "0xD0CA1C", VA = "0xD0CA1C")]
		private void OnGrab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xD0CABC", Offset = "0xD0CABC", VA = "0xD0CABC")]
		public StoneGenerator()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class TreeObstacle : MonoBehaviour
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string AxeName;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] differences;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] commons;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ParticleAndSound hitParticle;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleAndSound breakParticle;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int hitNum;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool isBroken;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityEvent onBreakedEvent;

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xD0E8DC", Offset = "0xD0E8DC", VA = "0xD0E8DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xD0E9A8", Offset = "0xD0E9A8", VA = "0xD0E9A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xD0EA58", Offset = "0xD0EA58", VA = "0xD0EA58")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xCFF904", Offset = "0xCFF904", VA = "0xCFF904")]
		public void AddListner(UnityAction onBreaked)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xD0EB10", Offset = "0xD0EB10", VA = "0xD0EB10")]
		private void Hit(WoodAxe axe)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xD0EBA0", Offset = "0xD0EBA0", VA = "0xD0EBA0")]
		private void Break()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xD0E8E0", Offset = "0xD0E8E0", VA = "0xD0E8E0")]
		private void ApplyVisual()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xD0EC68", Offset = "0xD0EC68", VA = "0xD0EC68")]
		public TreeObstacle()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class WaterDrop : MonoBehaviour
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject mainObj;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject splashObj;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody physic;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float maxLifeTime;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimalChara chick;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ChickQuestProgressManager questProgressManager;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool isSplashed;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 prevPos;

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xD101D0", Offset = "0xD101D0", VA = "0xD101D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xD10238", Offset = "0xD10238", VA = "0xD10238")]
		private void Update()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xD10450", Offset = "0xD10450", VA = "0xD10450")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xD10460", Offset = "0xD10460", VA = "0xD10460")]
		private void Splash()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xD10538", Offset = "0xD10538", VA = "0xD10538")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xD103BC", Offset = "0xD103BC", VA = "0xD103BC")]
		private static bool CollisionCapsuleAndPoint(Vector3 capsulePosA, Vector3 capsulePosB, float capsuleRadius, Vector3 point)
		{
			return default(bool);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xD10588", Offset = "0xD10588", VA = "0xD10588")]
		private static void ClosestPointPointAndSegment(Vector3 point, Vector3 segmentStart, Vector3 segmentEnd, out float t, out Vector3 closestPoint)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xD1061C", Offset = "0xD1061C", VA = "0xD1061C")]
		public WaterDrop()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class WoodAxe : MonoBehaviour
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OneShotVibrationParameter vibrationParameter;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xD0EBF8", Offset = "0xD0EBF8", VA = "0xD0EBF8")]
		public void HitVibration()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xD115A0", Offset = "0xD115A0", VA = "0xD115A0")]
		public WoodAxe()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class Bear01QuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x20000BC")]
		private enum State
		{
			[Token(Token = "0x4000459")]
			WaitFallHoneycomb,
			[Token(Token = "0x400045A")]
			ReadyEatFood
		}

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject treeIcon;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject animalIcon;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Food food;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HoneyTree honeyTree;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private State state;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xD1B2C4", Offset = "0xD1B2C4", VA = "0xD1B2C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xD1B3FC", Offset = "0xD1B3FC", VA = "0xD1B3FC")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xD1B4E0", Offset = "0xD1B4E0", VA = "0xD1B4E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xD1B518", Offset = "0xD1B518", VA = "0xD1B518")]
		private void Update_WaitFallHoneycomb()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xD1B5E0", Offset = "0xD1B5E0", VA = "0xD1B5E0")]
		private void ChangeState_ReadyEatFood()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xD1B55C", Offset = "0xD1B55C", VA = "0xD1B55C")]
		private void Update_ReadyEatFood()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xD1B658", Offset = "0xD1B658", VA = "0xD1B658")]
		private void CompletedQuest()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xD1B6EC", Offset = "0xD1B6EC", VA = "0xD1B6EC")]
		public Bear01QuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class Bear02QuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x400045B")]
		private const string IceAxeName = "Icepickaxe";

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject icon;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private IceObstacle obstacle;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject invisibleWall;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject iceAxe;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xD1B6F4", Offset = "0xD1B6F4", VA = "0xD1B6F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xD1B8D0", Offset = "0xD1B8D0", VA = "0xD1B8D0")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xD1B9C4", Offset = "0xD1B9C4", VA = "0xD1B9C4")]
		private void ActivationIceAxe()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xD1BA5C", Offset = "0xD1BA5C", VA = "0xD1BA5C")]
		private void OnBreakedObstacle()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xD1BAF0", Offset = "0xD1BAF0", VA = "0xD1BAF0")]
		public Bear02QuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class CapybaraQuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject questIcon;

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xD1CA84", Offset = "0xD1CA84", VA = "0xD1CA84")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xD1CBBC", Offset = "0xD1CBBC", VA = "0xD1CBBC")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xD1CC60", Offset = "0xD1CC60", VA = "0xD1CC60")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xD1CCC8", Offset = "0xD1CCC8", VA = "0xD1CCC8")]
		public CapybaraQuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class Cat01QuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject icon;

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xD1D00C", Offset = "0xD1D00C", VA = "0xD1D00C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xD1D144", Offset = "0xD1D144", VA = "0xD1D144")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xD1D1E8", Offset = "0xD1D1E8", VA = "0xD1D1E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xD1D24C", Offset = "0xD1D24C", VA = "0xD1D24C")]
		public Cat01QuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class Cat02QuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Quest_Snap_Stone[] snapPoints;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject stoneGenerator;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject questIcon;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject inivisibleWall;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform goalPoint;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int snapedCount;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool isBuiltBridge;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityEvent onCanCrossRoadAction;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xD1D254", Offset = "0xD1D254", VA = "0xD1D254")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xD1D2D4", Offset = "0xD1D2D4", VA = "0xD1D2D4")]
		private void Setup_Completed()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xD1D3BC", Offset = "0xD1D3BC", VA = "0xD1D3BC")]
		private void Setup_Quest()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xD1D4D4", Offset = "0xD1D4D4", VA = "0xD1D4D4")]
		public void OnSnapped()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xD1D510", Offset = "0xD1D510", VA = "0xD1D510")]
		private void OnBuiltBridge()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xD1D5AC", Offset = "0xD1D5AC", VA = "0xD1D5AC")]
		public static string Vector3ToString(Vector3 vec)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xD14E20", Offset = "0xD14E20", VA = "0xD14E20")]
		public static Vector3 StringToVector3(string str)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xD1D680", Offset = "0xD1D680", VA = "0xD1D680")]
		public Cat02QuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class ChickQuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x4000471")]
		private const int NeedDrinkNum = 3;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject icon;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject dropper;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int drinkNum;

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xD1D720", Offset = "0xD1D720", VA = "0xD1D720")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xD1D858", Offset = "0xD1D858", VA = "0xD1D858")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xD1D924", Offset = "0xD1D924", VA = "0xD1D924")]
		public void OnDrink()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xD1D9D8", Offset = "0xD1D9D8", VA = "0xD1D9D8")]
		private void Complete()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xD1DA74", Offset = "0xD1DA74", VA = "0xD1DA74")]
		public ChickQuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class ChinchillaQuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject nestIcon;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject animalIcon;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform nestPoint;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float nestRadius;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool exitNest;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xD1DCF4", Offset = "0xD1DCF4", VA = "0xD1DCF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xD1DE2C", Offset = "0xD1DE2C", VA = "0xD1DE2C")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xD1DEE8", Offset = "0xD1DEE8", VA = "0xD1DEE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xD1DF48", Offset = "0xD1DF48", VA = "0xD1DF48")]
		private void Update_CheckExitNest()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xD1E01C", Offset = "0xD1E01C", VA = "0xD1E01C")]
		private void FinishQuest()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xD1E070", Offset = "0xD1E070", VA = "0xD1E070")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xD1E11C", Offset = "0xD1E11C", VA = "0xD1E11C")]
		public ChinchillaQuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class Dog01QuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x400047E")]
		private const float PettingTime = 4f;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject icon;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float pettingTimer;

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xD22434", Offset = "0xD22434", VA = "0xD22434")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xD2256C", Offset = "0xD2256C", VA = "0xD2256C")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xD22610", Offset = "0xD22610", VA = "0xD22610")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xD226EC", Offset = "0xD226EC", VA = "0xD226EC")]
		public Dog01QuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class Dog02QuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x20000C5")]
		private enum STATE
		{
			[Token(Token = "0x400048E")]
			WAIT_START,
			[Token(Token = "0x400048F")]
			CAN_NOT_GET_DOWN,
			[Token(Token = "0x4000490")]
			CARRIED_TO_WARP,
			[Token(Token = "0x4000491")]
			WARP_TO_FINISH,
			[Token(Token = "0x4000492")]
			FINISHED
		}

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] questObjects;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject icon;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform finPlayerPos;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform finAnimalPos;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float fadeSpeed;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float fadeWait;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private STATE state;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float waitTimer;

		[Token(Token = "0x17000062")]
		private Player player
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xD226F4", Offset = "0xD226F4", VA = "0xD226F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xD2271C", Offset = "0xD2271C", VA = "0xD2271C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xD22854", Offset = "0xD22854", VA = "0xD22854")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xD22964", Offset = "0xD22964", VA = "0xD22964")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xD229AC", Offset = "0xD229AC", VA = "0xD229AC")]
		private void Update_CanNotGetDown()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xD22A6C", Offset = "0xD22A6C", VA = "0xD22A6C")]
		private void Update_CarriedToWarp()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xD22B10", Offset = "0xD22B10", VA = "0xD22B10")]
		private void Update_WarpToFinish()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xD22BEC", Offset = "0xD22BEC", VA = "0xD22BEC")]
		private void Warp()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xD22E18", Offset = "0xD22E18", VA = "0xD22E18")]
		private void Finish()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xD22E80", Offset = "0xD22E80", VA = "0xD22E80")]
		private Vector3 GroundPos(Vector3 startPos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xD22F4C", Offset = "0xD22F4C", VA = "0xD22F4C")]
		public Dog02QuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class DuckQuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x20000C7")]
		private enum STATE
		{
			[Token(Token = "0x400049E")]
			WAIT_CARRIED,
			[Token(Token = "0x400049F")]
			CARRYING,
			[Token(Token = "0x40004A0")]
			ON_ROWBOAT_TO_PIER,
			[Token(Token = "0x40004A1")]
			FINISHED
		}

		[Token(Token = "0x4000493")]
		private const string SeatParentName = "Rowboat";

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rowboat rowboat;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject questIcon;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image iconImage;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite carryIcon;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite boatIcon;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform seatPoint;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform pierExitPoint;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private STATE state;

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xD23298", Offset = "0xD23298", VA = "0xD23298")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xD23338", Offset = "0xD23338", VA = "0xD23338")]
		private void SetupQuest()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xD23508", Offset = "0xD23508", VA = "0xD23508")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xD23690", Offset = "0xD23690", VA = "0xD23690")]
		private void OnSeatedRowboat(Rowboat.DIRECTION direction)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xD237A0", Offset = "0xD237A0", VA = "0xD237A0")]
		private void OnExitRowboat(Rowboat.DIRECTION direction)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xD237C0", Offset = "0xD237C0", VA = "0xD237C0")]
		private void ChangeState_WaitCarried()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xD2354C", Offset = "0xD2354C", VA = "0xD2354C")]
		private void Update_WaitCarried()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xD23808", Offset = "0xD23808", VA = "0xD23808")]
		private void ChangeState_Carrying()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xD23594", Offset = "0xD23594", VA = "0xD23594")]
		private void Update_Carrying()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xD236AC", Offset = "0xD236AC", VA = "0xD236AC")]
		private void ChangeState_OnRowboatToPier()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xD235DC", Offset = "0xD235DC", VA = "0xD235DC")]
		private void Update_OnRowboatToPier()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xD237BC", Offset = "0xD237BC", VA = "0xD237BC")]
		private void ChangeState_Finished()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xD23854", Offset = "0xD23854", VA = "0xD23854")]
		private void Finish()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xD239BC", Offset = "0xD239BC", VA = "0xD239BC")]
		public DuckQuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class Fox01QuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject questIconObject;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image questIconImage;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite wholeAppleSprite;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite cutAppleSprite;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AppleTree appleTree;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform firstLookPoint;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x923F9C", Offset = "0x923F9C", VA = "0x923F9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x92414C", Offset = "0x92414C", VA = "0x92414C")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x92438C", Offset = "0x92438C", VA = "0x92438C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x9243D8", Offset = "0x9243D8", VA = "0x9243D8")]
		private void CompleteQuest()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x924418", Offset = "0x924418", VA = "0x924418")]
		private void OnPluckApple()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x9242B8", Offset = "0x9242B8", VA = "0x9242B8")]
		public static string Vector3ToString(Vector3 vec)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x92443C", Offset = "0x92443C", VA = "0x92443C")]
		public static Vector3 StringToVector3(string str)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x9245A8", Offset = "0x9245A8", VA = "0x9245A8")]
		public Fox01QuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class Fox02QuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x20000CA")]
		private enum State
		{
			[Token(Token = "0x40004B6")]
			WaitIceBreak,
			[Token(Token = "0x40004B7")]
			ReadyEatFood,
			[Token(Token = "0x40004B8")]
			Thanks
		}

		[Token(Token = "0x40004AA")]
		private const string IceAxeName = "Icepickaxe";

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject iceBreakIcon;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject foodIcon;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Food food;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private IceObstacle iceObstacle;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject questSnowHole;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject completedSnowCover;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject iceAxe;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private State state;

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x9245B0", Offset = "0x9245B0", VA = "0x9245B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x924744", Offset = "0x924744", VA = "0x924744")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x9247C4", Offset = "0x9247C4", VA = "0x9247C4")]
		private void Setup_CompletedQuest()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x924860", Offset = "0x924860", VA = "0x924860")]
		private void Setup_Quest()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x92496C", Offset = "0x92496C", VA = "0x92496C")]
		private void ActivationIceAxe()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x924A18", Offset = "0x924A18", VA = "0x924A18")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x924AD0", Offset = "0x924AD0", VA = "0x924AD0")]
		private void CompletedQuest()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x924B3C", Offset = "0x924B3C", VA = "0x924B3C")]
		private void OnBreakObstacle()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x924BC8", Offset = "0x924BC8", VA = "0x924BC8")]
		public Fox02QuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class OtterQuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject questIcon;

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xCFE450", Offset = "0xCFE450", VA = "0xCFE450")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xCFE588", Offset = "0xCFE588", VA = "0xCFE588")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xCFE62C", Offset = "0xCFE62C", VA = "0xCFE62C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xCFE694", Offset = "0xCFE694", VA = "0xCFE694")]
		public OtterQuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class PigQuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject icon;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TreeObstacle obstacleTree;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FallenTree fallenTree;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject invisibleWall;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject axe;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform goalPoint;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xCFF788", Offset = "0xCFF788", VA = "0xCFF788")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xCFF920", Offset = "0xCFF920", VA = "0xCFF920")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xCFF9A0", Offset = "0xCFF9A0", VA = "0xCFF9A0")]
		private void Setup_CompletedQuest()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xCFFA58", Offset = "0xCFFA58", VA = "0xCFFA58")]
		private void Setup_Quest()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xCFFAF0", Offset = "0xCFFAF0", VA = "0xCFFAF0")]
		private void OnBreakedObstacle()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xCFFBB8", Offset = "0xCFFBB8", VA = "0xCFFBB8")]
		private void OnFallenTree()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xCFFC28", Offset = "0xCFFC28", VA = "0xCFFC28")]
		public static string Vector3ToString(Vector3 vec)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xCFFCFC", Offset = "0xCFFCFC", VA = "0xCFFCFC")]
		public static Vector3 StringToVector3(string str)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xCFFE68", Offset = "0xCFFE68", VA = "0xCFFE68")]
		public PigQuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class Rabbit01QuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dirt[] dirt;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject questIcon;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject sponge;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int dirtCount;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xD05F74", Offset = "0xD05F74", VA = "0xD05F74")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xD060A4", Offset = "0xD060A4", VA = "0xD060A4")]
		private void Start_Quest()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xD05FF4", Offset = "0xD05FF4", VA = "0xD05FF4")]
		private void Start_IsCompletedQuest()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xD061B8", Offset = "0xD061B8", VA = "0xD061B8")]
		private void CompleteQuest()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xD06238", Offset = "0xD06238", VA = "0xD06238")]
		private void OnWashedDirt()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xD06254", Offset = "0xD06254", VA = "0xD06254")]
		public Rabbit01QuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class SealQuestProgressManager : MonoBehaviour
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MainGameScene mainGame;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimalChara animal;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject icon;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SnowObstacle obstacle;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xD098F0", Offset = "0xD098F0", VA = "0xD098F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xD09A88", Offset = "0xD09A88", VA = "0xD09A88")]
		private void OnStartScene()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xD09B5C", Offset = "0xD09B5C", VA = "0xD09B5C")]
		private void OnBreakedObstacle()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xD09BDC", Offset = "0xD09BDC", VA = "0xD09BDC")]
		public SealQuestProgressManager()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class QuestCompletedList : MonoBehaviour
	{
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly AnimalChara.AnimalKind[] QuestAnimalList;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] photos;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MainGameScene scene;

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xD031B4", Offset = "0xD031B4", VA = "0xD031B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xD0336C", Offset = "0xD0336C", VA = "0xD0336C")]
		private void OnStart()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xD03508", Offset = "0xD03508", VA = "0xD03508")]
		private void OnQuestCompleted(AnimalChara animal)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xD032E0", Offset = "0xD032E0", VA = "0xD032E0")]
		private void HidePhotos()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xD0341C", Offset = "0xD0341C", VA = "0xD0341C")]
		private void ApplyPhotosVisible()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xD0350C", Offset = "0xD0350C", VA = "0xD0350C")]
		public QuestCompletedList()
		{
		}
	}
}
namespace AnimalVR.Cultivation
{
	[Token(Token = "0x20000D0")]
	public class CultivationIcon : MonoBehaviour
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image iconRenderer;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite seedIcon;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite wateringIcon;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform planterPos;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image ballonRenderer;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float showDistance;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool isShowDistance;

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xD21418", Offset = "0xD21418", VA = "0xD21418")]
		private void Awake()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xD214D4", Offset = "0xD214D4", VA = "0xD214D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xD214D8", Offset = "0xD214D8", VA = "0xD214D8")]
		private void Update_Visible()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xD215E0", Offset = "0xD215E0", VA = "0xD215E0")]
		public void OnSeeded()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xD21618", Offset = "0xD21618", VA = "0xD21618")]
		public void OnRemovePlant()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xD21650", Offset = "0xD21650", VA = "0xD21650")]
		public void OnFullyGrownPlant()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xD2141C", Offset = "0xD2141C", VA = "0xD2141C")]
		private void ApplyRenderer()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xD21688", Offset = "0xD21688", VA = "0xD21688")]
		public CultivationIcon()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class Flower : MonoBehaviour
	{
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FlowerInfo.ID flowerID;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody physic;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ParticleAndSound particle;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool reserveVanish;

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x920F0C", Offset = "0x920F0C", VA = "0x920F0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x920FF0", Offset = "0x920FF0", VA = "0x920FF0")]
		private void OnGrab(GrabHand hand)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x920FF8", Offset = "0x920FF8", VA = "0x920FF8")]
		private void OnUngrab(GrabHand hand)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x921004", Offset = "0x921004", VA = "0x921004")]
		private void Update()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x921014", Offset = "0x921014", VA = "0x921014")]
		private void Vanish()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x921094", Offset = "0x921094", VA = "0x921094")]
		private void PlayEffect()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x9211A0", Offset = "0x9211A0", VA = "0x9211A0")]
		public void AchieveFlower()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x9212F8", Offset = "0x9212F8", VA = "0x9212F8")]
		public Flower()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D2")]
	public class FlowerInfo
	{
		[Token(Token = "0x20000D3")]
		public enum Kind
		{
			[Token(Token = "0x40004E0")]
			Cosmos,
			[Token(Token = "0x40004E1")]
			Tulip,
			[Token(Token = "0x40004E2")]
			Rose,
			[Token(Token = "0x40004E3")]
			Length
		}

		[Token(Token = "0x20000D4")]
		public enum ID
		{
			[Token(Token = "0x40004E5")]
			None = -1,
			[Token(Token = "0x40004E6")]
			Cosmos_Purple,
			[Token(Token = "0x40004E7")]
			Cosmos_Yellow,
			[Token(Token = "0x40004E8")]
			Cosmos_White,
			[Token(Token = "0x40004E9")]
			Cosmos_Red,
			[Token(Token = "0x40004EA")]
			Cosmos_Pink,
			[Token(Token = "0x40004EB")]
			Tulip_Purple,
			[Token(Token = "0x40004EC")]
			Tulip_Yellow,
			[Token(Token = "0x40004ED")]
			Tulip_White,
			[Token(Token = "0x40004EE")]
			Tulip_Red,
			[Token(Token = "0x40004EF")]
			Tulip_Pink,
			[Token(Token = "0x40004F0")]
			Rose_Purple,
			[Token(Token = "0x40004F1")]
			Rose_Blue,
			[Token(Token = "0x40004F2")]
			Rose_White,
			[Token(Token = "0x40004F3")]
			Rose_Red,
			[Token(Token = "0x40004F4")]
			Rose_Pink,
			[Token(Token = "0x40004F5")]
			Length
		}

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ID id;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject flowerObj;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite iconSprite;

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x921300", Offset = "0x921300", VA = "0x921300")]
		public Kind GetKind()
		{
			return default(Kind);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x9213B8", Offset = "0x9213B8", VA = "0x9213B8")]
		public FlowerInfo()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x43F214", Offset = "0x43F214")]
	public class FlowerSetting : ScriptableObject
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FlowerInfo[] flowerInfos;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x9213C0", Offset = "0x9213C0", VA = "0x9213C0")]
		public FlowerInfo Find(FlowerInfo.ID id)
		{
			return null;
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x921428", Offset = "0x921428", VA = "0x921428")]
		public FlowerSetting()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class FlowerVase : MonoBehaviour
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform putPoint;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject flower;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x441CC0", Offset = "0x441CC0")]
		private FlowerInfo <flowerInfo>k__BackingField;

		[Token(Token = "0x17000063")]
		public FlowerInfo flowerInfo
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x92197C", Offset = "0x92197C", VA = "0x92197C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443328", Offset = "0x443328")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x921984", Offset = "0x921984", VA = "0x921984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443338", Offset = "0x443338")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool HasFlower
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x92198C", Offset = "0x92198C", VA = "0x92198C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x9219F8", Offset = "0x9219F8", VA = "0x9219F8")]
		public void PutFlower(FlowerInfo info)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x921B28", Offset = "0x921B28", VA = "0x921B28")]
		public void DestroyFlower()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x921C20", Offset = "0x921C20", VA = "0x921C20")]
		public FlowerInfo.ID GetFlowerID()
		{
			return default(FlowerInfo.ID);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x921C38", Offset = "0x921C38", VA = "0x921C38")]
		public FlowerVase()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class GrowingPlant : MonoBehaviour
	{
		[Token(Token = "0x20000D8")]
		private enum STATE
		{
			[Token(Token = "0x4000508")]
			SEED,
			[Token(Token = "0x4000509")]
			BUD,
			[Token(Token = "0x400050A")]
			MEDIUM,
			[Token(Token = "0x400050B")]
			FLOWERING
		}

		[Token(Token = "0x40004FA")]
		private const float GrowRate_Bud_Min = 0f;

		[Token(Token = "0x40004FB")]
		private const float GrowRate_Bud_Max = 0.5f;

		[Token(Token = "0x40004FC")]
		private const float GrowRate_Medium_Min = 0.5f;

		[Token(Token = "0x40004FD")]
		private const float GrowRate_Medium_Max = 1f;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject budObj;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SkinnedMeshRenderer budMesh;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject mediumObj;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Grabbable[] floweringColorType;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Grabbable floweringObj;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float MediumScale_Min;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float MediumScale_Max;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float growRate;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Soil growingSoil;

		[Token(Token = "0x17000065")]
		public bool IsFullyGrown
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x9287A0", Offset = "0x9287A0", VA = "0x9287A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public bool IsGrowingSoil
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x9287B4", Offset = "0x9287B4", VA = "0x9287B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x928820", Offset = "0x928820", VA = "0x928820")]
		private void Update()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x928824", Offset = "0x928824", VA = "0x928824")]
		public void OnSoil(Soil soil)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x9288E4", Offset = "0x9288E4", VA = "0x9288E4")]
		private void SetFloweringColor()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x928AE4", Offset = "0x928AE4", VA = "0x928AE4")]
		public void Grow(float addGrowRate, bool isGrabbableWhenFullyGrown = true)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x928B38", Offset = "0x928B38", VA = "0x928B38")]
		public void GrowFully(bool isGrabbable)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x928B04", Offset = "0x928B04", VA = "0x928B04")]
		private void ApplyGrowVisual()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x928B44", Offset = "0x928B44", VA = "0x928B44")]
		private void ApplyGrowVisual_Seed()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x928BC0", Offset = "0x928BC0", VA = "0x928BC0")]
		private void ApplyGrowVisual_Bud()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x928C70", Offset = "0x928C70", VA = "0x928C70")]
		private void ApplyGrowVisual_Medium()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x928D5C", Offset = "0x928D5C", VA = "0x928D5C")]
		private void ApplyGrowVisual_FullGrown()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x928E80", Offset = "0x928E80", VA = "0x928E80")]
		private void OnGrab(GrabHand hand)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x928FDC", Offset = "0x928FDC", VA = "0x928FDC")]
		public GrowingPlant()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class RoomFlowerToggle : MonoBehaviour
	{
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject lockedObj;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image lockedImage;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject toggleObj;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle toggle;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image toggleImage;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TouchButton touchButton;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private OneShotVibrationParameter uiVibParam;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isUnlock;

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xD0683C", Offset = "0xD0683C", VA = "0xD0683C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xD068E0", Offset = "0xD068E0", VA = "0xD068E0")]
		public void Setup(bool isAchieved, Sprite sprite, UnityAction<bool> onChangeToggle)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xD069CC", Offset = "0xD069CC", VA = "0xD069CC")]
		public void SetIsOnWithoutNotify(bool isOn)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xD069EC", Offset = "0xD069EC", VA = "0xD069EC")]
		private void OnTouch(VR_Input.SIDE handSide)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xD06A5C", Offset = "0xD06A5C", VA = "0xD06A5C")]
		public RoomFlowerToggle()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class RoomVaseFlowerSelector : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F274", Offset = "0x43F274")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoomVaseFlowerSelector <>4__this;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int toggleNo;

			[Token(Token = "0x600053E")]
			[Address(RVA = "0xCCC910", Offset = "0xCCC910", VA = "0xCCC910")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0xCCC918", Offset = "0xCCC918", VA = "0xCCC918")]
			internal void <AddToggle>b__0(bool isOn)
			{
			}
		}

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoomFlowerToggle toggleOriginal;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform toggleParent;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<RoomFlowerToggle> toggles;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FlowerInfo[] flowerInfos;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int chooseFlower;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action<FlowerInfo.Kind, FlowerInfo> onChangeFlower;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FlowerInfo.Kind flowerKind;

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xD06ACC", Offset = "0xD06ACC", VA = "0xD06ACC")]
		public void Setup(FlowerInfo.Kind kind, FlowerInfo[] flowerInfos, Action<FlowerInfo.Kind, FlowerInfo> onChangeFlower)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xD06B64", Offset = "0xD06B64", VA = "0xD06B64")]
		private void AddToggle(FlowerInfo info)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xD06D54", Offset = "0xD06D54", VA = "0xD06D54")]
		private void OnChangeToggle(int no, bool isOn)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xD06E38", Offset = "0xD06E38", VA = "0xD06E38")]
		public void SetSelected(FlowerInfo.ID[] setSelects)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xD06F50", Offset = "0xD06F50", VA = "0xD06F50")]
		public RoomVaseFlowerSelector()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class RoomVaseManager : MonoBehaviour
	{
		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoomVaseUI ui;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FlowerSetting flowerSetting;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FlowerVase[] vase;

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xD06FDC", Offset = "0xD06FDC", VA = "0xD06FDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xD071D4", Offset = "0xD071D4", VA = "0xD071D4")]
		private void ApplyStartFlowers()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xD073A4", Offset = "0xD073A4", VA = "0xD073A4")]
		private void OnChooseFlower(FlowerInfo.Kind kind, FlowerInfo info)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xD072E4", Offset = "0xD072E4", VA = "0xD072E4")]
		private void InstantiateFlower(FlowerInfo.Kind vaseKind, FlowerInfo info)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xD073EC", Offset = "0xD073EC", VA = "0xD073EC")]
		private void DestroyFlower(FlowerInfo.Kind vaseKind)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xD07430", Offset = "0xD07430", VA = "0xD07430")]
		private void Record()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xD0753C", Offset = "0xD0753C", VA = "0xD0753C")]
		public RoomVaseManager()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class RoomVaseUI : MonoBehaviour
	{
		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F284", Offset = "0x43F284")]
		private sealed class <OpenMenuCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RoomVaseUI <>4__this;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000555")]
				[Address(RVA = "0xCCCCDC", Offset = "0xCCCCDC", VA = "0xCCCCDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000557")]
				[Address(RVA = "0xCCCD24", Offset = "0xCCCD24", VA = "0xCCCD24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0xCCCB30", Offset = "0xCCCB30", VA = "0xCCCB30")]
			[DebuggerHidden]
			public <OpenMenuCoroutine>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0xCCCB5C", Offset = "0xCCCB5C", VA = "0xCCCB5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0xCCCB60", Offset = "0xCCCB60", VA = "0xCCCB60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0xCCCCE4", Offset = "0xCCCCE4", VA = "0xCCCCE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F294", Offset = "0x43F294")]
		private sealed class <CloseMenuCoroutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RoomVaseUI <>4__this;

			[Token(Token = "0x17000069")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600055B")]
				[Address(RVA = "0xCCCAE0", Offset = "0xCCCAE0", VA = "0xCCCAE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600055D")]
				[Address(RVA = "0xCCCB28", Offset = "0xCCCB28", VA = "0xCCCB28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0xCCC944", Offset = "0xCCC944", VA = "0xCCC944")]
			[DebuggerHidden]
			public <CloseMenuCoroutine>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xCCC970", Offset = "0xCCC970", VA = "0xCCC970", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0xCCC974", Offset = "0xCCC974", VA = "0xCCC974", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0xCCCAE8", Offset = "0xCCCAE8", VA = "0xCCCAE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float ignoreInputTime;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TouchButton openButton;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TouchButton closeButton;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject menuRoot;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoomVaseFlowerSelector[] selectors;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioClip selectSE;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip openSE;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioClip closeSE;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LanguageTexts languageTexts;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private OneShotVibrationParameter uiVibParam;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool ignoreInput;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action<FlowerInfo.Kind, FlowerInfo> onChooseFlower;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xD075A4", Offset = "0xD075A4", VA = "0xD075A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xD07098", Offset = "0xD07098", VA = "0xD07098")]
		public void Setup(FlowerInfo[] infos, Action<FlowerInfo.Kind, FlowerInfo> onChooseFlower)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xD076E8", Offset = "0xD076E8", VA = "0xD076E8")]
		private FlowerInfo[] PickupFlowerKindInfos(FlowerInfo[] allInfos, FlowerInfo.Kind pickupKind)
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xD07814", Offset = "0xD07814", VA = "0xD07814")]
		private void OnChangeFlower(FlowerInfo.Kind kind, FlowerInfo chooseFlower)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xD078D4", Offset = "0xD078D4", VA = "0xD078D4")]
		private void OnTouchOpenButton(VR_Input.SIDE handSide)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xD079AC", Offset = "0xD079AC", VA = "0xD079AC")]
		private void OnTouchCloseButton(VR_Input.SIDE handSide)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xD07934", Offset = "0xD07934", VA = "0xD07934")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x443348", Offset = "0x443348")]
		private IEnumerator OpenMenuCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xD07A0C", Offset = "0xD07A0C", VA = "0xD07A0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4433A8", Offset = "0x4433A8")]
		private IEnumerator CloseMenuCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xD07A84", Offset = "0xD07A84", VA = "0xD07A84")]
		private void ApplyLanguage()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xD0732C", Offset = "0xD0732C", VA = "0xD0732C")]
		public void SetSelected(FlowerInfo.ID[] setSelects)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xD07B58", Offset = "0xD07B58", VA = "0xD07B58")]
		public RoomVaseUI()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class SeedBag : MonoBehaviour
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string AnmState_Opened;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string AnmState_Closed;

		[Token(Token = "0x4000534")]
		private const float AnmBlendTime = 0.5f;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SeedParticle seedParticleOriginal;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform direction;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float power;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float emitDot;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float emitRandomPos;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float emitRandomAngle;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float emitSpan;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int emitNum;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioClip seedEmitterSE;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float emitTimer;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SoundEffect3D se3d;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playingSE;

		[Token(Token = "0x1700006B")]
		public bool IsOpend
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xD09BE4", Offset = "0xD09BE4", VA = "0xD09BE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xD09C04", Offset = "0xD09C04", VA = "0xD09C04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xD09D50", Offset = "0xD09D50", VA = "0xD09D50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xD09DBC", Offset = "0xD09DBC", VA = "0xD09DBC")]
		private void Update_Emitter()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xD09E94", Offset = "0xD09E94", VA = "0xD09E94")]
		private void Emit()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xD09F08", Offset = "0xD09F08", VA = "0xD09F08")]
		private void EmitOne()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xD0A100", Offset = "0xD0A100", VA = "0xD0A100")]
		private void OnGrab(GrabHand grabHand)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xD0A180", Offset = "0xD0A180", VA = "0xD0A180")]
		private void OnUngrab(GrabHand ungrabHand)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xD0A200", Offset = "0xD0A200", VA = "0xD0A200")]
		public SeedBag()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x43F2A4", Offset = "0x43F2A4")]
	public class SeedParticle : MonoBehaviour
	{
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool isFlowerSeed;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject mainObj;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject splashObj;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isSplashed;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float maxLifeTime;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody rigidbody;

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xD0A2B8", Offset = "0xD0A2B8", VA = "0xD0A2B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xD0A340", Offset = "0xD0A340", VA = "0xD0A340")]
		private void Update()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xD0A3F4", Offset = "0xD0A3F4", VA = "0xD0A3F4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xD0A6C0", Offset = "0xD0A6C0", VA = "0xD0A6C0")]
		private void Splash()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xD0A798", Offset = "0xD0A798", VA = "0xD0A798")]
		public SeedParticle()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class Soil : MonoBehaviour
	{
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float BlendShape_Soil_Cover_Speed;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BlendShape_Grow_Speed;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkinnedMeshRenderer renderer;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string blendShapeName;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CultivationIcon cultivationIcon;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GrowingPlant[] flowerOriginals;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GrowingPlant radishOriginal;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float soilAmount;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int blendShapeNum;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GrowingPlant flowerInstance;

		[Token(Token = "0x1700006C")]
		public bool IsSeeded
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0xD0A4F0", Offset = "0xD0A4F0", VA = "0xD0A4F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xD0BB08", Offset = "0xD0BB08", VA = "0xD0BB08")]
		private void Start()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xD0BB5C", Offset = "0xD0BB5C", VA = "0xD0BB5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xD0A55C", Offset = "0xD0A55C", VA = "0xD0A55C")]
		public void SowSeed(bool isFlowerSeed)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xD0BC1C", Offset = "0xD0BC1C", VA = "0xD0BC1C")]
		public void Watering(float addGrowRate)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xD0BC84", Offset = "0xD0BC84", VA = "0xD0BC84")]
		public void RemovePlant(GrowingPlant flower)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xD0BD00", Offset = "0xD0BD00", VA = "0xD0BD00")]
		public void OnFullyGrownPlant()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xD0BD1C", Offset = "0xD0BD1C", VA = "0xD0BD1C")]
		public Soil()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x43F304", Offset = "0x43F304")]
	public class WaterParticle : MonoBehaviour
	{
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject mainObj;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject splashObj;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isSplashed;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float maxLifeTime;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float addGrowAmount;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody rigidbody;

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xD10638", Offset = "0xD10638", VA = "0xD10638")]
		private void Start()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xD106C0", Offset = "0xD106C0", VA = "0xD106C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xD10774", Offset = "0xD10774", VA = "0xD10774")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xD10854", Offset = "0xD10854", VA = "0xD10854")]
		private void Splash()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xD1092C", Offset = "0xD1092C", VA = "0xD1092C")]
		public WaterParticle()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class WateringPot : MonoBehaviour
	{
		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaterParticle waterParticleOriginal;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform direction;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float power;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float emitDot;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float emitRandomPos;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float emitRandomAngle;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float emitSpan;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int emitNum;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Grabbable grabbable;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip waterEmitterSE;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float emitTimer;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SoundEffect3D se3d;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool playingSE;

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xD10940", Offset = "0xD10940", VA = "0xD10940")]
		private void Start()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xD109C4", Offset = "0xD109C4", VA = "0xD109C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xD10A30", Offset = "0xD10A30", VA = "0xD10A30")]
		private void Update_Emitter()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xD10B08", Offset = "0xD10B08", VA = "0xD10B08")]
		private void Emit()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xD10B7C", Offset = "0xD10B7C", VA = "0xD10B7C")]
		private void EmitOne()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xD10D74", Offset = "0xD10D74", VA = "0xD10D74")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xD10E70", Offset = "0xD10E70", VA = "0xD10E70")]
		public WateringPot()
		{
		}
	}
}
namespace AnimalVR.Aquarium
{
	[Token(Token = "0x20000E5")]
	public class AquariumFishSelector : MonoBehaviour
	{
		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F364", Offset = "0x43F364")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AquariumFishSelector <>4__this;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int toggleNo;

			[Token(Token = "0x600058B")]
			[Address(RVA = "0xD11A1C", Offset = "0xD11A1C", VA = "0xD11A1C")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0xD11A24", Offset = "0xD11A24", VA = "0xD11A24")]
			internal void <AddToggle>b__0(bool isOn)
			{
			}
		}

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] FishTypeNames;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AquariumFishToggle toggleOriginal;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text text;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform toggleParent;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<AquariumFishToggle> toggles;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<FishInfo> typeFishInfos;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int selectableMax;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string fishTypeName;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<int> selectedFishes;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action<FishInfo[]> onChangeFishes;

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xD18074", Offset = "0xD18074", VA = "0xD18074")]
		public void Setup(FishInfo.Size type, FishInfo[] fishInfos, int selectableMax, Action<FishInfo[]> onChangeFishes)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xD18194", Offset = "0xD18194", VA = "0xD18194")]
		private void AddToggle(FishInfo info)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xD185B8", Offset = "0xD185B8", VA = "0xD185B8")]
		private void OnChangeToggle(int no, bool isOn)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xD183C0", Offset = "0xD183C0", VA = "0xD183C0")]
		private void ApplyText()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xD18770", Offset = "0xD18770", VA = "0xD18770")]
		private FishInfo[] ListupSelectedFishes()
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xD188D0", Offset = "0xD188D0", VA = "0xD188D0")]
		public Text[] GetFishNameTexts()
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xD18A00", Offset = "0xD18A00", VA = "0xD18A00")]
		public void SetSelected(FishInfo.Kind[] setSelects)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xD18BF0", Offset = "0xD18BF0", VA = "0xD18BF0")]
		public AquariumFishSelector()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class AquariumFishToggle : MonoBehaviour
	{
		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject lockedObj;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image lockedImage;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject toggleObj;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle toggle;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image toggleImage;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text nameText;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TouchButton touchButton;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private OneShotVibrationParameter vibrationParam;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isUnlock;

		[Token(Token = "0x1700006D")]
		public Text NameText
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xD18EB8", Offset = "0xD18EB8", VA = "0xD18EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xD18EC0", Offset = "0xD18EC0", VA = "0xD18EC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xD184AC", Offset = "0xD184AC", VA = "0xD184AC")]
		public void Setup(bool isAchieved, Sprite fishSprite, string fishName, UnityAction<bool> onChangeToggle)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xD18750", Offset = "0xD18750", VA = "0xD18750")]
		public void SetIsOnWithoutNotify(bool isOn)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xD18F68", Offset = "0xD18F68", VA = "0xD18F68")]
		private void OnTouch(VR_Input.SIDE handSide)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xD18FD8", Offset = "0xD18FD8", VA = "0xD18FD8")]
		public AquariumFishToggle()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class AquariumManager : MonoBehaviour
	{
		[Token(Token = "0x400057B")]
		public const int SlotNum_L = 1;

		[Token(Token = "0x400057C")]
		public const int SlotNum_M = 2;

		[Token(Token = "0x400057D")]
		public const int SlotNum_S = 3;

		[Token(Token = "0x400057E")]
		public const int SlotNum_All = 6;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AquariumUI ui;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FishSetting fishSetting;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FishCircularRoute[] routeL;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FishCircularRoute[] routeM;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FishCircularRoute[] routeS;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FishInfo.Kind[] recordL;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FishInfo.Kind[] recordM;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FishInfo.Kind[] recordS;

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xD19048", Offset = "0xD19048", VA = "0xD19048")]
		private void Start()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xD1930C", Offset = "0xD1930C", VA = "0xD1930C")]
		private void ApplyStartFishes()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xD195A0", Offset = "0xD195A0", VA = "0xD195A0")]
		private void OnSelectedTypeFishes(FishInfo.Size type, FishInfo[] selectedFishes)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xD1966C", Offset = "0xD1966C", VA = "0xD1966C")]
		private FishCircularRoute[] ChooseUseRoute(FishInfo.Size fishType)
		{
			return null;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xD196A4", Offset = "0xD196A4", VA = "0xD196A4")]
		private void Record()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xD198A4", Offset = "0xD198A4", VA = "0xD198A4")]
		public AquariumManager()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class AquariumUI : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F374", Offset = "0x43F374")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FishInfo.Size fishType;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AquariumUI <>4__this;

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xD11A50", Offset = "0xD11A50", VA = "0xD11A50")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xD11A58", Offset = "0xD11A58", VA = "0xD11A58")]
			internal void <Setup>b__0(FishInfo[] selectedFishes)
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F384", Offset = "0x43F384")]
		private sealed class <OpenMenuCoroutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AquariumUI <>4__this;

			[Token(Token = "0x1700006E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0xCCBE18", Offset = "0xCCBE18", VA = "0xCCBE18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0xCCBE60", Offset = "0xCCBE60", VA = "0xCCBE60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xCCBC8C", Offset = "0xCCBC8C", VA = "0xCCBC8C")]
			[DebuggerHidden]
			public <OpenMenuCoroutine>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xCCBCB8", Offset = "0xCCBCB8", VA = "0xCCBCB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xCCBCBC", Offset = "0xCCBCBC", VA = "0xCCBCBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xCCBE20", Offset = "0xCCBE20", VA = "0xCCBE20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F394", Offset = "0x43F394")]
		private sealed class <CloseMenuCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AquariumUI <>4__this;

			[Token(Token = "0x17000070")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0xD11C00", Offset = "0xD11C00", VA = "0xD11C00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0xD11C48", Offset = "0xD11C48", VA = "0xD11C48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xD11A80", Offset = "0xD11A80", VA = "0xD11A80")]
			[DebuggerHidden]
			public <CloseMenuCoroutine>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xD11AAC", Offset = "0xD11AAC", VA = "0xD11AAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xD11AB0", Offset = "0xD11AB0", VA = "0xD11AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xD11C08", Offset = "0xD11C08", VA = "0xD11C08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float ignoreInputTime;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject menuRoot;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TouchButton openButton;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TouchButton closeButton;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AquariumFishSelector[] selectors;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int[] fishSelectableMax;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip menuOpenAudioClip;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioClip menuCloseAudioClip;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip selectAudioClip;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LanguageTexts languageTexts;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private OneShotVibrationParameter uiVibParam;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool ignoreInput;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action<FishInfo.Size, FishInfo[]> onChangeTypeFishes;

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xD199AC", Offset = "0xD199AC", VA = "0xD199AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xD19104", Offset = "0xD19104", VA = "0xD19104")]
		public void Setup(FishInfo[] infos, Action<FishInfo.Size, FishInfo[]> onChangeTypeFishes)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xD19AD8", Offset = "0xD19AD8", VA = "0xD19AD8")]
		private void ApplyLanguage()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xD19BAC", Offset = "0xD19BAC", VA = "0xD19BAC")]
		private void OnChangeTypeFishes(FishInfo.Size fishType, FishInfo[] selectedFishes)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xD19C6C", Offset = "0xD19C6C", VA = "0xD19C6C")]
		private void OnTouchOpenButton(VR_Input.SIDE handSide)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xD19D44", Offset = "0xD19D44", VA = "0xD19D44")]
		private void OnTouchCloseButton(VR_Input.SIDE handSide)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xD19CCC", Offset = "0xD19CCC", VA = "0xD19CCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4434A8", Offset = "0x4434A8")]
		private IEnumerator OpenMenuCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xD19DA4", Offset = "0xD19DA4", VA = "0xD19DA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x443508", Offset = "0x443508")]
		private IEnumerator CloseMenuCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xD19528", Offset = "0xD19528", VA = "0xD19528")]
		public void SetSelected(FishInfo.Kind[] startFishes)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xD19E1C", Offset = "0xD19E1C", VA = "0xD19E1C")]
		public AquariumUI()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class FishCircularRoute : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EE")]
		private class FishParameter
		{
			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform fish;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4422D0", Offset = "0x4422D0")]
			public float routeOffset;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 posOffset;

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xCCC034", Offset = "0xCCC034", VA = "0xCCC034")]
			public FishParameter()
			{
			}
		}

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] points;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FishParameter[] fishParams;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x442280", Offset = "0x442280")]
		private float startSwimOffset;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RNS spline;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FishInfo fishInfo;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int MoveAnimationState;

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x91D5BC", Offset = "0x91D5BC", VA = "0x91D5BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x91D6B0", Offset = "0x91D6B0", VA = "0x91D6B0")]
		public void ApplyFish(FishInfo info)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x91D8C4", Offset = "0x91D8C4", VA = "0x91D8C4")]
		private void InstantiateFish(FishInfo info)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x91DA28", Offset = "0x91DA28", VA = "0x91DA28")]
		private void StartFisheAnimation(GameObject fishObj)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x91D6EC", Offset = "0x91D6EC", VA = "0x91D6EC")]
		private void DestroyFish()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x91DB40", Offset = "0x91DB40", VA = "0x91DB40")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x91DC2C", Offset = "0x91DC2C", VA = "0x91DC2C")]
		private static void SwimFish(FishParameter fishParam, RNS spline, float swimRate)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x91D5C0", Offset = "0x91D5C0", VA = "0x91D5C0")]
		private void CreateRouteSpline()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x91DDF4", Offset = "0x91DDF4", VA = "0x91DDF4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x91DECC", Offset = "0x91DECC", VA = "0x91DECC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x91DED8", Offset = "0x91DED8", VA = "0x91DED8")]
		private void DrawSpline(RNS spline, int splitNum)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x91E020", Offset = "0x91E020", VA = "0x91E020")]
		public FishInfo.Kind GetSwimingFishKind()
		{
			return default(FishInfo.Kind);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x91E038", Offset = "0x91E038", VA = "0x91E038")]
		public FishCircularRoute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EF")]
	public class FishInfo
	{
		[Token(Token = "0x20000F0")]
		public enum Kind
		{
			[Token(Token = "0x40005AD")]
			None = -1,
			[Token(Token = "0x40005AE")]
			Coelacanth,
			[Token(Token = "0x40005AF")]
			Pirarucu,
			[Token(Token = "0x40005B0")]
			Shark,
			[Token(Token = "0x40005B1")]
			Salmon,
			[Token(Token = "0x40005B2")]
			Angelfish,
			[Token(Token = "0x40005B3")]
			Sardine,
			[Token(Token = "0x40005B4")]
			Smelt,
			[Token(Token = "0x40005B5")]
			Goldfish,
			[Token(Token = "0x40005B6")]
			HoneyGourami,
			[Token(Token = "0x40005B7")]
			NeonTetra,
			[Token(Token = "0x40005B8")]
			Globefish,
			[Token(Token = "0x40005B9")]
			Clownfish,
			[Token(Token = "0x40005BA")]
			Jellyfish,
			[Token(Token = "0x40005BB")]
			Length
		}

		[Token(Token = "0x20000F1")]
		public enum Size
		{
			[Token(Token = "0x40005BD")]
			L,
			[Token(Token = "0x40005BE")]
			M,
			[Token(Token = "0x40005BF")]
			S
		}

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Kind kind;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Size size;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string fishName;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject fishObj;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sprite iconSprite;

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x91E11C", Offset = "0x91E11C", VA = "0x91E11C")]
		public FishInfo()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x43F3A4", Offset = "0x43F3A4")]
	public class FishSetting : ScriptableObject
	{
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FishInfo[] fishInfos;

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x91E124", Offset = "0x91E124", VA = "0x91E124")]
		public FishInfo Find(FishInfo.Kind kind)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x91E18C", Offset = "0x91E18C", VA = "0x91E18C")]
		public FishSetting()
		{
		}
	}
}
namespace AnimalVR.Animal
{
	[Token(Token = "0x20000F3")]
	public class AnimalAnimation
	{
		[Token(Token = "0x40005C1")]
		private const string HeadLayerName = "Head";

		[Token(Token = "0x40005C2")]
		private const string MouthLayerName = "Mouth";

		[Token(Token = "0x40005C3")]
		private const string TailLayerName = "Tail";

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int AnmState_Stand;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int AnmState_Stand_act_01;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int AnmState_Sit;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int AnmState_Sit_act_01;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int AnmState_Sit_act_02;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int AnmState_Prone;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int AnmState_Eat;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AnmState_MouthEat;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int AnmState_Sleep_In;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int AnmState_Sleep;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int AnmState_Sleep_Out;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int AnmState_Spoil_Up;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int AnmState_Carried;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int AnmState_HoldItemIn;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int AnmState_HoldItemOut;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int AnmState_Fall;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly int[,] IdleAnmTransition;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Animator animator;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4422E8", Offset = "0x4422E8")]
		private int <BaseLayer>k__BackingField;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4422F8", Offset = "0x4422F8")]
		private int <HeadLayer>k__BackingField;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442308", Offset = "0x442308")]
		private int <TailLayer>k__BackingField;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442318", Offset = "0x442318")]
		private int <MouthLayer>k__BackingField;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int[] previousAnmHashes;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int[] currentAnmHashes;

		[Token(Token = "0x17000072")]
		public int BaseLayer
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xD2BF80", Offset = "0xD2BF80", VA = "0xD2BF80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443608", Offset = "0x443608")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xD2BF88", Offset = "0xD2BF88", VA = "0xD2BF88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443618", Offset = "0x443618")]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public int HeadLayer
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xD2BF90", Offset = "0xD2BF90", VA = "0xD2BF90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443628", Offset = "0x443628")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xD2BF98", Offset = "0xD2BF98", VA = "0xD2BF98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443638", Offset = "0x443638")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public int TailLayer
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xD2BFA0", Offset = "0xD2BFA0", VA = "0xD2BFA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443648", Offset = "0x443648")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xD2BFA8", Offset = "0xD2BFA8", VA = "0xD2BFA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443658", Offset = "0x443658")]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public int MouthLayer
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xD2BFB0", Offset = "0xD2BFB0", VA = "0xD2BFB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443668", Offset = "0x443668")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xD2BFB8", Offset = "0xD2BFB8", VA = "0xD2BFB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443678", Offset = "0x443678")]
			private set
			{
			}
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xD2BFC0", Offset = "0xD2BFC0", VA = "0xD2BFC0")]
		public AnimalAnimation(Animator animator)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xD2C180", Offset = "0xD2C180", VA = "0xD2C180")]
		public void PlayAnimation(int animeHash, float anmBlendTime = 0f)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xD2C1A8", Offset = "0xD2C1A8", VA = "0xD2C1A8")]
		public void PlayAnimation(int animeHash, int layer, float anmBlendTime = 0f)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xD2C1D0", Offset = "0xD2C1D0", VA = "0xD2C1D0")]
		public void PlayIdleAnimation(float anmBlendTime = 0f)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xD2C3D0", Offset = "0xD2C3D0", VA = "0xD2C3D0")]
		public void SetLayerWeight(int layer, float weight)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xD2C3EC", Offset = "0xD2C3EC", VA = "0xD2C3EC")]
		public float GetLayerWeight(int layer)
		{
			return default(float);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xD2C408", Offset = "0xD2C408", VA = "0xD2C408")]
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layer)
		{
			return default(AnimatorStateInfo);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xD2C458", Offset = "0xD2C458", VA = "0xD2C458")]
		public bool IsInTransition(int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xD2C474", Offset = "0xD2C474", VA = "0xD2C474")]
		public bool CheckPreviousState(int layer, int shortNameHash)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xD2C4B8", Offset = "0xD2C4B8", VA = "0xD2C4B8")]
		public bool CheckCurrentState(int layer, int shortNameHash)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xD2C4FC", Offset = "0xD2C4FC", VA = "0xD2C4FC")]
		public int GetCurrentAnmHash(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xD2C208", Offset = "0xD2C208", VA = "0xD2C208")]
		public int CheckIdleAnimation()
		{
			return default(int);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xD2C538", Offset = "0xD2C538", VA = "0xD2C538")]
		public void SetFloat(int paramID, float paramValue)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xD2C554", Offset = "0xD2C554", VA = "0xD2C554")]
		public float GetPlayAnimationTime(int layer)
		{
			return default(float);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xD2C5B0", Offset = "0xD2C5B0", VA = "0xD2C5B0")]
		public void OnAnimatorStateEnter(int layer, int enterAnmHash)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xD2C5EC", Offset = "0xD2C5EC", VA = "0xD2C5EC")]
		public void OnAnimatorStateExit(int layer, int exitAnmHash)
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x43F404", Offset = "0x43F404")]
	public class AnimalAnimationSetting : ScriptableObject
	{
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool EnableSit;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool EnableProne;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool EnableStandUp;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] StandActs;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] SitActs;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] ProneActs;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string ReadyToEatOnHand;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimalMoveSpeed Speed;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xD2CCE8", Offset = "0xD2CCE8", VA = "0xD2CCE8")]
		public AnimalAnimationSetting()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class AnimalBallHolder
	{
		[Token(Token = "0x40005E4")]
		private const float RaycastHeight = 0.5f;

		[Token(Token = "0x40005E5")]
		private const float RaycastMaxDistance = 10f;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int layerMask;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara owner;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform ballHoldTrans;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442328", Offset = "0x442328")]
		private Ball <HoldingBall>k__BackingField;

		[Token(Token = "0x17000076")]
		public Ball HoldingBall
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xD2CF2C", Offset = "0xD2CF2C", VA = "0xD2CF2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443688", Offset = "0x443688")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xD2CF34", Offset = "0xD2CF34", VA = "0xD2CF34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443698", Offset = "0x443698")]
			private set
			{
			}
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xD2CF3C", Offset = "0xD2CF3C", VA = "0xD2CF3C")]
		public AnimalBallHolder(AnimalChara owner, Transform ballHoldTrans)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xD2CF8C", Offset = "0xD2CF8C", VA = "0xD2CF8C")]
		public void HoldBall(Ball ball)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xD2CFC8", Offset = "0xD2CFC8", VA = "0xD2CFC8")]
		public bool IsHolding()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xD2D034", Offset = "0xD2D034", VA = "0xD2D034")]
		public void ReleaseBall()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class AnimalChara : MonoBehaviour
	{
		[Token(Token = "0x20000F7")]
		public enum StanceType
		{
			[Token(Token = "0x4000616")]
			None = -1,
			[Token(Token = "0x4000617")]
			Stand,
			[Token(Token = "0x4000618")]
			Sit,
			[Token(Token = "0x4000619")]
			Prone,
			[Token(Token = "0x400061A")]
			Standup,
			[Token(Token = "0x400061B")]
			Length
		}

		[Token(Token = "0x20000F8")]
		public enum MessageType
		{
			[Token(Token = "0x400061D")]
			SetupQuest,
			[Token(Token = "0x400061E")]
			ProgressQuest,
			[Token(Token = "0x400061F")]
			CompleteQuestCondition
		}

		[Token(Token = "0x20000F9")]
		public enum AnimalKind
		{
			[Token(Token = "0x4000621")]
			Unknown = -1,
			[Token(Token = "0x4000622")]
			Bear01,
			[Token(Token = "0x4000623")]
			Bear02,
			[Token(Token = "0x4000624")]
			Capybara,
			[Token(Token = "0x4000625")]
			Cat01,
			[Token(Token = "0x4000626")]
			Cat02,
			[Token(Token = "0x4000627")]
			Chick,
			[Token(Token = "0x4000628")]
			Chinchilla,
			[Token(Token = "0x4000629")]
			Dog01,
			[Token(Token = "0x400062A")]
			Dog02,
			[Token(Token = "0x400062B")]
			Duck,
			[Token(Token = "0x400062C")]
			Fox01,
			[Token(Token = "0x400062D")]
			Fox02,
			[Token(Token = "0x400062E")]
			Otters,
			[Token(Token = "0x400062F")]
			Penguin,
			[Token(Token = "0x4000630")]
			Pig,
			[Token(Token = "0x4000631")]
			Rabbit01,
			[Token(Token = "0x4000632")]
			Rabbit02,
			[Token(Token = "0x4000633")]
			Seal,
			[Token(Token = "0x4000634")]
			Length
		}

		[Token(Token = "0x40005EA")]
		private const float FullStomachTime = 30f;

		[Token(Token = "0x40005EB")]
		private const string HandColliderName_L = "LeftHandRoot";

		[Token(Token = "0x40005EC")]
		private const string HandColliderName_R = "RightHandRoot";

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimalKind kind;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform eyeTrans;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform mouthTrans;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform ballHoldTrans;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SkinnedMeshRenderer eyelidBlendShape;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimalLookHead headLook;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LookAtRotator eyeLook;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject pettingEffect;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CharacterController characterController;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AnimalBallHolder ballHolder;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AnimalEyesightManager eyesight;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4423E8", Offset = "0x4423E8")]
		private bool <IsSetuped>k__BackingField;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4423F8", Offset = "0x4423F8")]
		private AnimalAnimation <Animation>k__BackingField;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442408", Offset = "0x442408")]
		private AnimalBrain <AI>k__BackingField;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442418", Offset = "0x442418")]
		private AnimalCommand <Command>k__BackingField;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442428", Offset = "0x442428")]
		private AnimalActionManager <Action>k__BackingField;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442438", Offset = "0x442438")]
		private MainGameManager <MainGame>k__BackingField;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442448", Offset = "0x442448")]
		private AnimalLookManager <Look>k__BackingField;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442458", Offset = "0x442458")]
		private PettingManager <Petting>k__BackingField;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442468", Offset = "0x442468")]
		private CarriedManager <Carried>k__BackingField;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442478", Offset = "0x442478")]
		private AIMover <Mover>k__BackingField;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442488", Offset = "0x442488")]
		private AnimalEyelidManager <Eyelid>k__BackingField;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442498", Offset = "0x442498")]
		private AnimalMouthSoundManager <MouthSound>k__BackingField;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4424A8", Offset = "0x4424A8")]
		private AnimalLimbsSoundManager <LimbsSound>k__BackingField;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4424B8", Offset = "0x4424B8")]
		private bool <IsQuestNow>k__BackingField;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4424C8", Offset = "0x4424C8")]
		private bool <ApplyRootMotion>k__BackingField;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4424D8", Offset = "0x4424D8")]
		private StanceType <Stance>k__BackingField;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private AnimalAnimationSetting animationSetting;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Vector3 MouthOffset_EatOnHand;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public Vector3 MouthOffset_EatOnDish;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float EatAreaRadius;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float EatOnHandLookPitchOffset;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public float CarriedLookPitchOffset;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private MouthSoundScriptableObject mouthSound;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private LimbsSoundScriptableObject limbsSound;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private FindableElement findableElement;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float fullStomachTimer;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public List<Food.Kind> edibleFoodKinds;

		[Token(Token = "0x17000077")]
		public bool IsSetuped
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0xD32A70", Offset = "0xD32A70", VA = "0xD32A70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4436A8", Offset = "0x4436A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xD32A78", Offset = "0xD32A78", VA = "0xD32A78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4436B8", Offset = "0x4436B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public AnimalKind Kind
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xD32A84", Offset = "0xD32A84", VA = "0xD32A84")]
			get
			{
				return default(AnimalKind);
			}
		}

		[Token(Token = "0x17000079")]
		public AnimalAnimation Animation
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xD32A8C", Offset = "0xD32A8C", VA = "0xD32A8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4436C8", Offset = "0x4436C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xD32A94", Offset = "0xD32A94", VA = "0xD32A94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4436D8", Offset = "0x4436D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public AnimalBrain AI
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xD32A9C", Offset = "0xD32A9C", VA = "0xD32A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4436E8", Offset = "0x4436E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xD32AA4", Offset = "0xD32AA4", VA = "0xD32AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4436F8", Offset = "0x4436F8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public AnimalCommand Command
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xD32AAC", Offset = "0xD32AAC", VA = "0xD32AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443708", Offset = "0x443708")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xD32AB4", Offset = "0xD32AB4", VA = "0xD32AB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443718", Offset = "0x443718")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public AnimalActionManager Action
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xD32ABC", Offset = "0xD32ABC", VA = "0xD32ABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443728", Offset = "0x443728")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xD32AC4", Offset = "0xD32AC4", VA = "0xD32AC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443738", Offset = "0x443738")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public MainGameManager MainGame
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xD32ACC", Offset = "0xD32ACC", VA = "0xD32ACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443748", Offset = "0x443748")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xD32AD4", Offset = "0xD32AD4", VA = "0xD32AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443758", Offset = "0x443758")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public AnimalLookManager Look
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xD32ADC", Offset = "0xD32ADC", VA = "0xD32ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443768", Offset = "0x443768")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xD32AE4", Offset = "0xD32AE4", VA = "0xD32AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443778", Offset = "0x443778")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public PettingManager Petting
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xD32AEC", Offset = "0xD32AEC", VA = "0xD32AEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443788", Offset = "0x443788")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xD32AF4", Offset = "0xD32AF4", VA = "0xD32AF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443798", Offset = "0x443798")]
			private set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public CarriedManager Carried
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xD32AFC", Offset = "0xD32AFC", VA = "0xD32AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4437A8", Offset = "0x4437A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xD32B04", Offset = "0xD32B04", VA = "0xD32B04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4437B8", Offset = "0x4437B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public Transform MouthTransform
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xD32B0C", Offset = "0xD32B0C", VA = "0xD32B0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public AIMover Mover
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xD32B14", Offset = "0xD32B14", VA = "0xD32B14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4437C8", Offset = "0x4437C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xD32B1C", Offset = "0xD32B1C", VA = "0xD32B1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4437D8", Offset = "0x4437D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public AnimalEyelidManager Eyelid
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xD32B24", Offset = "0xD32B24", VA = "0xD32B24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4437E8", Offset = "0x4437E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xD32B2C", Offset = "0xD32B2C", VA = "0xD32B2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4437F8", Offset = "0x4437F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public AnimalMouthSoundManager MouthSound
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xD32B34", Offset = "0xD32B34", VA = "0xD32B34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443808", Offset = "0x443808")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xD32B3C", Offset = "0xD32B3C", VA = "0xD32B3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443818", Offset = "0x443818")]
			private set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public AnimalLimbsSoundManager LimbsSound
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xD32B44", Offset = "0xD32B44", VA = "0xD32B44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443828", Offset = "0x443828")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xD32B4C", Offset = "0xD32B4C", VA = "0xD32B4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443838", Offset = "0x443838")]
			private set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool IsQuestNow
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0xD32B54", Offset = "0xD32B54", VA = "0xD32B54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443848", Offset = "0x443848")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000601")]
			[Address(RVA = "0xD32B5C", Offset = "0xD32B5C", VA = "0xD32B5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443858", Offset = "0x443858")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public bool ApplyRootMotion
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0xD32B68", Offset = "0xD32B68", VA = "0xD32B68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443868", Offset = "0x443868")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xD32B70", Offset = "0xD32B70", VA = "0xD32B70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443878", Offset = "0x443878")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public StanceType Stance
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0xD32B7C", Offset = "0xD32B7C", VA = "0xD32B7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443888", Offset = "0x443888")]
			get
			{
				return default(StanceType);
			}
			[Token(Token = "0x6000605")]
			[Address(RVA = "0xD32B84", Offset = "0xD32B84", VA = "0xD32B84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443898", Offset = "0x443898")]
			private set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public Vector3 BallHoldPos
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xD32B8C", Offset = "0xD32B8C", VA = "0xD32B8C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008A")]
		public bool CanHoldBall
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xD278C4", Offset = "0xD278C4", VA = "0xD278C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public AnimalAnimationSetting AnimationSetting
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0xD32C20", Offset = "0xD32C20", VA = "0xD32C20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public bool IsFullStomach
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0xD278B4", Offset = "0xD278B4", VA = "0xD278B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xD32C28", Offset = "0xD32C28", VA = "0xD32C28")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xD32CF0", Offset = "0xD32CF0", VA = "0xD32CF0")]
		public void SetupMainGame(MainGameManager mainGame)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xD335E0", Offset = "0xD335E0", VA = "0xD335E0")]
		private void SetupNormalAnimal()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xD338B8", Offset = "0xD338B8", VA = "0xD338B8")]
		private void SetUpAnimalNormalAI()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xD33604", Offset = "0xD33604", VA = "0xD33604")]
		private void SetupEdibleFoodKinds()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xD3391C", Offset = "0xD3391C", VA = "0xD3391C")]
		private static bool IsEdibleBigFood(AnimalKind animalKind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xD33940", Offset = "0xD33940", VA = "0xD33940")]
		private static bool IsEdibleLittleFood(AnimalKind animalKind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xD339A4", Offset = "0xD339A4", VA = "0xD339A4")]
		private static bool IsEdibleFeedingBottle(AnimalKind animalKind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xD33960", Offset = "0xD33960", VA = "0xD33960")]
		private static bool IsEdibleFish(AnimalKind animalKind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xD339B0", Offset = "0xD339B0", VA = "0xD339B0")]
		private static bool IsEdibleRadish(AnimalKind animalKind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xD339E4", Offset = "0xD339E4", VA = "0xD339E4")]
		public bool CheckEdible(Food.Kind foodKind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xD337C8", Offset = "0xD337C8", VA = "0xD337C8")]
		private void PlaceRandomFavoritePlace()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xD33A48", Offset = "0xD33A48", VA = "0xD33A48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xD33D98", Offset = "0xD33D98", VA = "0xD33D98")]
		private void UpdateStomach()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xD33DD8", Offset = "0xD33DD8", VA = "0xD33DD8")]
		public void Message(MessageType type, string option = "")
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xD33E2C", Offset = "0xD33E2C", VA = "0xD33E2C")]
		public void FinishAnimalQuest()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xD33F50", Offset = "0xD33F50", VA = "0xD33F50")]
		public Vector3[] GetAttentionPoints()
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xD2F1BC", Offset = "0xD2F1BC", VA = "0xD2F1BC")]
		public void SetStance(StanceType stance)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xD33FE0", Offset = "0xD33FE0", VA = "0xD33FE0")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xD34150", Offset = "0xD34150", VA = "0xD34150")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xD34254", Offset = "0xD34254", VA = "0xD34254")]
		public Transform GetMouthTransform()
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xD3425C", Offset = "0xD3425C", VA = "0xD3425C")]
		public void OnRemoveFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xD29454", Offset = "0xD29454", VA = "0xD29454")]
		public bool TryGetAttentionPoint(ref Vector3 lookPos)
		{
			return default(bool);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xD27930", Offset = "0xD27930", VA = "0xD27930")]
		public FindableElement SearchInEyesightFromPriority(FindableElement.Kind[] findPriority)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xD3430C", Offset = "0xD3430C", VA = "0xD3430C")]
		public FindableElement SearchInEyesightFromFunction(Func<FindableElement, bool> function)
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xD2E9C8", Offset = "0xD2E9C8", VA = "0xD2E9C8")]
		public void HoldBall(Ball ball)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xD2ED14", Offset = "0xD2ED14", VA = "0xD2ED14")]
		public bool IsHoldingBall()
		{
			return default(bool);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xD2ED2C", Offset = "0xD2ED2C", VA = "0xD2ED2C")]
		public void ReleaseBall()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xD2DC20", Offset = "0xD2DC20", VA = "0xD2DC20")]
		public void OnEatFinish()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xD33370", Offset = "0xD33370", VA = "0xD33370")]
		private void SetupQuestAnimal()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xD34350", Offset = "0xD34350", VA = "0xD34350")]
		private void SetupQuestAnimal_Cat01()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xD3445C", Offset = "0xD3445C", VA = "0xD3445C")]
		private void SetupQuestAnimal_Cat02()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xD346C8", Offset = "0xD346C8", VA = "0xD346C8")]
		private void SetupQuestAnimal_Capybara()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xD34568", Offset = "0xD34568", VA = "0xD34568")]
		private void SetupQuestAnimal_Chick()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xD347D4", Offset = "0xD347D4", VA = "0xD347D4")]
		private void SetupQuestAnimal_Dog01()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xD348F4", Offset = "0xD348F4", VA = "0xD348F4")]
		private void SetupQuestAnimal_Dog02()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xD34A24", Offset = "0xD34A24", VA = "0xD34A24")]
		private void SetupQuestAnimal_Duck()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xD34DA0", Offset = "0xD34DA0", VA = "0xD34DA0")]
		private void SetupQuestAnimal_Fox02()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xD34AA4", Offset = "0xD34AA4", VA = "0xD34AA4")]
		private void SetupQuestAnimal_Penguin()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xD34B24", Offset = "0xD34B24", VA = "0xD34B24")]
		private void SetupQuestAnimal_Rabbit01()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xD34C30", Offset = "0xD34C30", VA = "0xD34C30")]
		private void SetupQuestAnimal_Rabbit02()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xD34EAC", Offset = "0xD34EAC", VA = "0xD34EAC")]
		private void SetupQuestAnimal_Seal()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xD34FB8", Offset = "0xD34FB8", VA = "0xD34FB8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xD3516C", Offset = "0xD3516C", VA = "0xD3516C")]
		public AnimalChara()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class AnimalDrinkManager : MonoBehaviour
	{
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float Thirst_Amount_Limit;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float Thirst_Subtract_Speed;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float amount;

		[Token(Token = "0x1700008D")]
		public bool IsThirst
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xD35214", Offset = "0xD35214", VA = "0xD35214")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xD35290", Offset = "0xD35290", VA = "0xD35290")]
		public void Update()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xD35324", Offset = "0xD35324", VA = "0xD35324")]
		public void OnAddThirstAmount(float add)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xD35354", Offset = "0xD35354", VA = "0xD35354")]
		public AnimalDrinkManager()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class AnimalEyelidManager
	{
		[Token(Token = "0x4000638")]
		private const float AMOUNT_CHANGE = 1f;

		[Token(Token = "0x4000639")]
		private const string EYELID_BLENDNAME_L = "L_eye_close";

		[Token(Token = "0x400063A")]
		private const string EYELID_BLENDNAME_R = "R_eye_close";

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SkinnedMeshRenderer renderer;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int eyelidBlendShapeL;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int eyelidBlendShapeR;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float amount;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool isSleep;

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xD33274", Offset = "0xD33274", VA = "0xD33274")]
		public AnimalEyelidManager(SkinnedMeshRenderer eyelidBlendShape)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xD353C4", Offset = "0xD353C4", VA = "0xD353C4")]
		private static int FindPartialMatchBlendShapeIndex(SkinnedMeshRenderer mesh, string part_name)
		{
			return default(int);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xD33C8C", Offset = "0xD33C8C", VA = "0xD33C8C")]
		public void Update()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xD35460", Offset = "0xD35460", VA = "0xD35460")]
		public void SetIsSleep(bool isSleep)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class AnimalEyesightManager
	{
		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int FieldMaskLayer;

		[Token(Token = "0x4000641")]
		public const float MaxDistance = 10f;

		[Token(Token = "0x4000642")]
		public const float MaxAngle = 90f;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform eyeTrans;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MainGameManager mainGame;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimalChara owner;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FoundElementCollection founds;

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xD3317C", Offset = "0xD3317C", VA = "0xD3317C")]
		public AnimalEyesightManager(AnimalChara animal, Transform eyeTrans, MainGameManager mainGame)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xD33AF8", Offset = "0xD33AF8", VA = "0xD33AF8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xD342B8", Offset = "0xD342B8", VA = "0xD342B8")]
		public void OnRemoveFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xD342F0", Offset = "0xD342F0", VA = "0xD342F0")]
		public FindableElement SearchFromPriority(FindableElement.Kind[] prioritys)
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xD34334", Offset = "0xD34334", VA = "0xD34334")]
		public FindableElement SearchFromFunction(Func<FindableElement, bool> function)
		{
			return null;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xD342D4", Offset = "0xD342D4", VA = "0xD342D4")]
		public bool TryGetAttentionPoint(ref Vector3 lookPos)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FD")]
	public class FoundElementCollection
	{
		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442518", Offset = "0x442518")]
		private bool <IsOrganized>k__BackingField;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<FoundElementInfo> founds;

		[Token(Token = "0x1700008E")]
		public bool IsOrganized
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x9238E8", Offset = "0x9238E8", VA = "0x9238E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4438A8", Offset = "0x4438A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x9238F0", Offset = "0x9238F0", VA = "0x9238F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4438B8", Offset = "0x4438B8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x9238FC", Offset = "0x9238FC", VA = "0x9238FC")]
		public void Add(FoundElementInfo info)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x923964", Offset = "0x923964", VA = "0x923964")]
		public void Organize()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x923A2C", Offset = "0x923A2C", VA = "0x923A2C")]
		private static int NearSort(FoundElementInfo a, FoundElementInfo b)
		{
			return default(int);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x923A6C", Offset = "0x923A6C", VA = "0x923A6C")]
		public void Clear()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x923AC0", Offset = "0x923AC0", VA = "0x923AC0")]
		public void Remove(FindableElement element)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x923B9C", Offset = "0x923B9C", VA = "0x923B9C")]
		public FindableElement SearchFromPriorityFilter(FindableElement.Kind[] prioritys)
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x923CF4", Offset = "0x923CF4", VA = "0x923CF4")]
		public FindableElement SearchFromFunction(Func<FindableElement, bool> function)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x923DFC", Offset = "0x923DFC", VA = "0x923DFC")]
		public bool TryGetAttentionPoint(ref Vector3 lookPos)
		{
			return default(bool);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x923EB0", Offset = "0x923EB0", VA = "0x923EB0")]
		public FoundElementCollection()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class AnimalFavoritePlace : MonoBehaviour
	{
		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimalChara.AnimalKind kind;

		[Token(Token = "0x1700008F")]
		public AnimalChara.AnimalKind Kind
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0xD354D8", Offset = "0xD354D8", VA = "0xD354D8")]
			get
			{
				return default(AnimalChara.AnimalKind);
			}
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xD354E0", Offset = "0xD354E0", VA = "0xD354E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xD35534", Offset = "0xD35534", VA = "0xD35534")]
		public AnimalFavoritePlace()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class AnimalFavoritePlaceCollection
	{
		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<AnimalChara.AnimalKind, List<AnimalFavoritePlace>> kindCollection;

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xD3553C", Offset = "0xD3553C", VA = "0xD3553C")]
		public void Add(AnimalFavoritePlace[] places)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xD356D0", Offset = "0xD356D0", VA = "0xD356D0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xD355B4", Offset = "0xD355B4", VA = "0xD355B4")]
		public void Add(AnimalFavoritePlace place)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xD35724", Offset = "0xD35724", VA = "0xD35724")]
		public AnimalFavoritePlace[] GetPlaces(AnimalChara.AnimalKind kind)
		{
			return null;
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xD357E0", Offset = "0xD357E0", VA = "0xD357E0")]
		public AnimalFavoritePlaceCollection()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000100")]
	public struct AnimalMoveSpeed
	{
		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Walk;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Run;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xD13600", Offset = "0xD13600", VA = "0xD13600")]
		public AnimalMoveSpeed(float wark, float run)
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class CarriedManager
	{
		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Grabbable animalGrabbable;

		[Token(Token = "0x17000090")]
		public bool IsGrabbed
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0xD1CCD0", Offset = "0xD1CCD0", VA = "0xD1CCD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xD1CD68", Offset = "0xD1CD68", VA = "0xD1CD68")]
		public CarriedManager(Grabbable grabbableObject)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xD1CE0C", Offset = "0xD1CE0C", VA = "0xD1CE0C")]
		public void ForceUngrab()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xD1CE2C", Offset = "0xD1CE2C", VA = "0xD1CE2C")]
		public void SetEnable(bool enabled)
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class ChinchillaHandOnPellet : MonoBehaviour
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int HandsCount;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Renderer renderer;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lifespan_second;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform[] grabHands;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float time;

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xD1DA7C", Offset = "0xD1DA7C", VA = "0xD1DA7C")]
		private void Start()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xD1DAB4", Offset = "0xD1DAB4", VA = "0xD1DAB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xD1DBCC", Offset = "0xD1DBCC", VA = "0xD1DBCC")]
		public void StartEating()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xD1DC08", Offset = "0xD1DC08", VA = "0xD1DC08")]
		public ChinchillaHandOnPellet()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class AnimalCommand
	{
		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 move;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float turn;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool rollOver;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eatOnDish;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool readyEatOnHand;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool idleAction;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool sleep;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool spoil;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3? lookPos;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool holdBall;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool thank;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool proceedQuest;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public bool dislike;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool bark;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool bark_joy;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		public bool bark_like;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FindableElement targetElement;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimalChara.StanceType changeStance;

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xD28F70", Offset = "0xD28F70", VA = "0xD28F70")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xD33238", Offset = "0xD33238", VA = "0xD33238")]
		public AnimalCommand()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class AnimalLookManager
	{
		[Token(Token = "0x4000665")]
		private const float NoLookK = 10f;

		[Token(Token = "0x4000666")]
		private const float NoLookMinSpeed = 1f;

		[Token(Token = "0x4000667")]
		private const float LookK = 5f;

		[Token(Token = "0x4000668")]
		private const float LookMinSpeed = 1f;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LookAtRotator eyeLook;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalLookHead headLook;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float tooNearDistance;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442568", Offset = "0x442568")]
		private Transform <EyeTrans>k__BackingField;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442578", Offset = "0x442578")]
		private bool <IsKeepAnimationLook>k__BackingField;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442588", Offset = "0x442588")]
		private Vector3 <TargetPos>k__BackingField;

		[Token(Token = "0x17000091")]
		public Transform EyeTrans
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xD12DD4", Offset = "0xD12DD4", VA = "0xD12DD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4438C8", Offset = "0x4438C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xD12DDC", Offset = "0xD12DDC", VA = "0xD12DDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4438D8", Offset = "0x4438D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool IsKeepAnimationLook
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0xD12DE4", Offset = "0xD12DE4", VA = "0xD12DE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4438E8", Offset = "0x4438E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000668")]
			[Address(RVA = "0xD12DEC", Offset = "0xD12DEC", VA = "0xD12DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4438F8", Offset = "0x4438F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public Vector3 TargetPos
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0xD12DF8", Offset = "0xD12DF8", VA = "0xD12DF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443908", Offset = "0x443908")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0xD12E04", Offset = "0xD12E04", VA = "0xD12E04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443918", Offset = "0x443918")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public float HeadLookWeight
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0xD12E10", Offset = "0xD12E10", VA = "0xD12E10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0xD12E2C", Offset = "0xD12E2C", VA = "0xD12E2C")]
			set
			{
			}
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xD12E48", Offset = "0xD12E48", VA = "0xD12E48")]
		public AnimalLookManager(Transform eyeTrans, AnimalLookHead headLook, LookAtRotator eyeLook)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xD12ED0", Offset = "0xD12ED0", VA = "0xD12ED0")]
		public void Update()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xD12EE0", Offset = "0xD12EE0", VA = "0xD12EE0")]
		private void Update_NoLook()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xD13024", Offset = "0xD13024", VA = "0xD13024")]
		private void Update_LookAt()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xD11DD8", Offset = "0xD11DD8", VA = "0xD11DD8")]
		public void SetHeadLookOffset(float pitchOffset)
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class PettingManager
	{
		[Token(Token = "0x400066F")]
		private const float effectSpan = 0.2f;

		[Token(Token = "0x4000670")]
		private const float pettingGageSpeed = 4f;

		[Token(Token = "0x4000671")]
		private const float PettingGageMin = 0f;

		[Token(Token = "0x4000672")]
		private const float PettingGageMax = 1f;

		[Token(Token = "0x4000673")]
		private const float VibrationRate = 0.25f;

		[Token(Token = "0x4000674")]
		private const float VibrationMax = 0.1f;

		[Token(Token = "0x4000675")]
		private const float VibrationMinTime = 0.1f;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GameObject effectOriginal;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float effectTimer;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float pettingGage;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool onPetting;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442598", Offset = "0x442598")]
		private bool <IsPetted>k__BackingField;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4425A8", Offset = "0x4425A8")]
		private bool <Enable>k__BackingField;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4425B8", Offset = "0x4425B8")]
		private Vector3 <PettedPoint>k__BackingField;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float pettingTimerL;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float pettingTimerR;

		[Token(Token = "0x17000095")]
		public bool IsPetted
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0xCFF36C", Offset = "0xCFF36C", VA = "0xCFF36C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443928", Offset = "0x443928")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0xCFF374", Offset = "0xCFF374", VA = "0xCFF374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443938", Offset = "0x443938")]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool Enable
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0xCFF380", Offset = "0xCFF380", VA = "0xCFF380")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443948", Offset = "0x443948")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000675")]
			[Address(RVA = "0xCFF388", Offset = "0xCFF388", VA = "0xCFF388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443958", Offset = "0x443958")]
			private set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public Vector3 PettedPoint
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0xCFF394", Offset = "0xCFF394", VA = "0xCFF394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443968", Offset = "0x443968")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000677")]
			[Address(RVA = "0xCFF3A0", Offset = "0xCFF3A0", VA = "0xCFF3A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443978", Offset = "0x443978")]
			private set
			{
			}
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xCFF3AC", Offset = "0xCFF3AC", VA = "0xCFF3AC")]
		public PettingManager(GameObject effectOriginal)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xCFF3F4", Offset = "0xCFF3F4", VA = "0xCFF3F4")]
		public void Update()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xCFF4C0", Offset = "0xCFF4C0", VA = "0xCFF4C0")]
		private void UpdateVibration()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xCFF4F0", Offset = "0xCFF4F0", VA = "0xCFF4F0")]
		private static void UpdateVibration(ref float pettingTimer, VR_Input.SIDE side)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xCFF468", Offset = "0xCFF468", VA = "0xCFF468")]
		private void CoolingPettingGage()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xCFF5A8", Offset = "0xCFF5A8", VA = "0xCFF5A8")]
		public void OnHandTriggerStay(VR_Input.SIDE handSide, Transform handTrans)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xCFF770", Offset = "0xCFF770", VA = "0xCFF770")]
		public void SetEnable(bool isPettable)
		{
		}
	}
}
namespace AnimalVR.Animal.Action
{
	[Token(Token = "0x2000106")]
	public class AnimalActionManager
	{
		[Token(Token = "0x2000107")]
		public enum BodyState
		{
			[Token(Token = "0x4000683")]
			Idle,
			[Token(Token = "0x4000684")]
			IdleAction,
			[Token(Token = "0x4000685")]
			Move,
			[Token(Token = "0x4000686")]
			Turn,
			[Token(Token = "0x4000687")]
			Falling,
			[Token(Token = "0x4000688")]
			RollOver,
			[Token(Token = "0x4000689")]
			EatOnDish,
			[Token(Token = "0x400068A")]
			ReadyEatOnHand,
			[Token(Token = "0x400068B")]
			Sleep,
			[Token(Token = "0x400068C")]
			Spoil,
			[Token(Token = "0x400068D")]
			Carried,
			[Token(Token = "0x400068E")]
			HoldInBall,
			[Token(Token = "0x400068F")]
			HoldOutBall,
			[Token(Token = "0x4000690")]
			Thank,
			[Token(Token = "0x4000691")]
			Quest_Cat01,
			[Token(Token = "0x4000692")]
			Quest_Cat02,
			[Token(Token = "0x4000693")]
			Quest_Capybara,
			[Token(Token = "0x4000694")]
			Quest_Chick_Idle,
			[Token(Token = "0x4000695")]
			Quest_Chick_Drinking,
			[Token(Token = "0x4000696")]
			Quest_Dog01,
			[Token(Token = "0x4000697")]
			Quest_Dog02_CanNotGetDown,
			[Token(Token = "0x4000698")]
			Quest_Fox02_LookIce,
			[Token(Token = "0x4000699")]
			Quest_Rabbit01,
			[Token(Token = "0x400069A")]
			Quest_Rabbit02_CanNotGetOut,
			[Token(Token = "0x400069B")]
			Quest_Rabbit02_GetOutNest,
			[Token(Token = "0x400069C")]
			Quest_Seal
		}

		[Token(Token = "0x2000108")]
		public enum HeadState
		{
			[Token(Token = "0x400069E")]
			Idle,
			[Token(Token = "0x400069F")]
			Animation,
			[Token(Token = "0x40006A0")]
			Petted,
			[Token(Token = "0x40006A1")]
			HoldBall,
			[Token(Token = "0x40006A2")]
			Dislike,
			[Token(Token = "0x40006A3")]
			ThankBark,
			[Token(Token = "0x40006A4")]
			Bark,
			[Token(Token = "0x40006A5")]
			ReadyEatOnHand,
			[Token(Token = "0x40006A6")]
			EatOnlyMouth
		}

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4425C8", Offset = "0x4425C8")]
		private AnimalChara <Owner>k__BackingField;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4425D8", Offset = "0x4425D8")]
		private AnimalBodyActionStateManager <BodyManager>k__BackingField;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4425E8", Offset = "0x4425E8")]
		private AnimalHeadActionStateManager <HeadManager>k__BackingField;

		[Token(Token = "0x17000098")]
		public AnimalChara Owner
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0xD2B17C", Offset = "0xD2B17C", VA = "0xD2B17C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443988", Offset = "0x443988")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000680")]
			[Address(RVA = "0xD2B184", Offset = "0xD2B184", VA = "0xD2B184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443998", Offset = "0x443998")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public AnimalBodyActionStateManager BodyManager
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0xD2B18C", Offset = "0xD2B18C", VA = "0xD2B18C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4439A8", Offset = "0x4439A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000682")]
			[Address(RVA = "0xD2B194", Offset = "0xD2B194", VA = "0xD2B194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4439B8", Offset = "0x4439B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public AnimalHeadActionStateManager HeadManager
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0xD2B19C", Offset = "0xD2B19C", VA = "0xD2B19C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4439C8", Offset = "0x4439C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000684")]
			[Address(RVA = "0xD2B1A4", Offset = "0xD2B1A4", VA = "0xD2B1A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4439D8", Offset = "0x4439D8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xD2B1AC", Offset = "0xD2B1AC", VA = "0xD2B1AC")]
		public AnimalActionManager(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xD2B26C", Offset = "0xD2B26C", VA = "0xD2B26C")]
		private void SetupBodyManager()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xD2B6B0", Offset = "0xD2B6B0", VA = "0xD2B6B0")]
		private void SetupHeadManager()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xD2BDB8", Offset = "0xD2BDB8", VA = "0xD2BDB8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xD2BE30", Offset = "0xD2BE30", VA = "0xD2BE30")]
		public void OnRemoveFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xD2BECC", Offset = "0xD2BECC", VA = "0xD2BECC")]
		public void Message(AnimalChara.MessageType type, string option)
		{
		}
	}
	[Token(Token = "0x2000109")]
	public abstract class AnimalBodyActionStateInfo
	{
		[Token(Token = "0x600068B")]
		[Address(RVA = "0xD2D3DC", Offset = "0xD2D3DC", VA = "0xD2D3DC")]
		protected AnimalBodyActionStateInfo()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class AnimalBodyActionState : StateBase_WithMsg<AnimalActionManager.BodyState, AnimalBodyActionStateInfo>
	{
		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected AnimalActionManager actManager;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected AnimalBodyActionStateManager bodyStateManager;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected AnimalChara owner;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected MainGameManager mainGame;

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xD2D328", Offset = "0xD2D328", VA = "0xD2D328")]
		public AnimalBodyActionState(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xD2D3D4", Offset = "0xD2D3D4", VA = "0xD2D3D4", Slot = "7")]
		public virtual void OnRemoveFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xD2D3D8", Offset = "0xD2D3D8", VA = "0xD2D3D8", Slot = "8")]
		public virtual void Message(AnimalChara.MessageType type, string option)
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class AnimalBodyActionStateManager : StateManagerBase_WithMsg<AnimalActionManager.BodyState, AnimalBodyActionState, AnimalBodyActionStateInfo>
	{
		[Token(Token = "0x600068F")]
		[Address(RVA = "0xD2BE9C", Offset = "0xD2BE9C", VA = "0xD2BE9C")]
		public void OnRemoveFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xD2BF50", Offset = "0xD2BF50", VA = "0xD2BF50")]
		public void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xD2B9A4", Offset = "0xD2B9A4", VA = "0xD2B9A4")]
		public AnimalBodyActionStateManager()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public abstract class AnimalHeadActionStateInfo
	{
		[Token(Token = "0x6000692")]
		[Address(RVA = "0xD359F4", Offset = "0xD359F4", VA = "0xD359F4")]
		protected AnimalHeadActionStateInfo()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class AnimalHeadActionState : StateBase_WithMsg<AnimalActionManager.HeadState, AnimalHeadActionStateInfo>
	{
		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected AnimalActionManager actManager;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected AnimalHeadActionStateManager headStateManager;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected AnimalChara owner;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected MainGameManager mainGame;

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xD35864", Offset = "0xD35864", VA = "0xD35864")]
		public AnimalHeadActionState(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xD35910", Offset = "0xD35910", VA = "0xD35910", Slot = "7")]
		public virtual void OnRemoveFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xD35914", Offset = "0xD35914", VA = "0xD35914", Slot = "8")]
		public virtual void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xD35918", Offset = "0xD35918", VA = "0xD35918")]
		protected void ApplyCommandLookPos()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xD359C8", Offset = "0xD359C8", VA = "0xD359C8")]
		protected void KeepAnimationLook()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class AnimalHeadActionStateManager : StateManagerBase_WithMsg<AnimalActionManager.HeadState, AnimalHeadActionState, AnimalHeadActionStateInfo>
	{
		[Token(Token = "0x6000698")]
		[Address(RVA = "0xD2BEB4", Offset = "0xD2BEB4", VA = "0xD2BEB4")]
		public void OnRemoveFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xD2BF68", Offset = "0xD2BF68", VA = "0xD2BF68")]
		public void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xD2BC04", Offset = "0xD2BC04", VA = "0xD2BC04")]
		public AnimalHeadActionStateManager()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class AnimalBodyAction_Carried : AnimalBodyActionState
	{
		[Token(Token = "0x40006AF")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xD2BBF4", Offset = "0xD2BBF4", VA = "0xD2BBF4")]
		public AnimalBodyAction_Carried(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xD2D3E4", Offset = "0xD2D3E4", VA = "0xD2D3E4", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xD2D4CC", Offset = "0xD2D4CC", VA = "0xD2D4CC", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xD2D558", Offset = "0xD2D558", VA = "0xD2D558", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xD2D5FC", Offset = "0xD2D5FC", VA = "0xD2D5FC")]
		private void FixRotation()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class AnimalBodyAction_EatOnDish : AnimalBodyActionState
	{
		[Token(Token = "0x40006B0")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x40006B1")]
		private const float SearchFoodDistance = 1f;

		[Token(Token = "0x40006B2")]
		private const float FixSpeed = 2f;

		[Token(Token = "0x40006B3")]
		private const float EatSpeed = 0.1f;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Food targetFood;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float fixRate;

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xD2BBE4", Offset = "0xD2BBE4", VA = "0xD2BBE4")]
		public AnimalBodyAction_EatOnDish(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xD2D69C", Offset = "0xD2D69C", VA = "0xD2D69C", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xD2D950", Offset = "0xD2D950", VA = "0xD2D950", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xD2DC2C", Offset = "0xD2DC2C", VA = "0xD2DC2C", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xD2DAE4", Offset = "0xD2DAE4", VA = "0xD2DAE4")]
		private void FixPosition()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xD2DA54", Offset = "0xD2DA54", VA = "0xD2DA54")]
		private bool CheckReaction()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xD2D878", Offset = "0xD2D878", VA = "0xD2D878")]
		private Food FindFood()
		{
			return null;
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xD2DCC0", Offset = "0xD2DCC0", VA = "0xD2DCC0")]
		private bool FindFoodFunction(FindableElement element)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000111")]
	public class AnimalBodyAction_Falling : AnimalBodyActionState
	{
		[Token(Token = "0x40006B6")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xD2BB30", Offset = "0xD2BB30", VA = "0xD2BB30")]
		public AnimalBodyAction_Falling(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xD2DCFC", Offset = "0xD2DCFC", VA = "0xD2DCFC", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xD2DD8C", Offset = "0xD2DD8C", VA = "0xD2DD8C", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class AnimalBodyAction_HoldInBall : AnimalBodyActionState
	{
		[Token(Token = "0x40006B7")]
		private const float SearchFreeBallDistance = 1f;

		[Token(Token = "0x40006B8")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x40006B9")]
		private const float HoldInTime = 0.83f;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isHolded;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float timer;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Ball targetBall;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 startBallPos;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 ballSuckPos;

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xD2BBF8", Offset = "0xD2BBF8", VA = "0xD2BBF8")]
		public AnimalBodyAction_HoldInBall(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xD2E080", Offset = "0xD2E080", VA = "0xD2E080", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xD2E2C8", Offset = "0xD2E2C8", VA = "0xD2E2C8")]
		private Vector3 BallSuckPos()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xD2E410", Offset = "0xD2E410", VA = "0xD2E410")]
		public Vector3 RaycastGround(Vector3 startPos, float raycastHeight, float raycastMaxDistance, int layerMask)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xD2E520", Offset = "0xD2E520", VA = "0xD2E520", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xD2E78C", Offset = "0xD2E78C", VA = "0xD2E78C", Slot = "7")]
		public override void OnRemoveFindableElement(FindableElement element)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xD2E268", Offset = "0xD2E268", VA = "0xD2E268")]
		private Ball FindHoldableBall()
		{
			return null;
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xD2E530", Offset = "0xD2E530", VA = "0xD2E530")]
		private void Update_NoHolded()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xD2E6B4", Offset = "0xD2E6B4", VA = "0xD2E6B4")]
		private void Update_Holded()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xD2E948", Offset = "0xD2E948", VA = "0xD2E948")]
		private bool CheckEndAnimation(int layer, int checkState)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xD2E840", Offset = "0xD2E840", VA = "0xD2E840")]
		private void HoldBall()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xD2E9E0", Offset = "0xD2E9E0", VA = "0xD2E9E0", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class AnimalBodyAction_HoldOutBall : AnimalBodyActionState
	{
		[Token(Token = "0x40006BF")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x40006C0")]
		private const float HoldOutTime = 1.5f;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isReleased;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float timer;

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xD2BBFC", Offset = "0xD2BBFC", VA = "0xD2BBFC")]
		public AnimalBodyAction_HoldOutBall(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xD2EA08", Offset = "0xD2EA08", VA = "0xD2EA08", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xD2EB00", Offset = "0xD2EB00", VA = "0xD2EB00", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xD2EB10", Offset = "0xD2EB10", VA = "0xD2EB10")]
		private void Update_NoReleased()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xD2EB68", Offset = "0xD2EB68", VA = "0xD2EB68")]
		private void Update_Released()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xD2EC94", Offset = "0xD2EC94", VA = "0xD2EC94")]
		private bool CheckEndAnimation(int layer, int checkState)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xD2EC40", Offset = "0xD2EC40", VA = "0xD2EC40")]
		private void RleaseBall()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xD2ED44", Offset = "0xD2ED44", VA = "0xD2ED44", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class AnimalBodyAction_Idle : AnimalBodyActionState
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] AnmState_Idles;

		[Token(Token = "0x40006C4")]
		private const float AnmBlendTime = 0.5f;

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xD2B9F0", Offset = "0xD2B9F0", VA = "0xD2B9F0")]
		public AnimalBodyAction_Idle(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xD2EDA4", Offset = "0xD2EDA4", VA = "0xD2EDA4", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xD2EE7C", Offset = "0xD2EE7C", VA = "0xD2EE7C", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xD2F198", Offset = "0xD2F198", VA = "0xD2F198", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xD2F17C", Offset = "0xD2F17C", VA = "0xD2F17C")]
		private void ChangeStance(AnimalChara.StanceType stance)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xD2EDC0", Offset = "0xD2EDC0", VA = "0xD2EDC0")]
		private void PlayStanceAnimation(AnimalChara.StanceType stance)
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class AnimalBodyAction_IdleAction : AnimalBodyActionState
	{
		[Token(Token = "0x40006C5")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int nowIdleActionHash;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int[] standAct_Hashes;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int[] sitAct_Hashes;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int[] proneAct_Hashes;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xD2B9F4", Offset = "0xD2B9F4", VA = "0xD2B9F4")]
		public AnimalBodyAction_IdleAction(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xD2F380", Offset = "0xD2F380", VA = "0xD2F380", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xD2F59C", Offset = "0xD2F59C", VA = "0xD2F59C", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xD2F700", Offset = "0xD2F700", VA = "0xD2F700", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xD2F30C", Offset = "0xD2F30C", VA = "0xD2F30C")]
		private void SetupIdleActionHashes()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xD2F73C", Offset = "0xD2F73C", VA = "0xD2F73C")]
		private static int[] CreateAnmHashes(string[] anmNames)
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xD2F444", Offset = "0xD2F444", VA = "0xD2F444")]
		private int CheckIdleAction()
		{
			return default(int);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xD2F638", Offset = "0xD2F638", VA = "0xD2F638")]
		private bool CheckReaction()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000116")]
	public class AnimalBodyAction_Move : AnimalBodyActionState
	{
		[Token(Token = "0x40006CA")]
		private const float TurnSpeed = 180f;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int TrunAnmState;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int TurnAnmParam;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int MoveAnmState;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int MoveAnmParam;

		[Token(Token = "0x40006CF")]
		private const float MoveBlendTime = 0.2f;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int StopAnmState;

		[Token(Token = "0x40006D1")]
		private const float StopBlendTime = 0.5f;

		[Token(Token = "0x40006D2")]
		private const float WalkMagnitude = 1f;

		[Token(Token = "0x40006D3")]
		private const float RunMagnitude = 1.75f;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int animationState;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int stopAnime;

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xD2BA18", Offset = "0xD2BA18", VA = "0xD2BA18")]
		public AnimalBodyAction_Move(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xD2F80C", Offset = "0xD2F80C", VA = "0xD2F80C", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xD2F8CC", Offset = "0xD2F8CC", VA = "0xD2F8CC", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xD2FE0C", Offset = "0xD2FE0C", VA = "0xD2FE0C")]
		private float CalcSpeed(float moveZ)
		{
			return default(float);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xD2FCA8", Offset = "0xD2FCA8", VA = "0xD2FCA8")]
		private Vector3 CalcMoveVelocity(Vector3 commandVec)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xD2FE80", Offset = "0xD2FE80", VA = "0xD2FE80", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xD2F88C", Offset = "0xD2F88C", VA = "0xD2F88C")]
		private void ChangeAnimation(int nextAnimeHash, bool forceUpdate, float blend)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xD2FB44", Offset = "0xD2FB44", VA = "0xD2FB44")]
		private void NextAction()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xD2FD4C", Offset = "0xD2FD4C", VA = "0xD2FD4C")]
		private void ChangeMoveSound(float magnitude)
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class AnimalBodyAction_ReadyEatOnHand : AnimalBodyActionState
	{
		[Token(Token = "0x2000118")]
		private enum STATE
		{
			[Token(Token = "0x40006DF")]
			READY,
			[Token(Token = "0x40006E0")]
			EATING,
			[Token(Token = "0x40006E1")]
			CHEWING
		}

		[Token(Token = "0x40006D6")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x40006D7")]
		private const float SearchFoodDistance = 1f;

		[Token(Token = "0x40006D8")]
		private const float EatTime = 2f;

		[Token(Token = "0x40006D9")]
		private const float ChewingTime = 2f;

		[Token(Token = "0x40006DA")]
		private const float FoodMaxAmount = 1f;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private STATE state;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Food targetFood;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float timer;

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xD2BBE8", Offset = "0xD2BBE8", VA = "0xD2BBE8")]
		public AnimalBodyAction_ReadyEatOnHand(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xD311B4", Offset = "0xD311B4", VA = "0xD311B4", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xD3126C", Offset = "0xD3126C", VA = "0xD3126C", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xD3142C", Offset = "0xD3142C", VA = "0xD3142C")]
		private void Update_Ready()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xD314C0", Offset = "0xD314C0", VA = "0xD314C0")]
		private void Update_Eating()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xD315F4", Offset = "0xD315F4", VA = "0xD315F4")]
		private void Update_Chewing()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xD316D8", Offset = "0xD316D8", VA = "0xD316D8")]
		private void ChangeState(STATE newState)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xD317A8", Offset = "0xD317A8", VA = "0xD317A8", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xD31338", Offset = "0xD31338", VA = "0xD31338")]
		private bool CheckReaction()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xD318B0", Offset = "0xD318B0", VA = "0xD318B0")]
		private bool FindFoodFunction(FindableElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xD3164C", Offset = "0xD3164C", VA = "0xD3164C")]
		private bool CheckMouthReachingFood()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xD313C8", Offset = "0xD313C8", VA = "0xD313C8")]
		private void Exit()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class AnimalBodyAction_RollOver : AnimalBodyActionState
	{
		[Token(Token = "0x200011A")]
		private enum STATE
		{
			[Token(Token = "0x40006E8")]
			IN,
			[Token(Token = "0x40006E9")]
			MAIN,
			[Token(Token = "0x40006EA")]
			OUT
		}

		[Token(Token = "0x40006E2")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly int AnmState_RollOver_In;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private readonly int AnmState_RollOver_Out;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly int AnmState_RollOver_Petted;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private STATE state;

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xD2BB34", Offset = "0xD2BB34", VA = "0xD2BB34")]
		public AnimalBodyAction_RollOver(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xD318F8", Offset = "0xD318F8", VA = "0xD318F8", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xD31938", Offset = "0xD31938", VA = "0xD31938", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xD31B8C", Offset = "0xD31B8C", VA = "0xD31B8C", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xD31A68", Offset = "0xD31A68", VA = "0xD31A68")]
		private void Update_In()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xD31AB0", Offset = "0xD31AB0", VA = "0xD31AB0")]
		private void Update_Main()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xD31AB4", Offset = "0xD31AB4", VA = "0xD31AB4")]
		private void Update_Out()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xD319D8", Offset = "0xD319D8", VA = "0xD319D8")]
		private bool CheckReaction()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200011B")]
	public class AnimalBodyAction_Sleep : AnimalBodyActionState
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnmState_Sleep;

		[Token(Token = "0x40006EC")]
		private const float Speel_Sound_FadeTime = 0.5f;

		[Token(Token = "0x40006ED")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isAnmPlayed_Sleep;

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xD2BBEC", Offset = "0xD2BBEC", VA = "0xD2BBEC")]
		public AnimalBodyAction_Sleep(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xD31B90", Offset = "0xD31B90", VA = "0xD31B90", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xD31C48", Offset = "0xD31C48", VA = "0xD31C48", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xD31E50", Offset = "0xD31E50", VA = "0xD31E50", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xD31CEC", Offset = "0xD31CEC", VA = "0xD31CEC")]
		private bool CheckReaction()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xD31D7C", Offset = "0xD31D7C", VA = "0xD31D7C")]
		private void CheckSleepSoundStart()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class AnimalBodyAction_SoftPetted : AnimalBodyActionState
	{
		[Token(Token = "0x40006EF")]
		private const float AnmBlendTime = 0.4f;

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xD31F3C", Offset = "0xD31F3C", VA = "0xD31F3C")]
		public AnimalBodyAction_SoftPetted(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xD31F40", Offset = "0xD31F40", VA = "0xD31F40", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xD31F90", Offset = "0xD31F90", VA = "0xD31F90", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xD32024", Offset = "0xD32024", VA = "0xD32024")]
		private bool CheckReaction()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200011D")]
	public class AnimalBodyAction_Spoil : AnimalBodyActionState
	{
		[Token(Token = "0x40006F0")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xD2BBF0", Offset = "0xD2BBF0", VA = "0xD2BBF0")]
		public AnimalBodyAction_Spoil(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xD320B4", Offset = "0xD320B4", VA = "0xD320B4", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xD32144", Offset = "0xD32144", VA = "0xD32144", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xD32280", Offset = "0xD32280", VA = "0xD32280", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class AnimalBodyAction_Thank : AnimalBodyActionState
	{
		[Token(Token = "0x200011F")]
		private enum STATE
		{
			[Token(Token = "0x40006F7")]
			WAIT_START,
			[Token(Token = "0x40006F8")]
			WAIT_BARK
		}

		[Token(Token = "0x40006F1")]
		private const float AnmBlendTime = 0.25f;

		[Token(Token = "0x40006F2")]
		private const float WhiteBear_WaitTime = 0.5f;

		[Token(Token = "0x40006F3")]
		private const float Default_WaitTime = 2f;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float timer;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private STATE state;

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xD2BC00", Offset = "0xD2BC00", VA = "0xD2BC00")]
		public AnimalBodyAction_Thank(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xD322CC", Offset = "0xD322CC", VA = "0xD322CC", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xD32384", Offset = "0xD32384", VA = "0xD32384", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xD323A0", Offset = "0xD323A0", VA = "0xD323A0")]
		private void Update_WaitStart()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xD32494", Offset = "0xD32494", VA = "0xD32494")]
		private void Bark()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xD323F4", Offset = "0xD323F4", VA = "0xD323F4")]
		private void Update_WaitBark()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xD32508", Offset = "0xD32508", VA = "0xD32508", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xD32354", Offset = "0xD32354", VA = "0xD32354")]
		private void SetupWaitTime()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class AnimalBodyAction_Turn : AnimalBodyActionState
	{
		[Token(Token = "0x40006F9")]
		private const float TurnSpeed = 80f;

		[Token(Token = "0x40006FA")]
		private const float TurnAnimeThreshold = 45f;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int TrunAnmState;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int TurnAnmParam;

		[Token(Token = "0x40006FD")]
		private const float MoveBlendTime = 0.2f;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int StopAnmState;

		[Token(Token = "0x40006FF")]
		private const float StopBlendTime = 0.5f;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int animationState;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int stopAnime;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xD2BAA4", Offset = "0xD2BAA4", VA = "0xD2BAA4")]
		public AnimalBodyAction_Turn(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xD32534", Offset = "0xD32534", VA = "0xD32534", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xD325F4", Offset = "0xD325F4", VA = "0xD325F4", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xD328F0", Offset = "0xD328F0", VA = "0xD328F0", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xD325B4", Offset = "0xD325B4", VA = "0xD325B4")]
		private void ChangeAnimation(int nextAnimeHash, bool forceUpdate, float blend)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xD327B4", Offset = "0xD327B4", VA = "0xD327B4")]
		private void NextAction()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class AnimalBodyAction_Fox02_LookIce : AnimalBodyActionState
	{
		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnmState_Quest02;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xD2DEBC", Offset = "0xD2DEBC", VA = "0xD2DEBC")]
		public AnimalBodyAction_Fox02_LookIce(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xD2DEC0", Offset = "0xD2DEC0", VA = "0xD2DEC0", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xD2DF64", Offset = "0xD2DF64", VA = "0xD2DF64", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xD2DFEC", Offset = "0xD2DFEC", VA = "0xD2DFEC", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class AnimalBodyAction_Quest_Capybara : AnimalBodyActionState
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int AnmState_Prone;

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xD2FFE0", Offset = "0xD2FFE0", VA = "0xD2FFE0")]
		public AnimalBodyAction_Quest_Capybara(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xD2FFE4", Offset = "0xD2FFE4", VA = "0xD2FFE4", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xD30070", Offset = "0xD30070", VA = "0xD30070", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class AnimalBodyAction_Quest_Cat01_Idle : AnimalBodyActionState
	{
		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int AnmState_Prone;

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xD30164", Offset = "0xD30164", VA = "0xD30164")]
		public AnimalBodyAction_Quest_Cat01_Idle(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xD30168", Offset = "0xD30168", VA = "0xD30168", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xD301F4", Offset = "0xD301F4", VA = "0xD301F4", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class AnimalBodyAction_Quest_Cat02 : AnimalBodyActionState
	{
		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnmState_Quest1;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xD302F4", Offset = "0xD302F4", VA = "0xD302F4")]
		public AnimalBodyAction_Quest_Cat02(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xD302F8", Offset = "0xD302F8", VA = "0xD302F8", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xD30384", Offset = "0xD30384", VA = "0xD30384", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class AnimalBodyAction_Quest_Chick_Drinking : AnimalBodyActionState
	{
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnmState_Quest2;

		[Token(Token = "0x4000707")]
		private const float AnmBlend_Time = 0.25f;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isAnmPlaying;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xD30484", Offset = "0xD30484", VA = "0xD30484")]
		public AnimalBodyAction_Quest_Chick_Drinking(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xD30488", Offset = "0xD30488", VA = "0xD30488", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xD30528", Offset = "0xD30528", VA = "0xD30528", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class AnimalBodyAction_Quest_Chick_Idle : AnimalBodyActionState
	{
		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnmState_Quest1;

		[Token(Token = "0x400070A")]
		private const float AnmBlend_Time = 0.25f;

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xD30694", Offset = "0xD30694", VA = "0xD30694")]
		public AnimalBodyAction_Quest_Chick_Idle(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xD30698", Offset = "0xD30698", VA = "0xD30698", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xD30728", Offset = "0xD30728", VA = "0xD30728", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class AnimalBodyAction_Quest_Dog01 : AnimalBodyActionState
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnmState_Sit;

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xD30844", Offset = "0xD30844", VA = "0xD30844")]
		public AnimalBodyAction_Quest_Dog01(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xD30848", Offset = "0xD30848", VA = "0xD30848", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xD308D4", Offset = "0xD308D4", VA = "0xD308D4", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class AnimalBodyAction_Quest_Dog02_CanNotGetDown : AnimalBodyActionState
	{
		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly int AnmState_CanNotGetDown;

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xD309C8", Offset = "0xD309C8", VA = "0xD309C8")]
		public AnimalBodyAction_Quest_Dog02_CanNotGetDown(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xD30A30", Offset = "0xD30A30", VA = "0xD30A30", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xD30AA4", Offset = "0xD30AA4", VA = "0xD30AA4", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class AnimalBodyAction_Quest_Rabbit01 : AnimalBodyActionState
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnmState_Prone;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xD30B30", Offset = "0xD30B30", VA = "0xD30B30")]
		public AnimalBodyAction_Quest_Rabbit01(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xD30B34", Offset = "0xD30B34", VA = "0xD30B34", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xD30BC0", Offset = "0xD30BC0", VA = "0xD30BC0", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class AnimalBodyAction_Quest_Rabbit02_CanNotGetOut : AnimalBodyActionState
	{
		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly int AnmState_StayNest;

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xD30CB4", Offset = "0xD30CB4", VA = "0xD30CB4")]
		public AnimalBodyAction_Quest_Rabbit02_CanNotGetOut(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xD30D1C", Offset = "0xD30D1C", VA = "0xD30D1C", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xD30DAC", Offset = "0xD30DAC", VA = "0xD30DAC", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class AnimalBodyAction_Quest_Rabbit02_GetOutNest : AnimalBodyActionState
	{
		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly int AnmState_EscapeNest;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool playAnimation;

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xD30E34", Offset = "0xD30E34", VA = "0xD30E34")]
		public AnimalBodyAction_Quest_Rabbit02_GetOutNest(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xD30E9C", Offset = "0xD30E9C", VA = "0xD30E9C", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xD30F44", Offset = "0xD30F44", VA = "0xD30F44", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xD30FFC", Offset = "0xD30FFC", VA = "0xD30FFC", Slot = "6")]
		public override void Out(AnimalActionManager.BodyState nextState)
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class AnimalBodyAction_Quest_Seal : AnimalBodyActionState
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnmState_Quest1;

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xD31030", Offset = "0xD31030", VA = "0xD31030")]
		public AnimalBodyAction_Quest_Seal(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xD31034", Offset = "0xD31034", VA = "0xD31034", Slot = "4")]
		public override void In(AnimalBodyActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xD310C0", Offset = "0xD310C0", VA = "0xD310C0", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class AnimalHeadAction_Animation : AnimalHeadActionState
	{
		[Token(Token = "0x4000712")]
		private const float LookIgnoreSpeed = 4f;

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xD2BC54", Offset = "0xD2BC54", VA = "0xD2BC54")]
		public AnimalHeadAction_Animation(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xD359FC", Offset = "0xD359FC", VA = "0xD359FC", Slot = "4")]
		public override void In(AnimalHeadActionStateInfo msg)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xD35A00", Offset = "0xD35A00", VA = "0xD35A00", Slot = "5")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class AnimalHeadAction_Bark : AnimalHeadActionState
	{
		[Token(Token = "0x200012F")]
		public class Info : AnimalHeadActionStateInfo
		{
			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MouthSoundScriptableObject.Sound Sound;

			[Token(Token = "0x6000744")]
			[Address(RVA = "0xD119F0", Offset = "0xD119F0", VA = "0xD119F0")]
			public Info(MouthSoundScriptableObject.Sound sound)
			{
			}
		}

		[Token(Token = "0x2000130")]
		private enum STATE
		{
			[Token(Token = "0x400071C")]
			WAIT_BLEND_IN,
			[Token(Token = "0x400071D")]
			WAIT_BARK_FIN,
			[Token(Token = "0x400071E")]
			WAIT_BLEND_OUT
		}

		[Token(Token = "0x4000713")]
		private const float BlendTime = 0.2f;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly int Anime_Bark;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float timer;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float startWeght;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool isBarked;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private STATE state;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private MouthSoundScriptableObject.Sound sound;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xD2BCE8", Offset = "0xD2BCE8", VA = "0xD2BCE8")]
		public AnimalHeadAction_Bark(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xD35AA0", Offset = "0xD35AA0", VA = "0xD35AA0", Slot = "4")]
		public override void In(AnimalHeadActionStateInfo msg)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xD35B88", Offset = "0xD35B88", VA = "0xD35B88", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xD35BE0", Offset = "0xD35BE0", VA = "0xD35BE0")]
		private void Update_WaitBlendIn()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xD35CAC", Offset = "0xD35CAC", VA = "0xD35CAC")]
		private void Update_WaitBarkFin()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xD35CF8", Offset = "0xD35CF8", VA = "0xD35CF8")]
		private void Update_WaitBlendOut()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xD35DCC", Offset = "0xD35DCC", VA = "0xD35DCC")]
		private bool CheckEndAnimation(int layer, int checkState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xD35E4C", Offset = "0xD35E4C", VA = "0xD35E4C", Slot = "6")]
		public override void Out(AnimalActionManager.HeadState nextState)
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class AnimalHeadAction_Dislike : AnimalHeadActionState
	{
		[Token(Token = "0x400071F")]
		private const float MaxDistance = 1f;

		[Token(Token = "0x4000720")]
		private const float ParamSpringK = 5f;

		[Token(Token = "0x4000721")]
		private const float WeightSpeed = 2f;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnmState_Dislike;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int AnmParam_Dislike;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float param;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xD2BCE4", Offset = "0xD2BCE4", VA = "0xD2BCE4")]
		public AnimalHeadAction_Dislike(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xD35E94", Offset = "0xD35E94", VA = "0xD35E94", Slot = "4")]
		public override void In(AnimalHeadActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xD35FF0", Offset = "0xD35FF0", VA = "0xD35FF0", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xD360D4", Offset = "0xD360D4", VA = "0xD360D4")]
		private float CalcHeadLayerWeight(float headLayerWeight)
		{
			return default(float);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xD3617C", Offset = "0xD3617C", VA = "0xD3617C")]
		private float CalcMaxWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xD35F4C", Offset = "0xD35F4C", VA = "0xD35F4C")]
		private void ApplyParam()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xD363A0", Offset = "0xD363A0", VA = "0xD363A0", Slot = "6")]
		public override void Out(AnimalActionManager.HeadState nextState)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xD36288", Offset = "0xD36288", VA = "0xD36288")]
		private float CalcParam()
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000132")]
	public class AnimalHeadAction_EatOnlyMouth : AnimalHeadActionState
	{
		[Token(Token = "0x4000725")]
		private const float BlendTime = 0.2f;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly int Anime_MouthEat;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private MouthSoundScriptableObject.Sound sound;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xD2BD50", Offset = "0xD2BD50", VA = "0xD2BD50")]
		public AnimalHeadAction_EatOnlyMouth(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xD364FC", Offset = "0xD364FC", VA = "0xD364FC", Slot = "4")]
		public override void In(AnimalHeadActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xD3658C", Offset = "0xD3658C", VA = "0xD3658C", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xD36590", Offset = "0xD36590", VA = "0xD36590", Slot = "6")]
		public override void Out(AnimalActionManager.HeadState nextState)
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class AnimalHeadAction_HoldBall : AnimalHeadActionState
	{
		[Token(Token = "0x4000728")]
		private const float BlendTime = 0f;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly int Anime_Holding;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private readonly int Anime_Idle;

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xD2BC58", Offset = "0xD2BC58", VA = "0xD2BC58")]
		public AnimalHeadAction_HoldBall(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xD365F8", Offset = "0xD365F8", VA = "0xD365F8", Slot = "4")]
		public override void In(AnimalHeadActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xD36664", Offset = "0xD36664", VA = "0xD36664", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xD36668", Offset = "0xD36668", VA = "0xD36668", Slot = "6")]
		public override void Out(AnimalActionManager.HeadState nextState)
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class AnimalHeadAction_Idle : AnimalHeadActionState
	{
		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int AnmState_Idle;

		[Token(Token = "0x400072C")]
		private const float TargetOnDelay = 0.25f;

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xD2BC50", Offset = "0xD2BC50", VA = "0xD2BC50")]
		public AnimalHeadAction_Idle(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xD366D8", Offset = "0xD366D8", VA = "0xD366D8", Slot = "4")]
		public override void In(AnimalHeadActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xD36764", Offset = "0xD36764", VA = "0xD36764", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xD3697C", Offset = "0xD3697C", VA = "0xD3697C", Slot = "6")]
		public override void Out(AnimalActionManager.HeadState nextState)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xD36860", Offset = "0xD36860", VA = "0xD36860")]
		private bool CheckBarkReaction()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000135")]
	public class AnimalHeadAction_Petted : AnimalHeadActionState
	{
		[Token(Token = "0x600075C")]
		[Address(RVA = "0xD11C50", Offset = "0xD11C50", VA = "0xD11C50")]
		public AnimalHeadAction_Petted(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xD11C58", Offset = "0xD11C58", VA = "0xD11C58", Slot = "4")]
		public override void In(AnimalHeadActionStateInfo msg)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xD11C5C", Offset = "0xD11C5C", VA = "0xD11C5C", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xD11D94", Offset = "0xD11D94", VA = "0xD11D94", Slot = "6")]
		public override void Out(AnimalActionManager.HeadState nextState)
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class AnimalHeadAction_ReadyEatOnHand : AnimalHeadActionState
	{
		[Token(Token = "0x6000760")]
		[Address(RVA = "0xD11D9C", Offset = "0xD11D9C", VA = "0xD11D9C")]
		public AnimalHeadAction_ReadyEatOnHand(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xD11DA4", Offset = "0xD11DA4", VA = "0xD11DA4", Slot = "4")]
		public override void In(AnimalHeadActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xD11DF4", Offset = "0xD11DF4", VA = "0xD11DF4", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xD11E84", Offset = "0xD11E84", VA = "0xD11E84", Slot = "6")]
		public override void Out(AnimalActionManager.HeadState nextState)
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class AnimalHeadAction_ThankBark : AnimalHeadActionState
	{
		[Token(Token = "0x2000138")]
		private enum STATE
		{
			[Token(Token = "0x4000734")]
			WAIT_BLEND_IN,
			[Token(Token = "0x4000735")]
			WAIT_BARK_FIN,
			[Token(Token = "0x4000736")]
			WAIT_BLEND_OUT
		}

		[Token(Token = "0x400072D")]
		private const float BlendTime = 0.2f;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly int Anime_Bark;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float timer;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float startWeght;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool isBarked;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private STATE state;

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xD11EC8", Offset = "0xD11EC8", VA = "0xD11EC8")]
		public AnimalHeadAction_ThankBark(AnimalActionManager actManager)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xD11F34", Offset = "0xD11F34", VA = "0xD11F34", Slot = "4")]
		public override void In(AnimalHeadActionStateInfo msg)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xD11FA4", Offset = "0xD11FA4", VA = "0xD11FA4", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xD12000", Offset = "0xD12000", VA = "0xD12000")]
		private void Update_WaitBlendIn()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xD120B8", Offset = "0xD120B8", VA = "0xD120B8")]
		private void Update_WaitBarkFin()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xD12104", Offset = "0xD12104", VA = "0xD12104")]
		private void Update_WaitBlendOut()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xD12294", Offset = "0xD12294", VA = "0xD12294")]
		private bool CheckEndAnimation(int layer, int checkState)
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xD12310", Offset = "0xD12310", VA = "0xD12310", Slot = "6")]
		public override void Out(AnimalActionManager.HeadState nextState)
		{
		}
	}
}
namespace AnimalVR.Animal.AI
{
	[Token(Token = "0x2000139")]
	public class AnimalAI : AnimalBrain
	{
		[Token(Token = "0x200013A")]
		public enum State
		{
			[Token(Token = "0x400073A")]
			Idle,
			[Token(Token = "0x400073B")]
			GoToFavoritePlace,
			[Token(Token = "0x400073C")]
			Petted,
			[Token(Token = "0x400073D")]
			EatOnDish,
			[Token(Token = "0x400073E")]
			EatOnHand,
			[Token(Token = "0x400073F")]
			Sleep,
			[Token(Token = "0x4000740")]
			Spoil,
			[Token(Token = "0x4000741")]
			Carried,
			[Token(Token = "0x4000742")]
			PlayWithTheBall,
			[Token(Token = "0x4000743")]
			ChasingRCCar
		}

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4425F8", Offset = "0x4425F8")]
		private AnimalAIStateManager <StateManager>k__BackingField;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442608", Offset = "0x442608")]
		private AnimalChara <Owner>k__BackingField;

		[Token(Token = "0x1700009B")]
		public AnimalAIStateManager StateManager
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0xD25F28", Offset = "0xD25F28", VA = "0xD25F28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4439E8", Offset = "0x4439E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600076D")]
			[Address(RVA = "0xD25F30", Offset = "0xD25F30", VA = "0xD25F30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4439F8", Offset = "0x4439F8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public AnimalChara Owner
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0xD25F38", Offset = "0xD25F38", VA = "0xD25F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443A08", Offset = "0x443A08")]
			get
			{
				return null;
			}
			[Token(Token = "0x600076F")]
			[Address(RVA = "0xD25F40", Offset = "0xD25F40", VA = "0xD25F40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443A18", Offset = "0x443A18")]
			private set
			{
			}
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xD25F48", Offset = "0xD25F48", VA = "0xD25F48")]
		public AnimalAI(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xD25FDC", Offset = "0xD25FDC", VA = "0xD25FDC")]
		private void SetupStateManager()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xD26B00", Offset = "0xD26B00", VA = "0xD26B00", Slot = "4")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class AnimalAIMoveCalculator
	{
		[Token(Token = "0x200013C")]
		public struct Parameter
		{
			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 muzzleOffset;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float radius;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float runDistance;
		}

		[Token(Token = "0x200013D")]
		public enum STATE
		{
			[Token(Token = "0x400074F")]
			MOVING,
			[Token(Token = "0x4000750")]
			GOAL,
			[Token(Token = "0x4000751")]
			UNREACHABLE_HEIGHT
		}

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara animal;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Parameter param;

		[Token(Token = "0x4000746")]
		private const float FrontalAngle = 1f;

		[Token(Token = "0x4000747")]
		private const float AngleToCommand = 90f;

		[Token(Token = "0x4000748")]
		private const float MinTurnInput = 0f;

		[Token(Token = "0x4000749")]
		private const float NearAreaRate = 0.5f;

		[Token(Token = "0x400074A")]
		private const float FarAreaRate = 1f;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xD26B54", Offset = "0xD26B54", VA = "0xD26B54")]
		public AnimalAIMoveCalculator(AnimalChara animal, Vector3 muzzleOffset, float radius, float runDistance)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xD26BC4", Offset = "0xD26BC4", VA = "0xD26BC4")]
		public STATE CalcMoveCommand(Vector3 goal, out Vector3 command)
		{
			return default(STATE);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xD2703C", Offset = "0xD2703C", VA = "0xD2703C")]
		public STATE CheckMoveState(Vector3 goal)
		{
			return default(STATE);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xD26E54", Offset = "0xD26E54", VA = "0xD26E54")]
		private static bool IsGoal(Vector3 muzzlePos, Vector3 goal, float radius)
		{
			return default(bool);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xD26E90", Offset = "0xD26E90", VA = "0xD26E90")]
		private static bool IsFlatGoal(Vector3 muzzlePos, Vector3 goal, float radius)
		{
			return default(bool);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xD26E80", Offset = "0xD26E80", VA = "0xD26E80")]
		private static bool IsUnreachableHeight(Vector3 muzzlePos, Vector3 goal, float radius)
		{
			return default(bool);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xD26FB8", Offset = "0xD26FB8", VA = "0xD26FB8")]
		private static bool IsStoppableDistance(Vector3 bodyPos, Vector3 muzzleOffset, Vector3 goal, float radius)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xD26EF8", Offset = "0xD26EF8", VA = "0xD26EF8")]
		public static Vector3 MoveVectorToCommand(Transform animalTrans, Vector3 worldVec, bool isRun, bool allowBack)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xD271E8", Offset = "0xD271E8", VA = "0xD271E8")]
		private static Vector3 LocalVecToMoveCommand_AllowBack(Transform animalTrans, Vector3 worldVec, bool isRun)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xD27344", Offset = "0xD27344", VA = "0xD27344")]
		private static Vector3 LocalVecToMoveCommand_DisallowBack(Transform animalTrans, Vector3 worldVec, bool isRun)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xD27464", Offset = "0xD27464", VA = "0xD27464")]
		private static float VectorToDeltaAngle(float animalYaw, Vector3 worldVec)
		{
			return default(float);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xD26F08", Offset = "0xD26F08", VA = "0xD26F08")]
		private static float PositionToDeltaAngle(Transform animalTrans, Vector3 worldPos)
		{
			return default(float);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xD26FA4", Offset = "0xD26FA4", VA = "0xD26FA4")]
		private static bool IsFrontal(float deltaYaw)
		{
			return default(bool);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xD26FF4", Offset = "0xD26FF4", VA = "0xD26FF4")]
		private static float CalcTurn(float deltaAngle)
		{
			return default(float);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xD26EC0", Offset = "0xD26EC0", VA = "0xD26EC0")]
		private static bool IsTooNearFlatDistance(Vector3 bodyPos, Vector3 muzzleOffset, Vector3 goalPos, float radius)
		{
			return default(bool);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xD271DC", Offset = "0xD271DC", VA = "0xD271DC")]
		private static float FlatDistance(Vector3 bodyPos, Vector3 goalPos)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200013E")]
	public class AnimalAIReactionStateChanger
	{
		[Token(Token = "0x200013F")]
		public struct Parameter
		{
			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool reactCarried;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool reactPetted;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool reactFood;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public bool reactBall;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool reactRCCar;
		}

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara animal;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalAIStateManager stateManager;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Parameter param;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xD274A0", Offset = "0xD274A0", VA = "0xD274A0")]
		public AnimalAIReactionStateChanger(AnimalChara animal, AnimalAIStateManager stateManager, Parameter parameter)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xD27504", Offset = "0xD27504", VA = "0xD27504")]
		public bool CheckAndReaction()
		{
			return default(bool);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xD275D4", Offset = "0xD275D4", VA = "0xD275D4")]
		private bool CheckAndReaction_InEyesight()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000140")]
	public abstract class AnimalAIStateInfo
	{
		[Token(Token = "0x6000786")]
		[Address(RVA = "0xD27A04", Offset = "0xD27A04", VA = "0xD27A04")]
		protected AnimalAIStateInfo()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class AnimalAIState : StateBase_WithMsg<AnimalAI.State, AnimalAIStateInfo>
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalAI ai;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected AnimalAIStateManager stateManager;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected AnimalChara owner;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected MainGameManager mainGame;

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xD27958", Offset = "0xD27958", VA = "0xD27958")]
		public AnimalAIState(AnimalAI ai)
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class AnimalAIStateManager : StateManagerBase_WithMsg<AnimalAI.State, AnimalAIState, AnimalAIStateInfo>
	{
		[Token(Token = "0x6000788")]
		[Address(RVA = "0xD26308", Offset = "0xD26308", VA = "0xD26308")]
		public AnimalAIStateManager()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class AnimalAI_Carried : AnimalAIState
	{
		[Token(Token = "0x400075E")]
		private const float BarkCoolTimeMin = 5f;

		[Token(Token = "0x400075F")]
		private const float BarkCoolTimeMax = 10f;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool IsBarking;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float barkCoolTimer;

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xD26A1C", Offset = "0xD26A1C", VA = "0xD26A1C")]
		public AnimalAI_Carried(AnimalAI ai)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xD27A0C", Offset = "0xD27A0C", VA = "0xD27A0C", Slot = "4")]
		public override void In(AnimalAIStateInfo msg)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xD27A40", Offset = "0xD27A40", VA = "0xD27A40", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xD27C04", Offset = "0xD27C04", VA = "0xD27C04", Slot = "6")]
		public override void Out(AnimalAI.State nextState)
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class AnimalAI_ChasingRCCar : AnimalAIState
	{
		[Token(Token = "0x2000145")]
		public class Info : AnimalAIStateInfo
		{
			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RC_Car car;

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xD118F0", Offset = "0xD118F0", VA = "0xD118F0")]
			public Info(RC_Car car)
			{
			}
		}

		[Token(Token = "0x4000762")]
		private const float LoseInterestTime = 5f;

		[Token(Token = "0x4000763")]
		private const float GoalDistance = 0.5f;

		[Token(Token = "0x4000764")]
		private const float ReChasingDistance = 1f;

		[Token(Token = "0x4000765")]
		private const float WalkCommandMagnitude = 1f;

		[Token(Token = "0x4000766")]
		private const float RunCommandMagnitude = 2f;

		[Token(Token = "0x4000767")]
		private const float MaxDistance = 250f;

		[Token(Token = "0x4000768")]
		private const float WalkDistance = 0.5f;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimalAIReactionStateChanger.Parameter ReactionParameter;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RC_Car targetCar;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float loseInterestTimer;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool isCaughtUp;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AnimalAIReactionStateChanger reaction;

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xD26A24", Offset = "0xD26A24", VA = "0xD26A24")]
		public AnimalAI_ChasingRCCar(AnimalAI ai)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xD27C40", Offset = "0xD27C40", VA = "0xD27C40", Slot = "4")]
		public override void In(AnimalAIStateInfo msg)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xD27CD8", Offset = "0xD27CD8", VA = "0xD27CD8", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xD280AC", Offset = "0xD280AC", VA = "0xD280AC", Slot = "6")]
		public override void Out(AnimalAI.State nextState)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xD27EE4", Offset = "0xD27EE4", VA = "0xD27EE4")]
		private bool CheckCatchup(Vector3 chasingPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xD27FD8", Offset = "0xD27FD8", VA = "0xD27FD8")]
		private Vector3 CalcMoveCommand(Vector3 goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xD27F74", Offset = "0xD27F74", VA = "0xD27F74")]
		private float CalcTurnCommand(Vector3 goal)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000146")]
	public class AnimalAI_EatOnDish : AnimalAIState
	{
		[Token(Token = "0x2000147")]
		public class Info : AnimalAIStateInfo
		{
			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Food food;

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xD11924", Offset = "0xD11924", VA = "0xD11924")]
			public Info(Food food)
			{
			}
		}

		[Token(Token = "0x2000148")]
		private enum State
		{
			[Token(Token = "0x4000778")]
			Moving,
			[Token(Token = "0x4000779")]
			Eating,
			[Token(Token = "0x400077A")]
			FinishedBarking
		}

		[Token(Token = "0x400076F")]
		private const float RunDistance = 2f;

		[Token(Token = "0x4000770")]
		private const float TooFarDistance = 20f;

		[Token(Token = "0x4000771")]
		private const float GiveUpTime = 15f;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private State state;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float movingTimer;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AnimalAIMoveCalculator moveCalulator;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Food targetFood;

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xD26670", Offset = "0xD26670", VA = "0xD26670")]
		public AnimalAI_EatOnDish(AnimalAI ai)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xD28168", Offset = "0xD28168", VA = "0xD28168")]
		private void ClearCommand()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xD281F8", Offset = "0xD281F8", VA = "0xD281F8", Slot = "4")]
		public override void In(AnimalAIStateInfo msg)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xD282FC", Offset = "0xD282FC", VA = "0xD282FC", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xD28600", Offset = "0xD28600", VA = "0xD28600")]
		private void ChangeState_Moving()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xD28324", Offset = "0xD28324", VA = "0xD28324")]
		private void Update_Moving()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xD286C0", Offset = "0xD286C0", VA = "0xD286C0")]
		private bool CheckTooFar()
		{
			return default(bool);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xD28754", Offset = "0xD28754", VA = "0xD28754")]
		private bool CheckGiveUpTime()
		{
			return default(bool);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xD287C4", Offset = "0xD287C4", VA = "0xD287C4")]
		private void ChangeState_Eating()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xD28474", Offset = "0xD28474", VA = "0xD28474")]
		private void Update_Eating()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xD287F0", Offset = "0xD287F0", VA = "0xD287F0")]
		private void ChangeState_FinishedBarking()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xD284F4", Offset = "0xD284F4", VA = "0xD284F4")]
		private void Update_FinishedBarking()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xD28824", Offset = "0xD28824", VA = "0xD28824", Slot = "6")]
		public override void Out(AnimalAI.State nextState)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xD2829C", Offset = "0xD2829C", VA = "0xD2829C")]
		private void ChangeState(State state)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xD28768", Offset = "0xD28768", VA = "0xD28768")]
		private void Exit()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xD28608", Offset = "0xD28608", VA = "0xD28608")]
		private bool CheckEatableFood(bool isEating)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000149")]
	public class AnimalAI_EatOnHand : AnimalAIState
	{
		[Token(Token = "0x200014A")]
		public class Info : AnimalAIStateInfo
		{
			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Food food;

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xD11958", Offset = "0xD11958", VA = "0xD11958")]
			public Info(Food food)
			{
			}
		}

		[Token(Token = "0x200014B")]
		private enum State
		{
			[Token(Token = "0x4000786")]
			Moving,
			[Token(Token = "0x4000787")]
			ReadyToEat,
			[Token(Token = "0x4000788")]
			FinishedBarking
		}

		[Token(Token = "0x400077B")]
		private const float NearDistacne = 0.5f;

		[Token(Token = "0x400077C")]
		private const float RunDistance = 2f;

		[Token(Token = "0x400077D")]
		private const float TooFarDistance = 20f;

		[Token(Token = "0x400077E")]
		private const float GiveUpTime = 15f;

		[Token(Token = "0x400077F")]
		private const float BarkDelay = 2f;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private State state;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float timer;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AnimalAIMoveCalculator moveCalulator;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Food targetFood;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xD26734", Offset = "0xD26734", VA = "0xD26734")]
		public AnimalAI_EatOnHand(AnimalAI ai)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xD28828", Offset = "0xD28828", VA = "0xD28828", Slot = "4")]
		public override void In(AnimalAIStateInfo msg)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xD28934", Offset = "0xD28934", VA = "0xD28934", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xD28D20", Offset = "0xD28D20", VA = "0xD28D20")]
		private void ChangeState_Moving()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xD2895C", Offset = "0xD2895C", VA = "0xD2895C")]
		private void Update_Moving()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xD28DE0", Offset = "0xD28DE0", VA = "0xD28DE0")]
		private bool CheckTooFar()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xD28E74", Offset = "0xD28E74", VA = "0xD28E74")]
		private bool CheckGiveUpTime()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xD28EE4", Offset = "0xD28EE4", VA = "0xD28EE4")]
		private void ChangeState_ReadyToEat()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xD28A9C", Offset = "0xD28A9C", VA = "0xD28A9C")]
		private void Update_ReadyToEat()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xD28F40", Offset = "0xD28F40", VA = "0xD28F40")]
		private void ChangeState_FinishedBarking()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xD28BC8", Offset = "0xD28BC8", VA = "0xD28BC8")]
		private void Update_FinishedBarking()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xD28F4C", Offset = "0xD28F4C", VA = "0xD28F4C", Slot = "6")]
		public override void Out(AnimalAI.State nextState)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xD288C4", Offset = "0xD288C4", VA = "0xD288C4")]
		private void ChangeState(State state)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xD28E88", Offset = "0xD28E88", VA = "0xD28E88")]
		private void Exit()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xD28D28", Offset = "0xD28D28", VA = "0xD28D28")]
		private bool CheckEatableFood(bool isEating)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200014C")]
	public class AnimalAI_GoToFavoritePlace : AnimalAIState
	{
		[Token(Token = "0x4000789")]
		private const float GoalDistance = 0.5f;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimalAIReactionStateChanger.Parameter ReactionParameter;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AnimalFavoritePlace goal;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 startPos;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 goalPos;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimalAIReactionStateChanger reaction;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AnimalAIMoveCalculator moveCalculator;

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xD2642C", Offset = "0xD2642C", VA = "0xD2642C")]
		public AnimalAI_GoToFavoritePlace(AnimalAI ai)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xD28FC4", Offset = "0xD28FC4", VA = "0xD28FC4", Slot = "4")]
		public override void In(AnimalAIStateInfo msg)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xD292A8", Offset = "0xD292A8", VA = "0xD292A8", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xD293A4", Offset = "0xD293A4", VA = "0xD293A4")]
		private void Update_Look()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xD2947C", Offset = "0xD2947C", VA = "0xD2947C", Slot = "6")]
		public override void Out(AnimalAI.State nextState)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xD2905C", Offset = "0xD2905C", VA = "0xD2905C")]
		private bool ChooseGoalPlace()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200014D")]
	public class AnimalAI_Idle : AnimalAIState
	{
		[Token(Token = "0x200014E")]
		public class AnimalAIStateInfo_Idle : AnimalAIStateInfo
		{
			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool changeStance;

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xD1198C", Offset = "0xD1198C", VA = "0xD1198C")]
			public AnimalAIStateInfo_Idle(bool changeStance)
			{
			}
		}

		[Token(Token = "0x200014F")]
		private enum IdleActionType
		{
			[Token(Token = "0x400079F")]
			Bark,
			[Token(Token = "0x40007A0")]
			Sleep,
			[Token(Token = "0x40007A1")]
			Action
		}

		[Token(Token = "0x4000790")]
		private const float Change_Stance_Time = 0.5f;

		[Token(Token = "0x4000791")]
		private const float IDLE_TIME_MIN = 5f;

		[Token(Token = "0x4000792")]
		private const float IDLE_TIME_MAX = 20f;

		[Token(Token = "0x4000793")]
		private const float IDLEACTION_OCCURRENCE_MIN = 1f;

		[Token(Token = "0x4000794")]
		private const float IDLEACTION_OCCURRENCE_MAX = 10f;

		[Token(Token = "0x4000795")]
		private const int IDLEACTION_OR_SLEEP = 10;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimalAIReactionStateChanger.Parameter ReactionParameter;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float idleTimer;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float changeStanceTimer;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float idleActionOccurrenceTimer;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool changeStance;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool actionPlayed;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AnimalAIReactionStateChanger reaction;

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xD26354", Offset = "0xD26354", VA = "0xD26354")]
		public AnimalAI_Idle(AnimalAI animalAI)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xD29524", Offset = "0xD29524", VA = "0xD29524", Slot = "4")]
		public override void In(AnimalAIStateInfo msg)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xD295F8", Offset = "0xD295F8", VA = "0xD295F8", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xD29738", Offset = "0xD29738", VA = "0xD29738")]
		private void Update_Look()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xD29964", Offset = "0xD29964", VA = "0xD29964", Slot = "6")]
		public override void Out(AnimalAI.State nextState)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xD29908", Offset = "0xD29908", VA = "0xD29908")]
		private void ChangeTimeOutNextState()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xD2984C", Offset = "0xD2984C", VA = "0xD2984C")]
		private void PlayIdleAction()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xD299CC", Offset = "0xD299CC", VA = "0xD299CC")]
		private IdleActionType GetRandomIdleActionType()
		{
			return default(IdleActionType);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xD297E8", Offset = "0xD297E8", VA = "0xD297E8")]
		private void CountChangeStanceTimer()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xD29BA8", Offset = "0xD29BA8", VA = "0xD29BA8")]
		private AnimalChara.StanceType RandomNextStance()
		{
			return default(AnimalChara.StanceType);
		}
	}
	[Token(Token = "0x2000150")]
	public class AnimalAI_Petted : AnimalAIState
	{
		[Token(Token = "0x40007A2")]
		private const float RollOverTime = 2f;

		[Token(Token = "0x40007A3")]
		private const float NormalCoolTime = 2f;

		[Token(Token = "0x40007A4")]
		private const float RollOverCoolTime = 4f;

		[Token(Token = "0x40007A5")]
		private const float BarkCoolTimeMin = 3f;

		[Token(Token = "0x40007A6")]
		private const float BarkCoolTimeMax = 4f;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimalAIReactionStateChanger.Parameter ReactionParameter;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float rollOverTimer;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool IsRollOverd;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float coolTimer;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool IsBarking;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float barkCoolTimer;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AnimalAIReactionStateChanger reaction;

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xD265A0", Offset = "0xD265A0", VA = "0xD265A0")]
		public AnimalAI_Petted(AnimalAI ai)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xD29D78", Offset = "0xD29D78", VA = "0xD29D78", Slot = "4")]
		public override void In(AnimalAIStateInfo msg)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xD29DB8", Offset = "0xD29DB8", VA = "0xD29DB8", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xD29E8C", Offset = "0xD29E8C", VA = "0xD29E8C")]
		private void Update_Petted()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xD29FF0", Offset = "0xD29FF0", VA = "0xD29FF0")]
		private void Update_NoPetted()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xD2A0B0", Offset = "0xD2A0B0", VA = "0xD2A0B0", Slot = "6")]
		public override void Out(AnimalAI.State nextState)
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class AnimalAI_PlayWithTheBall : AnimalAIState
	{
		[Token(Token = "0x2000152")]
		public class Info : AnimalAIStateInfo
		{
			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Ball ball;

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0xD119BC", Offset = "0xD119BC", VA = "0xD119BC")]
			public Info(Ball ball)
			{
			}
		}

		[Token(Token = "0x2000153")]
		private enum State
		{
			[Token(Token = "0x40007BF")]
			ChaseBall,
			[Token(Token = "0x40007C0")]
			WaitHoldBall,
			[Token(Token = "0x40007C1")]
			ChasePlayer,
			[Token(Token = "0x40007C2")]
			StarePlayer
		}

		[Token(Token = "0x40007AE")]
		private const float WalkCommandMagnitude = 1f;

		[Token(Token = "0x40007AF")]
		private const float RunCommandMagnitude = 2f;

		[Token(Token = "0x40007B0")]
		private const float MaxDistance = 250f;

		[Token(Token = "0x40007B1")]
		private const float WalkDistance = 0.5f;

		[Token(Token = "0x40007B2")]
		private const float GoalBallDistance = 0.1f;

		[Token(Token = "0x40007B3")]
		private const float GoalPlayerDistance = 1f;

		[Token(Token = "0x40007B4")]
		private const float GoalBallAllowY = 0.3f;

		[Token(Token = "0x40007B5")]
		private const float MaxChaseSecond = 20f;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float chaseTimer;

		[Token(Token = "0x40007B7")]
		private const float StareSecond = 5f;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float stareTimer;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private State state;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Ball targetBall;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool passHoldInAction;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool onesBark;

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xD26A20", Offset = "0xD26A20", VA = "0xD26A20")]
		public AnimalAI_PlayWithTheBall(AnimalAI ai)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xD2A140", Offset = "0xD2A140", VA = "0xD2A140", Slot = "4")]
		public override void In(AnimalAIStateInfo msg)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xD2A1E8", Offset = "0xD2A1E8", VA = "0xD2A1E8", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xD2A27C", Offset = "0xD2A27C", VA = "0xD2A27C")]
		private bool CheckMissingBall()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xD2A390", Offset = "0xD2A390", VA = "0xD2A390")]
		private void ChaseBall()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xD2AA00", Offset = "0xD2AA00", VA = "0xD2AA00")]
		private void HoldBall()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xD2A4F0", Offset = "0xD2A4F0", VA = "0xD2A4F0")]
		private void WaitHoldBall()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xD2A5B8", Offset = "0xD2A5B8", VA = "0xD2A5B8")]
		private void ChasePlayer()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xD2ABB4", Offset = "0xD2ABB4", VA = "0xD2ABB4")]
		private void ReleaseBall()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xD2A730", Offset = "0xD2A730", VA = "0xD2A730")]
		private void StarePlayer()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xD2ABE4", Offset = "0xD2ABE4", VA = "0xD2ABE4", Slot = "6")]
		public override void Out(AnimalAI.State nextState)
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xD2ABE8", Offset = "0xD2ABE8", VA = "0xD2ABE8")]
		private void ClearCommand()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xD2A950", Offset = "0xD2A950", VA = "0xD2A950")]
		private bool CheckBallGoal()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xD2AB08", Offset = "0xD2AB08", VA = "0xD2AB08")]
		private bool CheckPlayerGoal()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xD2A890", Offset = "0xD2A890", VA = "0xD2A890")]
		private bool IsOverMaxDistance(Vector3 target)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xD2A90C", Offset = "0xD2A90C", VA = "0xD2A90C")]
		private bool IsOverMaxChaseTime()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xD2A334", Offset = "0xD2A334", VA = "0xD2A334")]
		private void ToIdleState()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xD2AA34", Offset = "0xD2AA34", VA = "0xD2AA34")]
		private Vector3 CalcMoveCommand(Vector3 goal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000154")]
	public class AnimalAI_Sleep : AnimalAIState
	{
		[Token(Token = "0x40007C3")]
		private const float SLEEP_TIME_MIN = 15f;

		[Token(Token = "0x40007C4")]
		private const float SLEEP_TIME_MAX = 30f;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimalAIReactionStateChanger.Parameter ReactionParameter;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float sleepTimer;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AnimalAIReactionStateChanger reaction;

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xD267F8", Offset = "0xD267F8", VA = "0xD267F8")]
		public AnimalAI_Sleep(AnimalAI ai)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xD2AC64", Offset = "0xD2AC64", VA = "0xD2AC64", Slot = "4")]
		public override void In(AnimalAIStateInfo msg)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xD2ACC8", Offset = "0xD2ACC8", VA = "0xD2ACC8", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xD2AD8C", Offset = "0xD2AD8C", VA = "0xD2AD8C", Slot = "6")]
		public override void Out(AnimalAI.State nextState)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xD2AD30", Offset = "0xD2AD30", VA = "0xD2AD30")]
		private void ChangeTimeOutNextState()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class AnimalAI_Spoil : AnimalAIState
	{
		[Token(Token = "0x2000156")]
		private enum State
		{
			[Token(Token = "0x40007D3")]
			Moving,
			[Token(Token = "0x40007D4")]
			Spoil
		}

		[Token(Token = "0x40007C8")]
		private const float GOAL_DISTANCE = 0.3f;

		[Token(Token = "0x40007C9")]
		private const float GOAL_DISTANCE_MAX = 2f;

		[Token(Token = "0x40007CA")]
		private const float SPOIL_TIME_MIN = 3f;

		[Token(Token = "0x40007CB")]
		private const float SPOIL_TIME_MAX = 5f;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AnimalAIReactionStateChanger.Parameter ReactionParameter;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float spoilTime;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 goal;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private State state;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AnimalAIReactionStateChanger reaction;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimalAIMoveCalculator moveCalculator;

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xD268C8", Offset = "0xD268C8", VA = "0xD268C8")]
		public AnimalAI_Spoil(AnimalAI ai)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xD2AE1C", Offset = "0xD2AE1C", VA = "0xD2AE1C", Slot = "4")]
		public override void In(AnimalAIStateInfo msg)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xD2AEB0", Offset = "0xD2AEB0", VA = "0xD2AEB0", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xD2B0C4", Offset = "0xD2B0C4", VA = "0xD2B0C4", Slot = "6")]
		public override void Out(AnimalAI.State nextState)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xD2B04C", Offset = "0xD2B04C", VA = "0xD2B04C")]
		private bool CheckPlayerRecognition()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000157")]
	public abstract class AnimalBrain
	{
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xD25FD4", Offset = "0xD25FD4", VA = "0xD25FD4")]
		public AnimalBrain()
		{
		}

		[Token(Token = "0x60007F1")]
		public abstract void Update();

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xD329F0", Offset = "0xD329F0", VA = "0xD329F0", Slot = "5")]
		public virtual void Message(AnimalChara.MessageType type, string option)
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class AnimalManualControl : AnimalBrain
	{
		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara owner;

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xD13130", Offset = "0xD13130", VA = "0xD13130")]
		public AnimalManualControl(AnimalChara owner)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xD13164", Offset = "0xD13164", VA = "0xD13164", Slot = "4")]
		public override void Update()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public class AnimalQuestBrain_Bear01 : AnimalBrain
	{
		[Token(Token = "0x200015A")]
		private enum State
		{
			[Token(Token = "0x40007DC")]
			LookHoneycomb,
			[Token(Token = "0x40007DD")]
			ReadyEatFood,
			[Token(Token = "0x40007DE")]
			Thanks
		}

		[Token(Token = "0x40007D6")]
		private const float QuestFoodSearchDistance = 10f;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara owner;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Food targetFood;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private State state;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool thanked;

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xD13608", Offset = "0xD13608", VA = "0xD13608")]
		public AnimalQuestBrain_Bear01(AnimalChara owner)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xD13788", Offset = "0xD13788", VA = "0xD13788", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xD137B0", Offset = "0xD137B0", VA = "0xD137B0")]
		private void Update_LookHoneycomb()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xD138A8", Offset = "0xD138A8", VA = "0xD138A8")]
		private void Update_ReadyEatFood()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xD13A10", Offset = "0xD13A10", VA = "0xD13A10")]
		private void Update_Thanks()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xD13B4C", Offset = "0xD13B4C", VA = "0xD13B4C", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xD13B20", Offset = "0xD13B20", VA = "0xD13B20")]
		private void ChangeState(State state)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xD13658", Offset = "0xD13658", VA = "0xD13658")]
		private Food FindQuestFood()
		{
			return null;
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xD13B6C", Offset = "0xD13B6C", VA = "0xD13B6C")]
		private bool FindFoodFunction(FindableElement element)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200015B")]
	public class AnimalQuestBrain_Bear02 : AnimalBrain
	{
		[Token(Token = "0x200015C")]
		private enum State
		{
			[Token(Token = "0x40007E6")]
			Idle,
			[Token(Token = "0x40007E7")]
			MoveToPlayer,
			[Token(Token = "0x40007E8")]
			Thanks
		}

		[Token(Token = "0x40007DF")]
		private const float GOAL_DISTANCE = 0.5f;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform playerEye;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private State state;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimalChara owner;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool thanked;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AnimalAIMoveCalculator moveCalculator;

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xD13BAC", Offset = "0xD13BAC", VA = "0xD13BAC")]
		public AnimalQuestBrain_Bear02(AnimalChara owner)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xD13C78", Offset = "0xD13C78", VA = "0xD13C78", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xD13EB8", Offset = "0xD13EB8", VA = "0xD13EB8", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xD13DA0", Offset = "0xD13DA0", VA = "0xD13DA0")]
		private void UpdateMoveToPlayer()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xD13E04", Offset = "0xD13E04", VA = "0xD13E04")]
		private void UpdateThanks()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xD13F50", Offset = "0xD13F50", VA = "0xD13F50")]
		private void CompleteQuest()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xD13ECC", Offset = "0xD13ECC", VA = "0xD13ECC")]
		private AnimalAIMoveCalculator.STATE CalcMoveToPlayerCommand(out Vector3 moveCommand)
		{
			return default(AnimalAIMoveCalculator.STATE);
		}
	}
	[Token(Token = "0x200015D")]
	public class AnimalQuestBrain_Capybara : AnimalBrain
	{
		[Token(Token = "0x200015E")]
		private enum State
		{
			[Token(Token = "0x40007EE")]
			WaitFood,
			[Token(Token = "0x40007EF")]
			ReadyEatFood,
			[Token(Token = "0x40007F0")]
			Thanks
		}

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara owner;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Food targetFood;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private State state;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool thanked;

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xD13F6C", Offset = "0xD13F6C", VA = "0xD13F6C")]
		public AnimalQuestBrain_Capybara(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xD13FA8", Offset = "0xD13FA8", VA = "0xD13FA8", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xD13FD0", Offset = "0xD13FD0", VA = "0xD13FD0")]
		private void Update_WaitFood()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xD14364", Offset = "0xD14364", VA = "0xD14364")]
		private bool QuestFoodFindFunc(FindableElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xD140D0", Offset = "0xD140D0", VA = "0xD140D0")]
		private void Update_ReadyEatFood()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xD14228", Offset = "0xD14228", VA = "0xD14228")]
		private void Update_Thanks()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xD14338", Offset = "0xD14338", VA = "0xD14338")]
		private void ChangeState(State state)
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class AnimalQuestBrain_Cat01 : AnimalBrain
	{
		[Token(Token = "0x2000160")]
		private enum State
		{
			[Token(Token = "0x40007FB")]
			Idle,
			[Token(Token = "0x40007FC")]
			Moving,
			[Token(Token = "0x40007FD")]
			Eating,
			[Token(Token = "0x40007FE")]
			FinishedBarking
		}

		[Token(Token = "0x40007F1")]
		private const float RunDistance = 2f;

		[Token(Token = "0x40007F2")]
		private const float TooFarDistance = 20f;

		[Token(Token = "0x40007F3")]
		private const float GiveUpTime = 15f;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly FindableElement.Kind[] SearchPriority;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara owner;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private State state;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float movingTimer;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnimalAIMoveCalculator moveCalulator;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Food targetFood;

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xD143A8", Offset = "0xD143A8", VA = "0xD143A8")]
		public AnimalQuestBrain_Cat01(AnimalChara owner)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xD1456C", Offset = "0xD1456C", VA = "0xD1456C", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xD148EC", Offset = "0xD148EC", VA = "0xD148EC")]
		private void ChangeState_Idle()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xD145A0", Offset = "0xD145A0", VA = "0xD145A0")]
		private void Update_Idle()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xD148F8", Offset = "0xD148F8", VA = "0xD148F8")]
		private void ChangeState_Moving()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xD14624", Offset = "0xD14624", VA = "0xD14624")]
		private void Update_Moving()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xD149B8", Offset = "0xD149B8", VA = "0xD149B8")]
		private bool CheckTooFar()
		{
			return default(bool);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xD14A4C", Offset = "0xD14A4C", VA = "0xD14A4C")]
		private bool CheckGiveUpTime()
		{
			return default(bool);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xD14A60", Offset = "0xD14A60", VA = "0xD14A60")]
		private void ChangeState_Eating()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xD14770", Offset = "0xD14770", VA = "0xD14770")]
		private void Update_Eating()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xD14A8C", Offset = "0xD14A8C", VA = "0xD14A8C")]
		private void ChangeState_FinishedBarking()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xD147E0", Offset = "0xD147E0", VA = "0xD147E0")]
		private void Update_FinishedBarking()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xD144D0", Offset = "0xD144D0", VA = "0xD144D0")]
		private void ChangeState(State state)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xD14900", Offset = "0xD14900", VA = "0xD14900")]
		private bool CheckEatableFood(bool isEating)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000161")]
	public class AnimalQuestBrain_Cat02 : AnimalBrain
	{
		[Token(Token = "0x2000162")]
		private enum State
		{
			[Token(Token = "0x4000808")]
			Idle,
			[Token(Token = "0x4000809")]
			Cross_RubbleRoad,
			[Token(Token = "0x400080A")]
			Thanks
		}

		[Token(Token = "0x40007FF")]
		private const float GOAL_DISTANCE = 0.5f;

		[Token(Token = "0x4000800")]
		private const float Move_Run = 2f;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private State state;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara owner;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform playerEye;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool thanked;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AnimalAIMoveCalculator moveCalculator;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 goalPos;

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xD14AC0", Offset = "0xD14AC0", VA = "0xD14AC0")]
		public AnimalQuestBrain_Cat02(AnimalChara owner)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xD14B90", Offset = "0xD14B90", VA = "0xD14B90", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xD14DE4", Offset = "0xD14DE4", VA = "0xD14DE4", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xD14CB8", Offset = "0xD14CB8", VA = "0xD14CB8")]
		private void UpdateCrossRubbleRoad()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xD14D30", Offset = "0xD14D30", VA = "0xD14D30")]
		private void UpdateThanks()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xD14FA0", Offset = "0xD14FA0", VA = "0xD14FA0")]
		private void CompleteQuest()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xD14F8C", Offset = "0xD14F8C", VA = "0xD14F8C")]
		private void CanCrossRubbleRoad(Vector3 goalPos)
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class AnimalQuestBrain_Chick : AnimalBrain
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform playerEye;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara owner;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isCompletedQuest;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool thanked;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool onDroppedWater;

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xD14FBC", Offset = "0xD14FBC", VA = "0xD14FBC")]
		public AnimalQuestBrain_Chick(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xD14FF8", Offset = "0xD14FF8", VA = "0xD14FF8", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xD15030", Offset = "0xD15030", VA = "0xD15030", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xD15180", Offset = "0xD15180", VA = "0xD15180")]
		private void UpdateThanks()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class AnimalQuestBrain_Chinchilla : AnimalBrain
	{
		[Token(Token = "0x2000165")]
		private enum State
		{
			[Token(Token = "0x4000819")]
			Idle,
			[Token(Token = "0x400081A")]
			Moving,
			[Token(Token = "0x400081B")]
			Eating,
			[Token(Token = "0x400081C")]
			FinishedBarking
		}

		[Token(Token = "0x4000810")]
		private const float RunDistance = 2f;

		[Token(Token = "0x4000811")]
		private const float TooFarDistance = 20f;

		[Token(Token = "0x4000812")]
		private const float GiveUpTime = 15f;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara owner;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private State state;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float movingTimer;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimalAIMoveCalculator moveCalulator;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Food targetFood;

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xD15234", Offset = "0xD15234", VA = "0xD15234")]
		public AnimalQuestBrain_Chinchilla(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xD153A8", Offset = "0xD153A8", VA = "0xD153A8", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xD15798", Offset = "0xD15798", VA = "0xD15798")]
		private void ChangeState_Idle()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xD153DC", Offset = "0xD153DC", VA = "0xD153DC")]
		private void Update_Idle()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xD157A4", Offset = "0xD157A4", VA = "0xD157A4")]
		private bool SearchFood(FindableElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xD157E8", Offset = "0xD157E8", VA = "0xD157E8")]
		private void ChangeState_Moving()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xD154D0", Offset = "0xD154D0", VA = "0xD154D0")]
		private void Update_Moving()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xD158A8", Offset = "0xD158A8", VA = "0xD158A8")]
		private bool CheckTooFar()
		{
			return default(bool);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xD1593C", Offset = "0xD1593C", VA = "0xD1593C")]
		private bool CheckGiveUpTime()
		{
			return default(bool);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xD15950", Offset = "0xD15950", VA = "0xD15950")]
		private void ChangeState_Eating()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xD1561C", Offset = "0xD1561C", VA = "0xD1561C")]
		private void Update_Eating()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xD1597C", Offset = "0xD1597C", VA = "0xD1597C")]
		private void ChangeState_FinishedBarking()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xD1568C", Offset = "0xD1568C", VA = "0xD1568C")]
		private void Update_FinishedBarking()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xD1530C", Offset = "0xD1530C", VA = "0xD1530C")]
		private void ChangeState(State state)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xD157F0", Offset = "0xD157F0", VA = "0xD157F0")]
		private bool CheckEatableFood(bool isEating)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000166")]
	public class AnimalQuestBrain_Dog01 : AnimalBrain
	{
		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform playerEye;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara owner;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isCompletedQuest;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool thanked;

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xD159B0", Offset = "0xD159B0", VA = "0xD159B0")]
		public AnimalQuestBrain_Dog01(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xD159EC", Offset = "0xD159EC", VA = "0xD159EC", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xD15A00", Offset = "0xD15A00", VA = "0xD15A00", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xD15B20", Offset = "0xD15B20", VA = "0xD15B20")]
		private void UpdateThanks()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class AnimalQuestBrain_Dog02 : AnimalBrain
	{
		[Token(Token = "0x2000168")]
		private enum STATE
		{
			[Token(Token = "0x4000826")]
			CANT_GET_DOWN,
			[Token(Token = "0x4000827")]
			THANKS
		}

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private STATE state;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool isCompleteQuestCondition;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		private bool thanked;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara owner;

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xD15BD4", Offset = "0xD15BD4", VA = "0xD15BD4")]
		public AnimalQuestBrain_Dog02(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xD15C08", Offset = "0xD15C08", VA = "0xD15C08", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xD15D8C", Offset = "0xD15D8C", VA = "0xD15D8C", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xD15CC8", Offset = "0xD15CC8", VA = "0xD15CC8")]
		private void Update_CantGetDown()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xD15DA0", Offset = "0xD15DA0", VA = "0xD15DA0")]
		private void ChangeStateThanks()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xD15CD8", Offset = "0xD15CD8", VA = "0xD15CD8")]
		private void Update_Thanks()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xD15DD4", Offset = "0xD15DD4", VA = "0xD15DD4")]
		private void CompleteQuest()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class AnimalQuestBrain_Duck : AnimalBrain
	{
		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform playerEye;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara owner;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isCompletedCondition;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool thanked;

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xD15DF0", Offset = "0xD15DF0", VA = "0xD15DF0")]
		public AnimalQuestBrain_Duck(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xD15E2C", Offset = "0xD15E2C", VA = "0xD15E2C", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xD15FF0", Offset = "0xD15FF0", VA = "0xD15FF0", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xD15F3C", Offset = "0xD15F3C", VA = "0xD15F3C")]
		private void UpdateThanks()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xD16004", Offset = "0xD16004", VA = "0xD16004")]
		private void CompleteQuest()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class AnimalQuestBrain_Fox01 : AnimalBrain
	{
		[Token(Token = "0x200016B")]
		private enum State
		{
			[Token(Token = "0x4000833")]
			WaitFood,
			[Token(Token = "0x4000834")]
			DislikeWholeApple,
			[Token(Token = "0x4000835")]
			ReadyEatFood,
			[Token(Token = "0x4000836")]
			Thanks
		}

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara owner;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DislikeItem dislikeItem;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Food targetFood;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private State state;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool thanked;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 firstLookPos;

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xD16038", Offset = "0xD16038", VA = "0xD16038")]
		public AnimalQuestBrain_Fox01(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xD16074", Offset = "0xD16074", VA = "0xD16074", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xD16608", Offset = "0xD16608", VA = "0xD16608", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xD160A8", Offset = "0xD160A8", VA = "0xD160A8")]
		private void Update_WaitFood()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xD16688", Offset = "0xD16688", VA = "0xD16688")]
		private bool FindAppleFunc(FindableElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xD16258", Offset = "0xD16258", VA = "0xD16258")]
		private void Update_DislikeWholeApple()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xD16378", Offset = "0xD16378", VA = "0xD16378")]
		private void Update_ReadyEatFood()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xD164F8", Offset = "0xD164F8", VA = "0xD164F8")]
		private void Update_Thanks()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xD1665C", Offset = "0xD1665C", VA = "0xD1665C")]
		private void ChangeState(State state)
		{
		}
	}
	[Token(Token = "0x200016C")]
	public class AnimalQuestBrain_Fox02 : AnimalBrain
	{
		[Token(Token = "0x200016D")]
		private enum State
		{
			[Token(Token = "0x400083D")]
			LookIce,
			[Token(Token = "0x400083E")]
			ReadyEatFood,
			[Token(Token = "0x400083F")]
			Thanks
		}

		[Token(Token = "0x4000837")]
		private const float QuestFoodSearchDistance = 2f;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara owner;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Food targetFood;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private State state;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool thanked;

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xD166D4", Offset = "0xD166D4", VA = "0xD166D4")]
		public AnimalQuestBrain_Fox02(AnimalChara owner)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xD16710", Offset = "0xD16710", VA = "0xD16710", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xD16730", Offset = "0xD16730", VA = "0xD16730")]
		private void Update_ReadyEatFood()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xD16868", Offset = "0xD16868", VA = "0xD16868")]
		private void Update_Thanks()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xD16978", Offset = "0xD16978", VA = "0xD16978", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xD169B0", Offset = "0xD169B0", VA = "0xD169B0")]
		private void ChangeState(State state)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xD16A18", Offset = "0xD16A18", VA = "0xD16A18")]
		private Food FindQuestFood()
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xD16B48", Offset = "0xD16B48", VA = "0xD16B48")]
		private bool FindFoodFunction(FindableElement element)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200016E")]
	public class AnimalQuestBrain_Otters : AnimalBrain
	{
		[Token(Token = "0x200016F")]
		private enum State
		{
			[Token(Token = "0x4000845")]
			WaitFood,
			[Token(Token = "0x4000846")]
			ReadyEatFood,
			[Token(Token = "0x4000847")]
			Thanks
		}

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara owner;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Food targetFood;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private State state;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool thanked;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xD16B88", Offset = "0xD16B88", VA = "0xD16B88")]
		public AnimalQuestBrain_Otters(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xD16BC4", Offset = "0xD16BC4", VA = "0xD16BC4", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xD16BEC", Offset = "0xD16BEC", VA = "0xD16BEC")]
		private void Update_WaitFood()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xD16F74", Offset = "0xD16F74", VA = "0xD16F74")]
		private bool QuestFoodFindFunc(FindableElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xD16CEC", Offset = "0xD16CEC", VA = "0xD16CEC")]
		private void Update_ReadyEatFood()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xD16E38", Offset = "0xD16E38", VA = "0xD16E38")]
		private void Update_Thanks()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xD16F48", Offset = "0xD16F48", VA = "0xD16F48")]
		private void ChangeState(State state)
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class AnimalQuestBrain_Penguin : AnimalBrain
	{
		[Token(Token = "0x2000171")]
		private enum STATE
		{
			[Token(Token = "0x400084D")]
			CANT_GET_DOWN,
			[Token(Token = "0x400084E")]
			THANKS
		}

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private STATE state;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool isCompleteQuestCondition;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		private bool thanked;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara owner;

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xD16FB8", Offset = "0xD16FB8", VA = "0xD16FB8")]
		public AnimalQuestBrain_Penguin(AnimalChara owner)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xD16FEC", Offset = "0xD16FEC", VA = "0xD16FEC", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xD17170", Offset = "0xD17170", VA = "0xD17170", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xD170AC", Offset = "0xD170AC", VA = "0xD170AC")]
		private void Update_CantGetDown()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xD17184", Offset = "0xD17184", VA = "0xD17184")]
		private void ChangeStateThanks()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xD170BC", Offset = "0xD170BC", VA = "0xD170BC")]
		private void Update_Thanks()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xD171B8", Offset = "0xD171B8", VA = "0xD171B8")]
		private void CompleteQuest()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class AnimalQuestBrain_Pig : AnimalBrain
	{
		[Token(Token = "0x2000173")]
		private enum State
		{
			[Token(Token = "0x4000859")]
			Idle,
			[Token(Token = "0x400085A")]
			Move,
			[Token(Token = "0x400085B")]
			Thanks
		}

		[Token(Token = "0x400084F")]
		private const float GOAL_DISTANCE = 1f;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int Default_Layer;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int ThroughInvisibleWall_Layer;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private State state;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara owner;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform playerEye;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool thanked;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AnimalAIMoveCalculator moveCalculator;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 goalPos;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xD171D4", Offset = "0xD171D4", VA = "0xD171D4")]
		public AnimalQuestBrain_Pig(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xD172A0", Offset = "0xD172A0", VA = "0xD172A0", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xD17388", Offset = "0xD17388", VA = "0xD17388")]
		private void UpdateMove()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xD17400", Offset = "0xD17400", VA = "0xD17400")]
		private void UpdateThanks()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xD17504", Offset = "0xD17504", VA = "0xD17504")]
		private void CompleteQuest()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xD17520", Offset = "0xD17520", VA = "0xD17520", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class AnimalQuestBrain_Rabbit01 : AnimalBrain
	{
		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform playerEye;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara owner;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isCompletedQuestCondition;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool thanked;

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xD175F8", Offset = "0xD175F8", VA = "0xD175F8")]
		public AnimalQuestBrain_Rabbit01(AnimalChara owner)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xD17634", Offset = "0xD17634", VA = "0xD17634", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xD17744", Offset = "0xD17744", VA = "0xD17744")]
		private void UpdateThanks()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xD17864", Offset = "0xD17864", VA = "0xD17864", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xD17848", Offset = "0xD17848", VA = "0xD17848")]
		private void CompleteQuest()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class AnimalQuestBrain_Rabbit02 : AnimalBrain
	{
		[Token(Token = "0x2000176")]
		private enum STATE
		{
			[Token(Token = "0x4000868")]
			CANT_GET_OUT,
			[Token(Token = "0x4000869")]
			WAIT_GET_OUT,
			[Token(Token = "0x400086A")]
			THANKS
		}

		[Token(Token = "0x4000860")]
		private const float OutWaitTime = 1f;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private STATE state;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool getouted;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		private bool thanked;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AnimalChara owner;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isCompleteQuestCondition;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float outWaitTimer;

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xD17878", Offset = "0xD17878", VA = "0xD17878")]
		public AnimalQuestBrain_Rabbit02(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xD178AC", Offset = "0xD178AC", VA = "0xD178AC", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xD17B50", Offset = "0xD17B50", VA = "0xD17B50", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xD17978", Offset = "0xD17978", VA = "0xD17978")]
		private void Update_CantGetOut()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xD17B64", Offset = "0xD17B64", VA = "0xD17B64")]
		private void ChangeState_WaitGetOut()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xD179D8", Offset = "0xD179D8", VA = "0xD179D8")]
		private void Update_WaitGetOut()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xD17B94", Offset = "0xD17B94", VA = "0xD17B94")]
		private void ChangeState_Thanks()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xD17A9C", Offset = "0xD17A9C", VA = "0xD17A9C")]
		private void Update_Thanks()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xD17BC8", Offset = "0xD17BC8", VA = "0xD17BC8")]
		private void FinishQuest()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class AnimalQuestBrain_Seal : AnimalBrain
	{
		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimalChara owner;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform playerEye;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isCompletedQuestCondition;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool thanked;

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xD17BE4", Offset = "0xD17BE4", VA = "0xD17BE4")]
		public AnimalQuestBrain_Seal(AnimalChara owner)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xD17C20", Offset = "0xD17C20", VA = "0xD17C20", Slot = "4")]
		public override void Update()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xD17DE4", Offset = "0xD17DE4", VA = "0xD17DE4", Slot = "5")]
		public override void Message(AnimalChara.MessageType type, string option)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xD17D30", Offset = "0xD17D30", VA = "0xD17D30")]
		private void UpdateThanks()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xD17DF8", Offset = "0xD17DF8", VA = "0xD17DF8")]
		private void CompleteQuest()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class AIMover
	{
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NavMeshAgent navMeshAgent;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CharacterController characterController;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 velocity;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool enable;

		[Token(Token = "0x1700009D")]
		public bool Enable
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0xD25588", Offset = "0xD25588", VA = "0xD25588")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600087E")]
			[Address(RVA = "0xD25590", Offset = "0xD25590", VA = "0xD25590")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public bool IsGrounded
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0xD25604", Offset = "0xD25604", VA = "0xD25604")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xD25654", Offset = "0xD25654", VA = "0xD25654")]
		public AIMover(NavMeshAgent navMeshAgent, CharacterController characterController)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xD25598", Offset = "0xD25598", VA = "0xD25598")]
		private void SetEnable(bool isEnable)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xD256EC", Offset = "0xD256EC", VA = "0xD256EC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xD257E4", Offset = "0xD257E4", VA = "0xD257E4")]
		public int SampleNavMeshArea()
		{
			return default(int);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xD25870", Offset = "0xD25870", VA = "0xD25870")]
		public Vector3 GetVectorToGoal(Vector3 goalPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xD2590C", Offset = "0xD2590C", VA = "0xD2590C")]
		public void Move(Vector3 velocity)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xD25944", Offset = "0xD25944", VA = "0xD25944")]
		public void SetPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xD259C4", Offset = "0xD259C4", VA = "0xD259C4")]
		public void SetRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xD25A4C", Offset = "0xD25A4C", VA = "0xD25A4C")]
		public void Teleport(Vector3 position, Quaternion rotation)
		{
		}
	}
}
namespace SimpleLightProbePlacer
{
	[Token(Token = "0x2000179")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x43F464", Offset = "0x43F464")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x43F464", Offset = "0x43F464")]
	public class LightProbeGroupControl : MonoBehaviour
	{
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_mergeDistance;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_usePointLights;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_pointLightRange;

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x92D198", Offset = "0x92D198", VA = "0x92D198")]
		public LightProbeGroupControl()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public enum LightProbeVolumeType
	{
		[Token(Token = "0x4000877")]
		Fixed,
		[Token(Token = "0x4000878")]
		Float
	}
	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x43F4E8", Offset = "0x43F4E8")]
	public class LightProbeVolume : TransformVolume
	{
		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LightProbeVolumeType m_type;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 m_densityFixed;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 m_densityFloat;

		[Token(Token = "0x1700009F")]
		public LightProbeVolumeType Type
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x92D1B8", Offset = "0x92D1B8", VA = "0x92D1B8")]
			get
			{
				return default(LightProbeVolumeType);
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x92D1C0", Offset = "0x92D1C0", VA = "0x92D1C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public Vector3 Density
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x92D1C8", Offset = "0x92D1C8", VA = "0x92D1C8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x92D204", Offset = "0x92D204", VA = "0x92D204")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public static Color EditorColor
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x92D224", Offset = "0x92D224", VA = "0x92D224")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x92D264", Offset = "0x92D264", VA = "0x92D264")]
		public List<Vector3> CreatePositions()
		{
			return null;
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x92D26C", Offset = "0x92D26C", VA = "0x92D26C")]
		public List<Vector3> CreatePositions(LightProbeVolumeType type)
		{
			return null;
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x92D55C", Offset = "0x92D55C", VA = "0x92D55C")]
		public static List<Vector3> CreatePositionsFixed(Transform volumeTransform, Vector3 origin, Vector3 size, Vector3 density)
		{
			return null;
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x92D360", Offset = "0x92D360", VA = "0x92D360")]
		public static List<Vector3> CreatePositionsFloat(Transform volumeTransform, Vector3 origin, Vector3 size, Vector3 density)
		{
			return null;
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x92D764", Offset = "0x92D764", VA = "0x92D764")]
		public LightProbeVolume()
		{
		}
	}
	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x43F520", Offset = "0x43F520")]
	public class TransformVolume : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F558", Offset = "0x43F558")]
		private sealed class <>c
		{
			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Vector3, Vector3, Vector3> <>9__14_0;

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xCCDBE0", Offset = "0xCCDBE0", VA = "0xCCDBE0")]
			public <>c()
			{
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xCCDBE8", Offset = "0xCCDBE8", VA = "0xCCDBE8")]
			internal Vector3 <GetBounds>b__14_0(Vector3 result, Vector3 point)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Volume m_volume;

		[Token(Token = "0x170000A2")]
		public Volume Volume
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0xD0DA84", Offset = "0xD0DA84", VA = "0xD0DA84")]
			get
			{
				return default(Volume);
			}
			[Token(Token = "0x6000895")]
			[Address(RVA = "0xD0DA98", Offset = "0xD0DA98", VA = "0xD0DA98")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public Vector3 Origin
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0xD0DAAC", Offset = "0xD0DAAC", VA = "0xD0DAAC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A4")]
		public Vector3 Size
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0xD0DAB8", Offset = "0xD0DAB8", VA = "0xD0DAB8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xD0DAC4", Offset = "0xD0DAC4", VA = "0xD0DAC4")]
		public bool IsInBounds(Vector3[] points)
		{
			return default(bool);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xD0DD78", Offset = "0xD0DD78", VA = "0xD0DD78")]
		public bool IsOnBorder(Vector3[] points)
		{
			return default(bool);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xD0DE8C", Offset = "0xD0DE8C", VA = "0xD0DE8C")]
		public bool IsInVolume(Vector3[] points)
		{
			return default(bool);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xD0DF40", Offset = "0xD0DF40", VA = "0xD0DF40")]
		public bool IsInVolume(Vector3 position)
		{
			return default(bool);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xD0E348", Offset = "0xD0E348", VA = "0xD0E348")]
		public Vector3[] GetCorners()
		{
			return null;
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xD0DB1C", Offset = "0xD0DB1C", VA = "0xD0DB1C")]
		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xD0DB60", Offset = "0xD0DB60", VA = "0xD0DB60")]
		public Bounds GetBounds(Vector3[] points)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xD0E510", Offset = "0xD0E510", VA = "0xD0E510")]
		public GameObject[] GetGameObjectsInBounds(LayerMask layerMask)
		{
			return null;
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xD0E00C", Offset = "0xD0E00C", VA = "0xD0E00C")]
		public Vector3 GetSideDirection(int side)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xD0E180", Offset = "0xD0E180", VA = "0xD0E180")]
		public Vector3 GetSidePosition(int side)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xD0E81C", Offset = "0xD0E81C", VA = "0xD0E81C")]
		public float GetSizeAxis(int side)
		{
			return default(float);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xD0E854", Offset = "0xD0E854", VA = "0xD0E854")]
		public TransformVolume()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xD0E8C0", Offset = "0xD0E8C0", VA = "0xD0E8C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443A28", Offset = "0x443A28")]
		private bool <IsOnBorder>b__9_0(Vector3 x)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x200017E")]
	public struct Volume
	{
		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Vector3 m_origin;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Vector3 m_size;

		[Token(Token = "0x170000A5")]
		public Vector3 Origin
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xD0FF28", Offset = "0xD0FF28", VA = "0xD0FF28")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A6")]
		public Vector3 Size
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xD0FF34", Offset = "0xD0FF34", VA = "0xD0FF34")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xD0E8B0", Offset = "0xD0E8B0", VA = "0xD0E8B0")]
		public Volume(Vector3 origin, Vector3 size)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xD0FF40", Offset = "0xD0FF40", VA = "0xD0FF40")]
		public static bool operator ==(Volume left, Volume right)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xD0FFD4", Offset = "0xD0FFD4", VA = "0xD0FFD4")]
		public static bool operator !=(Volume left, Volume right)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xD0FF74", Offset = "0xD0FF74", VA = "0xD0FF74")]
		public bool Equals(Volume other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xD1000C", Offset = "0xD1000C", VA = "0xD1000C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xD100A8", Offset = "0xD100A8", VA = "0xD100A8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xD10114", Offset = "0xD10114", VA = "0xD10114", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
