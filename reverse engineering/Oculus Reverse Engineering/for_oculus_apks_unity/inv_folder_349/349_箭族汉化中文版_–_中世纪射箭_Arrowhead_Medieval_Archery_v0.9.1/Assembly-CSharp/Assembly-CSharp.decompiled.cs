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
using UnityEngine.Serialization;
using UnityEngine.UI;
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
	[Address(RVA = "0x7B8DE8", Offset = "0x7B8DE8", VA = "0x7B8DE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7B8EA4", Offset = "0x7B8EA4", VA = "0x7B8EA4")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7B8E14", Offset = "0x7B8E14", VA = "0x7B8E14")]
	private void RefreshLabel()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x7B8EEC", Offset = "0x7B8EEC", VA = "0x7B8EEC")]
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
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x7B9EB0", Offset = "0x7B9EB0", VA = "0x7B9EB0")]
		public DisplayNameAttribute(string displayName)
		{
		}
	}

	[Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class IncrementAttribute : SRDebugger.IncrementAttribute
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x7B9F18", Offset = "0x7B9F18", VA = "0x7B9F18")]
		public IncrementAttribute(double increment)
		{
		}
	}

	[Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NumberRangeAttribute : SRDebugger.NumberRangeAttribute
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x7B9F20", Offset = "0x7B9F20", VA = "0x7B9F20")]
		public NumberRangeAttribute(double min, double max)
		{
		}
	}

	[Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class SortAttribute : SRDebugger.SortAttribute
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x7B9F28", Offset = "0x7B9F28", VA = "0x7B9F28")]
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
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x7B99E0", Offset = "0x7B99E0", VA = "0x7B99E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public event SROptionsPropertyChanged PropertyChanged
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x7B9B18", Offset = "0x7B9B18", VA = "0x7B9B18")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x7B9BB4", Offset = "0x7B9BB4", VA = "0x7B9BB4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	private event PropertyChangedEventHandler InterfacePropertyChangedEventHandler
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x7B9D04", Offset = "0x7B9D04", VA = "0x7B9D04")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x7B9DA0", Offset = "0x7B9DA0", VA = "0x7B9DA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	private event PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x7B9E3C", Offset = "0x7B9E3C", VA = "0x7B9E3C", Slot = "4")]
		add
		{
		}
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x7B9E40", Offset = "0x7B9E40", VA = "0x7B9E40", Slot = "5")]
		remove
		{
		}
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x7B8EF4", Offset = "0x7B8EF4", VA = "0x7B8EF4")]
	[Sort(0)]
	[Category("Round")]
	[DisplayName("Complete Round")]
	public void CompleteRound()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x7B9014", Offset = "0x7B9014", VA = "0x7B9014")]
	[Sort(1)]
	[Category("Round")]
	[DisplayName("Fail Round")]
	public void FailRound()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x7B9134", Offset = "0x7B9134", VA = "0x7B9134")]
	[DisplayName("Delete Player State")]
	[Category("Progression")]
	[Sort(4)]
	public void DeletePlayerState()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x7B914C", Offset = "0x7B914C", VA = "0x7B914C")]
	[Sort(5)]
	[Category("Progression")]
	[DisplayName("Money")]
	public void AddMoney()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x7B9190", Offset = "0x7B9190", VA = "0x7B9190")]
	[Sort(6)]
	[Category("Debug")]
	[DisplayName("Unlock All Areas")]
	public void UnlockAllAreas()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7B9384", Offset = "0x7B9384", VA = "0x7B9384")]
	[Category("Debug")]
	[Sort(7)]
	[DisplayName("Unlock Next Area")]
	public void UnlockNextArea()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x7B9498", Offset = "0x7B9498", VA = "0x7B9498")]
	[Sort(1)]
	[Category("Localization")]
	[DisplayName("EN")]
	public void LanguageEN()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x7B9500", Offset = "0x7B9500", VA = "0x7B9500")]
	[Sort(2)]
	[DisplayName("FR")]
	[Category("Localization")]
	public void LanguageFR()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x7B9568", Offset = "0x7B9568", VA = "0x7B9568")]
	[DisplayName("GE")]
	[Category("Localization")]
	[Sort(3)]
	public void LanguageGE()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x7B95D0", Offset = "0x7B95D0", VA = "0x7B95D0")]
	[DisplayName("IN")]
	[Category("Localization")]
	[Sort(4)]
	public void LanguageIN()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x7B9638", Offset = "0x7B9638", VA = "0x7B9638")]
	[DisplayName("IT")]
	[Category("Localization")]
	[Sort(5)]
	public void LanguageIT()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7B96A0", Offset = "0x7B96A0", VA = "0x7B96A0")]
	[DisplayName("JP")]
	[Category("Localization")]
	[Sort(6)]
	public void LanguageJP()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7B9708", Offset = "0x7B9708", VA = "0x7B9708")]
	[DisplayName("KR")]
	[Category("Localization")]
	[Sort(7)]
	public void LanguageKR()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7B9770", Offset = "0x7B9770", VA = "0x7B9770")]
	[Category("Localization")]
	[Sort(8)]
	[DisplayName("PO")]
	public void LanguagePO()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x7B97D8", Offset = "0x7B97D8", VA = "0x7B97D8")]
	[Category("Localization")]
	[DisplayName("RU")]
	[Sort(9)]
	public void LanguageRU()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7B9840", Offset = "0x7B9840", VA = "0x7B9840")]
	[DisplayName("SC")]
	[Category("Localization")]
	[Sort(10)]
	public void LanguageSC()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7B98A8", Offset = "0x7B98A8", VA = "0x7B98A8")]
	[DisplayName("ES")]
	[Sort(11)]
	[Category("Localization")]
	public void LanguageES()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7B9910", Offset = "0x7B9910", VA = "0x7B9910")]
	[DisplayName("TC")]
	[Category("Localization")]
	[Sort(12)]
	public void LanguageTC()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x7B9978", Offset = "0x7B9978", VA = "0x7B9978")]
	[Sort(13)]
	[Category("Localization")]
	[DisplayName("TR")]
	public void LanguageTR()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x7B9A38", Offset = "0x7B9A38", VA = "0x7B9A38")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	public static void OnStartup()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x7B9C50", Offset = "0x7B9C50", VA = "0x7B9C50")]
	public void OnPropertyChanged(string propertyName)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x7B9E44", Offset = "0x7B9E44", VA = "0x7B9E44")]
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
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x7B9F30", Offset = "0x7B9F30", VA = "0x7B9F30")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x7B9F38", Offset = "0x7B9F38", VA = "0x7B9F38")]
		set
		{
		}
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x7B9F48", Offset = "0x7B9F48", VA = "0x7B9F48")]
	public float GetStartAngle()
	{
		return default(float);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x7B9F50", Offset = "0x7B9F50", VA = "0x7B9F50")]
	public float GetEndAngle()
	{
		return default(float);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x7B9F58", Offset = "0x7B9F58", VA = "0x7B9F58")]
	public Color GetColor()
	{
		return default(Color);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x7B9F64", Offset = "0x7B9F64", VA = "0x7B9F64")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7B9F68", Offset = "0x7B9F68", VA = "0x7B9F68")]
	public void Init()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x7BA540", Offset = "0x7BA540", VA = "0x7BA540")]
	public void InitIfNeeded()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x7BA620", Offset = "0x7BA620", VA = "0x7BA620")]
	public void CalculateAll()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x7BA2B8", Offset = "0x7BA2B8", VA = "0x7BA2B8")]
	private void CalculateAngles()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x7BA39C", Offset = "0x7BA39C", VA = "0x7BA39C")]
	private void CalculateVertices()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x7BA4A4", Offset = "0x7BA4A4", VA = "0x7BA4A4")]
	private void CalculateColors()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x7BA648", Offset = "0x7BA648", VA = "0x7BA648")]
	public void SetRadius(float value)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x7B9F40", Offset = "0x7B9F40", VA = "0x7B9F40")]
	public void SetThickness(float value)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x7BA650", Offset = "0x7BA650", VA = "0x7BA650")]
	public void SetRadiusAndThickness(float radius, float thickness)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x7BA658", Offset = "0x7BA658", VA = "0x7BA658")]
	public void SetStartAngle(float value)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x7BA674", Offset = "0x7BA674", VA = "0x7BA674")]
	public void SetEndAngle(float value)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x7BA690", Offset = "0x7BA690", VA = "0x7BA690")]
	public void SetAngles(float startAngle, float endAngle)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x7BA6AC", Offset = "0x7BA6AC", VA = "0x7BA6AC")]
	public void SetColor(Color value)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x7BA6B8", Offset = "0x7BA6B8", VA = "0x7BA6B8")]
	public void SetAlpha(float value)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x7BA6C0", Offset = "0x7BA6C0", VA = "0x7BA6C0")]
	public RingGenerator()
	{
	}
}
[Token(Token = "0x2000009")]
[SelectionBase]
public class SelectionBase : MonoBehaviour
{
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x7BA6F0", Offset = "0x7BA6F0", VA = "0x7BA6F0")]
	public SelectionBase()
	{
	}
}
[Token(Token = "0x200000A")]
public class TMPLinkOpener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x7BA6F8", Offset = "0x7BA6F8", VA = "0x7BA6F8", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x7BA840", Offset = "0x7BA840", VA = "0x7BA840")]
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

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x7BA848", Offset = "0x7BA848", VA = "0x7BA848")]
	private void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x7BA874", Offset = "0x7BA874", VA = "0x7BA874")]
	private void Update()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x7BAA6C", Offset = "0x7BAA6C", VA = "0x7BAA6C", Slot = "4")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x7BAA90", Offset = "0x7BAA90", VA = "0x7BAA90")]
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

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x7BAAA0", Offset = "0x7BAAA0", VA = "0x7BAAA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x7BAB4C", Offset = "0x7BAB4C", VA = "0x7BAB4C")]
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
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x7BAD44", Offset = "0x7BAD44", VA = "0x7BAD44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x7BACD4", Offset = "0x7BACD4", VA = "0x7BACD4")]
		private Vector2 GetBulletEjectPos(Vector2 origin, float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x7BAD54", Offset = "0x7BAD54", VA = "0x7BAD54")]
		public void Fire()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x7BADA0", Offset = "0x7BADA0", VA = "0x7BADA0")]
		public void Reload()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x7BADAC", Offset = "0x7BADAC", VA = "0x7BADAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x7BADFC", Offset = "0x7BADFC", VA = "0x7BADFC")]
		public void DrawBar(FpsController fpsController, float barRadius)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x7BB280", Offset = "0x7BB280", VA = "0x7BB280")]
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

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x7BB2F4", Offset = "0x7BB2F4", VA = "0x7BB2F4")]
		public void UpdateCharge()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x7BB35C", Offset = "0x7BB35C", VA = "0x7BB35C")]
		public void DrawBar(FpsController fpsController, float barRadius)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x7BB9E0", Offset = "0x7BB9E0", VA = "0x7BB9E0")]
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

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x7BBA4C", Offset = "0x7BBA4C", VA = "0x7BBA4C")]
		public void DrawCompass(Vector3 worldDir)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x7BC2BC", Offset = "0x7BC2BC", VA = "0x7BC2BC")]
		public Compass()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class Crosshair : MonoBehaviour
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Style")]
		[Range(0f, 0.05f)]
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

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x7BC2F8", Offset = "0x7BC2F8", VA = "0x7BC2F8")]
		public void Fire()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x7BC318", Offset = "0x7BC318", VA = "0x7BC318")]
		public void FireHit()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x7BC338", Offset = "0x7BC338", VA = "0x7BC338")]
		public void UpdateCrosshairDecay()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x7BC3F4", Offset = "0x7BC3F4", VA = "0x7BC3F4")]
		public void DrawCrosshair()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x7BCAA4", Offset = "0x7BCAA4", VA = "0x7BCAA4")]
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

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x7BCB5C", Offset = "0x7BCB5C", VA = "0x7BCB5C")]
		public void SetT(float v)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x7BC360", Offset = "0x7BC360", VA = "0x7BC360")]
		public void Update()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x7BCB54", Offset = "0x7BCB54", VA = "0x7BCB54")]
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
				[Token(Token = "0x600006D")]
				[Address(RVA = "0x7BD75C", Offset = "0x7BD75C", VA = "0x7BD75C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600006F")]
				[Address(RVA = "0x7BD7A4", Offset = "0x7BD7A4", VA = "0x7BD7A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0x7BCFB8", Offset = "0x7BCFB8", VA = "0x7BCFB8")]
			[DebuggerHidden]
			public <FixedSteps>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0x7BD6C0", Offset = "0x7BD6C0", VA = "0x7BD6C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0x7BD6C4", Offset = "0x7BD6C4", VA = "0x7BD6C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x7BD764", Offset = "0x7BD764", VA = "0x7BD764", Slot = "8")]
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
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x7BCFE0", Offset = "0x7BCFE0", VA = "0x7BCFE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x7BCBB4", Offset = "0x7BCBB4", VA = "0x7BCBB4")]
			set
			{
			}
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x7BCB64", Offset = "0x7BCB64", VA = "0x7BCB64")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x7BCC44", Offset = "0x7BCC44", VA = "0x7BCC44", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x7BCBDC", Offset = "0x7BCBDC", VA = "0x7BCBDC")]
		[IteratorStateMachine(typeof(<FixedSteps>d__23))]
		private IEnumerator FixedSteps()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x7BB0E0", Offset = "0x7BB0E0", VA = "0x7BB0E0")]
		public static void DrawRoundedArcOutline(Vector2 origin, float radius, float thickness, float outlineThickness, float angStart, float angEnd)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x7BB968", Offset = "0x7BB968", VA = "0x7BB968")]
		public Vector2 GetShake(float speed, float amp)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x7BCFFC", Offset = "0x7BCFFC", VA = "0x7BCFFC")]
		private void FixedUpdateManual()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x7BD154", Offset = "0x7BD154", VA = "0x7BD154")]
		private void Update()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x7BD5C8", Offset = "0x7BD5C8", VA = "0x7BD5C8")]
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

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x7BD7AC", Offset = "0x7BD7AC", VA = "0x7BD7AC", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x7BDA40", Offset = "0x7BDA40", VA = "0x7BDA40")]
		private void BranchFrom(Matrix4x4 mtx)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x7BDEA0", Offset = "0x7BDEA0", VA = "0x7BDEA0")]
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

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x7BDF5C", Offset = "0x7BDF5C", VA = "0x7BDF5C", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x7BE284", Offset = "0x7BE284", VA = "0x7BE284")]
		private Vector2 GetDiscPosition(float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x7BE2F4", Offset = "0x7BE2F4", VA = "0x7BE2F4")]
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
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x7BE34C", Offset = "0x7BE34C", VA = "0x7BE34C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x7BE354", Offset = "0x7BE354", VA = "0x7BE354")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public float Beta
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x7BE35C", Offset = "0x7BE35C", VA = "0x7BE35C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x7BE364", Offset = "0x7BE364", VA = "0x7BE364")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x7BE30C", Offset = "0x7BE30C", VA = "0x7BE30C")]
		public OneEuroFilter(float minCutoff, float beta)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x7BE36C", Offset = "0x7BE36C", VA = "0x7BE36C")]
		public float Filter(float timeStamp, float x)
		{
			return default(float);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x7BE424", Offset = "0x7BE424", VA = "0x7BE424")]
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
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x7BE484", Offset = "0x7BE484", VA = "0x7BE484")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x7BE48C", Offset = "0x7BE48C", VA = "0x7BE48C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float Beta
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x7BE494", Offset = "0x7BE494", VA = "0x7BE494")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x7BE49C", Offset = "0x7BE49C", VA = "0x7BE49C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x7BE444", Offset = "0x7BE444", VA = "0x7BE444")]
		public OneEuroFilter3(float minCutoff, float beta)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x7BE4A4", Offset = "0x7BE4A4", VA = "0x7BE4A4")]
		public Vector3 Filter(float timeStamp, Vector3 x)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x7BE670", Offset = "0x7BE670", VA = "0x7BE670")]
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
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x7BE6D0", Offset = "0x7BE6D0", VA = "0x7BE6D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x7BE6D8", Offset = "0x7BE6D8", VA = "0x7BE6D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public float Beta
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x7BE6E0", Offset = "0x7BE6E0", VA = "0x7BE6E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x7BE6E8", Offset = "0x7BE6E8", VA = "0x7BE6E8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x7BE690", Offset = "0x7BE690", VA = "0x7BE690")]
		public OneEuroFilterQ(float minCutoff, float beta)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x7BE6F0", Offset = "0x7BE6F0", VA = "0x7BE6F0")]
		public Quaternion Filter(float timeStamp, Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x7BE8E0", Offset = "0x7BE8E0", VA = "0x7BE8E0")]
		private static float Alpha(float tE, float cutoff)
		{
			return default(float);
		}
	}
}
namespace EDKG.ArcheryRange
{
	[Token(Token = "0x200001B")]
	public class AnalyticsWrapper : MonoBehaviour
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, object> _levelParameters;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, object> _purchaseParameters;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<string, object> _challengeParameters;

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x7BE900", Offset = "0x7BE900", VA = "0x7BE900")]
		private void Awake()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x7BEE10", Offset = "0x7BEE10", VA = "0x7BEE10")]
		public static void ReportLevelStart(int id)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x7BF194", Offset = "0x7BF194", VA = "0x7BF194")]
		public static void ReportLevelComplete(int id)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x7BF518", Offset = "0x7BF518", VA = "0x7BF518")]
		public static void ReportLevelFail(int id)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x7BF89C", Offset = "0x7BF89C", VA = "0x7BF89C")]
		public static void ReportLevelSkip(int id)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x7BFC20", Offset = "0x7BFC20", VA = "0x7BFC20")]
		public static void ReportBowPurchased(int id, int totalStars, int totalCoins, int latestUnlockedLevel)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x7BFE3C", Offset = "0x7BFE3C", VA = "0x7BFE3C")]
		public static void ReportArrowPurchased(int id, int totalStars, int totalCoins, int latestUnlockedLevel)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x7C0058", Offset = "0x7C0058", VA = "0x7C0058")]
		public static void ReportChallengeStart(int id)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x7C03D8", Offset = "0x7C03D8", VA = "0x7C03D8")]
		public static void ReportChallengeComplete(int id)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x7C0758", Offset = "0x7C0758", VA = "0x7C0758")]
		public AnalyticsWrapper()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class Crosshair : MonoBehaviour
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RingGenerator BaseRing;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color NoFatigueColor;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color FullFatigueColor;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MinThickness;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MaxThickness;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _size;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _alpha;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _visibility;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _fatigue;

		[Token(Token = "0x1700000D")]
		public float Alpha
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x7C083C", Offset = "0x7C083C", VA = "0x7C083C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x7C0844", Offset = "0x7C0844", VA = "0x7C0844")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public float Visibility
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x7C0888", Offset = "0x7C0888", VA = "0x7C0888")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x7C0890", Offset = "0x7C0890", VA = "0x7C0890")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float Size
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x7C08AC", Offset = "0x7C08AC", VA = "0x7C08AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x7C08B4", Offset = "0x7C08B4", VA = "0x7C08B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float Fatigue
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x7C0910", Offset = "0x7C0910", VA = "0x7C0910")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x7C0918", Offset = "0x7C0918", VA = "0x7C0918")]
			set
			{
			}
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x7C0860", Offset = "0x7C0860", VA = "0x7C0860")]
		private void UpdateTransparency()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x7C09E8", Offset = "0x7C09E8", VA = "0x7C09E8")]
		public Crosshair()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class AudioManager : MonoBehaviour
	{
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static AudioManager Instance;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MusicPlayer MusicPlayer;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIAudioPlayer UIPlayer;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MiscUIAudioPlayer MiscUIPlayer;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioMixer Mixer;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _masterVolume;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _musicVolume;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _internalMute;

		[Token(Token = "0x40000A8")]
		private const float MinVolume = -35f;

		[Token(Token = "0x40000A9")]
		private const float VolumeSpan = 35f;

		[Token(Token = "0x40000AA")]
		private const float MuteVolume = -80f;

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x7C0A14", Offset = "0x7C0A14", VA = "0x7C0A14")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x7C0B74", Offset = "0x7C0B74", VA = "0x7C0B74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x7C0C34", Offset = "0x7C0C34", VA = "0x7C0C34")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x7C0C94", Offset = "0x7C0C94", VA = "0x7C0C94")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x7C0D0C", Offset = "0x7C0D0C", VA = "0x7C0D0C")]
		public void SetMasterVolume(float value, bool instant = false)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x7C0DDC", Offset = "0x7C0DDC", VA = "0x7C0DDC")]
		private void UpdateMasterVolume(bool instant = false)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x7C0D18", Offset = "0x7C0D18", VA = "0x7C0D18")]
		public void SetMusicVolume(float value, bool instant = false)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x7C0EA0", Offset = "0x7C0EA0", VA = "0x7C0EA0")]
		private void UpdateMusicVolume(bool instant = false)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x7C0C60", Offset = "0x7C0C60", VA = "0x7C0C60")]
		public void ToggleInternalMute(int value = -1)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x7C0F5C", Offset = "0x7C0F5C", VA = "0x7C0F5C")]
		public void OnMasterVolumeChangedEvent(float value)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x7C0F68", Offset = "0x7C0F68", VA = "0x7C0F68")]
		private void OnMusicVolumeChangedEvent(float value)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x7C0F74", Offset = "0x7C0F74", VA = "0x7C0F74")]
		public AudioManager()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class AudioSourcePool : MonoBehaviour
	{
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource SingleSource;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int SourcePoolSize;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _isInactive;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource[] _sourcePool;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _lastSourceId;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x7C0F8C", Offset = "0x7C0F8C", VA = "0x7C0F8C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x7C1190", Offset = "0x7C1190", VA = "0x7C1190")]
		protected AudioSource FindSource()
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x7C11E8", Offset = "0x7C11E8", VA = "0x7C11E8")]
		public AudioSource PlaySpatialClip(AudioClip clip, Vector3 pos, float pitch = 1f, float volume = 1f)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x7C1308", Offset = "0x7C1308", VA = "0x7C1308")]
		public AudioSource PlayClip(AudioClip clip, float pitch = 1f, float volume = 1f)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x7C13E8", Offset = "0x7C13E8", VA = "0x7C13E8")]
		public AudioSource PlayClipRandom(AudioClip clip, float pitchDelta = 0f, float pitchOffset = 0f, float volumeDelta = 0f, float volumeOffset = 0f)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x7C1460", Offset = "0x7C1460", VA = "0x7C1460")]
		public AudioSource PlayClipRandomPresetVolume(AudioClip clip, float defaultPitch, float pitchDelta = 0f, float pitchOffset = 0f, float defaultVolume = 1f, float volumeDelta = 0f, float volumeOffset = 0f)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x7C14E0", Offset = "0x7C14E0", VA = "0x7C14E0")]
		public AudioSourcePool()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class MusicPlayer : MonoBehaviour
	{
		[Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class <TransitionComplete>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MusicPlayer <>4__this;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000BC")]
				[Address(RVA = "0x7C1894", Offset = "0x7C1894", VA = "0x7C1894", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BE")]
				[Address(RVA = "0x7C18DC", Offset = "0x7C18DC", VA = "0x7C18DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x7C16F0", Offset = "0x7C16F0", VA = "0x7C16F0")]
			[DebuggerHidden]
			public <TransitionComplete>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x7C17C8", Offset = "0x7C17C8", VA = "0x7C17C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x7C17CC", Offset = "0x7C17CC", VA = "0x7C17CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x7C189C", Offset = "0x7C189C", VA = "0x7C189C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class <TrackComplete>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MusicPlayer <>4__this;

			[Token(Token = "0x17000013")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C2")]
				[Address(RVA = "0x7C19A4", Offset = "0x7C19A4", VA = "0x7C19A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C4")]
				[Address(RVA = "0x7C19EC", Offset = "0x7C19EC", VA = "0x7C19EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x7C1790", Offset = "0x7C1790", VA = "0x7C1790")]
			[DebuggerHidden]
			public <TrackComplete>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x7C18E4", Offset = "0x7C18E4", VA = "0x7C18E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x7C18E8", Offset = "0x7C18E8", VA = "0x7C18E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x7C19AC", Offset = "0x7C19AC", VA = "0x7C19AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioMixer Mixer;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioMixerSnapshot[] Snapshots;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip[] MenuTracks;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip[] GameTracks;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource MenuSource;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioSource GameSource;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _type;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _menuTrack;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _gameTrack;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _musicTrackCompleteCoroutine;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x7C0D24", Offset = "0x7C0D24", VA = "0x7C0D24")]
		public void ChangeType(int type)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x7C1678", Offset = "0x7C1678", VA = "0x7C1678")]
		[IteratorStateMachine(typeof(<TransitionComplete>d__11))]
		private IEnumerator TransitionComplete(float time)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x7C1718", Offset = "0x7C1718", VA = "0x7C1718")]
		[IteratorStateMachine(typeof(<TrackComplete>d__12))]
		private IEnumerator TrackComplete(float time)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x7C14F8", Offset = "0x7C14F8", VA = "0x7C14F8")]
		private void StartMenuTrack()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x7C15B8", Offset = "0x7C15B8", VA = "0x7C15B8")]
		private void StartGameTrack()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x7C17B8", Offset = "0x7C17B8", VA = "0x7C17B8")]
		public MusicPlayer()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class UIAudioPlayer : AudioSourcePool
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip ClickSnd;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip OpenSnd;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip CloseSnd;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip LongOpenSnd;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip LongCloseSnd;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x7C19F4", Offset = "0x7C19F4", VA = "0x7C19F4")]
		public void PlayClick()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x7C1A04", Offset = "0x7C1A04", VA = "0x7C1A04")]
		public void PlayOpenWindow()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x7C1A14", Offset = "0x7C1A14", VA = "0x7C1A14")]
		public void PlayCloseWindow()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x7C1A24", Offset = "0x7C1A24", VA = "0x7C1A24")]
		public void PlayLongOpen()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x7C1A34", Offset = "0x7C1A34", VA = "0x7C1A34")]
		public void PlayLongClose()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x7C1A44", Offset = "0x7C1A44", VA = "0x7C1A44")]
		public UIAudioPlayer()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class RandomSound : AudioSourcePool
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip[] Clips;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float PitchDelta;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float PitchOffset;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float VolumeDelta;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float VolumeOffset;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _lastClipId;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x7C1A5C", Offset = "0x7C1A5C", VA = "0x7C1A5C")]
		public void Play(int id = -1)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x7C1AF0", Offset = "0x7C1AF0", VA = "0x7C1AF0")]
		public void PlayVolume(int id = -1, float pitch = 1f, float volume = 1f)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x7C1B9C", Offset = "0x7C1B9C", VA = "0x7C1B9C")]
		public RandomSound()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class RagdollAudioPlayer : RandomSound
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _lastVelocity;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 _lastAngularVelocity;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _velocityThreshold;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _velocityChangeThreshold;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _maxVelocity;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x7C1BB4", Offset = "0x7C1BB4", VA = "0x7C1BB4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x7C1C0C", Offset = "0x7C1C0C", VA = "0x7C1C0C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x7C1C1C", Offset = "0x7C1C1C", VA = "0x7C1C1C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x7C1E28", Offset = "0x7C1E28", VA = "0x7C1E28")]
		public RagdollAudioPlayer()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class DynamicDistanceCrosshairController : MonoBehaviour
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRCrosshairController CrosshairController;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask ColliderLayerMask;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRShootingController _shootingController;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isActive;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _isCrosshairNeedsUpdating;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _arrowLength;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _targetDistance;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _filteredDistance;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7C1E58", Offset = "0x7C1E58", VA = "0x7C1E58")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x7C21C4", Offset = "0x7C21C4", VA = "0x7C21C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x7C24EC", Offset = "0x7C24EC", VA = "0x7C24EC")]
		[ContextMenu("Refresh")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x7C2590", Offset = "0x7C2590", VA = "0x7C2590")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7C2624", Offset = "0x7C2624", VA = "0x7C2624")]
		private float UpdateCollisions()
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x7C2770", Offset = "0x7C2770", VA = "0x7C2770")]
		private void OnStartDrawingEvent()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x7C277C", Offset = "0x7C277C", VA = "0x7C277C")]
		private void OnShootEvent()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x7C2784", Offset = "0x7C2784", VA = "0x7C2784")]
		private void OnCancelEvent()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x7C278C", Offset = "0x7C278C", VA = "0x7C278C")]
		public DynamicDistanceCrosshairController()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class VRCrosshairController : MonoBehaviour
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Crosshair Crosshair1;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DistanceFromArrow;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRShootingController _shootingController;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _noAccuracy;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _maxAccuracy;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isShootingControllerNull;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isFollowing;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Tween _sizeTween;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Tween _alphaTween;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x7C27A0", Offset = "0x7C27A0", VA = "0x7C27A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x7C2ED0", Offset = "0x7C2ED0", VA = "0x7C2ED0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x7C3590", Offset = "0x7C3590", VA = "0x7C3590")]
		private void OnCrosshairToggle()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x7C35EC", Offset = "0x7C35EC", VA = "0x7C35EC")]
		private void OnCrosshairChanged(int value)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x7C2508", Offset = "0x7C2508", VA = "0x7C2508")]
		public void SetDynamicCrosshairDistance(float value)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x7C36F0", Offset = "0x7C36F0", VA = "0x7C36F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x7C385C", Offset = "0x7C385C", VA = "0x7C385C")]
		private void OnStaminaAndFatigueChangingEvent(float stamina, float fatigue)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x7C3878", Offset = "0x7C3878", VA = "0x7C3878")]
		private void OnInitEvent()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x7C3620", Offset = "0x7C3620", VA = "0x7C3620")]
		[ContextMenu("Calculate Accuracy Values")]
		private void CalculateAccuracyValues()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x7C38AC", Offset = "0x7C38AC", VA = "0x7C38AC")]
		private void OnIdleEvent()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x7C38DC", Offset = "0x7C38DC", VA = "0x7C38DC")]
		private void OnStartDrawingEvent()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x7C38E8", Offset = "0x7C38E8", VA = "0x7C38E8")]
		private void OnShootEvent()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x7C39F4", Offset = "0x7C39F4", VA = "0x7C39F4")]
		private void OnCancelEvent()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x7C3B00", Offset = "0x7C3B00", VA = "0x7C3B00")]
		private void OnRearmEvent(int ammo, int realAmmo)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x7C3B04", Offset = "0x7C3B04", VA = "0x7C3B04")]
		private void OnNoAmmoEvent(int ammo)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x7C3B08", Offset = "0x7C3B08", VA = "0x7C3B08")]
		public VRCrosshairController()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class VRShootingController : MonoBehaviour
	{
		[Token(Token = "0x2000028")]
		private enum ControllerState
		{
			[Token(Token = "0x4000111")]
			Init,
			[Token(Token = "0x4000112")]
			Idle,
			[Token(Token = "0x4000113")]
			Drawing,
			[Token(Token = "0x4000114")]
			Shooting,
			[Token(Token = "0x4000115")]
			Canceling,
			[Token(Token = "0x4000116")]
			Reloading
		}

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AllEquipmentLoader AllEquipmentLoader;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DrawnThreshold;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private ControllerState _curState;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isDrawn;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _drawingProgress;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _rawDrawingProgress;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _drawingProgressWithFatigue;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isNocked;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private EquipmentStats _equipmentStats;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _arrowShotPivot;

		[Token(Token = "0x40000F7")]
		private const float BaseShootSpeed = 10f;

		[Token(Token = "0x40000F8")]
		private const float BaseCancelSpeed = 10f;

		[Token(Token = "0x40000F9")]
		private const float BaseFatigueSpeed = 0.2f;

		[Token(Token = "0x40000FA")]
		private const float BaseFatiguePercent = 0.5f;

		[Token(Token = "0x40000FB")]
		private const float BaseStaminaRestoreSpeed = 4f;

		[Token(Token = "0x40000FC")]
		private const float BaseShakeAmplitude = 0.033f;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _finalMinAccuracyAngle;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _finalMaxAccuracyAngle;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _finalNoAccuracyAngle;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _finalArrowSpeed;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _finalShootSpeed;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _finalCancelSpeed;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _finalFatigueSpeed;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _finalFatiguePercent;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _finalStamina;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _finalStaminaRestoreSpeed;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _finalShakeAmplitude;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private SpawnPool _arrowPool;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform _arrowPrefab;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _maxTargetDistance;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _stamina;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _fatigue;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _shakePercent;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _debugUnlimitedStamina;

		[Token(Token = "0x17000015")]
		public Transform ArrowShotPivot
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x7C406C", Offset = "0x7C406C", VA = "0x7C406C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public bool IsChangingDraw
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x7C36E0", Offset = "0x7C36E0", VA = "0x7C36E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public float DrawingProgress
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x7C4074", Offset = "0x7C4074", VA = "0x7C4074")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000018")]
		public float DrawingProgressWithFatigue
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x7C407C", Offset = "0x7C407C", VA = "0x7C407C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000019")]
		public float NoAccuracyAngle
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x7C4084", Offset = "0x7C4084", VA = "0x7C4084")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001A")]
		public float MaxAccuracyAngle
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x7C408C", Offset = "0x7C408C", VA = "0x7C408C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001B")]
		public float ArrowSpeed
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x7C4094", Offset = "0x7C4094", VA = "0x7C4094")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001C")]
		public float StaminaPercent
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x7C409C", Offset = "0x7C409C", VA = "0x7C409C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public float ShakePercent
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x7C40AC", Offset = "0x7C40AC", VA = "0x7C40AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x14000004")]
		public static event Action OnInit
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x7C2C8C", Offset = "0x7C2C8C", VA = "0x7C2C8C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x7C334C", Offset = "0x7C334C", VA = "0x7C334C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public static event Action OnIdle
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x7C2D44", Offset = "0x7C2D44", VA = "0x7C2D44")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x7C3404", Offset = "0x7C3404", VA = "0x7C3404")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public static event Action OnNocked
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x7C3BB4", Offset = "0x7C3BB4", VA = "0x7C3BB4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x7C3C70", Offset = "0x7C3C70", VA = "0x7C3C70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public static event Action OnStartDrawing
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x7C1F90", Offset = "0x7C1F90", VA = "0x7C1F90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x7C22B8", Offset = "0x7C22B8", VA = "0x7C22B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public static event Action<float, float> OnDrawChanging
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x7C3D2C", Offset = "0x7C3D2C", VA = "0x7C3D2C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x7C3DFC", Offset = "0x7C3DFC", VA = "0x7C3DFC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public static event Action OnShoot
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x7C204C", Offset = "0x7C204C", VA = "0x7C204C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x7C2374", Offset = "0x7C2374", VA = "0x7C2374")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public static event Action OnCancel
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x7C2108", Offset = "0x7C2108", VA = "0x7C2108")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x7C2430", Offset = "0x7C2430", VA = "0x7C2430")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public static event Action<float, float> OnStaminaAndFatigueChanging
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x7C2E00", Offset = "0x7C2E00", VA = "0x7C2E00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x7C34C0", Offset = "0x7C34C0", VA = "0x7C34C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public static event Action<float, float> OnShakingChanging
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x7C3ECC", Offset = "0x7C3ECC", VA = "0x7C3ECC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x7C3F9C", Offset = "0x7C3F9C", VA = "0x7C3F9C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x7C40B4", Offset = "0x7C40B4", VA = "0x7C40B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x7C449C", Offset = "0x7C449C", VA = "0x7C449C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x7C4834", Offset = "0x7C4834", VA = "0x7C4834")]
		private void Start()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x7C4A00", Offset = "0x7C4A00", VA = "0x7C4A00")]
		private void Update()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x7C4B20", Offset = "0x7C4B20", VA = "0x7C4B20")]
		private void OnNockedEvent()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x7C4B8C", Offset = "0x7C4B8C", VA = "0x7C4B8C")]
		private void OnStartDrawingEvent()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x7C4C00", Offset = "0x7C4C00", VA = "0x7C4C00")]
		private void OnDrawingEvent(Vector3 vector, float pullDistance, float pullDistanceFromHandle, float amount, float calibratedPullDistance, float calibratedAmount)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x7C4DF8", Offset = "0x7C4DF8", VA = "0x7C4DF8")]
		private void OnReleaseEvent(float amount)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x7C4A04", Offset = "0x7C4A04", VA = "0x7C4A04")]
		private void ProcessDrawing()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x7C4CAC", Offset = "0x7C4CAC", VA = "0x7C4CAC")]
		private void ProcessStaminaAndFatigue()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x7C510C", Offset = "0x7C510C", VA = "0x7C510C")]
		private void ProcessShaking()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x7C4E18", Offset = "0x7C4E18", VA = "0x7C4E18")]
		private void Shoot()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x7C5090", Offset = "0x7C5090", VA = "0x7C5090")]
		public void CancelShot()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x7C5184", Offset = "0x7C5184", VA = "0x7C5184")]
		public VRShootingController()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class DebugCamera : MonoBehaviour
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x7C519C", Offset = "0x7C519C", VA = "0x7C519C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x7C52C0", Offset = "0x7C52C0", VA = "0x7C52C0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x7C5364", Offset = "0x7C5364", VA = "0x7C5364")]
		private void OnAnotherSceneLoadedEvent(Scene s, LoadSceneMode l)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x7C5410", Offset = "0x7C5410", VA = "0x7C5410")]
		public DebugCamera()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class DebugQualityController : MonoBehaviour
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Slider Slider;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlayerSettingsState _settings;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x7C5418", Offset = "0x7C5418", VA = "0x7C5418")]
		private void Awake()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x7C5440", Offset = "0x7C5440", VA = "0x7C5440")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x7C54FC", Offset = "0x7C54FC", VA = "0x7C54FC")]
		public void OnQuality(float value)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x7C5668", Offset = "0x7C5668", VA = "0x7C5668")]
		public DebugQualityController()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class DebugTargetHitEffectController : MonoBehaviour
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int TargetHitEffectVersion;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Slider Slider;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ImpactNotification[] Prefab;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ImpactNotificationManager _impactNotificationManager;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x7C5670", Offset = "0x7C5670", VA = "0x7C5670")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x7C56E0", Offset = "0x7C56E0", VA = "0x7C56E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x7C5804", Offset = "0x7C5804", VA = "0x7C5804")]
		private void RefreshLabel()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x7C58E8", Offset = "0x7C58E8", VA = "0x7C58E8")]
		public void OnValueChanged(float value)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x7C5770", Offset = "0x7C5770", VA = "0x7C5770")]
		private void UpdateValue(int value)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x7C59CC", Offset = "0x7C59CC", VA = "0x7C59CC")]
		public DebugTargetHitEffectController()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class DebugTestSceneLoader : MonoBehaviour
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x7C5A20", Offset = "0x7C5A20", VA = "0x7C5A20")]
		public void LoadTestScene()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x7C5B1C", Offset = "0x7C5B1C", VA = "0x7C5B1C")]
		public DebugTestSceneLoader()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class RestartScene : MonoBehaviour
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x7C5B24", Offset = "0x7C5B24", VA = "0x7C5B24")]
		public void OnRestartScene()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x7C5B94", Offset = "0x7C5B94", VA = "0x7C5B94")]
		public RestartScene()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class TimeController : MonoBehaviour
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float NormalTime;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float _oldNormalTime;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _isFrozen;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<float> OnFreezeNormalTime;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<float> OnResetNormalTime;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<float> OnSetNormalTimeInternally;

		[Token(Token = "0x1700001E")]
		public static bool IsFrozen
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x7C5B9C", Offset = "0x7C5B9C", VA = "0x7C5B9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x7C5BF4", Offset = "0x7C5BF4", VA = "0x7C5BF4")]
		public static void SetNormalTime(float value)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x7C5C60", Offset = "0x7C5C60", VA = "0x7C5C60")]
		public static void ResetNormalTime()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x7C5D0C", Offset = "0x7C5D0C", VA = "0x7C5D0C")]
		public static void ToggleFreezeNormalTime()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x7C5DFC", Offset = "0x7C5DFC", VA = "0x7C5DFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x7C5F8C", Offset = "0x7C5F8C", VA = "0x7C5F8C")]
		private void SetNormalTimeInternal(float value)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x7C6030", Offset = "0x7C6030", VA = "0x7C6030")]
		public TimeController()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class TimeControllerUi : MonoBehaviour
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Slider NormalTime;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI NormalTimeLabel;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image FreezeButton;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color ActiveFreezeColor;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color _defaultFreezeColor;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x7C6084", Offset = "0x7C6084", VA = "0x7C6084")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x7C6364", Offset = "0x7C6364", VA = "0x7C6364")]
		public void OnValueChanged(float value)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x7C6410", Offset = "0x7C6410", VA = "0x7C6410")]
		public void OnResetNormalTimeBtn()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x7C645C", Offset = "0x7C645C", VA = "0x7C645C")]
		public void OnToggleFreezeNormalTimeBtn()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x7C64A8", Offset = "0x7C64A8", VA = "0x7C64A8")]
		private void OnResetNormalTimeEvent(float value)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x7C6600", Offset = "0x7C6600", VA = "0x7C6600")]
		private void OnFreezeNormalTimeEvent(float value)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x7C6758", Offset = "0x7C6758", VA = "0x7C6758")]
		private void OnSetNormalTimeInternallyEvent(float value)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x7C6820", Offset = "0x7C6820", VA = "0x7C6820")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x7C6A70", Offset = "0x7C6A70", VA = "0x7C6A70")]
		public TimeControllerUi()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class ToggleComponent : MonoBehaviour
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Behaviour Component;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x7C6A78", Offset = "0x7C6A78", VA = "0x7C6A78")]
		public void ToggleState()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x7C6AAC", Offset = "0x7C6AAC", VA = "0x7C6AAC")]
		public void SetState(bool value)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x7C6ACC", Offset = "0x7C6ACC", VA = "0x7C6ACC")]
		public ToggleComponent()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class ToggleGameObject : MonoBehaviour
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x7C6AD4", Offset = "0x7C6AD4", VA = "0x7C6AD4")]
		public void ToggleState()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x7C6B28", Offset = "0x7C6B28", VA = "0x7C6B28")]
		public void SetState(bool value)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x7C6B50", Offset = "0x7C6B50", VA = "0x7C6B50")]
		public ToggleGameObject()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class ArmLengthCalibration : MonoBehaviour
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<float, float> OnCalibrationComplete;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<bool, bool> OnTriggerPulled;

		[Token(Token = "0x400012D")]
		private const float _distanceReference = 0.79f;

		[Token(Token = "0x400012E")]
		private const float _minCalibration = 0.5f;

		[Token(Token = "0x400012F")]
		private const float _maxCalibration = 1f;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference LeftTrigger;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference RightTrigger;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InputAction _leftTriggerAction;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private InputAction _rightTriggerAction;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Body _body;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isLeftTriggerPulled;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool _isRightTriggerPulled;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _calibration;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isCalibrated;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _distanceAverage;

		[Token(Token = "0x1700001F")]
		public float Calibration
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x7C6B58", Offset = "0x7C6B58", VA = "0x7C6B58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x7C6B60", Offset = "0x7C6B60", VA = "0x7C6B60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x7C6D48", Offset = "0x7C6D48", VA = "0x7C6D48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x7C6EC0", Offset = "0x7C6EC0", VA = "0x7C6EC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x7C6EF0", Offset = "0x7C6EF0", VA = "0x7C6EF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x7C6F20", Offset = "0x7C6F20", VA = "0x7C6F20")]
		private void OnLeftTriggerActionP(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x7C6FC4", Offset = "0x7C6FC4", VA = "0x7C6FC4")]
		private void OnLeftTriggerActionC(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x7C6FEC", Offset = "0x7C6FEC", VA = "0x7C6FEC")]
		private void OnRightTriggerActionP(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x7C7028", Offset = "0x7C7028", VA = "0x7C7028")]
		private void OnRightTriggerActionC(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x7C6F5C", Offset = "0x7C6F5C", VA = "0x7C6F5C")]
		private void CheckIfBothTriggersPulled()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x7C7050", Offset = "0x7C7050", VA = "0x7C7050")]
		private void CapturePose()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x7C7218", Offset = "0x7C7218", VA = "0x7C7218")]
		public ArmLengthCalibration()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class BillboardManager : MonoBehaviour
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Target;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RandomAngle;

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x7C7228", Offset = "0x7C7228", VA = "0x7C7228")]
		[ContextMenu("Rotate towards Target")]
		private void ProcessBillboards()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x7C7378", Offset = "0x7C7378", VA = "0x7C7378")]
		[ContextMenu("Reset rotation")]
		private void ResetRotation()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x7C7438", Offset = "0x7C7438", VA = "0x7C7438")]
		public BillboardManager()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(CanvasGroup))]
	public class CanvasGroupButton : MonoBehaviour
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float InactiveAlpha;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Button _button;

		[Token(Token = "0x17000020")]
		public bool Interactable
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x7C74C4", Offset = "0x7C74C4", VA = "0x7C74C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x7C74E0", Offset = "0x7C74E0", VA = "0x7C74E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public float Alpha
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x7C7534", Offset = "0x7C7534", VA = "0x7C7534")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x7C7550", Offset = "0x7C7550", VA = "0x7C7550")]
			set
			{
			}
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x7C7448", Offset = "0x7C7448", VA = "0x7C7448")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x7C756C", Offset = "0x7C756C", VA = "0x7C756C")]
		public void SetActive(bool value)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x7C7594", Offset = "0x7C7594", VA = "0x7C7594")]
		public CanvasGroupButton()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class ContinueButton : MonoBehaviour
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool JustLeftControllerOption;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputActionReference ContinueButtonLeftAction;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InputAction _continueButtonLeftAction;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference ContinueButtonRightAction;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InputAction _continueButtonRightAction;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent OnContinueButton;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Sprite[] Sprites;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Image Image;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Image Image2;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _pressedOnce;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _pressedLeft;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool _pressedRight;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x7C75A4", Offset = "0x7C75A4", VA = "0x7C75A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x7C75E8", Offset = "0x7C75E8", VA = "0x7C75E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x7C7810", Offset = "0x7C7810", VA = "0x7C7810")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x7C7B34", Offset = "0x7C7B34", VA = "0x7C7B34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x7C7D7C", Offset = "0x7C7D7C", VA = "0x7C7D7C")]
		private void OnContinueButtonLeftPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x7C7E04", Offset = "0x7C7E04", VA = "0x7C7E04")]
		private void OnContinueButtonLeftStarted(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x7C7E94", Offset = "0x7C7E94", VA = "0x7C7E94")]
		private void OnContinueButtonLeftCanceled(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x7C7F28", Offset = "0x7C7F28", VA = "0x7C7F28")]
		private void OnContinueButtonRightPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x7C7FA8", Offset = "0x7C7FA8", VA = "0x7C7FA8")]
		private void OnContinueButtonRightStarted(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x7C8030", Offset = "0x7C8030", VA = "0x7C8030")]
		private void OnContinueButtonRightCanceled(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x7C80BC", Offset = "0x7C80BC", VA = "0x7C80BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x7C8154", Offset = "0x7C8154", VA = "0x7C8154")]
		public ContinueButton()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class FpsCounter : MonoBehaviour
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool Needed;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float UpdateInterval;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Prefix;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _accumulated;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _frames;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _timeLeft;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _fps;

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x7C815C", Offset = "0x7C815C", VA = "0x7C815C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x7C81E0", Offset = "0x7C81E0", VA = "0x7C81E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x7C83A4", Offset = "0x7C83A4", VA = "0x7C83A4")]
		public FpsCounter()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class GamePauser : MonoBehaviour
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<bool> OnGamePaused;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _isGamePaused;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Tween _tween;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x7C8448", Offset = "0x7C8448", VA = "0x7C8448")]
		public void Pause(bool value)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x7C85F0", Offset = "0x7C85F0", VA = "0x7C85F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x7C8600", Offset = "0x7C8600", VA = "0x7C8600")]
		public GamePauser()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class NumberShortener
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x7C867C", Offset = "0x7C867C", VA = "0x7C867C")]
		public static string Shorten(float value)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x7C8754", Offset = "0x7C8754", VA = "0x7C8754")]
		public static string Shorten(int value)
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x7C883C", Offset = "0x7C883C", VA = "0x7C883C")]
		public NumberShortener()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class PlayerPrefsX
	{
		[Token(Token = "0x200003B")]
		private enum ArrayType
		{
			[Token(Token = "0x400015D")]
			Float,
			[Token(Token = "0x400015E")]
			Int32,
			[Token(Token = "0x400015F")]
			Bool,
			[Token(Token = "0x4000160")]
			String,
			[Token(Token = "0x4000161")]
			Vector2,
			[Token(Token = "0x4000162")]
			Vector3,
			[Token(Token = "0x4000163")]
			Quaternion,
			[Token(Token = "0x4000164")]
			Color
		}

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int endianDiff1;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int endianDiff2;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int idx;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static byte[] byteBlock;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x7C8844", Offset = "0x7C8844", VA = "0x7C8844")]
		public static bool SetBool(string name, bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x7C88D4", Offset = "0x7C88D4", VA = "0x7C88D4")]
		public static bool GetBool(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x7C88F0", Offset = "0x7C88F0", VA = "0x7C88F0")]
		public static bool GetBool(string name, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x7C8930", Offset = "0x7C8930", VA = "0x7C8930")]
		public static bool SetVector2(string key, Vector2 vector)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x7C8A68", Offset = "0x7C8A68", VA = "0x7C8A68")]
		private static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x7C8BE0", Offset = "0x7C8BE0", VA = "0x7C8BE0")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x7C8C24", Offset = "0x7C8C24", VA = "0x7C8C24")]
		public static bool SetVector3(string key, Vector3 vector)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x7C8CC4", Offset = "0x7C8CC4", VA = "0x7C8CC4")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x7C8D3C", Offset = "0x7C8D3C", VA = "0x7C8D3C")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x7C8D94", Offset = "0x7C8D94", VA = "0x7C8D94")]
		public static bool SetQuaternion(string key, Quaternion vector)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x7C8E44", Offset = "0x7C8E44", VA = "0x7C8E44")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x7C8EC8", Offset = "0x7C8EC8", VA = "0x7C8EC8")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x7C8F2C", Offset = "0x7C8F2C", VA = "0x7C8F2C")]
		public static bool SetColor(string key, Color color)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x7C8FDC", Offset = "0x7C8FDC", VA = "0x7C8FDC")]
		public static Color GetColor(string key)
		{
			return default(Color);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x7C9018", Offset = "0x7C9018", VA = "0x7C9018")]
		public static Color GetColor(string key, Color defaultValue)
		{
			return default(Color);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x7C907C", Offset = "0x7C907C", VA = "0x7C907C")]
		public static bool SetBoolArray(string key, bool[] boolArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x7C9484", Offset = "0x7C9484", VA = "0x7C9484")]
		public static bool[] GetBoolArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x7C9720", Offset = "0x7C9720", VA = "0x7C9720")]
		public static bool[] GetBoolArray(string key, bool defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x7C97E0", Offset = "0x7C97E0", VA = "0x7C97E0")]
		public static bool SetStringArray(string key, string[] stringArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x7C9AE0", Offset = "0x7C9AE0", VA = "0x7C9AE0")]
		public static string[] GetStringArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x7C9DC0", Offset = "0x7C9DC0", VA = "0x7C9DC0")]
		public static string[] GetStringArray(string key, string defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x7C9EA8", Offset = "0x7C9EA8", VA = "0x7C9EA8")]
		public static bool SetIntArray(string key, int[] intArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x7C89B8", Offset = "0x7C89B8", VA = "0x7C89B8")]
		public static bool SetFloatArray(string key, float[] floatArray)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x7C9F58", Offset = "0x7C9F58", VA = "0x7C9F58")]
		public static bool SetVector2Array(string key, Vector2[] vector2Array)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x7CA008", Offset = "0x7CA008", VA = "0x7CA008")]
		public static bool SetVector3Array(string key, Vector3[] vector3Array)
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x7CA0B8", Offset = "0x7CA0B8", VA = "0x7CA0B8")]
		public static bool SetQuaternionArray(string key, Quaternion[] quaternionArray)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x7CA168", Offset = "0x7CA168", VA = "0x7CA168")]
		public static bool SetColorArray(string key, Color[] colorArray)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		private static bool SetValue<T>(string key, T array, ArrayType arrayType, int vectorNumber, Action<T, byte[], int> convert) where T : IList
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x7CA218", Offset = "0x7CA218", VA = "0x7CA218")]
		private static void ConvertFromInt(int[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x7CA244", Offset = "0x7CA244", VA = "0x7CA244")]
		private static void ConvertFromFloat(float[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x7CA300", Offset = "0x7CA300", VA = "0x7CA300")]
		private static void ConvertFromVector2(Vector2[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x7CA364", Offset = "0x7CA364", VA = "0x7CA364")]
		private static void ConvertFromVector3(Vector3[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x7CA3F8", Offset = "0x7CA3F8", VA = "0x7CA3F8")]
		private static void ConvertFromQuaternion(Quaternion[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x7CA498", Offset = "0x7CA498", VA = "0x7CA498")]
		private static void ConvertFromColor(Color[] array, byte[] bytes, int i)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x7CA538", Offset = "0x7CA538", VA = "0x7CA538")]
		public static int[] GetIntArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x7CA644", Offset = "0x7CA644", VA = "0x7CA644")]
		public static int[] GetIntArray(string key, int defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x7C8AD4", Offset = "0x7C8AD4", VA = "0x7C8AD4")]
		public static float[] GetFloatArray(string key)
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x7CA700", Offset = "0x7CA700", VA = "0x7CA700")]
		public static float[] GetFloatArray(string key, float defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x7CA7BC", Offset = "0x7CA7BC", VA = "0x7CA7BC")]
		public static Vector2[] GetVector2Array(string key)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x7CA8C8", Offset = "0x7CA8C8", VA = "0x7CA8C8")]
		public static Vector2[] GetVector2Array(string key, Vector2 defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x7CA98C", Offset = "0x7CA98C", VA = "0x7CA98C")]
		public static Vector3[] GetVector3Array(string key)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x7CAA98", Offset = "0x7CAA98", VA = "0x7CAA98")]
		public static Vector3[] GetVector3Array(string key, Vector3 defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x7CAB6C", Offset = "0x7CAB6C", VA = "0x7CAB6C")]
		public static Quaternion[] GetQuaternionArray(string key)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x7CAC78", Offset = "0x7CAC78", VA = "0x7CAC78")]
		public static Quaternion[] GetQuaternionArray(string key, Quaternion defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x7CAD54", Offset = "0x7CAD54", VA = "0x7CAD54")]
		public static Color[] GetColorArray(string key)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x7CAE60", Offset = "0x7CAE60", VA = "0x7CAE60")]
		public static Color[] GetColorArray(string key, Color defaultValue, int defaultSize)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		private static void GetValue<T>(string key, T list, ArrayType arrayType, int vectorNumber, Action<T, byte[]> convert) where T : IList
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x7CAF3C", Offset = "0x7CAF3C", VA = "0x7CAF3C")]
		private static void ConvertToInt(List<int> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x7CAFEC", Offset = "0x7CAFEC", VA = "0x7CAFEC")]
		private static void ConvertToFloat(List<float> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x7CB124", Offset = "0x7CB124", VA = "0x7CB124")]
		private static void ConvertToVector2(List<Vector2> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x7CB1F0", Offset = "0x7CB1F0", VA = "0x7CB1F0")]
		private static void ConvertToVector3(List<Vector3> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x7CB2D4", Offset = "0x7CB2D4", VA = "0x7CB2D4")]
		private static void ConvertToQuaternion(List<Quaternion> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x7CB3D0", Offset = "0x7CB3D0", VA = "0x7CB3D0")]
		private static void ConvertToColor(List<Color> list, byte[] bytes)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x7CB4CC", Offset = "0x7CB4CC", VA = "0x7CB4CC")]
		public static void ShowArrayType(string key)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x7C9240", Offset = "0x7C9240", VA = "0x7C9240")]
		private static void Initialize()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x7C9390", Offset = "0x7C9390", VA = "0x7C9390")]
		private static bool SaveBytes(string key, byte[] bytes)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x7CA274", Offset = "0x7CA274", VA = "0x7CA274")]
		private static void ConvertFloatToBytes(float f, byte[] bytes)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x7CB098", Offset = "0x7CB098", VA = "0x7CB098")]
		private static float ConvertBytesToFloat(byte[] bytes)
		{
			return default(float);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x7C9304", Offset = "0x7C9304", VA = "0x7C9304")]
		private static void ConvertInt32ToBytes(int i, byte[] bytes)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x7C9694", Offset = "0x7C9694", VA = "0x7C9694")]
		private static int ConvertBytesToInt32(byte[] bytes)
		{
			return default(int);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x7CB610", Offset = "0x7CB610", VA = "0x7CB610")]
		private static void ConvertTo4Bytes(byte[] bytes)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x7CB790", Offset = "0x7CB790", VA = "0x7CB790")]
		private static void ConvertFrom4Bytes(byte[] bytes)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x7CB910", Offset = "0x7CB910", VA = "0x7CB910")]
		public PlayerPrefsX()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class ReadOnlyAttribute : PropertyAttribute
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x7CB918", Offset = "0x7CB918", VA = "0x7CB918")]
		public ReadOnlyAttribute()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class ShadowDistanceAdjuster : MonoBehaviour
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float ForcedShadowDistance;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _defaultShadowDistance;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x7CB920", Offset = "0x7CB920", VA = "0x7CB920")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x7CBA2C", Offset = "0x7CBA2C", VA = "0x7CBA2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x7CBB28", Offset = "0x7CBB28", VA = "0x7CBB28")]
		private void OnQualityApplied()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x7CBB8C", Offset = "0x7CBB8C", VA = "0x7CBB8C")]
		public ShadowDistanceAdjuster()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class TargetFps : MonoBehaviour
	{
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x7CBB9C", Offset = "0x7CBB9C", VA = "0x7CBB9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x7CBC38", Offset = "0x7CBC38", VA = "0x7CBC38")]
		public TargetFps()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[RequireComponent(typeof(CanvasRenderer))]
	public class Touchable : Graphic
	{
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x7CBC40", Offset = "0x7CBC40", VA = "0x7CBC40", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x7CBC58", Offset = "0x7CBC58", VA = "0x7CBC58")]
		public Touchable()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class TouchArea : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<int> _touchIdList;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _curTouchId;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _isTouching;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool _touchedThisFrame;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		private bool _releasedThisFrame;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 _deltaPosition;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 _deltaPositionPercent;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 _deltaPositionInches;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _curDpi;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 _lastMousePosition;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector2 _screenSize;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _targetDisplaySize;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _curDisplaySize;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _displaySizeRatio;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _displaySizeRatioModifier;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float DisplaySizeRatioBalance;

		[Token(Token = "0x17000022")]
		public bool IsTouching
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x7CBCB0", Offset = "0x7CBCB0", VA = "0x7CBCB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public bool TouchedThisFrame
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x7CBCB8", Offset = "0x7CBCB8", VA = "0x7CBCB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public bool ReleasedThisFrame
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x7CBCC0", Offset = "0x7CBCC0", VA = "0x7CBCC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public Vector2 DeltaPosition
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x7CBCC8", Offset = "0x7CBCC8", VA = "0x7CBCC8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector2 DeltaPositionPercent
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x7CBCD0", Offset = "0x7CBCD0", VA = "0x7CBCD0")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000027")]
		public Vector2 DeltaPositionInches
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x7CBCD8", Offset = "0x7CBCD8", VA = "0x7CBCD8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000028")]
		public float DisplaySizeRatioModifier
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x7CBCE0", Offset = "0x7CBCE0", VA = "0x7CBCE0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x7CBCE8", Offset = "0x7CBCE8", VA = "0x7CBCE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x7CBE50", Offset = "0x7CBE50", VA = "0x7CBE50", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x7CBF14", Offset = "0x7CBF14", VA = "0x7CBF14", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x7CC000", Offset = "0x7CC000", VA = "0x7CC000")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x7CC11C", Offset = "0x7CC11C", VA = "0x7CC11C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x7CC138", Offset = "0x7CC138", VA = "0x7CC138")]
		public TouchArea()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public static class UsefulStuff
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random rng;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float[] FactorialCache;

		[Token(Token = "0x60001C6")]
		public static T FindInParents<T>(GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x7CC164", Offset = "0x7CC164", VA = "0x7CC164")]
		public static string GetGameObjectPath(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		public static void ShuffleArray<T>(T[] arr)
		{
		}

		[Token(Token = "0x60001C9")]
		public static void ShuffleArrayBest<T>(this List<T> list)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x7CC244", Offset = "0x7CC244", VA = "0x7CC244")]
		public static string ConvertToStringForSerialization(this DateTime time)
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x7CC608", Offset = "0x7CC608", VA = "0x7CC608")]
		public static DateTime ConvertDateTimeFromSerialization(this string value)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x7CC818", Offset = "0x7CC818", VA = "0x7CC818")]
		public static void SetAlpha(this Image image, float alpha)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x7CC8C8", Offset = "0x7CC8C8", VA = "0x7CC8C8")]
		public static float GetAlpha(this Image image)
		{
			return default(float);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x7CC950", Offset = "0x7CC950", VA = "0x7CC950")]
		public static void SetAlpha(this RawImage image, float alpha)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x7CCA00", Offset = "0x7CCA00", VA = "0x7CCA00")]
		public static float GetAlpha(this RawImage image)
		{
			return default(float);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x7CCA88", Offset = "0x7CCA88", VA = "0x7CCA88")]
		public static void SetAlpha(this TextMeshProUGUI label, float alpha)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x7CCB38", Offset = "0x7CCB38", VA = "0x7CCB38")]
		public static float GetAlpha(this TextMeshProUGUI label)
		{
			return default(float);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x7CCBBC", Offset = "0x7CCBBC", VA = "0x7CCBBC")]
		public static void SetAlpha(this SpriteRenderer sprite, float alpha)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x7CCC5C", Offset = "0x7CCC5C", VA = "0x7CCC5C")]
		public static float GetAlpha(this SpriteRenderer sprite)
		{
			return default(float);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x7CCCDC", Offset = "0x7CCCDC", VA = "0x7CCCDC")]
		public static void SetLeftTopRightBottom(this RectTransform rt, float left, float top, float right, float bottom)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x7CCDA0", Offset = "0x7CCDA0", VA = "0x7CCDA0")]
		public static bool SkillCheck(int skill, int toughness = 1, float successIfAbove = 0.66f)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x7CCE04", Offset = "0x7CCE04", VA = "0x7CCE04")]
		public static float SkillCheckChance(int skill, int toughness = 1, float successIfAbove = 0.66f)
		{
			return default(float);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x7CCFA4", Offset = "0x7CCFA4", VA = "0x7CCFA4")]
		public static int ChooseWithChance(float[] probs)
		{
			return default(int);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x7CD050", Offset = "0x7CD050", VA = "0x7CD050")]
		public static int GetXPForLevel(int level)
		{
			return default(int);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x7CD11C", Offset = "0x7CD11C", VA = "0x7CD11C")]
		public static float Remap(float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x7CD138", Offset = "0x7CD138", VA = "0x7CD138")]
		private static float[] InitFactorialCache(int max)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x7CCF18", Offset = "0x7CCF18", VA = "0x7CCF18")]
		public static float Factorial(int x)
		{
			return default(float);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x7CD1E8", Offset = "0x7CD1E8", VA = "0x7CD1E8")]
		public static int RandomSign()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000042")]
	public class Vector3LowPassFilter : MonoBehaviour
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SampleCount;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve WeightCurve;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] _samples;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] _weights;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _weightSum;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _currentSample;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _value;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x7CD298", Offset = "0x7CD298", VA = "0x7CD298")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x7CD29C", Offset = "0x7CD29C", VA = "0x7CD29C")]
		[ContextMenu("Calculate Weights")]
		private void CalculateWeights()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x7CD42C", Offset = "0x7CD42C", VA = "0x7CD42C")]
		public Vector3 AddSample(Vector3 sample)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x7CD588", Offset = "0x7CD588", VA = "0x7CD588")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x7CD66C", Offset = "0x7CD66C", VA = "0x7CD66C")]
		public Vector3LowPassFilter()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class AmmoNotification : MonoBehaviour
	{
		[Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class <PlayEditorTest>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AmmoNotification <>4__this;

			[Token(Token = "0x17000029")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001EF")]
				[Address(RVA = "0x7CDE78", Offset = "0x7CDE78", VA = "0x7CDE78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F1")]
				[Address(RVA = "0x7CDEC0", Offset = "0x7CDEC0", VA = "0x7CDEC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x7CDBA8", Offset = "0x7CDBA8", VA = "0x7CDBA8")]
			[DebuggerHidden]
			public <PlayEditorTest>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x7CDDB8", Offset = "0x7CDDB8", VA = "0x7CDDB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x7CDDBC", Offset = "0x7CDDBC", VA = "0x7CDDBC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x7CDE80", Offset = "0x7CDE80", VA = "0x7CDE80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteRenderer SpriteRenderer;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Sequence _sequence;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Sequence _sequence2;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _delay;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _editorTest;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _targetPosition;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<AmmoNotification> _onCompleteCallback;

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x7CD67C", Offset = "0x7CD67C", VA = "0x7CD67C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x7CD8F0", Offset = "0x7CD8F0", VA = "0x7CD8F0")]
		public void Init(float delay, Vector3 targetPosition, SpawnPool spawnPool, Action<AmmoNotification> onComplete)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x7CD9EC", Offset = "0x7CD9EC", VA = "0x7CD9EC")]
		private void OnStepComplete()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x7CDA80", Offset = "0x7CDA80", VA = "0x7CDA80")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x7CDAE4", Offset = "0x7CDAE4", VA = "0x7CDAE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x7CDB20", Offset = "0x7CDB20", VA = "0x7CDB20")]
		[ContextMenu("Test")]
		private void EditorTest()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x7CDB40", Offset = "0x7CDB40", VA = "0x7CDB40")]
		[IteratorStateMachine(typeof(<PlayEditorTest>d__14))]
		private IEnumerator PlayEditorTest()
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x7CDBD0", Offset = "0x7CDBD0", VA = "0x7CDBD0")]
		public AmmoNotification()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class AmmoNotificationManager : MonoBehaviour
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform AmmoNotificationPrefab;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 OffsetVector;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 PerAmmoOffsetVector;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _camera;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x7CDEC8", Offset = "0x7CDEC8", VA = "0x7CDEC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x7CE048", Offset = "0x7CE048", VA = "0x7CE048")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x7CE148", Offset = "0x7CE148", VA = "0x7CE148")]
		private void OnIncomingArrowsEvent(int count, Vector3 point)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x7CE398", Offset = "0x7CE398", VA = "0x7CE398")]
		private void AmmoNotifyComplete(AmmoNotification item)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x7CE3BC", Offset = "0x7CE3BC", VA = "0x7CE3BC")]
		public AmmoNotificationManager()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class ImpactNotification : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class <PlayEditorTest>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ImpactNotification <>4__this;

			[Token(Token = "0x1700002B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000201")]
				[Address(RVA = "0x7CE8E4", Offset = "0x7CE8E4", VA = "0x7CE8E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000203")]
				[Address(RVA = "0x7CE92C", Offset = "0x7CE92C", VA = "0x7CE92C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x7CE7F4", Offset = "0x7CE7F4", VA = "0x7CE7F4")]
			[DebuggerHidden]
			public <PlayEditorTest>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x7CE824", Offset = "0x7CE824", VA = "0x7CE824", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000200")]
			[Address(RVA = "0x7CE828", Offset = "0x7CE828", VA = "0x7CE828", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0x7CE8EC", Offset = "0x7CE8EC", VA = "0x7CE8EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteRenderer SpriteRenderer;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Sequence _sequence;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _editorTest;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x7CE3DC", Offset = "0x7CE3DC", VA = "0x7CE3DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x7CE6CC", Offset = "0x7CE6CC", VA = "0x7CE6CC")]
		public void Init(Color color, SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x7CE710", Offset = "0x7CE710", VA = "0x7CE710")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x7CE75C", Offset = "0x7CE75C", VA = "0x7CE75C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x7CE76C", Offset = "0x7CE76C", VA = "0x7CE76C")]
		[ContextMenu("Test")]
		private void EditorTest()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x7CE78C", Offset = "0x7CE78C", VA = "0x7CE78C")]
		[IteratorStateMachine(typeof(<PlayEditorTest>d__9))]
		private IEnumerator PlayEditorTest()
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x7CE81C", Offset = "0x7CE81C", VA = "0x7CE81C")]
		public ImpactNotification()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class ImpactNotificationManager : MonoBehaviour
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform ImpactNotificationPrefab;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color[] Colors;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _camera;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x7CE934", Offset = "0x7CE934", VA = "0x7CE934")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x7CEA70", Offset = "0x7CEA70", VA = "0x7CEA70")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x7CEB70", Offset = "0x7CEB70", VA = "0x7CEB70")]
		private void OnArrowHitEvent(RaycastHit hit, Vector3 velocity, int precission)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x7CED24", Offset = "0x7CED24", VA = "0x7CED24")]
		public ImpactNotificationManager()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class TargetHitNotification : MonoBehaviour
	{
		[Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class <PlayEditorTest>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TargetHitNotification <>4__this;

			[Token(Token = "0x1700002D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0x7CF2EC", Offset = "0x7CF2EC", VA = "0x7CF2EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000214")]
				[Address(RVA = "0x7CF334", Offset = "0x7CF334", VA = "0x7CF334", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0x7CF1FC", Offset = "0x7CF1FC", VA = "0x7CF1FC")]
			[DebuggerHidden]
			public <PlayEditorTest>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0x7CF22C", Offset = "0x7CF22C", VA = "0x7CF22C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x7CF230", Offset = "0x7CF230", VA = "0x7CF230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000213")]
			[Address(RVA = "0x7CF2F4", Offset = "0x7CF2F4", VA = "0x7CF2F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteRenderer SpriteRenderer;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Sequence _sequence;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _editorTest;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x7CED2C", Offset = "0x7CED2C", VA = "0x7CED2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x7CF094", Offset = "0x7CF094", VA = "0x7CF094")]
		public void Init(Sprite sprite, Color color, SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x7CF118", Offset = "0x7CF118", VA = "0x7CF118")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x7CF164", Offset = "0x7CF164", VA = "0x7CF164")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x7CF174", Offset = "0x7CF174", VA = "0x7CF174")]
		[ContextMenu("Test")]
		private void EditorTest()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x7CF194", Offset = "0x7CF194", VA = "0x7CF194")]
		[IteratorStateMachine(typeof(<PlayEditorTest>d__9))]
		private IEnumerator PlayEditorTest()
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x7CF224", Offset = "0x7CF224", VA = "0x7CF224")]
		public TargetHitNotification()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class TargetHitNotificationManager : MonoBehaviour
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform TargetHitNotificationPrefab;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 OffsetVector;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite[] Sprites;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color[] Colors;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _camera;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x7CF33C", Offset = "0x7CF33C", VA = "0x7CF33C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x7CF478", Offset = "0x7CF478", VA = "0x7CF478")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x7CF578", Offset = "0x7CF578", VA = "0x7CF578")]
		private void OnTargetHitEvent(int precision, RaycastHit hit)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x7CF738", Offset = "0x7CF738", VA = "0x7CF738")]
		public TargetHitNotificationManager()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class TimeNotification : MonoBehaviour
	{
		[Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class <PlayEditorTest>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeNotification <>4__this;

			[Token(Token = "0x1700002F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000224")]
				[Address(RVA = "0x7CFF34", Offset = "0x7CFF34", VA = "0x7CFF34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000030")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000226")]
				[Address(RVA = "0x7CFF7C", Offset = "0x7CFF7C", VA = "0x7CFF7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x7CFE44", Offset = "0x7CFE44", VA = "0x7CFE44")]
			[DebuggerHidden]
			public <PlayEditorTest>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x7CFE74", Offset = "0x7CFE74", VA = "0x7CFE74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x7CFE78", Offset = "0x7CFE78", VA = "0x7CFE78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x7CFF3C", Offset = "0x7CFF3C", VA = "0x7CFF3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro Label;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Sequence _sequence;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Sequence _sequence2;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _editorTest;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 _targetPosition;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action<TimeNotification> _onCompleteCallback;

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x7CF750", Offset = "0x7CF750", VA = "0x7CF750")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x7CFA48", Offset = "0x7CFA48", VA = "0x7CFA48")]
		public void Init(Vector3 targetPosition, SpawnPool spawnPool, Action<TimeNotification> onComplete)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x7CFB3C", Offset = "0x7CFB3C", VA = "0x7CFB3C")]
		private void OnStepComplete()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x7CFD1C", Offset = "0x7CFD1C", VA = "0x7CFD1C")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x7CFD80", Offset = "0x7CFD80", VA = "0x7CFD80")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x7CFDBC", Offset = "0x7CFDBC", VA = "0x7CFDBC")]
		[ContextMenu("Test")]
		private void EditorTest()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x7CFDDC", Offset = "0x7CFDDC", VA = "0x7CFDDC")]
		[IteratorStateMachine(typeof(<PlayEditorTest>d__13))]
		private IEnumerator PlayEditorTest()
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x7CFE6C", Offset = "0x7CFE6C", VA = "0x7CFE6C")]
		public TimeNotification()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class TimeNotificationManager : MonoBehaviour
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform TimeNotificationPrefab;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 OffsetVector;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _camera;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x7CFF84", Offset = "0x7CFF84", VA = "0x7CFF84")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x7D0104", Offset = "0x7D0104", VA = "0x7D0104")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x7D0204", Offset = "0x7D0204", VA = "0x7D0204")]
		private void OnIncomingTimeEvent(int count, Vector3 point)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x7D03E0", Offset = "0x7D03E0", VA = "0x7D03E0")]
		private void TimeNotifyComplete(TimeNotification item)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x7D0404", Offset = "0x7D0404", VA = "0x7D0404")]
		public TimeNotificationManager()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class AmmoManager : MonoBehaviour
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<int> OnShoot;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> OnConfirmedHit;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<int> OnBullseyeHit;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<int> OnConfirmedMiss;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<int> OnNoAmmo;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action<int, int> OnAvailableAmmoChanged;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action<int, Vector3> OnAmmoSent;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Action<int, int> OnAmmoReceived;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Action<int> OnBullseyeHitSent;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int StartingAmmo;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MaxTargetDistance;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<int> _incomingAmmo;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _releasedAmmo;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _additionalAmmo;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RoundManager _roundManager;

		[Token(Token = "0x17000031")]
		public int AvailableAmmo
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x7D041C", Offset = "0x7D041C", VA = "0x7D041C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x7D0424", Offset = "0x7D0424", VA = "0x7D0424")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public int CurAmmo
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x7D042C", Offset = "0x7D042C", VA = "0x7D042C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x7D0434", Offset = "0x7D0434", VA = "0x7D0434")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public int BullseyeHits
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x7D043C", Offset = "0x7D043C", VA = "0x7D043C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x7D0444", Offset = "0x7D0444", VA = "0x7D0444")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x7D044C", Offset = "0x7D044C", VA = "0x7D044C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x7D061C", Offset = "0x7D061C", VA = "0x7D061C", Slot = "5")]
		public virtual void FullRearm()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x7D0708", Offset = "0x7D0708", VA = "0x7D0708", Slot = "6")]
		public virtual void Shoot()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x7D07B0", Offset = "0x7D07B0", VA = "0x7D07B0", Slot = "7")]
		public virtual void ConfirmedHit(int value, RaycastHit hit)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x7D0940", Offset = "0x7D0940", VA = "0x7D0940", Slot = "8")]
		public virtual void IncomingAmmoArrived(int value)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x7D09FC", Offset = "0x7D09FC", VA = "0x7D09FC", Slot = "9")]
		public virtual void ConfirmedMiss()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x7D0AA0", Offset = "0x7D0AA0", VA = "0x7D0AA0")]
		private bool IsAmmoLeft()
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x7D0AB8", Offset = "0x7D0AB8", VA = "0x7D0AB8", Slot = "10")]
		public virtual int CalculateStars()
		{
			return default(int);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x7D0B6C", Offset = "0x7D0B6C", VA = "0x7D0B6C")]
		public AmmoManager()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class LevelManager : RoundManager
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnRessuply;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _isLevelCompleted;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool _isLevelFailed;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _levelFailReward;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x7D0B7C", Offset = "0x7D0B7C", VA = "0x7D0B7C", Slot = "6")]
		protected override void StartRound()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x7D0B98", Offset = "0x7D0B98", VA = "0x7D0B98", Slot = "7")]
		public override void CompleteRound(int value)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x7D0DA0", Offset = "0x7D0DA0", VA = "0x7D0DA0")]
		private void CompleteLevel()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x7D0C44", Offset = "0x7D0C44", VA = "0x7D0C44")]
		public void FailLevel()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x7D1330", Offset = "0x7D1330", VA = "0x7D1330")]
		public void PrepareForRessuply()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x7D1420", Offset = "0x7D1420", VA = "0x7D1420")]
		public void PrepareForNext()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x7D18A8", Offset = "0x7D18A8", VA = "0x7D18A8")]
		public void PrepareForRetry()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x7D1948", Offset = "0x7D1948", VA = "0x7D1948")]
		public void PrepareForSkip()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x7D19CC", Offset = "0x7D19CC", VA = "0x7D19CC", Slot = "9")]
		public override void PrepareForQuit()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x7D1A84", Offset = "0x7D1A84", VA = "0x7D1A84")]
		public LevelManager()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class MiniGameAmmoManager : AmmoManager
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x7D1A94", Offset = "0x7D1A94", VA = "0x7D1A94", Slot = "6")]
		public override void Shoot()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x7D1AFC", Offset = "0x7D1AFC", VA = "0x7D1AFC", Slot = "7")]
		public override void ConfirmedHit(int value, RaycastHit hit)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x7D1BD8", Offset = "0x7D1BD8", VA = "0x7D1BD8", Slot = "9")]
		public override void ConfirmedMiss()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x7D1C40", Offset = "0x7D1C40", VA = "0x7D1C40", Slot = "10")]
		public override int CalculateStars()
		{
			return default(int);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x7D1C48", Offset = "0x7D1C48", VA = "0x7D1C48")]
		public MiniGameAmmoManager()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class MiniGameManager : RoundManager
	{
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MiniGameTargetManager _miniGameTargetManager;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isMiniGameCompleted;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _startingTime;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _bullseyeTimeIncrease;

		[Token(Token = "0x17000034")]
		public float Timer
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x7D1C58", Offset = "0x7D1C58", VA = "0x7D1C58")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x7D1C60", Offset = "0x7D1C60", VA = "0x7D1C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public float TimerPercent
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x7D1C68", Offset = "0x7D1C68", VA = "0x7D1C68")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x7D1C74", Offset = "0x7D1C74", VA = "0x7D1C74", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x7D1E98", Offset = "0x7D1E98", VA = "0x7D1E98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x7D1F98", Offset = "0x7D1F98", VA = "0x7D1F98")]
		private void OnBullseyeHitEvent(int bullseyeHits)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x7D1FAC", Offset = "0x7D1FAC", VA = "0x7D1FAC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x7D1FB0", Offset = "0x7D1FB0", VA = "0x7D1FB0")]
		public void ForceStartRound()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x7D1FBC", Offset = "0x7D1FBC", VA = "0x7D1FBC", Slot = "6")]
		protected override void StartRound()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x7D1FD0", Offset = "0x7D1FD0", VA = "0x7D1FD0")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x7D202C", Offset = "0x7D202C", VA = "0x7D202C", Slot = "7")]
		public override void CompleteRound(int value)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x7D2060", Offset = "0x7D2060", VA = "0x7D2060")]
		private void CompleteMiniGame()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x7D2468", Offset = "0x7D2468", VA = "0x7D2468", Slot = "9")]
		public override void PrepareForQuit()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x7D24CC", Offset = "0x7D24CC", VA = "0x7D24CC")]
		public void PrepareForRetry()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x7D256C", Offset = "0x7D256C", VA = "0x7D256C")]
		public MiniGameManager()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class MiniGameTargetManager : MonoBehaviour
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _targetsHit;

		[Token(Token = "0x17000036")]
		public int TargetsHit
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x7D257C", Offset = "0x7D257C", VA = "0x7D257C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x7D2584", Offset = "0x7D2584", VA = "0x7D2584")]
		private void Awake()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x7D2784", Offset = "0x7D2784", VA = "0x7D2784")]
		private void OnTargetMissedEvent(EDKG.ArcheryRange.Projectiles.Arrow arrow)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x7D27A4", Offset = "0x7D27A4", VA = "0x7D27A4")]
		private void OnTargetHitEvent(int precision, RaycastHit hit)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x7D2804", Offset = "0x7D2804", VA = "0x7D2804")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x7D29BC", Offset = "0x7D29BC", VA = "0x7D29BC")]
		public MiniGameTargetManager()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class RoundManager : MonoBehaviour
	{
		[Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class <DelayedCompleteRound>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int value;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600026B")]
				[Address(RVA = "0x7D2B44", Offset = "0x7D2B44", VA = "0x7D2B44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600026D")]
				[Address(RVA = "0x7D2B8C", Offset = "0x7D2B8C", VA = "0x7D2B8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x7D2A4C", Offset = "0x7D2A4C", VA = "0x7D2A4C")]
			[DebuggerHidden]
			public <DelayedCompleteRound>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000269")]
			[Address(RVA = "0x7D2A78", Offset = "0x7D2A78", VA = "0x7D2A78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x7D2A7C", Offset = "0x7D2A7C", VA = "0x7D2A7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x7D2B4C", Offset = "0x7D2B4C", VA = "0x7D2B4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<int> OnRoundComplete;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected PlayerState _playerState;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected LoadingScreen _loadingScreen;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected AmmoManager _ammoManager;

		[Token(Token = "0x17000037")]
		public bool IsGameInProgress
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x7D29C4", Offset = "0x7D29C4", VA = "0x7D29C4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x7D29CC", Offset = "0x7D29CC", VA = "0x7D29CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x7D1DF4", Offset = "0x7D1DF4", VA = "0x7D1DF4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x7D29D8", Offset = "0x7D29D8", VA = "0x7D29D8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x7D0B8C", Offset = "0x7D0B8C", VA = "0x7D0B8C", Slot = "6")]
		protected virtual void StartRound()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x7D0C18", Offset = "0x7D0C18", VA = "0x7D0C18", Slot = "7")]
		public virtual void CompleteRound(int value)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x7D29E4", Offset = "0x7D29E4", VA = "0x7D29E4", Slot = "8")]
		[IteratorStateMachine(typeof(<DelayedCompleteRound>d__12))]
		protected virtual IEnumerator DelayedCompleteRound(int value)
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x7D2A74", Offset = "0x7D2A74", VA = "0x7D2A74", Slot = "9")]
		public virtual void PrepareForQuit()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x7D1A8C", Offset = "0x7D1A8C", VA = "0x7D1A8C")]
		public RoundManager()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class ScriptableObjectManager : MonoBehaviour
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScriptableObject[] ScriptableObjects;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x7D2B94", Offset = "0x7D2B94", VA = "0x7D2B94")]
		public ScriptableObjectManager()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class TargetManager : MonoBehaviour
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target[] TargetList;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _allTargetsHit;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RoundManager _roundManager;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Target> _initialTargetList;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Target> _targetList;

		[Token(Token = "0x1400000D")]
		public static event Action<float> OnTargetListProgressChanged
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x7D2B9C", Offset = "0x7D2B9C", VA = "0x7D2B9C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x7D2C68", Offset = "0x7D2C68", VA = "0x7D2C68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x7D2D34", Offset = "0x7D2D34", VA = "0x7D2D34")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x7D3114", Offset = "0x7D3114", VA = "0x7D3114")]
		private void OnTargetMissedEvent(EDKG.ArcheryRange.Projectiles.Arrow arrow)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x7D3144", Offset = "0x7D3144", VA = "0x7D3144")]
		private void OnTargetHitEvent(int precision, RaycastHit hit)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x7D31A0", Offset = "0x7D31A0", VA = "0x7D31A0")]
		private void OnTargetKilledEvent(Target t)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x7D32E4", Offset = "0x7D32E4", VA = "0x7D32E4")]
		private void OnTargetResetEvent(Target t)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x7D32C0", Offset = "0x7D32C0", VA = "0x7D32C0")]
		private void ReportLevelComplete()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x7D343C", Offset = "0x7D343C", VA = "0x7D343C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x7D3748", Offset = "0x7D3748", VA = "0x7D3748")]
		public TargetManager()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class PlayerSettingsState
	{
		[Token(Token = "0x2000059")]
		public delegate void SimpleFloatEvent(float value);

		[Token(Token = "0x200005A")]
		public delegate void SimpleIntEvent(int value);

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SerializableSettings _settings;

		[Token(Token = "0x1700003A")]
		public float MasterVolume
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x7D3EC8", Offset = "0x7D3EC8", VA = "0x7D3EC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x7D3EE4", Offset = "0x7D3EE4", VA = "0x7D3EE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public float MusicVolume
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x7D3F6C", Offset = "0x7D3F6C", VA = "0x7D3F6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x7D3F88", Offset = "0x7D3F88", VA = "0x7D3F88")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public int Quality
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x7D4010", Offset = "0x7D4010", VA = "0x7D4010")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x7D402C", Offset = "0x7D402C", VA = "0x7D402C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public float ArmLengthCalibration
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x7D40A8", Offset = "0x7D40A8", VA = "0x7D40A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x7D40C4", Offset = "0x7D40C4", VA = "0x7D40C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool Crosshair
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x7D05E4", Offset = "0x7D05E4", VA = "0x7D05E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x7D40E0", Offset = "0x7D40E0", VA = "0x7D40E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public int AdditionalArrows
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x7D0600", Offset = "0x7D0600", VA = "0x7D0600")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x7D4160", Offset = "0x7D4160", VA = "0x7D4160")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public float Smoothing
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x7D417C", Offset = "0x7D417C", VA = "0x7D417C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x7D4198", Offset = "0x7D4198", VA = "0x7D4198")]
			set
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public static event SimpleFloatEvent OnMasterVolumeChanged
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x7D3750", Offset = "0x7D3750", VA = "0x7D3750")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x7D3808", Offset = "0x7D3808", VA = "0x7D3808")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public static event SimpleFloatEvent OnMusicVolumeChanged
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x7D38C0", Offset = "0x7D38C0", VA = "0x7D38C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x7D397C", Offset = "0x7D397C", VA = "0x7D397C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public static event SimpleIntEvent OnQualityChanged
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x7D3A38", Offset = "0x7D3A38", VA = "0x7D3A38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x7D3AF4", Offset = "0x7D3AF4", VA = "0x7D3AF4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public static event SimpleIntEvent OnCrosshairChanged
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x7D3BB0", Offset = "0x7D3BB0", VA = "0x7D3BB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x7D3C6C", Offset = "0x7D3C6C", VA = "0x7D3C6C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public static event SimpleFloatEvent OnSmoothingChanged
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x7D3D28", Offset = "0x7D3D28", VA = "0x7D3D28")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x7D3DE4", Offset = "0x7D3DE4", VA = "0x7D3DE4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x7D3EA0", Offset = "0x7D3EA0", VA = "0x7D3EA0")]
		public PlayerSettingsState(SerializableSettings settings)
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class PlayerState
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SerializableState _state;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int LevelsPerArea;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int CappedArea;

		[Token(Token = "0x17000041")]
		public int StartedLevel
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x7D4FD8", Offset = "0x7D4FD8", VA = "0x7D4FD8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x7D4FE0", Offset = "0x7D4FE0", VA = "0x7D4FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public int TempStars
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x7D4FE8", Offset = "0x7D4FE8", VA = "0x7D4FE8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x7D4FF0", Offset = "0x7D4FF0", VA = "0x7D4FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int TempPreviousBestStars
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x7D4FF8", Offset = "0x7D4FF8", VA = "0x7D4FF8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x7D5000", Offset = "0x7D5000", VA = "0x7D5000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public int TempBullseyeHits
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x7D5008", Offset = "0x7D5008", VA = "0x7D5008")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x7D5010", Offset = "0x7D5010", VA = "0x7D5010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public int StartedMiniGame
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x7D5018", Offset = "0x7D5018", VA = "0x7D5018")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x7D5020", Offset = "0x7D5020", VA = "0x7D5020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public int TempScore
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x7D5028", Offset = "0x7D5028", VA = "0x7D5028")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x7D5030", Offset = "0x7D5030", VA = "0x7D5030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public int TempPreviousBestScore
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x7D5038", Offset = "0x7D5038", VA = "0x7D5038")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x7D5040", Offset = "0x7D5040", VA = "0x7D5040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public int PrimaryCurrency
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x7D1294", Offset = "0x7D1294", VA = "0x7D1294")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x7D12B0", Offset = "0x7D12B0", VA = "0x7D12B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public int PrimaryCurrencyDontUpdate
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x7D5910", Offset = "0x7D5910", VA = "0x7D5910")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x7D592C", Offset = "0x7D592C", VA = "0x7D592C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public int CurBow
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x7D5D8C", Offset = "0x7D5D8C", VA = "0x7D5D8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x7D5DA8", Offset = "0x7D5DA8", VA = "0x7D5DA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public int CurArrow
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x7D5E28", Offset = "0x7D5E28", VA = "0x7D5E28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x7D5E44", Offset = "0x7D5E44", VA = "0x7D5E44")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public int PremiumAimAssists
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x7D5EC4", Offset = "0x7D5EC4", VA = "0x7D5EC4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x7D5EE0", Offset = "0x7D5EE0", VA = "0x7D5EE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public int PremiumAimAssistsDontUpdate
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x7D5F60", Offset = "0x7D5F60", VA = "0x7D5F60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x7D5F7C", Offset = "0x7D5F7C", VA = "0x7D5F7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public int PremiumSlowmos
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x7D600C", Offset = "0x7D600C", VA = "0x7D600C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x7D6028", Offset = "0x7D6028", VA = "0x7D6028")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public int PremiumSlowmosDontUpdate
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x7D60A8", Offset = "0x7D60A8", VA = "0x7D60A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x7D60C4", Offset = "0x7D60C4", VA = "0x7D60C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public int LatestUnlockedMiniGame
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x7D6154", Offset = "0x7D6154", VA = "0x7D6154")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x7D6170", Offset = "0x7D6170", VA = "0x7D6170")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public int MiniGame
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x7D618C", Offset = "0x7D618C", VA = "0x7D618C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x7D61A8", Offset = "0x7D61A8", VA = "0x7D61A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public int TutorialNavBar
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x7D6370", Offset = "0x7D6370", VA = "0x7D6370")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x7D638C", Offset = "0x7D638C", VA = "0x7D638C")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool TutorialBoosters
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x7D63A8", Offset = "0x7D63A8", VA = "0x7D63A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x7D63C4", Offset = "0x7D63C4", VA = "0x7D63C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public int BowHand
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x7D63E4", Offset = "0x7D63E4", VA = "0x7D63E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x7D6400", Offset = "0x7D6400", VA = "0x7D6400")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public int DataProtectionUser
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x7D641C", Offset = "0x7D641C", VA = "0x7D641C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x7D6438", Offset = "0x7D6438", VA = "0x7D6438")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool DataProtectionPromptShown
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x7D6454", Offset = "0x7D6454", VA = "0x7D6454")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x7D6470", Offset = "0x7D6470", VA = "0x7D6470")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public int DataProtectionAds
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x7D6490", Offset = "0x7D6490", VA = "0x7D6490")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x7D64AC", Offset = "0x7D64AC", VA = "0x7D64AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public int DataProtectionAnalytics
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x7D64C8", Offset = "0x7D64C8", VA = "0x7D64C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x7D64E4", Offset = "0x7D64E4", VA = "0x7D64E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public bool DataProtectionAccepted
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x7D6500", Offset = "0x7D6500", VA = "0x7D6500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x7D651C", Offset = "0x7D651C", VA = "0x7D651C")]
			set
			{
			}
		}

		[Token(Token = "0x14000013")]
		public static event Action<int> OnStarsChanged
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x7D4480", Offset = "0x7D4480", VA = "0x7D4480")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x7D454C", Offset = "0x7D454C", VA = "0x7D454C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public static event Action<int> OnPrimaryCurrencyChanged
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x7D4618", Offset = "0x7D4618", VA = "0x7D4618")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x7D46E8", Offset = "0x7D46E8", VA = "0x7D46E8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public static event Action<int> OnSecondaryCurrencyChanged
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x7D47B8", Offset = "0x7D47B8", VA = "0x7D47B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x7D4888", Offset = "0x7D4888", VA = "0x7D4888")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public static event Action<int> OnPremiumAimAssistsChanged
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x7D4958", Offset = "0x7D4958", VA = "0x7D4958")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x7D4A28", Offset = "0x7D4A28", VA = "0x7D4A28")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public static event Action<int> OnPremiumSlowmosChanged
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x7D4AF8", Offset = "0x7D4AF8", VA = "0x7D4AF8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x7D4BC8", Offset = "0x7D4BC8", VA = "0x7D4BC8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public static event Action<int> OnAreaUnlocked
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x7D4C98", Offset = "0x7D4C98", VA = "0x7D4C98")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x7D4D68", Offset = "0x7D4D68", VA = "0x7D4D68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public static event Action<int, int> OnEquipmentChanged
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x7D4E38", Offset = "0x7D4E38", VA = "0x7D4E38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x7D4F08", Offset = "0x7D4F08", VA = "0x7D4F08")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x7D5048", Offset = "0x7D5048", VA = "0x7D5048")]
		public PlayerState(SerializableState state)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x7D2200", Offset = "0x7D2200", VA = "0x7D2200")]
		public int GetLatestUnlockedArea()
		{
			return default(int);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x7D1520", Offset = "0x7D1520", VA = "0x7D1520")]
		public int GetUnlockedLevelCountInArea(int areaId)
		{
			return default(int);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x7D5088", Offset = "0x7D5088", VA = "0x7D5088")]
		public int GetLatestUnlockedLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x7D1760", Offset = "0x7D1760", VA = "0x7D1760")]
		public string[] GetAreaLeveSceneNamePair(int globalLevelId)
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x7D5114", Offset = "0x7D5114", VA = "0x7D5114")]
		public void UnlockArea(int areaId)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x7D0FA8", Offset = "0x7D0FA8", VA = "0x7D0FA8")]
		public void CompleteLevelInArea(int areaId, int levelId, int stars)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x7D0F94", Offset = "0x7D0F94", VA = "0x7D0F94")]
		public int GetStarsPerLevel(int globalLevelId)
		{
			return default(int);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x7D53E4", Offset = "0x7D53E4", VA = "0x7D53E4")]
		public int GetStarsPerLevelInArea(int areaId, int levelId)
		{
			return default(int);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x7D5504", Offset = "0x7D5504", VA = "0x7D5504")]
		public int GetTotalStars()
		{
			return default(int);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x7D561C", Offset = "0x7D561C", VA = "0x7D561C")]
		public int GetTotalStarsInArea(int areaId)
		{
			return default(int);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x7D5734", Offset = "0x7D5734", VA = "0x7D5734")]
		public int GetRetriesPerLevel(int levelId)
		{
			return default(int);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x7D15B8", Offset = "0x7D15B8", VA = "0x7D15B8")]
		public void AddRetryPerLevel(int levelId)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x7D57BC", Offset = "0x7D57BC", VA = "0x7D57BC")]
		public string[] GetAreaMinigameSceneNamePair(int miniGameId)
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x7D2264", Offset = "0x7D2264", VA = "0x7D2264")]
		public int GetScorePerMiniGame(int miniGameId)
		{
			return default(int);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x7D22EC", Offset = "0x7D22EC", VA = "0x7D22EC")]
		public void CompleteMiniGame(int miniGameId, int score)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x7D5948", Offset = "0x7D5948", VA = "0x7D5948")]
		public void PrimaryCurrencyUpdate()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x7D59BC", Offset = "0x7D59BC", VA = "0x7D59BC")]
		public bool GetInventoryBows(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x7D5A74", Offset = "0x7D5A74", VA = "0x7D5A74")]
		public void SetInventoryBows(int id)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x7D5BA4", Offset = "0x7D5BA4", VA = "0x7D5BA4")]
		public bool GetInventoryArrows(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x7D5C5C", Offset = "0x7D5C5C", VA = "0x7D5C5C")]
		public void SetInventoryArrows(int id)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x7D5F98", Offset = "0x7D5F98", VA = "0x7D5F98")]
		public void PremiumAimAssistsUpdate()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x7D60E0", Offset = "0x7D60E0", VA = "0x7D60E0")]
		public void PremiumSlowmosUpdate()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x7D61C4", Offset = "0x7D61C4", VA = "0x7D61C4")]
		public int GetTutorialStep(int tutorialId)
		{
			return default(int);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x7D624C", Offset = "0x7D624C", VA = "0x7D624C")]
		public void SetTutorialStep(int tutorialId, int value)
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class PlayerStateInitializer : MonoBehaviour
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsPlannedInitialization;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SerializableStateDebug serializableStateDebug;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x7D653C", Offset = "0x7D653C", VA = "0x7D653C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x7D6688", Offset = "0x7D6688", VA = "0x7D6688")]
		public PlayerStateInitializer()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class PlayerStateManager
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlayerStateManager _instance;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly SerializableSettings _serializableSettings;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly SettingsSerializer _settingsSerializer;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly SerializableState _serializableState;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly StateSerializer _stateSerializer;

		[Token(Token = "0x1700005A")]
		public static PlayerStateManager Instance
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x7D0568", Offset = "0x7D0568", VA = "0x7D0568")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public PlayerState State
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x7D683C", Offset = "0x7D683C", VA = "0x7D683C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public PlayerSettingsState Settings
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x7D6844", Offset = "0x7D6844", VA = "0x7D6844")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public bool StateInitialized
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x7D684C", Offset = "0x7D684C", VA = "0x7D684C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x7D6854", Offset = "0x7D6854", VA = "0x7D6854")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool DebugMode
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x7D6860", Offset = "0x7D6860", VA = "0x7D6860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x7D6868", Offset = "0x7D6868", VA = "0x7D6868")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x7D6690", Offset = "0x7D6690", VA = "0x7D6690")]
		private PlayerStateManager()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x7D68EC", Offset = "0x7D68EC", VA = "0x7D68EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x7D65A4", Offset = "0x7D65A4", VA = "0x7D65A4")]
		public void Load()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x7D7344", Offset = "0x7D7344", VA = "0x7D7344")]
		public void Save()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x7D790C", Offset = "0x7D790C", VA = "0x7D790C")]
		public void SaveConsumables()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x7D65E4", Offset = "0x7D65E4", VA = "0x7D65E4")]
		public void LoadDebugData(SerializableStateDebug data)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x7D7C38", Offset = "0x7D7C38", VA = "0x7D7C38")]
		public void ResetSettings()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x7D65CC", Offset = "0x7D65CC", VA = "0x7D65CC")]
		public void LoadSettings()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x7D7EAC", Offset = "0x7D7EAC", VA = "0x7D7EAC")]
		public void SaveSettings()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class OldSerializableSettingsFormatLoader
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x7D8050", Offset = "0x7D8050", VA = "0x7D8050")]
		public static void LoadVersion0(SerializableSettings state)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x7D8054", Offset = "0x7D8054", VA = "0x7D8054")]
		public OldSerializableSettingsFormatLoader()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class SerializableSettings
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Version;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MasterVolume;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MusicVolume;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Quality;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ArmLengthCalibration;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool Crosshair;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int AdditionalArrows;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float Smoothing;

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x7D6874", Offset = "0x7D6874", VA = "0x7D6874")]
		public SerializableSettings()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class SettingsSerializer
	{
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly SerializableSettings _settings;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x7D6884", Offset = "0x7D6884", VA = "0x7D6884")]
		public SettingsSerializer(SerializableSettings settings)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x7D7C7C", Offset = "0x7D7C7C", VA = "0x7D7C7C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x7D7CB8", Offset = "0x7D7CB8", VA = "0x7D7CB8")]
		public void Load()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x7D7EC4", Offset = "0x7D7EC4", VA = "0x7D7EC4")]
		public void Save()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public static class OldSerializableStateFormatLoader
	{
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x7D805C", Offset = "0x7D805C", VA = "0x7D805C")]
		public static void LoadVersion0(SerializableState state)
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class SerializableState
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int TutorialNavBar;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool TutorialBoosters;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int BowHand;

		[Token(Token = "0x1700005F")]
		public int Version
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x7D8060", Offset = "0x7D8060", VA = "0x7D8060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000060")]
		public List<List<int>> StarsPerLevel
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x7D8068", Offset = "0x7D8068", VA = "0x7D8068")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x7D8070", Offset = "0x7D8070", VA = "0x7D8070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public List<int> RetriesPerLevel
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x7D8078", Offset = "0x7D8078", VA = "0x7D8078")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x7D8080", Offset = "0x7D8080", VA = "0x7D8080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public List<int> ScorePerMiniGame
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x7D8088", Offset = "0x7D8088", VA = "0x7D8088")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x7D8090", Offset = "0x7D8090", VA = "0x7D8090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public int PrimaryCurrency
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x7D8098", Offset = "0x7D8098", VA = "0x7D8098")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x7D80A0", Offset = "0x7D80A0", VA = "0x7D80A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public List<int> InventoryBows
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x7D80A8", Offset = "0x7D80A8", VA = "0x7D80A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x7D80B0", Offset = "0x7D80B0", VA = "0x7D80B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public List<int> InventoryArrows
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x7D80B8", Offset = "0x7D80B8", VA = "0x7D80B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x7D80C0", Offset = "0x7D80C0", VA = "0x7D80C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public int CurBow
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x7D80C8", Offset = "0x7D80C8", VA = "0x7D80C8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x7D80D0", Offset = "0x7D80D0", VA = "0x7D80D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public int CurArrow
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x7D80D8", Offset = "0x7D80D8", VA = "0x7D80D8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x7D80E0", Offset = "0x7D80E0", VA = "0x7D80E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public int PremiumAimAssists
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x7D80E8", Offset = "0x7D80E8", VA = "0x7D80E8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x7D80F0", Offset = "0x7D80F0", VA = "0x7D80F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public int PremiumSlowmos
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x7D80F8", Offset = "0x7D80F8", VA = "0x7D80F8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x7D8100", Offset = "0x7D8100", VA = "0x7D8100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public int LatestUnlockedMiniGame
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x7D8108", Offset = "0x7D8108", VA = "0x7D8108")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x7D8110", Offset = "0x7D8110", VA = "0x7D8110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public int MiniGame
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x7D8118", Offset = "0x7D8118", VA = "0x7D8118")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x7D8120", Offset = "0x7D8120", VA = "0x7D8120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public List<int> TutorialSteps
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x7D8128", Offset = "0x7D8128", VA = "0x7D8128")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x7D8130", Offset = "0x7D8130", VA = "0x7D8130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public int DataProtectionUser
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x7D8138", Offset = "0x7D8138", VA = "0x7D8138")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x7D8140", Offset = "0x7D8140", VA = "0x7D8140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool DataProtectionPromptShown
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x7D8148", Offset = "0x7D8148", VA = "0x7D8148")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x7D8150", Offset = "0x7D8150", VA = "0x7D8150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public int DataProtectionAds
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x7D815C", Offset = "0x7D815C", VA = "0x7D815C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x7D8164", Offset = "0x7D8164", VA = "0x7D8164")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public int DataProtectionAnalytics
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x7D816C", Offset = "0x7D816C", VA = "0x7D816C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x7D8174", Offset = "0x7D8174", VA = "0x7D8174")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool DataProtectionAccepted
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x7D817C", Offset = "0x7D817C", VA = "0x7D817C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x7D8184", Offset = "0x7D8184", VA = "0x7D8184")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x7D68AC", Offset = "0x7D68AC", VA = "0x7D68AC")]
		public SerializableState()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[CreateAssetMenu(fileName = "PlayerStateDebug", menuName = "ScriptableObjects/Debug/Player State Debug", order = 2)]
	public class SerializableStateDebug : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000064")]
		public class IntArrayClass
		{
			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int[] StarsPerLevel;

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x7D81AC", Offset = "0x7D81AC", VA = "0x7D81AC")]
			public IntArrayClass()
			{
			}
		}

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntArrayClass[] StarsPerLevel;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] RetriesPerLevel;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] ScorePerMiniGame;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int PrimaryCurrency;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] InventoryBows;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int[] InventoryArrows;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int CurBow;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int CurArrow;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int PremiumAimAssists;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int PremiumSlowmos;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int LatestUnlockedMiniGame;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int MiniGame;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int[] TutorialSteps;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int TutorialNavBar;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool TutorialBoosters;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int BowHand;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int DataProtectionUser;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool DataProtectionPromptShown;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int DataProtectionAds;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int DataProtectionAnalytics;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool DataProtectionAccepted;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x7D79A8", Offset = "0x7D79A8", VA = "0x7D79A8")]
		public void Apply(SerializableState state)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x7D8190", Offset = "0x7D8190", VA = "0x7D8190")]
		public SerializableStateDebug()
		{
		}
	}
	[Token(Token = "0x2000065")]
	internal class StateSerializer
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly SerializableState _state;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x7D68C4", Offset = "0x7D68C4", VA = "0x7D68C4")]
		public StateSerializer(SerializableState state)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x7D6914", Offset = "0x7D6914", VA = "0x7D6914")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x7D6C60", Offset = "0x7D6C60", VA = "0x7D6C60")]
		public void Load()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x7D735C", Offset = "0x7D735C", VA = "0x7D735C")]
		public void Save()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x7D7924", Offset = "0x7D7924", VA = "0x7D7924")]
		public void SaveConsumables()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class Prop : MonoBehaviour
	{
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x7D81B4", Offset = "0x7D81B4", VA = "0x7D81B4", Slot = "4")]
		public virtual void Hit(RaycastHit hit, Vector3 velocity, bool penetrated)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x7D81FC", Offset = "0x7D81FC", VA = "0x7D81FC", Slot = "5")]
		protected virtual void ReactToHit(RaycastHit hit, Vector3 velocity)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x7D8200", Offset = "0x7D8200", VA = "0x7D8200")]
		public Prop()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class StaticProp : Prop
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RandomSound Sound;

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x7D8208", Offset = "0x7D8208", VA = "0x7D8208", Slot = "5")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x7D8228", Offset = "0x7D8228", VA = "0x7D8228")]
		public StaticProp()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class QualityManager : MonoBehaviour
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnQualityApplied;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EDKG.ArcheryRange.PostLut.PostLut PostProcessing;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string[] _names;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _curQuality;

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x7D8230", Offset = "0x7D8230", VA = "0x7D8230")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x7D8354", Offset = "0x7D8354", VA = "0x7D8354")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x7D83CC", Offset = "0x7D83CC", VA = "0x7D83CC")]
		private void OnQualityChangedEvent(int value)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x7D82DC", Offset = "0x7D82DC", VA = "0x7D82DC")]
		private void UpdateQuality()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x7D8400", Offset = "0x7D8400", VA = "0x7D8400")]
		private void UpdatePostProcessing()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x7D842C", Offset = "0x7D842C", VA = "0x7D842C")]
		public QualityManager()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class Activator : Target
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject RegularHitObject;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Animator Animator;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public RandomSound Sound;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _animationStartActivatedHash;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _animationHitHash;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _animationResetHash;

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x7D8434", Offset = "0x7D8434", VA = "0x7D8434", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x7D8504", Offset = "0x7D8504", VA = "0x7D8504", Slot = "7")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x7D852C", Offset = "0x7D852C", VA = "0x7D852C", Slot = "12")]
		protected override int DeterminePrecision(RaycastHit hit)
		{
			return default(int);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x7D85BC", Offset = "0x7D85BC", VA = "0x7D85BC", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x7D85F4", Offset = "0x7D85F4", VA = "0x7D85F4")]
		public Activator()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class ActivationGroup : DynamicObject
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target[] GroupMembers;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x7D861C", Offset = "0x7D861C", VA = "0x7D861C", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x7D86C4", Offset = "0x7D86C4", VA = "0x7D86C4")]
		public ActivationGroup()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public abstract class DynamicObject : MonoBehaviour
	{
		[Token(Token = "0x600034D")]
		public abstract void Activate();

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x7D86D4", Offset = "0x7D86D4", VA = "0x7D86D4", Slot = "5")]
		public virtual void Deactivate()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x7D86CC", Offset = "0x7D86CC", VA = "0x7D86CC")]
		protected DynamicObject()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class Target : DynamicObject
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<int, RaycastHit> OnTargetHit;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Target> OnTargetKilled;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<Target> OnTargetReset;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ActiveAtStart;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool KilledOnHit;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform HomingArrowTarget;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _isAlive;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _isActive;

		[Token(Token = "0x17000072")]
		public bool IsAlive
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x7D86D8", Offset = "0x7D86D8", VA = "0x7D86D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public bool IsActive
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x7D86E0", Offset = "0x7D86E0", VA = "0x7D86E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x7D84F8", Offset = "0x7D84F8", VA = "0x7D84F8", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x7D86E8", Offset = "0x7D86E8", VA = "0x7D86E8", Slot = "4")]
		public sealed override void Activate()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x7D8528", Offset = "0x7D8528", VA = "0x7D8528", Slot = "7")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x7D8764", Offset = "0x7D8764", VA = "0x7D8764", Slot = "5")]
		public sealed override void Deactivate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x7D8788", Offset = "0x7D8788", VA = "0x7D8788", Slot = "8")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x7D878C", Offset = "0x7D878C", VA = "0x7D878C", Slot = "9")]
		public virtual Transform Hit(RaycastHit hit, Vector3 velocity, bool penetrated, [Out] int precision)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x7D893C", Offset = "0x7D893C", VA = "0x7D893C", Slot = "10")]
		protected virtual void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x7D8940", Offset = "0x7D8940", VA = "0x7D8940", Slot = "11")]
		protected virtual Transform GetCustomTransformForArrowToStickTo()
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x7D8948", Offset = "0x7D8948", VA = "0x7D8948", Slot = "12")]
		protected virtual int DeterminePrecision(RaycastHit hit)
		{
			return default(int);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x7D8950", Offset = "0x7D8950", VA = "0x7D8950", Slot = "13")]
		protected virtual void Die()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x7D8A14", Offset = "0x7D8A14", VA = "0x7D8A14", Slot = "14")]
		protected virtual void TakeDamage(int precision)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x7D8608", Offset = "0x7D8608", VA = "0x7D8608")]
		public Target()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class Bullseye : Target
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject RegularHitObject;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject BullseyeHitObject;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Animator Animator;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RandomSound Sound;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _animationStartActivatedHash;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _animationHitHash;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _animationResetHash;

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x7D8A18", Offset = "0x7D8A18", VA = "0x7D8A18", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x7D8ADC", Offset = "0x7D8ADC", VA = "0x7D8ADC", Slot = "7")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x7D8B00", Offset = "0x7D8B00", VA = "0x7D8B00", Slot = "12")]
		protected override int DeterminePrecision(RaycastHit hit)
		{
			return default(int);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x7D8BC8", Offset = "0x7D8BC8", VA = "0x7D8BC8", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x7D8C00", Offset = "0x7D8C00", VA = "0x7D8C00")]
		public Bullseye()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class CrusaderShield : Target
	{
		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Multiuse;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform Body;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RagdollShield RagdollPrefab;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject BullseyeHitObject;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RandomSound Sound;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _customTransformToStickTo;

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x7D8C14", Offset = "0x7D8C14", VA = "0x7D8C14", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x7D8C4C", Offset = "0x7D8C4C", VA = "0x7D8C4C", Slot = "7")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x7D8C84", Offset = "0x7D8C84", VA = "0x7D8C84", Slot = "8")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x7D8CD8", Offset = "0x7D8CD8", VA = "0x7D8CD8", Slot = "12")]
		protected override int DeterminePrecision(RaycastHit hit)
		{
			return default(int);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x7D8D70", Offset = "0x7D8D70", VA = "0x7D8D70", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x7D9048", Offset = "0x7D9048", VA = "0x7D9048", Slot = "11")]
		protected override Transform GetCustomTransformForArrowToStickTo()
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x7D9050", Offset = "0x7D9050", VA = "0x7D9050")]
		public CrusaderShield()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class Dummy : Target
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject[] RegularHitObject;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject[] BullseyeHitObject;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool HealOnActivation;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Animator Animator;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RandomSound Sound;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public RandomSound Sound2;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _animationStartActivatedHash;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _animationHitHash;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _animationResetHash;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _animationGoDownHash;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _animationNonLethalHitHash;

		[Token(Token = "0x400026B")]
		private const int MaxHealth = 2;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _health;

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x7D9064", Offset = "0x7D9064", VA = "0x7D9064", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x7D9184", Offset = "0x7D9184", VA = "0x7D9184", Slot = "7")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x7D91BC", Offset = "0x7D91BC", VA = "0x7D91BC", Slot = "8")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x7D91E0", Offset = "0x7D91E0", VA = "0x7D91E0", Slot = "12")]
		protected override int DeterminePrecision(RaycastHit hit)
		{
			return default(int);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x7D9318", Offset = "0x7D9318", VA = "0x7D9318", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x7D9380", Offset = "0x7D9380", VA = "0x7D9380", Slot = "14")]
		protected override void TakeDamage(int precision)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x7D93A8", Offset = "0x7D93A8", VA = "0x7D93A8")]
		public Dummy()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class ConstantRotator : MonoBehaviour
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Speed;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool RandomizeStartRotation;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float RandomizeSpeed;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x7D93C4", Offset = "0x7D93C4", VA = "0x7D93C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x7D94F8", Offset = "0x7D94F8", VA = "0x7D94F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x7D9584", Offset = "0x7D9584", VA = "0x7D9584")]
		public ConstantRotator()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class Deactivator : DynamicObject
	{
		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] ToDeactivate;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x7D958C", Offset = "0x7D958C", VA = "0x7D958C", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x7D95FC", Offset = "0x7D95FC", VA = "0x7D95FC", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x7D966C", Offset = "0x7D966C", VA = "0x7D966C")]
		public Deactivator()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class DelayedActivator : DynamicObject
	{
		[Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class <Timer>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayedActivator <>4__this;

			[Token(Token = "0x17000074")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600037D")]
				[Address(RVA = "0x7D9988", Offset = "0x7D9988", VA = "0x7D9988", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000075")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600037F")]
				[Address(RVA = "0x7D99D0", Offset = "0x7D99D0", VA = "0x7D99D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600037A")]
			[Address(RVA = "0x7D97A0", Offset = "0x7D97A0", VA = "0x7D97A0")]
			[DebuggerHidden]
			public <Timer>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600037B")]
			[Address(RVA = "0x7D983C", Offset = "0x7D983C", VA = "0x7D983C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600037C")]
			[Address(RVA = "0x7D9840", Offset = "0x7D9840", VA = "0x7D9840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0x7D9990", Offset = "0x7D9990", VA = "0x7D9990", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DelayedActivatorAudioPlayer AudioPlayer;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float[] Delays;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Coroutine _delayedCoroutine;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _nextStep;

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x7D9674", Offset = "0x7D9674", VA = "0x7D9674", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x7D9738", Offset = "0x7D9738", VA = "0x7D9738")]
		[IteratorStateMachine(typeof(<Timer>d__6))]
		private IEnumerator Timer()
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x7D97C8", Offset = "0x7D97C8", VA = "0x7D97C8")]
		public DelayedActivator()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class DelayedActivatorAudioPlayerTarget : DynamicObject
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DelayedActivatorAudioPlayer AudioPlayer;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Delay;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x7D99D8", Offset = "0x7D99D8", VA = "0x7D99D8", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x7D99FC", Offset = "0x7D99FC", VA = "0x7D99FC")]
		public DelayedActivatorAudioPlayerTarget()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class DelayedDeactivator : DynamicObject
	{
		[Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class <Mode0>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayedDeactivator <>4__this;

			[Token(Token = "0x17000076")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600038B")]
				[Address(RVA = "0x7D9ED0", Offset = "0x7D9ED0", VA = "0x7D9ED0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600038D")]
				[Address(RVA = "0x7D9F18", Offset = "0x7D9F18", VA = "0x7D9F18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x7D9BEC", Offset = "0x7D9BEC", VA = "0x7D9BEC")]
			[DebuggerHidden]
			public <Mode0>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x7D9C74", Offset = "0x7D9C74", VA = "0x7D9C74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x7D9C78", Offset = "0x7D9C78", VA = "0x7D9C78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x7D9ED8", Offset = "0x7D9ED8", VA = "0x7D9ED8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class <Mode1>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayedDeactivator <>4__this;

			[Token(Token = "0x17000078")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000391")]
				[Address(RVA = "0x7DA184", Offset = "0x7DA184", VA = "0x7DA184", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000393")]
				[Address(RVA = "0x7DA1CC", Offset = "0x7DA1CC", VA = "0x7DA1CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x7D9C14", Offset = "0x7D9C14", VA = "0x7D9C14")]
			[DebuggerHidden]
			public <Mode1>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x7D9F20", Offset = "0x7D9F20", VA = "0x7D9F20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0x7D9F24", Offset = "0x7D9F24", VA = "0x7D9F24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x7DA18C", Offset = "0x7DA18C", VA = "0x7DA18C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class <Mode2>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayedDeactivator <>4__this;

			[Token(Token = "0x1700007A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000397")]
				[Address(RVA = "0x7DA448", Offset = "0x7DA448", VA = "0x7DA448", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000399")]
				[Address(RVA = "0x7DA490", Offset = "0x7DA490", VA = "0x7DA490", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x7D9C3C", Offset = "0x7D9C3C", VA = "0x7D9C3C")]
			[DebuggerHidden]
			public <Mode2>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x7DA1D4", Offset = "0x7DA1D4", VA = "0x7DA1D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000396")]
			[Address(RVA = "0x7DA1D8", Offset = "0x7DA1D8", VA = "0x7DA1D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x7DA450", Offset = "0x7DA450", VA = "0x7DA450", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target[] TargetsToCheck;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int TargetCheckMode;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Delay;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DynamicObject[] ToDeactivate;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float SecondaryDelay;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DynamicObject[] SecondaryToActivate;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DynamicObject[] SecondaryToDeactivate;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Coroutine _delayedCoroutine;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x7D9A04", Offset = "0x7D9A04", VA = "0x7D9A04", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x7D9B98", Offset = "0x7D9B98", VA = "0x7D9B98")]
		private bool CheckIfGroupAlive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x7D9A60", Offset = "0x7D9A60", VA = "0x7D9A60")]
		[IteratorStateMachine(typeof(<Mode0>d__11))]
		private IEnumerator Mode0()
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x7D9AC8", Offset = "0x7D9AC8", VA = "0x7D9AC8")]
		[IteratorStateMachine(typeof(<Mode1>d__12))]
		private IEnumerator Mode1()
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x7D9B30", Offset = "0x7D9B30", VA = "0x7D9B30")]
		[IteratorStateMachine(typeof(<Mode2>d__13))]
		private IEnumerator Mode2()
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x7D9C64", Offset = "0x7D9C64", VA = "0x7D9C64")]
		public DelayedDeactivator()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class DelayedDeactivatorSimple : DynamicObject
	{
		[Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class <DelayedDeactivation>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayedDeactivatorSimple <>4__this;

			[Token(Token = "0x1700007C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003A0")]
				[Address(RVA = "0x7DA734", Offset = "0x7DA734", VA = "0x7DA734", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003A2")]
				[Address(RVA = "0x7DA77C", Offset = "0x7DA77C", VA = "0x7DA77C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600039D")]
			[Address(RVA = "0x7DA53C", Offset = "0x7DA53C", VA = "0x7DA53C")]
			[DebuggerHidden]
			public <DelayedDeactivation>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0x7DA574", Offset = "0x7DA574", VA = "0x7DA574", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600039F")]
			[Address(RVA = "0x7DA578", Offset = "0x7DA578", VA = "0x7DA578", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x7DA73C", Offset = "0x7DA73C", VA = "0x7DA73C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject Target;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Delay;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Target MakeSureTargetIsAlive;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("CheckIfTargetsAliveBeforeDeactivation")]
		public Target[] CheckIfAnyOfTheTargetsAreAvailable;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DynamicObject[] ToActivateOnDeactivation;

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x7DA498", Offset = "0x7DA498", VA = "0x7DA498", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x7DA4D4", Offset = "0x7DA4D4", VA = "0x7DA4D4")]
		[IteratorStateMachine(typeof(<DelayedDeactivation>d__6))]
		private IEnumerator DelayedDeactivation()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x7DA564", Offset = "0x7DA564", VA = "0x7DA564")]
		public DelayedDeactivatorSimple()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class ManualTween : MonoBehaviour
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Parameters")]
		public bool PlayOnAwake;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool PlayAsSequence;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool LocalSpace;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool UseCurValueAsStep;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool Close;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Tween type")]
		public int TweenType;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RotateMode RotateMode;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Waypoints")]
		public Vector3[] To;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Step parameters")]
		public float Duration;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Delay;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Easing")]
		public Ease EaseType;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Header("Loops")]
		public int Loops;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LoopType LoopType;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Events")]
		public UnityEvent OnStepCompleteEvent;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent OnSequnceCompleteEvent;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent OnCompleteEvent;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Vector3> _to;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Tween _curTween;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _nextStep;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _curLoop;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _curLoopDirection;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _lastStep;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _isSequenceComplete;

		[Token(Token = "0x1700007E")]
		public List<Vector3> FinalTo
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x7DA784", Offset = "0x7DA784", VA = "0x7DA784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x7DA78C", Offset = "0x7DA78C", VA = "0x7DA78C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x7DA958", Offset = "0x7DA958", VA = "0x7DA958")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x7DA968", Offset = "0x7DA968", VA = "0x7DA968")]
		[ContextMenu("Activate")]
		public void Play()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x7DAE04", Offset = "0x7DAE04", VA = "0x7DAE04")]
		public void SetToPreviousStep()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x7DAE30", Offset = "0x7DAE30", VA = "0x7DAE30")]
		public void SetToNextStep()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x7DAE5C", Offset = "0x7DAE5C", VA = "0x7DAE5C")]
		public void SetToStep(int step)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x7DAB78", Offset = "0x7DAB78", VA = "0x7DAB78")]
		private void TweenToNextStep()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x7DAE94", Offset = "0x7DAE94", VA = "0x7DAE94")]
		private void OnStepComplete()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x7DAF44", Offset = "0x7DAF44", VA = "0x7DAF44")]
		private void OnSequenceComplete()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x7DAFC0", Offset = "0x7DAFC0", VA = "0x7DAFC0")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x7DAFDC", Offset = "0x7DAFDC", VA = "0x7DAFDC")]
		public void PreviousStep()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x7DAFE8", Offset = "0x7DAFE8", VA = "0x7DAFE8")]
		public void GoToStep(int id)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x7DA9D4", Offset = "0x7DA9D4", VA = "0x7DA9D4")]
		private void SetValue(int step)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x7DAFF0", Offset = "0x7DAFF0", VA = "0x7DAFF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x7DB008", Offset = "0x7DB008", VA = "0x7DB008")]
		public ManualTween()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class MultiActivator : DynamicObject
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x7DB034", Offset = "0x7DB034", VA = "0x7DB034", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x7DB0A4", Offset = "0x7DB0A4", VA = "0x7DB0A4", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x7DB114", Offset = "0x7DB114", VA = "0x7DB114")]
		public MultiActivator()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class RandomTranslator : DynamicObject
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool RandomizeOnAwake;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UseCurValueAsStep;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool LocalSpace;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] Positions;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vector3> _positions;

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x7DB11C", Offset = "0x7DB11C", VA = "0x7DB11C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x7DB2D8", Offset = "0x7DB2D8", VA = "0x7DB2D8", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x7DB210", Offset = "0x7DB210", VA = "0x7DB210")]
		private void Randomize()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x7DB2DC", Offset = "0x7DB2DC", VA = "0x7DB2DC")]
		public RandomTranslator()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class RotatingShield : DynamicObject
	{
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleTween tween;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Target Target;

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x7DB2EC", Offset = "0x7DB2EC", VA = "0x7DB2EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x7DB370", Offset = "0x7DB370", VA = "0x7DB370", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x7DB3A8", Offset = "0x7DB3A8", VA = "0x7DB3A8", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x7DB3C8", Offset = "0x7DB3C8", VA = "0x7DB3C8")]
		private void OnRotatorDeactivated()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x7DB3E8", Offset = "0x7DB3E8", VA = "0x7DB3E8")]
		public RotatingShield()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class SimpleManualTweener : DynamicObject
	{
		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ManualTween ManualTween;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ActivateStepId;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int DeactivateStepId;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ForceStartFromPreviousStep;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool InstantDeactivation;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x7DB3F0", Offset = "0x7DB3F0", VA = "0x7DB3F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x7DB4FC", Offset = "0x7DB4FC", VA = "0x7DB4FC", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x7DB544", Offset = "0x7DB544", VA = "0x7DB544", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x7DB598", Offset = "0x7DB598", VA = "0x7DB598")]
		public void CancelDeactivation()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x7DB5C8", Offset = "0x7DB5C8", VA = "0x7DB5C8")]
		public SimpleManualTweener()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class SimpleMover : DynamicObject
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action OnHideCompleteCallback;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DOTweenAnimation _animation;

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x7DB5D8", Offset = "0x7DB5D8", VA = "0x7DB5D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x7DB628", Offset = "0x7DB628", VA = "0x7DB628", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x7DB680", Offset = "0x7DB680", VA = "0x7DB680", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x7DB62C", Offset = "0x7DB62C", VA = "0x7DB62C")]
		private void Show()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x7DB684", Offset = "0x7DB684", VA = "0x7DB684")]
		private void Hide()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x7DB6D8", Offset = "0x7DB6D8", VA = "0x7DB6D8")]
		public void OnHideComplete()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x7DB6F0", Offset = "0x7DB6F0", VA = "0x7DB6F0")]
		public SimpleMover()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class SimpleTween : DynamicObject
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action OnHideCompleteCallback;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DOTweenAnimation _animation;

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x7DB6F8", Offset = "0x7DB6F8", VA = "0x7DB6F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x7DB748", Offset = "0x7DB748", VA = "0x7DB748", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x7DB79C", Offset = "0x7DB79C", VA = "0x7DB79C", Slot = "5")]
		public override void Deactivate()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x7DB7F0", Offset = "0x7DB7F0", VA = "0x7DB7F0")]
		public void OnHideComplete()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x7DB808", Offset = "0x7DB808", VA = "0x7DB808")]
		public SimpleTween()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class TwoStepRotator : DynamicObject
	{
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x7DB810", Offset = "0x7DB810", VA = "0x7DB810", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x7DB814", Offset = "0x7DB814", VA = "0x7DB814")]
		public TwoStepRotator()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class Pumpkin : Target
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Multiuse;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RandomSound Sound;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform Body;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PumpkinFragments FragmentsPrefab;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _customTransformToStickTo;

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x7DB81C", Offset = "0x7DB81C", VA = "0x7DB81C", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x7DB878", Offset = "0x7DB878", VA = "0x7DB878", Slot = "7")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x7DB8FC", Offset = "0x7DB8FC", VA = "0x7DB8FC", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x7DBD04", Offset = "0x7DBD04", VA = "0x7DBD04", Slot = "11")]
		protected override Transform GetCustomTransformForArrowToStickTo()
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x7DBD0C", Offset = "0x7DBD0C", VA = "0x7DBD0C")]
		public Pumpkin()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class PumpkinFragments : MonoBehaviour
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] Parts;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody[] _rigidbodies;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] _posList;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion[] _rotList;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _life;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _curLife;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _shouldDisintegrate;

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x7DBD20", Offset = "0x7DBD20", VA = "0x7DBD20")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x7DBB7C", Offset = "0x7DBB7C", VA = "0x7DBB7C")]
		public void Init(SpawnPool pool, float forceMin, float forceMax)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x7DBF1C", Offset = "0x7DBF1C", VA = "0x7DBF1C")]
		private void ResetToInitialState()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x7DC0A4", Offset = "0x7DC0A4", VA = "0x7DC0A4")]
		private void Explode(float forceMin, float forceMax)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x7DBC18", Offset = "0x7DBC18", VA = "0x7DBC18")]
		public Rigidbody GetImpactPart(Vector3 point)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x7DC19C", Offset = "0x7DC19C", VA = "0x7DC19C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x7DC200", Offset = "0x7DC200", VA = "0x7DC200")]
		private void Disintegrate()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x7DC3F8", Offset = "0x7DC3F8", VA = "0x7DC3F8")]
		private void Despawn()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x7DC388", Offset = "0x7DC388", VA = "0x7DC388")]
		private void LockInPlace()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x7DC424", Offset = "0x7DC424", VA = "0x7DC424")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x7DC4AC", Offset = "0x7DC4AC", VA = "0x7DC4AC")]
		public PumpkinFragments()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class RagdollShield : MonoBehaviour
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Body;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _life;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _curLife;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _shouldDisintegrate;

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x7DC4BC", Offset = "0x7DC4BC", VA = "0x7DC4BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x7D8F7C", Offset = "0x7D8F7C", VA = "0x7D8F7C")]
		public void Init(SpawnPool pool, Vector3 velocity, Vector3 point)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x7DC51C", Offset = "0x7DC51C", VA = "0x7DC51C")]
		private void ResetToInitialState()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x7DC634", Offset = "0x7DC634", VA = "0x7DC634")]
		private void ApplyForce(Vector3 velocity, Vector3 point)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x7DC6B4", Offset = "0x7DC6B4", VA = "0x7DC6B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x7DC718", Offset = "0x7DC718", VA = "0x7DC718")]
		private void Disintegrate()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x7DC850", Offset = "0x7DC850", VA = "0x7DC850")]
		private void Despawn()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x7DC830", Offset = "0x7DC830", VA = "0x7DC830")]
		private void LockInPlace()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x7DC87C", Offset = "0x7DC87C", VA = "0x7DC87C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x7DC8AC", Offset = "0x7DC8AC", VA = "0x7DC8AC")]
		public RagdollShield()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class Sandbag : Target
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RandomSound Sound;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody _rigidbody;

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x7DC8BC", Offset = "0x7DC8BC", VA = "0x7DC8BC", Slot = "6")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x7DC914", Offset = "0x7DC914", VA = "0x7DC914", Slot = "10")]
		protected override void ReactToHit(RaycastHit hit, Vector3 velocity, int precision)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x7DC9C0", Offset = "0x7DC9C0", VA = "0x7DC9C0")]
		public Sandbag()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class FollowPosRot : MonoBehaviour
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Target;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x7DC9D4", Offset = "0x7DC9D4", VA = "0x7DC9D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x7DCA74", Offset = "0x7DCA74", VA = "0x7DCA74")]
		public FollowPosRot()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class RotationOffsetTest : MonoBehaviour
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Pivot;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform SecondObj;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Bow;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _dir;

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x7DCA7C", Offset = "0x7DCA7C", VA = "0x7DCA7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x7DCA94", Offset = "0x7DCA94", VA = "0x7DCA94")]
		private void CalculateVector()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x7DCBD0", Offset = "0x7DCBD0", VA = "0x7DCBD0")]
		private void CalculateRotation()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x7DCD30", Offset = "0x7DCD30", VA = "0x7DCD30")]
		public RotationOffsetTest()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class TestInput : MonoBehaviour
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputAction Action;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image Image;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color Idle;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color Started;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color Canceled;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Color Performed;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x7DCD38", Offset = "0x7DCD38", VA = "0x7DCD38")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x7DCE84", Offset = "0x7DCE84", VA = "0x7DCE84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x7DCFB0", Offset = "0x7DCFB0", VA = "0x7DCFB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x7DCFCC", Offset = "0x7DCFCC", VA = "0x7DCFCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x7DCFE8", Offset = "0x7DCFE8", VA = "0x7DCFE8")]
		private void OnStarted(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x7DD018", Offset = "0x7DD018", VA = "0x7DD018")]
		private void OnPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x7DD048", Offset = "0x7DD048", VA = "0x7DD048")]
		private void OnCanceled(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x7DD078", Offset = "0x7DD078", VA = "0x7DD078")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x7DD110", Offset = "0x7DD110", VA = "0x7DD110")]
		public TestInput()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class PrivacyWindow : ModalWindow
	{
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x7DD140", Offset = "0x7DD140", VA = "0x7DD140")]
		public void OnPrivacyPolicyBtn()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x7DD1BC", Offset = "0x7DD1BC", VA = "0x7DD1BC")]
		public void OnPrivacyOptOutBtn()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x7DD274", Offset = "0x7DD274", VA = "0x7DD274")]
		private void OnURLReceived(string url)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x7DD280", Offset = "0x7DD280", VA = "0x7DD280")]
		public PrivacyWindow()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class MiniGameUI : MonoBehaviour
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Localize NameLabel;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocalizationParamsManager NameLabelParams;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image Portrait;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject LockIcon;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CanvasGroup HighlightIcon;

		[Token(Token = "0x1700007F")]
		public bool IsLocked
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x7DD288", Offset = "0x7DD288", VA = "0x7DD288")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x7DD290", Offset = "0x7DD290", VA = "0x7DD290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x7DD29C", Offset = "0x7DD29C", VA = "0x7DD29C")]
		public void Refresh(MiniGameData mgd, int id, int targets, bool isLocked)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x7DD490", Offset = "0x7DD490", VA = "0x7DD490")]
		public void ShakeLocked()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x7DD5A8", Offset = "0x7DD5A8", VA = "0x7DD5A8")]
		public void Highlight(bool value)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x7DD6B0", Offset = "0x7DD6B0", VA = "0x7DD6B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x7DD6D8", Offset = "0x7DD6D8", VA = "0x7DD6D8")]
		public MiniGameUI()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class BowHolster : MonoBehaviour
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Offset;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Body _body;

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x7DD6E0", Offset = "0x7DD6E0", VA = "0x7DD6E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x7DD938", Offset = "0x7DD938", VA = "0x7DD938")]
		[ContextMenu("Update")]
		private void UpdateInEditor()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x7DD93C", Offset = "0x7DD93C", VA = "0x7DD93C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x7DD754", Offset = "0x7DD754", VA = "0x7DD754")]
		private void CalculatePosAndRot()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x7DD940", Offset = "0x7DD940", VA = "0x7DD940")]
		public BowHolster()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class GrabPose : MonoBehaviour
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int PoseId;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool AllowPointer;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool AllowThumb;

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x7DD954", Offset = "0x7DD954", VA = "0x7DD954")]
		public GrabPose()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class HandAnimator : MonoBehaviour
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator Animator;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Debug;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public int DebugPointerTouch;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public int DebugThumbTouch;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float DebugGrip;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float DebugTrigger;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int DebugGrabPose;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool DebugGrabAllowPointer;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool DebugGrabAllowThumb;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private readonly int _triggerHash;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly int _gripHash;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private readonly int _grabPoseHash;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly int _grabHash;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly int _releaseHash;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _allowPointer;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _pointerValue;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _pointerValueSmooth;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool _allowThumb;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _thumbValue;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _thumbValueSmooth;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x7DD95C", Offset = "0x7DD95C", VA = "0x7DD95C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x7DDAD8", Offset = "0x7DDAD8", VA = "0x7DDAD8")]
		public void SetTriggerValue(float value)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x7DDAFC", Offset = "0x7DDAFC", VA = "0x7DDAFC")]
		public void SetGripValue(float value)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x7DDB20", Offset = "0x7DDB20", VA = "0x7DDB20")]
		public void SetPointerTouchValue(bool value)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x7DDB40", Offset = "0x7DDB40", VA = "0x7DDB40")]
		public void SetThumbTouchValue(bool value)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x7DDB60", Offset = "0x7DDB60", VA = "0x7DDB60")]
		public void SetGrabPose(GrabPose pose)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x7DD98C", Offset = "0x7DD98C", VA = "0x7DD98C")]
		private void SmoothPointerTouch()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x7DDA14", Offset = "0x7DDA14", VA = "0x7DDA14")]
		private void SmoothThumbTouch()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x7DDA9C", Offset = "0x7DDA9C", VA = "0x7DDA9C")]
		private void DebugUpdateAnimator()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x7DDC4C", Offset = "0x7DDC4C", VA = "0x7DDC4C")]
		[ContextMenu("Reset Grab Pose")]
		private void DebugResetGrabPose()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x7DDC70", Offset = "0x7DDC70", VA = "0x7DDC70")]
		[ContextMenu("Grab Pose")]
		private void DebugSetGrabPose()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x7DDCC0", Offset = "0x7DDCC0", VA = "0x7DDCC0")]
		public HandAnimator()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class HandController : MonoBehaviour
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference PointerTouchingActionReference;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputActionReference ThumbTouchingActionReference;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference TriggerActionReference;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputActionReference GripActionReference;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private XRDirectInteractor _handInteractor;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HandAnimator _handAnimator;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private InputAction _pointerTouchingAction;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InputAction _thumbTouchingAction;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InputAction _triggerAction;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InputAction _gripAction;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _isPointerTouching;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _isThumbTouching;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _pointerTouchingValue;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _thumbTouchingValue;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _triggerValue;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _gripValue;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GrabPose _grabPose;

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x7DDDC4", Offset = "0x7DDDC4", VA = "0x7DDDC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x7DE1B8", Offset = "0x7DE1B8", VA = "0x7DE1B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x7DE508", Offset = "0x7DE508", VA = "0x7DE508")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x7DE558", Offset = "0x7DE558", VA = "0x7DE558")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x7DE5A8", Offset = "0x7DE5A8", VA = "0x7DE5A8")]
		private void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x7DE678", Offset = "0x7DE678", VA = "0x7DE678")]
		private void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x7DE704", Offset = "0x7DE704", VA = "0x7DE704")]
		private void GetPointerTouchingInput(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x7DE74C", Offset = "0x7DE74C", VA = "0x7DE74C")]
		private void GetThumbTouchingInput(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x7DE794", Offset = "0x7DE794", VA = "0x7DE794")]
		private void GetTriggerInput(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x7DE800", Offset = "0x7DE800", VA = "0x7DE800")]
		private void GetGripInput(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x7DE658", Offset = "0x7DE658", VA = "0x7DE658")]
		public void SetGrabPose(GrabPose pose)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x7DE67C", Offset = "0x7DE67C", VA = "0x7DE67C")]
		private void ReleaseGrabPose()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x7DE86C", Offset = "0x7DE86C", VA = "0x7DE86C")]
		public HandController()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class GroundAmmoItem : MonoBehaviour
	{
		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpriteRenderer Renderer;

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x7DE874", Offset = "0x7DE874", VA = "0x7DE874")]
		public void SetColor(Color c)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x7DE890", Offset = "0x7DE890", VA = "0x7DE890")]
		public GroundAmmoItem()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class GroundAmmoManager : MonoBehaviour
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RingGenerator Container;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GroundAmmoItem> List;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(1f, 180f)]
		public float TotalAngle;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color ContainerNoAmmo;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color ContainerRegular;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color ContainerHighlight;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Color ItemRegular;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Color ItemHighlight;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Color ItemTaken;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Color ItemNocked;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Color ItemAwarded;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _count;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _taken;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _nocked;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _highlighted;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int _awarded;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _visibleItems;

		[Token(Token = "0x4000322")]
		private const float _mainDirectionAngle = 0f;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _directionAngle;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float _itemAngle;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _spacingAngle;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Tween _angleTween;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Tween _directionTween;

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x7DE898", Offset = "0x7DE898", VA = "0x7DE898")]
		private void Awake()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x7DEEBC", Offset = "0x7DEEBC", VA = "0x7DEEBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x7DF4B8", Offset = "0x7DF4B8", VA = "0x7DF4B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x7DFA1C", Offset = "0x7DFA1C", VA = "0x7DFA1C")]
		private void TakeArrow(EDKG.ArcheryRange.VR.Arrow arrow)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x7DFA2C", Offset = "0x7DFA2C", VA = "0x7DFA2C")]
		private void ReturnArrow()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x7DFA3C", Offset = "0x7DFA3C", VA = "0x7DFA3C")]
		private void NockArrow()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x7DFA54", Offset = "0x7DFA54", VA = "0x7DFA54")]
		private void ShootArrow(int count)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x7DFA84", Offset = "0x7DFA84", VA = "0x7DFA84")]
		private void AwardArrow(int count, int realCount)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x7DFAB4", Offset = "0x7DFAB4", VA = "0x7DFAB4")]
		private void AwardArrowReceived(int received, int count)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x7DFAC8", Offset = "0x7DFAC8", VA = "0x7DFAC8")]
		private void QuiverStartHover()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x7DFAD8", Offset = "0x7DFAD8", VA = "0x7DFAD8")]
		private void QuiverEndHover()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x7DFAE8", Offset = "0x7DFAE8", VA = "0x7DFAE8")]
		private void QuiverNoAmmo()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x7DF4F4", Offset = "0x7DF4F4", VA = "0x7DF4F4")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x7DF964", Offset = "0x7DF964", VA = "0x7DF964")]
		private void UpdateAmmoLabel()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x7DFAEC", Offset = "0x7DFAEC", VA = "0x7DFAEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x7DF6A4", Offset = "0x7DF6A4", VA = "0x7DF6A4")]
		private void RefreshHighlights()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x7DFC60", Offset = "0x7DFC60", VA = "0x7DFC60")]
		[ContextMenu("Refresh")]
		private void EditorRefresh()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x7DFEE8", Offset = "0x7DFEE8", VA = "0x7DFEE8")]
		public GroundAmmoManager()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class GroundAmmoManagerShapes : MonoBehaviour
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Disc Container;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GroundAmmoItem> List;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(1f, 180f)]
		public float TotalAngle;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color ContainerNoAmmo;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color ContainerRegular;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color ContainerHighlight;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Color ItemRegular;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Color ItemHighlight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Color ItemTaken;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Color ItemNocked;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Color ItemAwarded;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public LocalizationParamsManager Label;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _count;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _taken;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _nocked;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _highlighted;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int _awarded;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _visibleItems;

		[Token(Token = "0x400033B")]
		private const float _mainDirectionAngle = 0f;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _directionAngle;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float _itemAngle;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _spacingAngle;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Tween _angleTween;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Tween _directionTween;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x7DFF10", Offset = "0x7DFF10", VA = "0x7DFF10")]
		private void Awake()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x7E0534", Offset = "0x7E0534", VA = "0x7E0534")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x7E0B30", Offset = "0x7E0B30", VA = "0x7E0B30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x7E107C", Offset = "0x7E107C", VA = "0x7E107C")]
		private void TakeArrow(EDKG.ArcheryRange.VR.Arrow arrow)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x7E108C", Offset = "0x7E108C", VA = "0x7E108C")]
		private void ReturnArrow()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x7E109C", Offset = "0x7E109C", VA = "0x7E109C")]
		private void NockArrow()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x7E10B4", Offset = "0x7E10B4", VA = "0x7E10B4")]
		private void ShootArrow(int count)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x7E10E4", Offset = "0x7E10E4", VA = "0x7E10E4")]
		private void AwardArrow(int count, int realCount)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x7E1114", Offset = "0x7E1114", VA = "0x7E1114")]
		private void AwardArrowReceived(int received, int count)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x7E1128", Offset = "0x7E1128", VA = "0x7E1128")]
		private void QuiverStartHover()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x7E1138", Offset = "0x7E1138", VA = "0x7E1138")]
		private void QuiverEndHover()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x7E1148", Offset = "0x7E1148", VA = "0x7E1148")]
		private void QuiverNoAmmo()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x7E0B6C", Offset = "0x7E0B6C", VA = "0x7E0B6C")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x7E0FB0", Offset = "0x7E0FB0", VA = "0x7E0FB0")]
		private void UpdateAmmoLabel()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x7E114C", Offset = "0x7E114C", VA = "0x7E114C")]
		private void Update()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x7E0D1C", Offset = "0x7E0D1C", VA = "0x7E0D1C")]
		private void RefreshHighlights()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x7E12C0", Offset = "0x7E12C0", VA = "0x7E12C0")]
		[ContextMenu("Refresh")]
		private void EditorRefresh()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x7E1560", Offset = "0x7E1560", VA = "0x7E1560")]
		public GroundAmmoManagerShapes()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class GroundAmmoManagerSimple : MonoBehaviour
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RingGenerator Container;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(1f, 180f)]
		public float TotalAngle;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color ContainerRegular;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color ContainerHighlight;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _highlighted;

		[Token(Token = "0x4000347")]
		private const float _mainDirectionAngle = 0f;

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x7E1588", Offset = "0x7E1588", VA = "0x7E1588")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x7E177C", Offset = "0x7E177C", VA = "0x7E177C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x7E1970", Offset = "0x7E1970", VA = "0x7E1970")]
		private void Start()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x7E19DC", Offset = "0x7E19DC", VA = "0x7E19DC")]
		private void QuiverStartHover()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x7E19EC", Offset = "0x7E19EC", VA = "0x7E19EC")]
		private void QuiverEndHover()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x7E19FC", Offset = "0x7E19FC", VA = "0x7E19FC")]
		private void QuiverNoAmmo()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x7E1978", Offset = "0x7E1978", VA = "0x7E1978")]
		private void RefreshHighlights()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x7E1A00", Offset = "0x7E1A00", VA = "0x7E1A00")]
		[ContextMenu("Refresh")]
		private void EditorRefresh()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x7E1A78", Offset = "0x7E1A78", VA = "0x7E1A78")]
		public GroundAmmoManagerSimple()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class InGameStats : MonoBehaviour
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _bowStatsPivot;

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x7E1A88", Offset = "0x7E1A88", VA = "0x7E1A88")]
		private void Start()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x7E1B18", Offset = "0x7E1B18", VA = "0x7E1B18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x7E1C20", Offset = "0x7E1C20", VA = "0x7E1C20")]
		public InGameStats()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class VRCrosshairToggle : MonoBehaviour
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnToggle;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference ActionReference;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputAction _action;

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x7E1C28", Offset = "0x7E1C28", VA = "0x7E1C28")]
		private void Awake()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x7E1CC8", Offset = "0x7E1CC8", VA = "0x7E1CC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x7E1D54", Offset = "0x7E1D54", VA = "0x7E1D54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x7E1D70", Offset = "0x7E1D70", VA = "0x7E1D70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x7E1D8C", Offset = "0x7E1D8C", VA = "0x7E1D8C")]
		private void OnToggleEvent(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x7E1DEC", Offset = "0x7E1DEC", VA = "0x7E1DEC")]
		public VRCrosshairToggle()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class VRDebugPanelToggle : MonoBehaviour
	{
		[Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class <DelayedPanelSetup>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mainPanel;

			[Token(Token = "0x17000080")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x7E27C4", Offset = "0x7E27C4", VA = "0x7E27C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x7E280C", Offset = "0x7E280C", VA = "0x7E280C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x7E24A0", Offset = "0x7E24A0", VA = "0x7E24A0")]
			[DebuggerHidden]
			public <DelayedPanelSetup>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x7E2684", Offset = "0x7E2684", VA = "0x7E2684", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x7E2688", Offset = "0x7E2688", VA = "0x7E2688", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x7E27CC", Offset = "0x7E27CC", VA = "0x7E27CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform LeftHand;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputActionReference ActionReference;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InputAction _action;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VRUIControllerActivation _vrUIControllerActivation;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x7E1DF4", Offset = "0x7E1DF4", VA = "0x7E1DF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x7E1FB4", Offset = "0x7E1FB4", VA = "0x7E1FB4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x7E2128", Offset = "0x7E2128", VA = "0x7E2128")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x7E2144", Offset = "0x7E2144", VA = "0x7E2144")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x7E2160", Offset = "0x7E2160", VA = "0x7E2160")]
		private void Start()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x7E2438", Offset = "0x7E2438", VA = "0x7E2438")]
		[IteratorStateMachine(typeof(<DelayedPanelSetup>d__9))]
		private IEnumerator DelayedPanelSetup(Transform mainPanel)
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x7E24C8", Offset = "0x7E24C8", VA = "0x7E24C8")]
		private void OnToggleEvent(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x7E2640", Offset = "0x7E2640", VA = "0x7E2640")]
		private void OnPanelVisibilityChanged(bool value)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x7E267C", Offset = "0x7E267C", VA = "0x7E267C")]
		public VRDebugPanelToggle()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class VRPauseToggle : MonoBehaviour
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnPauseToggle;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference PauseToggleActionReference;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputAction _pauseToggleAction;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x7E2814", Offset = "0x7E2814", VA = "0x7E2814")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x7E28B4", Offset = "0x7E28B4", VA = "0x7E28B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x7E2940", Offset = "0x7E2940", VA = "0x7E2940")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x7E295C", Offset = "0x7E295C", VA = "0x7E295C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x7E2978", Offset = "0x7E2978", VA = "0x7E2978")]
		private void OnPauseToggleEvent(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x7E29D8", Offset = "0x7E29D8", VA = "0x7E29D8")]
		public VRPauseToggle()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class VRScreenshot : MonoBehaviour
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference ActionReference;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputAction _action;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference ActionReference2;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InputAction _action2;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Supersampling;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int Supersampling2;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int FOVOverride;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool FollowCamera;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera _camera;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera _targetCamera;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RenderTexture _renderTexture;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _folder;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x7E29E0", Offset = "0x7E29E0", VA = "0x7E29E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x7E2B50", Offset = "0x7E2B50", VA = "0x7E2B50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x7E2C30", Offset = "0x7E2C30", VA = "0x7E2C30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x7E2C60", Offset = "0x7E2C60", VA = "0x7E2C60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x7E2C90", Offset = "0x7E2C90", VA = "0x7E2C90")]
		private void OnPerformed(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x7E3020", Offset = "0x7E3020", VA = "0x7E3020")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x7E2C94", Offset = "0x7E2C94", VA = "0x7E2C94")]
		[ContextMenu("Capture")]
		private void Capture()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x7E30F4", Offset = "0x7E30F4", VA = "0x7E30F4")]
		private void OnPerformed2(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x7E31BC", Offset = "0x7E31BC", VA = "0x7E31BC")]
		public VRScreenshot()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class VRScroll : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference ScrollActionReference;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SpeedModifier;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InputAction _scrollAction;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ScrollRect _scrollRect;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isPointerEntered;

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x7E3224", Offset = "0x7E3224", VA = "0x7E3224")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x7E32F4", Offset = "0x7E32F4", VA = "0x7E32F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x7E3380", Offset = "0x7E3380", VA = "0x7E3380")]
		private void OnScrollEvent(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x7E3474", Offset = "0x7E3474", VA = "0x7E3474", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x7E3480", Offset = "0x7E3480", VA = "0x7E3480", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x7E3488", Offset = "0x7E3488", VA = "0x7E3488")]
		public VRScroll()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class VRUIControllerActivation : MonoBehaviour
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static VRUIControllerActivation Instance;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject LeftController;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject RightController;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isUIControllerRequired;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool _uiScreenNeeded;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool _debugScreenNeeded;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _bowHand;

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x7E3498", Offset = "0x7E3498", VA = "0x7E3498")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x7E3640", Offset = "0x7E3640", VA = "0x7E3640")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x7E3750", Offset = "0x7E3750", VA = "0x7E3750")]
		private void OnBowPicked(Bow bow, int hand, XRDirectInteractor controller)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x7E37E8", Offset = "0x7E37E8", VA = "0x7E37E8")]
		public void UIScreenToggle(int state)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x7E2668", Offset = "0x7E2668", VA = "0x7E2668")]
		public void DebugScreenToggle(bool value)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x7E3758", Offset = "0x7E3758", VA = "0x7E3758")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x7E386C", Offset = "0x7E386C", VA = "0x7E386C")]
		public VRUIControllerActivation()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class ArrowPositioning : MonoBehaviour
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float HorizontalOffset;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform DummyArrowAttachPoint;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform DummyArrowHead;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform BowHandle;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 _horizontalOffsetPosition;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 _dummyDirection;

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x7E3874", Offset = "0x7E3874", VA = "0x7E3874")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x7E3984", Offset = "0x7E3984", VA = "0x7E3984")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x7E3A94", Offset = "0x7E3A94", VA = "0x7E3A94")]
		private void OnBowPicked(Bow bow, int hand, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x7E3B1C", Offset = "0x7E3B1C", VA = "0x7E3B1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x7E3C18", Offset = "0x7E3C18", VA = "0x7E3C18")]
		public ArrowPositioning()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class HandStaminaVisualization : MonoBehaviour
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer _renderer;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material _material;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color StaminaFull;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color StaminaEmpty;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color FatigueEmpty;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color FatigueFull;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int Color0;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int Color1;

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x7E3C2C", Offset = "0x7E3C2C", VA = "0x7E3C2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x7E3F84", Offset = "0x7E3F84", VA = "0x7E3F84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x7E418C", Offset = "0x7E418C", VA = "0x7E418C")]
		private void OnBowPickedEvent(Bow bow, int hand, XRDirectInteractor handInteractor)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x7E41D8", Offset = "0x7E41D8", VA = "0x7E41D8")]
		private void OnBowDroppedEvent(Bow bow, int hand, XRDirectInteractor handInteractor)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x7E41F8", Offset = "0x7E41F8", VA = "0x7E41F8")]
		private void OnStaminaAndFatigueChangingEvent(float stamina, float fatigue)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x7E3E44", Offset = "0x7E3E44", VA = "0x7E3E44")]
		private void UpdateStamina(float stamina, float fatigue)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x7E41FC", Offset = "0x7E41FC", VA = "0x7E41FC")]
		public HandStaminaVisualization()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class VRRecenter : MonoBehaviour
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference RecenterAction;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<XRInputSubsystem> _inputSubsystems;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InputAction _recenterAction;

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x7E42C4", Offset = "0x7E42C4", VA = "0x7E42C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x7E43F4", Offset = "0x7E43F4", VA = "0x7E43F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x7E4480", Offset = "0x7E4480", VA = "0x7E4480")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x7E449C", Offset = "0x7E449C", VA = "0x7E449C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x7E44B8", Offset = "0x7E44B8", VA = "0x7E44B8")]
		private void OnRecenter(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x7E4544", Offset = "0x7E4544", VA = "0x7E4544")]
		public VRRecenter()
		{
		}
	}
}
namespace EDKG.ArcheryRange.VR
{
	[Token(Token = "0x200009F")]
	public class Arrow : XRGrabInteractable
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<Arrow> OnPicked;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action OnGoingHome;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action OnArrivedHome;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action OnNocked;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool _isNocked;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool _isShot;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Transform _home;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private LayerMask _noneLayerMask;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private LayerMask _initialLayerMask;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private LayerMask _socketedLayerMask;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Action _onDestroyCallback;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private CustomInteractionManager _customInteractionManager;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x7E454C", Offset = "0x7E454C", VA = "0x7E454C", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x7E46FC", Offset = "0x7E46FC", VA = "0x7E46FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x7E479C", Offset = "0x7E479C", VA = "0x7E479C")]
		public void Init(SpawnPool spawnPool, Transform home, Action onDestroyCallback)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x7E4840", Offset = "0x7E4840", VA = "0x7E4840")]
		public void Nock()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x7E48B4", Offset = "0x7E48B4", VA = "0x7E48B4")]
		public void Shoot()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x7E4980", Offset = "0x7E4980", VA = "0x7E4980", Slot = "24")]
		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x7E49B4", Offset = "0x7E49B4", VA = "0x7E49B4")]
		private void GoHome()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x7E4BB4", Offset = "0x7E4BB4", VA = "0x7E4BB4")]
		private void OnGoHomeComplete()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x7E48C0", Offset = "0x7E48C0", VA = "0x7E48C0")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x7E4C14", Offset = "0x7E4C14", VA = "0x7E4C14")]
		private void OnGamePaused(bool value)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x7E4CE0", Offset = "0x7E4CE0", VA = "0x7E4CE0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x7E4E04", Offset = "0x7E4E04", VA = "0x7E4E04")]
		public Arrow()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class ArrowAutoGrabber : MonoBehaviour
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference LeftGrabAction;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputAction _leftGrabAction;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference RightGrabAction;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InputAction _rightGrabAction;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isGrabbing;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isGrabbingLeft;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool _isGrabbingRight;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _bowHand;

		[Token(Token = "0x17000082")]
		public bool IsGrabbing
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x7E4E0C", Offset = "0x7E4E0C", VA = "0x7E4E0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x7E4E14", Offset = "0x7E4E14", VA = "0x7E4E14")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x7E5090", Offset = "0x7E5090", VA = "0x7E5090")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x7E52E4", Offset = "0x7E52E4", VA = "0x7E52E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x7E5314", Offset = "0x7E5314", VA = "0x7E5314")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x7E5344", Offset = "0x7E5344", VA = "0x7E5344")]
		private void OnLeftGrab(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x7E53B4", Offset = "0x7E53B4", VA = "0x7E53B4")]
		private void OnLeftRelease(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x7E541C", Offset = "0x7E541C", VA = "0x7E541C")]
		private void OnRightGrab(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x7E548C", Offset = "0x7E548C", VA = "0x7E548C")]
		private void OnRightRelease(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x7E54F4", Offset = "0x7E54F4", VA = "0x7E54F4")]
		public void ConfirmGrab()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x7E54FC", Offset = "0x7E54FC", VA = "0x7E54FC")]
		private void OnBowPickedEvent(Bow bow, int hand, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x7E5528", Offset = "0x7E5528", VA = "0x7E5528")]
		public ArrowAutoGrabber()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class Body : MonoBehaviour
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Head;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRBaseInteractor HandLeftInteractor;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public XRBaseInteractor HandRightInteractor;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform HandLeftModel;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform HandLeftModelAttach;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Renderer HandLeftRenderer;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform HandRightModel;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform HandRightModelAttach;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Renderer HandRightRenderer;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform QuiverLine;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform BodyPivot;

		[Token(Token = "0x17000083")]
		public float Calibration
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x7E5530", Offset = "0x7E5530", VA = "0x7E5530")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x7E5538", Offset = "0x7E5538", VA = "0x7E5538")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x7E5540", Offset = "0x7E5540", VA = "0x7E5540")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x7E55E4", Offset = "0x7E55E4", VA = "0x7E55E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x7E56C0", Offset = "0x7E56C0", VA = "0x7E56C0")]
		public void SetCalibration(float value)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x7E56C8", Offset = "0x7E56C8", VA = "0x7E56C8")]
		public Body()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class Bow : XRGrabInteractable
	{
		[Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class <DelayedStart>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Bow <>4__this;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004DA")]
				[Address(RVA = "0x7E73BC", Offset = "0x7E73BC", VA = "0x7E73BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004DC")]
				[Address(RVA = "0x7E7404", Offset = "0x7E7404", VA = "0x7E7404", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x7E5BDC", Offset = "0x7E5BDC", VA = "0x7E5BDC")]
			[DebuggerHidden]
			public <DelayedStart>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x7E7314", Offset = "0x7E7314", VA = "0x7E7314", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x7E7318", Offset = "0x7E7318", VA = "0x7E7318", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x7E73C4", Offset = "0x7E73C4", VA = "0x7E73C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class <RestoreTracking>d__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Bow <>4__this;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <timeCounter>5__2;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool <stillGoing>5__3;

			[Token(Token = "0x17000088")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E0")]
				[Address(RVA = "0x7E781C", Offset = "0x7E781C", VA = "0x7E781C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004E2")]
				[Address(RVA = "0x7E7864", Offset = "0x7E7864", VA = "0x7E7864", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x7E6E08", Offset = "0x7E6E08", VA = "0x7E6E08")]
			[DebuggerHidden]
			public <RestoreTracking>d__41(int <>1__state)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x7E740C", Offset = "0x7E740C", VA = "0x7E740C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x7E7410", Offset = "0x7E7410", VA = "0x7E7410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x7E7824", Offset = "0x7E7824", VA = "0x7E7824", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int BowHand;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Bow, int, XRDirectInteractor> OnPicked;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<Bow, int, XRDirectInteractor> OnDropped;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public Transform StatsPivot;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public Transform ArrowShotPivot;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public NockSocket NockSocket;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public NockSlot NockSlot;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public NockPuller NockPuller;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private XRDirectInteractor _handInteractor;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Body _body;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private bool _isCustomRotation;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Quaternion _targetRotation;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Vector3 _pullVector;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float _pullDistance;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private BowHolster _home;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private bool _isHome;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private CustomInteractionManager _customInteractionManager;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private XRDirectInteractor _nockHandInteractor;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private Transform _handModelTransform;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private Transform _handModelAttachTransform;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private Transform _hand2ModelTransform;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Transform _hand2ModelAttachTransform;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private OneEuroFilterQ _bowHandRot;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private float _bowShakingPercent;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private float _bowSmoothingPercent;

		[Token(Token = "0x17000084")]
		public Body Body
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x7E56D0", Offset = "0x7E56D0", VA = "0x7E56D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public XRDirectInteractor HandInteractor
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x7E56D8", Offset = "0x7E56D8", VA = "0x7E56D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x7E56E0", Offset = "0x7E56E0", VA = "0x7E56E0", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x7E5B54", Offset = "0x7E5B54", VA = "0x7E5B54")]
		private void Start()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x7E5B74", Offset = "0x7E5B74", VA = "0x7E5B74")]
		[IteratorStateMachine(typeof(<DelayedStart>d__31))]
		private IEnumerator DelayedStart()
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x7E5C04", Offset = "0x7E5C04", VA = "0x7E5C04", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x7E6110", Offset = "0x7E6110", VA = "0x7E6110", Slot = "22")]
		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x7E6388", Offset = "0x7E6388", VA = "0x7E6388")]
		private void DetermineHand(XRBaseInteractor interactor)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x7E6430", Offset = "0x7E6430", VA = "0x7E6430")]
		private void GoToHand()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x7E6534", Offset = "0x7E6534", VA = "0x7E6534", Slot = "24")]
		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x7E6614", Offset = "0x7E6614", VA = "0x7E6614")]
		private void GoHome(bool instant = false)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x7E68C4", Offset = "0x7E68C4", VA = "0x7E68C4")]
		private void OnNockStartedPullingEvent()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x7E6A6C", Offset = "0x7E6A6C", VA = "0x7E6A6C")]
		private void OnNockPulledEvent(Vector3 vector, float pullDistance, float pullDistanceFromHandle, float amount, float calibratedPullDistance, float calibratedAmount)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x7E6BD0", Offset = "0x7E6BD0", VA = "0x7E6BD0")]
		private void OnNockReleasedEvent(float amount)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x7E6D90", Offset = "0x7E6D90", VA = "0x7E6D90")]
		[IteratorStateMachine(typeof(<RestoreTracking>d__41))]
		private IEnumerator RestoreTracking(float time)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x7E5F68", Offset = "0x7E5F68", VA = "0x7E5F68")]
		private void RestoreTrackingImmediately()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x7E6E30", Offset = "0x7E6E30", VA = "0x7E6E30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x7E7274", Offset = "0x7E7274", VA = "0x7E7274")]
		private void OnShakingChangedEvent(float percent, float amplitude)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x7E7298", Offset = "0x7E7298", VA = "0x7E7298")]
		private void OnSmoothingChangedEvent(float value)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x7E6EFC", Offset = "0x7E6EFC", VA = "0x7E6EFC")]
		private void UpdateRotation()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x7E72B4", Offset = "0x7E72B4", VA = "0x7E72B4")]
		public Bow()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class CustomInteractionManager : XRInteractionManager
	{
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x7E4C48", Offset = "0x7E4C48", VA = "0x7E4C48")]
		public void ForceDeselect(XRBaseInteractor interactor)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x7E786C", Offset = "0x7E786C", VA = "0x7E786C")]
		public CustomInteractionManager()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class ForceGrabBow : MonoBehaviour
	{
		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference ForceGrabBowLeftAction;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputAction _forceGrabBowLeftAction;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference ForceGrabBowRightAction;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InputAction _forceGrabBowRightAction;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Bow _bow;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Body _body;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isGamePaused;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CustomInteractionManager _customInteractionManager;

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x7E78C4", Offset = "0x7E78C4", VA = "0x7E78C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x7E7A98", Offset = "0x7E7A98", VA = "0x7E7A98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x7E7C44", Offset = "0x7E7C44", VA = "0x7E7C44")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x7E7D68", Offset = "0x7E7D68", VA = "0x7E7D68")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x7E7D98", Offset = "0x7E7D98", VA = "0x7E7D98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x7E7DC8", Offset = "0x7E7DC8", VA = "0x7E7DC8")]
		private void OnForceGrabBowLeft(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x7E7E60", Offset = "0x7E7E60", VA = "0x7E7E60")]
		private void OnForceGrabBowRight(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x7E7EF8", Offset = "0x7E7EF8", VA = "0x7E7EF8")]
		private void OnGamePaused(bool value)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x7E7F04", Offset = "0x7E7F04", VA = "0x7E7F04")]
		public ForceGrabBow()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class NockPuller : XRBaseInteractable
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnNockStartedPulling;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Vector3, float, float, float, float, float> OnNockPulling;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<float> OnNockReleased;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Bow Bow;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public float MaxPullDistance;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public MeshRenderer NockHighlighter;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Transform _handInteractor;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float _distanceFromHandle;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private bool _isActive;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 _pullVector;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float _pullDistance;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float _pullAmount;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float _calibration;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _calibratedMaxPullDistance;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float _calibratedPullDistance;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float _calibratedPullAmount;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private CustomInteractionManager _customInteractionManager;

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x7E7F0C", Offset = "0x7E7F0C", VA = "0x7E7F0C", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x7E8150", Offset = "0x7E8150", VA = "0x7E8150")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x7E8184", Offset = "0x7E8184", VA = "0x7E8184", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x7E6378", Offset = "0x7E6378", VA = "0x7E6378")]
		public void SetBowStatus(bool active)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x7E82DC", Offset = "0x7E82DC", VA = "0x7E82DC", Slot = "22")]
		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x7E839C", Offset = "0x7E839C", VA = "0x7E839C", Slot = "24")]
		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x7E8450", Offset = "0x7E8450", VA = "0x7E8450", Slot = "18")]
		protected override void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x7E8508", Offset = "0x7E8508", VA = "0x7E8508", Slot = "14")]
		public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x7E854C", Offset = "0x7E854C", VA = "0x7E854C")]
		private void CalculatePull()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x7E8388", Offset = "0x7E8388", VA = "0x7E8388")]
		private void ResetPull()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x7E8738", Offset = "0x7E8738", VA = "0x7E8738")]
		private void OnGamePaused(bool value)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x7E8774", Offset = "0x7E8774", VA = "0x7E8774")]
		public NockPuller()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class NockSlot : MonoBehaviour
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnNocked;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NockPuller NockPuller;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DistanceToNock;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _isActive;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Arrow _potentialArrow;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Arrow _nockedArrow;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CustomInteractionManager _customInteractionManager;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x7E8784", Offset = "0x7E8784", VA = "0x7E8784")]
		protected void Awake()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x7E8B1C", Offset = "0x7E8B1C", VA = "0x7E8B1C")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x7E8E70", Offset = "0x7E8E70", VA = "0x7E8E70")]
		public void SetBowStatus(bool active)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x7E8E7C", Offset = "0x7E8E7C", VA = "0x7E8E7C")]
		private void OnArrowPickedEvent(Arrow arrow)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x7E8E84", Offset = "0x7E8E84", VA = "0x7E8E84")]
		private void OnArrowGoingHomeEvent()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x7E8E8C", Offset = "0x7E8E8C", VA = "0x7E8E8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x7E8E9C", Offset = "0x7E8E9C", VA = "0x7E8E9C")]
		private void ProcessNocking()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x7E9058", Offset = "0x7E9058", VA = "0x7E9058")]
		private void OnShootArrowEvent()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x7E90DC", Offset = "0x7E90DC", VA = "0x7E90DC")]
		private void OnNockPulledEvent(Vector3 vector, float pullDistance, float pullDistanceFromHandle, float amount, float calibratedPullDistance, float calibratedAmount)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x7E915C", Offset = "0x7E915C", VA = "0x7E915C")]
		private void OnNockReleasedEvent(float amount)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x7E91C4", Offset = "0x7E91C4", VA = "0x7E91C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x7E92DC", Offset = "0x7E92DC", VA = "0x7E92DC")]
		public NockSlot()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class NockSocket : XRSocketInteractor
	{
		[Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class <DelayedReactivation>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NockSocket <>4__this;

			[Token(Token = "0x1700008A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000515")]
				[Address(RVA = "0x7E9D4C", Offset = "0x7E9D4C", VA = "0x7E9D4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000517")]
				[Address(RVA = "0x7E9D94", Offset = "0x7E9D94", VA = "0x7E9D94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x7E9B38", Offset = "0x7E9B38", VA = "0x7E9B38")]
			[DebuggerHidden]
			public <DelayedReactivation>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x7E9CA0", Offset = "0x7E9CA0", VA = "0x7E9CA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x7E9CA4", Offset = "0x7E9CA4", VA = "0x7E9CA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x7E9D54", Offset = "0x7E9D54", VA = "0x7E9D54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnNocked;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public NockPuller NockPuller;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _isActive;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Arrow _arrow;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private CustomInteractionManager _customInteractionManager;

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x7E92F0", Offset = "0x7E92F0", VA = "0x7E92F0", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x7E957C", Offset = "0x7E957C", VA = "0x7E957C", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x7E9794", Offset = "0x7E9794", VA = "0x7E9794")]
		public void SetBowStatus(bool active)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x7E97A0", Offset = "0x7E97A0", VA = "0x7E97A0", Slot = "13")]
		public override bool CanHover(XRBaseInteractable interactable)
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x7E983C", Offset = "0x7E983C", VA = "0x7E983C", Slot = "14")]
		public override bool CanSelect(XRBaseInteractable interactable)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x7E98CC", Offset = "0x7E98CC", VA = "0x7E98CC", Slot = "20")]
		protected override void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x7E9A0C", Offset = "0x7E9A0C", VA = "0x7E9A0C")]
		private void OnShootArrowEvent()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x7E9A90", Offset = "0x7E9A90", VA = "0x7E9A90", Slot = "26")]
		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x7E9AD0", Offset = "0x7E9AD0", VA = "0x7E9AD0")]
		[IteratorStateMachine(typeof(<DelayedReactivation>d__13))]
		private IEnumerator DelayedReactivation()
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x7E9B60", Offset = "0x7E9B60", VA = "0x7E9B60")]
		private void OnNockPulledEvent(Vector3 vector, float pullDistance, float pullDistanceFromHandle, float amount, float calibratedPullDistance, float calibratedAmount)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x7E9BE0", Offset = "0x7E9BE0", VA = "0x7E9BE0")]
		private void OnNockReleasedEvent(float amount)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x7E9C48", Offset = "0x7E9C48", VA = "0x7E9C48")]
		public NockSocket()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class Quiver : XRBaseInteractable
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnHoverStarted;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action OnHoverEnded;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action OnNoAmmo;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action OnAmmoReceived;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Renderer Renderer;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Material[] Materials;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Transform ArrowContainer;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Body _body;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Arrow _arrowPrefab;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private SpawnPool _pool;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ArrowAutoGrabber _arrowAutoGrabber;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool _arrowTaken;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		private bool _noAmmo;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		private bool _gameEnded;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x133")]
		private bool _tutorialDisable;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x7E9D9C", Offset = "0x7E9D9C", VA = "0x7E9D9C", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x7EA010", Offset = "0x7EA010", VA = "0x7EA010", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x7EA284", Offset = "0x7EA284", VA = "0x7EA284")]
		private void Start()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x7EA3AC", Offset = "0x7EA3AC", VA = "0x7EA3AC", Slot = "22")]
		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x7EA3F4", Offset = "0x7EA3F4", VA = "0x7EA3F4")]
		private void GrabArrow(XRBaseInteractor interactor)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x7EA604", Offset = "0x7EA604", VA = "0x7EA604", Slot = "18")]
		protected override void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x7EA7AC", Offset = "0x7EA7AC", VA = "0x7EA7AC", Slot = "20")]
		protected override void OnHoverExited(HoverExitEventArgs args)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x7EA8BC", Offset = "0x7EA8BC", VA = "0x7EA8BC")]
		private void ReEnableHover()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x7EA8E0", Offset = "0x7EA8E0", VA = "0x7EA8E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x7EA998", Offset = "0x7EA998", VA = "0x7EA998")]
		[ContextMenu("Update")]
		private void UpdateInEditor()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x7EA99C", Offset = "0x7EA99C", VA = "0x7EA99C")]
		private void OnNoAmmoEvent(int amount)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x7EAA20", Offset = "0x7EAA20", VA = "0x7EAA20")]
		private void OnAvailableAmmoChangedEvent(int count, int realCount)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x7EAAB0", Offset = "0x7EAAB0", VA = "0x7EAAB0")]
		private void OnGameEndedEvent(int results)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x7EA730", Offset = "0x7EA730", VA = "0x7EA730")]
		private void RefreshMaterial()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x7EAAC4", Offset = "0x7EAAC4", VA = "0x7EAAC4")]
		public void DisableForTutorial(bool value)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x7EAAD0", Offset = "0x7EAAD0", VA = "0x7EAAD0")]
		public Quiver()
		{
		}
	}
}
namespace EDKG.ArcheryRange.VR.Visualization
{
	[Token(Token = "0x20000AC")]
	public class BowAnimation : MonoBehaviour
	{
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator Animator;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _animationDrawingHash;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _animationStartDrawingHash;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _animationReleaseHash;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _animationCancelHash;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x7EAAD8", Offset = "0x7EAAD8", VA = "0x7EAAD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x7EACCC", Offset = "0x7EACCC", VA = "0x7EACCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x7EAE28", Offset = "0x7EAE28", VA = "0x7EAE28")]
		private void OnNockStartedPullingEvent()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x7EAE4C", Offset = "0x7EAE4C", VA = "0x7EAE4C")]
		private void OnNockPullingEvent(float amount, float rawAmount)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x7EAE74", Offset = "0x7EAE74", VA = "0x7EAE74")]
		private void OnArrowReleasedEvent()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x7EAE98", Offset = "0x7EAE98", VA = "0x7EAE98")]
		private void OnCancelPullEvent()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x7EAEBC", Offset = "0x7EAEBC", VA = "0x7EAEBC")]
		public BowAnimation()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class BowPullAmountVisualizer : MonoBehaviour
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Text;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform DrawBar;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform StaminaBar;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Image StaminaBarImage;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color FullStamina;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color NoStamina;

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x7EAEC4", Offset = "0x7EAEC4", VA = "0x7EAEC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x7EB158", Offset = "0x7EB158", VA = "0x7EB158")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x7EB218", Offset = "0x7EB218", VA = "0x7EB218")]
		private void OnDrawChangingEvent(float amount, float rawAmount)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x7EB240", Offset = "0x7EB240", VA = "0x7EB240")]
		private void OnStaminaAndFatigueChangingEvent(float stamina, float fatigue)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x7EAFA8", Offset = "0x7EAFA8", VA = "0x7EAFA8")]
		private void UpdateLabel(float amount)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x7EB068", Offset = "0x7EB068", VA = "0x7EB068")]
		private void UpdateDrawBar(float amount)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x7EB0A8", Offset = "0x7EB0A8", VA = "0x7EB0A8")]
		private void UpdateStaminaBar(float amount)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x7EB244", Offset = "0x7EB244", VA = "0x7EB244")]
		public BowPullAmountVisualizer()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class BowShaking : MonoBehaviour
	{
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Bow Bow;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private XRDirectInteractor _interactor;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _attach;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x7EB264", Offset = "0x7EB264", VA = "0x7EB264")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x7EB3C8", Offset = "0x7EB3C8", VA = "0x7EB3C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x7EB52C", Offset = "0x7EB52C", VA = "0x7EB52C")]
		private void OnBowPickedEvent(Bow bow, int hand, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x7EB560", Offset = "0x7EB560", VA = "0x7EB560")]
		private void OnShakingChangedEvent(float percent, float amplitude)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x7EB780", Offset = "0x7EB780", VA = "0x7EB780")]
		public BowShaking()
		{
		}
	}
}
namespace EDKG.ArcheryRange.VR.Helper
{
	[Token(Token = "0x20000AF")]
	public class FocusLostDisabler : MonoBehaviour
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _hasFocus;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] ToDisable;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Canvas[] CanvasToDisable;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer[] RendererToDisable;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MonoBehaviour[] ComponentsToDisable;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x7EB788", Offset = "0x7EB788", VA = "0x7EB788")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x7EB794", Offset = "0x7EB794", VA = "0x7EB794")]
		private void ProcessObjects()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x7EB900", Offset = "0x7EB900", VA = "0x7EB900")]
		public FocusLostDisabler()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI
{
	[Token(Token = "0x20000B0")]
	public class Temp : MonoBehaviour
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform Target;

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x7EB908", Offset = "0x7EB908", VA = "0x7EB908")]
		[ContextMenu("Print")]
		public void PrintPos()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x7EBCAC", Offset = "0x7EBCAC", VA = "0x7EBCAC")]
		public Temp()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class UIManager : MonoBehaviour
	{
		[Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class <DisableCanvasScaler>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIManager <>4__this;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600054C")]
				[Address(RVA = "0x7EC160", Offset = "0x7EC160", VA = "0x7EC160", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600054E")]
				[Address(RVA = "0x7EC1A8", Offset = "0x7EC1A8", VA = "0x7EC1A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x7EBF70", Offset = "0x7EBF70", VA = "0x7EBF70")]
			[DebuggerHidden]
			public <DisableCanvasScaler>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x7EC0C4", Offset = "0x7EC0C4", VA = "0x7EC0C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x7EC0C8", Offset = "0x7EC0C8", VA = "0x7EC0C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x7EC168", Offset = "0x7EC168", VA = "0x7EC168", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool IsInitialized;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int OverrideStartingScreen;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIScreen[] Screens;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int InitializationScreen;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int StartingScreen;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasScaler _canvasScaler;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Canvas _canvas;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _curScreenId;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UIScreen _curScreen;

		[Token(Token = "0x1700008C")]
		public int LastScreenId
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x7EBCB4", Offset = "0x7EBCB4", VA = "0x7EBCB4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x7EBCBC", Offset = "0x7EBCBC", VA = "0x7EBCBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x7EBCC4", Offset = "0x7EBCC4", VA = "0x7EBCC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x7EBD40", Offset = "0x7EBD40", VA = "0x7EBD40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x7EBF08", Offset = "0x7EBF08", VA = "0x7EBF08")]
		[IteratorStateMachine(typeof(<DisableCanvasScaler>d__15))]
		private IEnumerator DisableCanvasScaler()
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x7EBF98", Offset = "0x7EBF98", VA = "0x7EBF98")]
		public void SwitchToScreen(int id)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x7EC064", Offset = "0x7EC064", VA = "0x7EC064")]
		public UIManager()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class ArmLengthCalibrationWindow : ModalWindow
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArmLengthCalibration ArmLengthCalibration;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI Value;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RectTransform ActualHuman;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject TriggerPulledL;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject TriggerPulledR;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject CalibrationComplete;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CanvasGroup ContinueButton;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _calibration;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action _onCalibrationCompleteCallback;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x7EC1B0", Offset = "0x7EC1B0", VA = "0x7EC1B0")]
		public void Init([Optional] Action onCalibrationComplete)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x7EC504", Offset = "0x7EC504", VA = "0x7EC504", Slot = "11")]
		protected override void BeforeHide()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x7EC6A8", Offset = "0x7EC6A8", VA = "0x7EC6A8")]
		private void OnTriggerPulled(bool left, bool right)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x7EC6EC", Offset = "0x7EC6EC", VA = "0x7EC6EC")]
		private void OnCalibrationComplete(float value, float value2)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x7EC3CC", Offset = "0x7EC3CC", VA = "0x7EC3CC")]
		private void RefreshCalibrationValues(float value, float value2)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x7EC708", Offset = "0x7EC708", VA = "0x7EC708")]
		public void MarkCalibrationComplete()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x7EC754", Offset = "0x7EC754", VA = "0x7EC754")]
		public void OnCancel()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x7EC760", Offset = "0x7EC760", VA = "0x7EC760")]
		public void OnContinue()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x7EC7A0", Offset = "0x7EC7A0", VA = "0x7EC7A0")]
		public ArmLengthCalibrationWindow()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI._Presets
{
	[Token(Token = "0x20000B4")]
	[CreateAssetMenu(fileName = "ColorPresets", menuName = "ScriptableObjects/Presets/Color Presets", order = 0)]
	public class ColorPresets : ScriptableObject
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color Regular;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color Regular075;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color Regular05;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color Regular035;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color Regular025;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color Regular0125;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color Regular00625;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color RedFull;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color Red;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color Red075;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Color Red07;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Color Red05;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color Red025;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Color YellowFull;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Color Yellow;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Color Yellow075;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Color Yellow05;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public Color Yellow031;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public Color Yellow025;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Color Yellow012;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Color BrightGreen;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public Color GreenFull;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public Color Green;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public Color Green075;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public Color Green05;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public Color Green025;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public Color Paper;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public Color DarkPaper;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public Color DarkerPaper;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public Color DarkestPaper;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public Color White;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public Color White075;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public Color White05;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public Color White025;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public Color White016;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public Color White015;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public Color White0125;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public Color White010;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public Color White00625;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public Color White005;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public Color Black;

		[Token(Token = "0x1700008F")]
		public static ColorPresets Instance
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x7EC7A8", Offset = "0x7EC7A8", VA = "0x7EC7A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x7EC7F0", Offset = "0x7EC7F0", VA = "0x7EC7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x7EC83C", Offset = "0x7EC83C", VA = "0x7EC83C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x7EC888", Offset = "0x7EC888", VA = "0x7EC888")]
		public ColorPresets()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[CreateAssetMenu(fileName = "StringPresets", menuName = "ScriptableObjects/Presets/String Presets", order = 0)]
	public class StringPresets : ScriptableObject
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Currencies")]
		public string StarIcon;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string TargetIcon;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string BullseyeIcon;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string PrimaryCurrencyIcon;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string PremiumAimAssistIcon;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string PremiumSlowmoIcon;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Currencies Tinted")]
		public string StarIconTinted;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string TargetIconTinted;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string BullseyeIconTinted;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string PrimaryCurrencyIconTinted;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string AimAssistIconTinted;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string SlowmoIconTinted;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Header("Currencies 2x")]
		public string StarIcon2x;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string TargetIcon2x;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string BullseyeIcon2x;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string PrimaryCurrencyIcon2x;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string PremiumAimAssistIcon2x;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string PremiumSlowmoIcon2x;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Header("Equipment Stats")]
		public string AccuracyIcon;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string ArrowSpeedIcon;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string DrawSpeedIcon;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public string StaminaIcon;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string ReloadSpeedIcon;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Header("Equipment Stats Tinted")]
		public string AccuracyIconTinted;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string ArrowSpeedIconTinted;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public string DrawSpeedIconTinted;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string StaminaIconTinted;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public string ReloadSpeedIconTinted;

		[Token(Token = "0x17000090")]
		public static StringPresets Instance
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x7EC890", Offset = "0x7EC890", VA = "0x7EC890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x7EC8D8", Offset = "0x7EC8D8", VA = "0x7EC8D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x7EC924", Offset = "0x7EC924", VA = "0x7EC924")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x7EC970", Offset = "0x7EC970", VA = "0x7EC970")]
		public static string GetCurrencyIconById(int id, bool tinted = false)
		{
			return null;
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x7ECB64", Offset = "0x7ECB64", VA = "0x7ECB64")]
		public static string GetEquipmentStatIconById(int id)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x7ECCD8", Offset = "0x7ECCD8", VA = "0x7ECCD8")]
		public StringPresets()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI._Global
{
	[Token(Token = "0x20000B6")]
	public class LongPressButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
	{
		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _timePressed;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _isDown;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool _isLongPress;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEvent OnClick;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent OnLongPress;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float LongPressTime;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ImageStatBarFill LongPressFill;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CanvasGroup _longPressFillImage;

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x7ED0CC", Offset = "0x7ED0CC", VA = "0x7ED0CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x7ED130", Offset = "0x7ED130", VA = "0x7ED130")]
		private void Update()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x7ED204", Offset = "0x7ED204", VA = "0x7ED204", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x7ED24C", Offset = "0x7ED24C", VA = "0x7ED24C", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x7ED280", Offset = "0x7ED280", VA = "0x7ED280", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x7ED29C", Offset = "0x7ED29C", VA = "0x7ED29C")]
		public LongPressButton()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class MenuBackgroundManager : MonoBehaviour
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MaximizingBackground MaximizingBackground;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Texture _expandTexture;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Texture _expandTextureBlur;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _expandTextureId;

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x7ED2B4", Offset = "0x7ED2B4", VA = "0x7ED2B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x7ED2E0", Offset = "0x7ED2E0", VA = "0x7ED2E0")]
		public void Expand(Texture tex, Texture texBlur, int textureId, Transform t)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x7ED348", Offset = "0x7ED348", VA = "0x7ED348")]
		public void ExpandInstant(Texture tex, Texture texBlur, int textureId, Transform t)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x7ED3AC", Offset = "0x7ED3AC", VA = "0x7ED3AC")]
		public void Contract()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x7ED438", Offset = "0x7ED438", VA = "0x7ED438")]
		private void OnContractComplete()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x7ED464", Offset = "0x7ED464", VA = "0x7ED464")]
		public MenuBackgroundManager()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI._Global.StatBar
{
	[Token(Token = "0x20000B8")]
	public class ImageStatBarColor : MonoBehaviour
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image[] Images;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color ActiveColor;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color InactiveColor;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int Value;

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x7ED46C", Offset = "0x7ED46C", VA = "0x7ED46C")]
		private void Start()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x7ED54C", Offset = "0x7ED54C", VA = "0x7ED54C")]
		public void SetValue(int value)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x7ED470", Offset = "0x7ED470", VA = "0x7ED470")]
		[ContextMenu("Refresh")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x7ED554", Offset = "0x7ED554", VA = "0x7ED554")]
		public ImageStatBarColor()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class ImageStatBarFill : MonoBehaviour
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform Fill;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float Value;

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x7ED56C", Offset = "0x7ED56C", VA = "0x7ED56C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x7ED1FC", Offset = "0x7ED1FC", VA = "0x7ED1FC")]
		public void SetValue(float value)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x7ED570", Offset = "0x7ED570", VA = "0x7ED570")]
		[ContextMenu("Refresh")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x7ED598", Offset = "0x7ED598", VA = "0x7ED598")]
		public ImageStatBarFill()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class ImageStatBarSprites : MonoBehaviour
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image[] Images;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite InactiveSprite;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sprite ActiveSprite;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int Value;

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x7ED5A0", Offset = "0x7ED5A0", VA = "0x7ED5A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x7ED630", Offset = "0x7ED630", VA = "0x7ED630")]
		public void SetValue(int value)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x7ED5A4", Offset = "0x7ED5A4", VA = "0x7ED5A4")]
		[ContextMenu("Refresh")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x7ED638", Offset = "0x7ED638", VA = "0x7ED638")]
		public ImageStatBarSprites()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI._Global.DynamicResizablePanels
{
	[Token(Token = "0x20000BB")]
	public class DynamicResizablePanel : MonoBehaviour
	{
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Button _button;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LayoutElement _layoutElement;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 _expandedSize;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected float _transitionTime;

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x7ED640", Offset = "0x7ED640", VA = "0x7ED640", Slot = "4")]
		public virtual void Init(float expandedSize)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x7ED650", Offset = "0x7ED650", VA = "0x7ED650", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x7ED6E4", Offset = "0x7ED6E4", VA = "0x7ED6E4", Slot = "6")]
		public virtual void Expand(bool instant = false)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x7ED7F4", Offset = "0x7ED7F4", VA = "0x7ED7F4", Slot = "7")]
		protected virtual void OnExpandComplete()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x7ED7F8", Offset = "0x7ED7F8", VA = "0x7ED7F8", Slot = "8")]
		public virtual void Contract(bool instant = false)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x7ED92C", Offset = "0x7ED92C", VA = "0x7ED92C", Slot = "9")]
		protected virtual void OnContractComplete()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x7ED94C", Offset = "0x7ED94C", VA = "0x7ED94C", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x7ED95C", Offset = "0x7ED95C", VA = "0x7ED95C")]
		public DynamicResizablePanel()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class DynamicResizablePanelContent : MonoBehaviour
	{
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x7ED970", Offset = "0x7ED970", VA = "0x7ED970", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x7ED9C0", Offset = "0x7ED9C0", VA = "0x7ED9C0")]
		public void Show(bool instant = false)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x7EDB2C", Offset = "0x7EDB2C", VA = "0x7EDB2C")]
		public void Hide(bool instant = false)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x7EDC70", Offset = "0x7EDC70", VA = "0x7EDC70")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x7EDCA8", Offset = "0x7EDCA8", VA = "0x7EDCA8", Slot = "5")]
		protected virtual void BeforeShow()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x7EDCAC", Offset = "0x7EDCAC", VA = "0x7EDCAC", Slot = "6")]
		protected virtual void AfterShow()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x7EDCB0", Offset = "0x7EDCB0", VA = "0x7EDCB0", Slot = "7")]
		protected virtual void BeforeHide()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x7EDCB4", Offset = "0x7EDCB4", VA = "0x7EDCB4", Slot = "8")]
		protected virtual void AfterHide()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x7EDCB8", Offset = "0x7EDCB8", VA = "0x7EDCB8", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x7EDCC8", Offset = "0x7EDCC8", VA = "0x7EDCC8")]
		public DynamicResizablePanelContent()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class DynamicResizablePanelManager : MonoBehaviour
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float ExpandedSize;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DynamicResizablePanel[] _panelList;

		[Token(Token = "0x17000091")]
		public int CurPanelId
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x7EDCD0", Offset = "0x7EDCD0", VA = "0x7EDCD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x7EDCD8", Offset = "0x7EDCD8", VA = "0x7EDCD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public DynamicResizablePanel CurPanel
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x7EDCE0", Offset = "0x7EDCE0", VA = "0x7EDCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x7EDCE8", Offset = "0x7EDCE8", VA = "0x7EDCE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x7EDCF0", Offset = "0x7EDCF0", VA = "0x7EDCF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x7EDE58", Offset = "0x7EDE58", VA = "0x7EDE58")]
		public void Select(int id, bool instant = false)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x7EDF40", Offset = "0x7EDF40", VA = "0x7EDF40")]
		public void Deselect(bool instant = false)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x7EDFCC", Offset = "0x7EDFCC", VA = "0x7EDFCC")]
		public void SelectNext()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x7EE078", Offset = "0x7EE078", VA = "0x7EE078")]
		public void SelectPrevious()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x7EE128", Offset = "0x7EE128", VA = "0x7EE128")]
		public DynamicResizablePanelManager()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class DynamicResizablePanelWithIcon : DynamicResizablePanel
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CanvasGroup Icon;

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x7EE140", Offset = "0x7EE140", VA = "0x7EE140", Slot = "6")]
		public override void Expand(bool instant = false)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x7EE194", Offset = "0x7EE194", VA = "0x7EE194", Slot = "7")]
		protected override void OnExpandComplete()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x7EE1C0", Offset = "0x7EE1C0", VA = "0x7EE1C0", Slot = "8")]
		public override void Contract(bool instant = false)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x7EE238", Offset = "0x7EE238", VA = "0x7EE238", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x7EE264", Offset = "0x7EE264", VA = "0x7EE264")]
		public DynamicResizablePanelWithIcon()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.StatsBar
{
	[Token(Token = "0x20000BF")]
	public class StatsBar : MonoBehaviour
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Stars;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI PrimaryCurrency;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform _primaryCurrencyTransform;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _highlightEffectScale;

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x7EE278", Offset = "0x7EE278", VA = "0x7EE278")]
		private void Awake()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x7EE388", Offset = "0x7EE388", VA = "0x7EE388")]
		private void Start()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x7EE3A0", Offset = "0x7EE3A0", VA = "0x7EE3A0")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x7EE3B8", Offset = "0x7EE3B8", VA = "0x7EE3B8")]
		private void RefreshStars()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x7EE51C", Offset = "0x7EE51C", VA = "0x7EE51C")]
		private void RefreshPrimaryCurrency()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x7EE680", Offset = "0x7EE680", VA = "0x7EE680")]
		private void OnStarsChangedEvent(int value)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x7EE684", Offset = "0x7EE684", VA = "0x7EE684")]
		private void OnPrimaryCurrencyChangedEvent(int value)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x7EE688", Offset = "0x7EE688", VA = "0x7EE688")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x7EE768", Offset = "0x7EE768", VA = "0x7EE768")]
		public StatsBar()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class StatsUpdateEffectItem : MonoBehaviour
	{
		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite[] Sprites;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _statType;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image _image;

		[Token(Token = "0x17000093")]
		public int StatType
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x7EE77C", Offset = "0x7EE77C", VA = "0x7EE77C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x7EE784", Offset = "0x7EE784", VA = "0x7EE784")]
		public void Init(int statType, Vector3 fromPos, Vector3 toPos, Action<StatsUpdateEffectItem> onComplete)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x7EEB50", Offset = "0x7EEB50", VA = "0x7EEB50")]
		public StatsUpdateEffectItem()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class StatsUpdateEffectSystem : MonoBehaviour
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Items;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform[] FromPos;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform[] ToPos;

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x7EEB78", Offset = "0x7EEB78", VA = "0x7EEB78")]
		private void OnPurchasedEvent(int statType, int tier)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x7EED58", Offset = "0x7EED58", VA = "0x7EED58")]
		private void OnItemComplete(StatsUpdateEffectItem item)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x7EEEA8", Offset = "0x7EEEA8", VA = "0x7EEEA8")]
		public StatsUpdateEffectSystem()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Settings
{
	[Token(Token = "0x20000C3")]
	public class MainSettingsPanel : DynamicResizablePanelContent
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArmLengthCalibrationWindow ArmLengthCalibrationWindow;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Slider MasterVolume;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Slider MusicVolume;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Slider Quality;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image CrosshairIcon;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Localize CrosshairLabel;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public CanvasGroup AdditionalArrowsGroup;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Slider AdditionalArrows;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI AdditionalArrowsLabel;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI MasterVolumeLabel;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI MusicVolumeLabel;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Localize QualityLocalize;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Slider Smoothing;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI SmoothingLabel;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PlayerSettingsState _playerSettings;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string[] QualityTerms;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string[] CrosshairStateTerms;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x7EEEB0", Offset = "0x7EEEB0", VA = "0x7EEEB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x7EEEDC", Offset = "0x7EEEDC", VA = "0x7EEEDC", Slot = "5")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x7EF4F4", Offset = "0x7EF4F4", VA = "0x7EF4F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x7EF514", Offset = "0x7EF514", VA = "0x7EF514")]
		public void OnMasterVolumeChanged(float value)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x7EF69C", Offset = "0x7EF69C", VA = "0x7EF69C")]
		public void OnMusicVolumeChanged(float value)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x7EF824", Offset = "0x7EF824", VA = "0x7EF824")]
		public void OnQualityChanged(float value)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x7EF96C", Offset = "0x7EF96C", VA = "0x7EF96C")]
		public void OnHeightCalibration()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x7EF9DC", Offset = "0x7EF9DC", VA = "0x7EF9DC")]
		public void OnCrosshair()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x7EFB10", Offset = "0x7EFB10", VA = "0x7EFB10")]
		public void OnAdditionalArrowsChanged(float value)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x7EFC40", Offset = "0x7EFC40", VA = "0x7EFC40")]
		public void OnSmoothingChanged(float value)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x7EFDC8", Offset = "0x7EFDC8", VA = "0x7EFDC8")]
		public MainSettingsPanel()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class TertiarySettingsPanel : DynamicResizablePanelContent
	{
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PrivacyWindow PrivacyWindow;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x7EFF94", Offset = "0x7EFF94", VA = "0x7EFF94")]
		public void OnPrivacyPolicyBtn()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x7F0008", Offset = "0x7F0008", VA = "0x7F0008")]
		public TertiarySettingsPanel()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Menu.NavBar
{
	[Token(Token = "0x20000C5")]
	public class AlertWidget : MonoBehaviour
	{
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x17000094")]
		public bool IsVisible
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x7F0010", Offset = "0x7F0010", VA = "0x7F0010")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x7F00C0", Offset = "0x7F00C0", VA = "0x7F00C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x7F0110", Offset = "0x7F0110", VA = "0x7F0110")]
		public void Show(bool instant)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x7F01F0", Offset = "0x7F01F0", VA = "0x7F01F0")]
		public void Hide(bool instant)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x7F02D0", Offset = "0x7F02D0", VA = "0x7F02D0")]
		public AlertWidget()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class NavigationButton : DynamicResizablePanel, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
	{
		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Image Icon;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color InactiveColor;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color ActiveColor;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _timePressed;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _isDown;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool _isLongPress;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityEvent OnClick;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent OnLongPress;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float LongPressTime;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public ImageStatBarFill LongPressFill;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CanvasGroup _longPressFillImage;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x7F02D8", Offset = "0x7F02D8", VA = "0x7F02D8", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x7F0354", Offset = "0x7F0354", VA = "0x7F0354")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x7F0420", Offset = "0x7F0420", VA = "0x7F0420", Slot = "6")]
		public override void Expand(bool instant = false)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x7F047C", Offset = "0x7F047C", VA = "0x7F047C", Slot = "8")]
		public override void Contract(bool instant = false)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x7F04D8", Offset = "0x7F04D8", VA = "0x7F04D8", Slot = "11")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x7F0520", Offset = "0x7F0520", VA = "0x7F0520", Slot = "12")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x7F0554", Offset = "0x7F0554", VA = "0x7F0554", Slot = "13")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x7F0570", Offset = "0x7F0570", VA = "0x7F0570")]
		public NavigationButton()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Loading
{
	[Token(Token = "0x20000C7")]
	public class InitLoadingScreen : MonoBehaviour
	{
		[Token(Token = "0x20000C8")]
		[CompilerGenerated]
		private sealed class <SwitchScene>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InitLoadingScreen <>4__this;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AsyncOperation <asyncOperation>5__2;

			[Token(Token = "0x17000095")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D0")]
				[Address(RVA = "0x7F09D8", Offset = "0x7F09D8", VA = "0x7F09D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D2")]
				[Address(RVA = "0x7F0A20", Offset = "0x7F0A20", VA = "0x7F0A20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x7F074C", Offset = "0x7F074C", VA = "0x7F074C")]
			[DebuggerHidden]
			public <SwitchScene>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x7F0788", Offset = "0x7F0788", VA = "0x7F0788", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x7F078C", Offset = "0x7F078C", VA = "0x7F078C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x7F09E0", Offset = "0x7F09E0", VA = "0x7F09E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Canvas ContentCanvas;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MinTime;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string SceneToSwitchTo;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _startLoadingTime;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _mainCameraTransform;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _container;

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x7F0594", Offset = "0x7F0594", VA = "0x7F0594")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x7F05C4", Offset = "0x7F05C4", VA = "0x7F05C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x7F0668", Offset = "0x7F0668", VA = "0x7F0668")]
		public void InitialSceneSwitch()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x7F0718", Offset = "0x7F0718", VA = "0x7F0718")]
		private void InitPosition()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x7F06B0", Offset = "0x7F06B0", VA = "0x7F06B0")]
		[IteratorStateMachine(typeof(<SwitchScene>d__10))]
		private IEnumerator SwitchScene()
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x7F0774", Offset = "0x7F0774", VA = "0x7F0774")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x7F0778", Offset = "0x7F0778", VA = "0x7F0778")]
		public InitLoadingScreen()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class LoadingScreen : MonoBehaviour
	{
		[Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private sealed class <SwitchScene>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoadingScreen <>4__this;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <len>5__2;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <lastSceneId>5__3;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <progressPerScene>5__4;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Scene <sceneToMakeActive>5__5;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__6;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private AsyncOperation <asyncOperation>5__7;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private bool <isLastScene>5__8;

			[Token(Token = "0x17000097")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x7F1B44", Offset = "0x7F1B44", VA = "0x7F1B44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005E5")]
				[Address(RVA = "0x7F1B8C", Offset = "0x7F1B8C", VA = "0x7F1B8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x7F1428", Offset = "0x7F1428", VA = "0x7F1428")]
			[DebuggerHidden]
			public <SwitchScene>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x7F163C", Offset = "0x7F163C", VA = "0x7F163C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x7F1640", Offset = "0x7F1640", VA = "0x7F1640", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x7F1B4C", Offset = "0x7F1B4C", VA = "0x7F1B4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LoadingScreen Instance;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Canvas ContentCanvas;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform LoadingIcon;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI LoadingProgress;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI LoadingTime;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color LoadingTimeColor0;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color LoadingTimeColor1;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LoadingScreenAnimation loadingAnimation;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string[] _scenesToSwitchTo;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _startLoadingTime;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _minLoadingTime;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _stateSerializationRequired;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform _mainCameraTransform;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform _container;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x7F0A28", Offset = "0x7F0A28", VA = "0x7F0A28")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x7F0B20", Offset = "0x7F0B20", VA = "0x7F0B20")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x7F0BBC", Offset = "0x7F0BBC", VA = "0x7F0BBC")]
		private void InitPosition()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x7F0BF0", Offset = "0x7F0BF0", VA = "0x7F0BF0")]
		public void SwitchToScene(string sceneName, int stateSerializationRequired = 0)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x7F0C98", Offset = "0x7F0C98", VA = "0x7F0C98")]
		public void SwitchToScenes(string[] sceneNames, int stateSerializationRequired = 0)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x7F0FA8", Offset = "0x7F0FA8", VA = "0x7F0FA8")]
		public void ReloadActiveScenes(int stateSerializationRequired = 0)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x7F1340", Offset = "0x7F1340", VA = "0x7F1340")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x7F13C0", Offset = "0x7F13C0", VA = "0x7F13C0")]
		[IteratorStateMachine(typeof(<SwitchScene>d__21))]
		private IEnumerator SwitchScene()
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x7F1208", Offset = "0x7F1208", VA = "0x7F1208")]
		private void GetCurrentScenes()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x7F1450", Offset = "0x7F1450", VA = "0x7F1450")]
		private void Hide()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x7F15E4", Offset = "0x7F15E4", VA = "0x7F15E4")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x7F1624", Offset = "0x7F1624", VA = "0x7F1624")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x7F1634", Offset = "0x7F1634", VA = "0x7F1634")]
		public LoadingScreen()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class LoadingScreenAnimation : MonoBehaviour
	{
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasGroup Content;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Renderer Renderer;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material _material;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color None;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color Black;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Action _onShowComplete;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Action _onHideComplete;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _showTime;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _hideTime;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int MainColor;

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x7F1B94", Offset = "0x7F1B94", VA = "0x7F1B94", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x7F1C14", Offset = "0x7F1C14", VA = "0x7F1C14")]
		[ContextMenu("Show")]
		public void Show()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x7F0EF0", Offset = "0x7F0EF0", VA = "0x7F0EF0")]
		public void Show(Action onShowComplete)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x7F1C1C", Offset = "0x7F1C1C", VA = "0x7F1C1C")]
		private void DelayedShow()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x7F1D5C", Offset = "0x7F1D5C", VA = "0x7F1D5C")]
		private void OnShowContent()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x7F1E58", Offset = "0x7F1E58", VA = "0x7F1E58")]
		private void OnFullyShown()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x7F1E70", Offset = "0x7F1E70", VA = "0x7F1E70")]
		[ContextMenu("Hide")]
		public void Hide()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x7F14D8", Offset = "0x7F14D8", VA = "0x7F14D8")]
		public void Hide(Action onHideComplete)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x7F1E78", Offset = "0x7F1E78", VA = "0x7F1E78")]
		private void OnContentHidden()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x7F200C", Offset = "0x7F200C", VA = "0x7F200C")]
		private void OnHidden()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x7F204C", Offset = "0x7F204C", VA = "0x7F204C", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x7F205C", Offset = "0x7F205C", VA = "0x7F205C")]
		public LoadingScreenAnimation()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Equipment
{
	[Token(Token = "0x20000CC")]
	public class EquipmentListItem : MonoBehaviour
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Button Button;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image Portrait;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanvasGroup PortraitContainer;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI OwnedLabel;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI PricePrimaryCurrency;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CanvasGroup LockIcon;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CanvasGroup EquippedIcon;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject ComingSoonLabel;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AlertWidget UnlockedAlert;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AlertWidget UnlockedAlert2;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _portraitRT;

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x7F2100", Offset = "0x7F2100", VA = "0x7F2100")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x7F2158", Offset = "0x7F2158", VA = "0x7F2158")]
		public void Refresh(EquipmentUIData uiData, EquipmentBalanceData balanceData, bool isOwned, bool isEquipped, bool isLocked, bool isComingSoon, bool noPrimaryCurrency, Color primaryCurrencyColor, bool showAlert)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x7F2404", Offset = "0x7F2404", VA = "0x7F2404")]
		public void Select(bool value)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x7F2428", Offset = "0x7F2428", VA = "0x7F2428")]
		public EquipmentListItem()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class EquipmentPanelContent : DynamicResizablePanelContent
	{
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EquipmentDataLibrary EquipmentDataLibrary;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EquipmentUIDataLibrary EquipmentUIDataLibrary;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int PanelType;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EquipmentUIRenderer CurPortrait;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Localize NameLabel;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI[] CurStats;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject[] CurStatsButtons;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ScrollRect EquipmentListScrollRect;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EquipmentListItem[] EquipmentList;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Button BuyPrimaryCurrencyBtn;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Button EquipBtn;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public LocalizationParamsManager BuyPrimaryCurrencyLabelValue;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI BuyPrimaryCurrencyLabel;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject EquippedLabel;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LocalizationParamsManager LockedLabelValue;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject LockedLabel;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject ComingSoonLabel;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _curSelectionId;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private PlayerState _playerState;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BalanceData _balanceData;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _unlockableAlertId;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _viewedAlertId;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string _green;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private string _red;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string _grey;

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x7F2430", Offset = "0x7F2430", VA = "0x7F2430", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x7F2600", Offset = "0x7F2600", VA = "0x7F2600", Slot = "5")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x7F2664", Offset = "0x7F2664", VA = "0x7F2664")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x7F269C", Offset = "0x7F269C", VA = "0x7F269C")]
		private void RefreshBow()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x7F3188", Offset = "0x7F3188", VA = "0x7F3188")]
		private void RefreshArrow()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x7F3EAC", Offset = "0x7F3EAC", VA = "0x7F3EAC")]
		private void RefreshBuyButtons(bool isPurchased, bool isEquipped, EquipmentBalanceData data)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x7F3BEC", Offset = "0x7F3BEC", VA = "0x7F3BEC")]
		private void RefreshEquipmentList()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x7F41C8", Offset = "0x7F41C8", VA = "0x7F41C8")]
		public void OnStatInfoBtn(int id)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x7F42DC", Offset = "0x7F42DC", VA = "0x7F42DC")]
		public void OnSelect(int id)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x7F43F8", Offset = "0x7F43F8", VA = "0x7F43F8")]
		public void OnBuyPrimaryBtn()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x7F4700", Offset = "0x7F4700", VA = "0x7F4700")]
		public void OnEquipBtn()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x7F47FC", Offset = "0x7F47FC", VA = "0x7F47FC")]
		public EquipmentPanelContent()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	internal class DynamicResizablePanelWithContent : DynamicResizablePanelWithIcon
	{
		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DynamicResizablePanelContent Content;

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x7F5814", Offset = "0x7F5814", VA = "0x7F5814", Slot = "6")]
		public override void Expand(bool instant = false)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x7F5844", Offset = "0x7F5844", VA = "0x7F5844", Slot = "8")]
		public override void Contract(bool instant = false)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x7F5874", Offset = "0x7F5874", VA = "0x7F5874", Slot = "9")]
		protected override void OnContractComplete()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x7F58AC", Offset = "0x7F58AC", VA = "0x7F58AC")]
		public DynamicResizablePanelWithContent()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Areas
{
	[Token(Token = "0x20000CF")]
	public class AreaUI : MonoBehaviour
	{
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParallaxPortrait ParallaxPortrait;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanvasGroup PortraitContainer;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RawImage Portrait;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Button MainButton;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CanvasGroup Background;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CanvasGroup Highlight;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Graphic Highlight2;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public CanvasGroup BackBtns;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Localize StarsLabelLocalize;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LocalizationParamsManager StarsLabelValue;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LocalizationParamsManager NameLabelLocalize;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AreaUILockAnim LockIcon;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool _isLocked;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		private bool _isUnlockable;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		private bool _anotherAreaReadyToUnlock;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform _transform;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransform;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private LayoutElement _layoutElement;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2 _originalSize;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 _originalPos;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Action _onExpandCompleteCallback;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action _onContractCompleteCallback;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Action<AreaUI> _onUnlockCompleteCallback;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Color _normalColor;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Color _highlightedColor;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Color _pressedColor;

		[Token(Token = "0x17000099")]
		public int Id
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x7F58B4", Offset = "0x7F58B4", VA = "0x7F58B4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x7F58BC", Offset = "0x7F58BC", VA = "0x7F58BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		private float PortraitAlpha
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x7F58C4", Offset = "0x7F58C4", VA = "0x7F58C4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x7F58CC", Offset = "0x7F58CC", VA = "0x7F58CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public bool CanBeUnlocked
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x7F58D4", Offset = "0x7F58D4", VA = "0x7F58D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009C")]
		public bool IsLocked
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x7F58F4", Offset = "0x7F58F4", VA = "0x7F58F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x7F58FC", Offset = "0x7F58FC", VA = "0x7F58FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x7F59E4", Offset = "0x7F59E4", VA = "0x7F59E4")]
		public void Refresh(AreaData ad, bool isLatest, bool isLocked, bool isUnlockable, bool anotherAreaReadyToUnlock)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x7F62C8", Offset = "0x7F62C8", VA = "0x7F62C8")]
		public void ComingSoon(AreaData ad)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x7F63BC", Offset = "0x7F63BC", VA = "0x7F63BC")]
		public void Expand(Action onComplete)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x7F666C", Offset = "0x7F666C", VA = "0x7F666C")]
		private void OnExpandComplete()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x7F6728", Offset = "0x7F6728", VA = "0x7F6728")]
		public void ExpandInstant()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x7F68B0", Offset = "0x7F68B0", VA = "0x7F68B0")]
		public void Contract(Action onComplete)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x7F6A34", Offset = "0x7F6A34", VA = "0x7F6A34")]
		private void OnContractComplete()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x7F6A98", Offset = "0x7F6A98", VA = "0x7F6A98")]
		public void Unlock(Action<AreaUI> onComplete)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x7F6DB8", Offset = "0x7F6DB8", VA = "0x7F6DB8")]
		private void OnUnlockComplete()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x7F6DD4", Offset = "0x7F6DD4", VA = "0x7F6DD4")]
		public void ShakeLocked()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x7F6ED4", Offset = "0x7F6ED4", VA = "0x7F6ED4")]
		public void Show()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x7F6FB0", Offset = "0x7F6FB0", VA = "0x7F6FB0")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x7F6FD0", Offset = "0x7F6FD0", VA = "0x7F6FD0")]
		public void Hide()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x7F7044", Offset = "0x7F7044", VA = "0x7F7044")]
		public void HideInstant()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x7F707C", Offset = "0x7F707C", VA = "0x7F707C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x7F70A8", Offset = "0x7F70A8", VA = "0x7F70A8")]
		public AreaUI()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class AreaUIGroup : MonoBehaviour
	{
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnAreaUnlocked;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AreaDataLibrary AreaDataLibrary;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform Container;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CanvasGroup ScrollBar;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AreaUI[] _areaUiList;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ScrollRect _scrollRect;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HorizontalLayoutGroup _layoutGroup;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MenuBackgroundManager _menuBackgroundManager;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LevelUIGroup _levelUIGroup;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _curAreaId;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AreaUI _curAreaUI;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 _contractPosition;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _cantChangeState;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _savedScrollRectPos;

		[Token(Token = "0x1700009D")]
		public bool IsAreaSelected
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x7F70B0", Offset = "0x7F70B0", VA = "0x7F70B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x7F70C0", Offset = "0x7F70C0", VA = "0x7F70C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x7F729C", Offset = "0x7F729C", VA = "0x7F729C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x7F74AC", Offset = "0x7F74AC", VA = "0x7F74AC")]
		public void RegularStart()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x7F7558", Offset = "0x7F7558", VA = "0x7F7558")]
		public void Select(int id)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x7F7B70", Offset = "0x7F7B70", VA = "0x7F7B70")]
		[ContextMenu("SET POS")]
		private void SetScrollPos()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x7F7B94", Offset = "0x7F7B94", VA = "0x7F7B94")]
		public void SelectInstant(int id)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x7F8010", Offset = "0x7F8010", VA = "0x7F8010")]
		private void OnSelectPhaseComplete()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x7F8224", Offset = "0x7F8224", VA = "0x7F8224")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x7F822C", Offset = "0x7F822C", VA = "0x7F822C")]
		private void OnDeselectPhaseComplete()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x7F837C", Offset = "0x7F837C", VA = "0x7F837C")]
		private void OnDeselectComplete()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x7F7AE0", Offset = "0x7F7AE0", VA = "0x7F7AE0")]
		public void UnlockArea(AreaUI areaUI)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x7F83C8", Offset = "0x7F83C8", VA = "0x7F83C8")]
		public void UnlockArea(int id)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x7F8470", Offset = "0x7F8470", VA = "0x7F8470")]
		private void OnUnlockComplete(AreaUI areaUI)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x7F79B8", Offset = "0x7F79B8", VA = "0x7F79B8")]
		public void Deselect()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x7F863C", Offset = "0x7F863C", VA = "0x7F863C")]
		public void FocusOnArea(int id, bool instant = false)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x7F8720", Offset = "0x7F8720", VA = "0x7F8720")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x7F874C", Offset = "0x7F874C", VA = "0x7F874C")]
		public AreaUIGroup()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class AreaUILockAnim : MonoBehaviour
	{
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasGroup PortraitContainer;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CanvasGroup LockContainer;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform LockIcon;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CanvasGroup TapToUnlockContainer;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Sequence _idleSequence;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Sequence _unlockSequence;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action _onUnlockComplete;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Sequence _lockedSequence;

		[Token(Token = "0x1700009E")]
		public float PortraitAlpha
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x7F875C", Offset = "0x7F875C", VA = "0x7F875C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x7F5F24", Offset = "0x7F5F24", VA = "0x7F5F24")]
		public void Refresh(int type, bool instant)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x7F8764", Offset = "0x7F8764", VA = "0x7F8764")]
		private void StartIdleAnimation()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x7F6B30", Offset = "0x7F6B30", VA = "0x7F6B30")]
		public void StartUnlockAnimation(Action onComplete)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x7F6DEC", Offset = "0x7F6DEC", VA = "0x7F6DEC")]
		public void StartLockedAnimation()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x7F8948", Offset = "0x7F8948", VA = "0x7F8948")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x7F8994", Offset = "0x7F8994", VA = "0x7F8994")]
		public AreaUILockAnim()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class CampaignPanelContent : DynamicResizablePanelContent
	{
		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AreaUIGroup AreaUIGroup;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NewAreaAlert NewAreaAlert;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _firstView;

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x7F8A40", Offset = "0x7F8A40", VA = "0x7F8A40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x7F8B3C", Offset = "0x7F8B3C", VA = "0x7F8B3C", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x7F8C38", Offset = "0x7F8C38", VA = "0x7F8C38", Slot = "5")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x7F8CE4", Offset = "0x7F8CE4", VA = "0x7F8CE4")]
		private void OnAreaUnlockedEvent()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x7F8D04", Offset = "0x7F8D04", VA = "0x7F8D04")]
		public bool CanBeDeselected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x7F8D28", Offset = "0x7F8D28", VA = "0x7F8D28")]
		public void Deselect()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x7F8D40", Offset = "0x7F8D40", VA = "0x7F8D40")]
		public CampaignPanelContent()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class FullscreenBackground : MonoBehaviour
	{
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int TextureId;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 ReferenceTextureSize;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x7F8D50", Offset = "0x7F8D50", VA = "0x7F8D50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x7F8D54", Offset = "0x7F8D54", VA = "0x7F8D54")]
		[ContextMenu("Refresh")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x7F8F44", Offset = "0x7F8F44", VA = "0x7F8F44")]
		public FullscreenBackground()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class LevelUI : MonoBehaviour
	{
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasGroup PortraitContainer;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Name;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ImageStatBarSprites Stars;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CanvasGroup LockIcon;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action _onShowCompleteCallback;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action _onHideCompleteCallback;

		[Token(Token = "0x1700009F")]
		public bool IsLocked
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x7F8F58", Offset = "0x7F8F58", VA = "0x7F8F58")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x7F8F60", Offset = "0x7F8F60", VA = "0x7F8F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public int Id
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x7F8F6C", Offset = "0x7F8F6C", VA = "0x7F8F6C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x7F8F74", Offset = "0x7F8F74", VA = "0x7F8F74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		private float PortraitAlpha
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x7F8F7C", Offset = "0x7F8F7C", VA = "0x7F8F7C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x7F8F94", Offset = "0x7F8F94", VA = "0x7F8F94")]
		private void Awake()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x7F8FE4", Offset = "0x7F8FE4", VA = "0x7F8FE4")]
		public void Refresh(int id, int stars, bool isLocked)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x7F9138", Offset = "0x7F9138", VA = "0x7F9138")]
		public void Show(float delay, [Optional] Action onComplete)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x7F9300", Offset = "0x7F9300", VA = "0x7F9300")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x7F9318", Offset = "0x7F9318", VA = "0x7F9318")]
		public void ShowInstant()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x7F939C", Offset = "0x7F939C", VA = "0x7F939C")]
		public void Hide(float delay, [Optional] Action onComplete)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x7F9564", Offset = "0x7F9564", VA = "0x7F9564")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x7F957C", Offset = "0x7F957C", VA = "0x7F957C")]
		public void HideInstant()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x7F959C", Offset = "0x7F959C", VA = "0x7F959C")]
		public void ShakeLocked()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x7F96B4", Offset = "0x7F96B4", VA = "0x7F96B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x7F96DC", Offset = "0x7F96DC", VA = "0x7F96DC")]
		public LevelUI()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class LevelUIGroup : MonoBehaviour
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Container;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LevelUI[] _levelUiList;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action _onHideCompleteCallback;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action _onShowCompleteCallback;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _curAreaId;

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x7F96E4", Offset = "0x7F96E4", VA = "0x7F96E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x7F7EA0", Offset = "0x7F7EA0", VA = "0x7F7EA0")]
		public void Refresh(int areaId, AreaData ad)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x7F80C8", Offset = "0x7F80C8", VA = "0x7F80C8")]
		public void Show(Action onComplete)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x7F99BC", Offset = "0x7F99BC", VA = "0x7F99BC")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x7F7F88", Offset = "0x7F7F88", VA = "0x7F7F88")]
		public void ShowInstant()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x7F8514", Offset = "0x7F8514", VA = "0x7F8514")]
		public void Hide(Action onComplete)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x7F74D4", Offset = "0x7F74D4", VA = "0x7F74D4")]
		public void HideInstant()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x7F99D4", Offset = "0x7F99D4", VA = "0x7F99D4")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x7F9A18", Offset = "0x7F9A18", VA = "0x7F9A18")]
		public void OnSelectBtn(int id)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x7F9B84", Offset = "0x7F9B84", VA = "0x7F9B84")]
		public LevelUIGroup()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class MaximizingBackground : MonoBehaviour
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParallaxPortrait ParallaxPortrait;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParallaxPortrait ParallaxPortraitBlur;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RawImage Image;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RawImage ImageBlur;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _transform;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransform;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas _canvas;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isExpanded;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _scaleFactor;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector2 _fullScreenRect;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _savedPos;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector2 _savedSize;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform _curTransform;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _curRectTransform;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Action _onContractCompleteCallback;

		[Token(Token = "0x400055B")]
		private const float _showTime = 0.25f;

		[Token(Token = "0x400055C")]
		private const float _hideTime = 0.25f;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x7F9B8C", Offset = "0x7F9B8C", VA = "0x7F9B8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x7F9C80", Offset = "0x7F9C80", VA = "0x7F9C80")]
		public void SetTexture(Texture texture, Texture textureBlur, int textureId)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x7F9CC4", Offset = "0x7F9CC4", VA = "0x7F9CC4")]
		public void Contract(Action onComplete)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x7F9E30", Offset = "0x7F9E30", VA = "0x7F9E30")]
		private void OnContractComplete()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x7F9E48", Offset = "0x7F9E48", VA = "0x7F9E48")]
		public void Expand(Transform t)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x7FA0C0", Offset = "0x7FA0C0", VA = "0x7FA0C0")]
		public void ExpandInstant(Transform t)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x7FA2F0", Offset = "0x7FA2F0", VA = "0x7FA2F0")]
		public MaximizingBackground()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class ParallaxPortrait : MonoBehaviour
	{
		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform MaximizedBackground;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RawImage Image;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 _idOffset;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _id;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform _rectTransform;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 _referenceTextureSize;

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x7FA2F8", Offset = "0x7FA2F8", VA = "0x7FA2F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x7FA3A8", Offset = "0x7FA3A8", VA = "0x7FA3A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x7F5EE4", Offset = "0x7F5EE4", VA = "0x7F5EE4")]
		public void SetTexture(Texture texture, int id)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x7FA500", Offset = "0x7FA500", VA = "0x7FA500")]
		public ParallaxPortrait()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Game.NextEquipment
{
	[Token(Token = "0x20000D8")]
	public class NextEquipmentBar : MonoBehaviour
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ImageStatBarFill ProgressBar;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Localize Label;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LocalizationParamsManager LabelValue;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Image Portrait;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform PortraitTransform;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image Lock;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _equipmentType;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _newEquipmentAvailable;

		[Token(Token = "0x170000A2")]
		public bool NewEquipmentAvailable
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x7FA508", Offset = "0x7FA508", VA = "0x7FA508")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x7FA510", Offset = "0x7FA510", VA = "0x7FA510")]
		public void Refresh(int currency, int areaReached, int equipmentType)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x7FAAF4", Offset = "0x7FAAF4", VA = "0x7FAAF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x7FAB04", Offset = "0x7FAB04", VA = "0x7FAB04")]
		public NextEquipmentBar()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Widgets.Menu.TitleBar
{
	[Token(Token = "0x20000D9")]
	public class TitleBar : MonoBehaviour
	{
		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] Terms;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label0;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI Label1;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Localize Label0Localize;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Localize Label1Localize;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float TweenDistance;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float TweenTime;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _label0Transform;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _label1Transform;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Tween _label0Tween;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Tween _label1Tween;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Tween _label0TransformTween;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Tween _label1TransformTween;

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x7FAB0C", Offset = "0x7FAB0C", VA = "0x7FAB0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x7FAB4C", Offset = "0x7FAB4C", VA = "0x7FAB4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x7FABB0", Offset = "0x7FABB0", VA = "0x7FABB0")]
		public void ChangeTo(int id, bool direction, bool instant = false)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x7FAEC4", Offset = "0x7FAEC4", VA = "0x7FAEC4")]
		private void OnChanged()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x7FAF8C", Offset = "0x7FAF8C", VA = "0x7FAF8C")]
		public TitleBar()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Widgets.Game.MiniGameTimer
{
	[Token(Token = "0x20000DA")]
	public class MiniGameTimer : MonoBehaviour
	{
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnTimeUp;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image ProgressBar;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MiniGameManager _miniGameManager;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color _initialColor;

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x7FAFA0", Offset = "0x7FAFA0", VA = "0x7FAFA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x7FB038", Offset = "0x7FB038", VA = "0x7FB038")]
		private void Start()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x7FB058", Offset = "0x7FB058", VA = "0x7FB058")]
		private void Update()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x7FB080", Offset = "0x7FB080", VA = "0x7FB080")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x7FB18C", Offset = "0x7FB18C", VA = "0x7FB18C")]
		public MiniGameTimer()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class MiniGameTimerGround : MonoBehaviour
	{
		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action OnTimeUp;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RingGenerator ProgressBar;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MiniGameManager _miniGameManager;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _angle0;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _angle1;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color _initialColor;

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x7FB194", Offset = "0x7FB194", VA = "0x7FB194")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x7FB228", Offset = "0x7FB228", VA = "0x7FB228")]
		private void Update()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x7FB250", Offset = "0x7FB250", VA = "0x7FB250")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x7FB374", Offset = "0x7FB374", VA = "0x7FB374")]
		public MiniGameTimerGround()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.AmmoNotifier
{
	[Token(Token = "0x20000DC")]
	public class AmmoCounter : MonoBehaviour
	{
		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocalizationParamsManager AmmoLabelValue;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI AmmoLabel;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image ArrowIcon;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _arrowIconRotationTransform;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _arrowIconTransform;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _ammoLabelTransform;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _noAmmo;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x7FB37C", Offset = "0x7FB37C", VA = "0x7FB37C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x7FB7F4", Offset = "0x7FB7F4", VA = "0x7FB7F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x7FBC2C", Offset = "0x7FBC2C", VA = "0x7FBC2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x7FBC30", Offset = "0x7FBC30", VA = "0x7FBC30")]
		private void UpdateAmmoLabel()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x7FBCFC", Offset = "0x7FBCFC", VA = "0x7FBCFC")]
		private void OnShootEvent(int totalAmmo)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x7FBED8", Offset = "0x7FBED8", VA = "0x7FBED8")]
		private void OnNockedEvent()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x7FBFA4", Offset = "0x7FBFA4", VA = "0x7FBFA4")]
		private void OnAmmoReceivedEvent(int received, int totalAmmo)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x7FC298", Offset = "0x7FC298", VA = "0x7FC298")]
		private void OnNoAmmoEvent(int totalAmmo)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x7FC378", Offset = "0x7FC378", VA = "0x7FC378")]
		private void OnArrowPickedEvent(EDKG.ArcheryRange.VR.Arrow arrow)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x7FC3F4", Offset = "0x7FC3F4", VA = "0x7FC3F4")]
		private void OnArrowGoingHomeEvent()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x7FC470", Offset = "0x7FC470", VA = "0x7FC470")]
		public AmmoCounter()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class BullseyeHitCounter : MonoBehaviour
	{
		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Icon;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool StartHidden;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AmmoManager _ammoManager;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _labelTransform;

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x7FC478", Offset = "0x7FC478", VA = "0x7FC478")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x7FC5F8", Offset = "0x7FC5F8", VA = "0x7FC5F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x7FC7E8", Offset = "0x7FC7E8", VA = "0x7FC7E8")]
		private void OnBullseyeHitEvent(int value)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x7FC62C", Offset = "0x7FC62C", VA = "0x7FC62C")]
		private void UpdateLabel()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x7FC830", Offset = "0x7FC830", VA = "0x7FC830")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x7FC95C", Offset = "0x7FC95C", VA = "0x7FC95C")]
		public BullseyeHitCounter()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class BullseyeHitItem : MonoBehaviour
	{
		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _delay;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 _targetPosition;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action<BullseyeHitItem> _onCompleteCallback;

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x7FC964", Offset = "0x7FC964", VA = "0x7FC964")]
		private void Awake()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x7FC9B4", Offset = "0x7FC9B4", VA = "0x7FC9B4")]
		public void Init(float delay, Vector3 targetPosition, Action<BullseyeHitItem> onComplete)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x7FC9C4", Offset = "0x7FC9C4", VA = "0x7FC9C4")]
		private void Show()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x7FCCB4", Offset = "0x7FCCB4", VA = "0x7FCCB4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x7FCCE8", Offset = "0x7FCCE8", VA = "0x7FCCE8")]
		public BullseyeHitItem()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class TargetHitCounter : MonoBehaviour
	{
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI Label;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MiniGameTargetManager _targetManager;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _labelTransform;

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x7FCD34", Offset = "0x7FCD34", VA = "0x7FCD34")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x7FCE90", Offset = "0x7FCE90", VA = "0x7FCE90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x7FCFA4", Offset = "0x7FCFA4", VA = "0x7FCFA4")]
		private void OnHitEvent(int value)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x7FCE94", Offset = "0x7FCE94", VA = "0x7FCE94")]
		private void UpdateLabel()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x7FCFA8", Offset = "0x7FCFA8", VA = "0x7FCFA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x7FD0B4", Offset = "0x7FD0B4", VA = "0x7FD0B4")]
		public TargetHitCounter()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.ScreenTabs
{
	[Token(Token = "0x20000E0")]
	public class CalibrationTab : UIScreenTab
	{
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SplashScreen SplashScreen;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ArmLengthCalibrationWindow CalibrationWindow;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ArmLengthCalibration Calibration;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UIManager _uiManager;

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x7FD0BC", Offset = "0x7FD0BC", VA = "0x7FD0BC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x7FD210", Offset = "0x7FD210", VA = "0x7FD210", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x7FD2A0", Offset = "0x7FD2A0", VA = "0x7FD2A0")]
		public void OnCalibrationContinueBtn()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x7FD2C4", Offset = "0x7FD2C4", VA = "0x7FD2C4")]
		public CalibrationTab()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	internal class CampaignTab : UIScreenTab
	{
		[Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class <DelayedFocus>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CampaignTab <>4__this;

			[Token(Token = "0x170000A3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0x7FD798", Offset = "0x7FD798", VA = "0x7FD798", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x7FD7E0", Offset = "0x7FD7E0", VA = "0x7FD7E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x7FD68C", Offset = "0x7FD68C", VA = "0x7FD68C")]
			[DebuggerHidden]
			public <DelayedFocus>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x7FD6C4", Offset = "0x7FD6C4", VA = "0x7FD6C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x7FD6C8", Offset = "0x7FD6C8", VA = "0x7FD6C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x7FD7A0", Offset = "0x7FD7A0", VA = "0x7FD7A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AreaUIGroup AreaUIGroup;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CampaignAlert CampaignAlert;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _firstView;

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x7FD2D4", Offset = "0x7FD2D4", VA = "0x7FD2D4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x7FD3CC", Offset = "0x7FD3CC", VA = "0x7FD3CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x7FD4BC", Offset = "0x7FD4BC", VA = "0x7FD4BC")]
		private void OnAreaUnlockedEvent()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x7FD4DC", Offset = "0x7FD4DC", VA = "0x7FD4DC", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x7FD584", Offset = "0x7FD584", VA = "0x7FD584", Slot = "10")]
		public override void SelectAgain()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x7FD5E4", Offset = "0x7FD5E4", VA = "0x7FD5E4", Slot = "11")]
		public override void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x7FD624", Offset = "0x7FD624", VA = "0x7FD624")]
		[IteratorStateMachine(typeof(<DelayedFocus>d__9))]
		private IEnumerator DelayedFocus()
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x7FD6B4", Offset = "0x7FD6B4", VA = "0x7FD6B4")]
		public CampaignTab()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	internal class EquipmentTab : UIScreenTab
	{
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int OverrideStartingPanelId;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int StartingPanelId;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public EquipmentAlert EquipmentAlert;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject EquipmentRenderer;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DynamicResizablePanelManager _dynamicResizablePanelManager;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isFirstLaunch;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x7FD7E8", Offset = "0x7FD7E8", VA = "0x7FD7E8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x7FD840", Offset = "0x7FD840", VA = "0x7FD840", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x7FD938", Offset = "0x7FD938", VA = "0x7FD938", Slot = "9")]
		protected override void AfterHide()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x7FD95C", Offset = "0x7FD95C", VA = "0x7FD95C")]
		public void SelectPanel(int id)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x7FDA28", Offset = "0x7FDA28", VA = "0x7FDA28", Slot = "10")]
		public override void SelectAgain()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x7FDA4C", Offset = "0x7FDA4C", VA = "0x7FDA4C", Slot = "11")]
		public override void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x7FDA2C", Offset = "0x7FDA2C", VA = "0x7FDA2C")]
		public void Deselect()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x7FDA50", Offset = "0x7FDA50", VA = "0x7FDA50")]
		public EquipmentTab()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class HomeTab : UIScreenTab
	{
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x7FDAB4", Offset = "0x7FDAB4", VA = "0x7FDAB4", Slot = "5")]
		public override void ForceRefresh()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x7FDB20", Offset = "0x7FDB20", VA = "0x7FDB20")]
		public HomeTab()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class LoadingTab : UIScreenTab
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SplashScreen SplashScreen;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Localize MainMessageLocalize;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI DebugMessage;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI Timer;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RectTransform Image;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UIManager _uiManager;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private WaitForSecondsRealtime _waitForSecond;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Coroutine _timer;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _step;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _time;

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x7FDB28", Offset = "0x7FDB28", VA = "0x7FDB28", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x7FDBE0", Offset = "0x7FDBE0", VA = "0x7FDBE0", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x7FDBE4", Offset = "0x7FDBE4", VA = "0x7FDBE4")]
		private void FinalizeEverything()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x7FDD30", Offset = "0x7FDD30", VA = "0x7FDD30")]
		public LoadingTab()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	internal class MiniGamesTab : UIScreenTab
	{
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MiniGameDataLibrary MiniGameDataLibrary;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MiniGameUI[] MiniGameUIs;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ScrollRect ScrollRect;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public NewMiniGameAlert NewMiniGameAlert;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isFirstLaunch;

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x7FDD38", Offset = "0x7FDD38", VA = "0x7FDD38", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x7FDE54", Offset = "0x7FDE54", VA = "0x7FDE54")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x7FDF4C", Offset = "0x7FDF4C", VA = "0x7FDF4C")]
		private void FocusOnMiniGame(int id)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x7FE05C", Offset = "0x7FE05C", VA = "0x7FE05C")]
		public void SelectMiniGame(int id)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x7FE1C0", Offset = "0x7FE1C0", VA = "0x7FE1C0", Slot = "10")]
		public override void SelectAgain()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x7FE1C4", Offset = "0x7FE1C4", VA = "0x7FE1C4", Slot = "11")]
		public override void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x7FE1C8", Offset = "0x7FE1C8", VA = "0x7FE1C8")]
		public MiniGamesTab()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	internal class PlayTab : UIScreenTab
	{
		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int OverrideStartingPanelId;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int StartingPanelId;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CampaignPanelContent campaignPanelContent;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DynamicResizablePanelManager _dynamicResizablePanelManager;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isFirstLaunch;

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x7FE1D8", Offset = "0x7FE1D8", VA = "0x7FE1D8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x7FE230", Offset = "0x7FE230", VA = "0x7FE230", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x7FE2E4", Offset = "0x7FE2E4", VA = "0x7FE2E4")]
		public void SelectPanel(int id)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x7FE368", Offset = "0x7FE368", VA = "0x7FE368", Slot = "10")]
		public override void SelectAgain()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x7FE3CC", Offset = "0x7FE3CC", VA = "0x7FE3CC", Slot = "11")]
		public override void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x7FE3AC", Offset = "0x7FE3AC", VA = "0x7FE3AC")]
		public void Deselect()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x7FE3D0", Offset = "0x7FE3D0", VA = "0x7FE3D0")]
		public PlayTab()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	internal class SettingsTab : UIScreenTab
	{
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int StartingPanelId;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DynamicResizablePanelManager _dynamicResizablePanelManager;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isFirstLaunch;

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x7FE434", Offset = "0x7FE434", VA = "0x7FE434", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x7FE48C", Offset = "0x7FE48C", VA = "0x7FE48C", Slot = "6")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x7FE4C8", Offset = "0x7FE4C8", VA = "0x7FE4C8")]
		public void SelectPanel(int id)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x7FE54C", Offset = "0x7FE54C", VA = "0x7FE54C", Slot = "10")]
		public override void SelectAgain()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x7FE570", Offset = "0x7FE570", VA = "0x7FE570", Slot = "11")]
		public override void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x7FE550", Offset = "0x7FE550", VA = "0x7FE550")]
		public void Deselect()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x7FE574", Offset = "0x7FE574", VA = "0x7FE574")]
		public void SelectPreviousPanel()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x7FE590", Offset = "0x7FE590", VA = "0x7FE590")]
		public void SelectNextPanel()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x7FE5AC", Offset = "0x7FE5AC", VA = "0x7FE5AC")]
		public SettingsTab()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class SplashTab : UIScreenTab
	{
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SplashScreen SplashScreen;

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x7FE5C4", Offset = "0x7FE5C4", VA = "0x7FE5C4")]
		public void OnPlayBtn()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x7FE6C4", Offset = "0x7FE6C4", VA = "0x7FE6C4")]
		public void OnSettingsBtn()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x7FE73C", Offset = "0x7FE73C", VA = "0x7FE73C")]
		public void OnQuitBtn()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x7FE7A0", Offset = "0x7FE7A0", VA = "0x7FE7A0")]
		public SplashTab()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class UIScreenTab : MonoBehaviour
	{
		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x40005C2")]
		private const float _showScaleEffectMultiplier = 0.9f;

		[Token(Token = "0x40005C3")]
		private const float _showScaleEffectMultiplier2 = 1.15f;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 _showScaleEffectValue;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 _showScaleEffectValue2;

		[Token(Token = "0x40005C6")]
		private const float _showTime = 0.15f;

		[Token(Token = "0x40005C7")]
		private const float _hideTime = 0.15f;

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x7FD134", Offset = "0x7FD134", VA = "0x7FD134", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x7FDB1C", Offset = "0x7FDB1C", VA = "0x7FDB1C", Slot = "5")]
		public virtual void ForceRefresh()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x7FE7A8", Offset = "0x7FE7A8", VA = "0x7FE7A8")]
		public void Show(bool direction, bool instant = false)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x7FE9CC", Offset = "0x7FE9CC", VA = "0x7FE9CC")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x7FD29C", Offset = "0x7FD29C", VA = "0x7FD29C", Slot = "6")]
		protected virtual void BeforeShow()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x7FE9D8", Offset = "0x7FE9D8", VA = "0x7FE9D8", Slot = "7")]
		protected virtual void AfterShow()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x7FE9DC", Offset = "0x7FE9DC", VA = "0x7FE9DC")]
		public void Hide(bool direction, bool instant = false)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x7FEB38", Offset = "0x7FEB38", VA = "0x7FEB38")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x7FEB70", Offset = "0x7FEB70", VA = "0x7FEB70", Slot = "8")]
		protected virtual void BeforeHide()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x7FD958", Offset = "0x7FD958", VA = "0x7FD958", Slot = "9")]
		protected virtual void AfterHide()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x7FD5E0", Offset = "0x7FD5E0", VA = "0x7FD5E0", Slot = "10")]
		public virtual void SelectAgain()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x7FD620", Offset = "0x7FD620", VA = "0x7FD620", Slot = "11")]
		public virtual void SelectAgainLongPress()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x7FD2CC", Offset = "0x7FD2CC", VA = "0x7FD2CC")]
		public UIScreenTab()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Screens
{
	[Token(Token = "0x20000EB")]
	public class GameUIScreen : UIScreen
	{
		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RealTime;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GamePauser _gamePauser;

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x7FEB74", Offset = "0x7FEB74", VA = "0x7FEB74", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x7FEC88", Offset = "0x7FEC88", VA = "0x7FEC88", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x7FECB8", Offset = "0x7FECB8", VA = "0x7FECB8")]
		public GameUIScreen()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class UIScreen : MonoBehaviour
	{
		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int VRUIControllersState;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected UIManager _uiManager;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x7FEBEC", Offset = "0x7FEBEC", VA = "0x7FEBEC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x7FECC8", Offset = "0x7FECC8", VA = "0x7FECC8", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x7FECD8", Offset = "0x7FECD8", VA = "0x7FECD8", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x7FECDC", Offset = "0x7FECDC", VA = "0x7FECDC")]
		public void Show(bool instant = false)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x7FEE48", Offset = "0x7FEE48", VA = "0x7FEE48")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x7FECB4", Offset = "0x7FECB4", VA = "0x7FECB4", Slot = "7")]
		protected virtual void BeforeShow()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x7FEE54", Offset = "0x7FEE54", VA = "0x7FEE54", Slot = "8")]
		protected virtual void AfterShow()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x7FEE58", Offset = "0x7FEE58", VA = "0x7FEE58")]
		public void Hide(bool instant = false)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x7FEF70", Offset = "0x7FEF70", VA = "0x7FEF70")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x7FEFA8", Offset = "0x7FEFA8", VA = "0x7FEFA8", Slot = "9")]
		protected virtual void BeforeHide()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x7FEFAC", Offset = "0x7FEFAC", VA = "0x7FEFAC", Slot = "10")]
		protected virtual void AfterHide()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x7FECC0", Offset = "0x7FECC0", VA = "0x7FECC0")]
		public UIScreen()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Screens.MainMenu
{
	[Token(Token = "0x20000ED")]
	public class MenuScreen : UIScreen
	{
		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int OverrideStartingTab;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UIScreenTab[] Tabs;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int StartingTab;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DynamicResizablePanelManager NavBar;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public TitleBar TitleBar;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UIScreenTab _curTab;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _curTabId;

		[Token(Token = "0x170000A5")]
		public int CurTabId
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x7FEFB0", Offset = "0x7FEFB0", VA = "0x7FEFB0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x7FEFB8", Offset = "0x7FEFB8", VA = "0x7FEFB8", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x7FF0EC", Offset = "0x7FF0EC", VA = "0x7FF0EC")]
		public void OnTabBtn(int id)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x7FF2DC", Offset = "0x7FF2DC", VA = "0x7FF2DC")]
		public void OnTabBtnLongPress(int id)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x7FF370", Offset = "0x7FF370", VA = "0x7FF370")]
		public MenuScreen()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class SplashScreen : UIScreen
	{
		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool IsInitialized;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UIScreenTab[] Tabs;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _curTabId;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UIScreenTab _curTab;

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x7FF378", Offset = "0x7FF378", VA = "0x7FF378", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x7FDCDC", Offset = "0x7FDCDC", VA = "0x7FDCDC")]
		public void MarkAsInitialized()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x7FE734", Offset = "0x7FE734", VA = "0x7FE734")]
		public void SwitchToSettings()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x7FD2BC", Offset = "0x7FD2BC", VA = "0x7FD2BC")]
		public void SwitchToSplash()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x7FDD28", Offset = "0x7FDD28", VA = "0x7FDD28")]
		public void SwitchToCalibration()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x7FF550", Offset = "0x7FF550", VA = "0x7FF550")]
		public void OnSwitchToSplashBtn()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x7FF48C", Offset = "0x7FF48C", VA = "0x7FF48C")]
		private void SwitchToTab(int id)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x7FF5BC", Offset = "0x7FF5BC", VA = "0x7FF5BC")]
		public SplashScreen()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.Screens.Game
{
	[Token(Token = "0x20000EF")]
	public class GameScreen : GameUIScreen
	{
		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LoadingScreen _loadingScreen;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _canBePaused;

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x7FF5C4", Offset = "0x7FF5C4", VA = "0x7FF5C4")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x7FF658", Offset = "0x7FF658", VA = "0x7FF658")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x7FF664", Offset = "0x7FF664", VA = "0x7FF664", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x7FF868", Offset = "0x7FF868", VA = "0x7FF868", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x7FFA30", Offset = "0x7FFA30", VA = "0x7FFA30", Slot = "8")]
		protected override void AfterShow()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x7FFA3C", Offset = "0x7FFA3C", VA = "0x7FFA3C", Slot = "9")]
		protected override void BeforeHide()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x7FF5D0", Offset = "0x7FF5D0", VA = "0x7FF5D0")]
		private void OnPauseEvent()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x7FFA44", Offset = "0x7FFA44", VA = "0x7FFA44")]
		private void OnRoundCompletedEvent(int value)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x7FFA6C", Offset = "0x7FFA6C", VA = "0x7FFA6C")]
		public GameScreen()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class GameSettingsScreen : GameUIScreen
	{
		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DynamicResizablePanelContent MainPanel;

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x7FFA74", Offset = "0x7FFA74", VA = "0x7FFA74", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x7FFA9C", Offset = "0x7FFA9C", VA = "0x7FFA9C")]
		public void OnBackBtn()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x7FFB10", Offset = "0x7FFB10", VA = "0x7FFB10")]
		public GameSettingsScreen()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class LevelCompletedScreen : GameUIScreen
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform Panel;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LocalizationParamsManager TitleLabel;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ImageStatBarSprites PreviousBestStars;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ImageStatBarSprites CurrentStars;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI RewardLabel;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Button NextBtn;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject NextGroup;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject NextAreaCompleteGroup;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject NextLastLevelCompleteGroup;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject NextEquipmentContainer;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public NextEquipmentBar[] NextEquipmentBars;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private LevelManager _levelManager;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _newEquipmentAvailable;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool _continueOptionChosen;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int _reward;

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x7FFB18", Offset = "0x7FFB18", VA = "0x7FFB18", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x7FFB90", Offset = "0x7FFB90", VA = "0x7FFB90", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x7FFBA8", Offset = "0x7FFBA8", VA = "0x7FFBA8")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x80023C", Offset = "0x80023C", VA = "0x80023C")]
		private void RefreshNextEquipmentBars(bool avoidWindowRescale = false)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x800328", Offset = "0x800328", VA = "0x800328")]
		public void OnContinueBtn()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x8003B4", Offset = "0x8003B4", VA = "0x8003B4")]
		public void OnRetryBtn()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x800440", Offset = "0x800440", VA = "0x800440")]
		public void OnQuitBtn()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x8004D0", Offset = "0x8004D0", VA = "0x8004D0")]
		public void OnEquipmentBtn(int type)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x800560", Offset = "0x800560", VA = "0x800560", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x800570", Offset = "0x800570", VA = "0x800570")]
		public LevelCompletedScreen()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class LevelFailedScreen : GameUIScreen
	{
		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform Panel;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LocalizationParamsManager TitleLabel;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ImageStatBarSprites PreviousBestStars;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI RewardLabel;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject RessuplyBtnContainer;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI RessuplyBtnLabel;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Button SkipBtn;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject SkipGroup;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject SkipLastLevelInAreaGroup;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject SkipLastLevelGroup;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private LevelManager _levelManager;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool ressuplyResourcesAvailable;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool _continueOptionChosen;

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x800578", Offset = "0x800578", VA = "0x800578", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x800704", Offset = "0x800704", VA = "0x800704", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x80071C", Offset = "0x80071C", VA = "0x80071C")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x800C24", Offset = "0x800C24", VA = "0x800C24")]
		private void RessuplyAndContinue()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x800C40", Offset = "0x800C40", VA = "0x800C40")]
		private void OnSecondaryCurrencyChanged(int value)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x800C44", Offset = "0x800C44", VA = "0x800C44")]
		public void OnRetryBtn()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x800CD0", Offset = "0x800CD0", VA = "0x800CD0")]
		public void OnSkipBtn()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x800D5C", Offset = "0x800D5C", VA = "0x800D5C")]
		public void OnQuitBtn()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x800DEC", Offset = "0x800DEC", VA = "0x800DEC")]
		private void OnRessuplyEvent()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x800E0C", Offset = "0x800E0C", VA = "0x800E0C", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x800F5C", Offset = "0x800F5C", VA = "0x800F5C")]
		public LevelFailedScreen()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class MiniGameCompletedScreen : GameUIScreen
	{
		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform Panel;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LocalizationParamsManager TitleLabel;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI PreviousBestScore;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI CurrentScore;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI RewardLabel;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public NextEquipmentBar[] NextEquipmentBars;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MiniGameManager _miniGameManager;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _reward;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool _continueOptionChosen;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x800F64", Offset = "0x800F64", VA = "0x800F64", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x800FDC", Offset = "0x800FDC", VA = "0x800FDC", Slot = "7")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x800FF4", Offset = "0x800FF4", VA = "0x800FF4")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x801688", Offset = "0x801688", VA = "0x801688")]
		private void RefreshNextEquipmentBars()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x801738", Offset = "0x801738", VA = "0x801738")]
		public void OnQuitBtn()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x8017C8", Offset = "0x8017C8", VA = "0x8017C8")]
		public void OnRetryBtn()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x801854", Offset = "0x801854", VA = "0x801854")]
		public void OnEquipmentBtn(int type)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x8018E4", Offset = "0x8018E4", VA = "0x8018E4")]
		public MiniGameCompletedScreen()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class MiniGameScreen : GameUIScreen
	{
		[Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private sealed class <ProcessCountdown>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MiniGameScreen <>4__this;

			[Token(Token = "0x170000A6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600073A")]
				[Address(RVA = "0x802270", Offset = "0x802270", VA = "0x802270", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600073C")]
				[Address(RVA = "0x8022B8", Offset = "0x8022B8", VA = "0x8022B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x801EA8", Offset = "0x801EA8", VA = "0x801EA8")]
			[DebuggerHidden]
			public <ProcessCountdown>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x802100", Offset = "0x802100", VA = "0x802100", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x802104", Offset = "0x802104", VA = "0x802104", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x802278", Offset = "0x802278", VA = "0x802278", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI CountdownLabel;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float CountdownTime;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LoadingScreen _loadingScreen;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _canBePaused;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool _firstTimeShow;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _time;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MiniGameManager _miniGameManager;

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x8018EC", Offset = "0x8018EC", VA = "0x8018EC")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x801980", Offset = "0x801980", VA = "0x801980")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x80198C", Offset = "0x80198C", VA = "0x80198C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x801BB8", Offset = "0x801BB8", VA = "0x801BB8", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x801DA8", Offset = "0x801DA8", VA = "0x801DA8", Slot = "8")]
		protected override void AfterShow()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x801E10", Offset = "0x801E10", VA = "0x801E10", Slot = "9")]
		protected override void BeforeHide()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x8018F8", Offset = "0x8018F8", VA = "0x8018F8")]
		private void OnPauseEvent()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x801E18", Offset = "0x801E18", VA = "0x801E18")]
		private void OnRoundCompletedEvent(int value)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x801DE8", Offset = "0x801DE8", VA = "0x801DE8")]
		private void StartCountdown()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x801E40", Offset = "0x801E40", VA = "0x801E40")]
		[IteratorStateMachine(typeof(<ProcessCountdown>d__16))]
		private IEnumerator ProcessCountdown()
		{
			return null;
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x801ED0", Offset = "0x801ED0", VA = "0x801ED0")]
		private void AnimateCountdownLabel()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x80207C", Offset = "0x80207C", VA = "0x80207C")]
		private void FadeOutCountdownLabel()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x8020CC", Offset = "0x8020CC", VA = "0x8020CC")]
		private void StartRound()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x8020E8", Offset = "0x8020E8", VA = "0x8020E8")]
		public MiniGameScreen()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class PauseScreen : GameUIScreen
	{
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool IsMiniGame;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LoadingScreen _loadingScreen;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _canBeUnpaused;

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x8022C0", Offset = "0x8022C0", VA = "0x8022C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x8023FC", Offset = "0x8023FC", VA = "0x8023FC", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x8024FC", Offset = "0x8024FC", VA = "0x8024FC", Slot = "8")]
		protected override void AfterShow()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x802508", Offset = "0x802508", VA = "0x802508", Slot = "9")]
		protected override void BeforeHide()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x802510", Offset = "0x802510", VA = "0x802510")]
		private void OnPauseEvent()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x802520", Offset = "0x802520", VA = "0x802520")]
		public void OnResumeBtn()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x802594", Offset = "0x802594", VA = "0x802594")]
		public void OnRestartBtn()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x802680", Offset = "0x802680", VA = "0x802680")]
		public void OnSettingsBtn()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x8026F4", Offset = "0x8026F4", VA = "0x8026F4")]
		public void OnQuitBtn()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x8027D8", Offset = "0x8027D8", VA = "0x8027D8")]
		public PauseScreen()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UI.ModalWindows
{
	[Token(Token = "0x20000F7")]
	public class EquipmentStatWindow : ModalWindow
	{
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image[] StatPortraitList;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI[] StatTitleList;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI[] StatDescriptionList;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LocalizationParamsManager[] Parameters;

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x8027E0", Offset = "0x8027E0", VA = "0x8027E0")]
		public void Init(int id)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x802B20", Offset = "0x802B20", VA = "0x802B20")]
		public void Init(int id, int equipmentType, EquipmentData data)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x8027FC", Offset = "0x8027FC", VA = "0x8027FC")]
		private void Highlight(int id)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x8035F4", Offset = "0x8035F4", VA = "0x8035F4")]
		public EquipmentStatWindow()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class ErrorWindow : ModalWindow
	{
		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Localize Title;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Localize Description;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action _onAction0;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action _onAction1;

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x803604", Offset = "0x803604", VA = "0x803604")]
		public void Init(string title, string description)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x803678", Offset = "0x803678", VA = "0x803678")]
		public void Init(string title, string description, Action onAction0, Action onAction1)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x803700", Offset = "0x803700", VA = "0x803700")]
		public void OnAction0()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x803920", Offset = "0x803920", VA = "0x803920")]
		public void OnAction1()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x8039A0", Offset = "0x8039A0", VA = "0x8039A0")]
		public ErrorWindow()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class FestiveModalWindow : ModalWindow
	{
		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform ExpandingBackground;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action _onComplete;

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x8039A8", Offset = "0x8039A8", VA = "0x8039A8", Slot = "9")]
		protected override void BeforeShow()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x803A88", Offset = "0x803A88", VA = "0x803A88", Slot = "13")]
		public virtual void Hide(Action onComplete, bool instant = false)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x803A98", Offset = "0x803A98", VA = "0x803A98", Slot = "12")]
		protected override void AfterHide()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x803AB4", Offset = "0x803AB4", VA = "0x803AB4")]
		public FestiveModalWindow()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[RequireComponent(typeof(CanvasGroup))]
	public class ModalWindow : MonoBehaviour
	{
		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool CanBeClosedWithBackButton;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x170000A8")]
		public virtual bool IsVisible
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x803ABC", Offset = "0x803ABC", VA = "0x803ABC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x803B64", Offset = "0x803B64", VA = "0x803B64", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x803BB4", Offset = "0x803BB4", VA = "0x803BB4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x803BC4", Offset = "0x803BC4", VA = "0x803BC4", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x803BC8", Offset = "0x803BC8", VA = "0x803BC8", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x802998", Offset = "0x802998", VA = "0x802998")]
		public void Show(bool instant = false)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x803BCC", Offset = "0x803BCC", VA = "0x803BCC")]
		private void OnShowComplete()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x803A84", Offset = "0x803A84", VA = "0x803A84", Slot = "9")]
		protected virtual void BeforeShow()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x803BD8", Offset = "0x803BD8", VA = "0x803BD8", Slot = "10")]
		protected virtual void AfterShow()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x803BDC", Offset = "0x803BDC", VA = "0x803BDC")]
		public void OnHideBtn()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x803780", Offset = "0x803780", VA = "0x803780")]
		public void Hide(bool instant = false)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x803C48", Offset = "0x803C48", VA = "0x803C48")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x803C80", Offset = "0x803C80", VA = "0x803C80", Slot = "11")]
		protected virtual void BeforeHide()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x803AB0", Offset = "0x803AB0", VA = "0x803AB0", Slot = "12")]
		protected virtual void AfterHide()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x8035FC", Offset = "0x8035FC", VA = "0x8035FC")]
		public ModalWindow()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class ModalWindowManager : MonoBehaviour
	{
		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ModalWindowManager Instance;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EquipmentStatWindow EquipmentStatInfoWindow;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModalWindow MiniGameTutorialWindow;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArmLengthCalibrationWindow ArmLengthCalibrationWindow;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PrivacyWindow PrivacyWindow;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x803C84", Offset = "0x803C84", VA = "0x803C84")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x803CD0", Offset = "0x803CD0", VA = "0x803CD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x803D18", Offset = "0x803D18", VA = "0x803D18")]
		public ModalWindowManager()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class WaitingWindow : ModalWindow
	{
		[Token(Token = "0x20000FD")]
		[CompilerGenerated]
		private sealed class <UpdateCountdown>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WaitingWindow <>4__this;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000776")]
				[Address(RVA = "0x8043C0", Offset = "0x8043C0", VA = "0x8043C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000778")]
				[Address(RVA = "0x804408", Offset = "0x804408", VA = "0x804408", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x8041F8", Offset = "0x8041F8", VA = "0x8041F8")]
			[DebuggerHidden]
			public <UpdateCountdown>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x804314", Offset = "0x804314", VA = "0x804314", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x804318", Offset = "0x804318", VA = "0x804318", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x8043C8", Offset = "0x8043C8", VA = "0x8043C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000FE")]
		[CompilerGenerated]
		private sealed class <UpdateStopwatch>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WaitingWindow <>4__this;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600077C")]
				[Address(RVA = "0x8044B0", Offset = "0x8044B0", VA = "0x8044B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600077E")]
				[Address(RVA = "0x8044F8", Offset = "0x8044F8", VA = "0x8044F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x804288", Offset = "0x804288", VA = "0x804288")]
			[DebuggerHidden]
			public <UpdateStopwatch>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x804410", Offset = "0x804410", VA = "0x804410", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x804414", Offset = "0x804414", VA = "0x804414", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x8044B8", Offset = "0x8044B8", VA = "0x8044B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Localize Title;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Localize Description;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI Timer;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform Image;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _countdown;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaitForSecondsRealtime _waitForSecond;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _coroutine;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x803D20", Offset = "0x803D20", VA = "0x803D20", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x803D8C", Offset = "0x803D8C", VA = "0x803D8C")]
		public void Init(int seconds = -1, bool startImmediately = true)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x803F04", Offset = "0x803F04", VA = "0x803F04")]
		public void Init(string title, string description, int seconds = -1, bool startImmediately = true)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x803F8C", Offset = "0x803F8C", VA = "0x803F8C")]
		public void UpdateDescription(string title, string description)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x803EE8", Offset = "0x803EE8", VA = "0x803EE8")]
		public void StartTimer()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x804044", Offset = "0x804044", VA = "0x804044")]
		private void StartCountdown()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x804190", Offset = "0x804190", VA = "0x804190")]
		[IteratorStateMachine(typeof(<UpdateCountdown>d__13))]
		private IEnumerator UpdateCountdown()
		{
			return null;
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x8040C8", Offset = "0x8040C8", VA = "0x8040C8")]
		public void StartStopwatch()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x804220", Offset = "0x804220", VA = "0x804220")]
		[IteratorStateMachine(typeof(<UpdateStopwatch>d__15))]
		private IEnumerator UpdateStopwatch()
		{
			return null;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x804164", Offset = "0x804164", VA = "0x804164")]
		private void DisableTimer()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x8042B0", Offset = "0x8042B0", VA = "0x8042B0", Slot = "12")]
		protected override void AfterHide()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x8042E0", Offset = "0x8042E0", VA = "0x8042E0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x80430C", Offset = "0x80430C", VA = "0x80430C")]
		public WaitingWindow()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Tutorial
{
	[Token(Token = "0x20000FF")]
	public class TutorialHitTargets : TutorialStepVR
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _bowHand;

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x804500", Offset = "0x804500", VA = "0x804500", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x804688", Offset = "0x804688", VA = "0x804688")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x804788", Offset = "0x804788", VA = "0x804788")]
		private void OnArrowPickedEvent(EDKG.ArcheryRange.VR.Arrow arrow)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x8047A8", Offset = "0x8047A8", VA = "0x8047A8")]
		public TutorialHitTargets()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class TutorialStepDrawAndRelease : TutorialStepVR
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SplineComputer SplineRight;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform SplineRightStart;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform SplineRightEnd;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform _nock;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x8047E0", Offset = "0x8047E0", VA = "0x8047E0", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x804868", Offset = "0x804868", VA = "0x804868")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x8048E8", Offset = "0x8048E8", VA = "0x8048E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x804968", Offset = "0x804968", VA = "0x804968", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x804A6C", Offset = "0x804A6C", VA = "0x804A6C")]
		private void UpdateSpline(SplineComputer spline, Vector3 pos0, Vector3 pos0OffsetDirection, Vector3 pos1, Vector3 pos1OffsetDirection, Transform startSprite, Transform endSprite)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x804CE0", Offset = "0x804CE0", VA = "0x804CE0")]
		private void OnShootEvent()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x804CE4", Offset = "0x804CE4", VA = "0x804CE4")]
		public TutorialStepDrawAndRelease()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class TutorialStepMiniGames : TutorialStep
	{
		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModalWindow ModalWindow;

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x804D00", Offset = "0x804D00", VA = "0x804D00", Slot = "4")]
		public override void Show(Tutorial tutorial)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x804D9C", Offset = "0x804D9C", VA = "0x804D9C", Slot = "5")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x804E20", Offset = "0x804E20", VA = "0x804E20")]
		public void CompleteTutorialStep()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x804E24", Offset = "0x804E24", VA = "0x804E24")]
		public TutorialStepMiniGames()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class TutorialStepNockArrow : TutorialStepVR
	{
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SplineComputer SplineLeft;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SplineComputer SplineRight;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform SplineLeftStart;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform SplineLeftEnd;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform SplineRightStart;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform SplineRightEnd;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _bowHand;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _hand;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform _nock;

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x804E34", Offset = "0x804E34", VA = "0x804E34", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x8050E0", Offset = "0x8050E0", VA = "0x8050E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x805328", Offset = "0x805328", VA = "0x805328")]
		private void Start()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x8053A8", Offset = "0x8053A8", VA = "0x8053A8")]
		private void OnBowPickedEvent(Bow bow, int hand, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x8050AC", Offset = "0x8050AC", VA = "0x8050AC")]
		private void SetBowHand(int hand)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x8053DC", Offset = "0x8053DC", VA = "0x8053DC", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x805650", Offset = "0x805650", VA = "0x805650")]
		private void UpdateSpline(SplineComputer spline, Vector3 pos0, Vector3 pos0OffsetDirection, Vector3 pos1, Vector3 pos1OffsetDirection, Transform startSprite, Transform endSprite)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x8058C4", Offset = "0x8058C4", VA = "0x8058C4")]
		private void OnArrowNockedEvent()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x8058C8", Offset = "0x8058C8", VA = "0x8058C8")]
		private void OnArrowGoingHomeEvent()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x805994", Offset = "0x805994", VA = "0x805994")]
		public TutorialStepNockArrow()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class TutorialStepPickArrow : TutorialStepVR
	{
		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 QuiverOffset;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SplineComputer SplineLeft;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SplineComputer SplineRight;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform SplineLeftStart;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform SplineLeftEnd;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform SplineRightStart;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform SplineRightEnd;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _bowHand;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform _hand;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform _quiver;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 _quiverOffset;

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x8059B0", Offset = "0x8059B0", VA = "0x8059B0", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x805C04", Offset = "0x805C04", VA = "0x805C04")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x805DDC", Offset = "0x805DDC", VA = "0x805DDC")]
		private void Start()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x805DFC", Offset = "0x805DFC", VA = "0x805DFC")]
		private void OnBowPickedEvent(Bow bow, int hand, XRDirectInteractor interactor)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x805BA4", Offset = "0x805BA4", VA = "0x805BA4")]
		private void SetBowHand(int hand)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x805E04", Offset = "0x805E04", VA = "0x805E04", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x805FB8", Offset = "0x805FB8", VA = "0x805FB8")]
		private void UpdateSpline(SplineComputer spline, Vector3 pos0, Vector3 pos0OffsetDirection, Vector3 pos1, Vector3 pos1OffsetDirection, Transform startSprite, Transform endSprite)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x80622C", Offset = "0x80622C", VA = "0x80622C")]
		private void OnArrowPickedEvent(EDKG.ArcheryRange.VR.Arrow arrow)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x806230", Offset = "0x806230", VA = "0x806230")]
		public TutorialStepPickArrow()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class TutorialStepSwapHands : TutorialStepVR
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SplineComputer SplineLeft;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SplineComputer SplineRight;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform SplineLeftStart;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform SplineLeftEnd;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform SplineRightStart;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform SplineRightEnd;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public InputActionReference ForceGrabBowLeftAction;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public InputActionReference ForceGrabBowRightAction;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InputAction _forceGrabBowLeftAction;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InputAction _forceGrabBowRightAction;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform _handLeft;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform _handRight;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quiver _quiver;

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x80625C", Offset = "0x80625C", VA = "0x80625C", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x8063CC", Offset = "0x8063CC", VA = "0x8063CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x8063EC", Offset = "0x8063EC", VA = "0x8063EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x8064CC", Offset = "0x8064CC", VA = "0x8064CC", Slot = "8")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x806678", Offset = "0x806678", VA = "0x806678")]
		private void UpdateSpline(SplineComputer spline, Vector3 pos0, Vector3 pos0OffsetDirection, Vector3 pos1, Vector3 pos1OffsetDirection, Transform startSprite, Transform endSprite)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x8068EC", Offset = "0x8068EC", VA = "0x8068EC")]
		private void OnForceGrabBowLeft(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x806908", Offset = "0x806908", VA = "0x806908")]
		private void OnForceGrabBowRight(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x806924", Offset = "0x806924", VA = "0x806924")]
		public TutorialStepSwapHands()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class TutorialStepVR : TutorialStep
	{
		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float YOffset;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ZOffset;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float SmoothFollowFactor;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Body _body;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform _camera;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 _targetPos;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion _targetRot;

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x804608", Offset = "0x804608", VA = "0x804608", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x806940", Offset = "0x806940", VA = "0x806940", Slot = "4")]
		public override void Show(Tutorial tutorial)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x806970", Offset = "0x806970", VA = "0x806970", Slot = "5")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x804A68", Offset = "0x804A68", VA = "0x804A68", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x8069A0", Offset = "0x8069A0", VA = "0x8069A0")]
		private void UpdatePosition()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x8047C4", Offset = "0x8047C4", VA = "0x8047C4")]
		public TutorialStepVR()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000106")]
	public class Tutorial
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TutorialStep[] Steps;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TutorialManager _tutorialManager;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _curStepId;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TutorialStep _curStep;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x806BD0", Offset = "0x806BD0", VA = "0x806BD0")]
		public void Init(TutorialManager tutorialManager)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x806C30", Offset = "0x806C30", VA = "0x806C30")]
		public void MarkStepComplete(TutorialStep step)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x806BE0", Offset = "0x806BE0", VA = "0x806BE0")]
		private void NextStep()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x806D0C", Offset = "0x806D0C", VA = "0x806D0C")]
		private void ReportTutorialComplete()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x8058E4", Offset = "0x8058E4", VA = "0x8058E4")]
		public void Rewind(TutorialStep step)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x806D80", Offset = "0x806D80", VA = "0x806D80")]
		private void PreviousStep()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x806DD0", Offset = "0x806DD0", VA = "0x806DD0")]
		public void Hide()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x806E40", Offset = "0x806E40", VA = "0x806E40")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x806EB0", Offset = "0x806EB0", VA = "0x806EB0")]
		public Tutorial()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class TutorialManager : MonoBehaviour
	{
		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TutorialManager Instance;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Tutorial[] Tutorials;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _curTutorialId;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Tutorial _curTutorial;

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x806EC0", Offset = "0x806EC0", VA = "0x806EC0")]
		public void Awake()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x7FE024", Offset = "0x7FE024", VA = "0x7FE024")]
		public void ShowTutorialIfNeeded(int type)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x806F94", Offset = "0x806F94", VA = "0x806F94")]
		private bool IsTutorialNeeded(int type)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x806FD0", Offset = "0x806FD0", VA = "0x806FD0")]
		public void ShowTutorial(int type)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x806D28", Offset = "0x806D28", VA = "0x806D28")]
		public void MarkTutorialComplete(Tutorial tutorial)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x807040", Offset = "0x807040", VA = "0x807040")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x8070D8", Offset = "0x8070D8", VA = "0x8070D8")]
		public TutorialManager()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class TutorialStarter : MonoBehaviour
	{
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x8070E8", Offset = "0x8070E8", VA = "0x8070E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x80713C", Offset = "0x80713C", VA = "0x80713C")]
		public TutorialStarter()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public abstract class TutorialStep : MonoBehaviour
	{
		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Tutorial _tutorial;

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x804D24", Offset = "0x804D24", VA = "0x804D24", Slot = "4")]
		public virtual void Show(Tutorial tutorial)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x804DC0", Offset = "0x804DC0", VA = "0x804DC0", Slot = "5")]
		public virtual void Hide()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x80478C", Offset = "0x80478C", VA = "0x80478C")]
		protected void ReportComplete()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x807144", Offset = "0x807144", VA = "0x807144", Slot = "6")]
		public virtual void Destroy()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x804E2C", Offset = "0x804E2C", VA = "0x804E2C")]
		protected TutorialStep()
		{
		}
	}
}
namespace EDKG.ArcheryRange._MiniGame
{
	[Token(Token = "0x200010A")]
	public class TwoTargetRotator : DynamicObject
	{
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target[] TargetList;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DynamicObject[] ObjectsToActivate;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _curTarget;

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x807148", Offset = "0x807148", VA = "0x807148", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x8071FC", Offset = "0x8071FC", VA = "0x8071FC")]
		public TwoTargetRotator()
		{
		}
	}
}
namespace EDKG.ArcheryRange._MiniGame.SpringBarrelComponents
{
	[Token(Token = "0x200010B")]
	public class SpringBarrel : MonoBehaviour
	{
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target Target;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform Container;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Speed;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool _goingUp;

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x807204", Offset = "0x807204", VA = "0x807204")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x807320", Offset = "0x807320", VA = "0x807320")]
		private void OnStepComplete()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x8074D0", Offset = "0x8074D0", VA = "0x8074D0")]
		public SpringBarrel()
		{
		}
	}
}
namespace EDKG.ArcheryRange._MiniGame.BullseyeField
{
	[Token(Token = "0x200010C")]
	public class RandomTargetActivator : DynamicObject
	{
		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] Targets;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ActivateOnAwake;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _lastTargetId;

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x8074E8", Offset = "0x8074E8", VA = "0x8074E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x807500", Offset = "0x807500", VA = "0x807500", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x8075A0", Offset = "0x8075A0", VA = "0x8075A0")]
		public RandomTargetActivator()
		{
		}
	}
	[Token(Token = "0x200010D")]
	internal class RandomTargetActivatorWithCheck : DynamicObject
	{
		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] Targets;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Target[] TargetsToCheck;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ActivateOnAwake;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DelayedActivatorAudioPlayer AudioPlayer;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _lastTargetId;

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x8075B8", Offset = "0x8075B8", VA = "0x8075B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x8075D0", Offset = "0x8075D0", VA = "0x8075D0", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x807784", Offset = "0x807784", VA = "0x807784")]
		public RandomTargetActivatorWithCheck()
		{
		}
	}
}
namespace EDKG.ArcheryRange._MiniGame.TwoTargetRotatorComponents
{
	[Token(Token = "0x200010E")]
	public class RandomAreaMover : DynamicObject
	{
		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Corner1;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform Corner2;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float TweenDuration;

		[Token(Token = "0x170000AD")]
		public Vector3 NewPos
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x80779C", Offset = "0x80779C", VA = "0x80779C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x8077A8", Offset = "0x8077A8", VA = "0x8077A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x8077B4", Offset = "0x8077B4", VA = "0x8077B4", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x8078B0", Offset = "0x8078B0", VA = "0x8078B0")]
		public RandomAreaMover()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class RandomAxisMover : DynamicObject
	{
		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Point1;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 Point2;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float TweenDuration;

		[Token(Token = "0x170000AE")]
		public Vector3 NewPos
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x8078C0", Offset = "0x8078C0", VA = "0x8078C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x8078CC", Offset = "0x8078CC", VA = "0x8078CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x8078D8", Offset = "0x8078D8", VA = "0x8078D8", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x80798C", Offset = "0x80798C", VA = "0x80798C")]
		public RandomAxisMover()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class StepRotator : DynamicObject
	{
		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Step;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TweenDuration;

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x80799C", Offset = "0x80799C", VA = "0x80799C", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x8079C4", Offset = "0x8079C4", VA = "0x8079C4")]
		public StepRotator()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class TargetFacer : DynamicObject
	{
		[Token(Token = "0x2000112")]
		[CompilerGenerated]
		private sealed class <DelayedActivation>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TargetFacer <>4__this;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x807C64", Offset = "0x807C64", VA = "0x807C64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E4")]
				[Address(RVA = "0x807CAC", Offset = "0x807CAC", VA = "0x807CAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x807B30", Offset = "0x807B30", VA = "0x807B30")]
			[DebuggerHidden]
			public <DelayedActivation>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x807B68", Offset = "0x807B68", VA = "0x807B68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x807B6C", Offset = "0x807B6C", VA = "0x807B6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x807C6C", Offset = "0x807C6C", VA = "0x807C6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Target;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RandomAreaMover Pos;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float TweenDuration;

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x8079D4", Offset = "0x8079D4", VA = "0x8079D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x807AA8", Offset = "0x807AA8", VA = "0x807AA8", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x807AC8", Offset = "0x807AC8", VA = "0x807AC8")]
		[IteratorStateMachine(typeof(<DelayedActivation>d__5))]
		private IEnumerator DelayedActivation()
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x807B58", Offset = "0x807B58", VA = "0x807B58")]
		public TargetFacer()
		{
		}
	}
}
namespace EDKG.ArcheryRange._MiniGame.CircularRotatorComponents
{
	[Token(Token = "0x2000113")]
	public class StepRotator : DynamicObject
	{
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x807CB4", Offset = "0x807CB4", VA = "0x807CB4", Slot = "4")]
		public override void Activate()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x807D44", Offset = "0x807D44", VA = "0x807D44")]
		public StepRotator()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class TargetRotator : MonoBehaviour
	{
		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Target Target;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Speed;

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x807D4C", Offset = "0x807D4C", VA = "0x807D4C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x807E64", Offset = "0x807E64", VA = "0x807E64")]
		private void OnStepComplete()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x807E94", Offset = "0x807E94", VA = "0x807E94")]
		public TargetRotator()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class ConstantRotator : MonoBehaviour
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Speed;

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x807EA4", Offset = "0x807EA4", VA = "0x807EA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x807F3C", Offset = "0x807F3C", VA = "0x807F3C")]
		public ConstantRotator()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Temp
{
	[Token(Token = "0x2000116")]
	public class TreeWindZone : MonoBehaviour
	{
		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer _renderer;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MaterialPropertyBlock _propBlock;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector4 _wind;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x807F44", Offset = "0x807F44", VA = "0x807F44")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x807FD0", Offset = "0x807FD0", VA = "0x807FD0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x807FD8", Offset = "0x807FD8", VA = "0x807FD8")]
		public void UpdateWind(bool setToZero = false)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x8083C0", Offset = "0x8083C0", VA = "0x8083C0")]
		public TreeWindZone()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Progression.MiniGames
{
	[Serializable]
	[Token(Token = "0x2000117")]
	public class MiniGameData
	{
		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Id;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite BackgroundSprite;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite BlurredBackgroundSprite;

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x8083C8", Offset = "0x8083C8", VA = "0x8083C8")]
		public MiniGameData()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[CreateAssetMenu(fileName = "MiniGameDataLibrary", menuName = "ScriptableObjects/MiniGame Data Library", order = 0)]
	public class MiniGameDataLibrary : ScriptableObject
	{
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MiniGameData[] MiniGameList;

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x8083D0", Offset = "0x8083D0", VA = "0x8083D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x808428", Offset = "0x808428", VA = "0x808428")]
		public MiniGameDataLibrary()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Progression.Balance
{
	[Serializable]
	[Token(Token = "0x2000119")]
	public class EquipmentBalanceData
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int PricePrimaryCurrency;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int UnlockArea;

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x808430", Offset = "0x808430", VA = "0x808430")]
		public EquipmentBalanceData(int pricePrimaryCurrency, int unlockArea)
		{
		}
	}
	[Token(Token = "0x200011A")]
	[CreateAssetMenu(fileName = "BalanceData", menuName = "ScriptableObjects/Balance Data", order = 0)]
	public class BalanceData : ScriptableObject
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static BalanceData Instance;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Data loading")]
		[ReadOnly]
		public string Version;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAsset TextAsset;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Progression")]
		public int AreaCount;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int[] AreaStarRequirement;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Primary currency gains")]
		public int[] StarPCGain;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int[] BullseyeHitPCGain;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int[] MiniGameHitPCGain;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float MiniGameBullseyeHitTimeGain;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Equipment stats")]
		public EquipmentBalanceData[] Bows;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EquipmentBalanceData[] Arrows;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Monetization Costs")]
		public int RessuplyCost;

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x80845C", Offset = "0x80845C", VA = "0x80845C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x8084A8", Offset = "0x8084A8", VA = "0x8084A8")]
		[ContextMenu("Load from CSV")]
		public void LoadFromCSV()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x808E24", Offset = "0x808E24", VA = "0x808E24")]
		public bool IsBowPurchaseable(int id, int currencyAmount)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x808E64", Offset = "0x808E64", VA = "0x808E64")]
		public bool IsArrowPurchaseable(int id, int currencyAmount)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x808EA4", Offset = "0x808EA4", VA = "0x808EA4")]
		public BalanceData()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Progression.Areas
{
	[Serializable]
	[Token(Token = "0x200011B")]
	public class AreaData
	{
		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Id;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture BackgroundTexture;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture BlurredBackgroundTexture;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int TextureId;

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x808EBC", Offset = "0x808EBC", VA = "0x808EBC")]
		public AreaData()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[CreateAssetMenu(fileName = "AreaDataLibrary", menuName = "ScriptableObjects/Area Data Library", order = 0)]
	public class AreaDataLibrary : ScriptableObject
	{
		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AreaData[] AreaList;

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x808EC4", Offset = "0x808EC4", VA = "0x808EC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x808F1C", Offset = "0x808F1C", VA = "0x808F1C")]
		public AreaDataLibrary()
		{
		}
	}
}
namespace EDKG.ArcheryRange.PostLut
{
	[Token(Token = "0x200011D")]
	[ExecuteInEditMode]
	public class PostLut : MonoBehaviour
	{
		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material SourceMaterial;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture2D DebugTexture;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Texture2D _nextLut;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material _instancedMaterial;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly int _textureNameId;

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x808F24", Offset = "0x808F24", VA = "0x808F24")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x808FFC", Offset = "0x808FFC", VA = "0x808FFC")]
		[ContextMenu("Test")]
		private void TestDebugTexture()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x8090F0", Offset = "0x8090F0", VA = "0x8090F0")]
		public void ChangeLut(Texture2D lut)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x8091DC", Offset = "0x8091DC", VA = "0x8091DC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x8092B8", Offset = "0x8092B8", VA = "0x8092B8")]
		public void Toggle(bool value)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x8092C4", Offset = "0x8092C4", VA = "0x8092C4")]
		public PostLut()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class PostLutChanger : MonoBehaviour
	{
		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D Lut;

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x80931C", Offset = "0x80931C", VA = "0x80931C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x809320", Offset = "0x809320", VA = "0x809320")]
		[ContextMenu("Change LUT")]
		private void ChangeLut()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x8093D8", Offset = "0x8093D8", VA = "0x8093D8")]
		[ContextMenu("Disable LUT")]
		private void DisableLut()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x80948C", Offset = "0x80948C", VA = "0x80948C")]
		public PostLutChanger()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Initialization
{
	[Token(Token = "0x200011F")]
	public class EarlyInitMarker : MonoBehaviour
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static EarlyInitMarker Instance;

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x809494", Offset = "0x809494", VA = "0x809494")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x809528", Offset = "0x809528", VA = "0x809528")]
		public EarlyInitMarker()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class EarlyInitMarkerChecker : MonoBehaviour
	{
		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject EarlyInitPrefab;

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x809530", Offset = "0x809530", VA = "0x809530")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x8095FC", Offset = "0x8095FC", VA = "0x8095FC")]
		public EarlyInitMarkerChecker()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class MainInitMarker : MonoBehaviour
	{
		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MainInitMarker Instance;

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x809604", Offset = "0x809604", VA = "0x809604")]
		private void Awake()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x80973C", Offset = "0x80973C", VA = "0x80973C")]
		public MainInitMarker()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class MainInitMarkerChecker : MonoBehaviour
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject MainInitPrefab;

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x809744", Offset = "0x809744", VA = "0x809744")]
		private void Awake()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x809810", Offset = "0x809810", VA = "0x809810")]
		public MainInitMarkerChecker()
		{
		}
	}
}
namespace EDKG.ArcheryRange.ImpactEffects
{
	[Token(Token = "0x2000123")]
	public class BaseImpactNotification : MonoBehaviour
	{
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x809818", Offset = "0x809818", VA = "0x809818", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x80981C", Offset = "0x80981C", VA = "0x80981C", Slot = "5")]
		protected virtual void Init()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x809820", Offset = "0x809820", VA = "0x809820")]
		public BaseImpactNotification()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UIRenderer
{
	[Token(Token = "0x2000124")]
	public class EquipmentUIHomeRenderer : MonoBehaviour
	{
		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] Bows;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] Arrows;

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x809828", Offset = "0x809828", VA = "0x809828")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x8098A8", Offset = "0x8098A8", VA = "0x8098A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x809928", Offset = "0x809928", VA = "0x809928")]
		private void Start()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x80998C", Offset = "0x80998C", VA = "0x80998C")]
		private void OnEquipmentChanged(int bow, int arrow)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x809B20", Offset = "0x809B20", VA = "0x809B20")]
		private void RefreshArrowPositions(Transform arrowGroup, Transform bowGroup)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x809C18", Offset = "0x809C18", VA = "0x809C18")]
		public EquipmentUIHomeRenderer()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class EquipmentUIRenderer : MonoBehaviour
	{
		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RenderTexture RenderTexture;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RawImage[] RawImages;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EquipmentUIRendererGroup[] Groups;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _curCategory;

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x809C20", Offset = "0x809C20", VA = "0x809C20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x809D20", Offset = "0x809D20", VA = "0x809D20")]
		public void SelectEquipment(int type, int id)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x809DCC", Offset = "0x809DCC", VA = "0x809DCC")]
		private void SelectCategory(int type)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x809FE4", Offset = "0x809FE4", VA = "0x809FE4")]
		public EquipmentUIRenderer()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class EquipmentUIRendererGroup : MonoBehaviour
	{
		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] Items;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 Offset;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _curId;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _targetId;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 _startPosition;

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x809FF4", Offset = "0x809FF4", VA = "0x809FF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x809E54", Offset = "0x809E54", VA = "0x809E54")]
		public void SelectInstant(int id)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x809FCC", Offset = "0x809FCC", VA = "0x809FCC")]
		public void Select(int id)
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x80A0D8", Offset = "0x80A0D8", VA = "0x80A0D8")]
		private void MoveToTargetItem()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x80A15C", Offset = "0x80A15C", VA = "0x80A15C")]
		private void EnableRequiredItems()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x80A338", Offset = "0x80A338", VA = "0x80A338")]
		private void Move()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x80A444", Offset = "0x80A444", VA = "0x80A444")]
		private void OnMoveComplete()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x80A448", Offset = "0x80A448", VA = "0x80A448")]
		private void DisableRequiredItems()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x80A228", Offset = "0x80A228", VA = "0x80A228")]
		private void AnimateEnter(Transform t)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x80A024", Offset = "0x80A024", VA = "0x80A024")]
		private void AnimateRegular(Transform t)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x80A0C8", Offset = "0x80A0C8", VA = "0x80A0C8")]
		private void AnimateExit(Transform t)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x80A4DC", Offset = "0x80A4DC", VA = "0x80A4DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x80A564", Offset = "0x80A564", VA = "0x80A564")]
		public EquipmentUIRendererGroup()
		{
		}
	}
}
namespace EDKG.ArcheryRange.UIData
{
	[Serializable]
	[Token(Token = "0x2000128")]
	public class EquipmentUIData
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Sprite Portrait;

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x80A590", Offset = "0x80A590", VA = "0x80A590")]
		public EquipmentUIData()
		{
		}
	}
	[Token(Token = "0x2000129")]
	[CreateAssetMenu(fileName = "EquipmentUILibrary", menuName = "ScriptableObjects/Equipment/Equipment UI Library", order = 0)]
	public class EquipmentUIDataLibrary : ScriptableObject
	{
		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EquipmentUIData[] Bows;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EquipmentUIData[] Arrows;

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x80A598", Offset = "0x80A598", VA = "0x80A598")]
		public EquipmentUIDataLibrary()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Projectiles
{
	[Token(Token = "0x200012A")]
	public class Arrow : MonoBehaviour
	{
		[Token(Token = "0x200012B")]
		public delegate void SimpleEvent(Arrow arrow);

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SimpleEvent OnArrowMissed;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<RaycastHit, Vector3, int> OnHit;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask ColliderLayerMask;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform PhysicalArrowPrefab;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform StuckArrowPrefab;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject Model;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ArrowTrailRenderer TrailRenderer;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IMovable _movementSystem;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isAlive;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _defaultLife;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _curLife;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool _hasPotentialToHitTarget;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _maxTargetDistance;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 _velocity;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _penetrationDepth;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 _lastPos;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x80A5A0", Offset = "0x80A5A0", VA = "0x80A5A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x80A5F0", Offset = "0x80A5F0", VA = "0x80A5F0")]
		public void Init(float speed, SpawnPool spawnPool, float maxTargetDistance)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x80A76C", Offset = "0x80A76C", VA = "0x80A76C")]
		private void Update()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x80ADA0", Offset = "0x80ADA0", VA = "0x80ADA0")]
		private void CheckFutureCollision(RaycastHit hit)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x80AC24", Offset = "0x80AC24", VA = "0x80AC24")]
		private void CheckCollision(RaycastHit hit)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x80B2F0", Offset = "0x80B2F0", VA = "0x80B2F0")]
		private void StuckInObject(RaycastHit hit, [Optional] Transform customTransformToStickTo)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x80B020", Offset = "0x80B020", VA = "0x80B020")]
		private void HitImpenetrableObject(RaycastHit hit)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x80AEE0", Offset = "0x80AEE0", VA = "0x80AEE0")]
		private Transform ReportTargetHit(RaycastHit hit, bool penetrated)
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x80B18C", Offset = "0x80B18C", VA = "0x80B18C")]
		private void ReportEnvironmentHit(RaycastHit hit, bool penetrated)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x80AAE0", Offset = "0x80AAE0", VA = "0x80AAE0")]
		private void ReportTargetMissed()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x80AB48", Offset = "0x80AB48", VA = "0x80AB48")]
		private void Die(bool instant = false)
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x80B5F4", Offset = "0x80B5F4", VA = "0x80B5F4")]
		private void Despawn(bool instant)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x80B658", Offset = "0x80B658", VA = "0x80B658")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x80B6C0", Offset = "0x80B6C0", VA = "0x80B6C0")]
		public Arrow()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class PhysicalArrow : MonoBehaviour
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody Rigidbody;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _life;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _curLife;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x80B500", Offset = "0x80B500", VA = "0x80B500")]
		public void Init(float speed, SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x80B810", Offset = "0x80B810", VA = "0x80B810")]
		private void Update()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x80B85C", Offset = "0x80B85C", VA = "0x80B85C")]
		private void Despawn()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x80B90C", Offset = "0x80B90C", VA = "0x80B90C")]
		public PhysicalArrow()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class StuckArrow : MonoBehaviour
	{
		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _life;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _curLife;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpawnPool _spawnPool;

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x80B4F0", Offset = "0x80B4F0", VA = "0x80B4F0")]
		public void Init(SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x80B91C", Offset = "0x80B91C", VA = "0x80B91C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x80B968", Offset = "0x80B968", VA = "0x80B968")]
		private void Despawn()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x80BA1C", Offset = "0x80BA1C", VA = "0x80BA1C")]
		public StuckArrow()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Projectiles.MovementSystems
{
	[Token(Token = "0x200012E")]
	public interface IMovable
	{
		[Token(Token = "0x6000846")]
		void Init(float speed);

		[Token(Token = "0x6000847")]
		void Process();

		[Token(Token = "0x6000848")]
		Vector3 GetFuturePosition();

		[Token(Token = "0x6000849")]
		Vector3 GetVelocity();

		[Token(Token = "0x600084A")]
		void Kill();
	}
	[Token(Token = "0x200012F")]
	public class PhysicsMovement : MonoBehaviour, IMovable
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody Rigidbody;

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x80BA2C", Offset = "0x80BA2C", VA = "0x80BA2C", Slot = "4")]
		public void Init(float speed)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x80BAE4", Offset = "0x80BAE4", VA = "0x80BAE4", Slot = "5")]
		public void Process()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x80BB64", Offset = "0x80BB64", VA = "0x80BB64", Slot = "6")]
		public Vector3 GetFuturePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x80BBEC", Offset = "0x80BBEC", VA = "0x80BBEC", Slot = "7")]
		public Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x80BC08", Offset = "0x80BC08", VA = "0x80BC08", Slot = "8")]
		public void Kill()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x80BC28", Offset = "0x80BC28", VA = "0x80BC28")]
		public PhysicsMovement()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Projectiles.Effects
{
	[Token(Token = "0x2000130")]
	public class ArrowTrailRenderer : MonoBehaviour
	{
		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject RearSprite;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TrailRenderer TrailRenderer;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isActive;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _defaultTrailRendererActivationTime;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _curTrailRendererActivationTime;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _defaultTrailRendererTime;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _curTrailRendererTime;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x80A708", Offset = "0x80A708", VA = "0x80A708")]
		public void Init()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x80BC30", Offset = "0x80BC30", VA = "0x80BC30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x80B59C", Offset = "0x80B59C", VA = "0x80B59C")]
		public void Kill(bool instant)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x80BD88", Offset = "0x80BD88", VA = "0x80BD88")]
		public ArrowTrailRenderer()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Projectiles.TrajectoryAssist
{
	[Token(Token = "0x2000131")]
	public class AimAssistTrajectory : MonoBehaviour
	{
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform CollisionSpot;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask ColliderLayerMask;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _source;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _velocity;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _drag;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _iterations;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _steps;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SplineComputer _splineComputer;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SplineRenderer _splineRenderer;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _camera;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material _lineMaterial;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3[] _positions;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SplinePoint[] _pointList;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _isActive;

		[Token(Token = "0x170000B1")]
		public SplinePoint[] PointList
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x80BDA4", Offset = "0x80BDA4", VA = "0x80BDA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x80BDAC", Offset = "0x80BDAC", VA = "0x80BDAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x80BF7C", Offset = "0x80BF7C", VA = "0x80BF7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x80BFA8", Offset = "0x80BFA8", VA = "0x80BFA8")]
		public void Init(Transform s, float velocity)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x80C41C", Offset = "0x80C41C", VA = "0x80C41C")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x80C5C4", Offset = "0x80C5C4", VA = "0x80C5C4")]
		public void SetVelocity(float velocity)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x80C5CC", Offset = "0x80C5CC", VA = "0x80C5CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x80BFD0", Offset = "0x80BFD0", VA = "0x80BFD0")]
		private void UpdateTrajectory()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x80C5DC", Offset = "0x80C5DC", VA = "0x80C5DC")]
		private float UpdateCollisions()
		{
			return default(float);
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x80C2F0", Offset = "0x80C2F0", VA = "0x80C2F0")]
		private void Show()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x80C424", Offset = "0x80C424", VA = "0x80C424")]
		private void Hide()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x80C930", Offset = "0x80C930", VA = "0x80C930")]
		private void OnHideComplete()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x80C95C", Offset = "0x80C95C", VA = "0x80C95C")]
		public AimAssistTrajectory()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Equipment
{
	[Token(Token = "0x2000132")]
	public class EquipmentStats
	{
		[Token(Token = "0x170000B2")]
		public EquipmentPrefabData BowPrefabData
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x80C9F0", Offset = "0x80C9F0", VA = "0x80C9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x80C9F8", Offset = "0x80C9F8", VA = "0x80C9F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public ArrowPrefabData ArrowPrefabData
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x80CA00", Offset = "0x80CA00", VA = "0x80CA00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x80CA08", Offset = "0x80CA08", VA = "0x80CA08")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public float BaseAccuracy
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x80CA10", Offset = "0x80CA10", VA = "0x80CA10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x80CA18", Offset = "0x80CA18", VA = "0x80CA18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public float BaseArrowSpeed
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x80CA20", Offset = "0x80CA20", VA = "0x80CA20")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x80CA28", Offset = "0x80CA28", VA = "0x80CA28")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public float BaseStamina
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x80CA30", Offset = "0x80CA30", VA = "0x80CA30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x80CA38", Offset = "0x80CA38", VA = "0x80CA38")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public float Accuracy
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x80CA40", Offset = "0x80CA40", VA = "0x80CA40")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x80CA48", Offset = "0x80CA48", VA = "0x80CA48")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public float ArrowSpeed
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x80CA50", Offset = "0x80CA50", VA = "0x80CA50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x80CA58", Offset = "0x80CA58", VA = "0x80CA58")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public float Stamina
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x80CA60", Offset = "0x80CA60", VA = "0x80CA60")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x80CA68", Offset = "0x80CA68", VA = "0x80CA68")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x80CA70", Offset = "0x80CA70", VA = "0x80CA70")]
		public EquipmentStats()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000133")]
	public class EquipmentData
	{
		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Accuracy;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float ArrowSpeed;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Stamina;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int UIAccuracy;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int UIArrowSpeed;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int UIStamina;

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x80CA78", Offset = "0x80CA78", VA = "0x80CA78")]
		public EquipmentData()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[CreateAssetMenu(fileName = "EquipmentLibrary", menuName = "ScriptableObjects/Equipment/Equipment Library", order = 0)]
	public class EquipmentDataLibrary : ScriptableObject
	{
		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Data loading")]
		[ReadOnly]
		public string Version;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAsset TextAsset;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Space]
		public float BaseAccuracy;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float BaseArrowSpeed;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float BaseStamina;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Space]
		public EquipmentData[] Bows;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space]
		public EquipmentData[] Arrows;

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x80CA80", Offset = "0x80CA80", VA = "0x80CA80")]
		[ContextMenu("Load from CSV")]
		public void LoadFromCSV()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x80D0C0", Offset = "0x80D0C0", VA = "0x80D0C0")]
		public EquipmentDataLibrary()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class AllEquipmentLoader : MonoBehaviour
	{
		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EquipmentDataLibrary EquipmentDataLibrary;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EquipmentPrefabLoader BowPrefabLoader;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EquipmentPrefabLoader ArrowPrefabLoader;

		[Token(Token = "0x170000BA")]
		public EquipmentStats Stats
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x80D0C8", Offset = "0x80D0C8", VA = "0x80D0C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x80D0D0", Offset = "0x80D0D0", VA = "0x80D0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x80D0D8", Offset = "0x80D0D8", VA = "0x80D0D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x80D290", Offset = "0x80D290", VA = "0x80D290")]
		private void Start()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x80D2C8", Offset = "0x80D2C8", VA = "0x80D2C8")]
		public AllEquipmentLoader()
		{
		}
	}
	[Token(Token = "0x2000136")]
	internal class ArrowPrefabLoader : EquipmentPrefabLoader
	{
		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int PreloadAmount;

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x80D2D0", Offset = "0x80D2D0", VA = "0x80D2D0", Slot = "5")]
		public override void FinalizeLoad()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x80D358", Offset = "0x80D358", VA = "0x80D358")]
		private void InstantiatePool(ArrowPrefabData arrowData)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x80D53C", Offset = "0x80D53C", VA = "0x80D53C")]
		public ArrowPrefabLoader()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class BowPrefabLoader : EquipmentPrefabLoader
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform EquipmentContainer;

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x80D554", Offset = "0x80D554", VA = "0x80D554", Slot = "4")]
		public override EquipmentPrefabData AwakeLoad(int id)
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x80D61C", Offset = "0x80D61C", VA = "0x80D61C")]
		private void InstantiateCharacterEquipment(EquipmentPrefabData data)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x80D73C", Offset = "0x80D73C", VA = "0x80D73C")]
		public BowPrefabLoader()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class EquipmentPrefabLoader : MonoBehaviour
	{
		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] DataPath;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected EquipmentPrefabData Data;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected int _id;

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x80D584", Offset = "0x80D584", VA = "0x80D584", Slot = "4")]
		public virtual EquipmentPrefabData AwakeLoad(int id)
		{
			return null;
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x80D354", Offset = "0x80D354", VA = "0x80D354", Slot = "5")]
		public virtual void FinalizeLoad()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x80D54C", Offset = "0x80D54C", VA = "0x80D54C")]
		public EquipmentPrefabLoader()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class QuiverPrefabLoader : EquipmentPrefabLoader
	{
		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform EquipmentContainer;

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x80D744", Offset = "0x80D744", VA = "0x80D744", Slot = "4")]
		public override EquipmentPrefabData AwakeLoad(int id)
		{
			return null;
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x80D774", Offset = "0x80D774", VA = "0x80D774")]
		private void InstantiateCharacterEquipment(EquipmentPrefabData data)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x80D894", Offset = "0x80D894", VA = "0x80D894")]
		public QuiverPrefabLoader()
		{
		}
	}
	[Token(Token = "0x200013A")]
	[CreateAssetMenu(fileName = "Arrow", menuName = "ScriptableObjects/Equipment/Arrow Prefab Data", order = 2)]
	public class ArrowPrefabData : EquipmentPrefabData
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EDKG.ArcheryRange.Projectiles.Arrow ArrowPrefab;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EDKG.ArcheryRange.VR.Arrow DummyArrowPrefab;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PhysicalArrow PhysicalArrowPrefab;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public StuckArrow StuckArrowPrefab;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform Model;

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x80D89C", Offset = "0x80D89C", VA = "0x80D89C")]
		public ArrowPrefabData()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[CreateAssetMenu(fileName = "Equipment", menuName = "ScriptableObjects/Equipment/Equipment Prefab Data", order = 0)]
	public class EquipmentPrefabData : ScriptableObject
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject EquipmentPrefab;

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x80D8A4", Offset = "0x80D8A4", VA = "0x80D8A4")]
		public EquipmentPrefabData()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Targets
{
	[Token(Token = "0x200013C")]
	public class DelayedActivatorAudioPlayer : AudioSourcePool
	{
		[Token(Token = "0x200013D")]
		[CompilerGenerated]
		private sealed class <PlayDelayedActivation>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DelayedActivatorAudioPlayer <>4__this;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000896")]
				[Address(RVA = "0x80DCBC", Offset = "0x80DCBC", VA = "0x80DCBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000898")]
				[Address(RVA = "0x80DD04", Offset = "0x80DD04", VA = "0x80DD04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x80DA78", Offset = "0x80DA78", VA = "0x80DA78")]
			[DebuggerHidden]
			public <PlayDelayedActivation>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x80DBD8", Offset = "0x80DBD8", VA = "0x80DBD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x80DBDC", Offset = "0x80DBDC", VA = "0x80DBDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x80DCC4", Offset = "0x80DCC4", VA = "0x80DCC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200013E")]
		[CompilerGenerated]
		private sealed class <PlayLaunchSound>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DelayedActivatorAudioPlayer <>4__this;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600089C")]
				[Address(RVA = "0x80DDC8", Offset = "0x80DDC8", VA = "0x80DDC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600089E")]
				[Address(RVA = "0x80DE10", Offset = "0x80DE10", VA = "0x80DE10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x80DAA0", Offset = "0x80DAA0", VA = "0x80DAA0")]
			[DebuggerHidden]
			public <PlayLaunchSound>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x80DD0C", Offset = "0x80DD0C", VA = "0x80DD0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x80DD10", Offset = "0x80DD10", VA = "0x80DD10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x80DDD0", Offset = "0x80DDD0", VA = "0x80DDD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip ActivationSound;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip LaunchSound;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float PitchDelta;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float PitchOffset;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float VolumeDelta;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float VolumeOffset;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AudioSource _activationSource;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _delay;

		[Token(Token = "0x4000716")]
		private const float ActivationSoundLength = 2.5f;

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x80D8AC", Offset = "0x80D8AC", VA = "0x80D8AC")]
		public void PlayActivationSound(float delay)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x80D988", Offset = "0x80D988", VA = "0x80D988")]
		[IteratorStateMachine(typeof(<PlayDelayedActivation>d__10))]
		private IEnumerator PlayDelayedActivation(float time)
		{
			return null;
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x80DA00", Offset = "0x80DA00", VA = "0x80DA00")]
		[IteratorStateMachine(typeof(<PlayLaunchSound>d__11))]
		private IEnumerator PlayLaunchSound(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x80DAC8", Offset = "0x80DAC8", VA = "0x80DAC8")]
		public void StopActivationSound()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x80DB48", Offset = "0x80DB48", VA = "0x80DB48")]
		public void PlayLaunchSound()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x80DBD0", Offset = "0x80DBD0", VA = "0x80DBD0")]
		public DelayedActivatorAudioPlayer()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Targets._MiniGame
{
	[Token(Token = "0x200013F")]
	public class CountdownActivator : MonoBehaviour
	{
		[Token(Token = "0x2000140")]
		[CompilerGenerated]
		private sealed class <CountdownActivation>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CountdownActivator <>4__this;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0x80E060", Offset = "0x80E060", VA = "0x80E060", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A7")]
				[Address(RVA = "0x80E0A8", Offset = "0x80E0A8", VA = "0x80E0A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x80DF28", Offset = "0x80DF28", VA = "0x80DF28")]
			[DebuggerHidden]
			public <CountdownActivation>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x80DF60", Offset = "0x80DF60", VA = "0x80DF60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x80DF64", Offset = "0x80DF64", VA = "0x80DF64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x80E068", Offset = "0x80E068", VA = "0x80E068", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicObject[] ToActivate;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CountdownTime;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _time;

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x80DE18", Offset = "0x80DE18", VA = "0x80DE18")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x80DEB0", Offset = "0x80DEB0", VA = "0x80DEB0")]
		[IteratorStateMachine(typeof(<CountdownActivation>d__4))]
		private IEnumerator CountdownActivation(float time)
		{
			return null;
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x80DF50", Offset = "0x80DF50", VA = "0x80DF50")]
		public CountdownActivator()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Audio.Players
{
	[Token(Token = "0x2000141")]
	public class MiscUIAudioPlayer : AudioSourcePool
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioClip[] CoinsSounds;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip[] BowSounds;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip[] ArrowSounds;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip[] IAPSounds;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip[] HomingArrowsSounds;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioClip WinSound;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioClip LoseSound;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioClip TutorialSound0;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioClip TutorialSound1;

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x80E0B0", Offset = "0x80E0B0", VA = "0x80E0B0")]
		public void PlayBowPurchaseSound()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x80E154", Offset = "0x80E154", VA = "0x80E154")]
		public void PlayBowEquipSound()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x80E1B0", Offset = "0x80E1B0", VA = "0x80E1B0")]
		public void PlayArrowPurchaseSound()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x80E254", Offset = "0x80E254", VA = "0x80E254")]
		public void PlayArrowEquipSound()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x80E2B0", Offset = "0x80E2B0", VA = "0x80E2B0")]
		public void PlayIAPPurchaseSound()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x80E30C", Offset = "0x80E30C", VA = "0x80E30C")]
		public void PlayActivateHomingArrow()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x80E368", Offset = "0x80E368", VA = "0x80E368")]
		public void PlayWinLevel()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x80E414", Offset = "0x80E414", VA = "0x80E414")]
		public void PlayLoseLevel()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x80E4C0", Offset = "0x80E4C0", VA = "0x80E4C0")]
		public void PlayTutorialSound(bool show)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x80E4E4", Offset = "0x80E4E4", VA = "0x80E4E4")]
		public MiscUIAudioPlayer()
		{
		}
	}
}
namespace EDKG.ArcheryRange.Audio.AnimationSync
{
	[Token(Token = "0x2000142")]
	public class CharacterAudioPlayer : AudioSourcePool
	{
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource DrawSource;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip[] DrawSnd;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip[] ReleaseSnd;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip[] TakeArrowSnd;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip[] PutArrowSnd;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _lastDrawSnd;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _lastReleaseSnd;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _lastTakeArrowSnd;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _lastPutArrowSnd;

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x80E51C", Offset = "0x80E51C", VA = "0x80E51C")]
		public void PlayDraw()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x80E5E8", Offset = "0x80E5E8", VA = "0x80E5E8")]
		public void StopDraw()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x80E604", Offset = "0x80E604", VA = "0x80E604")]
		public void PlayRelease()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x80E6B0", Offset = "0x80E6B0", VA = "0x80E6B0")]
		public void PlayTakeArrow()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x80E74C", Offset = "0x80E74C", VA = "0x80E74C")]
		public void PlayPutArrow(int id)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x80E7FC", Offset = "0x80E7FC", VA = "0x80E7FC")]
		public CharacterAudioPlayer()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class WeaponAudioPlayer : AudioSourcePool
	{
		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource DrawSource;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioClip[] NockSnd;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip[] DrawSnd;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip[] ReleaseSnd;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip[] CancelSnd;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _lastNockSnd;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _lastDrawSnd;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _lastReleaseSnd;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _lastCancelSnd;

		[Token(Token = "0x4000741")]
		private const float _drawThreshold = 0.35f;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _thresholdPassed;

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x80E804", Offset = "0x80E804", VA = "0x80E804", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x80E96C", Offset = "0x80E96C", VA = "0x80E96C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x80EAC8", Offset = "0x80EAC8", VA = "0x80EAC8")]
		private void OnNockedEvent()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x80EB68", Offset = "0x80EB68", VA = "0x80EB68")]
		private void OnDrawChagingEvent(float amount, float rawAmount)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x80EC98", Offset = "0x80EC98", VA = "0x80EC98")]
		private void OnShootEvent()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x80ED78", Offset = "0x80ED78", VA = "0x80ED78")]
		private void OnCancelEvent()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x80EACC", Offset = "0x80EACC", VA = "0x80EACC")]
		private void PlayNock()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x80EBCC", Offset = "0x80EBCC", VA = "0x80EBCC")]
		private void PlayDraw()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x80ECC0", Offset = "0x80ECC0", VA = "0x80ECC0")]
		private void StopDraw()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x80ECDC", Offset = "0x80ECDC", VA = "0x80ECDC")]
		private void PlayShoot()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x80EDA0", Offset = "0x80EDA0", VA = "0x80EDA0")]
		private void PlayCancel()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x80EE3C", Offset = "0x80EE3C", VA = "0x80EE3C")]
		public WeaponAudioPlayer()
		{
		}
	}
}
namespace EDKG.ArcheryRange.AlertSystem
{
	[Token(Token = "0x2000144")]
	public class CampaignAlert : BaseAlert
	{
		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _shownCampaignAlertId;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _seenCampaignAlertId;

		[Token(Token = "0x170000C1")]
		public int ShownCampaignAlertId
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x80EE44", Offset = "0x80EE44", VA = "0x80EE44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x80EE4C", Offset = "0x80EE4C", VA = "0x80EE4C", Slot = "7")]
		protected override void CheckIfAlertNeeded()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x80EF54", Offset = "0x80EF54", VA = "0x80EF54", Slot = "9")]
		public override void MarkAlertViewed()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x80EF84", Offset = "0x80EF84", VA = "0x80EF84")]
		public CampaignAlert()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class EquipmentAlert : BaseAlert
	{
		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AlertWidget BowsAlert;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AlertWidget ArrowsAlert;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isBowsAlertNeeded;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isArrowsAlertNeeded;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _shownBowAlertId;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _shownArrowAlertId;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _seenBowAlertId;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _seenArrowAlertId;

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x80EF9C", Offset = "0x80EF9C", VA = "0x80EF9C", Slot = "7")]
		protected override void CheckIfAlertNeeded()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x80F294", Offset = "0x80F294", VA = "0x80F294", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x80F338", Offset = "0x80F338", VA = "0x80F338")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x80F3B8", Offset = "0x80F3B8", VA = "0x80F3B8")]
		private void OnPrimaryCurrencyChangedEvent(int value)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x80F3E4", Offset = "0x80F3E4", VA = "0x80F3E4", Slot = "8")]
		protected override void RefreshAlert(bool instant = false)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x80EFD0", Offset = "0x80EFD0", VA = "0x80EFD0")]
		private void CheckBowsAlert()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x80F124", Offset = "0x80F124", VA = "0x80F124")]
		private void CheckArrowsAlert()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x80F544", Offset = "0x80F544", VA = "0x80F544")]
		public void MarkBowsAlertViewed()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x80F574", Offset = "0x80F574", VA = "0x80F574")]
		public void MarkArrowsAlertViewed()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x80F278", Offset = "0x80F278", VA = "0x80F278")]
		private void FinalizeAlertCheck()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x80F5A4", Offset = "0x80F5A4", VA = "0x80F5A4")]
		public EquipmentAlert()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class NewAreaAlert : BaseAlert
	{
		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AlertWidget CampaignAlert;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AlertWidget MiniGameAlert;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isCampaignAlertNeeded;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _isMiniGameAlertNeeded;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _shownCampaignAlertId;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _shownMiniGameAlertId;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _seenCampaignAlertId;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _seenMiniGameAlertId;

		[Token(Token = "0x170000C2")]
		public int ShownCampaignAlertId
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x80F5B8", Offset = "0x80F5B8", VA = "0x80F5B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C3")]
		public int ShownMiniGameAlertId
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x80F5C0", Offset = "0x80F5C0", VA = "0x80F5C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x80F5C8", Offset = "0x80F5C8", VA = "0x80F5C8", Slot = "7")]
		protected override void CheckIfAlertNeeded()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x80F798", Offset = "0x80F798", VA = "0x80F798", Slot = "8")]
		protected override void RefreshAlert(bool instant = false)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x80F5FC", Offset = "0x80F5FC", VA = "0x80F5FC")]
		private void CheckCampaignAlert()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x80F700", Offset = "0x80F700", VA = "0x80F700")]
		private void CheckMiniGameAlert()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x80F880", Offset = "0x80F880", VA = "0x80F880")]
		public void MarkCampaignAlertViewed()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x80F8B0", Offset = "0x80F8B0", VA = "0x80F8B0")]
		public void MarkMiniGameAlertViewed()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x80F77C", Offset = "0x80F77C", VA = "0x80F77C")]
		private void FinalizeAlertCheck()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x80F928", Offset = "0x80F928", VA = "0x80F928")]
		public NewAreaAlert()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class NewMiniGameAlert : BaseAlert
	{
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _shownMiniGameAlertId;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _seenMiniGameAlertId;

		[Token(Token = "0x170000C4")]
		public int ShownMiniGameAlertId
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x80F93C", Offset = "0x80F93C", VA = "0x80F93C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x80F944", Offset = "0x80F944", VA = "0x80F944", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x80F9E0", Offset = "0x80F9E0", VA = "0x80F9E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x80FA60", Offset = "0x80FA60", VA = "0x80FA60", Slot = "7")]
		protected override void CheckIfAlertNeeded()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x80FADC", Offset = "0x80FADC", VA = "0x80FADC", Slot = "9")]
		public override void MarkAlertViewed()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x80FB2C", Offset = "0x80FB2C", VA = "0x80FB2C")]
		private void OnAreaUnlockedEvent(int areaId)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x80FB38", Offset = "0x80FB38", VA = "0x80FB38")]
		public NewMiniGameAlert()
		{
		}
	}
}
namespace DefaultNamespace
{
	[Token(Token = "0x2000148")]
	public class BaseAlert : MonoBehaviour
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AlertWidget NavBarAlert;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool _isNeeded;

		[Token(Token = "0x170000C5")]
		public bool IsNeeded
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x80FB48", Offset = "0x80FB48", VA = "0x80FB48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x80F9D4", Offset = "0x80F9D4", VA = "0x80F9D4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x80FB50", Offset = "0x80FB50", VA = "0x80FB50", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x80F328", Offset = "0x80F328", VA = "0x80F328", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x80EF50", Offset = "0x80EF50", VA = "0x80EF50", Slot = "7")]
		protected virtual void CheckIfAlertNeeded()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x80F4CC", Offset = "0x80F4CC", VA = "0x80F4CC", Slot = "8")]
		protected virtual void RefreshAlert(bool instant = false)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x80EF70", Offset = "0x80EF70", VA = "0x80EF70", Slot = "9")]
		public virtual void MarkAlertViewed()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x80FB5C", Offset = "0x80FB5C", VA = "0x80FB5C", Slot = "10")]
		public virtual void CheckForAlert()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x80EF94", Offset = "0x80EF94", VA = "0x80EF94")]
		public BaseAlert()
		{
		}
	}
	[Token(Token = "0x2000149")]
	public class LevelCounter : MonoBehaviour
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocalizationParamsManager LevelLabel;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform LevelProgressBar;

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x80FB88", Offset = "0x80FB88", VA = "0x80FB88")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x80FC08", Offset = "0x80FC08", VA = "0x80FC08")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x80FCF8", Offset = "0x80FCF8", VA = "0x80FCF8")]
		private void OnTargetListProgressChangedEvent(float percent)
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x80FD94", Offset = "0x80FD94", VA = "0x80FD94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x80FE6C", Offset = "0x80FE6C", VA = "0x80FE6C")]
		public LevelCounter()
		{
		}
	}
	[Token(Token = "0x200014A")]
	public class MiniGameCounter : MonoBehaviour
	{
		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI LevelLabel;

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x80FE74", Offset = "0x80FE74", VA = "0x80FE74")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x80FF1C", Offset = "0x80FF1C", VA = "0x80FF1C")]
		public MiniGameCounter()
		{
		}
	}
}
namespace I2.Loc
{
	[Token(Token = "0x200014B")]
	public static class PersistentStorage
	{
		[Token(Token = "0x200014C")]
		public enum eFileType
		{
			[Token(Token = "0x400075E")]
			Raw,
			[Token(Token = "0x400075F")]
			Persistent,
			[Token(Token = "0x4000760")]
			Temporal,
			[Token(Token = "0x4000761")]
			Streaming
		}

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x80FF24", Offset = "0x80FF24", VA = "0x80FF24")]
		public static void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x80FFE4", Offset = "0x80FFE4", VA = "0x80FFE4")]
		public static string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x81009C", Offset = "0x81009C", VA = "0x81009C")]
		public static void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x810144", Offset = "0x810144", VA = "0x810144")]
		public static bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x8101EC", Offset = "0x8101EC", VA = "0x8101EC")]
		public static void ForceSaveSettings()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x81028C", Offset = "0x81028C", VA = "0x81028C")]
		public static bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x81032C", Offset = "0x81032C", VA = "0x81032C")]
		public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x8103FC", Offset = "0x8103FC", VA = "0x8103FC")]
		public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x8104BC", Offset = "0x8104BC", VA = "0x8104BC")]
		public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x81057C", Offset = "0x81057C", VA = "0x81057C")]
		public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200014D")]
	public abstract class I2BasePersistentStorage
	{
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x810640", Offset = "0x810640", VA = "0x810640", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x8108DC", Offset = "0x8108DC", VA = "0x8108DC", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x810B18", Offset = "0x810B18", VA = "0x810B18", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x810D18", Offset = "0x810D18", VA = "0x810D18", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x810D20", Offset = "0x810D20", VA = "0x810D20", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x810D2C", Offset = "0x810D2C", VA = "0x810D2C", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x810D34", Offset = "0x810D34", VA = "0x810D34")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x810DCC", Offset = "0x810DCC", VA = "0x810DCC", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x810F60", Offset = "0x810F60", VA = "0x810F60", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x8110E8", Offset = "0x8110E8", VA = "0x8110E8", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x811264", Offset = "0x811264", VA = "0x811264", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x8113E0", Offset = "0x8113E0", VA = "0x8113E0")]
		protected I2BasePersistentStorage()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class I2CustomPersistentStorage : I2BasePersistentStorage
	{
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x80FFDC", Offset = "0x80FFDC", VA = "0x80FFDC")]
		public I2CustomPersistentStorage()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class BaseSpecializationManager
	{
		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] mSpecializations;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> mSpecializationsFallbacks;

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x8113E8", Offset = "0x8113E8", VA = "0x8113E8", Slot = "4")]
		public virtual void InitializeSpecializations()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x81186C", Offset = "0x81186C", VA = "0x81186C", Slot = "5")]
		public virtual string GetCurrentSpecialization()
		{
			return null;
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x8118C8", Offset = "0x8118C8", VA = "0x8118C8", Slot = "6")]
		public virtual string GetFallbackSpecialization(string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x811970", Offset = "0x811970", VA = "0x811970")]
		public BaseSpecializationManager()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class SpecializationManager : BaseSpecializationManager
	{
		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x811978", Offset = "0x811978", VA = "0x811978")]
		private SpecializationManager()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x81199C", Offset = "0x81199C", VA = "0x81199C")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x811B88", Offset = "0x811B88", VA = "0x811B88")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x811EA8", Offset = "0x811EA8", VA = "0x811EA8")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x811CA8", Offset = "0x811CA8", VA = "0x811CA8")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
			return null;
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x812268", Offset = "0x812268", VA = "0x812268")]
		public static void AppendSpecializations(string text, [Optional] List<string> list)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000151")]
	public class EventCallback
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonoBehaviour Target;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MethodName;

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x812504", Offset = "0x812504", VA = "0x812504")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x812568", Offset = "0x812568", VA = "0x812568")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x8125EC", Offset = "0x8125EC", VA = "0x8125EC")]
		public EventCallback()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public enum ePluralType
	{
		[Token(Token = "0x4000768")]
		Zero,
		[Token(Token = "0x4000769")]
		One,
		[Token(Token = "0x400076A")]
		Two,
		[Token(Token = "0x400076B")]
		Few,
		[Token(Token = "0x400076C")]
		Many,
		[Token(Token = "0x400076D")]
		Plural
	}
	[Token(Token = "0x2000153")]
	public static class GoogleLanguages
	{
		[Token(Token = "0x2000154")]
		public struct LanguageCodeDef
		{
			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Code;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string GoogleCode;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool HasJoinedWords;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int PluralRule;
		}

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<string, LanguageCodeDef> mLanguageDef;

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x812644", Offset = "0x812644", VA = "0x812644")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x812A48", Offset = "0x812A48", VA = "0x812A48")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			return null;
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x812900", Offset = "0x812900", VA = "0x812900")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default(bool);
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x812FC8", Offset = "0x812FC8", VA = "0x812FC8")]
		public static string GetFormatedLanguageName(string Language)
		{
			return null;
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x813110", Offset = "0x813110", VA = "0x813110")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x8131E0", Offset = "0x8131E0", VA = "0x8131E0")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, [Out] string Language, [Out] string code)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x813338", Offset = "0x813338", VA = "0x813338")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
			return null;
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x813528", Offset = "0x813528", VA = "0x813528")]
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
			return null;
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x813828", Offset = "0x813828", VA = "0x813828")]
		public static List<string> GetAllInternationalCodes()
		{
			return null;
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x813A4C", Offset = "0x813A4C", VA = "0x813A4C")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x813C18", Offset = "0x813C18", VA = "0x813C18")]
		private static int GetPluralRule(string langCode)
		{
			return default(int);
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x813E00", Offset = "0x813E00", VA = "0x813E00")]
		public static bool LanguageHasPluralType(string langCode, string pluralType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x813FB0", Offset = "0x813FB0", VA = "0x813FB0")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
			return default(ePluralType);
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x814650", Offset = "0x814650", VA = "0x814650")]
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
			return default(int);
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x814638", Offset = "0x814638", VA = "0x814638")]
		private static bool inRange(int amount, int min, int max)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000155")]
	public static class GoogleTranslation
	{
		[Token(Token = "0x2000156")]
		public delegate void fnOnTranslated(string Translation, string Error);

		[Token(Token = "0x2000157")]
		public delegate void fnOnTranslationReady(Dictionary<string, TranslationQuery> dict, string error);

		[Token(Token = "0x2000159")]
		[CompilerGenerated]
		private sealed class <WaitForTranslations>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000954")]
				[Address(RVA = "0x81DC40", Offset = "0x81DC40", VA = "0x81DC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000956")]
				[Address(RVA = "0x81DC88", Offset = "0x81DC88", VA = "0x81DC88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0x81BA90", Offset = "0x81BA90", VA = "0x81BA90")]
			[DebuggerHidden]
			public <WaitForTranslations>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x81DAB8", Offset = "0x81DAB8", VA = "0x81DAB8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x81DABC", Offset = "0x81DABC", VA = "0x81DABC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x81DC48", Offset = "0x81DC48", VA = "0x81DC48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<TranslationJob> mTranslationJobs;

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x81A404", Offset = "0x81A404", VA = "0x81A404")]
		public static bool CanTranslate()
		{
			return default(bool);
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x81A63C", Offset = "0x81A63C", VA = "0x81A63C")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, fnOnTranslated OnTranslationReady)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x81ACF0", Offset = "0x81ACF0", VA = "0x81ACF0")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x81AC5C", Offset = "0x81AC5C", VA = "0x81AC5C")]
		public static void Translate(Dictionary<string, TranslationQuery> requests, fnOnTranslationReady OnTranslationReady, bool usePOST = true)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x81B38C", Offset = "0x81B38C", VA = "0x81B38C")]
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x81B408", Offset = "0x81B408", VA = "0x81B408")]
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
			return null;
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x81B278", Offset = "0x81B278", VA = "0x81B278")]
		private static void AddTranslationJob(TranslationJob job)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x81BA30", Offset = "0x81BA30", VA = "0x81BA30")]
		[IteratorStateMachine(typeof(<WaitForTranslations>d__11))]
		private static IEnumerator WaitForTranslations()
		{
			return null;
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x81BAB8", Offset = "0x81BAB8", VA = "0x81BAB8")]
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
			return null;
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x81C1D8", Offset = "0x81C1D8", VA = "0x81C1D8")]
		public static bool IsTranslating()
		{
			return default(bool);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x81C28C", Offset = "0x81C28C", VA = "0x81C28C")]
		public static void CancelCurrentGoogleTranslations()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x81A950", Offset = "0x81A950", VA = "0x81A950")]
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x81C498", Offset = "0x81C498", VA = "0x81C498")]
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x81AE44", Offset = "0x81AE44", VA = "0x81AE44")]
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x81CEF8", Offset = "0x81CEF8", VA = "0x81CEF8")]
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x81BF54", Offset = "0x81BF54", VA = "0x81BF54")]
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
			return default(TranslationQuery);
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x81C6E8", Offset = "0x81C6E8", VA = "0x81C6E8")]
		public static bool HasParameters(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x81C8A4", Offset = "0x81C8A4", VA = "0x81C8A4")]
		public static string GetPluralParameter(string text, bool forceTag)
		{
			return null;
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x81C77C", Offset = "0x81C77C", VA = "0x81C77C")]
		public static string GetPluralText(string text, string pluralType)
		{
			return null;
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x81CFF8", Offset = "0x81CFF8", VA = "0x81CFF8")]
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
			return default(int);
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x81C128", Offset = "0x81C128", VA = "0x81C128")]
		private static string GetGoogleNoTranslateTag(int tagNumber)
		{
			return null;
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x81C988", Offset = "0x81C988", VA = "0x81C988")]
		private static void ParseNonTranslatableElements(TranslationQuery query)
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x81B160", Offset = "0x81B160", VA = "0x81B160")]
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x81D0BC", Offset = "0x81D0BC", VA = "0x81D0BC")]
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x81D374", Offset = "0x81D374", VA = "0x81D374")]
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x81D6DC", Offset = "0x81D6DC", VA = "0x81D6DC")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x81B97C", Offset = "0x81B97C", VA = "0x81B97C")]
		public static string TitleCase(string s)
		{
			return null;
		}
	}
	[Token(Token = "0x200015A")]
	public struct TranslationQuery
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OrigText;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Text;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string LanguageCode;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] TargetLanguagesCode;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] Results;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Tags;
	}
	[Token(Token = "0x200015B")]
	public class TranslationJob : IDisposable
	{
		[Token(Token = "0x200015C")]
		public enum eJobState
		{
			[Token(Token = "0x4000783")]
			Running,
			[Token(Token = "0x4000784")]
			Succeeded,
			[Token(Token = "0x4000785")]
			Failed
		}

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public eJobState mJobState;

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x81DC90", Offset = "0x81DC90", VA = "0x81DC90", Slot = "5")]
		public virtual eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x81DC98", Offset = "0x81DC98", VA = "0x81DC98", Slot = "6")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x81DC9C", Offset = "0x81DC9C", VA = "0x81DC9C")]
		public TranslationJob()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class TranslationJob_WWW : TranslationJob
	{
		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityWebRequest www;

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x81DCA4", Offset = "0x81DCA4", VA = "0x81DCA4", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x81DCC8", Offset = "0x81DCC8", VA = "0x81DCC8")]
		public TranslationJob_WWW()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class TranslationJob_GET : TranslationJob_WWW
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> mQueries;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mErrorMessage;

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x81DCD0", Offset = "0x81DCD0", VA = "0x81DCD0")]
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x81DD5C", Offset = "0x81DD5C", VA = "0x81DD5C")]
		private void ExecuteNextQuery()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x81DE84", Offset = "0x81DE84", VA = "0x81DE84", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x81DF24", Offset = "0x81DF24", VA = "0x81DF24")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class TranslationJob_Main : TranslationJob
	{
		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TranslationJob_WEB mWeb;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TranslationJob_POST mPost;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TranslationJob_GET mGet;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mErrorMessage;

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x81B0DC", Offset = "0x81B0DC", VA = "0x81B0DC")]
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x81E1A0", Offset = "0x81E1A0", VA = "0x81E1A0", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x81E35C", Offset = "0x81E35C", VA = "0x81E35C", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class TranslationJob_POST : TranslationJob_WWW
	{
		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x81E020", Offset = "0x81E020", VA = "0x81E020")]
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x81E3A4", Offset = "0x81E3A4", VA = "0x81E3A4", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x81E430", Offset = "0x81E430", VA = "0x81E430")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mErrorMessage;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string mCurrentBatch_ToLanguageCode;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mCurrentBatch_FromLanguageCode;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> mCurrentBatch_Text;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<KeyValuePair<string, string>> mQueries;

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x81E518", Offset = "0x81E518", VA = "0x81E518")]
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x81E550", Offset = "0x81E550", VA = "0x81E550")]
		private void FindAllQueries()
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x81E918", Offset = "0x81E918", VA = "0x81E918")]
		private void ExecuteNextBatch()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x81ECA0", Offset = "0x81ECA0", VA = "0x81ECA0", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x81ED40", Offset = "0x81ED40", VA = "0x81ED40")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x81EE58", Offset = "0x81EE58", VA = "0x81EE58")]
		private string ParseTranslationResult(string html, string OriginalText)
		{
			return null;
		}
	}
	[Token(Token = "0x2000163")]
	public enum eLanguageDataFlags
	{
		[Token(Token = "0x400079F")]
		DISABLED = 1,
		[Token(Token = "0x40007A0")]
		KEEP_LOADED = 2,
		[Token(Token = "0x40007A1")]
		NOT_LOADED = 4
	}
	[Serializable]
	[Token(Token = "0x2000164")]
	public class LanguageData
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Code;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte Flags;

		[NonSerialized]
		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Compressed;

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x81F520", Offset = "0x81F520", VA = "0x81F520")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x81F530", Offset = "0x81F530", VA = "0x81F530")]
		public void SetEnabled(bool bEnabled)
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x81F54C", Offset = "0x81F54C", VA = "0x81F54C")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x81F55C", Offset = "0x81F55C", VA = "0x81F55C")]
		public bool CanBeUnloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x81F56C", Offset = "0x81F56C", VA = "0x81F56C")]
		public void SetLoaded(bool loaded)
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x81F588", Offset = "0x81F588", VA = "0x81F588")]
		public void SetCanBeUnLoaded(bool allowUnloading)
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x81F5A4", Offset = "0x81F5A4", VA = "0x81F5A4")]
		public LanguageData()
		{
		}
	}
	[Token(Token = "0x2000165")]
	[AddComponentMenu("I2/Localization/Source")]
	[ExecuteInEditMode]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		[Token(Token = "0x2000166")]
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int version;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool NeverDestroy;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool GoogleLiveSyncIsUptoDate;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<UnityEngine.Object> Assets;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Google_WebServiceURL;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<TermData> mTerms;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool CaseInsensitiveTerms;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string mTerm_AppName;

		[Token(Token = "0x170000C8")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x81F5AC", Offset = "0x81F5AC", VA = "0x81F5AC", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x81F5B4", Offset = "0x81F5B4", VA = "0x81F5B4", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x81F5BC", Offset = "0x81F5BC", VA = "0x81F5BC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x81F658", Offset = "0x81F658", VA = "0x81F658")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x81F6F4", Offset = "0x81F6F4", VA = "0x81F6F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x81F784", Offset = "0x81F784", VA = "0x81F784")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x81F7F8", Offset = "0x81F7F8", VA = "0x81F7F8")]
		public string GetSourceName()
		{
			return null;
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x81F8E8", Offset = "0x81F8E8", VA = "0x81F8E8", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x81F8F4", Offset = "0x81F8F4", VA = "0x81F8F4", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x81FF98", Offset = "0x81FF98", VA = "0x81FF98")]
		public LanguageSource()
		{
		}
	}
	[Token(Token = "0x2000167")]
	[CreateAssetMenu(fileName = "I2Languages", menuName = "I2 Localization/LanguageSource", order = 1)]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x170000C9")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x820294", Offset = "0x820294", VA = "0x820294", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x82029C", Offset = "0x82029C", VA = "0x82029C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x8202A4", Offset = "0x8202A4", VA = "0x8202A4")]
		public LanguageSourceAsset()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public interface ILanguageSource
	{
		[Token(Token = "0x170000CA")]
		LanguageSourceData SourceData
		{
			[Token(Token = "0x6000989")]
			get;
			[Token(Token = "0x600098A")]
			set;
		}
	}
	[Serializable]
	[Token(Token = "0x2000169")]
	[ExecuteInEditMode]
	public class LanguageSourceData
	{
		[Token(Token = "0x200016A")]
		public enum MissingTranslationAction
		{
			[Token(Token = "0x40007D8")]
			Empty,
			[Token(Token = "0x40007D9")]
			Fallback,
			[Token(Token = "0x40007DA")]
			ShowWarning,
			[Token(Token = "0x40007DB")]
			ShowTerm
		}

		[Token(Token = "0x200016B")]
		public enum eAllowUnloadLanguages
		{
			[Token(Token = "0x40007DD")]
			Never,
			[Token(Token = "0x40007DE")]
			OnlyInDevice,
			[Token(Token = "0x40007DF")]
			EditorAndDevice
		}

		[Token(Token = "0x200016C")]
		public enum eGoogleUpdateFrequency
		{
			[Token(Token = "0x40007E1")]
			Always,
			[Token(Token = "0x40007E2")]
			Never,
			[Token(Token = "0x40007E3")]
			Daily,
			[Token(Token = "0x40007E4")]
			Weekly,
			[Token(Token = "0x40007E5")]
			Monthly,
			[Token(Token = "0x40007E6")]
			OnlyOnce,
			[Token(Token = "0x40007E7")]
			EveryOtherDay
		}

		[Token(Token = "0x200016D")]
		public enum eGoogleUpdateSynchronization
		{
			[Token(Token = "0x40007E9")]
			Manual,
			[Token(Token = "0x40007EA")]
			OnSceneLoaded,
			[Token(Token = "0x40007EB")]
			AsSoonAsDownloaded
		}

		[Token(Token = "0x200016F")]
		[CompilerGenerated]
		private sealed class <Import_Google_Coroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LanguageSourceData <>4__this;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool JustCheck;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000CC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009E5")]
				[Address(RVA = "0x828940", Offset = "0x828940", VA = "0x828940", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E7")]
				[Address(RVA = "0x828988", Offset = "0x828988", VA = "0x828988", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x8260F0", Offset = "0x8260F0", VA = "0x8260F0")]
			[DebuggerHidden]
			public <Import_Google_Coroutine>d__65(int <>1__state)
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x828684", Offset = "0x828684", VA = "0x828684", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x828688", Offset = "0x828688", VA = "0x828688", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x828948", Offset = "0x828948", VA = "0x828948", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILanguageSource owner;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GoogleLiveSyncIsUptoDate;

		[NonSerialized]
		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool mIsGlobalSource;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TermData> mTerms;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool CaseInsensitiveTerms;

		[NonSerialized]
		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, TermData> mDictionary;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mTerm_AppName;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Google_WebServiceURL;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<UnityEngine.Object> Assets;

		[NonSerialized]
		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string mDelayedGoogleData;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static char[] CategorySeparators;

		[Token(Token = "0x170000CB")]
		public UnityEngine.Object ownerObject
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x820308", Offset = "0x820308", VA = "0x820308")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400001B")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x81FEFC", Offset = "0x81FEFC", VA = "0x81FEFC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x820384", Offset = "0x820384", VA = "0x820384")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x81F714", Offset = "0x81F714", VA = "0x81F714")]
		public void Awake()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x81F7A4", Offset = "0x81F7A4", VA = "0x81F7A4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x820DF0", Offset = "0x820DF0", VA = "0x820DF0")]
		public bool IsEqualTo(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x821358", Offset = "0x821358", VA = "0x821358")]
		internal bool ManagerHasASimilarSource()
		{
			return default(bool);
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x821460", Offset = "0x821460", VA = "0x821460")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x821544", Offset = "0x821544", VA = "0x821544")]
		public bool IsGlobalSource()
		{
			return default(bool);
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x82154C", Offset = "0x82154C", VA = "0x82154C")]
		public void Editor_SetDirty()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x820968", Offset = "0x820968", VA = "0x820968")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x821550", Offset = "0x821550", VA = "0x821550")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x821624", Offset = "0x821624", VA = "0x821624")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x82167C", Offset = "0x82167C", VA = "0x82167C")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x82175C", Offset = "0x82175C", VA = "0x82175C")]
		public string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x821E8C", Offset = "0x821E8C", VA = "0x821E8C")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x8220E8", Offset = "0x8220E8", VA = "0x8220E8")]
		private static void AppendI2Text(StringBuilder Builder, string text)
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x8221B4", Offset = "0x8221B4", VA = "0x8221B4")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x8226BC", Offset = "0x8226BC", VA = "0x8226BC")]
		public string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x823000", Offset = "0x823000", VA = "0x823000")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x822E9C", Offset = "0x822E9C", VA = "0x822E9C")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x823260", Offset = "0x823260", VA = "0x823260")]
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x8233DC", Offset = "0x8233DC", VA = "0x8233DC")]
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x8235A0", Offset = "0x8235A0", VA = "0x8235A0")]
		private string Export_Google_CreateData()
		{
			return null;
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x823A7C", Offset = "0x823A7C", VA = "0x823A7C")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x824774", Offset = "0x824774", VA = "0x824774")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x823BDC", Offset = "0x823BDC", VA = "0x823BDC")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x8249BC", Offset = "0x8249BC", VA = "0x8249BC")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x824D34", Offset = "0x824D34", VA = "0x824D34")]
		public static eTermType GetTermType(string type)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x824F7C", Offset = "0x824F7C", VA = "0x824F7C")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x8251A0", Offset = "0x8251A0", VA = "0x8251A0")]
		public static void FreeUnusedLanguages()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x825344", Offset = "0x825344", VA = "0x825344")]
		public void Import_Google_FromCache()
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x825758", Offset = "0x825758", VA = "0x825758")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x825E04", Offset = "0x825E04", VA = "0x825E04")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x825598", Offset = "0x825598", VA = "0x825598")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x826074", Offset = "0x826074", VA = "0x826074")]
		[IteratorStateMachine(typeof(<Import_Google_Coroutine>d__65))]
		private IEnumerator Import_Google_Coroutine(bool JustCheck)
		{
			return null;
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x826118", Offset = "0x826118", VA = "0x826118")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x8261C4", Offset = "0x8261C4", VA = "0x8261C4")]
		public void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x826324", Offset = "0x826324", VA = "0x826324")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x82648C", Offset = "0x82648C", VA = "0x82648C")]
		public bool HasGoogleSpreadsheet()
		{
			return default(bool);
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x8257E8", Offset = "0x8257E8", VA = "0x8257E8")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x820F50", Offset = "0x820F50", VA = "0x820F50")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return default(int);
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x8266E0", Offset = "0x8266E0", VA = "0x8266E0")]
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
			return null;
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x826770", Offset = "0x826770", VA = "0x826770")]
		public bool IsCurrentLanguage(int languageIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x824A4C", Offset = "0x824A4C", VA = "0x824A4C")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return default(int);
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x826524", Offset = "0x826524", VA = "0x826524")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return default(int);
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x826814", Offset = "0x826814", VA = "0x826814")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x8268A0", Offset = "0x8268A0", VA = "0x8268A0")]
		public static string GetLanguageWithoutRegion(string Language)
		{
			return null;
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x826938", Offset = "0x826938", VA = "0x826938")]
		public void AddLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x8269B0", Offset = "0x8269B0", VA = "0x8269B0")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x826B84", Offset = "0x826B84", VA = "0x826B84")]
		public void RemoveLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x826E4C", Offset = "0x826E4C", VA = "0x826E4C")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x826FC0", Offset = "0x826FC0", VA = "0x826FC0")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x8271B0", Offset = "0x8271B0", VA = "0x8271B0")]
		public bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x82723C", Offset = "0x82723C", VA = "0x82723C")]
		public void EnableLanguage(string Language, bool bEnabled)
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x8272D8", Offset = "0x8272D8", VA = "0x8272D8")]
		public bool AllowUnloadingLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x8272E8", Offset = "0x8272E8", VA = "0x8272E8")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x8274C4", Offset = "0x8274C4", VA = "0x8274C4")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x827888", Offset = "0x827888", VA = "0x827888")]
		public void LoadAllLanguages(bool forceLoad = false)
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x827628", Offset = "0x827628", VA = "0x827628")]
		public void UnloadLanguage(int languageIndex)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x824E64", Offset = "0x824E64", VA = "0x824E64")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x824DCC", Offset = "0x824DCC", VA = "0x824DCC")]
		public bool HasUnloadedLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x8237B8", Offset = "0x8237B8", VA = "0x8237B8")]
		public List<string> GetCategories(bool OnlyMainCategory = false, [Optional] List<string> Categories)
		{
			return null;
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x8279D4", Offset = "0x8279D4", VA = "0x8279D4")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x82790C", Offset = "0x82790C", VA = "0x82790C")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x827A80", Offset = "0x827A80", VA = "0x827A80")]
		public static void DeserializeFullTerm(string FullTerm, [Out] string Key, [Out] string Category, bool OnlyMainCategory = false)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x820670", Offset = "0x820670", VA = "0x820670")]
		public void UpdateDictionary(bool force = false)
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x827B74", Offset = "0x827B74", VA = "0x827B74")]
		public string GetTranslation(string term, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x827C18", Offset = "0x827C18", VA = "0x827C18")]
		public bool TryGetTranslation(string term, [Out] string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x822464", Offset = "0x822464", VA = "0x822464")]
		private bool TryGetFallbackTranslation(TermData termData, [Out] string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x827E34", Offset = "0x827E34", VA = "0x827E34")]
		public TermData AddTerm(string term)
		{
			return null;
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x821100", Offset = "0x821100", VA = "0x821100")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x82805C", Offset = "0x82805C", VA = "0x82805C")]
		public bool ContainsTerm(string term)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x828078", Offset = "0x828078", VA = "0x828078")]
		public List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x827E40", Offset = "0x827E40", VA = "0x827E40")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x8282C4", Offset = "0x8282C4", VA = "0x8282C4")]
		public void RemoveTerm(string term)
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x824BC0", Offset = "0x824BC0", VA = "0x824BC0")]
		public static void ValidateFullTerm(string Term)
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x81FCA0", Offset = "0x81FCA0", VA = "0x81FCA0")]
		public LanguageSourceData()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public enum eSpreadsheetUpdateMode
	{
		[Token(Token = "0x40007F9")]
		None,
		[Token(Token = "0x40007FA")]
		Replace,
		[Token(Token = "0x40007FB")]
		Merge,
		[Token(Token = "0x40007FC")]
		AddNewTerms
	}
	[Token(Token = "0x2000171")]
	public class LocalizationReader
	{
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x828990", Offset = "0x828990", VA = "0x828990")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			return null;
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x828C10", Offset = "0x828C10", VA = "0x828C10")]
		public static bool TextAsset_ReadLine(string line, [Out] string key, [Out] string value, [Out] string category, [Out] string comment, [Out] string termType)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x828FE8", Offset = "0x828FE8", VA = "0x828FE8")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x823AB8", Offset = "0x823AB8", VA = "0x823AB8")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x829208", Offset = "0x829208", VA = "0x829208")]
		private static string[] ParseCSVline(string Line, int iStart, char Separator)
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x8293F4", Offset = "0x8293F4", VA = "0x8293F4")]
		private static void AddCSVtoken(List<string> list, string Line, int iEnd, int iWordStart)
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x8247AC", Offset = "0x8247AC", VA = "0x8247AC")]
		public static List<string[]> ReadI2CSV(string Text)
		{
			return null;
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x828F5C", Offset = "0x828F5C", VA = "0x828F5C")]
		public static void ValidateFullTerm(string Term)
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x829578", Offset = "0x829578", VA = "0x829578")]
		public static string EncodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x828EB4", Offset = "0x828EB4", VA = "0x828EB4")]
		public static string DecodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x829670", Offset = "0x829670", VA = "0x829670")]
		public LocalizationReader()
		{
		}
	}
	[Token(Token = "0x2000172")]
	[AddComponentMenu("I2/Localization/I2 Localize")]
	public class Localize : MonoBehaviour
	{
		[Token(Token = "0x2000173")]
		public enum TermModification
		{
			[Token(Token = "0x400081D")]
			DontModify,
			[Token(Token = "0x400081E")]
			ToUpper,
			[Token(Token = "0x400081F")]
			ToLower,
			[Token(Token = "0x4000820")]
			ToUpperFirst,
			[Token(Token = "0x4000821")]
			ToTitle
		}

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mTerm;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mTermSecondary;

		[NonSerialized]
		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string FinalTerm;

		[NonSerialized]
		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string FinalSecondaryTerm;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TermModification PrimaryTermModifier;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public TermModification SecondaryTermModifier;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string TermPrefix;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string TermSuffix;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool LocalizeOnAwake;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string LastLocalizedLanguage;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool IgnoreRTL;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int MaxCharactersInRTL;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreNumbersInRTL;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool CorrectAlignmentForRTL;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool AddSpacesToJoinedLanguages;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool AllowLocalizedParameters;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<UnityEngine.Object> TranslatedObjects;

		[NonSerialized]
		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent LocalizeEvent;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string SecondaryTranslation;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string CallBackTerm;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string CallBackSecondaryTerm;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Localize CurrentLocalizeComponent;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool AlwaysForceLocalize;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool mGUI_ShowReferences;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool mGUI_ShowTems;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		public bool mGUI_ShowCallback;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public ILocalizeTarget mLocalizeTarget;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string mLocalizeTargetName;

		[Token(Token = "0x170000CE")]
		public string Term
		{
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x829678", Offset = "0x829678", VA = "0x829678")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x829680", Offset = "0x829680", VA = "0x829680")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public string SecondaryTerm
		{
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x8296C0", Offset = "0x8296C0", VA = "0x8296C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x8296C8", Offset = "0x8296C8", VA = "0x8296C8")]
			set
			{
			}
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x82971C", Offset = "0x82971C", VA = "0x82971C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x82A724", Offset = "0x82A724", VA = "0x82A724")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x82A72C", Offset = "0x82A72C", VA = "0x82A72C")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x829F0C", Offset = "0x829F0C", VA = "0x829F0C")]
		public void OnLocalize(bool Force = false)
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x829A8C", Offset = "0x829A8C", VA = "0x829A8C")]
		public bool FindTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x82A774", Offset = "0x82A774", VA = "0x82A774")]
		public void GetFinalTerms([Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x82AF1C", Offset = "0x82AF1C", VA = "0x82AF1C")]
		public string GetMainTargetsText()
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x82AFE4", Offset = "0x82AFE4", VA = "0x82AFE4")]
		public void SetFinalTerms(string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm, bool RemoveNonASCII)
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x829684", Offset = "0x829684", VA = "0x829684")]
		public void SetTerm(string primary)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x8296D4", Offset = "0x8296D4", VA = "0x8296D4")]
		public void SetTerm(string primary, string secondary)
		{
		}

		[Token(Token = "0x6000A01")]
		internal T GetSecondaryTranslatedObj<T>(string mainTranslation, string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x829750", Offset = "0x829750", VA = "0x829750")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x6000A03")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000A04")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x82B020", Offset = "0x82B020", VA = "0x82B020")]
		private void DeserializeTranslation(string translation, [Out] string value, [Out] string secondary)
		{
		}

		[Token(Token = "0x6000A06")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x82B10C", Offset = "0x82B10C", VA = "0x82B10C")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x82B190", Offset = "0x82B190", VA = "0x82B190")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x82B270", Offset = "0x82B270", VA = "0x82B270")]
		public void SetGlobalLanguage(string Language)
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x82B394", Offset = "0x82B394", VA = "0x82B394")]
		public Localize()
		{
		}
	}
	[Token(Token = "0x2000175")]
	[AddComponentMenu("I2/Localization/Localize Dropdown")]
	public class LocalizeDropdown : MonoBehaviour
	{
		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> _Terms;

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x82B724", Offset = "0x82B724", VA = "0x82B724")]
		public void Start()
		{
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x82BA1C", Offset = "0x82BA1C", VA = "0x82BA1C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x82BB94", Offset = "0x82BB94", VA = "0x82BB94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x82B930", Offset = "0x82B930", VA = "0x82B930")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x82BBEC", Offset = "0x82BBEC", VA = "0x82BBEC")]
		private void FillValues()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x82BE4C", Offset = "0x82BE4C", VA = "0x82BE4C")]
		public void UpdateLocalization()
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x82C3BC", Offset = "0x82C3BC", VA = "0x82C3BC")]
		public void UpdateLocalizationTMPro()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x82C174", Offset = "0x82C174", VA = "0x82C174")]
		private void FillValuesTMPro()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x82C6D8", Offset = "0x82C6D8", VA = "0x82C6D8")]
		public LocalizeDropdown()
		{
		}
	}
	[Token(Token = "0x2000176")]
	public static class LocalizationManager
	{
		[Token(Token = "0x2000177")]
		public delegate object _GetParam(string param);

		[Token(Token = "0x2000178")]
		public delegate void OnLocalizeCallback();

		[Token(Token = "0x200017E")]
		[CompilerGenerated]
		private sealed class <Delayed_Import_Google>d__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LanguageSourceData source;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool justCheck;

			[Token(Token = "0x170000D5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A74")]
				[Address(RVA = "0x832B58", Offset = "0x832B58", VA = "0x832B58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A76")]
				[Address(RVA = "0x832BA0", Offset = "0x832BA0", VA = "0x832BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x832A74", Offset = "0x832A74", VA = "0x832A74")]
			[DebuggerHidden]
			public <Delayed_Import_Google>d__59(int <>1__state)
			{
			}

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x832A9C", Offset = "0x832A9C", VA = "0x832A9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x832AA0", Offset = "0x832AA0", VA = "0x832AA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x832B60", Offset = "0x832B60", VA = "0x832B60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000180")]
		[CompilerGenerated]
		private sealed class <Coroutine_LocalizeAll>d__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A7C")]
				[Address(RVA = "0x832CBC", Offset = "0x832CBC", VA = "0x832CBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A7E")]
				[Address(RVA = "0x832D04", Offset = "0x832D04", VA = "0x832D04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x832BD8", Offset = "0x832BD8", VA = "0x832BD8")]
			[DebuggerHidden]
			public <Coroutine_LocalizeAll>d__84(int <>1__state)
			{
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x832C00", Offset = "0x832C00", VA = "0x832C00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x832C04", Offset = "0x832C04", VA = "0x832C04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x832CC4", Offset = "0x832CC4", VA = "0x832CC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string mLanguageCode;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CultureInfo mCurrentCulture;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool mChangeCultureInfo;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public static bool IsRight2Left;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public static bool HasJoinedWords;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static List<ILocalizationParamsManager> ParamManagers;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string[] LanguagesRTL;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static List<LanguageSourceData> Sources;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] GlobalSources;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string mCurrentDeviceLanguage;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static bool mLocalizeIsScheduled;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public static bool HighlightLocalizedTargets;

		[Token(Token = "0x170000D0")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x8252E8", Offset = "0x8252E8", VA = "0x8252E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x82B2C4", Offset = "0x82B2C4", VA = "0x82B2C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x82D4AC", Offset = "0x82D4AC", VA = "0x82D4AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x82D508", Offset = "0x82D508", VA = "0x82D508")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public static string CurrentRegion
		{
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x82D798", Offset = "0x82D798", VA = "0x82D798")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x82D90C", Offset = "0x82D90C", VA = "0x82D90C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x82DACC", Offset = "0x82DACC", VA = "0x82DACC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x82DB9C", Offset = "0x82DB9C", VA = "0x82DB9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x82DCA0", Offset = "0x82DCA0", VA = "0x82DCA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400001C")]
		public static event OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x82B854", Offset = "0x82B854", VA = "0x82B854")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x82BAB8", Offset = "0x82BAB8", VA = "0x82BAB8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x81A88C", Offset = "0x81A88C", VA = "0x81A88C")]
		public static void InitializeIfNeeded()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x82CD80", Offset = "0x82CD80", VA = "0x82CD80")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x82651C", Offset = "0x82651C", VA = "0x82651C")]
		public static int GetRequiredWebServiceVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x81A4A8", Offset = "0x81A4A8", VA = "0x81A4A8")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
			return null;
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x82D2D4", Offset = "0x82D2D4", VA = "0x82D2D4")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x82DCF8", Offset = "0x82DCF8", VA = "0x82DCF8")]
		private static CultureInfo CreateCultureForCode(string code)
		{
			return null;
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x82DEE8", Offset = "0x82DEE8", VA = "0x82DEE8")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x82DDEC", Offset = "0x82DDEC", VA = "0x82DDEC")]
		private static void SetCurrentCultureInfo()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x82C9AC", Offset = "0x82C9AC", VA = "0x82C9AC")]
		private static void SelectStartupLanguage()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x82E018", Offset = "0x82E018", VA = "0x82E018")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x82CDC0", Offset = "0x82CDC0", VA = "0x82CDC0")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			return null;
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x82D11C", Offset = "0x82D11C", VA = "0x82D11C")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x82D5D0", Offset = "0x82D5D0", VA = "0x82D5D0")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			return null;
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x82E1D0", Offset = "0x82E1D0", VA = "0x82E1D0")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x82E428", Offset = "0x82E428", VA = "0x82E428")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x82E654", Offset = "0x82E654", VA = "0x82E654")]
		public static bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x82E748", Offset = "0x82E748", VA = "0x82E748")]
		private static void LoadCurrentLanguage()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x82E870", Offset = "0x82E870", VA = "0x82E870")]
		public static void PreviewLanguage(string NewLanguage)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x82C754", Offset = "0x82C754", VA = "0x82C754")]
		public static void AutoLoadGlobalParamManagers()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x82E940", Offset = "0x82E940", VA = "0x82E940")]
		public static void ApplyLocalizationParams(string translation, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x82A974", Offset = "0x82A974", VA = "0x82A974")]
		public static void ApplyLocalizationParams(string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x82EEF8", Offset = "0x82EEF8", VA = "0x82EEF8")]
		public static void ApplyLocalizationParams(string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x82EAF8", Offset = "0x82EAF8", VA = "0x82EAF8")]
		public static void ApplyLocalizationParams(string translation, _GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x82F11C", Offset = "0x82F11C", VA = "0x82F11C")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
			return null;
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x82F3AC", Offset = "0x82F3AC", VA = "0x82F3AC")]
		private static string GetPluralType(MatchCollection matches, string langCode, _GetParam getParam)
		{
			return null;
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x82AEC0", Offset = "0x82AEC0", VA = "0x82AEC0")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x82AA58", Offset = "0x82AA58", VA = "0x82AA58")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x82F570", Offset = "0x82F570", VA = "0x82F570")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			return null;
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x82DE64", Offset = "0x82DE64", VA = "0x82DE64")]
		public static bool IsRTL(string Code)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x82C928", Offset = "0x82C928", VA = "0x82C928")]
		public static bool UpdateSources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x82F60C", Offset = "0x82F60C", VA = "0x82F60C")]
		private static void UnregisterDeletededSources()
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x82F8B0", Offset = "0x82F8B0", VA = "0x82F8B0")]
		private static void RegisterSceneSources()
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x82F714", Offset = "0x82F714", VA = "0x82F714")]
		private static void RegisterSourceInResources()
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x820420", Offset = "0x820420", VA = "0x820420")]
		internal static void AddSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x82FA34", Offset = "0x82FA34", VA = "0x82FA34")]
		[IteratorStateMachine(typeof(<Delayed_Import_Google>d__59))]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x820D70", Offset = "0x820D70", VA = "0x820D70")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x82FAC0", Offset = "0x82FAC0", VA = "0x82FAC0")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x82FB44", Offset = "0x82FB44", VA = "0x82FB44")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x82FCE8", Offset = "0x82FCE8", VA = "0x82FCE8")]
		public static UnityEngine.Object FindAsset(string value)
		{
			return null;
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x82FE18", Offset = "0x82FE18", VA = "0x82FE18")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x82DF7C", Offset = "0x82DF7C", VA = "0x82DF7C")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
			return null;
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x82FEF4", Offset = "0x82FEF4", VA = "0x82FEF4")]
		private static void DetectDeviceLanguage()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x83032C", Offset = "0x83032C", VA = "0x83032C")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x82A8C0", Offset = "0x82A8C0", VA = "0x82A8C0")]
		public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x830788", Offset = "0x830788", VA = "0x830788")]
		public static string GetTermTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x8305B8", Offset = "0x8305B8", VA = "0x8305B8")]
		public static bool TryGetTranslation(string Term, [Out] string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A53")]
		public static T GetTranslatedObject<T>(string AssetName, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000A54")]
		public static T GetTranslatedObjectByTermName<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x830824", Offset = "0x830824", VA = "0x830824")]
		public static string GetAppName(string languageCode)
		{
			return null;
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x820CA4", Offset = "0x820CA4", VA = "0x820CA4")]
		public static void LocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x830B8C", Offset = "0x830B8C", VA = "0x830B8C")]
		[IteratorStateMachine(typeof(<Coroutine_LocalizeAll>d__84))]
		private static IEnumerator Coroutine_LocalizeAll()
		{
			return null;
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x830A14", Offset = "0x830A14", VA = "0x830A14")]
		private static void DoLocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x830BEC", Offset = "0x830BEC", VA = "0x830BEC")]
		public static List<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x830D14", Offset = "0x830D14", VA = "0x830D14")]
		public static List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x830F58", Offset = "0x830F58", VA = "0x830F58")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x82EFDC", Offset = "0x82EFDC", VA = "0x82EFDC")]
		public static TermData GetTermData(string term, [Out] LanguageSourceData source)
		{
			return null;
		}
	}
	[Token(Token = "0x2000181")]
	public abstract class ILocalizeTarget : ScriptableObject
	{
		[Token(Token = "0x6000A7F")]
		public abstract bool IsValid(Localize cmp);

		[Token(Token = "0x6000A80")]
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm);

		[Token(Token = "0x6000A81")]
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		[Token(Token = "0x6000A82")]
		public abstract bool CanUseSecondaryTerm();

		[Token(Token = "0x6000A83")]
		public abstract bool AllowMainTermToBeRTL();

		[Token(Token = "0x6000A84")]
		public abstract bool AllowSecondTermToBeRTL();

		[Token(Token = "0x6000A85")]
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		[Token(Token = "0x6000A86")]
		public abstract eTermType GetSecondaryTermType(Localize cmp);

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x832D0C", Offset = "0x832D0C", VA = "0x832D0C")]
		protected ILocalizeTarget()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : UnityEngine.Object
	{
		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T mTarget;

		[Token(Token = "0x6000A88")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A89")]
		protected LocalizeTarget()
		{
		}
	}
	[Token(Token = "0x2000183")]
	public abstract class ILocalizeTargetDescriptor
	{
		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x6000A8A")]
		public abstract bool CanLocalize(Localize cmp);

		[Token(Token = "0x6000A8B")]
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		[Token(Token = "0x6000A8C")]
		public abstract Type GetTargetType();

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x832D14", Offset = "0x832D14", VA = "0x832D14")]
		protected ILocalizeTargetDescriptor()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		[Token(Token = "0x6000A8E")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6000A8F")]
		public override Type GetTargetType()
		{
			return null;
		}

		[Token(Token = "0x6000A90")]
		protected LocalizeTargetDesc()
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : UnityEngine.Object where G : LocalizeTarget<T>
	{
		[Token(Token = "0x6000A91")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A92")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6000A93")]
		public LocalizeTargetDesc_Type()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x832D1C", Offset = "0x832D1C", VA = "0x832D1C")]
		static LocalizeTarget_TextMeshPro_Label()
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x832D20", Offset = "0x832D20", VA = "0x832D20")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x832DDC", Offset = "0x832DDC", VA = "0x832DDC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x832DE4", Offset = "0x832DE4", VA = "0x832DE4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x832DEC", Offset = "0x832DEC", VA = "0x832DEC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x832DF4", Offset = "0x832DF4", VA = "0x832DF4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x832DFC", Offset = "0x832DFC", VA = "0x832DFC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x832E04", Offset = "0x832E04", VA = "0x832E04", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x832F10", Offset = "0x832F10", VA = "0x832F10", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x8334A4", Offset = "0x8334A4", VA = "0x8334A4")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			return null;
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x83370C", Offset = "0x83370C", VA = "0x83370C")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, [Out] TextAlignmentOptions alignLTR, [Out] TextAlignmentOptions alignRTL)
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x8333C4", Offset = "0x8333C4", VA = "0x8333C4")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x83360C", Offset = "0x83360C", VA = "0x83360C")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x8339B0", Offset = "0x8339B0", VA = "0x8339B0")]
		public LocalizeTarget_TextMeshPro_Label()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool mAlignmentWasRTL;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool mInitializeAlignment;

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x833A0C", Offset = "0x833A0C", VA = "0x833A0C")]
		static LocalizeTarget_TextMeshPro_UGUI()
		{
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x833A10", Offset = "0x833A10", VA = "0x833A10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x833ACC", Offset = "0x833ACC", VA = "0x833ACC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x833AD4", Offset = "0x833AD4", VA = "0x833AD4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x833ADC", Offset = "0x833ADC", VA = "0x833ADC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x833AE4", Offset = "0x833AE4", VA = "0x833AE4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x833AEC", Offset = "0x833AEC", VA = "0x833AEC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x833AF4", Offset = "0x833AF4", VA = "0x833AF4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x833C00", Offset = "0x833C00", VA = "0x833C00", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x8340B4", Offset = "0x8340B4", VA = "0x8340B4")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x834110", Offset = "0x834110", VA = "0x834110")]
		static LocalizeTarget_UnityStandard_AudioSource()
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x834114", Offset = "0x834114", VA = "0x834114")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x8341D0", Offset = "0x8341D0", VA = "0x8341D0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x8341D8", Offset = "0x8341D8", VA = "0x8341D8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x8341E0", Offset = "0x8341E0", VA = "0x8341E0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x8341E8", Offset = "0x8341E8", VA = "0x8341E8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x8341F0", Offset = "0x8341F0", VA = "0x8341F0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x8341F8", Offset = "0x8341F8", VA = "0x8341F8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x8342CC", Offset = "0x8342CC", VA = "0x8342CC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x83443C", Offset = "0x83443C", VA = "0x83443C")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
	{
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x834484", Offset = "0x834484", VA = "0x834484", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x8344B8", Offset = "0x8344B8", VA = "0x8344B8")]
		public LocalizeTargetDesc_Child()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x834500", Offset = "0x834500", VA = "0x834500")]
		static LocalizeTarget_UnityStandard_Child()
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x834504", Offset = "0x834504", VA = "0x834504")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x8345A8", Offset = "0x8345A8", VA = "0x8345A8", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x8345DC", Offset = "0x8345DC", VA = "0x8345DC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x8345E4", Offset = "0x8345E4", VA = "0x8345E4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x8345EC", Offset = "0x8345EC", VA = "0x8345EC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x8345F4", Offset = "0x8345F4", VA = "0x8345F4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x8345FC", Offset = "0x8345FC", VA = "0x8345FC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x834604", Offset = "0x834604", VA = "0x834604", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x83463C", Offset = "0x83463C", VA = "0x83463C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x83477C", Offset = "0x83477C", VA = "0x83477C")]
		public LocalizeTarget_UnityStandard_Child()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x8347C4", Offset = "0x8347C4", VA = "0x8347C4")]
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x8347C8", Offset = "0x8347C8", VA = "0x8347C8")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x834884", Offset = "0x834884", VA = "0x834884", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x83488C", Offset = "0x83488C", VA = "0x83488C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x834894", Offset = "0x834894", VA = "0x834894", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x83489C", Offset = "0x83489C", VA = "0x83489C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x8348A4", Offset = "0x8348A4", VA = "0x8348A4", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x8348AC", Offset = "0x8348AC", VA = "0x8348AC", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x834A88", Offset = "0x834A88", VA = "0x834A88", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x834C54", Offset = "0x834C54", VA = "0x834C54")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
	{
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x834C9C", Offset = "0x834C9C", VA = "0x834C9C", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x834CA4", Offset = "0x834CA4", VA = "0x834CA4")]
		public LocalizeTargetDesc_Prefab()
		{
		}
	}
	[Token(Token = "0x200018D")]
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x834CEC", Offset = "0x834CEC", VA = "0x834CEC")]
		static LocalizeTarget_UnityStandard_Prefab()
		{
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x834CF0", Offset = "0x834CF0", VA = "0x834CF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x834D94", Offset = "0x834D94", VA = "0x834D94", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x834D9C", Offset = "0x834D9C", VA = "0x834D9C", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x834DA4", Offset = "0x834DA4", VA = "0x834DA4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x834DAC", Offset = "0x834DAC", VA = "0x834DAC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x834DB4", Offset = "0x834DB4", VA = "0x834DB4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x834DBC", Offset = "0x834DBC", VA = "0x834DBC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x834DC4", Offset = "0x834DC4", VA = "0x834DC4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x834DFC", Offset = "0x834DFC", VA = "0x834DFC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x835000", Offset = "0x835000", VA = "0x835000")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			return null;
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x8351A4", Offset = "0x8351A4", VA = "0x8351A4")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x8351EC", Offset = "0x8351EC", VA = "0x8351EC")]
		static LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x8351F0", Offset = "0x8351F0", VA = "0x8351F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x8352AC", Offset = "0x8352AC", VA = "0x8352AC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x8352B4", Offset = "0x8352B4", VA = "0x8352B4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x8352BC", Offset = "0x8352BC", VA = "0x8352BC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x8352C4", Offset = "0x8352C4", VA = "0x8352C4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x8352CC", Offset = "0x8352CC", VA = "0x8352CC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x8352D4", Offset = "0x8352D4", VA = "0x8352D4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x8353AC", Offset = "0x8353AC", VA = "0x8353AC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x8354A8", Offset = "0x8354A8", VA = "0x8354A8")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignment mAlignment_RTL;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignment mAlignment_LTR;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x8354F0", Offset = "0x8354F0", VA = "0x8354F0")]
		static LocalizeTarget_UnityStandard_TextMesh()
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x8354F4", Offset = "0x8354F4", VA = "0x8354F4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x8355B0", Offset = "0x8355B0", VA = "0x8355B0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x8355B8", Offset = "0x8355B8", VA = "0x8355B8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x8355C0", Offset = "0x8355C0", VA = "0x8355C0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x8355C8", Offset = "0x8355C8", VA = "0x8355C8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x8355D0", Offset = "0x8355D0", VA = "0x8355D0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x8355D8", Offset = "0x8355D8", VA = "0x8355D8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x8356F4", Offset = "0x8356F4", VA = "0x8356F4", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x835950", Offset = "0x835950", VA = "0x835950")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x8359A8", Offset = "0x8359A8", VA = "0x8359A8")]
		static LocalizeTarget_UnityUI_Image()
		{
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x8359AC", Offset = "0x8359AC", VA = "0x8359AC")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x835A68", Offset = "0x835A68", VA = "0x835A68", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x835A70", Offset = "0x835A70", VA = "0x835A70", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x835A78", Offset = "0x835A78", VA = "0x835A78", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x835A80", Offset = "0x835A80", VA = "0x835A80", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x835B00", Offset = "0x835B00", VA = "0x835B00", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x835B08", Offset = "0x835B08", VA = "0x835B08", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x835C84", Offset = "0x835C84", VA = "0x835C84", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x835D74", Offset = "0x835D74", VA = "0x835D74")]
		public LocalizeTarget_UnityUI_Image()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x835DBC", Offset = "0x835DBC", VA = "0x835DBC")]
		static LocalizeTarget_UnityUI_RawImage()
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x835DC0", Offset = "0x835DC0", VA = "0x835DC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x835E7C", Offset = "0x835E7C", VA = "0x835E7C", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x835E84", Offset = "0x835E84", VA = "0x835E84", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x835E8C", Offset = "0x835E8C", VA = "0x835E8C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x835E94", Offset = "0x835E94", VA = "0x835E94", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x835E9C", Offset = "0x835E9C", VA = "0x835E9C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x835EA4", Offset = "0x835EA4", VA = "0x835EA4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x835F80", Offset = "0x835F80", VA = "0x835F80", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x836070", Offset = "0x836070", VA = "0x836070")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		}
	}
	[Token(Token = "0x2000192")]
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAnchor mAlignment_RTL;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAnchor mAlignment_LTR;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x8360B8", Offset = "0x8360B8", VA = "0x8360B8")]
		static LocalizeTarget_UnityUI_Text()
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x8360BC", Offset = "0x8360BC", VA = "0x8360BC")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x836178", Offset = "0x836178", VA = "0x836178", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x836180", Offset = "0x836180", VA = "0x836180", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x836188", Offset = "0x836188", VA = "0x836188", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x836190", Offset = "0x836190", VA = "0x836190", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x836198", Offset = "0x836198", VA = "0x836198", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x8361A0", Offset = "0x8361A0", VA = "0x8361A0", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, [Out] string primaryTerm, [Out] string secondaryTerm)
		{
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x8362BC", Offset = "0x8362BC", VA = "0x8362BC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x836564", Offset = "0x836564", VA = "0x836564")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, [Out] TextAnchor alignLTR, [Out] TextAnchor alignRTL)
		{
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x83661C", Offset = "0x83661C", VA = "0x83661C")]
		public LocalizeTarget_UnityUI_Text()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public enum eTermType
	{
		[Token(Token = "0x400085C")]
		Text,
		[Token(Token = "0x400085D")]
		Font,
		[Token(Token = "0x400085E")]
		Texture,
		[Token(Token = "0x400085F")]
		AudioClip,
		[Token(Token = "0x4000860")]
		GameObject,
		[Token(Token = "0x4000861")]
		Sprite,
		[Token(Token = "0x4000862")]
		Material,
		[Token(Token = "0x4000863")]
		Child,
		[Token(Token = "0x4000864")]
		Mesh,
		[Token(Token = "0x4000865")]
		TextMeshPFont,
		[Token(Token = "0x4000866")]
		Object
	}
	[Token(Token = "0x2000194")]
	public enum TranslationFlag : byte
	{
		[Token(Token = "0x4000868")]
		Normal = 1,
		[Token(Token = "0x4000869")]
		AutoTranslated
	}
	[Serializable]
	[Token(Token = "0x2000195")]
	public class TermData
	{
		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Term;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public eTermType TermType;

		[NonSerialized]
		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Languages;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] Flags;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] Languages_Touch;

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x836674", Offset = "0x836674", VA = "0x836674")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
			return null;
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x836788", Offset = "0x836788", VA = "0x836788")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x836864", Offset = "0x836864", VA = "0x836864")]
		public void RemoveSpecialization(string specialization)
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x8368B8", Offset = "0x8368B8", VA = "0x8368B8")]
		public void RemoveSpecialization(int idx, string specialization)
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x836A44", Offset = "0x836A44", VA = "0x836A44")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x836A78", Offset = "0x836A78", VA = "0x836A78")]
		public void Validate()
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x836C2C", Offset = "0x836C2C", VA = "0x836C2C")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x836CB4", Offset = "0x836CB4", VA = "0x836CB4")]
		public bool HasSpecializations()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x836D7C", Offset = "0x836D7C", VA = "0x836D7C")]
		public List<string> GetAllSpecializations()
		{
			return null;
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x836E64", Offset = "0x836E64", VA = "0x836E64")]
		public TermData()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class TermsPopup : PropertyAttribute
	{
		[Token(Token = "0x170000D9")]
		public string Filter
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x836F34", Offset = "0x836F34", VA = "0x836F34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x836F3C", Offset = "0x836F3C", VA = "0x836F3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x836F0C", Offset = "0x836F0C", VA = "0x836F0C")]
		public TermsPopup(string filter = "")
		{
		}
	}
	[Token(Token = "0x2000197")]
	public class AutoChangeCultureInfo : MonoBehaviour
	{
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x836F44", Offset = "0x836F44", VA = "0x836F44")]
		public void Start()
		{
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x836F98", Offset = "0x836F98", VA = "0x836F98")]
		public AutoChangeCultureInfo()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x170000DA")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x836FA0", Offset = "0x836FA0", VA = "0x836FA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x8370E0", Offset = "0x8370E0", VA = "0x8370E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x837164", Offset = "0x837164", VA = "0x837164")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x837188", Offset = "0x837188", VA = "0x837188")]
		public CoroutineManager()
		{
		}
	}
	[Token(Token = "0x2000199")]
	[AddComponentMenu("I2/Localization/I2 Localize Callback")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent _OnLocalize;

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x837190", Offset = "0x837190", VA = "0x837190")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x837268", Offset = "0x837268", VA = "0x837268")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x83730C", Offset = "0x83730C", VA = "0x83730C")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x837328", Offset = "0x837328", VA = "0x837328")]
		public CustomLocalizeCallback()
		{
		}
	}
	[Token(Token = "0x200019A")]
	public class HindiFixer
	{
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x837390", Offset = "0x837390", VA = "0x837390")]
		internal static string Fix(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x837794", Offset = "0x837794", VA = "0x837794")]
		public HindiFixer()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public static class I2Utils
	{
		[Token(Token = "0x4000875")]
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

		[Token(Token = "0x4000876")]
		public const string NumberChars = "0123456789";

		[Token(Token = "0x4000877")]
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x8338F4", Offset = "0x8338F4", VA = "0x8338F4")]
		public static string ReverseText(string source)
		{
			return null;
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x837814", Offset = "0x837814", VA = "0x837814")]
		public static string RemoveNonASCII(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x837A3C", Offset = "0x837A3C", VA = "0x837A3C")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x837AE4", Offset = "0x837AE4", VA = "0x837AE4")]
		public static string SplitLine(string line, int maxCharacters)
		{
			return null;
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x837D80", Offset = "0x837D80", VA = "0x837D80")]
		public static bool FindNextTag(string line, int iStart, [Out] int tagStart, [Out] int tagEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x837A5C", Offset = "0x837A5C", VA = "0x837A5C")]
		public static string RemoveTags(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x837F04", Offset = "0x837F04", VA = "0x837F04")]
		public static bool RemoveResourcesPath(string sPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x838180", Offset = "0x838180", VA = "0x838180")]
		public static bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x838188", Offset = "0x838188", VA = "0x838188")]
		public static string GetPath(this Transform tr)
		{
			return null;
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x838258", Offset = "0x838258", VA = "0x838258")]
		public static Transform FindObject(string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x8382B8", Offset = "0x8382B8", VA = "0x8382B8")]
		public static Transform FindObject(Scene scene, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x8383F4", Offset = "0x8383F4", VA = "0x8383F4")]
		public static Transform FindObject(Transform root, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000B36")]
		public static H FindInParents<H>(Transform tr) where H : Component
		{
			return null;
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x838518", Offset = "0x838518", VA = "0x838518")]
		public static string GetCaptureMatch(Match match)
		{
			return null;
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x8385C4", Offset = "0x8385C4", VA = "0x8385C4")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		}
	}
	[Token(Token = "0x200019E")]
	public interface ILocalizationParamsManager
	{
		[Token(Token = "0x6000B3C")]
		string GetParameterValue(string Param);
	}
	[Token(Token = "0x200019F")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		[Serializable]
		[Token(Token = "0x20001A0")]
		public struct ParamValue
		{
			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string Value;
		}

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<ParamValue> _Params;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _IsGlobalManager;

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x838650", Offset = "0x838650", VA = "0x838650", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x838714", Offset = "0x838714", VA = "0x838714")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x8388B0", Offset = "0x8388B0", VA = "0x8388B0")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x838968", Offset = "0x838968", VA = "0x838968", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x838978", Offset = "0x838978", VA = "0x838978")]
		public void DoAutoRegister()
		{
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x838A9C", Offset = "0x838A9C", VA = "0x838A9C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x838B1C", Offset = "0x838B1C", VA = "0x838B1C")]
		public LocalizationParamsManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001A1")]
	public struct LocalizedString
	{
		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string mTerm;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool mRTL_IgnoreArabicFix;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int mRTL_MaxLineLength;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool mRTL_ConvertNumbers;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_DontLocalizeParameters;

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x838B98", Offset = "0x838B98", VA = "0x838B98")]
		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x838C5C", Offset = "0x838C5C", VA = "0x838C5C")]
		public static implicit operator LocalizedString(string term)
		{
			return default(LocalizedString);
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x838C68", Offset = "0x838C68", VA = "0x838C68")]
		public LocalizedString(LocalizedString str)
		{
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x838B9C", Offset = "0x838B9C", VA = "0x838B9C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20001A2")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x838CA0", Offset = "0x838CA0", VA = "0x838CA0", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x838DC4", Offset = "0x838DC4", VA = "0x838DC4", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x838E44", Offset = "0x838E44", VA = "0x838E44", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x838E4C", Offset = "0x838E4C", VA = "0x838E4C")]
		public RegisterGlobalParameters()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public interface IResourceManager_Bundles
	{
		[Token(Token = "0x6000B4C")]
		UnityEngine.Object LoadFromBundle(string path, Type assetType);
	}
	[Token(Token = "0x20001A4")]
	public class ResourceManager : MonoBehaviour
	{
		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<IResourceManager_Bundles> mBundleManagers;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object[] Assets;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, UnityEngine.Object> mResourcesCache;

		[Token(Token = "0x170000DB")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x838E54", Offset = "0x838E54", VA = "0x838E54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x8391FC", Offset = "0x8391FC", VA = "0x8391FC")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000B4F")]
		public T GetAsset<T>(string Name) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x8392B8", Offset = "0x8392B8", VA = "0x8392B8")]
		private UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x8393DC", Offset = "0x8393DC", VA = "0x8393DC")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B52")]
		public T LoadFromResources<T>(string Path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000B53")]
		public T LoadFromBundle<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x839254", Offset = "0x839254", VA = "0x839254")]
		public void CleanResourceCache()
		{
		}

		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x83943C", Offset = "0x83943C", VA = "0x83943C")]
		public ResourceManager()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class RTLFixer
	{
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x839568", Offset = "0x839568", VA = "0x839568")]
		public static string Fix(string str)
		{
			return null;
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x8397E4", Offset = "0x8397E4", VA = "0x8397E4")]
		public static string Fix(string str, bool rtl)
		{
			return null;
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x839574", Offset = "0x839574", VA = "0x839574")]
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x83A9EC", Offset = "0x83A9EC", VA = "0x83A9EC")]
		public RTLFixer()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	internal enum IsolatedArabicLetters
	{
		[Token(Token = "0x4000888")]
		Hamza = 65152,
		[Token(Token = "0x4000889")]
		Alef = 65165,
		[Token(Token = "0x400088A")]
		AlefHamza = 65155,
		[Token(Token = "0x400088B")]
		WawHamza = 65157,
		[Token(Token = "0x400088C")]
		AlefMaksoor = 65159,
		[Token(Token = "0x400088D")]
		AlefMaksora = 64508,
		[Token(Token = "0x400088E")]
		HamzaNabera = 65161,
		[Token(Token = "0x400088F")]
		Ba = 65167,
		[Token(Token = "0x4000890")]
		Ta = 65173,
		[Token(Token = "0x4000891")]
		Tha2 = 65177,
		[Token(Token = "0x4000892")]
		Jeem = 65181,
		[Token(Token = "0x4000893")]
		H7aa = 65185,
		[Token(Token = "0x4000894")]
		Khaa2 = 65189,
		[Token(Token = "0x4000895")]
		Dal = 65193,
		[Token(Token = "0x4000896")]
		Thal = 65195,
		[Token(Token = "0x4000897")]
		Ra2 = 65197,
		[Token(Token = "0x4000898")]
		Zeen = 65199,
		[Token(Token = "0x4000899")]
		Seen = 65201,
		[Token(Token = "0x400089A")]
		Sheen = 65205,
		[Token(Token = "0x400089B")]
		S9a = 65209,
		[Token(Token = "0x400089C")]
		Dha = 65213,
		[Token(Token = "0x400089D")]
		T6a = 65217,
		[Token(Token = "0x400089E")]
		T6ha = 65221,
		[Token(Token = "0x400089F")]
		Ain = 65225,
		[Token(Token = "0x40008A0")]
		Gain = 65229,
		[Token(Token = "0x40008A1")]
		Fa = 65233,
		[Token(Token = "0x40008A2")]
		Gaf = 65237,
		[Token(Token = "0x40008A3")]
		Kaf = 65241,
		[Token(Token = "0x40008A4")]
		Lam = 65245,
		[Token(Token = "0x40008A5")]
		Meem = 65249,
		[Token(Token = "0x40008A6")]
		Noon = 65253,
		[Token(Token = "0x40008A7")]
		Ha = 65257,
		[Token(Token = "0x40008A8")]
		Waw = 65261,
		[Token(Token = "0x40008A9")]
		Ya = 65265,
		[Token(Token = "0x40008AA")]
		AlefMad = 65153,
		[Token(Token = "0x40008AB")]
		TaMarboota = 65171,
		[Token(Token = "0x40008AC")]
		PersianPe = 64342,
		[Token(Token = "0x40008AD")]
		PersianChe = 64378,
		[Token(Token = "0x40008AE")]
		PersianZe = 64394,
		[Token(Token = "0x40008AF")]
		PersianGaf = 64402,
		[Token(Token = "0x40008B0")]
		PersianGaf2 = 64398
	}
	[Token(Token = "0x20001A7")]
	internal enum GeneralArabicLetters
	{
		[Token(Token = "0x40008B2")]
		Hamza = 1569,
		[Token(Token = "0x40008B3")]
		Alef = 1575,
		[Token(Token = "0x40008B4")]
		AlefHamza = 1571,
		[Token(Token = "0x40008B5")]
		WawHamza = 1572,
		[Token(Token = "0x40008B6")]
		AlefMaksoor = 1573,
		[Token(Token = "0x40008B7")]
		AlefMagsora = 1609,
		[Token(Token = "0x40008B8")]
		HamzaNabera = 1574,
		[Token(Token = "0x40008B9")]
		Ba = 1576,
		[Token(Token = "0x40008BA")]
		Ta = 1578,
		[Token(Token = "0x40008BB")]
		Tha2 = 1579,
		[Token(Token = "0x40008BC")]
		Jeem = 1580,
		[Token(Token = "0x40008BD")]
		H7aa = 1581,
		[Token(Token = "0x40008BE")]
		Khaa2 = 1582,
		[Token(Token = "0x40008BF")]
		Dal = 1583,
		[Token(Token = "0x40008C0")]
		Thal = 1584,
		[Token(Token = "0x40008C1")]
		Ra2 = 1585,
		[Token(Token = "0x40008C2")]
		Zeen = 1586,
		[Token(Token = "0x40008C3")]
		Seen = 1587,
		[Token(Token = "0x40008C4")]
		Sheen = 1588,
		[Token(Token = "0x40008C5")]
		S9a = 1589,
		[Token(Token = "0x40008C6")]
		Dha = 1590,
		[Token(Token = "0x40008C7")]
		T6a = 1591,
		[Token(Token = "0x40008C8")]
		T6ha = 1592,
		[Token(Token = "0x40008C9")]
		Ain = 1593,
		[Token(Token = "0x40008CA")]
		Gain = 1594,
		[Token(Token = "0x40008CB")]
		Fa = 1601,
		[Token(Token = "0x40008CC")]
		Gaf = 1602,
		[Token(Token = "0x40008CD")]
		Kaf = 1603,
		[Token(Token = "0x40008CE")]
		Lam = 1604,
		[Token(Token = "0x40008CF")]
		Meem = 1605,
		[Token(Token = "0x40008D0")]
		Noon = 1606,
		[Token(Token = "0x40008D1")]
		Ha = 1607,
		[Token(Token = "0x40008D2")]
		Waw = 1608,
		[Token(Token = "0x40008D3")]
		Ya = 1610,
		[Token(Token = "0x40008D4")]
		AlefMad = 1570,
		[Token(Token = "0x40008D5")]
		TaMarboota = 1577,
		[Token(Token = "0x40008D6")]
		PersianPe = 1662,
		[Token(Token = "0x40008D7")]
		PersianChe = 1670,
		[Token(Token = "0x40008D8")]
		PersianZe = 1688,
		[Token(Token = "0x40008D9")]
		PersianGaf = 1711,
		[Token(Token = "0x40008DA")]
		PersianGaf2 = 1705
	}
	[Token(Token = "0x20001A8")]
	internal class ArabicMapping
	{
		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int from;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int to;

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x83A9F4", Offset = "0x83A9F4", VA = "0x83A9F4")]
		public ArabicMapping(int from, int to)
		{
		}
	}
	[Token(Token = "0x20001A9")]
	internal class ArabicTable
	{
		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ArabicTable arabicMapper;

		[Token(Token = "0x170000DC")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0x83C160", Offset = "0x83C160", VA = "0x83C160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x83AA20", Offset = "0x83AA20", VA = "0x83AA20")]
		private ArabicTable()
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x83C1D0", Offset = "0x83C1D0", VA = "0x83C1D0")]
		internal int Convert(int toBeConverted)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001AA")]
	internal class TashkeelLocation
	{
		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char tashkeel;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int position;

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x83C364", Offset = "0x83C364", VA = "0x83C364")]
		public TashkeelLocation(char tashkeel, int position)
		{
		}
	}
	[Token(Token = "0x20001AB")]
	internal class RTLFixerTool
	{
		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x83C394", Offset = "0x83C394", VA = "0x83C394")]
		internal static string RemoveTashkeel(string str, [Out] List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x83C8B0", Offset = "0x83C8B0", VA = "0x83C8B0")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x8399E4", Offset = "0x8399E4", VA = "0x8399E4")]
		internal static string FixLine(string str)
		{
			return null;
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x83CADC", Offset = "0x83CADC", VA = "0x83CADC")]
		internal static bool IsIgnoredCharacter(char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x83D0AC", Offset = "0x83D0AC", VA = "0x83D0AC")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x83CF68", Offset = "0x83CF68", VA = "0x83CF68")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x83CC38", Offset = "0x83CC38", VA = "0x83CC38")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x83D398", Offset = "0x83D398", VA = "0x83D398")]
		public RTLFixerTool()
		{
		}
	}
	[Token(Token = "0x20001AC")]
	[AddComponentMenu("I2/Localization/SetLanguage Button")]
	public class SetLanguage : MonoBehaviour
	{
		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string _Language;

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x83D3EC", Offset = "0x83D3EC", VA = "0x83D3EC")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x83D3F0", Offset = "0x83D3F0", VA = "0x83D3F0")]
		public void ApplyLanguage()
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x83D488", Offset = "0x83D488", VA = "0x83D488")]
		public SetLanguage()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	[AddComponentMenu("I2/Localization/SetLanguage Dropdown")]
	public class SetLanguageDropdown : MonoBehaviour
	{
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x83D490", Offset = "0x83D490", VA = "0x83D490")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x83D6E8", Offset = "0x83D6E8", VA = "0x83D6E8")]
		private void OnValueChanged(int index)
		{
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x83D7D4", Offset = "0x83D7D4", VA = "0x83D7D4")]
		public SetLanguageDropdown()
		{
		}
	}
	[Token(Token = "0x20001AE")]
	public class StringObfucator
	{
		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static char[] StringObfuscatorPassword;

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x83D7DC", Offset = "0x83D7DC", VA = "0x83D7DC")]
		public static string Encode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x83DAD0", Offset = "0x83DAD0", VA = "0x83DAD0")]
		public static string Decode(string ObfucatedString)
		{
			return null;
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x83DA4C", Offset = "0x83DA4C", VA = "0x83DA4C")]
		private static string ToBase64(string regularString)
		{
			return null;
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x83DBA8", Offset = "0x83DBA8", VA = "0x83DBA8")]
		private static string FromBase64(string base64string)
		{
			return null;
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x83D8B4", Offset = "0x83D8B4", VA = "0x83D8B4")]
		private static string XoREncode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x83DC34", Offset = "0x83DC34", VA = "0x83DC34")]
		public StringObfucator()
		{
		}
	}
}
namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x20001AF")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x40008E6")]
		Array = 1,
		[Token(Token = "0x40008E7")]
		Class,
		[Token(Token = "0x40008E8")]
		Value,
		[Token(Token = "0x40008E9")]
		IntValue,
		[Token(Token = "0x40008EA")]
		DoubleValue,
		[Token(Token = "0x40008EB")]
		BoolValue,
		[Token(Token = "0x40008EC")]
		FloatValue
	}
	[Token(Token = "0x20001B0")]
	public class JSONNode
	{
		[Token(Token = "0x20001B1")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x170000E9")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000BA9")]
				[Address(RVA = "0x83FD28", Offset = "0x83FD28", VA = "0x83FD28", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BAB")]
				[Address(RVA = "0x83FD70", Offset = "0x83FD70", VA = "0x83FD70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x83DDFC", Offset = "0x83DDFC", VA = "0x83DDFC")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x83FD0C", Offset = "0x83FD0C", VA = "0x83FD0C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x83FD10", Offset = "0x83FD10", VA = "0x83FD10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x83FD30", Offset = "0x83FD30", VA = "0x83FD30", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0x83FD78", Offset = "0x83FD78", VA = "0x83FD78", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x83FE10", Offset = "0x83FE10", VA = "0x83FE10", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x170000EB")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000BB3")]
				[Address(RVA = "0x840440", Offset = "0x840440", VA = "0x840440", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BB5")]
				[Address(RVA = "0x840488", Offset = "0x840488", VA = "0x840488", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x83DEA8", Offset = "0x83DEA8", VA = "0x83DEA8")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0x83FE14", Offset = "0x83FE14", VA = "0x83FE14", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x83FED4", Offset = "0x83FED4", VA = "0x83FED4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x840390", Offset = "0x840390", VA = "0x840390")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0x8402E0", Offset = "0x8402E0", VA = "0x8402E0")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x840448", Offset = "0x840448", VA = "0x840448", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x840490", Offset = "0x840490", VA = "0x840490", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x840534", Offset = "0x840534", VA = "0x840534", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public virtual JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x83DCB0", Offset = "0x83DCB0", VA = "0x83DCB0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x83DCB8", Offset = "0x83DCB8", VA = "0x83DCB8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x83DCBC", Offset = "0x83DCBC", VA = "0x83DCBC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x83DCC4", Offset = "0x83DCC4", VA = "0x83DCC4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public virtual string Value
		{
			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x83DCC8", Offset = "0x83DCC8", VA = "0x83DCC8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x83DD08", Offset = "0x83DD08", VA = "0x83DD08", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public virtual int Count
		{
			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x83DD0C", Offset = "0x83DD0C", VA = "0x83DD0C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E1")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000B81")]
			[Address(RVA = "0x83DD8C", Offset = "0x83DD8C", VA = "0x83DD8C", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__17))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0x83DE30", Offset = "0x83DE30", VA = "0x83DE30")]
			[IteratorStateMachine(typeof(<get_DeepChilds>d__19))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x83DF5C", Offset = "0x83DF5C", VA = "0x83DF5C", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B86")]
			[Address(RVA = "0x83DF90", Offset = "0x83DF90", VA = "0x83DF90", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x83DFCC", Offset = "0x83DFCC", VA = "0x83DFCC", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B88")]
			[Address(RVA = "0x83E004", Offset = "0x83E004", VA = "0x83E004", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0x83E040", Offset = "0x83E040", VA = "0x83E040", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0x83E078", Offset = "0x83E078", VA = "0x83E078", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x83E0B4", Offset = "0x83E0B4", VA = "0x83E0B4", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0x83E16C", Offset = "0x83E16C", VA = "0x83E16C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0x83E1E4", Offset = "0x83E1E4", VA = "0x83E1E4", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x83E25C", Offset = "0x83E25C", VA = "0x83E25C", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x83DCAC", Offset = "0x83DCAC", VA = "0x83DCAC", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x83DD14", Offset = "0x83DD14", VA = "0x83DD14", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x83DD74", Offset = "0x83DD74", VA = "0x83DD74", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x83DD7C", Offset = "0x83DD7C", VA = "0x83DD7C", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x83DD84", Offset = "0x83DD84", VA = "0x83DD84", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x83DEDC", Offset = "0x83DEDC", VA = "0x83DEDC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x83DF1C", Offset = "0x83DF1C", VA = "0x83DF1C", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x83E2D4", Offset = "0x83E2D4", VA = "0x83E2D4")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x83E360", Offset = "0x83E360", VA = "0x83E360")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x83E39C", Offset = "0x83E39C", VA = "0x83E39C")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x83E424", Offset = "0x83E424", VA = "0x83E424")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x83E43C", Offset = "0x83E43C", VA = "0x83E43C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x83E448", Offset = "0x83E448", VA = "0x83E448", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x83E450", Offset = "0x83E450", VA = "0x83E450")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x83E61C", Offset = "0x83E61C", VA = "0x83E61C")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x83EE94", Offset = "0x83EE94", VA = "0x83EE94", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x83EE98", Offset = "0x83EE98", VA = "0x83EE98")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x83EF18", Offset = "0x83EF18", VA = "0x83EF18")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x83EF68", Offset = "0x83EF68", VA = "0x83EF68")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x83EFB8", Offset = "0x83EFB8", VA = "0x83EFB8")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x83F008", Offset = "0x83F008", VA = "0x83F008")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x83F1E4", Offset = "0x83F1E4", VA = "0x83F1E4")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x83F3E4", Offset = "0x83F3E4", VA = "0x83F3E4")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x83F850", Offset = "0x83F850", VA = "0x83F850")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x83F8A0", Offset = "0x83F8A0", VA = "0x83F8A0")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x83F8F0", Offset = "0x83F8F0", VA = "0x83F8F0")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x83F940", Offset = "0x83F940", VA = "0x83F940")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x83FAD4", Offset = "0x83FAD4", VA = "0x83FAD4")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x83FC50", Offset = "0x83FC50", VA = "0x83FC50")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x83FD04", Offset = "0x83FD04", VA = "0x83FD04")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x20001B4")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000F1")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000BCA")]
				[Address(RVA = "0x8412F0", Offset = "0x8412F0", VA = "0x8412F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BCC")]
				[Address(RVA = "0x841338", Offset = "0x841338", VA = "0x841338", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x840AA4", Offset = "0x840AA4", VA = "0x840AA4")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x8410E4", Offset = "0x8410E4", VA = "0x8410E4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x841100", Offset = "0x841100", VA = "0x841100", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x8412A0", Offset = "0x8412A0", VA = "0x8412A0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x8412F8", Offset = "0x8412F8", VA = "0x8412F8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x841340", Offset = "0x841340", VA = "0x841340", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x8413E4", Offset = "0x8413E4", VA = "0x8413E4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001B5")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000F3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BD3")]
				[Address(RVA = "0x8415F4", Offset = "0x8415F4", VA = "0x8415F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BD5")]
				[Address(RVA = "0x84163C", Offset = "0x84163C", VA = "0x84163C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x840B40", Offset = "0x840B40", VA = "0x840B40")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x8413E8", Offset = "0x8413E8", VA = "0x8413E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x841404", Offset = "0x841404", VA = "0x841404", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x8415A4", Offset = "0x8415A4", VA = "0x8415A4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x8415FC", Offset = "0x8415FC", VA = "0x8415FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x170000ED")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x840538", Offset = "0x840538", VA = "0x840538", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x840614", Offset = "0x840614", VA = "0x840614", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x84071C", Offset = "0x84071C", VA = "0x84071C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x840780", Offset = "0x840780", VA = "0x840780", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public override int Count
		{
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x840828", Offset = "0x840828", VA = "0x840828", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F0")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x840A2C", Offset = "0x840A2C", VA = "0x840A2C", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__13))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x840870", Offset = "0x840870", VA = "0x840870", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x840918", Offset = "0x840918", VA = "0x840918", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x8409CC", Offset = "0x8409CC", VA = "0x8409CC", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x840AD8", Offset = "0x840AD8", VA = "0x840AD8", Slot = "29")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__14))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x840B68", Offset = "0x840B68", VA = "0x840B68", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x840D84", Offset = "0x840D84", VA = "0x840D84", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x841008", Offset = "0x841008", VA = "0x841008", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x83EE18", Offset = "0x83EE18", VA = "0x83EE18")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x20001B8")]
		[CompilerGenerated]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000F9")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000BEB")]
				[Address(RVA = "0x842C68", Offset = "0x842C68", VA = "0x842C68", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BED")]
				[Address(RVA = "0x842CB0", Offset = "0x842CB0", VA = "0x842CB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0x841EC0", Offset = "0x841EC0", VA = "0x841EC0")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x842A48", Offset = "0x842A48", VA = "0x842A48", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x842A64", Offset = "0x842A64", VA = "0x842A64", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x842C18", Offset = "0x842C18", VA = "0x842C18")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x842C70", Offset = "0x842C70", VA = "0x842C70", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x842CB8", Offset = "0x842CB8", VA = "0x842CB8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x842D5C", Offset = "0x842D5C", VA = "0x842D5C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001B9")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000FB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BF4")]
				[Address(RVA = "0x842FA0", Offset = "0x842FA0", VA = "0x842FA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BF6")]
				[Address(RVA = "0x842FE8", Offset = "0x842FE8", VA = "0x842FE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x841F5C", Offset = "0x841F5C", VA = "0x841F5C")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x842D60", Offset = "0x842D60", VA = "0x842D60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x842D7C", Offset = "0x842D7C", VA = "0x842D7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x842F50", Offset = "0x842F50", VA = "0x842F50")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x842FA8", Offset = "0x842FA8", VA = "0x842FA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x170000F5")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x841644", Offset = "0x841644", VA = "0x841644", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x841734", Offset = "0x841734", VA = "0x841734", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x841800", Offset = "0x841800", VA = "0x841800", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x8418A0", Offset = "0x8418A0", VA = "0x8418A0", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public override int Count
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x84197C", Offset = "0x84197C", VA = "0x84197C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F8")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x841E48", Offset = "0x841E48", VA = "0x841E48", Slot = "16")]
			[IteratorStateMachine(typeof(<get_Childs>d__14))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x8419CC", Offset = "0x8419CC", VA = "0x8419CC", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x841AE0", Offset = "0x841AE0", VA = "0x841AE0", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x841BA4", Offset = "0x841BA4", VA = "0x841BA4", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x841C80", Offset = "0x841C80", VA = "0x841C80", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x841EF4", Offset = "0x841EF4", VA = "0x841EF4", Slot = "29")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x841F84", Offset = "0x841F84", VA = "0x841F84", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x842370", Offset = "0x842370", VA = "0x842370", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x8427E0", Offset = "0x8427E0", VA = "0x8427E0", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x83ED38", Offset = "0x83ED38", VA = "0x83ED38")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x20001BA")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x170000FD")]
		public override string Value
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x842FF0", Offset = "0x842FF0", VA = "0x842FF0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x842FF8", Offset = "0x842FF8", VA = "0x842FF8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x83E338", Offset = "0x83E338", VA = "0x83E338")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x83F818", Offset = "0x83F818", VA = "0x83F818")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x83F7A8", Offset = "0x83F7A8", VA = "0x83F7A8")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x83F7E0", Offset = "0x83F7E0", VA = "0x83F7E0")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x83F770", Offset = "0x83F770", VA = "0x83F770")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x843000", Offset = "0x843000", VA = "0x843000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x843058", Offset = "0x843058", VA = "0x843058", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x8430B0", Offset = "0x8430B0", VA = "0x8430B0", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20001BB")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x170000FE")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x8433C4", Offset = "0x8433C4", VA = "0x8433C4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x843428", Offset = "0x843428", VA = "0x843428", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x8434A8", Offset = "0x8434A8", VA = "0x8434A8", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C07")]
			[Address(RVA = "0x843518", Offset = "0x843518", VA = "0x843518", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public override int AsInt
		{
			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x843778", Offset = "0x843778", VA = "0x843778", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x8437FC", Offset = "0x8437FC", VA = "0x8437FC", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public override float AsFloat
		{
			[Token(Token = "0x6000C12")]
			[Address(RVA = "0x843884", Offset = "0x843884", VA = "0x843884", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000C13")]
			[Address(RVA = "0x843908", Offset = "0x843908", VA = "0x843908", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public override double AsDouble
		{
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x843990", Offset = "0x843990", VA = "0x843990", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x843A14", Offset = "0x843A14", VA = "0x843A14", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public override bool AsBool
		{
			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x843A9C", Offset = "0x843A9C", VA = "0x843A9C", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x843B20", Offset = "0x843B20", VA = "0x843B20", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x843BA8", Offset = "0x843BA8", VA = "0x843BA8", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000105")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x843C10", Offset = "0x843C10", VA = "0x843C10", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x8405EC", Offset = "0x8405EC", VA = "0x8405EC")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x841708", Offset = "0x841708", VA = "0x841708")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x843370", Offset = "0x843370", VA = "0x843370")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x8435A0", Offset = "0x8435A0", VA = "0x8435A0", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x843620", Offset = "0x843620", VA = "0x843620", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x8436A8", Offset = "0x8436A8", VA = "0x8436A8")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x8436C0", Offset = "0x8436C0", VA = "0x8436C0")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x8436D8", Offset = "0x8436D8", VA = "0x8436D8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x8436F0", Offset = "0x8436F0", VA = "0x8436F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x8436F8", Offset = "0x8436F8", VA = "0x8436F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x843738", Offset = "0x843738", VA = "0x843738", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x20001BC")]
	public static class JSON
	{
		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x843C78", Offset = "0x843C78", VA = "0x843C78")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
namespace FlexFramework.Excel
{
	[Token(Token = "0x20001BD")]
	public abstract class CustomConverter<T> : IConverter
	{
		[Token(Token = "0x20001BE")]
		[CompilerGenerated]
		private sealed class <SplitGroup>d__5 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string <>2__current;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private char start;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public char <>3__start;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private char end;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public char <>3__end;

			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string input;

			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string <>3__input;

			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator <>7__wrap1;

			[Token(Token = "0x17000107")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x6000C26")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000108")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C28")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C22")]
			[DebuggerHidden]
			public <SplitGroup>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000C23")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C24")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C25")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000C27")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000C29")]
			[DebuggerHidden]
			private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000C2A")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		private Type FlexFramework.Excel.IConverter.Type
		{
			[Token(Token = "0x6000C1B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C1C")]
		public abstract T Convert(string input);

		[Token(Token = "0x6000C1D")]
		public bool TryConvert(string input, [Out] T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C1E")]
		protected string[] Split(string input, params char[] separators)
		{
			return null;
		}

		[Token(Token = "0x6000C1F")]
		[IteratorStateMachine(typeof(CustomConverter<>.<SplitGroup>d__5))]
		protected IEnumerable<string> SplitGroup(string input, char start, char end)
		{
			return null;
		}

		[Token(Token = "0x6000C20")]
		private object FlexFramework.Excel.IConverter.Convert(string input)
		{
			return null;
		}

		[Token(Token = "0x6000C21")]
		protected CustomConverter()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	public sealed class ArrayConverter<T> : CustomConverter<T[]>
	{
		[Token(Token = "0x6000C2B")]
		public override T[] Convert(string input)
		{
			return null;
		}

		[Token(Token = "0x6000C2C")]
		public ArrayConverter()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	public class Color32Converter : CustomConverter<Color32>
	{
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x843C7C", Offset = "0x843C7C", VA = "0x843C7C", Slot = "6")]
		public override Color32 Convert(string input)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x8444D0", Offset = "0x8444D0", VA = "0x8444D0")]
		public Color32Converter()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	public sealed class ColorConverter : CustomConverter<Color>
	{
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x844518", Offset = "0x844518", VA = "0x844518", Slot = "6")]
		public override Color Convert(string input)
		{
			return default(Color);
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x8449B4", Offset = "0x8449B4", VA = "0x8449B4")]
		public static string ColorToHex(Color color)
		{
			return null;
		}

		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x844908", Offset = "0x844908", VA = "0x844908")]
		public static Color HexToColor(string hex)
		{
			return default(Color);
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x844A60", Offset = "0x844A60", VA = "0x844A60")]
		public ColorConverter()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public sealed class DictionaryConverter<TKey, TValue> : CustomConverter<Dictionary<TKey, TValue>>
	{
		[Token(Token = "0x6000C36")]
		public override Dictionary<TKey, TValue> Convert(string input)
		{
			return null;
		}

		[Token(Token = "0x6000C37")]
		public DictionaryConverter()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	public sealed class ListConverter<T> : CustomConverter<List<T>>
	{
		[Token(Token = "0x6000C38")]
		public override List<T> Convert(string input)
		{
			return null;
		}

		[Token(Token = "0x6000C39")]
		public ListConverter()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	public class ObjectConverter : CustomConverter<object>
	{
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x844AA8", Offset = "0x844AA8", VA = "0x844AA8", Slot = "6")]
		public override object Convert(string input)
		{
			return null;
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x844DF8", Offset = "0x844DF8", VA = "0x844DF8")]
		public ObjectConverter()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	public sealed class RectConverter : CustomConverter<Rect>
	{
		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x844E40", Offset = "0x844E40", VA = "0x844E40", Slot = "6")]
		public override Rect Convert(string input)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x8450BC", Offset = "0x8450BC", VA = "0x8450BC")]
		public RectConverter()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	public sealed class Vector2Converter : CustomConverter<Vector2>
	{
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x845104", Offset = "0x845104", VA = "0x845104", Slot = "6")]
		public override Vector2 Convert(string input)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x845318", Offset = "0x845318", VA = "0x845318")]
		public Vector2Converter()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	public sealed class Vector3Converter : CustomConverter<Vector3>
	{
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x845360", Offset = "0x845360", VA = "0x845360", Slot = "6")]
		public override Vector3 Convert(string input)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x845594", Offset = "0x845594", VA = "0x845594")]
		public Vector3Converter()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	public sealed class Vector4Converter : CustomConverter<Vector4>
	{
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x8455DC", Offset = "0x8455DC", VA = "0x8455DC", Slot = "6")]
		public override Vector4 Convert(string input)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x845838", Offset = "0x845838", VA = "0x845838")]
		public Vector4Converter()
		{
		}
	}
	[Token(Token = "0x20001CB")]
	public static class Extensions
	{
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x845880", Offset = "0x845880", VA = "0x845880")]
		public static object Convert(this Cell cell, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C48")]
		public static T Convert<T>(this Cell cell)
		{
			return (T)null;
		}

		[Token(Token = "0x6000C49")]
		public static T Convert<T>(this Row row, IGenerator<T> generator) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000C4A")]
		public static T Convert<T>(this Row row, string expression) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000C4B")]
		public static T Convert<T>(this Row row, IEnumerable<Cell> cols) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x845C80", Offset = "0x845C80", VA = "0x845C80")]
		public static object Convert(this Row row, Type type, string expression)
		{
			return null;
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x845DC0", Offset = "0x845DC0", VA = "0x845DC0")]
		public static object Convert(this Row row, Type type, IEnumerable<Cell> cols)
		{
			return null;
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x845D1C", Offset = "0x845D1C", VA = "0x845D1C")]
		public static object Convert(this Row row, IGenerator generator)
		{
			return null;
		}

		[Token(Token = "0x6000C4F")]
		public static IEnumerable<T> Convert<T>(this Table table) where T : new()
		{
			return null;
		}

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x845E5C", Offset = "0x845E5C", VA = "0x845E5C")]
		public static IEnumerable<object> Convert(this Table table, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C51")]
		public static IEnumerable<T> Convert<T>(this Table table, ITableGenerator<T> generator) where T : new()
		{
			return null;
		}

		[Token(Token = "0x6000C52")]
		public static IEnumerable<T> Convert<T>(this Table table, int row) where T : new()
		{
			return null;
		}

		[Token(Token = "0x6000C53")]
		public static IEnumerable<T> Convert<T>(this Table table, string expression, params int[] exclude) where T : new()
		{
			return null;
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x845F84", Offset = "0x845F84", VA = "0x845F84")]
		public static IEnumerable<object> Convert(this Table table, Type type, string expression, params int[] exclude)
		{
			return null;
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x845EE0", Offset = "0x845EE0", VA = "0x845EE0")]
		public static IEnumerable<object> Convert(this Table table, ITableGenerator generator)
		{
			return null;
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x846064", Offset = "0x846064", VA = "0x846064")]
		public static IEnumerable<object> Convert(this Table table, Type type, int row)
		{
			return null;
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x84624C", Offset = "0x84624C", VA = "0x84624C")]
		public static string Dump(this Row row, char delimiter, char enclose)
		{
			return null;
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x8463E8", Offset = "0x8463E8", VA = "0x8463E8")]
		public static string Dump(this Row row)
		{
			return null;
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x84644C", Offset = "0x84644C", VA = "0x84644C")]
		public static string Dump(this Cell cell, char delimiter, char enclose)
		{
			return null;
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x846590", Offset = "0x846590", VA = "0x846590")]
		public static string Dump(this Cell cell)
		{
			return null;
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x8465F4", Offset = "0x8465F4", VA = "0x8465F4")]
		public static string Dump(this Table table, char delimiter, char enclose)
		{
			return null;
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x8467D4", Offset = "0x8467D4", VA = "0x8467D4")]
		public static string Dump(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x846838", Offset = "0x846838", VA = "0x846838")]
		public static Cell Select(this Row row, string address)
		{
			return null;
		}

		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x846B40", Offset = "0x846B40", VA = "0x846B40")]
		public static IEnumerable<Cell> SelectRange(this Row row, string range)
		{
			return null;
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x846BDC", Offset = "0x846BDC", VA = "0x846BDC")]
		public static Cell Select(this Table table, string address)
		{
			return null;
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x846DE8", Offset = "0x846DE8", VA = "0x846DE8")]
		public static IEnumerable<Cell> SelectRange(this Table table, string range)
		{
			return null;
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x846E84", Offset = "0x846E84", VA = "0x846E84")]
		public static Cell Select(this WorkBook book, string path)
		{
			return null;
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x84702C", Offset = "0x84702C", VA = "0x84702C")]
		public static IEnumerable<Cell> SelectRange(this WorkBook book, string path)
		{
			return null;
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x8471D4", Offset = "0x8471D4", VA = "0x8471D4")]
		public static void Recalculate(this Table table)
		{
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x847320", Offset = "0x847320", VA = "0x847320")]
		public static Table Expand(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x8475D8", Offset = "0x8475D8", VA = "0x8475D8")]
		public static Table Collapse(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x847974", Offset = "0x847974", VA = "0x847974")]
		public static Table Rotate(this Table table)
		{
			return null;
		}

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x847CA8", Offset = "0x847CA8", VA = "0x847CA8")]
		public static bool IsEmpty(this Row row)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001D3")]
	public interface IConverter
	{
		[Token(Token = "0x17000109")]
		Type Type
		{
			[Token(Token = "0x6000C7C")]
			get;
		}

		[Token(Token = "0x6000C7B")]
		object Convert(string input);
	}
	[Token(Token = "0x20001D4")]
	public static class Validator
	{
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x848088", Offset = "0x848088", VA = "0x848088")]
		public static bool CanCast(Type from, Type to)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x848310", Offset = "0x848310", VA = "0x848310")]
		private static bool HasImplicitConversion(Type definedOn, Type baseType, Type targetType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x8481DC", Offset = "0x8481DC", VA = "0x8481DC")]
		public static bool HasImplicitConversion(Type source, Type target)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001D6")]
	public static class ValueConverter
	{
		[Token(Token = "0x20001D7")]
		private class Converter<T> : IConverter
		{
			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Converter<string, T> _converter;

			[Token(Token = "0x1700010A")]
			private Type FlexFramework.Excel.IConverter.Type
			{
				[Token(Token = "0x6000C8F")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C8E")]
			public Converter(Converter<string, T> converter)
			{
			}

			[Token(Token = "0x6000C90")]
			private object FlexFramework.Excel.IConverter.Convert(string input)
			{
				return null;
			}
		}

		[Token(Token = "0x20001D8")]
		private class Converter : IConverter
		{
			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Converter<string, object> _converter;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Type _type;

			[Token(Token = "0x1700010B")]
			private Type FlexFramework.Excel.IConverter.Type
			{
				[Token(Token = "0x6000C92")]
				[Address(RVA = "0x849584", Offset = "0x849584", VA = "0x849584", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x8493A8", Offset = "0x8493A8", VA = "0x8493A8")]
			public Converter(Converter<string, object> converter, Type type)
			{
			}

			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x84958C", Offset = "0x84958C", VA = "0x84958C", Slot = "4")]
			private object FlexFramework.Excel.IConverter.Convert(string input)
			{
				return null;
			}
		}

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<IConverter> converters;

		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x848600", Offset = "0x848600", VA = "0x848600")]
		static ValueConverter()
		{
		}

		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x84868C", Offset = "0x84868C", VA = "0x84868C")]
		public static void Reset()
		{
		}

		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x84926C", Offset = "0x84926C", VA = "0x84926C")]
		public static void Empty()
		{
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x8458FC", Offset = "0x8458FC", VA = "0x8458FC")]
		public static object Convert(Type type, string value)
		{
			return null;
		}

		[Token(Token = "0x6000C87")]
		public static T Convert<T>(string value)
		{
			return (T)null;
		}

		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x8490DC", Offset = "0x8490DC", VA = "0x8490DC")]
		public static bool Register(IConverter converter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C89")]
		public static bool Register<T>() where T : IConverter, new()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C8A")]
		public static bool Register<T>(Converter<string, T> converter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x849314", Offset = "0x849314", VA = "0x849314")]
		public static bool Register(Converter<string, object> converter, Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x84946C", Offset = "0x84946C", VA = "0x84946C")]
		public static bool Unregister(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C8D")]
		public static bool Unregister<T>()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001DC")]
	public struct Address : IEquatable<Address>
	{
		[Token(Token = "0x1700010C")]
		public int Column
		{
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x849984", Offset = "0x849984", VA = "0x849984")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x84998C", Offset = "0x84998C", VA = "0x84998C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public int Row
		{
			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x849994", Offset = "0x849994", VA = "0x849994")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x84999C", Offset = "0x84999C", VA = "0x84999C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public string ColumnName
		{
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x849B84", Offset = "0x849B84", VA = "0x849B84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x8498BC", Offset = "0x8498BC", VA = "0x8498BC", Slot = "4")]
		private bool System.IEquatable<FlexFramework.Excel.Address>.Equals(Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x8498E4", Offset = "0x8498E4", VA = "0x8498E4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x849970", Offset = "0x849970", VA = "0x849970", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x8469E0", Offset = "0x8469E0", VA = "0x8469E0")]
		public Address(string address)
		{
		}

		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x847318", Offset = "0x847318", VA = "0x847318")]
		public Address(int column, int row)
		{
		}

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x849CB8", Offset = "0x849CB8", VA = "0x849CB8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x847FD0", Offset = "0x847FD0", VA = "0x847FD0")]
		public static bool operator ==(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x849D4C", Offset = "0x849D4C", VA = "0x849D4C")]
		public static bool operator !=(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x849D6C", Offset = "0x849D6C", VA = "0x849D6C")]
		public static bool operator >=(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x849D8C", Offset = "0x849D8C", VA = "0x849D8C")]
		public static bool operator <=(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x849DAC", Offset = "0x849DAC", VA = "0x849DAC")]
		public static bool operator >(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x849DCC", Offset = "0x849DCC", VA = "0x849DCC")]
		public static bool operator <(Address address, Address other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x849DEC", Offset = "0x849DEC", VA = "0x849DEC")]
		public static Range operator +(Address from, Address to)
		{
			return default(Range);
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x849E1C", Offset = "0x849E1C", VA = "0x849E1C")]
		public static Address operator >>(Address address, int column)
		{
			return default(Address);
		}

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x849E2C", Offset = "0x849E2C", VA = "0x849E2C")]
		public static Address operator <<(Address address, int column)
		{
			return default(Address);
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x849E3C", Offset = "0x849E3C", VA = "0x849E3C")]
		public static Address operator +(Address address, int row)
		{
			return default(Address);
		}

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x849E4C", Offset = "0x849E4C", VA = "0x849E4C")]
		public static Address operator -(Address address, int row)
		{
			return default(Address);
		}

		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x849B8C", Offset = "0x849B8C", VA = "0x849B8C")]
		public static string ParseColumn(int column)
		{
			return null;
		}

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x8499A4", Offset = "0x8499A4", VA = "0x8499A4")]
		public static int ParseColumn(string column)
		{
			return default(int);
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x846970", Offset = "0x846970", VA = "0x846970")]
		public static bool IsValid(string address)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001DD")]
	public class Cell : ICloneable<Cell>
	{
		[Token(Token = "0x1700010F")]
		public Address Address
		{
			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x849E5C", Offset = "0x849E5C", VA = "0x849E5C")]
			[CompilerGenerated]
			get
			{
				return default(Address);
			}
			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x849E64", Offset = "0x849E64", VA = "0x849E64")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public object Value
		{
			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x849E6C", Offset = "0x849E6C", VA = "0x849E6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x849E74", Offset = "0x849E74", VA = "0x849E74")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public bool IsSpan
		{
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x849E7C", Offset = "0x849E7C", VA = "0x849E7C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x849E84", Offset = "0x849E84", VA = "0x849E84")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public virtual string Text
		{
			[Token(Token = "0x6000CC1")]
			[Address(RVA = "0x84A160", Offset = "0x84A160", VA = "0x84A160", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000113")]
		public string String
		{
			[Token(Token = "0x6000CC2")]
			[Address(RVA = "0x84A1E4", Offset = "0x84A1E4", VA = "0x84A1E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		public int Integer
		{
			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x84A2F8", Offset = "0x84A2F8", VA = "0x84A2F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000115")]
		public bool Boolean
		{
			[Token(Token = "0x6000CC4")]
			[Address(RVA = "0x84A414", Offset = "0x84A414", VA = "0x84A414")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000116")]
		public float Single
		{
			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x84A530", Offset = "0x84A530", VA = "0x84A530")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000117")]
		public double Double
		{
			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x84A64C", Offset = "0x84A64C", VA = "0x84A64C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000118")]
		public bool IsInteger
		{
			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x84A3B4", Offset = "0x84A3B4", VA = "0x84A3B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000119")]
		public bool IsSingle
		{
			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x84A5EC", Offset = "0x84A5EC", VA = "0x84A5EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		public bool IsDouble
		{
			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x84A708", Offset = "0x84A708", VA = "0x84A708")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public bool IsBoolean
		{
			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x84A4D0", Offset = "0x84A4D0", VA = "0x84A4D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		public bool IsString
		{
			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x84A298", Offset = "0x84A298", VA = "0x84A298")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x8475D0", Offset = "0x8475D0", VA = "0x8475D0")]
		public Cell()
		{
		}

		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x849E90", Offset = "0x849E90", VA = "0x849E90")]
		public Cell(Address address)
		{
		}

		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x849EB8", Offset = "0x849EB8", VA = "0x849EB8")]
		public Cell(string value, Address address)
		{
		}

		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x849EE4", Offset = "0x849EE4", VA = "0x849EE4")]
		public Cell(bool value, Address address)
		{
		}

		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x849F60", Offset = "0x849F60", VA = "0x849F60")]
		public Cell(int value, Address address)
		{
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x849FDC", Offset = "0x849FDC", VA = "0x849FDC")]
		public Cell(long value, Address address)
		{
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x84A058", Offset = "0x84A058", VA = "0x84A058")]
		public Cell(float value, Address address)
		{
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x84A0DC", Offset = "0x84A0DC", VA = "0x84A0DC")]
		public Cell(double value, Address address)
		{
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x84A768", Offset = "0x84A768", VA = "0x84A768", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x84A774", Offset = "0x84A774", VA = "0x84A774", Slot = "4")]
		public Cell DeepClone()
		{
			return null;
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x84A7F4", Offset = "0x84A7F4", VA = "0x84A7F4", Slot = "5")]
		public Cell ShallowClone()
		{
			return null;
		}

		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x84A874", Offset = "0x84A874", VA = "0x84A874")]
		public static implicit operator string(Cell cell)
		{
			return null;
		}

		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x84A884", Offset = "0x84A884", VA = "0x84A884")]
		public static implicit operator int(Cell cell)
		{
			return default(int);
		}

		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x84A894", Offset = "0x84A894", VA = "0x84A894")]
		public static implicit operator bool(Cell cell)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x84A8A4", Offset = "0x84A8A4", VA = "0x84A8A4")]
		public static implicit operator float(Cell cell)
		{
			return default(float);
		}

		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x84A8B4", Offset = "0x84A8B4", VA = "0x84A8B4")]
		public static implicit operator double(Cell cell)
		{
			return default(double);
		}
	}
	[Token(Token = "0x20001DE")]
	public interface ICloneable<T> where T : class
	{
		[Token(Token = "0x6000CD4")]
		T DeepClone();

		[Token(Token = "0x6000CD5")]
		T ShallowClone();
	}
	[Token(Token = "0x20001DF")]
	public struct Range : IEquatable<Range>
	{
		[Token(Token = "0x1700011D")]
		public Address From
		{
			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x84AA3C", Offset = "0x84AA3C", VA = "0x84AA3C")]
			[CompilerGenerated]
			readonly get
			{
				return default(Address);
			}
			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x84AA44", Offset = "0x84AA44", VA = "0x84AA44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public Address To
		{
			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x84AA4C", Offset = "0x84AA4C", VA = "0x84AA4C")]
			[CompilerGenerated]
			readonly get
			{
				return default(Address);
			}
			[Token(Token = "0x6000CDC")]
			[Address(RVA = "0x84AA54", Offset = "0x84AA54", VA = "0x84AA54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x84A8C4", Offset = "0x84A8C4", VA = "0x84A8C4", Slot = "4")]
		public bool Equals(Range other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x84A974", Offset = "0x84A974", VA = "0x84A974", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x84A9EC", Offset = "0x84A9EC", VA = "0x84A9EC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x84AA5C", Offset = "0x84AA5C", VA = "0x84AA5C")]
		public Range(Address from, Address to)
		{
		}

		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x84AAE0", Offset = "0x84AAE0", VA = "0x84AAE0")]
		public Range(string range)
		{
		}

		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x84AC50", Offset = "0x84AC50", VA = "0x84AC50")]
		public bool Contains(Address address)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x84ACA0", Offset = "0x84ACA0", VA = "0x84ACA0")]
		public bool Contains(Range range)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x84ACF0", Offset = "0x84ACF0", VA = "0x84ACF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x84AD98", Offset = "0x84AD98", VA = "0x84AD98")]
		public static bool operator ==(Range range, Range other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x84ADE0", Offset = "0x84ADE0", VA = "0x84ADE0")]
		public static bool operator !=(Range range, Range other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x84AE28", Offset = "0x84AE28", VA = "0x84AE28")]
		public static bool IsValid(string range)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001E0")]
	public class Row : ReadOnlyCollection<Cell>, ICloneable<Row>
	{
		[Token(Token = "0x1700011F")]
		public IList<Cell> Cells
		{
			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x84AE98", Offset = "0x84AE98", VA = "0x84AE98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000120")]
		public Cell this[string address]
		{
			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x84AED4", Offset = "0x84AED4", VA = "0x84AED4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		public Cell this[Address address]
		{
			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x84AF5C", Offset = "0x84AF5C", VA = "0x84AF5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		public IEnumerable<Cell> this[Range range]
		{
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x84B038", Offset = "0x84B038", VA = "0x84B038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x84B118", Offset = "0x84B118", VA = "0x84B118")]
		public Row(IList<Cell> list)
		{
		}

		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x84B170", Offset = "0x84B170", VA = "0x84B170")]
		public Row()
		{
		}

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x84B200", Offset = "0x84B200", VA = "0x84B200", Slot = "34")]
		public Row DeepClone()
		{
			return null;
		}

		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x84B360", Offset = "0x84B360", VA = "0x84B360", Slot = "35")]
		public Row ShallowClone()
		{
			return null;
		}
	}
	[Token(Token = "0x20001E4")]
	public abstract class Table : ReadOnlyCollection<Row>, ICloneable<Table>
	{
		[Token(Token = "0x17000123")]
		public IList<Row> Rows
		{
			[Token(Token = "0x6000CF5")]
			[Address(RVA = "0x84B4FC", Offset = "0x84B4FC", VA = "0x84B4FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		public Cell this[string address]
		{
			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x84B538", Offset = "0x84B538", VA = "0x84B538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000125")]
		public Cell this[Address address]
		{
			[Token(Token = "0x6000CF7")]
			[Address(RVA = "0x84B5C0", Offset = "0x84B5C0", VA = "0x84B5C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		public IEnumerable<Cell> this[Range range]
		{
			[Token(Token = "0x6000CF8")]
			[Address(RVA = "0x84B768", Offset = "0x84B768", VA = "0x84B768")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x84B4A4", Offset = "0x84B4A4", VA = "0x84B4A4")]
		public Table(IList<Row> list)
		{
		}

		[Token(Token = "0x6000CF9")]
		public abstract Table DeepClone();

		[Token(Token = "0x6000CFA")]
		public abstract Table ShallowClone();
	}
	[Token(Token = "0x20001E8")]
	public sealed class Document : Table
	{
		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static char Delimiter;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static char Enclose;

		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x84B9D0", Offset = "0x84B9D0", VA = "0x84B9D0")]
		public Document(IList<Row> list)
		{
		}

		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x84B9D4", Offset = "0x84B9D4", VA = "0x84B9D4")]
		public Document()
		{
		}

		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x84BA4C", Offset = "0x84BA4C", VA = "0x84BA4C")]
		public static Document LoadAt(string path)
		{
			return null;
		}

		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x84BAB4", Offset = "0x84BAB4", VA = "0x84BAB4")]
		public static Document Load(string content)
		{
			return null;
		}

		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x84C330", Offset = "0x84C330", VA = "0x84C330")]
		public static Document Load(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x84C3B8", Offset = "0x84C3B8", VA = "0x84C3B8")]
		public static Document Load(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x84BC70", Offset = "0x84BC70", VA = "0x84BC70")]
		public static Document Load(TextReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x84C574", Offset = "0x84C574", VA = "0x84C574")]
		public static void Reset()
		{
		}

		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x84C5D4", Offset = "0x84C5D4", VA = "0x84C5D4", Slot = "36")]
		public override Table DeepClone()
		{
			return null;
		}

		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x84C734", Offset = "0x84C734", VA = "0x84C734", Slot = "37")]
		public override Table ShallowClone()
		{
			return null;
		}
	}
	[Token(Token = "0x20001EA")]
	public sealed class SharedStringCollection : ReadOnlyCollection<string>
	{
		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x84C884", Offset = "0x84C884", VA = "0x84C884")]
		public SharedStringCollection(IList<string> list)
		{
		}
	}
	[Token(Token = "0x20001EB")]
	public sealed class WorkBook : KeyedCollection<string, WorkSheet>
	{
		[Token(Token = "0x17000127")]
		public SharedStringCollection SharedStrings
		{
			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x84C8DC", Offset = "0x84C8DC", VA = "0x84C8DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x84C8E4", Offset = "0x84C8E4", VA = "0x84C8E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x84C8EC", Offset = "0x84C8EC", VA = "0x84C8EC")]
		public WorkBook(byte[] buffer)
		{
		}

		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x84E45C", Offset = "0x84E45C", VA = "0x84E45C")]
		public WorkBook(Stream stream)
		{
		}

		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x84E4F0", Offset = "0x84E4F0", VA = "0x84E4F0")]
		public WorkBook(string fileName)
		{
		}

		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x84CAD8", Offset = "0x84CAD8", VA = "0x84CAD8")]
		private void Read(ZipFile zip)
		{
		}

		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x84E75C", Offset = "0x84E75C", VA = "0x84E75C", Slot = "38")]
		protected override string GetKeyForItem(WorkSheet item)
		{
			return null;
		}

		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x84E774", Offset = "0x84E774", VA = "0x84E774")]
		public void Merge()
		{
		}
	}
	[Token(Token = "0x20001ED")]
	public sealed class WorkSheet : Table
	{
		[Token(Token = "0x17000128")]
		public string ID
		{
			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0x84F4A0", Offset = "0x84F4A0", VA = "0x84F4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x84F4A8", Offset = "0x84F4A8", VA = "0x84F4A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public string Name
		{
			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0x84F4B0", Offset = "0x84F4B0", VA = "0x84F4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x84F4B8", Offset = "0x84F4B8", VA = "0x84F4B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public ReadOnlyCollection<Range> Spans
		{
			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x84F4C0", Offset = "0x84F4C0", VA = "0x84F4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x84F4C8", Offset = "0x84F4C8", VA = "0x84F4C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x84F4D0", Offset = "0x84F4D0", VA = "0x84F4D0")]
		public WorkSheet(string id, string name, IList<Row> rows)
		{
		}

		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x84E6B4", Offset = "0x84E6B4", VA = "0x84E6B4")]
		public WorkSheet(string id, string name, IList<Row> rows, IList<Range> spans)
		{
		}

		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x84E9F8", Offset = "0x84E9F8", VA = "0x84E9F8")]
		public void Merge()
		{
		}

		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x84F4FC", Offset = "0x84F4FC", VA = "0x84F4FC", Slot = "36")]
		public override Table DeepClone()
		{
			return null;
		}

		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x84F6A4", Offset = "0x84F6A4", VA = "0x84F6A4", Slot = "37")]
		public override Table ShallowClone()
		{
			return null;
		}
	}
	[Token(Token = "0x20001EF")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false)]
	public sealed class ColumnAttribute : Attribute
	{
		[Token(Token = "0x1700012B")]
		public int Column
		{
			[Token(Token = "0x6000D2C")]
			[Address(RVA = "0x84F7BC", Offset = "0x84F7BC", VA = "0x84F7BC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0x84F7C4", Offset = "0x84F7C4", VA = "0x84F7C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public object Default
		{
			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x84F7CC", Offset = "0x84F7CC", VA = "0x84F7CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x84F7D4", Offset = "0x84F7D4", VA = "0x84F7D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public bool Fallback
		{
			[Token(Token = "0x6000D30")]
			[Address(RVA = "0x84F7DC", Offset = "0x84F7DC", VA = "0x84F7DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x84F7E4", Offset = "0x84F7E4", VA = "0x84F7E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x84F7F0", Offset = "0x84F7F0", VA = "0x84F7F0")]
		public ColumnAttribute(int column)
		{
		}

		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x84F818", Offset = "0x84F818", VA = "0x84F818")]
		public ColumnAttribute(int column, object @default)
		{
		}

		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x84F850", Offset = "0x84F850", VA = "0x84F850")]
		public ColumnAttribute(string column)
		{
		}

		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x84F888", Offset = "0x84F888", VA = "0x84F888")]
		public ColumnAttribute(string column, object @default)
		{
		}
	}
	[Token(Token = "0x20001F0")]
	public interface IGenerator
	{
		[Token(Token = "0x6000D36")]
		object Instantiate(Row row);
	}
	[Token(Token = "0x20001F1")]
	public interface IGenerator<T>
	{
		[Token(Token = "0x6000D37")]
		T Instantiate(Row row);
	}
	[Token(Token = "0x20001F2")]
	public interface ITableGenerator
	{
		[Token(Token = "0x6000D38")]
		IEnumerable<object> Instantiate(Table table);
	}
	[Token(Token = "0x20001F3")]
	public interface ITableGenerator<T>
	{
		[Token(Token = "0x6000D39")]
		IEnumerable<T> Instantiate(Table table);
	}
	[Token(Token = "0x20001F4")]
	public sealed class Mapper<T> : MapperBase<Mapper<T>>, IGenerator<T> where T : new()
	{
		[Token(Token = "0x6000D3A")]
		public Mapper()
		{
		}

		[Token(Token = "0x6000D3B")]
		protected override object CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D3C")]
		private T FlexFramework.Excel.IGenerator<T>.Instantiate(Row row)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x20001F5")]
	public sealed class Mapper : MapperBase<Mapper>, IGenerator
	{
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x84F8D0", Offset = "0x84F8D0", VA = "0x84F8D0")]
		public Mapper(Type type)
		{
		}

		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x84F928", Offset = "0x84F928", VA = "0x84F928", Slot = "8")]
		private object FlexFramework.Excel.IGenerator.Instantiate(Row row)
		{
			return null;
		}
	}
	[Token(Token = "0x20001F6")]
	public abstract class MapperBase<T> where T : MapperBase<T>
	{
		[Token(Token = "0x20001F8")]
		[CompilerGenerated]
		private sealed class <Cast>d__11 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MapperBase<T> <>4__this;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Row row;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Row <>3__row;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<Mapping> <>7__wrap1;

			[Token(Token = "0x1700012F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000D5E")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000130")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000D60")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D5A")]
			[DebuggerHidden]
			public <Cast>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000D5B")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D5C")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D5D")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000D5F")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000D61")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000D62")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Mapping[] mappings;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Type type;

		[Token(Token = "0x1700012E")]
		public bool SafeMode
		{
			[Token(Token = "0x6000D3F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000D41")]
		protected MapperBase(Type type)
		{
		}

		[Token(Token = "0x6000D42")]
		protected virtual MemberInfo[] GetMembers()
		{
			return null;
		}

		[Token(Token = "0x6000D43")]
		protected virtual object CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D44")]
		protected virtual void Assign(object obj, MemberInfo[] members, object[] data)
		{
		}

		[Token(Token = "0x6000D45")]
		public virtual void Extract()
		{
		}

		[Token(Token = "0x6000D46")]
		[IteratorStateMachine(typeof(MapperBase<>.<Cast>d__11))]
		protected IEnumerable<object> Cast(Row row)
		{
			return null;
		}

		[Token(Token = "0x6000D47")]
		public T Map(string member, int column)
		{
			return null;
		}

		[Token(Token = "0x6000D48")]
		public T Map(string member, int column, object @default)
		{
			return null;
		}

		[Token(Token = "0x6000D49")]
		public T Map(string member, string column)
		{
			return null;
		}

		[Token(Token = "0x6000D4A")]
		public T Map(string member, string column, object @default)
		{
			return null;
		}

		[Token(Token = "0x6000D4B")]
		public T Map(string expression)
		{
			return null;
		}

		[Token(Token = "0x6000D4C")]
		public T Map(IEnumerable<Cell> row)
		{
			return null;
		}

		[Token(Token = "0x6000D4D")]
		public T Remove(string member)
		{
			return null;
		}

		[Token(Token = "0x6000D4E")]
		public T Clear()
		{
			return null;
		}

		[Token(Token = "0x6000D4F")]
		public T Copy(T mapping)
		{
			return null;
		}

		[Token(Token = "0x6000D50")]
		protected object Instantiate(Row row)
		{
			return null;
		}
	}
	[Token(Token = "0x20001FD")]
	public class Mapping
	{
		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object _default;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _column;

		[Token(Token = "0x17000131")]
		public MemberInfo Member
		{
			[Token(Token = "0x6000D6B")]
			[Address(RVA = "0x84F980", Offset = "0x84F980", VA = "0x84F980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D6C")]
			[Address(RVA = "0x84F988", Offset = "0x84F988", VA = "0x84F988")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public Type Type
		{
			[Token(Token = "0x6000D6D")]
			[Address(RVA = "0x84F990", Offset = "0x84F990", VA = "0x84F990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D6E")]
			[Address(RVA = "0x84F998", Offset = "0x84F998", VA = "0x84F998")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public int Column
		{
			[Token(Token = "0x6000D6F")]
			[Address(RVA = "0x84F9A0", Offset = "0x84F9A0", VA = "0x84F9A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000D70")]
			[Address(RVA = "0x84F9A8", Offset = "0x84F9A8", VA = "0x84F9A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public object Default
		{
			[Token(Token = "0x6000D71")]
			[Address(RVA = "0x84FA18", Offset = "0x84FA18", VA = "0x84FA18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D72")]
			[Address(RVA = "0x84FA20", Offset = "0x84FA20", VA = "0x84FA20")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public bool Fallback
		{
			[Token(Token = "0x6000D73")]
			[Address(RVA = "0x84FAF4", Offset = "0x84FAF4", VA = "0x84FAF4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D74")]
			[Address(RVA = "0x84FAFC", Offset = "0x84FAFC", VA = "0x84FAFC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public bool Failed
		{
			[Token(Token = "0x6000D75")]
			[Address(RVA = "0x84FB08", Offset = "0x84FB08", VA = "0x84FB08")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D76")]
			[Address(RVA = "0x84FB10", Offset = "0x84FB10", VA = "0x84FB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000D77")]
		[Address(RVA = "0x84FB1C", Offset = "0x84FB1C", VA = "0x84FB1C")]
		public Mapping(MemberInfo member)
		{
		}

		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x84FC68", Offset = "0x84FC68", VA = "0x84FC68")]
		public Mapping(MemberInfo member, int column)
		{
		}

		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x84FC90", Offset = "0x84FC90", VA = "0x84FC90")]
		public Mapping(MemberInfo member, int column, object @default)
		{
		}
	}
	[Token(Token = "0x20001FE")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	public sealed class TableAttribute : Attribute
	{
		[Token(Token = "0x17000137")]
		public int[] Ignore
		{
			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0x84FD80", Offset = "0x84FD80", VA = "0x84FD80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0x84FD88", Offset = "0x84FD88", VA = "0x84FD88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public bool SafeMode
		{
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x84FD90", Offset = "0x84FD90", VA = "0x84FD90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x84FD98", Offset = "0x84FD98", VA = "0x84FD98")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x84FDA4", Offset = "0x84FDA4", VA = "0x84FDA4")]
		public TableAttribute(params int[] ignore)
		{
		}
	}
	[Token(Token = "0x20001FF")]
	public sealed class TableMapper<T> : TableMapperBase<TableMapper<T>>, IGenerator<T>, ITableGenerator<T> where T : new()
	{
		[Token(Token = "0x6000D7F")]
		public TableMapper()
		{
		}

		[Token(Token = "0x6000D80")]
		protected override object CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x6000D81")]
		private T FlexFramework.Excel.IGenerator<T>.Instantiate(Row row)
		{
			return (T)null;
		}

		[Token(Token = "0x6000D82")]
		private IEnumerable<T> FlexFramework.Excel.ITableGenerator<T>.Instantiate(Table table)
		{
			return null;
		}
	}
	[Token(Token = "0x2000200")]
	public sealed class TableMapper : TableMapperBase<TableMapper>, IGenerator, ITableGenerator
	{
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x84FDCC", Offset = "0x84FDCC", VA = "0x84FDCC")]
		public TableMapper(Type type)
		{
		}

		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x84FE24", Offset = "0x84FE24", VA = "0x84FE24", Slot = "8")]
		private object FlexFramework.Excel.IGenerator.Instantiate(Row row)
		{
			return null;
		}

		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x84FE7C", Offset = "0x84FE7C", VA = "0x84FE7C", Slot = "9")]
		private IEnumerable<object> FlexFramework.Excel.ITableGenerator.Instantiate(Table table)
		{
			return null;
		}
	}
	[Token(Token = "0x2000201")]
	public abstract class TableMapperBase<T> : MapperBase<T> where T : TableMapperBase<T>
	{
		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly List<int> excludes;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int index;

		[Token(Token = "0x6000D8A")]
		protected TableMapperBase(Type type)
		{
		}

		[Token(Token = "0x6000D8B")]
		public override void Extract()
		{
		}

		[Token(Token = "0x6000D8C")]
		public T Exclude(params int[] rows)
		{
			return null;
		}

		[Token(Token = "0x6000D8D")]
		public T Include(params int[] rows)
		{
			return null;
		}

		[Token(Token = "0x6000D8E")]
		public T IncludeAll()
		{
			return null;
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000203")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x850050", Offset = "0x850050", VA = "0x850050")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x8501EC", Offset = "0x8501EC", VA = "0x8501EC")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x850360", Offset = "0x850360", VA = "0x850360")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x8504D8", Offset = "0x8504D8", VA = "0x8504D8")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x850540", Offset = "0x850540", VA = "0x850540")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x8505A8", Offset = "0x8505A8", VA = "0x8505A8")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x850600", Offset = "0x850600", VA = "0x850600")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x850678", Offset = "0x850678", VA = "0x850678")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x8506D0", Offset = "0x8506D0", VA = "0x8506D0")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x850728", Offset = "0x850728", VA = "0x850728")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x850780", Offset = "0x850780", VA = "0x850780")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x8507D8", Offset = "0x8507D8", VA = "0x8507D8")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x850838", Offset = "0x850838", VA = "0x850838")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x850894", Offset = "0x850894", VA = "0x850894")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x8508EC", Offset = "0x8508EC", VA = "0x8508EC")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000207")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x850A0C", Offset = "0x850A0C", VA = "0x850A0C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x850BB4", Offset = "0x850BB4", VA = "0x850BB4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x850D50", Offset = "0x850D50", VA = "0x850D50")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x850EEC", Offset = "0x850EEC", VA = "0x850EEC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x851088", Offset = "0x851088", VA = "0x851088")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x85122C", Offset = "0x85122C", VA = "0x85122C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x851484", Offset = "0x851484", VA = "0x851484")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x851964", Offset = "0x851964", VA = "0x851964")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x851BC8", Offset = "0x851BC8", VA = "0x851BC8")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x851E38", Offset = "0x851E38", VA = "0x851E38")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x851FFC", Offset = "0x851FFC", VA = "0x851FFC")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000213")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x8525EC", Offset = "0x8525EC", VA = "0x8525EC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x85278C", Offset = "0x85278C", VA = "0x85278C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x852924", Offset = "0x852924", VA = "0x852924")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x852ABC", Offset = "0x852ABC", VA = "0x852ABC")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x852C3C", Offset = "0x852C3C", VA = "0x852C3C")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000219")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x8531F8", Offset = "0x8531F8", VA = "0x8531F8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x853394", Offset = "0x853394", VA = "0x853394")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x853508", Offset = "0x853508", VA = "0x853508")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x8536E4", Offset = "0x8536E4", VA = "0x8536E4")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200021D")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x200021E")]
		public static class Utils
		{
			[Token(Token = "0x6000E19")]
			[Address(RVA = "0x857D70", Offset = "0x857D70", VA = "0x857D70")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x8539C4", Offset = "0x8539C4", VA = "0x8539C4")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x853B38", Offset = "0x853B38", VA = "0x853B38")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x853CD4", Offset = "0x853CD4", VA = "0x853CD4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x853E48", Offset = "0x853E48", VA = "0x853E48")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x853FE4", Offset = "0x853FE4", VA = "0x853FE4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x854158", Offset = "0x854158", VA = "0x854158")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x8542F0", Offset = "0x8542F0", VA = "0x8542F0")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x8544D4", Offset = "0x8544D4", VA = "0x8544D4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x854670", Offset = "0x854670", VA = "0x854670")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x85480C", Offset = "0x85480C", VA = "0x85480C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x8549A8", Offset = "0x8549A8", VA = "0x8549A8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x854B44", Offset = "0x854B44", VA = "0x854B44")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x854CB8", Offset = "0x854CB8", VA = "0x854CB8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x854E3C", Offset = "0x854E3C", VA = "0x854E3C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x854FD8", Offset = "0x854FD8", VA = "0x854FD8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x85516C", Offset = "0x85516C", VA = "0x85516C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x855300", Offset = "0x855300", VA = "0x855300")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x8554A4", Offset = "0x8554A4", VA = "0x8554A4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x85563C", Offset = "0x85563C", VA = "0x85563C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x8557D4", Offset = "0x8557D4", VA = "0x8557D4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x85596C", Offset = "0x85596C", VA = "0x85596C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x855B08", Offset = "0x855B08", VA = "0x855B08")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x855CA4", Offset = "0x855CA4", VA = "0x855CA4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x855E28", Offset = "0x855E28", VA = "0x855E28")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x855FB0", Offset = "0x855FB0", VA = "0x855FB0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x856138", Offset = "0x856138", VA = "0x856138")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x8562D4", Offset = "0x8562D4", VA = "0x8562D4")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x856478", Offset = "0x856478", VA = "0x856478")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x856644", Offset = "0x856644", VA = "0x856644")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x856818", Offset = "0x856818", VA = "0x856818")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x856C24", Offset = "0x856C24", VA = "0x856C24")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x856DB4", Offset = "0x856DB4", VA = "0x856DB4")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x856F34", Offset = "0x856F34", VA = "0x856F34")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x8570B4", Offset = "0x8570B4", VA = "0x8570B4")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x857240", Offset = "0x857240", VA = "0x857240")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x8573DC", Offset = "0x8573DC", VA = "0x8573DC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x857550", Offset = "0x857550", VA = "0x857550")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x857770", Offset = "0x857770", VA = "0x857770")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x857970", Offset = "0x857970", VA = "0x857970")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x857B70", Offset = "0x857B70", VA = "0x857B70")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000246")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x6000E93")]
		[Address(RVA = "0x858C60", Offset = "0x858C60", VA = "0x858C60")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x858E40", Offset = "0x858E40", VA = "0x858E40")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x85902C", Offset = "0x85902C", VA = "0x85902C")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x859114", Offset = "0x859114", VA = "0x859114")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x8591FC", Offset = "0x8591FC", VA = "0x8591FC")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x8592E4", Offset = "0x8592E4", VA = "0x8592E4")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x8593DC", Offset = "0x8593DC", VA = "0x8593DC")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x8594E4", Offset = "0x8594E4", VA = "0x8594E4")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x8595CC", Offset = "0x8595CC", VA = "0x8595CC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x8597C0", Offset = "0x8597C0", VA = "0x8597C0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000249")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x200024A")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000139")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000EA3")]
				[Address(RVA = "0x859A44", Offset = "0x859A44", VA = "0x859A44", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000EA4")]
			[Address(RVA = "0x8590EC", Offset = "0x8590EC", VA = "0x8590EC")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x200024B")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700013A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000EA5")]
				[Address(RVA = "0x859A74", Offset = "0x859A74", VA = "0x859A74", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000EA6")]
			[Address(RVA = "0x8591D4", Offset = "0x8591D4", VA = "0x8591D4")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x200024C")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700013B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000EA7")]
				[Address(RVA = "0x859AD4", Offset = "0x859AD4", VA = "0x859AD4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000EA8")]
			[Address(RVA = "0x8592BC", Offset = "0x8592BC", VA = "0x8592BC")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200024D")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700013C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000EA9")]
				[Address(RVA = "0x859AF0", Offset = "0x859AF0", VA = "0x859AF0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000EAA")]
			[Address(RVA = "0x8593AC", Offset = "0x8593AC", VA = "0x8593AC")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200024E")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700013D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000EAB")]
				[Address(RVA = "0x859B30", Offset = "0x859B30", VA = "0x859B30", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000EAC")]
			[Address(RVA = "0x8594AC", Offset = "0x8594AC", VA = "0x8594AC")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200024F")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700013E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000EAD")]
				[Address(RVA = "0x859B88", Offset = "0x859B88", VA = "0x859B88", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000EAE")]
			[Address(RVA = "0x8595A4", Offset = "0x8595A4", VA = "0x8595A4")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000250")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000251")]
		public static class Physics
		{
			[Token(Token = "0x6000EB1")]
			[Address(RVA = "0x859D18", Offset = "0x859D18", VA = "0x859D18")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000EB2")]
			[Address(RVA = "0x859E18", Offset = "0x859E18", VA = "0x859E18")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000EB3")]
			[Address(RVA = "0x859EA4", Offset = "0x859EA4", VA = "0x859EA4")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000EB4")]
			[Address(RVA = "0x859F30", Offset = "0x859F30", VA = "0x859F30")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x859BBC", Offset = "0x859BBC", VA = "0x859BBC")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x859C70", Offset = "0x859C70", VA = "0x859C70")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x2000252")]
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000253")]
		public enum AnimationType
		{
			[Token(Token = "0x40009FC")]
			None,
			[Token(Token = "0x40009FD")]
			Move,
			[Token(Token = "0x40009FE")]
			LocalMove,
			[Token(Token = "0x40009FF")]
			Rotate,
			[Token(Token = "0x4000A00")]
			LocalRotate,
			[Token(Token = "0x4000A01")]
			Scale,
			[Token(Token = "0x4000A02")]
			Color,
			[Token(Token = "0x4000A03")]
			Fade,
			[Token(Token = "0x4000A04")]
			Text,
			[Token(Token = "0x4000A05")]
			PunchPosition,
			[Token(Token = "0x4000A06")]
			PunchRotation,
			[Token(Token = "0x4000A07")]
			PunchScale,
			[Token(Token = "0x4000A08")]
			ShakePosition,
			[Token(Token = "0x4000A09")]
			ShakeRotation,
			[Token(Token = "0x4000A0A")]
			ShakeScale,
			[Token(Token = "0x4000A0B")]
			CameraAspect,
			[Token(Token = "0x4000A0C")]
			CameraBackgroundColor,
			[Token(Token = "0x4000A0D")]
			CameraFieldOfView,
			[Token(Token = "0x4000A0E")]
			CameraOrthoSize,
			[Token(Token = "0x4000A0F")]
			CameraPixelRect,
			[Token(Token = "0x4000A10")]
			CameraRect,
			[Token(Token = "0x4000A11")]
			UIWidthHeight
		}

		[Token(Token = "0x2000254")]
		public enum TargetType
		{
			[Token(Token = "0x4000A13")]
			Unset,
			[Token(Token = "0x4000A14")]
			Camera,
			[Token(Token = "0x4000A15")]
			CanvasGroup,
			[Token(Token = "0x4000A16")]
			Image,
			[Token(Token = "0x4000A17")]
			Light,
			[Token(Token = "0x4000A18")]
			RectTransform,
			[Token(Token = "0x4000A19")]
			Renderer,
			[Token(Token = "0x4000A1A")]
			SpriteRenderer,
			[Token(Token = "0x4000A1B")]
			Rigidbody,
			[Token(Token = "0x4000A1C")]
			Rigidbody2D,
			[Token(Token = "0x4000A1D")]
			Text,
			[Token(Token = "0x4000A1E")]
			Transform,
			[Token(Token = "0x4000A1F")]
			tk2dBaseSprite,
			[Token(Token = "0x4000A20")]
			tk2dTextMesh,
			[Token(Token = "0x4000A21")]
			TextMeshPro,
			[Token(Token = "0x4000A22")]
			TextMeshProUGUI
		}

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isActive;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isValid;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenCreated;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x1400001D")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x6000EB5")]
			[Address(RVA = "0x85A074", Offset = "0x85A074", VA = "0x85A074")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000EB6")]
			[Address(RVA = "0x85A140", Offset = "0x85A140", VA = "0x85A140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x85A20C", Offset = "0x85A20C", VA = "0x85A20C")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x85A274", Offset = "0x85A274", VA = "0x85A274")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x85B890", Offset = "0x85B890", VA = "0x85B890")]
		private void Start()
		{
		}

		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0x85B8C8", Offset = "0x85B8C8", VA = "0x85B8C8")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x85B8CC", Offset = "0x85B8CC", VA = "0x85B8CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x85A2B8", Offset = "0x85A2B8", VA = "0x85A2B8")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0x85BFB8", Offset = "0x85BFB8", VA = "0x85BFB8", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0x85C024", Offset = "0x85C024", VA = "0x85C024", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x85C090", Offset = "0x85C090", VA = "0x85C090", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x85C0FC", Offset = "0x85C0FC", VA = "0x85C0FC", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x85C168", Offset = "0x85C168", VA = "0x85C168", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x85C1D4", Offset = "0x85C1D4", VA = "0x85C1D4", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x85C2B8", Offset = "0x85C2B8", VA = "0x85C2B8", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x85C2C8", Offset = "0x85C2C8", VA = "0x85C2C8", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x85C614", Offset = "0x85C614", VA = "0x85C614", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x85C684", Offset = "0x85C684", VA = "0x85C684", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x85C6FC", Offset = "0x85C6FC", VA = "0x85C6FC")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x85C778", Offset = "0x85C778", VA = "0x85C778")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x85C7D0", Offset = "0x85C7D0", VA = "0x85C7D0")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x85C828", Offset = "0x85C828", VA = "0x85C828")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x85C8A4", Offset = "0x85C8A4", VA = "0x85C8A4")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x85C8FC", Offset = "0x85C8FC", VA = "0x85C8FC")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x85C978", Offset = "0x85C978", VA = "0x85C978")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x85C9D0", Offset = "0x85C9D0", VA = "0x85C9D0")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x85CB04", Offset = "0x85CB04", VA = "0x85CB04")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x85CB84", Offset = "0x85CB84", VA = "0x85CB84")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x85CBF4", Offset = "0x85CBF4", VA = "0x85CBF4")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x85CC80", Offset = "0x85CC80", VA = "0x85CC80")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x85CCF4", Offset = "0x85CCF4", VA = "0x85CCF4")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x85B91C", Offset = "0x85B91C", VA = "0x85B91C")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x85CE3C", Offset = "0x85CE3C", VA = "0x85CE3C")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x85B904", Offset = "0x85B904", VA = "0x85B904")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x85C3C0", Offset = "0x85C3C0", VA = "0x85C3C0")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x85CE6C", Offset = "0x85CE6C", VA = "0x85CE6C")]
		public DOTweenAnimation()
		{
		}
	}
	[Token(Token = "0x2000255")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000EDA")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000256")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x85D038", Offset = "0x85D038", VA = "0x85D038")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x85D088", Offset = "0x85D088", VA = "0x85D088")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x85D43C", Offset = "0x85D43C", VA = "0x85D43C")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000259")]
	public static class ShortcutExtensionsTMPText
	{
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x85BB1C", Offset = "0x85BB1C", VA = "0x85BB1C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this TMP_Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x85D850", Offset = "0x85D850", VA = "0x85D850")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x85DA20", Offset = "0x85DA20", VA = "0x85DA20")]
		public static TweenerCore<Color, Color, ColorOptions> DOOutlineColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x85DBF0", Offset = "0x85DBF0", VA = "0x85DBF0")]
		public static TweenerCore<Color, Color, ColorOptions> DOGlowColor(this TMP_Text target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x85BCB0", Offset = "0x85BCB0", VA = "0x85BCB0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x85DCE8", Offset = "0x85DCE8", VA = "0x85DCE8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x85DE5C", Offset = "0x85DE5C", VA = "0x85DE5C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x85DFF0", Offset = "0x85DFF0", VA = "0x85DFF0")]
		public static TweenerCore<float, float, FloatOptions> DOFontSize(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x85E164", Offset = "0x85E164", VA = "0x85E164")]
		public static TweenerCore<int, int, NoOptions> DOMaxVisibleCharacters(this TMP_Text target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x85BE1C", Offset = "0x85BE1C", VA = "0x85BE1C")]
		public static TweenerCore<string, string, StringOptions> DOText(this TMP_Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
}
