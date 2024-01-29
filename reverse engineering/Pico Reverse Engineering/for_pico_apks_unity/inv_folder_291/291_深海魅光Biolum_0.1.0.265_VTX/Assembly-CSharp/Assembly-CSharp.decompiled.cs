using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using FluffyUnderware.Curvy;
using FluffyUnderware.Curvy.Controllers;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class InfectionGrowthController : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E3B7C", Offset = "0x6E3B7C")]
	private sealed class <AnimateGrowth>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		public InfectionGrowthController <>4__this;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		public float targetInfectionLevel;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x2C")]
		private float <currentInfectionLevel>5__2;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		private float <t>5__3;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x19FBD04", Offset = "0x19FBD04", VA = "0x19FBD04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x19FBD4C", Offset = "0x19FBD4C", VA = "0x19FBD4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x19FA494", Offset = "0x19FA494", VA = "0x19FA494")]
		[DebuggerHidden]
		public <AnimateGrowth>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x19FBC30", Offset = "0x19FBC30", VA = "0x19FBC30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x19FBC34", Offset = "0x19FBC34", VA = "0x19FBC34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x19FBD0C", Offset = "0x19FBD0C", VA = "0x19FBD0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	private MaterialPropertyBlock block;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public Renderer leftHandModel;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	private string infectionParamName;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	public float infectionLevel;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x34")]
	public float fadeTime;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x19FA1AC", Offset = "0x19FA1AC", VA = "0x19FA1AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x19FA378", Offset = "0x19FA378", VA = "0x19FA378")]
	public void AnimateInfectionValue(float newInfectionLevel)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x19FA40C", Offset = "0x19FA40C", VA = "0x19FA40C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6E3EF4", Offset = "0x6E3EF4")]
	private IEnumerator AnimateGrowth(float targetInfectionLevel)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x19FA2C0", Offset = "0x19FA2C0", VA = "0x19FA2C0")]
	public void SetInfectionProperty(float infectionValue)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x19FA4C0", Offset = "0x19FA4C0", VA = "0x19FA4C0")]
	public InfectionGrowthController()
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteAlways]
public class SplineArray : MonoBehaviour
{
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x18")]
	public SplineController[] controllers;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x20")]
	public CurvySpline spline;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x28")]
	public float distance;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x2C")]
	public float offet;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x19FBA3C", Offset = "0x19FBA3C", VA = "0x19FBA3C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6E3FA4", Offset = "0x6E3FA4")]
	public void InitControllers()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x19FBB08", Offset = "0x19FBB08", VA = "0x19FBB08")]
	public void SetControllerPositions()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x19FBBA4", Offset = "0x19FBBA4", VA = "0x19FBBA4")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x19FBBA8", Offset = "0x19FBBA8", VA = "0x19FBBA8")]
	public SplineArray()
	{
	}
}
[Token(Token = "0x2000005")]
[ExecuteAlways]
public class Lotus_Dissolve : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E3BEC", Offset = "0x6E3BEC")]
	public float dissolveBlend;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x19FA550", Offset = "0x19FA550", VA = "0x19FA550")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x19FA554", Offset = "0x19FA554", VA = "0x19FA554")]
	private void Update()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x19FA5A4", Offset = "0x19FA5A4", VA = "0x19FA5A4")]
	public Lotus_Dissolve()
	{
	}
}
[Token(Token = "0x2000006")]
public class ChangeSkyBoxBegin : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x18")]
	public Transform player;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x20")]
	private Material actualSkybox;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x28")]
	public Color startColor;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x38")]
	public Color endColor;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x48")]
	public float depthToEndColor;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x19F9E24", Offset = "0x19F9E24", VA = "0x19F9E24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x19F9E54", Offset = "0x19F9E54", VA = "0x19F9E54")]
	private void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x19F9FC8", Offset = "0x19F9FC8", VA = "0x19F9FC8")]
	public ChangeSkyBoxBegin()
	{
	}
}
[Token(Token = "0x2000007")]
[ExecuteAlways]
public class ChangeSkyboxWhileGoingDeep : MonoBehaviour
{
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E3C04", Offset = "0x6E3C04")]
	public Transform player;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x20")]
	public Transform startDepthPoint;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x28")]
	public Transform endDepthPoint;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E3C3C", Offset = "0x6E3C3C")]
	public float ambientIntensityBake;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x34")]
	public float ambientIntensityRealtime;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E3C74", Offset = "0x6E3C74")]
	public Gradient fogGradient;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E3CAC", Offset = "0x6E3CAC")]
	public AnimationCurve goingDeepCurve;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve goingBlackCurve;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E3CE4", Offset = "0x6E3CE4")]
	public bool debug;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E3D1C", Offset = "0x6E3D1C")]
	public float depthFactor;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x58")]
	private float startDepth;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x5C")]
	private float endDepth;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x19F9FDC", Offset = "0x19F9FDC", VA = "0x19F9FDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x19FA02C", Offset = "0x19FA02C", VA = "0x19FA02C")]
	[ExecuteAlways]
	private void Update()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x19FA15C", Offset = "0x19FA15C", VA = "0x19FA15C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x19FA168", Offset = "0x19FA168", VA = "0x19FA168")]
	public ChangeSkyboxWhileGoingDeep()
	{
	}
}
[Token(Token = "0x2000008")]
public class DisableAtStart : MonoBehaviour
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x19FA17C", Offset = "0x19FA17C", VA = "0x19FA17C")]
	private void Start()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x19FA1A4", Offset = "0x19FA1A4", VA = "0x19FA1A4")]
	public DisableAtStart()
	{
	}
}
[Token(Token = "0x2000009")]
public class LaunchAnimBySignal : MonoBehaviour
{
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x18")]
	public Animator an;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x20")]
	public string paramName;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x19FA524", Offset = "0x19FA524", VA = "0x19FA524")]
	public void launchAnim()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x19FA548", Offset = "0x19FA548", VA = "0x19FA548")]
	public LaunchAnimBySignal()
	{
	}
}
[Token(Token = "0x200000A")]
public class RenameObjects : MonoBehaviour
{
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x18")]
	private Transform[] myChilds;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x20")]
	private int i;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x19FA5B4", Offset = "0x19FA5B4", VA = "0x19FA5B4")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6E3FEC", Offset = "0x6E3FEC")]
	private void RenameObjectsF()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x19FA778", Offset = "0x19FA778", VA = "0x19FA778")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6E4024", Offset = "0x6E4024")]
	private void RenameObjectsN()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x19FA934", Offset = "0x19FA934", VA = "0x19FA934")]
	public RenameObjects()
	{
	}
}
[Token(Token = "0x200000B")]
public class SetRandomForFishShader : MonoBehaviour
{
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] allFish;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x19FAC54", Offset = "0x19FAC54", VA = "0x19FAC54")]
	private void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x19FAD64", Offset = "0x19FAD64", VA = "0x19FAD64")]
	public SetRandomForFishShader()
	{
	}
}
[Token(Token = "0x200000C")]
public class SetTargetFrameRate : MonoBehaviour
{
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x18")]
	public int targetFrameRate;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x19FAD6C", Offset = "0x19FAD6C", VA = "0x19FAD6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x19FAD9C", Offset = "0x19FAD9C", VA = "0x19FAD9C")]
	public SetTargetFrameRate()
	{
	}
}
[Token(Token = "0x200000D")]
public class SetVertexBlendShape : MonoBehaviour
{
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x18")]
	public Mesh mesh1;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x20")]
	public Mesh mesh2;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x19FADAC", Offset = "0x19FADAC", VA = "0x19FADAC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6E405C", Offset = "0x6E405C")]
	private void ToColor()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x19FAFA8", Offset = "0x19FAFA8", VA = "0x19FAFA8")]
	public SetVertexBlendShape()
	{
	}
}
[Token(Token = "0x200000E")]
public class SetVertexColor : MonoBehaviour
{
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x18")]
	private List<Mesh> meshToColor;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x20")]
	private List<Transform> directionMesh;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] objects;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x19FAFB0", Offset = "0x19FAFB0", VA = "0x19FAFB0")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6E4094", Offset = "0x6E4094")]
	private void ToColor()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x19FB4B0", Offset = "0x19FB4B0", VA = "0x19FB4B0")]
	public SetVertexColor()
	{
	}
}
[Token(Token = "0x200000F")]
public class SetVertexMesh : MonoBehaviour
{
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] go;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x20")]
	private List<Mesh> meshToColor;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x19FB580", Offset = "0x19FB580", VA = "0x19FB580")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6E40CC", Offset = "0x6E40CC")]
	private void ToColor()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x19FB814", Offset = "0x19FB814", VA = "0x19FB814")]
	public SetVertexMesh()
	{
	}
}
[Token(Token = "0x2000010")]
public class SkyBoxControl : CurvyInterpolatableMetadataBase<Color>
{
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x20")]
	public SkyBoxData skyBoxData;

