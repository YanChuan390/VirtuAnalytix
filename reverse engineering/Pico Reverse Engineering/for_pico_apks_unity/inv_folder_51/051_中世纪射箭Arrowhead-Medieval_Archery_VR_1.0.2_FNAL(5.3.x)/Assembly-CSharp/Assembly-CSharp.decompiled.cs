using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using DefaultNamespace;
using Dreamteck.Splines;
using EDKG.ArcheryRange;
using EDKG.ArcheryRange.AlertSystem;
using EDKG.ArcheryRange.Audio.Players;
using EDKG.ArcheryRange.Equipment;
using EDKG.ArcheryRange.PostLut;
using EDKG.ArcheryRange.Progression.Areas;
using EDKG.ArcheryRange.Progression.Balance;
using EDKG.ArcheryRange.Progression.MiniGames;
using EDKG.ArcheryRange.Projectiles;
using EDKG.ArcheryRange.Projectiles.Effects;
using EDKG.ArcheryRange.Projectiles.MovementSystems;
using EDKG.ArcheryRange.Targets;
using EDKG.ArcheryRange.UI.Areas;
using EDKG.ArcheryRange.UI.Game.NextEquipment;
using EDKG.ArcheryRange.UI.Loading;
using EDKG.ArcheryRange.UI.Menu.NavBar;
using EDKG.ArcheryRange.UI.ModalWindows;
using EDKG.ArcheryRange.UI.ScreenTabs;
using EDKG.ArcheryRange.UI.Screens;
using EDKG.ArcheryRange.UI.Screens.MainMenu;
using EDKG.ArcheryRange.UI.Widgets.Menu.TitleBar;
using EDKG.ArcheryRange.UI._Global;
using EDKG.ArcheryRange.UI._Global.DynamicResizablePanels;
using EDKG.ArcheryRange.UI._Global.StatBar;
using EDKG.ArcheryRange.UIData;
using EDKG.ArcheryRange.UIRenderer;
using EDKG.ArcheryRange.VR;
using EDKG.ArcheryRange.VR.Visualization;
using I2.Loc;
using ICSharpCode.SharpZipLib.Zip;
using Il2CppDummyDll;
using Kilogrames;
using PathologicalGames;
using SRDebugger;
using Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DebugToggleQuality : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI Label;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _curId;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string[] _names;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x9E6F30", Offset = "0x9E6F30", VA = "0x9E6F30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x9E6FEC", Offset = "0x9E6FEC", VA = "0x9E6FEC")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x9E6F5C", Offset = "0x9E6F5C", VA = "0x9E6F5C")]
	private void RefreshLabel()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x9E7034", Offset = "0x9E7034", VA = "0x9E7034")]
	public DebugToggleQuality()
	{
	}
}
[Token(Token = "0x2000003")]
[Preserve]
public class SROptions : INotifyPropertyChanged
{
	[Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class DisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x9E7E54", Offset = "0x9E7E54", VA = "0x9E7E54")]
		public DisplayNameAttribute(string displayName)
		{
		}
	}

	[Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class IncrementAttribute : SRDebugger.IncrementAttribute
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x9E7EBC", Offset = "0x9E7EBC", VA = "0x9E7EBC")]
		public IncrementAttribute(double increment)
		{
		}
	}

	[Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NumberRangeAttribute : SRDebugger.NumberRangeAttribute
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x9E7EC4", Offset = "0x9E7EC4", VA = "0x9E7EC4")]
		public NumberRangeAttribute(double min, double max)
		{
		}
	}

	[Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class SortAttribute : SRDebugger.SortAttribute
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x9E7ECC", Offset = "0x9E7ECC", VA = "0x9E7ECC")]
		public SortAttribute(int priority)
		{
		}
	}

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GameObject _menu;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly SROptions _current;

	[Token(Token = "0x17000001")]
	public static SROptions Current
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x9E7980", Offset = "0x9E7980", VA = "0x9E7980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public event SROptionsPropertyChanged PropertyChanged
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x9E7AB8", Offset = "0x9E7AB8", VA = "0x9E7AB8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x9E7B54", Offset = "0x9E7B54", VA = "0x9E7B54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	private event PropertyChangedEventHandler InterfacePropertyChangedEventHandler
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x9E7CA8", Offset = "0x9E7CA8", VA = "0x9E7CA8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x9E7D44", Offset = "0x9E7D44", VA = "0x9E7D44")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	private event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x9E7DE0", Offset = "0x9E7DE0", VA = "0x9E7DE0", Slot = "4")]
		add
		{
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x9E7DE4", Offset = "0x9E7DE4", VA = "0x9E7DE4", Slot = "5")]
		remove
		{
		}
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x9E703C", Offset = "0x9E703C", VA = "0x9E703C")]
	[Sort(0)]
	[Category("Round")]
	[DisplayName("Complete Round")]
	public void CompleteRound()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x9E715C", Offset = "0x9E715C", VA = "0x9E715C")]
	[Sort(1)]
	[Category("Round")]
	[DisplayName("Fail Round")]
	public void FailRound()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x9E727C", Offset = "0x9E727C", VA = "0x9E727C")]
	[Sort(4)]
	[Category("Progression")]
	[DisplayName("Delete Player State")]
	public void DeletePlayerState()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x9E7294", Offset = "0x9E7294", VA = "0x9E7294")]
	[Sort(5)]
	[DisplayName("Money")]
	[Category("Progression")]
	public void AddMoney()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x9E72D8", Offset = "0x9E72D8", VA = "0x9E72D8")]
	[Sort(6)]
	[DisplayName("Unlock All Areas")]
	[Category("Debug")]
	public void UnlockAllAreas()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9E752C", Offset = "0x9E752C", VA = "0x9E752C")]
	[Category("Debug")]
	[Sort(7)]
	[DisplayName("Unlock Next Area")]
	public void UnlockNextArea()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x9E7640", Offset = "0x9E7640", VA = "0x9E7640")]
	[Sort(1)]
	[Category("Localization")]
	[DisplayName("EN")]
	public void LanguageEN()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x9E76A8", Offset = "0x9E76A8", VA = "0x9E76A8")]
	[DisplayName("FR")]
	[Sort(2)]
	[Category("Localization")]
	public void LanguageFR()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x9E7710", Offset = "0x9E7710", VA = "0x9E7710")]
	[DisplayName("GE")]
	[Category("Localization")]
	[Sort(3)]
	public void LanguageGE()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x9E7778", Offset = "0x9E7778", VA = "0x9E7778")]
	[DisplayName("IT")]
	[Category("Localization")]
	[Sort(4)]
	public void LanguageIT()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x9E77E0", Offset = "0x9E77E0", VA = "0x9E77E0")]
	[Sort(5)]
	[Category("Localization")]
	[DisplayName("JP")]
	public void LanguageJP()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x9E7848", Offset = "0x9E7848", VA = "0x9E7848")]
	[DisplayName("KR")]
	[Category("Localization")]
	[Sort(6)]
	public void LanguageKR()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x9E78B0", Offset = "0x9E78B0", VA = "0x9E78B0")]
	[DisplayName("SC")]
	[Category("Localization")]
	[Sort(7)]
	public void LanguageSC()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x9E7918", Offset = "0x9E7918", VA = "0x9E7918")]
	[DisplayName("ES")]
	[Category("Localization")]
	[Sort(8)]
	public void LanguageES()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x9E79D8", Offset = "0x9E79D8", VA = "0x9E79D8")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	public static void OnStartup()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x9E7BF0", Offset = "0x9E7BF0", VA = "0x9E7BF0")]
	public void OnPropertyChanged(string propertyName)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x9E7DE8", Offset = "0x9E7DE8", VA = "0x9E7DE8")]
	public SROptions()
	{
	}
}
[Token(Token = "0x2000008")]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class RingGenerator : MonoBehaviour
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshFilter MeshFilter;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int Angles;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float Radius;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float Thickness;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Color Color;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float StartAngle;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float EndAngle;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector2[] _angles;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _vertices;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Color[] _colors;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int[] _triangles;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float _alpha;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool _isInit;

	[Token(Token = "0x17000002")]
	public float AnimatedThickness
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x9E7ED4", Offset = "0x9E7ED4", VA = "0x9E7ED4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x9E7EDC", Offset = "0x9E7EDC", VA = "0x9E7EDC")]
		set
		{
		}
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x9E7EEC", Offset = "0x9E7EEC", VA = "0x9E7EEC")]
	public float GetStartAngle()
	{
		return default(float);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x9E7EF4", Offset = "0x9E7EF4", VA = "0x9E7EF4")]
	public float GetEndAngle()
	{
		return default(float);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x9E7EFC", Offset = "0x9E7EFC", VA = "0x9E7EFC")]
	public Color GetColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x9E7F08", Offset = "0x9E7F08", VA = "0x9E7F08")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x9E7F0C", Offset = "0x9E7F0C", VA = "0x9E7F0C")]
	public void Init()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x9E84E4", Offset = "0x9E84E4", VA = "0x9E84E4")]
	public void InitIfNeeded()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9E85C4", Offset = "0x9E85C4", VA = "0x9E85C4")]
	public void CalculateAll()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9E825C", Offset = "0x9E825C", VA = "0x9E825C")]
	private void CalculateAngles()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x9E8340", Offset = "0x9E8340", VA = "0x9E8340")]
	private void CalculateVertices()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x9E8448", Offset = "0x9E8448", VA = "0x9E8448")]
	private void CalculateColors()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x9E85EC", Offset = "0x9E85EC", VA = "0x9E85EC")]
	public void SetRadius(float value)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x9E7EE4", Offset = "0x9E7EE4", VA = "0x9E7EE4")]
	public void SetThickness(float value)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x9E85F4", Offset = "0x9E85F4", VA = "0x9E85F4")]
	public void SetRadiusAndThickness(float radius, float thickness)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x9E85FC", Offset = "0x9E85FC", VA = "0x9E85FC")]
	public void SetStartAngle(float value)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x9E8618", Offset = "0x9E8618", VA = "0x9E8618")]
	public void SetEndAngle(float value)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x9E8634", Offset = "0x9E8634", VA = "0x9E8634")]
	public void SetAngles(float startAngle, float endAngle)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x9E8650", Offset = "0x9E8650", VA = "0x9E8650")]
	public void SetColor(Color value)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x9E865C", Offset = "0x9E865C", VA = "0x9E865C")]
	public void SetAlpha(float value)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x9E8664", Offset = "0x9E8664", VA = "0x9E8664")]
	public RingGenerator()
	{
	}
}
[Token(Token = "0x2000009")]
[SelectionBase]
public class SelectionBase : MonoBehaviour
{
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x9E8694", Offset = "0x9E8694", VA = "0x9E8694")]
	public SelectionBase()
	{
	}
}
[Token(Token = "0x200000A")]
public class TMPLinkOpener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x9E869C", Offset = "0x9E869C", VA = "0x9E869C", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x9E87E4", Offset = "0x9E87E4", VA = "0x9E87E4")]
	public TMPLinkOpener()
	{
	}
}
[Token(Token = "0x200000B")]
public class DistanceHint : DynamicObject
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ShapeRenderer[] Shapes;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform _camera;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _maxAlpha;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x9E87EC", Offset = "0x9E87EC", VA = "0x9E87EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x9E8818", Offset = "0x9E8818", VA = "0x9E8818")]
	private void Update()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x9E8A10", Offset = "0x9E8A10", VA = "0x9E8A10", Slot = "4")]
	public override void Activate()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x9E8A34", Offset = "0x9E8A34", VA = "0x9E8A34")]
	public DistanceHint()
	{
	}
}
[Token(Token = "0x200000C")]
public class VersionWidget : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Prefix;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool NewLine;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI Label;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x9E8A44", Offset = "0x9E8A44", VA = "0x9E8A44")]
	private void Start()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x9E8AF0", Offset = "0x9E8AF0", VA = "0x9E8AF0")]
	public VersionWidget()
	{
	}
}
[Token(Token = "0x200000D")]
public delegate void SROptionsPropertyChanged(object sender, string propertyName);
namespace Shapes
{
	[Token(Token = "0x200000E")]
	public class AmmoBar : MonoBehaviour
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int totalBullets;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int bullets;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Style")]
		[Range(0f, 1f)]
		public float bulletThicknessScale;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 0.5f)]
		public float bulletEjectScale;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Animation")]
		public float bulletDisappearTime;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, (float)Math.PI * 2f)]
		public float bulletEjectAngSpeed;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, (float)Math.PI * 2f)]
		public float ejectRotSpeedVariance;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve bulletEjectX;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve bulletEjectY;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] bulletFireTimes;

		[Token(Token = "0x17000003")]
		public bool HasBulletsLeft
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x9E8CFC", Offset = "0x9E8CFC", VA = "0x9E8CFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x9E8C8C", Offset = "0x9E8C8C", VA = "0x9E8C8C")]
		private Vector2 GetBulletEjectPos(Vector2 origin, float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x9E8D0C", Offset = "0x9E8D0C", VA = "0x9E8D0C")]
		public void Fire()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x9E8D58", Offset = "0x9E8D58", VA = "0x9E8D58")]
		public void Reload()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x9E8D64", Offset = "0x9E8D64", VA = "0x9E8D64")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x9E8DB4", Offset = "0x9E8DB4", VA = "0x9E8DB4")]
		public void DrawBar(FpsController fpsController, float barRadius)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x9E9238", Offset = "0x9E9238", VA = "0x9E9238")]
		public AmmoBar()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class ChargeBar : MonoBehaviour
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Gameplay")]
		[SerializeField]
		private float chargeSpeed;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float chargeDecaySpeed;

		[NonSerialized]
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isCharging;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float charge;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Style")]
		public Color tickColor;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Gradient chargeFillGradient;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 0.1f)]
		public float tickSizeSmol;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 0.1f)]
		public float tickSizeLorge;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 0.05f)]
		public float tickTickness;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 0.5f)]
		public float fontSize;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 0.5f)]
		public float fontSizeLorge;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 0.1f)]
		public float percentLabelOffset;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 0.4f)]
		public float fontGrowRangePrev;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 0.4f)]
		public float fontGrowRangeNext;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Animation")]
		public AnimationCurve chargeFillCurve;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve animChargeShakeMagnitude;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 0.05f)]
		public float chargeShakeMagnitude;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float chargeShakeSpeed;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x9E92AC", Offset = "0x9E92AC", VA = "0x9E92AC")]
		public void UpdateCharge()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x9E9314", Offset = "0x9E9314", VA = "0x9E9314")]
		public void DrawBar(FpsController fpsController, float barRadius)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x9E9998", Offset = "0x9E9998", VA = "0x9E9998")]
		public ChargeBar()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class Compass : MonoBehaviour
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 position;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float width;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 0.01f)]
		public float lineThickness;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0.1f, 2f)]
		public float bendRadius;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.05f, 3.0787609f)]
		public float fieldOfView;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Ticks")]
		public int ticksPerQuarterTurn;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 0.2f)]
		public float tickSize;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float tickEdgeFadeFraction;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0.01f, 0.26f)]
		public float fontSizeTickLabel;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 0.1f)]
		public float tickLabelOffset;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0.01f, 0.26f)]
		[Header("Degree Marker")]
		public float fontSizeLookLabel;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2 lookAngLabelOffset;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 0.05f)]
		public float triangleNootSize;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x9E9A04", Offset = "0x9E9A04", VA = "0x9E9A04")]
		public void DrawCompass(Vector3 worldDir)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x9EA274", Offset = "0x9EA274", VA = "0x9EA274")]
		public Compass()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class Crosshair : MonoBehaviour
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 0.05f)]
		[Header("Style")]
		public float crosshairCrossInnerRad;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 0.05f)]
		public float crosshairCrossOuterRad;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 0.05f)]
		public float crosshairCrossThickness;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 0.05f)]
		public float crosshairHitCrossInnerRad;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 0.05f)]
		public float crosshairHitCrossOuterRad;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.05f)]
		public float crosshairHitCrossThickness;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Header("Animation")]
		public float scaleFire;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Decayer fireDecayer;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Decayer hitDecayer;

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x9EA2B0", Offset = "0x9EA2B0", VA = "0x9EA2B0")]
		public void Fire()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x9EA2D0", Offset = "0x9EA2D0", VA = "0x9EA2D0")]
		public void FireHit()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x9EA2F0", Offset = "0x9EA2F0", VA = "0x9EA2F0")]
		public void UpdateCrosshairDecay()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x9EA3AC", Offset = "0x9EA3AC", VA = "0x9EA3AC")]
		public void DrawCrosshair()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x9EAA5C", Offset = "0x9EAA5C", VA = "0x9EAA5C")]
		public Crosshair()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public class Decayer
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float decaySpeed;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float magnitude;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[NonSerialized]
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float value;

		[NonSerialized]
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float valueInv;

		[NonSerialized]
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float t;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x9EAB14", Offset = "0x9EAB14", VA = "0x9EAB14")]
		public void SetT(float v)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x9EA318", Offset = "0x9EA318", VA = "0x9EA318")]
		public void Update()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x9EAB0C", Offset = "0x9EAB0C", VA = "0x9EAB0C")]
		public Decayer()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteAlways]
	public class FpsController : ImmediateModeShapeDrawer
	{
		[Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class <FixedSteps>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FpsController <>4__this;

			[Token(Token = "0x17000005")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000068")]
				[Address(RVA = "0x9EB714", Offset = "0x9EB714", VA = "0x9EB714", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600006A")]
				[Address(RVA = "0x9EB75C", Offset = "0x9EB75C", VA = "0x9EB75C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000065")]
			[Address(RVA = "0x9EAF70", Offset = "0x9EAF70", VA = "0x9EAF70")]
			[DebuggerHidden]
			public <FixedSteps>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000066")]
			[Address(RVA = "0x9EB678", Offset = "0x9EB678", VA = "0x9EB678", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000067")]
			[Address(RVA = "0x9EB67C", Offset = "0x9EB67C", VA = "0x9EB67C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x9EB71C", Offset = "0x9EB71C", VA = "0x9EB71C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Camera cam;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Crosshair crosshair;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ChargeBar chargeBar;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AmmoBar ammoBar;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Compass compass;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform crosshairTransform;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0.8f, 1f)]
		[Header("Player Movement")]
		public float smoof;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float moveSpeed;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lookSensitivity;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float yaw;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float pitch;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector2 moveInput;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 moveVel;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Sidebar Style")]
		[Range(0f, (float)Math.PI)]
		public float ammoBarAngularSpanRad;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 0.05f)]
		public float ammoBarOutlineThickness;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 0.2f)]
		public float ammoBarThickness;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 0.2f)]
		public float ammoBarRadius;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Header("Animation")]
		[Range(0f, 0.3f)]
		public float fireSidebarRadiusPunchAmount;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve shakeAnimX;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AnimationCurve shakeAnimY;

		[Token(Token = "0x17000004")]
		private bool InputFocus
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x9EAF98", Offset = "0x9EAF98", VA = "0x9EAF98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x9EAB6C", Offset = "0x9EAB6C", VA = "0x9EAB6C")]
			set
			{
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x9EAB1C", Offset = "0x9EAB1C", VA = "0x9EAB1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x9EABFC", Offset = "0x9EABFC", VA = "0x9EABFC", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x9EAB94", Offset = "0x9EAB94", VA = "0x9EAB94")]
		[IteratorStateMachine(typeof(<FixedSteps>d__23))]
		private IEnumerator FixedSteps()
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x9E9098", Offset = "0x9E9098", VA = "0x9E9098")]
		public static void DrawRoundedArcOutline(Vector2 origin, float radius, float thickness, float outlineThickness, float angStart, float angEnd)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x9E9920", Offset = "0x9E9920", VA = "0x9E9920")]
		public Vector2 GetShake(float speed, float amp)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x9EAFB4", Offset = "0x9EAFB4", VA = "0x9EAFB4")]
		private void FixedUpdateManual()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x9EB10C", Offset = "0x9EB10C", VA = "0x9EB10C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x9EB580", Offset = "0x9EB580", VA = "0x9EB580")]
		public FpsController()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[ExecuteAlways]
	public class ProceduralTree : ImmediateModeShapeDrawer
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Header("Line Style")]
		[Range(0f, 0.1f)]
		public float lineThickness;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color lineColor;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Tree shape")]
		public int seed;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(1f, 2000f)]
		public int lineCount;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 4f)]
		public int branchesMin;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(1f, 5f)]
		public int branchesMax;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float branchLengthMin;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float branchLengthMax;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, (float)Math.PI)]
		public float maxAngDeviation;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool use3D;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int currentLineCount;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Queue<Matrix4x4> mtxQueue;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x9EB764", Offset = "0x9EB764", VA = "0x9EB764", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x9EB9E8", Offset = "0x9EB9E8", VA = "0x9EB9E8")]
		private void BranchFrom(Matrix4x4 mtx)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x9EBE44", Offset = "0x9EBE44", VA = "0x9EBE44")]
		public ProceduralTree()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteAlways]
	public class SpinningColorDiscs : ImmediateModeShapeDrawer
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(3f, 32f)]
		public int discCount;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float discRadius;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x9EBF00", Offset = "0x9EBF00", VA = "0x9EBF00", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x9EC228", Offset = "0x9EC228", VA = "0x9EC228")]
		private Vector2 GetDiscPosition(float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x9EC298", Offset = "0x9EC298", VA = "0x9EC298")]
		public SpinningColorDiscs()
		{
		}
	}
}
namespace Kilogrames
{
	[Token(Token = "0x2000018")]
	public class OneEuroFilter
	{
		[Token(Token = "0x4000081")]
		private const float DCutOff = 1f;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _prevTimeStamp;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _prevX;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _prevDX;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _isFirstTime;

		[Token(Token = "0x17000007")]
		public float MinCutoff
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x9EC2F0", Offset = "0x9EC2F0", VA = "0x9EC2F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x9EC2F8", Offset = "0x9EC2F8", VA = "0x9EC2F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public float Beta
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x9EC300", Offset = "0x9EC300", VA = "0x9EC300")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x9EC308", Offset = "0x9EC308", VA = "0x9EC308")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x9EC2B0", Offset = "0x9EC2B0", VA = "0x9EC2B0")]
		public OneEuroFilter(float minCutoff, float beta)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x9EC310", Offset = "0x9EC310", VA = "0x9EC310")]
		public float Filter(float timeStamp, float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x9EC3C8", Offset = "0x9EC3C8", VA = "0x9EC3C8")]
		private static float Alpha(float tE, float cutoff)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000019")]
	public class OneEuroFilter3
	{
		[Token(Token = "0x4000088")]
		private const float DCutOff = 1f;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _prevTimeStamp;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 _prevX;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 _prevDX;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool _isFirstTime;

		[Token(Token = "0x17000009")]
		public float MinCutoff
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x9EC428", Offset = "0x9EC428", VA = "0x9EC428")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x9EC430", Offset = "0x9EC430", VA = "0x9EC430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float Beta
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x9EC438", Offset = "0x9EC438", VA = "0x9EC438")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x9EC440", Offset = "0x9EC440", VA = "0x9EC440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x9EC3E8", Offset = "0x9EC3E8", VA = "0x9EC3E8")]
		public OneEuroFilter3(float minCutoff, float beta)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x9EC448", Offset = "0x9EC448", VA = "0x9EC448")]
		public Vector3 Filter(float timeStamp, Vector3 x)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x9EC614", Offset = "0x9EC614", VA = "0x9EC614")]
		private static float Alpha(float tE, float cutoff)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200001A")]
	public class OneEuroFilterQ
	{
		[Token(Token = "0x400008F")]
		private const float DCutOff = 1f;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _prevTimeStamp;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector4 _prevX;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector4 _prevDX;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _isFirstTime;

		[Token(Token = "0x1700000B")]
		public float MinCutoff
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x9EC674", Offset = "0x9EC674", VA = "0x9EC674")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x9EC67C", Offset = "0x9EC67C", VA = "0x9EC67C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public float Beta
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x9EC684", Offset = "0x9EC684", VA = "0x9EC684")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x9EC68C", Offset = "0x9EC68C", VA = "0x9EC68C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x9EC634", Offset = "0x9EC634", VA = "0x9EC634")]
		public OneEuroFilterQ(float minCutoff, float beta)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x9EC694", Offset = "0x9EC694", VA = "0x9EC694")]
		public Quaternion Filter(float timeStamp, Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x9EC884", Offset = "0x9EC884", VA = "0x9EC884")]
		private static float Alpha(float tE, float cutoff)
		{
			return default(float);
		}
	}
}
namespace Kilogrames.VR.Helper
{
	[Token(Token = "0x200001B")]
	public class DeviceSpriteSwitcher : MonoBehaviour
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image[] Images;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite[] Sprites;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x9EC8A4", Offset = "0x9EC8A4", VA = "0x9EC8A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x9EC978", Offset = "0x9EC978", VA = "0x9EC978")]
		public DeviceSpriteSwitcher()
		{
		}
	}
}
namespace EDKG.ArcheryRange
{
	[Token(Token = "0x200001C")]
	public class AnalyticsWrapper : MonoBehaviour
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, object> _levelParameters;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, object> _purchaseParameters;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<string, object> _challengeParameters;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x9EC980", Offset = "0x9EC980", VA = "0x9EC980")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x9ECE90", Offset = "0x9ECE90", VA = "0x9ECE90")]
		public static void ReportLevelStart(int id)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x9ED214", Offset = "0x9ED214", VA = "0x9ED214")]
		public static void ReportLevelComplete(int id)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x9ED598", Offset = "0x9ED598", VA = "0x9ED598")]
		public static void ReportLevelFail(int id)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x9ED91C", Offset = "0x9ED91C", VA = "0x9ED91C")]
		public static void ReportLevelSkip(int id)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x9EDCA0", Offset = "0x9EDCA0", VA = "0x9EDCA0")]
		public static void ReportBowPurchased(int id, int totalStars, int totalCoins, int latestUnlockedLevel)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x9EDEBC", Offset = "0x9EDEBC", VA = "0x9EDEBC")]
		public static void ReportArrowPurchased(int id, int totalStars, int totalCoins, int latestUnlockedLevel)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x9EE0D8", Offset = "0x9EE0D8", VA = "0x9EE0D8")]
		public static void ReportChallengeStart(int id)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x9EE458", Offset = "0x9EE458", VA = "0x9EE458")]
		public static void ReportChallengeComplete(int id)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x9EE7D8", Offset = "0x9EE7D8", VA = "0x9EE7D8")]
		public AnalyticsWrapper()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Crosshair : MonoBehaviour
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RingGenerator BaseRing;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color NoFatigueColor;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color FullFatigueColor;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MinThickness;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MaxThickness;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _size;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _alpha;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _visibility;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _fatigue;

		[Token(Token = "0x1700000D")]
		public float Alpha
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x9EE8BC", Offset = "0x9EE8BC", VA = "0x9EE8BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x9EE8C4", Offset = "0x9EE8C4", VA = "0x9EE8C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public float Visibility
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x9EE908", Offset = "0x9EE908", VA = "0x9EE908")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x9EE910", Offset = "0x9EE910", VA = "0x9EE910")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float Size
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x9EE92C", Offset = "0x9EE92C", VA = "0x9EE92C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x9EE934", Offset = "0x9EE934", VA = "0x9EE934")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float Fatigue
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x9EE990", Offset = "0x9EE990", VA = "0x9EE990")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x9EE998", Offset = "0x9EE998", VA = "0x9EE998")]
			set
			{
			}
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x9EE8E0", Offset = "0x9EE8E0", VA = "0x9EE8E0")]
		private void UpdateTransparency()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x9EEA68", Offset = "0x9EEA68", VA = "0x9EEA68")]
		public Crosshair()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class AudioManager : MonoBehaviour
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static AudioManager Instance;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MusicPlayer MusicPlayer;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIAudioPlayer UIPlayer;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MiscUIAudioPlayer MiscUIPlayer;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioMixer Mixer;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _masterVolume;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _musicVolume;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _internalMute;

		[Token(Token = "0x40000AA")]
		private const float MinVolume = -35f;

		[Token(Token = "0x40000AB")]
		private const float VolumeSpan = 35f;

		[Token(Token = "0x40000AC")]
		private const float MuteVolume = -80f;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x9EEA94", Offset = "0x9EEA94", VA = "0x9EEA94")]
		private void Awake()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x9EEBF4", Offset = "0x9EEBF4", VA = "0x9EEBF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x9EECB4", Offset = "0x9EECB4", VA = "0x9EECB4")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9EED14", Offset = "0x9EED14", VA = "0x9EED14")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x9EED8C", Offset = "0x9EED8C", VA = "0x9EED8C")]
		public void SetMasterVolume(float value, bool instant = false)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x9EEE28", Offset = "0x9EEE28", VA = "0x9EEE28")]
		private void UpdateMasterVolume(bool instant = false)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x9EED98", Offset = "0x9EED98", VA = "0x9EED98")]
		public void SetMusicVolume(float value, bool instant = false)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x9EEEEC", Offset = "0x9EEEEC", VA = "0x9EEEEC")]
		private void UpdateMusicVolume(bool instant = false)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x9EECE0", Offset = "0x9EECE0", VA = "0x9EECE0")]
		public void ToggleInternalMute(int value = -1)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x9EEFA8", Offset = "0x9EEFA8", VA = "0x9EEFA8")]
		public void OnMasterVolumeChangedEvent(float value)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x9EEFB4", Offset = "0x9EEFB4", VA = "0x9EEFB4")]
		private void OnMusicVolumeChangedEvent(float value)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x9EEFC0", Offset = "0x9EEFC0", VA = "0x9EEFC0")]
		public AudioManager()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class AudioSourcePool : MonoBehaviour
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource SingleSource;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int SourcePoolSize;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _isInactive;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource[] _sourcePool;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _lastSourceId;

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x9EEFD8", Offset = "0x9EEFD8", VA = "0x9EEFD8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x9EF1DC", Offset = "0x9EF1DC", VA = "0x9EF1DC")]
		protected AudioSource FindSource()
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x9EF234", Offset = "0x9EF234", VA = "0x9EF234")]
		public AudioSource PlaySpatialClip(AudioClip clip, Vector3 pos, float pitch = 1f, float volume = 1f)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x9EF354", Offset = "0x9EF354", VA = "0x9EF354")]
		public AudioSource PlayClip(AudioClip clip, float pitch = 1f, float volume = 1f)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x9EF434", Offset = "0x9EF434", VA = "0x9EF434")]
		public AudioSource PlayClipRandom(AudioClip clip, float pitchDelta = 0f, float pitchOffset = 0f, float volumeDelta = 0f, float volumeOffset = 0f)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x9EF4AC", Offset = "0x9EF4AC", VA = "0x9EF4AC")]
		public AudioSource PlayClipRandomPresetVolume(AudioClip clip, float defaultPitch, float pitchDelta = 0f, float pitchOffset = 0f, float defaultVolume = 1f, float volumeDelta = 0f, float volumeOffset = 0f)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x9EF52C", Offset = "0x9EF52C", VA = "0x9EF52C")]
		public AudioSourcePool()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class MusicPlayer : MonoBehaviour
	{
		[Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class <PlayMenuTrack>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MusicPlayer <>4__this;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000BD")]
				[Address(RVA = "0x9EFB20", Offset = "0x9EFB20", VA = "0x9EFB20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BF")]
				[Address(RVA = "0x9EFB68", Offset = "0x9EFB68", VA = "0x9EFB68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x9EF784", Offset = "0x9EF784", VA = "0x9EF784")]
			[DebuggerHidden]
			public <PlayMenuTrack>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x9EF99C", Offset = "0x9EF99C", VA = "0x9EF99C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x9EF9A0", Offset = "0x9EF9A0", VA = "0x9EF9A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x9EFB28", Offset = "0x9EFB28", VA = "0x9EFB28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class <StopMenuSourceCoroutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MusicPlayer <>4__this;

			[Token(Token = "0x17000013")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C3")]
				[Address(RVA = "0x9EFC2C", Offset = "0x9EFC2C", VA = "0x9EFC2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C5")]
				[Address(RVA = "0x9EFC74", Offset = "0x9EFC74", VA = "0x9EFC74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x9EF824", Offset = "0x9EF824", VA = "0x9EF824")]
			[DebuggerHidden]
			public <StopMenuSourceCoroutine>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x9EFB70", Offset = "0x9EFB70", VA = "0x9EFB70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x9EFB74", Offset = "0x9EFB74", VA = "0x9EFB74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x9EFC34", Offset = "0x9EFC34", VA = "0x9EFC34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class <PlayGameTrack>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MusicPlayer <>4__this;

			[Token(Token = "0x17000015")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C9")]
				[Address(RVA = "0x9EFE00", Offset = "0x9EFE00", VA = "0x9EFE00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000016")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000CB")]
				[Address(RVA = "0x9EFE48", Offset = "0x9EFE48", VA = "0x9EFE48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x9EF8B4", Offset = "0x9EF8B4", VA = "0x9EF8B4")]
			[DebuggerHidden]
			public <PlayGameTrack>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x9EFC7C", Offset = "0x9EFC7C", VA = "0x9EFC7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x9EFC80", Offset = "0x9EFC80", VA = "0x9EFC80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x9EFE08", Offset = "0x9EFE08", VA = "0x9EFE08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class <StopGameSourceCoroutine>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MusicPlayer <>4__this;

			[Token(Token = "0x17000017")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000CF")]
				[Address(RVA = "0x9EFF0C", Offset = "0x9EFF0C", VA = "0x9EFF0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000018")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D1")]
				[Address(RVA = "0x9EFF54", Offset = "0x9EFF54", VA = "0x9EFF54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x9EF954", Offset = "0x9EF954", VA = "0x9EF954")]
			[DebuggerHidden]
			public <StopGameSourceCoroutine>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x9EFE50", Offset = "0x9EFE50", VA = "0x9EFE50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x9EFE54", Offset = "0x9EFE54", VA = "0x9EFE54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x9EFF14", Offset = "0x9EFF14", VA = "0x9EFF14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioMixer Mixer;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioMixerSnapshot[] Snapshots;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip[] MenuTracks;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip[] GameTracks;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource MenuSource;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioSource GameSource;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int MenuStartTrack;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool MenuRandomOrder;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int GameStartTrack;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool GameRandomOrder;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _type;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _menuTrack;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _menuTrackTime;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _gameTrack;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _gameTrackTime;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Coroutine _menuTrackCoroutine;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine _gameTrackCoroutine;

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x9EEDA4", Offset = "0x9EEDA4", VA = "0x9EEDA4")]
		public void ChangeType(int type)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x9EF544", Offset = "0x9EF544", VA = "0x9EF544")]
		private void StartMenuTrack()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x9EF71C", Offset = "0x9EF71C", VA = "0x9EF71C")]
		[IteratorStateMachine(typeof(<PlayMenuTrack>d__19))]
		private IEnumerator PlayMenuTrack()
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x9EF6BC", Offset = "0x9EF6BC", VA = "0x9EF6BC")]
		private void StopMenuTrack(float time)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x9EF7AC", Offset = "0x9EF7AC", VA = "0x9EF7AC")]
		[IteratorStateMachine(typeof(<StopMenuSourceCoroutine>d__21))]
		private IEnumerator StopMenuSourceCoroutine(float time)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x9EF630", Offset = "0x9EF630", VA = "0x9EF630")]
		private void StartGameTrack()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x9EF84C", Offset = "0x9EF84C", VA = "0x9EF84C")]
		[IteratorStateMachine(typeof(<PlayGameTrack>d__23))]
		private IEnumerator PlayGameTrack()
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x9EF5D0", Offset = "0x9EF5D0", VA = "0x9EF5D0")]
		private void StopGameTrack(float time)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9EF8DC", Offset = "0x9EF8DC", VA = "0x9EF8DC")]
		[IteratorStateMachine(typeof(<StopGameSourceCoroutine>d__25))]
		private IEnumerator StopGameSourceCoroutine(float time)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x9EF97C", Offset = "0x9EF97C", VA = "0x9EF97C")]
		public MusicPlayer()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class UIAudioPlayer : AudioSourcePool
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip ClickSnd;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip OpenSnd;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip CloseSnd;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip LongOpenSnd;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip LongCloseSnd;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x9EFF5C", Offset = "0x9EFF5C", VA = "0x9EFF5C")]
		public void PlayClick()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x9EFF6C", Offset = "0x9EFF6C", VA = "0x9EFF6C")]
		public void PlayOpenWindow()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x9EFF7C", Offset = "0x9EFF7C", VA = "0x9EFF7C")]
		public void PlayCloseWindow()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x9EFF8C", Offset = "0x9EFF8C", VA = "0x9EFF8C")]
		public void PlayLongOpen()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x9EFF9C", Offset = "0x9EFF9C", VA = "0x9EFF9C")]
		public void PlayLongClose()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x9EFFAC", Offset = "0x9EFFAC", VA = "0x9EFFAC")]
		public UIAudioPlayer()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class RandomSound : AudioSourcePool
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip[] Clips;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float PitchDelta;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float PitchOffset;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float VolumeDelta;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float VolumeOffset;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _lastClipId;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x9EFFC4", Offset = "0x9EFFC4", VA = "0x9EFFC4")]
		public void Play(int id = -1)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x9F0058", Offset = "0x9F0058", VA = "0x9F0058")]
		public void PlayVolume(int id = -1, float pitch = 1f, float volume = 1f)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x9F0104", Offset = "0x9F0104", VA = "0x9F0104")]
		public RandomSound()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class RagdollAudioPlayer : RandomSound
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _lastVelocity;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 _lastAngularVelocity;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _velocityThreshold;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _velocityChangeThreshold;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _maxVelocity;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x9F011C", Offset = "0x9F011C", VA = "0x9F011C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x9F0174", Offset = "0x9F0174", VA = "0x9F0174")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x9F0184", Offset = "0x9F0184", VA = "0x9F0184")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x9F0390", Offset = "0x9F0390", VA = "0x9F0390")]
		public RagdollAudioPlayer()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class DynamicDistanceCrosshairController : MonoBehaviour
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRCrosshairController CrosshairController;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask ColliderLayerMask;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRShootingController _shootingController;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isActive;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _isCrosshairNeedsUpdating;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _arrowLength;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _targetDistance;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _filteredDistance;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x9F03C0", Offset = "0x9F03C0", VA = "0x9F03C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x9F072C", Offset = "0x9F072C", VA = "0x9F072C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x9F0A54", Offset = "0x9F0A54", VA = "0x9F0A54")]
		[ContextMenu("Refresh")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x9F0AF8", Offset = "0x9F0AF8", VA = "0x9F0AF8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x9F0B8C", Offset = "0x9F0B8C", VA = "0x9F0B8C")]
		private float UpdateCollisions()
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x9F0CD8", Offset = "0x9F0CD8", VA = "0x9F0CD8")]
		private void OnStartDrawingEvent()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x9F0CE4", Offset = "0x9F0CE4", VA = "0x9F0CE4")]
		private void OnShootEvent()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x9F0CEC", Offset = "0x9F0CEC", VA = "0x9F0CEC")]
		private void OnCancelEvent()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x9F0CF4", Offset = "0x9F0CF4", VA = "0x9F0CF4")]
		public DynamicDistanceCrosshairController()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class VRCrosshairController : MonoBehaviour
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Crosshair Crosshair1;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DistanceFromArrow;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRShootingController _shootingController;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _noAccuracy;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _maxAccuracy;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isShootingControllerNull;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isFollowing;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Tween _sizeTween;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Tween _alphaTween;

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x9F0D08", Offset = "0x9F0D08", VA = "0x9F0D08")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x9F1438", Offset = "0x9F1438", VA = "0x9F1438")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x9F1AF8", Offset = "0x9F1AF8", VA = "0x9F1AF8")]
		private void OnCrosshairToggle()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x9F1B54", Offset = "0x9F1B54", VA = "0x9F1B54")]
		private void OnCrosshairChanged(int value)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x9F0A70", Offset = "0x9F0A70", VA = "0x9F0A70")]
		public void SetDynamicCrosshairDistance(float value)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x9F1C58", Offset = "0x9F1C58", VA = "0x9F1C58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x9F1DE0", Offset = "0x9F1DE0", VA = "0x9F1DE0")]
		private void OnStaminaAndFatigueChangingEvent(float stamina, float fatigue)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x9F1DFC", Offset = "0x9F1DFC", VA = "0x9F1DFC")]
		private void OnInitEvent()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x9F1B88", Offset = "0x9F1B88", VA = "0x9F1B88")]
		[ContextMenu("Calculate Accuracy Values")]
		private void CalculateAccuracyValues()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x9F1E30", Offset = "0x9F1E30", VA = "0x9F1E30")]
		private void OnIdleEvent()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x9F1E60", Offset = "0x9F1E60", VA = "0x9F1E60")]
		private void OnStartDrawingEvent()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x9F1E6C", Offset = "0x9F1E6C", VA = "0x9F1E6C")]
		private void OnShootEvent()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x9F1F78", Offset = "0x9F1F78", VA = "0x9F1F78")]
		private void OnCancelEvent()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x9F2084", Offset = "0x9F2084", VA = "0x9F2084")]
		private void OnRearmEvent(int ammo, int realAmmo)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x9F2088", Offset = "0x9F2088", VA = "0x9F2088")]
		private void OnNoAmmoEvent(int ammo)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x9F208C", Offset = "0x9F208C", VA = "0x9F208C")]
		public VRCrosshairController()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class VRShootingController : MonoBehaviour
	{
		[Token(Token = "0x200002B")]
		private enum ControllerState
		{
			[Token(Token = "0x4000120")]
			Init,
			[Token(Token = "0x4000121")]
			Idle,
			[Token(Token = "0x4000122")]
			Drawing,
			[Token(Token = "0x4000123")]
			Shooting,
			[Token(Token = "0x4000124")]
			Canceling,
			[Token(Token = "0x4000125")]
			Reloading
		}

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AllEquipmentLoader AllEquipmentLoader;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DrawnThreshold;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private ControllerState _curState;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isDrawn;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _drawingProgress;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _rawDrawingProgress;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _drawingProgressWithFatigue;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isNocked;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private EquipmentStats _equipmentStats;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _arrowShotPivot;

		[Token(Token = "0x4000106")]
		private const float BaseShootSpeed = 10f;

		[Token(Token = "0x4000107")]
		private const float BaseCancelSpeed = 10f;

		[Token(Token = "0x4000108")]
		private const float BaseFatigueSpeed = 0.2f;

		[Token(Token = "0x4000109")]
		private const float BaseFatiguePercent = 0.5f;

		[Token(Token = "0x400010A")]
		private const float BaseStaminaRestoreSpeed = 4f;

		[Token(Token = "0x400010B")]
		private const float BaseShakeAmplitude = 0.033f;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _finalMinAccuracyAngle;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _finalMaxAccuracyAngle;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _finalNoAccuracyAngle;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _finalArrowSpeed;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _finalShootSpeed;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _finalCancelSpeed;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _finalFatigueSpeed;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _finalFatiguePercent;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _finalStamina;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _finalStaminaRestoreSpeed;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _finalShakeAmplitude;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private SpawnPool _arrowPool;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform _arrowPrefab;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _maxTargetDistance;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _stamina;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _fatigue;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _shakePercent;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _debugUnlimitedStamina;

		[Token(Token = "0x17000019")]
		public Transform ArrowShotPivot
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x9F25F0", Offset = "0x9F25F0", VA = "0x9F25F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public bool IsChangingDraw
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x9F1C48", Offset = "0x9F1C48", VA = "0x9F1C48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public float DrawingProgress
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x9F25F8", Offset = "0x9F25F8", VA = "0x9F25F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001C")]
		public float DrawingProgressWithFatigue
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x9F2600", Offset = "0x9F2600", VA = "0x9F2600")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public float NoAccuracyAngle
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x9F2608", Offset = "0x9F2608", VA = "0x9F2608")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001E")]
		public float MaxAccuracyAngle
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x9F2610", Offset = "0x9F2610", VA = "0x9F2610")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001F")]
		public float ArrowSpeed
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x9F2618", Offset = "0x9F2618", VA = "0x9F2618")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000020")]
		public float StaminaPercent
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x9F2620", Offset = "0x9F2620", VA = "0x9F2620")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public float ShakePercent
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x9F2630", Offset = "0x9F2630", VA = "0x9F2630")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x14000004")]
		public static event Action OnInit
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x9F11F4", Offset = "0x9F11F4", VA = "0x9F11F4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x9F18B4", Offset = "0x9F18B4", VA = "0x9F18B4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public static event Action OnIdle
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x9F12AC", Offset = "0x9F12AC", VA = "0x9F12AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x9F196C", Offset = "0x9F196C", VA = "0x9F196C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public static event Action OnNocked
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x9F2138", Offset = "0x9F2138", VA = "0x9F2138")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x9F21F4", Offset = "0x9F21F4", VA = "0x9F21F4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public static event Action OnStartDrawing
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x9F04F8", Offset = "0x9F04F8", VA = "0x9F04F8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x9F0820", Offset = "0x9F0820", VA = "0x9F0820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public static event Action<float, float> OnDrawChanging
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x9F22B0", Offset = "0x9F22B0", VA = "0x9F22B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x9F2380", Offset = "0x9F2380", VA = "0x9F2380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public static event Action OnShoot
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x9F05B4", Offset = "0x9F05B4", VA = "0x9F05B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x9F08DC", Offset = "0x9F08DC", VA = "0x9F08DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public static event Action OnCancel
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x9F0670", Offset = "0x9F0670", VA = "0x9F0670")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x9F0998", Offset = "0x9F0998", VA = "0x9F0998")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public static event Action<float, float> OnStaminaAndFatigueChanging
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x9F1368", Offset = "0x9F1368", VA = "0x9F1368")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x9F1A28", Offset = "0x9F1A28", VA = "0x9F1A28")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public static event Action<float, float> OnShakingChanging
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x9F2450", Offset = "0x9F2450", VA = "0x9F2450")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x9F2520", Offset = "0x9F2520", VA = "0x9F2520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x9F2638", Offset = "0x9F2638", VA = "0x9F2638")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x9F2984", Offset = "0x9F2984", VA = "0x9F2984")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x9F2C80", Offset = "0x9F2C80", VA = "0x9F2C80")]
		private void Start()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x9F2E50", Offset = "0x9F2E50", VA = "0x9F2E50")]
		private void Update()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x9F2F78", Offset = "0x9F2F78", VA = "0x9F2F78")]
		private void OnNockedEvent()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x9F2FE8", Offset = "0x9F2FE8", VA = "0x9F2FE8")]
		private void OnStartDrawingEvent()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x9F3060", Offset = "0x9F3060", VA = "0x9F3060")]
		private void OnDrawingEvent(Vector3 vector, float pullDistance, float pullDistanceFromHandle, float amount, float calibratedPullDistance, float calibratedAmount)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x9F3260", Offset = "0x9F3260", VA = "0x9F3260")]
		private void OnReleaseEvent(float amount)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x9F2E54", Offset = "0x9F2E54", VA = "0x9F2E54")]
		private void ProcessDrawing()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x9F3110", Offset = "0x9F3110", VA = "0x9F3110")]
		private void ProcessStaminaAndFatigue()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x9F357C", Offset = "0x9F357C", VA = "0x9F357C")]
		private void ProcessShaking()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x9F3280", Offset = "0x9F3280", VA = "0x9F3280")]
		private void Shoot()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x9F34FC", Offset = "0x9F34FC", VA = "0x9F34FC")]
		public void CancelShot()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x9F35F8", Offset = "0x9F35F8", VA = "0x9F35F8")]
		public VRShootingController()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class DebugCamera : MonoBehaviour
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x9F3610", Offset = "0x9F3610", VA = "0x9F3610")]
		private void Start()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x9F3734", Offset = "0x9F3734", VA = "0x9F3734")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x9F37D8", Offset = "0x9F37D8", VA = "0x9F37D8")]
		private void OnAnotherSceneLoadedEvent(Scene s, LoadSceneMode l)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x9F3884", Offset = "0x9F3884", VA = "0x9F3884")]
		public DebugCamera()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class DebugQualityController : MonoBehaviour
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Slider Slider;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlayerSettingsState _settings;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x9F388C", Offset = "0x9F388C", VA = "0x9F388C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x9F38B4", Offset = "0x9F38B4", VA = "0x9F38B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x9F3970", Offset = "0x9F3970", VA = "0x9F3970")]
		public void OnQuality(float value)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x9F3ADC", Offset = "0x9F3ADC", VA = "0x9F3ADC")]
		public DebugQualityController()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class DebugTargetHitEffectController : MonoBehaviour
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int TargetHitEffectVersion;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Slider Slider;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ImpactNotification[] Prefab;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ImpactNotificationManager _impactNotificationManager;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x9F3AE4", Offset = "0x9F3AE4", VA = "0x9F3AE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x9F3B54", Offset = "0x9F3B54", VA = "0x9F3B54")]
		private void Start()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x9F3C78", Offset = "0x9F3C78", VA = "0x9F3C78")]
		private void RefreshLabel()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x9F3D5C", Offset = "0x9F3D5C", VA = "0x9F3D5C")]
		public void OnValueChanged(float value)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x9F3BE4", Offset = "0x9F3BE4", VA = "0x9F3BE4")]
		private void UpdateValue(int value)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x9F3E40", Offset = "0x9F3E40", VA = "0x9F3E40")]
		public DebugTargetHitEffectController()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class DebugTestSceneLoader : MonoBehaviour
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x9F3E94", Offset = "0x9F3E94", VA = "0x9F3E94")]
		public void LoadTestScene()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x9F3F90", Offset = "0x9F3F90", VA = "0x9F3F90")]
		public DebugTestSceneLoader()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class RestartScene : MonoBehaviour
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x9F3F98", Offset = "0x9F3F98", VA = "0x9F3F98")]
		public void OnRestartScene()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x9F4008", Offset = "0x9F4008", VA = "0x9F4008")]
		public RestartScene()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class TimeController : MonoBehaviour
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float NormalTime;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float _oldNormalTime;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _isFrozen;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<float> OnFreezeNormalTime;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<float> OnResetNormalTime;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<float> OnSetNormalTimeInternally;

		[Token(Token = "0x17000022")]
		public static bool IsFrozen
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x9F4010", Offset = "0x9F4010", VA = "0x9F4010")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x9F4068", Offset = "0x9F4068", VA = "0x9F4068")]
		public static void SetNormalTime(float value)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x9F40D4", Offset = "0x9F40D4", VA = "0x9F40D4")]
		public static void ResetNormalTime()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x9F4180", Offset = "0x9F4180", VA = "0x9F4180")]
		public static void ToggleFreezeNormalTime()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x9F4270", Offset = "0x9F4270", VA = "0x9F4270")]
		private void Update()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x9F4400", Offset = "0x9F4400", VA = "0x9F4400")]
		private void SetNormalTimeInternal(float value)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x9F44A4", Offset = "0x9F44A4", VA = "0x9F44A4")]
		public TimeController()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class TimeControllerUi : MonoBehaviour
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Slider NormalTime;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI NormalTimeLabel;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image FreezeButton;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color ActiveFreezeColor;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color _defaultFreezeColor;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x9F44F8", Offset = "0x9F44F8", VA = "0x9F44F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x9F47D8", Offset = "0x9F47D8", VA = "0x9F47D8")]
		public void OnValueChanged(float value)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x9F4884", Offset = "0x9F4884", VA = "0x9F4884")]
		public void OnResetNormalTimeBtn()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x9F48D0", Offset = "0x9F48D0", VA = "0x9F48D0")]
		public void OnToggleFreezeNormalTimeBtn()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x9F491C", Offset = "0x9F491C", VA = "0x9F491C")]
		private void OnResetNormalTimeEvent(float value)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x9F4A74", Offset = "0x9F4A74", VA = "0x9F4A74")]
		private void OnFreezeNormalTimeEvent(float value)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x9F4BCC", Offset = "0x9F4BCC", VA = "0x9F4BCC")]
		private void OnSetNormalTimeInternallyEvent(float value)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x9F4C94", Offset = "0x9F4C94", VA = "0x9F4C94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x9F4EE4", Offset = "0x9F4EE4", VA = "0x9F4EE4")]
		public TimeControllerUi()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class ToggleComponent : MonoBehaviour
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Behaviour Component;

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x9F4EEC", Offset = "0x9F4EEC", VA = "0x9F4EEC")]
		public void ToggleState()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x9F4F20", Offset = "0x9F4F20", VA = "0x9F4F20")]
		public void SetState(bool value)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x9F4F40", Offset = "0x9F4F40", VA = "0x9F4F40")]
		public ToggleComponent()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class ToggleGameObject : MonoBehaviour
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x9F4F48", Offset = "0x9F4F48", VA = "0x9F4F48")]
		public void ToggleState()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x9F4F9C", Offset = "0x9F4F9C", VA = "0x9F4F9C")]
		public void SetState(bool value)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x9F4FC4", Offset = "0x9F4FC4", VA = "0x9F4FC4")]
		public ToggleGameObject()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class ArmLengthCalibration : MonoBehaviour
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<float, float> OnCalibrationComplete;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<bool, bool> OnTriggerPulled;

		[Token(Token = "0x400013C")]
		private const float _distanceReference = 0.79f;

		[Token(Token = "0x400013D")]
		public const float _minCalibration = 0.5f;

		[Token(Token = "0x400013E")]
		public const float _maxCalibration = 1f;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference LeftTrigger;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference RightTrigger;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InputAction _leftTriggerAction;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private InputAction _rightTriggerAction;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Body _body;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isLeftTriggerPulled;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool _isRightTriggerPulled;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _calibration;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isCalibrated;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _distanceAverage;

		[Token(Token = "0x17000023")]
		public float Calibration
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x9F4FCC", Offset = "0x9F4FCC", VA = "0x9F4FCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x9F4FD4", Offset = "0x9F4FD4", VA = "0x9F4FD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x9F51BC", Offset = "0x9F51BC", VA = "0x9F51BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x9F5334", Offset = "0x9F5334", VA = "0x9F5334")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x9F5364", Offset = "0x9F5364", VA = "0x9F5364")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x9F5394", Offset = "0x9F5394", VA = "0x9F5394")]
		private void OnLeftTriggerActionP(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x9F5440", Offset = "0x9F5440", VA = "0x9F5440")]
		private void OnLeftTriggerActionC(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x9F5468", Offset = "0x9F5468", VA = "0x9F5468")]
		private void OnRightTriggerActionP(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x9F54A8", Offset = "0x9F54A8", VA = "0x9F54A8")]
		private void OnRightTriggerActionC(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x9F53D4", Offset = "0x9F53D4", VA = "0x9F53D4")]
		private void CheckIfBothTriggersPulled()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x9F54D0", Offset = "0x9F54D0", VA = "0x9F54D0")]
		private void CapturePose()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x9F5698", Offset = "0x9F5698", VA = "0x9F5698")]
		public ArmLengthCalibration()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class BillboardManager : MonoBehaviour
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Target;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RandomAngle;

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x9F56A8", Offset = "0x9F56A8", VA = "0x9F56A8")]
		[ContextMenu("Rotate towards Target")]
		private void ProcessBillboards()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x9F57F8", Offset = "0x9F57F8", VA = "0x9F57F8")]
		[ContextMenu("Reset rotation")]
		private void ResetRotation()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x9F58B8", Offset = "0x9F58B8", VA = "0x9F58B8")]
		public BillboardManager()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(CanvasGroup))]
	public class CanvasGroupButton : MonoBehaviour
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float InactiveAlpha;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Button _button;

		[Token(Token = "0x17000024")]
		public bool Interactable
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x9F5944", Offset = "0x9F5944", VA = "0x9F5944")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x9F5960", Offset = "0x9F5960", VA = "0x9F5960")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public float Alpha
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x9F59B4", Offset = "0x9F59B4", VA = "0x9F59B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x9F59D0", Offset = "0x9F59D0", VA = "0x9F59D0")]
			set
			{
			}
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x9F58C8", Offset = "0x9F58C8", VA = "0x9F58C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x9F59EC", Offset = "0x9F59EC", VA = "0x9F59EC")]
		public void SetActive(bool value)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x9F5A14", Offset = "0x9F5A14", VA = "0x9F5A14")]
		public CanvasGroupButton()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class ContinueButton : MonoBehaviour
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool JustLeftControllerOption;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputActionReference ContinueButtonLeftAction;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InputAction _continueButtonLeftAction;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference ContinueButtonRightAction;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InputAction _continueButtonRightAction;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent OnContinueButton;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Sprite[] Sprites;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Image Image;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Image Image2;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _pressedOnce;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _pressedLeft;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool _pressedRight;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x9F5A24", Offset = "0x9F5A24", VA = "0x9F5A24")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x9F5A68", Offset = "0x9F5A68", VA = "0x9F5A68")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x9F5C90", Offset = "0x9F5C90", VA = "0x9F5C90")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x9F5FB4", Offset = "0x9F5FB4", VA = "0x9F5FB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x9F61FC", Offset = "0x9F61FC", VA = "0x9F61FC")]
		private void OnContinueButtonLeftPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x9F6284", Offset = "0x9F6284", VA = "0x9F6284")]
		private void OnContinueButtonLeftStarted(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x9F6314", Offset = "0x9F6314", VA = "0x9F6314")]
		private void OnContinueButtonLeftCanceled(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x9F63A8", Offset = "0x9F63A8", VA = "0x9F63A8")]
		private void OnContinueButtonRightPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x9F6428", Offset = "0x9F6428", VA = "0x9F6428")]
		private void OnContinueButtonRightStarted(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x9F64B0", Offset = "0x9F64B0", VA = "0x9F64B0")]
		private void OnContinueButtonRightCanceled(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x9F653C", Offset = "0x9F653C", VA = "0x9F653C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x9F65D4", Offset = "0x9F65D4", VA = "0x9F65D4")]
		public ContinueButton()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class FpsCounter : MonoBehaviour
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool Needed;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float UpdateInterval;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Prefix;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _accumulated;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _frames;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _timeLeft;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _fps;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x9F65DC", Offset = "0x9F65DC", VA = "0x9F65DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x9F6660", Offset = "0x9F6660", VA = "0x9F6660")]
		private void Update()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x9F6824", Offset = "0x9F6824", VA = "0x9F6824")]
		public FpsCounter()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class GamePauser : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<bool> OnGamePaused;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _isGamePaused;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Tween _tween;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x9F68C8", Offset = "0x9F68C8", VA = "0x9F68C8")]
		public void Pause(bool value)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x9F6A74", Offset = "0x9F6A74", VA = "0x9F6A74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x9F6A84", Offset = "0x9F6A84", VA = "0x9F6A84")]
		public GamePauser()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class NumberShortener
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x9F6B00", Offset = "0x9F6B00", VA = "0x9F6B00")]
		public static string Shorten(float value)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x9F6BD8", Offset = "0x9F6BD8", VA = "0x9F6BD8")]
		public static string Shorten(int value)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x9F6CC0", Offset = "0x9F6CC0", VA = "0x9F6CC0")]
		public NumberShortener()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class PlayerPrefsX
	{
		[Token(Token = "0x200003E")]
		private enum ArrayType
		{
			[Token(Token = "0x400016C")]
			Float,
			[Token(Token = "0x400016D")]
			Int32,
			[Token(Token = "0x400016E")]
			Bool,
			[Token(Token = "0x400016F")]
			String,
			[Token(Token = "0x4000170")]
			Vector2,
			[Token(Token = "0x4000171")]
			Vector3,
			[Token(Token = "0x4000172")]
			Quaternion,
			[Token(Token = "0x4000173")]
			Color
		}

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int endianDiff1;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int endianDiff2;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int idx;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static byte[] byteBlock;

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x9F6CC8", Offset = "0x9F6CC8", VA = "0x9F6CC8")]
		public static bool SetBool(string name, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x9F6D58", Offset = "0x9F6D58", VA = "0x9F6D58")]
		public static bool GetBool(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x9F6D74", Offset = "0x9F6D74", VA = "0x9F6D74")]
		public static bool GetBool(string name, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x9F6DB4", Offset = "0x9F6DB4", VA = "0x9F6DB4")]
		public static bool SetVector2(string key, Vector2 vector)
		{
			return default(bool);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x9F6EEC", Offset = "0x9F6EEC", VA = "0x9F6EEC")]
		private static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x9F7064", Offset = "0x9F7064", VA = "0x9F7064")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x9F70A8", Offset = "0x9F70A8", VA = "0x9F70A8")]
		public static bool SetVector3(string key, Vector3 vector)
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x9F7148", Offset = "0x9F7148", VA = "0x9F7148")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x9F71C0", Offset = "0x9F71C0", VA = "0x9F71C0")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x9F7218", Offset = "0x9F7218", VA = "0x9F7218")]
		public static bool SetQuaternion(string key, Quaternion vector)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x9F72C8", Offset = "0x9F72C8", VA = "0x9F72C8")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x9F734C", Offset = "0x9F734C", VA = "0x9F734C")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x9F73B0", Offset = "0x9F73B0", VA = "0x9F73B0")]
		public static bool SetColor(string key, Color color)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x9F7460", Offset = "0x9F7460", VA = "0x9F7460")]
		public static Color GetColor(string key)
		{
			return default(Color);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x9F749C", Offset = "0x9F749C", VA = "0x9F749C")]
		public static Color GetColor(string key, Color defaultValue)
		{
			return default(Color);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x9F7500", Offset = "0x9F7500", VA = "0x9F7500")]
		public static bool SetBoolArray(string key, bool[] boolArray)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x9F7908", Offset = "0x9F7908", VA = "0x9F7908")]
		public static bool[] GetBoolArray(string key)
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x9F7BA4", Offset = "0x9F7BA4", VA = "0x9F7BA4")]
		public static bool[] GetBoolArray(string key, bool defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x9F7C64", Offset = "0x9F7C64", VA = "0x9F7C64")]
		public static bool SetStringArray(string key, string[] stringArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x9F7F64", Offset = "0x9F7F64", VA = "0x9F7F64")]
		public static string[] GetStringArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x9F8244", Offset = "0x9F8244", VA = "0x9F8244")]
		public static string[] GetStringArray(string key, string defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x9F832C", Offset = "0x9F832C", VA = "0x9F832C")]
		public static bool SetIntArray(string key, int[] intArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x9F6E3C", Offset = "0x9F6E3C", VA = "0x9F6E3C")]
		public static bool SetFloatArray(string key, float[] floatArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x9F83DC", Offset = "0x9F83DC", VA = "0x9F83DC")]
		public static bool SetVector2Array(string key, Vector2[] vector2Array)
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x9F848C", Offset = "0x9F848C", VA = "0x9F848C")]
		public static bool SetVector3Array(string key, Vector3[] vector3Array)
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x9F853C", Offset = "0x9F853C", VA = "0x9F853C")]
		public static bool SetQuaternionArray(string key, Quaternion[] quaternionArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x9F85EC", Offset = "0x9F85EC", VA = "0x9F85EC")]
		public static bool SetColorArray(string key, Color[] colorArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		private static bool SetValue<T>(string key, T array, ArrayType arrayType, int vectorNumber, Action<T, byte[], int> convert) where T : IList
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x9F869C", Offset = "0x9F869C", VA = "0x9F869C")]
		private static void ConvertFromInt(int[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x9F86C8", Offset = "0x9F86C8", VA = "0x9F86C8")]
		private static void ConvertFromFloat(float[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x9F8784", Offset = "0x9F8784", VA = "0x9F8784")]
		private static void ConvertFromVector2(Vector2[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x9F87E8", Offset = "0x9F87E8", VA = "0x9F87E8")]
		private static void ConvertFromVector3(Vector3[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x9F887C", Offset = "0x9F887C", VA = "0x9F887C")]
		private static void ConvertFromQuaternion(Quaternion[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x9F891C", Offset = "0x9F891C", VA = "0x9F891C")]
		private static void ConvertFromColor(Color[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x9F89BC", Offset = "0x9F89BC", VA = "0x9F89BC")]
		public static int[] GetIntArray(string key)
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x9F8AC8", Offset = "0x9F8AC8", VA = "0x9F8AC8")]
		public static int[] GetIntArray(string key, int defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x9F6F58", Offset = "0x9F6F58", VA = "0x9F6F58")]
		public static float[] GetFloatArray(string key)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x9F8B84", Offset = "0x9F8B84", VA = "0x9F8B84")]
		public static float[] GetFloatArray(string key, float defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x9F8C40", Offset = "0x9F8C40", VA = "0x9F8C40")]
		public static Vector2[] GetVector2Array(string key)
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x9F8D4C", Offset = "0x9F8D4C", VA = "0x9F8D4C")]
		public static Vector2[] GetVector2Array(string key, Vector2 defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x9F8E10", Offset = "0x9F8E10", VA = "0x9F8E10")]
		public static Vector3[] GetVector3Array(string key)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x9F8F1C", Offset = "0x9F8F1C", VA = "0x9F8F1C")]
		public static Vector3[] GetVector3Array(string key, Vector3 defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x9F8FF0", Offset = "0x9F8FF0", VA = "0x9F8FF0")]
		public static Quaternion[] GetQuaternionArray(string key)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x9F90FC", Offset = "0x9F90FC", VA = "0x9F90FC")]
		public static Quaternion[] GetQuaternionArray(string key, Quaternion defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x9F91D8", Offset = "0x9F91D8", VA = "0x9F91D8")]
		public static Color[] GetColorArray(string key)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x9F92E4", Offset = "0x9F92E4", VA = "0x9F92E4")]
		public static Color[] GetColorArray(string key, Color defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		private static void GetValue<T>(string key, T list, ArrayType arrayType, int vectorNumber, Action<T, byte[]> convert) where T : IList
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x9F93C0", Offset = "0x9F93C0", VA = "0x9F93C0")]
		private static void ConvertToInt(List<int> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x9F9470", Offset = "0x9F9470", VA = "0x9F9470")]
		private static void ConvertToFloat(List<float> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x9F95A8", Offset = "0x9F95A8", VA = "0x9F95A8")]
		private static void ConvertToVector2(List<Vector2> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x9F9674", Offset = "0x9F9674", VA = "0x9F9674")]
		private static void ConvertToVector3(List<Vector3> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x9F9758", Offset = "0x9F9758", VA = "0x9F9758")]
		private static void ConvertToQuaternion(List<Quaternion> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x9F9854", Offset = "0x9F9854", VA = "0x9F9854")]
		private static void ConvertToColor(List<Color> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x9F9950", Offset = "0x9F9950", VA = "0x9F9950")]
		public static void ShowArrayType(string key)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x9F76C4", Offset = "0x9F76C4", VA = "0x9F76C4")]
		private static void Initialize()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x9F7814", Offset = "0x9F7814", VA = "0x9F7814")]
		private static bool SaveBytes(string key, byte[] bytes)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x9F86F8", Offset = "0x9F86F8", VA = "0x9F86F8")]
		private static void ConvertFloatToBytes(float f, byte[] bytes)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x9F951C", Offset = "0x9F951C", VA = "0x9F951C")]
		private static float ConvertBytesToFloat(byte[] bytes)
		{
			return default(float);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x9F7788", Offset = "0x9F7788", VA = "0x9F7788")]
		private static void ConvertInt32ToBytes(int i, byte[] bytes)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x9F7B18", Offset = "0x9F7B18", VA = "0x9F7B18")]
		private static int ConvertBytesToInt32(byte[] bytes)
		{
			return default(int);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x9F9A94", Offset = "0x9F9A94", VA = "0x9F9A94")]
		private static void ConvertTo4Bytes(byte[] bytes)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x9F9C14", Offset = "0x9F9C14", VA = "0x9F9C14")]
		private static void ConvertFrom4Bytes(byte[] bytes)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x9F9D94", Offset = "0x9F9D94", VA = "0x9F9D94")]
		public PlayerPrefsX()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class ReadOnlyAttribute : PropertyAttribute
	{
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x9F9D9C", Offset = "0x9F9D9C", VA = "0x9F9D9C")]
		public ReadOnlyAttribute()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class ShadowDistanceAdjuster : MonoBehaviour
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float ForcedShadowDistance;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _defaultShadowDistance;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x9F9DA4", Offset = "0x9F9DA4", VA = "0x9F9DA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x9F9EB0", Offset = "0x9F9EB0", VA = "0x9F9EB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x9F9FAC", Offset = "0x9F9FAC", VA = "0x9F9FAC")]
		private void OnQualityApplied()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x9F9FD4", Offset = "0x9F9FD4", VA = "0x9F9FD4")]
		public ShadowDistanceAdjuster()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class TargetFps : MonoBehaviour
	{
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x9F9FE4", Offset = "0x9F9FE4", VA = "0x9F9FE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x9FA004", Offset = "0x9FA004", VA = "0x9FA004")]
		public TargetFps()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[RequireComponent(typeof(CanvasRenderer))]
	public class Touchable : Graphic
	{
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x9FA00C", Offset = "0x9FA00C", VA = "0x9FA00C", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x9FA024", Offset = "0x9FA024", VA = "0x9FA024")]
		public Touchable()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class TouchArea : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<int> _touchIdList;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _curTouchId;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _isTouching;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool _touchedThisFrame;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		private bool _releasedThisFrame;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 _deltaPosition;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 _deltaPositionPercent;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 _deltaPositionInches;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _curDpi;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 _lastMousePosition;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector2 _screenSize;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _targetDisplaySize;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _curDisplaySize;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _displaySizeRatio;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _displaySizeRatioModifier;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float DisplaySizeRatioBalance;

		[Token(Token = "0x17000026")]
		public bool IsTouching
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x9FA07C", Offset = "0x9FA07C", VA = "0x9FA07C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public bool TouchedThisFrame
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x9FA084", Offset = "0x9FA084", VA = "0x9FA084")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public bool ReleasedThisFrame
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x9FA08C", Offset = "0x9FA08C", VA = "0x9FA08C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public Vector2 DeltaPosition
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x9FA094", Offset = "0x9FA094", VA = "0x9FA094")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x1700002A")]
		public Vector2 DeltaPositionPercent
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x9FA09C", Offset = "0x9FA09C", VA = "0x9FA09C")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x1700002B")]
		public Vector2 DeltaPositionInches
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x9FA0A4", Offset = "0x9FA0A4", VA = "0x9FA0A4")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x1700002C")]
		public float DisplaySizeRatioModifier
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x9FA0AC", Offset = "0x9FA0AC", VA = "0x9FA0AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x9FA0B4", Offset = "0x9FA0B4", VA = "0x9FA0B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x9FA21C", Offset = "0x9FA21C", VA = "0x9FA21C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x9FA2E0", Offset = "0x9FA2E0", VA = "0x9FA2E0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x9FA3CC", Offset = "0x9FA3CC", VA = "0x9FA3CC")]
		public void Update()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x9FA4E8", Offset = "0x9FA4E8", VA = "0x9FA4E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x9FA504", Offset = "0x9FA504", VA = "0x9FA504")]
		public TouchArea()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public static class UsefulStuff
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random rng;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float[] FactorialCache;

		[Token(Token = "0x60001D3")]
		public static T FindInParents<T>(GameObject go) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x9FA530", Offset = "0x9FA530", VA = "0x9FA530")]
		public static string GetGameObjectPath(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		public static void ShuffleArray<T>(T[] arr)
		{
		}

		[Token(Token = "0x60001D6")]
		public static void ShuffleArrayBest<T>(this List<T> list)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x9FA610", Offset = "0x9FA610", VA = "0x9FA610")]
		public static string ConvertToStringForSerialization(this DateTime time)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x9FA9D4", Offset = "0x9FA9D4", VA = "0x9FA9D4")]
		public static DateTime ConvertDateTimeFromSerialization(this string value)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x9FABE4", Offset = "0x9FABE4", VA = "0x9FABE4")]
		public static void SetAlpha(this Image image, float alpha)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x9FAC94", Offset = "0x9FAC94", VA = "0x9FAC94")]
		public static float GetAlpha(this Image image)
		{
			return default(float);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x9FAD1C", Offset = "0x9FAD1C", VA = "0x9FAD1C")]
		public static void SetAlpha(this RawImage image, float alpha)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x9FADCC", Offset = "0x9FADCC", VA = "0x9FADCC")]
		public static float GetAlpha(this RawImage image)
		{
			return default(float);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x9FAE54", Offset = "0x9FAE54", VA = "0x9FAE54")]
		public static void SetAlpha(this TextMeshProUGUI label, float alpha)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x9FAF04", Offset = "0x9FAF04", VA = "0x9FAF04")]
		public static float GetAlpha(this TextMeshProUGUI label)
		{
			return default(float);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x9FAF88", Offset = "0x9FAF88", VA = "0x9FAF88")]
		public static void SetAlpha(this SpriteRenderer sprite, float alpha)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x9FB028", Offset = "0x9FB028", VA = "0x9FB028")]
		public static float GetAlpha(this SpriteRenderer sprite)
		{
			return default(float);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x9FB0A8", Offset = "0x9FB0A8", VA = "0x9FB0A8")]
		public static void SetLeftTopRightBottom(this RectTransform rt, float left, float top, float right, float bottom)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x9FB16C", Offset = "0x9FB16C", VA = "0x9FB16C")]
		public static bool SkillCheck(int skill, int toughness = 1, float successIfAbove = 0.66f)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x9FB1D0", Offset = "0x9FB1D0", VA = "0x9FB1D0")]
		public static float SkillCheckChance(int skill, int toughness = 1, float successIfAbove = 0.66f)
		{
			return default(float);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x9FB370", Offset = "0x9FB370", VA = "0x9FB370")]
		public static int ChooseWithChance(float[] probs)
		{
			return default(int);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x9FB41C", Offset = "0x9FB41C", VA = "0x9FB41C")]
		public static int GetXPForLevel(int level)
		{
			return default(int);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x9FB4E8", Offset = "0x9FB4E8", VA = "0x9FB4E8")]
		public static float Remap(float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x9FB504", Offset = "0x9FB504", VA = "0x9FB504")]
		private static float[] InitFactorialCache(int max)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x9FB2E4", Offset = "0x9FB2E4", VA = "0x9FB2E4")]
		public static float Factorial(int x)
		{
			return default(float);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x9FB5B4", Offset = "0x9FB5B4", VA = "0x9FB5B4")]
		public static int RandomSign()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000045")]
	public class Vector3LowPassFilter : MonoBehaviour
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SampleCount;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve WeightCurve;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] _samples;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] _weights;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _weightSum;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _currentSample;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _value;

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x9FC664", Offset = "0x9FC664", VA = "0x9FC664")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x9FC668", Offset = "0x9FC668", VA = "0x9FC668")]
		[ContextMenu("Calculate Weights")]
		private void CalculateWeights()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x9FC7F8", Offset = "0x9FC7F8", VA = "0x9FC7F8")]
		public Vector3 AddSample(Vector3 sample)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x9FC954", Offset = "0x9FC954", VA = "0x9FC954")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x9FCA38", Offset = "0x9FCA38", VA = "0x9FCA38")]
		public Vector3LowPassFilter()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class AmmoNotification : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class <PlayEditorTest>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AmmoNotification <>4__this;

			[Token(Token = "0x1700002D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001FC")]
				[Address(RVA = "0x9FD248", Offset = "0x9FD248", VA = "0x9FD248", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001FE")]
				[Address(RVA = "0x9FD290", Offset = "0x9FD290", VA = "0x9FD290", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x9FCF78", Offset = "0x9FCF78", VA = "0x9FCF78")]
			[DebuggerHidden]
			public <PlayEditorTest>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x9FD188", Offset = "0x9FD188", VA = "0x9FD188", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x9FD18C", Offset = "0x9FD18C", VA = "0x9FD18C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x9FD250", Offset = "0x9FD250", VA = "0x9FD250", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteRenderer SpriteRenderer;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Sequence _sequence;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Sequence _sequence2;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _delay;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _editorTest;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _targetPosition;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<AmmoNotification> _onCompleteCallback;

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x9FCA48", Offset = "0x9FCA48", VA = "0x9FCA48")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x9FCCBC", Offset = "0x9FCCBC", VA = "0x9FCCBC")]
		public void Init(float delay, Vector3 targetPosition, SpawnPool spawnPool, Action<AmmoNotification> onComplete)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x9FCDB8", Offset = "0x9FCDB8", VA = "0x9FCDB8")]
		private void OnStepComplete()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x9FCE4C", Offset = "0x9FCE4C", VA = "0x9FCE4C")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x9FCEB4", Offset = "0x9FCEB4", VA = "0x9FCEB4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x9FCEF0", Offset = "0x9FCEF0", VA = "0x9FCEF0")]
		[ContextMenu("Test")]
		private void EditorTest()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x9FCF10", Offset = "0x9FCF10", VA = "0x9FCF10")]
		[IteratorStateMachine(typeof(<PlayEditorTest>d__14))]
		private IEnumerator PlayEditorTest()
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x9FCFA0", Offset = "0x9FCFA0", VA = "0x9FCFA0")]
		public AmmoNotification()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class AmmoNotificationManager : MonoBehaviour
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform AmmoNotificationPrefab;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 OffsetVector;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 PerAmmoOffsetVector;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _camera;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x9FD298", Offset = "0x9FD298", VA = "0x9FD298")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x9FD418", Offset = "0x9FD418", VA = "0x9FD418")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x9FD518", Offset = "0x9FD518", VA = "0x9FD518")]
		private void OnIncomingArrowsEvent(int count, Vector3 point)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x9FD768", Offset = "0x9FD768", VA = "0x9FD768")]
		private void AmmoNotifyComplete(AmmoNotification item)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x9FD78C", Offset = "0x9FD78C", VA = "0x9FD78C")]
		public AmmoNotificationManager()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class ImpactNotification : MonoBehaviour
	{
		[Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class <PlayEditorTest>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ImpactNotification <>4__this;

			[Token(Token = "0x1700002F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600020E")]
				[Address(RVA = "0x9FDCB4", Offset = "0x9FDCB4", VA = "0x9FDCB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000030")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0x9FDCFC", Offset = "0x9FDCFC", VA = "0x9FDCFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600020B")]
			[Address(RVA = "0x9FDBC4", Offset = "0x9FDBC4", VA = "0x9FDBC4")]
			[DebuggerHidden]
			public <PlayEditorTest>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600020C")]
			[Address(RVA = "0x9FDBF4", Offset = "0x9FDBF4", VA = "0x9FDBF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0x9FDBF8", Offset = "0x9FDBF8", VA = "0x9FDBF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0x9FDCBC", Offset = "0x9FDCBC", VA = "0x9FDCBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteRenderer SpriteRenderer;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Sequence _sequence;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _editorTest;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x9FD7AC", Offset = "0x9FD7AC", VA = "0x9FD7AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x9FDA9C", Offset = "0x9FDA9C", VA = "0x9FDA9C")]
		public void Init(Color color, SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x9FDAE0", Offset = "0x9FDAE0", VA = "0x9FDAE0")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x9FDB2C", Offset = "0x9FDB2C", VA = "0x9FDB2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x9FDB3C", Offset = "0x9FDB3C", VA = "0x9FDB3C")]
		[ContextMenu("Test")]
		private void EditorTest()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x9FDB5C", Offset = "0x9FDB5C", VA = "0x9FDB5C")]
		[IteratorStateMachine(typeof(<PlayEditorTest>d__9))]
		private IEnumerator PlayEditorTest()
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x9FDBEC", Offset = "0x9FDBEC", VA = "0x9FDBEC")]
		public ImpactNotification()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class ImpactNotificationManager : MonoBehaviour
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform ImpactNotificationPrefab;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color[] Colors;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _camera;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x9FDD04", Offset = "0x9FDD04", VA = "0x9FDD04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x9FDE40", Offset = "0x9FDE40", VA = "0x9FDE40")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x9FDF40", Offset = "0x9FDF40", VA = "0x9FDF40")]
		private void OnArrowHitEvent(RaycastHit hit, Vector3 velocity, int precission)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x9FE0F4", Offset = "0x9FE0F4", VA = "0x9FE0F4")]
		public ImpactNotificationManager()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class TargetHitNotification : MonoBehaviour
	{
		[Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class <PlayEditorTest>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TargetHitNotification <>4__this;

			[Token(Token = "0x17000031")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x9FE6BC", Offset = "0x9FE6BC", VA = "0x9FE6BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000032")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000221")]
				[Address(RVA = "0x9FE704", Offset = "0x9FE704", VA = "0x9FE704", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0x9FE5CC", Offset = "0x9FE5CC", VA = "0x9FE5CC")]
			[DebuggerHidden]
			public <PlayEditorTest>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x9FE5FC", Offset = "0x9FE5FC", VA = "0x9FE5FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x9FE600", Offset = "0x9FE600", VA = "0x9FE600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x9FE6C4", Offset = "0x9FE6C4", VA = "0x9FE6C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteRenderer SpriteRenderer;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Sequence _sequence;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _editorTest;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x9FE0FC", Offset = "0x9FE0FC", VA = "0x9FE0FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x9FE464", Offset = "0x9FE464", VA = "0x9FE464")]
		public void Init(Sprite sprite, Color color, SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x9FE4E8", Offset = "0x9FE4E8", VA = "0x9FE4E8")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x9FE534", Offset = "0x9FE534", VA = "0x9FE534")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x9FE544", Offset = "0x9FE544", VA = "0x9FE544")]
		[ContextMenu("Test")]
		private void EditorTest()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x9FE564", Offset = "0x9FE564", VA = "0x9FE564")]
		[IteratorStateMachine(typeof(<PlayEditorTest>d__9))]
		private IEnumerator PlayEditorTest()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x9FE5F4", Offset = "0x9FE5F4", VA = "0x9FE5F4")]
		public TargetHitNotification()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class TargetHitNotificationManager : MonoBehaviour
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform TargetHitNotificationPrefab;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 OffsetVector;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite[] Sprites;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color[] Colors;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _camera;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x9FE70C", Offset = "0x9FE70C", VA = "0x9FE70C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x9FE848", Offset = "0x9FE848", VA = "0x9FE848")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x9FE948", Offset = "0x9FE948", VA = "0x9FE948")]
		private void OnTargetHitEvent(int precision, RaycastHit hit)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x9FEB08", Offset = "0x9FEB08", VA = "0x9FEB08")]
		public TargetHitNotificationManager()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class TimeNotification : MonoBehaviour
	{
		[Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class <PlayEditorTest>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeNotification <>4__this;

			[Token(Token = "0x17000033")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000231")]
				[Address(RVA = "0x9FF308", Offset = "0x9FF308", VA = "0x9FF308", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000034")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x9FF350", Offset = "0x9FF350", VA = "0x9FF350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x9FF218", Offset = "0x9FF218", VA = "0x9FF218")]
			[DebuggerHidden]
			public <PlayEditorTest>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x9FF248", Offset = "0x9FF248", VA = "0x9FF248", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x9FF24C", Offset = "0x9FF24C", VA = "0x9FF24C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x9FF310", Offset = "0x9FF310", VA = "0x9FF310", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro Label;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Sequence _sequence;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Sequence _sequence2;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _editorTest;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 _targetPosition;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action<TimeNotification> _onCompleteCallback;

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x9FEB20", Offset = "0x9FEB20", VA = "0x9FEB20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x9FEE18", Offset = "0x9FEE18", VA = "0x9FEE18")]
		public void Init(Vector3 targetPosition, SpawnPool spawnPool, Action<TimeNotification> onComplete)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x9FEF0C", Offset = "0x9FEF0C", VA = "0x9FEF0C")]
		private void OnStepComplete()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x9FF0EC", Offset = "0x9FF0EC", VA = "0x9FF0EC")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x9FF154", Offset = "0x9FF154", VA = "0x9FF154")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x9FF190", Offset = "0x9FF190", VA = "0x9FF190")]
		[ContextMenu("Test")]
		private void EditorTest()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x9FF1B0", Offset = "0x9FF1B0", VA = "0x9FF1B0")]
		[IteratorStateMachine(typeof(<PlayEditorTest>d__13))]
		private IEnumerator PlayEditorTest()
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x9FF240", Offset = "0x9FF240", VA = "0x9FF240")]
		public TimeNotification()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class TimeNotificationManager : MonoBehaviour
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform TimeNotificationPrefab;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 OffsetVector;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _camera;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x9FF358", Offset = "0x9FF358", VA = "0x9FF358")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x9FF4D8", Offset = "0x9FF4D8", VA = "0x9FF4D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x9FF5D8", Offset = "0x9FF5D8", VA = "0x9FF5D8")]
		private void OnIncomingTimeEvent(int count, Vector3 point)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x9FF7B4", Offset = "0x9FF7B4", VA = "0x9FF7B4")]
		private void TimeNotifyComplete(TimeNotification item)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x9FF7D8", Offset = "0x9FF7D8", VA = "0x9FF7D8")]
		public TimeNotificationManager()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class AmmoManager : MonoBehaviour
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<int> OnShoot;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> OnConfirmedHit;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<int> OnBullseyeHit;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<int> OnConfirmedMiss;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<int> OnNoAmmo;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action<int, int> OnAvailableAmmoChanged;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action<int, Vector3> OnAmmoSent;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Action<int, int> OnAmmoReceived;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Action<int> OnBullseyeHitSent;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int StartingAmmo;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MaxTargetDistance;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<int> _incomingAmmo;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _releasedAmmo;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _additionalAmmo;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RoundManager _roundManager;

		[Token(Token = "0x17000035")]
		public int AvailableAmmo
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x9FF7F0", Offset = "0x9FF7F0", VA = "0x9FF7F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x9FF7F8", Offset = "0x9FF7F8", VA = "0x9FF7F8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public int CurAmmo
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x9FF800", Offset = "0x9FF800", VA = "0x9FF800")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x9FF808", Offset = "0x9FF808", VA = "0x9FF808")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public int BullseyeHits
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x9FF810", Offset = "0x9FF810", VA = "0x9FF810")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x9FF818", Offset = "0x9FF818", VA = "0x9FF818")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x9FF820", Offset = "0x9FF820", VA = "0x9FF820", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x9FF9F0", Offset = "0x9FF9F0", VA = "0x9FF9F0", Slot = "5")]
		public virtual void FullRearm()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x9FFAE4", Offset = "0x9FFAE4", VA = "0x9FFAE4", Slot = "6")]
		public virtual void Shoot()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x9FFB94", Offset = "0x9FFB94", VA = "0x9FFB94", Slot = "7")]
		public virtual void ConfirmedHit(int value, RaycastHit hit)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x9FFD74", Offset = "0x9FFD74", VA = "0x9FFD74", Slot = "8")]
		public virtual void IncomingAmmoArrived(int value)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x9FFE34", Offset = "0x9FFE34", VA = "0x9FFE34", Slot = "9")]
		public virtual void ConfirmedMiss()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x9FFD5C", Offset = "0x9FFD5C", VA = "0x9FFD5C")]
		private bool IsAmmoLeft()
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x9FFEDC", Offset = "0x9FFEDC", VA = "0x9FFEDC", Slot = "10")]
		public virtual int CalculateStars()
		{
			return default(int);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x9FFF90", Offset = "0x9FFF90", VA = "0x9FFF90")]
		public AmmoManager()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class LevelManager : RoundManager
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnRessuply;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _isLevelCompleted;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool _isLevelFailed;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _levelFailReward;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x9FFFA0", Offset = "0x9FFFA0", VA = "0x9FFFA0", Slot = "6")]
		protected override void StartRound()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x9FFFBC", Offset = "0x9FFFBC", VA = "0x9FFFBC", Slot = "7")]
		public override void CompleteRound(int value)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA001C4", Offset = "0xA001C4", VA = "0xA001C4")]
		private void CompleteLevel()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA00068", Offset = "0xA00068", VA = "0xA00068")]
		public void FailLevel()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xA0075C", Offset = "0xA0075C", VA = "0xA0075C")]
		public void PrepareForRessuply()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA00850", Offset = "0xA00850", VA = "0xA00850")]
		public void PrepareForNext()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA00D10", Offset = "0xA00D10", VA = "0xA00D10")]
		public void PrepareForRetry()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA00DB0", Offset = "0xA00DB0", VA = "0xA00DB0")]
		public void PrepareForSkip()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xA00E34", Offset = "0xA00E34", VA = "0xA00E34", Slot = "9")]
		public override void PrepareForQuit()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA00F24", Offset = "0xA00F24", VA = "0xA00F24")]
		public LevelManager()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class MiniGameAmmoManager : AmmoManager
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA00F34", Offset = "0xA00F34", VA = "0xA00F34", Slot = "6")]
		public override void Shoot()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA00FA0", Offset = "0xA00FA0", VA = "0xA00FA0", Slot = "7")]
		public override void ConfirmedHit(int value, RaycastHit hit)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xA01084", Offset = "0xA01084", VA = "0xA01084", Slot = "9")]
		public override void ConfirmedMiss()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA010F0", Offset = "0xA010F0", VA = "0xA010F0", Slot = "10")]
		public override int CalculateStars()
		{
			return default(int);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA010F8", Offset = "0xA010F8", VA = "0xA010F8")]
		public MiniGameAmmoManager()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class MiniGameManager : RoundManager
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MiniGameTargetManager _miniGameTargetManager;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isMiniGameCompleted;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DynamicObject[] ToActivateOnRoundStart;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _startingTime;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _bullseyeTimeIncrease;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quiver _quiver;

		[Token(Token = "0x17000038")]
		public float Timer
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0xA01108", Offset = "0xA01108", VA = "0xA01108")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xA01110", Offset = "0xA01110", VA = "0xA01110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public float TimerPercent
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xA01118", Offset = "0xA01118", VA = "0xA01118")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA01124", Offset = "0xA01124", VA = "0xA01124", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA01348", Offset = "0xA01348", VA = "0xA01348")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA01448", Offset = "0xA01448", VA = "0xA01448")]
		private void OnBullseyeHitEvent(int bullseyeHits)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA0145C", Offset = "0xA0145C", VA = "0xA0145C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xA014E8", Offset = "0xA014E8", VA = "0xA014E8")]
		public void ForceStartRound()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xA01564", Offset = "0xA01564", VA = "0xA01564", Slot = "6")]
		protected override void StartRound()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA015A4", Offset = "0xA015A4", VA = "0xA015A4")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xA01600", Offset = "0xA01600", VA = "0xA01600", Slot = "7")]
		public override void CompleteRound(int value)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA01634", Offset = "0xA01634", VA = "0xA01634")]
		private void CompleteMiniGame()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xA01A3C", Offset = "0xA01A3C", VA = "0xA01A3C", Slot = "9")]
		public override void PrepareForQuit()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xA01AD8", Offset = "0xA01AD8", VA = "0xA01AD8")]
		public void PrepareForRetry()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA01B78", Offset = "0xA01B78", VA = "0xA01B78")]
		public MiniGameManager()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class MiniGameTargetManager : MonoBehaviour
	{
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _targetsHit;

		[Token(Token = "0x1700003A")]
		public int TargetsHit
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xA01B88", Offset = "0xA01B88", VA = "0xA01B88")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xA01B90", Offset = "0xA01B90", VA = "0xA01B90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xA01D90", Offset = "0xA01D90", VA = "0xA01D90")]
		private void OnTargetMissedEvent(EDKG.ArcheryRange.Projectiles.Arrow arrow)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xA01DB0", Offset = "0xA01DB0", VA = "0xA01DB0")]
		private void OnTargetHitEvent(int precision, RaycastHit hit)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA01E10", Offset = "0xA01E10", VA = "0xA01E10")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xA01FC8", Offset = "0xA01FC8", VA = "0xA01FC8")]
		public MiniGameTargetManager()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class RoundManager : MonoBehaviour
	{
		[Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class <DelayedCompleteRound>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int value;

			[Token(Token = "0x1700003C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000278")]
				[Address(RVA = "0xA02154", Offset = "0xA02154", VA = "0xA02154", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0xA0219C", Offset = "0xA0219C", VA = "0xA0219C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0xA02058", Offset = "0xA02058", VA = "0xA02058")]
			[DebuggerHidden]
			public <DelayedCompleteRound>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0xA02084", Offset = "0xA02084", VA = "0xA02084", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0xA02088", Offset = "0xA02088", VA = "0xA02088", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0xA0215C", Offset = "0xA0215C", VA = "0xA0215C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<int> OnRoundComplete;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected PlayerState _playerState;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected LoadingScreen _loadingScreen;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected AmmoManager _ammoManager;

		[Token(Token = "0x1700003B")]
		public bool IsGameInProgress
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xA01FD0", Offset = "0xA01FD0", VA = "0xA01FD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xA01FD8", Offset = "0xA01FD8", VA = "0xA01FD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xA012A4", Offset = "0xA012A4", VA = "0xA012A4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xA01FE4", Offset = "0xA01FE4", VA = "0xA01FE4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x9FFFB0", Offset = "0x9FFFB0", VA = "0x9FFFB0", Slot = "6")]
		protected virtual void StartRound()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xA0003C", Offset = "0xA0003C", VA = "0xA0003C", Slot = "7")]
		public virtual void CompleteRound(int value)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xA01FF0", Offset = "0xA01FF0", VA = "0xA01FF0", Slot = "8")]
		[IteratorStateMachine(typeof(<DelayedCompleteRound>d__12))]
		protected virtual IEnumerator DelayedCompleteRound(int value)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xA02080", Offset = "0xA02080", VA = "0xA02080", Slot = "9")]
		public virtual void PrepareForQuit()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xA00F2C", Offset = "0xA00F2C", VA = "0xA00F2C")]
		public RoundManager()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class ScriptableObjectManager : MonoBehaviour
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScriptableObject[] ScriptableObjects;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA021A4", Offset = "0xA021A4", VA = "0xA021A4")]
		public ScriptableObjectManager()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class TargetManager : MonoBehaviour
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target[] TargetList;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _allTargetsHit;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RoundManager _roundManager;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Target> _initialTargetList;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Target> _targetList;

		[Token(Token = "0x1400000D")]
		public static event Action<float> OnTargetListProgressChanged
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0xA021AC", Offset = "0xA021AC", VA = "0xA021AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600027D")]
			[Address(RVA = "0xA02278", Offset = "0xA02278", VA = "0xA02278")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xA02344", Offset = "0xA02344", VA = "0xA02344")]
		private void Awake()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xA02724", Offset = "0xA02724", VA = "0xA02724")]
		private void OnTargetMissedEvent(EDKG.ArcheryRange.Projectiles.Arrow arrow)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xA02754", Offset = "0xA02754", VA = "0xA02754")]
		private void OnTargetHitEvent(int precision, RaycastHit hit)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xA027B0", Offset = "0xA027B0", VA = "0xA027B0")]
		private void OnTargetKilledEvent(Target t)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xA028F8", Offset = "0xA028F8", VA = "0xA028F8")]
		private void OnTargetResetEvent(Target t)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA028D4", Offset = "0xA028D4", VA = "0xA028D4")]
		private void ReportLevelComplete()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA02A54", Offset = "0xA02A54", VA = "0xA02A54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA02D60", Offset = "0xA02D60", VA = "0xA02D60")]
		public TargetManager()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class PlayerSettingsState
	{
		[Token(Token = "0x200005C")]
		public delegate void SimpleFloatEvent(float value);

		[Token(Token = "0x200005D")]
		public delegate void SimpleIntEvent(int value);

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SerializableSettings _settings;

		[Token(Token = "0x1700003E")]
		public float MasterVolume
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0xA03CF0", Offset = "0xA03CF0", VA = "0xA03CF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0xA03D0C", Offset = "0xA03D0C", VA = "0xA03D0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public float MusicVolume
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0xA03D98", Offset = "0xA03D98", VA = "0xA03D98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0xA03DB4", Offset = "0xA03DB4", VA = "0xA03DB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public int Quality
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xA03E40", Offset = "0xA03E40", VA = "0xA03E40")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xA03E5C", Offset = "0xA03E5C", VA = "0xA03E5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public float ArmLengthCalibration
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xA03EDC", Offset = "0xA03EDC", VA = "0xA03EDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xA03EF8", Offset = "0xA03EF8", VA = "0xA03EF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public float Smoothing
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0xA03F84", Offset = "0xA03F84", VA = "0xA03F84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0xA03FA0", Offset = "0xA03FA0", VA = "0xA03FA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool SnapPoint
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0xA0402C", Offset = "0xA0402C", VA = "0xA0402C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0xA04048", Offset = "0xA04048", VA = "0xA04048")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Vector3 SnapPointPos
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xA040CC", Offset = "0xA040CC", VA = "0xA040CC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0xA040EC", Offset = "0xA040EC", VA = "0xA040EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public bool Crosshair
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x9FF9B8", Offset = "0x9FF9B8", VA = "0x9FF9B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xA0410C", Offset = "0xA0410C", VA = "0xA0410C")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public int AdditionalArrows
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x9FF9D4", Offset = "0x9FF9D4", VA = "0x9FF9D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xA04190", Offset = "0xA04190", VA = "0xA04190")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public bool ArrowSide
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xA041AC", Offset = "0xA041AC", VA = "0xA041AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xA041C8", Offset = "0xA041C8", VA = "0xA041C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public float InitialTrajectory
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xA04254", Offset = "0xA04254", VA = "0xA04254")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xA04270", Offset = "0xA04270", VA = "0xA04270")]
			set
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public static event SimpleFloatEvent OnMasterVolumeChanged
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0xA02D68", Offset = "0xA02D68", VA = "0xA02D68")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0xA02E20", Offset = "0xA02E20", VA = "0xA02E20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public static event SimpleFloatEvent OnMusicVolumeChanged
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0xA02ED8", Offset = "0xA02ED8", VA = "0xA02ED8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xA02F94", Offset = "0xA02F94", VA = "0xA02F94")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public static event SimpleIntEvent OnQualityChanged
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xA03050", Offset = "0xA03050", VA = "0xA03050")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xA0310C", Offset = "0xA0310C", VA = "0xA0310C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public static event SimpleFloatEvent OnSmoothingChanged
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xA031C8", Offset = "0xA031C8", VA = "0xA031C8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xA03284", Offset = "0xA03284", VA = "0xA03284")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public static event SimpleFloatEvent OnArmLengthCalibrationChanged
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0xA03340", Offset = "0xA03340", VA = "0xA03340")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xA033FC", Offset = "0xA033FC", VA = "0xA033FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public static event SimpleIntEvent OnSnapPointChanged
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0xA034B8", Offset = "0xA034B8", VA = "0xA034B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000291")]
			[Address(RVA = "0xA03574", Offset = "0xA03574", VA = "0xA03574")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public static event SimpleIntEvent OnCrosshairChanged
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0xA03630", Offset = "0xA03630", VA = "0xA03630")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0xA036EC", Offset = "0xA036EC", VA = "0xA036EC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public static event SimpleIntEvent OnArrowSideChanged
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0xA037A8", Offset = "0xA037A8", VA = "0xA037A8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0xA03864", Offset = "0xA03864", VA = "0xA03864")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public static event SimpleFloatEvent OnInitialTrajectoryChanged
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0xA03920", Offset = "0xA03920", VA = "0xA03920")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000297")]
			[Address(RVA = "0xA039DC", Offset = "0xA039DC", VA = "0xA039DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xA03A98", Offset = "0xA03A98", VA = "0xA03A98")]
		public PlayerSettingsState(SerializableSettings settings)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xA03AC0", Offset = "0xA03AC0", VA = "0xA03AC0")]
		public void ResetMainSettings()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA03C14", Offset = "0xA03C14", VA = "0xA03C14")]
		public void ResetAdvancedSettings()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class PlayerState
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SerializableState _state;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int LevelsPerArea;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int CappedArea;

		[Token(Token = "0x17000049")]
		public int StartedLevel
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xA0527C", Offset = "0xA0527C", VA = "0xA0527C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xA05284", Offset = "0xA05284", VA = "0xA05284")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public int TempStars
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xA0528C", Offset = "0xA0528C", VA = "0xA0528C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xA05294", Offset = "0xA05294", VA = "0xA05294")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public int TempPreviousBestStars
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xA0529C", Offset = "0xA0529C", VA = "0xA0529C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0xA052A4", Offset = "0xA052A4", VA = "0xA052A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public int TempBullseyeHits
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0xA052AC", Offset = "0xA052AC", VA = "0xA052AC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0xA052B4", Offset = "0xA052B4", VA = "0xA052B4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public int StartedMiniGame
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0xA052BC", Offset = "0xA052BC", VA = "0xA052BC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xA052C4", Offset = "0xA052C4", VA = "0xA052C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public int TempScore
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xA052CC", Offset = "0xA052CC", VA = "0xA052CC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xA052D4", Offset = "0xA052D4", VA = "0xA052D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public int TempPreviousBestScore
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xA052DC", Offset = "0xA052DC", VA = "0xA052DC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xA052E4", Offset = "0xA052E4", VA = "0xA052E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public int PrimaryCurrency
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xA006BC", Offset = "0xA006BC", VA = "0xA006BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xA006D8", Offset = "0xA006D8", VA = "0xA006D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public int PrimaryCurrencyDontUpdate
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xA05BB8", Offset = "0xA05BB8", VA = "0xA05BB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xA05BD4", Offset = "0xA05BD4", VA = "0xA05BD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public int CurBow
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xA06038", Offset = "0xA06038", VA = "0xA06038")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xA06054", Offset = "0xA06054", VA = "0xA06054")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public int CurArrow
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xA060D8", Offset = "0xA060D8", VA = "0xA060D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xA060F4", Offset = "0xA060F4", VA = "0xA060F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public int PremiumAimAssists
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xA06178", Offset = "0xA06178", VA = "0xA06178")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xA06194", Offset = "0xA06194", VA = "0xA06194")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public int PremiumAimAssistsDontUpdate
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xA06218", Offset = "0xA06218", VA = "0xA06218")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xA06234", Offset = "0xA06234", VA = "0xA06234")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public int PremiumSlowmos
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xA062C8", Offset = "0xA062C8", VA = "0xA062C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xA062E4", Offset = "0xA062E4", VA = "0xA062E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public int PremiumSlowmosDontUpdate
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xA06368", Offset = "0xA06368", VA = "0xA06368")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xA06384", Offset = "0xA06384", VA = "0xA06384")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public int LatestUnlockedMiniGame
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xA06418", Offset = "0xA06418", VA = "0xA06418")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xA06434", Offset = "0xA06434", VA = "0xA06434")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public int MiniGame
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0xA06450", Offset = "0xA06450", VA = "0xA06450")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xA0646C", Offset = "0xA0646C", VA = "0xA0646C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public int TutorialNavBar
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0xA06634", Offset = "0xA06634", VA = "0xA06634")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000305")]
			[Address(RVA = "0xA06650", Offset = "0xA06650", VA = "0xA06650")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool TutorialBoosters
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0xA0666C", Offset = "0xA0666C", VA = "0xA0666C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000307")]
			[Address(RVA = "0xA06688", Offset = "0xA06688", VA = "0xA06688")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public int BowHand
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0xA066A8", Offset = "0xA066A8", VA = "0xA066A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000309")]
			[Address(RVA = "0xA066C4", Offset = "0xA066C4", VA = "0xA066C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public int DataProtectionUser
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0xA06744", Offset = "0xA06744", VA = "0xA06744")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xA06760", Offset = "0xA06760", VA = "0xA06760")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool DataProtectionPromptShown
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xA0677C", Offset = "0xA0677C", VA = "0xA0677C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xA06798", Offset = "0xA06798", VA = "0xA06798")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public int DataProtectionAds
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0xA067B8", Offset = "0xA067B8", VA = "0xA067B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xA067D4", Offset = "0xA067D4", VA = "0xA067D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public int DataProtectionAnalytics
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0xA067F0", Offset = "0xA067F0", VA = "0xA067F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xA0680C", Offset = "0xA0680C", VA = "0xA0680C")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public bool DataProtectionAccepted
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0xA06828", Offset = "0xA06828", VA = "0xA06828")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000313")]
			[Address(RVA = "0xA06844", Offset = "0xA06844", VA = "0xA06844")]
			set
			{
			}
		}

		[Token(Token = "0x14000017")]
		public static event Action<int> OnStarsChanged
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xA04584", Offset = "0xA04584", VA = "0xA04584")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xA04650", Offset = "0xA04650", VA = "0xA04650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public static event Action<int> OnPrimaryCurrencyChanged
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xA0471C", Offset = "0xA0471C", VA = "0xA0471C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xA047EC", Offset = "0xA047EC", VA = "0xA047EC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public static event Action<int> OnSecondaryCurrencyChanged
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xA048BC", Offset = "0xA048BC", VA = "0xA048BC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xA0498C", Offset = "0xA0498C", VA = "0xA0498C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public static event Action<int> OnPremiumAimAssistsChanged
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xA04A5C", Offset = "0xA04A5C", VA = "0xA04A5C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xA04B2C", Offset = "0xA04B2C", VA = "0xA04B2C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public static event Action<int> OnPremiumSlowmosChanged
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xA04BFC", Offset = "0xA04BFC", VA = "0xA04BFC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xA04CCC", Offset = "0xA04CCC", VA = "0xA04CCC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public static event Action<int> OnAreaUnlocked
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xA04D9C", Offset = "0xA04D9C", VA = "0xA04D9C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xA04E6C", Offset = "0xA04E6C", VA = "0xA04E6C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public static event Action<int, int> OnEquipmentChanged
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xA04F3C", Offset = "0xA04F3C", VA = "0xA04F3C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xA0500C", Offset = "0xA0500C", VA = "0xA0500C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public static event Action<int> OnBowHandChanged
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xA050DC", Offset = "0xA050DC", VA = "0xA050DC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xA051AC", Offset = "0xA051AC", VA = "0xA051AC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xA052EC", Offset = "0xA052EC", VA = "0xA052EC")]
		public PlayerState(SerializableState state)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA017D4", Offset = "0xA017D4", VA = "0xA017D4")]
		public int GetLatestUnlockedArea()
		{
			return default(int);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xA00988", Offset = "0xA00988", VA = "0xA00988")]
		public int GetUnlockedLevelCountInArea(int areaId)
		{
			return default(int);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA0532C", Offset = "0xA0532C", VA = "0xA0532C")]
		public int GetLatestUnlockedLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA00BC8", Offset = "0xA00BC8", VA = "0xA00BC8")]
		public string[] GetAreaLeveSceneNamePair(int globalLevelId)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA053B8", Offset = "0xA053B8", VA = "0xA053B8")]
		public void UnlockArea(int areaId)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xA003CC", Offset = "0xA003CC", VA = "0xA003CC")]
		public void CompleteLevelInArea(int areaId, int levelId, int stars)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xA003B8", Offset = "0xA003B8", VA = "0xA003B8")]
		public int GetStarsPerLevel(int globalLevelId)
		{
			return default(int);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xA0568C", Offset = "0xA0568C", VA = "0xA0568C")]
		public int GetStarsPerLevelInArea(int areaId, int levelId)
		{
			return default(int);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xA057AC", Offset = "0xA057AC", VA = "0xA057AC")]
		public int GetTotalStars()
		{
			return default(int);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xA058C4", Offset = "0xA058C4", VA = "0xA058C4")]
		public int GetTotalStarsInArea(int areaId)
		{
			return default(int);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xA059DC", Offset = "0xA059DC", VA = "0xA059DC")]
		public int GetRetriesPerLevel(int levelId)
		{
			return default(int);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xA00A20", Offset = "0xA00A20", VA = "0xA00A20")]
		public void AddRetryPerLevel(int levelId)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xA05A64", Offset = "0xA05A64", VA = "0xA05A64")]
		public string[] GetAreaMinigameSceneNamePair(int miniGameId)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xA01838", Offset = "0xA01838", VA = "0xA01838")]
		public int GetScorePerMiniGame(int miniGameId)
		{
			return default(int);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA018C0", Offset = "0xA018C0", VA = "0xA018C0")]
		public void CompleteMiniGame(int miniGameId, int score)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xA05BF0", Offset = "0xA05BF0", VA = "0xA05BF0")]
		public void PrimaryCurrencyUpdate()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xA05C68", Offset = "0xA05C68", VA = "0xA05C68")]
		public bool GetInventoryBows(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xA05D20", Offset = "0xA05D20", VA = "0xA05D20")]
		public void SetInventoryBows(int id)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xA05E50", Offset = "0xA05E50", VA = "0xA05E50")]
		public bool GetInventoryArrows(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xA05F08", Offset = "0xA05F08", VA = "0xA05F08")]
		public void SetInventoryArrows(int id)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xA06250", Offset = "0xA06250", VA = "0xA06250")]
		public void PremiumAimAssistsUpdate()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xA063A0", Offset = "0xA063A0", VA = "0xA063A0")]
		public void PremiumSlowmosUpdate()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA06488", Offset = "0xA06488", VA = "0xA06488")]
		public int GetTutorialStep(int tutorialId)
		{
			return default(int);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA06510", Offset = "0xA06510", VA = "0xA06510")]
		public void SetTutorialStep(int tutorialId, int value)
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class PlayerStateInitializer : MonoBehaviour
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsPlannedInitialization;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SerializableStateDebug serializableStateDebug;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xA06864", Offset = "0xA06864", VA = "0xA06864")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xA069B0", Offset = "0xA069B0", VA = "0xA069B0")]
		public PlayerStateInitializer()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class PlayerStateManager
	{
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlayerStateManager _instance;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly SerializableSettings _serializableSettings;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly SettingsSerializer _settingsSerializer;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly SerializableState _serializableState;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly StateSerializer _stateSerializer;

		[Token(Token = "0x17000062")]
		public static PlayerStateManager Instance
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x9FF93C", Offset = "0x9FF93C", VA = "0x9FF93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public PlayerState State
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0xA06B68", Offset = "0xA06B68", VA = "0xA06B68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public PlayerSettingsState Settings
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0xA06B70", Offset = "0xA06B70", VA = "0xA06B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public bool StateInitialized
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0xA06B78", Offset = "0xA06B78", VA = "0xA06B78")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031A")]
			[Address(RVA = "0xA06B80", Offset = "0xA06B80", VA = "0xA06B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool DebugMode
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0xA06B8C", Offset = "0xA06B8C", VA = "0xA06B8C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031C")]
			[Address(RVA = "0xA06B94", Offset = "0xA06B94", VA = "0xA06B94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xA069B8", Offset = "0xA069B8", VA = "0xA069B8")]
		private PlayerStateManager()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xA06C1C", Offset = "0xA06C1C", VA = "0xA06C1C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xA068CC", Offset = "0xA068CC", VA = "0xA068CC")]
		public void Load()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xA07674", Offset = "0xA07674", VA = "0xA07674")]
		public void Save()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xA07C44", Offset = "0xA07C44", VA = "0xA07C44")]
		public void SaveConsumables()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xA0690C", Offset = "0xA0690C", VA = "0xA0690C")]
		public void LoadDebugData(SerializableStateDebug data)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA07F70", Offset = "0xA07F70", VA = "0xA07F70")]
		public void ResetMainSettings()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA0801C", Offset = "0xA0801C", VA = "0xA0801C")]
		public void ResetAdvancedSettings()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA068F4", Offset = "0xA068F4", VA = "0xA068F4")]
		public void LoadSettings()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA08370", Offset = "0xA08370", VA = "0xA08370")]
		public void SaveSettings()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class OldSerializableSettingsFormatLoader
	{
		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA085D0", Offset = "0xA085D0", VA = "0xA085D0")]
		public static void LoadVersion0(SerializableSettings state)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xA085D4", Offset = "0xA085D4", VA = "0xA085D4")]
		public OldSerializableSettingsFormatLoader()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class SerializableSettings
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Version;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MasterVolume;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MusicVolume;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Quality;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ArmLengthCalibration;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Smoothing;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool SnapPoint;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 SnapPointPos;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool Crosshair;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int AdditionalArrows;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool ArrowSide;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float InitialTrajectory;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xA06BA0", Offset = "0xA06BA0", VA = "0xA06BA0")]
		public SerializableSettings()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class SettingsSerializer
	{
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly SerializableSettings _settings;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xA06BB4", Offset = "0xA06BB4", VA = "0xA06BB4")]
		public SettingsSerializer(SerializableSettings settings)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xA085DC", Offset = "0xA085DC", VA = "0xA085DC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xA07F98", Offset = "0xA07F98", VA = "0xA07F98")]
		public void ResetMainSettings()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xA08058", Offset = "0xA08058", VA = "0xA08058")]
		public void ResetAdvancedSettings()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xA08084", Offset = "0xA08084", VA = "0xA08084")]
		public void Load()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xA08388", Offset = "0xA08388", VA = "0xA08388")]
		public void Save()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public static class OldSerializableStateFormatLoader
	{
		[Token(Token = "0x6000330")]
		[Address(RVA = "0xA08688", Offset = "0xA08688", VA = "0xA08688")]
		public static void LoadVersion0(SerializableState state)
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class SerializableState
	{
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int TutorialNavBar;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool TutorialBoosters;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int BowHand;

		[Token(Token = "0x17000067")]
		public int Version
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0xA0868C", Offset = "0xA0868C", VA = "0xA0868C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000068")]
		public List<List<int>> StarsPerLevel
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0xA08694", Offset = "0xA08694", VA = "0xA08694")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000333")]
			[Address(RVA = "0xA0869C", Offset = "0xA0869C", VA = "0xA0869C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public List<int> RetriesPerLevel
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0xA086A4", Offset = "0xA086A4", VA = "0xA086A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0xA086AC", Offset = "0xA086AC", VA = "0xA086AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public List<int> ScorePerMiniGame
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0xA086B4", Offset = "0xA086B4", VA = "0xA086B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xA086BC", Offset = "0xA086BC", VA = "0xA086BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public int PrimaryCurrency
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0xA086C4", Offset = "0xA086C4", VA = "0xA086C4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000339")]
			[Address(RVA = "0xA086CC", Offset = "0xA086CC", VA = "0xA086CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public List<int> InventoryBows
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0xA086D4", Offset = "0xA086D4", VA = "0xA086D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600033B")]
			[Address(RVA = "0xA086DC", Offset = "0xA086DC", VA = "0xA086DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public List<int> InventoryArrows
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0xA086E4", Offset = "0xA086E4", VA = "0xA086E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600033D")]
			[Address(RVA = "0xA086EC", Offset = "0xA086EC", VA = "0xA086EC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public int CurBow
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0xA086F4", Offset = "0xA086F4", VA = "0xA086F4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600033F")]
			[Address(RVA = "0xA086FC", Offset = "0xA086FC", VA = "0xA086FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public int CurArrow
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0xA08704", Offset = "0xA08704", VA = "0xA08704")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0xA0870C", Offset = "0xA0870C", VA = "0xA0870C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public int PremiumAimAssists
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0xA08714", Offset = "0xA08714", VA = "0xA08714")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0xA0871C", Offset = "0xA0871C", VA = "0xA0871C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public int PremiumSlowmos
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0xA08724", Offset = "0xA08724", VA = "0xA08724")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0xA0872C", Offset = "0xA0872C", VA = "0xA0872C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public int LatestUnlockedMiniGame
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0xA08734", Offset = "0xA08734", VA = "0xA08734")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0xA0873C", Offset = "0xA0873C", VA = "0xA0873C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public int MiniGame
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0xA08744", Offset = "0xA08744", VA = "0xA08744")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000349")]
			[Address(RVA = "0xA0874C", Offset = "0xA0874C", VA = "0xA0874C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public List<int> TutorialSteps
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0xA08754", Offset = "0xA08754", VA = "0xA08754")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600034B")]
			[Address(RVA = "0xA0875C", Offset = "0xA0875C", VA = "0xA0875C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public int DataProtectionUser
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0xA08764", Offset = "0xA08764", VA = "0xA08764")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600034D")]
			[Address(RVA = "0xA0876C", Offset = "0xA0876C", VA = "0xA0876C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool DataProtectionPromptShown
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0xA08774", Offset = "0xA08774", VA = "0xA08774")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600034F")]
			[Address(RVA = "0xA0877C", Offset = "0xA0877C", VA = "0xA0877C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public int DataProtectionAds
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0xA08788", Offset = "0xA08788", VA = "0xA08788")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000351")]
			[Address(RVA = "0xA08790", Offset = "0xA08790", VA = "0xA08790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public int DataProtectionAnalytics
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0xA08798", Offset = "0xA08798", VA = "0xA08798")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000353")]
			[Address(RVA = "0xA087A0", Offset = "0xA087A0", VA = "0xA087A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public bool DataProtectionAccepted
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xA087A8", Offset = "0xA087A8", VA = "0xA087A8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000355")]
			[Address(RVA = "0xA087B0", Offset = "0xA087B0", VA = "0xA087B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xA06BDC", Offset = "0xA06BDC", VA = "0xA06BDC")]
		public SerializableState()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[CreateAssetMenu(fileName = "PlayerStateDebug", menuName = "ScriptableObjects/Debug/Player State Debug", order = 2)]
	public class SerializableStateDebug : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000067")]
		public class IntArrayClass
		{
			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int[] StarsPerLevel;

			[Token(Token = "0x6000359")]
			[Address(RVA = "0xA087D8", Offset = "0xA087D8", VA = "0xA087D8")]
			public IntArrayClass()
			{
			}
		}

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntArrayClass[] StarsPerLevel;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] RetriesPerLevel;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] ScorePerMiniGame;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int PrimaryCurrency;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] InventoryBows;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int[] InventoryArrows;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int CurBow;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int CurArrow;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int PremiumAimAssists;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int PremiumSlowmos;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int LatestUnlockedMiniGame;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int MiniGame;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int[] TutorialSteps;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int TutorialNavBar;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool TutorialBoosters;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int BowHand;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int DataProtectionUser;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool DataProtectionPromptShown;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int DataProtectionAds;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int DataProtectionAnalytics;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool DataProtectionAccepted;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xA07CE0", Offset = "0xA07CE0", VA = "0xA07CE0")]
		public void Apply(SerializableState state)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xA087BC", Offset = "0xA087BC", VA = "0xA087BC")]
		public SerializableStateDebug()
		{
		}
	}
	[Token(Token = "0x2000068")]
	internal class StateSerializer
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly SerializableState _state;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xA06BF4", Offset = "0xA06BF4", VA = "0xA06BF4")]
		public StateSerializer(SerializableState state)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xA06C44", Offset = "0xA06C44", VA = "0xA06C44")]
		public void Reset()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xA06F90", Offset = "0xA06F90", VA = "0xA06F90")]
		public void Load()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xA0768C", Offset = "0xA0768C", VA = "0xA0768C")]
		public void Save()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xA07C5C", Offset = "0xA07C5C", VA = "0xA07C5C")]
		public void SaveConsumables()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class Prop : MonoBehaviour
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA087E0", Offset = "0xA087E0", VA = "0xA087E0", Slot = "4")]
		public virtual void Hit(RaycastHit hit, Vector3 velocity, bool penetrated)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA08828", Offset = "0xA08828", VA = "0xA08828", Slot = "5")]
		protected virtual void ReactToHit(RaycastHit hit, Vector3 velocity)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA0882C", Offset = "0xA0882C", VA = "0xA0882C")]
		public Prop()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class StaticProp : Prop
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RandomSound Sound;

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA08834", Offset = "0xA08834", VA = "0xA08834", Slot = "5")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA08854", Offset = "0xA08854", VA = "0xA08854")]
		public StaticProp()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class QualityManager : MonoBehaviour
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnQualityApplied;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EDKG.ArcheryRange.PostLut.PostLut PostProcessing;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string[] _names;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _curQuality;

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xA0885C", Offset = "0xA0885C", VA = "0xA0885C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xA08984", Offset = "0xA08984", VA = "0xA08984")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xA089FC", Offset = "0xA089FC", VA = "0xA089FC")]
		private void OnQualityChangedEvent(int value)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xA08908", Offset = "0xA08908", VA = "0xA08908")]
		private void UpdateQuality()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xA08A08", Offset = "0xA08A08", VA = "0xA08A08")]
		private void UpdatePostProcessing()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xA08A34", Offset = "0xA08A34", VA = "0xA08A34")]
		public QualityManager()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class Activator : Target
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject RegularHitObject;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Animator Animator;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public RandomSound Sound;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _animationStartActivatedHash;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _animationHitHash;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _animationResetHash;

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xA08A3C", Offset = "0xA08A3C", VA = "0xA08A3C", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xA08B0C", Offset = "0xA08B0C", VA = "0xA08B0C", Slot = "7")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xA08B34", Offset = "0xA08B34", VA = "0xA08B34", Slot = "12")]
		protected override int DeterminePrecision(RaycastHit hit)
		{
			return default(int);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xA08BC4", Offset = "0xA08BC4", VA = "0xA08BC4", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xA08BFC", Offset = "0xA08BFC", VA = "0xA08BFC")]
		public Activator()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class ActivationGroup : DynamicObject
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target[] GroupMembers;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xA08C24", Offset = "0xA08C24", VA = "0xA08C24", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xA08CCC", Offset = "0xA08CCC", VA = "0xA08CCC")]
		public ActivationGroup()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class DynamicObject : MonoBehaviour
	{
		[Token(Token = "0x6000371")]
		public abstract void Activate();

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xA08CDC", Offset = "0xA08CDC", VA = "0xA08CDC", Slot = "5")]
		public virtual void Deactivate()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xA08CD4", Offset = "0xA08CD4", VA = "0xA08CD4")]
		protected DynamicObject()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class Target : DynamicObject
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<int, RaycastHit> OnTargetHit;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Target> OnTargetKilled;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<Target> OnTargetReset;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ActiveAtStart;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool KilledOnHit;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform HomingArrowTarget;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isAlive;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _isActive;

		[Token(Token = "0x1700007A")]
		public bool IsAlive
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xA08CE0", Offset = "0xA08CE0", VA = "0xA08CE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public bool IsActive
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xA08CE8", Offset = "0xA08CE8", VA = "0xA08CE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xA08B00", Offset = "0xA08B00", VA = "0xA08B00", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xA08CF0", Offset = "0xA08CF0", VA = "0xA08CF0", Slot = "4")]
		public sealed override void Activate()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xA08B30", Offset = "0xA08B30", VA = "0xA08B30", Slot = "7")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xA08D70", Offset = "0xA08D70", VA = "0xA08D70", Slot = "5")]
		public sealed override void Deactivate()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xA08D94", Offset = "0xA08D94", VA = "0xA08D94", Slot = "8")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xA08D98", Offset = "0xA08D98", VA = "0xA08D98", Slot = "9")]
		public virtual Transform Hit(RaycastHit hit, Vector3 velocity, bool penetrated, out int precision)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xA08F4C", Offset = "0xA08F4C", VA = "0xA08F4C", Slot = "10")]
		protected virtual void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xA08F50", Offset = "0xA08F50", VA = "0xA08F50", Slot = "11")]
		protected virtual Transform GetCustomTransformForArrowToStickTo()
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xA08F58", Offset = "0xA08F58", VA = "0xA08F58", Slot = "12")]
		protected virtual int DeterminePrecision(RaycastHit hit)
		{
			return default(int);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xA08F60", Offset = "0xA08F60", VA = "0xA08F60", Slot = "13")]
		protected virtual void Die()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xA09028", Offset = "0xA09028", VA = "0xA09028", Slot = "14")]
		protected virtual void TakeDamage(int precision)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xA08C10", Offset = "0xA08C10", VA = "0xA08C10")]
		public Target()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class Bullseye : Target
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject RegularHitObject;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject BullseyeHitObject;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Animator Animator;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RandomSound Sound;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _animationStartActivatedHash;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _animationHitHash;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _animationResetHash;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xA0902C", Offset = "0xA0902C", VA = "0xA0902C", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xA090F0", Offset = "0xA090F0", VA = "0xA090F0", Slot = "7")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xA09114", Offset = "0xA09114", VA = "0xA09114", Slot = "12")]
		protected override int DeterminePrecision(RaycastHit hit)
		{
			return default(int);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xA091DC", Offset = "0xA091DC", VA = "0xA091DC", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xA09214", Offset = "0xA09214", VA = "0xA09214")]
		public Bullseye()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class CrusaderShield : Target
	{
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Multiuse;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform Body;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RagdollShield RagdollPrefab;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject BullseyeHitObject;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RandomSound Sound;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _customTransformToStickTo;

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xA09228", Offset = "0xA09228", VA = "0xA09228", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xA09260", Offset = "0xA09260", VA = "0xA09260", Slot = "7")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xA09298", Offset = "0xA09298", VA = "0xA09298", Slot = "8")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xA092EC", Offset = "0xA092EC", VA = "0xA092EC", Slot = "12")]
		protected override int DeterminePrecision(RaycastHit hit)
		{
			return default(int);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xA09384", Offset = "0xA09384", VA = "0xA09384", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xA0965C", Offset = "0xA0965C", VA = "0xA0965C", Slot = "11")]
		protected override Transform GetCustomTransformForArrowToStickTo()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xA09664", Offset = "0xA09664", VA = "0xA09664")]
		public CrusaderShield()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class Dummy : Target
	{
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject[] RegularHitObject;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject[] BullseyeHitObject;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool HealOnActivation;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Animator Animator;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RandomSound Sound;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public RandomSound Sound2;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _animationStartActivatedHash;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _animationHitHash;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _animationResetHash;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _animationGoDownHash;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _animationNonLethalHitHash;

		[Token(Token = "0x4000285")]
		private const int MaxHealth = 2;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _health;

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xA09678", Offset = "0xA09678", VA = "0xA09678", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xA09798", Offset = "0xA09798", VA = "0xA09798", Slot = "7")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xA097D0", Offset = "0xA097D0", VA = "0xA097D0", Slot = "8")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xA097F4", Offset = "0xA097F4", VA = "0xA097F4", Slot = "12")]
		protected override int DeterminePrecision(RaycastHit hit)
		{
			return default(int);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xA0992C", Offset = "0xA0992C", VA = "0xA0992C", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xA09994", Offset = "0xA09994", VA = "0xA09994", Slot = "14")]
		protected override void TakeDamage(int precision)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xA099BC", Offset = "0xA099BC", VA = "0xA099BC")]
		public Dummy()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class ConstantRotator : MonoBehaviour
	{
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Speed;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool RandomizeStartRotation;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float RandomizeSpeed;

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xA099D8", Offset = "0xA099D8", VA = "0xA099D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xA09B0C", Offset = "0xA09B0C", VA = "0xA09B0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xA09B98", Offset = "0xA09B98", VA = "0xA09B98")]
		public ConstantRotator()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class Deactivator : DynamicObject
	{
		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] ToDeactivate;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xA09BA0", Offset = "0xA09BA0", VA = "0xA09BA0", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xA09C10", Offset = "0xA09C10", VA = "0xA09C10", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xA09C80", Offset = "0xA09C80", VA = "0xA09C80")]
		public Deactivator()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class DelayedActivator : DynamicObject
	{
		[Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class <Timer>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayedActivator <>4__this;

			[Token(Token = "0x1700007C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003A1")]
				[Address(RVA = "0xA09F9C", Offset = "0xA09F9C", VA = "0xA09F9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003A3")]
				[Address(RVA = "0xA09FE4", Offset = "0xA09FE4", VA = "0xA09FE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0xA09DB4", Offset = "0xA09DB4", VA = "0xA09DB4")]
			[DebuggerHidden]
			public <Timer>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600039F")]
			[Address(RVA = "0xA09E50", Offset = "0xA09E50", VA = "0xA09E50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0xA09E54", Offset = "0xA09E54", VA = "0xA09E54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xA09FA4", Offset = "0xA09FA4", VA = "0xA09FA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DelayedActivatorAudioPlayer AudioPlayer;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float[] Delays;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Coroutine _delayedCoroutine;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _nextStep;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xA09C88", Offset = "0xA09C88", VA = "0xA09C88", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xA09D4C", Offset = "0xA09D4C", VA = "0xA09D4C")]
		[IteratorStateMachine(typeof(<Timer>d__6))]
		private IEnumerator Timer()
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xA09DDC", Offset = "0xA09DDC", VA = "0xA09DDC")]
		public DelayedActivator()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class DelayedActivatorAudioPlayerTarget : DynamicObject
	{
		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DelayedActivatorAudioPlayer AudioPlayer;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Delay;

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xA09FEC", Offset = "0xA09FEC", VA = "0xA09FEC", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xA0A010", Offset = "0xA0A010", VA = "0xA0A010")]
		public DelayedActivatorAudioPlayerTarget()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class DelayedDeactivator : DynamicObject
	{
		[Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class <Mode0>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayedDeactivator <>4__this;

			[Token(Token = "0x1700007E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003AF")]
				[Address(RVA = "0xA0A4E4", Offset = "0xA0A4E4", VA = "0xA0A4E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0xA0A52C", Offset = "0xA0A52C", VA = "0xA0A52C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xA0A200", Offset = "0xA0A200", VA = "0xA0A200")]
			[DebuggerHidden]
			public <Mode0>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xA0A288", Offset = "0xA0A288", VA = "0xA0A288", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xA0A28C", Offset = "0xA0A28C", VA = "0xA0A28C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xA0A4EC", Offset = "0xA0A4EC", VA = "0xA0A4EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class <Mode1>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayedDeactivator <>4__this;

			[Token(Token = "0x17000080")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B5")]
				[Address(RVA = "0xA0A798", Offset = "0xA0A798", VA = "0xA0A798", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B7")]
				[Address(RVA = "0xA0A7E0", Offset = "0xA0A7E0", VA = "0xA0A7E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xA0A228", Offset = "0xA0A228", VA = "0xA0A228")]
			[DebuggerHidden]
			public <Mode1>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xA0A534", Offset = "0xA0A534", VA = "0xA0A534", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xA0A538", Offset = "0xA0A538", VA = "0xA0A538", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xA0A7A0", Offset = "0xA0A7A0", VA = "0xA0A7A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class <Mode2>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayedDeactivator <>4__this;

			[Token(Token = "0x17000082")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003BB")]
				[Address(RVA = "0xA0AA5C", Offset = "0xA0AA5C", VA = "0xA0AA5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003BD")]
				[Address(RVA = "0xA0AAA4", Offset = "0xA0AAA4", VA = "0xA0AAA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xA0A250", Offset = "0xA0A250", VA = "0xA0A250")]
			[DebuggerHidden]
			public <Mode2>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xA0A7E8", Offset = "0xA0A7E8", VA = "0xA0A7E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xA0A7EC", Offset = "0xA0A7EC", VA = "0xA0A7EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xA0AA64", Offset = "0xA0AA64", VA = "0xA0AA64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target[] TargetsToCheck;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int TargetCheckMode;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Delay;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DynamicObject[] ToDeactivate;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float SecondaryDelay;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DynamicObject[] SecondaryToActivate;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DynamicObject[] SecondaryToDeactivate;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Coroutine _delayedCoroutine;

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xA0A018", Offset = "0xA0A018", VA = "0xA0A018", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xA0A1AC", Offset = "0xA0A1AC", VA = "0xA0A1AC")]
		private bool CheckIfGroupAlive()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xA0A074", Offset = "0xA0A074", VA = "0xA0A074")]
		[IteratorStateMachine(typeof(<Mode0>d__11))]
		private IEnumerator Mode0()
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xA0A0DC", Offset = "0xA0A0DC", VA = "0xA0A0DC")]
		[IteratorStateMachine(typeof(<Mode1>d__12))]
		private IEnumerator Mode1()
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xA0A144", Offset = "0xA0A144", VA = "0xA0A144")]
		[IteratorStateMachine(typeof(<Mode2>d__13))]
		private IEnumerator Mode2()
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xA0A278", Offset = "0xA0A278", VA = "0xA0A278")]
		public DelayedDeactivator()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class DelayedDeactivatorSimple : DynamicObject
	{
		[Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class <DelayedDeactivation>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayedDeactivatorSimple <>4__this;

			[Token(Token = "0x17000084")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003C4")]
				[Address(RVA = "0xA0AD48", Offset = "0xA0AD48", VA = "0xA0AD48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003C6")]
				[Address(RVA = "0xA0AD90", Offset = "0xA0AD90", VA = "0xA0AD90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xA0AB50", Offset = "0xA0AB50", VA = "0xA0AB50")]
			[DebuggerHidden]
			public <DelayedDeactivation>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xA0AB88", Offset = "0xA0AB88", VA = "0xA0AB88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xA0AB8C", Offset = "0xA0AB8C", VA = "0xA0AB8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xA0AD50", Offset = "0xA0AD50", VA = "0xA0AD50", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject Target;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Delay;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Target MakeSureTargetIsAlive;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Target[] CheckIfAnyOfTheTargetsAreAvailable;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DynamicObject[] ToActivateOnDeactivation;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xA0AAAC", Offset = "0xA0AAAC", VA = "0xA0AAAC", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xA0AAE8", Offset = "0xA0AAE8", VA = "0xA0AAE8")]
		[IteratorStateMachine(typeof(<DelayedDeactivation>d__6))]
		private IEnumerator DelayedDeactivation()
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xA0AB78", Offset = "0xA0AB78", VA = "0xA0AB78")]
		public DelayedDeactivatorSimple()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class ManualTweenerStepCompleteActivator : MonoBehaviour
	{
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Target MakeSureTargetIsAlive;

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xA0AD98", Offset = "0xA0AD98", VA = "0xA0AD98")]
		public void OnStepComplete()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xA0AE68", Offset = "0xA0AE68", VA = "0xA0AE68")]
		public ManualTweenerStepCompleteActivator()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class ManualTween : MonoBehaviour
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Parameters")]
		public bool PlayOnAwake;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool PlayAsSequence;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool LocalSpace;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool UseCurValueAsStep;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool Close;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Tween type")]
		public int TweenType;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RotateMode RotateMode;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Waypoints")]
		public Vector3[] To;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Step parameters")]
		public float Duration;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Delay;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Easing")]
		public Ease EaseType;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Header("Loops")]
		public int Loops;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LoopType LoopType;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Events")]
		public UnityEvent OnStepCompleteEvent;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnSequnceCompleteEvent;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnCompleteEvent;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Vector3> _to;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Tween _curTween;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _nextStep;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _curLoop;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _curLoopDirection;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _lastStep;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _isSequenceComplete;

		[Token(Token = "0x17000086")]
		public List<Vector3> FinalTo
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0xA0AE70", Offset = "0xA0AE70", VA = "0xA0AE70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xA0AE78", Offset = "0xA0AE78", VA = "0xA0AE78")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xA0B044", Offset = "0xA0B044", VA = "0xA0B044")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xA0B054", Offset = "0xA0B054", VA = "0xA0B054")]
		[ContextMenu("Activate")]
		public void Play()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xA0B4F0", Offset = "0xA0B4F0", VA = "0xA0B4F0")]
		public void SetToPreviousStep()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xA0B51C", Offset = "0xA0B51C", VA = "0xA0B51C")]
		public void SetToNextStep()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xA0B548", Offset = "0xA0B548", VA = "0xA0B548")]
		public void SetToStep(int step)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xA0B264", Offset = "0xA0B264", VA = "0xA0B264")]
		private void TweenToNextStep()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xA0B580", Offset = "0xA0B580", VA = "0xA0B580")]
		private void OnStepComplete()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xA0B630", Offset = "0xA0B630", VA = "0xA0B630")]
		private void OnSequenceComplete()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xA0B6AC", Offset = "0xA0B6AC", VA = "0xA0B6AC")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xA0B6C8", Offset = "0xA0B6C8", VA = "0xA0B6C8")]
		public void PreviousStep()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xA0B6D4", Offset = "0xA0B6D4", VA = "0xA0B6D4")]
		public void GoToStep(int id)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xA0B0C0", Offset = "0xA0B0C0", VA = "0xA0B0C0")]
		private void SetValue(int step)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xA0B6DC", Offset = "0xA0B6DC", VA = "0xA0B6DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xA0B6F4", Offset = "0xA0B6F4", VA = "0xA0B6F4")]
		public ManualTween()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class MultiActivator : DynamicObject
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xA0B720", Offset = "0xA0B720", VA = "0xA0B720", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xA0B790", Offset = "0xA0B790", VA = "0xA0B790", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xA0B800", Offset = "0xA0B800", VA = "0xA0B800")]
		public MultiActivator()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class RandomTranslator : DynamicObject
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool RandomizeOnAwake;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UseCurValueAsStep;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool LocalSpace;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] Positions;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vector3> _positions;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xA0B808", Offset = "0xA0B808", VA = "0xA0B808")]
		private void Start()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xA0B9C4", Offset = "0xA0B9C4", VA = "0xA0B9C4", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xA0B8FC", Offset = "0xA0B8FC", VA = "0xA0B8FC")]
		private void Randomize()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xA0B9C8", Offset = "0xA0B9C8", VA = "0xA0B9C8")]
		public RandomTranslator()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class RotatingShield : DynamicObject
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleTween tween;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Target Target;

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xA0B9D8", Offset = "0xA0B9D8", VA = "0xA0B9D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xA0BA5C", Offset = "0xA0BA5C", VA = "0xA0BA5C", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xA0BA94", Offset = "0xA0BA94", VA = "0xA0BA94", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xA0BAB4", Offset = "0xA0BAB4", VA = "0xA0BAB4")]
		private void OnRotatorDeactivated()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xA0BAD4", Offset = "0xA0BAD4", VA = "0xA0BAD4")]
		public RotatingShield()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class SimpleManualTweener : DynamicObject
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ManualTween ManualTween;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ActivateStepId;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int DeactivateStepId;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ForceStartFromPreviousStep;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool InstantDeactivation;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xA0BADC", Offset = "0xA0BADC", VA = "0xA0BADC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xA0BBE8", Offset = "0xA0BBE8", VA = "0xA0BBE8", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xA0BC30", Offset = "0xA0BC30", VA = "0xA0BC30", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xA0BC84", Offset = "0xA0BC84", VA = "0xA0BC84")]
		public void CancelDeactivation()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xA0BCB4", Offset = "0xA0BCB4", VA = "0xA0BCB4")]
		public SimpleManualTweener()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class SimpleMover : DynamicObject
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action OnHideCompleteCallback;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DOTweenAnimation _animation;

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xA0BCC4", Offset = "0xA0BCC4", VA = "0xA0BCC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xA0BD14", Offset = "0xA0BD14", VA = "0xA0BD14", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xA0BD6C", Offset = "0xA0BD6C", VA = "0xA0BD6C", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xA0BD18", Offset = "0xA0BD18", VA = "0xA0BD18")]
		private void Show()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xA0BD70", Offset = "0xA0BD70", VA = "0xA0BD70")]
		private void Hide()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xA0BDC4", Offset = "0xA0BDC4", VA = "0xA0BDC4")]
		public void OnHideComplete()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xA0BDE0", Offset = "0xA0BDE0", VA = "0xA0BDE0")]
		public SimpleMover()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class SimpleTween : DynamicObject
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action OnHideCompleteCallback;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DOTweenAnimation _animation;

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xA0BDE8", Offset = "0xA0BDE8", VA = "0xA0BDE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xA0BE38", Offset = "0xA0BE38", VA = "0xA0BE38", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xA0BE8C", Offset = "0xA0BE8C", VA = "0xA0BE8C", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xA0BEE0", Offset = "0xA0BEE0", VA = "0xA0BEE0")]
		public void OnHideComplete()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xA0BEFC", Offset = "0xA0BEFC", VA = "0xA0BEFC")]
		public SimpleTween()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class TwoStepRotator : DynamicObject
	{
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xA0BF04", Offset = "0xA0BF04", VA = "0xA0BF04", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xA0BF08", Offset = "0xA0BF08", VA = "0xA0BF08")]
		public TwoStepRotator()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class Pumpkin : Target
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Multiuse;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RandomSound Sound;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform Body;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PumpkinFragments FragmentsPrefab;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _customTransformToStickTo;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xA0BF10", Offset = "0xA0BF10", VA = "0xA0BF10", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xA0BF6C", Offset = "0xA0BF6C", VA = "0xA0BF6C", Slot = "7")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xA0BFF0", Offset = "0xA0BFF0", VA = "0xA0BFF0", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xA0C3F8", Offset = "0xA0C3F8", VA = "0xA0C3F8", Slot = "11")]
		protected override Transform GetCustomTransformForArrowToStickTo()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xA0C400", Offset = "0xA0C400", VA = "0xA0C400")]
		public Pumpkin()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class PumpkinFragments : MonoBehaviour
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] Parts;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody[] _rigidbodies;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] _posList;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion[] _rotList;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _life;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _curLife;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _shouldDisintegrate;

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xA0C414", Offset = "0xA0C414", VA = "0xA0C414")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xA0C270", Offset = "0xA0C270", VA = "0xA0C270")]
		public void Init(SpawnPool pool, float forceMin, float forceMax)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xA0C610", Offset = "0xA0C610", VA = "0xA0C610")]
		private void ResetToInitialState()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xA0C798", Offset = "0xA0C798", VA = "0xA0C798")]
		private void Explode(float forceMin, float forceMax)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xA0C30C", Offset = "0xA0C30C", VA = "0xA0C30C")]
		public Rigidbody GetImpactPart(Vector3 point)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xA0C890", Offset = "0xA0C890", VA = "0xA0C890")]
		private void Update()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xA0C8F4", Offset = "0xA0C8F4", VA = "0xA0C8F4")]
		private void Disintegrate()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xA0CAEC", Offset = "0xA0CAEC", VA = "0xA0CAEC")]
		private void Despawn()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xA0CA7C", Offset = "0xA0CA7C", VA = "0xA0CA7C")]
		private void LockInPlace()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xA0CB18", Offset = "0xA0CB18", VA = "0xA0CB18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xA0CBA0", Offset = "0xA0CBA0", VA = "0xA0CBA0")]
		public PumpkinFragments()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class RagdollShield : MonoBehaviour
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Body;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _life;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _curLife;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _shouldDisintegrate;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xA0CBB0", Offset = "0xA0CBB0", VA = "0xA0CBB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xA09590", Offset = "0xA09590", VA = "0xA09590")]
		public void Init(SpawnPool pool, Vector3 velocity, Vector3 point)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xA0CC10", Offset = "0xA0CC10", VA = "0xA0CC10")]
		private void ResetToInitialState()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xA0CD28", Offset = "0xA0CD28", VA = "0xA0CD28")]
		private void ApplyForce(Vector3 velocity, Vector3 point)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xA0CDA8", Offset = "0xA0CDA8", VA = "0xA0CDA8")]
		private void Update()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xA0CE0C", Offset = "0xA0CE0C", VA = "0xA0CE0C")]
		private void Disintegrate()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xA0CF44", Offset = "0xA0CF44", VA = "0xA0CF44")]
		private void Despawn()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xA0CF24", Offset = "0xA0CF24", VA = "0xA0CF24")]
		private void LockInPlace()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xA0CF70", Offset = "0xA0CF70", VA = "0xA0CF70")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xA0CFA0", Offset = "0xA0CFA0", VA = "0xA0CFA0")]
		public RagdollShield()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class Sandbag : Target
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RandomSound Sound;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xA0CFB0", Offset = "0xA0CFB0", VA = "0xA0CFB0", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xA0D008", Offset = "0xA0D008", VA = "0xA0D008", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xA0D0B4", Offset = "0xA0D0B4", VA = "0xA0D0B4")]
		public Sandbag()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class FollowPosRot : MonoBehaviour
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Target;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xA0D0C8", Offset = "0xA0D0C8", VA = "0xA0D0C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xA0D168", Offset = "0xA0D168", VA = "0xA0D168")]
		public FollowPosRot()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class RotationOffsetTest : MonoBehaviour
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Pivot;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform SecondObj;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Bow;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _dir;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xA0D170", Offset = "0xA0D170", VA = "0xA0D170")]
		private void Update()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xA0D188", Offset = "0xA0D188", VA = "0xA0D188")]
		private void CalculateVector()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xA0D2C4", Offset = "0xA0D2C4", VA = "0xA0D2C4")]
		private void CalculateRotation()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xA0D424", Offset = "0xA0D424", VA = "0xA0D424")]
		public RotationOffsetTest()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class TestInput : MonoBehaviour
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputAction Action;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image Image;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color Idle;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color Started;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color Canceled;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Color Performed;

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xA0D42C", Offset = "0xA0D42C", VA = "0xA0D42C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xA0D578", Offset = "0xA0D578", VA = "0xA0D578")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xA0D6A4", Offset = "0xA0D6A4", VA = "0xA0D6A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xA0D6C0", Offset = "0xA0D6C0", VA = "0xA0D6C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xA0D6DC", Offset = "0xA0D6DC", VA = "0xA0D6DC")]
		private void OnStarted(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xA0D70C", Offset = "0xA0D70C", VA = "0xA0D70C")]
		private void OnPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xA0D73C", Offset = "0xA0D73C", VA = "0xA0D73C")]
		private void OnCanceled(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xA0D76C", Offset = "0xA0D76C", VA = "0xA0D76C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xA0D804", Offset = "0xA0D804", VA = "0xA0D804")]
		public TestInput()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class PrivacyWindow : ModalWindow
	{
		[Token(Token = "0x6000424")]
		[Address(RVA = "0xA0D834", Offset = "0xA0D834", VA = "0xA0D834")]
		public void OnPrivacyPolicyBtn()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xA0D8B0", Offset = "0xA0D8B0", VA = "0xA0D8B0")]
		public void OnPrivacyOptOutBtn()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xA0D968", Offset = "0xA0D968", VA = "0xA0D968")]
		private void OnURLReceived(string url)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xA0D974", Offset = "0xA0D974", VA = "0xA0D974")]
		public PrivacyWindow()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class MiniGameUI : MonoBehaviour
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Localize NameLabel;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocalizationParamsManager NameLabelParams;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image Portrait;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject LockIcon;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CanvasGroup HighlightIcon;

		[Token(Token = "0x17000087")]
		public bool IsLocked
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0xA0D97C", Offset = "0xA0D97C", VA = "0xA0D97C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0xA0D984", Offset = "0xA0D984", VA = "0xA0D984")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xA0D990", Offset = "0xA0D990", VA = "0xA0D990")]
		public void Refresh(MiniGameData mgd, int id, int targets, bool isLocked)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xA0DB84", Offset = "0xA0DB84", VA = "0xA0DB84")]
		public void ShakeLocked()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xA0DC9C", Offset = "0xA0DC9C", VA = "0xA0DC9C")]
		public void Highlight(bool value)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xA0DDA4", Offset = "0xA0DDA4", VA = "0xA0DDA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xA0DDCC", Offset = "0xA0DDCC", VA = "0xA0DDCC")]
		public MiniGameUI()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class BowHolster : MonoBehaviour
	{
		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Offset;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Body _body;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xA0DDD4", Offset = "0xA0DDD4", VA = "0xA0DDD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xA0E02C", Offset = "0xA0E02C", VA = "0xA0E02C")]
		[ContextMenu("Update")]
		private void UpdateInEditor()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xA0E030", Offset = "0xA0E030", VA = "0xA0E030")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xA0DE48", Offset = "0xA0DE48", VA = "0xA0DE48")]
		private void CalculatePosAndRot()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xA0E034", Offset = "0xA0E034", VA = "0xA0E034")]
		public BowHolster()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class GrabPose : MonoBehaviour
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int PoseId;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool AllowPointer;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool AllowThumb;

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xA0E048", Offset = "0xA0E048", VA = "0xA0E048")]
		public GrabPose()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class HandAnimator : MonoBehaviour
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator Animator;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Debug;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public int DebugPointerTouch;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public int DebugThumbTouch;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float DebugGrip;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float DebugTrigger;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int DebugGrabPose;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool DebugGrabAllowPointer;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool DebugGrabAllowThumb;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private readonly int _triggerHash;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly int _gripHash;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private readonly int _grabPoseHash;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly int _grabHash;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly int _releaseHash;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _allowPointer;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _pointerValue;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _pointerValueSmooth;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool _allowThumb;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _thumbValue;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _thumbValueSmooth;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xA0E050", Offset = "0xA0E050", VA = "0xA0E050")]
		private void Update()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xA0E1CC", Offset = "0xA0E1CC", VA = "0xA0E1CC")]
		public void SetTriggerValue(float value)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xA0E1F0", Offset = "0xA0E1F0", VA = "0xA0E1F0")]
		public void SetGripValue(float value)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xA0E214", Offset = "0xA0E214", VA = "0xA0E214")]
		public void SetPointerTouchValue(bool value)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xA0E234", Offset = "0xA0E234", VA = "0xA0E234")]
		public void SetThumbTouchValue(bool value)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xA0E254", Offset = "0xA0E254", VA = "0xA0E254")]
		public void SetGrabPose(GrabPose pose)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xA0E080", Offset = "0xA0E080", VA = "0xA0E080")]
		private void SmoothPointerTouch()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xA0E108", Offset = "0xA0E108", VA = "0xA0E108")]
		private void SmoothThumbTouch()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xA0E190", Offset = "0xA0E190", VA = "0xA0E190")]
		private void DebugUpdateAnimator()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xA0E340", Offset = "0xA0E340", VA = "0xA0E340")]
		[ContextMenu("Reset Grab Pose")]
		private void DebugResetGrabPose()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xA0E364", Offset = "0xA0E364", VA = "0xA0E364")]
		[ContextMenu("Grab Pose")]
		private void DebugSetGrabPose()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xA0E3B4", Offset = "0xA0E3B4", VA = "0xA0E3B4")]
		public HandAnimator()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class HandController : MonoBehaviour
	{
		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference PointerTouchingActionReference;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputActionReference ThumbTouchingActionReference;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference TriggerActionReference;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference GripActionReference;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private XRDirectInteractor _handInteractor;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HandAnimator _handAnimator;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private InputAction _pointerTouchingAction;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InputAction _thumbTouchingAction;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InputAction _triggerAction;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InputAction _gripAction;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _isPointerTouching;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _isThumbTouching;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _pointerTouchingValue;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _thumbTouchingValue;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _triggerValue;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _gripValue;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GrabPose _grabPose;

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xA0E4B8", Offset = "0xA0E4B8", VA = "0xA0E4B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xA0E8AC", Offset = "0xA0E8AC", VA = "0xA0E8AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xA0EBFC", Offset = "0xA0EBFC", VA = "0xA0EBFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xA0EC4C", Offset = "0xA0EC4C", VA = "0xA0EC4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xA0EC9C", Offset = "0xA0EC9C", VA = "0xA0EC9C")]
		private void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xA0ED74", Offset = "0xA0ED74", VA = "0xA0ED74")]
		private void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xA0EE00", Offset = "0xA0EE00", VA = "0xA0EE00")]
		private void GetPointerTouchingInput(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xA0EE48", Offset = "0xA0EE48", VA = "0xA0EE48")]
		private void GetThumbTouchingInput(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xA0EE90", Offset = "0xA0EE90", VA = "0xA0EE90")]
		private void GetTriggerInput(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xA0EEFC", Offset = "0xA0EEFC", VA = "0xA0EEFC")]
		private void GetGripInput(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xA0ED54", Offset = "0xA0ED54", VA = "0xA0ED54")]
		public void SetGrabPose(GrabPose pose)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xA0ED78", Offset = "0xA0ED78", VA = "0xA0ED78")]
		private void ReleaseGrabPose()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xA0EF68", Offset = "0xA0EF68", VA = "0xA0EF68")]
		public HandController()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class GroundAmmoItem : MonoBehaviour
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteRenderer Renderer;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xA0FF70", Offset = "0xA0FF70", VA = "0xA0FF70")]
		public void SetColor(Color c)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xA0FF8C", Offset = "0xA0FF8C", VA = "0xA0FF8C")]
		public GroundAmmoItem()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class GroundAmmoManager : MonoBehaviour
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RingGenerator Container;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GroundAmmoItem> List;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(1f, 180f)]
		public float TotalAngle;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color ContainerNoAmmo;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color ContainerRegular;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color ContainerHighlight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Color ItemRegular;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Color ItemHighlight;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Color ItemTaken;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Color ItemNocked;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Color ItemAwarded;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _count;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _taken;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _nocked;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _highlighted;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int _awarded;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _visibleItems;

		[Token(Token = "0x400033E")]
		private const float _mainDirectionAngle = 0f;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _directionAngle;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float _itemAngle;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _spacingAngle;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Tween _angleTween;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Tween _directionTween;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xA0FF94", Offset = "0xA0FF94", VA = "0xA0FF94")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xA105B8", Offset = "0xA105B8", VA = "0xA105B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xA10BB4", Offset = "0xA10BB4", VA = "0xA10BB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xA11118", Offset = "0xA11118", VA = "0xA11118")]
		private void TakeArrow(EDKG.ArcheryRange.VR.Arrow arrow)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xA11128", Offset = "0xA11128", VA = "0xA11128")]
		private void ReturnArrow()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xA11138", Offset = "0xA11138", VA = "0xA11138")]
		private void NockArrow()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xA11150", Offset = "0xA11150", VA = "0xA11150")]
		private void ShootArrow(int count)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xA11180", Offset = "0xA11180", VA = "0xA11180")]
		private void AwardArrow(int count, int realCount)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xA111B0", Offset = "0xA111B0", VA = "0xA111B0")]
		private void AwardArrowReceived(int received, int count)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xA111C4", Offset = "0xA111C4", VA = "0xA111C4")]
		private void QuiverStartHover()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xA111D4", Offset = "0xA111D4", VA = "0xA111D4")]
		private void QuiverEndHover()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xA111E4", Offset = "0xA111E4", VA = "0xA111E4")]
		private void QuiverNoAmmo()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xA10BF0", Offset = "0xA10BF0", VA = "0xA10BF0")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xA11060", Offset = "0xA11060", VA = "0xA11060")]
		private void UpdateAmmoLabel()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xA111E8", Offset = "0xA111E8", VA = "0xA111E8")]
		private void Update()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xA10DA0", Offset = "0xA10DA0", VA = "0xA10DA0")]
		private void RefreshHighlights()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xA1135C", Offset = "0xA1135C", VA = "0xA1135C")]
		[ContextMenu("Refresh")]
		private void EditorRefresh()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xA115E4", Offset = "0xA115E4", VA = "0xA115E4")]
		public GroundAmmoManager()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class GroundAmmoManagerShapes : MonoBehaviour
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Disc Container;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GroundAmmoItem> List;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(1f, 180f)]
		public float TotalAngle;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color ContainerNoAmmo;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color ContainerRegular;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color ContainerHighlight;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Color ItemRegular;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Color ItemHighlight;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Color ItemTaken;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Color ItemNocked;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Color ItemAwarded;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public LocalizationParamsManager Label;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _count;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _taken;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _nocked;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _highlighted;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int _awarded;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _visibleItems;

		[Token(Token = "0x4000357")]
		private const float _mainDirectionAngle = 0f;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _directionAngle;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float _itemAngle;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _spacingAngle;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Tween _angleTween;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Tween _directionTween;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xA1160C", Offset = "0xA1160C", VA = "0xA1160C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xA11C30", Offset = "0xA11C30", VA = "0xA11C30")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xA1222C", Offset = "0xA1222C", VA = "0xA1222C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xA12788", Offset = "0xA12788", VA = "0xA12788")]
		private void TakeArrow(EDKG.ArcheryRange.VR.Arrow arrow)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xA12798", Offset = "0xA12798", VA = "0xA12798")]
		private void ReturnArrow()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xA127A8", Offset = "0xA127A8", VA = "0xA127A8")]
		private void NockArrow()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xA127C0", Offset = "0xA127C0", VA = "0xA127C0")]
		private void ShootArrow(int count)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xA127F0", Offset = "0xA127F0", VA = "0xA127F0")]
		private void AwardArrow(int count, int realCount)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xA12820", Offset = "0xA12820", VA = "0xA12820")]
		private void AwardArrowReceived(int received, int count)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xA12834", Offset = "0xA12834", VA = "0xA12834")]
		private void QuiverStartHover()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xA12844", Offset = "0xA12844", VA = "0xA12844")]
		private void QuiverEndHover()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xA12854", Offset = "0xA12854", VA = "0xA12854")]
		private void QuiverNoAmmo()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xA12268", Offset = "0xA12268", VA = "0xA12268")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xA126BC", Offset = "0xA126BC", VA = "0xA126BC")]
		private void UpdateAmmoLabel()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xA12858", Offset = "0xA12858", VA = "0xA12858")]
		private void Update()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xA12418", Offset = "0xA12418", VA = "0xA12418")]
		private void RefreshHighlights()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xA129CC", Offset = "0xA129CC", VA = "0xA129CC")]
		[ContextMenu("Refresh")]
		private void EditorRefresh()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xA12C84", Offset = "0xA12C84", VA = "0xA12C84")]
		public GroundAmmoManagerShapes()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class GroundAmmoManagerSimple : MonoBehaviour
	{
		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RingGenerator Container;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(1f, 180f)]
		public float TotalAngle;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color ContainerRegular;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color ContainerHighlight;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _highlighted;

		[Token(Token = "0x4000363")]
		private const float _mainDirectionAngle = 0f;

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xA12CAC", Offset = "0xA12CAC", VA = "0xA12CAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xA12EA0", Offset = "0xA12EA0", VA = "0xA12EA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xA13094", Offset = "0xA13094", VA = "0xA13094")]
		private void Start()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xA13100", Offset = "0xA13100", VA = "0xA13100")]
		private void QuiverStartHover()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xA13110", Offset = "0xA13110", VA = "0xA13110")]
		private void QuiverEndHover()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xA13120", Offset = "0xA13120", VA = "0xA13120")]
		private void QuiverNoAmmo()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xA1309C", Offset = "0xA1309C", VA = "0xA1309C")]
		private void RefreshHighlights()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xA13124", Offset = "0xA13124", VA = "0xA13124")]
		[ContextMenu("Refresh")]
		private void EditorRefresh()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xA1319C", Offset = "0xA1319C", VA = "0xA1319C")]
		public GroundAmmoManagerSimple()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class InGameStats : MonoBehaviour
	{
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _bowStatsPivot;

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xA131AC", Offset = "0xA131AC", VA = "0xA131AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xA1323C", Offset = "0xA1323C", VA = "0xA1323C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xA13344", Offset = "0xA13344", VA = "0xA13344")]
		public InGameStats()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class VRCrosshairToggle : MonoBehaviour
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnToggle;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference ActionReference;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputAction _action;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xA1334C", Offset = "0xA1334C", VA = "0xA1334C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xA133EC", Offset = "0xA133EC", VA = "0xA133EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xA13478", Offset = "0xA13478", VA = "0xA13478")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xA13494", Offset = "0xA13494", VA = "0xA13494")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xA134B0", Offset = "0xA134B0", VA = "0xA134B0")]
		private void OnToggleEvent(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xA13514", Offset = "0xA13514", VA = "0xA13514")]
		public VRCrosshairToggle()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class VRDebugPanelToggle : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class <DelayedPanelSetup>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mainPanel;

			[Token(Token = "0x17000088")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0xA13EEC", Offset = "0xA13EEC", VA = "0xA13EEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0xA13F34", Offset = "0xA13F34", VA = "0xA13F34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0xA13BC8", Offset = "0xA13BC8", VA = "0xA13BC8")]
			[DebuggerHidden]
			public <DelayedPanelSetup>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0xA13DAC", Offset = "0xA13DAC", VA = "0xA13DAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0xA13DB0", Offset = "0xA13DB0", VA = "0xA13DB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0xA13EF4", Offset = "0xA13EF4", VA = "0xA13EF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform LeftHand;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputActionReference ActionReference;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InputAction _action;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VRUIControllerActivation _vrUIControllerActivation;

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xA1351C", Offset = "0xA1351C", VA = "0xA1351C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xA136DC", Offset = "0xA136DC", VA = "0xA136DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xA13850", Offset = "0xA13850", VA = "0xA13850")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xA1386C", Offset = "0xA1386C", VA = "0xA1386C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xA13888", Offset = "0xA13888", VA = "0xA13888")]
		private void Start()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xA13B60", Offset = "0xA13B60", VA = "0xA13B60")]
		[IteratorStateMachine(typeof(<DelayedPanelSetup>d__9))]
		private IEnumerator DelayedPanelSetup(Transform mainPanel)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xA13BF0", Offset = "0xA13BF0", VA = "0xA13BF0")]
		private void OnToggleEvent(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xA13D68", Offset = "0xA13D68", VA = "0xA13D68")]
		private void OnPanelVisibilityChanged(bool value)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xA13DA4", Offset = "0xA13DA4", VA = "0xA13DA4")]
		public VRDebugPanelToggle()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class VRPauseToggle : MonoBehaviour
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnPauseToggle;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference PauseToggleActionReference;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputAction _pauseToggleAction;

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xA13F3C", Offset = "0xA13F3C", VA = "0xA13F3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xA13FDC", Offset = "0xA13FDC", VA = "0xA13FDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xA14068", Offset = "0xA14068", VA = "0xA14068")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xA14084", Offset = "0xA14084", VA = "0xA14084")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xA140A0", Offset = "0xA140A0", VA = "0xA140A0")]
		private void OnPauseToggleEvent(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xA14104", Offset = "0xA14104", VA = "0xA14104")]
		public VRPauseToggle()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class VRScreenshot : MonoBehaviour
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference ActionReference;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputAction _action;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference ActionReference2;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InputAction _action2;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Supersampling;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int Supersampling2;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int FOVOverride;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool FollowCamera;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera _camera;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera _targetCamera;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RenderTexture _renderTexture;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _folder;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xA1410C", Offset = "0xA1410C", VA = "0xA1410C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xA1427C", Offset = "0xA1427C", VA = "0xA1427C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xA1435C", Offset = "0xA1435C", VA = "0xA1435C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xA1438C", Offset = "0xA1438C", VA = "0xA1438C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xA143BC", Offset = "0xA143BC", VA = "0xA143BC")]
		private void OnPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xA1474C", Offset = "0xA1474C", VA = "0xA1474C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xA143C0", Offset = "0xA143C0", VA = "0xA143C0")]
		[ContextMenu("Capture")]
		private void Capture()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xA14820", Offset = "0xA14820", VA = "0xA14820")]
		private void OnPerformed2(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xA148E8", Offset = "0xA148E8", VA = "0xA148E8")]
		public VRScreenshot()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class VRScroll : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference ScrollActionReference;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SpeedModifier;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InputAction _scrollAction;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ScrollRect _scrollRect;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _isPointerEntered;

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xA14950", Offset = "0xA14950", VA = "0xA14950")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xA149B8", Offset = "0xA149B8", VA = "0xA149B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xA14A9C", Offset = "0xA14A9C", VA = "0xA14A9C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xA14AAC", Offset = "0xA14AAC", VA = "0xA14AAC", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xA14ABC", Offset = "0xA14ABC", VA = "0xA14ABC")]
		public VRScroll()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class VRUIControllerActivation : MonoBehaviour
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static VRUIControllerActivation Instance;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject LeftController;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject RightController;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isUIControllerRequired;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool OnlyActiveHand;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference TriggerLeftAction;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InputAction _triggerLeftAction;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InputActionReference TriggerRightAction;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private InputAction _triggerRightAction;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _uiScreenNeeded;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool _debugScreenNeeded;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _bowHand;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _activeHand;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xA14ACC", Offset = "0xA14ACC", VA = "0xA14ACC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xA14D48", Offset = "0xA14D48", VA = "0xA14D48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xA14F00", Offset = "0xA14F00", VA = "0xA14F00")]
		private void OnBowPicked(Bow bow, int hand, XRDirectInteractor controller)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xA14FEC", Offset = "0xA14FEC", VA = "0xA14FEC")]
		private void OnTriggerLeftPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xA15008", Offset = "0xA15008", VA = "0xA15008")]
		private void OnTriggerRightPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xA15020", Offset = "0xA15020", VA = "0xA15020")]
		public void UIScreenToggle(int state)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xA13D90", Offset = "0xA13D90", VA = "0xA13D90")]
		public void DebugScreenToggle(bool value)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xA14F08", Offset = "0xA14F08", VA = "0xA14F08")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xA150A4", Offset = "0xA150A4", VA = "0xA150A4")]
		public VRUIControllerActivation()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class ArrowPositioning : MonoBehaviour
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float HorizontalOffset;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform DummyArrowAttachPoint;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform DummyArrowHead;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform ActualArrowSpawn;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform BowHandle;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _horizontalOffsetPosition;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 _dummyDirection;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _hand;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _arrowSide;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _initialTrajectory;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xA150AC", Offset = "0xA150AC", VA = "0xA150AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xA15260", Offset = "0xA15260", VA = "0xA15260")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xA15414", Offset = "0xA15414", VA = "0xA15414")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xA1552C", Offset = "0xA1552C", VA = "0xA1552C")]
		private void OnBowPicked(Bow bow, int hand, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xA155B8", Offset = "0xA155B8", VA = "0xA155B8")]
		private void OnArrowSideChanged(int side)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xA15644", Offset = "0xA15644", VA = "0xA15644")]
		private void OnInitialTrajectoryChanged(float value)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xA1564C", Offset = "0xA1564C", VA = "0xA1564C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xA157F8", Offset = "0xA157F8", VA = "0xA157F8")]
		public ArrowPositioning()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class HandStaminaVisualization : MonoBehaviour
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer _renderer;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material _material;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color StaminaFull;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color StaminaEmpty;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color FatigueEmpty;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color FatigueFull;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Color0;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int Color1;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xA1580C", Offset = "0xA1580C", VA = "0xA1580C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xA15B64", Offset = "0xA15B64", VA = "0xA15B64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xA15D6C", Offset = "0xA15D6C", VA = "0xA15D6C")]
		private void OnBowPickedEvent(Bow bow, int hand, XRDirectInteractor handInteractor)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xA15DB8", Offset = "0xA15DB8", VA = "0xA15DB8")]
		private void OnBowDroppedEvent(Bow bow, int hand, XRDirectInteractor handInteractor)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xA15DD8", Offset = "0xA15DD8", VA = "0xA15DD8")]
		private void OnStaminaAndFatigueChangingEvent(float stamina, float fatigue)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xA15A24", Offset = "0xA15A24", VA = "0xA15A24")]
		private void UpdateStamina(float stamina, float fatigue)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xA15DDC", Offset = "0xA15DDC", VA = "0xA15DDC")]
		public HandStaminaVisualization()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class VRRecenter : MonoBehaviour
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference RecenterAction;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<XRInputSubsystem> _inputSubsystems;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InputAction _recenterAction;

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xA15EA4", Offset = "0xA15EA4", VA = "0xA15EA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xA15FD4", Offset = "0xA15FD4", VA = "0xA15FD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xA16060", Offset = "0xA16060", VA = "0xA16060")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xA1607C", Offset = "0xA1607C", VA = "0xA1607C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xA16098", Offset = "0xA16098", VA = "0xA16098")]
		private void OnRecenter(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xA16124", Offset = "0xA16124", VA = "0xA16124")]
		public VRRecenter()
		{
		}
	}
}
namespace EDKG.ArcheryRange.VR
{
	[Token(Token = "0x20000A3")]
	public class Arrow : XRGrabInteractable
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<Arrow> OnPicked;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action OnGoingHome;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action OnArrivedHome;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action OnNocked;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private bool _isNocked;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A9")]
		private bool _isShot;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AA")]
		private bool _canBeInteracted;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private Transform _home;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private Action _onDestroyCallback;

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xA1612C", Offset = "0xA1612C", VA = "0xA1612C", Slot = "47")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xA16238", Offset = "0xA16238", VA = "0xA16238")]
		public void Init(SpawnPool spawnPool, Transform home, Action onDestroyCallback)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xA162E0", Offset = "0xA162E0", VA = "0xA162E0", Slot = "54")]
		public override bool IsHoverableBy(IXRHoverInteractor interactor)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xA16310", Offset = "0xA16310", VA = "0xA16310", Slot = "55")]
		public override bool IsSelectableBy(IXRSelectInteractor interactor)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xA16340", Offset = "0xA16340", VA = "0xA16340")]
		public void Nock()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xA163B4", Offset = "0xA163B4", VA = "0xA163B4")]
		public void Shoot()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xA16484", Offset = "0xA16484", VA = "0xA16484", Slot = "68")]
		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xA164B8", Offset = "0xA164B8", VA = "0xA164B8")]
		private void GoHome()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xA166B8", Offset = "0xA166B8", VA = "0xA166B8")]
		private void OnGoHomeComplete()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xA163C0", Offset = "0xA163C0", VA = "0xA163C0")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xA1671C", Offset = "0xA1671C", VA = "0xA1671C")]
		private void OnGamePaused(bool value)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xA16774", Offset = "0xA16774", VA = "0xA16774", Slot = "50")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xA16898", Offset = "0xA16898", VA = "0xA16898")]
		public Arrow()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class ArrowAutoGrabber : MonoBehaviour
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference LeftGrabAction;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputAction _leftGrabAction;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference RightGrabAction;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InputAction _rightGrabAction;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isGrabbing;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isGrabbingLeft;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool _isGrabbingRight;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _bowHand;

		[Token(Token = "0x1700008A")]
		public bool IsGrabbing
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xA168F0", Offset = "0xA168F0", VA = "0xA168F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xA168F8", Offset = "0xA168F8", VA = "0xA168F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xA16B74", Offset = "0xA16B74", VA = "0xA16B74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xA16DC8", Offset = "0xA16DC8", VA = "0xA16DC8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xA16DF8", Offset = "0xA16DF8", VA = "0xA16DF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xA16E28", Offset = "0xA16E28", VA = "0xA16E28")]
		private void OnLeftGrab(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xA16E98", Offset = "0xA16E98", VA = "0xA16E98")]
		private void OnLeftRelease(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xA16F00", Offset = "0xA16F00", VA = "0xA16F00")]
		private void OnRightGrab(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xA16F70", Offset = "0xA16F70", VA = "0xA16F70")]
		private void OnRightRelease(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xA16FD8", Offset = "0xA16FD8", VA = "0xA16FD8")]
		public void ConfirmGrab()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xA16FE0", Offset = "0xA16FE0", VA = "0xA16FE0")]
		private void OnBowPickedEvent(Bow bow, int hand, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xA1700C", Offset = "0xA1700C", VA = "0xA1700C")]
		public ArrowAutoGrabber()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class Body : MonoBehaviour
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Head;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRBaseInteractor HandLeftInteractor;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public XRBaseInteractor HandRightInteractor;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform HandLeftModel;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform HandLeftModelAttach;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Renderer HandLeftRenderer;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform HandRightModel;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform HandRightModelAttach;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Renderer HandRightRenderer;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform QuiverLine;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform BodyPivot;

		[Token(Token = "0x1700008B")]
		public float Calibration
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xA17014", Offset = "0xA17014", VA = "0xA17014")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xA1701C", Offset = "0xA1701C", VA = "0xA1701C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xA17024", Offset = "0xA17024", VA = "0xA17024")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xA170C8", Offset = "0xA170C8", VA = "0xA170C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xA171A4", Offset = "0xA171A4", VA = "0xA171A4")]
		public void SetCalibration(float value)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xA171AC", Offset = "0xA171AC", VA = "0xA171AC")]
		public Body()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class Bow : XRGrabInteractable
	{
		[Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class <DelayedStart>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Bow <>4__this;

			[Token(Token = "0x1700008E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000505")]
				[Address(RVA = "0xA18ED0", Offset = "0xA18ED0", VA = "0xA18ED0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000507")]
				[Address(RVA = "0xA18F18", Offset = "0xA18F18", VA = "0xA18F18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0xA17650", Offset = "0xA17650", VA = "0xA17650")]
			[DebuggerHidden]
			public <DelayedStart>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0xA18E28", Offset = "0xA18E28", VA = "0xA18E28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0xA18E2C", Offset = "0xA18E2C", VA = "0xA18E2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0xA18ED8", Offset = "0xA18ED8", VA = "0xA18ED8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class <RestoreTracking>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Bow <>4__this;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <timeCounter>5__2;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool <stillGoing>5__3;

			[Token(Token = "0x17000090")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600050B")]
				[Address(RVA = "0xA192F0", Offset = "0xA192F0", VA = "0xA192F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600050D")]
				[Address(RVA = "0xA19338", Offset = "0xA19338", VA = "0xA19338", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0xA188CC", Offset = "0xA188CC", VA = "0xA188CC")]
			[DebuggerHidden]
			public <RestoreTracking>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0xA18F20", Offset = "0xA18F20", VA = "0xA18F20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0xA18F24", Offset = "0xA18F24", VA = "0xA18F24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0xA192F8", Offset = "0xA192F8", VA = "0xA192F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int BowHand;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Bow, int, XRDirectInteractor> OnPicked;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<Bow, int, XRDirectInteractor> OnDropped;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public Transform StatsPivot;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public Transform ArrowShotPivot;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public NockSlot NockSlot;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public NockPuller NockPuller;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private XRDirectInteractor _handInteractor;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private Body _body;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private bool _isCustomRotation;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
		private Quaternion _targetRotation;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
		private float _pullDistance;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private BowHolster _home;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private bool _isHome;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private XRDirectInteractor _nockHandInteractor;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private Transform _handModelTransform;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private Transform _handModelAttachTransform;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private Transform _hand2ModelTransform;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private OneEuroFilterQ _bowHandRot;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private float _bowShakingPercent;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private float _bowSmoothingPercent;

		[Token(Token = "0x1700008C")]
		public Body Body
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xA171B4", Offset = "0xA171B4", VA = "0xA171B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public XRDirectInteractor HandInteractor
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0xA171BC", Offset = "0xA171BC", VA = "0xA171BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xA171C4", Offset = "0xA171C4", VA = "0xA171C4", Slot = "47")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xA175C8", Offset = "0xA175C8", VA = "0xA175C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xA175E8", Offset = "0xA175E8", VA = "0xA175E8")]
		[IteratorStateMachine(typeof(<DelayedStart>d__27))]
		private IEnumerator DelayedStart()
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xA17678", Offset = "0xA17678", VA = "0xA17678", Slot = "50")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xA17B5C", Offset = "0xA17B5C", VA = "0xA17B5C", Slot = "66")]
		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xA17D94", Offset = "0xA17D94", VA = "0xA17D94")]
		private void DetermineHand(XRBaseInteractor interactor)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xA17E3C", Offset = "0xA17E3C", VA = "0xA17E3C")]
		private void GoToHand()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xA17F48", Offset = "0xA17F48", VA = "0xA17F48", Slot = "68")]
		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xA1801C", Offset = "0xA1801C", VA = "0xA1801C")]
		private void GoHome(bool instant = false)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xA182CC", Offset = "0xA182CC", VA = "0xA182CC")]
		private void OnNockStartedPullingEvent()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xA184C8", Offset = "0xA184C8", VA = "0xA184C8")]
		private void OnNockPulledEvent(Vector3 vector, float pullDistance, float pullDistanceFromHandle, float amount, float calibratedPullDistance, float calibratedAmount)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xA1863C", Offset = "0xA1863C", VA = "0xA1863C")]
		private void OnNockReleasedEvent(float amount)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xA18854", Offset = "0xA18854", VA = "0xA18854")]
		[IteratorStateMachine(typeof(<RestoreTracking>d__37))]
		private IEnumerator RestoreTracking(float time)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xA179B4", Offset = "0xA179B4", VA = "0xA179B4")]
		public void RestoreTrackingImmediately()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xA188F4", Offset = "0xA188F4", VA = "0xA188F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xA18D38", Offset = "0xA18D38", VA = "0xA18D38")]
		private void OnShakingChangedEvent(float percent, float amplitude)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xA18D5C", Offset = "0xA18D5C", VA = "0xA18D5C")]
		private void OnSmoothingChangedEvent(float value)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xA189C0", Offset = "0xA189C0", VA = "0xA189C0")]
		private void UpdateRotation()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xA18D78", Offset = "0xA18D78", VA = "0xA18D78")]
		public Bow()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class CustomInteractionManager : XRInteractionManager
	{
		[Token(Token = "0x600050E")]
		[Address(RVA = "0xA19340", Offset = "0xA19340", VA = "0xA19340")]
		public void ForceDeselect(XRBaseInteractor interactor)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xA193F4", Offset = "0xA193F4", VA = "0xA193F4")]
		public CustomInteractionManager()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class ForceGrabBow : MonoBehaviour
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference ForceGrabBowLeftAction;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputAction _forceGrabBowLeftAction;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference ForceGrabBowRightAction;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InputAction _forceGrabBowRightAction;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Bow _bow;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Body _body;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isGamePaused;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private XRInteractionManager _interactionManager;

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xA1944C", Offset = "0xA1944C", VA = "0xA1944C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xA19620", Offset = "0xA19620", VA = "0xA19620")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xA197CC", Offset = "0xA197CC", VA = "0xA197CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xA19884", Offset = "0xA19884", VA = "0xA19884")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xA198B4", Offset = "0xA198B4", VA = "0xA198B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xA198E4", Offset = "0xA198E4", VA = "0xA198E4")]
		private void OnForceGrabBowLeft(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xA19990", Offset = "0xA19990", VA = "0xA19990")]
		private void OnForceGrabBowRight(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xA19A3C", Offset = "0xA19A3C", VA = "0xA19A3C")]
		private void OnGamePaused(bool value)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xA19A48", Offset = "0xA19A48", VA = "0xA19A48")]
		public ForceGrabBow()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class NockPuller : XRBaseInteractable
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnNockStartedPulling;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Vector3, float, float, float, float, float> OnNockPulling;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<float> OnNockReleased;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Bow Bow;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float MaxPullDistance;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public MeshRenderer NockHighlighter;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Transform _handInteractor;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float _distanceFromHandle;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private bool _isActive;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 _pullVector;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float _pullDistance;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private float _pullAmount;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private float _calibration;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float _calibratedMaxPullDistance;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float _calibratedPullDistance;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float _calibratedPullAmount;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private SnapPoint _snapPoint;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private bool _useSnapPoint;

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xA19A50", Offset = "0xA19A50", VA = "0xA19A50", Slot = "47")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xA19D08", Offset = "0xA19D08", VA = "0xA19D08")]
		private void Start()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xA19D78", Offset = "0xA19D78", VA = "0xA19D78", Slot = "50")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xA17D84", Offset = "0xA17D84", VA = "0xA17D84")]
		public void SetBowStatus(bool active)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xA19F4C", Offset = "0xA19F4C", VA = "0xA19F4C", Slot = "66")]
		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xA1A0A0", Offset = "0xA1A0A0", VA = "0xA1A0A0", Slot = "68")]
		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xA1A168", Offset = "0xA1A168", VA = "0xA1A168", Slot = "62")]
		protected override void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xA1A254", Offset = "0xA1A254", VA = "0xA1A254", Slot = "58")]
		public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xA1A2A0", Offset = "0xA1A2A0", VA = "0xA1A2A0")]
		private void CalculatePull()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xA1A08C", Offset = "0xA1A08C", VA = "0xA1A08C")]
		private void ResetPull()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xA1A790", Offset = "0xA1A790", VA = "0xA1A790")]
		private void OnGamePaused(bool value)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xA1A7F0", Offset = "0xA1A7F0", VA = "0xA1A7F0")]
		private void OnArmLengthCalibrationChanged(float value)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xA1A838", Offset = "0xA1A838", VA = "0xA1A838")]
		private void OnSnapPointChanged(int value)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xA1A848", Offset = "0xA1A848", VA = "0xA1A848")]
		public NockPuller()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class NockSlot : MonoBehaviour
	{
		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnNocked;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NockPuller NockPuller;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DistanceToNock;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _isActive;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Arrow _potentialArrow;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Arrow _nockedArrow;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private XRInteractionManager _interactionManager;

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xA1A858", Offset = "0xA1A858", VA = "0xA1A858")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xA1ABF0", Offset = "0xA1ABF0", VA = "0xA1ABF0")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xA1AF44", Offset = "0xA1AF44", VA = "0xA1AF44")]
		public void SetBowStatus(bool active)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xA1AF50", Offset = "0xA1AF50", VA = "0xA1AF50")]
		private void OnArrowPickedEvent(Arrow arrow)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xA1AF58", Offset = "0xA1AF58", VA = "0xA1AF58")]
		private void OnArrowGoingHomeEvent()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xA1AF60", Offset = "0xA1AF60", VA = "0xA1AF60")]
		private void Update()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xA1AF70", Offset = "0xA1AF70", VA = "0xA1AF70")]
		private void ProcessNocking()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xA1B148", Offset = "0xA1B148", VA = "0xA1B148")]
		private void OnShootArrowEvent()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xA1B1CC", Offset = "0xA1B1CC", VA = "0xA1B1CC")]
		private void OnNockPulledEvent(Vector3 vector, float pullDistance, float pullDistanceFromHandle, float amount, float calibratedPullDistance, float calibratedAmount)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xA1B24C", Offset = "0xA1B24C", VA = "0xA1B24C")]
		private void OnNockReleasedEvent(float amount)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xA1B2B4", Offset = "0xA1B2B4", VA = "0xA1B2B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xA1B3CC", Offset = "0xA1B3CC", VA = "0xA1B3CC")]
		public NockSlot()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class Quiver : XRBaseInteractable
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnHoverStarted;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action OnHoverEnded;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action OnNoAmmo;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action OnAmmoReceived;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Renderer Renderer;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public Material[] Materials;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public Transform ArrowContainer;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Body _body;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Arrow _arrowPrefab;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private SpawnPool _pool;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private ArrowAutoGrabber _arrowAutoGrabber;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool _arrowTaken;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
		private bool _noAmmo;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x192")]
		private bool _gameEnded;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x193")]
		private bool _tutorialDisable;

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xA1B3E0", Offset = "0xA1B3E0", VA = "0xA1B3E0", Slot = "47")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xA1B654", Offset = "0xA1B654", VA = "0xA1B654", Slot = "50")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xA1B8C8", Offset = "0xA1B8C8", VA = "0xA1B8C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xA1B9F0", Offset = "0xA1B9F0", VA = "0xA1B9F0", Slot = "62")]
		protected override void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xA1BE84", Offset = "0xA1BE84", VA = "0xA1BE84", Slot = "64")]
		protected override void OnHoverExited(HoverExitEventArgs args)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xA1BFCC", Offset = "0xA1BFCC", VA = "0xA1BFCC", Slot = "66")]
		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xA1BC3C", Offset = "0xA1BC3C", VA = "0xA1BC3C")]
		private void GrabArrow(XRBaseInteractor interactor)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xA1C08C", Offset = "0xA1C08C", VA = "0xA1C08C")]
		private void ReEnableHover()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xA1C0B0", Offset = "0xA1C0B0", VA = "0xA1C0B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xA1C168", Offset = "0xA1C168", VA = "0xA1C168")]
		[ContextMenu("Update")]
		private void UpdateInEditor()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xA1C16C", Offset = "0xA1C16C", VA = "0xA1C16C")]
		private void OnNoAmmoEvent(int amount)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xA1C1F4", Offset = "0xA1C1F4", VA = "0xA1C1F4")]
		private void OnAvailableAmmoChangedEvent(int count, int realCount)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xA1C288", Offset = "0xA1C288", VA = "0xA1C288")]
		private void OnGameEndedEvent(int results)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xA1BBAC", Offset = "0xA1BBAC", VA = "0xA1BBAC")]
		private void RefreshMaterial()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xA1C29C", Offset = "0xA1C29C", VA = "0xA1C29C")]
		public void DisableForTutorial(bool value)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xA1C2A8", Offset = "0xA1C2A8", VA = "0xA1C2A8")]
		public Quiver()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class SnapPoint : MonoBehaviour
	{
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform RightSnappingPoint;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform LeftSnappingPoint;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float SnapSpeedMultiplier;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float UnSnapSpeedMultiplier;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BoxCollider _collider;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private LayerMask _layerMask;

		[Token(Token = "0x4000417")]
		private const float MinX = 0f;

		[Token(Token = "0x4000418")]
		private const float MaxX = 0.2f;

		[Token(Token = "0x4000419")]
		private const float MinY = -0.1f;

		[Token(Token = "0x400041A")]
		private const float MaxY = 0.1f;

		[Token(Token = "0x400041B")]
		private const float MinZ = -0.1f;

		[Token(Token = "0x400041C")]
		private const float MaxZ = 0.05f;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _isCaptured;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _snapPercent;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 _snappedControllerPos;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 DefaultSnapPointPos;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _bowIsDrawing;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _bowHand;

		[Token(Token = "0x17000092")]
		public bool IsCaptured
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xA1C2B0", Offset = "0xA1C2B0", VA = "0xA1C2B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		public bool BowIsDrawing
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xA1C2B8", Offset = "0xA1C2B8", VA = "0xA1C2B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public Vector3 BowHandSnapPosition
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xA1C2C0", Offset = "0xA1C2C0", VA = "0xA1C2C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 SnapPosition
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0xA1C2EC", Offset = "0xA1C2EC", VA = "0xA1C2EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xA1C308", Offset = "0xA1C308", VA = "0xA1C308")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xA1C4A8", Offset = "0xA1C4A8", VA = "0xA1C4A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xA1C57C", Offset = "0xA1C57C", VA = "0xA1C57C")]
		private void OnSettingsChanged(int value)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xA1C690", Offset = "0xA1C690", VA = "0xA1C690")]
		private void OnBowHandChanged(int hand)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xA1C694", Offset = "0xA1C694", VA = "0xA1C694")]
		private void Start()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xA1C580", Offset = "0xA1C580", VA = "0xA1C580")]
		private void InitSettings()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xA1C698", Offset = "0xA1C698", VA = "0xA1C698")]
		public void SetBowIsDrawing(bool value)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xA1A504", Offset = "0xA1A504", VA = "0xA1A504")]
		public Vector3 Process(Vector3 actualControllerPos, Vector3 bowPos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xA1C6A4", Offset = "0xA1C6A4", VA = "0xA1C6A4")]
		public void AddX(float value)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xA1C730", Offset = "0xA1C730", VA = "0xA1C730")]
		public void AddY(float value)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xA1C7C4", Offset = "0xA1C7C4", VA = "0xA1C7C4")]
		public void AddZ(float value)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xA1C858", Offset = "0xA1C858", VA = "0xA1C858")]
		public void ChangeX(float value)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xA1C8E0", Offset = "0xA1C8E0", VA = "0xA1C8E0")]
		public void ChangeY(float value)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xA1C96C", Offset = "0xA1C96C", VA = "0xA1C96C")]
		public void ChangeZ(float value)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xA1C9FC", Offset = "0xA1C9FC", VA = "0xA1C9FC")]
		public void ResetToDefaults()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xA1CA94", Offset = "0xA1CA94", VA = "0xA1CA94")]
		public SnapPoint()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class SnapPointCustomization : MonoBehaviour
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Speed;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SnapPoint _snapPoint;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SnapPointVisualization _snapPointVisualization;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference LeftTrigger;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InputActionReference RightTrigger;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InputActionReference LeftThumbstick;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InputActionReference RightThumbstick;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InputActionReference Reset;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InputAction _leftTrigger;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InputAction _rightTrigger;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private InputAction _leftThumbstick;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private InputAction _rightThumbstick;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private InputAction _reset;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _leftTriggerPressed;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool _rightTriggerPressed;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		private bool _isEnabled;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PlayerSettingsState _settings;

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xA1CB0C", Offset = "0xA1CB0C", VA = "0xA1CB0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xA1CE4C", Offset = "0xA1CE4C", VA = "0xA1CE4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xA1D090", Offset = "0xA1D090", VA = "0xA1D090")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xA1D0F0", Offset = "0xA1D0F0", VA = "0xA1D0F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xA1D150", Offset = "0xA1D150", VA = "0xA1D150")]
		private void OnLeftTriggerPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xA1D244", Offset = "0xA1D244", VA = "0xA1D244")]
		private void OnLeftTriggerCanceled(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xA1D350", Offset = "0xA1D350", VA = "0xA1D350")]
		private void OnRightTriggerPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xA1D404", Offset = "0xA1D404", VA = "0xA1D404")]
		private void OnRightTriggerCanceled(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xA1D494", Offset = "0xA1D494", VA = "0xA1D494")]
		private void OnResetPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xA1D4AC", Offset = "0xA1D4AC", VA = "0xA1D4AC")]
		private void OnArrowReleased()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xA1D4DC", Offset = "0xA1D4DC", VA = "0xA1D4DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xA1D6CC", Offset = "0xA1D6CC", VA = "0xA1D6CC")]
		private void RefreshVisualization()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xA1D2D8", Offset = "0xA1D2D8", VA = "0xA1D2D8")]
		private void Save()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xA1D848", Offset = "0xA1D848", VA = "0xA1D848")]
		public SnapPointCustomization()
		{
		}
	}
}
namespace EDKG.ArcheryRange.VR.Visualization
{
	[Token(Token = "0x20000B0")]
	public class BowAnimation : MonoBehaviour
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator Animator;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _animationDrawingHash;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _animationStartDrawingHash;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _animationReleaseHash;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _animationCancelHash;

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xA1D85C", Offset = "0xA1D85C", VA = "0xA1D85C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xA1DA50", Offset = "0xA1DA50", VA = "0xA1DA50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xA1DBAC", Offset = "0xA1DBAC", VA = "0xA1DBAC")]
		private void OnNockStartedPullingEvent()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xA1DBD0", Offset = "0xA1DBD0", VA = "0xA1DBD0")]
		private void OnNockPullingEvent(float amount, float rawAmount)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xA1DBF8", Offset = "0xA1DBF8", VA = "0xA1DBF8")]
		private void OnArrowReleasedEvent()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xA1DC1C", Offset = "0xA1DC1C", VA = "0xA1DC1C")]
		private void OnCancelPullEvent()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xA1DC40", Offset = "0xA1DC40", VA = "0xA1DC40")]
		public BowAnimation()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class BowPullAmountVisualizer : MonoBehaviour
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Text;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform DrawBar;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform StaminaBar;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Image StaminaBarImage;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color FullStamina;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color NoStamina;

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xA1DC48", Offset = "0xA1DC48", VA = "0xA1DC48")]
		private void Awake()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xA1DEDC", Offset = "0xA1DEDC", VA = "0xA1DEDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xA1DF9C", Offset = "0xA1DF9C", VA = "0xA1DF9C")]
		private void OnDrawChangingEvent(float amount, float rawAmount)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xA1DFC4", Offset = "0xA1DFC4", VA = "0xA1DFC4")]
		private void OnStaminaAndFatigueChangingEvent(float stamina, float fatigue)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xA1DD2C", Offset = "0xA1DD2C", VA = "0xA1DD2C")]
		private void UpdateLabel(float amount)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xA1DDEC", Offset = "0xA1DDEC", VA = "0xA1DDEC")]
		private void UpdateDrawBar(float amount)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xA1DE2C", Offset = "0xA1DE2C", VA = "0xA1DE2C")]
		private void UpdateStaminaBar(float amount)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xA1DFC8", Offset = "0xA1DFC8", VA = "0xA1DFC8")]
		public BowPullAmountVisualizer()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class BowShaking : MonoBehaviour
	{
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Bow Bow;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private XRDirectInteractor _interactor;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _attach;

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xA1DFE8", Offset = "0xA1DFE8", VA = "0xA1DFE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xA1E14C", Offset = "0xA1E14C", VA = "0xA1E14C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xA1E2B0", Offset = "0xA1E2B0", VA = "0xA1E2B0")]
		private void OnBowPickedEvent(Bow bow, int hand, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xA1E2E4", Offset = "0xA1E2E4", VA = "0xA1E2E4")]
		private void OnShakingChangedEvent(float percent, float amplitude)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xA1E504", Offset = "0xA1E504", VA = "0xA1E504")]
		public BowShaking()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class SnapPointVisualization : MonoBehaviour
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float YOffset;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float ZOffset;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SmoothFollowFactor;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image StatusIcon;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color Color0;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color Color1;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Body _body;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected Transform _camera;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 _targetPos;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion _targetRot;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _isNeeded;

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xA1E50C", Offset = "0xA1E50C", VA = "0xA1E50C")]
		protected void Awake()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xA1D208", Offset = "0xA1D208", VA = "0xA1D208")]
		public void Init(Vector3 pos)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xA1D328", Offset = "0xA1D328", VA = "0xA1D328")]
		public void Hide()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xA1D70C", Offset = "0xA1D70C", VA = "0xA1D70C")]
		public void Refresh(Vector3 pos, bool isCaptured)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xA1E5B8", Offset = "0xA1E5B8", VA = "0xA1E5B8")]
		protected void LateUpdate()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xA1E5BC", Offset = "0xA1E5BC", VA = "0xA1E5BC")]
		private void UpdatePosition()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xA1E7EC", Offset = "0xA1E7EC", VA = "0xA1E7EC")]
		public SnapPointVisualization()
		{
		}
	}
}
namespace EDKG.ArcheryRange.VR.Helper
{
	[Token(Token = "0x20000B4")]
	public class FocusLostDisabler : MonoBehaviour
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _hasFocus;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] ToDisable;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Canvas[] CanvasToDisable;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer[] RendererToDisable;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MonoBehaviour[] ComponentsToDisable;

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xA1E808", Offset = "0xA1E808", VA = "0xA1E808")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xA1E814", Offset = "0xA1E814", VA = "0xA1E814")]
		private void ProcessObjects()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xA1E980", Offset = "0xA1E980", VA = "0xA1E980")]
		public FocusLostDisabler()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class HapticParameters
	{
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float Duration;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float GrabArrowDuration;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float TouchNockPullerAmplitude;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float TouchQuiverAmplitude;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static float StopTouchingQuiverAmplitude;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float GrabArrowAmplitude;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static float StartDrawingBowHandAmplitude;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static float StartDrawingOffHandAmplitude;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static float ReleaseBowHandAmplitude;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static float ReleaseOffHandAmplitude;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xA1E988", Offset = "0xA1E988", VA = "0xA1E988")]
		public HapticParameters()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class PICODeviceChecker
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _deviceType;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int _predefinedType0;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int _predefinedType1;

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xA1E9F4", Offset = "0xA1E9F4", VA = "0xA1E9F4")]
		public static int GetDeviceType()
		{
			return default(int);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xA1EA7C", Offset = "0xA1EA7C", VA = "0xA1EA7C")]
		private static void InitDeviceType()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xA1EB24", Offset = "0xA1EB24", VA = "0xA1EB24")]
		public PICODeviceChecker()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI
{
	[Token(Token = "0x20000B7")]
	public class Temp : MonoBehaviour
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MusicPlayer MP;

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xA1EB84", Offset = "0xA1EB84", VA = "0xA1EB84")]
		private void Awake()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xA1EBA4", Offset = "0xA1EBA4", VA = "0xA1EBA4")]
		[ContextMenu("Pause")]
		public void Pause()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xA1EBB0", Offset = "0xA1EBB0", VA = "0xA1EBB0")]
		[ContextMenu("Resume")]
		public void Resume()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xA1EBBC", Offset = "0xA1EBBC", VA = "0xA1EBBC")]
		[ContextMenu("To Game")]
		public void ChangeToGameTrack()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xA1EBDC", Offset = "0xA1EBDC", VA = "0xA1EBDC")]
		[ContextMenu("To Menu")]
		public void ChangeToMenuTrack()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xA1EBFC", Offset = "0xA1EBFC", VA = "0xA1EBFC")]
		public Temp()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class UIManager : MonoBehaviour
	{
		[Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private sealed class <DisableCanvasScaler>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIManager <>4__this;

			[Token(Token = "0x17000097")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600059B")]
				[Address(RVA = "0xA1F0B0", Offset = "0xA1F0B0", VA = "0xA1F0B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600059D")]
				[Address(RVA = "0xA1F0F8", Offset = "0xA1F0F8", VA = "0xA1F0F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0xA1EEC0", Offset = "0xA1EEC0", VA = "0xA1EEC0")]
			[DebuggerHidden]
			public <DisableCanvasScaler>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xA1F014", Offset = "0xA1F014", VA = "0xA1F014", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0xA1F018", Offset = "0xA1F018", VA = "0xA1F018", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0xA1F0B8", Offset = "0xA1F0B8", VA = "0xA1F0B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool IsInitialized;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int OverrideStartingScreen;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIScreen[] Screens;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int InitializationScreen;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int StartingScreen;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasScaler _canvasScaler;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Canvas _canvas;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _curScreenId;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UIScreen _curScreen;

		[Token(Token = "0x17000096")]
		public int LastScreenId
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xA1EC04", Offset = "0xA1EC04", VA = "0xA1EC04")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xA1EC0C", Offset = "0xA1EC0C", VA = "0xA1EC0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xA1EC14", Offset = "0xA1EC14", VA = "0xA1EC14")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xA1EC90", Offset = "0xA1EC90", VA = "0xA1EC90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xA1EE58", Offset = "0xA1EE58", VA = "0xA1EE58")]
		[IteratorStateMachine(typeof(<DisableCanvasScaler>d__15))]
		private IEnumerator DisableCanvasScaler()
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xA1EEE8", Offset = "0xA1EEE8", VA = "0xA1EEE8")]
		public void SwitchToScreen(int id)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xA1EFB4", Offset = "0xA1EFB4", VA = "0xA1EFB4")]
		public UIManager()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class ArmLengthCalibrationWindow : ModalWindow
	{
		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArmLengthCalibration ArmLengthCalibration;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI Value;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RectTransform ActualHuman;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject TriggerPulledL;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject TriggerPulledR;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject CalibrationComplete;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CanvasGroup ContinueButton;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _calibration;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action _onCalibrationCompleteCallback;

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xA1F100", Offset = "0xA1F100", VA = "0xA1F100")]
		public void Init([Optional] Action onCalibrationComplete)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xA1F454", Offset = "0xA1F454", VA = "0xA1F454", Slot = "11")]
		protected override void BeforeHide()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xA1F5FC", Offset = "0xA1F5FC", VA = "0xA1F5FC")]
		private void OnTriggerPulled(bool left, bool right)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xA1F640", Offset = "0xA1F640", VA = "0xA1F640")]
		private void OnCalibrationComplete(float value, float value2)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xA1F31C", Offset = "0xA1F31C", VA = "0xA1F31C")]
		private void RefreshCalibrationValues(float value, float value2)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xA1F65C", Offset = "0xA1F65C", VA = "0xA1F65C")]
		public void MarkCalibrationComplete()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xA1F6A8", Offset = "0xA1F6A8", VA = "0xA1F6A8")]
		public void OnCancel()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xA1F6B4", Offset = "0xA1F6B4", VA = "0xA1F6B4")]
		public void OnContinue()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xA1F708", Offset = "0xA1F708", VA = "0xA1F708")]
		public ArmLengthCalibrationWindow()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI._Presets
{
	[Token(Token = "0x20000BB")]
	[CreateAssetMenu(fileName = "ColorPresets", menuName = "ScriptableObjects/Presets/Color Presets", order = 0)]
	public class ColorPresets : ScriptableObject
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color Regular;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color Regular075;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color Regular05;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color Regular035;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color Regular025;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color Regular0125;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color Regular00625;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color RedFull;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color Red;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color Red075;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Color Red07;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Color Red05;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color Red025;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Color YellowFull;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Color Yellow;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Color Yellow075;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Color Yellow05;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public Color Yellow031;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Color Yellow025;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Color Yellow012;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Color BrightGreen;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public Color GreenFull;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public Color Green;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public Color Green075;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public Color Green05;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public Color Green025;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public Color Paper;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public Color DarkPaper;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public Color DarkerPaper;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public Color DarkestPaper;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public Color White;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public Color White075;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public Color White05;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public Color White025;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public Color White016;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public Color White015;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public Color White0125;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public Color White010;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public Color White00625;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public Color White005;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public Color Black;

		[Token(Token = "0x17000099")]
		public static ColorPresets Instance
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xA1F710", Offset = "0xA1F710", VA = "0xA1F710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xA1F758", Offset = "0xA1F758", VA = "0xA1F758")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xA1F7A4", Offset = "0xA1F7A4", VA = "0xA1F7A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xA1F7F0", Offset = "0xA1F7F0", VA = "0xA1F7F0")]
		public ColorPresets()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[CreateAssetMenu(fileName = "StringPresets", menuName = "ScriptableObjects/Presets/String Presets", order = 0)]
	public class StringPresets : ScriptableObject
	{
		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Currencies")]
		public string StarIcon;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string TargetIcon;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string BullseyeIcon;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string PrimaryCurrencyIcon;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string PremiumAimAssistIcon;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string PremiumSlowmoIcon;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Currencies Tinted")]
		public string StarIconTinted;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string TargetIconTinted;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string BullseyeIconTinted;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string PrimaryCurrencyIconTinted;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string AimAssistIconTinted;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string SlowmoIconTinted;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Header("Currencies 2x")]
		public string StarIcon2x;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string TargetIcon2x;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string BullseyeIcon2x;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string PrimaryCurrencyIcon2x;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string PremiumAimAssistIcon2x;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string PremiumSlowmoIcon2x;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Header("Equipment Stats")]
		public string AccuracyIcon;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string ArrowSpeedIcon;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string DrawSpeedIcon;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public string StaminaIcon;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string ReloadSpeedIcon;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Header("Equipment Stats Tinted")]
		public string AccuracyIconTinted;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string ArrowSpeedIconTinted;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public string DrawSpeedIconTinted;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string StaminaIconTinted;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public string ReloadSpeedIconTinted;

		[Token(Token = "0x1700009A")]
		public static StringPresets Instance
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xA1F7F8", Offset = "0xA1F7F8", VA = "0xA1F7F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xA1F840", Offset = "0xA1F840", VA = "0xA1F840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xA1F88C", Offset = "0xA1F88C", VA = "0xA1F88C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xA1F8D8", Offset = "0xA1F8D8", VA = "0xA1F8D8")]
		public static string GetCurrencyIconById(int id, bool tinted = false)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xA1FACC", Offset = "0xA1FACC", VA = "0xA1FACC")]
		public static string GetEquipmentStatIconById(int id)
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xA1FC40", Offset = "0xA1FC40", VA = "0xA1FC40")]
		public StringPresets()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI._Global
{
	[Token(Token = "0x20000BD")]
	public class LongPressButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
	{
		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _timePressed;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _isDown;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool _isLongPress;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent OnClick;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent OnLongPress;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float LongPressTime;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ImageStatBarFill LongPressFill;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CanvasGroup _longPressFillImage;

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xA20034", Offset = "0xA20034", VA = "0xA20034")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xA20098", Offset = "0xA20098", VA = "0xA20098")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xA201AC", Offset = "0xA201AC", VA = "0xA201AC", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xA201F4", Offset = "0xA201F4", VA = "0xA201F4", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xA20264", Offset = "0xA20264", VA = "0xA20264", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xA20280", Offset = "0xA20280", VA = "0xA20280")]
		public LongPressButton()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class MenuBackgroundManager : MonoBehaviour
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MaximizingBackground MaximizingBackground;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Texture _expandTexture;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Texture _expandTextureBlur;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _expandTextureId;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xA20298", Offset = "0xA20298", VA = "0xA20298")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xA202C4", Offset = "0xA202C4", VA = "0xA202C4")]
		public void Expand(Texture tex, Texture texBlur, int textureId, Transform t)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xA2032C", Offset = "0xA2032C", VA = "0xA2032C")]
		public void ExpandInstant(Texture tex, Texture texBlur, int textureId, Transform t)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xA20390", Offset = "0xA20390", VA = "0xA20390")]
		public void Contract()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xA2041C", Offset = "0xA2041C", VA = "0xA2041C")]
		private void OnContractComplete()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xA20448", Offset = "0xA20448", VA = "0xA20448")]
		public MenuBackgroundManager()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI._Global.StatBar
{
	[Token(Token = "0x20000BF")]
	public class ImageStatBarColor : MonoBehaviour
	{
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image[] Images;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color ActiveColor;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color InactiveColor;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int Value;

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xA20450", Offset = "0xA20450", VA = "0xA20450")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xA20530", Offset = "0xA20530", VA = "0xA20530")]
		public void SetValue(int value)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xA20454", Offset = "0xA20454", VA = "0xA20454")]
		[ContextMenu("Refresh")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xA20538", Offset = "0xA20538", VA = "0xA20538")]
		public ImageStatBarColor()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class ImageStatBarFill : MonoBehaviour
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform Fill;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float Value;

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xA20550", Offset = "0xA20550", VA = "0xA20550")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xA201A4", Offset = "0xA201A4", VA = "0xA201A4")]
		public void SetValue(float value)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xA20554", Offset = "0xA20554", VA = "0xA20554")]
		[ContextMenu("Refresh")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xA2057C", Offset = "0xA2057C", VA = "0xA2057C")]
		public ImageStatBarFill()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class ImageStatBarSprites : MonoBehaviour
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image[] Images;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite InactiveSprite;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sprite ActiveSprite;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int Value;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xA20584", Offset = "0xA20584", VA = "0xA20584")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xA20614", Offset = "0xA20614", VA = "0xA20614")]
		public void SetValue(int value)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xA20588", Offset = "0xA20588", VA = "0xA20588")]
		[ContextMenu("Refresh")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xA2061C", Offset = "0xA2061C", VA = "0xA2061C")]
		public ImageStatBarSprites()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI._Global.DynamicResizablePanels
{
	[Token(Token = "0x20000C2")]
	public class DynamicResizablePanel : MonoBehaviour
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Button _button;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LayoutElement _layoutElement;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 _expandedSize;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected float _transitionTime;

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xA20624", Offset = "0xA20624", VA = "0xA20624", Slot = "4")]
		public virtual void Init(float expandedSize)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xA20634", Offset = "0xA20634", VA = "0xA20634", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xA206C8", Offset = "0xA206C8", VA = "0xA206C8", Slot = "6")]
		public virtual void Expand(bool instant = false)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xA207F8", Offset = "0xA207F8", VA = "0xA207F8", Slot = "7")]
		protected virtual void OnExpandComplete()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xA207FC", Offset = "0xA207FC", VA = "0xA207FC", Slot = "8")]
		public virtual void Contract(bool instant = false)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xA20950", Offset = "0xA20950", VA = "0xA20950", Slot = "9")]
		protected virtual void OnContractComplete()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xA20970", Offset = "0xA20970", VA = "0xA20970", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xA20980", Offset = "0xA20980", VA = "0xA20980")]
		public DynamicResizablePanel()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class DynamicResizablePanelContent : MonoBehaviour
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xA20994", Offset = "0xA20994", VA = "0xA20994", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xA209E4", Offset = "0xA209E4", VA = "0xA209E4")]
		public void Show(bool instant = false)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xA20B70", Offset = "0xA20B70", VA = "0xA20B70")]
		public void Hide(bool instant = false)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xA20CD4", Offset = "0xA20CD4", VA = "0xA20CD4")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xA20D0C", Offset = "0xA20D0C", VA = "0xA20D0C", Slot = "5")]
		protected virtual void BeforeShow()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xA20D10", Offset = "0xA20D10", VA = "0xA20D10", Slot = "6")]
		protected virtual void AfterShow()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xA20D14", Offset = "0xA20D14", VA = "0xA20D14", Slot = "7")]
		protected virtual void BeforeHide()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xA20D18", Offset = "0xA20D18", VA = "0xA20D18", Slot = "8")]
		protected virtual void AfterHide()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xA20D1C", Offset = "0xA20D1C", VA = "0xA20D1C", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xA20D2C", Offset = "0xA20D2C", VA = "0xA20D2C")]
		public DynamicResizablePanelContent()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class DynamicResizablePanelManager : MonoBehaviour
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float ExpandedSize;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DynamicResizablePanel[] _panelList;

		[Token(Token = "0x1700009B")]
		public int CurPanelId
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xA20D34", Offset = "0xA20D34", VA = "0xA20D34")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xA20D3C", Offset = "0xA20D3C", VA = "0xA20D3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public DynamicResizablePanel CurPanel
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xA20D44", Offset = "0xA20D44", VA = "0xA20D44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xA20D4C", Offset = "0xA20D4C", VA = "0xA20D4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xA20D54", Offset = "0xA20D54", VA = "0xA20D54")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xA20EBC", Offset = "0xA20EBC", VA = "0xA20EBC")]
		public void Select(int id, bool instant = false)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xA20FA4", Offset = "0xA20FA4", VA = "0xA20FA4")]
		public void Deselect(bool instant = false)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xA21030", Offset = "0xA21030", VA = "0xA21030")]
		public void SelectNext()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xA210DC", Offset = "0xA210DC", VA = "0xA210DC")]
		public void SelectPrevious()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xA2118C", Offset = "0xA2118C", VA = "0xA2118C")]
		public DynamicResizablePanelManager()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class DynamicResizablePanelWithIcon : DynamicResizablePanel
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CanvasGroup Icon;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xA211A4", Offset = "0xA211A4", VA = "0xA211A4", Slot = "6")]
		public override void Expand(bool instant = false)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xA21230", Offset = "0xA21230", VA = "0xA21230", Slot = "7")]
		protected override void OnExpandComplete()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xA2125C", Offset = "0xA2125C", VA = "0xA2125C", Slot = "8")]
		public override void Contract(bool instant = false)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xA2130C", Offset = "0xA2130C", VA = "0xA2130C", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xA21338", Offset = "0xA21338", VA = "0xA21338")]
		public DynamicResizablePanelWithIcon()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.StatsBar
{
	[Token(Token = "0x20000C6")]
	public class StatsBar : MonoBehaviour
	{
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Stars;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI PrimaryCurrency;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform _primaryCurrencyTransform;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _highlightEffectScale;

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xA2134C", Offset = "0xA2134C", VA = "0xA2134C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xA2145C", Offset = "0xA2145C", VA = "0xA2145C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xA21474", Offset = "0xA21474", VA = "0xA21474")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xA2148C", Offset = "0xA2148C", VA = "0xA2148C")]
		private void RefreshStars()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xA215F0", Offset = "0xA215F0", VA = "0xA215F0")]
		private void RefreshPrimaryCurrency()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xA21754", Offset = "0xA21754", VA = "0xA21754")]
		private void OnStarsChangedEvent(int value)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xA21758", Offset = "0xA21758", VA = "0xA21758")]
		private void OnPrimaryCurrencyChangedEvent(int value)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xA2175C", Offset = "0xA2175C", VA = "0xA2175C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xA2183C", Offset = "0xA2183C", VA = "0xA2183C")]
		public StatsBar()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class StatsUpdateEffectItem : MonoBehaviour
	{
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite[] Sprites;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _statType;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image _image;

		[Token(Token = "0x1700009D")]
		public int StatType
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xA21850", Offset = "0xA21850", VA = "0xA21850")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xA21858", Offset = "0xA21858", VA = "0xA21858")]
		public void Init(int statType, Vector3 fromPos, Vector3 toPos, Action<StatsUpdateEffectItem> onComplete)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xA21C24", Offset = "0xA21C24", VA = "0xA21C24")]
		public StatsUpdateEffectItem()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class StatsUpdateEffectSystem : MonoBehaviour
	{
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Items;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform[] FromPos;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform[] ToPos;

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xA21C4C", Offset = "0xA21C4C", VA = "0xA21C4C")]
		private void OnPurchasedEvent(int statType, int tier)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xA21E2C", Offset = "0xA21E2C", VA = "0xA21E2C")]
		private void OnItemComplete(StatsUpdateEffectItem item)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xA21F7C", Offset = "0xA21F7C", VA = "0xA21F7C")]
		public StatsUpdateEffectSystem()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Settings
{
	[Token(Token = "0x20000CA")]
	public class AdvancedSettingsPanel : DynamicResizablePanelContent
	{
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image CrosshairIcon;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanvasGroup AdditionalArrowsGroup;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Slider AdditionalArrows;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI AdditionalArrowsLabel;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image ArrowSideIcon;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Slider InitialTrajectory;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Slider InitialTrajectorySecondary;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI InitialTrajectoryLabel;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PlayerSettingsState _playerSettings;

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xA21F84", Offset = "0xA21F84", VA = "0xA21F84", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xA21FB0", Offset = "0xA21FB0", VA = "0xA21FB0", Slot = "5")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xA22214", Offset = "0xA22214", VA = "0xA22214")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xA21FB4", Offset = "0xA21FB4", VA = "0xA21FB4")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xA22234", Offset = "0xA22234", VA = "0xA22234")]
		public void OnCrosshair()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xA22358", Offset = "0xA22358", VA = "0xA22358")]
		public void OnAdditionalArrowsChanged(float value)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xA22488", Offset = "0xA22488", VA = "0xA22488")]
		public void OnArrowSide()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xA22578", Offset = "0xA22578", VA = "0xA22578")]
		public void OnInitialTrajectoryChanged(float value)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xA22648", Offset = "0xA22648", VA = "0xA22648")]
		public void OnInitialTrajectoryChangedSecondary(float value)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xA22718", Offset = "0xA22718", VA = "0xA22718")]
		public void OnResetToDefaults()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xA22794", Offset = "0xA22794", VA = "0xA22794")]
		public AdvancedSettingsPanel()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class DocsSettingsPanel : DynamicResizablePanelContent
	{
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PrivacyWindow _privacyWindow;

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xA2279C", Offset = "0xA2279C", VA = "0xA2279C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xA22800", Offset = "0xA22800", VA = "0xA22800")]
		public void OnPrivacyPolicyBtn()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xA22874", Offset = "0xA22874", VA = "0xA22874")]
		public DocsSettingsPanel()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class MainSettingsPanel : DynamicResizablePanelContent
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Slider MasterVolume;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI MasterVolumeLabel;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Slider MusicVolume;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI MusicVolumeLabel;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI ArmLenghtCalibrationLabel;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Slider Smoothing;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI SmoothingLabel;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Image SnapPointIcon;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PlayerSettingsState _playerSettings;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ArmLengthCalibrationWindow _armLengthCalibrationWindow;

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xA2287C", Offset = "0xA2287C", VA = "0xA2287C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xA228F4", Offset = "0xA228F4", VA = "0xA228F4", Slot = "5")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xA228F8", Offset = "0xA228F8", VA = "0xA228F8")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xA22DD4", Offset = "0xA22DD4", VA = "0xA22DD4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xA22DF4", Offset = "0xA22DF4", VA = "0xA22DF4")]
		public void OnMasterVolumeChanged(float value)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xA22F7C", Offset = "0xA22F7C", VA = "0xA22F7C")]
		public void OnMusicVolumeChanged(float value)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xA23104", Offset = "0xA23104", VA = "0xA23104")]
		public void OnArmLengthCalibration()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xA231C0", Offset = "0xA231C0", VA = "0xA231C0")]
		private void OnArmLengthCalibrationComplete()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xA2324C", Offset = "0xA2324C", VA = "0xA2324C")]
		public void OnSmoothingChanged(float value)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xA233D4", Offset = "0xA233D4", VA = "0xA233D4")]
		public void OnSnapPoint()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xA234C4", Offset = "0xA234C4", VA = "0xA234C4")]
		public void OnSnapPointCustomize()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xA23558", Offset = "0xA23558", VA = "0xA23558")]
		public void OnResetToDefaults()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xA235D4", Offset = "0xA235D4", VA = "0xA235D4")]
		public MainSettingsPanel()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Menu.NavBar
{
	[Token(Token = "0x20000CD")]
	public class AlertWidget : MonoBehaviour
	{
		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x1700009E")]
		public bool IsVisible
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0xA235DC", Offset = "0xA235DC", VA = "0xA235DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xA2368C", Offset = "0xA2368C", VA = "0xA2368C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xA236DC", Offset = "0xA236DC", VA = "0xA236DC")]
		public void Show(bool instant)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xA237BC", Offset = "0xA237BC", VA = "0xA237BC")]
		public void Hide(bool instant)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xA2389C", Offset = "0xA2389C", VA = "0xA2389C")]
		public AlertWidget()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class NavigationButton : DynamicResizablePanel, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Image Icon;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color InactiveColor;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color ActiveColor;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _timePressed;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _isDown;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool _isLongPress;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityEvent OnClick;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent OnLongPress;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float LongPressTime;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public ImageStatBarFill LongPressFill;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CanvasGroup _longPressFillImage;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xA238A4", Offset = "0xA238A4", VA = "0xA238A4", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xA23920", Offset = "0xA23920", VA = "0xA23920")]
		private void Update()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xA239EC", Offset = "0xA239EC", VA = "0xA239EC", Slot = "6")]
		public override void Expand(bool instant = false)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xA23A48", Offset = "0xA23A48", VA = "0xA23A48", Slot = "8")]
		public override void Contract(bool instant = false)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xA23AA4", Offset = "0xA23AA4", VA = "0xA23AA4", Slot = "11")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xA23AEC", Offset = "0xA23AEC", VA = "0xA23AEC", Slot = "12")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xA23B20", Offset = "0xA23B20", VA = "0xA23B20", Slot = "13")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xA23B3C", Offset = "0xA23B3C", VA = "0xA23B3C")]
		public NavigationButton()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Loading
{
	[Token(Token = "0x20000CF")]
	public class InitLoadingScreen : MonoBehaviour
	{
		[Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private sealed class <SwitchScene>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InitLoadingScreen <>4__this;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AsyncOperation <asyncOperation>5__2;

			[Token(Token = "0x1700009F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600062D")]
				[Address(RVA = "0xA24FA4", Offset = "0xA24FA4", VA = "0xA24FA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600062F")]
				[Address(RVA = "0xA24FEC", Offset = "0xA24FEC", VA = "0xA24FEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0xA24D18", Offset = "0xA24D18", VA = "0xA24D18")]
			[DebuggerHidden]
			public <SwitchScene>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0xA24D54", Offset = "0xA24D54", VA = "0xA24D54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0xA24D58", Offset = "0xA24D58", VA = "0xA24D58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0xA24FAC", Offset = "0xA24FAC", VA = "0xA24FAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Canvas ContentCanvas;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MinTime;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string SceneToSwitchTo;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _startLoadingTime;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _mainCameraTransform;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _container;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xA24B60", Offset = "0xA24B60", VA = "0xA24B60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xA24B90", Offset = "0xA24B90", VA = "0xA24B90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xA24C34", Offset = "0xA24C34", VA = "0xA24C34")]
		public void InitialSceneSwitch()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xA24CE4", Offset = "0xA24CE4", VA = "0xA24CE4")]
		private void InitPosition()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xA24C7C", Offset = "0xA24C7C", VA = "0xA24C7C")]
		[IteratorStateMachine(typeof(<SwitchScene>d__10))]
		private IEnumerator SwitchScene()
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xA24D40", Offset = "0xA24D40", VA = "0xA24D40")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xA24D44", Offset = "0xA24D44", VA = "0xA24D44")]
		public InitLoadingScreen()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class LoadingScreen : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class <SwitchScene>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoadingScreen <>4__this;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <len>5__2;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <lastSceneId>5__3;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Scene <sceneToMakeActive>5__4;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <i>5__5;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AsyncOperation <asyncOperation>5__6;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private bool <isLastScene>5__7;

			[Token(Token = "0x170000A1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0xA25BE0", Offset = "0xA25BE0", VA = "0xA25BE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0xA25C28", Offset = "0xA25C28", VA = "0xA25C28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0xA25734", Offset = "0xA25734", VA = "0xA25734")]
			[DebuggerHidden]
			public <SwitchScene>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0xA25924", Offset = "0xA25924", VA = "0xA25924", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0xA25928", Offset = "0xA25928", VA = "0xA25928", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0xA25BE8", Offset = "0xA25BE8", VA = "0xA25BE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LoadingScreen Instance;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Canvas ContentCanvas;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LoadingScreenAnimation loadingAnimation;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string[] _scenesToSwitchTo;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _startLoadingTime;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _minLoadingTime;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _stateSerializationRequired;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _mainCameraTransform;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _container;

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xA24FF4", Offset = "0xA24FF4", VA = "0xA24FF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xA250EC", Offset = "0xA250EC", VA = "0xA250EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xA25188", Offset = "0xA25188", VA = "0xA25188")]
		private void InitPosition()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xA251BC", Offset = "0xA251BC", VA = "0xA251BC")]
		public void SwitchToScene(string sceneName, int stateSerializationRequired = 0)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xA25264", Offset = "0xA25264", VA = "0xA25264")]
		public void SwitchToScenes(string[] sceneNames, int stateSerializationRequired = 0)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xA25414", Offset = "0xA25414", VA = "0xA25414")]
		public void ReloadActiveScenes(int stateSerializationRequired = 0)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xA2564C", Offset = "0xA2564C", VA = "0xA2564C")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xA256CC", Offset = "0xA256CC", VA = "0xA256CC")]
		[IteratorStateMachine(typeof(<SwitchScene>d__16))]
		private IEnumerator SwitchScene()
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xA25514", Offset = "0xA25514", VA = "0xA25514")]
		private void GetCurrentScenes()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xA2575C", Offset = "0xA2575C", VA = "0xA2575C")]
		private void Hide()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xA258F0", Offset = "0xA258F0", VA = "0xA258F0")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xA2591C", Offset = "0xA2591C", VA = "0xA2591C")]
		public LoadingScreen()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class LoadingScreenAnimation : MonoBehaviour
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasGroup Content;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Renderer Renderer;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material _material;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color None;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color Black;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Action _onShowComplete;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Action _onHideComplete;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _showTime;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _hideTime;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int MainColor;

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xA25C30", Offset = "0xA25C30", VA = "0xA25C30", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xA25CB0", Offset = "0xA25CB0", VA = "0xA25CB0")]
		[ContextMenu("Show")]
		public void Show()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xA2535C", Offset = "0xA2535C", VA = "0xA2535C")]
		public void Show(Action onShowComplete)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xA25CB8", Offset = "0xA25CB8", VA = "0xA25CB8")]
		private void DelayedShow()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xA25DF8", Offset = "0xA25DF8", VA = "0xA25DF8")]
		private void OnShowContent()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xA25EF4", Offset = "0xA25EF4", VA = "0xA25EF4")]
		private void OnFullyShown()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xA25F10", Offset = "0xA25F10", VA = "0xA25F10")]
		[ContextMenu("Hide")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xA257E4", Offset = "0xA257E4", VA = "0xA257E4")]
		public void Hide(Action onHideComplete)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xA25F18", Offset = "0xA25F18", VA = "0xA25F18")]
		private void OnContentHidden()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xA260AC", Offset = "0xA260AC", VA = "0xA260AC")]
		private void OnHidden()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xA260F0", Offset = "0xA260F0", VA = "0xA260F0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xA26100", Offset = "0xA26100", VA = "0xA26100")]
		public LoadingScreenAnimation()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Equipment
{
	[Token(Token = "0x20000D4")]
	public class EquipmentListItem : MonoBehaviour
	{
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Button Button;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image Portrait;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanvasGroup PortraitContainer;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI OwnedLabel;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI PricePrimaryCurrency;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CanvasGroup LockIcon;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CanvasGroup EquippedIcon;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject ComingSoonLabel;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AlertWidget UnlockedAlert;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AlertWidget UnlockedAlert2;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _portraitRT;

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xA261A4", Offset = "0xA261A4", VA = "0xA261A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xA261FC", Offset = "0xA261FC", VA = "0xA261FC")]
		public void Refresh(EquipmentUIData uiData, EquipmentBalanceData balanceData, bool isOwned, bool isEquipped, bool isLocked, bool isComingSoon, bool noPrimaryCurrency, Color primaryCurrencyColor, bool showAlert)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xA264B4", Offset = "0xA264B4", VA = "0xA264B4")]
		public void Select(bool value)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xA264D8", Offset = "0xA264D8", VA = "0xA264D8")]
		public EquipmentListItem()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class EquipmentPanelContent : DynamicResizablePanelContent
	{
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EquipmentDataLibrary EquipmentDataLibrary;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EquipmentUIDataLibrary EquipmentUIDataLibrary;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int PanelType;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EquipmentUIRenderer CurPortrait;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Localize NameLabel;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI[] CurStats;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject[] CurStatsButtons;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ScrollRect EquipmentListScrollRect;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EquipmentListItem[] EquipmentList;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Button BuyPrimaryCurrencyBtn;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Button EquipBtn;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public LocalizationParamsManager BuyPrimaryCurrencyLabelValue;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI BuyPrimaryCurrencyLabel;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject EquippedLabel;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LocalizationParamsManager LockedLabelValue;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject LockedLabel;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject ComingSoonLabel;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _curSelectionId;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private PlayerState _playerState;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BalanceData _balanceData;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _unlockableAlertId;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _viewedAlertId;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string _green;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private string _red;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string _grey;

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xA264E0", Offset = "0xA264E0", VA = "0xA264E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xA266B4", Offset = "0xA266B4", VA = "0xA266B4", Slot = "5")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xA26718", Offset = "0xA26718", VA = "0xA26718")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xA26750", Offset = "0xA26750", VA = "0xA26750")]
		private void RefreshBow()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xA2723C", Offset = "0xA2723C", VA = "0xA2723C")]
		private void RefreshArrow()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xA27F60", Offset = "0xA27F60", VA = "0xA27F60")]
		private void RefreshBuyButtons(bool isPurchased, bool isEquipped, EquipmentBalanceData data)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xA27CA0", Offset = "0xA27CA0", VA = "0xA27CA0")]
		private void RefreshEquipmentList()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xA2827C", Offset = "0xA2827C", VA = "0xA2827C")]
		public void OnStatInfoBtn(int id)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xA28E64", Offset = "0xA28E64", VA = "0xA28E64")]
		public void OnSelect(int id)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xA28F80", Offset = "0xA28F80", VA = "0xA28F80")]
		public void OnBuyPrimaryBtn()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xA29288", Offset = "0xA29288", VA = "0xA29288")]
		public void OnEquipBtn()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xA29384", Offset = "0xA29384", VA = "0xA29384")]
		public EquipmentPanelContent()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	internal class DynamicResizablePanelWithContent : DynamicResizablePanelWithIcon
	{
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DynamicResizablePanelContent Content;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xA2939C", Offset = "0xA2939C", VA = "0xA2939C", Slot = "6")]
		public override void Expand(bool instant = false)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xA293CC", Offset = "0xA293CC", VA = "0xA293CC", Slot = "8")]
		public override void Contract(bool instant = false)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xA293FC", Offset = "0xA293FC", VA = "0xA293FC", Slot = "9")]
		protected override void OnContractComplete()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xA29434", Offset = "0xA29434", VA = "0xA29434")]
		public DynamicResizablePanelWithContent()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Areas
{
	[Token(Token = "0x20000D7")]
	public class AreaUI : MonoBehaviour
	{
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParallaxPortrait ParallaxPortrait;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanvasGroup PortraitContainer;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RawImage Portrait;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Button MainButton;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CanvasGroup Background;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CanvasGroup Highlight;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Graphic Highlight2;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public CanvasGroup BackBtns;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Localize StarsLabelLocalize;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LocalizationParamsManager StarsLabelValue;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LocalizationParamsManager NameLabelLocalize;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AreaUILockAnim LockIcon;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool _isLocked;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		private bool _isUnlockable;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		private bool _anotherAreaReadyToUnlock;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform _transform;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransform;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private LayoutElement _layoutElement;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2 _originalSize;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 _originalPos;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Action _onExpandCompleteCallback;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action _onContractCompleteCallback;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Action<AreaUI> _onUnlockCompleteCallback;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Color _normalColor;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Color _highlightedColor;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Color _pressedColor;

		[Token(Token = "0x170000A3")]
		public int Id
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0xA2943C", Offset = "0xA2943C", VA = "0xA2943C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xA29444", Offset = "0xA29444", VA = "0xA29444")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		private float PortraitAlpha
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xA2944C", Offset = "0xA2944C", VA = "0xA2944C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000667")]
			[Address(RVA = "0xA29454", Offset = "0xA29454", VA = "0xA29454")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool CanBeUnlocked
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0xA2945C", Offset = "0xA2945C", VA = "0xA2945C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		public bool IsLocked
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0xA2947C", Offset = "0xA2947C", VA = "0xA2947C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xA29484", Offset = "0xA29484", VA = "0xA29484")]
		private void Awake()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xA2956C", Offset = "0xA2956C", VA = "0xA2956C")]
		public void Refresh(AreaData ad, bool isLatest, bool isLocked, bool isUnlockable, bool anotherAreaReadyToUnlock)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xA29E50", Offset = "0xA29E50", VA = "0xA29E50")]
		public void ComingSoon(AreaData ad)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xA29F44", Offset = "0xA29F44", VA = "0xA29F44")]
		public void Expand(Action onComplete)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xA2A1F4", Offset = "0xA2A1F4", VA = "0xA2A1F4")]
		private void OnExpandComplete()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xA2A2B4", Offset = "0xA2A2B4", VA = "0xA2A2B4")]
		public void ExpandInstant()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xA2A43C", Offset = "0xA2A43C", VA = "0xA2A43C")]
		public void Contract(Action onComplete)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xA2A5C0", Offset = "0xA2A5C0", VA = "0xA2A5C0")]
		private void OnContractComplete()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xA2A628", Offset = "0xA2A628", VA = "0xA2A628")]
		public void Unlock(Action<AreaUI> onComplete)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xA2A948", Offset = "0xA2A948", VA = "0xA2A948")]
		private void OnUnlockComplete()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xA2A968", Offset = "0xA2A968", VA = "0xA2A968")]
		public void ShakeLocked()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xA2AA68", Offset = "0xA2AA68", VA = "0xA2AA68")]
		public void Show()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xA2AB44", Offset = "0xA2AB44", VA = "0xA2AB44")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xA2AB64", Offset = "0xA2AB64", VA = "0xA2AB64")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xA2ABD8", Offset = "0xA2ABD8", VA = "0xA2ABD8")]
		public void HideInstant()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xA2AC10", Offset = "0xA2AC10", VA = "0xA2AC10")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xA2AC3C", Offset = "0xA2AC3C", VA = "0xA2AC3C")]
		public AreaUI()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class AreaUIGroup : MonoBehaviour
	{
		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnAreaUnlocked;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AreaDataLibrary AreaDataLibrary;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform Container;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanvasGroup ScrollBar;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AreaUI[] _areaUiList;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ScrollRect _scrollRect;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HorizontalLayoutGroup _layoutGroup;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MenuBackgroundManager _menuBackgroundManager;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LevelUIGroup _levelUIGroup;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _curAreaId;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AreaUI _curAreaUI;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 _contractPosition;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _cantChangeState;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _savedScrollRectPos;

		[Token(Token = "0x170000A7")]
		public bool IsAreaSelected
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0xA2AC44", Offset = "0xA2AC44", VA = "0xA2AC44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xA2AC54", Offset = "0xA2AC54", VA = "0xA2AC54")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xA2AE30", Offset = "0xA2AE30", VA = "0xA2AE30")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xA2B040", Offset = "0xA2B040", VA = "0xA2B040")]
		public void RegularStart()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xA2B0EC", Offset = "0xA2B0EC", VA = "0xA2B0EC")]
		public void Select(int id)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xA2B704", Offset = "0xA2B704", VA = "0xA2B704")]
		[ContextMenu("SET POS")]
		private void SetScrollPos()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xA2B728", Offset = "0xA2B728", VA = "0xA2B728")]
		public void SelectInstant(int id)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xA2BBA4", Offset = "0xA2BBA4", VA = "0xA2BBA4")]
		private void OnSelectPhaseComplete()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xA2BDB8", Offset = "0xA2BDB8", VA = "0xA2BDB8")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xA2BDC0", Offset = "0xA2BDC0", VA = "0xA2BDC0")]
		private void OnDeselectPhaseComplete()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xA2BF10", Offset = "0xA2BF10", VA = "0xA2BF10")]
		private void OnDeselectComplete()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xA2B674", Offset = "0xA2B674", VA = "0xA2B674")]
		public void UnlockArea(AreaUI areaUI)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xA2BF5C", Offset = "0xA2BF5C", VA = "0xA2BF5C")]
		public void UnlockArea(int id)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xA2C004", Offset = "0xA2C004", VA = "0xA2C004")]
		private void OnUnlockComplete(AreaUI areaUI)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xA2B54C", Offset = "0xA2B54C", VA = "0xA2B54C")]
		public void Deselect()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xA2C1D4", Offset = "0xA2C1D4", VA = "0xA2C1D4")]
		public void FocusOnArea(int id, bool instant = false)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xA2C2B8", Offset = "0xA2C2B8", VA = "0xA2C2B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xA2C2E4", Offset = "0xA2C2E4", VA = "0xA2C2E4")]
		public AreaUIGroup()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class AreaUILockAnim : MonoBehaviour
	{
		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasGroup PortraitContainer;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanvasGroup LockContainer;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform LockIcon;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CanvasGroup TapToUnlockContainer;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Sequence _idleSequence;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Sequence _unlockSequence;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action _onUnlockComplete;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Sequence _lockedSequence;

		[Token(Token = "0x170000A8")]
		public float PortraitAlpha
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0xA2C2F4", Offset = "0xA2C2F4", VA = "0xA2C2F4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xA29AAC", Offset = "0xA29AAC", VA = "0xA29AAC")]
		public void Refresh(int type, bool instant)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xA2C2FC", Offset = "0xA2C2FC", VA = "0xA2C2FC")]
		private void StartIdleAnimation()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xA2A6C0", Offset = "0xA2A6C0", VA = "0xA2A6C0")]
		public void StartUnlockAnimation(Action onComplete)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xA2A980", Offset = "0xA2A980", VA = "0xA2A980")]
		public void StartLockedAnimation()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xA2C4E0", Offset = "0xA2C4E0", VA = "0xA2C4E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xA2C52C", Offset = "0xA2C52C", VA = "0xA2C52C")]
		public AreaUILockAnim()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class CampaignPanelContent : DynamicResizablePanelContent
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AreaUIGroup AreaUIGroup;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NewAreaAlert NewAreaAlert;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _firstView;

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xA2C5DC", Offset = "0xA2C5DC", VA = "0xA2C5DC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xA2C6D8", Offset = "0xA2C6D8", VA = "0xA2C6D8", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xA2C7D4", Offset = "0xA2C7D4", VA = "0xA2C7D4", Slot = "5")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xA2C880", Offset = "0xA2C880", VA = "0xA2C880")]
		private void OnAreaUnlockedEvent()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xA2C8A0", Offset = "0xA2C8A0", VA = "0xA2C8A0")]
		public bool CanBeDeselected()
		{
			return default(bool);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xA2C8C4", Offset = "0xA2C8C4", VA = "0xA2C8C4")]
		public void Deselect()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xA2C8DC", Offset = "0xA2C8DC", VA = "0xA2C8DC")]
		public CampaignPanelContent()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class FullscreenBackground : MonoBehaviour
	{
		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int TextureId;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 ReferenceTextureSize;

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xA2C8EC", Offset = "0xA2C8EC", VA = "0xA2C8EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xA2C8F0", Offset = "0xA2C8F0", VA = "0xA2C8F0")]
		[ContextMenu("Refresh")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xA2CAE0", Offset = "0xA2CAE0", VA = "0xA2CAE0")]
		public FullscreenBackground()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class LevelUI : MonoBehaviour
	{
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasGroup PortraitContainer;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Name;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ImageStatBarSprites Stars;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CanvasGroup LockIcon;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action _onShowCompleteCallback;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action _onHideCompleteCallback;

		[Token(Token = "0x170000A9")]
		public bool IsLocked
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xA2CAF4", Offset = "0xA2CAF4", VA = "0xA2CAF4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xA2CAFC", Offset = "0xA2CAFC", VA = "0xA2CAFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public int Id
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xA2CB08", Offset = "0xA2CB08", VA = "0xA2CB08")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xA2CB10", Offset = "0xA2CB10", VA = "0xA2CB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		private float PortraitAlpha
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xA2CB18", Offset = "0xA2CB18", VA = "0xA2CB18")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xA2CB30", Offset = "0xA2CB30", VA = "0xA2CB30")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xA2CB80", Offset = "0xA2CB80", VA = "0xA2CB80")]
		public void Refresh(int id, int stars, bool isLocked)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xA2CCD4", Offset = "0xA2CCD4", VA = "0xA2CCD4")]
		public void Show(float delay, [Optional] Action onComplete)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xA2CE9C", Offset = "0xA2CE9C", VA = "0xA2CE9C")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xA2CEB8", Offset = "0xA2CEB8", VA = "0xA2CEB8")]
		public void ShowInstant()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xA2CF3C", Offset = "0xA2CF3C", VA = "0xA2CF3C")]
		public void Hide(float delay, [Optional] Action onComplete)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xA2D104", Offset = "0xA2D104", VA = "0xA2D104")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xA2D120", Offset = "0xA2D120", VA = "0xA2D120")]
		public void HideInstant()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xA2D140", Offset = "0xA2D140", VA = "0xA2D140")]
		public void ShakeLocked()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xA2D258", Offset = "0xA2D258", VA = "0xA2D258")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xA2D280", Offset = "0xA2D280", VA = "0xA2D280")]
		public LevelUI()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class LevelUIGroup : MonoBehaviour
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Container;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LevelUI[] _levelUiList;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action _onHideCompleteCallback;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action _onShowCompleteCallback;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _curAreaId;

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xA2D288", Offset = "0xA2D288", VA = "0xA2D288")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xA2BA34", Offset = "0xA2BA34", VA = "0xA2BA34")]
		public void Refresh(int areaId, AreaData ad)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xA2BC5C", Offset = "0xA2BC5C", VA = "0xA2BC5C")]
		public void Show(Action onComplete)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xA2D560", Offset = "0xA2D560", VA = "0xA2D560")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xA2BB1C", Offset = "0xA2BB1C", VA = "0xA2BB1C")]
		public void ShowInstant()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xA2C0AC", Offset = "0xA2C0AC", VA = "0xA2C0AC")]
		public void Hide(Action onComplete)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xA2B068", Offset = "0xA2B068", VA = "0xA2B068")]
		public void HideInstant()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xA2D57C", Offset = "0xA2D57C", VA = "0xA2D57C")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xA2D5C4", Offset = "0xA2D5C4", VA = "0xA2D5C4")]
		public void OnSelectBtn(int id)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xA2D750", Offset = "0xA2D750", VA = "0xA2D750")]
		public LevelUIGroup()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class MaximizingBackground : MonoBehaviour
	{
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParallaxPortrait ParallaxPortrait;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParallaxPortrait ParallaxPortraitBlur;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RawImage Image;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RawImage ImageBlur;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _transform;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransform;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas _canvas;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isExpanded;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _scaleFactor;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector2 _fullScreenRect;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _savedPos;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector2 _savedSize;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform _curTransform;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _curRectTransform;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action _onContractCompleteCallback;

		[Token(Token = "0x40005AB")]
		private const float _showTime = 0.25f;

		[Token(Token = "0x40005AC")]
		private const float _hideTime = 0.25f;

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xA2D758", Offset = "0xA2D758", VA = "0xA2D758")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xA2D84C", Offset = "0xA2D84C", VA = "0xA2D84C")]
		public void SetTexture(Texture texture, Texture textureBlur, int textureId)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xA2D890", Offset = "0xA2D890", VA = "0xA2D890")]
		public void Contract(Action onComplete)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xA2D9FC", Offset = "0xA2D9FC", VA = "0xA2D9FC")]
		private void OnContractComplete()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xA2DA18", Offset = "0xA2DA18", VA = "0xA2DA18")]
		public void Expand(Transform t)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xA2DC90", Offset = "0xA2DC90", VA = "0xA2DC90")]
		public void ExpandInstant(Transform t)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xA2DEC0", Offset = "0xA2DEC0", VA = "0xA2DEC0")]
		public MaximizingBackground()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class ParallaxPortrait : MonoBehaviour
	{
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform MaximizedBackground;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RawImage Image;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 _idOffset;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _id;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform _rectTransform;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 _referenceTextureSize;

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xA2DEC8", Offset = "0xA2DEC8", VA = "0xA2DEC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xA2DF78", Offset = "0xA2DF78", VA = "0xA2DF78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xA29A6C", Offset = "0xA29A6C", VA = "0xA29A6C")]
		public void SetTexture(Texture texture, int id)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xA2E0D0", Offset = "0xA2E0D0", VA = "0xA2E0D0")]
		public ParallaxPortrait()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Game.NextEquipment
{
	[Token(Token = "0x20000E0")]
	public class NextEquipmentBar : MonoBehaviour
	{
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ImageStatBarFill ProgressBar;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Localize Label;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LocalizationParamsManager LabelValue;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Image Portrait;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform PortraitTransform;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image Lock;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _equipmentType;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _newEquipmentAvailable;

		[Token(Token = "0x170000AC")]
		public bool NewEquipmentAvailable
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xA2E0D8", Offset = "0xA2E0D8", VA = "0xA2E0D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xA2E0E0", Offset = "0xA2E0E0", VA = "0xA2E0E0")]
		public void Refresh(int currency, int areaReached, int equipmentType)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xA2E6C4", Offset = "0xA2E6C4", VA = "0xA2E6C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xA2E6D4", Offset = "0xA2E6D4", VA = "0xA2E6D4")]
		public NextEquipmentBar()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Widgets.Menu.TitleBar
{
	[Token(Token = "0x20000E1")]
	public class TitleBar : MonoBehaviour
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] Terms;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label0;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI Label1;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Localize Label0Localize;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Localize Label1Localize;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float TweenDistance;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float TweenTime;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _label0Transform;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _label1Transform;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Tween _label0Tween;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Tween _label1Tween;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Tween _label0TransformTween;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Tween _label1TransformTween;

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xA2E6DC", Offset = "0xA2E6DC", VA = "0xA2E6DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xA2E71C", Offset = "0xA2E71C", VA = "0xA2E71C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xA2E780", Offset = "0xA2E780", VA = "0xA2E780")]
		public void ChangeTo(int id, bool direction, bool instant = false)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xA2EA94", Offset = "0xA2EA94", VA = "0xA2EA94")]
		private void OnChanged()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xA2EB5C", Offset = "0xA2EB5C", VA = "0xA2EB5C")]
		public TitleBar()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Widgets.Game.MiniGameTimer
{
	[Token(Token = "0x20000E2")]
	public class MiniGameTimer : MonoBehaviour
	{
		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnTimeUp;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image ProgressBar;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MiniGameManager _miniGameManager;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color _initialColor;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xA2EB70", Offset = "0xA2EB70", VA = "0xA2EB70")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xA2EC08", Offset = "0xA2EC08", VA = "0xA2EC08")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xA2EC28", Offset = "0xA2EC28", VA = "0xA2EC28")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xA2EC50", Offset = "0xA2EC50", VA = "0xA2EC50")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xA2ED5C", Offset = "0xA2ED5C", VA = "0xA2ED5C")]
		public MiniGameTimer()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class MiniGameTimerGround : MonoBehaviour
	{
		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnTimeUp;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RingGenerator ProgressBar;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MiniGameManager _miniGameManager;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _angle0;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _angle1;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color _initialColor;

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xA2ED64", Offset = "0xA2ED64", VA = "0xA2ED64")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xA2EDF8", Offset = "0xA2EDF8", VA = "0xA2EDF8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xA2EE20", Offset = "0xA2EE20", VA = "0xA2EE20")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xA2EF44", Offset = "0xA2EF44", VA = "0xA2EF44")]
		public MiniGameTimerGround()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.AmmoNotifier
{
	[Token(Token = "0x20000E4")]
	public class AmmoCounter : MonoBehaviour
	{
		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocalizationParamsManager AmmoLabelValue;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI AmmoLabel;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image ArrowIcon;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _arrowIconRotationTransform;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _arrowIconTransform;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _ammoLabelTransform;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _noAmmo;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xA2EF4C", Offset = "0xA2EF4C", VA = "0xA2EF4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xA2F3C4", Offset = "0xA2F3C4", VA = "0xA2F3C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xA2F7FC", Offset = "0xA2F7FC", VA = "0xA2F7FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xA2F800", Offset = "0xA2F800", VA = "0xA2F800")]
		private void UpdateAmmoLabel()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xA2F8CC", Offset = "0xA2F8CC", VA = "0xA2F8CC")]
		private void OnShootEvent(int totalAmmo)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xA2FAA8", Offset = "0xA2FAA8", VA = "0xA2FAA8")]
		private void OnNockedEvent()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xA2FB74", Offset = "0xA2FB74", VA = "0xA2FB74")]
		private void OnAmmoReceivedEvent(int received, int totalAmmo)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xA2FE68", Offset = "0xA2FE68", VA = "0xA2FE68")]
		private void OnNoAmmoEvent(int totalAmmo)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xA2FF48", Offset = "0xA2FF48", VA = "0xA2FF48")]
		private void OnArrowPickedEvent(EDKG.ArcheryRange.VR.Arrow arrow)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xA2FFC4", Offset = "0xA2FFC4", VA = "0xA2FFC4")]
		private void OnArrowGoingHomeEvent()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xA30040", Offset = "0xA30040", VA = "0xA30040")]
		public AmmoCounter()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class BullseyeHitCounter : MonoBehaviour
	{
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Icon;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool StartHidden;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _labelTransform;

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xA30048", Offset = "0xA30048", VA = "0xA30048")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xA301C8", Offset = "0xA301C8", VA = "0xA301C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xA303B8", Offset = "0xA303B8", VA = "0xA303B8")]
		private void OnBullseyeHitEvent(int value)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xA301FC", Offset = "0xA301FC", VA = "0xA301FC")]
		private void UpdateLabel()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xA30400", Offset = "0xA30400", VA = "0xA30400")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xA3052C", Offset = "0xA3052C", VA = "0xA3052C")]
		public BullseyeHitCounter()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class BullseyeHitItem : MonoBehaviour
	{
		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _delay;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 _targetPosition;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action<BullseyeHitItem> _onCompleteCallback;

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xA30534", Offset = "0xA30534", VA = "0xA30534")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xA30584", Offset = "0xA30584", VA = "0xA30584")]
		public void Init(float delay, Vector3 targetPosition, Action<BullseyeHitItem> onComplete)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xA30594", Offset = "0xA30594", VA = "0xA30594")]
		private void Show()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xA30884", Offset = "0xA30884", VA = "0xA30884")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xA308B8", Offset = "0xA308B8", VA = "0xA308B8")]
		public BullseyeHitItem()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class TargetHitCounter : MonoBehaviour
	{
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MiniGameTargetManager _targetManager;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _labelTransform;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xA30908", Offset = "0xA30908", VA = "0xA30908")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xA30A64", Offset = "0xA30A64", VA = "0xA30A64")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xA30B78", Offset = "0xA30B78", VA = "0xA30B78")]
		private void OnHitEvent(int value)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xA30A68", Offset = "0xA30A68", VA = "0xA30A68")]
		private void UpdateLabel()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xA30B7C", Offset = "0xA30B7C", VA = "0xA30B7C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xA30C88", Offset = "0xA30C88", VA = "0xA30C88")]
		public TargetHitCounter()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.ScreenTabs
{
	[Token(Token = "0x20000E8")]
	public class CalibrationTab : UIScreenTab
	{
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SplashScreen SplashScreen;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ArmLengthCalibrationWindow CalibrationWindow;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ArmLengthCalibration Calibration;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UIManager _uiManager;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xA30C90", Offset = "0xA30C90", VA = "0xA30C90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xA30DE4", Offset = "0xA30DE4", VA = "0xA30DE4", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xA30E74", Offset = "0xA30E74", VA = "0xA30E74")]
		public void OnCalibrationContinueBtn()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xA30E98", Offset = "0xA30E98", VA = "0xA30E98")]
		public CalibrationTab()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	internal class CampaignTab : UIScreenTab
	{
		[Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class <DelayedFocus>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CampaignTab <>4__this;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000705")]
				[Address(RVA = "0xA3136C", Offset = "0xA3136C", VA = "0xA3136C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000707")]
				[Address(RVA = "0xA313B4", Offset = "0xA313B4", VA = "0xA313B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0xA31260", Offset = "0xA31260", VA = "0xA31260")]
			[DebuggerHidden]
			public <DelayedFocus>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0xA31298", Offset = "0xA31298", VA = "0xA31298", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0xA3129C", Offset = "0xA3129C", VA = "0xA3129C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0xA31374", Offset = "0xA31374", VA = "0xA31374", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AreaUIGroup AreaUIGroup;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CampaignAlert CampaignAlert;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _firstView;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xA30EA8", Offset = "0xA30EA8", VA = "0xA30EA8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xA30FA0", Offset = "0xA30FA0", VA = "0xA30FA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xA31090", Offset = "0xA31090", VA = "0xA31090")]
		private void OnAreaUnlockedEvent()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xA310B0", Offset = "0xA310B0", VA = "0xA310B0", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xA31158", Offset = "0xA31158", VA = "0xA31158", Slot = "10")]
		public override void SelectAgain()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xA311B8", Offset = "0xA311B8", VA = "0xA311B8", Slot = "11")]
		public override void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xA311F8", Offset = "0xA311F8", VA = "0xA311F8")]
		[IteratorStateMachine(typeof(<DelayedFocus>d__9))]
		private IEnumerator DelayedFocus()
		{
			return null;
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xA31288", Offset = "0xA31288", VA = "0xA31288")]
		public CampaignTab()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	internal class EquipmentTab : UIScreenTab
	{
		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int OverrideStartingPanelId;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int StartingPanelId;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public EquipmentAlert EquipmentAlert;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject EquipmentRenderer;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DynamicResizablePanelManager _dynamicResizablePanelManager;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isFirstLaunch;

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xA313BC", Offset = "0xA313BC", VA = "0xA313BC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xA31414", Offset = "0xA31414", VA = "0xA31414", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xA3150C", Offset = "0xA3150C", VA = "0xA3150C", Slot = "9")]
		protected override void AfterHide()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xA31530", Offset = "0xA31530", VA = "0xA31530")]
		public void SelectPanel(int id)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xA315FC", Offset = "0xA315FC", VA = "0xA315FC", Slot = "10")]
		public override void SelectAgain()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xA31620", Offset = "0xA31620", VA = "0xA31620", Slot = "11")]
		public override void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xA31600", Offset = "0xA31600", VA = "0xA31600")]
		public void Deselect()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xA31624", Offset = "0xA31624", VA = "0xA31624")]
		public EquipmentTab()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class HomeTab : UIScreenTab
	{
		[Token(Token = "0x6000711")]
		[Address(RVA = "0xA31688", Offset = "0xA31688", VA = "0xA31688", Slot = "5")]
		public override void ForceRefresh()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xA316F4", Offset = "0xA316F4", VA = "0xA316F4")]
		public HomeTab()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class LoadingTab : UIScreenTab
	{
		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SplashScreen SplashScreen;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Localize MainMessageLocalize;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI DebugMessage;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI Timer;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RectTransform Image;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UIManager _uiManager;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private WaitForSecondsRealtime _waitForSecond;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Coroutine _timer;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _step;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _time;

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xA316FC", Offset = "0xA316FC", VA = "0xA316FC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xA317B4", Offset = "0xA317B4", VA = "0xA317B4", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xA317B8", Offset = "0xA317B8", VA = "0xA317B8")]
		private void FinalizeEverything()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xA31974", Offset = "0xA31974", VA = "0xA31974")]
		public LoadingTab()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	internal class MiniGamesTab : UIScreenTab
	{
		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MiniGameDataLibrary MiniGameDataLibrary;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MiniGameUI[] MiniGameUIs;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ScrollRect ScrollRect;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public NewMiniGameAlert NewMiniGameAlert;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isFirstLaunch;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xA3197C", Offset = "0xA3197C", VA = "0xA3197C", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xA31A9C", Offset = "0xA31A9C", VA = "0xA31A9C")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xA31B94", Offset = "0xA31B94", VA = "0xA31B94")]
		private void FocusOnMiniGame(int id)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xA31C6C", Offset = "0xA31C6C", VA = "0xA31C6C")]
		public void SelectMiniGame(int id)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xA31DF0", Offset = "0xA31DF0", VA = "0xA31DF0")]
		public MiniGamesTab()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	internal class PlayTab : UIScreenTab
	{
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int OverrideStartingPanelId;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int StartingPanelId;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CampaignPanelContent campaignPanelContent;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DynamicResizablePanelManager _dynamicResizablePanelManager;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isFirstLaunch;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xA31E00", Offset = "0xA31E00", VA = "0xA31E00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xA31E58", Offset = "0xA31E58", VA = "0xA31E58", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xA31F0C", Offset = "0xA31F0C", VA = "0xA31F0C")]
		public void SelectPanel(int id)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xA31F90", Offset = "0xA31F90", VA = "0xA31F90", Slot = "10")]
		public override void SelectAgain()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xA31FF4", Offset = "0xA31FF4", VA = "0xA31FF4", Slot = "11")]
		public override void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xA31FD4", Offset = "0xA31FD4", VA = "0xA31FD4")]
		public void Deselect()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xA31FF8", Offset = "0xA31FF8", VA = "0xA31FF8")]
		public PlayTab()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	internal class SettingsTab : UIScreenTab
	{
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int StartingPanelId;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DynamicResizablePanelManager _dynamicResizablePanelManager;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isFirstLaunch;

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xA3205C", Offset = "0xA3205C", VA = "0xA3205C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xA320B4", Offset = "0xA320B4", VA = "0xA320B4", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xA320F0", Offset = "0xA320F0", VA = "0xA320F0")]
		public void SelectPanel(int id)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xA32174", Offset = "0xA32174", VA = "0xA32174", Slot = "10")]
		public override void SelectAgain()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xA32198", Offset = "0xA32198", VA = "0xA32198", Slot = "11")]
		public override void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xA32178", Offset = "0xA32178", VA = "0xA32178")]
		public void Deselect()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xA3219C", Offset = "0xA3219C", VA = "0xA3219C")]
		public void SelectPreviousPanel()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xA321B8", Offset = "0xA321B8", VA = "0xA321B8")]
		public void SelectNextPanel()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xA321D4", Offset = "0xA321D4", VA = "0xA321D4")]
		public SettingsTab()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class SplashTab : UIScreenTab
	{
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SplashScreen SplashScreen;

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xA321EC", Offset = "0xA321EC", VA = "0xA321EC")]
		public void OnPlayBtn()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xA3230C", Offset = "0xA3230C", VA = "0xA3230C")]
		public void OnSettingsBtn()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xA32384", Offset = "0xA32384", VA = "0xA32384")]
		public void OnQuitBtn()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xA323E8", Offset = "0xA323E8", VA = "0xA323E8")]
		public SplashTab()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class UIScreenTab : MonoBehaviour
	{
		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4000612")]
		private const float _showScaleEffectMultiplier = 0.9f;

		[Token(Token = "0x4000613")]
		private const float _showScaleEffectMultiplier2 = 1.15f;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 _showScaleEffectValue;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 _showScaleEffectValue2;

		[Token(Token = "0x4000616")]
		private const float _showTime = 0.15f;

		[Token(Token = "0x4000617")]
		private const float _hideTime = 0.15f;

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xA30D08", Offset = "0xA30D08", VA = "0xA30D08", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xA316F0", Offset = "0xA316F0", VA = "0xA316F0", Slot = "5")]
		public virtual void ForceRefresh()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xA323F0", Offset = "0xA323F0", VA = "0xA323F0")]
		public void Show(bool direction, bool instant = false)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xA32614", Offset = "0xA32614", VA = "0xA32614")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xA30E70", Offset = "0xA30E70", VA = "0xA30E70", Slot = "6")]
		protected virtual void BeforeShow()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xA32620", Offset = "0xA32620", VA = "0xA32620", Slot = "7")]
		protected virtual void AfterShow()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xA32624", Offset = "0xA32624", VA = "0xA32624")]
		public void Hide(bool direction, bool instant = false)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xA32780", Offset = "0xA32780", VA = "0xA32780")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xA327B8", Offset = "0xA327B8", VA = "0xA327B8", Slot = "8")]
		protected virtual void BeforeHide()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xA3152C", Offset = "0xA3152C", VA = "0xA3152C", Slot = "9")]
		protected virtual void AfterHide()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xA311B4", Offset = "0xA311B4", VA = "0xA311B4", Slot = "10")]
		public virtual void SelectAgain()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xA311F4", Offset = "0xA311F4", VA = "0xA311F4", Slot = "11")]
		public virtual void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xA30EA0", Offset = "0xA30EA0", VA = "0xA30EA0")]
		public UIScreenTab()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Screens
{
	[Token(Token = "0x20000F3")]
	public class GameUIScreen : UIScreen
	{
		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RealTime;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GamePauser _gamePauser;

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xA327BC", Offset = "0xA327BC", VA = "0xA327BC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xA328D0", Offset = "0xA328D0", VA = "0xA328D0", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xA32900", Offset = "0xA32900", VA = "0xA32900")]
		public GameUIScreen()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class UIScreen : MonoBehaviour
	{
		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int VRUIControllersState;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected UIManager _uiManager;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xA32834", Offset = "0xA32834", VA = "0xA32834", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xA32910", Offset = "0xA32910", VA = "0xA32910", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xA32920", Offset = "0xA32920", VA = "0xA32920", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xA32924", Offset = "0xA32924", VA = "0xA32924")]
		public void Show(bool instant = false)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xA32A90", Offset = "0xA32A90", VA = "0xA32A90")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xA328FC", Offset = "0xA328FC", VA = "0xA328FC", Slot = "7")]
		protected virtual void BeforeShow()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xA32A9C", Offset = "0xA32A9C", VA = "0xA32A9C", Slot = "8")]
		protected virtual void AfterShow()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xA32AA0", Offset = "0xA32AA0", VA = "0xA32AA0")]
		public void Hide(bool instant = false)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xA32BB8", Offset = "0xA32BB8", VA = "0xA32BB8")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xA32BF0", Offset = "0xA32BF0", VA = "0xA32BF0", Slot = "9")]
		protected virtual void BeforeHide()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xA32BF4", Offset = "0xA32BF4", VA = "0xA32BF4", Slot = "10")]
		protected virtual void AfterHide()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xA32908", Offset = "0xA32908", VA = "0xA32908")]
		public UIScreen()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Screens.MainMenu
{
	[Token(Token = "0x20000F5")]
	public class MenuScreen : UIScreen
	{
		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int OverrideStartingTab;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UIScreenTab[] Tabs;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int StartingTab;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DynamicResizablePanelManager NavBar;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TitleBar TitleBar;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UIScreenTab _curTab;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _curTabId;

		[Token(Token = "0x170000AF")]
		public int CurTabId
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0xA32BF8", Offset = "0xA32BF8", VA = "0xA32BF8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xA32C00", Offset = "0xA32C00", VA = "0xA32C00", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xA32D34", Offset = "0xA32D34", VA = "0xA32D34")]
		public void OnTabBtn(int id)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xA32F24", Offset = "0xA32F24", VA = "0xA32F24")]
		public void OnTabBtnLongPress(int id)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xA32FB8", Offset = "0xA32FB8", VA = "0xA32FB8")]
		public MenuScreen()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class SplashScreen : UIScreen
	{
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool IsInitialized;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UIScreenTab[] Tabs;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _curTabId;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UIScreenTab _curTab;

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xA32FC0", Offset = "0xA32FC0", VA = "0xA32FC0", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xA31920", Offset = "0xA31920", VA = "0xA31920")]
		public void MarkAsInitialized()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xA3237C", Offset = "0xA3237C", VA = "0xA3237C")]
		public void SwitchToSettings()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xA30E90", Offset = "0xA30E90", VA = "0xA30E90")]
		public void SwitchToSplash()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xA3196C", Offset = "0xA3196C", VA = "0xA3196C")]
		public void SwitchToCalibration()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xA33164", Offset = "0xA33164", VA = "0xA33164")]
		public void OnSwitchToSplashBtn()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xA330A0", Offset = "0xA330A0", VA = "0xA330A0")]
		private void SwitchToTab(int id)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xA331D0", Offset = "0xA331D0", VA = "0xA331D0")]
		public SplashScreen()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Screens.Game
{
	[Token(Token = "0x20000F7")]
	public class GameScreen : GameUIScreen
	{
		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LoadingScreen _loadingScreen;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _canBePaused;

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xA331D8", Offset = "0xA331D8", VA = "0xA331D8")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xA3326C", Offset = "0xA3326C", VA = "0xA3326C")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xA33278", Offset = "0xA33278", VA = "0xA33278", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xA3347C", Offset = "0xA3347C", VA = "0xA3347C", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xA33644", Offset = "0xA33644", VA = "0xA33644", Slot = "8")]
		protected override void AfterShow()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xA33650", Offset = "0xA33650", VA = "0xA33650", Slot = "9")]
		protected override void BeforeHide()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xA331E4", Offset = "0xA331E4", VA = "0xA331E4")]
		private void OnPauseEvent()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xA33658", Offset = "0xA33658", VA = "0xA33658")]
		private void OnRoundCompletedEvent(int value)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xA33680", Offset = "0xA33680", VA = "0xA33680")]
		public GameScreen()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class GameSettingsScreen : GameUIScreen
	{
		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int StartingPanelId;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DynamicResizablePanelManager DynamicResizablePanelManager;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isFirstLaunch;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xA33688", Offset = "0xA33688", VA = "0xA33688", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xA336C8", Offset = "0xA336C8", VA = "0xA336C8")]
		public void SelectPanel(int id)
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xA3374C", Offset = "0xA3374C", VA = "0xA3374C")]
		public void Deselect()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xA3376C", Offset = "0xA3376C", VA = "0xA3376C")]
		public void OnBackBtn()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xA337E0", Offset = "0xA337E0", VA = "0xA337E0")]
		public GameSettingsScreen()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class LevelCompletedScreen : GameUIScreen
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform Panel;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LocalizationParamsManager TitleLabel;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ImageStatBarSprites PreviousBestStars;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ImageStatBarSprites CurrentStars;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI RewardLabel;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Button NextBtn;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject NextGroup;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject NextAreaCompleteGroup;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject NextLastLevelCompleteGroup;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject NextEquipmentContainer;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public NextEquipmentBar[] NextEquipmentBars;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private LevelManager _levelManager;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _newEquipmentAvailable;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool _continueOptionChosen;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int _reward;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xA337F8", Offset = "0xA337F8", VA = "0xA337F8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xA33870", Offset = "0xA33870", VA = "0xA33870", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xA33888", Offset = "0xA33888", VA = "0xA33888")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xA33F1C", Offset = "0xA33F1C", VA = "0xA33F1C")]
		private void RefreshNextEquipmentBars(bool avoidWindowRescale = false)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xA34008", Offset = "0xA34008", VA = "0xA34008")]
		public void OnContinueBtn()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xA34094", Offset = "0xA34094", VA = "0xA34094")]
		public void OnRetryBtn()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xA34120", Offset = "0xA34120", VA = "0xA34120")]
		public void OnQuitBtn()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xA341B0", Offset = "0xA341B0", VA = "0xA341B0")]
		public void OnEquipmentBtn(int type)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xA34240", Offset = "0xA34240", VA = "0xA34240", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xA34250", Offset = "0xA34250", VA = "0xA34250")]
		public LevelCompletedScreen()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class LevelFailedScreen : GameUIScreen
	{
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform Panel;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LocalizationParamsManager TitleLabel;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ImageStatBarSprites PreviousBestStars;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI RewardLabel;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Button SkipBtn;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject SkipGroup;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject SkipLastLevelInAreaGroup;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject SkipLastLevelGroup;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private LevelManager _levelManager;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool ressuplyResourcesAvailable;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _continueOptionChosen;

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xA34258", Offset = "0xA34258", VA = "0xA34258", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xA34394", Offset = "0xA34394", VA = "0xA34394", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xA343AC", Offset = "0xA343AC", VA = "0xA343AC")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xA348B4", Offset = "0xA348B4", VA = "0xA348B4")]
		public void OnRetryBtn()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xA34940", Offset = "0xA34940", VA = "0xA34940")]
		public void OnSkipBtn()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xA349CC", Offset = "0xA349CC", VA = "0xA349CC")]
		public void OnQuitBtn()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xA34A5C", Offset = "0xA34A5C", VA = "0xA34A5C")]
		private void OnRessuplyEvent()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xA34A7C", Offset = "0xA34A7C", VA = "0xA34A7C", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xA34B7C", Offset = "0xA34B7C", VA = "0xA34B7C")]
		public LevelFailedScreen()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class MiniGameCompletedScreen : GameUIScreen
	{
		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform Panel;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LocalizationParamsManager TitleLabel;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI PreviousBestScore;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI CurrentScore;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI RewardLabel;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public NextEquipmentBar[] NextEquipmentBars;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MiniGameManager _miniGameManager;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _reward;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool _continueOptionChosen;

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xA34B84", Offset = "0xA34B84", VA = "0xA34B84", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xA34BFC", Offset = "0xA34BFC", VA = "0xA34BFC", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xA34C14", Offset = "0xA34C14", VA = "0xA34C14")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xA352A8", Offset = "0xA352A8", VA = "0xA352A8")]
		private void RefreshNextEquipmentBars()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xA35358", Offset = "0xA35358", VA = "0xA35358")]
		public void OnQuitBtn()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xA353E8", Offset = "0xA353E8", VA = "0xA353E8")]
		public void OnRetryBtn()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xA35474", Offset = "0xA35474", VA = "0xA35474")]
		public void OnEquipmentBtn(int type)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xA35504", Offset = "0xA35504", VA = "0xA35504")]
		public MiniGameCompletedScreen()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class MiniGameScreen : GameUIScreen
	{
		[Token(Token = "0x20000FD")]
		[CompilerGenerated]
		private sealed class <ProcessCountdown>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MiniGameScreen <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000794")]
				[Address(RVA = "0xA35E30", Offset = "0xA35E30", VA = "0xA35E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000796")]
				[Address(RVA = "0xA35E78", Offset = "0xA35E78", VA = "0xA35E78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0xA35AD0", Offset = "0xA35AD0", VA = "0xA35AD0")]
			[DebuggerHidden]
			public <ProcessCountdown>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xA35CB8", Offset = "0xA35CB8", VA = "0xA35CB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0xA35CBC", Offset = "0xA35CBC", VA = "0xA35CBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xA35E38", Offset = "0xA35E38", VA = "0xA35E38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI CountdownLabel;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float CountdownTime;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LoadingScreen _loadingScreen;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _canBePaused;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool _countdownEnded;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _time;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MiniGameManager _miniGameManager;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xA3550C", Offset = "0xA3550C", VA = "0xA3550C")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xA355A0", Offset = "0xA355A0", VA = "0xA355A0")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xA355AC", Offset = "0xA355AC", VA = "0xA355AC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xA357E4", Offset = "0xA357E4", VA = "0xA357E4", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xA359D4", Offset = "0xA359D4", VA = "0xA359D4", Slot = "8")]
		protected override void AfterShow()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xA35A38", Offset = "0xA35A38", VA = "0xA35A38", Slot = "9")]
		protected override void BeforeHide()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xA35518", Offset = "0xA35518", VA = "0xA35518")]
		private void OnPauseEvent()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xA35A40", Offset = "0xA35A40", VA = "0xA35A40")]
		private void OnRoundCompletedEvent(int value)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xA35A18", Offset = "0xA35A18", VA = "0xA35A18")]
		private void StartCountdown()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xA35A68", Offset = "0xA35A68", VA = "0xA35A68")]
		[IteratorStateMachine(typeof(<ProcessCountdown>d__16))]
		private IEnumerator ProcessCountdown()
		{
			return null;
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xA35AF8", Offset = "0xA35AF8", VA = "0xA35AF8")]
		private void AnimateCountdownLabel()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xA35C34", Offset = "0xA35C34", VA = "0xA35C34")]
		private void FadeOutCountdownLabel()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xA35C84", Offset = "0xA35C84", VA = "0xA35C84")]
		private void StartRound()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xA35CA0", Offset = "0xA35CA0", VA = "0xA35CA0")]
		public MiniGameScreen()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class PauseScreen : GameUIScreen
	{
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool IsMiniGame;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LoadingScreen _loadingScreen;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _canBeUnpaused;

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xA35E80", Offset = "0xA35E80", VA = "0xA35E80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xA35FBC", Offset = "0xA35FBC", VA = "0xA35FBC", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xA360BC", Offset = "0xA360BC", VA = "0xA360BC", Slot = "8")]
		protected override void AfterShow()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xA360C8", Offset = "0xA360C8", VA = "0xA360C8", Slot = "9")]
		protected override void BeforeHide()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xA360D0", Offset = "0xA360D0", VA = "0xA360D0")]
		private void OnPauseEvent()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xA360E0", Offset = "0xA360E0", VA = "0xA360E0")]
		public void OnResumeBtn()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xA36154", Offset = "0xA36154", VA = "0xA36154")]
		public void OnRestartBtn()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xA3623C", Offset = "0xA3623C", VA = "0xA3623C")]
		public void OnSettingsBtn()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xA362B0", Offset = "0xA362B0", VA = "0xA362B0")]
		public void OnQuitBtn()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xA363B4", Offset = "0xA363B4", VA = "0xA363B4")]
		public PauseScreen()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.ModalWindows
{
	[Token(Token = "0x20000FF")]
	public class EquipmentStatWindow : ModalWindow
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image[] StatPortraitList;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI[] StatTitleList;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI[] StatDescriptionList;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LocalizationParamsManager[] Parameters;

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xA363BC", Offset = "0xA363BC", VA = "0xA363BC")]
		public void Init(int id)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xA2838C", Offset = "0xA2838C", VA = "0xA2838C")]
		public void Init(int id, int equipmentType, EquipmentData data)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xA363DC", Offset = "0xA363DC", VA = "0xA363DC")]
		private void Highlight(int id)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xA36578", Offset = "0xA36578", VA = "0xA36578")]
		public EquipmentStatWindow()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ErrorWindow : ModalWindow
	{
		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Localize Title;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Localize Description;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action _onAction0;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action _onAction1;

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xA36580", Offset = "0xA36580", VA = "0xA36580")]
		public void Init(string title, string description)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xA3677C", Offset = "0xA3677C", VA = "0xA3677C")]
		public void Init(string title, string description, Action onAction0, Action onAction1)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xA36804", Offset = "0xA36804", VA = "0xA36804")]
		public void OnAction0()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xA36A28", Offset = "0xA36A28", VA = "0xA36A28")]
		public void OnAction1()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xA36AAC", Offset = "0xA36AAC", VA = "0xA36AAC")]
		public ErrorWindow()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class FestiveModalWindow : ModalWindow
	{
		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform ExpandingBackground;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action _onComplete;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xA36ABC", Offset = "0xA36ABC", VA = "0xA36ABC", Slot = "9")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xA36B9C", Offset = "0xA36B9C", VA = "0xA36B9C", Slot = "13")]
		public virtual void Hide(Action onComplete, bool instant = false)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xA36BAC", Offset = "0xA36BAC", VA = "0xA36BAC", Slot = "12")]
		protected override void AfterHide()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xA36BCC", Offset = "0xA36BCC", VA = "0xA36BCC")]
		public FestiveModalWindow()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[RequireComponent(typeof(CanvasGroup))]
	public class ModalWindow : MonoBehaviour
	{
		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool CanBeClosedWithBackButton;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x170000B2")]
		public virtual bool IsVisible
		{
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0xA36BD4", Offset = "0xA36BD4", VA = "0xA36BD4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xA36C7C", Offset = "0xA36C7C", VA = "0xA36C7C", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xA36CCC", Offset = "0xA36CCC", VA = "0xA36CCC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xA36CDC", Offset = "0xA36CDC", VA = "0xA36CDC", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xA36CE0", Offset = "0xA36CE0", VA = "0xA36CE0", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xA365F4", Offset = "0xA365F4", VA = "0xA365F4")]
		public void Show(bool instant = false)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xA36CE4", Offset = "0xA36CE4", VA = "0xA36CE4")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xA36B98", Offset = "0xA36B98", VA = "0xA36B98", Slot = "9")]
		protected virtual void BeforeShow()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xA36CF0", Offset = "0xA36CF0", VA = "0xA36CF0", Slot = "10")]
		protected virtual void AfterShow()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xA36CF4", Offset = "0xA36CF4", VA = "0xA36CF4")]
		public void OnHideBtn()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xA36888", Offset = "0xA36888", VA = "0xA36888")]
		public void Hide(bool instant = false)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xA36D60", Offset = "0xA36D60", VA = "0xA36D60")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xA36D98", Offset = "0xA36D98", VA = "0xA36D98", Slot = "11")]
		protected virtual void BeforeHide()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xA36BC8", Offset = "0xA36BC8", VA = "0xA36BC8", Slot = "12")]
		protected virtual void AfterHide()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xA36AB4", Offset = "0xA36AB4", VA = "0xA36AB4")]
		public ModalWindow()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class ModalWindowManager : MonoBehaviour
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ModalWindowManager Instance;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EquipmentStatWindow EquipmentStatInfoWindow;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModalWindow MiniGameTutorialWindow;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArmLengthCalibrationWindow ArmLengthCalibrationWindow;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PrivacyWindow PrivacyWindow;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ModalWindow SnapPointInfo;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xA36D9C", Offset = "0xA36D9C", VA = "0xA36D9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xA36DE8", Offset = "0xA36DE8", VA = "0xA36DE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xA36E30", Offset = "0xA36E30", VA = "0xA36E30")]
		public ModalWindowManager()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class WaitingWindow : ModalWindow
	{
		[Token(Token = "0x2000105")]
		[CompilerGenerated]
		private sealed class <UpdateCountdown>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WaitingWindow <>4__this;

			[Token(Token = "0x170000B3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D0")]
				[Address(RVA = "0xA374D8", Offset = "0xA374D8", VA = "0xA374D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D2")]
				[Address(RVA = "0xA37520", Offset = "0xA37520", VA = "0xA37520", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0xA37310", Offset = "0xA37310", VA = "0xA37310")]
			[DebuggerHidden]
			public <UpdateCountdown>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xA3742C", Offset = "0xA3742C", VA = "0xA3742C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0xA37430", Offset = "0xA37430", VA = "0xA37430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xA374E0", Offset = "0xA374E0", VA = "0xA374E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000106")]
		[CompilerGenerated]
		private sealed class <UpdateStopwatch>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WaitingWindow <>4__this;

			[Token(Token = "0x170000B5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D6")]
				[Address(RVA = "0xA375C8", Offset = "0xA375C8", VA = "0xA375C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D8")]
				[Address(RVA = "0xA37610", Offset = "0xA37610", VA = "0xA37610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xA373A0", Offset = "0xA373A0", VA = "0xA373A0")]
			[DebuggerHidden]
			public <UpdateStopwatch>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0xA37528", Offset = "0xA37528", VA = "0xA37528", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xA3752C", Offset = "0xA3752C", VA = "0xA3752C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0xA375D0", Offset = "0xA375D0", VA = "0xA375D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Localize Title;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Localize Description;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI Timer;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform Image;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _countdown;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaitForSecondsRealtime _waitForSecond;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _coroutine;

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xA36E38", Offset = "0xA36E38", VA = "0xA36E38", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xA36EA4", Offset = "0xA36EA4", VA = "0xA36EA4")]
		public void Init(int seconds = -1, bool startImmediately = true)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xA3701C", Offset = "0xA3701C", VA = "0xA3701C")]
		public void Init(string title, string description, int seconds = -1, bool startImmediately = true)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xA370A4", Offset = "0xA370A4", VA = "0xA370A4")]
		public void UpdateDescription(string title, string description)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xA37000", Offset = "0xA37000", VA = "0xA37000")]
		public void StartTimer()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xA3715C", Offset = "0xA3715C", VA = "0xA3715C")]
		private void StartCountdown()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xA372A8", Offset = "0xA372A8", VA = "0xA372A8")]
		[IteratorStateMachine(typeof(<UpdateCountdown>d__13))]
		private IEnumerator UpdateCountdown()
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xA371E0", Offset = "0xA371E0", VA = "0xA371E0")]
		public void StartStopwatch()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xA37338", Offset = "0xA37338", VA = "0xA37338")]
		[IteratorStateMachine(typeof(<UpdateStopwatch>d__15))]
		private IEnumerator UpdateStopwatch()
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xA3727C", Offset = "0xA3727C", VA = "0xA3727C")]
		private void DisableTimer()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xA373C8", Offset = "0xA373C8", VA = "0xA373C8", Slot = "12")]
		protected override void AfterHide()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xA373F8", Offset = "0xA373F8", VA = "0xA373F8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xA37424", Offset = "0xA37424", VA = "0xA37424")]
		public WaitingWindow()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Tutorial
{
	[Token(Token = "0x2000107")]
	public class TutorialAdvancedSettings : TutorialStepVR
	{
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xA37618", Offset = "0xA37618", VA = "0xA37618", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xA37720", Offset = "0xA37720", VA = "0xA37720")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xA377A0", Offset = "0xA377A0", VA = "0xA377A0")]
		private void OnShootEvent()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xA377C0", Offset = "0xA377C0", VA = "0xA377C0")]
		public TutorialAdvancedSettings()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class TutorialHitTargets : TutorialStepVR
	{
		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _bowHand;

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xA377F8", Offset = "0xA377F8", VA = "0xA377F8", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xA37900", Offset = "0xA37900", VA = "0xA37900")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xA37A00", Offset = "0xA37A00", VA = "0xA37A00")]
		private void OnArrowPickedEvent(EDKG.ArcheryRange.VR.Arrow arrow)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xA37A04", Offset = "0xA37A04", VA = "0xA37A04")]
		public TutorialHitTargets()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class TutorialStepDrawAndRelease : TutorialStepVR
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SplineComputer SplineRight;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform SplineRightStart;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform SplineRightEnd;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform _nock;

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xA37A20", Offset = "0xA37A20", VA = "0xA37A20", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xA37AA8", Offset = "0xA37AA8", VA = "0xA37AA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xA37B28", Offset = "0xA37B28", VA = "0xA37B28")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xA37BA8", Offset = "0xA37BA8", VA = "0xA37BA8", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xA37CAC", Offset = "0xA37CAC", VA = "0xA37CAC")]
		private void UpdateSpline(SplineComputer spline, Vector3 pos0, Vector3 pos0OffsetDirection, Vector3 pos1, Vector3 pos1OffsetDirection, Transform startSprite, Transform endSprite)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xA37F20", Offset = "0xA37F20", VA = "0xA37F20")]
		private void OnShootEvent()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xA37F24", Offset = "0xA37F24", VA = "0xA37F24")]
		public TutorialStepDrawAndRelease()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class TutorialStepMiniGames : TutorialStep
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModalWindow ModalWindow;

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xA37F40", Offset = "0xA37F40", VA = "0xA37F40", Slot = "4")]
		public override void Show(Tutorial tutorial)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xA37FE4", Offset = "0xA37FE4", VA = "0xA37FE4", Slot = "5")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xA38070", Offset = "0xA38070", VA = "0xA38070")]
		public void CompleteTutorialStep()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xA38074", Offset = "0xA38074", VA = "0xA38074")]
		public TutorialStepMiniGames()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class TutorialStepNockArrow : TutorialStepVR
	{
		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SplineComputer SplineLeft;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SplineComputer SplineRight;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform SplineLeftStart;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform SplineLeftEnd;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform SplineRightStart;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform SplineRightEnd;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _bowHand;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _hand;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform _nock;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xA38084", Offset = "0xA38084", VA = "0xA38084", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xA38330", Offset = "0xA38330", VA = "0xA38330")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xA38578", Offset = "0xA38578", VA = "0xA38578")]
		private void Start()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xA385F8", Offset = "0xA385F8", VA = "0xA385F8")]
		private void OnBowPickedEvent(Bow bow, int hand, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xA382FC", Offset = "0xA382FC", VA = "0xA382FC")]
		private void SetBowHand(int hand)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xA3862C", Offset = "0xA3862C", VA = "0xA3862C", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xA388A0", Offset = "0xA388A0", VA = "0xA388A0")]
		private void UpdateSpline(SplineComputer spline, Vector3 pos0, Vector3 pos0OffsetDirection, Vector3 pos1, Vector3 pos1OffsetDirection, Transform startSprite, Transform endSprite)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xA38B14", Offset = "0xA38B14", VA = "0xA38B14")]
		private void OnArrowNockedEvent()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xA38B18", Offset = "0xA38B18", VA = "0xA38B18")]
		private void OnArrowGoingHomeEvent()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xA38BE4", Offset = "0xA38BE4", VA = "0xA38BE4")]
		public TutorialStepNockArrow()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class TutorialStepPickArrow : TutorialStepVR
	{
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 QuiverOffset;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SplineComputer SplineLeft;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SplineComputer SplineRight;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform SplineLeftStart;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform SplineLeftEnd;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform SplineRightStart;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform SplineRightEnd;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _bowHand;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform _hand;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform _quiver;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 _quiverOffset;

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xA38C00", Offset = "0xA38C00", VA = "0xA38C00", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xA38E54", Offset = "0xA38E54", VA = "0xA38E54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xA3902C", Offset = "0xA3902C", VA = "0xA3902C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xA3904C", Offset = "0xA3904C", VA = "0xA3904C")]
		private void OnBowPickedEvent(Bow bow, int hand, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xA38DF4", Offset = "0xA38DF4", VA = "0xA38DF4")]
		private void SetBowHand(int hand)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xA39054", Offset = "0xA39054", VA = "0xA39054", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xA39208", Offset = "0xA39208", VA = "0xA39208")]
		private void UpdateSpline(SplineComputer spline, Vector3 pos0, Vector3 pos0OffsetDirection, Vector3 pos1, Vector3 pos1OffsetDirection, Transform startSprite, Transform endSprite)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xA3947C", Offset = "0xA3947C", VA = "0xA3947C")]
		private void OnArrowPickedEvent(EDKG.ArcheryRange.VR.Arrow arrow)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xA39480", Offset = "0xA39480", VA = "0xA39480")]
		public TutorialStepPickArrow()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class TutorialStepSwapHands : TutorialStepVR
	{
		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SplineComputer SplineLeft;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SplineComputer SplineRight;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform SplineLeftStart;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform SplineLeftEnd;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform SplineRightStart;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform SplineRightEnd;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public InputActionReference ForceGrabBowLeftAction;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public InputActionReference ForceGrabBowRightAction;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InputAction _forceGrabBowLeftAction;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InputAction _forceGrabBowRightAction;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform _handLeft;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform _handRight;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quiver _quiver;

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xA394AC", Offset = "0xA394AC", VA = "0xA394AC", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xA3961C", Offset = "0xA3961C", VA = "0xA3961C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xA3963C", Offset = "0xA3963C", VA = "0xA3963C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xA3971C", Offset = "0xA3971C", VA = "0xA3971C", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xA398C8", Offset = "0xA398C8", VA = "0xA398C8")]
		private void UpdateSpline(SplineComputer spline, Vector3 pos0, Vector3 pos0OffsetDirection, Vector3 pos1, Vector3 pos1OffsetDirection, Transform startSprite, Transform endSprite)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xA39B3C", Offset = "0xA39B3C", VA = "0xA39B3C")]
		private void OnForceGrabBowLeft(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xA39B58", Offset = "0xA39B58", VA = "0xA39B58")]
		private void OnForceGrabBowRight(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xA39B74", Offset = "0xA39B74", VA = "0xA39B74")]
		public TutorialStepSwapHands()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class TutorialStepVR : TutorialStep
	{
		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float YOffset;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ZOffset;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float SmoothFollowFactor;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Body _body;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform _camera;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _targetPos;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion _targetRot;

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xA376A0", Offset = "0xA376A0", VA = "0xA376A0", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xA39B90", Offset = "0xA39B90", VA = "0xA39B90", Slot = "4")]
		public override void Show(Tutorial tutorial)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xA39BC0", Offset = "0xA39BC0", VA = "0xA39BC0", Slot = "5")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xA37CA8", Offset = "0xA37CA8", VA = "0xA37CA8", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xA39BF0", Offset = "0xA39BF0", VA = "0xA39BF0")]
		private void UpdatePosition()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xA377DC", Offset = "0xA377DC", VA = "0xA377DC")]
		public TutorialStepVR()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010F")]
	public class Tutorial
	{
		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TutorialStep[] Steps;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TutorialManager _tutorialManager;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _curStepId;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TutorialStep _curStep;

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xA39E20", Offset = "0xA39E20", VA = "0xA39E20")]
		public void Init(TutorialManager tutorialManager)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xA39E80", Offset = "0xA39E80", VA = "0xA39E80")]
		public void MarkStepComplete(TutorialStep step)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xA39E30", Offset = "0xA39E30", VA = "0xA39E30")]
		private void NextStep()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xA39F5C", Offset = "0xA39F5C", VA = "0xA39F5C")]
		private void ReportTutorialComplete()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xA38B34", Offset = "0xA38B34", VA = "0xA38B34")]
		public void Rewind(TutorialStep step)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xA39FD0", Offset = "0xA39FD0", VA = "0xA39FD0")]
		private void PreviousStep()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xA3A020", Offset = "0xA3A020", VA = "0xA3A020")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xA3A090", Offset = "0xA3A090", VA = "0xA3A090")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xA3A100", Offset = "0xA3A100", VA = "0xA3A100")]
		public Tutorial()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class TutorialManager : MonoBehaviour
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TutorialManager Instance;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Tutorial[] Tutorials;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _curTutorialId;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Tutorial _curTutorial;

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xA3A110", Offset = "0xA3A110", VA = "0xA3A110")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xA3A1E4", Offset = "0xA3A1E4", VA = "0xA3A1E4")]
		public void ShowTutorialIfNeeded(int type)
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xA3A21C", Offset = "0xA3A21C", VA = "0xA3A21C")]
		private bool IsTutorialNeeded(int type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xA3A258", Offset = "0xA3A258", VA = "0xA3A258")]
		public void ShowTutorial(int type)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xA39F78", Offset = "0xA39F78", VA = "0xA39F78")]
		public void MarkTutorialComplete(Tutorial tutorial)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xA3A2C8", Offset = "0xA3A2C8", VA = "0xA3A2C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xA3A360", Offset = "0xA3A360", VA = "0xA3A360")]
		public TutorialManager()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class TutorialStarter : MonoBehaviour
	{
		[Token(Token = "0x600081D")]
		[Address(RVA = "0xA3A370", Offset = "0xA3A370", VA = "0xA3A370")]
		private void Start()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xA3A3C4", Offset = "0xA3A3C4", VA = "0xA3A3C4")]
		public TutorialStarter()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public abstract class TutorialStep : MonoBehaviour
	{
		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Tutorial _tutorial;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xA37F64", Offset = "0xA37F64", VA = "0xA37F64", Slot = "4")]
		public virtual void Show(Tutorial tutorial)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xA38008", Offset = "0xA38008", VA = "0xA38008", Slot = "5")]
		public virtual void Hide()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xA377A4", Offset = "0xA377A4", VA = "0xA377A4")]
		protected void ReportComplete()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xA3A3F0", Offset = "0xA3A3F0", VA = "0xA3A3F0", Slot = "6")]
		public virtual void Destroy()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xA3807C", Offset = "0xA3807C", VA = "0xA3807C")]
		protected TutorialStep()
		{
		}
	}
}
namespace EDKG.ArcheryRange._MiniGame
{
	[Token(Token = "0x2000113")]
	public class TwoTargetRotator : DynamicObject
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target[] TargetList;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DynamicObject[] ObjectsToActivate;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _curTarget;

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xA3A3F4", Offset = "0xA3A3F4", VA = "0xA3A3F4", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xA3A4A8", Offset = "0xA3A4A8", VA = "0xA3A4A8")]
		public TwoTargetRotator()
		{
		}
	}
}
namespace EDKG.ArcheryRange._MiniGame.SpringBarrelComponents
{
	[Token(Token = "0x2000114")]
	public class SpringBarrel : MonoBehaviour
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target Target;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform Container;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Speed;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool _goingUp;

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xA3A4B0", Offset = "0xA3A4B0", VA = "0xA3A4B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xA3A5CC", Offset = "0xA3A5CC", VA = "0xA3A5CC")]
		private void OnStepComplete()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xA3A77C", Offset = "0xA3A77C", VA = "0xA3A77C")]
		public SpringBarrel()
		{
		}
	}
}
namespace EDKG.ArcheryRange._MiniGame.BullseyeField
{
	[Token(Token = "0x2000115")]
	public class RandomTargetActivator : DynamicObject
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] Targets;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ActivateOnAwake;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _lastTargetId;

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xA3A794", Offset = "0xA3A794", VA = "0xA3A794")]
		private void Start()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xA3A7AC", Offset = "0xA3A7AC", VA = "0xA3A7AC", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xA3A84C", Offset = "0xA3A84C", VA = "0xA3A84C")]
		public RandomTargetActivator()
		{
		}
	}
	[Token(Token = "0x2000116")]
	internal class RandomTargetActivatorWithCheck : DynamicObject
	{
		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] Targets;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Target[] TargetsToCheck;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ActivateOnAwake;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DelayedActivatorAudioPlayer AudioPlayer;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _lastTargetId;

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xA3A864", Offset = "0xA3A864", VA = "0xA3A864")]
		private void Start()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xA3A87C", Offset = "0xA3A87C", VA = "0xA3A87C", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xA3AAE8", Offset = "0xA3AAE8", VA = "0xA3AAE8")]
		public RandomTargetActivatorWithCheck()
		{
		}
	}
}
namespace EDKG.ArcheryRange._MiniGame.TwoTargetRotatorComponents
{
	[Token(Token = "0x2000117")]
	public class RandomAreaMover : DynamicObject
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Corner1;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform Corner2;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float TweenDuration;

		[Token(Token = "0x170000B7")]
		public Vector3 NewPos
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0xA3AB00", Offset = "0xA3AB00", VA = "0xA3AB00")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000830")]
			[Address(RVA = "0xA3AB0C", Offset = "0xA3AB0C", VA = "0xA3AB0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xA3AB18", Offset = "0xA3AB18", VA = "0xA3AB18", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xA3AC14", Offset = "0xA3AC14", VA = "0xA3AC14")]
		public RandomAreaMover()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class RandomAxisMover : DynamicObject
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Point1;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 Point2;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float TweenDuration;

		[Token(Token = "0x170000B8")]
		public Vector3 NewPos
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0xA3AC24", Offset = "0xA3AC24", VA = "0xA3AC24")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000834")]
			[Address(RVA = "0xA3AC30", Offset = "0xA3AC30", VA = "0xA3AC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xA3AC3C", Offset = "0xA3AC3C", VA = "0xA3AC3C", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xA3ACF0", Offset = "0xA3ACF0", VA = "0xA3ACF0")]
		public RandomAxisMover()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class StepRotator : DynamicObject
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Step;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TweenDuration;

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xA3AD00", Offset = "0xA3AD00", VA = "0xA3AD00", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xA3AD28", Offset = "0xA3AD28", VA = "0xA3AD28")]
		public StepRotator()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class TargetFacer : DynamicObject
	{
		[Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class <DelayedActivation>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TargetFacer <>4__this;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000840")]
				[Address(RVA = "0xA3AFC8", Offset = "0xA3AFC8", VA = "0xA3AFC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000842")]
				[Address(RVA = "0xA3B010", Offset = "0xA3B010", VA = "0xA3B010", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0xA3AE94", Offset = "0xA3AE94", VA = "0xA3AE94")]
			[DebuggerHidden]
			public <DelayedActivation>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0xA3AECC", Offset = "0xA3AECC", VA = "0xA3AECC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0xA3AED0", Offset = "0xA3AED0", VA = "0xA3AED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0xA3AFD0", Offset = "0xA3AFD0", VA = "0xA3AFD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Target;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RandomAreaMover Pos;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float TweenDuration;

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xA3AD38", Offset = "0xA3AD38", VA = "0xA3AD38")]
		private void Start()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xA3AE0C", Offset = "0xA3AE0C", VA = "0xA3AE0C", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xA3AE2C", Offset = "0xA3AE2C", VA = "0xA3AE2C")]
		[IteratorStateMachine(typeof(<DelayedActivation>d__5))]
		private IEnumerator DelayedActivation()
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xA3AEBC", Offset = "0xA3AEBC", VA = "0xA3AEBC")]
		public TargetFacer()
		{
		}
	}
}
namespace EDKG.ArcheryRange._MiniGame.CircularRotatorComponents
{
	[Token(Token = "0x200011C")]
	public class StepRotator : DynamicObject
	{
		[Token(Token = "0x6000843")]
		[Address(RVA = "0xA3B018", Offset = "0xA3B018", VA = "0xA3B018", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xA3B0A8", Offset = "0xA3B0A8", VA = "0xA3B0A8")]
		public StepRotator()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class TargetRotator : MonoBehaviour
	{
		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target Target;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Speed;

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xA3B0B0", Offset = "0xA3B0B0", VA = "0xA3B0B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xA3B1C8", Offset = "0xA3B1C8", VA = "0xA3B1C8")]
		private void OnStepComplete()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xA3B1F8", Offset = "0xA3B1F8", VA = "0xA3B1F8")]
		public TargetRotator()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class ConstantRotator : MonoBehaviour
	{
		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Speed;

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xA3B208", Offset = "0xA3B208", VA = "0xA3B208")]
		private void Update()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xA3B2A0", Offset = "0xA3B2A0", VA = "0xA3B2A0")]
		public ConstantRotator()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Temp
{
	[Token(Token = "0x200011F")]
	public class TreeWindZone : MonoBehaviour
	{
		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer _renderer;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MaterialPropertyBlock _propBlock;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector4 _wind;

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xA3B2A8", Offset = "0xA3B2A8", VA = "0xA3B2A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xA3B334", Offset = "0xA3B334", VA = "0xA3B334")]
		private void Update()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xA3B33C", Offset = "0xA3B33C", VA = "0xA3B33C")]
		public void UpdateWind(bool setToZero = false)
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xA3B724", Offset = "0xA3B724", VA = "0xA3B724")]
		public TreeWindZone()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Progression.MiniGames
{
	[Serializable]
	[Token(Token = "0x2000120")]
	public class MiniGameData
	{
		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Id;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite BackgroundSprite;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite BlurredBackgroundSprite;

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xA3B72C", Offset = "0xA3B72C", VA = "0xA3B72C")]
		public MiniGameData()
		{
		}
	}
	[Token(Token = "0x2000121")]
	[CreateAssetMenu(fileName = "MiniGameDataLibrary", menuName = "ScriptableObjects/MiniGame Data Library", order = 0)]
	public class MiniGameDataLibrary : ScriptableObject
	{
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MiniGameData[] MiniGameList;

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xA3B734", Offset = "0xA3B734", VA = "0xA3B734")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xA3B78C", Offset = "0xA3B78C", VA = "0xA3B78C")]
		public MiniGameDataLibrary()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Progression.Balance
{
	[Serializable]
	[Token(Token = "0x2000122")]
	public class EquipmentBalanceData
	{
		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int PricePrimaryCurrency;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int UnlockArea;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xA3B794", Offset = "0xA3B794", VA = "0xA3B794")]
		public EquipmentBalanceData(int pricePrimaryCurrency, int unlockArea)
		{
		}
	}
	[Token(Token = "0x2000123")]
	[CreateAssetMenu(fileName = "BalanceData", menuName = "ScriptableObjects/Balance Data", order = 0)]
	public class BalanceData : ScriptableObject
	{
		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static BalanceData Instance;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Data loading")]
		[ReadOnly]
		public string Version;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAsset TextAsset;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Progression")]
		public int AreaCount;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int[] AreaStarRequirement;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Primary currency gains")]
		public int[] StarPCGain;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int[] BullseyeHitPCGain;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int[] MiniGameHitPCGain;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float MiniGameBullseyeHitTimeGain;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Equipment stats")]
		public EquipmentBalanceData[] Bows;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EquipmentBalanceData[] Arrows;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Monetization Costs")]
		public int RessuplyCost;

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xA3B7C0", Offset = "0xA3B7C0", VA = "0xA3B7C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xA3B80C", Offset = "0xA3B80C", VA = "0xA3B80C")]
		[ContextMenu("Load from CSV")]
		public void LoadFromCSV()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xA3C188", Offset = "0xA3C188", VA = "0xA3C188")]
		public bool IsBowPurchaseable(int id, int currencyAmount)
		{
			return default(bool);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xA3C1C8", Offset = "0xA3C1C8", VA = "0xA3C1C8")]
		public bool IsArrowPurchaseable(int id, int currencyAmount)
		{
			return default(bool);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xA3C208", Offset = "0xA3C208", VA = "0xA3C208")]
		public BalanceData()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Progression.Areas
{
	[Serializable]
	[Token(Token = "0x2000124")]
	public class AreaData
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Id;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture BackgroundTexture;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture BlurredBackgroundTexture;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int TextureId;

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xA3C220", Offset = "0xA3C220", VA = "0xA3C220")]
		public AreaData()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[CreateAssetMenu(fileName = "AreaDataLibrary", menuName = "ScriptableObjects/Area Data Library", order = 0)]
	public class AreaDataLibrary : ScriptableObject
	{
		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AreaData[] AreaList;

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xA3C228", Offset = "0xA3C228", VA = "0xA3C228")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xA3C280", Offset = "0xA3C280", VA = "0xA3C280")]
		public AreaDataLibrary()
		{
		}
	}
}
namespace EDKG.ArcheryRange.PostLut
{
	[Token(Token = "0x2000126")]
	[ExecuteInEditMode]
	public class PostLut : MonoBehaviour
	{
		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material SourceMaterial;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture2D DebugTexture;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Texture2D _nextLut;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material _instancedMaterial;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly int _textureNameId;

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xA3C288", Offset = "0xA3C288", VA = "0xA3C288")]
		private void Awake()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xA3C360", Offset = "0xA3C360", VA = "0xA3C360")]
		[ContextMenu("Test")]
		private void TestDebugTexture()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xA3C454", Offset = "0xA3C454", VA = "0xA3C454")]
		public void ChangeLut(Texture2D lut)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xA3C540", Offset = "0xA3C540", VA = "0xA3C540")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xA3C61C", Offset = "0xA3C61C", VA = "0xA3C61C")]
		public void Toggle(bool value)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xA3C628", Offset = "0xA3C628", VA = "0xA3C628")]
		public PostLut()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class PostLutChanger : MonoBehaviour
	{
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D Lut;

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xA3C680", Offset = "0xA3C680", VA = "0xA3C680")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xA3C684", Offset = "0xA3C684", VA = "0xA3C684")]
		[ContextMenu("Change LUT")]
		private void ChangeLut()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xA3C73C", Offset = "0xA3C73C", VA = "0xA3C73C")]
		[ContextMenu("Disable LUT")]
		private void DisableLut()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xA3C7F0", Offset = "0xA3C7F0", VA = "0xA3C7F0")]
		public PostLutChanger()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Initialization
{
	[Token(Token = "0x2000128")]
	public class EarlyInitMarker : MonoBehaviour
	{
		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static EarlyInitMarker Instance;

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xA3C7F8", Offset = "0xA3C7F8", VA = "0xA3C7F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xA3C88C", Offset = "0xA3C88C", VA = "0xA3C88C")]
		public EarlyInitMarker()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class EarlyInitMarkerChecker : MonoBehaviour
	{
		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject EarlyInitPrefab;

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xA3C894", Offset = "0xA3C894", VA = "0xA3C894")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xA3C960", Offset = "0xA3C960", VA = "0xA3C960")]
		public EarlyInitMarkerChecker()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class MainInitMarker : MonoBehaviour
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MainInitMarker Instance;

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xA3C968", Offset = "0xA3C968", VA = "0xA3C968")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xA3CAA0", Offset = "0xA3CAA0", VA = "0xA3CAA0")]
		public MainInitMarker()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class MainInitMarkerChecker : MonoBehaviour
	{
		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject MainInitPrefab;

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xA3CAA8", Offset = "0xA3CAA8", VA = "0xA3CAA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xA3CB74", Offset = "0xA3CB74", VA = "0xA3CB74")]
		public MainInitMarkerChecker()
		{
		}
	}
}
namespace EDKG.ArcheryRange.ImpactEffects
{
	[Token(Token = "0x200012C")]
	public class BaseImpactNotification : MonoBehaviour
	{
		[Token(Token = "0x600086C")]
		[Address(RVA = "0xA3CB7C", Offset = "0xA3CB7C", VA = "0xA3CB7C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xA3CB80", Offset = "0xA3CB80", VA = "0xA3CB80", Slot = "5")]
		protected virtual void Init()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xA3CB84", Offset = "0xA3CB84", VA = "0xA3CB84")]
		public BaseImpactNotification()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UIRenderer
{
	[Token(Token = "0x200012D")]
	public class EquipmentUIHomeRenderer : MonoBehaviour
	{
		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] Bows;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] Arrows;

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xA3CB8C", Offset = "0xA3CB8C", VA = "0xA3CB8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xA3CC0C", Offset = "0xA3CC0C", VA = "0xA3CC0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xA3CC8C", Offset = "0xA3CC8C", VA = "0xA3CC8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xA3CCF0", Offset = "0xA3CCF0", VA = "0xA3CCF0")]
		private void OnEquipmentChanged(int bow, int arrow)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xA3CE84", Offset = "0xA3CE84", VA = "0xA3CE84")]
		private void RefreshArrowPositions(Transform arrowGroup, Transform bowGroup)
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xA3CF7C", Offset = "0xA3CF7C", VA = "0xA3CF7C")]
		public EquipmentUIHomeRenderer()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class EquipmentUIRenderer : MonoBehaviour
	{
		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RenderTexture RenderTexture;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RawImage[] RawImages;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EquipmentUIRendererGroup[] Groups;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _curCategory;

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xA3CF84", Offset = "0xA3CF84", VA = "0xA3CF84")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xA3D084", Offset = "0xA3D084", VA = "0xA3D084")]
		public void SelectEquipment(int type, int id)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xA3D130", Offset = "0xA3D130", VA = "0xA3D130")]
		private void SelectCategory(int type)
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xA3D348", Offset = "0xA3D348", VA = "0xA3D348")]
		public EquipmentUIRenderer()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class EquipmentUIRendererGroup : MonoBehaviour
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] Items;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 Offset;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _curId;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _targetId;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 _startPosition;

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xA3D358", Offset = "0xA3D358", VA = "0xA3D358")]
		private void Awake()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xA3D1B8", Offset = "0xA3D1B8", VA = "0xA3D1B8")]
		public void SelectInstant(int id)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xA3D330", Offset = "0xA3D330", VA = "0xA3D330")]
		public void Select(int id)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xA3D43C", Offset = "0xA3D43C", VA = "0xA3D43C")]
		private void MoveToTargetItem()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xA3D4C0", Offset = "0xA3D4C0", VA = "0xA3D4C0")]
		private void EnableRequiredItems()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xA3D69C", Offset = "0xA3D69C", VA = "0xA3D69C")]
		private void Move()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xA3D7A8", Offset = "0xA3D7A8", VA = "0xA3D7A8")]
		private void OnMoveComplete()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xA3D7AC", Offset = "0xA3D7AC", VA = "0xA3D7AC")]
		private void DisableRequiredItems()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xA3D58C", Offset = "0xA3D58C", VA = "0xA3D58C")]
		private void AnimateEnter(Transform t)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xA3D388", Offset = "0xA3D388", VA = "0xA3D388")]
		private void AnimateRegular(Transform t)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xA3D42C", Offset = "0xA3D42C", VA = "0xA3D42C")]
		private void AnimateExit(Transform t)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xA3D840", Offset = "0xA3D840", VA = "0xA3D840")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xA3D8C8", Offset = "0xA3D8C8", VA = "0xA3D8C8")]
		public EquipmentUIRendererGroup()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UIData
{
	[Serializable]
	[Token(Token = "0x2000131")]
	public class EquipmentUIData
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Sprite Portrait;

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xA3D8F4", Offset = "0xA3D8F4", VA = "0xA3D8F4")]
		public EquipmentUIData()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[CreateAssetMenu(fileName = "EquipmentUILibrary", menuName = "ScriptableObjects/Equipment/Equipment UI Library", order = 0)]
	public class EquipmentUIDataLibrary : ScriptableObject
	{
		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EquipmentUIData[] Bows;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EquipmentUIData[] Arrows;

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xA3D8FC", Offset = "0xA3D8FC", VA = "0xA3D8FC")]
		public EquipmentUIDataLibrary()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Projectiles
{
	[Token(Token = "0x2000133")]
	public class Arrow : MonoBehaviour
	{
		[Token(Token = "0x2000134")]
		public delegate void SimpleEvent(Arrow arrow);

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SimpleEvent OnArrowMissed;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<RaycastHit, Vector3, int> OnHit;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask ColliderLayerMask;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform PhysicalArrowPrefab;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform StuckArrowPrefab;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject Model;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ArrowTrailRenderer TrailRenderer;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IMovable _movementSystem;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isAlive;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _defaultLife;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _curLife;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool _hasPotentialToHitTarget;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _maxTargetDistance;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 _velocity;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _penetrationDepth;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 _lastPos;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xA3D904", Offset = "0xA3D904", VA = "0xA3D904")]
		private void Awake()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xA3D954", Offset = "0xA3D954", VA = "0xA3D954")]
		public void Init(float speed, SpawnPool spawnPool, float maxTargetDistance)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xA3DAD0", Offset = "0xA3DAD0", VA = "0xA3DAD0")]
		private void Update()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xA3E108", Offset = "0xA3E108", VA = "0xA3E108")]
		private void CheckFutureCollision(RaycastHit hit)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xA3DF8C", Offset = "0xA3DF8C", VA = "0xA3DF8C")]
		private void CheckCollision(RaycastHit hit)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xA3E648", Offset = "0xA3E648", VA = "0xA3E648")]
		private void StuckInObject(RaycastHit hit, [Optional] Transform customTransformToStickTo)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xA3E374", Offset = "0xA3E374", VA = "0xA3E374")]
		private void HitImpenetrableObject(RaycastHit hit)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xA3E248", Offset = "0xA3E248", VA = "0xA3E248")]
		private Transform ReportTargetHit(RaycastHit hit, bool penetrated)
		{
			return null;
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xA3E4E0", Offset = "0xA3E4E0", VA = "0xA3E4E0")]
		private void ReportEnvironmentHit(RaycastHit hit, bool penetrated)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xA3DE44", Offset = "0xA3DE44", VA = "0xA3DE44")]
		private void ReportTargetMissed()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xA3DEB0", Offset = "0xA3DEB0", VA = "0xA3DEB0")]
		private void Die(bool instant = false)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xA3E94C", Offset = "0xA3E94C", VA = "0xA3E94C")]
		private void Despawn(bool instant)
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xA3E9B0", Offset = "0xA3E9B0", VA = "0xA3E9B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xA3EA18", Offset = "0xA3EA18", VA = "0xA3EA18")]
		public Arrow()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class PhysicalArrow : MonoBehaviour
	{
		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody Rigidbody;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _life;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _curLife;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xA3E858", Offset = "0xA3E858", VA = "0xA3E858")]
		public void Init(float speed, SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xA3EB7C", Offset = "0xA3EB7C", VA = "0xA3EB7C")]
		private void Update()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xA3EBC8", Offset = "0xA3EBC8", VA = "0xA3EBC8")]
		private void Despawn()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xA3EC78", Offset = "0xA3EC78", VA = "0xA3EC78")]
		public PhysicalArrow()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class StuckArrow : MonoBehaviour
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _life;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _curLife;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xA3E848", Offset = "0xA3E848", VA = "0xA3E848")]
		public void Init(SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xA3EC88", Offset = "0xA3EC88", VA = "0xA3EC88")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xA3ECD4", Offset = "0xA3ECD4", VA = "0xA3ECD4")]
		private void Despawn()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xA3ED88", Offset = "0xA3ED88", VA = "0xA3ED88")]
		public StuckArrow()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Projectiles.MovementSystems
{
	[Token(Token = "0x2000137")]
	public interface IMovable
	{
		[Token(Token = "0x60008A4")]
		void Init(float speed);

		[Token(Token = "0x60008A5")]
		void Process();

		[Token(Token = "0x60008A6")]
		Vector3 GetFuturePosition();

		[Token(Token = "0x60008A7")]
		Vector3 GetVelocity();

		[Token(Token = "0x60008A8")]
		void Kill();
	}
	[Token(Token = "0x2000138")]
	public class PhysicsMovement : MonoBehaviour, IMovable
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody Rigidbody;

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xA3ED98", Offset = "0xA3ED98", VA = "0xA3ED98", Slot = "4")]
		public void Init(float speed)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xA3EE50", Offset = "0xA3EE50", VA = "0xA3EE50", Slot = "5")]
		public void Process()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xA3EED0", Offset = "0xA3EED0", VA = "0xA3EED0", Slot = "6")]
		public Vector3 GetFuturePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xA3EF58", Offset = "0xA3EF58", VA = "0xA3EF58", Slot = "7")]
		public Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xA3EF74", Offset = "0xA3EF74", VA = "0xA3EF74", Slot = "8")]
		public void Kill()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xA3EF94", Offset = "0xA3EF94", VA = "0xA3EF94")]
		public PhysicsMovement()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Projectiles.Effects
{
	[Token(Token = "0x2000139")]
	public class ArrowTrailRenderer : MonoBehaviour
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject RearSprite;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TrailRenderer TrailRenderer;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isActive;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _defaultTrailRendererActivationTime;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _curTrailRendererActivationTime;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _defaultTrailRendererTime;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _curTrailRendererTime;

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xA3DA6C", Offset = "0xA3DA6C", VA = "0xA3DA6C")]
		public void Init()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xA3EF9C", Offset = "0xA3EF9C", VA = "0xA3EF9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xA3E8F4", Offset = "0xA3E8F4", VA = "0xA3E8F4")]
		public void Kill(bool instant)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xA3F0F4", Offset = "0xA3F0F4", VA = "0xA3F0F4")]
		public ArrowTrailRenderer()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Projectiles.TrajectoryAssist
{
	[Token(Token = "0x200013A")]
	public class AimAssistTrajectory : MonoBehaviour
	{
		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform CollisionSpot;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask ColliderLayerMask;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _source;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _velocity;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _drag;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _iterations;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _steps;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SplineComputer _splineComputer;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SplineRenderer _splineRenderer;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _camera;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material _lineMaterial;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3[] _positions;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SplinePoint[] _pointList;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _isActive;

		[Token(Token = "0x170000BB")]
		public SplinePoint[] PointList
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xA3F110", Offset = "0xA3F110", VA = "0xA3F110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xA3F118", Offset = "0xA3F118", VA = "0xA3F118")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xA3F2E8", Offset = "0xA3F2E8", VA = "0xA3F2E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xA3F314", Offset = "0xA3F314", VA = "0xA3F314")]
		public void Init(Transform s, float velocity)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xA3F788", Offset = "0xA3F788", VA = "0xA3F788")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xA3F930", Offset = "0xA3F930", VA = "0xA3F930")]
		public void SetVelocity(float velocity)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xA3F938", Offset = "0xA3F938", VA = "0xA3F938")]
		private void Update()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xA3F33C", Offset = "0xA3F33C", VA = "0xA3F33C")]
		private void UpdateTrajectory()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xA3F948", Offset = "0xA3F948", VA = "0xA3F948")]
		private float UpdateCollisions()
		{
			return default(float);
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xA3F65C", Offset = "0xA3F65C", VA = "0xA3F65C")]
		private void Show()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xA3F790", Offset = "0xA3F790", VA = "0xA3F790")]
		private void Hide()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xA3FC9C", Offset = "0xA3FC9C", VA = "0xA3FC9C")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xA3FCC8", Offset = "0xA3FCC8", VA = "0xA3FCC8")]
		public AimAssistTrajectory()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Equipment
{
	[Token(Token = "0x200013B")]
	public class EquipmentStats
	{
		[Token(Token = "0x170000BC")]
		public EquipmentPrefabData BowPrefabData
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xA3FD5C", Offset = "0xA3FD5C", VA = "0xA3FD5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xA3FD64", Offset = "0xA3FD64", VA = "0xA3FD64")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public ArrowPrefabData ArrowPrefabData
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xA3FD6C", Offset = "0xA3FD6C", VA = "0xA3FD6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xA3FD74", Offset = "0xA3FD74", VA = "0xA3FD74")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public float BaseAccuracy
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xA3FD7C", Offset = "0xA3FD7C", VA = "0xA3FD7C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xA3FD84", Offset = "0xA3FD84", VA = "0xA3FD84")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public float BaseArrowSpeed
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xA3FD8C", Offset = "0xA3FD8C", VA = "0xA3FD8C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xA3FD94", Offset = "0xA3FD94", VA = "0xA3FD94")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public float BaseStamina
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xA3FD9C", Offset = "0xA3FD9C", VA = "0xA3FD9C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xA3FDA4", Offset = "0xA3FDA4", VA = "0xA3FDA4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public float Accuracy
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xA3FDAC", Offset = "0xA3FDAC", VA = "0xA3FDAC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xA3FDB4", Offset = "0xA3FDB4", VA = "0xA3FDB4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public float ArrowSpeed
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xA3FDBC", Offset = "0xA3FDBC", VA = "0xA3FDBC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0xA3FDC4", Offset = "0xA3FDC4", VA = "0xA3FDC4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public float Stamina
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0xA3FDCC", Offset = "0xA3FDCC", VA = "0xA3FDCC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0xA3FDD4", Offset = "0xA3FDD4", VA = "0xA3FDD4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xA3FDDC", Offset = "0xA3FDDC", VA = "0xA3FDDC")]
		public EquipmentStats()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013C")]
	public class EquipmentData
	{
		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Accuracy;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float ArrowSpeed;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Stamina;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int UIAccuracy;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int UIArrowSpeed;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int UIStamina;

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xA3FDE4", Offset = "0xA3FDE4", VA = "0xA3FDE4")]
		public EquipmentData()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[CreateAssetMenu(fileName = "EquipmentLibrary", menuName = "ScriptableObjects/Equipment/Equipment Library", order = 0)]
	public class EquipmentDataLibrary : ScriptableObject
	{
		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Data loading")]
		[ReadOnly]
		public string Version;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAsset TextAsset;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Space]
		public float BaseAccuracy;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float BaseArrowSpeed;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float BaseStamina;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Space]
		public EquipmentData[] Bows;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space]
		public EquipmentData[] Arrows;

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xA3FDEC", Offset = "0xA3FDEC", VA = "0xA3FDEC")]
		[ContextMenu("Load from CSV")]
		public void LoadFromCSV()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xA4042C", Offset = "0xA4042C", VA = "0xA4042C")]
		public EquipmentDataLibrary()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class AllEquipmentLoader : MonoBehaviour
	{
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EquipmentDataLibrary EquipmentDataLibrary;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EquipmentPrefabLoader BowPrefabLoader;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EquipmentPrefabLoader ArrowPrefabLoader;

		[Token(Token = "0x170000C4")]
		public EquipmentStats Stats
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0xA40434", Offset = "0xA40434", VA = "0xA40434")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0xA4043C", Offset = "0xA4043C", VA = "0xA4043C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xA40444", Offset = "0xA40444", VA = "0xA40444")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xA405FC", Offset = "0xA405FC", VA = "0xA405FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xA40634", Offset = "0xA40634", VA = "0xA40634")]
		public AllEquipmentLoader()
		{
		}
	}
	[Token(Token = "0x200013F")]
	internal class ArrowPrefabLoader : EquipmentPrefabLoader
	{
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int PreloadAmount;

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xA4063C", Offset = "0xA4063C", VA = "0xA4063C", Slot = "5")]
		public override void FinalizeLoad()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xA406C4", Offset = "0xA406C4", VA = "0xA406C4")]
		private void InstantiatePool(ArrowPrefabData arrowData)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xA408A8", Offset = "0xA408A8", VA = "0xA408A8")]
		public ArrowPrefabLoader()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class BowPrefabLoader : EquipmentPrefabLoader
	{
		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform EquipmentContainer;

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xA408C0", Offset = "0xA408C0", VA = "0xA408C0", Slot = "4")]
		public override EquipmentPrefabData AwakeLoad(int id)
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xA40988", Offset = "0xA40988", VA = "0xA40988")]
		private void InstantiateCharacterEquipment(EquipmentPrefabData data)
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xA40AA8", Offset = "0xA40AA8", VA = "0xA40AA8")]
		public BowPrefabLoader()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class EquipmentPrefabLoader : MonoBehaviour
	{
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] DataPath;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected EquipmentPrefabData Data;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected int _id;

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xA408F0", Offset = "0xA408F0", VA = "0xA408F0", Slot = "4")]
		public virtual EquipmentPrefabData AwakeLoad(int id)
		{
			return null;
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xA406C0", Offset = "0xA406C0", VA = "0xA406C0", Slot = "5")]
		public virtual void FinalizeLoad()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xA408B8", Offset = "0xA408B8", VA = "0xA408B8")]
		public EquipmentPrefabLoader()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class QuiverPrefabLoader : EquipmentPrefabLoader
	{
		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform EquipmentContainer;

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xA40AB0", Offset = "0xA40AB0", VA = "0xA40AB0", Slot = "4")]
		public override EquipmentPrefabData AwakeLoad(int id)
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xA40AE0", Offset = "0xA40AE0", VA = "0xA40AE0")]
		private void InstantiateCharacterEquipment(EquipmentPrefabData data)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xA40C00", Offset = "0xA40C00", VA = "0xA40C00")]
		public QuiverPrefabLoader()
		{
		}
	}
	[Token(Token = "0x2000143")]
	[CreateAssetMenu(fileName = "Arrow", menuName = "ScriptableObjects/Equipment/Arrow Prefab Data", order = 2)]
	public class ArrowPrefabData : EquipmentPrefabData
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EDKG.ArcheryRange.Projectiles.Arrow ArrowPrefab;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EDKG.ArcheryRange.VR.Arrow DummyArrowPrefab;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PhysicalArrow PhysicalArrowPrefab;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public StuckArrow StuckArrowPrefab;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform Model;

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xA40C08", Offset = "0xA40C08", VA = "0xA40C08")]
		public ArrowPrefabData()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[CreateAssetMenu(fileName = "Equipment", menuName = "ScriptableObjects/Equipment/Equipment Prefab Data", order = 0)]
	public class EquipmentPrefabData : ScriptableObject
	{
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject EquipmentPrefab;

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xA40C10", Offset = "0xA40C10", VA = "0xA40C10")]
		public EquipmentPrefabData()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Targets
{
	[Token(Token = "0x2000145")]
	public class DelayedActivatorAudioPlayer : AudioSourcePool
	{
		[Token(Token = "0x2000146")]
		[CompilerGenerated]
		private sealed class <PlayDelayedActivation>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DelayedActivatorAudioPlayer <>4__this;

			[Token(Token = "0x170000C5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008F4")]
				[Address(RVA = "0xA40FA0", Offset = "0xA40FA0", VA = "0xA40FA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008F6")]
				[Address(RVA = "0xA40FE8", Offset = "0xA40FE8", VA = "0xA40FE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xA40DE4", Offset = "0xA40DE4", VA = "0xA40DE4")]
			[DebuggerHidden]
			public <PlayDelayedActivation>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xA40EBC", Offset = "0xA40EBC", VA = "0xA40EBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xA40EC0", Offset = "0xA40EC0", VA = "0xA40EC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0xA40FA8", Offset = "0xA40FA8", VA = "0xA40FA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000147")]
		[CompilerGenerated]
		private sealed class <PlayLaunchSound>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DelayedActivatorAudioPlayer <>4__this;

			[Token(Token = "0x170000C7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008FA")]
				[Address(RVA = "0xA410AC", Offset = "0xA410AC", VA = "0xA410AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008FC")]
				[Address(RVA = "0xA410F4", Offset = "0xA410F4", VA = "0xA410F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xA40E0C", Offset = "0xA40E0C", VA = "0xA40E0C")]
			[DebuggerHidden]
			public <PlayLaunchSound>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xA40FF0", Offset = "0xA40FF0", VA = "0xA40FF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0xA40FF4", Offset = "0xA40FF4", VA = "0xA40FF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0xA410B4", Offset = "0xA410B4", VA = "0xA410B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip ActivationSound;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip LaunchSound;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float PitchDelta;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float PitchOffset;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float VolumeDelta;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float VolumeOffset;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource _activationSource;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _delay;

		[Token(Token = "0x4000767")]
		private const float ActivationSoundLength = 2.5f;

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xA40C18", Offset = "0xA40C18", VA = "0xA40C18")]
		public void PlayActivationSound(float delay)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xA40CF4", Offset = "0xA40CF4", VA = "0xA40CF4")]
		[IteratorStateMachine(typeof(<PlayDelayedActivation>d__10))]
		private IEnumerator PlayDelayedActivation(float time)
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xA40D6C", Offset = "0xA40D6C", VA = "0xA40D6C")]
		[IteratorStateMachine(typeof(<PlayLaunchSound>d__11))]
		private IEnumerator PlayLaunchSound(float delay)
		{
			return null;
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xA40E34", Offset = "0xA40E34", VA = "0xA40E34")]
		public void StopActivationSound()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xA3AA60", Offset = "0xA3AA60", VA = "0xA3AA60")]
		public void PlayLaunchSound()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xA40EB4", Offset = "0xA40EB4", VA = "0xA40EB4")]
		public DelayedActivatorAudioPlayer()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Audio.Players
{
	[Token(Token = "0x2000148")]
	public class MiscUIAudioPlayer : AudioSourcePool
	{
		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip[] CoinsSounds;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip[] BowSounds;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip[] ArrowSounds;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip[] IAPSounds;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip[] HomingArrowsSounds;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioClip WinSound;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioClip LoseSound;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioClip TutorialSound0;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioClip TutorialSound1;

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xA410FC", Offset = "0xA410FC", VA = "0xA410FC")]
		public void PlayBowPurchaseSound()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xA411A0", Offset = "0xA411A0", VA = "0xA411A0")]
		public void PlayBowEquipSound()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xA411FC", Offset = "0xA411FC", VA = "0xA411FC")]
		public void PlayArrowPurchaseSound()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xA412A0", Offset = "0xA412A0", VA = "0xA412A0")]
		public void PlayArrowEquipSound()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xA412FC", Offset = "0xA412FC", VA = "0xA412FC")]
		public void PlayIAPPurchaseSound()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xA41358", Offset = "0xA41358", VA = "0xA41358")]
		public void PlayActivateHomingArrow()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xA413B4", Offset = "0xA413B4", VA = "0xA413B4")]
		public void PlayWinLevel()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xA41460", Offset = "0xA41460", VA = "0xA41460")]
		public void PlayLoseLevel()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xA3A3CC", Offset = "0xA3A3CC", VA = "0xA3A3CC")]
		public void PlayTutorialSound(bool show)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xA4150C", Offset = "0xA4150C", VA = "0xA4150C")]
		public MiscUIAudioPlayer()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Audio.AnimationSync
{
	[Token(Token = "0x2000149")]
	public class CharacterAudioPlayer : AudioSourcePool
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource DrawSource;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip[] DrawSnd;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip[] ReleaseSnd;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip[] TakeArrowSnd;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip[] PutArrowSnd;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _lastDrawSnd;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _lastReleaseSnd;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _lastTakeArrowSnd;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _lastPutArrowSnd;

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xA41544", Offset = "0xA41544", VA = "0xA41544")]
		public void PlayDraw()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xA41610", Offset = "0xA41610", VA = "0xA41610")]
		public void StopDraw()
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xA4162C", Offset = "0xA4162C", VA = "0xA4162C")]
		public void PlayRelease()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xA416D8", Offset = "0xA416D8", VA = "0xA416D8")]
		public void PlayTakeArrow()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xA41774", Offset = "0xA41774", VA = "0xA41774")]
		public void PlayPutArrow(int id)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xA41824", Offset = "0xA41824", VA = "0xA41824")]
		public CharacterAudioPlayer()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class WeaponAudioPlayer : AudioSourcePool
	{
		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource DrawSource;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip[] NockSnd;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip[] DrawSnd;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip[] ReleaseSnd;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip[] CancelSnd;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _lastNockSnd;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _lastDrawSnd;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _lastReleaseSnd;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _lastCancelSnd;

		[Token(Token = "0x400078B")]
		private const float _drawThreshold = 0.35f;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _thresholdPassed;

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xA4182C", Offset = "0xA4182C", VA = "0xA4182C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xA41994", Offset = "0xA41994", VA = "0xA41994")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xA41AF0", Offset = "0xA41AF0", VA = "0xA41AF0")]
		private void OnNockedEvent()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xA41B90", Offset = "0xA41B90", VA = "0xA41B90")]
		private void OnDrawChagingEvent(float amount, float rawAmount)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xA41CC0", Offset = "0xA41CC0", VA = "0xA41CC0")]
		private void OnShootEvent()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xA41DA0", Offset = "0xA41DA0", VA = "0xA41DA0")]
		private void OnCancelEvent()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xA41AF4", Offset = "0xA41AF4", VA = "0xA41AF4")]
		private void PlayNock()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xA41BF4", Offset = "0xA41BF4", VA = "0xA41BF4")]
		private void PlayDraw()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xA41CE8", Offset = "0xA41CE8", VA = "0xA41CE8")]
		private void StopDraw()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xA41D04", Offset = "0xA41D04", VA = "0xA41D04")]
		private void PlayShoot()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xA41DC8", Offset = "0xA41DC8", VA = "0xA41DC8")]
		private void PlayCancel()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xA41E64", Offset = "0xA41E64", VA = "0xA41E64")]
		public WeaponAudioPlayer()
		{
		}
	}
}
namespace EDKG.ArcheryRange.AlertSystem
{
	[Token(Token = "0x200014B")]
	public class CampaignAlert : BaseAlert
	{
		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _shownCampaignAlertId;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _seenCampaignAlertId;

		[Token(Token = "0x170000C9")]
		public int ShownCampaignAlertId
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0xA41E6C", Offset = "0xA41E6C", VA = "0xA41E6C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xA41E74", Offset = "0xA41E74", VA = "0xA41E74", Slot = "7")]
		protected override void CheckIfAlertNeeded()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xA41F7C", Offset = "0xA41F7C", VA = "0xA41F7C", Slot = "9")]
		public override void MarkAlertViewed()
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xA41FAC", Offset = "0xA41FAC", VA = "0xA41FAC")]
		public CampaignAlert()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public class EquipmentAlert : BaseAlert
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AlertWidget BowsAlert;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AlertWidget ArrowsAlert;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isBowsAlertNeeded;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isArrowsAlertNeeded;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _shownBowAlertId;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _shownArrowAlertId;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _seenBowAlertId;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _seenArrowAlertId;

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xA41FC4", Offset = "0xA41FC4", VA = "0xA41FC4", Slot = "7")]
		protected override void CheckIfAlertNeeded()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xA422BC", Offset = "0xA422BC", VA = "0xA422BC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xA42360", Offset = "0xA42360", VA = "0xA42360")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xA423E0", Offset = "0xA423E0", VA = "0xA423E0")]
		private void OnPrimaryCurrencyChangedEvent(int value)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xA4240C", Offset = "0xA4240C", VA = "0xA4240C", Slot = "8")]
		protected override void RefreshAlert(bool instant = false)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xA41FF8", Offset = "0xA41FF8", VA = "0xA41FF8")]
		private void CheckBowsAlert()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xA4214C", Offset = "0xA4214C", VA = "0xA4214C")]
		private void CheckArrowsAlert()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xA4256C", Offset = "0xA4256C", VA = "0xA4256C")]
		public void MarkBowsAlertViewed()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xA4259C", Offset = "0xA4259C", VA = "0xA4259C")]
		public void MarkArrowsAlertViewed()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xA422A0", Offset = "0xA422A0", VA = "0xA422A0")]
		private void FinalizeAlertCheck()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xA425CC", Offset = "0xA425CC", VA = "0xA425CC")]
		public EquipmentAlert()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public class NewAreaAlert : BaseAlert
	{
		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AlertWidget CampaignAlert;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AlertWidget MiniGameAlert;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isCampaignAlertNeeded;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isMiniGameAlertNeeded;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _shownCampaignAlertId;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _shownMiniGameAlertId;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _seenCampaignAlertId;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _seenMiniGameAlertId;

		[Token(Token = "0x170000CA")]
		public int ShownCampaignAlertId
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0xA425E0", Offset = "0xA425E0", VA = "0xA425E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CB")]
		public int ShownMiniGameAlertId
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0xA425E8", Offset = "0xA425E8", VA = "0xA425E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xA425F0", Offset = "0xA425F0", VA = "0xA425F0", Slot = "7")]
		protected override void CheckIfAlertNeeded()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xA427C0", Offset = "0xA427C0", VA = "0xA427C0", Slot = "8")]
		protected override void RefreshAlert(bool instant = false)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xA42624", Offset = "0xA42624", VA = "0xA42624")]
		private void CheckCampaignAlert()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xA42728", Offset = "0xA42728", VA = "0xA42728")]
		private void CheckMiniGameAlert()
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xA428A8", Offset = "0xA428A8", VA = "0xA428A8")]
		public void MarkCampaignAlertViewed()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xA428D8", Offset = "0xA428D8", VA = "0xA428D8")]
		public void MarkMiniGameAlertViewed()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xA427A4", Offset = "0xA427A4", VA = "0xA427A4")]
		private void FinalizeAlertCheck()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xA42950", Offset = "0xA42950", VA = "0xA42950")]
		public NewAreaAlert()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class NewMiniGameAlert : BaseAlert
	{
		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _shownMiniGameAlertId;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _seenMiniGameAlertId;

		[Token(Token = "0x170000CC")]
		public int ShownMiniGameAlertId
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0xA42964", Offset = "0xA42964", VA = "0xA42964")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xA4296C", Offset = "0xA4296C", VA = "0xA4296C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xA42A08", Offset = "0xA42A08", VA = "0xA42A08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xA42A88", Offset = "0xA42A88", VA = "0xA42A88", Slot = "7")]
		protected override void CheckIfAlertNeeded()
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xA42B04", Offset = "0xA42B04", VA = "0xA42B04", Slot = "9")]
		public override void MarkAlertViewed()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xA42B54", Offset = "0xA42B54", VA = "0xA42B54")]
		private void OnAreaUnlockedEvent(int areaId)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xA42B60", Offset = "0xA42B60", VA = "0xA42B60")]
		public NewMiniGameAlert()
		{
		}
	}
}
namespace DefaultNamespace
{
	[Token(Token = "0x200014F")]
	public class BaseAlert : MonoBehaviour
	{
		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AlertWidget NavBarAlert;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool _isNeeded;

		[Token(Token = "0x170000CD")]
		public bool IsNeeded
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0xA42B70", Offset = "0xA42B70", VA = "0xA42B70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xA429FC", Offset = "0xA429FC", VA = "0xA429FC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xA42B78", Offset = "0xA42B78", VA = "0xA42B78", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xA42350", Offset = "0xA42350", VA = "0xA42350", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xA41F78", Offset = "0xA41F78", VA = "0xA41F78", Slot = "7")]
		protected virtual void CheckIfAlertNeeded()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xA424F4", Offset = "0xA424F4", VA = "0xA424F4", Slot = "8")]
		protected virtual void RefreshAlert(bool instant = false)
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xA41F98", Offset = "0xA41F98", VA = "0xA41F98", Slot = "9")]
		public virtual void MarkAlertViewed()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xA42B84", Offset = "0xA42B84", VA = "0xA42B84", Slot = "10")]
		public virtual void CheckForAlert()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xA41FBC", Offset = "0xA41FBC", VA = "0xA41FBC")]
		public BaseAlert()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class LevelCounter : MonoBehaviour
	{
		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocalizationParamsManager LevelLabel;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform LevelProgressBar;

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xA42BB0", Offset = "0xA42BB0", VA = "0xA42BB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xA42C30", Offset = "0xA42C30", VA = "0xA42C30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xA42D20", Offset = "0xA42D20", VA = "0xA42D20")]
		private void OnTargetListProgressChangedEvent(float percent)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xA42DBC", Offset = "0xA42DBC", VA = "0xA42DBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xA42E94", Offset = "0xA42E94", VA = "0xA42E94")]
		public LevelCounter()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class MiniGameCounter : MonoBehaviour
	{
		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI LevelLabel;

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xA42E9C", Offset = "0xA42E9C", VA = "0xA42E9C")]
		private void Start()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xA42F44", Offset = "0xA42F44", VA = "0xA42F44")]
		public MiniGameCounter()
		{
		}
	}
}
namespace I2.Loc
{
	[Token(Token = "0x2000152")]
	public static class PersistentStorage
	{
		[Token(Token = "0x2000153")]
		public enum eFileType
		{
			[Token(Token = "0x40007A8")]
			Raw,
			[Token(Token = "0x40007A9")]
			Persistent,
			[Token(Token = "0x40007AA")]
			Temporal,
			[Token(Token = "0x40007AB")]
			Streaming
		}

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xA42F4C", Offset = "0xA42F4C", VA = "0xA42F4C")]
		public static void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xA4300C", Offset = "0xA4300C", VA = "0xA4300C")]
		public static string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xA430C4", Offset = "0xA430C4", VA = "0xA430C4")]
		public static void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xA4316C", Offset = "0xA4316C", VA = "0xA4316C")]
		public static bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xA43214", Offset = "0xA43214", VA = "0xA43214")]
		public static void ForceSaveSettings()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xA432B4", Offset = "0xA432B4", VA = "0xA432B4")]
		public static bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xA43354", Offset = "0xA43354", VA = "0xA43354")]
		public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xA43424", Offset = "0xA43424", VA = "0xA43424")]
		public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xA434E4", Offset = "0xA434E4", VA = "0xA434E4")]
		public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0xA435A4", Offset = "0xA435A4", VA = "0xA435A4")]
		public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000154")]
	public abstract class I2BasePersistentStorage
	{
		[Token(Token = "0x6000955")]
		[Address(RVA = "0xA43668", Offset = "0xA43668", VA = "0xA43668", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xA43904", Offset = "0xA43904", VA = "0xA43904", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xA43B80", Offset = "0xA43B80", VA = "0xA43B80", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xA43DC0", Offset = "0xA43DC0", VA = "0xA43DC0", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xA43DC8", Offset = "0xA43DC8", VA = "0xA43DC8", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xA43DD4", Offset = "0xA43DD4", VA = "0xA43DD4", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xA43DDC", Offset = "0xA43DDC", VA = "0xA43DDC")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			return null;
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xA43E74", Offset = "0xA43E74", VA = "0xA43E74", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xA44008", Offset = "0xA44008", VA = "0xA44008", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xA44190", Offset = "0xA44190", VA = "0xA44190", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xA4430C", Offset = "0xA4430C", VA = "0xA4430C", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0xA44488", Offset = "0xA44488", VA = "0xA44488")]
		protected I2BasePersistentStorage()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class I2CustomPersistentStorage : I2BasePersistentStorage
	{
		[Token(Token = "0x6000961")]
		[Address(RVA = "0xA43004", Offset = "0xA43004", VA = "0xA43004")]
		public I2CustomPersistentStorage()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class BaseSpecializationManager
	{
		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] mSpecializations;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> mSpecializationsFallbacks;

		[Token(Token = "0x6000962")]
		[Address(RVA = "0xA44490", Offset = "0xA44490", VA = "0xA44490", Slot = "4")]
		public virtual void InitializeSpecializations()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0xA44980", Offset = "0xA44980", VA = "0xA44980", Slot = "5")]
		public virtual string GetCurrentSpecialization()
		{
			return null;
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xA449DC", Offset = "0xA449DC", VA = "0xA449DC", Slot = "6")]
		public virtual string GetFallbackSpecialization(string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xA44A84", Offset = "0xA44A84", VA = "0xA44A84")]
		public BaseSpecializationManager()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public class SpecializationManager : BaseSpecializationManager
	{
		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xA44A8C", Offset = "0xA44A8C", VA = "0xA44A8C")]
		private SpecializationManager()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xA44AB0", Offset = "0xA44AB0", VA = "0xA44AB0")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xA44CA8", Offset = "0xA44CA8", VA = "0xA44CA8")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xA45034", Offset = "0xA45034", VA = "0xA45034")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xA44DC8", Offset = "0xA44DC8", VA = "0xA44DC8")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
			return null;
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xA453F0", Offset = "0xA453F0", VA = "0xA453F0")]
		public static void AppendSpecializations(string text, [Optional] List<string> list)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000158")]
	public class EventCallback
	{
		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonoBehaviour Target;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MethodName;

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xA45690", Offset = "0xA45690", VA = "0xA45690")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xA456F4", Offset = "0xA456F4", VA = "0xA456F4")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xA45778", Offset = "0xA45778", VA = "0xA45778")]
		public EventCallback()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public enum ePluralType
	{
		[Token(Token = "0x40007B2")]
		Zero,
		[Token(Token = "0x40007B3")]
		One,
		[Token(Token = "0x40007B4")]
		Two,
		[Token(Token = "0x40007B5")]
		Few,
		[Token(Token = "0x40007B6")]
		Many,
		[Token(Token = "0x40007B7")]
		Plural
	}
	[Token(Token = "0x200015A")]
	public static class GoogleLanguages
	{
		[Token(Token = "0x200015B")]
		public struct LanguageCodeDef
		{
			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Code;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string GoogleCode;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool HasJoinedWords;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int PluralRule;
		}

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<string, LanguageCodeDef> mLanguageDef;

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xA457D0", Offset = "0xA457D0", VA = "0xA457D0")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xA45BE8", Offset = "0xA45BE8", VA = "0xA45BE8")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xA45A9C", Offset = "0xA45A9C", VA = "0xA45A9C")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default(bool);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xA46168", Offset = "0xA46168", VA = "0xA46168")]
		public static string GetFormatedLanguageName(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xA462B4", Offset = "0xA462B4", VA = "0xA462B4")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xA46384", Offset = "0xA46384", VA = "0xA46384")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xA464E4", Offset = "0xA464E4", VA = "0xA464E4")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
			return null;
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xA466E0", Offset = "0xA466E0", VA = "0xA466E0")]
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xA469E0", Offset = "0xA469E0", VA = "0xA469E0")]
		public static List<string> GetAllInternationalCodes()
		{
			return null;
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xA46C70", Offset = "0xA46C70", VA = "0xA46C70")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			return default(bool);
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xA46E30", Offset = "0xA46E30", VA = "0xA46E30")]
		private static int GetPluralRule(string langCode)
		{
			return default(int);
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xA47010", Offset = "0xA47010", VA = "0xA47010")]
		public static bool LanguageHasPluralType(string langCode, string pluralType)
		{
			return default(bool);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xA471C0", Offset = "0xA471C0", VA = "0xA471C0")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
			return default(ePluralType);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0xA47860", Offset = "0xA47860", VA = "0xA47860")]
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
			return default(int);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xA47848", Offset = "0xA47848", VA = "0xA47848")]
		private static bool inRange(int amount, int min, int max)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200015C")]
	public static class GoogleTranslation
	{
		[Token(Token = "0x200015D")]
		public delegate void fnOnTranslated(string Translation, string Error);

		[Token(Token = "0x200015E")]
		public delegate void fnOnTranslationReady(Dictionary<string, TranslationQuery> dict, string error);

		[Token(Token = "0x2000160")]
		[CompilerGenerated]
		private sealed class <WaitForTranslations>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009A9")]
				[Address(RVA = "0xA50FBC", Offset = "0xA50FBC", VA = "0xA50FBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009AB")]
				[Address(RVA = "0xA51004", Offset = "0xA51004", VA = "0xA51004", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0xA4ED78", Offset = "0xA4ED78", VA = "0xA4ED78")]
			[DebuggerHidden]
			public <WaitForTranslations>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0xA50E34", Offset = "0xA50E34", VA = "0xA50E34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0xA50E38", Offset = "0xA50E38", VA = "0xA50E38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0xA50FC4", Offset = "0xA50FC4", VA = "0xA50FC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<TranslationJob> mTranslationJobs;

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xA4D614", Offset = "0xA4D614", VA = "0xA4D614")]
		public static bool CanTranslate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xA4D84C", Offset = "0xA4D84C", VA = "0xA4D84C")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, fnOnTranslated OnTranslationReady)
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0xA4DF78", Offset = "0xA4DF78", VA = "0xA4DF78")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xA4DEE4", Offset = "0xA4DEE4", VA = "0xA4DEE4")]
		public static void Translate(Dictionary<string, TranslationQuery> requests, fnOnTranslationReady OnTranslationReady, bool usePOST = true)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xA4E678", Offset = "0xA4E678", VA = "0xA4E678")]
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xA4E6F4", Offset = "0xA4E6F4", VA = "0xA4E6F4")]
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
			return null;
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xA4E564", Offset = "0xA4E564", VA = "0xA4E564")]
		private static void AddTranslationJob(TranslationJob job)
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xA4ED18", Offset = "0xA4ED18", VA = "0xA4ED18")]
		[IteratorStateMachine(typeof(<WaitForTranslations>d__11))]
		private static IEnumerator WaitForTranslations()
		{
			return null;
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xA4EDA0", Offset = "0xA4EDA0", VA = "0xA4EDA0")]
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
			return null;
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xA4F4BC", Offset = "0xA4F4BC", VA = "0xA4F4BC")]
		public static bool IsTranslating()
		{
			return default(bool);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xA4F570", Offset = "0xA4F570", VA = "0xA4F570")]
		public static void CancelCurrentGoogleTranslations()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xA4DBD0", Offset = "0xA4DBD0", VA = "0xA4DBD0")]
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xA4F778", Offset = "0xA4F778", VA = "0xA4F778")]
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0xA4E130", Offset = "0xA4E130", VA = "0xA4E130")]
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xA50204", Offset = "0xA50204", VA = "0xA50204")]
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0xA4F23C", Offset = "0xA4F23C", VA = "0xA4F23C")]
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
			return default(TranslationQuery);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0xA4F9C8", Offset = "0xA4F9C8", VA = "0xA4F9C8")]
		public static bool HasParameters(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0xA4FB9C", Offset = "0xA4FB9C", VA = "0xA4FB9C")]
		public static string GetPluralParameter(string text, bool forceTag)
		{
			return null;
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0xA4FA64", Offset = "0xA4FA64", VA = "0xA4FA64")]
		public static string GetPluralText(string text, string pluralType)
		{
			return null;
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0xA50304", Offset = "0xA50304", VA = "0xA50304")]
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0xA4F40C", Offset = "0xA4F40C", VA = "0xA4F40C")]
		private static string GetGoogleNoTranslateTag(int tagNumber)
		{
			return null;
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xA4FC8C", Offset = "0xA4FC8C", VA = "0xA4FC8C")]
		private static void ParseNonTranslatableElements(ref TranslationQuery query)
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xA4E44C", Offset = "0xA4E44C", VA = "0xA4E44C")]
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xA503CC", Offset = "0xA503CC", VA = "0xA503CC")]
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xA506E4", Offset = "0xA506E4", VA = "0xA506E4")]
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xA50A4C", Offset = "0xA50A4C", VA = "0xA50A4C")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xA4EC64", Offset = "0xA4EC64", VA = "0xA4EC64")]
		public static string TitleCase(string s)
		{
			return null;
		}
	}
	[Token(Token = "0x2000161")]
	public struct TranslationQuery
	{
		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OrigText;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Text;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string LanguageCode;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] TargetLanguagesCode;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] Results;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Tags;
	}
	[Token(Token = "0x2000162")]
	public class TranslationJob : IDisposable
	{
		[Token(Token = "0x2000163")]
		public enum eJobState
		{
			[Token(Token = "0x40007CD")]
			Running,
			[Token(Token = "0x40007CE")]
			Succeeded,
			[Token(Token = "0x40007CF")]
			Failed
		}

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public eJobState mJobState;

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xA5100C", Offset = "0xA5100C", VA = "0xA5100C", Slot = "5")]
		public virtual eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xA51014", Offset = "0xA51014", VA = "0xA51014", Slot = "6")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xA51018", Offset = "0xA51018", VA = "0xA51018")]
		public TranslationJob()
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class TranslationJob_WWW : TranslationJob
	{
		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityWebRequest www;

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xA51020", Offset = "0xA51020", VA = "0xA51020", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xA51044", Offset = "0xA51044", VA = "0xA51044")]
		public TranslationJob_WWW()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public class TranslationJob_GET : TranslationJob_WWW
	{
		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> mQueries;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mErrorMessage;

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xA5104C", Offset = "0xA5104C", VA = "0xA5104C")]
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xA510D8", Offset = "0xA510D8", VA = "0xA510D8")]
		private void ExecuteNextQuery()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xA511F8", Offset = "0xA511F8", VA = "0xA511F8", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xA51298", Offset = "0xA51298", VA = "0xA51298")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x2000166")]
	public class TranslationJob_Main : TranslationJob
	{
		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TranslationJob_WEB mWeb;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TranslationJob_POST mPost;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TranslationJob_GET mGet;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mErrorMessage;

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xA4E3C8", Offset = "0xA4E3C8", VA = "0xA4E3C8")]
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xA51518", Offset = "0xA51518", VA = "0xA51518", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xA516D4", Offset = "0xA516D4", VA = "0xA516D4", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class TranslationJob_POST : TranslationJob_WWW
	{
		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xA51398", Offset = "0xA51398", VA = "0xA51398")]
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xA5171C", Offset = "0xA5171C", VA = "0xA5171C", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xA517A8", Offset = "0xA517A8", VA = "0xA517A8")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mErrorMessage;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string mCurrentBatch_ToLanguageCode;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mCurrentBatch_FromLanguageCode;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> mCurrentBatch_Text;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<KeyValuePair<string, string>> mQueries;

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xA51890", Offset = "0xA51890", VA = "0xA51890")]
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xA518C8", Offset = "0xA518C8", VA = "0xA518C8")]
		private void FindAllQueries()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xA51C8C", Offset = "0xA51C8C", VA = "0xA51C8C")]
		private void ExecuteNextBatch()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xA52014", Offset = "0xA52014", VA = "0xA52014", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xA520B4", Offset = "0xA520B4", VA = "0xA520B4")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xA521D0", Offset = "0xA521D0", VA = "0xA521D0")]
		private string ParseTranslationResult(string html, string OriginalText)
		{
			return null;
		}
	}
	[Token(Token = "0x200016A")]
	public enum eLanguageDataFlags
	{
		[Token(Token = "0x40007E9")]
		DISABLED = 1,
		[Token(Token = "0x40007EA")]
		KEEP_LOADED = 2,
		[Token(Token = "0x40007EB")]
		NOT_LOADED = 4
	}
	[Serializable]
	[Token(Token = "0x200016B")]
	public class LanguageData
	{
		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Code;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte Flags;

		[NonSerialized]
		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Compressed;

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xA528A0", Offset = "0xA528A0", VA = "0xA528A0")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xA528B0", Offset = "0xA528B0", VA = "0xA528B0")]
		public void SetEnabled(bool bEnabled)
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xA528CC", Offset = "0xA528CC", VA = "0xA528CC")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xA528DC", Offset = "0xA528DC", VA = "0xA528DC")]
		public bool CanBeUnloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0xA528EC", Offset = "0xA528EC", VA = "0xA528EC")]
		public void SetLoaded(bool loaded)
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0xA52908", Offset = "0xA52908", VA = "0xA52908")]
		public void SetCanBeUnLoaded(bool allowUnloading)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0xA52924", Offset = "0xA52924", VA = "0xA52924")]
		public LanguageData()
		{
		}
	}
	[Token(Token = "0x200016C")]
	[AddComponentMenu("I2/Localization/Source")]
	[ExecuteInEditMode]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		[Token(Token = "0x200016D")]
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int version;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool NeverDestroy;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool GoogleLiveSyncIsUptoDate;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<UnityEngine.Object> Assets;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Google_WebServiceURL;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<TermData> mTerms;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool CaseInsensitiveTerms;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string mTerm_AppName;

		[Token(Token = "0x170000D0")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0xA5292C", Offset = "0xA5292C", VA = "0xA5292C", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0xA52934", Offset = "0xA52934", VA = "0xA52934", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0xA5293C", Offset = "0xA5293C", VA = "0xA5293C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xA529D8", Offset = "0xA529D8", VA = "0xA529D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xA52A74", Offset = "0xA52A74", VA = "0xA52A74")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xA52B04", Offset = "0xA52B04", VA = "0xA52B04")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xA52B78", Offset = "0xA52B78", VA = "0xA52B78")]
		public string GetSourceName()
		{
			return null;
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xA52C68", Offset = "0xA52C68", VA = "0xA52C68", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xA52C74", Offset = "0xA52C74", VA = "0xA52C74", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xA53318", Offset = "0xA53318", VA = "0xA53318")]
		public LanguageSource()
		{
		}
	}
	[Token(Token = "0x200016E")]
	[CreateAssetMenu(fileName = "I2Languages", menuName = "I2 Localization/LanguageSource", order = 1)]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x170000D1")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0xA53628", Offset = "0xA53628", VA = "0xA53628", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xA53630", Offset = "0xA53630", VA = "0xA53630", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xA53638", Offset = "0xA53638", VA = "0xA53638")]
		public LanguageSourceAsset()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public interface ILanguageSource
	{
		[Token(Token = "0x170000D2")]
		LanguageSourceData SourceData
		{
			[Token(Token = "0x60009DE")]
			get;
			[Token(Token = "0x60009DF")]
			set;
		}
	}
	[Serializable]
	[Token(Token = "0x2000170")]
	[ExecuteInEditMode]
	public class LanguageSourceData
	{
		[Token(Token = "0x2000171")]
		public enum MissingTranslationAction
		{
			[Token(Token = "0x4000822")]
			Empty,
			[Token(Token = "0x4000823")]
			Fallback,
			[Token(Token = "0x4000824")]
			ShowWarning,
			[Token(Token = "0x4000825")]
			ShowTerm
		}

		[Token(Token = "0x2000172")]
		public enum eAllowUnloadLanguages
		{
			[Token(Token = "0x4000827")]
			Never,
			[Token(Token = "0x4000828")]
			OnlyInDevice,
			[Token(Token = "0x4000829")]
			EditorAndDevice
		}

		[Token(Token = "0x2000173")]
		public enum eGoogleUpdateFrequency
		{
			[Token(Token = "0x400082B")]
			Always,
			[Token(Token = "0x400082C")]
			Never,
			[Token(Token = "0x400082D")]
			Daily,
			[Token(Token = "0x400082E")]
			Weekly,
			[Token(Token = "0x400082F")]
			Monthly,
			[Token(Token = "0x4000830")]
			OnlyOnce,
			[Token(Token = "0x4000831")]
			EveryOtherDay
		}

		[Token(Token = "0x2000174")]
		public enum eGoogleUpdateSynchronization
		{
			[Token(Token = "0x4000833")]
			Manual,
			[Token(Token = "0x4000834")]
			OnSceneLoaded,
			[Token(Token = "0x4000835")]
			AsSoonAsDownloaded
		}

		[Token(Token = "0x2000176")]
		[CompilerGenerated]
		private sealed class <Import_Google_Coroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LanguageSourceData <>4__this;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool forceUpdate;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool JustCheck;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A3A")]
				[Address(RVA = "0xA5BE34", Offset = "0xA5BE34", VA = "0xA5BE34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A3C")]
				[Address(RVA = "0xA5BE7C", Offset = "0xA5BE7C", VA = "0xA5BE7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0xA5957C", Offset = "0xA5957C", VA = "0xA5957C")]
			[DebuggerHidden]
			public <Import_Google_Coroutine>d__65(int <>1__state)
			{
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0xA5BB70", Offset = "0xA5BB70", VA = "0xA5BB70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0xA5BB74", Offset = "0xA5BB74", VA = "0xA5BB74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0xA5BE3C", Offset = "0xA5BE3C", VA = "0xA5BE3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILanguageSource owner;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GoogleLiveSyncIsUptoDate;

		[NonSerialized]
		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool mIsGlobalSource;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TermData> mTerms;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool CaseInsensitiveTerms;

		[NonSerialized]
		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, TermData> mDictionary;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mTerm_AppName;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Google_WebServiceURL;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<UnityEngine.Object> Assets;

		[NonSerialized]
		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string mDelayedGoogleData;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static char[] CategorySeparators;

		[Token(Token = "0x170000D3")]
		public UnityEngine.Object ownerObject
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0xA5369C", Offset = "0xA5369C", VA = "0xA5369C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000020")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0xA5327C", Offset = "0xA5327C", VA = "0xA5327C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0xA53718", Offset = "0xA53718", VA = "0xA53718")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xA52A94", Offset = "0xA52A94", VA = "0xA52A94")]
		public void Awake()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xA52B24", Offset = "0xA52B24", VA = "0xA52B24")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xA54238", Offset = "0xA54238", VA = "0xA54238")]
		public bool IsEqualTo(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xA547A0", Offset = "0xA547A0", VA = "0xA547A0")]
		internal bool ManagerHasASimilarSource()
		{
			return default(bool);
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xA548A8", Offset = "0xA548A8", VA = "0xA548A8")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xA5498C", Offset = "0xA5498C", VA = "0xA5498C")]
		public bool IsGlobalSource()
		{
			return default(bool);
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xA54994", Offset = "0xA54994", VA = "0xA54994")]
		public void Editor_SetDirty()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xA53D00", Offset = "0xA53D00", VA = "0xA53D00")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xA54998", Offset = "0xA54998", VA = "0xA54998")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xA54A6C", Offset = "0xA54A6C", VA = "0xA54A6C")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xA54AC4", Offset = "0xA54AC4", VA = "0xA54AC4")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xA54BA4", Offset = "0xA54BA4", VA = "0xA54BA4")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xA550C8", Offset = "0xA550C8", VA = "0xA550C8")]
		public string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xA557F0", Offset = "0xA557F0", VA = "0xA557F0")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xA55A4C", Offset = "0xA55A4C", VA = "0xA55A4C")]
		private static void AppendI2Text(StringBuilder Builder, string text)
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xA55B20", Offset = "0xA55B20", VA = "0xA55B20")]
		public string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xA56468", Offset = "0xA56468", VA = "0xA56468")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xA56304", Offset = "0xA56304", VA = "0xA56304")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xA566C8", Offset = "0xA566C8", VA = "0xA566C8")]
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xA56844", Offset = "0xA56844", VA = "0xA56844")]
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xA56A08", Offset = "0xA56A08", VA = "0xA56A08")]
		private string Export_Google_CreateData()
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xA56EDC", Offset = "0xA56EDC", VA = "0xA56EDC")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xA57BDC", Offset = "0xA57BDC", VA = "0xA57BDC")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xA5703C", Offset = "0xA5703C", VA = "0xA5703C")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xA57E24", Offset = "0xA57E24", VA = "0xA57E24")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default(bool);
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xA5819C", Offset = "0xA5819C", VA = "0xA5819C")]
		public static eTermType GetTermType(string type)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xA583E4", Offset = "0xA583E4", VA = "0xA583E4")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xA58614", Offset = "0xA58614", VA = "0xA58614")]
		public static void FreeUnusedLanguages()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xA587B8", Offset = "0xA587B8", VA = "0xA587B8")]
		public void Import_Google_FromCache()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xA58BCC", Offset = "0xA58BCC", VA = "0xA58BCC")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xA59278", Offset = "0xA59278", VA = "0xA59278")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xA58A0C", Offset = "0xA58A0C", VA = "0xA58A0C")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xA594F4", Offset = "0xA594F4", VA = "0xA594F4")]
		[IteratorStateMachine(typeof(<Import_Google_Coroutine>d__65))]
		private IEnumerator Import_Google_Coroutine(bool forceUpdate, bool JustCheck)
		{
			return null;
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0xA595A4", Offset = "0xA595A4", VA = "0xA595A4")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xA59650", Offset = "0xA59650", VA = "0xA59650")]
		public void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xA597B0", Offset = "0xA597B0", VA = "0xA597B0")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xA59918", Offset = "0xA59918", VA = "0xA59918")]
		public bool HasGoogleSpreadsheet()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xA58C5C", Offset = "0xA58C5C", VA = "0xA58C5C")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xA54398", Offset = "0xA54398", VA = "0xA54398")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return default(int);
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xA59B6C", Offset = "0xA59B6C", VA = "0xA59B6C")]
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
			return null;
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xA59BFC", Offset = "0xA59BFC", VA = "0xA59BFC")]
		public bool IsCurrentLanguage(int languageIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xA57EB4", Offset = "0xA57EB4", VA = "0xA57EB4")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xA599B0", Offset = "0xA599B0", VA = "0xA599B0")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return default(int);
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xA59CA0", Offset = "0xA59CA0", VA = "0xA59CA0")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0xA59D2C", Offset = "0xA59D2C", VA = "0xA59D2C")]
		public static string GetLanguageWithoutRegion(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xA59DC4", Offset = "0xA59DC4", VA = "0xA59DC4")]
		public void AddLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xA59E3C", Offset = "0xA59E3C", VA = "0xA59E3C")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xA5A010", Offset = "0xA5A010", VA = "0xA5A010")]
		public void RemoveLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xA5A2D8", Offset = "0xA5A2D8", VA = "0xA5A2D8")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xA5A44C", Offset = "0xA5A44C", VA = "0xA5A44C")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xA5A63C", Offset = "0xA5A63C", VA = "0xA5A63C")]
		public bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xA5A6C8", Offset = "0xA5A6C8", VA = "0xA5A6C8")]
		public void EnableLanguage(string Language, bool bEnabled)
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xA5A764", Offset = "0xA5A764", VA = "0xA5A764")]
		public bool AllowUnloadingLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xA5A774", Offset = "0xA5A774", VA = "0xA5A774")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xA5A950", Offset = "0xA5A950", VA = "0xA5A950")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xA5AD10", Offset = "0xA5AD10", VA = "0xA5AD10")]
		public void LoadAllLanguages(bool forceLoad = false)
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xA5AAB4", Offset = "0xA5AAB4", VA = "0xA5AAB4")]
		public void UnloadLanguage(int languageIndex)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xA582CC", Offset = "0xA582CC", VA = "0xA582CC")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xA58234", Offset = "0xA58234", VA = "0xA58234")]
		public bool HasUnloadedLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xA56C1C", Offset = "0xA56C1C", VA = "0xA56C1C")]
		public List<string> GetCategories(bool OnlyMainCategory = false, [Optional] List<string> Categories)
		{
			return null;
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xA5AE5C", Offset = "0xA5AE5C", VA = "0xA5AE5C")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xA5AD94", Offset = "0xA5AD94", VA = "0xA5AD94")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xA5AF08", Offset = "0xA5AF08", VA = "0xA5AF08")]
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xA53A08", Offset = "0xA53A08", VA = "0xA53A08")]
		public void UpdateDictionary(bool force = false)
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xA5AFFC", Offset = "0xA5AFFC", VA = "0xA5AFFC")]
		public string GetTranslation(string term, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xA5B030", Offset = "0xA5B030", VA = "0xA5B030")]
		public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xA54E54", Offset = "0xA54E54", VA = "0xA54E54")]
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xA5B320", Offset = "0xA5B320", VA = "0xA5B320")]
		public TermData AddTerm(string term)
		{
			return null;
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xA54548", Offset = "0xA54548", VA = "0xA54548")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xA5B548", Offset = "0xA5B548", VA = "0xA5B548")]
		public bool ContainsTerm(string term)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xA5B564", Offset = "0xA5B564", VA = "0xA5B564")]
		public List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xA5B32C", Offset = "0xA5B32C", VA = "0xA5B32C")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xA5B7B0", Offset = "0xA5B7B0", VA = "0xA5B7B0")]
		public void RemoveTerm(string term)
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xA58028", Offset = "0xA58028", VA = "0xA58028")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xA53020", Offset = "0xA53020", VA = "0xA53020")]
		public LanguageSourceData()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public enum eSpreadsheetUpdateMode
	{
		[Token(Token = "0x4000844")]
		None,
		[Token(Token = "0x4000845")]
		Replace,
		[Token(Token = "0x4000846")]
		Merge,
		[Token(Token = "0x4000847")]
		AddNewTerms
	}
	[Token(Token = "0x2000178")]
	public class LocalizationReader
	{
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xA5BE84", Offset = "0xA5BE84", VA = "0xA5BE84")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			return null;
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xA5C104", Offset = "0xA5C104", VA = "0xA5C104")]
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xA5C4E4", Offset = "0xA5C4E4", VA = "0xA5C4E4")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xA56F18", Offset = "0xA56F18", VA = "0xA56F18")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xA5C708", Offset = "0xA5C708", VA = "0xA5C708")]
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
		{
			return null;
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xA5C8F4", Offset = "0xA5C8F4", VA = "0xA5C8F4")]
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xA57C14", Offset = "0xA57C14", VA = "0xA57C14")]
		public static List<string[]> ReadI2CSV(string Text)
		{
			return null;
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xA5C458", Offset = "0xA5C458", VA = "0xA5C458")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xA5CA78", Offset = "0xA5CA78", VA = "0xA5CA78")]
		public static string EncodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xA5C3B0", Offset = "0xA5C3B0", VA = "0xA5C3B0")]
		public static string DecodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xA5CB70", Offset = "0xA5CB70", VA = "0xA5CB70")]
		public LocalizationReader()
		{
		}
	}
	[Token(Token = "0x2000179")]
	[AddComponentMenu("I2/Localization/I2 Localize")]
	public class Localize : MonoBehaviour
	{
		[Token(Token = "0x200017A")]
		public enum TermModification
		{
			[Token(Token = "0x4000869")]
			DontModify,
			[Token(Token = "0x400086A")]
			ToUpper,
			[Token(Token = "0x400086B")]
			ToLower,
			[Token(Token = "0x400086C")]
			ToUpperFirst,
			[Token(Token = "0x400086D")]
			ToTitle
		}

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mTerm;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mTermSecondary;

		[NonSerialized]
		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string FinalTerm;

		[NonSerialized]
		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string FinalSecondaryTerm;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TermModification PrimaryTermModifier;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public TermModification SecondaryTermModifier;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string TermPrefix;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string TermSuffix;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool LocalizeOnAwake;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string LastLocalizedLanguage;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool IgnoreRTL;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int MaxCharactersInRTL;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreNumbersInRTL;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool CorrectAlignmentForRTL;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool AddSpacesToJoinedLanguages;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool AllowLocalizedParameters;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool AllowParameters;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<UnityEngine.Object> TranslatedObjects;

		[NonSerialized]
		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent LocalizeEvent;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string SecondaryTranslation;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string CallBackTerm;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string CallBackSecondaryTerm;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Localize CurrentLocalizeComponent;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool AlwaysForceLocalize;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool mGUI_ShowReferences;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool mGUI_ShowTems;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		public bool mGUI_ShowCallback;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public ILocalizeTarget mLocalizeTarget;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string mLocalizeTargetName;

		[Token(Token = "0x170000D6")]
		public string Term
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0xA5CB78", Offset = "0xA5CB78", VA = "0xA5CB78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0xA5CB80", Offset = "0xA5CB80", VA = "0xA5CB80")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public string SecondaryTerm
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0xA5CBC0", Offset = "0xA5CBC0", VA = "0xA5CBC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0xA5CBC8", Offset = "0xA5CBC8", VA = "0xA5CBC8")]
			set
			{
			}
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xA5CC1C", Offset = "0xA5CC1C", VA = "0xA5CC1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xA5DC28", Offset = "0xA5DC28", VA = "0xA5DC28")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xA5DC30", Offset = "0xA5DC30", VA = "0xA5DC30")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xA5D400", Offset = "0xA5D400", VA = "0xA5D400")]
		public void OnLocalize(bool Force = false)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xA5CF8C", Offset = "0xA5CF8C", VA = "0xA5CF8C")]
		public bool FindTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xA5DC78", Offset = "0xA5DC78", VA = "0xA5DC78")]
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xA5E434", Offset = "0xA5E434", VA = "0xA5E434")]
		public string GetMainTargetsText()
		{
			return null;
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xA5E4FC", Offset = "0xA5E4FC", VA = "0xA5E4FC")]
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xA5CB84", Offset = "0xA5CB84", VA = "0xA5CB84")]
		public void SetTerm(string primary)
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xA5CBD4", Offset = "0xA5CBD4", VA = "0xA5CBD4")]
		public void SetTerm(string primary, string secondary)
		{
		}

		[Token(Token = "0x6000A56")]
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xA5CC50", Offset = "0xA5CC50", VA = "0xA5CC50")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x6000A58")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000A59")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xA5E538", Offset = "0xA5E538", VA = "0xA5E538")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
		}

		[Token(Token = "0x6000A5B")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xA5E624", Offset = "0xA5E624", VA = "0xA5E624")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xA5E6A8", Offset = "0xA5E6A8", VA = "0xA5E6A8")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0xA5E788", Offset = "0xA5E788", VA = "0xA5E788")]
		public void SetGlobalLanguage(string Language)
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xA5E8AC", Offset = "0xA5E8AC", VA = "0xA5E8AC")]
		public Localize()
		{
		}
	}
	[Token(Token = "0x200017C")]
	[AddComponentMenu("I2/Localization/Localize Dropdown")]
	public class LocalizeDropdown : MonoBehaviour
	{
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> _Terms;

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xA5EC3C", Offset = "0xA5EC3C", VA = "0xA5EC3C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xA5EF40", Offset = "0xA5EF40", VA = "0xA5EF40")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xA5F0B8", Offset = "0xA5F0B8", VA = "0xA5F0B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xA5EE54", Offset = "0xA5EE54", VA = "0xA5EE54")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xA5F110", Offset = "0xA5F110", VA = "0xA5F110")]
		private void FillValues()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xA5F36C", Offset = "0xA5F36C", VA = "0xA5F36C")]
		public void UpdateLocalization()
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xA5F8D8", Offset = "0xA5F8D8", VA = "0xA5F8D8")]
		public void UpdateLocalizationTMPro()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xA5F694", Offset = "0xA5F694", VA = "0xA5F694")]
		private void FillValuesTMPro()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xA5FBF4", Offset = "0xA5FBF4", VA = "0xA5FBF4")]
		public LocalizeDropdown()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public static class LocalizationManager
	{
		[Token(Token = "0x200017E")]
		public delegate bool FnCustomApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters);

		[Token(Token = "0x200017F")]
		public delegate object _GetParam(string param);

		[Token(Token = "0x2000180")]
		public delegate void OnLocalizeCallback();

		[Token(Token = "0x2000186")]
		[CompilerGenerated]
		private sealed class <Delayed_Import_Google>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LanguageSourceData source;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool justCheck;

			[Token(Token = "0x170000DD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ACE")]
				[Address(RVA = "0xA6631C", Offset = "0xA6631C", VA = "0xA6631C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AD0")]
				[Address(RVA = "0xA66364", Offset = "0xA66364", VA = "0xA66364", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0xA66238", Offset = "0xA66238", VA = "0xA66238")]
			[DebuggerHidden]
			public <Delayed_Import_Google>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0xA66260", Offset = "0xA66260", VA = "0xA66260", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0xA66264", Offset = "0xA66264", VA = "0xA66264", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0xA66324", Offset = "0xA66324", VA = "0xA66324", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000188")]
		[CompilerGenerated]
		private sealed class <Coroutine_LocalizeAll>d__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000DF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AD6")]
				[Address(RVA = "0xA66480", Offset = "0xA66480", VA = "0xA66480", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AD8")]
				[Address(RVA = "0xA664C8", Offset = "0xA664C8", VA = "0xA664C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0xA6639C", Offset = "0xA6639C", VA = "0xA6639C")]
			[DebuggerHidden]
			public <Coroutine_LocalizeAll>d__88(int <>1__state)
			{
			}

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0xA663C4", Offset = "0xA663C4", VA = "0xA663C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0xA663C8", Offset = "0xA663C8", VA = "0xA663C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0xA66488", Offset = "0xA66488", VA = "0xA66488", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string mLanguageCode;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CultureInfo mCurrentCulture;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool mChangeCultureInfo;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public static bool IsRight2Left;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public static bool HasJoinedWords;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static List<ILocalizationParamsManager> ParamManagers;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static FnCustomApplyLocalizationParams CustomApplyLocalizationParams;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string[] LanguagesRTL;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static List<LanguageSourceData> Sources;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] GlobalSources;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Func<LanguageSourceData, bool> Callback_AllowSyncFromGoogle;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static string mCurrentDeviceLanguage;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static bool mLocalizeIsScheduled;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public static bool HighlightLocalizedTargets;

		[Token(Token = "0x170000D8")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0xA5875C", Offset = "0xA5875C", VA = "0xA5875C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0xA5E7DC", Offset = "0xA5E7DC", VA = "0xA5E7DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0xA609C8", Offset = "0xA609C8", VA = "0xA609C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0xA60A24", Offset = "0xA60A24", VA = "0xA60A24")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public static string CurrentRegion
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0xA60CB4", Offset = "0xA60CB4", VA = "0xA60CB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0xA60E28", Offset = "0xA60E28", VA = "0xA60E28")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0xA60FE8", Offset = "0xA60FE8", VA = "0xA60FE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0xA610B8", Offset = "0xA610B8", VA = "0xA610B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0xA611BC", Offset = "0xA611BC", VA = "0xA611BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000021")]
		public static event OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0xA5ED78", Offset = "0xA5ED78", VA = "0xA5ED78")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0xA5EFDC", Offset = "0xA5EFDC", VA = "0xA5EFDC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xA4DB0C", Offset = "0xA4DB0C", VA = "0xA4DB0C")]
		public static void InitializeIfNeeded()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xA6029C", Offset = "0xA6029C", VA = "0xA6029C")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xA599A8", Offset = "0xA599A8", VA = "0xA599A8")]
		public static int GetRequiredWebServiceVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xA4D6B8", Offset = "0xA4D6B8", VA = "0xA4D6B8")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
			return null;
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0xA607F0", Offset = "0xA607F0", VA = "0xA607F0")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0xA61214", Offset = "0xA61214", VA = "0xA61214")]
		private static CultureInfo CreateCultureForCode(string code)
		{
			return null;
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xA61404", Offset = "0xA61404", VA = "0xA61404")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xA61308", Offset = "0xA61308", VA = "0xA61308")]
		private static void SetCurrentCultureInfo()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0xA5FEC8", Offset = "0xA5FEC8", VA = "0xA5FEC8")]
		private static void SelectStartupLanguage()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0xA61534", Offset = "0xA61534", VA = "0xA61534")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0xA602DC", Offset = "0xA602DC", VA = "0xA602DC")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			return null;
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0xA60638", Offset = "0xA60638", VA = "0xA60638")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0xA60AEC", Offset = "0xA60AEC", VA = "0xA60AEC")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			return null;
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0xA616EC", Offset = "0xA616EC", VA = "0xA616EC")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0xA6194C", Offset = "0xA6194C", VA = "0xA6194C")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0xA61B80", Offset = "0xA61B80", VA = "0xA61B80")]
		public static bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xA61C74", Offset = "0xA61C74", VA = "0xA61C74")]
		private static void LoadCurrentLanguage()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0xA61D9C", Offset = "0xA61D9C", VA = "0xA61D9C")]
		public static void PreviewLanguage(string NewLanguage)
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0xA5FC70", Offset = "0xA5FC70", VA = "0xA5FC70")]
		public static void AutoLoadGlobalParamManagers()
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0xA61E6C", Offset = "0xA61E6C", VA = "0xA61E6C")]
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0xA5DE88", Offset = "0xA5DE88", VA = "0xA5DE88")]
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0xA62498", Offset = "0xA62498", VA = "0xA62498")]
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0xA62018", Offset = "0xA62018", VA = "0xA62018")]
		public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0xA626C4", Offset = "0xA626C4", VA = "0xA626C4")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
			return null;
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0xA62954", Offset = "0xA62954", VA = "0xA62954")]
		private static string GetPluralType(MatchCollection matches, string langCode, _GetParam getParam)
		{
			return null;
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0xA5E3D8", Offset = "0xA5E3D8", VA = "0xA5E3D8")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xA5DF6C", Offset = "0xA5DF6C", VA = "0xA5DF6C")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0xA62B18", Offset = "0xA62B18", VA = "0xA62B18")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			return null;
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0xA61380", Offset = "0xA61380", VA = "0xA61380")]
		public static bool IsRTL(string Code)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0xA5FE44", Offset = "0xA5FE44", VA = "0xA5FE44")]
		public static bool UpdateSources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xA62BB4", Offset = "0xA62BB4", VA = "0xA62BB4")]
		private static void UnregisterDeletededSources()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xA62E58", Offset = "0xA62E58", VA = "0xA62E58")]
		private static void RegisterSceneSources()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xA62CBC", Offset = "0xA62CBC", VA = "0xA62CBC")]
		private static void RegisterSourceInResources()
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xA62FDC", Offset = "0xA62FDC", VA = "0xA62FDC")]
		private static bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xA537B4", Offset = "0xA537B4", VA = "0xA537B4")]
		internal static void AddSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xA6307C", Offset = "0xA6307C", VA = "0xA6307C")]
		[IteratorStateMachine(typeof(<Delayed_Import_Google>d__63))]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xA541B8", Offset = "0xA541B8", VA = "0xA541B8")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0xA63108", Offset = "0xA63108", VA = "0xA63108")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0xA6318C", Offset = "0xA6318C", VA = "0xA6318C")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0xA63330", Offset = "0xA63330", VA = "0xA63330")]
		public static UnityEngine.Object FindAsset(string value)
		{
			return null;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0xA63460", Offset = "0xA63460", VA = "0xA63460")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xA61498", Offset = "0xA61498", VA = "0xA61498")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
			return null;
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xA6353C", Offset = "0xA6353C", VA = "0xA6353C")]
		private static void DetectDeviceLanguage()
		{
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0xA63974", Offset = "0xA63974", VA = "0xA63974")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xA5DDC4", Offset = "0xA5DDC4", VA = "0xA5DDC4")]
		public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return null;
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xA63DDC", Offset = "0xA63DDC", VA = "0xA63DDC")]
		public static string GetTermTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return null;
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xA63C00", Offset = "0xA63C00", VA = "0xA63C00")]
		public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA9")]
		public static T GetTranslatedObject<T>(string AssetName, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000AAA")]
		public static T GetTranslatedObjectByTermName<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xA63E88", Offset = "0xA63E88", VA = "0xA63E88")]
		public static string GetAppName(string languageCode)
		{
			return null;
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xA540EC", Offset = "0xA540EC", VA = "0xA540EC")]
		public static void LocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xA641F0", Offset = "0xA641F0", VA = "0xA641F0")]
		[IteratorStateMachine(typeof(<Coroutine_LocalizeAll>d__88))]
		private static IEnumerator Coroutine_LocalizeAll()
		{
			return null;
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0xA64078", Offset = "0xA64078", VA = "0xA64078")]
		private static void DoLocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0xA64250", Offset = "0xA64250", VA = "0xA64250")]
		public static List<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xA64378", Offset = "0xA64378", VA = "0xA64378")]
		public static List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xA645BC", Offset = "0xA645BC", VA = "0xA645BC")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0xA62584", Offset = "0xA62584", VA = "0xA62584")]
		public static TermData GetTermData(string term, out LanguageSourceData source)
		{
			return null;
		}
	}
	[Token(Token = "0x2000189")]
	public abstract class ILocalizeTarget : ScriptableObject
	{
		[Token(Token = "0x6000AD9")]
		public abstract bool IsValid(Localize cmp);

		[Token(Token = "0x6000ADA")]
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		[Token(Token = "0x6000ADB")]
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		[Token(Token = "0x6000ADC")]
		public abstract bool CanUseSecondaryTerm();

		[Token(Token = "0x6000ADD")]
		public abstract bool AllowMainTermToBeRTL();

		[Token(Token = "0x6000ADE")]
		public abstract bool AllowSecondTermToBeRTL();

		[Token(Token = "0x6000ADF")]
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		[Token(Token = "0x6000AE0")]
		public abstract eTermType GetSecondaryTermType(Localize cmp);

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0xA664D0", Offset = "0xA664D0", VA = "0xA664D0")]
		protected ILocalizeTarget()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : UnityEngine.Object
	{
		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T mTarget;

		[Token(Token = "0x6000AE2")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE3")]
		protected LocalizeTarget()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public abstract class ILocalizeTargetDescriptor
	{
		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x6000AE4")]
		public abstract bool CanLocalize(Localize cmp);

		[Token(Token = "0x6000AE5")]
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		[Token(Token = "0x6000AE6")]
		public abstract Type GetTargetType();

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0xA664D8", Offset = "0xA664D8", VA = "0xA664D8")]
		protected ILocalizeTargetDescriptor()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		[Token(Token = "0x6000AE8")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6000AE9")]
		public override Type GetTargetType()
		{
			return null;
		}

		[Token(Token = "0x6000AEA")]
		protected LocalizeTargetDesc()
		{
		}
	}
	[Token(Token = "0x200018D")]
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : UnityEngine.Object where G : LocalizeTarget<T>
	{
		[Token(Token = "0x6000AEB")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AEC")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6000AED")]
		public LocalizeTargetDesc_Type()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0xA664E0", Offset = "0xA664E0", VA = "0xA664E0")]
		static LocalizeTarget_TextMeshPro_Label()
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0xA664E4", Offset = "0xA664E4", VA = "0xA664E4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0xA665A0", Offset = "0xA665A0", VA = "0xA665A0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0xA665A8", Offset = "0xA665A8", VA = "0xA665A8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0xA665B0", Offset = "0xA665B0", VA = "0xA665B0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0xA665B8", Offset = "0xA665B8", VA = "0xA665B8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0xA665C0", Offset = "0xA665C0", VA = "0xA665C0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0xA665C8", Offset = "0xA665C8", VA = "0xA665C8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0xA666D4", Offset = "0xA666D4", VA = "0xA666D4", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0xA66C60", Offset = "0xA66C60", VA = "0xA66C60")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			return null;
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0xA66EC8", Offset = "0xA66EC8", VA = "0xA66EC8")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0xA66B80", Offset = "0xA66B80", VA = "0xA66B80")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0xA66DC8", Offset = "0xA66DC8", VA = "0xA66DC8")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0xA67240", Offset = "0xA67240", VA = "0xA67240")]
		public LocalizeTarget_TextMeshPro_Label()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool mAlignmentWasRTL;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool mInitializeAlignment;

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0xA6729C", Offset = "0xA6729C", VA = "0xA6729C")]
		static LocalizeTarget_TextMeshPro_UGUI()
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0xA672A0", Offset = "0xA672A0", VA = "0xA672A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0xA6735C", Offset = "0xA6735C", VA = "0xA6735C", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0xA67364", Offset = "0xA67364", VA = "0xA67364", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0xA6736C", Offset = "0xA6736C", VA = "0xA6736C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0xA67374", Offset = "0xA67374", VA = "0xA67374", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0xA6737C", Offset = "0xA6737C", VA = "0xA6737C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0xA67384", Offset = "0xA67384", VA = "0xA67384", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0xA67490", Offset = "0xA67490", VA = "0xA67490", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0xA6793C", Offset = "0xA6793C", VA = "0xA6793C")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0xA67998", Offset = "0xA67998", VA = "0xA67998")]
		static LocalizeTarget_UnityStandard_AudioSource()
		{
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0xA6799C", Offset = "0xA6799C", VA = "0xA6799C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0xA67A58", Offset = "0xA67A58", VA = "0xA67A58", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0xA67A60", Offset = "0xA67A60", VA = "0xA67A60", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0xA67A68", Offset = "0xA67A68", VA = "0xA67A68", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0xA67A70", Offset = "0xA67A70", VA = "0xA67A70", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0xA67A78", Offset = "0xA67A78", VA = "0xA67A78", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0xA67A80", Offset = "0xA67A80", VA = "0xA67A80", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0xA67B48", Offset = "0xA67B48", VA = "0xA67B48", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0xA67CB8", Offset = "0xA67CB8", VA = "0xA67CB8")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
	{
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0xA67D00", Offset = "0xA67D00", VA = "0xA67D00", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0xA67D34", Offset = "0xA67D34", VA = "0xA67D34")]
		public LocalizeTargetDesc_Child()
		{
		}
	}
	[Token(Token = "0x2000192")]
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0xA67D7C", Offset = "0xA67D7C", VA = "0xA67D7C")]
		static LocalizeTarget_UnityStandard_Child()
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0xA67D80", Offset = "0xA67D80", VA = "0xA67D80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0xA67E24", Offset = "0xA67E24", VA = "0xA67E24", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0xA67E58", Offset = "0xA67E58", VA = "0xA67E58", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0xA67E60", Offset = "0xA67E60", VA = "0xA67E60", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0xA67E68", Offset = "0xA67E68", VA = "0xA67E68", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0xA67E70", Offset = "0xA67E70", VA = "0xA67E70", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0xA67E78", Offset = "0xA67E78", VA = "0xA67E78", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0xA67E80", Offset = "0xA67E80", VA = "0xA67E80", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0xA67EB8", Offset = "0xA67EB8", VA = "0xA67EB8", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0xA67FF8", Offset = "0xA67FF8", VA = "0xA67FF8")]
		public LocalizeTarget_UnityStandard_Child()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0xA68040", Offset = "0xA68040", VA = "0xA68040")]
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0xA68044", Offset = "0xA68044", VA = "0xA68044")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0xA68100", Offset = "0xA68100", VA = "0xA68100", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xA68108", Offset = "0xA68108", VA = "0xA68108", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xA68110", Offset = "0xA68110", VA = "0xA68110", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0xA68118", Offset = "0xA68118", VA = "0xA68118", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xA68120", Offset = "0xA68120", VA = "0xA68120", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xA68128", Offset = "0xA68128", VA = "0xA68128", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0xA68304", Offset = "0xA68304", VA = "0xA68304", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xA684D0", Offset = "0xA684D0", VA = "0xA684D0")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}
	}
	[Token(Token = "0x2000194")]
	public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
	{
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0xA68518", Offset = "0xA68518", VA = "0xA68518", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0xA68520", Offset = "0xA68520", VA = "0xA68520")]
		public LocalizeTargetDesc_Prefab()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0xA68568", Offset = "0xA68568", VA = "0xA68568")]
		static LocalizeTarget_UnityStandard_Prefab()
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0xA6856C", Offset = "0xA6856C", VA = "0xA6856C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0xA68610", Offset = "0xA68610", VA = "0xA68610", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0xA68618", Offset = "0xA68618", VA = "0xA68618", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0xA68620", Offset = "0xA68620", VA = "0xA68620", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0xA68628", Offset = "0xA68628", VA = "0xA68628", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0xA68630", Offset = "0xA68630", VA = "0xA68630", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0xA68638", Offset = "0xA68638", VA = "0xA68638", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0xA68640", Offset = "0xA68640", VA = "0xA68640", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0xA68678", Offset = "0xA68678", VA = "0xA68678", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0xA6887C", Offset = "0xA6887C", VA = "0xA6887C")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			return null;
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0xA68A20", Offset = "0xA68A20", VA = "0xA68A20")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0xA68A68", Offset = "0xA68A68", VA = "0xA68A68")]
		static LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0xA68A6C", Offset = "0xA68A6C", VA = "0xA68A6C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0xA68B28", Offset = "0xA68B28", VA = "0xA68B28", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0xA68B30", Offset = "0xA68B30", VA = "0xA68B30", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0xA68B38", Offset = "0xA68B38", VA = "0xA68B38", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0xA68B40", Offset = "0xA68B40", VA = "0xA68B40", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0xA68B48", Offset = "0xA68B48", VA = "0xA68B48", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0xA68B50", Offset = "0xA68B50", VA = "0xA68B50", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0xA68C1C", Offset = "0xA68C1C", VA = "0xA68C1C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0xA68D18", Offset = "0xA68D18", VA = "0xA68D18")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}
	}
	[Token(Token = "0x2000197")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignment mAlignment_RTL;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignment mAlignment_LTR;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0xA68D60", Offset = "0xA68D60", VA = "0xA68D60")]
		static LocalizeTarget_UnityStandard_TextMesh()
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0xA68D64", Offset = "0xA68D64", VA = "0xA68D64")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0xA68E20", Offset = "0xA68E20", VA = "0xA68E20", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0xA68E28", Offset = "0xA68E28", VA = "0xA68E28", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0xA68E30", Offset = "0xA68E30", VA = "0xA68E30", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0xA68E38", Offset = "0xA68E38", VA = "0xA68E38", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0xA68E40", Offset = "0xA68E40", VA = "0xA68E40", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0xA68E48", Offset = "0xA68E48", VA = "0xA68E48", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0xA68F64", Offset = "0xA68F64", VA = "0xA68F64", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0xA6920C", Offset = "0xA6920C", VA = "0xA6920C")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class LocalizeTarget_UnityStandard_VideoPlayer : LocalizeTarget<VideoPlayer>
	{
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0xA69264", Offset = "0xA69264", VA = "0xA69264")]
		static LocalizeTarget_UnityStandard_VideoPlayer()
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0xA69268", Offset = "0xA69268", VA = "0xA69268")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0xA69324", Offset = "0xA69324", VA = "0xA69324", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0xA6932C", Offset = "0xA6932C", VA = "0xA6932C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0xA69334", Offset = "0xA69334", VA = "0xA69334", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0xA6933C", Offset = "0xA6933C", VA = "0xA6933C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0xA69344", Offset = "0xA69344", VA = "0xA69344", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0xA6934C", Offset = "0xA6934C", VA = "0xA6934C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0xA69418", Offset = "0xA69418", VA = "0xA69418", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0xA69514", Offset = "0xA69514", VA = "0xA69514")]
		public LocalizeTarget_UnityStandard_VideoPlayer()
		{
		}
	}
	[Token(Token = "0x2000199")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0xA6955C", Offset = "0xA6955C", VA = "0xA6955C")]
		static LocalizeTarget_UnityUI_Image()
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0xA69560", Offset = "0xA69560", VA = "0xA69560")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0xA6961C", Offset = "0xA6961C", VA = "0xA6961C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0xA69624", Offset = "0xA69624", VA = "0xA69624", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0xA6962C", Offset = "0xA6962C", VA = "0xA6962C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0xA69634", Offset = "0xA69634", VA = "0xA69634", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0xA696B4", Offset = "0xA696B4", VA = "0xA696B4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0xA696BC", Offset = "0xA696BC", VA = "0xA696BC", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0xA69838", Offset = "0xA69838", VA = "0xA69838", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0xA69928", Offset = "0xA69928", VA = "0xA69928")]
		public LocalizeTarget_UnityUI_Image()
		{
		}
	}
	[Token(Token = "0x200019A")]
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0xA69970", Offset = "0xA69970", VA = "0xA69970")]
		static LocalizeTarget_UnityUI_RawImage()
		{
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0xA69974", Offset = "0xA69974", VA = "0xA69974")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0xA69A30", Offset = "0xA69A30", VA = "0xA69A30", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0xA69A38", Offset = "0xA69A38", VA = "0xA69A38", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0xA69A40", Offset = "0xA69A40", VA = "0xA69A40", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0xA69A48", Offset = "0xA69A48", VA = "0xA69A48", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0xA69A50", Offset = "0xA69A50", VA = "0xA69A50", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0xA69A58", Offset = "0xA69A58", VA = "0xA69A58", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0xA69B34", Offset = "0xA69B34", VA = "0xA69B34", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0xA69C24", Offset = "0xA69C24", VA = "0xA69C24")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		}
	}
	[Token(Token = "0x200019B")]
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAnchor mAlignment_RTL;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAnchor mAlignment_LTR;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0xA69C6C", Offset = "0xA69C6C", VA = "0xA69C6C")]
		static LocalizeTarget_UnityUI_Text()
		{
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0xA69C70", Offset = "0xA69C70", VA = "0xA69C70")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0xA69D2C", Offset = "0xA69D2C", VA = "0xA69D2C", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0xA69D34", Offset = "0xA69D34", VA = "0xA69D34", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0xA69D3C", Offset = "0xA69D3C", VA = "0xA69D3C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0xA69D44", Offset = "0xA69D44", VA = "0xA69D44", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0xA69D4C", Offset = "0xA69D4C", VA = "0xA69D4C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0xA69D54", Offset = "0xA69D54", VA = "0xA69D54", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0xA69E70", Offset = "0xA69E70", VA = "0xA69E70", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0xA6A118", Offset = "0xA6A118", VA = "0xA6A118")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0xA6A1D0", Offset = "0xA6A1D0", VA = "0xA6A1D0")]
		public LocalizeTarget_UnityUI_Text()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public enum eTermType
	{
		[Token(Token = "0x40008AA")]
		Text,
		[Token(Token = "0x40008AB")]
		Font,
		[Token(Token = "0x40008AC")]
		Texture,
		[Token(Token = "0x40008AD")]
		AudioClip,
		[Token(Token = "0x40008AE")]
		GameObject,
		[Token(Token = "0x40008AF")]
		Sprite,
		[Token(Token = "0x40008B0")]
		Material,
		[Token(Token = "0x40008B1")]
		Child,
		[Token(Token = "0x40008B2")]
		Mesh,
		[Token(Token = "0x40008B3")]
		TextMeshPFont,
		[Token(Token = "0x40008B4")]
		Object,
		[Token(Token = "0x40008B5")]
		Video
	}
	[Token(Token = "0x200019D")]
	public enum TranslationFlag : byte
	{
		[Token(Token = "0x40008B7")]
		Normal = 1,
		[Token(Token = "0x40008B8")]
		AutoTranslated
	}
	[Serializable]
	[Token(Token = "0x200019E")]
	public class TermData
	{
		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Term;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public eTermType TermType;

		[NonSerialized]
		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Languages;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] Flags;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] Languages_Touch;

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0xA6A228", Offset = "0xA6A228", VA = "0xA6A228")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
			return null;
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0xA6A33C", Offset = "0xA6A33C", VA = "0xA6A33C")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0xA6A418", Offset = "0xA6A418", VA = "0xA6A418")]
		public void RemoveSpecialization(string specialization)
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0xA6A46C", Offset = "0xA6A46C", VA = "0xA6A46C")]
		public void RemoveSpecialization(int idx, string specialization)
		{
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0xA6A5F8", Offset = "0xA6A5F8", VA = "0xA6A5F8")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0xA6A62C", Offset = "0xA6A62C", VA = "0xA6A62C")]
		public void Validate()
		{
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0xA6A7E0", Offset = "0xA6A7E0", VA = "0xA6A7E0")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0xA6A868", Offset = "0xA6A868", VA = "0xA6A868")]
		public bool HasSpecializations()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0xA6A930", Offset = "0xA6A930", VA = "0xA6A930")]
		public List<string> GetAllSpecializations()
		{
			return null;
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0xA6AA18", Offset = "0xA6AA18", VA = "0xA6AA18")]
		public TermData()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class TermsPopup : PropertyAttribute
	{
		[Token(Token = "0x170000E1")]
		public string Filter
		{
			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0xA6AB50", Offset = "0xA6AB50", VA = "0xA6AB50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0xA6AB58", Offset = "0xA6AB58", VA = "0xA6AB58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0xA6AB28", Offset = "0xA6AB28", VA = "0xA6AB28")]
		public TermsPopup(string filter = "")
		{
		}
	}
	[Token(Token = "0x20001A0")]
	public class AutoChangeCultureInfo : MonoBehaviour
	{
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0xA6AB60", Offset = "0xA6AB60", VA = "0xA6AB60")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0xA6ABB4", Offset = "0xA6ABB4", VA = "0xA6ABB4")]
		public AutoChangeCultureInfo()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x170000E2")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x6000B81")]
			[Address(RVA = "0xA6ABBC", Offset = "0xA6ABBC", VA = "0xA6ABBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0xA6ACFC", Offset = "0xA6ACFC", VA = "0xA6ACFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0xA6AD80", Offset = "0xA6AD80", VA = "0xA6AD80")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0xA6ADA4", Offset = "0xA6ADA4", VA = "0xA6ADA4")]
		public CoroutineManager()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	[AddComponentMenu("I2/Localization/I2 Localize Callback")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent _OnLocalize;

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0xA6ADAC", Offset = "0xA6ADAC", VA = "0xA6ADAC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0xA6AE84", Offset = "0xA6AE84", VA = "0xA6AE84")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0xA6AF28", Offset = "0xA6AF28", VA = "0xA6AF28")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0xA6AF44", Offset = "0xA6AF44", VA = "0xA6AF44")]
		public CustomLocalizeCallback()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public class HindiFixer
	{
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0xA6AFAC", Offset = "0xA6AFAC", VA = "0xA6AFAC")]
		internal static string Fix(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0xA6B3B0", Offset = "0xA6B3B0", VA = "0xA6B3B0")]
		public HindiFixer()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public static class I2Utils
	{
		[Token(Token = "0x40008C4")]
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

		[Token(Token = "0x40008C5")]
		public const string NumberChars = "0123456789";

		[Token(Token = "0x40008C6")]
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0xA670B0", Offset = "0xA670B0", VA = "0xA670B0")]
		public static string ReverseText(string source)
		{
			return null;
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0xA6B4B4", Offset = "0xA6B4B4", VA = "0xA6B4B4")]
		public static string RemoveNonASCII(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0xA6B6D4", Offset = "0xA6B6D4", VA = "0xA6B6D4")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0xA6B77C", Offset = "0xA6B77C", VA = "0xA6B77C")]
		public static string SplitLine(string line, int maxCharacters)
		{
			return null;
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0xA6BA18", Offset = "0xA6BA18", VA = "0xA6BA18")]
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0xA6B6F4", Offset = "0xA6B6F4", VA = "0xA6B6F4")]
		public static string RemoveTags(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0xA6BB9C", Offset = "0xA6BB9C", VA = "0xA6BB9C")]
		public static bool RemoveResourcesPath(ref string sPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0xA6BE28", Offset = "0xA6BE28", VA = "0xA6BE28")]
		public static bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0xA6BE30", Offset = "0xA6BE30", VA = "0xA6BE30")]
		public static string GetPath(this Transform tr)
		{
			return null;
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0xA6BF00", Offset = "0xA6BF00", VA = "0xA6BF00")]
		public static Transform FindObject(string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0xA6BF60", Offset = "0xA6BF60", VA = "0xA6BF60")]
		public static Transform FindObject(Scene scene, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0xA6C0A0", Offset = "0xA6C0A0", VA = "0xA6C0A0")]
		public static Transform FindObject(Transform root, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000B9A")]
		public static H FindInParents<H>(Transform tr) where H : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0xA6C1C8", Offset = "0xA6C1C8", VA = "0xA6C1C8")]
		public static string GetCaptureMatch(Match match)
		{
			return null;
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0xA6C274", Offset = "0xA6C274", VA = "0xA6C274")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		}
	}
	[Token(Token = "0x20001A8")]
	public interface ILocalizationParamsManager
	{
		[Token(Token = "0x6000BA1")]
		string GetParameterValue(string Param);
	}
	[Token(Token = "0x20001A9")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		[Serializable]
		[Token(Token = "0x20001AA")]
		public struct ParamValue
		{
			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string Value;
		}

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<ParamValue> _Params;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _IsGlobalManager;

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0xA6C300", Offset = "0xA6C300", VA = "0xA6C300", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0xA6C3C4", Offset = "0xA6C3C4", VA = "0xA6C3C4")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0xA6C560", Offset = "0xA6C560", VA = "0xA6C560")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0xA6C618", Offset = "0xA6C618", VA = "0xA6C618", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0xA6C628", Offset = "0xA6C628", VA = "0xA6C628")]
		public void DoAutoRegister()
		{
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0xA6C74C", Offset = "0xA6C74C", VA = "0xA6C74C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0xA6C7CC", Offset = "0xA6C7CC", VA = "0xA6C7CC")]
		public LocalizationParamsManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001AB")]
	public struct LocalizedString
	{
		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string mTerm;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool mRTL_IgnoreArabicFix;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int mRTL_MaxLineLength;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool mRTL_ConvertNumbers;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_DontLocalizeParameters;

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0xA6C848", Offset = "0xA6C848", VA = "0xA6C848")]
		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0xA6C910", Offset = "0xA6C910", VA = "0xA6C910")]
		public static implicit operator LocalizedString(string term)
		{
			return default(LocalizedString);
		}

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0xA6C91C", Offset = "0xA6C91C", VA = "0xA6C91C")]
		public LocalizedString(LocalizedString str)
		{
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0xA6C84C", Offset = "0xA6C84C", VA = "0xA6C84C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20001AC")]
	public class RegisterCallback_AllowSyncFromGoogle : MonoBehaviour
	{
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0xA6C954", Offset = "0xA6C954", VA = "0xA6C954")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0xA6C9F0", Offset = "0xA6C9F0", VA = "0xA6C9F0")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0xA6CA8C", Offset = "0xA6CA8C", VA = "0xA6CA8C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0xA6CAE4", Offset = "0xA6CAE4", VA = "0xA6CAE4", Slot = "4")]
		public virtual bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0xA6CAEC", Offset = "0xA6CAEC", VA = "0xA6CAEC")]
		public RegisterCallback_AllowSyncFromGoogle()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0xA6CAF4", Offset = "0xA6CAF4", VA = "0xA6CAF4", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0xA6CC18", Offset = "0xA6CC18", VA = "0xA6CC18", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0xA6CC98", Offset = "0xA6CC98", VA = "0xA6CC98", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0xA6CCA0", Offset = "0xA6CCA0", VA = "0xA6CCA0")]
		public RegisterGlobalParameters()
		{
		}
	}
	[Token(Token = "0x20001AE")]
	public interface IResourceManager_Bundles
	{
		[Token(Token = "0x6000BB6")]
		UnityEngine.Object LoadFromBundle(string path, Type assetType);
	}
	[Token(Token = "0x20001AF")]
	public class ResourceManager : MonoBehaviour
	{
		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<IResourceManager_Bundles> mBundleManagers;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object[] Assets;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, UnityEngine.Object> mResourcesCache;

		[Token(Token = "0x170000E3")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0xA6CCA8", Offset = "0xA6CCA8", VA = "0xA6CCA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0xA6D050", Offset = "0xA6D050", VA = "0xA6D050")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000BB9")]
		public T GetAsset<T>(string Name) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0xA6D118", Offset = "0xA6D118", VA = "0xA6D118")]
		private UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0xA6D23C", Offset = "0xA6D23C", VA = "0xA6D23C")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BBC")]
		public T LoadFromResources<T>(string Path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000BBD")]
		public T LoadFromBundle<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0xA6D0AC", Offset = "0xA6D0AC", VA = "0xA6D0AC")]
		public void CleanResourceCache(bool unloadResources = false)
		{
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0xA6D29C", Offset = "0xA6D29C", VA = "0xA6D29C")]
		public ResourceManager()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public class RTLFixer
	{
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0xA6D3C8", Offset = "0xA6D3C8", VA = "0xA6D3C8")]
		public static string Fix(string str)
		{
			return null;
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0xA6D644", Offset = "0xA6D644", VA = "0xA6D644")]
		public static string Fix(string str, bool rtl)
		{
			return null;
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0xA6D3D4", Offset = "0xA6D3D4", VA = "0xA6D3D4")]
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0xA6E84C", Offset = "0xA6E84C", VA = "0xA6E84C")]
		public RTLFixer()
		{
		}
	}
	[Token(Token = "0x20001B1")]
	internal enum IsolatedArabicLetters
	{
		[Token(Token = "0x40008D9")]
		Hamza = 65152,
		[Token(Token = "0x40008DA")]
		Alef = 65165,
		[Token(Token = "0x40008DB")]
		AlefHamza = 65155,
		[Token(Token = "0x40008DC")]
		WawHamza = 65157,
		[Token(Token = "0x40008DD")]
		AlefMaksoor = 65159,
		[Token(Token = "0x40008DE")]
		AlefMaksora = 64508,
		[Token(Token = "0x40008DF")]
		HamzaNabera = 65161,
		[Token(Token = "0x40008E0")]
		Ba = 65167,
		[Token(Token = "0x40008E1")]
		Ta = 65173,
		[Token(Token = "0x40008E2")]
		Tha2 = 65177,
		[Token(Token = "0x40008E3")]
		Jeem = 65181,
		[Token(Token = "0x40008E4")]
		H7aa = 65185,
		[Token(Token = "0x40008E5")]
		Khaa2 = 65189,
		[Token(Token = "0x40008E6")]
		Dal = 65193,
		[Token(Token = "0x40008E7")]
		Thal = 65195,
		[Token(Token = "0x40008E8")]
		Ra2 = 65197,
		[Token(Token = "0x40008E9")]
		Zeen = 65199,
		[Token(Token = "0x40008EA")]
		Seen = 65201,
		[Token(Token = "0x40008EB")]
		Sheen = 65205,
		[Token(Token = "0x40008EC")]
		S9a = 65209,
		[Token(Token = "0x40008ED")]
		Dha = 65213,
		[Token(Token = "0x40008EE")]
		T6a = 65217,
		[Token(Token = "0x40008EF")]
		T6ha = 65221,
		[Token(Token = "0x40008F0")]
		Ain = 65225,
		[Token(Token = "0x40008F1")]
		Gain = 65229,
		[Token(Token = "0x40008F2")]
		Fa = 65233,
		[Token(Token = "0x40008F3")]
		Gaf = 65237,
		[Token(Token = "0x40008F4")]
		Kaf = 65241,
		[Token(Token = "0x40008F5")]
		Lam = 65245,
		[Token(Token = "0x40008F6")]
		Meem = 65249,
		[Token(Token = "0x40008F7")]
		Noon = 65253,
		[Token(Token = "0x40008F8")]
		Ha = 65257,
		[Token(Token = "0x40008F9")]
		Waw = 65261,
		[Token(Token = "0x40008FA")]
		Ya = 65265,
		[Token(Token = "0x40008FB")]
		AlefMad = 65153,
		[Token(Token = "0x40008FC")]
		TaMarboota = 65171,
		[Token(Token = "0x40008FD")]
		PersianPe = 64342,
		[Token(Token = "0x40008FE")]
		PersianChe = 64378,
		[Token(Token = "0x40008FF")]
		PersianZe = 64394,
		[Token(Token = "0x4000900")]
		PersianGaf = 64402,
		[Token(Token = "0x4000901")]
		PersianGaf2 = 64398
	}
	[Token(Token = "0x20001B2")]
	internal enum GeneralArabicLetters
	{
		[Token(Token = "0x4000903")]
		Hamza = 1569,
		[Token(Token = "0x4000904")]
		Alef = 1575,
		[Token(Token = "0x4000905")]
		AlefHamza = 1571,
		[Token(Token = "0x4000906")]
		WawHamza = 1572,
		[Token(Token = "0x4000907")]
		AlefMaksoor = 1573,
		[Token(Token = "0x4000908")]
		AlefMagsora = 1609,
		[Token(Token = "0x4000909")]
		HamzaNabera = 1574,
		[Token(Token = "0x400090A")]
		Ba = 1576,
		[Token(Token = "0x400090B")]
		Ta = 1578,
		[Token(Token = "0x400090C")]
		Tha2 = 1579,
		[Token(Token = "0x400090D")]
		Jeem = 1580,
		[Token(Token = "0x400090E")]
		H7aa = 1581,
		[Token(Token = "0x400090F")]
		Khaa2 = 1582,
		[Token(Token = "0x4000910")]
		Dal = 1583,
		[Token(Token = "0x4000911")]
		Thal = 1584,
		[Token(Token = "0x4000912")]
		Ra2 = 1585,
		[Token(Token = "0x4000913")]
		Zeen = 1586,
		[Token(Token = "0x4000914")]
		Seen = 1587,
		[Token(Token = "0x4000915")]
		Sheen = 1588,
		[Token(Token = "0x4000916")]
		S9a = 1589,
		[Token(Token = "0x4000917")]
		Dha = 1590,
		[Token(Token = "0x4000918")]
		T6a = 1591,
		[Token(Token = "0x4000919")]
		T6ha = 1592,
		[Token(Token = "0x400091A")]
		Ain = 1593,
		[Token(Token = "0x400091B")]
		Gain = 1594,
		[Token(Token = "0x400091C")]
		Fa = 1601,
		[Token(Token = "0x400091D")]
		Gaf = 1602,
		[Token(Token = "0x400091E")]
		Kaf = 1603,
		[Token(Token = "0x400091F")]
		Lam = 1604,
		[Token(Token = "0x4000920")]
		Meem = 1605,
		[Token(Token = "0x4000921")]
		Noon = 1606,
		[Token(Token = "0x4000922")]
		Ha = 1607,
		[Token(Token = "0x4000923")]
		Waw = 1608,
		[Token(Token = "0x4000924")]
		Ya = 1610,
		[Token(Token = "0x4000925")]
		AlefMad = 1570,
		[Token(Token = "0x4000926")]
		TaMarboota = 1577,
		[Token(Token = "0x4000927")]
		PersianPe = 1662,
		[Token(Token = "0x4000928")]
		PersianChe = 1670,
		[Token(Token = "0x4000929")]
		PersianZe = 1688,
		[Token(Token = "0x400092A")]
		PersianGaf = 1711,
		[Token(Token = "0x400092B")]
		PersianGaf2 = 1705
	}
	[Token(Token = "0x20001B3")]
	internal class ArabicMapping
	{
		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int from;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int to;

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0xA6E854", Offset = "0xA6E854", VA = "0xA6E854")]
		public ArabicMapping(int from, int to)
		{
		}
	}
	[Token(Token = "0x20001B4")]
	internal class ArabicTable
	{
		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ArabicTable arabicMapper;

		[Token(Token = "0x170000E4")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0xA6FFC0", Offset = "0xA6FFC0", VA = "0xA6FFC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0xA6E880", Offset = "0xA6E880", VA = "0xA6E880")]
		private ArabicTable()
		{
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0xA70030", Offset = "0xA70030", VA = "0xA70030")]
		internal int Convert(int toBeConverted)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001B5")]
	internal class TashkeelLocation
	{
		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char tashkeel;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int position;

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0xA701C4", Offset = "0xA701C4", VA = "0xA701C4")]
		public TashkeelLocation(char tashkeel, int position)
		{
		}
	}
	[Token(Token = "0x20001B6")]
	internal class RTLFixerTool
	{
		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0xA701F4", Offset = "0xA701F4", VA = "0xA701F4")]
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0xA70710", Offset = "0xA70710", VA = "0xA70710")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0xA6D844", Offset = "0xA6D844", VA = "0xA6D844")]
		internal static string FixLine(string str)
		{
			return null;
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0xA70938", Offset = "0xA70938", VA = "0xA70938")]
		internal static bool IsIgnoredCharacter(char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0xA70F08", Offset = "0xA70F08", VA = "0xA70F08")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0xA70DC4", Offset = "0xA70DC4", VA = "0xA70DC4")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0xA70A94", Offset = "0xA70A94", VA = "0xA70A94")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0xA711F4", Offset = "0xA711F4", VA = "0xA711F4")]
		public RTLFixerTool()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	[AddComponentMenu("I2/Localization/SetLanguage Button")]
	public class SetLanguage : MonoBehaviour
	{
		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string _Language;

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0xA71248", Offset = "0xA71248", VA = "0xA71248")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0xA7124C", Offset = "0xA7124C", VA = "0xA7124C")]
		public void ApplyLanguage()
		{
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0xA712E4", Offset = "0xA712E4", VA = "0xA712E4")]
		public SetLanguage()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	[AddComponentMenu("I2/Localization/SetLanguage Dropdown")]
	public class SetLanguageDropdown : MonoBehaviour
	{
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0xA712EC", Offset = "0xA712EC", VA = "0xA712EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0xA71544", Offset = "0xA71544", VA = "0xA71544")]
		private void OnValueChanged(int index)
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0xA71630", Offset = "0xA71630", VA = "0xA71630")]
		public SetLanguageDropdown()
		{
		}
	}
	[Token(Token = "0x20001B9")]
	public class StringObfucator
	{
		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static char[] StringObfuscatorPassword;

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0xA71638", Offset = "0xA71638", VA = "0xA71638")]
		public static string Encode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0xA7192C", Offset = "0xA7192C", VA = "0xA7192C")]
		public static string Decode(string ObfucatedString)
		{
			return null;
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0xA718A8", Offset = "0xA718A8", VA = "0xA718A8")]
		private static string ToBase64(string regularString)
		{
			return null;
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0xA71A04", Offset = "0xA71A04", VA = "0xA71A04")]
		private static string FromBase64(string base64string)
		{
			return null;
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0xA71710", Offset = "0xA71710", VA = "0xA71710")]
		private static string XoREncode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0xA71A90", Offset = "0xA71A90", VA = "0xA71A90")]
		public StringObfucator()
		{
		}
	}
}
namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x20001BA")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x4000937")]
		Array = 1,
		[Token(Token = "0x4000938")]
		Class,
		[Token(Token = "0x4000939")]
		Value,
		[Token(Token = "0x400093A")]
		IntValue,
		[Token(Token = "0x400093B")]
		DoubleValue,
		[Token(Token = "0x400093C")]
		BoolValue,
		[Token(Token = "0x400093D")]
		FloatValue
	}
	[Token(Token = "0x20001BB")]
	public class JSONNode
	{
		[Token(Token = "0x20001BC")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x170000F1")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000C13")]
				[Address(RVA = "0xA73B78", Offset = "0xA73B78", VA = "0xA73B78", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C15")]
				[Address(RVA = "0xA73BC0", Offset = "0xA73BC0", VA = "0xA73BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C10")]
			[Address(RVA = "0xA71C58", Offset = "0xA71C58", VA = "0xA71C58")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000C11")]
			[Address(RVA = "0xA73B5C", Offset = "0xA73B5C", VA = "0xA73B5C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C12")]
			[Address(RVA = "0xA73B60", Offset = "0xA73B60", VA = "0xA73B60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C14")]
			[Address(RVA = "0xA73B80", Offset = "0xA73B80", VA = "0xA73B80", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C16")]
			[Address(RVA = "0xA73BC8", Offset = "0xA73BC8", VA = "0xA73BC8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C17")]
			[Address(RVA = "0xA73C60", Offset = "0xA73C60", VA = "0xA73C60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001BD")]
		[CompilerGenerated]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x170000F3")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000C1D")]
				[Address(RVA = "0xA742B0", Offset = "0xA742B0", VA = "0xA742B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C1F")]
				[Address(RVA = "0xA742F8", Offset = "0xA742F8", VA = "0xA742F8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C18")]
			[Address(RVA = "0xA71D04", Offset = "0xA71D04", VA = "0xA71D04")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000C19")]
			[Address(RVA = "0xA73C64", Offset = "0xA73C64", VA = "0xA73C64", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0xA73D1C", Offset = "0xA73D1C", VA = "0xA73D1C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0xA74200", Offset = "0xA74200", VA = "0xA74200")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0xA74150", Offset = "0xA74150", VA = "0xA74150")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0xA742B8", Offset = "0xA742B8", VA = "0xA742B8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C20")]
			[Address(RVA = "0xA74300", Offset = "0xA74300", VA = "0xA74300", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C21")]
			[Address(RVA = "0xA743A4", Offset = "0xA743A4", VA = "0xA743A4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public virtual JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0xA71B0C", Offset = "0xA71B0C", VA = "0xA71B0C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0xA71B14", Offset = "0xA71B14", VA = "0xA71B14", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0xA71B18", Offset = "0xA71B18", VA = "0xA71B18", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0xA71B20", Offset = "0xA71B20", VA = "0xA71B20", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public virtual string Value
		{
			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0xA71B24", Offset = "0xA71B24", VA = "0xA71B24", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0xA71B64", Offset = "0xA71B64", VA = "0xA71B64", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public virtual int Count
		{
			[Token(Token = "0x6000BE6")]
			[Address(RVA = "0xA71B68", Offset = "0xA71B68", VA = "0xA71B68", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E9")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0xA71BE8", Offset = "0xA71BE8", VA = "0xA71BE8", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__17))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0xA71C8C", Offset = "0xA71C8C", VA = "0xA71C8C")]
			[IteratorStateMachine(typeof(<get_DeepChilds>d__19))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EB")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0xA71DB8", Offset = "0xA71DB8", VA = "0xA71DB8", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0xA71DEC", Offset = "0xA71DEC", VA = "0xA71DEC", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0xA71E28", Offset = "0xA71E28", VA = "0xA71E28", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0xA71E60", Offset = "0xA71E60", VA = "0xA71E60", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0xA71E9C", Offset = "0xA71E9C", VA = "0xA71E9C", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0xA71ED4", Offset = "0xA71ED4", VA = "0xA71ED4", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0xA71F10", Offset = "0xA71F10", VA = "0xA71F10", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0xA71FC8", Offset = "0xA71FC8", VA = "0xA71FC8", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0xA72040", Offset = "0xA72040", VA = "0xA72040", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0xA720B8", Offset = "0xA720B8", VA = "0xA720B8", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0xA71B08", Offset = "0xA71B08", VA = "0xA71B08", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0xA71B70", Offset = "0xA71B70", VA = "0xA71B70", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0xA71BD0", Offset = "0xA71BD0", VA = "0xA71BD0", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0xA71BD8", Offset = "0xA71BD8", VA = "0xA71BD8", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0xA71BE0", Offset = "0xA71BE0", VA = "0xA71BE0", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0xA71D38", Offset = "0xA71D38", VA = "0xA71D38", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0xA71D78", Offset = "0xA71D78", VA = "0xA71D78", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0xA72130", Offset = "0xA72130", VA = "0xA72130")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0xA721BC", Offset = "0xA721BC", VA = "0xA721BC")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0xA721F8", Offset = "0xA721F8", VA = "0xA721F8")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0xA72280", Offset = "0xA72280", VA = "0xA72280")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0xA72298", Offset = "0xA72298", VA = "0xA72298", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0xA722A4", Offset = "0xA722A4", VA = "0xA722A4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0xA722AC", Offset = "0xA722AC", VA = "0xA722AC")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0xA72478", Offset = "0xA72478", VA = "0xA72478")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0xA72CF0", Offset = "0xA72CF0", VA = "0xA72CF0", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0xA72CF4", Offset = "0xA72CF4", VA = "0xA72CF4")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0xA72D74", Offset = "0xA72D74", VA = "0xA72D74")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0xA72DC4", Offset = "0xA72DC4", VA = "0xA72DC4")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0xA72E14", Offset = "0xA72E14", VA = "0xA72E14")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0xA72E64", Offset = "0xA72E64", VA = "0xA72E64")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0xA73034", Offset = "0xA73034", VA = "0xA73034")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0xA73234", Offset = "0xA73234", VA = "0xA73234")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0xA736A0", Offset = "0xA736A0", VA = "0xA736A0")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0xA736F0", Offset = "0xA736F0", VA = "0xA736F0")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0xA73740", Offset = "0xA73740", VA = "0xA73740")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0xA73790", Offset = "0xA73790", VA = "0xA73790")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0xA73924", Offset = "0xA73924", VA = "0xA73924")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0xA73AA0", Offset = "0xA73AA0", VA = "0xA73AA0")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0xA73B54", Offset = "0xA73B54", VA = "0xA73B54")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x20001BF")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000F9")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000C34")]
				[Address(RVA = "0xA7514C", Offset = "0xA7514C", VA = "0xA7514C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C36")]
				[Address(RVA = "0xA75194", Offset = "0xA75194", VA = "0xA75194", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C30")]
			[Address(RVA = "0xA74914", Offset = "0xA74914", VA = "0xA74914")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000C31")]
			[Address(RVA = "0xA74F4C", Offset = "0xA74F4C", VA = "0xA74F4C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C32")]
			[Address(RVA = "0xA74F68", Offset = "0xA74F68", VA = "0xA74F68", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C33")]
			[Address(RVA = "0xA750FC", Offset = "0xA750FC", VA = "0xA750FC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C35")]
			[Address(RVA = "0xA75154", Offset = "0xA75154", VA = "0xA75154", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C37")]
			[Address(RVA = "0xA7519C", Offset = "0xA7519C", VA = "0xA7519C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C38")]
			[Address(RVA = "0xA75240", Offset = "0xA75240", VA = "0xA75240", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001C0")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000FB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C3D")]
				[Address(RVA = "0xA75444", Offset = "0xA75444", VA = "0xA75444", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C3F")]
				[Address(RVA = "0xA7548C", Offset = "0xA7548C", VA = "0xA7548C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C39")]
			[Address(RVA = "0xA749B0", Offset = "0xA749B0", VA = "0xA749B0")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0xA75244", Offset = "0xA75244", VA = "0xA75244", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0xA75260", Offset = "0xA75260", VA = "0xA75260", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0xA753F4", Offset = "0xA753F4", VA = "0xA753F4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0xA7544C", Offset = "0xA7544C", VA = "0xA7544C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x170000F5")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000C22")]
			[Address(RVA = "0xA743A8", Offset = "0xA743A8", VA = "0xA743A8", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C23")]
			[Address(RVA = "0xA74484", Offset = "0xA74484", VA = "0xA74484", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000C24")]
			[Address(RVA = "0xA7458C", Offset = "0xA7458C", VA = "0xA7458C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C25")]
			[Address(RVA = "0xA745F0", Offset = "0xA745F0", VA = "0xA745F0", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public override int Count
		{
			[Token(Token = "0x6000C26")]
			[Address(RVA = "0xA74698", Offset = "0xA74698", VA = "0xA74698", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F8")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0xA7489C", Offset = "0xA7489C", VA = "0xA7489C", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__13))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0xA746E0", Offset = "0xA746E0", VA = "0xA746E0", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0xA74788", Offset = "0xA74788", VA = "0xA74788", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0xA7483C", Offset = "0xA7483C", VA = "0xA7483C", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0xA74948", Offset = "0xA74948", VA = "0xA74948", Slot = "29")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__14))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0xA749D8", Offset = "0xA749D8", VA = "0xA749D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0xA74BF0", Offset = "0xA74BF0", VA = "0xA74BF0", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0xA74E70", Offset = "0xA74E70", VA = "0xA74E70", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0xA72C74", Offset = "0xA72C74", VA = "0xA72C74")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x20001C3")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000101")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000C55")]
				[Address(RVA = "0xA76A8C", Offset = "0xA76A8C", VA = "0xA76A8C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000102")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C57")]
				[Address(RVA = "0xA76AD4", Offset = "0xA76AD4", VA = "0xA76AD4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C51")]
			[Address(RVA = "0xA75D10", Offset = "0xA75D10", VA = "0xA75D10")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000C52")]
			[Address(RVA = "0xA76878", Offset = "0xA76878", VA = "0xA76878", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C53")]
			[Address(RVA = "0xA76894", Offset = "0xA76894", VA = "0xA76894", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C54")]
			[Address(RVA = "0xA76A3C", Offset = "0xA76A3C", VA = "0xA76A3C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C56")]
			[Address(RVA = "0xA76A94", Offset = "0xA76A94", VA = "0xA76A94", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C58")]
			[Address(RVA = "0xA76ADC", Offset = "0xA76ADC", VA = "0xA76ADC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C59")]
			[Address(RVA = "0xA76B80", Offset = "0xA76B80", VA = "0xA76B80", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000103")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C5E")]
				[Address(RVA = "0xA76DC4", Offset = "0xA76DC4", VA = "0xA76DC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000104")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C60")]
				[Address(RVA = "0xA76E0C", Offset = "0xA76E0C", VA = "0xA76E0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0xA75DAC", Offset = "0xA75DAC", VA = "0xA75DAC")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0xA76B84", Offset = "0xA76B84", VA = "0xA76B84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0xA76BA0", Offset = "0xA76BA0", VA = "0xA76BA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0xA76D74", Offset = "0xA76D74", VA = "0xA76D74")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0xA76DCC", Offset = "0xA76DCC", VA = "0xA76DCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x170000FD")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000C40")]
			[Address(RVA = "0xA75494", Offset = "0xA75494", VA = "0xA75494", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C41")]
			[Address(RVA = "0xA75584", Offset = "0xA75584", VA = "0xA75584", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000C42")]
			[Address(RVA = "0xA75650", Offset = "0xA75650", VA = "0xA75650", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C43")]
			[Address(RVA = "0xA756F0", Offset = "0xA756F0", VA = "0xA756F0", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public override int Count
		{
			[Token(Token = "0x6000C44")]
			[Address(RVA = "0xA757CC", Offset = "0xA757CC", VA = "0xA757CC", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000100")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000C49")]
			[Address(RVA = "0xA75C98", Offset = "0xA75C98", VA = "0xA75C98", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__14))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0xA7581C", Offset = "0xA7581C", VA = "0xA7581C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0xA75930", Offset = "0xA75930", VA = "0xA75930", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0xA759F4", Offset = "0xA759F4", VA = "0xA759F4", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0xA75AD0", Offset = "0xA75AD0", VA = "0xA75AD0", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0xA75D44", Offset = "0xA75D44", VA = "0xA75D44", Slot = "29")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0xA75DD4", Offset = "0xA75DD4", VA = "0xA75DD4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0xA761A8", Offset = "0xA761A8", VA = "0xA761A8", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0xA76614", Offset = "0xA76614", VA = "0xA76614", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0xA72B94", Offset = "0xA72B94", VA = "0xA72B94")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000105")]
		public override string Value
		{
			[Token(Token = "0x6000C61")]
			[Address(RVA = "0xA76E14", Offset = "0xA76E14", VA = "0xA76E14", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C62")]
			[Address(RVA = "0xA76E1C", Offset = "0xA76E1C", VA = "0xA76E1C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0xA72194", Offset = "0xA72194", VA = "0xA72194")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0xA73668", Offset = "0xA73668", VA = "0xA73668")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0xA735F8", Offset = "0xA735F8", VA = "0xA735F8")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0xA73630", Offset = "0xA73630", VA = "0xA73630")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0xA735C0", Offset = "0xA735C0", VA = "0xA735C0")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x6000C68")]
		[Address(RVA = "0xA76E24", Offset = "0xA76E24", VA = "0xA76E24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0xA76E7C", Offset = "0xA76E7C", VA = "0xA76E7C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0xA76ED4", Offset = "0xA76ED4", VA = "0xA76ED4", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20001C6")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000106")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0xA771E8", Offset = "0xA771E8", VA = "0xA771E8", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0xA7724C", Offset = "0xA7724C", VA = "0xA7724C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000C70")]
			[Address(RVA = "0xA772CC", Offset = "0xA772CC", VA = "0xA772CC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C71")]
			[Address(RVA = "0xA7733C", Offset = "0xA7733C", VA = "0xA7733C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public override int AsInt
		{
			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0xA7759C", Offset = "0xA7759C", VA = "0xA7759C", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0xA77620", Offset = "0xA77620", VA = "0xA77620", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public override float AsFloat
		{
			[Token(Token = "0x6000C7C")]
			[Address(RVA = "0xA776A8", Offset = "0xA776A8", VA = "0xA776A8", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000C7D")]
			[Address(RVA = "0xA7772C", Offset = "0xA7772C", VA = "0xA7772C", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public override double AsDouble
		{
			[Token(Token = "0x6000C7E")]
			[Address(RVA = "0xA777B4", Offset = "0xA777B4", VA = "0xA777B4", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000C7F")]
			[Address(RVA = "0xA77838", Offset = "0xA77838", VA = "0xA77838", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public override bool AsBool
		{
			[Token(Token = "0x6000C80")]
			[Address(RVA = "0xA778C0", Offset = "0xA778C0", VA = "0xA778C0", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C81")]
			[Address(RVA = "0xA77944", Offset = "0xA77944", VA = "0xA77944", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000C82")]
			[Address(RVA = "0xA779CC", Offset = "0xA779CC", VA = "0xA779CC", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x6000C83")]
			[Address(RVA = "0xA77A34", Offset = "0xA77A34", VA = "0xA77A34", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0xA7445C", Offset = "0xA7445C", VA = "0xA7445C")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0xA75558", Offset = "0xA75558", VA = "0xA75558")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0xA77194", Offset = "0xA77194", VA = "0xA77194")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x6000C72")]
		[Address(RVA = "0xA773C4", Offset = "0xA773C4", VA = "0xA773C4", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000C73")]
		[Address(RVA = "0xA77444", Offset = "0xA77444", VA = "0xA77444", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0xA774CC", Offset = "0xA774CC", VA = "0xA774CC")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0xA774E4", Offset = "0xA774E4", VA = "0xA774E4")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0xA774FC", Offset = "0xA774FC", VA = "0xA774FC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0xA77514", Offset = "0xA77514", VA = "0xA77514", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0xA7751C", Offset = "0xA7751C", VA = "0xA7751C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0xA7755C", Offset = "0xA7755C", VA = "0xA7755C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x20001C7")]
	public static class JSON
	{
		[Token(Token = "0x6000C84")]
		[Address(RVA = "0xA77A9C", Offset = "0xA77A9C", VA = "0xA77A9C")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
namespace FlexFramework.Excel
{
	[Token(Token = "0x20001C8")]
	public abstract class CustomConverter<T> : IConverter
	{
		[Token(Token = "0x20001C9")]
		[CompilerGenerated]
		private sealed class <SplitGroup>d__5 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string <>2__current;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private char start;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public char <>3__start;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private char end;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public char <>3__end;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string input;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string <>3__input;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator <>7__wrap1;

			[Token(Token = "0x1700010F")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x6000C90")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000110")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C92")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C8C")]
			[DebuggerHidden]
			public <SplitGroup>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000C8D")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C8E")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C8F")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C91")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C93")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C94")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		private Type FlexFramework.Excel.IConverter.Type
		{
			[Token(Token = "0x6000C85")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C86")]
		public abstract T Convert(string input);

		[Token(Token = "0x6000C87")]
		public bool TryConvert(string input, out T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C88")]
		protected string[] Split(string input, params char[] separators)
		{
			return null;
		}

		[Token(Token = "0x6000C89")]
		[IteratorStateMachine(typeof(CustomConverter<>.<SplitGroup>d__5))]
		protected IEnumerable<string> SplitGroup(string input, char start, char end)
		{
			return null;
		}

		[Token(Token = "0x6000C8A")]
		private object FlexFramework.Excel.IConverter.Convert(string input)
		{
			return null;
		}

		[Token(Token = "0x6000C8B")]
		protected CustomConverter()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	public sealed class ArrayConverter<T> : CustomConverter<T[]>
	{
		[Token(Token = "0x6000C95")]
		public override T[] Convert(string input)
		{
			return null;
		}

		[Token(Token = "0x6000C96")]
		public ArrayConverter()
		{
		}
	}
	[Token(Token = "0x20001CC")]
	public class Color32Converter : CustomConverter<Color32>
	{
		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0xA77AA0", Offset = "0xA77AA0", VA = "0xA77AA0", Slot = "6")]
		public override Color32 Convert(string input)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0xA782F4", Offset = "0xA782F4", VA = "0xA782F4")]
		public Color32Converter()
		{
		}
	}
	[Token(Token = "0x20001CD")]
	public sealed class ColorConverter : CustomConverter<Color>
	{
		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0xA7833C", Offset = "0xA7833C", VA = "0xA7833C", Slot = "6")]
		public override Color Convert(string input)
		{
			return default(Color);
		}

		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0xA787D8", Offset = "0xA787D8", VA = "0xA787D8")]
		public static string ColorToHex(Color color)
		{
			return null;
		}

		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0xA7872C", Offset = "0xA7872C", VA = "0xA7872C")]
		public static Color HexToColor(string hex)
		{
			return default(Color);
		}

		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0xA78884", Offset = "0xA78884", VA = "0xA78884")]
		public ColorConverter()
		{
		}
	}
	[Token(Token = "0x20001CE")]
	public sealed class DictionaryConverter<TKey, TValue> : CustomConverter<Dictionary<TKey, TValue>>
	{
		[Token(Token = "0x6000CA0")]
		public override Dictionary<TKey, TValue> Convert(string input)
		{
			return null;
		}

		[Token(Token = "0x6000CA1")]
		public DictionaryConverter()
		{
		}
	}
	[Token(Token = "0x20001CF")]
	public sealed class ListConverter<T> : CustomConverter<List<T>>
	{
		[Token(Token = "0x6000CA2")]
		public override List<T> Convert(string input)
		{
			return null;
		}

		[Token(Token = "0x6000CA3")]
		public ListConverter()
		{
		}
	}
	[Token(Token = "0x20001D1")]
	public class ObjectConverter : CustomConverter<object>
	{
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0xA788CC", Offset = "0xA788CC", VA = "0xA788CC", Slot = "6")]
		public override object Convert(string input)
		{
			return null;
		}

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0xA78C1C", Offset = "0xA78C1C", VA = "0xA78C1C")]
		public ObjectConverter()
		{
		}
	}
	[Token(Token = "0x20001D2")]
	public sealed class RectConverter : CustomConverter<Rect>
	{
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0xA78C64", Offset = "0xA78C64", VA = "0xA78C64", Slot = "6")]
		public override Rect Convert(string input)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0xA78EE0", Offset = "0xA78EE0", VA = "0xA78EE0")]
		public RectConverter()
		{
		}
	}
	[Token(Token = "0x20001D3")]
	public sealed class Vector2Converter : CustomConverter<Vector2>
	{
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0xA78F28", Offset = "0xA78F28", VA = "0xA78F28", Slot = "6")]
		public override Vector2 Convert(string input)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0xA7913C", Offset = "0xA7913C", VA = "0xA7913C")]
		public Vector2Converter()
		{
		}
	}
	[Token(Token = "0x20001D4")]
	public sealed class Vector3Converter : CustomConverter<Vector3>
	{
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0xA79184", Offset = "0xA79184", VA = "0xA79184", Slot = "6")]
		public override Vector3 Convert(string input)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0xA793B8", Offset = "0xA793B8", VA = "0xA793B8")]
		public Vector3Converter()
		{
		}
	}
	[Token(Token = "0x20001D5")]
	public sealed class Vector4Converter : CustomConverter<Vector4>
	{
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0xA79400", Offset = "0xA79400", VA = "0xA79400", Slot = "6")]
		public override Vector4 Convert(string input)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0xA7965C", Offset = "0xA7965C", VA = "0xA7965C")]
		public Vector4Converter()
		{
		}
	}
	[Token(Token = "0x20001D6")]
	public static class Extensions
	{
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0xA796A4", Offset = "0xA796A4", VA = "0xA796A4")]
		public static object Convert(this Cell cell, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000CB2")]
		public static T Convert<T>(this Cell cell)
		{
			return (T)null;
		}

		[Token(Token = "0x6000CB3")]
		public static T Convert<T>(this Row row, IGenerator<T> generator) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000CB4")]
		public static T Convert<T>(this Row row, string expression) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000CB5")]
		public static T Convert<T>(this Row row, IEnumerable<Cell> cols) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0xA79AA8", Offset = "0xA79AA8", VA = "0xA79AA8")]
		public static object Convert(this Row row, Type type, string expression)
		{
			return null;
		}

		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0xA79BE8", Offset = "0xA79BE8", VA = "0xA79BE8")]
		public static object Convert(this Row row, Type type, IEnumerable<Cell> cols)
		{
			return null;
		}

		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0xA79B44", Offset = "0xA79B44", VA = "0xA79B44")]
		public static object Convert(this Row row, IGenerator generator)
		{
			return null;
		}

		[Token(Token = "0x6000CB9")]
		public static IEnumerable<T> Convert<T>(this Table table) where T : new()
		{
			return null;
		}

		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0xA79C84", Offset = "0xA79C84", VA = "0xA79C84")]
		public static IEnumerable<object> Convert(this Table table, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000CBB")]
		public static IEnumerable<T> Convert<T>(this Table table, ITableGenerator<T> generator) where T : new()
		{
			return null;
		}

		[Token(Token = "0x6000CBC")]
		public static IEnumerable<T> Convert<T>(this Table table, int row) where T : new()
		{
			return null;
		}

		[Token(Token = "0x6000CBD")]
		public static IEnumerable<T> Convert<T>(this Table table, string expression, params int[] exclude) where T : new()
		{
			return null;
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0xA79DAC", Offset = "0xA79DAC", VA = "0xA79DAC")]
		public static IEnumerable<object> Convert(this Table table, Type type, string expression, params int[] exclude)
		{
			return null;
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0xA79D08", Offset = "0xA79D08", VA = "0xA79D08")]
		public static IEnumerable<object> Convert(this Table table, ITableGenerator generator)
		{
			return null;
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0xA79E8C", Offset = "0xA79E8C", VA = "0xA79E8C")]
		public static IEnumerable<object> Convert(this Table table, Type type, int row)
		{
			return null;
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0xA7A074", Offset = "0xA7A074", VA = "0xA7A074")]
		public static string Dump(this Row row, char delimiter, char enclose)
		{
			return null;
		}

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0xA7A210", Offset = "0xA7A210", VA = "0xA7A210")]
		public static string Dump(this Row row)
		{
			return null;
		}

		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0xA7A274", Offset = "0xA7A274", VA = "0xA7A274")]
		public static string Dump(this Cell cell, char delimiter, char enclose)
		{
			return null;
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0xA7A3B8", Offset = "0xA7A3B8", VA = "0xA7A3B8")]
		public static string Dump(this Cell cell)
		{
			return null;
		}

		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0xA7A41C", Offset = "0xA7A41C", VA = "0xA7A41C")]
		public static string Dump(this Table table, char delimiter, char enclose)
		{
			return null;
		}

		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0xA7A5FC", Offset = "0xA7A5FC", VA = "0xA7A5FC")]
		public static string Dump(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0xA7A660", Offset = "0xA7A660", VA = "0xA7A660")]
		public static Cell Select(this Row row, string address)
		{
			return null;
		}

		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0xA7A968", Offset = "0xA7A968", VA = "0xA7A968")]
		public static IEnumerable<Cell> SelectRange(this Row row, string range)
		{
			return null;
		}

		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0xA7ABD4", Offset = "0xA7ABD4", VA = "0xA7ABD4")]
		public static Cell Select(this Table table, string address)
		{
			return null;
		}

		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0xA7ADE0", Offset = "0xA7ADE0", VA = "0xA7ADE0")]
		public static IEnumerable<Cell> SelectRange(this Table table, string range)
		{
			return null;
		}

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0xA7AE70", Offset = "0xA7AE70", VA = "0xA7AE70")]
		public static Cell Select(this WorkBook book, string path)
		{
			return null;
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0xA7B018", Offset = "0xA7B018", VA = "0xA7B018")]
		public static IEnumerable<Cell> SelectRange(this WorkBook book, string path)
		{
			return null;
		}

		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0xA7B1C0", Offset = "0xA7B1C0", VA = "0xA7B1C0")]
		public static void Recalculate(this Table table)
		{
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0xA7B30C", Offset = "0xA7B30C", VA = "0xA7B30C")]
		public static Table Expand(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0xA7B5C4", Offset = "0xA7B5C4", VA = "0xA7B5C4")]
		public static Table Collapse(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0xA7B960", Offset = "0xA7B960", VA = "0xA7B960")]
		public static Table Rotate(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0xA7BC94", Offset = "0xA7BC94", VA = "0xA7BC94")]
		public static bool IsEmpty(this Row row)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001DE")]
	public interface IConverter
	{
		[Token(Token = "0x17000111")]
		Type Type
		{
			[Token(Token = "0x6000CE6")]
			get;
		}

		[Token(Token = "0x6000CE5")]
		object Convert(string input);
	}
	[Token(Token = "0x20001DF")]
	public static class Validator
	{
		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0xA7C074", Offset = "0xA7C074", VA = "0xA7C074")]
		public static bool CanCast(Type from, Type to)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0xA7C2FC", Offset = "0xA7C2FC", VA = "0xA7C2FC")]
		private static bool HasImplicitConversion(Type definedOn, Type baseType, Type targetType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0xA7C1C8", Offset = "0xA7C1C8", VA = "0xA7C1C8")]
		public static bool HasImplicitConversion(Type source, Type target)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001E1")]
	public static class ValueConverter
	{
		[Token(Token = "0x20001E2")]
		private class Converter<T> : IConverter
		{
			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Converter<string, T> _converter;

			[Token(Token = "0x17000112")]
			private Type FlexFramework.Excel.IConverter.Type
			{
				[Token(Token = "0x6000CF9")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CF8")]
			public Converter(Converter<string, T> converter)
			{
			}

			[Token(Token = "0x6000CFA")]
			private object FlexFramework.Excel.IConverter.Convert(string input)
			{
				return null;
			}
		}

		[Token(Token = "0x20001E3")]
		private class Converter : IConverter
		{
			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Converter<string, object> _converter;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Type _type;

			[Token(Token = "0x17000113")]
			private Type FlexFramework.Excel.IConverter.Type
			{
				[Token(Token = "0x6000CFC")]
				[Address(RVA = "0xA7D570", Offset = "0xA7D570", VA = "0xA7D570", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CFB")]
			[Address(RVA = "0xA7D394", Offset = "0xA7D394", VA = "0xA7D394")]
			public Converter(Converter<string, object> converter, Type type)
			{
			}

			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0xA7D578", Offset = "0xA7D578", VA = "0xA7D578", Slot = "4")]
			private object FlexFramework.Excel.IConverter.Convert(string input)
			{
				return null;
			}
		}

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<IConverter> converters;

		[Token(Token = "0x6000CED")]
		[Address(RVA = "0xA7C5EC", Offset = "0xA7C5EC", VA = "0xA7C5EC")]
		static ValueConverter()
		{
		}

		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0xA7C678", Offset = "0xA7C678", VA = "0xA7C678")]
		public static void Reset()
		{
		}

		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0xA7D258", Offset = "0xA7D258", VA = "0xA7D258")]
		public static void Empty()
		{
		}

		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0xA79720", Offset = "0xA79720", VA = "0xA79720")]
		public static object Convert(Type type, string value)
		{
			return null;
		}

		[Token(Token = "0x6000CF1")]
		public static T Convert<T>(string value)
		{
			return (T)null;
		}

		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0xA7D0C8", Offset = "0xA7D0C8", VA = "0xA7D0C8")]
		public static bool Register(IConverter converter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CF3")]
		public static bool Register<T>() where T : IConverter, new()
		{
			return default(bool);
		}

		[Token(Token = "0x6000CF4")]
		public static bool Register<T>(Converter<string, T> converter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0xA7D300", Offset = "0xA7D300", VA = "0xA7D300")]
		public static bool Register(Converter<string, object> converter, Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0xA7D458", Offset = "0xA7D458", VA = "0xA7D458")]
		public static bool Unregister(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CF7")]
		public static bool Unregister<T>()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001E7")]
	public struct Address : IEquatable<Address>
	{
		[Token(Token = "0x17000114")]
		public int Column
		{
			[Token(Token = "0x6000D07")]
			[Address(RVA = "0xA7D974", Offset = "0xA7D974", VA = "0xA7D974")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000D08")]
			[Address(RVA = "0xA7D97C", Offset = "0xA7D97C", VA = "0xA7D97C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000115")]
		public int Row
		{
			[Token(Token = "0x6000D09")]
			[Address(RVA = "0xA7D984", Offset = "0xA7D984", VA = "0xA7D984")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000D0A")]
			[Address(RVA = "0xA7D98C", Offset = "0xA7D98C", VA = "0xA7D98C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public string ColumnName
		{
			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0xA7DB74", Offset = "0xA7DB74", VA = "0xA7DB74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D04")]
		[Address(RVA = "0xA7D8AC", Offset = "0xA7D8AC", VA = "0xA7D8AC", Slot = "4")]
		private bool System.IEquatable<FlexFramework.Excel.Address>.Equals(Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D05")]
		[Address(RVA = "0xA7D8D4", Offset = "0xA7D8D4", VA = "0xA7D8D4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D06")]
		[Address(RVA = "0xA7D960", Offset = "0xA7D960", VA = "0xA7D960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0xA7A808", Offset = "0xA7A808", VA = "0xA7A808")]
		public Address(string address)
		{
		}

		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0xA7B304", Offset = "0xA7B304", VA = "0xA7B304")]
		public Address(int column, int row)
		{
		}

		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0xA7DCA8", Offset = "0xA7DCA8", VA = "0xA7DCA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0xA7BFBC", Offset = "0xA7BFBC", VA = "0xA7BFBC")]
		public static bool operator ==(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D10")]
		[Address(RVA = "0xA7DD3C", Offset = "0xA7DD3C", VA = "0xA7DD3C")]
		public static bool operator !=(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D11")]
		[Address(RVA = "0xA7DD5C", Offset = "0xA7DD5C", VA = "0xA7DD5C")]
		public static bool operator >=(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D12")]
		[Address(RVA = "0xA7DD7C", Offset = "0xA7DD7C", VA = "0xA7DD7C")]
		public static bool operator <=(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D13")]
		[Address(RVA = "0xA7DD9C", Offset = "0xA7DD9C", VA = "0xA7DD9C")]
		public static bool operator >(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D14")]
		[Address(RVA = "0xA7DDBC", Offset = "0xA7DDBC", VA = "0xA7DDBC")]
		public static bool operator <(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D15")]
		[Address(RVA = "0xA7DDDC", Offset = "0xA7DDDC", VA = "0xA7DDDC")]
		public static Range operator +(Address from, Address to)
		{
			return default(Range);
		}

		[Token(Token = "0x6000D16")]
		[Address(RVA = "0xA7DE7C", Offset = "0xA7DE7C", VA = "0xA7DE7C")]
		public static Address operator >>(Address address, int column)
		{
			return default(Address);
		}

		[Token(Token = "0x6000D17")]
		[Address(RVA = "0xA7DE8C", Offset = "0xA7DE8C", VA = "0xA7DE8C")]
		public static Address operator <<(Address address, int column)
		{
			return default(Address);
		}

		[Token(Token = "0x6000D18")]
		[Address(RVA = "0xA7DE9C", Offset = "0xA7DE9C", VA = "0xA7DE9C")]
		public static Address operator +(Address address, int row)
		{
			return default(Address);
		}

		[Token(Token = "0x6000D19")]
		[Address(RVA = "0xA7DEAC", Offset = "0xA7DEAC", VA = "0xA7DEAC")]
		public static Address operator -(Address address, int row)
		{
			return default(Address);
		}

		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0xA7DB7C", Offset = "0xA7DB7C", VA = "0xA7DB7C")]
		public static string ParseColumn(int column)
		{
			return null;
		}

		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0xA7D994", Offset = "0xA7D994", VA = "0xA7D994")]
		public static int ParseColumn(string column)
		{
			return default(int);
		}

		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0xA7A798", Offset = "0xA7A798", VA = "0xA7A798")]
		public static bool IsValid(string address)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001E8")]
	public class Cell : ICloneable<Cell>
	{
		[Token(Token = "0x17000117")]
		public Address Address
		{
			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0xA7DEBC", Offset = "0xA7DEBC", VA = "0xA7DEBC")]
			[CompilerGenerated]
			get
			{
				return default(Address);
			}
			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0xA7DEC4", Offset = "0xA7DEC4", VA = "0xA7DEC4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public object Value
		{
			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0xA7DECC", Offset = "0xA7DECC", VA = "0xA7DECC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D20")]
			[Address(RVA = "0xA7DED4", Offset = "0xA7DED4", VA = "0xA7DED4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public bool IsSpan
		{
			[Token(Token = "0x6000D21")]
			[Address(RVA = "0xA7DEDC", Offset = "0xA7DEDC", VA = "0xA7DEDC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D22")]
			[Address(RVA = "0xA7DEE4", Offset = "0xA7DEE4", VA = "0xA7DEE4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public virtual string Text
		{
			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0xA7E1C0", Offset = "0xA7E1C0", VA = "0xA7E1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011B")]
		public string String
		{
			[Token(Token = "0x6000D2C")]
			[Address(RVA = "0xA7E244", Offset = "0xA7E244", VA = "0xA7E244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		public int Integer
		{
			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0xA7E358", Offset = "0xA7E358", VA = "0xA7E358")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700011D")]
		public bool Boolean
		{
			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0xA7E474", Offset = "0xA7E474", VA = "0xA7E474")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011E")]
		public float Single
		{
			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0xA7E590", Offset = "0xA7E590", VA = "0xA7E590")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700011F")]
		public double Double
		{
			[Token(Token = "0x6000D30")]
			[Address(RVA = "0xA7E6AC", Offset = "0xA7E6AC", VA = "0xA7E6AC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000120")]
		public bool IsInteger
		{
			[Token(Token = "0x6000D31")]
			[Address(RVA = "0xA7E414", Offset = "0xA7E414", VA = "0xA7E414")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000121")]
		public bool IsSingle
		{
			[Token(Token = "0x6000D32")]
			[Address(RVA = "0xA7E64C", Offset = "0xA7E64C", VA = "0xA7E64C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000122")]
		public bool IsDouble
		{
			[Token(Token = "0x6000D33")]
			[Address(RVA = "0xA7E768", Offset = "0xA7E768", VA = "0xA7E768")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000123")]
		public bool IsBoolean
		{
			[Token(Token = "0x6000D34")]
			[Address(RVA = "0xA7E530", Offset = "0xA7E530", VA = "0xA7E530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000124")]
		public bool IsString
		{
			[Token(Token = "0x6000D35")]
			[Address(RVA = "0xA7E2F8", Offset = "0xA7E2F8", VA = "0xA7E2F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000D23")]
		[Address(RVA = "0xA7B5BC", Offset = "0xA7B5BC", VA = "0xA7B5BC")]
		public Cell()
		{
		}

		[Token(Token = "0x6000D24")]
		[Address(RVA = "0xA7DEF0", Offset = "0xA7DEF0", VA = "0xA7DEF0")]
		public Cell(Address address)
		{
		}

		[Token(Token = "0x6000D25")]
		[Address(RVA = "0xA7DF18", Offset = "0xA7DF18", VA = "0xA7DF18")]
		public Cell(string value, Address address)
		{
		}

		[Token(Token = "0x6000D26")]
		[Address(RVA = "0xA7DF44", Offset = "0xA7DF44", VA = "0xA7DF44")]
		public Cell(bool value, Address address)
		{
		}

		[Token(Token = "0x6000D27")]
		[Address(RVA = "0xA7DFC0", Offset = "0xA7DFC0", VA = "0xA7DFC0")]
		public Cell(int value, Address address)
		{
		}

		[Token(Token = "0x6000D28")]
		[Address(RVA = "0xA7E03C", Offset = "0xA7E03C", VA = "0xA7E03C")]
		public Cell(long value, Address address)
		{
		}

		[Token(Token = "0x6000D29")]
		[Address(RVA = "0xA7E0B8", Offset = "0xA7E0B8", VA = "0xA7E0B8")]
		public Cell(float value, Address address)
		{
		}

		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0xA7E13C", Offset = "0xA7E13C", VA = "0xA7E13C")]
		public Cell(double value, Address address)
		{
		}

		[Token(Token = "0x6000D36")]
		[Address(RVA = "0xA7E7C8", Offset = "0xA7E7C8", VA = "0xA7E7C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000D37")]
		[Address(RVA = "0xA7E7D4", Offset = "0xA7E7D4", VA = "0xA7E7D4", Slot = "4")]
		public Cell DeepClone()
		{
			return null;
		}

		[Token(Token = "0x6000D38")]
		[Address(RVA = "0xA7E854", Offset = "0xA7E854", VA = "0xA7E854", Slot = "5")]
		public Cell ShallowClone()
		{
			return null;
		}

		[Token(Token = "0x6000D39")]
		[Address(RVA = "0xA7E8D4", Offset = "0xA7E8D4", VA = "0xA7E8D4")]
		public static implicit operator string(Cell cell)
		{
			return null;
		}

		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0xA7E8E4", Offset = "0xA7E8E4", VA = "0xA7E8E4")]
		public static implicit operator int(Cell cell)
		{
			return default(int);
		}

		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0xA7E8F4", Offset = "0xA7E8F4", VA = "0xA7E8F4")]
		public static implicit operator bool(Cell cell)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0xA7E904", Offset = "0xA7E904", VA = "0xA7E904")]
		public static implicit operator float(Cell cell)
		{
			return default(float);
		}

		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0xA7E914", Offset = "0xA7E914", VA = "0xA7E914")]
		public static implicit operator double(Cell cell)
		{
			return default(double);
		}
	}
	[Token(Token = "0x20001E9")]
	public interface ICloneable<T> where T : class
	{
		[Token(Token = "0x6000D3E")]
		T DeepClone();

		[Token(Token = "0x6000D3F")]
		T ShallowClone();
	}
	[Token(Token = "0x20001EA")]
	public struct Range : IEquatable<Range>
	{
		[Token(Token = "0x17000125")]
		public Address From
		{
			[Token(Token = "0x6000D43")]
			[Address(RVA = "0xA7EA24", Offset = "0xA7EA24", VA = "0xA7EA24")]
			[CompilerGenerated]
			readonly get
			{
				return default(Address);
			}
			[Token(Token = "0x6000D44")]
			[Address(RVA = "0xA7EA2C", Offset = "0xA7EA2C", VA = "0xA7EA2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public Address To
		{
			[Token(Token = "0x6000D45")]
			[Address(RVA = "0xA7EA34", Offset = "0xA7EA34", VA = "0xA7EA34")]
			[CompilerGenerated]
			readonly get
			{
				return default(Address);
			}
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0xA7EA3C", Offset = "0xA7EA3C", VA = "0xA7EA3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000D40")]
		[Address(RVA = "0xA7E924", Offset = "0xA7E924", VA = "0xA7E924", Slot = "4")]
		public bool Equals(Range other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D41")]
		[Address(RVA = "0xA7E98C", Offset = "0xA7E98C", VA = "0xA7E98C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D42")]
		[Address(RVA = "0xA7E9FC", Offset = "0xA7E9FC", VA = "0xA7E9FC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000D47")]
		[Address(RVA = "0xA7DE08", Offset = "0xA7DE08", VA = "0xA7DE08")]
		public Range(Address from, Address to)
		{
		}

		[Token(Token = "0x6000D48")]
		[Address(RVA = "0xA7AA68", Offset = "0xA7AA68", VA = "0xA7AA68")]
		public Range(string range)
		{
		}

		[Token(Token = "0x6000D49")]
		[Address(RVA = "0xA7EA44", Offset = "0xA7EA44", VA = "0xA7EA44")]
		public bool Contains(Address address)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0xA7EA84", Offset = "0xA7EA84", VA = "0xA7EA84")]
		public bool Contains(Range range)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0xA7EAC8", Offset = "0xA7EAC8", VA = "0xA7EAC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0xA7EB70", Offset = "0xA7EB70", VA = "0xA7EB70")]
		public static bool operator ==(Range range, Range other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0xA7EBB0", Offset = "0xA7EBB0", VA = "0xA7EBB0")]
		public static bool operator !=(Range range, Range other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0xA7A9F8", Offset = "0xA7A9F8", VA = "0xA7A9F8")]
		public static bool IsValid(string range)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001EB")]
	public class Row : ReadOnlyCollection<Cell>, ICloneable<Row>
	{
		[Token(Token = "0x17000127")]
		public IList<Cell> Cells
		{
			[Token(Token = "0x6000D4F")]
			[Address(RVA = "0xA7EBF0", Offset = "0xA7EBF0", VA = "0xA7EBF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		public Cell this[string address]
		{
			[Token(Token = "0x6000D50")]
			[Address(RVA = "0xA7EC2C", Offset = "0xA7EC2C", VA = "0xA7EC2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000129")]
		public Cell this[Address address]
		{
			[Token(Token = "0x6000D51")]
			[Address(RVA = "0xA7ECB4", Offset = "0xA7ECB4", VA = "0xA7ECB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		public IEnumerable<Cell> this[Range range]
		{
			[Token(Token = "0x6000D52")]
			[Address(RVA = "0xA7ED90", Offset = "0xA7ED90", VA = "0xA7ED90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D53")]
		[Address(RVA = "0xA7EE70", Offset = "0xA7EE70", VA = "0xA7EE70")]
		public Row(IList<Cell> list)
		{
		}

		[Token(Token = "0x6000D54")]
		[Address(RVA = "0xA7EEC8", Offset = "0xA7EEC8", VA = "0xA7EEC8")]
		public Row()
		{
		}

		[Token(Token = "0x6000D55")]
		[Address(RVA = "0xA7EF58", Offset = "0xA7EF58", VA = "0xA7EF58", Slot = "35")]
		public Row DeepClone()
		{
			return null;
		}

		[Token(Token = "0x6000D56")]
		[Address(RVA = "0xA7F0B8", Offset = "0xA7F0B8", VA = "0xA7F0B8", Slot = "36")]
		public Row ShallowClone()
		{
			return null;
		}
	}
	[Token(Token = "0x20001EF")]
	public abstract class Table : ReadOnlyCollection<Row>, ICloneable<Table>
	{
		[Token(Token = "0x1700012B")]
		public IList<Row> Rows
		{
			[Token(Token = "0x6000D5F")]
			[Address(RVA = "0xA7F258", Offset = "0xA7F258", VA = "0xA7F258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		public Cell this[string address]
		{
			[Token(Token = "0x6000D60")]
			[Address(RVA = "0xA7F294", Offset = "0xA7F294", VA = "0xA7F294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012D")]
		public Cell this[Address address]
		{
			[Token(Token = "0x6000D61")]
			[Address(RVA = "0xA7F31C", Offset = "0xA7F31C", VA = "0xA7F31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012E")]
		public IEnumerable<Cell> this[Range range]
		{
			[Token(Token = "0x6000D62")]
			[Address(RVA = "0xA7F4C4", Offset = "0xA7F4C4", VA = "0xA7F4C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0xA7F200", Offset = "0xA7F200", VA = "0xA7F200")]
		public Table(IList<Row> list)
		{
		}

		[Token(Token = "0x6000D63")]
		public abstract Table DeepClone();

		[Token(Token = "0x6000D64")]
		public abstract Table ShallowClone();
	}
	[Token(Token = "0x20001F3")]
	public sealed class Document : Table
	{
		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static char Delimiter;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static char Enclose;

		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0xA7F730", Offset = "0xA7F730", VA = "0xA7F730")]
		public Document(IList<Row> list)
		{
		}

		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0xA7F734", Offset = "0xA7F734", VA = "0xA7F734")]
		public Document()
		{
		}

		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0xA7F7AC", Offset = "0xA7F7AC", VA = "0xA7F7AC")]
		public static Document LoadAt(string path)
		{
			return null;
		}

		[Token(Token = "0x6000D70")]
		[Address(RVA = "0xA7F814", Offset = "0xA7F814", VA = "0xA7F814")]
		public static Document Load(string content)
		{
			return null;
		}

		[Token(Token = "0x6000D71")]
		[Address(RVA = "0xA80090", Offset = "0xA80090", VA = "0xA80090")]
		public static Document Load(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000D72")]
		[Address(RVA = "0xA80118", Offset = "0xA80118", VA = "0xA80118")]
		public static Document Load(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6000D73")]
		[Address(RVA = "0xA7F9D0", Offset = "0xA7F9D0", VA = "0xA7F9D0")]
		public static Document Load(TextReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000D74")]
		[Address(RVA = "0xA802D4", Offset = "0xA802D4", VA = "0xA802D4")]
		public static void Reset()
		{
		}

		[Token(Token = "0x6000D75")]
		[Address(RVA = "0xA80334", Offset = "0xA80334", VA = "0xA80334", Slot = "37")]
		public override Table DeepClone()
		{
			return null;
		}

		[Token(Token = "0x6000D76")]
		[Address(RVA = "0xA80494", Offset = "0xA80494", VA = "0xA80494", Slot = "38")]
		public override Table ShallowClone()
		{
			return null;
		}
	}
	[Token(Token = "0x20001F5")]
	public sealed class SharedStringCollection : ReadOnlyCollection<string>
	{
		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0xA805E4", Offset = "0xA805E4", VA = "0xA805E4")]
		public SharedStringCollection(IList<string> list)
		{
		}
	}
	[Token(Token = "0x20001F6")]
	public sealed class WorkBook : KeyedCollection<string, WorkSheet>
	{
		[Token(Token = "0x1700012F")]
		public SharedStringCollection SharedStrings
		{
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0xA8063C", Offset = "0xA8063C", VA = "0xA8063C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0xA80644", Offset = "0xA80644", VA = "0xA80644")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0xA8064C", Offset = "0xA8064C", VA = "0xA8064C")]
		public WorkBook(byte[] buffer)
		{
		}

		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0xA8219C", Offset = "0xA8219C", VA = "0xA8219C")]
		public WorkBook(Stream stream)
		{
		}

		[Token(Token = "0x6000D80")]
		[Address(RVA = "0xA82230", Offset = "0xA82230", VA = "0xA82230")]
		public WorkBook(string fileName)
		{
		}

		[Token(Token = "0x6000D81")]
		[Address(RVA = "0xA8082C", Offset = "0xA8082C", VA = "0xA8082C")]
		private void Read(ZipFile zip)
		{
		}

		[Token(Token = "0x6000D82")]
		[Address(RVA = "0xA82490", Offset = "0xA82490", VA = "0xA82490", Slot = "39")]
		protected override string GetKeyForItem(WorkSheet item)
		{
			return null;
		}

		[Token(Token = "0x6000D83")]
		[Address(RVA = "0xA824A8", Offset = "0xA824A8", VA = "0xA824A8")]
		public void Merge()
		{
		}
	}
	[Token(Token = "0x20001F8")]
	public sealed class WorkSheet : Table
	{
		[Token(Token = "0x17000130")]
		public string ID
		{
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0xA831A4", Offset = "0xA831A4", VA = "0xA831A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D88")]
			[Address(RVA = "0xA831AC", Offset = "0xA831AC", VA = "0xA831AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public string Name
		{
			[Token(Token = "0x6000D89")]
			[Address(RVA = "0xA831B4", Offset = "0xA831B4", VA = "0xA831B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D8A")]
			[Address(RVA = "0xA831BC", Offset = "0xA831BC", VA = "0xA831BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public ReadOnlyCollection<Range> Spans
		{
			[Token(Token = "0x6000D8B")]
			[Address(RVA = "0xA831C4", Offset = "0xA831C4", VA = "0xA831C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D8C")]
			[Address(RVA = "0xA831CC", Offset = "0xA831CC", VA = "0xA831CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0xA831D4", Offset = "0xA831D4", VA = "0xA831D4")]
		public WorkSheet(string id, string name, IList<Row> rows)
		{
		}

		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0xA823E8", Offset = "0xA823E8", VA = "0xA823E8")]
		public WorkSheet(string id, string name, IList<Row> rows, IList<Range> spans)
		{
		}

		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0xA82720", Offset = "0xA82720", VA = "0xA82720")]
		public void Merge()
		{
		}

		[Token(Token = "0x6000D90")]
		[Address(RVA = "0xA83200", Offset = "0xA83200", VA = "0xA83200", Slot = "37")]
		public override Table DeepClone()
		{
			return null;
		}

		[Token(Token = "0x6000D91")]
		[Address(RVA = "0xA833A8", Offset = "0xA833A8", VA = "0xA833A8", Slot = "38")]
		public override Table ShallowClone()
		{
			return null;
		}
	}
	[Token(Token = "0x20001FA")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false)]
	public sealed class ColumnAttribute : Attribute
	{
		[Token(Token = "0x17000133")]
		public int Column
		{
			[Token(Token = "0x6000D96")]
			[Address(RVA = "0xA834C0", Offset = "0xA834C0", VA = "0xA834C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000D97")]
			[Address(RVA = "0xA834C8", Offset = "0xA834C8", VA = "0xA834C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public object Default
		{
			[Token(Token = "0x6000D98")]
			[Address(RVA = "0xA834D0", Offset = "0xA834D0", VA = "0xA834D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D99")]
			[Address(RVA = "0xA834D8", Offset = "0xA834D8", VA = "0xA834D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public bool Fallback
		{
			[Token(Token = "0x6000D9A")]
			[Address(RVA = "0xA834E0", Offset = "0xA834E0", VA = "0xA834E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D9B")]
			[Address(RVA = "0xA834E8", Offset = "0xA834E8", VA = "0xA834E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0xA834F4", Offset = "0xA834F4", VA = "0xA834F4")]
		public ColumnAttribute(int column)
		{
		}

		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0xA8351C", Offset = "0xA8351C", VA = "0xA8351C")]
		public ColumnAttribute(int column, object @default)
		{
		}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0xA83554", Offset = "0xA83554", VA = "0xA83554")]
		public ColumnAttribute(string column)
		{
		}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0xA8358C", Offset = "0xA8358C", VA = "0xA8358C")]
		public ColumnAttribute(string column, object @default)
		{
		}
	}
	[Token(Token = "0x20001FB")]
	public interface IGenerator
	{
		[Token(Token = "0x6000DA0")]
		object Instantiate(Row row);
	}
	[Token(Token = "0x20001FC")]
	public interface IGenerator<T>
	{
		[Token(Token = "0x6000DA1")]
		T Instantiate(Row row);
	}
	[Token(Token = "0x20001FD")]
	public interface ITableGenerator
	{
		[Token(Token = "0x6000DA2")]
		IEnumerable<object> Instantiate(Table table);
	}
	[Token(Token = "0x20001FE")]
	public interface ITableGenerator<T>
	{
		[Token(Token = "0x6000DA3")]
		IEnumerable<T> Instantiate(Table table);
	}
	[Token(Token = "0x20001FF")]
	public sealed class Mapper<T> : MapperBase<Mapper<T>>, IGenerator<T> where T : new()
	{
		[Token(Token = "0x6000DA4")]
		public Mapper()
		{
		}

		[Token(Token = "0x6000DA5")]
		protected override object CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6000DA6")]
		private T FlexFramework.Excel.IGenerator<T>.Instantiate(Row row)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000200")]
	public sealed class Mapper : MapperBase<Mapper>, IGenerator
	{
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0xA835D4", Offset = "0xA835D4", VA = "0xA835D4")]
		public Mapper(Type type)
		{
		}

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0xA8362C", Offset = "0xA8362C", VA = "0xA8362C", Slot = "8")]
		private object FlexFramework.Excel.IGenerator.Instantiate(Row row)
		{
			return null;
		}
	}
	[Token(Token = "0x2000201")]
	public abstract class MapperBase<T> where T : MapperBase<T>
	{
		[Token(Token = "0x2000203")]
		[CompilerGenerated]
		private sealed class <Cast>d__11 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MapperBase<T> <>4__this;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Row row;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Row <>3__row;

			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<Mapping> <>7__wrap1;

			[Token(Token = "0x17000137")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000DC8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000138")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000DCA")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000DC4")]
			[DebuggerHidden]
			public <Cast>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000DC5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000DC6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000DC7")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000DC9")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000DCB")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000DCC")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Mapping[] mappings;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Type type;

		[Token(Token = "0x17000136")]
		public bool SafeMode
		{
			[Token(Token = "0x6000DA9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DAA")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000DAB")]
		protected MapperBase(Type type)
		{
		}

		[Token(Token = "0x6000DAC")]
		protected virtual MemberInfo[] GetMembers()
		{
			return null;
		}

		[Token(Token = "0x6000DAD")]
		protected virtual object CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6000DAE")]
		protected virtual void Assign(object obj, MemberInfo[] members, object[] data)
		{
		}

		[Token(Token = "0x6000DAF")]
		public virtual void Extract()
		{
		}

		[Token(Token = "0x6000DB0")]
		[IteratorStateMachine(typeof(MapperBase<>.<Cast>d__11))]
		protected IEnumerable<object> Cast(Row row)
		{
			return null;
		}

		[Token(Token = "0x6000DB1")]
		public T Map(string member, int column)
		{
			return null;
		}

		[Token(Token = "0x6000DB2")]
		public T Map(string member, int column, object @default)
		{
			return null;
		}

		[Token(Token = "0x6000DB3")]
		public T Map(string member, string column)
		{
			return null;
		}

		[Token(Token = "0x6000DB4")]
		public T Map(string member, string column, object @default)
		{
			return null;
		}

		[Token(Token = "0x6000DB5")]
		public T Map(string expression)
		{
			return null;
		}

		[Token(Token = "0x6000DB6")]
		public T Map(IEnumerable<Cell> row)
		{
			return null;
		}

		[Token(Token = "0x6000DB7")]
		public T Remove(string member)
		{
			return null;
		}

		[Token(Token = "0x6000DB8")]
		public T Clear()
		{
			return null;
		}

		[Token(Token = "0x6000DB9")]
		public T Copy(T mapping)
		{
			return null;
		}

		[Token(Token = "0x6000DBA")]
		protected object Instantiate(Row row)
		{
			return null;
		}
	}
	[Token(Token = "0x2000208")]
	public class Mapping
	{
		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object _default;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _column;

		[Token(Token = "0x17000139")]
		public MemberInfo Member
		{
			[Token(Token = "0x6000DD5")]
			[Address(RVA = "0xA83684", Offset = "0xA83684", VA = "0xA83684")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DD6")]
			[Address(RVA = "0xA8368C", Offset = "0xA8368C", VA = "0xA8368C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public Type Type
		{
			[Token(Token = "0x6000DD7")]
			[Address(RVA = "0xA83694", Offset = "0xA83694", VA = "0xA83694")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0xA8369C", Offset = "0xA8369C", VA = "0xA8369C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public int Column
		{
			[Token(Token = "0x6000DD9")]
			[Address(RVA = "0xA836A4", Offset = "0xA836A4", VA = "0xA836A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000DDA")]
			[Address(RVA = "0xA836AC", Offset = "0xA836AC", VA = "0xA836AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public object Default
		{
			[Token(Token = "0x6000DDB")]
			[Address(RVA = "0xA8371C", Offset = "0xA8371C", VA = "0xA8371C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DDC")]
			[Address(RVA = "0xA83724", Offset = "0xA83724", VA = "0xA83724")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public bool Fallback
		{
			[Token(Token = "0x6000DDD")]
			[Address(RVA = "0xA837F8", Offset = "0xA837F8", VA = "0xA837F8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DDE")]
			[Address(RVA = "0xA83800", Offset = "0xA83800", VA = "0xA83800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public bool Failed
		{
			[Token(Token = "0x6000DDF")]
			[Address(RVA = "0xA8380C", Offset = "0xA8380C", VA = "0xA8380C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DE0")]
			[Address(RVA = "0xA83814", Offset = "0xA83814", VA = "0xA83814")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0xA83820", Offset = "0xA83820", VA = "0xA83820")]
		public Mapping(MemberInfo member)
		{
		}

		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0xA8396C", Offset = "0xA8396C", VA = "0xA8396C")]
		public Mapping(MemberInfo member, int column)
		{
		}

		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0xA83994", Offset = "0xA83994", VA = "0xA83994")]
		public Mapping(MemberInfo member, int column, object @default)
		{
		}
	}
	[Token(Token = "0x2000209")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	public sealed class TableAttribute : Attribute
	{
		[Token(Token = "0x1700013F")]
		public int[] Ignore
		{
			[Token(Token = "0x6000DE4")]
			[Address(RVA = "0xA83A84", Offset = "0xA83A84", VA = "0xA83A84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DE5")]
			[Address(RVA = "0xA83A8C", Offset = "0xA83A8C", VA = "0xA83A8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public bool SafeMode
		{
			[Token(Token = "0x6000DE6")]
			[Address(RVA = "0xA83A94", Offset = "0xA83A94", VA = "0xA83A94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DE7")]
			[Address(RVA = "0xA83A9C", Offset = "0xA83A9C", VA = "0xA83A9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0xA83AA8", Offset = "0xA83AA8", VA = "0xA83AA8")]
		public TableAttribute(params int[] ignore)
		{
		}
	}
	[Token(Token = "0x200020A")]
	public sealed class TableMapper<T> : TableMapperBase<TableMapper<T>>, IGenerator<T>, ITableGenerator<T> where T : new()
	{
		[Token(Token = "0x6000DE9")]
		public TableMapper()
		{
		}

		[Token(Token = "0x6000DEA")]
		protected override object CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6000DEB")]
		private T FlexFramework.Excel.IGenerator<T>.Instantiate(Row row)
		{
			return (T)null;
		}

		[Token(Token = "0x6000DEC")]
		private IEnumerable<T> FlexFramework.Excel.ITableGenerator<T>.Instantiate(Table table)
		{
			return null;
		}
	}
	[Token(Token = "0x200020B")]
	public sealed class TableMapper : TableMapperBase<TableMapper>, IGenerator, ITableGenerator
	{
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0xA83AD0", Offset = "0xA83AD0", VA = "0xA83AD0")]
		public TableMapper(Type type)
		{
		}

		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0xA83B28", Offset = "0xA83B28", VA = "0xA83B28", Slot = "8")]
		private object FlexFramework.Excel.IGenerator.Instantiate(Row row)
		{
			return null;
		}

		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0xA83B80", Offset = "0xA83B80", VA = "0xA83B80", Slot = "9")]
		private IEnumerable<object> FlexFramework.Excel.ITableGenerator.Instantiate(Table table)
		{
			return null;
		}
	}
	[Token(Token = "0x200020C")]
	public abstract class TableMapperBase<T> : MapperBase<T> where T : TableMapperBase<T>
	{
		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly List<int> excludes;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int index;

		[Token(Token = "0x6000DF4")]
		protected TableMapperBase(Type type)
		{
		}

		[Token(Token = "0x6000DF5")]
		public override void Extract()
		{
		}

		[Token(Token = "0x6000DF6")]
		public T Exclude(params int[] rows)
		{
			return null;
		}

		[Token(Token = "0x6000DF7")]
		public T Include(params int[] rows)
		{
			return null;
		}

		[Token(Token = "0x6000DF8")]
		public T IncludeAll()
		{
			return null;
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200020E")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0xA83D54", Offset = "0xA83D54", VA = "0xA83D54")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0xA83EF0", Offset = "0xA83EF0", VA = "0xA83EF0")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0xA84064", Offset = "0xA84064", VA = "0xA84064")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0xA841DC", Offset = "0xA841DC", VA = "0xA841DC")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0xA84244", Offset = "0xA84244", VA = "0xA84244")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000E00")]
		[Address(RVA = "0xA842AC", Offset = "0xA842AC", VA = "0xA842AC")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0xA84304", Offset = "0xA84304", VA = "0xA84304")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0xA8437C", Offset = "0xA8437C", VA = "0xA8437C")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0xA843D4", Offset = "0xA843D4", VA = "0xA843D4")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000E04")]
		[Address(RVA = "0xA8442C", Offset = "0xA8442C", VA = "0xA8442C")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000E05")]
		[Address(RVA = "0xA84484", Offset = "0xA84484", VA = "0xA84484")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000E06")]
		[Address(RVA = "0xA844DC", Offset = "0xA844DC", VA = "0xA844DC")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0xA8453C", Offset = "0xA8453C", VA = "0xA8453C")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000E08")]
		[Address(RVA = "0xA84598", Offset = "0xA84598", VA = "0xA84598")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000E09")]
		[Address(RVA = "0xA845F0", Offset = "0xA845F0", VA = "0xA845F0")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000212")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x6000E13")]
		[Address(RVA = "0xA84710", Offset = "0xA84710", VA = "0xA84710")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E14")]
		[Address(RVA = "0xA848B8", Offset = "0xA848B8", VA = "0xA848B8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E15")]
		[Address(RVA = "0xA84A54", Offset = "0xA84A54", VA = "0xA84A54")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E16")]
		[Address(RVA = "0xA84BF0", Offset = "0xA84BF0", VA = "0xA84BF0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E17")]
		[Address(RVA = "0xA84D8C", Offset = "0xA84D8C", VA = "0xA84D8C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000E18")]
		[Address(RVA = "0xA84F30", Offset = "0xA84F30", VA = "0xA84F30")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000E19")]
		[Address(RVA = "0xA85188", Offset = "0xA85188", VA = "0xA85188")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0xA85668", Offset = "0xA85668", VA = "0xA85668")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0xA858CC", Offset = "0xA858CC", VA = "0xA858CC")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0xA85B3C", Offset = "0xA85B3C", VA = "0xA85B3C")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0xA85D00", Offset = "0xA85D00", VA = "0xA85D00")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200021E")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0xA862F0", Offset = "0xA862F0", VA = "0xA862F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0xA86490", Offset = "0xA86490", VA = "0xA86490")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0xA86628", Offset = "0xA86628", VA = "0xA86628")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0xA867C0", Offset = "0xA867C0", VA = "0xA867C0")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0xA86940", Offset = "0xA86940", VA = "0xA86940")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000224")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0xA86EFC", Offset = "0xA86EFC", VA = "0xA86EFC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0xA87098", Offset = "0xA87098", VA = "0xA87098")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E50")]
		[Address(RVA = "0xA8720C", Offset = "0xA8720C", VA = "0xA8720C")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E51")]
		[Address(RVA = "0xA873E8", Offset = "0xA873E8", VA = "0xA873E8")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000228")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000229")]
		public static class Utils
		{
			[Token(Token = "0x6000E83")]
			[Address(RVA = "0xA8BA74", Offset = "0xA8BA74", VA = "0xA8BA74")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0xA876C8", Offset = "0xA876C8", VA = "0xA876C8")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0xA8783C", Offset = "0xA8783C", VA = "0xA8783C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0xA879D8", Offset = "0xA879D8", VA = "0xA879D8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0xA87B4C", Offset = "0xA87B4C", VA = "0xA87B4C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0xA87CE8", Offset = "0xA87CE8", VA = "0xA87CE8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E60")]
		[Address(RVA = "0xA87E5C", Offset = "0xA87E5C", VA = "0xA87E5C")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E61")]
		[Address(RVA = "0xA87FF4", Offset = "0xA87FF4", VA = "0xA87FF4")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E62")]
		[Address(RVA = "0xA881D8", Offset = "0xA881D8", VA = "0xA881D8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E63")]
		[Address(RVA = "0xA88374", Offset = "0xA88374", VA = "0xA88374")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E64")]
		[Address(RVA = "0xA88510", Offset = "0xA88510", VA = "0xA88510")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E65")]
		[Address(RVA = "0xA886AC", Offset = "0xA886AC", VA = "0xA886AC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E66")]
		[Address(RVA = "0xA88848", Offset = "0xA88848", VA = "0xA88848")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E67")]
		[Address(RVA = "0xA889BC", Offset = "0xA889BC", VA = "0xA889BC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E68")]
		[Address(RVA = "0xA88B40", Offset = "0xA88B40", VA = "0xA88B40")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E69")]
		[Address(RVA = "0xA88CDC", Offset = "0xA88CDC", VA = "0xA88CDC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0xA88E70", Offset = "0xA88E70", VA = "0xA88E70")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0xA89004", Offset = "0xA89004", VA = "0xA89004")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0xA891A8", Offset = "0xA891A8", VA = "0xA891A8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0xA89340", Offset = "0xA89340", VA = "0xA89340")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0xA894D8", Offset = "0xA894D8", VA = "0xA894D8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0xA89670", Offset = "0xA89670", VA = "0xA89670")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E70")]
		[Address(RVA = "0xA8980C", Offset = "0xA8980C", VA = "0xA8980C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E71")]
		[Address(RVA = "0xA899A8", Offset = "0xA899A8", VA = "0xA899A8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E72")]
		[Address(RVA = "0xA89B2C", Offset = "0xA89B2C", VA = "0xA89B2C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E73")]
		[Address(RVA = "0xA89CB4", Offset = "0xA89CB4", VA = "0xA89CB4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E74")]
		[Address(RVA = "0xA89E3C", Offset = "0xA89E3C", VA = "0xA89E3C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E75")]
		[Address(RVA = "0xA89FD8", Offset = "0xA89FD8", VA = "0xA89FD8")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E76")]
		[Address(RVA = "0xA8A17C", Offset = "0xA8A17C", VA = "0xA8A17C")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000E77")]
		[Address(RVA = "0xA8A348", Offset = "0xA8A348", VA = "0xA8A348")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000E78")]
		[Address(RVA = "0xA8A51C", Offset = "0xA8A51C", VA = "0xA8A51C")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E79")]
		[Address(RVA = "0xA8A928", Offset = "0xA8A928", VA = "0xA8A928")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0xA8AAB8", Offset = "0xA8AAB8", VA = "0xA8AAB8")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0xA8AC38", Offset = "0xA8AC38", VA = "0xA8AC38")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0xA8ADB8", Offset = "0xA8ADB8", VA = "0xA8ADB8")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0xA8AF44", Offset = "0xA8AF44", VA = "0xA8AF44")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0xA8B0E0", Offset = "0xA8B0E0", VA = "0xA8B0E0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0xA8B254", Offset = "0xA8B254", VA = "0xA8B254")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000E80")]
		[Address(RVA = "0xA8B474", Offset = "0xA8B474", VA = "0xA8B474")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E81")]
		[Address(RVA = "0xA8B674", Offset = "0xA8B674", VA = "0xA8B674")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E82")]
		[Address(RVA = "0xA8B874", Offset = "0xA8B874", VA = "0xA8B874")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000251")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0xA8C964", Offset = "0xA8C964", VA = "0xA8C964")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0xA8CB44", Offset = "0xA8CB44", VA = "0xA8CB44")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0xA8CD30", Offset = "0xA8CD30", VA = "0xA8CD30")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000F00")]
		[Address(RVA = "0xA8CE18", Offset = "0xA8CE18", VA = "0xA8CE18")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000F01")]
		[Address(RVA = "0xA8CF00", Offset = "0xA8CF00", VA = "0xA8CF00")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000F02")]
		[Address(RVA = "0xA8CFE8", Offset = "0xA8CFE8", VA = "0xA8CFE8")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000F03")]
		[Address(RVA = "0xA8D0E0", Offset = "0xA8D0E0", VA = "0xA8D0E0")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000F04")]
		[Address(RVA = "0xA8D1E8", Offset = "0xA8D1E8", VA = "0xA8D1E8")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000F05")]
		[Address(RVA = "0xA8D2D0", Offset = "0xA8D2D0", VA = "0xA8D2D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000F06")]
		[Address(RVA = "0xA8D4C4", Offset = "0xA8D4C4", VA = "0xA8D4C4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000254")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000255")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000141")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000F0D")]
				[Address(RVA = "0xA8D748", Offset = "0xA8D748", VA = "0xA8D748", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000F0E")]
			[Address(RVA = "0xA8CDF0", Offset = "0xA8CDF0", VA = "0xA8CDF0")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000256")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000142")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000F0F")]
				[Address(RVA = "0xA8D778", Offset = "0xA8D778", VA = "0xA8D778", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000F10")]
			[Address(RVA = "0xA8CED8", Offset = "0xA8CED8", VA = "0xA8CED8")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000257")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000143")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000F11")]
				[Address(RVA = "0xA8D7D8", Offset = "0xA8D7D8", VA = "0xA8D7D8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000F12")]
			[Address(RVA = "0xA8CFC0", Offset = "0xA8CFC0", VA = "0xA8CFC0")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000258")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000144")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000F13")]
				[Address(RVA = "0xA8D7F4", Offset = "0xA8D7F4", VA = "0xA8D7F4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000F14")]
			[Address(RVA = "0xA8D0B0", Offset = "0xA8D0B0", VA = "0xA8D0B0")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000259")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000145")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000F15")]
				[Address(RVA = "0xA8D834", Offset = "0xA8D834", VA = "0xA8D834", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000F16")]
			[Address(RVA = "0xA8D1B0", Offset = "0xA8D1B0", VA = "0xA8D1B0")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200025A")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000146")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000F17")]
				[Address(RVA = "0xA8D88C", Offset = "0xA8D88C", VA = "0xA8D88C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000F18")]
			[Address(RVA = "0xA8D2A8", Offset = "0xA8D2A8", VA = "0xA8D2A8")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200025B")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x200025C")]
		public static class Physics
		{
			[Token(Token = "0x6000F1B")]
			[Address(RVA = "0xA8DA1C", Offset = "0xA8DA1C", VA = "0xA8DA1C")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000F1C")]
			[Address(RVA = "0xA8DB1C", Offset = "0xA8DB1C", VA = "0xA8DB1C")]
			public static bool HasRigidbody2D(UnityEngine.Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000F1D")]
			[Address(RVA = "0xA8DBA8", Offset = "0xA8DBA8", VA = "0xA8DBA8")]
			[Preserve]
			public static bool HasRigidbody(UnityEngine.Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000F1E")]
			[Address(RVA = "0xA8DC34", Offset = "0xA8DC34", VA = "0xA8DC34")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000F19")]
		[Address(RVA = "0xA8D8C0", Offset = "0xA8D8C0", VA = "0xA8D8C0")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0xA8D974", Offset = "0xA8D974", VA = "0xA8D974")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x200025D")]
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x200025E")]
		public enum AnimationType
		{
			[Token(Token = "0x4000A4D")]
			None,
			[Token(Token = "0x4000A4E")]
			Move,
			[Token(Token = "0x4000A4F")]
			LocalMove,
			[Token(Token = "0x4000A50")]
			Rotate,
			[Token(Token = "0x4000A51")]
			LocalRotate,
			[Token(Token = "0x4000A52")]
			Scale,
			[Token(Token = "0x4000A53")]
			Color,
			[Token(Token = "0x4000A54")]
			Fade,
			[Token(Token = "0x4000A55")]
			Text,
			[Token(Token = "0x4000A56")]
			PunchPosition,
			[Token(Token = "0x4000A57")]
			PunchRotation,
			[Token(Token = "0x4000A58")]
			PunchScale,
			[Token(Token = "0x4000A59")]
			ShakePosition,
			[Token(Token = "0x4000A5A")]
			ShakeRotation,
			[Token(Token = "0x4000A5B")]
			ShakeScale,
			[Token(Token = "0x4000A5C")]
			CameraAspect,
			[Token(Token = "0x4000A5D")]
			CameraBackgroundColor,
			[Token(Token = "0x4000A5E")]
			CameraFieldOfView,
			[Token(Token = "0x4000A5F")]
			CameraOrthoSize,
			[Token(Token = "0x4000A60")]
			CameraPixelRect,
			[Token(Token = "0x4000A61")]
			CameraRect,
			[Token(Token = "0x4000A62")]
			UIWidthHeight
		}

		[Token(Token = "0x200025F")]
		public enum TargetType
		{
			[Token(Token = "0x4000A64")]
			Unset,
			[Token(Token = "0x4000A65")]
			Camera,
			[Token(Token = "0x4000A66")]
			CanvasGroup,
			[Token(Token = "0x4000A67")]
			Image,
			[Token(Token = "0x4000A68")]
			Light,
			[Token(Token = "0x4000A69")]
			RectTransform,
			[Token(Token = "0x4000A6A")]
			Renderer,
			[Token(Token = "0x4000A6B")]
			SpriteRenderer,
			[Token(Token = "0x4000A6C")]
			Rigidbody,
			[Token(Token = "0x4000A6D")]
			Rigidbody2D,
			[Token(Token = "0x4000A6E")]
			Text,
			[Token(Token = "0x4000A6F")]
			Transform,
			[Token(Token = "0x4000A70")]
			tk2dBaseSprite,
			[Token(Token = "0x4000A71")]
			tk2dTextMesh,
			[Token(Token = "0x4000A72")]
			TextMeshPro,
			[Token(Token = "0x4000A73")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isActive;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isValid;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UnityEngine.Component target;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenCreated;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000022")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x6000F1F")]
			[Address(RVA = "0xA8DD78", Offset = "0xA8DD78", VA = "0xA8DD78")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F20")]
			[Address(RVA = "0xA8DE44", Offset = "0xA8DE44", VA = "0xA8DE44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000F21")]
		[Address(RVA = "0xA8DF10", Offset = "0xA8DF10", VA = "0xA8DF10")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000F22")]
		[Address(RVA = "0xA8DF7C", Offset = "0xA8DF7C", VA = "0xA8DF7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000F23")]
		[Address(RVA = "0xA8F598", Offset = "0xA8F598", VA = "0xA8F598")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F24")]
		[Address(RVA = "0xA8F5D0", Offset = "0xA8F5D0", VA = "0xA8F5D0")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000F25")]
		[Address(RVA = "0xA8F5D4", Offset = "0xA8F5D4", VA = "0xA8F5D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000F26")]
		[Address(RVA = "0xA8DFC0", Offset = "0xA8DFC0", VA = "0xA8DFC0")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000F27")]
		[Address(RVA = "0xA8FCC0", Offset = "0xA8FCC0", VA = "0xA8FCC0", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000F28")]
		[Address(RVA = "0xA8FD2C", Offset = "0xA8FD2C", VA = "0xA8FD2C", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000F29")]
		[Address(RVA = "0xA8FD98", Offset = "0xA8FD98", VA = "0xA8FD98", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0xA8FE04", Offset = "0xA8FE04", VA = "0xA8FE04", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0xA8FE70", Offset = "0xA8FE70", VA = "0xA8FE70", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0xA8FEDC", Offset = "0xA8FEDC", VA = "0xA8FEDC", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0xA8FFC0", Offset = "0xA8FFC0", VA = "0xA8FFC0", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0xA8FFD0", Offset = "0xA8FFD0", VA = "0xA8FFD0", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0xA9031C", Offset = "0xA9031C", VA = "0xA9031C", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000F30")]
		[Address(RVA = "0xA9038C", Offset = "0xA9038C", VA = "0xA9038C", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000F31")]
		[Address(RVA = "0xA90404", Offset = "0xA90404", VA = "0xA90404")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000F32")]
		[Address(RVA = "0xA90480", Offset = "0xA90480", VA = "0xA90480")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000F33")]
		[Address(RVA = "0xA904D8", Offset = "0xA904D8", VA = "0xA904D8")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000F34")]
		[Address(RVA = "0xA90530", Offset = "0xA90530", VA = "0xA90530")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000F35")]
		[Address(RVA = "0xA905AC", Offset = "0xA905AC", VA = "0xA905AC")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000F36")]
		[Address(RVA = "0xA90604", Offset = "0xA90604", VA = "0xA90604")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000F37")]
		[Address(RVA = "0xA90680", Offset = "0xA90680", VA = "0xA90680")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000F38")]
		[Address(RVA = "0xA906D8", Offset = "0xA906D8", VA = "0xA906D8")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000F39")]
		[Address(RVA = "0xA9080C", Offset = "0xA9080C", VA = "0xA9080C")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0xA9088C", Offset = "0xA9088C", VA = "0xA9088C")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0xA908FC", Offset = "0xA908FC", VA = "0xA908FC")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0xA90988", Offset = "0xA90988", VA = "0xA90988")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000F3D")]
		[Address(RVA = "0xA909FC", Offset = "0xA909FC", VA = "0xA909FC")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0xA8F624", Offset = "0xA8F624", VA = "0xA8F624")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0xA90B44", Offset = "0xA90B44", VA = "0xA90B44")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000F40")]
		[Address(RVA = "0xA8F60C", Offset = "0xA8F60C", VA = "0xA8F60C")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000F41")]
		[Address(RVA = "0xA900C8", Offset = "0xA900C8", VA = "0xA900C8")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000F42")]
		[Address(RVA = "0xA90B74", Offset = "0xA90B74", VA = "0xA90B74")]
		public DOTweenAnimation()
		{
		}
	}
	[Token(Token = "0x2000260")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000F44")]
		public static bool IsSameOrSubclassOf<T>(this UnityEngine.Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000261")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0xA90D40", Offset = "0xA90D40", VA = "0xA90D40")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000F46")]
		[Address(RVA = "0xA90D90", Offset = "0xA90D90", VA = "0xA90D90")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000F47")]
		[Address(RVA = "0xA91144", Offset = "0xA91144", VA = "0xA91144")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000264")]
	public static class ShortcutExtensionsTMPText
	{
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0xA8F824", Offset = "0xA8F824", VA = "0xA8F824")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this TMP_Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0xA91558", Offset = "0xA91558", VA = "0xA91558")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0xA91728", Offset = "0xA91728", VA = "0xA91728")]
		public static TweenerCore<Color, Color, ColorOptions> DOOutlineColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000F50")]
		[Address(RVA = "0xA918F8", Offset = "0xA918F8", VA = "0xA918F8")]
		public static TweenerCore<Color, Color, ColorOptions> DOGlowColor(this TMP_Text target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x6000F51")]
		[Address(RVA = "0xA8F9B8", Offset = "0xA8F9B8", VA = "0xA8F9B8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000F52")]
		[Address(RVA = "0xA919F0", Offset = "0xA919F0", VA = "0xA919F0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000F53")]
		[Address(RVA = "0xA91B64", Offset = "0xA91B64", VA = "0xA91B64")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000F54")]
		[Address(RVA = "0xA91CF8", Offset = "0xA91CF8", VA = "0xA91CF8")]
		public static TweenerCore<float, float, FloatOptions> DOFontSize(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000F55")]
		[Address(RVA = "0xA91E6C", Offset = "0xA91E6C", VA = "0xA91E6C")]
		public static TweenerCore<int, int, NoOptions> DOMaxVisibleCharacters(this TMP_Text target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000F56")]
		[Address(RVA = "0xA8FB24", Offset = "0xA8FB24", VA = "0xA8FB24")]
		public static TweenerCore<string, string, StringOptions> DOText(this TMP_Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
}
