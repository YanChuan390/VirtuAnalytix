using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class LTDescr
{
	[Token(Token = "0x2000015")]
	public delegate Vector3 EaseTypeDelegate();

	[Token(Token = "0x2000016")]
	public delegate void ActionMethodDelegate();

	[Serializable]
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4836AC", Offset = "0x4836AC")]
	private sealed class <>c
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static ActionMethodDelegate <>9__110_0;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ActionMethodDelegate <>9__111_0;

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1B40B04", Offset = "0x1B40B04", VA = "0x1B40B04")]
		public <>c()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1B40B0C", Offset = "0x1B40B0C", VA = "0x1B40B0C")]
		internal void <setCallback>b__110_0()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1B40B10", Offset = "0x1B40B10", VA = "0x1B40B10")]
		internal void <setValue3>b__111_0()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public bool toggle;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	public bool useEstimatedTime;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
	public bool useFrames;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
	public bool useManualTime;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool usesNormalDt;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public bool hasInitiliazed;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public bool hasExtraOnCompletes;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
	public bool hasPhysics;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool onCompleteOnRepeat;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool onCompleteOnStart;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool useRecursion;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float ratioPassed;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float passed;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float time;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float speed;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float lastVal;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private uint _id;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int loopCount;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public uint counter;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float direction;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float directionLast;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float overshoot;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float period;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float scale;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool destroyOnComplete;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform trans;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public LTRect ltRect;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	internal Vector3 fromInternal;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	internal Vector3 toInternal;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	internal Vector3 diff;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	internal Vector3 diffDiv2;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TweenAction type;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private LeanTweenType easeType;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public LeanTweenType loopType;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool hasUpdateCallback;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public EaseTypeDelegate easeMethod;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4836CC", Offset = "0x4836CC")]
	private ActionMethodDelegate <easeInternal>k__BackingField;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4836DC", Offset = "0x4836DC")]
	private ActionMethodDelegate <initInternal>k__BackingField;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public SpriteRenderer spriteRen;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RectTransform rectTransform;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public Text uiText;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Image uiImage;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public RawImage rawImage;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Sprite[] sprites;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public LTDescrOptional _optional;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float val;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float dt;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Vector3 newVect;

	[Token(Token = "0x17000001")]
	public Vector3 from
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1B2DD30", Offset = "0x1B2DD30", VA = "0x1B2DD30")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1B2DD44", Offset = "0x1B2DD44", VA = "0x1B2DD44")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Vector3 to
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1B2DD50", Offset = "0x1B2DD50", VA = "0x1B2DD50")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1B2DD64", Offset = "0x1B2DD64", VA = "0x1B2DD64")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public ActionMethodDelegate easeInternal
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1B2DD70", Offset = "0x1B2DD70", VA = "0x1B2DD70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48385C", Offset = "0x48385C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1B2DD78", Offset = "0x1B2DD78", VA = "0x1B2DD78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48386C", Offset = "0x48386C")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public ActionMethodDelegate initInternal
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1B2DD80", Offset = "0x1B2DD80", VA = "0x1B2DD80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48387C", Offset = "0x48387C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1B2DD88", Offset = "0x1B2DD88", VA = "0x1B2DD88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48388C", Offset = "0x48388C")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public int uniqueId
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1B2EA30", Offset = "0x1B2EA30", VA = "0x1B2EA30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public int id
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1B2E8AC", Offset = "0x1B2E8AC", VA = "0x1B2E8AC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000007")]
	public LTDescrOptional optional
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1B2EA40", Offset = "0x1B2EA40", VA = "0x1B2EA40")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1B2EA48", Offset = "0x1B2EA48", VA = "0x1B2EA48")]
		set
		{
		}
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1B2DD90", Offset = "0x1B2DD90", VA = "0x1B2DD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1B2E8BC", Offset = "0x1B2E8BC", VA = "0x1B2E8BC")]
	public LTDescr()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1B2E938", Offset = "0x1B2E938", VA = "0x1B2E938")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x48389C", Offset = "0x48389C")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1B2EA50", Offset = "0x1B2EA50", VA = "0x1B2EA50")]
	public void reset()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1B2EC88", Offset = "0x1B2EC88", VA = "0x1B2EC88")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1B2ED50", Offset = "0x1B2ED50", VA = "0x1B2ED50")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1B2EE04", Offset = "0x1B2EE04", VA = "0x1B2EE04")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1B2EEB8", Offset = "0x1B2EEB8", VA = "0x1B2EEB8")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1B2EF6C", Offset = "0x1B2EF6C", VA = "0x1B2EF6C")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1B2F020", Offset = "0x1B2F020", VA = "0x1B2F020")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1B2F0D4", Offset = "0x1B2F0D4", VA = "0x1B2F0D4")]
	private void initFromInternal()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1B2F0E0", Offset = "0x1B2F0E0", VA = "0x1B2F0E0")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1B2F194", Offset = "0x1B2F194", VA = "0x1B2F194")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1B2F248", Offset = "0x1B2F248", VA = "0x1B2F248")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1B2F2FC", Offset = "0x1B2F2FC", VA = "0x1B2F2FC")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1B2F3B0", Offset = "0x1B2F3B0", VA = "0x1B2F3B0")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1B2F464", Offset = "0x1B2F464", VA = "0x1B2F464")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1B2F518", Offset = "0x1B2F518", VA = "0x1B2F518")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1B2F5CC", Offset = "0x1B2F5CC", VA = "0x1B2F5CC")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1B2F680", Offset = "0x1B2F680", VA = "0x1B2F680")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1B2F734", Offset = "0x1B2F734", VA = "0x1B2F734")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1B2F7E8", Offset = "0x1B2F7E8", VA = "0x1B2F7E8")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1B2F89C", Offset = "0x1B2F89C", VA = "0x1B2F89C")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1B2F950", Offset = "0x1B2F950", VA = "0x1B2F950")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1B2FA04", Offset = "0x1B2FA04", VA = "0x1B2FA04")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1B2FAB8", Offset = "0x1B2FAB8", VA = "0x1B2FAB8")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1B2FB6C", Offset = "0x1B2FB6C", VA = "0x1B2FB6C")]
	public LTDescr setColor()
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1B2FC20", Offset = "0x1B2FC20", VA = "0x1B2FC20")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1B2FCD4", Offset = "0x1B2FCD4", VA = "0x1B2FCD4")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1B2FD88", Offset = "0x1B2FD88", VA = "0x1B2FD88")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1B2FE3C", Offset = "0x1B2FE3C", VA = "0x1B2FE3C")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1B2FEF0", Offset = "0x1B2FEF0", VA = "0x1B2FEF0")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1B2FFA4", Offset = "0x1B2FFA4", VA = "0x1B2FFA4")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1B30058", Offset = "0x1B30058", VA = "0x1B30058")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1B3010C", Offset = "0x1B3010C", VA = "0x1B3010C")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1B301C0", Offset = "0x1B301C0", VA = "0x1B301C0")]
	private void initCanvasRotateAround()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1B30224", Offset = "0x1B30224", VA = "0x1B30224")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1B302D8", Offset = "0x1B302D8", VA = "0x1B302D8")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1B3038C", Offset = "0x1B3038C", VA = "0x1B3038C")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1B30440", Offset = "0x1B30440", VA = "0x1B30440")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1B304F4", Offset = "0x1B304F4", VA = "0x1B304F4")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1B305A8", Offset = "0x1B305A8", VA = "0x1B305A8")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1B3065C", Offset = "0x1B3065C", VA = "0x1B3065C")]
	private void callback()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1B3096C", Offset = "0x1B3096C", VA = "0x1B3096C")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1B30AA4", Offset = "0x1B30AA4", VA = "0x1B30AA4")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1B30BDC", Offset = "0x1B30BDC", VA = "0x1B30BDC")]
	public LTDescr setMove()
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1B30C90", Offset = "0x1B30C90", VA = "0x1B30C90")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1B30D44", Offset = "0x1B30D44", VA = "0x1B30D44")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1B30DF8", Offset = "0x1B30DF8", VA = "0x1B30DF8")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1B30EAC", Offset = "0x1B30EAC", VA = "0x1B30EAC")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1B30F60", Offset = "0x1B30F60", VA = "0x1B30F60")]
	public LTDescr setScale()
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1B31014", Offset = "0x1B31014", VA = "0x1B31014")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1B310C8", Offset = "0x1B310C8", VA = "0x1B310C8")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1B3117C", Offset = "0x1B3117C", VA = "0x1B3117C")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1B31230", Offset = "0x1B31230", VA = "0x1B31230")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1B312E4", Offset = "0x1B312E4", VA = "0x1B312E4")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1B31398", Offset = "0x1B31398", VA = "0x1B31398")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1B3144C", Offset = "0x1B3144C", VA = "0x1B3144C")]
	private void init()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1B31A58", Offset = "0x1B31A58", VA = "0x1B31A58")]
	private void initSpeed()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1B31BAC", Offset = "0x1B31BAC", VA = "0x1B31BAC")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1B31BC4", Offset = "0x1B31BC4", VA = "0x1B31BC4")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1B3187C", Offset = "0x1B3187C", VA = "0x1B3187C")]
	public void callOnCompletes()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1B32194", Offset = "0x1B32194", VA = "0x1B32194")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1B3226C", Offset = "0x1B3226C", VA = "0x1B3226C")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1B3284C", Offset = "0x1B3284C", VA = "0x1B3284C")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1B32C84", Offset = "0x1B32C84", VA = "0x1B32C84")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1B33104", Offset = "0x1B33104", VA = "0x1B33104")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1B33520", Offset = "0x1B33520", VA = "0x1B33520")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1B3393C", Offset = "0x1B3393C", VA = "0x1B3393C")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1B33D9C", Offset = "0x1B33D9C", VA = "0x1B33D9C")]
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1B34140", Offset = "0x1B34140", VA = "0x1B34140")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1B344E8", Offset = "0x1B344E8", VA = "0x1B344E8")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1B34884", Offset = "0x1B34884", VA = "0x1B34884")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1B34A30", Offset = "0x1B34A30", VA = "0x1B34A30")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1B34A4C", Offset = "0x1B34A4C", VA = "0x1B34A4C")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1B34A58", Offset = "0x1B34A58", VA = "0x1B34A58")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1B34A94", Offset = "0x1B34A94", VA = "0x1B34A94")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1B34A9C", Offset = "0x1B34A9C", VA = "0x1B34A9C")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1B34C54", Offset = "0x1B34C54", VA = "0x1B34C54")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1B35E84", Offset = "0x1B35E84", VA = "0x1B35E84")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1B34D64", Offset = "0x1B34D64", VA = "0x1B34D64")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1B34CDC", Offset = "0x1B34CDC", VA = "0x1B34CDC")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1B34DEC", Offset = "0x1B34DEC", VA = "0x1B34DEC")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1B34E74", Offset = "0x1B34E74", VA = "0x1B34E74")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1B34EFC", Offset = "0x1B34EFC", VA = "0x1B34EFC")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1B34F84", Offset = "0x1B34F84", VA = "0x1B34F84")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1B3500C", Offset = "0x1B3500C", VA = "0x1B3500C")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1B35094", Offset = "0x1B35094", VA = "0x1B35094")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1B3511C", Offset = "0x1B3511C", VA = "0x1B3511C")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1B351A4", Offset = "0x1B351A4", VA = "0x1B351A4")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1B3522C", Offset = "0x1B3522C", VA = "0x1B3522C")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1B352B4", Offset = "0x1B352B4", VA = "0x1B352B4")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1B3533C", Offset = "0x1B3533C", VA = "0x1B3533C")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1B353C4", Offset = "0x1B353C4", VA = "0x1B353C4")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1B3544C", Offset = "0x1B3544C", VA = "0x1B3544C")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1B354D4", Offset = "0x1B354D4", VA = "0x1B354D4")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1B3555C", Offset = "0x1B3555C", VA = "0x1B3555C")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1B355E4", Offset = "0x1B355E4", VA = "0x1B355E4")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1B3566C", Offset = "0x1B3566C", VA = "0x1B3566C")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1B356F4", Offset = "0x1B356F4", VA = "0x1B356F4")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1B3577C", Offset = "0x1B3577C", VA = "0x1B3577C")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1B35804", Offset = "0x1B35804", VA = "0x1B35804")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1B3588C", Offset = "0x1B3588C", VA = "0x1B3588C")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1B35914", Offset = "0x1B35914", VA = "0x1B35914")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1B3599C", Offset = "0x1B3599C", VA = "0x1B3599C")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1B35A24", Offset = "0x1B35A24", VA = "0x1B35A24")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1B35AAC", Offset = "0x1B35AAC", VA = "0x1B35AAC")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1B35B34", Offset = "0x1B35B34", VA = "0x1B35B34")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1B35BBC", Offset = "0x1B35BBC", VA = "0x1B35BBC")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1B35C44", Offset = "0x1B35C44", VA = "0x1B35C44")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1B35CCC", Offset = "0x1B35CCC", VA = "0x1B35CCC")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1B35DA8", Offset = "0x1B35DA8", VA = "0x1B35DA8")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1B35F0C", Offset = "0x1B35F0C", VA = "0x1B35F0C")]
	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1B3602C", Offset = "0x1B3602C", VA = "0x1B3602C")]
	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1B3612C", Offset = "0x1B3612C", VA = "0x1B3612C")]
	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1B361F4", Offset = "0x1B361F4", VA = "0x1B361F4")]
	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1B36310", Offset = "0x1B36310", VA = "0x1B36310")]
	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1B363D4", Offset = "0x1B363D4", VA = "0x1B363D4")]
	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1B365B0", Offset = "0x1B365B0", VA = "0x1B365B0")]
	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1B3667C", Offset = "0x1B3667C", VA = "0x1B3667C")]
	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1B36764", Offset = "0x1B36764", VA = "0x1B36764")]
	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1B36880", Offset = "0x1B36880", VA = "0x1B36880")]
	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1B3698C", Offset = "0x1B3698C", VA = "0x1B3698C")]
	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1B36A78", Offset = "0x1B36A78", VA = "0x1B36A78")]
	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1B36C38", Offset = "0x1B36C38", VA = "0x1B36C38")]
	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1B36D1C", Offset = "0x1B36D1C", VA = "0x1B36D1C")]
	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1B36E0C", Offset = "0x1B36E0C", VA = "0x1B36E0C")]
	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1B36F38", Offset = "0x1B36F38", VA = "0x1B36F38")]
	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1B37088", Offset = "0x1B37088", VA = "0x1B37088")]
	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1B371C8", Offset = "0x1B371C8", VA = "0x1B371C8")]
	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1B372E4", Offset = "0x1B372E4", VA = "0x1B372E4")]
	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1B373F4", Offset = "0x1B373F4", VA = "0x1B373F4")]
	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1B37508", Offset = "0x1B37508", VA = "0x1B37508")]
	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1B37724", Offset = "0x1B37724", VA = "0x1B37724")]
	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1B3784C", Offset = "0x1B3784C", VA = "0x1B3784C")]
	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1B37988", Offset = "0x1B37988", VA = "0x1B37988")]
	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1B37B48", Offset = "0x1B37B48", VA = "0x1B37B48")]
	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1B37CC0", Offset = "0x1B37CC0", VA = "0x1B37CC0")]
	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1B37EAC", Offset = "0x1B37EAC", VA = "0x1B37EAC")]
	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1B380F8", Offset = "0x1B380F8", VA = "0x1B380F8")]
	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1B38264", Offset = "0x1B38264", VA = "0x1B38264")]
	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1B383A0", Offset = "0x1B383A0", VA = "0x1B383A0")]
	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1B3858C", Offset = "0x1B3858C", VA = "0x1B3858C")]
	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1B386B0", Offset = "0x1B386B0", VA = "0x1B386B0")]
	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1B387D4", Offset = "0x1B387D4", VA = "0x1B387D4")]
	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1B388F8", Offset = "0x1B388F8", VA = "0x1B388F8")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1B38900", Offset = "0x1B38900", VA = "0x1B38900")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1B38908", Offset = "0x1B38908", VA = "0x1B38908")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1B38910", Offset = "0x1B38910", VA = "0x1B38910")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1B389B0", Offset = "0x1B389B0", VA = "0x1B389B0")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1B38A88", Offset = "0x1B38A88", VA = "0x1B38A88")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1B38AB4", Offset = "0x1B38AB4", VA = "0x1B38AB4")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1B38C00", Offset = "0x1B38C00", VA = "0x1B38C00")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1B38C4C", Offset = "0x1B38C4C", VA = "0x1B38C4C")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1B38C58", Offset = "0x1B38C58", VA = "0x1B38C58")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1B38C60", Offset = "0x1B38C60", VA = "0x1B38C60")]
	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1B38C6C", Offset = "0x1B38C6C", VA = "0x1B38C6C")]
	public LTDescr setPassed(float passed)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1B38C74", Offset = "0x1B38C74", VA = "0x1B38C74")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1B38C94", Offset = "0x1B38C94", VA = "0x1B38C94")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1B38CBC", Offset = "0x1B38CBC", VA = "0x1B38CBC")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1B38D08", Offset = "0x1B38D08", VA = "0x1B38D08")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1B38D10", Offset = "0x1B38D10", VA = "0x1B38D10")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1B38D20", Offset = "0x1B38D20", VA = "0x1B38D20")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1B38D30", Offset = "0x1B38D30", VA = "0x1B38D30")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1B38D40", Offset = "0x1B38D40", VA = "0x1B38D40")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1B38D50", Offset = "0x1B38D50", VA = "0x1B38D50")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1B38D60", Offset = "0x1B38D60", VA = "0x1B38D60")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1B38D6C", Offset = "0x1B38D6C", VA = "0x1B38D6C")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1B38D88", Offset = "0x1B38D88", VA = "0x1B38D88")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1B38D90", Offset = "0x1B38D90", VA = "0x1B38D90")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1B38DAC", Offset = "0x1B38DAC", VA = "0x1B38DAC")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1B38DE4", Offset = "0x1B38DE4", VA = "0x1B38DE4")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1B38E18", Offset = "0x1B38E18", VA = "0x1B38E18")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1B38E4C", Offset = "0x1B38E4C", VA = "0x1B38E4C")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1B38EA0", Offset = "0x1B38EA0", VA = "0x1B38EA0")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1B38ED4", Offset = "0x1B38ED4", VA = "0x1B38ED4")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1B38F08", Offset = "0x1B38F08", VA = "0x1B38F08")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1B38F3C", Offset = "0x1B38F3C", VA = "0x1B38F3C")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1B38F70", Offset = "0x1B38F70", VA = "0x1B38F70")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1B38FA4", Offset = "0x1B38FA4", VA = "0x1B38FA4")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1B38FD8", Offset = "0x1B38FD8", VA = "0x1B38FD8")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1B3900C", Offset = "0x1B3900C", VA = "0x1B3900C")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1B39040", Offset = "0x1B39040", VA = "0x1B39040")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1B39074", Offset = "0x1B39074", VA = "0x1B39074")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1B390A8", Offset = "0x1B390A8", VA = "0x1B390A8")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1B390FC", Offset = "0x1B390FC", VA = "0x1B390FC")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1B39150", Offset = "0x1B39150", VA = "0x1B39150")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1B391A4", Offset = "0x1B391A4", VA = "0x1B391A4")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1B391F8", Offset = "0x1B391F8", VA = "0x1B391F8")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1B39224", Offset = "0x1B39224", VA = "0x1B39224")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1B39318", Offset = "0x1B39318", VA = "0x1B39318")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1B3938C", Offset = "0x1B3938C", VA = "0x1B3938C")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1B393B8", Offset = "0x1B393B8", VA = "0x1B393B8")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1B39510", Offset = "0x1B39510", VA = "0x1B39510")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1B3953C", Offset = "0x1B3953C", VA = "0x1B3953C")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1B39578", Offset = "0x1B39578", VA = "0x1B39578")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1B39580", Offset = "0x1B39580", VA = "0x1B39580")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1B38D00", Offset = "0x1B38D00", VA = "0x1B38D00")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1B395AC", Offset = "0x1B395AC", VA = "0x1B395AC")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1B395B4", Offset = "0x1B395B4", VA = "0x1B395B4")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1B395BC", Offset = "0x1B395BC", VA = "0x1B395BC")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1B395C4", Offset = "0x1B395C4", VA = "0x1B395C4")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1B39604", Offset = "0x1B39604", VA = "0x1B39604")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1B39630", Offset = "0x1B39630", VA = "0x1B39630")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1B399CC", Offset = "0x1B399CC", VA = "0x1B399CC")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1B399D4", Offset = "0x1B399D4", VA = "0x1B399D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4838D0", Offset = "0x4838D0")]
	private void <setMoveX>b__71_0()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1B39A14", Offset = "0x1B39A14", VA = "0x1B39A14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4838E0", Offset = "0x4838E0")]
	private void <setMoveX>b__71_1()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1B39AE8", Offset = "0x1B39AE8", VA = "0x1B39AE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4838F0", Offset = "0x4838F0")]
	private void <setMoveY>b__72_0()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1B39B28", Offset = "0x1B39B28", VA = "0x1B39B28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483900", Offset = "0x483900")]
	private void <setMoveY>b__72_1()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1B39BF4", Offset = "0x1B39BF4", VA = "0x1B39BF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483910", Offset = "0x483910")]
	private void <setMoveZ>b__73_0()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1B39C34", Offset = "0x1B39C34", VA = "0x1B39C34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483920", Offset = "0x483920")]
	private void <setMoveZ>b__73_1()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1B39D04", Offset = "0x1B39D04", VA = "0x1B39D04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483930", Offset = "0x483930")]
	private void <setMoveLocalX>b__74_0()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1B39D44", Offset = "0x1B39D44", VA = "0x1B39D44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483940", Offset = "0x483940")]
	private void <setMoveLocalX>b__74_1()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1B39E18", Offset = "0x1B39E18", VA = "0x1B39E18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483950", Offset = "0x483950")]
	private void <setMoveLocalY>b__75_0()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1B39E58", Offset = "0x1B39E58", VA = "0x1B39E58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483960", Offset = "0x483960")]
	private void <setMoveLocalY>b__75_1()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1B39F24", Offset = "0x1B39F24", VA = "0x1B39F24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483970", Offset = "0x483970")]
	private void <setMoveLocalZ>b__76_0()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1B39F64", Offset = "0x1B39F64", VA = "0x1B39F64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483980", Offset = "0x483980")]
	private void <setMoveLocalZ>b__76_1()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1B3A034", Offset = "0x1B3A034", VA = "0x1B3A034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483990", Offset = "0x483990")]
	private void <setMoveCurved>b__78_0()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1B3A1E0", Offset = "0x1B3A1E0", VA = "0x1B3A1E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4839A0", Offset = "0x4839A0")]
	private void <setMoveCurvedLocal>b__79_0()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1B3A38C", Offset = "0x1B3A38C", VA = "0x1B3A38C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4839B0", Offset = "0x4839B0")]
	private void <setMoveSpline>b__80_0()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1B3A7E8", Offset = "0x1B3A7E8", VA = "0x1B3A7E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4839C0", Offset = "0x4839C0")]
	private void <setMoveSplineLocal>b__81_0()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1B3AC88", Offset = "0x1B3AC88", VA = "0x1B3AC88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4839D0", Offset = "0x4839D0")]
	private void <setScaleX>b__82_0()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1B3ACC8", Offset = "0x1B3ACC8", VA = "0x1B3ACC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4839E0", Offset = "0x4839E0")]
	private void <setScaleX>b__82_1()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1B3AD9C", Offset = "0x1B3AD9C", VA = "0x1B3AD9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4839F0", Offset = "0x4839F0")]
	private void <setScaleY>b__83_0()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1B3ADDC", Offset = "0x1B3ADDC", VA = "0x1B3ADDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483A00", Offset = "0x483A00")]
	private void <setScaleY>b__83_1()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1B3AEA8", Offset = "0x1B3AEA8", VA = "0x1B3AEA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483A10", Offset = "0x483A10")]
	private void <setScaleZ>b__84_0()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1B3AEE8", Offset = "0x1B3AEE8", VA = "0x1B3AEE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483A20", Offset = "0x483A20")]
	private void <setScaleZ>b__84_1()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1B3AFB8", Offset = "0x1B3AFB8", VA = "0x1B3AFB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483A30", Offset = "0x483A30")]
	private void <setRotateX>b__85_0()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1B3B078", Offset = "0x1B3B078", VA = "0x1B3B078")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483A40", Offset = "0x483A40")]
	private void <setRotateX>b__85_1()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1B3B14C", Offset = "0x1B3B14C", VA = "0x1B3B14C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483A50", Offset = "0x483A50")]
	private void <setRotateY>b__86_0()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1B3B20C", Offset = "0x1B3B20C", VA = "0x1B3B20C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483A60", Offset = "0x483A60")]
	private void <setRotateY>b__86_1()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1B3B2D8", Offset = "0x1B3B2D8", VA = "0x1B3B2D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483A70", Offset = "0x483A70")]
	private void <setRotateZ>b__87_0()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1B3B398", Offset = "0x1B3B398", VA = "0x1B3B398")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483A80", Offset = "0x483A80")]
	private void <setRotateZ>b__87_1()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1B3B468", Offset = "0x1B3B468", VA = "0x1B3B468")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483A90", Offset = "0x483A90")]
	private void <setRotateAround>b__88_0()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1B3B4C8", Offset = "0x1B3B4C8", VA = "0x1B3B4C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483AA0", Offset = "0x483AA0")]
	private void <setRotateAround>b__88_1()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1B3B87C", Offset = "0x1B3B87C", VA = "0x1B3B87C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483AB0", Offset = "0x483AB0")]
	private void <setRotateAroundLocal>b__89_0()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1B3B8DC", Offset = "0x1B3B8DC", VA = "0x1B3B8DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483AC0", Offset = "0x483AC0")]
	private void <setRotateAroundLocal>b__89_1()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1B3BCC4", Offset = "0x1B3BCC4", VA = "0x1B3BCC4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483AD0", Offset = "0x483AD0")]
	private void <setAlpha>b__90_0()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1B3C3F0", Offset = "0x1B3C3F0", VA = "0x1B3C3F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483AE0", Offset = "0x483AE0")]
	private void <setAlpha>b__90_2()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1B3C5C0", Offset = "0x1B3C5C0", VA = "0x1B3C5C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483AF0", Offset = "0x483AF0")]
	private void <setAlpha>b__90_1()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1B3C7A4", Offset = "0x1B3C7A4", VA = "0x1B3C7A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483B00", Offset = "0x483B00")]
	private void <setTextAlpha>b__91_0()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1B3C89C", Offset = "0x1B3C89C", VA = "0x1B3C89C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483B10", Offset = "0x483B10")]
	private void <setTextAlpha>b__91_1()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1B3C8E4", Offset = "0x1B3C8E4", VA = "0x1B3C8E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483B20", Offset = "0x483B20")]
	private void <setAlphaVertex>b__92_0()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1B3C9C0", Offset = "0x1B3C9C0", VA = "0x1B3C9C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483B30", Offset = "0x483B30")]
	private void <setAlphaVertex>b__92_1()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1B3CCE4", Offset = "0x1B3CCE4", VA = "0x1B3CCE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483B40", Offset = "0x483B40")]
	private void <setColor>b__93_0()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1B3D3F8", Offset = "0x1B3D3F8", VA = "0x1B3D3F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483B50", Offset = "0x483B50")]
	private void <setColor>b__93_1()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1B3D698", Offset = "0x1B3D698", VA = "0x1B3D698")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483B60", Offset = "0x483B60")]
	private void <setCallbackColor>b__94_0()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1B3D6E8", Offset = "0x1B3D6E8", VA = "0x1B3D6E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483B70", Offset = "0x483B70")]
	private void <setCallbackColor>b__94_1()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1B3D988", Offset = "0x1B3D988", VA = "0x1B3D988")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483B80", Offset = "0x483B80")]
	private void <setTextColor>b__95_0()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1B3DA9C", Offset = "0x1B3DA9C", VA = "0x1B3DA9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483B90", Offset = "0x483B90")]
	private void <setTextColor>b__95_1()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1B3DC60", Offset = "0x1B3DC60", VA = "0x1B3DC60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483BA0", Offset = "0x483BA0")]
	private void <setCanvasAlpha>b__96_0()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1B3DDC8", Offset = "0x1B3DDC8", VA = "0x1B3DDC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483BB0", Offset = "0x483BB0")]
	private void <setCanvasAlpha>b__96_1()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1B3DFE8", Offset = "0x1B3DFE8", VA = "0x1B3DFE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483BC0", Offset = "0x483BC0")]
	private void <setCanvasGroupAlpha>b__97_0()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1B3E074", Offset = "0x1B3E074", VA = "0x1B3E074")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483BD0", Offset = "0x483BD0")]
	private void <setCanvasGroupAlpha>b__97_1()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1B3E130", Offset = "0x1B3E130", VA = "0x1B3E130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483BE0", Offset = "0x483BE0")]
	private void <setCanvasColor>b__98_0()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1B3E2B4", Offset = "0x1B3E2B4", VA = "0x1B3E2B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483BF0", Offset = "0x483BF0")]
	private void <setCanvasColor>b__98_1()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1B3E544", Offset = "0x1B3E544", VA = "0x1B3E544")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483C00", Offset = "0x483C00")]
	private void <setCanvasMoveX>b__99_0()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1B3E584", Offset = "0x1B3E584", VA = "0x1B3E584")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483C10", Offset = "0x483C10")]
	private void <setCanvasMoveX>b__99_1()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1B3E638", Offset = "0x1B3E638", VA = "0x1B3E638")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483C20", Offset = "0x483C20")]
	private void <setCanvasMoveY>b__100_0()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1B3E678", Offset = "0x1B3E678", VA = "0x1B3E678")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483C30", Offset = "0x483C30")]
	private void <setCanvasMoveY>b__100_1()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1B3E72C", Offset = "0x1B3E72C", VA = "0x1B3E72C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483C40", Offset = "0x483C40")]
	private void <setCanvasMoveZ>b__101_0()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1B3E76C", Offset = "0x1B3E76C", VA = "0x1B3E76C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483C50", Offset = "0x483C50")]
	private void <setCanvasMoveZ>b__101_1()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1B3E820", Offset = "0x1B3E820", VA = "0x1B3E820")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483C60", Offset = "0x483C60")]
	private void <setCanvasRotateAround>b__103_0()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1B3EB48", Offset = "0x1B3EB48", VA = "0x1B3EB48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483C70", Offset = "0x483C70")]
	private void <setCanvasRotateAroundLocal>b__104_0()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1B3EEDC", Offset = "0x1B3EEDC", VA = "0x1B3EEDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483C80", Offset = "0x483C80")]
	private void <setCanvasPlaySprite>b__105_0()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1B3EF54", Offset = "0x1B3EF54", VA = "0x1B3EF54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483C90", Offset = "0x483C90")]
	private void <setCanvasPlaySprite>b__105_1()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1B3F13C", Offset = "0x1B3F13C", VA = "0x1B3F13C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483CA0", Offset = "0x483CA0")]
	private void <setCanvasMove>b__106_0()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1B3F180", Offset = "0x1B3F180", VA = "0x1B3F180")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483CB0", Offset = "0x483CB0")]
	private void <setCanvasMove>b__106_1()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1B3F1D4", Offset = "0x1B3F1D4", VA = "0x1B3F1D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483CC0", Offset = "0x483CC0")]
	private void <setCanvasScale>b__107_0()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1B3F218", Offset = "0x1B3F218", VA = "0x1B3F218")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483CD0", Offset = "0x483CD0")]
	private void <setCanvasScale>b__107_1()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1B3F26C", Offset = "0x1B3F26C", VA = "0x1B3F26C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483CE0", Offset = "0x483CE0")]
	private void <setCanvasSizeDelta>b__108_0()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1B3F324", Offset = "0x1B3F324", VA = "0x1B3F324")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483CF0", Offset = "0x483CF0")]
	private void <setCanvasSizeDelta>b__108_1()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1B3F3F0", Offset = "0x1B3F3F0", VA = "0x1B3F3F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483D00", Offset = "0x483D00")]
	private void <setMove>b__112_0()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1B3F434", Offset = "0x1B3F434", VA = "0x1B3F434")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483D10", Offset = "0x483D10")]
	private void <setMove>b__112_1()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1B3F4F4", Offset = "0x1B3F4F4", VA = "0x1B3F4F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483D20", Offset = "0x483D20")]
	private void <setMoveLocal>b__113_0()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1B3F538", Offset = "0x1B3F538", VA = "0x1B3F538")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483D30", Offset = "0x483D30")]
	private void <setMoveLocal>b__113_1()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1B3F5F8", Offset = "0x1B3F5F8", VA = "0x1B3F5F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483D40", Offset = "0x483D40")]
	private void <setMoveToTransform>b__114_0()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1B3F63C", Offset = "0x1B3F63C", VA = "0x1B3F63C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483D50", Offset = "0x483D50")]
	private void <setMoveToTransform>b__114_1()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1B3F7D4", Offset = "0x1B3F7D4", VA = "0x1B3F7D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483D60", Offset = "0x483D60")]
	private void <setRotate>b__115_0()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1B3F900", Offset = "0x1B3F900", VA = "0x1B3F900")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483D70", Offset = "0x483D70")]
	private void <setRotate>b__115_1()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1B3F9C0", Offset = "0x1B3F9C0", VA = "0x1B3F9C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483D80", Offset = "0x483D80")]
	private void <setRotateLocal>b__116_0()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x1B3FAEC", Offset = "0x1B3FAEC", VA = "0x1B3FAEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483D90", Offset = "0x483D90")]
	private void <setRotateLocal>b__116_1()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1B3FBAC", Offset = "0x1B3FBAC", VA = "0x1B3FBAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483DA0", Offset = "0x483DA0")]
	private void <setScale>b__117_0()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1B3FBF0", Offset = "0x1B3FBF0", VA = "0x1B3FBF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483DB0", Offset = "0x483DB0")]
	private void <setScale>b__117_1()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1B3FCB0", Offset = "0x1B3FCB0", VA = "0x1B3FCB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483DC0", Offset = "0x483DC0")]
	private void <setGUIMove>b__118_0()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1B40098", Offset = "0x1B40098", VA = "0x1B40098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483DD0", Offset = "0x483DD0")]
	private void <setGUIMove>b__118_1()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1B401C8", Offset = "0x1B401C8", VA = "0x1B401C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483DE0", Offset = "0x483DE0")]
	private void <setGUIMoveMargin>b__119_0()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1B402CC", Offset = "0x1B402CC", VA = "0x1B402CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483DF0", Offset = "0x483DF0")]
	private void <setGUIMoveMargin>b__119_1()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1B4035C", Offset = "0x1B4035C", VA = "0x1B4035C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483E00", Offset = "0x483E00")]
	private void <setGUIScale>b__120_0()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1B4043C", Offset = "0x1B4043C", VA = "0x1B4043C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483E10", Offset = "0x483E10")]
	private void <setGUIScale>b__120_1()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1B40570", Offset = "0x1B40570", VA = "0x1B40570")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483E20", Offset = "0x483E20")]
	private void <setGUIAlpha>b__121_0()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1B405A8", Offset = "0x1B405A8", VA = "0x1B405A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483E30", Offset = "0x483E30")]
	private void <setGUIAlpha>b__121_1()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1B40604", Offset = "0x1B40604", VA = "0x1B40604")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483E40", Offset = "0x483E40")]
	private void <setGUIRotate>b__122_0()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1B40A30", Offset = "0x1B40A30", VA = "0x1B40A30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483E50", Offset = "0x483E50")]
	private void <setGUIRotate>b__122_1()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1B40A8C", Offset = "0x1B40A8C", VA = "0x1B40A8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483E60", Offset = "0x483E60")]
	private void <setDelayedSound>b__123_0()
	{
	}
}
[Token(Token = "0x2000003")]
public class LTDescrOptional
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4836EC", Offset = "0x4836EC")]
	private Transform <toTrans>k__BackingField;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4836FC", Offset = "0x4836FC")]
	private Vector3 <point>k__BackingField;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48370C", Offset = "0x48370C")]
	private Vector3 <axis>k__BackingField;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48371C", Offset = "0x48371C")]
	private float <lastVal>k__BackingField;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48372C", Offset = "0x48372C")]
	private Quaternion <origRotation>k__BackingField;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48373C", Offset = "0x48373C")]
	private LTBezierPath <path>k__BackingField;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48374C", Offset = "0x48374C")]
	private LTSpline <spline>k__BackingField;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int initFrameCount;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48375C", Offset = "0x48375C")]
	private LTRect <ltRect>k__BackingField;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48376C", Offset = "0x48376C")]
	private Action<float> <onUpdateFloat>k__BackingField;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48377C", Offset = "0x48377C")]
	private Action<float, float> <onUpdateFloatRatio>k__BackingField;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48378C", Offset = "0x48378C")]
	private Action<float, object> <onUpdateFloatObject>k__BackingField;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48379C", Offset = "0x48379C")]
	private Action<Vector2> <onUpdateVector2>k__BackingField;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4837AC", Offset = "0x4837AC")]
	private Action<Vector3> <onUpdateVector3>k__BackingField;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4837BC", Offset = "0x4837BC")]
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4837CC", Offset = "0x4837CC")]
	private Action<Color> <onUpdateColor>k__BackingField;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4837DC", Offset = "0x4837DC")]
	private Action<Color, object> <onUpdateColorObject>k__BackingField;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4837EC", Offset = "0x4837EC")]
	private Action <onComplete>k__BackingField;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4837FC", Offset = "0x4837FC")]
	private Action<object> <onCompleteObject>k__BackingField;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48380C", Offset = "0x48380C")]
	private object <onCompleteParam>k__BackingField;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48381C", Offset = "0x48381C")]
	private object <onUpdateParam>k__BackingField;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48382C", Offset = "0x48382C")]
	private Action <onStart>k__BackingField;

	[Token(Token = "0x17000008")]
	public Transform toTrans
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1B40BBC", Offset = "0x1B40BBC", VA = "0x1B40BBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483E70", Offset = "0x483E70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1B40BC4", Offset = "0x1B40BC4", VA = "0x1B40BC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483E80", Offset = "0x483E80")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public Vector3 point
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1B40BCC", Offset = "0x1B40BCC", VA = "0x1B40BCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483E90", Offset = "0x483E90")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1B40BE0", Offset = "0x1B40BE0", VA = "0x1B40BE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483EA0", Offset = "0x483EA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Vector3 axis
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1B40BEC", Offset = "0x1B40BEC", VA = "0x1B40BEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483EB0", Offset = "0x483EB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1B40C00", Offset = "0x1B40C00", VA = "0x1B40C00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483EC0", Offset = "0x483EC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float lastVal
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1B40C0C", Offset = "0x1B40C0C", VA = "0x1B40C0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483ED0", Offset = "0x483ED0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1B40C14", Offset = "0x1B40C14", VA = "0x1B40C14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483EE0", Offset = "0x483EE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Quaternion origRotation
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1B40C1C", Offset = "0x1B40C1C", VA = "0x1B40C1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483EF0", Offset = "0x483EF0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1B40C2C", Offset = "0x1B40C2C", VA = "0x1B40C2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F00", Offset = "0x483F00")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public LTBezierPath path
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1B40C3C", Offset = "0x1B40C3C", VA = "0x1B40C3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F10", Offset = "0x483F10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1B40C44", Offset = "0x1B40C44", VA = "0x1B40C44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F20", Offset = "0x483F20")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public LTSpline spline
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1B40C4C", Offset = "0x1B40C4C", VA = "0x1B40C4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F30", Offset = "0x483F30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1B40C54", Offset = "0x1B40C54", VA = "0x1B40C54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F40", Offset = "0x483F40")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public LTRect ltRect
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1B40C5C", Offset = "0x1B40C5C", VA = "0x1B40C5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F50", Offset = "0x483F50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1B40C64", Offset = "0x1B40C64", VA = "0x1B40C64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F60", Offset = "0x483F60")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1B40C6C", Offset = "0x1B40C6C", VA = "0x1B40C6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F70", Offset = "0x483F70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1B40C74", Offset = "0x1B40C74", VA = "0x1B40C74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F80", Offset = "0x483F80")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1B40C7C", Offset = "0x1B40C7C", VA = "0x1B40C7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F90", Offset = "0x483F90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1B40C84", Offset = "0x1B40C84", VA = "0x1B40C84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483FA0", Offset = "0x483FA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1B40C8C", Offset = "0x1B40C8C", VA = "0x1B40C8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483FB0", Offset = "0x483FB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1B40C94", Offset = "0x1B40C94", VA = "0x1B40C94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483FC0", Offset = "0x483FC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1B40C9C", Offset = "0x1B40C9C", VA = "0x1B40C9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483FD0", Offset = "0x483FD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1B40CA4", Offset = "0x1B40CA4", VA = "0x1B40CA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483FE0", Offset = "0x483FE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1B40CAC", Offset = "0x1B40CAC", VA = "0x1B40CAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483FF0", Offset = "0x483FF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1B40CB4", Offset = "0x1B40CB4", VA = "0x1B40CB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484000", Offset = "0x484000")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1B40CBC", Offset = "0x1B40CBC", VA = "0x1B40CBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484010", Offset = "0x484010")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1B40CC4", Offset = "0x1B40CC4", VA = "0x1B40CC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484020", Offset = "0x484020")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1B40CCC", Offset = "0x1B40CCC", VA = "0x1B40CCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484030", Offset = "0x484030")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1B40CD4", Offset = "0x1B40CD4", VA = "0x1B40CD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484040", Offset = "0x484040")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Action<Color, object> onUpdateColorObject
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1B40CDC", Offset = "0x1B40CDC", VA = "0x1B40CDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484050", Offset = "0x484050")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1B40CE4", Offset = "0x1B40CE4", VA = "0x1B40CE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484060", Offset = "0x484060")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public Action onComplete
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1B40CEC", Offset = "0x1B40CEC", VA = "0x1B40CEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484070", Offset = "0x484070")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1B40CF4", Offset = "0x1B40CF4", VA = "0x1B40CF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484080", Offset = "0x484080")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1B40CFC", Offset = "0x1B40CFC", VA = "0x1B40CFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484090", Offset = "0x484090")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1B40D04", Offset = "0x1B40D04", VA = "0x1B40D04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4840A0", Offset = "0x4840A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public object onCompleteParam
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1B40D0C", Offset = "0x1B40D0C", VA = "0x1B40D0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4840B0", Offset = "0x4840B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1B40D14", Offset = "0x1B40D14", VA = "0x1B40D14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4840C0", Offset = "0x4840C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public object onUpdateParam
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1B40D1C", Offset = "0x1B40D1C", VA = "0x1B40D1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4840D0", Offset = "0x4840D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1B40D24", Offset = "0x1B40D24", VA = "0x1B40D24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4840E0", Offset = "0x4840E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public Action onStart
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1B40D2C", Offset = "0x1B40D2C", VA = "0x1B40D2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4840F0", Offset = "0x4840F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1B40D34", Offset = "0x1B40D34", VA = "0x1B40D34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x484100", Offset = "0x484100")]
		set
		{
		}
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1B2EBC8", Offset = "0x1B2EBC8", VA = "0x1B2EBC8")]
	public void reset()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1B31FD0", Offset = "0x1B31FD0", VA = "0x1B31FD0")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1B2E930", Offset = "0x1B2E930", VA = "0x1B2E930")]
	public LTDescrOptional()
	{
	}
}
[Token(Token = "0x2000004")]
public class LTSeq
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public LTSeq previous;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public LTSeq current;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LTDescr tween;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float totalDelay;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeScale;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int debugIter;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public uint counter;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool toggle;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private uint _id;

	[Token(Token = "0x1700001D")]
	public int id
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1B44270", Offset = "0x1B44270", VA = "0x1B44270")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1B44280", Offset = "0x1B44280", VA = "0x1B44280")]
	public void reset()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1B44294", Offset = "0x1B44294", VA = "0x1B44294")]
	public void init(uint id, uint global_counter)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1B442B4", Offset = "0x1B442B4", VA = "0x1B442B4")]
	private LTSeq addOn()
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1B443C8", Offset = "0x1B443C8", VA = "0x1B443C8")]
	private float addPreviousDelays()
	{
		return default(float);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1B44444", Offset = "0x1B44444", VA = "0x1B44444")]
	public LTSeq append(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1B44494", Offset = "0x1B44494", VA = "0x1B44494")]
	public LTSeq append(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1B445A8", Offset = "0x1B445A8", VA = "0x1B445A8")]
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1B44670", Offset = "0x1B44670", VA = "0x1B44670")]
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1B44710", Offset = "0x1B44710", VA = "0x1B44710")]
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1B4452C", Offset = "0x1B4452C", VA = "0x1B4452C")]
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1B447E0", Offset = "0x1B447E0", VA = "0x1B447E0")]
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1B44834", Offset = "0x1B44834", VA = "0x1B44834")]
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1B44864", Offset = "0x1B44864", VA = "0x1B44864")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1B44950", Offset = "0x1B44950", VA = "0x1B44950")]
	public LTSeq reverse()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1B44954", Offset = "0x1B44954", VA = "0x1B44954")]
	public LTSeq()
	{
	}
}
[Token(Token = "0x2000005")]
public class LeanAudioStream
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int position;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public AudioClip audioClip;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float[] audioArr;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1FFC3E8", Offset = "0x1FFC3E8", VA = "0x1FFC3E8")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1FFCD8C", Offset = "0x1FFCD8C", VA = "0x1FFCD8C")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1FFCE24", Offset = "0x1FFCE24", VA = "0x1FFCE24")]
	public void OnAudioSetPosition(int newPosition)
	{
	}
}
[Token(Token = "0x2000006")]
public class LeanAudio
{
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float MIN_FREQEUNCY_PERIOD;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int PROCESSING_ITERATIONS_MAX;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float[] generatedWaveDistances;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int generatedWaveDistancesCount;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static float[] longList;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1FFB330", Offset = "0x1FFB330", VA = "0x1FFB330")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1FFB488", Offset = "0x1FFB488", VA = "0x1FFB488")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1FFC30C", Offset = "0x1FFC30C", VA = "0x1FFC30C")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1FFB580", Offset = "0x1FFB580", VA = "0x1FFB580")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1FFBB48", Offset = "0x1FFBB48", VA = "0x1FFBB48")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1FFC408", Offset = "0x1FFC408", VA = "0x1FFC408")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1FFC40C", Offset = "0x1FFC40C", VA = "0x1FFC40C")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1FFC5F8", Offset = "0x1FFC5F8", VA = "0x1FFC5F8")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1FFC85C", Offset = "0x1FFC85C", VA = "0x1FFC85C")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1FFC918", Offset = "0x1FFC918", VA = "0x1FFC918")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1FFC9B0", Offset = "0x1FFC9B0", VA = "0x1FFC9B0")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1FFC6DC", Offset = "0x1FFC6DC", VA = "0x1FFC6DC")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1FFCAA0", Offset = "0x1FFCAA0", VA = "0x1FFCAA0")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1FFCCB0", Offset = "0x1FFCCB0", VA = "0x1FFCCB0")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x2000007")]
public class LeanAudioOptions
{
	[Token(Token = "0x2000018")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x4000123")]
		Sine,
		[Token(Token = "0x4000124")]
		Square,
		[Token(Token = "0x4000125")]
		Sawtooth,
		[Token(Token = "0x4000126")]
		Noise
	}

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public LeanAudioWaveStyle waveStyle;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3[] vibrato;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] modulation;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int frequencyRate;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float waveNoiseScale;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float waveNoiseInfluence;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool useSetData;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LeanAudioStream stream;

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1FFB45C", Offset = "0x1FFB45C", VA = "0x1FFB45C")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1FFCD34", Offset = "0x1FFCD34", VA = "0x1FFCD34")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1FFCD3C", Offset = "0x1FFCD3C", VA = "0x1FFCD3C")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1FFCD44", Offset = "0x1FFCD44", VA = "0x1FFCD44")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1FFCD50", Offset = "0x1FFCD50", VA = "0x1FFCD50")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1FFCD5C", Offset = "0x1FFCD5C", VA = "0x1FFCD5C")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1FFCD68", Offset = "0x1FFCD68", VA = "0x1FFCD68")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1FFCD74", Offset = "0x1FFCD74", VA = "0x1FFCD74")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1FFCD7C", Offset = "0x1FFCD7C", VA = "0x1FFCD7C")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1FFCD84", Offset = "0x1FFCD84", VA = "0x1FFCD84")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000008")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4836BC", Offset = "0x4836BC")]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LeanTester <>4__this;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x1FFE1F8", Offset = "0x1FFE1F8", VA = "0x1FFE1F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1FFE278", Offset = "0x1FFE278", VA = "0x1FFE278", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1FFE00C", Offset = "0x1FFE00C", VA = "0x1FFE00C")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1FFE040", Offset = "0x1FFE040", VA = "0x1FFE040", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1FFE044", Offset = "0x1FFE044", VA = "0x1FFE044", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1FFE200", Offset = "0x1FFE200", VA = "0x1FFE200", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float timeout;

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1FFDF68", Offset = "0x1FFDF68", VA = "0x1FFDF68")]
	public void Start()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1FFDF8C", Offset = "0x1FFDF8C", VA = "0x1FFDF8C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x484110", Offset = "0x484110")]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1FFE02C", Offset = "0x1FFE02C", VA = "0x1FFE02C")]
	public LeanTester()
	{
	}
}
[Token(Token = "0x2000009")]
public class LeanTest
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int expected;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int tests;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int passes;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float timeout;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool timeoutStarted;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public static bool testsFinished;

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1FFCE2C", Offset = "0x1FFCE2C", VA = "0x1FFCE2C")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1FFCEB4", Offset = "0x1FFCEB4", VA = "0x1FFCEB4")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1FFDDD0", Offset = "0x1FFDDD0", VA = "0x1FFDDD0")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1FFD638", Offset = "0x1FFD638", VA = "0x1FFD638")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1FFDE4C", Offset = "0x1FFDE4C", VA = "0x1FFDE4C")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1FFD760", Offset = "0x1FFD760", VA = "0x1FFD760")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1FFD7D0", Offset = "0x1FFD7D0", VA = "0x1FFD7D0")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1FFD9E4", Offset = "0x1FFD9E4", VA = "0x1FFD9E4")]
	public static void overview()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1FFDED0", Offset = "0x1FFDED0", VA = "0x1FFDED0")]
	public LeanTest()
	{
	}
}
[Token(Token = "0x200000A")]
public enum TweenAction
{
	[Token(Token = "0x400006A")]
	MOVE_X,
	[Token(Token = "0x400006B")]
	MOVE_Y,
	[Token(Token = "0x400006C")]
	MOVE_Z,
	[Token(Token = "0x400006D")]
	MOVE_LOCAL_X,
	[Token(Token = "0x400006E")]
	MOVE_LOCAL_Y,
	[Token(Token = "0x400006F")]
	MOVE_LOCAL_Z,
	[Token(Token = "0x4000070")]
	MOVE_CURVED,
	[Token(Token = "0x4000071")]
	MOVE_CURVED_LOCAL,
	[Token(Token = "0x4000072")]
	MOVE_SPLINE,
	[Token(Token = "0x4000073")]
	MOVE_SPLINE_LOCAL,
	[Token(Token = "0x4000074")]
	SCALE_X,
	[Token(Token = "0x4000075")]
	SCALE_Y,
	[Token(Token = "0x4000076")]
	SCALE_Z,
	[Token(Token = "0x4000077")]
	ROTATE_X,
	[Token(Token = "0x4000078")]
	ROTATE_Y,
	[Token(Token = "0x4000079")]
	ROTATE_Z,
	[Token(Token = "0x400007A")]
	ROTATE_AROUND,
	[Token(Token = "0x400007B")]
	ROTATE_AROUND_LOCAL,
	[Token(Token = "0x400007C")]
	CANVAS_ROTATEAROUND,
	[Token(Token = "0x400007D")]
	CANVAS_ROTATEAROUND_LOCAL,
	[Token(Token = "0x400007E")]
	CANVAS_PLAYSPRITE,
	[Token(Token = "0x400007F")]
	ALPHA,
	[Token(Token = "0x4000080")]
	TEXT_ALPHA,
	[Token(Token = "0x4000081")]
	CANVAS_ALPHA,
	[Token(Token = "0x4000082")]
	CANVASGROUP_ALPHA,
	[Token(Token = "0x4000083")]
	ALPHA_VERTEX,
	[Token(Token = "0x4000084")]
	COLOR,
	[Token(Token = "0x4000085")]
	CALLBACK_COLOR,
	[Token(Token = "0x4000086")]
	TEXT_COLOR,
	[Token(Token = "0x4000087")]
	CANVAS_COLOR,
	[Token(Token = "0x4000088")]
	CANVAS_MOVE_X,
	[Token(Token = "0x4000089")]
	CANVAS_MOVE_Y,
	[Token(Token = "0x400008A")]
	CANVAS_MOVE_Z,
	[Token(Token = "0x400008B")]
	CALLBACK,
	[Token(Token = "0x400008C")]
	MOVE,
	[Token(Token = "0x400008D")]
	MOVE_LOCAL,
	[Token(Token = "0x400008E")]
	MOVE_TO_TRANSFORM,
	[Token(Token = "0x400008F")]
	ROTATE,
	[Token(Token = "0x4000090")]
	ROTATE_LOCAL,
	[Token(Token = "0x4000091")]
	SCALE,
	[Token(Token = "0x4000092")]
	VALUE3,
	[Token(Token = "0x4000093")]
	GUI_MOVE,
	[Token(Token = "0x4000094")]
	GUI_MOVE_MARGIN,
	[Token(Token = "0x4000095")]
	GUI_SCALE,
	[Token(Token = "0x4000096")]
	GUI_ALPHA,
	[Token(Token = "0x4000097")]
	GUI_ROTATE,
	[Token(Token = "0x4000098")]
	DELAYED_SOUND,
	[Token(Token = "0x4000099")]
	CANVAS_MOVE,
	[Token(Token = "0x400009A")]
	CANVAS_SCALE,
	[Token(Token = "0x400009B")]
	CANVAS_SIZEDELTA
}
[Token(Token = "0x200000B")]
public enum LeanTweenType
{
	[Token(Token = "0x400009D")]
	notUsed,
	[Token(Token = "0x400009E")]
	linear,
	[Token(Token = "0x400009F")]
	easeOutQuad,
	[Token(Token = "0x40000A0")]
	easeInQuad,
	[Token(Token = "0x40000A1")]
	easeInOutQuad,
	[Token(Token = "0x40000A2")]
	easeInCubic,
	[Token(Token = "0x40000A3")]
	easeOutCubic,
	[Token(Token = "0x40000A4")]
	easeInOutCubic,
	[Token(Token = "0x40000A5")]
	easeInQuart,
	[Token(Token = "0x40000A6")]
	easeOutQuart,
	[Token(Token = "0x40000A7")]
	easeInOutQuart,
	[Token(Token = "0x40000A8")]
	easeInQuint,
	[Token(Token = "0x40000A9")]
	easeOutQuint,
	[Token(Token = "0x40000AA")]
	easeInOutQuint,
	[Token(Token = "0x40000AB")]
	easeInSine,
	[Token(Token = "0x40000AC")]
	easeOutSine,
	[Token(Token = "0x40000AD")]
	easeInOutSine,
	[Token(Token = "0x40000AE")]
	easeInExpo,
	[Token(Token = "0x40000AF")]
	easeOutExpo,
	[Token(Token = "0x40000B0")]
	easeInOutExpo,
	[Token(Token = "0x40000B1")]
	easeInCirc,
	[Token(Token = "0x40000B2")]
	easeOutCirc,
	[Token(Token = "0x40000B3")]
	easeInOutCirc,
	[Token(Token = "0x40000B4")]
	easeInBounce,
	[Token(Token = "0x40000B5")]
	easeOutBounce,
	[Token(Token = "0x40000B6")]
	easeInOutBounce,
	[Token(Token = "0x40000B7")]
	easeInBack,
	[Token(Token = "0x40000B8")]
	easeOutBack,
	[Token(Token = "0x40000B9")]
	easeInOutBack,
	[Token(Token = "0x40000BA")]
	easeInElastic,
	[Token(Token = "0x40000BB")]
	easeOutElastic,
	[Token(Token = "0x40000BC")]
	easeInOutElastic,
	[Token(Token = "0x40000BD")]
	easeSpring,
	[Token(Token = "0x40000BE")]
	easeShake,
	[Token(Token = "0x40000BF")]
	punch,
	[Token(Token = "0x40000C0")]
	once,
	[Token(Token = "0x40000C1")]
	clamp,
	[Token(Token = "0x40000C2")]
	pingPong,
	[Token(Token = "0x40000C3")]
	animationCurve
}
[Token(Token = "0x200000C")]
public class LeanTween : MonoBehaviour
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool throwErrors;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float tau;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float PI_DIV2;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static LTSeq[] sequences;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTDescr[] tweens;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static int[] tweensFinished;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static LTDescr tween;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static int tweenMaxSearch;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int maxTweens;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static int maxSequences;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int frameRendered;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static GameObject _tweenEmpty;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static float dtEstimated;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static float dtManual;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static float dtActual;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static uint global_counter;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static int i;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static int j;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static int finishedCnt;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public static AnimationCurve punch;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static AnimationCurve shake;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int maxTweenReached;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static int startSearch;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public static LTDescr d;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Action<LTEvent>[] eventListeners;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static GameObject[] goListeners;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static int eventsMaxSearch;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public static int EVENTS_MAX;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static int LISTENERS_MAX;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private static int INIT_LISTENERS_MAX;

	[Token(Token = "0x1700001E")]
	public static int maxSearch
	{
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1FFE380", Offset = "0x1FFE380", VA = "0x1FFE380")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001F")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1FFE3F8", Offset = "0x1FFE3F8", VA = "0x1FFE3F8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000020")]
	public static int tweensRunning
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1FFE470", Offset = "0x1FFE470", VA = "0x1FFE470")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000021")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x200332C", Offset = "0x200332C", VA = "0x200332C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1FFE280", Offset = "0x1FFE280", VA = "0x1FFE280")]
	public static void init()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1FFE2FC", Offset = "0x1FFE2FC", VA = "0x1FFE2FC")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1FFE56C", Offset = "0x1FFE56C", VA = "0x1FFE56C")]
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1FFEA3C", Offset = "0x1FFEA3C", VA = "0x1FFEA3C")]
	public static void reset()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1FFEC2C", Offset = "0x1FFEC2C", VA = "0x1FFEC2C")]
	public void Update()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1FFF1D0", Offset = "0x1FFF1D0", VA = "0x1FFF1D0")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1FFF258", Offset = "0x1FFF258", VA = "0x1FFF258")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1FFEC9C", Offset = "0x1FFEC9C", VA = "0x1FFEC9C")]
	public static void update()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1FFF804", Offset = "0x1FFF804", VA = "0x1FFF804")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1FFF2CC", Offset = "0x1FFF2CC", VA = "0x1FFF2CC")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1FFF8FC", Offset = "0x1FFF8FC", VA = "0x1FFF8FC")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1FFFB38", Offset = "0x1FFFB38", VA = "0x1FFFB38")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1FFFC28", Offset = "0x1FFFC28", VA = "0x1FFFC28")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1FFFC9C", Offset = "0x1FFFC9C", VA = "0x1FFFC9C")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1FFFF30", Offset = "0x1FFFF30", VA = "0x1FFFF30")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1FFFFAC", Offset = "0x1FFFFAC", VA = "0x1FFFFAC")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x20002D4", Offset = "0x20002D4", VA = "0x20002D4")]
	public static void cancel(RectTransform rect)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x200036C", Offset = "0x200036C", VA = "0x200036C")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x2000700", Offset = "0x2000700", VA = "0x2000700")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x2000874", Offset = "0x2000874", VA = "0x2000874")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x20008F0", Offset = "0x20008F0", VA = "0x20008F0")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x2000C9C", Offset = "0x2000C9C", VA = "0x2000C9C")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x200102C", Offset = "0x200102C", VA = "0x200102C")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x20010A4", Offset = "0x20010A4", VA = "0x20010A4")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x2001380", Offset = "0x2001380", VA = "0x2001380")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x484180", Offset = "0x484180")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x20013F8", Offset = "0x20013F8", VA = "0x20013F8")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x200153C", Offset = "0x200153C", VA = "0x200153C")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x20016FC", Offset = "0x20016FC", VA = "0x20016FC")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x2001818", Offset = "0x2001818", VA = "0x2001818")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x2001934", Offset = "0x2001934", VA = "0x2001934")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4841B4", Offset = "0x4841B4")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x20019AC", Offset = "0x20019AC", VA = "0x20019AC")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x2001AF0", Offset = "0x2001AF0", VA = "0x2001AF0")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x2001CB0", Offset = "0x2001CB0", VA = "0x2001CB0")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x2001F6C", Offset = "0x2001F6C", VA = "0x2001F6C")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x2002000", Offset = "0x2002000", VA = "0x2002000")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2002184", Offset = "0x2002184", VA = "0x2002184")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x20022F8", Offset = "0x20022F8", VA = "0x20022F8")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x2002CB4", Offset = "0x2002CB4", VA = "0x2002CB4")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x2002DA4", Offset = "0x2002DA4", VA = "0x2002DA4")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x2002E2C", Offset = "0x2002E2C", VA = "0x2002E2C")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x20033B4", Offset = "0x20033B4", VA = "0x20033B4")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x20034D4", Offset = "0x20034D4", VA = "0x20034D4")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x2003640", Offset = "0x2003640", VA = "0x2003640")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x200376C", Offset = "0x200376C", VA = "0x200376C")]
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x2003AD8", Offset = "0x2003AD8", VA = "0x2003AD8")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x2003C00", Offset = "0x2003C00", VA = "0x2003C00")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x2003D08", Offset = "0x2003D08", VA = "0x2003D08")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x2003E10", Offset = "0x2003E10", VA = "0x2003E10")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x2003F18", Offset = "0x2003F18", VA = "0x2003F18")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x2004004", Offset = "0x2004004", VA = "0x2004004")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x2004184", Offset = "0x2004184", VA = "0x2004184")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x20042E8", Offset = "0x20042E8", VA = "0x20042E8")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x200444C", Offset = "0x200444C", VA = "0x200444C")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x200456C", Offset = "0x200456C", VA = "0x200456C")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x200468C", Offset = "0x200468C", VA = "0x200468C")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x20047A8", Offset = "0x20047A8", VA = "0x20047A8")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x20048C4", Offset = "0x20048C4", VA = "0x20048C4")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2004A04", Offset = "0x2004A04", VA = "0x2004A04")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x2004AD0", Offset = "0x2004AD0", VA = "0x2004AD0")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2004BF8", Offset = "0x2004BF8", VA = "0x2004BF8")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x2004E24", Offset = "0x2004E24", VA = "0x2004E24")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x2004F50", Offset = "0x2004F50", VA = "0x2004F50")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x200507C", Offset = "0x200507C", VA = "0x200507C")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x20051CC", Offset = "0x20051CC", VA = "0x20051CC")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x20052F8", Offset = "0x20052F8", VA = "0x20052F8")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x2005448", Offset = "0x2005448", VA = "0x2005448")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x2005578", Offset = "0x2005578", VA = "0x2005578")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x20056A8", Offset = "0x20056A8", VA = "0x20056A8")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x2005794", Offset = "0x2005794", VA = "0x2005794")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x2005880", Offset = "0x2005880", VA = "0x2005880")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x200596C", Offset = "0x200596C", VA = "0x200596C")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2005A38", Offset = "0x2005A38", VA = "0x2005A38")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x2005C64", Offset = "0x2005C64", VA = "0x2005C64")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x2005D50", Offset = "0x2005D50", VA = "0x2005D50")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x2005E3C", Offset = "0x2005E3C", VA = "0x2005E3C")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x2005F28", Offset = "0x2005F28", VA = "0x2005F28")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x2006054", Offset = "0x2006054", VA = "0x2006054")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x2006180", Offset = "0x2006180", VA = "0x2006180")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x200629C", Offset = "0x200629C", VA = "0x200629C")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x2006368", Offset = "0x2006368", VA = "0x2006368")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x200647C", Offset = "0x200647C", VA = "0x200647C")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x2006548", Offset = "0x2006548", VA = "0x2006548")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x2006634", Offset = "0x2006634", VA = "0x2006634")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x2006720", Offset = "0x2006720", VA = "0x2006720")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x200680C", Offset = "0x200680C", VA = "0x200680C")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x200692C", Offset = "0x200692C", VA = "0x200692C")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x2006A4C", Offset = "0x2006A4C", VA = "0x2006A4C")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x2006B18", Offset = "0x2006B18", VA = "0x2006B18")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x2006C48", Offset = "0x2006C48", VA = "0x2006C48")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x2006D34", Offset = "0x2006D34", VA = "0x2006D34")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x2006E20", Offset = "0x2006E20", VA = "0x2006E20")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x2006F0C", Offset = "0x2006F0C", VA = "0x2006F0C")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x2007048", Offset = "0x2007048", VA = "0x2007048")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x2007188", Offset = "0x2007188", VA = "0x2007188")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x200731C", Offset = "0x200731C", VA = "0x200731C")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x2007418", Offset = "0x2007418", VA = "0x2007418")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x2007600", Offset = "0x2007600", VA = "0x2007600")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x20077A8", Offset = "0x20077A8", VA = "0x20077A8")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x2007950", Offset = "0x2007950", VA = "0x2007950")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x2007B7C", Offset = "0x2007B7C", VA = "0x2007B7C")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x2007DA8", Offset = "0x2007DA8", VA = "0x2007DA8")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x2007F60", Offset = "0x2007F60", VA = "0x2007F60")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x20080BC", Offset = "0x20080BC", VA = "0x20080BC")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x2008268", Offset = "0x2008268", VA = "0x2008268")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x20083DC", Offset = "0x20083DC", VA = "0x20083DC")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x200854C", Offset = "0x200854C", VA = "0x200854C")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x2008654", Offset = "0x2008654", VA = "0x2008654")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x200877C", Offset = "0x200877C", VA = "0x200877C")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x20088A4", Offset = "0x20088A4", VA = "0x20088A4")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x20089CC", Offset = "0x20089CC", VA = "0x20089CC")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x2008B54", Offset = "0x2008B54", VA = "0x2008B54")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x2008CBC", Offset = "0x2008CBC", VA = "0x2008CBC")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x2008E20", Offset = "0x2008E20", VA = "0x2008E20")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x2008F84", Offset = "0x2008F84", VA = "0x2008F84")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x200908C", Offset = "0x200908C", VA = "0x200908C")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x20091D0", Offset = "0x20091D0", VA = "0x20091D0")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x20092F8", Offset = "0x20092F8", VA = "0x20092F8")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x2009480", Offset = "0x2009480", VA = "0x2009480")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x2009504", Offset = "0x2009504", VA = "0x2009504")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x2009640", Offset = "0x2009640", VA = "0x2009640")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x2009664", Offset = "0x2009664", VA = "0x2009664")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2009680", Offset = "0x2009680", VA = "0x2009680")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x20096E0", Offset = "0x20096E0", VA = "0x20096E0")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x20098BC", Offset = "0x20098BC", VA = "0x20098BC")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x2009948", Offset = "0x2009948", VA = "0x2009948")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x2009A30", Offset = "0x2009A30", VA = "0x2009A30")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x2009B3C", Offset = "0x2009B3C", VA = "0x2009B3C")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x2009B5C", Offset = "0x2009B5C", VA = "0x2009B5C")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x2009B84", Offset = "0x2009B84", VA = "0x2009B84")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x2009BE8", Offset = "0x2009BE8", VA = "0x2009BE8")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x2009C30", Offset = "0x2009C30", VA = "0x2009C30")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x2009C54", Offset = "0x2009C54", VA = "0x2009C54")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x2009C84", Offset = "0x2009C84", VA = "0x2009C84")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x2009CEC", Offset = "0x2009CEC", VA = "0x2009CEC")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x2009D14", Offset = "0x2009D14", VA = "0x2009D14")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x2009D44", Offset = "0x2009D44", VA = "0x2009D44")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x2009DB0", Offset = "0x2009DB0", VA = "0x2009DB0")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x2009DDC", Offset = "0x2009DDC", VA = "0x2009DDC")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x2009E14", Offset = "0x2009E14", VA = "0x2009E14")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x2009E8C", Offset = "0x2009E8C", VA = "0x2009E8C")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x2009F38", Offset = "0x2009F38", VA = "0x2009F38")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x2009FE0", Offset = "0x2009FE0", VA = "0x2009FE0")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x200A098", Offset = "0x200A098", VA = "0x200A098")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x200A144", Offset = "0x200A144", VA = "0x200A144")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x200A1F0", Offset = "0x200A1F0", VA = "0x200A1F0")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x200A314", Offset = "0x200A314", VA = "0x200A314")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x200A3D8", Offset = "0x200A3D8", VA = "0x200A3D8")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x200A498", Offset = "0x200A498", VA = "0x200A498")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x200A5B8", Offset = "0x200A5B8", VA = "0x200A5B8")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x200A668", Offset = "0x200A668", VA = "0x200A668")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x200A734", Offset = "0x200A734", VA = "0x200A734")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x200A834", Offset = "0x200A834", VA = "0x200A834")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x200A874", Offset = "0x200A874", VA = "0x200A874")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x200A8BC", Offset = "0x200A8BC", VA = "0x200A8BC")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x200A954", Offset = "0x200A954", VA = "0x200A954")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x200AAA8", Offset = "0x200AAA8", VA = "0x200AAA8")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x200ABF0", Offset = "0x200ABF0", VA = "0x200ABF0")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x200ADE4", Offset = "0x200ADE4", VA = "0x200ADE4")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x200AE68", Offset = "0x200AE68", VA = "0x200AE68")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x200B408", Offset = "0x200B408", VA = "0x200B408")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x200B73C", Offset = "0x200B73C", VA = "0x200B73C")]
	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x200B48C", Offset = "0x200B48C", VA = "0x200B48C")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x200B834", Offset = "0x200B834", VA = "0x200B834")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x200B8B0", Offset = "0x200B8B0", VA = "0x200B8B0")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x200BB50", Offset = "0x200BB50", VA = "0x200BB50")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x200000D")]
