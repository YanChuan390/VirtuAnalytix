using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using AdventureLabs.Data;
using Il2CppDummyDll;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class HealthBar : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform _healthTransform;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FloatCollection _unitCurrHealth;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private FloatVariable _unitMaxHealth;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int _unitIndex;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float _startWidth;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1D7BA90", Offset = "0x1D7BA90", VA = "0x1D7BA90")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1D7BAE4", Offset = "0x1D7BAE4", VA = "0x1D7BAE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1D7BBB8", Offset = "0x1D7BBB8", VA = "0x1D7BBB8")]
	public HealthBar()
	{
	}
}
[Token(Token = "0x2000003")]
public class LookCamera : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedNormal;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float speedFast;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float mouseSensitivityX;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float mouseSensitivityY;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float rotY;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1D7BBC0", Offset = "0x1D7BBC0", VA = "0x1D7BBC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1D7BC88", Offset = "0x1D7BC88", VA = "0x1D7BC88")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1D7BDF0", Offset = "0x1D7BDF0", VA = "0x1D7BDF0")]
	public LookCamera()
	{
	}
}
namespace Shapes
{
	[Token(Token = "0x2000004")]
	public class AmmoBar : MonoBehaviour
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int totalBullets;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int bullets;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB6C30", Offset = "0xAB6C30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6C30", Offset = "0xAB6C30")]
		public float bulletThicknessScale;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6C84", Offset = "0xAB6C84")]
		public float bulletEjectScale;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB6C9C", Offset = "0xAB6C9C")]
		public float bulletDisappearTime;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6CD4", Offset = "0xAB6CD4")]
		public float bulletEjectAngSpeed;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6CF0", Offset = "0xAB6CF0")]
		public float ejectRotSpeedVariance;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve bulletEjectX;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve bulletEjectY;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] bulletFireTimes;

		[Token(Token = "0x17000001")]
		public bool HasBulletsLeft
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1D77D58", Offset = "0x1D77D58", VA = "0x1D77D58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1D77CDC", Offset = "0x1D77CDC", VA = "0x1D77CDC")]
		private Vector2 GetBulletEjectPos(Vector2 origin, float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1D77D68", Offset = "0x1D77D68", VA = "0x1D77D68")]
		public void Fire()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1D77DC0", Offset = "0x1D77DC0", VA = "0x1D77DC0")]
		public void Reload()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1D77DCC", Offset = "0x1D77DCC", VA = "0x1D77DCC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1D77E20", Offset = "0x1D77E20", VA = "0x1D77E20")]
		public void DrawBar(FpsController fpsController, float barRadius)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1D782D8", Offset = "0x1D782D8", VA = "0x1D782D8")]
		public AmmoBar()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class ChargeBar : MonoBehaviour
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB6D0C", Offset = "0xAB6D0C")]
		[SerializeField]
		private float chargeSpeed;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float chargeDecaySpeed;

		[NonSerialized]
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isCharging;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float charge;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB6D68", Offset = "0xAB6D68")]
		public Color tickColor;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Gradient chargeFillGradient;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6DA0", Offset = "0xAB6DA0")]
		public float tickSizeSmol;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6DBC", Offset = "0xAB6DBC")]
		public float tickSizeLorge;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6DD8", Offset = "0xAB6DD8")]
		public float tickTickness;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6DF4", Offset = "0xAB6DF4")]
		public float fontSize;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6E0C", Offset = "0xAB6E0C")]
		public float fontSizeLorge;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6E24", Offset = "0xAB6E24")]
		public float percentLabelOffset;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6E40", Offset = "0xAB6E40")]
		public float fontGrowRangePrev;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6E5C", Offset = "0xAB6E5C")]
		public float fontGrowRangeNext;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB6E78", Offset = "0xAB6E78")]
		public AnimationCurve chargeFillCurve;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve animChargeShakeMagnitude;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6EB0", Offset = "0xAB6EB0")]
		public float chargeShakeMagnitude;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float chargeShakeSpeed;

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1D78358", Offset = "0x1D78358", VA = "0x1D78358")]
		public void UpdateCharge()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1D783C4", Offset = "0x1D783C4", VA = "0x1D783C4")]
		public void DrawBar(FpsController fpsController, float barRadius)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1D78A74", Offset = "0x1D78A74", VA = "0x1D78A74")]
		public ChargeBar()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class Compass : MonoBehaviour
	{
		[StructLayout(3)]
		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6830", Offset = "0xAB6830")]
		private struct <>c__DisplayClass13_0
		{
			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angWorldMax;

			[Token(Token = "0x4000090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angWorldMin;

			[Token(Token = "0x4000091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float angUiMin;

			[Token(Token = "0x4000092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float angUiMax;

			[Token(Token = "0x4000093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2 compArcOrigin;

			[Token(Token = "0x4000094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Compass <>4__this;
		}

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 position;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float width;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6ECC", Offset = "0xAB6ECC")]
		public float lineThickness;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6EE8", Offset = "0xAB6EE8")]
		public float bendRadius;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6F04", Offset = "0xAB6F04")]
		public float fieldOfView;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB6F24", Offset = "0xAB6F24")]
		public int ticksPerQuarterTurn;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6F5C", Offset = "0xAB6F5C")]
		public float tickSize;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6F78", Offset = "0xAB6F78")]
		public float tickEdgeFadeFraction;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6F90", Offset = "0xAB6F90")]
		public float fontSizeTickLabel;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6FB0", Offset = "0xAB6FB0")]
		public float tickLabelOffset;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB6FCC", Offset = "0xAB6FCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB6FCC", Offset = "0xAB6FCC")]
		public float fontSizeLookLabel;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2 lookAngLabelOffset;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB7028", Offset = "0xAB7028")]
		public float triangleNootSize;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1D78AF4", Offset = "0x1D78AF4", VA = "0x1D78AF4")]
		public void DrawCompass(Vector3 worldDir)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1D79258", Offset = "0x1D79258", VA = "0x1D79258")]
		public Compass()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1D78FF4", Offset = "0x1D78FF4", VA = "0x1D78FF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB74B8", Offset = "0xAB74B8")]
		private void <DrawCompass>g__CompassArcNoot|13_0(float worldAng, float size, string label, ref <>c__DisplayClass13_0 P_3)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class Crosshair : MonoBehaviour
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB7044", Offset = "0xAB7044")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB7044", Offset = "0xAB7044")]
		public float crosshairCrossInnerRad;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB709C", Offset = "0xAB709C")]
		public float crosshairCrossOuterRad;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB70B8", Offset = "0xAB70B8")]
		public float crosshairCrossThickness;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB70D4", Offset = "0xAB70D4")]
		public float crosshairHitCrossInnerRad;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB70F0", Offset = "0xAB70F0")]
		public float crosshairHitCrossOuterRad;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB710C", Offset = "0xAB710C")]
		public float crosshairHitCrossThickness;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB7128", Offset = "0xAB7128")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB7128", Offset = "0xAB7128")]
		public float scaleFire;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Decayer fireDecayer;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Decayer hitDecayer;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1D79294", Offset = "0x1D79294", VA = "0x1D79294")]
		public void Fire()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1D792B4", Offset = "0x1D792B4", VA = "0x1D792B4")]
		public void FireHit()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1D792D4", Offset = "0x1D792D4", VA = "0x1D792D4")]
		public void UpdateCrosshairDecay()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1D793B0", Offset = "0x1D793B0", VA = "0x1D793B0")]
		public void DrawCrosshair()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1D797A8", Offset = "0x1D797A8", VA = "0x1D797A8")]
		public Crosshair()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1D7965C", Offset = "0x1D7965C", VA = "0x1D7965C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB74C8", Offset = "0xAB74C8")]
		internal static void <DrawCrosshair>g__DrawCross|12_0(Vector2[] dirs, float radInner, float radOuter, float thickness, float radialOffset, Color color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class Decayer
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float decaySpeed;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float magnitude;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[NonSerialized]
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float value;

		[NonSerialized]
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float valueInv;

		[NonSerialized]
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float t;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1D7AE44", Offset = "0x1D7AE44", VA = "0x1D7AE44")]
		public void SetT(float v)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1D79308", Offset = "0x1D79308", VA = "0x1D79308")]
		public void Update()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1D79858", Offset = "0x1D79858", VA = "0x1D79858")]
		public Decayer()
		{
		}
	}
	[Token(Token = "0x2000009")]
	[ExecuteAlways]
	public class FpsController : MonoBehaviour
	{
		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6840", Offset = "0xAB6840")]
		private sealed class <FixedSteps>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FpsController <>4__this;

			[Token(Token = "0x17000024")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000151")]
				[Address(RVA = "0x1D8093C", Offset = "0x1D8093C", VA = "0x1D8093C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000025")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000153")]
				[Address(RVA = "0x1D80984", Offset = "0x1D80984", VA = "0x1D80984", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1D7AF6C", Offset = "0x1D7AF6C", VA = "0x1D7AF6C")]
			[DebuggerHidden]
			public <FixedSteps>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1D808A0", Offset = "0x1D808A0", VA = "0x1D808A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1D808A4", Offset = "0x1D808A4", VA = "0x1D808A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1D80944", Offset = "0x1D80944", VA = "0x1D80944", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform head;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera cam;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Crosshair crosshair;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ChargeBar chargeBar;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AmmoBar ammoBar;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Compass compass;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform crosshairTransform;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB717C", Offset = "0xAB717C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB717C", Offset = "0xAB717C")]
		public float smoof;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float moveSpeed;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float lookSensitivity;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float yaw;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float pitch;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector2 moveInput;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 moveVel;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB71D4", Offset = "0xAB71D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB71D4", Offset = "0xAB71D4")]
		public float ammoBarAngularSpanRad;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB722C", Offset = "0xAB722C")]
		public float ammoBarOutlineThickness;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB7248", Offset = "0xAB7248")]
		public float ammoBarThickness;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB7264", Offset = "0xAB7264")]
		public float ammoBarRadius;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAB7280", Offset = "0xAB7280")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAB7280", Offset = "0xAB7280")]
		public float fireSidebarRadiusPunchAmount;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AnimationCurve shakeAnimX;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve shakeAnimY;

		[Token(Token = "0x17000002")]
		private bool InputFocus
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x1D7AE4C", Offset = "0x1D7AE4C", VA = "0x1D7AE4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1D7AE6C", Offset = "0x1D7AE6C", VA = "0x1D7AE6C")]
			set
			{
			}
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1D7812C", Offset = "0x1D7812C", VA = "0x1D7812C")]
		public static void DrawRoundedArcOutline(Vector2 origin, float radius, float thickness, float outlineThickness, float angStart, float angEnd)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1D789F0", Offset = "0x1D789F0", VA = "0x1D789F0")]
		public Vector2 GetShake(float speed, float amp)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1D7AEA0", Offset = "0x1D7AEA0", VA = "0x1D7AEA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1D7AF00", Offset = "0x1D7AF00", VA = "0x1D7AF00")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAB74D8", Offset = "0xAB74D8")]
		private IEnumerator FixedSteps()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1D7AF98", Offset = "0x1D7AF98", VA = "0x1D7AF98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1D7B120", Offset = "0x1D7B120", VA = "0x1D7B120")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1D7B2A8", Offset = "0x1D7B2A8", VA = "0x1D7B2A8")]
		private void DrawShapesSRP(ScriptableRenderContext ctx, Camera cam)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1D7AF9C", Offset = "0x1D7AF9C", VA = "0x1D7AF9C")]
		private void OnPostRenderSubscribe()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1D7B124", Offset = "0x1D7B124", VA = "0x1D7B124")]
		private void OnPostRenderUnsubscribe()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1D7B2B0", Offset = "0x1D7B2B0", VA = "0x1D7B2B0")]
		private void DrawShapes(Camera cam)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1D7B4B4", Offset = "0x1D7B4B4", VA = "0x1D7B4B4")]
		private void FixedUpdateManual()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1D7B60C", Offset = "0x1D7B60C", VA = "0x1D7B60C")]
		private void Update()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1D7B9F0", Offset = "0x1D7B9F0", VA = "0x1D7B9F0")]
		public FpsController()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1D7B9A0", Offset = "0x1D7B9A0", VA = "0x1D7B9A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7538", Offset = "0xAB7538")]
		private void <Update>g__DoInput|35_0(KeyCode key, Vector2 dir)
		{
		}
	}
}
namespace CSNC.Controller
{
	[Token(Token = "0x200000A")]
	public class TransformSetterController : MonoBehaviour
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _transform;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NonSerializedTransformReference _nonSerializedTransformReference;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1D802B0", Offset = "0x1D802B0", VA = "0x1D802B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1D802D0", Offset = "0x1D802D0", VA = "0x1D802D0")]
		public TransformSetterController()
		{
		}
	}
}
namespace RedScarf.EasyCSV.Demo
{
	[Token(Token = "0x200000B")]
	public class CsvTest : MonoBehaviour
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextAsset text;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CsvTable table;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int row;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int column;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string rowStr;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string columnStr;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string readValue;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string writeValue;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string rowDataStr;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string rowID;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int buttonWidth;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1D79860", Offset = "0x1D79860", VA = "0x1D79860")]
		private void Start()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1D79910", Offset = "0x1D79910", VA = "0x1D79910")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1D7ADC4", Offset = "0x1D7ADC4", VA = "0x1D7ADC4")]
		public CsvTest()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class TestRowData
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string columnName1;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string columnName2;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string columnName3;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string columnName4;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int columnName5;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1D7FFD0", Offset = "0x1D7FFD0", VA = "0x1D7FFD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1D802A8", Offset = "0x1D802A8", VA = "0x1D802A8")]
		public TestRowData()
		{
		}
	}
}
namespace EventsPlus
{
	[Token(Token = "0x200000D")]
	public delegate void Action<A, B, C, D, E>(A tA, B tB, C tC, D tD, E tE);
	[Token(Token = "0x200000E")]
	public delegate void Action<A, B, C, D, E, F>(A tA, B tB, C tC, D tD, E tE, F tF);
	[Token(Token = "0x200000F")]
	public delegate void Action<A, B, C, D, E, F, G>(A tA, B tB, C tC, D tD, E tE, F tF, G tG);
	[Token(Token = "0x2000010")]
	public delegate void Action<A, B, C, D, E, F, G, H>(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH);
	[Token(Token = "0x2000011")]
	public delegate void Action<A, B, C, D, E, F, G, H, I>(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI);
	[Token(Token = "0x2000012")]
	public delegate void Action<A, B, C, D, E, F, G, H, I, J>(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI, J tJ);
	[Token(Token = "0x2000013")]
	public delegate T Func<A, B, C, D, E, T>(A tA, B tB, C tC, D tD, E tE);
	[Token(Token = "0x2000014")]
	public delegate T Func<A, B, C, D, E, F, T>(A tA, B tB, C tC, D tD, E tE, F tF);
	[Token(Token = "0x2000015")]
	public delegate T Func<A, B, C, D, E, F, G, T>(A tA, B tB, C tC, D tD, E tE, F tF, G tG);
	[Token(Token = "0x2000016")]
	public delegate T Func<A, B, C, D, E, F, G, H, T>(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH);
	[Token(Token = "0x2000017")]
	public delegate T Func<A, B, C, D, E, F, G, H, I, T>(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI);
	[Token(Token = "0x2000018")]
	public delegate T Func<A, B, C, D, E, F, G, H, I, J, T>(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI, J tJ);
	[Serializable]
	[Token(Token = "0x2000019")]
	public class Publisher
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected string _tag;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected List<RawCall> _calls;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<Subscriber, List<RawRequest>> requests;

