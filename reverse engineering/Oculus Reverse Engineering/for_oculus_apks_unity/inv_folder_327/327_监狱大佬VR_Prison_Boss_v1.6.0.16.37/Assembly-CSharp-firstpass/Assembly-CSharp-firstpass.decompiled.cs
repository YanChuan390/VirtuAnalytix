using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
[ImageEffectTransformsToLDR]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x1EF6A0", Offset = "0x1EF6A0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1EF6A0", Offset = "0x1EF6A0")]
public class ColorSuite : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	public enum DitherMode
	{
		[Token(Token = "0x4000012")]
		Off,
		[Token(Token = "0x4000013")]
		Ordered,
		[Token(Token = "0x4000014")]
		Triangular
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[SerializeField]
	private float _colorTemp;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private float _colorTint;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private bool _toneMapping;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _exposure;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _saturation;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve _rCurve;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public AnimationCurve _gCurve;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve _bCurve;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public AnimationCurve _cCurve;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private DitherMode _ditherMode;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public Action<ColorSuite> _updateCallback;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Shader shader;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Material _material;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int _lutSize;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Texture3D _lutTexture;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture tempRT;

	[Token(Token = "0x17000001")]
	public float colorTemp
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2CC784", Offset = "0x2CC784", VA = "0x2CC784")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2CC78C", Offset = "0x2CC78C", VA = "0x2CC78C")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public float colorTint
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2CC794", Offset = "0x2CC794", VA = "0x2CC794")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2CC79C", Offset = "0x2CC79C", VA = "0x2CC79C")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public bool toneMapping
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2CC7A4", Offset = "0x2CC7A4", VA = "0x2CC7A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2CC7AC", Offset = "0x2CC7AC", VA = "0x2CC7AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public float exposure
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2CC7B4", Offset = "0x2CC7B4", VA = "0x2CC7B4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2CC7BC", Offset = "0x2CC7BC", VA = "0x2CC7BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public float saturation
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2CC7C4", Offset = "0x2CC7C4", VA = "0x2CC7C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2CC7CC", Offset = "0x2CC7CC", VA = "0x2CC7CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public AnimationCurve redCurve
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2CC7D4", Offset = "0x2CC7D4", VA = "0x2CC7D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2CC7DC", Offset = "0x2CC7DC", VA = "0x2CC7DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public AnimationCurve greenCurve
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2CCB2C", Offset = "0x2CCB2C", VA = "0x2CCB2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2CCB34", Offset = "0x2CCB34", VA = "0x2CCB34")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public AnimationCurve blueCurve
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2CCB3C", Offset = "0x2CCB3C", VA = "0x2CCB3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2CCB44", Offset = "0x2CCB44", VA = "0x2CCB44")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public AnimationCurve rgbCurve
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2CCB4C", Offset = "0x2CCB4C", VA = "0x2CCB4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2CCB54", Offset = "0x2CCB54", VA = "0x2CCB54")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public DitherMode ditherMode
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2CCB5C", Offset = "0x2CCB5C", VA = "0x2CCB5C")]
		get
		{
			return default(DitherMode);
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2CCB64", Offset = "0x2CCB64", VA = "0x2CCB64")]
		set
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2CC6D8", Offset = "0x2CC6D8", VA = "0x2CC6D8")]
	public ColorSuite()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2CCB6C", Offset = "0x2CCB6C", VA = "0x2CCB6C")]
	private static Color EncodeRGBM(float r, float g, float b)
	{
		return default(Color);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2CCCA8", Offset = "0x2CCCA8", VA = "0x2CCCA8")]
	private static float StandardIlluminantY(float x)
	{
		return default(float);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2CCCE0", Offset = "0x2CCCE0", VA = "0x2CCCE0")]
	private static Vector3 CIExyToLMS(float x, float y)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2CCDB0", Offset = "0x2CCDB0", VA = "0x2CCDB0")]
	private void Setup()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2CC7E4", Offset = "0x2CC7E4", VA = "0x2CC7E4")]
	private void UpdateLUT()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2CCF90", Offset = "0x2CCF90", VA = "0x2CCF90")]
	private Vector3 CalculateColorBalance()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2CD0AC", Offset = "0x2CD0AC", VA = "0x2CD0AC")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2CD0B0", Offset = "0x2CD0B0", VA = "0x2CD0B0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2CD0CC", Offset = "0x2CD0CC", VA = "0x2CD0CC")]
	private void Reset()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2CD0E8", Offset = "0x2CD0E8", VA = "0x2CD0E8")]
	public void ApplyChanges()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2CD494", Offset = "0x2CD494", VA = "0x2CD494")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2CD518", Offset = "0x2CD518", VA = "0x2CD518")]
	private void OnPostRender()
	{
	}
}
namespace Trebuchet.Contrepoids
{
	[Token(Token = "0x2000004")]
	public abstract class Calibrator : MonoBehaviour
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameObject[] CalibratedObjects;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] CalibratedObjectsByName;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool receiveInput;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string RecenterInputName;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public string CalibrateHeightInputName;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ResetHeightInputName;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float DesiredHeight;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform ReferencePoint;

		[Token(Token = "0x1700000B")]
		public Vector3 Offset
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0xB70C40", Offset = "0xB70C40", VA = "0xB70C40")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0xB70D3C", Offset = "0xB70D3C", VA = "0xB70D3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xB70E14", Offset = "0xB70E14", VA = "0xB70E14")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xB70F10", Offset = "0xB70F10", VA = "0xB70F10")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		private float RotationY
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0xB711B0", Offset = "0xB711B0", VA = "0xB711B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0xB71208", Offset = "0xB71208", VA = "0xB71208")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		protected abstract Transform ChildToAlign
		{
			[Token(Token = "0x6000029")]
			get;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xB70C2C", Offset = "0xB70C2C", VA = "0xB70C2C")]
		protected Calibrator()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xB712C4", Offset = "0xB712C4", VA = "0xB712C4")]
		public void Start()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xB71508", Offset = "0xB71508", VA = "0xB71508")]
		public void Update()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xB7199C", Offset = "0xB7199C", VA = "0xB7199C")]
		public void DesiredHeightOnInput()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xB718A4", Offset = "0xB718A4", VA = "0xB718A4")]
		public void RecenterOnInput()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xB71B0C", Offset = "0xB71B0C", VA = "0xB71B0C")]
		public void ApplyDesiredHeight()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xB71CC8", Offset = "0xB71CC8", VA = "0xB71CC8")]
		public void AlignHeadWith(Vector3 direction)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xB71CD0", Offset = "0xB71CD0", VA = "0xB71CD0")]
		public void RecenterXZToThis()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xB71600", Offset = "0xB71600", VA = "0xB71600")]
		private void MoveObjectsToUnderReferencePoint()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xB71E74", Offset = "0xB71E74", VA = "0xB71E74")]
		private void MoveSiblingReference()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xB712C8", Offset = "0xB712C8", VA = "0xB712C8")]
		public void SetupCalibration()
		{
		}
	}
}
namespace Trebuchet.Contrepoids.Event
{
	[Token(Token = "0x2000005")]
	public class EventManager
	{
		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF7F0", Offset = "0x1EF7F0")]
		private sealed class <Invalidate>c__AnonStorey0
		{
			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object receiver;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal EventManager $this;

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0xB72C2C", Offset = "0xB72C2C", VA = "0xB72C2C")]
			public <Invalidate>c__AnonStorey0()
			{
			}

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0xB72CC4", Offset = "0xB72CC4", VA = "0xB72CC4")]
			internal bool <>m__0(Type t)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xB72CFC", Offset = "0xB72CFC", VA = "0xB72CFC")]
			internal void <>m__1(Type type)
			{
			}
		}

		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF800", Offset = "0x1EF800")]
		private sealed class <SetCache>c__AnonStorey1<T> where T : IEventReceiver
		{
			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Type type;

			[Token(Token = "0x60002A8")]
			public <SetCache>c__AnonStorey1()
			{
			}

			[Token(Token = "0x60002A9")]
			internal bool <>m__0(object r)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF810", Offset = "0x1EF810")]
		private sealed class <Get>c__AnonStorey2<T> where T : class, IEventReceiver
		{
			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T cgetter;

			[Token(Token = "0x60002AA")]
			public <Get>c__AnonStorey2()
			{
			}