public class LTUtility
{
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x1B39854", Offset = "0x1B39854", VA = "0x1B39854")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x1B462D8", Offset = "0x1B462D8", VA = "0x1B462D8")]
	public LTUtility()
	{
	}
}
[Token(Token = "0x200000E")]
public class LTBezier
{
	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float length;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Vector3 a;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 aa;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 bb;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 cc;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float len;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float[] arcLengths;

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x1B2C5F0", Offset = "0x1B2C5F0", VA = "0x1B2C5F0")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x1B2CB94", Offset = "0x1B2CB94", VA = "0x1B2CB94")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x1B2CA34", Offset = "0x1B2CA34", VA = "0x1B2CA34")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x1B2CDC8", Offset = "0x1B2CDC8", VA = "0x1B2CDC8")]
	public Vector3 point(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200000F")]
public class LTBezierPath
{
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector3[] pts;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float length;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool orientToPath;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool orientToPath2d;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private LTBezier[] beziers;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float[] lengthRatio;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int currentBezier;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int previousBezier;

	[Token(Token = "0x17000022")]
	public float distance
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1B2D2A4", Offset = "0x1B2D2A4", VA = "0x1B2D2A4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x1B2CDF8", Offset = "0x1B2CDF8", VA = "0x1B2CDF8")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1B2CE00", Offset = "0x1B2CE00", VA = "0x1B2CE00")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1B2CE28", Offset = "0x1B2CE28", VA = "0x1B2CE28")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1B2D2AC", Offset = "0x1B2D2AC", VA = "0x1B2D2AC")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1B2D470", Offset = "0x1B2D470", VA = "0x1B2D470")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1B2D63C", Offset = "0x1B2D63C", VA = "0x1B2D63C")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x1B2D808", Offset = "0x1B2D808", VA = "0x1B2D808")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x1B2D8B4", Offset = "0x1B2D8B4", VA = "0x1B2D8B4")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x1B2D970", Offset = "0x1B2D970", VA = "0x1B2D970")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x1B2DA1C", Offset = "0x1B2DA1C", VA = "0x1B2DA1C")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x1B2DB44", Offset = "0x1B2DB44", VA = "0x1B2DB44")]
	public float getRationInOneRange(float ratio)
	{
		return default(float);
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x1B2DC2C", Offset = "0x1B2DC2C", VA = "0x1B2DC2C")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
[Token(Token = "0x2000010")]
public class LTSpline
{
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float distance;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool constantSpeed;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] pts;

	[NonSerialized]
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector3[] ptsAdj;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int ptsAdjLength;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orientToPath;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int numSections;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int currPt;

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x1B39994", Offset = "0x1B39994", VA = "0x1B39994")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x1B44E10", Offset = "0x1B44E10", VA = "0x1B44E10")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x1B4495C", Offset = "0x1B4495C", VA = "0x1B4495C")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x1B45380", Offset = "0x1B45380", VA = "0x1B45380")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x1B44E50", Offset = "0x1B44E50", VA = "0x1B44E50")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x1B455FC", Offset = "0x1B455FC", VA = "0x1B455FC")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x1B3A7B0", Offset = "0x1B3A7B0", VA = "0x1B3A7B0")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x1B3A538", Offset = "0x1B3A538", VA = "0x1B3A538")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x1B3A994", Offset = "0x1B3A994", VA = "0x1B3A994")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x1B3A704", Offset = "0x1B3A704", VA = "0x1B3A704")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x1B4574C", Offset = "0x1B4574C", VA = "0x1B4574C")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x1B3ABDC", Offset = "0x1B3ABDC", VA = "0x1B3ABDC")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x1B45808", Offset = "0x1B45808", VA = "0x1B45808")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x1B4590C", Offset = "0x1B4590C", VA = "0x1B4590C")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x1B459F4", Offset = "0x1B459F4", VA = "0x1B459F4")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1B45B64", Offset = "0x1B45B64", VA = "0x1B45B64")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1B45E24", Offset = "0x1B45E24", VA = "0x1B45E24")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1B45E30", Offset = "0x1B45E30", VA = "0x1B45E30")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1B460B0", Offset = "0x1B460B0", VA = "0x1B460B0")]
	public Vector3[] generateVectors()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000011")]