		[Token(Token = "0x17000003")]
		public virtual Type[] types
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1D7CCB0", Offset = "0x1D7CCB0", VA = "0x1D7CCB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public string tag
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x1D7CCB8", Offset = "0x1D7CCB8", VA = "0x1D7CCB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public List<RawCall> calls
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x1D7CCC0", Offset = "0x1D7CCC0", VA = "0x1D7CCC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x1D7CCC8", Offset = "0x1D7CCC8", VA = "0x1D7CCC8")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action<Publisher> OnLoaded
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x1D7BE04", Offset = "0x1D7BE04", VA = "0x1D7BE04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7548", Offset = "0xAB7548")]
			add
			{
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x1D7BEC0", Offset = "0x1D7BEC0", VA = "0x1D7BEC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7558", Offset = "0xAB7558")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action onVoid
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x1D7BF7C", Offset = "0x1D7BF7C", VA = "0x1D7BF7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7568", Offset = "0xAB7568")]
			add
			{
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x1D7C01C", Offset = "0x1D7C01C", VA = "0x1D7C01C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7578", Offset = "0xAB7578")]
			remove
			{
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1D7C0BC", Offset = "0x1D7C0BC", VA = "0x1D7C0BC")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1D7C0E8", Offset = "0x1D7C0E8", VA = "0x1D7C0E8", Slot = "4")]
		public virtual void initialize()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1D7C428", Offset = "0x1D7C428", VA = "0x1D7C428", Slot = "1")]
		~Publisher()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1D7C6B4", Offset = "0x1D7C6B4", VA = "0x1D7C6B4", Slot = "5")]
		public virtual void onSubscriberLoaded(Subscriber tSubscriber)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1D7CA0C", Offset = "0x1D7CA0C", VA = "0x1D7CA0C", Slot = "6")]
		protected virtual void onSubscriberDestroyed(Subscriber tSubscriber)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1D7CE98", Offset = "0x1D7CE98", VA = "0x1D7CE98")]
		public bool addCall(RawCall tCall)
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1D7CF6C", Offset = "0x1D7CF6C", VA = "0x1D7CF6C", Slot = "8")]
		protected virtual void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1D7CFF0", Offset = "0x1D7CFF0", VA = "0x1D7CFF0")]
		public bool removeCall(RawCall tCall)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1D7CD98", Offset = "0x1D7CD98", VA = "0x1D7CD98")]
		public bool removeCall(int tIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1D7D074", Offset = "0x1D7D074", VA = "0x1D7D074", Slot = "9")]
		protected virtual void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1D7C79C", Offset = "0x1D7C79C", VA = "0x1D7C79C")]
		public bool addRequest(Subscriber tSubscriber, RawRequest tRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1D7D0F8", Offset = "0x1D7D0F8", VA = "0x1D7D0F8", Slot = "10")]
		protected virtual void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1D7CAFC", Offset = "0x1D7CAFC", VA = "0x1D7CAFC")]
		public bool removeRequest(Subscriber tSubscriber, RawRequest tRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1D7D17C", Offset = "0x1D7D17C", VA = "0x1D7D17C", Slot = "11")]
		protected virtual void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1D7D200", Offset = "0x1D7D200", VA = "0x1D7D200")]
		public void publish()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Publisher<A> : Publisher
	{
		[Token(Token = "0x17000006")]
		public override Type[] types
		{
			[Token(Token = "0x600007F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<A> onEvent
		{
			[Token(Token = "0x600007B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7588", Offset = "0xAB7588")]
			add
			{
			}
			[Token(Token = "0x600007C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7598", Offset = "0xAB7598")]
			remove
			{
			}
		}

		[Token(Token = "0x600007D")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x600007E")]
		~Publisher()
		{
		}

		[Token(Token = "0x6000080")]
		protected override void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x6000081")]
		protected override void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x6000082")]
		protected override void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x6000083")]
		protected override void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x6000084")]
		public void publish(A tA)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class Publisher<A, B> : Publisher
	{
		[Token(Token = "0x17000007")]
		public override Type[] types
		{
			[Token(Token = "0x6000089")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<A, B> onEvent
		{
			[Token(Token = "0x6000085")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB75A8", Offset = "0xAB75A8")]
			add
			{
			}
			[Token(Token = "0x6000086")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB75B8", Offset = "0xAB75B8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000087")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x6000088")]
		~Publisher()
		{
		}

		[Token(Token = "0x600008A")]
		protected override void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x600008B")]
		protected override void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x600008C")]
		protected override void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x600008D")]
		protected override void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x600008E")]
		public void publish(A tA, B tB)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class Publisher<A, B, C> : Publisher
	{
		[Token(Token = "0x17000008")]
		public override Type[] types
		{
			[Token(Token = "0x6000093")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000005")]
		public event Action<A, B, C> onEvent
		{
			[Token(Token = "0x600008F")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB75C8", Offset = "0xAB75C8")]
			add
			{
			}
			[Token(Token = "0x6000090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB75D8", Offset = "0xAB75D8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000091")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x6000092")]
		~Publisher()
		{
		}

		[Token(Token = "0x6000094")]
		protected override void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x6000095")]
		protected override void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x6000096")]
		protected override void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x6000097")]
		protected override void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x6000098")]
		public void publish(A tA, B tB, C tC)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Publisher<A, B, C, D> : Publisher
	{
		[Token(Token = "0x17000009")]
		public override Type[] types
		{
			[Token(Token = "0x600009D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000006")]
		public event Action<A, B, C, D> onEvent
		{
			[Token(Token = "0x6000099")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB75E8", Offset = "0xAB75E8")]
			add
			{
			}
			[Token(Token = "0x600009A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB75F8", Offset = "0xAB75F8")]
			remove
			{
			}
		}

		[Token(Token = "0x600009B")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x600009C")]
		~Publisher()
		{
		}

		[Token(Token = "0x600009E")]
		protected override void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x600009F")]
		protected override void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x60000A0")]
		protected override void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000A1")]
		protected override void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000A2")]
		public void publish(A tA, B tB, C tC, D tD)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class Publisher<A, B, C, D, E> : Publisher
	{
		[Token(Token = "0x1700000A")]
		public override Type[] types
		{
			[Token(Token = "0x60000A7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<A, B, C, D, E> onEvent
		{
			[Token(Token = "0x60000A3")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7608", Offset = "0xAB7608")]
			add
			{
			}
			[Token(Token = "0x60000A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7618", Offset = "0xAB7618")]
			remove
			{
			}
		}

		[Token(Token = "0x60000A5")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x60000A6")]
		~Publisher()
		{
		}

		[Token(Token = "0x60000A8")]
		protected override void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x60000A9")]
		protected override void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x60000AA")]
		protected override void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000AB")]
		protected override void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000AC")]
		public void publish(A tA, B tB, C tC, D tD, E tE)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Publisher<A, B, C, D, E, F> : Publisher
	{
		[Token(Token = "0x1700000B")]
		public override Type[] types
		{
			[Token(Token = "0x60000B1")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000008")]
		public event Action<A, B, C, D, E, F> onEvent
		{
			[Token(Token = "0x60000AD")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7628", Offset = "0xAB7628")]
			add
			{
			}
			[Token(Token = "0x60000AE")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7638", Offset = "0xAB7638")]
			remove
			{
			}
		}

		[Token(Token = "0x60000AF")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x60000B0")]
		~Publisher()
		{
		}

		[Token(Token = "0x60000B2")]
		protected override void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x60000B3")]
		protected override void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x60000B4")]
		protected override void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000B5")]
		protected override void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000B6")]
		public void publish(A tA, B tB, C tC, D tD, E tE, F tF)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class Publisher<A, B, C, D, E, F, G> : Publisher
	{
		[Token(Token = "0x1700000C")]
		public override Type[] types
		{
			[Token(Token = "0x60000BB")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000009")]
		public event Action<A, B, C, D, E, F, G> onEvent
		{
			[Token(Token = "0x60000B7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7648", Offset = "0xAB7648")]
			add
			{
			}
			[Token(Token = "0x60000B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7658", Offset = "0xAB7658")]
			remove
			{
			}
		}

		[Token(Token = "0x60000B9")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x60000BA")]
		~Publisher()
		{
		}

		[Token(Token = "0x60000BC")]
		protected override void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x60000BD")]
		protected override void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x60000BE")]
		protected override void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000BF")]
		protected override void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000C0")]
		public void publish(A tA, B tB, C tC, D tD, E tE, F tF, G tG)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class Publisher<A, B, C, D, E, F, G, H> : Publisher
	{
		[Token(Token = "0x1700000D")]
		public override Type[] types
		{
			[Token(Token = "0x60000C5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action<A, B, C, D, E, F, G, H> onEvent
		{
			[Token(Token = "0x60000C1")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7668", Offset = "0xAB7668")]
			add
			{
			}
			[Token(Token = "0x60000C2")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7678", Offset = "0xAB7678")]
			remove
			{
			}
		}

		[Token(Token = "0x60000C3")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x60000C4")]
		~Publisher()
		{
		}

		[Token(Token = "0x60000C6")]
		protected override void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x60000C7")]
		protected override void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x60000C8")]
		protected override void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000C9")]
		protected override void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000CA")]
		public void publish(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH)
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class Publisher<A, B, C, D, E, F, G, H, I> : Publisher
	{
		[Token(Token = "0x1700000E")]
		public override Type[] types
		{
			[Token(Token = "0x60000CF")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action<A, B, C, D, E, F, G, H, I> onEvent
		{
			[Token(Token = "0x60000CB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7688", Offset = "0xAB7688")]
			add
			{
			}
			[Token(Token = "0x60000CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB7698", Offset = "0xAB7698")]
			remove
			{
			}
		}

		[Token(Token = "0x60000CD")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x60000CE")]
		~Publisher()
		{
		}

		[Token(Token = "0x60000D0")]
		protected override void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x60000D1")]
		protected override void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x60000D2")]
		protected override void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000D3")]
		protected override void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000D4")]
		public void publish(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class Publisher<A, B, C, D, E, F, G, H, I, J> : Publisher
	{
		[Token(Token = "0x1700000F")]
		public override Type[] types
		{
			[Token(Token = "0x60000D9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action<A, B, C, D, E, F, G, H, I, J> onEvent
		{
			[Token(Token = "0x60000D5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB76A8", Offset = "0xAB76A8")]
			add
			{
			}
			[Token(Token = "0x60000D6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB76B8", Offset = "0xAB76B8")]
			remove
			{
			}
		}

		[Token(Token = "0x60000D7")]
		public Publisher([Optional] string tTag)
		{
		}

		[Token(Token = "0x60000D8")]
		~Publisher()
		{
		}

		[Token(Token = "0x60000DA")]
		protected override void effectsCallAdded(RawCall tCall)
		{
		}

		[Token(Token = "0x60000DB")]
		protected override void effectsCallRemoved(RawCall tCall, int tIndex)
		{
		}

		[Token(Token = "0x60000DC")]
		protected override void effectsRequestAdded(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000DD")]
		protected override void effectsRequestRemoved(Subscriber tSubscriber, RawRequest tRequest)
		{
		}

		[Token(Token = "0x60000DE")]
		public void publish(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI, J tJ)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class RawArgument
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string type;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEngine.Object objectValue;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string stringValue;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected float _x1;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected float _x2;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected float _y1;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected float _y2;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected float _z1;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected float _z2;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long longValue;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double doubleValue;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve animationCurveValue;

		[Token(Token = "0x17000010")]
		public virtual object genericValue
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x1D7D214", Offset = "0x1D7D214", VA = "0x1D7D214", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public bool boolValue
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x1D7D920", Offset = "0x1D7D920", VA = "0x1D7D920")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x1D7DBF8", Offset = "0x1D7DBF8", VA = "0x1D7DBF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public int intValue
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x1D7D930", Offset = "0x1D7D930", VA = "0x1D7D930")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x1D7DC20", Offset = "0x1D7DC20", VA = "0x1D7DC20")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Enum enumValue
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1D7DA9C", Offset = "0x1D7DA9C", VA = "0x1D7DA9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x1D7DC2C", Offset = "0x1D7DC2C", VA = "0x1D7DC2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float floatValue
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x1D7DCA8", Offset = "0x1D7DCA8", VA = "0x1D7DCA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1D7DCB0", Offset = "0x1D7DCB0", VA = "0x1D7DCB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Vector2 vector2Value
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1D7D93C", Offset = "0x1D7D93C", VA = "0x1D7D93C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1D7DCB8", Offset = "0x1D7DCB8", VA = "0x1D7DCB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 vector3Value
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x1D7D948", Offset = "0x1D7D948", VA = "0x1D7D948")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1D7DCC4", Offset = "0x1D7DCC4", VA = "0x1D7DCC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Vector4 vector4Value
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x1D7D98C", Offset = "0x1D7D98C", VA = "0x1D7D98C")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1D7DCD4", Offset = "0x1D7DCD4", VA = "0x1D7DCD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Quaternion quaternionValue
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1D7D9C8", Offset = "0x1D7D9C8", VA = "0x1D7D9C8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1D7DCE4", Offset = "0x1D7DCE4", VA = "0x1D7DCE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Rect rectValue
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1D7DA04", Offset = "0x1D7DA04", VA = "0x1D7DA04")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1D7DCF4", Offset = "0x1D7DCF4", VA = "0x1D7DCF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Bounds boundsValue
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x1D7DA40", Offset = "0x1D7DA40", VA = "0x1D7DA40")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x1D7DD60", Offset = "0x1D7DD60", VA = "0x1D7DD60")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Color colorValue
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1D7DA60", Offset = "0x1D7DA60", VA = "0x1D7DA60")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1D7DDE0", Offset = "0x1D7DDE0", VA = "0x1D7DDE0")]
			set
			{
			}
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1D7DDF0", Offset = "0x1D7DDF0", VA = "0x1D7DDF0")]
		public RawArgument()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class RawCall : RawDelegate
	{
		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6850", Offset = "0xAB6850")]
		private sealed class <>c__DisplayClass8_0<T, A>
		{
			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T tTarget;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400009B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, A> tempSetter;

			[Token(Token = "0x6000154")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000155")]
			internal void <createFieldAction>b__0(A tA)
			{
			}
		}

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6860", Offset = "0xAB6860")]
		private sealed class <>c__DisplayClass9_0<T, A>
		{
			[Token(Token = "0x400009C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T tTarget;

			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, A> tempSetter;

			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tValue;

			[Token(Token = "0x6000156")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000157")]
			internal void <createFieldCall>b__0()
			{
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6870", Offset = "0xAB6870")]
		private sealed class <>c__DisplayClass10_0<A>
		{
			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A> tempDelegate;

			[Token(Token = "0x6000158")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000159")]
			internal void <createPropertyAction>b__0(A tA)
			{
			}
		}

		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6880", Offset = "0xAB6880")]
		private sealed class <>c__DisplayClass11_0<A>
		{
			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A> tempDelegate;

			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tValue;

			[Token(Token = "0x600015A")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600015B")]
			internal void <createPropertyCall>b__0()
			{
			}
		}

		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6890", Offset = "0xAB6890")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RawCall <>4__this;

			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Publisher tPublisher;

			[Token(Token = "0x40000AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action tempDelegate;

			[Token(Token = "0x600015C")]
			[Address(RVA = "0x1D7EF6C", Offset = "0x1D7EF6C", VA = "0x1D7EF6C")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1D8098C", Offset = "0x1D8098C", VA = "0x1D8098C")]
			internal void <createActionCall0>b__0()
			{
			}
		}

		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB68A0", Offset = "0xAB68A0")]
		private sealed class <>c__DisplayClass13_0<A>
		{
			[Token(Token = "0x40000AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A> tempDelegate;

			[Token(Token = "0x600015E")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x600015F")]
			internal void <createAction1>b__0(A tA)
			{
			}
		}

		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB68B0", Offset = "0xAB68B0")]
		private sealed class <>c__DisplayClass14_0<A>
		{
			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A> tempDelegate;

			[Token(Token = "0x40000B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x6000160")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000161")]
			internal void <createActionCall1>b__0()
			{
			}
		}

		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB68C0", Offset = "0xAB68C0")]
		private sealed class <>c__DisplayClass15_0<A, B>
		{
			[Token(Token = "0x40000B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B> tempDelegate;

			[Token(Token = "0x6000162")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000163")]
			internal void <createAction2>b__0(A tA, B tB)
			{
			}
		}

		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB68D0", Offset = "0xAB68D0")]
		private sealed class <>c__DisplayClass16_0<A, B>
		{
			[Token(Token = "0x40000B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B> tempDelegate;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x6000164")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000165")]
			internal void <createActionCall2>b__0()
			{
			}
		}

		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB68E0", Offset = "0xAB68E0")]
		private sealed class <>c__DisplayClass17_0<A, B, C>
		{
			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C> tempDelegate;

			[Token(Token = "0x6000166")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6000167")]
			internal void <createAction3>b__0(A tA, B tB, C tC)
			{
			}
		}

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB68F0", Offset = "0xAB68F0")]
		private sealed class <>c__DisplayClass18_0<A, B, C>
		{
			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C> tempDelegate;

			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x6000168")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000169")]
			internal void <createActionCall3>b__0()
			{
			}
		}

		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6900", Offset = "0xAB6900")]
		private sealed class <>c__DisplayClass19_0<A, B, C, D>
		{
			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D> tempDelegate;

			[Token(Token = "0x600016A")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x600016B")]
			internal void <createAction4>b__0(A tA, B tB, C tC, D tD)
			{
			}
		}

		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6910", Offset = "0xAB6910")]
		private sealed class <>c__DisplayClass20_0<A, B, C, D>
		{
			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D> tempDelegate;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x600016C")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x600016D")]
			internal void <createActionCall4>b__0()
			{
			}
		}

		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6920", Offset = "0xAB6920")]
		private sealed class <>c__DisplayClass21_0<A, B, C, D, E>
		{
			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E> tempDelegate;

			[Token(Token = "0x600016E")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x600016F")]
			internal void <createAction5>b__0(A tA, B tB, C tC, D tD, E tE)
			{
			}
		}

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6930", Offset = "0xAB6930")]
		private sealed class <>c__DisplayClass22_0<A, B, C, D, E>
		{
			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E> tempDelegate;

			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x40000D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x40000D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x40000D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x6000170")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000171")]
			internal void <createActionCall5>b__0()
			{
			}
		}

		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6940", Offset = "0xAB6940")]
		private sealed class <>c__DisplayClass23_0<A, B, C, D, E, F>
		{
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E, F> tempDelegate;

			[Token(Token = "0x6000172")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000173")]
			internal void <createAction6>b__0(A tA, B tB, C tC, D tD, E tE, F tF)
			{
			}
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6950", Offset = "0xAB6950")]
		private sealed class <>c__DisplayClass24_0<A, B, C, D, E, F>
		{
			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E, F> tempDelegate;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public F tF;

			[Token(Token = "0x6000174")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000175")]
			internal void <createActionCall6>b__0()
			{
			}
		}

		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6960", Offset = "0xAB6960")]
		private sealed class <>c__DisplayClass25_0<A, B, C, D, E, F, G>
		{
			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E, F, G> tempDelegate;

			[Token(Token = "0x6000176")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000177")]
			internal void <createAction7>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG)
			{
			}
		}

		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6970", Offset = "0xAB6970")]
		private sealed class <>c__DisplayClass26_0<A, B, C, D, E, F, G>
		{
			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E, F, G> tempDelegate;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public F tF;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public G tG;

			[Token(Token = "0x6000178")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000179")]
			internal void <createActionCall7>b__0()
			{
			}
		}

		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6980", Offset = "0xAB6980")]
		private sealed class <>c__DisplayClass27_0<A, B, C, D, E, F, G, H>
		{
			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E, F, G, H> tempDelegate;

			[Token(Token = "0x600017A")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x600017B")]
			internal void <createAction8>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH)
			{
			}
		}

		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6990", Offset = "0xAB6990")]
		private sealed class <>c__DisplayClass28_0<A, B, C, D, E, F, G, H>
		{
			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E, F, G, H> tempDelegate;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public F tF;

			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public G tG;

			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public H tH;

			[Token(Token = "0x600017C")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x600017D")]
			internal void <createActionCall8>b__0()
			{
			}
		}

		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB69A0", Offset = "0xAB69A0")]
		private sealed class <>c__DisplayClass29_0<A, B, C, D, E, F, G, H, I>
		{
			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E, F, G, H, I> tempDelegate;

			[Token(Token = "0x600017E")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x600017F")]
			internal void <createAction9>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI)
			{
			}
		}

		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB69B0", Offset = "0xAB69B0")]
		private sealed class <>c__DisplayClass30_0<A, B, C, D, E, F, G, H, I>
		{
			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E, F, G, H, I> tempDelegate;

			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public F tF;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public G tG;

			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public H tH;

			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public I tI;

			[Token(Token = "0x6000180")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000181")]
			internal void <createActionCall9>b__0()
			{
			}
		}

		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB69C0", Offset = "0xAB69C0")]
		private sealed class <>c__DisplayClass31_0<A, B, C, D, E, F, G, H, I, J>
		{
			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E, F, G, H, I, J> tempDelegate;

			[Token(Token = "0x6000182")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000183")]
			internal void <createAction10>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI, J tJ)
			{
			}
		}

		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB69D0", Offset = "0xAB69D0")]
		private sealed class <>c__DisplayClass32_0<A, B, C, D, E, F, G, H, I, J>
		{
			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<A, B, C, D, E, F, G, H, I, J> tempDelegate;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public F tF;

			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public G tG;

			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public H tH;

			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public I tI;

			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public J tJ;

			[Token(Token = "0x6000184")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000185")]
			internal void <createActionCall10>b__0()
			{
			}
		}

		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB69E0", Offset = "0xAB69E0")]
		private sealed class <>c__DisplayClass33_0<T>
		{
			[Token(Token = "0x400011E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400011F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> tempDelegate;

			[Token(Token = "0x6000186")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000187")]
			internal void <createFuncCall0>b__0()
			{
			}
		}

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB69F0", Offset = "0xAB69F0")]
		private sealed class <>c__DisplayClass34_0<A, T>
		{
			[Token(Token = "0x4000121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, T> tempDelegate;

			[Token(Token = "0x6000188")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000189")]
			internal void <createFunc1>b__0(A tA)
			{
			}
		}

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6A00", Offset = "0xAB6A00")]
		private sealed class <>c__DisplayClass35_0<A, T>
		{
			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, T> tempDelegate;

			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x600018A")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x600018B")]
			internal void <createFuncCall1>b__0()
			{
			}
		}

		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6A10", Offset = "0xAB6A10")]
		private sealed class <>c__DisplayClass36_0<A, B, T>
		{
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, T> tempDelegate;

			[Token(Token = "0x600018C")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600018D")]
			internal void <createFunc2>b__0(A tA, B tB)
			{
			}
		}

		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6A20", Offset = "0xAB6A20")]
		private sealed class <>c__DisplayClass37_0<A, B, T>
		{
			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, T> tempDelegate;

			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x600018E")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x600018F")]
			internal void <createFuncCall2>b__0()
			{
			}
		}

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6A30", Offset = "0xAB6A30")]
		private sealed class <>c__DisplayClass38_0<A, B, C, T>
		{
			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, T> tempDelegate;

			[Token(Token = "0x6000190")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000191")]
			internal void <createFunc3>b__0(A tA, B tB, C tC)
			{
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6A40", Offset = "0xAB6A40")]
		private sealed class <>c__DisplayClass39_0<A, B, C, T>
		{
			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, T> tempDelegate;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x6000192")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000193")]
			internal void <createFuncCall3>b__0()
			{
			}
		}

		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6A50", Offset = "0xAB6A50")]
		private sealed class <>c__DisplayClass40_0<A, B, C, D, T>
		{
			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, T> tempDelegate;

			[Token(Token = "0x6000194")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000195")]
			internal void <createFunc4>b__0(A tA, B tB, C tC, D tD)
			{
			}
		}

		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6A60", Offset = "0xAB6A60")]
		private sealed class <>c__DisplayClass41_0<A, B, C, D, T>
		{
			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, T> tempDelegate;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x6000196")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000197")]
			internal void <createFuncCall4>b__0()
			{
			}
		}

		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6A70", Offset = "0xAB6A70")]
		private sealed class <>c__DisplayClass42_0<A, B, C, D, E, T>
		{
			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, T> tempDelegate;

			[Token(Token = "0x6000198")]
			public <>c__DisplayClass42_0()
			{
			}

			[Token(Token = "0x6000199")]
			internal void <createFunc5>b__0(A tA, B tB, C tC, D tD, E tE)
			{
			}
		}

		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6A80", Offset = "0xAB6A80")]
		private sealed class <>c__DisplayClass43_0<A, B, C, D, E, T>
		{
			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, T> tempDelegate;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x600019A")]
			public <>c__DisplayClass43_0()
			{
			}

			[Token(Token = "0x600019B")]
			internal void <createFuncCall5>b__0()
			{
			}
		}

		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6A90", Offset = "0xAB6A90")]
		private sealed class <>c__DisplayClass44_0<A, B, C, D, E, F, T>
		{
			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, T> tempDelegate;

			[Token(Token = "0x600019C")]
			public <>c__DisplayClass44_0()
			{
			}

			[Token(Token = "0x600019D")]
			internal void <createFunc6>b__0(A tA, B tB, C tC, D tD, E tE, F tF)
			{
			}
		}

		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6AA0", Offset = "0xAB6AA0")]
		private sealed class <>c__DisplayClass45_0<A, B, C, D, E, F, T>
		{
			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, T> tempDelegate;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public F tF;

			[Token(Token = "0x600019E")]
			public <>c__DisplayClass45_0()
			{
			}

			[Token(Token = "0x600019F")]
			internal void <createFuncCall6>b__0()
			{
			}
		}

		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6AB0", Offset = "0xAB6AB0")]
		private sealed class <>c__DisplayClass46_0<A, B, C, D, E, F, G, T>
		{
			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, T> tempDelegate;

			[Token(Token = "0x60001A0")]
			public <>c__DisplayClass46_0()
			{
			}

			[Token(Token = "0x60001A1")]
			internal void <createFunc7>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG)
			{
			}
		}

		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6AC0", Offset = "0xAB6AC0")]
		private sealed class <>c__DisplayClass47_0<A, B, C, D, E, F, G, T>
		{
			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, T> tempDelegate;

			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public F tF;

			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public G tG;

			[Token(Token = "0x60001A2")]
			public <>c__DisplayClass47_0()
			{
			}

			[Token(Token = "0x60001A3")]
			internal void <createFuncCall7>b__0()
			{
			}
		}

		[Token(Token = "0x2000055")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6AD0", Offset = "0xAB6AD0")]
		private sealed class <>c__DisplayClass48_0<A, B, C, D, E, F, G, H, T>
		{
			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, H, T> tempDelegate;

			[Token(Token = "0x60001A4")]
			public <>c__DisplayClass48_0()
			{
			}

			[Token(Token = "0x60001A5")]
			internal void <createFunc8>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH)
			{
			}
		}

		[Token(Token = "0x2000056")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6AE0", Offset = "0xAB6AE0")]
		private sealed class <>c__DisplayClass49_0<A, B, C, D, E, F, G, H, T>
		{
			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, H, T> tempDelegate;

			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public F tF;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public G tG;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public H tH;

			[Token(Token = "0x60001A6")]
			public <>c__DisplayClass49_0()
			{
			}

			[Token(Token = "0x60001A7")]
			internal void <createFuncCall8>b__0()
			{
			}
		}

		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6AF0", Offset = "0xAB6AF0")]
		private sealed class <>c__DisplayClass50_0<A, B, C, D, E, F, G, H, I, T>
		{
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, H, I, T> tempDelegate;

			[Token(Token = "0x60001A8")]
			public <>c__DisplayClass50_0()
			{
			}

			[Token(Token = "0x60001A9")]
			internal void <createFunc9>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI)
			{
			}
		}

		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6B00", Offset = "0xAB6B00")]
		private sealed class <>c__DisplayClass51_0<A, B, C, D, E, F, G, H, I, T>
		{
			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, H, I, T> tempDelegate;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public F tF;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public G tG;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public H tH;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public I tI;

			[Token(Token = "0x60001AA")]
			public <>c__DisplayClass51_0()
			{
			}

			[Token(Token = "0x60001AB")]
			internal void <createFuncCall9>b__0()
			{
			}
		}

		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6B10", Offset = "0xAB6B10")]
		private sealed class <>c__DisplayClass52_0<A, B, C, D, E, F, G, H, I, J, T>
		{
			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, H, I, J, T> tempDelegate;

			[Token(Token = "0x60001AC")]
			public <>c__DisplayClass52_0()
			{
			}

			[Token(Token = "0x60001AD")]
			internal void <createFunc10>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI, J tJ)
			{
			}
		}

		[Token(Token = "0x200005A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6B20", Offset = "0xAB6B20")]
		private sealed class <>c__DisplayClass53_0<A, B, C, D, E, F, G, H, I, J, T>
		{
			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RawCall <>4__this;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Publisher tPublisher;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, H, I, J, T> tempDelegate;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public A tA;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public B tB;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public C tC;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public D tD;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public E tE;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public F tF;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public G tG;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public H tH;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public I tI;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public J tJ;

			[Token(Token = "0x60001AE")]
			public <>c__DisplayClass53_0()
			{
			}

			[Token(Token = "0x60001AF")]
			internal void <createFuncCall10>b__0()
			{
			}
		}

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected RawArgument[] _arguments;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool _isDynamic;

		[Token(Token = "0x1700001C")]
		public RawArgument[] arguments
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1D7E1D0", Offset = "0x1D7E1D0", VA = "0x1D7E1D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public bool isDynamic
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1D7E1D8", Offset = "0x1D7E1D8", VA = "0x1D7E1D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1D7DDF8", Offset = "0x1D7DDF8", VA = "0x1D7DDF8", Slot = "6")]
		public virtual void initialize(Publisher tPublisher)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1D7E1E0", Offset = "0x1D7E1E0", VA = "0x1D7E1E0", Slot = "7")]
		public virtual Delegate createDelegate(Publisher tPublisher, MemberInfo tMember)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		protected virtual Action<A> createFieldAction<T, A>(Publisher tPublisher, T tTarget, FieldInfo tField)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		protected virtual Action createFieldCall<T, A>(Publisher tPublisher, T tTarget, FieldInfo tField, A tValue)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		protected virtual Action<A> createPropertyAction<A>(Publisher tPublisher, PropertyInfo tProperty)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		protected virtual Action createPropertyCall<A>(Publisher tPublisher, PropertyInfo tProperty, A tValue)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1D7EE2C", Offset = "0x1D7EE2C", VA = "0x1D7EE2C", Slot = "12")]
		protected virtual Action createActionCall0(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		protected virtual Action<A> createAction1<A>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		protected virtual Action createActionCall1<A>(Publisher tPublisher, MethodInfo tMethod, A tA)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		protected virtual Action<A, B> createAction2<A, B>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		protected virtual Action createActionCall2<A, B>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB)
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		protected virtual Action<A, B, C> createAction3<A, B, C>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		protected virtual Action createActionCall3<A, B, C>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		protected virtual Action<A, B, C, D> createAction4<A, B, C, D>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		protected virtual Action createActionCall4<A, B, C, D>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD)
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		protected virtual Action<A, B, C, D, E> createAction5<A, B, C, D, E>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		protected virtual Action createActionCall5<A, B, C, D, E>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		protected virtual Action<A, B, C, D, E, F> createAction6<A, B, C, D, E, F>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		protected virtual Action createActionCall6<A, B, C, D, E, F>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE, F tF)
		{
			return null;
		}

		[Token(Token = "0x600010C")]
		protected virtual Action<A, B, C, D, E, F, G> createAction7<A, B, C, D, E, F, G>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600010D")]
		protected virtual Action createActionCall7<A, B, C, D, E, F, G>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE, F tF, G tG)
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		protected virtual Action<A, B, C, D, E, F, G, H> createAction8<A, B, C, D, E, F, G, H>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		protected virtual Action createActionCall8<A, B, C, D, E, F, G, H>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH)
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		protected virtual Action<A, B, C, D, E, F, G, H, I> createAction9<A, B, C, D, E, F, G, H, I>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		protected virtual Action createActionCall9<A, B, C, D, E, F, G, H, I>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		protected virtual Action<A, B, C, D, E, F, G, H, I, J> createAction10<A, B, C, D, E, F, G, H, I, J>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		protected virtual Action createActionCall10<A, B, C, D, E, F, G, H, I, J>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI, J tJ)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		protected virtual Action createFuncCall0<T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		protected virtual Action<A> createFunc1<A, T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		protected virtual Action createFuncCall1<A, T>(Publisher tPublisher, MethodInfo tMethod, A tA)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		protected virtual Action<A, B> createFunc2<A, B, T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		protected virtual Action createFuncCall2<A, B, T>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		protected virtual Action<A, B, C> createFunc3<A, B, C, T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		protected virtual Action createFuncCall3<A, B, C, T>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		protected virtual Action<A, B, C, D> createFunc4<A, B, C, D, T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		protected virtual Action createFuncCall4<A, B, C, D, T>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		protected virtual Action<A, B, C, D, E> createFunc5<A, B, C, D, E, T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		protected virtual Action createFuncCall5<A, B, C, D, E, T>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		protected virtual Action<A, B, C, D, E, F> createFunc6<A, B, C, D, E, F, T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		protected virtual Action createFuncCall6<A, B, C, D, E, F, T>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE, F tF)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		protected virtual Action<A, B, C, D, E, F, G> createFunc7<A, B, C, D, E, F, G, T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		protected virtual Action createFuncCall7<A, B, C, D, E, F, G, T>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE, F tF, G tG)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		protected virtual Action<A, B, C, D, E, F, G, H> createFunc8<A, B, C, D, E, F, G, H, T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		protected virtual Action createFuncCall8<A, B, C, D, E, F, G, H, T>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		protected virtual Action<A, B, C, D, E, F, G, H, I> createFunc9<A, B, C, D, E, F, G, H, I, T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		protected virtual Action createFuncCall9<A, B, C, D, E, F, G, H, I, T>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		protected virtual Action<A, B, C, D, E, F, G, H, I, J> createFunc10<A, B, C, D, E, F, G, H, I, J, T>(Publisher tPublisher, MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		protected virtual Action createFuncCall10<A, B, C, D, E, F, G, H, I, J, T>(Publisher tPublisher, MethodInfo tMethod, A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI, J tJ)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1D7EF74", Offset = "0x1D7EF74", VA = "0x1D7EF74")]
		public RawCall()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class RawDelegate
	{
		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6B30", Offset = "0xAB6B30")]
		private sealed class <>c__DisplayClass11_0<T, A>
		{
			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, A> tempSetter;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T tTarget;

			[Token(Token = "0x60001B0")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60001B1")]
			internal void <CreateFieldAction>b__0(A tA)
			{
			}
		}

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected UnityEngine.Object _target;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string _member;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Delegate _delegateInstance;

		[Token(Token = "0x1700001E")]
		public UnityEngine.Object target
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1D7F038", Offset = "0x1D7F038", VA = "0x1D7F038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public string member
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1D7F040", Offset = "0x1D7F040", VA = "0x1D7F040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public Delegate delegateInstance
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1D7F048", Offset = "0x1D7F048", VA = "0x1D7F048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1D7EF84", Offset = "0x1D7EF84", VA = "0x1D7EF84", Slot = "4")]
		public virtual void initialize()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1D7F050", Offset = "0x1D7F050", VA = "0x1D7F050", Slot = "5")]
		public virtual Delegate createDelegate(MemberInfo tMember)
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		protected static Action<A> CreateFieldAction<T, A>(T tTarget, FieldInfo tField)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		protected static Action<T, A> CreateFieldSetter<T, A>(FieldInfo tField)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1D7EF7C", Offset = "0x1D7EF7C", VA = "0x1D7EF7C")]
		public RawDelegate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class RawRequest : RawDelegate
	{
		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6B40", Offset = "0xAB6B40")]
		private sealed class <>c__DisplayClass4_0<T>
		{
			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> tempDelegate;

			[Token(Token = "0x60001B2")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60001B3")]
			internal void <createFunc0>b__0()
			{
			}
		}

		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6B50", Offset = "0xAB6B50")]
		private sealed class <>c__DisplayClass5_0<A, T>
		{
			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, T> tempDelegate;

			[Token(Token = "0x60001B4")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60001B5")]
			internal void <createFunc1>b__0(A tA)
			{
			}
		}

		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6B60", Offset = "0xAB6B60")]
		private sealed class <>c__DisplayClass6_0<A, B, T>
		{
			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, T> tempDelegate;

			[Token(Token = "0x60001B6")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60001B7")]
			internal void <createFunc2>b__0(A tA, B tB)
			{
			}
		}

		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6B70", Offset = "0xAB6B70")]
		private sealed class <>c__DisplayClass7_0<A, B, C, T>
		{
			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, T> tempDelegate;

			[Token(Token = "0x60001B8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60001B9")]
			internal void <createFunc3>b__0(A tA, B tB, C tC)
			{
			}
		}

		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6B80", Offset = "0xAB6B80")]
		private sealed class <>c__DisplayClass8_0<A, B, C, D, T>
		{
			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, T> tempDelegate;

			[Token(Token = "0x60001BA")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60001BB")]
			internal void <createFunc4>b__0(A tA, B tB, C tC, D tD)
			{
			}
		}

		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6B90", Offset = "0xAB6B90")]
		private sealed class <>c__DisplayClass9_0<A, B, C, D, E, T>
		{
			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, T> tempDelegate;

			[Token(Token = "0x60001BC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60001BD")]
			internal void <createFunc5>b__0(A tA, B tB, C tC, D tD, E tE)
			{
			}
		}

		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6BA0", Offset = "0xAB6BA0")]
		private sealed class <>c__DisplayClass10_0<A, B, C, D, E, F, T>
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, T> tempDelegate;

			[Token(Token = "0x60001BE")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60001BF")]
			internal void <createFunc6>b__0(A tA, B tB, C tC, D tD, E tE, F tF)
			{
			}
		}

		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6BB0", Offset = "0xAB6BB0")]
		private sealed class <>c__DisplayClass11_0<A, B, C, D, E, F, G, T>
		{
			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, T> tempDelegate;

			[Token(Token = "0x60001C0")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60001C1")]
			internal void <createFunc7>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG)
			{
			}
		}

		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6BC0", Offset = "0xAB6BC0")]
		private sealed class <>c__DisplayClass12_0<A, B, C, D, E, F, G, H, T>
		{
			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, H, T> tempDelegate;

			[Token(Token = "0x60001C2")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60001C3")]
			internal void <createFunc8>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH)
			{
			}
		}

		[Token(Token = "0x2000065")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6BD0", Offset = "0xAB6BD0")]
		private sealed class <>c__DisplayClass13_0<A, B, C, D, E, F, G, H, I, T>
		{
			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, H, I, T> tempDelegate;

			[Token(Token = "0x60001C4")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60001C5")]
			internal void <createFunc9>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI)
			{
			}
		}

		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB6BE0", Offset = "0xAB6BE0")]
		private sealed class <>c__DisplayClass14_0<A, B, C, D, E, F, G, H, I, J, T>
		{
			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<A, B, C, D, E, F, G, H, I, J, T> tempDelegate;

			[Token(Token = "0x60001C6")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60001C7")]
			internal void <createFunc10>b__0(A tA, B tB, C tC, D tD, E tE, F tF, G tG, H tH, I tI, J tJ)
			{
			}
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected string[] _tags;

		[Token(Token = "0x17000021")]
		public string[] tags
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1D7F998", Offset = "0x1D7F998", VA = "0x1D7F998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1D7F9A0", Offset = "0x1D7F9A0", VA = "0x1D7F9A0", Slot = "5")]
		public override Delegate createDelegate(MemberInfo tMember)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		protected virtual Action createFunc0<T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		protected virtual Action<A> createFunc1<A, T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		protected virtual Action<A, B> createFunc2<A, B, T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		protected virtual Action<A, B, C> createFunc3<A, B, C, T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		protected virtual Action<A, B, C, D> createFunc4<A, B, C, D, T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		protected virtual Action<A, B, C, D, E> createFunc5<A, B, C, D, E, T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		protected virtual Action<A, B, C, D, E, F> createFunc6<A, B, C, D, E, F, T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		protected virtual Action<A, B, C, D, E, F, G> createFunc7<A, B, C, D, E, F, G, T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		protected virtual Action<A, B, C, D, E, F, G, H> createFunc8<A, B, C, D, E, F, G, H, T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		protected virtual Action<A, B, C, D, E, F, G, H, I> createFunc9<A, B, C, D, E, F, G, H, I, T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		protected virtual Action<A, B, C, D, E, F, G, H, I, J> createFunc10<A, B, C, D, E, F, G, H, I, J, T>(MethodInfo tMethod)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1D7FD34", Offset = "0x1D7FD34", VA = "0x1D7FD34")]
		public RawRequest()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class Subscriber : MonoBehaviour
	{
		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected RawRequest[] _requests;

		[Token(Token = "0x17000022")]
		public RawRequest[] requests
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1D7FFC0", Offset = "0x1D7FFC0", VA = "0x1D7FFC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000D")]
		public static event Action<Subscriber> OnLoaded
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1D7C2AC", Offset = "0x1D7C2AC", VA = "0x1D7C2AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB76C8", Offset = "0xAB76C8")]
			add
			{
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1D7C538", Offset = "0x1D7C538", VA = "0x1D7C538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB76D8", Offset = "0xAB76D8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public static event Action<Subscriber> OnDestroyed
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1D7C368", Offset = "0x1D7C368", VA = "0x1D7C368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB76E8", Offset = "0xAB76E8")]
			add
			{
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1D7C5F4", Offset = "0x1D7C5F4", VA = "0x1D7C5F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAB76F8", Offset = "0xAB76F8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1D7FD90", Offset = "0x1D7FD90", VA = "0x1D7FD90", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1D7FEC8", Offset = "0x1D7FEC8", VA = "0x1D7FEC8", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1D7FF98", Offset = "0x1D7FF98", VA = "0x1D7FF98", Slot = "6")]
		protected virtual void onPublisherLoaded(Publisher tPublisher)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1D7FFC8", Offset = "0x1D7FFC8", VA = "0x1D7FFC8")]
		public Subscriber()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public static class Utility
	{
		[Token(Token = "0x17000023")]
		public static BindingFlags InstanceFlags
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1D7EE24", Offset = "0x1D7EE24", VA = "0x1D7EE24")]
			get
			{
				return default(BindingFlags);
			}
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1D802D8", Offset = "0x1D802D8", VA = "0x1D802D8")]
		public static string Serialize(MemberInfo tInfo)
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1D7DEBC", Offset = "0x1D7DEBC", VA = "0x1D7DEBC")]
		public static MemberInfo Deserialize(Type tType, string tSerialized, BindingFlags tFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1D804F8", Offset = "0x1D804F8", VA = "0x1D804F8")]
		public static string GetKeyword(this Type tType)
		{
			return null;
		}
	}
}
