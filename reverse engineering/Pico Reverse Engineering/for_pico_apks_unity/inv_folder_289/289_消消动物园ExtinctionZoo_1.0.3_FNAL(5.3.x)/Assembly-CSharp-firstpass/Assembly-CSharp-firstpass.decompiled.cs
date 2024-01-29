using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using DragonBones;
using ES3Internal;
using ES3Types;
using FlyingWormConsole3.LiteNetLib.Layers;
using FlyingWormConsole3.LiteNetLib.Utils;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736300", Offset = "0x736300")]
internal sealed class <>f__AnonymousType0<<assembly>j__TPar, <type>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x73DEE0", Offset = "0x73DEE0")]
	private readonly <assembly>j__TPar <assembly>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x73DEF4", Offset = "0x73DEF4")]
	private readonly <type>j__TPar <type>i__Field;

	[Token(Token = "0x17000001")]
	public <assembly>j__TPar assembly
	{
		[Token(Token = "0x6000001")]
		get
		{
			return (<assembly>j__TPar)null;
		}
	}

	[Token(Token = "0x17000002")]
	public <type>j__TPar type
	{
		[Token(Token = "0x6000002")]
		get
		{
			return (<type>j__TPar)null;
		}
	}

	[Token(Token = "0x6000003")]
	[DebuggerHidden]
	public <>f__AnonymousType0(<assembly>j__TPar assembly, <type>j__TPar type)
	{
	}

	[Token(Token = "0x6000004")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public static class ConsoleProDebug
{
	[Token(Token = "0x6000007")]
	[Address(RVA = "0xCFEF9C", Offset = "0xCFEF9C", VA = "0xCFEF9C")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xCFEFA0", Offset = "0xCFEFA0", VA = "0xCFEFA0")]
	public static void LogToFilter(string inLog, string inFilterName, [Optional] UnityEngine.Object inContext)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xCFF060", Offset = "0xCFF060", VA = "0xCFF060")]
	public static void LogAsType(string inLog, string inTypeName, [Optional] UnityEngine.Object inContext)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xCFF120", Offset = "0xCFF120", VA = "0xCFF120")]
	public static void Watch(string inName, string inValue)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xCFF370", Offset = "0xCFF370", VA = "0xCFF370")]
	public static void Search(string inText)
	{
	}
}
[Token(Token = "0x2000004")]
public class AnimationBase : BaseDemo
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private UnityArmatureComponent _armatureComp;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xEAA26C", Offset = "0xEAA26C", VA = "0xEAA26C", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xEAA688", Offset = "0xEAA688", VA = "0xEAA688", Slot = "6")]
	protected override void OnTouch(TouchType type)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xEAAB28", Offset = "0xEAAB28", VA = "0xEAAB28")]
	private void OnAnimationEventHandler(string type, EventObject eventObject)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xEAABDC", Offset = "0xEAABDC", VA = "0xEAABDC")]
	public AnimationBase()
	{
	}
}
[Token(Token = "0x2000005")]
public class AnimationLayer : BaseDemo
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private UnityArmatureComponent _mechaArmatureComp;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xEAC80C", Offset = "0xEAC80C", VA = "0xEAC80C", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xEACA2C", Offset = "0xEACA2C", VA = "0xEACA2C")]
	private void OnAnimationEventHandler(string type, EventObject eventObject)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xEACDA0", Offset = "0xEACDA0", VA = "0xEACDA0")]
	public AnimationLayer()
	{
	}
}
[Token(Token = "0x2000006")]
public enum TouchType
{
	[Token(Token = "0x4000006")]
	TOUCH_BEGIN,
	[Token(Token = "0x4000007")]
	TOUCH_MOVE,
	[Token(Token = "0x4000008")]
	TOUCH_END
}
[Token(Token = "0x2000007")]
public class BaseDemo : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736310", Offset = "0x736310")]
	private sealed class <DragDelay>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BaseDemo <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1015D30", Offset = "0x1015D30", VA = "0x1015D30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x1015D78", Offset = "0x1015D78", VA = "0x1015D78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1015C44", Offset = "0x1015C44", VA = "0x1015C44")]
		[DebuggerHidden]
		public <DragDelay>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1015C70", Offset = "0x1015C70", VA = "0x1015C70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1015C74", Offset = "0x1015C74", VA = "0x1015C74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1015D38", Offset = "0x1015D38", VA = "0x1015D38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly List<GameObject> _dragTargets;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected bool _isCreateBackground;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	protected bool _isTouched;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject _currentDragTarget;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 _startDragWorldPosition;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 _startDragScreenPosition;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 _currentDragWorldPosition;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 _dragOffset;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xEB4374", Offset = "0xEB4374", VA = "0xEB4374")]
	private void Start()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xEB44F8", Offset = "0xEB44F8", VA = "0xEB44F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xEB4C9C", Offset = "0xEB4C9C", VA = "0xEB4C9C", Slot = "4")]
	protected virtual void OnStart()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xEB4CA0", Offset = "0xEB4CA0", VA = "0xEB4CA0", Slot = "5")]
	protected virtual void OnUpdate()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xEB4CA4", Offset = "0xEB4CA4", VA = "0xEB4CA4", Slot = "6")]
	protected virtual void OnTouch(TouchType type)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xEB4CA8", Offset = "0xEB4CA8", VA = "0xEB4CA8", Slot = "7")]
	protected virtual void OnDrag(GameObject target, Vector3 startDragPos, Vector3 currentDragPos)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xEB4CAC", Offset = "0xEB4CAC", VA = "0xEB4CAC")]
	protected void EnableDrag(GameObject target)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xEB4DD8", Offset = "0xEB4DD8", VA = "0xEB4DD8")]
	protected void DisableDrag(GameObject target)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xEB43AC", Offset = "0xEB43AC", VA = "0xEB43AC")]
	private void CreateBackground()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xEB4A30", Offset = "0xEB4A30", VA = "0xEB4A30")]
	private GameObject GetClickTarget()
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xEB4F08", Offset = "0xEB4F08", VA = "0xEB4F08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E330", Offset = "0x73E330")]
	private IEnumerator DragDelay()
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xEAABE0", Offset = "0xEAABE0", VA = "0xEAABE0")]
	public BaseDemo()
	{
	}
}
[Token(Token = "0x2000009")]
public class BoneOffset : BaseDemo
{
	[Token(Token = "0x6000025")]
	[Address(RVA = "0xCFBF50", Offset = "0xCFBF50", VA = "0xCFBF50", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xCFC41C", Offset = "0xCFC41C", VA = "0xCFC41C")]
	private void _OnAnimationHandler(string type, EventObject eventObject)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xCFC158", Offset = "0xCFC158", VA = "0xCFC158")]
	private void _MoveTo(UnityArmatureComponent armatureComp)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xCFC4AC", Offset = "0xCFC4AC", VA = "0xCFC4AC")]
	public BoneOffset()
	{
	}
}
[Token(Token = "0x200000A")]
public class BoundingBox : BaseDemo
{
	[Token(Token = "0x4000014")]
	public const float LINE_WIDTH = 4f;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Point _intersectionPointA;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly Point _intersectionPointB;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly Point _normalRadians;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 _helpPointA;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 _helpPointB;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private UnityArmatureComponent _armatureComp;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private UnityArmatureComponent _boundingBoxComp;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private UnityArmatureComponent _targetA;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private UnityArmatureComponent _targetB;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _lineSlot;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private GameObject _pointSlotA;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject _pointSlotB;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xCFCF3C", Offset = "0xCFCF3C", VA = "0xCFCF3C", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xCFD578", Offset = "0xCFD578", VA = "0xCFD578", Slot = "5")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xCFD57C", Offset = "0xCFD57C", VA = "0xCFD57C")]
	private void BoundingBoxCheck()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xCFDBDC", Offset = "0xCFDBDC", VA = "0xCFDBDC")]
	public BoundingBox()
	{
	}
}
[Token(Token = "0x200000B")]
public class CoreElement : BaseDemo
{
	[Token(Token = "0x4000021")]
	public const float G = -0.005f;

	[Token(Token = "0x4000022")]
	public const float GROUND = 0f;

	[Token(Token = "0x4000023")]
	public const KeyCode left = KeyCode.A;

	[Token(Token = "0x4000024")]
	public const KeyCode right = KeyCode.D;

	[Token(Token = "0x4000025")]
	public const KeyCode up = KeyCode.W;

	[Token(Token = "0x4000026")]
	public const KeyCode down = KeyCode.S;

	[Token(Token = "0x4000027")]
	public const KeyCode switchSkin = KeyCode.Space;

	[Token(Token = "0x4000028")]
	public const KeyCode switchLeftWeapon = KeyCode.Q;

	[Token(Token = "0x4000029")]
	public const KeyCode switchRightWeapon = KeyCode.E;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Mecha _player;

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xCFF788", Offset = "0xCFF788", VA = "0xCFF788", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xCFF984", Offset = "0xCFF984", VA = "0xCFF984", Slot = "5")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xCFFB44", Offset = "0xCFFB44", VA = "0xCFFB44")]
	public CoreElement()
	{
	}
}
[Token(Token = "0x200000C")]
public class Mecha
{
	[Token(Token = "0x400002B")]
	private const float JUMP_SPEED = -0.2f;

	[Token(Token = "0x400002C")]
	private const float NORMALIZE_MOVE_SPEED = 0.03f;

	[Token(Token = "0x400002D")]
	private const float MAX_MOVE_SPEED_FRONT = 0.042f;

	[Token(Token = "0x400002E")]
	private const float MAX_MOVE_SPEED_BACK = 0.03f;

	[Token(Token = "0x400002F")]
	private const string NORMAL_ANIMATION_GROUP = "normal";

	[Token(Token = "0x4000030")]
	private const string AIM_ANIMATION_GROUP = "aim";

	[Token(Token = "0x4000031")]
	private const string ATTACK_ANIMATION_GROUP = "attack";

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string[] WEAPON_L_LIST;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string[] WEAPON_R_LIST;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string[] SKINS;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool _isJumpingA;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	private bool _isJumpingB;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	private bool _isSquating;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	private bool _isAttackingA;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private bool _isAttackingB;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int _weaponRIndex;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int _weaponLIndex;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _skinIndex;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int _faceDir;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _aimDir;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int _moveDir;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float _aimRadian;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float _speedX;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float _speedY;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Armature _armature;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UnityArmatureComponent _armatureComponent;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Armature _weaponL;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Armature _weaponR;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AnimationState _aimState;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AnimationState _walkState;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AnimationState _attackState;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2 _target;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x146B2D8", Offset = "0x146B2D8", VA = "0x146B2D8")]
	public Mecha()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x146B908", Offset = "0x146B908", VA = "0x146B908")]
	public void Move(int dir)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x146B920", Offset = "0x146B920", VA = "0x146B920")]
	public void Jump()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x146B9DC", Offset = "0x146B9DC", VA = "0x146B9DC")]
	public void Squat(bool isSquating)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x146BA00", Offset = "0x146BA00", VA = "0x146BA00")]
	public void Attack(bool isAttacking)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x146BA20", Offset = "0x146BA20", VA = "0x146BA20")]
	public void SwitchWeaponL()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x146BD44", Offset = "0x146BD44", VA = "0x146BD44")]
	public void SwitchWeaponR()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x146C068", Offset = "0x146C068", VA = "0x146C068")]
	public void SwitchSkin()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x146C24C", Offset = "0x146C24C", VA = "0x146C24C")]
	public void Aim(float x, float y)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x146C254", Offset = "0x146C254", VA = "0x146C254")]
	public void Update()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x146C280", Offset = "0x146C280", VA = "0x146C280")]
	private void _UpdatePosition()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x146C4BC", Offset = "0x146C4BC", VA = "0x146C4BC")]
	private void _UpdateAim()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x146C730", Offset = "0x146C730", VA = "0x146C730")]
	private void _UpdateAttack()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x146B73C", Offset = "0x146B73C", VA = "0x146B73C")]
	private void _UpdateAnimation()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x146C800", Offset = "0x146C800", VA = "0x146C800")]
	private void _Fire(Vector3 firePoint)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x146CA08", Offset = "0x146CA08", VA = "0x146CA08")]
	private void _OnAnimationEventHandler(string type, EventObject evt)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x146CC3C", Offset = "0x146CC3C", VA = "0x146CC3C")]
	private void _OnFrameEventHandler(string type, EventObject eventObject)
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x736320", Offset = "0x736320")]
public class Bullet : MonoBehaviour
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UnityArmatureComponent _armatureComponent;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private UnityArmatureComponent _effectComponent;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 _speed;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xCFDDCC", Offset = "0xCFDDCC", VA = "0xCFDDCC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xCFDE38", Offset = "0xCFDE38", VA = "0xCFDE38")]
	public void Init(string effectArmatureName, float radian, float speed)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xCFE208", Offset = "0xCFE208", VA = "0xCFE208")]
	private void Update()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xCFE398", Offset = "0xCFE398", VA = "0xCFE398")]
	public Bullet()
	{
	}
}
[Token(Token = "0x200000E")]
public class DragonBonesEvent : BaseDemo
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private UnityArmatureComponent _mechaArmatureComp;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AudioSource _sound;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xD617A4", Offset = "0xD617A4", VA = "0xD617A4", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xD61AB4", Offset = "0xD61AB4", VA = "0xD61AB4", Slot = "5")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xD61B4C", Offset = "0xD61B4C", VA = "0xD61B4C")]
	private void OnSoundEventHandler(string type, EventObject eventObject)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xD61C10", Offset = "0xD61C10", VA = "0xD61C10")]
	private void OnAnimationEventHandler(string type, EventObject eventObject)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xD61CDC", Offset = "0xD61CDC", VA = "0xD61CDC")]
	public DragonBonesEvent()
	{
	}
}
[Token(Token = "0x200000F")]
public class HelloDragonBones : BaseDemo
{
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UnityDragonBonesData dragonBoneData;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1468EE8", Offset = "0x1468EE8", VA = "0x1468EE8", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1469054", Offset = "0x1469054", VA = "0x1469054")]
	public HelloDragonBones()
	{
	}
}
[Token(Token = "0x2000010")]
public class InverseKinematics : BaseDemo
{
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private UnityArmatureComponent _armatureComp;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private UnityArmatureComponent _floorBoardComp;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Bone _chestBone;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Bone _leftFootBone;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Bone _rightFootBone;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Bone _circleBone;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Bone _floorBoardBone;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private AnimationState _aimState;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _offsetRotation;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int _faceDir;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float _aimRadian;

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1469E80", Offset = "0x1469E80", VA = "0x1469E80", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x146A410", Offset = "0x146A410", VA = "0x146A410", Slot = "5")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x146A434", Offset = "0x146A434", VA = "0x146A434")]
	private void _UpdateAim()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x146A5C4", Offset = "0x146A5C4", VA = "0x146A5C4")]
	private void _UpdateFoot()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x146A7C8", Offset = "0x146A7C8", VA = "0x146A7C8")]
	public InverseKinematics()
	{
	}
}
[Token(Token = "0x2000011")]
public class LightShader : BaseDemo
{
	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UnityEngine.Transform target;

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x146A7E8", Offset = "0x146A7E8", VA = "0x146A7E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x146A7F0", Offset = "0x146A7F0", VA = "0x146A7F0", Slot = "5")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x146A888", Offset = "0x146A888", VA = "0x146A888")]
	public LightShader()
	{
	}
}
[Token(Token = "0x2000012")]
public class Performance : MonoBehaviour
{
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736380", Offset = "0x736380")]
	private sealed class <BuildArmatureComponent>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Performance <>4__this;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <lY>5__2;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <lX>5__3;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <index>5__4;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <y>5__5;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <x>5__6;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x1021C78", Offset = "0x1021C78", VA = "0x1021C78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x1021CC0", Offset = "0x1021CC0", VA = "0x1021CC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x102191C", Offset = "0x102191C", VA = "0x102191C")]
		[DebuggerHidden]
		public <BuildArmatureComponent>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1021948", Offset = "0x1021948", VA = "0x1021948", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x102194C", Offset = "0x102194C", VA = "0x102194C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1021C80", Offset = "0x1021C80", VA = "0x1021C80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityDragonBonesData dragonBoneData;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text text;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1479408", Offset = "0x1479408", VA = "0x1479408")]
	private void Start()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x14797B4", Offset = "0x14797B4", VA = "0x14797B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E3E0", Offset = "0x73E3E0")]
	private IEnumerator BuildArmatureComponent()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x147982C", Offset = "0x147982C", VA = "0x147982C")]
	public Performance()
	{
	}
}
[Token(Token = "0x2000014")]
public class ReplaceAnimtion : BaseDemo
{
	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private UnityArmatureComponent _armatureCompA;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private UnityArmatureComponent _armatureCompB;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private UnityArmatureComponent _armatureCompC;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private UnityArmatureComponent _armatureCompD;

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x147B4DC", Offset = "0x147B4DC", VA = "0x147B4DC", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x147BB74", Offset = "0x147BB74", VA = "0x147BB74", Slot = "5")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x147BBB0", Offset = "0x147BBB0", VA = "0x147BBB0")]
	private void ChangeAnimtion()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x147BD94", Offset = "0x147BD94", VA = "0x147BD94")]
	public ReplaceAnimtion()
	{
	}
}
[Token(Token = "0x2000015")]
public class ReplaceSkin : BaseDemo
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private UnityArmatureComponent _bodyArmatureComp;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _replaceSuitIndex;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Dictionary<string, List<string>> _suitConfigs;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<string> _replaceSuitParts;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x147BD9C", Offset = "0x147BD9C", VA = "0x147BD9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x147C328", Offset = "0x147C328", VA = "0x147C328", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x147D378", Offset = "0x147D378", VA = "0x147D378", Slot = "5")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x147D070", Offset = "0x147D070", VA = "0x147D070")]
	private void _LoadData(string dragonBonesJSONPath, string textureAtlasJSONPath)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x147D5E8", Offset = "0x147D5E8", VA = "0x147D5E8")]
	private void _OnFrameEventHandler(string type, EventObject eventObject)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x147D3B4", Offset = "0x147D3B4", VA = "0x147D3B4")]
	private void RandomReplaceSkin()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x147D724", Offset = "0x147D724", VA = "0x147D724")]
	public ReplaceSkin()
	{
	}
}
[Token(Token = "0x2000016")]
public class ReplaceSlotDisplay : BaseDemo
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string[] WEAPON_RIGHT_LIST;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject _logoReplaceTxt;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private UnityArmatureComponent _armatureComp;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Slot _leftWeaponSlot;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Slot _rightWeaponSlot;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject _sourceLogoDisplay;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _leftWeaponIndex;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int _rightWeaponIndex;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x147D7F4", Offset = "0x147D7F4", VA = "0x147D7F4", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x147DAD4", Offset = "0x147DAD4", VA = "0x147DAD4", Slot = "5")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x147DBF0", Offset = "0x147DBF0", VA = "0x147DBF0")]
	private void _ReplaceDisplay(int type)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x147E0D0", Offset = "0x147E0D0", VA = "0x147E0D0")]
	private GameObject _GetTextLogo()
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x147E23C", Offset = "0x147E23C", VA = "0x147E23C")]
	public ReplaceSlotDisplay()
	{
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x736390", Offset = "0x736390")]
public class ES3Serializable : Attribute
{
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1753390", Offset = "0x1753390", VA = "0x1753390")]
	public ES3Serializable()
	{
	}
}
[Token(Token = "0x2000018")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x7363A4", Offset = "0x7363A4")]
public class ES3NonSerializable : Attribute
{
	[Token(Token = "0x6000070")]
	[Address(RVA = "0xD79A48", Offset = "0xD79A48", VA = "0xD79A48")]
	public ES3NonSerializable()
	{
	}
}
[Token(Token = "0x2000019")]
public class ES3AutoSave : MonoBehaviour, ISerializationCallbackReceiver
{
	[Serializable]
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7363B8", Offset = "0x7363B8")]
	private sealed class <>c
	{
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Component> <>9__13_0;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x10195E4", Offset = "0x10195E4", VA = "0x10195E4")]
		public <>c()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x10195EC", Offset = "0x10195EC", VA = "0x10195EC")]
		internal bool <OnAfterDeserialize>b__13_0(Component c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool saveLayer;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool saveTag;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool saveName;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool saveHideFlags;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool saveActive;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool saveChildren;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	private bool isQuitting;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Component> componentsToSave;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xD6C8B0", Offset = "0xD6C8B0", VA = "0xD6C8B0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xD6C8BC", Offset = "0xD6C8BC", VA = "0xD6C8BC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xD6CD70", Offset = "0xD6CD70", VA = "0xD6CD70")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xD6CD7C", Offset = "0xD6CD7C", VA = "0xD6CD7C")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xD6CEF8", Offset = "0xD6CEF8", VA = "0xD6CEF8", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xD6CEFC", Offset = "0xD6CEFC", VA = "0xD6CEFC", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xD6D028", Offset = "0xD6D028", VA = "0xD6D028")]
	public ES3AutoSave()
	{
	}
}
[Token(Token = "0x200001B")]
public class ES3AutoSaveMgr : MonoBehaviour
{
	[Token(Token = "0x200001C")]
	public enum LoadEvent
	{
		[Token(Token = "0x4000088")]
		None,
		[Token(Token = "0x4000089")]
		Awake,
		[Token(Token = "0x400008A")]
		Start
	}

	[Token(Token = "0x200001D")]
	public enum SaveEvent
	{
		[Token(Token = "0x400008C")]
		None,
		[Token(Token = "0x400008D")]
		OnApplicationQuit,
		[Token(Token = "0x400008E")]
		OnApplicationPause
	}

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ES3AutoSaveMgr _current;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string key;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SaveEvent saveEvent;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LoadEvent loadEvent;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ES3SerializableSettings settings;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HashSet<ES3AutoSave> autoSaves;

	[Token(Token = "0x17000007")]
	public static ES3AutoSaveMgr Current
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xD6C9B8", Offset = "0xD6C9B8", VA = "0xD6C9B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	public static ES3AutoSaveMgr Instance
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0xD6D0BC", Offset = "0xD6D0BC", VA = "0xD6D0BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xD6D114", Offset = "0xD6D114", VA = "0xD6D114")]
	public void Save()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xD6D3B4", Offset = "0xD6D3B4", VA = "0xD6D3B4")]
	public void Load()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xD6D4D8", Offset = "0xD6D4D8", VA = "0xD6D4D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xD6D4EC", Offset = "0xD6D4EC", VA = "0xD6D4EC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xD6D684", Offset = "0xD6D684", VA = "0xD6D684")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xD6D698", Offset = "0xD6D698", VA = "0xD6D698")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xD6CC68", Offset = "0xD6CC68", VA = "0xD6CC68")]
	public static void AddAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xD6CDF0", Offset = "0xD6CDF0", VA = "0xD6CDF0")]
	public static void RemoveAutoSave(ES3AutoSave autoSave)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xD6D528", Offset = "0xD6D528", VA = "0xD6D528")]
	public void GetAutoSaves()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xD6D704", Offset = "0xD6D704", VA = "0xD6D704")]
	public ES3AutoSaveMgr()
	{
	}
}
[Token(Token = "0x200001E")]
public class ES3
{
	[Token(Token = "0x200001F")]
	public enum Location
	{
		[Token(Token = "0x4000090")]
		File,
		[Token(Token = "0x4000091")]
		PlayerPrefs,
		[Token(Token = "0x4000092")]
		InternalMS,
		[Token(Token = "0x4000093")]
		Resources,
		[Token(Token = "0x4000094")]
		Cache
	}

	[Token(Token = "0x2000020")]
	public enum Directory
	{
		[Token(Token = "0x4000096")]
		PersistentDataPath,
		[Token(Token = "0x4000097")]
		DataPath
	}

	[Token(Token = "0x2000021")]
	public enum EncryptionType
	{
		[Token(Token = "0x4000099")]
		None,
		[Token(Token = "0x400009A")]
		AES
	}

	[Token(Token = "0x2000022")]
	public enum CompressionType
	{
		[Token(Token = "0x400009C")]
		None,
		[Token(Token = "0x400009D")]
		Gzip
	}

	[Token(Token = "0x2000023")]
	public enum Format
	{
		[Token(Token = "0x400009F")]
		JSON
	}

	[Token(Token = "0x2000024")]
	public enum ReferenceMode
	{
		[Token(Token = "0x40000A1")]
		ByRef,
		[Token(Token = "0x40000A2")]
		ByValue,
		[Token(Token = "0x40000A3")]
		ByRefAndValue
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xD61CE4", Offset = "0xD61CE4", VA = "0xD61CE4")]
	public static void Save(string key, object value)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xD61D74", Offset = "0xD61D74", VA = "0xD61D74")]
	public static void Save(string key, object value, string filePath)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xD61E08", Offset = "0xD61E08", VA = "0xD61E08")]
	public static void Save(string key, object value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xD61EA8", Offset = "0xD61EA8", VA = "0xD61EA8")]
	public static void Save(string key, object value, ES3Settings settings)
	{
	}

	[Token(Token = "0x600008C")]
	public static void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x600008D")]
	public static void Save<T>(string key, T value, string filePath)
	{
	}

	[Token(Token = "0x600008E")]
	public static void Save<T>(string key, T value, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600008F")]
	public static void Save<T>(string key, T value, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xD61F0C", Offset = "0xD61F0C", VA = "0xD61F0C")]
	public static void SaveRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xD62170", Offset = "0xD62170", VA = "0xD62170")]
	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xD621E4", Offset = "0xD621E4", VA = "0xD621E4")]
	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xD61F74", Offset = "0xD61F74", VA = "0xD61F74")]
	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xD62C44", Offset = "0xD62C44", VA = "0xD62C44")]
	public static void SaveRaw(string str)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xD62CF0", Offset = "0xD62CF0", VA = "0xD62CF0")]
	public static void SaveRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xD62D64", Offset = "0xD62D64", VA = "0xD62D64")]
	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xD62CAC", Offset = "0xD62CAC", VA = "0xD62CAC")]
	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xD62DDC", Offset = "0xD62DDC", VA = "0xD62DDC")]
	public static void AppendRaw(byte[] bytes)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xD63048", Offset = "0xD63048", VA = "0xD63048")]
	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xD62E44", Offset = "0xD62E44", VA = "0xD62E44")]
	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xD63140", Offset = "0xD63140", VA = "0xD63140")]
	public static void AppendRaw(string str)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xD633D0", Offset = "0xD633D0", VA = "0xD633D0")]
	public static void AppendRaw(string str, string filePath)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xD63444", Offset = "0xD63444", VA = "0xD63444")]
	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xD631A8", Offset = "0xD631A8", VA = "0xD631A8")]
	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xD634BC", Offset = "0xD634BC", VA = "0xD634BC")]
	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xD63540", Offset = "0xD63540", VA = "0xD63540")]
	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xD63534", Offset = "0xD63534", VA = "0xD63534")]
	public static void SaveImage(Texture2D texture, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xD6375C", Offset = "0xD6375C", VA = "0xD6375C")]
	public static void SaveImage(Texture2D texture, int quality, string imagePath)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xD637D4", Offset = "0xD637D4", VA = "0xD637D4")]
	public static void SaveImage(Texture2D texture, int quality, string imagePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xD635BC", Offset = "0xD635BC", VA = "0xD635BC")]
	public static void SaveImage(Texture2D texture, int quality, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xD638C0", Offset = "0xD638C0", VA = "0xD638C0")]
	public static object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xD63940", Offset = "0xD63940", VA = "0xD63940")]
	public static object Load(string key, string filePath)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xD639CC", Offset = "0xD639CC", VA = "0xD639CC")]
	public static object Load(string key, string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xD63A5C", Offset = "0xD63A5C", VA = "0xD63A5C")]
	public static object Load(string key, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xD63AB8", Offset = "0xD63AB8", VA = "0xD63AB8")]
	public static object Load(string key, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xD63B48", Offset = "0xD63B48", VA = "0xD63B48")]
	public static object Load(string key, string filePath, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xD63BDC", Offset = "0xD63BDC", VA = "0xD63BDC")]
	public static object Load(string key, string filePath, object defaultValue, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xD63C7C", Offset = "0xD63C7C", VA = "0xD63C7C")]
	public static object Load(string key, object defaultValue, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	public static T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x60000AE")]
	public static T Load<T>(string key, string filePath)
	{
		return (T)null;
	}

	[Token(Token = "0x60000AF")]
	public static T Load<T>(string key, string filePath, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x60000B0")]
	public static T Load<T>(string key, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x60000B1")]
	public static T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60000B2")]
	public static T Load<T>(string key, string filePath, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60000B3")]
	public static T Load<T>(string key, string filePath, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x60000B4")]
	public static T Load<T>(string key, T defaultValue, ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x60000B5")]
	public static void LoadInto<T>(string key, object obj) where T : class
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xD63CE0", Offset = "0xD63CE0", VA = "0xD63CE0")]
	public static void LoadInto(string key, string filePath, object obj)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xD63D74", Offset = "0xD63D74", VA = "0xD63D74")]
	public static void LoadInto(string key, string filePath, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xD63E14", Offset = "0xD63E14", VA = "0xD63E14")]
	public static void LoadInto(string key, object obj, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000B9")]
	public static void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x60000BA")]
	public static void LoadInto<T>(string key, string filePath, T obj) where T : class
	{
	}

	[Token(Token = "0x60000BB")]
	public static void LoadInto<T>(string key, string filePath, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x60000BC")]
	public static void LoadInto<T>(string key, T obj, ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xD63E78", Offset = "0xD63E78", VA = "0xD63E78")]
	public static string LoadString(string key, string defaultValue, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xD63EE0", Offset = "0xD63EE0", VA = "0xD63EE0")]
	public static string LoadString(string key, string defaultValue, [Optional] string filePath, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xD63F54", Offset = "0xD63F54", VA = "0xD63F54")]
	public static byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xD64478", Offset = "0xD64478", VA = "0xD64478")]
	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xD644DC", Offset = "0xD644DC", VA = "0xD644DC")]
	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xD63FB4", Offset = "0xD63FB4", VA = "0xD63FB4")]
	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xD645EC", Offset = "0xD645EC", VA = "0xD645EC")]
	public static string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xD64698", Offset = "0xD64698", VA = "0xD64698")]
	public static string LoadRawString(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xD646FC", Offset = "0xD646FC", VA = "0xD646FC")]
	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xD6464C", Offset = "0xD6464C", VA = "0xD6464C")]
	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xD6476C", Offset = "0xD6476C", VA = "0xD6476C")]
	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xD647E8", Offset = "0xD647E8", VA = "0xD647E8")]
	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xD647D4", Offset = "0xD647D4", VA = "0xD647D4")]
	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xD6485C", Offset = "0xD6485C", VA = "0xD6485C")]
	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xD648D0", Offset = "0xD648D0", VA = "0xD648D0")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xD64948", Offset = "0xD64948", VA = "0xD64948")]
	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	public static byte[] Serialize<T>(T value, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xD64D44", Offset = "0xD64D44", VA = "0xD64D44")]
	internal static byte[] Serialize(object value, ES3Type type, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	public static T Deserialize<T>(byte[] bytes, [Optional] ES3Settings settings)
	{
		return (T)null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xD65100", Offset = "0xD65100", VA = "0xD65100")]
	internal static object Deserialize(ES3Type type, byte[] bytes, [Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	public static void DeserializeInto<T>(byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x60000D2")]
	public static void DeserializeInto<T>(ES3Type type, byte[] bytes, T obj, [Optional] ES3Settings settings) where T : class
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xD654F8", Offset = "0xD654F8", VA = "0xD654F8")]
	public static byte[] EncryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xD655F4", Offset = "0xD655F4", VA = "0xD655F4")]
	public static byte[] DecryptBytes(byte[] bytes, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xD656F0", Offset = "0xD656F0", VA = "0xD656F0")]
	public static string EncryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xD657C8", Offset = "0xD657C8", VA = "0xD657C8")]
	public static string DecryptString(string str, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xD658A0", Offset = "0xD658A0", VA = "0xD658A0")]
	public static byte[] CompressBytes(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xD65BA4", Offset = "0xD65BA4", VA = "0xD65BA4")]
	public static byte[] DecompressBytes(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xD65F44", Offset = "0xD65F44", VA = "0xD65F44")]
	public static string CompressString(string str)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xD6600C", Offset = "0xD6600C", VA = "0xD6600C")]
	public static string DecompressString(string str)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xD660D4", Offset = "0xD660D4", VA = "0xD660D4")]
	public static void DeleteFile()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xD662A8", Offset = "0xD662A8", VA = "0xD662A8")]
	public static void DeleteFile(string filePath)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xD6630C", Offset = "0xD6630C", VA = "0xD6630C")]
	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xD66134", Offset = "0xD66134", VA = "0xD66134")]
	public static void DeleteFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xD6648C", Offset = "0xD6648C", VA = "0xD6648C")]
	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xD66958", Offset = "0xD66958", VA = "0xD66958")]
	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xD6651C", Offset = "0xD6651C", VA = "0xD6651C")]
	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xD66DF0", Offset = "0xD66DF0", VA = "0xD66DF0")]
	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xD672D8", Offset = "0xD672D8", VA = "0xD672D8")]
	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xD66E80", Offset = "0xD66E80", VA = "0xD66E80")]
	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xD67380", Offset = "0xD67380", VA = "0xD67380")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xD676DC", Offset = "0xD676DC", VA = "0xD676DC")]
	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xD67410", Offset = "0xD67410", VA = "0xD67410")]
	public static void CopyDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xD67B7C", Offset = "0xD67B7C", VA = "0xD67B7C")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xD67DC4", Offset = "0xD67DC4", VA = "0xD67DC4")]
	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xD67C0C", Offset = "0xD67C0C", VA = "0xD67C0C")]
	public static void RenameDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xD67EF8", Offset = "0xD67EF8", VA = "0xD67EF8")]
	public static void DeleteDirectory(string directoryPath)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xD68098", Offset = "0xD68098", VA = "0xD68098")]
	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xD67F5C", Offset = "0xD67F5C", VA = "0xD67F5C")]
	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xD68108", Offset = "0xD68108", VA = "0xD68108")]
	public static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xD68390", Offset = "0xD68390", VA = "0xD68390")]
	public static void DeleteKey(string key, string filePath)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xD68404", Offset = "0xD68404", VA = "0xD68404")]
	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xD68170", Offset = "0xD68170", VA = "0xD68170")]
	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xD686CC", Offset = "0xD686CC", VA = "0xD686CC")]
	public static bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xD688F4", Offset = "0xD688F4", VA = "0xD688F4")]
	public static bool KeyExists(string key, string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xD68968", Offset = "0xD68968", VA = "0xD68968")]
	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xD68734", Offset = "0xD68734", VA = "0xD68734")]
	public static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xD68B44", Offset = "0xD68B44", VA = "0xD68B44")]
	public static bool FileExists()
	{
		return default(bool);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xD68BA4", Offset = "0xD68BA4", VA = "0xD68BA4")]
	public static bool FileExists(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xD68C08", Offset = "0xD68C08", VA = "0xD68C08")]
	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xD68538", Offset = "0xD68538", VA = "0xD68538")]
	public static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xD68D08", Offset = "0xD68D08", VA = "0xD68D08")]
	public static bool DirectoryExists(string folderPath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xD68D6C", Offset = "0xD68D6C", VA = "0xD68D6C")]
	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xD6777C", Offset = "0xD6777C", VA = "0xD6777C")]
	public static bool DirectoryExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xD68DDC", Offset = "0xD68DDC", VA = "0xD68DDC")]
	public static string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xD6928C", Offset = "0xD6928C", VA = "0xD6928C")]
	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xD692F0", Offset = "0xD692F0", VA = "0xD692F0")]
	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xD68E3C", Offset = "0xD68E3C", VA = "0xD68E3C")]
	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xD694C8", Offset = "0xD694C8", VA = "0xD694C8")]
	public static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xD6956C", Offset = "0xD6956C", VA = "0xD6956C")]
	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xD695D0", Offset = "0xD695D0", VA = "0xD695D0")]
	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xD678C8", Offset = "0xD678C8", VA = "0xD678C8")]
	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xD69808", Offset = "0xD69808", VA = "0xD69808")]
	public static string[] GetDirectories()
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xD69868", Offset = "0xD69868", VA = "0xD69868")]
	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xD698CC", Offset = "0xD698CC", VA = "0xD698CC")]
	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xD67AA4", Offset = "0xD67AA4", VA = "0xD67AA4")]
	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xD69AB0", Offset = "0xD69AB0", VA = "0xD69AB0")]
	public static void CreateBackup()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xD69BB4", Offset = "0xD69BB4", VA = "0xD69BB4")]
	public static void CreateBackup(string filePath)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xD69C18", Offset = "0xD69C18", VA = "0xD69C18")]
	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xD69B10", Offset = "0xD69B10", VA = "0xD69B10")]
	public static void CreateBackup(ES3Settings settings)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xD69C88", Offset = "0xD69C88", VA = "0xD69C88")]
	public static bool RestoreBackup(string filePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xD69DAC", Offset = "0xD69DAC", VA = "0xD69DAC")]
	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xD69CEC", Offset = "0xD69CEC", VA = "0xD69CEC")]
	public static bool RestoreBackup(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xD69E1C", Offset = "0xD69E1C", VA = "0xD69E1C")]
	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xD6A02C", Offset = "0xD6A02C", VA = "0xD6A02C")]
	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xD6A090", Offset = "0xD6A090", VA = "0xD6A090")]
	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xD69E7C", Offset = "0xD69E7C", VA = "0xD69E7C")]
	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xD6A2C8", Offset = "0xD6A2C8", VA = "0xD6A2C8")]
	public static void StoreCachedFile()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xD6A588", Offset = "0xD6A588", VA = "0xD6A588")]
	public static void StoreCachedFile(string filePath)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xD6A64C", Offset = "0xD6A64C", VA = "0xD6A64C")]
	public static void StoreCachedFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xD6A5EC", Offset = "0xD6A5EC", VA = "0xD6A5EC")]
	public static void StoreCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xD6A6BC", Offset = "0xD6A6BC", VA = "0xD6A6BC")]
	public static void CacheFile()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xD6A77C", Offset = "0xD6A77C", VA = "0xD6A77C")]
	public static void CacheFile(string filePath)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xD6A7E0", Offset = "0xD6A7E0", VA = "0xD6A7E0")]
	public static void CacheFile(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xD6A71C", Offset = "0xD6A71C", VA = "0xD6A71C")]
	public static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xD6AA10", Offset = "0xD6AA10", VA = "0xD6AA10")]
	public static void Init()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xD6AAA0", Offset = "0xD6AAA0", VA = "0xD6AAA0")]
	public ES3()
	{
	}
}
[Token(Token = "0x2000025")]
public class ES3File
{
	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73DF18", Offset = "0x73DF18")]
	public static Dictionary<string, ES3File> cachedFiles;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, ES3Data> cache;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool syncWithFile;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private DateTime timestamp;

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xD72F18", Offset = "0xD72F18", VA = "0xD72F18")]
	public ES3File()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xD73444", Offset = "0xD73444", VA = "0xD73444")]
	public ES3File(string filePath)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xD734BC", Offset = "0xD734BC", VA = "0xD734BC")]
	public ES3File(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xD6E1A0", Offset = "0xD6E1A0", VA = "0xD6E1A0")]
	public ES3File(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xD73538", Offset = "0xD73538", VA = "0xD73538")]
	public ES3File(bool syncWithFile)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xD735B0", Offset = "0xD735B0", VA = "0xD735B0")]
	public ES3File(string filePath, bool syncWithFile)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xD7362C", Offset = "0xD7362C", VA = "0xD7362C")]
	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xD72F84", Offset = "0xD72F84", VA = "0xD72F84")]
	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xD736B4", Offset = "0xD736B4", VA = "0xD736B4")]
	public ES3File(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xD737E4", Offset = "0xD737E4", VA = "0xD737E4")]
	public void Sync()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xD73BB8", Offset = "0xD73BB8", VA = "0xD73BB8")]
	public void Sync(string filePath, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xD737EC", Offset = "0xD737EC", VA = "0xD737EC")]
	public void Sync([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xD73C30", Offset = "0xD73C30", VA = "0xD73C30")]
	public void Clear()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xD73C84", Offset = "0xD73C84", VA = "0xD73C84")]
	public string[] GetKeys()
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	public void Save<T>(string key, T value)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xD62384", Offset = "0xD62384", VA = "0xD62384")]
	public void SaveRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xD630C0", Offset = "0xD630C0", VA = "0xD630C0")]
	public void AppendRaw(byte[] bytes, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xD73E24", Offset = "0xD73E24", VA = "0xD73E24")]
	public object Load(string key)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xD73E80", Offset = "0xD73E80", VA = "0xD73E80")]
	public object Load(string key, object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	public T Load<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000132")]
	public T Load<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000133")]
	public void LoadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xD6454C", Offset = "0xD6454C", VA = "0xD6454C")]
	public byte[] LoadRawBytes()
	{
		return null;
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xD73EE4", Offset = "0xD73EE4", VA = "0xD73EE4")]
	public string LoadRawString()
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xD6F264", Offset = "0xD6F264", VA = "0xD6F264")]
	internal byte[] GetBytes([Optional] ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xD73F90", Offset = "0xD73F90", VA = "0xD73F90")]
	public void DeleteKey(string key)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xD73FF4", Offset = "0xD73FF4", VA = "0xD73FF4")]
	public bool KeyExists(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xD74058", Offset = "0xD74058", VA = "0xD74058")]
	public int Size()
	{
		return default(int);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xD74184", Offset = "0xD74184", VA = "0xD74184")]
	public Type GetKeyType(string key)
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xD6225C", Offset = "0xD6225C", VA = "0xD6225C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E490", Offset = "0x73E490")]
	internal static ES3File GetOrCreateCachedFile(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xD6A850", Offset = "0xD6A850", VA = "0xD6A850")]
	internal static void CacheFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xD6A324", Offset = "0xD6A324", VA = "0xD6A324")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E4A4", Offset = "0x73E4A4")]
	internal static void Store([Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xD663FC", Offset = "0xD663FC", VA = "0xD663FC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E4B8", Offset = "0x73E4B8")]
	internal static void RemoveCachedFile(ES3Settings settings)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xD66A08", Offset = "0xD66A08", VA = "0xD66A08")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E4CC", Offset = "0x73E4CC")]
	internal static void CopyCachedFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xD6847C", Offset = "0xD6847C", VA = "0xD6847C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E4E0", Offset = "0x73E4E0")]
	internal static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xD689E0", Offset = "0xD689E0", VA = "0xD689E0")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E4F4", Offset = "0x73E4F4")]
	internal static bool KeyExists(string key, ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xD68C78", Offset = "0xD68C78", VA = "0xD68C78")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E508", Offset = "0x73E508")]
	internal static bool FileExists(ES3Settings settings)
	{
		return default(bool);
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xD69360", Offset = "0xD69360", VA = "0xD69360")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E51C", Offset = "0x73E51C")]
	internal static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xD69640", Offset = "0xD69640", VA = "0xD69640")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E530", Offset = "0x73E530")]
	internal static string[] GetFiles()
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xD6A1D4", Offset = "0xD6A1D4", VA = "0xD6A1D4")]
	internal static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}
}
[Token(Token = "0x2000026")]
public class ES3InspectorInfo : MonoBehaviour
{
	[Token(Token = "0x6000147")]
	[Address(RVA = "0xD752EC", Offset = "0xD752EC", VA = "0xD752EC")]
	public ES3InspectorInfo()
	{
	}
}
[Token(Token = "0x2000027")]
public class ES3ReferenceMgr : ES3ReferenceMgrBase
{
	[Token(Token = "0x6000148")]
	[Address(RVA = "0xD7C250", Offset = "0xD7C250", VA = "0xD7C250")]
	public ES3ReferenceMgr()
	{
	}
}
[Token(Token = "0x2000028")]
public class ES3Spreadsheet
{
	[Token(Token = "0x2000029")]
	protected struct Index
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int col;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int row;

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x101C6E8", Offset = "0x101C6E8", VA = "0x101C6E8")]
		public Index(int col, int row)
		{
		}
	}

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int cols;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int rows;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Index, string> cells;

	[Token(Token = "0x40000AC")]
	private const string QUOTE = "\"";

	[Token(Token = "0x40000AD")]
	private const char QUOTE_CHAR = '"';

	[Token(Token = "0x40000AE")]
	private const char COMMA_CHAR = ',';

	[Token(Token = "0x40000AF")]
	private const char NEWLINE_CHAR = '\n';

	[Token(Token = "0x40000B0")]
	private const string ESCAPED_QUOTE = "\"\"";

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static char[] CHARS_TO_ESCAPE;

	[Token(Token = "0x17000009")]
	public int ColumnCount
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x17547A4", Offset = "0x17547A4", VA = "0x17547A4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000A")]
	public int RowCount
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x17547AC", Offset = "0x17547AC", VA = "0x17547AC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x17547B4", Offset = "0x17547B4", VA = "0x17547B4")]
	public void SetCell(int col, int row, object value)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x17549F0", Offset = "0x17549F0", VA = "0x17549F0")]
	private void SetCellString(int col, int row, string value)
	{
	}

	[Token(Token = "0x600014D")]
	public T GetCell<T>(int col, int row)
	{
		return (T)null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1754AB0", Offset = "0x1754AB0", VA = "0x1754AB0")]
	public object GetCell(Type type, int col, int row)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1754EE8", Offset = "0x1754EE8", VA = "0x1754EE8")]
	public void Load(string filePath)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1754F94", Offset = "0x1754F94", VA = "0x1754F94")]
	public void Load(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1754F64", Offset = "0x1754F64", VA = "0x1754F64")]
	public void Load(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x175571C", Offset = "0x175571C", VA = "0x175571C")]
	public void LoadRaw(string str)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x17557F0", Offset = "0x17557F0", VA = "0x17557F0")]
	public void LoadRaw(string str, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1755468", Offset = "0x1755468", VA = "0x1755468")]
	private void Load(Stream stream, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1755890", Offset = "0x1755890", VA = "0x1755890")]
	public void Save(string filePath)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1755C4C", Offset = "0x1755C4C", VA = "0x1755C4C")]
	public void Save(string filePath, ES3Settings settings)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1755CC4", Offset = "0x1755CC4", VA = "0x1755CC4")]
	public void Save(ES3Settings settings)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1755CCC", Offset = "0x1755CCC", VA = "0x1755CCC")]
	public void Save(string filePath, bool append)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1755D44", Offset = "0x1755D44", VA = "0x1755D44")]
	public void Save(string filePath, ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1755904", Offset = "0x1755904", VA = "0x1755904")]
	public void Save(ES3Settings settings, bool append)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1755F84", Offset = "0x1755F84", VA = "0x1755F84")]
	private static string Escape(string str, bool isAlreadyWrappedInQuotes = false)
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x17560C0", Offset = "0x17560C0", VA = "0x17560C0")]
	private static string Unescape(string str)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1755DC8", Offset = "0x1755DC8", VA = "0x1755DC8")]
	private string[,] ToArray()
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x17561A4", Offset = "0x17561A4", VA = "0x17561A4")]
	public ES3Spreadsheet()
	{
	}
}
[Token(Token = "0x200002A")]
public abstract class ES3Reader : IDisposable
{
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x7363C8", Offset = "0x7363C8")]
	public class ES3ReaderPropertyEnumerator
	{
		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7363DC", Offset = "0x7363DC")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderPropertyEnumerator <>4__this;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001A4")]
				[Address(RVA = "0x1021F08", Offset = "0x1021F08", VA = "0x1021F08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001A6")]
				[Address(RVA = "0x1021F50", Offset = "0x1021F50", VA = "0x1021F50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x101BB90", Offset = "0x101BB90", VA = "0x101BB90")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1021E50", Offset = "0x1021E50", VA = "0x1021E50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x1021E54", Offset = "0x1021E54", VA = "0x1021E54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x1021F10", Offset = "0x1021F10", VA = "0x1021F10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x101BAE4", Offset = "0x101BAE4", VA = "0x101BAE4")]
		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x101BB18", Offset = "0x101BB18", VA = "0x101BB18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E5E4", Offset = "0x73E5E4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x7363EC", Offset = "0x7363EC")]
	public class ES3ReaderRawEnumerator
	{
		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736400", Offset = "0x736400")]
		private sealed class <GetEnumerator>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3ReaderRawEnumerator <>4__this;

			[Token(Token = "0x1700000F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001AC")]
				[Address(RVA = "0x102212C", Offset = "0x102212C", VA = "0x102212C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001AE")]
				[Address(RVA = "0x1022174", Offset = "0x1022174", VA = "0x1022174", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x101BC68", Offset = "0x101BC68", VA = "0x101BC68")]
			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x1021F58", Offset = "0x1021F58", VA = "0x1021F58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x1021F5C", Offset = "0x1021F5C", VA = "0x1021F5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1022134", Offset = "0x1022134", VA = "0x1022134", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Reader reader;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x101BBBC", Offset = "0x101BBBC", VA = "0x101BBBC")]
		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x101BBF0", Offset = "0x101BBF0", VA = "0x101BBF0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E694", Offset = "0x73E694")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected int serializationDepth;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal string overridePropertiesName;

	[Token(Token = "0x1700000B")]
	public virtual ES3ReaderPropertyEnumerator Properties
	{
		[Token(Token = "0x6000184")]
		[Address(RVA = "0xD7BA2C", Offset = "0xD7BA2C", VA = "0xD7BA2C", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000C")]
	internal virtual ES3ReaderRawEnumerator RawEnumerator
	{
		[Token(Token = "0x6000185")]
		[Address(RVA = "0xD7BA8C", Offset = "0xD7BA8C", VA = "0xD7BA8C", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000161")]
	internal abstract int Read_int();

	[Token(Token = "0x6000162")]
	internal abstract float Read_float();

	[Token(Token = "0x6000163")]
	internal abstract bool Read_bool();

	[Token(Token = "0x6000164")]
	internal abstract char Read_char();

	[Token(Token = "0x6000165")]
	internal abstract decimal Read_decimal();

	[Token(Token = "0x6000166")]
	internal abstract double Read_double();

	[Token(Token = "0x6000167")]
	internal abstract long Read_long();

	[Token(Token = "0x6000168")]
	internal abstract ulong Read_ulong();

	[Token(Token = "0x6000169")]
	internal abstract byte Read_byte();

	[Token(Token = "0x600016A")]
	internal abstract sbyte Read_sbyte();

	[Token(Token = "0x600016B")]
	internal abstract short Read_short();

	[Token(Token = "0x600016C")]
	internal abstract ushort Read_ushort();

	[Token(Token = "0x600016D")]
	internal abstract uint Read_uint();

	[Token(Token = "0x600016E")]
	internal abstract string Read_string();

	[Token(Token = "0x600016F")]
	internal abstract byte[] Read_byteArray();

	[Token(Token = "0x6000170")]
	internal abstract long Read_ref();

	[Token(Token = "0x6000171")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E544", Offset = "0x73E544")]
	public abstract string ReadPropertyName();

	[Token(Token = "0x6000172")]
	protected abstract Type ReadKeyPrefix(bool ignore = false);

	[Token(Token = "0x6000173")]
	protected abstract void ReadKeySuffix();

	[Token(Token = "0x6000174")]
	internal abstract byte[] ReadElement(bool skip = false);

	[Token(Token = "0x6000175")]
	public abstract void Dispose();

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xD7B968", Offset = "0xD7B968", VA = "0xD7B968", Slot = "26")]
	internal virtual bool Goto(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xD75C98", Offset = "0xD75C98", VA = "0xD75C98", Slot = "27")]
	internal virtual bool StartReadObject()
	{
		return default(bool);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xD75FB8", Offset = "0xD75FB8", VA = "0xD75FB8", Slot = "28")]
	internal virtual void EndReadObject()
	{
	}

	[Token(Token = "0x6000179")]
	internal abstract bool StartReadDictionary();

	[Token(Token = "0x600017A")]
	internal abstract void EndReadDictionary();

	[Token(Token = "0x600017B")]
	internal abstract bool StartReadDictionaryKey();

	[Token(Token = "0x600017C")]
	internal abstract void EndReadDictionaryKey();

	[Token(Token = "0x600017D")]
	internal abstract void StartReadDictionaryValue();

	[Token(Token = "0x600017E")]
	internal abstract bool EndReadDictionaryValue();

	[Token(Token = "0x600017F")]
	internal abstract bool StartReadCollection();

	[Token(Token = "0x6000180")]
	internal abstract void EndReadCollection();

	[Token(Token = "0x6000181")]
	internal abstract bool StartReadCollectionItem();

	[Token(Token = "0x6000182")]
	internal abstract bool EndReadCollectionItem();

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xD75470", Offset = "0xD75470", VA = "0xD75470")]
	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xD7BAEC", Offset = "0xD7BAEC", VA = "0xD7BAEC", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E558", Offset = "0x73E558")]
	public virtual void Skip()
	{
	}

	[Token(Token = "0x6000187")]
	public virtual T Read<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000188")]
	public virtual void ReadInto<T>(object obj)
	{
	}

	[Token(Token = "0x6000189")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E56C", Offset = "0x73E56C")]
	public T ReadProperty<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x600018A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E580", Offset = "0x73E580")]
	public T ReadProperty<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xD7BB00", Offset = "0xD7BB00", VA = "0xD7BB00")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E594", Offset = "0x73E594")]
	public long ReadRefProperty()
	{
		return default(long);
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xD7BB3C", Offset = "0xD7BB3C", VA = "0xD7BB3C")]
	internal Type ReadType()
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xD7BC20", Offset = "0xD7BC20", VA = "0xD7BC20")]
	public object SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xD7BDC4", Offset = "0xD7BDC4", VA = "0xD7BDC4")]
	public object SetPrivateField(string name, object value, object objectContainingField)
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	public virtual T Read<T>(string key)
	{
		return (T)null;
	}

	[Token(Token = "0x6000190")]
	public virtual T Read<T>(string key, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6000191")]
	public virtual void ReadInto<T>(string key, T obj) where T : class
	{
	}

	[Token(Token = "0x6000192")]
	protected virtual void ReadObject<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x6000193")]
	protected virtual T ReadObject<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000194")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E5A8", Offset = "0x73E5A8")]
	public virtual T Read<T>(ES3Type type)
	{
		return (T)null;
	}

	[Token(Token = "0x6000195")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E5BC", Offset = "0x73E5BC")]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[Token(Token = "0x6000196")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E5D0", Offset = "0x73E5D0")]
	internal Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xD7BF68", Offset = "0xD7BF68", VA = "0xD7BF68")]
	public static ES3Reader Create()
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xD7BFC8", Offset = "0xD7BFC8", VA = "0xD7BFC8")]
	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xD7C02C", Offset = "0xD7C02C", VA = "0xD7C02C")]
	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xD68AA8", Offset = "0xD68AA8", VA = "0xD68AA8")]
	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xD7C09C", Offset = "0xD7C09C", VA = "0xD7C09C")]
	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xD73D54", Offset = "0xD73D54", VA = "0xD73D54")]
	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xD7C104", Offset = "0xD7C104", VA = "0xD7C104")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xD6546C", Offset = "0xD6546C", VA = "0xD6546C")]
	internal static ES3Reader Create(Stream stream, ES3Settings settings, bool readHeaderAndFooter)
	{
		return null;
	}
}
[Token(Token = "0x200002F")]
public class ES3XMLReader
{
	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1467558", Offset = "0x1467558", VA = "0x1467558")]
	public ES3XMLReader()
	{
	}
}
[Token(Token = "0x2000030")]
public class ES3Defaults : ScriptableObject
{
	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ES3SerializableSettings settings;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool addMgrToSceneAutomatically;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool autoUpdateReferences;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool addAllPrefabsToManager;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool logDebugInfo;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool logWarnings;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool logErrors;

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xD722F0", Offset = "0xD722F0", VA = "0xD722F0")]
	public ES3Defaults()
	{
	}
}
[Token(Token = "0x2000031")]
public class ES3Settings : ICloneable
{
	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ES3Settings _defaults;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ES3Defaults _defaultSettingsScriptableObject;

	[Token(Token = "0x40000C8")]
	private const string defaultSettingsPath = "ES3/ES3Defaults";

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static ES3Settings _unencryptedUncompressedSettings;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string[] resourcesExtensions;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private ES3.Location _location;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ES3.EncryptionType encryptionType;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ES3.CompressionType compressionType;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string encryptionPassword;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ES3.Directory directory;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ES3.Format format;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool prettyPrint;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bufferSize;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Encoding encoding;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool saveChildren;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73DF4C", Offset = "0x73DF4C")]
	public bool typeChecking;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73DF60", Offset = "0x73DF60")]
	public bool safeReflection;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73DF74", Offset = "0x73DF74")]
	public ES3.ReferenceMode memberReferenceMode;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73DF88", Offset = "0x73DF88")]
	public ES3.ReferenceMode referenceMode;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73DF9C", Offset = "0x73DF9C")]
	public int serializationDepthLimit;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73DFB0", Offset = "0x73DFB0")]
	public string[] assemblyNames;

	[Token(Token = "0x17000011")]
	public static ES3Defaults defaultSettingsScriptableObject
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x175379C", Offset = "0x175379C", VA = "0x175379C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000012")]
	public static ES3Settings defaultSettings
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x17538D0", Offset = "0x17538D0", VA = "0x17538D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000013")]
	internal static ES3Settings unencryptedUncompressedSettings
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x17539F4", Offset = "0x17539F4", VA = "0x17539F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public ES3.Location location
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1753D8C", Offset = "0x1753D8C", VA = "0x1753D8C")]
		get
		{
			return default(ES3.Location);
		}
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1753DDC", Offset = "0x1753DDC", VA = "0x1753DDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public string FullPath
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1753DE4", Offset = "0x1753DE4", VA = "0x1753DE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x174EE4C", Offset = "0x174EE4C", VA = "0x174EE4C")]
	public ES3Settings([Optional] string path, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x17542E0", Offset = "0x17542E0", VA = "0x17542E0")]
	public ES3Settings(string path, params Enum[] enums)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1753BC0", Offset = "0x1753BC0", VA = "0x1753BC0")]
	public ES3Settings(params Enum[] enums)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x1754324", Offset = "0x1754324", VA = "0x1754324")]
	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x1754368", Offset = "0x1754368", VA = "0x1754368")]
	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, [Optional] ES3Settings settings)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x17533FC", Offset = "0x17533FC", VA = "0x17533FC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E744", Offset = "0x73E744")]
	public ES3Settings(bool applyDefaults)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1754174", Offset = "0x1754174", VA = "0x1754174")]
	private static bool IsAbsolute(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x17543AC", Offset = "0x17543AC", VA = "0x17543AC", Slot = "4")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E758", Offset = "0x73E758")]
	public object Clone()
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1754218", Offset = "0x1754218", VA = "0x1754218")]
	private void CopyInto(ES3Settings newSettings)
	{
	}
}
[Serializable]
[Token(Token = "0x2000032")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x736410", Offset = "0x736410")]
public class ES3SerializableSettings : ES3Settings
{
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1753398", Offset = "0x1753398", VA = "0x1753398")]
	public ES3SerializableSettings()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x1753634", Offset = "0x1753634", VA = "0x1753634")]
	public ES3SerializableSettings(bool applyDefaults)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x17536A4", Offset = "0x17536A4", VA = "0x17536A4")]
	public ES3SerializableSettings(string path)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1753724", Offset = "0x1753724", VA = "0x1753724")]
	public ES3SerializableSettings(string path, ES3.Location location)
	{
	}
}
[Token(Token = "0x2000033")]
public class ES3Ref
{
	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public long id;

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xD7C1A4", Offset = "0xD7C1A4", VA = "0xD7C1A4")]
	public ES3Ref(long id)
	{
	}
}
[Token(Token = "0x2000034")]
public class ES3Cloud : ES3WebClass
{
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736424", Offset = "0x736424")]
	private sealed class <Sync>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x101B548", Offset = "0x101B548", VA = "0x101B548", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x101B590", Offset = "0x101B590", VA = "0x101B590", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x101B3D4", Offset = "0x101B3D4", VA = "0x101B3D4")]
		[DebuggerHidden]
		public <Sync>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x101B400", Offset = "0x101B400", VA = "0x101B400", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x101B404", Offset = "0x101B404", VA = "0x101B404", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x101B550", Offset = "0x101B550", VA = "0x101B550", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736434", Offset = "0x736434")]
	private sealed class <UploadFile>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public long fileTimestamp;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public byte[] bytes;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x101B978", Offset = "0x101B978", VA = "0x101B978", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x101B9C0", Offset = "0x101B9C0", VA = "0x101B9C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x101B598", Offset = "0x101B598", VA = "0x101B598")]
		[DebuggerHidden]
		public <UploadFile>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x101B5C4", Offset = "0x101B5C4", VA = "0x101B5C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x101B69C", Offset = "0x101B69C", VA = "0x101B69C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x101B5E0", Offset = "0x101B5E0", VA = "0x101B5E0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x101B980", Offset = "0x101B980", VA = "0x101B980", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736444", Offset = "0x736444")]
	private sealed class <DownloadFile>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3File es3File;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x1019F18", Offset = "0x1019F18", VA = "0x1019F18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x1019F60", Offset = "0x1019F60", VA = "0x1019F60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1019A80", Offset = "0x1019A80", VA = "0x1019A80")]
		[DebuggerHidden]
		public <DownloadFile>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1019AAC", Offset = "0x1019AAC", VA = "0x1019AAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1019B84", Offset = "0x1019B84", VA = "0x1019B84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1019AC8", Offset = "0x1019AC8", VA = "0x1019AC8")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1019F20", Offset = "0x1019F20", VA = "0x1019F20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736454", Offset = "0x736454")]
	private sealed class <DownloadFile>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long timestamp;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x101A3B8", Offset = "0x101A3B8", VA = "0x101A3B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x101A400", Offset = "0x101A400", VA = "0x101A400", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1019F68", Offset = "0x1019F68", VA = "0x1019F68")]
		[DebuggerHidden]
		public <DownloadFile>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1019F94", Offset = "0x1019F94", VA = "0x1019F94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x101A06C", Offset = "0x101A06C", VA = "0x101A06C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1019FB0", Offset = "0x1019FB0", VA = "0x1019FB0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x101A3C0", Offset = "0x101A3C0", VA = "0x101A3C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736464", Offset = "0x736464")]
	private sealed class <DeleteFile>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x1019A30", Offset = "0x1019A30", VA = "0x1019A30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x1019A78", Offset = "0x1019A78", VA = "0x1019A78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x10196E4", Offset = "0x10196E4", VA = "0x10196E4")]
		[DebuggerHidden]
		public <DeleteFile>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1019710", Offset = "0x1019710", VA = "0x1019710", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x10197E8", Offset = "0x10197E8", VA = "0x10197E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x101972C", Offset = "0x101972C", VA = "0x101972C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1019A38", Offset = "0x1019A38", VA = "0x1019A38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736474", Offset = "0x736474")]
	private sealed class <RenameFile>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Settings newSettings;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string user;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string password;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x101AF5C", Offset = "0x101AF5C", VA = "0x101AF5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x101AFA4", Offset = "0x101AFA4", VA = "0x101AFA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x101ABD4", Offset = "0x101ABD4", VA = "0x101ABD4")]
		[DebuggerHidden]
		public <RenameFile>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x101AC00", Offset = "0x101AC00", VA = "0x101AC00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x101ACD8", Offset = "0x101ACD8", VA = "0x101ACD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x101AC1C", Offset = "0x101AC1C", VA = "0x101AC1C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x101AF64", Offset = "0x101AF64", VA = "0x101AF64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736484", Offset = "0x736484")]
	private sealed class <DownloadFilenames>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x101A7A0", Offset = "0x101A7A0", VA = "0x101A7A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x101A7E8", Offset = "0x101A7E8", VA = "0x101A7E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x101A408", Offset = "0x101A408", VA = "0x101A408")]
		[DebuggerHidden]
		public <DownloadFilenames>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x101A434", Offset = "0x101A434", VA = "0x101A434", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x101A50C", Offset = "0x101A50C", VA = "0x101A50C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x101A450", Offset = "0x101A450", VA = "0x101A450")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x101A7A8", Offset = "0x101A7A8", VA = "0x101A7A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736494", Offset = "0x736494")]
	private sealed class <SearchFilenames>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string user;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string password;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string searchPattern;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x101B384", Offset = "0x101B384", VA = "0x101B384", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x101B3CC", Offset = "0x101B3CC", VA = "0x101B3CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x101AFAC", Offset = "0x101AFAC", VA = "0x101AFAC")]
		[DebuggerHidden]
		public <SearchFilenames>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x101AFD8", Offset = "0x101AFD8", VA = "0x101AFD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x101B0B0", Offset = "0x101B0B0", VA = "0x101B0B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x101AFF4", Offset = "0x101AFF4", VA = "0x101AFF4")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x101B38C", Offset = "0x101B38C", VA = "0x101B38C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7364A4", Offset = "0x7364A4")]
	private sealed class <DownloadTimestamp>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3Cloud <>4__this;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Settings settings;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string user;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string password;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <webRequest>5__2;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x101AB84", Offset = "0x101AB84", VA = "0x101AB84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x101ABCC", Offset = "0x101ABCC", VA = "0x101ABCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x101A7F0", Offset = "0x101A7F0", VA = "0x101A7F0")]
		[DebuggerHidden]
		public <DownloadTimestamp>d__70(int <>1__state)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x101A81C", Offset = "0x101A81C", VA = "0x101A81C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x101A8F4", Offset = "0x101A8F4", VA = "0x101A8F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x101A838", Offset = "0x101A838", VA = "0x101A838")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x101AB8C", Offset = "0x101AB8C", VA = "0x101AB8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int timeout;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Encoding encoding;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private byte[] _data;

	[Token(Token = "0x17000016")]
	public byte[] data
	{
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xD6E5A0", Offset = "0xD6E5A0", VA = "0xD6E5A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000017")]
	public string text
	{
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xD6E5A8", Offset = "0xD6E5A8", VA = "0xD6E5A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	public string[] filenames
	{
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xD6E5DC", Offset = "0xD6E5DC", VA = "0xD6E5DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000019")]
	public DateTime timestamp
	{
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xD6E6AC", Offset = "0xD6E6AC", VA = "0xD6E6AC")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xD6E4DC", Offset = "0xD6E4DC", VA = "0xD6E4DC")]
	public ES3Cloud(string url, string apiKey)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xD6E538", Offset = "0xD6E538", VA = "0xD6E538")]
	public ES3Cloud(string url, string apiKey, int timeout)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xD6E830", Offset = "0xD6E830", VA = "0xD6E830")]
	public IEnumerator Sync()
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xD6E978", Offset = "0xD6E978", VA = "0xD6E978")]
	public IEnumerator Sync(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xD6EA08", Offset = "0xD6EA08", VA = "0xD6EA08")]
	public IEnumerator Sync(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xD6EA9C", Offset = "0xD6EA9C", VA = "0xD6EA9C")]
	public IEnumerator Sync(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xD6EB28", Offset = "0xD6EB28", VA = "0xD6EB28")]
	public IEnumerator Sync(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xD6EBBC", Offset = "0xD6EBBC", VA = "0xD6EBBC")]
	public IEnumerator Sync(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xD6EC5C", Offset = "0xD6EC5C", VA = "0xD6EC5C")]
	public IEnumerator Sync(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xD6E8B4", Offset = "0xD6E8B4", VA = "0xD6E8B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E76C", Offset = "0x73E76C")]
	private IEnumerator Sync(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xD6ECEC", Offset = "0xD6ECEC", VA = "0xD6ECEC")]
	public IEnumerator UploadFile()
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xD6EDD4", Offset = "0xD6EDD4", VA = "0xD6EDD4")]
	public IEnumerator UploadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xD6EE74", Offset = "0xD6EE74", VA = "0xD6EE74")]
	public IEnumerator UploadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xD6EF18", Offset = "0xD6EF18", VA = "0xD6EF18")]
	public IEnumerator UploadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xD6EFB0", Offset = "0xD6EFB0", VA = "0xD6EFB0")]
	public IEnumerator UploadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xD6F054", Offset = "0xD6F054", VA = "0xD6F054")]
	public IEnumerator UploadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xD6F104", Offset = "0xD6F104", VA = "0xD6F104")]
	public IEnumerator UploadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xD6F1A0", Offset = "0xD6F1A0", VA = "0xD6F1A0")]
	public IEnumerator UploadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xD6F95C", Offset = "0xD6F95C", VA = "0xD6F95C")]
	public IEnumerator UploadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xD6FA24", Offset = "0xD6FA24", VA = "0xD6FA24")]
	public IEnumerator UploadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xD6ED88", Offset = "0xD6ED88", VA = "0xD6ED88")]
	public IEnumerator UploadFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xD6FAE4", Offset = "0xD6FAE4", VA = "0xD6FAE4")]
	public IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xD6F874", Offset = "0xD6F874", VA = "0xD6F874")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E7CC", Offset = "0x73E7CC")]
	private IEnumerator UploadFile(byte[] bytes, ES3Settings settings, string user, string password, long fileTimestamp)
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xD6FB48", Offset = "0xD6FB48", VA = "0xD6FB48")]
	public IEnumerator DownloadFile()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xD6FC9C", Offset = "0xD6FC9C", VA = "0xD6FC9C")]
	public IEnumerator DownloadFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xD6FD30", Offset = "0xD6FD30", VA = "0xD6FD30")]
	public IEnumerator DownloadFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xD6FDC8", Offset = "0xD6FDC8", VA = "0xD6FDC8")]
	public IEnumerator DownloadFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xD6FE58", Offset = "0xD6FE58", VA = "0xD6FE58")]
	public IEnumerator DownloadFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xD6FEF0", Offset = "0xD6FEF0", VA = "0xD6FEF0")]
	public IEnumerator DownloadFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xD6FF94", Offset = "0xD6FF94", VA = "0xD6FF94")]
	public IEnumerator DownloadFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xD70028", Offset = "0xD70028", VA = "0xD70028")]
	public IEnumerator DownloadFile(ES3File es3File)
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xD70158", Offset = "0xD70158", VA = "0xD70158")]
	public IEnumerator DownloadFile(ES3File es3File, string user)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xD701C0", Offset = "0xD701C0", VA = "0xD701C0")]
	public IEnumerator DownloadFile(ES3File es3File, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xD7008C", Offset = "0xD7008C", VA = "0xD7008C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E82C", Offset = "0x73E82C")]
	private IEnumerator DownloadFile(ES3File es3File, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xD6FBD0", Offset = "0xD6FBD0", VA = "0xD6FBD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E88C", Offset = "0x73E88C")]
	private IEnumerator DownloadFile(ES3Settings settings, string user, string password, long timestamp)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xD701C8", Offset = "0xD701C8", VA = "0xD701C8")]
	public IEnumerator DeleteFile()
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xD70310", Offset = "0xD70310", VA = "0xD70310")]
	public IEnumerator DeleteFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xD703A0", Offset = "0xD703A0", VA = "0xD703A0")]
	public IEnumerator DeleteFile(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xD70434", Offset = "0xD70434", VA = "0xD70434")]
	public IEnumerator DeleteFile(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xD704C0", Offset = "0xD704C0", VA = "0xD704C0")]
	public IEnumerator DeleteFile(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xD70554", Offset = "0xD70554", VA = "0xD70554")]
	public IEnumerator DeleteFile(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xD705F4", Offset = "0xD705F4", VA = "0xD705F4")]
	public IEnumerator DeleteFile(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xD7024C", Offset = "0xD7024C", VA = "0xD7024C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E8EC", Offset = "0x73E8EC")]
	private IEnumerator DeleteFile(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xD70684", Offset = "0xD70684", VA = "0xD70684")]
	public IEnumerator RenameFile(string filePath, string newFilePath)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xD70818", Offset = "0xD70818", VA = "0xD70818")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user)
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xD708D8", Offset = "0xD708D8", VA = "0xD708D8")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xD70990", Offset = "0xD70990", VA = "0xD70990")]
	public IEnumerator RenameFile(string filePath, string newFilePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xD70A50", Offset = "0xD70A50", VA = "0xD70A50")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xD70B1C", Offset = "0xD70B1C", VA = "0xD70B1C")]
	public IEnumerator RenameFile(string filePath, string newFilePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xD70740", Offset = "0xD70740", VA = "0xD70740")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E94C", Offset = "0x73E94C")]
	private IEnumerator RenameFile(ES3Settings settings, ES3Settings newSettings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xD70BD8", Offset = "0xD70BD8", VA = "0xD70BD8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73E9AC", Offset = "0x73E9AC")]
	public IEnumerator DownloadFilenames(string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xD70C80", Offset = "0xD70C80", VA = "0xD70C80")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EA0C", Offset = "0x73EA0C")]
	public IEnumerator SearchFilenames(string searchPattern, string user = "", string password = "")
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xD70D44", Offset = "0xD70D44", VA = "0xD70D44")]
	public IEnumerator DownloadTimestamp()
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xD70E8C", Offset = "0xD70E8C", VA = "0xD70E8C")]
	public IEnumerator DownloadTimestamp(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xD70F1C", Offset = "0xD70F1C", VA = "0xD70F1C")]
	public IEnumerator DownloadTimestamp(string filePath, string user)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xD70FB0", Offset = "0xD70FB0", VA = "0xD70FB0")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xD7103C", Offset = "0xD7103C", VA = "0xD7103C")]
	public IEnumerator DownloadTimestamp(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xD710D0", Offset = "0xD710D0", VA = "0xD710D0")]
	public IEnumerator DownloadTimestamp(string filePath, string user, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xD71170", Offset = "0xD71170", VA = "0xD71170")]
	public IEnumerator DownloadTimestamp(string filePath, string user, string password, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xD70DC8", Offset = "0xD70DC8", VA = "0xD70DC8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EA6C", Offset = "0x73EA6C")]
	private IEnumerator DownloadTimestamp(ES3Settings settings, string user, string password)
	{
		return null;
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xD6F764", Offset = "0xD6F764", VA = "0xD6F764")]
	private long DateTimeToUnixTimestamp(DateTime dt)
	{
		return default(long);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xD71200", Offset = "0xD71200", VA = "0xD71200")]
	private long GetFileTimestamp(ES3Settings settings)
	{
		return default(long);
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xD7121C", Offset = "0xD7121C", VA = "0xD7121C", Slot = "4")]
	protected override void Reset()
	{
	}
}
[Token(Token = "0x200003E")]
public abstract class ES3Writer : IDisposable
{
	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ES3Settings settings;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected HashSet<string> keysToDelete;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal bool writeHeaderAndFooter;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	internal bool overwriteKeys;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected int serializationDepth;

	[Token(Token = "0x6000247")]
	internal abstract void WriteNull();

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x1B13E48", Offset = "0x1B13E48", VA = "0x1B13E48", Slot = "6")]
	internal virtual void StartWriteFile()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x1B13E58", Offset = "0x1B13E58", VA = "0x1B13E58", Slot = "7")]
	internal virtual void EndWriteFile()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x1B13E68", Offset = "0x1B13E68", VA = "0x1B13E68", Slot = "8")]
	internal virtual void StartWriteObject(string name)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1B13E78", Offset = "0x1B13E78", VA = "0x1B13E78", Slot = "9")]
	internal virtual void EndWriteObject(string name)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1B13E88", Offset = "0x1B13E88", VA = "0x1B13E88", Slot = "10")]
	internal virtual void StartWriteProperty(string name)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1B13F58", Offset = "0x1B13F58", VA = "0x1B13F58", Slot = "11")]
	internal virtual void EndWriteProperty(string name)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1B13F5C", Offset = "0x1B13F5C", VA = "0x1B13F5C", Slot = "12")]
	internal virtual void StartWriteCollection()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1B13F6C", Offset = "0x1B13F6C", VA = "0x1B13F6C", Slot = "13")]
	internal virtual void EndWriteCollection()
	{
	}

	[Token(Token = "0x6000250")]
	internal abstract void StartWriteCollectionItem(int index);

	[Token(Token = "0x6000251")]
	internal abstract void EndWriteCollectionItem(int index);

	[Token(Token = "0x6000252")]
	internal abstract void StartWriteDictionary();

	[Token(Token = "0x6000253")]
	internal abstract void EndWriteDictionary();

	[Token(Token = "0x6000254")]
	internal abstract void StartWriteDictionaryKey(int index);

	[Token(Token = "0x6000255")]
	internal abstract void EndWriteDictionaryKey(int index);

	[Token(Token = "0x6000256")]
	internal abstract void StartWriteDictionaryValue(int index);

	[Token(Token = "0x6000257")]
	internal abstract void EndWriteDictionaryValue(int index);

	[Token(Token = "0x6000258")]
	public abstract void Dispose();

	[Token(Token = "0x6000259")]
	internal abstract void WriteRawProperty(string name, byte[] bytes);

	[Token(Token = "0x600025A")]
	internal abstract void WritePrimitive(int value);

	[Token(Token = "0x600025B")]
	internal abstract void WritePrimitive(float value);

	[Token(Token = "0x600025C")]
	internal abstract void WritePrimitive(bool value);

	[Token(Token = "0x600025D")]
	internal abstract void WritePrimitive(decimal value);

	[Token(Token = "0x600025E")]
	internal abstract void WritePrimitive(double value);

	[Token(Token = "0x600025F")]
	internal abstract void WritePrimitive(long value);

	[Token(Token = "0x6000260")]
	internal abstract void WritePrimitive(ulong value);

	[Token(Token = "0x6000261")]
	internal abstract void WritePrimitive(uint value);

	[Token(Token = "0x6000262")]
	internal abstract void WritePrimitive(byte value);

	[Token(Token = "0x6000263")]
	internal abstract void WritePrimitive(sbyte value);

	[Token(Token = "0x6000264")]
	internal abstract void WritePrimitive(short value);

	[Token(Token = "0x6000265")]
	internal abstract void WritePrimitive(ushort value);

	[Token(Token = "0x6000266")]
	internal abstract void WritePrimitive(char value);

	[Token(Token = "0x6000267")]
	internal abstract void WritePrimitive(string value);

	[Token(Token = "0x6000268")]
	internal abstract void WritePrimitive(byte[] value);

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1B13F7C", Offset = "0x1B13F7C", VA = "0x1B13F7C")]
	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x1B1404C", Offset = "0x1B1404C", VA = "0x1B1404C", Slot = "39")]
	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	[Token(Token = "0x600026B")]
	public virtual void Write<T>(string key, object value)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x1B14138", Offset = "0x1B14138", VA = "0x1B14138", Slot = "41")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73ED9C", Offset = "0x73ED9C")]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x1B14274", Offset = "0x1B14274", VA = "0x1B14274", Slot = "42")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EDB0", Offset = "0x73EDB0")]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x1B14340", Offset = "0x1B14340", VA = "0x1B14340", Slot = "43")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EDC4", Offset = "0x73EDC4")]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1B14974", Offset = "0x1B14974", VA = "0x1B14974", Slot = "44")]
	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x1B14AEC", Offset = "0x1B14AEC", VA = "0x1B14AEC", Slot = "45")]
	public virtual void WriteProperty(string name, object value)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x1B14B14", Offset = "0x1B14B14", VA = "0x1B14B14", Slot = "46")]
	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000272")]
	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x1B14C4C", Offset = "0x1B14C4C", VA = "0x1B14C4C", Slot = "48")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EDD8", Offset = "0x73EDD8")]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x1B14C74", Offset = "0x1B14C74", VA = "0x1B14C74", Slot = "49")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EDEC", Offset = "0x73EDEC")]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x1B14D10", Offset = "0x1B14D10", VA = "0x1B14D10", Slot = "50")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EE00", Offset = "0x73EE00")]
	public virtual void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1B14E28", Offset = "0x1B14E28", VA = "0x1B14E28")]
	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x1B15038", Offset = "0x1B15038", VA = "0x1B15038")]
	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x1B15248", Offset = "0x1B15248", VA = "0x1B15248")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EE14", Offset = "0x73EE14")]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x1B15410", Offset = "0x1B15410", VA = "0x1B15410")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EE28", Offset = "0x73EE28")]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x1B155D8", Offset = "0x1B155D8", VA = "0x1B155D8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EE3C", Offset = "0x73EE3C")]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x1B157DC", Offset = "0x1B157DC", VA = "0x1B157DC")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EE50", Offset = "0x73EE50")]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x1B135E8", Offset = "0x1B135E8", VA = "0x1B135E8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EE64", Offset = "0x73EE64")]
	public void WriteType(Type type)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x1B159E0", Offset = "0x1B159E0", VA = "0x1B159E0")]
	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x1B15A5C", Offset = "0x1B15A5C", VA = "0x1B15A5C")]
	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x1B15A6C", Offset = "0x1B15A6C", VA = "0x1B15A6C")]
	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x1B15ACC", Offset = "0x1B15ACC", VA = "0x1B15ACC")]
	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x1B14B9C", Offset = "0x1B14B9C", VA = "0x1B14B9C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EE78", Offset = "0x73EE78")]
	protected bool SerializationDepthLimitExceeded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x1B15C50", Offset = "0x1B15C50", VA = "0x1B15C50", Slot = "51")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EE8C", Offset = "0x73EE8C")]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x1B15CB4", Offset = "0x1B15CB4", VA = "0x1B15CB4")]
	protected void Merge()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x1B15E00", Offset = "0x1B15E00", VA = "0x1B15E00")]
	protected void Merge(ES3Reader reader)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x1B16130", Offset = "0x1B16130", VA = "0x1B16130", Slot = "52")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x1B16144", Offset = "0x1B16144", VA = "0x1B16144", Slot = "53")]
	public virtual void Save(bool overwriteKeys)
	{
	}
}
[Token(Token = "0x200003F")]
public class ES3XMLWriter
{
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x1467560", Offset = "0x1467560", VA = "0x1467560")]
	public ES3XMLWriter()
	{
	}
}
namespace ES3Types
{
	[Token(Token = "0x2000040")]
	[Preserve]
	public class ES3Type_ES3Prefab : ES3Type
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x175F114", Offset = "0x175F114", VA = "0x175F114")]
		public ES3Type_ES3Prefab()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x175F1DC", Offset = "0x175F1DC", VA = "0x175F1DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600028A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	public class ES3Type_ES3PrefabInternal : ES3Type
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x175F1E4", Offset = "0x175F1E4", VA = "0x175F1E4")]
		public ES3Type_ES3PrefabInternal()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x175F2AC", Offset = "0x175F2AC", VA = "0x175F2AC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600028E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class ES32DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000291")]
		[Address(RVA = "0xD6AAA8", Offset = "0xD6AAA8", VA = "0xD6AAA8")]
		public ES32DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xD6ABB8", Offset = "0xD6ABB8", VA = "0xD6ABB8", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		[Token(Token = "0x6000293")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xD6ADD4", Offset = "0xD6ADD4", VA = "0xD6ADD4", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xD6B04C", Offset = "0xD6B04C", VA = "0xD6B04C", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class ES33DArrayType : ES3CollectionType
	{
		[Token(Token = "0x6000297")]
		[Address(RVA = "0xD6B31C", Offset = "0xD6B31C", VA = "0xD6B31C")]
		public ES33DArrayType(Type type)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xD6B320", Offset = "0xD6B320", VA = "0xD6B320", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x6000299")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xD6B5D4", Offset = "0xD6B5D4", VA = "0xD6B5D4", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xD6B928", Offset = "0xD6B928", VA = "0xD6B928", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000044")]
	[Preserve]
	public class ES3ArrayType : ES3CollectionType
	{
		[Token(Token = "0x600029D")]
		[Address(RVA = "0xD6BC98", Offset = "0xD6BC98", VA = "0xD6BC98")]
		public ES3ArrayType(Type type)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xD6BC9C", Offset = "0xD6BC9C", VA = "0xD6BC9C")]
		public ES3ArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xD6BD1C", Offset = "0xD6BD1C", VA = "0xD6BD1C", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xD6BEA0", Offset = "0xD6BEA0", VA = "0xD6BEA0", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xD6C0D4", Offset = "0xD6C0D4", VA = "0xD6C0D4", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000045")]
	[Preserve]
	public abstract class ES3CollectionType : ES3Type
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type elementType;

		[Token(Token = "0x60002A4")]
		public abstract object Read(ES3Reader reader);

		[Token(Token = "0x60002A5")]
		public abstract void ReadInto(ES3Reader reader, object obj);

		[Token(Token = "0x60002A6")]
		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xD6AAAC", Offset = "0xD6AAAC", VA = "0xD6AAAC")]
		public ES3CollectionType(Type type)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xD6BCDC", Offset = "0xD6BCDC", VA = "0xD6BCDC")]
		public ES3CollectionType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xD7124C", Offset = "0xD7124C", VA = "0xD7124C", Slot = "4")]
		[Preserve]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002AA")]
		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xD7125C", Offset = "0xD7125C", VA = "0xD7125C", Slot = "12")]
		[Preserve]
		protected virtual void ReadICollectionInto(ES3Reader reader, ICollection collection, ES3Type elementType)
		{
		}
	}
	[Token(Token = "0x2000046")]
	[Preserve]
	public class ES3DictionaryType : ES3Type
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type keyType;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ES3Type valueType;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xD7236C", Offset = "0xD7236C", VA = "0xD7236C")]
		public ES3DictionaryType(Type type)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xD724B0", Offset = "0xD724B0", VA = "0xD724B0")]
		public ES3DictionaryType(Type type, ES3Type keyType, ES3Type valueType)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xD7251C", Offset = "0xD7251C", VA = "0xD7251C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xD72540", Offset = "0xD72540", VA = "0xD72540")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002B1")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xD72950", Offset = "0xD72950", VA = "0xD72950")]
		public object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xD72B9C", Offset = "0xD72B9C", VA = "0xD72B9C")]
		public void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000047")]
	[Preserve]
	public class ES3HashSetType : ES3CollectionType
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xD7482C", Offset = "0xD7482C", VA = "0xD7482C")]
		public ES3HashSetType(Type type)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xD74830", Offset = "0xD74830", VA = "0xD74830", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002B7")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xD74E10", Offset = "0xD74E10", VA = "0xD74E10", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xD75108", Offset = "0xD75108", VA = "0xD75108", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000048")]
	[Preserve]
	public class ES3ListType : ES3CollectionType
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xD783F8", Offset = "0xD783F8", VA = "0xD783F8")]
		public ES3ListType(Type type)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xD783FC", Offset = "0xD783FC", VA = "0xD783FC")]
		public ES3ListType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xD7843C", Offset = "0xD7843C", VA = "0xD7843C", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002BE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xD78820", Offset = "0xD78820", VA = "0xD78820", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xD78A0C", Offset = "0xD78A0C", VA = "0xD78A0C", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000049")]
	[Preserve]
	public class ES3NativeArrayType : ES3CollectionType
	{
		[Serializable]
		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736524", Offset = "0x736524")]
		private sealed class <>c
		{
			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MethodInfo, bool> <>9__6_0;

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x101BA2C", Offset = "0x101BA2C", VA = "0x101BA2C")]
			public <>c()
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x101BA34", Offset = "0x101BA34", VA = "0x101BA34")]
			internal bool <ReadInto>b__6_0(MethodInfo m)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xD7907C", Offset = "0xD7907C", VA = "0xD7907C")]
		public ES3NativeArrayType(Type type)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xD79080", Offset = "0xD79080", VA = "0xD79080")]
		public ES3NativeArrayType(Type type, ES3Type elementType)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xD790C0", Offset = "0xD790C0", VA = "0xD790C0", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xD79478", Offset = "0xD79478", VA = "0xD79478", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xD79810", Offset = "0xD79810", VA = "0xD79810", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xD795DC", Offset = "0xD795DC", VA = "0xD795DC")]
		private Array ReadAsArray(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004B")]
	[Preserve]
	public class ES3QueueType : ES3CollectionType
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xD7AD38", Offset = "0xD7AD38", VA = "0xD7AD38")]
		public ES3QueueType(Type type)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xD7AD3C", Offset = "0xD7AD3C", VA = "0xD7AD3C", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002CF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xD7B10C", Offset = "0xD7B10C", VA = "0xD7B10C", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xD7B410", Offset = "0xD7B410", VA = "0xD7B410", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200004C")]
	[Preserve]
	public class ES3StackType : ES3CollectionType
	{
		[Serializable]
		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x736554", Offset = "0x736554")]
		private sealed class <>c
		{
			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MethodInfo, bool> <>9__4_0;

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x101C754", Offset = "0x101C754", VA = "0x101C754")]
			public <>c()
			{
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x101C75C", Offset = "0x101C75C", VA = "0x101C75C")]
			internal bool <Read>b__4_0(MethodInfo t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x17562BC", Offset = "0x17562BC", VA = "0x17562BC")]
		public ES3StackType(Type type)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x17562C4", Offset = "0x17562C4", VA = "0x17562C4", Slot = "9")]
		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002D5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1756694", Offset = "0x1756694", VA = "0x1756694", Slot = "7")]
		public override object Read(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1756AFC", Offset = "0x1756AFC", VA = "0x1756AFC", Slot = "8")]
		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200004E")]
	[Preserve]
	public class ES3TupleType : ES3Type
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ES3Type[] es3Types;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Type[] types;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected ES3Reflection.ES3ReflectedMethod readMethod;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x175744C", Offset = "0x175744C", VA = "0x175744C")]
		public ES3TupleType(Type type)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1757620", Offset = "0x1757620", VA = "0x1757620", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1757644", Offset = "0x1757644", VA = "0x1757644")]
		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		[Token(Token = "0x60002DF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200004F")]
	[Preserve]
	public abstract class ES3ComponentType : ES3UnityObjectType
	{
		[Token(Token = "0x4000136")]
		protected const string gameObjectPropertyName = "goID";

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xD7178C", Offset = "0xD7178C", VA = "0xD7178C")]
		public ES3ComponentType(Type type)
		{
		}

		[Token(Token = "0x60002E1")]
		protected abstract void WriteComponent(object obj, ES3Writer writer);

		[Token(Token = "0x60002E2")]
		protected abstract void ReadComponent<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xD71794", Offset = "0xD71794", VA = "0xD71794", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002E4")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002E5")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xD71DB8", Offset = "0xD71DB8", VA = "0xD71DB8")]
		private static Component GetOrAddComponent(GameObject go, Type type)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xD71E74", Offset = "0xD71E74", VA = "0xD71E74")]
		public static Component CreateComponent(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000050")]
	[Preserve]
	public abstract class ES3ObjectType : ES3Type
	{
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xD79A50", Offset = "0xD79A50", VA = "0xD79A50")]
		public ES3ObjectType(Type type)
		{
		}

		[Token(Token = "0x60002EA")]
		protected abstract void WriteObject(object obj, ES3Writer writer);

		[Token(Token = "0x60002EB")]
		protected abstract object ReadObject<T>(ES3Reader reader);

		[Token(Token = "0x60002EC")]
		protected virtual void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xD79A58", Offset = "0xD79A58", VA = "0xD79A58", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002EE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000051")]
	[Preserve]
	public abstract class ES3ScriptableObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x174E26C", Offset = "0x174E26C", VA = "0x174E26C")]
		public ES3ScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x60002F1")]
		protected abstract void WriteScriptableObject(object obj, ES3Writer writer);

		[Token(Token = "0x60002F2")]
		protected abstract void ReadScriptableObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x175320C", Offset = "0x175320C", VA = "0x175320C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002F4")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002F5")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x7365A4", Offset = "0x7365A4")]
	[Preserve]
	public abstract class ES3Type
	{
		[Token(Token = "0x4000137")]
		public const string typeFieldName = "__type";

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ES3Member[] members;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isPrimitive;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isValueType;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isCollection;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isDictionary;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTuple;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isEnum;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isES3TypeUnityObject;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isReflectedType;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isUnsupported;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int priority;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x174E2A0", Offset = "0x174E2A0", VA = "0x174E2A0")]
		protected ES3Type(Type type)
		{
		}

		[Token(Token = "0x60002F8")]
		public abstract void Write(object obj, ES3Writer writer);

		[Token(Token = "0x60002F9")]
		public abstract object Read<T>(ES3Reader reader);

		[Token(Token = "0x60002FA")]
		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x17579F0", Offset = "0x17579F0", VA = "0x17579F0")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FC")]
		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1757B00", Offset = "0x1757B00", VA = "0x1757B00")]
		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x174E0B4", Offset = "0x174E0B4", VA = "0x174E0B4")]
		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1757B5C", Offset = "0x1757B5C", VA = "0x1757B5C")]
		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x174E0A4", Offset = "0x174E0A4", VA = "0x174E0A4")]
		protected void GetMembers(bool safe)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x174E3B0", Offset = "0x174E3B0", VA = "0x174E3B0")]
		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x7365E0", Offset = "0x7365E0")]
	public class ES3PropertiesAttribute : Attribute
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string[] members;

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xD7AD04", Offset = "0xD7AD04", VA = "0xD7AD04")]
		public ES3PropertiesAttribute(params string[] members)
		{
		}
	}
	[Token(Token = "0x2000054")]
	[Preserve]
	public abstract class ES3UnityObjectType : ES3ObjectType
	{
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1B0AD4C", Offset = "0x1B0AD4C", VA = "0x1B0AD4C")]
		public ES3UnityObjectType(Type type)
		{
		}

		[Token(Token = "0x6000304")]
		protected abstract void WriteUnityObject(object obj, ES3Writer writer);

		[Token(Token = "0x6000305")]
		protected abstract void ReadUnityObject<T>(ES3Reader reader, object obj);

		[Token(Token = "0x6000306")]
		protected abstract object ReadUnityObject<T>(ES3Reader reader);

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1B131E8", Offset = "0x1B131E8", VA = "0x1B131E8", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1B131FC", Offset = "0x1B131FC", VA = "0x1B131FC", Slot = "13")]
		public virtual void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x6000309")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600030A")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1B13474", Offset = "0x1B13474", VA = "0x1B13474")]
		protected bool WriteUsingDerivedType(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000055")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x736604", Offset = "0x736604")]
	public class ES3Type_BigInteger : ES3Type
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x175AC80", Offset = "0x175AC80", VA = "0x175AC80")]
		public ES3Type_BigInteger()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x175AD48", Offset = "0x175AD48", VA = "0x175AD48", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600030E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000056")]
	public class ES3Type_BigIntegerArray : ES3ArrayType
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x175AE5C", Offset = "0x175AE5C", VA = "0x175AE5C")]
		public ES3Type_BigIntegerArray()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x736694", Offset = "0x736694")]
	public class ES3Type_Random : ES3ObjectType
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1CFF0F8", Offset = "0x1CFF0F8", VA = "0x1CFF0F8")]
		public ES3Type_Random()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1CFF1C4", Offset = "0x1CFF1C4", VA = "0x1CFF1C4", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000313")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000314")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public class ES3Type_RandomArray : ES3ArrayType
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1CFF2CC", Offset = "0x1CFF2CC", VA = "0x1CFF2CC")]
		public ES3Type_RandomArray()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[Preserve]
	public class ES3Type_DateTime : ES3Type
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x175EE14", Offset = "0x175EE14", VA = "0x175EE14")]
		public ES3Type_DateTime()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x175EEDC", Offset = "0x175EEDC", VA = "0x175EEDC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000319")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005A")]
	public class ES3Type_DateTimeArray : ES3ArrayType
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x175F018", Offset = "0x175F018", VA = "0x175F018")]
		public ES3Type_DateTimeArray()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[Preserve]
	public class ES3Type_ES3Ref : ES3Type
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x175F450", Offset = "0x175F450", VA = "0x175F450")]
		public ES3Type_ES3Ref()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x175F520", Offset = "0x175F520", VA = "0x175F520", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600031E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005C")]
	public class ES3Type_ES3RefArray : ES3ArrayType
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x175F630", Offset = "0x175F630", VA = "0x175F630")]
		public ES3Type_ES3RefArray()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class ES3Type_ES3RefDictionary : ES3DictionaryType
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x175F7A4", Offset = "0x175F7A4", VA = "0x175F7A4")]
		public ES3Type_ES3RefDictionary()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[Preserve]
	public class ES3Type_UIntPtr : ES3Type
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1B0EB0C", Offset = "0x1B0EB0C", VA = "0x1B0EB0C")]
		public ES3Type_UIntPtr()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1B0EBE0", Offset = "0x1B0EBE0", VA = "0x1B0EBE0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000326")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200005F")]
	public class ES3Type_UIntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1B0EC78", Offset = "0x1B0EC78", VA = "0x1B0EC78")]
		public ES3Type_UIntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[Preserve]
	public class ES3Type_bool : ES3Type
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1B10508", Offset = "0x1B10508", VA = "0x1B10508")]
		public ES3Type_bool()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1B105DC", Offset = "0x1B105DC", VA = "0x1B105DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600032B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000061")]
	public class ES3Type_boolArray : ES3ArrayType
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1B10674", Offset = "0x1B10674", VA = "0x1B10674")]
		public ES3Type_boolArray()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[Preserve]
	public class ES3Type_byte : ES3Type
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1B10770", Offset = "0x1B10770", VA = "0x1B10770")]
		public ES3Type_byte()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1B10844", Offset = "0x1B10844", VA = "0x1B10844", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000330")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	[Preserve]
	public class ES3Type_byteArray : ES3Type
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1B108DC", Offset = "0x1B108DC", VA = "0x1B108DC")]
		public ES3Type_byteArray()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1B109B0", Offset = "0x1B109B0", VA = "0x1B109B0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000334")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	[Preserve]
	public class ES3Type_char : ES3Type
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1B10A48", Offset = "0x1B10A48", VA = "0x1B10A48")]
		public ES3Type_char()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1B10B1C", Offset = "0x1B10B1C", VA = "0x1B10B1C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000338")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	public class ES3Type_charArray : ES3ArrayType
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1B10BB4", Offset = "0x1B10BB4", VA = "0x1B10BB4")]
		public ES3Type_charArray()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[Preserve]
	public class ES3Type_decimal : ES3Type
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1B10CB0", Offset = "0x1B10CB0", VA = "0x1B10CB0")]
		public ES3Type_decimal()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1B10D84", Offset = "0x1B10D84", VA = "0x1B10D84", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600033D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000067")]
	public class ES3Type_decimalArray : ES3ArrayType
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1B10E1C", Offset = "0x1B10E1C", VA = "0x1B10E1C")]
		public ES3Type_decimalArray()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[Preserve]
	public class ES3Type_double : ES3Type
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1B10F18", Offset = "0x1B10F18", VA = "0x1B10F18")]
		public ES3Type_double()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1B10FEC", Offset = "0x1B10FEC", VA = "0x1B10FEC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000342")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000069")]
	public class ES3Type_doubleArray : ES3ArrayType
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1B11084", Offset = "0x1B11084", VA = "0x1B11084")]
		public ES3Type_doubleArray()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[Preserve]
	public class ES3Type_enum : ES3Type
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Type underlyingType;

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1B11180", Offset = "0x1B11180", VA = "0x1B11180")]
		public ES3Type_enum(Type type)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1B1125C", Offset = "0x1B1125C", VA = "0x1B1125C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000347")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	[Preserve]
	public class ES3Type_float : ES3Type
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1B11D48", Offset = "0x1B11D48", VA = "0x1B11D48")]
		public ES3Type_float()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1B11E1C", Offset = "0x1B11E1C", VA = "0x1B11E1C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600034B")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	public class ES3Type_floatArray : ES3ArrayType
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1B11EB4", Offset = "0x1B11EB4", VA = "0x1B11EB4")]
		public ES3Type_floatArray()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[Preserve]
	public class ES3Type_int : ES3Type
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1B11FB0", Offset = "0x1B11FB0", VA = "0x1B11FB0")]
		public ES3Type_int()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1B12084", Offset = "0x1B12084", VA = "0x1B12084", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000350")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200006E")]
	public class ES3Type_intArray : ES3ArrayType
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1B1211C", Offset = "0x1B1211C", VA = "0x1B1211C")]
		public ES3Type_intArray()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[Preserve]
	public class ES3Type_IntPtr : ES3Type
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1CF645C", Offset = "0x1CF645C", VA = "0x1CF645C")]
		public ES3Type_IntPtr()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1CF6530", Offset = "0x1CF6530", VA = "0x1CF6530", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000355")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000070")]
	public class ES3Type_IntPtrArray : ES3ArrayType
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1CF65D4", Offset = "0x1CF65D4", VA = "0x1CF65D4")]
		public ES3Type_IntPtrArray()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[Preserve]
	public class ES3Type_long : ES3Type
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1B12218", Offset = "0x1B12218", VA = "0x1B12218")]
		public ES3Type_long()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1B122EC", Offset = "0x1B122EC", VA = "0x1B122EC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600035A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000072")]
	public class ES3Type_longArray : ES3ArrayType
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1B12384", Offset = "0x1B12384", VA = "0x1B12384")]
		public ES3Type_longArray()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[Preserve]
	public class ES3Type_sbyte : ES3Type
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1B12480", Offset = "0x1B12480", VA = "0x1B12480")]
		public ES3Type_sbyte()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1B12554", Offset = "0x1B12554", VA = "0x1B12554", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600035F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000074")]
	public class ES3Type_sbyteArray : ES3ArrayType
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1B125EC", Offset = "0x1B125EC", VA = "0x1B125EC")]
		public ES3Type_sbyteArray()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[Preserve]
	public class ES3Type_short : ES3Type
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1B126E8", Offset = "0x1B126E8", VA = "0x1B126E8")]
		public ES3Type_short()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1B127BC", Offset = "0x1B127BC", VA = "0x1B127BC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000364")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000076")]
	public class ES3Type_shortArray : ES3ArrayType
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1B12854", Offset = "0x1B12854", VA = "0x1B12854")]
		public ES3Type_shortArray()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[Preserve]
	public class ES3Type_string : ES3Type
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1B12950", Offset = "0x1B12950", VA = "0x1B12950")]
		public ES3Type_string()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1B12A24", Offset = "0x1B12A24", VA = "0x1B12A24", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000369")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	public class ES3Type_StringArray : ES3ArrayType
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1B0BC70", Offset = "0x1B0BC70", VA = "0x1B0BC70")]
		public ES3Type_StringArray()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[Preserve]
	public class ES3Type_uint : ES3Type
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1B12AB0", Offset = "0x1B12AB0", VA = "0x1B12AB0")]
		public ES3Type_uint()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1B12B84", Offset = "0x1B12B84", VA = "0x1B12B84", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600036E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200007A")]
	public class ES3Type_uintArray : ES3ArrayType
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1B12C1C", Offset = "0x1B12C1C", VA = "0x1B12C1C")]
		public ES3Type_uintArray()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[Preserve]
	public class ES3Type_ulong : ES3Type
	{
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1B12D18", Offset = "0x1B12D18", VA = "0x1B12D18")]
		public ES3Type_ulong()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1B12DEC", Offset = "0x1B12DEC", VA = "0x1B12DEC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000373")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200007C")]
	public class ES3Type_ulongArray : ES3ArrayType
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1B12E84", Offset = "0x1B12E84", VA = "0x1B12E84")]
		public ES3Type_ulongArray()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[Preserve]
	public class ES3Type_ushort : ES3Type
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1B12F80", Offset = "0x1B12F80", VA = "0x1B12F80")]
		public ES3Type_ushort()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1B13054", Offset = "0x1B13054", VA = "0x1B13054", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000378")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200007E")]
	public class ES3Type_ushortArray : ES3ArrayType
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1B130EC", Offset = "0x1B130EC", VA = "0x1B130EC")]
		public ES3Type_ushortArray()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[Preserve]
	internal class ES3ReflectedComponentType : ES3ComponentType
	{
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x174E06C", Offset = "0x174E06C", VA = "0x174E06C")]
		public ES3ReflectedComponentType(Type type)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x174E0B0", Offset = "0x174E0B0", VA = "0x174E0B0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600037D")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000080")]
	[Preserve]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x174E1F8", Offset = "0x174E1F8", VA = "0x174E1F8")]
		public ES3ReflectedObjectType(Type type)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x174E230", Offset = "0x174E230", VA = "0x174E230", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000380")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000081")]
	[Preserve]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x174E234", Offset = "0x174E234", VA = "0x174E234")]
		public ES3ReflectedScriptableObjectType(Type type)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x174E274", Offset = "0x174E274", VA = "0x174E274", Slot = "14")]
		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000384")]
		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000082")]
	[Preserve]
	internal class ES3ReflectedType : ES3Type
	{
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x174E278", Offset = "0x174E278", VA = "0x174E278")]
		public ES3ReflectedType(Type type)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x174E378", Offset = "0x174E378", VA = "0x174E378")]
		public ES3ReflectedType(Type type, string[] members)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x174E560", Offset = "0x174E560", VA = "0x174E560", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000388")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000083")]
	[Preserve]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x174EBA8", Offset = "0x174EBA8", VA = "0x174EBA8")]
		public ES3ReflectedUnityObjectType(Type type)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x174EBE0", Offset = "0x174EBE0", VA = "0x174EBE0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600038C")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000084")]
	[Preserve]
	internal class ES3ReflectedValueType : ES3Type
	{
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x174EBE4", Offset = "0x174EBE4", VA = "0x174EBE4")]
		public ES3ReflectedValueType(Type type)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x174EC18", Offset = "0x174EC18", VA = "0x174EC18", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000390")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7368FC", Offset = "0x7368FC")]
	[Preserve]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x175B880", Offset = "0x175B880", VA = "0x175B880")]
		public ES3Type_BoxCollider()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x175B94C", Offset = "0x175B94C", VA = "0x175B94C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000394")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000086")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x736A18", Offset = "0x736A18")]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x175BBF4", Offset = "0x175BBF4", VA = "0x175BBF4")]
		public ES3Type_BoxCollider2D()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x175BCC0", Offset = "0x175BCC0", VA = "0x175BCC0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000398")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000087")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x736B50", Offset = "0x736B50")]
	public class ES3Type_Camera : ES3ComponentType
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x175C63C", Offset = "0x175C63C", VA = "0x175C63C")]
		public ES3Type_Camera()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x175C708", Offset = "0x175C708", VA = "0x175C708", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600039C")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x736F60", Offset = "0x736F60")]
	[Preserve]
	public class ES3Type_CapsuleCollider : ES3ComponentType
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x175D2AC", Offset = "0x175D2AC", VA = "0x175D2AC")]
		public ES3Type_CapsuleCollider()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x175D378", Offset = "0x175D378", VA = "0x175D378", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A0")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000089")]
	[Preserve]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x175FDDC", Offset = "0x175FDDC", VA = "0x175FDDC")]
		public ES3Type_EventSystem()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x175FEA8", Offset = "0x175FEA8", VA = "0x175FEA8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A4")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7370C4", Offset = "0x7370C4")]
	[Preserve]
	public class ES3Type_Image : ES3ComponentType
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1762D6C", Offset = "0x1762D6C", VA = "0x1762D6C")]
		public ES3Type_Image()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1762E44", Offset = "0x1762E44", VA = "0x1762E44", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003A8")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class ES3Type_ImageArray : ES3ArrayType
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1CF5FA0", Offset = "0x1CF5FA0", VA = "0x1CF5FA0")]
		public ES3Type_ImageArray()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x737384", Offset = "0x737384")]
	[Preserve]
	public class ES3Type_MeshCollider : ES3ComponentType
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1CFABA4", Offset = "0x1CFABA4", VA = "0x1CFABA4")]
		public ES3Type_MeshCollider()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1CFAC70", Offset = "0x1CFAC70", VA = "0x1CFAC70", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003AD")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class ES3Type_MeshColliderArray : ES3ArrayType
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1CFAF94", Offset = "0x1CFAF94", VA = "0x1CFAF94")]
		public ES3Type_MeshColliderArray()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7374D8", Offset = "0x7374D8")]
	public class ES3Type_MeshFilter : ES3ComponentType
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1CFB090", Offset = "0x1CFB090", VA = "0x1CFB090")]
		public ES3Type_MeshFilter()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1CFB15C", Offset = "0x1CFB15C", VA = "0x1CFB15C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B2")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class ES3Type_MeshFilterArray : ES3ArrayType
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1CFB208", Offset = "0x1CFB208", VA = "0x1CFB208")]
		public ES3Type_MeshFilterArray()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x737568", Offset = "0x737568")]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1CFB304", Offset = "0x1CFB304", VA = "0x1CFB304")]
		public ES3Type_MeshRenderer()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1CFB3D0", Offset = "0x1CFB3D0", VA = "0x1CFB3D0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003B7")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class ES3Type_MeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1CFBBDC", Offset = "0x1CFBBDC", VA = "0x1CFBBDC")]
		public ES3Type_MeshRendererArray()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7377B8", Offset = "0x7377B8")]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1CFD268", Offset = "0x1CFD268", VA = "0x1CFD268")]
		public ES3Type_ParticleSystem()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1CFD334", Offset = "0x1CFD334", VA = "0x1CFD334", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003BC")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000093")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x737B20", Offset = "0x737B20")]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1CFE5C4", Offset = "0x1CFE5C4", VA = "0x1CFE5C4")]
		public ES3Type_PolygonCollider2D()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1CFE690", Offset = "0x1CFE690", VA = "0x1CFE690", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C0")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class ES3Type_PolygonCollider2DArray : ES3ArrayType
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1CFEC18", Offset = "0x1CFEC18", VA = "0x1CFEC18")]
		public ES3Type_PolygonCollider2DArray()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x737C90", Offset = "0x737C90")]
	public class ES3Type_RawImage : ES3ComponentType
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1CFF3C8", Offset = "0x1CFF3C8", VA = "0x1CFF3C8")]
		public ES3Type_RawImage()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1CFF4A0", Offset = "0x1CFF4A0", VA = "0x1CFF4A0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003C5")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class ES3Type_RawImageArray : ES3ArrayType
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1CFF9FC", Offset = "0x1CFF9FC", VA = "0x1CFF9FC")]
		public ES3Type_RawImageArray()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x737E38", Offset = "0x737E38")]
	public class ES3Type_Rigidbody : ES3ComponentType
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1B06CE4", Offset = "0x1B06CE4", VA = "0x1B06CE4")]
		public ES3Type_Rigidbody()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1B06DBC", Offset = "0x1B06DBC", VA = "0x1B06DBC", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003CA")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class ES3UserType_RigidbodyArray : ES3ArrayType
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1B13688", Offset = "0x1B13688", VA = "0x1B13688")]
		public ES3UserType_RigidbodyArray()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x738114", Offset = "0x738114")]
	[Preserve]
	public class ES3Type_SphereCollider : ES3ComponentType
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1B0A81C", Offset = "0x1B0A81C", VA = "0x1B0A81C")]
		public ES3Type_SphereCollider()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1B0A8E8", Offset = "0x1B0A8E8", VA = "0x1B0A8E8", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003CF")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009A")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x738230", Offset = "0x738230")]
	public class ES3Type_Text : ES3ComponentType
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1B0C0F8", Offset = "0x1B0C0F8", VA = "0x1B0C0F8")]
		public ES3Type_Text()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1B0C1C4", Offset = "0x1B0C1C4", VA = "0x1B0C1C4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D3")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009B")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x738528", Offset = "0x738528")]
	public class ES3Type_Transform : ES3ComponentType
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int countRead;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1B0E3E8", Offset = "0x1B0E3E8", VA = "0x1B0E3E8")]
		public ES3Type_Transform()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1B0E4B4", Offset = "0x1B0E4B4", VA = "0x1B0E4B4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003D7")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009C")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x738628", Offset = "0x738628")]
	public class ES3Type_AnimationCurve : ES3Type
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x175A604", Offset = "0x175A604", VA = "0x175A604")]
		public ES3Type_AnimationCurve()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x175A6CC", Offset = "0x175A6CC", VA = "0x175A6CC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003DB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7386F0", Offset = "0x7386F0")]
	[Preserve]
	public class ES3Type_AudioClip : ES3UnityObjectType
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x175A870", Offset = "0x175A870", VA = "0x175A870")]
		public ES3Type_AudioClip()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x175A93C", Offset = "0x175A93C", VA = "0x175A93C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E0")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60003E1")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x200009E")]
	public class ES3Type_AudioClipArray : ES3ArrayType
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x175AB84", Offset = "0x175AB84", VA = "0x175AB84")]
		public ES3Type_AudioClipArray()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7387F0", Offset = "0x7387F0")]
	[Preserve]
	public class ES3Type_BoneWeight : ES3Type
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x175AF58", Offset = "0x175AF58", VA = "0x175AF58")]
		public ES3Type_BoneWeight()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x175B020", Offset = "0x175B020", VA = "0x175B020", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003E6")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A0")]
	public class ES3Type_BoneWeightArray : ES3ArrayType
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x175B41C", Offset = "0x175B41C", VA = "0x175B41C")]
		public ES3Type_BoneWeightArray()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x738944", Offset = "0x738944")]
	public class ES3Type_Bounds : ES3Type
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x175B518", Offset = "0x175B518", VA = "0x175B518")]
		public ES3Type_Bounds()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x175B5E0", Offset = "0x175B5E0", VA = "0x175B5E0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003EB")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A2")]
	public class ES3Type_BoundsArray : ES3ArrayType
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x175B784", Offset = "0x175B784", VA = "0x175B784")]
		public ES3Type_BoundsArray()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7389F0", Offset = "0x7389F0")]
	[Preserve]
	public class ES3Type_Burst : ES3Type
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x175C008", Offset = "0x175C008", VA = "0x175C008")]
		public ES3Type_Burst()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x175C0DC", Offset = "0x175C0DC", VA = "0x175C0DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F0")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A4")]
	public class ES3Type_BurstArray : ES3ArrayType
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x175C540", Offset = "0x175C540", VA = "0x175C540")]
		public ES3Type_BurstArray()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x738B28", Offset = "0x738B28")]
	public class ES3Type_CollisionModule : ES3Type
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x175D800", Offset = "0x175D800", VA = "0x175D800")]
		public ES3Type_CollisionModule()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x175D8C8", Offset = "0x175D8C8", VA = "0x175D8C8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003F5")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x738D94", Offset = "0x738D94")]
	public class ES3Type_Color : ES3Type
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x175DFC8", Offset = "0x175DFC8", VA = "0x175DFC8")]
		public ES3Type_Color()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x175E090", Offset = "0x175E090", VA = "0x175E090", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003FA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A7")]
	public class ES3Type_ColorArray : ES3ArrayType
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x175E6D0", Offset = "0x175E6D0", VA = "0x175E6D0")]
		public ES3Type_ColorArray()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x738E78", Offset = "0x738E78")]
	public class ES3Type_Color32 : ES3Type
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x175E2AC", Offset = "0x175E2AC", VA = "0x175E2AC")]
		public ES3Type_Color32()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x175E374", Offset = "0x175E374", VA = "0x175E374", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60003FF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x175E58C", Offset = "0x175E58C", VA = "0x175E58C")]
		public static bool Equals(Color32 a, Color32 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A9")]
	public class ES3Type_Color32Array : ES3ArrayType
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x175E5D4", Offset = "0x175E5D4", VA = "0x175E5D4")]
		public ES3Type_Color32Array()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x738F5C", Offset = "0x738F5C")]
	[Preserve]
	public class ES3Type_ColorBySpeedModule : ES3Type
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x175E7CC", Offset = "0x175E7CC", VA = "0x175E7CC")]
		public ES3Type_ColorBySpeedModule()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x175E894", Offset = "0x175E894", VA = "0x175E894", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000405")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x739024", Offset = "0x739024")]
	[Preserve]
	public class ES3Type_ColorOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x175EB40", Offset = "0x175EB40", VA = "0x175EB40")]
		public ES3Type_ColorOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x175EC08", Offset = "0x175EC08", VA = "0x175EC08", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600040A")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7390D0", Offset = "0x7390D0")]
	public class ES3Type_EmissionModule : ES3Type
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x175F91C", Offset = "0x175F91C", VA = "0x175F91C")]
		public ES3Type_EmissionModule()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x175F9E4", Offset = "0x175F9E4", VA = "0x175F9E4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600040F")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7391D0", Offset = "0x7391D0")]
	public class ES3Type_ExternalForcesModule : ES3Type
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x175FEB0", Offset = "0x175FEB0", VA = "0x175FEB0")]
		public ES3Type_ExternalForcesModule()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x175FF78", Offset = "0x175FF78", VA = "0x175FF78", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000414")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73927C", Offset = "0x73927C")]
	[Preserve]
	public class ES3Type_Flare : ES3Type
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1760158", Offset = "0x1760158", VA = "0x1760158")]
		public ES3Type_Flare()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1760220", Offset = "0x1760220", VA = "0x1760220", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000419")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class ES3Type_FlareArray : ES3ArrayType
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x17602F8", Offset = "0x17602F8", VA = "0x17602F8")]
		public ES3Type_FlareArray()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73930C", Offset = "0x73930C")]
	[Preserve]
	public class ES3Type_Font : ES3UnityObjectType
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x17603F4", Offset = "0x17603F4", VA = "0x17603F4")]
		public ES3Type_Font()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x17604C0", Offset = "0x17604C0", VA = "0x17604C0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600041F")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000420")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B1")]
	public class ES3Type_FontArray : ES3ArrayType
	{
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x17605EC", Offset = "0x17605EC", VA = "0x17605EC")]
		public ES3Type_FontArray()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7393B8", Offset = "0x7393B8")]
	[Preserve]
	public class ES3Type_ForceOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x17606E8", Offset = "0x17606E8", VA = "0x17606E8")]
		public ES3Type_ForceOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x17607B0", Offset = "0x17607B0", VA = "0x17607B0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000425")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x739528", Offset = "0x739528")]
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x739660", Offset = "0x739660")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Predicate<Component> <>9__0;

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x101C788", Offset = "0x101C788", VA = "0x101C788")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x101C790", Offset = "0x101C790", VA = "0x101C790")]
			internal bool <ReadComponents>b__0(Component x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400019F")]
		private const string prefabPropertyName = "es3Prefab";

		[Token(Token = "0x40001A0")]
		private const string transformPropertyName = "transformID";

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool saveChildren;

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1760CA0", Offset = "0x1760CA0", VA = "0x1760CA0")]
		public ES3Type_GameObject()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1760D6C", Offset = "0x1760D6C", VA = "0x1760D6C", Slot = "13")]
		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		[Token(Token = "0x600042A")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1761950", Offset = "0x1761950", VA = "0x1761950")]
		private void ReadComponents(ES3Reader reader, GameObject go)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1761FD0", Offset = "0x1761FD0", VA = "0x1761FD0")]
		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1761634", Offset = "0x1761634", VA = "0x1761634")]
		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1762064", Offset = "0x1762064", VA = "0x1762064", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000430")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000431")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B5")]
	public class ES3Type_GameObjectArray : ES3ArrayType
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x176206C", Offset = "0x176206C", VA = "0x176206C")]
		public ES3Type_GameObjectArray()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x739670", Offset = "0x739670")]
	public class ES3Type_Gradient : ES3Type
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1762168", Offset = "0x1762168", VA = "0x1762168")]
		public ES3Type_Gradient()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1762230", Offset = "0x1762230", VA = "0x1762230", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000438")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x739738", Offset = "0x739738")]
	[Preserve]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x17623E0", Offset = "0x17623E0", VA = "0x17623E0")]
		public ES3Type_GradientAlphaKey()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x17624A8", Offset = "0x17624A8", VA = "0x17624A8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600043D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B8")]
	public class ES3Type_GradientAlphaKeyArray : ES3ArrayType
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1762618", Offset = "0x1762618", VA = "0x1762618")]
		public ES3Type_GradientAlphaKeyArray()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x7397E4", Offset = "0x7397E4")]
	[Preserve]
	public class ES3Type_GradientColorKey : ES3Type
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1762714", Offset = "0x1762714", VA = "0x1762714")]
		public ES3Type_GradientColorKey()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x17627DC", Offset = "0x17627DC", VA = "0x17627DC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000442")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BA")]
	public class ES3Type_GradientColorKeyArray : ES3ArrayType
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1762998", Offset = "0x1762998", VA = "0x1762998")]
		public ES3Type_GradientColorKeyArray()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x739890", Offset = "0x739890")]
	public class ES3Type_Guid : ES3Type
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1762A94", Offset = "0x1762A94", VA = "0x1762A94")]
		public ES3Type_Guid()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1762B5C", Offset = "0x1762B5C", VA = "0x1762B5C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000447")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BC")]
	public class ES3Type_GuidArray : ES3ArrayType
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1762C70", Offset = "0x1762C70", VA = "0x1762C70")]
		public ES3Type_GuidArray()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x739920", Offset = "0x739920")]
	public class ES3Type_InheritVelocityModule : ES3Type
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1CF609C", Offset = "0x1CF609C", VA = "0x1CF609C")]
		public ES3Type_InheritVelocityModule()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1CF6168", Offset = "0x1CF6168", VA = "0x1CF6168", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600044C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x739A04", Offset = "0x739A04")]
	public class ES3Type_Keyframe : ES3Type
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1CF66D0", Offset = "0x1CF66D0", VA = "0x1CF66D0")]
		public ES3Type_Keyframe()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1CF679C", Offset = "0x1CF679C", VA = "0x1CF679C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000451")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BF")]
	public class ES3Type_KeyframeArray : ES3ArrayType
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1CF69EC", Offset = "0x1CF69EC", VA = "0x1CF69EC")]
		public ES3Type_KeyframeArray()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x739AE8", Offset = "0x739AE8")]
	public class ES3Type_LayerMask : ES3Type
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1CF6AE8", Offset = "0x1CF6AE8", VA = "0x1CF6AE8")]
		public ES3Type_LayerMask()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1CF6BB4", Offset = "0x1CF6BB4", VA = "0x1CF6BB4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000456")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x739BB0", Offset = "0x739BB0")]
	[Preserve]
	public class ES3Type_Light : ES3ComponentType
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1CF6CE8", Offset = "0x1CF6CE8", VA = "0x1CF6CE8")]
		public ES3Type_Light()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1CF6DB4", Offset = "0x1CF6DB4", VA = "0x1CF6DB4", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600045A")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x739E8C", Offset = "0x739E8C")]
	public class ES3Type_LightsModule : ES3Type
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1CF76AC", Offset = "0x1CF76AC", VA = "0x1CF76AC")]
		public ES3Type_LightsModule()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1CF7778", Offset = "0x1CF7778", VA = "0x1CF7778", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600045E")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73A050", Offset = "0x73A050")]
	public class ES3Type_LimitVelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1CF7D9C", Offset = "0x1CF7D9C", VA = "0x1CF7D9C")]
		public ES3Type_LimitVelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1CF7E68", Offset = "0x1CF7E68", VA = "0x1CF7E68", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000463")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73A214", Offset = "0x73A214")]
	public class ES3Type_MainModule : ES3Type
	{
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1CF846C", Offset = "0x1CF846C", VA = "0x1CF846C")]
		public ES3Type_MainModule()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1CF8538", Offset = "0x1CF8538", VA = "0x1CF8538", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000468")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73A694", Offset = "0x73A694")]
	public class ES3Type_Material : ES3UnityObjectType
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1CF9520", Offset = "0x1CF9520", VA = "0x1CF9520")]
		public ES3Type_Material()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1CF95EC", Offset = "0x1CF95EC", VA = "0x1CF95EC", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600046D")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class ES3Type_MaterialArray : ES3ArrayType
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1CF9ADC", Offset = "0x1CF9ADC", VA = "0x1CF9ADC")]
		public ES3Type_MaterialArray()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73A794", Offset = "0x73A794")]
	public class ES3Type_Matrix4x4 : ES3Type
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1CF9BD8", Offset = "0x1CF9BD8", VA = "0x1CF9BD8")]
		public ES3Type_Matrix4x4()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1CF9CA4", Offset = "0x1CF9CA4", VA = "0x1CF9CA4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000473")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C8")]
	public class ES3Type_Matrix4x4Array : ES3ArrayType
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1CF9F18", Offset = "0x1CF9F18", VA = "0x1CF9F18")]
		public ES3Type_Matrix4x4Array()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73A878", Offset = "0x73A878")]
	public class ES3Type_Mesh : ES3UnityObjectType
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1CFA014", Offset = "0x1CFA014", VA = "0x1CFA014")]
		public ES3Type_Mesh()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1CFA0E0", Offset = "0x1CFA0E0", VA = "0x1CFA0E0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000478")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73AA74", Offset = "0x73AA74")]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1CFBCD8", Offset = "0x1CFBCD8", VA = "0x1CFBCD8")]
		public ES3Type_MinMaxCurve()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1CFBDA4", Offset = "0x1CFBDA4", VA = "0x1CFBDA4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600047D")]
		[Preserve]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		[Preserve]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73ABC8", Offset = "0x73ABC8")]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1CFC160", Offset = "0x1CFC160", VA = "0x1CFC160")]
		public ES3Type_MinMaxGradient()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1CFC22C", Offset = "0x1CFC22C", VA = "0x1CFC22C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000482")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73AD00", Offset = "0x73AD00")]
	[Preserve]
	public class ES3Type_NoiseModule : ES3Type
	{
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1CFC5B8", Offset = "0x1CFC5B8", VA = "0x1CFC5B8")]
		public ES3Type_NoiseModule()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1CFC684", Offset = "0x1CFC684", VA = "0x1CFC684", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000486")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000487")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73B068", Offset = "0x73B068")]
	public class ES3Type_PhysicMaterial : ES3ObjectType
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1CFDE14", Offset = "0x1CFDE14", VA = "0x1CFDE14")]
		public ES3Type_PhysicMaterial()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1CFDEE0", Offset = "0x1CFDEE0", VA = "0x1CFDEE0", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600048B")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x600048C")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CE")]
	public class ES3Type_PhysicMaterialArray : ES3ArrayType
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1CFE188", Offset = "0x1CFE188", VA = "0x1CFE188")]
		public ES3Type_PhysicMaterialArray()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73B168", Offset = "0x73B168")]
	[Preserve]
	public class ES3Type_PhysicsMaterial2D : ES3ObjectType
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1CFE284", Offset = "0x1CFE284", VA = "0x1CFE284")]
		public ES3Type_PhysicsMaterial2D()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1CFE350", Offset = "0x1CFE350", VA = "0x1CFE350", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000491")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x6000492")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D0")]
	public class ES3Type_PhysicsMaterial2DArray : ES3ArrayType
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1CFE4C8", Offset = "0x1CFE4C8", VA = "0x1CFE4C8")]
		public ES3Type_PhysicsMaterial2DArray()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73B214", Offset = "0x73B214")]
	public class ES3Type_Quaternion : ES3Type
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1CFED14", Offset = "0x1CFED14", VA = "0x1CFED14")]
		public ES3Type_Quaternion()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1CFEDE0", Offset = "0x1CFEDE0", VA = "0x1CFEDE0", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000497")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D2")]
	public class ES3Type_QuaternionArray : ES3ArrayType
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1CFEFFC", Offset = "0x1CFEFFC", VA = "0x1CFEFFC")]
		public ES3Type_QuaternionArray()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73B2F8", Offset = "0x73B2F8")]
	public class ES3Type_Rect : ES3Type
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1CFFAF8", Offset = "0x1CFFAF8", VA = "0x1CFFAF8")]
		public ES3Type_Rect()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1CFFBC4", Offset = "0x1CFFBC4", VA = "0x1CFFBC4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600049C")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D4")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73B3DC", Offset = "0x73B3DC")]
	public class ES3Type_RectTransform : ES3ComponentType
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1CFFE04", Offset = "0x1CFFE04", VA = "0x1CFFE04")]
		public ES3Type_RectTransform()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1CFFED0", Offset = "0x1CFFED0", VA = "0x1CFFED0", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004A0")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73B5A0", Offset = "0x73B5A0")]
	public class ES3Type_RenderTexture : ES3ObjectType
	{
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1D00450", Offset = "0x1D00450", VA = "0x1D00450")]
		public ES3Type_RenderTexture()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1D0051C", Offset = "0x1D0051C", VA = "0x1D0051C", Slot = "7")]
		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004A4")]
		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60004A5")]
		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D6")]
	public class ES3Type_RenderTextureArray : ES3ArrayType
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1B06BE8", Offset = "0x1B06BE8", VA = "0x1B06BE8")]
		public ES3Type_RenderTextureArray()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73B994", Offset = "0x73B994")]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1B0771C", Offset = "0x1B0771C", VA = "0x1B0771C")]
		public ES3Type_RotationBySpeedModule()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1B077E8", Offset = "0x1B077E8", VA = "0x1B077E8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004AA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D8")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73BB04", Offset = "0x73BB04")]
	public class ES3Type_RotationOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1B07D10", Offset = "0x1B07D10", VA = "0x1B07D10")]
		public ES3Type_RotationOverLifetimeModule()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1B07DDC", Offset = "0x1B07DDC", VA = "0x1B07DDC", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004AF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73BC58", Offset = "0x73BC58")]
	[Preserve]
	public class ES3Type_Shader : ES3Type
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1B08270", Offset = "0x1B08270", VA = "0x1B08270")]
		public ES3Type_Shader()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1B0833C", Offset = "0x1B0833C", VA = "0x1B0833C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004B4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class ES3Type_ShaderArray : ES3ArrayType
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1B084DC", Offset = "0x1B084DC", VA = "0x1B084DC")]
		public ES3Type_ShaderArray()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73BD04", Offset = "0x73BD04")]
	[Preserve]
	public class ES3Type_ShapeModule : ES3Type
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1B085D8", Offset = "0x1B085D8", VA = "0x1B085D8")]
		public ES3Type_ShapeModule()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1B086A4", Offset = "0x1B086A4", VA = "0x1B086A4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004BA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73BF8C", Offset = "0x73BF8C")]
	public class ES3Type_SizeBySpeedModule : ES3Type
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1B08E88", Offset = "0x1B08E88", VA = "0x1B08E88")]
		public ES3Type_SizeBySpeedModule()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1B08F54", Offset = "0x1B08F54", VA = "0x1B08F54", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004BF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73C134", Offset = "0x73C134")]
	[Preserve]
	public class ES3Type_SizeOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1B0953C", Offset = "0x1B0953C", VA = "0x1B0953C")]
		public ES3Type_SizeOverLifetimeModule()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1B09608", Offset = "0x1B09608", VA = "0x1B09608", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004C4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DE")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73C2C0", Offset = "0x73C2C0")]
	[Preserve]
	public class ES3Type_SkinnedMeshRenderer : ES3ComponentType
	{
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1B09B5C", Offset = "0x1B09B5C", VA = "0x1B09B5C")]
		public ES3Type_SkinnedMeshRenderer()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1B09C28", Offset = "0x1B09C28", VA = "0x1B09C28", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004C9")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class ES3Type_SkinnedMeshRendererArray : ES3ArrayType
	{
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1B0A720", Offset = "0x1B0A720", VA = "0x1B0A720")]
		public ES3Type_SkinnedMeshRendererArray()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73C5B8", Offset = "0x73C5B8")]
	[Preserve]
	public class ES3Type_Sprite : ES3UnityObjectType
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1B0AC74", Offset = "0x1B0AC74", VA = "0x1B0AC74")]
		public ES3Type_Sprite()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1B0AD7C", Offset = "0x1B0AD7C", VA = "0x1B0AD7C", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004CE")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60004CF")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73C6B8", Offset = "0x73C6B8")]
	[Preserve]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1B0B170", Offset = "0x1B0B170", VA = "0x1B0B170")]
		public ES3Type_SpriteRenderer()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1B0B23C", Offset = "0x1B0B23C", VA = "0x1B0B23C", Slot = "14")]
		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004D3")]
		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class ES3Type_SpriteRendererArray : ES3ArrayType
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1B0BB74", Offset = "0x1B0BB74", VA = "0x1B0BB74")]
		public ES3Type_SpriteRendererArray()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73C95C", Offset = "0x73C95C")]
	public class ES3Type_SubEmittersModule : ES3Type
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1B0BD6C", Offset = "0x1B0BD6C", VA = "0x1B0BD6C")]
		public ES3Type_SubEmittersModule()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1B0BE38", Offset = "0x1B0BE38", VA = "0x1B0BE38", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004D8")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73CA24", Offset = "0x73CA24")]
	[Preserve]
	public class ES3Type_Texture : ES3Type
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1B0C998", Offset = "0x1B0C998", VA = "0x1B0C998")]
		public ES3Type_Texture()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1B0CA64", Offset = "0x1B0CA64", VA = "0x1B0CA64", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004DD")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60004DE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E5")]
	public class ES3Type_TextureArray : ES3ArrayType
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1B0D35C", Offset = "0x1B0D35C", VA = "0x1B0D35C")]
		public ES3Type_TextureArray()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73CB24", Offset = "0x73CB24")]
	[Preserve]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1B0CC18", Offset = "0x1B0CC18", VA = "0x1B0CC18")]
		public ES3Type_Texture2D()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1B0CCF0", Offset = "0x1B0CCF0", VA = "0x1B0CCF0", Slot = "10")]
		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004E3")]
		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		[Token(Token = "0x60004E4")]
		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1B0D1C8", Offset = "0x1B0D1C8", VA = "0x1B0D1C8")]
		protected bool IsReadable(Texture2D instance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E7")]
	public class ES3Type_Texture2DArray : ES3ArrayType
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1B0D260", Offset = "0x1B0D260", VA = "0x1B0D260")]
		public ES3Type_Texture2DArray()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73CC24", Offset = "0x73CC24")]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1B0D458", Offset = "0x1B0D458", VA = "0x1B0D458")]
		public ES3Type_TextureSheetAnimationModule()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1B0D524", Offset = "0x1B0D524", VA = "0x1B0D524", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004EA")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73CE20", Offset = "0x73CE20")]
	public class ES3Type_TrailModule : ES3Type
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1B0DB70", Offset = "0x1B0DB70", VA = "0x1B0DB70")]
		public ES3Type_TrailModule()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1B0DC3C", Offset = "0x1B0DC3C", VA = "0x1B0DC3C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004EF")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73D038", Offset = "0x73D038")]
	public class ES3Type_TriggerModule : ES3Type
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1B0E70C", Offset = "0x1B0E70C", VA = "0x1B0E70C")]
		public ES3Type_TriggerModule()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1B0E7D8", Offset = "0x1B0E7D8", VA = "0x1B0E7D8", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004F4")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73D154", Offset = "0x73D154")]
	[Preserve]
	public class ES3Type_Vector2 : ES3Type
	{
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1B0ED74", Offset = "0x1B0ED74", VA = "0x1B0ED74")]
		public ES3Type_Vector2()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1B0EE40", Offset = "0x1B0EE40", VA = "0x1B0EE40", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004F9")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000EC")]
	public class ES3Type_Vector2Array : ES3ArrayType
	{
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1B0EFB0", Offset = "0x1B0EFB0", VA = "0x1B0EFB0")]
		public ES3Type_Vector2Array()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73D200", Offset = "0x73D200")]
	public class ES3Type_Vector2Int : ES3Type
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1B0F0AC", Offset = "0x1B0F0AC", VA = "0x1B0F0AC")]
		public ES3Type_Vector2Int()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1B0F178", Offset = "0x1B0F178", VA = "0x1B0F178", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x60004FE")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000EE")]
	public class ES3Type_Vector2IntArray : ES3ArrayType
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1B0F2EC", Offset = "0x1B0F2EC", VA = "0x1B0F2EC")]
		public ES3Type_Vector2IntArray()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73D2AC", Offset = "0x73D2AC")]
	public class ES3Type_Vector3 : ES3Type
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1B0F3E8", Offset = "0x1B0F3E8", VA = "0x1B0F3E8")]
		public ES3Type_Vector3()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1B0F4B4", Offset = "0x1B0F4B4", VA = "0x1B0F4B4", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000503")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F0")]
	public class ES3Type_Vector3Array : ES3ArrayType
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1B0F67C", Offset = "0x1B0F67C", VA = "0x1B0F67C")]
		public ES3Type_Vector3Array()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73D374", Offset = "0x73D374")]
	public class ES3Type_Vector3Int : ES3Type
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1B0F778", Offset = "0x1B0F778", VA = "0x1B0F778")]
		public ES3Type_Vector3Int()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1B0F844", Offset = "0x1B0F844", VA = "0x1B0F844", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000508")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F2")]
	public class ES3Type_Vector3IntArray : ES3ArrayType
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1B0FA44", Offset = "0x1B0FA44", VA = "0x1B0FA44")]
		public ES3Type_Vector3IntArray()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73D43C", Offset = "0x73D43C")]
	public class ES3Type_Vector4 : ES3Type
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1B0FB40", Offset = "0x1B0FB40", VA = "0x1B0FB40")]
		public ES3Type_Vector4()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1B0FC0C", Offset = "0x1B0FC0C", VA = "0x1B0FC0C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x600050D")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1B0FE24", Offset = "0x1B0FE24", VA = "0x1B0FE24")]
		public static bool Equals(Vector4 a, Vector4 b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F4")]
	public class ES3Type_Vector4Array : ES3ArrayType
	{
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1B0FEC4", Offset = "0x1B0FEC4", VA = "0x1B0FEC4")]
		public ES3Type_Vector4Array()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[Preserve]
	[AttributeAttribute(Name = "ES3PropertiesAttribute", RVA = "0x73D520", Offset = "0x73D520")]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ES3Type Instance;

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1B0FFC0", Offset = "0x1B0FFC0", VA = "0x1B0FFC0")]
		public ES3Type_VelocityOverLifetimeModule()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1B1008C", Offset = "0x1B1008C", VA = "0x1B1008C", Slot = "4")]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Token(Token = "0x6000513")]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
namespace ES3Internal
{
	[Token(Token = "0x20000F6")]
	internal static class ES3Debug
	{
		[Token(Token = "0x40001E6")]
		private const string disableInfoMsg = "\n<i>To disable these messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Info'</i>";

		[Token(Token = "0x40001E7")]
		private const string disableWarningMsg = "\n<i>To disable warnings from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Warnings'</i>";

		[Token(Token = "0x40001E8")]
		private const string disableErrorMsg = "\n<i>To disable these error messages from Easy Save, go to Window > Easy Save 3 > Settings, and uncheck 'Log Errors'</i>";

		[Token(Token = "0x40001E9")]
		private const char indentChar = '-';

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xD7208C", Offset = "0xD7208C", VA = "0xD7208C")]
		public static void Log(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xD6C6CC", Offset = "0xD6C6CC", VA = "0xD6C6CC")]
		public static void LogWarning(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xD6E1F4", Offset = "0xD6E1F4", VA = "0xD6E1F4")]
		public static void LogError(string msg, [Optional] UnityEngine.Object context, int indent = 0)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xD72278", Offset = "0xD72278", VA = "0xD72278")]
		private static string Indent(int size)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F7")]
	public static class ES3Hash
	{
		[Token(Token = "0x600051A")]
		[Address(RVA = "0xD74660", Offset = "0xD74660", VA = "0xD74660")]
		public static string SHA1Hash(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F8")]
	public abstract class EncryptionAlgorithm
	{
		[Token(Token = "0x600051B")]
		public abstract byte[] Encrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x600051C")]
		public abstract byte[] Decrypt(byte[] bytes, string password, int bufferSize);

		[Token(Token = "0x600051D")]
		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x600051E")]
		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1467A5C", Offset = "0x1467A5C", VA = "0x1467A5C")]
		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1467B40", Offset = "0x1467B40", VA = "0x1467B40")]
		protected EncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		[Token(Token = "0x40001EA")]
		private const int ivSize = 16;

		[Token(Token = "0x40001EB")]
		private const int keySize = 16;

		[Token(Token = "0x40001EC")]
		private const int pwIterations = 100;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xEA439C", Offset = "0xEA439C", VA = "0xEA439C", Slot = "4")]
		public override byte[] Encrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xEA460C", Offset = "0xEA460C", VA = "0xEA460C", Slot = "5")]
		public override byte[] Decrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xEA487C", Offset = "0xEA487C", VA = "0xEA487C", Slot = "6")]
		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xEA4CD0", Offset = "0xEA4CD0", VA = "0xEA4CD0", Slot = "7")]
		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xEA510C", Offset = "0xEA510C", VA = "0xEA510C")]
		public AESEncryptionAlgorithm()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class UnbufferedCryptoStream : MemoryStream
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Stream stream;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly bool isReadStream;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string password;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int bufferSize;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private EncryptionAlgorithm alg;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool disposed;

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x148538C", Offset = "0x148538C", VA = "0x148538C")]
		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1485458", Offset = "0x1485458", VA = "0x1485458", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public struct ES3Data
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ES3Type type;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] bytes;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xD71F7C", Offset = "0xD71F7C", VA = "0xD71F7C")]
		public ES3Data(Type type, byte[] bytes)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xD72058", Offset = "0xD72058", VA = "0xD72058")]
		public ES3Data(ES3Type type, byte[] bytes)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public static class ES3IO
	{
		[Token(Token = "0x20000FD")]
		public enum ES3FileMode
		{
			[Token(Token = "0x40001F9")]
			Read,
			[Token(Token = "0x40001FA")]
			Write,
			[Token(Token = "0x40001FB")]
			Append
		}

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly string persistentDataPath;

		[Token(Token = "0x40001F6")]
		internal const string backupFileSuffix = ".bac";

		[Token(Token = "0x40001F7")]
		internal const string temporaryFileSuffix = ".tmp";

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xD6A100", Offset = "0xD6A100", VA = "0xD6A100")]
		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xD6385C", Offset = "0xD6385C", VA = "0xD6385C")]
		public static string GetExtension(string path)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xD6637C", Offset = "0xD6637C", VA = "0xD6637C")]
		public static void DeleteFile(string filePath)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xD669F8", Offset = "0xD669F8", VA = "0xD669F8")]
		public static bool FileExists(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xD67378", Offset = "0xD67378", VA = "0xD67378")]
		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xD66A00", Offset = "0xD66A00", VA = "0xD66A00")]
		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xD67EF0", Offset = "0xD67EF0", VA = "0xD67EF0")]
		public static void MoveDirectory(string sourcePath, string destPath)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xD678C0", Offset = "0xD678C0", VA = "0xD678C0")]
		public static void CreateDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xD67E64", Offset = "0xD67E64", VA = "0xD67E64")]
		public static bool DirectoryExists(string directoryPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xD74510", Offset = "0xD74510", VA = "0xD74510")]
		public static string GetDirectoryPath(string path, char seperator = '/')
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xD7515C", Offset = "0xD7515C", VA = "0xD7515C")]
		public static bool UsesForwardSlash(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xD679EC", Offset = "0xD679EC", VA = "0xD679EC")]
		public static string CombinePathAndFilename(string directoryPath, string fileOrDirectoryName)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xD6993C", Offset = "0xD6993C", VA = "0xD6993C")]
		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xD67E6C", Offset = "0xD67E6C", VA = "0xD67E6C")]
		public static void DeleteDirectory(string directoryPath)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xD696E0", Offset = "0xD696E0", VA = "0xD696E0")]
		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xD751B4", Offset = "0xD751B4", VA = "0xD751B4")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xD751BC", Offset = "0xD751BC", VA = "0xD751BC")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xD627C8", Offset = "0xD627C8", VA = "0xD627C8")]
		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class ES3Prefab : MonoBehaviour
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long prefabId;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ES3RefIdDictionary localRefs;

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xD7A070", Offset = "0xD7A070", VA = "0xD7A070")]
		public void Awake()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xD7A254", Offset = "0xD7A254", VA = "0xD7A254")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xD7A2D0", Offset = "0xD7A2D0", VA = "0xD7A2D0")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xD7A408", Offset = "0xD7A408", VA = "0xD7A408")]
		public Dictionary<string, string> GetReferences()
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xD7A670", Offset = "0xD7A670", VA = "0xD7A670")]
		public void ApplyReferences(Dictionary<long, long> localToGlobal)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xD7A3B0", Offset = "0xD7A3B0", VA = "0xD7A3B0")]
		public static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xD7AC44", Offset = "0xD7AC44", VA = "0xD7AC44")]
		public ES3Prefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FF")]
	[DisallowMultipleComponent]
	public abstract class ES3ReferenceMgrBase : MonoBehaviour
	{
		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D684", Offset = "0x73D684")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Object obj;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<long, UnityEngine.Object>, bool> <>9__0;

			[Token(Token = "0x6000560")]
			[Address(RVA = "0x101BE04", Offset = "0x101BE04", VA = "0x101BE04")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0x101BE0C", Offset = "0x101BE0C", VA = "0x101BE0C")]
			internal bool <Remove>b__0(KeyValuePair<long, UnityEngine.Object> kvp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D694", Offset = "0x73D694")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long referenceID;

			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<KeyValuePair<UnityEngine.Object, long>, bool> <>9__0;

			[Token(Token = "0x6000562")]
			[Address(RVA = "0x101BE90", Offset = "0x101BE90", VA = "0x101BE90")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0x101BE98", Offset = "0x101BE98", VA = "0x101BE98")]
			internal bool <Remove>b__0(KeyValuePair<UnityEngine.Object, long> kvp)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D6A4", Offset = "0x73D6A4")]
		private sealed class <>c
		{
			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<long, UnityEngine.Object>, bool> <>9__32_0;

			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<long, UnityEngine.Object>, long> <>9__32_1;

			[Token(Token = "0x6000565")]
			[Address(RVA = "0x101BCF8", Offset = "0x101BCF8", VA = "0x101BCF8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000566")]
			[Address(RVA = "0x101BD00", Offset = "0x101BD00", VA = "0x101BD00")]
			internal bool <RemoveNullOrInvalidValues>b__32_0(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return default(bool);
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0x101BDC4", Offset = "0x101BDC4", VA = "0x101BDC4")]
			internal long <RemoveNullOrInvalidValues>b__32_1(KeyValuePair<long, UnityEngine.Object> pair)
			{
				return default(long);
			}
		}

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _lock;

		[Token(Token = "0x40001FF")]
		public const string referencePropertyName = "_ES3Ref";

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ES3ReferenceMgrBase _current;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static HashSet<ES3ReferenceMgrBase> mgrs;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.Random rng;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool openPrefabs;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ES3Prefab> prefabs;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public ES3IdRefDictionary idRef;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ES3RefIdDictionary _refId;

		[Token(Token = "0x1700002C")]
		public static ES3ReferenceMgrBase Current
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xD71A44", Offset = "0xD71A44", VA = "0xD71A44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public bool IsInitialised
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0xD7C5D8", Offset = "0xD7C5D8", VA = "0xD7C5D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002E")]
		public ES3RefIdDictionary refId
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0xD7C638", Offset = "0xD7C638", VA = "0xD7C638")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000548")]
			[Address(RVA = "0xD7C82C", Offset = "0xD7C82C", VA = "0xD7C82C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public ES3GlobalReferences GlobalReferences
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0xD7C834", Offset = "0xD7C834", VA = "0xD7C834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xD7C3A0", Offset = "0xD7C3A0", VA = "0xD7C3A0")]
		public static ES3ReferenceMgrBase GetManagerFromScene(Scene scene)
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xD7C83C", Offset = "0xD7C83C", VA = "0xD7C83C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xD7CBB8", Offset = "0xD7CBB8", VA = "0xD7CBB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xD7CA7C", Offset = "0xD7CA7C", VA = "0xD7CA7C")]
		public void Merge(ES3ReferenceMgrBase otherMgr)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xD7CCE0", Offset = "0xD7CCE0", VA = "0xD7CCE0")]
		public long Get(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xD7CF2C", Offset = "0xD7CF2C", VA = "0xD7CF2C")]
		internal UnityEngine.Object Get(long id, Type type, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xD7D4C8", Offset = "0xD7D4C8", VA = "0xD7D4C8")]
		public UnityEngine.Object Get(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xD7D4D4", Offset = "0xD7D4D4", VA = "0xD7D4D4")]
		public ES3Prefab GetPrefab(long id, bool suppressWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xD7D8D0", Offset = "0xD7D8D0", VA = "0xD7D8D0")]
		public long GetPrefab(ES3Prefab prefabToFind, bool suppressWarnings = false)
		{
			return default(long);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xD71C04", Offset = "0xD71C04", VA = "0xD71C04")]
		public long Add(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xD7A8A8", Offset = "0xD7A8A8", VA = "0xD7A8A8")]
		public long Add(UnityEngine.Object obj, long id)
		{
			return default(long);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xD7DCDC", Offset = "0xD7DCDC", VA = "0xD7DCDC")]
		public bool AddPrefab(ES3Prefab prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xD7DD7C", Offset = "0xD7DD7C", VA = "0xD7DD7C")]
		public void Remove(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xD7E298", Offset = "0xD7E298", VA = "0xD7E298")]
		public void Remove(long referenceID)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xD7E7C0", Offset = "0xD7E7C0", VA = "0xD7E7C0")]
		public void RemoveNullOrInvalidValues()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xD7EB3C", Offset = "0xD7EB3C", VA = "0xD7EB3C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xD7EC68", Offset = "0xD7EC68", VA = "0xD7EC68")]
		public bool Contains(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xD7ECD0", Offset = "0xD7ECD0", VA = "0xD7ECD0")]
		public bool Contains(long referenceID)
		{
			return default(bool);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xD7ED34", Offset = "0xD7ED34", VA = "0xD7ED34")]
		public void ChangeId(long oldId, long newId)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xD7AA94", Offset = "0xD7AA94", VA = "0xD7AA94")]
		internal static long GetNewRefID()
		{
			return default(long);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xD7A3A8", Offset = "0xD7A3A8", VA = "0xD7A3A8")]
		internal static bool CanBeSaved(UnityEngine.Object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xD7C2B0", Offset = "0xD7C2B0", VA = "0xD7C2B0")]
		protected ES3ReferenceMgrBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000103")]
	public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
	{
		[Token(Token = "0x6000568")]
		[Address(RVA = "0xD75220", Offset = "0xD75220", VA = "0xD75220", Slot = "44")]
		protected override bool KeysAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xD7522C", Offset = "0xD7522C", VA = "0xD7522C", Slot = "45")]
		protected override bool ValuesAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xD752A0", Offset = "0xD752A0", VA = "0xD752A0")]
		public ES3IdRefDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73D6B4", Offset = "0x73D6B4")]
	public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
	{
		[Token(Token = "0x600056B")]
		[Address(RVA = "0xD7C1D0", Offset = "0xD7C1D0", VA = "0xD7C1D0", Slot = "44")]
		protected override bool KeysAreEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xD7C244", Offset = "0xD7C244", VA = "0xD7C244", Slot = "45")]
		protected override bool ValuesAreEqual(long a, long b)
		{
			return default(bool);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xD7ACB8", Offset = "0xD7ACB8", VA = "0xD7ACB8")]
		public ES3RefIdDictionary()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public static class ES3Reflection
	{
		[Token(Token = "0x2000106")]
		public struct ES3ReflectedMember
		{
			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private FieldInfo fieldInfo;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private PropertyInfo propertyInfo;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isProperty;

			[Token(Token = "0x17000031")]
			public bool IsNull
			{
				[Token(Token = "0x6000598")]
				[Address(RVA = "0x101C128", Offset = "0x101C128", VA = "0x101C128")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public string Name
			{
				[Token(Token = "0x6000599")]
				[Address(RVA = "0x101C174", Offset = "0x101C174", VA = "0x101C174")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000033")]
			public Type MemberType
			{
				[Token(Token = "0x600059A")]
				[Address(RVA = "0x101C1A8", Offset = "0x101C1A8", VA = "0x101C1A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000034")]
			public bool IsPublic
			{
				[Token(Token = "0x600059B")]
				[Address(RVA = "0x101C1F4", Offset = "0x101C1F4", VA = "0x101C1F4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000035")]
			public bool IsProtected
			{
				[Token(Token = "0x600059C")]
				[Address(RVA = "0x101C294", Offset = "0x101C294", VA = "0x101C294")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000036")]
			public bool IsStatic
			{
				[Token(Token = "0x600059D")]
				[Address(RVA = "0x101C2E8", Offset = "0x101C2E8", VA = "0x101C2E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x101C33C", Offset = "0x101C33C", VA = "0x101C33C")]
			public ES3ReflectedMember(object fieldPropertyInfo)
			{
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x101C51C", Offset = "0x101C51C", VA = "0x101C51C")]
			public void SetValue(object obj, object value)
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x101C564", Offset = "0x101C564", VA = "0x101C564")]
			public object GetValue(object obj)
			{
				return null;
			}
		}

		[Token(Token = "0x2000107")]
		public class ES3ReflectedMethod
		{
			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MethodInfo method;

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x101C5B4", Offset = "0x101C5B4", VA = "0x101C5B4")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x101C638", Offset = "0x101C638", VA = "0x101C638")]
			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes, BindingFlags bindingAttr)
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x101C6CC", Offset = "0x101C6CC", VA = "0x101C6CC")]
			public object Invoke(object obj, [Optional] object[] parameters)
			{
				return null;
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D6C8", Offset = "0x73D6C8")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type derivedType;

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x101C048", Offset = "0x101C048", VA = "0x101C048")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x101C050", Offset = "0x101C050", VA = "0x101C050")]
			internal bool <GetDerivedTypes>b__2(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D6D8", Offset = "0x73D6D8")]
		private sealed class <>c
		{
			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__27_0;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Assembly, Type, <>f__AnonymousType0<Assembly, Type>> <>9__27_1;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<<>f__AnonymousType0<Assembly, Type>, Type> <>9__27_3;

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x101BF50", Offset = "0x101BF50", VA = "0x101BF50")]
			public <>c()
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x101BF58", Offset = "0x101BF58", VA = "0x101BF58")]
			internal IEnumerable<Type> <GetDerivedTypes>b__27_0(Assembly assembly)
			{
				return null;
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x101BF7C", Offset = "0x101BF7C", VA = "0x101BF7C")]
			internal <>f__AnonymousType0<Assembly, Type> <GetDerivedTypes>b__27_1(Assembly assembly, Type type)
			{
				return null;
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x101C000", Offset = "0x101C000", VA = "0x101C000")]
			internal Type <GetDerivedTypes>b__27_3(<>f__AnonymousType0<Assembly, Type> <>h__TransparentIdentifier0)
			{
				return null;
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D6E8", Offset = "0x73D6E8")]
		private sealed class <>c__DisplayClass46_0
		{
			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string methodName;

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x101C0E0", Offset = "0x101C0E0", VA = "0x101C0E0")]
			public <>c__DisplayClass46_0()
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x101C0E8", Offset = "0x101C0E8", VA = "0x101C0E8")]
			internal bool <GetMethods>b__0(MethodInfo t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400020E")]
		public const string memberFieldPrefix = "m_";

		[Token(Token = "0x400020F")]
		public const string componentTagFieldName = "tag";

		[Token(Token = "0x4000210")]
		public const string componentNameFieldName = "name";

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string[] excludedPropertyNames;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Type serializableAttributeType;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Type serializeFieldAttributeType;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Type obsoleteAttributeType;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Type nonSerializedAttributeType;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Type es3SerializableAttributeType;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Type es3NonSerializableAttributeType;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Type[] EmptyTypes;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Assembly[] _assemblies;

		[Token(Token = "0x17000030")]
		private static Assembly[] Assemblies
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x174EC1C", Offset = "0x174EC1C", VA = "0x174EC1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x174EEB0", Offset = "0x174EEB0", VA = "0x174EEB0")]
		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x174F088", Offset = "0x174F088", VA = "0x174F088")]
		public static List<FieldInfo> GetSerializableFields(Type type, [Optional] List<FieldInfo> serializableFields, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x174FA48", Offset = "0x174FA48", VA = "0x174FA48")]
		public static List<PropertyInfo> GetSerializableProperties(Type type, [Optional] List<PropertyInfo> serializableProperties, bool safe = true, [Optional] string[] memberNames, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x174F6E0", Offset = "0x174F6E0", VA = "0x174F6E0")]
		public static bool TypeIsSerializable(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1750228", Offset = "0x1750228", VA = "0x1750228")]
		public static object CreateInstance(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1750504", Offset = "0x1750504", VA = "0x1750504")]
		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x17506A8", Offset = "0x17506A8", VA = "0x17506A8")]
		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1750730", Offset = "0x1750730", VA = "0x1750730")]
		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1750738", Offset = "0x1750738", VA = "0x1750738")]
		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1750800", Offset = "0x1750800", VA = "0x1750800")]
		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, [Optional] string[] memberNames)
		{
			return null;
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1750B40", Offset = "0x1750B40", VA = "0x1750B40")]
		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1750D28", Offset = "0x1750D28", VA = "0x1750D28")]
		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		[Token(Token = "0x600057B")]
		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1750F18", Offset = "0x1750F18", VA = "0x1750F18")]
		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x174EB88", Offset = "0x174EB88", VA = "0x174EB88")]
		public static bool IsAssignableFrom(Type a, Type b)
		{
			return default(bool);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1751300", Offset = "0x1751300", VA = "0x1751300")]
		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x174F048", Offset = "0x174F048", VA = "0x174F048")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1751320", Offset = "0x1751320", VA = "0x1751320")]
		public static int GetArrayRank(Type type)
		{
			return default(int);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1751340", Offset = "0x1751340", VA = "0x1751340")]
		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1751360", Offset = "0x1751360", VA = "0x1751360")]
		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1750210", Offset = "0x1750210", VA = "0x1750210")]
		public static bool TypeIsArray(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x174F068", Offset = "0x174F068", VA = "0x174F068")]
		public static Type GetElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x17513E8", Offset = "0x17513E8", VA = "0x17513E8")]
		public static bool IsAbstract(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1751400", Offset = "0x1751400", VA = "0x1751400")]
		public static bool IsInterface(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x174F028", Offset = "0x174F028", VA = "0x174F028")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x17501F8", Offset = "0x17501F8", VA = "0x17501F8")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1751418", Offset = "0x1751418", VA = "0x1751418")]
		public static bool IsEnum(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1750420", Offset = "0x1750420", VA = "0x1750420")]
		public static bool HasParameterlessConstructor(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1751438", Offset = "0x1751438", VA = "0x1751438")]
		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x17514E4", Offset = "0x17514E4", VA = "0x17514E4")]
		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1750BCC", Offset = "0x1750BCC", VA = "0x1750BCC")]
		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1750DB4", Offset = "0x1750DB4", VA = "0x1750DB4")]
		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x17515D0", Offset = "0x17515D0", VA = "0x17515D0")]
		public static MethodInfo[] GetMethods(Type type, string methodName)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x17500E8", Offset = "0x17500E8", VA = "0x17500E8")]
		public static bool IsPrimitive(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x174F6D4", Offset = "0x174F6D4", VA = "0x174F6D4")]
		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x17500C8", Offset = "0x17500C8", VA = "0x17500C8")]
		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x17516F8", Offset = "0x17516F8", VA = "0x17516F8")]
		public static bool ImplementsInterface(Type type, Type interfaceType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x174FA28", Offset = "0x174FA28", VA = "0x174FA28")]
		public static Type BaseType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x17517A0", Offset = "0x17517A0", VA = "0x17517A0")]
		public static Type GetType(string typeString)
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1752244", Offset = "0x1752244", VA = "0x1752244")]
		public static string GetTypeString(Type type)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200010B")]
	public abstract class ES3SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D6F8", Offset = "0x73D6F8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TKey, TVal>, bool> <>9__6_0;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TKey, TVal>, TKey> <>9__6_1;

			[Token(Token = "0x60005B5")]
			public <>c()
			{
			}

			[Token(Token = "0x60005B6")]
			internal bool <RemoveNullValues>b__6_0(KeyValuePair<TKey, TVal> pair)
			{
				return default(bool);
			}

			[Token(Token = "0x60005B7")]
			internal TKey <RemoveNullValues>b__6_1(KeyValuePair<TKey, TVal> pair)
			{
				return (TKey)null;
			}
		}

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _Keys;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TVal> _Values;

		[Token(Token = "0x60005AD")]
		protected abstract bool KeysAreEqual(TKey a, TKey b);

		[Token(Token = "0x60005AE")]
		protected abstract bool ValuesAreEqual(TVal a, TVal b);

		[Token(Token = "0x60005AF")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60005B0")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60005B1")]
		public int RemoveNullValues()
		{
			return default(int);
		}

		[Token(Token = "0x60005B2")]
		public bool ChangeKey(TKey oldKey, TKey newKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B3")]
		protected ES3SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class ES3JSONReader : ES3Reader
	{
		[Token(Token = "0x4000229")]
		private const char endOfStreamChar = '\uffff';

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StreamReader baseReader;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xD752F4", Offset = "0xD752F4", VA = "0xD752F4")]
		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xD75558", Offset = "0xD75558", VA = "0xD75558", Slot = "21")]
		public override string ReadPropertyName()
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xD75AD0", Offset = "0xD75AD0", VA = "0xD75AD0", Slot = "22")]
		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xD75C74", Offset = "0xD75C74", VA = "0xD75C74", Slot = "23")]
		protected override void ReadKeySuffix()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xD75C84", Offset = "0xD75C84", VA = "0xD75C84", Slot = "27")]
		internal override bool StartReadObject()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xD75F88", Offset = "0xD75F88", VA = "0xD75F88", Slot = "28")]
		internal override void EndReadObject()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xD75FC8", Offset = "0xD75FC8", VA = "0xD75FC8", Slot = "29")]
		internal override bool StartReadDictionary()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xD75FD8", Offset = "0xD75FD8", VA = "0xD75FD8", Slot = "30")]
		internal override void EndReadDictionary()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xD75FDC", Offset = "0xD75FDC", VA = "0xD75FDC", Slot = "31")]
		internal override bool StartReadDictionaryKey()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xD76020", Offset = "0xD76020", VA = "0xD76020", Slot = "32")]
		internal override void EndReadDictionaryKey()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xD76028", Offset = "0xD76028", VA = "0xD76028", Slot = "33")]
		internal override void StartReadDictionaryValue()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xD7602C", Offset = "0xD7602C", VA = "0xD7602C", Slot = "34")]
		internal override bool EndReadDictionaryValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xD760F4", Offset = "0xD760F4", VA = "0xD760F4", Slot = "35")]
		internal override bool StartReadCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xD760FC", Offset = "0xD760FC", VA = "0xD760FC", Slot = "36")]
		internal override void EndReadCollection()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xD76100", Offset = "0xD76100", VA = "0xD76100", Slot = "37")]
		internal override bool StartReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xD76144", Offset = "0xD76144", VA = "0xD76144", Slot = "38")]
		internal override bool EndReadCollectionItem()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xD7620C", Offset = "0xD7620C", VA = "0xD7620C")]
		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xD76348", Offset = "0xD76348", VA = "0xD76348", Slot = "24")]
		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xD762E4", Offset = "0xD762E4", VA = "0xD762E4")]
		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return default(char);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xD757B8", Offset = "0xD757B8", VA = "0xD757B8")]
		private char ReadCharIgnoreWhitespace(bool ignoreTrailingWhitespace = true)
		{
			return default(char);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xD75CAC", Offset = "0xD75CAC", VA = "0xD75CAC")]
		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xD758C4", Offset = "0xD758C4", VA = "0xD758C4")]
		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xD768C4", Offset = "0xD768C4", VA = "0xD768C4")]
		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xD76AA8", Offset = "0xD76AA8", VA = "0xD76AA8")]
		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return default(char);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xD75724", Offset = "0xD75724", VA = "0xD75724")]
		private char PeekCharIgnoreWhitespace()
		{
			return default(char);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xD76CB0", Offset = "0xD76CB0", VA = "0xD76CB0")]
		private void SkipWhiteSpace()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xD754A4", Offset = "0xD754A4", VA = "0xD754A4")]
		private void SkipOpeningBraceOfFile()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xD7688C", Offset = "0xD7688C", VA = "0xD7688C")]
		private static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xD76808", Offset = "0xD76808", VA = "0xD76808")]
		private static bool IsOpeningBrace(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xD7681C", Offset = "0xD7681C", VA = "0xD7681C")]
		private static bool IsEndOfValue(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xD757A4", Offset = "0xD757A4", VA = "0xD757A4")]
		private static bool IsTerminator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xD75898", Offset = "0xD75898", VA = "0xD75898")]
		private static bool IsQuotationMark(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xD76D30", Offset = "0xD76D30", VA = "0xD76D30")]
		private static bool IsEndOfStream(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xD76D40", Offset = "0xD76D40", VA = "0xD76D40")]
		private string GetValueString()
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xD76E18", Offset = "0xD76E18", VA = "0xD76E18", Slot = "18")]
		internal override string Read_string()
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xD76FDC", Offset = "0xD76FDC", VA = "0xD76FDC", Slot = "20")]
		internal override long Read_ref()
		{
			return default(long);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xD77120", Offset = "0xD77120", VA = "0xD77120", Slot = "8")]
		internal override char Read_char()
		{
			return default(char);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xD771A0", Offset = "0xD771A0", VA = "0xD771A0", Slot = "6")]
		internal override float Read_float()
		{
			return default(float);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xD77220", Offset = "0xD77220", VA = "0xD77220", Slot = "5")]
		internal override int Read_int()
		{
			return default(int);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xD77238", Offset = "0xD77238", VA = "0xD77238", Slot = "7")]
		internal override bool Read_bool()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xD772AC", Offset = "0xD772AC", VA = "0xD772AC", Slot = "9")]
		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xD77360", Offset = "0xD77360", VA = "0xD77360", Slot = "10")]
		internal override double Read_double()
		{
			return default(double);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xD77414", Offset = "0xD77414", VA = "0xD77414", Slot = "11")]
		internal override long Read_long()
		{
			return default(long);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xD7742C", Offset = "0xD7742C", VA = "0xD7742C", Slot = "12")]
		internal override ulong Read_ulong()
		{
			return default(ulong);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xD77444", Offset = "0xD77444", VA = "0xD77444", Slot = "17")]
		internal override uint Read_uint()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xD7745C", Offset = "0xD7745C", VA = "0xD7745C", Slot = "13")]
		internal override byte Read_byte()
		{
			return default(byte);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xD77478", Offset = "0xD77478", VA = "0xD77478", Slot = "14")]
		internal override sbyte Read_sbyte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xD77494", Offset = "0xD77494", VA = "0xD77494", Slot = "15")]
		internal override short Read_short()
		{
			return default(short);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xD774B0", Offset = "0xD774B0", VA = "0xD774B0", Slot = "16")]
		internal override ushort Read_ushort()
		{
			return default(ushort);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xD774CC", Offset = "0xD774CC", VA = "0xD774CC", Slot = "19")]
		internal override byte[] Read_byteArray()
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xD7754C", Offset = "0xD7754C", VA = "0xD7754C", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class ES3GlobalReferences : ScriptableObject
	{
		[Token(Token = "0x17000037")]
		public static ES3GlobalReferences Instance
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xD7463C", Offset = "0xD7463C", VA = "0xD7463C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xD74644", Offset = "0xD74644", VA = "0xD74644")]
		public UnityEngine.Object Get(long id)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xD7464C", Offset = "0xD7464C", VA = "0xD7464C")]
		public long GetOrAdd(UnityEngine.Object obj)
		{
			return default(long);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xD74654", Offset = "0xD74654", VA = "0xD74654")]
		public void RemoveInvalidKeys()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xD74658", Offset = "0xD74658", VA = "0xD74658")]
		public ES3GlobalReferences()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class ES3DefaultSettings : MonoBehaviour
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ES3SerializableSettings settings;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoUpdateReferences;

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xD722E0", Offset = "0xD722E0", VA = "0xD722E0")]
		public ES3DefaultSettings()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public enum ES3FileMode
	{
		[Token(Token = "0x400022E")]
		Read,
		[Token(Token = "0x400022F")]
		Write,
		[Token(Token = "0x4000230")]
		Append
	}
	[Token(Token = "0x2000111")]
	public class ES3FileStream : FileStream
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool isDisposed;

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xD74304", Offset = "0xD74304", VA = "0xD74304")]
		public ES3FileStream(string path, ES3FileMode fileMode, int bufferSize, bool useAsync)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xD743D4", Offset = "0xD743D4", VA = "0xD743D4")]
		protected static string GetPath(string path, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xD744E0", Offset = "0xD744E0", VA = "0xD744E0")]
		protected static FileMode GetFileMode(ES3FileMode fileMode)
		{
			return default(FileMode);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xD74500", Offset = "0xD74500", VA = "0xD74500")]
		protected static FileAccess GetFileAccess(ES3FileMode fileMode)
		{
			return default(FileAccess);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xD7461C", Offset = "0xD7461C", VA = "0xD7461C", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000112")]
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string path;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool append;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isWriteStream;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isDisposed;

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xD79C28", Offset = "0xD79C28", VA = "0xD79C28")]
		public ES3PlayerPrefsStream(string path)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xD79D6C", Offset = "0xD79D6C", VA = "0xD79D6C")]
		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xD79C78", Offset = "0xD79C78", VA = "0xD79C78")]
		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xD79DC4", Offset = "0xD79DC4", VA = "0xD79DC4", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000113")]
	internal class ES3ResourcesStream : MemoryStream
	{
		[Token(Token = "0x17000038")]
		public bool Exists
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x17530AC", Offset = "0x17530AC", VA = "0x17530AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x17530D0", Offset = "0x17530D0", VA = "0x17530D0")]
		public ES3ResourcesStream(string path)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1753100", Offset = "0x1753100", VA = "0x1753100")]
		private static byte[] GetData(string path)
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1753200", Offset = "0x1753200", VA = "0x1753200", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000114")]
	public static class ES3Stream
	{
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1755014", Offset = "0x1755014", VA = "0x1755014")]
		public static Stream CreateStream(ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1757054", Offset = "0x1757054", VA = "0x1757054")]
		public static Stream CreateStream(Stream stream, ES3Settings settings, ES3FileMode fileMode)
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1757434", Offset = "0x1757434", VA = "0x1757434")]
		public static void CopyTo(Stream source, Stream destination)
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class ES3Member
	{
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isProperty;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ES3Reflection.ES3ReflectedMember reflectedMember;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useReflection;

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xD78F88", Offset = "0xD78F88", VA = "0xD78F88")]
		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xD78FE8", Offset = "0xD78FE8", VA = "0xD78FE8")]
		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
	[Token(Token = "0x2000116")]
	[Preserve]
	public static class ES3TypeMgr
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73E014", Offset = "0x73E014")]
		public static Dictionary<Type, ES3Type> types;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ES3Type lastAccessedType;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x174E92C", Offset = "0x174E92C", VA = "0x174E92C")]
		public static ES3Type GetOrCreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x175A460", Offset = "0x175A460", VA = "0x175A460")]
		public static ES3Type GetES3Type(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1757814", Offset = "0x1757814", VA = "0x1757814")]
		internal static void Add(Type type, ES3Type es3Type)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x17598E4", Offset = "0x17598E4", VA = "0x17598E4")]
		internal static ES3Type CreateES3Type(Type type, bool throwException = true)
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1759674", Offset = "0x1759674", VA = "0x1759674")]
		internal static void Init()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class ES3WebClass
	{
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D718", Offset = "0x73D718")]
		private sealed class <SendWebRequest>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ES3WebClass <>4__this;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UnityWebRequest webRequest;

			[Token(Token = "0x1700003C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000617")]
				[Address(RVA = "0x101C8D8", Offset = "0x101C8D8", VA = "0x101C8D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000619")]
				[Address(RVA = "0x101C920", Offset = "0x101C920", VA = "0x101C920", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x101C824", Offset = "0x101C824", VA = "0x101C824")]
			[DebuggerHidden]
			public <SendWebRequest>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x101C850", Offset = "0x101C850", VA = "0x101C850", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x101C854", Offset = "0x101C854", VA = "0x101C854", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x101C8E0", Offset = "0x101C8E0", VA = "0x101C8E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string url;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string apiKey;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<KeyValuePair<string, string>> formData;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected UnityWebRequest _webRequest;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isDone;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string error;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public long errorCode;

		[Token(Token = "0x17000039")]
		public float uploadProgress
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x1B13784", Offset = "0x1B13784", VA = "0x1B13784")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003A")]
		public float downloadProgress
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1B1379C", Offset = "0x1B1379C", VA = "0x1B1379C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		public bool isError
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1B137B4", Offset = "0x1B137B4", VA = "0x1B137B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1B137F4", Offset = "0x1B137F4", VA = "0x1B137F4")]
		public static bool IsNetworkError(UnityWebRequest www)
		{
			return default(bool);
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1B1381C", Offset = "0x1B1381C", VA = "0x1B1381C")]
		protected ES3WebClass(string url, string apiKey)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1B138D0", Offset = "0x1B138D0", VA = "0x1B138D0")]
		public void AddPOSTField(string fieldName, string value)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1B13974", Offset = "0x1B13974", VA = "0x1B13974")]
		protected string GetUser(string user, string password)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1B13A14", Offset = "0x1B13A14", VA = "0x1B13A14")]
		protected WWWForm CreateWWWForm()
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1B13B74", Offset = "0x1B13B74", VA = "0x1B13B74")]
		protected bool HandleError(UnityWebRequest webRequest, bool errorIfDataIsDownloaded)
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1B13D80", Offset = "0x1B13D80", VA = "0x1B13D80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x73EEE0", Offset = "0x73EEE0")]
		protected IEnumerator SendWebRequest(UnityWebRequest webRequest)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1B13E14", Offset = "0x1B13E14", VA = "0x1B13E14", Slot = "4")]
		protected virtual void Reset()
		{
		}
	}
	[Token(Token = "0x2000119")]
	internal enum ES3SpecialByte : byte
	{
		[Token(Token = "0x400024A")]
		Null = 0,
		[Token(Token = "0x400024B")]
		Bool = 1,
		[Token(Token = "0x400024C")]
		Byte = 2,
		[Token(Token = "0x400024D")]
		Sbyte = 3,
		[Token(Token = "0x400024E")]
		Char = 4,
		[Token(Token = "0x400024F")]
		Decimal = 5,
		[Token(Token = "0x4000250")]
		Double = 6,
		[Token(Token = "0x4000251")]
		Float = 7,
		[Token(Token = "0x4000252")]
		Int = 8,
		[Token(Token = "0x4000253")]
		Uint = 9,
		[Token(Token = "0x4000254")]
		Long = 10,
		[Token(Token = "0x4000255")]
		Ulong = 11,
		[Token(Token = "0x4000256")]
		Short = 12,
		[Token(Token = "0x4000257")]
		Ushort = 13,
		[Token(Token = "0x4000258")]
		String = 14,
		[Token(Token = "0x4000259")]
		ByteArray = 15,
		[Token(Token = "0x400025A")]
		Collection = 128,
		[Token(Token = "0x400025B")]
		Dictionary = 129,
		[Token(Token = "0x400025C")]
		CollectionItem = 130,
		[Token(Token = "0x400025D")]
		Object = 254,
		[Token(Token = "0x400025E")]
		Terminator = byte.MaxValue
	}
	[Token(Token = "0x200011A")]
	internal static class ES3Binary
	{
		[Token(Token = "0x400025F")]
		internal const string ObjectTerminator = ".";

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Dictionary<ES3SpecialByte, Type> IdToType;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly Dictionary<Type, ES3SpecialByte> TypeToId;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xD6D84C", Offset = "0xD6D84C", VA = "0xD6D84C")]
		internal static ES3SpecialByte TypeToByte(Type type)
		{
			return default(ES3SpecialByte);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xD6D8FC", Offset = "0xD6D8FC", VA = "0xD6D8FC")]
		internal static Type ByteToType(ES3SpecialByte b)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xD6D95C", Offset = "0xD6D95C", VA = "0xD6D95C")]
		internal static Type ByteToType(byte b)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xD6DA58", Offset = "0xD6DA58", VA = "0xD6DA58")]
		internal static bool IsPrimitive(ES3SpecialByte b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200011B")]
	internal class ES3CacheWriter : ES3Writer
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ES3File es3File;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xD6E104", Offset = "0xD6E104", VA = "0xD6E104")]
		internal ES3CacheWriter(ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000620")]
		public override void Write<T>(string key, object value)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xD6E1A8", Offset = "0xD6E1A8", VA = "0xD6E1A8", Slot = "39")]
		internal override void Write(string key, Type type, byte[] value)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xD6E3D8", Offset = "0xD6E3D8", VA = "0xD6E3D8", Slot = "41")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73EF90", Offset = "0x73EF90")]
		public override void Write(Type type, string key, object value)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xD6E444", Offset = "0xD6E444", VA = "0xD6E444", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xD6E448", Offset = "0xD6E448", VA = "0xD6E448", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xD6E44C", Offset = "0xD6E44C", VA = "0xD6E44C", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xD6E450", Offset = "0xD6E450", VA = "0xD6E450", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xD6E454", Offset = "0xD6E454", VA = "0xD6E454", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xD6E458", Offset = "0xD6E458", VA = "0xD6E458", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xD6E45C", Offset = "0xD6E45C", VA = "0xD6E45C", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xD6E460", Offset = "0xD6E460", VA = "0xD6E460", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xD6E464", Offset = "0xD6E464", VA = "0xD6E464", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xD6E468", Offset = "0xD6E468", VA = "0xD6E468", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xD6E46C", Offset = "0xD6E46C", VA = "0xD6E46C", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xD6E470", Offset = "0xD6E470", VA = "0xD6E470", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xD6E474", Offset = "0xD6E474", VA = "0xD6E474", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xD6E478", Offset = "0xD6E478", VA = "0xD6E478", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xD6E47C", Offset = "0xD6E47C", VA = "0xD6E47C", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xD6E480", Offset = "0xD6E480", VA = "0xD6E480", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xD6E484", Offset = "0xD6E484", VA = "0xD6E484")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xD6E48C", Offset = "0xD6E48C", VA = "0xD6E48C")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xD6E490", Offset = "0xD6E490", VA = "0xD6E490", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xD6E494", Offset = "0xD6E494", VA = "0xD6E494", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xD6E498", Offset = "0xD6E498", VA = "0xD6E498", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xD6E49C", Offset = "0xD6E49C", VA = "0xD6E49C", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xD6E4A4", Offset = "0xD6E4A4", VA = "0xD6E4A4", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xD6E4A8", Offset = "0xD6E4A8", VA = "0xD6E4A8", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xD6E4AC", Offset = "0xD6E4AC", VA = "0xD6E4AC", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xD6E4B0", Offset = "0xD6E4B0", VA = "0xD6E4B0", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xD6E4B4", Offset = "0xD6E4B4", VA = "0xD6E4B4", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xD6E4B8", Offset = "0xD6E4B8", VA = "0xD6E4B8", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xD6E4BC", Offset = "0xD6E4BC", VA = "0xD6E4BC", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xD6E4C0", Offset = "0xD6E4C0", VA = "0xD6E4C0", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xD6E4C4", Offset = "0xD6E4C4", VA = "0xD6E4C4", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xD6E4C8", Offset = "0xD6E4C8", VA = "0xD6E4C8", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xD6E4CC", Offset = "0xD6E4CC", VA = "0xD6E4CC", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xD6E4D0", Offset = "0xD6E4D0", VA = "0xD6E4D0", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xD6E4D4", Offset = "0xD6E4D4", VA = "0xD6E4D4", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xD6E4D8", Offset = "0xD6E4D8", VA = "0xD6E4D8", Slot = "22")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200011C")]
	internal class ES3JSONWriter : ES3Writer
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal StreamWriter baseWriter;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isFirstProperty;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xD77568", Offset = "0xD77568", VA = "0xD77568")]
		public ES3JSONWriter(Stream stream, ES3Settings settings)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xD77574", Offset = "0xD77574", VA = "0xD77574")]
		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xD7762C", Offset = "0xD7762C", VA = "0xD7762C", Slot = "24")]
		internal override void WritePrimitive(int value)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xD77650", Offset = "0xD77650", VA = "0xD77650", Slot = "25")]
		internal override void WritePrimitive(float value)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xD7770C", Offset = "0xD7770C", VA = "0xD7770C", Slot = "26")]
		internal override void WritePrimitive(bool value)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xD77794", Offset = "0xD77794", VA = "0xD77794", Slot = "27")]
		internal override void WritePrimitive(decimal value)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xD77838", Offset = "0xD77838", VA = "0xD77838", Slot = "28")]
		internal override void WritePrimitive(double value)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xD778F4", Offset = "0xD778F4", VA = "0xD778F4", Slot = "29")]
		internal override void WritePrimitive(long value)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xD77918", Offset = "0xD77918", VA = "0xD77918", Slot = "30")]
		internal override void WritePrimitive(ulong value)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xD7793C", Offset = "0xD7793C", VA = "0xD7793C", Slot = "31")]
		internal override void WritePrimitive(uint value)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xD77960", Offset = "0xD77960", VA = "0xD77960", Slot = "32")]
		internal override void WritePrimitive(byte value)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xD779F4", Offset = "0xD779F4", VA = "0xD779F4", Slot = "33")]
		internal override void WritePrimitive(sbyte value)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xD77A88", Offset = "0xD77A88", VA = "0xD77A88", Slot = "34")]
		internal override void WritePrimitive(short value)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xD77B1C", Offset = "0xD77B1C", VA = "0xD77B1C", Slot = "35")]
		internal override void WritePrimitive(ushort value)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xD77BB0", Offset = "0xD77BB0", VA = "0xD77BB0", Slot = "36")]
		internal override void WritePrimitive(char value)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xD77BF4", Offset = "0xD77BF4", VA = "0xD77BF4", Slot = "38")]
		internal override void WritePrimitive(byte[] value)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xD77C7C", Offset = "0xD77C7C", VA = "0xD77C7C", Slot = "37")]
		internal override void WritePrimitive(string value)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xD77EAC", Offset = "0xD77EAC", VA = "0xD77EAC", Slot = "5")]
		internal override void WriteNull()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xD77F0C", Offset = "0xD77F0C", VA = "0xD77F0C")]
		private static bool CharacterRequiresEscaping(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xD77F40", Offset = "0xD77F40", VA = "0xD77F40")]
		private void WriteCommaIfRequired()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xD7801C", Offset = "0xD7801C", VA = "0xD7801C", Slot = "23")]
		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xD780B8", Offset = "0xD780B8", VA = "0xD780B8", Slot = "6")]
		internal override void StartWriteFile()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xD78100", Offset = "0xD78100", VA = "0xD78100", Slot = "7")]
		internal override void EndWriteFile()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xD78158", Offset = "0xD78158", VA = "0xD78158", Slot = "10")]
		internal override void StartWriteProperty(string name)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xD78218", Offset = "0xD78218", VA = "0xD78218", Slot = "11")]
		internal override void EndWriteProperty(string name)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xD78220", Offset = "0xD78220", VA = "0xD78220", Slot = "8")]
		internal override void StartWriteObject(string name)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xD78264", Offset = "0xD78264", VA = "0xD78264", Slot = "9")]
		internal override void EndWriteObject(string name)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xD782AC", Offset = "0xD782AC", VA = "0xD782AC", Slot = "12")]
		internal override void StartWriteCollection()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xD782F0", Offset = "0xD782F0", VA = "0xD782F0", Slot = "13")]
		internal override void EndWriteCollection()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xD78334", Offset = "0xD78334", VA = "0xD78334", Slot = "14")]
		internal override void StartWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xD78360", Offset = "0xD78360", VA = "0xD78360", Slot = "15")]
		internal override void EndWriteCollectionItem(int index)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xD78364", Offset = "0xD78364", VA = "0xD78364", Slot = "16")]
		internal override void StartWriteDictionary()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xD78374", Offset = "0xD78374", VA = "0xD78374", Slot = "17")]
		internal override void EndWriteDictionary()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xD78384", Offset = "0xD78384", VA = "0xD78384", Slot = "18")]
		internal override void StartWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xD783B0", Offset = "0xD783B0", VA = "0xD783B0", Slot = "19")]
		internal override void EndWriteDictionaryKey(int index)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xD783D4", Offset = "0xD783D4", VA = "0xD783D4", Slot = "20")]
		internal override void StartWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xD783D8", Offset = "0xD783D8", VA = "0xD783D8", Slot = "21")]
		internal override void EndWriteDictionaryValue(int index)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xD783DC", Offset = "0xD783DC", VA = "0xD783DC", Slot = "22")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xD77F8C", Offset = "0xD77F8C", VA = "0xD77F8C")]
		public void WriteNewlineAndTabs()
		{
		}
	}
}
namespace DragonBones
{
	[Token(Token = "0x200011D")]
	public class Animation : BaseObject
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float timeScale;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _lockUpdate;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _animationDirty;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _inheritTimeScale;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<string> _animationNames;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<AnimationState> _animationStates;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, AnimationData> _animations;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Armature _armature;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AnimationConfig _animationConfig;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AnimationState _lastAnimationState;

		[Token(Token = "0x1700003E")]
		public bool isPlaying
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0xEA9BAC", Offset = "0xEA9BAC", VA = "0xEA9BAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool isCompleted
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0xEA9CFC", Offset = "0xEA9CFC", VA = "0xEA9CFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public string lastAnimationName
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0xEA9E5C", Offset = "0xEA9E5C", VA = "0xEA9E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public List<string> animationNames
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0xEA9EB4", Offset = "0xEA9EB4", VA = "0xEA9EB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public Dictionary<string, AnimationData> animations
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0xEA9EBC", Offset = "0xEA9EBC", VA = "0xEA9EBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000685")]
			[Address(RVA = "0xEA9EC4", Offset = "0xEA9EC4", VA = "0xEA9EC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public AnimationConfig animationConfig
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0xEAA0DC", Offset = "0xEAA0DC", VA = "0xEAA0DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public AnimationState lastAnimationState
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0xEAA114", Offset = "0xEAA114", VA = "0xEAA114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xEA62D4", Offset = "0xEA62D4", VA = "0xEA62D4", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xEA64A4", Offset = "0xEA64A4", VA = "0xEA64A4")]
		private void _FadeOut(AnimationConfig animationConfig)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xEA6DB8", Offset = "0xEA6DB8", VA = "0xEA6DB8")]
		internal void Init(Armature armature)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xEA6E70", Offset = "0xEA6E70", VA = "0xEA6E70")]
		internal void AdvanceTime(float passedTime)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xEA7DA8", Offset = "0xEA7DA8", VA = "0xEA7DA8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xEA7F14", Offset = "0xEA7F14", VA = "0xEA7F14")]
		public void Stop([Optional] string animationName)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xEA8128", Offset = "0xEA8128", VA = "0xEA8128")]
		public AnimationState PlayConfig(AnimationConfig animationConfig)
		{
			return null;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xEA9678", Offset = "0xEA9678", VA = "0xEA9678")]
		public AnimationState Play([Optional] string animationName, int playTimes = -1)
		{
			return null;
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xEA8EC0", Offset = "0xEA8EC0", VA = "0xEA8EC0")]
		public AnimationState FadeIn(string animationName, float fadeInTime = -1f, int playTimes = -1, int layer = 0, [Optional] string group, AnimationFadeOutMode fadeOutMode = AnimationFadeOutMode.SameLayerAndGroup)
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xEA9844", Offset = "0xEA9844", VA = "0xEA9844")]
		public AnimationState GotoAndPlayByTime(string animationName, float time = 0f, int playTimes = -1)
		{
			return null;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xEA98E4", Offset = "0xEA98E4", VA = "0xEA98E4")]
		public AnimationState GotoAndPlayByFrame(string animationName, uint frame = 0u, int playTimes = -1)
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xEA9A10", Offset = "0xEA9A10", VA = "0xEA9A10")]
		public AnimationState GotoAndPlayByProgress(string animationName, float progress = 0f, int playTimes = -1)
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xEA9B2C", Offset = "0xEA9B2C", VA = "0xEA9B2C")]
		public AnimationState GotoAndStopByTime(string animationName, float time = 0f)
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xEA9B54", Offset = "0xEA9B54", VA = "0xEA9B54")]
		public AnimationState GotoAndStopByFrame(string animationName, uint frame = 0u)
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xEA9B7C", Offset = "0xEA9B7C", VA = "0xEA9B7C")]
		public AnimationState GotoAndStopByProgress(string animationName, float progress = 0f)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xEA805C", Offset = "0xEA805C", VA = "0xEA805C")]
		public AnimationState GetState(string animationName)
		{
			return null;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xEA8E5C", Offset = "0xEA8E5C", VA = "0xEA8E5C")]
		public bool HasAnimation(string animationName)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xEA9BA4", Offset = "0xEA9BA4", VA = "0xEA9BA4")]
		public List<AnimationState> GetStates()
		{
			return null;
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xEAA11C", Offset = "0xEAA11C", VA = "0xEAA11C")]
		public Animation()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class AnimationState : BaseObject
	{
		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool actionEnabled;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool additiveBlending;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool displayControl;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public bool resetToPose;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int playTimes;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int layer;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeScale;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float autoFadeOutTime;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float fadeTotalTime;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string group;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _timelineDirty;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal int _playheadState;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal int _fadeState;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal int _subFadeState;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal float _position;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal float _duration;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _fadeTime;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _time;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal float _fadeProgress;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _weightResult;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal readonly BlendState _blendState;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly List<string> _boneMask;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly List<BoneTimelineState> _boneTimelines;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly List<SlotTimelineState> _slotTimelines;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<ConstraintTimelineState> _constraintTimelines;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly List<TimelineState> _poseTimelines;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Dictionary<string, BonePose> _bonePoses;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AnimationData _animationData;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Armature _armature;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal ActionTimelineState _actionTimeline;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ZOrderTimelineState _zOrderTimeline;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AnimationState _parent;

		[Token(Token = "0x17000045")]
		public bool isFadeIn
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0xEAFE04", Offset = "0xEAFE04", VA = "0xEAFE04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public bool isFadeOut
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0xEAFE10", Offset = "0xEAFE10", VA = "0xEAFE10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public bool isFadeComplete
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xEAFE20", Offset = "0xEAFE20", VA = "0xEAFE20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		public bool isPlaying
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0xEA97E0", Offset = "0xEA97E0", VA = "0xEA97E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public bool isCompleted
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0xEA9814", Offset = "0xEA9814", VA = "0xEA9814")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public int currentPlayTimes
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xEAFE30", Offset = "0xEAFE30", VA = "0xEAFE30")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004B")]
		public float totalTime
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0xEAFE4C", Offset = "0xEAFE4C", VA = "0xEAFE4C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004C")]
		public float currentTime
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0xEAFE54", Offset = "0xEAFE54", VA = "0xEAFE54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0xEAA818", Offset = "0xEAA818", VA = "0xEAA818")]
			set
			{
			}
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xEACDA4", Offset = "0xEACDA4", VA = "0xEACDA4", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xEAD420", Offset = "0xEAD420", VA = "0xEAD420")]
		private void _UpdateTimelines()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xEAD8B0", Offset = "0xEAD8B0", VA = "0xEAD8B0")]
		private void _UpdateBoneAndSlotTimelines()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xEAF660", Offset = "0xEAF660", VA = "0xEAF660")]
		private void _AdvanceFadeTime(float passedTime)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xEA8A48", Offset = "0xEA8A48", VA = "0xEA8A48")]
		internal void Init(Armature armature, AnimationData animationData, AnimationConfig animationConfig)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xEA75D4", Offset = "0xEA75D4", VA = "0xEA75D4")]
		internal void AdvanceTime(float passedTime, float cacheFrameRate)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xEA9838", Offset = "0xEA9838", VA = "0xEA9838")]
		public void Play()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xEA8118", Offset = "0xEA8118", VA = "0xEA8118")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xEA6990", Offset = "0xEA6990", VA = "0xEA6990")]
		public void FadeOut(float fadeOutTime, bool pausePlayhead = true)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xEAF5D4", Offset = "0xEAF5D4", VA = "0xEAF5D4")]
		public bool ContainsBoneMask(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xEACB54", Offset = "0xEACB54", VA = "0xEACB54")]
		public void AddBoneMask(string boneName, bool recursive = true)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xEAF9E4", Offset = "0xEAF9E4", VA = "0xEAF9E4")]
		public void RemoveBoneMask(string boneName, bool recursive = true)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xEAFDA4", Offset = "0xEAFDA4", VA = "0xEAFDA4")]
		public void RemoveAllBoneMask()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xEAFE70", Offset = "0xEAFE70", VA = "0xEAFE70")]
		public AnimationState()
		{
		}
	}
	[Token(Token = "0x200011F")]
	internal class BonePose : BaseObject
	{
		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Transform current;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Transform delta;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Transform result;

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xCFC4B4", Offset = "0xCFC4B4", VA = "0xCFC4B4", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xCFC500", Offset = "0xCFC500", VA = "0xCFC500")]
		public BonePose()
		{
		}
	}
	[Token(Token = "0x2000120")]
	internal class BlendState
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool dirty;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int layer;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float leftWeight;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float layerWeight;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float blendWeight;

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xCFA8E0", Offset = "0xCFA8E0", VA = "0xCFA8E0")]
		public int Update(float weight, int p_layer)
		{
			return default(int);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xCFA964", Offset = "0xCFA964", VA = "0xCFA964")]
		public void Clear()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xCFA974", Offset = "0xCFA974", VA = "0xCFA974")]
		public BlendState()
		{
		}
	}
	[Token(Token = "0x2000121")]
	internal enum TweenState
	{
		[Token(Token = "0x400029A")]
		None,
		[Token(Token = "0x400029B")]
		Once,
		[Token(Token = "0x400029C")]
		Always
	}
	[Token(Token = "0x2000122")]
	internal abstract class TimelineState : BaseObject
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int playState;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int currentPlayTimes;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float currentTime;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected TweenState _tweenState;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected uint _frameRate;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected int _frameValueOffset;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected uint _frameCount;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected uint _frameOffset;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected int _frameIndex;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float _frameRateR;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float _position;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float _duration;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected float _timeScale;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected float _timeOffset;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected DragonBonesData _dragonBonesData;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected AnimationData _animationData;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected TimelineData _timelineData;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Armature _armature;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected AnimationState _animationState;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected TimelineState _actionTimeline;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected short[] _frameArray;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected short[] _frameIntArray;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected float[] _frameFloatArray;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected ushort[] _timelineArray;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected List<uint> _frameIndices;

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x148433C", Offset = "0x148433C", VA = "0x148433C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60006A6")]
		protected abstract void _OnArriveAtFrame();

		[Token(Token = "0x60006A7")]
		protected abstract void _OnUpdateFrame();

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x148442C", Offset = "0x148442C", VA = "0x148442C")]
		protected bool _SetCurrentTime(float passedTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x148463C", Offset = "0x148463C", VA = "0x148463C", Slot = "7")]
		public virtual void Init(Armature armature, AnimationState animationState, TimelineData timelineData)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x14848B8", Offset = "0x14848B8", VA = "0x14848B8", Slot = "8")]
		public virtual void FadeOut()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1483274", Offset = "0x1483274", VA = "0x1483274", Slot = "9")]
		public virtual void Update(float passedTime)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x14848BC", Offset = "0x14848BC", VA = "0x14848BC")]
		protected TimelineState()
		{
		}
	}
	[Token(Token = "0x2000123")]
	internal abstract class TweenTimelineState : TimelineState
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected TweenType _tweenType;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		protected int _curveCount;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected float _framePosition;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		protected float _frameDurationR;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected float _tweenProgress;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		protected float _tweenEasing;

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x14850FC", Offset = "0x14850FC", VA = "0x14850FC")]
		private static float _GetEasingValue(TweenType tweenType, float progress, float easing)
		{
			return default(float);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x148523C", Offset = "0x148523C", VA = "0x148523C")]
		private static float _GetEasingCurveValue(float progress, short[] samples, int count, int offset)
		{
			return default(float);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x14837AC", Offset = "0x14837AC", VA = "0x14837AC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x14826F0", Offset = "0x14826F0", VA = "0x14826F0", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1482C1C", Offset = "0x1482C1C", VA = "0x1482C1C", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x14837D4", Offset = "0x14837D4", VA = "0x14837D4")]
		protected TweenTimelineState()
		{
		}
	}
	[Token(Token = "0x2000124")]
	internal abstract class BoneTimelineState : TweenTimelineState
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Bone bone;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BonePose bonePose;

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xCFCB30", Offset = "0xCFCB30", VA = "0xCFCB30", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xCFCB70", Offset = "0xCFCB70", VA = "0xCFCB70")]
		public void Blend(int state)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xCFBE10", Offset = "0xCFBE10", VA = "0xCFBE10")]
		protected BoneTimelineState()
		{
		}
	}
	[Token(Token = "0x2000125")]
	internal abstract class SlotTimelineState : TweenTimelineState
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Slot slot;

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x148206C", Offset = "0x148206C", VA = "0x148206C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1483534", Offset = "0x1483534", VA = "0x1483534")]
		protected SlotTimelineState()
		{
		}
	}
	[Token(Token = "0x2000126")]
	internal abstract class ConstraintTimelineState : TweenTimelineState
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Constraint constraint;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xCFF750", Offset = "0xCFF750", VA = "0xCFF750", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xCFF780", Offset = "0xCFF780", VA = "0xCFF780")]
		protected ConstraintTimelineState()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public interface IAnimatable
	{
		[Token(Token = "0x1700004D")]
		WorldClock clock
		{
			[Token(Token = "0x60006BB")]
			get;
			[Token(Token = "0x60006BC")]
			set;
		}

		[Token(Token = "0x60006BA")]
		void AdvanceTime(float passedTime);
	}
	[Token(Token = "0x2000128")]
	internal class ActionTimelineState : TimelineState
	{
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xEA5378", Offset = "0xEA5378", VA = "0xEA5378")]
		private void _OnCrossFrame(int frameIndex)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xEA57E8", Offset = "0xEA57E8", VA = "0xEA57E8", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xEA57EC", Offset = "0xEA57EC", VA = "0xEA57EC", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xEA57F0", Offset = "0xEA57F0", VA = "0xEA57F0", Slot = "9")]
		public override void Update(float passedTime)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xEA62A0", Offset = "0xEA62A0", VA = "0xEA62A0")]
		public void SetCurrentTime(float value)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xEA62CC", Offset = "0xEA62CC", VA = "0xEA62CC")]
		public ActionTimelineState()
		{
		}
	}
	[Token(Token = "0x2000129")]
	internal class ZOrderTimelineState : TimelineState
	{
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1015BBC", Offset = "0x1015BBC", VA = "0x1015BBC", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1015C38", Offset = "0x1015C38", VA = "0x1015C38", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1015C3C", Offset = "0x1015C3C", VA = "0x1015C3C")]
		public ZOrderTimelineState()
		{
		}
	}
	[Token(Token = "0x200012A")]
	internal class BoneAllTimelineState : BoneTimelineState
	{
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xCFB9DC", Offset = "0xCFB9DC", VA = "0xCFB9DC", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xCFBC74", Offset = "0xCFBC74", VA = "0xCFBC74", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xCFBD68", Offset = "0xCFBD68", VA = "0xCFBD68", Slot = "8")]
		public override void FadeOut()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xCFBE08", Offset = "0xCFBE08", VA = "0xCFBE08")]
		public BoneAllTimelineState()
		{
		}
	}
	[Token(Token = "0x200012B")]
	internal class BoneTranslateTimelineState : BoneTimelineState
	{
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xCFCCFC", Offset = "0xCFCCFC", VA = "0xCFCCFC", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xCFCEA0", Offset = "0xCFCEA0", VA = "0xCFCEA0", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xCFCF34", Offset = "0xCFCF34", VA = "0xCFCF34")]
		public BoneTranslateTimelineState()
		{
		}
	}
	[Token(Token = "0x200012C")]
	internal class BoneRotateTimelineState : BoneTimelineState
	{
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xCFC5F0", Offset = "0xCFC5F0", VA = "0xCFC5F0", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xCFC7D4", Offset = "0xCFC7D4", VA = "0xCFC7D4", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xCFC868", Offset = "0xCFC868", VA = "0xCFC868", Slot = "8")]
		public override void FadeOut()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xCFC908", Offset = "0xCFC908", VA = "0xCFC908")]
		public BoneRotateTimelineState()
		{
		}
	}
	[Token(Token = "0x200012D")]
	internal class BoneScaleTimelineState : BoneTimelineState
	{
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xCFC910", Offset = "0xCFC910", VA = "0xCFC910", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xCFCA94", Offset = "0xCFCA94", VA = "0xCFCA94", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xCFCB28", Offset = "0xCFCB28", VA = "0xCFCB28")]
		public BoneScaleTimelineState()
		{
		}
	}
	[Token(Token = "0x200012E")]
	internal class SlotDislayTimelineState : SlotTimelineState
	{
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1483708", Offset = "0x1483708", VA = "0x1483708", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x14837A8", Offset = "0x14837A8", VA = "0x14837A8")]
		public SlotDislayTimelineState()
		{
		}
	}
	[Token(Token = "0x200012F")]
	internal class SlotColorTimelineState : SlotTimelineState
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _dirty;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly int[] _current;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly int[] _delta;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly float[] _result;

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1482030", Offset = "0x1482030", VA = "0x1482030", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x14820A0", Offset = "0x14820A0", VA = "0x14820A0", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x14828E8", Offset = "0x14828E8", VA = "0x14828E8", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1482C98", Offset = "0x1482C98", VA = "0x1482C98", Slot = "8")]
		public override void FadeOut()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1482CA4", Offset = "0x1482CA4", VA = "0x1482CA4", Slot = "9")]
		public override void Update(float passedTime)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1483484", Offset = "0x1483484", VA = "0x1483484")]
		public SlotColorTimelineState()
		{
		}
	}
	[Token(Token = "0x2000130")]
	internal class DeformTimelineState : SlotTimelineState
	{
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int vertexOffset;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool _dirty;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int _frameFloatOffset;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _valueCount;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int _deformCount;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int _valueOffset;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly List<float> _current;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly List<float> _delta;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly List<float> _result;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool test;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xD5F6BC", Offset = "0xD5F6BC", VA = "0xD5F6BC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xD5F748", Offset = "0xD5F748", VA = "0xD5F748", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xD5F9B0", Offset = "0xD5F9B0", VA = "0xD5F9B0", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xD5FAD4", Offset = "0xD5FAD4", VA = "0xD5FAD4", Slot = "7")]
		public override void Init(Armature armature, AnimationState animationState, TimelineData timelineData)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xD5FD3C", Offset = "0xD5FD3C", VA = "0xD5FD3C", Slot = "8")]
		public override void FadeOut()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xD5FD48", Offset = "0xD5FD48", VA = "0xD5FD48", Slot = "9")]
		public override void Update(float passedTime)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xD601D4", Offset = "0xD601D4", VA = "0xD601D4")]
		public DeformTimelineState()
		{
		}
	}
	[Token(Token = "0x2000131")]
	internal class IKConstraintTimelineState : ConstraintTimelineState
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _current;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _delta;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1469AF4", Offset = "0x1469AF4", VA = "0x1469AF4", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1469B1C", Offset = "0x1469B1C", VA = "0x1469B1C", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1469CFC", Offset = "0x1469CFC", VA = "0x1469CFC", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1469DB0", Offset = "0x1469DB0", VA = "0x1469DB0")]
		public IKConstraintTimelineState()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class WorldClock : IAnimatable
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float time;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float timeScale;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _systemTime;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<IAnimatable> _animatebles;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WorldClock _clock;

		[Token(Token = "0x1700004E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x73FE24", Offset = "0x73FE24")]
		public WorldClock clock
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x10158A4", Offset = "0x10158A4", VA = "0x10158A4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x10158AC", Offset = "0x10158AC", VA = "0x10158AC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1014FFC", Offset = "0x1014FFC", VA = "0x1014FFC")]
		public WorldClock(float time = -1f)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1015104", Offset = "0x1015104", VA = "0x1015104", Slot = "4")]
		public void AdvanceTime(float passedTime)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1015430", Offset = "0x1015430", VA = "0x1015430")]
		public bool Contains(IAnimatable value)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1015508", Offset = "0x1015508", VA = "0x1015508")]
		public void Add(IAnimatable value)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1015628", Offset = "0x1015628", VA = "0x1015628")]
		public void Remove(IAnimatable value)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x101574C", Offset = "0x101574C", VA = "0x101574C")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class Armature : BaseObject, IAnimatable
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool inheritAnimation;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object userData;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _lockUpdate;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool _slotsDirty;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool _zOrderDirty;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		private bool _flipX;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _flipY;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int _cacheFrameIndex;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<Bone> _bones;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<Slot> _slots;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal readonly List<Constraint> _constraints;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<EventObject> _actions;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ArmatureData _armatureData;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animation _animation;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IArmatureProxy _proxy;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private object _display;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal TextureAtlasData _replaceTextureAtlasData;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object _replacedTexture;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal DragonBones _dragonBones;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private WorldClock _clock;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal Slot _parent;

		[Token(Token = "0x1700004F")]
		public bool flipX
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0xEB14C4", Offset = "0xEB14C4", VA = "0xEB14C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000703")]
			[Address(RVA = "0xEB14CC", Offset = "0xEB14CC", VA = "0xEB14CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public bool flipY
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0xEB14F8", Offset = "0xEB14F8", VA = "0xEB14F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000705")]
			[Address(RVA = "0xEB1500", Offset = "0xEB1500", VA = "0xEB1500")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public uint cacheFrameRate
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0xEB152C", Offset = "0xEB152C", VA = "0xEB152C")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000707")]
			[Address(RVA = "0xEB1548", Offset = "0xEB1548", VA = "0xEB1548")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public string name
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0xEA8A2C", Offset = "0xEA8A2C", VA = "0xEA8A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public ArmatureData armatureData
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0xEB1818", Offset = "0xEB1818", VA = "0xEB1818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public Animation animation
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0xEB1820", Offset = "0xEB1820", VA = "0xEB1820")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public IArmatureProxy proxy
		{
			[Token(Token = "0x600070B")]
			[Address(RVA = "0xEB1828", Offset = "0xEB1828", VA = "0xEB1828")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public IEventDispatcher<EventObject> eventDispatcher
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0xEB1830", Offset = "0xEB1830", VA = "0xEB1830")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public object display
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0xEB1838", Offset = "0xEB1838", VA = "0xEB1838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public object replacedTexture
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0xEB1840", Offset = "0xEB1840", VA = "0xEB1840")]
			get
			{
				return null;
			}
			[Token(Token = "0x600070F")]
			[Address(RVA = "0xEB1848", Offset = "0xEB1848", VA = "0xEB1848")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public WorldClock clock
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0xEB19C0", Offset = "0xEB19C0", VA = "0xEB19C0", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0xEB19C8", Offset = "0xEB19C8", VA = "0xEB19C8", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public Slot parent
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0xEB1B38", Offset = "0xEB1B38", VA = "0xEB1B38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xEB00DC", Offset = "0xEB00DC", VA = "0xEB00DC")]
		private static int _OnSortSlots(Slot a, Slot b)
		{
			return default(int);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xEB0118", Offset = "0xEB0118", VA = "0xEB0118", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xEA6164", Offset = "0xEA6164", VA = "0xEA6164")]
		internal void _SortZOrder(short[] slotIndices, int offset)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xEB07F4", Offset = "0xEB07F4", VA = "0xEB07F4")]
		internal void _AddBone(Bone value)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xEB0894", Offset = "0xEB0894", VA = "0xEB0894")]
		internal void _AddSlot(Slot value)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xEB093C", Offset = "0xEB093C", VA = "0xEB093C")]
		internal void _AddConstraint(Constraint value)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xEA5710", Offset = "0xEA5710", VA = "0xEA5710")]
		internal void _BufferAction(EventObject action, bool append)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xEB09DC", Offset = "0xEB09DC", VA = "0xEB09DC")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xEB0A04", Offset = "0xEB0A04", VA = "0xEB0A04")]
		internal void Init(ArmatureData armatureData, IArmatureProxy proxy, object display, DragonBones dragonBones)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xEA8FBC", Offset = "0xEA8FBC", VA = "0xEA8FBC", Slot = "5")]
		public void AdvanceTime(float passedTime)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xEB0BB4", Offset = "0xEB0BB4", VA = "0xEB0BB4")]
		public void InvalidUpdate([Optional] string boneName, bool updateSlot = false)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xEB0F44", Offset = "0xEB0F44", VA = "0xEB0F44")]
		public Slot ContainsPoint(float x, float y)
		{
			return null;
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xEB10A0", Offset = "0xEB10A0", VA = "0xEB10A0")]
		public Slot IntersectsSegment(float xA, float yA, float xB, float yB, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return null;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xEAB190", Offset = "0xEAB190", VA = "0xEAB190")]
		public Bone GetBone(string name)
		{
			return null;
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xEB1354", Offset = "0xEB1354", VA = "0xEB1354")]
		public Bone GetBoneByDisplay(object display)
		{
			return null;
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xEB0694", Offset = "0xEB0694", VA = "0xEB0694")]
		public Slot GetSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xEB1370", Offset = "0xEB1370", VA = "0xEB1370")]
		public Slot GetSlotByDisplay(object display)
		{
			return null;
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xEB14B4", Offset = "0xEB14B4", VA = "0xEB14B4")]
		public List<Bone> GetBones()
		{
			return null;
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xEB14BC", Offset = "0xEB14BC", VA = "0xEB14BC")]
		public List<Slot> GetSlots()
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xEB1B40", Offset = "0xEB1B40", VA = "0xEB1B40")]
		public Armature()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class Bone : TransformObject
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal OffsetMode offsetMode;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal readonly Transform animationPose;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal bool _transformDirty;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		internal bool _childrenTransformDirty;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool _localDirty;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		internal bool _hasConstraint;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _visible;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _cachedFrameIndex;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal readonly BlendState _blendState;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal BoneData _boneData;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected Bone _parent;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal List<int> _cachedFrameIndices;

		[Token(Token = "0x1700005B")]
		public BoneData boneData
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0xCFB5D4", Offset = "0xCFB5D4", VA = "0xCFB5D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public bool visible
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0xCFB5DC", Offset = "0xCFB5DC", VA = "0xCFB5DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071D")]
			[Address(RVA = "0xCFB5E4", Offset = "0xCFB5E4", VA = "0xCFB5E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public string name
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0xCFB740", Offset = "0xCFB740", VA = "0xCFB740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public Bone parent
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0xCFB75C", Offset = "0xCFB75C", VA = "0xCFB75C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x73FE5C", Offset = "0x73FE5C")]
		public Slot slot
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0xCFB764", Offset = "0xCFB764", VA = "0xCFB764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xCFA97C", Offset = "0xCFA97C", VA = "0xCFA97C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xCFAA10", Offset = "0xCFAA10", VA = "0xCFAA10")]
		private void _UpdateGlobalTransformMatrix(bool isCache)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xCFB0B0", Offset = "0xCFB0B0", VA = "0xCFB0B0")]
		internal void Init(BoneData boneData, Armature armatureValue)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xCFB16C", Offset = "0xCFB16C", VA = "0xCFB16C")]
		internal void Update(int cacheFrameIndex)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xCFB544", Offset = "0xCFB544", VA = "0xCFB544")]
		internal void UpdateByConstraint()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xCFB59C", Offset = "0xCFB59C", VA = "0xCFB59C")]
		public void InvalidUpdate()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xCFB5A8", Offset = "0xCFB5A8", VA = "0xCFB5A8")]
		public bool Contains(Bone value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xCFB8B0", Offset = "0xCFB8B0", VA = "0xCFB8B0")]
		public Bone()
		{
		}
	}
	[Token(Token = "0x2000135")]
	internal abstract class Constraint : BaseObject
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly Matrix _helpMatrix;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly Transform _helpTransform;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static readonly Point _helpPoint;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal ConstraintData _constraintData;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Armature _armature;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Bone _target;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal Bone _root;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Bone _bone;

		[Token(Token = "0x17000060")]
		public string name
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0xCFF4F0", Offset = "0xCFF4F0", VA = "0xCFF4F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xCFF49C", Offset = "0xCFF49C", VA = "0xCFF49C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000723")]
		public abstract void Init(ConstraintData constraintData, Armature armature);

		[Token(Token = "0x6000724")]
		public abstract void Update();

		[Token(Token = "0x6000725")]
		public abstract void InvalidUpdate();

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xCFF50C", Offset = "0xCFF50C", VA = "0xCFF50C")]
		protected Constraint()
		{
		}
	}
	[Token(Token = "0x2000136")]
	internal class IKConstraint : Constraint
	{
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool _scaleEnabled;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		internal bool _bendPositive;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal float _weight;

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x146925C", Offset = "0x146925C", VA = "0x146925C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1469298", Offset = "0x1469298", VA = "0x1469298")]
		private void _ComputeA()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x14693C0", Offset = "0x14693C0", VA = "0x14693C0")]
		private void _ComputeB()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x146982C", Offset = "0x146982C", VA = "0x146982C", Slot = "5")]
		public override void Init(ConstraintData constraintData, Armature armature)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x14699BC", Offset = "0x14699BC", VA = "0x14699BC", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1469A10", Offset = "0x1469A10", VA = "0x1469A10", Slot = "7")]
		public override void InvalidUpdate()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1469A58", Offset = "0x1469A58", VA = "0x1469A58")]
		public IKConstraint()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class DeformVertices : BaseObject
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool verticesDirty;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<float> vertices;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<Bone> bones;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VerticesData verticesData;

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xD602A8", Offset = "0xD602A8", VA = "0xD602A8", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xD60334", Offset = "0xD60334", VA = "0xD60334")]
		public void init(VerticesData verticesDataValue, Armature armature)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xD605FC", Offset = "0xD605FC", VA = "0xD605FC")]
		public bool isBonesUpdate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xD6072C", Offset = "0xD6072C", VA = "0xD6072C")]
		public DeformVertices()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public interface IArmatureProxy : IEventDispatcher<EventObject>
	{
		[Token(Token = "0x17000061")]
		Armature armature
		{
			[Token(Token = "0x6000738")]
			get;
		}

		[Token(Token = "0x17000062")]
		Animation animation
		{
			[Token(Token = "0x6000739")]
			get;
		}

		[Token(Token = "0x6000734")]
		void DBInit(Armature armature);

		[Token(Token = "0x6000735")]
		void DBClear();

		[Token(Token = "0x6000736")]
		void DBUpdate();

		[Token(Token = "0x6000737")]
		void Dispose(bool disposeProxy);
	}
	[Token(Token = "0x2000139")]
	public abstract class Slot : TransformObject
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string displayController;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected bool _displayDirty;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		protected bool _zOrderDirty;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		protected bool _visibleDirty;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		protected bool _blendModeDirty;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal bool _colorDirty;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		internal bool _transformDirty;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		protected bool _visible;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal BlendMode _blendMode;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected int _displayIndex;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected int _animationDisplayIndex;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal int _zOrder;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected int _cachedFrameIndex;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		internal float _pivotX;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal float _pivotY;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected readonly Matrix _localMatrix;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal readonly ColorTransform _colorTransform;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal readonly List<DisplayData> _displayDatas;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected readonly List<object> _displayList;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal SlotData _slotData;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected List<DisplayData> _rawDisplayDatas;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected DisplayData _displayData;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected BoundingBoxData _boundingBoxData;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected TextureData _textureData;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public DeformVertices _deformVertices;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected object _rawDisplay;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected object _meshDisplay;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected object _display;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected Armature _childArmature;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected Bone _parent;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal List<int> _cachedFrameIndices;

		[Token(Token = "0x17000063")]
		public bool visible
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x1481B08", Offset = "0x1481B08", VA = "0x1481B08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x1481B10", Offset = "0x1481B10", VA = "0x1481B10")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public int displayIndex
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x1481B3C", Offset = "0x1481B3C", VA = "0x1481B3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x147DF50", Offset = "0x147DF50", VA = "0x147DF50")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public string name
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1481B44", Offset = "0x1481B44", VA = "0x1481B44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public List<object> displayList
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x147DEAC", Offset = "0x147DEAC", VA = "0x147DEAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1481B60", Offset = "0x1481B60", VA = "0x1481B60")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public SlotData slotData
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x1481E34", Offset = "0x1481E34", VA = "0x1481E34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public List<DisplayData> rawDisplayDatas
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x1481E3C", Offset = "0x1481E3C", VA = "0x1481E3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x1481E44", Offset = "0x1481E44", VA = "0x1481E44")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public BoundingBoxData boundingBoxData
		{
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x1481FEC", Offset = "0x1481FEC", VA = "0x1481FEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public object rawDisplay
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x1481FF4", Offset = "0x1481FF4", VA = "0x1481FF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public object meshDisplay
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x1481FFC", Offset = "0x1481FFC", VA = "0x1481FFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public object display
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1482004", Offset = "0x1482004", VA = "0x1482004")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x147DFA4", Offset = "0x147DFA4", VA = "0x147DFA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Armature childArmature
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x148200C", Offset = "0x148200C", VA = "0x148200C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x1482014", Offset = "0x1482014", VA = "0x1482014")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public Bone parent
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x1482028", Offset = "0x1482028", VA = "0x1482028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x147F1F0", Offset = "0x147F1F0", VA = "0x147F1F0")]
		public Slot()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x147F4C8", Offset = "0x147F4C8", VA = "0x147F4C8", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600073C")]
		protected abstract void _InitDisplay(object value, bool isRetain);

		[Token(Token = "0x600073D")]
		protected abstract void _DisposeDisplay(object value, bool isRelease);

		[Token(Token = "0x600073E")]
		protected abstract void _OnUpdateDisplay();

		[Token(Token = "0x600073F")]
		protected abstract void _AddDisplay();

		[Token(Token = "0x6000740")]
		protected abstract void _ReplaceDisplay(object value);

		[Token(Token = "0x6000741")]
		protected abstract void _RemoveDisplay();

		[Token(Token = "0x6000742")]
		protected abstract void _UpdateZOrder();

		[Token(Token = "0x6000743")]
		internal abstract void _UpdateVisible();

		[Token(Token = "0x6000744")]
		internal abstract void _UpdateBlendMode();

		[Token(Token = "0x6000745")]
		protected abstract void _UpdateColor();

		[Token(Token = "0x6000746")]
		protected abstract void _UpdateFrame();

		[Token(Token = "0x6000747")]
		protected abstract void _UpdateMesh();

		[Token(Token = "0x6000748")]
		protected abstract void _UpdateTransform();

		[Token(Token = "0x6000749")]
		protected abstract void _IdentityTransform();

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x147F91C", Offset = "0x147F91C", VA = "0x147F91C")]
		protected DisplayData _GetDefaultRawDisplayData(int displayIndex)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x147F9D0", Offset = "0x147F9D0", VA = "0x147F9D0")]
		protected void _UpdateDisplayData()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x14803D4", Offset = "0x14803D4", VA = "0x14803D4")]
		protected void _UpdateDisplay()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1480928", Offset = "0x1480928", VA = "0x1480928")]
		protected void _UpdateGlobalTransformMatrix(bool isCache)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1480CCC", Offset = "0x1480CCC", VA = "0x1480CCC")]
		internal bool _SetDisplayIndex(int value, bool isAnimation = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1480D30", Offset = "0x1480D30", VA = "0x1480D30")]
		internal bool _SetZorder(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1480D48", Offset = "0x1480D48", VA = "0x1480D48")]
		internal bool _SetColor(ColorTransform value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1480D84", Offset = "0x1480D84", VA = "0x1480D84")]
		internal bool _SetDisplayList(List<object> value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1481008", Offset = "0x1481008", VA = "0x1481008", Slot = "19")]
		internal virtual void Init(SlotData slotData, Armature armatureValue, object rawDisplay, object meshDisplay)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x148116C", Offset = "0x148116C", VA = "0x148116C")]
		internal void Update(int cacheFrameIndex)
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1481528", Offset = "0x1481528", VA = "0x1481528")]
		public void UpdateTransformAndMatrix()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1481540", Offset = "0x1481540", VA = "0x1481540")]
		internal void ReplaceDisplayData(DisplayData value, int displayIndex = -1)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1481684", Offset = "0x1481684", VA = "0x1481684")]
		public bool ContainsPoint(float x, float y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x14817A8", Offset = "0x14817A8", VA = "0x14817A8")]
		public int IntersectsSegment(float xA, float yA, float xB, float yB, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1481AF8", Offset = "0x1481AF8", VA = "0x1481AF8")]
		public void InvalidUpdate()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public abstract class TransformObject : BaseObject
	{
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly Matrix _helpMatrix;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly Transform _helpTransform;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static readonly Point _helpPoint;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Matrix globalTransformMatrix;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Transform global;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Transform offset;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform origin;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object userData;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected bool _globalDirty;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal Armature _armature;

		[Token(Token = "0x1700006F")]
		public Armature armature
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1484FFC", Offset = "0x1484FFC", VA = "0x1484FFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x147F898", Offset = "0x147F898", VA = "0x147F898", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1484FCC", Offset = "0x1484FCC", VA = "0x1484FCC")]
		public void UpdateGlobalTransform()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x147F3B0", Offset = "0x147F3B0", VA = "0x147F3B0")]
		protected TransformObject()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public abstract class BaseObject
	{
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint _hashCode;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static uint _defaultMaxCount;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, uint> _maxCountMap;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<Type, List<BaseObject>> _poolsMap;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly uint hashCode;

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xEB8864", Offset = "0xEB8864", VA = "0xEB8864")]
		private static void _ReturnObject(BaseObject obj)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xEB8B9C", Offset = "0xEB8B9C", VA = "0xEB8B9C")]
		public static void SetMaxCount(Type classType, uint maxCount)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xEB901C", Offset = "0xEB901C", VA = "0xEB901C")]
		public static void ClearPool(Type classType)
		{
		}

		[Token(Token = "0x6000773")]
		public static T BorrowObject<T>() where T : BaseObject, new()
		{
			return null;
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xEA5278", Offset = "0xEA5278", VA = "0xEA5278")]
		protected BaseObject()
		{
		}

		[Token(Token = "0x6000775")]
		protected abstract void _OnClear();

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xEA51A8", Offset = "0xEA51A8", VA = "0xEA51A8")]
		public void ReturnToPool()
		{
		}
	}
	[Token(Token = "0x200013C")]
	internal enum BinaryOffset
	{
		[Token(Token = "0x4000334")]
		WeigthBoneCount = 0,
		[Token(Token = "0x4000335")]
		WeigthFloatOffset = 1,
		[Token(Token = "0x4000336")]
		WeigthBoneIndices = 2,
		[Token(Token = "0x4000337")]
		MeshVertexCount = 0,
		[Token(Token = "0x4000338")]
		MeshTriangleCount = 1,
		[Token(Token = "0x4000339")]
		MeshFloatOffset = 2,
		[Token(Token = "0x400033A")]
		MeshWeightOffset = 3,
		[Token(Token = "0x400033B")]
		MeshVertexIndices = 4,
		[Token(Token = "0x400033C")]
		TimelineScale = 0,
		[Token(Token = "0x400033D")]
		TimelineOffset = 1,
		[Token(Token = "0x400033E")]
		TimelineKeyFrameCount = 2,
		[Token(Token = "0x400033F")]
		TimelineFrameValueCount = 3,
		[Token(Token = "0x4000340")]
		TimelineFrameValueOffset = 4,
		[Token(Token = "0x4000341")]
		TimelineFrameOffset = 5,
		[Token(Token = "0x4000342")]
		FramePosition = 0,
		[Token(Token = "0x4000343")]
		FrameTweenType = 1,
		[Token(Token = "0x4000344")]
		FrameTweenEasingOrCurveSampleCount = 2,
		[Token(Token = "0x4000345")]
		FrameCurveSamples = 3,
		[Token(Token = "0x4000346")]
		DeformVertexOffset = 0,
		[Token(Token = "0x4000347")]
		DeformCount = 1,
		[Token(Token = "0x4000348")]
		DeformValueCount = 2,
		[Token(Token = "0x4000349")]
		DeformValueOffset = 3,
		[Token(Token = "0x400034A")]
		DeformFloatOffset = 4
	}
	[Token(Token = "0x200013D")]
	public enum ArmatureType
	{
		[Token(Token = "0x400034C")]
		None = -1,
		[Token(Token = "0x400034D")]
		Armature,
		[Token(Token = "0x400034E")]
		MovieClip,
		[Token(Token = "0x400034F")]
		Stage
	}
	[Token(Token = "0x200013E")]
	public enum DisplayType
	{
		[Token(Token = "0x4000351")]
		None = -1,
		[Token(Token = "0x4000352")]
		Image,
		[Token(Token = "0x4000353")]
		Armature,
		[Token(Token = "0x4000354")]
		Mesh,
		[Token(Token = "0x4000355")]
		BoundingBox,
		[Token(Token = "0x4000356")]
		Path
	}
	[Token(Token = "0x200013F")]
	public enum BoundingBoxType
	{
		[Token(Token = "0x4000358")]
		None = -1,
		[Token(Token = "0x4000359")]
		Rectangle,
		[Token(Token = "0x400035A")]
		Ellipse,
		[Token(Token = "0x400035B")]
		Polygon
	}
	[Token(Token = "0x2000140")]
	public enum ActionType
	{
		[Token(Token = "0x400035D")]
		Play = 0,
		[Token(Token = "0x400035E")]
		Frame = 10,
		[Token(Token = "0x400035F")]
		Sound = 11
	}
	[Token(Token = "0x2000141")]
	public enum BlendMode
	{
		[Token(Token = "0x4000361")]
		Normal,
		[Token(Token = "0x4000362")]
		Add,
		[Token(Token = "0x4000363")]
		Alpha,
		[Token(Token = "0x4000364")]
		Darken,
		[Token(Token = "0x4000365")]
		Difference,
		[Token(Token = "0x4000366")]
		Erase,
		[Token(Token = "0x4000367")]
		HardLight,
		[Token(Token = "0x4000368")]
		Invert,
		[Token(Token = "0x4000369")]
		Layer,
		[Token(Token = "0x400036A")]
		Lighten,
		[Token(Token = "0x400036B")]
		Multiply,
		[Token(Token = "0x400036C")]
		Overlay,
		[Token(Token = "0x400036D")]
		Screen,
		[Token(Token = "0x400036E")]
		Subtract
	}
	[Token(Token = "0x2000142")]
	public enum TweenType
	{
		[Token(Token = "0x4000370")]
		None,
		[Token(Token = "0x4000371")]
		Line,
		[Token(Token = "0x4000372")]
		Curve,
		[Token(Token = "0x4000373")]
		QuadIn,
		[Token(Token = "0x4000374")]
		QuadOut,
		[Token(Token = "0x4000375")]
		QuadInOut
	}
	[Token(Token = "0x2000143")]
	public enum TimelineType
	{
		[Token(Token = "0x4000377")]
		Action = 0,
		[Token(Token = "0x4000378")]
		ZOrder = 1,
		[Token(Token = "0x4000379")]
		BoneAll = 10,
		[Token(Token = "0x400037A")]
		BoneTranslate = 11,
		[Token(Token = "0x400037B")]
		BoneRotate = 12,
		[Token(Token = "0x400037C")]
		BoneScale = 13,
		[Token(Token = "0x400037D")]
		SlotDisplay = 20,
		[Token(Token = "0x400037E")]
		SlotColor = 21,
		[Token(Token = "0x400037F")]
		SlotDeform = 22,
		[Token(Token = "0x4000380")]
		IKConstraint = 30,
		[Token(Token = "0x4000381")]
		AnimationTime = 40,
		[Token(Token = "0x4000382")]
		AnimationWeight = 41
	}
	[Token(Token = "0x2000144")]
	public enum OffsetMode
	{
		[Token(Token = "0x4000384")]
		None,
		[Token(Token = "0x4000385")]
		Additive,
		[Token(Token = "0x4000386")]
		Override
	}
	[Token(Token = "0x2000145")]
	public enum AnimationFadeOutMode
	{
		[Token(Token = "0x4000388")]
		None,
		[Token(Token = "0x4000389")]
		SameLayer,
		[Token(Token = "0x400038A")]
		SameGroup,
		[Token(Token = "0x400038B")]
		SameLayerAndGroup,
		[Token(Token = "0x400038C")]
		All,
		[Token(Token = "0x400038D")]
		Single
	}
	[Token(Token = "0x2000146")]
	internal static class Helper
	{
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int INT16_SIZE;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int UINT16_SIZE;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int FLOAT_SIZE;

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x146905C", Offset = "0x146905C", VA = "0x146905C")]
		internal static void Assert(bool condition, string message)
		{
		}

		[Token(Token = "0x6000779")]
		internal static void ResizeList<T>(this List<T> list, int count, [Optional] T value)
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1469060", Offset = "0x1469060", VA = "0x1469060")]
		internal static List<float> Convert(this List<object> list)
		{
			return null;
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1469174", Offset = "0x1469174", VA = "0x1469174")]
		internal static bool FloatEqual(float f0, float f1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000147")]
	public class DragonBones
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool yDown;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool debug;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool debugDraw;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string VERSION;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly WorldClock _clock;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<EventObject> _events;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<BaseObject> _objects;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IEventDispatcher<EventObject> _eventManager;

		[Token(Token = "0x17000070")]
		public WorldClock clock
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0xD61070", Offset = "0xD61070", VA = "0xD61070")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public IEventDispatcher<EventObject> eventManager
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0xD61078", Offset = "0xD61078", VA = "0xD61078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xD60B34", Offset = "0xD60B34", VA = "0xD60B34")]
		public DragonBones(IEventDispatcher<EventObject> eventManager)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xD60C5C", Offset = "0xD60C5C", VA = "0xD60C5C")]
		public void AdvanceTime(float passedTime)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xD60FC4", Offset = "0xD60FC4", VA = "0xD60FC4")]
		public void BufferEvent(EventObject value)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xD60F24", Offset = "0xD60F24", VA = "0xD60F24")]
		public void BufferObject(BaseObject value)
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xD61064", Offset = "0xD61064", VA = "0xD61064")]
		public static implicit operator bool(DragonBones exists)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000148")]
	public class EventObject : BaseObject
	{
		[Token(Token = "0x4000399")]
		public const string START = "start";

		[Token(Token = "0x400039A")]
		public const string LOOP_COMPLETE = "loopComplete";

		[Token(Token = "0x400039B")]
		public const string COMPLETE = "complete";

		[Token(Token = "0x400039C")]
		public const string FADE_IN = "fadeIn";

		[Token(Token = "0x400039D")]
		public const string FADE_IN_COMPLETE = "fadeInComplete";

		[Token(Token = "0x400039E")]
		public const string FADE_OUT = "fadeOut";

		[Token(Token = "0x400039F")]
		public const string FADE_OUT_COMPLETE = "fadeOutComplete";

		[Token(Token = "0x40003A0")]
		public const string FRAME_EVENT = "frameEvent";

		[Token(Token = "0x40003A1")]
		public const string SOUND_EVENT = "soundEvent";

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float time;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string type;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Armature armature;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Bone bone;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Slot slot;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationState animationState;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ActionData actionData;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UserData data;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1468A60", Offset = "0x1468A60", VA = "0x1468A60")]
		public static void ActionDataToInstance(ActionData data, EventObject instance, Armature armature)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1468BAC", Offset = "0x1468BAC", VA = "0x1468BAC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1468C80", Offset = "0x1468C80", VA = "0x1468C80")]
		public EventObject()
		{
		}
	}
	[Token(Token = "0x2000149")]
	public delegate void ListenerDelegate<T>(string type, T eventObject);
	[Token(Token = "0x200014A")]
	public interface IEventDispatcher<T>
	{
		[Token(Token = "0x600078C")]
		bool HasDBEventListener(string type);

		[Token(Token = "0x600078D")]
		void DispatchDBEvent(string type, T eventObject);

		[Token(Token = "0x600078E")]
		void AddDBEventListener(string type, ListenerDelegate<T> listener);

		[Token(Token = "0x600078F")]
		void RemoveDBEventListener(string type, ListenerDelegate<T> listener);
	}
	[Token(Token = "0x200014B")]
	public class BuildArmaturePackage
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dataName;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string textureAtlasName;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DragonBonesData data;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArmatureData armature;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SkinData skin;

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xCFDD60", Offset = "0xCFDD60", VA = "0xCFDD60")]
		public BuildArmaturePackage()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public abstract class BaseFactory
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static ObjectDataParser _objectParser;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static BinaryDataParser _binaryParser;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool autoSearch;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly Dictionary<string, DragonBonesData> _dragonBonesDataMap;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly Dictionary<string, List<TextureAtlasData>> _textureAtlasDataMap;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DragonBones _dragonBones;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected DataParser _dataParser;

		[Token(Token = "0x17000072")]
		public WorldClock clock
		{
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xEB8838", Offset = "0xEB8838", VA = "0xEB8838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xEB4F80", Offset = "0xEB4F80", VA = "0xEB4F80")]
		public BaseFactory([Optional] DataParser dataParser)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xEB51B0", Offset = "0xEB51B0", VA = "0xEB51B0")]
		protected bool _IsSupportMesh()
		{
			return default(bool);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xEB51B8", Offset = "0xEB51B8", VA = "0xEB51B8")]
		protected TextureData _GetTextureData(string textureAtlasName, string textureName)
		{
			return null;
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xEB5634", Offset = "0xEB5634", VA = "0xEB5634")]
		protected bool _FillBuildArmaturePackage(BuildArmaturePackage dataPackage, string dragonBonesName, string armatureName, string skinName, string textureAtlasName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xEB5AC4", Offset = "0xEB5AC4", VA = "0xEB5AC4")]
		protected void _BuildBones(BuildArmaturePackage dataPackage, Armature armature)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xEB5BE0", Offset = "0xEB5BE0", VA = "0xEB5BE0")]
		protected void _BuildSlots(BuildArmaturePackage dataPackage, Armature armature)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xEB6674", Offset = "0xEB6674", VA = "0xEB6674")]
		protected void _BuildConstraints(BuildArmaturePackage dataPackage, Armature armature)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xEB685C", Offset = "0xEB685C", VA = "0xEB685C", Slot = "4")]
		protected virtual Armature _BuildChildArmature(BuildArmaturePackage dataPackage, Slot slot, DisplayData displayData)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xEB6224", Offset = "0xEB6224", VA = "0xEB6224")]
		protected object _GetSlotDisplay(BuildArmaturePackage dataPackage, DisplayData displayData, DisplayData rawDisplayData, Slot slot)
		{
			return null;
		}

		[Token(Token = "0x600079A")]
		protected abstract TextureAtlasData _BuildTextureAtlasData(TextureAtlasData textureAtlasData, object textureAtlas);

		[Token(Token = "0x600079B")]
		protected abstract Armature _BuildArmature(BuildArmaturePackage dataPackage);

		[Token(Token = "0x600079C")]
		protected abstract Slot _BuildSlot(BuildArmaturePackage dataPackage, SlotData slotData, Armature armature);

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xEB68E0", Offset = "0xEB68E0", VA = "0xEB68E0")]
		public DragonBonesData ParseDragonBonesData(object rawData, [Optional] string name, float scale = 1f)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xEB6D1C", Offset = "0xEB6D1C", VA = "0xEB6D1C")]
		public TextureAtlasData ParseTextureAtlasData(Dictionary<string, object> rawData, object textureAtlas, [Optional] string name, float scale = 1f)
		{
			return null;
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xEB6DCC", Offset = "0xEB6DCC", VA = "0xEB6DCC")]
		public void UpdateTextureAtlasData(string name, List<object> textureAtlases)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xEB6F78", Offset = "0xEB6F78", VA = "0xEB6F78")]
		public DragonBonesData GetDragonBonesData(string name)
		{
			return null;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xEB6BB8", Offset = "0xEB6BB8", VA = "0xEB6BB8")]
		public void AddDragonBonesData(DragonBonesData data, [Optional] string name)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xEB7014", Offset = "0xEB7014", VA = "0xEB7014", Slot = "8")]
		public virtual void RemoveDragonBonesData(string name, bool disposeData = true)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xEB6EDC", Offset = "0xEB6EDC", VA = "0xEB6EDC")]
		public List<TextureAtlasData> GetTextureAtlasData(string name)
		{
			return null;
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xEB6A34", Offset = "0xEB6A34", VA = "0xEB6A34")]
		public void AddTextureAtlasData(TextureAtlasData data, [Optional] string name)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xEB70FC", Offset = "0xEB70FC", VA = "0xEB70FC", Slot = "9")]
		public virtual void RemoveTextureAtlasData(string name, bool disposeData = true)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xEB72A4", Offset = "0xEB72A4", VA = "0xEB72A4", Slot = "10")]
		public virtual ArmatureData GetArmatureData(string name, string dragonBonesName = "")
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xEB7354", Offset = "0xEB7354", VA = "0xEB7354", Slot = "11")]
		public virtual void Clear(bool disposeData = true)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xEB778C", Offset = "0xEB778C", VA = "0xEB778C", Slot = "12")]
		public virtual Armature BuildArmature(string armatureName, string dragonBonesName = "", [Optional] string skinName, [Optional] string textureAtlasName)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xEB7948", Offset = "0xEB7948", VA = "0xEB7948", Slot = "13")]
		public virtual void ReplaceDisplay(Slot slot, DisplayData displayData, int displayIndex = -1)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xEB7B38", Offset = "0xEB7B38", VA = "0xEB7B38")]
		public bool ReplaceSlotDisplay(string dragonBonesName, string armatureName, string slotName, string displayName, Slot slot, int displayIndex = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xEB7BD0", Offset = "0xEB7BD0", VA = "0xEB7BD0")]
		public bool ReplaceSlotDisplayList(string dragonBonesName, string armatureName, string slotName, Slot slot)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xEB7CD4", Offset = "0xEB7CD4", VA = "0xEB7CD4")]
		public bool ReplaceSkin(Armature armature, SkinData skin, bool isOverride = false, [Optional] List<string> exclude)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xEB80DC", Offset = "0xEB80DC", VA = "0xEB80DC")]
		public bool ReplaceAnimation(Armature armature, ArmatureData armatureData, bool isOverride = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xEB8828", Offset = "0xEB8828", VA = "0xEB8828")]
		public Dictionary<string, DragonBonesData> GetAllDragonBonesData()
		{
			return null;
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xEB8830", Offset = "0xEB8830", VA = "0xEB8830")]
		public Dictionary<string, List<TextureAtlasData>> GetAllTextureAtlasData()
		{
			return null;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xEB8854", Offset = "0xEB8854", VA = "0xEB8854")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x73EFC4", Offset = "0x73EFC4")]
		public bool ChangeSkin(Armature armature, SkinData skin, [Optional] List<string> exclude)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200014D")]
	public class ColorTransform
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float alphaMultiplier;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float redMultiplier;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float greenMultiplier;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blueMultiplier;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int alphaOffset;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int redOffset;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int greenOffset;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int blueOffset;

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xCFEA44", Offset = "0xCFEA44", VA = "0xCFEA44")]
		public ColorTransform()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xCFEA54", Offset = "0xCFEA54", VA = "0xCFEA54")]
		public void CopyFrom(ColorTransform value)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xCFEAA8", Offset = "0xCFEAA8", VA = "0xCFEAA8")]
		public void Identity()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class Matrix
	{
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float a;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float b;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float c;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float d;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float tx;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ty;

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x146A940", Offset = "0x146A940", VA = "0x146A940")]
		public Matrix()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x146A954", Offset = "0x146A954", VA = "0x146A954", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x146AD4C", Offset = "0x146AD4C", VA = "0x146AD4C")]
		public Matrix CopyFrom(Matrix value)
		{
			return null;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x146AD90", Offset = "0x146AD90", VA = "0x146AD90")]
		public Matrix CopyFromArray(List<float> value, int offset = 0)
		{
			return null;
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x146AED4", Offset = "0x146AED4", VA = "0x146AED4")]
		public Matrix Identity()
		{
			return null;
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x146AEE8", Offset = "0x146AEE8", VA = "0x146AEE8")]
		public Matrix Concat(Matrix value)
		{
			return null;
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x146AFB4", Offset = "0x146AFB4", VA = "0x146AFB4")]
		public Matrix Invert()
		{
			return null;
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x146B08C", Offset = "0x146B08C", VA = "0x146B08C")]
		public void TransformPoint(float x, float y, Point result, bool delta = false)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x146B0EC", Offset = "0x146B0EC", VA = "0x146B0EC")]
		public void TransformRectangle(Rectangle rectangle, bool delta = false)
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class Point
	{
		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float x;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float y;

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1479834", Offset = "0x1479834", VA = "0x1479834")]
		public Point()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x147983C", Offset = "0x147983C", VA = "0x147983C")]
		public void CopyFrom(Point value)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1479860", Offset = "0x1479860", VA = "0x1479860")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class Rectangle
	{
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float x;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float y;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float width;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float height;

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x147A48C", Offset = "0x147A48C", VA = "0x147A48C")]
		public Rectangle()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x147A494", Offset = "0x147A494", VA = "0x147A494")]
		public void CopyFrom(Rectangle value)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x147A4C8", Offset = "0x147A4C8", VA = "0x147A4C8")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class Transform
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float PI;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly float PI_D;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly float PI_H;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly float PI_Q;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly float RAD_DEG;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly float DEG_RAD;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float x;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float y;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float skew;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rotation;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scaleX;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float scaleY;

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1484928", Offset = "0x1484928", VA = "0x1484928")]
		public static float NormalizeRadian(float value)
		{
			return default(float);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x14849FC", Offset = "0x14849FC", VA = "0x14849FC")]
		public Transform()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1484A0C", Offset = "0x1484A0C", VA = "0x1484A0C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x148147C", Offset = "0x148147C", VA = "0x148147C")]
		public Transform CopyFrom(Transform value)
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1484E98", Offset = "0x1484E98", VA = "0x1484E98")]
		public Transform Identity()
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x14814C0", Offset = "0x14814C0", VA = "0x14814C0")]
		public Transform Add(Transform value)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1484EA8", Offset = "0x1484EA8", VA = "0x1484EA8")]
		public Transform Minus(Transform value)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x14809A0", Offset = "0x14809A0", VA = "0x14809A0")]
		public Transform FromMatrix(Matrix matrix)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1480240", Offset = "0x1480240", VA = "0x1480240")]
		public Transform ToMatrix(Matrix matrix)
		{
			return null;
		}
	}
	[Token(Token = "0x2000152")]
	public class AnimationConfig : BaseObject
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool pauseFadeOut;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationFadeOutMode fadeOutMode;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweenType fadeOutTweenType;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeOutTime;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool pauseFadeIn;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool actionEnabled;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool additiveBlending;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool displayControl;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool resetToPose;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TweenType fadeInTweenType;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int playTimes;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int layer;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float position;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float duration;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float timeScale;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float weight;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float fadeInTime;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float autoFadeOutTime;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string name;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string animation;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string group;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public readonly List<string> boneMask;

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xEAAC6C", Offset = "0xEAAC6C", VA = "0xEAAC6C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xEA7F08", Offset = "0xEA7F08", VA = "0xEA7F08")]
		public void Clear()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xEAAD50", Offset = "0xEAAD50", VA = "0xEAAD50")]
		public void CopyFrom(AnimationConfig value)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xEAAF60", Offset = "0xEAAF60", VA = "0xEAAF60")]
		public bool ContainsBoneMask(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xEAAFEC", Offset = "0xEAAFEC", VA = "0xEAAFEC")]
		public void AddBoneMask(Armature armature, string boneName, bool recursive = false)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xEAB2F0", Offset = "0xEAB2F0", VA = "0xEAB2F0")]
		public void RemoveBoneMask(Armature armature, string name, bool recursive = true)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xEAB550", Offset = "0xEAB550", VA = "0xEAB550")]
		public AnimationConfig()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class AnimationData : BaseObject
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint frameIntOffset;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint frameFloatOffset;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint frameOffset;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint frameCount;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint playTimes;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float scale;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float fadeInTime;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float cacheFrameRate;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string name;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly List<bool> cachedFrames;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly Dictionary<string, List<TimelineData>> boneTimelines;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly Dictionary<string, List<TimelineData>> slotTimelines;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly Dictionary<string, List<TimelineData>> constraintTimelines;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public readonly Dictionary<string, List<int>> boneCachedFrameIndices;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public readonly Dictionary<string, List<int>> slotCachedFrameIndices;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TimelineData actionTimeline;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TimelineData zOrderTimeline;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public ArmatureData parent;

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xEAB5FC", Offset = "0xEAB5FC", VA = "0xEAB5FC")]
		public AnimationData()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xEAB7C0", Offset = "0xEAB7C0", VA = "0xEAB7C0", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xEABCDC", Offset = "0xEABCDC", VA = "0xEABCDC")]
		public void CacheFrames(float frameRate)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xEAC1D0", Offset = "0xEAC1D0", VA = "0xEAC1D0")]
		public void AddBoneTimeline(BoneData bone, TimelineData tiemline)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xEAC348", Offset = "0xEAC348", VA = "0xEAC348")]
		public void AddSlotTimeline(SlotData slot, TimelineData timeline)
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xEAC4C0", Offset = "0xEAC4C0", VA = "0xEAC4C0")]
		public void AddConstraintTimeline(ConstraintData constraint, TimelineData timeline)
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xEAC638", Offset = "0xEAC638", VA = "0xEAC638")]
		public List<TimelineData> GetBoneTimelines(string timelineName)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xEAC6D4", Offset = "0xEAC6D4", VA = "0xEAC6D4")]
		public List<TimelineData> GetSlotTimelines(string timelineName)
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xEAC770", Offset = "0xEAC770", VA = "0xEAC770")]
		public List<TimelineData> GetConstraintTimelines(string timelineName)
		{
			return null;
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xEA749C", Offset = "0xEA749C", VA = "0xEA749C")]
		public List<int> GetBoneCachedFrameIndices(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xEA7538", Offset = "0xEA7538", VA = "0xEA7538")]
		public List<int> GetSlotCachedFrameIndices(string slotName)
		{
			return null;
		}
	}
	[Token(Token = "0x2000154")]
	public class TimelineData : BaseObject
	{
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TimelineType type;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint offset;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int frameIndicesOffset;

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x14842C0", Offset = "0x14842C0", VA = "0x14842C0", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x14842D8", Offset = "0x14842D8", VA = "0x14842D8")]
		public TimelineData()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class ArmatureData : BaseObject
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ArmatureType type;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint frameRate;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint cacheFrameRate;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scale;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Rectangle aabb;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly List<string> animationNames;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly List<BoneData> sortedBones;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly List<SlotData> sortedSlots;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly List<ActionData> defaultActions;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly List<ActionData> actions;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public readonly Dictionary<string, BoneData> bones;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public readonly Dictionary<string, SlotData> slots;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public readonly Dictionary<string, ConstraintData> constraints;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public readonly Dictionary<string, SkinData> skins;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public readonly Dictionary<string, AnimationData> animations;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public SkinData defaultSkin;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AnimationData defaultAnimation;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public CanvasData canvas;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UserData userData;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public DragonBonesData parent;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xEB1CDC", Offset = "0xEB1CDC", VA = "0xEB1CDC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xEB281C", Offset = "0xEB281C", VA = "0xEB281C")]
		public void SortBones()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xEB1690", Offset = "0xEB1690", VA = "0xEB1690")]
		public void CacheFrames(uint frameRate)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xEB2B3C", Offset = "0xEB2B3C", VA = "0xEB2B3C")]
		public int SetCacheFrame(Matrix globalTransformMatrix, Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xEB2CE4", Offset = "0xEB2CE4", VA = "0xEB2CE4")]
		public void GetCacheFrame(Matrix globalTransformMatrix, Transform transform, int arrayOffset)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xEB2EF4", Offset = "0xEB2EF4", VA = "0xEB2EF4")]
		public void AddBone(BoneData value)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xEB306C", Offset = "0xEB306C", VA = "0xEB306C")]
		public void AddSlot(SlotData value)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xEB31E4", Offset = "0xEB31E4", VA = "0xEB31E4")]
		public void AddConstraint(ConstraintData value)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xEB3334", Offset = "0xEB3334", VA = "0xEB3334")]
		public void AddSkin(SkinData value)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xEB34E4", Offset = "0xEB34E4", VA = "0xEB34E4")]
		public void AddAnimation(AnimationData value)
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xEB3684", Offset = "0xEB3684", VA = "0xEB3684")]
		internal void AddAction(ActionData value, bool isDefault)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xEB36F8", Offset = "0xEB36F8", VA = "0xEB36F8")]
		public BoneData GetBone(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xEB37AC", Offset = "0xEB37AC", VA = "0xEB37AC")]
		public SlotData GetSlot(string slotName)
		{
			return null;
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xEB3860", Offset = "0xEB3860", VA = "0xEB3860")]
		public ConstraintData GetConstraint(string constraintName)
		{
			return null;
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xEB38FC", Offset = "0xEB38FC", VA = "0xEB38FC")]
		public SkinData GetSkin(string skinName)
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xEB39B0", Offset = "0xEB39B0", VA = "0xEB39B0")]
		public MeshDisplayData GetMesh(string skinName, string slotName, string meshName)
		{
			return null;
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xEB3A68", Offset = "0xEB3A68", VA = "0xEB3A68")]
		public AnimationData GetAnimation(string animationName)
		{
			return null;
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xEB3B1C", Offset = "0xEB3B1C", VA = "0xEB3B1C")]
		public ArmatureData()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class BoneData : BaseObject
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool inheritTranslation;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool inheritRotation;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool inheritScale;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public bool inheritReflection;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float length;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Transform transform;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UserData userData;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BoneData parent;

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xCFBE18", Offset = "0xCFBE18", VA = "0xCFBE18", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xCFBEB4", Offset = "0xCFBEB4", VA = "0xCFBEB4")]
		public BoneData()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class SurfaceData : BoneData
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float vertexCountX;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float vertexCountY;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly List<float> vertices;

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x14837D8", Offset = "0x14837D8", VA = "0x14837D8", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x148383C", Offset = "0x148383C", VA = "0x148383C")]
		public SurfaceData()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class SlotData : BaseObject
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ColorTransform DEFAULT_COLOR;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BlendMode blendMode;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int displayIndex;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int zOrder;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ColorTransform color;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UserData userData;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BoneData parent;

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1483538", Offset = "0x1483538", VA = "0x1483538")]
		public static ColorTransform CreateColor()
		{
			return null;
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1483590", Offset = "0x1483590", VA = "0x1483590", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x148362C", Offset = "0x148362C", VA = "0x148362C")]
		public SlotData()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public abstract class BoundingBoxData : BaseObject
	{
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BoundingBoxType type;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint color;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float width;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float height;

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xCFDC9C", Offset = "0xCFDC9C", VA = "0xCFDC9C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60007FE")]
		public abstract bool ContainsPoint(float pX, float pY);

		[Token(Token = "0x60007FF")]
		public abstract int IntersectsSegment(float xA, float yA, float xB, float yB, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians);

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xCFDCA8", Offset = "0xCFDCA8", VA = "0xCFDCA8")]
		protected BoundingBoxData()
		{
		}
	}
	[Token(Token = "0x200015A")]
	internal enum OutCode
	{
		[Token(Token = "0x4000431")]
		InSide = 0,
		[Token(Token = "0x4000432")]
		Left = 1,
		[Token(Token = "0x4000433")]
		Right = 2,
		[Token(Token = "0x4000434")]
		Top = 4,
		[Token(Token = "0x4000435")]
		Bottom = 8
	}
	[Token(Token = "0x200015B")]
	public class RectangleBoundingBoxData : BoundingBoxData
	{
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x147A4D0", Offset = "0x147A4D0", VA = "0x147A4D0")]
		private static int _ComputeOutCode(float x, float y, float xMin, float yMin, float xMax, float yMax)
		{
			return default(int);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x147A0F8", Offset = "0x147A0F8", VA = "0x147A0F8")]
		public static int RectangleIntersectsSegment(float xA, float yA, float xB, float yB, float xMin, float yMin, float xMax, float yMax, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x147A514", Offset = "0x147A514", VA = "0x147A514", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x147A53C", Offset = "0x147A53C", VA = "0x147A53C", Slot = "5")]
		public override bool ContainsPoint(float pX, float pY)
		{
			return default(bool);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x147A58C", Offset = "0x147A58C", VA = "0x147A58C", Slot = "6")]
		public override int IntersectsSegment(float xA, float yA, float xB, float yB, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x147A5B8", Offset = "0x147A5B8", VA = "0x147A5B8")]
		public RectangleBoundingBoxData()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class EllipseBoundingBoxData : BoundingBoxData
	{
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1467568", Offset = "0x1467568", VA = "0x1467568")]
		public static int EllipseIntersectsSegment(float xA, float yA, float xB, float yB, float xC, float yC, float widthH, float heightH, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x146790C", Offset = "0x146790C", VA = "0x146790C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1467938", Offset = "0x1467938", VA = "0x1467938", Slot = "5")]
		public override bool ContainsPoint(float pX, float pY)
		{
			return default(bool);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1467A2C", Offset = "0x1467A2C", VA = "0x1467A2C", Slot = "6")]
		public override int IntersectsSegment(float xA, float yA, float xB, float yB, Point intersectionPointA, Point intersectionPointB, Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1467A54", Offset = "0x1467A54", VA = "0x1467A54")]
		public EllipseBoundingBoxData()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class PolygonBoundingBoxData : BoundingBoxData
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float x;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float y;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly List<float> vertices;

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1479868", Offset = "0x1479868", VA = "0x1479868")]
		public static int PolygonIntersectsSegment(float xA, float yA, float xB, float yB, List<float> vertices, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1479DB4", Offset = "0x1479DB4", VA = "0x1479DB4", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1479E20", Offset = "0x1479E20", VA = "0x1479E20", Slot = "5")]
		public override bool ContainsPoint(float pX, float pY)
		{
			return default(bool);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x147A044", Offset = "0x147A044", VA = "0x147A044", Slot = "6")]
		public override int IntersectsSegment(float xA, float yA, float xB, float yB, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x147A408", Offset = "0x147A408", VA = "0x147A408")]
		public PolygonBoundingBoxData()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class CanvasData : BaseObject
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool hasBackground;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int color;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float x;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float y;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float width;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float height;

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xCFE948", Offset = "0xCFE948", VA = "0xCFE948", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xCFE958", Offset = "0xCFE958", VA = "0xCFE958")]
		public CanvasData()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public abstract class ConstraintData : BaseObject
	{
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int order;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoneData target;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BoneData root;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BoneData bone;

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xCFF660", Offset = "0xCFF660", VA = "0xCFF660", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xCFF6EC", Offset = "0xCFF6EC", VA = "0xCFF6EC")]
		protected ConstraintData()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class IKConstraintData : ConstraintData
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool scaleEnabled;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool bendPositive;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float weight;

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1469ABC", Offset = "0x1469ABC", VA = "0x1469ABC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1469AEC", Offset = "0x1469AEC", VA = "0x1469AEC")]
		public IKConstraintData()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class VerticesData
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isShared;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool inheritDeform;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int offset;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DragonBonesData data;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WeightData weight;

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1014DF8", Offset = "0x1014DF8", VA = "0x1014DF8")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1014E54", Offset = "0x1014E54", VA = "0x1014E54")]
		public void ShareFrom(VerticesData value)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1014E88", Offset = "0x1014E88", VA = "0x1014E88")]
		public VerticesData()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public abstract class DisplayData : BaseObject
	{
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public DisplayType type;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SkinData parent;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Transform transform;

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xD60834", Offset = "0xD60834", VA = "0xD60834", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xD608C4", Offset = "0xD608C4", VA = "0xD608C4")]
		protected DisplayData()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class ImageDisplayData : DisplayData
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly Point pivot;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextureData texture;

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1469DB8", Offset = "0x1469DB8", VA = "0x1469DB8", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1469E00", Offset = "0x1469E00", VA = "0x1469E00")]
		public ImageDisplayData()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class ArmatureDisplayData : DisplayData
	{
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool inheritAnimation;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly List<ActionData> actions;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ArmatureData armature;

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xEB3E98", Offset = "0xEB3E98", VA = "0xEB3E98", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xEB3FF8", Offset = "0xEB3FF8", VA = "0xEB3FF8")]
		internal void AddAction(ActionData value)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xEB405C", Offset = "0xEB405C", VA = "0xEB405C")]
		public ArmatureDisplayData()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class MeshDisplayData : DisplayData
	{
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly VerticesData vertices;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextureData texture;

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x146DE3C", Offset = "0x146DE3C", VA = "0x146DE3C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x146DE88", Offset = "0x146DE88", VA = "0x146DE88")]
		public MeshDisplayData()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public class BoundingBoxDisplayData : DisplayData
	{
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BoundingBoxData boundingBox;

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xCFDD0C", Offset = "0xCFDD0C", VA = "0xCFDD0C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xCFDD58", Offset = "0xCFDD58", VA = "0xCFDD58")]
		public BoundingBoxDisplayData()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class PathDisplayData : DisplayData
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool closed;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool constantSpeed;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly VerticesData vertices;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly List<float> curveLengths;

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x14792D0", Offset = "0x14792D0", VA = "0x14792D0", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x147934C", Offset = "0x147934C", VA = "0x147934C")]
		public PathDisplayData()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class WeightData : BaseObject
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int count;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int offset;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<BoneData> bones;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1014E90", Offset = "0x1014E90", VA = "0x1014E90", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1014EE8", Offset = "0x1014EE8", VA = "0x1014EE8")]
		internal void AddBone(BoneData value)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x1014F4C", Offset = "0x1014F4C", VA = "0x1014F4C")]
		public WeightData()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class DragonBonesData : BaseObject
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool autoSearch;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint frameRate;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string version;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ArmatureData stage;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly List<uint> frameIndices;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly List<float> cachedFrames;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly List<string> armatureNames;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly Dictionary<string, ArmatureData> armatures;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal byte[] binary;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal short[] intArray;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal float[] floatArray;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal short[] frameIntArray;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal float[] frameFloatArray;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal short[] frameArray;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal ushort[] timelineArray;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal UserData userData;

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xD6110C", Offset = "0xD6110C", VA = "0xD6110C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xD613FC", Offset = "0xD613FC", VA = "0xD613FC")]
		public void AddArmature(ArmatureData value)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xD61568", Offset = "0xD61568", VA = "0xD61568")]
		public ArmatureData GetArmature(string armatureName)
		{
			return null;
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xD61604", Offset = "0xD61604", VA = "0xD61604")]
		public DragonBonesData()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class SkinData : BaseObject
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Dictionary<string, List<DisplayData>> displays;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArmatureData parent;

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x147EA9C", Offset = "0x147EA9C", VA = "0x147EA9C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x147EDCC", Offset = "0x147EDCC", VA = "0x147EDCC")]
		public void AddDisplay(string slotName, DisplayData value)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x147EF40", Offset = "0x147EF40", VA = "0x147EF40")]
		public DisplayData GetDisplay(string slotName, string displayName)
		{
			return null;
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x147F08C", Offset = "0x147F08C", VA = "0x147F08C")]
		public List<DisplayData> GetDisplays(string slotName)
		{
			return null;
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x147F140", Offset = "0x147F140", VA = "0x147F140")]
		public SkinData()
		{
		}
	}
	[Token(Token = "0x200016B")]
	public abstract class TextureAtlasData : BaseObject
	{
		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool autoSearch;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint width;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint height;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scale;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string imagePath;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly Dictionary<string, TextureData> textures;

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x14838C0", Offset = "0x14838C0", VA = "0x14838C0")]
		public TextureAtlasData()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x1483970", Offset = "0x1483970", VA = "0x1483970", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x1483B10", Offset = "0x1483B10", VA = "0x1483B10")]
		public void CopyFrom(TextureAtlasData value)
		{
		}

		[Token(Token = "0x6000836")]
		public abstract TextureData CreateTexture();

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x1483E70", Offset = "0x1483E70", VA = "0x1483E70")]
		public void AddTexture(TextureData value)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x1483FC4", Offset = "0x1483FC4", VA = "0x1483FC4")]
		public TextureData GetTexture(string name)
		{
			return null;
		}
	}
	[Token(Token = "0x200016C")]
	public abstract class TextureData : BaseObject
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool rotated;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Rectangle region;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextureAtlasData parent;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rectangle frame;

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x1484060", Offset = "0x1484060", VA = "0x1484060")]
		public static Rectangle CreateRectangle()
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x14840B8", Offset = "0x14840B8", VA = "0x14840B8", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x148413C", Offset = "0x148413C", VA = "0x148413C", Slot = "5")]
		public virtual void CopyFrom(TextureData value)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x1484224", Offset = "0x1484224", VA = "0x1484224")]
		protected TextureData()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class UserData : BaseObject
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<int> ints;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<float> floats;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly List<string> strings;

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x1014914", Offset = "0x1014914", VA = "0x1014914", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x10149B0", Offset = "0x10149B0", VA = "0x10149B0")]
		internal void AddInt(int value)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x1014A14", Offset = "0x1014A14", VA = "0x1014A14")]
		internal void AddFloat(float value)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x1014A78", Offset = "0x1014A78", VA = "0x1014A78")]
		internal void AddString(string value)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1014ADC", Offset = "0x1014ADC", VA = "0x1014ADC")]
		public int GetInt(int index = 0)
		{
			return default(int);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x1014B6C", Offset = "0x1014B6C", VA = "0x1014B6C")]
		public float GetFloat(int index = 0)
		{
			return default(float);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1014BF8", Offset = "0x1014BF8", VA = "0x1014BF8")]
		public string GetString(int index = 0)
		{
			return null;
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1014CA4", Offset = "0x1014CA4", VA = "0x1014CA4")]
		public UserData()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class ActionData : BaseObject
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ActionType type;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoneData bone;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SlotData slot;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UserData data;

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xEA5114", Offset = "0xEA5114", VA = "0xEA5114", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xEA5218", Offset = "0xEA5218", VA = "0xEA5218")]
		public ActionData()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class BinaryDataParser : ObjectDataParser
	{
		[Token(Token = "0x2000170")]
		public delegate object JsonParseDelegate(string json);

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static JsonParseDelegate jsonParseDelegate;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int _binaryOffset;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private byte[] _binary;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private short[] _intArrayBuffer;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float[] _floatArrayBuffer;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private short[] _frameIntArrayBuffer;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float[] _frameFloatArrayBuffer;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private short[] _frameArrayBuffer;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private ushort[] _timelineArrayBuffer;

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xEB93C8", Offset = "0xEB93C8", VA = "0xEB93C8")]
		private TimelineData _ParseBinaryTimeline(TimelineType type, uint offset, [Optional] TimelineData timelineData)
		{
			return null;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xEB9694", Offset = "0xEB9694", VA = "0xEB9694")]
		private void _ParseVertices(Dictionary<string, object> rawData, VerticesData vertices)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xEB9920", Offset = "0xEB9920", VA = "0xEB9920", Slot = "6")]
		protected override void _ParseMesh(Dictionary<string, object> rawData, MeshDisplayData mesh)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xEB9938", Offset = "0xEB9938", VA = "0xEB9938", Slot = "7")]
		protected override AnimationData _ParseAnimation(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xEBA6CC", Offset = "0xEBA6CC", VA = "0xEBA6CC", Slot = "8")]
		protected override void _ParseArray(Dictionary<string, object> rawData)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xEBAED0", Offset = "0xEBAED0", VA = "0xEBAED0", Slot = "4")]
		public override DragonBonesData ParseDragonBonesData(object rawObj, float scale = 1f)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xEBB02C", Offset = "0xEBB02C", VA = "0xEBB02C")]
		public static Dictionary<string, object> DeserializeBinaryJsonData(byte[] bytes, out int headerLength, [Optional] JsonParseDelegate jsonParse)
		{
			return null;
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xEB51A8", Offset = "0xEB51A8", VA = "0xEB51A8")]
		public BinaryDataParser()
		{
		}
	}
	[Token(Token = "0x2000171")]
	internal class BinaryDataReader : BinaryReader
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int i;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int readLength;

		[Token(Token = "0x17000073")]
		private long Length
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xCF9F94", Offset = "0xCF9F94", VA = "0xCF9F94")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xCF927C", Offset = "0xCF927C", VA = "0xCF927C")]
		internal BinaryDataReader(Stream stream)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xCF9284", Offset = "0xCF9284", VA = "0xCF9284")]
		internal BinaryDataReader(Stream stream, Encoding encoding)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xCF928C", Offset = "0xCF928C", VA = "0xCF928C", Slot = "27")]
		public virtual void Seek(int offset, SeekOrigin origin = SeekOrigin.Current)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xCF92E4", Offset = "0xCF92E4", VA = "0xCF92E4", Slot = "28")]
		public virtual bool[] ReadBooleans(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xCF93CC", Offset = "0xCF93CC", VA = "0xCF93CC", Slot = "29")]
		public virtual byte[] ReadBytes(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xCF94B0", Offset = "0xCF94B0", VA = "0xCF94B0", Slot = "30")]
		public virtual char[] ReadChars(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xCF9594", Offset = "0xCF9594", VA = "0xCF9594", Slot = "31")]
		public virtual decimal[] ReadDecimals(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xCF967C", Offset = "0xCF967C", VA = "0xCF967C", Slot = "32")]
		public virtual double[] ReadDoubles(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xCF9760", Offset = "0xCF9760", VA = "0xCF9760", Slot = "33")]
		public virtual short[] ReadInt16s(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xCF9844", Offset = "0xCF9844", VA = "0xCF9844", Slot = "34")]
		public virtual int[] ReadInt32s(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xCF9928", Offset = "0xCF9928", VA = "0xCF9928", Slot = "35")]
		public virtual long[] ReadInt64s(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xCF9A0C", Offset = "0xCF9A0C", VA = "0xCF9A0C", Slot = "36")]
		public virtual sbyte[] ReadSBytes(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xCF9AF0", Offset = "0xCF9AF0", VA = "0xCF9AF0", Slot = "37")]
		public virtual float[] ReadSingles(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xCF9BD4", Offset = "0xCF9BD4", VA = "0xCF9BD4", Slot = "38")]
		public virtual string[] ReadStrings(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xCF9CE8", Offset = "0xCF9CE8", VA = "0xCF9CE8", Slot = "39")]
		public virtual ushort[] ReadUInt16s(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xCF9DCC", Offset = "0xCF9DCC", VA = "0xCF9DCC", Slot = "40")]
		public virtual uint[] ReadUInt32s(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xCF9EB0", Offset = "0xCF9EB0", VA = "0xCF9EB0", Slot = "41")]
		public virtual ulong[] ReadUInt64s(int offset, int readLength)
		{
			return null;
		}
	}
	[Token(Token = "0x2000172")]
	internal class BinaryDataWriter : BinaryWriter
	{
		[Token(Token = "0x17000074")]
		private long Length
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0xCFA8B4", Offset = "0xCFA8B4", VA = "0xCFA8B4")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xCF9FC0", Offset = "0xCF9FC0", VA = "0xCF9FC0")]
		public BinaryDataWriter()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xCFA054", Offset = "0xCFA054", VA = "0xCFA054")]
		internal BinaryDataWriter(Stream stream)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xCFA0C8", Offset = "0xCFA0C8", VA = "0xCFA0C8")]
		public BinaryDataWriter(Encoding encoding)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xCFA16C", Offset = "0xCFA16C", VA = "0xCFA16C")]
		internal BinaryDataWriter(Stream stream, Encoding encoding)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xCFA1E8", Offset = "0xCFA1E8", VA = "0xCFA1E8", Slot = "25")]
		public virtual void Write(bool[] value)
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xCFA264", Offset = "0xCFA264", VA = "0xCFA264", Slot = "11")]
		public override void Write(byte[] value)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xCFA2E0", Offset = "0xCFA2E0", VA = "0xCFA2E0", Slot = "14")]
		public override void Write(char[] value)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xCFA35C", Offset = "0xCFA35C", VA = "0xCFA35C", Slot = "26")]
		public virtual void Write(decimal[] value)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xCFA3DC", Offset = "0xCFA3DC", VA = "0xCFA3DC", Slot = "27")]
		public virtual void Write(double[] value)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xCFA458", Offset = "0xCFA458", VA = "0xCFA458", Slot = "28")]
		public virtual void Write(short[] value)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xCFA4D4", Offset = "0xCFA4D4", VA = "0xCFA4D4", Slot = "29")]
		public virtual void Write(int[] value)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xCFA550", Offset = "0xCFA550", VA = "0xCFA550", Slot = "30")]
		public virtual void Write(long[] value)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xCFA5CC", Offset = "0xCFA5CC", VA = "0xCFA5CC", Slot = "31")]
		public virtual void Write(sbyte[] value)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xCFA648", Offset = "0xCFA648", VA = "0xCFA648", Slot = "32")]
		public virtual void Write(float[] value)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xCFA6C4", Offset = "0xCFA6C4", VA = "0xCFA6C4", Slot = "33")]
		public virtual void Write(string[] value)
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xCFA740", Offset = "0xCFA740", VA = "0xCFA740", Slot = "34")]
		public virtual void Write(ushort[] value)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xCFA7BC", Offset = "0xCFA7BC", VA = "0xCFA7BC", Slot = "35")]
		public virtual void Write(uint[] value)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xCFA838", Offset = "0xCFA838", VA = "0xCFA838", Slot = "36")]
		public virtual void Write(ulong[] value)
		{
		}
	}
	[Token(Token = "0x2000173")]
	public abstract class DataParser
	{
		[Token(Token = "0x4000493")]
		protected const string DATA_VERSION_2_3 = "2.3";

		[Token(Token = "0x4000494")]
		protected const string DATA_VERSION_3_0 = "3.0";

		[Token(Token = "0x4000495")]
		protected const string DATA_VERSION_4_0 = "4.0";

		[Token(Token = "0x4000496")]
		protected const string DATA_VERSION_4_5 = "4.5";

		[Token(Token = "0x4000497")]
		protected const string DATA_VERSION_5_0 = "5.0";

		[Token(Token = "0x4000498")]
		protected const string DATA_VERSION_5_5 = "5.5";

		[Token(Token = "0x4000499")]
		protected const string DATA_VERSION = "5.5";

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly List<string> DATA_VERSIONS;

		[Token(Token = "0x400049B")]
		protected const string TEXTURE_ATLAS = "textureAtlas";

		[Token(Token = "0x400049C")]
		protected const string SUB_TEXTURE = "SubTexture";

		[Token(Token = "0x400049D")]
		protected const string FORMAT = "format";

		[Token(Token = "0x400049E")]
		protected const string IMAGE_PATH = "imagePath";

		[Token(Token = "0x400049F")]
		protected const string WIDTH = "width";

		[Token(Token = "0x40004A0")]
		protected const string HEIGHT = "height";

		[Token(Token = "0x40004A1")]
		protected const string ROTATED = "rotated";

		[Token(Token = "0x40004A2")]
		protected const string FRAME_X = "frameX";

		[Token(Token = "0x40004A3")]
		protected const string FRAME_Y = "frameY";

		[Token(Token = "0x40004A4")]
		protected const string FRAME_WIDTH = "frameWidth";

		[Token(Token = "0x40004A5")]
		protected const string FRAME_HEIGHT = "frameHeight";

		[Token(Token = "0x40004A6")]
		protected const string DRADON_BONES = "dragonBones";

		[Token(Token = "0x40004A7")]
		protected const string USER_DATA = "userData";

		[Token(Token = "0x40004A8")]
		protected const string ARMATURE = "armature";

		[Token(Token = "0x40004A9")]
		protected const string BONE = "bone";

		[Token(Token = "0x40004AA")]
		protected const string SLOT = "slot";

		[Token(Token = "0x40004AB")]
		protected const string CONSTRAINT = "constraint";

		[Token(Token = "0x40004AC")]
		protected const string IK = "ik";

		[Token(Token = "0x40004AD")]
		protected const string SKIN = "skin";

		[Token(Token = "0x40004AE")]
		protected const string DISPLAY = "display";

		[Token(Token = "0x40004AF")]
		protected const string ANIMATION = "animation";

		[Token(Token = "0x40004B0")]
		protected const string Z_ORDER = "zOrder";

		[Token(Token = "0x40004B1")]
		protected const string FFD = "ffd";

		[Token(Token = "0x40004B2")]
		protected const string FRAME = "frame";

		[Token(Token = "0x40004B3")]
		protected const string TRANSLATE_FRAME = "translateFrame";

		[Token(Token = "0x40004B4")]
		protected const string ROTATE_FRAME = "rotateFrame";

		[Token(Token = "0x40004B5")]
		protected const string SCALE_FRAME = "scaleFrame";

		[Token(Token = "0x40004B6")]
		protected const string DISPLAY_FRAME = "displayFrame";

		[Token(Token = "0x40004B7")]
		protected const string COLOR_FRAME = "colorFrame";

		[Token(Token = "0x40004B8")]
		protected const string DEFAULT_ACTIONS = "defaultActions";

		[Token(Token = "0x40004B9")]
		protected const string ACTIONS = "actions";

		[Token(Token = "0x40004BA")]
		protected const string EVENTS = "events";

		[Token(Token = "0x40004BB")]
		protected const string INTS = "ints";

		[Token(Token = "0x40004BC")]
		protected const string FLOATS = "floats";

		[Token(Token = "0x40004BD")]
		protected const string STRINGS = "strings";

		[Token(Token = "0x40004BE")]
		protected const string CANVAS = "canvas";

		[Token(Token = "0x40004BF")]
		protected const string TRANSFORM = "transform";

		[Token(Token = "0x40004C0")]
		protected const string PIVOT = "pivot";

		[Token(Token = "0x40004C1")]
		protected const string AABB = "aabb";

		[Token(Token = "0x40004C2")]
		protected const string COLOR = "color";

		[Token(Token = "0x40004C3")]
		protected const string VERSION = "version";

		[Token(Token = "0x40004C4")]
		protected const string COMPATIBLE_VERSION = "compatibleVersion";

		[Token(Token = "0x40004C5")]
		protected const string FRAME_RATE = "frameRate";

		[Token(Token = "0x40004C6")]
		protected const string TYPE = "type";

		[Token(Token = "0x40004C7")]
		protected const string SUB_TYPE = "subType";

		[Token(Token = "0x40004C8")]
		protected const string NAME = "name";

		[Token(Token = "0x40004C9")]
		protected const string PARENT = "parent";

		[Token(Token = "0x40004CA")]
		protected const string TARGET = "target";

		[Token(Token = "0x40004CB")]
		protected const string STAGE = "stage";

		[Token(Token = "0x40004CC")]
		protected const string SHARE = "share";

		[Token(Token = "0x40004CD")]
		protected const string PATH = "path";

		[Token(Token = "0x40004CE")]
		protected const string LENGTH = "length";

		[Token(Token = "0x40004CF")]
		protected const string DISPLAY_INDEX = "displayIndex";

		[Token(Token = "0x40004D0")]
		protected const string BLEND_MODE = "blendMode";

		[Token(Token = "0x40004D1")]
		protected const string INHERIT_TRANSLATION = "inheritTranslation";

		[Token(Token = "0x40004D2")]
		protected const string INHERIT_ROTATION = "inheritRotation";

		[Token(Token = "0x40004D3")]
		protected const string INHERIT_SCALE = "inheritScale";

		[Token(Token = "0x40004D4")]
		protected const string INHERIT_REFLECTION = "inheritReflection";

		[Token(Token = "0x40004D5")]
		protected const string INHERIT_ANIMATION = "inheritAnimation";

		[Token(Token = "0x40004D6")]
		protected const string INHERIT_DEFORM = "inheritDeform";

		[Token(Token = "0x40004D7")]
		protected const string BEND_POSITIVE = "bendPositive";

		[Token(Token = "0x40004D8")]
		protected const string CHAIN = "chain";

		[Token(Token = "0x40004D9")]
		protected const string WEIGHT = "weight";

		[Token(Token = "0x40004DA")]
		protected const string FADE_IN_TIME = "fadeInTime";

		[Token(Token = "0x40004DB")]
		protected const string PLAY_TIMES = "playTimes";

		[Token(Token = "0x40004DC")]
		protected const string SCALE = "scale";

		[Token(Token = "0x40004DD")]
		protected const string OFFSET = "offset";

		[Token(Token = "0x40004DE")]
		protected const string POSITION = "position";

		[Token(Token = "0x40004DF")]
		protected const string DURATION = "duration";

		[Token(Token = "0x40004E0")]
		protected const string TWEEN_TYPE = "tweenType";

		[Token(Token = "0x40004E1")]
		protected const string TWEEN_EASING = "tweenEasing";

		[Token(Token = "0x40004E2")]
		protected const string TWEEN_ROTATE = "tweenRotate";

		[Token(Token = "0x40004E3")]
		protected const string TWEEN_SCALE = "tweenScale";

		[Token(Token = "0x40004E4")]
		protected const string CLOCK_WISE = "clockwise";

		[Token(Token = "0x40004E5")]
		protected const string CURVE = "curve";

		[Token(Token = "0x40004E6")]
		protected const string SOUND = "sound";

		[Token(Token = "0x40004E7")]
		protected const string EVENT = "event";

		[Token(Token = "0x40004E8")]
		protected const string ACTION = "action";

		[Token(Token = "0x40004E9")]
		protected const string X = "x";

		[Token(Token = "0x40004EA")]
		protected const string Y = "y";

		[Token(Token = "0x40004EB")]
		protected const string SKEW_X = "skX";

		[Token(Token = "0x40004EC")]
		protected const string SKEW_Y = "skY";

		[Token(Token = "0x40004ED")]
		protected const string SCALE_X = "scX";

		[Token(Token = "0x40004EE")]
		protected const string SCALE_Y = "scY";

		[Token(Token = "0x40004EF")]
		protected const string VALUE = "value";

		[Token(Token = "0x40004F0")]
		protected const string ROTATE = "rotate";

		[Token(Token = "0x40004F1")]
		protected const string SKEW = "skew";

		[Token(Token = "0x40004F2")]
		protected const string ALPHA_OFFSET = "aO";

		[Token(Token = "0x40004F3")]
		protected const string RED_OFFSET = "rO";

		[Token(Token = "0x40004F4")]
		protected const string GREEN_OFFSET = "gO";

		[Token(Token = "0x40004F5")]
		protected const string BLUE_OFFSET = "bO";

		[Token(Token = "0x40004F6")]
		protected const string ALPHA_MULTIPLIER = "aM";

		[Token(Token = "0x40004F7")]
		protected const string RED_MULTIPLIER = "rM";

		[Token(Token = "0x40004F8")]
		protected const string GREEN_MULTIPLIER = "gM";

		[Token(Token = "0x40004F9")]
		protected const string BLUE_MULTIPLIER = "bM";

		[Token(Token = "0x40004FA")]
		protected const string UVS = "uvs";

		[Token(Token = "0x40004FB")]
		protected const string VERTICES = "vertices";

		[Token(Token = "0x40004FC")]
		protected const string TRIANGLES = "triangles";

		[Token(Token = "0x40004FD")]
		protected const string WEIGHTS = "weights";

		[Token(Token = "0x40004FE")]
		protected const string SLOT_POSE = "slotPose";

		[Token(Token = "0x40004FF")]
		protected const string BONE_POSE = "bonePose";

		[Token(Token = "0x4000500")]
		protected const string GOTO_AND_PLAY = "gotoAndPlay";

		[Token(Token = "0x4000501")]
		protected const string DEFAULT_NAME = "default";

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xD0DC60", Offset = "0xD0DC60", VA = "0xD0DC60")]
		protected static ArmatureType _GetArmatureType(string value)
		{
			return default(ArmatureType);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xD0DD3C", Offset = "0xD0DD3C", VA = "0xD0DD3C")]
		protected static DisplayType _GetDisplayType(string value)
		{
			return default(DisplayType);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xD0DE48", Offset = "0xD0DE48", VA = "0xD0DE48")]
		protected static BoundingBoxType _GetBoundingBoxType(string value)
		{
			return default(BoundingBoxType);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xD0DF1C", Offset = "0xD0DF1C", VA = "0xD0DF1C")]
		protected static ActionType _GetActionType(string value)
		{
			return default(ActionType);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xD0DFF0", Offset = "0xD0DFF0", VA = "0xD0DFF0")]
		protected static BlendMode _GetBlendMode(string value)
		{
			return default(BlendMode);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xD0E410", Offset = "0xD0E410", VA = "0xD0E410")]
		public DataParser()
		{
		}

		[Token(Token = "0x600087E")]
		public abstract DragonBonesData ParseDragonBonesData(object rawData, float scale);

		[Token(Token = "0x600087F")]
		public abstract bool ParseTextureAtlasData(object rawData, TextureAtlasData textureAtlasData, float scale);
	}
	[Token(Token = "0x2000174")]
	public class ObjectDataParser : DataParser
	{
		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected int _rawTextureAtlasIndex;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly List<BoneData> _rawBones;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected DragonBonesData _data;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ArmatureData _armature;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected BoneData _bone;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected SlotData _slot;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected SkinData _skin;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected MeshDisplayData _mesh;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected AnimationData _animation;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected TimelineData _timeline;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<object> _rawTextureAtlases;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _defaultColorOffset;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _prevClockwise;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _prevRotation;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Matrix _helpMatrixA;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Matrix _helpMatrixB;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly Transform _helpTransform;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly ColorTransform _helpColorTransform;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Point _helpPoint;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly List<float> _helpArray;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly List<short> _intArray;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly List<float> _floatArray;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<short> _frameIntArray;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly List<float> _frameFloatArray;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<short> _frameArray;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly List<ushort> _timelineArray;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<object> _cacheRawMeshes;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly List<MeshDisplayData> _cacheMeshes;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly List<ActionFrame> _actionFrames;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly Dictionary<string, List<float>> _weightSlotPose;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly Dictionary<string, List<float>> _weightBonePoses;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly Dictionary<string, List<uint>> _weightBoneIndices;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly Dictionary<string, List<BoneData>> _cacheBones;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly Dictionary<string, List<ActionData>> _slotChildActions;

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x14C4D34", Offset = "0x14C4D34", VA = "0x14C4D34")]
		protected static bool _GetBoolean(Dictionary<string, object> rawData, string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x14C4F50", Offset = "0x14C4F50", VA = "0x14C4F50")]
		protected static uint _GetNumber(Dictionary<string, object> rawData, string key, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x14C5064", Offset = "0x14C5064", VA = "0x14C5064")]
		protected static int _GetNumber(Dictionary<string, object> rawData, string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x14C5178", Offset = "0x14C5178", VA = "0x14C5178")]
		protected static float _GetNumber(Dictionary<string, object> rawData, string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x14C5298", Offset = "0x14C5298", VA = "0x14C5298")]
		protected static string _GetString(Dictionary<string, object> rawData, string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x14C53B0", Offset = "0x14C53B0", VA = "0x14C53B0")]
		public ObjectDataParser()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x14C5934", Offset = "0x14C5934", VA = "0x14C5934")]
		private void _GetCurvePoint(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, float t, Point result)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x14C59B8", Offset = "0x14C59B8", VA = "0x14C59B8")]
		private void _SamplingEasingCurve(float[] curve, List<float> samples)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x14C5CA8", Offset = "0x14C5CA8", VA = "0x14C5CA8")]
		private void _ParseActionDataInFrame(object rawData, int frameStart, [Optional] BoneData bone, [Optional] SlotData slot)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x14C5F50", Offset = "0x14C5F50", VA = "0x14C5F50")]
		private void _MergeActionFrame(object rawData, int frameStart, ActionType type, [Optional] BoneData bone, [Optional] SlotData slot)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x14C7334", Offset = "0x14C7334", VA = "0x14C7334")]
		private int _ParseCacheActionFrame(ActionFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x14C74C8", Offset = "0x14C74C8", VA = "0x14C74C8")]
		private ArmatureData _ParseArmature(Dictionary<string, object> rawData, float scale)
		{
			return null;
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x14C8DA0", Offset = "0x14C8DA0", VA = "0x14C8DA0")]
		protected BoneData _ParseBone(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x14C902C", Offset = "0x14C902C", VA = "0x14C902C")]
		protected ConstraintData _ParseIKConstraint(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x14C92B4", Offset = "0x14C92B4", VA = "0x14C92B4")]
		private SlotData _ParseSlot(Dictionary<string, object> rawData, int zOrder)
		{
			return null;
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x14C96C8", Offset = "0x14C96C8", VA = "0x14C96C8")]
		protected SkinData _ParseSkin(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x14CA174", Offset = "0x14CA174", VA = "0x14CA174")]
		protected DisplayData _ParseDisplay(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x14CA9F8", Offset = "0x14CA9F8", VA = "0x14CA9F8")]
		protected void _ParsePivot(Dictionary<string, object> rawData, ImageDisplayData display)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x14CAE04", Offset = "0x14CAE04", VA = "0x14CAE04", Slot = "6")]
		protected virtual void _ParseMesh(Dictionary<string, object> rawData, MeshDisplayData mesh)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x14CAB74", Offset = "0x14CAB74", VA = "0x14CAB74")]
		protected BoundingBoxData _ParseBoundingBox(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x14CBF74", Offset = "0x14CBF74", VA = "0x14CBF74")]
		protected PolygonBoundingBoxData _ParsePolygonBoundingBox(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x14CC39C", Offset = "0x14CC39C", VA = "0x14CC39C", Slot = "7")]
		protected virtual AnimationData _ParseAnimation(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x14CD7A0", Offset = "0x14CD7A0", VA = "0x14CD7A0")]
		protected TimelineData _ParseTimeline(Dictionary<string, object> rawData, List<object> rawFrames, string framesKey, TimelineType type, bool addIntOffset, bool addFloatOffset, uint frameValueCount, Func<Dictionary<string, object>, int, int, int> frameParser)
		{
			return null;
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x14CDFE4", Offset = "0x14CDFE4", VA = "0x14CDFE4")]
		protected void _ParseBoneTimeline(Dictionary<string, object> rawData)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x14CE3F0", Offset = "0x14CE3F0", VA = "0x14CE3F0")]
		protected void _ParseSlotTimeline(Dictionary<string, object> rawData)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x14CE694", Offset = "0x14CE694", VA = "0x14CE694")]
		protected int _ParseFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x14CE770", Offset = "0x14CE770", VA = "0x14CE770")]
		protected int _ParseTweenFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x14CEF84", Offset = "0x14CEF84", VA = "0x14CEF84")]
		private int _ParseZOrderFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x14CF534", Offset = "0x14CF534", VA = "0x14CF534")]
		protected int _ParseBoneAllFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x14CF8C0", Offset = "0x14CF8C0", VA = "0x14CF8C0")]
		protected int _ParseBoneTranslateFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x14CFA24", Offset = "0x14CFA24", VA = "0x14CFA24")]
		protected int _ParseBoneRotateFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x14CFCD4", Offset = "0x14CFCD4", VA = "0x14CFCD4")]
		protected int _ParseBoneScaleFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x14CFE38", Offset = "0x14CFE38", VA = "0x14CFE38")]
		protected int _ParseSlotDisplayFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x14CFFBC", Offset = "0x14CFFBC", VA = "0x14CFFBC")]
		protected int _ParseSlotColorFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x14D0A78", Offset = "0x14D0A78", VA = "0x14D0A78")]
		protected int _ParseSlotFFDFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x14D13F0", Offset = "0x14D13F0", VA = "0x14D13F0")]
		protected int _ParseIKConstraintFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x14C6364", Offset = "0x14C6364", VA = "0x14C6364")]
		protected List<ActionData> _ParseActionData(object rawData, ActionType type, [Optional] BoneData bone, [Optional] SlotData slot)
		{
			return null;
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x14C9CF0", Offset = "0x14C9CF0", VA = "0x14C9CF0")]
		protected void _ParseTransform(Dictionary<string, object> rawData, Transform transform, float scale)
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x14C9FC0", Offset = "0x14C9FC0", VA = "0x14C9FC0")]
		protected void _ParseColorTransform(Dictionary<string, object> rawData, ColorTransform color)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x14D1624", Offset = "0x14D1624", VA = "0x14D1624", Slot = "8")]
		protected virtual void _ParseArray(Dictionary<string, object> rawData)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x14D16F8", Offset = "0x14D16F8", VA = "0x14D16F8")]
		protected void _ModifyArray()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x14D1FFC", Offset = "0x14D1FFC", VA = "0x14D1FFC", Slot = "4")]
		public override DragonBonesData ParseDragonBonesData(object rawObj, float scale = 1f)
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x14D26BC", Offset = "0x14D26BC", VA = "0x14D26BC", Slot = "5")]
		public override bool ParseTextureAtlasData(object rawObj, TextureAtlasData textureAtlasData, float scale = 1f)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000175")]
	internal class ActionFrame
	{
		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameStart;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<int> actions;

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xEA52F4", Offset = "0xEA52F4", VA = "0xEA52F4")]
		public ActionFrame()
		{
		}
	}
	[Token(Token = "0x2000176")]
	public class MeshBuffer : IDisposable
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly List<UnitySlot> combineSlots;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mesh sharedMesh;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int vertexCount;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] rawVertextBuffers;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2[] uvBuffers;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3[] vertexBuffers;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color32[] color32Buffers;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int[] triangleBuffers;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool vertexDirty;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool zorderDirty;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool enabled;

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x146D2C8", Offset = "0x146D2C8", VA = "0x146D2C8")]
		public static Mesh GenerateMesh()
		{
			return null;
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x146D344", Offset = "0x146D344", VA = "0x146D344")]
		private static int _OnSortSlots(Slot a, Slot b)
		{
			return default(int);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x146D380", Offset = "0x146D380", VA = "0x146D380", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x146D4BC", Offset = "0x146D4BC", VA = "0x146D4BC")]
		public void Clear()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x146D5D0", Offset = "0x146D5D0", VA = "0x146D5D0")]
		public void CombineMeshes(CombineInstance[] combines)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x146D790", Offset = "0x146D790", VA = "0x146D790")]
		public void InitMesh()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x146D888", Offset = "0x146D888", VA = "0x146D888")]
		public void UpdateVertices()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x146D8C8", Offset = "0x146D8C8", VA = "0x146D8C8")]
		public void UpdateColors()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x146D8EC", Offset = "0x146D8EC", VA = "0x146D8EC")]
		public void UpdateOrder()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x146DDB8", Offset = "0x146DDB8", VA = "0x146DDB8")]
		public MeshBuffer()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public enum SortingMode
	{
		[Token(Token = "0x4000533")]
		SortByZ,
		[Token(Token = "0x4000534")]
		SortByOrder
	}
	[Token(Token = "0x2000178")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class UnityArmatureComponent : DragonBoneEventDispatcher, IArmatureProxy, IEventDispatcher<EventObject>
	{
		[Token(Token = "0x4000535")]
		public const int ORDER_SPACE = 10;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityDragonBonesData unityData;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string armatureName;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isUGUI;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool debugDraw;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal readonly ColorTransform _colorTransform;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string animationName;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _disposeProxy;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal Armature _armature;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73E028", Offset = "0x73E028")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73E028", Offset = "0x73E028")]
		protected int _playTimes;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73E090", Offset = "0x73E090")]
		protected float _timeScale;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		internal SortingMode _sortingMode;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		internal string _sortingLayerName;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		internal int _sortingOrder;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		internal float _zSpace;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected bool _flipX;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[SerializeField]
		protected bool _flipY;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		[SerializeField]
		protected bool _closeCombineMeshs;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		private bool _hasSortingGroup;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material _debugDrawer;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal int _armatureZ;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal SortingGroup _sortingGroup;

		[Token(Token = "0x17000075")]
		public Armature armature
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x1485F44", Offset = "0x1485F44", VA = "0x1485F44", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public Animation animation
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x147BD7C", Offset = "0x147BD7C", VA = "0x147BD7C", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public SortingMode sortingMode
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x1485F4C", Offset = "0x1485F4C", VA = "0x1485F4C")]
			get
			{
				return default(SortingMode);
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x1485F54", Offset = "0x1485F54", VA = "0x1485F54")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public string sortingLayerName
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x1486450", Offset = "0x1486450", VA = "0x1486450")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x1486458", Offset = "0x1486458", VA = "0x1486458")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public int sortingOrder
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x14864A4", Offset = "0x14864A4", VA = "0x14864A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x14864AC", Offset = "0x14864AC", VA = "0x14864AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public float zSpace
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x14864B4", Offset = "0x14864B4", VA = "0x14864B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x14864BC", Offset = "0x14864BC", VA = "0x14864BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public ColorTransform color
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x1486520", Offset = "0x1486520", VA = "0x1486520")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1486528", Offset = "0x1486528", VA = "0x1486528")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public SortingGroup sortingGroup
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1486664", Offset = "0x1486664", VA = "0x1486664")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x14854F8", Offset = "0x14854F8", VA = "0x14854F8", Slot = "9")]
		public void DBClear()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1485620", Offset = "0x1485620", VA = "0x1485620", Slot = "8")]
		public void DBInit(Armature armature)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1485628", Offset = "0x1485628", VA = "0x1485628", Slot = "10")]
		public void DBUpdate()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x148562C", Offset = "0x148562C", VA = "0x148562C")]
		private void CreateLineMaterial()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x14857DC", Offset = "0x14857DC", VA = "0x14857DC")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1485F24", Offset = "0x1485F24", VA = "0x1485F24", Slot = "11")]
		public void Dispose(bool disposeProxy = true)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x148666C", Offset = "0x148666C", VA = "0x148666C")]
		private void _UpdateSortingGroup()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x14860DC", Offset = "0x14860DC", VA = "0x14860DC")]
		private void _UpdateSlotsSorting()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1486BF4", Offset = "0x1486BF4", VA = "0x1486BF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1486E40", Offset = "0x1486E40", VA = "0x1486E40")]
		private void Start()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x14870AC", Offset = "0x14870AC", VA = "0x14870AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x1487184", Offset = "0x1487184", VA = "0x1487184")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x1486E50", Offset = "0x1486E50", VA = "0x1486E50")]
		private void OpenCombineMeshs()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x147D11C", Offset = "0x147D11C", VA = "0x147D11C")]
		public void CloseCombineMeshs()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x1487250", Offset = "0x1487250", VA = "0x1487250")]
		public UnityArmatureComponent()
		{
		}
	}
	[Token(Token = "0x2000179")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73D770", Offset = "0x73D770")]
	[ExecuteInEditMode]
	public class UnityCombineMeshs : MonoBehaviour
	{
		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public List<string> slotNames;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public MeshBuffer[] meshBuffers;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool dirty;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityArmatureComponent _unityArmature;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _subSlotCount;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _verticeOffset;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isCanCombineMesh;

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x14872F4", Offset = "0x14872F4", VA = "0x14872F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x1487360", Offset = "0x1487360", VA = "0x1487360")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x1487474", Offset = "0x1487474", VA = "0x1487474")]
		private void RestoreArmature(Armature armature)
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x14875E0", Offset = "0x14875E0", VA = "0x14875E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x1487694", Offset = "0x1487694", VA = "0x1487694")]
		public void BeginCombineMesh()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1487BE8", Offset = "0x1487BE8", VA = "0x1487BE8")]
		public void CollectMesh(Armature armature, List<CombineMeshInfo> combineSlots)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1488298", Offset = "0x1488298", VA = "0x1488298")]
		public UnityCombineMeshs()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public struct CombineMeshInfo
	{
		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UnitySlot proxySlot;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<CombineInstance> combines;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<UnitySlot> slots;
	}
	[Serializable]
	[Token(Token = "0x200017B")]
	public class UnityDragonBonesData : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200017C")]
		public class TextureAtlas
		{
			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TextAsset textureAtlasJSON;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture2D texture;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Material material;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material uiMaterial;

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x1021E48", Offset = "0x1021E48", VA = "0x1021E48")]
			public TextureAtlas()
			{
			}
		}

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string dataName;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAsset dragonBonesJSON;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextureAtlas[] textureAtlas;

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x148831C", Offset = "0x148831C", VA = "0x148831C")]
		public void RemoveFromFactory(bool disposeData = true)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x1488494", Offset = "0x1488494", VA = "0x1488494")]
		public UnityDragonBonesData()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class UnityEventDispatcher<T> : MonoBehaviour
	{
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, ListenerDelegate<T>> _listeners;

		[Token(Token = "0x60008DD")]
		public UnityEventDispatcher()
		{
		}

		[Token(Token = "0x60008DE")]
		public void DispatchEvent(string type, T eventObject)
		{
		}

		[Token(Token = "0x60008DF")]
		public bool HasEventListener(string type)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E0")]
		public void AddEventListener(string type, ListenerDelegate<T> listener)
		{
		}

		[Token(Token = "0x60008E1")]
		public void RemoveEventListener(string type, ListenerDelegate<T> listener)
		{
		}
	}
	[Token(Token = "0x200017E")]
	[DisallowMultipleComponent]
	public class DragonBoneEventDispatcher : UnityEventDispatcher<EventObject>, IEventDispatcher<EventObject>
	{
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xD60960", Offset = "0xD60960", VA = "0xD60960", Slot = "6")]
		public void AddDBEventListener(string type, ListenerDelegate<EventObject> listener)
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xD609C4", Offset = "0xD609C4", VA = "0xD609C4", Slot = "5")]
		public void DispatchDBEvent(string type, EventObject eventObject)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xD60A28", Offset = "0xD60A28", VA = "0xD60A28", Slot = "4")]
		public bool HasDBEventListener(string type)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xD60A84", Offset = "0xD60A84", VA = "0xD60A84", Slot = "7")]
		public void RemoveDBEventListener(string type, ListenerDelegate<EventObject> listener)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xD60AE8", Offset = "0xD60AE8", VA = "0xD60AE8")]
		public DragonBoneEventDispatcher()
		{
		}
	}
	[Token(Token = "0x200017F")]
	internal class ClockHandler : MonoBehaviour
	{
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xCFE9BC", Offset = "0xCFE9BC", VA = "0xCFE9BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xCFEA3C", Offset = "0xCFEA3C", VA = "0xCFEA3C")]
		public ClockHandler()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class UnityFactory : BaseFactory
	{
		[Token(Token = "0x400055D")]
		internal const string defaultShaderName = "Sprites/Default";

		[Token(Token = "0x400055E")]
		internal const string defaultUIShaderName = "UI/Default";

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static DragonBones _dragonBonesInstance;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static UnityFactory _factory;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static GameObject _gameObject;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject _armatureGameObject;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isUGUI;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<UnityDragonBonesData> _cacheUnityDragonBonesData;

		[Token(Token = "0x1700007D")]
		public static UnityFactory factory
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x147949C", Offset = "0x147949C", VA = "0x147949C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public IEventDispatcher<EventObject> soundEventManager
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1489984", Offset = "0x1489984", VA = "0x1489984")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x148849C", Offset = "0x148849C", VA = "0x148849C")]
		public UnityFactory([Optional] DataParser dataParser)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x1488564", Offset = "0x1488564", VA = "0x1488564")]
		private void Init()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1488B04", Offset = "0x1488B04", VA = "0x1488B04", Slot = "5")]
		protected override TextureAtlasData _BuildTextureAtlasData(TextureAtlasData textureAtlasData, object textureAtlas)
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x1488C98", Offset = "0x1488C98", VA = "0x1488C98", Slot = "6")]
		protected override Armature _BuildArmature(BuildArmaturePackage dataPackage)
		{
			return null;
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x1488FF4", Offset = "0x1488FF4", VA = "0x1488FF4", Slot = "4")]
		protected override Armature _BuildChildArmature(BuildArmaturePackage dataPackage, Slot slot, DisplayData displayData)
		{
			return null;
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x1489338", Offset = "0x1489338", VA = "0x1489338", Slot = "7")]
		protected override Slot _BuildSlot(BuildArmaturePackage dataPackage, SlotData slotData, Armature armature)
		{
			return null;
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x147BA6C", Offset = "0x147BA6C", VA = "0x147BA6C")]
		public UnityArmatureComponent BuildArmatureComponent(string armatureName, string dragonBonesName = "", string skinName = "", string textureAtlasName = "", [Optional] GameObject gameObject, bool isUGUI = false)
		{
			return null;
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x14895FC", Offset = "0x14895FC", VA = "0x14895FC")]
		public GameObject GetTextureDisplay(string textureName, [Optional] string textureAtlasName)
		{
			return null;
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x1489604", Offset = "0x1489604", VA = "0x1489604")]
		protected void _RefreshTextureAtlas(UnityTextureAtlasData textureAtlasData, bool isUGUI, bool isEditor = false)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x1489900", Offset = "0x1489900", VA = "0x1489900", Slot = "11")]
		public override void Clear(bool disposeData = true)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x1479564", Offset = "0x1479564", VA = "0x1479564")]
		public DragonBonesData LoadData(UnityDragonBonesData data, bool isUGUI = false, float armatureScale = 0.01f, float texScale = 1f)
		{
			return null;
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x147B80C", Offset = "0x147B80C", VA = "0x147B80C")]
		public DragonBonesData LoadDragonBonesData(string dragonBonesJSONPath, string name = "", float scale = 0.01f)
		{
			return null;
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x14899F4", Offset = "0x14899F4", VA = "0x14899F4")]
		public DragonBonesData LoadDragonBonesData(TextAsset dragonBonesJSON, string name = "", float scale = 0.01f)
		{
			return null;
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x147B888", Offset = "0x147B888", VA = "0x147B888")]
		public UnityTextureAtlasData LoadTextureAtlasData(string textureAtlasJSONPath, string name = "", float scale = 1f, bool isUGUI = false)
		{
			return null;
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x1489C30", Offset = "0x1489C30", VA = "0x1489C30")]
		public UnityTextureAtlasData LoadTextureAtlasData(UnityDragonBonesData.TextureAtlas textureAtlas, string name, float scale = 1f, bool isUGUI = false)
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x1489E74", Offset = "0x1489E74", VA = "0x1489E74")]
		public void RefreshAllTextureAtlas(UnityArmatureComponent unityArmature)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x148A1A0", Offset = "0x148A1A0", VA = "0x148A1A0", Slot = "13")]
		public override void ReplaceDisplay(Slot slot, DisplayData displayData, int displayIndex = -1)
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x148A384", Offset = "0x148A384", VA = "0x148A384")]
		public void ReplaceSlotDisplay(string dragonBonesName, string armatureName, string slotName, string displayName, Slot slot, Texture2D texture, [Optional] Material material, bool isUGUI = false, int displayIndex = -1)
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x148ACD8", Offset = "0x148ACD8", VA = "0x148ACD8")]
		public UnityDragonBonesData GetCacheUnityDragonBonesData(string draonBonesName)
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x148ADD8", Offset = "0x148ADD8", VA = "0x148ADD8")]
		public void AddCacheUnityDragonBonesData(UnityDragonBonesData unityData)
		{
		}
	}
	[Token(Token = "0x2000181")]
	internal static class UnityFactoryHelper
	{
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x10105D0", Offset = "0x10105D0", VA = "0x10105D0")]
		internal static Material GenerateMaterial(string shaderName, string materialName, Texture texture)
		{
			return null;
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x101067C", Offset = "0x101067C", VA = "0x101067C")]
		internal static string CheckResourecdPath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x1010744", Offset = "0x1010744", VA = "0x1010744")]
		internal static string GetTextureAtlasImagePath(string textureAtlasJSONPath, string textureAtlasImageName)
		{
			return null;
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1010870", Offset = "0x1010870", VA = "0x1010870")]
		internal static string GetTextureAtlasNameByPath(string textureAtlasJSONPath)
		{
			return null;
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x1010968", Offset = "0x1010968", VA = "0x1010968")]
		internal static void DestroyUnityObject(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000182")]
	internal static class LogHelper
	{
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x146A890", Offset = "0x146A890", VA = "0x146A890")]
		internal static void LogWarning(object message)
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class UnitySlot : Slot
	{
		[Token(Token = "0x4000565")]
		internal const float Z_OFFSET = 0.001f;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] TRIANGLES;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3 _helpVector3;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal GameObject _renderDisplay;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal UnityUGUIDisplay _uiDisplay;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		internal MeshBuffer _meshBuffer;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal MeshRenderer _meshRenderer;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal MeshFilter _meshFilter;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal bool _isIgnoreCombineMesh;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		internal bool _isCombineMesh;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		internal int _sumMeshIndex;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal int _verticeOrder;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		internal int _verticeOffset;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal UnityCombineMeshs _combineMesh;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal bool _isActive;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		private bool _skewed;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private UnityArmatureComponent _proxy;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private BlendMode _currentBlendMode;

		[Token(Token = "0x1700007F")]
		public Mesh mesh
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x1013CB0", Offset = "0x1013CB0", VA = "0x1013CB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0x1013CC8", Offset = "0x1013CC8", VA = "0x1013CC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public UnityTextureAtlasData currentTextureAtlasData
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0x1012BD8", Offset = "0x1012BD8", VA = "0x1012BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public GameObject renderDisplay
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x1013CD0", Offset = "0x1013CD0", VA = "0x1013CD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public UnityArmatureComponent proxy
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x1013CD8", Offset = "0x1013CD8", VA = "0x1013CD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public bool isIgnoreCombineMesh
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x1013CE0", Offset = "0x1013CE0", VA = "0x1013CE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1010A04", Offset = "0x1010A04", VA = "0x1010A04")]
		public UnitySlot()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x1010A20", Offset = "0x1010A20", VA = "0x1010A20", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x1010AEC", Offset = "0x1010AEC", VA = "0x1010AEC", Slot = "5")]
		protected override void _InitDisplay(object value, bool isRetain)
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x1010AF0", Offset = "0x1010AF0", VA = "0x1010AF0", Slot = "6")]
		protected override void _DisposeDisplay(object value, bool isRelease)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x1010B74", Offset = "0x1010B74", VA = "0x1010B74", Slot = "7")]
		protected override void _OnUpdateDisplay()
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x1010F78", Offset = "0x1010F78", VA = "0x1010F78", Slot = "8")]
		protected override void _AddDisplay()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x101139C", Offset = "0x101139C", VA = "0x101139C", Slot = "9")]
		protected override void _ReplaceDisplay(object value)
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x10114D8", Offset = "0x10114D8", VA = "0x10114D8", Slot = "10")]
		protected override void _RemoveDisplay()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x1011508", Offset = "0x1011508", VA = "0x1011508", Slot = "11")]
		protected override void _UpdateZOrder()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x1011124", Offset = "0x1011124", VA = "0x1011124")]
		internal void _SetZorder(Vector3 zorderPos)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x1011648", Offset = "0x1011648", VA = "0x1011648")]
		public void DisallowCombineMesh()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x1011670", Offset = "0x1011670", VA = "0x1011670")]
		internal void CancelCombineMesh()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x101156C", Offset = "0x101156C", VA = "0x101156C")]
		private void _CombineMesh()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x101185C", Offset = "0x101185C", VA = "0x101185C", Slot = "12")]
		internal override void _UpdateVisible()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x10118C0", Offset = "0x10118C0", VA = "0x10118C0", Slot = "13")]
		internal override void _UpdateBlendMode()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x1011BBC", Offset = "0x1011BBC", VA = "0x1011BBC", Slot = "14")]
		protected override void _UpdateColor()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x101201C", Offset = "0x101201C", VA = "0x101201C", Slot = "15")]
		protected override void _UpdateFrame()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x1012D14", Offset = "0x1012D14", VA = "0x1012D14", Slot = "18")]
		protected override void _IdentityTransform()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x1012D88", Offset = "0x1012D88", VA = "0x1012D88", Slot = "16")]
		protected override void _UpdateMesh()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x1013514", Offset = "0x1013514", VA = "0x1013514", Slot = "17")]
		protected override void _UpdateTransform()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class UnityTextureAtlasData : TextureAtlasData
	{
		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool _disposeEnabled;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Material texture;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Material uiTexture;

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x1013D90", Offset = "0x1013D90", VA = "0x1013D90")]
		public UnityTextureAtlasData()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x1013D98", Offset = "0x1013D98", VA = "0x1013D98", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x1013E9C", Offset = "0x1013E9C", VA = "0x1013E9C", Slot = "5")]
		public override TextureData CreateTexture()
		{
			return null;
		}
	}
	[Token(Token = "0x2000185")]
	internal class UnityTextureData : TextureData
	{
		[Token(Token = "0x400057A")]
		public const string SHADER_PATH = "Shaders/";

		[Token(Token = "0x400057B")]
		public const string SHADER_GRAP = "DB_BlendMode_Grab";

		[Token(Token = "0x400057C")]
		public const string SHADER_FRAME_BUFFER = "DB_BlendMode_Framebuffer";

		[Token(Token = "0x400057D")]
		public const string UI_SHADER_GRAP = "DB_BlendMode_UIGrab";

		[Token(Token = "0x400057E")]
		public const string UI_SHADER_FRAME_BUFFER = "DB_BlendMode_UIFramebuffer";

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Dictionary<string, Material> _cacheBlendModeMats;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x1013F0C", Offset = "0x1013F0C", VA = "0x1013F0C")]
		public UnityTextureData()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x1013F90", Offset = "0x1013F90", VA = "0x1013F90", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x1014178", Offset = "0x1014178", VA = "0x1014178")]
		private Material _GetMaterial(BlendMode blendMode)
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x1014404", Offset = "0x1014404", VA = "0x1014404")]
		private Material _GetUIMaterial(BlendMode blendMode)
		{
			return null;
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x1011BB0", Offset = "0x1011BB0", VA = "0x1011BB0")]
		internal Material GetMaterial(BlendMode blendMode, bool isUGUI = false)
		{
			return null;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x10146FC", Offset = "0x10146FC", VA = "0x10146FC", Slot = "5")]
		public override void CopyFrom(TextureData value)
		{
		}
	}
	[Token(Token = "0x2000186")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73D800", Offset = "0x73D800")]
	public class UnityUGUIDisplay : MaskableGraphic
	{
		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		public Mesh sharedMesh;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Texture _texture;

		[Token(Token = "0x17000085")]
		public override Texture mainTexture
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x101479C", Offset = "0x101479C", VA = "0x101479C", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public Texture texture
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x1014840", Offset = "0x1014840", VA = "0x1014840")]
			get
			{
				return null;
			}
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x1012C60", Offset = "0x1012C60", VA = "0x1012C60")]
			set
			{
			}
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x1014848", Offset = "0x1014848", VA = "0x1014848", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x1014864", Offset = "0x1014864", VA = "0x1014864", Slot = "37")]
		public override void Rebuild(CanvasUpdate update)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x10148D8", Offset = "0x10148D8", VA = "0x10148D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x101490C", Offset = "0x101490C", VA = "0x101490C")]
		public UnityUGUIDisplay()
		{
		}
	}
}
namespace MiniJSON
{
	[Token(Token = "0x2000187")]
	public static class Json
	{
		[Token(Token = "0x2000188")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x2000189")]
			private enum TOKEN
			{
				[Token(Token = "0x4000585")]
				NONE,
				[Token(Token = "0x4000586")]
				CURLY_OPEN,
				[Token(Token = "0x4000587")]
				CURLY_CLOSE,
				[Token(Token = "0x4000588")]
				SQUARED_OPEN,
				[Token(Token = "0x4000589")]
				SQUARED_CLOSE,
				[Token(Token = "0x400058A")]
				COLON,
				[Token(Token = "0x400058B")]
				COMMA,
				[Token(Token = "0x400058C")]
				STRING,
				[Token(Token = "0x400058D")]
				NUMBER,
				[Token(Token = "0x400058E")]
				TRUE,
				[Token(Token = "0x400058F")]
				FALSE,
				[Token(Token = "0x4000590")]
				NULL
			}

			[Token(Token = "0x4000582")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000087")]
			private char PeekChar
			{
				[Token(Token = "0x600093E")]
				[Address(RVA = "0x102043C", Offset = "0x102043C", VA = "0x102043C")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000088")]
			private char NextChar
			{
				[Token(Token = "0x600093F")]
				[Address(RVA = "0x1020250", Offset = "0x1020250", VA = "0x1020250")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000089")]
			private string NextWord
			{
				[Token(Token = "0x6000940")]
				[Address(RVA = "0x10202D4", Offset = "0x10202D4", VA = "0x10202D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6000941")]
				[Address(RVA = "0x101FAA4", Offset = "0x101FAA4", VA = "0x101FAA4")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x101F680", Offset = "0x101F680", VA = "0x101F680")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x101F728", Offset = "0x101F728", VA = "0x101F728")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x101F7A8", Offset = "0x101F7A8", VA = "0x101F7A8")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x101F940", Offset = "0x101F940", VA = "0x101F940", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x101F97C", Offset = "0x101F97C", VA = "0x101F97C")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000938")]
			[Address(RVA = "0x101FEFC", Offset = "0x101FEFC", VA = "0x101FEFC")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0x101F918", Offset = "0x101F918", VA = "0x101F918")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x101FFE4", Offset = "0x101FFE4", VA = "0x101FFE4")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x101FC68", Offset = "0x101FC68", VA = "0x101FC68")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x10200BC", Offset = "0x10200BC", VA = "0x10200BC")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x102038C", Offset = "0x102038C", VA = "0x102038C")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x200018A")]
		private sealed class Serializer
		{
			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x10204C0", Offset = "0x10204C0", VA = "0x10204C0")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0x1020530", Offset = "0x1020530", VA = "0x1020530")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000944")]
			[Address(RVA = "0x10205A8", Offset = "0x10205A8", VA = "0x10205A8")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000945")]
			[Address(RVA = "0x1020C08", Offset = "0x1020C08", VA = "0x1020C08")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000946")]
			[Address(RVA = "0x1020A5C", Offset = "0x1020A5C", VA = "0x1020A5C")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000947")]
			[Address(RVA = "0x1020794", Offset = "0x1020794", VA = "0x1020794")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0x1021048", Offset = "0x1021048", VA = "0x1021048")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x146A7D0", Offset = "0x146A7D0", VA = "0x146A7D0")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x146A7E0", Offset = "0x146A7E0", VA = "0x146A7E0")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200018B")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x200018C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8B8", Offset = "0x73D8B8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x1016438", Offset = "0x1016438", VA = "0x1016438")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x1016440", Offset = "0x1016440", VA = "0x1016440")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x101645C", Offset = "0x101645C", VA = "0x101645C")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200018D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8C8", Offset = "0x73D8C8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x1016478", Offset = "0x1016478", VA = "0x1016478")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x1016480", Offset = "0x1016480", VA = "0x1016480")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x101649C", Offset = "0x101649C", VA = "0x101649C")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200018E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8D8", Offset = "0x73D8D8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x10164B8", Offset = "0x10164B8", VA = "0x10164B8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x10164C0", Offset = "0x10164C0", VA = "0x10164C0")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000960")]
			[Address(RVA = "0x1016500", Offset = "0x1016500", VA = "0x1016500")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xD04BD8", Offset = "0xD04BD8", VA = "0xD04BD8")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xD04DA8", Offset = "0xD04DA8", VA = "0xD04DA8")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xD04F50", Offset = "0xD04F50", VA = "0xD04F50")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xD0510C", Offset = "0xD0510C", VA = "0xD0510C")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xD05180", Offset = "0xD05180", VA = "0xD05180")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xD051F4", Offset = "0xD051F4", VA = "0xD051F4")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xD05258", Offset = "0xD05258", VA = "0xD05258")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xD052DC", Offset = "0xD052DC", VA = "0xD052DC")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xD05340", Offset = "0xD05340", VA = "0xD05340")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xD053A4", Offset = "0xD053A4", VA = "0xD053A4")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xD05408", Offset = "0xD05408", VA = "0xD05408")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xD0546C", Offset = "0xD0546C", VA = "0xD0546C")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xD054D8", Offset = "0xD054D8", VA = "0xD054D8")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xD05540", Offset = "0xD05540", VA = "0xD05540")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xD055A4", Offset = "0xD055A4", VA = "0xD055A4")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200018F")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D8F8", Offset = "0x73D8F8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600096C")]
			[Address(RVA = "0x1016524", Offset = "0x1016524", VA = "0x1016524")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x101652C", Offset = "0x101652C", VA = "0x101652C")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000191")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D908", Offset = "0x73D908")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600096E")]
			[Address(RVA = "0x101666C", Offset = "0x101666C", VA = "0x101666C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0x1016674", Offset = "0x1016674", VA = "0x1016674")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000192")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D918", Offset = "0x73D918")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000970")]
			[Address(RVA = "0x1016690", Offset = "0x1016690", VA = "0x1016690")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x1016698", Offset = "0x1016698", VA = "0x1016698")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000193")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D928", Offset = "0x73D928")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x10166B4", Offset = "0x10166B4", VA = "0x10166B4")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x10166BC", Offset = "0x10166BC", VA = "0x10166BC")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000194")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D938", Offset = "0x73D938")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x10166D8", Offset = "0x10166D8", VA = "0x10166D8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0x10166E0", Offset = "0x10166E0", VA = "0x10166E0")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000195")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D948", Offset = "0x73D948")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000976")]
			[Address(RVA = "0x10166FC", Offset = "0x10166FC", VA = "0x10166FC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0x1016704", Offset = "0x1016704", VA = "0x1016704")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000196")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D958", Offset = "0x73D958")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x6000978")]
			[Address(RVA = "0x1016720", Offset = "0x1016720", VA = "0x1016720")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0x1016728", Offset = "0x1016728", VA = "0x1016728")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x1016744", Offset = "0x1016744", VA = "0x1016744")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0x1016778", Offset = "0x1016778", VA = "0x1016778")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0x1016794", Offset = "0x1016794", VA = "0x1016794")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0x10167B0", Offset = "0x10167B0", VA = "0x10167B0")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x2000197")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D968", Offset = "0x73D968")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600097E")]
			[Address(RVA = "0x1016870", Offset = "0x1016870", VA = "0x1016870")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x1016878", Offset = "0x1016878", VA = "0x1016878")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000198")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D978", Offset = "0x73D978")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Transform trans;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x1016894", Offset = "0x1016894", VA = "0x1016894")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x101689C", Offset = "0x101689C", VA = "0x101689C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x10168B8", Offset = "0x10168B8", VA = "0x10168B8")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000199")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D988", Offset = "0x73D988")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x10169B8", Offset = "0x10169B8", VA = "0x10169B8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x10169C0", Offset = "0x10169C0", VA = "0x10169C0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200019A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D998", Offset = "0x73D998")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Transform trans;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x1016548", Offset = "0x1016548", VA = "0x1016548")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x1016550", Offset = "0x1016550", VA = "0x1016550")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x101656C", Offset = "0x101656C", VA = "0x101656C")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0xD01B70", Offset = "0xD01B70", VA = "0xD01B70")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xD05608", Offset = "0xD05608", VA = "0xD05608")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xD057D8", Offset = "0xD057D8", VA = "0xD057D8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xD059A8", Offset = "0xD059A8", VA = "0xD059A8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xD01F20", Offset = "0xD01F20", VA = "0xD01F20")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xD05B78", Offset = "0xD05B78", VA = "0xD05B78")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xD05DCC", Offset = "0xD05DCC", VA = "0xD05DCC")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xD06300", Offset = "0xD06300", VA = "0xD06300")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xD0657C", Offset = "0xD0657C", VA = "0xD0657C")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xD06818", Offset = "0xD06818", VA = "0xD06818")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xD06A08", Offset = "0xD06A08", VA = "0xD06A08")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200019B")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x200019C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D9B8", Offset = "0x73D9B8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x10169DC", Offset = "0x10169DC", VA = "0x10169DC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x10169E4", Offset = "0x10169E4", VA = "0x10169E4")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200019D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D9C8", Offset = "0x73D9C8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x1016A00", Offset = "0x1016A00", VA = "0x1016A00")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0x1016A08", Offset = "0x1016A08", VA = "0x1016A08")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200019E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D9D8", Offset = "0x73D9D8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x1016A24", Offset = "0x1016A24", VA = "0x1016A24")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x1016A2C", Offset = "0x1016A2C", VA = "0x1016A2C")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200019F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D9E8", Offset = "0x73D9E8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x1016A48", Offset = "0x1016A48", VA = "0x1016A48")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x1016A50", Offset = "0x1016A50", VA = "0x1016A50")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x20001A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73D9F8", Offset = "0x73D9F8")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x1016A6C", Offset = "0x1016A6C", VA = "0x1016A6C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x1016A74", Offset = "0x1016A74", VA = "0x1016A74")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x1016A90", Offset = "0x1016A90", VA = "0x1016A90")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x1016AAC", Offset = "0x1016AAC", VA = "0x1016AAC")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x1016AE0", Offset = "0x1016AE0", VA = "0x1016AE0")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x1016AFC", Offset = "0x1016AFC", VA = "0x1016AFC")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x1016B18", Offset = "0x1016B18", VA = "0x1016B18")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x20001A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DA08", Offset = "0x73DA08")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x1016BD0", Offset = "0x1016BD0", VA = "0x1016BD0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x1016BD8", Offset = "0x1016BD8", VA = "0x1016BD8")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x1016C00", Offset = "0x1016C00", VA = "0x1016C00")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DA18", Offset = "0x73DA18")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Transform trans;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x1016C1C", Offset = "0x1016C1C", VA = "0x1016C1C")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x1016C24", Offset = "0x1016C24", VA = "0x1016C24")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x1016C40", Offset = "0x1016C40", VA = "0x1016C40")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DA28", Offset = "0x73DA28")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x1016D38", Offset = "0x1016D38", VA = "0x1016D38")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x1016D40", Offset = "0x1016D40", VA = "0x1016D40")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x1016D68", Offset = "0x1016D68", VA = "0x1016D68")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DA38", Offset = "0x73DA38")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Transform trans;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x1016D84", Offset = "0x1016D84", VA = "0x1016D84")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x1016D8C", Offset = "0x1016D8C", VA = "0x1016D8C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x1016DA8", Offset = "0x1016DA8", VA = "0x1016DA8")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xD01D4C", Offset = "0xD01D4C", VA = "0xD01D4C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xD06C18", Offset = "0xD06C18", VA = "0xD06C18")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xD06DE4", Offset = "0xD06DE4", VA = "0xD06DE4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xD020F8", Offset = "0xD020F8", VA = "0xD020F8")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xD06FB0", Offset = "0xD06FB0", VA = "0xD06FB0")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xD0740C", Offset = "0xD0740C", VA = "0xD0740C")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xD0770C", Offset = "0xD0770C", VA = "0xD0770C")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0xD07A30", Offset = "0xD07A30", VA = "0xD07A30")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xD07C1C", Offset = "0xD07C1C", VA = "0xD07C1C")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A5")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20001A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DA58", Offset = "0x73DA58")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x1016EA0", Offset = "0x1016EA0", VA = "0x1016EA0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x1016EA8", Offset = "0x1016EA8", VA = "0x1016EA8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x1016EC4", Offset = "0x1016EC4", VA = "0x1016EC4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DA68", Offset = "0x73DA68")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x1016EE0", Offset = "0x1016EE0", VA = "0x1016EE0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x1016EE8", Offset = "0x1016EE8", VA = "0x1016EE8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x1016F04", Offset = "0x1016F04", VA = "0x1016F04")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DA78", Offset = "0x73DA78")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x1016F20", Offset = "0x1016F20", VA = "0x1016F20")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x1016F28", Offset = "0x1016F28", VA = "0x1016F28")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x1016F34", Offset = "0x1016F34", VA = "0x1016F34")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xD02474", Offset = "0xD02474", VA = "0xD02474")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xD029E4", Offset = "0xD029E4", VA = "0xD029E4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xD07E2C", Offset = "0xD07E2C", VA = "0xD07E2C")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xD08018", Offset = "0xD08018", VA = "0xD08018")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A9")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x20001AA")]
		public static class Utils
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1018008", Offset = "0x1018008", VA = "0x1018008")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20001AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DA98", Offset = "0x73DA98")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1016FE0", Offset = "0x1016FE0", VA = "0x1016FE0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x1016FE8", Offset = "0x1016FE8", VA = "0x1016FE8")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x1017004", Offset = "0x1017004", VA = "0x1017004")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DAA8", Offset = "0x73DAA8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x10172A8", Offset = "0x10172A8", VA = "0x10172A8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x10172B0", Offset = "0x10172B0", VA = "0x10172B0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x10172D4", Offset = "0x10172D4", VA = "0x10172D4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DAB8", Offset = "0x73DAB8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x10176BC", Offset = "0x10176BC", VA = "0x10176BC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x10176C4", Offset = "0x10176C4", VA = "0x10176C4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x10176E8", Offset = "0x10176E8", VA = "0x10176E8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DAC8", Offset = "0x73DAC8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x1017BC0", Offset = "0x1017BC0", VA = "0x1017BC0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1017BC8", Offset = "0x1017BC8", VA = "0x1017BC8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x1017BEC", Offset = "0x1017BEC", VA = "0x1017BEC")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DAD8", Offset = "0x73DAD8")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x1017D20", Offset = "0x1017D20", VA = "0x1017D20")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x1017D28", Offset = "0x1017D28", VA = "0x1017D28")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x1017D4C", Offset = "0x1017D4C", VA = "0x1017D4C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DAE8", Offset = "0x73DAE8")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x1017D70", Offset = "0x1017D70", VA = "0x1017D70")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x1017D78", Offset = "0x1017D78", VA = "0x1017D78")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x1017D94", Offset = "0x1017D94", VA = "0x1017D94")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DAF8", Offset = "0x73DAF8")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x1017DB0", Offset = "0x1017DB0", VA = "0x1017DB0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x1017DB8", Offset = "0x1017DB8", VA = "0x1017DB8")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x1017E1C", Offset = "0x1017E1C", VA = "0x1017E1C")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB08", Offset = "0x73DB08")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x1017E78", Offset = "0x1017E78", VA = "0x1017E78")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x1017E80", Offset = "0x1017E80", VA = "0x1017E80")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x1017EE4", Offset = "0x1017EE4", VA = "0x1017EE4")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB18", Offset = "0x73DB18")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x1017F40", Offset = "0x1017F40", VA = "0x1017F40")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x1017F48", Offset = "0x1017F48", VA = "0x1017F48")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x1017FAC", Offset = "0x1017FAC", VA = "0x1017FAC")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB28", Offset = "0x73DB28")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x1017020", Offset = "0x1017020", VA = "0x1017020")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x1017028", Offset = "0x1017028", VA = "0x1017028")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x1017048", Offset = "0x1017048", VA = "0x1017048")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB38", Offset = "0x73DB38")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x1017064", Offset = "0x1017064", VA = "0x1017064")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x101706C", Offset = "0x101706C", VA = "0x101706C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x101708C", Offset = "0x101708C", VA = "0x101708C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB48", Offset = "0x73DB48")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x10170A8", Offset = "0x10170A8", VA = "0x10170A8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x10170B0", Offset = "0x10170B0", VA = "0x10170B0")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x10170CC", Offset = "0x10170CC", VA = "0x10170CC")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB58", Offset = "0x73DB58")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x10170E8", Offset = "0x10170E8", VA = "0x10170E8")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x10170F0", Offset = "0x10170F0", VA = "0x10170F0")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x101710C", Offset = "0x101710C", VA = "0x101710C")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB68", Offset = "0x73DB68")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x1017128", Offset = "0x1017128", VA = "0x1017128")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x1017130", Offset = "0x1017130", VA = "0x1017130")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x101714C", Offset = "0x101714C", VA = "0x101714C")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB78", Offset = "0x73DB78")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x1017168", Offset = "0x1017168", VA = "0x1017168")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x1017170", Offset = "0x1017170", VA = "0x1017170")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x101718C", Offset = "0x101718C", VA = "0x101718C")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB88", Offset = "0x73DB88")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x10171A8", Offset = "0x10171A8", VA = "0x10171A8")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x10171B0", Offset = "0x10171B0", VA = "0x10171B0")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x10171CC", Offset = "0x10171CC", VA = "0x10171CC")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DB98", Offset = "0x73DB98")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x10171E8", Offset = "0x10171E8", VA = "0x10171E8")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x10171F0", Offset = "0x10171F0", VA = "0x10171F0")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x101720C", Offset = "0x101720C", VA = "0x101720C")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBA8", Offset = "0x73DBA8")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x1017228", Offset = "0x1017228", VA = "0x1017228")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x1017230", Offset = "0x1017230", VA = "0x1017230")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x101724C", Offset = "0x101724C", VA = "0x101724C")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBB8", Offset = "0x73DBB8")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x1017268", Offset = "0x1017268", VA = "0x1017268")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x1017270", Offset = "0x1017270", VA = "0x1017270")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x101728C", Offset = "0x101728C", VA = "0x101728C")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBC8", Offset = "0x73DBC8")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x10172F8", Offset = "0x10172F8", VA = "0x10172F8")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x1017300", Offset = "0x1017300", VA = "0x1017300")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x101731C", Offset = "0x101731C", VA = "0x101731C")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBD8", Offset = "0x73DBD8")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x1017338", Offset = "0x1017338", VA = "0x1017338")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x1017340", Offset = "0x1017340", VA = "0x1017340")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x101735C", Offset = "0x101735C", VA = "0x101735C")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBE8", Offset = "0x73DBE8")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x1017378", Offset = "0x1017378", VA = "0x1017378")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x1017380", Offset = "0x1017380", VA = "0x1017380")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x101739C", Offset = "0x101739C", VA = "0x101739C")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DBF8", Offset = "0x73DBF8")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x10173B8", Offset = "0x10173B8", VA = "0x10173B8")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x10173C0", Offset = "0x10173C0", VA = "0x10173C0")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x10173DC", Offset = "0x10173DC", VA = "0x10173DC")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC08", Offset = "0x73DC08")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x10173F8", Offset = "0x10173F8", VA = "0x10173F8")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x1017400", Offset = "0x1017400", VA = "0x1017400")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x101741C", Offset = "0x101741C", VA = "0x101741C")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC18", Offset = "0x73DC18")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x1017438", Offset = "0x1017438", VA = "0x1017438")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x1017440", Offset = "0x1017440", VA = "0x1017440")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x101745C", Offset = "0x101745C", VA = "0x101745C")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC28", Offset = "0x73DC28")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x1017478", Offset = "0x1017478", VA = "0x1017478")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x1017480", Offset = "0x1017480", VA = "0x1017480")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x10174A8", Offset = "0x10174A8", VA = "0x10174A8")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC38", Offset = "0x73DC38")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x10174C4", Offset = "0x10174C4", VA = "0x10174C4")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x10174CC", Offset = "0x10174CC", VA = "0x10174CC")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x10174F4", Offset = "0x10174F4", VA = "0x10174F4")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC48", Offset = "0x73DC48")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x1017510", Offset = "0x1017510", VA = "0x1017510")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x1017518", Offset = "0x1017518", VA = "0x1017518")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x1017540", Offset = "0x1017540", VA = "0x1017540")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC58", Offset = "0x73DC58")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x101755C", Offset = "0x101755C", VA = "0x101755C")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x1017564", Offset = "0x1017564", VA = "0x1017564")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x1017580", Offset = "0x1017580", VA = "0x1017580")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x101759C", Offset = "0x101759C", VA = "0x101759C")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x10175D0", Offset = "0x10175D0", VA = "0x10175D0")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x10175EC", Offset = "0x10175EC", VA = "0x10175EC")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x1017608", Offset = "0x1017608", VA = "0x1017608")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x20001C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC68", Offset = "0x73DC68")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x101770C", Offset = "0x101770C", VA = "0x101770C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x1017714", Offset = "0x1017714", VA = "0x1017714")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x1017768", Offset = "0x1017768", VA = "0x1017768")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC78", Offset = "0x73DC78")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x10177B4", Offset = "0x10177B4", VA = "0x10177B4")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x10177BC", Offset = "0x10177BC", VA = "0x10177BC")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x10177D8", Offset = "0x10177D8", VA = "0x10177D8")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC88", Offset = "0x73DC88")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x10177F4", Offset = "0x10177F4", VA = "0x10177F4")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x10177FC", Offset = "0x10177FC", VA = "0x10177FC")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x1017818", Offset = "0x1017818", VA = "0x1017818")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DC98", Offset = "0x73DC98")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x1017834", Offset = "0x1017834", VA = "0x1017834")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x101783C", Offset = "0x101783C", VA = "0x101783C")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x1017860", Offset = "0x1017860", VA = "0x1017860")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCA8", Offset = "0x73DCA8")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x1017884", Offset = "0x1017884", VA = "0x1017884")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x101788C", Offset = "0x101788C", VA = "0x101788C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x10178B0", Offset = "0x10178B0", VA = "0x10178B0")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCB8", Offset = "0x73DCB8")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x10178D4", Offset = "0x10178D4", VA = "0x10178D4")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x10178DC", Offset = "0x10178DC", VA = "0x10178DC")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x10178E4", Offset = "0x10178E4", VA = "0x10178E4")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x20001CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCC8", Offset = "0x73DCC8")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x1017980", Offset = "0x1017980", VA = "0x1017980")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x1017988", Offset = "0x1017988", VA = "0x1017988")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x10179AC", Offset = "0x10179AC", VA = "0x10179AC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCD8", Offset = "0x73DCD8")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x10179D0", Offset = "0x10179D0", VA = "0x10179D0")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x10179D8", Offset = "0x10179D8", VA = "0x10179D8")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x10179FC", Offset = "0x10179FC", VA = "0x10179FC")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x20001D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCE8", Offset = "0x73DCE8")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x1017A20", Offset = "0x1017A20", VA = "0x1017A20")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x1017A28", Offset = "0x1017A28", VA = "0x1017A28")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x1017A34", Offset = "0x1017A34", VA = "0x1017A34")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DCF8", Offset = "0x73DCF8")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x1017AF0", Offset = "0x1017AF0", VA = "0x1017AF0")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x1017AF8", Offset = "0x1017AF8", VA = "0x1017AF8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x1017B04", Offset = "0x1017B04", VA = "0x1017B04")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DD08", Offset = "0x73DD08")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x1017C10", Offset = "0x1017C10", VA = "0x1017C10")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x1017C18", Offset = "0x1017C18", VA = "0x1017C18")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x1017C24", Offset = "0x1017C24", VA = "0x1017C24")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DD18", Offset = "0x73DD18")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x1017CE0", Offset = "0x1017CE0", VA = "0x1017CE0")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x1017CE8", Offset = "0x1017CE8", VA = "0x1017CE8")]
			internal Vector2 <DOShapeCircle>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x1017D04", Offset = "0x1017D04", VA = "0x1017D04")]
			internal void <DOShapeCircle>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xD02EDC", Offset = "0xD02EDC", VA = "0xD02EDC")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xD02644", Offset = "0xD02644", VA = "0xD02644")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xD02B8C", Offset = "0xD02B8C", VA = "0xD02B8C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xD08274", Offset = "0xD08274", VA = "0xD08274")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xD08444", Offset = "0xD08444", VA = "0xD08444")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xD085EC", Offset = "0xD085EC", VA = "0xD085EC")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xD087B8", Offset = "0xD087B8", VA = "0xD087B8")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xD089AC", Offset = "0xD089AC", VA = "0xD089AC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xD08B7C", Offset = "0xD08B7C", VA = "0xD08B7C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xD08D4C", Offset = "0xD08D4C", VA = "0xD08D4C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xD08F1C", Offset = "0xD08F1C", VA = "0xD08F1C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xD090EC", Offset = "0xD090EC", VA = "0xD090EC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xD09294", Offset = "0xD09294", VA = "0xD09294")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xD0944C", Offset = "0xD0944C", VA = "0xD0944C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xD0961C", Offset = "0xD0961C", VA = "0xD0961C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xD097E4", Offset = "0xD097E4", VA = "0xD097E4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xD01998", Offset = "0xD01998", VA = "0xD01998")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0xD099AC", Offset = "0xD099AC", VA = "0xD099AC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0xD09B78", Offset = "0xD09B78", VA = "0xD09B78")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0xD09D44", Offset = "0xD09D44", VA = "0xD09D44")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0xD09F10", Offset = "0xD09F10", VA = "0xD09F10")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xD0A0E0", Offset = "0xD0A0E0", VA = "0xD0A0E0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xD0A2B0", Offset = "0xD0A2B0", VA = "0xD0A2B0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xD0A468", Offset = "0xD0A468", VA = "0xD0A468")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xD0A624", Offset = "0xD0A624", VA = "0xD0A624")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xD022A4", Offset = "0xD022A4", VA = "0xD022A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xD032D8", Offset = "0xD032D8", VA = "0xD032D8")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xD0A7E0", Offset = "0xD0A7E0", VA = "0xD0A7E0")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
		{
			return null;
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xD034B0", Offset = "0xD034B0", VA = "0xD034B0")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
		{
			return null;
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xD0A9E8", Offset = "0xD0A9E8", VA = "0xD0A9E8")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xD0AE3C", Offset = "0xD0AE3C", VA = "0xD0AE3C")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xD0B000", Offset = "0xD0B000", VA = "0xD0B000")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xD0B1B4", Offset = "0xD0B1B4", VA = "0xD0B1B4")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xD0B368", Offset = "0xD0B368", VA = "0xD0B368")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xD02814", Offset = "0xD02814", VA = "0xD02814")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xD0B528", Offset = "0xD0B528", VA = "0xD0B528")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xD02D34", Offset = "0xD02D34", VA = "0xD02D34")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xD03084", Offset = "0xD03084", VA = "0xD03084")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xD0B750", Offset = "0xD0B750", VA = "0xD0B750")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xD0B9B4", Offset = "0xD0B9B4", VA = "0xD0B9B4")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xD0BC18", Offset = "0xD0BC18", VA = "0xD0BC18")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xD0BE7C", Offset = "0xD0BE7C", VA = "0xD0BE7C")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x20001D4")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x20001D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DD38", Offset = "0x73DD38")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x101824C", Offset = "0x101824C", VA = "0x101824C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x1018254", Offset = "0x1018254", VA = "0x1018254")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x1018278", Offset = "0x1018278", VA = "0x1018278")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DD48", Offset = "0x73DD48")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x101829C", Offset = "0x101829C", VA = "0x101829C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x10182A4", Offset = "0x10182A4", VA = "0x10182A4")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x10182C8", Offset = "0x10182C8", VA = "0x10182C8")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DD58", Offset = "0x73DD58")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x10182EC", Offset = "0x10182EC", VA = "0x10182EC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x1018530", Offset = "0x1018530", VA = "0x1018530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DD68", Offset = "0x73DD68")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x1018C40", Offset = "0x1018C40", VA = "0x1018C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x1018EA8", Offset = "0x1018EA8", VA = "0x1018EA8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DD78", Offset = "0x73DD78")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x1018794", Offset = "0x1018794", VA = "0x1018794", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x10189C4", Offset = "0x10189C4", VA = "0x10189C4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DD88", Offset = "0x73DD88")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x101853C", Offset = "0x101853C", VA = "0x101853C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x1018788", Offset = "0x1018788", VA = "0x1018788", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DD98", Offset = "0x73DD98")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x10189D0", Offset = "0x10189D0", VA = "0x10189D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x1018C34", Offset = "0x1018C34", VA = "0x1018C34", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20001DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DDA8", Offset = "0x73DDA8")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x1018EB4", Offset = "0x1018EB4", VA = "0x1018EB4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x10190EC", Offset = "0x10190EC", VA = "0x10190EC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xD0C08C", Offset = "0xD0C08C", VA = "0xD0C08C")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xD0C27C", Offset = "0xD0C27C", VA = "0xD0C27C")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xD0C480", Offset = "0xD0C480", VA = "0xD0C480")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xD0C540", Offset = "0xD0C540", VA = "0xD0C540")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xD0C600", Offset = "0xD0C600", VA = "0xD0C600")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xD0C6C0", Offset = "0xD0C6C0", VA = "0xD0C6C0")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xD0C790", Offset = "0xD0C790", VA = "0xD0C790")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xD0C860", Offset = "0xD0C860", VA = "0xD0C860")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xD0C920", Offset = "0xD0C920", VA = "0xD0C920")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xD0CB48", Offset = "0xD0CB48", VA = "0xD0CB48")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xD0CD70", Offset = "0xD0CD70", VA = "0xD0CD70")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x73F5AC", Offset = "0x73F5AC")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xD0CE8C", Offset = "0xD0CE8C", VA = "0xD0CE8C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x73F61C", Offset = "0x73F61C")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xD0CFA8", Offset = "0xD0CFA8", VA = "0xD0CFA8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x73F68C", Offset = "0x73F68C")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xD0D0C4", Offset = "0xD0D0C4", VA = "0xD0D0C4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x73F6FC", Offset = "0x73F6FC")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xD0D1F0", Offset = "0xD0D1F0", VA = "0xD0D1F0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x73F76C", Offset = "0x73F76C")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xD0D31C", Offset = "0xD0D31C", VA = "0xD0D31C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x73F7DC", Offset = "0x73F7DC")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x20001DD")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x20001DE")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700008B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A85")]
				[Address(RVA = "0x1016140", Offset = "0x1016140", VA = "0x1016140", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x1016174", Offset = "0x1016174", VA = "0x1016174")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x20001DF")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700008C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A87")]
				[Address(RVA = "0x1016338", Offset = "0x1016338", VA = "0x1016338", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x101639C", Offset = "0x101639C", VA = "0x101639C")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x20001E0")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700008D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A89")]
				[Address(RVA = "0x101623C", Offset = "0x101623C", VA = "0x101623C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x1016258", Offset = "0x1016258", VA = "0x1016258")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x20001E1")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700008E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A8B")]
				[Address(RVA = "0x10161A8", Offset = "0x10161A8", VA = "0x10161A8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x10161F4", Offset = "0x10161F4", VA = "0x10161F4")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x20001E2")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700008F")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A8D")]
				[Address(RVA = "0x101628C", Offset = "0x101628C", VA = "0x101628C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x10162F0", Offset = "0x10162F0", VA = "0x10162F0")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x20001E3")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000090")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A8F")]
				[Address(RVA = "0x10163D0", Offset = "0x10163D0", VA = "0x10163D0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1016404", Offset = "0x1016404", VA = "0x1016404")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x20001E4")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x20001E5")]
		public static class Physics
		{
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x10190F8", Offset = "0x10190F8", VA = "0x10190F8")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, UnityEngine.Transform trans)
			{
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x10191FC", Offset = "0x10191FC", VA = "0x10191FC")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x1019294", Offset = "0x1019294", VA = "0x1019294")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x101932C", Offset = "0x101932C", VA = "0x101932C")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0xD0D438", Offset = "0xD0D438", VA = "0xD0D438")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xD0D4FC", Offset = "0xD0D4FC", VA = "0xD0D4FC")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x20001E6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73DDB8", Offset = "0x73DDB8")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x20001E7")]
		public enum AnimationType
		{
			[Token(Token = "0x4000643")]
			None,
			[Token(Token = "0x4000644")]
			Move,
			[Token(Token = "0x4000645")]
			LocalMove,
			[Token(Token = "0x4000646")]
			Rotate,
			[Token(Token = "0x4000647")]
			LocalRotate,
			[Token(Token = "0x4000648")]
			Scale,
			[Token(Token = "0x4000649")]
			Color,
			[Token(Token = "0x400064A")]
			Fade,
			[Token(Token = "0x400064B")]
			Text,
			[Token(Token = "0x400064C")]
			PunchPosition,
			[Token(Token = "0x400064D")]
			PunchRotation,
			[Token(Token = "0x400064E")]
			PunchScale,
			[Token(Token = "0x400064F")]
			ShakePosition,
			[Token(Token = "0x4000650")]
			ShakeRotation,
			[Token(Token = "0x4000651")]
			ShakeScale,
			[Token(Token = "0x4000652")]
			CameraAspect,
			[Token(Token = "0x4000653")]
			CameraBackgroundColor,
			[Token(Token = "0x4000654")]
			CameraFieldOfView,
			[Token(Token = "0x4000655")]
			CameraOrthoSize,
			[Token(Token = "0x4000656")]
			CameraPixelRect,
			[Token(Token = "0x4000657")]
			CameraRect,
			[Token(Token = "0x4000658")]
			UIWidthHeight
		}

		[Token(Token = "0x20001E8")]
		public enum TargetType
		{
			[Token(Token = "0x400065A")]
			Unset,
			[Token(Token = "0x400065B")]
			Camera,
			[Token(Token = "0x400065C")]
			CanvasGroup,
			[Token(Token = "0x400065D")]
			Image,
			[Token(Token = "0x400065E")]
			Light,
			[Token(Token = "0x400065F")]
			RectTransform,
			[Token(Token = "0x4000660")]
			Renderer,
			[Token(Token = "0x4000661")]
			SpriteRenderer,
			[Token(Token = "0x4000662")]
			Rigidbody,
			[Token(Token = "0x4000663")]
			Rigidbody2D,
			[Token(Token = "0x4000664")]
			Text,
			[Token(Token = "0x4000665")]
			Transform,
			[Token(Token = "0x4000666")]
			tk2dBaseSprite,
			[Token(Token = "0x4000667")]
			tk2dTextMesh,
			[Token(Token = "0x4000668")]
			TextMeshPro,
			[Token(Token = "0x4000669")]
			TextMeshProUGUI
		}

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool autoGenerate;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isActive;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		public bool isValid;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public UnityEngine.Transform endValueTransform;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool optionalBool1;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public ShakeRandomnessMode optionalShakeRandomnessMode;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenAutoGenerationCalled;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0xCFFDE4", Offset = "0xCFFDE4", VA = "0xCFFDE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F8EC", Offset = "0x73F8EC")]
			add
			{
			}
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0xCFFEA0", Offset = "0xCFFEA0", VA = "0xCFFEA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F8FC", Offset = "0x73F8FC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xCFFF5C", Offset = "0xCFFF5C", VA = "0xCFFF5C")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xCFFFD8", Offset = "0xCFFFD8", VA = "0xCFFFD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xD01628", Offset = "0xD01628", VA = "0xD01628")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xD01674", Offset = "0xD01674", VA = "0xD01674")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0xD01678", Offset = "0xD01678", VA = "0xD01678")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0xD016BC", Offset = "0xD016BC", VA = "0xD016BC")]
		public void RewindThenRecreateTween()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0xD01700", Offset = "0xD01700", VA = "0xD01700")]
		public void RewindThenRecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0xD01744", Offset = "0xD01744", VA = "0xD01744")]
		public void RecreateTween()
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xD01750", Offset = "0xD01750", VA = "0xD01750")]
		public void RecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xD00030", Offset = "0xD00030", VA = "0xD00030")]
		public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
		{
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0xD036E0", Offset = "0xD036E0", VA = "0xD036E0")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0xD037F8", Offset = "0xD037F8", VA = "0xD037F8")]
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xD038F0", Offset = "0xD038F0", VA = "0xD038F0", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xD0397C", Offset = "0xD0397C", VA = "0xD0397C", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xD03A08", Offset = "0xD03A08", VA = "0xD03A08", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xD03A94", Offset = "0xD03A94", VA = "0xD03A94", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xD03B20", Offset = "0xD03B20", VA = "0xD03B20", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xD03BAC", Offset = "0xD03BAC", VA = "0xD03BAC", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xD03CA4", Offset = "0xD03CA4", VA = "0xD03CA4", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xD03CB4", Offset = "0xD03CB4", VA = "0xD03CB4", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xD04044", Offset = "0xD04044", VA = "0xD04044", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0xD040D4", Offset = "0xD040D4", VA = "0xD040D4", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0xD04174", Offset = "0xD04174", VA = "0xD04174")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xD04210", Offset = "0xD04210", VA = "0xD04210")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xD04274", Offset = "0xD04274", VA = "0xD04274")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0xD042D8", Offset = "0xD042D8", VA = "0xD042D8")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0xD04374", Offset = "0xD04374", VA = "0xD04374")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0xD043D8", Offset = "0xD043D8", VA = "0xD043D8")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0xD04474", Offset = "0xD04474", VA = "0xD04474")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xD044D8", Offset = "0xD044D8", VA = "0xD044D8")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xD04628", Offset = "0xD04628", VA = "0xD04628")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xD046C8", Offset = "0xD046C8", VA = "0xD046C8")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xD04744", Offset = "0xD04744", VA = "0xD04744")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xD047F0", Offset = "0xD047F0", VA = "0xD047F0")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xD04870", Offset = "0xD04870", VA = "0xD04870")]
		public void DOKillById(string id)
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xD04910", Offset = "0xD04910", VA = "0xD04910")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xD01774", Offset = "0xD01774", VA = "0xD01774")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xD04978", Offset = "0xD04978", VA = "0xD04978")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0xD0175C", Offset = "0xD0175C", VA = "0xD0175C")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0xD036C0", Offset = "0xD036C0", VA = "0xD036C0")]
		private GameObject GetTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0xD03DDC", Offset = "0xD03DDC", VA = "0xD03DDC")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0xD049BC", Offset = "0xD049BC", VA = "0xD049BC")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0xD04BCC", Offset = "0xD04BCC", VA = "0xD04BCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F90C", Offset = "0x73F90C")]
		private void <CreateTween>b__54_0()
		{
		}
	}
	[Token(Token = "0x20001E9")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000AC4")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001EA")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x20001EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DE10", Offset = "0x73DE10")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Transform target;

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x101951C", Offset = "0x101951C", VA = "0x101951C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x1019524", Offset = "0x1019524", VA = "0x1019524")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x1019540", Offset = "0x1019540", VA = "0x1019540")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DE20", Offset = "0x73DE20")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x101955C", Offset = "0x101955C", VA = "0x101955C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x1019564", Offset = "0x1019564", VA = "0x1019564")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0xD0D5B0", Offset = "0xD0D5B0", VA = "0xD0D5B0")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0xD0D5FC", Offset = "0xD0D5FC", VA = "0xD0D5FC")]
		public static Tweener DOSpiral(this UnityEngine.Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0xD0D92C", Offset = "0xD0D92C", VA = "0xD0D92C")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
namespace FlyingWormConsole3
{
	[Token(Token = "0x20001ED")]
	public class ConsoleProRemoteServer : MonoBehaviour
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useNATPunch;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int port;

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0xCFF418", Offset = "0xCFF418", VA = "0xCFF418")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0xCFF48C", Offset = "0xCFF48C", VA = "0xCFF48C")]
		public ConsoleProRemoteServer()
		{
		}
	}
}
namespace FlyingWormConsole3.LiteNetLib
{
	[Token(Token = "0x20001EE")]
	internal abstract class BaseChannel
	{
		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly NetPeer Peer;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly Queue<NetPacket> OutgoingQueue;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _isAddedToPeerChannelSendQueue;

		[Token(Token = "0x17000091")]
		public int PacketsInQueue
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0xEB40E0", Offset = "0xEB40E0", VA = "0xEB40E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0xEB412C", Offset = "0xEB412C", VA = "0xEB412C")]
		protected BaseChannel(NetPeer peer)
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0xEB41D0", Offset = "0xEB41D0", VA = "0xEB41D0")]
		public void AddToQueue(NetPacket packet)
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0xEB42DC", Offset = "0xEB42DC", VA = "0xEB42DC")]
		protected void AddToPeerChannelSendQueue()
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0xEB4330", Offset = "0xEB4330", VA = "0xEB4330")]
		public bool SendAndCheckQueue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD4")]
		protected abstract bool SendNextPackets();

		[Token(Token = "0x6000AD5")]
		public abstract bool ProcessPacket(NetPacket packet);
	}
	[Token(Token = "0x20001EF")]
	internal enum ConnectionRequestResult
	{
		[Token(Token = "0x4000672")]
		None,
		[Token(Token = "0x4000673")]
		Accept,
		[Token(Token = "0x4000674")]
		Reject,
		[Token(Token = "0x4000675")]
		RejectForce
	}
	[Token(Token = "0x20001F0")]
	public class ConnectionRequest
	{
		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetManager _listener;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _used;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly NetDataReader Data;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E190", Offset = "0x73E190")]
		private ConnectionRequestResult <Result>k__BackingField;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal long ConnectionTime;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal byte ConnectionNumber;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly IPEndPoint RemoteEndPoint;

		[Token(Token = "0x17000092")]
		internal ConnectionRequestResult Result
		{
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0xCFEAB8", Offset = "0xCFEAB8", VA = "0xCFEAB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F94C", Offset = "0x73F94C")]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0xCFEAC0", Offset = "0xCFEAC0", VA = "0xCFEAC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F95C", Offset = "0x73F95C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0xCFEAC8", Offset = "0xCFEAC8", VA = "0xCFEAC8")]
		private bool TryActivate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0xCFEAF4", Offset = "0xCFEAF4", VA = "0xCFEAF4")]
		internal void UpdateRequest(NetConnectRequestPacket connRequest)
		{
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xCFEB24", Offset = "0xCFEB24", VA = "0xCFEB24")]
		internal ConnectionRequest(long connectionId, byte connectionNumber, NetDataReader netDataReader, IPEndPoint endPoint, NetManager listener)
		{
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0xCFEBA0", Offset = "0xCFEBA0", VA = "0xCFEBA0")]
		public NetPeer AcceptIfKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0xCFEDCC", Offset = "0xCFEDCC", VA = "0xCFEDCC")]
		public NetPeer Accept()
		{
			return null;
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0xCFEE38", Offset = "0xCFEE38", VA = "0xCFEE38")]
		public void Reject(byte[] rejectData, int start, int length, bool force)
		{
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0xCFEED4", Offset = "0xCFEED4", VA = "0xCFEED4")]
		public void Reject(byte[] rejectData, int start, int length)
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0xCFEEDC", Offset = "0xCFEEDC", VA = "0xCFEEDC")]
		public void RejectForce(byte[] rejectData, int start, int length)
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0xCFEEE4", Offset = "0xCFEEE4", VA = "0xCFEEE4")]
		public void RejectForce()
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0xCFEEF8", Offset = "0xCFEEF8", VA = "0xCFEEF8")]
		public void RejectForce(byte[] rejectData)
		{
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0xCFEF18", Offset = "0xCFEF18", VA = "0xCFEF18")]
		public void RejectForce(NetDataWriter rejectData)
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0xCFEF40", Offset = "0xCFEF40", VA = "0xCFEF40")]
		public void Reject()
		{
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0xCFEF54", Offset = "0xCFEF54", VA = "0xCFEF54")]
		public void Reject(byte[] rejectData)
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0xCFEF74", Offset = "0xCFEF74", VA = "0xCFEF74")]
		public void Reject(NetDataWriter rejectData)
		{
		}
	}
	[Token(Token = "0x20001F1")]
	public enum UnconnectedMessageType
	{
		[Token(Token = "0x400067E")]
		BasicMessage,
		[Token(Token = "0x400067F")]
		Broadcast
	}
	[Token(Token = "0x20001F2")]
	public enum DisconnectReason
	{
		[Token(Token = "0x4000681")]
		ConnectionFailed,
		[Token(Token = "0x4000682")]
		Timeout,
		[Token(Token = "0x4000683")]
		HostUnreachable,
		[Token(Token = "0x4000684")]
		NetworkUnreachable,
		[Token(Token = "0x4000685")]
		RemoteConnectionClose,
		[Token(Token = "0x4000686")]
		DisconnectPeerCalled,
		[Token(Token = "0x4000687")]
		ConnectionRejected,
		[Token(Token = "0x4000688")]
		InvalidProtocol,
		[Token(Token = "0x4000689")]
		UnknownHost,
		[Token(Token = "0x400068A")]
		Reconnect,
		[Token(Token = "0x400068B")]
		PeerToPeerConnection
	}
	[Token(Token = "0x20001F3")]
	public struct DisconnectInfo
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DisconnectReason Reason;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SocketError SocketErrorCode;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public NetPacketReader AdditionalData;
	}
	[Token(Token = "0x20001F4")]
	public interface INetEventListener
	{
		[Token(Token = "0x6000AE6")]
		void OnPeerConnected(NetPeer peer);

		[Token(Token = "0x6000AE7")]
		void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo);

		[Token(Token = "0x6000AE8")]
		void OnNetworkError(IPEndPoint endPoint, SocketError socketError);

		[Token(Token = "0x6000AE9")]
		void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod);

		[Token(Token = "0x6000AEA")]
		void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType);

		[Token(Token = "0x6000AEB")]
		void OnNetworkLatencyUpdate(NetPeer peer, int latency);

		[Token(Token = "0x6000AEC")]
		void OnConnectionRequest(ConnectionRequest request);
	}
	[Token(Token = "0x20001F5")]
	public interface IDeliveryEventListener
	{
		[Token(Token = "0x6000AED")]
		void OnMessageDelivered(NetPeer peer, object userData);
	}
	[Token(Token = "0x20001F6")]
	public interface INtpEventListener
	{
		[Token(Token = "0x6000AEE")]
		void OnNtpResponse(NtpPacket packet);
	}
	[Token(Token = "0x20001F7")]
	public class EventBasedNetListener : INetEventListener, IDeliveryEventListener, INtpEventListener
	{
		[Token(Token = "0x20001F8")]
		public delegate void OnPeerConnected(NetPeer peer);

		[Token(Token = "0x20001F9")]
		public delegate void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo);

		[Token(Token = "0x20001FA")]
		public delegate void OnNetworkError(IPEndPoint endPoint, SocketError socketError);

		[Token(Token = "0x20001FB")]
		public delegate void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod);

		[Token(Token = "0x20001FC")]
		public delegate void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType);

		[Token(Token = "0x20001FD")]
		public delegate void OnNetworkLatencyUpdate(NetPeer peer, int latency);

		[Token(Token = "0x20001FE")]
		public delegate void OnConnectionRequest(ConnectionRequest request);

		[Token(Token = "0x20001FF")]
		public delegate void OnDeliveryEvent(NetPeer peer, object userData);

		[Token(Token = "0x2000200")]
		public delegate void OnNtpResponseEvent(NtpPacket packet);

		[Token(Token = "0x14000002")]
		public event OnPeerConnected PeerConnectedEvent
		{
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x1467DF8", Offset = "0x1467DF8", VA = "0x1467DF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F96C", Offset = "0x73F96C")]
			add
			{
			}
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x1467E98", Offset = "0x1467E98", VA = "0x1467E98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F97C", Offset = "0x73F97C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event OnPeerDisconnected PeerDisconnectedEvent
		{
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x1467F38", Offset = "0x1467F38", VA = "0x1467F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F98C", Offset = "0x73F98C")]
			add
			{
			}
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x1467FD8", Offset = "0x1467FD8", VA = "0x1467FD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F99C", Offset = "0x73F99C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event OnNetworkError NetworkErrorEvent
		{
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x1468078", Offset = "0x1468078", VA = "0x1468078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F9AC", Offset = "0x73F9AC")]
			add
			{
			}
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x1468118", Offset = "0x1468118", VA = "0x1468118")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F9BC", Offset = "0x73F9BC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event OnNetworkReceive NetworkReceiveEvent
		{
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x14681B8", Offset = "0x14681B8", VA = "0x14681B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F9CC", Offset = "0x73F9CC")]
			add
			{
			}
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x1468258", Offset = "0x1468258", VA = "0x1468258")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F9DC", Offset = "0x73F9DC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event OnNetworkReceiveUnconnected NetworkReceiveUnconnectedEvent
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x14682F8", Offset = "0x14682F8", VA = "0x14682F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F9EC", Offset = "0x73F9EC")]
			add
			{
			}
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x1468398", Offset = "0x1468398", VA = "0x1468398")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F9FC", Offset = "0x73F9FC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event OnNetworkLatencyUpdate NetworkLatencyUpdateEvent
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x1468438", Offset = "0x1468438", VA = "0x1468438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA0C", Offset = "0x73FA0C")]
			add
			{
			}
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x14684D8", Offset = "0x14684D8", VA = "0x14684D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA1C", Offset = "0x73FA1C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event OnConnectionRequest ConnectionRequestEvent
		{
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x1468578", Offset = "0x1468578", VA = "0x1468578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA2C", Offset = "0x73FA2C")]
			add
			{
			}
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x1468618", Offset = "0x1468618", VA = "0x1468618")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA3C", Offset = "0x73FA3C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event OnDeliveryEvent DeliveryEvent
		{
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x14686B8", Offset = "0x14686B8", VA = "0x14686B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA4C", Offset = "0x73FA4C")]
			add
			{
			}
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x1468758", Offset = "0x1468758", VA = "0x1468758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA5C", Offset = "0x73FA5C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event OnNtpResponseEvent NtpResponseEvent
		{
			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x14687F8", Offset = "0x14687F8", VA = "0x14687F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA6C", Offset = "0x73FA6C")]
			add
			{
			}
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x1468898", Offset = "0x1468898", VA = "0x1468898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA7C", Offset = "0x73FA7C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x1468938", Offset = "0x1468938", VA = "0x1468938")]
		public void ClearPeerConnectedEvent()
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x1468944", Offset = "0x1468944", VA = "0x1468944")]
		public void ClearPeerDisconnectedEvent()
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x1468950", Offset = "0x1468950", VA = "0x1468950")]
		public void ClearNetworkErrorEvent()
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x146895C", Offset = "0x146895C", VA = "0x146895C")]
		public void ClearNetworkReceiveEvent()
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x1468968", Offset = "0x1468968", VA = "0x1468968")]
		public void ClearNetworkReceiveUnconnectedEvent()
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x1468974", Offset = "0x1468974", VA = "0x1468974")]
		public void ClearNetworkLatencyUpdateEvent()
		{
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x1468980", Offset = "0x1468980", VA = "0x1468980")]
		public void ClearConnectionRequestEvent()
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x146898C", Offset = "0x146898C", VA = "0x146898C")]
		public void ClearDeliveryEvent()
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x1468998", Offset = "0x1468998", VA = "0x1468998")]
		public void ClearNtpResponseEvent()
		{
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x14689A4", Offset = "0x14689A4", VA = "0x14689A4", Slot = "4")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnPeerConnected(NetPeer peer)
		{
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x14689B8", Offset = "0x14689B8", VA = "0x14689B8", Slot = "5")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x14689CC", Offset = "0x14689CC", VA = "0x14689CC", Slot = "6")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkError(IPEndPoint endPoint, SocketError socketErrorCode)
		{
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x14689E0", Offset = "0x14689E0", VA = "0x14689E0", Slot = "7")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x14689F4", Offset = "0x14689F4", VA = "0x14689F4", Slot = "8")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x1468A08", Offset = "0x1468A08", VA = "0x1468A08", Slot = "9")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnNetworkLatencyUpdate(NetPeer peer, int latency)
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x1468A1C", Offset = "0x1468A1C", VA = "0x1468A1C", Slot = "10")]
		private void FlyingWormConsole3.LiteNetLib.INetEventListener.OnConnectionRequest(ConnectionRequest request)
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x1468A30", Offset = "0x1468A30", VA = "0x1468A30", Slot = "11")]
		private void FlyingWormConsole3.LiteNetLib.IDeliveryEventListener.OnMessageDelivered(NetPeer peer, object userData)
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x1468A44", Offset = "0x1468A44", VA = "0x1468A44", Slot = "12")]
		private void FlyingWormConsole3.LiteNetLib.INtpEventListener.OnNtpResponse(NtpPacket packet)
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x1468A58", Offset = "0x1468A58", VA = "0x1468A58")]
		public EventBasedNetListener()
		{
		}
	}
	[Token(Token = "0x2000201")]
	public enum NatAddressType
	{
		[Token(Token = "0x4000699")]
		Internal,
		[Token(Token = "0x400069A")]
		External
	}
	[Token(Token = "0x2000202")]
	public interface INatPunchListener
	{
		[Token(Token = "0x6000B38")]
		void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

		[Token(Token = "0x6000B39")]
		void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token);
	}
	[Token(Token = "0x2000203")]
	public class EventBasedNatPunchListener : INatPunchListener
	{
		[Token(Token = "0x2000204")]
		public delegate void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

		[Token(Token = "0x2000205")]
		public delegate void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token);

		[Token(Token = "0x1400000B")]
		public event OnNatIntroductionRequest NatIntroductionRequest
		{
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x1467B48", Offset = "0x1467B48", VA = "0x1467B48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA8C", Offset = "0x73FA8C")]
			add
			{
			}
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x1467BE8", Offset = "0x1467BE8", VA = "0x1467BE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA9C", Offset = "0x73FA9C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event OnNatIntroductionSuccess NatIntroductionSuccess
		{
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x1467C88", Offset = "0x1467C88", VA = "0x1467C88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FAAC", Offset = "0x73FAAC")]
			add
			{
			}
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x1467D28", Offset = "0x1467D28", VA = "0x1467D28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FABC", Offset = "0x73FABC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x1467DC8", Offset = "0x1467DC8", VA = "0x1467DC8", Slot = "4")]
		private void FlyingWormConsole3.LiteNetLib.INatPunchListener.OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token)
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x1467DDC", Offset = "0x1467DDC", VA = "0x1467DDC", Slot = "5")]
		private void FlyingWormConsole3.LiteNetLib.INatPunchListener.OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token)
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x1467DF0", Offset = "0x1467DF0", VA = "0x1467DF0")]
		public EventBasedNatPunchListener()
		{
		}
	}
	[Token(Token = "0x2000206")]
	public sealed class NatPunchModule
	{
		[Token(Token = "0x2000207")]
		private struct RequestEventData
		{
			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IPEndPoint LocalEndPoint;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IPEndPoint RemoteEndPoint;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Token;
		}

		[Token(Token = "0x2000208")]
		private struct SuccessEventData
		{
			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IPEndPoint TargetEndPoint;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public NatAddressType Type;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Token;
		}

		[Token(Token = "0x2000209")]
		private class NatIntroduceRequestPacket
		{
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E250", Offset = "0x73E250")]
			private IPEndPoint <Internal>k__BackingField;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E260", Offset = "0x73E260")]
			private string <Token>k__BackingField;

			[Token(Token = "0x17000093")]
			public IPEndPoint Internal
			{
				[Token(Token = "0x6000B54")]
				[Address(RVA = "0x1021344", Offset = "0x1021344", VA = "0x1021344")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FACC", Offset = "0x73FACC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B55")]
				[Address(RVA = "0x102134C", Offset = "0x102134C", VA = "0x102134C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FADC", Offset = "0x73FADC")]
				set
				{
				}
			}

			[Token(Token = "0x17000094")]
			public string Token
			{
				[Token(Token = "0x6000B56")]
				[Address(RVA = "0x1021354", Offset = "0x1021354", VA = "0x1021354")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FAEC", Offset = "0x73FAEC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B57")]
				[Address(RVA = "0x102135C", Offset = "0x102135C", VA = "0x102135C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FAFC", Offset = "0x73FAFC")]
				set
				{
				}
			}

			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x1021364", Offset = "0x1021364", VA = "0x1021364")]
			public NatIntroduceRequestPacket()
			{
			}
		}

		[Token(Token = "0x200020A")]
		private class NatIntroduceResponsePacket
		{
			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E270", Offset = "0x73E270")]
			private IPEndPoint <Internal>k__BackingField;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E280", Offset = "0x73E280")]
			private IPEndPoint <External>k__BackingField;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E290", Offset = "0x73E290")]
			private string <Token>k__BackingField;

			[Token(Token = "0x17000095")]
			public IPEndPoint Internal
			{
				[Token(Token = "0x6000B59")]
				[Address(RVA = "0x102136C", Offset = "0x102136C", VA = "0x102136C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FB0C", Offset = "0x73FB0C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B5A")]
				[Address(RVA = "0x1021374", Offset = "0x1021374", VA = "0x1021374")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FB1C", Offset = "0x73FB1C")]
				set
				{
				}
			}

			[Token(Token = "0x17000096")]
			public IPEndPoint External
			{
				[Token(Token = "0x6000B5B")]
				[Address(RVA = "0x102137C", Offset = "0x102137C", VA = "0x102137C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FB2C", Offset = "0x73FB2C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B5C")]
				[Address(RVA = "0x1021384", Offset = "0x1021384", VA = "0x1021384")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FB3C", Offset = "0x73FB3C")]
				set
				{
				}
			}

			[Token(Token = "0x17000097")]
			public string Token
			{
				[Token(Token = "0x6000B5D")]
				[Address(RVA = "0x102138C", Offset = "0x102138C", VA = "0x102138C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FB4C", Offset = "0x73FB4C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B5E")]
				[Address(RVA = "0x1021394", Offset = "0x1021394", VA = "0x1021394")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FB5C", Offset = "0x73FB5C")]
				set
				{
				}
			}

			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0x102139C", Offset = "0x102139C", VA = "0x102139C")]
			public NatIntroduceResponsePacket()
			{
			}
		}

		[Token(Token = "0x200020B")]
		private class NatPunchPacket
		{
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2A0", Offset = "0x73E2A0")]
			private string <Token>k__BackingField;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2B0", Offset = "0x73E2B0")]
			private bool <IsExternal>k__BackingField;

			[Token(Token = "0x17000098")]
			public string Token
			{
				[Token(Token = "0x6000B60")]
				[Address(RVA = "0x10213A4", Offset = "0x10213A4", VA = "0x10213A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FB6C", Offset = "0x73FB6C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B61")]
				[Address(RVA = "0x10213AC", Offset = "0x10213AC", VA = "0x10213AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FB7C", Offset = "0x73FB7C")]
				set
				{
				}
			}

			[Token(Token = "0x17000099")]
			public bool IsExternal
			{
				[Token(Token = "0x6000B62")]
				[Address(RVA = "0x10213B4", Offset = "0x10213B4", VA = "0x10213B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FB8C", Offset = "0x73FB8C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000B63")]
				[Address(RVA = "0x10213BC", Offset = "0x10213BC", VA = "0x10213BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FB9C", Offset = "0x73FB9C")]
				set
				{
				}
			}

			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x10213C8", Offset = "0x10213C8", VA = "0x10213C8")]
			public NatPunchPacket()
			{
			}
		}

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetSocket _socket;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Queue<RequestEventData> _requestEvents;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Queue<SuccessEventData> _successEvents;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly NetDataReader _cacheReader;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly NetDataWriter _cacheWriter;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetPacketProcessor _netPacketProcessor;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private INatPunchListener _natPunchListener;

		[Token(Token = "0x40006A4")]
		public const int MaxTokenLength = 256;

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x146DEF8", Offset = "0x146DEF8", VA = "0x146DEF8")]
		internal NatPunchModule(NetSocket socket)
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x146E33C", Offset = "0x146E33C", VA = "0x146E33C")]
		internal void ProcessMessage(IPEndPoint senderEndPoint, NetPacket packet)
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x146E504", Offset = "0x146E504", VA = "0x146E504")]
		public void Init(INatPunchListener listener)
		{
		}

		[Token(Token = "0x6000B4C")]
		private void Send<T>(T packet, IPEndPoint target) where T : class, new()
		{
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x146E50C", Offset = "0x146E50C", VA = "0x146E50C")]
		public void NatIntroduce(IPEndPoint hostInternal, IPEndPoint hostExternal, IPEndPoint clientInternal, IPEndPoint clientExternal, string additionalInfo)
		{
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x146E628", Offset = "0x146E628", VA = "0x146E628")]
		public void PollEvents()
		{
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x146E9D8", Offset = "0x146E9D8", VA = "0x146E9D8")]
		public void SendNatIntroduceRequest(string host, int port, string additionalInfo)
		{
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x146EA6C", Offset = "0x146EA6C", VA = "0x146EA6C")]
		public void SendNatIntroduceRequest(IPEndPoint masterServerEndPoint, string additionalInfo)
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x146EBCC", Offset = "0x146EBCC", VA = "0x146EBCC")]
		private void OnNatIntroductionRequest(NatIntroduceRequestPacket req, IPEndPoint senderEndPoint)
		{
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x146ED60", Offset = "0x146ED60", VA = "0x146ED60")]
		private void OnNatIntroductionResponse(NatIntroduceResponsePacket req)
		{
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x146EECC", Offset = "0x146EECC", VA = "0x146EECC")]
		private void OnNatPunch(NatPunchPacket req, IPEndPoint senderEndPoint)
		{
		}
	}
	[Token(Token = "0x200020C")]
	public enum DeliveryMethod : byte
	{
		[Token(Token = "0x40006B3")]
		Unreliable = 4,
		[Token(Token = "0x40006B4")]
		ReliableUnordered = 0,
		[Token(Token = "0x40006B5")]
		Sequenced = 1,
		[Token(Token = "0x40006B6")]
		ReliableOrdered = 2,
		[Token(Token = "0x40006B7")]
		ReliableSequenced = 3
	}
	[Token(Token = "0x200020D")]
	public static class NetConstants
	{
		[Token(Token = "0x40006B8")]
		public const int DefaultWindowSize = 64;

		[Token(Token = "0x40006B9")]
		public const int SocketBufferSize = 1048576;

		[Token(Token = "0x40006BA")]
		public const int SocketTTL = 255;

		[Token(Token = "0x40006BB")]
		public const int HeaderSize = 1;

		[Token(Token = "0x40006BC")]
		public const int ChanneledHeaderSize = 4;

		[Token(Token = "0x40006BD")]
		public const int FragmentHeaderSize = 6;

		[Token(Token = "0x40006BE")]
		public const int FragmentedHeaderTotalSize = 10;

		[Token(Token = "0x40006BF")]
		public const ushort MaxSequence = 32768;

		[Token(Token = "0x40006C0")]
		public const ushort HalfMaxSequence = 16384;

		[Token(Token = "0x40006C1")]
		internal const int ProtocolId = 11;

		[Token(Token = "0x40006C2")]
		internal const int MaxUdpHeaderSize = 68;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly int[] PossibleMtu;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly int MaxPacketSize;

		[Token(Token = "0x40006C5")]
		public const byte MaxConnectionNumber = 4;

		[Token(Token = "0x40006C6")]
		public const int PacketPoolSize = 1000;
	}
	[Token(Token = "0x200020E")]
	public class InvalidPacketException : ArgumentException
	{
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x1469E70", Offset = "0x1469E70", VA = "0x1469E70")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Token(Token = "0x200020F")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x1484920", Offset = "0x1484920", VA = "0x1484920")]
		public TooBigPacketException(string message)
		{
		}
	}
	[Token(Token = "0x2000210")]
	public enum NetLogLevel
	{
		[Token(Token = "0x40006C8")]
		Warning,
		[Token(Token = "0x40006C9")]
		Error,
		[Token(Token = "0x40006CA")]
		Trace,
		[Token(Token = "0x40006CB")]
		Info
	}
	[Token(Token = "0x2000211")]
	public interface INetLogger
	{
		[Token(Token = "0x6000B68")]
		void WriteNet(NetLogLevel level, string str, params object[] args);
	}
	[Token(Token = "0x2000212")]
	public static class NetDebug
	{
		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static INetLogger Logger;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object DebugLogLock;

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x1472BE4", Offset = "0x1472BE4", VA = "0x1472BE4")]
		private static void WriteLogic(NetLogLevel logLevel, string str, params object[] args)
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x1472E28", Offset = "0x1472E28", VA = "0x1472E28")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x73FBAC", Offset = "0x73FBAC")]
		internal static void Write(string str, params object[] args)
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x1472E9C", Offset = "0x1472E9C", VA = "0x1472E9C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x73FBE4", Offset = "0x73FBE4")]
		internal static void Write(NetLogLevel level, string str, params object[] args)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x1472F14", Offset = "0x1472F14", VA = "0x1472F14")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x73FC1C", Offset = "0x73FC1C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x73FC1C", Offset = "0x73FC1C")]
		internal static void WriteForce(string str, params object[] args)
		{
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x1472F88", Offset = "0x1472F88", VA = "0x1472F88")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x73FC7C", Offset = "0x73FC7C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x73FC7C", Offset = "0x73FC7C")]
		internal static void WriteForce(NetLogLevel level, string str, params object[] args)
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x1473000", Offset = "0x1473000", VA = "0x1473000")]
		internal static void WriteError(string str, params object[] args)
		{
		}
	}
	[Token(Token = "0x2000213")]
	public enum IPv6Mode
	{
		[Token(Token = "0x40006CF")]
		Disabled,
		[Token(Token = "0x40006D0")]
		SeparateSocket,
		[Token(Token = "0x40006D1")]
		DualMode
	}
	[Token(Token = "0x2000214")]
	public sealed class NetPacketReader : NetDataReader
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private NetPacket _packet;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly NetManager _manager;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetEvent _evt;

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x14BCB54", Offset = "0x14BCB54", VA = "0x14BCB54")]
		internal NetPacketReader(NetManager manager, NetEvent evt)
		{
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x14BCBA4", Offset = "0x14BCBA4", VA = "0x14BCBA4")]
		internal void SetSource(NetPacket packet, int headerSize)
		{
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x14BCBF4", Offset = "0x14BCBF4", VA = "0x14BCBF4")]
		internal void RecycleInternal()
		{
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x14BCC60", Offset = "0x14BCC60", VA = "0x14BCC60")]
		public void Recycle()
		{
		}
	}
	[Token(Token = "0x2000215")]
	internal sealed class NetEvent
	{
		[Token(Token = "0x2000216")]
		public enum EType
		{
			[Token(Token = "0x40006E1")]
			Connect,
			[Token(Token = "0x40006E2")]
			Disconnect,
			[Token(Token = "0x40006E3")]
			Receive,
			[Token(Token = "0x40006E4")]
			ReceiveUnconnected,
			[Token(Token = "0x40006E5")]
			Error,
			[Token(Token = "0x40006E6")]
			ConnectionLatencyUpdated,
			[Token(Token = "0x40006E7")]
			Broadcast,
			[Token(Token = "0x40006E8")]
			ConnectionRequest,
			[Token(Token = "0x40006E9")]
			MessageDelivered
		}

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NetEvent Next;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EType Type;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NetPeer Peer;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IPEndPoint RemoteEndPoint;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public object UserData;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Latency;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public SocketError ErrorCode;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DisconnectReason DisconnectReason;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ConnectionRequest ConnectionRequest;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DeliveryMethod DeliveryMethod;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly NetPacketReader DataReader;

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x1473100", Offset = "0x1473100", VA = "0x1473100")]
		public NetEvent(NetManager manager)
		{
		}
	}
	[Token(Token = "0x2000217")]
	public class NetManager : IEnumerable<NetPeer>, IEnumerable
	{
		[Token(Token = "0x2000218")]
		private class IPEndPointComparer : IEqualityComparer<IPEndPoint>
		{
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x10213D0", Offset = "0x10213D0", VA = "0x10213D0", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x1021430", Offset = "0x1021430", VA = "0x1021430", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x1021450", Offset = "0x1021450", VA = "0x1021450")]
			public IPEndPointComparer()
			{
			}
		}

		[Token(Token = "0x2000219")]
		public struct NetPeerEnumerator : IEnumerator<NetPeer>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly NetPeer _initialPeer;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private NetPeer _p;

			[Token(Token = "0x170000A1")]
			public NetPeer Current
			{
				[Token(Token = "0x6000BCF")]
				[Address(RVA = "0x102151C", Offset = "0x102151C", VA = "0x102151C", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BD0")]
				[Address(RVA = "0x1021524", Offset = "0x1021524", VA = "0x1021524", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x1021458", Offset = "0x1021458", VA = "0x1021458")]
			public NetPeerEnumerator(NetPeer p)
			{
			}

			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x1021488", Offset = "0x1021488", VA = "0x1021488", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x102148C", Offset = "0x102148C", VA = "0x102148C", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x10214DC", Offset = "0x10214DC", VA = "0x10214DC", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetSocket _socket;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Thread _logicThread;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _manualMode;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly AutoResetEvent _updateTriggerEvent;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Queue<NetEvent> _netEventsQueue;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NetEvent _netEventPoolHead;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly INetEventListener _netEventListener;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly IDeliveryEventListener _deliveryEventListener;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly INtpEventListener _ntpEventListener;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<IPEndPoint, NetPeer> _peersDict;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly Dictionary<IPEndPoint, ConnectionRequest> _requestsDict;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly Dictionary<IPEndPoint, NtpRequest> _ntpRequests;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly ReaderWriterLockSlim _peersLock;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private NetPeer _headPeer;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _connectedPeersCount;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<NetPeer> _connectedPeerListCache;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NetPeer[] _peersArray;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly PacketLayerBase _extraPacketLayer;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastPeerId;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Queue<int> _peerIds;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private byte _channelsCount;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly object _eventLock;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal readonly NetPacketPool NetPacketPool;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool UnconnectedMessagesEnabled;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool NatPunchEnabled;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public int UpdateTime;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int PingInterval;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int DisconnectTimeout;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool SimulatePacketLoss;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool SimulateLatency;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public int SimulationPacketLossChance;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public int SimulationMinLatency;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public int SimulationMaxLatency;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool UnsyncedEvents;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		public bool UnsyncedReceiveEvent;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		public bool UnsyncedDeliveryEvent;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		public bool BroadcastReceiveEnabled;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public int ReconnectDelay;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int MaxConnectAttempts;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool ReuseAddress;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public readonly NetStatistics Statistics;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public bool EnableStatistics;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public readonly NatPunchModule NatPunchModule;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool AutoRecycle;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public IPv6Mode IPv6Enabled;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int MtuOverride;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool UseSafeMtu;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		public bool DisconnectOnUnreachable;

		[Token(Token = "0x1700009A")]
		public bool IsRunning
		{
			[Token(Token = "0x6000B75")]
			[Address(RVA = "0x1473184", Offset = "0x1473184", VA = "0x1473184")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		public int LocalPort
		{
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x14731B4", Offset = "0x14731B4", VA = "0x14731B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009C")]
		public NetPeer FirstPeer
		{
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x14731D0", Offset = "0x14731D0", VA = "0x14731D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public byte ChannelsCount
		{
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x14731F4", Offset = "0x14731F4", VA = "0x14731F4")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x14731FC", Offset = "0x14731FC", VA = "0x14731FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public List<NetPeer> ConnectedPeerList
		{
			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x1473268", Offset = "0x1473268", VA = "0x1473268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public int ConnectedPeersCount
		{
			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x14733A4", Offset = "0x14733A4", VA = "0x14733A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A0")]
		public int ExtraPacketSizeForLayer
		{
			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0x14733C8", Offset = "0x14733C8", VA = "0x14733C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x1473368", Offset = "0x1473368", VA = "0x1473368")]
		public NetPeer GetPeerById(int id)
		{
			return null;
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x14733E0", Offset = "0x14733E0", VA = "0x14733E0")]
		private bool TryGetPeer(IPEndPoint endPoint, out NetPeer peer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x147347C", Offset = "0x147347C", VA = "0x147347C")]
		private void AddPeer(NetPeer peer)
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x147360C", Offset = "0x147360C", VA = "0x147360C")]
		private void RemovePeer(NetPeer peer)
		{
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x1473658", Offset = "0x1473658", VA = "0x1473658")]
		private void RemovePeerInternal(NetPeer peer)
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x1473860", Offset = "0x1473860", VA = "0x1473860")]
		public NetManager(INetEventListener listener, [Optional] PacketLayerBase extraPacketLayer)
		{
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x1473DC8", Offset = "0x1473DC8", VA = "0x1473DC8")]
		internal void ConnectionLatencyUpdated(NetPeer fromPeer, int latency)
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x1474148", Offset = "0x1474148", VA = "0x1474148")]
		internal void MessageDelivered(NetPeer fromPeer, object userData)
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x1474198", Offset = "0x1474198", VA = "0x1474198")]
		internal int SendRawAndRecycle(NetPacket packet, IPEndPoint remoteEndPoint)
		{
			return default(int);
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x14745B8", Offset = "0x14745B8", VA = "0x14745B8")]
		internal int SendRaw(NetPacket packet, IPEndPoint remoteEndPoint)
		{
			return default(int);
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x14741F0", Offset = "0x14741F0", VA = "0x14741F0")]
		internal int SendRaw(byte[] message, int start, int length, IPEndPoint remoteEndPoint)
		{
			return default(int);
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x1474808", Offset = "0x1474808", VA = "0x1474808")]
		internal void DisconnectPeerForce(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, NetPacket eventData)
		{
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x147483C", Offset = "0x147483C", VA = "0x147483C")]
		private void DisconnectPeer(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, bool force, byte[] data, int start, int count, NetPacket eventData)
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x1473E0C", Offset = "0x1473E0C", VA = "0x1473E0C")]
		private void CreateEvent(NetEvent.EType type, [Optional] NetPeer peer, [Optional] IPEndPoint remoteEndPoint, SocketError errorCode = SocketError.Success, int latency = 0, DisconnectReason disconnectReason = DisconnectReason.ConnectionFailed, [Optional] ConnectionRequest connectionRequest, DeliveryMethod deliveryMethod = DeliveryMethod.Unreliable, [Optional] NetPacket readerSource, [Optional] object userData)
		{
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x14749A4", Offset = "0x14749A4", VA = "0x14749A4")]
		private void ProcessEvent(NetEvent evt)
		{
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x1474F14", Offset = "0x1474F14", VA = "0x1474F14")]
		internal void RecycleEvent(NetEvent evt)
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x147503C", Offset = "0x147503C", VA = "0x147503C")]
		private void UpdateLogic()
		{
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x14755E4", Offset = "0x14755E4", VA = "0x14755E4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x73FCDC", Offset = "0x73FCDC")]
		private void ProcessDelayedPackets()
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x14752A0", Offset = "0x14752A0", VA = "0x14752A0")]
		private void ProcessNtpRequests(int elapsedMilliseconds)
		{
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x14755E8", Offset = "0x14755E8", VA = "0x14755E8")]
		public void ManualUpdate(int elapsedMilliseconds)
		{
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x1475674", Offset = "0x1475674", VA = "0x1475674")]
		public void ManualReceive()
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x147569C", Offset = "0x147569C", VA = "0x147569C")]
		internal void OnMessageReceived(NetPacket packet, SocketError errorCode, IPEndPoint remoteEndPoint)
		{
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x14761CC", Offset = "0x14761CC", VA = "0x14761CC")]
		internal NetPeer OnConnectionSolved(ConnectionRequest request, byte[] rejectData, int start, int length)
		{
			return null;
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x1476700", Offset = "0x1476700", VA = "0x1476700")]
		private int GetNextPeerId()
		{
			return default(int);
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x1476834", Offset = "0x1476834", VA = "0x1476834")]
		private void ProcessConnectRequest(IPEndPoint remoteEndPoint, NetPeer netPeer, NetConnectRequestPacket connRequest)
		{
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x14759C8", Offset = "0x14759C8", VA = "0x14759C8")]
		private void DataReceived(NetPacket packet, IPEndPoint remoteEndPoint)
		{
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x1476CE0", Offset = "0x1476CE0", VA = "0x1476CE0")]
		internal void CreateReceiveEvent(NetPacket packet, DeliveryMethod method, int headerSize, NetPeer fromPeer)
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x1476F70", Offset = "0x1476F70", VA = "0x1476F70")]
		public void SendToAll(NetDataWriter writer, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x1476FA8", Offset = "0x1476FA8", VA = "0x1476FA8")]
		public void SendToAll(byte[] data, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x1476F9C", Offset = "0x1476F9C", VA = "0x1476F9C")]
		public void SendToAll(byte[] data, int start, int length, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x14770E4", Offset = "0x14770E4", VA = "0x14770E4")]
		public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x1477110", Offset = "0x1477110", VA = "0x1477110")]
		public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x1476FCC", Offset = "0x1476FCC", VA = "0x1476FCC")]
		public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x1477134", Offset = "0x1477134", VA = "0x1477134")]
		public void SendToAll(NetDataWriter writer, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x1477290", Offset = "0x1477290", VA = "0x1477290")]
		public void SendToAll(byte[] data, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x14772B8", Offset = "0x14772B8", VA = "0x14772B8")]
		public void SendToAll(byte[] data, int start, int length, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x14772C8", Offset = "0x14772C8", VA = "0x14772C8")]
		public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x14772F8", Offset = "0x14772F8", VA = "0x14772F8")]
		public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x1477164", Offset = "0x1477164", VA = "0x1477164")]
		public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x1477320", Offset = "0x1477320", VA = "0x1477320")]
		public bool Start()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x14773A8", Offset = "0x14773A8", VA = "0x14773A8")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x14774FC", Offset = "0x14774FC", VA = "0x14774FC")]
		public bool Start(string addressIPv4, string addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x1477328", Offset = "0x1477328", VA = "0x1477328")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x14775A0", Offset = "0x14775A0", VA = "0x14775A0")]
		public bool StartInManualMode(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x14775D4", Offset = "0x14775D4", VA = "0x14775D4")]
		public bool StartInManualMode(string addressIPv4, string addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x1477678", Offset = "0x1477678", VA = "0x1477678")]
		public bool StartInManualMode(int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x14776F8", Offset = "0x14776F8", VA = "0x14776F8")]
		public bool SendUnconnectedMessage(byte[] message, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x1477770", Offset = "0x1477770", VA = "0x1477770")]
		public bool SendUnconnectedMessage(NetDataWriter writer, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x1477718", Offset = "0x1477718", VA = "0x1477718")]
		public bool SendUnconnectedMessage(byte[] message, int start, int length, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x1477860", Offset = "0x1477860", VA = "0x1477860")]
		public bool SendBroadcast(NetDataWriter writer, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x1477A0C", Offset = "0x1477A0C", VA = "0x1477A0C")]
		public bool SendBroadcast(byte[] data, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x1477888", Offset = "0x1477888", VA = "0x1477888")]
		public bool SendBroadcast(byte[] data, int start, int length, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x1477B00", Offset = "0x1477B00", VA = "0x1477B00")]
		public void TriggerUpdate()
		{
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x1477B1C", Offset = "0x1477B1C", VA = "0x1477B1C")]
		public void PollEvents()
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x1477D38", Offset = "0x1477D38", VA = "0x1477D38")]
		public NetPeer Connect(string address, int port, string key)
		{
			return null;
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x1477D7C", Offset = "0x1477D7C", VA = "0x1477D7C")]
		public NetPeer Connect(string address, int port, NetDataWriter connectionData)
		{
			return null;
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x1478158", Offset = "0x1478158", VA = "0x1478158")]
		public NetPeer Connect(IPEndPoint target, string key)
		{
			return null;
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x1477ED4", Offset = "0x1477ED4", VA = "0x1477ED4")]
		public NetPeer Connect(IPEndPoint target, NetDataWriter connectionData)
		{
			return null;
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x147818C", Offset = "0x147818C", VA = "0x147818C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x1478194", Offset = "0x1478194", VA = "0x1478194")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x14784A4", Offset = "0x14784A4", VA = "0x14784A4")]
		public int GetPeersCount(ConnectionState peerState)
		{
			return default(int);
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x1473294", Offset = "0x1473294", VA = "0x1473294")]
		public void GetPeersNonAlloc(List<NetPeer> peers, ConnectionState peerState)
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x147851C", Offset = "0x147851C", VA = "0x147851C")]
		public void DisconnectAll()
		{
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x147852C", Offset = "0x147852C", VA = "0x147852C")]
		public void DisconnectAll(byte[] data, int start, int count)
		{
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x14785C8", Offset = "0x14785C8", VA = "0x14785C8")]
		public void DisconnectPeerForce(NetPeer peer)
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x1478600", Offset = "0x1478600", VA = "0x1478600")]
		public void DisconnectPeer(NetPeer peer)
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x1478670", Offset = "0x1478670", VA = "0x1478670")]
		public void DisconnectPeer(NetPeer peer, byte[] data)
		{
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x14786B0", Offset = "0x14786B0", VA = "0x14786B0")]
		public void DisconnectPeer(NetPeer peer, NetDataWriter writer)
		{
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x1478638", Offset = "0x1478638", VA = "0x1478638")]
		public void DisconnectPeer(NetPeer peer, byte[] data, int start, int count)
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x14786F0", Offset = "0x14786F0", VA = "0x14786F0")]
		public void CreateNtpRequest(IPEndPoint endPoint)
		{
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x1478788", Offset = "0x1478788", VA = "0x1478788")]
		public void CreateNtpRequest(string ntpServerAddress, int port)
		{
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x1478868", Offset = "0x1478868", VA = "0x1478868")]
		public void CreateNtpRequest(string ntpServerAddress)
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x1478944", Offset = "0x1478944", VA = "0x1478944")]
		public NetPeerEnumerator GetEnumerator()
		{
			return default(NetPeerEnumerator);
		}

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x1478984", Offset = "0x1478984", VA = "0x1478984", Slot = "4")]
		private IEnumerator<NetPeer> System.Collections.Generic.IEnumerable<FlyingWormConsole3.LiteNetLib.NetPeer>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x1478A00", Offset = "0x1478A00", VA = "0x1478A00", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200021A")]
	internal enum PacketProperty : byte
	{
		[Token(Token = "0x400071D")]
		Unreliable,
		[Token(Token = "0x400071E")]
		Channeled,
		[Token(Token = "0x400071F")]
		Ack,
		[Token(Token = "0x4000720")]
		Ping,
		[Token(Token = "0x4000721")]
		Pong,
		[Token(Token = "0x4000722")]
		ConnectRequest,
		[Token(Token = "0x4000723")]
		ConnectAccept,
		[Token(Token = "0x4000724")]
		Disconnect,
		[Token(Token = "0x4000725")]
		UnconnectedMessage,
		[Token(Token = "0x4000726")]
		MtuCheck,
		[Token(Token = "0x4000727")]
		MtuOk,
		[Token(Token = "0x4000728")]
		Broadcast,
		[Token(Token = "0x4000729")]
		Merged,
		[Token(Token = "0x400072A")]
		ShutdownOk,
		[Token(Token = "0x400072B")]
		PeerNotFound,
		[Token(Token = "0x400072C")]
		InvalidProtocol,
		[Token(Token = "0x400072D")]
		NatMessage,
		[Token(Token = "0x400072E")]
		Empty
	}
	[Token(Token = "0x200021B")]
	internal sealed class NetPacket
	{
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int LastProperty;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] HeaderSizes;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] RawData;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Size;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object UserData;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NetPacket Next;

		[Token(Token = "0x170000A3")]
		public PacketProperty Property
		{
			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x1476C14", Offset = "0x1476C14", VA = "0x1476C14")]
			get
			{
				return default(PacketProperty);
			}
			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x1477AC0", Offset = "0x1477AC0", VA = "0x1477AC0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public byte ConnectionNumber
		{
			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x146F5F0", Offset = "0x146F5F0", VA = "0x146F5F0")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x14766C0", Offset = "0x14766C0", VA = "0x14766C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public ushort Sequence
		{
			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x1478C74", Offset = "0x1478C74", VA = "0x1478C74")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x1478CE0", Offset = "0x1478CE0", VA = "0x1478CE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool IsFragmented
		{
			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x1478CF0", Offset = "0x1478CF0", VA = "0x1478CF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A7")]
		public byte ChannelId
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x1478D68", Offset = "0x1478D68", VA = "0x1478D68")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x1478DA0", Offset = "0x1478DA0", VA = "0x1478DA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public ushort FragmentId
		{
			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x1478DD8", Offset = "0x1478DD8", VA = "0x1478DD8")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x1478E44", Offset = "0x1478E44", VA = "0x1478E44")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public ushort FragmentPart
		{
			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x1478E54", Offset = "0x1478E54", VA = "0x1478E54")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x1478EC0", Offset = "0x1478EC0", VA = "0x1478EC0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public ushort FragmentsTotal
		{
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x1478ED0", Offset = "0x1478ED0", VA = "0x1478ED0")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x1478F3C", Offset = "0x1478F3C", VA = "0x1478F3C")]
			set
			{
			}
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x1478A7C", Offset = "0x1478A7C", VA = "0x1478A7C")]
		static NetPacket()
		{
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x1478D2C", Offset = "0x1478D2C", VA = "0x1478D2C")]
		public void MarkFragmented()
		{
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x1478F4C", Offset = "0x1478F4C", VA = "0x1478F4C")]
		public NetPacket(int size)
		{
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x146F26C", Offset = "0x146F26C", VA = "0x146F26C")]
		public NetPacket(PacketProperty property, int size)
		{
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x1477A2C", Offset = "0x1477A2C", VA = "0x1477A2C")]
		public static int GetHeaderSize(PacketProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x14748FC", Offset = "0x14748FC", VA = "0x14748FC")]
		public int GetHeaderSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x1476AFC", Offset = "0x1476AFC", VA = "0x1476AFC")]
		public bool Verify()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200021C")]
	internal sealed class NetConnectRequestPacket
	{
		[Token(Token = "0x4000735")]
		public const int HeaderSize = 14;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly long ConnectionTime;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly byte ConnectionNumber;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly byte[] TargetAddress;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly NetDataReader Data;

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x146F334", Offset = "0x146F334", VA = "0x146F334")]
		private NetConnectRequestPacket(long connectionTime, byte connectionNumber, byte[] targetAddress, NetDataReader data)
		{
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x146F39C", Offset = "0x146F39C", VA = "0x146F39C")]
		public static int GetProtocolId(NetPacket packet)
		{
			return default(int);
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x146F410", Offset = "0x146F410", VA = "0x146F410")]
		public static NetConnectRequestPacket FromData(NetPacket packet)
		{
			return null;
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x146F678", Offset = "0x146F678", VA = "0x146F678")]
		public static NetPacket Make(NetDataWriter connectData, SocketAddress addressBytes, long connectId)
		{
			return null;
		}
	}
	[Token(Token = "0x200021D")]
	internal sealed class NetConnectAcceptPacket
	{
		[Token(Token = "0x400073A")]
		public const int Size = 11;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly long ConnectionId;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly byte ConnectionNumber;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public readonly bool IsReusedPeer;

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x146F044", Offset = "0x146F044", VA = "0x146F044")]
		private NetConnectAcceptPacket(long connectionId, byte connectionNumber, bool isReusedPeer)
		{
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x146F08C", Offset = "0x146F08C", VA = "0x146F08C")]
		public static NetConnectAcceptPacket FromData(NetPacket packet)
		{
			return null;
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x146F1A4", Offset = "0x146F1A4", VA = "0x146F1A4")]
		public static NetPacket Make(long connectId, byte connectNum, bool reusedPeer)
		{
			return null;
		}
	}
	[Token(Token = "0x200021E")]
	internal sealed class NetPacketPool
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NetPacket _head;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _count;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly object _lock;

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x1477798", Offset = "0x1477798", VA = "0x1477798")]
		public NetPacket GetWithData(PacketProperty property, byte[] data, int start, int length)
		{
			return null;
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x1476628", Offset = "0x1476628", VA = "0x1476628")]
		public NetPacket GetWithProperty(PacketProperty property, int size)
		{
			return null;
		}

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x1476C4C", Offset = "0x1476C4C", VA = "0x1476C4C")]
		public NetPacket GetWithProperty(PacketProperty property)
		{
			return null;
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x14745E0", Offset = "0x14745E0", VA = "0x14745E0")]
		public NetPacket GetPacket(int size)
		{
			return null;
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x147442C", Offset = "0x147442C", VA = "0x147442C")]
		public void Recycle(NetPacket packet)
		{
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x1473D58", Offset = "0x1473D58", VA = "0x1473D58")]
		public NetPacketPool()
		{
		}
	}
	[Token(Token = "0x200021F")]
	[Flags]
	public enum ConnectionState : byte
	{
		[Token(Token = "0x4000742")]
		Outgoing = 2,
		[Token(Token = "0x4000743")]
		Connected = 4,
		[Token(Token = "0x4000744")]
		ShutdownRequested = 8,
		[Token(Token = "0x4000745")]
		Disconnected = 0x10,
		[Token(Token = "0x4000746")]
		Any = 0xE
	}
	[Token(Token = "0x2000220")]
	internal enum ConnectRequestResult
	{
		[Token(Token = "0x4000748")]
		None,
		[Token(Token = "0x4000749")]
		P2PLose,
		[Token(Token = "0x400074A")]
		Reconnection,
		[Token(Token = "0x400074B")]
		NewConnection
	}
	[Token(Token = "0x2000221")]
	internal enum DisconnectResult
	{
		[Token(Token = "0x400074D")]
		None,
		[Token(Token = "0x400074E")]
		Reject,
		[Token(Token = "0x400074F")]
		Disconnect
	}
	[Token(Token = "0x2000222")]
	internal enum ShutdownResult
	{
		[Token(Token = "0x4000751")]
		None,
		[Token(Token = "0x4000752")]
		Success,
		[Token(Token = "0x4000753")]
		WasConnected
	}
	[Token(Token = "0x2000223")]
	public class NetPeer
	{
		[Token(Token = "0x2000224")]
		private class IncomingFragments
		{
			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NetPacket[] Fragments;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int ReceivedCount;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int TotalSize;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte ChannelId;

			[Token(Token = "0x6000C23")]
			[Address(RVA = "0x102190C", Offset = "0x102190C", VA = "0x102190C")]
			public IncomingFragments()
			{
			}
		}

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _rtt;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _avgRtt;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _rttCount;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double _resendDelay;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _pingSendTimer;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _rttResetTimer;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Stopwatch _pingTimer;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _timeSinceLastPacket;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long _remoteDelta;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly NetPacketPool _packetPool;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly object _shutdownLock;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal NetPeer NextPeer;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal NetPeer PrevPeer;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly Queue<NetPacket> _unreliableChannel;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly Queue<BaseChannel> _channelSendQueue;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly BaseChannel[] _channels;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _mtu;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _mtuIdx;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _finishMtu;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _mtuCheckTimer;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _mtuCheckAttempts;

		[Token(Token = "0x4000769")]
		private const int MtuCheckDelay = 1000;

		[Token(Token = "0x400076A")]
		private const int MaxMtuCheckAttempts = 4;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly object _mtuMutex;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _fragmentId;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Dictionary<ushort, IncomingFragments> _holdedFragments;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<ushort, ushort> _deliveredFragments;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly NetPacket _mergeData;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _mergePos;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _mergeCount;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _connectAttempts;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _connectTimer;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private long _connectTime;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private byte _connectNum;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private ConnectionState _connectionState;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NetPacket _shutdownPacket;

		[Token(Token = "0x4000778")]
		private const int ShutdownDelay = 300;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int _shutdownTimer;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly NetPacket _pingPacket;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly NetPacket _pongPacket;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly NetPacket _connectRequestPacket;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly NetPacket _connectAcceptPacket;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public readonly IPEndPoint EndPoint;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public readonly NetManager NetManager;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public readonly int Id;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public object Tag;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public readonly NetStatistics Statistics;

		[Token(Token = "0x170000AB")]
		internal byte ConnectionNum
		{
			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x14BCCD4", Offset = "0x14BCCD4", VA = "0x14BCCD4")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x14BCCDC", Offset = "0x14BCCDC", VA = "0x14BCCDC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public ConnectionState ConnectionState
		{
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x14BCD38", Offset = "0x14BCD38", VA = "0x14BCD38")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Token(Token = "0x170000AD")]
		internal long ConnectTime
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x14BCD40", Offset = "0x14BCD40", VA = "0x14BCD40")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000AE")]
		public int Ping
		{
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x14BCD48", Offset = "0x14BCD48", VA = "0x14BCD48")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AF")]
		public int Mtu
		{
			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x14BCD5C", Offset = "0x14BCD5C", VA = "0x14BCD5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B0")]
		public long RemoteTimeDelta
		{
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x14BCD64", Offset = "0x14BCD64", VA = "0x14BCD64")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000B1")]
		public DateTime RemoteUtcTime
		{
			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x14BCD6C", Offset = "0x14BCD6C", VA = "0x14BCD6C")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x170000B2")]
		public int TimeSinceLastPacket
		{
			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x14BCE08", Offset = "0x14BCE08", VA = "0x14BCE08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B3")]
		internal double ResendDelay
		{
			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x14BCE10", Offset = "0x14BCE10", VA = "0x14BCE10")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x14BCE18", Offset = "0x14BCE18", VA = "0x14BCE18")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id)
		{
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x14BD234", Offset = "0x14BD234", VA = "0x14BD234")]
		private void SetMtu(int mtuIdx)
		{
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x14BD224", Offset = "0x14BD224", VA = "0x14BD224")]
		private void OverrideMtu(int mtuValue)
		{
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x14BD2EC", Offset = "0x14BD2EC", VA = "0x14BD2EC")]
		public int GetPacketsCountInReliableQueue(byte channelNumber, bool ordered)
		{
			return default(int);
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x14BD3AC", Offset = "0x14BD3AC", VA = "0x14BD3AC")]
		private BaseChannel CreateChannel(byte idx)
		{
			return null;
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x14BD520", Offset = "0x14BD520", VA = "0x14BD520")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id, byte connectNum, NetDataWriter connectData)
		{
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x14BD658", Offset = "0x14BD658", VA = "0x14BD658")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id, long connectId, byte connectNum)
		{
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x14BD6D8", Offset = "0x14BD6D8", VA = "0x14BD6D8")]
		internal void Reject(long connectionId, byte connectionNumber, byte[] data, int start, int length)
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x14BDA3C", Offset = "0x14BDA3C", VA = "0x14BDA3C")]
		internal bool ProcessConnectAccept(NetConnectAcceptPacket packet)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x14BDAAC", Offset = "0x14BDAAC", VA = "0x14BDAAC")]
		public int GetMaxSinglePacketSize(DeliveryMethod options)
		{
			return default(int);
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x14BDB34", Offset = "0x14BDB34", VA = "0x14BDB34")]
		public void SendWithDeliveryEvent(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x14BE010", Offset = "0x14BE010", VA = "0x14BE010")]
		public void SendWithDeliveryEvent(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x14BE078", Offset = "0x14BE078", VA = "0x14BE078")]
		public void SendWithDeliveryEvent(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x14BE10C", Offset = "0x14BE10C", VA = "0x14BE10C")]
		public void Send(byte[] data, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x14BE134", Offset = "0x14BE134", VA = "0x14BE134")]
		public void Send(NetDataWriter dataWriter, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x14BE164", Offset = "0x14BE164", VA = "0x14BE164")]
		public void Send(byte[] data, int start, int length, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x14BE174", Offset = "0x14BE174", VA = "0x14BE174")]
		public void Send(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x14BE19C", Offset = "0x14BE19C", VA = "0x14BE19C")]
		public void Send(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x14BE1CC", Offset = "0x14BE1CC", VA = "0x14BE1CC")]
		public void Send(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x14BDBC0", Offset = "0x14BDBC0", VA = "0x14BDBC0")]
		private void SendInternal(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x14BE1D4", Offset = "0x14BE1D4", VA = "0x14BE1D4")]
		public void Disconnect(byte[] data)
		{
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x14BE1FC", Offset = "0x14BE1FC", VA = "0x14BE1FC")]
		public void Disconnect(NetDataWriter writer)
		{
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x14BE224", Offset = "0x14BE224", VA = "0x14BE224")]
		public void Disconnect(byte[] data, int start, int count)
		{
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x14BE254", Offset = "0x14BE254", VA = "0x14BE254")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x14BE274", Offset = "0x14BE274", VA = "0x14BE274")]
		internal DisconnectResult ProcessDisconnect(NetPacket packet)
		{
			return default(DisconnectResult);
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x14BE358", Offset = "0x14BE358", VA = "0x14BE358")]
		internal void AddToReliableChannelSendQueue(BaseChannel channel)
		{
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x14BD6F4", Offset = "0x14BD6F4", VA = "0x14BD6F4")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x14BE45C", Offset = "0x14BE45C", VA = "0x14BE45C")]
		private void UpdateRoundTripTime(int roundTripTime)
		{
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x14BE498", Offset = "0x14BE498", VA = "0x14BE498")]
		internal void AddReliablePacket(DeliveryMethod method, NetPacket p)
		{
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x14BEAAC", Offset = "0x14BEAAC", VA = "0x14BEAAC")]
		private void ProcessMtuPacket(NetPacket packet)
		{
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x14BEF04", Offset = "0x14BEF04", VA = "0x14BEF04")]
		private void UpdateMtuLogic(int deltaTime)
		{
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x14BF1A4", Offset = "0x14BF1A4", VA = "0x14BF1A4")]
		internal ConnectRequestResult ProcessConnectRequest(NetConnectRequestPacket connRequest)
		{
			return default(ConnectRequestResult);
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x14BF2EC", Offset = "0x14BF2EC", VA = "0x14BF2EC")]
		internal void ProcessPacket(NetPacket packet)
		{
		}

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x14BF9B4", Offset = "0x14BF9B4", VA = "0x14BF9B4")]
		private void SendMerged()
		{
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x14BFA74", Offset = "0x14BFA74", VA = "0x14BFA74")]
		internal void SendUserData(NetPacket packet)
		{
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x14BFBA0", Offset = "0x14BFBA0", VA = "0x14BFBA0")]
		internal void Update(int deltaTime)
		{
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x14C00D4", Offset = "0x14C00D4", VA = "0x14C00D4")]
		internal void RecycleAndDeliver(NetPacket packet)
		{
		}
	}
	[Token(Token = "0x2000225")]
	internal sealed class NetSocket
	{
		[Token(Token = "0x4000787")]
		public const int ReceivePollingTime = 500000;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Socket _udpSocketv4;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Socket _udpSocketv6;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Thread _threadv4;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Thread _threadv6;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IPEndPoint _bufferEndPointv4;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IPEndPoint _bufferEndPointv6;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly NetManager _listener;

		[Token(Token = "0x400078F")]
		private const int SioUdpConnreset = -1744830452;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IPAddress MulticastAddressV6;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly bool IPv6Support;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2C0", Offset = "0x73E2C0")]
		private int <LocalPort>k__BackingField;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool IsRunning;

		[Token(Token = "0x170000B4")]
		public int LocalPort
		{
			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x14C0310", Offset = "0x14C0310", VA = "0x14C0310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD14", Offset = "0x73FD14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C25")]
			[Address(RVA = "0x14C0318", Offset = "0x14C0318", VA = "0x14C0318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD24", Offset = "0x73FD24")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public short Ttl
		{
			[Token(Token = "0x6000C26")]
			[Address(RVA = "0x14C0320", Offset = "0x14C0320", VA = "0x14C0320")]
			get
			{
				return default(short);
			}
			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x14C03C4", Offset = "0x14C03C4", VA = "0x14C03C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x14C0400", Offset = "0x14C0400", VA = "0x14C0400")]
		static NetSocket()
		{
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x14C04E8", Offset = "0x14C04E8", VA = "0x14C04E8")]
		public NetSocket(NetManager listener)
		{
		}

		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x14C051C", Offset = "0x14C051C", VA = "0x14C051C")]
		private bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x14C0540", Offset = "0x14C0540", VA = "0x14C0540")]
		private bool ProcessError(SocketException ex, EndPoint bufferEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x14C07B0", Offset = "0x14C07B0", VA = "0x14C07B0")]
		public void ManualReceive()
		{
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x14C0800", Offset = "0x14C0800", VA = "0x14C0800")]
		private bool ManualReceive(Socket socket, EndPoint bufferEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x14C0A58", Offset = "0x14C0A58", VA = "0x14C0A58")]
		private void ReceiveLogic(object state)
		{
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x14C0DD4", Offset = "0x14C0DD4", VA = "0x14C0DD4")]
		public bool Bind(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool reuseAddress, IPv6Mode ipv6Mode, bool manualMode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x14C1368", Offset = "0x14C1368", VA = "0x14C1368")]
		private bool BindSocket(Socket socket, IPEndPoint ep, bool reuseAddress, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x14C1C60", Offset = "0x14C1C60", VA = "0x14C1C60")]
		public bool SendBroadcast(byte[] data, int offset, int size, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x14C1FD0", Offset = "0x14C1FD0", VA = "0x14C1FD0")]
		public int SendTo(byte[] data, int offset, int size, IPEndPoint remoteEndPoint, ref SocketError errorCode)
		{
			return default(int);
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x14C240C", Offset = "0x14C240C", VA = "0x14C240C")]
		public void Close(bool suspend)
		{
		}
	}
	[Token(Token = "0x2000226")]
	public sealed class NetStatistics
	{
		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private long _packetsSent;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long _packetsReceived;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private long _bytesSent;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long _bytesReceived;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long _packetLoss;

		[Token(Token = "0x170000B6")]
		public long PacketsSent
		{
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x14C2518", Offset = "0x14C2518", VA = "0x14C2518")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000B7")]
		public long PacketsReceived
		{
			[Token(Token = "0x6000C35")]
			[Address(RVA = "0x14C2524", Offset = "0x14C2524", VA = "0x14C2524")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000B8")]
		public long BytesSent
		{
			[Token(Token = "0x6000C36")]
			[Address(RVA = "0x14C2530", Offset = "0x14C2530", VA = "0x14C2530")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000B9")]
		public long BytesReceived
		{
			[Token(Token = "0x6000C37")]
			[Address(RVA = "0x14C253C", Offset = "0x14C253C", VA = "0x14C253C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000BA")]
		public long PacketLoss
		{
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x14C2548", Offset = "0x14C2548", VA = "0x14C2548")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000BB")]
		public long PacketLossPercent
		{
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x14C2554", Offset = "0x14C2554", VA = "0x14C2554")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x14C25A4", Offset = "0x14C25A4", VA = "0x14C25A4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x14BFA5C", Offset = "0x14BFA5C", VA = "0x14BFA5C")]
		public void IncrementPacketsSent()
		{
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x14C260C", Offset = "0x14C260C", VA = "0x14C260C")]
		public void IncrementPacketsReceived()
		{
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x14BFA68", Offset = "0x14BFA68", VA = "0x14BFA68")]
		public void AddBytesSent(long bytesSent)
		{
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x14C2618", Offset = "0x14C2618", VA = "0x14C2618")]
		public void AddBytesReceived(long bytesReceived)
		{
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x14C2624", Offset = "0x14C2624", VA = "0x14C2624")]
		public void IncrementPacketLoss()
		{
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x14C2630", Offset = "0x14C2630", VA = "0x14C2630")]
		public void AddPacketLoss(long packetLoss)
		{
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x14C263C", Offset = "0x14C263C", VA = "0x14C263C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x14BD21C", Offset = "0x14BD21C", VA = "0x14BD21C")]
		public NetStatistics()
		{
		}
	}
	[Token(Token = "0x2000227")]
	[Flags]
	public enum LocalAddrType
	{
		[Token(Token = "0x400079A")]
		IPv4 = 1,
		[Token(Token = "0x400079B")]
		IPv6 = 2,
		[Token(Token = "0x400079C")]
		All = 3
	}
	[Token(Token = "0x2000228")]
	public static class NetUtils
	{
		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<string> IpList;

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x14C2900", Offset = "0x14C2900", VA = "0x14C2900")]
		public static IPEndPoint MakeEndPoint(string hostStr, int port)
		{
			return null;
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x14C29AC", Offset = "0x14C29AC", VA = "0x14C29AC")]
		public static IPAddress ResolveAddress(string hostStr)
		{
			return null;
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x14C2B94", Offset = "0x14C2B94", VA = "0x14C2B94")]
		public static IPAddress ResolveAddress(string hostStr, AddressFamily addressFamily)
		{
			return null;
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x14C2C14", Offset = "0x14C2C14", VA = "0x14C2C14")]
		public static List<string> GetLocalIpList(LocalAddrType addrType)
		{
			return null;
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x14C2CBC", Offset = "0x14C2CBC", VA = "0x14C2CBC")]
		public static void GetLocalIpList(IList<string> targetList, LocalAddrType addrType)
		{
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x14C34B0", Offset = "0x14C34B0", VA = "0x14C34B0")]
		public static string GetLocalIp(LocalAddrType addrType)
		{
			return null;
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x14C36D0", Offset = "0x14C36D0", VA = "0x14C36D0")]
		internal static void PrintInterfaceInfos()
		{
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x14BF98C", Offset = "0x14BF98C", VA = "0x14BF98C")]
		internal static int RelativeSequenceNumber(int number, int expected)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000229")]
	internal sealed class ReliableChannel : BaseChannel
	{
		[Token(Token = "0x200022A")]
		private struct PendingPacket
		{
			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NetPacket _packet;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private long _timeStamp;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool _isSent;

			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x1021CC8", Offset = "0x1021CC8", VA = "0x1021CC8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6000C51")]
			[Address(RVA = "0x1021D40", Offset = "0x1021D40", VA = "0x1021D40")]
			public void Init(NetPacket packet)
			{
			}

			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x1021D68", Offset = "0x1021D68", VA = "0x1021D68")]
			public void TrySend(long currentTime, NetPeer peer, out bool hasPacket)
			{
			}

			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x1021DF0", Offset = "0x1021DF0", VA = "0x1021DF0")]
			public bool Clear(NetPeer peer)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly NetPacket _outgoingAcks;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly PendingPacket[] _pendingPackets;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetPacket[] _receivedPackets;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly bool[] _earlyReceived;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _localSeqence;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _remoteSequence;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _localWindowStart;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _remoteWindowStart;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _mustSendAcks;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private readonly DeliveryMethod _deliveryMethod;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private readonly bool _ordered;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private readonly int _windowSize;

		[Token(Token = "0x40007AA")]
		private const int BitsInByte = 8;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly byte _id;

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x147A5C0", Offset = "0x147A5C0", VA = "0x147A5C0")]
		public ReliableChannel(NetPeer peer, bool ordered, byte id)
		{
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x147A794", Offset = "0x147A794", VA = "0x147A794")]
		private void ProcessAck(NetPacket packet)
		{
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x147AAD8", Offset = "0x147AAD8", VA = "0x147AAD8", Slot = "4")]
		protected override bool SendNextPackets()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x147AFC0", Offset = "0x147AFC0", VA = "0x147AFC0", Slot = "5")]
		public override bool ProcessPacket(NetPacket packet)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200022B")]
	internal sealed class SequencedChannel : BaseChannel
	{
		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _localSequence;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ushort _remoteSequence;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private readonly bool _reliable;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NetPacket _lastPacket;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetPacket _ackPacket;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _mustSendAck;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private readonly byte _id;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long _lastPacketSendTime;

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x147E46C", Offset = "0x147E46C", VA = "0x147E46C")]
		public SequencedChannel(NetPeer peer, bool reliable, byte id)
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x147E540", Offset = "0x147E540", VA = "0x147E540", Slot = "4")]
		protected override bool SendNextPackets()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x147E898", Offset = "0x147E898", VA = "0x147E898", Slot = "5")]
		public override bool ProcessPacket(NetPacket packet)
		{
			return default(bool);
		}
	}
}
namespace FlyingWormConsole3.LiteNetLib.Utils
{
	[Token(Token = "0x200022C")]
	public static class CRC32C
	{
		[Token(Token = "0x40007B7")]
		public const int ChecksumSize = 4;

		[Token(Token = "0x40007B8")]
		private const uint Poly = 2197175160u;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly uint[] Table;

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0xCFE3A0", Offset = "0xCFE3A0", VA = "0xCFE3A0")]
		static CRC32C()
		{
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0xCFE4A8", Offset = "0xCFE4A8", VA = "0xCFE4A8")]
		public static uint Compute(byte[] input, int offset, int length)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x200022D")]
	public static class FastBitConverter
	{
		[StructLayout(2)]
		[Token(Token = "0x200022E")]
		private struct ConverterHelperDouble
		{
			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong Along;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double Adouble;
		}

		[StructLayout(2)]
		[Token(Token = "0x200022F")]
		private struct ConverterHelperFloat
		{
			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Aint;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float Afloat;
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x1468CE4", Offset = "0x1468CE4", VA = "0x1468CE4")]
		private static void WriteLittleEndian(byte[] buffer, int offset, ulong data)
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x1468DE0", Offset = "0x1468DE0", VA = "0x1468DE0")]
		private static void WriteLittleEndian(byte[] buffer, int offset, int data)
		{
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x1468E6C", Offset = "0x1468E6C", VA = "0x1468E6C")]
		public static void WriteLittleEndian(byte[] buffer, int offset, short data)
		{
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x1468EC0", Offset = "0x1468EC0", VA = "0x1468EC0")]
		public static void GetBytes(byte[] bytes, int startIndex, double value)
		{
		}

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x1468EC8", Offset = "0x1468EC8", VA = "0x1468EC8")]
		public static void GetBytes(byte[] bytes, int startIndex, float value)
		{
		}

		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x1468ED0", Offset = "0x1468ED0", VA = "0x1468ED0")]
		public static void GetBytes(byte[] bytes, int startIndex, short value)
		{
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x1468ED4", Offset = "0x1468ED4", VA = "0x1468ED4")]
		public static void GetBytes(byte[] bytes, int startIndex, ushort value)
		{
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x1468ED8", Offset = "0x1468ED8", VA = "0x1468ED8")]
		public static void GetBytes(byte[] bytes, int startIndex, int value)
		{
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x1468EDC", Offset = "0x1468EDC", VA = "0x1468EDC")]
		public static void GetBytes(byte[] bytes, int startIndex, uint value)
		{
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x1468EE0", Offset = "0x1468EE0", VA = "0x1468EE0")]
		public static void GetBytes(byte[] bytes, int startIndex, long value)
		{
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x1468EE4", Offset = "0x1468EE4", VA = "0x1468EE4")]
		public static void GetBytes(byte[] bytes, int startIndex, ulong value)
		{
		}
	}
	[Token(Token = "0x2000230")]
	public interface INetSerializable
	{
		[Token(Token = "0x6000C64")]
		void Serialize(NetDataWriter writer);

		[Token(Token = "0x6000C65")]
		void Deserialize(NetDataReader reader);
	}
	[Token(Token = "0x2000231")]
	public class NetDataReader
	{
		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected byte[] _data;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int _position;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected int _dataSize;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _offset;

		[Token(Token = "0x170000BC")]
		public byte[] RawData
		{
			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x146F8A4", Offset = "0x146F8A4", VA = "0x146F8A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public int RawDataSize
		{
			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x146F8AC", Offset = "0x146F8AC", VA = "0x146F8AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BE")]
		public int UserDataOffset
		{
			[Token(Token = "0x6000C68")]
			[Address(RVA = "0x146F8B4", Offset = "0x146F8B4", VA = "0x146F8B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BF")]
		public int UserDataSize
		{
			[Token(Token = "0x6000C69")]
			[Address(RVA = "0x146F8BC", Offset = "0x146F8BC", VA = "0x146F8BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C0")]
		public bool IsNull
		{
			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0x146F8C8", Offset = "0x146F8C8", VA = "0x146F8C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C1")]
		public int Position
		{
			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0x146F8D8", Offset = "0x146F8D8", VA = "0x146F8D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C2")]
		public bool EndOfData
		{
			[Token(Token = "0x6000C6C")]
			[Address(RVA = "0x146F8E0", Offset = "0x146F8E0", VA = "0x146F8E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		public int AvailableBytes
		{
			[Token(Token = "0x6000C6D")]
			[Address(RVA = "0x146F8F0", Offset = "0x146F8F0", VA = "0x146F8F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x146F8FC", Offset = "0x146F8FC", VA = "0x146F8FC")]
		public void SkipBytes(int count)
		{
		}

		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x146F90C", Offset = "0x146F90C", VA = "0x146F90C")]
		public void SetSource(NetDataWriter dataWriter)
		{
		}

		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x146F954", Offset = "0x146F954", VA = "0x146F954")]
		public void SetSource(byte[] source)
		{
		}

		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x146F9A4", Offset = "0x146F9A4", VA = "0x146F9A4")]
		public void SetSource(byte[] source, int offset)
		{
		}

		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x146E460", Offset = "0x146E460", VA = "0x146E460")]
		public void SetSource(byte[] source, int offset, int maxSize)
		{
		}

		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x146E220", Offset = "0x146E220", VA = "0x146E220")]
		public NetDataReader()
		{
		}

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x146F9F8", Offset = "0x146F9F8", VA = "0x146F9F8")]
		public NetDataReader(NetDataWriter writer)
		{
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x146FA28", Offset = "0x146FA28", VA = "0x146FA28")]
		public NetDataReader(byte[] source)
		{
		}

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x146FA58", Offset = "0x146FA58", VA = "0x146FA58")]
		public NetDataReader(byte[] source, int offset)
		{
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x146F628", Offset = "0x146F628", VA = "0x146F628")]
		public NetDataReader(byte[] source, int offset, int maxSize)
		{
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x146FA98", Offset = "0x146FA98", VA = "0x146FA98")]
		public IPEndPoint GetNetEndPoint()
		{
			return null;
		}

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x146FC90", Offset = "0x146FC90", VA = "0x146FC90")]
		public byte GetByte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x146FCDC", Offset = "0x146FCDC", VA = "0x146FCDC")]
		public sbyte GetSByte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x146FD28", Offset = "0x146FD28", VA = "0x146FD28")]
		public bool[] GetBoolArray()
		{
			return null;
		}

		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x146FE10", Offset = "0x146FE10", VA = "0x146FE10")]
		public ushort[] GetUShortArray()
		{
			return null;
		}

		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x146FEF4", Offset = "0x146FEF4", VA = "0x146FEF4")]
		public short[] GetShortArray()
		{
			return null;
		}

		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x146FFD8", Offset = "0x146FFD8", VA = "0x146FFD8")]
		public long[] GetLongArray()
		{
			return null;
		}

		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x14700BC", Offset = "0x14700BC", VA = "0x14700BC")]
		public ulong[] GetULongArray()
		{
			return null;
		}

		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x14701A0", Offset = "0x14701A0", VA = "0x14701A0")]
		public int[] GetIntArray()
		{
			return null;
		}

		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x1470284", Offset = "0x1470284", VA = "0x1470284")]
		public uint[] GetUIntArray()
		{
			return null;
		}

		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x1470368", Offset = "0x1470368", VA = "0x1470368")]
		public float[] GetFloatArray()
		{
			return null;
		}

		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x147044C", Offset = "0x147044C", VA = "0x147044C")]
		public double[] GetDoubleArray()
		{
			return null;
		}

		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x1470530", Offset = "0x1470530", VA = "0x1470530")]
		public string[] GetStringArray()
		{
			return null;
		}

		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x1470720", Offset = "0x1470720", VA = "0x1470720")]
		public string[] GetStringArray(int maxStringLength)
		{
			return null;
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x1470878", Offset = "0x1470878", VA = "0x1470878")]
		public bool GetBool()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x14708CC", Offset = "0x14708CC", VA = "0x14708CC")]
		public char GetChar()
		{
			return default(char);
		}

		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x1470954", Offset = "0x1470954", VA = "0x1470954")]
		public ushort GetUShort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x14709DC", Offset = "0x14709DC", VA = "0x14709DC")]
		public short GetShort()
		{
			return default(short);
		}

		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x1470A64", Offset = "0x1470A64", VA = "0x1470A64")]
		public long GetLong()
		{
			return default(long);
		}

		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x1470AEC", Offset = "0x1470AEC", VA = "0x1470AEC")]
		public ulong GetULong()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x146FC08", Offset = "0x146FC08", VA = "0x146FC08")]
		public int GetInt()
		{
			return default(int);
		}

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x1470B74", Offset = "0x1470B74", VA = "0x1470B74")]
		public uint GetUInt()
		{
			return default(uint);
		}

		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x1470BFC", Offset = "0x1470BFC", VA = "0x1470BFC")]
		public float GetFloat()
		{
			return default(float);
		}

		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x1470C84", Offset = "0x1470C84", VA = "0x1470C84")]
		public double GetDouble()
		{
			return default(double);
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x146FB20", Offset = "0x146FB20", VA = "0x146FB20")]
		public string GetString(int maxLength)
		{
			return null;
		}

		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x1470680", Offset = "0x1470680", VA = "0x1470680")]
		public string GetString()
		{
			return null;
		}

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x1470D0C", Offset = "0x1470D0C", VA = "0x1470D0C")]
		public ArraySegment<byte> GetRemainingBytesSegment()
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x6000C93")]
		public T Get<T>() where T : INetSerializable, new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x1470D8C", Offset = "0x1470D8C", VA = "0x1470D8C")]
		public byte[] GetRemainingBytes()
		{
			return null;
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x1470E18", Offset = "0x1470E18", VA = "0x1470E18")]
		public void GetBytes(byte[] destination, int start, int count)
		{
		}

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x1470E64", Offset = "0x1470E64", VA = "0x1470E64")]
		public void GetBytes(byte[] destination, int count)
		{
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x1470EB0", Offset = "0x1470EB0", VA = "0x1470EB0")]
		public sbyte[] GetSBytesWithLength()
		{
			return null;
		}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x1470F4C", Offset = "0x1470F4C", VA = "0x1470F4C")]
		public byte[] GetBytesWithLength()
		{
			return null;
		}

		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x1470FE8", Offset = "0x1470FE8", VA = "0x1470FE8")]
		public byte PeekByte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x1471028", Offset = "0x1471028", VA = "0x1471028")]
		public sbyte PeekSByte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x1471068", Offset = "0x1471068", VA = "0x1471068")]
		public bool PeekBool()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x14710B0", Offset = "0x14710B0", VA = "0x14710B0")]
		public char PeekChar()
		{
			return default(char);
		}

		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x1471120", Offset = "0x1471120", VA = "0x1471120")]
		public ushort PeekUShort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0x1471190", Offset = "0x1471190", VA = "0x1471190")]
		public short PeekShort()
		{
			return default(short);
		}

		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x1471200", Offset = "0x1471200", VA = "0x1471200")]
		public long PeekLong()
		{
			return default(long);
		}

		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x1471270", Offset = "0x1471270", VA = "0x1471270")]
		public ulong PeekULong()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x14712E0", Offset = "0x14712E0", VA = "0x14712E0")]
		public int PeekInt()
		{
			return default(int);
		}

		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x1471350", Offset = "0x1471350", VA = "0x1471350")]
		public uint PeekUInt()
		{
			return default(uint);
		}

		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x14713C0", Offset = "0x14713C0", VA = "0x14713C0")]
		public float PeekFloat()
		{
			return default(float);
		}

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x1471430", Offset = "0x1471430", VA = "0x1471430")]
		public double PeekDouble()
		{
			return default(double);
		}

		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x14714A0", Offset = "0x14714A0", VA = "0x14714A0")]
		public string PeekString(int maxLength)
		{
			return null;
		}

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x14715C8", Offset = "0x14715C8", VA = "0x14715C8")]
		public string PeekString()
		{
			return null;
		}

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x14716AC", Offset = "0x14716AC", VA = "0x14716AC")]
		public bool TryGetByte(out byte result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x14716F4", Offset = "0x14716F4", VA = "0x14716F4")]
		public bool TryGetSByte(out sbyte result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x147173C", Offset = "0x147173C", VA = "0x147173C")]
		public bool TryGetBool(out bool result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x1471784", Offset = "0x1471784", VA = "0x1471784")]
		public bool TryGetChar(out char result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x14717CC", Offset = "0x14717CC", VA = "0x14717CC")]
		public bool TryGetShort(out short result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x1471814", Offset = "0x1471814", VA = "0x1471814")]
		public bool TryGetUShort(out ushort result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x147185C", Offset = "0x147185C", VA = "0x147185C")]
		public bool TryGetInt(out int result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x14718A4", Offset = "0x14718A4", VA = "0x14718A4")]
		public bool TryGetUInt(out uint result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x14718EC", Offset = "0x14718EC", VA = "0x14718EC")]
		public bool TryGetLong(out long result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x1471934", Offset = "0x1471934", VA = "0x1471934")]
		public bool TryGetULong(out ulong result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x147197C", Offset = "0x147197C", VA = "0x147197C")]
		public bool TryGetFloat(out float result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x14719C0", Offset = "0x14719C0", VA = "0x14719C0")]
		public bool TryGetDouble(out double result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x1471A04", Offset = "0x1471A04", VA = "0x1471A04")]
		public bool TryGetString(out string result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x1471A80", Offset = "0x1471A80", VA = "0x1471A80")]
		public bool TryGetStringArray(out string[] result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x1471B88", Offset = "0x1471B88", VA = "0x1471B88")]
		public bool TryGetBytesWithLength(out byte[] result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x1471C08", Offset = "0x1471C08", VA = "0x1471C08")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x2000232")]
	public class NetDataWriter
	{
		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected byte[] _data;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int _position;

		[Token(Token = "0x40007C4")]
		private const int InitialSize = 64;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly bool _autoResize;

		[Token(Token = "0x170000C4")]
		public int Capacity
		{
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x1471C18", Offset = "0x1471C18", VA = "0x1471C18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C5")]
		public byte[] Data
		{
			[Token(Token = "0x6000CC2")]
			[Address(RVA = "0x147218C", Offset = "0x147218C", VA = "0x147218C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public int Length
		{
			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x1472194", Offset = "0x1472194", VA = "0x1472194")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x146E228", Offset = "0x146E228", VA = "0x146E228")]
		public NetDataWriter()
		{
		}

		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x1471CB8", Offset = "0x1471CB8", VA = "0x1471CB8")]
		public NetDataWriter(bool autoResize)
		{
		}

		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x1471C34", Offset = "0x1471C34", VA = "0x1471C34")]
		public NetDataWriter(bool autoResize, int initialSize)
		{
		}

		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x1471CC4", Offset = "0x1471CC4", VA = "0x1471CC4")]
		public static NetDataWriter FromBytes(byte[] bytes, bool copy)
		{
			return null;
		}

		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x1471E08", Offset = "0x1471E08", VA = "0x1471E08")]
		public static NetDataWriter FromBytes(byte[] bytes, int offset, int length)
		{
			return null;
		}

		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x1471F08", Offset = "0x1471F08", VA = "0x1471F08")]
		public static NetDataWriter FromString(string value)
		{
			return null;
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x1472058", Offset = "0x1472058", VA = "0x1472058")]
		public void ResizeIfNeed(int newSize)
		{
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x14720E8", Offset = "0x14720E8", VA = "0x14720E8")]
		public void Reset(int size)
		{
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x147210C", Offset = "0x147210C", VA = "0x147210C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x1472114", Offset = "0x1472114", VA = "0x1472114")]
		public byte[] CopyData()
		{
			return null;
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x147219C", Offset = "0x147219C", VA = "0x147219C")]
		public int SetPosition(int position)
		{
			return default(int);
		}

		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x14721AC", Offset = "0x14721AC", VA = "0x14721AC")]
		public void Put(float value)
		{
		}

		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x1472208", Offset = "0x1472208", VA = "0x1472208")]
		public void Put(double value)
		{
		}

		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x1472264", Offset = "0x1472264", VA = "0x1472264")]
		public void Put(long value)
		{
		}

		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x14722B8", Offset = "0x14722B8", VA = "0x14722B8")]
		public void Put(ulong value)
		{
		}

		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x147230C", Offset = "0x147230C", VA = "0x147230C")]
		public void Put(int value)
		{
		}

		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x1472360", Offset = "0x1472360", VA = "0x1472360")]
		public void Put(uint value)
		{
		}

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x14723B4", Offset = "0x14723B4", VA = "0x14723B4")]
		public void Put(char value)
		{
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x1472408", Offset = "0x1472408", VA = "0x1472408")]
		public void Put(ushort value)
		{
		}

		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x147245C", Offset = "0x147245C", VA = "0x147245C")]
		public void Put(short value)
		{
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x14724B0", Offset = "0x14724B0", VA = "0x14724B0")]
		public void Put(sbyte value)
		{
		}

		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x1472524", Offset = "0x1472524", VA = "0x1472524")]
		public void Put(byte value)
		{
		}

		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x1471E98", Offset = "0x1471E98", VA = "0x1471E98")]
		public void Put(byte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x1471D90", Offset = "0x1471D90", VA = "0x1471D90")]
		public void Put(byte[] data)
		{
		}

		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x1472598", Offset = "0x1472598", VA = "0x1472598")]
		public void PutSBytesWithLength(sbyte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x1472630", Offset = "0x1472630", VA = "0x1472630")]
		public void PutSBytesWithLength(sbyte[] data)
		{
		}

		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x14726C4", Offset = "0x14726C4", VA = "0x14726C4")]
		public void PutBytesWithLength(byte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x147275C", Offset = "0x147275C", VA = "0x147275C")]
		public void PutBytesWithLength(byte[] data)
		{
		}

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x14727F0", Offset = "0x14727F0", VA = "0x14727F0")]
		public void Put(bool value)
		{
		}

		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x1472868", Offset = "0x1472868", VA = "0x1472868")]
		private void PutArray(Array arr, int sz)
		{
		}

		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x1472918", Offset = "0x1472918", VA = "0x1472918")]
		public void PutArray(float[] value)
		{
		}

		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x1472920", Offset = "0x1472920", VA = "0x1472920")]
		public void PutArray(double[] value)
		{
		}

		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x1472928", Offset = "0x1472928", VA = "0x1472928")]
		public void PutArray(long[] value)
		{
		}

		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x1472930", Offset = "0x1472930", VA = "0x1472930")]
		public void PutArray(ulong[] value)
		{
		}

		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x1472938", Offset = "0x1472938", VA = "0x1472938")]
		public void PutArray(int[] value)
		{
		}

		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x1472940", Offset = "0x1472940", VA = "0x1472940")]
		public void PutArray(uint[] value)
		{
		}

		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x1472948", Offset = "0x1472948", VA = "0x1472948")]
		public void PutArray(ushort[] value)
		{
		}

		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x1472950", Offset = "0x1472950", VA = "0x1472950")]
		public void PutArray(short[] value)
		{
		}

		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x1472958", Offset = "0x1472958", VA = "0x1472958")]
		public void PutArray(bool[] value)
		{
		}

		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x1472960", Offset = "0x1472960", VA = "0x1472960")]
		public void PutArray(string[] value)
		{
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x1472A00", Offset = "0x1472A00", VA = "0x1472A00")]
		public void PutArray(string[] value, int maxLength)
		{
		}

		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x1472B94", Offset = "0x1472B94", VA = "0x1472B94")]
		public void Put(IPEndPoint endPoint)
		{
		}

		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x1471F7C", Offset = "0x1471F7C", VA = "0x1471F7C")]
		public void Put(string value)
		{
		}

		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x1472AA8", Offset = "0x1472AA8", VA = "0x1472AA8")]
		public void Put(string value, int maxLength)
		{
		}

		[Token(Token = "0x6000CE6")]
		public void Put<T>(T obj) where T : INetSerializable
		{
		}
	}
	[Token(Token = "0x2000233")]
	public class NetPacketProcessor
	{
		[Token(Token = "0x2000234")]
		private static class HashCache<T>
		{
			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ulong Id;

			[Token(Token = "0x6000D04")]
			static HashCache()
			{
			}
		}

		[Token(Token = "0x2000235")]
		protected delegate void SubscribeDelegate(NetDataReader reader, object userData);

		[Token(Token = "0x2000236")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DE50", Offset = "0x73DE50")]
		private sealed class <>c__DisplayClass25_0<T> where T : class, new()
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> packetConstructor;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NetPacketProcessor <>4__this;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onReceive;

			[Token(Token = "0x6000D09")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000D0A")]
			internal void <Subscribe>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x2000237")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DE60", Offset = "0x73DE60")]
		private sealed class <>c__DisplayClass26_0<T, TUserData> where T : class, new()
		{
			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> packetConstructor;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NetPacketProcessor <>4__this;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, TUserData> onReceive;

			[Token(Token = "0x6000D0B")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000D0C")]
			internal void <Subscribe>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x2000238")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DE70", Offset = "0x73DE70")]
		private sealed class <>c__DisplayClass27_0<T> where T : class, new()
		{
			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NetPacketProcessor <>4__this;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onReceive;

			[Token(Token = "0x6000D0D")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000D0E")]
			internal void <SubscribeReusable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x2000239")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DE80", Offset = "0x73DE80")]
		private sealed class <>c__DisplayClass28_0<T, TUserData> where T : class, new()
		{
			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NetPacketProcessor <>4__this;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, TUserData> onReceive;

			[Token(Token = "0x6000D0F")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000D10")]
			internal void <SubscribeReusable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x200023A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DE90", Offset = "0x73DE90")]
		private sealed class <>c__DisplayClass29_0<T, TUserData> where T : INetSerializable
		{
			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> packetConstructor;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, TUserData> onReceive;

			[Token(Token = "0x6000D11")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000D12")]
			internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x200023B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DEA0", Offset = "0x73DEA0")]
		private sealed class <>c__DisplayClass30_0<T> where T : INetSerializable
		{
			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> packetConstructor;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onReceive;

			[Token(Token = "0x6000D13")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000D14")]
			internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x200023C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DEB0", Offset = "0x73DEB0")]
		private sealed class <>c__DisplayClass31_0<T, TUserData> where T : INetSerializable, new()
		{
			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, TUserData> onReceive;

			[Token(Token = "0x6000D15")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000D16")]
			internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x200023D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73DEC0", Offset = "0x73DEC0")]
		private sealed class <>c__DisplayClass32_0<T> where T : INetSerializable, new()
		{
			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onReceive;

			[Token(Token = "0x6000D17")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000D18")]
			internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetSerializer _netSerializer;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<ulong, SubscribeDelegate> _callbacks;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly NetDataWriter _netDataWriter;

		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x1478FC8", Offset = "0x1478FC8", VA = "0x1478FC8")]
		public NetPacketProcessor()
		{
		}

		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x146E234", Offset = "0x146E234", VA = "0x146E234")]
		public NetPacketProcessor(int maxStringLength)
		{
		}

		[Token(Token = "0x6000CE9")]
		protected virtual ulong GetHash<T>()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x14790C0", Offset = "0x14790C0", VA = "0x14790C0", Slot = "5")]
		protected virtual SubscribeDelegate GetCallbackFromData(NetDataReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000CEB")]
		protected virtual void WriteHash<T>(NetDataWriter writer)
		{
		}

		[Token(Token = "0x6000CEC")]
		public void RegisterNestedType<T>() where T : struct, INetSerializable
		{
		}

		[Token(Token = "0x6000CED")]
		public void RegisterNestedType<T>(Action<NetDataWriter, T> writeDelegate, Func<NetDataReader, T> readDelegate)
		{
		}

		[Token(Token = "0x6000CEE")]
		public void RegisterNestedType<T>(Func<T> constructor) where T : class, INetSerializable
		{
		}

		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x1479190", Offset = "0x1479190", VA = "0x1479190")]
		public void ReadAllPackets(NetDataReader reader)
		{
		}

		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x146E4A0", Offset = "0x146E4A0", VA = "0x146E4A0")]
		public void ReadAllPackets(NetDataReader reader, object userData)
		{
		}

		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x14791E8", Offset = "0x14791E8", VA = "0x14791E8")]
		public void ReadPacket(NetDataReader reader)
		{
		}

		[Token(Token = "0x6000CF2")]
		public void Send<T>(NetPeer peer, T packet, DeliveryMethod options) where T : class, new()
		{
		}

		[Token(Token = "0x6000CF3")]
		public void SendNetSerializable<T>(NetPeer peer, T packet, DeliveryMethod options) where T : INetSerializable
		{
		}

		[Token(Token = "0x6000CF4")]
		public void Send<T>(NetManager manager, T packet, DeliveryMethod options) where T : class, new()
		{
		}

		[Token(Token = "0x6000CF5")]
		public void SendNetSerializable<T>(NetManager manager, T packet, DeliveryMethod options) where T : INetSerializable
		{
		}

		[Token(Token = "0x6000CF6")]
		public void Write<T>(NetDataWriter writer, T packet) where T : class, new()
		{
		}

		[Token(Token = "0x6000CF7")]
		public void WriteNetSerializable<T>(NetDataWriter writer, T packet) where T : INetSerializable
		{
		}

		[Token(Token = "0x6000CF8")]
		public byte[] Write<T>(T packet) where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x6000CF9")]
		public byte[] WriteNetSerializable<T>(T packet) where T : INetSerializable
		{
			return null;
		}

		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x14791F0", Offset = "0x14791F0", VA = "0x14791F0")]
		public void ReadPacket(NetDataReader reader, object userData)
		{
		}

		[Token(Token = "0x6000CFB")]
		public void Subscribe<T>(Action<T> onReceive, Func<T> packetConstructor) where T : class, new()
		{
		}

		[Token(Token = "0x6000CFC")]
		public void Subscribe<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) where T : class, new()
		{
		}

		[Token(Token = "0x6000CFD")]
		public void SubscribeReusable<T>(Action<T> onReceive) where T : class, new()
		{
		}

		[Token(Token = "0x6000CFE")]
		public void SubscribeReusable<T, TUserData>(Action<T, TUserData> onReceive) where T : class, new()
		{
		}

		[Token(Token = "0x6000CFF")]
		public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) where T : INetSerializable
		{
		}

		[Token(Token = "0x6000D00")]
		public void SubscribeNetSerializable<T>(Action<T> onReceive, Func<T> packetConstructor) where T : INetSerializable
		{
		}

		[Token(Token = "0x6000D01")]
		public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive) where T : INetSerializable, new()
		{
		}

		[Token(Token = "0x6000D02")]
		public void SubscribeNetSerializable<T>(Action<T> onReceive) where T : INetSerializable, new()
		{
		}

		[Token(Token = "0x6000D03")]
		public bool RemoveSubscription<T>()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200023E")]
	public class InvalidTypeException : ArgumentException
	{
		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x1469E78", Offset = "0x1469E78", VA = "0x1469E78")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Token(Token = "0x200023F")]
	public class ParseException : Exception
	{
		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x147925C", Offset = "0x147925C", VA = "0x147925C")]
		public ParseException(string message)
		{
		}
	}
	[Token(Token = "0x2000240")]
	public class NetSerializer
	{
		[Token(Token = "0x2000241")]
		private enum CallType
		{
			[Token(Token = "0x40007E2")]
			Basic,
			[Token(Token = "0x40007E3")]
			Array,
			[Token(Token = "0x40007E4")]
			List
		}

		[Token(Token = "0x2000242")]
		private abstract class FastCall<T>
		{
			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallType Type;

			[Token(Token = "0x6000D26")]
			public virtual void Init(MethodInfo getMethod, MethodInfo setMethod, CallType type)
			{
			}

			[Token(Token = "0x6000D27")]
			public abstract void Read(T inf, NetDataReader r);

			[Token(Token = "0x6000D28")]
			public abstract void Write(T inf, NetDataWriter w);

			[Token(Token = "0x6000D29")]
			public abstract void ReadArray(T inf, NetDataReader r);

			[Token(Token = "0x6000D2A")]
			public abstract void WriteArray(T inf, NetDataWriter w);

			[Token(Token = "0x6000D2B")]
			public abstract void ReadList(T inf, NetDataReader r);

			[Token(Token = "0x6000D2C")]
			public abstract void WriteList(T inf, NetDataWriter w);

			[Token(Token = "0x6000D2D")]
			protected FastCall()
			{
			}
		}

		[Token(Token = "0x2000243")]
		private abstract class FastCallSpecific<TClass, TProperty> : FastCall<TClass>
		{
			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Func<TClass, TProperty> Getter;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Action<TClass, TProperty> Setter;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Func<TClass, TProperty[]> GetterArr;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Action<TClass, TProperty[]> SetterArr;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Func<TClass, List<TProperty>> GetterList;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Action<TClass, List<TProperty>> SetterList;

			[Token(Token = "0x6000D2E")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D2F")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D30")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D31")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D32")]
			protected TProperty[] ReadArrayHelper(TClass inf, NetDataReader r)
			{
				return null;
			}

			[Token(Token = "0x6000D33")]
			protected TProperty[] WriteArrayHelper(TClass inf, NetDataWriter w)
			{
				return null;
			}

			[Token(Token = "0x6000D34")]
			protected List<TProperty> ReadListHelper(TClass inf, NetDataReader r, out int len)
			{
				return null;
			}

			[Token(Token = "0x6000D35")]
			protected List<TProperty> WriteListHelper(TClass inf, NetDataWriter w, out int len)
			{
				return null;
			}

			[Token(Token = "0x6000D36")]
			public override void Init(MethodInfo getMethod, MethodInfo setMethod, CallType type)
			{
			}

			[Token(Token = "0x6000D37")]
			protected FastCallSpecific()
			{
			}
		}

		[Token(Token = "0x2000244")]
		private abstract class FastCallSpecificAuto<TClass, TProperty> : FastCallSpecific<TClass, TProperty>
		{
			[Token(Token = "0x6000D38")]
			protected abstract void ElementRead(NetDataReader r, out TProperty prop);

			[Token(Token = "0x6000D39")]
			protected abstract void ElementWrite(NetDataWriter w, ref TProperty prop);

			[Token(Token = "0x6000D3A")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D3B")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D3C")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D3D")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D3E")]
			protected FastCallSpecificAuto()
			{
			}
		}

		[Token(Token = "0x2000245")]
		private sealed class FastCallStatic<TClass, TProperty> : FastCallSpecific<TClass, TProperty>
		{
			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Action<NetDataWriter, TProperty> _writer;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<NetDataReader, TProperty> _reader;

			[Token(Token = "0x6000D3F")]
			public FastCallStatic(Action<NetDataWriter, TProperty> write, Func<NetDataReader, TProperty> read)
			{
			}

			[Token(Token = "0x6000D40")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D41")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D42")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D43")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D44")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D45")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x2000246")]
		private sealed class FastCallStruct<TClass, TProperty> : FastCallSpecific<TClass, TProperty> where TProperty : struct, INetSerializable
		{
			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TProperty _p;

			[Token(Token = "0x6000D46")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D47")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D48")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D49")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D4A")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D4B")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D4C")]
			public FastCallStruct()
			{
			}
		}

		[Token(Token = "0x2000247")]
		private sealed class FastCallClass<TClass, TProperty> : FastCallSpecific<TClass, TProperty> where TProperty : class, INetSerializable
		{
			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<TProperty> _constructor;

			[Token(Token = "0x6000D4D")]
			public FastCallClass(Func<TProperty> constructor)
			{
			}

			[Token(Token = "0x6000D4E")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D4F")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D50")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D51")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D52")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D53")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x2000248")]
		private class IntSerializer<T> : FastCallSpecific<T, int>
		{
			[Token(Token = "0x6000D54")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D55")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D56")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D57")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D58")]
			public IntSerializer()
			{
			}
		}

		[Token(Token = "0x2000249")]
		private class UIntSerializer<T> : FastCallSpecific<T, uint>
		{
			[Token(Token = "0x6000D59")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D5A")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D5B")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D5C")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D5D")]
			public UIntSerializer()
			{
			}
		}

		[Token(Token = "0x200024A")]
		private class ShortSerializer<T> : FastCallSpecific<T, short>
		{
			[Token(Token = "0x6000D5E")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D5F")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D60")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D61")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D62")]
			public ShortSerializer()
			{
			}
		}

		[Token(Token = "0x200024B")]
		private class UShortSerializer<T> : FastCallSpecific<T, ushort>
		{
			[Token(Token = "0x6000D63")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D64")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D65")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D66")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D67")]
			public UShortSerializer()
			{
			}
		}

		[Token(Token = "0x200024C")]
		private class LongSerializer<T> : FastCallSpecific<T, long>
		{
			[Token(Token = "0x6000D68")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D69")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D6A")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D6B")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D6C")]
			public LongSerializer()
			{
			}
		}

		[Token(Token = "0x200024D")]
		private class ULongSerializer<T> : FastCallSpecific<T, ulong>
		{
			[Token(Token = "0x6000D6D")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D6E")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D6F")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D70")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D71")]
			public ULongSerializer()
			{
			}
		}

		[Token(Token = "0x200024E")]
		private class ByteSerializer<T> : FastCallSpecific<T, byte>
		{
			[Token(Token = "0x6000D72")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D73")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D74")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D75")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D76")]
			public ByteSerializer()
			{
			}
		}

		[Token(Token = "0x200024F")]
		private class SByteSerializer<T> : FastCallSpecific<T, sbyte>
		{
			[Token(Token = "0x6000D77")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D78")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D79")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D7A")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D7B")]
			public SByteSerializer()
			{
			}
		}

		[Token(Token = "0x2000250")]
		private class FloatSerializer<T> : FastCallSpecific<T, float>
		{
			[Token(Token = "0x6000D7C")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D7D")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D7E")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D7F")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D80")]
			public FloatSerializer()
			{
			}
		}

		[Token(Token = "0x2000251")]
		private class DoubleSerializer<T> : FastCallSpecific<T, double>
		{
			[Token(Token = "0x6000D81")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D82")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D83")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D84")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D85")]
			public DoubleSerializer()
			{
			}
		}

		[Token(Token = "0x2000252")]
		private class BoolSerializer<T> : FastCallSpecific<T, bool>
		{
			[Token(Token = "0x6000D86")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D87")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D88")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D89")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D8A")]
			public BoolSerializer()
			{
			}
		}

		[Token(Token = "0x2000253")]
		private class CharSerializer<T> : FastCallSpecificAuto<T, char>
		{
			[Token(Token = "0x6000D8B")]
			protected override void ElementWrite(NetDataWriter w, ref char prop)
			{
			}

			[Token(Token = "0x6000D8C")]
			protected override void ElementRead(NetDataReader r, out char prop)
			{
			}

			[Token(Token = "0x6000D8D")]
			public CharSerializer()
			{
			}
		}

		[Token(Token = "0x2000254")]
		private class IPEndPointSerializer<T> : FastCallSpecificAuto<T, IPEndPoint>
		{
			[Token(Token = "0x6000D8E")]
			protected override void ElementWrite(NetDataWriter w, ref IPEndPoint prop)
			{
			}

			[Token(Token = "0x6000D8F")]
			protected override void ElementRead(NetDataReader r, out IPEndPoint prop)
			{
			}

			[Token(Token = "0x6000D90")]
			public IPEndPointSerializer()
			{
			}
		}

		[Token(Token = "0x2000255")]
		private class StringSerializer<T> : FastCallSpecific<T, string>
		{
			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int _maxLength;

			[Token(Token = "0x6000D91")]
			public StringSerializer(int maxLength)
			{
			}

			[Token(Token = "0x6000D92")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D93")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D94")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D95")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x2000256")]
		private class EnumByteSerializer<T> : FastCall<T>
		{
			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected readonly PropertyInfo Property;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected readonly Type PropertyType;

			[Token(Token = "0x6000D96")]
			public EnumByteSerializer(PropertyInfo property, Type propertyType)
			{
			}

			[Token(Token = "0x6000D97")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D98")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D99")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D9A")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000D9B")]
			public override void ReadList(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D9C")]
			public override void WriteList(T inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x2000257")]
		private class EnumIntSerializer<T> : EnumByteSerializer<T>
		{
			[Token(Token = "0x6000D9D")]
			public EnumIntSerializer(PropertyInfo property, Type propertyType)
			{
			}

			[Token(Token = "0x6000D9E")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000D9F")]
			public override void Write(T inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x2000258")]
		private sealed class ClassInfo<T>
		{
			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static ClassInfo<T> Instance;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly FastCall<T>[] _serializers;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int _membersCount;

			[Token(Token = "0x6000DA0")]
			public ClassInfo(List<FastCall<T>> serializers)
			{
			}

			[Token(Token = "0x6000DA1")]
			public void Write(T obj, NetDataWriter writer)
			{
			}

			[Token(Token = "0x6000DA2")]
			public void Read(T obj, NetDataReader reader)
			{
			}
		}

		[Token(Token = "0x2000259")]
		private abstract class CustomType
		{
			[Token(Token = "0x6000DA3")]
			public abstract FastCall<T> Get<T>();

			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0x1021914", Offset = "0x1021914", VA = "0x1021914")]
			protected CustomType()
			{
			}
		}

		[Token(Token = "0x200025A")]
		private sealed class CustomTypeStruct<TProperty> : CustomType where TProperty : struct, INetSerializable
		{
			[Token(Token = "0x6000DA5")]
			public override FastCall<T> Get<T>()
			{
				return null;
			}

			[Token(Token = "0x6000DA6")]
			public CustomTypeStruct()
			{
			}
		}

		[Token(Token = "0x200025B")]
		private sealed class CustomTypeClass<TProperty> : CustomType where TProperty : class, INetSerializable
		{
			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<TProperty> _constructor;

			[Token(Token = "0x6000DA7")]
			public CustomTypeClass(Func<TProperty> constructor)
			{
			}

			[Token(Token = "0x6000DA8")]
			public override FastCall<T> Get<T>()
			{
				return null;
			}
		}

		[Token(Token = "0x200025C")]
		private sealed class CustomTypeStatic<TProperty> : CustomType
		{
			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Action<NetDataWriter, TProperty> _writer;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<NetDataReader, TProperty> _reader;

			[Token(Token = "0x6000DA9")]
			public CustomTypeStatic(Action<NetDataWriter, TProperty> writer, Func<NetDataReader, TProperty> reader)
			{
			}

			[Token(Token = "0x6000DAA")]
			public override FastCall<T> Get<T>()
			{
				return null;
			}
		}

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NetDataWriter _writer;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int _maxStringLength;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<Type, CustomType> _registeredTypes;

		[Token(Token = "0x6000D1B")]
		public void RegisterNestedType<T>() where T : struct, INetSerializable
		{
		}

		[Token(Token = "0x6000D1C")]
		public void RegisterNestedType<T>(Func<T> constructor) where T : class, INetSerializable
		{
		}

		[Token(Token = "0x6000D1D")]
		public void RegisterNestedType<T>(Action<NetDataWriter, T> writer, Func<NetDataReader, T> reader)
		{
		}

		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x14C0270", Offset = "0x14C0270", VA = "0x14C0270")]
		public NetSerializer()
		{
		}

		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x14C0278", Offset = "0x14C0278", VA = "0x14C0278")]
		public NetSerializer(int maxStringLength)
		{
		}

		[Token(Token = "0x6000D20")]
		private ClassInfo<T> RegisterInternal<T>()
		{
			return null;
		}

		[Token(Token = "0x6000D21")]
		public void Register<T>()
		{
		}

		[Token(Token = "0x6000D22")]
		public T Deserialize<T>(NetDataReader reader) where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x6000D23")]
		public bool Deserialize<T>(NetDataReader reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D24")]
		public void Serialize<T>(NetDataWriter writer, T obj) where T : class, new()
		{
		}

		[Token(Token = "0x6000D25")]
		public byte[] Serialize<T>(T obj) where T : class, new()
		{
			return null;
		}
	}
	[Token(Token = "0x200025D")]
	public class NtpPacket
	{
		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTime Epoch;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2D0", Offset = "0x73E2D0")]
		private byte[] <Bytes>k__BackingField;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73E2E0", Offset = "0x73E2E0")]
		private DateTime? <DestinationTimestamp>k__BackingField;

		[Token(Token = "0x170000C7")]
		public byte[] Bytes
		{
			[Token(Token = "0x6000DAB")]
			[Address(RVA = "0x14C3B2C", Offset = "0x14C3B2C", VA = "0x14C3B2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD34", Offset = "0x73FD34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DAC")]
			[Address(RVA = "0x14C3B34", Offset = "0x14C3B34", VA = "0x14C3B34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD44", Offset = "0x73FD44")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public NtpLeapIndicator LeapIndicator
		{
			[Token(Token = "0x6000DAD")]
			[Address(RVA = "0x14C3B3C", Offset = "0x14C3B3C", VA = "0x14C3B3C")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Token(Token = "0x170000C9")]
		public int VersionNumber
		{
			[Token(Token = "0x6000DAE")]
			[Address(RVA = "0x14C3B74", Offset = "0x14C3B74", VA = "0x14C3B74")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000DAF")]
			[Address(RVA = "0x14C3BAC", Offset = "0x14C3BAC", VA = "0x14C3BAC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public NtpMode Mode
		{
			[Token(Token = "0x6000DB0")]
			[Address(RVA = "0x14C3BEC", Offset = "0x14C3BEC", VA = "0x14C3BEC")]
			get
			{
				return default(NtpMode);
			}
			[Token(Token = "0x6000DB1")]
			[Address(RVA = "0x14C3C24", Offset = "0x14C3C24", VA = "0x14C3C24")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public int Stratum
		{
			[Token(Token = "0x6000DB2")]
			[Address(RVA = "0x14C3C64", Offset = "0x14C3C64", VA = "0x14C3C64")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CC")]
		public int Poll
		{
			[Token(Token = "0x6000DB3")]
			[Address(RVA = "0x14C3C9C", Offset = "0x14C3C9C", VA = "0x14C3C9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CD")]
		public int Precision
		{
			[Token(Token = "0x6000DB4")]
			[Address(RVA = "0x14C3CD4", Offset = "0x14C3CD4", VA = "0x14C3CD4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CE")]
		public TimeSpan RootDelay
		{
			[Token(Token = "0x6000DB5")]
			[Address(RVA = "0x14C3D0C", Offset = "0x14C3D0C", VA = "0x14C3D0C")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170000CF")]
		public TimeSpan RootDispersion
		{
			[Token(Token = "0x6000DB6")]
			[Address(RVA = "0x14C3DA4", Offset = "0x14C3DA4", VA = "0x14C3DA4")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170000D0")]
		public uint ReferenceId
		{
			[Token(Token = "0x6000DB7")]
			[Address(RVA = "0x14C3DAC", Offset = "0x14C3DAC", VA = "0x14C3DAC")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x170000D1")]
		public DateTime? ReferenceTimestamp
		{
			[Token(Token = "0x6000DB8")]
			[Address(RVA = "0x14C3E68", Offset = "0x14C3E68", VA = "0x14C3E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		public DateTime? OriginTimestamp
		{
			[Token(Token = "0x6000DB9")]
			[Address(RVA = "0x14C3FA8", Offset = "0x14C3FA8", VA = "0x14C3FA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public DateTime? ReceiveTimestamp
		{
			[Token(Token = "0x6000DBA")]
			[Address(RVA = "0x14C3FB0", Offset = "0x14C3FB0", VA = "0x14C3FB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public DateTime? TransmitTimestamp
		{
			[Token(Token = "0x6000DBB")]
			[Address(RVA = "0x14C3FB8", Offset = "0x14C3FB8", VA = "0x14C3FB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DBC")]
			[Address(RVA = "0x14C3FC0", Offset = "0x14C3FC0", VA = "0x14C3FC0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public DateTime? DestinationTimestamp
		{
			[Token(Token = "0x6000DBD")]
			[Address(RVA = "0x14C4124", Offset = "0x14C4124", VA = "0x14C4124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD54", Offset = "0x73FD54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DBE")]
			[Address(RVA = "0x14C4130", Offset = "0x14C4130", VA = "0x14C4130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FD64", Offset = "0x73FD64")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public TimeSpan RoundTripTime
		{
			[Token(Token = "0x6000DBF")]
			[Address(RVA = "0x14C4138", Offset = "0x14C4138", VA = "0x14C4138")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170000D7")]
		public TimeSpan CorrectionOffset
		{
			[Token(Token = "0x6000DC0")]
			[Address(RVA = "0x14C43D4", Offset = "0x14C43D4", VA = "0x14C43D4")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x14C455C", Offset = "0x14C455C", VA = "0x14C455C")]
		public NtpPacket()
		{
		}

		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x14C4644", Offset = "0x14C4644", VA = "0x14C4644")]
		internal NtpPacket(byte[] bytes)
		{
		}

		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x14C46E8", Offset = "0x14C46E8", VA = "0x14C46E8")]
		public static NtpPacket FromServerResponse(byte[] bytes, DateTime destinationTimestamp)
		{
			return null;
		}

		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x14C4790", Offset = "0x14C4790", VA = "0x14C4790")]
		internal void ValidateRequest()
		{
		}

		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x14C4884", Offset = "0x14C4884", VA = "0x14C4884")]
		internal void ValidateReply()
		{
		}

		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0x14C42AC", Offset = "0x14C42AC", VA = "0x14C42AC")]
		private void CheckTimestamps()
		{
		}

		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x14C3E70", Offset = "0x14C3E70", VA = "0x14C3E70")]
		private DateTime? GetDateTime64(int offset)
		{
			return null;
		}

		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x14C3FD0", Offset = "0x14C3FD0", VA = "0x14C3FD0")]
		private void SetDateTime64(int offset, DateTime? value)
		{
		}

		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x14C3D14", Offset = "0x14C3D14", VA = "0x14C3D14")]
		private TimeSpan GetTimeSpan32(int offset)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x14C49E0", Offset = "0x14C49E0", VA = "0x14C49E0")]
		private ulong GetUInt64BE(int offset)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x14C4A94", Offset = "0x14C4A94", VA = "0x14C4A94")]
		private void SetUInt64BE(int offset, ulong value)
		{
		}

		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x14C4B1C", Offset = "0x14C4B1C", VA = "0x14C4B1C")]
		private int GetInt32BE(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x14C3DB4", Offset = "0x14C3DB4", VA = "0x14C3DB4")]
		private uint GetUInt32BE(int offset)
		{
			return default(uint);
		}

		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x14C4B8C", Offset = "0x14C4B8C", VA = "0x14C4B8C")]
		private static uint SwapEndianness(uint x)
		{
			return default(uint);
		}

		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x14C4B20", Offset = "0x14C4B20", VA = "0x14C4B20")]
		private static ulong SwapEndianness(ulong x)
		{
			return default(ulong);
		}
	}
	[Token(Token = "0x200025E")]
	public enum NtpLeapIndicator
	{
		[Token(Token = "0x40007FD")]
		NoWarning,
		[Token(Token = "0x40007FE")]
		LastMinuteHas61Seconds,
		[Token(Token = "0x40007FF")]
		LastMinuteHas59Seconds,
		[Token(Token = "0x4000800")]
		AlarmCondition
	}
	[Token(Token = "0x200025F")]
	public enum NtpMode
	{
		[Token(Token = "0x4000802")]
		Client = 3,
		[Token(Token = "0x4000803")]
		Server
	}
	[Token(Token = "0x2000260")]
	internal sealed class NtpRequest
	{
		[Token(Token = "0x4000804")]
		private const int ResendTimer = 1000;

		[Token(Token = "0x4000805")]
		private const int KillTimer = 10000;

		[Token(Token = "0x4000806")]
		public const int DefaultPort = 123;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IPEndPoint _ntpEndPoint;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _resendTime;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _killTime;

		[Token(Token = "0x170000D8")]
		public bool NeedToKill
		{
			[Token(Token = "0x6000DD2")]
			[Address(RVA = "0x14C4C3C", Offset = "0x14C4C3C", VA = "0x14C4C3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x14C4C00", Offset = "0x14C4C00", VA = "0x14C4C00")]
		public NtpRequest(IPEndPoint endPoint)
		{
		}

		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x14C4C50", Offset = "0x14C4C50", VA = "0x14C4C50")]
		public bool Send(NetSocket socket, int time)
		{
			return default(bool);
		}
	}
}
namespace FlyingWormConsole3.LiteNetLib.Layers
{
	[Token(Token = "0x2000261")]
	public sealed class Crc32cLayer : PacketLayerBase
	{
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0xCFFB4C", Offset = "0xCFFB4C", VA = "0xCFFB4C")]
		public Crc32cLayer()
		{
		}

		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0xCFFB58", Offset = "0xCFFB58", VA = "0xCFFB58", Slot = "4")]
		public override void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}

		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0xCFFD3C", Offset = "0xCFFD3C", VA = "0xCFFD3C", Slot = "5")]
		public override void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}
	}
	[Token(Token = "0x2000262")]
	public abstract class PacketLayerBase
	{
		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int ExtraPacketSizeForLayer;

		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x1479230", Offset = "0x1479230", VA = "0x1479230")]
		protected PacketLayerBase(int extraPacketSizeForLayer)
		{
		}

		[Token(Token = "0x6000DD8")]
		public abstract void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);

		[Token(Token = "0x6000DD9")]
		public abstract void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);
	}
	[Token(Token = "0x2000263")]
	public class XorEncryptLayer : PacketLayerBase
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private byte[] _byteKey;

		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x101591C", Offset = "0x101591C", VA = "0x101591C")]
		public XorEncryptLayer()
		{
		}

		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x1015928", Offset = "0x1015928", VA = "0x1015928")]
		public XorEncryptLayer(byte[] key)
		{
		}

		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x1015A08", Offset = "0x1015A08", VA = "0x1015A08")]
		public XorEncryptLayer(string key)
		{
		}

		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x1015A3C", Offset = "0x1015A3C", VA = "0x1015A3C")]
		public void SetKey(string key)
		{
		}

		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x101595C", Offset = "0x101595C", VA = "0x101595C")]
		public void SetKey(byte[] key)
		{
		}

		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x1015A8C", Offset = "0x1015A8C", VA = "0x1015A8C", Slot = "4")]
		public override void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}

		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x1015B24", Offset = "0x1015B24", VA = "0x1015B24", Slot = "5")]
		public override void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}
	}
}
