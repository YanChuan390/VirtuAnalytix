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
	[Token(Token = "0x2000043")]
	public delegate Vector3 EaseTypeDelegate();

	[Token(Token = "0x2000044")]
	public delegate void ActionMethodDelegate();

	[Serializable]
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01B8", Offset = "0x5C01B8")]
	private sealed class <>c
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ActionMethodDelegate <>9__113_0;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static ActionMethodDelegate <>9__114_0;

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xF90CCC", Offset = "0xF90CCC", VA = "0xF90CCC")]
		public <>c()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xF90CD4", Offset = "0xF90CD4", VA = "0xF90CD4")]
		internal void <setCallback>b__113_0()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xF90CD8", Offset = "0xF90CD8", VA = "0xF90CD8")]
		internal void <setValue3>b__114_0()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool toggle;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool useEstimatedTime;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool useFrames;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	public bool useManualTime;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool usesNormalDt;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool hasInitiliazed;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool hasExtraOnCompletes;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool hasPhysics;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool onCompleteOnRepeat;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool onCompleteOnStart;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useRecursion;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ratioPassed;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float passed;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float delay;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float time;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float lastVal;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private uint _id;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int loopCount;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public uint counter;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float direction;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float directionLast;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float overshoot;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float period;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float scale;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool destroyOnComplete;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform trans;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	internal Vector3 fromInternal;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	internal Vector3 toInternal;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	internal Vector3 diff;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	internal Vector3 diffDiv2;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TweenAction type;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private LeanTweenType easeType;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LeanTweenType loopType;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool hasUpdateCallback;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public EaseTypeDelegate easeMethod;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0218", Offset = "0x5C0218")]
	private ActionMethodDelegate <easeInternal>k__BackingField;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0228", Offset = "0x5C0228")]
	private ActionMethodDelegate <initInternal>k__BackingField;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public SpriteRenderer spriteRen;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RectTransform rectTransform;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Text uiText;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Image uiImage;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public RawImage rawImage;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Sprite[] sprites;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public LTDescrOptional _optional;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float val;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float dt;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Vector3 newVect;

	[Token(Token = "0x17000001")]
	public Vector3 from
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xF81F94", Offset = "0xF81F94", VA = "0xF81F94")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xF81FA0", Offset = "0xF81FA0", VA = "0xF81FA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Vector3 to
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xF81FAC", Offset = "0xF81FAC", VA = "0xF81FAC")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xF81FB8", Offset = "0xF81FB8", VA = "0xF81FB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public ActionMethodDelegate easeInternal
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xF81FC4", Offset = "0xF81FC4", VA = "0xF81FC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0914", Offset = "0x5C0914")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0xF81FCC", Offset = "0xF81FCC", VA = "0xF81FCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0924", Offset = "0x5C0924")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public ActionMethodDelegate initInternal
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0xF81FD4", Offset = "0xF81FD4", VA = "0xF81FD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0934", Offset = "0x5C0934")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xF81FDC", Offset = "0xF81FDC", VA = "0xF81FDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0944", Offset = "0x5C0944")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public Transform toTrans
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xF81FE4", Offset = "0xF81FE4", VA = "0xF81FE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public int uniqueId
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0xF828C8", Offset = "0xF828C8", VA = "0xF828C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000007")]
	public int id
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0xF82764", Offset = "0xF82764", VA = "0xF82764")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public LTDescrOptional optional
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0xF828D8", Offset = "0xF828D8", VA = "0xF828D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0xF828E0", Offset = "0xF828E0", VA = "0xF828E0")]
		set
		{
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xF82000", Offset = "0xF82000", VA = "0xF82000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xF82774", Offset = "0xF82774", VA = "0xF82774")]
	public LTDescr()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xF827EC", Offset = "0xF827EC", VA = "0xF827EC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C0954", Offset = "0x5C0954")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xF828E8", Offset = "0xF828E8", VA = "0xF828E8")]
	public void reset()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xF82A90", Offset = "0xF82A90", VA = "0xF82A90")]
	public LTDescr setFollow()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xF82A9C", Offset = "0xF82A9C", VA = "0xF82A9C")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xF82B44", Offset = "0xF82B44", VA = "0xF82B44")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xF82BE0", Offset = "0xF82BE0", VA = "0xF82BE0")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xF82C7C", Offset = "0xF82C7C", VA = "0xF82C7C")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xF82D18", Offset = "0xF82D18", VA = "0xF82D18")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xF82DB4", Offset = "0xF82DB4", VA = "0xF82DB4")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xF82E50", Offset = "0xF82E50", VA = "0xF82E50")]
	private void initFromInternal()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xF82E58", Offset = "0xF82E58", VA = "0xF82E58")]
	public LTDescr setOffset(Vector3 offset)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xF82E64", Offset = "0xF82E64", VA = "0xF82E64")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xF82F00", Offset = "0xF82F00", VA = "0xF82F00")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xF82F9C", Offset = "0xF82F9C", VA = "0xF82F9C")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xF83038", Offset = "0xF83038", VA = "0xF83038")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xF830D4", Offset = "0xF830D4", VA = "0xF830D4")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xF83170", Offset = "0xF83170", VA = "0xF83170")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xF8320C", Offset = "0xF8320C", VA = "0xF8320C")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xF832A8", Offset = "0xF832A8", VA = "0xF832A8")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xF83344", Offset = "0xF83344", VA = "0xF83344")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xF833E0", Offset = "0xF833E0", VA = "0xF833E0")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xF8347C", Offset = "0xF8347C", VA = "0xF8347C")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xF83518", Offset = "0xF83518", VA = "0xF83518")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xF835B4", Offset = "0xF835B4", VA = "0xF835B4")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xF83650", Offset = "0xF83650", VA = "0xF83650")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xF836EC", Offset = "0xF836EC", VA = "0xF836EC")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xF83788", Offset = "0xF83788", VA = "0xF83788")]
	public LTDescr setColor()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xF83824", Offset = "0xF83824", VA = "0xF83824")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xF838C0", Offset = "0xF838C0", VA = "0xF838C0")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xF8395C", Offset = "0xF8395C", VA = "0xF8395C")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xF839F8", Offset = "0xF839F8", VA = "0xF839F8")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xF83A94", Offset = "0xF83A94", VA = "0xF83A94")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xF83B30", Offset = "0xF83B30", VA = "0xF83B30")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xF83BCC", Offset = "0xF83BCC", VA = "0xF83BCC")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xF83C68", Offset = "0xF83C68", VA = "0xF83C68")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xF83D04", Offset = "0xF83D04", VA = "0xF83D04")]
	private void initCanvasRotateAround()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xF83D4C", Offset = "0xF83D4C", VA = "0xF83D4C")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xF83DE8", Offset = "0xF83DE8", VA = "0xF83DE8")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xF83E84", Offset = "0xF83E84", VA = "0xF83E84")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xF83F20", Offset = "0xF83F20", VA = "0xF83F20")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xF83FBC", Offset = "0xF83FBC", VA = "0xF83FBC")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xF84058", Offset = "0xF84058", VA = "0xF84058")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xF840F4", Offset = "0xF840F4", VA = "0xF840F4")]
	private void callback()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xF84384", Offset = "0xF84384", VA = "0xF84384")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xF84490", Offset = "0xF84490", VA = "0xF84490")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xF8459C", Offset = "0xF8459C", VA = "0xF8459C")]
	public LTDescr setMove()
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xF84638", Offset = "0xF84638", VA = "0xF84638")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xF846D4", Offset = "0xF846D4", VA = "0xF846D4")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xF84770", Offset = "0xF84770", VA = "0xF84770")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xF8480C", Offset = "0xF8480C", VA = "0xF8480C")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xF848A8", Offset = "0xF848A8", VA = "0xF848A8")]
	public LTDescr setScale()
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xF84944", Offset = "0xF84944", VA = "0xF84944")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xF849E0", Offset = "0xF849E0", VA = "0xF849E0")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xF84A7C", Offset = "0xF84A7C", VA = "0xF84A7C")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xF84B18", Offset = "0xF84B18", VA = "0xF84B18")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xF84BB4", Offset = "0xF84BB4", VA = "0xF84BB4")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xF84C50", Offset = "0xF84C50", VA = "0xF84C50")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xF84CEC", Offset = "0xF84CEC", VA = "0xF84CEC")]
	public LTDescr setTarget(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xF84D08", Offset = "0xF84D08", VA = "0xF84D08")]
	private void init()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xF851B0", Offset = "0xF851B0", VA = "0xF851B0")]
	private void initSpeed()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xF852D4", Offset = "0xF852D4", VA = "0xF852D4")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xF852F8", Offset = "0xF852F8", VA = "0xF852F8")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xF850B8", Offset = "0xF850B8", VA = "0xF850B8")]
	public void callOnCompletes()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xF857E8", Offset = "0xF857E8", VA = "0xF857E8")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xF858C8", Offset = "0xF858C8", VA = "0xF858C8")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xF85CD8", Offset = "0xF85CD8", VA = "0xF85CD8")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xF8602C", Offset = "0xF8602C", VA = "0xF8602C")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xF863D0", Offset = "0xF863D0", VA = "0xF863D0")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xF8672C", Offset = "0xF8672C", VA = "0xF8672C")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xF86A98", Offset = "0xF86A98", VA = "0xF86A98")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xF86E30", Offset = "0xF86E30", VA = "0xF86E30")]
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xF87150", Offset = "0xF87150", VA = "0xF87150")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xF87438", Offset = "0xF87438", VA = "0xF87438")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xF87760", Offset = "0xF87760", VA = "0xF87760")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xF8787C", Offset = "0xF8787C", VA = "0xF8787C")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xF87894", Offset = "0xF87894", VA = "0xF87894")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xF878A0", Offset = "0xF878A0", VA = "0xF878A0")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xF878C0", Offset = "0xF878C0", VA = "0xF878C0")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xF878C8", Offset = "0xF878C8", VA = "0xF878C8")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xF87A04", Offset = "0xF87A04", VA = "0xF87A04")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xF88A14", Offset = "0xF88A14", VA = "0xF88A14")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xF87AF4", Offset = "0xF87AF4", VA = "0xF87AF4")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xF87A7C", Offset = "0xF87A7C", VA = "0xF87A7C")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xF87B6C", Offset = "0xF87B6C", VA = "0xF87B6C")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xF87BE4", Offset = "0xF87BE4", VA = "0xF87BE4")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xF87C5C", Offset = "0xF87C5C", VA = "0xF87C5C")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xF87CD4", Offset = "0xF87CD4", VA = "0xF87CD4")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xF87D4C", Offset = "0xF87D4C", VA = "0xF87D4C")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xF87DC4", Offset = "0xF87DC4", VA = "0xF87DC4")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xF87E3C", Offset = "0xF87E3C", VA = "0xF87E3C")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xF87EB4", Offset = "0xF87EB4", VA = "0xF87EB4")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xF87F2C", Offset = "0xF87F2C", VA = "0xF87F2C")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xF87FA4", Offset = "0xF87FA4", VA = "0xF87FA4")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xF8801C", Offset = "0xF8801C", VA = "0xF8801C")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xF88094", Offset = "0xF88094", VA = "0xF88094")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xF8810C", Offset = "0xF8810C", VA = "0xF8810C")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xF88184", Offset = "0xF88184", VA = "0xF88184")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xF881FC", Offset = "0xF881FC", VA = "0xF881FC")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xF88274", Offset = "0xF88274", VA = "0xF88274")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xF882EC", Offset = "0xF882EC", VA = "0xF882EC")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xF88364", Offset = "0xF88364", VA = "0xF88364")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xF883DC", Offset = "0xF883DC", VA = "0xF883DC")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xF88454", Offset = "0xF88454", VA = "0xF88454")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xF884CC", Offset = "0xF884CC", VA = "0xF884CC")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xF88544", Offset = "0xF88544", VA = "0xF88544")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xF885BC", Offset = "0xF885BC", VA = "0xF885BC")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xF88634", Offset = "0xF88634", VA = "0xF88634")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xF886AC", Offset = "0xF886AC", VA = "0xF886AC")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xF88724", Offset = "0xF88724", VA = "0xF88724")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xF8879C", Offset = "0xF8879C", VA = "0xF8879C")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xF88814", Offset = "0xF88814", VA = "0xF88814")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xF8888C", Offset = "0xF8888C", VA = "0xF8888C")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xF88950", Offset = "0xF88950", VA = "0xF88950")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xF88A8C", Offset = "0xF88A8C", VA = "0xF88A8C")]
	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xF88B7C", Offset = "0xF88B7C", VA = "0xF88B7C")]
	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xF88C68", Offset = "0xF88C68", VA = "0xF88C68")]
	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xF88D1C", Offset = "0xF88D1C", VA = "0xF88D1C")]
	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xF88DF8", Offset = "0xF88DF8", VA = "0xF88DF8")]
	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xF88EA8", Offset = "0xF88EA8", VA = "0xF88EA8")]
	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xF8904C", Offset = "0xF8904C", VA = "0xF8904C")]
	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xF89104", Offset = "0xF89104", VA = "0xF89104")]
	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xF891DC", Offset = "0xF891DC", VA = "0xF891DC")]
	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xF892E0", Offset = "0xF892E0", VA = "0xF892E0")]
	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xF893AC", Offset = "0xF893AC", VA = "0xF893AC")]
	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xF89488", Offset = "0xF89488", VA = "0xF89488")]
	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xF895FC", Offset = "0xF895FC", VA = "0xF895FC")]
	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xF896CC", Offset = "0xF896CC", VA = "0xF896CC")]
	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xF897AC", Offset = "0xF897AC", VA = "0xF897AC")]
	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xF898C0", Offset = "0xF898C0", VA = "0xF898C0")]
	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xF899E0", Offset = "0xF899E0", VA = "0xF899E0")]
	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xF89AF0", Offset = "0xF89AF0", VA = "0xF89AF0")]
	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xF89BE4", Offset = "0xF89BE4", VA = "0xF89BE4")]
	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xF89CD0", Offset = "0xF89CD0", VA = "0xF89CD0")]
	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xF89DBC", Offset = "0xF89DBC", VA = "0xF89DBC")]
	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xF89F40", Offset = "0xF89F40", VA = "0xF89F40")]
	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xF8A044", Offset = "0xF8A044", VA = "0xF8A044")]
	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xF8A15C", Offset = "0xF8A15C", VA = "0xF8A15C")]
	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xF8A2E4", Offset = "0xF8A2E4", VA = "0xF8A2E4")]
	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xF8A44C", Offset = "0xF8A44C", VA = "0xF8A44C")]
	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xF8A648", Offset = "0xF8A648", VA = "0xF8A648")]
	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xF8A878", Offset = "0xF8A878", VA = "0xF8A878")]
	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xF8A988", Offset = "0xF8A988", VA = "0xF8A988")]
	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xF8AA8C", Offset = "0xF8AA8C", VA = "0xF8AA8C")]
	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xF8AC20", Offset = "0xF8AC20", VA = "0xF8AC20")]
	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xF8AD34", Offset = "0xF8AD34", VA = "0xF8AD34")]
	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xF8AE48", Offset = "0xF8AE48", VA = "0xF8AE48")]
	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xF8AF5C", Offset = "0xF8AF5C", VA = "0xF8AF5C")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xF8AF64", Offset = "0xF8AF64", VA = "0xF8AF64")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xF8AF6C", Offset = "0xF8AF6C", VA = "0xF8AF6C")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xF8AF74", Offset = "0xF8AF74", VA = "0xF8AF74")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xF8B008", Offset = "0xF8B008", VA = "0xF8B008")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xF8B0D0", Offset = "0xF8B0D0", VA = "0xF8B0D0")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xF8B0EC", Offset = "0xF8B0EC", VA = "0xF8B0EC")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xF8B1FC", Offset = "0xF8B1FC", VA = "0xF8B1FC")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xF8B24C", Offset = "0xF8B24C", VA = "0xF8B24C")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xF8B258", Offset = "0xF8B258", VA = "0xF8B258")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xF8B264", Offset = "0xF8B264", VA = "0xF8B264")]
	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xF8B270", Offset = "0xF8B270", VA = "0xF8B270")]
	public LTDescr setPassed(float passed)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xF8B278", Offset = "0xF8B278", VA = "0xF8B278")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xF8B294", Offset = "0xF8B294", VA = "0xF8B294")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xF8B2C8", Offset = "0xF8B2C8", VA = "0xF8B2C8")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xF8B31C", Offset = "0xF8B31C", VA = "0xF8B31C")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xF8B324", Offset = "0xF8B324", VA = "0xF8B324")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xF8B334", Offset = "0xF8B334", VA = "0xF8B334")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xF8B344", Offset = "0xF8B344", VA = "0xF8B344")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xF8B354", Offset = "0xF8B354", VA = "0xF8B354")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xF8B364", Offset = "0xF8B364", VA = "0xF8B364")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xF8B374", Offset = "0xF8B374", VA = "0xF8B374")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xF8B380", Offset = "0xF8B380", VA = "0xF8B380")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xF8B3A0", Offset = "0xF8B3A0", VA = "0xF8B3A0")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xF8B3A8", Offset = "0xF8B3A8", VA = "0xF8B3A8")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xF8B3C8", Offset = "0xF8B3C8", VA = "0xF8B3C8")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xF8B3F4", Offset = "0xF8B3F4", VA = "0xF8B3F4")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xF8B418", Offset = "0xF8B418", VA = "0xF8B418")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xF8B43C", Offset = "0xF8B43C", VA = "0xF8B43C")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xF8B474", Offset = "0xF8B474", VA = "0xF8B474")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xF8B498", Offset = "0xF8B498", VA = "0xF8B498")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xF8B4BC", Offset = "0xF8B4BC", VA = "0xF8B4BC")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xF8B4E0", Offset = "0xF8B4E0", VA = "0xF8B4E0")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xF8B504", Offset = "0xF8B504", VA = "0xF8B504")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xF8B528", Offset = "0xF8B528", VA = "0xF8B528")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xF8B54C", Offset = "0xF8B54C", VA = "0xF8B54C")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xF8B570", Offset = "0xF8B570", VA = "0xF8B570")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xF8B594", Offset = "0xF8B594", VA = "0xF8B594")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xF8B5B8", Offset = "0xF8B5B8", VA = "0xF8B5B8")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xF8B5DC", Offset = "0xF8B5DC", VA = "0xF8B5DC")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xF8B614", Offset = "0xF8B614", VA = "0xF8B614")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xF8B64C", Offset = "0xF8B64C", VA = "0xF8B64C")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xF8B684", Offset = "0xF8B684", VA = "0xF8B684")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xF8B6BC", Offset = "0xF8B6BC", VA = "0xF8B6BC")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xF8B6D8", Offset = "0xF8B6D8", VA = "0xF8B6D8")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xF8B79C", Offset = "0xF8B79C", VA = "0xF8B79C")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xF8B804", Offset = "0xF8B804", VA = "0xF8B804")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xF8B820", Offset = "0xF8B820", VA = "0xF8B820")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xF8B970", Offset = "0xF8B970", VA = "0xF8B970")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xF8B98C", Offset = "0xF8B98C", VA = "0xF8B98C")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xF8B9AC", Offset = "0xF8B9AC", VA = "0xF8B9AC")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xF8B9B8", Offset = "0xF8B9B8", VA = "0xF8B9B8")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xF8B310", Offset = "0xF8B310", VA = "0xF8B310")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xF8B9D4", Offset = "0xF8B9D4", VA = "0xF8B9D4")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xF8B9E0", Offset = "0xF8B9E0", VA = "0xF8B9E0")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xF8B9E8", Offset = "0xF8B9E8", VA = "0xF8B9E8")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xF8B9F0", Offset = "0xF8B9F0", VA = "0xF8B9F0")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xF8BA18", Offset = "0xF8BA18", VA = "0xF8BA18")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xF8BA34", Offset = "0xF8BA34", VA = "0xF8BA34")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xF8BC20", Offset = "0xF8BC20", VA = "0xF8BC20")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xF8BC2C", Offset = "0xF8BC2C", VA = "0xF8BC2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C098C", Offset = "0x5C098C")]
	private void <setMoveX>b__73_0()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xF8BC60", Offset = "0xF8BC60", VA = "0xF8BC60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C099C", Offset = "0x5C099C")]
	private void <setMoveX>b__73_1()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xF8BCFC", Offset = "0xF8BCFC", VA = "0xF8BCFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09AC", Offset = "0x5C09AC")]
	private void <setMoveY>b__74_0()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xF8BD30", Offset = "0xF8BD30", VA = "0xF8BD30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09BC", Offset = "0x5C09BC")]
	private void <setMoveY>b__74_1()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xF8BDC8", Offset = "0xF8BDC8", VA = "0xF8BDC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09CC", Offset = "0x5C09CC")]
	private void <setMoveZ>b__75_0()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xF8BDFC", Offset = "0xF8BDFC", VA = "0xF8BDFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09DC", Offset = "0x5C09DC")]
	private void <setMoveZ>b__75_1()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xF8BE98", Offset = "0xF8BE98", VA = "0xF8BE98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09EC", Offset = "0x5C09EC")]
	private void <setMoveLocalX>b__76_0()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xF8BECC", Offset = "0xF8BECC", VA = "0xF8BECC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C09FC", Offset = "0x5C09FC")]
	private void <setMoveLocalX>b__76_1()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xF8BF68", Offset = "0xF8BF68", VA = "0xF8BF68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0A0C", Offset = "0x5C0A0C")]
	private void <setMoveLocalY>b__77_0()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xF8BF9C", Offset = "0xF8BF9C", VA = "0xF8BF9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0A1C", Offset = "0x5C0A1C")]
	private void <setMoveLocalY>b__77_1()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xF8C034", Offset = "0xF8C034", VA = "0xF8C034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0A2C", Offset = "0x5C0A2C")]
	private void <setMoveLocalZ>b__78_0()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xF8C068", Offset = "0xF8C068", VA = "0xF8C068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0A3C", Offset = "0x5C0A3C")]
	private void <setMoveLocalZ>b__78_1()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xF8C104", Offset = "0xF8C104", VA = "0xF8C104")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0A4C", Offset = "0x5C0A4C")]
	private void <setMoveCurved>b__81_0()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xF8C1E0", Offset = "0xF8C1E0", VA = "0xF8C1E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0A5C", Offset = "0x5C0A5C")]
	private void <setMoveCurvedLocal>b__82_0()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xF8C2BC", Offset = "0xF8C2BC", VA = "0xF8C2BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0A6C", Offset = "0x5C0A6C")]
	private void <setMoveSpline>b__83_0()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xF8C5D8", Offset = "0xF8C5D8", VA = "0xF8C5D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0A7C", Offset = "0x5C0A7C")]
	private void <setMoveSplineLocal>b__84_0()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xF8C950", Offset = "0xF8C950", VA = "0xF8C950")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0A8C", Offset = "0x5C0A8C")]
	private void <setScaleX>b__85_0()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xF8C984", Offset = "0xF8C984", VA = "0xF8C984")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0A9C", Offset = "0x5C0A9C")]
	private void <setScaleX>b__85_1()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xF8CA20", Offset = "0xF8CA20", VA = "0xF8CA20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0AAC", Offset = "0x5C0AAC")]
	private void <setScaleY>b__86_0()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xF8CA54", Offset = "0xF8CA54", VA = "0xF8CA54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0ABC", Offset = "0x5C0ABC")]
	private void <setScaleY>b__86_1()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xF8CAEC", Offset = "0xF8CAEC", VA = "0xF8CAEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0ACC", Offset = "0x5C0ACC")]
	private void <setScaleZ>b__87_0()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xF8CB20", Offset = "0xF8CB20", VA = "0xF8CB20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0ADC", Offset = "0x5C0ADC")]
	private void <setScaleZ>b__87_1()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xF8CBBC", Offset = "0xF8CBBC", VA = "0xF8CBBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0AEC", Offset = "0x5C0AEC")]
	private void <setRotateX>b__88_0()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xF8CC58", Offset = "0xF8CC58", VA = "0xF8CC58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0AFC", Offset = "0x5C0AFC")]
	private void <setRotateX>b__88_1()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xF8CCF4", Offset = "0xF8CCF4", VA = "0xF8CCF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B0C", Offset = "0x5C0B0C")]
	private void <setRotateY>b__89_0()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xF8CD90", Offset = "0xF8CD90", VA = "0xF8CD90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B1C", Offset = "0x5C0B1C")]
	private void <setRotateY>b__89_1()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xF8CE28", Offset = "0xF8CE28", VA = "0xF8CE28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B2C", Offset = "0x5C0B2C")]
	private void <setRotateZ>b__90_0()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xF8CEC4", Offset = "0xF8CEC4", VA = "0xF8CEC4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B3C", Offset = "0x5C0B3C")]
	private void <setRotateZ>b__90_1()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xF8CF60", Offset = "0xF8CF60", VA = "0xF8CF60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B4C", Offset = "0x5C0B4C")]
	private void <setRotateAround>b__91_0()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xF8CFA4", Offset = "0xF8CFA4", VA = "0xF8CFA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B5C", Offset = "0x5C0B5C")]
	private void <setRotateAround>b__91_1()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xF8D1AC", Offset = "0xF8D1AC", VA = "0xF8D1AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B6C", Offset = "0x5C0B6C")]
	private void <setRotateAroundLocal>b__92_0()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xF8D1F0", Offset = "0xF8D1F0", VA = "0xF8D1F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B7C", Offset = "0x5C0B7C")]
	private void <setRotateAroundLocal>b__92_1()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xF8D46C", Offset = "0xF8D46C", VA = "0xF8D46C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B8C", Offset = "0x5C0B8C")]
	private void <setAlpha>b__93_0()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xF8D97C", Offset = "0xF8D97C", VA = "0xF8D97C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B9C", Offset = "0x5C0B9C")]
	private void <setAlpha>b__93_2()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xF8DAE4", Offset = "0xF8DAE4", VA = "0xF8DAE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0BAC", Offset = "0x5C0BAC")]
	private void <setAlpha>b__93_1()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xF8DC5C", Offset = "0xF8DC5C", VA = "0xF8DC5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0BBC", Offset = "0x5C0BBC")]
	private void <setTextAlpha>b__94_0()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xF8DD18", Offset = "0xF8DD18", VA = "0xF8DD18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0BCC", Offset = "0x5C0BCC")]
	private void <setTextAlpha>b__94_1()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xF8DD50", Offset = "0xF8DD50", VA = "0xF8DD50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0BDC", Offset = "0x5C0BDC")]
	private void <setAlphaVertex>b__95_0()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xF8DDE8", Offset = "0xF8DDE8", VA = "0xF8DDE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0BEC", Offset = "0x5C0BEC")]
	private void <setAlphaVertex>b__95_1()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xF8E018", Offset = "0xF8E018", VA = "0xF8E018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0BFC", Offset = "0x5C0BFC")]
	private void <setColor>b__96_0()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xF8E514", Offset = "0xF8E514", VA = "0xF8E514")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0C0C", Offset = "0x5C0C0C")]
	private void <setColor>b__96_1()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xF8E6F8", Offset = "0xF8E6F8", VA = "0xF8E6F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0C1C", Offset = "0x5C0C1C")]
	private void <setCallbackColor>b__97_0()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xF8E74C", Offset = "0xF8E74C", VA = "0xF8E74C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0C2C", Offset = "0x5C0C2C")]
	private void <setCallbackColor>b__97_1()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xF8E930", Offset = "0xF8E930", VA = "0xF8E930")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0C3C", Offset = "0x5C0C3C")]
	private void <setTextColor>b__98_0()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xF8E9F0", Offset = "0xF8E9F0", VA = "0xF8E9F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0C4C", Offset = "0x5C0C4C")]
	private void <setTextColor>b__98_1()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xF8EB3C", Offset = "0xF8EB3C", VA = "0xF8EB3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0C5C", Offset = "0x5C0C5C")]
	private void <setCanvasAlpha>b__99_0()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xF8EC5C", Offset = "0xF8EC5C", VA = "0xF8EC5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0C6C", Offset = "0x5C0C6C")]
	private void <setCanvasAlpha>b__99_1()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xF8EDE4", Offset = "0xF8EDE4", VA = "0xF8EDE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0C7C", Offset = "0x5C0C7C")]
	private void <setCanvasGroupAlpha>b__100_0()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xF8EE50", Offset = "0xF8EE50", VA = "0xF8EE50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0C8C", Offset = "0x5C0C8C")]
	private void <setCanvasGroupAlpha>b__100_1()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xF8EECC", Offset = "0xF8EECC", VA = "0xF8EECC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0C9C", Offset = "0x5C0C9C")]
	private void <setCanvasColor>b__101_0()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xF8EFE8", Offset = "0xF8EFE8", VA = "0xF8EFE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0CAC", Offset = "0x5C0CAC")]
	private void <setCanvasColor>b__101_1()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xF8F1AC", Offset = "0xF8F1AC", VA = "0xF8F1AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0CBC", Offset = "0x5C0CBC")]
	private void <setCanvasMoveX>b__102_0()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xF8F1E0", Offset = "0xF8F1E0", VA = "0xF8F1E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0CCC", Offset = "0x5C0CCC")]
	private void <setCanvasMoveX>b__102_1()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xF8F26C", Offset = "0xF8F26C", VA = "0xF8F26C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0CDC", Offset = "0x5C0CDC")]
	private void <setCanvasMoveY>b__103_0()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xF8F2A0", Offset = "0xF8F2A0", VA = "0xF8F2A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0CEC", Offset = "0x5C0CEC")]
	private void <setCanvasMoveY>b__103_1()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xF8F330", Offset = "0xF8F330", VA = "0xF8F330")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0CFC", Offset = "0x5C0CFC")]
	private void <setCanvasMoveZ>b__104_0()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xF8F364", Offset = "0xF8F364", VA = "0xF8F364")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0D0C", Offset = "0x5C0D0C")]
	private void <setCanvasMoveZ>b__104_1()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xF8F3F4", Offset = "0xF8F3F4", VA = "0xF8F3F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0D1C", Offset = "0x5C0D1C")]
	private void <setCanvasRotateAround>b__106_0()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xF8F5D0", Offset = "0xF8F5D0", VA = "0xF8F5D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0D2C", Offset = "0x5C0D2C")]
	private void <setCanvasRotateAroundLocal>b__107_0()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xF8F80C", Offset = "0xF8F80C", VA = "0xF8F80C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0D3C", Offset = "0x5C0D3C")]
	private void <setCanvasPlaySprite>b__108_0()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xF8F870", Offset = "0xF8F870", VA = "0xF8F870")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0D4C", Offset = "0x5C0D4C")]
	private void <setCanvasPlaySprite>b__108_1()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xF8F9C4", Offset = "0xF8F9C4", VA = "0xF8F9C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0D5C", Offset = "0x5C0D5C")]
	private void <setCanvasMove>b__109_0()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xF8F9FC", Offset = "0xF8F9FC", VA = "0xF8F9FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0D6C", Offset = "0x5C0D6C")]
	private void <setCanvasMove>b__109_1()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xF8FA38", Offset = "0xF8FA38", VA = "0xF8FA38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0D7C", Offset = "0x5C0D7C")]
	private void <setCanvasScale>b__110_0()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xF8FA70", Offset = "0xF8FA70", VA = "0xF8FA70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0D8C", Offset = "0x5C0D8C")]
	private void <setCanvasScale>b__110_1()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xF8FAAC", Offset = "0xF8FAAC", VA = "0xF8FAAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0D9C", Offset = "0x5C0D9C")]
	private void <setCanvasSizeDelta>b__111_0()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xF8FB48", Offset = "0xF8FB48", VA = "0xF8FB48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0DAC", Offset = "0x5C0DAC")]
	private void <setCanvasSizeDelta>b__111_1()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xF8FBF8", Offset = "0xF8FBF8", VA = "0xF8FBF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0DBC", Offset = "0x5C0DBC")]
	private void <setMove>b__115_0()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xF8FC30", Offset = "0xF8FC30", VA = "0xF8FC30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0DCC", Offset = "0x5C0DCC")]
	private void <setMove>b__115_1()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xF8FCB0", Offset = "0xF8FCB0", VA = "0xF8FCB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0DDC", Offset = "0x5C0DDC")]
	private void <setMoveLocal>b__116_0()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xF8FCE8", Offset = "0xF8FCE8", VA = "0xF8FCE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0DEC", Offset = "0x5C0DEC")]
	private void <setMoveLocal>b__116_1()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xF8FD68", Offset = "0xF8FD68", VA = "0xF8FD68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0DFC", Offset = "0x5C0DFC")]
	private void <setMoveToTransform>b__117_0()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xF8FDA0", Offset = "0xF8FDA0", VA = "0xF8FDA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0E0C", Offset = "0x5C0E0C")]
	private void <setMoveToTransform>b__117_1()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xF8FEC8", Offset = "0xF8FEC8", VA = "0xF8FEC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0E1C", Offset = "0x5C0E1C")]
	private void <setRotate>b__118_0()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xF8FFCC", Offset = "0xF8FFCC", VA = "0xF8FFCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0E2C", Offset = "0x5C0E2C")]
	private void <setRotate>b__118_1()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xF9004C", Offset = "0xF9004C", VA = "0xF9004C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0E3C", Offset = "0x5C0E3C")]
	private void <setRotateLocal>b__119_0()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xF90150", Offset = "0xF90150", VA = "0xF90150")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0E4C", Offset = "0x5C0E4C")]
	private void <setRotateLocal>b__119_1()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xF901D0", Offset = "0xF901D0", VA = "0xF901D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0E5C", Offset = "0x5C0E5C")]
	private void <setScale>b__120_0()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xF90208", Offset = "0xF90208", VA = "0xF90208")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0E6C", Offset = "0x5C0E6C")]
	private void <setScale>b__120_1()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xF90288", Offset = "0xF90288", VA = "0xF90288")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0E7C", Offset = "0x5C0E7C")]
	private void <setGUIMove>b__121_0()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xF90558", Offset = "0xF90558", VA = "0xF90558")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0E8C", Offset = "0x5C0E8C")]
	private void <setGUIMove>b__121_1()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xF90628", Offset = "0xF90628", VA = "0xF90628")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0E9C", Offset = "0x5C0E9C")]
	private void <setGUIMoveMargin>b__122_0()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xF906CC", Offset = "0xF906CC", VA = "0xF906CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0EAC", Offset = "0x5C0EAC")]
	private void <setGUIMoveMargin>b__122_1()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xF90720", Offset = "0xF90720", VA = "0xF90720")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0EBC", Offset = "0x5C0EBC")]
	private void <setGUIScale>b__123_0()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xF907D8", Offset = "0xF907D8", VA = "0xF907D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0ECC", Offset = "0x5C0ECC")]
	private void <setGUIScale>b__123_1()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xF908A8", Offset = "0xF908A8", VA = "0xF908A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0EDC", Offset = "0x5C0EDC")]
	private void <setGUIAlpha>b__124_0()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xF908D4", Offset = "0xF908D4", VA = "0xF908D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0EEC", Offset = "0x5C0EEC")]
	private void <setGUIAlpha>b__124_1()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xF90910", Offset = "0xF90910", VA = "0xF90910")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0EFC", Offset = "0x5C0EFC")]
	private void <setGUIRotate>b__125_0()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xF90C20", Offset = "0xF90C20", VA = "0xF90C20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0F0C", Offset = "0x5C0F0C")]
	private void <setGUIRotate>b__125_1()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xF90C5C", Offset = "0xF90C5C", VA = "0xF90C5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0F1C", Offset = "0x5C0F1C")]
	private void <setDelayedSound>b__126_0()
	{
	}
}
[Token(Token = "0x2000003")]
public class LTDescrOptional
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0238", Offset = "0x5C0238")]
	private Transform <toTrans>k__BackingField;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0248", Offset = "0x5C0248")]
	private Vector3 <point>k__BackingField;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0258", Offset = "0x5C0258")]
	private Vector3 <axis>k__BackingField;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0268", Offset = "0x5C0268")]
	private float <lastVal>k__BackingField;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0278", Offset = "0x5C0278")]
	private Quaternion <origRotation>k__BackingField;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0288", Offset = "0x5C0288")]
	private LTBezierPath <path>k__BackingField;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0298", Offset = "0x5C0298")]
	private LTSpline <spline>k__BackingField;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int initFrameCount;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Color color;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02A8", Offset = "0x5C02A8")]
	private LTRect <ltRect>k__BackingField;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02B8", Offset = "0x5C02B8")]
	private Action<float> <onUpdateFloat>k__BackingField;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02C8", Offset = "0x5C02C8")]
	private Action<float, float> <onUpdateFloatRatio>k__BackingField;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02D8", Offset = "0x5C02D8")]
	private Action<float, object> <onUpdateFloatObject>k__BackingField;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02E8", Offset = "0x5C02E8")]
	private Action<Vector2> <onUpdateVector2>k__BackingField;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02F8", Offset = "0x5C02F8")]
	private Action<Vector3> <onUpdateVector3>k__BackingField;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0308", Offset = "0x5C0308")]
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0318", Offset = "0x5C0318")]
	private Action<Color> <onUpdateColor>k__BackingField;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0328", Offset = "0x5C0328")]
	private Action<Color, object> <onUpdateColorObject>k__BackingField;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0338", Offset = "0x5C0338")]
	private Action <onComplete>k__BackingField;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0348", Offset = "0x5C0348")]
	private Action<object> <onCompleteObject>k__BackingField;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0358", Offset = "0x5C0358")]
	private object <onCompleteParam>k__BackingField;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0368", Offset = "0x5C0368")]
	private object <onUpdateParam>k__BackingField;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0378", Offset = "0x5C0378")]
	private Action <onStart>k__BackingField;

	[Token(Token = "0x17000009")]
	public Transform toTrans
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xF90D70", Offset = "0xF90D70", VA = "0xF90D70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0F2C", Offset = "0x5C0F2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000139")]
		[Address(RVA = "0xF90D78", Offset = "0xF90D78", VA = "0xF90D78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0F3C", Offset = "0x5C0F3C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Vector3 point
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0xF90D80", Offset = "0xF90D80", VA = "0xF90D80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0F4C", Offset = "0x5C0F4C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600013B")]
		[Address(RVA = "0xF90D8C", Offset = "0xF90D8C", VA = "0xF90D8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0F5C", Offset = "0x5C0F5C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public Vector3 axis
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0xF90D98", Offset = "0xF90D98", VA = "0xF90D98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0F6C", Offset = "0x5C0F6C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600013D")]
		[Address(RVA = "0xF90DA4", Offset = "0xF90DA4", VA = "0xF90DA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0F7C", Offset = "0x5C0F7C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public float lastVal
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0xF90DB0", Offset = "0xF90DB0", VA = "0xF90DB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0F8C", Offset = "0x5C0F8C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600013F")]
		[Address(RVA = "0xF90DB8", Offset = "0xF90DB8", VA = "0xF90DB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0F9C", Offset = "0x5C0F9C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public Quaternion origRotation
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0xF90DC0", Offset = "0xF90DC0", VA = "0xF90DC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0FAC", Offset = "0x5C0FAC")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000141")]
		[Address(RVA = "0xF90DCC", Offset = "0xF90DCC", VA = "0xF90DCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0FBC", Offset = "0x5C0FBC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public LTBezierPath path
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0xF90DD8", Offset = "0xF90DD8", VA = "0xF90DD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0FCC", Offset = "0x5C0FCC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000143")]
		[Address(RVA = "0xF90DE0", Offset = "0xF90DE0", VA = "0xF90DE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0FDC", Offset = "0x5C0FDC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public LTSpline spline
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0xF90DE8", Offset = "0xF90DE8", VA = "0xF90DE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0FEC", Offset = "0x5C0FEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000145")]
		[Address(RVA = "0xF90DF0", Offset = "0xF90DF0", VA = "0xF90DF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0FFC", Offset = "0x5C0FFC")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public LTRect ltRect
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0xF90DF8", Offset = "0xF90DF8", VA = "0xF90DF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C100C", Offset = "0x5C100C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000147")]
		[Address(RVA = "0xF90E00", Offset = "0xF90E00", VA = "0xF90E00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C101C", Offset = "0x5C101C")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0xF90E08", Offset = "0xF90E08", VA = "0xF90E08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C102C", Offset = "0x5C102C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000149")]
		[Address(RVA = "0xF90E10", Offset = "0xF90E10", VA = "0xF90E10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C103C", Offset = "0x5C103C")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xF90E18", Offset = "0xF90E18", VA = "0xF90E18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C104C", Offset = "0x5C104C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xF90E20", Offset = "0xF90E20", VA = "0xF90E20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C105C", Offset = "0x5C105C")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0xF90E28", Offset = "0xF90E28", VA = "0xF90E28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C106C", Offset = "0x5C106C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014D")]
		[Address(RVA = "0xF90E30", Offset = "0xF90E30", VA = "0xF90E30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C107C", Offset = "0x5C107C")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xF90E38", Offset = "0xF90E38", VA = "0xF90E38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C108C", Offset = "0x5C108C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xF90E40", Offset = "0xF90E40", VA = "0xF90E40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C109C", Offset = "0x5C109C")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xF90E48", Offset = "0xF90E48", VA = "0xF90E48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C10AC", Offset = "0x5C10AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xF90E50", Offset = "0xF90E50", VA = "0xF90E50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C10BC", Offset = "0x5C10BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0xF90E58", Offset = "0xF90E58", VA = "0xF90E58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C10CC", Offset = "0x5C10CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xF90E60", Offset = "0xF90E60", VA = "0xF90E60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C10DC", Offset = "0x5C10DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0xF90E68", Offset = "0xF90E68", VA = "0xF90E68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C10EC", Offset = "0x5C10EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000155")]
		[Address(RVA = "0xF90E70", Offset = "0xF90E70", VA = "0xF90E70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C10FC", Offset = "0x5C10FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public Action<Color, object> onUpdateColorObject
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xF90E78", Offset = "0xF90E78", VA = "0xF90E78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C110C", Offset = "0x5C110C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000157")]
		[Address(RVA = "0xF90E80", Offset = "0xF90E80", VA = "0xF90E80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C111C", Offset = "0x5C111C")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public Action onComplete
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0xF90E88", Offset = "0xF90E88", VA = "0xF90E88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C112C", Offset = "0x5C112C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0xF90E90", Offset = "0xF90E90", VA = "0xF90E90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C113C", Offset = "0x5C113C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0xF90E98", Offset = "0xF90E98", VA = "0xF90E98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C114C", Offset = "0x5C114C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015B")]
		[Address(RVA = "0xF90EA0", Offset = "0xF90EA0", VA = "0xF90EA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C115C", Offset = "0x5C115C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public object onCompleteParam
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0xF90EA8", Offset = "0xF90EA8", VA = "0xF90EA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C116C", Offset = "0x5C116C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015D")]
		[Address(RVA = "0xF90EB0", Offset = "0xF90EB0", VA = "0xF90EB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C117C", Offset = "0x5C117C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public object onUpdateParam
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0xF90EB8", Offset = "0xF90EB8", VA = "0xF90EB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C118C", Offset = "0x5C118C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xF90EC0", Offset = "0xF90EC0", VA = "0xF90EC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C119C", Offset = "0x5C119C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public Action onStart
	{
		[Token(Token = "0x6000160")]
		[Address(RVA = "0xF90EC8", Offset = "0xF90EC8", VA = "0xF90EC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C11AC", Offset = "0x5C11AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xF90ED0", Offset = "0xF90ED0", VA = "0xF90ED0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C11BC", Offset = "0x5C11BC")]
		set
		{
		}
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xF829FC", Offset = "0xF829FC", VA = "0xF829FC")]
	public void reset()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xF8564C", Offset = "0xF8564C", VA = "0xF8564C")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xF827E4", Offset = "0xF827E4", VA = "0xF827E4")]
	public LTDescrOptional()
	{
	}
}
[Token(Token = "0x2000004")]
public class LTSeq
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LTSeq previous;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LTSeq current;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LTDescr tween;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float totalDelay;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeScale;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int debugIter;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public uint counter;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool toggle;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private uint _id;

	[Token(Token = "0x1700001E")]
	public int id
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xF936C8", Offset = "0xF936C8", VA = "0xF936C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xF936D8", Offset = "0xF936D8", VA = "0xF936D8")]
	public void reset()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xF936E8", Offset = "0xF936E8", VA = "0xF936E8")]
	public void init(uint id, uint global_counter)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xF93700", Offset = "0xF93700", VA = "0xF93700")]
	private LTSeq addOn()
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xF937C0", Offset = "0xF937C0", VA = "0xF937C0")]
	private float addPreviousDelays()
	{
		return default(float);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xF937FC", Offset = "0xF937FC", VA = "0xF937FC")]
	public LTSeq append(float delay)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xF93824", Offset = "0xF93824", VA = "0xF93824")]
	public LTSeq append(Action callback)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xF93908", Offset = "0xF93908", VA = "0xF93908")]
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xF939B4", Offset = "0xF939B4", VA = "0xF939B4")]
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xF93A48", Offset = "0xF93A48", VA = "0xF93A48")]
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xF938A8", Offset = "0xF938A8", VA = "0xF938A8")]
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xF93B04", Offset = "0xF93B04", VA = "0xF93B04")]
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xF93B44", Offset = "0xF93B44", VA = "0xF93B44")]
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xF93B70", Offset = "0xF93B70", VA = "0xF93B70")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xF93BF8", Offset = "0xF93BF8", VA = "0xF93BF8")]
	public LTSeq reverse()
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xF93BFC", Offset = "0xF93BFC", VA = "0xF93BFC")]
	public LTSeq()
	{
	}
}
[Token(Token = "0x2000005")]
public class LeanAudioStream
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int position;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip audioClip;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] audioArr;

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xF2442C", Offset = "0xF2442C", VA = "0xF2442C")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xF24C20", Offset = "0xF24C20", VA = "0xF24C20")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xF24CA4", Offset = "0xF24CA4", VA = "0xF24CA4")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int generatedWaveDistancesCount;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float[] longList;

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xF237B0", Offset = "0xF237B0", VA = "0xF237B0")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xF238D4", Offset = "0xF238D4", VA = "0xF238D4")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xF2436C", Offset = "0xF2436C", VA = "0xF2436C")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xF239A8", Offset = "0xF239A8", VA = "0xF239A8")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xF23E20", Offset = "0xF23E20", VA = "0xF23E20")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xF24458", Offset = "0xF24458", VA = "0xF24458")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xF2445C", Offset = "0xF2445C", VA = "0xF2445C")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xF245C0", Offset = "0xF245C0", VA = "0xF245C0")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xF247C0", Offset = "0xF247C0", VA = "0xF247C0")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xF24874", Offset = "0xF24874", VA = "0xF24874")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xF24900", Offset = "0xF24900", VA = "0xF24900")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xF24698", Offset = "0xF24698", VA = "0xF24698")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xF249C0", Offset = "0xF249C0", VA = "0xF249C0")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xF24B50", Offset = "0xF24B50", VA = "0xF24B50")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x2000007")]
public class LeanAudioOptions
{
	[Token(Token = "0x2000046")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x40002E5")]
		Sine,
		[Token(Token = "0x40002E6")]
		Square,
		[Token(Token = "0x40002E7")]
		Sawtooth,
		[Token(Token = "0x40002E8")]
		Noise
	}

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LeanAudioWaveStyle waveStyle;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] vibrato;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] modulation;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int frequencyRate;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float waveNoiseScale;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float waveNoiseInfluence;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool useSetData;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LeanAudioStream stream;

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xF238B0", Offset = "0xF238B0", VA = "0xF238B0")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xF24BCC", Offset = "0xF24BCC", VA = "0xF24BCC")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xF24BD4", Offset = "0xF24BD4", VA = "0xF24BD4")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xF24BDC", Offset = "0xF24BDC", VA = "0xF24BDC")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xF24BE4", Offset = "0xF24BE4", VA = "0xF24BE4")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xF24BF0", Offset = "0xF24BF0", VA = "0xF24BF0")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xF24BFC", Offset = "0xF24BFC", VA = "0xF24BFC")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xF24C08", Offset = "0xF24C08", VA = "0xF24C08")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xF24C10", Offset = "0xF24C10", VA = "0xF24C10")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xF24C18", Offset = "0xF24C18", VA = "0xF24C18")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000008")]
public class LeanSmooth
{
	[Token(Token = "0x6000191")]
	[Address(RVA = "0xF24CAC", Offset = "0xF24CAC", VA = "0xF24CAC")]
	public static float damp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xF24E48", Offset = "0xF24E48", VA = "0xF24E48")]
	public static Vector3 damp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xF24F24", Offset = "0xF24F24", VA = "0xF24F24")]
	public static Color damp(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f)
	{
		return default(Color);
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xF25020", Offset = "0xF25020", VA = "0xF25020")]
	public static float spring(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		return default(float);
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xF25144", Offset = "0xF25144", VA = "0xF25144")]
	public static Vector3 spring(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xF25240", Offset = "0xF25240", VA = "0xF25240")]
	public static Color spring(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		return default(Color);
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xF25368", Offset = "0xF25368", VA = "0xF25368")]
	public static float linear(float current, float target, float moveSpeed, float deltaTime = -1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xF253E0", Offset = "0xF253E0", VA = "0xF253E0")]
	public static Vector3 linear(Vector3 current, Vector3 target, float moveSpeed, float deltaTime = -1f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xF25538", Offset = "0xF25538", VA = "0xF25538")]
	public static Color linear(Color current, Color target, float moveSpeed)
	{
		return default(Color);
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xF256B0", Offset = "0xF256B0", VA = "0xF256B0")]
	public static float bounceOut(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		return default(float);
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xF2580C", Offset = "0xF2580C", VA = "0xF2580C")]
	public static Vector3 bounceOut(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xF25910", Offset = "0xF25910", VA = "0xF25910")]
	public static Color bounceOut(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1f, float deltaTime = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		return default(Color);
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xF25A48", Offset = "0xF25A48", VA = "0xF25A48")]
	public LeanSmooth()
	{
	}
}
[Token(Token = "0x2000009")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01C8", Offset = "0x5C01C8")]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeanTester <>4__this;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xF26A14", Offset = "0xF26A14", VA = "0xF26A14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xF26A7C", Offset = "0xF26A7C", VA = "0xF26A7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xF26874", Offset = "0xF26874", VA = "0xF26874")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xF268B0", Offset = "0xF268B0", VA = "0xF268B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xF268B4", Offset = "0xF268B4", VA = "0xF268B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xF26A1C", Offset = "0xF26A1C", VA = "0xF26A1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeout;

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xF267D8", Offset = "0xF267D8", VA = "0xF267D8")]
	public void Start()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xF26804", Offset = "0xF26804", VA = "0xF26804")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C11CC", Offset = "0x5C11CC")]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xF268A0", Offset = "0xF268A0", VA = "0xF268A0")]
	public LeanTester()
	{
	}
}
[Token(Token = "0x200000A")]
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

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xF25A50", Offset = "0xF25A50", VA = "0xF25A50")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xF25ACC", Offset = "0xF25ACC", VA = "0xF25ACC")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xF26664", Offset = "0xF26664", VA = "0xF26664")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xF26060", Offset = "0xF26060", VA = "0xF26060")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xF266D4", Offset = "0xF266D4", VA = "0xF266D4")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xF26190", Offset = "0xF26190", VA = "0xF26190")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xF261F0", Offset = "0xF261F0", VA = "0xF261F0")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xF26364", Offset = "0xF26364", VA = "0xF26364")]
	public static void overview()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xF2674C", Offset = "0xF2674C", VA = "0xF2674C")]
	public LeanTest()
	{
	}
}
[Token(Token = "0x200000B")]
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
	CANVAS_SIZEDELTA,
	[Token(Token = "0x400009C")]
	FOLLOW
}
[Token(Token = "0x200000C")]
public enum LeanTweenType
{
	[Token(Token = "0x400009E")]
	notUsed,
	[Token(Token = "0x400009F")]
	linear,
	[Token(Token = "0x40000A0")]
	easeOutQuad,
	[Token(Token = "0x40000A1")]
	easeInQuad,
	[Token(Token = "0x40000A2")]
	easeInOutQuad,
	[Token(Token = "0x40000A3")]
	easeInCubic,
	[Token(Token = "0x40000A4")]
	easeOutCubic,
	[Token(Token = "0x40000A5")]
	easeInOutCubic,
	[Token(Token = "0x40000A6")]
	easeInQuart,
	[Token(Token = "0x40000A7")]
	easeOutQuart,
	[Token(Token = "0x40000A8")]
	easeInOutQuart,
	[Token(Token = "0x40000A9")]
	easeInQuint,
	[Token(Token = "0x40000AA")]
	easeOutQuint,
	[Token(Token = "0x40000AB")]
	easeInOutQuint,
	[Token(Token = "0x40000AC")]
	easeInSine,
	[Token(Token = "0x40000AD")]
	easeOutSine,
	[Token(Token = "0x40000AE")]
	easeInOutSine,
	[Token(Token = "0x40000AF")]
	easeInExpo,
	[Token(Token = "0x40000B0")]
	easeOutExpo,
	[Token(Token = "0x40000B1")]
	easeInOutExpo,
	[Token(Token = "0x40000B2")]
	easeInCirc,
	[Token(Token = "0x40000B3")]
	easeOutCirc,
	[Token(Token = "0x40000B4")]
	easeInOutCirc,
	[Token(Token = "0x40000B5")]
	easeInBounce,
	[Token(Token = "0x40000B6")]
	easeOutBounce,
	[Token(Token = "0x40000B7")]
	easeInOutBounce,
	[Token(Token = "0x40000B8")]
	easeInBack,
	[Token(Token = "0x40000B9")]
	easeOutBack,
	[Token(Token = "0x40000BA")]
	easeInOutBack,
	[Token(Token = "0x40000BB")]
	easeInElastic,
	[Token(Token = "0x40000BC")]
	easeOutElastic,
	[Token(Token = "0x40000BD")]
	easeInOutElastic,
	[Token(Token = "0x40000BE")]
	easeSpring,
	[Token(Token = "0x40000BF")]
	easeShake,
	[Token(Token = "0x40000C0")]
	punch,
	[Token(Token = "0x40000C1")]
	once,
	[Token(Token = "0x40000C2")]
	clamp,
	[Token(Token = "0x40000C3")]
	pingPong,
	[Token(Token = "0x40000C4")]
	animationCurve
}
[Token(Token = "0x200000D")]
public enum LeanProp
{
	[Token(Token = "0x40000C6")]
	position,
	[Token(Token = "0x40000C7")]
	localPosition,
	[Token(Token = "0x40000C8")]
	x,
	[Token(Token = "0x40000C9")]
	y,
	[Token(Token = "0x40000CA")]
	z,
	[Token(Token = "0x40000CB")]
	localX,
	[Token(Token = "0x40000CC")]
	localY,
	[Token(Token = "0x40000CD")]
	localZ,
	[Token(Token = "0x40000CE")]
	scale,
	[Token(Token = "0x40000CF")]
	color
}
[Token(Token = "0x200000E")]
public class LeanTween : MonoBehaviour
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01D8", Offset = "0x5C01D8")]
	private sealed class <>c__DisplayClass193_0
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LTDescr d;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float smoothTime;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxSpeed;

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xF316A0", Offset = "0xF316A0", VA = "0xF316A0")]
		public <>c__DisplayClass193_0()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xF33024", Offset = "0xF33024", VA = "0xF33024")]
		internal void <followDamp>b__0()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xF3318C", Offset = "0xF3318C", VA = "0xF3318C")]
		internal void <followDamp>b__1()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xF332F4", Offset = "0xF332F4", VA = "0xF332F4")]
		internal void <followDamp>b__2()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xF3341C", Offset = "0xF3341C", VA = "0xF3341C")]
		internal void <followDamp>b__3()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xF33544", Offset = "0xF33544", VA = "0xF33544")]
		internal void <followDamp>b__4()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xF3366C", Offset = "0xF3366C", VA = "0xF3366C")]
		internal void <followDamp>b__5()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xF33794", Offset = "0xF33794", VA = "0xF33794")]
		internal void <followDamp>b__6()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xF338BC", Offset = "0xF338BC", VA = "0xF338BC")]
		internal void <followDamp>b__7()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xF339E4", Offset = "0xF339E4", VA = "0xF339E4")]
		internal void <followDamp>b__8()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xF33AC8", Offset = "0xF33AC8", VA = "0xF33AC8")]
		internal void <followDamp>b__9()
		{
		}
	}

	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01E8", Offset = "0x5C01E8")]
	private sealed class <>c__DisplayClass194_0
	{
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LTDescr d;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float smoothTime;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxSpeed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float friction;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float accelRate;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xF31994", Offset = "0xF31994", VA = "0xF31994")]
		public <>c__DisplayClass194_0()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xF33C88", Offset = "0xF33C88", VA = "0xF33C88")]
		internal void <followSpring>b__0()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xF33DFC", Offset = "0xF33DFC", VA = "0xF33DFC")]
		internal void <followSpring>b__1()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xF33EF4", Offset = "0xF33EF4", VA = "0xF33EF4")]
		internal void <followSpring>b__2()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xF33FA8", Offset = "0xF33FA8", VA = "0xF33FA8")]
		internal void <followSpring>b__3()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xF3405C", Offset = "0xF3405C", VA = "0xF3405C")]
		internal void <followSpring>b__4()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xF34110", Offset = "0xF34110", VA = "0xF34110")]
		internal void <followSpring>b__5()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xF341C4", Offset = "0xF341C4", VA = "0xF341C4")]
		internal void <followSpring>b__6()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xF34278", Offset = "0xF34278", VA = "0xF34278")]
		internal void <followSpring>b__7()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xF3432C", Offset = "0xF3432C", VA = "0xF3432C")]
		internal void <followSpring>b__8()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xF34424", Offset = "0xF34424", VA = "0xF34424")]
		internal void <followSpring>b__9()
		{
		}
	}

	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01F8", Offset = "0x5C01F8")]
	private sealed class <>c__DisplayClass195_0
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LTDescr d;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float smoothTime;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxSpeed;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float friction;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float accelRate;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float hitDamping;

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xF31C78", Offset = "0xF31C78", VA = "0xF31C78")]
		public <>c__DisplayClass195_0()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xF34580", Offset = "0xF34580", VA = "0xF34580")]
		internal void <followBounceOut>b__0()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xF346FC", Offset = "0xF346FC", VA = "0xF346FC")]
		internal void <followBounceOut>b__1()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xF34878", Offset = "0xF34878", VA = "0xF34878")]
		internal void <followBounceOut>b__2()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xF34930", Offset = "0xF34930", VA = "0xF34930")]
		internal void <followBounceOut>b__3()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xF349E8", Offset = "0xF349E8", VA = "0xF349E8")]
		internal void <followBounceOut>b__4()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xF34AA0", Offset = "0xF34AA0", VA = "0xF34AA0")]
		internal void <followBounceOut>b__5()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xF34B58", Offset = "0xF34B58", VA = "0xF34B58")]
		internal void <followBounceOut>b__6()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xF34C10", Offset = "0xF34C10", VA = "0xF34C10")]
		internal void <followBounceOut>b__7()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xF34CC8", Offset = "0xF34CC8", VA = "0xF34CC8")]
		internal void <followBounceOut>b__8()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xF34DC8", Offset = "0xF34DC8", VA = "0xF34DC8")]
		internal void <followBounceOut>b__9()
		{
		}
	}

	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0208", Offset = "0x5C0208")]
	private sealed class <>c__DisplayClass196_0
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LTDescr d;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float moveSpeed;

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xF31F3C", Offset = "0xF31F3C", VA = "0xF31F3C")]
		public <>c__DisplayClass196_0()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xF34F2C", Offset = "0xF34F2C", VA = "0xF34F2C")]
		internal void <followLinear>b__0()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xF35050", Offset = "0xF35050", VA = "0xF35050")]
		internal void <followLinear>b__1()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xF350F0", Offset = "0xF350F0", VA = "0xF350F0")]
		internal void <followLinear>b__2()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xF351A8", Offset = "0xF351A8", VA = "0xF351A8")]
		internal void <followLinear>b__3()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xF35260", Offset = "0xF35260", VA = "0xF35260")]
		internal void <followLinear>b__4()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xF35318", Offset = "0xF35318", VA = "0xF35318")]
		internal void <followLinear>b__5()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xF353D0", Offset = "0xF353D0", VA = "0xF353D0")]
		internal void <followLinear>b__6()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xF35488", Offset = "0xF35488", VA = "0xF35488")]
		internal void <followLinear>b__7()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xF35540", Offset = "0xF35540", VA = "0xF35540")]
		internal void <followLinear>b__8()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xF355E0", Offset = "0xF355E0", VA = "0xF355E0")]
		internal void <followLinear>b__9()
		{
		}
	}

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool throwErrors;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float tau;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float PI_DIV2;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTSeq[] sequences;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static LTDescr[] tweens;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int[] tweensFinished;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] tweensFinishedIds;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static LTDescr tween;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int tweenMaxSearch;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int maxTweens;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static int maxSequences;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static int frameRendered;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static GameObject _tweenEmpty;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static float dtEstimated;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public static float dtManual;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static float dtActual;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static uint global_counter;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static int i;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static int j;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static int finishedCnt;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static AnimationCurve punch;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static AnimationCurve shake;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static int maxTweenReached;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public static int startSearch;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static LTDescr d;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static Action<LTEvent>[] eventListeners;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static GameObject[] goListeners;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static int eventsMaxSearch;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public static int EVENTS_MAX;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static int LISTENERS_MAX;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private static int INIT_LISTENERS_MAX;

	[Token(Token = "0x1700001F")]
	public static int maxSearch
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xF26B5C", Offset = "0xF26B5C", VA = "0xF26B5C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000020")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xF26BC4", Offset = "0xF26BC4", VA = "0xF26BC4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000021")]
	public static int tweensRunning
	{
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xF26C2C", Offset = "0xF26C2C", VA = "0xF26C2C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000022")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xF2AE10", Offset = "0xF2AE10", VA = "0xF2AE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xF26A84", Offset = "0xF26A84", VA = "0xF26A84")]
	public static void init()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xF26AEC", Offset = "0xF26AEC", VA = "0xF26AEC")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xF26D0C", Offset = "0xF26D0C", VA = "0xF26D0C")]
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xF2711C", Offset = "0xF2711C", VA = "0xF2711C")]
	public static void reset()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xF272A8", Offset = "0xF272A8", VA = "0xF272A8")]
	public void Update()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xF277D8", Offset = "0xF277D8", VA = "0xF277D8")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xF27848", Offset = "0xF27848", VA = "0xF27848")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xF27304", Offset = "0xF27304", VA = "0xF27304")]
	public static void update()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xF27CA8", Offset = "0xF27CA8", VA = "0xF27CA8")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xF278A8", Offset = "0xF278A8", VA = "0xF278A8")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xF27D88", Offset = "0xF27D88", VA = "0xF27D88")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xF27F44", Offset = "0xF27F44", VA = "0xF27F44")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xF28004", Offset = "0xF28004", VA = "0xF28004")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xF28064", Offset = "0xF28064", VA = "0xF28064")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xF28260", Offset = "0xF28260", VA = "0xF28260")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xF282C8", Offset = "0xF282C8", VA = "0xF282C8")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xF2845C", Offset = "0xF2845C", VA = "0xF2845C")]
	public static void cancel(RectTransform rect)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xF284E0", Offset = "0xF284E0", VA = "0xF284E0")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xF2878C", Offset = "0xF2878C", VA = "0xF2878C")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xF288C4", Offset = "0xF288C4", VA = "0xF288C4")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xF2892C", Offset = "0xF2892C", VA = "0xF2892C")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xF28BC8", Offset = "0xF28BC8", VA = "0xF28BC8")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xF28E64", Offset = "0xF28E64", VA = "0xF28E64")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xF28EC8", Offset = "0xF28EC8", VA = "0xF28EC8")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xF29104", Offset = "0xF29104", VA = "0xF29104")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C1230", Offset = "0x5C1230")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xF29168", Offset = "0xF29168", VA = "0xF29168")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xF2926C", Offset = "0xF2926C", VA = "0xF2926C")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xF293E0", Offset = "0xF293E0", VA = "0xF293E0")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xF294CC", Offset = "0xF294CC", VA = "0xF294CC")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xF295B8", Offset = "0xF295B8", VA = "0xF295B8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C1268", Offset = "0x5C1268")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xF2961C", Offset = "0xF2961C", VA = "0xF2961C")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xF29720", Offset = "0xF29720", VA = "0xF29720")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xF29894", Offset = "0xF29894", VA = "0xF29894")]
	public static bool isPaused([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xF29B44", Offset = "0xF29B44", VA = "0xF29B44")]
	public static bool isPaused(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xF29DF0", Offset = "0xF29DF0", VA = "0xF29DF0")]
	public static bool isPaused(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xF29BC4", Offset = "0xF29BC4", VA = "0xF29BC4")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xF29F5C", Offset = "0xF29F5C", VA = "0xF29F5C")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xF29FDC", Offset = "0xF29FDC", VA = "0xF29FDC")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xF2A108", Offset = "0xF2A108", VA = "0xF2A108")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xF2A244", Offset = "0xF2A244", VA = "0xF2A244")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xF2A8D8", Offset = "0xF2A8D8", VA = "0xF2A8D8")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xF2A998", Offset = "0xF2A998", VA = "0xF2A998")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xF2AA0C", Offset = "0xF2AA0C", VA = "0xF2AA0C")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xF2AE88", Offset = "0xF2AE88", VA = "0xF2AE88")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xF2AFA0", Offset = "0xF2AFA0", VA = "0xF2AFA0")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xF2B0BC", Offset = "0xF2B0BC", VA = "0xF2B0BC")]
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xF2B340", Offset = "0xF2B340", VA = "0xF2B340")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xF2B42C", Offset = "0xF2B42C", VA = "0xF2B42C")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xF2B514", Offset = "0xF2B514", VA = "0xF2B514")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xF2B5EC", Offset = "0xF2B5EC", VA = "0xF2B5EC")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xF2B6C4", Offset = "0xF2B6C4", VA = "0xF2B6C4")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xF2B79C", Offset = "0xF2B79C", VA = "0xF2B79C")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xF2B860", Offset = "0xF2B860", VA = "0xF2B860")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xF2B9A4", Offset = "0xF2B9A4", VA = "0xF2B9A4")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xF2BAD4", Offset = "0xF2BAD4", VA = "0xF2BAD4")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xF2BC04", Offset = "0xF2BC04", VA = "0xF2BC04")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xF2BCF4", Offset = "0xF2BCF4", VA = "0xF2BCF4")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xF2BDE4", Offset = "0xF2BDE4", VA = "0xF2BDE4")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xF2BED4", Offset = "0xF2BED4", VA = "0xF2BED4")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xF2BFC4", Offset = "0xF2BFC4", VA = "0xF2BFC4")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xF2C0C4", Offset = "0xF2C0C4", VA = "0xF2C0C4")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xF2C170", Offset = "0xF2C170", VA = "0xF2C170")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xF2C258", Offset = "0xF2C258", VA = "0xF2C258")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xF2C40C", Offset = "0xF2C40C", VA = "0xF2C40C")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xF2C504", Offset = "0xF2C504", VA = "0xF2C504")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xF2C5FC", Offset = "0xF2C5FC", VA = "0xF2C5FC")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xF2C71C", Offset = "0xF2C71C", VA = "0xF2C71C")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xF2C814", Offset = "0xF2C814", VA = "0xF2C814")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xF2C934", Offset = "0xF2C934", VA = "0xF2C934")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xF2CA34", Offset = "0xF2CA34", VA = "0xF2CA34")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xF2CB34", Offset = "0xF2CB34", VA = "0xF2CB34")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xF2CBF8", Offset = "0xF2CBF8", VA = "0xF2CBF8")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xF2CCBC", Offset = "0xF2CCBC", VA = "0xF2CCBC")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xF2CD80", Offset = "0xF2CD80", VA = "0xF2CD80")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xF2CE2C", Offset = "0xF2CE2C", VA = "0xF2CE2C")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xF2CFE0", Offset = "0xF2CFE0", VA = "0xF2CFE0")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xF2D0A4", Offset = "0xF2D0A4", VA = "0xF2D0A4")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xF2D168", Offset = "0xF2D168", VA = "0xF2D168")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xF2D22C", Offset = "0xF2D22C", VA = "0xF2D22C")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xF2D324", Offset = "0xF2D324", VA = "0xF2D324")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xF2D41C", Offset = "0xF2D41C", VA = "0xF2D41C")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xF2D50C", Offset = "0xF2D50C", VA = "0xF2D50C")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xF2D5B8", Offset = "0xF2D5B8", VA = "0xF2D5B8")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xF2D694", Offset = "0xF2D694", VA = "0xF2D694")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xF2D740", Offset = "0xF2D740", VA = "0xF2D740")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xF2D804", Offset = "0xF2D804", VA = "0xF2D804")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xF2D8C8", Offset = "0xF2D8C8", VA = "0xF2D8C8")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xF2D98C", Offset = "0xF2D98C", VA = "0xF2D98C")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xF2DA84", Offset = "0xF2DA84", VA = "0xF2DA84")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xF2DB7C", Offset = "0xF2DB7C", VA = "0xF2DB7C")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xF2DC28", Offset = "0xF2DC28", VA = "0xF2DC28")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xF2DD28", Offset = "0xF2DD28", VA = "0xF2DD28")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xF2DDEC", Offset = "0xF2DDEC", VA = "0xF2DDEC")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xF2DEB0", Offset = "0xF2DEB0", VA = "0xF2DEB0")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xF2DF74", Offset = "0xF2DF74", VA = "0xF2DF74")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xF2E080", Offset = "0xF2E080", VA = "0xF2E080")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xF2E190", Offset = "0xF2E190", VA = "0xF2E190")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xF2E2E8", Offset = "0xF2E2E8", VA = "0xF2E2E8")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xF2E3C8", Offset = "0xF2E3C8", VA = "0xF2E3C8")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xF2E550", Offset = "0xF2E550", VA = "0xF2E550")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xF2E6B4", Offset = "0xF2E6B4", VA = "0xF2E6B4")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xF2E818", Offset = "0xF2E818", VA = "0xF2E818")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xF2E9F0", Offset = "0xF2E9F0", VA = "0xF2E9F0")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xF2EBC8", Offset = "0xF2EBC8", VA = "0xF2EBC8")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xF2ED3C", Offset = "0xF2ED3C", VA = "0xF2ED3C")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xF2EE50", Offset = "0xF2EE50", VA = "0xF2EE50")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xF2EFB8", Offset = "0xF2EFB8", VA = "0xF2EFB8")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xF2F0E4", Offset = "0xF2F0E4", VA = "0xF2F0E4")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xF2F20C", Offset = "0xF2F20C", VA = "0xF2F20C")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xF2F2E0", Offset = "0xF2F2E0", VA = "0xF2F2E0")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xF2F3C8", Offset = "0xF2F3C8", VA = "0xF2F3C8")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xF2F4B0", Offset = "0xF2F4B0", VA = "0xF2F4B0")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xF2F598", Offset = "0xF2F598", VA = "0xF2F598")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xF2F6C0", Offset = "0xF2F6C0", VA = "0xF2F6C0")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xF2F7D4", Offset = "0xF2F7D4", VA = "0xF2F7D4")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xF2F8F0", Offset = "0xF2F8F0", VA = "0xF2F8F0")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xF2FA0C", Offset = "0xF2FA0C", VA = "0xF2FA0C")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xF2FAE0", Offset = "0xF2FAE0", VA = "0xF2FAE0")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xF2FBEC", Offset = "0xF2FBEC", VA = "0xF2FBEC")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xF2FCD4", Offset = "0xF2FCD4", VA = "0xF2FCD4")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xF2FE14", Offset = "0xF2FE14", VA = "0xF2FE14")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xF2FE60", Offset = "0xF2FE60", VA = "0xF2FE60")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xF2FF60", Offset = "0xF2FF60", VA = "0xF2FF60")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xF2FF78", Offset = "0xF2FF78", VA = "0xF2FF78")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xF2FF88", Offset = "0xF2FF88", VA = "0xF2FF88")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xF2FFD8", Offset = "0xF2FFD8", VA = "0xF2FFD8")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xF30114", Offset = "0xF30114", VA = "0xF30114")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xF3019C", Offset = "0xF3019C", VA = "0xF3019C")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xF30270", Offset = "0xF30270", VA = "0xF30270")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xF30374", Offset = "0xF30374", VA = "0xF30374")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xF30388", Offset = "0xF30388", VA = "0xF30388")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xF303A4", Offset = "0xF303A4", VA = "0xF303A4")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xF303F8", Offset = "0xF303F8", VA = "0xF303F8")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xF30430", Offset = "0xF30430", VA = "0xF30430")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xF30448", Offset = "0xF30448", VA = "0xF30448")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xF30470", Offset = "0xF30470", VA = "0xF30470")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xF304C8", Offset = "0xF304C8", VA = "0xF304C8")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xF304E4", Offset = "0xF304E4", VA = "0xF304E4")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xF3050C", Offset = "0xF3050C", VA = "0xF3050C")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xF30568", Offset = "0xF30568", VA = "0xF30568")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xF30588", Offset = "0xF30588", VA = "0xF30588")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xF305B8", Offset = "0xF305B8", VA = "0xF305B8")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xF30620", Offset = "0xF30620", VA = "0xF30620")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xF306B8", Offset = "0xF306B8", VA = "0xF306B8")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xF3074C", Offset = "0xF3074C", VA = "0xF3074C")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xF307F0", Offset = "0xF307F0", VA = "0xF307F0")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xF30888", Offset = "0xF30888", VA = "0xF30888")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xF30920", Offset = "0xF30920", VA = "0xF30920")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xF30A10", Offset = "0xF30A10", VA = "0xF30A10")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xF30ABC", Offset = "0xF30ABC", VA = "0xF30ABC")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xF30B68", Offset = "0xF30B68", VA = "0xF30B68")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xF30C60", Offset = "0xF30C60", VA = "0xF30C60")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xF30CF8", Offset = "0xF30CF8", VA = "0xF30CF8")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xF30DC4", Offset = "0xF30DC4", VA = "0xF30DC4")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xF30E9C", Offset = "0xF30E9C", VA = "0xF30E9C")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xF30ED0", Offset = "0xF30ED0", VA = "0xF30ED0")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xF30F10", Offset = "0xF30F10", VA = "0xF30F10")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xF30FA8", Offset = "0xF30FA8", VA = "0xF30FA8")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xF310DC", Offset = "0xF310DC", VA = "0xF310DC")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xF31200", Offset = "0xF31200", VA = "0xF31200")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xF313C0", Offset = "0xF313C0", VA = "0xF313C0")]
	public static LTDescr followDamp(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xF316A8", Offset = "0xF316A8", VA = "0xF316A8")]
	public static LTDescr followSpring(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f, float friction = 2f, float accelRate = 0.5f)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xF3199C", Offset = "0xF3199C", VA = "0xF3199C")]
	public static LTDescr followBounceOut(Transform trans, Transform target, LeanProp prop, float smoothTime, float maxSpeed = -1f, float friction = 2f, float accelRate = 0.5f, float hitDamping = 0.9f)
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xF31C80", Offset = "0xF31C80", VA = "0xF31C80")]
	public static LTDescr followLinear(Transform trans, Transform target, LeanProp prop, float moveSpeed)
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xF31F44", Offset = "0xF31F44", VA = "0xF31F44")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xF31FBC", Offset = "0xF31FBC", VA = "0xF31FBC")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xF32468", Offset = "0xF32468", VA = "0xF32468")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xF3270C", Offset = "0xF3270C", VA = "0xF3270C")]
	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xF324E0", Offset = "0xF324E0", VA = "0xF324E0")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xF327D8", Offset = "0xF327D8", VA = "0xF327D8")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xF32840", Offset = "0xF32840", VA = "0xF32840")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xF32A60", Offset = "0xF32A60", VA = "0xF32A60")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x200000F")]