	[Token(Token = "0x17000003")]
	public override Color MetaDataValue
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x19FB898", Offset = "0x19FB898", VA = "0x19FB898", Slot = "10")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x19FB8C4", Offset = "0x19FB8C4", VA = "0x19FB8C4", Slot = "11")]
	public override Color Interpolate(CurvyInterpolatableMetadataBase<Color> nextMetadata, float interpolationTime)
	{
		return default(Color);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x19FB9E8", Offset = "0x19FB9E8", VA = "0x19FB9E8")]
	public SkyBoxControl()
	{
	}
}
[Token(Token = "0x2000011")]
public class TestHaptic : MonoBehaviour
{
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x18")]
	public InputDevice leftController;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x19FBBB0", Offset = "0x19FBBB0", VA = "0x19FBBB0")]
	private void Start()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x19FBBF4", Offset = "0x19FBBF4", VA = "0x19FBBF4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x19FBC0C", Offset = "0x19FBC0C", VA = "0x19FBC0C")]
	public TestHaptic()
	{
	}
}
[Token(Token = "0x2000012")]
public class XrTextureRes : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E3D34", Offset = "0x6E3D34")]
	[SerializeField]
	private float resMultiplicator;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x19FBC14", Offset = "0x19FBC14", VA = "0x19FBC14")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x19FBC20", Offset = "0x19FBC20", VA = "0x19FBC20")]
	public XrTextureRes()
	{
	}
}
[Token(Token = "0x2000013")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6E3BBC", Offset = "0x6E3BBC")]
public class SkyBoxData : ScriptableObject
{
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x18")]
	public Color skyColor;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x19FBA34", Offset = "0x19FBA34", VA = "0x19FBA34")]
	public SkyBoxData()
	{
	}
}
[Token(Token = "0x2000014")]
[ExecuteAlways]
public class ScanUtility : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E3BDC", Offset = "0x6E3BDC")]
	private sealed class <Scanning>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x20")]
		public ScanUtility <>4__this;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x19FBE20", Offset = "0x19FBE20", VA = "0x19FBE20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x19FBE68", Offset = "0x19FBE68", VA = "0x19FBE68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x19FABDC", Offset = "0x19FABDC", VA = "0x19FABDC")]
		[DebuggerHidden]
		public <Scanning>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x19FBD54", Offset = "0x19FBD54", VA = "0x19FBD54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x19FBD58", Offset = "0x19FBD58", VA = "0x19FBD58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x19FBE28", Offset = "0x19FBE28", VA = "0x19FBE28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E3D74", Offset = "0x6E3D74")]
	public bool debug;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x20")]
	public Transform camDebug;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E3DAC", Offset = "0x6E3DAC")]
	public Color color;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x38")]
	public float colorMult;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E3DE4", Offset = "0x6E3DE4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E3DE4", Offset = "0x6E3DE4")]
	public float gridSize;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E3E38", Offset = "0x6E3E38")]
	public float lineWidth;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E3E50", Offset = "0x6E3E50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E3E50", Offset = "0x6E3E50")]
	public float zoneWidth;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve zoneWidthMult;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x50")]
	public float maxDistance;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6E3EA4", Offset = "0x6E3EA4")]
	public float scanDuration;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve scanningCurve;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6E3EDC", Offset = "0x6E3EDC")]
	public float scanning;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x19FA93C", Offset = "0x19FA93C", VA = "0x19FA93C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x19FAB38", Offset = "0x19FAB38", VA = "0x19FAB38")]
	[AttributeAttribute(Name = "ButtonAttribute", RVA = "0x6E4104", Offset = "0x6E4104")]
	public void ProcessScanning()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x19FAB64", Offset = "0x19FAB64", VA = "0x19FAB64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6E411C", Offset = "0x6E411C")]
	private IEnumerator Scanning()
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x19FAC08", Offset = "0x19FAC08", VA = "0x19FAC08")]
	public ScanUtility()
	{
	}
}
