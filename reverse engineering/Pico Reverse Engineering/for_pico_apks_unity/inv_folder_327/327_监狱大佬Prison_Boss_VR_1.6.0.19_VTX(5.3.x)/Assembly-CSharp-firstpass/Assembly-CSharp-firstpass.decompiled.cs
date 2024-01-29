using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using DG.Tweening.Core;
using Il2CppDummyDll;
using LitJson;
using Pvr_UnitySDKAPI;
using Pvr_UnitySDKAPI.Achievement;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ImageEffectTransformsToLDR]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x160B4C", Offset = "0x160B4C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x160B4C", Offset = "0x160B4C")]
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
		[Address(RVA = "0x354F98", Offset = "0x354F98", VA = "0x354F98")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x354FA0", Offset = "0x354FA0", VA = "0x354FA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public float colorTint
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x354FA8", Offset = "0x354FA8", VA = "0x354FA8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x354FB0", Offset = "0x354FB0", VA = "0x354FB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public bool toneMapping
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x354FB8", Offset = "0x354FB8", VA = "0x354FB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x354FC0", Offset = "0x354FC0", VA = "0x354FC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public float exposure
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x354FC8", Offset = "0x354FC8", VA = "0x354FC8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x354FD0", Offset = "0x354FD0", VA = "0x354FD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public float saturation
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x354FD8", Offset = "0x354FD8", VA = "0x354FD8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x354FE0", Offset = "0x354FE0", VA = "0x354FE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public AnimationCurve redCurve
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x354FE8", Offset = "0x354FE8", VA = "0x354FE8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x354FF0", Offset = "0x354FF0", VA = "0x354FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public AnimationCurve greenCurve
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x355340", Offset = "0x355340", VA = "0x355340")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x355348", Offset = "0x355348", VA = "0x355348")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public AnimationCurve blueCurve
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x355350", Offset = "0x355350", VA = "0x355350")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x355358", Offset = "0x355358", VA = "0x355358")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public AnimationCurve rgbCurve
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x355360", Offset = "0x355360", VA = "0x355360")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x355368", Offset = "0x355368", VA = "0x355368")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public DitherMode ditherMode
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x355370", Offset = "0x355370", VA = "0x355370")]
		get
		{
			return default(DitherMode);
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x355378", Offset = "0x355378", VA = "0x355378")]
		set
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x354EEC", Offset = "0x354EEC", VA = "0x354EEC")]
	public ColorSuite()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x355380", Offset = "0x355380", VA = "0x355380")]
	private static Color EncodeRGBM(float r, float g, float b)
	{
		return default(Color);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3554BC", Offset = "0x3554BC", VA = "0x3554BC")]
	private static float StandardIlluminantY(float x)
	{
		return default(float);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x3554F4", Offset = "0x3554F4", VA = "0x3554F4")]
	private static Vector3 CIExyToLMS(float x, float y)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x3555C4", Offset = "0x3555C4", VA = "0x3555C4")]
	private void Setup()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x354FF8", Offset = "0x354FF8", VA = "0x354FF8")]
	private void UpdateLUT()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3557A4", Offset = "0x3557A4", VA = "0x3557A4")]
	private Vector3 CalculateColorBalance()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3558C0", Offset = "0x3558C0", VA = "0x3558C0")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x355C88", Offset = "0x355C88", VA = "0x355C88")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x355CA4", Offset = "0x355CA4", VA = "0x355CA4")]
	private void Reset()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x3558DC", Offset = "0x3558DC", VA = "0x3558DC")]
	public void ApplyChanges()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x355CC0", Offset = "0x355CC0", VA = "0x355CC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x355D38", Offset = "0x355D38", VA = "0x355D38")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x355DBC", Offset = "0x355DBC", VA = "0x355DBC")]
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
			[Token(Token = "0x6000024")]
			[Address(RVA = "0xAC4538", Offset = "0xAC4538", VA = "0xAC4538")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xAC4634", Offset = "0xAC4634", VA = "0xAC4634")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xAC470C", Offset = "0xAC470C", VA = "0xAC470C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0xAC4808", Offset = "0xAC4808", VA = "0xAC4808")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		private float RotationY
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0xAC4AA8", Offset = "0xAC4AA8", VA = "0xAC4AA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0xAC4B00", Offset = "0xAC4B00", VA = "0xAC4B00")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		protected abstract Transform ChildToAlign
		{
			[Token(Token = "0x600002A")]
			get;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xAC4524", Offset = "0xAC4524", VA = "0xAC4524")]
		protected Calibrator()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xAC4BBC", Offset = "0xAC4BBC", VA = "0xAC4BBC")]
		public void Start()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xAC4E00", Offset = "0xAC4E00", VA = "0xAC4E00")]
		public void Update()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xAC5294", Offset = "0xAC5294", VA = "0xAC5294")]
		public void DesiredHeightOnInput()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xAC519C", Offset = "0xAC519C", VA = "0xAC519C")]
		public void RecenterOnInput()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xAC5404", Offset = "0xAC5404", VA = "0xAC5404")]
		public void ApplyDesiredHeight()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xAC55C0", Offset = "0xAC55C0", VA = "0xAC55C0")]
		public void AlignHeadWith(Vector3 direction)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xAC55C8", Offset = "0xAC55C8", VA = "0xAC55C8")]
		public void RecenterXZToThis()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xAC4EF8", Offset = "0xAC4EF8", VA = "0xAC4EF8")]
		private void MoveObjectsToUnderReferencePoint()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xAC576C", Offset = "0xAC576C", VA = "0xAC576C")]
		private void MoveSiblingReference()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xAC4BC0", Offset = "0xAC4BC0", VA = "0xAC4BC0")]
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
		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160C8C", Offset = "0x160C8C")]
		private sealed class <Invalidate>c__AnonStorey0
		{
			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object receiver;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal EventManager $this;

			[Token(Token = "0x6000922")]
			[Address(RVA = "0xAC6524", Offset = "0xAC6524", VA = "0xAC6524")]
			public <Invalidate>c__AnonStorey0()
			{
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0xAC65BC", Offset = "0xAC65BC", VA = "0xAC65BC")]
			internal bool <>m__0(Type t)
			{
				return default(bool);
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0xAC65F4", Offset = "0xAC65F4", VA = "0xAC65F4")]
			internal void <>m__1(Type type)
			{
			}
		}

		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160C9C", Offset = "0x160C9C")]
		private sealed class <SetCache>c__AnonStorey1<T> where T : IEventReceiver
		{
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Type type;

			[Token(Token = "0x6000925")]
			public <SetCache>c__AnonStorey1()
			{
			}

			[Token(Token = "0x6000926")]
			internal bool <>m__0(object r)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160CAC", Offset = "0x160CAC")]
		private sealed class <Get>c__AnonStorey2<T> where T : class, IEventReceiver
		{
			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal T cgetter;

			[Token(Token = "0x6000927")]
			public <Get>c__AnonStorey2()
			{
			}

			[Token(Token = "0x6000928")]
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

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xAC5F7C", Offset = "0xAC5F7C", VA = "0xAC5F7C")]
		public EventManager()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xAC603C", Offset = "0xAC603C", VA = "0xAC603C")]
		public void Add(object receiver)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xAC627C", Offset = "0xAC627C", VA = "0xAC627C")]
		public void AddRange(params object[] receivers)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xAC62DC", Offset = "0xAC62DC", VA = "0xAC62DC")]
		public void AddRange(IEnumerable<object> receivers)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xAC63BC", Offset = "0xAC63BC", VA = "0xAC63BC")]
		public void Remove(object receiver)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xAC6444", Offset = "0xAC6444", VA = "0xAC6444")]
		public void RemoveRange(IEnumerable<object> receivers)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xAC60C4", Offset = "0xAC60C4", VA = "0xAC60C4")]
		private void Invalidate(object receiver)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xAC652C", Offset = "0xAC652C", VA = "0xAC652C")]
		public void AddIfNeeded(object receiver)
		{
		}

		[Token(Token = "0x600003D")]
		private List<IEventReceiver> SetCache<T>() where T : IEventReceiver
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		public IEnumerable<T> Get<T>(object getter) where T : class, IEventReceiver
		{
			return null;
		}

		[Token(Token = "0x600003F")]
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

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xAC58E8", Offset = "0xAC58E8", VA = "0xAC58E8")]
		public ChangeMat()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xAC5908", Offset = "0xAC5908", VA = "0xAC5908", Slot = "4")]
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

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xAC5A70", Offset = "0xAC5A70", VA = "0xAC5A70")]
		public ChangeName()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xAC5AE4", Offset = "0xAC5AE4", VA = "0xAC5AE4", Slot = "4")]
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

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xAC5C18", Offset = "0xAC5C18", VA = "0xAC5C18")]
		public ChangeShader()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xAC5C28", Offset = "0xAC5C28", VA = "0xAC5C28", Slot = "4")]
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

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xAC5D18", Offset = "0xAC5D18", VA = "0xAC5D18")]
		public CopyName()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xAC5D20", Offset = "0xAC5D20", VA = "0xAC5D20")]
		public void Copy()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xAC5E78", Offset = "0xAC5E78", VA = "0xAC5E78")]
		public void Paste()
		{
		}
	}
}
[Token(Token = "0x200000B")]
public class GOMButton : Attribute
{
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x3628E8", Offset = "0x3628E8", VA = "0x3628E8")]
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

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xAC58F8", Offset = "0xAC58F8", VA = "0xAC58F8")]
		public GoMBase()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xAC59DC", Offset = "0xAC59DC", VA = "0xAC59DC", Slot = "4")]
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

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xAC6680", Offset = "0xAC6680", VA = "0xAC6680")]
		public PushScaleToChild()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xAC6690", Offset = "0xAC6690", VA = "0xAC6690", Slot = "4")]
		public override void Apply()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xAC66BC", Offset = "0xAC66BC", VA = "0xAC66BC")]
		private void Apply(Transform target)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xAC6DF8", Offset = "0xAC6DF8", VA = "0xAC6DF8")]
		private void Push(Vector3 from, Transform to)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xAC6E90", Offset = "0xAC6E90", VA = "0xAC6E90")]
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

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xAC6F58", Offset = "0xAC6F58", VA = "0xAC6F58")]
		public ResetToOrigin()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xAC6F68", Offset = "0xAC6F68", VA = "0xAC6F68", Slot = "4")]
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
		[Token(Token = "0x6000053")]
		[Address(RVA = "0xAC4510", Offset = "0xAC4510", VA = "0xAC4510")]
		public App()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xAC4518", Offset = "0xAC4518", VA = "0xAC4518")]
		public static void Quit()
		{
		}
	}
}
[Token(Token = "0x2000010")]
public class NVRLifeCycle : MonoBehaviour
{
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x365448", Offset = "0x365448", VA = "0x365448")]
	public NVRLifeCycle()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x365450", Offset = "0x365450", VA = "0x365450")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x365540", Offset = "0x365540", VA = "0x365540")]
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

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x3656A8", Offset = "0x3656A8", VA = "0x3656A8")]
	public NVRParent()
	{
	}
}
[Token(Token = "0x2000012")]
public class DontDestroyOnLoad : MonoBehaviour
{
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x35FB70", Offset = "0x35FB70", VA = "0x35FB70")]
	public DontDestroyOnLoad()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x35FB78", Offset = "0x35FB78", VA = "0x35FB78")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160CBC", Offset = "0x160CBC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x160CBC", Offset = "0x160CBC")]
		private static string <name>k__BackingField;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160CF0", Offset = "0x160CF0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x160CF0", Offset = "0x160CF0")]
		private static PlatformStatus <status>k__BackingField;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160D24", Offset = "0x160D24")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x160D24", Offset = "0x160D24")]
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
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xACA934", Offset = "0xACA934", VA = "0xACA934")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160D58", Offset = "0x160D58")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xACA784", Offset = "0xACA784", VA = "0xACA784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160D68", Offset = "0x160D68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public static PlatformStatus status
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xACA9C0", Offset = "0xACA9C0", VA = "0xACA9C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160D78", Offset = "0x160D78")]
			get
			{
				return default(PlatformStatus);
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0xACA814", Offset = "0xACA814", VA = "0xACA814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160D88", Offset = "0x160D88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public static string userName
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0xACAA4C", Offset = "0xACAA4C", VA = "0xACAA4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160D98", Offset = "0x160D98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0xACA8A4", Offset = "0xACA8A4", VA = "0xACA8A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160DA8", Offset = "0x160DA8")]
			private set
			{
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xACA6A4", Offset = "0xACA6A4", VA = "0xACA6A4")]
		public Platform()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xACAAD8", Offset = "0xACAAD8", VA = "0xACAAD8")]
		public static void NameChange(string name)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xACAB58", Offset = "0xACAB58", VA = "0xACAB58")]
		public static void StatusCallbackAdd(Action<PlatformStatus> callback)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xACACB0", Offset = "0xACACB0", VA = "0xACACB0")]
		public static void StatusCallbackRemove(Action<PlatformStatus> callback)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xACADD8", Offset = "0xACADD8", VA = "0xACADD8")]
		public static void StatusChange(PlatformStatus status)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xACAED8", Offset = "0xACAED8", VA = "0xACAED8")]
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
		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160DC8", Offset = "0x160DC8")]
		private sealed class <LoadSceneAfterInit>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600092B")]
				[Address(RVA = "0xAC7F70", Offset = "0xAC7F70", VA = "0xAC7F70", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600092C")]
				[Address(RVA = "0xAC7F78", Offset = "0xAC7F78", VA = "0xAC7F78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0xAC7D3C", Offset = "0xAC7D3C", VA = "0xAC7D3C")]
			[DebuggerHidden]
			public <LoadSceneAfterInit>c__Iterator0()
			{
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0xAC7DE8", Offset = "0xAC7DE8", VA = "0xAC7DE8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0xAC7F80", Offset = "0xAC7F80", VA = "0xAC7F80", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0xAC7F94", Offset = "0xAC7F94", VA = "0xAC7F94", Slot = "6")]
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
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xAC71D4", Offset = "0xAC71D4", VA = "0xAC71D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public bool IsActive
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xAC7260", Offset = "0xAC7260", VA = "0xAC7260")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		private bool IsInit
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xAC7350", Offset = "0xAC7350", VA = "0xAC7350")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xAC71CC", Offset = "0xAC71CC", VA = "0xAC71CC")]
		public SceneActivator()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xAC743C", Offset = "0xAC743C", VA = "0xAC743C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xAC75A4", Offset = "0xAC75A4", VA = "0xAC75A4")]
		private void CheckObjectCondition()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xAC78E4", Offset = "0xAC78E4", VA = "0xAC78E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xAC7778", Offset = "0xAC7778", VA = "0xAC7778")]
		public void Desactivate()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xAC7CB8", Offset = "0xAC7CB8", VA = "0xAC7CB8")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xAC7C2C", Offset = "0xAC7C2C", VA = "0xAC7C2C")]
		[DebuggerHidden]
		private IEnumerator LoadSceneAfterInit()
		{
			return null;
		}
	}
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x160E28", Offset = "0x160E28")]
	public class SceneLoaderHelperAttribute : Attribute
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0xACA69C", Offset = "0xACA69C", VA = "0xACA69C")]
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
			[Token(Token = "0x2000150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160EBC", Offset = "0x160EBC")]
			private sealed class <WaitForActive>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
			{
				[Token(Token = "0x40006C3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal SceneInformations $this;

				[Token(Token = "0x40006C4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				internal object $current;

				[Token(Token = "0x40006C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal bool $disposing;

				[Token(Token = "0x40006C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				internal int $PC;

				[Token(Token = "0x170000A4")]
				private object System.Collections.Generic.IEnumerator<object>.Current
				{
					[Token(Token = "0x6000931")]
					[Address(RVA = "0xACA5F4", Offset = "0xACA5F4", VA = "0xACA5F4", Slot = "8")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x170000A5")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000932")]
					[Address(RVA = "0xACA5FC", Offset = "0xACA5FC", VA = "0xACA5FC", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x600092F")]
				[Address(RVA = "0xACA524", Offset = "0xACA524", VA = "0xACA524")]
				[DebuggerHidden]
				public <WaitForActive>c__Iterator0()
				{
				}

				[Token(Token = "0x6000930")]
				[Address(RVA = "0xACA52C", Offset = "0xACA52C", VA = "0xACA52C", Slot = "5")]
				public bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x6000933")]
				[Address(RVA = "0xACA604", Offset = "0xACA604", VA = "0xACA604", Slot = "7")]
				[DebuggerHidden]
				public void Dispose()
				{
				}

				[Token(Token = "0x6000934")]
				[Address(RVA = "0xACA618", Offset = "0xACA618", VA = "0xACA618", Slot = "6")]
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
				[Token(Token = "0x6000093")]
				[Address(RVA = "0xAC9E90", Offset = "0xAC9E90", VA = "0xAC9E90")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000092")]
			[Address(RVA = "0xAC8E28", Offset = "0xAC8E28", VA = "0xAC8E28")]
			public SceneInformations()
			{
			}

			[Token(Token = "0x6000094")]
			[Address(RVA = "0xAC9430", Offset = "0xAC9430", VA = "0xAC9430")]
			public void SetActive()
			{
			}

			[Token(Token = "0x6000095")]
			[Address(RVA = "0xACA49C", Offset = "0xACA49C", VA = "0xACA49C")]
			public void Destroy()
			{
			}

			[Token(Token = "0x6000096")]
			[Address(RVA = "0xACA4A4", Offset = "0xACA4A4", VA = "0xACA4A4")]
			[DebuggerHidden]
			public IEnumerator WaitForActive()
			{
				return null;
			}
		}

		[Token(Token = "0x2000151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160F1C", Offset = "0x160F1C")]
		private sealed class <GetInfosLoadingWith>c__AnonStorey1
		{
			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal AsyncOperation operation;

			[Token(Token = "0x6000935")]
			[Address(RVA = "0xAC8288", Offset = "0xAC8288", VA = "0xAC8288")]
			public <GetInfosLoadingWith>c__AnonStorey1()
			{
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0xACA118", Offset = "0xACA118", VA = "0xACA118")]
			internal bool <>m__0(SceneInformations infos)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000152")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160F2C", Offset = "0x160F2C")]
		private sealed class <GetInfosUnloadingWith>c__AnonStorey2
		{
			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal AsyncOperation operation;

			[Token(Token = "0x6000937")]
			[Address(RVA = "0xAC837C", Offset = "0xAC837C", VA = "0xAC837C")]
			public <GetInfosUnloadingWith>c__AnonStorey2()
			{
			}

			[Token(Token = "0x6000938")]
			[Address(RVA = "0xACA14C", Offset = "0xACA14C", VA = "0xACA14C")]
			internal bool <>m__0(SceneInformations infos)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160F3C", Offset = "0x160F3C")]
		private sealed class <GetInfos>c__AnonStorey3
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Scene scene;

			[Token(Token = "0x6000939")]
			[Address(RVA = "0xAC8470", Offset = "0xAC8470", VA = "0xAC8470")]
			public <GetInfos>c__AnonStorey3()
			{
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0xAC9FA4", Offset = "0xAC9FA4", VA = "0xAC9FA4")]
			internal bool <>m__0(SceneInformations infos)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160F4C", Offset = "0x160F4C")]
		private sealed class <GetInfos>c__AnonStorey4
		{
			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string name;

			[Token(Token = "0x600093B")]
			[Address(RVA = "0xAC8564", Offset = "0xAC8564", VA = "0xAC8564")]
			public <GetInfos>c__AnonStorey4()
			{
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0xACA074", Offset = "0xACA074", VA = "0xACA074")]
			internal bool <>m__0(SceneInformations infos)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160F5C", Offset = "0x160F5C")]
		private sealed class <UnloadSceneSlowly>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SceneInformations infos;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal SceneLoader $this;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x170000A6")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600093F")]
				[Address(RVA = "0xACA3F4", Offset = "0xACA3F4", VA = "0xACA3F4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000940")]
				[Address(RVA = "0xACA3FC", Offset = "0xACA3FC", VA = "0xACA3FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0xAC9E64", Offset = "0xAC9E64", VA = "0xAC9E64")]
			[DebuggerHidden]
			public <UnloadSceneSlowly>c__Iterator0()
			{
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0xACA180", Offset = "0xACA180", VA = "0xACA180", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0xACA404", Offset = "0xACA404", VA = "0xACA404", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0xACA418", Offset = "0xACA418", VA = "0xACA418", Slot = "6")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160E5C", Offset = "0x160E5C")]
		private static Func<SceneInformations, bool> <>f__am$cache0;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160E6C", Offset = "0x160E6C")]
		private static Func<SceneInformations, bool> <>f__am$cache1;

		[Token(Token = "0x17000015")]
		public static SceneLoader Instance
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xAC7B88", Offset = "0xAC7B88", VA = "0xAC7B88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xAC8018", Offset = "0xAC8018", VA = "0xAC8018")]
		public SceneLoader()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xAC80A4", Offset = "0xAC80A4", VA = "0xAC80A4")]
		public IEnumerable<SceneInformations> GetInfosActive()
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xAC819C", Offset = "0xAC819C", VA = "0xAC819C")]
		public IEnumerable<SceneInformations> GetInfosLoadingWith(AsyncOperation operation)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xAC8290", Offset = "0xAC8290", VA = "0xAC8290")]
		public IEnumerable<SceneInformations> GetInfosUnloadingWith(AsyncOperation operation)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xAC8384", Offset = "0xAC8384", VA = "0xAC8384")]
		public IEnumerable<SceneInformations> GetInfos(Scene scene)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xAC8478", Offset = "0xAC8478", VA = "0xAC8478")]
		public IEnumerable<SceneInformations> GetInfos(string name)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xAC856C", Offset = "0xAC856C", VA = "0xAC856C")]
		public void Awake()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xAC8CD4", Offset = "0xAC8CD4", VA = "0xAC8CD4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xAC88D0", Offset = "0xAC88D0", VA = "0xAC88D0")]
		private void CreateHelpers()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xAC86D0", Offset = "0xAC86D0", VA = "0xAC86D0")]
		private void PopulateFromOpenedScene()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xAC8F48", Offset = "0xAC8F48", VA = "0xAC8F48")]
		private void SceneManager_sceneUnloaded(Scene arg0)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xAC905C", Offset = "0xAC905C", VA = "0xAC905C")]
		private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xAC9108", Offset = "0xAC9108", VA = "0xAC9108")]
		private void SceneManager_activeSceneChanged(Scene current, Scene next)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xAC9174", Offset = "0xAC9174", VA = "0xAC9174")]
		private void Scene_completed(AsyncOperation obj)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xAC9460", Offset = "0xAC9460", VA = "0xAC9460")]
		private void Unloading_completed(AsyncOperation asyncOperation)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xAC8E30", Offset = "0xAC8E30", VA = "0xAC8E30")]
		private SceneActivator GetActivator(Scene scene)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xAC95F0", Offset = "0xAC95F0", VA = "0xAC95F0")]
		private void SetSceneActive(SceneInformations sceneInformations)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xAC9890", Offset = "0xAC9890", VA = "0xAC9890")]
		private void SetSceneInactive(SceneInformations info)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xAC7C98", Offset = "0xAC7C98", VA = "0xAC7C98")]
		public static SceneInformations LoadScene(int buildIndex)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xAC7F44", Offset = "0xAC7F44", VA = "0xAC7F44")]
		public static SceneInformations LoadScene(string name)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xAC9B40", Offset = "0xAC9B40", VA = "0xAC9B40")]
		public static SceneInformations PrepareSceneOnce(int buildIndex)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xAC99FC", Offset = "0xAC99FC", VA = "0xAC99FC")]
		public static SceneInformations PrepareSceneOnce(string name)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xAC9CBC", Offset = "0xAC9CBC", VA = "0xAC9CBC")]
		public static SceneInformations PrepareScene(int buildIndex)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xAC9BE4", Offset = "0xAC9BE4", VA = "0xAC9BE4")]
		public static SceneInformations PrepareScene(string name)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xAC9CDC", Offset = "0xAC9CDC", VA = "0xAC9CDC")]
		private void SetupLoadingInfos(SceneInformations infos)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xAC99A4", Offset = "0xAC99A4", VA = "0xAC99A4")]
		private static void DestroyScene(SceneInformations infos)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xAC9DCC", Offset = "0xAC9DCC", VA = "0xAC9DCC")]
		[DebuggerHidden]
		private IEnumerator UnloadSceneSlowly(SceneInformations infos)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xAC9E6C", Offset = "0xAC9E6C", VA = "0xAC9E6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160E8C", Offset = "0x160E8C")]
		private static bool <GetInfosActive>m__0(SceneInformations infos)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xAC9F78", Offset = "0xAC9F78", VA = "0xAC9F78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160E9C", Offset = "0x160E9C")]
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

		[Token(Token = "0x6000097")]
		public SimpleScriptableObject()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class BaseSettings : ICloneable
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0xACAF5C", Offset = "0xACAF5C", VA = "0xACAF5C")]
		public BaseSettings()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xACAF64", Offset = "0xACAF64", VA = "0xACAF64", Slot = "4")]
		public object Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x200001B")]
	public class Settings<T, U> : MonoBehaviour where T : BaseSettings, new() where U : SimpleScriptableObject<T>
	{
		[Token(Token = "0x2000156")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x160FFC", Offset = "0x160FFC")]
		private sealed class <GetDefaultValues>c__Iterator0 : IEnumerable, IEnumerable<object>, IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Type type;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal object $current;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool $disposing;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int $PC;

			[Token(Token = "0x170000A8")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000945")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000946")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000943")]
			[DebuggerHidden]
			public <GetDefaultValues>c__Iterator0()
			{
			}

			[Token(Token = "0x6000944")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000947")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000948")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x6000949")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600094A")]
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
			[Token(Token = "0x600009F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private string FilePath
		{
			[Token(Token = "0x60000A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private string PersistentFilePath
		{
			[Token(Token = "0x60000A1")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009A")]
		public Settings()
		{
		}

		[Token(Token = "0x600009B")]
		public T GetSettings()
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		public T GetForcedSettings()
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		public T GetSavedSettings()
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		public void SetSettings(T settings)
		{
		}

		[Token(Token = "0x60000A2")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A3")]
		public void ReloadSettings()
		{
		}

		[Token(Token = "0x60000A4")]
		private static T MergeSettings(params T[] settings)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		private void LoadFromFile(string[] paths)
		{
		}

		[Token(Token = "0x60000A6")]
		private static void Save(T setting, string filepath)
		{
		}

		[Token(Token = "0x60000A7")]
		private static void LoadPublicFieldFromT()
		{
		}

		[Token(Token = "0x60000A8")]
		private static void CopyNonDefaultMember(T from, ref T to)
		{
		}

		[Token(Token = "0x60000A9")]
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
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xACD8E4", Offset = "0xACD8E4", VA = "0xACD8E4")]
			public static string GetPath(string subdirectory)
			{
				return null;
			}
		}

		[Token(Token = "0x200001E")]
		private static class OSX
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0xACD9D4", Offset = "0xACD9D4", VA = "0xACD9D4")]
			public static string GetApplicationSupportPath(string subdirectory)
			{
				return null;
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xACDF60", Offset = "0xACDF60", VA = "0xACDF60")]
			public static string GetLogsPath()
			{
				return null;
			}
		}

		[Token(Token = "0x200001F")]
		private static class Linux
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xACDAD0", Offset = "0xACDAD0", VA = "0xACDAD0")]
			public static string GetSaveDirectory()
			{
				return null;
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xACDD20", Offset = "0xACDD20", VA = "0xACDD20")]
			public static string GetConfigDirectory()
			{
				return null;
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xACE04C", Offset = "0xACE04C", VA = "0xACE04C")]
			public static string GetLogDirectory()
			{
				return null;
			}
		}

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16107C", Offset = "0x16107C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x16107C", Offset = "0x16107C")]
		private static bool <includeCompanyName>k__BackingField;

		[Token(Token = "0x1700001A")]
		public static bool includeCompanyName
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xACD758", Offset = "0xACD758", VA = "0xACD758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1610B0", Offset = "0x1610B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xACD6C8", Offset = "0xACD6C8", VA = "0xACD6C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1610C0", Offset = "0x1610C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public static string saveDataDirectory
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xACD7E4", Offset = "0xACD7E4", VA = "0xACD7E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public static string configDirectory
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0xACDC20", Offset = "0xACDC20", VA = "0xACDC20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public static string logDirectory
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xACDE70", Offset = "0xACDE70", VA = "0xACDE70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xACD6C0", Offset = "0xACD6C0", VA = "0xACD6C0")]
		static StandardPaths()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xACE0D4", Offset = "0xACE0D4", VA = "0xACE0D4")]
		private static string AppendProductPath(string path)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xACE1EC", Offset = "0xACE1EC", VA = "0xACE1EC")]
		private static string AppendDirectory(string path, string dir)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xACE2FC", Offset = "0xACE2FC", VA = "0xACE2FC")]
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
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xACAF6C", Offset = "0xACAF6C", VA = "0xACAF6C")]
		public static void GetQuadraticBezierCurve(ref Vector3[] points, Vector3 start, Vector3 end, Vector3 ctrl)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xACB268", Offset = "0xACB268", VA = "0xACB268")]
		public static void GetCubicBezierCurve(ref Vector3[] points, Vector3 start, Vector3 end, Vector3 ctrl, Vector3 ctrl2)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xACB3B0", Offset = "0xACB3B0", VA = "0xACB3B0")]
		public static Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xACB09C", Offset = "0xACB09C", VA = "0xACB09C")]
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

		[Token(Token = "0x2000157")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161130", Offset = "0x161130")]
		private sealed class <GetClass>c__Iterator0<T> : IEnumerable, IEnumerable<TypeWithAttributes<T>>, IEnumerator, IDisposable, IEnumerator<TypeWithAttributes<T>> where T : Attribute
		{
			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Assembly[] $locvar0;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int $locvar1;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Assembly <assembly>__1;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Type[] $locvar2;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int $locvar3;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Type <type>__2;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool inheritAttributes;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal object[] <attributes>__3;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TypeWithAttributes<T> $current;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool $disposing;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int $PC;

			[Token(Token = "0x170000AA")]
			private TypeWithAttributes<T> System.Collections.Generic.IEnumerator<Trebuchet.Utils.GlobalUtils.TypeWithAttributes<T>>.Current
			{
				[Token(Token = "0x600094D")]
				[DebuggerHidden]
				get
				{
					return default(TypeWithAttributes<T>);
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600094E")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094B")]
			[DebuggerHidden]
			public <GetClass>c__Iterator0()
			{
			}

			[Token(Token = "0x600094C")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600094F")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000950")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x6000951")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000952")]
			[DebuggerHidden]
			private IEnumerator<TypeWithAttributes<T>> System.Collections.Generic.IEnumerable<Trebuchet.Utils.GlobalUtils.TypeWithAttributes<T>>.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject globalManager;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xACB5EC", Offset = "0xACB5EC", VA = "0xACB5EC")]
		public static bool IsNotNull(this object target)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xACB5FC", Offset = "0xACB5FC", VA = "0xACB5FC")]
		public static bool IsNumber(this float number)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xACB63C", Offset = "0xACB63C", VA = "0xACB63C")]
		public static Mesh GetMeshInstance(this Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Token(Token = "0x60000C2")]
		public static void Resize<T>(ref T[] array, int size)
		{
		}

		[Token(Token = "0x60000C3")]
		[DebuggerHidden]
		public static IEnumerable<TypeWithAttributes<T>> GetClass<T>(bool inheritAttributes = true) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1611C0", Offset = "0x1611C0")]
		private static Func<bool, bool> <>f__am$cache0;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xACB7C8", Offset = "0xACB7C8", VA = "0xACB7C8")]
		public static bool All(this IEnumerable<bool> bools)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		public static bool StartsWith<Source>(this IEnumerable<Source> first, ICollection<Source> second)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xACB8BC", Offset = "0xACB8BC", VA = "0xACB8BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1611F0", Offset = "0x1611F0")]
		private static bool <All>m__0(bool b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000024")]
	public static class TransformUtils
	{
		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1612C0", Offset = "0x1612C0")]
		private sealed class <FindClose>c__AnonStorey0<T> where T : Component
		{
			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Vector3 position;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal float distance;

			[Token(Token = "0x6000953")]
			public <FindClose>c__AnonStorey0()
			{
			}

			[Token(Token = "0x6000954")]
			internal bool <>m__0(T w)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xACB8C4", Offset = "0xACB8C4", VA = "0xACB8C4")]
		public static void LerpWorld(this Transform transform, Vector3 position, Quaternion rotation, float speed)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xACBCA8", Offset = "0xACBCA8", VA = "0xACBCA8")]
		public static void LerpLocal(this Transform transform, Vector3 position, Quaternion rotation, float speed)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xACBE58", Offset = "0xACBE58", VA = "0xACBE58")]
		public static float Lerp(this float value, float target, float speed)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xACBE78", Offset = "0xACBE78", VA = "0xACBE78")]
		public static void LerpLocal(this Transform transform, Vector3 position, Quaternion rotation, Vector3 scale, float speed)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xACC0A0", Offset = "0xACC0A0", VA = "0xACC0A0")]
		public static void SetLayerRecursively(this GameObject gameObject, int newLayer)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xACC4DC", Offset = "0xACC4DC", VA = "0xACC4DC")]
		public static void SetLayerRecursively(this Component component, int newLayer)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xACC15C", Offset = "0xACC15C", VA = "0xACC15C")]
		public static void SetLayerRecursively(this Transform transform, int newLayer)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xACC598", Offset = "0xACC598", VA = "0xACC598")]
		public static Transform FindDeep(this Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		public static IEnumerable<T> FindClose<T>(this Component comp, float distance = 3f) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		public static T GetOrAdd<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		public static T GetOrAdd<T>(this Component component) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x2000025")]
	public static class VectorUtils
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xACC974", Offset = "0xACC974", VA = "0xACC974")]
		public static Vector3 MultipliedBy(this Vector3 orig, Vector3 other)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xACBAF0", Offset = "0xACBAF0", VA = "0xACBAF0")]
		public static bool IsRotation(this Quaternion quat)
		{
			return default(bool);
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x161300", Offset = "0x161300")]
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

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x358D64", Offset = "0x358D64", VA = "0x358D64")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x358FC8", Offset = "0x358FC8", VA = "0x358FC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x35BB50", Offset = "0x35BB50", VA = "0x35BB50")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x35BB90", Offset = "0x35BB90", VA = "0x35BB90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x359014", Offset = "0x359014", VA = "0x359014")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x35C85C", Offset = "0x35C85C", VA = "0x35C85C", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x35C8F4", Offset = "0x35C8F4", VA = "0x35C8F4", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x35C98C", Offset = "0x35C98C", VA = "0x35C98C", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x35CA24", Offset = "0x35CA24", VA = "0x35CA24", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x35CABC", Offset = "0x35CABC", VA = "0x35CABC", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x35CB54", Offset = "0x35CB54", VA = "0x35CB54", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x35CCB4", Offset = "0x35CCB4", VA = "0x35CCB4", Slot = "10")]
		public override void DORestart(bool fromHere = false)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x35D19C", Offset = "0x35D19C", VA = "0x35D19C", Slot = "11")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x35D238", Offset = "0x35D238", VA = "0x35D238", Slot = "12")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x35D2DC", Offset = "0x35D2DC", VA = "0x35D2DC")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x35D37C", Offset = "0x35D37C", VA = "0x35D37C")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x35D404", Offset = "0x35D404", VA = "0x35D404")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x35D48C", Offset = "0x35D48C", VA = "0x35D48C")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x35D52C", Offset = "0x35D52C", VA = "0x35D52C")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x35D5B4", Offset = "0x35D5B4", VA = "0x35D5B4")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x35D654", Offset = "0x35D654", VA = "0x35D654")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x35D6DC", Offset = "0x35D6DC", VA = "0x35D6DC")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x35D83C", Offset = "0x35D83C", VA = "0x35D83C")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x35D8E8", Offset = "0x35D8E8", VA = "0x35D8E8")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x35D9A8", Offset = "0x35D9A8", VA = "0x35D9A8")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x35DA54", Offset = "0x35DA54", VA = "0x35DA54")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x35BBDC", Offset = "0x35BBDC", VA = "0x35BBDC")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x35CDD0", Offset = "0x35CDD0", VA = "0x35CDD0")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x35DB6C", Offset = "0x35DB6C", VA = "0x35DB6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161334", Offset = "0x161334")]
		private void <CreateTween>m__0()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x60000F3")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000028")]
	public static class ShortcutExtensionsTextMeshPro
	{
		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161414", Offset = "0x161414")]
		private sealed class <DOColor>c__AnonStorey0
		{
			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x35DB78", Offset = "0x35DB78", VA = "0x35DB78")]
			public <DOColor>c__AnonStorey0()
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x35E724", Offset = "0x35E724", VA = "0x35E724")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x35E75C", Offset = "0x35E75C", VA = "0x35E75C")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161424", Offset = "0x161424")]
		private sealed class <DOFaceColor>c__AnonStorey1
		{
			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x35DD34", Offset = "0x35DD34", VA = "0x35DD34")]
			public <DOFaceColor>c__AnonStorey1()
			{
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x35E7B8", Offset = "0x35E7B8", VA = "0x35E7B8")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x35E7F8", Offset = "0x35E7F8", VA = "0x35E7F8")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161434", Offset = "0x161434")]
		private sealed class <DOOutlineColor>c__AnonStorey2
		{
			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x35DEF0", Offset = "0x35DEF0", VA = "0x35DEF0")]
			public <DOOutlineColor>c__AnonStorey2()
			{
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x35EA14", Offset = "0x35EA14", VA = "0x35EA14")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x35EA54", Offset = "0x35EA54", VA = "0x35EA54")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161444", Offset = "0x161444")]
		private sealed class <DOFade>c__AnonStorey3
		{
			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x35E04C", Offset = "0x35E04C", VA = "0x35E04C")]
			public <DOFade>c__AnonStorey3()
			{
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x35E8D0", Offset = "0x35E8D0", VA = "0x35E8D0")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000960")]
			[Address(RVA = "0x35E908", Offset = "0x35E908", VA = "0x35E908")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x200015D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161454", Offset = "0x161454")]
		private sealed class <DOFaceFade>c__AnonStorey4
		{
			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x6000961")]
			[Address(RVA = "0x35E1E8", Offset = "0x35E1E8", VA = "0x35E1E8")]
			public <DOFaceFade>c__AnonStorey4()
			{
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0x35E844", Offset = "0x35E844", VA = "0x35E844")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x35E884", Offset = "0x35E884", VA = "0x35E884")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161464", Offset = "0x161464")]
		private sealed class <DOScale>c__AnonStorey5
		{
			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Transform t;

			[Token(Token = "0x6000964")]
			[Address(RVA = "0x35E3DC", Offset = "0x35E3DC", VA = "0x35E3DC")]
			public <DOScale>c__AnonStorey5()
			{
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0x35EAA0", Offset = "0x35EAA0", VA = "0x35EAA0")]
			internal Vector3 <>m__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0x35EAD0", Offset = "0x35EAD0", VA = "0x35EAD0")]
			internal void <>m__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161474", Offset = "0x161474")]
		private sealed class <DOFontSize>c__AnonStorey6
		{
			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x6000967")]
			[Address(RVA = "0x35E578", Offset = "0x35E578", VA = "0x35E578")]
			public <DOFontSize>c__AnonStorey6()
			{
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0x35E964", Offset = "0x35E964", VA = "0x35E964")]
			internal float <>m__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x35E98C", Offset = "0x35E98C", VA = "0x35E98C")]
			internal void <>m__1(float x)
			{
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161484", Offset = "0x161484")]
		private sealed class <DOMaxVisibleCharacters>c__AnonStorey7
		{
			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x35E714", Offset = "0x35E714", VA = "0x35E714")]
			public <DOMaxVisibleCharacters>c__AnonStorey7()
			{
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0x35E9BC", Offset = "0x35E9BC", VA = "0x35E9BC")]
			internal int <>m__0()
			{
				return default(int);
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0x35E9E4", Offset = "0x35E9E4", VA = "0x35E9E4")]
			internal void <>m__1(int x)
			{
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161494", Offset = "0x161494")]
		private sealed class <DOText>c__AnonStorey8
		{
			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshPro target;

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x35E71C", Offset = "0x35E71C", VA = "0x35E71C")]
			public <DOText>c__AnonStorey8()
			{
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0x35EB1C", Offset = "0x35EB1C", VA = "0x35EB1C")]
			internal string <>m__0()
			{
				return null;
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0x35EB44", Offset = "0x35EB44", VA = "0x35EB44")]
			internal void <>m__1(string x)
			{
			}
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x35BFF8", Offset = "0x35BFF8", VA = "0x35BFF8")]
		public static Tweener DOColor(this TextMeshPro target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x35DB80", Offset = "0x35DB80", VA = "0x35DB80")]
		public static Tweener DOFaceColor(this TextMeshPro target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x35DD3C", Offset = "0x35DD3C", VA = "0x35DD3C")]
		public static Tweener DOOutlineColor(this TextMeshPro target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x35DEF8", Offset = "0x35DEF8", VA = "0x35DEF8")]
		public static Tweener DOGlowColor(this TextMeshPro target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x35C338", Offset = "0x35C338", VA = "0x35C338")]
		public static Tweener DOFade(this TextMeshPro target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x35E054", Offset = "0x35E054", VA = "0x35E054")]
		public static Tweener DOFaceFade(this TextMeshPro target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x35E1F0", Offset = "0x35E1F0", VA = "0x35E1F0")]
		public static Tweener DOScale(this TextMeshPro target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x35E3E4", Offset = "0x35E3E4", VA = "0x35E3E4")]
		public static Tweener DOFontSize(this TextMeshPro target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x35E580", Offset = "0x35E580", VA = "0x35E580")]
		public static Tweener DOMaxVisibleCharacters(this TextMeshPro target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x35C694", Offset = "0x35C694", VA = "0x35C694")]
		public static Tweener DOText(this TextMeshPro target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
	[Token(Token = "0x2000029")]
	public static class ShortcutExtensionsTextMeshProUGUI
	{
		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161554", Offset = "0x161554")]
		private sealed class <DOColor>c__AnonStorey0
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x6000970")]
			[Address(RVA = "0x35EB74", Offset = "0x35EB74", VA = "0x35EB74")]
			public <DOColor>c__AnonStorey0()
			{
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x35F720", Offset = "0x35F720", VA = "0x35F720")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x35F758", Offset = "0x35F758", VA = "0x35F758")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161564", Offset = "0x161564")]
		private sealed class <DOFaceColor>c__AnonStorey1
		{
			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x35ED30", Offset = "0x35ED30", VA = "0x35ED30")]
			public <DOFaceColor>c__AnonStorey1()
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x35F7B4", Offset = "0x35F7B4", VA = "0x35F7B4")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0x35F7F4", Offset = "0x35F7F4", VA = "0x35F7F4")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161574", Offset = "0x161574")]
		private sealed class <DOOutlineColor>c__AnonStorey2
		{
			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x6000976")]
			[Address(RVA = "0x35EEEC", Offset = "0x35EEEC", VA = "0x35EEEC")]
			public <DOOutlineColor>c__AnonStorey2()
			{
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0x35FA10", Offset = "0x35FA10", VA = "0x35FA10")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0x35FA50", Offset = "0x35FA50", VA = "0x35FA50")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161584", Offset = "0x161584")]
		private sealed class <DOFade>c__AnonStorey3
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x6000979")]
			[Address(RVA = "0x35F048", Offset = "0x35F048", VA = "0x35F048")]
			public <DOFade>c__AnonStorey3()
			{
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x35F8CC", Offset = "0x35F8CC", VA = "0x35F8CC")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0x35F904", Offset = "0x35F904", VA = "0x35F904")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161594", Offset = "0x161594")]
		private sealed class <DOFaceFade>c__AnonStorey4
		{
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x600097C")]
			[Address(RVA = "0x35F1E4", Offset = "0x35F1E4", VA = "0x35F1E4")]
			public <DOFaceFade>c__AnonStorey4()
			{
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0x35F840", Offset = "0x35F840", VA = "0x35F840")]
			internal Color <>m__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0x35F880", Offset = "0x35F880", VA = "0x35F880")]
			internal void <>m__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1615A4", Offset = "0x1615A4")]
		private sealed class <DOScale>c__AnonStorey5
		{
			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Transform t;

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x35F3D8", Offset = "0x35F3D8", VA = "0x35F3D8")]
			public <DOScale>c__AnonStorey5()
			{
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x35FA9C", Offset = "0x35FA9C", VA = "0x35FA9C")]
			internal Vector3 <>m__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x35FACC", Offset = "0x35FACC", VA = "0x35FACC")]
			internal void <>m__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1615B4", Offset = "0x1615B4")]
		private sealed class <DOFontSize>c__AnonStorey6
		{
			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x35F574", Offset = "0x35F574", VA = "0x35F574")]
			public <DOFontSize>c__AnonStorey6()
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x35F960", Offset = "0x35F960", VA = "0x35F960")]
			internal float <>m__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x35F988", Offset = "0x35F988", VA = "0x35F988")]
			internal void <>m__1(float x)
			{
			}
		}

		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1615C4", Offset = "0x1615C4")]
		private sealed class <DOMaxVisibleCharacters>c__AnonStorey7
		{
			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x35F710", Offset = "0x35F710", VA = "0x35F710")]
			public <DOMaxVisibleCharacters>c__AnonStorey7()
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x35F9B8", Offset = "0x35F9B8", VA = "0x35F9B8")]
			internal int <>m__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x35F9E0", Offset = "0x35F9E0", VA = "0x35F9E0")]
			internal void <>m__1(int x)
			{
			}
		}

		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1615D4", Offset = "0x1615D4")]
		private sealed class <DOText>c__AnonStorey8
		{
			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextMeshProUGUI target;

			[Token(Token = "0x6000988")]
			[Address(RVA = "0x35F718", Offset = "0x35F718", VA = "0x35F718")]
			public <DOText>c__AnonStorey8()
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x35FB18", Offset = "0x35FB18", VA = "0x35FB18")]
			internal string <>m__0()
			{
				return null;
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0x35FB40", Offset = "0x35FB40", VA = "0x35FB40")]
			internal void <>m__1(string x)
			{
			}
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x35BE4C", Offset = "0x35BE4C", VA = "0x35BE4C")]
		public static Tweener DOColor(this TextMeshProUGUI target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x35EB7C", Offset = "0x35EB7C", VA = "0x35EB7C")]
		public static Tweener DOFaceColor(this TextMeshProUGUI target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x35ED38", Offset = "0x35ED38", VA = "0x35ED38")]
		public static Tweener DOOutlineColor(this TextMeshProUGUI target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x35EEF4", Offset = "0x35EEF4", VA = "0x35EEF4")]
		public static Tweener DOGlowColor(this TextMeshProUGUI target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x35C1A4", Offset = "0x35C1A4", VA = "0x35C1A4")]
		public static Tweener DOFade(this TextMeshProUGUI target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x35F050", Offset = "0x35F050", VA = "0x35F050")]
		public static Tweener DOFaceFade(this TextMeshProUGUI target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x35F1EC", Offset = "0x35F1EC", VA = "0x35F1EC")]
		public static Tweener DOScale(this TextMeshProUGUI target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x35F3E0", Offset = "0x35F3E0", VA = "0x35F3E0")]
		public static Tweener DOFontSize(this TextMeshProUGUI target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x35F57C", Offset = "0x35F57C", VA = "0x35F57C")]
		public static Tweener DOMaxVisibleCharacters(this TextMeshProUGUI target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x35C4CC", Offset = "0x35C4CC", VA = "0x35C4CC")]
		public static Tweener DOText(this TextMeshProUGUI target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
}
namespace Pvr_UnitySDKAPI.Achievement
{
	[Token(Token = "0x200002A")]
	public sealed class AchievementCore
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool IsPlatformInitialized;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool LogMessages;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x45DE48", Offset = "0x45DE48", VA = "0x45DE48")]
		public AchievementCore()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x45DE50", Offset = "0x45DE50", VA = "0x45DE50")]
		public static bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x45DEDC", Offset = "0x45DEDC", VA = "0x45DEDC")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x45DEE0", Offset = "0x45DEE0", VA = "0x45DEE0")]
		public static void RegisterNetwork()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x45E0F8", Offset = "0x45E0F8", VA = "0x45E0F8")]
		public static void UnRegisterNetwork()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public static class Achievements
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x45E2B8", Offset = "0x45E2B8", VA = "0x45E2B8")]
		public static Pvr_Request<Pvr_AchievementUpdate> Init()
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x45E900", Offset = "0x45E900", VA = "0x45E900")]
		public static Pvr_Request<Pvr_AchievementUpdate> AddCount(string name, long count)
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x45EC3C", Offset = "0x45EC3C", VA = "0x45EC3C")]
		public static Pvr_Request<Pvr_AchievementUpdate> AddFields(string name, string fields)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x45EF40", Offset = "0x45EF40", VA = "0x45EF40")]
		public static Pvr_Request<Pvr_AchievementDefinitionList> GetAllDefinitions()
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x45F250", Offset = "0x45F250", VA = "0x45F250")]
		public static Pvr_Request<Pvr_AchievementProgressList> GetAllProgress()
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x45F4AC", Offset = "0x45F4AC", VA = "0x45F4AC")]
		public static Pvr_Request<Pvr_AchievementDefinitionList> GetDefinitionsByName(string[] names)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x45F7B0", Offset = "0x45F7B0", VA = "0x45F7B0")]
		public static Pvr_Request<Pvr_AchievementProgressList> GetProgressByName(string[] names)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x45FA60", Offset = "0x45FA60", VA = "0x45FA60")]
		public static Pvr_Request<Pvr_AchievementUpdate> Unlock(string name)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x45FD10", Offset = "0x45FD10", VA = "0x45FD10")]
		public static Pvr_Request<Pvr_AchievementDefinitionList> GetNextAchievementDefinitionListPage(Pvr_AchievementDefinitionList list)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4601EC", Offset = "0x4601EC", VA = "0x4601EC")]
		public static Pvr_Request<Pvr_AchievementProgressList> GetNextAchievementProgressListPage(Pvr_AchievementProgressList list)
		{
			return null;
		}
	}
	[Token(Token = "0x200002C")]
	public enum AchievementType
	{
		[Token(Token = "0x4000075")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1615E4", Offset = "0x1615E4")]
		Unknown,
		[Token(Token = "0x4000076")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x161618", Offset = "0x161618")]
		Simple,
		[Token(Token = "0x4000077")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x16164C", Offset = "0x16164C")]
		Bitfield,
		[Token(Token = "0x4000078")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x161680", Offset = "0x161680")]
		Count
	}
	[Token(Token = "0x200002D")]
	public class Pvr_AchievementAPI
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass achievementAPI;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static AndroidJavaClass definitionArrayHandle;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AndroidJavaClass definitionHandle;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static AndroidJavaClass progressArrayHandle;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static AndroidJavaClass progressHandle;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static AndroidJavaClass updateHandle;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static AndroidJavaObject errorHandle;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static AndroidJavaObject unityInterface;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string openId;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static string accessToken;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string appId;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x460DFC", Offset = "0x460DFC", VA = "0x460DFC")]
		public Pvr_AchievementAPI()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x45E3BC", Offset = "0x45E3BC", VA = "0x45E3BC")]
		internal static long Init()
		{
			return default(long);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x45DF58", Offset = "0x45DF58", VA = "0x45DF58")]
		internal static void RegisterNetwork()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x45E170", Offset = "0x45E170", VA = "0x45E170")]
		internal static void UnRegisterNetwork()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x460E04", Offset = "0x460E04", VA = "0x460E04")]
		internal static AndroidJavaObject PopMessage()
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x460EF0", Offset = "0x460EF0", VA = "0x460EF0")]
		internal static string pvr_Error_GetMessage(AndroidJavaObject popMessage)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x461060", Offset = "0x461060", VA = "0x461060")]
		internal static int pvr_Error_GetHttpCode(AndroidJavaObject popMessage)
		{
			return default(int);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x4611A4", Offset = "0x4611A4", VA = "0x4611A4")]
		internal static int pvr_Error_GetCode(AndroidJavaObject popMessage)
		{
			return default(int);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x45EA1C", Offset = "0x45EA1C", VA = "0x45EA1C")]
		internal static long pvr_Achievements_AddCount(string name, long count)
		{
			return default(long);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x45ED50", Offset = "0x45ED50", VA = "0x45ED50")]
		internal static long pvr_Achievements_AddFields(string name, string fields)
		{
			return default(long);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x45F044", Offset = "0x45F044", VA = "0x45F044")]
		internal static long pvr_Achievements_GetAllDefinitions()
		{
			return default(long);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x45F354", Offset = "0x45F354", VA = "0x45F354")]
		internal static long pvr_Achievements_GetAllProgress()
		{
			return default(long);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x45F5B8", Offset = "0x45F5B8", VA = "0x45F5B8")]
		internal static long pvr_Achievements_GetDefinitionsByName(string[] names, int v)
		{
			return default(long);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x45F8BC", Offset = "0x45F8BC", VA = "0x45F8BC")]
		internal static long pvr_Achievements_GetProgressByName(string[] names, int v)
		{
			return default(long);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x45FB6C", Offset = "0x45FB6C", VA = "0x45FB6C")]
		internal static long pvr_Achievements_Unlock(string name)
		{
			return default(long);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x45FEC8", Offset = "0x45FEC8", VA = "0x45FEC8")]
		internal static long pvr_HTTP_GetWithMessageType(string nextUrl, Pvr_Message.MessageType messageType)
		{
			return default(long);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x4612E8", Offset = "0x4612E8", VA = "0x4612E8")]
		internal static long pvr_Message_GetType(AndroidJavaObject popMessage)
		{
			return default(long);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x4613F8", Offset = "0x4613F8", VA = "0x4613F8")]
		internal static bool pvr_Message_IsError(AndroidJavaObject popMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4614A4", Offset = "0x4614A4", VA = "0x4614A4")]
		internal static long pvr_Message_GetRequestID(AndroidJavaObject popMessage)
		{
			return default(long);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x460D24", Offset = "0x460D24", VA = "0x460D24")]
		internal static string pvr_Message_GetString(AndroidJavaObject popMessage)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x461550", Offset = "0x461550", VA = "0x461550")]
		internal static bool pvr_AchievementUpdate_GetJustUnlocked(AndroidJavaObject popMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x461694", Offset = "0x461694", VA = "0x461694")]
		internal static string pvr_AchievementUpdate_GetName(AndroidJavaObject popMessage)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x461804", Offset = "0x461804", VA = "0x461804")]
		internal static int pvr_AchievementProgressArray_GetSize(AndroidJavaObject msg)
		{
			return default(int);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x461948", Offset = "0x461948", VA = "0x461948")]
		internal static AndroidJavaObject pvr_AchievementProgressArray_GetElement(AndroidJavaObject msg, int index)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x461B00", Offset = "0x461B00", VA = "0x461B00")]
		internal static string pvr_AchievementProgressArray_GetNextUrl(AndroidJavaObject msg)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x461C70", Offset = "0x461C70", VA = "0x461C70")]
		internal static string pvr_AchievementProgress_GetBitfield(AndroidJavaObject msg)
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x461DE0", Offset = "0x461DE0", VA = "0x461DE0")]
		internal static long pvr_AchievementProgress_GetCount(AndroidJavaObject msg)
		{
			return default(long);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x461F24", Offset = "0x461F24", VA = "0x461F24")]
		internal static bool pvr_AchievementProgress_GetIsUnlocked(AndroidJavaObject msg)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x462068", Offset = "0x462068", VA = "0x462068")]
		internal static string pvr_AchievementProgress_GetName(AndroidJavaObject msg)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4621D8", Offset = "0x4621D8", VA = "0x4621D8")]
		internal static DateTime pvr_AchievementProgress_GetUnlockTime(AndroidJavaObject msg)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x462380", Offset = "0x462380", VA = "0x462380")]
		internal static DateTime DateTimeFromNative(long seconds_since_the_one_true_epoch)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x462434", Offset = "0x462434", VA = "0x462434")]
		internal static int pvr_AchievementDefinitionArray_GetSize(AndroidJavaObject msg)
		{
			return default(int);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x462578", Offset = "0x462578", VA = "0x462578")]
		internal static AndroidJavaObject pvr_AchievementDefinitionArray_GetElement(AndroidJavaObject msg, int index)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x462730", Offset = "0x462730", VA = "0x462730")]
		internal static string pvr_AchievementDefinitionArray_GetNextUrl(AndroidJavaObject msg)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x4628A0", Offset = "0x4628A0", VA = "0x4628A0")]
		internal static AchievementType pvr_AchievementDefinition_GetType(AndroidJavaObject msg)
		{
			return default(AchievementType);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x462A48", Offset = "0x462A48", VA = "0x462A48")]
		internal static string pvr_AchievementDefinition_GetName(AndroidJavaObject msg)
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x462BB8", Offset = "0x462BB8", VA = "0x462BB8")]
		internal static int pvr_AchievementDefinition_GetBitfieldLength(AndroidJavaObject msg)
		{
			return default(int);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x462CFC", Offset = "0x462CFC", VA = "0x462CFC")]
		internal static long pvr_AchievementDefinition_GetTarget(AndroidJavaObject msg)
		{
			return default(long);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x462E40", Offset = "0x462E40", VA = "0x462E40")]
		internal static string pvr_AchievementDefinition_GetTitle(AndroidJavaObject msg)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x462FB0", Offset = "0x462FB0", VA = "0x462FB0")]
		internal static string pvr_AchievementDefinition_GetUnlockedDescription(AndroidJavaObject msg)
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x463120", Offset = "0x463120", VA = "0x463120")]
		internal static string pvr_AchievementDefinition_GetLockedIcon(AndroidJavaObject msg)
		{
			return null;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x463290", Offset = "0x463290", VA = "0x463290")]
		internal static bool pvr_AchievementDefinition_GetIsSecrect(AndroidJavaObject msg)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4633D4", Offset = "0x4633D4", VA = "0x4633D4")]
		internal static string pvr_AchievementDefinition_GetUnlockedIcon(AndroidJavaObject msg)
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x463544", Offset = "0x463544", VA = "0x463544")]
		internal static string pvr_AchievementDefinition_GetDescription(AndroidJavaObject msg)
		{
			return null;
		}
	}
}
[Token(Token = "0x200002E")]
public class AchievementSample : MonoBehaviour
{
	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Text dataOutput;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public InputField getDefinitionsByNameInputField;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public InputField getProgressByNameInputField;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InputField unLockInputField;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public InputField addCountInputField;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public InputField addFieldsInputField;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x349CC4", Offset = "0x349CC4", VA = "0x349CC4")]
	public AchievementSample()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x349CCC", Offset = "0x349CCC", VA = "0x349CCC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x349D4C", Offset = "0x349D4C", VA = "0x349D4C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x349DCC", Offset = "0x349DCC", VA = "0x349DCC")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x34A024", Offset = "0x34A024", VA = "0x34A024")]
	private void Update()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x34A034", Offset = "0x34A034", VA = "0x34A034")]
	public void AsyncInitialize()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x34A0D4", Offset = "0x34A0D4", VA = "0x34A0D4")]
	public void GetDefinitionsByName()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x34A3B8", Offset = "0x34A3B8", VA = "0x34A3B8")]
	public void GetProgressByName()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x34A69C", Offset = "0x34A69C", VA = "0x34A69C")]
	public void GetAllDefinitions()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x34A808", Offset = "0x34A808", VA = "0x34A808")]
	public void GetAllProgress()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x34A974", Offset = "0x34A974", VA = "0x34A974")]
	public void UnLock()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x34ABE8", Offset = "0x34ABE8", VA = "0x34ABE8")]
	public void AddCount()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x34B07C", Offset = "0x34B07C", VA = "0x34B07C")]
	public void AddFields()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x349F58", Offset = "0x349F58", VA = "0x349F58")]
	private void achievementInit()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x34A73C", Offset = "0x34A73C", VA = "0x34A73C")]
	private void getAchievementAllDefinition()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x34A8A8", Offset = "0x34A8A8", VA = "0x34A8A8")]
	private void getAchievementAllProgress()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x34B2BC", Offset = "0x34B2BC", VA = "0x34B2BC")]
	private void addFieldsAchievement(string achievementName, string fields)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x34AF54", Offset = "0x34AF54", VA = "0x34AF54")]
	private void addCountAchievement(string achievementName, string count)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x34AB14", Offset = "0x34AB14", VA = "0x34AB14")]
	private void unlockAchievement(string achievementName)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x34A5C8", Offset = "0x34A5C8", VA = "0x34A5C8")]
	private void getAchievementProgress(string[] achievementNames)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x34A2E4", Offset = "0x34A2E4", VA = "0x34A2E4")]
	private void getAchievementDefinition(string[] achievementNames)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x349E44", Offset = "0x349E44", VA = "0x349E44")]
	private void printOutputLine(string newLine)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x34B398", Offset = "0x34B398", VA = "0x34B398")]
	private void achievementAllDefinitionCallback(Pvr_Message<Pvr_AchievementDefinitionList> msg)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x34BF98", Offset = "0x34BF98", VA = "0x34BF98")]
	private void achievementAllProgressCallback(Pvr_Message<Pvr_AchievementProgressList> msg)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x34C87C", Offset = "0x34C87C", VA = "0x34C87C")]
	private void achievementFieldsCallback(Pvr_Message msg)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x34CC40", Offset = "0x34CC40", VA = "0x34CC40")]
	private void achievementCountCallback(Pvr_Message msg)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x34D004", Offset = "0x34D004", VA = "0x34D004")]
	private void achievementUnlockCallback(Pvr_Message msg)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x34D3C8", Offset = "0x34D3C8", VA = "0x34D3C8")]
	private void achievementProgressCallback(Pvr_Message<Pvr_AchievementProgressList> msg)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x34DAF0", Offset = "0x34DAF0", VA = "0x34DAF0")]
	private void achievementDefinitionCallback(Pvr_Message<Pvr_AchievementDefinitionList> msg)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x34E32C", Offset = "0x34E32C", VA = "0x34E32C")]
	private void initAchievementCallback(Pvr_Message msg)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x34E6F0", Offset = "0x34E6F0", VA = "0x34E6F0")]
	private void LoginCallback(string LoginInfo)
	{
	}
}
namespace Pvr_UnitySDKAPI.Achievement
{
	[Token(Token = "0x200002F")]
	public class Pvr_AchievementDefinition
	{
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly AchievementType Type;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly string Name;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int BitfieldLength;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly long Target;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string Title;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly string Description;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string UnlockedDescription;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public readonly string UnlockedIcon;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string LockedIcon;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public readonly bool IsSecrect;

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x463944", Offset = "0x463944", VA = "0x463944")]
		public Pvr_AchievementDefinition(AndroidJavaObject msg)
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class Pvr_AchievementDefinitionList : Pvr_DeserializableList<Pvr_AchievementDefinition>
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x460514", Offset = "0x460514", VA = "0x460514")]
		public Pvr_AchievementDefinitionList(AndroidJavaObject msg)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class Pvr_AchievementProgress
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string Bitfield;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly long Count;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly bool IsUnlocked;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly string Name;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly DateTime UnlockTime;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x463A44", Offset = "0x463A44", VA = "0x463A44")]
		public Pvr_AchievementProgress(AndroidJavaObject msg)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Pvr_AchievementProgressList : Pvr_DeserializableList<Pvr_AchievementProgress>
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x460824", Offset = "0x460824", VA = "0x460824")]
		public Pvr_AchievementProgressList(AndroidJavaObject msg)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class Pvr_AchievementUpdate
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly bool JustUnlocked;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly string Name;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x460B34", Offset = "0x460B34", VA = "0x460B34")]
		public Pvr_AchievementUpdate(AndroidJavaObject msg)
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1616B4", Offset = "0x1616B4")]
	public class Pvr_DeserializableList<T> : IList<T>, IEnumerable, ICollection<T>, IEnumerable<T>
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected List<T> data;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected string nextUrl;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected string previousUrl;

		[Token(Token = "0x1700001E")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[Token(Token = "0x600016B")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public int Count
		{
			[Token(Token = "0x600016A")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000020")]
		public T Item
		{
			[Token(Token = "0x600016D")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x600016E")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool HasNextPage
		{
			[Token(Token = "0x6000179")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public bool HasPreviousPage
		{
			[Token(Token = "0x600017A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public string NextUrl
		{
			[Token(Token = "0x600017B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public string PreviousUrl
		{
			[Token(Token = "0x600017C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000169")]
		public Pvr_DeserializableList()
		{
		}

		[Token(Token = "0x600016C")]
		public int IndexOf(T obj)
		{
			return default(int);
		}

		[Token(Token = "0x600016F")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000170")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000171")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000173")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000175")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000177")]
		private IEnumerator GetEnumerator1()
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000035")]
	public static class Pvr_Callback
	{
		[Token(Token = "0x2000036")]
		private class RequestCallback
		{
			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Pvr_Message.Callback messageCallback;

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x4643E8", Offset = "0x4643E8", VA = "0x4643E8")]
			public RequestCallback()
			{
			}

			[Token(Token = "0x6000184")]
			[Address(RVA = "0x4643F0", Offset = "0x4643F0", VA = "0x4643F0")]
			public RequestCallback(Pvr_Message.Callback callback)
			{
			}

			[Token(Token = "0x6000185")]
			[Address(RVA = "0x464410", Offset = "0x464410", VA = "0x464410", Slot = "4")]
			public virtual void HandleMessage(Pvr_Message msg)
			{
			}
		}

		[Token(Token = "0x2000037")]
		private sealed class RequestCallback<T> : RequestCallback
		{
			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Pvr_Message<T>.Callback callback;

			[Token(Token = "0x6000186")]
			public RequestCallback(Pvr_Message<T>.Callback callback)
			{
			}

			[Token(Token = "0x6000187")]
			public override void HandleMessage(Pvr_Message msg)
			{
			}
		}

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<long, Request> requestIDsToRequests;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Dictionary<Pvr_Message.MessageType, RequestCallback> notificationCallbacks;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x463B1C", Offset = "0x463B1C", VA = "0x463B1C")]
		internal static void AddRequest(Request request)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x463D98", Offset = "0x463D98", VA = "0x463D98")]
		internal static void RunCallbacks()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x464150", Offset = "0x464150", VA = "0x464150")]
		internal static void RunLimitedCallbacks(uint limit)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x464220", Offset = "0x464220", VA = "0x464220")]
		internal static void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x463EB4", Offset = "0x463EB4", VA = "0x463EB4")]
		internal static void HandleMessage(Pvr_Message msg)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class Pvr_CallbackRunner : MonoBehaviour
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool IsPersistantBetweenSceneLoads;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4647C4", Offset = "0x4647C4", VA = "0x4647C4")]
		public Pvr_CallbackRunner()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x4647D4", Offset = "0x4647D4", VA = "0x4647D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x464920", Offset = "0x464920", VA = "0x464920")]
		private void Update()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4649D8", Offset = "0x4649D8", VA = "0x4649D8")]
		private void OnApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public abstract class Pvr_Message<T> : Pvr_Message
	{
		[Token(Token = "0x200003A")]
		public new delegate void Callback(Pvr_Message<T> message);

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T data;

		[Token(Token = "0x17000025")]
		public T Data
		{
			[Token(Token = "0x600018D")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x600018C")]
		public Pvr_Message(AndroidJavaObject msg)
		{
		}

		[Token(Token = "0x600018E")]
		protected abstract T GetDataFromMessage(AndroidJavaObject msg);
	}
	[Token(Token = "0x200003B")]
	public class Pvr_Message
	{
		[Token(Token = "0x200003C")]
		public delegate void Callback(Pvr_Message message);

		[Token(Token = "0x200003D")]
		public enum MessageType : uint
		{
			[Token(Token = "0x40000A9")]
			Unknown = 0u,
			[Token(Token = "0x40000AA")]
			Achievements_AddCount = 65495601u,
			[Token(Token = "0x40000AB")]
			Achievements_AddFields = 346693929u,
			[Token(Token = "0x40000AC")]
			Achievements_GetAllDefinitions = 64177549u,
			[Token(Token = "0x40000AD")]
			Achievements_GetAllProgress = 1335877149u,
			[Token(Token = "0x40000AE")]
			Achievements_GetDefinitionsByName = 1653670332u,
			[Token(Token = "0x40000AF")]
			Achievements_GetNextAchievementDefinitionArrayPage = 712888917u,
			[Token(Token = "0x40000B0")]
			Achievements_GetNextAchievementProgressArrayPage = 792913703u,
			[Token(Token = "0x40000B1")]
			Achievements_GetProgressByName = 354837425u,
			[Token(Token = "0x40000B2")]
			Achievements_Unlock = 1497156573u,
			[Token(Token = "0x40000B3")]
			Achievements_WriteAchievementProgress = 121027549u,
			[Token(Token = "0x40000B4")]
			Achievements_VerifyAccessToken = 53284924u
		}

		[Token(Token = "0x200003E")]
		internal delegate Pvr_Message ExtraMessageTypesHandler(AndroidJavaObject messageHandle, MessageType message_type);

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private MessageType type;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private long requestID;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Error error;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1616E8", Offset = "0x1616E8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1616E8", Offset = "0x1616E8")]
		private static ExtraMessageTypesHandler <HandleExtraMessageTypes>k__BackingField;

		[Token(Token = "0x17000026")]
		public MessageType Type
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x464314", Offset = "0x464314", VA = "0x464314")]
			get
			{
				return default(MessageType);
			}
		}

		[Token(Token = "0x17000027")]
		public bool IsError
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x464CDC", Offset = "0x464CDC", VA = "0x464CDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public long RequestID
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x46430C", Offset = "0x46430C", VA = "0x46430C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000029")]
		internal static ExtraMessageTypesHandler HandleExtraMessageTypes
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x464F38", Offset = "0x464F38", VA = "0x464F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16172C", Offset = "0x16172C")]
			private get
			{
				return null;
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x464ED4", Offset = "0x464ED4", VA = "0x464ED4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16171C", Offset = "0x16171C")]
			set
			{
			}
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x464A50", Offset = "0x464A50", VA = "0x464A50")]
		public Pvr_Message(AndroidJavaObject msg)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x464CEC", Offset = "0x464CEC", VA = "0x464CEC", Slot = "4")]
		public virtual Error GetError()
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x464CF4", Offset = "0x464CF4", VA = "0x464CF4", Slot = "5")]
		public virtual Pvr_AchievementDefinitionList GetAchievementDefinitions()
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x464CFC", Offset = "0x464CFC", VA = "0x464CFC", Slot = "6")]
		public virtual Pvr_AchievementProgressList GetAchievementProgressList()
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x464D04", Offset = "0x464D04", VA = "0x464D04", Slot = "7")]
		public virtual Pvr_AchievementUpdate GetAchievementUpdate()
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x464D0C", Offset = "0x464D0C", VA = "0x464D0C", Slot = "8")]
		public virtual string GetString()
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x464D14", Offset = "0x464D14", VA = "0x464D14")]
		internal static Pvr_Message ParseMessageHandle(AndroidJavaObject messageHandle)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x463E34", Offset = "0x463E34", VA = "0x463E34")]
		public static Pvr_Message PopMessage()
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	public class MessageWithAchievementDefinitions : Pvr_Message<Pvr_AchievementDefinitionList>
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4603D4", Offset = "0x4603D4", VA = "0x4603D4")]
		public MessageWithAchievementDefinitions(AndroidJavaObject msg)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x460440", Offset = "0x460440", VA = "0x460440", Slot = "5")]
		public override Pvr_AchievementDefinitionList GetAchievementDefinitions()
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4604A4", Offset = "0x4604A4", VA = "0x4604A4", Slot = "9")]
		protected override Pvr_AchievementDefinitionList GetDataFromMessage(AndroidJavaObject msg)
		{
			return null;
		}
	}
	[Token(Token = "0x2000040")]
	public class MessageWithAchievementProgressList : Pvr_Message<Pvr_AchievementProgressList>
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4606E4", Offset = "0x4606E4", VA = "0x4606E4")]
		public MessageWithAchievementProgressList(AndroidJavaObject msg)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x460750", Offset = "0x460750", VA = "0x460750", Slot = "6")]
		public override Pvr_AchievementProgressList GetAchievementProgressList()
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4607B4", Offset = "0x4607B4", VA = "0x4607B4", Slot = "9")]
		protected override Pvr_AchievementProgressList GetDataFromMessage(AndroidJavaObject msg)
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	public class MessageWithAchievementUpdate : Pvr_Message<Pvr_AchievementUpdate>
	{
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4609F4", Offset = "0x4609F4", VA = "0x4609F4")]
		public MessageWithAchievementUpdate(AndroidJavaObject msg)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x460A60", Offset = "0x460A60", VA = "0x460A60", Slot = "7")]
		public override Pvr_AchievementUpdate GetAchievementUpdate()
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x460AC4", Offset = "0x460AC4", VA = "0x460AC4", Slot = "9")]
		protected override Pvr_AchievementUpdate GetDataFromMessage(AndroidJavaObject msg)
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	public class MessageWithString : Pvr_Message<string>
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x460BD4", Offset = "0x460BD4", VA = "0x460BD4")]
		public MessageWithString(AndroidJavaObject msg)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x460C40", Offset = "0x460C40", VA = "0x460C40", Slot = "8")]
		public override string GetString()
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x460CA4", Offset = "0x460CA4", VA = "0x460CA4", Slot = "9")]
		protected override string GetDataFromMessage(AndroidJavaObject msg)
		{
			return null;
		}
	}
	[Token(Token = "0x2000043")]
	public class Error
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly int Code;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly int HttpCode;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Message;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4603A4", Offset = "0x4603A4", VA = "0x4603A4")]
		public Error(int code, string message, int httpCode)
		{
		}
	}
	[Token(Token = "0x2000044")]
	public sealed class Pvr_Request<T> : Request
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Pvr_Message<T>.Callback callback_;

		[Token(Token = "0x60001B5")]
		public Pvr_Request(long requestID)
		{
		}

		[Token(Token = "0x60001B6")]
		public Pvr_Request<T> OnComplete(Pvr_Message<T>.Callback callback)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		public override void HandleMessage(Pvr_Message msg)
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class Request
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Pvr_Message.Callback callback_;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16173C", Offset = "0x16173C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x16173C", Offset = "0x16173C")]
		private long <RequestID>k__BackingField;

		[Token(Token = "0x1700002A")]
		public long RequestID
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x463D90", Offset = "0x463D90", VA = "0x463D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161770", Offset = "0x161770")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x4654A0", Offset = "0x4654A0", VA = "0x4654A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161780", Offset = "0x161780")]
			set
			{
			}
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x465478", Offset = "0x465478", VA = "0x465478")]
		public Request(long requestID)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4654B0", Offset = "0x4654B0", VA = "0x4654B0")]
		public Request OnComplete(Pvr_Message.Callback callback)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x46553C", Offset = "0x46553C", VA = "0x46553C", Slot = "4")]
		public virtual void HandleMessage(Pvr_Message msg)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x464928", Offset = "0x464928", VA = "0x464928")]
		public static void RunCallbacks(uint limit = 0u)
		{
		}
	}
}
namespace BoundarySystem_Ext
{
	[Token(Token = "0x2000046")]
	internal static class Pvr_BoundaryAPI
	{
		[Token(Token = "0x40000BB")]
		private const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x34E7F8", Offset = "0x34E7F8", VA = "0x34E7F8")]
		public static extern void Pvr_StartSDKBoundary();

		[PreserveSig]
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x34E8A8", Offset = "0x34E8A8", VA = "0x34E8A8")]
		public static extern void Pvr_ShutdownSDKBoundary();

		[PreserveSig]
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x34E958", Offset = "0x34E958", VA = "0x34E958")]
		private static extern int Pvr_GetMainSensorStateExt(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber);

		[PreserveSig]
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x34EA58", Offset = "0x34EA58", VA = "0x34EA58")]
		private static extern IntPtr Pvr_GetCameraData_Ext();

		[PreserveSig]
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x34EB08", Offset = "0x34EB08", VA = "0x34EB08")]
		public static extern void Pvr_ResetVrModebyForce();

		[PreserveSig]
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x34EBB8", Offset = "0x34EBB8", VA = "0x34EBB8")]
		private static extern bool Pvr_ResumeBoundaryForSTS();

		[PreserveSig]
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x34EC70", Offset = "0x34EC70", VA = "0x34EC70")]
		private static extern void Pvr_PauseBoundaryForSTS();

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x34ED20", Offset = "0x34ED20", VA = "0x34ED20")]
		public static int UPvr_GetMainSensorStateExt(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber)
		{
			return default(int);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x34ED70", Offset = "0x34ED70", VA = "0x34ED70")]
		public static IntPtr UPvr_GetCameraData_Ext()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x34EDBC", Offset = "0x34EDBC", VA = "0x34EDBC")]
		public static bool UPvr_ResumeBoundaryForSTS()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x34EDC0", Offset = "0x34EDC0", VA = "0x34EDC0")]
		public static void UPvr_PauseBoundaryForSTS()
		{
		}

		[Token(Token = "0x60001C9")]
		public static IntPtr StructToIntPtr<T>(T info)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001CA")]
		public static T IntPtrToStruct<T>(IntPtr info)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000047")]
	internal static class Pvr_SafeAreaAlgoAPI
	{
		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x161790", Offset = "0x161790")]
		public delegate void SafeAreaCallback(IntPtr lineCollectionPtr, IntPtr safeAreaRectPtr);

		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x1617A4", Offset = "0x1617A4")]
		public delegate void SafeAreaCallbackShrink(IntPtr lineCollectionPtr, IntPtr safeAreaDetailRectPtr);

		[Token(Token = "0x200004A")]
		public struct GSAPoint3i
		{
			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;
		}

		[Token(Token = "0x200004B")]
		public struct GSALine
		{
			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr pointArray;

			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int pointCount;
		}

		[Token(Token = "0x200004C")]
		public struct GSALineCollection
		{
			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr lineArray;

			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int lineCount;
		}

		[Token(Token = "0x200004D")]
		public struct GSALegalData
		{
			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int overMaxRange;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int includeBigGrap;

			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int bigGapNum;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int centerOut;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int removeNarrow;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int overMaxRange_more;

			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int validShrinkArea;
		}

		[Token(Token = "0x200004E")]
		public struct GSARect
		{
			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GSAPoint3i leftup;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public GSAPoint3i leftdown;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GSAPoint3i rightup;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public GSAPoint3i rightdown;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GSAPoint3i center;

			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public uint width;

			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint height;

			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int isLegal;

			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public GSALegalData legalData;
		}

		[Token(Token = "0x40000BC")]
		private const string LibFileName = "SafetyArea";

		[PreserveSig]
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x34F1B0", Offset = "0x34F1B0", VA = "0x34F1B0")]
		private static extern int GSAInit(int width, int height);

		[PreserveSig]
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x34F278", Offset = "0x34F278", VA = "0x34F278")]
		private static extern int GSAShutDown();

		[PreserveSig]
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x34F328", Offset = "0x34F328", VA = "0x34F328")]
		private static extern int GSASetCallback(SafeAreaCallback cb);

		[PreserveSig]
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x34F3F4", Offset = "0x34F3F4", VA = "0x34F3F4")]
		private static extern int GSASetCallbackShrink(SafeAreaCallbackShrink cb);

		[PreserveSig]
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x34F4C0", Offset = "0x34F4C0", VA = "0x34F4C0")]
		private static extern int GSAUpDateData(IntPtr lineCollectionPtr);

		[PreserveSig]
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x34F580", Offset = "0x34F580", VA = "0x34F580")]
		private static extern int GSASetConfigFilePath(IntPtr configPath);

		[PreserveSig]
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x34F640", Offset = "0x34F640", VA = "0x34F640")]
		private static extern bool GSAGetClosedAreaUpdateFlag();

		[PreserveSig]
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x34F6F8", Offset = "0x34F6F8", VA = "0x34F6F8")]
		private static extern int GSALoadSafetyArea(IntPtr lineCollectionPtr);

		[PreserveSig]
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x34F7B8", Offset = "0x34F7B8", VA = "0x34F7B8")]
		private static extern double GSABoundaryDetector(ref GSAPoint3i pointPtr);

		[PreserveSig]
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x34F878", Offset = "0x34F878", VA = "0x34F878")]
		private static extern int GSALoadSafetyArea2(IntPtr lineCollectionPtr, bool isPlayArea);

		[PreserveSig]
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x34F940", Offset = "0x34F940", VA = "0x34F940")]
		private static extern double GSABoundaryDetector2(ref GSAPoint3i point, bool isPlayArea, ref GSAPoint3i closestPoint, ref GSAPoint3i normalDir);

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x34FA14", Offset = "0x34FA14", VA = "0x34FA14")]
		public static int Pvr_GSAInit(int width, int height)
		{
			return default(int);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x34FA18", Offset = "0x34FA18", VA = "0x34FA18")]
		public static int Pvr_GSASetCallback(SafeAreaCallback cb)
		{
			return default(int);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x34FA1C", Offset = "0x34FA1C", VA = "0x34FA1C")]
		public static int Pvr_GSASetCallbackShrink(SafeAreaCallbackShrink cb)
		{
			return default(int);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x34FA20", Offset = "0x34FA20", VA = "0x34FA20")]
		public static int Pvr_GSAUpDateData(IntPtr lineCollectionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x34FA24", Offset = "0x34FA24", VA = "0x34FA24")]
		public static bool Pvr_GSAGetClosedAreaUpdateFlag()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x34FA28", Offset = "0x34FA28", VA = "0x34FA28")]
		public static int Pvr_GSASetConfigFilePath(string configPath)
		{
			return default(int);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x34FAD4", Offset = "0x34FAD4", VA = "0x34FAD4")]
		public static int Pvr_GSALoadSafetyArea(IntPtr lineCollectionPtr)
		{
			return default(int);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x34FAD8", Offset = "0x34FAD8", VA = "0x34FAD8")]
		public static double Pvr_GSABoundaryDetector(ref GSAPoint3i point)
		{
			return default(double);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x34FADC", Offset = "0x34FADC", VA = "0x34FADC")]
		public static int Pvr_GSAShutDown()
		{
			return default(int);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x34FAE0", Offset = "0x34FAE0", VA = "0x34FAE0")]
		public static int Pvr_GSALoadSafetyArea2(IntPtr lineCollectionPtr, bool isPlayArea)
		{
			return default(int);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x34FAE4", Offset = "0x34FAE4", VA = "0x34FAE4")]
		public static double Pvr_GSABoundaryDetector2(ref GSAPoint3i point, bool isPlayArea, ref GSAPoint3i closestPoint, ref GSAPoint3i normalDir)
		{
			return default(double);
		}
	}
	[Token(Token = "0x200004F")]
	public class Pvr_BoundarySystem
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Pvr_BoundarySystem instance;

		[Token(Token = "0x40000D5")]
		public const int CameraImageWidth = 1280;

		[Token(Token = "0x40000D6")]
		public const int CameraImageHeight = 400;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr CameraFramePtr;

		[Token(Token = "0x1700002B")]
		public static Pvr_BoundarySystem Instance
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x34EE24", Offset = "0x34EE24", VA = "0x34EE24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x34EDC4", Offset = "0x34EDC4", VA = "0x34EDC4")]
		public Pvr_BoundarySystem()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x34EEC0", Offset = "0x34EEC0", VA = "0x34EEC0")]
		public void OpenBoundary()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x34EEC4", Offset = "0x34EEC4", VA = "0x34EEC4")]
		public void CloseBoundary()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x34EEC8", Offset = "0x34EEC8", VA = "0x34EEC8")]
		public void Reset6Dof()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x34EECC", Offset = "0x34EECC", VA = "0x34EECC")]
		public float[] GetControllerFixedPoseData(int hand)
		{
			return null;
		}
	}
	[Token(Token = "0x2000050")]
	public class Pvr_SafeAreaAlgoModule
	{
		[Token(Token = "0x2000051")]
		public struct ExtraInfo
		{
			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool overMaxRange;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeBigGap;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int bigGapNum;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool centerOut;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool removeNarrow;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public bool overMaxRange_more;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int validShrinkArea;
		}

		[Token(Token = "0x2000052")]
		public struct BoundaryPlayerArea
		{
			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 lowerleft;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 upperleft;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 upperRight;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 lowerRight;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 center;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public uint width;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint height;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool isLegal;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public ExtraInfo extraInfo;
		}

		[Token(Token = "0x2000053")]
		public delegate void BoundarySystemCallback(BoundaryPlayerArea playAreaInfo, List<Vector3> boundaryPoints, List<List<Vector3>> unusedLines);

		[Token(Token = "0x2000054")]
		public delegate void BoundarySystemCallbackShrink(List<Vector3> rectPoints, List<Vector3> boundaryPoints, List<List<Vector3>> unusedLines);

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Pvr_SafeAreaAlgoModule instance;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private BoundarySystemCallback boundarySystemCallback;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private BoundarySystemCallbackShrink boundarySystemCallbackShrink;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1617B8", Offset = "0x1617B8")]
		private static Pvr_SafeAreaAlgoAPI.SafeAreaCallback <>f__mg$cache0;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1617C8", Offset = "0x1617C8")]
		private static Pvr_SafeAreaAlgoAPI.SafeAreaCallbackShrink <>f__mg$cache1;

		[Token(Token = "0x1700002C")]
		public static Pvr_SafeAreaAlgoModule Instance
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x351698", Offset = "0x351698", VA = "0x351698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x351690", Offset = "0x351690", VA = "0x351690")]
		public Pvr_SafeAreaAlgoModule()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x351738", Offset = "0x351738", VA = "0x351738")]
		public void RegisterCallBack(BoundarySystemCallback callback)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x351740", Offset = "0x351740", VA = "0x351740")]
		public void RegisterCallBackShrink(BoundarySystemCallbackShrink callback)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x351748", Offset = "0x351748", VA = "0x351748")]
		public bool Start()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x351940", Offset = "0x351940", VA = "0x351940")]
		public bool CommitNewLineData(bool isFistLine, Vector3[] points)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x351D8C", Offset = "0x351D8C", VA = "0x351D8C")]
		public bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x351E38", Offset = "0x351E38", VA = "0x351E38")]
		public double QueryDistanceOfPoint(Vector3 point)
		{
			return default(double);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x351EB8", Offset = "0x351EB8", VA = "0x351EB8")]
		public double QueryDistanceOfPoint(Vector3 point, bool isPlayArea, ref Vector3 closestPoint, ref Vector3 normalDir)
		{
			return default(double);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x3501BC", Offset = "0x3501BC", VA = "0x3501BC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1617D8", Offset = "0x1617D8")]
		private static void _SafeAreaCallback(IntPtr lineCollectionPtr, IntPtr safeAreaRectPtr)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x350BD0", Offset = "0x350BD0", VA = "0x350BD0")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x161850", Offset = "0x161850")]
		private static void _SafeAreaCallbackShrink(IntPtr lineCollectionPtr, IntPtr safeAreaDetailRectPtr)
		{
		}
	}
}
namespace Pvr_UnitySDKAPI
{
	[Token(Token = "0x2000055")]
	public class PvrControllerKey
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool State;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public bool PressedDown;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public bool PressedUp;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public bool LongPressed;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool Click;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool Touch;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool TouchDown;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public bool TouchUp;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x6A39D4", Offset = "0x6A39D4", VA = "0x6A39D4")]
		public PvrControllerKey()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class ControllerHand
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PvrControllerKey App;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public PvrControllerKey Touch;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PvrControllerKey Home;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public PvrControllerKey VolumeDown;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PvrControllerKey VolumeUp;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PvrControllerKey Trigger;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PvrControllerKey X;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PvrControllerKey Y;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PvrControllerKey A;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PvrControllerKey B;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PvrControllerKey Left;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PvrControllerKey Right;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PvrControllerKey Thumbrest;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector2 TouchPadPosition;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int TriggerNum;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int GripValue;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Quaternion Rotation;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 Position;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int Battery;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public ControllerState ConnectState;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SwipeDirection SwipeDirection;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public TouchPadClick TouchPadClick;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool isShowBoundary;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x6A37AC", Offset = "0x6A37AC", VA = "0x6A37AC")]
		public ControllerHand()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public enum ControllerState
	{
		[Token(Token = "0x400010D")]
		Error = -1,
		[Token(Token = "0x400010E")]
		DisConnected,
		[Token(Token = "0x400010F")]
		Connected
	}
	[Token(Token = "0x2000058")]
	public enum Pvr_KeyCode
	{
		[Token(Token = "0x4000111")]
		None = 0,
		[Token(Token = "0x4000112")]
		APP = 1,
		[Token(Token = "0x4000113")]
		TOUCHPAD = 2,
		[Token(Token = "0x4000114")]
		HOME = 4,
		[Token(Token = "0x4000115")]
		VOLUMEUP = 8,
		[Token(Token = "0x4000116")]
		VOLUMEDOWN = 16,
		[Token(Token = "0x4000117")]
		TRIGGER = 32,
		[Token(Token = "0x4000118")]
		A = 64,
		[Token(Token = "0x4000119")]
		B = 128,
		[Token(Token = "0x400011A")]
		X = 256,
		[Token(Token = "0x400011B")]
		Y = 512,
		[Token(Token = "0x400011C")]
		Left = 1024,
		[Token(Token = "0x400011D")]
		Right = 2048,
		[Token(Token = "0x400011E")]
		Thumbrest = 4096,
		[Token(Token = "0x400011F")]
		Any = -1
	}
	[Token(Token = "0x2000059")]
	public enum SwipeDirection
	{
		[Token(Token = "0x4000121")]
		No,
		[Token(Token = "0x4000122")]
		SwipeUp,
		[Token(Token = "0x4000123")]
		SwipeDown,
		[Token(Token = "0x4000124")]
		SwipeLeft,
		[Token(Token = "0x4000125")]
		SwipeRight
	}
	[Token(Token = "0x200005A")]
	public enum TouchPadClick
	{
		[Token(Token = "0x4000127")]
		No,
		[Token(Token = "0x4000128")]
		ClickUp,
		[Token(Token = "0x4000129")]
		ClickDown,
		[Token(Token = "0x400012A")]
		ClickLeft,
		[Token(Token = "0x400012B")]
		ClickRight
	}
	[Token(Token = "0x200005B")]
	public struct Controller
	{
		[Token(Token = "0x400012C")]
		private const float JOYSTICK_THRESHOLD = 0.4f;

		[Token(Token = "0x400012D")]
		public const string LibFileName = "Pvr_UnitySDK";

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x69AE40", Offset = "0x69AE40", VA = "0x69AE40")]
		public static Vector2 UPvr_GetTouchPadPosition(int hand)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x69AF8C", Offset = "0x69AF8C", VA = "0x69AF8C")]
		public static float UPvr_GetAxis1D(int hand, Pvr_KeyCode key)
		{
			return default(float);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x69B1A4", Offset = "0x69B1A4", VA = "0x69B1A4")]
		public static Vector2 UPvr_GetAxis2D(int hand)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x69B670", Offset = "0x69B670", VA = "0x69B670")]
		public static bool UPvr_GetJoystickUp(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x69B9FC", Offset = "0x69B9FC", VA = "0x69B9FC")]
		public static bool UPvr_GetJoystickDown(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x69BD8C", Offset = "0x69BD8C", VA = "0x69BD8C")]
		public static bool UPvr_GetJoystickLeft(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x69C124", Offset = "0x69C124", VA = "0x69C124")]
		public static bool UPvr_GetJoystickRight(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x69C4B8", Offset = "0x69C4B8", VA = "0x69C4B8")]
		public static ControllerState UPvr_GetControllerState(int hand)
		{
			return default(ControllerState);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x69C618", Offset = "0x69C618", VA = "0x69C618")]
		public static Quaternion UPvr_GetControllerQUA(int hand)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x69C780", Offset = "0x69C780", VA = "0x69C780")]
		public static Vector3 UPvr_GetControllerPOS(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x69C8DC", Offset = "0x69C8DC", VA = "0x69C8DC")]
		public static Quaternion UPvr_GetControllerPredictRotation(int hand, float predictTime)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x69CA54", Offset = "0x69CA54", VA = "0x69CA54")]
		public static Vector3 UPvr_GetControllerPredictPosition(int hand, float predictTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x69CBC0", Offset = "0x69CBC0", VA = "0x69CBC0")]
		public static int UPvr_GetControllerTriggerValue(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x69CCDC", Offset = "0x69CCDC", VA = "0x69CCDC")]
		public static int UPvr_GetControllerPower(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x69CDF8", Offset = "0x69CDF8", VA = "0x69CDF8")]
		public static int UPvr_GetControllerPowerByPercent(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x69CF1C", Offset = "0x69CF1C", VA = "0x69CF1C")]
		public static SwipeDirection UPvr_GetSwipeDirection(int hand)
		{
			return default(SwipeDirection);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x69D038", Offset = "0x69D038", VA = "0x69D038")]
		public static TouchPadClick UPvr_GetTouchPadClick(int hand)
		{
			return default(TouchPadClick);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x69D154", Offset = "0x69D154", VA = "0x69D154")]
		public static bool UPvr_GetKey(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x69DB2C", Offset = "0x69DB2C", VA = "0x69DB2C")]
		public static bool UPvr_GetKeyDown(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x69E504", Offset = "0x69E504", VA = "0x69E504")]
		public static bool UPvr_GetKeyUp(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x69EEDC", Offset = "0x69EEDC", VA = "0x69EEDC")]
		public static bool UPvr_GetTouch(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x69F484", Offset = "0x69F484", VA = "0x69F484")]
		public static bool UPvr_GetTouchDown(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x69FA2C", Offset = "0x69FA2C", VA = "0x69FA2C")]
		public static bool UPvr_GetTouchUp(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x69FFD4", Offset = "0x69FFD4", VA = "0x69FFD4")]
		public static bool UPvr_GetKeyClick(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x6A09AC", Offset = "0x6A09AC", VA = "0x6A09AC")]
		public static bool UPvr_GetKeyLongPressed(int hand, Pvr_KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x6A1384", Offset = "0x6A1384", VA = "0x6A1384")]
		public static bool UPvr_IsTouching(int hand)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x6A15AC", Offset = "0x6A15AC", VA = "0x6A15AC")]
		public static void UPvr_SetHandNess(Pvr_Controller.UserHandNess hand)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x6A16BC", Offset = "0x6A16BC", VA = "0x6A16BC")]
		public static Pvr_Controller.UserHandNess UPvr_GetHandNess()
		{
			return default(Pvr_Controller.UserHandNess);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x6A1758", Offset = "0x6A1758", VA = "0x6A1758")]
		public static int UPvr_GetPreferenceDevice()
		{
			return default(int);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x6A1860", Offset = "0x6A1860", VA = "0x6A1860")]
		public static bool UPvr_IsEnbleTrigger()
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x6A1904", Offset = "0x6A1904", VA = "0x6A1904")]
		public static int UPvr_GetDeviceType()
		{
			return default(int);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x6A19A0", Offset = "0x6A19A0", VA = "0x6A19A0")]
		public static int UPvr_GetMainHandNess()
		{
			return default(int);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x6A1A3C", Offset = "0x6A1A3C", VA = "0x6A1A3C")]
		public static void UPvr_SetMainHandNess(int hand)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x6A1AE8", Offset = "0x6A1AE8", VA = "0x6A1AE8")]
		public static int UPvr_GetControllerAbility(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x6A1B94", Offset = "0x6A1B94", VA = "0x6A1B94")]
		public static void UPvr_VibrateNeo2Controller(float strength, int time, int hand)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x6A1C5C", Offset = "0x6A1C5C", VA = "0x6A1C5C")]
		public static void UPvr_VibrateController(float strength, int time, int hand)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x6A1D24", Offset = "0x6A1D24", VA = "0x6A1D24")]
		public static int UPvr_GetControllerBindingState(int hand)
		{
			return default(int);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x6A1DD0", Offset = "0x6A1DD0", VA = "0x6A1DD0")]
		public static Vector3 UPvr_GetVelocity(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x6A1E84", Offset = "0x6A1E84", VA = "0x6A1E84")]
		public static Vector3 UPvr_GetAngularVelocity(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x6A1F38", Offset = "0x6A1F38", VA = "0x6A1F38")]
		public static Vector3 UPvr_GetAcceleration(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x6A1FEC", Offset = "0x6A1FEC", VA = "0x6A1FEC")]
		public static Vector3 UPvr_GetAngularAcceleration(int hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x6A20A0", Offset = "0x6A20A0", VA = "0x6A20A0")]
		public static void UPvr_ScanController()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x6A2144", Offset = "0x6A2144", VA = "0x6A2144")]
		public static void UPvr_StopScanController()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x6A21E8", Offset = "0x6A21E8", VA = "0x6A21E8")]
		public static void UPvr_ConnectController(string mac)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x6A2340", Offset = "0x6A2340", VA = "0x6A2340")]
		public static void UPvr_DisConnectController()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x6A23E4", Offset = "0x6A23E4", VA = "0x6A23E4")]
		public static void UPvr_ResetController(int hand)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x6A2490", Offset = "0x6A2490", VA = "0x6A2490")]
		public static string UPvr_GetControllerVersion()
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x6A2534", Offset = "0x6A2534", VA = "0x6A2534")]
		public static void UPvr_GetDeviceVersion(int deviceType)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x6A25E0", Offset = "0x6A25E0", VA = "0x6A25E0")]
		public static void UPvr_GetControllerSnCode(int controllerSerialNum)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x6A268C", Offset = "0x6A268C", VA = "0x6A268C")]
		public static void UPvr_SetControllerUnbind(int controllerSerialNum)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x6A2738", Offset = "0x6A2738", VA = "0x6A2738")]
		public static void UPvr_SetStationRestart()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x6A27DC", Offset = "0x6A27DC", VA = "0x6A27DC")]
		public static void UPvr_StartStationOtaUpdate()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x6A2880", Offset = "0x6A2880", VA = "0x6A2880")]
		public static void UPvr_StartControllerOtaUpdate(int mode, int controllerSerialNum)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x6A2934", Offset = "0x6A2934", VA = "0x6A2934")]
		public static void UPvr_EnterPairMode(int controllerSerialNum)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x6A29E0", Offset = "0x6A29E0", VA = "0x6A29E0")]
		public static void UPvr_SetControllerShutdown(int controllerSerialNum)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x6A2A8C", Offset = "0x6A2A8C", VA = "0x6A2A8C")]
		public static int UPvr_GetStationPairState()
		{
			return default(int);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x6A2B30", Offset = "0x6A2B30", VA = "0x6A2B30")]
		public static int UPvr_GetStationOtaUpdateProgress()
		{
			return default(int);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x6A2BD4", Offset = "0x6A2BD4", VA = "0x6A2BD4")]
		public static int UPvr_GetControllerOtaUpdateProgress()
		{
			return default(int);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x6A2C78", Offset = "0x6A2C78", VA = "0x6A2C78")]
		public static void UPvr_GetControllerVersionAndSN(int controllerSerialNum)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x6A2D24", Offset = "0x6A2D24", VA = "0x6A2D24")]
		public static void UPvr_GetControllerUniqueID()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x6A2E6C", Offset = "0x6A2E6C", VA = "0x6A2E6C")]
		public void UPvr_InterruptStationPairMode()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x6A2F1C", Offset = "0x6A2F1C", VA = "0x6A2F1C")]
		public void UPvr_StartCV2PairingMode(int deviceType)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x6A2FCC", Offset = "0x6A2FCC", VA = "0x6A2FCC")]
		public void UPvr_StopCV2PairingMode(int deviceType)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x6A2FD0", Offset = "0x6A2FD0", VA = "0x6A2FD0")]
		public static void UPvr_SetArmModelParameters(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x6A30D8", Offset = "0x6A30D8", VA = "0x6A30D8")]
		public static void UPvr_CalcArmModelParameters(float[] headOrientation, float[] controllerOrientation, float[] controllerPrimary)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x6A31D4", Offset = "0x6A31D4", VA = "0x6A31D4")]
		public static void UPvr_GetPointerPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x6A32B0", Offset = "0x6A32B0", VA = "0x6A32B0")]
		public static void UPvr_GetElbowPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x6A338C", Offset = "0x6A338C", VA = "0x6A338C")]
		public static void UPvr_GetWristPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x6A3468", Offset = "0x6A3468", VA = "0x6A3468")]
		public static void UPvr_GetShoulderPose(float[] rotation, float[] position)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x6A3544", Offset = "0x6A3544", VA = "0x6A3544")]
		public static void UPvr_IsEnbleHomeKey(bool state)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x6A35F0", Offset = "0x6A35F0", VA = "0x6A35F0")]
		public static void UPvr_SwitchHomeKey(bool state)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x6A369C", Offset = "0x6A369C", VA = "0x6A369C")]
		public static int UPvr_GetControllerSensorStatus(int id)
		{
			return default(int);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x6A3748", Offset = "0x6A3748", VA = "0x6A3748")]
		public static void UPvr_SetControllerOriginOffset(int hand, Vector3 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x6A30F0", Offset = "0x6A30F0", VA = "0x6A30F0")]
		private static extern void Pvr_CalcArmModelParameters(float[] headOrientation, float[] controllerOrientation, float[] gyro);

		[PreserveSig]
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x6A31D8", Offset = "0x6A31D8", VA = "0x6A31D8")]
		private static extern void Pvr_GetPointerPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x6A32B4", Offset = "0x6A32B4", VA = "0x6A32B4")]
		private static extern void Pvr_GetElbowPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x6A3390", Offset = "0x6A3390", VA = "0x6A3390")]
		private static extern void Pvr_GetWristPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x6A346C", Offset = "0x6A346C", VA = "0x6A346C")]
		private static extern void Pvr_GetShoulderPose(float[] rotation, float[] position);

		[PreserveSig]
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x6A2FF8", Offset = "0x6A2FF8", VA = "0x6A2FF8")]
		private static extern void Pvr_SetArmModelParameters(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle);
	}
}
[Token(Token = "0x200005C")]
public class Pvr_Controller : MonoBehaviour
{
	[Token(Token = "0x200005D")]
	public enum UserHandNess
	{
		[Token(Token = "0x4000145")]
		Right,
		[Token(Token = "0x4000146")]
		Left
	}

	[Token(Token = "0x200005E")]
	public enum GazeType
	{
		[Token(Token = "0x4000148")]
		Never,
		[Token(Token = "0x4000149")]
		DuringMotion,
		[Token(Token = "0x400014A")]
		Always
	}

	[Token(Token = "0x200005F")]
	public enum ControllerAxis
	{
		[Token(Token = "0x400014C")]
		Controller,
		[Token(Token = "0x400014D")]
		Wrist,
		[Token(Token = "0x400014E")]
		Elbow,
		[Token(Token = "0x400014F")]
		Shoulder
	}

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject controller0;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject controller1;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UserHandNess handness;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public ControllerAxis Axis;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GazeType Gazetype;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1618C8", Offset = "0x1618C8")]
	public float ElbowHeight;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1618E4", Offset = "0x1618E4")]
	public float ElbowDepth;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x161900", Offset = "0x161900")]
	public float PointerTiltAngle;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float mouseX;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float mouseY;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float mouseZ;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3[] inputDirection;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16191C", Offset = "0x16191C")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x16191C", Offset = "0x16191C")]
	private static Vector3 <pointerPosition>k__BackingField;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161950", Offset = "0x161950")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x161950", Offset = "0x161950")]
	private static Quaternion <pointerRotation>k__BackingField;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161984", Offset = "0x161984")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x161984", Offset = "0x161984")]
	private static Vector3 <elbowPosition>k__BackingField;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1619B8", Offset = "0x1619B8")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1619B8", Offset = "0x1619B8")]
	private static Quaternion <elbowRotation>k__BackingField;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1619EC", Offset = "0x1619EC")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1619EC", Offset = "0x1619EC")]
	private static Vector3 <wristPosition>k__BackingField;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161A20", Offset = "0x161A20")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x161A20", Offset = "0x161A20")]
	private static Quaternion <wristRotation>k__BackingField;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161A54", Offset = "0x161A54")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x161A54", Offset = "0x161A54")]
	private static Vector3 <shoulderPosition>k__BackingField;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161A88", Offset = "0x161A88")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x161A88", Offset = "0x161A88")]
	private static Quaternion <shoulderRotation>k__BackingField;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161ABC", Offset = "0x161ABC")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x161ABC", Offset = "0x161ABC")]
	private static Vector3 <originOffsetL>k__BackingField;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161AF0", Offset = "0x161AF0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x161AF0", Offset = "0x161AF0")]
	private static Vector3 <originOffsetR>k__BackingField;

	[Token(Token = "0x1700002D")]
	public static Vector3 pointerPosition
	{
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x369C64", Offset = "0x369C64", VA = "0x369C64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161B24", Offset = "0x161B24")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x369B74", Offset = "0x369B74", VA = "0x369B74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161B34", Offset = "0x161B34")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public static Quaternion pointerRotation
	{
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x369CD0", Offset = "0x369CD0", VA = "0x369CD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161B44", Offset = "0x161B44")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x369BE8", Offset = "0x369BE8", VA = "0x369BE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161B54", Offset = "0x161B54")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public static Vector3 elbowPosition
	{
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x369FF4", Offset = "0x369FF4", VA = "0x369FF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161B64", Offset = "0x161B64")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x369F04", Offset = "0x369F04", VA = "0x369F04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161B74", Offset = "0x161B74")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public static Quaternion elbowRotation
	{
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x36A060", Offset = "0x36A060", VA = "0x36A060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161B84", Offset = "0x161B84")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x369F78", Offset = "0x369F78", VA = "0x369F78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161B94", Offset = "0x161B94")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public static Vector3 wristPosition
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x369E2C", Offset = "0x369E2C", VA = "0x369E2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161BA4", Offset = "0x161BA4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x369D3C", Offset = "0x369D3C", VA = "0x369D3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161BB4", Offset = "0x161BB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public static Quaternion wristRotation
	{
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x369E98", Offset = "0x369E98", VA = "0x369E98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161BC4", Offset = "0x161BC4")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x369DB0", Offset = "0x369DB0", VA = "0x369DB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161BD4", Offset = "0x161BD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public static Vector3 shoulderPosition
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x36A1BC", Offset = "0x36A1BC", VA = "0x36A1BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161BE4", Offset = "0x161BE4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x36A0CC", Offset = "0x36A0CC", VA = "0x36A0CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161BF4", Offset = "0x161BF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public static Quaternion shoulderRotation
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x36A228", Offset = "0x36A228", VA = "0x36A228")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161C04", Offset = "0x161C04")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x36A140", Offset = "0x36A140", VA = "0x36A140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161C14", Offset = "0x161C14")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public static Vector3 originOffsetL
	{
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x367D48", Offset = "0x367D48", VA = "0x367D48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161C24", Offset = "0x161C24")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x36A294", Offset = "0x36A294", VA = "0x36A294")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161C34", Offset = "0x161C34")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public static Vector3 originOffsetR
	{
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x367DB4", Offset = "0x367DB4", VA = "0x367DB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161C44", Offset = "0x161C44")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x36A308", Offset = "0x36A308", VA = "0x36A308")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161C54", Offset = "0x161C54")]
		set
		{
		}
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x3669F4", Offset = "0x3669F4", VA = "0x3669F4")]
	public Pvr_Controller()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x366A80", Offset = "0x366A80", VA = "0x366A80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x366C18", Offset = "0x366C18", VA = "0x366C18")]
	private void Start()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x366C9C", Offset = "0x366C9C", VA = "0x366C9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x366E34", Offset = "0x366E34", VA = "0x366E34")]
	private void MainControllerChanged(string index)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x366F1C", Offset = "0x366F1C", VA = "0x366F1C")]
	private void HandnessChanged(string index)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x366F20", Offset = "0x366F20", VA = "0x366F20")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x366E38", Offset = "0x366E38", VA = "0x366E38")]
	private void RefreshHandness()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x366F98", Offset = "0x366F98", VA = "0x366F98")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x3671C4", Offset = "0x3671C4", VA = "0x3671C4")]
	private void ShowController()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x3673A8", Offset = "0x3673A8", VA = "0x3673A8")]
	private void CheckControllerState(string data)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x3674B4", Offset = "0x3674B4", VA = "0x3674B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x366F24", Offset = "0x366F24", VA = "0x366F24")]
	public static void ChangeHandNess()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x367A08", Offset = "0x367A08", VA = "0x367A08")]
	private void DoUpdateControler0()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x367AB4", Offset = "0x367AB4", VA = "0x367AB4")]
	private void DoUpdateControler1()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x367B6C", Offset = "0x367B6C", VA = "0x367B6C")]
	private void UpdateControlloerRay(bool update0 = true, bool update1 = true)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x36981C", Offset = "0x36981C", VA = "0x36981C")]
	private Quaternion UpdateSimulatedFrameParams()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x367E20", Offset = "0x367E20", VA = "0x367E20")]
	private void SetArmParaToSo(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x367E54", Offset = "0x367E54", VA = "0x367E54")]
	private void CalcArmModelfromSo(int hand)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x3686AC", Offset = "0x3686AC", VA = "0x3686AC")]
	public void UpdateControllerDataSO(int hand)
	{
	}
}
[Token(Token = "0x2000060")]
public class Pvr_ControllerDemo : MonoBehaviour
{
	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject HeadSetController;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject controller0;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GameObject controller1;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cube;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Ray ray;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private GameObject currentController;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform lastHit;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Transform currentHit;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material normat;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private Material gazemat;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Material clickmat;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool noClick;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject referenceObj;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float rayDefaultLength;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isHasController;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool headcontrolmode;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private RaycastHit hit;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject rayLine;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private GameObject dot;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Transform dragObj;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float disX;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float disY;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float disZ;

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x36A37C", Offset = "0x36A37C", VA = "0x36A37C")]
	public Pvr_ControllerDemo()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x36A390", Offset = "0x36A390", VA = "0x36A390")]
	private void Start()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x36A58C", Offset = "0x36A58C", VA = "0x36A58C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x36A6E8", Offset = "0x36A6E8", VA = "0x36A6E8")]
	private void Update()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x36D190", Offset = "0x36D190", VA = "0x36D190")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x36D23C", Offset = "0x36D23C", VA = "0x36D23C")]
	private void ControllerStateListener(string data)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x36D2E8", Offset = "0x36D2E8", VA = "0x36D2E8")]
	private void CheckControllerStateForGoblin(string state)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x36D3A4", Offset = "0x36D3A4", VA = "0x36D3A4")]
	public void SwitchControlMode()
	{
	}
}
[Token(Token = "0x2000061")]
public class Pvr_ControllerEventsExamples : MonoBehaviour
{
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x36D3A8", Offset = "0x36D3A8", VA = "0x36D3A8")]
	public Pvr_ControllerEventsExamples()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x36D3B0", Offset = "0x36D3B0", VA = "0x36D3B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x36D690", Offset = "0x36D690", VA = "0x36D690")]
	private void UIPointerElementEnter(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x36D794", Offset = "0x36D794", VA = "0x36D794")]
	private void UIPointerElementExit(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x36D898", Offset = "0x36D898", VA = "0x36D898")]
	private void UIPointerElementClick(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x36D99C", Offset = "0x36D99C", VA = "0x36D99C")]
	private void UIPointerElementDragStart(object sender, UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x36DAA0", Offset = "0x36DAA0", VA = "0x36DAA0")]
	private void UIPointerElementDragEnd(object sender, UIPointerEventArgs e)
	{
	}
}
[Token(Token = "0x2000062")]
public class Pvr_ControllerInit : MonoBehaviour
{
	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x161D34", Offset = "0x161D34")]
	private sealed class <RefreshController>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int id;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Pvr_ControllerInit $this;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object $current;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool $disposing;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int $PC;

		[Token(Token = "0x170000AC")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x370764", Offset = "0x370764", VA = "0x370764", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x37076C", Offset = "0x37076C", VA = "0x37076C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x36EF64", Offset = "0x36EF64", VA = "0x36EF64")]
		[DebuggerHidden]
		public <RefreshController>c__Iterator0()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x37016C", Offset = "0x37016C", VA = "0x37016C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x370774", Offset = "0x370774", VA = "0x370774", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x370788", Offset = "0x370788", VA = "0x370788", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private ControllerVariety Variety;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool isCustomModel;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private GameObject goblin;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject g2;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private GameObject neo2L;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject neo2R;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private GameObject neo3L;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject neo3R;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Material standardMat;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Material unlitMat;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int controllerType;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public bool loadModelSuccess;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int systemOrUnity;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private JsonData curControllerData;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private string modelName;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string texFormat;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private string prePath;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string modelFilePath;

	[Token(Token = "0x4000179")]
	private const string goblinTexbasePath = "Controller/controller1/controller1";

	[Token(Token = "0x400017A")]
	private const string g2TexbasePath = "Controller/controller3/controller3";

	[Token(Token = "0x400017B")]
	private const string neo2TexbasePath = "Controller/controller4/controller4";

	[Token(Token = "0x400017C")]
	private const string neo3TexbasePath = "Controller/controller5/controller5";

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x36DBA4", Offset = "0x36DBA4", VA = "0x36DBA4")]
	public Pvr_ControllerInit()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x36DC8C", Offset = "0x36DC8C", VA = "0x36DC8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x36DE90", Offset = "0x36DE90", VA = "0x36DE90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x36DFE0", Offset = "0x36DFE0", VA = "0x36DFE0")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x36E354", Offset = "0x36E354", VA = "0x36E354")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x36E634", Offset = "0x36E634", VA = "0x36E634")]
	private void LoadResFromJson()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x36E8EC", Offset = "0x36E8EC", VA = "0x36E8EC")]
	private void CheckControllerStateForGoblin(string state)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x36EDC8", Offset = "0x36EDC8", VA = "0x36EDC8")]
	private void CheckControllerStateOfAbility(string data)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x36DFEC", Offset = "0x36DFEC", VA = "0x36DFEC")]
	private void DestroyLocalController()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x36E9E0", Offset = "0x36E9E0", VA = "0x36E9E0")]
	private void DestroySysController()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x36E854", Offset = "0x36E854", VA = "0x36E854")]
	[DebuggerHidden]
	private IEnumerator RefreshController(int id)
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x36EF6C", Offset = "0x36EF6C", VA = "0x36EF6C")]
	private void LoadControllerFromPrefab()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x36F830", Offset = "0x36F830", VA = "0x36F830")]
	private void LoadControllerFromSystem(int id)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x36F324", Offset = "0x36F324", VA = "0x36F324")]
	private void LoadTexture(Pvr_ControllerVisual visual, string controllerName, bool fromRes)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x36FE78", Offset = "0x36FE78", VA = "0x36FE78")]
	private Texture2D LoadOneTexture(string filepath, bool fromRes)
	{
		return null;
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x36FFC0", Offset = "0x36FFC0", VA = "0x36FFC0")]
	private byte[] ReadPNG(string path)
	{
		return null;
	}
}
[Token(Token = "0x2000063")]
public class Pvr_ControllerLink
{
	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public AndroidJavaClass javaHummingbirdClass;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public AndroidJavaClass javaPico2ReceiverClass;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AndroidJavaClass javaserviceClass;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public AndroidJavaClass javavractivityclass;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AndroidJavaClass javaCVClass;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public AndroidJavaObject activity;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string gameobjname;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool picoDevice;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string hummingBirdMac;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int hummingBirdRSSI;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool goblinserviceStarted;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool neoserviceStarted;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool controller0Connected;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool controller1Connected;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int mainHandID;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Pvr_Controller.UserHandNess handness;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int controllerType;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ControllerHand Controller0;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public ControllerHand Controller1;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int platFormType;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int trackingmode;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int systemProp;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int enablehand6dofbyhead;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool switchHomeKey;

	[Token(Token = "0x4000195")]
	private const float SWITCH_METER = 1000f;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int iPhoneHMDModeEnabled;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float[] hbPoseData;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float[] sensorData;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] keyData;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int[] neo3TouchValue;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float[] fixedState;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float[] neoposeData;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int[] goblinKeyArray;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int[] neoKeyArray;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int[] neotriggerV;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float[] velocity;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float[] angularVelocity;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float[] angularAcce;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float[] acceData;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float[] predictData;

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x37080C", Offset = "0x37080C", VA = "0x37080C")]
	public Pvr_ControllerLink(string name)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x370DE8", Offset = "0x370DE8", VA = "0x370DE8")]
	private void StartHummingBirdService()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x371A40", Offset = "0x371A40", VA = "0x371A40")]
	public bool IsServiceExisted()
	{
		return default(bool);
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x371700", Offset = "0x371700", VA = "0x371700")]
	public void SetGameObjectToJar(string name)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x37188C", Offset = "0x37188C", VA = "0x37188C")]
	public void BindService()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x371C78", Offset = "0x371C78", VA = "0x371C78")]
	public void UnBindService()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x371E2C", Offset = "0x371E2C", VA = "0x371E2C")]
	public void StopReceiver()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x371F74", Offset = "0x371F74", VA = "0x371F74")]
	public void StartReceiver()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x372108", Offset = "0x372108", VA = "0x372108")]
	public int getHandness()
	{
		return default(int);
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x372338", Offset = "0x372338", VA = "0x372338")]
	public void setHandness(int hand)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x372508", Offset = "0x372508", VA = "0x372508")]
	public void StartScan()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x372668", Offset = "0x372668", VA = "0x372668")]
	public void StopScan()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x371598", Offset = "0x371598", VA = "0x371598")]
	public int GetSysproc()
	{
		return default(int);
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x3727D4", Offset = "0x3727D4", VA = "0x3727D4")]
	public void ResetController(int num)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x372A0C", Offset = "0x372A0C", VA = "0x372A0C")]
	public void ConnectBLE()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x372BCC", Offset = "0x372BCC", VA = "0x372BCC")]
	public void DisConnectBLE()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x372CBC", Offset = "0x372CBC", VA = "0x372CBC")]
	public bool StartUpgrade()
	{
		return default(bool);
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x372DC8", Offset = "0x372DC8", VA = "0x372DC8")]
	public void setBinPath(string path, bool isasset)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x372FE8", Offset = "0x372FE8", VA = "0x372FE8")]
	public string GetBLEImageType()
	{
		return null;
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x37318C", Offset = "0x37318C", VA = "0x37318C")]
	public long GetBLEVersion()
	{
		return default(long);
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x3732FC", Offset = "0x3732FC", VA = "0x3732FC")]
	public string GetFileImageType()
	{
		return null;
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x3734A0", Offset = "0x3734A0", VA = "0x3734A0")]
	public long GetFileVersion()
	{
		return default(long);
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x373610", Offset = "0x373610", VA = "0x373610")]
	public int GetControllerConnectionState(int num)
	{
		return default(int);
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x373A54", Offset = "0x373A54", VA = "0x373A54")]
	public void RebackToLauncher()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x373BB0", Offset = "0x373BB0", VA = "0x373BB0")]
	public void TurnUpVolume()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x373DBC", Offset = "0x373DBC", VA = "0x373DBC")]
	public void TurnDownVolume()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x373FC8", Offset = "0x373FC8", VA = "0x373FC8")]
	public float[] GetHBControllerPoseData()
	{
		return null;
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x374588", Offset = "0x374588", VA = "0x374588")]
	public float[] GetControllerSensorData()
	{
		return null;
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x374750", Offset = "0x374750", VA = "0x374750")]
	public int[] GetControllerKeyData()
	{
		return null;
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x374808", Offset = "0x374808", VA = "0x374808")]
	public int[] GetNeo3TouchData(int hand)
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x37558C", Offset = "0x37558C", VA = "0x37558C")]
	public int GetNeo3GripValue(int hand)
	{
		return default(int);
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x3757BC", Offset = "0x3757BC", VA = "0x3757BC")]
	public float[] GetControllerFixedSensorState(int hand)
	{
		return null;
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x3761E0", Offset = "0x3761E0", VA = "0x3761E0")]
	public float[] GetCvControllerPoseData(int hand)
	{
		return null;
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x376C70", Offset = "0x376C70", VA = "0x376C70")]
	public int[] GetHBControllerKeyData()
	{
		return null;
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x378F70", Offset = "0x378F70", VA = "0x378F70")]
	public int GetHBKeyValue()
	{
		return default(int);
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x379124", Offset = "0x379124", VA = "0x379124")]
	public int[] GetCvControllerKeyData(int hand)
	{
		return null;
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x37C37C", Offset = "0x37C37C", VA = "0x37C37C")]
	public int GetCVTriggerValue(int hand)
	{
		return default(int);
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x37C5F8", Offset = "0x37C5F8", VA = "0x37C5F8")]
	public void AutoConnectHbController(int scanTimeMs)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x37C808", Offset = "0x37C808", VA = "0x37C808")]
	public void StartControllerThread(int headSensorState, int handSensorState)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x37CA78", Offset = "0x37CA78", VA = "0x37CA78")]
	public void StopControllerThread(int headSensorState, int handSensorState)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x37CCE8", Offset = "0x37CCE8", VA = "0x37CCE8")]
	public void SetUnityVersionToJar(string version)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x37CE84", Offset = "0x37CE84", VA = "0x37CE84")]
	public Vector3 GetVelocity(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x37D4AC", Offset = "0x37D4AC", VA = "0x37D4AC")]
	public Vector3 GetAngularVelocity(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x37DCC8", Offset = "0x37DCC8", VA = "0x37DCC8")]
	public Vector3 GetAngularAcceleration(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x37E3B4", Offset = "0x37E3B4", VA = "0x37E3B4")]
	public Vector3 GetAcceleration(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x37EA6C", Offset = "0x37EA6C", VA = "0x37EA6C")]
	public string GetConnectedDeviceMac()
	{
		return null;
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x37EC08", Offset = "0x37EC08", VA = "0x37EC08")]
	public void VibrateNeo2Controller(float strength, int time, int hand)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x37F05C", Offset = "0x37F05C", VA = "0x37F05C")]
	public void VibrateController(float strength, int time, int hand)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x37F4B0", Offset = "0x37F4B0", VA = "0x37F4B0")]
	public int GetMainControllerIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x37F624", Offset = "0x37F624", VA = "0x37F624")]
	public void SetMainController(int index)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x37F7F4", Offset = "0x37F7F4", VA = "0x37F7F4")]
	public void ResetHeadSensorForController()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x37F8E8", Offset = "0x37F8E8", VA = "0x37F8E8")]
	public void GetDeviceVersion(int deviceType)
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x37FAB8", Offset = "0x37FAB8", VA = "0x37FAB8")]
	public void GetControllerSnCode(int controllerSerialNum)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x37FC88", Offset = "0x37FC88", VA = "0x37FC88")]
	public void SetControllerUnbind(int controllerSerialNum)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x37FE58", Offset = "0x37FE58", VA = "0x37FE58")]
	public void SetStationRestart()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x37FF4C", Offset = "0x37FF4C", VA = "0x37FF4C")]
	public void StartStationOtaUpdate()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x380040", Offset = "0x380040", VA = "0x380040")]
	public void StartControllerOtaUpdate(int mode, int controllerSerialNum)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x380298", Offset = "0x380298", VA = "0x380298")]
	public void EnterPairMode(int controllerSerialNum)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x380468", Offset = "0x380468", VA = "0x380468")]
	public void SetControllerShutdown(int controllerSerialNum)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x380638", Offset = "0x380638", VA = "0x380638")]
	public int GetStationPairState()
	{
		return default(int);
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x3807AC", Offset = "0x3807AC", VA = "0x3807AC")]
	public int GetStationOtaUpdateProgress()
	{
		return default(int);
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x380920", Offset = "0x380920", VA = "0x380920")]
	public int GetControllerOtaUpdateProgress()
	{
		return default(int);
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x380A94", Offset = "0x380A94", VA = "0x380A94")]
	public void GetControllerVersionAndSN(int controllerSerialNum)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x380C64", Offset = "0x380C64", VA = "0x380C64")]
	public void GetControllerUniqueID()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x380D58", Offset = "0x380D58", VA = "0x380D58")]
	public void InterruptStationPairMode()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x380E4C", Offset = "0x380E4C", VA = "0x380E4C")]
	public int GetControllerAbility(int controllerSerialNum)
	{
		return default(int);
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x38103C", Offset = "0x38103C", VA = "0x38103C")]
	public void SwitchHomeKey(bool state)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x38113C", Offset = "0x38113C", VA = "0x38113C")]
	public void SetBootReconnect()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x381224", Offset = "0x381224", VA = "0x381224")]
	public int GetTemperature()
	{
		return default(int);
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x38138C", Offset = "0x38138C", VA = "0x38138C")]
	public int GetDeviceType()
	{
		return default(int);
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x3814F4", Offset = "0x3814F4", VA = "0x3814F4")]
	public int GetControllerType()
	{
		return default(int);
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x3815B4", Offset = "0x3815B4", VA = "0x3815B4")]
	public string GetHummingBird2SN()
	{
		return null;
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x381714", Offset = "0x381714", VA = "0x381714")]
	public string GetControllerVersion()
	{
		return null;
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x381874", Offset = "0x381874", VA = "0x381874")]
	public bool IsEnbleTrigger()
	{
		return default(bool);
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x3819DC", Offset = "0x3819DC", VA = "0x3819DC")]
	public void StartCV2PairingMode(int devicetype)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x381BAC", Offset = "0x381BAC", VA = "0x381BAC")]
	public void StopCV2PairingMode(int devicetype)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x381D7C", Offset = "0x381D7C", VA = "0x381D7C")]
	public int GetControllerBindingState(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x381F60", Offset = "0x381F60", VA = "0x381F60")]
	public void setIsEnbleHomeKey(bool state)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x382130", Offset = "0x382130", VA = "0x382130")]
	public int getControllerSensorStatus(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x382314", Offset = "0x382314", VA = "0x382314")]
	public float[] GetControllerPredictSensorData(int controllerID, float predictTime)
	{
		return null;
	}
}
[Token(Token = "0x2000064")]
public class Pvr_ControllerManager : MonoBehaviour
{
	[Token(Token = "0x2000065")]
	public delegate void PvrServiceStartSuccess();

	[Token(Token = "0x2000066")]
	public delegate void PvrControllerStateChanged(string data);

	[Token(Token = "0x2000067")]
	public delegate void ChangeMainControllerCallBack(string index);

	[Token(Token = "0x2000068")]
	public delegate void ChangeHandNessCallBack(string index);

	[Token(Token = "0x2000069")]
	public delegate void SetHbServiceBindState();

	[Token(Token = "0x200006A")]
	public delegate void ControllerThreadStartedCallback();

	[Token(Token = "0x200006B")]
	public delegate void SetControllerServiceBindState();

	[Token(Token = "0x200006C")]
	public delegate void ControllerStatusChange(string isconnect);

	[Token(Token = "0x200006D")]
	public delegate void SetControllerAbility(string data);

	[Token(Token = "0x200006E")]
	public delegate void SetControllerStateChanged(string data);

	[Token(Token = "0x200006F")]
	public delegate void SetHbControllerMac(string mac);

	[Token(Token = "0x2000070")]
	public delegate void ControllerDeviceVersionCallback(string data);

	[Token(Token = "0x2000071")]
	public delegate void ControllerSnCodeCallback(string data);

	[Token(Token = "0x2000072")]
	public delegate void ControllerUnbindCallback(string status);

	[Token(Token = "0x2000073")]
	public delegate void ControllerStationStatusCallback(string status);

	[Token(Token = "0x2000074")]
	public delegate void ControllerStationBusyCallback(string status);

	[Token(Token = "0x2000075")]
	public delegate void ControllerOtaStartCodeCallback(string data);

	[Token(Token = "0x2000076")]
	public delegate void ControllerDeviceVersionAndSNCallback(string data);

	[Token(Token = "0x2000077")]
	public delegate void ControllerUniqueIDCallback(string data);

	[Token(Token = "0x2000078")]
	public delegate void ControllerCombinedKeyUnbindCallback(string data);

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_ControllerManager instance;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static Pvr_ControllerLink controllerlink;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private float cTime;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool stopConnect;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Text toast;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool controllerServicestate;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float disConnectTime;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool LengthAdaptiveRay;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float[] sensorData;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int[] keyData;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float[] g2SensorData;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int[] g2KeyData;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int keyOffset;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int rotControllerMode;

	[Token(Token = "0x17000037")]
	public static Pvr_ControllerManager Instance
	{
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x437B3C", Offset = "0x437B3C", VA = "0x437B3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public static event PvrServiceStartSuccess PvrServiceStartSuccessEvent
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x437E8C", Offset = "0x437E8C", VA = "0x437E8C")]
		add
		{
		}
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x438000", Offset = "0x438000", VA = "0x438000")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event PvrControllerStateChanged PvrControllerStateChangedEvent
	{
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x438174", Offset = "0x438174", VA = "0x438174")]
		add
		{
		}
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x4382E8", Offset = "0x4382E8", VA = "0x4382E8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public static event ChangeMainControllerCallBack ChangeMainControllerCallBackEvent
	{
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x43845C", Offset = "0x43845C", VA = "0x43845C")]
		add
		{
		}
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x4385D0", Offset = "0x4385D0", VA = "0x4385D0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public static event ChangeHandNessCallBack ChangeHandNessCallBackEvent
	{
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x438744", Offset = "0x438744", VA = "0x438744")]
		add
		{
		}
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x4388B8", Offset = "0x4388B8", VA = "0x4388B8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public static event SetHbServiceBindState SetHbServiceBindStateEvent
	{
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x438A2C", Offset = "0x438A2C", VA = "0x438A2C")]
		add
		{
		}
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x438BA0", Offset = "0x438BA0", VA = "0x438BA0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event ControllerThreadStartedCallback ControllerThreadStartedCallbackEvent
	{
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x438D14", Offset = "0x438D14", VA = "0x438D14")]
		add
		{
		}
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x438E88", Offset = "0x438E88", VA = "0x438E88")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public static event SetControllerServiceBindState SetControllerServiceBindStateEvent
	{
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x438FFC", Offset = "0x438FFC", VA = "0x438FFC")]
		add
		{
		}
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x439170", Offset = "0x439170", VA = "0x439170")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public static event ControllerStatusChange ControllerStatusChangeEvent
	{
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x4392E4", Offset = "0x4392E4", VA = "0x4392E4")]
		add
		{
		}
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x439458", Offset = "0x439458", VA = "0x439458")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public static event SetControllerAbility SetControllerAbilityEvent
	{
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4395CC", Offset = "0x4395CC", VA = "0x4395CC")]
		add
		{
		}
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x439740", Offset = "0x439740", VA = "0x439740")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public static event SetControllerStateChanged SetControllerStateChangedEvent
	{
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x4398B4", Offset = "0x4398B4", VA = "0x4398B4")]
		add
		{
		}
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x439A28", Offset = "0x439A28", VA = "0x439A28")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public static event SetHbControllerMac SetHbControllerMacEvent
	{
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x439B9C", Offset = "0x439B9C", VA = "0x439B9C")]
		add
		{
		}
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x439D10", Offset = "0x439D10", VA = "0x439D10")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public static event ControllerDeviceVersionCallback ControllerDeviceVersionCallbackEvent
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x439E84", Offset = "0x439E84", VA = "0x439E84")]
		add
		{
		}
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x439FF8", Offset = "0x439FF8", VA = "0x439FF8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public static event ControllerSnCodeCallback ControllerSnCodeCallbackEvent
	{
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x43A16C", Offset = "0x43A16C", VA = "0x43A16C")]
		add
		{
		}
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x43A2E0", Offset = "0x43A2E0", VA = "0x43A2E0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public static event ControllerUnbindCallback ControllerUnbindCallbackEvent
	{
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x43A454", Offset = "0x43A454", VA = "0x43A454")]
		add
		{
		}
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x43A5C8", Offset = "0x43A5C8", VA = "0x43A5C8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public static event ControllerStationStatusCallback ControllerStationStatusCallbackEvent
	{
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x43A73C", Offset = "0x43A73C", VA = "0x43A73C")]
		add
		{
		}
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x43A8B0", Offset = "0x43A8B0", VA = "0x43A8B0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	public static event ControllerStationBusyCallback ControllerStationBusyCallbackEvent
	{
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x43AA24", Offset = "0x43AA24", VA = "0x43AA24")]
		add
		{
		}
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x43AB98", Offset = "0x43AB98", VA = "0x43AB98")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public static event ControllerOtaStartCodeCallback ControllerOtaStartCodeCallbackEvent
	{
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x43AD0C", Offset = "0x43AD0C", VA = "0x43AD0C")]
		add
		{
		}
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x43AE80", Offset = "0x43AE80", VA = "0x43AE80")]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public static event ControllerDeviceVersionAndSNCallback ControllerDeviceVersionAndSNCallbackEvent
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x43AFF4", Offset = "0x43AFF4", VA = "0x43AFF4")]
		add
		{
		}
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x43B168", Offset = "0x43B168", VA = "0x43B168")]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	public static event ControllerUniqueIDCallback ControllerUniqueIDCallbackEvent
	{
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x43B2DC", Offset = "0x43B2DC", VA = "0x43B2DC")]
		add
		{
		}
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x43B450", Offset = "0x43B450", VA = "0x43B450")]
		remove
		{
		}
	}

	[Token(Token = "0x14000014")]
	public static event ControllerCombinedKeyUnbindCallback ControllerCombinedKeyUnbindCallbackEvent
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x43B5C4", Offset = "0x43B5C4", VA = "0x43B5C4")]
		add
		{
		}
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x43B738", Offset = "0x43B738", VA = "0x43B738")]
		remove
		{
		}
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x437A4C", Offset = "0x437A4C", VA = "0x437A4C")]
	public Pvr_ControllerManager()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x43B8AC", Offset = "0x43B8AC", VA = "0x43B8AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x43BCE8", Offset = "0x43BCE8", VA = "0x43BCE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x43BDC8", Offset = "0x43BDC8", VA = "0x43BDC8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x43F5B4", Offset = "0x43F5B4", VA = "0x43F5B4")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x43FF4C", Offset = "0x43FF4C", VA = "0x43FF4C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x440064", Offset = "0x440064", VA = "0x440064")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x44029C", Offset = "0x44029C", VA = "0x44029C")]
	public Vector3 GetAngularVelocity(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x4403C4", Offset = "0x4403C4", VA = "0x4403C4")]
	public Vector3 GetAcceleration(int num)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x43BC04", Offset = "0x43BC04", VA = "0x43BC04")]
	public void BindService()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x4404EC", Offset = "0x4404EC", VA = "0x4404EC")]
	public void StartScan()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x4405D0", Offset = "0x4405D0", VA = "0x4405D0")]
	public void StopScan()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x4406B4", Offset = "0x4406B4", VA = "0x4406B4")]
	public void ResetController(int num)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x43FCA4", Offset = "0x43FCA4", VA = "0x43FCA4")]
	public static int GetControllerConnectionState(int num)
	{
		return default(int);
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x4407A0", Offset = "0x4407A0", VA = "0x4407A0")]
	public void ConnectBLE()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x440884", Offset = "0x440884", VA = "0x440884")]
	public void DisConnectBLE()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x440968", Offset = "0x440968", VA = "0x440968")]
	public void SetBinPath(string path, bool isAsset)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x440A5C", Offset = "0x440A5C", VA = "0x440A5C")]
	public void StartUpgrade()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x440B40", Offset = "0x440B40", VA = "0x440B40")]
	public static string GetBLEImageType()
	{
		return null;
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x440BE4", Offset = "0x440BE4", VA = "0x440BE4")]
	public static long GetBLEVersion()
	{
		return default(long);
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x440C88", Offset = "0x440C88", VA = "0x440C88")]
	public static string GetFileImageType()
	{
		return null;
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x440D2C", Offset = "0x440D2C", VA = "0x440D2C")]
	public static long GetFileVersion()
	{
		return default(long);
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x440DD0", Offset = "0x440DD0", VA = "0x440DD0")]
	public static void AutoConnectHbController(int scans)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x440EBC", Offset = "0x440EBC", VA = "0x440EBC")]
	public static string GetConnectedDeviceMac()
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x440FEC", Offset = "0x440FEC", VA = "0x440FEC")]
	public void setHbControllerMac(string mac)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x4415FC", Offset = "0x4415FC", VA = "0x4415FC")]
	public int GetControllerRSSI()
	{
		return default(int);
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x441698", Offset = "0x441698", VA = "0x441698")]
	public void setHbServiceBindState(string state)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x441CC4", Offset = "0x441CC4", VA = "0x441CC4")]
	public void setControllerServiceBindState(string state)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x4422CC", Offset = "0x4422CC", VA = "0x4422CC")]
	public void setHbControllerConnectState(string isconnect)
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x442E4C", Offset = "0x442E4C", VA = "0x442E4C")]
	public void setControllerStateChanged(string state)
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x443B68", Offset = "0x443B68", VA = "0x443B68")]
	public void setControllerAbility(string data)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x444080", Offset = "0x444080", VA = "0x444080")]
	public void controllerThreadStartedCallback()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x444978", Offset = "0x444978", VA = "0x444978")]
	public void controllerDeviceVersionCallback(string data)
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x444E90", Offset = "0x444E90", VA = "0x444E90")]
	public void controllerSnCodeCallback(string data)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x4453A8", Offset = "0x4453A8", VA = "0x4453A8")]
	public void controllerUnbindCallback(string status)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x4458C0", Offset = "0x4458C0", VA = "0x4458C0")]
	public void controllerStationStatusCallback(string status)
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x445DD8", Offset = "0x445DD8", VA = "0x445DD8")]
	public void controllerStationBusyCallback(string status)
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x4462F0", Offset = "0x4462F0", VA = "0x4462F0")]
	public void controllerOTAStartCodeCallback(string data)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x446808", Offset = "0x446808", VA = "0x446808")]
	public void controllerDeviceVersionAndSNCallback(string data)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x446D20", Offset = "0x446D20", VA = "0x446D20")]
	public void controllerUniqueIDCallback(string data)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x447238", Offset = "0x447238", VA = "0x447238")]
	public void controllerCombinedKeyUnbindCallback(string controllerSerialNum)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x4476C4", Offset = "0x4476C4", VA = "0x4476C4")]
	public void setupdateFailed()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x4476C8", Offset = "0x4476C8", VA = "0x4476C8")]
	public void setupdateSuccess()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x4476CC", Offset = "0x4476CC", VA = "0x4476CC")]
	public void setupdateProgress(string progress)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x4476D0", Offset = "0x4476D0", VA = "0x4476D0")]
	public void setHbAutoConnectState(string state)
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x447BA8", Offset = "0x447BA8", VA = "0x447BA8")]
	public void callbackControllerServiceState(string state)
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x447D7C", Offset = "0x447D7C", VA = "0x447D7C")]
	public void changeMainControllerCallback(string index)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x4482FC", Offset = "0x4482FC", VA = "0x4482FC")]
	public void changeHandnessCallback(string index)
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x447898", Offset = "0x447898", VA = "0x447898")]
	private void ShowToast(int type)
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x44887C", Offset = "0x44887C", VA = "0x44887C")]
	private void HideToast()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x448980", Offset = "0x448980", VA = "0x448980")]
	private void CheckControllerService()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x444254", Offset = "0x444254", VA = "0x444254")]
	private void GetCVControllerState()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x43E9C4", Offset = "0x43E9C4", VA = "0x43E9C4")]
	private void SetSystemKey()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x43E368", Offset = "0x43E368", VA = "0x43E368")]
	private void TransformData(ControllerHand hand, int handId, int[] data)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x448994", Offset = "0x448994", VA = "0x448994")]
	private void TransSingleKey(PvrControllerKey key, int beginIndex, int[] data)
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x448B50", Offset = "0x448B50", VA = "0x448B50")]
	private void TransformTouchData(ControllerHand hand, int handId, int[] data)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x448C74", Offset = "0x448C74", VA = "0x448C74")]
	private void TransSingleTouchValue(PvrControllerKey key, int beginIndex, int[] data)
	{
	}
}
namespace Pvr_UnitySDKAPI
{
	[Token(Token = "0x2000079")]
	public enum ControllerVariety
	{
		[Token(Token = "0x40001C8")]
		Controller0,
		[Token(Token = "0x40001C9")]
		Controller1
	}
}
[Token(Token = "0x200007A")]
public class Pvr_ControllerModuleInit : MonoBehaviour
{
	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1621E4", Offset = "0x1621E4")]
	private sealed class <ShowOrHideRay>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int id;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Pvr_ControllerModuleInit $this;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object $current;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool $disposing;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int $PC;

		[Token(Token = "0x170000AE")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x6000993")]
			[Address(RVA = "0x44A2E0", Offset = "0x44A2E0", VA = "0x44A2E0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x44A2E8", Offset = "0x44A2E8", VA = "0x44A2E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x449CC4", Offset = "0x449CC4", VA = "0x449CC4")]
		[DebuggerHidden]
		public <ShowOrHideRay>c__Iterator0()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x44A19C", Offset = "0x44A19C", VA = "0x44A19C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x44A2F0", Offset = "0x44A2F0", VA = "0x44A2F0", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x44A304", Offset = "0x44A304", VA = "0x44A304", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public ControllerVariety Variety;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool IsCustomModel;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private GameObject dot;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject rayLine;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private GameObject controller;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool moduleState;

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x4496AC", Offset = "0x4496AC", VA = "0x4496AC")]
	public Pvr_ControllerModuleInit()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x4496BC", Offset = "0x4496BC", VA = "0x4496BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x4498FC", Offset = "0x4498FC", VA = "0x4498FC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x449A2C", Offset = "0x449A2C", VA = "0x449A2C")]
	private void ServiceStartSuccess()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x449A90", Offset = "0x449A90", VA = "0x449A90")]
	private void ControllerStateChanged(string data)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x449C28", Offset = "0x449C28", VA = "0x449C28")]
	private void MainControllerIDChanged(string data)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x449A30", Offset = "0x449A30", VA = "0x449A30")]
	private void RefreshRay()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x449C2C", Offset = "0x449C2C", VA = "0x449C2C")]
	[DebuggerHidden]
	private IEnumerator ShowOrHideRay(int id)
	{
		return null;
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x449CCC", Offset = "0x449CCC", VA = "0x449CCC")]
	public void ForceHideOrShow(bool state)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x449E50", Offset = "0x449E50", VA = "0x449E50")]
	public void UpdateRay()
	{
	}
}
[Token(Token = "0x200007B")]
public class Pvr_ControllerPower : MonoBehaviour
{
	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[SerializeField]
	private Sprite power1;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Sprite power2;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private Sprite power3;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Sprite power4;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Sprite power5;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public ControllerVariety variety;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public ControllerDevice currentDevice;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Image powerImage;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int powerValue;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float power;

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x44A388", Offset = "0x44A388", VA = "0x44A388")]
	public Pvr_ControllerPower()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x44A390", Offset = "0x44A390", VA = "0x44A390")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x44A4B4", Offset = "0x44A4B4", VA = "0x44A4B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x44A4E8", Offset = "0x44A4E8", VA = "0x44A4E8")]
	private void RefreshPower(int hand)
	{
	}
}
namespace Pvr_UnitySDKAPI
{
	[Token(Token = "0x200007C")]
	public enum ControllerDevice
	{
		[Token(Token = "0x40001DB")]
		Goblin,
		[Token(Token = "0x40001DC")]
		Neo,
		[Token(Token = "0x40001DD")]
		G2,
		[Token(Token = "0x40001DE")]
		Neo2,
		[Token(Token = "0x40001DF")]
		Neo3,
		[Token(Token = "0x40001E0")]
		NewController
	}
}
[Token(Token = "0x200007D")]
public class Pvr_ControllerVisual : MonoBehaviour
{
	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public ControllerDevice currentDevice;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Texture2D m_idle;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Texture2D m_app;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D m_home;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Texture2D m_touchpad;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D m_volUp;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Texture2D m_volDn;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D m_trigger;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Texture2D m_a;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D m_b;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Texture2D m_x;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D m_y;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Texture2D m_grip;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Renderer controllerRenderMat;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public ControllerVariety variety;

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x44A658", Offset = "0x44A658", VA = "0x44A658")]
	public Pvr_ControllerVisual()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x44A660", Offset = "0x44A660", VA = "0x44A660")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x44A6C8", Offset = "0x44A6C8", VA = "0x44A6C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x44A760", Offset = "0x44A760", VA = "0x44A760")]
	private void Update()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x44A794", Offset = "0x44A794", VA = "0x44A794")]
	private void ChangeKeyEffects(int hand)
	{
	}
}
[Token(Token = "0x200007E")]
public class Pvr_ToolTips : MonoBehaviour
{
	[Token(Token = "0x200007F")]
	public enum TipBtn
	{
		[Token(Token = "0x40001F4")]
		app,
		[Token(Token = "0x40001F5")]
		touchpad,
		[Token(Token = "0x40001F6")]
		home,
		[Token(Token = "0x40001F7")]
		volup,
		[Token(Token = "0x40001F8")]
		voldown,
		[Token(Token = "0x40001F9")]
		trigger,
		[Token(Token = "0x40001FA")]
		grip
	}

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private ControllerDevice currentDevice;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float tipsAlpha;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Pvr_ToolTips tooltips;

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x453480", Offset = "0x453480", VA = "0x453480")]
	public Pvr_ToolTips()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x453488", Offset = "0x453488", VA = "0x453488")]
	public void ChangeTipsText(TipBtn tip, string key)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x4537B4", Offset = "0x4537B4", VA = "0x4537B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x45384C", Offset = "0x45384C", VA = "0x45384C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x453EA4", Offset = "0x453EA4", VA = "0x453EA4")]
	private void LoadTextFromJson()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x4544F4", Offset = "0x4544F4", VA = "0x4544F4")]
	public static void RefreshTips()
	{
	}
}
[Token(Token = "0x2000080")]
public class Pvr_TouchPadScroll : MonoBehaviour
{
	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private ScrollRect scrollRect;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool isHoving;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int mainHand;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SwipeDirection direction;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector2 currPos;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector2 tarPos;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float lerpSpeed;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform tranViewport;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float ignoreDis;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector2 lastTouchDownPos;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector2 lastTouchUpPos;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isTouching;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool isClosed;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector2 vecOrigin;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector2 vecOriginNeo2;

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x4545C8", Offset = "0x4545C8", VA = "0x4545C8")]
	public Pvr_TouchPadScroll()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x4546C0", Offset = "0x4546C0", VA = "0x4546C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x454780", Offset = "0x454780", VA = "0x454780")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x454E0C", Offset = "0x454E0C", VA = "0x454E0C")]
	private bool IsControllerConnect()
	{
		return default(bool);
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x454968", Offset = "0x454968", VA = "0x454968")]
	private void UpdateTargetPos()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x4550A8", Offset = "0x4550A8", VA = "0x4550A8")]
	private void ComputeTouchPos()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x4555E8", Offset = "0x4555E8", VA = "0x4555E8")]
	private void ComputeRockerPos()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x455B50", Offset = "0x455B50", VA = "0x455B50")]
	private bool VerifyNeo2TouchValid(Vector2 nowTouchPos)
	{
		return default(bool);
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x454B20", Offset = "0x454B20", VA = "0x454B20")]
	private void UpdatePos()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x454F44", Offset = "0x454F44", VA = "0x454F44")]
	private void ResetParameter()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x4547A4", Offset = "0x4547A4", VA = "0x4547A4")]
	private void Process()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x455BA8", Offset = "0x455BA8", VA = "0x455BA8")]
	private bool IsHovering(Pvr_UIPointer pointer)
	{
		return default(bool);
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x455E58", Offset = "0x455E58", VA = "0x455E58")]
	private bool FindTree(Transform tran)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000081")]
public class Pvr_TouchVisual : MonoBehaviour
{
	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[HideInInspector]
	public ControllerDevice currentDevice;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public ControllerVariety variety;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private MeshRenderer touchRenderer;

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x455F74", Offset = "0x455F74", VA = "0x455F74")]
	public Pvr_TouchVisual()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x455F7C", Offset = "0x455F7C", VA = "0x455F7C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x456060", Offset = "0x456060", VA = "0x456060")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x456094", Offset = "0x456094", VA = "0x456094")]
	private void ChangeEffects(int hand)
	{
	}
}
[Token(Token = "0x2000082")]
public class DemoController : MonoBehaviour
{
	[Token(Token = "0x2000083")]
	public delegate void showLoadingEventHandler();

	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1622E4", Offset = "0x1622E4")]
	private sealed class <InitDelegate>c__AnonStorey0
	{
		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal GameObject btnObj;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal DemoController $this;

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x357A54", Offset = "0x357A54", VA = "0x357A54")]
		public <InitDelegate>c__AnonStorey0()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x358CF4", Offset = "0x358CF4", VA = "0x358CF4")]
		internal void <>m__0()
		{
		}
	}

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Callback callback;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GameObject msg;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Pvr_UnitySDKManager picoVrManager;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string currentOrderID;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject loading;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject BG;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public GameObject InputPanel;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static showLoadingEventHandler showLoading;

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x356EA4", Offset = "0x356EA4", VA = "0x356EA4")]
	public DemoController()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x356EAC", Offset = "0x356EAC", VA = "0x356EAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x357180", Offset = "0x357180", VA = "0x357180")]
	private void Start()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x3577BC", Offset = "0x3577BC", VA = "0x3577BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x357280", Offset = "0x357280", VA = "0x357280")]
	private void InitDelegate()
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x357A5C", Offset = "0x357A5C", VA = "0x357A5C")]
	private void OnClick(GameObject btnObj)
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x358034", Offset = "0x358034", VA = "0x358034")]
	public string getRamdomTestOrderID()
	{
		return null;
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x357F6C", Offset = "0x357F6C", VA = "0x357F6C")]
	private void StartLoading()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x35857C", Offset = "0x35857C", VA = "0x35857C")]
	public void StopLoading()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x3586E4", Offset = "0x3586E4", VA = "0x3586E4")]
	public void DoPayByCode()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x358B54", Offset = "0x358B54", VA = "0x358B54")]
	private bool VerifyLocalToken()
	{
		return default(bool);
	}
}
[Token(Token = "0x2000084")]
public class LoadingRatation : MonoBehaviour
{
	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x364940", Offset = "0x364940", VA = "0x364940")]
	public LoadingRatation()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x364948", Offset = "0x364948", VA = "0x364948")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x36494C", Offset = "0x36494C", VA = "0x36494C")]
	private void Update()
	{
	}
}
[Token(Token = "0x2000085")]
public class InputManager : MonoBehaviour
{
	[Token(Token = "0x2000086")]
	public delegate void doEnterEventHandler();

	[Token(Token = "0x200016E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1622F4", Offset = "0x1622F4")]
	private sealed class <InitKeyBoard>c__AnonStorey0
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal GameObject btnObj;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal InputManager $this;

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x363A28", Offset = "0x363A28", VA = "0x363A28")]
		public <InitKeyBoard>c__AnonStorey0()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x3648D0", Offset = "0x3648D0", VA = "0x3648D0")]
		internal void <>m__0()
		{
		}
	}

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static doEnterEventHandler doEnter;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private StringBuilder sb;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private ArrayList btnsName;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private GameObject enter;

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x362D28", Offset = "0x362D28", VA = "0x362D28")]
	public InputManager()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x362DC8", Offset = "0x362DC8", VA = "0x362DC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x363A20", Offset = "0x363A20", VA = "0x363A20")]
	private void Start()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x363A24", Offset = "0x363A24", VA = "0x363A24")]
	private void Update()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x362DCC", Offset = "0x362DCC", VA = "0x362DCC")]
	private void InitKeyBoard()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x363A30", Offset = "0x363A30", VA = "0x363A30")]
	private void OnClick(GameObject btnObj)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x364784", Offset = "0x364784", VA = "0x364784")]
	private void EnterChar(string s)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x363DE4", Offset = "0x363DE4", VA = "0x363DE4")]
	private void DoCapslock(bool IsUpper)
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x3644E4", Offset = "0x3644E4", VA = "0x3644E4")]
	private void ClearBuffer()
	{
	}
}
[Token(Token = "0x2000087")]
public class Callback : MonoBehaviour
{
	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string IS_SUCCESS;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static string MSG;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string CODE;

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x352B38", Offset = "0x352B38", VA = "0x352B38")]
	public Callback()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x352B40", Offset = "0x352B40", VA = "0x352B40")]
	public void LoginCallback(string LoginInfo)
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x3532D8", Offset = "0x3532D8", VA = "0x3532D8")]
	public void QueryOrPayCallback(string queryOrPayInfo)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x353640", Offset = "0x353640", VA = "0x353640")]
	public void UserInfoCallback(string userInfo)
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x352EA8", Offset = "0x352EA8", VA = "0x352EA8")]
	public void SetMassage(string massage)
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x353778", Offset = "0x353778", VA = "0x353778")]
	public GameObject GetCurrentGameObject()
	{
		return null;
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x3537DC", Offset = "0x3537DC", VA = "0x3537DC")]
	public void ActivityForResultCallback(string activity)
	{
	}
}
[Token(Token = "0x2000088")]
public class CommonDic
{
	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CommonDic dic;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Dictionary<string, string> mydic;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private string _app_ID;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private string _app_Key;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string _user_token;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private string _access_token;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string _open_id;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private string _refresh_token;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string _expires_in;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private string _user_info;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string _subject;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private string _body;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _order_id;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private string _total;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _goods_tag;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private string _notify_url;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _trade_type;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private string _pay_code;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _order_info;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private string _code;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string _msg;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private string _merchant_ID;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string _payKey;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private string _isSuucess;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string _loginMsg;

	[Token(Token = "0x17000038")]
	public string subject
	{
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x356D9C", Offset = "0x356D9C", VA = "0x356D9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x356CD0", Offset = "0x356CD0", VA = "0x356CD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public string body
	{
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x356DA4", Offset = "0x356DA4", VA = "0x356DA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x356CD8", Offset = "0x356CD8", VA = "0x356CD8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public string order_id
	{
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x356DAC", Offset = "0x356DAC", VA = "0x356DAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x356CE0", Offset = "0x356CE0", VA = "0x356CE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public string total
	{
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x356DB4", Offset = "0x356DB4", VA = "0x356DB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x356CE8", Offset = "0x356CE8", VA = "0x356CE8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public string goods_tag
	{
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x356DBC", Offset = "0x356DBC", VA = "0x356DBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x356CF0", Offset = "0x356CF0", VA = "0x356CF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public string notify_url
	{
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x356DC4", Offset = "0x356DC4", VA = "0x356DC4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x356CF8", Offset = "0x356CF8", VA = "0x356CF8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public string pay_code
	{
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x356DCC", Offset = "0x356DCC", VA = "0x356DCC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x356D08", Offset = "0x356D08", VA = "0x356D08")]
		set
		{
		}
	}

	[Token(Token = "0x1700003F")]
	public string trade_type
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x356DD4", Offset = "0x356DD4", VA = "0x356DD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x356D00", Offset = "0x356D00", VA = "0x356D00")]
		set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public string user_token
	{
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x356DDC", Offset = "0x356DDC", VA = "0x356DDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x356DE4", Offset = "0x356DE4", VA = "0x356DE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public string access_token
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x356DEC", Offset = "0x356DEC", VA = "0x356DEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x356DF4", Offset = "0x356DF4", VA = "0x356DF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public string open_id
	{
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x356DFC", Offset = "0x356DFC", VA = "0x356DFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x356E04", Offset = "0x356E04", VA = "0x356E04")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public string refresh_token
	{
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x356E0C", Offset = "0x356E0C", VA = "0x356E0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x356E14", Offset = "0x356E14", VA = "0x356E14")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public string expires_in
	{
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x356E1C", Offset = "0x356E1C", VA = "0x356E1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x356E24", Offset = "0x356E24", VA = "0x356E24")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public string isSuccess
	{
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x356E2C", Offset = "0x356E2C", VA = "0x356E2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x3532C8", Offset = "0x3532C8", VA = "0x3532C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public string loginMsg
	{
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x356E34", Offset = "0x356E34", VA = "0x356E34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x3532D0", Offset = "0x3532D0", VA = "0x3532D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public string user_info
	{
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x356E3C", Offset = "0x356E3C", VA = "0x356E3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x353770", Offset = "0x353770", VA = "0x353770")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public string order_info
	{
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x356E44", Offset = "0x356E44", VA = "0x356E44")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x353638", Offset = "0x353638", VA = "0x353638")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public string code
	{
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x356E4C", Offset = "0x356E4C", VA = "0x356E4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x353628", Offset = "0x353628", VA = "0x353628")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public string msg
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x356E54", Offset = "0x356E54", VA = "0x356E54")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x353630", Offset = "0x353630", VA = "0x353630")]
		set
		{
		}
	}

	[Token(Token = "0x1700004B")]
	public string app_ID
	{
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x356E5C", Offset = "0x356E5C", VA = "0x356E5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x356E64", Offset = "0x356E64", VA = "0x356E64")]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public string app_Key
	{
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x356E6C", Offset = "0x356E6C", VA = "0x356E6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x356E74", Offset = "0x356E74", VA = "0x356E74")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public string merchant_ID
	{
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x356E7C", Offset = "0x356E7C", VA = "0x356E7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x356E84", Offset = "0x356E84", VA = "0x356E84")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public string paykey
	{
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x356E8C", Offset = "0x356E8C", VA = "0x356E8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x356E94", Offset = "0x356E94", VA = "0x356E94")]
		set
		{
		}
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x355EAC", Offset = "0x355EAC", VA = "0x355EAC")]
	public CommonDic()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x3531C4", Offset = "0x3531C4", VA = "0x3531C4")]
	public static CommonDic getInstance()
	{
		return null;
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x356A98", Offset = "0x356A98", VA = "0x356A98")]
	public Dictionary<string, string> getDic()
	{
		return null;
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x356AFC", Offset = "0x356AFC", VA = "0x356AFC")]
	public void setParameters(string name, string value)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x356D10", Offset = "0x356D10", VA = "0x356D10")]
	public string PayOrderString()
	{
		return null;
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x355F7C", Offset = "0x355F7C", VA = "0x355F7C")]
	public static void InitDicData(Dictionary<string, string> mydic)
	{
	}
}
[Token(Token = "0x2000089")]
public class LoginSDK
{
	[Token(Token = "0x6000422")]
	[Address(RVA = "0x3649D8", Offset = "0x3649D8", VA = "0x3649D8")]
	public LoginSDK()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x357FBC", Offset = "0x357FBC", VA = "0x357FBC")]
	public static void Login()
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x358504", Offset = "0x358504", VA = "0x358504")]
	public static void GetUserAPI()
	{
	}
}
[Token(Token = "0x200008A")]
public class PicoPaymentSDK
{
	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject _jo;

	[Token(Token = "0x1700004F")]
	public static AndroidJavaObject jo
	{
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x353904", Offset = "0x353904", VA = "0x353904")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x3664FC", Offset = "0x3664FC", VA = "0x3664FC")]
		set
		{
		}
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x3664F4", Offset = "0x3664F4", VA = "0x3664F4")]
	public PicoPaymentSDK()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x3649E0", Offset = "0x3649E0", VA = "0x3649E0")]
	public static void Login()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x35807C", Offset = "0x35807C", VA = "0x35807C")]
	public static void Pay(string payOrderJson)
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x3582C0", Offset = "0x3582C0", VA = "0x3582C0")]
	public static void QueryOrder(string orderId)
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x364BCC", Offset = "0x364BCC", VA = "0x364BCC")]
	public static void GetUserAPI()
	{
	}
}
namespace Pvr_UnitySDKAPI
{
	[Token(Token = "0x200008B")]
	public enum PBS_SystemInfoEnum
	{
		[Token(Token = "0x4000237")]
		ELECTRIC_QUANTITY,
		[Token(Token = "0x4000238")]
		PUI_VERSION,
		[Token(Token = "0x4000239")]
		EQUIPMENT_MODEL,
		[Token(Token = "0x400023A")]
		EQUIPMENT_SN,
		[Token(Token = "0x400023B")]
		CUSTOMER_SN,
		[Token(Token = "0x400023C")]
		INTERNAL_STORAGE_SPACE_OF_THE_DEVICE,
		[Token(Token = "0x400023D")]
		DEVICE_BLUETOOTH_STATUS,
		[Token(Token = "0x400023E")]
		BLUETOOTH_NAME_CONNECTED,
		[Token(Token = "0x400023F")]
		BLUETOOTH_MAC_ADDRESS,
		[Token(Token = "0x4000240")]
		DEVICE_WIFI_STATUS,
		[Token(Token = "0x4000241")]
		WIFI_NAME_CONNECTED,
		[Token(Token = "0x4000242")]
		WLAN_MAC_ADDRESS,
		[Token(Token = "0x4000243")]
		DEVICE_IP
	}
	[Token(Token = "0x200008C")]
	public enum PBS_DeviceControlEnum
	{
		[Token(Token = "0x4000245")]
		DEVICE_CONTROL_REBOOT,
		[Token(Token = "0x4000246")]
		DEVICE_CONTROL_SHUTDOWN
	}
	[Token(Token = "0x200008D")]
	public enum PBS_PackageControlEnum
	{
		[Token(Token = "0x4000248")]
		PACKAGE_SILENCE_INSTALL,
		[Token(Token = "0x4000249")]
		PACKAGE_SILENCE_UNINSTALL
	}
	[Token(Token = "0x200008E")]
	public enum PBS_SwitchEnum
	{
		[Token(Token = "0x400024B")]
		S_ON,
		[Token(Token = "0x400024C")]
		S_OFF
	}
	[Token(Token = "0x200008F")]
	public enum PBS_HomeEventEnum
	{
		[Token(Token = "0x400024E")]
		SINGLE_CLICK,
		[Token(Token = "0x400024F")]
		DOUBLE_CLICK,
		[Token(Token = "0x4000250")]
		LONG_PRESS
	}
	[Token(Token = "0x2000090")]
	public enum PBS_HomeFunctionEnum
	{
		[Token(Token = "0x4000252")]
		VALUE_HOME_GO_TO_SETTING,
		[Token(Token = "0x4000253")]
		VALUE_HOME_BACK,
		[Token(Token = "0x4000254")]
		VALUE_HOME_RECENTER,
		[Token(Token = "0x4000255")]
		VALUE_HOME_OPEN_APP,
		[Token(Token = "0x4000256")]
		VALUE_HOME_DISABLE,
		[Token(Token = "0x4000257")]
		VALUE_HOME_GO_TO_HOME,
		[Token(Token = "0x4000258")]
		VALUE_HOME_SEND_BROADCAST,
		[Token(Token = "0x4000259")]
		VALUE_HOME_CLEAN_MEMORY
	}
	[Token(Token = "0x2000091")]
	public enum PBS_ScreenOffDelayTimeEnum
	{
		[Token(Token = "0x400025B")]
		THREE = 3,
		[Token(Token = "0x400025C")]
		TEN = 10,
		[Token(Token = "0x400025D")]
		THIRTY = 30,
		[Token(Token = "0x400025E")]
		SIXTY = 60,
		[Token(Token = "0x400025F")]
		THREE_HUNDRED = 300,
		[Token(Token = "0x4000260")]
		SIX_HUNDRED = 600,
		[Token(Token = "0x4000261")]
		NEVER = -1
	}
	[Token(Token = "0x2000092")]
	public enum PBS_SleepDelayTimeEnum
	{
		[Token(Token = "0x4000263")]
		FIFTEEN = 15,
		[Token(Token = "0x4000264")]
		THIRTY = 30,
		[Token(Token = "0x4000265")]
		SIXTY = 60,
		[Token(Token = "0x4000266")]
		THREE_HUNDRED = 300,
		[Token(Token = "0x4000267")]
		SIX_HUNDRED = 600,
		[Token(Token = "0x4000268")]
		ONE_THOUSAND_AND_EIGHT_HUNDRED = 1800,
		[Token(Token = "0x4000269")]
		NEVER = -1
	}
	[Token(Token = "0x2000093")]
	public enum PBS_SystemFunctionSwitchEnum
	{
		[Token(Token = "0x400026B")]
		SFS_USB,
		[Token(Token = "0x400026C")]
		SFS_AUTOSLEEP,
		[Token(Token = "0x400026D")]
		SFS_SCREENON_CHARGING,
		[Token(Token = "0x400026E")]
		SFS_OTG_CHARGING,
		[Token(Token = "0x400026F")]
		SFS_RETURN_MENU_IN_2DMODE,
		[Token(Token = "0x4000270")]
		SFS_COMBINATION_KEY,
		[Token(Token = "0x4000271")]
		SFS_CALIBRATION_WITH_POWER_ON,
		[Token(Token = "0x4000272")]
		SFS_SYSTEM_UPDATE,
		[Token(Token = "0x4000273")]
		SFS_CAST_SERVICE,
		[Token(Token = "0x4000274")]
		SFS_EYE_PROTECTION,
		[Token(Token = "0x4000275")]
		SFS_SECURITY_ZONE_PERMANENTLY,
		[Token(Token = "0x4000276")]
		SFS_GLOBAL_CALIBRATION,
		[Token(Token = "0x4000277")]
		SFS_Auto_Calibration,
		[Token(Token = "0x4000278")]
		SFS_USB_BOOT,
		[Token(Token = "0x4000279")]
		SFS_VOLUME_UI,
		[Token(Token = "0x400027A")]
		SFS_CONTROLLER_UI,
		[Token(Token = "0x400027B")]
		SFS_NAVGATION_SWITCH
	}
	[Token(Token = "0x2000094")]
	public enum PBS_USBConfigModeEnum
	{
		[Token(Token = "0x400027D")]
		MTP,
		[Token(Token = "0x400027E")]
		CHARGE
	}
	[Token(Token = "0x2000095")]
	public struct ToBService
	{
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<bool> BoolCallback;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Action<int> IntCallback;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<long> LongCallback;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static Action<string> StringCallback;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static AndroidJavaClass unityPlayer;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static AndroidJavaObject currentActivity;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static AndroidJavaObject tobHelper;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static AndroidJavaClass tobHelperClass;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x6B0DBC", Offset = "0x6B0DBC", VA = "0x6B0DBC")]
		public static void UPvr_InitToBService()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x6B0F6C", Offset = "0x6B0F6C", VA = "0x6B0F6C")]
		public static void UPvr_SetUnityObjectName(string obj)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x6B1070", Offset = "0x6B1070", VA = "0x6B1070")]
		public static void UPvr_BindToBService()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x6B117C", Offset = "0x6B117C", VA = "0x6B117C")]
		public static void UPvr_UnBindToBService()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x6B1288", Offset = "0x6B1288", VA = "0x6B1288")]
		private static AndroidJavaObject GetEnumType(Enum enumType)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x6B1418", Offset = "0x6B1418", VA = "0x6B1418")]
		public static string UPvr_StateGetDeviceInfo(PBS_SystemInfoEnum type)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x6B1620", Offset = "0x6B1620", VA = "0x6B1620")]
		public static void UPvr_ControlSetDeviceAction(PBS_DeviceControlEnum deviceControl, Action<int> callback)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x6B176C", Offset = "0x6B176C", VA = "0x6B176C")]
		public static void UPvr_ControlAPPManger(PBS_PackageControlEnum packageControl, string path, Action<int> callback)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x6B1970", Offset = "0x6B1970", VA = "0x6B1970")]
		public static void UPvr_ControlSetAutoConnectWIFI(string ssid, string pwd, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x6B1B4C", Offset = "0x6B1B4C", VA = "0x6B1B4C")]
		public static void UPvr_ControlClearAutoConnectWIFI(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x6B1BEC", Offset = "0x6B1BEC", VA = "0x6B1BEC")]
		public static void UPvr_PropertySetHomeKey(PBS_HomeEventEnum eventEnum, PBS_HomeFunctionEnum function, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x6B1DAC", Offset = "0x6B1DAC", VA = "0x6B1DAC")]
		public static void UPvr_PropertySetHomeKeyAll(PBS_HomeEventEnum eventEnum, PBS_HomeFunctionEnum function, int timesetup, string pkg, string className, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x6B2070", Offset = "0x6B2070", VA = "0x6B2070")]
		public static void UPvr_PropertyDisablePowerKey(bool isSingleTap, bool enable, Action<int> callback)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x6B2220", Offset = "0x6B2220", VA = "0x6B2220")]
		public static void UPvr_PropertySetScreenOffDelay(PBS_ScreenOffDelayTimeEnum timeEnum, Action<int> callback)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x6B236C", Offset = "0x6B236C", VA = "0x6B236C")]
		public static void UPvr_PropertySetSleepDelay(PBS_SleepDelayTimeEnum timeEnum)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x6B2498", Offset = "0x6B2498", VA = "0x6B2498")]
		public static void UPvr_SwitchSystemFunction(PBS_SystemFunctionSwitchEnum systemFunction, PBS_SwitchEnum switchEnum)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x6B26A4", Offset = "0x6B26A4", VA = "0x6B26A4")]
		public static void UPvr_SwitchSetUsbConfigurationOption(PBS_USBConfigModeEnum uSBConfigModeEnum)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x6B283C", Offset = "0x6B283C", VA = "0x6B283C")]
		public static void UPvr_ScreenOn()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x6B28E8", Offset = "0x6B28E8", VA = "0x6B28E8")]
		public static void UPvr_ScreenOff()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x6B2994", Offset = "0x6B2994", VA = "0x6B2994")]
		public static void UPvr_AcquireWakeLock()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x6B2A40", Offset = "0x6B2A40", VA = "0x6B2A40")]
		public static void UPvr_ReleaseWakeLock()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x6B2AEC", Offset = "0x6B2AEC", VA = "0x6B2AEC")]
		public static void UPvr_EnableEnterKey()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x6B2B98", Offset = "0x6B2B98", VA = "0x6B2B98")]
		public static void UPvr_DisableEnterKey()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x6B2C44", Offset = "0x6B2C44", VA = "0x6B2C44")]
		public static void UPvr_EnableVolumeKey()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x6B2CF0", Offset = "0x6B2CF0", VA = "0x6B2CF0")]
		public static void UPvr_DisableVolumeKey()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x6B2D9C", Offset = "0x6B2D9C", VA = "0x6B2D9C")]
		public static void UPvr_EnableBackKey()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x6B2E48", Offset = "0x6B2E48", VA = "0x6B2E48")]
		public static void UPvr_DisableBackKey()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x6B2EF4", Offset = "0x6B2EF4", VA = "0x6B2EF4")]
		public static void UPvr_WriteConfigFileToDataLocal(string path, string content, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x6B3064", Offset = "0x6B3064", VA = "0x6B3064")]
		public static void UPvr_ResetAllKeyToDefault(Action<bool> callback)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x6B3104", Offset = "0x6B3104", VA = "0x6B3104")]
		public static void UPvr_SetAPPAsHome(PBS_SwitchEnum switchEnum, string packageName)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x6B327C", Offset = "0x6B327C", VA = "0x6B327C")]
		public static void UPvr_KillAppsByPidOrPackageName(int[] pids, string[] packageNames)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x6B3438", Offset = "0x6B3438", VA = "0x6B3438")]
		public static void UPvr_FreezeScreen(bool freeze)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x6B355C", Offset = "0x6B355C", VA = "0x6B355C")]
		public static void UPvr_OpenMiracast()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x6B3608", Offset = "0x6B3608", VA = "0x6B3608")]
		public static bool UPvr_IsMiracastOn()
		{
			return default(bool);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x6B36D8", Offset = "0x6B36D8", VA = "0x6B36D8")]
		public static void UPvr_CloseMiracast()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x6B3784", Offset = "0x6B3784", VA = "0x6B3784")]
		public static void UPvr_StartScan()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x6B3830", Offset = "0x6B3830", VA = "0x6B3830")]
		public static void UPvr_StopScan()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x6B38DC", Offset = "0x6B38DC", VA = "0x6B38DC")]
		public static void UPvr_ConnectWifiDisplay(string modelJson)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x6B39E0", Offset = "0x6B39E0", VA = "0x6B39E0")]
		public static void UPvr_DisConnectWifiDisplay()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x6B3A8C", Offset = "0x6B3A8C", VA = "0x6B3A8C")]
		public static void UPvr_ForgetWifiDisplay(string address)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x6B3B90", Offset = "0x6B3B90", VA = "0x6B3B90")]
		public static void UPvr_RenameWifiDisplay(string address, string newName)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x6B3CE0", Offset = "0x6B3CE0", VA = "0x6B3CE0")]
		public static void UPvr_SetWDModelsCallback()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x6B3D60", Offset = "0x6B3D60", VA = "0x6B3D60")]
		public static void UPvr_SetWDJsonCallback()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x6B3DE0", Offset = "0x6B3DE0", VA = "0x6B3DE0")]
		public static void UPvr_UpdateWifiDisplays(Action<string> callback)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x6B3EAC", Offset = "0x6B3EAC", VA = "0x6B3EAC")]
		public static string UPvr_GetConnectedWD()
		{
			return null;
		}
	}
}
[Token(Token = "0x2000096")]
public class Pvr_ToBService : MonoBehaviour
{
	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Text deviceInfoText;

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x452CCC", Offset = "0x452CCC", VA = "0x452CCC")]
	public Pvr_ToBService()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x452CD4", Offset = "0x452CD4", VA = "0x452CD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x452D10", Offset = "0x452D10", VA = "0x452D10")]
	private void Start()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x452D28", Offset = "0x452D28", VA = "0x452D28")]
	private void OnDestory()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x452CD8", Offset = "0x452CD8", VA = "0x452CD8")]
	private void InitToBService()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x452D1C", Offset = "0x452D1C", VA = "0x452D1C")]
	private void BindToBService()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x452D34", Offset = "0x452D34", VA = "0x452D34")]
	private void UnBindToBService()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x452D40", Offset = "0x452D40", VA = "0x452D40")]
	private void BoolCallback(string value)
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x452E20", Offset = "0x452E20", VA = "0x452E20")]
	private void IntCallback(string value)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x452ED4", Offset = "0x452ED4", VA = "0x452ED4")]
	private void LongCallback(string value)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x452F9C", Offset = "0x452F9C", VA = "0x452F9C")]
	private void StringCallback(string value)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x45303C", Offset = "0x45303C", VA = "0x45303C")]
	public void StateGetDeviceInfo()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x453114", Offset = "0x453114", VA = "0x453114")]
	public void ControlSetDeviceAction()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x4531BC", Offset = "0x4531BC", VA = "0x4531BC")]
	private void ControlSetDeviceActionCallBack(int value)
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x4532BC", Offset = "0x4532BC", VA = "0x4532BC")]
	public void AppManager()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x453380", Offset = "0x453380", VA = "0x453380")]
	private void AppManagerCallBack(int value)
	{
	}
}
namespace Pvr_UnitySDKAPI
{
	[Token(Token = "0x2000097")]
	public enum GlobalIntConfigs
	{
		[Token(Token = "0x4000289")]
		EYE_TEXTURE_RESOLUTION0,
		[Token(Token = "0x400028A")]
		EYE_TEXTURE_RESOLUTION1,
		[Token(Token = "0x400028B")]
		SEENSOR_COUNT,
		[Token(Token = "0x400028C")]
		ABILITY6DOF,
		[Token(Token = "0x400028D")]
		PLATFORM_TYPE,
		[Token(Token = "0x400028E")]
		TRACKING_MODE,
		[Token(Token = "0x400028F")]
		LOG_LEVEL,
		[Token(Token = "0x4000290")]
		ENBLE_HAND6DOF_BY_HEAD,
		[Token(Token = "0x4000291")]
		ENBLE_6DOF_GLOBAL_TRACKING,
		[Token(Token = "0x4000292")]
		TARGET_FRAME_RATE,
		[Token(Token = "0x4000293")]
		iShowFPS,
		[Token(Token = "0x4000294")]
		SensorMode,
		[Token(Token = "0x4000295")]
		LOGICFLOW,
		[Token(Token = "0x4000296")]
		EYE_TEXTURE_RES_HIGH,
		[Token(Token = "0x4000297")]
		EYE_TEXTURE_RES_NORMAL,
		[Token(Token = "0x4000298")]
		iCtrlModelLoadingPri,
		[Token(Token = "0x4000299")]
		iPhoneHMDModeEnabled,
		[Token(Token = "0x400029A")]
		isEnableBoundary,
		[Token(Token = "0x400029B")]
		Enable_Activity_Rotation,
		[Token(Token = "0x400029C")]
		GetDisplay_Orientation,
		[Token(Token = "0x400029D")]
		GetWaitFrameNum,
		[Token(Token = "0x400029E")]
		GetResetFrameNum,
		[Token(Token = "0x400029F")]
		EnableFFRBYSYS,
		[Token(Token = "0x40002A0")]
		RotControllerMode
	}
	[Token(Token = "0x2000098")]
	public enum GlobalFloatConfigs
	{
		[Token(Token = "0x40002A2")]
		IPD,
		[Token(Token = "0x40002A3")]
		VFOV,
		[Token(Token = "0x40002A4")]
		HFOV,
		[Token(Token = "0x40002A5")]
		NECK_MODEL_X,
		[Token(Token = "0x40002A6")]
		NECK_MODEL_Y,
		[Token(Token = "0x40002A7")]
		NECK_MODEL_Z,
		[Token(Token = "0x40002A8")]
		DISPLAY_REFRESH_RATE
	}
	[Token(Token = "0x2000099")]
	public enum RenderTextureAntiAliasing
	{
		[Token(Token = "0x40002AA")]
		X_1 = 1,
		[Token(Token = "0x40002AB")]
		X_2 = 2,
		[Token(Token = "0x40002AC")]
		X_4 = 4,
		[Token(Token = "0x40002AD")]
		X_8 = 8
	}
	[Token(Token = "0x200009A")]
	public enum PlatForm
	{
		[Token(Token = "0x40002AF")]
		Android = 1,
		[Token(Token = "0x40002B0")]
		IOS,
		[Token(Token = "0x40002B1")]
		Win,
		[Token(Token = "0x40002B2")]
		Notsupport
	}
	[Token(Token = "0x200009B")]
	public enum RenderTextureDepth
	{
		[Token(Token = "0x40002B4")]
		BD_0 = 0,
		[Token(Token = "0x40002B5")]
		BD_16 = 16,
		[Token(Token = "0x40002B6")]
		BD_24 = 24
	}
	[Token(Token = "0x200009C")]
	public enum RenderTextureLevel
	{
		[Token(Token = "0x40002B8")]
		Normal,
		[Token(Token = "0x40002B9")]
		High
	}
	[Token(Token = "0x200009D")]
	public enum Sensorindex
	{
		[Token(Token = "0x40002BB")]
		Default,
		[Token(Token = "0x40002BC")]
		FirstSensor,
		[Token(Token = "0x40002BD")]
		SecondSensor
	}
	[Token(Token = "0x200009E")]
	public enum Eye
	{
		[Token(Token = "0x40002BF")]
		LeftEye,
		[Token(Token = "0x40002C0")]
		RightEye,
		[Token(Token = "0x40002C1")]
		BothEye
	}
	[Token(Token = "0x200009F")]
	public enum ResUtilsType
	{
		[Token(Token = "0x40002C3")]
		TYPE_TEXTSIZE,
		[Token(Token = "0x40002C4")]
		TYPE_COLOR,
		[Token(Token = "0x40002C5")]
		TYPE_TEXT,
		[Token(Token = "0x40002C6")]
		TYPE_FONT,
		[Token(Token = "0x40002C7")]
		TYPE_VALUE,
		[Token(Token = "0x40002C8")]
		TYPE_DRAWABLE,
		[Token(Token = "0x40002C9")]
		TYPE_OBJECT,
		[Token(Token = "0x40002CA")]
		TYPR_OBJECTARRAY
	}
	[Token(Token = "0x20000A0")]
	public enum TrackingOrigin
	{
		[Token(Token = "0x40002CC")]
		EyeLevel,
		[Token(Token = "0x40002CD")]
		FloorLevel,
		[Token(Token = "0x40002CE")]
		StageLevel
	}
	[Token(Token = "0x20000A1")]
	public enum EFoveationLevel
	{
		[Token(Token = "0x40002D0")]
		Low,
		[Token(Token = "0x40002D1")]
		Med,
		[Token(Token = "0x40002D2")]
		High,
		[Token(Token = "0x40002D3")]
		Top_High
	}
	[Token(Token = "0x20000A2")]
	public enum StereoRenderingPathPico
	{
		[Token(Token = "0x40002D5")]
		MultiPass,
		[Token(Token = "0x40002D6")]
		SinglePass
	}
	[Token(Token = "0x20000A3")]
	public enum ExtraLatencyMode
	{
		[Token(Token = "0x40002D8")]
		ExtraLatencyModeOff,
		[Token(Token = "0x40002D9")]
		ExtraLatencyModeOn,
		[Token(Token = "0x40002DA")]
		ExtraLatencyModeDynamic
	}
	[Token(Token = "0x20000A4")]
	public enum pvrEyePoseStatus
	{
		[Token(Token = "0x40002DC")]
		kGazePointValid = 1,
		[Token(Token = "0x40002DD")]
		kGazeVectorValid = 2,
		[Token(Token = "0x40002DE")]
		kEyeOpennessValid = 4,
		[Token(Token = "0x40002DF")]
		kEyePupilDilationValid = 8,
		[Token(Token = "0x40002E0")]
		kEyePositionGuideValid = 0x10
	}
	[Token(Token = "0x20000A5")]
	public enum TrackingMode
	{
		[Token(Token = "0x40002E2")]
		PVR_TRACKING_MODE_ROTATION = 1,
		[Token(Token = "0x40002E3")]
		PVR_TRACKING_MODE_POSITION = 2,
		[Token(Token = "0x40002E4")]
		PVR_TRACKING_MODE_EYE = 4
	}
	[Token(Token = "0x20000A6")]
	public enum SystemDisplayFrequency
	{
		[Token(Token = "0x40002E6")]
		Default,
		[Token(Token = "0x40002E7")]
		RefreshRate72,
		[Token(Token = "0x40002E8")]
		RefreshRate90
	}
	[Token(Token = "0x20000A7")]
	public struct EyeTrackingData
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int leftEyePoseStatus;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int rightEyePoseStatus;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int combinedEyePoseStatus;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 leftEyeGazePoint;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 rightEyeGazePoint;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 combinedEyeGazePoint;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 leftEyeGazeVector;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rightEyeGazeVector;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 combinedEyeGazeVector;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float leftEyeOpenness;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float rightEyeOpenness;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float leftEyePupilDilation;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float rightEyePupilDilation;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 leftEyePositionGuide;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 rightEyePositionGuide;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 foveatedGazeDirection;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int foveatedGazeTrackingState;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public byte[] reserved;
	}
	[Token(Token = "0x20000A8")]
	public struct EyeTrackingGazeRay
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Direction;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool IsValid;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Origin;
	}
	[Token(Token = "0x20000A9")]
	public struct EyeDeviceInfo
	{
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ViewFrustum targetFrustumLeft;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ViewFrustum targetFrustumRight;
	}
	[Token(Token = "0x20000AA")]
	public struct ViewFrustum
	{
		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float left;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float right;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float top;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float bottom;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float near;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float far;
	}
	[Token(Token = "0x20000AB")]
	public struct EyeSetting
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform eyelocalPosition;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Rect eyeRect;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float eyeFov;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float eyeAspect;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Matrix4x4 eyeProjectionMatrix;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Shader eyeShader;
	}
	[Token(Token = "0x20000AC")]
	public struct Sensor
	{
		[Token(Token = "0x400030C")]
		public const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x6A7D00", Offset = "0x6A7D00", VA = "0x6A7D00")]
		private static extern int Pvr_Enable6DofModule(bool enable);

		[PreserveSig]
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x6A7DC0", Offset = "0x6A7DC0", VA = "0x6A7DC0")]
		private static extern int Pvr_OptionalResetSensor(int index, int resetRot, int resetPos);

		[PreserveSig]
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x6A7E8C", Offset = "0x6A7E8C", VA = "0x6A7E8C")]
		private static extern int Pvr_Init(int index);

		[PreserveSig]
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x6A7F4C", Offset = "0x6A7F4C", VA = "0x6A7F4C")]
		private static extern int Pvr_StartSensor(int index);

		[PreserveSig]
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x6A800C", Offset = "0x6A800C", VA = "0x6A800C")]
		private static extern int Pvr_StopSensor(int index);

		[PreserveSig]
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x6A80CC", Offset = "0x6A80CC", VA = "0x6A80CC")]
		private static extern int Pvr_ResetSensor(int index);

		[PreserveSig]
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x6A818C", Offset = "0x6A818C", VA = "0x6A818C")]
		private static extern int Pvr_ResetSensorAll(int index);

		[PreserveSig]
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x6A824C", Offset = "0x6A824C", VA = "0x6A824C")]
		private static extern int Pvr_GetSensorState(int index, ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz);

		[PreserveSig]
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x6A8340", Offset = "0x6A8340", VA = "0x6A8340")]
		private static extern int Pvr_GetMainSensorState(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber);

		[PreserveSig]
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x6A8440", Offset = "0x6A8440", VA = "0x6A8440")]
		private static extern int Pvr_GetPsensorState();

		[PreserveSig]
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x6A84F0", Offset = "0x6A84F0", VA = "0x6A84F0")]
		private static extern int Pvr_GetHmdPSensorStatus();

		[PreserveSig]
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x6A85A0", Offset = "0x6A85A0", VA = "0x6A85A0")]
		private static extern int Pvr_GetSensorGyroscope(int index, ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x6A8674", Offset = "0x6A8674", VA = "0x6A8674")]
		private static extern int Pvr_GetSensorMagnet(int index, ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x6A8748", Offset = "0x6A8748", VA = "0x6A8748")]
		private static extern int Pvr_Get6DofSensorQualityStatus();

		[PreserveSig]
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x6A87F8", Offset = "0x6A87F8", VA = "0x6A87F8")]
		private static extern bool Pvr_Get6DofSafePanelFlag();

		[PreserveSig]
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x6A88B0", Offset = "0x6A88B0", VA = "0x6A88B0")]
		private static extern void Pvr_SetReinPosition(float x, float y, float z, float w, float px, float py, float pz, int hand, bool valid, int key);

		[PreserveSig]
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x6A89B8", Offset = "0x6A89B8", VA = "0x6A89B8")]
		private static extern bool Pvr_SetTrackingOriginType(TrackingOrigin trackingOriginType);

		[PreserveSig]
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x6A8A80", Offset = "0x6A8A80", VA = "0x6A8A80")]
		private static extern bool Pvr_GetAcceleration(ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x6A8B54", Offset = "0x6A8B54", VA = "0x6A8B54")]
		private static extern bool Pvr_GetAngularVelocity(ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x6A8C28", Offset = "0x6A8C28", VA = "0x6A8C28")]
		private static extern bool Pvr_GetVelocity(ref float x, ref float y, ref float z);

		[PreserveSig]
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x6A8CFC", Offset = "0x6A8CFC", VA = "0x6A8CFC")]
		private static extern bool Pvr_GetAngularAcceleration(ref float x, ref float y, ref float z);

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x6A8DD0", Offset = "0x6A8DD0", VA = "0x6A8DD0")]
		public static bool UPvr_Pvr_Get6DofSafePanelFlag()
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x6A8DD4", Offset = "0x6A8DD4", VA = "0x6A8DD4")]
		public static int UPvr_Init(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x6A8DD8", Offset = "0x6A8DD8", VA = "0x6A8DD8")]
		public static void UPvr_InitPsensor()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x6A9060", Offset = "0x6A9060", VA = "0x6A9060")]
		public static int UPvr_GetPsensorState()
		{
			return default(int);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x6A92EC", Offset = "0x6A92EC", VA = "0x6A92EC")]
		public static int UPvr_GetPSensorStatus()
		{
			return default(int);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x6A92F0", Offset = "0x6A92F0", VA = "0x6A92F0")]
		public static void UPvr_UnregisterPsensor()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x6A9504", Offset = "0x6A9504", VA = "0x6A9504")]
		public static int UPvr_StartSensor(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x6A9508", Offset = "0x6A9508", VA = "0x6A9508")]
		public static int UPvr_StopSensor(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x6A950C", Offset = "0x6A950C", VA = "0x6A950C")]
		public static int UPvr_ResetSensor(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x6A95B0", Offset = "0x6A95B0", VA = "0x6A95B0")]
		public static int UPvr_OptionalResetSensor(int index, int resetRot, int resetPos)
		{
			return default(int);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x6A95C8", Offset = "0x6A95C8", VA = "0x6A95C8")]
		public static int UPvr_GetSensorState(int index, ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz)
		{
			return default(int);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x6A9604", Offset = "0x6A9604", VA = "0x6A9604")]
		public static int UPvr_GetMainSensorState(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber)
		{
			return default(int);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x6A9654", Offset = "0x6A9654", VA = "0x6A9654")]
		public static int UPvr_GetSensorGyroscope(int index, ref float x, ref float y, ref float z)
		{
			return default(int);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x6A9674", Offset = "0x6A9674", VA = "0x6A9674")]
		public static int UPvr_GetSensorMagnet(int index, ref float x, ref float y, ref float z)
		{
			return default(int);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x6A9694", Offset = "0x6A9694", VA = "0x6A9694")]
		public static int UPvr_Get6DofSensorQualityStatus()
		{
			return default(int);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x6A9698", Offset = "0x6A9698", VA = "0x6A9698")]
		public static int UPvr_Enable6DofModule(bool enable)
		{
			return default(int);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x6A8DDC", Offset = "0x6A8DDC", VA = "0x6A8DDC")]
		public static void Pvr_InitPsensor()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x6A99A8", Offset = "0x6A99A8", VA = "0x6A99A8")]
		public static bool Pvr_IsHead6dofReset()
		{
			return default(bool);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x6A90BC", Offset = "0x6A90BC", VA = "0x6A90BC")]
		public static int Pvr_GetAndroidPsensorState()
		{
			return default(int);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x6A92F4", Offset = "0x6A92F4", VA = "0x6A92F4")]
		public static void Pvr_UnregisterPsensor()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x6A9C80", Offset = "0x6A9C80", VA = "0x6A9C80")]
		public static int UPvr_ResetSensorAll(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x6A9C84", Offset = "0x6A9C84", VA = "0x6A9C84")]
		public static void UPvr_SetReinPosition(float x, float y, float z, float w, float px, float py, float pz, int hand, bool valid, int key)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x6AA2BC", Offset = "0x6AA2BC", VA = "0x6AA2BC")]
		public static bool UPvr_SetTrackingOriginType(TrackingOrigin trackingOriginType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x6AA2C0", Offset = "0x6AA2C0", VA = "0x6AA2C0")]
		public static Vector3 UPvr_GetAcceleration()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x6AA31C", Offset = "0x6AA31C", VA = "0x6AA31C")]
		public static Vector3 UPvr_AngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x6AA380", Offset = "0x6AA380", VA = "0x6AA380")]
		public static Vector3 UPvr_GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x6AA3DC", Offset = "0x6AA3DC", VA = "0x6AA3DC")]
		public static Vector3 UPvr_GetAngularAcceleration()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000AD")]
	public struct Render
	{
		[Token(Token = "0x400030D")]
		public const string LibFileName = "Pvr_UnitySDK";

		[Token(Token = "0x17000050")]
		public static float[] SystemDisplayFrequenciesAvailable
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x6A5344", Offset = "0x6A5344", VA = "0x6A5344")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public static float systemDisplayFrequency
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x6A53C8", Offset = "0x6A53C8", VA = "0x6A53C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x6A5418", Offset = "0x6A5418", VA = "0x6A5418")]
			set
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x6A5420", Offset = "0x6A5420", VA = "0x6A5420")]
		private static extern void Pvr_ChangeScreenParameters(string model, int width, int height, double xppi, double yppi, double densityDpi);

		[PreserveSig]
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x6A552C", Offset = "0x6A552C", VA = "0x6A552C")]
		private static extern int Pvr_SetRatio(float midH, float midV);

		[PreserveSig]
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x6A55F0", Offset = "0x6A55F0", VA = "0x6A55F0")]
		private static extern int Pvr_SetPupillaryPoint(bool enable);

		[PreserveSig]
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x6A56B0", Offset = "0x6A56B0", VA = "0x6A56B0")]
		private static extern IntPtr Pvr_GetSupportHMDTypes();

		[PreserveSig]
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x6A5760", Offset = "0x6A5760", VA = "0x6A5760")]
		private static extern void Pvr_SetCurrentHMDType(string type);

		[PreserveSig]
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x6A583C", Offset = "0x6A583C", VA = "0x6A583C")]
		private static extern int Pvr_GetIntConfig(int configsenum, ref int res);

		[PreserveSig]
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x6A5904", Offset = "0x6A5904", VA = "0x6A5904")]
		private static extern int Pvr_GetFloatConfig(int configsenum, ref float res);

		[PreserveSig]
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x6A59CC", Offset = "0x6A59CC", VA = "0x6A59CC")]
		private static extern void Pvr_SetupLayerData(int layerIndex, int sideMask, int textureId, int textureType, int layerFlags, float[] colorScaleAndOffset);

		[PreserveSig]
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x6A5AB8", Offset = "0x6A5AB8", VA = "0x6A5AB8")]
		private static extern void Pvr_SetupLayerCoords(int layerIndex, int sideMask, float[] lowerLeft, float[] lowerRight, float[] upperLeft, float[] upperRight);

		[PreserveSig]
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x6A5BBC", Offset = "0x6A5BBC", VA = "0x6A5BBC")]
		private static extern void Pvr_SetOverlayModelViewMatrix(int overlayType, int overlayShape, int texId, int eyeSide, int layerIndex, bool isHeadLocked, int layerFlags, float[] mvMatrix, float[] modelS, float[] modelR, float[] modelT, float[] cameraR, float[] cameraT, float[] colorScaleAndOffset);

		[PreserveSig]
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x6A5D10", Offset = "0x6A5D10", VA = "0x6A5D10")]
		private static extern bool Pvr_EnableFoveation(bool enable);

		[PreserveSig]
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x6A5DD8", Offset = "0x6A5DD8", VA = "0x6A5DD8")]
		private static extern void Pvr_SetFoveationParameters(int textureId, int previousId, float focalPointX, float focalPointY, float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum);

		[PreserveSig]
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x6A5ED0", Offset = "0x6A5ED0", VA = "0x6A5ED0")]
		private static extern void Pvr_SetFoveationResource(int textureId, int previousId, float focalPointX, float focalPointY);

		[PreserveSig]
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x6A5FA8", Offset = "0x6A5FA8", VA = "0x6A5FA8")]
		private static extern void Pvr_SetFoveationParameters2(float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum);

		[PreserveSig]
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x6A6080", Offset = "0x6A6080", VA = "0x6A6080")]
		private static extern void Pvr_SetFoveationLevel(EFoveationLevel level);

		[PreserveSig]
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x6A6140", Offset = "0x6A6140", VA = "0x6A6140")]
		private static extern EFoveationLevel Pvr_GetFoveationLevel();

		[PreserveSig]
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x6A61F0", Offset = "0x6A61F0", VA = "0x6A61F0")]
		private static extern bool Pvr_GetIntSysProc(string property, ref int res);

		[PreserveSig]
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x6A62E4", Offset = "0x6A62E4", VA = "0x6A62E4")]
		private static extern void Pvr_SetColorspaceType(int colorspaceType);

		[PreserveSig]
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x6A63A4", Offset = "0x6A63A4", VA = "0x6A63A4")]
		private static extern void Pvr_SetCastingColorspaceType(int colorspaceType);

		[PreserveSig]
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x6A6464", Offset = "0x6A6464", VA = "0x6A6464")]
		private static extern IntPtr Pvr_CreateLayerAndroidSurface(int layerType, int layerIndex);

		[PreserveSig]
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x6A652C", Offset = "0x6A652C", VA = "0x6A652C")]
		private static extern IntPtr Pvr_GetLayerAndroidSurface(int layerType, int layerIndex);

		[PreserveSig]
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x6A65F4", Offset = "0x6A65F4", VA = "0x6A65F4")]
		private static extern void Pvr_SetMonoMode(bool openMono);

		[PreserveSig]
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x6A66B4", Offset = "0x6A66B4", VA = "0x6A66B4")]
		private static extern void Pvr_GetStencilMesh(int eye, ref int vertexCount, ref int triangleCount, ref IntPtr vertexData, ref IntPtr indexData);

		[PreserveSig]
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x6A6790", Offset = "0x6A6790", VA = "0x6A6790")]
		private static extern int Pvr_GetRefreshRate(ref float rate);

		[PreserveSig]
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x6A6850", Offset = "0x6A6850", VA = "0x6A6850")]
		private static extern int Pvr_SetRefreshRate(float rate);

		[PreserveSig]
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x6A6910", Offset = "0x6A6910", VA = "0x6A6910")]
		private static extern bool Pvr_GetRawCameraFrame(byte[] buffer, ref uint width, ref uint height, ref uint count);

		[PreserveSig]
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x6A69F4", Offset = "0x6A69F4", VA = "0x6A69F4")]
		private static extern int Pvr_GetDisplayFrequenciesAvailable(float[] rate, int length);

		[PreserveSig]
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x6A6AC4", Offset = "0x6A6AC4", VA = "0x6A6AC4")]
		private static extern int Pvr_SetDisplayFrequency(float rate);

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x6A5348", Offset = "0x6A5348", VA = "0x6A5348")]
		public static float[] UPvr_GetDisplayFrequenciesAvailable()
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x6A6B84", Offset = "0x6A6B84", VA = "0x6A6B84")]
		public static void UPvr_SetDisplayFrequency(float rate)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x6A6B88", Offset = "0x6A6B88", VA = "0x6A6B88")]
		public static void UPvr_GetRawCameraData(byte[] buffer, ref uint width, ref uint height, ref uint count)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x6A6BA8", Offset = "0x6A6BA8", VA = "0x6A6BA8")]
		public static void UPvr_ChangeScreenParameters(string model, int width, int height, double xppi, double yppi, double densityDpi)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x6A6BCC", Offset = "0x6A6BCC", VA = "0x6A6BCC")]
		public static int UPvr_SetRatio(float midH, float midV)
		{
			return default(int);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x6A6BD0", Offset = "0x6A6BD0", VA = "0x6A6BD0")]
		public static void UPvr_EnableFoveation(bool enable)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x6A6E68", Offset = "0x6A6E68", VA = "0x6A6E68")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x162304", Offset = "0x162304")]
		public static void UPvr_SetFoveationParameters(int textureId, int previousId, float focalPointX, float focalPointY, float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x6A6EA8", Offset = "0x6A6EA8", VA = "0x6A6EA8")]
		public static void UPvr_SetFoveationResource(int textureId, int previousId, float focalPointX, float focalPointY)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x6A6EC8", Offset = "0x6A6EC8", VA = "0x6A6EC8")]
		public static void SetFoveatedRenderingLevel(EFoveationLevel level)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x6A7044", Offset = "0x6A7044", VA = "0x6A7044")]
		public static EFoveationLevel GetFoveatedRenderingLevel()
		{
			return default(EFoveationLevel);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x6A7048", Offset = "0x6A7048", VA = "0x6A7048")]
		public static void SetFoveatedRenderingParameters(Vector2 ffrGainValue, float ffrAreaValue, float ffrMinimumValue)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x6A71F0", Offset = "0x6A71F0", VA = "0x6A71F0")]
		public static bool UPvr_GetIntSysProc(string property, ref int res)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x6A71F4", Offset = "0x6A71F4", VA = "0x6A71F4")]
		public static int UPvr_GetIntConfig(int configsenum, ref int res)
		{
			return default(int);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x6A71F8", Offset = "0x6A71F8", VA = "0x6A71F8")]
		public static int UPvr_GetFloatConfig(int configsenum, ref float res)
		{
			return default(int);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x6A71FC", Offset = "0x6A71FC", VA = "0x6A71FC")]
		public static string UPvr_GetSupportHMDTypes()
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x6A72A8", Offset = "0x6A72A8", VA = "0x6A72A8")]
		public static void UPvr_SetCurrentHMDType(string type)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x6A72AC", Offset = "0x6A72AC", VA = "0x6A72AC")]
		public static void UPvr_SetupLayerData(int layerIndex, int sideMask, int textureId, int textureType, int layerFlags, Vector4 colorScale, Vector4 colorOffset)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x6A745C", Offset = "0x6A745C", VA = "0x6A745C")]
		public static void UPvr_SetupLayerCoords(int layerIndex, int sideMask, float[] lowerLeft, float[] lowerRight, float[] upperLeft, float[] upperRight)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x6A7480", Offset = "0x6A7480", VA = "0x6A7480")]
		public static void UPvr_SetOverlayModelViewMatrix(int overlayType, int overlayShape, int texId, int eyeSide, int layerIndex, bool isHeadLocked, int layerFlags, Matrix4x4 mvMatrix, Vector3 modelS, Quaternion modelR, Vector3 modelT, Quaternion cameraR, Vector3 cameraT, Vector4 colorScale, Vector4 colorOffset)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x6A7BC4", Offset = "0x6A7BC4", VA = "0x6A7BC4")]
		public static void UPvr_SetColorspaceType(int colorspaceType)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x6A7BC8", Offset = "0x6A7BC8", VA = "0x6A7BC8")]
		public static void UPvr_SetCastingColorspaceType(int colorspaceType)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x6A7BCC", Offset = "0x6A7BCC", VA = "0x6A7BCC")]
		public static IntPtr UPvr_CreateLayerAndroidSurface(int layerType, int layerIndex)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x6A7BD0", Offset = "0x6A7BD0", VA = "0x6A7BD0")]
		public static IntPtr UPvr_GetLayerAndroidSurface(int layerType, int layerIndex)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x6A7BD4", Offset = "0x6A7BD4", VA = "0x6A7BD4")]
		public static void UPvr_SetMonoMode(bool openMono)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x6A7CDC", Offset = "0x6A7CDC", VA = "0x6A7CDC")]
		public static void UPvr_GetStencilMesh(int eye, ref int vertexCount, ref int triangleCount, ref IntPtr vertexDataPtr, ref IntPtr indexDataPtr)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x6A53F0", Offset = "0x6A53F0", VA = "0x6A53F0")]
		public static float UPvr_GetSystemDisplayFrequency()
		{
			return default(float);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x6A541C", Offset = "0x6A541C", VA = "0x6A541C")]
		public static void UPvr_SetSystemDisplayFrequency(float rate)
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public struct System
	{
		[Token(Token = "0x400030E")]
		public const string LibFileName = "Pvr_UnitySDK";

		[Token(Token = "0x400030F")]
		public const string UnitySDKVersion = "2.8.11.5";

		[PreserveSig]
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x6AA440", Offset = "0x6AA440", VA = "0x6AA440")]
		public static extern void Pvr_SetInitActivity(IntPtr activity, IntPtr vrActivityClass);

		[PreserveSig]
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x6AA508", Offset = "0x6AA508", VA = "0x6AA508")]
		private static extern IntPtr Pvr_GetSDKVersion();

		[PreserveSig]
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x6AA5B8", Offset = "0x6AA5B8", VA = "0x6AA5B8")]
		public static extern int Pvr_GetHmdHardwareVersion();

		[PreserveSig]
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x6AA668", Offset = "0x6AA668", VA = "0x6AA668")]
		public static extern IntPtr Pvr_GetHmdFirmwareVersion();

		[PreserveSig]
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x6AA718", Offset = "0x6AA718", VA = "0x6AA718")]
		public static extern IntPtr Pvr_GetHmdSerialNumber();

		[PreserveSig]
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x6AA7C8", Offset = "0x6AA7C8", VA = "0x6AA7C8")]
		public static extern int PVR_GetHmdBatteryStatus();

		[PreserveSig]
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x6AA878", Offset = "0x6AA878", VA = "0x6AA878")]
		public static extern float PVR_GetHmdBatteryTemperature();

		[PreserveSig]
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x6AA928", Offset = "0x6AA928", VA = "0x6AA928")]
		public static extern int PVR_SetHmdAudioStatus(bool enable);

		[PreserveSig]
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x6AA9E8", Offset = "0x6AA9E8", VA = "0x6AA9E8")]
		public static extern bool Pvr_GetEyeTrackingData(ref int leftEyePoseStatus, ref int rightEyePoseStatus, ref int combinedEyePoseStatus, ref float leftEyeGazePointX, ref float leftEyeGazePointY, ref float leftEyeGazePointZ, ref float rightEyeGazePointX, ref float rightEyeGazePointY, ref float rightEyeGazePointZ, ref float combinedEyeGazePointX, ref float combinedEyeGazePointY, ref float combinedEyeGazePointZ, ref float leftEyeGazeVectorX, ref float leftEyeGazeVectorY, ref float leftEyeGazeVectorZ, ref float rightEyeGazeVectorX, ref float rightEyeGazeVectorY, ref float rightEyeGazeVectorZ, ref float combinedEyeGazeVectorX, ref float combinedEyeGazeVectorY, ref float combinedEyeGazeVectorZ, ref float leftEyeOpenness, ref float rightEyeOpenness, ref float leftEyePupilDilation, ref float rightEyePupilDilation, ref float leftEyePositionGuideX, ref float leftEyePositionGuideY, ref float leftEyePositionGuideZ, ref float rightEyePositionGuideX, ref float rightEyePositionGuideY, ref float rightEyePositionGuideZ, ref float foveatedGazeDirectionX, ref float foveatedGazeDirectionY, ref float foveatedGazeDirectionZ, ref int foveatedGazeTrackingState);

		[PreserveSig]
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x6AABA0", Offset = "0x6AABA0", VA = "0x6AABA0")]
		public static extern bool Pvr_SetTrackingMode(int trackingMode);

		[PreserveSig]
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x6AAC68", Offset = "0x6AAC68", VA = "0x6AAC68")]
		public static extern int Pvr_GetTrackingMode();

		[PreserveSig]
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x6AAD18", Offset = "0x6AAD18", VA = "0x6AAD18")]
		public static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x6AADC8", Offset = "0x6AADC8", VA = "0x6AADC8")]
		public static extern void UnityEventData(long data);

		[PreserveSig]
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x6AAE90", Offset = "0x6AAE90", VA = "0x6AAE90")]
		public static extern bool Pvr_EnableSinglePass(bool enable);

		[PreserveSig]
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x6AAF58", Offset = "0x6AAF58", VA = "0x6AAF58")]
		public static extern void Pvr_SetAntiAliasing(int antiAliasing);

		[PreserveSig]
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x6AB018", Offset = "0x6AB018", VA = "0x6AB018")]
		public static extern void Pvr_SinglePassBeforeForwardOpaque();

		[PreserveSig]
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x6AB0C8", Offset = "0x6AB0C8", VA = "0x6AB0C8")]
		public static extern void Pvr_SetCurrentRenderTexture(uint textureId);

		[PreserveSig]
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x6AB188", Offset = "0x6AB188", VA = "0x6AB188")]
		public static extern bool Pvr_SetSinglePassDepthBufferWidthHeight(int width, int height);

		[PreserveSig]
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x6AB258", Offset = "0x6AB258", VA = "0x6AB258")]
		public static extern int PVR_setPerformanceLevels(int cpuLevel, int gpuLevel);

		[PreserveSig]
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x6AB320", Offset = "0x6AB320", VA = "0x6AB320")]
		public static extern bool Pvr_SetIPD(float distance);

		[PreserveSig]
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x6AB3E8", Offset = "0x6AB3E8", VA = "0x6AB3E8")]
		public static extern float Pvr_GetIPD();

		[PreserveSig]
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x6AB498", Offset = "0x6AB498", VA = "0x6AB498")]
		public static extern bool Pvr_SetTrackingIPDEnabled(bool enable);

		[PreserveSig]
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x6AB560", Offset = "0x6AB560", VA = "0x6AB560")]
		public static extern bool Pvr_GetTrackingIPDEnabled();

		[PreserveSig]
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x6AB618", Offset = "0x6AB618", VA = "0x6AB618")]
		public static extern bool Pvr_GetEyeTrackingAutoIPD(ref float autoIPD);

		[PreserveSig]
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x6A5294", Offset = "0x6A5294", VA = "0x6A5294")]
		public static extern int PVR_GetHmdAudioStatus();

		[PreserveSig]
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x6AB6E0", Offset = "0x6AB6E0", VA = "0x6AB6E0")]
		private static extern float Pvr_GetPredictedDisplayTime();

		[PreserveSig]
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x6AB790", Offset = "0x6AB790", VA = "0x6AB790")]
		public static extern bool Pvr_SetExtraLatencyMode(int mode);

		[Token(Token = "0x60004EF")]
		public static bool UPvr_CallStaticMethod<T>(ref T result, AndroidJavaClass jclass, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x6A969C", Offset = "0x6A969C", VA = "0x6A969C")]
		public static bool UPvr_CallStaticMethod(AndroidJavaObject jobj, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		public static bool UPvr_CallMethod<T>(ref T result, AndroidJavaObject jobj, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x6AB858", Offset = "0x6AB858", VA = "0x6AB858")]
		public static bool UPvr_CallMethod(AndroidJavaObject jobj, string name, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x6ABB64", Offset = "0x6ABB64", VA = "0x6ABB64")]
		public static string UPvr_GetSDKVersion()
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x6ABC54", Offset = "0x6ABC54", VA = "0x6ABC54")]
		public static string UPvr_GetUnitySDKVersion()
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x6ABCB0", Offset = "0x6ABCB0", VA = "0x6ABCB0")]
		public static string UPvr_GetDeviceMode()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x6ABD30", Offset = "0x6ABD30", VA = "0x6ABD30")]
		public static string UPvr_GetDeviceModel()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x6A4078", Offset = "0x6A4078", VA = "0x6A4078")]
		public static string UPvr_GetDeviceSN()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x6A4598", Offset = "0x6A4598", VA = "0x6A4598")]
		public static AndroidJavaObject UPvr_GetCurrentActivity()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x6ABD3C", Offset = "0x6ABD3C", VA = "0x6ABD3C")]
		public static bool UPvr_SetMonoPresentation()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x6ABDD8", Offset = "0x6ABDD8", VA = "0x6ABDD8")]
		public static bool UPvr_IsPresentationExisted()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x6ABEA4", Offset = "0x6ABEA4", VA = "0x6ABEA4")]
		public static bool UPvr_GetMainActivityPauseStatus()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x6ABF70", Offset = "0x6ABF70", VA = "0x6ABF70")]
		public static void UPvr_Sleep()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x6AC048", Offset = "0x6AC048", VA = "0x6AC048")]
		public static bool UPvr_StartHomeKeyReceiver(string startreceivre)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x6AC3A8", Offset = "0x6AC3A8", VA = "0x6AC3A8")]
		public static bool UPvr_StopHomeKeyReceiver()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x6AC6C0", Offset = "0x6AC6C0", VA = "0x6AC6C0")]
		public static void UPvr_StartVRModel()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x6AC798", Offset = "0x6AC798", VA = "0x6AC798")]
		public static void UPvr_RemovePlatformLogo()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x6AC870", Offset = "0x6AC870", VA = "0x6AC870")]
		public static void UPvr_ShowPlatformLogo()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x6AC948", Offset = "0x6AC948", VA = "0x6AC948")]
		public static bool UPvr_IsPicoActivity()
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x6ACAB0", Offset = "0x6ACAB0", VA = "0x6ACAB0")]
		public static void UPvr_StopVRModel()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x6ACB88", Offset = "0x6ACB88", VA = "0x6ACB88")]
		public static string UPvr_GetCountryCode()
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x6ACD2C", Offset = "0x6ACD2C", VA = "0x6ACD2C")]
		public static bool UPvr_SetIPD(float distance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x6AD2D0", Offset = "0x6AD2D0", VA = "0x6AD2D0")]
		public static float UPvr_GetIPD()
		{
			return default(float);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x6AD3D8", Offset = "0x6AD3D8", VA = "0x6AD3D8")]
		public static bool UPvr_SetTrackingIPDEnabled(bool enable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x6AD3DC", Offset = "0x6AD3DC", VA = "0x6AD3DC")]
		public static bool UPvr_GetTrackingIPDEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x6AD3E0", Offset = "0x6AD3E0", VA = "0x6AD3E0")]
		public static bool UPvr_GetEyeTrackingAutoIPD(ref float autoipd)
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x6AD3E4", Offset = "0x6AD3E4", VA = "0x6AD3E4")]
		public static void UPvr_UnityEventData(long data)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x6AD3FC", Offset = "0x6AD3FC", VA = "0x6AD3FC")]
		public static long UPvr_GetEyeBufferData(int id)
		{
			return default(long);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x6AD49C", Offset = "0x6AD49C", VA = "0x6AD49C")]
		public static bool UPvr_checkDevice(string packagename)
		{
			return default(bool);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x6AD644", Offset = "0x6AD644", VA = "0x6AD644")]
		public static int UPvr_GetHmdHardwareVersion()
		{
			return default(int);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x6AD648", Offset = "0x6AD648", VA = "0x6AD648")]
		public static string UPvr_GetHmdFirmwareVersion()
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x6AD738", Offset = "0x6AD738", VA = "0x6AD738")]
		public static string UPvr_GetHmdSerialNumber()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x6AD828", Offset = "0x6AD828", VA = "0x6AD828")]
		public static int UPvr_GetHmdBatteryStatus()
		{
			return default(int);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x6AD82C", Offset = "0x6AD82C", VA = "0x6AD82C")]
		public static float UPvr_GetHmdBatteryTemperature()
		{
			return default(float);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x6AD830", Offset = "0x6AD830", VA = "0x6AD830")]
		public static int UPvr_SetHmdAudioStatus(bool enable)
		{
			return default(int);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x6AD834", Offset = "0x6AD834", VA = "0x6AD834")]
		public static int UPvr_GetTrackingMode()
		{
			return default(int);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x6AD838", Offset = "0x6AD838", VA = "0x6AD838")]
		public static bool UPvr_setTrackingMode(int trackingMode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x6AD83C", Offset = "0x6AD83C", VA = "0x6AD83C")]
		public static bool UPvr_getEyeTrackingData(ref EyeTrackingData trackingData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x6ADB10", Offset = "0x6ADB10", VA = "0x6ADB10")]
		public static bool UPvr_getEyeTrackingGazeRay(ref EyeTrackingGazeRay gazeRay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x6ADE30", Offset = "0x6ADE30", VA = "0x6ADE30")]
		public static bool UPvr_getEyeTrackingGazeRayWorld(ref EyeTrackingGazeRay gazeRay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x6AE1D8", Offset = "0x6AE1D8", VA = "0x6AE1D8")]
		public static Vector3 UPvr_getEyeTrackingPos()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x6AE6E0", Offset = "0x6AE6E0", VA = "0x6AE6E0")]
		public static int UPvr_GetPhoneScreenBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x6AE83C", Offset = "0x6AE83C", VA = "0x6AE83C")]
		public static void UPvr_SetPhoneScreenBrightness(int level)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x6AE9DC", Offset = "0x6AE9DC", VA = "0x6AE9DC")]
		public static bool UPvr_IsPicoDefaultActivity()
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x6AED5C", Offset = "0x6AED5C", VA = "0x6AED5C")]
		public static bool UPvr_EnableSinglePass(bool enable)
		{
			return default(bool);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x6AED60", Offset = "0x6AED60", VA = "0x6AED60")]
		public static void UPvr_SetAntiAliasing(int antiAliasing)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x6AED64", Offset = "0x6AED64", VA = "0x6AED64")]
		public static void UPvr_SinglePassBeforeForwardOpaque()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x6AED68", Offset = "0x6AED68", VA = "0x6AED68")]
		public static void UPvr_SetCurrentRenderTexture(uint textureId)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x6AED6C", Offset = "0x6AED6C", VA = "0x6AED6C")]
		public static bool UPvr_SetSinglePassDepthBufferWidthHeight(int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x6AED70", Offset = "0x6AED70", VA = "0x6AED70")]
		public static int UPVR_setPerformanceLevels(int cpuLevel, int gpuLevel)
		{
			return default(int);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x6AED74", Offset = "0x6AED74", VA = "0x6AED74")]
		public static int UPvr_GetColorRes(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x6AF000", Offset = "0x6AF000", VA = "0x6AF000")]
		public static int UPvr_GetConfigInt(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x6AF28C", Offset = "0x6AF28C", VA = "0x6AF28C")]
		public static string UPvr_GetConfigString(string name)
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x6AF560", Offset = "0x6AF560", VA = "0x6AF560")]
		public static string UPvr_GetDrawableLocation(string name)
		{
			return null;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x6AF834", Offset = "0x6AF834", VA = "0x6AF834")]
		public static int UPvr_GetTextSize(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x6AFAC0", Offset = "0x6AFAC0", VA = "0x6AFAC0")]
		public static string UPvr_GetLangString(string name)
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x6AFD94", Offset = "0x6AFD94", VA = "0x6AFD94")]
		public static string UPvr_GetStringValue(string id, int type)
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x6B00D4", Offset = "0x6B00D4", VA = "0x6B00D4")]
		public static int UPvr_GetIntValue(string id, int type)
		{
			return default(int);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x6B03CC", Offset = "0x6B03CC", VA = "0x6B03CC")]
		public static float UPvr_GetFloatValue(string id)
		{
			return default(float);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x6B065C", Offset = "0x6B065C", VA = "0x6B065C")]
		public static string UPvr_GetObjectOrArray(string id, int type)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x6B099C", Offset = "0x6B099C", VA = "0x6B099C")]
		public static int UPvr_GetCharSpace(string id)
		{
			return default(int);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x6B0C28", Offset = "0x6B0C28", VA = "0x6B0C28")]
		public static bool UPvr_SetExtraLatencyMode(ExtraLatencyMode mode)
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x6B0C2C", Offset = "0x6B0C2C", VA = "0x6B0C2C")]
		public static float UPvr_GetPredictedDisplayTime()
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000AF")]
	public struct BoundarySystem
	{
		[Token(Token = "0x20000B0")]
		public enum BoundaryType
		{
			[Token(Token = "0x4000312")]
			OuterBoundary,
			[Token(Token = "0x4000313")]
			PlayArea
		}

		[Token(Token = "0x20000B1")]
		public struct BoundaryTestResult
		{
			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool IsTriggering;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float ClosestDistance;

			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 ClosestPoint;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 ClosestPointNormal;
		}

		[Token(Token = "0x20000B2")]
		public enum BoundaryTrackingNode
		{
			[Token(Token = "0x4000319")]
			HandLeft,
			[Token(Token = "0x400031A")]
			HandRight,
			[Token(Token = "0x400031B")]
			Head
		}

		[Token(Token = "0x20000B3")]
		public enum BoundaryTrackingState
		{
			[Token(Token = "0x400031D")]
			LostNoReason = 3,
			[Token(Token = "0x400031E")]
			LostCamera,
			[Token(Token = "0x400031F")]
			LostHighLight,
			[Token(Token = "0x4000320")]
			LostLowLight,
			[Token(Token = "0x4000321")]
			LostLowFeatureCount,
			[Token(Token = "0x4000322")]
			LostReLocation,
			[Token(Token = "0x4000323")]
			LostInitialization,
			[Token(Token = "0x4000324")]
			LostNoCamera,
			[Token(Token = "0x4000325")]
			LostNoIMU,
			[Token(Token = "0x4000326")]
			LostIMUJitter,
			[Token(Token = "0x4000327")]
			LostUnknown
		}

		[Token(Token = "0x4000310")]
		public const string LibFileName = "Pvr_UnitySDK";

		[PreserveSig]
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x4655F8", Offset = "0x4655F8", VA = "0x4655F8")]
		private static extern float Pvr_GetFloorHeight();

		[PreserveSig]
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x4656A8", Offset = "0x4656A8", VA = "0x4656A8")]
		private static extern int Pvr_GetSeeThroughState();

		[PreserveSig]
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x465758", Offset = "0x465758", VA = "0x465758")]
		private static extern void Pvr_BoundarySetSTBackground(bool value);

		[PreserveSig]
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x465818", Offset = "0x465818", VA = "0x465818")]
		private static extern int Pvr_GetTrackingState();

		[PreserveSig]
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x4658C8", Offset = "0x4658C8", VA = "0x4658C8")]
		private static extern bool Pvr_GetFrameRateLimit();

		[PreserveSig]
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x465980", Offset = "0x465980", VA = "0x465980")]
		private static extern bool Pvr_IsBoundaryEnable();

		[PreserveSig]
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x465A38", Offset = "0x465A38", VA = "0x465A38")]
		private static extern bool Pvr_BoundaryGetConfigured();

		[PreserveSig]
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x465AF0", Offset = "0x465AF0", VA = "0x465AF0")]
		private static extern bool Pvr_BoundaryTestNode(int node, bool isPlayArea, ref bool isTriggering, ref float closestDistance, ref float px, ref float py, ref float pz, ref float nx, ref float ny, ref float nz);

		[PreserveSig]
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x465C10", Offset = "0x465C10", VA = "0x465C10")]
		private static extern bool Pvr_BoundaryTestPoint(float x, float y, float z, bool isPlayArea, ref bool isTriggering, ref float closestDistance, ref float px, ref float py, ref float pz, ref float nx, ref float ny, ref float nz);

		[PreserveSig]
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x465D40", Offset = "0x465D40", VA = "0x465D40")]
		private static extern int Pvr_BoundaryGetGeometry(out IntPtr handle, bool isPlayArea);

		[PreserveSig]
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x465E18", Offset = "0x465E18", VA = "0x465E18")]
		private static extern int Pvr_BoundaryGetDimensions(ref float x, ref float y, ref float z, bool isPlayArea);

		[PreserveSig]
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x465EEC", Offset = "0x465EEC", VA = "0x465EEC")]
		private static extern bool Pvr_BoundaryGetEnabled();

		[PreserveSig]
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x465FA4", Offset = "0x465FA4", VA = "0x465FA4")]
		private static extern void Pvr_BoundarySetVisible(bool value);

		[PreserveSig]
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x466064", Offset = "0x466064", VA = "0x466064")]
		private static extern bool Pvr_BoundaryGetVisible();

		[PreserveSig]
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x46611C", Offset = "0x46611C", VA = "0x46611C")]
		private static extern bool Pvr_EnableLWRP(bool enable);

		[PreserveSig]
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x4661E4", Offset = "0x4661E4", VA = "0x4661E4")]
		private static extern bool Pvr_SetViewportSize(int w, int h);

		[PreserveSig]
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x4662B4", Offset = "0x4662B4", VA = "0x4662B4")]
		private static extern void Pvr_BoundarySetSeeThroughVisible(bool value);

		[PreserveSig]
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x466374", Offset = "0x466374", VA = "0x466374")]
		private static extern void PVR_SetCameraImageRect(int width, int height);

		[PreserveSig]
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x46643C", Offset = "0x46643C", VA = "0x46643C")]
		private static extern void Pvr_SetGuardianSystemDisable(bool value);

		[PreserveSig]
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x4664FC", Offset = "0x4664FC", VA = "0x4664FC")]
		private static extern int Pvr_GetDialogState();

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x4665AC", Offset = "0x4665AC", VA = "0x4665AC")]
		public static float UPvr_GetFloorHeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x4665B0", Offset = "0x4665B0", VA = "0x4665B0")]
		public static int UPvr_GetSeeThroughState()
		{
			return default(int);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x4665B4", Offset = "0x4665B4", VA = "0x4665B4")]
		public static void UPvr_EnableSeeThroughManual(bool enable)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x4665B8", Offset = "0x4665B8", VA = "0x4665B8")]
		public static BoundaryTrackingState UPvr_GetTrackingState()
		{
			return default(BoundaryTrackingState);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x4665BC", Offset = "0x4665BC", VA = "0x4665BC")]
		public static bool UPvr_GetFrameRateLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x4665C0", Offset = "0x4665C0", VA = "0x4665C0")]
		public static bool UPvr_IsBoundaryEnable()
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x4665C4", Offset = "0x4665C4", VA = "0x4665C4")]
		public static bool UPvr_BoundaryGetConfigured()
		{
			return default(bool);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x4665C8", Offset = "0x4665C8", VA = "0x4665C8")]
		public static BoundaryTestResult UPvr_BoundaryTestNode(BoundaryTrackingNode node, BoundaryType boundaryType)
		{
			return default(BoundaryTestResult);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x466784", Offset = "0x466784", VA = "0x466784")]
		public static BoundaryTestResult UPvr_BoundaryTestPoint(Vector3 point, BoundaryType boundaryType)
		{
			return default(BoundaryTestResult);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x466948", Offset = "0x466948", VA = "0x466948")]
		public static Vector3[] UPvr_BoundaryGetGeometry(BoundaryType boundaryType)
		{
			return null;
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x466B50", Offset = "0x466B50", VA = "0x466B50")]
		public static Vector3 UPvr_BoundaryGetDimensions(BoundaryType boundaryType)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x466BB8", Offset = "0x466BB8", VA = "0x466BB8")]
		public static bool UPvr_BoundaryGetEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x466BBC", Offset = "0x466BBC", VA = "0x466BBC")]
		public static void UPvr_BoundarySetVisible(bool value)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x466BC0", Offset = "0x466BC0", VA = "0x466BC0")]
		public static bool UPvr_BoundaryGetVisible()
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x466BC4", Offset = "0x466BC4", VA = "0x466BC4")]
		public static bool UPvr_EnableLWRP(bool enable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x466BC8", Offset = "0x466BC8", VA = "0x466BC8")]
		public static bool UPvr_SetViewportSize(int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x466BCC", Offset = "0x466BCC", VA = "0x466BCC")]
		public static void UPvr_StartCameraFrame()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x466D84", Offset = "0x466D84", VA = "0x466D84")]
		public static void UPvr_StopCameraFrame()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x466F3C", Offset = "0x466F3C", VA = "0x466F3C")]
		public static void UPvr_BoundaryGetSeeThroughData(int cameraIndex, RenderTexture renderTexture)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x4671C0", Offset = "0x4671C0", VA = "0x4671C0")]
		public static void UPvr_BoundarySetCameraImageRect(int width, int height)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x467350", Offset = "0x467350", VA = "0x467350")]
		public static void UPvr_BoundarySetSeeThroughVisible(bool value)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x4674D8", Offset = "0x4674D8", VA = "0x4674D8")]
		public static void UPvr_SetGuardianSystemDisable(bool value)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x467660", Offset = "0x467660", VA = "0x467660")]
		public static int UPvr_GetDialogState()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000B4")]
	public struct PlatformSettings
	{
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x6A3D8C", Offset = "0x6A3D8C", VA = "0x6A3D8C")]
		public static Pvr_UnitySDKPlatformSetting.simulationType UPvr_IsCurrentDeviceValid()
		{
			return default(Pvr_UnitySDKPlatformSetting.simulationType);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x6A4180", Offset = "0x6A4180", VA = "0x6A4180")]
		public static bool UPvr_AppEntitlementCheck(string appid)
		{
			return default(bool);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x6A4648", Offset = "0x6A4648", VA = "0x6A4648")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x162378", Offset = "0x162378")]
		public static bool UPvr_KeyEntitlementCheck(string publicKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x6A4A60", Offset = "0x6A4A60", VA = "0x6A4A60")]
		public static int UPvr_AppEntitlementCheckExtra(string appid)
		{
			return default(int);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x6A4E78", Offset = "0x6A4E78", VA = "0x6A4E78")]
		public static int UPvr_KeyEntitlementCheckExtra(string publicKey)
		{
			return default(int);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x6A5290", Offset = "0x6A5290", VA = "0x6A5290")]
		public static int UPvr_GetHmdAudioStatus()
		{
			return default(int);
		}
	}
}
[Token(Token = "0x20000B5")]
public class PLOG : MonoBehaviour
{
	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int logLevel;

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x36664C", Offset = "0x36664C", VA = "0x36664C")]
	public PLOG()
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x366654", Offset = "0x366654", VA = "0x366654")]
	public static void getConfigTraceLevel()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x3666EC", Offset = "0x3666EC", VA = "0x3666EC")]
	public static void D(string msg)
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x3667C0", Offset = "0x3667C0", VA = "0x3667C0")]
	public static void I(string msg)
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x366894", Offset = "0x366894", VA = "0x366894")]
	public static void W(string msg)
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x366968", Offset = "0x366968", VA = "0x366968")]
	public static void E(string msg)
	{
	}
}
[Token(Token = "0x20000B6")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x1623AC", Offset = "0x1623AC")]
public class PicoDevice : MonoBehaviour
{
	[Token(Token = "0x20000B7")]
	public enum DeviceType
	{
		[Token(Token = "0x400032D")]
		HMD,
		[Token(Token = "0x400032E")]
		LeftController,
		[Token(Token = "0x400032F")]
		RightController
	}

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public DeviceType deviceType;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Vector3 devicePos;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Quaternion deviceRot;

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x365C58", Offset = "0x365C58", VA = "0x365C58")]
	public PicoDevice()
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x365C60", Offset = "0x365C60", VA = "0x365C60")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x365FFC", Offset = "0x365FFC", VA = "0x365FFC")]
	private void AjouterCamera(GameObject objet, Camera principale)
	{
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x3661B4", Offset = "0x3661B4", VA = "0x3661B4")]
	private void Update()
	{
	}
}
[Token(Token = "0x20000B8")]
public class CPicoSDKSettingAsset : ScriptableObject
{
	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool IgnoreSDKSetting;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public bool DontshowBuildWaring;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public bool AppIDChecked;

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x356E9C", Offset = "0x356E9C", VA = "0x356E9C")]
	public CPicoSDKSettingAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B9")]
public class Pvr_UnitySDKProjectSetting : ScriptableObject
{
	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public RenderTextureAntiAliasing rtAntiAlising;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RenderTextureDepth rtBitDepth;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public RenderTextureFormat rtFormat;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool usedefaultRenderTexture;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector2 customRTSize;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool usedefaultfps;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int customfps;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool usesinglepass;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool usecontentprotect;

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x38606C", Offset = "0x38606C", VA = "0x38606C")]
	public Pvr_UnitySDKProjectSetting()
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x386074", Offset = "0x386074", VA = "0x386074")]
	public static Pvr_UnitySDKProjectSetting GetProjectConfig()
	{
		return null;
	}
}
[Token(Token = "0x20000BA")]
public sealed class Pvr_UnitySDKPlatformSetting : ScriptableObject
{
	[Token(Token = "0x20000BB")]
	public enum simulationType
	{
		[Token(Token = "0x4000342")]
		Null,
		[Token(Token = "0x4000343")]
		Invalid,
		[Token(Token = "0x4000344")]
		Valid
	}

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[SerializeField]
	private bool entitlementchecksimulation;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	[SerializeField]
	private bool startTimeEntitlementCheck;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string appID;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public List<string> deviceSN;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKPlatformSetting instance;

	[Token(Token = "0x17000052")]
	public static bool Entitlementchecksimulation
	{
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x384CDC", Offset = "0x384CDC", VA = "0x384CDC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x384D00", Offset = "0x384D00", VA = "0x384D00")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public static bool StartTimeEntitlementCheck
	{
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x3844F4", Offset = "0x3844F4", VA = "0x3844F4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x384D50", Offset = "0x384D50", VA = "0x384D50")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public static Pvr_UnitySDKPlatformSetting Instance
	{
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x384518", Offset = "0x384518", VA = "0x384518")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x384DA0", Offset = "0x384DA0", VA = "0x384DA0")]
		set
		{
		}
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x384C50", Offset = "0x384C50", VA = "0x384C50")]
	public Pvr_UnitySDKPlatformSetting()
	{
	}
}
[Token(Token = "0x20000BC")]
public class Pvr_UnitySDKManager : MonoBehaviour
{
	[Token(Token = "0x20000BD")]
	public delegate void EntitlementCheckResult(int ReturnValue);

	[Token(Token = "0x200016F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1626E8", Offset = "0x1626E8")]
	private sealed class <ToastManager>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float time;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int type;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool state;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal Pvr_UnitySDKManager $this;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object $current;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal bool $disposing;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int $PC;

		[Token(Token = "0x170000B0")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x3848CC", Offset = "0x3848CC", VA = "0x3848CC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x3848D4", Offset = "0x3848D4", VA = "0x3848D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x3846C0", Offset = "0x3846C0", VA = "0x3846C0")]
		[DebuggerHidden]
		public <ToastManager>c__Iterator0()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x3846C8", Offset = "0x3846C8", VA = "0x3846C8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x3848DC", Offset = "0x3848DC", VA = "0x3848DC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x3848F0", Offset = "0x3848F0", VA = "0x3848F0", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000170")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162748", Offset = "0x162748")]
	private sealed class <SetProperty>c__AnonStorey5
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Transform trans;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Pvr_UnitySDKManager $this;

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x38406C", Offset = "0x38406C", VA = "0x38406C")]
		public <SetProperty>c__AnonStorey5()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x384074", Offset = "0x384074", VA = "0x384074")]
		internal void <>m__0()
		{
		}
	}

	[Token(Token = "0x2000171")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162758", Offset = "0x162758")]
	private sealed class <G3TipsManager>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float time;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal GameObject tip;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object $current;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool $disposing;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int $PC;

		[Token(Token = "0x170000B2")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x3826B4", Offset = "0x3826B4", VA = "0x3826B4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x3826BC", Offset = "0x3826BC", VA = "0x3826BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x3825B8", Offset = "0x3825B8", VA = "0x3825B8")]
		[DebuggerHidden]
		public <G3TipsManager>c__Iterator1()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x3825C0", Offset = "0x3825C0", VA = "0x3825C0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x3826C4", Offset = "0x3826C4", VA = "0x3826C4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x3826D8", Offset = "0x3826D8", VA = "0x3826D8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000172")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1627B8", Offset = "0x1627B8")]
	private sealed class <Start>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Pvr_UnitySDKManager $this;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal object $current;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool $disposing;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int $PC;

		[Token(Token = "0x170000B4")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x384618", Offset = "0x384618", VA = "0x384618", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x384620", Offset = "0x384620", VA = "0x384620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x3840F8", Offset = "0x3840F8", VA = "0x3840F8")]
		[DebuggerHidden]
		public <Start>c__Iterator2()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x384100", Offset = "0x384100", VA = "0x384100", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x384628", Offset = "0x384628", VA = "0x384628", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x38463C", Offset = "0x38463C", VA = "0x38463C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000173")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162818", Offset = "0x162818")]
	private sealed class <InitRenderThreadRoutine>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int <i>__1;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal object $current;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool $disposing;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int $PC;

		[Token(Token = "0x170000B6")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x382D04", Offset = "0x382D04", VA = "0x382D04", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x382D0C", Offset = "0x382D0C", VA = "0x382D0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x38275C", Offset = "0x38275C", VA = "0x38275C")]
		[DebuggerHidden]
		public <InitRenderThreadRoutine>c__Iterator3()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x382764", Offset = "0x382764", VA = "0x382764", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x382D14", Offset = "0x382D14", VA = "0x382D14", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x382D28", Offset = "0x382D28", VA = "0x382D28", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000174")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162878", Offset = "0x162878")]
	private sealed class <OnResume>c__Iterator4 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int <ability6dof>__0;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int <enumindex>__0;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int <waitNum>__0;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int <resetNum>__0;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int <i>__1;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal Pvr_UnitySDKManager $this;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal object $current;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool $disposing;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int $PC;

		[Token(Token = "0x170000B8")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x383FC4", Offset = "0x383FC4", VA = "0x383FC4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x383FCC", Offset = "0x383FCC", VA = "0x383FCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x382DAC", Offset = "0x382DAC", VA = "0x382DAC")]
		[DebuggerHidden]
		public <OnResume>c__Iterator4()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x382DB4", Offset = "0x382DB4", VA = "0x382DB4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x383FD4", Offset = "0x383FD4", VA = "0x383FD4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x383FE8", Offset = "0x383FE8", VA = "0x383FE8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PlatForm platform;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Pvr_UnitySDKManager sdk;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[HideInInspector]
	public float EyesAspect;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public int posStatus;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public bool ismirroring;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Vector3 resetBasePos;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public int trackingmode;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public int systemprop;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public bool systemFPS;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public float[] headData;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool rotfoldout;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	[SerializeField]
	private bool hmdOnlyrot;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	[SerializeField]
	private bool controllerOnlyrot;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TrackingOrigin trackingOrigin;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool ResetTrackerOnLoad;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Vector3 leftEyeOffset;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[HideInInspector]
	public Vector3 rightEyeOffset;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Rect leftEyeRect;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Rect rightEyeRect;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Matrix4x4 leftEyeView;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public Matrix4x4 rightEyeView;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[HideInInspector]
	public Pvr_UnitySDKEditor pvr_UnitySDKEditor;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	[SerializeField]
	private bool vrModeEnabled;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[HideInInspector]
	public Material Eyematerial;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	[HideInInspector]
	public Material Middlematerial;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162550", Offset = "0x162550")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x162550", Offset = "0x162550")]
	private bool <picovrTriggered>k__BackingField;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	[HideInInspector]
	public bool newPicovrTriggered;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
	[SerializeField]
	private bool showFPS;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	[HideInInspector]
	public Vector3 neckOffset;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private bool pVRNeck;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
	[HideInInspector]
	public bool UseCustomNeckPara;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
	[HideInInspector]
	public bool onResume;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11B")]
	[HideInInspector]
	public bool isEnterVRMode;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool isHasController;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Pvr_UnitySDKConfigProfile pvr_UnitySDKConfig;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private GameObject calltoast;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject msgtoast;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private GameObject lowhmdBatterytoast;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameObject lowphoneBatterytoast;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private GameObject LowPhoneHealthtoast;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject LowcontrollerBatterytoast;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private bool lowControllerpowerstate;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private float controllerpowershowtime;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private bool UseToast;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int iPhoneHMDModeEnabled;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private GameObject G3LiteTips;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	private bool monoscopic;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
	private bool mIsAndroid7;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Func<bool> eventEnterVRMode;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
	[HideInInspector]
	public bool ShowVideoSeethrough;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public int SystemDebugFFRLevel;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public int SystemFFRLevel;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	public int AppCheckResult;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public SystemDisplayFrequency displayFrequency;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public Action<float> DisplayRefreshRateChanged;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Action longPressHomeKeyAction;

	[Token(Token = "0x17000055")]
	public static Pvr_UnitySDKManager SDK
	{
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x6A6CC4", Offset = "0x6A6CC4", VA = "0x6A6CC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000056")]
	public bool Rotfoldout
	{
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x6C3C18", Offset = "0x6C3C18", VA = "0x6C3C18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x6C3C20", Offset = "0x6C3C20", VA = "0x6C3C20")]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	public bool HmdOnlyrot
	{
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x6C3C38", Offset = "0x6C3C38", VA = "0x6C3C38")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x6C3C40", Offset = "0x6C3C40", VA = "0x6C3C40")]
		set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public bool ControllerOnlyrot
	{
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x6C3C58", Offset = "0x6C3C58", VA = "0x6C3C58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x6C3C60", Offset = "0x6C3C60", VA = "0x6C3C60")]
		set
		{
		}
	}

	[Token(Token = "0x17000059")]
	public TrackingOrigin TrackingOrigin
	{
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x6C3C78", Offset = "0x6C3C78", VA = "0x6C3C78")]
		get
		{
			return default(TrackingOrigin);
		}
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x6C3C80", Offset = "0x6C3C80", VA = "0x6C3C80")]
		set
		{
		}
	}

	[Token(Token = "0x1700005A")]
	[HideInInspector]
	public bool VRModeEnabled
	{
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x6BBA54", Offset = "0x6BBA54", VA = "0x6BBA54")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x6B9724", Offset = "0x6B9724", VA = "0x6B9724")]
		set
		{
		}
	}

	[Token(Token = "0x1700005B")]
	[HideInInspector]
	public bool picovrTriggered
	{
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x6C3D38", Offset = "0x6C3D38", VA = "0x6C3D38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162648", Offset = "0x162648")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x6B7E90", Offset = "0x6B7E90", VA = "0x6B7E90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162658", Offset = "0x162658")]
		set
		{
		}
	}

	[Token(Token = "0x1700005C")]
	public bool ShowFPS
	{
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x6C3D40", Offset = "0x6C3D40", VA = "0x6C3D40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x6C3D48", Offset = "0x6C3D48", VA = "0x6C3D48")]
		set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public bool PVRNeck
	{
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x6C3D60", Offset = "0x6C3D60", VA = "0x6C3D60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x6C3D68", Offset = "0x6C3D68", VA = "0x6C3D68")]
		set
		{
		}
	}

	[Token(Token = "0x1700005E")]
	[HideInInspector]
	public bool Monoscopic
	{
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x6BB118", Offset = "0x6BB118", VA = "0x6BB118")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x6C3D80", Offset = "0x6C3D80", VA = "0x6C3D80")]
		set
		{
		}
	}

	[Token(Token = "0x14000015")]
	public static event EntitlementCheckResult EntitlementCheckResultEvent
	{
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x6C3D9C", Offset = "0x6C3D9C", VA = "0x6C3D9C")]
		add
		{
		}
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x6C3F10", Offset = "0x6C3F10", VA = "0x6C3F10")]
		remove
		{
		}
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x6C3B10", Offset = "0x6C3B10", VA = "0x6C3B10")]
	public Pvr_UnitySDKManager()
	{
	}

	[Token(Token = "0x600057F")]
	[Address(RVA = "0x6C3C94", Offset = "0x6C3C94", VA = "0x6C3C94")]
	public void ChangeDefaultCustomRtSize(int w, int h)
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x6BB0F0", Offset = "0x6BB0F0", VA = "0x6BB0F0")]
	public Vector3 EyeOffset(Eye eye)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x6C3D08", Offset = "0x6C3D08", VA = "0x6C3D08")]
	public Rect EyeRect(Eye eye)
	{
		return default(Rect);
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x6C4084", Offset = "0x6C4084", VA = "0x6C4084")]
	private bool SDKManagerInit()
	{
		return default(bool);
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x6C426C", Offset = "0x6C426C", VA = "0x6C426C")]
	private bool SDKManagerInitCoreAbility()
	{
		return default(bool);
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x6C440C", Offset = "0x6C440C", VA = "0x6C440C")]
	public void smsReceivedCallback(string msg)
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x6C56E4", Offset = "0x6C56E4", VA = "0x6C56E4")]
	public void phoneStateCallback(string state)
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x6C5D2C", Offset = "0x6C5D2C", VA = "0x6C5D2C")]
	public void phoneBatteryStateCallback(string state)
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x6C611C", Offset = "0x6C611C", VA = "0x6C611C")]
	public void hmdLowBatteryCallback(string level)
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x6C4A54", Offset = "0x6C4A54", VA = "0x6C4A54")]
	private string TransformNumber(string number)
	{
		return null;
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x6C62BC", Offset = "0x6C62BC", VA = "0x6C62BC")]
	public void onHmdOrientationReseted()
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x6C5618", Offset = "0x6C5618", VA = "0x6C5618")]
	[DebuggerHidden]
	private IEnumerator ToastManager(int type, bool state, float time)
	{
		return null;
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x6C62C0", Offset = "0x6C62C0", VA = "0x6C62C0")]
	private void CheckControllerStateForG2(string state)
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x6C64A8", Offset = "0x6C64A8", VA = "0x6C64A8")]
	public void notificationCallback(string data)
	{
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x6C7C78", Offset = "0x6C7C78", VA = "0x6C7C78")]
	private Sprite LoadSprite(Vector2 size, string filepath)
	{
		return null;
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x6C7DFC", Offset = "0x6C7DFC", VA = "0x6C7DFC")]
	private byte[] ReadTex(string path)
	{
		return null;
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x6C6A00", Offset = "0x6C6A00", VA = "0x6C6A00")]
	private void SetProperty(int type, JsonData data, string value)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x6C720C", Offset = "0x6C720C", VA = "0x6C720C")]
	private void SetBaseProperty(Transform trans, JsonData data, string value)
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x6C7808", Offset = "0x6C7808", VA = "0x6C7808")]
	private void SetImageProperty(Transform image, JsonData data, string value)
	{
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x6C8030", Offset = "0x6C8030", VA = "0x6C8030")]
	private void SetTextProperty(Transform text, JsonData data, string value)
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x6C7BD4", Offset = "0x6C7BD4", VA = "0x6C7BD4")]
	[DebuggerHidden]
	private IEnumerator G3TipsManager(GameObject tip, float time)
	{
		return null;
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x6C844C", Offset = "0x6C844C", VA = "0x6C844C")]
	private float JsonToFloat(JsonData data)
	{
		return default(float);
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x6C84E8", Offset = "0x6C84E8", VA = "0x6C84E8")]
	private bool SDKManagerInitFPS()
	{
		return default(bool);
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x6C41D4", Offset = "0x6C41D4", VA = "0x6C41D4")]
	private bool SDKManagerInitConfigProfile()
	{
		return default(bool);
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x6C874C", Offset = "0x6C874C", VA = "0x6C874C")]
	private bool SDKManagerInitEditor()
	{
		return default(bool);
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x6C8854", Offset = "0x6C8854", VA = "0x6C8854")]
	private bool SDKManagerInitPara()
	{
		return default(bool);
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x6C885C", Offset = "0x6C885C", VA = "0x6C885C")]
	public void SDKManagerLongHomeKey()
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x6C89D4", Offset = "0x6C89D4", VA = "0x6C89D4")]
	private void setLongHomeKey()
	{
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x6C8D44", Offset = "0x6C8D44", VA = "0x6C8D44")]
	public void verifyAPPCallback(string code)
	{
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x6C8F0C", Offset = "0x6C8F0C", VA = "0x6C8F0C")]
	public void IpdRefreshCallBack(string ipd)
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x6C9090", Offset = "0x6C9090", VA = "0x6C9090")]
	public void DisplayRefreshRateCallBack(string rate)
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x6C91D0", Offset = "0x6C91D0", VA = "0x6C91D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x6CA7D8", Offset = "0x6CA7D8", VA = "0x6CA7D8")]
	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x6CA858", Offset = "0x6CA858", VA = "0x6CA858")]
	[DebuggerHidden]
	private IEnumerator InitRenderThreadRoutine()
	{
		return null;
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x6CA8C4", Offset = "0x6CA8C4", VA = "0x6CA8C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x6CACC0", Offset = "0x6CACC0", VA = "0x6CACC0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x6CAE7C", Offset = "0x6CAE7C", VA = "0x6CAE7C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x6CB05C", Offset = "0x6CB05C", VA = "0x6CB05C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x6CB064", Offset = "0x6CB064", VA = "0x6CB064")]
	private void OnPause()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x6CB1E0", Offset = "0x6CB1E0", VA = "0x6CB1E0")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x6CB59C", Offset = "0x6CB59C", VA = "0x6CB59C")]
	public void EnterVRMode()
	{
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x6CB150", Offset = "0x6CB150", VA = "0x6CB150")]
	public void LeaveVRMode()
	{
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x6CB6D4", Offset = "0x6CB6D4", VA = "0x6CB6D4")]
	public void SixDofForceQuit()
	{
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x6C9EB4", Offset = "0x6C9EB4", VA = "0x6C9EB4")]
	private void InitUI()
	{
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x6CA1C0", Offset = "0x6CA1C0", VA = "0x6CA1C0")]
	private void RefreshTextByLanguage()
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x6C9A5C", Offset = "0x6C9A5C", VA = "0x6C9A5C")]
	private void LoadIsMirroringValue()
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x6CB51C", Offset = "0x6CB51C", VA = "0x6CB51C")]
	[DebuggerHidden]
	private IEnumerator OnResume()
	{
		return null;
	}
}
[Token(Token = "0x20000BE")]
public class QuitGame : MonoBehaviour
{
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x391C50", Offset = "0x391C50", VA = "0x391C50")]
	public QuitGame()
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x391C58", Offset = "0x391C58", VA = "0x391C58")]
	private void Start()
	{
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x391C5C", Offset = "0x391C5C", VA = "0x391C5C")]
	private void Update()
	{
	}
}
[Token(Token = "0x20000BF")]
public class Pvr_UnityEyeMask : MonoBehaviour
{
	[Token(Token = "0x20000C0")]
	private class EyeMaskData
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Eye eyeSide;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Camera camera;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CommandBuffer cmdBuf;

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x45DE40", Offset = "0x45DE40", VA = "0x45DE40")]
		public EyeMaskData()
		{
		}
	}

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Shader eyeMaskShader;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Material eyeMaskMaterial;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Mesh eyeMaskMeshLeft;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Mesh eyeMaskMeshRight;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Mesh eyeMaskMeshBoth;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float zDir;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Color eyeMaskColor;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private List<EyeMaskData> cameraDataList;

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x45B7DC", Offset = "0x45B7DC", VA = "0x45B7DC")]
	public Pvr_UnityEyeMask()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x45B898", Offset = "0x45B898", VA = "0x45B898")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x45B988", Offset = "0x45B988", VA = "0x45B988")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x45CBFC", Offset = "0x45CBFC", VA = "0x45CBFC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x45C1F8", Offset = "0x45C1F8", VA = "0x45C1F8")]
	private void CreateCommandBuffer()
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x45DBFC", Offset = "0x45DBFC", VA = "0x45DBFC")]
	private void OnCustomPreRender(Camera cam)
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x45D0C4", Offset = "0x45D0C4", VA = "0x45D0C4")]
	private Mesh GetStencilMesh(Eye eyeSide)
	{
		return null;
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x45D5DC", Offset = "0x45D5DC", VA = "0x45D5DC")]
	private Mesh GetStencilMeshBoth(Mesh leftMesh, Mesh rightMesh)
	{
		return null;
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x45CF40", Offset = "0x45CF40", VA = "0x45CF40")]
	private bool VerifyCommadBuffer()
	{
		return default(bool);
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x45BCD8", Offset = "0x45BCD8", VA = "0x45BCD8")]
	private void PrepareCameras()
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x45DDEC", Offset = "0x45DDEC", VA = "0x45DDEC")]
	private void AddCameraCommandBuffer(EyeMaskData data)
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x45CE6C", Offset = "0x45CE6C", VA = "0x45CE6C")]
	private void RemoveCameraCommandBuffer(EyeMaskData data)
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x45CEC0", Offset = "0x45CEC0", VA = "0x45CEC0")]
	private void CleanEyeMask()
	{
	}
}
[Token(Token = "0x20000C1")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x1628D8", Offset = "0x1628D8")]
public class Pvr_UnitySDKEye : MonoBehaviour
{
	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Pvr_UnitySDKEye> Instances;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Eye eyeSide;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162950", Offset = "0x162950")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x162950", Offset = "0x162950")]
	private Camera <eyecamera>k__BackingField;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int eyeCameraOriginCullingMask;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CameraClearFlags eyeCameraOriginClearFlag;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Color eyeCameraOriginBackgroundColor;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int lastBoundaryState;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Matrix4x4 realProj;

	[Token(Token = "0x4000391")]
	private const int bufferSize = 3;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int IDIndex;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private RenderEventType eventType;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int previousId;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool setLevel;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Material mat_Vignette;

	[Token(Token = "0x1700005F")]
	public Camera eyecamera
	{
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x6B98F8", Offset = "0x6B98F8", VA = "0x6B98F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162984", Offset = "0x162984")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x6B9900", Offset = "0x6B9900", VA = "0x6B9900")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162994", Offset = "0x162994")]
		private set
		{
		}
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x6B97DC", Offset = "0x6B97DC", VA = "0x6B97DC")]
	public Pvr_UnitySDKEye()
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x6B9908", Offset = "0x6B9908", VA = "0x6B9908")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x6B99DC", Offset = "0x6B99DC", VA = "0x6B99DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x6BA200", Offset = "0x6BA200", VA = "0x6BA200")]
	private void Update()
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x6BA534", Offset = "0x6BA534", VA = "0x6BA534")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x6BA538", Offset = "0x6BA538", VA = "0x6BA538")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x6BA53C", Offset = "0x6BA53C", VA = "0x6BA53C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x6BA5F4", Offset = "0x6BA5F4", VA = "0x6BA5F4")]
	public void MyPreRender(Camera camera)
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x6BA8A0", Offset = "0x6BA8A0", VA = "0x6BA8A0")]
	public void MyPreRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x6BA96C", Offset = "0x6BA96C", VA = "0x6BA96C")]
	public void MyPostRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x6BA6C0", Offset = "0x6BA6C0", VA = "0x6BA6C0")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x6BAA38", Offset = "0x6BAA38", VA = "0x6BAA38")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x6BAED4", Offset = "0x6BAED4", VA = "0x6BAED4")]
	public void EyeRender()
	{
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x6B9AFC", Offset = "0x6B9AFC", VA = "0x6B9AFC")]
	private void Setup(Eye eyeSide)
	{
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x6B9DEC", Offset = "0x6B9DEC", VA = "0x6B9DEC")]
	private void SetupUpdate()
	{
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x6AD0B8", Offset = "0x6AD0B8", VA = "0x6AD0B8")]
	public void RefreshCameraPosition(float ipd)
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x6BB120", Offset = "0x6BB120", VA = "0x6BB120")]
	private void DrawVignetteLine()
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x6BB290", Offset = "0x6BB290", VA = "0x6BB290")]
	private void vignette()
	{
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x6BACBC", Offset = "0x6BACBC", VA = "0x6BACBC")]
	private void SetFFRParameter()
	{
	}
}
[Token(Token = "0x20000C2")]
public class Pvr_UnitySDKEyeManager : MonoBehaviour
{
	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162B50", Offset = "0x162B50")]
	private sealed class <EndOfFrame>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int <boundaryState>__1;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal Pvr_UnitySDKEyeManager $this;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal object $current;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool $disposing;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int $PC;

		[Token(Token = "0x170000BA")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x6C1808", Offset = "0x6C1808", VA = "0x6C1808", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x6C1810", Offset = "0x6C1810", VA = "0x6C1810", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x6BE0A4", Offset = "0x6BE0A4", VA = "0x6BE0A4")]
		[DebuggerHidden]
		public <EndOfFrame>c__Iterator0()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x6BEEE8", Offset = "0x6BEEE8", VA = "0x6BEEE8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x6C1818", Offset = "0x6C1818", VA = "0x6C1818", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x6C182C", Offset = "0x6C182C", VA = "0x6C182C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162BB0", Offset = "0x162BB0")]
	private sealed class <ScreenFade>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float <elapsedTime>__0;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float startAlpha;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float endAlpha;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal Pvr_UnitySDKEyeManager $this;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object $current;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal bool $disposing;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int $PC;

		[Token(Token = "0x170000BC")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x6C1A70", Offset = "0x6C1A70", VA = "0x6C1A70", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x6C1A78", Offset = "0x6C1A78", VA = "0x6C1A78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x6BEEDC", Offset = "0x6BEEDC", VA = "0x6BEEDC")]
		[DebuggerHidden]
		public <ScreenFade>c__Iterator1()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x6C18B0", Offset = "0x6C18B0", VA = "0x6C18B0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x6C1A80", Offset = "0x6C1A80", VA = "0x6C1A80", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x6C1A94", Offset = "0x6C1A94", VA = "0x6C1A94", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKEyeManager instance;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Pvr_UnitySDKEye[] eyes;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public Camera LeftEyeCamera;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public Camera RightEyeCamera;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Camera MonoEyeCamera;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public Camera BothEyeCamera;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int MonoEyeTextureID;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private readonly int WaitSplashScreenFrames;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int frameNum;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[HideInInspector]
	private bool foveatedRendering;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[HideInInspector]
	private EFoveationLevel foveationLevel;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int eyeTextureId;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RenderEventType eventType;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Pvr_UnitySDKEyeOverlay compositeLayer;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int overlayLayerDepth;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int underlayLayerDepth;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isHeadLocked;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int layerFlags;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public bool EyeTracking;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[HideInInspector]
	public Vector3 eyePoint;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private EyeTrackingData eyePoseData;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[HideInInspector]
	public static bool supportEyeTracking;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x162A74", Offset = "0x162A74")]
	public bool screenFade;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x162AA8", Offset = "0x162AA8")]
	public float fadeTime;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x162ADC", Offset = "0x162ADC")]
	public Color fadeColor;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public int renderQueue;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private MeshRenderer fadeMeshRenderer;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private MeshFilter fadeMeshFilter;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private Material fadeMaterial;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float elapsedTime;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private bool isFading;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float currentAlpha;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private float nowFadeAlpha;

	[Token(Token = "0x17000060")]
	public static Pvr_UnitySDKEyeManager Instance
	{
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x6ACE94", Offset = "0x6ACE94", VA = "0x6ACE94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000061")]
	public Pvr_UnitySDKEye[] Eyes
	{
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x6ACFF4", Offset = "0x6ACFF4", VA = "0x6ACFF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000062")]
	[HideInInspector]
	public bool FoveatedRendering
	{
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x6BB6AC", Offset = "0x6BB6AC", VA = "0x6BB6AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x6BB6B4", Offset = "0x6BB6B4", VA = "0x6BB6B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000063")]
	[HideInInspector]
	public EFoveationLevel FoveationLevel
	{
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x6BB710", Offset = "0x6BB710", VA = "0x6BB710")]
		get
		{
			return default(EFoveationLevel);
		}
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x6BB718", Offset = "0x6BB718", VA = "0x6BB718")]
		set
		{
		}
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x6BB61C", Offset = "0x6BB61C", VA = "0x6BB61C")]
	public Pvr_UnitySDKEyeManager()
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x6BB728", Offset = "0x6BB728", VA = "0x6BB728")]
	private void SetCameraEnableEditor()
	{
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x6BBA5C", Offset = "0x6BBA5C", VA = "0x6BBA5C")]
	private void SetCamerasEnableByStereoRendering()
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x6BBB78", Offset = "0x6BBB78", VA = "0x6BBB78")]
	private void SetupMonoCamera()
	{
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x6BBD00", Offset = "0x6BBD00", VA = "0x6BBD00")]
	private void SetupUpdate()
	{
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x6BBE54", Offset = "0x6BBE54", VA = "0x6BBE54")]
	private void MonoEyeRender()
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x6BC070", Offset = "0x6BC070", VA = "0x6BC070")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x6BCCB8", Offset = "0x6BCCB8", VA = "0x6BCCB8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x6BD6E8", Offset = "0x6BD6E8", VA = "0x6BD6E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x6BD704", Offset = "0x6BD704", VA = "0x6BD704")]
	private void Update()
	{
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x6BDAA0", Offset = "0x6BDAA0", VA = "0x6BDAA0")]
	private void OnPause()
	{
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x6BDC08", Offset = "0x6BDC08", VA = "0x6BDC08")]
	public void MyPostRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x6BDE28", Offset = "0x6BDE28", VA = "0x6BDE28")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x6BDE30", Offset = "0x6BDE30", VA = "0x6BDE30")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x6BDCD0", Offset = "0x6BDCD0", VA = "0x6BDCD0")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x6BE024", Offset = "0x6BE024", VA = "0x6BE024")]
	[DebuggerHidden]
	private IEnumerator EndOfFrame()
	{
		return null;
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x6BE0AC", Offset = "0x6BE0AC", VA = "0x6BE0AC")]
	private void CreateExternalSurface(Pvr_UnitySDKEyeOverlay overlayInstance, int layerDepth)
	{
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x6BE53C", Offset = "0x6BE53C", VA = "0x6BE53C")]
	public bool SetEyeTrackingMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x6AE3D8", Offset = "0x6AE3D8", VA = "0x6AE3D8")]
	public Vector3 GetEyeTrackingPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x6BE9A8", Offset = "0x6BE9A8", VA = "0x6BE9A8")]
	private EyeDeviceInfo GetDeviceInfo()
	{
		return default(EyeDeviceInfo);
	}

	[Token(Token = "0x6000600")]
	[Address(RVA = "0x6BC588", Offset = "0x6BC588", VA = "0x6BC588")]
	private void CreateFadeMesh()
	{
	}

	[Token(Token = "0x6000601")]
	[Address(RVA = "0x6BDE34", Offset = "0x6BDE34", VA = "0x6BDE34")]
	private void DestoryFadeMesh()
	{
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x6BCCB0", Offset = "0x6BCCB0", VA = "0x6BCCB0")]
	public void SetCurrentAlpha(float alpha)
	{
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x6BD62C", Offset = "0x6BD62C", VA = "0x6BD62C")]
	[DebuggerHidden]
	private IEnumerator ScreenFade(float startAlpha, float endAlpha)
	{
		return null;
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x6BED14", Offset = "0x6BED14", VA = "0x6BED14")]
	private void SetMaterialAlpha()
	{
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x6BD624", Offset = "0x6BD624", VA = "0x6BD624")]
	public bool GfxDeviceAdvanceFrameGLES()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000C3")]
public class Pvr_UnitySDKEyeOverlay : MonoBehaviour, IComparable<Pvr_UnitySDKEyeOverlay>
{
	[Token(Token = "0x20000C4")]
	public delegate void ExternalAndroidSurfaceObjectCreated();

	[Token(Token = "0x20000C5")]
	public enum OverlayShape
	{
		[Token(Token = "0x40003CF")]
		Quad,
		[Token(Token = "0x40003D0")]
		Cylinder,
		[Token(Token = "0x40003D1")]
		Equirect
	}

	[Token(Token = "0x20000C6")]
	public enum OverlayType
	{
		[Token(Token = "0x40003D3")]
		Overlay,
		[Token(Token = "0x40003D4")]
		Underlay
	}

	[Token(Token = "0x20000C7")]
	public enum OverlayTexFilterMode
	{
		[Token(Token = "0x40003D6")]
		NotCare,
		[Token(Token = "0x40003D7")]
		Nearest,
		[Token(Token = "0x40003D8")]
		Linear,
		[Token(Token = "0x40003D9")]
		Nearest_Mipmap_Nearest,
		[Token(Token = "0x40003DA")]
		Linear_Mipmap_Nearest,
		[Token(Token = "0x40003DB")]
		Nearest_Mipmap_Linear,
		[Token(Token = "0x40003DC")]
		Linear_Mipmap_Linear
	}

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Pvr_UnitySDKEyeOverlay> Instances;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int layerIndex;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public OverlayType overlayType;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public OverlayShape overlayShape;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform layerTransform;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Texture[] layerTextures;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int[] layerTextureIds;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Matrix4x4[] MVMatrixs;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3[] ModelScales;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Quaternion[] ModelRotations;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3[] ModelTranslations;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Quaternion[] CameraRotations;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3[] CameraTranslations;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Camera[] layerEyeCamera;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool overrideColorScaleAndOffset;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector4 colorScale;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector4 colorOffset;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector4 overlayLayerColorScaleDefault;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Vector4 overlayLayerColorOffsetDefault;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool isExternalAndroidSurface;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public IntPtr externalAndroidSurfaceObject;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public ExternalAndroidSurfaceObjectCreated externalAndroidSurfaceObjectCreated;

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x6C1B18", Offset = "0x6C1B18", VA = "0x6C1B18")]
	public Pvr_UnitySDKEyeOverlay()
	{
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x6C1D6C", Offset = "0x6C1D6C", VA = "0x6C1D6C", Slot = "4")]
	public int CompareTo(Pvr_UnitySDKEyeOverlay other)
	{
		return default(int);
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x6C1D9C", Offset = "0x6C1D9C", VA = "0x6C1D9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0x6C24CC", Offset = "0x6C24CC", VA = "0x6C24CC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0x6C2F24", Offset = "0x6C2F24", VA = "0x6C2F24")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0x6BD2B8", Offset = "0x6BD2B8", VA = "0x6BD2B8")]
	public void RefreshCamera()
	{
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0x6C2274", Offset = "0x6C2274", VA = "0x6C2274")]
	private void InitializeBuffer()
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0x6C24D0", Offset = "0x6C24D0", VA = "0x6C24D0")]
	private void UpdateCoords()
	{
	}

	[Token(Token = "0x600060F")]
	[Address(RVA = "0x6C2FDC", Offset = "0x6C2FDC", VA = "0x6C2FDC")]
	public void SetTexture(Texture texture)
	{
	}

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x6C3080", Offset = "0x6C3080", VA = "0x6C3080")]
	public void SetLayerColorScaleAndOffset(Vector4 scale, Vector4 offset)
	{
	}

	[Token(Token = "0x6000611")]
	[Address(RVA = "0x6C17C8", Offset = "0x6C17C8", VA = "0x6C17C8")]
	public Vector4 GetLayerColorScale()
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x6C17E8", Offset = "0x6C17E8", VA = "0x6C17E8")]
	public Vector4 GetLayerColorOffset()
	{
		return default(Vector4);
	}
}
[Token(Token = "0x20000C8")]
public class Pvr_UnitySDKRender
{
	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKRender instance;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public AndroidJavaObject activity;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static AndroidJavaClass javaVrActivityClass;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static AndroidJavaClass javaSysActivityClass;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static AndroidJavaClass javaserviceClass;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static AndroidJavaClass javaVrActivityLongReceiver;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static AndroidJavaClass javaVrActivityClientClass;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private bool canConnecttoActivity;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	private bool isInitrenderThread;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string model;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector2 prefinger1;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector2 prefinger2;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int eyeTextureCount;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RenderTexture[] eyeTextures;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int[] eyeTextureIds;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int currEyeTextureIdx;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int nextEyeTextureIdx;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int lastEyeTextureIdx;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool isSwitchSDK;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int RenderviewNumber;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool isFirstStartup;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool isShellMode;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private StereoRenderingPathPico stereoRenderPath;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162C10", Offset = "0x162C10")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x162C10", Offset = "0x162C10")]
	private SDKStereoRendering <StereoRendering>k__BackingField;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float rtScaleFactor;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float eyeVFov;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float eyeHFov;

	[Token(Token = "0x17000064")]
	public static Pvr_UnitySDKRender Instance
	{
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x3829D0", Offset = "0x3829D0", VA = "0x3829D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x386E54", Offset = "0x386E54", VA = "0x386E54")]
		set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public StereoRenderingPathPico StereoRenderPath
	{
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x386EE4", Offset = "0x386EE4", VA = "0x386EE4")]
		get
		{
			return default(StereoRenderingPathPico);
		}
	}

	[Token(Token = "0x17000066")]
	public SDKStereoRendering StereoRendering
	{
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x386EEC", Offset = "0x386EEC", VA = "0x386EEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162C44", Offset = "0x162C44")]
		get
		{
			return null;
		}
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x386EF4", Offset = "0x386EF4", VA = "0x386EF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162C54", Offset = "0x162C54")]
		private set
		{
		}
	}

	[Token(Token = "0x17000067")]
	public float RtScaleFactor
	{
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x386EFC", Offset = "0x386EFC", VA = "0x386EFC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x386F04", Offset = "0x386F04", VA = "0x386F04")]
		set
		{
		}
	}

	[Token(Token = "0x17000068")]
	public float EyeVFoV
	{
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x3870CC", Offset = "0x3870CC", VA = "0x3870CC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x3870D4", Offset = "0x3870D4", VA = "0x3870D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000069")]
	public float EyeHFoV
	{
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x3870EC", Offset = "0x3870EC", VA = "0x3870EC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x3870F4", Offset = "0x3870F4", VA = "0x3870F4")]
		set
		{
		}
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x3860E4", Offset = "0x3860E4", VA = "0x3860E4")]
	public Pvr_UnitySDKRender()
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x386238", Offset = "0x386238", VA = "0x386238")]
	public void ConnectToAndriod()
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x386DB0", Offset = "0x386DB0", VA = "0x386DB0")]
	public void Init()
	{
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x387534", Offset = "0x387534", VA = "0x387534")]
	private bool InitRenderAbility()
	{
		return default(bool);
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x3876A4", Offset = "0x3876A4", VA = "0x3876A4")]
	private bool UpdateRenderParaFrame()
	{
		return default(bool);
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x387784", Offset = "0x387784", VA = "0x387784")]
	private bool CreateEyeBuffer()
	{
		return default(bool);
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x3884B4", Offset = "0x3884B4", VA = "0x3884B4")]
	private void InitSinglePass()
	{
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x387C24", Offset = "0x387C24", VA = "0x387C24")]
	public float GetEyeVFOV()
	{
		return default(float);
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x387DF4", Offset = "0x387DF4", VA = "0x387DF4")]
	public float GetEyeHFOV()
	{
		return default(float);
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x3887B8", Offset = "0x3887B8", VA = "0x3887B8")]
	private void ConfigureEyeBuffer(int eyeTextureIndex, Vector2 resolution)
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x386F20", Offset = "0x386F20", VA = "0x386F20")]
	public bool ReCreateEyeBuffer()
	{
		return default(bool);
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x3844D8", Offset = "0x3844D8", VA = "0x3844D8")]
	public void ReInit()
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x382AF8", Offset = "0x382AF8", VA = "0x382AF8")]
	public void IssueRenderThread()
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x388FE8", Offset = "0x388FE8", VA = "0x388FE8")]
	private void AutoAdpatForPico1s()
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x387FC4", Offset = "0x387FC4", VA = "0x387FC4")]
	public Vector2 GetEyeBufferResolution()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x3893A0", Offset = "0x3893A0", VA = "0x3893A0")]
	public bool GetUsePredictedMatrix()
	{
		return default(bool);
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x38710C", Offset = "0x38710C", VA = "0x38710C")]
	public bool GetIsShellMode()
	{
		return default(bool);
	}
}
[Token(Token = "0x20000C9")]
public class Pvr_UnitySDKSinglePass : SDKStereoRendering
{
	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Camera bothCamera;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private Matrix4x4[] unity_StereoMatrixP;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Matrix4x4[] unity_StereoMatrixInvP;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Matrix4x4[] unity_StereoWorldToCamera;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Matrix4x4[] unity_StereoCameraToWorld;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Matrix4x4[] unity_StereoMatrixVP;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3[] eyesOffset;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Matrix4x4[] eyesOffsetMatrix;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private CommandBuffer commandBufferBeforeForwardOpaque;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CommandBuffer commandBufferBeforeSkybox;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private CommandBuffer commandBufferAfterSkybox;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color backgroundColor;

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x388EEC", Offset = "0x388EEC", VA = "0x388EEC")]
	public Pvr_UnitySDKSinglePass()
	{
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x38D3F4", Offset = "0x38D3F4", VA = "0x38D3F4", Slot = "4")]
	public override void InitEye(Camera eye)
	{
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x38E1C8", Offset = "0x38E1C8", VA = "0x38E1C8", Slot = "5")]
	public override void OnSDKRenderInited()
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x38E368", Offset = "0x38E368", VA = "0x38E368", Slot = "6")]
	public override void OnSDKPreRender()
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x38F500", Offset = "0x38F500", VA = "0x38F500", Slot = "7")]
	public override void OnSDKPostRender()
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x38E1CC", Offset = "0x38E1CC", VA = "0x38E1CC")]
	public void OnSDKRenderInited_SinglePass()
	{
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x38F5F0", Offset = "0x38F5F0", VA = "0x38F5F0")]
	private void SetAntiAliasing()
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0x38D924", Offset = "0x38D924", VA = "0x38D924")]
	public void SetEyesPosition()
	{
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0x38DEE8", Offset = "0x38DEE8", VA = "0x38DEE8")]
	public void SetEyeProjection()
	{
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0x38F768", Offset = "0x38F768", VA = "0x38F768")]
	private static Matrix4x4 GetProjection(float near, float far)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0x38FB2C", Offset = "0x38FB2C", VA = "0x38FB2C")]
	public static Matrix4x4 MakeProjection(float n, float f)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x38F8B4", Offset = "0x38F8B4", VA = "0x38F8B4")]
	public void SetStereoProjectionMatrix(Matrix4x4 left, Matrix4x4 right)
	{
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x38F508", Offset = "0x38F508", VA = "0x38F508")]
	private void SwitchKeywordAndDeviceView(bool enable)
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x38FD9C", Offset = "0x38FD9C", VA = "0x38FD9C")]
	public static Matrix4x4[] GetStereoWorldToCameraMat()
	{
		return null;
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x38E36C", Offset = "0x38E36C", VA = "0x38E36C")]
	public void SinglePassPreRender()
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x390394", Offset = "0x390394", VA = "0x390394")]
	private void SetCommandBuffers()
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x3902B8", Offset = "0x3902B8", VA = "0x3902B8")]
	private void SetRenderTextureWithDepth()
	{
	}
}
[Token(Token = "0x20000CA")]
public abstract class SDKStereoRendering
{
	[Token(Token = "0x6000647")]
	[Address(RVA = "0x38D3EC", Offset = "0x38D3EC", VA = "0x38D3EC")]
	protected SDKStereoRendering()
	{
	}

	[Token(Token = "0x6000648")]
	public abstract void InitEye(Camera eye);

	[Token(Token = "0x6000649")]
	public abstract void OnSDKRenderInited();

	[Token(Token = "0x600064A")]
	public abstract void OnSDKPreRender();

	[Token(Token = "0x600064B")]
	public abstract void OnSDKPostRender();
}
[Token(Token = "0x20000CB")]
public class HighlightAtGaze : MonoBehaviour
{
	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Color HighlightColor;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float AnimationTime;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer myRenderer;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Color originalColor;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Color targetColor;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private EyeTrackingGazeRay gazeRay;

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x3628F0", Offset = "0x3628F0", VA = "0x3628F0")]
	public HighlightAtGaze()
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x362938", Offset = "0x362938", VA = "0x362938")]
	private void Start()
	{
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x3629F8", Offset = "0x3629F8", VA = "0x3629F8")]
	private void Update()
	{
	}
}
[Token(Token = "0x20000CC")]
public class RayVisualizer : MonoBehaviour
{
	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private LineRenderer _line;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private EyeTrackingGazeRay gazeRay;

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x391CF4", Offset = "0x391CF4", VA = "0x391CF4")]
	public RayVisualizer()
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x391CFC", Offset = "0x391CFC", VA = "0x391CFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x391DC8", Offset = "0x391DC8", VA = "0x391DC8")]
	private void Update()
	{
	}
}
[Token(Token = "0x20000CD")]
public class GetSeeThroughImage : MonoBehaviour
{
	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public RawImage viewImage_left;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RawImage viewImage_right;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int width;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int height;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private RenderTexture cameraTex_left;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderTexture cameraTex_right;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool cameraPreview;

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x362664", Offset = "0x362664", VA = "0x362664")]
	public GetSeeThroughImage()
	{
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x36266C", Offset = "0x36266C", VA = "0x36266C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x3627D8", Offset = "0x3627D8", VA = "0x3627D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x3628C8", Offset = "0x3628C8", VA = "0x3628C8")]
	private void OnDestory()
	{
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x362670", Offset = "0x362670", VA = "0x362670")]
	private void CreateTexture()
	{
	}

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x362870", Offset = "0x362870", VA = "0x362870")]
	private void DrawTexture()
	{
	}
}
[Token(Token = "0x20000CE")]
public class OverlayExternalSurfaceDemo : MonoBehaviour
{
	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public string movieName;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Pvr_UnitySDKEyeOverlay.OverlayType overlayType;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Pvr_UnitySDKEyeOverlay.OverlayShape overlayShape;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Pvr_UnitySDKEyeOverlay overlay;

	[Token(Token = "0x4000417")]
	private const string TAG = "[ExternalSurface]>>>>>>";

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162C64", Offset = "0x162C64")]
	private static Pvr_UnitySDKEyeOverlay.ExternalAndroidSurfaceObjectCreated <>f__am$cache0;

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x3656B0", Offset = "0x3656B0", VA = "0x3656B0")]
	public OverlayExternalSurfaceDemo()
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x3656B8", Offset = "0x3656B8", VA = "0x3656B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x36583C", Offset = "0x36583C", VA = "0x36583C")]
	private void Start()
	{
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x365950", Offset = "0x365950", VA = "0x365950")]
	private void StartPlay(string moviePath, string licenceUrl)
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x365BC8", Offset = "0x365BC8", VA = "0x365BC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162C74", Offset = "0x162C74")]
	private static void <StartPlay>m__0()
	{
	}
}
[Token(Token = "0x20000CF")]
public class MoveCylinder : MonoBehaviour
{
	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Vector3 startingPosition;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Quaternion startingRotation;

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x364DB8", Offset = "0x364DB8", VA = "0x364DB8")]
	public MoveCylinder()
	{
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x364DC0", Offset = "0x364DC0", VA = "0x364DC0")]
	private void Start()
	{
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x364E48", Offset = "0x364E48", VA = "0x364E48")]
	public void Reset()
	{
	}
}
[Token(Token = "0x20000D0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x162C84", Offset = "0x162C84")]
public class MoveSphere : MonoBehaviour
{
	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Vector3 startingPosition;

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x364EE4", Offset = "0x364EE4", VA = "0x364EE4")]
	public MoveSphere()
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x364EEC", Offset = "0x364EEC", VA = "0x364EEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x365130", Offset = "0x365130", VA = "0x365130")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x365044", Offset = "0x365044", VA = "0x365044")]
	public void SetGazedAt(bool gazedAt)
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x365134", Offset = "0x365134", VA = "0x365134")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x3652E0", Offset = "0x3652E0", VA = "0x3652E0")]
	public void TeleportRandomly()
	{
	}
}
[Token(Token = "0x20000D1")]
public class Resetbutton : MonoBehaviour
{
	[Token(Token = "0x6000666")]
	[Address(RVA = "0x391FCC", Offset = "0x391FCC", VA = "0x391FCC")]
	public Resetbutton()
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x391FD4", Offset = "0x391FD4", VA = "0x391FD4")]
	public void DemoResetTracking()
	{
	}
}
[Token(Token = "0x20000D2")]
public class UserEntitlementCheck : MonoBehaviour
{
	[Token(Token = "0x6000668")]
	[Address(RVA = "0xACE3F4", Offset = "0xACE3F4", VA = "0xACE3F4")]
	public UserEntitlementCheck()
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0xACE3FC", Offset = "0xACE3FC", VA = "0xACE3FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0xACE4BC", Offset = "0xACE4BC", VA = "0xACE4BC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0xACE57C", Offset = "0xACE57C", VA = "0xACE57C")]
	private void HandelEntitlementCheckResult(int resultCode)
	{
	}
}
[Token(Token = "0x20000D3")]
public class Pvr_SQPLoader : MonoBehaviour
{
	[Token(Token = "0x20000D4")]
	private struct SceneInfo
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<string> scenes;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long version;

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x452CC0", Offset = "0x452CC0", VA = "0x452CC0")]
		public SceneInfo(List<string> sceneList, long currentSceneEpochVersion)
		{
		}
	}

	[Token(Token = "0x2000177")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162D0C", Offset = "0x162D0C")]
	private sealed class <onCheckNewSceneCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal SceneInfo <newSceneInfo>__1;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Pvr_SQPLoader $this;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal object $current;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool $disposing;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int $PC;

		[Token(Token = "0x170000BE")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x452BC4", Offset = "0x452BC4", VA = "0x452BC4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x452BCC", Offset = "0x452BCC", VA = "0x452BCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x452784", Offset = "0x452784", VA = "0x452784")]
		[DebuggerHidden]
		public <onCheckNewSceneCoroutine>c__Iterator0()
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x45278C", Offset = "0x45278C", VA = "0x45278C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x452BD4", Offset = "0x452BD4", VA = "0x452BD4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x452BE8", Offset = "0x452BE8", VA = "0x452BE8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400041C")]
	public const string RESOURCE_BUNDLE_NAME = "asset_resources";

	[Token(Token = "0x400041D")]
	public const string EXTERNAL_STORAGE_PATH = "/sdcard/Android/data";

	[Token(Token = "0x400041E")]
	public const string SCENE_LOAD_DATA_NAME = "SceneLoadData.txt";

	[Token(Token = "0x400041F")]
	private const string SQP_INDEX_NAME = "PvrSQPIndex";

	[Token(Token = "0x4000420")]
	private const string CACHE_SCENES_PATH = "cache/scenes";

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private AsyncOperation loadSceneOperation;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string scenePath;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private string sceneLoadDataPath;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<AssetBundle> loadedAssetBundles;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SceneInfo currentSceneInfo;

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x451B4C", Offset = "0x451B4C", VA = "0x451B4C")]
	public Pvr_SQPLoader()
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x451C3C", Offset = "0x451C3C", VA = "0x451C3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x451CD4", Offset = "0x451CD4", VA = "0x451CD4")]
	private void Start()
	{
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x4526DC", Offset = "0x4526DC", VA = "0x4526DC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x451E84", Offset = "0x451E84", VA = "0x451E84")]
	private SceneInfo GetSceneInfo()
	{
		return default(SceneInfo);
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x4520D8", Offset = "0x4520D8", VA = "0x4520D8")]
	private void LoadScene(SceneInfo sceneInfo)
	{
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x4526E0", Offset = "0x4526E0", VA = "0x4526E0")]
	private void LoadSceneOperation_completed(AsyncOperation obj)
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x452704", Offset = "0x452704", VA = "0x452704")]
	[DebuggerHidden]
	private IEnumerator onCheckNewSceneCoroutine()
	{
		return null;
	}
}
[Token(Token = "0x20000D5")]
public class Pvr_UnitySDKHeadTrack : MonoBehaviour
{
	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x162D6C", Offset = "0x162D6C")]
	public bool trackRotation;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x162DA0", Offset = "0x162DA0")]
	public bool trackPosition;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform target;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private bool updated;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	private bool dataClock;

	[Token(Token = "0x1700006A")]
	public Ray Gaze
	{
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x6C33D4", Offset = "0x6C33D4", VA = "0x6C33D4")]
		get
		{
			return default(Ray);
		}
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x6C33C4", Offset = "0x6C33C4", VA = "0x6C33C4")]
	public Pvr_UnitySDKHeadTrack()
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x6C3B04", Offset = "0x6C3B04", VA = "0x6C3B04")]
	private void Update()
	{
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x6C3488", Offset = "0x6C3488", VA = "0x6C3488")]
	private void UpdateHead()
	{
	}
}
[Token(Token = "0x20000D6")]
public class Pvr_UnitySDKPose
{
	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static readonly Matrix4x4 flipZ;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162DD4", Offset = "0x162DD4")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x162DD4", Offset = "0x162DD4")]
	private Vector3 <Position>k__BackingField;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162E08", Offset = "0x162E08")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x162E08", Offset = "0x162E08")]
	private Quaternion <Orientation>k__BackingField;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162E3C", Offset = "0x162E3C")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x162E3C", Offset = "0x162E3C")]
	private Matrix4x4 <Matrix>k__BackingField;

	[Token(Token = "0x1700006B")]
	public Matrix4x4 RightHandedMatrix
	{
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x3858C8", Offset = "0x3858C8", VA = "0x3858C8")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Token(Token = "0x1700006C")]
	public Vector3 Position
	{
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x385D2C", Offset = "0x385D2C", VA = "0x385D2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162E70", Offset = "0x162E70")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x385D3C", Offset = "0x385D3C", VA = "0x385D3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162E80", Offset = "0x162E80")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700006D")]
	public Quaternion Orientation
	{
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x385D48", Offset = "0x385D48", VA = "0x385D48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162E90", Offset = "0x162E90")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x385D5C", Offset = "0x385D5C", VA = "0x385D5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162EA0", Offset = "0x162EA0")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public Matrix4x4 Matrix
	{
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x385D08", Offset = "0x385D08", VA = "0x385D08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162EB0", Offset = "0x162EB0")]
		get
		{
			return default(Matrix4x4);
		}
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x385D6C", Offset = "0x385D6C", VA = "0x385D6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x162EC0", Offset = "0x162EC0")]
		protected set
		{
		}
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x38536C", Offset = "0x38536C", VA = "0x38536C")]
	public Pvr_UnitySDKPose(Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x38569C", Offset = "0x38569C", VA = "0x38569C")]
	public Pvr_UnitySDKPose(Vector3 position, Quaternion orientation)
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x3856F0", Offset = "0x3856F0", VA = "0x3856F0")]
	public void Set(Vector3 position, Quaternion orientation)
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x385414", Offset = "0x385414", VA = "0x385414")]
	protected void Set(Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x385DD8", Offset = "0x385DD8", VA = "0x385DD8")]
	private Quaternion NormalizeQuaternion(ref Quaternion q)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x20000D7")]
public class Pvr_UnitySDKSensor
{
	[Token(Token = "0x20000D8")]
	public delegate void Enter3DofModel();

	[Token(Token = "0x20000D9")]
	public delegate void Exit3DofModel();

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_UnitySDKSensor instance;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private bool SensorStart;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	private bool SensorInit;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Quaternion UnityQuaternion;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 UnityPosition;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Sensorindex sensorIndex;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool dofClock;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static Action EyeFovChanged;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Pvr_UnitySDKPose HeadPose;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float vfov;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float hfov;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float w;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float x;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float y;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float z;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float px;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float py;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float pz;

	[Token(Token = "0x1700006F")]
	public static Pvr_UnitySDKSensor Instance
	{
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x383850", Offset = "0x383850", VA = "0x383850")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x389614", Offset = "0x389614", VA = "0x389614")]
		set
		{
		}
	}

	[Token(Token = "0x14000016")]
	public static event Enter3DofModel Enter3DofModelEvent
	{
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x3896A4", Offset = "0x3896A4", VA = "0x3896A4")]
		add
		{
		}
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x389818", Offset = "0x389818", VA = "0x389818")]
		remove
		{
		}
	}

	[Token(Token = "0x14000017")]
	public static event Exit3DofModel Exit3DofModelEvent
	{
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x38998C", Offset = "0x38998C", VA = "0x38998C")]
		add
		{
		}
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x389B00", Offset = "0x389B00", VA = "0x389B00")]
		remove
		{
		}
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x3893AC", Offset = "0x3893AC", VA = "0x3893AC")]
	public Pvr_UnitySDKSensor()
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x3894C4", Offset = "0x3894C4", VA = "0x3894C4")]
	public void Init()
	{
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x38A160", Offset = "0x38A160", VA = "0x38A160")]
	public void SensorUpdate()
	{
	}

	[Token(Token = "0x600068F")]
	[Address(RVA = "0x389FB0", Offset = "0x389FB0", VA = "0x389FB0")]
	public bool InitUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x389C74", Offset = "0x389C74", VA = "0x389C74")]
	public bool InitUnitySDK6DofSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0x383978", Offset = "0x383978", VA = "0x383978")]
	public bool StartUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0x38B6C8", Offset = "0x38B6C8", VA = "0x38B6C8")]
	public bool StopUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0x383B28", Offset = "0x383B28", VA = "0x383B28")]
	public bool ResetUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0x383D24", Offset = "0x383D24", VA = "0x383D24")]
	public bool OptionalResetUnitySDKSensor(int resetRot, int resetPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0x38A1C8", Offset = "0x38A1C8", VA = "0x38A1C8")]
	public bool GetUnitySDKSensorState()
	{
		return default(bool);
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0x38BF0C", Offset = "0x38BF0C", VA = "0x38BF0C")]
	public bool GetUnitySDKPSensorState()
	{
		return default(bool);
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0x38BC70", Offset = "0x38BC70", VA = "0x38BC70")]
	private void RefreshHeadData(float x, float y, float z, float w, float px, float py, float pz)
	{
	}
}
[Token(Token = "0x20000DA")]
public class CLoadingAsset : ScriptableObject
{
	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public int SplashScreenType;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Texture2D> splashImage;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Texture2D Inside_background;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool UseSplashText;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public string DefaultText;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string ChineseText;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public string EnglishText;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string JapaneseText;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public string KoreanText;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string FontSize;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Color FontColor;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public string TextHeight;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool UseCarousel;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int SplashTextAlignment;

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x354E60", Offset = "0x354E60", VA = "0x354E60")]
	public CLoadingAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x20000DB")]
public class Pvr_UnitySDKConfigProfile
{
	[Token(Token = "0x20000DC")]
	public struct Lenses
	{
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float separation;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float offset;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float distance;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int alignment;

		[Token(Token = "0x400045A")]
		public const int AlignTop = -1;

		[Token(Token = "0x400045B")]
		public const int AlignCenter = 0;

		[Token(Token = "0x400045C")]
		public const int AlignBottom = 1;
	}

	[Token(Token = "0x20000DD")]
	public struct MaxFOV
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float upper;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float lower;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float inner;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float outer;
	}

	[Token(Token = "0x20000DE")]
	public struct Distortion
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float k1;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float k2;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float k3;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float k4;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float k5;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float k6;

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x6B7834", Offset = "0x6B7834", VA = "0x6B7834")]
		public float distort(float r)
		{
			return default(float);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x6B783C", Offset = "0x6B783C", VA = "0x6B783C")]
		public float distort(float r, float dist)
		{
			return default(float);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x6B7844", Offset = "0x6B7844", VA = "0x6B7844")]
		public float diatortInv(float radious)
		{
			return default(float);
		}
	}

	[Token(Token = "0x20000DF")]
	public struct Device
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Lenses devLenses;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MaxFOV devMaxFov;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Distortion devDistortion;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Distortion devDistortionInv;
	}

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Device SimulateDevice;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Device device;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static readonly Pvr_UnitySDKConfigProfile Default;

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x6B6D18", Offset = "0x6B6D18", VA = "0x6B6D18")]
	public Pvr_UnitySDKConfigProfile()
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x6B6D20", Offset = "0x6B6D20", VA = "0x6B6D20")]
	public Pvr_UnitySDKConfigProfile Clone()
	{
		return null;
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x6B6DC4", Offset = "0x6B6DC4", VA = "0x6B6DC4")]
	public static Pvr_UnitySDKConfigProfile GetPicoProfile()
	{
		return null;
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x6B6E98", Offset = "0x6B6E98", VA = "0x6B6E98")]
	public float[] GetLeftEyeVisibleTanAngles(float width, float height)
	{
		return null;
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x6B72C8", Offset = "0x6B72C8", VA = "0x6B72C8")]
	public float[] GetLeftEyeNoLensTanAngles(float width, float height)
	{
		return null;
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x6B7584", Offset = "0x6B7584", VA = "0x6B7584")]
	public Rect GetLeftEyeVisibleScreenRect(float[] undistortedFrustum, float width, float height)
	{
		return default(Rect);
	}
}
[Token(Token = "0x20000E0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x162F38", Offset = "0x162F38")]
public class Pvr_UnitySDKFPS : MonoBehaviour
{
	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Text fpsText;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float updateInterval;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float accum;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int frames;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float timeLeft;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string strFps;

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x6C31A0", Offset = "0x6C31A0", VA = "0x6C31A0")]
	public Pvr_UnitySDKFPS()
	{
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x6C31B0", Offset = "0x6C31B0", VA = "0x6C31B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x6C3250", Offset = "0x6C3250", VA = "0x6C3250")]
	private void ShowFps()
	{
	}
}
[Token(Token = "0x20000E1")]
public class Pvr_GazeFuse : MonoBehaviour
{
	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject gazeGameObject;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Image image;

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x44ACFC", Offset = "0x44ACFC", VA = "0x44ACFC")]
	public Pvr_GazeFuse()
	{
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x44AD04", Offset = "0x44AD04", VA = "0x44AD04")]
	private void Start()
	{
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x44AD6C", Offset = "0x44AD6C", VA = "0x44AD6C")]
	private void Update()
	{
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x44AFC8", Offset = "0x44AFC8", VA = "0x44AFC8")]
	private void FuseAmountChanged(float fuseAmount)
	{
	}
}
[Token(Token = "0x20000E2")]
public class Pvr_GazeInputModule : PointerInputModule
{
	[Token(Token = "0x20000E3")]
	public enum Mode
	{
		[Token(Token = "0x400047D")]
		Click,
		[Token(Token = "0x400047E")]
		Gaze
	}

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Mode mode;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x162FB0", Offset = "0x162FB0")]
	public string ClickInputName;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x162FE4", Offset = "0x162FE4")]
	public float GazeTimeInSeconds;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163018", Offset = "0x163018")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x163018", Offset = "0x163018")]
	private static float <gazeFraction>k__BackingField;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16304C", Offset = "0x16304C")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x16304C", Offset = "0x16304C")]
	private static GameObject <gazeGameObject>k__BackingField;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RaycastResult CurrentRaycast;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private PointerEventData pointerEventData;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private GameObject currentLookAtHandler;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float currentLookAtHandlerClickTime;

	[Token(Token = "0x17000070")]
	public static float gazeFraction
	{
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x44AF64", Offset = "0x44AF64", VA = "0x44AF64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163080", Offset = "0x163080")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x44B0F8", Offset = "0x44B0F8", VA = "0x44B0F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163090", Offset = "0x163090")]
		private set
		{
		}
	}

	[Token(Token = "0x17000071")]
	public static GameObject gazeGameObject
	{
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x44AF00", Offset = "0x44AF00", VA = "0x44AF00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1630A0", Offset = "0x1630A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x44B164", Offset = "0x44B164", VA = "0x44B164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1630B0", Offset = "0x1630B0")]
		private set
		{
		}
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x44B084", Offset = "0x44B084", VA = "0x44B084")]
	public Pvr_GazeInputModule()
	{
	}

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x44B1C8", Offset = "0x44B1C8", VA = "0x44B1C8", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x44B1E4", Offset = "0x44B1E4", VA = "0x44B1E4")]
	private void HandleLook()
	{
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x44B584", Offset = "0x44B584", VA = "0x44B584")]
	private void HandleSelection()
	{
	}
}
[Token(Token = "0x20000E4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x1630C0", Offset = "0x1630C0")]
public class Pvr_GazeInputModuleCrosshair : MonoBehaviour
{
	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool DisplayCrosshair;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x163138", Offset = "0x163138")]
	public Transform Crosshair;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Pvr_GazeInputModule gazeInputModule;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 CrosshairOriginalScale;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float CrosshairOriginalDistance;

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x44BC3C", Offset = "0x44BC3C", VA = "0x44BC3C")]
	public Pvr_GazeInputModuleCrosshair()
	{
	}

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x44BC44", Offset = "0x44BC44", VA = "0x44BC44")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x44BCAC", Offset = "0x44BCAC", VA = "0x44BCAC")]
	private void Start()
	{
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x44BD58", Offset = "0x44BD58", VA = "0x44BD58")]
	private void Update()
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x44BEBC", Offset = "0x44BEBC", VA = "0x44BEBC")]
	private void SetCrossHairAtDistance(float dist)
	{
	}
}
[Token(Token = "0x20000E5")]
public enum RenderEventType
{
	[Token(Token = "0x4000485")]
	InitRenderThread = 1024,
	[Token(Token = "0x4000486")]
	Pause,
	[Token(Token = "0x4000487")]
	Resume,
	[Token(Token = "0x4000488")]
	LeftEyeEndFrame,
	[Token(Token = "0x4000489")]
	RightEyeEndFrame,
	[Token(Token = "0x400048A")]
	TimeWarp,
	[Token(Token = "0x400048B")]
	ResetVrModeParms,
	[Token(Token = "0x400048C")]
	ShutdownRenderThread,
	[Token(Token = "0x400048D")]
	BeginEye,
	[Token(Token = "0x400048E")]
	EndEye,
	[Token(Token = "0x400048F")]
	BoundaryRenderLeft,
	[Token(Token = "0x4000490")]
	BoundaryRenderRight,
	[Token(Token = "0x4000491")]
	BothEyeEndFrame,
	[Token(Token = "0x4000492")]
	CameraFrameLeft,
	[Token(Token = "0x4000493")]
	CameraFrameRight,
	[Token(Token = "0x4000494")]
	StartCameraFrame,
	[Token(Token = "0x4000495")]
	StopCameraFrame
}
[Token(Token = "0x20000E6")]
public static class Pvr_UnitySDKPluginEvent
{
	[Token(Token = "0x20000E7")]
	private delegate void RenderEventDelegate(int eventId);

	[Token(Token = "0x4000496")]
	private const uint IS_DATA_FLAG = 2147483648u;

	[Token(Token = "0x4000497")]
	private const uint DATA_POS_MASK = 1073741824u;

	[Token(Token = "0x4000498")]
	private const int DATA_POS_SHIFT = 30;

	[Token(Token = "0x4000499")]
	private const uint EVENT_TYPE_MASK = 1056899072u;

	[Token(Token = "0x400049A")]
	private const int EVENT_TYPE_SHIFT = 17;

	[Token(Token = "0x400049B")]
	private const uint PAYLOAD_MASK = 65535u;

	[Token(Token = "0x400049C")]
	private const int PAYLOAD_SHIFT = 16;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static RenderEventDelegate SetSinglePassBeforeForwardOpaqueHandle;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static IntPtr SetSinglePassBeforeForwardOpaquePtr;

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x384E6C", Offset = "0x384E6C", VA = "0x384E6C")]
	public static void Issue(RenderEventType eventType)
	{
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x384E9C", Offset = "0x384E9C", VA = "0x384E9C")]
	private static int EncodeType(int eventType)
	{
		return default(int);
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x384EA8", Offset = "0x384EA8", VA = "0x384EA8")]
	private static int EncodeData(int eventId, int eventData, int pos)
	{
		return default(int);
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x384ED4", Offset = "0x384ED4", VA = "0x384ED4")]
	private static int DecodeData(int eventData)
	{
		return default(int);
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x384E60", Offset = "0x384E60", VA = "0x384E60")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x16316C", Offset = "0x16316C")]
	private static void SetSinglePassBeforeForwardOpaque(int eventId)
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x384EE8", Offset = "0x384EE8", VA = "0x384EE8")]
	public static void SetSinglePassBeforeForwardOpaque(CommandBuffer cmd)
	{
	}
}
[Token(Token = "0x20000E8")]
public class Pvr_UnitySDKSightInputModule : BaseInputModule
{
	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1631E4", Offset = "0x1631E4")]
	public GameObject cursor;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int trigger;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public float clickTime;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Vector2 hotspot;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PointerEventData pointerData;

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x38C170", Offset = "0x38C170", VA = "0x38C170")]
	public Pvr_UnitySDKSightInputModule()
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x38C1CC", Offset = "0x38C1CC", VA = "0x38C1CC", Slot = "21")]
	public override bool ShouldActivateModule()
	{
		return default(bool);
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x38C28C", Offset = "0x38C28C", VA = "0x38C28C", Slot = "22")]
	public override void DeactivateModule()
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x38C650", Offset = "0x38C650", VA = "0x38C650", Slot = "20")]
	public override bool IsPointerOverGameObject(int pointerId)
	{
		return default(bool);
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x38C6FC", Offset = "0x38C6FC", VA = "0x38C6FC", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x38C730", Offset = "0x38C730", VA = "0x38C730")]
	private void CastRayFromGaze()
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x38C99C", Offset = "0x38C99C", VA = "0x38C99C")]
	private void UpdateCurrentObject()
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x38CBF4", Offset = "0x38CBF4", VA = "0x38CBF4")]
	private void PlaceCursor()
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x38C3C8", Offset = "0x38C3C8", VA = "0x38C3C8")]
	private void HandlePendingClick()
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x38CF30", Offset = "0x38CF30", VA = "0x38CF30")]
	private void HandleTrigger()
	{
	}
}
[Token(Token = "0x20000E9")]
public class Pvr_ObjImporter
{
	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Pvr_ObjImporter _instance;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private List<int> triangles;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private List<Vector3> vertices;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<Vector2> uv;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private List<Vector3> normals;

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<PvrVector3Int> faceData;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private List<int> intArray;

	[Token(Token = "0x40004AB")]
	private const int MIN_POW_10 = -16;

	[Token(Token = "0x40004AC")]
	private const int MAX_POW_10 = 16;

	[Token(Token = "0x40004AD")]
	private const int NUM_POWS_10 = 33;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly float[] pow10;

	[Token(Token = "0x17000072")]
	public static Pvr_ObjImporter Instance
	{
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x450090", Offset = "0x450090", VA = "0x450090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x450088", Offset = "0x450088", VA = "0x450088")]
	public Pvr_ObjImporter()
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x45017C", Offset = "0x45017C", VA = "0x45017C")]
	public Mesh ImportFile(string filePath)
	{
		return null;
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x450874", Offset = "0x450874", VA = "0x450874")]
	private void LoadMeshData(string fileName)
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x45127C", Offset = "0x45127C", VA = "0x45127C")]
	private float GetFloat(StringBuilder sb, ref int start, ref StringBuilder sbFloat)
	{
		return default(float);
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x451454", Offset = "0x451454", VA = "0x451454")]
	private int GetInt(StringBuilder sb, ref int start, ref StringBuilder sbInt)
	{
		return default(int);
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x4519A4", Offset = "0x4519A4", VA = "0x4519A4")]
	private static float[] GenerateLookupTable()
	{
		return null;
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x4515E4", Offset = "0x4515E4", VA = "0x4515E4")]
	private float ParseFloat(StringBuilder value)
	{
		return default(float);
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x451934", Offset = "0x451934", VA = "0x451934")]
	private int IntParseFast(StringBuilder value)
	{
		return default(int);
	}
}
[Token(Token = "0x20000EA")]
public sealed class PvrVector3Int
{
	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163238", Offset = "0x163238")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x163238", Offset = "0x163238")]
	private int <x>k__BackingField;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16326C", Offset = "0x16326C")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x16326C", Offset = "0x16326C")]
	private int <y>k__BackingField;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1632A0", Offset = "0x1632A0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1632A0", Offset = "0x1632A0")]
	private int <z>k__BackingField;

	[Token(Token = "0x17000073")]
	public int x
	{
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x391C38", Offset = "0x391C38", VA = "0x391C38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1632D4", Offset = "0x1632D4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x391C20", Offset = "0x391C20", VA = "0x391C20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1632E4", Offset = "0x1632E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public int y
	{
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x391C40", Offset = "0x391C40", VA = "0x391C40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1632F4", Offset = "0x1632F4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x391C28", Offset = "0x391C28", VA = "0x391C28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163304", Offset = "0x163304")]
		set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public int z
	{
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x391C48", Offset = "0x391C48", VA = "0x391C48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163314", Offset = "0x163314")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x391C30", Offset = "0x391C30", VA = "0x391C30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163324", Offset = "0x163324")]
		set
		{
		}
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x391BE8", Offset = "0x391BE8", VA = "0x391BE8")]
	public PvrVector3Int()
	{
	}

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x391BF0", Offset = "0x391BF0", VA = "0x391BF0")]
	public PvrVector3Int(int x, int y, int z)
	{
	}
}
[Token(Token = "0x20000EB")]
public class Pvr_EnumFlags : PropertyAttribute
{
	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x44ACF4", Offset = "0x44ACF4", VA = "0x44ACF4")]
	public Pvr_EnumFlags()
	{
	}
}
[Token(Token = "0x20000EC")]
public enum ConfirmBtn
{
	[Token(Token = "0x40004B3")]
	App = 1,
	[Token(Token = "0x40004B4")]
	TouchPad = 2,
	[Token(Token = "0x40004B5")]
	Trigger = 4
}
[Token(Token = "0x20000ED")]
public class Pvr_InputModule : PointerInputModule
{
	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Pvr_UIPointer> pointers;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Pvr_EnumFlags]
	public ConfirmBtn confirmBtn;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<RaycastResult> rayCasts;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private RaycastResult rayCastResult;

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x44C074", Offset = "0x44C074", VA = "0x44C074")]
	public Pvr_InputModule()
	{
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x44C114", Offset = "0x44C114", VA = "0x44C114", Slot = "30")]
	public virtual void Initialise()
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x44C1C4", Offset = "0x44C1C4", VA = "0x44C1C4")]
	public static void AddPoint(Pvr_UIPointer point)
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x44C2F0", Offset = "0x44C2F0", VA = "0x44C2F0")]
	public static void RemovePoint(Pvr_UIPointer point)
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x44C41C", Offset = "0x44C41C", VA = "0x44C41C", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x44C940", Offset = "0x44C940", VA = "0x44C940", Slot = "31")]
	protected virtual List<RaycastResult> CheckRaycasts(Pvr_UIPointer pointer)
	{
		return null;
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x44CB00", Offset = "0x44CB00", VA = "0x44CB00", Slot = "32")]
	protected virtual bool CheckTransformTree(Transform target, Transform source)
	{
		return default(bool);
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x44CC1C", Offset = "0x44CC1C", VA = "0x44CC1C", Slot = "33")]
	protected virtual bool NoValidCollision(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		return default(bool);
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x44CD98", Offset = "0x44CD98", VA = "0x44CD98", Slot = "34")]
	protected virtual bool IsHovering(Pvr_UIPointer pointer)
	{
		return default(bool);
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x44D060", Offset = "0x44D060", VA = "0x44D060", Slot = "35")]
	protected virtual bool ValidElement(GameObject obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x44D148", Offset = "0x44D148", VA = "0x44D148", Slot = "36")]
	protected virtual void CheckPointerHoverClick(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x44D1E8", Offset = "0x44D1E8", VA = "0x44D1E8", Slot = "37")]
	protected virtual void Hover(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x44EB38", Offset = "0x44EB38", VA = "0x44EB38", Slot = "38")]
	protected virtual void Click(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x44EBC0", Offset = "0x44EBC0", VA = "0x44EBC0", Slot = "39")]
	protected virtual void ClickOnUp(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x44EC70", Offset = "0x44EC70", VA = "0x44EC70", Slot = "40")]
	protected virtual void ClickOnDown(Pvr_UIPointer pointer, List<RaycastResult> results, bool forceClick = false)
	{
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x44ED4C", Offset = "0x44ED4C", VA = "0x44ED4C", Slot = "41")]
	protected virtual bool IsEligibleClick(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		return default(bool);
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x44F1F0", Offset = "0x44F1F0", VA = "0x44F1F0", Slot = "42")]
	protected virtual bool AttemptClick(Pvr_UIPointer pointer)
	{
		return default(bool);
	}

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x44F6D4", Offset = "0x44F6D4", VA = "0x44F6D4", Slot = "43")]
	protected virtual void Drag(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
	}
}
[Token(Token = "0x20000EE")]
public class Pvr_UICanvas : MonoBehaviour
{
	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163354", Offset = "0x163354")]
	private sealed class <CreateDraggablePanel>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Canvas canvas;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal GameObject <draggablePanel>__1;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Vector2 canvasSize;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object $current;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal bool $disposing;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int $PC;

		[Token(Token = "0x170000C0")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x45726C", Offset = "0x45726C", VA = "0x45726C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x457274", Offset = "0x457274", VA = "0x457274", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x456874", Offset = "0x456874", VA = "0x456874")]
		[DebuggerHidden]
		public <CreateDraggablePanel>c__Iterator0()
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x456CB8", Offset = "0x456CB8", VA = "0x456CB8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x45727C", Offset = "0x45727C", VA = "0x45727C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x457290", Offset = "0x457290", VA = "0x457290", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool clickOnPointerCollision;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float autoActivateWithinDistance;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	protected BoxCollider canvasBoxCollider;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Rigidbody canvasRigidBody;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected Coroutine draggablePanelCreation;

	[Token(Token = "0x40004BF")]
	protected const string CANVAS_DRAGGABLE_PANEL = "UICANVAS_DRAGGABLE_PANEL";

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x4561D0", Offset = "0x4561D0", VA = "0x4561D0")]
	public Pvr_UICanvas()
	{
	}

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x4561D8", Offset = "0x4561D8", VA = "0x4561D8", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x4561E8", Offset = "0x4561E8", VA = "0x4561E8", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x4561F8", Offset = "0x4561F8", VA = "0x4561F8", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x456208", Offset = "0x456208", VA = "0x456208", Slot = "7")]
	protected virtual void SetupCanvas()
	{
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0x4567D4", Offset = "0x4567D4", VA = "0x4567D4", Slot = "8")]
	[DebuggerHidden]
	protected virtual IEnumerator CreateDraggablePanel(Canvas canvas, Vector2 canvasSize)
	{
		return null;
	}

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x45687C", Offset = "0x45687C", VA = "0x45687C", Slot = "9")]
	protected virtual void RemoveCanvas()
	{
	}
}
[Token(Token = "0x20000EF")]
public struct UIDraggableItemEventArgs
{
	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject target;
}
[Token(Token = "0x20000F0")]
public delegate void UIDraggableItemEventHandler(object sender, UIDraggableItemEventArgs e);
[Token(Token = "0x20000F1")]
public class Pvr_UIDraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IEventSystemHandler
{
	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool restrictToDropZone;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public bool restrictToOriginalCanvas;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float moveOffset;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public GameObject validDropZone;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected RectTransform dragTransform;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected Vector3 startPosition;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Quaternion startRotation;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected GameObject startDropZone;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected Transform startParent;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Canvas startCanvas;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected CanvasGroup canvasGroup;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Pvr_InputModule currentInputmodule;

	[Token(Token = "0x14000018")]
	public event UIDraggableItemEventHandler DraggableItemDropped
	{
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x457328", Offset = "0x457328", VA = "0x457328")]
		add
		{
		}
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x45741C", Offset = "0x45741C", VA = "0x45741C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000019")]
	public event UIDraggableItemEventHandler DraggableItemReset
	{
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x457510", Offset = "0x457510", VA = "0x457510")]
		add
		{
		}
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x457604", Offset = "0x457604", VA = "0x457604")]
		remove
		{
		}
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0x457314", Offset = "0x457314", VA = "0x457314")]
	public Pvr_UIDraggableItem()
	{
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0x4576F8", Offset = "0x4576F8", VA = "0x4576F8", Slot = "7")]
	public virtual void OnDraggableItemDropped(UIDraggableItemEventArgs e)
	{
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0x457714", Offset = "0x457714", VA = "0x457714", Slot = "8")]
	public virtual void OnDraggableItemReset(UIDraggableItemEventArgs e)
	{
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0x457730", Offset = "0x457730", VA = "0x457730", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0x457AF8", Offset = "0x457AF8", VA = "0x457AF8", Slot = "5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0x457B08", Offset = "0x457B08", VA = "0x457B08", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0x4581E8", Offset = "0x4581E8", VA = "0x4581E8", Slot = "9")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x458318", Offset = "0x458318", VA = "0x458318", Slot = "10")]
	protected virtual Pvr_UIPointer GetPointer()
	{
		return null;
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0x458528", Offset = "0x458528", VA = "0x458528", Slot = "11")]
	protected virtual void SetDragPosition(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0x458940", Offset = "0x458940", VA = "0x458940", Slot = "12")]
	protected virtual void ResetElement()
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x458A5C", Offset = "0x458A5C", VA = "0x458A5C", Slot = "13")]
	protected virtual UIDraggableItemEventArgs SetEventPayload(GameObject target)
	{
		return default(UIDraggableItemEventArgs);
	}
}
[Token(Token = "0x20000F2")]
public class Pvr_UIDropZone : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
{
	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	protected Pvr_UIDraggableItem droppableItem;

	[Token(Token = "0x6000716")]
	[Address(RVA = "0x458A64", Offset = "0x458A64", VA = "0x458A64")]
	public Pvr_UIDropZone()
	{
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0x458A6C", Offset = "0x458A6C", VA = "0x458A6C", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x458BD0", Offset = "0x458BD0", VA = "0x458BD0", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
[Token(Token = "0x20000F3")]
public class Pvr_UIGraphicRaycaster : GraphicRaycaster
{
	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Canvas currentCanvas;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected Vector2 lastKnownPosition;

	[Token(Token = "0x40004D2")]
	protected const float UI_CONTROL_OFFSET = 1E-05f;

	[NonSerialized]
	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<RaycastResult> s_RaycastResults;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16342C", Offset = "0x16342C")]
	private static Comparison<RaycastResult> <>f__am$cache0;

	[Token(Token = "0x17000076")]
	protected virtual Canvas canvas
	{
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x45A0C0", Offset = "0x45A0C0", VA = "0x45A0C0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0x458C84", Offset = "0x458C84", VA = "0x458C84")]
	public Pvr_UIGraphicRaycaster()
	{
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0x458D08", Offset = "0x458D08", VA = "0x458D08", Slot = "17")]
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x458F48", Offset = "0x458F48", VA = "0x458F48", Slot = "22")]
	protected virtual void SetNearestRaycast(ref PointerEventData eventData, ref List<RaycastResult> resultAppendList, ref List<RaycastResult> raycastResults)
	{
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x459484", Offset = "0x459484", VA = "0x459484", Slot = "23")]
	protected virtual float GetHitDistance(Ray ray)
	{
		return default(float);
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x459878", Offset = "0x459878", VA = "0x459878", Slot = "24")]
	protected virtual void Raycast(Canvas canvas, Camera eventCamera, Ray ray, ref List<RaycastResult> results)
	{
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x45A224", Offset = "0x45A224", VA = "0x45A224")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16343C", Offset = "0x16343C")]
	private static int <Raycast>m__0(RaycastResult g1, RaycastResult g2)
	{
		return default(int);
	}
}
[Token(Token = "0x20000F4")]
public struct UIPointerEventArgs
{
	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool isActive;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public GameObject currentTarget;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public GameObject previousTarget;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public RaycastResult raycastResult;
}
[Token(Token = "0x20000F5")]
public delegate void UIPointerEventHandler(object sender, UIPointerEventArgs e);
[Token(Token = "0x20000F6")]
public class Pvr_UIPointer : MonoBehaviour
{
	[Token(Token = "0x20000F7")]
	public enum ClickMethods
	{
		[Token(Token = "0x40004F3")]
		ClickOnButtonUp,
		[Token(Token = "0x40004F4")]
		ClickOnButtonDown
	}

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public ClickMethods clickMethod;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public bool collisionClick;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[HideInInspector]
	public bool pressToDrag;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public GameObject autoActivatingCanvas;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public PointerEventData pointerEventData;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public GameObject hoveringElement;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public float hoverDurationTimer;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public bool canClickOnHover;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform pointerOriginTransform;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected bool pointerClicked;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	protected bool beamEnabledState;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	protected bool lastPointerPressState;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	protected bool lastPointerClickState;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected GameObject currentTarget;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected EventSystem cachedEventSystem;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Pvr_InputModule cachedVRInputModule;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected Transform originalPointerOriginTransform;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool TouchBtnValue;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool AppBtnValue;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool TriggerBtnValue;

	[Token(Token = "0x1400001A")]
	public event UIPointerEventHandler UIPointerElementEnter
	{
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x45A2BC", Offset = "0x45A2BC", VA = "0x45A2BC")]
		add
		{
		}
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x45A3B0", Offset = "0x45A3B0", VA = "0x45A3B0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001B")]
	public event UIPointerEventHandler UIPointerElementExit
	{
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x45A4A4", Offset = "0x45A4A4", VA = "0x45A4A4")]
		add
		{
		}
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x45A598", Offset = "0x45A598", VA = "0x45A598")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001C")]
	public event UIPointerEventHandler UIPointerElementClick
	{
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x45A68C", Offset = "0x45A68C", VA = "0x45A68C")]
		add
		{
		}
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x45A780", Offset = "0x45A780", VA = "0x45A780")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001D")]
	public event UIPointerEventHandler UIPointerElementDragStart
	{
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x45A874", Offset = "0x45A874", VA = "0x45A874")]
		add
		{
		}
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x45A968", Offset = "0x45A968", VA = "0x45A968")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001E")]
	public event UIPointerEventHandler UIPointerElementDragEnd
	{
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x45AA5C", Offset = "0x45AA5C", VA = "0x45AA5C")]
		add
		{
		}
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x45AB50", Offset = "0x45AB50", VA = "0x45AB50")]
		remove
		{
		}
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x45A2B4", Offset = "0x45A2B4", VA = "0x45A2B4")]
	public Pvr_UIPointer()
	{
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x45AC44", Offset = "0x45AC44", VA = "0x45AC44", Slot = "4")]
	public virtual bool PointerActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x45AC4C", Offset = "0x45AC4C", VA = "0x45AC4C", Slot = "5")]
	public virtual bool IsSelectionButtonPressed()
	{
		return default(bool);
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x45ADE8", Offset = "0x45ADE8", VA = "0x45ADE8", Slot = "6")]
	public virtual Vector3 GetOriginPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x45AED8", Offset = "0x45AED8", VA = "0x45AED8", Slot = "7")]
	public virtual Vector3 GetOriginForward()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0x45AFC8", Offset = "0x45AFC8", VA = "0x45AFC8", Slot = "8")]
	public virtual bool ValidClick(bool checkLastClick, bool lastClickState = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0x45B000", Offset = "0x45B000", VA = "0x45B000", Slot = "9")]
	protected virtual void ResetHoverTimer()
	{
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0x45B010", Offset = "0x45B010", VA = "0x45B010", Slot = "10")]
	public virtual void OnUIPointerElementEnter(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0x45B120", Offset = "0x45B120", VA = "0x45B120", Slot = "11")]
	public virtual void OnUIPointerElementExit(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0x45B22C", Offset = "0x45B22C", VA = "0x45B22C", Slot = "12")]
	public virtual void OnUIPointerElementClick(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0x45B338", Offset = "0x45B338", VA = "0x45B338", Slot = "13")]
	public virtual void OnUIPointerElementDragStart(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0x45B3A4", Offset = "0x45B3A4", VA = "0x45B3A4", Slot = "14")]
	public virtual void OnUIPointerElementDragEnd(UIPointerEventArgs e)
	{
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x45B410", Offset = "0x45B410", VA = "0x45B410", Slot = "15")]
	public virtual UIPointerEventArgs SetUIPointerEvent(RaycastResult currentRaycastResult, GameObject currentTarget, [Optional] GameObject lastTarget)
	{
		return default(UIPointerEventArgs);
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x45B4D0", Offset = "0x45B4D0", VA = "0x45B4D0", Slot = "16")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x45B4DC", Offset = "0x45B4DC", VA = "0x45B4DC", Slot = "17")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x45B510", Offset = "0x45B510", VA = "0x45B510", Slot = "18")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x45B590", Offset = "0x45B590", VA = "0x45B590", Slot = "19")]
	protected virtual void ConfigureEventSystem()
	{
	}
}
[Token(Token = "0x20000F8")]
[ExecuteInEditMode]
public class Pvr_UnitySDKEditor : MonoBehaviour
{
	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private bool vrModeEnabled;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float mouseX;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float mouseY;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float mouseZ;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float neckModelScale;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool autoUntiltHead;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 neckOffset;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public Matrix4x4 headView;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[HideInInspector]
	public Matrix4x4 leftEyeUndistortedProj;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[HideInInspector]
	public Matrix4x4 rightEyeUndistortedProj;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[HideInInspector]
	public Matrix4x4 leftEyeProj;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	[HideInInspector]
	public Matrix4x4 rightEyeProj;

	[Token(Token = "0x4000501")]
	private const float TOUCH_TIME_LIMIT = 0.2f;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private float touchStartTime;

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x6B784C", Offset = "0x6B784C", VA = "0x6B784C")]
	public Pvr_UnitySDKEditor()
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x6B785C", Offset = "0x6B785C", VA = "0x6B785C")]
	public Matrix4x4 UndistortedProjection(Eye eye)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x6B78A0", Offset = "0x6B78A0", VA = "0x6B78A0")]
	public Matrix4x4 Projection(Eye eye)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x6B78E4", Offset = "0x6B78E4", VA = "0x6B78E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x6B7B84", Offset = "0x6B7B84", VA = "0x6B7B84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x6B78F8", Offset = "0x6B78F8", VA = "0x6B78F8")]
	public void InitEyePara()
	{
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x6B7AC4", Offset = "0x6B7AC4", VA = "0x6B7AC4")]
	private void InitEditorSensorPara()
	{
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0x6B8B2C", Offset = "0x6B8B2C", VA = "0x6B8B2C")]
	public static Matrix4x4 MakeProjection(float l, float t, float r, float b, float n, float f)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0x6B8D20", Offset = "0x6B8D20", VA = "0x6B8D20")]
	public bool UpdateStatesensor()
	{
		return default(bool);
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0x6B7E98", Offset = "0x6B7E98", VA = "0x6B7E98")]
	public void ComputeEyesFromProfile()
	{
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0x6B94C8", Offset = "0x6B94C8", VA = "0x6B94C8")]
	public bool ResetUnitySDKSensor()
	{
		return default(bool);
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0x6B7C50", Offset = "0x6B7C50", VA = "0x6B7C50")]
	private void SimulateInput()
	{
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0x6B8A2C", Offset = "0x6B8A2C", VA = "0x6B8A2C")]
	private void FovAdjust()
	{
	}

	[Token(Token = "0x600074E")]
	[Address(RVA = "0x6B959C", Offset = "0x6B959C", VA = "0x6B959C")]
	private Rect RectAdjust(Rect eyeRect)
	{
		return default(Rect);
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x6B8D34", Offset = "0x6B8D34", VA = "0x6B8D34")]
	private void UpdateSimulatedSensor()
	{
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x6B887C", Offset = "0x6B887C", VA = "0x6B887C")]
	private void InitForEye(ref Material mat, ref Material mat1)
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x6B94E0", Offset = "0x6B94E0", VA = "0x6B94E0")]
	private void EnableVEmodel()
	{
	}
}
namespace Pvr_UnitySDKAPI
{
	[Token(Token = "0x20000F9")]
	public enum DeviceCommand
	{
		[Token(Token = "0x4000504")]
		SET_PICO_NEO_HMD_BRIGHTNESS = 12,
		[Token(Token = "0x4000505")]
		SET_PICO_NEO_HMD_SLEEPDELAY
	}
	[Token(Token = "0x20000FA")]
	public enum BrightnessLevel
	{
		[Token(Token = "0x4000507")]
		VR_BRIGHTNESS_LEVEL_MIN = 1,
		[Token(Token = "0x4000508")]
		VR_BRIGHTNESS_LEVEL_MAX = 100,
		[Token(Token = "0x4000509")]
		VR_BRIGHTNESS_LEVEL_DOWN = 1000,
		[Token(Token = "0x400050A")]
		VR_BRIGHTNESS_LEVEL_UP = 1001,
		[Token(Token = "0x400050B")]
		VR_BRIGHTNESS_LEVEL_SCREEN_OFF = -100
	}
	[Token(Token = "0x20000FB")]
	public struct VolumePowerBrightness
	{
		[Token(Token = "0x400050C")]
		public const string LibFileName = "Pvr_UnitySDK";

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AndroidJavaObject activity;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static AndroidJavaClass javaSysActivityClass;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static AndroidJavaClass batteryjavaVrActivityClass;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AndroidJavaClass volumejavaVrActivityClass;

		[PreserveSig]
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x6B4018", Offset = "0x6B4018", VA = "0x6B4018")]
		public static extern void Pvr_SetInitActivity(IntPtr activity, IntPtr vrActivityClass);

		[PreserveSig]
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x6B40E0", Offset = "0x6B40E0", VA = "0x6B40E0")]
		private static extern bool Pvr_IsHmdExist();

		[PreserveSig]
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x6B4198", Offset = "0x6B4198", VA = "0x6B4198")]
		private static extern int Pvr_GetHmdScreenBrightness();

		[PreserveSig]
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x6B4248", Offset = "0x6B4248", VA = "0x6B4248")]
		private static extern bool Pvr_SetHmdScreenBrightness(int brightness);

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x6B4310", Offset = "0x6B4310", VA = "0x6B4310")]
		public static bool UPvr_IsHmdExist()
		{
			return default(bool);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x6B4314", Offset = "0x6B4314", VA = "0x6B4314")]
		public static int UPvr_GetHmdScreenBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x6B4318", Offset = "0x6B4318", VA = "0x6B4318")]
		public static bool UPvr_SetHmdScreenBrightness(int brightness)
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x6B431C", Offset = "0x6B431C", VA = "0x6B431C")]
		public static bool UPvr_SetCommonBrightness(int brightness)
		{
			return default(bool);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x6B464C", Offset = "0x6B464C", VA = "0x6B464C")]
		public static int UPvr_GetCommonBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x6B4918", Offset = "0x6B4918", VA = "0x6B4918")]
		public static int[] UPvr_GetScreenBrightnessLevel()
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x6B4B40", Offset = "0x6B4B40", VA = "0x6B4B40")]
		public static void UPvr_SetScreenBrightnessLevel(int vrBrightness, int level)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x6B4E08", Offset = "0x6B4E08", VA = "0x6B4E08")]
		public static bool UPvr_SetDevicePropForUser(DeviceCommand deviceid, string number)
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x6B4FD0", Offset = "0x6B4FD0", VA = "0x6B4FD0")]
		public static string UPvr_GetDevicePropForUser(DeviceCommand deviceid)
		{
			return null;
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x6B5158", Offset = "0x6B5158", VA = "0x6B5158")]
		public static bool UPvr_InitBatteryClass()
		{
			return default(bool);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x6B5428", Offset = "0x6B5428", VA = "0x6B5428")]
		public static bool UPvr_InitBatteryVolClass()
		{
			return default(bool);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x6B57FC", Offset = "0x6B57FC", VA = "0x6B57FC")]
		public static bool UPvr_StartBatteryReceiver(string startreceivre)
		{
			return default(bool);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x6B5AD4", Offset = "0x6B5AD4", VA = "0x6B5AD4")]
		public static bool UPvr_StopBatteryReceiver()
		{
			return default(bool);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x6B4348", Offset = "0x6B4348", VA = "0x6B4348")]
		public static bool UPvr_SetBrightness(int brightness)
		{
			return default(bool);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x6B4670", Offset = "0x6B4670", VA = "0x6B4670")]
		public static int UPvr_GetCurrentBrightness()
		{
			return default(int);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x6B491C", Offset = "0x6B491C", VA = "0x6B491C")]
		public static int[] Pvr_GetScreenBrightnessLevel()
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x6B4B44", Offset = "0x6B4B44", VA = "0x6B4B44")]
		public static void Pvr_SetScreenBrightnessLevel(int vrBrightness, int level)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x6B5D60", Offset = "0x6B5D60", VA = "0x6B5D60")]
		public static bool UPvr_StartAudioReceiver(string startreceivre)
		{
			return default(bool);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x6B6038", Offset = "0x6B6038", VA = "0x6B6038")]
		public static bool UPvr_StopAudioReceiver()
		{
			return default(bool);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x6B62C4", Offset = "0x6B62C4", VA = "0x6B62C4")]
		public static int UPvr_GetMaxVolumeNumber()
		{
			return default(int);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x6B64C8", Offset = "0x6B64C8", VA = "0x6B64C8")]
		public static int UPvr_GetCurrentVolumeNumber()
		{
			return default(int);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x6B66CC", Offset = "0x6B66CC", VA = "0x6B66CC")]
		public static bool UPvr_VolumeUp()
		{
			return default(bool);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x6B68B8", Offset = "0x6B68B8", VA = "0x6B68B8")]
		public static bool UPvr_VolumeDown()
		{
			return default(bool);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x6B6AA4", Offset = "0x6B6AA4", VA = "0x6B6AA4")]
		public static bool UPvr_SetVolumeNum(int volume)
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x6B6D08", Offset = "0x6B6D08", VA = "0x6B6D08")]
		public static bool UPvr_SetAudio(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x6B6D10", Offset = "0x6B6D10", VA = "0x6B6D10")]
		public static bool UPvr_SetBattery(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x6B4FD4", Offset = "0x6B4FD4", VA = "0x6B4FD4")]
		private static string getDevicePropForUser(DeviceCommand deviceid)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x6B4E0C", Offset = "0x6B4E0C", VA = "0x6B4E0C")]
		private static bool setDevicePropForUser(DeviceCommand deviceid, string number)
		{
			return default(bool);
		}
	}
}
[Token(Token = "0x20000FC")]
public class Pvr_VolumePowerBrightness : MonoBehaviour
{
	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private bool VolEnable;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	private bool BattEnable;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Text showResult;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Text setVolumnum;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text setBrightnum;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public string MusicPath;

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x391238", Offset = "0x391238", VA = "0x391238")]
	public Pvr_VolumePowerBrightness()
	{
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x391240", Offset = "0x391240", VA = "0x391240")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0x3912FC", Offset = "0x3912FC", VA = "0x3912FC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x39135C", Offset = "0x39135C", VA = "0x39135C")]
	public void GetMaxVolumeNumber()
	{
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0x391448", Offset = "0x391448", VA = "0x391448")]
	public void GetCurrentVolumeNumber()
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x391534", Offset = "0x391534", VA = "0x391534")]
	public void VolumeUp()
	{
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0x3915D8", Offset = "0x3915D8", VA = "0x3915D8")]
	public void VolumeDown()
	{
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0x39167C", Offset = "0x39167C", VA = "0x39167C")]
	public void SetVolumeNum()
	{
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0x39180C", Offset = "0x39180C", VA = "0x39180C")]
	public void SetBrightness()
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x39199C", Offset = "0x39199C", VA = "0x39199C")]
	public void GetCurrentBrightness()
	{
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x391A88", Offset = "0x391A88", VA = "0x391A88")]
	public bool setAudio(string s)
	{
		return default(bool);
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x391B38", Offset = "0x391B38", VA = "0x391B38")]
	public bool setBattery(string s)
	{
		return default(bool);
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x3912B0", Offset = "0x3912B0", VA = "0x3912B0")]
	private bool InitBatteryVolClass()
	{
		return default(bool);
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0x3912BC", Offset = "0x3912BC", VA = "0x3912BC")]
	private bool StartBatteryReceiver(string startreceivre)
	{
		return default(bool);
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0x391350", Offset = "0x391350", VA = "0x391350")]
	private bool StopBatteryReceiver()
	{
		return default(bool);
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0x3912DC", Offset = "0x3912DC", VA = "0x3912DC")]
	private bool StartAudioReceiver(string startreceivre)
	{
		return default(bool);
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0x391344", Offset = "0x391344", VA = "0x391344")]
	private bool StopAudioReceiver()
	{
		return default(bool);
	}
}
namespace SoftMasking
{
	[Token(Token = "0x20000FD")]
	internal struct ClearListAtExit<T> : IDisposable
	{
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> _list;

		[Token(Token = "0x6000784")]
		public ClearListAtExit(List<T> list)
		{
		}

		[Token(Token = "0x6000785")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public interface ISoftMask
	{
		[Token(Token = "0x17000077")]
		bool isAlive
		{
			[Token(Token = "0x6000786")]
			get;
		}

		[Token(Token = "0x17000078")]
		bool isMaskingEnabled
		{
			[Token(Token = "0x6000787")]
			get;
		}

		[Token(Token = "0x6000788")]
		Material GetReplacement(Material original);

		[Token(Token = "0x6000789")]
		void ReleaseReplacement(Material replacement);

		[Token(Token = "0x600078A")]
		void UpdateTransformChildren(Transform transform);
	}
}
namespace SoftMasking.Extensions
{
	[Token(Token = "0x20000FF")]
	public static class MaterialOps
	{
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x39209C", Offset = "0x39209C", VA = "0x39209C")]
		public static bool SupportsSoftMask(this Material mat)
		{
			return default(bool);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x392110", Offset = "0x392110", VA = "0x392110")]
		public static bool HasDefaultUIShader(this Material mat)
		{
			return default(bool);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x3921E4", Offset = "0x3921E4", VA = "0x3921E4")]
		public static bool HasDefaultETC1UIShader(this Material mat)
		{
			return default(bool);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x3922B8", Offset = "0x3922B8", VA = "0x3922B8")]
		public static void EnableKeyword(this Material mat, string keyword, bool enabled)
		{
		}
	}
}
namespace SoftMasking
{
	[Token(Token = "0x2000100")]
	internal class MaterialReplacements
	{
		[Token(Token = "0x2000101")]
		private class MaterialOverride
		{
			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int _useCount;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163670", Offset = "0x163670")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x163670", Offset = "0x163670")]
			private Material <original>k__BackingField;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1636A4", Offset = "0x1636A4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1636A4", Offset = "0x1636A4")]
			private Material <replacement>k__BackingField;

			[Token(Token = "0x17000079")]
			public Material original
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0x392878", Offset = "0x392878", VA = "0x392878")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1636D8", Offset = "0x1636D8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000796")]
				[Address(RVA = "0x392D00", Offset = "0x392D00", VA = "0x392D00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1636E8", Offset = "0x1636E8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public Material replacement
			{
				[Token(Token = "0x6000797")]
				[Address(RVA = "0x392A68", Offset = "0x392A68", VA = "0x392A68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1636F8", Offset = "0x1636F8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000798")]
				[Address(RVA = "0x392D08", Offset = "0x392D08", VA = "0x392D08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163708", Offset = "0x163708")]
				private set
				{
				}
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x392894", Offset = "0x392894", VA = "0x392894")]
			public MaterialOverride(Material original, Material replacement)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x392880", Offset = "0x392880", VA = "0x392880")]
			public Material Get()
			{
				return null;
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x392A70", Offset = "0x392A70", VA = "0x392A70")]
			public bool Release()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly IMaterialReplacer _replacer;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly Action<Material> _applyParameters;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<MaterialOverride> _overrides;

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x3924E0", Offset = "0x3924E0", VA = "0x3924E0")]
		public MaterialReplacements(IMaterialReplacer replacer, Action<Material> applyParameters)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x39257C", Offset = "0x39257C", VA = "0x39257C")]
		public Material Get(Material original)
		{
			return null;
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x3928C4", Offset = "0x3928C4", VA = "0x3928C4")]
		public void Release(Material replacement)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x392A88", Offset = "0x392A88", VA = "0x392A88")]
		public void ApplyAll()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x392BD4", Offset = "0x392BD4", VA = "0x392BD4")]
		public void DestroyAllAndClear()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x163718", Offset = "0x163718")]
	public class GlobalMaterialReplacerAttribute : Attribute
	{
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x3922FC", Offset = "0x3922FC", VA = "0x3922FC")]
		public GlobalMaterialReplacerAttribute()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public interface IMaterialReplacer
	{
		[Token(Token = "0x1700007B")]
		int order
		{
			[Token(Token = "0x600079C")]
			get;
		}

		[Token(Token = "0x600079D")]
		Material Replace(Material material);
	}
	[Token(Token = "0x2000104")]
	public static class MaterialReplacer
	{
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<IMaterialReplacer> _globalReplacers;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16373C", Offset = "0x16373C")]
		private static Func<Assembly, IEnumerable<Type>> <>f__mg$cache0;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16374C", Offset = "0x16374C")]
		private static Func<Type, bool> <>f__mg$cache1;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16375C", Offset = "0x16375C")]
		private static Func<Type, IMaterialReplacer> <>f__mg$cache2;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16376C", Offset = "0x16376C")]
		private static Func<IMaterialReplacer, bool> <>f__am$cache0;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16377C", Offset = "0x16377C")]
		private static Func<Type, bool> <>f__am$cache1;

		[Token(Token = "0x1700007C")]
		public static IEnumerable<IMaterialReplacer> globalReplacers
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x392D10", Offset = "0x392D10", VA = "0x392D10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x392DBC", Offset = "0x392DBC", VA = "0x392DBC")]
		private static IEnumerable<IMaterialReplacer> CollectGlobalReplacers()
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x3930DC", Offset = "0x3930DC", VA = "0x3930DC")]
		private static bool IsMaterialReplacerType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x393270", Offset = "0x393270", VA = "0x393270")]
		private static IMaterialReplacer TryCreateInstance(Type t)
		{
			return null;
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x393514", Offset = "0x393514", VA = "0x393514")]
		private static IEnumerable<Type> GetTypesSafe(this Assembly asm)
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x3936C8", Offset = "0x3936C8", VA = "0x3936C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x16379C", Offset = "0x16379C")]
		private static bool <CollectGlobalReplacers>m__0(IMaterialReplacer t)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x3936D8", Offset = "0x3936D8", VA = "0x3936D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1637AC", Offset = "0x1637AC")]
		private static bool <GetTypesSafe>m__1(Type t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000105")]
	public class MaterialReplacerChain : IMaterialReplacer
	{
		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly List<IMaterialReplacer> _replacers;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1637BC", Offset = "0x1637BC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x1637BC", Offset = "0x1637BC")]
		private int <order>k__BackingField;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1637F0", Offset = "0x1637F0")]
		private static Comparison<IMaterialReplacer> <>f__am$cache0;

		[Token(Token = "0x1700007D")]
		public int order
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x393958", Offset = "0x393958", VA = "0x393958", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163800", Offset = "0x163800")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x393960", Offset = "0x393960", VA = "0x393960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163810", Offset = "0x163810")]
			private set
			{
			}
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x3936E8", Offset = "0x3936E8", VA = "0x3936E8")]
		public MaterialReplacerChain(IEnumerable<IMaterialReplacer> replacers, IMaterialReplacer yetAnother)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x393968", Offset = "0x393968", VA = "0x393968", Slot = "5")]
		public Material Replace(Material material)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x39379C", Offset = "0x39379C", VA = "0x39379C")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x393B1C", Offset = "0x393B1C", VA = "0x393B1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163820", Offset = "0x163820")]
		private static int <Initialize>m__0(IMaterialReplacer a, IMaterialReplacer b)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000106")]
	public static class MaskChannel
	{
		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Color alpha;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Color red;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Color green;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Color blue;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Color gray;
	}
	[Token(Token = "0x2000107")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x163830", Offset = "0x163830")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x163830", Offset = "0x163830")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x163830", Offset = "0x163830")]
	public class SoftMask : UIBehaviour, ISoftMask, ICanvasRaycastFilter
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public enum MaskSource
		{
			[Token(Token = "0x4000546")]
			Graphic,
			[Token(Token = "0x4000547")]
			Sprite,
			[Token(Token = "0x4000548")]
			Texture
		}

		[Serializable]
		[Token(Token = "0x2000109")]
		public enum BorderMode
		{
			[Token(Token = "0x400054A")]
			Simple,
			[Token(Token = "0x400054B")]
			Sliced,
			[Token(Token = "0x400054C")]
			Tiled
		}

		[Serializable]
		[Token(Token = "0x200010A")]
		[Flags]
		public enum Errors
		{
			[Token(Token = "0x400054E")]
			NoError = 0,
			[Token(Token = "0x400054F")]
			UnsupportedShaders = 1,
			[Token(Token = "0x4000550")]
			NestedMasks = 2,
			[Token(Token = "0x4000551")]
			TightPackedSprite = 4,
			[Token(Token = "0x4000552")]
			AlphaSplitSprite = 8,
			[Token(Token = "0x4000553")]
			UnsupportedImageType = 0x10,
			[Token(Token = "0x4000554")]
			UnreadableTexture = 0x20
		}

		[Token(Token = "0x200010B")]
		private struct SourceParameters
		{
			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Image image;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Sprite sprite;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BorderMode spriteBorderMode;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Texture2D texture;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rect textureUVRect;
		}

		[Token(Token = "0x200010C")]
		private class MaterialReplacerImpl : IMaterialReplacer
		{
			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly SoftMask _owner;

			[Token(Token = "0x1700008E")]
			public int order
			{
				[Token(Token = "0x60007F8")]
				[Address(RVA = "0x399F88", Offset = "0x399F88", VA = "0x399F88", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x393E58", Offset = "0x393E58", VA = "0x393E58")]
			public MaterialReplacerImpl(SoftMask owner)
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x399F90", Offset = "0x399F90", VA = "0x399F90", Slot = "5")]
			public Material Replace(Material original)
			{
				return null;
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x39A0BC", Offset = "0x39A0BC", VA = "0x39A0BC")]
			private static Material Replace(Material original, Shader defaultReplacementShader)
			{
				return null;
			}
		}

		[Token(Token = "0x200010D")]
		private static class Mathr
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x397978", Offset = "0x397978", VA = "0x397978")]
			public static Vector4 ToVector(Rect r)
			{
				return default(Vector4);
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x397AEC", Offset = "0x397AEC", VA = "0x397AEC")]
			public static Vector4 Div(Vector4 v, Vector2 s)
			{
				return default(Vector4);
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x3983F8", Offset = "0x3983F8", VA = "0x3983F8")]
			public static Vector2 Div(Vector2 v, Vector2 s)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x397B94", Offset = "0x397B94", VA = "0x397B94")]
			public static Vector4 Mul(Vector4 v, Vector2 s)
			{
				return default(Vector4);
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x397B54", Offset = "0x397B54", VA = "0x397B54")]
			public static Vector2 Size(Vector4 r)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x397A14", Offset = "0x397A14", VA = "0x397A14")]
			public static Vector4 Move(Vector4 v, Vector2 o)
			{
				return default(Vector4);
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x397A7C", Offset = "0x397A7C", VA = "0x397A7C")]
			public static Vector4 BorderOf(Vector4 outer, Vector4 inner)
			{
				return default(Vector4);
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x397BFC", Offset = "0x397BFC", VA = "0x397BFC")]
			public static Vector4 ApplyBorder(Vector4 v, Vector4 b)
			{
				return default(Vector4);
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x39A220", Offset = "0x39A220", VA = "0x39A220")]
			public static Vector2 Min(Vector4 r)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x39A248", Offset = "0x39A248", VA = "0x39A248")]
			public static Vector2 Max(Vector4 r)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x3998D4", Offset = "0x3998D4", VA = "0x3998D4")]
			public static Vector2 Remap(Vector2 c, Vector4 from, Vector4 to)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x394DE0", Offset = "0x394DE0", VA = "0x394DE0")]
			public static bool Inside(Vector2 v, Vector4 r)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010E")]
		private struct MaterialParameters
		{
			[Token(Token = "0x200010F")]
			private static class Ids
			{
				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly int SoftMask;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public static readonly int SoftMask_Rect;

				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static readonly int SoftMask_UVRect;

				[Token(Token = "0x4000567")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public static readonly int SoftMask_ChannelWeights;

				[Token(Token = "0x4000568")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public static readonly int SoftMask_WorldToMask;

				[Token(Token = "0x4000569")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public static readonly int SoftMask_BorderRect;

				[Token(Token = "0x400056A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public static readonly int SoftMask_UVBorderRect;

				[Token(Token = "0x400056B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public static readonly int SoftMask_TileRepeat;
			}

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector4 maskRect;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector4 maskBorder;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector4 maskRectUV;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector4 maskBorderUV;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector2 tileRepeat;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Color maskChannelWeights;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Matrix4x4 worldToMask;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Texture2D texture;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public BorderMode borderMode;

			[Token(Token = "0x1700008F")]
			public Texture2D activeTexture
			{
				[Token(Token = "0x6000807")]
				[Address(RVA = "0x399598", Offset = "0x399598", VA = "0x399598")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x39973C", Offset = "0x39973C", VA = "0x39973C")]
			public bool SampleMask(Vector2 localPos, out float mask)
			{
				return default(bool);
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x399758", Offset = "0x399758", VA = "0x399758")]
			public void Apply(Material mat)
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x3998B8", Offset = "0x3998B8", VA = "0x3998B8")]
			private Vector2 XY2UV(Vector2 localPos)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x399AF0", Offset = "0x399AF0", VA = "0x399AF0")]
			private Vector2 MapSimple(Vector2 localPos)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x399B98", Offset = "0x399B98", VA = "0x399B98")]
			private Vector2 MapBorder(Vector2 localPos, bool repeat)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x399D44", Offset = "0x399D44", VA = "0x399D44")]
			private float Inset(float v, float x1, float x2, float u1, float u2, float repeat = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x399D78", Offset = "0x399D78", VA = "0x399D78")]
			private float Inset(float v, float x1, float x2, float x3, float x4, float u1, float u2, float u3, float u4, float repeat = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x399DCC", Offset = "0x399DCC", VA = "0x399DCC")]
			private float Frac(float v)
			{
				return default(float);
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x399DD0", Offset = "0x399DD0", VA = "0x399DD0")]
			private float MaskValue(Color mask)
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000110")]
		private struct Diagnostics
		{
			[Token(Token = "0x2000179")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163A1C", Offset = "0x163A1C")]
			private sealed class <PollErrors>c__AnonStorey0
			{
				[Token(Token = "0x4000737")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal SoftMask softMask;

				[Token(Token = "0x60009D3")]
				[Address(RVA = "0x398BEC", Offset = "0x398BEC", VA = "0x398BEC")]
				public <PollErrors>c__AnonStorey0()
				{
				}

				[Token(Token = "0x60009D4")]
				[Address(RVA = "0x3994CC", Offset = "0x3994CC", VA = "0x3994CC")]
				internal bool <>m__0(SoftMaskable m)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x200017A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163A2C", Offset = "0x163A2C")]
			private sealed class <ThereAreNestedMasks>c__AnonStorey1
			{
				[Token(Token = "0x4000738")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal SoftMask softMask;

				[Token(Token = "0x60009D5")]
				[Address(RVA = "0x3991AC", Offset = "0x3991AC", VA = "0x3991AC")]
				public <ThereAreNestedMasks>c__AnonStorey1()
				{
				}

				[Token(Token = "0x60009D6")]
				[Address(RVA = "0x39952C", Offset = "0x39952C", VA = "0x39952C")]
				internal bool <>m__0(SoftMask x)
				{
					return default(bool);
				}

				[Token(Token = "0x60009D7")]
				[Address(RVA = "0x399538", Offset = "0x399538", VA = "0x399538")]
				internal bool <>m__1(SoftMask x)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private SoftMask _softMask;

			[Token(Token = "0x17000090")]
			private Image image
			{
				[Token(Token = "0x6000815")]
				[Address(RVA = "0x399160", Offset = "0x399160", VA = "0x399160")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private Sprite sprite
			{
				[Token(Token = "0x6000816")]
				[Address(RVA = "0x399168", Offset = "0x399168", VA = "0x399168")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private Texture2D texture
			{
				[Token(Token = "0x6000817")]
				[Address(RVA = "0x3991A4", Offset = "0x3991A4", VA = "0x3991A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x398BE4", Offset = "0x398BE4", VA = "0x398BE4")]
			public Diagnostics(SoftMask softMask)
			{
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x399124", Offset = "0x399124", VA = "0x399124")]
			public Errors PollErrors()
			{
				return default(Errors);
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x39768C", Offset = "0x39768C", VA = "0x39768C")]
			public static Errors CheckSprite(Sprite sprite)
			{
				return default(Errors);
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x3991B4", Offset = "0x3991B4", VA = "0x3991B4")]
			private bool ThereAreNestedMasks()
			{
				return default(bool);
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x3991CC", Offset = "0x3991CC", VA = "0x3991CC")]
			private Errors CheckImage()
			{
				return default(Errors);
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x3992DC", Offset = "0x3992DC", VA = "0x3992DC")]
			private Errors CheckTexture()
			{
				return default(Errors);
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x3992E4", Offset = "0x3992E4", VA = "0x3992E4")]
			private static bool AreCompeting(SoftMask softMask, SoftMask other)
			{
				return default(bool);
			}

			[Token(Token = "0x600081C")]
			private static T SelectChild<T>(T first, T second) where T : Component
			{
				return null;
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x3991D4", Offset = "0x3991D4", VA = "0x3991D4")]
			private static bool IsReadable(Texture2D texture)
			{
				return default(bool);
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x3991BC", Offset = "0x3991BC", VA = "0x3991BC")]
			private static bool IsSupportedImageType(Image.Type type)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Shader _defaultShader;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Shader _defaultETC1Shader;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MaskSource _source;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _separateMask;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Sprite _sprite;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BorderMode _spriteBorderMode;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Texture2D _texture;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rect _textureUVRect;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _channelWeights;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _raycastThreshold;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private MaterialReplacements _materials;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MaterialParameters _parameters;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Sprite _lastUsedSprite;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Rect _lastMaskRect;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool _maskingWasEnabled;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		private bool _destroyed;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		private bool _dirty;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RectTransform _maskTransform;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Graphic _graphic;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Canvas _canvas;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Rect DefaultUVRect;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<SoftMask> s_masks;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly List<SoftMaskable> s_maskables;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1639BC", Offset = "0x1639BC")]
		private static Action<SoftMaskable> <>f__am$cache0;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1639CC", Offset = "0x1639CC")]
		private static Action<SoftMaskable> <>f__am$cache1;

		[Token(Token = "0x1700007E")]
		private bool SoftMasking.ISoftMask.isAlive
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x395E64", Offset = "0x395E64", VA = "0x395E64", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		public Shader defaultShader
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x393E78", Offset = "0x393E78", VA = "0x393E78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x393E80", Offset = "0x393E80", VA = "0x393E80")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public Shader defaultETC1Shader
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x393F78", Offset = "0x393F78", VA = "0x393F78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x393F80", Offset = "0x393F80", VA = "0x393F80")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public MaskSource source
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x393FA4", Offset = "0x393FA4", VA = "0x393FA4")]
			get
			{
				return default(MaskSource);
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x393FAC", Offset = "0x393FAC", VA = "0x393FAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public RectTransform separateMask
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x394028", Offset = "0x394028", VA = "0x394028")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x394030", Offset = "0x394030", VA = "0x394030")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public Sprite sprite
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x3940FC", Offset = "0x3940FC", VA = "0x3940FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x394104", Offset = "0x394104", VA = "0x394104")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public BorderMode spriteBorderMode
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x3941C4", Offset = "0x3941C4", VA = "0x3941C4")]
			get
			{
				return default(BorderMode);
			}
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x3941CC", Offset = "0x3941CC", VA = "0x3941CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public Texture2D texture
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x394248", Offset = "0x394248", VA = "0x394248")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x394250", Offset = "0x394250", VA = "0x394250")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public Rect textureUVRect
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x394310", Offset = "0x394310", VA = "0x394310")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x394324", Offset = "0x394324", VA = "0x394324")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public Color channelWeights
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x3943EC", Offset = "0x3943EC", VA = "0x3943EC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x394400", Offset = "0x394400", VA = "0x394400")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public float raycastThreshold
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x3944C8", Offset = "0x3944C8", VA = "0x3944C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x3944D0", Offset = "0x3944D0", VA = "0x3944D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public bool isUsingRaycastFiltering
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x3944D8", Offset = "0x3944D8", VA = "0x3944D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public bool isMaskingEnabled
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x3944F0", Offset = "0x3944F0", VA = "0x3944F0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		private RectTransform maskTransform
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x394BF8", Offset = "0x394BF8", VA = "0x394BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		private Canvas canvas
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x3945A4", Offset = "0x3945A4", VA = "0x3945A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		private bool isBasedOnGraphic
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x395E50", Offset = "0x395E50", VA = "0x395E50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x393C98", Offset = "0x393C98", VA = "0x393C98")]
		public SoftMask()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x394648", Offset = "0x394648", VA = "0x394648")]
		public Errors PollErrors()
		{
			return default(Errors);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x3948DC", Offset = "0x3948DC", VA = "0x3948DC", Slot = "22")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x395044", Offset = "0x395044", VA = "0x395044", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x395144", Offset = "0x395144", VA = "0x395144", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x395930", Offset = "0x395930", VA = "0x395930", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x395B68", Offset = "0x395B68", VA = "0x395B68", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x395B90", Offset = "0x395B90", VA = "0x395B90", Slot = "23")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x395C7C", Offset = "0x395C7C", VA = "0x395C7C", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x395C9C", Offset = "0x395C9C", VA = "0x395C9C", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x395CBC", Offset = "0x395CBC", VA = "0x395CBC", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x395CE4", Offset = "0x395CE4", VA = "0x395CE4", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x395D14", Offset = "0x395D14", VA = "0x395D14")]
		private void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x39519C", Offset = "0x39519C", VA = "0x39519C")]
		private void SubscribeOnWillRenderCanvases()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x395AB0", Offset = "0x395AB0", VA = "0x395AB0")]
		private void UnsubscribeFromWillRenderCanvases()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x395D30", Offset = "0x395D30", VA = "0x395D30")]
		private void OnWillRenderCanvases()
		{
		}

		[Token(Token = "0x60007D2")]
		private static T Touch<T>(T obj)
		{
			return (T)null;
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x395F0C", Offset = "0x395F0C", VA = "0x395F0C", Slot = "19")]
		private Material SoftMasking.ISoftMask.GetReplacement(Material original)
		{
			return null;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x395F38", Offset = "0x395F38", VA = "0x395F38", Slot = "20")]
		private void SoftMasking.ISoftMask.ReleaseReplacement(Material replacement)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x395F64", Offset = "0x395F64", VA = "0x395F64", Slot = "21")]
		private void SoftMasking.ISoftMask.UpdateTransformChildren(Transform transform)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x395F68", Offset = "0x395F68", VA = "0x395F68")]
		private void OnGraphicDirty()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x395510", Offset = "0x395510", VA = "0x395510")]
		private void FindGraphic()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x395D54", Offset = "0x395D54", VA = "0x395D54")]
		private Canvas NearestEnabledCanvas()
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x3956DC", Offset = "0x3956DC", VA = "0x3956DC")]
		private void UpdateMaskParameters()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x3952B4", Offset = "0x3952B4", VA = "0x3952B4")]
		private void SpawnMaskablesInChildren(Transform root)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x3960C4", Offset = "0x3960C4", VA = "0x3960C4")]
		private void InvalidateChildren()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x3957B0", Offset = "0x3957B0", VA = "0x3957B0")]
		private void NotifyChildrenThatMaskMightChanged()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x396244", Offset = "0x396244", VA = "0x396244")]
		private void ForEachChildMaskable(Action<SoftMaskable> f)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x395B44", Offset = "0x395B44", VA = "0x395B44")]
		private void DestroyMaterials()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x3965B0", Offset = "0x3965B0", VA = "0x3965B0")]
		private SourceParameters DeduceSourceParameters()
		{
			return default(SourceParameters);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x39696C", Offset = "0x39696C", VA = "0x39696C")]
		private BorderMode ToBorderMode(Image.Type imageType)
		{
			return default(BorderMode);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x395F7C", Offset = "0x395F7C", VA = "0x395F7C")]
		private void CalculateMaskParameters()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x396AF0", Offset = "0x396AF0", VA = "0x396AF0")]
		private void CalculateSpriteBased(Sprite sprite, BorderMode borderMode)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x397DB8", Offset = "0x397DB8", VA = "0x397DB8")]
		private static Vector4 AdjustBorders(Vector4 border, Vector4 rect)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x3974C8", Offset = "0x3974C8", VA = "0x3974C8")]
		private void CalculateTextureBased(Texture2D texture, Rect uvRect)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x3975D8", Offset = "0x3975D8", VA = "0x3975D8")]
		private void CalculateSolidFill()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x3978C4", Offset = "0x3978C4", VA = "0x3978C4")]
		private void FillCommonParameters()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x397C6C", Offset = "0x397C6C", VA = "0x397C6C")]
		private float GraphicToCanvasScale(Sprite sprite)
		{
			return default(float);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x398148", Offset = "0x398148", VA = "0x398148")]
		private Matrix4x4 WorldToMask()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x394D14", Offset = "0x394D14", VA = "0x394D14")]
		private Vector4 LocalMaskRect(Vector4 border)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x397F1C", Offset = "0x397F1C", VA = "0x397F1C")]
		private Vector2 MaskRepeat(Sprite sprite, Vector4 centralPart)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x395064", Offset = "0x395064", VA = "0x395064")]
		private void WarnIfDefaultShaderIsNotSet()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x3977CC", Offset = "0x3977CC", VA = "0x3977CC")]
		private void WarnSpriteErrors(Errors errors)
		{
		}

		[Token(Token = "0x60007F1")]
		private void Set<T>(ref T field, T value)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x393EA4", Offset = "0x393EA4", VA = "0x393EA4")]
		private void SetShader(ref Shader field, Shader value, bool warnIfNotSet = true)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x39855C", Offset = "0x39855C", VA = "0x39855C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1639DC", Offset = "0x1639DC")]
		private void <SoftMask>m__0(Material m)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x398A4C", Offset = "0x398A4C", VA = "0x398A4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1639EC", Offset = "0x1639EC")]
		private static void <InvalidateChildren>m__1(SoftMaskable x)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x398B38", Offset = "0x398B38", VA = "0x398B38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1639FC", Offset = "0x1639FC")]
		private static void <NotifyChildrenThatMaskMightChanged>m__2(SoftMaskable x)
		{
		}
	}
	[Token(Token = "0x2000111")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x163A3C", Offset = "0x163A3C")]
	public class SoftMaskable : UIBehaviour, IMaterialModifier
	{
		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private ISoftMask _mask;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Graphic _graphic;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Material _replacement;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _affectedByMask;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _destroyed;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163A94", Offset = "0x163A94")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x163A94", Offset = "0x163A94")]
		private bool <shaderIsNotSupported>k__BackingField;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ISoftMask> s_softMasks;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static List<Canvas> s_canvases;

		[Token(Token = "0x17000093")]
		public bool shaderIsNotSupported
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x399524", Offset = "0x399524", VA = "0x399524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163AC8", Offset = "0x163AC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x39A2CC", Offset = "0x39A2CC", VA = "0x39A2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163AD8", Offset = "0x163AD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool isMaskingEnabled
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x39A2D4", Offset = "0x39A2D4", VA = "0x39A2D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public ISoftMask mask
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x39951C", Offset = "0x39951C", VA = "0x39951C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x39A450", Offset = "0x39A450", VA = "0x39A450")]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		private Graphic graphic
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x39AA0C", Offset = "0x39AA0C", VA = "0x39AA0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		private Material replacement
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x39A864", Offset = "0x39A864", VA = "0x39A864")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x39A564", Offset = "0x39A564", VA = "0x39A564")]
			set
			{
			}
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x39A2C4", Offset = "0x39A2C4", VA = "0x39A2C4")]
		public SoftMaskable()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x39A6DC", Offset = "0x39A6DC", VA = "0x39A6DC", Slot = "17")]
		public Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x398A70", Offset = "0x398A70", VA = "0x398A70")]
		public void Invalidate()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x398B6C", Offset = "0x398B6C", VA = "0x398B6C")]
		public void MaskMightChanged()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x39AC44", Offset = "0x39AC44", VA = "0x39AC44", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x39AC6C", Offset = "0x39AC6C", VA = "0x39AC6C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x39AD84", Offset = "0x39AD84", VA = "0x39AD84", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x39ADA8", Offset = "0x39ADA8", VA = "0x39ADA8", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x39ADC8", Offset = "0x39ADC8", VA = "0x39ADC8", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x39ADE8", Offset = "0x39ADE8", VA = "0x39ADE8", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x39AE08", Offset = "0x39AE08", VA = "0x39AE08")]
		private void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x39AC9C", Offset = "0x39AC9C", VA = "0x39AC9C")]
		private void RequestChildTransformUpdate()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x39AAC0", Offset = "0x39AAC0", VA = "0x39AAC0")]
		private bool FindMaskOrDie()
		{
			return default(bool);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x39AE0C", Offset = "0x39AE0C", VA = "0x39AE0C")]
		private static ISoftMask NearestMask(Transform transform, out bool processedByThisMask, bool enabledOnly = true)
		{
			return null;
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x39AFB8", Offset = "0x39AFB8", VA = "0x39AFB8")]
		private static ISoftMask GetISoftMask(Transform current, bool shouldBeEnabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x39B188", Offset = "0x39B188", VA = "0x39B188")]
		private static bool IsOverridingSortingCanvas(Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		private static T GetComponent<T>(Component component, List<T> cachedList) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x39A86C", Offset = "0x39A86C", VA = "0x39A86C")]
		private void SetShaderNotSupported(Material material)
		{
		}
	}
}
namespace SoftMasking.TextMeshPro
{
	[Token(Token = "0x2000112")]
	[GlobalMaterialReplacer]
	public class MaterialReplacer : IMaterialReplacer
	{
		[Token(Token = "0x17000098")]
		public int order
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x39B380", Offset = "0x39B380", VA = "0x39B380", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x39B378", Offset = "0x39B378", VA = "0x39B378")]
		public MaterialReplacer()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x39B388", Offset = "0x39B388", VA = "0x39B388", Slot = "5")]
		public Material Replace(Material material)
		{
			return null;
		}
	}
}
[Token(Token = "0x2000113")]
public abstract class EffectBase : MonoBehaviour
{
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x35FC10", Offset = "0x35FC10", VA = "0x35FC10")]
	protected EffectBase()
	{
	}

	[Token(Token = "0x600083E")]
	public void EnsureArray<T>(ref T[] array, int size, [Optional] T initialValue)
	{
	}

	[Token(Token = "0x600083F")]
	public void EnsureArray<T>(ref T[,] array, int size0, int size1, [Optional] T defaultValue)
	{
	}

	[Token(Token = "0x6000840")]
	[Address(RVA = "0x35FC18", Offset = "0x35FC18", VA = "0x35FC18")]
	public void EnsureMaterial(ref Material material, Shader shader)
	{
	}

	[Token(Token = "0x6000841")]
	[Address(RVA = "0x35FE50", Offset = "0x35FE50", VA = "0x35FE50")]
	public void EnsureDepthTexture(Camera camera)
	{
	}

	[Token(Token = "0x6000842")]
	[Address(RVA = "0x35FEC4", Offset = "0x35FEC4", VA = "0x35FEC4")]
	public void EnsureKeyword(Material material, string name, bool enabled)
	{
	}

	[Token(Token = "0x6000843")]
	[Address(RVA = "0x35FF30", Offset = "0x35FF30", VA = "0x35FF30")]
	public bool EnsureRenderTarget(ref RenderTexture rt, int width, int height, RenderTextureFormat format, FilterMode filterMode, int depthBits = 0, int antiAliasing = 1)
	{
		return default(bool);
	}

	[Token(Token = "0x6000844")]
	[Address(RVA = "0x360180", Offset = "0x360180", VA = "0x360180")]
	public void ReleaseRenderTarget(ref RenderTexture rt)
	{
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0x360230", Offset = "0x360230", VA = "0x360230")]
	public void DrawFullscreenQuad()
	{
	}
}
[Token(Token = "0x2000114")]
public static class Vector2Extension
{
	[Token(Token = "0x6000846")]
	[Address(RVA = "0xACEA04", Offset = "0xACEA04", VA = "0xACEA04")]
	public static float SignedAngle(this Vector2 v1, Vector2 v2)
	{
		return default(float);
	}

	[Token(Token = "0x6000847")]
	[Address(RVA = "0xACEBD0", Offset = "0xACEBD0", VA = "0xACEBD0")]
	public static Vector2 Rotate(this Vector2 v, float theta)
	{
		return default(Vector2);
	}
}
[Token(Token = "0x2000115")]
public static class Vector3Extension
{
	[Token(Token = "0x6000848")]
	[Address(RVA = "0xACECB8", Offset = "0xACECB8", VA = "0xACECB8")]
	public static Vector3 WithX(this Vector3 v, float x)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000849")]
	[Address(RVA = "0xACECF4", Offset = "0xACECF4", VA = "0xACECF4")]
	public static Vector3 WithY(this Vector3 v, float y)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600084A")]
	[Address(RVA = "0xACED30", Offset = "0xACED30", VA = "0xACED30")]
	public static Vector3 WithZ(this Vector3 v, float z)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000116")]
public static class Matrix4x4Extension
{
	[Token(Token = "0x600084B")]
	[Address(RVA = "0x35449C", Offset = "0x35449C", VA = "0x35449C")]
	public static Matrix4x4 GetPerspectiveProjection(float left, float right, float bottom, float top, float near, float far)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0x354264", Offset = "0x354264", VA = "0x354264")]
	public static Matrix4x4 GetOrthographicProjection(float left, float right, float bottom, float top, float near, float far)
	{
		return default(Matrix4x4);
	}
}
[Token(Token = "0x2000117")]
public static class CameraExtension
{
	[Token(Token = "0x600084D")]
	[Address(RVA = "0x353A3C", Offset = "0x353A3C", VA = "0x353A3C")]
	public static Vector4 GetProjectionExtents(this Camera camera)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600084E")]
	[Address(RVA = "0x353A60", Offset = "0x353A60", VA = "0x353A60")]
	public static Vector4 GetProjectionExtents(this Camera camera, float texelOffsetX, float texelOffsetY)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0x353CBC", Offset = "0x353CBC", VA = "0x353CBC")]
	public static Vector4 GetProjectionExtents(this Camera camera, Camera.StereoscopicEye eye)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000850")]
	[Address(RVA = "0x353CE0", Offset = "0x353CE0", VA = "0x353CE0")]
	public static Vector4 GetProjectionExtents(this Camera camera, Camera.StereoscopicEye eye, float texelOffsetX, float texelOffsetY)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000851")]
	[Address(RVA = "0x354060", Offset = "0x354060", VA = "0x354060")]
	public static Matrix4x4 GetProjectionMatrix(this Camera camera)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000852")]
	[Address(RVA = "0x354084", Offset = "0x354084", VA = "0x354084")]
	public static Matrix4x4 GetProjectionMatrix(this Camera camera, float texelOffsetX, float texelOffsetY)
	{
		return default(Matrix4x4);
	}
}
[Token(Token = "0x2000118")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x163BD8", Offset = "0x163BD8")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x163BD8", Offset = "0x163BD8")]
public class FrustumJitter : MonoBehaviour
{
	[Token(Token = "0x2000119")]
	public enum Pattern
	{
		[Token(Token = "0x400058D")]
		Still,
		[Token(Token = "0x400058E")]
		Uniform2,
		[Token(Token = "0x400058F")]
		Uniform4,
		[Token(Token = "0x4000590")]
		Uniform4_Helix,
		[Token(Token = "0x4000591")]
		Uniform4_DoubleHelix,
		[Token(Token = "0x4000592")]
		SkewButterfly,
		[Token(Token = "0x4000593")]
		Rotated4,
		[Token(Token = "0x4000594")]
		Rotated4_Helix,
		[Token(Token = "0x4000595")]
		Rotated4_Helix2,
		[Token(Token = "0x4000596")]
		Poisson10,
		[Token(Token = "0x4000597")]
		Pentagram,
		[Token(Token = "0x4000598")]
		Halton_2_3_X8,
		[Token(Token = "0x4000599")]
		Halton_2_3_X16,
		[Token(Token = "0x400059A")]
		Halton_2_3_X32,
		[Token(Token = "0x400059B")]
		Halton_2_3_X256,
		[Token(Token = "0x400059C")]
		MotionPerp2
	}

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float[] points_Still;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static float[] points_Uniform2;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static float[] points_Uniform4;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static float[] points_Uniform4_Helix;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static float[] points_Uniform4_DoubleHelix;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static float[] points_SkewButterfly;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float[] points_Rotated4;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static float[] points_Rotated4_Helix;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static float[] points_Rotated4_Helix2;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static float[] points_Poisson10;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static float[] points_Pentagram;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static float[] points_Halton_2_3_x8;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static float[] points_Halton_2_3_x16;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static float[] points_Halton_2_3_x32;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static float[] points_Halton_2_3_x256;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static float[] points_MotionPerp2;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Camera _camera;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Vector3 focalMotionPos;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 focalMotionDir;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Pattern pattern;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float patternScale;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 activeSample;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int activeIndex;

	[Token(Token = "0x6000853")]
	[Address(RVA = "0x36083C", Offset = "0x36083C", VA = "0x36083C")]
	static FrustumJitter()
	{
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0x3611DC", Offset = "0x3611DC", VA = "0x3611DC")]
	public FrustumJitter()
	{
	}

	[Token(Token = "0x6000855")]
	[Address(RVA = "0x360F2C", Offset = "0x360F2C", VA = "0x360F2C")]
	private static void TransformPattern(float[] seq, float theta, float scale)
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0x361308", Offset = "0x361308", VA = "0x361308")]
	private static float HaltonSeq(int prime, int index = 1)
	{
		return default(float);
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0x3610AC", Offset = "0x3610AC", VA = "0x3610AC")]
	private static void InitializeHalton_2_3(float[] seq)
	{
	}

	[Token(Token = "0x6000858")]
	[Address(RVA = "0x361400", Offset = "0x361400", VA = "0x361400")]
	private static float[] AccessPointData(Pattern pattern)
	{
		return null;
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0x3619AC", Offset = "0x3619AC", VA = "0x3619AC")]
	public static int AccessLength(Pattern pattern)
	{
		return default(int);
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0x361A48", Offset = "0x361A48", VA = "0x361A48")]
	public Vector2 Sample(Pattern pattern, int index)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600085B")]
	[Address(RVA = "0x361C78", Offset = "0x361C78", VA = "0x361C78")]
	private void Reset()
	{
	}

	[Token(Token = "0x600085C")]
	[Address(RVA = "0x361CE0", Offset = "0x361CE0", VA = "0x361CE0")]
	private void Clear()
	{
	}

	[Token(Token = "0x600085D")]
	[Address(RVA = "0x361D9C", Offset = "0x361D9C", VA = "0x361D9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600085E")]
	[Address(RVA = "0x361DB8", Offset = "0x361DB8", VA = "0x361DB8")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x600085F")]
	[Address(RVA = "0x362660", Offset = "0x362660", VA = "0x362660")]
	private void OnDisable()
	{
	}
}
[Token(Token = "0x200011A")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x163C88", Offset = "0x163C88")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x163C88", Offset = "0x163C88")]
public class TemporalReprojection : EffectBase
{
	[Token(Token = "0x200011B")]
	public enum Neighborhood
	{
		[Token(Token = "0x40005B3")]
		MinMax3x3,
		[Token(Token = "0x40005B4")]
		MinMax3x3Rounded,
		[Token(Token = "0x40005B5")]
		MinMax4TapVarying
	}

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static RenderBuffer[] mrt;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Camera _camera;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private FrustumJitter _frustumJitter;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private VelocityBuffer _velocityBuffer;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader reprojectionShader;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Material reprojectionMaterial;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderTexture[,] reprojectionBuffer;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int[] reprojectionIndex;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Neighborhood neighborhood;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool unjitterColorSamples;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool unjitterNeighborhood;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool unjitterReprojection;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	public bool useYCoCg;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool useClipping;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool useDilation;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool useMotionBlur;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool useOptimizations;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x163D7C", Offset = "0x163D7C")]
	public float feedbackMin;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x163D94", Offset = "0x163D94")]
	public float feedbackMax;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float motionBlurStrength;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool motionBlurIgnoreFF;

	[Token(Token = "0x6000860")]
	[Address(RVA = "0x39B610", Offset = "0x39B610", VA = "0x39B610")]
	public TemporalReprojection()
	{
	}

	[Token(Token = "0x6000861")]
	[Address(RVA = "0x39B70C", Offset = "0x39B70C", VA = "0x39B70C")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0x39B7AC", Offset = "0x39B7AC", VA = "0x39B7AC")]
	private void Clear()
	{
	}

	[Token(Token = "0x6000863")]
	[Address(RVA = "0x39B88C", Offset = "0x39B88C", VA = "0x39B88C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000864")]
	[Address(RVA = "0x39B8A8", Offset = "0x39B8A8", VA = "0x39B8A8")]
	private void Resolve(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0x39C800", Offset = "0x39C800", VA = "0x39C800")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000866")]
	[Address(RVA = "0x39CA2C", Offset = "0x39CA2C", VA = "0x39CA2C")]
	private void OnApplicationQuit()
	{
	}
}
[Token(Token = "0x200011C")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x163DAC", Offset = "0x163DAC")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x163DAC", Offset = "0x163DAC")]
public class VelocityBuffer : EffectBase
{
	[Token(Token = "0x200011D")]
	public enum NeighborMaxSupport
	{
		[Token(Token = "0x40005C9")]
		TileSize10,
		[Token(Token = "0x40005CA")]
		TileSize20,
		[Token(Token = "0x40005CB")]
		TileSize40
	}

	[Token(Token = "0x40005B6")]
	private const RenderTextureFormat velocityFormat = RenderTextureFormat.RGFloat;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Camera _camera;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private FrustumJitter _frustumJitter;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Shader velocityShader;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material velocityMaterial;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private RenderTexture[] velocityBuffer;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderTexture[] velocityNeighborMax;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool[] paramInitialized;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector4[] paramProjectionExtents;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Matrix4x4[] paramCurrV;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Matrix4x4[] paramCurrVP;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Matrix4x4[] paramPrevVP;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Matrix4x4[] paramPrevVP_NoFlip;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int activeEyeIndex;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool neighborMaxGen;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public NeighborMaxSupport neighborMaxSupport;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float timeScaleNextFrame;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163E78", Offset = "0x163E78")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x163E78", Offset = "0x163E78")]
	private float <timeScale>k__BackingField;

	[Token(Token = "0x17000099")]
	public RenderTexture activeVelocityBuffer
	{
		[Token(Token = "0x6000869")]
		[Address(RVA = "0xACED84", Offset = "0xACED84", VA = "0xACED84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009A")]
	public RenderTexture activeVelocityNeighborMax
	{
		[Token(Token = "0x600086A")]
		[Address(RVA = "0xACEDD4", Offset = "0xACEDD4", VA = "0xACEDD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009B")]
	public float timeScale
	{
		[Token(Token = "0x600086B")]
		[Address(RVA = "0xACEE24", Offset = "0xACEE24", VA = "0xACEE24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163EAC", Offset = "0x163EAC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600086C")]
		[Address(RVA = "0xACEE2C", Offset = "0xACEE2C", VA = "0xACEE2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163EBC", Offset = "0x163EBC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0xACED6C", Offset = "0xACED6C", VA = "0xACED6C")]
	public VelocityBuffer()
	{
	}

	[Token(Token = "0x600086D")]
	[Address(RVA = "0xACEE34", Offset = "0xACEE34", VA = "0xACEE34")]
	private void Reset()
	{
	}

	[Token(Token = "0x600086E")]
	[Address(RVA = "0xACEEB8", Offset = "0xACEEB8", VA = "0xACEEB8")]
	private void Clear()
	{
	}

	[Token(Token = "0x600086F")]
	[Address(RVA = "0xACEF98", Offset = "0xACEF98", VA = "0xACEF98")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000870")]
	[Address(RVA = "0xACEFB4", Offset = "0xACEFB4", VA = "0xACEFB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000871")]
	[Address(RVA = "0xACEFD4", Offset = "0xACEFD4", VA = "0xACEFD4")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x6000872")]
	[Address(RVA = "0xACEFE0", Offset = "0xACEFE0", VA = "0xACEFE0")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6000873")]
	[Address(RVA = "0xAD15C8", Offset = "0xAD15C8", VA = "0xAD15C8")]
	private void OnApplicationQuit()
	{
	}
}
[Token(Token = "0x200011E")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x163ECC", Offset = "0x163ECC")]
public class VelocityBufferTag : MonoBehaviour
{
	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<Vector3> temporaryVertexStorage;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static List<VelocityBufferTag> activeObjects;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Transform _transform;

	[NonSerialized]
	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public SkinnedMeshRenderer meshSmr;

	[NonSerialized]
	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public bool meshSmrActive;

	[NonSerialized]
	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Mesh mesh;

	[NonSerialized]
	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public Matrix4x4 localToWorldPrev;

	[NonSerialized]
	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[HideInInspector]
	public Matrix4x4 localToWorldCurr;

	[Token(Token = "0x40005D4")]
	private const int framesNotRenderedSleepThreshold = 60;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int framesNotRendered;

	[Token(Token = "0x1700009C")]
	public bool rendering
	{
		[Token(Token = "0x6000875")]
		[Address(RVA = "0xAD15B4", Offset = "0xAD15B4", VA = "0xAD15B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000874")]
	[Address(RVA = "0xAD16B0", Offset = "0xAD16B0", VA = "0xAD16B0")]
	public VelocityBufferTag()
	{
	}

	[Token(Token = "0x6000876")]
	[Address(RVA = "0xAD16C0", Offset = "0xAD16C0", VA = "0xAD16C0")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0xAD18C8", Offset = "0xAD18C8", VA = "0xAD18C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000878")]
	[Address(RVA = "0xAD18CC", Offset = "0xAD18CC", VA = "0xAD18CC")]
	private void TagUpdate(bool restart)
	{
	}

	[Token(Token = "0x6000879")]
	[Address(RVA = "0xAD1D14", Offset = "0xAD1D14", VA = "0xAD1D14")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600087A")]
	[Address(RVA = "0xAD1D30", Offset = "0xAD1D30", VA = "0xAD1D30")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x600087B")]
	[Address(RVA = "0xAD1E04", Offset = "0xAD1E04", VA = "0xAD1E04")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600087C")]
	[Address(RVA = "0xAD1EBC", Offset = "0xAD1EBC", VA = "0xAD1EBC")]
	private void OnDisable()
	{
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x200011F")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x2000181")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163F60", Offset = "0x163F60")]
		private sealed class <Start>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int <i>__1;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Benchmark01 $this;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009DA")]
				[Address(RVA = "0x39D640", Offset = "0x39D640", VA = "0x39D640", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009DB")]
				[Address(RVA = "0x39D648", Offset = "0x39D648", VA = "0x39D648", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x39CCAC", Offset = "0x39CCAC", VA = "0x39CCAC")]
			[DebuggerHidden]
			public <Start>c__Iterator0()
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x39CCB4", Offset = "0x39CCB4", VA = "0x39CCB4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x39D650", Offset = "0x39D650", VA = "0x39D650", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x39D664", Offset = "0x39D664", VA = "0x39D664", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int BenchmarkType;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Font TextMeshFont;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private TextContainer m_textContainer;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40005DC")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x40005DD")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Material m_material01;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material m_material02;

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x39CC24", Offset = "0x39CC24", VA = "0x39CC24")]
		public Benchmark01()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x39CC2C", Offset = "0x39CC2C", VA = "0x39CC2C")]
		[DebuggerHidden]
		private IEnumerator Start()
		{
			return null;
		}
	}
	[Token(Token = "0x2000120")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x163FD0", Offset = "0x163FD0")]
		private sealed class <Start>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int <i>__1;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Benchmark01_UGUI $this;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009E0")]
				[Address(RVA = "0x39DF6C", Offset = "0x39DF6C", VA = "0x39DF6C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E1")]
				[Address(RVA = "0x39DF74", Offset = "0x39DF74", VA = "0x39DF74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x39D770", Offset = "0x39D770", VA = "0x39D770")]
			[DebuggerHidden]
			public <Start>c__Iterator0()
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x39D778", Offset = "0x39D778", VA = "0x39D778", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x39DF7C", Offset = "0x39DF7C", VA = "0x39DF7C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x39DF90", Offset = "0x39DF90", VA = "0x39DF90", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int BenchmarkType;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Canvas canvas;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Font TextMeshFont;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text m_textMesh;

		[Token(Token = "0x40005E6")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x40005E7")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Material m_material01;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material m_material02;

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x39D6E8", Offset = "0x39D6E8", VA = "0x39D6E8")]
		public Benchmark01_UGUI()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x39D6F0", Offset = "0x39D6F0", VA = "0x39D6F0")]
		[DebuggerHidden]
		private IEnumerator Start()
		{
			return null;
		}
	}
	[Token(Token = "0x2000121")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int SpawnType;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int NumberOfNPC;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x39E014", Offset = "0x39E014", VA = "0x39E014")]
		public Benchmark02()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x39E024", Offset = "0x39E024", VA = "0x39E024")]
		private void Start()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int SpawnType;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int NumberOfNPC;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Font TheFont;

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x39EA1C", Offset = "0x39EA1C", VA = "0x39EA1C")]
		public Benchmark03()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x39EA2C", Offset = "0x39EA2C", VA = "0x39EA2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x39EA30", Offset = "0x39EA30", VA = "0x39EA30")]
		private void Start()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int SpawnType;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int MinPointSize;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int MaxPointSize;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Steps;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Transform m_Transform;

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x39EE48", Offset = "0x39EE48", VA = "0x39EE48")]
		public Benchmark04()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x39EE64", Offset = "0x39EE64", VA = "0x39EE64")]
		private void Start()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x2000125")]
		public enum CameraModes
		{
			[Token(Token = "0x400060F")]
			Follow,
			[Token(Token = "0x4000610")]
			Isometric,
			[Token(Token = "0x4000611")]
			Free
		}

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Transform cameraTransform;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform dummyTarget;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform CameraTarget;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FollowDistance;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MaxFollowDistance;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MinFollowDistance;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ElevationAngle;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MaxElevationAngle;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float MinElevationAngle;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float OrbitalAngle;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CameraModes CameraMode;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool MovementSmoothing;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool RotationSmoothing;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool previousSmoothing;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float MovementSmoothingValue;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float RotationSmoothingValue;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MoveSensitivity;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 currentVelocity;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 desiredPosition;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float mouseX;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float mouseY;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 moveVector;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float mouseWheel;

		[Token(Token = "0x400060C")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x400060D")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x39F3E0", Offset = "0x39F3E0", VA = "0x39F3E0")]
		public CameraController()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x39F4DC", Offset = "0x39F4DC", VA = "0x39F4DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x39F5C8", Offset = "0x39F5C8", VA = "0x39F5C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x39F6B4", Offset = "0x39F6B4", VA = "0x39F6B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x39FCE0", Offset = "0x39FCE0", VA = "0x39FCE0")]
		private void GetPlayerInput()
		{
		}
	}
}
[Token(Token = "0x2000126")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public TMP_InputField TMP_ChatInput;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TMP_Text TMP_ChatOutput;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x600088E")]
	[Address(RVA = "0x3546CC", Offset = "0x3546CC", VA = "0x3546CC")]
	public ChatController()
	{
	}

	[Token(Token = "0x600088F")]
	[Address(RVA = "0x3546D4", Offset = "0x3546D4", VA = "0x3546D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000890")]
	[Address(RVA = "0x3547B0", Offset = "0x3547B0", VA = "0x3547B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0x35488C", Offset = "0x35488C", VA = "0x35488C")]
	private void AddToChatOutput(string newText)
	{
	}
}
[Token(Token = "0x2000127")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x164040", Offset = "0x164040")]
	private sealed class <Start>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
	{
		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Matrix4x4 <matrix>__0;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal EnvMapAnimator $this;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal object $current;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal bool $disposing;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal int $PC;

		[Token(Token = "0x170000C6")]
		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x360794", Offset = "0x360794", VA = "0x360794", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x36079C", Offset = "0x36079C", VA = "0x36079C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x360460", Offset = "0x360460", VA = "0x360460")]
		[DebuggerHidden]
		public <Start>c__Iterator0()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x360468", Offset = "0x360468", VA = "0x360468", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x3607A4", Offset = "0x3607A4", VA = "0x3607A4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x3607B8", Offset = "0x3607B8", VA = "0x3607B8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Material m_material;

	[Token(Token = "0x6000892")]
	[Address(RVA = "0x360348", Offset = "0x360348", VA = "0x360348")]
	public EnvMapAnimator()
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x360350", Offset = "0x360350", VA = "0x360350")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0x3603E0", Offset = "0x3603E0", VA = "0x3603E0")]
	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x2000128")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x2000129")]
		public enum MotionType
		{
			[Token(Token = "0x4000623")]
			Rotation,
			[Token(Token = "0x4000624")]
			BackAndForth,
			[Token(Token = "0x4000625")]
			Translation
		}

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float SpinSpeed;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int RotationRange;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Transform m_transform;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_time;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color32 m_lightColor;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int frames;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MotionType Motion;

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x3A0A84", Offset = "0x3A0A84", VA = "0x3A0A84")]
		public ObjectSpin()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x3A0AA0", Offset = "0x3A0AA0", VA = "0x3A0AA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x3A0C60", Offset = "0x3A0C60", VA = "0x3A0C60")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x2000184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1640B0", Offset = "0x1640B0")]
		private sealed class <AnimateProperties>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <glowPower>__1;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal ShaderPropAnimator $this;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009EC")]
				[Address(RVA = "0x3A12A8", Offset = "0x3A12A8", VA = "0x3A12A8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009ED")]
				[Address(RVA = "0x3A12B0", Offset = "0x3A12B0", VA = "0x3A12B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x3A1080", Offset = "0x3A1080", VA = "0x3A1080")]
			[DebuggerHidden]
			public <AnimateProperties>c__Iterator0()
			{
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x3A1088", Offset = "0x3A1088", VA = "0x3A1088", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x3A12B8", Offset = "0x3A12B8", VA = "0x3A12B8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x3A12CC", Offset = "0x3A12CC", VA = "0x3A12CC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Renderer m_Renderer;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Material m_Material;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_frame;

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x3A0F4C", Offset = "0x3A0F4C", VA = "0x3A0F4C")]
		public ShaderPropAnimator()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x3A0F54", Offset = "0x3A0F54", VA = "0x3A0F54")]
		private void Awake()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x3A0FDC", Offset = "0x3A0FDC", VA = "0x3A0FDC")]
		private void Start()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x3A1000", Offset = "0x3A1000", VA = "0x3A1000")]
		[DebuggerHidden]
		private IEnumerator AnimateProperties()
		{
			return null;
		}
	}
	[Token(Token = "0x200012B")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x400062B")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_frame;

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x3A1350", Offset = "0x3A1350", VA = "0x3A1350")]
		public SimpleScript()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x3A1358", Offset = "0x3A1358", VA = "0x3A1358")]
		private void Start()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x3A1468", Offset = "0x3A1468", VA = "0x3A1468")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x164120", Offset = "0x164120")]
		private sealed class <WarpText>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <old_CurveScale>__0;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal float <old_ShearValue>__0;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal AnimationCurve <old_curve>__0;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal TMP_TextInfo <textInfo>__1;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int <characterCount>__1;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal float <boundsMinX>__1;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal float <boundsMaxX>__1;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal Vector3[] <vertices>__2;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal SkewTextExample $this;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			internal object $current;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal bool $disposing;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			internal int $PC;

			[Token(Token = "0x170000CA")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009F2")]
				[Address(RVA = "0x3A2FBC", Offset = "0x3A2FBC", VA = "0x3A2FBC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F3")]
				[Address(RVA = "0x3A2FC4", Offset = "0x3A2FC4", VA = "0x3A2FC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x3A1940", Offset = "0x3A1940", VA = "0x3A1940")]
			[DebuggerHidden]
			public <WarpText>c__Iterator0()
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x3A1948", Offset = "0x3A1948", VA = "0x3A1948", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x3A2FCC", Offset = "0x3A2FCC", VA = "0x3A2FCC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x3A2FE0", Offset = "0x3A2FE0", VA = "0x3A2FE0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float CurveScale;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float ShearAmount;

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x3A1520", Offset = "0x3A1520", VA = "0x3A1520")]
		public SkewTextExample()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x3A1770", Offset = "0x3A1770", VA = "0x3A1770")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x3A17F4", Offset = "0x3A17F4", VA = "0x3A17F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x3A1898", Offset = "0x3A1898", VA = "0x3A1898")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x3A1818", Offset = "0x3A1818", VA = "0x3A1818")]
		[DebuggerHidden]
		private IEnumerator WarpText()
		{
			return null;
		}
	}
	[Token(Token = "0x200012D")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x2000186")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x164190", Offset = "0x164190")]
		private sealed class <Start>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int <totalVisibleCharacters>__0;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int <counter>__0;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <visibleCount>__0;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal TeleType $this;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal object $current;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal bool $disposing;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int $PC;

			[Token(Token = "0x170000CC")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009F8")]
				[Address(RVA = "0x3A356C", Offset = "0x3A356C", VA = "0x3A356C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F9")]
				[Address(RVA = "0x3A3574", Offset = "0x3A3574", VA = "0x3A3574", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x3A3230", Offset = "0x3A3230", VA = "0x3A3230")]
			[DebuggerHidden]
			public <Start>c__Iterator0()
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x3A3238", Offset = "0x3A3238", VA = "0x3A3238", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x3A357C", Offset = "0x3A357C", VA = "0x3A357C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x3A3590", Offset = "0x3A3590", VA = "0x3A3590", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string label01;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string label02;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x3A3064", Offset = "0x3A3064", VA = "0x3A3064")]
		public TeleType()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x3A30E4", Offset = "0x3A30E4", VA = "0x3A30E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x3A31B0", Offset = "0x3A31B0", VA = "0x3A31B0")]
		[DebuggerHidden]
		private IEnumerator Start()
		{
			return null;
		}
	}
	[Token(Token = "0x200012E")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x2000187")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x164210", Offset = "0x164210")]
		private sealed class <RevealCharacters>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_Text textComponent;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <totalVisibleCharacters>__0;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <visibleCount>__0;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TextConsoleSimulator $this;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal object $current;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int $PC;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009FE")]
				[Address(RVA = "0x3A3BD0", Offset = "0x3A3BD0", VA = "0x3A3BD0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009FF")]
				[Address(RVA = "0x3A3BD8", Offset = "0x3A3BD8", VA = "0x3A3BD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x3A396C", Offset = "0x3A396C", VA = "0x3A396C")]
			[DebuggerHidden]
			public <RevealCharacters>c__Iterator0()
			{
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x3A39FC", Offset = "0x3A39FC", VA = "0x3A39FC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x3A3BE0", Offset = "0x3A3BE0", VA = "0x3A3BE0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x3A3BF4", Offset = "0x3A3BF4", VA = "0x3A3BF4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x164270", Offset = "0x164270")]
		private sealed class <RevealWords>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_Text textComponent;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int <totalWordCount>__0;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <totalVisibleCharacters>__0;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <counter>__0;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int <currentWord>__0;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int <visibleCount>__0;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal object $current;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool $disposing;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int $PC;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A04")]
				[Address(RVA = "0x3A3F1C", Offset = "0x3A3F1C", VA = "0x3A3F1C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A05")]
				[Address(RVA = "0x3A3F24", Offset = "0x3A3F24", VA = "0x3A3F24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x3A39F4", Offset = "0x3A39F4", VA = "0x3A39F4")]
			[DebuggerHidden]
			public <RevealWords>c__Iterator1()
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x3A3C78", Offset = "0x3A3C78", VA = "0x3A3C78", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x3A3F2C", Offset = "0x3A3F2C", VA = "0x3A3F2C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x3A3F40", Offset = "0x3A3F40", VA = "0x3A3F40", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool hasTextChanged;

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x3A3614", Offset = "0x3A3614", VA = "0x3A3614")]
		public TextConsoleSimulator()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x3A361C", Offset = "0x3A361C", VA = "0x3A361C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x3A36A0", Offset = "0x3A36A0", VA = "0x3A36A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x3A3760", Offset = "0x3A3760", VA = "0x3A3760")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x3A3860", Offset = "0x3A3860", VA = "0x3A3860")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x3A3960", Offset = "0x3A3960", VA = "0x3A3960")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x3A36C8", Offset = "0x3A36C8", VA = "0x3A36C8")]
		[DebuggerHidden]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x3A3974", Offset = "0x3A3974", VA = "0x3A3974")]
		[DebuggerHidden]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}
	}
	[Token(Token = "0x200012F")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x2000189")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1642F0", Offset = "0x1642F0")]
		private sealed class <DisplayTextMeshProFloatingText>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <CountDuration>__0;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal float <starting_Count>__0;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal float <current_Count>__0;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Vector3 <start_pos>__0;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Color32 <start_color>__0;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal float <alpha>__0;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int <int_counter>__0;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal float <fadeDuration>__0;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal TextMeshProFloatingText $this;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal object $current;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal bool $disposing;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal int $PC;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A0A")]
				[Address(RVA = "0x3A5A58", Offset = "0x3A5A58", VA = "0x3A5A58", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0x3A5A60", Offset = "0x3A5A60", VA = "0x3A5A60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x3A4928", Offset = "0x3A4928", VA = "0x3A4928")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x3A5214", Offset = "0x3A5214", VA = "0x3A5214", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x3A5A68", Offset = "0x3A5A68", VA = "0x3A5A68", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x3A5A7C", Offset = "0x3A5A7C", VA = "0x3A5A7C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200018A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x164350", Offset = "0x164350")]
		private sealed class <DisplayTextMeshFloatingText>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <CountDuration>__0;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal float <starting_Count>__0;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal float <current_Count>__0;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Vector3 <start_pos>__0;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Color32 <start_color>__0;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal float <alpha>__0;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int <int_counter>__0;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal float <fadeDuration>__0;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal TextMeshProFloatingText $this;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal object $current;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal bool $disposing;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal int $PC;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A10")]
				[Address(RVA = "0x3A516C", Offset = "0x3A516C", VA = "0x3A516C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A11")]
				[Address(RVA = "0x3A5174", Offset = "0x3A5174", VA = "0x3A5174", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x3A4930", Offset = "0x3A4930", VA = "0x3A4930")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>c__Iterator1()
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x3A4938", Offset = "0x3A4938", VA = "0x3A4938", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x3A517C", Offset = "0x3A517C", VA = "0x3A517C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x3A5190", Offset = "0x3A5190", VA = "0x3A5190", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Font TheFont;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GameObject m_floatingText;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMesh m_textMesh;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Transform m_transform;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Transform m_cameraTransform;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 lastPOS;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion lastRotation;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int SpawnType;

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x3A3FC4", Offset = "0x3A3FC4", VA = "0x3A3FC4")]
		public TextMeshProFloatingText()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x3A40B8", Offset = "0x3A40B8", VA = "0x3A40B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x3A41C8", Offset = "0x3A41C8", VA = "0x3A41C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x3A4828", Offset = "0x3A4828", VA = "0x3A4828")]
		[DebuggerHidden]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x3A48A8", Offset = "0x3A48A8", VA = "0x3A48A8")]
		[DebuggerHidden]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}
	}
	[Token(Token = "0x2000130")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int SpawnType;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int NumberOfNPC;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Font TheFont;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x3A5B00", Offset = "0x3A5B00", VA = "0x3A5B00")]
		public TextMeshSpawner()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x3A5B10", Offset = "0x3A5B10", VA = "0x3A5B10")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x3A5B14", Offset = "0x3A5B14", VA = "0x3A5B14")]
		private void Start()
		{
		}
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000131")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xAC2B88", Offset = "0xAC2B88", VA = "0xAC2B88")]
		public TMP_DigitValidator()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xAC2B90", Offset = "0xAC2B90", VA = "0xAC2B90", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x2000132")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x2000133")]
		public enum objectType
		{
			[Token(Token = "0x400064A")]
			TextMeshPro,
			[Token(Token = "0x400064B")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public objectType ObjectType;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStatic;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TMP_Text m_text;

		[Token(Token = "0x4000647")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int count;

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x3A5FE4", Offset = "0x3A5FE4", VA = "0x3A5FE4")]
		public TMP_ExampleScript_01()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x3A5FEC", Offset = "0x3A5FEC", VA = "0x3A5FEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x3A62A8", Offset = "0x3A62A8", VA = "0x3A62A8")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000135")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000657")]
			TopLeft,
			[Token(Token = "0x4000658")]
			BottomLeft,
			[Token(Token = "0x4000659")]
			TopRight,
			[Token(Token = "0x400065A")]
			BottomRight
		}

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float UpdateInterval;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_LastInterval;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_Frames;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private string htmlColorTag;

		[Token(Token = "0x4000651")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Camera m_camera;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x3A6364", Offset = "0x3A6364", VA = "0x3A6364")]
		public TMP_FrameRateCounter()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x3A6380", Offset = "0x3A6380", VA = "0x3A6380")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x3A6A0C", Offset = "0x3A6A0C", VA = "0x3A6A0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x3A6A34", Offset = "0x3A6A34", VA = "0x3A6A34")]
		private void Update()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x3A6640", Offset = "0x3A6640", VA = "0x3A6640")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000136")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xAC2BB4", Offset = "0xAC2BB4", VA = "0xAC2BB4")]
		public TMP_PhoneNumberValidator()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xAC2BBC", Offset = "0xAC2BBC", VA = "0xAC2BBC", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x2000137")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x3A6C2C", Offset = "0x3A6C2C", VA = "0x3A6C2C")]
		public TMP_TextEventCheck()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x3A6C34", Offset = "0x3A6C34", VA = "0x3A6C34")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x3A6F9C", Offset = "0x3A6F9C", VA = "0x3A6F9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x3A7304", Offset = "0x3A7304", VA = "0x3A7304")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x3A7608", Offset = "0x3A7608", VA = "0x3A7608")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x3A790C", Offset = "0x3A790C", VA = "0x3A790C")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x3A7CC0", Offset = "0x3A7CC0", VA = "0x3A7CC0")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x3A8074", Offset = "0x3A8074", VA = "0x3A8074")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}
	}
}
namespace TMPro
{
	[Token(Token = "0x2000138")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Serializable]
		[Token(Token = "0x2000139")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0xAC3624", Offset = "0xAC3624", VA = "0xAC3624")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013A")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0xAC3688", Offset = "0xAC3688", VA = "0xAC3688")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013B")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0xAC36EC", Offset = "0xAC36EC", VA = "0xAC36EC")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013C")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0xAC3750", Offset = "0xAC3750", VA = "0xAC3750")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013D")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0xAC37B4", Offset = "0xAC37B4", VA = "0xAC37B4")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Camera m_Camera;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Canvas m_Canvas;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_lastLineIndex;

		[Token(Token = "0x1700009D")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xAC3818", Offset = "0xAC3818", VA = "0xAC3818")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xAC3820", Offset = "0xAC3820", VA = "0xAC3820")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xAC3828", Offset = "0xAC3828", VA = "0xAC3828")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xAC3830", Offset = "0xAC3830", VA = "0xAC3830")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xAC3838", Offset = "0xAC3838", VA = "0xAC3838")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0xAC3840", Offset = "0xAC3840", VA = "0xAC3840")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0xAC3848", Offset = "0xAC3848", VA = "0xAC3848")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0xAC3850", Offset = "0xAC3850", VA = "0xAC3850")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0xAC3858", Offset = "0xAC3858", VA = "0xAC3858")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0xAC3860", Offset = "0xAC3860", VA = "0xAC3860")]
			set
			{
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xAC3518", Offset = "0xAC3518", VA = "0xAC3518")]
		public TMP_TextEventHandler()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xAC3868", Offset = "0xAC3868", VA = "0xAC3868")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xAC3A44", Offset = "0xAC3A44", VA = "0xAC3A44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xAC4508", Offset = "0xAC4508", VA = "0xAC4508", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xAC450C", Offset = "0xAC450C", VA = "0xAC450C", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xAC4260", Offset = "0xAC4260", VA = "0xAC4260")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xAC42DC", Offset = "0xAC42DC", VA = "0xAC42DC")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xAC4358", Offset = "0xAC4358", VA = "0xAC4358")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xAC43E8", Offset = "0xAC43E8", VA = "0xAC43E8")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xAC4478", Offset = "0xAC4478", VA = "0xAC4478")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x200013E")]
	[ExecuteInEditMode]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool ShowCharacters;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool ShowWords;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool ShowLinks;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public bool ShowLines;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool ShowMeshBounds;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool ShowTextBounds;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x164410", Offset = "0x164410")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x164410", Offset = "0x164410")]
		public string ObjectStats;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Transform m_Transform;

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x3A8408", Offset = "0x3A8408", VA = "0x3A8408")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Camera m_Camera;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool m_isHoveringObject;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_selectedLink;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_lastCharIndex;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_lastWordIndex;

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x3A8410", Offset = "0x3A8410", VA = "0x3A8410")]
		public TMP_TextSelector_A()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x3A8428", Offset = "0x3A8428", VA = "0x3A8428")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x3A84E0", Offset = "0x3A84E0", VA = "0x3A84E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x3A9460", Offset = "0x3A9460", VA = "0x3A9460", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x3A94FC", Offset = "0x3A94FC", VA = "0x3A94FC", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x400067A")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x400067B")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Canvas m_Canvas;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool isHoveringObject;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_selectedWord;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastIndex;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x3A9598", Offset = "0x3A9598", VA = "0x3A9598")]
		public TMP_TextSelector_B()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x3A95B0", Offset = "0x3A95B0", VA = "0x3A95B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x3A97B8", Offset = "0x3A97B8", VA = "0x3A97B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x3A98B8", Offset = "0x3A98B8", VA = "0x3A98B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x3A99B8", Offset = "0x3A99B8", VA = "0x3A99B8")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x3A9A90", Offset = "0x3A9A90", VA = "0x3A9A90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x3AC630", Offset = "0x3AC630", VA = "0x3AC630", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x3AC63C", Offset = "0x3AC63C", VA = "0x3AC63C", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x3AC648", Offset = "0x3AC648", VA = "0x3AC648", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x3AC64C", Offset = "0x3AC64C", VA = "0x3AC64C", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x3AB4E4", Offset = "0x3AB4E4", VA = "0x3AB4E4")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x400068F")]
			TopLeft,
			[Token(Token = "0x4000690")]
			BottomLeft,
			[Token(Token = "0x4000691")]
			TopRight,
			[Token(Token = "0x4000692")]
			BottomRight
		}

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float UpdateInterval;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_LastInterval;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int m_Frames;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private string htmlColorTag;

		[Token(Token = "0x400068A")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x3AC650", Offset = "0x3AC650", VA = "0x3AC650")]
		public TMP_UiFrameRateCounter()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x3AC66C", Offset = "0x3AC66C", VA = "0x3AC66C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x3ACD50", Offset = "0x3ACD50", VA = "0x3ACD50")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x3ACD78", Offset = "0x3ACD78", VA = "0x3ACD78")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x3AC8AC", Offset = "0x3AC8AC", VA = "0x3AC8AC")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x2000144")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x400069A")]
			TopLeft,
			[Token(Token = "0x400069B")]
			BottomLeft,
			[Token(Token = "0x400069C")]
			TopRight,
			[Token(Token = "0x400069D")]
			BottomRight
		}

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000694")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Camera m_camera;

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x3ACF70", Offset = "0x3ACF70", VA = "0x3ACF70")]
		public TMPro_InstructionOverlay()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x3ACF80", Offset = "0x3ACF80", VA = "0x3ACF80")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x3AD25C", Offset = "0x3AD25C", VA = "0x3AD25C")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x200018B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x164460", Offset = "0x164460")]
		private sealed class <AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int <currentCharacter>__0;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Color32 <c0>__0;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <characterCount>__1;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int <materialIndex>__1;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Color32[] <newVertexColors>__1;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int <vertexIndex>__1;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal VertexColorCycler $this;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal object $current;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal bool $disposing;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int $PC;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A16")]
				[Address(RVA = "0x3AD9EC", Offset = "0x3AD9EC", VA = "0x3AD9EC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A17")]
				[Address(RVA = "0x3AD9F4", Offset = "0x3AD9F4", VA = "0x3AD9F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x3AD550", Offset = "0x3AD550", VA = "0x3AD550")]
			[DebuggerHidden]
			public <AnimateVertexColors>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x3AD558", Offset = "0x3AD558", VA = "0x3AD558", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x3AD9FC", Offset = "0x3AD9FC", VA = "0x3AD9FC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x3ADA10", Offset = "0x3ADA10", VA = "0x3ADA10", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x3AD43C", Offset = "0x3AD43C", VA = "0x3AD43C")]
		public VertexColorCycler()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x3AD444", Offset = "0x3AD444", VA = "0x3AD444")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x3AD4AC", Offset = "0x3AD4AC", VA = "0x3AD4AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x3AD4D0", Offset = "0x3AD4D0", VA = "0x3AD4D0")]
		[DebuggerHidden]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
	[Token(Token = "0x2000146")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x2000147")]
		private struct VertexAnim
		{
			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x200018C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1644D0", Offset = "0x1644D0")]
		private sealed class <AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int <loopCount>__0;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal VertexAnim[] <vertexAnim>__0;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal TMP_MeshInfo[] <cachedMeshInfo>__0;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int <characterCount>__1;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal VertexJitter $this;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal object $current;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal bool $disposing;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal int $PC;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A1C")]
				[Address(RVA = "0x3AEF80", Offset = "0x3AEF80", VA = "0x3AEF80", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A1D")]
				[Address(RVA = "0x3AEF88", Offset = "0x3AEF88", VA = "0x3AEF88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x3ADE58", Offset = "0x3ADE58", VA = "0x3ADE58")]
			[DebuggerHidden]
			public <AnimateVertexColors>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x3ADE60", Offset = "0x3ADE60", VA = "0x3ADE60", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x3AEF90", Offset = "0x3AEF90", VA = "0x3AEF90", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x3AEFA4", Offset = "0x3AEFA4", VA = "0x3AEFA4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float AngleMultiplier;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float SpeedMultiplier;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float CurveScale;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool hasTextChanged;

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x3ADA94", Offset = "0x3ADA94", VA = "0x3ADA94")]
		public VertexJitter()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x3ADAAC", Offset = "0x3ADAAC", VA = "0x3ADAAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x3ADB14", Offset = "0x3ADB14", VA = "0x3ADB14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x3ADC14", Offset = "0x3ADC14", VA = "0x3ADC14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x3ADD14", Offset = "0x3ADD14", VA = "0x3ADD14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x3ADDB8", Offset = "0x3ADDB8", VA = "0x3ADDB8")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x3ADD38", Offset = "0x3ADD38", VA = "0x3ADD38")]
		[DebuggerHidden]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
	[Token(Token = "0x2000148")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x200018D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x164540", Offset = "0x164540")]
		private sealed class <AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Vector3[][] <copyOfVertices>__0;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <characterCount>__1;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <lineCount>__1;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal VertexShakeA $this;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal object $current;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal bool $disposing;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal int $PC;

			[Token(Token = "0x170000DA")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A22")]
				[Address(RVA = "0x3B0AB4", Offset = "0x3B0AB4", VA = "0x3B0AB4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A23")]
				[Address(RVA = "0x3B0ABC", Offset = "0x3B0ABC", VA = "0x3B0ABC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x3AF3E8", Offset = "0x3AF3E8", VA = "0x3AF3E8")]
			[DebuggerHidden]
			public <AnimateVertexColors>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x3AF3F0", Offset = "0x3AF3F0", VA = "0x3AF3F0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x3B0AC4", Offset = "0x3B0AC4", VA = "0x3B0AC4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x3B0AD8", Offset = "0x3B0AD8", VA = "0x3B0AD8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float AngleMultiplier;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float SpeedMultiplier;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float ScaleMultiplier;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float RotationMultiplier;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x3AF028", Offset = "0x3AF028", VA = "0x3AF028")]
		public VertexShakeA()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x3AF044", Offset = "0x3AF044", VA = "0x3AF044")]
		private void Awake()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x3AF0AC", Offset = "0x3AF0AC", VA = "0x3AF0AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x3AF1AC", Offset = "0x3AF1AC", VA = "0x3AF1AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x3AF2AC", Offset = "0x3AF2AC", VA = "0x3AF2AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x3AF350", Offset = "0x3AF350", VA = "0x3AF350")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x3AF2D0", Offset = "0x3AF2D0", VA = "0x3AF2D0")]
		[DebuggerHidden]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
	[Token(Token = "0x2000149")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x200018E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1645B0", Offset = "0x1645B0")]
		private sealed class <AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Vector3[][] <copyOfVertices>__0;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <characterCount>__1;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <lineCount>__1;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal VertexShakeB $this;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal object $current;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal bool $disposing;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal int $PC;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A28")]
				[Address(RVA = "0x3B2F68", Offset = "0x3B2F68", VA = "0x3B2F68", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A29")]
				[Address(RVA = "0x3B2F70", Offset = "0x3B2F70", VA = "0x3B2F70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x3B0F18", Offset = "0x3B0F18", VA = "0x3B0F18")]
			[DebuggerHidden]
			public <AnimateVertexColors>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x3B0F20", Offset = "0x3B0F20", VA = "0x3B0F20", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x3B2F78", Offset = "0x3B2F78", VA = "0x3B2F78", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x3B2F8C", Offset = "0x3B2F8C", VA = "0x3B2F8C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float AngleMultiplier;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float SpeedMultiplier;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float CurveScale;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool hasTextChanged;

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x3B0B5C", Offset = "0x3B0B5C", VA = "0x3B0B5C")]
		public VertexShakeB()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x3B0B74", Offset = "0x3B0B74", VA = "0x3B0B74")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x3B0BDC", Offset = "0x3B0BDC", VA = "0x3B0BDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x3B0CDC", Offset = "0x3B0CDC", VA = "0x3B0CDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x3B0DDC", Offset = "0x3B0DDC", VA = "0x3B0DDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x3B0E80", Offset = "0x3B0E80", VA = "0x3B0E80")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x3B0E00", Offset = "0x3B0E00", VA = "0x3B0E00")]
		[DebuggerHidden]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
	[Token(Token = "0x200014A")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x200018F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x164620", Offset = "0x164620")]
		private sealed class <AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x2000190")]
			private sealed class <AnimateVertexColors>c__AnonStorey1
			{
				[Token(Token = "0x40007C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal List<float> modifiedCharScale;

				[Token(Token = "0x40007C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				internal <AnimateVertexColors>c__Iterator0 <>f__ref$0;

				[Token(Token = "0x6000A32")]
				[Address(RVA = "0xAC12A0", Offset = "0xAC12A0", VA = "0xAC12A0")]
				public <AnimateVertexColors>c__AnonStorey1()
				{
				}

				[Token(Token = "0x6000A33")]
				[Address(RVA = "0xAC1350", Offset = "0xAC1350", VA = "0xAC1350")]
				internal int <>m__0(int a, int b)
				{
					return default(int);
				}
			}

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TMP_TextInfo <textInfo>__0;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal TMP_MeshInfo[] <cachedMeshInfoVertexData>__0;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal List<int> <scaleSortingOrder>__0;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <characterCount>__1;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal VertexZoom $this;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal object $current;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal bool $disposing;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal int $PC;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private <AnimateVertexColors>c__AnonStorey1 $locvar0;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A2E")]
				[Address(RVA = "0xAC12A8", Offset = "0xAC12A8", VA = "0xAC12A8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A2F")]
				[Address(RVA = "0xAC12B0", Offset = "0xAC12B0", VA = "0xAC12B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0xABFC58", Offset = "0xABFC58", VA = "0xABFC58")]
			[DebuggerHidden]
			public <AnimateVertexColors>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0xABFC60", Offset = "0xABFC60", VA = "0xABFC60", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0xAC12B8", Offset = "0xAC12B8", VA = "0xAC12B8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0xAC12CC", Offset = "0xAC12CC", VA = "0xAC12CC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float AngleMultiplier;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float SpeedMultiplier;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float CurveScale;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool hasTextChanged;

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xABF894", Offset = "0xABF894", VA = "0xABF894")]
		public VertexZoom()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xABF8AC", Offset = "0xABF8AC", VA = "0xABF8AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xABF914", Offset = "0xABF914", VA = "0xABF914")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xABFA14", Offset = "0xABFA14", VA = "0xABFA14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xABFB14", Offset = "0xABFB14", VA = "0xABFB14")]
		private void Start()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xABFBB8", Offset = "0xABFBB8", VA = "0xABFBB8")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xABFB38", Offset = "0xABFB38", VA = "0xABFB38")]
		[DebuggerHidden]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}
	}
	[Token(Token = "0x200014B")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x2000191")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x164690", Offset = "0x164690")]
		private sealed class <WarpText>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <old_CurveScale>__0;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal AnimationCurve <old_curve>__0;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TMP_TextInfo <textInfo>__1;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int <characterCount>__1;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal float <boundsMinX>__1;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal float <boundsMaxX>__1;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Vector3[] <vertices>__2;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal Matrix4x4 <matrix>__2;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal WarpTextExample $this;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal object $current;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			internal bool $disposing;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal int $PC;

			[Token(Token = "0x170000E0")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A36")]
				[Address(RVA = "0xAC2AE0", Offset = "0xAC2AE0", VA = "0xAC2AE0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A37")]
				[Address(RVA = "0xAC2AE8", Offset = "0xAC2AE8", VA = "0xAC2AE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0xAC1844", Offset = "0xAC1844", VA = "0xAC1844")]
			[DebuggerHidden]
			public <WarpText>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0xAC184C", Offset = "0xAC184C", VA = "0xAC184C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0xAC2AF0", Offset = "0xAC2AF0", VA = "0xAC2AF0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0xAC2B04", Offset = "0xAC2B04", VA = "0xAC2B04", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float AngleMultiplier;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SpeedMultiplier;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float CurveScale;

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xAC1420", Offset = "0xAC1420", VA = "0xAC1420")]
		public WarpTextExample()
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xAC1674", Offset = "0xAC1674", VA = "0xAC1674")]
		private void Awake()
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xAC16F8", Offset = "0xAC16F8", VA = "0xAC16F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xAC179C", Offset = "0xAC179C", VA = "0xAC179C")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xAC171C", Offset = "0xAC171C", VA = "0xAC171C")]
		[DebuggerHidden]
		private IEnumerator WarpText()
		{
			return null;
		}
	}
}