public class LTRect
{
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Rect _rect;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float alpha;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float rotation;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 pivot;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 margin;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Rect relativeRect;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool rotateEnabled;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[HideInInspector]
	public bool rotateFinished;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool alphaEnabled;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public string labelStr;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LTGUI.Element_Type type;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public GUIStyle style;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool useColor;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Color color;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool fontScaleToFit;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool useSimpleScale;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	public bool sizeByHeight;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture texture;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int _id;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public int counter;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x17000023")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1B426B0", Offset = "0x1B426B0", VA = "0x1B426B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000024")]
	public int id
	{
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1B43054", Offset = "0x1B43054", VA = "0x1B43054")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000025")]
	public float x
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1B43D74", Offset = "0x1B43D74", VA = "0x1B43D74")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1B43D80", Offset = "0x1B43D80", VA = "0x1B43D80")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public float y
	{
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1B43D8C", Offset = "0x1B43D8C", VA = "0x1B43D8C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1B43D98", Offset = "0x1B43D98", VA = "0x1B43D98")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public float width
	{
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1B43DA4", Offset = "0x1B43DA4", VA = "0x1B43DA4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1B43DB0", Offset = "0x1B43DB0", VA = "0x1B43DB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public float height
	{
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1B43DBC", Offset = "0x1B43DBC", VA = "0x1B43DBC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1B43DC8", Offset = "0x1B43DC8", VA = "0x1B43DC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public Rect rect
	{
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1B3FD90", Offset = "0x1B3FD90", VA = "0x1B3FD90")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1B43DD4", Offset = "0x1B43DD4", VA = "0x1B43DD4")]
		set
		{
		}
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1B43914", Offset = "0x1B43914", VA = "0x1B43914")]
	public LTRect()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1B39458", Offset = "0x1B39458", VA = "0x1B39458")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x1B43A98", Offset = "0x1B43A98", VA = "0x1B43A98")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x1B43B84", Offset = "0x1B43B84", VA = "0x1B43B84")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1B43C6C", Offset = "0x1B43C6C", VA = "0x1B43C6C")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x1B43064", Offset = "0x1B43064", VA = "0x1B43064")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x1B439E8", Offset = "0x1B439E8", VA = "0x1B439E8")]
	public void reset()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x1B406B8", Offset = "0x1B406B8", VA = "0x1B406B8")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x1B43DE4", Offset = "0x1B43DE4", VA = "0x1B43DE4")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x1B43DEC", Offset = "0x1B43DEC", VA = "0x1B43DEC")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x1B43DF4", Offset = "0x1B43DF4", VA = "0x1B43DF4")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x1B43E14", Offset = "0x1B43E14", VA = "0x1B43E14")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x1B43E1C", Offset = "0x1B43E1C", VA = "0x1B43E1C")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x1B43E24", Offset = "0x1B43E24", VA = "0x1B43E24")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x1B43E48", Offset = "0x1B43E48", VA = "0x1B43E48")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x1B43EC8", Offset = "0x1B43EC8", VA = "0x1B43EC8")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x1B43ED0", Offset = "0x1B43ED0", VA = "0x1B43ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public class LTEvent
{
	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public object data;

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1B40D3C", Offset = "0x1B40D3C", VA = "0x1B40D3C")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x2000013")]
public class LTGUI
{
	[Token(Token = "0x200001A")]
	public enum Element_Type
	{
		[Token(Token = "0x400012C")]
		Texture,
		[Token(Token = "0x400012D")]
		Label
	}

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static LTRect[] levels;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int[] levelDepths;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Rect[] buttons;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] buttonLevels;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static int[] buttonLastFrame;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static LTRect r;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static Color color;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static bool isGUIEnabled;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int global_counter;

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x1B40D64", Offset = "0x1B40D64", VA = "0x1B40D64")]
	public static void init()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x1B40E58", Offset = "0x1B40E58", VA = "0x1B40E58")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x1B41014", Offset = "0x1B41014", VA = "0x1B41014")]
	public static void reset()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x1B41218", Offset = "0x1B41218", VA = "0x1B41218")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x1B423B0", Offset = "0x1B423B0", VA = "0x1B423B0")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x1B424B4", Offset = "0x1B424B4", VA = "0x1B424B4")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x1B426C4", Offset = "0x1B426C4", VA = "0x1B426C4")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x1B427E8", Offset = "0x1B427E8", VA = "0x1B427E8")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1B428B0", Offset = "0x1B428B0", VA = "0x1B428B0")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1B42EDC", Offset = "0x1B42EDC", VA = "0x1B42EDC")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1B42FA4", Offset = "0x1B42FA4", VA = "0x1B42FA4")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1B42960", Offset = "0x1B42960", VA = "0x1B42960")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x1B43070", Offset = "0x1B43070", VA = "0x1B43070")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x1B434A0", Offset = "0x1B434A0", VA = "0x1B434A0")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x1B43748", Offset = "0x1B43748", VA = "0x1B43748")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x1B43618", Offset = "0x1B43618", VA = "0x1B43618")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x1B43850", Offset = "0x1B43850", VA = "0x1B43850")]
	public LTGUI()
	{
	}
}
namespace DentedPixel;

[Token(Token = "0x2000014")]
public class LeanDummy
{
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x1B2C5E8", Offset = "0x1B2C5E8", VA = "0x1B2C5E8")]
	public LeanDummy()
	{
	}
}