public class LTUtility
{
	[Token(Token = "0x600025C")]
	[Address(RVA = "0xF23700", Offset = "0xF23700", VA = "0xF23700")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xF237A8", Offset = "0xF237A8", VA = "0xF237A8")]
	public LTUtility()
	{
	}
}
[Token(Token = "0x2000010")]
public class LTBezier
{
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float length;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 a;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 aa;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 bb;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 cc;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float len;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] arcLengths;

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xF80D88", Offset = "0xF80D88", VA = "0xF80D88")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xF811D0", Offset = "0xF811D0", VA = "0xF811D0")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xF810F8", Offset = "0xF810F8", VA = "0xF810F8")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xF812D4", Offset = "0xF812D4", VA = "0xF812D4")]
	public Vector3 point(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000011")]
public class LTBezierPath
{
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] pts;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float length;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orientToPath;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTBezier[] beziers;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] lengthRatio;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentBezier;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int previousBezier;

	[Token(Token = "0x17000023")]
	public float distance
	{
		[Token(Token = "0x6000265")]
		[Address(RVA = "0xF81660", Offset = "0xF81660", VA = "0xF81660")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xF812F8", Offset = "0xF812F8", VA = "0xF812F8")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xF81300", Offset = "0xF81300", VA = "0xF81300")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xF81330", Offset = "0xF81330", VA = "0xF81330")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xF81668", Offset = "0xF81668", VA = "0xF81668")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xF81740", Offset = "0xF81740", VA = "0xF81740")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xF818C4", Offset = "0xF818C4", VA = "0xF818C4")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xF81A48", Offset = "0xF81A48", VA = "0xF81A48")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xF81AEC", Offset = "0xF81AEC", VA = "0xF81AEC")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xF81B8C", Offset = "0xF81B8C", VA = "0xF81B8C")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xF81C30", Offset = "0xF81C30", VA = "0xF81C30")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xF81D64", Offset = "0xF81D64", VA = "0xF81D64")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xF81E40", Offset = "0xF81E40", VA = "0xF81E40")]
	public float ratioAtPoint(Vector3 pt, float precision = 0.01f)
	{
		return default(float);
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class LTSpline
{
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float distance;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool constantSpeed;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] pts;

	[NonSerialized]
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] ptsAdj;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ptsAdjLength;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool orientToPath;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool orientToPath2d;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int numSections;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int currPt;

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xF8BBE4", Offset = "0xF8BBE4", VA = "0xF8BBE4")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xF93FB0", Offset = "0xF93FB0", VA = "0xF93FB0")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xF93C04", Offset = "0xF93C04", VA = "0xF93C04")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xF9443C", Offset = "0xF9443C", VA = "0xF9443C")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xF93FFC", Offset = "0xF93FFC", VA = "0xF93FFC")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xF945E4", Offset = "0xF945E4", VA = "0xF945E4")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xF8C5C0", Offset = "0xF8C5C0", VA = "0xF8C5C0")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xF8C398", Offset = "0xF8C398", VA = "0xF8C398")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xF8C6B4", Offset = "0xF8C6B4", VA = "0xF8C6B4")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xF8C51C", Offset = "0xF8C51C", VA = "0xF8C51C")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xF94728", Offset = "0xF94728", VA = "0xF94728")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xF8C8AC", Offset = "0xF8C8AC", VA = "0xF8C8AC")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xF947C8", Offset = "0xF947C8", VA = "0xF947C8")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xF94898", Offset = "0xF94898", VA = "0xF94898")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xF94960", Offset = "0xF94960", VA = "0xF94960")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xF94AC4", Offset = "0xF94AC4", VA = "0xF94AC4")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xF94D04", Offset = "0xF94D04", VA = "0xF94D04")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xF94D18", Offset = "0xF94D18", VA = "0xF94D18")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xF94EF4", Offset = "0xF94EF4", VA = "0xF94EF4")]
	public Vector3[] generateVectors()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class LTRect
{
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rect _rect;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float alpha;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rotation;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 pivot;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 margin;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rect relativeRect;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool rotateEnabled;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[HideInInspector]
	public bool rotateFinished;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool alphaEnabled;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string labelStr;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LTGUI.Element_Type type;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle style;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool useColor;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color color;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool fontScaleToFit;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool useSimpleScale;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	public bool sizeByHeight;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture texture;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _id;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public int counter;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x17000024")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x6000288")]
		[Address(RVA = "0xF920B8", Offset = "0xF920B8", VA = "0xF920B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000025")]
	public int id
	{
		[Token(Token = "0x6000289")]
		[Address(RVA = "0xF92820", Offset = "0xF92820", VA = "0xF92820")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000026")]
	public float x
	{
		[Token(Token = "0x600028D")]
		[Address(RVA = "0xF9330C", Offset = "0xF9330C", VA = "0xF9330C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600028E")]
		[Address(RVA = "0xF93318", Offset = "0xF93318", VA = "0xF93318")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public float y
	{
		[Token(Token = "0x600028F")]
		[Address(RVA = "0xF93324", Offset = "0xF93324", VA = "0xF93324")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000290")]
		[Address(RVA = "0xF93330", Offset = "0xF93330", VA = "0xF93330")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public float width
	{
		[Token(Token = "0x6000291")]
		[Address(RVA = "0xF9333C", Offset = "0xF9333C", VA = "0xF9333C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000292")]
		[Address(RVA = "0xF93348", Offset = "0xF93348", VA = "0xF93348")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public float height
	{
		[Token(Token = "0x6000293")]
		[Address(RVA = "0xF93354", Offset = "0xF93354", VA = "0xF93354")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000294")]
		[Address(RVA = "0xF93360", Offset = "0xF93360", VA = "0xF93360")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public Rect rect
	{
		[Token(Token = "0x6000295")]
		[Address(RVA = "0xF90340", Offset = "0xF90340", VA = "0xF90340")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000296")]
		[Address(RVA = "0xF9336C", Offset = "0xF9336C", VA = "0xF9336C")]
		set
		{
		}
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xF92F1C", Offset = "0xF92F1C", VA = "0xF92F1C")]
	public LTRect()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xF8B8C4", Offset = "0xF8B8C4", VA = "0xF8B8C4")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xF9305C", Offset = "0xF9305C", VA = "0xF9305C")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xF93134", Offset = "0xF93134", VA = "0xF93134")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xF93214", Offset = "0xF93214", VA = "0xF93214")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xF9282C", Offset = "0xF9282C", VA = "0xF9282C")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xF92FD4", Offset = "0xF92FD4", VA = "0xF92FD4")]
	public void reset()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xF9097C", Offset = "0xF9097C", VA = "0xF9097C")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xF93378", Offset = "0xF93378", VA = "0xF93378")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xF93380", Offset = "0xF93380", VA = "0xF93380")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xF9338C", Offset = "0xF9338C", VA = "0xF9338C")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xF933A0", Offset = "0xF933A0", VA = "0xF933A0")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xF933A8", Offset = "0xF933A8", VA = "0xF933A8")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xF933B0", Offset = "0xF933B0", VA = "0xF933B0")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xF933C4", Offset = "0xF933C4", VA = "0xF933C4")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xF93430", Offset = "0xF93430", VA = "0xF93430")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xF9343C", Offset = "0xF9343C", VA = "0xF9343C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000014")]
public class LTEvent
{
	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public object data;

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xF90ED8", Offset = "0xF90ED8", VA = "0xF90ED8")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x2000015")]
public class LTGUI
{
	[Token(Token = "0x200004C")]
	public enum Element_Type
	{
		[Token(Token = "0x40002FE")]
		Texture,
		[Token(Token = "0x40002FF")]
		Label
	}

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTRect[] levels;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] levelDepths;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Rect[] buttons;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] buttonLevels;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int[] buttonLastFrame;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static LTRect r;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Color color;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static bool isGUIEnabled;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int global_counter;

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xF90F14", Offset = "0xF90F14", VA = "0xF90F14")]
	public static void init()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xF90FE8", Offset = "0xF90FE8", VA = "0xF90FE8")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xF91168", Offset = "0xF91168", VA = "0xF91168")]
	public static void reset()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xF912F8", Offset = "0xF912F8", VA = "0xF912F8")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xF91E64", Offset = "0xF91E64", VA = "0xF91E64")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xF91F44", Offset = "0xF91F44", VA = "0xF91F44")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xF920C8", Offset = "0xF920C8", VA = "0xF920C8")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xF921CC", Offset = "0xF921CC", VA = "0xF921CC")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xF9228C", Offset = "0xF9228C", VA = "0xF9228C")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xF926D8", Offset = "0xF926D8", VA = "0xF926D8")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xF92798", Offset = "0xF92798", VA = "0xF92798")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xF92318", Offset = "0xF92318", VA = "0xF92318")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xF92834", Offset = "0xF92834", VA = "0xF92834")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xF92B68", Offset = "0xF92B68", VA = "0xF92B68")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xF92DA4", Offset = "0xF92DA4", VA = "0xF92DA4")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xF92C8C", Offset = "0xF92C8C", VA = "0xF92C8C")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xF92E78", Offset = "0xF92E78", VA = "0xF92E78")]
	public LTGUI()
	{
	}
}
[Token(Token = "0x2000016")]
public static class LeanTweenExt
{
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xF356F0", Offset = "0xF356F0", VA = "0xF356F0")]
	public static LTDescr LeanAlpha(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xF3576C", Offset = "0xF3576C", VA = "0xF3576C")]
	public static LTDescr LeanAlphaVertex(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xF357E8", Offset = "0xF357E8", VA = "0xF357E8")]
	public static LTDescr LeanAlpha(this RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xF35864", Offset = "0xF35864", VA = "0xF35864")]
	public static LTDescr LeanAlpha(this CanvasGroup canvas, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xF358E0", Offset = "0xF358E0", VA = "0xF358E0")]
	public static LTDescr LeanAlphaText(this RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xF3595C", Offset = "0xF3595C", VA = "0xF3595C")]
	public static void LeanCancel(this GameObject gameObject)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xF359C0", Offset = "0xF359C0", VA = "0xF359C0")]
	public static void LeanCancel(this GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xF35A34", Offset = "0xF35A34", VA = "0xF35A34")]
	public static void LeanCancel(this GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xF35AB0", Offset = "0xF35AB0", VA = "0xF35AB0")]
	public static void LeanCancel(this RectTransform rectTransform)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xF35B14", Offset = "0xF35B14", VA = "0xF35B14")]
	public static LTDescr LeanColor(this GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xF35BB8", Offset = "0xF35BB8", VA = "0xF35BB8")]
	public static LTDescr LeanColorText(this RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xF35C5C", Offset = "0xF35C5C", VA = "0xF35C5C")]
	public static LTDescr LeanDelayedCall(this GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xF35CE0", Offset = "0xF35CE0", VA = "0xF35CE0")]
	public static LTDescr LeanDelayedCall(this GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xF35D64", Offset = "0xF35D64", VA = "0xF35D64")]
	public static bool LeanIsPaused(this GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xF35DC8", Offset = "0xF35DC8", VA = "0xF35DC8")]
	public static bool LeanIsPaused(this RectTransform rectTransform)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xF35E2C", Offset = "0xF35E2C", VA = "0xF35E2C")]
	public static bool LeanIsTweening(this GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xF35E90", Offset = "0xF35E90", VA = "0xF35E90")]
	public static LTDescr LeanMove(this GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xF35F24", Offset = "0xF35F24", VA = "0xF35F24")]
	public static LTDescr LeanMove(this Transform transform, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xF35FD4", Offset = "0xF35FD4", VA = "0xF35FD4")]
	public static LTDescr LeanMove(this RectTransform rectTransform, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xF36068", Offset = "0xF36068", VA = "0xF36068")]
	public static LTDescr LeanMove(this GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xF360F4", Offset = "0xF360F4", VA = "0xF360F4")]
	public static LTDescr LeanMove(this Transform transform, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xF3619C", Offset = "0xF3619C", VA = "0xF3619C")]
	public static LTDescr LeanMove(this GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xF36220", Offset = "0xF36220", VA = "0xF36220")]
	public static LTDescr LeanMove(this GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xF362A4", Offset = "0xF362A4", VA = "0xF362A4")]
	public static LTDescr LeanMove(this GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xF36328", Offset = "0xF36328", VA = "0xF36328")]
	public static LTDescr LeanMove(this Transform transform, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xF363C8", Offset = "0xF363C8", VA = "0xF363C8")]
	public static LTDescr LeanMove(this Transform transform, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xF36468", Offset = "0xF36468", VA = "0xF36468")]
	public static LTDescr LeanMove(this Transform transform, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xF36508", Offset = "0xF36508", VA = "0xF36508")]
	public static LTDescr LeanMoveLocal(this GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xF3659C", Offset = "0xF3659C", VA = "0xF3659C")]
	public static LTDescr LeanMoveLocal(this GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xF36620", Offset = "0xF36620", VA = "0xF36620")]
	public static LTDescr LeanMoveLocal(this GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xF366A4", Offset = "0xF366A4", VA = "0xF366A4")]
	public static LTDescr LeanMoveLocal(this Transform transform, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xF36754", Offset = "0xF36754", VA = "0xF36754")]
	public static LTDescr LeanMoveLocal(this Transform transform, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xF367F4", Offset = "0xF367F4", VA = "0xF367F4")]
	public static LTDescr LeanMoveLocal(this Transform transform, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xF36894", Offset = "0xF36894", VA = "0xF36894")]
	public static LTDescr LeanMoveLocalX(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xF36910", Offset = "0xF36910", VA = "0xF36910")]
	public static LTDescr LeanMoveLocalY(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xF3698C", Offset = "0xF3698C", VA = "0xF3698C")]
	public static LTDescr LeanMoveLocalZ(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xF36A08", Offset = "0xF36A08", VA = "0xF36A08")]
	public static LTDescr LeanMoveLocalX(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xF36AA0", Offset = "0xF36AA0", VA = "0xF36AA0")]
	public static LTDescr LeanMoveLocalY(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xF36B38", Offset = "0xF36B38", VA = "0xF36B38")]
	public static LTDescr LeanMoveLocalZ(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xF36BD0", Offset = "0xF36BD0", VA = "0xF36BD0")]
	public static LTDescr LeanMoveSpline(this GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xF36C54", Offset = "0xF36C54", VA = "0xF36C54")]
	public static LTDescr LeanMoveSpline(this GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xF36CD8", Offset = "0xF36CD8", VA = "0xF36CD8")]
	public static LTDescr LeanMoveSpline(this Transform transform, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xF36D78", Offset = "0xF36D78", VA = "0xF36D78")]
	public static LTDescr LeanMoveSpline(this Transform transform, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xF36E18", Offset = "0xF36E18", VA = "0xF36E18")]
	public static LTDescr LeanMoveSplineLocal(this GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xF36E9C", Offset = "0xF36E9C", VA = "0xF36E9C")]
	public static LTDescr LeanMoveSplineLocal(this Transform transform, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xF36F3C", Offset = "0xF36F3C", VA = "0xF36F3C")]
	public static LTDescr LeanMoveX(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xF36FB8", Offset = "0xF36FB8", VA = "0xF36FB8")]
	public static LTDescr LeanMoveX(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xF37050", Offset = "0xF37050", VA = "0xF37050")]
	public static LTDescr LeanMoveX(this RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xF370CC", Offset = "0xF370CC", VA = "0xF370CC")]
	public static LTDescr LeanMoveY(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xF37148", Offset = "0xF37148", VA = "0xF37148")]
	public static LTDescr LeanMoveY(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xF371E0", Offset = "0xF371E0", VA = "0xF371E0")]
	public static LTDescr LeanMoveY(this RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xF3725C", Offset = "0xF3725C", VA = "0xF3725C")]
	public static LTDescr LeanMoveZ(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xF372D8", Offset = "0xF372D8", VA = "0xF372D8")]
	public static LTDescr LeanMoveZ(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xF37370", Offset = "0xF37370", VA = "0xF37370")]
	public static LTDescr LeanMoveZ(this RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xF373EC", Offset = "0xF373EC", VA = "0xF373EC")]
	public static void LeanPause(this GameObject gameObject)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xF37450", Offset = "0xF37450", VA = "0xF37450")]
	public static LTDescr LeanPlay(this RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xF374C4", Offset = "0xF374C4", VA = "0xF374C4")]
	public static void LeanResume(this GameObject gameObject)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xF37528", Offset = "0xF37528", VA = "0xF37528")]
	public static LTDescr LeanRotate(this GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xF375BC", Offset = "0xF375BC", VA = "0xF375BC")]
	public static LTDescr LeanRotate(this Transform transform, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xF3766C", Offset = "0xF3766C", VA = "0xF3766C")]
	public static LTDescr LeanRotate(this RectTransform rectTransform, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xF37700", Offset = "0xF37700", VA = "0xF37700")]
	public static LTDescr LeanRotateAround(this GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xF377A4", Offset = "0xF377A4", VA = "0xF377A4")]
	public static LTDescr LeanRotateAround(this Transform transform, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xF37864", Offset = "0xF37864", VA = "0xF37864")]
	public static LTDescr LeanRotateAround(this RectTransform rectTransform, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xF37908", Offset = "0xF37908", VA = "0xF37908")]
	public static LTDescr LeanRotateAroundLocal(this GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xF379AC", Offset = "0xF379AC", VA = "0xF379AC")]
	public static LTDescr LeanRotateAroundLocal(this Transform transform, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xF37A6C", Offset = "0xF37A6C", VA = "0xF37A6C")]
	public static LTDescr LeanRotateAroundLocal(this RectTransform rectTransform, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xF37B10", Offset = "0xF37B10", VA = "0xF37B10")]
	public static LTDescr LeanRotateX(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xF37B8C", Offset = "0xF37B8C", VA = "0xF37B8C")]
	public static LTDescr LeanRotateX(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xF37C24", Offset = "0xF37C24", VA = "0xF37C24")]
	public static LTDescr LeanRotateY(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xF37CA0", Offset = "0xF37CA0", VA = "0xF37CA0")]
	public static LTDescr LeanRotateY(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xF37D38", Offset = "0xF37D38", VA = "0xF37D38")]
	public static LTDescr LeanRotateZ(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xF37DB4", Offset = "0xF37DB4", VA = "0xF37DB4")]
	public static LTDescr LeanRotateZ(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xF37E4C", Offset = "0xF37E4C", VA = "0xF37E4C")]
	public static LTDescr LeanScale(this GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xF37EE0", Offset = "0xF37EE0", VA = "0xF37EE0")]
	public static LTDescr LeanScale(this Transform transform, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xF37F90", Offset = "0xF37F90", VA = "0xF37F90")]
	public static LTDescr LeanScale(this RectTransform rectTransform, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xF38024", Offset = "0xF38024", VA = "0xF38024")]
	public static LTDescr LeanScaleX(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xF380A0", Offset = "0xF380A0", VA = "0xF380A0")]
	public static LTDescr LeanScaleX(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xF38138", Offset = "0xF38138", VA = "0xF38138")]
	public static LTDescr LeanScaleY(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0xF381B4", Offset = "0xF381B4", VA = "0xF381B4")]
	public static LTDescr LeanScaleY(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xF3824C", Offset = "0xF3824C", VA = "0xF3824C")]
	public static LTDescr LeanScaleZ(this GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xF382C8", Offset = "0xF382C8", VA = "0xF382C8")]
	public static LTDescr LeanScaleZ(this Transform transform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xF38360", Offset = "0xF38360", VA = "0xF38360")]
	public static LTDescr LeanSize(this RectTransform rectTransform, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xF383EC", Offset = "0xF383EC", VA = "0xF383EC")]
	public static LTDescr LeanValue(this GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xF38510", Offset = "0xF38510", VA = "0xF38510")]
	public static LTDescr LeanValue(this GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xF3859C", Offset = "0xF3859C", VA = "0xF3859C")]
	public static LTDescr LeanValue(this GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xF38640", Offset = "0xF38640", VA = "0xF38640")]
	public static LTDescr LeanValue(this GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xF386FC", Offset = "0xF386FC", VA = "0xF386FC")]
	public static LTDescr LeanValue(this GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xF38798", Offset = "0xF38798", VA = "0xF38798")]
	public static LTDescr LeanValue(this GameObject gameObject, Action<float, float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xF38834", Offset = "0xF38834", VA = "0xF38834")]
	public static LTDescr LeanValue(this GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xF388D0", Offset = "0xF388D0", VA = "0xF388D0")]
	public static LTDescr LeanValue(this GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xF389FC", Offset = "0xF389FC", VA = "0xF389FC")]
	public static LTDescr LeanValue(this GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0xF38AB0", Offset = "0xF38AB0", VA = "0xF38AB0")]
	public static LTDescr LeanValue(this GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xF33714", Offset = "0xF33714", VA = "0xF33714")]
	public static void LeanSetPosX(this Transform transform, float val)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xF3383C", Offset = "0xF3383C", VA = "0xF3383C")]
	public static void LeanSetPosY(this Transform transform, float val)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xF33964", Offset = "0xF33964", VA = "0xF33964")]
	public static void LeanSetPosZ(this Transform transform, float val)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xF3339C", Offset = "0xF3339C", VA = "0xF3339C")]
	public static void LeanSetLocalPosX(this Transform transform, float val)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xF334C4", Offset = "0xF334C4", VA = "0xF334C4")]
	public static void LeanSetLocalPosY(this Transform transform, float val)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xF335EC", Offset = "0xF335EC", VA = "0xF335EC")]
	public static void LeanSetLocalPosZ(this Transform transform, float val)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xF33C18", Offset = "0xF33C18", VA = "0xF33C18")]
	public static Color LeanColor(this Transform transform)
	{
		return default(Color);
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000017")]
	public enum AAMode
	{
		[Token(Token = "0x400012D")]
		FXAA2,
		[Token(Token = "0x400012E")]
		FXAA3Console,
		[Token(Token = "0x400012F")]
		FXAA1PresetA,
		[Token(Token = "0x4000130")]
		FXAA1PresetB,
		[Token(Token = "0x4000131")]
		NFAA,
		[Token(Token = "0x4000132")]
		SSAA,
		[Token(Token = "0x4000133")]
		DLAA
	}
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BEFCC", Offset = "0x5BEFCC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BEFCC", Offset = "0x5BEFCC")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xF38B7C", Offset = "0xF38B7C", VA = "0xF38B7C")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xF38BE0", Offset = "0xF38BE0", VA = "0xF38BE0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xF38CCC", Offset = "0xF38CCC", VA = "0xF38CCC")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xF39214", Offset = "0xF39214", VA = "0xF39214")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF064", Offset = "0x5BF064")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF064", Offset = "0x5BF064")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200004D")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x4000301")]
			Ghosting,
			[Token(Token = "0x4000302")]
			Anamorphic,
			[Token(Token = "0x4000303")]
			Combined
		}

		[Token(Token = "0x200004E")]
		public enum TweakMode
		{
			[Token(Token = "0x4000305")]
			Basic,
			[Token(Token = "0x4000306")]
			Complex
		}

		[Token(Token = "0x200004F")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000308")]
			Auto,
			[Token(Token = "0x4000309")]
			On,
			[Token(Token = "0x400030A")]
			Off
		}

		[Token(Token = "0x2000050")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x400030C")]
			Screen,
			[Token(Token = "0x400030D")]
			Add
		}

		[Token(Token = "0x2000051")]
		public enum BloomQuality
		{
			[Token(Token = "0x400030F")]
			Cheap,
			[Token(Token = "0x4000310")]
			High
		}

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xF39238", Offset = "0xF39238", VA = "0xF39238", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xF392D8", Offset = "0xF392D8", VA = "0xF392D8")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xF3A694", Offset = "0xF3A694", VA = "0xF3A694")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xF3A494", Offset = "0xF3A494", VA = "0xF3A494")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xF3A19C", Offset = "0xF3A19C", VA = "0xF3A19C")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xF3A0B8", Offset = "0xF3A0B8", VA = "0xF3A0B8")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xF3A288", Offset = "0xF3A288", VA = "0xF3A288")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xF3A75C", Offset = "0xF3A75C", VA = "0xF3A75C")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x4000169")]
		Ghosting,
		[Token(Token = "0x400016A")]
		Anamorphic,
		[Token(Token = "0x400016B")]
		Combined
	}
	[Token(Token = "0x200001B")]
	public enum TweakMode34
	{
		[Token(Token = "0x400016D")]
		Basic,
		[Token(Token = "0x400016E")]
		Complex
	}
	[Token(Token = "0x200001C")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x4000170")]
		Auto,
		[Token(Token = "0x4000171")]
		On,
		[Token(Token = "0x4000172")]
		Off
	}
	[Token(Token = "0x200001D")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x4000174")]
		Screen,
		[Token(Token = "0x4000175")]
		Add
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF0FC", Offset = "0x5BF0FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF0FC", Offset = "0x5BF0FC")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xF3A89C", Offset = "0xF3A89C", VA = "0xF3A89C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xF3A978", Offset = "0xF3A978", VA = "0xF3A978")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xF3B8C4", Offset = "0xF3B8C4", VA = "0xF3B8C4")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xF3B6D4", Offset = "0xF3B6D4", VA = "0xF3B6D4")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xF3B458", Offset = "0xF3B458", VA = "0xF3B458")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xF3B580", Offset = "0xF3B580", VA = "0xF3B580")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xF3B978", Offset = "0xF3B978", VA = "0xF3B978")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF194", Offset = "0x5BF194")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF194", Offset = "0x5BF194")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000052")]
		public enum Resolution
		{
			[Token(Token = "0x4000312")]
			Low,
			[Token(Token = "0x4000313")]
			High
		}

		[Token(Token = "0x2000053")]
		public enum BlurType
		{
			[Token(Token = "0x4000315")]
			Standard,
			[Token(Token = "0x4000316")]
			Sgx
		}

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C03A8", Offset = "0x5C03A8")]
		public float threshold;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C03C0", Offset = "0x5C03C0")]
		public float intensity;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C03D8", Offset = "0x5C03D8")]
		public float blurSize;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C03F0", Offset = "0x5C03F0")]
		public int blurIterations;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x108F46C", Offset = "0x108F46C", VA = "0x108F46C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x108F9F0", Offset = "0x108F9F0", VA = "0x108F9F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x108FAA0", Offset = "0x108FAA0", VA = "0x108FAA0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x108FE6C", Offset = "0x108FE6C", VA = "0x108FE6C")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF22C", Offset = "0x5BF22C")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0408", Offset = "0x5C0408")]
		public int iterations;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0420", Offset = "0x5C0420")]
		public float blurSpread;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x1700002B")]
		protected Material material
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x108FF08", Offset = "0x108FF08", VA = "0x108FF08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1090040", Offset = "0x1090040", VA = "0x1090040")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x109013C", Offset = "0x109013C", VA = "0x109013C")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x10901FC", Offset = "0x10901FC", VA = "0x10901FC")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x10903A0", Offset = "0x10903A0", VA = "0x10903A0")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1090518", Offset = "0x1090518", VA = "0x1090518")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1090684", Offset = "0x1090684", VA = "0x1090684")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF278", Offset = "0x5BF278")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF278", Offset = "0x5BF278")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000054")]
		public enum BlurType
		{
			[Token(Token = "0x4000318")]
			StandardGauss,
			[Token(Token = "0x4000319")]
			SgxGauss
		}

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0438", Offset = "0x5C0438")]
		public int downsample;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0450", Offset = "0x5C0450")]
		public float blurSize;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0468", Offset = "0x5C0468")]
		public int blurIterations;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x10906A0", Offset = "0x10906A0", VA = "0x10906A0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x10906F8", Offset = "0x10906F8", VA = "0x10906F8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x10907A8", Offset = "0x10907A8", VA = "0x10907A8")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1090B4C", Offset = "0x1090B4C", VA = "0x1090B4C")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF310", Offset = "0x5BF310")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF310", Offset = "0x5BF310")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x2000055")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x400031B")]
			CameraMotion,
			[Token(Token = "0x400031C")]
			LocalBlur,
			[Token(Token = "0x400031D")]
			Reconstruction,
			[Token(Token = "0x400031E")]
			ReconstructionDX11,
			[Token(Token = "0x400031F")]
			ReconstructionDisc
		}

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1090B64", Offset = "0x1090B64", VA = "0x1090B64")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1090E00", Offset = "0x1090E00", VA = "0x1090E00")]
		private new void Start()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x109105C", Offset = "0x109105C", VA = "0x109105C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x109111C", Offset = "0x109111C", VA = "0x109111C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1091280", Offset = "0x1091280", VA = "0x1091280", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1091364", Offset = "0x1091364", VA = "0x1091364")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1090F00", Offset = "0x1090F00", VA = "0x1090F00")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1092D0C", Offset = "0x1092D0C", VA = "0x1092D0C")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1092C20", Offset = "0x1092C20", VA = "0x1092C20")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1092CFC", Offset = "0x1092CFC", VA = "0x1092CFC")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1093048", Offset = "0x1093048", VA = "0x1093048")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF3A8", Offset = "0x5BF3A8")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x2000056")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000321")]
			Simple,
			[Token(Token = "0x4000322")]
			Advanced
		}

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1093194", Offset = "0x1093194", VA = "0x1093194")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x10931D0", Offset = "0x10931D0", VA = "0x10931D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x10931D4", Offset = "0x10931D4", VA = "0x10931D4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1093434", Offset = "0x1093434", VA = "0x1093434")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1093828", Offset = "0x1093828", VA = "0x1093828")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x109382C", Offset = "0x109382C", VA = "0x109382C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1093B28", Offset = "0x1093B28", VA = "0x1093B28")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF3F4", Offset = "0x5BF3F4")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1094158", Offset = "0x1094158", VA = "0x1094158", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x10941AC", Offset = "0x10941AC", VA = "0x10941AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1094254", Offset = "0x1094254", VA = "0x1094254")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x10942FC", Offset = "0x10942FC", VA = "0x10942FC")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x10944F8", Offset = "0x10944F8", VA = "0x10944F8")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x10945EC", Offset = "0x10945EC", VA = "0x10945EC")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x10948F8", Offset = "0x10948F8", VA = "0x10948F8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1094AE4", Offset = "0x1094AE4", VA = "0x1094AE4")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF440", Offset = "0x5BF440")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1094B38", Offset = "0x1094B38", VA = "0x1094B38")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1094CB4", Offset = "0x1094CB4", VA = "0x1094CB4")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF48C", Offset = "0x5BF48C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF48C", Offset = "0x5BF48C")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0480", Offset = "0x5C0480")]
		public float intensity;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0498", Offset = "0x5C0498")]
		public float threshold;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C04B4", Offset = "0x5C04B4")]
		public float blurSpread;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1094CC4", Offset = "0x1094CC4", VA = "0x1094CC4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1094D34", Offset = "0x1094D34", VA = "0x1094D34")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x109509C", Offset = "0x109509C", VA = "0x109509C")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF524", Offset = "0x5BF524")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C04CC", Offset = "0x5C04CC")]
		public float adaptationSpeed;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C04E8", Offset = "0x5C04E8")]
		public float limitMinimum;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0500", Offset = "0x5C0500")]
		public float limitMaximum;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x1700002C")]
		protected Material materialLum
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x10950B0", Offset = "0x10950B0", VA = "0x10950B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		protected Material materialReduce
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x1095174", Offset = "0x1095174", VA = "0x1095174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		protected Material materialAdapt
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1095238", Offset = "0x1095238", VA = "0x1095238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		protected Material materialApply
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x10952FC", Offset = "0x10952FC", VA = "0x10952FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x10953C0", Offset = "0x10953C0", VA = "0x10953C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1095454", Offset = "0x1095454", VA = "0x1095454")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x10955A4", Offset = "0x10955A4", VA = "0x10955A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x10957CC", Offset = "0x10957CC", VA = "0x10957CC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1095A28", Offset = "0x1095A28", VA = "0x1095A28")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1095C38", Offset = "0x1095C38", VA = "0x1095C38")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF570", Offset = "0x5BF570")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF570", Offset = "0x5BF570")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1095CB0", Offset = "0x1095CB0", VA = "0x1095CB0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1095D28", Offset = "0x1095D28", VA = "0x1095D28")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x10960D0", Offset = "0x10960D0", VA = "0x10960D0")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF608", Offset = "0x5BF608")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF608", Offset = "0x5BF608")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000057")]
		public enum BlurType
		{
			[Token(Token = "0x4000324")]
			DiscBlur,
			[Token(Token = "0x4000325")]
			DX11
		}

		[Token(Token = "0x2000058")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x4000327")]
			Low,
			[Token(Token = "0x4000328")]
			Medium,
			[Token(Token = "0x4000329")]
			High
		}

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x10960E8", Offset = "0x10960E8", VA = "0x10960E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1096288", Offset = "0x1096288", VA = "0x1096288")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1096300", Offset = "0x1096300", VA = "0x1096300")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1096408", Offset = "0x1096408", VA = "0x1096408")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x109616C", Offset = "0x109616C", VA = "0x109616C")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x109644C", Offset = "0x109644C", VA = "0x109644C")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x10965A8", Offset = "0x10965A8", VA = "0x10965A8")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x10968C8", Offset = "0x10968C8", VA = "0x10968C8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1097F20", Offset = "0x1097F20", VA = "0x1097F20")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF6A0", Offset = "0x5BF6A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF6A0", Offset = "0x5BF6A0")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x2000059")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x400032B")]
			OnlyBackground = 1,
			[Token(Token = "0x400032C")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200005A")]
		public enum DofResolution
		{
			[Token(Token = "0x400032E")]
			High = 2,
			[Token(Token = "0x400032F")]
			Medium,
			[Token(Token = "0x4000330")]
			Low
		}

		[Token(Token = "0x200005B")]
		public enum DofBlurriness
		{
			[Token(Token = "0x4000332")]
			Low = 1,
			[Token(Token = "0x4000333")]
			High = 2,
			[Token(Token = "0x4000334")]
			VeryHigh = 4
		}

		[Token(Token = "0x200005C")]
		public enum BokehDestination
		{
			[Token(Token = "0x4000336")]
			Background = 1,
			[Token(Token = "0x4000337")]
			Foreground,
			[Token(Token = "0x4000338")]
			BackgroundAndForeground
		}

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1097F74", Offset = "0x1097F74", VA = "0x1097F74")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1098048", Offset = "0x1098048", VA = "0x1098048", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x109814C", Offset = "0x109814C", VA = "0x109814C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1098378", Offset = "0x1098378", VA = "0x1098378")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x10983F0", Offset = "0x10983F0", VA = "0x10983F0")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x109854C", Offset = "0x109854C", VA = "0x109854C")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1098570", Offset = "0x1098570", VA = "0x1098570")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1098594", Offset = "0x1098594", VA = "0x1098594")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1099378", Offset = "0x1099378", VA = "0x1099378")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1099A2C", Offset = "0x1099A2C", VA = "0x1099A2C")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1099E94", Offset = "0x1099E94", VA = "0x1099E94")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x109922C", Offset = "0x109922C", VA = "0x109922C")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1099614", Offset = "0x1099614", VA = "0x1099614")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1099CE8", Offset = "0x1099CE8", VA = "0x1099CE8")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1098EF8", Offset = "0x1098EF8", VA = "0x1098EF8")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x109A37C", Offset = "0x109A37C", VA = "0x109A37C")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF738", Offset = "0x5BF738")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF738", Offset = "0x5BF738")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x200005D")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x400033A")]
			TriangleDepthNormals,
			[Token(Token = "0x400033B")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x400033C")]
			SobelDepth,
			[Token(Token = "0x400033D")]
			SobelDepthThin,
			[Token(Token = "0x400033E")]
			TriangleLuminance
		}

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x109A454", Offset = "0x109A454", VA = "0x109A454", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x109A58C", Offset = "0x109A58C", VA = "0x109A58C")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x109A4CC", Offset = "0x109A4CC", VA = "0x109A4CC")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x109A598", Offset = "0x109A598", VA = "0x109A598")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x109A59C", Offset = "0x109A59C", VA = "0x109A59C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x109A788", Offset = "0x109A788", VA = "0x109A788")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF7D0", Offset = "0x5BF7D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF7D0", Offset = "0x5BF7D0")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0518", Offset = "0x5C0518")]
		public float strengthX;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0530", Offset = "0x5C0530")]
		public float strengthY;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x109A7D8", Offset = "0x109A7D8", VA = "0x109A7D8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x109A830", Offset = "0x109A830", VA = "0x109A830")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x109A9A0", Offset = "0x109A9A0", VA = "0x109A9A0")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF868", Offset = "0x5BF868")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF868", Offset = "0x5BF868")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0548", Offset = "0x5C0548")]
		public bool distanceFog;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0580", Offset = "0x5C0580")]
		public bool excludeFarPixels;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C05B8", Offset = "0x5C05B8")]
		public bool useRadialDistance;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C05F0", Offset = "0x5C05F0")]
		public bool heightFog;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C0628", Offset = "0x5C0628")]
		public float height;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0660", Offset = "0x5C0660")]
		public float heightDensity;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5C067C", Offset = "0x5C067C")]
		public float startDistance;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x109A9B4", Offset = "0x109A9B4", VA = "0x109A9B4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x109AA0C", Offset = "0x109AA0C", VA = "0x109AA0C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x109B044", Offset = "0x109B044", VA = "0x109B044")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF900", Offset = "0x5BF900")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C06B4", Offset = "0x5C06B4")]
		public float rampOffset;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x109B064", Offset = "0x109B064", VA = "0x109B064")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x109B140", Offset = "0x109B140", VA = "0x109B140")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BF94C", Offset = "0x5BF94C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF94C", Offset = "0x5BF94C")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000030")]
		protected Material material
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x1094BF0", Offset = "0x1094BF0", VA = "0x1094BF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x109B148", Offset = "0x109B148", VA = "0x109B148", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x109B1F8", Offset = "0x109B1F8", VA = "0x109B1F8", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1094CBC", Offset = "0x1094CBC", VA = "0x1094CBC")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BF9D4", Offset = "0x5BF9D4")]
	public class ImageEffects
	{
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x109B2A8", Offset = "0x109B2A8", VA = "0x109B2A8")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x109B524", Offset = "0x109B524", VA = "0x109B524")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C18F0", Offset = "0x5C18F0")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x109B59C", Offset = "0x109B59C", VA = "0x109B59C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C1928", Offset = "0x5C1928")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x109B61C", Offset = "0x109B61C", VA = "0x109B61C")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BFA0C", Offset = "0x5BFA0C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFA0C", Offset = "0x5BFA0C")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C06CC", Offset = "0x5C06CC")]
		public float blurAmount;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x109B624", Offset = "0x109B624", VA = "0x109B624", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x109B628", Offset = "0x109B628", VA = "0x109B628", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x109B69C", Offset = "0x109B69C", VA = "0x109B69C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x109BA20", Offset = "0x109BA20", VA = "0x109BA20")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFAA4", Offset = "0x5BFAA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BFAA4", Offset = "0x5BFAA4")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x109BA34", Offset = "0x109BA34", VA = "0x109BA34", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x109BAAC", Offset = "0x109BAAC", VA = "0x109BAAC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x109C3CC", Offset = "0x109C3CC", VA = "0x109C3CC")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x109C748", Offset = "0x109C748", VA = "0x109C748")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFB3C", Offset = "0x5BFB3C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BFB3C", Offset = "0x5BFB3C")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C06E8", Offset = "0x5C06E8")]
		public float grainIntensityMin;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0700", Offset = "0x5C0700")]
		public float grainIntensityMax;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0718", Offset = "0x5C0718")]
		public float grainSize;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0738", Offset = "0x5C0738")]
		public float scratchIntensityMin;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0750", Offset = "0x5C0750")]
		public float scratchIntensityMax;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0768", Offset = "0x5C0768")]
		public float scratchFPS;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0780", Offset = "0x5C0780")]
		public float scratchJitter;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000031")]
		protected Material material
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x109C990", Offset = "0x109C990", VA = "0x109C990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x109C850", Offset = "0x109C850", VA = "0x109C850")]
		protected void Start()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x109CAEC", Offset = "0x109CAEC", VA = "0x109CAEC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x109CBF0", Offset = "0x109CBF0", VA = "0x109CBF0")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x109CD2C", Offset = "0x109CD2C", VA = "0x109CD2C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x109D074", Offset = "0x109D074", VA = "0x109D074")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFBD4", Offset = "0x5BFBD4")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x108F5CC", Offset = "0x108F5CC", VA = "0x108F5CC")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x109D0D4", Offset = "0x109D0D4", VA = "0x109D0D4")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x109D2B0", Offset = "0x109D2B0", VA = "0x109D2B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x109D2BC", Offset = "0x109D2BC", VA = "0x109D2BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x109D2C0", Offset = "0x109D2C0", VA = "0x109D2C0")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x109D370", Offset = "0x109D370", VA = "0x109D370")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x109D378", Offset = "0x109D378", VA = "0x109D378", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x10931C4", Offset = "0x10931C4", VA = "0x10931C4")]
		protected void Start()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x108F4C4", Offset = "0x108F4C4", VA = "0x108F4C4")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1091308", Offset = "0x1091308", VA = "0x1091308")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x109D428", Offset = "0x109D428", VA = "0x109D428")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x108F948", Offset = "0x108F948", VA = "0x108F948")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x109D430", Offset = "0x109D430", VA = "0x109D430")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x109D0A8", Offset = "0x109D0A8", VA = "0x109D0A8")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x109D630", Offset = "0x109D630", VA = "0x109D630")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x108FE8C", Offset = "0x108FE8C", VA = "0x108FE8C")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFC48", Offset = "0x5BFC48")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x109D9AC", Offset = "0x109D9AC", VA = "0x109D9AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x109DA18", Offset = "0x109DA18", VA = "0x109DA18")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x109DC94", Offset = "0x109DC94", VA = "0x109DC94")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x109E00C", Offset = "0x109E00C", VA = "0x109E00C")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x109E1B8", Offset = "0x109E1B8", VA = "0x109E1B8")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000036")]
	internal class Quads
	{
		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x109E1C0", Offset = "0x109E1C0", VA = "0x109E1C0")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x10981A8", Offset = "0x10981A8", VA = "0x10981A8")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x109A0BC", Offset = "0x109A0BC", VA = "0x109A0BC")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x109E2E4", Offset = "0x109E2E4", VA = "0x109E2E4")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x109E818", Offset = "0x109E818", VA = "0x109E818")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFCBC", Offset = "0x5BFCBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BFCBC", Offset = "0x5BFCBC")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200005E")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x4000340")]
			Additive,
			[Token(Token = "0x4000341")]
			ScreenBlend,
			[Token(Token = "0x4000342")]
			Multiply,
			[Token(Token = "0x4000343")]
			Overlay,
			[Token(Token = "0x4000344")]
			AlphaBlend
		}

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x109E824", Offset = "0x109E824", VA = "0x109E824", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x109E87C", Offset = "0x109E87C", VA = "0x109E87C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x109E9E4", Offset = "0x109E9E4", VA = "0x109E9E4")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFD54", Offset = "0x5BFD54")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BFD54", Offset = "0x5BFD54")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0798", Offset = "0x5C0798")]
		public float intensity;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C07B0", Offset = "0x5C07B0")]
		public float radius;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C07CC", Offset = "0x5C07CC")]
		public int blurIterations;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C07E4", Offset = "0x5C07E4")]
		public float blurFilterDistance;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C07FC", Offset = "0x5C07FC")]
		public int downsample;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x109E9F4", Offset = "0x109E9F4", VA = "0x109E9F4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x109EA4C", Offset = "0x109EA4C", VA = "0x109EA4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x109EAF4", Offset = "0x109EAF4", VA = "0x109EAF4")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x109F308", Offset = "0x109F308", VA = "0x109F308")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFDEC", Offset = "0x5BFDEC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BFDEC", Offset = "0x5BFDEC")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x200005F")]
		public enum SSAOSamples
		{
			[Token(Token = "0x4000346")]
			Low,
			[Token(Token = "0x4000347")]
			Medium,
			[Token(Token = "0x4000348")]
			High
		}

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0814", Offset = "0x5C0814")]
		public float m_Radius;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0830", Offset = "0x5C0830")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0848", Offset = "0x5C0848")]
		public int m_Blur;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0860", Offset = "0x5C0860")]
		public int m_Downsampling;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0878", Offset = "0x5C0878")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C0894", Offset = "0x5C0894")]
		public float m_MinZ;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x109F324", Offset = "0x109F324", VA = "0x109F324")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x109F3D4", Offset = "0x109F3D4", VA = "0x109F3D4")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x109F470", Offset = "0x109F470", VA = "0x109F470")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x109F478", Offset = "0x109F478", VA = "0x109F478")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x109F60C", Offset = "0x109F60C", VA = "0x109F60C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x109F550", Offset = "0x109F550", VA = "0x109F550")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x109F680", Offset = "0x109F680", VA = "0x109F680")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x109FD3C", Offset = "0x109FD3C", VA = "0x109FD3C")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BFE84", Offset = "0x5BFE84")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x109FD70", Offset = "0x109FD70", VA = "0x109FD70")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x109FE00", Offset = "0x109FE00", VA = "0x109FE00")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFED0", Offset = "0x5BFED0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BFED0", Offset = "0x5BFED0")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000060")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x400034A")]
			Low,
			[Token(Token = "0x400034B")]
			Normal,
			[Token(Token = "0x400034C")]
			High
		}

		[Token(Token = "0x2000061")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x400034E")]
			Screen,
			[Token(Token = "0x400034F")]
			Add
		}

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x109FE08", Offset = "0x109FE08", VA = "0x109FE08", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x109FE70", Offset = "0x109FE70", VA = "0x109FE70")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x10A065C", Offset = "0x10A065C", VA = "0x10A065C")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFF68", Offset = "0x5BFF68")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BFF68", Offset = "0x5BFF68")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000062")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000351")]
			TiltShiftMode,
			[Token(Token = "0x4000352")]
			IrisMode
		}

		[Token(Token = "0x2000063")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000354")]
			Preview,
			[Token(Token = "0x4000355")]
			Low,
			[Token(Token = "0x4000356")]
			Normal,
			[Token(Token = "0x4000357")]
			High
		}

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C08B0", Offset = "0x5C08B0")]
		public float blurArea;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C08C8", Offset = "0x5C08C8")]
		public float maxBlurSize;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C08E0", Offset = "0x5C08E0")]
		public int downsample;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x10A06F0", Offset = "0x10A06F0", VA = "0x10A06F0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x10A0748", Offset = "0x10A0748", VA = "0x10A0748")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x10A09D8", Offset = "0x10A09D8", VA = "0x10A09D8")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5BFFF0", Offset = "0x5BFFF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5BFFF0", Offset = "0x5BFFF0")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000064")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000359")]
			SimpleReinhard,
			[Token(Token = "0x400035A")]
			UserCurve,
			[Token(Token = "0x400035B")]
			Hable,
			[Token(Token = "0x400035C")]
			Photographic,
			[Token(Token = "0x400035D")]
			OptimizedHejiDawson,
			[Token(Token = "0x400035E")]
			AdaptiveReinhard,
			[Token(Token = "0x400035F")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000065")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000361")]
			Square16 = 0x10,
			[Token(Token = "0x4000362")]
			Square32 = 0x20,
			[Token(Token = "0x4000363")]
			Square64 = 0x40,
			[Token(Token = "0x4000364")]
			Square128 = 0x80,
			[Token(Token = "0x4000365")]
			Square256 = 0x100,
			[Token(Token = "0x4000366")]
			Square512 = 0x200,
			[Token(Token = "0x4000367")]
			Square1024 = 0x400
		}

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x10A09F0", Offset = "0x10A09F0", VA = "0x10A09F0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x10A0B2C", Offset = "0x10A0B2C", VA = "0x10A0B2C")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x10A0DD4", Offset = "0x10A0DD4", VA = "0x10A0DD4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x10A0F2C", Offset = "0x10A0F2C", VA = "0x10A0F2C")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x10A101C", Offset = "0x10A101C", VA = "0x10A101C")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x10A1828", Offset = "0x10A1828", VA = "0x10A1828")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200003E")]
	internal class Triangles
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x10A1854", Offset = "0x10A1854", VA = "0x10A1854")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x10A1990", Offset = "0x10A1990", VA = "0x10A1990")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x10A1B60", Offset = "0x10A1B60", VA = "0x10A1B60")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x10A1E20", Offset = "0x10A1E20", VA = "0x10A1E20")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x10A2250", Offset = "0x10A2250", VA = "0x10A2250")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C0088", Offset = "0x5C0088")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5C08F8", Offset = "0x5C08F8")]
		public float angle;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x10A225C", Offset = "0x10A225C", VA = "0x10A225C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x10A22A0", Offset = "0x10A22A0", VA = "0x10A22A0")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5C00D4", Offset = "0x5C00D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C00D4", Offset = "0x5C00D4")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x2000066")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000369")]
			Simple,
			[Token(Token = "0x400036A")]
			Advanced
		}

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x10A231C", Offset = "0x10A231C", VA = "0x10A231C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x10A23A0", Offset = "0x10A23A0", VA = "0x10A23A0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x10A29CC", Offset = "0x10A29CC", VA = "0x10A29CC")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C016C", Offset = "0x5C016C")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x10A29F8", Offset = "0x10A29F8", VA = "0x10A29F8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x10A2A3C", Offset = "0x10A2A3C", VA = "0x10A2A3C")]
		public Vortex()
		{
		}
	}
}
namespace DentedPixel
{
	[Token(Token = "0x2000042")]
	public class LeanDummy
	{
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xF80D80", Offset = "0xF80D80", VA = "0xF80D80")]
		public LeanDummy()
		{
		}
	}
}