			[Token(Token = "0x60002AB")]
			internal bool <>m__0(T t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private List<object> allReceiver;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Dictionary<Type, List<IEventReceiver>> cache;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xB72684", Offset = "0xB72684", VA = "0xB72684")]
		public EventManager()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xB72744", Offset = "0xB72744", VA = "0xB72744")]
		public void Add(object receiver)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xB72984", Offset = "0xB72984", VA = "0xB72984")]
		public void AddRange(params object[] receivers)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xB729E4", Offset = "0xB729E4", VA = "0xB729E4")]
		public void AddRange(IEnumerable<object> receivers)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xB72AC4", Offset = "0xB72AC4", VA = "0xB72AC4")]
		public void Remove(object receiver)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xB72B4C", Offset = "0xB72B4C", VA = "0xB72B4C")]
		public void RemoveRange(IEnumerable<object> receivers)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xB727CC", Offset = "0xB727CC", VA = "0xB727CC")]
		private void Invalidate(object receiver)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xB72C34", Offset = "0xB72C34", VA = "0xB72C34")]
		public void AddIfNeeded(object receiver)
		{
		}

		[Token(Token = "0x600003C")]
		private List<IEventReceiver> SetCache<T>() where T : IEventReceiver
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		public IEnumerable<T> Get<T>(object getter) where T : class, IEventReceiver
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		public void Send<T>(object sender, Action<T> action) where T : class, IEventReceiver
		{
		}
	}
	[Token(Token = "0x2000006")]
	public interface IEventReceiver
	{
	}
}
namespace Trebuchet.Contrepoids
{
	[Token(Token = "0x2000007")]
	public class ChangeMat : GoMBase
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material material;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xB71FF0", Offset = "0xB71FF0", VA = "0xB71FF0")]
		public ChangeMat()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xB72010", Offset = "0xB72010", VA = "0xB72010", Slot = "4")]
		public override void Apply()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class ChangeName : GoMBase
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NewName;

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xB72178", Offset = "0xB72178", VA = "0xB72178")]
		public ChangeName()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xB721EC", Offset = "0xB721EC", VA = "0xB721EC", Slot = "4")]
		public override void Apply()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class ChangeShader : GoMBase
	{
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Shader newShader;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xB72320", Offset = "0xB72320", VA = "0xB72320")]
		public ChangeShader()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xB72330", Offset = "0xB72330", VA = "0xB72330", Slot = "4")]
		public override void Apply()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class CopyName : MonoBehaviour
	{
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string[] names;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform target;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xB72420", Offset = "0xB72420", VA = "0xB72420")]
		public CopyName()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB72428", Offset = "0xB72428", VA = "0xB72428")]
		public void Copy()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xB72580", Offset = "0xB72580", VA = "0xB72580")]
		public void Paste()
		{
		}
	}
}
[Token(Token = "0x200000B")]
public class GOMButton : Attribute
{
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2D6F08", Offset = "0x2D6F08", VA = "0x2D6F08")]
	public GOMButton()
	{
	}
}
namespace Trebuchet.Contrepoids
{
	[Token(Token = "0x200000C")]
	public class GoMBase : MonoBehaviour
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool DestroyAfterUse;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xB72000", Offset = "0xB72000", VA = "0xB72000")]
		public GoMBase()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xB720E4", Offset = "0xB720E4", VA = "0xB720E4", Slot = "4")]
		public virtual void Apply()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class PushScaleToChild : GoMBase
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool PushToLeaf;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool PushOnlyToMeshRenderer;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xB72D88", Offset = "0xB72D88", VA = "0xB72D88")]
		public PushScaleToChild()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xB72D98", Offset = "0xB72D98", VA = "0xB72D98", Slot = "4")]
		public override void Apply()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xB72DC4", Offset = "0xB72DC4", VA = "0xB72DC4")]
		private void Apply(Transform target)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xB73500", Offset = "0xB73500", VA = "0xB73500")]
		private void Push(Vector3 from, Transform to)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xB73598", Offset = "0xB73598", VA = "0xB73598")]
		private bool ShouldPushToChild(Transform target)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000E")]
	public class ResetToOrigin : GoMBase
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 localPosition;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion localRotation;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xB73660", Offset = "0xB73660", VA = "0xB73660")]
		public ResetToOrigin()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xB73670", Offset = "0xB73670", VA = "0xB73670", Slot = "4")]
		public override void Apply()
		{
		}
	}
}
namespace Trebuchet
{
	[Token(Token = "0x200000F")]
	public class App : MonoBehaviour
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0xB70C18", Offset = "0xB70C18", VA = "0xB70C18")]
		public App()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xB70C20", Offset = "0xB70C20", VA = "0xB70C20")]
		public static void Quit()
		{
		}
	}
}
[Token(Token = "0x2000010")]
public class NVRLifeCycle : MonoBehaviour
{
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2D6F10", Offset = "0x2D6F10", VA = "0x2D6F10")]
	public NVRLifeCycle()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2D6F18", Offset = "0x2D6F18", VA = "0x2D6F18")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2D7008", Offset = "0x2D7008", VA = "0x2D7008")]
	private void SceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}
}
[Token(Token = "0x2000011")]
public class NVRParent : MonoBehaviour
{
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject targetParent;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2D7170", Offset = "0x2D7170", VA = "0x2D7170")]
	public NVRParent()
	{
	}
}
[Token(Token = "0x2000012")]
public class DontDestroyOnLoad : MonoBehaviour
{
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2D4414", Offset = "0x2D4414", VA = "0x2D4414")]
	public DontDestroyOnLoad()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2D441C", Offset = "0x2D441C", VA = "0x2D441C")]
	private void Awake()
	{
	}
}
namespace Trebuchet
{
	[Token(Token = "0x2000013")]
	public class Platform : MonoBehaviour
	{
		[Token(Token = "0x2000014")]
		public enum PlatformStatus
		{
			[Token(Token = "0x4000030")]
			uninitialized,
			[Token(Token = "0x4000031")]
			initializing,
			[Token(Token = "0x4000032")]
			initialized,
			[Token(Token = "0x4000033")]
			initializationFailed,
			[Token(Token = "0x4000034")]
			initializationError
		}

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF820", Offset = "0x1EF820")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1EF820", Offset = "0x1EF820")]
		private static string <name>k__BackingField;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF854", Offset = "0x1EF854")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1EF854", Offset = "0x1EF854")]
		private static PlatformStatus <status>k__BackingField;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF888", Offset = "0x1EF888")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1EF888", Offset = "0x1EF888")]
		private static string <userName>k__BackingField;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Action<PlatformStatus> statusCallback;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool demo;

		[Token(Token = "0x1700000F")]
		public new static string name
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xB7703C", Offset = "0xB7703C", VA = "0xB7703C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF8BC", Offset = "0x1EF8BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xB76E8C", Offset = "0xB76E8C", VA = "0xB76E8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF8CC", Offset = "0x1EF8CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public static PlatformStatus status
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xB770C8", Offset = "0xB770C8", VA = "0xB770C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF8DC", Offset = "0x1EF8DC")]
			get
			{
				return default(PlatformStatus);
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xB76F1C", Offset = "0xB76F1C", VA = "0xB76F1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF8EC", Offset = "0x1EF8EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public static string userName
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0xB77154", Offset = "0xB77154", VA = "0xB77154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF8FC", Offset = "0x1EF8FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0xB76FAC", Offset = "0xB76FAC", VA = "0xB76FAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF90C", Offset = "0x1EF90C")]
			private set
			{
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xB76DAC", Offset = "0xB76DAC", VA = "0xB76DAC")]
		public Platform()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xB771E0", Offset = "0xB771E0", VA = "0xB771E0")]
		public static void NameChange(string name)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xB77260", Offset = "0xB77260", VA = "0xB77260")]
		public static void StatusCallbackAdd(Action<PlatformStatus> callback)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xB773B8", Offset = "0xB773B8", VA = "0xB773B8")]
		public static void StatusCallbackRemove(Action<PlatformStatus> callback)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xB774E0", Offset = "0xB774E0", VA = "0xB774E0")]
		public static void StatusChange(PlatformStatus status)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xB775E0", Offset = "0xB775E0", VA = "0xB775E0")]
		public static void UserNameChange(string userName)
		{
		}
	}
}
namespace Trebuchet.Contrepoids
{
	[Token(Token = "0x2000015")]
	public class SceneActivator : MonoBehaviour
	{
		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF92C", Offset = "0x1EF92C")]
		private sealed class <LoadSceneAfterInit>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x17000049")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60002AE")]
				[Address(RVA = "0xB74678", Offset = "0xB74678", VA = "0xB74678", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002AF")]
				[Address(RVA = "0xB74680", Offset = "0xB74680", VA = "0xB74680", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xB74444", Offset = "0xB74444", VA = "0xB74444")]
			[DebuggerHidden]
			public <LoadSceneAfterInit>c__Iterator0()
			{
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xB744F0", Offset = "0xB744F0", VA = "0xB744F0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xB74688", Offset = "0xB74688", VA = "0xB74688", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0xB7469C", Offset = "0xB7469C", VA = "0xB7469C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool InitSceneHasBeenLoaded;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static string SceneToLoadAfterInit;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Transform DisabledTransform;

		[Token(Token = "0x17000012")]
		public static bool InitDone
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xB738DC", Offset = "0xB738DC", VA = "0xB738DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public bool IsActive
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xB73968", Offset = "0xB73968", VA = "0xB73968")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		private bool IsInit
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xB73A58", Offset = "0xB73A58", VA = "0xB73A58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xB738D4", Offset = "0xB738D4", VA = "0xB738D4")]
		public SceneActivator()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xB73B44", Offset = "0xB73B44", VA = "0xB73B44")]
		private void Awake()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xB73CAC", Offset = "0xB73CAC", VA = "0xB73CAC")]
		private void CheckObjectCondition()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xB73FEC", Offset = "0xB73FEC", VA = "0xB73FEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xB73E80", Offset = "0xB73E80", VA = "0xB73E80")]
		public void Desactivate()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xB743C0", Offset = "0xB743C0", VA = "0xB743C0")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xB74334", Offset = "0xB74334", VA = "0xB74334")]
		[DebuggerHidden]
		private IEnumerator LoadSceneAfterInit()
		{
			return null;
		}
	}
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1EF98C", Offset = "0x1EF98C")]
	public class SceneLoaderHelperAttribute : Attribute
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0xB76DA4", Offset = "0xB76DA4", VA = "0xB76DA4")]
		public SceneLoaderHelperAttribute()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class SceneLoader : MonoBehaviour
	{
		[Token(Token = "0x2000018")]
		public class SceneInformations
		{
			[Token(Token = "0x200007D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFA20", Offset = "0x1EFA20")]
			private sealed class <WaitForActive>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
			{
				[Token(Token = "0x400021E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal SceneInformations $this;

				[Token(Token = "0x400021F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				internal object $current;

				[Token(Token = "0x4000220")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal bool $disposing;

				[Token(Token = "0x4000221")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				internal int $PC;

				[Token(Token = "0x1700004B")]
				private object System.Collections.Generic.IEnumerator<object>.Current
				{
					[Token(Token = "0x60002B4")]
					[Address(RVA = "0xB76CFC", Offset = "0xB76CFC", VA = "0xB76CFC", Slot = "8")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x1700004C")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x60002B5")]
					[Address(RVA = "0xB76D04", Offset = "0xB76D04", VA = "0xB76D04", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x60002B2")]
				[Address(RVA = "0xB76C2C", Offset = "0xB76C2C", VA = "0xB76C2C")]
				[DebuggerHidden]
				public <WaitForActive>c__Iterator0()
				{
				}

				[Token(Token = "0x60002B3")]
				[Address(RVA = "0xB76C34", Offset = "0xB76C34", VA = "0xB76C34", Slot = "5")]
				public bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x60002B6")]
				[Address(RVA = "0xB76D0C", Offset = "0xB76D0C", VA = "0xB76D0C", Slot = "7")]
				[DebuggerHidden]
				public void Dispose()
				{
				}

				[Token(Token = "0x60002B7")]
				[Address(RVA = "0xB76D20", Offset = "0xB76D20", VA = "0xB76D20", Slot = "6")]
				[DebuggerHidden]
				public void Reset()
				{
				}
			}

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string name;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Scene? scene;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public SceneActivator activator;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncOperation loading;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public AsyncOperation unloading;

			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool activateAfterLoad;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool destroyAfterFirstDesactivation;

			[Token(Token = "0x17000016")]
			public bool IsActive
			{
				[Token(Token = "0x6000092")]
				[Address(RVA = "0xB76598", Offset = "0xB76598", VA = "0xB76598")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000091")]
			[Address(RVA = "0xB75530", Offset = "0xB75530", VA = "0xB75530")]
			public SceneInformations()
			{
			}

			[Token(Token = "0x6000093")]
			[Address(RVA = "0xB75B38", Offset = "0xB75B38", VA = "0xB75B38")]
			public void SetActive()
			{
			}

			[Token(Token = "0x6000094")]
			[Address(RVA = "0xB76BA4", Offset = "0xB76BA4", VA = "0xB76BA4")]
			public void Destroy()
			{
			}

			[Token(Token = "0x6000095")]
			[Address(RVA = "0xB76BAC", Offset = "0xB76BAC", VA = "0xB76BAC")]
			[DebuggerHidden]
			public IEnumerator WaitForActive()
			{
				return null;
			}
		}

		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFA80", Offset = "0x1EFA80")]
		private sealed class <GetInfosLoadingWith>c__AnonStorey1
		{
			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal AsyncOperation operation;

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xB74990", Offset = "0xB74990", VA = "0xB74990")]
			public <GetInfosLoadingWith>c__AnonStorey1()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xB76820", Offset = "0xB76820", VA = "0xB76820")]
			internal bool <>m__0(SceneInformations infos)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFA90", Offset = "0x1EFA90")]
		private sealed class <GetInfosUnloadingWith>c__AnonStorey2
		{
			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal AsyncOperation operation;

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xB74A84", Offset = "0xB74A84", VA = "0xB74A84")]
			public <GetInfosUnloadingWith>c__AnonStorey2()
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xB76854", Offset = "0xB76854", VA = "0xB76854")]
			internal bool <>m__0(SceneInformations infos)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFAA0", Offset = "0x1EFAA0")]
		private sealed class <GetInfos>c__AnonStorey3
		{
			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Scene scene;

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xB74B78", Offset = "0xB74B78", VA = "0xB74B78")]
			public <GetInfos>c__AnonStorey3()
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xB766AC", Offset = "0xB766AC", VA = "0xB766AC")]
			internal bool <>m__0(SceneInformations infos)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFAB0", Offset = "0x1EFAB0")]
		private sealed class <GetInfos>c__AnonStorey4
		{
			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string name;

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xB74C6C", Offset = "0xB74C6C", VA = "0xB74C6C")]
			public <GetInfos>c__AnonStorey4()
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xB7677C", Offset = "0xB7677C", VA = "0xB7677C")]
			internal bool <>m__0(SceneInformations infos)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000082")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFAC0", Offset = "0x1EFAC0")]
		private sealed class <UnloadSceneSlowly>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SceneInformations infos;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal SceneLoader $this;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x1700004D")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60002C2")]
				[Address(RVA = "0xB76AFC", Offset = "0xB76AFC", VA = "0xB76AFC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002C3")]
				[Address(RVA = "0xB76B04", Offset = "0xB76B04", VA = "0xB76B04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xB7656C", Offset = "0xB7656C", VA = "0xB7656C")]
			[DebuggerHidden]
			public <UnloadSceneSlowly>c__Iterator0()
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xB76888", Offset = "0xB76888", VA = "0xB76888", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xB76B0C", Offset = "0xB76B0C", VA = "0xB76B0C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xB76B20", Offset = "0xB76B20", VA = "0xB76B20", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SceneLoader _Instance;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<SceneInformations> ScenesInfos;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Scene? lastLoadedScene;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF9C0", Offset = "0x1EF9C0")]
		private static Func<SceneInformations, bool> <>f__am$cache0;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF9D0", Offset = "0x1EF9D0")]
		private static Func<SceneInformations, bool> <>f__am$cache1;

		[Token(Token = "0x17000015")]
		public static SceneLoader Instance
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xB74290", Offset = "0xB74290", VA = "0xB74290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xB74720", Offset = "0xB74720", VA = "0xB74720")]
		public SceneLoader()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xB747AC", Offset = "0xB747AC", VA = "0xB747AC")]
		public IEnumerable<SceneInformations> GetInfosActive()
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xB748A4", Offset = "0xB748A4", VA = "0xB748A4")]
		public IEnumerable<SceneInformations> GetInfosLoadingWith(AsyncOperation operation)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xB74998", Offset = "0xB74998", VA = "0xB74998")]
		public IEnumerable<SceneInformations> GetInfosUnloadingWith(AsyncOperation operation)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xB74A8C", Offset = "0xB74A8C", VA = "0xB74A8C")]
		public IEnumerable<SceneInformations> GetInfos(Scene scene)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xB74B80", Offset = "0xB74B80", VA = "0xB74B80")]
		public IEnumerable<SceneInformations> GetInfos(string name)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xB74C74", Offset = "0xB74C74", VA = "0xB74C74")]
		public void Awake()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xB753DC", Offset = "0xB753DC", VA = "0xB753DC")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xB74FD8", Offset = "0xB74FD8", VA = "0xB74FD8")]
		private void CreateHelpers()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xB74DD8", Offset = "0xB74DD8", VA = "0xB74DD8")]
		private void PopulateFromOpenedScene()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xB75650", Offset = "0xB75650", VA = "0xB75650")]
		private void SceneManager_sceneUnloaded(Scene arg0)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xB75764", Offset = "0xB75764", VA = "0xB75764")]
		private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xB75810", Offset = "0xB75810", VA = "0xB75810")]
		private void SceneManager_activeSceneChanged(Scene current, Scene next)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xB7587C", Offset = "0xB7587C", VA = "0xB7587C")]
		private void Scene_completed(AsyncOperation obj)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xB75B68", Offset = "0xB75B68", VA = "0xB75B68")]
		private void Unloading_completed(AsyncOperation asyncOperation)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xB75538", Offset = "0xB75538", VA = "0xB75538")]
		private SceneActivator GetActivator(Scene scene)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xB75CF8", Offset = "0xB75CF8", VA = "0xB75CF8")]
		private void SetSceneActive(SceneInformations sceneInformations)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xB75F98", Offset = "0xB75F98", VA = "0xB75F98")]
		private void SetSceneInactive(SceneInformations info)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xB743A0", Offset = "0xB743A0", VA = "0xB743A0")]
		public static SceneInformations LoadScene(int buildIndex)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xB7464C", Offset = "0xB7464C", VA = "0xB7464C")]
		public static SceneInformations LoadScene(string name)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xB76248", Offset = "0xB76248", VA = "0xB76248")]
		public static SceneInformations PrepareSceneOnce(int buildIndex)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xB76104", Offset = "0xB76104", VA = "0xB76104")]
		public static SceneInformations PrepareSceneOnce(string name)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xB763C4", Offset = "0xB763C4", VA = "0xB763C4")]
		public static SceneInformations PrepareScene(int buildIndex)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xB762EC", Offset = "0xB762EC", VA = "0xB762EC")]
		public static SceneInformations PrepareScene(string name)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB763E4", Offset = "0xB763E4", VA = "0xB763E4")]
		private void SetupLoadingInfos(SceneInformations infos)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xB760AC", Offset = "0xB760AC", VA = "0xB760AC")]
		private static void DestroyScene(SceneInformations infos)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xB764D4", Offset = "0xB764D4", VA = "0xB764D4")]
		[DebuggerHidden]
		private IEnumerator UnloadSceneSlowly(SceneInformations infos)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xB76574", Offset = "0xB76574", VA = "0xB76574")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EF9F0", Offset = "0x1EF9F0")]
		private static bool <GetInfosActive>m__0(SceneInformations infos)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xB76680", Offset = "0xB76680", VA = "0xB76680")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFA00", Offset = "0x1EFA00")]
		private static bool <PrepareSceneOnce>m__1(SceneInformations info)
		{
			return default(bool);
		}
	}
}
namespace Trebuchet.Settings
{
	[Token(Token = "0x2000019")]
	public class SimpleScriptableObject<T> : ScriptableObject where T : BaseSettings, new()
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Data;

		[Token(Token = "0x6000096")]
		public SimpleScriptableObject()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class BaseSettings : ICloneable
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0xB77664", Offset = "0xB77664", VA = "0xB77664")]
		public BaseSettings()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xB7766C", Offset = "0xB7766C", VA = "0xB7766C", Slot = "4")]
		public object Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x200001B")]
	public class Settings<T, U> : MonoBehaviour where T : BaseSettings, new() where U : SimpleScriptableObject<T>
	{
		[Token(Token = "0x2000083")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFB60", Offset = "0x1EFB60")]
		private sealed class <GetDefaultValues>c__Iterator0 : IEnumerable, IEnumerable<object>, IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Type type;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal object $current;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool $disposing;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int $PC;

			[Token(Token = "0x1700004F")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60002C8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000050")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002C9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C6")]
			[DebuggerHidden]
			public <GetDefaultValues>c__Iterator0()
			{
			}

			[Token(Token = "0x60002C7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002CA")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60002CB")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x60002CC")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002CD")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<object>.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public U SettingDefaultValue;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string SettingFilePath;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public U ForceSetting;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T SavedSettings;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T ForcedSettings;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FieldInfo[] members;

		[Token(Token = "0x17000017")]
		private static FieldInfo[] Members
		{
			[Token(Token = "0x600009E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private string FilePath
		{
			[Token(Token = "0x600009F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private string PersistentFilePath
		{
			[Token(Token = "0x60000A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000099")]
		public Settings()
		{
		}

		[Token(Token = "0x600009A")]
		public T GetSettings()
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		public T GetForcedSettings()
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		public T GetSavedSettings()
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		public void SetSettings(T settings)
		{
		}

		[Token(Token = "0x60000A1")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A2")]
		public void ReloadSettings()
		{
		}

		[Token(Token = "0x60000A3")]
		private static T MergeSettings(params T[] settings)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		private void LoadFromFile(string[] paths)
		{
		}

		[Token(Token = "0x60000A5")]
		private static void Save(T setting, string filepath)
		{
		}

		[Token(Token = "0x60000A6")]
		private static void LoadPublicFieldFromT()
		{
		}

		[Token(Token = "0x60000A7")]
		private static void CopyNonDefaultMember(T from, ref T to)
		{
		}

		[Token(Token = "0x60000A8")]
		[DebuggerHidden]
		private static IEnumerable GetDefaultValues(Type type)
		{
			return null;
		}
	}
}
namespace UnityToolbag
{
	[Token(Token = "0x200001C")]
	public static class StandardPaths
	{
		[Token(Token = "0x200001D")]
		private static class Windows
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0xB792FC", Offset = "0xB792FC", VA = "0xB792FC")]
			public static string GetPath(string subdirectory)
			{
				return null;
			}
		}

		[Token(Token = "0x200001E")]
		private static class OSX
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xB793EC", Offset = "0xB793EC", VA = "0xB793EC")]
			public static string GetApplicationSupportPath(string subdirectory)
			{
				return null;
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0xB79978", Offset = "0xB79978", VA = "0xB79978")]
			public static string GetLogsPath()
			{
				return null;
			}
		}

		[Token(Token = "0x200001F")]
		private static class Linux
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xB794E8", Offset = "0xB794E8", VA = "0xB794E8")]
			public static string GetSaveDirectory()
			{
				return null;
			}

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xB79738", Offset = "0xB79738", VA = "0xB79738")]
			public static string GetConfigDirectory()
			{
				return null;
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xB79A64", Offset = "0xB79A64", VA = "0xB79A64")]
			public static string GetLogDirectory()
			{
				return null;
			}
		}

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFBE0", Offset = "0x1EFBE0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1EFBE0", Offset = "0x1EFBE0")]
		private static bool <includeCompanyName>k__BackingField;

		[Token(Token = "0x1700001A")]
		public static bool includeCompanyName
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xB79170", Offset = "0xB79170", VA = "0xB79170")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFC14", Offset = "0x1EFC14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xB790E0", Offset = "0xB790E0", VA = "0xB790E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFC24", Offset = "0x1EFC24")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public static string saveDataDirectory
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xB791FC", Offset = "0xB791FC", VA = "0xB791FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public static string configDirectory
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xB79638", Offset = "0xB79638", VA = "0xB79638")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public static string logDirectory
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0xB79888", Offset = "0xB79888", VA = "0xB79888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xB790D8", Offset = "0xB790D8", VA = "0xB790D8")]
		static StandardPaths()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xB79AEC", Offset = "0xB79AEC", VA = "0xB79AEC")]
		private static string AppendProductPath(string path)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xB79C04", Offset = "0xB79C04", VA = "0xB79C04")]
		private static string AppendDirectory(string path, string dir)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xB79D14", Offset = "0xB79D14", VA = "0xB79D14")]
		private static string CleanForPath(string str)
		{
			return null;
		}
	}
}
namespace Trebuchet.Utils
{
	[Token(Token = "0x2000020")]
	public static class BezierUtils
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xB77674", Offset = "0xB77674", VA = "0xB77674")]
		public static void GetQuadraticBezierCurve(ref Vector3[] points, Vector3 start, Vector3 end, Vector3 ctrl)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xB77970", Offset = "0xB77970", VA = "0xB77970")]
		public static void GetCubicBezierCurve(ref Vector3[] points, Vector3 start, Vector3 end, Vector3 ctrl, Vector3 ctrl2)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xB77AB8", Offset = "0xB77AB8", VA = "0xB77AB8")]
		public static Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xB777A4", Offset = "0xB777A4", VA = "0xB777A4")]
		public static Vector3 CalculateQuadraticBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000021")]
	public static class GlobalUtils
	{
		[Token(Token = "0x2000022")]
		public struct TypeWithAttributes<T> where T : Attribute
		{
			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Type Type;

			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T[] Attributes;
		}

		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFC94", Offset = "0x1EFC94")]
		private sealed class <GetClass>c__Iterator0<T> : IEnumerable, IEnumerable<TypeWithAttributes<T>>, IEnumerator, IDisposable, IEnumerator<TypeWithAttributes<T>> where T : Attribute
		{
			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Assembly[] $locvar0;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int $locvar1;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Assembly <assembly>__1;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Type[] $locvar2;

			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int $locvar3;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Type <type>__2;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool inheritAttributes;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal object[] <attributes>__3;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TypeWithAttributes<T> $current;

			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool $disposing;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int $PC;

			[Token(Token = "0x17000051")]
			private TypeWithAttributes<T> System.Collections.Generic.IEnumerator<Trebuchet.Utils.GlobalUtils.TypeWithAttributes<T>>.Current
			{
				[Token(Token = "0x60002D0")]
				[DebuggerHidden]
				get
				{
					return default(TypeWithAttributes<T>);
				}
			}

			[Token(Token = "0x17000052")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002D1")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002CE")]
			[DebuggerHidden]
			public <GetClass>c__Iterator0()
			{
			}

			[Token(Token = "0x60002CF")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002D2")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60002D3")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x60002D4")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002D5")]
			[DebuggerHidden]
			private IEnumerator<TypeWithAttributes<T>> System.Collections.Generic.IEnumerable<Trebuchet.Utils.GlobalUtils.TypeWithAttributes<T>>.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject globalManager;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xB77CF4", Offset = "0xB77CF4", VA = "0xB77CF4")]
		public static bool IsNotNull(this object target)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xB77D04", Offset = "0xB77D04", VA = "0xB77D04")]
		public static bool IsNumber(this float number)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xB77D44", Offset = "0xB77D44", VA = "0xB77D44")]
		public static Mesh GetMeshInstance(this Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Token(Token = "0x60000C1")]
		public static void Resize<T>(ref T[] array, int size)
		{
		}

		[Token(Token = "0x60000C2")]
		[DebuggerHidden]
		public static IEnumerable<TypeWithAttributes<T>> GetClass<T>(bool inheritAttributes = true) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		public static T GlobalManager<T>(ref T instance, [Optional] Action<T> initialiser) where T : Component, new()
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	public static class LinqUtils
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFD24", Offset = "0x1EFD24")]
		private static Func<bool, bool> <>f__am$cache0;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xB77ED0", Offset = "0xB77ED0", VA = "0xB77ED0")]
		public static bool All(this IEnumerable<bool> bools)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		public static bool StartsWith<Source>(this IEnumerable<Source> first, ICollection<Source> second)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xB77FC4", Offset = "0xB77FC4", VA = "0xB77FC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFD54", Offset = "0x1EFD54")]
		private static bool <All>m__0(bool b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000024")]
	public static class TransformUtils
	{
		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFE24", Offset = "0x1EFE24")]
		private sealed class <FindClose>c__AnonStorey0<T> where T : Component
		{
			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Vector3 position;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal float distance;

			[Token(Token = "0x60002D6")]
			public <FindClose>c__AnonStorey0()
			{
			}

			[Token(Token = "0x60002D7")]
			internal bool <>m__0(T w)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xB77FCC", Offset = "0xB77FCC", VA = "0xB77FCC")]
		public static void LerpWorld(this Transform transform, Vector3 position, Quaternion rotation, float speed)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xB783B0", Offset = "0xB783B0", VA = "0xB783B0")]
		public static void LerpLocal(this Transform transform, Vector3 position, Quaternion rotation, float speed)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xB78560", Offset = "0xB78560", VA = "0xB78560")]
		public static float Lerp(this float value, float target, float speed)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xB78580", Offset = "0xB78580", VA = "0xB78580")]
		public static void LerpLocal(this Transform transform, Vector3 position, Quaternion rotation, Vector3 scale, float speed)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xB787A8", Offset = "0xB787A8", VA = "0xB787A8")]
		public static void SetLayerRecursively(this GameObject gameObject, int newLayer)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xB78BE4", Offset = "0xB78BE4", VA = "0xB78BE4")]
		public static void SetLayerRecursively(this Component component, int newLayer)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xB78864", Offset = "0xB78864", VA = "0xB78864")]
		public static void SetLayerRecursively(this Transform transform, int newLayer)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xB78CA0", Offset = "0xB78CA0", VA = "0xB78CA0")]
		public static Transform FindDeep(this Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		public static IEnumerable<T> FindClose<T>(this Component comp, float distance = 3f) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		public static T GetOrAdd<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		public static T GetOrAdd<T>(this Component component) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x2000025")]
	public static class VectorUtils
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xB7907C", Offset = "0xB7907C", VA = "0xB7907C")]
		public static Vector3 MultipliedBy(this Vector3 orig, Vector3 other)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xB781F8", Offset = "0xB781F8", VA = "0xB781F8")]
		public static bool IsRotation(this Quaternion quat)
		{
			return default(bool);
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1EFE64", Offset = "0x1EFE64")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float delay;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float duration;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Ease easeType;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LoopType loopType;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int loops;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string id;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool isRelative;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool isFrom;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		public bool isIndependentUpdate;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		public bool autoKill;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isActive;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isValid;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Component target;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DOTweenAnimationType animationType;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public TargetType targetType;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TargetType forcedTargetType;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool autoPlay;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool useTargetAsV3;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float endValueFloat;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 endValueV3;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector2 endValueV2;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color endValueColor;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string endValueString;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Rect endValueRect;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Transform endValueTransform;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool optionalBool0;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float optionalFloat0;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int optionalInt0;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public string optionalString;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _tweenCreated;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _playCount;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2CD608", Offset = "0x2CD608", VA = "0x2CD608")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2CD86C", Offset = "0x2CD86C", VA = "0x2CD86C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2D03F4", Offset = "0x2D03F4", VA = "0x2D03F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2D0434", Offset = "0x2D0434", VA = "0x2D0434")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2CD8B8", Offset = "0x2CD8B8", VA = "0x2CD8B8")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2D1100", Offset = "0x2D1100", VA = "0x2D1100", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2D1198", Offset = "0x2D1198", VA = "0x2D1198", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2D1230", Offset = "0x2D1230", VA = "0x2D1230", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2D12C8", Offset = "0x2D12C8", VA = "0x2D12C8", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2D1360", Offset = "0x2D1360", VA = "0x2D1360", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2D13F8", Offset = "0x2D13F8", VA = "0x2D13F8", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2D1558", Offset = "0x2D1558", VA = "0x2D1558", Slot = "10")]
		public override void DORestart(bool fromHere = false)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2D1A40", Offset = "0x2D1A40", VA = "0x2D1A40", Slot = "11")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2D1ADC", Offset = "0x2D1ADC", VA = "0x2D1ADC", Slot = "12")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2D1B80", Offset = "0x2D1B80", VA = "0x2D1B80")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2D1C20", Offset = "0x2D1C20", VA = "0x2D1C20")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2D1CA8", Offset = "0x2D1CA8", VA = "0x2D1CA8")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2D1D30", Offset = "0x2D1D30", VA = "0x2D1D30")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2D1DD0", Offset = "0x2D1DD0", VA = "0x2D1DD0")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2D1E58", Offset = "0x2D1E58", VA = "0x2D1E58")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2D1EF8", Offset = "0x2D1EF8", VA = "0x2D1EF8")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2D1F80", Offset = "0x2D1F80", VA = "0x2D1F80")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2D20E0", Offset = "0x2D20E0", VA = "0x2D20E0")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2D218C", Offset = "0x2D218C", VA = "0x2D218C")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2D224C", Offset = "0x2D224C", VA = "0x2D224C")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2D22F8", Offset = "0x2D22F8", VA = "0x2D22F8")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2D0480", Offset = "0x2D0480", VA = "0x2D0480")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2D1674", Offset = "0x2D1674", VA = "0x2D1674")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2D2410", Offset = "0x2D2410", VA = "0x2D2410")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFE98", Offset = "0x1EFE98")]
		private void <CreateTween>m__0()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x60000F2")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000028")]
	public static class ShortcutExtensionsTextMeshPro
	{
		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFF78", Offset = "0x1EFF78")]
		private sealed class <DOColor>c__AnonStorey0
		{
			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x2D241C", Offset = "0x2D241C", VA = "0x2D241C")]
			public <DOColor>c__AnonStorey0()
			{
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x2D2FC8", Offset = "0x2D2FC8", VA = "0x2D2FC8")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x2D3000", Offset = "0x2D3000", VA = "0x2D3000")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFF88", Offset = "0x1EFF88")]
		private sealed class <DOFaceColor>c__AnonStorey1
		{
			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x2D25D8", Offset = "0x2D25D8", VA = "0x2D25D8")]
			public <DOFaceColor>c__AnonStorey1()
			{
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x2D305C", Offset = "0x2D305C", VA = "0x2D305C")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x2D309C", Offset = "0x2D309C", VA = "0x2D309C")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFF98", Offset = "0x1EFF98")]
		private sealed class <DOOutlineColor>c__AnonStorey2
		{
			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x2D2794", Offset = "0x2D2794", VA = "0x2D2794")]
			public <DOOutlineColor>c__AnonStorey2()
			{
			}

			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x2D32B8", Offset = "0x2D32B8", VA = "0x2D32B8")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x2D32F8", Offset = "0x2D32F8", VA = "0x2D32F8")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFFA8", Offset = "0x1EFFA8")]
		private sealed class <DOFade>c__AnonStorey3
		{
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x2D28F0", Offset = "0x2D28F0", VA = "0x2D28F0")]
			public <DOFade>c__AnonStorey3()
			{
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x2D3174", Offset = "0x2D3174", VA = "0x2D3174")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x2D31AC", Offset = "0x2D31AC", VA = "0x2D31AC")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFFB8", Offset = "0x1EFFB8")]
		private sealed class <DOFaceFade>c__AnonStorey4
		{
			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x2D2A8C", Offset = "0x2D2A8C", VA = "0x2D2A8C")]
			public <DOFaceFade>c__AnonStorey4()
			{
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x2D30E8", Offset = "0x2D30E8", VA = "0x2D30E8")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x2D3128", Offset = "0x2D3128", VA = "0x2D3128")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFFC8", Offset = "0x1EFFC8")]
		private sealed class <DOScale>c__AnonStorey5
		{
			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Transform t;

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x2D2C80", Offset = "0x2D2C80", VA = "0x2D2C80")]
			public <DOScale>c__AnonStorey5()
			{
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x2D3344", Offset = "0x2D3344", VA = "0x2D3344")]
			internal Vector3 <>m__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x2D3374", Offset = "0x2D3374", VA = "0x2D3374")]
			internal void <>m__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFFD8", Offset = "0x1EFFD8")]
		private sealed class <DOFontSize>c__AnonStorey6
		{
			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x2D2E1C", Offset = "0x2D2E1C", VA = "0x2D2E1C")]
			public <DOFontSize>c__AnonStorey6()
			{
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x2D3208", Offset = "0x2D3208", VA = "0x2D3208")]
			internal float <>m__0()
			{
				return default(float);
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x2D3230", Offset = "0x2D3230", VA = "0x2D3230")]
			internal void <>m__1(float x)
			{
			}
		}

		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFFE8", Offset = "0x1EFFE8")]
		private sealed class <DOMaxVisibleCharacters>c__AnonStorey7
		{
			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x2D2FB8", Offset = "0x2D2FB8", VA = "0x2D2FB8")]
			public <DOMaxVisibleCharacters>c__AnonStorey7()
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x2D3260", Offset = "0x2D3260", VA = "0x2D3260")]
			internal int <>m__0()
			{
				return default(int);
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x2D3288", Offset = "0x2D3288", VA = "0x2D3288")]
			internal void <>m__1(int x)
			{
			}
		}

		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1EFFF8", Offset = "0x1EFFF8")]
		private sealed class <DOText>c__AnonStorey8
		{
			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x2D2FC0", Offset = "0x2D2FC0", VA = "0x2D2FC0")]
			public <DOText>c__AnonStorey8()
			{
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x2D33C0", Offset = "0x2D33C0", VA = "0x2D33C0")]
			internal string <>m__0()
			{
				return null;
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x2D33E8", Offset = "0x2D33E8", VA = "0x2D33E8")]
			internal void <>m__1(string x)
			{
			}
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2D089C", Offset = "0x2D089C", VA = "0x2D089C")]
		public static Tweener DOColor(this TextMeshPro target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2D2424", Offset = "0x2D2424", VA = "0x2D2424")]
		public static Tweener DOFaceColor(this TextMeshPro target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2D25E0", Offset = "0x2D25E0", VA = "0x2D25E0")]
		public static Tweener DOOutlineColor(this TextMeshPro target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2D279C", Offset = "0x2D279C", VA = "0x2D279C")]
		public static Tweener DOGlowColor(this TextMeshPro target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2D0BDC", Offset = "0x2D0BDC", VA = "0x2D0BDC")]
		public static Tweener DOFade(this TextMeshPro target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2D28F8", Offset = "0x2D28F8", VA = "0x2D28F8")]
		public static Tweener DOFaceFade(this TextMeshPro target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2D2A94", Offset = "0x2D2A94", VA = "0x2D2A94")]
		public static Tweener DOScale(this TextMeshPro target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2D2C88", Offset = "0x2D2C88", VA = "0x2D2C88")]
		public static Tweener DOFontSize(this TextMeshPro target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2D2E24", Offset = "0x2D2E24", VA = "0x2D2E24")]
		public static Tweener DOMaxVisibleCharacters(this TextMeshPro target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2D0F38", Offset = "0x2D0F38", VA = "0x2D0F38")]
		public static Tweener DOText(this TextMeshPro target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
	[Token(Token = "0x2000029")]
	public static class ShortcutExtensionsTextMeshProUGUI
	{
		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F00B8", Offset = "0x1F00B8")]
		private sealed class <DOColor>c__AnonStorey0
		{
			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x2D3418", Offset = "0x2D3418", VA = "0x2D3418")]
			public <DOColor>c__AnonStorey0()
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x2D3FC4", Offset = "0x2D3FC4", VA = "0x2D3FC4")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x2D3FFC", Offset = "0x2D3FFC", VA = "0x2D3FFC")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F00C8", Offset = "0x1F00C8")]
		private sealed class <DOFaceColor>c__AnonStorey1
		{
			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x2D35D4", Offset = "0x2D35D4", VA = "0x2D35D4")]
			public <DOFaceColor>c__AnonStorey1()
			{
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x2D4058", Offset = "0x2D4058", VA = "0x2D4058")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x2D4098", Offset = "0x2D4098", VA = "0x2D4098")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F00D8", Offset = "0x1F00D8")]
		private sealed class <DOOutlineColor>c__AnonStorey2
		{
			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x2D3790", Offset = "0x2D3790", VA = "0x2D3790")]
			public <DOOutlineColor>c__AnonStorey2()
			{
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x2D42B4", Offset = "0x2D42B4", VA = "0x2D42B4")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x2D42F4", Offset = "0x2D42F4", VA = "0x2D42F4")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F00E8", Offset = "0x1F00E8")]
		private sealed class <DOFade>c__AnonStorey3
		{
			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x2D38EC", Offset = "0x2D38EC", VA = "0x2D38EC")]
			public <DOFade>c__AnonStorey3()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x2D4170", Offset = "0x2D4170", VA = "0x2D4170")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x2D41A8", Offset = "0x2D41A8", VA = "0x2D41A8")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F00F8", Offset = "0x1F00F8")]
		private sealed class <DOFaceFade>c__AnonStorey4
		{
			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x2D3A88", Offset = "0x2D3A88", VA = "0x2D3A88")]
			public <DOFaceFade>c__AnonStorey4()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x2D40E4", Offset = "0x2D40E4", VA = "0x2D40E4")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x2D4124", Offset = "0x2D4124", VA = "0x2D4124")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0108", Offset = "0x1F0108")]
		private sealed class <DOScale>c__AnonStorey5
		{
			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Transform t;

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x2D3C7C", Offset = "0x2D3C7C", VA = "0x2D3C7C")]
			public <DOScale>c__AnonStorey5()
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x2D4340", Offset = "0x2D4340", VA = "0x2D4340")]
			internal Vector3 <>m__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x2D4370", Offset = "0x2D4370", VA = "0x2D4370")]
			internal void <>m__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0118", Offset = "0x1F0118")]
		private sealed class <DOFontSize>c__AnonStorey6
		{
			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x2D3E18", Offset = "0x2D3E18", VA = "0x2D3E18")]
			public <DOFontSize>c__AnonStorey6()
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x2D4204", Offset = "0x2D4204", VA = "0x2D4204")]
			internal float <>m__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x2D422C", Offset = "0x2D422C", VA = "0x2D422C")]
			internal void <>m__1(float x)
			{
			}
		}

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0128", Offset = "0x1F0128")]
		private sealed class <DOMaxVisibleCharacters>c__AnonStorey7
		{
			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x2D3FB4", Offset = "0x2D3FB4", VA = "0x2D3FB4")]
			public <DOMaxVisibleCharacters>c__AnonStorey7()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x2D425C", Offset = "0x2D425C", VA = "0x2D425C")]
			internal int <>m__0()
			{
				return default(int);
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x2D4284", Offset = "0x2D4284", VA = "0x2D4284")]
			internal void <>m__1(int x)
			{
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0138", Offset = "0x1F0138")]
		private sealed class <DOText>c__AnonStorey8
		{
			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x2D3FBC", Offset = "0x2D3FBC", VA = "0x2D3FBC")]
			public <DOText>c__AnonStorey8()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x2D43BC", Offset = "0x2D43BC", VA = "0x2D43BC")]
			internal string <>m__0()
			{
				return null;
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x2D43E4", Offset = "0x2D43E4", VA = "0x2D43E4")]
			internal void <>m__1(string x)
			{
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2D06F0", Offset = "0x2D06F0", VA = "0x2D06F0")]
		public static Tweener DOColor(this TextMeshProUGUI target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2D3420", Offset = "0x2D3420", VA = "0x2D3420")]
		public static Tweener DOFaceColor(this TextMeshProUGUI target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2D35DC", Offset = "0x2D35DC", VA = "0x2D35DC")]
		public static Tweener DOOutlineColor(this TextMeshProUGUI target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2D3798", Offset = "0x2D3798", VA = "0x2D3798")]
		public static Tweener DOGlowColor(this TextMeshProUGUI target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2D0A48", Offset = "0x2D0A48", VA = "0x2D0A48")]
		public static Tweener DOFade(this TextMeshProUGUI target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2D38F4", Offset = "0x2D38F4", VA = "0x2D38F4")]
		public static Tweener DOFaceFade(this TextMeshProUGUI target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2D3A90", Offset = "0x2D3A90", VA = "0x2D3A90")]
		public static Tweener DOScale(this TextMeshProUGUI target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2D3C84", Offset = "0x2D3C84", VA = "0x2D3C84")]
		public static Tweener DOFontSize(this TextMeshProUGUI target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2D3E20", Offset = "0x2D3E20", VA = "0x2D3E20")]
		public static Tweener DOMaxVisibleCharacters(this TextMeshProUGUI target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2D0D70", Offset = "0x2D0D70", VA = "0x2D0D70")]
		public static Tweener DOText(this TextMeshProUGUI target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
}
namespace SoftMasking
{
	[Token(Token = "0x200002A")]
	internal struct ClearListAtExit<T> : IDisposable
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> _list;

		[Token(Token = "0x6000107")]
		public ClearListAtExit(List<T> list)
		{
		}

		[Token(Token = "0x6000108")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public interface ISoftMask
	{
		[Token(Token = "0x1700001E")]
		bool isAlive
		{
			[Token(Token = "0x6000109")]
			get;
		}

		[Token(Token = "0x1700001F")]
		bool isMaskingEnabled
		{
			[Token(Token = "0x600010A")]
			get;
		}

		[Token(Token = "0x600010B")]
		Material GetReplacement(Material original);

		[Token(Token = "0x600010C")]
		void ReleaseReplacement(Material replacement);

		[Token(Token = "0x600010D")]
		void UpdateTransformChildren(Transform transform);
	}
}
namespace SoftMasking.Extensions
{
	[Token(Token = "0x200002C")]
	public static class MaterialOps
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2D7178", Offset = "0x2D7178", VA = "0x2D7178")]
		public static bool SupportsSoftMask(this Material mat)
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2D71EC", Offset = "0x2D71EC", VA = "0x2D71EC")]
		public static bool HasDefaultUIShader(this Material mat)
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2D72C0", Offset = "0x2D72C0", VA = "0x2D72C0")]
		public static bool HasDefaultETC1UIShader(this Material mat)
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2D7394", Offset = "0x2D7394", VA = "0x2D7394")]
		public static void EnableKeyword(this Material mat, string keyword, bool enabled)
		{
		}
	}
}
namespace SoftMasking
{
	[Token(Token = "0x200002D")]
	internal class MaterialReplacements
	{
		[Token(Token = "0x200002E")]
		private class MaterialOverride
		{
			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int _useCount;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0198", Offset = "0x1F0198")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1F0198", Offset = "0x1F0198")]
			private Material <original>k__BackingField;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F01CC", Offset = "0x1F01CC")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1F01CC", Offset = "0x1F01CC")]
			private Material <replacement>k__BackingField;

			[Token(Token = "0x17000020")]
			public Material original
			{
				[Token(Token = "0x6000118")]
				[Address(RVA = "0x2D7954", Offset = "0x2D7954", VA = "0x2D7954")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0200", Offset = "0x1F0200")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000119")]
				[Address(RVA = "0x2D7DDC", Offset = "0x2D7DDC", VA = "0x2D7DDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0210", Offset = "0x1F0210")]
				private set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public Material replacement
			{
				[Token(Token = "0x600011A")]
				[Address(RVA = "0x2D7B44", Offset = "0x2D7B44", VA = "0x2D7B44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0220", Offset = "0x1F0220")]
				get
				{
					return null;
				}
				[Token(Token = "0x600011B")]
				[Address(RVA = "0x2D7DE4", Offset = "0x2D7DE4", VA = "0x2D7DE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0230", Offset = "0x1F0230")]
				private set
				{
				}
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2D7970", Offset = "0x2D7970", VA = "0x2D7970")]
			public MaterialOverride(Material original, Material replacement)
			{
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2D795C", Offset = "0x2D795C", VA = "0x2D795C")]
			public Material Get()
			{
				return null;
			}

			[Token(Token = "0x600011D")]
			[Address(RVA = "0x2D7B4C", Offset = "0x2D7B4C", VA = "0x2D7B4C")]
			public bool Release()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly IMaterialReplacer _replacer;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly Action<Material> _applyParameters;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<MaterialOverride> _overrides;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2D75BC", Offset = "0x2D75BC", VA = "0x2D75BC")]
		public MaterialReplacements(IMaterialReplacer replacer, Action<Material> applyParameters)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2D7658", Offset = "0x2D7658", VA = "0x2D7658")]
		public Material Get(Material original)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2D79A0", Offset = "0x2D79A0", VA = "0x2D79A0")]
		public void Release(Material replacement)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2D7B64", Offset = "0x2D7B64", VA = "0x2D7B64")]
		public void ApplyAll()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2D7CB0", Offset = "0x2D7CB0", VA = "0x2D7CB0")]
		public void DestroyAllAndClear()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x1F0240", Offset = "0x1F0240")]
	public class GlobalMaterialReplacerAttribute : Attribute
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2D73D8", Offset = "0x2D73D8", VA = "0x2D73D8")]
		public GlobalMaterialReplacerAttribute()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public interface IMaterialReplacer
	{
		[Token(Token = "0x17000022")]
		int order
		{
			[Token(Token = "0x600011F")]
			get;
		}

		[Token(Token = "0x6000120")]
		Material Replace(Material material);
	}
	[Token(Token = "0x2000031")]
	public static class MaterialReplacer
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<IMaterialReplacer> _globalReplacers;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0264", Offset = "0x1F0264")]
		private static Func<Assembly, IEnumerable<Type>> <>f__mg$cache0;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0274", Offset = "0x1F0274")]
		private static Func<Type, bool> <>f__mg$cache1;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0284", Offset = "0x1F0284")]
		private static Func<Type, IMaterialReplacer> <>f__mg$cache2;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0294", Offset = "0x1F0294")]
		private static Func<IMaterialReplacer, bool> <>f__am$cache0;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F02A4", Offset = "0x1F02A4")]
		private static Func<Type, bool> <>f__am$cache1;

		[Token(Token = "0x17000023")]
		public static IEnumerable<IMaterialReplacer> globalReplacers
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2D7DEC", Offset = "0x2D7DEC", VA = "0x2D7DEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2D7E98", Offset = "0x2D7E98", VA = "0x2D7E98")]
		private static IEnumerable<IMaterialReplacer> CollectGlobalReplacers()
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2D81B8", Offset = "0x2D81B8", VA = "0x2D81B8")]
		private static bool IsMaterialReplacerType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2D834C", Offset = "0x2D834C", VA = "0x2D834C")]
		private static IMaterialReplacer TryCreateInstance(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2D85F0", Offset = "0x2D85F0", VA = "0x2D85F0")]
		private static IEnumerable<Type> GetTypesSafe(this Assembly asm)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2D87A4", Offset = "0x2D87A4", VA = "0x2D87A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F02C4", Offset = "0x1F02C4")]
		private static bool <CollectGlobalReplacers>m__0(IMaterialReplacer t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2D87B4", Offset = "0x2D87B4", VA = "0x2D87B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F02D4", Offset = "0x1F02D4")]
		private static bool <GetTypesSafe>m__1(Type t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000032")]
	public class MaterialReplacerChain : IMaterialReplacer
	{
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly List<IMaterialReplacer> _replacers;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F02E4", Offset = "0x1F02E4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1F02E4", Offset = "0x1F02E4")]
		private int <order>k__BackingField;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0318", Offset = "0x1F0318")]
		private static Comparison<IMaterialReplacer> <>f__am$cache0;

		[Token(Token = "0x17000024")]
		public int order
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x2D8A34", Offset = "0x2D8A34", VA = "0x2D8A34", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0328", Offset = "0x1F0328")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x2D8A3C", Offset = "0x2D8A3C", VA = "0x2D8A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0338", Offset = "0x1F0338")]
			private set
			{
			}
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2D87C4", Offset = "0x2D87C4", VA = "0x2D87C4")]
		public MaterialReplacerChain(IEnumerable<IMaterialReplacer> replacers, IMaterialReplacer yetAnother)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2D8A44", Offset = "0x2D8A44", VA = "0x2D8A44", Slot = "5")]
		public Material Replace(Material material)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2D8878", Offset = "0x2D8878", VA = "0x2D8878")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2D8BF8", Offset = "0x2D8BF8", VA = "0x2D8BF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0348", Offset = "0x1F0348")]
		private static int <Initialize>m__0(IMaterialReplacer a, IMaterialReplacer b)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000033")]
	public static class MaskChannel
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Color alpha;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Color red;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Color green;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Color blue;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Color gray;
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1F0358", Offset = "0x1F0358")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F0358", Offset = "0x1F0358")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1F0358", Offset = "0x1F0358")]
	public class SoftMask : UIBehaviour, ISoftMask, ICanvasRaycastFilter
	{
		[Serializable]
		[Token(Token = "0x2000035")]
		public enum MaskSource
		{
			[Token(Token = "0x40000A1")]
			Graphic,
			[Token(Token = "0x40000A2")]
			Sprite,
			[Token(Token = "0x40000A3")]
			Texture
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		public enum BorderMode
		{
			[Token(Token = "0x40000A5")]
			Simple,
			[Token(Token = "0x40000A6")]
			Sliced,
			[Token(Token = "0x40000A7")]
			Tiled
		}

		[Serializable]
		[Token(Token = "0x2000037")]
		[Flags]
		public enum Errors
		{
			[Token(Token = "0x40000A9")]
			NoError = 0,
			[Token(Token = "0x40000AA")]
			UnsupportedShaders = 1,
			[Token(Token = "0x40000AB")]
			NestedMasks = 2,
			[Token(Token = "0x40000AC")]
			TightPackedSprite = 4,
			[Token(Token = "0x40000AD")]
			AlphaSplitSprite = 8,
			[Token(Token = "0x40000AE")]
			UnsupportedImageType = 0x10,
			[Token(Token = "0x40000AF")]
			UnreadableTexture = 0x20
		}

		[Token(Token = "0x2000038")]
		private struct SourceParameters
		{
			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Image image;

			[Token(Token = "0x40000B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Sprite sprite;

			[Token(Token = "0x40000B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BorderMode spriteBorderMode;

			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Texture2D texture;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rect textureUVRect;
		}

		[Token(Token = "0x2000039")]
		private class MaterialReplacerImpl : IMaterialReplacer
		{
			[Token(Token = "0x40000B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly SoftMask _owner;

			[Token(Token = "0x17000035")]
			public int order
			{
				[Token(Token = "0x600017B")]
				[Address(RVA = "0x2DF064", Offset = "0x2DF064", VA = "0x2DF064", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2D8F34", Offset = "0x2D8F34", VA = "0x2D8F34")]
			public MaterialReplacerImpl(SoftMask owner)
			{
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x2DF06C", Offset = "0x2DF06C", VA = "0x2DF06C", Slot = "5")]
			public Material Replace(Material original)
			{
				return null;
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2DF198", Offset = "0x2DF198", VA = "0x2DF198")]
			private static Material Replace(Material original, Shader defaultReplacementShader)
			{
				return null;
			}
		}

		[Token(Token = "0x200003A")]
		private static class Mathr
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2DCA54", Offset = "0x2DCA54", VA = "0x2DCA54")]
			public static Vector4 ToVector(Rect r)
			{
				return default(Vector4);
			}

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x2DCBC8", Offset = "0x2DCBC8", VA = "0x2DCBC8")]
			public static Vector4 Div(Vector4 v, Vector2 s)
			{
				return default(Vector4);
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x2DD4D4", Offset = "0x2DD4D4", VA = "0x2DD4D4")]
			public static Vector2 Div(Vector2 v, Vector2 s)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2DCC70", Offset = "0x2DCC70", VA = "0x2DCC70")]
			public static Vector4 Mul(Vector4 v, Vector2 s)
			{
				return default(Vector4);
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2DCC30", Offset = "0x2DCC30", VA = "0x2DCC30")]
			public static Vector2 Size(Vector4 r)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x2DCAF0", Offset = "0x2DCAF0", VA = "0x2DCAF0")]
			public static Vector4 Move(Vector4 v, Vector2 o)
			{
				return default(Vector4);
			}

			[Token(Token = "0x6000184")]
			[Address(RVA = "0x2DCB58", Offset = "0x2DCB58", VA = "0x2DCB58")]
			public static Vector4 BorderOf(Vector4 outer, Vector4 inner)
			{
				return default(Vector4);
			}

			[Token(Token = "0x6000185")]
			[Address(RVA = "0x2DCCD8", Offset = "0x2DCCD8", VA = "0x2DCCD8")]
			public static Vector4 ApplyBorder(Vector4 v, Vector4 b)
			{
				return default(Vector4);
			}

			[Token(Token = "0x6000186")]
			[Address(RVA = "0x2DF2FC", Offset = "0x2DF2FC", VA = "0x2DF2FC")]
			public static Vector2 Min(Vector4 r)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000187")]
			[Address(RVA = "0x2DF324", Offset = "0x2DF324", VA = "0x2DF324")]
			public static Vector2 Max(Vector4 r)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000188")]
			[Address(RVA = "0x2DE9B0", Offset = "0x2DE9B0", VA = "0x2DE9B0")]
			public static Vector2 Remap(Vector2 c, Vector4 from, Vector4 to)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2D9EBC", Offset = "0x2D9EBC", VA = "0x2D9EBC")]
			public static bool Inside(Vector2 v, Vector4 r)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200003B")]
		private struct MaterialParameters
		{
			[Token(Token = "0x200003C")]
			private static class Ids
			{
				[Token(Token = "0x40000BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly int SoftMask;

				[Token(Token = "0x40000C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public static readonly int SoftMask_Rect;

				[Token(Token = "0x40000C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static readonly int SoftMask_UVRect;

				[Token(Token = "0x40000C2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public static readonly int SoftMask_ChannelWeights;

				[Token(Token = "0x40000C3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public static readonly int SoftMask_WorldToMask;

				[Token(Token = "0x40000C4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public static readonly int SoftMask_BorderRect;

				[Token(Token = "0x40000C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public static readonly int SoftMask_UVBorderRect;

				[Token(Token = "0x40000C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public static readonly int SoftMask_TileRepeat;
			}

			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector4 maskRect;

			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector4 maskBorder;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector4 maskRectUV;

			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector4 maskBorderUV;

			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector2 tileRepeat;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Color maskChannelWeights;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Matrix4x4 worldToMask;

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Texture2D texture;

			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public BorderMode borderMode;

			[Token(Token = "0x17000036")]
			public Texture2D activeTexture
			{
				[Token(Token = "0x600018A")]
				[Address(RVA = "0x2DE674", Offset = "0x2DE674", VA = "0x2DE674")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2DE818", Offset = "0x2DE818", VA = "0x2DE818")]
			public bool SampleMask(Vector2 localPos, out float mask)
			{
				return default(bool);
			}

			[Token(Token = "0x600018C")]
			[Address(RVA = "0x2DE834", Offset = "0x2DE834", VA = "0x2DE834")]
			public void Apply(Material mat)
			{
			}

			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2DE994", Offset = "0x2DE994", VA = "0x2DE994")]
			private Vector2 XY2UV(Vector2 localPos)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0x2DEBCC", Offset = "0x2DEBCC", VA = "0x2DEBCC")]
			private Vector2 MapSimple(Vector2 localPos)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600018F")]
			[Address(RVA = "0x2DEC74", Offset = "0x2DEC74", VA = "0x2DEC74")]
			private Vector2 MapBorder(Vector2 localPos, bool repeat)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000190")]
			[Address(RVA = "0x2DEE20", Offset = "0x2DEE20", VA = "0x2DEE20")]
			private float Inset(float v, float x1, float x2, float u1, float u2, float repeat = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2DEE54", Offset = "0x2DEE54", VA = "0x2DEE54")]
			private float Inset(float v, float x1, float x2, float x3, float x4, float u1, float u2, float u3, float u4, float repeat = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0x2DEEA8", Offset = "0x2DEEA8", VA = "0x2DEEA8")]
			private float Frac(float v)
			{
				return default(float);
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x2DEEAC", Offset = "0x2DEEAC", VA = "0x2DEEAC")]
			private float MaskValue(Color mask)
			{
				return default(float);
			}
		}

		[Token(Token = "0x200003D")]
		private struct Diagnostics
		{
			[Token(Token = "0x2000098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0544", Offset = "0x1F0544")]
			private sealed class <PollErrors>c__AnonStorey0
			{
				[Token(Token = "0x400024E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal SoftMask softMask;

				[Token(Token = "0x600030E")]
				[Address(RVA = "0x2DDCC8", Offset = "0x2DDCC8", VA = "0x2DDCC8")]
				public <PollErrors>c__AnonStorey0()
				{
				}

				[Token(Token = "0x600030F")]
				[Address(RVA = "0x2DE5A8", Offset = "0x2DE5A8", VA = "0x2DE5A8")]
				internal bool <>m__0(SoftMaskable m)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x2000099")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0554", Offset = "0x1F0554")]
			private sealed class <ThereAreNestedMasks>c__AnonStorey1
			{
				[Token(Token = "0x400024F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal SoftMask softMask;

				[Token(Token = "0x6000310")]
				[Address(RVA = "0x2DE288", Offset = "0x2DE288", VA = "0x2DE288")]
				public <ThereAreNestedMasks>c__AnonStorey1()
				{
				}

				[Token(Token = "0x6000311")]
				[Address(RVA = "0x2DE608", Offset = "0x2DE608", VA = "0x2DE608")]
				internal bool <>m__0(SoftMask x)
				{
					return default(bool);
				}

				[Token(Token = "0x6000312")]
				[Address(RVA = "0x2DE614", Offset = "0x2DE614", VA = "0x2DE614")]
				internal bool <>m__1(SoftMask x)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private SoftMask _softMask;

			[Token(Token = "0x17000037")]
			private Image image
			{
				[Token(Token = "0x6000198")]
				[Address(RVA = "0x2DE23C", Offset = "0x2DE23C", VA = "0x2DE23C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000038")]
			private Sprite sprite
			{
				[Token(Token = "0x6000199")]
				[Address(RVA = "0x2DE244", Offset = "0x2DE244", VA = "0x2DE244")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private Texture2D texture
			{
				[Token(Token = "0x600019A")]
				[Address(RVA = "0x2DE280", Offset = "0x2DE280", VA = "0x2DE280")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x2DDCC0", Offset = "0x2DDCC0", VA = "0x2DDCC0")]
			public Diagnostics(SoftMask softMask)
			{
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x2DE200", Offset = "0x2DE200", VA = "0x2DE200")]
			public Errors PollErrors()
			{
				return default(Errors);
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x2DC768", Offset = "0x2DC768", VA = "0x2DC768")]
			public static Errors CheckSprite(Sprite sprite)
			{
				return default(Errors);
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0x2DE290", Offset = "0x2DE290", VA = "0x2DE290")]
			private bool ThereAreNestedMasks()
			{
				return default(bool);
			}

			[Token(Token = "0x600019C")]
			[Address(RVA = "0x2DE2A8", Offset = "0x2DE2A8", VA = "0x2DE2A8")]
			private Errors CheckImage()
			{
				return default(Errors);
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0x2DE3B8", Offset = "0x2DE3B8", VA = "0x2DE3B8")]
			private Errors CheckTexture()
			{
				return default(Errors);
			}

			[Token(Token = "0x600019E")]
			[Address(RVA = "0x2DE3C0", Offset = "0x2DE3C0", VA = "0x2DE3C0")]
			private static bool AreCompeting(SoftMask softMask, SoftMask other)
			{
				return default(bool);
			}

			[Token(Token = "0x600019F")]
			private static T SelectChild<T>(T first, T second) where T : Component
			{
				return null;
			}

			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x2DE2B0", Offset = "0x2DE2B0", VA = "0x2DE2B0")]
			private static bool IsReadable(Texture2D texture)
			{
				return default(bool);
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x2DE298", Offset = "0x2DE298", VA = "0x2DE298")]
			private static bool IsSupportedImageType(Image.Type type)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Shader _defaultShader;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Shader _defaultETC1Shader;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MaskSource _source;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _separateMask;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Sprite _sprite;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BorderMode _spriteBorderMode;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Texture2D _texture;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rect _textureUVRect;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _channelWeights;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _raycastThreshold;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private MaterialReplacements _materials;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MaterialParameters _parameters;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Sprite _lastUsedSprite;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Rect _lastMaskRect;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool _maskingWasEnabled;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		private bool _destroyed;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		private bool _dirty;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RectTransform _maskTransform;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Graphic _graphic;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Canvas _canvas;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Rect DefaultUVRect;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<SoftMask> s_masks;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly List<SoftMaskable> s_maskables;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F04E4", Offset = "0x1F04E4")]
		private static Action<SoftMaskable> <>f__am$cache0;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F04F4", Offset = "0x1F04F4")]
		private static Action<SoftMaskable> <>f__am$cache1;

		[Token(Token = "0x17000025")]
		private bool SoftMasking.ISoftMask.isAlive
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x2DAF40", Offset = "0x2DAF40", VA = "0x2DAF40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000026")]
		public Shader defaultShader
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x2D8F54", Offset = "0x2D8F54", VA = "0x2D8F54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x2D8F5C", Offset = "0x2D8F5C", VA = "0x2D8F5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public Shader defaultETC1Shader
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2D9054", Offset = "0x2D9054", VA = "0x2D9054")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x2D905C", Offset = "0x2D905C", VA = "0x2D905C")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public MaskSource source
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2D9080", Offset = "0x2D9080", VA = "0x2D9080")]
			get
			{
				return default(MaskSource);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2D9088", Offset = "0x2D9088", VA = "0x2D9088")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public RectTransform separateMask
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2D9104", Offset = "0x2D9104", VA = "0x2D9104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2D910C", Offset = "0x2D910C", VA = "0x2D910C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Sprite sprite
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2D91D8", Offset = "0x2D91D8", VA = "0x2D91D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2D91E0", Offset = "0x2D91E0", VA = "0x2D91E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public BorderMode spriteBorderMode
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2D92A0", Offset = "0x2D92A0", VA = "0x2D92A0")]
			get
			{
				return default(BorderMode);
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2D92A8", Offset = "0x2D92A8", VA = "0x2D92A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Texture2D texture
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2D9324", Offset = "0x2D9324", VA = "0x2D9324")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2D932C", Offset = "0x2D932C", VA = "0x2D932C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Rect textureUVRect
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2D93EC", Offset = "0x2D93EC", VA = "0x2D93EC")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x2D9400", Offset = "0x2D9400", VA = "0x2D9400")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Color channelWeights
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2D94C8", Offset = "0x2D94C8", VA = "0x2D94C8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2D94DC", Offset = "0x2D94DC", VA = "0x2D94DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public float raycastThreshold
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2D95A4", Offset = "0x2D95A4", VA = "0x2D95A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2D95AC", Offset = "0x2D95AC", VA = "0x2D95AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool isUsingRaycastFiltering
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x2D95B4", Offset = "0x2D95B4", VA = "0x2D95B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public bool isMaskingEnabled
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2D95CC", Offset = "0x2D95CC", VA = "0x2D95CC", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		private RectTransform maskTransform
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2D9CD4", Offset = "0x2D9CD4", VA = "0x2D9CD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private Canvas canvas
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2D9680", Offset = "0x2D9680", VA = "0x2D9680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private bool isBasedOnGraphic
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x2DAF2C", Offset = "0x2DAF2C", VA = "0x2DAF2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2D8D74", Offset = "0x2D8D74", VA = "0x2D8D74")]
		public SoftMask()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2D9724", Offset = "0x2D9724", VA = "0x2D9724")]
		public Errors PollErrors()
		{
			return default(Errors);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2D99B8", Offset = "0x2D99B8", VA = "0x2D99B8", Slot = "22")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2DA120", Offset = "0x2DA120", VA = "0x2DA120", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2DA220", Offset = "0x2DA220", VA = "0x2DA220", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2DAA0C", Offset = "0x2DAA0C", VA = "0x2DAA0C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2DAC44", Offset = "0x2DAC44", VA = "0x2DAC44", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2DAC6C", Offset = "0x2DAC6C", VA = "0x2DAC6C", Slot = "23")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2DAD58", Offset = "0x2DAD58", VA = "0x2DAD58", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2DAD78", Offset = "0x2DAD78", VA = "0x2DAD78", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2DAD98", Offset = "0x2DAD98", VA = "0x2DAD98", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2DADC0", Offset = "0x2DADC0", VA = "0x2DADC0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2DADF0", Offset = "0x2DADF0", VA = "0x2DADF0")]
		private void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2DA278", Offset = "0x2DA278", VA = "0x2DA278")]
		private void SubscribeOnWillRenderCanvases()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2DAB8C", Offset = "0x2DAB8C", VA = "0x2DAB8C")]
		private void UnsubscribeFromWillRenderCanvases()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2DAE0C", Offset = "0x2DAE0C", VA = "0x2DAE0C")]
		private void OnWillRenderCanvases()
		{
		}

		[Token(Token = "0x6000155")]
		private static T Touch<T>(T obj)
		{
			return (T)null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2DAFE8", Offset = "0x2DAFE8", VA = "0x2DAFE8", Slot = "19")]
		private Material SoftMasking.ISoftMask.GetReplacement(Material original)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2DB014", Offset = "0x2DB014", VA = "0x2DB014", Slot = "20")]
		private void SoftMasking.ISoftMask.ReleaseReplacement(Material replacement)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2DB040", Offset = "0x2DB040", VA = "0x2DB040", Slot = "21")]
		private void SoftMasking.ISoftMask.UpdateTransformChildren(Transform transform)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2DB044", Offset = "0x2DB044", VA = "0x2DB044")]
		private void OnGraphicDirty()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2DA5EC", Offset = "0x2DA5EC", VA = "0x2DA5EC")]
		private void FindGraphic()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2DAE30", Offset = "0x2DAE30", VA = "0x2DAE30")]
		private Canvas NearestEnabledCanvas()
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2DA7B8", Offset = "0x2DA7B8", VA = "0x2DA7B8")]
		private void UpdateMaskParameters()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2DA390", Offset = "0x2DA390", VA = "0x2DA390")]
		private void SpawnMaskablesInChildren(Transform root)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2DB1A0", Offset = "0x2DB1A0", VA = "0x2DB1A0")]
		private void InvalidateChildren()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2DA88C", Offset = "0x2DA88C", VA = "0x2DA88C")]
		private void NotifyChildrenThatMaskMightChanged()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2DB320", Offset = "0x2DB320", VA = "0x2DB320")]
		private void ForEachChildMaskable(Action<SoftMaskable> f)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2DAC20", Offset = "0x2DAC20", VA = "0x2DAC20")]
		private void DestroyMaterials()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2DB68C", Offset = "0x2DB68C", VA = "0x2DB68C")]
		private SourceParameters DeduceSourceParameters()
		{
			return default(SourceParameters);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2DBA48", Offset = "0x2DBA48", VA = "0x2DBA48")]
		private BorderMode ToBorderMode(Image.Type imageType)
		{
			return default(BorderMode);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2DB058", Offset = "0x2DB058", VA = "0x2DB058")]
		private void CalculateMaskParameters()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2DBBCC", Offset = "0x2DBBCC", VA = "0x2DBBCC")]
		private void CalculateSpriteBased(Sprite sprite, BorderMode borderMode)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2DCE94", Offset = "0x2DCE94", VA = "0x2DCE94")]
		private static Vector4 AdjustBorders(Vector4 border, Vector4 rect)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2DC5A4", Offset = "0x2DC5A4", VA = "0x2DC5A4")]
		private void CalculateTextureBased(Texture2D texture, Rect uvRect)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2DC6B4", Offset = "0x2DC6B4", VA = "0x2DC6B4")]
		private void CalculateSolidFill()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2DC9A0", Offset = "0x2DC9A0", VA = "0x2DC9A0")]
		private void FillCommonParameters()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2DCD48", Offset = "0x2DCD48", VA = "0x2DCD48")]
		private float GraphicToCanvasScale(Sprite sprite)
		{
			return default(float);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2DD224", Offset = "0x2DD224", VA = "0x2DD224")]
		private Matrix4x4 WorldToMask()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2D9DF0", Offset = "0x2D9DF0", VA = "0x2D9DF0")]
		private Vector4 LocalMaskRect(Vector4 border)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2DCFF8", Offset = "0x2DCFF8", VA = "0x2DCFF8")]
		private Vector2 MaskRepeat(Sprite sprite, Vector4 centralPart)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2DA140", Offset = "0x2DA140", VA = "0x2DA140")]
		private void WarnIfDefaultShaderIsNotSet()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2DC8A8", Offset = "0x2DC8A8", VA = "0x2DC8A8")]
		private void WarnSpriteErrors(Errors errors)
		{
		}

		[Token(Token = "0x6000174")]
		private void Set<T>(ref T field, T value)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2D8F80", Offset = "0x2D8F80", VA = "0x2D8F80")]
		private void SetShader(ref Shader field, Shader value, bool warnIfNotSet = true)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2DD638", Offset = "0x2DD638", VA = "0x2DD638")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0504", Offset = "0x1F0504")]
		private void <SoftMask>m__0(Material m)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2DDB28", Offset = "0x2DDB28", VA = "0x2DDB28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0514", Offset = "0x1F0514")]
		private static void <InvalidateChildren>m__1(SoftMaskable x)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2DDC14", Offset = "0x2DDC14", VA = "0x2DDC14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0524", Offset = "0x1F0524")]
		private static void <NotifyChildrenThatMaskMightChanged>m__2(SoftMaskable x)
		{
		}
	}
	[Token(Token = "0x200003E")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1F0564", Offset = "0x1F0564")]
	public class SoftMaskable : UIBehaviour, IMaterialModifier
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private ISoftMask _mask;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Graphic _graphic;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Material _replacement;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _affectedByMask;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _destroyed;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F05BC", Offset = "0x1F05BC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1F05BC", Offset = "0x1F05BC")]
		private bool <shaderIsNotSupported>k__BackingField;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ISoftMask> s_softMasks;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static List<Canvas> s_canvases;

		[Token(Token = "0x1700003A")]
		public bool shaderIsNotSupported
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x2DE600", Offset = "0x2DE600", VA = "0x2DE600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F05F0", Offset = "0x1F05F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x2DF3A8", Offset = "0x2DF3A8", VA = "0x2DF3A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0600", Offset = "0x1F0600")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool isMaskingEnabled
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x2DF3B0", Offset = "0x2DF3B0", VA = "0x2DF3B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public ISoftMask mask
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x2DE5F8", Offset = "0x2DE5F8", VA = "0x2DE5F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x2DF52C", Offset = "0x2DF52C", VA = "0x2DF52C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		private Graphic graphic
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x2DFAE8", Offset = "0x2DFAE8", VA = "0x2DFAE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private Material replacement
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x2DF940", Offset = "0x2DF940", VA = "0x2DF940")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x2DF640", Offset = "0x2DF640", VA = "0x2DF640")]
			set
			{
			}
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2DF3A0", Offset = "0x2DF3A0", VA = "0x2DF3A0")]
		public SoftMaskable()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2DF7B8", Offset = "0x2DF7B8", VA = "0x2DF7B8", Slot = "17")]
		public Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2DDB4C", Offset = "0x2DDB4C", VA = "0x2DDB4C")]
		public void Invalidate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2DDC48", Offset = "0x2DDC48", VA = "0x2DDC48")]
		public void MaskMightChanged()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2DFD20", Offset = "0x2DFD20", VA = "0x2DFD20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2DFD48", Offset = "0x2DFD48", VA = "0x2DFD48", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2DFE60", Offset = "0x2DFE60", VA = "0x2DFE60", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2DFE84", Offset = "0x2DFE84", VA = "0x2DFE84", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2DFEA4", Offset = "0x2DFEA4", VA = "0x2DFEA4", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2DFEC4", Offset = "0x2DFEC4", VA = "0x2DFEC4", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2DFEE4", Offset = "0x2DFEE4", VA = "0x2DFEE4")]
		private void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2DFD78", Offset = "0x2DFD78", VA = "0x2DFD78")]
		private void RequestChildTransformUpdate()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2DFB9C", Offset = "0x2DFB9C", VA = "0x2DFB9C")]
		private bool FindMaskOrDie()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2DFEE8", Offset = "0x2DFEE8", VA = "0x2DFEE8")]
		private static ISoftMask NearestMask(Transform transform, out bool processedByThisMask, bool enabledOnly = true)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2E0094", Offset = "0x2E0094", VA = "0x2E0094")]
		private static ISoftMask GetISoftMask(Transform current, bool shouldBeEnabled = true)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2E0264", Offset = "0x2E0264", VA = "0x2E0264")]
		private static bool IsOverridingSortingCanvas(Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		private static T GetComponent<T>(Component component, List<T> cachedList) where T : class
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2DF948", Offset = "0x2DF948", VA = "0x2DF948")]
		private void SetShaderNotSupported(Material material)
		{
		}
	}
}
namespace SoftMasking.TextMeshPro
{
	[Token(Token = "0x200003F")]
	[GlobalMaterialReplacer]
	public class MaterialReplacer : IMaterialReplacer
	{
		[Token(Token = "0x1700003F")]
		public int order
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x2E045C", Offset = "0x2E045C", VA = "0x2E045C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2E0454", Offset = "0x2E0454", VA = "0x2E0454")]
		public MaterialReplacer()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2E0464", Offset = "0x2E0464", VA = "0x2E0464", Slot = "5")]
		public Material Replace(Material material)
		{
			return null;
		}
	}
}
[Token(Token = "0x2000040")]
public abstract class EffectBase : MonoBehaviour
{
	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2D44B4", Offset = "0x2D44B4", VA = "0x2D44B4")]
	protected EffectBase()
	{
	}

	[Token(Token = "0x60001C1")]
	public void EnsureArray<T>(ref T[] array, int size, [Optional] T initialValue)
	{
	}

	[Token(Token = "0x60001C2")]
	public void EnsureArray<T>(ref T[,] array, int size0, int size1, [Optional] T defaultValue)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x2D44BC", Offset = "0x2D44BC", VA = "0x2D44BC")]
	public void EnsureMaterial(ref Material material, Shader shader)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x2D46F4", Offset = "0x2D46F4", VA = "0x2D46F4")]
	public void EnsureDepthTexture(Camera camera)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x2D4768", Offset = "0x2D4768", VA = "0x2D4768")]
	public void EnsureKeyword(Material material, string name, bool enabled)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x2D47D4", Offset = "0x2D47D4", VA = "0x2D47D4")]
	public bool EnsureRenderTarget(ref RenderTexture rt, int width, int height, RenderTextureFormat format, FilterMode filterMode, int depthBits = 0, int antiAliasing = 1)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x2D4A24", Offset = "0x2D4A24", VA = "0x2D4A24")]
	public void ReleaseRenderTarget(ref RenderTexture rt)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x2D4AD4", Offset = "0x2D4AD4", VA = "0x2D4AD4")]
	public void DrawFullscreenQuad()
	{
	}
}
[Token(Token = "0x2000041")]
public static class Vector2Extension
{
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xB79E0C", Offset = "0xB79E0C", VA = "0xB79E0C")]
	public static float SignedAngle(this Vector2 v1, Vector2 v2)
	{
		return default(float);
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xB79FD8", Offset = "0xB79FD8", VA = "0xB79FD8")]
	public static Vector2 Rotate(this Vector2 v, float theta)
	{
		return default(Vector2);
	}
}
[Token(Token = "0x2000042")]
public static class Vector3Extension
{
	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xB7A0C0", Offset = "0xB7A0C0", VA = "0xB7A0C0")]
	public static Vector3 WithX(this Vector3 v, float x)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xB7A0FC", Offset = "0xB7A0FC", VA = "0xB7A0FC")]
	public static Vector3 WithY(this Vector3 v, float y)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xB7A138", Offset = "0xB7A138", VA = "0xB7A138")]
	public static Vector3 WithZ(this Vector3 v, float z)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000043")]
public static class Matrix4x4Extension
{
	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x2CBD14", Offset = "0x2CBD14", VA = "0x2CBD14")]
	public static Matrix4x4 GetPerspectiveProjection(float left, float right, float bottom, float top, float near, float far)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x2CBADC", Offset = "0x2CBADC", VA = "0x2CBADC")]
	public static Matrix4x4 GetOrthographicProjection(float left, float right, float bottom, float top, float near, float far)
	{
		return default(Matrix4x4);
	}
}
[Token(Token = "0x2000044")]
public static class CameraExtension
{
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x2CB2B4", Offset = "0x2CB2B4", VA = "0x2CB2B4")]
	public static Vector4 GetProjectionExtents(this Camera camera)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x2CB2D8", Offset = "0x2CB2D8", VA = "0x2CB2D8")]
	public static Vector4 GetProjectionExtents(this Camera camera, float texelOffsetX, float texelOffsetY)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x2CB534", Offset = "0x2CB534", VA = "0x2CB534")]
	public static Vector4 GetProjectionExtents(this Camera camera, Camera.StereoscopicEye eye)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x2CB558", Offset = "0x2CB558", VA = "0x2CB558")]
	public static Vector4 GetProjectionExtents(this Camera camera, Camera.StereoscopicEye eye, float texelOffsetX, float texelOffsetY)
	{
		return default(Vector4);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x2CB8D8", Offset = "0x2CB8D8", VA = "0x2CB8D8")]
	public static Matrix4x4 GetProjectionMatrix(this Camera camera)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x2CB8FC", Offset = "0x2CB8FC", VA = "0x2CB8FC")]
	public static Matrix4x4 GetProjectionMatrix(this Camera camera, float texelOffsetX, float texelOffsetY)
	{
		return default(Matrix4x4);
	}
}
[Token(Token = "0x2000045")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F0700", Offset = "0x1F0700")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1F0700", Offset = "0x1F0700")]
public class FrustumJitter : MonoBehaviour
{
	[Token(Token = "0x2000046")]
	public enum Pattern
	{
		[Token(Token = "0x40000E8")]
		Still,
		[Token(Token = "0x40000E9")]
		Uniform2,
		[Token(Token = "0x40000EA")]
		Uniform4,
		[Token(Token = "0x40000EB")]
		Uniform4_Helix,
		[Token(Token = "0x40000EC")]
		Uniform4_DoubleHelix,
		[Token(Token = "0x40000ED")]
		SkewButterfly,
		[Token(Token = "0x40000EE")]
		Rotated4,
		[Token(Token = "0x40000EF")]
		Rotated4_Helix,
		[Token(Token = "0x40000F0")]
		Rotated4_Helix2,
		[Token(Token = "0x40000F1")]
		Poisson10,
		[Token(Token = "0x40000F2")]
		Pentagram,
		[Token(Token = "0x40000F3")]
		Halton_2_3_X8,
		[Token(Token = "0x40000F4")]
		Halton_2_3_X16,
		[Token(Token = "0x40000F5")]
		Halton_2_3_X32,
		[Token(Token = "0x40000F6")]
		Halton_2_3_X256,
		[Token(Token = "0x40000F7")]
		MotionPerp2
	}

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float[] points_Still;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static float[] points_Uniform2;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static float[] points_Uniform4;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static float[] points_Uniform4_Helix;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static float[] points_Uniform4_DoubleHelix;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static float[] points_SkewButterfly;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float[] points_Rotated4;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static float[] points_Rotated4_Helix;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static float[] points_Rotated4_Helix2;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static float[] points_Poisson10;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static float[] points_Pentagram;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static float[] points_Halton_2_3_x8;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static float[] points_Halton_2_3_x16;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static float[] points_Halton_2_3_x32;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static float[] points_Halton_2_3_x256;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static float[] points_MotionPerp2;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Camera _camera;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Vector3 focalMotionPos;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 focalMotionDir;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Pattern pattern;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float patternScale;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 activeSample;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int activeIndex;

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x2D50E0", Offset = "0x2D50E0", VA = "0x2D50E0")]
	static FrustumJitter()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2D5A80", Offset = "0x2D5A80", VA = "0x2D5A80")]
	public FrustumJitter()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x2D57D0", Offset = "0x2D57D0", VA = "0x2D57D0")]
	private static void TransformPattern(float[] seq, float theta, float scale)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2D5BAC", Offset = "0x2D5BAC", VA = "0x2D5BAC")]
	private static float HaltonSeq(int prime, int index = 1)
	{
		return default(float);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x2D5950", Offset = "0x2D5950", VA = "0x2D5950")]
	private static void InitializeHalton_2_3(float[] seq)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x2D5CA4", Offset = "0x2D5CA4", VA = "0x2D5CA4")]
	private static float[] AccessPointData(Pattern pattern)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x2D6250", Offset = "0x2D6250", VA = "0x2D6250")]
	public static int AccessLength(Pattern pattern)
	{
		return default(int);
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x2D62EC", Offset = "0x2D62EC", VA = "0x2D62EC")]
	public Vector2 Sample(Pattern pattern, int index)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x2D651C", Offset = "0x2D651C", VA = "0x2D651C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x2D6584", Offset = "0x2D6584", VA = "0x2D6584")]
	private void Clear()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x2D6640", Offset = "0x2D6640", VA = "0x2D6640")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x2D665C", Offset = "0x2D665C", VA = "0x2D665C")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x2D6F04", Offset = "0x2D6F04", VA = "0x2D6F04")]
	private void OnDisable()
	{
	}
}
[Token(Token = "0x2000047")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F07B0", Offset = "0x1F07B0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1F07B0", Offset = "0x1F07B0")]
public class TemporalReprojection : EffectBase
{
	[Token(Token = "0x2000048")]
	public enum Neighborhood
	{
		[Token(Token = "0x400010E")]
		MinMax3x3,
		[Token(Token = "0x400010F")]
		MinMax3x3Rounded,
		[Token(Token = "0x4000110")]
		MinMax4TapVarying
	}

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static RenderBuffer[] mrt;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Camera _camera;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private FrustumJitter _frustumJitter;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private VelocityBuffer _velocityBuffer;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader reprojectionShader;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Material reprojectionMaterial;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderTexture[,] reprojectionBuffer;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int[] reprojectionIndex;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Neighborhood neighborhood;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool unjitterColorSamples;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool unjitterNeighborhood;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool unjitterReprojection;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	public bool useYCoCg;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool useClipping;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool useDilation;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool useMotionBlur;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool useOptimizations;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1F08A4", Offset = "0x1F08A4")]
	public float feedbackMin;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1F08BC", Offset = "0x1F08BC")]
	public float feedbackMax;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float motionBlurStrength;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool motionBlurIgnoreFF;

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x2E06EC", Offset = "0x2E06EC", VA = "0x2E06EC")]
	public TemporalReprojection()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x2E07E8", Offset = "0x2E07E8", VA = "0x2E07E8")]
	private void Reset()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2E0888", Offset = "0x2E0888", VA = "0x2E0888")]
	private void Clear()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x2E0968", Offset = "0x2E0968", VA = "0x2E0968")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x2E0984", Offset = "0x2E0984", VA = "0x2E0984")]
	private void Resolve(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x2E1834", Offset = "0x2E1834", VA = "0x2E1834")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x2E1A60", Offset = "0x2E1A60", VA = "0x2E1A60")]
	private void OnApplicationQuit()
	{
	}
}
[Token(Token = "0x2000049")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x1F08D4", Offset = "0x1F08D4")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1F08D4", Offset = "0x1F08D4")]
public class VelocityBuffer : EffectBase
{
	[Token(Token = "0x200004A")]
	public enum NeighborMaxSupport
	{
		[Token(Token = "0x4000124")]
		TileSize10,
		[Token(Token = "0x4000125")]
		TileSize20,
		[Token(Token = "0x4000126")]
		TileSize40
	}

	[Token(Token = "0x4000111")]
	private const RenderTextureFormat velocityFormat = RenderTextureFormat.RGFloat;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Camera _camera;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private FrustumJitter _frustumJitter;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Shader velocityShader;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material velocityMaterial;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private RenderTexture[] velocityBuffer;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderTexture[] velocityNeighborMax;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool[] paramInitialized;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector4[] paramProjectionExtents;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Matrix4x4[] paramCurrV;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Matrix4x4[] paramCurrVP;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Matrix4x4[] paramPrevVP;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Matrix4x4[] paramPrevVP_NoFlip;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int activeEyeIndex;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool neighborMaxGen;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public NeighborMaxSupport neighborMaxSupport;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float timeScaleNextFrame;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F09A0", Offset = "0x1F09A0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1F09A0", Offset = "0x1F09A0")]
	private float <timeScale>k__BackingField;

	[Token(Token = "0x17000040")]
	public RenderTexture activeVelocityBuffer
	{
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xB7A18C", Offset = "0xB7A18C", VA = "0xB7A18C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public RenderTexture activeVelocityNeighborMax
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xB7A1DC", Offset = "0xB7A1DC", VA = "0xB7A1DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000042")]
	public float timeScale
	{
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xB7A22C", Offset = "0xB7A22C", VA = "0xB7A22C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F09D4", Offset = "0x1F09D4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xB7A234", Offset = "0xB7A234", VA = "0xB7A234")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F09E4", Offset = "0x1F09E4")]
		private set
		{
		}
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xB7A174", Offset = "0xB7A174", VA = "0xB7A174")]
	public VelocityBuffer()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xB7A23C", Offset = "0xB7A23C", VA = "0xB7A23C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xB7A2C0", Offset = "0xB7A2C0", VA = "0xB7A2C0")]
	private void Clear()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xB7A3A0", Offset = "0xB7A3A0", VA = "0xB7A3A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xB7A3BC", Offset = "0xB7A3BC", VA = "0xB7A3BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xB7A3DC", Offset = "0xB7A3DC", VA = "0xB7A3DC")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xB7A3E8", Offset = "0xB7A3E8", VA = "0xB7A3E8")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xB7C9D0", Offset = "0xB7C9D0", VA = "0xB7C9D0")]
	private void OnApplicationQuit()
	{
	}
}
[Token(Token = "0x200004B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1F09F4", Offset = "0x1F09F4")]
public class VelocityBufferTag : MonoBehaviour
{
	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<Vector3> temporaryVertexStorage;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static List<VelocityBufferTag> activeObjects;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Transform _transform;

	[NonSerialized]
	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public SkinnedMeshRenderer meshSmr;

	[NonSerialized]
	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public bool meshSmrActive;

	[NonSerialized]
	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Mesh mesh;

	[NonSerialized]
	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public Matrix4x4 localToWorldPrev;

	[NonSerialized]
	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[HideInInspector]
	public Matrix4x4 localToWorldCurr;

	[Token(Token = "0x400012F")]
	private const int framesNotRenderedSleepThreshold = 60;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int framesNotRendered;

	[Token(Token = "0x17000043")]
	public bool rendering
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xB7C9BC", Offset = "0xB7C9BC", VA = "0xB7C9BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xB7CAB8", Offset = "0xB7CAB8", VA = "0xB7CAB8")]
	public VelocityBufferTag()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xB7CAC8", Offset = "0xB7CAC8", VA = "0xB7CAC8")]
	private void Reset()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xB7CCD0", Offset = "0xB7CCD0", VA = "0xB7CCD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xB7CCD4", Offset = "0xB7CCD4", VA = "0xB7CCD4")]
	private void TagUpdate(bool restart)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xB7D11C", Offset = "0xB7D11C", VA = "0xB7D11C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xB7D138", Offset = "0xB7D138", VA = "0xB7D138")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xB7D20C", Offset = "0xB7D20C", VA = "0xB7D20C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xB7D2C4", Offset = "0xB7D2C4", VA = "0xB7D2C4")]
	private void OnDisable()
	{
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x200004C")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0A88", Offset = "0x1F0A88")]
		private sealed class <Start>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int <i>__1;

			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Benchmark01 $this;

			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000053")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000315")]
				[Address(RVA = "0x2E2654", Offset = "0x2E2654", VA = "0x2E2654", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000054")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000316")]
				[Address(RVA = "0x2E265C", Offset = "0x2E265C", VA = "0x2E265C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x2E1CC0", Offset = "0x2E1CC0", VA = "0x2E1CC0")]
			[DebuggerHidden]
			public <Start>c__Iterator0()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x2E1CC8", Offset = "0x2E1CC8", VA = "0x2E1CC8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x2E2664", Offset = "0x2E2664", VA = "0x2E2664", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2E2678", Offset = "0x2E2678", VA = "0x2E2678", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int BenchmarkType;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Font TextMeshFont;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMesh m_textMesh;

		[Token(Token = "0x4000137")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x4000138")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Material m_material01;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material m_material02;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2E1C38", Offset = "0x2E1C38", VA = "0x2E1C38")]
		public Benchmark01()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2E1C40", Offset = "0x2E1C40", VA = "0x2E1C40")]
		[DebuggerHidden]
		private IEnumerator Start()
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0AF8", Offset = "0x1F0AF8")]
		private sealed class <Start>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int <i>__1;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Benchmark01_UGUI $this;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000055")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600031B")]
				[Address(RVA = "0x2E2F80", Offset = "0x2E2F80", VA = "0x2E2F80", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000056")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600031C")]
				[Address(RVA = "0x2E2F88", Offset = "0x2E2F88", VA = "0x2E2F88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x2E2784", Offset = "0x2E2784", VA = "0x2E2784")]
			[DebuggerHidden]
			public <Start>c__Iterator0()
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x2E278C", Offset = "0x2E278C", VA = "0x2E278C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x2E2F90", Offset = "0x2E2F90", VA = "0x2E2F90", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x2E2FA4", Offset = "0x2E2FA4", VA = "0x2E2FA4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int BenchmarkType;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Canvas canvas;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Font TextMeshFont;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text m_textMesh;

		[Token(Token = "0x4000141")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x4000142")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Material m_material01;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material m_material02;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2E26FC", Offset = "0x2E26FC", VA = "0x2E26FC")]
		public Benchmark01_UGUI()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2E2704", Offset = "0x2E2704", VA = "0x2E2704")]
		[DebuggerHidden]
		private IEnumerator Start()
		{
			return null;
		}
	}
	[Token(Token = "0x200004E")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int SpawnType;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int NumberOfNPC;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2E3028", Offset = "0x2E3028", VA = "0x2E3028")]
		public Benchmark02()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2E3038", Offset = "0x2E3038", VA = "0x2E3038")]
		private void Start()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int SpawnType;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int NumberOfNPC;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Font TheFont;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2E3A30", Offset = "0x2E3A30", VA = "0x2E3A30")]
		public Benchmark03()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2E3A40", Offset = "0x2E3A40", VA = "0x2E3A40")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2E3A44", Offset = "0x2E3A44", VA = "0x2E3A44")]
		private void Start()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int SpawnType;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int MinPointSize;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int MaxPointSize;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Steps;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Transform m_Transform;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2E3E5C", Offset = "0x2E3E5C", VA = "0x2E3E5C")]
		public Benchmark04()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2E3E78", Offset = "0x2E3E78", VA = "0x2E3E78")]
		private void Start()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x2000052")]
		public enum CameraModes
		{
			[Token(Token = "0x400016A")]
			Follow,
			[Token(Token = "0x400016B")]
			Isometric,
			[Token(Token = "0x400016C")]
			Free
		}

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Transform cameraTransform;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform dummyTarget;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform CameraTarget;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FollowDistance;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MaxFollowDistance;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MinFollowDistance;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ElevationAngle;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MaxElevationAngle;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float MinElevationAngle;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float OrbitalAngle;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CameraModes CameraMode;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool MovementSmoothing;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool RotationSmoothing;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool previousSmoothing;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float MovementSmoothingValue;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float RotationSmoothingValue;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MoveSensitivity;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 currentVelocity;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 desiredPosition;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float mouseX;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float mouseY;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 moveVector;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float mouseWheel;

		[Token(Token = "0x4000167")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x4000168")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2E43F4", Offset = "0x2E43F4", VA = "0x2E43F4")]
		public CameraController()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2E44F0", Offset = "0x2E44F0", VA = "0x2E44F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2E45DC", Offset = "0x2E45DC", VA = "0x2E45DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2E46C8", Offset = "0x2E46C8", VA = "0x2E46C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2E4CF4", Offset = "0x2E4CF4", VA = "0x2E4CF4")]
		private void GetPlayerInput()
		{
		}
	}
}
[Token(Token = "0x2000053")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public TMP_InputField TMP_ChatInput;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TMP_Text TMP_ChatOutput;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x2CBF44", Offset = "0x2CBF44", VA = "0x2CBF44")]
	public ChatController()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x2CBF4C", Offset = "0x2CBF4C", VA = "0x2CBF4C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x2CC028", Offset = "0x2CC028", VA = "0x2CC028")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x2CC104", Offset = "0x2CC104", VA = "0x2CC104")]
	private void AddToChatOutput(string newText)
	{
	}
}
[Token(Token = "0x2000054")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0B68", Offset = "0x1F0B68")]
	private sealed class <Start>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Matrix4x4 <matrix>__0;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal EnvMapAnimator $this;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal object $current;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal bool $disposing;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal int $PC;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x2D5038", Offset = "0x2D5038", VA = "0x2D5038", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x2D5040", Offset = "0x2D5040", VA = "0x2D5040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2D4D04", Offset = "0x2D4D04", VA = "0x2D4D04")]
		[DebuggerHidden]
		public <Start>c__Iterator0()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2D4D0C", Offset = "0x2D4D0C", VA = "0x2D4D0C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2D5048", Offset = "0x2D5048", VA = "0x2D5048", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2D505C", Offset = "0x2D505C", VA = "0x2D505C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Material m_material;

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x2D4BEC", Offset = "0x2D4BEC", VA = "0x2D4BEC")]
	public EnvMapAnimator()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x2D4BF4", Offset = "0x2D4BF4", VA = "0x2D4BF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x2D4C84", Offset = "0x2D4C84", VA = "0x2D4C84")]
	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x2000055")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x2000056")]
		public enum MotionType
		{
			[Token(Token = "0x400017E")]
			Rotation,
			[Token(Token = "0x400017F")]
			BackAndForth,
			[Token(Token = "0x4000180")]
			Translation
		}

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float SpinSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int RotationRange;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Transform m_transform;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_time;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color32 m_lightColor;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int frames;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MotionType Motion;

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2E5A98", Offset = "0x2E5A98", VA = "0x2E5A98")]
		public ObjectSpin()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2E5AB4", Offset = "0x2E5AB4", VA = "0x2E5AB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2E5C74", Offset = "0x2E5C74", VA = "0x2E5C74")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0BD8", Offset = "0x1F0BD8")]
		private sealed class <AnimateProperties>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <glowPower>__1;

			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal ShaderPropAnimator $this;

			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000059")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000327")]
				[Address(RVA = "0x2E62BC", Offset = "0x2E62BC", VA = "0x2E62BC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000328")]
				[Address(RVA = "0x2E62C4", Offset = "0x2E62C4", VA = "0x2E62C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x2E6094", Offset = "0x2E6094", VA = "0x2E6094")]
			[DebuggerHidden]
			public <AnimateProperties>c__Iterator0()
			{
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x2E609C", Offset = "0x2E609C", VA = "0x2E609C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x2E62CC", Offset = "0x2E62CC", VA = "0x2E62CC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x2E62E0", Offset = "0x2E62E0", VA = "0x2E62E0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Renderer m_Renderer;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Material m_Material;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_frame;

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2E5F60", Offset = "0x2E5F60", VA = "0x2E5F60")]
		public ShaderPropAnimator()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2E5F68", Offset = "0x2E5F68", VA = "0x2E5F68")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2E5FF0", Offset = "0x2E5FF0", VA = "0x2E5FF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2E6014", Offset = "0x2E6014", VA = "0x2E6014")]
		[DebuggerHidden]
		private IEnumerator AnimateProperties()
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000186")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_frame;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2E6364", Offset = "0x2E6364", VA = "0x2E6364")]
		public SimpleScript()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2E636C", Offset = "0x2E636C", VA = "0x2E636C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2E647C", Offset = "0x2E647C", VA = "0x2E647C")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0C48", Offset = "0x1F0C48")]
		private sealed class <WarpText>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <old_CurveScale>__0;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal float <old_ShearValue>__0;

			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal AnimationCurve <old_curve>__0;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal TMP_TextInfo <textInfo>__1;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int <characterCount>__1;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal float <boundsMinX>__1;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal float <boundsMaxX>__1;

			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal Vector3[] <vertices>__2;

			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal SkewTextExample $this;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			internal object $current;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal bool $disposing;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			internal int $PC;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600032D")]
				[Address(RVA = "0x2E7FD0", Offset = "0x2E7FD0", VA = "0x2E7FD0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600032E")]
				[Address(RVA = "0x2E7FD8", Offset = "0x2E7FD8", VA = "0x2E7FD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x2E6954", Offset = "0x2E6954", VA = "0x2E6954")]
			[DebuggerHidden]
			public <WarpText>c__Iterator0()
			{
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x2E695C", Offset = "0x2E695C", VA = "0x2E695C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x2E7FE0", Offset = "0x2E7FE0", VA = "0x2E7FE0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x2E7FF4", Offset = "0x2E7FF4", VA = "0x2E7FF4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float CurveScale;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float ShearAmount;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2E6534", Offset = "0x2E6534", VA = "0x2E6534")]
		public SkewTextExample()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2E6784", Offset = "0x2E6784", VA = "0x2E6784")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2E6808", Offset = "0x2E6808", VA = "0x2E6808")]
		private void Start()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2E68AC", Offset = "0x2E68AC", VA = "0x2E68AC")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2E682C", Offset = "0x2E682C", VA = "0x2E682C")]
		[DebuggerHidden]
		private IEnumerator WarpText()
		{
			return null;
		}
	}
	[Token(Token = "0x200005A")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0CB8", Offset = "0x1F0CB8")]
		private sealed class <Start>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int <totalVisibleCharacters>__0;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int <counter>__0;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <visibleCount>__0;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal TeleType $this;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal object $current;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal bool $disposing;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int $PC;

			[Token(Token = "0x1700005D")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000333")]
				[Address(RVA = "0x2E8580", Offset = "0x2E8580", VA = "0x2E8580", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000334")]
				[Address(RVA = "0x2E8588", Offset = "0x2E8588", VA = "0x2E8588", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x2E8244", Offset = "0x2E8244", VA = "0x2E8244")]
			[DebuggerHidden]
			public <Start>c__Iterator0()
			{
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x2E824C", Offset = "0x2E824C", VA = "0x2E824C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x2E8590", Offset = "0x2E8590", VA = "0x2E8590", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x2E85A4", Offset = "0x2E85A4", VA = "0x2E85A4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string label01;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string label02;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2E8078", Offset = "0x2E8078", VA = "0x2E8078")]
		public TeleType()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2E80F8", Offset = "0x2E80F8", VA = "0x2E80F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2E81C4", Offset = "0x2E81C4", VA = "0x2E81C4")]
		[DebuggerHidden]
		private IEnumerator Start()
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0D38", Offset = "0x1F0D38")]
		private sealed class <RevealCharacters>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_Text textComponent;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <totalVisibleCharacters>__0;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <visibleCount>__0;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextConsoleSimulator $this;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal object $current;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int $PC;

			[Token(Token = "0x1700005F")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000339")]
				[Address(RVA = "0x2E8BE4", Offset = "0x2E8BE4", VA = "0x2E8BE4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000060")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600033A")]
				[Address(RVA = "0x2E8BEC", Offset = "0x2E8BEC", VA = "0x2E8BEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x2E8980", Offset = "0x2E8980", VA = "0x2E8980")]
			[DebuggerHidden]
			public <RevealCharacters>c__Iterator0()
			{
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x2E8A10", Offset = "0x2E8A10", VA = "0x2E8A10", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x2E8BF4", Offset = "0x2E8BF4", VA = "0x2E8BF4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x2E8C08", Offset = "0x2E8C08", VA = "0x2E8C08", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0D98", Offset = "0x1F0D98")]
		private sealed class <RevealWords>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_Text textComponent;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int <totalWordCount>__0;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <totalVisibleCharacters>__0;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <counter>__0;

			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int <currentWord>__0;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int <visibleCount>__0;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal object $current;

			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool $disposing;

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int $PC;

			[Token(Token = "0x17000061")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0x2E8F30", Offset = "0x2E8F30", VA = "0x2E8F30", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000062")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000340")]
				[Address(RVA = "0x2E8F38", Offset = "0x2E8F38", VA = "0x2E8F38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x2E8A08", Offset = "0x2E8A08", VA = "0x2E8A08")]
			[DebuggerHidden]
			public <RevealWords>c__Iterator1()
			{
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x2E8C8C", Offset = "0x2E8C8C", VA = "0x2E8C8C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0x2E8F40", Offset = "0x2E8F40", VA = "0x2E8F40", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x2E8F54", Offset = "0x2E8F54", VA = "0x2E8F54", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool hasTextChanged;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2E8628", Offset = "0x2E8628", VA = "0x2E8628")]
		public TextConsoleSimulator()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2E8630", Offset = "0x2E8630", VA = "0x2E8630")]
		private void Awake()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2E86B4", Offset = "0x2E86B4", VA = "0x2E86B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2E8774", Offset = "0x2E8774", VA = "0x2E8774")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2E8874", Offset = "0x2E8874", VA = "0x2E8874")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2E8974", Offset = "0x2E8974", VA = "0x2E8974")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2E86DC", Offset = "0x2E86DC", VA = "0x2E86DC")]
		[DebuggerHidden]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2E8988", Offset = "0x2E8988", VA = "0x2E8988")]
		[DebuggerHidden]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}
	}
	[Token(Token = "0x200005C")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0E18", Offset = "0x1F0E18")]
		private sealed class <DisplayTextMeshProFloatingText>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <CountDuration>__0;

			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal float <starting_Count>__0;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal float <current_Count>__0;

			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Vector3 <start_pos>__0;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Color32 <start_color>__0;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal float <alpha>__0;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int <int_counter>__0;

			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal float <fadeDuration>__0;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal TextMeshProFloatingText $this;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal object $current;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal bool $disposing;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal int $PC;

			[Token(Token = "0x17000063")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000345")]
				[Address(RVA = "0x2EAA6C", Offset = "0x2EAA6C", VA = "0x2EAA6C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000346")]
				[Address(RVA = "0x2EAA74", Offset = "0x2EAA74", VA = "0x2EAA74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x2E993C", Offset = "0x2E993C", VA = "0x2E993C")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>c__Iterator0()
			{
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x2EA228", Offset = "0x2EA228", VA = "0x2EA228", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x2EAA7C", Offset = "0x2EAA7C", VA = "0x2EAA7C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x2EAA90", Offset = "0x2EAA90", VA = "0x2EAA90", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0E78", Offset = "0x1F0E78")]
		private sealed class <DisplayTextMeshFloatingText>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <CountDuration>__0;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal float <starting_Count>__0;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal float <current_Count>__0;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Vector3 <start_pos>__0;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Color32 <start_color>__0;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal float <alpha>__0;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int <int_counter>__0;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal float <fadeDuration>__0;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal TextMeshProFloatingText $this;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal object $current;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal bool $disposing;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal int $PC;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600034B")]
				[Address(RVA = "0x2EA180", Offset = "0x2EA180", VA = "0x2EA180", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600034C")]
				[Address(RVA = "0x2EA188", Offset = "0x2EA188", VA = "0x2EA188", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000349")]
			[Address(RVA = "0x2E9944", Offset = "0x2E9944", VA = "0x2E9944")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>c__Iterator1()
			{
			}

			[Token(Token = "0x600034A")]
			[Address(RVA = "0x2E994C", Offset = "0x2E994C", VA = "0x2E994C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x2EA190", Offset = "0x2EA190", VA = "0x2EA190", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x2EA1A4", Offset = "0x2EA1A4", VA = "0x2EA1A4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Font TheFont;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GameObject m_floatingText;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMesh m_textMesh;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Transform m_transform;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Transform m_cameraTransform;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 lastPOS;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion lastRotation;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int SpawnType;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2E8FD8", Offset = "0x2E8FD8", VA = "0x2E8FD8")]
		public TextMeshProFloatingText()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2E90CC", Offset = "0x2E90CC", VA = "0x2E90CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2E91DC", Offset = "0x2E91DC", VA = "0x2E91DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2E983C", Offset = "0x2E983C", VA = "0x2E983C")]
		[DebuggerHidden]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2E98BC", Offset = "0x2E98BC", VA = "0x2E98BC")]
		[DebuggerHidden]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}
	}
	[Token(Token = "0x200005D")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int SpawnType;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int NumberOfNPC;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Font TheFont;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2EAB14", Offset = "0x2EAB14", VA = "0x2EAB14")]
		public TextMeshSpawner()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2EAB24", Offset = "0x2EAB24", VA = "0x2EAB24")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2EAB28", Offset = "0x2EAB28", VA = "0x2EAB28")]
		private void Start()
		{
		}
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200005E")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xB6F290", Offset = "0xB6F290", VA = "0xB6F290")]
		public TMP_DigitValidator()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xB6F298", Offset = "0xB6F298", VA = "0xB6F298", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x200005F")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x2000060")]
		public enum objectType
		{
			[Token(Token = "0x40001A5")]
			TextMeshPro,
			[Token(Token = "0x40001A6")]
			TextMeshProUGUI
		}

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public objectType ObjectType;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStatic;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TMP_Text m_text;

		[Token(Token = "0x40001A2")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int count;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2EAFF8", Offset = "0x2EAFF8", VA = "0x2EAFF8")]
		public TMP_ExampleScript_01()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2EB000", Offset = "0x2EB000", VA = "0x2EB000")]
		private void Awake()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2EB2BC", Offset = "0x2EB2BC", VA = "0x2EB2BC")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000062")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40001B2")]
			TopLeft,
			[Token(Token = "0x40001B3")]
			BottomLeft,
			[Token(Token = "0x40001B4")]
			TopRight,
			[Token(Token = "0x40001B5")]
			BottomRight
		}

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float UpdateInterval;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_LastInterval;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_Frames;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private string htmlColorTag;

		[Token(Token = "0x40001AC")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Camera m_camera;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2EB378", Offset = "0x2EB378", VA = "0x2EB378")]
		public TMP_FrameRateCounter()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2EB394", Offset = "0x2EB394", VA = "0x2EB394")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2EBA20", Offset = "0x2EBA20", VA = "0x2EBA20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2EBA48", Offset = "0x2EBA48", VA = "0x2EBA48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2EB654", Offset = "0x2EB654", VA = "0x2EB654")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000063")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xB6F2BC", Offset = "0xB6F2BC", VA = "0xB6F2BC")]
		public TMP_PhoneNumberValidator()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xB6F2C4", Offset = "0xB6F2C4", VA = "0xB6F2C4", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x2000064")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2EBC40", Offset = "0x2EBC40", VA = "0x2EBC40")]
		public TMP_TextEventCheck()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2EBC48", Offset = "0x2EBC48", VA = "0x2EBC48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2EBFB0", Offset = "0x2EBFB0", VA = "0x2EBFB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2EC318", Offset = "0x2EC318", VA = "0x2EC318")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2EC61C", Offset = "0x2EC61C", VA = "0x2EC61C")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2EC920", Offset = "0x2EC920", VA = "0x2EC920")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2ECCD4", Offset = "0x2ECCD4", VA = "0x2ECCD4")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2ED088", Offset = "0x2ED088", VA = "0x2ED088")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}
	}
}
namespace TMPro
{
	[Token(Token = "0x2000065")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Serializable]
		[Token(Token = "0x2000066")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0xB6FD2C", Offset = "0xB6FD2C", VA = "0xB6FD2C")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000067")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xB6FD90", Offset = "0xB6FD90", VA = "0xB6FD90")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000068")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xB6FDF4", Offset = "0xB6FDF4", VA = "0xB6FDF4")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000069")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xB6FE58", Offset = "0xB6FE58", VA = "0xB6FE58")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006A")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xB6FEBC", Offset = "0xB6FEBC", VA = "0xB6FEBC")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Camera m_Camera;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Canvas m_Canvas;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_lastLineIndex;

		[Token(Token = "0x17000044")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0xB6FF20", Offset = "0xB6FF20", VA = "0xB6FF20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0xB6FF28", Offset = "0xB6FF28", VA = "0xB6FF28")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0xB6FF30", Offset = "0xB6FF30", VA = "0xB6FF30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xB6FF38", Offset = "0xB6FF38", VA = "0xB6FF38")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0xB6FF40", Offset = "0xB6FF40", VA = "0xB6FF40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xB6FF48", Offset = "0xB6FF48", VA = "0xB6FF48")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xB6FF50", Offset = "0xB6FF50", VA = "0xB6FF50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xB6FF58", Offset = "0xB6FF58", VA = "0xB6FF58")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0xB6FF60", Offset = "0xB6FF60", VA = "0xB6FF60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xB6FF68", Offset = "0xB6FF68", VA = "0xB6FF68")]
			set
			{
			}
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xB6FC20", Offset = "0xB6FC20", VA = "0xB6FC20")]
		public TMP_TextEventHandler()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xB6FF70", Offset = "0xB6FF70", VA = "0xB6FF70")]
		private void Awake()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xB7014C", Offset = "0xB7014C", VA = "0xB7014C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xB70C10", Offset = "0xB70C10", VA = "0xB70C10", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xB70C14", Offset = "0xB70C14", VA = "0xB70C14", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xB70968", Offset = "0xB70968", VA = "0xB70968")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xB709E4", Offset = "0xB709E4", VA = "0xB709E4")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xB70A60", Offset = "0xB70A60", VA = "0xB70A60")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xB70AF0", Offset = "0xB70AF0", VA = "0xB70AF0")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xB70B80", Offset = "0xB70B80", VA = "0xB70B80")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x200006B")]
	[ExecuteInEditMode]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool ShowCharacters;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool ShowWords;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool ShowLinks;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public bool ShowLines;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool ShowMeshBounds;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool ShowTextBounds;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1F0F38", Offset = "0x1F0F38")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x1F0F38", Offset = "0x1F0F38")]
		public string ObjectStats;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Transform m_Transform;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2ED41C", Offset = "0x2ED41C", VA = "0x2ED41C")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Camera m_Camera;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool m_isHoveringObject;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_selectedLink;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_lastCharIndex;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_lastWordIndex;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2ED424", Offset = "0x2ED424", VA = "0x2ED424")]
		public TMP_TextSelector_A()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2ED43C", Offset = "0x2ED43C", VA = "0x2ED43C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2ED4F4", Offset = "0x2ED4F4", VA = "0x2ED4F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2EE474", Offset = "0x2EE474", VA = "0x2EE474", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2EE510", Offset = "0x2EE510", VA = "0x2EE510", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x40001D5")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x40001D6")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Canvas m_Canvas;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool isHoveringObject;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_selectedWord;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastIndex;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2EE5AC", Offset = "0x2EE5AC", VA = "0x2EE5AC")]
		public TMP_TextSelector_B()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2EE5C4", Offset = "0x2EE5C4", VA = "0x2EE5C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2EE7CC", Offset = "0x2EE7CC", VA = "0x2EE7CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2EE8CC", Offset = "0x2EE8CC", VA = "0x2EE8CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2EE9CC", Offset = "0x2EE9CC", VA = "0x2EE9CC")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2EEAA4", Offset = "0x2EEAA4", VA = "0x2EEAA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2F1644", Offset = "0x2F1644", VA = "0x2F1644", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2F1650", Offset = "0x2F1650", VA = "0x2F1650", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2F165C", Offset = "0x2F165C", VA = "0x2F165C", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2F1660", Offset = "0x2F1660", VA = "0x2F1660", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2F04F8", Offset = "0x2F04F8", VA = "0x2F04F8")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x200006F")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40001EA")]
			TopLeft,
			[Token(Token = "0x40001EB")]
			BottomLeft,
			[Token(Token = "0x40001EC")]
			TopRight,
			[Token(Token = "0x40001ED")]
			BottomRight
		}

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float UpdateInterval;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_LastInterval;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_Frames;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private string htmlColorTag;

		[Token(Token = "0x40001E5")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2F1664", Offset = "0x2F1664", VA = "0x2F1664")]
		public TMP_UiFrameRateCounter()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2F1680", Offset = "0x2F1680", VA = "0x2F1680")]
		private void Awake()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2F1D64", Offset = "0x2F1D64", VA = "0x2F1D64")]
		private void Start()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2F1D8C", Offset = "0x2F1D8C", VA = "0x2F1D8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2F18C0", Offset = "0x2F18C0", VA = "0x2F18C0")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x2000071")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40001F5")]
			TopLeft,
			[Token(Token = "0x40001F6")]
			BottomLeft,
			[Token(Token = "0x40001F7")]
			TopRight,
			[Token(Token = "0x40001F8")]
			BottomRight
		}

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40001EF")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TextContainer m_textContainer;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Camera m_camera;

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2F1F84", Offset = "0x2F1F84", VA = "0x2F1F84")]
		public TMPro_InstructionOverlay()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2F1F94", Offset = "0x2F1F94", VA = "0x2F1F94")]
		private void Awake()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2F2270", Offset = "0x2F2270", VA = "0x2F2270")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0F88", Offset = "0x1F0F88")]
		private sealed class <AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int <currentCharacter>__0;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Color32 <c0>__0;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <characterCount>__1;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int <materialIndex>__1;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Color32[] <newVertexColors>__1;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int <vertexIndex>__1;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal VertexColorCycler $this;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal object $current;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal bool $disposing;

			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int $PC;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000351")]
				[Address(RVA = "0x2F2A00", Offset = "0x2F2A00", VA = "0x2F2A00", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000352")]
				[Address(RVA = "0x2F2A08", Offset = "0x2F2A08", VA = "0x2F2A08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x2F2564", Offset = "0x2F2564", VA = "0x2F2564")]
			[DebuggerHidden]
			public <AnimateVertexColors>c__Iterator0()
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x2F256C", Offset = "0x2F256C", VA = "0x2F256C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x2F2A10", Offset = "0x2F2A10", VA = "0x2F2A10", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x2F2A24", Offset = "0x2F2A24", VA = "0x2F2A24", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2F2450", Offset = "0x2F2450", VA = "0x2F2450")]
		public VertexColorCycler()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2F2458", Offset = "0x2F2458", VA = "0x2F2458")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2F24C0", Offset = "0x2F24C0", VA = "0x2F24C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2F24E4", Offset = "0x2F24E4", VA = "0x2F24E4")]
		[DebuggerHidden]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
	[Token(Token = "0x2000073")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x2000074")]
		private struct VertexAnim
		{
			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F0FF8", Offset = "0x1F0FF8")]
		private sealed class <AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int <loopCount>__0;

			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal VertexAnim[] <vertexAnim>__0;

			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal TMP_MeshInfo[] <cachedMeshInfo>__0;

			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int <characterCount>__1;

			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal VertexJitter $this;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal object $current;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal bool $disposing;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal int $PC;

			[Token(Token = "0x17000069")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000357")]
				[Address(RVA = "0x2F3F94", Offset = "0x2F3F94", VA = "0x2F3F94", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000358")]
				[Address(RVA = "0x2F3F9C", Offset = "0x2F3F9C", VA = "0x2F3F9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x2F2E6C", Offset = "0x2F2E6C", VA = "0x2F2E6C")]
			[DebuggerHidden]
			public <AnimateVertexColors>c__Iterator0()
			{
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0x2F2E74", Offset = "0x2F2E74", VA = "0x2F2E74", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x2F3FA4", Offset = "0x2F3FA4", VA = "0x2F3FA4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x2F3FB8", Offset = "0x2F3FB8", VA = "0x2F3FB8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float AngleMultiplier;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float SpeedMultiplier;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float CurveScale;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool hasTextChanged;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2F2AA8", Offset = "0x2F2AA8", VA = "0x2F2AA8")]
		public VertexJitter()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2F2AC0", Offset = "0x2F2AC0", VA = "0x2F2AC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2F2B28", Offset = "0x2F2B28", VA = "0x2F2B28")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2F2C28", Offset = "0x2F2C28", VA = "0x2F2C28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2F2D28", Offset = "0x2F2D28", VA = "0x2F2D28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2F2DCC", Offset = "0x2F2DCC", VA = "0x2F2DCC")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2F2D4C", Offset = "0x2F2D4C", VA = "0x2F2D4C")]
		[DebuggerHidden]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
	[Token(Token = "0x2000075")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F1068", Offset = "0x1F1068")]
		private sealed class <AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Vector3[][] <copyOfVertices>__0;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <characterCount>__1;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <lineCount>__1;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal VertexShakeA $this;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal object $current;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal bool $disposing;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal int $PC;

			[Token(Token = "0x1700006B")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x2F5AC8", Offset = "0x2F5AC8", VA = "0x2F5AC8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600035E")]
				[Address(RVA = "0x2F5AD0", Offset = "0x2F5AD0", VA = "0x2F5AD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x2F43FC", Offset = "0x2F43FC", VA = "0x2F43FC")]
			[DebuggerHidden]
			public <AnimateVertexColors>c__Iterator0()
			{
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x2F4404", Offset = "0x2F4404", VA = "0x2F4404", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0x2F5AD8", Offset = "0x2F5AD8", VA = "0x2F5AD8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000360")]
			[Address(RVA = "0x2F5AEC", Offset = "0x2F5AEC", VA = "0x2F5AEC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float AngleMultiplier;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float ScaleMultiplier;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float RotationMultiplier;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2F403C", Offset = "0x2F403C", VA = "0x2F403C")]
		public VertexShakeA()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2F4058", Offset = "0x2F4058", VA = "0x2F4058")]
		private void Awake()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2F40C0", Offset = "0x2F40C0", VA = "0x2F40C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2F41C0", Offset = "0x2F41C0", VA = "0x2F41C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2F42C0", Offset = "0x2F42C0", VA = "0x2F42C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2F4364", Offset = "0x2F4364", VA = "0x2F4364")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2F42E4", Offset = "0x2F42E4", VA = "0x2F42E4")]
		[DebuggerHidden]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
	[Token(Token = "0x2000076")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F10D8", Offset = "0x1F10D8")]
		private sealed class <AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Vector3[][] <copyOfVertices>__0;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <characterCount>__1;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <lineCount>__1;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal VertexShakeB $this;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal object $current;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal bool $disposing;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal int $PC;

			[Token(Token = "0x1700006D")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x2F7F7C", Offset = "0x2F7F7C", VA = "0x2F7F7C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000364")]
				[Address(RVA = "0x2F7F84", Offset = "0x2F7F84", VA = "0x2F7F84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000361")]
			[Address(RVA = "0x2F5F2C", Offset = "0x2F5F2C", VA = "0x2F5F2C")]
			[DebuggerHidden]
			public <AnimateVertexColors>c__Iterator0()
			{
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0x2F5F34", Offset = "0x2F5F34", VA = "0x2F5F34", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x2F7F8C", Offset = "0x2F7F8C", VA = "0x2F7F8C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x2F7FA0", Offset = "0x2F7FA0", VA = "0x2F7FA0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float AngleMultiplier;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float SpeedMultiplier;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float CurveScale;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool hasTextChanged;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2F5B70", Offset = "0x2F5B70", VA = "0x2F5B70")]
		public VertexShakeB()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2F5B88", Offset = "0x2F5B88", VA = "0x2F5B88")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2F5BF0", Offset = "0x2F5BF0", VA = "0x2F5BF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2F5CF0", Offset = "0x2F5CF0", VA = "0x2F5CF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2F5DF0", Offset = "0x2F5DF0", VA = "0x2F5DF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2F5E94", Offset = "0x2F5E94", VA = "0x2F5E94")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2F5E14", Offset = "0x2F5E14", VA = "0x2F5E14")]
		[DebuggerHidden]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
	[Token(Token = "0x2000077")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F1148", Offset = "0x1F1148")]
		private sealed class <AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x20000AF")]
			private sealed class <AnimateVertexColors>c__AnonStorey1
			{
				[Token(Token = "0x40002DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal List<float> modifiedCharScale;

				[Token(Token = "0x40002DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				internal <AnimateVertexColors>c__Iterator0 <>f__ref$0;

				[Token(Token = "0x600036D")]
				[Address(RVA = "0xB6DA50", Offset = "0xB6DA50", VA = "0xB6DA50")]
				public <AnimateVertexColors>c__AnonStorey1()
				{
				}

				[Token(Token = "0x600036E")]
				[Address(RVA = "0xB6DA58", Offset = "0xB6DA58", VA = "0xB6DA58")]
				internal int <>m__0(int a, int b)
				{
					return default(int);
				}
			}

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal TMP_MeshInfo[] <cachedMeshInfoVertexData>__0;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal List<int> <scaleSortingOrder>__0;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <characterCount>__1;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal VertexZoom $this;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal object $current;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal bool $disposing;

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal int $PC;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private <AnimateVertexColors>c__AnonStorey1 $locvar0;

			[Token(Token = "0x1700006F")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000369")]
				[Address(RVA = "0x2F9A30", Offset = "0x2F9A30", VA = "0x2F9A30", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036A")]
				[Address(RVA = "0x2F9A38", Offset = "0x2F9A38", VA = "0x2F9A38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x2F83E8", Offset = "0x2F83E8", VA = "0x2F83E8")]
			[DebuggerHidden]
			public <AnimateVertexColors>c__Iterator0()
			{
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0x2F83F0", Offset = "0x2F83F0", VA = "0x2F83F0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x2F9A40", Offset = "0x2F9A40", VA = "0x2F9A40", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x2F9A54", Offset = "0x2F9A54", VA = "0x2F9A54", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float AngleMultiplier;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float SpeedMultiplier;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float CurveScale;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool hasTextChanged;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2F8024", Offset = "0x2F8024", VA = "0x2F8024")]
		public VertexZoom()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2F803C", Offset = "0x2F803C", VA = "0x2F803C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2F80A4", Offset = "0x2F80A4", VA = "0x2F80A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2F81A4", Offset = "0x2F81A4", VA = "0x2F81A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2F82A4", Offset = "0x2F82A4", VA = "0x2F82A4")]
		private void Start()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2F8348", Offset = "0x2F8348", VA = "0x2F8348")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2F82C8", Offset = "0x2F82C8", VA = "0x2F82C8")]
		[DebuggerHidden]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F11B8", Offset = "0x1F11B8")]
		private sealed class <WarpText>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <old_CurveScale>__0;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal AnimationCurve <old_curve>__0;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TMP_TextInfo <textInfo>__1;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <characterCount>__1;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal float <boundsMinX>__1;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal float <boundsMaxX>__1;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Vector3[] <vertices>__2;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal WarpTextExample $this;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal object $current;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			internal bool $disposing;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal int $PC;

			[Token(Token = "0x17000071")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000371")]
				[Address(RVA = "0xB6F1E8", Offset = "0xB6F1E8", VA = "0xB6F1E8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000372")]
				[Address(RVA = "0xB6F1F0", Offset = "0xB6F1F0", VA = "0xB6F1F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600036F")]
			[Address(RVA = "0xB6DF4C", Offset = "0xB6DF4C", VA = "0xB6DF4C")]
			[DebuggerHidden]
			public <WarpText>c__Iterator0()
			{
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0xB6DF54", Offset = "0xB6DF54", VA = "0xB6DF54", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000373")]
			[Address(RVA = "0xB6F1F8", Offset = "0xB6F1F8", VA = "0xB6F1F8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000374")]
			[Address(RVA = "0xB6F20C", Offset = "0xB6F20C", VA = "0xB6F20C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float AngleMultiplier;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float CurveScale;

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xB6DB28", Offset = "0xB6DB28", VA = "0xB6DB28")]
		public WarpTextExample()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xB6DD7C", Offset = "0xB6DD7C", VA = "0xB6DD7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xB6DE00", Offset = "0xB6DE00", VA = "0xB6DE00")]
		private void Start()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xB6DEA4", Offset = "0xB6DEA4", VA = "0xB6DEA4")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xB6DE24", Offset = "0xB6DE24", VA = "0xB6DE24")]
		[DebuggerHidden]
		private IEnumerator WarpText()
		{
			return null;
		}
	}
}
