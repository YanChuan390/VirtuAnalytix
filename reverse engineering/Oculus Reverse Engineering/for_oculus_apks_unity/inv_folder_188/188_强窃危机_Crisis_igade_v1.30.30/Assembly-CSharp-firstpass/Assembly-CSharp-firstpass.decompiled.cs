using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ExampleScript : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text batteryText;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool auto;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool activeResearch;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float autoTimer;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float autoDelay;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private ForceTubeVRChannel target;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x9F763C", Offset = "0x9F763C", VA = "0x9F763C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x9F77F8", Offset = "0x9F77F8", VA = "0x9F77F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x9F7C1C", Offset = "0x9F7C1C", VA = "0x9F7C1C")]
	public void Shoot()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x9F7C9C", Offset = "0x9F7C9C", VA = "0x9F7C9C")]
	public void AutoShoot()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x9F7CAC", Offset = "0x9F7CAC", VA = "0x9F7CAC")]
	public void Kick()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x9F7E88", Offset = "0x9F7E88", VA = "0x9F7E88")]
	public void Rumble()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x9F80D4", Offset = "0x9F80D4", VA = "0x9F80D4")]
	public void SetTargetChannel(int target)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x9F80DC", Offset = "0x9F80DC", VA = "0x9F80DC")]
	public void SetActiveResearch()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x9F8298", Offset = "0x9F8298", VA = "0x9F8298")]
	public void OpenBluetoothSettings()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9F83D0", Offset = "0x9F83D0", VA = "0x9F83D0")]
	public ExampleScript()
	{
	}
}
[Token(Token = "0x2000003")]
public enum ForceTubeVRChannel
{
	[Token(Token = "0x4000008")]
	all,
	[Token(Token = "0x4000009")]
	rifle,
	[Token(Token = "0x400000A")]
	rifleButt,
	[Token(Token = "0x400000B")]
	rifleBolt,
	[Token(Token = "0x400000C")]
	pistol1,
	[Token(Token = "0x400000D")]
	pistol2,
	[Token(Token = "0x400000E")]
	other,
	[Token(Token = "0x400000F")]
	vest
}
[Token(Token = "0x2000004")]
public class ForceTubeVRInterface : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class <InitAndroid>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool pistolsFirst;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x9F8A2C", Offset = "0x9F8A2C", VA = "0x9F8A2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x9F8A74", Offset = "0x9F8A74", VA = "0x9F8A74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x9F8458", Offset = "0x9F8458", VA = "0x9F8458")]
		[DebuggerHidden]
		public <InitAndroid>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x9F8678", Offset = "0x9F8678", VA = "0x9F8678", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x9F867C", Offset = "0x9F867C", VA = "0x9F867C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x9F8A34", Offset = "0x9F8A34", VA = "0x9F8A34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ForceTubeVRInterface instance;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AndroidJavaObject ForceTubeVRPlugin;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x9F83EC", Offset = "0x9F83EC", VA = "0x9F83EC")]
	[IteratorStateMachine(typeof(<InitAndroid>d__2))]
	private static IEnumerator InitAndroid(bool pistolsFirst)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x9F76AC", Offset = "0x9F76AC", VA = "0x9F76AC")]
	public static void InitAsync(bool pistolsFirst = false)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x9F7D24", Offset = "0x9F7D24", VA = "0x9F7D24")]
	public static void Kick(byte power, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x9F7F04", Offset = "0x9F7F04", VA = "0x9F7F04")]
	public static void Rumble(byte power, float duration, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x9F7920", Offset = "0x9F7920", VA = "0x9F7920")]
	public static void Shoot(byte kickPower, byte rumblePower, float rumbleDuration, ForceTubeVRChannel target = ForceTubeVRChannel.rifle)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x9F818C", Offset = "0x9F818C", VA = "0x9F818C")]
	public static void SetActiveResearch(bool active)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x9F8480", Offset = "0x9F8480", VA = "0x9F8480")]
	public static byte TempoToKickPower(float tempo)
	{
		return default(byte);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x9F7B38", Offset = "0x9F7B38", VA = "0x9F7B38")]
	public static byte GetBatteryLevel()
	{
		return default(byte);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x9F8304", Offset = "0x9F8304", VA = "0x9F8304")]
	public static void OpenBluetoothSettings()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x9F85A4", Offset = "0x9F85A4", VA = "0x9F85A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x9F8670", Offset = "0x9F8670", VA = "0x9F8670")]
	public ForceTubeVRInterface()
	{
	}
}
[Token(Token = "0x2000006")]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ConfigurableJoint[] leftLeg;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConfigurableJoint[] rightLeg;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool leftLegRemoved;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool rightLegRemoved;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x9F8A7C", Offset = "0x9F8A7C", VA = "0x9F8A7C")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x9F8B44", Offset = "0x9F8B44", VA = "0x9F8B44")]
	private void OnMuscleRemoved(Muscle m)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x9F8C04", Offset = "0x9F8C04", VA = "0x9F8C04")]
	private bool IsLegMuscle(Muscle m, out bool isLeft)
	{
		return default(bool);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x9F8D5C", Offset = "0x9F8D5C", VA = "0x9F8D5C")]
	public Skeleton()
	{
	}
}
namespace UnLogickFactory
{
	[Token(Token = "0x2000007")]
	public class FbxCustomPropertyExporterExample : MonoBehaviour
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("filename")]
		public string editorFilename;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string runtimeFilename;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int logLevel;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool manuallyExport;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x9F8D64", Offset = "0x9F8D64", VA = "0x9F8D64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x9F8D74", Offset = "0x9F8D74", VA = "0x9F8D74")]
		public void Export()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x9FBA14", Offset = "0x9FBA14", VA = "0x9FBA14")]
		private void OnFbxNodeCallback(Transform transform, IntPtr fbxNode)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x9FBAA4", Offset = "0x9FBAA4", VA = "0x9FBAA4")]
		private void OnFbxMeshCallback(Transform transform, IntPtr fbxNode, MeshRenderer meshRenderer, IntPtr fbxMesh)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x9FBB90", Offset = "0x9FBB90", VA = "0x9FBB90")]
		private void OnFbxTerrainCallback(Transform transform, IntPtr fbxNode, Terrain terrain, IntPtr fbxMesh)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x9FBC94", Offset = "0x9FBC94", VA = "0x9FBC94")]
		private void OnFbxSkinnedMeshCallback(Transform transform, IntPtr fbxNode, SkinnedMeshRenderer skinnedMeshRenderer, IntPtr fbxMesh)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x9FBD38", Offset = "0x9FBD38", VA = "0x9FBD38")]
		private void OnFbxMaterialCallback(Transform transform, IntPtr fbxNode, IntPtr fbxMaterial, IntPtr[] fbxTextures)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x9FBDDC", Offset = "0x9FBDDC", VA = "0x9FBDDC")]
		public FbxCustomPropertyExporterExample()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public static class AnimatorExtension
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MethodInfo _writeDefaultPoseMethodInfo;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x9FBE50", Offset = "0x9FBE50", VA = "0x9FBE50")]
		public static void SetTPose(this Animator animator)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class FbxCustomProperty
	{
		[Token(Token = "0x200000A")]
		public enum FbxCustomPropertyType
		{
			[Token(Token = "0x4000036")]
			Color,
			[Token(Token = "0x4000037")]
			Double4,
			[Token(Token = "0x4000038")]
			Double3,
			[Token(Token = "0x4000039")]
			Double2,
			[Token(Token = "0x400003A")]
			Matrix,
			[Token(Token = "0x400003B")]
			Double,
			[Token(Token = "0x400003C")]
			Bool,
			[Token(Token = "0x400003D")]
			Long,
			[Token(Token = "0x400003E")]
			String
		}

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FbxCustomPropertyType type;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private double m11;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private double m12;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private double m13;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private double m14;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private double m21;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private double m22;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private double m23;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private double m24;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private double m31;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private double m32;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private double m33;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private double m34;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private double m41;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private double m42;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private double m43;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private double m44;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool boolValue;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string stringValue;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private long longValue;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string propertyName;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x9FC030", Offset = "0x9FC030", VA = "0x9FC030")]
		public void SetValue(float value)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x9FC044", Offset = "0x9FC044", VA = "0x9FC044")]
		public void SetValue(Vector2 value)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x9FC05C", Offset = "0x9FC05C", VA = "0x9FC05C")]
		public void SetValue(Vector3 value)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x9FC07C", Offset = "0x9FC07C", VA = "0x9FC07C")]
		public void SetValue(Vector4 value)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x9FC09C", Offset = "0x9FC09C", VA = "0x9FC09C")]
		public void SetValue(Color value)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x9FC0B8", Offset = "0x9FC0B8", VA = "0x9FC0B8")]
		public void SetValue(Matrix4x4 value)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x9FC184", Offset = "0x9FC184", VA = "0x9FC184")]
		public void SetValue(bool value)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x9FC198", Offset = "0x9FC198", VA = "0x9FC198")]
		public void SetValue(string value)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x9FC1A8", Offset = "0x9FC1A8", VA = "0x9FC1A8")]
		public void SetValue(long value)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x9FC1B8", Offset = "0x9FC1B8", VA = "0x9FC1B8")]
		public void Apply(IntPtr target)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x9FC50C", Offset = "0x9FC50C", VA = "0x9FC50C")]
		public FbxCustomProperty()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public abstract class FbxCustomPropertyBehaviour : MonoBehaviour
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FbxCustomProperty[] customProperties;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x9FC55C", Offset = "0x9FC55C", VA = "0x9FC55C")]
		public void Apply(IntPtr target)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x9FC5C0", Offset = "0x9FC5C0", VA = "0x9FC5C0")]
		protected FbxCustomPropertyBehaviour()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class FbxMaterialCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x9FC5C8", Offset = "0x9FC5C8", VA = "0x9FC5C8")]
		public FbxMaterialCustomProperties()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class FbxMeshCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x9FC5D0", Offset = "0x9FC5D0", VA = "0x9FC5D0")]
		public FbxMeshCustomProperties()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class FbxNodeCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x9FC5D8", Offset = "0x9FC5D8", VA = "0x9FC5D8")]
		public FbxNodeCustomProperties()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class FbxShaderProperty
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> shaders;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x9FC5E0", Offset = "0x9FC5E0", VA = "0x9FC5E0")]
		public FbxShaderProperty()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class FbxSkinnedMeshCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x9FC660", Offset = "0x9FC660", VA = "0x9FC660")]
		public FbxSkinnedMeshCustomProperties()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class FbxTerrainCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x9FC668", Offset = "0x9FC668", VA = "0x9FC668")]
		public FbxTerrainCustomProperties()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class FbxTextureCustomProperties : FbxCustomPropertyBehaviour
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x9FC670", Offset = "0x9FC670", VA = "0x9FC670")]
		public FbxTextureCustomProperties()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class FbxExportSettings
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FbxLODScheme LODScheme;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int logLevel;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FbxTextureExportScheme textureScheme;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int formatId;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool embedTextures;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool embedShaderProperty;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int terrainQuality;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SkinnedMeshOptions skinnedMeshOptions;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BlendShapeOptions blendShapeOptions;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ObjectExportMask objectExportMask;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FbxNodeCallback OnFbxNodeCreated;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FbxMeshCallback OnFbxMeshCreated;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public FbxSkinnedMeshCallback OnFbxSkinnedMeshCreated;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FbxTerrainCallback OnFbxTerrainCreated;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FbxMaterialCallback OnFbxMaterialCreated;

		[Token(Token = "0x17000003")]
		public bool ExportCloth
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x9FC678", Offset = "0x9FC678", VA = "0x9FC678")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public bool ExportMeshes
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x9FC684", Offset = "0x9FC684", VA = "0x9FC684")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000005")]
		public bool ExportSkinnedMeshes
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x9FC690", Offset = "0x9FC690", VA = "0x9FC690")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000006")]
		public bool ExportTerrains
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x9FC69C", Offset = "0x9FC69C", VA = "0x9FC69C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public bool ExportLights
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x9FC6A8", Offset = "0x9FC6A8", VA = "0x9FC6A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool ExportCameras
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x9FC6B4", Offset = "0x9FC6B4", VA = "0x9FC6B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x9F907C", Offset = "0x9F907C", VA = "0x9F907C")]
		public FbxExportSettings()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class FbxExportCollection
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<Transform, IntPtr> FbxNodes;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<MeshRenderer> Meshes;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SkinnedMeshRenderer> SkinnedMeshes;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Cloth> Cloths;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Terrain> Terrains;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Camera> Cameras;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<Light> Lights;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x9FC954", Offset = "0x9FC954", VA = "0x9FC954")]
		public FbxExportCollection()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public enum ObjectExportMask
	{
		[Token(Token = "0x4000058")]
		ExportMeshes = 1,
		[Token(Token = "0x4000059")]
		ExportSkinnedMeshes = 2,
		[Token(Token = "0x400005A")]
		ExportTerrains = 4,
		[Token(Token = "0x400005B")]
		ExportCloth = 8,
		[Token(Token = "0x400005C")]
		ExportCameras = 16,
		[Token(Token = "0x400005D")]
		ExportLights = 32,
		[Token(Token = "0x400005E")]
		ExportAll = 63
	}
	[Token(Token = "0x2000016")]
	public enum SkinnedMeshOptions
	{
		[Token(Token = "0x4000060")]
		ExportCurrentPose,
		[Token(Token = "0x4000061")]
		ExportTPose
	}
	[Token(Token = "0x2000017")]
	public enum BlendShapeOptions
	{
		[Token(Token = "0x4000063")]
		Reset,
		[Token(Token = "0x4000064")]
		WriteDeformations
	}
	[Token(Token = "0x2000018")]
	public delegate void FbxNodeCallback(Transform transform, IntPtr fbxNode);
	[Token(Token = "0x2000019")]
	public delegate void FbxMeshCallback(Transform transform, IntPtr fbxNode, MeshRenderer meshRenderer, IntPtr fbxMesh);
	[Token(Token = "0x200001A")]
	public delegate void FbxTerrainCallback(Transform transform, IntPtr fbxNode, Terrain terrain, IntPtr fbxMesh);
	[Token(Token = "0x200001B")]
	public delegate void FbxSkinnedMeshCallback(Transform transform, IntPtr fbxNode, SkinnedMeshRenderer skinnedMeshRenderer, IntPtr fbxMesh);
	[Token(Token = "0x200001C")]
	public delegate void FbxMaterialCallback(Transform transform, IntPtr fbxNode, IntPtr fbxMaterial, IntPtr[] fbxTextures);
	[Token(Token = "0x200001D")]
	public class FbxExporter
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int loggingLevel;

		[Token(Token = "0x17000009")]
		public static bool FbxSupported
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x9FCF48", Offset = "0x9FCF48", VA = "0x9FCF48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public static string Version
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xA02FE8", Offset = "0xA02FE8", VA = "0xA02FE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x9FC6C8", Offset = "0x9FC6C8", VA = "0x9FC6C8")]
		public static int GetDefaultFormat()
		{
			return default(int);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x9FD518", Offset = "0x9FD518", VA = "0x9FD518")]
		public static bool Export(string filename, params Transform[] roots)
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x9FD650", Offset = "0x9FD650", VA = "0x9FD650")]
		public static bool Export(string filename, int formatId, params Transform[] roots)
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x9F974C", Offset = "0x9F974C", VA = "0x9F974C")]
		public static bool Export(string filename, FbxExportSettings settings, params Transform[] roots)
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x9FED2C", Offset = "0x9FED2C", VA = "0x9FED2C")]
		private static void EmbedShaderProperty(IntPtr node, Material[] materials, FbxShaderProperty shaderProperty)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xA00A38", Offset = "0xA00A38", VA = "0xA00A38")]
		private static string GetShader(Material material)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xA00B14", Offset = "0xA00B14", VA = "0xA00B14")]
		private static bool IsHumanoidRoot(Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x9FDAE0", Offset = "0x9FDAE0", VA = "0x9FDAE0")]
		private static void ExportSkinnedMeshOrCloth(SkinnedMeshRenderer smr, Transform root, TextureExporter textureExporter, string outputPath, Dictionary<IntPtr, IntPtr> skeletonNodes, Dictionary<Material, IntPtr> materialDictionary, FbxExportSettings settings, FbxExportCollection fbxCollection)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xA00994", Offset = "0xA00994", VA = "0xA00994")]
		private static UnityFbxExporterBinding.EType ConvertLightType(LightType type)
		{
			return default(UnityFbxExporterBinding.EType);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x9FD5A8", Offset = "0x9FD5A8", VA = "0x9FD5A8")]
		public static bool Export(string filename, int formatId, FbxTextureExportScheme textureScheme, int terrainQuality, FbxLODScheme LODScheme, int logLevel, params Transform[] roots)
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xA02588", Offset = "0xA02588", VA = "0xA02588")]
		private static void RecursivelyEnsureLimb(Transform root, Transform bone, Dictionary<Transform, IntPtr> fbxNodes, Dictionary<IntPtr, IntPtr> skeletonNodes)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xA009B4", Offset = "0xA009B4", VA = "0xA009B4")]
		public static void LogFormat(bool actuallyLogThis, string format, params object[] arguments)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x9FEAC4", Offset = "0x9FEAC4", VA = "0x9FEAC4")]
		public static void LogFormat(bool actuallyLogThis, UnityEngine.Object context, string format, params object[] arguments)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xA028F0", Offset = "0xA028F0", VA = "0xA028F0")]
		public static void LogWarningFormat(bool actuallyLogThis, string format, params object[] arguments)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x9FD6D8", Offset = "0x9FD6D8", VA = "0x9FD6D8")]
		public static void LogErrorFormat(bool actuallyLogThis, string format, params object[] arguments)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x9FF920", Offset = "0x9FF920", VA = "0x9FF920")]
		private static bool checkIsValid(Terrain terrain, out TerrainData terrainData)
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x9FE940", Offset = "0x9FE940", VA = "0x9FE940")]
		private static bool checkIsValid(MeshRenderer mr, out Mesh mesh, out Material[] materials)
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xA00BC4", Offset = "0xA00BC4", VA = "0xA00BC4")]
		private static bool checkIsValid(SkinnedMeshRenderer smr, bool exportCloth, out Transform[] bones, out Mesh mesh, out Cloth cloth, out Material[] materials)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xA02974", Offset = "0xA02974", VA = "0xA02974")]
		public static void GetFormatNames(bool filterFbx, out string[] names, out int[] formatIds)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xA027B4", Offset = "0xA027B4", VA = "0xA027B4")]
		private static void SkinAddCluster(IntPtr fbxSkin, IntPtr fbxCluster, IntPtr fbxRoot, Transform bone)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xA03028", Offset = "0xA03028", VA = "0xA03028")]
		public FbxExporter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public class FbxLODScheme
	{
		[Token(Token = "0x2000020")]
		public enum LODScheme
		{
			[Token(Token = "0x400006B")]
			IgnoreLOD = 0,
			[Token(Token = "0x400006C")]
			MainCamera = 1,
			[Token(Token = "0x400006D")]
			OtherCameras = 2,
			[Token(Token = "0x400006E")]
			AllCameras = 3,
			[Token(Token = "0x400006F")]
			PerformCulling = 4,
			[Token(Token = "0x4000070")]
			CullMainCamera = 5,
			[Token(Token = "0x4000071")]
			CullOtherCameras = 6,
			[Token(Token = "0x4000072")]
			CullAllCameras = 8
		}

		[Token(Token = "0x2000021")]
		public enum LODSchemeEnumMaskFlags
		{
			[Token(Token = "0x4000074")]
			MainCamera = 1,
			[Token(Token = "0x4000075")]
			OtherCameras = 2,
			[Token(Token = "0x4000076")]
			PerformCulling = 4
		}

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LODScheme Scheme;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera[] _lodCameras;

		[Token(Token = "0x1700000B")]
		public LODSchemeEnumMaskFlags SchemeMask
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xA030D8", Offset = "0xA030D8", VA = "0xA030D8")]
			get
			{
				return default(LODSchemeEnumMaskFlags);
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xA030E0", Offset = "0xA030E0", VA = "0xA030E0")]
			set
			{
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xA030E8", Offset = "0xA030E8", VA = "0xA030E8", Slot = "4")]
		public virtual void Prepare(int logLevel)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xA032B8", Offset = "0xA032B8", VA = "0xA032B8", Slot = "5")]
		public virtual void GetRenderers(LODGroup lodGroup, FbxExportCollection result, FbxExportSettings settings)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xA030EC", Offset = "0xA030EC", VA = "0xA030EC")]
		private void _Prepare()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xA032BC", Offset = "0xA032BC", VA = "0xA032BC")]
		private void _GetRenderers(LODGroup lodGroup, FbxExportCollection result, FbxExportSettings settings)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xA0391C", Offset = "0xA0391C", VA = "0xA0391C")]
		private bool IsCulled(Renderer renderer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xA0386C", Offset = "0xA0386C", VA = "0xA0386C")]
		private int DetermineLODGroup(LODGroup lodGroup)
		{
			return default(int);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xA03C50", Offset = "0xA03C50", VA = "0xA03C50")]
		private static int DetermineLOD(LODGroup lodGroup, Camera camera)
		{
			return default(int);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x9FC6C0", Offset = "0x9FC6C0", VA = "0x9FC6C0")]
		public FbxLODScheme()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class FbxTextureExportScheme
	{
		[Token(Token = "0x2000023")]
		public enum TextureExportFormat
		{
			[Token(Token = "0x400007D")]
			Png,
			[Token(Token = "0x400007E")]
			Jpeg
		}

		[Token(Token = "0x2000024")]
		public enum TextureColorSpace
		{
			[Token(Token = "0x4000080")]
			NoConversion,
			[Token(Token = "0x4000081")]
			GammaToHdr,
			[Token(Token = "0x4000082")]
			HdrToGamma,
			[Token(Token = "0x4000083")]
			Experimental
		}

		[Token(Token = "0x2000025")]
		public enum TextureElements
		{
			[Token(Token = "0x4000085")]
			None = 0,
			[Token(Token = "0x4000086")]
			Meshes = 1,
			[Token(Token = "0x4000087")]
			SkinnedMeshes = 2,
			[Token(Token = "0x4000088")]
			MeshesAndSkinnedMeshes = 3,
			[Token(Token = "0x4000089")]
			Terrains = 4,
			[Token(Token = "0x400008A")]
			MeshesAndTerrains = 5,
			[Token(Token = "0x400008B")]
			SkinnedMeshesAndTerrains = 6,
			[Token(Token = "0x400008C")]
			MeshesAndSkinnedMeshesAndTerrains = 7,
			[Token(Token = "0x400008D")]
			Everything = 7
		}

		[Token(Token = "0x2000026")]
		public enum TextureElementsMask
		{
			[Token(Token = "0x400008F")]
			Meshes = 1,
			[Token(Token = "0x4000090")]
			SkinnedMeshes = 2,
			[Token(Token = "0x4000091")]
			Terrains = 4
		}

		[Token(Token = "0x2000027")]
		public enum TextureSizes
		{
			[Token(Token = "0x4000093")]
			ScaleFull,
			[Token(Token = "0x4000094")]
			ScaleHalf,
			[Token(Token = "0x4000095")]
			ScaleQuarter,
			[Token(Token = "0x4000096")]
			ScaleEighth,
			[Token(Token = "0x4000097")]
			ScaleSixteenth,
			[Token(Token = "0x4000098")]
			Scale32nd
		}

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextureColorSpace textureColorSpace;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TextureElements textureElements;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextureSizes textureSize;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TextureExportFormat textureFormat;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] _textureExportFormatExtensions;

		[Token(Token = "0x1700000C")]
		public bool ExportMeshTextures
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x9FEF58", Offset = "0x9FEF58", VA = "0x9FEF58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public bool ExportSkinnedMeshTextures
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xA00E04", Offset = "0xA00E04", VA = "0xA00E04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public bool ExportTerrainTextures
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0xA002FC", Offset = "0xA002FC", VA = "0xA002FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		public string textureExtension
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xA04054", Offset = "0xA04054", VA = "0xA04054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xA040D4", Offset = "0xA040D4", VA = "0xA040D4", Slot = "4")]
		public virtual void AllocateTextures(Material mat, Renderer renderer, ref Texture2D _diffuseTexture, ref Texture2D _specularMapTexture, ref Texture2D _normalMapTexture, out int resolutionX, out int resolutionY)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xA04414", Offset = "0xA04414", VA = "0xA04414", Slot = "5")]
		public virtual float CalcColorSpace()
		{
			return default(float);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x9F90F4", Offset = "0x9F90F4", VA = "0x9F90F4")]
		public static FbxTextureExportScheme GetDefaultScheme()
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xA04450", Offset = "0xA04450", VA = "0xA04450")]
		public static FbxTextureExportScheme GetNoneScheme()
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xA040E4", Offset = "0xA040E4", VA = "0xA040E4")]
		protected void _AllocateTextures(Material mat, Renderer renderer, ref Texture2D _diffuseTexture, ref Texture2D _normalMapTexture, ref Texture2D _specularMapTexture, out int maxResolutionX, out int maxResolutionY)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xA044BC", Offset = "0xA044BC", VA = "0xA044BC")]
		protected bool AllocateTextureBasedOnMaterial(Material mat, string shaderVariableName, ref Texture2D _diffuseTexture, ref int maxResolutionX, ref int maxResolutionY)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xA045FC", Offset = "0xA045FC", VA = "0xA045FC")]
		public void AllocateTexture(ref Texture2D texture, int resolutionX, int resolutionY)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xA04744", Offset = "0xA04744", VA = "0xA04744")]
		protected void AdjustResolution(ref int resolutionX, ref int resolutionY)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xA0443C", Offset = "0xA0443C", VA = "0xA0443C")]
		public FbxTextureExportScheme()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	public class TextureExporter : MonoBehaviour
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera _exportCamera;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture2D _diffuseTexture;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D _normalMapTexture;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D _specularMapTexture;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RenderTexture rt;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Renderer _textureExporter;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _normalMat;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material _specularMat;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material _diffuseMat;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string _normalMapFilename;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string _specularMapFilename;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string _diffuseTextureFilename;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<Material, Material> AlreadyProcessedMaterials;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material lastMaterial;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int renderTextureSize;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FbxTextureExportScheme currentScheme;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x9FEF64", Offset = "0x9FEF64", VA = "0x9FEF64")]
		public static TextureExporter CreateTextureExporter()
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xA048A4", Offset = "0xA048A4", VA = "0xA048A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xA04A28", Offset = "0xA04A28", VA = "0xA04A28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xA00308", Offset = "0xA00308", VA = "0xA00308")]
		public void ProcessTerrain(Terrain terrain, int resolution, FbxTextureExportScheme textureScheme, string path)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x9FF0CC", Offset = "0x9FF0CC", VA = "0x9FF0CC")]
		public Material ProcessMaterial(Material mat, Renderer renderer, FbxTextureExportScheme textureScheme, string path)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xA04C78", Offset = "0xA04C78", VA = "0xA04C78")]
		protected void CleanupLastMaterial()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xA054D4", Offset = "0xA054D4", VA = "0xA054D4")]
		protected Texture MakeDummyTexture(Texture texture)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xA04D98", Offset = "0xA04D98", VA = "0xA04D98")]
		protected Material SetupTerrainMaterial(Terrain terrain, int layer, TerrainLayer[] layers, Texture2D control)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xA05308", Offset = "0xA05308", VA = "0xA05308")]
		protected void PerformTextureExport(int resolutionX, int resolutionY)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xA055A4", Offset = "0xA055A4", VA = "0xA055A4", Slot = "4")]
		public virtual void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xA056C8", Offset = "0xA056C8", VA = "0xA056C8")]
		protected void ExportSingleTexture(RenderTexture src, Texture2D dest, Material mat, string filename, int textureType)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xA0584C", Offset = "0xA0584C", VA = "0xA0584C")]
		private bool VerifySpecular(Texture2D dest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xA05844", Offset = "0xA05844", VA = "0xA05844")]
		private bool VerifyNormals(Texture2D dest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xA05854", Offset = "0xA05854", VA = "0xA05854")]
		protected void WriteAllBytes(string filename, byte[] data)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xA05A4C", Offset = "0xA05A4C", VA = "0xA05A4C")]
		protected void EnsureFolderExists(string folder)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xA05AEC", Offset = "0xA05AEC", VA = "0xA05AEC")]
		public TextureExporter()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public static class UnityFbxExporterBinding
	{
		[Token(Token = "0x200002A")]
		private static class NativeMethods
		{
			[PreserveSig]
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xA05FCC", Offset = "0xA05FCC", VA = "0xA05FCC")]
			public static extern IntPtr LoadLibrary(string dllToLoad);

			[PreserveSig]
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xA0773C", Offset = "0xA0773C", VA = "0xA0773C")]
			public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

			[PreserveSig]
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xA077DC", Offset = "0xA077DC", VA = "0xA077DC")]
			public static extern bool FreeLibrary(IntPtr hModule);
		}

		[Token(Token = "0x200002B")]
		public delegate void LogCallback(string msg);

		[Token(Token = "0x200002C")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int IntVoid();

		[Token(Token = "0x200002D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate string StringInt(int value);

		[Token(Token = "0x200002E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool BoolInt(int value);

		[Token(Token = "0x200002F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidLogCallback(LogCallback msg);

		[Token(Token = "0x2000030")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntLogCallback(int index, LogCallback msg);

		[Token(Token = "0x2000031")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidVoid();

		[Token(Token = "0x2000032")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool BoolString(string value);

		[Token(Token = "0x2000033")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool BoolStringInt(string arg0, int arg1);

		[Token(Token = "0x2000034")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool BoolStringIntBool(string arg0, int arg1, bool arg2);

		[Token(Token = "0x2000035")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrString(string value);

		[Token(Token = "0x2000036")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringDouble3(string value, double r, double g, double b);

		[Token(Token = "0x2000037")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringIntPtrDoubleDoubleDouble(string value, IntPtr node, double nearPlane, double farPlane, double fieldOfView);

		[Token(Token = "0x2000038")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringIntPtrETypeDoubleDoubleDoubleDoubleBoolBool(string value, IntPtr node, EType lightType, double r, double g, double b, double intensity, bool enabled, bool shadows);

		[Token(Token = "0x2000039")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringIntPtr(string arg0, IntPtr arg1);

		[Token(Token = "0x200003A")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringIntPtrDouble(string arg0, IntPtr arg1, double arg2);

		[Token(Token = "0x200003B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrVoid(LogCallback logCallback);

		[Token(Token = "0x200003C")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtr(IntPtr value);

		[Token(Token = "0x200003D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtrDoubleArrayInt(IntPtr arg0, double[] arg1, int arg2);

		[Token(Token = "0x200003E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDoubleArrayInt(IntPtr arg0, double[] arg1, int arg2);

		[Token(Token = "0x200003F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrIntIntArrayInt(IntPtr arg0, int arg1, int[] arg2, int arg3);

		[Token(Token = "0x2000040")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrStringStringETextureUseEAlphaSource(string arg0, string arg1, ETextureUse arg2, EAlphaSource arg3);

		[Token(Token = "0x2000041")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrIntPtrTextureChannels(IntPtr arg0, IntPtr arg1, TextureChannels arg2);

		[Token(Token = "0x2000042")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrIntPtr(IntPtr arg0, IntPtr arg1);

		[Token(Token = "0x2000043")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDoubleArrayIntString(IntPtr arg0, double[] arg1, int arg2, string arg3);

		[Token(Token = "0x2000044")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtrString(IntPtr arg0, string arg1);

		[Token(Token = "0x2000045")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDouble3x3(IntPtr node, double rot_x, double rot_y, double rot_z, double pos_x, double pos_y, double pos_z, double scale_x, double scale_y, double scale_z);

		[Token(Token = "0x2000046")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtr3(IntPtr arg0, IntPtr arg1, IntPtr arg2);

		[Token(Token = "0x2000047")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtr3Double3x3(IntPtr arg0, IntPtr arg1, IntPtr arg2, double rot_x, double rot_y, double rot_z, double pos_x, double pos_y, double pos_z, double scale_x, double scale_y, double scale_z);

		[Token(Token = "0x2000048")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrIntDouble(IntPtr arg0, int arg1, double arg2);

		[Token(Token = "0x2000049")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtr(IntPtr arg0);

		[Token(Token = "0x200004A")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidStringIntPtrArrayDoubleArrayInt(string arg0, IntPtr[] arg1, double[] arg2, int arg3);

		[Token(Token = "0x200004B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDoubleArray(IntPtr cluster, double[] matrix);

		[Token(Token = "0x200004C")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDouble3(IntPtr arg0, double arg1, double arg2, double arg3);

		[Token(Token = "0x200004D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDouble4(IntPtr arg0, double arg1, double arg2, double arg3, double arg4);

		[Token(Token = "0x200004E")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrIntPtrDouble16(IntPtr arg0, IntPtr arg1, double p00, double p10, double p20, double p30, double p01, double p11, double p21, double p31, double p02, double p12, double p22, double p32, double p03, double p13, double p23, double p33);

		[Token(Token = "0x200004F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool BoolIntPtr6DoubleIntPtr(IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, double arg6, IntPtr arg7, LogCallback logCallback);

		[Token(Token = "0x2000050")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int IntIntPtr(IntPtr arg0);

		[Token(Token = "0x2000051")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr IntPtrIntPtrInt(IntPtr arg0, int arg1);

		[Token(Token = "0x2000052")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate string StringIntPtr(IntPtr arg0);

		[Token(Token = "0x2000053")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringDouble4(IntPtr arg0, string arg1, double arg2, double arg3, double arg4, double arg5);

		[Token(Token = "0x2000054")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringDouble3(IntPtr arg0, string arg1, double arg2, double arg3, double arg4);

		[Token(Token = "0x2000055")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringDouble2(IntPtr arg0, string arg1, double arg2, double arg3);

		[Token(Token = "0x2000056")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringDouble(IntPtr arg0, string arg1, double arg2);

		[Token(Token = "0x2000057")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrDouble(IntPtr arg0, double arg1);

		[Token(Token = "0x2000058")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringBool(IntPtr arg0, string arg1, bool arg2);

		[Token(Token = "0x2000059")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringLong(IntPtr arg0, string arg1, long arg2);

		[Token(Token = "0x200005A")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringMatrix(IntPtr arg0, string arg1, double p00, double p10, double p20, double p30, double p01, double p11, double p21, double p31, double p02, double p12, double p22, double p32, double p03, double p13, double p23, double p33);

		[Token(Token = "0x200005B")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void VoidIntPtrStringString(IntPtr arg0, string arg1, string arg2);

		[Token(Token = "0x200005C")]
		public enum EType
		{
			[Token(Token = "0x40000EE")]
			ePoint,
			[Token(Token = "0x40000EF")]
			eDirectional,
			[Token(Token = "0x40000F0")]
			eSpot,
			[Token(Token = "0x40000F1")]
			eArea,
			[Token(Token = "0x40000F2")]
			eVolume
		}

		[Token(Token = "0x200005D")]
		public enum ETextureUse
		{
			[Token(Token = "0x40000F4")]
			eStandard,
			[Token(Token = "0x40000F5")]
			eShadowMap,
			[Token(Token = "0x40000F6")]
			eLightMap,
			[Token(Token = "0x40000F7")]
			eSphericalReflectionMap,
			[Token(Token = "0x40000F8")]
			eSphereReflectionMap,
			[Token(Token = "0x40000F9")]
			eBumpNormalMap
		}

		[Token(Token = "0x200005E")]
		public enum EAlphaSource
		{
			[Token(Token = "0x40000FB")]
			eNone,
			[Token(Token = "0x40000FC")]
			eRGBIntensity,
			[Token(Token = "0x40000FD")]
			eBlack
		}

		[Token(Token = "0x200005F")]
		public enum TextureChannels
		{
			[Token(Token = "0x40000FF")]
			Diffuse,
			[Token(Token = "0x4000100")]
			Emissive,
			[Token(Token = "0x4000101")]
			Ambient,
			[Token(Token = "0x4000102")]
			NormalMap,
			[Token(Token = "0x4000103")]
			BumpMap,
			[Token(Token = "0x4000104")]
			TransparentColor,
			[Token(Token = "0x4000105")]
			Shininess,
			[Token(Token = "0x4000106")]
			Specular,
			[Token(Token = "0x4000107")]
			Reflection
		}

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 rotAdjust;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Vector3 posAdjust;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Vector3 scaleAdjust;

		[Token(Token = "0x40000AC")]
		private const string dllFilenameBase = "UnityFbxExporter";

		[Token(Token = "0x40000AD")]
		private const string dllVersion = "16";

		[Token(Token = "0x40000AE")]
		private const string dllExtension = "dll";

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static IntPtr exportSceneDll;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static VoidVoid Create;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static VoidVoid Destroy;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static BoolStringIntBool Save;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static IntPtrStringIntPtr MeshCreate;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static VoidLogCallback LogFbxFormats;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static IntVoid FormatsCount;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static VoidIntLogCallback GetFormat;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static BoolInt IsFormatFbx;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static IntPtrIntPtr MeshGetNode;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static IntPtrIntPtrDoubleArrayInt MeshSetVertices;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static VoidIntPtrDoubleArrayInt MeshSetNormals;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static VoidIntPtrDoubleArrayInt MeshSetColors;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static VoidIntPtrIntIntArrayInt MeshAddTriangles;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static IntPtrStringStringETextureUseEAlphaSource CreateTexture;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static IntPtrStringDouble3 CreatePhongMaterial;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static VoidIntPtrDouble4 SetTextureScale;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static VoidIntPtrIntPtrTextureChannels MaterialSetTexture;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static VoidIntPtrIntPtr MeshAddMaterial;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static VoidIntPtrDoubleArrayIntString MeshSetUV;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static IntPtrIntPtrString CreateNode;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static VoidIntPtr MakeNodeSkeleton;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static IntPtrString SkeletonCreateRoot;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static IntPtrIntPtrString SkeletonCreateLimb;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static VoidIntPtrDouble3x3 NodeSetLocal;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static IntPtrIntPtr MeshCreateSkin;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static IntPtrIntPtr ClusterCreate;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static IntPtrIntPtr3Double3x3 SkinAddCluster;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static VoidIntPtrIntDouble ClusterAddWeight;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static VoidIntPtr MeshStoreBindPose;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static VoidStringIntPtrArrayDoubleArrayInt MeshSetBindPose;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static VoidIntPtrDoubleArray ClusterSetLinkMatrix;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static VoidIntPtrDouble3 NodeSetPreRotation;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static VoidIntPtr UpdateTransformation;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static IntPtrVoid CreateBindPose;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static VoidIntPtrIntPtrDouble16 AddBoneToPose;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static BoolIntPtr6DoubleIntPtr IsValidBindPoseVerbose;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public static IntPtrVoid FbxStatusCreate;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public static IntPtrVoid NodeListCreate;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public static IntIntPtr NodeListSize;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public static IntPtrIntPtrInt NodeListGetAt;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public static StringIntPtr NodeGetName;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public static StringIntPtr PoseGetClassId;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public static StringIntPtr NodeGetClassId;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public static VoidIntPtrStringDouble4 SetColorProperty;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public static VoidIntPtrStringDouble4 SetDouble4Property;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public static VoidIntPtrStringDouble3 SetDouble3Property;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public static VoidIntPtrStringDouble2 SetDouble2Property;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public static VoidIntPtrStringMatrix SetMatrixProperty;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public static VoidIntPtrStringDouble SetDoubleProperty;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public static VoidIntPtrStringBool SetBoolProperty;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public static VoidIntPtrStringLong SetLongProperty;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public static VoidIntPtrStringString SetStringProperty;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public static IntPtrStringIntPtrDoubleDoubleDouble CameraCreate;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public static IntPtrStringIntPtrETypeDoubleDoubleDoubleDoubleBoolBool LightCreate;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public static IntPtrIntPtr AddBlendShape;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public static IntPtrStringIntPtr AddBlendChannel;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public static IntPtrStringIntPtrDouble AddBlendFrame;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public static VoidIntPtrDouble SetBlendShapeDeformPercent;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public static SkinnedMeshRenderer blendSmr;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public static Mesh blendMesh;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public static float[] blendWeights;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xA05B68", Offset = "0xA05B68", VA = "0xA05B68")]
		public static string GetDLLPath(int logLevel = 0)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x9FCF50", Offset = "0x9FCF50", VA = "0x9FCF50")]
		public static bool Init(int logLevel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xA05F6C", Offset = "0xA05F6C", VA = "0xA05F6C")]
		private static IntPtr LoadLibrary(string path)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600009D")]
		private static void SetupMethod<T>(string methodName, ref T methodDelegate) where T : class
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xA05FC8", Offset = "0xA05FC8", VA = "0xA05FC8")]
		public static void Close()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xA06060", Offset = "0xA06060", VA = "0xA06060")]
		public static IntPtr ProcessMesh(Mesh sourceMesh, Material[] materials, IntPtr node)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xA060F8", Offset = "0xA060F8", VA = "0xA060F8")]
		public static IntPtr ProcessMesh(Mesh sourceMesh, Material[] materials)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xA0619C", Offset = "0xA0619C", VA = "0xA0619C")]
		public static IntPtr ProcessMesh(Mesh sourceMesh, int logLevel, Material[] materials, Vector3[] overrideVertices, Vector3[] overrideNormals, IntPtr node, Dictionary<Material, IntPtr> KnownMaterials)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x9FF85C", Offset = "0x9FF85C", VA = "0x9FF85C")]
		public static IntPtr ProcessMesh(Mesh sourceMesh, int logLevel, Material[] materials, Vector3[] overrideVertices, Vector3[] overrideNormals, IntPtr node, Dictionary<Material, IntPtr> KnownMaterials, out IntPtr[] fbxMaterials, out IntPtr[][] fbxTextures)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xA00E10", Offset = "0xA00E10", VA = "0xA00E10")]
		public static IntPtr ProcessMesh(Mesh sourceMesh, int logLevel, Material[] materials, Vector3[] overrideVertices, Vector3[] overrideNormals, IntPtr node, Dictionary<Material, IntPtr> KnownMaterials, out IntPtr[] fbxMaterials, out IntPtr[][] fbxTextures, BlendShapeOptions blendShapeOptions)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x9FF9C0", Offset = "0x9FF9C0", VA = "0x9FF9C0")]
		public static IntPtr ProcessTerrain(Terrain terrain, TerrainData terrainData, int terrainQuality, IntPtr node, out IntPtr material, out IntPtr[] textures)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xA06488", Offset = "0xA06488", VA = "0xA06488")]
		private static void FlipTriangles(int[] triangles)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xA064EC", Offset = "0xA064EC", VA = "0xA064EC")]
		private static IntPtr AddTextureToMaterial(IntPtr material, Material mat, string shaderName, TextureChannels channel, ETextureUse textureUse, int logLevel)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xA0679C", Offset = "0xA0679C", VA = "0xA0679C")]
		private static void CopyVectorsToDoubles(double[] dest, Vector3[] source)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xA06254", Offset = "0xA06254", VA = "0xA06254")]
		private static void CopyPointsToDoubles(double[] dest, Vector3[] source)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xA063CC", Offset = "0xA063CC", VA = "0xA063CC")]
		private static void CopyColorsToDoubles(double[] dest, Color[] source)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xA06310", Offset = "0xA06310", VA = "0xA06310")]
		private static void CopyVectorsToDoubles(double[] dest, Vector2[] source)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xA06858", Offset = "0xA06858", VA = "0xA06858")]
		private static void AddVector3ToArray(double[] doubleData, ref Vector3 vector, ref int index)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xA068D8", Offset = "0xA068D8", VA = "0xA068D8")]
		private static void AddPoint3ToArray(double[] doubleData, ref Vector3 vector, ref int index)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xA0695C", Offset = "0xA0695C", VA = "0xA0695C")]
		private static void AddColorToArray(double[] doubleData, ref Color color, ref int index)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA069FC", Offset = "0xA069FC", VA = "0xA069FC")]
		private static void AddVector2ToArray(double[] doubleData, ref Vector2 vector, ref int index)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x9FD75C", Offset = "0x9FD75C", VA = "0x9FD75C")]
		public static FbxExportCollection ScanHierarchy(Transform rootBone, bool createRoot, FbxExportSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xA06A5C", Offset = "0xA06A5C", VA = "0xA06A5C")]
		private static void RecursiveAddTransforms(Transform bone, IntPtr fbxBone, FbxExportCollection result, bool rootLevel, FbxExportSettings settings, bool belowLODGroup)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xA07234", Offset = "0xA07234", VA = "0xA07234")]
		private static void AddBoneWeight(ref BoneWeight boneWeight, IntPtr[] fbxClusters, int boneWeightIndex)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xA02704", Offset = "0xA02704", VA = "0xA02704")]
		public static void AddBoneWeights(BoneWeight[] boneWeights, IntPtr[] fbxClusters)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x9FEB50", Offset = "0x9FEB50", VA = "0x9FEB50")]
		public static void NodeSetTransform(IntPtr node, Transform transform, bool rootLevel)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xA074A4", Offset = "0xA074A4", VA = "0xA074A4")]
		public static void CameraSetTransform(IntPtr node, Transform transform, bool rootLevel)
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000060")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000061")]
		public enum UpdateMode
		{
			[Token(Token = "0x400012E")]
			Update,
			[Token(Token = "0x400012F")]
			FixedUpdate,
			[Token(Token = "0x4000130")]
			LateUpdate,
			[Token(Token = "0x4000131")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000010")]
		public float x
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xA0CAA8", Offset = "0xA0CAA8", VA = "0xA0CAA8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xA0CAB0", Offset = "0xA0CAB0", VA = "0xA0CAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public float y
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xA0CAB8", Offset = "0xA0CAB8", VA = "0xA0CAB8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xA0CAC0", Offset = "0xA0CAC0", VA = "0xA0CAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public float distanceTarget
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xA0CAC8", Offset = "0xA0CAC8", VA = "0xA0CAC8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xA0CAD0", Offset = "0xA0CAD0", VA = "0xA0CAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		private float zoomAdd
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xA0D4A0", Offset = "0xA0D4A0", VA = "0xA0D4A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xA0CAD8", Offset = "0xA0CAD8", VA = "0xA0CAD8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA0CC00", Offset = "0xA0CC00", VA = "0xA0CC00", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA0CC48", Offset = "0xA0CC48", VA = "0xA0CC48", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xA0CCA0", Offset = "0xA0CCA0", VA = "0xA0CCA0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xA0CCF8", Offset = "0xA0CCF8", VA = "0xA0CCF8")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xA0CC2C", Offset = "0xA0CC2C", VA = "0xA0CC2C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA0CE84", Offset = "0xA0CE84", VA = "0xA0CE84")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xA0D464", Offset = "0xA0D464", VA = "0xA0D464")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xA0D50C", Offset = "0xA0D50C", VA = "0xA0D50C")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xA0D5CC", Offset = "0xA0D5CC", VA = "0xA0D5CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xA0D5F8", Offset = "0xA0D5F8", VA = "0xA0D5F8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xA0D81C", Offset = "0xA0D81C", VA = "0xA0D81C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xA0D858", Offset = "0xA0D858", VA = "0xA0D858")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public enum Axis
	{
		[Token(Token = "0x4000138")]
		X,
		[Token(Token = "0x4000139")]
		Y,
		[Token(Token = "0x400013A")]
		Z
	}
	[Token(Token = "0x2000064")]
	public class AxisTools
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0xA0D874", Offset = "0xA0D874", VA = "0xA0D874")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xA0D954", Offset = "0xA0D954", VA = "0xA0D954")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xA0D98C", Offset = "0xA0D98C", VA = "0xA0D98C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xA0DAD4", Offset = "0xA0DAD4", VA = "0xA0DAD4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xA0DA88", Offset = "0xA0DA88", VA = "0xA0DA88")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xA0DBD0", Offset = "0xA0DBD0", VA = "0xA0DBD0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xA0DFF8", Offset = "0xA0DFF8", VA = "0xA0DFF8")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000066")]
		public class LimbOrientation
		{
			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600019B")]
			[Address(RVA = "0xA0E2F4", Offset = "0xA0E2F4", VA = "0xA0E2F4")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000014")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0xA0E040", Offset = "0xA0E040", VA = "0xA0E040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0xA0E368", Offset = "0xA0E368", VA = "0xA0E368")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xA0E000", Offset = "0xA0E000", VA = "0xA0E000")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000067")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000068")]
		public enum BoneType
		{
			[Token(Token = "0x4000155")]
			Unassigned,
			[Token(Token = "0x4000156")]
			Spine,
			[Token(Token = "0x4000157")]
			Head,
			[Token(Token = "0x4000158")]
			Arm,
			[Token(Token = "0x4000159")]
			Leg,
			[Token(Token = "0x400015A")]
			Tail,
			[Token(Token = "0x400015B")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000069")]
		public enum BoneSide
		{
			[Token(Token = "0x400015D")]
			Center,
			[Token(Token = "0x400015E")]
			Left,
			[Token(Token = "0x400015F")]
			Right
		}

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xA0E61C", Offset = "0xA0E61C", VA = "0xA0E61C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xA0E8E0", Offset = "0xA0E8E0", VA = "0xA0E8E0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xA0EB14", Offset = "0xA0EB14", VA = "0xA0EB14")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xA0EB88", Offset = "0xA0EB88", VA = "0xA0EB88")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xA0EC1C", Offset = "0xA0EC1C", VA = "0xA0EC1C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xA0E7C8", Offset = "0xA0E7C8", VA = "0xA0E7C8")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xA0EA8C", Offset = "0xA0EA8C", VA = "0xA0EA8C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xA0F354", Offset = "0xA0F354", VA = "0xA0F354")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xA0F1AC", Offset = "0xA0F1AC", VA = "0xA0F1AC")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xA0F280", Offset = "0xA0F280", VA = "0xA0F280")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xA0EE04", Offset = "0xA0EE04", VA = "0xA0EE04")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xA0EEA0", Offset = "0xA0EEA0", VA = "0xA0EEA0")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xA0EF3C", Offset = "0xA0EF3C", VA = "0xA0EF3C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xA0EFD8", Offset = "0xA0EFD8", VA = "0xA0EFD8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xA0F074", Offset = "0xA0F074", VA = "0xA0F074")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xA0F110", Offset = "0xA0F110", VA = "0xA0F110")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xA0F53C", Offset = "0xA0F53C", VA = "0xA0F53C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xA0ED30", Offset = "0xA0ED30", VA = "0xA0ED30")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xA0F4B8", Offset = "0xA0F4B8", VA = "0xA0F4B8")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xA0F59C", Offset = "0xA0F59C", VA = "0xA0F59C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA0F65C", Offset = "0xA0F65C", VA = "0xA0F65C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA0F444", Offset = "0xA0F444", VA = "0xA0F444")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA0F3D4", Offset = "0xA0F3D4", VA = "0xA0F3D4")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class BipedReferences
	{
		[Token(Token = "0x200006B")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000018")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0xA14F80", Offset = "0xA14F80", VA = "0xA14F80")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xA14F6C", Offset = "0xA14F6C", VA = "0xA14F6C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000016")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xA11654", Offset = "0xA11654", VA = "0xA11654", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public bool isEmpty
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xA119B0", Offset = "0xA119B0", VA = "0xA119B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA119C0", Offset = "0xA119C0", VA = "0xA119C0", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA11D4C", Offset = "0xA11D4C", VA = "0xA11D4C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xA120DC", Offset = "0xA120DC", VA = "0xA120DC")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA12700", Offset = "0xA12700", VA = "0xA12700")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA1233C", Offset = "0xA1233C", VA = "0xA1233C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA12F08", Offset = "0xA12F08", VA = "0xA12F08")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA12FE8", Offset = "0xA12FE8", VA = "0xA12FE8")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xA13A64", Offset = "0xA13A64", VA = "0xA13A64")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xA13884", Offset = "0xA13884", VA = "0xA13884")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xA13624", Offset = "0xA13624", VA = "0xA13624")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA13084", Offset = "0xA13084", VA = "0xA13084")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA13978", Offset = "0xA13978", VA = "0xA13978")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA13B44", Offset = "0xA13B44", VA = "0xA13B44")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA14604", Offset = "0xA14604", VA = "0xA14604")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA140C4", Offset = "0xA140C4", VA = "0xA140C4")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA148D8", Offset = "0xA148D8", VA = "0xA148D8")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA14418", Offset = "0xA14418", VA = "0xA14418")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA148E0", Offset = "0xA148E0", VA = "0xA148E0")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA148E8", Offset = "0xA148E8", VA = "0xA148E8")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA14A9C", Offset = "0xA14A9C", VA = "0xA14A9C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA14F04", Offset = "0xA14F04", VA = "0xA14F04")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA122D4", Offset = "0xA122D4", VA = "0xA122D4")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xA14F88", Offset = "0xA14F88", VA = "0xA14F88")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xA14F90", Offset = "0xA14F90", VA = "0xA14F90")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xA15088", Offset = "0xA15088", VA = "0xA15088")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class Hierarchy
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xA14E80", Offset = "0xA14E80", VA = "0xA14E80")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xA14D74", Offset = "0xA14D74", VA = "0xA14D74")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xA13164", Offset = "0xA13164", VA = "0xA13164")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xA13774", Offset = "0xA13774", VA = "0xA13774")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xA133E4", Offset = "0xA133E4", VA = "0xA133E4")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xA15098", Offset = "0xA15098", VA = "0xA15098")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xA13294", Offset = "0xA13294", VA = "0xA13294")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xA1518C", Offset = "0xA1518C", VA = "0xA1518C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xA154F8", Offset = "0xA154F8", VA = "0xA154F8")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xA152F0", Offset = "0xA152F0", VA = "0xA152F0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA15680", Offset = "0xA15680", VA = "0xA15680")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000177")]
		None,
		[Token(Token = "0x4000178")]
		InOutCubic,
		[Token(Token = "0x4000179")]
		InOutQuintic,
		[Token(Token = "0x400017A")]
		InOutSine,
		[Token(Token = "0x400017B")]
		InQuintic,
		[Token(Token = "0x400017C")]
		InQuartic,
		[Token(Token = "0x400017D")]
		InCubic,
		[Token(Token = "0x400017E")]
		InQuadratic,
		[Token(Token = "0x400017F")]
		InElastic,
		[Token(Token = "0x4000180")]
		InElasticSmall,
		[Token(Token = "0x4000181")]
		InElasticBig,
		[Token(Token = "0x4000182")]
		InSine,
		[Token(Token = "0x4000183")]
		InBack,
		[Token(Token = "0x4000184")]
		OutQuintic,
		[Token(Token = "0x4000185")]
		OutQuartic,
		[Token(Token = "0x4000186")]
		OutCubic,
		[Token(Token = "0x4000187")]
		OutInCubic,
		[Token(Token = "0x4000188")]
		OutInQuartic,
		[Token(Token = "0x4000189")]
		OutElastic,
		[Token(Token = "0x400018A")]
		OutElasticSmall,
		[Token(Token = "0x400018B")]
		OutElasticBig,
		[Token(Token = "0x400018C")]
		OutSine,
		[Token(Token = "0x400018D")]
		OutBack,
		[Token(Token = "0x400018E")]
		OutBackCubic,
		[Token(Token = "0x400018F")]
		OutBackQuartic,
		[Token(Token = "0x4000190")]
		BackInCubic,
		[Token(Token = "0x4000191")]
		BackInQuartic
	}
	[Token(Token = "0x2000070")]
	public class Interp
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xA15688", Offset = "0xA15688", VA = "0xA15688")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xA16010", Offset = "0xA16010", VA = "0xA16010")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xA16080", Offset = "0xA16080", VA = "0xA16080")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xA15A88", Offset = "0xA15A88", VA = "0xA15A88")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xA15A94", Offset = "0xA15A94", VA = "0xA15A94")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xA15AB8", Offset = "0xA15AB8", VA = "0xA15AB8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xA15AF4", Offset = "0xA15AF4", VA = "0xA15AF4")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xA15B0C", Offset = "0xA15B0C", VA = "0xA15B0C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xA15B20", Offset = "0xA15B20", VA = "0xA15B20")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xA15B34", Offset = "0xA15B34", VA = "0xA15B34")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xA15B44", Offset = "0xA15B44", VA = "0xA15B44")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xA15B8C", Offset = "0xA15B8C", VA = "0xA15B8C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xA15BC4", Offset = "0xA15BC4", VA = "0xA15BC4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xA15BEC", Offset = "0xA15BEC", VA = "0xA15BEC")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xA160F0", Offset = "0xA160F0", VA = "0xA160F0")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xA15C20", Offset = "0xA15C20", VA = "0xA15C20")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xA15C48", Offset = "0xA15C48", VA = "0xA15C48")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xA15C78", Offset = "0xA15C78", VA = "0xA15C78")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xA15CAC", Offset = "0xA15CAC", VA = "0xA15CAC")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xA15CF0", Offset = "0xA15CF0", VA = "0xA15CF0")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xA15D54", Offset = "0xA15D54", VA = "0xA15D54")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xA15DB8", Offset = "0xA15DB8", VA = "0xA15DB8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA15E0C", Offset = "0xA15E0C", VA = "0xA15E0C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xA15E60", Offset = "0xA15E60", VA = "0xA15E60")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xA15E98", Offset = "0xA15E98", VA = "0xA15E98")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xA15ECC", Offset = "0xA15ECC", VA = "0xA15ECC")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xA16124", Offset = "0xA16124", VA = "0xA16124")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xA15F10", Offset = "0xA15F10", VA = "0xA15F10")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xA15FA0", Offset = "0xA15FA0", VA = "0xA15FA0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xA15FD0", Offset = "0xA15FD0", VA = "0xA15FD0")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xA161B4", Offset = "0xA161B4", VA = "0xA161B4")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xA161BC", Offset = "0xA161BC", VA = "0xA161BC")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xA16224", Offset = "0xA16224", VA = "0xA16224")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xA1628C", Offset = "0xA1628C", VA = "0xA1628C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xA162D8", Offset = "0xA162D8", VA = "0xA162D8")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA16394", Offset = "0xA16394", VA = "0xA16394")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xA162EC", Offset = "0xA162EC", VA = "0xA162EC")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xA163A8", Offset = "0xA163A8", VA = "0xA163A8")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xA16438", Offset = "0xA16438", VA = "0xA16438")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xA16460", Offset = "0xA16460", VA = "0xA16460")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xA164AC", Offset = "0xA164AC", VA = "0xA164AC")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xA16514", Offset = "0xA16514", VA = "0xA16514")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xA16668", Offset = "0xA16668", VA = "0xA16668")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xA167A0", Offset = "0xA167A0", VA = "0xA167A0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xA167F8", Offset = "0xA167F8", VA = "0xA167F8")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000073")]
	public static class QuaTools
	{
		[Token(Token = "0x6000209")]
		[Address(RVA = "0xA1681C", Offset = "0xA1681C", VA = "0xA1681C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xA16868", Offset = "0xA16868", VA = "0xA16868")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xA168B4", Offset = "0xA168B4", VA = "0xA168B4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xA169B8", Offset = "0xA169B8", VA = "0xA169B8")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xA16ABC", Offset = "0xA16ABC", VA = "0xA16ABC")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xA16BD0", Offset = "0xA16BD0", VA = "0xA16BD0")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xA16C78", Offset = "0xA16C78", VA = "0xA16C78")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xA16D84", Offset = "0xA16D84", VA = "0xA16D84")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xA16EEC", Offset = "0xA16EEC", VA = "0xA16EEC")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xA170D0", Offset = "0xA170D0", VA = "0xA170D0")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xA171A0", Offset = "0xA171A0", VA = "0xA171A0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000074")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000019")]
		public static T instance
		{
			[Token(Token = "0x6000214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000215")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000216")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700001A")]
		private bool animatePhysics
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xA17440", Offset = "0xA17440", VA = "0xA17440")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		private bool isAnimated
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xA17700", Offset = "0xA17700", VA = "0xA17700")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xA17324", Offset = "0xA17324", VA = "0xA17324")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xA173B8", Offset = "0xA173B8", VA = "0xA173B8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xA173BC", Offset = "0xA173BC", VA = "0xA173BC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xA173C0", Offset = "0xA173C0", VA = "0xA173C0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xA173C4", Offset = "0xA173C4", VA = "0xA173C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xA1743C", Offset = "0xA1743C", VA = "0xA1743C")]
		private void Start()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA173EC", Offset = "0xA173EC", VA = "0xA173EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA176C4", Offset = "0xA176C4", VA = "0xA176C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xA1750C", Offset = "0xA1750C", VA = "0xA1750C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xA17798", Offset = "0xA17798", VA = "0xA17798")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xA177E4", Offset = "0xA177E4", VA = "0xA177E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xA17830", Offset = "0xA17830", VA = "0xA17830")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xA17868", Offset = "0xA17868", VA = "0xA17868")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xA17878", Offset = "0xA17878", VA = "0xA17878")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xA1792C", Offset = "0xA1792C", VA = "0xA1792C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xA179E0", Offset = "0xA179E0", VA = "0xA179E0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xA17A94", Offset = "0xA17A94", VA = "0xA17A94")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public static class V3Tools
	{
		[Token(Token = "0x600022A")]
		[Address(RVA = "0xA17A9C", Offset = "0xA17A9C", VA = "0xA17A9C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xA17AF8", Offset = "0xA17AF8", VA = "0xA17AF8")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xA17B30", Offset = "0xA17B30", VA = "0xA17B30")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xA17C80", Offset = "0xA17C80", VA = "0xA17C80")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA17DFC", Offset = "0xA17DFC", VA = "0xA17DFC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA1804C", Offset = "0xA1804C", VA = "0xA1804C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA182A4", Offset = "0xA182A4", VA = "0xA182A4")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA18450", Offset = "0xA18450", VA = "0xA18450")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000078")]
	public static class Warning
	{
		[Token(Token = "0x2000079")]
		public delegate void Logger(string message);

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA18648", Offset = "0xA18648", VA = "0xA18648")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA12E54", Offset = "0xA12E54", VA = "0xA12E54")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x200007A")]
	public class AnimationBlocker : MonoBehaviour
	{
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xA187F4", Offset = "0xA187F4", VA = "0xA187F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xA188B8", Offset = "0xA188B8", VA = "0xA188B8")]
		public AnimationBlocker()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourAnimatedStagger")]
	public class BehaviourAnimatedStagger : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x200007C")]
		public struct FallParams
		{
			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float startPinWeightMlp;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float startMuscleWeightMlp;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float losePinSpeed;
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public struct FallParamsGroup
		{
			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Muscle.Group[] groups;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FallParams fallParams;
		}

		[Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class <LoseBalance>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourAnimatedStagger <>4__this;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool <done>5__2;

			[Token(Token = "0x1700001C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000243")]
				[Address(RVA = "0xA197CC", Offset = "0xA197CC", VA = "0xA197CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000245")]
				[Address(RVA = "0xA19814", Offset = "0xA19814", VA = "0xA19814", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0xA18D20", Offset = "0xA18D20", VA = "0xA18D20")]
			[DebuggerHidden]
			public <LoseBalance>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0xA18E28", Offset = "0xA18E28", VA = "0xA18E28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0xA18E2C", Offset = "0xA18E2C", VA = "0xA18E2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0xA197D4", Offset = "0xA197D4", VA = "0xA197D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Header("Master Properties")]
		public LayerMask groundLayers;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float animationBlendSpeed;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float animationMag;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public float momentumMag;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public float unbalancedMuscleWeightMlp;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float unbalancedMuscleDamperAdd;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool dropProps;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float maxGetUpVelocity;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float minHipHeight;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Header("Muscle Group Properties")]
		public FallParams defaults;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public FallParamsGroup[] groupOverrides;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Header("Events")]
		public PuppetEvent onUngrounded;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public PuppetEvent onFallOver;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public PuppetEvent onRest;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[HideInInspector]
		public Vector3 moveVector;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[HideInInspector]
		public bool isGrounded;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[HideInInspector]
		public Vector3 forward;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xA188C0", Offset = "0xA188C0", VA = "0xA188C0", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xA18C94", Offset = "0xA18C94", VA = "0xA18C94", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA18D1C", Offset = "0xA18D1C", VA = "0xA18D1C", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xA18CB4", Offset = "0xA18CB4", VA = "0xA18CB4")]
		[IteratorStateMachine(typeof(<LoseBalance>d__23))]
		private IEnumerator LoseBalance()
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xA18D48", Offset = "0xA18D48", VA = "0xA18D48")]
		private FallParams GetFallParams(Muscle.Group group)
		{
			return default(FallParams);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA18DEC", Offset = "0xA18DEC", VA = "0xA18DEC")]
		public BehaviourAnimatedStagger()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x2000080")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x2000081")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x2000082")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x2000083")]
		public struct PuppetEvent
		{
			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Another Puppet Behaviour to switch to on this event. This must be the exact Type of the the Behaviour, careful with spelling.")]
			public string switchToBehaviour;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Animations to cross-fade to on this event. This is separate from the UnityEvent below because UnityEvents can't handle calls with more than one parameter such as Animator.CrossFade.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x40001D9")]
			private const string empty = "";

			[Token(Token = "0x1700001F")]
			public bool switchBehaviour
			{
				[Token(Token = "0x600027E")]
				[Address(RVA = "0xA19740", Offset = "0xA19740", VA = "0xA19740")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0xA194F4", Offset = "0xA194F4", VA = "0xA194F4")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000084")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animationState;

			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int layer;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40001DE")]
			private const string empty = "";

			[Token(Token = "0x6000280")]
			[Address(RVA = "0xA1A85C", Offset = "0xA1A85C", VA = "0xA1A85C")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0xA1A918", Offset = "0xA1A918", VA = "0xA1A918")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0xA1AA14", Offset = "0xA1AA14", VA = "0xA1AA14")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0xA1AAEC", Offset = "0xA1AAEC", VA = "0xA1AAEC")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourDelegate OnPreFixedUpdate;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BehaviourDelegate OnPreUpdate;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourDelegate OnPreLateUpdate;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreRead;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreWrite;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BehaviourDelegate OnPostFixedUpdate;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BehaviourDelegate OnPostUpdate;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public BehaviourDelegate OnPostLateUpdate;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostRead;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostWrite;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public bool deactivated;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool initiated;

		[Token(Token = "0x1700001E")]
		public bool forceActive
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xA198A0", Offset = "0xA198A0", VA = "0xA198A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xA198A8", Offset = "0xA198A8", VA = "0xA198A8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000246")]
		public abstract void OnReactivate();

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xA1981C", Offset = "0xA1981C", VA = "0xA1981C", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xA19820", Offset = "0xA19820", VA = "0xA19820", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xA19824", Offset = "0xA19824", VA = "0xA19824", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA19828", Offset = "0xA19828", VA = "0xA19828", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA1982C", Offset = "0xA1982C", VA = "0xA1982C", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xA19830", Offset = "0xA19830", VA = "0xA19830", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA19834", Offset = "0xA19834", VA = "0xA19834", Slot = "11")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA19850", Offset = "0xA19850", VA = "0xA19850", Slot = "12")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA1986C", Offset = "0xA1986C", VA = "0xA1986C", Slot = "13")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xA19870", Offset = "0xA19870", VA = "0xA19870", Slot = "14")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA19874", Offset = "0xA19874", VA = "0xA19874", Slot = "15")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA19878", Offset = "0xA19878", VA = "0xA19878", Slot = "16")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA1987C", Offset = "0xA1987C", VA = "0xA1987C", Slot = "17")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xA19880", Offset = "0xA19880", VA = "0xA19880", Slot = "18")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA19884", Offset = "0xA19884", VA = "0xA19884", Slot = "19")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA19888", Offset = "0xA19888", VA = "0xA19888", Slot = "20")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA1988C", Offset = "0xA1988C", VA = "0xA1988C", Slot = "21")]
		protected virtual void OnReadBehaviour()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xA19890", Offset = "0xA19890", VA = "0xA19890", Slot = "22")]
		protected virtual void OnWriteBehaviour()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xA19894", Offset = "0xA19894", VA = "0xA19894", Slot = "23")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA19898", Offset = "0xA19898", VA = "0xA19898", Slot = "24")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA1989C", Offset = "0xA1989C", VA = "0xA1989C", Slot = "25")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xA198B4", Offset = "0xA198B4", VA = "0xA198B4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xA19914", Offset = "0xA19914", VA = "0xA19914")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA19980", Offset = "0xA19980", VA = "0xA19980")]
		public void OnRead()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xA199EC", Offset = "0xA199EC", VA = "0xA199EC")]
		public void OnWrite()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA19A58", Offset = "0xA19A58", VA = "0xA19A58")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xA19AF8", Offset = "0xA19AF8", VA = "0xA19AF8")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xA19BBC", Offset = "0xA19BBC", VA = "0xA19BBC")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA19C80", Offset = "0xA19C80", VA = "0xA19C80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xA19C90", Offset = "0xA19C90", VA = "0xA19C90")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xA19DA4", Offset = "0xA19DA4", VA = "0xA19DA4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xA19E04", Offset = "0xA19E04", VA = "0xA19E04")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xA19EB0", Offset = "0xA19EB0", VA = "0xA19EB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA19F5C", Offset = "0xA19F5C", VA = "0xA19F5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xA1A008", Offset = "0xA1A008", VA = "0xA1A008", Slot = "26")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xA1A04C", Offset = "0xA1A04C", VA = "0xA1A04C")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xA1A16C", Offset = "0xA1A16C", VA = "0xA1A16C")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xA19454", Offset = "0xA19454", VA = "0xA19454")]
		protected void RemoveMusclesOfGroup(Muscle.Group group)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xA1A308", Offset = "0xA1A308", VA = "0xA1A308", Slot = "27")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xA1A2A0", Offset = "0xA1A2A0", VA = "0xA1A2A0")]
		protected bool MusclesContainsGroup(Muscle.Group group)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xA18E20", Offset = "0xA18E20", VA = "0xA18E20")]
		protected BehaviourBase()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourFall")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page11.html")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class <SmoothActivate>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourFall <>4__this;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <fader>5__2;

			[Token(Token = "0x17000020")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000293")]
				[Address(RVA = "0xA1B4BC", Offset = "0xA1B4BC", VA = "0xA1B4BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000021")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000295")]
				[Address(RVA = "0xA1B504", Offset = "0xA1B504", VA = "0xA1B504", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0xA1AC38", Offset = "0xA1AC38", VA = "0xA1AC38")]
			[DebuggerHidden]
			public <SmoothActivate>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0xA1B2FC", Offset = "0xA1B2FC", VA = "0xA1B2FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0xA1B300", Offset = "0xA1B300", VA = "0xA1B300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0xA1B4C4", Offset = "0xA1B4C4", VA = "0xA1B4C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[LargeHeader("Animation State")]
		[Tooltip("Animation State to crossfade to when this behaviour is activated.")]
		public string stateName;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("The duration of crossfading to 'State Name'. Value is in seconds.")]
		public float transitionDuration;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Tooltip("Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.")]
		public int layer;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("Start time of the current destination state. Value is in seconds. If no explicit fixedTime is specified or fixedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time and no transition will happen.")]
		public float fixedTime;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[Tooltip("The layers that will be raycasted against to find colliding objects.")]
		[LargeHeader("Blending")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Tooltip("The parameter in the Animator that blends between catch fall and writhe animations.")]
		public string blendParameter;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[Tooltip("The height of the pelvis from the ground at which will blend to writhe animation.")]
		public float writheHeight;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[Tooltip("The vertical velocity of the pelvis at which will blend to writhe animation.")]
		public float writheYVelocity;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Tooltip("The speed of blendig between the two falling animations.")]
		public float blendSpeed;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[Tooltip("The speed of blending in mapping on activation.")]
		public float blendMappingSpeed;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[LargeHeader("Ending")]
		[Tooltip("If false, this behaviour will never end.")]
		public bool canEnd;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[Tooltip("The minimum time since this behaviour activated before it can end.")]
		public float minTime;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Tooltip("If the velocity of the pelvis falls below this value, can end the behaviour.")]
		public float maxEndVelocity;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Tooltip("Event triggered when all end conditions are met.")]
		public PuppetEvent onEnd;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float timer;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA1AB00", Offset = "0xA1AB00", VA = "0xA1AB00")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA1AB44", Offset = "0xA1AB44", VA = "0xA1AB44")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xA1AB88", Offset = "0xA1AB88", VA = "0xA1AB88", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xA1AC24", Offset = "0xA1AC24", VA = "0xA1AC24", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xA1AC2C", Offset = "0xA1AC2C", VA = "0xA1AC2C", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xA1ABBC", Offset = "0xA1ABBC", VA = "0xA1ABBC")]
		[IteratorStateMachine(typeof(<SmoothActivate>d__21))]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xA1AC60", Offset = "0xA1AC60", VA = "0xA1AC60", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xA1B110", Offset = "0xA1B110", VA = "0xA1B110", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xA1B214", Offset = "0xA1B214", VA = "0xA1B214", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xA1AFA8", Offset = "0xA1AFA8", VA = "0xA1AFA8")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xA1AEAC", Offset = "0xA1AEAC", VA = "0xA1AEAC")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xA1B260", Offset = "0xA1B260", VA = "0xA1B260")]
		public BehaviourFall()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourPuppet")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page10.html")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000088")]
		public enum State
		{
			[Token(Token = "0x400022A")]
			Puppet,
			[Token(Token = "0x400022B")]
			Unpinned,
			[Token(Token = "0x400022C")]
			GetUp
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public enum NormalMode
		{
			[Token(Token = "0x400022E")]
			Active,
			[Token(Token = "0x400022F")]
			Unmapped,
			[Token(Token = "0x4000230")]
			Kinematic
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class MasterProps
		{
			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xA1E90C", Offset = "0xA1E90C", VA = "0xA1E90C")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public struct MuscleProps
		{
			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			[Tooltip("How much will collisions with muscles of this group unpin parent muscles?")]
			public float unpinParents;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(0f, 1f)]
			[Tooltip("How much will collisions with muscles of this group unpin child muscles?")]
			public float unpinChildren;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("How much will collisions with muscles of this group unpin muscles of the same group?")]
			public float unpinGroup;

			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("If 1, muscles of this group will always be mapped to the ragdoll.")]
			[Range(0f, 1f)]
			public float minMappingWeight;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If 0, muscles of this group will not be mapped to the ragdoll pose even if they are unpinned.")]
			[Range(0f, 1f)]
			public float maxMappingWeight;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, muscles of this group will have their colliders disabled while in puppet state (not unbalanced nor getting up).")]
			public bool disableColliders;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("How fast will muscles of this group regain their pin weight (multiplier)?")]
			public float regainPinSpeed;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Smaller value means more unpinning from collisions (multiplier).")]
			public float collisionResistance;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
			public float knockOutDistance;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The PhysicsMaterial applied to the muscles while the character is in Puppet or GetUp state. Using a lower friction material reduces the risk of muscles getting stuck and pulled out of their joints.")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The PhysicsMaterial applied to the muscles while the character is in Unpinned state.")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Muscle groups to which those properties apply.")]
			public Muscle.Group[] groups;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The muscle properties for those muscle groups.")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("Multiplier for the 'Collision Resistance' for these layers.")]
			public float multiplier;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Overrides 'Collision Threshold' for these layers.")]
			public float collisionThreshold;
		}

		[Token(Token = "0x200008E")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[LargeHeader("Collision And Recovery")]
		public MasterProps masterProps;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Will ground the target to those layers when getting up.")]
		public LayerMask groundLayers;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Tooltip("Will unpin the muscles that collide with those layers.")]
		public LayerMask collisionLayers;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("The collision impulse sqrMagnitude threshold under which collisions will be ignored.")]
		public float collisionThreshold;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[Tooltip("Multiplies collision resistance for the specified layers.")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Tooltip("An optimisation. Will only process up to this number of collisions per physics step.")]
		[Range(1f, 30f)]
		public int maxCollisions;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[Range(0.001f, 10f)]
		[Tooltip("How fast will the muscles of this group regain their pin weight?")]
		public float regainPinSpeed;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Tooltip("'Boosting' is a term used for making muscles temporarily immune to collisions and/or deal more damage to the muscles of other characters. That is done by increasing Muscle.State.immunity and Muscle.State.impulseMlp. For example when you set muscle.state.immunity to 1, boostFalloff will determine how fast this value will fall back to normal (0). Use BehaviourPuppet.BoostImmunity() and BehaviourPuppet.BoostImpulseMlp() for boosting from your own scripts. It is helpful for making the puppet stronger and deliever more punch while playing a melee hitting/kicking animation.")]
		public float boostFalloff;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[LargeHeader("Muscle Group Properties")]
		[Tooltip("The default muscle properties. If there are no 'Group Overrides', this will be used for all muscles.")]
		public MuscleProps defaults;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[Tooltip("Overriding default muscle properties for some muscle groups (for example making the feet stiffer or the hands looser).")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[LargeHeader("Losing Balance")]
		[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
		[Range(0.001f, 10f)]
		public float knockOutDistance;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[Range(0f, 1f)]
		[Tooltip("Smaller value makes the muscles weaker when the puppet is knocked out.")]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[Tooltip("Most character controllers apply supernatural accelerations to characters when changing running direction or jumping. It will require major pinning forces to be applied on the ragdoll to keep up with that acceleration. When a puppet collides with something at that point and is unpinned, those forces might shoot the puppet off to space. This variable limits the velocity of the ragdoll's Rigidbodies when the puppet is unpinned.")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[Range(0f, 1f)]
		[Tooltip("If a muscle has drifted farther than 'Knock Out Distance', will only unpin the puppet if it's pin weight is less than this value. Lowering this value will make puppets less likely to lose balance on minor collisions.")]
		public float pinWeightThreshold;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[Tooltip("If false, will not unbalance the puppet by muscles that have their pin weight set to 0 in PuppetMaster muscle settings.")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[Tooltip("If true, all muscles of the 'Prop' group will be detached from the puppet when it loses balance.")]
		public bool dropProps;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[Tooltip("If true, GetUp state will be triggerred automatically after 'Get Up Delay' and when the velocity of the hip muscle is less than 'Max Get Up Velocity'.")]
		[LargeHeader("Getting Up")]
		public bool canGetUp;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[Tooltip("Minimum delay for getting up after loosing balance. After that time has passed, will wait for the velocity of the hip muscle to come down below 'Max Get Up Velocity' and then switch to the GetUp state.")]
		public float getUpDelay;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[Tooltip("The duration of blending the animation target from the ragdoll pose to the getting up animation once the GetUp state has been triggered.")]
		public float blendToAnimationTime;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[Tooltip("Will not get up before the velocity of the hip muscle has come down to this value.")]
		public float maxGetUpVelocity;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Tooltip("The duration of the 'GetUp' state after which it switches to the 'Puppetä state.")]
		public float minGetUpDuration;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[Tooltip("Collision resistance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[Tooltip("Regain pin weight speed multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[Tooltip("Knock out distance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a prone pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a supine pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[LargeHeader("Events")]
		[Tooltip("Called when the character starts getting up from a prone pose (facing down).")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[Tooltip("Called when the character starts getting up from a supine pose (facing up).")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[Tooltip("Called when the character is knocked out (loses balance). Doesn't matter from which state.")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[Tooltip("Called when the character is knocked out (loses balance) only from the normal Puppet state.")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[Tooltip("Called when the character is knocked out (loses balance) only from the GetUp state.")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[Tooltip("Called when the character has fully recovered and switched to the Puppet state.")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		[HideInInspector]
		public bool canMoveTarget;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float unpinnedTimer;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private float getUpTimer;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Vector3 hipsForward;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Vector3 hipsUp;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private float getupAnimationBlendWeightV;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private bool getUpTargetFixed;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private int collisions;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private bool eventsEnabled;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private float lastKnockOutDistance;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private float knockOutDistanceSqr;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool getupDisabled;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x299")]
		private bool hasCollidedSinceGetUp;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29A")]
		private bool hasBoosted;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private Vector3 getUpPosition;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		private bool dropPropFlag;

		[Token(Token = "0x17000022")]
		public State state
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0xA1B594", Offset = "0xA1B594", VA = "0xA1B594")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0xA1B59C", Offset = "0xA1B59C", VA = "0xA1B59C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xA1B50C", Offset = "0xA1B50C", VA = "0xA1B50C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA1B550", Offset = "0xA1B550", VA = "0xA1B550")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA1B5A4", Offset = "0xA1B5A4", VA = "0xA1B5A4", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xA1B7F8", Offset = "0xA1B7F8", VA = "0xA1B7F8")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xA1B860", Offset = "0xA1B860", VA = "0xA1B860", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xA1B8F8", Offset = "0xA1B8F8", VA = "0xA1B8F8", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xA1BE2C", Offset = "0xA1BE2C", VA = "0xA1BE2C", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xA1C500", Offset = "0xA1C500", VA = "0xA1C500", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xA1C588", Offset = "0xA1C588", VA = "0xA1C588", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xA1C590", Offset = "0xA1C590", VA = "0xA1C590", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xA1C600", Offset = "0xA1C600", VA = "0xA1C600", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xA1C60C", Offset = "0xA1C60C", VA = "0xA1C60C", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xA1CD08", Offset = "0xA1CD08", VA = "0xA1CD08", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA1CFB0", Offset = "0xA1CFB0", VA = "0xA1CFB0")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xA1D070", Offset = "0xA1D070", VA = "0xA1D070", Slot = "21")]
		protected override void OnReadBehaviour()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xA1CE58", Offset = "0xA1CE58", VA = "0xA1CE58")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xA1D350", Offset = "0xA1D350", VA = "0xA1D350", Slot = "11")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xA1D398", Offset = "0xA1D398", VA = "0xA1D398", Slot = "12")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xA1D31C", Offset = "0xA1D31C", VA = "0xA1D31C")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xA1D3D8", Offset = "0xA1D3D8", VA = "0xA1D3D8")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xA1D40C", Offset = "0xA1D40C", VA = "0xA1D40C", Slot = "27")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xA1D420", Offset = "0xA1D420", VA = "0xA1D420")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA1D5D8", Offset = "0xA1D5D8", VA = "0xA1D5D8")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xA1D65C", Offset = "0xA1D65C", VA = "0xA1D65C")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xA1D74C", Offset = "0xA1D74C", VA = "0xA1D74C")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA1D900", Offset = "0xA1D900", VA = "0xA1D900")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA1D69C", Offset = "0xA1D69C", VA = "0xA1D69C")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xA1D974", Offset = "0xA1D974", VA = "0xA1D974")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xA1DA0C", Offset = "0xA1DA0C", VA = "0xA1DA0C")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xA1D6F8", Offset = "0xA1D6F8", VA = "0xA1D6F8")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xA1DA78", Offset = "0xA1DA78", VA = "0xA1DA78")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xA1DB10", Offset = "0xA1DB10", VA = "0xA1DB10")]
		public void Unpin()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xA1DB88", Offset = "0xA1DB88", VA = "0xA1DB88", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xA1DD48", Offset = "0xA1DD48", VA = "0xA1DD48", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA1E120", Offset = "0xA1E120", VA = "0xA1E120")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA1DC60", Offset = "0xA1DC60", VA = "0xA1DC60")]
		private void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xA1E408", Offset = "0xA1E408", VA = "0xA1E408")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xA1E2C4", Offset = "0xA1E2C4", VA = "0xA1E2C4")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA1E608", Offset = "0xA1E608", VA = "0xA1E608")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xA1D868", Offset = "0xA1D868", VA = "0xA1D868")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xA1E350", Offset = "0xA1E350", VA = "0xA1E350")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xA1E6B4", Offset = "0xA1E6B4", VA = "0xA1E6B4")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xA1CC40", Offset = "0xA1CC40", VA = "0xA1CC40")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xA1BEB0", Offset = "0xA1BEB0", VA = "0xA1BEB0")]
		public void SetState(State newState)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xA1E780", Offset = "0xA1E780", VA = "0xA1E780")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xA1B654", Offset = "0xA1B654", VA = "0xA1B654")]
		private void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA1E7FC", Offset = "0xA1E7FC", VA = "0xA1E7FC")]
		public BehaviourPuppet()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourTemplate")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA1EAE0", Offset = "0xA1EAE0", VA = "0xA1EAE0", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA1EB00", Offset = "0xA1EB00", VA = "0xA1EB00", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA1EB04", Offset = "0xA1EB04", VA = "0xA1EB04", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xA1EB08", Offset = "0xA1EB08", VA = "0xA1EB08", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xA1EB0C", Offset = "0xA1EB0C", VA = "0xA1EB0C", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xA1EB48", Offset = "0xA1EB48", VA = "0xA1EB48", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xA1EB4C", Offset = "0xA1EB4C", VA = "0xA1EB4C", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xA1EB54", Offset = "0xA1EB54", VA = "0xA1EB54", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xA1EB5C", Offset = "0xA1EB5C", VA = "0xA1EB5C")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000091")]
		public class Settings
		{
			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Ankle joint damper / spring. Increase to make the balancing effect softer.")]
			public float damperForSpring;

			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier for joint max force.")]
			public float maxForceMlp;

			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Multiplier for the inertia tensor. Increasing this will increase the balancing forces.")]
			public float IMlp;

			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Velocity-based prediction.")]
			public float velocityF;

			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space offset for the center of pressure. Can be used to make the characer lean in a certain direction.")]
			public Vector3 copOffset;

			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The amount of torque applied to the lower legs to help keep the puppet balanced. Note that this is an external force (not coming from the joints themselves) and might make the simulation seem unnatural.")]
			public float torqueMlp;

			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Maximum magnitude of the torque applied to the lower legs if 'Torque Mlp' > 0.")]
			public float maxTorqueMag;

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xA1F2E8", Offset = "0xA1F2E8", VA = "0xA1F2E8")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Settings settings;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] copPoints;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PressureSensor pressureSensor;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody Ibody;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 I;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion toJointSpace;

		[Token(Token = "0x17000023")]
		public ConfigurableJoint joint
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xA1EB6C", Offset = "0xA1EB6C", VA = "0xA1EB6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xA1EB74", Offset = "0xA1EB74", VA = "0xA1EB74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Vector3 dir
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0xA1EB7C", Offset = "0xA1EB7C", VA = "0xA1EB7C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xA1EB88", Offset = "0xA1EB88", VA = "0xA1EB88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 dirVel
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xA1EB94", Offset = "0xA1EB94", VA = "0xA1EB94")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xA1EBA0", Offset = "0xA1EBA0", VA = "0xA1EBA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 cop
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xA1EBAC", Offset = "0xA1EBAC", VA = "0xA1EBAC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xA1EBB8", Offset = "0xA1EBB8", VA = "0xA1EBB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public Vector3 com
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xA1EBC4", Offset = "0xA1EBC4", VA = "0xA1EBC4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xA1EBD0", Offset = "0xA1EBD0", VA = "0xA1EBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Vector3 comV
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xA1EBDC", Offset = "0xA1EBDC", VA = "0xA1EBDC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xA1EBE8", Offset = "0xA1EBE8", VA = "0xA1EBE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xA1EBF4", Offset = "0xA1EBF4", VA = "0xA1EBF4")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xA1ED04", Offset = "0xA1ED04", VA = "0xA1ED04")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xA1F224", Offset = "0xA1F224", VA = "0xA1F224")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xA1F304", Offset = "0xA1F304", VA = "0xA1F304")]
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA1F30C", Offset = "0xA1F30C", VA = "0xA1F30C")]
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xA1F318", Offset = "0xA1F318", VA = "0xA1F318")]
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xA1F320", Offset = "0xA1F320", VA = "0xA1F320")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA1F2E0", Offset = "0xA1F2E0", VA = "0xA1F2E0")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public enum Mode
		{
			[Token(Token = "0x4000272")]
			FeetCentroid,
			[Token(Token = "0x4000273")]
			CenterOfPressure
		}

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool[] groundContacts;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		[Token(Token = "0x17000029")]
		public Vector3 position
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xA1F328", Offset = "0xA1F328", VA = "0xA1F328")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xA1F334", Offset = "0xA1F334", VA = "0xA1F334")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Vector3 direction
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xA1F340", Offset = "0xA1F340", VA = "0xA1F340")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xA1F34C", Offset = "0xA1F34C", VA = "0xA1F34C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float angle
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xA1F358", Offset = "0xA1F358", VA = "0xA1F358")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xA1F360", Offset = "0xA1F360", VA = "0xA1F360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Vector3 velocity
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xA1F368", Offset = "0xA1F368", VA = "0xA1F368")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xA1F374", Offset = "0xA1F374", VA = "0xA1F374")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xA1F380", Offset = "0xA1F380", VA = "0xA1F380")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xA1F38C", Offset = "0xA1F38C", VA = "0xA1F38C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Quaternion rotation
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xA1F398", Offset = "0xA1F398", VA = "0xA1F398")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xA1F3A4", Offset = "0xA1F3A4", VA = "0xA1F3A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public Quaternion inverseRotation
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xA1F3B0", Offset = "0xA1F3B0", VA = "0xA1F3B0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xA1F3BC", Offset = "0xA1F3BC", VA = "0xA1F3BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool isGrounded
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xA1F3C8", Offset = "0xA1F3C8", VA = "0xA1F3C8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xA1F3D0", Offset = "0xA1F3D0", VA = "0xA1F3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public float lastGroundedTime
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xA1F3DC", Offset = "0xA1F3DC", VA = "0xA1F3DC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xA1F3E4", Offset = "0xA1F3E4", VA = "0xA1F3E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xA188E0", Offset = "0xA188E0", VA = "0xA188E0")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xA1F3EC", Offset = "0xA1F3EC", VA = "0xA1F3EC")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xA1F490", Offset = "0xA1F490", VA = "0xA1F490")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xA1F698", Offset = "0xA1F698", VA = "0xA1F698")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xA1F79C", Offset = "0xA1F79C", VA = "0xA1F79C")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xA1FB7C", Offset = "0xA1FB7C", VA = "0xA1FB7C")]
		private void OnPreLateUpdate()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA201B0", Offset = "0xA201B0", VA = "0xA201B0")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA1F59C", Offset = "0xA1F59C", VA = "0xA1F59C")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA1FED4", Offset = "0xA1FED4", VA = "0xA1FED4")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xA1F950", Offset = "0xA1F950", VA = "0xA1F950")]
		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xA20018", Offset = "0xA20018", VA = "0xA20018")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xA20208", Offset = "0xA20208", VA = "0xA20208")]
		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xA1FF2C", Offset = "0xA1FF2C", VA = "0xA1FF2C")]
		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xA1FA84", Offset = "0xA1FA84", VA = "0xA1FA84")]
		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xA2033C", Offset = "0xA2033C", VA = "0xA2033C")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class Booster
	{
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("If true, all the muscles will be boosted and the 'Muscles' and 'Groups' properties below will be ignored.")]
		public bool fullBody;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Muscles to boost. Used only when 'Full Body' is false.")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Muscle groups to boost. Used only when 'Full Body' is false.")]
		public Muscle.Group[] groups;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("Immunity to apply to the muscles. If muscle immunity is 1, it can not be damaged.")]
		public float immunity;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Impulse multiplier to be applied to the muscles. This makes them deal more damage to other puppets.")]
		public float impulseMlp;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Falloff for parent muscles (power of kinship degree).")]
		public float boostParents;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Falloff for child muscles (power of kinship degree).")]
		public float boostChildren;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("This does nothing on it's own, you can use it in a 'yield return new WaitForseconds(delay);' call.")]
		public float delay;

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xA20350", Offset = "0xA20350", VA = "0xA20350")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xA20544", Offset = "0xA20544", VA = "0xA20544")]
		public Booster()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		public int muscleIndex;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xA205C8", Offset = "0xA205C8", VA = "0xA205C8")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xA20634", Offset = "0xA20634", VA = "0xA20634")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x2000098")]
		public enum Group
		{
			[Token(Token = "0x40002B0")]
			Hips,
			[Token(Token = "0x40002B1")]
			Spine,
			[Token(Token = "0x40002B2")]
			Head,
			[Token(Token = "0x40002B3")]
			Arm,
			[Token(Token = "0x40002B4")]
			Hand,
			[Token(Token = "0x40002B5")]
			Leg,
			[Token(Token = "0x40002B6")]
			Foot,
			[Token(Token = "0x40002B7")]
			Tail,
			[Token(Token = "0x40002B8")]
			Prop
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public class Props
		{
			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Which body part does this muscle belong to?")]
			public Group group;

			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			[Tooltip("The weight (multiplier) of mapping this muscle's target to the muscle.")]
			public float mappingWeight;

			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight (multiplier) of pinning this muscle to it's target's position using a simple AddForce command.")]
			public float pinWeight;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("The muscle strength (multiplier).")]
			public float muscleWeight;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplier of the positionDamper of the ConfigurableJoints' Slerp Drive.")]
			[Range(0f, 1f)]
			public float muscleDamper;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("If true, will map the target to the world space position of the muscle. Normally this should be true for only the root muscle (the hips).")]
			public bool mapPosition;

			[Token(Token = "0x600033E")]
			[Address(RVA = "0xA23A70", Offset = "0xA23A70", VA = "0xA23A70")]
			public Props()
			{
			}

			[Token(Token = "0x600033F")]
			[Address(RVA = "0xA23AA4", Offset = "0xA23AA4", VA = "0xA23AA4")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0xA23B04", Offset = "0xA23B04", VA = "0xA23B04")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x200009A")]
		public struct State
		{
			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x17000040")]
			public static State Default
			{
				[Token(Token = "0x6000341")]
				[Address(RVA = "0xA23B54", Offset = "0xA23B54", VA = "0xA23B54")]
				get
				{
					return default(State);
				}
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0xA23B70", Offset = "0xA23B70", VA = "0xA23B70")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Props props;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public State state;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public int[] parentIndexes;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public int[] childIndexes;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool[] childFlags;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public int[] kinshipDegrees;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 positionOffset;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private JointDrive slerpDrive;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float lastRotationDamper;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion toParentSpace;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Quaternion targetAnimatedWorldRotation;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Transform targetParent;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private bool directTargetParent;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x215")]
		private bool initiated;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Collider[] _colliders;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private float lastReadTime;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float lastWriteTime;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool[] disabledColliders;

		[Token(Token = "0x17000032")]
		public Transform transform
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xA2063C", Offset = "0xA2063C", VA = "0xA2063C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000310")]
			[Address(RVA = "0xA20644", Offset = "0xA20644", VA = "0xA20644")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xA2064C", Offset = "0xA2064C", VA = "0xA2064C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000312")]
			[Address(RVA = "0xA20654", Offset = "0xA20654", VA = "0xA20654")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0xA2065C", Offset = "0xA2065C", VA = "0xA2065C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000314")]
			[Address(RVA = "0xA20664", Offset = "0xA20664", VA = "0xA20664")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0xA2066C", Offset = "0xA2066C", VA = "0xA2066C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000316")]
			[Address(RVA = "0xA20678", Offset = "0xA20678", VA = "0xA20678")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Collider[] colliders
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0xA20684", Offset = "0xA20684", VA = "0xA20684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0xA2068C", Offset = "0xA2068C", VA = "0xA2068C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0xA20698", Offset = "0xA20698", VA = "0xA20698")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public Vector3 targetAngularVelocity
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0xA206A4", Offset = "0xA206A4", VA = "0xA206A4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0xA206B0", Offset = "0xA206B0", VA = "0xA206B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 mappedVelocity
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0xA206BC", Offset = "0xA206BC", VA = "0xA206BC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0xA206C8", Offset = "0xA206C8", VA = "0xA206C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Vector3 mappedAngularVelocity
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0xA206D4", Offset = "0xA206D4", VA = "0xA206D4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600031F")]
			[Address(RVA = "0xA206E0", Offset = "0xA206E0", VA = "0xA206E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0xA206EC", Offset = "0xA206EC", VA = "0xA206EC")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000321")]
			[Address(RVA = "0xA206FC", Offset = "0xA206FC", VA = "0xA206FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		private Quaternion localRotation
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0xA21A10", Offset = "0xA21A10", VA = "0xA21A10")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700003D")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xA21B88", Offset = "0xA21B88", VA = "0xA21B88")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700003E")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0xA21AD0", Offset = "0xA21AD0", VA = "0xA21AD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700003F")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0xA21CBC", Offset = "0xA21CBC", VA = "0xA21CBC")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xA2070C", Offset = "0xA2070C", VA = "0xA2070C")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA208E4", Offset = "0xA208E4", VA = "0xA208E4", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA218C4", Offset = "0xA218C4", VA = "0xA218C4")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA22398", Offset = "0xA22398", VA = "0xA22398")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA22444", Offset = "0xA22444", VA = "0xA22444")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA2204C", Offset = "0xA2204C", VA = "0xA2204C")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xA2229C", Offset = "0xA2229C", VA = "0xA2229C")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xA224E4", Offset = "0xA224E4", VA = "0xA224E4")]
		public void IgnoreCollisions(Muscle m, bool ignore)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xA22690", Offset = "0xA22690", VA = "0xA22690")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xA2272C", Offset = "0xA2272C", VA = "0xA2272C")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xA22788", Offset = "0xA22788", VA = "0xA22788")]
		public void Reset()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xA22988", Offset = "0xA22988", VA = "0xA22988")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xA21DFC", Offset = "0xA21DFC", VA = "0xA21DFC")]
		public void Read()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xA22A7C", Offset = "0xA22A7C", VA = "0xA22A7C")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xA22B88", Offset = "0xA22B88", VA = "0xA22B88")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xA22E28", Offset = "0xA22E28", VA = "0xA22E28", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xA232C4", Offset = "0xA232C4", VA = "0xA232C4")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA236A8", Offset = "0xA236A8", VA = "0xA236A8")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xA22F08", Offset = "0xA22F08", VA = "0xA22F08")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xA23118", Offset = "0xA23118", VA = "0xA23118")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xA237F4", Offset = "0xA237F4", VA = "0xA237F4")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xA22DC8", Offset = "0xA22DC8", VA = "0xA22DC8")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xA219DC", Offset = "0xA219DC", VA = "0xA219DC")]
		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xA2391C", Offset = "0xA2391C", VA = "0xA2391C")]
		public Muscle()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public struct MuscleCollision
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xA23BC4", Offset = "0xA23BC4", VA = "0xA23BC4")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	[Token(Token = "0x200009C")]
	public struct MuscleHit
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xA23BD8", Offset = "0xA23BD8", VA = "0xA23BD8")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Muscle Collision Broadcaster")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x40002D2")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x40002D3")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x40002D4")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xA23BF0", Offset = "0xA23BF0", VA = "0xA23BF0")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xA23CC8", Offset = "0xA23CC8", VA = "0xA23CC8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xA23E4C", Offset = "0xA23E4C", VA = "0xA23E4C")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xA24084", Offset = "0xA24084", VA = "0xA24084")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xA242B0", Offset = "0xA242B0", VA = "0xA242B0")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public static class PhysXTools
	{
		[Token(Token = "0x600034A")]
		[Address(RVA = "0xA242B8", Offset = "0xA242B8", VA = "0xA242B8")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xA24414", Offset = "0xA24414", VA = "0xA24414")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xA24570", Offset = "0xA24570", VA = "0xA24570")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xA24610", Offset = "0xA24610", VA = "0xA24610")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xA246A0", Offset = "0xA246A0", VA = "0xA246A0")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xA247A0", Offset = "0xA247A0", VA = "0xA247A0")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xA24B38", Offset = "0xA24B38", VA = "0xA24B38")]
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xA24D08", Offset = "0xA24D08", VA = "0xA24D08")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xA24EB0", Offset = "0xA24EB0", VA = "0xA24EB0")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xA2500C", Offset = "0xA2500C", VA = "0xA2500C")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xA2504C", Offset = "0xA2504C", VA = "0xA2504C")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xA250F8", Offset = "0xA250F8", VA = "0xA250F8")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xA24600", Offset = "0xA24600", VA = "0xA24600")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200009F")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int count;

		[Token(Token = "0x17000041")]
		public Vector3 center
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0xA2512C", Offset = "0xA2512C", VA = "0xA2512C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0xA25138", Offset = "0xA25138", VA = "0xA25138")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool inContact
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0xA25144", Offset = "0xA25144", VA = "0xA25144")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0xA2514C", Offset = "0xA2514C", VA = "0xA2514C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public Vector3 bottom
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xA25158", Offset = "0xA25158", VA = "0xA25158")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0xA25164", Offset = "0xA25164", VA = "0xA25164")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Rigidbody r
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0xA25170", Offset = "0xA25170", VA = "0xA25170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0xA25178", Offset = "0xA25178", VA = "0xA25178")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA25180", Offset = "0xA25180", VA = "0xA25180")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA251F4", Offset = "0xA251F4", VA = "0xA251F4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA25348", Offset = "0xA25348", VA = "0xA25348")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA2534C", Offset = "0xA2534C", VA = "0xA2534C")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA25354", Offset = "0xA25354", VA = "0xA25354")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xA253CC", Offset = "0xA253CC", VA = "0xA253CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xA251F8", Offset = "0xA251F8", VA = "0xA251F8")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xA25408", Offset = "0xA25408", VA = "0xA25408")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xA2542C", Offset = "0xA2542C", VA = "0xA2542C")]
		public PressureSensor()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("This has no other purpose but helping you distinguish props by PropRoot.currentProp.propType.")]
		public int propType;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Muscle of this prop.")]
		[LargeHeader("Muscle")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The muscle properties that will be applied to the Muscle on pickup.")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If true, this prop's layer will be forced to PuppetMaster layer and target's layer forced to PuppetMaster's Target Root's layer when the prop is picked up.")]
		public bool forceLayers;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[LargeHeader("Additional Pin")]
		[Tooltip("Optinal additional pin, useful for long melee weapons that would otherwise require a lot of muscle force and solver iterations to be swinged quickly. Should normally be without any colliders attached. The position of the pin, it's mass and the pin weight will effect how the prop will handle.")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Target Transform for the additional pin.")]
		public Transform additionalPinTarget;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("The pin weight of the additional pin. Increasing this weight will make the prop follow animation better, but will increase jitter when colliding with objects.")]
		public float additionalPinWeight;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider[] colliders;

		[Token(Token = "0x17000045")]
		public bool isPickedUp
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0xA25434", Offset = "0xA25434", VA = "0xA25434")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public PropRoot propRoot
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0xA25494", Offset = "0xA25494", VA = "0xA25494")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0xA2549C", Offset = "0xA2549C", VA = "0xA2549C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xA254A4", Offset = "0xA254A4", VA = "0xA254A4")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xA25634", Offset = "0xA25634", VA = "0xA25634")]
		public void Drop()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xA25644", Offset = "0xA25644", VA = "0xA25644")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xA2564C", Offset = "0xA2564C", VA = "0xA2564C", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xA25650", Offset = "0xA25650", VA = "0xA25650", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xA25654", Offset = "0xA25654", VA = "0xA25654", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xA25658", Offset = "0xA25658", VA = "0xA25658", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xA2581C", Offset = "0xA2581C", VA = "0xA2581C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xA25848", Offset = "0xA25848", VA = "0xA25848")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xA2597C", Offset = "0xA2597C", VA = "0xA2597C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xA25B04", Offset = "0xA25B04", VA = "0xA25B04")]
		protected Prop()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Prop Root")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If a prop is connected, what will it's joint be connected to?")]
		public Rigidbody connectTo;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Is there a Prop connected to this PropRoot? Simply assign this value to connect, replace or drop props.")]
		public Prop currentProp;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xA25BBC", Offset = "0xA25BBC", VA = "0xA25BBC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xA25C00", Offset = "0xA25C00", VA = "0xA25C00")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xA25C44", Offset = "0xA25C44", VA = "0xA25C44")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xA26A24", Offset = "0xA26A24", VA = "0xA26A24")]
		private void Awake()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xA26A9C", Offset = "0xA26A9C", VA = "0xA26A9C")]
		private void Update()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xA26BA4", Offset = "0xA26BA4", VA = "0xA26BA4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xA26D40", Offset = "0xA26D40", VA = "0xA26D40")]
		private void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xA27844", Offset = "0xA27844", VA = "0xA27844")]
		public PropRoot()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Prop Template")]
	public class PropTemplate : Prop
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xA2784C", Offset = "0xA2784C", VA = "0xA2784C", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xA27850", Offset = "0xA27850", VA = "0xA27850", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xA27854", Offset = "0xA27854", VA = "0xA27854", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xA27858", Offset = "0xA27858", VA = "0xA27858")]
		public PropTemplate()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[HelpURL("https://www.youtube.com/watch?v=LYusqeqHAUc")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Puppet Master")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		public enum Mode
		{
			[Token(Token = "0x400033C")]
			Active,
			[Token(Token = "0x400033D")]
			Kinematic,
			[Token(Token = "0x400033E")]
			Disabled
		}

		[Token(Token = "0x20000A5")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000A6")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x20000A7")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000340")]
			Normal,
			[Token(Token = "0x4000341")]
			AnimatePhysics,
			[Token(Token = "0x4000342")]
			FixedUpdate
		}

		[Serializable]
		[Token(Token = "0x20000A8")]
		public enum State
		{
			[Token(Token = "0x4000344")]
			Alive,
			[Token(Token = "0x4000345")]
			Dead,
			[Token(Token = "0x4000346")]
			Frozen
		}

		[Serializable]
		[Token(Token = "0x20000A9")]
		public struct StateSettings
		{
			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("How much does it take to weigh out muscle weight to deadMuscleWeight?")]
			public float killDuration;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("The muscle weight mlp while the puppet is Dead.")]
			public float deadMuscleWeight;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("The muscle damper add while the puppet is Dead.")]
			public float deadMuscleDamper;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("The max square velocity of the ragdoll bones for freezing the puppet.")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If true, PuppetMaster, all it's behaviours and the ragdoll will be destroyed when the puppet is frozen.")]
			public bool freezePermanently;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[Tooltip("If true, will enable angular limits when killing the puppet.")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[Tooltip("If true, will enable internal collisions when killing the puppet.")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x17000055")]
			public static StateSettings Default
			{
				[Token(Token = "0x6000408")]
				[Address(RVA = "0xA27A10", Offset = "0xA27A10", VA = "0xA27A10")]
				get
				{
					return default(StateSettings);
				}
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0xA32378", Offset = "0xA32378", VA = "0xA32378")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class <DisabledToActive>d__125 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000056")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600040C")]
				[Address(RVA = "0xA325E0", Offset = "0xA325E0", VA = "0xA325E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000057")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600040E")]
				[Address(RVA = "0xA32628", Offset = "0xA32628", VA = "0xA32628", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0xA2D644", Offset = "0xA2D644", VA = "0xA2D644")]
			[DebuggerHidden]
			public <DisabledToActive>d__125(int <>1__state)
			{
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0xA3239C", Offset = "0xA3239C", VA = "0xA3239C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0xA323A0", Offset = "0xA323A0", VA = "0xA323A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0xA325E8", Offset = "0xA325E8", VA = "0xA325E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class <KinematicToActive>d__127 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000058")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000412")]
				[Address(RVA = "0xA327CC", Offset = "0xA327CC", VA = "0xA327CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000414")]
				[Address(RVA = "0xA32814", Offset = "0xA32814", VA = "0xA32814", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0xA2D66C", Offset = "0xA2D66C", VA = "0xA2D66C")]
			[DebuggerHidden]
			public <KinematicToActive>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0xA32630", Offset = "0xA32630", VA = "0xA32630", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0xA32634", Offset = "0xA32634", VA = "0xA32634", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0xA327D4", Offset = "0xA327D4", VA = "0xA327D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class <ActiveToDisabled>d__128 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700005A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000418")]
				[Address(RVA = "0xA32914", Offset = "0xA32914", VA = "0xA32914", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600041A")]
				[Address(RVA = "0xA3295C", Offset = "0xA3295C", VA = "0xA3295C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0xA2D694", Offset = "0xA2D694", VA = "0xA2D694")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__128(int <>1__state)
			{
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0xA3281C", Offset = "0xA3281C", VA = "0xA3281C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0xA32820", Offset = "0xA32820", VA = "0xA32820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0xA3291C", Offset = "0xA3291C", VA = "0xA3291C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class <ActiveToKinematic>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700005C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0xA32A94", Offset = "0xA32A94", VA = "0xA32A94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000420")]
				[Address(RVA = "0xA32ADC", Offset = "0xA32ADC", VA = "0xA32ADC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0xA2D6BC", Offset = "0xA2D6BC", VA = "0xA2D6BC")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0xA32964", Offset = "0xA32964", VA = "0xA32964", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0xA32968", Offset = "0xA32968", VA = "0xA32968", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0xA32A9C", Offset = "0xA32A9C", VA = "0xA32A9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class <AliveToDead>d__181 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <range>5__2;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <mW>5__3;

			[Token(Token = "0x1700005E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000424")]
				[Address(RVA = "0xA32DEC", Offset = "0xA32DEC", VA = "0xA32DEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000426")]
				[Address(RVA = "0xA32E34", Offset = "0xA32E34", VA = "0xA32E34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0xA30C84", Offset = "0xA30C84", VA = "0xA30C84")]
			[DebuggerHidden]
			public <AliveToDead>d__181(int <>1__state)
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0xA32AE4", Offset = "0xA32AE4", VA = "0xA32AE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0xA32AE8", Offset = "0xA32AE8", VA = "0xA32AE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0xA32DF4", Offset = "0xA32DF4", VA = "0xA32DF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Humanoid Config allows you to easily share PuppetMaster properties, including individual muscle props between Humanoid puppets.")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Simulation")]
		[Tooltip("Sets/sets the state of the puppet (Alive, Dead or Frozen). Frozen means the ragdoll will be deactivated once it comes to stop in dead state.")]
		public State state;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[ContextMenuItem("Reset To Default", "ResetStateSettings")]
		[Tooltip("Settings for killing and freezing the puppet.")]
		public StateSettings stateSettings;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Active mode means all muscles are active and the character is physically simulated. Kinematic mode sets rigidbody.isKinematic to true for all the muscles and simply updates their position/rotation to match the target's. Disabled mode disables the ragdoll. Switching modes is done by simply changing this value, blending in/out will be handled automatically by the PuppetMaster.")]
		public Mode mode;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The time of blending when switching from Active to Kinematic/Disabled or from Kinematic/Disabled to Active. Switching from Kinematic to Disabled or vice versa will be done instantly.")]
		public float blendTime;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("If true, will fix the target character's Transforms to their default local positions and rotations in each update cycle to avoid drifting from additive reading-writing. Use this only if the target contains unanimated bones.")]
		public bool fixTargetTransforms;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Rigidbody.solverIterationCount for the muscles of this Puppet.")]
		public int solverIterationCount;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If true, will draw the target's pose as green lines in the Scene view. This runs in the Editor only. If you wish to profile PuppetMaster, switch this off.")]
		public bool visualizeTargetPose;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[LargeHeader("Master Weights")]
		[Tooltip("The weight of mapping the animated character to the ragdoll pose.")]
		[Range(0f, 1f)]
		public float mappingWeight;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The weight of pinning the muscles to the position of their animated targets using simple AddForce.")]
		[Range(0f, 1f)]
		public float pinWeight;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The normalized strength of the muscles.")]
		[Range(0f, 1f)]
		public float muscleWeight;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[LargeHeader("Joint and Muscle Settings")]
		[Tooltip("The positionSpring of the ConfigurableJoints' Slerp Drive.")]
		public float muscleSpring;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("The positionDamper of the ConfigurableJoints' Slerp Drive.")]
		public float muscleDamper;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Adjusts the slope of the pinWeight curve. Has effect only while interpolating pinWeight from 0 to 1 and back.")]
		[Range(1f, 8f)]
		public float pinPow;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 100f)]
		[Tooltip("Reduces pinning force the farther away the target is. Bigger value loosens the pinning, resulting in sloppier behaviour.")]
		public float pinDistanceFalloff;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("When the target has animated bones between the muscle bones, the joint anchors need to be updated in every update cycle because the muscles' targets move relative to each other in position space. This gives much more accurate results, but is computationally expensive so consider leaving it off.")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[Tooltip("Enable this if any of the target's bones has translation animation.")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[Tooltip("Should the joints use angular limits? If the PuppetMaster fails to match the target's pose, it might be because the joint limits are too stiff and do not allow for such motion. Uncheck this to see if the limits are clamping the range of your puppet's animation. Since the joints are actuated, most PuppetMaster simulations will not actually require using joint limits at all.")]
		public bool angularLimits;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[Tooltip("Should the muscles collide with each other? Consider leaving this off while the puppet is pinned for performance and better accuracy.  Since the joints are actuated, most PuppetMaster simulations will not actually require internal collisions at all.")]
		public bool internalCollisions;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The Muscles managed by this PuppetMaster.")]
		[LargeHeader("Individual Muscle Settings")]
		public Muscle[] muscles;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Animator _targetAnimator;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		public List<SolverManager> solvers;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		private bool fixedFrame;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int lastSolverIterationCount;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool isLegacy;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private bool animatorDisabled;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		private bool awakeFailed;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		private bool interpolated;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool freezeFlag;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		private bool hasBeenDisabled;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
		private bool teleport;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 teleportPosition;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Quaternion teleportRotation;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Mode activeMode;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Mode lastMode;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float mappingBlend;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private State activeState;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private State lastState;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		[HideInInspector]
		public bool storeTargetMappedState;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Transform[] targetChildren;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3[] targetMappedPositions;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Quaternion[] targetMappedRotations;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Vector3[] targetSampledPositions;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Quaternion[] targetSampledRotations;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool targetMappedStateStored;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x179")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17A")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17B")]
		private bool hasProp;

		[Token(Token = "0x17000047")]
		public Animator targetAnimator
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xA27A34", Offset = "0xA27A34", VA = "0xA27A34")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038A")]
			[Address(RVA = "0xA27B60", Offset = "0xA27B60", VA = "0xA27B60")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Animation targetAnimation
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xA27B68", Offset = "0xA27B68", VA = "0xA27B68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0xA27B70", Offset = "0xA27B70", VA = "0xA27B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public BehaviourBase[] behaviours
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0xA27B78", Offset = "0xA27B78", VA = "0xA27B78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0xA27B80", Offset = "0xA27B80", VA = "0xA27B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool isActive
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0xA27B88", Offset = "0xA27B88", VA = "0xA27B88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public bool initiated
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0xA27C00", Offset = "0xA27C00", VA = "0xA27C00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0xA27C08", Offset = "0xA27C08", VA = "0xA27C08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0xA27C14", Offset = "0xA27C14", VA = "0xA27C14")]
			get
			{
				return default(UpdateMode);
			}
		}

		[Token(Token = "0x1700004D")]
		public bool controlsAnimator
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0xA27D24", Offset = "0xA27D24", VA = "0xA27D24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public bool isBlending
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0xA27BDC", Offset = "0xA27BDC", VA = "0xA27BDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xA27C4C", Offset = "0xA27C4C", VA = "0xA27C4C")]
			get
			{
				return default(AnimatorUpdateMode);
			}
		}

		[Token(Token = "0x17000050")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xA2D0F4", Offset = "0xA2D0F4", VA = "0xA2D0F4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xA2D0FC", Offset = "0xA2D0FC", VA = "0xA2D0FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool isSwitchingState
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xA27D78", Offset = "0xA27D78", VA = "0xA27D78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		public bool isKilling
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xA306D4", Offset = "0xA306D4", VA = "0xA306D4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0xA306DC", Offset = "0xA306DC", VA = "0xA306DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool isAlive
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xA2BE04", Offset = "0xA2BE04", VA = "0xA2BE04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public bool isFrozen
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xA2B580", Offset = "0xA2B580", VA = "0xA2B580")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xA2785C", Offset = "0xA2785C", VA = "0xA2785C")]
		[ContextMenu("User Manual (Setup)")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xA278A0", Offset = "0xA278A0", VA = "0xA278A0")]
		[ContextMenu("User Manual (Component)")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xA278E4", Offset = "0xA278E4", VA = "0xA278E4")]
		[ContextMenu("User Manual (Performance)")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xA27928", Offset = "0xA27928", VA = "0xA27928")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xA2796C", Offset = "0xA2796C", VA = "0xA2796C")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xA279B0", Offset = "0xA279B0", VA = "0xA279B0")]
		[ContextMenu("TUTORIAL VIDEO (COMPONENT)")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xA279F4", Offset = "0xA279F4", VA = "0xA279F4")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xA27D8C", Offset = "0xA27D8C", VA = "0xA27D8C")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xA27DB4", Offset = "0xA27DB4", VA = "0xA27DB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xA27E4C", Offset = "0xA27E4C", VA = "0xA27E4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xA28518", Offset = "0xA28518", VA = "0xA28518")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xA28E40", Offset = "0xA28E40", VA = "0xA28E40")]
		private void Start()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xA28EEC", Offset = "0xA28EEC", VA = "0xA28EEC")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xA28550", Offset = "0xA28550", VA = "0xA28550")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xA2A4B8", Offset = "0xA2A4B8", VA = "0xA2A4B8")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xA2A594", Offset = "0xA2A594", VA = "0xA2A594")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xA2A6E0", Offset = "0xA2A6E0", VA = "0xA2A6E0")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xA2A760", Offset = "0xA2A760", VA = "0xA2A760", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xA2B6FC", Offset = "0xA2B6FC", VA = "0xA2B6FC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xA2B768", Offset = "0xA2B768", VA = "0xA2B768", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xA2B7B4", Offset = "0xA2B7B4", VA = "0xA2B7B4", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xA2B9F4", Offset = "0xA2B9F4", VA = "0xA2B9F4")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xA2ACA0", Offset = "0xA2ACA0", VA = "0xA2ACA0")]
		private void Read()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xA2AB64", Offset = "0xA2AB64", VA = "0xA2AB64")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xA2BE14", Offset = "0xA2BE14", VA = "0xA2BE14")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xA2C094", Offset = "0xA2C094", VA = "0xA2C094")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xA2B590", Offset = "0xA2B590", VA = "0xA2B590")]
		private void SetInternalCollisions(bool collide)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xA2B674", Offset = "0xA2B674", VA = "0xA2B674")]
		private void SetAngularLimits(bool limited)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xA26F80", Offset = "0xA26F80", VA = "0xA26F80")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xA25CF0", Offset = "0xA25CF0", VA = "0xA25CF0")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xA2C9D4", Offset = "0xA2C9D4", VA = "0xA2C9D4")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xA2CA70", Offset = "0xA2CA70", VA = "0xA2CA70")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xA2CB0C", Offset = "0xA2CB0C", VA = "0xA2CB0C")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xA2CBA8", Offset = "0xA2CBA8", VA = "0xA2CBA8")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xA2CC44", Offset = "0xA2CC44", VA = "0xA2CC44")]
		[ContextMenu("Flatten Muscle Hierarchy")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xA2CD3C", Offset = "0xA2CD3C", VA = "0xA2CD3C")]
		[ContextMenu("Tree Muscle Hierarchy")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xA2CE88", Offset = "0xA2CE88", VA = "0xA2CE88")]
		[ContextMenu("Fix Muscle Positions")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xA2CF9C", Offset = "0xA2CF9C", VA = "0xA2CF9C")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xA2A01C", Offset = "0xA2A01C", VA = "0xA2A01C")]
		private bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xA2C898", Offset = "0xA2C898", VA = "0xA2C898")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xA2C924", Offset = "0xA2C924", VA = "0xA2C924")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xA2D108", Offset = "0xA2D108", VA = "0xA2D108")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xA2D198", Offset = "0xA2D198", VA = "0xA2D198", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xA2D2DC", Offset = "0xA2D2DC", VA = "0xA2D2DC")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xA2D41C", Offset = "0xA2D41C", VA = "0xA2D41C")]
		[IteratorStateMachine(typeof(<DisabledToActive>d__125))]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xA2D484", Offset = "0xA2D484", VA = "0xA2D484")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xA2D50C", Offset = "0xA2D50C", VA = "0xA2D50C")]
		[IteratorStateMachine(typeof(<KinematicToActive>d__127))]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xA2D574", Offset = "0xA2D574", VA = "0xA2D574")]
		[IteratorStateMachine(typeof(<ActiveToDisabled>d__128))]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xA2D5DC", Offset = "0xA2D5DC", VA = "0xA2D5DC")]
		[IteratorStateMachine(typeof(<ActiveToKinematic>d__129))]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xA2D6E4", Offset = "0xA2D6E4", VA = "0xA2D6E4")]
		private void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xA2D7AC", Offset = "0xA2D7AC", VA = "0xA2D7AC")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xA2D840", Offset = "0xA2D840", VA = "0xA2D840")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xA2DBE0", Offset = "0xA2DBE0", VA = "0xA2DBE0")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xA2DE74", Offset = "0xA2DE74", VA = "0xA2DE74")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xA2DF84", Offset = "0xA2DF84", VA = "0xA2DF84")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xA2E064", Offset = "0xA2E064", VA = "0xA2E064")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xA2DA9C", Offset = "0xA2DA9C", VA = "0xA2DA9C")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xA2E0E8", Offset = "0xA2E0E8", VA = "0xA2E0E8")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xA2C360", Offset = "0xA2C360", VA = "0xA2C360")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xA2E308", Offset = "0xA2E308", VA = "0xA2E308")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xA2C290", Offset = "0xA2C290", VA = "0xA2C290")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xA2DC64", Offset = "0xA2DC64", VA = "0xA2DC64")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xA2D8C4", Offset = "0xA2D8C4", VA = "0xA2D8C4")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xA2E130", Offset = "0xA2E130", VA = "0xA2E130")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xA2C6C0", Offset = "0xA2C6C0", VA = "0xA2C6C0")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xA2E350", Offset = "0xA2E350", VA = "0xA2E350")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xA2EFB0", Offset = "0xA2EFB0", VA = "0xA2EFB0")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xA2E440", Offset = "0xA2E440", VA = "0xA2E440")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xA2F120", Offset = "0xA2F120", VA = "0xA2F120")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xA2F8F0", Offset = "0xA2F8F0", VA = "0xA2F8F0")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xA302AC", Offset = "0xA302AC", VA = "0xA302AC")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xA2F51C", Offset = "0xA2F51C", VA = "0xA2F51C")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xA2FFE0", Offset = "0xA2FFE0", VA = "0xA2FFE0")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xA306E8", Offset = "0xA306E8", VA = "0xA306E8")]
		public void Kill()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xA306F4", Offset = "0xA306F4", VA = "0xA306F4")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xA30710", Offset = "0xA30710", VA = "0xA30710")]
		public void Freeze()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xA3071C", Offset = "0xA3071C", VA = "0xA3071C")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xA30738", Offset = "0xA30738", VA = "0xA30738")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xA30740", Offset = "0xA30740", VA = "0xA30740", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xA30834", Offset = "0xA30834", VA = "0xA30834")]
		[IteratorStateMachine(typeof(<AliveToDead>d__181))]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xA2BB90", Offset = "0xA2BB90", VA = "0xA2BB90")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xA308B0", Offset = "0xA308B0", VA = "0xA308B0")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xA2825C", Offset = "0xA2825C", VA = "0xA2825C")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xA309A4", Offset = "0xA309A4", VA = "0xA309A4")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xA309B0", Offset = "0xA309B0", VA = "0xA309B0")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xA30BB4", Offset = "0xA30BB4", VA = "0xA30BB4")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xA28344", Offset = "0xA28344", VA = "0xA28344")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xA30CAC", Offset = "0xA30CAC", VA = "0xA30CAC")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xA30D44", Offset = "0xA30D44", VA = "0xA30D44")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xA30E24", Offset = "0xA30E24", VA = "0xA30E24")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xA2A114", Offset = "0xA2A114", VA = "0xA2A114")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xA29E28", Offset = "0xA29E28", VA = "0xA29E28")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xA317A0", Offset = "0xA317A0", VA = "0xA317A0")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xA31660", Offset = "0xA31660", VA = "0xA31660")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xA31270", Offset = "0xA31270", VA = "0xA31270")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xA31800", Offset = "0xA31800", VA = "0xA31800")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xA31960", Offset = "0xA31960", VA = "0xA31960")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xA3156C", Offset = "0xA3156C", VA = "0xA3156C")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xA31C18", Offset = "0xA31C18", VA = "0xA31C18")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xA31D64", Offset = "0xA31D64", VA = "0xA31D64")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xA31B5C", Offset = "0xA31B5C", VA = "0xA31B5C")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xA29294", Offset = "0xA29294", VA = "0xA29294")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xA2C3A8", Offset = "0xA2C3A8", VA = "0xA2C3A8")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xA2C204", Offset = "0xA2C204", VA = "0xA2C204")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xA31FA0", Offset = "0xA31FA0", VA = "0xA31FA0")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public enum MuscleRemoveMode
	{
		[Token(Token = "0x4000361")]
		Sever,
		[Token(Token = "0x4000362")]
		Explode,
		[Token(Token = "0x4000363")]
		Numb
	}
	[Token(Token = "0x20000B0")]
	[CreateAssetMenu(fileName = "PuppetMaster Humanoid Config", menuName = "PuppetMaster/Humanoid Config", order = 1)]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Token(Token = "0x600042A")]
			[Address(RVA = "0xA32FFC", Offset = "0xA32FFC", VA = "0xA32FFC")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("Simulation")]
		public PuppetMaster.State state;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[LargeHeader("Master Weights")]
		[Range(0f, 1f)]
		public float mappingWeight;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float pinWeight;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float muscleWeight;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[LargeHeader("Joint and Muscle Settings")]
		public float muscleSpring;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(1f, 8f)]
		public float pinPow;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 100f)]
		public float pinDistanceFalloff;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool angularLimits;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool internalCollisions;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[LargeHeader("Individual Muscle Settings")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xA29B8C", Offset = "0xA29B8C", VA = "0xA29B8C")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xA32E3C", Offset = "0xA32E3C", VA = "0xA32E3C")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xA32F50", Offset = "0xA32F50", VA = "0xA32F50")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/PuppetMaster Settings")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x20000B3")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(1f, 100f)]
			public int puppetsPerFrame;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int index;

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xA33578", Offset = "0xA33578", VA = "0xA33578")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xA333D8", Offset = "0xA333D8", VA = "0xA333D8")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0xA3303C", Offset = "0xA3303C", VA = "0xA3303C")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Optimizations")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x17000060")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0xA33004", Offset = "0xA33004", VA = "0xA33004")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600042C")]
			[Address(RVA = "0xA3300C", Offset = "0xA3300C", VA = "0xA3300C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0xA33014", Offset = "0xA33014", VA = "0xA33014")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600042E")]
			[Address(RVA = "0xA3301C", Offset = "0xA3301C", VA = "0xA3301C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0xA33024", Offset = "0xA33024", VA = "0xA33024")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xA3302C", Offset = "0xA3302C", VA = "0xA3302C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0xA33034", Offset = "0xA33034", VA = "0xA33034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xA2A3E4", Offset = "0xA2A3E4", VA = "0xA2A3E4")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xA2A688", Offset = "0xA2A688", VA = "0xA2A688")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xA2BDE0", Offset = "0xA2BDE0", VA = "0xA2BDE0")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xA3315C", Offset = "0xA3315C", VA = "0xA3315C")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xA33180", Offset = "0xA33180", VA = "0xA33180")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xA331A4", Offset = "0xA331A4", VA = "0xA331A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xA333F4", Offset = "0xA333F4", VA = "0xA333F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xA3345C", Offset = "0xA3345C", VA = "0xA3345C")]
		public PuppetMasterSettings()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public static class PuppetMasterTools
	{
		[Token(Token = "0x600043D")]
		[Address(RVA = "0xA33598", Offset = "0xA33598", VA = "0xA33598")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xA33B6C", Offset = "0xA33B6C", VA = "0xA33B6C")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xA3444C", Offset = "0xA3444C", VA = "0xA3444C")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xA3452C", Offset = "0xA3452C", VA = "0xA3452C")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x20000B6")]
		public enum Mode
		{
			[Token(Token = "0x400038B")]
			Float,
			[Token(Token = "0x400038C")]
			Curve
		}

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xA34664", Offset = "0xA34664", VA = "0xA34664")]
		public Weight(float floatValue)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xA346C8", Offset = "0xA346C8", VA = "0xA346C8")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xA3473C", Offset = "0xA3473C", VA = "0xA3473C")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000B7")]
	public class InitialVelocity : MonoBehaviour
	{
		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 initialVelocity;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xA34770", Offset = "0xA34770", VA = "0xA34770")]
		private void Start()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xA347D0", Offset = "0xA347D0", VA = "0xA347D0")]
		public InitialVelocity()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Biped Ragdoll Creator")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public struct Options
		{
			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Header("Optional Bones")]
			public bool spine;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Header("Joints")]
			public JointType joints;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Header("Colliders")]
			public float colliderLengthOverlap;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x17000064")]
			public static Options Default
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0xA37CD4", Offset = "0xA37CD4", VA = "0xA37CD4")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xA347D8", Offset = "0xA347D8", VA = "0xA347D8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xA3481C", Offset = "0xA3481C", VA = "0xA3481C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xA34860", Offset = "0xA34860", VA = "0xA34860")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xA348A4", Offset = "0xA348A4", VA = "0xA348A4")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xA34B28", Offset = "0xA34B28", VA = "0xA34B28")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xA34C70", Offset = "0xA34C70", VA = "0xA34C70")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xA36780", Offset = "0xA36780", VA = "0xA36780")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xA36B7C", Offset = "0xA36B7C", VA = "0xA36B7C")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xA37278", Offset = "0xA37278", VA = "0xA37278")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xA35A94", Offset = "0xA35A94", VA = "0xA35A94")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xA35EE0", Offset = "0xA35EE0", VA = "0xA35EE0")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xA37378", Offset = "0xA37378", VA = "0xA37378")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xA37B2C", Offset = "0xA37B2C", VA = "0xA37B2C")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xA37B94", Offset = "0xA37B94", VA = "0xA37B94")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xA366F8", Offset = "0xA366F8", VA = "0xA366F8")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xA34AB0", Offset = "0xA34AB0", VA = "0xA34AB0")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xA37C80", Offset = "0xA37C80", VA = "0xA37C80")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xA37D0C", Offset = "0xA37D0C", VA = "0xA37D0C")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xA38484", Offset = "0xA38484", VA = "0xA38484")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xA3856C", Offset = "0xA3856C", VA = "0xA3856C")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xA38868", Offset = "0xA38868", VA = "0xA38868")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xA38B70", Offset = "0xA38B70", VA = "0xA38B70")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xA38E98", Offset = "0xA38E98", VA = "0xA38E98")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xA390AC", Offset = "0xA390AC", VA = "0xA390AC")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x20000BB")]
	public static class JointConverter
	{
		[Token(Token = "0x600045F")]
		[Address(RVA = "0xA39144", Offset = "0xA39144", VA = "0xA39144")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xA3964C", Offset = "0xA3964C", VA = "0xA3964C")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xA3993C", Offset = "0xA3993C", VA = "0xA3993C")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xA39A90", Offset = "0xA39A90", VA = "0xA39A90")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xA39414", Offset = "0xA39414", VA = "0xA39414")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xA39C34", Offset = "0xA39C34", VA = "0xA39C34")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xA39D60", Offset = "0xA39D60", VA = "0xA39D60")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xA39E0C", Offset = "0xA39E0C", VA = "0xA39E0C")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xA39DB8", Offset = "0xA39DB8", VA = "0xA39DB8")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xA39E64", Offset = "0xA39E64", VA = "0xA39E64")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xA39EC0", Offset = "0xA39EC0", VA = "0xA39EC0")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x20000BC")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public enum ColliderType
		{
			[Token(Token = "0x40003B1")]
			Box,
			[Token(Token = "0x40003B2")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public enum JointType
		{
			[Token(Token = "0x40003B4")]
			Configurable,
			[Token(Token = "0x40003B5")]
			Character
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		public enum Direction
		{
			[Token(Token = "0x40003B7")]
			X,
			[Token(Token = "0x40003B8")]
			Y,
			[Token(Token = "0x40003B9")]
			Z
		}

		[Token(Token = "0x20000C0")]
		public struct CreateJointParams
		{
			[Token(Token = "0x20000C1")]
			public struct Limits
			{
				[Token(Token = "0x40003C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x40003C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x40003C2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x40003C3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x600047A")]
				[Address(RVA = "0xA3B730", Offset = "0xA3B730", VA = "0xA3B730")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x6000479")]
			[Address(RVA = "0xA3B710", Offset = "0xA3B710", VA = "0xA3B710")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xA39F0C", Offset = "0xA39F0C", VA = "0xA39F0C")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xA3A0EC", Offset = "0xA3A0EC", VA = "0xA3A0EC")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xA3A2FC", Offset = "0xA3A2FC", VA = "0xA3A2FC")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xA3A7A8", Offset = "0xA3A7A8", VA = "0xA3A7A8")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xA3A644", Offset = "0xA3A644", VA = "0xA3A644")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xA3AB30", Offset = "0xA3AB30", VA = "0xA3AB30")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xA3AB40", Offset = "0xA3AB40", VA = "0xA3AB40")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xA3AB5C", Offset = "0xA3AB5C", VA = "0xA3AB5C")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xA3AC3C", Offset = "0xA3AC3C", VA = "0xA3AC3C")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xA3A670", Offset = "0xA3A670", VA = "0xA3A670")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xA3AD1C", Offset = "0xA3AD1C", VA = "0xA3AD1C")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xA3AF94", Offset = "0xA3AF94", VA = "0xA3AF94")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xA3B134", Offset = "0xA3B134", VA = "0xA3B134")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xA3B6D8", Offset = "0xA3B6D8", VA = "0xA3B6D8")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xA3B708", Offset = "0xA3B708", VA = "0xA3B708")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Ragdoll Editor")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public enum Mode
		{
			[Token(Token = "0x40003C9")]
			Colliders,
			[Token(Token = "0x40003CA")]
			Joints
		}

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Collider selectedCollider;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool symmetry;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Mode mode;

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xA3B73C", Offset = "0xA3B73C", VA = "0xA3B73C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xA3B780", Offset = "0xA3B780", VA = "0xA3B780")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xA3B7C4", Offset = "0xA3B7C4", VA = "0xA3B7C4")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xA3B808", Offset = "0xA3B808", VA = "0xA3B808")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000C4")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xA3B818", Offset = "0xA3B818", VA = "0xA3B818")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xA3B898", Offset = "0xA3B898", VA = "0xA3B898")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xA3B8A0", Offset = "0xA3B8A0", VA = "0xA3B8A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xA3B90C", Offset = "0xA3B90C", VA = "0xA3B90C")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xA3B96C", Offset = "0xA3B96C", VA = "0xA3B96C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xA3B9A4", Offset = "0xA3B9A4", VA = "0xA3B9A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xA3BAEC", Offset = "0xA3BAEC", VA = "0xA3BAEC")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xA3BC5C", Offset = "0xA3BC5C", VA = "0xA3BC5C")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xA3BE40", Offset = "0xA3BE40", VA = "0xA3BE40")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xA3BED0", Offset = "0xA3BED0", VA = "0xA3BED0")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xA3BEE4", Offset = "0xA3BEE4", VA = "0xA3BEE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xA3C050", Offset = "0xA3C050", VA = "0xA3C050")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xA3C24C", Offset = "0xA3C24C", VA = "0xA3C24C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xA3C27C", Offset = "0xA3C27C", VA = "0xA3C27C")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xA3C6A8", Offset = "0xA3C6A8", VA = "0xA3C6A8")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xA3C6C8", Offset = "0xA3C6C8", VA = "0xA3C6C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xA3CFE4", Offset = "0xA3CFE4", VA = "0xA3CFE4")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xA3CD60", Offset = "0xA3CD60", VA = "0xA3CD60")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xA3D0F4", Offset = "0xA3D0F4", VA = "0xA3D0F4")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x17000065")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0xA3D120", Offset = "0xA3D120", VA = "0xA3D120")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xA3D1A0", Offset = "0xA3D1A0", VA = "0xA3D1A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xA3D4E4", Offset = "0xA3D4E4", VA = "0xA3D4E4")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x17000068")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004A0")]
				[Address(RVA = "0xA3DED4", Offset = "0xA3DED4", VA = "0xA3DED4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000069")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004A2")]
				[Address(RVA = "0xA3DF1C", Offset = "0xA3DF1C", VA = "0xA3DF1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0xA3DBF8", Offset = "0xA3DBF8", VA = "0xA3DBF8")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0xA3DC50", Offset = "0xA3DC50", VA = "0xA3DC50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0xA3DC54", Offset = "0xA3DC54", VA = "0xA3DC54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xA3DEDC", Offset = "0xA3DEDC", VA = "0xA3DEDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x17000066")]
		public bool isStepping
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0xA3D4F8", Offset = "0xA3D4F8", VA = "0xA3D4F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		public Vector3 position
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xA3D0C4", Offset = "0xA3D0C4", VA = "0xA3D0C4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xA3D50C", Offset = "0xA3D50C", VA = "0xA3D50C")]
			set
			{
			}
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xA3D558", Offset = "0xA3D558", VA = "0xA3D558")]
		private void Start()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xA3D698", Offset = "0xA3D698", VA = "0xA3D698")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xA3D938", Offset = "0xA3D938", VA = "0xA3D938")]
		private void Update()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xA3DB54", Offset = "0xA3DB54", VA = "0xA3DB54")]
		[IteratorStateMachine(typeof(<Step>d__24))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xA3DC20", Offset = "0xA3DC20", VA = "0xA3DC20")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xA3DF24", Offset = "0xA3DF24", VA = "0xA3DF24")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xA3DFF0", Offset = "0xA3DFF0", VA = "0xA3DFF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xA3E264", Offset = "0xA3E264", VA = "0xA3E264")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public struct Warp
		{
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000429")]
			PositionOffset,
			[Token(Token = "0x400042A")]
			Position
		}

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xA3E26C", Offset = "0xA3E26C", VA = "0xA3E26C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xA3E28C", Offset = "0xA3E28C", VA = "0xA3E28C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xA3E4A4", Offset = "0xA3E4A4", VA = "0xA3E4A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xA3E75C", Offset = "0xA3E75C", VA = "0xA3E75C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xA3E7F0", Offset = "0xA3E7F0", VA = "0xA3E7F0")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xA3E7F8", Offset = "0xA3E7F8", VA = "0xA3E7F8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xA3E848", Offset = "0xA3E848", VA = "0xA3E848")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xA3EA50", Offset = "0xA3EA50", VA = "0xA3EA50", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xA3EC78", Offset = "0xA3EC78", VA = "0xA3EC78")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[RequireComponent(typeof(AimIK))]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xA3EC8C", Offset = "0xA3EC8C", VA = "0xA3EC8C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xA3EE20", Offset = "0xA3EE20", VA = "0xA3EE20", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xA3EE88", Offset = "0xA3EE88", VA = "0xA3EE88")]
		private void Read()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xA3EFC0", Offset = "0xA3EFC0", VA = "0xA3EFC0")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xA3F01C", Offset = "0xA3F01C", VA = "0xA3F01C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xA3F664", Offset = "0xA3F664", VA = "0xA3F664")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xA3F478", Offset = "0xA3F478", VA = "0xA3F478")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xA3F908", Offset = "0xA3F908", VA = "0xA3F908")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xA3FA14", Offset = "0xA3FA14", VA = "0xA3FA14")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xA3FA30", Offset = "0xA3FA30", VA = "0xA3FA30", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xA3FA8C", Offset = "0xA3FA8C", VA = "0xA3FA8C", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xA3FDC8", Offset = "0xA3FDC8", VA = "0xA3FDC8")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xA3FEB8", Offset = "0xA3FEB8", VA = "0xA3FEB8")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[RequireComponent(typeof(AnimatorController3rdPerson))]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x1700006A")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xA40118", Offset = "0xA40118", VA = "0xA40118")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006B")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xA40198", Offset = "0xA40198", VA = "0xA40198")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xA3FEC0", Offset = "0xA3FEC0", VA = "0xA3FEC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xA3FF28", Offset = "0xA3FF28", VA = "0xA3FF28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xA40218", Offset = "0xA40218", VA = "0xA40218")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xA40220", Offset = "0xA40220", VA = "0xA40220", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xA4067C", Offset = "0xA4067C", VA = "0xA4067C")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xA40684", Offset = "0xA40684", VA = "0xA40684")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xA40728", Offset = "0xA40728", VA = "0xA40728")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xA40B84", Offset = "0xA40B84", VA = "0xA40B84")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xA40C24", Offset = "0xA40C24", VA = "0xA40C24")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D8")]
		public class Limb
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xA40DB8", Offset = "0xA40DB8", VA = "0xA40DB8")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xA40EDC", Offset = "0xA40EDC", VA = "0xA40EDC")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xA40C94", Offset = "0xA40C94", VA = "0xA40C94")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xA40E30", Offset = "0xA40E30", VA = "0xA40E30")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xA40EC8", Offset = "0xA40EC8", VA = "0xA40EC8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xA40ECC", Offset = "0xA40ECC", VA = "0xA40ECC")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xA40EEC", Offset = "0xA40EEC", VA = "0xA40EEC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xA40F54", Offset = "0xA40F54", VA = "0xA40F54")]
		private void Update()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xA4101C", Offset = "0xA4101C", VA = "0xA4101C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xA41024", Offset = "0xA41024", VA = "0xA41024")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xA41074", Offset = "0xA41074", VA = "0xA41074")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xA4120C", Offset = "0xA4120C", VA = "0xA4120C")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xA41214", Offset = "0xA41214", VA = "0xA41214")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xA412E4", Offset = "0xA412E4", VA = "0xA412E4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xA41364", Offset = "0xA41364", VA = "0xA41364")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xA417AC", Offset = "0xA417AC", VA = "0xA417AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xA418B8", Offset = "0xA418B8", VA = "0xA418B8")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		[SerializeField]
		private float cameraRecoilWeight;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool updateFrame;

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xA418C0", Offset = "0xA418C0", VA = "0xA418C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xA41A20", Offset = "0xA41A20", VA = "0xA41A20")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xA41A2C", Offset = "0xA41A2C", VA = "0xA41A2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xA41CEC", Offset = "0xA41CEC", VA = "0xA41CEC")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xA41E3C", Offset = "0xA41E3C", VA = "0xA41E3C")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xA41AF0", Offset = "0xA41AF0", VA = "0xA41AF0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xA42AC0", Offset = "0xA42AC0", VA = "0xA42AC0")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(FPSAiming))]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xA42AE0", Offset = "0xA42AE0", VA = "0xA42AE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xA42B5C", Offset = "0xA42B5C", VA = "0xA42B5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xA42C58", Offset = "0xA42C58", VA = "0xA42C58")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xA42D04", Offset = "0xA42D04", VA = "0xA42D04")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xA42D14", Offset = "0xA42D14", VA = "0xA42D14")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xA42E58", Offset = "0xA42E58", VA = "0xA42E58")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xA42FBC", Offset = "0xA42FBC", VA = "0xA42FBC")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xA42FCC", Offset = "0xA42FCC", VA = "0xA42FCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xA43198", Offset = "0xA43198", VA = "0xA43198")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xA435A8", Offset = "0xA435A8", VA = "0xA435A8")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xA435B8", Offset = "0xA435B8", VA = "0xA435B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xA436A0", Offset = "0xA436A0", VA = "0xA436A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xA4378C", Offset = "0xA4378C", VA = "0xA4378C")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xA43794", Offset = "0xA43794", VA = "0xA43794")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xA43C94", Offset = "0xA43C94", VA = "0xA43C94")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[RequireComponent(typeof(InteractionSystem))]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("The object to interact to")]
		private InteractionObject interactionObject;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("The effectors to interact with")]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xA43C9C", Offset = "0xA43C9C", VA = "0xA43C9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xA43CEC", Offset = "0xA43CEC", VA = "0xA43CEC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xA43F98", Offset = "0xA43F98", VA = "0xA43F98")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E4")]
		public class Partner
		{
			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x1700006C")]
			private Transform neck
			{
				[Token(Token = "0x60004F6")]
				[Address(RVA = "0xA447A4", Offset = "0xA447A4", VA = "0xA447A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xA43FC8", Offset = "0xA43FC8", VA = "0xA43FC8")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xA44044", Offset = "0xA44044", VA = "0xA44044")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xA4463C", Offset = "0xA4463C", VA = "0xA4463C")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xA447F0", Offset = "0xA447F0", VA = "0xA447F0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xA43FA0", Offset = "0xA43FA0", VA = "0xA43FA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xA43FE8", Offset = "0xA43FE8", VA = "0xA43FE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xA4462C", Offset = "0xA4462C", VA = "0xA4462C")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		public enum Mode
		{
			[Token(Token = "0x40004B4")]
			Position,
			[Token(Token = "0x40004B5")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public class Absorber
		{
			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xA44968", Offset = "0xA44968", VA = "0xA44968")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000500")]
			[Address(RVA = "0xA44B3C", Offset = "0xA44B3C", VA = "0xA44B3C")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0xA44B60", Offset = "0xA44B60", VA = "0xA44B60")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0xA44C70", Offset = "0xA44C70", VA = "0xA44C70")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0xA44E08", Offset = "0xA44E08", VA = "0xA44E08")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xA44804", Offset = "0xA44804", VA = "0xA44804", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xA448E8", Offset = "0xA448E8", VA = "0xA448E8")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xA44A30", Offset = "0xA44A30", VA = "0xA44A30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xA44BF4", Offset = "0xA44BF4", VA = "0xA44BF4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xA44CE0", Offset = "0xA44CE0", VA = "0xA44CE0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xA44DF8", Offset = "0xA44DF8", VA = "0xA44DF8")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xA44E68", Offset = "0xA44E68", VA = "0xA44E68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xA44ED8", Offset = "0xA44ED8", VA = "0xA44ED8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xA44FA8", Offset = "0xA44FA8", VA = "0xA44FA8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xA450F0", Offset = "0xA450F0", VA = "0xA450F0")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000EA")]
		public class EffectorLink
		{
			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x600050B")]
			[Address(RVA = "0xA45370", Offset = "0xA45370", VA = "0xA45370")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xA45104", Offset = "0xA45104", VA = "0xA45104", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xA451F0", Offset = "0xA451F0", VA = "0xA451F0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xA45368", Offset = "0xA45368", VA = "0xA45368")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xA45380", Offset = "0xA45380", VA = "0xA45380")]
		private void Start()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xA45680", Offset = "0xA45680", VA = "0xA45680")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xA45E7C", Offset = "0xA45E7C", VA = "0xA45E7C")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x1700006D")]
		private bool holding
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0xA460FC", Offset = "0xA460FC", VA = "0xA460FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xA45EE8", Offset = "0xA45EE8", VA = "0xA45EE8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000510")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xA4611C", Offset = "0xA4611C", VA = "0xA4611C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xA462DC", Offset = "0xA462DC", VA = "0xA462DC")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xA4644C", Offset = "0xA4644C", VA = "0xA4644C")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xA4651C", Offset = "0xA4651C", VA = "0xA4651C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xA4663C", Offset = "0xA4663C", VA = "0xA4663C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xA467B0", Offset = "0xA467B0", VA = "0xA467B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xA469AC", Offset = "0xA469AC", VA = "0xA469AC")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000519")]
		[Address(RVA = "0xA469C0", Offset = "0xA469C0", VA = "0xA469C0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xA46BA0", Offset = "0xA46BA0", VA = "0xA46BA0")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600051B")]
		[Address(RVA = "0xA46BB4", Offset = "0xA46BB4", VA = "0xA46BB4", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xA46CC8", Offset = "0xA46CC8", VA = "0xA46CC8")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x20000F0")]
		[CompilerGenerated]
		private sealed class <applyForce>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtilityDemo <>4__this;

			[Token(Token = "0x1700006E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000525")]
				[Address(RVA = "0xA47108", Offset = "0xA47108", VA = "0xA47108", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000527")]
				[Address(RVA = "0xA47150", Offset = "0xA47150", VA = "0xA47150", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0xA46FD4", Offset = "0xA46FD4", VA = "0xA46FD4")]
			[DebuggerHidden]
			public <applyForce>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0xA47010", Offset = "0xA47010", VA = "0xA47010", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xA47014", Offset = "0xA47014", VA = "0xA47014", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0xA47110", Offset = "0xA47110", VA = "0xA47110", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rigidbody rigibodyHit;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float hitForce;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody hitTransform;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RaycastHit raycastHit;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Camera theCamera;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xA46CDC", Offset = "0xA46CDC", VA = "0xA46CDC")]
		private void Start()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xA46D60", Offset = "0xA46D60", VA = "0xA46D60")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xA46DF8", Offset = "0xA46DF8", VA = "0xA46DF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xA46F6C", Offset = "0xA46F6C", VA = "0xA46F6C")]
		[IteratorStateMachine(typeof(<applyForce>d__13))]
		private IEnumerator applyForce()
		{
			return null;
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xA46FFC", Offset = "0xA46FFC", VA = "0xA46FFC")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[RequireComponent(typeof(Recoil))]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xA47158", Offset = "0xA47158", VA = "0xA47158")]
		private void Start()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xA471A8", Offset = "0xA471A8", VA = "0xA471A8")]
		private void Update()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xA471F4", Offset = "0xA471F4", VA = "0xA471F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xA4728C", Offset = "0xA4728C", VA = "0xA4728C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000070")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000533")]
				[Address(RVA = "0xA475CC", Offset = "0xA475CC", VA = "0xA475CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000535")]
				[Address(RVA = "0xA47614", Offset = "0xA47614", VA = "0xA47614", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0xA47400", Offset = "0xA47400", VA = "0xA47400")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0xA47438", Offset = "0xA47438", VA = "0xA47438", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0xA4743C", Offset = "0xA4743C", VA = "0xA4743C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0xA475D4", Offset = "0xA475D4", VA = "0xA475D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xA4729C", Offset = "0xA4729C", VA = "0xA4729C")]
		private void Start()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xA4734C", Offset = "0xA4734C", VA = "0xA4734C")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xA47388", Offset = "0xA47388", VA = "0xA47388")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xA47428", Offset = "0xA47428", VA = "0xA47428")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[RequireComponent(typeof(Animator))]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000072")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600053C")]
				[Address(RVA = "0xA47888", Offset = "0xA47888", VA = "0xA47888", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600053E")]
				[Address(RVA = "0xA478D0", Offset = "0xA478D0", VA = "0xA478D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0xA4772C", Offset = "0xA4772C", VA = "0xA4772C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0xA4775C", Offset = "0xA4775C", VA = "0xA4775C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0xA47760", Offset = "0xA47760", VA = "0xA47760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600053D")]
			[Address(RVA = "0xA47890", Offset = "0xA47890", VA = "0xA47890", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xA4761C", Offset = "0xA4761C", VA = "0xA4761C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xA476C4", Offset = "0xA476C4", VA = "0xA476C4")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xA47754", Offset = "0xA47754", VA = "0xA47754")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		public class EffectorLink
		{
			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000543")]
			[Address(RVA = "0xA4793C", Offset = "0xA4793C", VA = "0xA4793C")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0xA48478", Offset = "0xA48478", VA = "0xA48478")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xA47D00", Offset = "0xA47D00", VA = "0xA47D00")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0xA48554", Offset = "0xA48554", VA = "0xA48554")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0xA48638", Offset = "0xA48638", VA = "0xA48638")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0xA486C4", Offset = "0xA486C4", VA = "0xA486C4")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0xA4874C", Offset = "0xA4874C", VA = "0xA4874C")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0xA482B8", Offset = "0xA482B8", VA = "0xA482B8")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0xA487D4", Offset = "0xA487D4", VA = "0xA487D4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xA478D8", Offset = "0xA478D8", VA = "0xA478D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xA47CA0", Offset = "0xA47CA0", VA = "0xA47CA0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xA48208", Offset = "0xA48208", VA = "0xA48208")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xA48470", Offset = "0xA48470", VA = "0xA48470")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xA48808", Offset = "0xA48808", VA = "0xA48808")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xA48838", Offset = "0xA48838", VA = "0xA48838")]
		private void Update()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xA488E8", Offset = "0xA488E8", VA = "0xA488E8")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xA488FC", Offset = "0xA488FC", VA = "0xA488FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xA48AE0", Offset = "0xA48AE0", VA = "0xA48AE0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xA48D7C", Offset = "0xA48D7C", VA = "0xA48D7C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xA48E44", Offset = "0xA48E44", VA = "0xA48E44")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xA48F50", Offset = "0xA48F50", VA = "0xA48F50")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xA48F58", Offset = "0xA48F58", VA = "0xA48F58", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xA493B0", Offset = "0xA493B0", VA = "0xA493B0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xA49578", Offset = "0xA49578", VA = "0xA49578")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xA495AC", Offset = "0xA495AC", VA = "0xA495AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xA497B4", Offset = "0xA497B4", VA = "0xA497B4")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xA49820", Offset = "0xA49820", VA = "0xA49820")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20000FD")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x17000074")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000563")]
				[Address(RVA = "0xA49F6C", Offset = "0xA49F6C", VA = "0xA49F6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000565")]
				[Address(RVA = "0xA49FB4", Offset = "0xA49FB4", VA = "0xA49FB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0xA49C00", Offset = "0xA49C00", VA = "0xA49C00")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0xA49DF0", Offset = "0xA49DF0", VA = "0xA49DF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000562")]
			[Address(RVA = "0xA49DF4", Offset = "0xA49DF4", VA = "0xA49DF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000564")]
			[Address(RVA = "0xA49F74", Offset = "0xA49F74", VA = "0xA49F74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xA49828", Offset = "0xA49828", VA = "0xA49828")]
		private void Start()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xA4994C", Offset = "0xA4994C", VA = "0xA4994C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xA498E4", Offset = "0xA498E4", VA = "0xA498E4")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xA49C28", Offset = "0xA49C28", VA = "0xA49C28")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xA49D00", Offset = "0xA49D00", VA = "0xA49D00")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xA49DD4", Offset = "0xA49DD4", VA = "0xA49DD4")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xA49FBC", Offset = "0xA49FBC", VA = "0xA49FBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xA4A024", Offset = "0xA4A024", VA = "0xA4A024")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xA4A0D0", Offset = "0xA4A0D0", VA = "0xA4A0D0")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000100")]
		public class Part
		{
			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x600056B")]
			[Address(RVA = "0xA4A144", Offset = "0xA4A144", VA = "0xA4A144")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xA4A264", Offset = "0xA4A264", VA = "0xA4A264")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xA4A0E0", Offset = "0xA4A0E0", VA = "0xA4A0E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xA4A25C", Offset = "0xA4A25C", VA = "0xA4A25C")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xA4A26C", Offset = "0xA4A26C", VA = "0xA4A26C")]
		private void Update()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xA4A3B0", Offset = "0xA4A3B0", VA = "0xA4A3B0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xA4A514", Offset = "0xA4A514", VA = "0xA4A514")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xA4A524", Offset = "0xA4A524", VA = "0xA4A524")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xA4A550", Offset = "0xA4A550", VA = "0xA4A550")]
		[ContextMenu("Calibrate")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xA4A580", Offset = "0xA4A580", VA = "0xA4A580")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xA4A588", Offset = "0xA4A588", VA = "0xA4A588")]
		private void Start()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xA4A5D8", Offset = "0xA4A5D8", VA = "0xA4A5D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xA4A7B0", Offset = "0xA4A7B0", VA = "0xA4A7B0")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorIKDemo : MonoBehaviour
	{
		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandIKTarget;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xA4A808", Offset = "0xA4A808", VA = "0xA4A808")]
		private void Start()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xA4A858", Offset = "0xA4A858", VA = "0xA4A858")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xA4A8B0", Offset = "0xA4A8B0", VA = "0xA4A8B0")]
		public AnimatorIKDemo()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class BallShooter : MonoBehaviour
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode keyCode;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ball;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 spawnOffset;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 force;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float mass;

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xA4A8B8", Offset = "0xA4A8B8", VA = "0xA4A8B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xA4AAD4", Offset = "0xA4AAD4", VA = "0xA4AAD4")]
		public BallShooter()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class CharacterAnimationMeleeDemo : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x17000076")]
		private CharacterMeleeDemo melee
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0xA4AB00", Offset = "0xA4AB00", VA = "0xA4AB00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xA4AB7C", Offset = "0xA4AB7C", VA = "0xA4AB7C", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xA4B03C", Offset = "0xA4B03C", VA = "0xA4B03C")]
		public CharacterAnimationMeleeDemo()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class CharacterMeleeDemo : CharacterPuppet
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public class Action
		{
			[Serializable]
			[Token(Token = "0x2000109")]
			public class Anim
			{
				[Token(Token = "0x4000557")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string stateName;

				[Token(Token = "0x4000558")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int layer;

				[Token(Token = "0x4000559")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public float transitionDuration;

				[Token(Token = "0x400055A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public float fixedTime;

				[Token(Token = "0x6000584")]
				[Address(RVA = "0xA4B690", Offset = "0xA4B690", VA = "0xA4B690")]
				public Anim()
				{
				}
			}

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int inputActionIndex;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float duration;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float minFrequency;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Anim anim;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] requiredPropTypes;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Booster[] boosters;

			[Token(Token = "0x6000583")]
			[Address(RVA = "0xA4B680", Offset = "0xA4B680", VA = "0xA4B680")]
			public Action()
			{
			}
		}

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[Header("Melee")]
		public Action[] actions;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[HideInInspector]
		public int currentActionIndex;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		[HideInInspector]
		public float lastActionTime;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float lastActionMoveMag;

		[Token(Token = "0x17000077")]
		public Action currentAction
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0xA4AFFC", Offset = "0xA4AFFC", VA = "0xA4AFFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xA4B084", Offset = "0xA4B084", VA = "0xA4B084", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xA4B104", Offset = "0xA4B104", VA = "0xA4B104", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xA4B42C", Offset = "0xA4B42C", VA = "0xA4B42C")]
		private bool StartAction(Action action)
		{
			return default(bool);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xA4B670", Offset = "0xA4B670", VA = "0xA4B670")]
		public CharacterMeleeDemo()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class CharacterPuppet : CharacterThirdPerson
	{
		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[Header("Puppet")]
		public PropRoot propRoot;

		[Token(Token = "0x17000078")]
		public BehaviourPuppet puppet
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0xA4B698", Offset = "0xA4B698", VA = "0xA4B698")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xA4B6A0", Offset = "0xA4B6A0", VA = "0xA4B6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xA4B090", Offset = "0xA4B090", VA = "0xA4B090", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xA4B87C", Offset = "0xA4B87C", VA = "0xA4B87C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xA4B9A8", Offset = "0xA4B9A8", VA = "0xA4B9A8", Slot = "9")]
		protected override void Rotate()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xA4C01C", Offset = "0xA4C01C", VA = "0xA4C01C", Slot = "10")]
		protected override bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xA4B67C", Offset = "0xA4B67C", VA = "0xA4B67C")]
		public CharacterPuppet()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class CreatePuppetInRuntime : MonoBehaviour
	{
		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Creating a Puppet from a ragdoll character prefab.")]
		public Transform ragdollPrefab;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("What will the Puppet be named?")]
		public string instanceName;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The layer to assign the character controller to. Collisions between this layer and the 'Ragdoll Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int characterControllerLayer;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("The layer to assign the PuppetMaster and all it's muscles to. Collisions between this layer and the 'Character Controller Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int ragdollLayer;

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xA4C278", Offset = "0xA4C278", VA = "0xA4C278")]
		private void Start()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xA4C3E4", Offset = "0xA4C3E4", VA = "0xA4C3E4")]
		public CreatePuppetInRuntime()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class CreateRagdollInRuntime : MonoBehaviour
	{
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The character prefab/FBX.")]
		public GameObject prefab;

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xA4C434", Offset = "0xA4C434", VA = "0xA4C434")]
		private void Start()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xA4C5C0", Offset = "0xA4C5C0", VA = "0xA4C5C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xA4C5C4", Offset = "0xA4C5C4", VA = "0xA4C5C4")]
		public CreateRagdollInRuntime()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class Destructor : MonoBehaviour
	{
		[Token(Token = "0x200010E")]
		[CompilerGenerated]
		private sealed class <Destruct>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Destructor <>4__this;

			[Token(Token = "0x17000079")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000597")]
				[Address(RVA = "0xA4C77C", Offset = "0xA4C77C", VA = "0xA4C77C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000599")]
				[Address(RVA = "0xA4C7C4", Offset = "0xA4C7C4", VA = "0xA4C7C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0xA4C654", Offset = "0xA4C654", VA = "0xA4C654")]
			[DebuggerHidden]
			public <Destruct>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0xA4C68C", Offset = "0xA4C68C", VA = "0xA4C68C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0xA4C690", Offset = "0xA4C690", VA = "0xA4C690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0xA4C784", Offset = "0xA4C784", VA = "0xA4C784", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xA4C5CC", Offset = "0xA4C5CC", VA = "0xA4C5CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xA4C5EC", Offset = "0xA4C5EC", VA = "0xA4C5EC")]
		[IteratorStateMachine(typeof(<Destruct>d__2))]
		private IEnumerator Destruct()
		{
			return null;
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xA4C67C", Offset = "0xA4C67C", VA = "0xA4C67C")]
		public Destructor()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class Dying : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class <FadeOutPinWeight>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x1700007B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A2")]
				[Address(RVA = "0xA4CC60", Offset = "0xA4CC60", VA = "0xA4CC60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0xA4CCA8", Offset = "0xA4CCA8", VA = "0xA4CCA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0xA4CAF8", Offset = "0xA4CAF8", VA = "0xA4CAF8")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xA4CBB4", Offset = "0xA4CBB4", VA = "0xA4CBB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xA4CBB8", Offset = "0xA4CBB8", VA = "0xA4CBB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xA4CC68", Offset = "0xA4CC68", VA = "0xA4CC68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000111")]
		[CompilerGenerated]
		private sealed class <FadeOutMuscleWeight>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0xA4CD5C", Offset = "0xA4CD5C", VA = "0xA4CD5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0xA4CDA4", Offset = "0xA4CDA4", VA = "0xA4CDA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xA4CB20", Offset = "0xA4CB20", VA = "0xA4CB20")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xA4CCB0", Offset = "0xA4CCB0", VA = "0xA4CCB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xA4CCB4", Offset = "0xA4CCB4", VA = "0xA4CCB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xA4CD64", Offset = "0xA4CD64", VA = "0xA4CD64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The speed of fading out PuppetMaster.pinWeight.")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The speed of fading out PuppetMaster.muscleWeight.")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The muscle weight to fade out to.")]
		public float deadMuscleWeight;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool isDead;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xA4C7CC", Offset = "0xA4C7CC", VA = "0xA4C7CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xA4C860", Offset = "0xA4C860", VA = "0xA4C860")]
		private void Update()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xA4CA28", Offset = "0xA4CA28", VA = "0xA4CA28")]
		[IteratorStateMachine(typeof(<FadeOutPinWeight>d__10))]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xA4CA90", Offset = "0xA4CA90", VA = "0xA4CA90")]
		[IteratorStateMachine(typeof(<FadeOutMuscleWeight>d__11))]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xA4CB48", Offset = "0xA4CB48", VA = "0xA4CB48")]
		public Dying()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[RequireComponent(typeof(ParticleSystem))]
	public class FXCollisionBlood : MonoBehaviour
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minCollisionImpulse;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int emission;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float emissionImpulseAdd;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxEmission;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem particles;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xA4CDAC", Offset = "0xA4CDAC", VA = "0xA4CDAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xA4CE98", Offset = "0xA4CE98", VA = "0xA4CE98")]
		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xA4CFE4", Offset = "0xA4CFE4", VA = "0xA4CFE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xA4D0E8", Offset = "0xA4D0E8", VA = "0xA4D0E8")]
		public FXCollisionBlood()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class Grab : MonoBehaviour
	{
		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The PuppetMaster this muscle belongs to.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Used for switching walk/run by default.")]
		public UserControlMelee userControl;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The layers we wish to grab (optimization).")]
		public int grabLayer;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool grabbed;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider c;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BehaviourPuppet otherPuppet;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider otherCollider;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float nextGrabTime;

		[Token(Token = "0x4000584")]
		private const float massMlp = 5f;

		[Token(Token = "0x4000585")]
		private const int solverIterationMlp = 10;

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xA4D108", Offset = "0xA4D108", VA = "0xA4D108")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xA4D184", Offset = "0xA4D184", VA = "0xA4D184")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xA4D518", Offset = "0xA4D518", VA = "0xA4D518")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xA4D634", Offset = "0xA4D634", VA = "0xA4D634")]
		public Grab()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class Killing : MonoBehaviour
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Settings for killing and freezing the puppet.")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xA4D63C", Offset = "0xA4D63C", VA = "0xA4D63C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xA4D700", Offset = "0xA4D700", VA = "0xA4D700")]
		public Killing()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[RequireComponent(typeof(PuppetMaster))]
	public class LayerSetup : MonoBehaviour
	{
		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the character controller gameobject (the one that has the capsule collider/CharacterController.")]
		[Header("References")]
		public Transform characterController;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Layers")]
		[Tooltip("The layer to assign the character controller to. Collisions between this layer and the 'Ragdoll Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int characterControllerLayer;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The layer to assign the PuppetMaster and all it's muscles to. Collisions between this layer and the 'Character Controller Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int ragdollLayer;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Layers that will be ignored by the character controller")]
		public LayerMask ignoreCollisionWithCharacterController;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Layers that will not collide with the Ragdoll layer.")]
		public LayerMask ignoreCollisionWithRagdoll;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PuppetMaster puppetMaster;

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xA4D748", Offset = "0xA4D748", VA = "0xA4D748")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xA4D938", Offset = "0xA4D938", VA = "0xA4D938")]
		public LayerSetup()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class Planet : MonoBehaviour
	{
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float mass;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody[] rigidbodies;

		[Token(Token = "0x4000590")]
		private const float G = 6.672E-11f;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xA4D940", Offset = "0xA4D940", VA = "0xA4D940")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xA4DA00", Offset = "0xA4DA00", VA = "0xA4DA00")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xA4DA80", Offset = "0xA4DA80", VA = "0xA4DA80")]
		private void ApplyGravity(Rigidbody r)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xA4DB88", Offset = "0xA4DB88", VA = "0xA4DB88")]
		public Planet()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class PropDemo : MonoBehaviour
	{
		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Prop you wish to pick up.")]
		public Prop prop;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The PropRoot of the left hand.")]
		public PropRoot propRootLeft;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The PropRoot of the right hand.")]
		public PropRoot propRootRight;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If true, the prop will be picked up when PuppetMaster initiates")]
		public bool pickUpOnStart;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool right;

		[Token(Token = "0x1700007F")]
		private PropRoot connectTo
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xA4DBD4", Offset = "0xA4DBD4", VA = "0xA4DBD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xA4DB98", Offset = "0xA4DB98", VA = "0xA4DB98")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xA4DBF0", Offset = "0xA4DBF0", VA = "0xA4DBF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xA4DCC8", Offset = "0xA4DCC8", VA = "0xA4DCC8")]
		public PropDemo()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class PropMelee : Prop
	{
		[Token(Token = "0x2000119")]
		[CompilerGenerated]
		private sealed class <Action>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropMelee <>4__this;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <additionalPinMuscleIndex>5__2;

			[Token(Token = "0x17000080")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C8")]
				[Address(RVA = "0xA4E130", Offset = "0xA4E130", VA = "0xA4E130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0xA4E178", Offset = "0xA4E178", VA = "0xA4E178", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xA4DD50", Offset = "0xA4DD50", VA = "0xA4DD50")]
			[DebuggerHidden]
			public <Action>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xA4DF18", Offset = "0xA4DF18", VA = "0xA4DF18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xA4DF1C", Offset = "0xA4DF1C", VA = "0xA4DF1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xA4E138", Offset = "0xA4E138", VA = "0xA4E138", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Melee")]
		[Tooltip("Switch to a CapsuleCollider when the prop is picked up so it behaves more smoothly when colliding with objects.")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The default BoxCollider used when this prop is not picked up.")]
		public BoxCollider boxCollider;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("Temporarily increase the radius of the capsule collider when a hitting action is triggered, so it would not pass colliders too easily.")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		[Tooltip("Temporarily set (increase) the pin weight of the additional pin when a hitting action is triggered.")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0.1f, 10f)]
		[Tooltip("Temporarily increase the mass of the Rigidbody when a hitting action is triggered.")]
		public float actionMassMlp;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Tooltip("Offset to the default center of mass of the Rigidbody (might improve prop handling).")]
		public Vector3 COMOffset;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float defaultColliderRadius;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float defaultMass;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float defaultAddMass;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Rigidbody r;

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xA4B5A8", Offset = "0xA4B5A8", VA = "0xA4B5A8")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xA4DCD8", Offset = "0xA4DCD8", VA = "0xA4DCD8")]
		[IteratorStateMachine(typeof(<Action>d__11))]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xA4DD78", Offset = "0xA4DD78", VA = "0xA4DD78", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xA4DE28", Offset = "0xA4DE28", VA = "0xA4DE28", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xA4DE94", Offset = "0xA4DE94", VA = "0xA4DE94", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xA4DF00", Offset = "0xA4DF00", VA = "0xA4DF00")]
		public PropMelee()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class PropPickUpTrigger : MonoBehaviour
	{
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Prop prop;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask characterLayers;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharacterPuppet characterPuppet;

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xA4E180", Offset = "0xA4E180", VA = "0xA4E180")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xA4E2EC", Offset = "0xA4E2EC", VA = "0xA4E2EC")]
		public PropPickUpTrigger()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class PuppetBoard : MonoBehaviour
	{
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Board target Rigidbody.")]
		public Rigidbody target;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Pivot Transform of the body target.")]
		public Transform bodyTargetPivot;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The body target keeps the puppet upright by a SpringJoint connected to the body.")]
		public Transform bodyTarget;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xA4E2F4", Offset = "0xA4E2F4", VA = "0xA4E2F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xA4E394", Offset = "0xA4E394", VA = "0xA4E394")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xA4E57C", Offset = "0xA4E57C", VA = "0xA4E57C")]
		public PuppetBoard()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class PuppetScaling : MonoBehaviour
	{
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0.01f, 10f)]
		public float masterScale;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int muscleIndex;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0.01f, 10f)]
		public float muscleScale;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultMuscleSpring;

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xA4E584", Offset = "0xA4E584", VA = "0xA4E584")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xA4E5AC", Offset = "0xA4E5AC", VA = "0xA4E5AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xA4E95C", Offset = "0xA4E95C", VA = "0xA4E95C")]
		public PuppetScaling()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class RaycastShooter : MonoBehaviour
	{
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layers;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unpin;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float force;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem blood;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xA4E970", Offset = "0xA4E970", VA = "0xA4E970")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xA4EBBC", Offset = "0xA4EBBC", VA = "0xA4EBBC")]
		public RaycastShooter()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class Respawning : MonoBehaviour
	{
		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Pooled characters will be parented to this deactivated GameObject.")]
		public Transform pool;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the BehaviourPuppet component of the character you wish to respawn.")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The animation to play on respawn.")]
		public string idleAnimation;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform puppetRoot;

		[Token(Token = "0x17000082")]
		private bool isPooled
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xA4EBCC", Offset = "0xA4EBCC", VA = "0xA4EBCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xA4EC54", Offset = "0xA4EC54", VA = "0xA4EC54")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xA4ECA8", Offset = "0xA4ECA8", VA = "0xA4ECA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xA4EDCC", Offset = "0xA4EDCC", VA = "0xA4EDCC")]
		private void Pool()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xA4EDF0", Offset = "0xA4EDF0", VA = "0xA4EDF0")]
		private void Respawn(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xA4EED0", Offset = "0xA4EED0", VA = "0xA4EED0")]
		public Respawning()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class RotateShoulderToTarget : MonoBehaviour
	{
		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform shoulder;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 euler;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xA4EED8", Offset = "0xA4EED8", VA = "0xA4EED8")]
		private void OnPuppetMasterRead()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xA4EFC8", Offset = "0xA4EFC8", VA = "0xA4EFC8")]
		public RotateShoulderToTarget()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class SkeletonShooter : MonoBehaviour
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MuscleRemoveMode removeMuscleMode;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float unpin;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem particles;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xA4EFD0", Offset = "0xA4EFD0", VA = "0xA4EFD0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xA4F354", Offset = "0xA4F354", VA = "0xA4F354")]
		public SkeletonShooter()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class UserControlAIMelee : UserControlThirdPerson
	{
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourPuppet targetPuppet;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isAttacking;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float attackTimer;

		[Token(Token = "0x17000083")]
		private Transform moveTarget
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0xA4F364", Offset = "0xA4F364", VA = "0xA4F364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xA4F3AC", Offset = "0xA4F3AC", VA = "0xA4F3AC", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xA4F690", Offset = "0xA4F690", VA = "0xA4F690")]
		private bool CanAttack()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xA4F7D4", Offset = "0xA4F7D4", VA = "0xA4F7D4")]
		public UserControlAIMelee()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class UserControlMelee : UserControlThirdPerson
	{
		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KeyCode hitKey;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xA4F7F0", Offset = "0xA4F7F0", VA = "0xA4F7F0", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xA4F818", Offset = "0xA4F818", VA = "0xA4F818")]
		public UserControlMelee()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000084")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xA4F848", Offset = "0xA4F848", VA = "0xA4F848", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xA4F828", Offset = "0xA4F828", VA = "0xA4F828", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xA4F850", Offset = "0xA4F850", VA = "0xA4F850")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xA4F8B0", Offset = "0xA4F8B0", VA = "0xA4F8B0", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xA4FB1C", Offset = "0xA4FB1C", VA = "0xA4FB1C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xA4FD60", Offset = "0xA4FD60", VA = "0xA4FD60", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xA4FB2C", Offset = "0xA4FB2C", VA = "0xA4FB2C")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xA4FD70", Offset = "0xA4FD70", VA = "0xA4FD70")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xA4FD88", Offset = "0xA4FD88", VA = "0xA4FD88", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xA4FDE0", Offset = "0xA4FDE0", VA = "0xA4FDE0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xA4FE70", Offset = "0xA4FE70", VA = "0xA4FE70")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xA4FF94", Offset = "0xA4FF94", VA = "0xA4FF94")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40005D8")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40005D9")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x17000085")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xA50044", Offset = "0xA50044", VA = "0xA50044", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xA4FFAC", Offset = "0xA4FFAC", VA = "0xA4FFAC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xA50028", Offset = "0xA50028", VA = "0xA50028", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xA4AC68", Offset = "0xA4AC68", VA = "0xA4AC68", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xA50138", Offset = "0xA50138", VA = "0xA50138")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xA4B060", Offset = "0xA4B060", VA = "0xA4B060")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000126")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		protected float gravityMultiplier;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40005E5")]
		protected const float half = 0.5f;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60005F7")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xA50260", Offset = "0xA50260", VA = "0xA50260")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xA5044C", Offset = "0xA5044C", VA = "0xA5044C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xA505FC", Offset = "0xA505FC", VA = "0xA505FC", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xA5079C", Offset = "0xA5079C", VA = "0xA5079C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xA507FC", Offset = "0xA507FC", VA = "0xA507FC")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xA50960", Offset = "0xA50960", VA = "0xA50960")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xA50B64", Offset = "0xA50B64", VA = "0xA50B64")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xA50B88", Offset = "0xA50B88", VA = "0xA50B88")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xA50BAC", Offset = "0xA50BAC", VA = "0xA50BAC")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xA50CF8", Offset = "0xA50CF8", VA = "0xA50CF8")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000128")]
		public enum MoveMode
		{
			[Token(Token = "0x400061D")]
			Directional,
			[Token(Token = "0x400061E")]
			Strafe
		}

		[Token(Token = "0x2000129")]
		public struct AnimState
		{
			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public float airSpeed;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Header("Wall Running")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x17000086")]
		public bool onGround
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0xA50D18", Offset = "0xA50D18", VA = "0xA50D18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xA50D20", Offset = "0xA50D20", VA = "0xA50D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xA4B6A8", Offset = "0xA4B6A8", VA = "0xA4B6A8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xA50D2C", Offset = "0xA50D2C", VA = "0xA50D2C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xA4B8F8", Offset = "0xA4B8F8", VA = "0xA4B8F8", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xA50DB0", Offset = "0xA50DB0", VA = "0xA50DB0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xA4B5E4", Offset = "0xA4B5E4", VA = "0xA4B5E4", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xA52148", Offset = "0xA52148", VA = "0xA52148", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xA51388", Offset = "0xA51388", VA = "0xA51388")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xA52220", Offset = "0xA52220", VA = "0xA52220")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xA528AC", Offset = "0xA528AC", VA = "0xA528AC")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xA51D60", Offset = "0xA51D60", VA = "0xA51D60")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xA4BB9C", Offset = "0xA4BB9C", VA = "0xA4BB9C", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xA5299C", Offset = "0xA5299C", VA = "0xA5299C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xA4C048", Offset = "0xA4C048", VA = "0xA4C048", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xA51800", Offset = "0xA51800", VA = "0xA51800")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xA4C178", Offset = "0xA4C178", VA = "0xA4C178")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012B")]
		public enum RotationMode
		{
			[Token(Token = "0x4000633")]
			Smooth,
			[Token(Token = "0x4000634")]
			Linear
		}

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Acceleration of movement.")]
		private float accelerationTime;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Turning speed.")]
		private float turnTime;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		private bool walkByDefault;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		private float moveSpeed;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000087")]
		public bool isGrounded
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0xA52AC4", Offset = "0xA52AC4", VA = "0xA52AC4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000614")]
			[Address(RVA = "0xA52ACC", Offset = "0xA52ACC", VA = "0xA52ACC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xA52AD8", Offset = "0xA52AD8", VA = "0xA52AD8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xA52B6C", Offset = "0xA52B6C", VA = "0xA52B6C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xA53184", Offset = "0xA53184", VA = "0xA53184")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xA52BB4", Offset = "0xA52BB4", VA = "0xA52BB4")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xA52F1C", Offset = "0xA52F1C", VA = "0xA52F1C")]
		private void Move()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xA531B4", Offset = "0xA531B4", VA = "0xA531B4")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xA5324C", Offset = "0xA5324C", VA = "0xA5324C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xA532CC", Offset = "0xA532CC", VA = "0xA532CC")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xA532F4", Offset = "0xA532F4", VA = "0xA532F4", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xA534B0", Offset = "0xA534B0", VA = "0xA534B0")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200012E")]
		public struct State
		{
			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xA534CC", Offset = "0xA534CC", VA = "0xA534CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xA4906C", Offset = "0xA4906C", VA = "0xA4906C", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xA4959C", Offset = "0xA4959C", VA = "0xA4959C")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000622")]
		[Address(RVA = "0xA534F8", Offset = "0xA534F8", VA = "0xA534F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xA53530", Offset = "0xA53530", VA = "0xA53530")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xA53538", Offset = "0xA53538", VA = "0xA53538")]
		private void Update()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xA53560", Offset = "0xA53560", VA = "0xA53560")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xA53604", Offset = "0xA53604", VA = "0xA53604")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000131")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xA53618", Offset = "0xA53618", VA = "0xA53618")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xA5365C", Offset = "0xA5365C", VA = "0xA5365C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xA536A0", Offset = "0xA536A0", VA = "0xA536A0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xA536E4", Offset = "0xA536E4", VA = "0xA536E4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xA53728", Offset = "0xA53728", VA = "0xA53728")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xA537C0", Offset = "0xA537C0", VA = "0xA537C0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xA537DC", Offset = "0xA537DC", VA = "0xA537DC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xA53808", Offset = "0xA53808", VA = "0xA53808")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xA53834", Offset = "0xA53834", VA = "0xA53834")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xA53870", Offset = "0xA53870", VA = "0xA53870")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xA538B0", Offset = "0xA538B0", VA = "0xA538B0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xA538D0", Offset = "0xA538D0", VA = "0xA538D0")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xA538F0", Offset = "0xA538F0", VA = "0xA538F0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xA53914", Offset = "0xA53914", VA = "0xA53914")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xA5393C", Offset = "0xA5393C", VA = "0xA5393C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xA53964", Offset = "0xA53964", VA = "0xA53964")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xA53744", Offset = "0xA53744", VA = "0xA53744")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xA53988", Offset = "0xA53988", VA = "0xA53988")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xA53994", Offset = "0xA53994", VA = "0xA53994")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xA539A0", Offset = "0xA539A0", VA = "0xA539A0")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xA53C0C", Offset = "0xA53C0C", VA = "0xA53C0C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xA53CA8", Offset = "0xA53CA8", VA = "0xA53CA8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xA53FD0", Offset = "0xA53FD0", VA = "0xA53FD0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xA5443C", Offset = "0xA5443C", VA = "0xA5443C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xA54464", Offset = "0xA54464", VA = "0xA54464")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000132")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000088")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0xA53ADC", Offset = "0xA53ADC", VA = "0xA53ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0xA54684", Offset = "0xA54684", VA = "0xA54684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xA53E60", Offset = "0xA53E60", VA = "0xA53E60")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xA544F8", Offset = "0xA544F8", VA = "0xA544F8")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000133")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700008A")]
		public bool isValid
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xA54840", Offset = "0xA54840", VA = "0xA54840")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000645")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xA548A0", Offset = "0xA548A0", VA = "0xA548A0")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000134")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xA548A8", Offset = "0xA548A8", VA = "0xA548A8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xA54940", Offset = "0xA54940", VA = "0xA54940")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xA54948", Offset = "0xA54948", VA = "0xA54948")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000135")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700008B")]
		private bool positionChanged
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0xA54A74", Offset = "0xA54A74", VA = "0xA54A74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xA54970", Offset = "0xA54970", VA = "0xA54970", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xA54AD0", Offset = "0xA54AD0", VA = "0xA54AD0")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xA54AD8", Offset = "0xA54AD8", VA = "0xA54AD8")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000136")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xA54B00", Offset = "0xA54B00", VA = "0xA54B00", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xA54B7C", Offset = "0xA54B7C", VA = "0xA54B7C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xA54B84", Offset = "0xA54B84", VA = "0xA54B84")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000137")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700008C")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0xA54CB0", Offset = "0xA54CB0", VA = "0xA54CB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xA54BAC", Offset = "0xA54BAC", VA = "0xA54BAC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xA54D08", Offset = "0xA54D08", VA = "0xA54D08")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xA54D10", Offset = "0xA54D10", VA = "0xA54D10")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000138")]
	public class Constraints
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xA54D38", Offset = "0xA54D38", VA = "0xA54D38")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xA53F80", Offset = "0xA53F80", VA = "0xA53F80")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xA54144", Offset = "0xA54144", VA = "0xA54144")]
		public void Update()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xA54838", Offset = "0xA54838", VA = "0xA54838")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000139")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200013A")]
		public enum DOF
		{
			[Token(Token = "0x4000678")]
			One,
			[Token(Token = "0x4000679")]
			Three
		}

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x1700008D")]
		public bool initiated
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0xA54D98", Offset = "0xA54D98", VA = "0xA54D98")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600065A")]
			[Address(RVA = "0xA54DA0", Offset = "0xA54DA0", VA = "0xA54DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0xA54DAC", Offset = "0xA54DAC", VA = "0xA54DAC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600065C")]
			[Address(RVA = "0xA54DCC", Offset = "0xA54DCC", VA = "0xA54DCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0xA54DEC", Offset = "0xA54DEC", VA = "0xA54DEC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600065E")]
			[Address(RVA = "0xA54E0C", Offset = "0xA54E0C", VA = "0xA54E0C")]
			set
			{
			}
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xA54E2C", Offset = "0xA54E2C", VA = "0xA54E2C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xA54F18", Offset = "0xA54F18", VA = "0xA54F18")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xA552B4", Offset = "0xA552B4", VA = "0xA552B4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xA55374", Offset = "0xA55374", VA = "0xA55374")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xA55718", Offset = "0xA55718", VA = "0xA55718")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000090")]
		public bool initiated
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0xA55728", Offset = "0xA55728", VA = "0xA55728")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xA55730", Offset = "0xA55730", VA = "0xA55730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xA5573C", Offset = "0xA5573C", VA = "0xA5573C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xA557B0", Offset = "0xA557B0", VA = "0xA557B0")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xA55ABC", Offset = "0xA55ABC", VA = "0xA55ABC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xA55C28", Offset = "0xA55C28", VA = "0xA55C28")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xA559D4", Offset = "0xA559D4", VA = "0xA559D4")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xA55D8C", Offset = "0xA55D8C", VA = "0xA55D8C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xA55E34", Offset = "0xA55E34", VA = "0xA55E34")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xA55EA4", Offset = "0xA55EA4", VA = "0xA55EA4")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xA55F00", Offset = "0xA55F00", VA = "0xA55F00", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xA55F04", Offset = "0xA55F04", VA = "0xA55F04", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xA55F08", Offset = "0xA55F08", VA = "0xA55F08")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200013D")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		public float weight;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x6000671")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xA55F68", Offset = "0xA55F68", VA = "0xA55F68")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xA56218", Offset = "0xA56218", VA = "0xA56218")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xA5602C", Offset = "0xA5602C", VA = "0xA5602C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xA56240", Offset = "0xA56240", VA = "0xA56240")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000676")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000677")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xA563B4", Offset = "0xA563B4", VA = "0xA563B4")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xA56520", Offset = "0xA56520", VA = "0xA56520", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xA56564", Offset = "0xA56564", VA = "0xA56564", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xA565A8", Offset = "0xA565A8", VA = "0xA565A8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xA56614", Offset = "0xA56614", VA = "0xA56614")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xA566B4", Offset = "0xA566B4", VA = "0xA566B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xA56708", Offset = "0xA56708", VA = "0xA56708")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xA56A0C", Offset = "0xA56A0C", VA = "0xA56A0C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xA56A4C", Offset = "0xA56A4C", VA = "0xA56A4C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xA56EAC", Offset = "0xA56EAC", VA = "0xA56EAC")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xA56F6C", Offset = "0xA56F6C", VA = "0xA56F6C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xA5713C", Offset = "0xA5713C", VA = "0xA5713C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xA572E4", Offset = "0xA572E4", VA = "0xA572E4")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000140")]
		public class SpineEffector
		{
			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x6000697")]
			[Address(RVA = "0xA57F88", Offset = "0xA57F88", VA = "0xA57F88")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0xA57F98", Offset = "0xA57F98", VA = "0xA57F98")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xA57370", Offset = "0xA57370", VA = "0xA57370")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xA573B4", Offset = "0xA573B4", VA = "0xA573B4", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xA573F8", Offset = "0xA573F8", VA = "0xA573F8", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xA5743C", Offset = "0xA5743C", VA = "0xA5743C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xA574A8", Offset = "0xA574A8", VA = "0xA574A8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xA57530", Offset = "0xA57530", VA = "0xA57530")]
		private void Update()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xA577A4", Offset = "0xA577A4", VA = "0xA577A4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xA577B0", Offset = "0xA577B0", VA = "0xA577B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xA5758C", Offset = "0xA5758C", VA = "0xA5758C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xA577BC", Offset = "0xA577BC", VA = "0xA577BC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xA57B30", Offset = "0xA57B30", VA = "0xA57B30")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xA57CB4", Offset = "0xA57CB4", VA = "0xA57CB4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xA57DE8", Offset = "0xA57DE8", VA = "0xA57DE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xA57EFC", Offset = "0xA57EFC", VA = "0xA57EFC")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000141")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xA57FDC", Offset = "0xA57FDC", VA = "0xA57FDC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xA58020", Offset = "0xA58020", VA = "0xA58020", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xA58064", Offset = "0xA58064", VA = "0xA58064", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xA58080", Offset = "0xA58080", VA = "0xA58080")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xA582A0", Offset = "0xA582A0", VA = "0xA582A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xA58380", Offset = "0xA58380", VA = "0xA58380")]
		private void Update()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xA58834", Offset = "0xA58834", VA = "0xA58834")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xA58C70", Offset = "0xA58C70", VA = "0xA58C70")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xA58E20", Offset = "0xA58E20", VA = "0xA58E20")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xA591A8", Offset = "0xA591A8", VA = "0xA591A8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xA5937C", Offset = "0xA5937C", VA = "0xA5937C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xA59580", Offset = "0xA59580", VA = "0xA59580")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000142")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000143")]
		public struct Foot
		{
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xA5C4E4", Offset = "0xA5C4E4", VA = "0xA5C4E4")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		public float maxRootRotation;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xA5960C", Offset = "0xA5960C", VA = "0xA5960C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xA59650", Offset = "0xA59650", VA = "0xA59650", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xA59694", Offset = "0xA59694", VA = "0xA59694", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xA596C4", Offset = "0xA596C4", VA = "0xA596C4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xA597C8", Offset = "0xA597C8", VA = "0xA597C8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xA599C0", Offset = "0xA599C0", VA = "0xA599C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xA59A24", Offset = "0xA59A24", VA = "0xA59A24")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xA59A7C", Offset = "0xA59A7C", VA = "0xA59A7C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xA59D70", Offset = "0xA59D70", VA = "0xA59D70")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xA5A0C8", Offset = "0xA5A0C8", VA = "0xA5A0C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xA5A158", Offset = "0xA5A158", VA = "0xA5A158")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xA5A458", Offset = "0xA5A458", VA = "0xA5A458")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xA5AB20", Offset = "0xA5AB20", VA = "0xA5AB20")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xA5ADD8", Offset = "0xA5ADD8", VA = "0xA5ADD8")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xA5AF0C", Offset = "0xA5AF0C", VA = "0xA5AF0C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xA5B1D4", Offset = "0xA5B1D4", VA = "0xA5B1D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xA5B204", Offset = "0xA5B204", VA = "0xA5B204")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xA5B400", Offset = "0xA5B400", VA = "0xA5B400")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xA5C518", Offset = "0xA5C518", VA = "0xA5C518")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xA5C51C", Offset = "0xA5C51C", VA = "0xA5C51C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xA5C520", Offset = "0xA5C520", VA = "0xA5C520", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xA5C524", Offset = "0xA5C524", VA = "0xA5C524", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xA5C5B4", Offset = "0xA5C5B4", VA = "0xA5C5B4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xA5C63C", Offset = "0xA5C63C", VA = "0xA5C63C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xA5C690", Offset = "0xA5C690", VA = "0xA5C690")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xA5CB3C", Offset = "0xA5CB3C", VA = "0xA5CB3C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xA5CF24", Offset = "0xA5CF24", VA = "0xA5CF24")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xA5CFA8", Offset = "0xA5CFA8", VA = "0xA5CFA8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xA5D244", Offset = "0xA5D244", VA = "0xA5D244")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xA5D378", Offset = "0xA5D378", VA = "0xA5D378")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xA5D510", Offset = "0xA5D510", VA = "0xA5D510")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000145")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000146")]
		public enum Quality
		{
			[Token(Token = "0x40006DC")]
			Fastest,
			[Token(Token = "0x40006DD")]
			Simple,
			[Token(Token = "0x40006DE")]
			Best
		}

		[Token(Token = "0x2000147")]
		public class Leg
		{
			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x17000099")]
			public bool isGrounded
			{
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0xA5EA70", Offset = "0xA5EA70", VA = "0xA5EA70")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0xA5EA78", Offset = "0xA5EA78", VA = "0xA5EA78")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0xA5EA84", Offset = "0xA5EA84", VA = "0xA5EA84")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0xA5EA90", Offset = "0xA5EA90", VA = "0xA5EA90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public bool initiated
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0xA5EA9C", Offset = "0xA5EA9C", VA = "0xA5EA9C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0xA5EAA4", Offset = "0xA5EAA4", VA = "0xA5EAA4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009C")]
			public float heightFromGround
			{
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0xA5EAB0", Offset = "0xA5EAB0", VA = "0xA5EAB0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0xA5EAB8", Offset = "0xA5EAB8", VA = "0xA5EAB8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public Vector3 velocity
			{
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0xA5EAC0", Offset = "0xA5EAC0", VA = "0xA5EAC0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E6")]
				[Address(RVA = "0xA5EACC", Offset = "0xA5EACC", VA = "0xA5EACC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public Transform transform
			{
				[Token(Token = "0x60006E7")]
				[Address(RVA = "0xA5EAD8", Offset = "0xA5EAD8", VA = "0xA5EAD8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0xA5EAE0", Offset = "0xA5EAE0", VA = "0xA5EAE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public float IKOffset
			{
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0xA5EAE8", Offset = "0xA5EAE8", VA = "0xA5EAE8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0xA5EAF0", Offset = "0xA5EAF0", VA = "0xA5EAF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0xA5F0B4", Offset = "0xA5F0B4", VA = "0xA5F0B4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A1")]
			private float rootYOffset
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0xA5F228", Offset = "0xA5F228", VA = "0xA5F228")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xA5DA88", Offset = "0xA5DA88", VA = "0xA5DA88")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xA5EAF8", Offset = "0xA5EAF8", VA = "0xA5EAF8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xA5E698", Offset = "0xA5E698", VA = "0xA5E698")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xA5DB78", Offset = "0xA5DB78", VA = "0xA5DB78")]
			public void Process()
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0xA5EE34", Offset = "0xA5EE34", VA = "0xA5EE34")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0xA5EB38", Offset = "0xA5EB38", VA = "0xA5EB38")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0xA5F148", Offset = "0xA5F148", VA = "0xA5F148")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0xA5EC98", Offset = "0xA5EC98", VA = "0xA5EC98")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xA5ED18", Offset = "0xA5ED18", VA = "0xA5ED18")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xA5F1B4", Offset = "0xA5F1B4", VA = "0xA5F1B4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0xA5F0E8", Offset = "0xA5F0E8", VA = "0xA5F0E8")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xA5F2CC", Offset = "0xA5F2CC", VA = "0xA5F2CC")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xA5D9E8", Offset = "0xA5D9E8", VA = "0xA5D9E8")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000148")]
		public class Pelvis
		{
			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000A2")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0xA5F47C", Offset = "0xA5F47C", VA = "0xA5F47C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0xA5F488", Offset = "0xA5F488", VA = "0xA5F488")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			public float heightOffset
			{
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0xA5F494", Offset = "0xA5F494", VA = "0xA5F494")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006FD")]
				[Address(RVA = "0xA5F49C", Offset = "0xA5F49C", VA = "0xA5F49C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xA5DB50", Offset = "0xA5DB50", VA = "0xA5DB50")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xA5E604", Offset = "0xA5E604", VA = "0xA5E604")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0xA5F4A4", Offset = "0xA5F4A4", VA = "0xA5F4A4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0xA5E2A0", Offset = "0xA5E2A0", VA = "0xA5E2A0")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0xA5DA80", Offset = "0xA5DA80", VA = "0xA5DA80")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000091")]
		public Leg[] legs
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xA5D568", Offset = "0xA5D568", VA = "0xA5D568")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xA5D570", Offset = "0xA5D570", VA = "0xA5D570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xA5D578", Offset = "0xA5D578", VA = "0xA5D578")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xA5D580", Offset = "0xA5D580", VA = "0xA5D580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool isGrounded
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xA5D588", Offset = "0xA5D588", VA = "0xA5D588")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xA5D590", Offset = "0xA5D590", VA = "0xA5D590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public Transform root
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0xA5D59C", Offset = "0xA5D59C", VA = "0xA5D59C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xA5D5A4", Offset = "0xA5D5A4", VA = "0xA5D5A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xA5D5AC", Offset = "0xA5D5AC", VA = "0xA5D5AC")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0xA5D5C4", Offset = "0xA5D5C4", VA = "0xA5D5C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool rootGrounded
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0xA5D5E4", Offset = "0xA5D5E4", VA = "0xA5D5E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public Vector3 up
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xA5D884", Offset = "0xA5D884", VA = "0xA5D884")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000098")]
		private bool useRootRotation
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xA5E72C", Offset = "0xA5E72C", VA = "0xA5E72C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xA5D62C", Offset = "0xA5D62C", VA = "0xA5D62C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xA5D8EC", Offset = "0xA5D8EC", VA = "0xA5D8EC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xA5C8C8", Offset = "0xA5C8C8", VA = "0xA5C8C8")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xA5CD30", Offset = "0xA5CD30", VA = "0xA5CD30")]
		public void Update()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xA5E48C", Offset = "0xA5E48C", VA = "0xA5E48C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xA5C53C", Offset = "0xA5C53C", VA = "0xA5C53C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xA5DB60", Offset = "0xA5DB60", VA = "0xA5DB60")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xA5E7E0", Offset = "0xA5E7E0", VA = "0xA5E7E0")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xA5E864", Offset = "0xA5E864", VA = "0xA5E864")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xA5E9B8", Offset = "0xA5E9B8", VA = "0xA5E9B8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xA5EA28", Offset = "0xA5EA28", VA = "0xA5EA28")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000149")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xA5F4F8", Offset = "0xA5F4F8", VA = "0xA5F4F8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xA5F53C", Offset = "0xA5F53C", VA = "0xA5F53C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xA5F580", Offset = "0xA5F580", VA = "0xA5F580")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xA5F5C4", Offset = "0xA5F5C4", VA = "0xA5F5C4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xA5F608", Offset = "0xA5F608", VA = "0xA5F608")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xA5F64C", Offset = "0xA5F64C", VA = "0xA5F64C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xA5F654", Offset = "0xA5F654", VA = "0xA5F654")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xA5F6C4", Offset = "0xA5F6C4", VA = "0xA5F6C4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xA5F708", Offset = "0xA5F708", VA = "0xA5F708", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xA5F74C", Offset = "0xA5F74C", VA = "0xA5F74C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xA5F790", Offset = "0xA5F790", VA = "0xA5F790")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xA5F7D4", Offset = "0xA5F7D4", VA = "0xA5F7D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xA5F7DC", Offset = "0xA5F7DC", VA = "0xA5F7DC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200014B")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xA5F844", Offset = "0xA5F844", VA = "0xA5F844", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xA5F888", Offset = "0xA5F888", VA = "0xA5F888", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xA5F8CC", Offset = "0xA5F8CC", VA = "0xA5F8CC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xA5F910", Offset = "0xA5F910", VA = "0xA5F910")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xA5F954", Offset = "0xA5F954", VA = "0xA5F954", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xA5F95C", Offset = "0xA5F95C", VA = "0xA5F95C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xA5F9C4", Offset = "0xA5F9C4", VA = "0xA5F9C4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xA5FA08", Offset = "0xA5FA08", VA = "0xA5FA08", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xA5FA4C", Offset = "0xA5FA4C", VA = "0xA5FA4C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xA5FA90", Offset = "0xA5FA90", VA = "0xA5FA90")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xA5FAD4", Offset = "0xA5FAD4", VA = "0xA5FAD4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xA5FADC", Offset = "0xA5FADC", VA = "0xA5FADC")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xA5FB44", Offset = "0xA5FB44", VA = "0xA5FB44", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xA5FB88", Offset = "0xA5FB88", VA = "0xA5FB88", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xA5FBCC", Offset = "0xA5FBCC", VA = "0xA5FBCC")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xA5FC10", Offset = "0xA5FC10", VA = "0xA5FC10")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xA5FC54", Offset = "0xA5FC54", VA = "0xA5FC54")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xA5FC98", Offset = "0xA5FC98", VA = "0xA5FC98")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xA5FCDC", Offset = "0xA5FCDC", VA = "0xA5FCDC")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xA5FD00", Offset = "0xA5FD00", VA = "0xA5FD00", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xA5FD08", Offset = "0xA5FD08", VA = "0xA5FD08")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xA5FEC4", Offset = "0xA5FEC4", VA = "0xA5FEC4")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xA60374", Offset = "0xA60374", VA = "0xA60374")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xA60394", Offset = "0xA60394", VA = "0xA60394")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xA6046C", Offset = "0xA6046C", VA = "0xA6046C")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000729")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xA60504", Offset = "0xA60504", VA = "0xA60504", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xA6057C", Offset = "0xA6057C", VA = "0xA6057C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xA605EC", Offset = "0xA605EC", VA = "0xA605EC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600072D")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600072E")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xA5F6BC", Offset = "0xA5F6BC", VA = "0xA5F6BC")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x170000A4")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0xA6063C", Offset = "0xA6063C", VA = "0xA6063C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xA606C8", Offset = "0xA606C8", VA = "0xA606C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xA6072C", Offset = "0xA6072C", VA = "0xA6072C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xA607CC", Offset = "0xA607CC", VA = "0xA607CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xA607F8", Offset = "0xA607F8", VA = "0xA607F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xA60750", Offset = "0xA60750", VA = "0xA60750")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xA6087C", Offset = "0xA6087C", VA = "0xA6087C")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000150")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xA60884", Offset = "0xA60884", VA = "0xA60884", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xA608EC", Offset = "0xA608EC", VA = "0xA608EC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xA60954", Offset = "0xA60954", VA = "0xA60954")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xA60998", Offset = "0xA60998", VA = "0xA60998")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xA609DC", Offset = "0xA609DC", VA = "0xA609DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xA609E4", Offset = "0xA609E4", VA = "0xA609E4")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000151")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xA60A4C", Offset = "0xA60A4C", VA = "0xA60A4C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xA60A90", Offset = "0xA60A90", VA = "0xA60A90", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xA60AD4", Offset = "0xA60AD4", VA = "0xA60AD4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xA60B18", Offset = "0xA60B18", VA = "0xA60B18")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xA60B5C", Offset = "0xA60B5C", VA = "0xA60B5C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xA60B64", Offset = "0xA60B64", VA = "0xA60B64")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page8.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xA60BCC", Offset = "0xA60BCC", VA = "0xA60BCC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xA60C10", Offset = "0xA60C10", VA = "0xA60C10", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xA60C54", Offset = "0xA60C54", VA = "0xA60C54")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xA60C98", Offset = "0xA60C98", VA = "0xA60C98")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xA60CDC", Offset = "0xA60CDC", VA = "0xA60CDC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xA60CE4", Offset = "0xA60CE4", VA = "0xA60CE4")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000153")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xA60D4C", Offset = "0xA60D4C", VA = "0xA60D4C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xA60D90", Offset = "0xA60D90", VA = "0xA60D90", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xA60DD4", Offset = "0xA60DD4", VA = "0xA60DD4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xA60E18", Offset = "0xA60E18", VA = "0xA60E18")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xA60E5C", Offset = "0xA60E5C", VA = "0xA60E5C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xA60E64", Offset = "0xA60E64", VA = "0xA60E64")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000155")]
		public class References
		{
			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x170000A5")]
			public bool isFilled
			{
				[Token(Token = "0x6000758")]
				[Address(RVA = "0xA617E0", Offset = "0xA617E0", VA = "0xA617E0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A6")]
			public bool isEmpty
			{
				[Token(Token = "0x6000759")]
				[Address(RVA = "0xA61424", Offset = "0xA61424", VA = "0xA61424")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0xA61B4C", Offset = "0xA61B4C", VA = "0xA61B4C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0xA60FFC", Offset = "0xA60FFC", VA = "0xA60FFC")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xA61B44", Offset = "0xA61B44", VA = "0xA61B44")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xA60ECC", Offset = "0xA60ECC", VA = "0xA60ECC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xA60F34", Offset = "0xA60F34", VA = "0xA60F34", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xA60F9C", Offset = "0xA60F9C", VA = "0xA60F9C")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xA60FE0", Offset = "0xA60FE0", VA = "0xA60FE0")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xA61388", Offset = "0xA61388", VA = "0xA61388")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xA613B0", Offset = "0xA613B0", VA = "0xA613B0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xA613B8", Offset = "0xA613B8", VA = "0xA613B8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xA61AAC", Offset = "0xA61AAC", VA = "0xA61AAC")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000156")]
	public class FABRIKChain
	{
		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xA61F88", Offset = "0xA61F88", VA = "0xA61F88")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xA6204C", Offset = "0xA6204C", VA = "0xA6204C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xA6206C", Offset = "0xA6206C", VA = "0xA6206C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xA622C0", Offset = "0xA622C0", VA = "0xA622C0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xA6212C", Offset = "0xA6212C", VA = "0xA6212C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xA623A4", Offset = "0xA623A4", VA = "0xA623A4")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xA62404", Offset = "0xA62404", VA = "0xA62404")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xA628A0", Offset = "0xA628A0", VA = "0xA628A0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xA62A34", Offset = "0xA62A34", VA = "0xA62A34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xA62B40", Offset = "0xA62B40", VA = "0xA62B40")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000159")]
		public class BendBone
		{
			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000774")]
			[Address(RVA = "0xA65C98", Offset = "0xA65C98", VA = "0xA65C98")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0xA65CF8", Offset = "0xA65CF8", VA = "0xA65CF8")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0xA633A8", Offset = "0xA633A8", VA = "0xA633A8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0xA63778", Offset = "0xA63778", VA = "0xA63778")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[LargeHeader("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		[LargeHeader("CCD")]
		public float CCDWeight;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		public float postStretchWeight;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xA62B48", Offset = "0xA62B48", VA = "0xA62B48")]
		private void Start()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xA62F34", Offset = "0xA62F34", VA = "0xA62F34")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xA633D4", Offset = "0xA633D4", VA = "0xA633D4")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xA637A0", Offset = "0xA637A0", VA = "0xA637A0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xA6409C", Offset = "0xA6409C", VA = "0xA6409C")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xA64494", Offset = "0xA64494", VA = "0xA64494")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xA648A4", Offset = "0xA648A4", VA = "0xA648A4")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xA6521C", Offset = "0xA6521C", VA = "0xA6521C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xA63DE0", Offset = "0xA63DE0", VA = "0xA63DE0")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xA65458", Offset = "0xA65458", VA = "0xA65458")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xA6513C", Offset = "0xA6513C", VA = "0xA6513C")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xA6503C", Offset = "0xA6503C", VA = "0xA6503C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xA657B8", Offset = "0xA657B8", VA = "0xA657B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xA65AF0", Offset = "0xA65AF0", VA = "0xA65AF0")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015A")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200015B")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000A7")]
			public float nominalDistance
			{
				[Token(Token = "0x600078C")]
				[Address(RVA = "0xA68CA4", Offset = "0xA68CA4", VA = "0xA68CA4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600078D")]
				[Address(RVA = "0xA68CAC", Offset = "0xA68CAC", VA = "0xA68CAC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			public bool isRigid
			{
				[Token(Token = "0x600078E")]
				[Address(RVA = "0xA68CB4", Offset = "0xA68CB4", VA = "0xA68CB4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600078F")]
				[Address(RVA = "0xA68CBC", Offset = "0xA68CBC", VA = "0xA68CBC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0xA68CC8", Offset = "0xA68CC8", VA = "0xA68CC8")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0xA669B8", Offset = "0xA669B8", VA = "0xA669B8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xA6705C", Offset = "0xA6705C", VA = "0xA6705C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0xA68A68", Offset = "0xA68A68", VA = "0xA68A68")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015C")]
		public enum Smoothing
		{
			[Token(Token = "0x400077B")]
			None,
			[Token(Token = "0x400077C")]
			Exponential,
			[Token(Token = "0x400077D")]
			Cubic
		}

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400076F")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xA65D74", Offset = "0xA65D74", VA = "0xA65D74")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xA65EDC", Offset = "0xA65EDC", VA = "0xA65EDC")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xA66010", Offset = "0xA66010", VA = "0xA66010")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xA66128", Offset = "0xA66128", VA = "0xA66128")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xA661E4", Offset = "0xA661E4", VA = "0xA661E4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xA662F0", Offset = "0xA662F0", VA = "0xA662F0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xA66C78", Offset = "0xA66C78", VA = "0xA66C78")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xA6645C", Offset = "0xA6645C", VA = "0xA6645C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xA67240", Offset = "0xA67240", VA = "0xA67240")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xA674D4", Offset = "0xA674D4", VA = "0xA674D4")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xA677A4", Offset = "0xA677A4", VA = "0xA677A4")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xA6816C", Offset = "0xA6816C", VA = "0xA6816C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xA68664", Offset = "0xA68664", VA = "0xA68664")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xA68864", Offset = "0xA68864", VA = "0xA68864")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xA68550", Offset = "0xA68550", VA = "0xA68550")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xA6800C", Offset = "0xA6800C", VA = "0xA6800C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xA684EC", Offset = "0xA684EC", VA = "0xA684EC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xA68940", Offset = "0xA68940", VA = "0xA68940")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xA68418", Offset = "0xA68418", VA = "0xA68418")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xA68768", Offset = "0xA68768", VA = "0xA68768")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015D")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x170000A9")]
		public bool initiated
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0xA68EE0", Offset = "0xA68EE0", VA = "0xA68EE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000796")]
			[Address(RVA = "0xA68EE8", Offset = "0xA68EE8", VA = "0xA68EE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xA68D08", Offset = "0xA68D08", VA = "0xA68D08")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xA65E70", Offset = "0xA65E70", VA = "0xA65E70")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xA68EF4", Offset = "0xA68EF4", VA = "0xA68EF4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xA66A0C", Offset = "0xA66A0C", VA = "0xA66A0C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xA66A18", Offset = "0xA66A18", VA = "0xA66A18")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xA690C8", Offset = "0xA690C8", VA = "0xA690C8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xA69414", Offset = "0xA69414", VA = "0xA69414")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xA679DC", Offset = "0xA679DC", VA = "0xA679DC")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xA68F80", Offset = "0xA68F80", VA = "0xA68F80")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xA69024", Offset = "0xA69024", VA = "0xA69024")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200015E")]
	public class IKEffector
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x170000AA")]
		public bool isEndEffector
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xA697DC", Offset = "0xA697DC", VA = "0xA697DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xA697E4", Offset = "0xA697E4", VA = "0xA697E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xA6575C", Offset = "0xA6575C", VA = "0xA6575C")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xA697F0", Offset = "0xA697F0", VA = "0xA697F0")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xA69874", Offset = "0xA69874", VA = "0xA69874")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xA69A14", Offset = "0xA69A14", VA = "0xA69A14")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xA69BD0", Offset = "0xA69BD0", VA = "0xA69BD0")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xA69EC4", Offset = "0xA69EC4", VA = "0xA69EC4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xA6A164", Offset = "0xA6A164", VA = "0xA6A164")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xA6A284", Offset = "0xA6A284", VA = "0xA6A284")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xA6A320", Offset = "0xA6A320", VA = "0xA6A320")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xA6A9D4", Offset = "0xA6A9D4", VA = "0xA6A9D4")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xA6AA2C", Offset = "0xA6AA2C", VA = "0xA6AA2C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xA6AC00", Offset = "0xA6AC00", VA = "0xA6AC00")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xA6AE5C", Offset = "0xA6AE5C", VA = "0xA6AE5C")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200015F")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000160")]
		public class BoneMap
		{
			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000AB")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60007B5")]
				[Address(RVA = "0xA6B3A8", Offset = "0xA6B3A8", VA = "0xA6B3A8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AC")]
			public bool isNodeBone
			{
				[Token(Token = "0x60007B8")]
				[Address(RVA = "0xA6B460", Offset = "0xA6B460", VA = "0xA6B460")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AD")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60007CC")]
				[Address(RVA = "0xA6B828", Offset = "0xA6B828", VA = "0xA6B828")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xA6B37C", Offset = "0xA6B37C", VA = "0xA6B37C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xA6B3D8", Offset = "0xA6B3D8", VA = "0xA6B3D8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0xA6B41C", Offset = "0xA6B41C", VA = "0xA6B41C")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xA6B470", Offset = "0xA6B470", VA = "0xA6B470")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xA6B544", Offset = "0xA6B544", VA = "0xA6B544")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xA6B54C", Offset = "0xA6B54C", VA = "0xA6B54C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xA6B618", Offset = "0xA6B618", VA = "0xA6B618")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xA6B684", Offset = "0xA6B684", VA = "0xA6B684")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0xA6B718", Offset = "0xA6B718", VA = "0xA6B718")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0xA6B990", Offset = "0xA6B990", VA = "0xA6B990")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xA6B9BC", Offset = "0xA6B9BC", VA = "0xA6B9BC")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0xA6B9E8", Offset = "0xA6B9E8", VA = "0xA6B9E8")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xA6BA10", Offset = "0xA6BA10", VA = "0xA6BA10")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0xA6BAD4", Offset = "0xA6BAD4", VA = "0xA6BAD4")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xA6BC68", Offset = "0xA6BC68", VA = "0xA6BC68")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0xA6BC8C", Offset = "0xA6BC8C", VA = "0xA6BC8C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xA6BDAC", Offset = "0xA6BDAC", VA = "0xA6BDAC")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0xA6BE10", Offset = "0xA6BE10", VA = "0xA6BE10")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0xA6BF90", Offset = "0xA6BF90", VA = "0xA6BF90")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xA6C110", Offset = "0xA6C110", VA = "0xA6C110")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xA6C18C", Offset = "0xA6C18C", VA = "0xA6C18C")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xA6BB4C", Offset = "0xA6BB4C", VA = "0xA6BB4C")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0xA6C2B4", Offset = "0xA6C2B4", VA = "0xA6C2B4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xA6B118", Offset = "0xA6B118", VA = "0xA6B118", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xA6B120", Offset = "0xA6B120", VA = "0xA6B120", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xA6B124", Offset = "0xA6B124", VA = "0xA6B124")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xA6B260", Offset = "0xA6B260", VA = "0xA6B260")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xA6B374", Offset = "0xA6B374", VA = "0xA6B374")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000161")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xA6C2D0", Offset = "0xA6C2D0", VA = "0xA6C2D0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xA6C36C", Offset = "0xA6C36C", VA = "0xA6C36C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xA6C3F0", Offset = "0xA6C3F0", VA = "0xA6C3F0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xA6C488", Offset = "0xA6C488", VA = "0xA6C488")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xA6C4A0", Offset = "0xA6C4A0", VA = "0xA6C4A0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xA6C4BC", Offset = "0xA6C4BC", VA = "0xA6C4BC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xA6C548", Offset = "0xA6C548", VA = "0xA6C548")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xA6C560", Offset = "0xA6C560", VA = "0xA6C560")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000162")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000163")]
		public enum BoneMapType
		{
			[Token(Token = "0x40007D3")]
			Parent,
			[Token(Token = "0x40007D4")]
			Bone1,
			[Token(Token = "0x40007D5")]
			Bone2,
			[Token(Token = "0x40007D6")]
			Bone3
		}

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xA6C584", Offset = "0xA6C584", VA = "0xA6C584", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xA6C5F8", Offset = "0xA6C5F8", VA = "0xA6C5F8")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xA6C6C0", Offset = "0xA6C6C0", VA = "0xA6C6C0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xA6C978", Offset = "0xA6C978", VA = "0xA6C978")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xA6CA8C", Offset = "0xA6CA8C", VA = "0xA6CA8C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xA6CBCC", Offset = "0xA6CBCC", VA = "0xA6CBCC")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xA6CBD8", Offset = "0xA6CBD8", VA = "0xA6CBD8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xA6CC70", Offset = "0xA6CC70", VA = "0xA6CC70")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xA6CD18", Offset = "0xA6CD18", VA = "0xA6CD18", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xA6CF74", Offset = "0xA6CF74", VA = "0xA6CF74")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xA6CFD4", Offset = "0xA6CFD4", VA = "0xA6CFD4")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000164")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xA6D11C", Offset = "0xA6D11C", VA = "0xA6D11C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xA6D43C", Offset = "0xA6D43C", VA = "0xA6D43C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xA6D578", Offset = "0xA6D578", VA = "0xA6D578")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xA6D6E8", Offset = "0xA6D6E8", VA = "0xA6D6E8")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xA6D6F8", Offset = "0xA6D6F8", VA = "0xA6D6F8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xA6D754", Offset = "0xA6D754", VA = "0xA6D754")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xA6D7CC", Offset = "0xA6D7CC", VA = "0xA6D7CC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xA6DDE0", Offset = "0xA6DDE0", VA = "0xA6DDE0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xA6DE18", Offset = "0xA6DE18", VA = "0xA6DE18")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xA6E07C", Offset = "0xA6E07C", VA = "0xA6E07C")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xA6E3A4", Offset = "0xA6E3A4", VA = "0xA6E3A4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xA6E484", Offset = "0xA6E484", VA = "0xA6E484")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xA6E538", Offset = "0xA6E538", VA = "0xA6E538")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000165")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000166")]
		public class Point
		{
			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0xA6FE08", Offset = "0xA6FE08", VA = "0xA6FE08")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0xA6FE4C", Offset = "0xA6FE4C", VA = "0xA6FE4C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0xA6FF2C", Offset = "0xA6FF2C", VA = "0xA6FF2C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0xA6FF58", Offset = "0xA6FF58", VA = "0xA6FF58")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0xA6FF84", Offset = "0xA6FF84", VA = "0xA6FF84")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0xA6FFC8", Offset = "0xA6FFC8", VA = "0xA6FFC8")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0xA7000C", Offset = "0xA7000C", VA = "0xA7000C")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000167")]
		public class Bone : Point
		{
			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000AF")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600080B")]
				[Address(RVA = "0xA7006C", Offset = "0xA7006C", VA = "0xA7006C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600080C")]
				[Address(RVA = "0xA7014C", Offset = "0xA7014C", VA = "0xA7014C")]
				set
				{
				}
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0xA701C4", Offset = "0xA701C4", VA = "0xA701C4")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0xA70430", Offset = "0xA70430", VA = "0xA70430")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0xA706EC", Offset = "0xA706EC", VA = "0xA706EC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0xA708E0", Offset = "0xA708E0", VA = "0xA708E0")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0xA70908", Offset = "0xA70908", VA = "0xA70908")]
			public Bone()
			{
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0xA70974", Offset = "0xA70974", VA = "0xA70974")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0xA709EC", Offset = "0xA709EC", VA = "0xA709EC")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000168")]
		public class Node : Point
		{
			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000814")]
			[Address(RVA = "0xA70A74", Offset = "0xA70A74", VA = "0xA70A74")]
			public Node()
			{
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0xA70A78", Offset = "0xA70A78", VA = "0xA70A78")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0xA70A9C", Offset = "0xA70A9C", VA = "0xA70A9C")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000169")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200016A")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x170000AE")]
		public bool initiated
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0xA6FA14", Offset = "0xA6FA14", VA = "0xA6FA14")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0xA6FA1C", Offset = "0xA6FA1C", VA = "0xA6FA1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xA6F77C", Offset = "0xA6F77C", VA = "0xA6F77C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60007EF")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xA6F7F0", Offset = "0xA6F7F0", VA = "0xA6F7F0")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xA6F960", Offset = "0xA6F960", VA = "0xA6F960")]
		public void Update()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xA6F9D0", Offset = "0xA6F9D0", VA = "0xA6F9D0", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xA6F9DC", Offset = "0xA6F9DC", VA = "0xA6F9DC")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xA6F9E8", Offset = "0xA6F9E8", VA = "0xA6F9E8")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xA6F9F0", Offset = "0xA6F9F0", VA = "0xA6F9F0")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xA6FA0C", Offset = "0xA6FA0C", VA = "0xA6FA0C")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60007F9")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60007FA")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60007FB")]
		public abstract void FixTransforms();

		[Token(Token = "0x60007FC")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60007FD")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60007FE")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xA6FA28", Offset = "0xA6FA28", VA = "0xA6FA28")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xA6FA40", Offset = "0xA6FA40", VA = "0xA6FA40")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xA6FB64", Offset = "0xA6FB64", VA = "0xA6FB64")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xA6FBFC", Offset = "0xA6FBFC", VA = "0xA6FBFC")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xA6FDF0", Offset = "0xA6FDF0", VA = "0xA6FDF0")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016B")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x170000B0")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0xA70E6C", Offset = "0xA70E6C", VA = "0xA70E6C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B1")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0xA70E9C", Offset = "0xA70E9C", VA = "0xA70E9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B2")]
		protected override int minBones
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0xA71AD0", Offset = "0xA71AD0", VA = "0xA71AD0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B3")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0xA72010", Offset = "0xA72010", VA = "0xA72010", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xA70D34", Offset = "0xA70D34", VA = "0xA70D34")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xA70ECC", Offset = "0xA70ECC", VA = "0xA70ECC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xA71158", Offset = "0xA71158", VA = "0xA71158", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xA71A28", Offset = "0xA71A28", VA = "0xA71A28")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xA716C4", Offset = "0xA716C4", VA = "0xA716C4")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xA71AD8", Offset = "0xA71AD8", VA = "0xA71AD8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xA72070", Offset = "0xA72070", VA = "0xA72070")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016C")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xA72184", Offset = "0xA72184", VA = "0xA72184")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xA721F4", Offset = "0xA721F4", VA = "0xA721F4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xA726E8", Offset = "0xA726E8", VA = "0xA726E8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xA72DBC", Offset = "0xA72DBC", VA = "0xA72DBC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xA7344C", Offset = "0xA7344C", VA = "0xA7344C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016D")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x170000B4")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0xA74418", Offset = "0xA74418", VA = "0xA74418", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xA73450", Offset = "0xA73450", VA = "0xA73450")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xA73A30", Offset = "0xA73A30", VA = "0xA73A30")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xA73B60", Offset = "0xA73B60", VA = "0xA73B60", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xA73BE8", Offset = "0xA73BE8", VA = "0xA73BE8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xA740E0", Offset = "0xA740E0", VA = "0xA740E0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xA74420", Offset = "0xA74420", VA = "0xA74420")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xA73528", Offset = "0xA73528", VA = "0xA73528")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xA73B18", Offset = "0xA73B18", VA = "0xA73B18")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xA743D0", Offset = "0xA743D0", VA = "0xA743D0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xA738C4", Offset = "0xA738C4", VA = "0xA738C4")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xA74ACC", Offset = "0xA74ACC", VA = "0xA74ACC")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xA74B34", Offset = "0xA74B34", VA = "0xA74B34")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xA74C04", Offset = "0xA74C04", VA = "0xA74C04")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xA74CCC", Offset = "0xA74CCC", VA = "0xA74CCC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xA73E58", Offset = "0xA73E58", VA = "0xA73E58")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xA73F9C", Offset = "0xA73F9C", VA = "0xA73F9C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xA74DBC", Offset = "0xA74DBC", VA = "0xA74DBC")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xA746BC", Offset = "0xA746BC", VA = "0xA746BC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xA73B08", Offset = "0xA73B08", VA = "0xA73B08")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xA7542C", Offset = "0xA7542C", VA = "0xA7542C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xA74F7C", Offset = "0xA74F7C", VA = "0xA74F7C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xA7453C", Offset = "0xA7453C", VA = "0xA7453C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xA7460C", Offset = "0xA7460C", VA = "0xA7460C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xA754E4", Offset = "0xA754E4", VA = "0xA754E4")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016E")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xA75564", Offset = "0xA75564", VA = "0xA75564", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xA75BB8", Offset = "0xA75BB8", VA = "0xA75BB8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xA75C44", Offset = "0xA75C44", VA = "0xA75C44", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xA75CD8", Offset = "0xA75CD8", VA = "0xA75CD8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xA75DC0", Offset = "0xA75DC0", VA = "0xA75DC0")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xA75E50", Offset = "0xA75E50", VA = "0xA75E50", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xA76250", Offset = "0xA76250", VA = "0xA76250", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xA76428", Offset = "0xA76428", VA = "0xA76428", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xA762F0", Offset = "0xA762F0", VA = "0xA762F0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xA76028", Offset = "0xA76028", VA = "0xA76028")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xA764AC", Offset = "0xA764AC", VA = "0xA764AC")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016F")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xA7651C", Offset = "0xA7651C", VA = "0xA7651C")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xA765F8", Offset = "0xA765F8", VA = "0xA765F8")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xA76640", Offset = "0xA76640", VA = "0xA76640")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xA76754", Offset = "0xA76754", VA = "0xA76754")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xA767A4", Offset = "0xA767A4", VA = "0xA767A4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xA76818", Offset = "0xA76818", VA = "0xA76818", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xA76990", Offset = "0xA76990", VA = "0xA76990", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xA76AEC", Offset = "0xA76AEC", VA = "0xA76AEC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xA76CEC", Offset = "0xA76CEC", VA = "0xA76CEC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xA76DC0", Offset = "0xA76DC0", VA = "0xA76DC0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xA76EA8", Offset = "0xA76EA8", VA = "0xA76EA8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xA77008", Offset = "0xA77008", VA = "0xA77008", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xA771A4", Offset = "0xA771A4", VA = "0xA771A4", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xA773DC", Offset = "0xA773DC", VA = "0xA773DC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xA776BC", Offset = "0xA776BC", VA = "0xA776BC", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xA776F4", Offset = "0xA776F4", VA = "0xA776F4", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xA777D8", Offset = "0xA777D8", VA = "0xA777D8")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000170")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000824")]
		Body,
		[Token(Token = "0x4000825")]
		LeftShoulder,
		[Token(Token = "0x4000826")]
		RightShoulder,
		[Token(Token = "0x4000827")]
		LeftThigh,
		[Token(Token = "0x4000828")]
		RightThigh,
		[Token(Token = "0x4000829")]
		LeftHand,
		[Token(Token = "0x400082A")]
		RightHand,
		[Token(Token = "0x400082B")]
		LeftFoot,
		[Token(Token = "0x400082C")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000171")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400082E")]
		LeftArm,
		[Token(Token = "0x400082F")]
		RightArm,
		[Token(Token = "0x4000830")]
		LeftLeg,
		[Token(Token = "0x4000831")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000172")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x170000B5")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xA778F4", Offset = "0xA778F4", VA = "0xA778F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0xA77A34", Offset = "0xA77A34", VA = "0xA77A34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0xA77A3C", Offset = "0xA77A3C", VA = "0xA77A3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0xA77A44", Offset = "0xA77A44", VA = "0xA77A44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xA77A4C", Offset = "0xA77A4C", VA = "0xA77A4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0xA77A54", Offset = "0xA77A54", VA = "0xA77A54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0xA77A5C", Offset = "0xA77A5C", VA = "0xA77A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xA77A64", Offset = "0xA77A64", VA = "0xA77A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0xA77A6C", Offset = "0xA77A6C", VA = "0xA77A6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0xA77A74", Offset = "0xA77A74", VA = "0xA77A74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0xA77AA0", Offset = "0xA77AA0", VA = "0xA77AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0xA77ACC", Offset = "0xA77ACC", VA = "0xA77ACC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0xA77AF8", Offset = "0xA77AF8", VA = "0xA77AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0xA77B24", Offset = "0xA77B24", VA = "0xA77B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0xA77B4C", Offset = "0xA77B4C", VA = "0xA77B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0xA77B78", Offset = "0xA77B78", VA = "0xA77B78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0xA77BA4", Offset = "0xA77BA4", VA = "0xA77BA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0xA77BD0", Offset = "0xA77BD0", VA = "0xA77BD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0xA799BC", Offset = "0xA799BC", VA = "0xA799BC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000886")]
			[Address(RVA = "0xA799C8", Offset = "0xA799C8", VA = "0xA799C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xA77BF8", Offset = "0xA77BF8", VA = "0xA77BF8")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xA77CF8", Offset = "0xA77CF8", VA = "0xA77CF8")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xA77C48", Offset = "0xA77C48", VA = "0xA77C48")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xA77D70", Offset = "0xA77D70", VA = "0xA77D70")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xA778FC", Offset = "0xA778FC", VA = "0xA778FC")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xA77E38", Offset = "0xA77E38", VA = "0xA77E38")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xA77EE8", Offset = "0xA77EE8", VA = "0xA77EE8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xA77F94", Offset = "0xA77F94", VA = "0xA77F94")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xA78040", Offset = "0xA78040", VA = "0xA78040")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xA78048", Offset = "0xA78048", VA = "0xA78048")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xA78070", Offset = "0xA78070", VA = "0xA78070")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xA78130", Offset = "0xA78130", VA = "0xA78130", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xA782C0", Offset = "0xA782C0", VA = "0xA782C0")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xA792B4", Offset = "0xA792B4", VA = "0xA792B4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xA79864", Offset = "0xA79864", VA = "0xA79864")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xA798C0", Offset = "0xA798C0", VA = "0xA798C0")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xA79704", Offset = "0xA79704", VA = "0xA79704")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xA797B4", Offset = "0xA797B4", VA = "0xA797B4")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xA799D4", Offset = "0xA799D4", VA = "0xA799D4")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xA79A98", Offset = "0xA79A98", VA = "0xA79A98", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xA79B68", Offset = "0xA79B68", VA = "0xA79B68")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xA79C84", Offset = "0xA79C84", VA = "0xA79C84")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xA79E14", Offset = "0xA79E14", VA = "0xA79E14")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xA79F8C", Offset = "0xA79F8C", VA = "0xA79F8C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xA7A1EC", Offset = "0xA7A1EC", VA = "0xA7A1EC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xA7A264", Offset = "0xA7A264", VA = "0xA7A264")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000173")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x170000C8")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xA7AA8C", Offset = "0xA7AA8C", VA = "0xA7AA8C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C9")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xA7AA94", Offset = "0xA7AA94", VA = "0xA7AA94", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xA7AA9C", Offset = "0xA7AA9C", VA = "0xA7AA9C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CB")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xA7AAAC", Offset = "0xA7AAAC", VA = "0xA7AAAC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000CC")]
		protected float positionOffset
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xA72D74", Offset = "0xA72D74", VA = "0xA72D74")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xA7A270", Offset = "0xA7A270", VA = "0xA7A270")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xA7A3EC", Offset = "0xA7A3EC", VA = "0xA7A3EC")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xA7A518", Offset = "0xA7A518", VA = "0xA7A518", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xA7A574", Offset = "0xA7A574", VA = "0xA7A574", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xA7A5E4", Offset = "0xA7A5E4", VA = "0xA7A5E4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xA7A9A8", Offset = "0xA7A9A8", VA = "0xA7A9A8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xA7A9B0", Offset = "0xA7A9B0", VA = "0xA7A9B0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xA7AAA4", Offset = "0xA7AAA4", VA = "0xA7AAA4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xA7AAA8", Offset = "0xA7AAA8", VA = "0xA7AAA8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xA72260", Offset = "0xA72260", VA = "0xA72260")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xA729C8", Offset = "0xA729C8", VA = "0xA729C8")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xA7AB68", Offset = "0xA7AB68", VA = "0xA7AB68")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xA72110", Offset = "0xA72110", VA = "0xA72110")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000174")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xA7ADFC", Offset = "0xA7ADFC", VA = "0xA7ADFC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xA7B158", Offset = "0xA7B158", VA = "0xA7B158")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xA7B1B8", Offset = "0xA7B1B8", VA = "0xA7B1B8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xA7B2FC", Offset = "0xA7B2FC", VA = "0xA7B2FC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xA7B45C", Offset = "0xA7B45C", VA = "0xA7B45C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xA7B49C", Offset = "0xA7B49C", VA = "0xA7B49C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xA7B4EC", Offset = "0xA7B4EC", VA = "0xA7B4EC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xA7B844", Offset = "0xA7B844", VA = "0xA7B844", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xA7B864", Offset = "0xA7B864", VA = "0xA7B864")]
		private void Solve()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xA7B544", Offset = "0xA7B544", VA = "0xA7B544")]
		private void Read()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xA7B8E8", Offset = "0xA7B8E8", VA = "0xA7B8E8")]
		private void Write()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xA7B9F4", Offset = "0xA7B9F4", VA = "0xA7B9F4")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000175")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000176")]
		public enum BendModifier
		{
			[Token(Token = "0x400085C")]
			Animation,
			[Token(Token = "0x400085D")]
			Target,
			[Token(Token = "0x400085E")]
			Parent,
			[Token(Token = "0x400085F")]
			Arm,
			[Token(Token = "0x4000860")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000177")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0xA7CF70", Offset = "0xA7CF70", VA = "0xA7CF70")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x170000CD")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0xA7CF54", Offset = "0xA7CF54", VA = "0xA7CF54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xA7BB88", Offset = "0xA7BB88", VA = "0xA7BB88")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xA7BBCC", Offset = "0xA7BBCC", VA = "0xA7BBCC")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xA7BC38", Offset = "0xA7BC38", VA = "0xA7BC38", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xA7C178", Offset = "0xA7C178", VA = "0xA7C178", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xA7CC98", Offset = "0xA7CC98", VA = "0xA7CC98", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xA7CD40", Offset = "0xA7CD40", VA = "0xA7CD40")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xA7CED4", Offset = "0xA7CED4", VA = "0xA7CED4")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xA7BF8C", Offset = "0xA7BF8C", VA = "0xA7BF8C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xA7C234", Offset = "0xA7C234", VA = "0xA7C234")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000178")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000179")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000D4")]
			public Vector3 forward
			{
				[Token(Token = "0x60008D9")]
				[Address(RVA = "0xA7EAA8", Offset = "0xA7EAA8", VA = "0xA7EAA8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0xA7F10C", Offset = "0xA7F10C", VA = "0xA7F10C")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xA7DE54", Offset = "0xA7DE54", VA = "0xA7DE54")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0xA7E100", Offset = "0xA7E100", VA = "0xA7E100")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0xA7EDF0", Offset = "0xA7EDF0", VA = "0xA7EDF0")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x170000CE")]
		private bool spineIsValid
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xA7D670", Offset = "0xA7D670", VA = "0xA7D670")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xA7D818", Offset = "0xA7D818", VA = "0xA7D818")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D0")]
		private bool headIsValid
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xA7D73C", Offset = "0xA7D73C", VA = "0xA7D73C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D1")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xA7D83C", Offset = "0xA7D83C", VA = "0xA7D83C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D2")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xA7D74C", Offset = "0xA7D74C", VA = "0xA7D74C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D3")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xA7D8A8", Offset = "0xA7D8A8", VA = "0xA7D8A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xA7D10C", Offset = "0xA7D10C", VA = "0xA7D10C")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xA7D128", Offset = "0xA7D128", VA = "0xA7D128")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xA7D154", Offset = "0xA7D154", VA = "0xA7D154")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xA7D18C", Offset = "0xA7D18C", VA = "0xA7D18C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xA7D1D4", Offset = "0xA7D1D4", VA = "0xA7D1D4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xA7D22C", Offset = "0xA7D22C", VA = "0xA7D22C")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xA7D29C", Offset = "0xA7D29C", VA = "0xA7D29C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xA7D3A8", Offset = "0xA7D3A8", VA = "0xA7D3A8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xA7D4C8", Offset = "0xA7D4C8", VA = "0xA7D4C8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xA7D8CC", Offset = "0xA7D8CC", VA = "0xA7D8CC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xA7DAE4", Offset = "0xA7DAE4", VA = "0xA7DAE4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xA7DC44", Offset = "0xA7DC44", VA = "0xA7DC44")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xA7DE78", Offset = "0xA7DE78", VA = "0xA7DE78", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xA7E1EC", Offset = "0xA7E1EC", VA = "0xA7E1EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xA7E2B0", Offset = "0xA7E2B0", VA = "0xA7E2B0")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xA7E4CC", Offset = "0xA7E4CC", VA = "0xA7E4CC")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xA7E814", Offset = "0xA7E814", VA = "0xA7E814")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xA7EAD8", Offset = "0xA7EAD8", VA = "0xA7EAD8")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xA7DCEC", Offset = "0xA7DCEC", VA = "0xA7DCEC")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xA7EEF8", Offset = "0xA7EEF8", VA = "0xA7EEF8")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200017A")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200017B")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xA80390", Offset = "0xA80390", VA = "0xA80390")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xA80C30", Offset = "0xA80C30", VA = "0xA80C30")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xA7BC08", Offset = "0xA7BC08", VA = "0xA7BC08")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xA80CCC", Offset = "0xA80CCC", VA = "0xA80CCC")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xA7F110", Offset = "0xA7F110", VA = "0xA7F110")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xA7F2A4", Offset = "0xA7F2A4", VA = "0xA7F2A4")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xA7F424", Offset = "0xA7F424", VA = "0xA7F424")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xA7F430", Offset = "0xA7F430", VA = "0xA7F430")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xA7F44C", Offset = "0xA7F44C", VA = "0xA7F44C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xA7F458", Offset = "0xA7F458", VA = "0xA7F458")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xA7F460", Offset = "0xA7F460", VA = "0xA7F460", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xA7F54C", Offset = "0xA7F54C", VA = "0xA7F54C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xA7F644", Offset = "0xA7F644", VA = "0xA7F644", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xA7F678", Offset = "0xA7F678", VA = "0xA7F678", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xA7F6BC", Offset = "0xA7F6BC", VA = "0xA7F6BC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xA7FA60", Offset = "0xA7FA60", VA = "0xA7FA60")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xA7FAA8", Offset = "0xA7FAA8", VA = "0xA7FAA8")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xA7FF9C", Offset = "0xA7FF9C", VA = "0xA7FF9C")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xA800F4", Offset = "0xA800F4", VA = "0xA800F4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xA802A0", Offset = "0xA802A0", VA = "0xA802A0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xA80220", Offset = "0xA80220", VA = "0xA80220")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xA80480", Offset = "0xA80480", VA = "0xA80480", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xA80CC0", Offset = "0xA80CC0", VA = "0xA80CC0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xA80CC4", Offset = "0xA80CC4", VA = "0xA80CC4", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xA80CC8", Offset = "0xA80CC8", VA = "0xA80CC8", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xA80A7C", Offset = "0xA80A7C", VA = "0xA80A7C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xA7CDAC", Offset = "0xA7CDAC", VA = "0xA7CDAC")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200017C")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200017D")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200017E")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40008BC")]
				YawPitch,
				[Token(Token = "0x40008BD")]
				FromTo
			}

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target")]
			public Transform target;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the hand target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the arm shorter/longer.")]
			public float armLengthMlp;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length).")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40008B9")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40008BA")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000D6")]
			public Vector3 position
			{
				[Token(Token = "0x6000913")]
				[Address(RVA = "0xA88730", Offset = "0xA88730", VA = "0xA88730")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000914")]
				[Address(RVA = "0xA8873C", Offset = "0xA8873C", VA = "0xA8873C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000D7")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000915")]
				[Address(RVA = "0xA88748", Offset = "0xA88748", VA = "0xA88748")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000916")]
				[Address(RVA = "0xA88754", Offset = "0xA88754", VA = "0xA88754")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000917")]
				[Address(RVA = "0xA88760", Offset = "0xA88760", VA = "0xA88760")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000918")]
				[Address(RVA = "0xA88788", Offset = "0xA88788", VA = "0xA88788")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000919")]
				[Address(RVA = "0xA887B4", Offset = "0xA887B4", VA = "0xA887B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private VirtualBone hand
			{
				[Token(Token = "0x600091A")]
				[Address(RVA = "0xA887E0", Offset = "0xA887E0", VA = "0xA887E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0xA8880C", Offset = "0xA8880C", VA = "0xA8880C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0xA88F38", Offset = "0xA88F38", VA = "0xA88F38", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0xA891E4", Offset = "0xA891E4", VA = "0xA891E4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0xA89208", Offset = "0xA89208", VA = "0xA89208")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0xA866F4", Offset = "0xA866F4", VA = "0xA866F4")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0xA8A1A4", Offset = "0xA8A1A4", VA = "0xA8A1A4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0xA8A1FC", Offset = "0xA8A1FC", VA = "0xA8A1FC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0xA89558", Offset = "0xA89558", VA = "0xA89558")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0xA89760", Offset = "0xA89760", VA = "0xA89760")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0xA8A408", Offset = "0xA8A408", VA = "0xA8A408")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0xA88484", Offset = "0xA88484", VA = "0xA88484")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200017F")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000DC")]
			public float sqrMag
			{
				[Token(Token = "0x600092B")]
				[Address(RVA = "0xA8A5B8", Offset = "0xA8A5B8", VA = "0xA8A5B8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600092C")]
				[Address(RVA = "0xA8A5C0", Offset = "0xA8A5C0", VA = "0xA8A5C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000DD")]
			public float mag
			{
				[Token(Token = "0x600092D")]
				[Address(RVA = "0xA8A5C8", Offset = "0xA8A5C8", VA = "0xA8A5C8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600092E")]
				[Address(RVA = "0xA8A5D0", Offset = "0xA8A5D0", VA = "0xA8A5D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000926")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x6000927")]
			public abstract void PreSolve();

			[Token(Token = "0x6000928")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000929")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600092A")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600092F")]
			[Address(RVA = "0xA845E0", Offset = "0xA845E0", VA = "0xA845E0")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0xA8A738", Offset = "0xA8A738", VA = "0xA8A738")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0xA8A7C0", Offset = "0xA8A7C0", VA = "0xA8A7C0")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0xA8A9C4", Offset = "0xA8A9C4", VA = "0xA8A9C4")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0xA86288", Offset = "0xA86288", VA = "0xA86288")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0xA8A040", Offset = "0xA8A040", VA = "0xA8A040")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0xA8AA0C", Offset = "0xA8AA0C", VA = "0xA8AA0C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0xA8AB30", Offset = "0xA8AB30", VA = "0xA8AB30")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0xA8A520", Offset = "0xA8A520", VA = "0xA8A520")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000180")]
		public class Footstep
		{
			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000DE")]
			public bool isStepping
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0xA8AB44", Offset = "0xA8AB44", VA = "0xA8AB44")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DF")]
			public float stepProgress
			{
				[Token(Token = "0x6000939")]
				[Address(RVA = "0xA8AB58", Offset = "0xA8AB58", VA = "0xA8AB58")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600093A")]
				[Address(RVA = "0xA8AB60", Offset = "0xA8AB60", VA = "0xA8AB60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0xA8AB68", Offset = "0xA8AB68", VA = "0xA8AB68")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0xA8AC68", Offset = "0xA8AC68", VA = "0xA8AC68")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0xA8AD44", Offset = "0xA8AD44", VA = "0xA8AD44")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0xA8ADF4", Offset = "0xA8ADF4", VA = "0xA8ADF4")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0xA8AFFC", Offset = "0xA8AFFC", VA = "0xA8AFFC")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0xA8B1E0", Offset = "0xA8B1E0", VA = "0xA8B1E0")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000181")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The toe/foot target.")]
			public Transform target;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the toe/foot target.")]
			public float positionWeight;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target.")]
			public float rotationWeight;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the knee bending direction.")]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x170000E0")]
			public Vector3 position
			{
				[Token(Token = "0x6000941")]
				[Address(RVA = "0xA8B354", Offset = "0xA8B354", VA = "0xA8B354")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000942")]
				[Address(RVA = "0xA8B360", Offset = "0xA8B360", VA = "0xA8B360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E1")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000943")]
				[Address(RVA = "0xA8B36C", Offset = "0xA8B36C", VA = "0xA8B36C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000944")]
				[Address(RVA = "0xA8B378", Offset = "0xA8B378", VA = "0xA8B378")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E2")]
			public bool hasToes
			{
				[Token(Token = "0x6000945")]
				[Address(RVA = "0xA8B384", Offset = "0xA8B384", VA = "0xA8B384")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000946")]
				[Address(RVA = "0xA8B38C", Offset = "0xA8B38C", VA = "0xA8B38C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E3")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000947")]
				[Address(RVA = "0xA8B398", Offset = "0xA8B398", VA = "0xA8B398")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000948")]
				[Address(RVA = "0xA8B3C0", Offset = "0xA8B3C0", VA = "0xA8B3C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000949")]
				[Address(RVA = "0xA8B3EC", Offset = "0xA8B3EC", VA = "0xA8B3EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			private VirtualBone toes
			{
				[Token(Token = "0x600094A")]
				[Address(RVA = "0xA8B418", Offset = "0xA8B418", VA = "0xA8B418")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E7")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600094B")]
				[Address(RVA = "0xA86164", Offset = "0xA86164", VA = "0xA86164")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600094C")]
				[Address(RVA = "0xA8B444", Offset = "0xA8B444", VA = "0xA8B444")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600094D")]
				[Address(RVA = "0xA8B450", Offset = "0xA8B450", VA = "0xA8B450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0xA8B45C", Offset = "0xA8B45C", VA = "0xA8B45C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600094F")]
			[Address(RVA = "0xA8B8F0", Offset = "0xA8B8F0", VA = "0xA8B8F0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0xA8BEC4", Offset = "0xA8BEC4", VA = "0xA8BEC4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0xA8BE74", Offset = "0xA8BE74", VA = "0xA8BE74")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0xA8BC38", Offset = "0xA8BC38", VA = "0xA8BC38")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0xA863AC", Offset = "0xA863AC", VA = "0xA863AC")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0xA8C390", Offset = "0xA8C390", VA = "0xA8C390", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0xA8C48C", Offset = "0xA8C48C", VA = "0xA8C48C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0xA885C8", Offset = "0xA885C8", VA = "0xA885C8")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000182")]
		public class Locomotion
		{
			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			public float weight;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Range(0.9f, 1f)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of steps.")]
			public float stepSpeed;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Range(0f, 180f)]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000E9")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0xA8C56C", Offset = "0xA8C56C", VA = "0xA8C56C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000958")]
				[Address(RVA = "0xA8C578", Offset = "0xA8C578", VA = "0xA8C578")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000EA")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600095E")]
				[Address(RVA = "0xA8C988", Offset = "0xA8C988", VA = "0xA8C988")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EB")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600095F")]
				[Address(RVA = "0xA8C9BC", Offset = "0xA8C9BC", VA = "0xA8C9BC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EC")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000960")]
				[Address(RVA = "0xA8C9F4", Offset = "0xA8C9F4", VA = "0xA8C9F4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000ED")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000961")]
				[Address(RVA = "0xA8CA28", Offset = "0xA8CA28", VA = "0xA8CA28")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0xA84690", Offset = "0xA84690", VA = "0xA84690")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0xA827FC", Offset = "0xA827FC", VA = "0xA827FC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600095B")]
			[Address(RVA = "0xA81D0C", Offset = "0xA81D0C", VA = "0xA81D0C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0xA81C54", Offset = "0xA81C54", VA = "0xA81C54")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0xA84E4C", Offset = "0xA84E4C", VA = "0xA84E4C")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0xA8C5B8", Offset = "0xA8C5B8", VA = "0xA8C5B8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0xA8C76C", Offset = "0xA8C76C", VA = "0xA8C76C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000964")]
			[Address(RVA = "0xA8C7D8", Offset = "0xA8C7D8", VA = "0xA8C7D8")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0xA88644", Offset = "0xA88644", VA = "0xA88644")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000183")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target.")]
			public Transform headTarget;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target, useful with seated rigs.")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the head target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the head target.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Positional weight of the pelvis target.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target.")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Rotational weight of the chest target.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			public float neckStiffness;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Clamps chest rotation.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Range(0f, 1f)]
			[Tooltip("Clamps head rotation.")]
			public float headClampWeight;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private int pelvisIndex;

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int spineIndex;

			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int chestIndex;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int neckIndex;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int headIndex;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private float length;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private bool hasChest;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
			private bool hasNeck;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private float headHeight;

			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float sizeMlp;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private Vector3 chestForward;

			[Token(Token = "0x170000EE")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000966")]
				[Address(RVA = "0xA829E0", Offset = "0xA829E0", VA = "0xA829E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000967")]
				[Address(RVA = "0xA8CA60", Offset = "0xA8CA60", VA = "0xA8CA60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000968")]
				[Address(RVA = "0xA866AC", Offset = "0xA866AC", VA = "0xA866AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000969")]
				[Address(RVA = "0xA8CA94", Offset = "0xA8CA94", VA = "0xA8CA94")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F2")]
			public VirtualBone head
			{
				[Token(Token = "0x600096A")]
				[Address(RVA = "0xA8C584", Offset = "0xA8C584", VA = "0xA8C584")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600096B")]
				[Address(RVA = "0xA8CAC8", Offset = "0xA8CAC8", VA = "0xA8CAC8")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600096C")]
				[Address(RVA = "0xA8CADC", Offset = "0xA8CADC", VA = "0xA8CADC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0xA8CAF0", Offset = "0xA8CAF0", VA = "0xA8CAF0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0xA8D6D4", Offset = "0xA8D6D4", VA = "0xA8D6D4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0xA8D880", Offset = "0xA8D880", VA = "0xA8D880", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0xA8DE80", Offset = "0xA8DE80", VA = "0xA8DE80")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0xA84984", Offset = "0xA84984", VA = "0xA84984")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0xA8E8AC", Offset = "0xA8E8AC", VA = "0xA8E8AC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0xA8EEB4", Offset = "0xA8EEB4", VA = "0xA8EEB4")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0xA8F4B8", Offset = "0xA8F4B8", VA = "0xA8F4B8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0xA8F688", Offset = "0xA8F688", VA = "0xA8F688", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0xA8E0C4", Offset = "0xA8E0C4", VA = "0xA8E0C4")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0xA86198", Offset = "0xA86198", VA = "0xA86198")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0xA8E4B4", Offset = "0xA8E4B4", VA = "0xA8E4B4")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xA8F758", Offset = "0xA8F758", VA = "0xA8F758")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0xA8ECB8", Offset = "0xA8ECB8", VA = "0xA8ECB8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0xA8EAA0", Offset = "0xA8EAA0", VA = "0xA8EAA0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0xA88378", Offset = "0xA88378", VA = "0xA88378")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000184")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000937")]
			Pelvis,
			[Token(Token = "0x4000938")]
			Chest,
			[Token(Token = "0x4000939")]
			Head,
			[Token(Token = "0x400093A")]
			LeftHand,
			[Token(Token = "0x400093B")]
			RightHand,
			[Token(Token = "0x400093C")]
			LeftFoot,
			[Token(Token = "0x400093D")]
			RightFoot,
			[Token(Token = "0x400093E")]
			LeftHeel,
			[Token(Token = "0x400093F")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000185")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000941")]
			Pelvis,
			[Token(Token = "0x4000942")]
			Chest,
			[Token(Token = "0x4000943")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000186")]
		public class VirtualBone
		{
			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600097D")]
			[Address(RVA = "0xA84550", Offset = "0xA84550", VA = "0xA84550")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0xA845C0", Offset = "0xA845C0", VA = "0xA845C0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0xA8F9F8", Offset = "0xA8F9F8", VA = "0xA8F9F8")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0xA8A5D8", Offset = "0xA8A5D8", VA = "0xA8A5D8")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0xA8A854", Offset = "0xA8A854", VA = "0xA8A854")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0xA8FBF8", Offset = "0xA8FBF8", VA = "0xA8FBF8")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0xA895D8", Offset = "0xA895D8", VA = "0xA895D8")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0xA8FDA0", Offset = "0xA8FDA0", VA = "0xA8FDA0")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0xA89C5C", Offset = "0xA89C5C", VA = "0xA89C5C")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0xA8FE44", Offset = "0xA8FE44", VA = "0xA8FE44")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0xA8F15C", Offset = "0xA8F15C", VA = "0xA8F15C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0xA8FF9C", Offset = "0xA8FF9C", VA = "0xA8FF9C")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0xA900B0", Offset = "0xA900B0", VA = "0xA900B0")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach.")]
		public bool plantFeet;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The procedural locomotion solver.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x170000D5")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0xA88144", Offset = "0xA88144", VA = "0xA88144")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600090F")]
			[Address(RVA = "0xA8814C", Offset = "0xA8814C", VA = "0xA8814C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xA80CD0", Offset = "0xA80CD0", VA = "0xA80CD0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xA810B0", Offset = "0xA810B0", VA = "0xA810B0")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xA80F64", Offset = "0xA80F64", VA = "0xA80F64")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xA818D8", Offset = "0xA818D8", VA = "0xA818D8")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xA81A1C", Offset = "0xA81A1C", VA = "0xA81A1C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xA81A5C", Offset = "0xA81A5C", VA = "0xA81A5C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xA81B80", Offset = "0xA81B80", VA = "0xA81B80")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xA820D4", Offset = "0xA820D4", VA = "0xA820D4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xA82A14", Offset = "0xA82A14", VA = "0xA82A14", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xA82B68", Offset = "0xA82B68", VA = "0xA82B68", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xA82CE0", Offset = "0xA82CE0", VA = "0xA82CE0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xA82D50", Offset = "0xA82D50", VA = "0xA82D50", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xA82DC0", Offset = "0xA82DC0", VA = "0xA82DC0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xA82FBC", Offset = "0xA82FBC", VA = "0xA82FBC")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xA81398", Offset = "0xA81398", VA = "0xA81398")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xA8147C", Offset = "0xA8147C", VA = "0xA8147C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xA817C4", Offset = "0xA817C4", VA = "0xA817C4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xA821CC", Offset = "0xA821CC", VA = "0xA821CC")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xA8322C", Offset = "0xA8322C", VA = "0xA8322C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xA83258", Offset = "0xA83258", VA = "0xA83258", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xA84318", Offset = "0xA84318", VA = "0xA84318")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xA8231C", Offset = "0xA8231C", VA = "0xA8231C")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xA832B0", Offset = "0xA832B0", VA = "0xA832B0")]
		private void Solve()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xA844DC", Offset = "0xA844DC", VA = "0xA844DC")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xA84518", Offset = "0xA84518", VA = "0xA84518")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xA841E4", Offset = "0xA841E4", VA = "0xA841E4")]
		private void Write()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xA87A78", Offset = "0xA87A78", VA = "0xA87A78")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xA88154", Offset = "0xA88154", VA = "0xA88154")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		[Range(0f, 1f)]
		public float parentChildCrossfade;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
		public float twistAngleOffset;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axis;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform parent;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform child;

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xA90264", Offset = "0xA90264", VA = "0xA90264")]
		public void Relax()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xA906A8", Offset = "0xA906A8", VA = "0xA906A8")]
		private void Start()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xA909F8", Offset = "0xA909F8", VA = "0xA909F8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xA90A70", Offset = "0xA90A70", VA = "0xA90A70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xA90AE8", Offset = "0xA90AE8", VA = "0xA90AE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0xA90C00", Offset = "0xA90C00", VA = "0xA90C00")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000188")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x170000F4")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0xA90CA0", Offset = "0xA90CA0", VA = "0xA90CA0")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000991")]
			[Address(RVA = "0xA90CA8", Offset = "0xA90CA8", VA = "0xA90CA8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public bool isPaused
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0xA90CB0", Offset = "0xA90CB0", VA = "0xA90CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000993")]
			[Address(RVA = "0xA90CB8", Offset = "0xA90CB8", VA = "0xA90CB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0xA90CC4", Offset = "0xA90CC4", VA = "0xA90CC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000995")]
			[Address(RVA = "0xA90CCC", Offset = "0xA90CCC", VA = "0xA90CCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public bool inInteraction
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0xA90CD4", Offset = "0xA90CD4", VA = "0xA90CD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F8")]
		public float progress
		{
			[Token(Token = "0x600099F")]
			[Address(RVA = "0xA924C8", Offset = "0xA924C8", VA = "0xA924C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xA90D34", Offset = "0xA90D34", VA = "0xA90D34")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xA90DC4", Offset = "0xA90DC4", VA = "0xA90DC4")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xA90E58", Offset = "0xA90E58", VA = "0xA90E58")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xA90F8C", Offset = "0xA90F8C", VA = "0xA90F8C")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xA912D0", Offset = "0xA912D0", VA = "0xA912D0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xA913F0", Offset = "0xA913F0", VA = "0xA913F0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xA91444", Offset = "0xA91444", VA = "0xA91444")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xA918E4", Offset = "0xA918E4", VA = "0xA918E4")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xA91F34", Offset = "0xA91F34", VA = "0xA91F34")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xA92158", Offset = "0xA92158", VA = "0xA92158")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xA9237C", Offset = "0xA9237C", VA = "0xA9237C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xA924F8", Offset = "0xA924F8", VA = "0xA924F8")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000189")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xA9273C", Offset = "0xA9273C", VA = "0xA9273C")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xA9284C", Offset = "0xA9284C", VA = "0xA9284C")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xA928E4", Offset = "0xA928E4", VA = "0xA928E4")]
		public void Update()
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xA92AD4", Offset = "0xA92AD4", VA = "0xA92AD4")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xA92B7C", Offset = "0xA92B7C", VA = "0xA92B7C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xA92C28", Offset = "0xA92C28", VA = "0xA92C28")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200018A")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200018B")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0xA941E0", Offset = "0xA941E0", VA = "0xA941E0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xA94478", Offset = "0xA94478", VA = "0xA94478")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018C")]
		public class Message
		{
			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x4000990")]
			private const string empty = "";

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0xA94380", Offset = "0xA94380", VA = "0xA94380")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0xA94480", Offset = "0xA94480", VA = "0xA94480")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018D")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000997")]
			private const string empty = "";

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0xA942A4", Offset = "0xA942A4", VA = "0xA942A4")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0xA94488", Offset = "0xA94488", VA = "0xA94488")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0xA94538", Offset = "0xA94538", VA = "0xA94538")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0xA94610", Offset = "0xA94610", VA = "0xA94610")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018E")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200018F")]
			public enum Type
			{
				[Token(Token = "0x400099B")]
				PositionWeight,
				[Token(Token = "0x400099C")]
				RotationWeight,
				[Token(Token = "0x400099D")]
				PositionOffsetX,
				[Token(Token = "0x400099E")]
				PositionOffsetY,
				[Token(Token = "0x400099F")]
				PositionOffsetZ,
				[Token(Token = "0x40009A0")]
				Pull,
				[Token(Token = "0x40009A1")]
				Reach,
				[Token(Token = "0x40009A2")]
				RotateBoneWeight,
				[Token(Token = "0x40009A3")]
				Push,
				[Token(Token = "0x40009A4")]
				PushParent,
				[Token(Token = "0x40009A5")]
				PoserWeight
			}

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0xA938CC", Offset = "0xA938CC", VA = "0xA938CC")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0xA94624", Offset = "0xA94624", VA = "0xA94624")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000190")]
		public class Multiplier
		{
			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xA93E64", Offset = "0xA93E64", VA = "0xA93E64")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xA9462C", Offset = "0xA9462C", VA = "0xA9462C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000F9")]
		public float length
		{
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0xA92DD4", Offset = "0xA92DD4", VA = "0xA92DD4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0xA92DDC", Offset = "0xA92DDC", VA = "0xA92DDC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0xA92DE4", Offset = "0xA92DE4", VA = "0xA92DE4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0xA92DEC", Offset = "0xA92DEC", VA = "0xA92DEC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0xA93024", Offset = "0xA93024", VA = "0xA93024")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0xA92FA4", Offset = "0xA92FA4", VA = "0xA92FA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xA92C3C", Offset = "0xA92C3C", VA = "0xA92C3C")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xA92C80", Offset = "0xA92C80", VA = "0xA92C80")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xA92CC4", Offset = "0xA92CC4", VA = "0xA92CC4")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xA92D08", Offset = "0xA92D08", VA = "0xA92D08")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xA92D4C", Offset = "0xA92D4C", VA = "0xA92D4C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xA92D90", Offset = "0xA92D90", VA = "0xA92D90")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xA92DF4", Offset = "0xA92DF4", VA = "0xA92DF4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xA930A4", Offset = "0xA930A4", VA = "0xA930A4")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xA9321C", Offset = "0xA9321C", VA = "0xA9321C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xA932B0", Offset = "0xA932B0", VA = "0xA932B0")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xA932B8", Offset = "0xA932B8", VA = "0xA932B8")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xA93458", Offset = "0xA93458", VA = "0xA93458")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xA93460", Offset = "0xA93460", VA = "0xA93460")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xA93E94", Offset = "0xA93E94", VA = "0xA93E94")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xA940A0", Offset = "0xA940A0", VA = "0xA940A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xA938E8", Offset = "0xA938E8", VA = "0xA938E8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xA933F4", Offset = "0xA933F4", VA = "0xA933F4")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xA93E08", Offset = "0xA93E08", VA = "0xA93E08")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xA940A4", Offset = "0xA940A4", VA = "0xA940A4")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xA94100", Offset = "0xA94100", VA = "0xA94100")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xA94144", Offset = "0xA94144", VA = "0xA94144")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xA94188", Offset = "0xA94188", VA = "0xA94188")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000191")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000192")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000193")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[FormerlySerializedAs("collider")]
		[Header("Triggering")]
		public Collider characterCollider;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Tooltip("Reference to the FBBIK component.")]
		[Space(10f)]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x170000FD")]
		public bool inInteraction
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xA947D4", Offset = "0xA947D4", VA = "0xA947D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FE")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0xA9622C", Offset = "0xA9622C", VA = "0xA9622C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0xA96234", Offset = "0xA96234", VA = "0xA96234")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0xA9623C", Offset = "0xA9623C", VA = "0xA9623C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0xA96244", Offset = "0xA96244", VA = "0xA96244")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xA9463C", Offset = "0xA9463C", VA = "0xA9463C")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xA94680", Offset = "0xA94680", VA = "0xA94680")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xA946C4", Offset = "0xA946C4", VA = "0xA946C4")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xA94708", Offset = "0xA94708", VA = "0xA94708")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xA9474C", Offset = "0xA9474C", VA = "0xA9474C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xA94790", Offset = "0xA94790", VA = "0xA94790")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xA94950", Offset = "0xA94950", VA = "0xA94950")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xA94A0C", Offset = "0xA94A0C", VA = "0xA94A0C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xA94AC8", Offset = "0xA94AC8", VA = "0xA94AC8")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xA94B64", Offset = "0xA94B64", VA = "0xA94B64")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xA94C4C", Offset = "0xA94C4C", VA = "0xA94C4C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xA94D48", Offset = "0xA94D48", VA = "0xA94D48")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xA94DD0", Offset = "0xA94DD0", VA = "0xA94DD0")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xA94E58", Offset = "0xA94E58", VA = "0xA94E58")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xA94EE0", Offset = "0xA94EE0", VA = "0xA94EE0")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xA94F4C", Offset = "0xA94F4C", VA = "0xA94F4C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xA94FB8", Offset = "0xA94FB8", VA = "0xA94FB8")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xA95018", Offset = "0xA95018", VA = "0xA95018")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xA95098", Offset = "0xA95098", VA = "0xA95098")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xA95120", Offset = "0xA95120", VA = "0xA95120")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xA951D8", Offset = "0xA951D8", VA = "0xA951D8")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xA95468", Offset = "0xA95468", VA = "0xA95468")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xA95624", Offset = "0xA95624", VA = "0xA95624")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xA9588C", Offset = "0xA9588C", VA = "0xA9588C")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xA95B18", Offset = "0xA95B18", VA = "0xA95B18")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xA95B50", Offset = "0xA95B50", VA = "0xA95B50")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xA95BB0", Offset = "0xA95BB0", VA = "0xA95BB0")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xA95CB8", Offset = "0xA95CB8", VA = "0xA95CB8")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xA95E98", Offset = "0xA95E98", VA = "0xA95E98")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xA9610C", Offset = "0xA9610C", VA = "0xA9610C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xA95974", Offset = "0xA95974", VA = "0xA95974")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xA9624C", Offset = "0xA9624C", VA = "0xA9624C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xA96A9C", Offset = "0xA96A9C", VA = "0xA96A9C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xA96ABC", Offset = "0xA96ABC", VA = "0xA96ABC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xA96AD8", Offset = "0xA96AD8", VA = "0xA96AD8")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xA96AF4", Offset = "0xA96AF4", VA = "0xA96AF4")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xA96B48", Offset = "0xA96B48", VA = "0xA96B48")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xA96CB4", Offset = "0xA96CB4", VA = "0xA96CB4")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xA96DB0", Offset = "0xA96DB0", VA = "0xA96DB0")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xA9710C", Offset = "0xA9710C", VA = "0xA9710C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xA971F0", Offset = "0xA971F0", VA = "0xA971F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xA974D4", Offset = "0xA974D4", VA = "0xA974D4")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xA96854", Offset = "0xA96854", VA = "0xA96854")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xA97604", Offset = "0xA97604", VA = "0xA97604")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xA97718", Offset = "0xA97718", VA = "0xA97718")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0xA977C4", Offset = "0xA977C4", VA = "0xA977C4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xA978AC", Offset = "0xA978AC", VA = "0xA978AC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xA978C4", Offset = "0xA978C4", VA = "0xA978C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xA94870", Offset = "0xA94870", VA = "0xA94870")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xA95354", Offset = "0xA95354", VA = "0xA95354")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xA97CAC", Offset = "0xA97CAC", VA = "0xA97CAC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xA97CF0", Offset = "0xA97CF0", VA = "0xA97CF0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xA97D34", Offset = "0xA97D34", VA = "0xA97D34")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000194")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000195")]
		public class Multiplier
		{
			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xA98AE8", Offset = "0xA98AE8", VA = "0xA98AE8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xA98328", Offset = "0xA98328", VA = "0xA98328")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xA9836C", Offset = "0xA9836C", VA = "0xA9836C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xA983B0", Offset = "0xA983B0", VA = "0xA983B0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xA983F4", Offset = "0xA983F4", VA = "0xA983F4")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xA98438", Offset = "0xA98438", VA = "0xA98438")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xA9847C", Offset = "0xA9847C", VA = "0xA9847C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xA93868", Offset = "0xA93868", VA = "0xA93868")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xA984C0", Offset = "0xA984C0", VA = "0xA984C0")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xA9854C", Offset = "0xA9854C", VA = "0xA9854C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xA989F0", Offset = "0xA989F0", VA = "0xA989F0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xA98A34", Offset = "0xA98A34", VA = "0xA98A34")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xA98A78", Offset = "0xA98A78", VA = "0xA98A78")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000196")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000197")]
		public class CharacterPosition
		{
			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x17000100")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000A27")]
				[Address(RVA = "0xA98CC8", Offset = "0xA98CC8", VA = "0xA98CC8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000101")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000A28")]
				[Address(RVA = "0xA98CD4", Offset = "0xA98CD4", VA = "0xA98CD4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0xA98D94", Offset = "0xA98D94", VA = "0xA98D94")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0xA994F8", Offset = "0xA994F8", VA = "0xA994F8")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000198")]
		public class CameraPosition
		{
			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction?")]
			public Collider lookAtTarget;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0xA9950C", Offset = "0xA9950C", VA = "0xA9950C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0xA99684", Offset = "0xA99684", VA = "0xA99684")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0xA9998C", Offset = "0xA9998C", VA = "0xA9998C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000199")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x200019A")]
			public class Interaction
			{
				[Token(Token = "0x40009DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40009E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000A30")]
				[Address(RVA = "0xA99A10", Offset = "0xA99A10", VA = "0xA99A10")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0xA98BC0", Offset = "0xA98BC0", VA = "0xA98BC0")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0xA99A00", Offset = "0xA99A00", VA = "0xA99A00")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xA98AF0", Offset = "0xA98AF0", VA = "0xA98AF0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xA98B34", Offset = "0xA98B34", VA = "0xA98B34")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xA98B78", Offset = "0xA98B78", VA = "0xA98B78")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xA98BBC", Offset = "0xA98BBC", VA = "0xA98BBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xA96F58", Offset = "0xA96F58", VA = "0xA96F58")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xA98C70", Offset = "0xA98C70", VA = "0xA98C70")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x200019C")]
		public class Map
		{
			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0xA99D04", Offset = "0xA99D04", VA = "0xA99D04")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0xA9A040", Offset = "0xA9A040", VA = "0xA9A040")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0xA9A000", Offset = "0xA9A000", VA = "0xA9A000")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0xA99E84", Offset = "0xA99E84", VA = "0xA99E84")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xA99A18", Offset = "0xA99A18", VA = "0xA99A18", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xA99D90", Offset = "0xA99D90", VA = "0xA99D90", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xA99D94", Offset = "0xA99D94", VA = "0xA99D94", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xA99FA4", Offset = "0xA99FA4", VA = "0xA99FA4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xA99D34", Offset = "0xA99D34", VA = "0xA99D34")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xA99C70", Offset = "0xA99C70", VA = "0xA99C70")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xA9A084", Offset = "0xA9A084", VA = "0xA9A084")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200019D")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xA9A0A4", Offset = "0xA9A0A4", VA = "0xA9A0A4", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xA9A164", Offset = "0xA9A164", VA = "0xA9A164", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xA9A308", Offset = "0xA9A308", VA = "0xA9A308", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xA9A3F0", Offset = "0xA9A3F0", VA = "0xA9A3F0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xA9A1B8", Offset = "0xA9A1B8", VA = "0xA9A1B8")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xA9A720", Offset = "0xA9A720", VA = "0xA9A720")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200019E")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000A42")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000A43")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000A44")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000A45")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xA9A730", Offset = "0xA9A730", VA = "0xA9A730", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xA9A774", Offset = "0xA9A774", VA = "0xA9A774", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xA9A7A0", Offset = "0xA9A7A0", VA = "0xA9A7A0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xA9A094", Offset = "0xA9A094", VA = "0xA9A094")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class RagdollUtility : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A0")]
		public class Rigidbone
		{
			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0xA9AE34", Offset = "0xA9AE34", VA = "0xA9AE34")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0xA9B97C", Offset = "0xA9B97C", VA = "0xA9B97C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0xA9B73C", Offset = "0xA9B73C", VA = "0xA9B73C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20001A1")]
		public class Child
		{
			[Token(Token = "0x4000A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0xA9AF88", Offset = "0xA9AF88", VA = "0xA9AF88")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0xA9BB3C", Offset = "0xA9BB3C", VA = "0xA9BB3C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0xA9BA50", Offset = "0xA9BA50", VA = "0xA9BA50")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20001A2")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A65")]
				[Address(RVA = "0xA9C108", Offset = "0xA9C108", VA = "0xA9C108", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A67")]
				[Address(RVA = "0xA9C150", Offset = "0xA9C150", VA = "0xA9C150", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0xA9AFE4", Offset = "0xA9AFE4", VA = "0xA9AFE4")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0xA9BF24", Offset = "0xA9BF24", VA = "0xA9BF24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0xA9BF28", Offset = "0xA9BF28", VA = "0xA9BF28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0xA9C110", Offset = "0xA9C110", VA = "0xA9C110", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Rigidbone[] rigidbones;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000102")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0xA9A7E4", Offset = "0xA9A7E4", VA = "0xA9A7E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000103")]
		private bool ikUsed
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0xA9B370", Offset = "0xA9B370", VA = "0xA9B370")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xA9A7B8", Offset = "0xA9A7B8", VA = "0xA9A7B8")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xA9A930", Offset = "0xA9A930", VA = "0xA9A930")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xA9AA28", Offset = "0xA9AA28", VA = "0xA9AA28")]
		public void Start()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xA9A9C0", Offset = "0xA9A9C0", VA = "0xA9A9C0")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xA9B00C", Offset = "0xA9B00C", VA = "0xA9B00C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xA9B234", Offset = "0xA9B234", VA = "0xA9B234")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xA9B2D4", Offset = "0xA9B2D4", VA = "0xA9B2D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xA9B4C4", Offset = "0xA9B4C4", VA = "0xA9B4C4")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xA9B344", Offset = "0xA9B344", VA = "0xA9B344")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xA9B490", Offset = "0xA9B490", VA = "0xA9B490")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xA9B544", Offset = "0xA9B544", VA = "0xA9B544")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0xA9B4E8", Offset = "0xA9B4E8", VA = "0xA9B4E8")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xA9A964", Offset = "0xA9A964", VA = "0xA9A964")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xA9B268", Offset = "0xA9B268", VA = "0xA9B268")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xA9BD14", Offset = "0xA9BD14", VA = "0xA9BD14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xA9BE2C", Offset = "0xA9BE2C", VA = "0xA9BE2C")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000106")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0xA9C4D4", Offset = "0xA9C4D4", VA = "0xA9C4D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000107")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0xA9C4E0", Offset = "0xA9C4E0", VA = "0xA9C4E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xA9C158", Offset = "0xA9C158", VA = "0xA9C158")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xA9C190", Offset = "0xA9C190", VA = "0xA9C190")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xA9C444", Offset = "0xA9C444", VA = "0xA9C444")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xA9C4A8", Offset = "0xA9C4A8", VA = "0xA9C4A8")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000A6E")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xA9C348", Offset = "0xA9C348", VA = "0xA9C348")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xA9C510", Offset = "0xA9C510", VA = "0xA9C510")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xA9C514", Offset = "0xA9C514", VA = "0xA9C514")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xA9C53C", Offset = "0xA9C53C", VA = "0xA9C53C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xA9C610", Offset = "0xA9C610", VA = "0xA9C610")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0xA9C868", Offset = "0xA9C868", VA = "0xA9C868")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0xA9C9BC", Offset = "0xA9C9BC", VA = "0xA9C9BC")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0xA9CA1C", Offset = "0xA9CA1C", VA = "0xA9CA1C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0xA9CA60", Offset = "0xA9CA60", VA = "0xA9CA60")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0xA9CAA4", Offset = "0xA9CAA4", VA = "0xA9CAA4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0xA9CAE8", Offset = "0xA9CAE8", VA = "0xA9CAE8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0xA9CB2C", Offset = "0xA9CB2C", VA = "0xA9CB2C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0xA9CB64", Offset = "0xA9CB64", VA = "0xA9CB64")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0xA9CE88", Offset = "0xA9CE88", VA = "0xA9CE88")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0xA9CE98", Offset = "0xA9CE98", VA = "0xA9CE98")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xA9CEDC", Offset = "0xA9CEDC", VA = "0xA9CEDC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xA9CF20", Offset = "0xA9CF20", VA = "0xA9CF20")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0xA9CF64", Offset = "0xA9CF64", VA = "0xA9CF64")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0xA9CFA8", Offset = "0xA9CFA8", VA = "0xA9CFA8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0xA9CFC4", Offset = "0xA9CFC4", VA = "0xA9CFC4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0xA9D20C", Offset = "0xA9D20C", VA = "0xA9D20C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20001A7")]
		public class ReachCone
		{
			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000108")]
			public Vector3 o
			{
				[Token(Token = "0x6000A94")]
				[Address(RVA = "0xA9EFA0", Offset = "0xA9EFA0", VA = "0xA9EFA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000109")]
			public Vector3 a
			{
				[Token(Token = "0x6000A95")]
				[Address(RVA = "0xA9EFCC", Offset = "0xA9EFCC", VA = "0xA9EFCC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010A")]
			public Vector3 b
			{
				[Token(Token = "0x6000A96")]
				[Address(RVA = "0xA9EFFC", Offset = "0xA9EFFC", VA = "0xA9EFFC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010B")]
			public Vector3 c
			{
				[Token(Token = "0x6000A97")]
				[Address(RVA = "0xA9F02C", Offset = "0xA9F02C", VA = "0xA9F02C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010C")]
			public bool isValid
			{
				[Token(Token = "0x6000A99")]
				[Address(RVA = "0xA9E4E8", Offset = "0xA9E4E8", VA = "0xA9E4E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A98")]
			[Address(RVA = "0xA9E98C", Offset = "0xA9E98C", VA = "0xA9E98C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0xA9EAF0", Offset = "0xA9EAF0", VA = "0xA9EAF0")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A8")]
		public class LimitPoint
		{
			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0xA9E4F8", Offset = "0xA9E4F8", VA = "0xA9E4F8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0xA9D270", Offset = "0xA9D270", VA = "0xA9D270")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0xA9D2B4", Offset = "0xA9D2B4", VA = "0xA9D2B4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0xA9D2F8", Offset = "0xA9D2F8", VA = "0xA9D2F8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0xA9D33C", Offset = "0xA9D33C", VA = "0xA9D33C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xA9D380", Offset = "0xA9D380", VA = "0xA9D380")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0xA9D9B8", Offset = "0xA9D9B8", VA = "0xA9D9B8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0xA9DA40", Offset = "0xA9DA40", VA = "0xA9DA40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0xA9E020", Offset = "0xA9E020", VA = "0xA9E020")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0xA9D40C", Offset = "0xA9D40C", VA = "0xA9D40C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0xA9E55C", Offset = "0xA9E55C", VA = "0xA9E55C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0xA9ED64", Offset = "0xA9ED64", VA = "0xA9ED64")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0xA9EDAC", Offset = "0xA9EDAC", VA = "0xA9EDAC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0xA9EE0C", Offset = "0xA9EE0C", VA = "0xA9EE0C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0xA9DD7C", Offset = "0xA9DD7C", VA = "0xA9DD7C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xA9EE78", Offset = "0xA9EE78", VA = "0xA9EE78")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0xA9EF44", Offset = "0xA9EF44", VA = "0xA9EF44")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20001A9")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xA9F05C", Offset = "0xA9F05C", VA = "0xA9F05C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0xA9F0A0", Offset = "0xA9F0A0", VA = "0xA9F0A0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0xA9F0E4", Offset = "0xA9F0E4", VA = "0xA9F0E4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0xA9F128", Offset = "0xA9F128", VA = "0xA9F128")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0xA9F16C", Offset = "0xA9F16C", VA = "0xA9F16C")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xA9F188", Offset = "0xA9F188", VA = "0xA9F188", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xA9F1C0", Offset = "0xA9F1C0", VA = "0xA9F1C0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0xA9F56C", Offset = "0xA9F56C", VA = "0xA9F56C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool rotationAllowed;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform lastTarget;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float switchWeight;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float switchWeightV;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float weightV;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 dir;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700010D")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0xA9F5F4", Offset = "0xA9F5F4", VA = "0xA9F5F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0xA9F578", Offset = "0xA9F578", VA = "0xA9F578")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xA9F678", Offset = "0xA9F678", VA = "0xA9F678")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xA9FB90", Offset = "0xA9FB90", VA = "0xA9FB90")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xA9FD14", Offset = "0xA9FD14", VA = "0xA9FD14")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xA9FF60", Offset = "0xA9FF60", VA = "0xA9FF60")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20001AB")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001AC")]
		public class Pose
		{
			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0xAA0104", Offset = "0xAA0104", VA = "0xAA0104")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0xAA0674", Offset = "0xAA0674", VA = "0xAA0674")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0xAA067C", Offset = "0xAA067C", VA = "0xAA067C")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xAA0034", Offset = "0xAA0034", VA = "0xAA0034")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xAA05B4", Offset = "0xAA05B4", VA = "0xAA05B4")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xAA0614", Offset = "0xAA0614", VA = "0xAA0614")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001AE")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001AF")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A54")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A55")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000AB5")]
				[Address(RVA = "0xAA0B40", Offset = "0xAA0B40", VA = "0xAA0B40")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xAA07E8", Offset = "0xAA07E8", VA = "0xAA07E8")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0xAA0B18", Offset = "0xAA0B18", VA = "0xAA0B18")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0xAA0B28", Offset = "0xAA0B28", VA = "0xAA0B28")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xAA0698", Offset = "0xAA0698", VA = "0xAA0698", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xAA0AF8", Offset = "0xAA0AF8", VA = "0xAA0AF8")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xAA0B48", Offset = "0xAA0B48", VA = "0xAA0B48", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xAA0BB0", Offset = "0xAA0BB0", VA = "0xAA0BB0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xAA0E50", Offset = "0xAA0E50", VA = "0xAA0E50")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001B2")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700010F")]
			public bool inProgress
			{
				[Token(Token = "0x6000ABD")]
				[Address(RVA = "0xAA0F08", Offset = "0xAA0F08", VA = "0xAA0F08")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000110")]
			protected float crossFader
			{
				[Token(Token = "0x6000ABE")]
				[Address(RVA = "0xAA1408", Offset = "0xAA1408", VA = "0xAA1408")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000ABF")]
				[Address(RVA = "0xAA1410", Offset = "0xAA1410", VA = "0xAA1410")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000111")]
			protected float timer
			{
				[Token(Token = "0x6000AC0")]
				[Address(RVA = "0xAA1418", Offset = "0xAA1418", VA = "0xAA1418")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AC1")]
				[Address(RVA = "0xAA1420", Offset = "0xAA1420", VA = "0xAA1420")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000112")]
			protected Vector3 force
			{
				[Token(Token = "0x6000AC2")]
				[Address(RVA = "0xAA1428", Offset = "0xAA1428", VA = "0xAA1428")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AC3")]
				[Address(RVA = "0xAA1434", Offset = "0xAA1434", VA = "0xAA1434")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000113")]
			protected Vector3 point
			{
				[Token(Token = "0x6000AC4")]
				[Address(RVA = "0xAA1440", Offset = "0xAA1440", VA = "0xAA1440")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AC5")]
				[Address(RVA = "0xAA144C", Offset = "0xAA144C", VA = "0xAA144C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0xAA12D0", Offset = "0xAA12D0", VA = "0xAA12D0")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0xAA0FDC", Offset = "0xAA0FDC", VA = "0xAA0FDC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000AC8")]
			protected abstract float GetLength();

			[Token(Token = "0x6000AC9")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000ACA")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0xAA1458", Offset = "0xAA1458", VA = "0xAA1458")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B3")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001B4")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A6B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A6C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000A6D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A6E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000AD0")]
				[Address(RVA = "0xAA178C", Offset = "0xAA178C", VA = "0xAA178C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000AD1")]
				[Address(RVA = "0xAA15E8", Offset = "0xAA15E8", VA = "0xAA15E8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000AD2")]
				[Address(RVA = "0xAA183C", Offset = "0xAA183C", VA = "0xAA183C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0xAA146C", Offset = "0xAA146C", VA = "0xAA146C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0xAA1588", Offset = "0xAA1588", VA = "0xAA1588", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0xAA15FC", Offset = "0xAA15FC", VA = "0xAA15FC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0xAA1828", Offset = "0xAA1828", VA = "0xAA1828")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B5")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001B6")]
			public class BoneLink
			{
				[Token(Token = "0x4000A72")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x4000A73")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x4000A74")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A75")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000AD7")]
				[Address(RVA = "0xAA1AFC", Offset = "0xAA1AFC", VA = "0xAA1AFC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000AD8")]
				[Address(RVA = "0xAA1928", Offset = "0xAA1928", VA = "0xAA1928")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000AD9")]
				[Address(RVA = "0xAA1C9C", Offset = "0xAA1C9C", VA = "0xAA1C9C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0xAA1844", Offset = "0xAA1844", VA = "0xAA1844", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0xAA18D0", Offset = "0xAA18D0", VA = "0xAA18D0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0xAA1934", Offset = "0xAA1934", VA = "0xAA1934", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0xAA1C88", Offset = "0xAA1C88", VA = "0xAA1C88")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700010E")]
		public bool inProgress
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0xAA0E6C", Offset = "0xAA0E6C", VA = "0xAA0E6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xAA0F1C", Offset = "0xAA0F1C", VA = "0xAA0F1C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xAA10B4", Offset = "0xAA10B4", VA = "0xAA10B4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xAA13F8", Offset = "0xAA13F8", VA = "0xAA13F8")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20001B8")]
		public abstract class Offset
		{
			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000114")]
			protected float crossFader
			{
				[Token(Token = "0x6000ADD")]
				[Address(RVA = "0xAA220C", Offset = "0xAA220C", VA = "0xAA220C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000ADE")]
				[Address(RVA = "0xAA2214", Offset = "0xAA2214", VA = "0xAA2214")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000115")]
			protected float timer
			{
				[Token(Token = "0x6000ADF")]
				[Address(RVA = "0xAA221C", Offset = "0xAA221C", VA = "0xAA221C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AE0")]
				[Address(RVA = "0xAA2224", Offset = "0xAA2224", VA = "0xAA2224")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000116")]
			protected Vector3 force
			{
				[Token(Token = "0x6000AE1")]
				[Address(RVA = "0xAA222C", Offset = "0xAA222C", VA = "0xAA222C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AE2")]
				[Address(RVA = "0xAA2238", Offset = "0xAA2238", VA = "0xAA2238")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000117")]
			protected Vector3 point
			{
				[Token(Token = "0x6000AE3")]
				[Address(RVA = "0xAA2244", Offset = "0xAA2244", VA = "0xAA2244")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AE4")]
				[Address(RVA = "0xAA2250", Offset = "0xAA2250", VA = "0xAA2250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0xAA20BC", Offset = "0xAA20BC", VA = "0xAA20BC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0xAA1DB8", Offset = "0xAA1DB8", VA = "0xAA1DB8")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AE7")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000AE8")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000AE9")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0xAA225C", Offset = "0xAA225C", VA = "0xAA225C")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B9")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001BA")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000A86")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000A87")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000A88")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A89")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000AEF")]
				[Address(RVA = "0xAA2640", Offset = "0xAA2640", VA = "0xAA2640")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000AF0")]
				[Address(RVA = "0xAA2464", Offset = "0xAA2464", VA = "0xAA2464")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000AF1")]
				[Address(RVA = "0xAA26D4", Offset = "0xAA26D4", VA = "0xAA26D4")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0xAA2270", Offset = "0xAA2270", VA = "0xAA2270", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xAA2404", Offset = "0xAA2404", VA = "0xAA2404", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0xAA2478", Offset = "0xAA2478", VA = "0xAA2478", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0xAA26B8", Offset = "0xAA26B8", VA = "0xAA26B8")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BB")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001BC")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000A8D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000A8E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x4000A8F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A90")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000AF6")]
				[Address(RVA = "0xAA2A94", Offset = "0xAA2A94", VA = "0xAA2A94")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000AF7")]
				[Address(RVA = "0xAA280C", Offset = "0xAA280C", VA = "0xAA280C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000AF8")]
				[Address(RVA = "0xAA2BB0", Offset = "0xAA2BB0", VA = "0xAA2BB0")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x4000A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000A8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xAA26DC", Offset = "0xAA26DC", VA = "0xAA26DC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xAA27B4", Offset = "0xAA27B4", VA = "0xAA27B4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xAA2818", Offset = "0xAA2818", VA = "0xAA2818", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xAA2B9C", Offset = "0xAA2B9C", VA = "0xAA2B9C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xAA1D00", Offset = "0xAA1D00", VA = "0xAA1D00", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0xAA1E98", Offset = "0xAA1E98", VA = "0xAA1E98")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0xAA21EC", Offset = "0xAA21EC", VA = "0xAA21EC")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20001BD")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001BE")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001BF")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A9E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A9F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000AFF")]
				[Address(RVA = "0xAA3178", Offset = "0xAA3178", VA = "0xAA3178")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x4000A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x4000A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x4000A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x4000A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x4000A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000A9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0xAA2C80", Offset = "0xAA2C80", VA = "0xAA2C80")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0xAA2E00", Offset = "0xAA2E00", VA = "0xAA2E00")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0xAA315C", Offset = "0xAA315C", VA = "0xAA315C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0xAA2C14", Offset = "0xAA2C14", VA = "0xAA2C14")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0xAA2D5C", Offset = "0xAA2D5C", VA = "0xAA2D5C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0xAA314C", Offset = "0xAA314C", VA = "0xAA314C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001C1")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000AA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000AA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x4000AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x4000AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x4000AAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0xAA32E4", Offset = "0xAA32E4", VA = "0xAA32E4")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000B09")]
			[Address(RVA = "0xAA3554", Offset = "0xAA3554", VA = "0xAA3554")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0xAA35C4", Offset = "0xAA35C4", VA = "0xAA35C4")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0xAA360C", Offset = "0xAA360C", VA = "0xAA360C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20001C2")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x17000119")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B0F")]
				[Address(RVA = "0xAA3768", Offset = "0xAA3768", VA = "0xAA3768", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B11")]
				[Address(RVA = "0xAA37B0", Offset = "0xAA37B0", VA = "0xAA37B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0xAA31E8", Offset = "0xAA31E8", VA = "0xAA31E8")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0xAA3614", Offset = "0xAA3614", VA = "0xAA3614", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0xAA3618", Offset = "0xAA3618", VA = "0xAA3618", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0xAA3770", Offset = "0xAA3770", VA = "0xAA3770", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000118")]
		protected float deltaTime
		{
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0xAA07C8", Offset = "0xAA07C8", VA = "0xAA07C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000B01")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0xAA0B90", Offset = "0xAA0B90", VA = "0xAA0B90", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0xAA3180", Offset = "0xAA3180", VA = "0xAA3180")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0xAA3210", Offset = "0xAA3210", VA = "0xAA3210")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0xAA30A4", Offset = "0xAA30A4", VA = "0xAA30A4")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0xAA3448", Offset = "0xAA3448", VA = "0xAA3448", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0xAA0B08", Offset = "0xAA0B08", VA = "0xAA0B08")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x1700011C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B1C")]
				[Address(RVA = "0xAA3BBC", Offset = "0xAA3BBC", VA = "0xAA3BBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B1E")]
				[Address(RVA = "0xAA3C04", Offset = "0xAA3C04", VA = "0xAA3C04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B19")]
			[Address(RVA = "0xAA3860", Offset = "0xAA3860", VA = "0xAA3860")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0xAA3A68", Offset = "0xAA3A68", VA = "0xAA3A68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0xAA3A6C", Offset = "0xAA3A6C", VA = "0xAA3A6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0xAA3BC4", Offset = "0xAA3BC4", VA = "0xAA3BC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700011B")]
		protected float deltaTime
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0xAA37B8", Offset = "0xAA37B8", VA = "0xAA37B8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000B13")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0xAA37D8", Offset = "0xAA37D8", VA = "0xAA37D8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0xAA37F8", Offset = "0xAA37F8", VA = "0xAA37F8")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0xAA3888", Offset = "0xAA3888", VA = "0xAA3888")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0xAA395C", Offset = "0xAA395C", VA = "0xAA395C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0xAA21FC", Offset = "0xAA21FC", VA = "0xAA21FC")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001C6")]
		public class EffectorLink
		{
			[Token(Token = "0x4000AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000B22")]
			[Address(RVA = "0xAA3C0C", Offset = "0xAA3C0C", VA = "0xAA3C0C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B23")]
			[Address(RVA = "0xAA3F58", Offset = "0xAA3F58", VA = "0xAA3F58")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0xAA0D9C", Offset = "0xAA0D9C", VA = "0xAA0D9C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xAA3E5C", Offset = "0xAA3E5C", VA = "0xAA3E5C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xAA3F00", Offset = "0xAA3F00", VA = "0xAA3F00")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001C8")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20001C9")]
			public class EffectorLink
			{
				[Token(Token = "0x4000AD9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000ADA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000B33")]
				[Address(RVA = "0xAA52AC", Offset = "0xAA52AC", VA = "0xAA52AC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x4000AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Token(Token = "0x4000AD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000AD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000AD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000AD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000B30")]
			[Address(RVA = "0xAA40FC", Offset = "0xAA40FC", VA = "0xAA40FC")]
			public void Start()
			{
			}

			[Token(Token = "0x6000B31")]
			[Address(RVA = "0xAA4C58", Offset = "0xAA4C58", VA = "0xAA4C58")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000B32")]
			[Address(RVA = "0xAA5298", Offset = "0xAA5298", VA = "0xAA5298")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001CA")]
		public enum Handedness
		{
			[Token(Token = "0x4000ADC")]
			Right,
			[Token(Token = "0x4000ADD")]
			Left
		}

		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x4000ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x4000AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x4000AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x4000AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700011E")]
		public bool isFinished
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0xAA3F60", Offset = "0xAA3F60", VA = "0xAA3F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011F")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0xAA4E5C", Offset = "0xAA4E5C", VA = "0xAA4E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000120")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0xAA4E98", Offset = "0xAA4E98", VA = "0xAA4E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0xAA4E24", Offset = "0xAA4E24", VA = "0xAA4E24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0xAA4E40", Offset = "0xAA4E40", VA = "0xAA4E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0xAA3F84", Offset = "0xAA3F84", VA = "0xAA3F84")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xAA3FB0", Offset = "0xAA3FB0", VA = "0xAA3FB0")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0xAA41D0", Offset = "0xAA41D0", VA = "0xAA41D0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0xAA4ED4", Offset = "0xAA4ED4", VA = "0xAA4ED4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0xAA4FEC", Offset = "0xAA4FEC", VA = "0xAA4FEC")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0xAA503C", Offset = "0xAA503C", VA = "0xAA503C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0xAA520C", Offset = "0xAA520C", VA = "0xAA520C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20001CB")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x4000ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x4000AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0xAA52B4", Offset = "0xAA52B4", VA = "0xAA52B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0xAA53A4", Offset = "0xAA53A4", VA = "0xAA53A4")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0xAA5480", Offset = "0xAA5480", VA = "0xAA5480")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0xAA5884", Offset = "0xAA5884", VA = "0xAA5884")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0xAA58B8", Offset = "0xAA58B8", VA = "0xAA58B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0xAA59C4", Offset = "0xAA59C4", VA = "0xAA59C4")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20001CC")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20001CD")]
		public class Settings
		{
			[Token(Token = "0x4000AE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000AE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Local axis of the body tracker towards the player's forward direction.")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("Local axis of the body tracker towards the up direction.")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x4000AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x4000AEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0xAA717C", Offset = "0xAA717C", VA = "0xAA717C")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0xAA59D8", Offset = "0xAA59D8", VA = "0xAA59D8")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0xAA69D4", Offset = "0xAA69D4", VA = "0xAA69D4")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20001CE")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0xAA7370", Offset = "0xAA7370", VA = "0xAA7370")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0xAA708C", Offset = "0xAA708C", VA = "0xAA708C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0xAA7460", Offset = "0xAA7460", VA = "0xAA7460")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0xAA7748", Offset = "0xAA7748", VA = "0xAA7748")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0xAA7854", Offset = "0xAA7854", VA = "0xAA7854")]
		public VRIKRootController()
		{
		}
	}
}
