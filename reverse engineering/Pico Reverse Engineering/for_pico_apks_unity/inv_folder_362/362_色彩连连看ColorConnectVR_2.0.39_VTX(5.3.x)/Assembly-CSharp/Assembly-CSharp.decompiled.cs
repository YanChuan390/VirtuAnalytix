using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Assets.UserReporting.Scripts.Plugin;
using CurvedUI;
using DMS.Scriptables;
using Il2CppDummyDll;
using LIV.SDK.Unity;
using Microsoft.CodeAnalysis;
using StylizedWater;
using TMPro;
using Unity.Cloud.Authorization;
using Unity.Cloud.UserReporting;
using Unity.Cloud.UserReporting.Client;
using Unity.Cloud.UserReporting.Plugin;
using Unity.Cloud.UserReporting.Plugin.SimpleJson.Reflection;
using Unity.Collections;
using Unity.Screenshots;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E0A4", Offset = "0xE4E0A4")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2B2BC28", Offset = "0x2B2BC28", VA = "0x2B2BC28")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E0DC", Offset = "0xE4E0DC")]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2B2E8C8", Offset = "0x2B2E8C8", VA = "0x2B2E8C8")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4E114", Offset = "0xE4E114")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE4E114", Offset = "0xE4E114")]
public class AlphaFlashingText : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xE4FA00", Offset = "0xE4FA00")]
	public List<TextAlpha> textList;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xE4FA38", Offset = "0xE4FA38")]
	public string HelpURL;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string ReportAProblem;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string Patrons;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color[] currentColor;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Text[] thisText;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] chAlpha;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int textCount;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2556E98", Offset = "0x2556E98", VA = "0x2556E98")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x25570C8", Offset = "0x25570C8", VA = "0x25570C8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2557314", Offset = "0x2557314", VA = "0x2557314")]
	public AlphaFlashingText()
	{
	}
}
[Serializable]
[Token(Token = "0x2000005")]
public class TextAlpha
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Text text;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minAlpha;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxAlpha;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timerAlpha;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x16E8858", Offset = "0x16E8858", VA = "0x16E8858")]
	public TextAlpha()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xE4E174", Offset = "0xE4E174")]
public class LineColourProfileCustom : LineColourProfile
{
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2B30EF0", Offset = "0x2B30EF0", VA = "0x2B30EF0")]
	public LineColourProfileCustom()
	{
	}
}
[Token(Token = "0x2000007")]
public class ColourPickerCard : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image image;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color myColor;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2566848", Offset = "0x2566848", VA = "0x2566848")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x25668CC", Offset = "0x25668CC", VA = "0x25668CC")]
	public void PickColour()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x256692C", Offset = "0x256692C", VA = "0x256692C")]
	public ColourPickerCard()
	{
	}
}
[Token(Token = "0x2000008")]
public class CustomLineColour_MonoListener : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LineCustomColour lineCustomColour;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject selectedImage;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image colourImage;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2B25D30", Offset = "0x2B25D30", VA = "0x2B25D30")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2B25EB8", Offset = "0x2B25EB8", VA = "0x2B25EB8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2B2602C", Offset = "0x2B2602C", VA = "0x2B2602C")]
	public void ClickColour()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2B25EB0", Offset = "0x2B25EB0", VA = "0x2B25EB0")]
	private void SelectedCustomColourChanged()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2B261D4", Offset = "0x2B261D4", VA = "0x2B261D4")]
	private void SelectedCustomColourChanged(bool val)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2B262FC", Offset = "0x2B262FC", VA = "0x2B262FC")]
	public CustomLineColour_MonoListener()
	{
	}
}
[Token(Token = "0x2000009")]
public class GameColours : GlobalScriptable
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameColours instance;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LineColourProfile defaultColourProfile;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEvent OnCustomColourChanged;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public BoolVariable customColourSelected;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LineCustomColour selectedCustomColourForChange;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<LineCustomColour> customColours;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2B2C8A0", Offset = "0x2B2C8A0", VA = "0x2B2C8A0", Slot = "5")]
	public override void SoSetStartingValue()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2B2610C", Offset = "0x2B2610C", VA = "0x2B2610C")]
	public void SetSelectedCustomColour(LineCustomColour customColour)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2B2C928", Offset = "0x2B2C928", VA = "0x2B2C928")]
	public void SetCustomColourColour(ColourPickerCard card)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2B2CA18", Offset = "0x2B2CA18", VA = "0x2B2CA18")]
	public void SetLineColoursFromProfile(LineColourProfile colourProfile)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2B2CBAC", Offset = "0x2B2CBAC", VA = "0x2B2CBAC", Slot = "9")]
	public override void Load()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2B2CD9C", Offset = "0x2B2CD9C", VA = "0x2B2CD9C")]
	public GameColours()
	{
	}
}
[Token(Token = "0x200000A")]
public class I_SetMonoColoursFromLineProfile : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool useCustomProfile;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LineColourProfile profileToListenTo;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Image> images;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject loadColoursButton;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2B2DD5C", Offset = "0x2B2DD5C", VA = "0x2B2DD5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2B2E030", Offset = "0x2B2E030", VA = "0x2B2E030")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2B2DE54", Offset = "0x2B2DE54", VA = "0x2B2DE54")]
	public void ColoursChanged()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2B2E120", Offset = "0x2B2E120", VA = "0x2B2E120")]
	public void SaveCurrentMaterialsToProfile()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2B2E328", Offset = "0x2B2E328", VA = "0x2B2E328")]
	public void SetMaterialsFromProfile()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2B2E3B4", Offset = "0x2B2E3B4", VA = "0x2B2E3B4")]
	public I_SetMonoColoursFromLineProfile()
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xE4E184", Offset = "0xE4E184")]
public class LineColourProfile : GlobalScriptableWithID
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool allowOverwriteFromRuntime;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool setAllColoursAsDefault;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color defaultColour;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Color> lineColours;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UnityEvent coloursChanged;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2B2CCDC", Offset = "0x2B2CCDC", VA = "0x2B2CCDC")]
	public void UseThisProfile()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2B2E1EC", Offset = "0x2B2E1EC", VA = "0x2B2E1EC")]
	public void SaveCurrentMaterialsToProfile()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2B30AAC", Offset = "0x2B30AAC", VA = "0x2B30AAC", Slot = "8")]
	public override void Save()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2B30C20", Offset = "0x2B30C20", VA = "0x2B30C20", Slot = "9")]
	public override void Load()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2B30E00", Offset = "0x2B30E00", VA = "0x2B30E00")]
	public LineColourProfile()
	{
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xE4E194", Offset = "0xE4E194")]
public class LineCustomColour : GlobalScriptableWithID
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color colour;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material material;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2B30EF4", Offset = "0x2B30EF4", VA = "0x2B30EF4")]
	public void SelectForColourChange()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2B2C9D0", Offset = "0x2B2C9D0", VA = "0x2B2C9D0")]
	public void SetColour(Color _colour)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2B30F50", Offset = "0x2B30F50", VA = "0x2B30F50", Slot = "8")]
	public override void Save()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2B30FF0", Offset = "0x2B30FF0", VA = "0x2B30FF0", Slot = "9")]
	public override void Load()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2B310EC", Offset = "0x2B310EC", VA = "0x2B310EC")]
	public LineCustomColour()
	{
	}
}
[Token(Token = "0x200000D")]
public class SelectCustomLineColourForChange : MonoBehaviour
{
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2C1FF58", Offset = "0x2C1FF58", VA = "0x2C1FF58")]
	public SelectCustomLineColourForChange()
	{
	}
}
[Token(Token = "0x200000E")]
public class SetWaterObjectForPlanarReflections : MonoBehaviour
{
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObjectVariable reflections;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PlanarReflections planerReflections;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2C2080C", Offset = "0x2C2080C", VA = "0x2C2080C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2C2091C", Offset = "0x2C2091C", VA = "0x2C2091C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2C20900", Offset = "0x2C20900", VA = "0x2C20900")]
	private void Changed(GameObject arg0, Vector3 arg1, Vector3 arg2)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2C209E0", Offset = "0x2C209E0", VA = "0x2C209E0")]
	public SetWaterObjectForPlanarReflections()
	{
	}
}
[Token(Token = "0x200000F")]
public class AnimatePostProcessing : MonoBehaviour
{
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E1A4", Offset = "0xE4E1A4")]
	private sealed class <AdjustWeight>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimatePostProcessing <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x16F63D0", Offset = "0x16F63D0", VA = "0x16F63D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x16F6418", Offset = "0x16F6418", VA = "0x16F6418", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x16F625C", Offset = "0x16F625C", VA = "0x16F625C")]
		[DebuggerHidden]
		public <AdjustWeight>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x16F6288", Offset = "0x16F6288", VA = "0x16F6288", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x16F628C", Offset = "0x16F628C", VA = "0x16F628C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x16F63D8", Offset = "0x16F63D8", VA = "0x16F63D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameCondition conToHide;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Volume vProfile;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float targetWeight;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE4FA70", Offset = "0xE4FA70")]
	public float adjustSpeed;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator adjustWeightRoutine;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2557ED0", Offset = "0x2557ED0", VA = "0x2557ED0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2557F94", Offset = "0x2557F94", VA = "0x2557F94")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2557F90", Offset = "0x2557F90", VA = "0x2557F90")]
	private void ConChanged(bool val)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x255803C", Offset = "0x255803C", VA = "0x255803C")]
	private void CheckList()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2558080", Offset = "0x2558080", VA = "0x2558080")]
	private void SetWeightAndStartRoutine(float weight)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x25580DC", Offset = "0x25580DC", VA = "0x25580DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5152C", Offset = "0xE5152C")]
	private IEnumerator AdjustWeight()
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2558154", Offset = "0x2558154", VA = "0x2558154")]
	public AnimatePostProcessing()
	{
	}
}
[Token(Token = "0x2000011")]
public class CUI_MoveAlong : MonoBehaviour
{
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2560760", Offset = "0x2560760", VA = "0x2560760")]
	private void Start()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2560764", Offset = "0x2560764", VA = "0x2560764")]
	private void Update()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x256098C", Offset = "0x256098C", VA = "0x256098C")]
	public CUI_MoveAlong()
	{
	}
}
[Token(Token = "0x2000012")]
public class CUI_MoveHeartbeat : MonoBehaviour
{
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool wrapAroundParent;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rectie;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform parentRectie;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2560994", Offset = "0x2560994", VA = "0x2560994")]
	private void Start()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2560A54", Offset = "0x2560A54", VA = "0x2560A54")]
	private void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2560B78", Offset = "0x2560B78", VA = "0x2560B78")]
	public CUI_MoveHeartbeat()
	{
	}
}
[Token(Token = "0x2000013")]
public class CUI_ShowParentCoordinates : MonoBehaviour
{
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x25614C0", Offset = "0x25614C0", VA = "0x25614C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2561594", Offset = "0x2561594", VA = "0x2561594")]
	private void Update()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2561598", Offset = "0x2561598", VA = "0x2561598")]
	public CUI_ShowParentCoordinates()
	{
	}
}
[Token(Token = "0x2000014")]
public class CUI_rotation_anim : MonoBehaviour
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 Rotation;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2562270", Offset = "0x2562270", VA = "0x2562270")]
	private void Start()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2562274", Offset = "0x2562274", VA = "0x2562274")]
	private void Update()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x256245C", Offset = "0x256245C", VA = "0x256245C")]
	public CUI_rotation_anim()
	{
	}
}
[Token(Token = "0x2000015")]
public class CUI_touchpad : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform container;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform dot;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2562464", Offset = "0x2562464", VA = "0x2562464")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x25624D8", Offset = "0x25624D8", VA = "0x25624D8")]
	private void MoveDotOnTouchpadAxisChanged(object o, ViveInputArgs args)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2562598", Offset = "0x2562598", VA = "0x2562598")]
	public CUI_touchpad()
	{
	}
}
[Token(Token = "0x2000016")]
[ExecuteInEditMode]
public class CurvedUIInputModule : BaseInputModule
{
	[Token(Token = "0x2000017")]
	public enum CUIControlMethod
	{
		[Token(Token = "0x4000053")]
		MOUSE = 0,
		[Token(Token = "0x4000054")]
		GAZE = 1,
		[Token(Token = "0x4000055")]
		WORLD_MOUSE = 2,
		[Token(Token = "0x4000056")]
		CUSTOM_RAY = 3,
		[Token(Token = "0x4000057")]
		STEAMVR_LEGACY = 4,
		[Token(Token = "0x4000058")]
		OCULUSVR = 5,
		[Token(Token = "0x4000059")]
		STEAMVR_2 = 8,
		[Token(Token = "0x400005A")]
		UNITY_XR = 9
	}

	[Token(Token = "0x2000018")]
	public enum Hand
	{
		[Token(Token = "0x400005C")]
		Both,
		[Token(Token = "0x400005D")]
		Right,
		[Token(Token = "0x400005E")]
		Left
	}

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private CUIControlMethod controlMethod;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private string submitButtonName;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Camera mainEventCamera;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private LayerMask raycastLayerMask;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private bool gazeUseTimedClick;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float gazeClickTimer;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float gazeClickTimerDelay;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image gazeTimedClickProgressImage;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float worldSpaceMouseSensitivity;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private Hand usedHand;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Transform pointerTransformOverride;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool disableOtherInputModulesOnStart;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static CurvedUIInputModule instance;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject currentDragging;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject currentPointedAt;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject m_rightController;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject m_leftController;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float gazeTimerProgress;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Ray customControllerRay;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float dragThreshold;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool pressedDown;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	private bool pressedLastFrame;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector2 lastEventDataPosition;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private PointerInputModule.MouseButtonEventData storedData;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Vector3 lastMouseOnScreenPos;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Vector2 worldSpaceMouseInCanvasSpace;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private Vector2 lastWorldSpaceMouseOnCanvas;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private Vector2 worldSpaceMouseOnCanvasDelta;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private XRBaseController rightXRController;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[SerializeField]
	private XRBaseController leftXRController;

	[Token(Token = "0x17000003")]
	public static CurvedUIInputModule Instance
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1B463C4", Offset = "0x1B463C4", VA = "0x1B463C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1B464DC", Offset = "0x1B464DC", VA = "0x1B464DC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public static bool CanInstanceBeAccessed
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1B46548", Offset = "0x1B46548", VA = "0x1B46548")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000005")]
	public static CUIControlMethod ControlMethod
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1B441F8", Offset = "0x1B441F8", VA = "0x1B441F8")]
		get
		{
			return default(CUIControlMethod);
		}
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1B465E4", Offset = "0x1B465E4", VA = "0x1B465E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public LayerMask RaycastLayerMask
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1B4667C", Offset = "0x1B4667C", VA = "0x1B4667C")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1B46684", Offset = "0x1B46684", VA = "0x1B46684")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public Hand UsedHand
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1B4668C", Offset = "0x1B4668C", VA = "0x1B4668C")]
		get
		{
			return default(Hand);
		}
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1B46694", Offset = "0x1B46694", VA = "0x1B46694")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Transform ControllerTransform
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1B4606C", Offset = "0x1B4606C", VA = "0x1B4606C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	public Vector3 ControllerPointingDirection
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1B4670C", Offset = "0x1B4670C", VA = "0x1B4670C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700000A")]
	public Vector3 ControllerPointingOrigin
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1B4672C", Offset = "0x1B4672C", VA = "0x1B4672C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700000B")]
	public Transform PointerTransformOverride
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1B4669C", Offset = "0x1B4669C", VA = "0x1B4669C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1B4674C", Offset = "0x1B4674C", VA = "0x1B4674C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public GameObject CurrentPointedAt
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1B467C4", Offset = "0x1B467C4", VA = "0x1B467C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	public Camera EventCamera
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1B467CC", Offset = "0x1B467CC", VA = "0x1B467CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1B4413C", Offset = "0x1B4413C", VA = "0x1B4413C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public static Vector2 MousePosition
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1B46A50", Offset = "0x1B46A50", VA = "0x1B46A50")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700000F")]
	public static bool LeftMouseButton
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1B46B50", Offset = "0x1B46B50", VA = "0x1B46B50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000010")]
	public static Ray CustomControllerRay
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1B46AD8", Offset = "0x1B46AD8", VA = "0x1B46AD8")]
		get
		{
			return default(Ray);
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1B46118", Offset = "0x1B46118", VA = "0x1B46118")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public static bool CustomControllerButtonState
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1B46BB0", Offset = "0x1B46BB0", VA = "0x1B46BB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1B45FFC", Offset = "0x1B45FFC", VA = "0x1B45FFC")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE52E84", Offset = "0xE52E84")]
	public static bool CustomControllerButtonDown
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1B46C18", Offset = "0x1B46C18", VA = "0x1B46C18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1B46C70", Offset = "0x1B46C70", VA = "0x1B46C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public Vector2 WorldSpaceMouseInCanvasSpace
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1B46CD0", Offset = "0x1B46CD0", VA = "0x1B46CD0")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1B46CD8", Offset = "0x1B46CD8", VA = "0x1B46CD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public Vector2 WorldSpaceMouseInCanvasSpaceDelta
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1B46CE4", Offset = "0x1B46CE4", VA = "0x1B46CE4")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000015")]
	public float WorldSpaceMouseSensitivity
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1B46CF8", Offset = "0x1B46CF8", VA = "0x1B46CF8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1B46D00", Offset = "0x1B46D00", VA = "0x1B46D00")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public bool GazeUseTimedClick
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1B46D08", Offset = "0x1B46D08", VA = "0x1B46D08")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1B46D10", Offset = "0x1B46D10", VA = "0x1B46D10")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public float GazeClickTimer
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1B46D1C", Offset = "0x1B46D1C", VA = "0x1B46D1C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1B46D24", Offset = "0x1B46D24", VA = "0x1B46D24")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public float GazeClickTimerDelay
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1B46D50", Offset = "0x1B46D50", VA = "0x1B46D50")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1B46D58", Offset = "0x1B46D58", VA = "0x1B46D58")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public float GazeTimerProgress
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1B46D84", Offset = "0x1B46D84", VA = "0x1B46D84")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700001A")]
	public Image GazeTimedClickProgressImage
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1B46D8C", Offset = "0x1B46D8C", VA = "0x1B46D8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1B46D94", Offset = "0x1B46D94", VA = "0x1B46D94")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public XRBaseController RightXRController
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1B46D9C", Offset = "0x1B46D9C", VA = "0x1B46D9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1B46DA4", Offset = "0x1B46DA4", VA = "0x1B46DA4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public XRBaseController LeftXRController
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1B46DB4", Offset = "0x1B46DB4", VA = "0x1B46DB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1B46DBC", Offset = "0x1B46DBC", VA = "0x1B46DBC")]
		set
		{
		}
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1B43F94", Offset = "0x1B43F94", VA = "0x1B43F94", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1B44444", Offset = "0x1B44444", VA = "0x1B44444", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1B44480", Offset = "0x1B44480", VA = "0x1B44480", Slot = "26")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1B44260", Offset = "0x1B44260", VA = "0x1B44260")]
	private void SetupUnityXrControllers()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1B446B8", Offset = "0x1B446B8", VA = "0x1B446B8", Slot = "17")]
	public override void Process()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1B4484C", Offset = "0x1B4484C", VA = "0x1B4484C")]
	protected PointerInputModule.MouseButtonEventData GetEventData()
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1B44AE4", Offset = "0x1B44AE4", VA = "0x1B44AE4")]
	private void ProcessMove(PointerEventData eventData, GameObject currentRaycastTarget)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1B45128", Offset = "0x1B45128", VA = "0x1B45128")]
	private void ProcessButton(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1B45888", Offset = "0x1B45888", VA = "0x1B45888")]
	private void ProcessDrag(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1B45B94", Offset = "0x1B45B94", VA = "0x1B45B94")]
	private static void ProcessScroll(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1B45CC0", Offset = "0x1B45CC0", VA = "0x1B45CC0")]
	private void ProcessUnityXrController()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1B461A8", Offset = "0x1B461A8", VA = "0x1B461A8", Slot = "27")]
	protected virtual void ProcessMouseController()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1B462F4", Offset = "0x1B462F4", VA = "0x1B462F4", Slot = "28")]
	protected virtual void ProcessCustomRayController()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1B462F8", Offset = "0x1B462F8", VA = "0x1B462F8", Slot = "29")]
	protected virtual void ProcessGaze()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1B45E2C", Offset = "0x1B45E2C", VA = "0x1B45E2C")]
	public void GetXrControllerButtonState(ref bool pressed, Hand checkHand)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1B45E00", Offset = "0x1B45E00", VA = "0x1B45E00")]
	private PointerEventData.FramePressState CustomRayFramePressedState()
	{
		return default(PointerEventData.FramePressState);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1B463B8", Offset = "0x1B463B8", VA = "0x1B463B8", Slot = "30")]
	protected virtual void ProcessViveControllers()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1B463BC", Offset = "0x1B463BC", VA = "0x1B463BC", Slot = "31")]
	protected virtual void ProcessOculusVRController()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1B463C0", Offset = "0x1B463C0", VA = "0x1B463C0")]
	private void ProcessSteamVR2Controllers()
	{
	}

	[Token(Token = "0x600005B")]
	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1B467D4", Offset = "0x1B467D4", VA = "0x1B467D4")]
	public Ray GetEventRay([Optional] Camera eventCam)
	{
		return default(Ray);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1B46DCC", Offset = "0x1B46DCC", VA = "0x1B46DCC")]
	public CurvedUIInputModule()
	{
	}
}
[Token(Token = "0x2000019")]
public class SetLivPos : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LIV.SDK.Unity.LIV liv;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform toCopy;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int vFov;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2C206F8", Offset = "0x2C206F8", VA = "0x2C206F8")]
	private void Update()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2C207A0", Offset = "0x2C207A0", VA = "0x2C207A0")]
	public SetLivPos()
	{
	}
}
[Token(Token = "0x200001A")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Token(Token = "0x1700001D")]
	public static bool Initialized
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2C26F48", Offset = "0x2C26F48", VA = "0x2C26F48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2C26F50", Offset = "0x2C26F50", VA = "0x2C26F50")]
	public SteamManager()
	{
	}
}
[Token(Token = "0x200001B")]
public class SetLocalBoolIfIntOverZero : MonoBehaviour
{
	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int value;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LocalBoolVariable localBool;

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2C207A8", Offset = "0x2C207A8", VA = "0x2C207A8")]
	public void Add()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2C207F4", Offset = "0x2C207F4", VA = "0x2C207F4")]
	public void Remove()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2C207B8", Offset = "0x2C207B8", VA = "0x2C207B8")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2C20804", Offset = "0x2C20804", VA = "0x2C20804")]
	public SetLocalBoolIfIntOverZero()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4E1D4", Offset = "0xE4E1D4")]
public class BuoyantObject : MonoBehaviour
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Color red;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color green;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color blue;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color orange;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float steepness;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float wavelength;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float speed;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float[] directions;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xE4FB68", Offset = "0xE4FB68")]
	public StylizedWaterURP water;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE4FBA0", Offset = "0xE4FBA0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xE4FBA0", Offset = "0xE4FBA0")]
	public float strength;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE4FBF4", Offset = "0xE4FBF4")]
	public float objectDepth;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float velocityDrag;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float angularDrag;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xE4FC10", Offset = "0xE4FC10")]
	public Transform[] effectors;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Rigidbody rb;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3[] effectorProjections;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x255EAAC", Offset = "0x255EAAC", VA = "0x255EAAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x255EC20", Offset = "0x255EC20", VA = "0x255EC20")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x255EC40", Offset = "0x255EC40", VA = "0x255EC40")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x255EEE0", Offset = "0x255EEE0", VA = "0x255EEE0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x255F19C", Offset = "0x255F19C", VA = "0x255F19C")]
	public BuoyantObject()
	{
	}
}
[Token(Token = "0x200001D")]
public class FramerateMonitor : UserReportingMonitor
{
	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float duration;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float MaximumDurationInSeconds;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float MinimumFramerate;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2B2C804", Offset = "0x2B2C804", VA = "0x2B2C804")]
	public FramerateMonitor()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2B2C834", Offset = "0x2B2C834", VA = "0x2B2C834")]
	private void Update()
	{
	}
}
[Token(Token = "0x200001E")]
public class UserReportingConfigureOnly : MonoBehaviour
{
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x16F21EC", Offset = "0x16F21EC", VA = "0x16F21EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x16F220C", Offset = "0x16F220C", VA = "0x16F220C")]
	public UserReportingConfigureOnly()
	{
	}
}
[Token(Token = "0x200001F")]
public class UserReportingMonitor : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E234", Offset = "0xE4E234")]
	private sealed class <>c
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<UserReportScreenshot> <>9__7_0;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<UserReportScreenshot> <>9__7_1;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x16F9C10", Offset = "0x16F9C10", VA = "0x16F9C10")]
		public <>c()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x16F9C18", Offset = "0x16F9C18", VA = "0x16F9C18")]
		internal void <Trigger>b__7_0(UserReportScreenshot s)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x16F9C1C", Offset = "0x16F9C1C", VA = "0x16F9C1C")]
		internal void <Trigger>b__7_1(UserReportScreenshot s)
		{
		}
	}

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool IsEnabled;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool IsEnabledAfterTrigger;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool IsHiddenWithoutDimension;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string MonitorName;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string Summary;

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x16F2214", Offset = "0x16F2214", VA = "0x16F2214")]
	public UserReportingMonitor()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x16F2270", Offset = "0x16F2270", VA = "0x16F2270")]
	private void Start()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x16F2290", Offset = "0x16F2290", VA = "0x16F2290")]
	public void Trigger()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x16F250C", Offset = "0x16F250C", VA = "0x16F250C", Slot = "4")]
	protected virtual void Triggered()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x16F2510", Offset = "0x16F2510", VA = "0x16F2510")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE515DC", Offset = "0xE515DC")]
	private void <Trigger>b__7_2(UserReport br)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x16F2900", Offset = "0x16F2900", VA = "0x16F2900")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE515EC", Offset = "0xE515EC")]
	private void <Trigger>b__7_3(bool success, UserReport br2)
	{
	}
}
[Serializable]
[Token(Token = "0x2000021")]
public enum UserReportingPlatformType
{
	[Token(Token = "0x4000080")]
	Default,
	[Token(Token = "0x4000081")]
	Async
}
[Token(Token = "0x2000022")]
public class UserReportingScript : MonoBehaviour
{
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E244", Offset = "0xE4E244")]
	private sealed class <ClearError>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UserReportingScript <>4__this;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x16F9D54", Offset = "0x16F9D54", VA = "0x16F9D54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x16F9D9C", Offset = "0x16F9D9C", VA = "0x16F9D9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x16F2ADC", Offset = "0x16F2ADC", VA = "0x16F2ADC")]
		[DebuggerHidden]
		public <ClearError>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x16F9C9C", Offset = "0x16F9C9C", VA = "0x16F9C9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x16F9CA0", Offset = "0x16F9CA0", VA = "0x16F9CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x16F9D5C", Offset = "0x16F9D5C", VA = "0x16F9D5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E254", Offset = "0xE4E254")]
	private sealed class <>c
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<UserReportScreenshot> <>9__29_0;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<UserReportScreenshot> <>9__29_1;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<float, float> <>9__33_0;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action<bool, byte[]> <>9__33_1;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x16F9C84", Offset = "0x16F9C84", VA = "0x16F9C84")]
		public <>c()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x16F9C8C", Offset = "0x16F9C8C", VA = "0x16F9C8C")]
		internal void <CreateUserReport>b__29_0(UserReportScreenshot s)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x16F9C90", Offset = "0x16F9C90", VA = "0x16F9C90")]
		internal void <CreateUserReport>b__29_1(UserReportScreenshot s)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x16F9C94", Offset = "0x16F9C94", VA = "0x16F9C94")]
		internal void <Start>b__33_0(float upload, float download)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x16F9C98", Offset = "0x16F9C98", VA = "0x16F9C98")]
		internal void <Start>b__33_1(bool result, byte[] bytes)
		{
		}
	}

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FC48", Offset = "0xE4FC48")]
	public Dropdown CategoryDropdown;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FC80", Offset = "0xE4FC80")]
	public InputField DescriptionInput;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FCB8", Offset = "0xE4FCB8")]
	public Canvas ErrorPopup;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isCreatingUserReport;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FCF0", Offset = "0xE4FCF0")]
	public bool IsHotkeyEnabled;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FD28", Offset = "0xE4FD28")]
	public bool IsInSilentMode;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FD60", Offset = "0xE4FD60")]
	public bool IsSelfReporting;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool isShowingError;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool isSubmitting;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FD98", Offset = "0xE4FD98")]
	public Text ProgressText;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FDD0", Offset = "0xE4FDD0")]
	public bool SendEventsToAnalytics;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FE08", Offset = "0xE4FE08")]
	public Canvas SubmittingPopup;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FE40", Offset = "0xE4FE40")]
	public InputField SummaryInput;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FE78", Offset = "0xE4FE78")]
	public Image ThumbnailViewer;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private UnityUserReportingUpdater unityUserReportingUpdater;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FEB0", Offset = "0xE4FEB0")]
	public Button UserReportButton;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FEE8", Offset = "0xE4FEE8")]
	public Canvas UserReportForm;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FF20", Offset = "0xE4FF20")]
	public UserReportingPlatformType UserReportingPlatform;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE4FF58", Offset = "0xE4FF58")]
	public UnityEvent UserReportSubmitting;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4FF90", Offset = "0xE4FF90")]
	private UserReport <CurrentUserReport>k__BackingField;

	[Token(Token = "0x1700001E")]
	public UserReport CurrentUserReport
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x16F29B0", Offset = "0x16F29B0", VA = "0x16F29B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE515FC", Offset = "0xE515FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x16F29B8", Offset = "0x16F29B8", VA = "0x16F29B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5160C", Offset = "0xE5160C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public UserReportingState State
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x16F29C0", Offset = "0x16F29C0", VA = "0x16F29C0")]
		get
		{
			return default(UserReportingState);
		}
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x16F290C", Offset = "0x16F290C", VA = "0x16F290C")]
	public UserReportingScript()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x16F29F4", Offset = "0x16F29F4", VA = "0x16F29F4")]
	public void CancelUserReport()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x16F2A64", Offset = "0x16F2A64", VA = "0x16F2A64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5161C", Offset = "0xE5161C")]
	private IEnumerator ClearError()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x16F2A20", Offset = "0x16F2A20", VA = "0x16F2A20")]
	private void ClearForm()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x16F2B08", Offset = "0x16F2B08", VA = "0x16F2B08")]
	public void CreateUserReport()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x16F2D9C", Offset = "0x16F2D9C", VA = "0x16F2D9C")]
	private UserReportingClientConfiguration GetConfiguration()
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x16F2E00", Offset = "0x16F2E00", VA = "0x16F2E00")]
	public bool IsSubmitting()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x16F2E08", Offset = "0x16F2E08", VA = "0x16F2E08")]
	private void SetThumbnail(UserReport userReport)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x16F2FAC", Offset = "0x16F2FAC", VA = "0x16F2FAC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x16F3460", Offset = "0x16F3460", VA = "0x16F3460")]
	public void SubmitUserReport()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x16F37F4", Offset = "0x16F37F4", VA = "0x16F37F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x16F3A64", Offset = "0x16F3A64", VA = "0x16F3A64", Slot = "4")]
	protected virtual void RaiseUserReportSubmitting()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x16F3A78", Offset = "0x16F3A78", VA = "0x16F3A78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5167C", Offset = "0xE5167C")]
	private void <CreateUserReport>b__29_2(UserReport br)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x16F3E90", Offset = "0x16F3E90", VA = "0x16F3E90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5168C", Offset = "0xE5168C")]
	private void <SubmitUserReport>b__34_0(float uploadProgress, float downloadProgress)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x16F3F80", Offset = "0x16F3F80", VA = "0x16F3F80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5169C", Offset = "0xE5169C")]
	private void <SubmitUserReport>b__34_1(bool success, UserReport br2)
	{
	}
}
[Token(Token = "0x2000025")]
public enum UserReportingState
{
	[Token(Token = "0x400009F")]
	Idle,
	[Token(Token = "0x40000A0")]
	CreatingUserReport,
	[Token(Token = "0x40000A1")]
	ShowingForm,
	[Token(Token = "0x40000A2")]
	SubmittingForm
}
[Token(Token = "0x2000026")]
public class UserReportingXRExtensions : MonoBehaviour
{
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x16F3FD4", Offset = "0x16F3FD4", VA = "0x16F3FD4")]
	private static bool XRIsPresent()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x16F4198", Offset = "0x16F4198", VA = "0x16F4198")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x16F4210", Offset = "0x16F4210", VA = "0x16F4210")]
	private void Update()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x16F430C", Offset = "0x16F430C", VA = "0x16F430C")]
	public UserReportingXRExtensions()
	{
	}
}
[Token(Token = "0x2000027")]
public class VersionNumberToText : MonoBehaviour
{
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI textMesh;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x16F4818", Offset = "0x16F4818", VA = "0x16F4818")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x16F4894", Offset = "0x16F4894", VA = "0x16F4894")]
	public VersionNumberToText()
	{
	}
}
[Token(Token = "0x2000028")]
public class VarietySceneSelect : MonoBehaviour
{
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x16F4314", Offset = "0x16F4314", VA = "0x16F4314")]
	public void LoadSceneDemo1()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x16F4388", Offset = "0x16F4388", VA = "0x16F4388")]
	public void LoadSceneDemo2()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x16F43FC", Offset = "0x16F43FC", VA = "0x16F43FC")]
	public void LoadSceneDemo3()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x16F4470", Offset = "0x16F4470", VA = "0x16F4470")]
	public void LoadSceneDemo4()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x16F44E4", Offset = "0x16F44E4", VA = "0x16F44E4")]
	public void LoadSceneDemo5()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x16F4558", Offset = "0x16F4558", VA = "0x16F4558")]
	public void LoadSceneDemo6()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x16F45CC", Offset = "0x16F45CC", VA = "0x16F45CC")]
	public void LoadSceneDemo7()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x16F4640", Offset = "0x16F4640", VA = "0x16F4640")]
	public void LoadSceneDemo8()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x16F46B4", Offset = "0x16F46B4", VA = "0x16F46B4")]
	public void LoadSceneDemo9()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x16F4728", Offset = "0x16F4728", VA = "0x16F4728")]
	public void LoadSceneDemo10()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x16F479C", Offset = "0x16F479C", VA = "0x16F479C")]
	public void LoadSceneDemo11()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x16F4810", Offset = "0x16F4810", VA = "0x16F4810")]
	public VarietySceneSelect()
	{
	}
}
[Token(Token = "0x2000029")]
public class FlickerLight : MonoBehaviour
{
	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float MinLightIntensity;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MaxLightIntensity;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float AccelerateTime;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float _targetIntensity;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _lastIntensity;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _timePassed;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light _lt;

	[Token(Token = "0x40000AB")]
	private const double Tolerance = 0.0001;

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2B2C6AC", Offset = "0x2B2C6AC", VA = "0x2B2C6AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2B2C728", Offset = "0x2B2C728", VA = "0x2B2C728")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x2B2C7E8", Offset = "0x2B2C7E8", VA = "0x2B2C7E8")]
	public FlickerLight()
	{
	}
}
[Token(Token = "0x200002A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4E264", Offset = "0xE4E264")]
public class UVOffset : MonoBehaviour
{
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float scrollSpeed;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool scrollY;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshRenderer renderer;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x16EA480", Offset = "0x16EA480", VA = "0x16EA480")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x16EA4DC", Offset = "0x16EA4DC", VA = "0x16EA4DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x16EA570", Offset = "0x16EA570", VA = "0x16EA570")]
	public UVOffset()
	{
	}
}
namespace DistantLands
{
	[Token(Token = "0x200002B")]
	public class Fish : MonoBehaviour
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float speed;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float averageSpeed;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 averageHeading;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 averagePosition;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float neighborDistance;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int performance;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public GlobalFlock flock;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool turning;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2B2BC30", Offset = "0x2B2BC30", VA = "0x2B2BC30")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2B2BC68", Offset = "0x2B2BC68", VA = "0x2B2BC68")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2B2BE90", Offset = "0x2B2BE90", VA = "0x2B2BE90")]
		private void ApplyTankBoundary()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2B2BF78", Offset = "0x2B2BF78", VA = "0x2B2BF78")]
		private void ApplyRules()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2B2BF3C", Offset = "0x2B2BF3C", VA = "0x2B2BF3C")]
		private float TurnSpeed()
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2B2C4A4", Offset = "0x2B2C4A4", VA = "0x2B2C4A4")]
		public Fish()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class GlobalFlock : MonoBehaviour
	{
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] fishPrefabs;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject fishSchool;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float wanderSize;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject target;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int numFish;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public List<GameObject> allFish;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Vector3 goalPos;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2B2D0CC", Offset = "0x2B2D0CC", VA = "0x2B2D0CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2B2D35C", Offset = "0x2B2D35C", VA = "0x2B2D35C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2B2D360", Offset = "0x2B2D360", VA = "0x2B2D360")]
		private void HandleGoalPos()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2B2D430", Offset = "0x2B2D430", VA = "0x2B2D430")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2B2D480", Offset = "0x2B2D480", VA = "0x2B2D480")]
		public GlobalFlock()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class MoveFishSchool : MonoBehaviour
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float moveRange;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float moveSpeed;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 positionChangeSpeed;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _time;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 _originalPos;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 _newPos;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform target;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2B31810", Offset = "0x2B31810", VA = "0x2B31810")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2B31874", Offset = "0x2B31874", VA = "0x2B31874")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2B31994", Offset = "0x2B31994", VA = "0x2B31994")]
		public MoveFishSchool()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class WaypointSystem : MonoBehaviour
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform objectToMove;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float moveSpeed;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float turnSpeed;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform target;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int progress;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> waypoints;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x16F5810", Offset = "0x16F5810", VA = "0x16F5810")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x16F5910", Offset = "0x16F5910", VA = "0x16F5910")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x16F5B1C", Offset = "0x16F5B1C", VA = "0x16F5B1C")]
		public void NextPoint()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x16F5BC0", Offset = "0x16F5BC0", VA = "0x16F5BC0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x16F5D8C", Offset = "0x16F5D8C", VA = "0x16F5D8C")]
		public WaypointSystem()
		{
		}
	}
}
namespace Assets.UserReporting.Scripts.Plugin
{
	[Token(Token = "0x200002F")]
	public interface ILogListener
	{
		[Token(Token = "0x60000EF")]
		void ReceiveLogMessage(string logString, string stackTrace, LogType logType);
	}
	[Token(Token = "0x2000030")]
	public static class LogDispatcher
	{
		[Serializable]
		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E2C4", Offset = "0xE4E2C4")]
		private sealed class <>c
		{
			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x16F6E20", Offset = "0x16F6E20", VA = "0x16F6E20")]
			public <>c()
			{
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x16F6E28", Offset = "0x16F6E28", VA = "0x16F6E28")]
			internal void <.cctor>b__0_0(string logString, string stackTrace, LogType logType)
			{
			}
		}

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<WeakReference> listeners;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2B31150", Offset = "0x2B31150", VA = "0x2B31150")]
		static LogDispatcher()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2B31264", Offset = "0x2B31264", VA = "0x2B31264")]
		public static void Register(ILogListener logListener)
		{
		}
	}
}
namespace StylizedWater
{
	[Token(Token = "0x2000032")]
	public static class GerstnerWaveDisplacement
	{
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2B2CE58", Offset = "0x2B2CE58", VA = "0x2B2CE58")]
		private static Vector3 GerstnerWave(Vector3 position, float steepness, float wavelength, float speed, float direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2B2CF48", Offset = "0x2B2CF48", VA = "0x2B2CF48")]
		public static Vector3 GetWaveDisplacement(Vector3 position, float steepness, float wavelength, float speed, float[] directions)
		{
			return default(Vector3);
		}
	}
}
namespace Unity.Screenshots
{
	[Token(Token = "0x2000033")]
	public static class Downsampler
	{
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2B2AE28", Offset = "0x2B2AE28", VA = "0x2B2AE28")]
		public static byte[] Downsample(byte[] dataRgba, int stride, int maximumWidth, int maximumHeight, out int downsampledStride)
		{
			return null;
		}
	}
	[Token(Token = "0x2000034")]
	public static class PngEncoder
	{
		[Token(Token = "0x2000035")]
		public class Crc32
		{
			[Serializable]
			[Token(Token = "0x2000036")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E2E4", Offset = "0xE4E2E4")]
			private sealed class <>c
			{
				[Token(Token = "0x40000D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly <>c <>9;

				[Token(Token = "0x40000D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static Func<int, uint> <>9__1_0;

				[Token(Token = "0x6000109")]
				[Address(RVA = "0x16F9E08", Offset = "0x16F9E08", VA = "0x16F9E08")]
				public <>c()
				{
				}

				[Token(Token = "0x600010A")]
				[Address(RVA = "0x16F9E10", Offset = "0x16F9E10", VA = "0x16F9E10")]
				internal uint <.ctor>b__1_0(int i)
				{
					return default(uint);
				}
			}

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static uint generator;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly uint[] checksumTable;

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x16F728C", Offset = "0x16F728C", VA = "0x16F728C")]
			public Crc32()
			{
			}

			[Token(Token = "0x6000105")]
			public uint Calculate<T>(IEnumerable<T> byteStream)
			{
				return default(uint);
			}

			[Token(Token = "0x6000107")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5174C", Offset = "0xE5174C")]
			private uint <Calculate>b__3_0<T>(uint checksumRegister, T currentByte)
			{
				return default(uint);
			}
		}

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E2F4", Offset = "0xE4E2F4")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public byte[] dataRgba;

			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int stride;

			[Token(Token = "0x40000D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<Exception, byte[]> callback;

			[Token(Token = "0x600010B")]
			[Address(RVA = "0x16F711C", Offset = "0x16F711C", VA = "0x16F711C")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600010C")]
			[Address(RVA = "0x16F7124", Offset = "0x16F7124", VA = "0x16F7124")]
			internal void <EncodeAsync>b__0(object state)
			{
			}
		}

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Crc32 crc32;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2B33154", Offset = "0x2B33154", VA = "0x2B33154")]
		static PngEncoder()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2B331CC", Offset = "0x2B331CC", VA = "0x2B331CC")]
		private static uint Adler32(byte[] bytes)
		{
			return default(uint);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2B3326C", Offset = "0x2B3326C", VA = "0x2B3326C")]
		private static void AppendByte(this byte[] data, ref int position, byte value)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2B332B4", Offset = "0x2B332B4", VA = "0x2B332B4")]
		private static void AppendBytes(this byte[] data, ref int position, byte[] value)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2B33388", Offset = "0x2B33388", VA = "0x2B33388")]
		private static void AppendChunk(this byte[] data, ref int position, string chunkType, byte[] chunkData)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2B33564", Offset = "0x2B33564", VA = "0x2B33564")]
		private static void AppendInt(this byte[] data, ref int position, int value)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2B33738", Offset = "0x2B33738", VA = "0x2B33738")]
		private static void AppendUInt(this byte[] data, ref int position, uint value)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2B33808", Offset = "0x2B33808", VA = "0x2B33808")]
		private static byte[] Compress(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2B33B74", Offset = "0x2B33B74", VA = "0x2B33B74")]
		public static byte[] Encode(byte[] dataRgba, int stride)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2B3405C", Offset = "0x2B3405C", VA = "0x2B3405C")]
		public static void EncodeAsync(byte[] dataRgba, int stride, Action<Exception, byte[]> callback)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2B33634", Offset = "0x2B33634", VA = "0x2B33634")]
		private static uint GetChunkCrc(byte[] chunkTypeBytes, byte[] chunkData)
		{
			return default(uint);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2B3348C", Offset = "0x2B3348C", VA = "0x2B3348C")]
		private static byte[] GetChunkTypeBytes(string value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	public class ScreenshotManager
	{
		[Token(Token = "0x2000039")]
		private class ScreenshotOperation
		{
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4FFC0", Offset = "0xE4FFC0")]
			private Action<int, byte[]> <Callback>k__BackingField;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4FFD0", Offset = "0xE4FFD0")]
			private byte[] <Data>k__BackingField;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4FFE0", Offset = "0xE4FFE0")]
			private int <FrameNumber>k__BackingField;

			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4FFF0", Offset = "0xE4FFF0")]
			private bool <IsAwaiting>k__BackingField;

			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50000", Offset = "0xE50000")]
			private bool <IsComplete>k__BackingField;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50010", Offset = "0xE50010")]
			private bool <IsInUse>k__BackingField;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50020", Offset = "0xE50020")]
			private int <MaximumHeight>k__BackingField;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50030", Offset = "0xE50030")]
			private int <MaximumWidth>k__BackingField;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50040", Offset = "0xE50040")]
			private object <Source>k__BackingField;

			[Token(Token = "0x17000022")]
			public Action<int, byte[]> Callback
			{
				[Token(Token = "0x6000112")]
				[Address(RVA = "0x16F81A0", Offset = "0x16F81A0", VA = "0x16F81A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5175C", Offset = "0xE5175C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000113")]
				[Address(RVA = "0x16F81A8", Offset = "0x16F81A8", VA = "0x16F81A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5176C", Offset = "0xE5176C")]
				set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public byte[] Data
			{
				[Token(Token = "0x6000114")]
				[Address(RVA = "0x16F81B0", Offset = "0x16F81B0", VA = "0x16F81B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5177C", Offset = "0xE5177C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000115")]
				[Address(RVA = "0x16F81B8", Offset = "0x16F81B8", VA = "0x16F81B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5178C", Offset = "0xE5178C")]
				set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public int FrameNumber
			{
				[Token(Token = "0x6000116")]
				[Address(RVA = "0x16F81C0", Offset = "0x16F81C0", VA = "0x16F81C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5179C", Offset = "0xE5179C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000117")]
				[Address(RVA = "0x16F81C8", Offset = "0x16F81C8", VA = "0x16F81C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE517AC", Offset = "0xE517AC")]
				set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public bool IsAwaiting
			{
				[Token(Token = "0x6000118")]
				[Address(RVA = "0x16F81D0", Offset = "0x16F81D0", VA = "0x16F81D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE517BC", Offset = "0xE517BC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000119")]
				[Address(RVA = "0x16F81D8", Offset = "0x16F81D8", VA = "0x16F81D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE517CC", Offset = "0xE517CC")]
				set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public bool IsComplete
			{
				[Token(Token = "0x600011A")]
				[Address(RVA = "0x16F81E4", Offset = "0x16F81E4", VA = "0x16F81E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE517DC", Offset = "0xE517DC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600011B")]
				[Address(RVA = "0x16F81EC", Offset = "0x16F81EC", VA = "0x16F81EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE517EC", Offset = "0xE517EC")]
				set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public bool IsInUse
			{
				[Token(Token = "0x600011C")]
				[Address(RVA = "0x16F81F8", Offset = "0x16F81F8", VA = "0x16F81F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE517FC", Offset = "0xE517FC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600011D")]
				[Address(RVA = "0x16F8200", Offset = "0x16F8200", VA = "0x16F8200")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5180C", Offset = "0xE5180C")]
				set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public int MaximumHeight
			{
				[Token(Token = "0x600011E")]
				[Address(RVA = "0x16F820C", Offset = "0x16F820C", VA = "0x16F820C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5181C", Offset = "0xE5181C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600011F")]
				[Address(RVA = "0x16F8214", Offset = "0x16F8214", VA = "0x16F8214")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5182C", Offset = "0xE5182C")]
				set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public int MaximumWidth
			{
				[Token(Token = "0x6000120")]
				[Address(RVA = "0x16F821C", Offset = "0x16F821C", VA = "0x16F821C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5183C", Offset = "0xE5183C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000121")]
				[Address(RVA = "0x16F8224", Offset = "0x16F8224", VA = "0x16F8224")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5184C", Offset = "0xE5184C")]
				set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public object Source
			{
				[Token(Token = "0x6000122")]
				[Address(RVA = "0x16F822C", Offset = "0x16F822C", VA = "0x16F822C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5185C", Offset = "0xE5185C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000123")]
				[Address(RVA = "0x16F8234", Offset = "0x16F8234", VA = "0x16F8234")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5186C", Offset = "0xE5186C")]
				set
				{
				}
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x16F823C", Offset = "0x16F823C", VA = "0x16F823C")]
			public void Use()
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x16F8294", Offset = "0x16F8294", VA = "0x16F8294")]
			public ScreenshotOperation()
			{
			}
		}

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Action<byte[], object> screenshotCallbackDelegate;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<ScreenshotOperation> screenshotOperations;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ScreenshotRecorder screenshotRecorder;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2C1F370", Offset = "0x2C1F370", VA = "0x2C1F370")]
		public ScreenshotManager()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2C1F514", Offset = "0x2C1F514", VA = "0x2C1F514")]
		private ScreenshotOperation GetScreenshotOperation()
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2C1F6B8", Offset = "0x2C1F6B8", VA = "0x2C1F6B8")]
		public void OnEndOfFrame()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2C1FBC8", Offset = "0x2C1FBC8", VA = "0x2C1FBC8")]
		private void ScreenshotCallback(byte[] data, object state)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2C1FC6C", Offset = "0x2C1FC6C", VA = "0x2C1FC6C")]
		public void TakeScreenshot(object source, int frameNumber, int maximumWidth, int maximumHeight, Action<int, byte[]> callback)
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class ScreenshotRecorder
	{
		[Token(Token = "0x200003B")]
		private class ScreenshotOperation
		{
			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaitCallback EncodeCallbackDelegate;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<AsyncGPUReadbackRequest> ScreenshotCallbackDelegate;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50050", Offset = "0xE50050")]
			private Action<byte[], object> <Callback>k__BackingField;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50060", Offset = "0xE50060")]
			private int <Height>k__BackingField;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50070", Offset = "0xE50070")]
			private int <Identifier>k__BackingField;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50080", Offset = "0xE50080")]
			private bool <IsInUse>k__BackingField;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50090", Offset = "0xE50090")]
			private int <MaximumHeight>k__BackingField;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE500A0", Offset = "0xE500A0")]
			private int <MaximumWidth>k__BackingField;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE500B0", Offset = "0xE500B0")]
			private NativeArray<byte> <NativeData>k__BackingField;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE500C0", Offset = "0xE500C0")]
			private Texture <Source>k__BackingField;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE500D0", Offset = "0xE500D0")]
			private object <State>k__BackingField;

			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE500E0", Offset = "0xE500E0")]
			private ScreenshotType <Type>k__BackingField;

			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE500F0", Offset = "0xE500F0")]
			private int <Width>k__BackingField;

			[Token(Token = "0x1700002B")]
			public Action<byte[], object> Callback
			{
				[Token(Token = "0x600012E")]
				[Address(RVA = "0x16F8390", Offset = "0x16F8390", VA = "0x16F8390")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5187C", Offset = "0xE5187C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600012F")]
				[Address(RVA = "0x16F8398", Offset = "0x16F8398", VA = "0x16F8398")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5188C", Offset = "0xE5188C")]
				set
				{
				}
			}

			[Token(Token = "0x1700002C")]
			public int Height
			{
				[Token(Token = "0x6000130")]
				[Address(RVA = "0x16F83A0", Offset = "0x16F83A0", VA = "0x16F83A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5189C", Offset = "0xE5189C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000131")]
				[Address(RVA = "0x16F83A8", Offset = "0x16F83A8", VA = "0x16F83A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE518AC", Offset = "0xE518AC")]
				set
				{
				}
			}

			[Token(Token = "0x1700002D")]
			public int Identifier
			{
				[Token(Token = "0x6000132")]
				[Address(RVA = "0x16F83B0", Offset = "0x16F83B0", VA = "0x16F83B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE518BC", Offset = "0xE518BC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000133")]
				[Address(RVA = "0x16F83B8", Offset = "0x16F83B8", VA = "0x16F83B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE518CC", Offset = "0xE518CC")]
				set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public bool IsInUse
			{
				[Token(Token = "0x6000134")]
				[Address(RVA = "0x16F83C0", Offset = "0x16F83C0", VA = "0x16F83C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE518DC", Offset = "0xE518DC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000135")]
				[Address(RVA = "0x16F83C8", Offset = "0x16F83C8", VA = "0x16F83C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE518EC", Offset = "0xE518EC")]
				set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public int MaximumHeight
			{
				[Token(Token = "0x6000136")]
				[Address(RVA = "0x16F83D4", Offset = "0x16F83D4", VA = "0x16F83D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE518FC", Offset = "0xE518FC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000137")]
				[Address(RVA = "0x16F83DC", Offset = "0x16F83DC", VA = "0x16F83DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5190C", Offset = "0xE5190C")]
				set
				{
				}
			}

			[Token(Token = "0x17000030")]
			public int MaximumWidth
			{
				[Token(Token = "0x6000138")]
				[Address(RVA = "0x16F83E4", Offset = "0x16F83E4", VA = "0x16F83E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5191C", Offset = "0xE5191C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000139")]
				[Address(RVA = "0x16F83EC", Offset = "0x16F83EC", VA = "0x16F83EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5192C", Offset = "0xE5192C")]
				set
				{
				}
			}

			[Token(Token = "0x17000031")]
			public NativeArray<byte> NativeData
			{
				[Token(Token = "0x600013A")]
				[Address(RVA = "0x16F83F4", Offset = "0x16F83F4", VA = "0x16F83F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5193C", Offset = "0xE5193C")]
				get
				{
					return default(NativeArray<byte>);
				}
				[Token(Token = "0x600013B")]
				[Address(RVA = "0x16F8400", Offset = "0x16F8400", VA = "0x16F8400")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5194C", Offset = "0xE5194C")]
				set
				{
				}
			}

			[Token(Token = "0x17000032")]
			public Texture Source
			{
				[Token(Token = "0x600013C")]
				[Address(RVA = "0x16F8408", Offset = "0x16F8408", VA = "0x16F8408")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5195C", Offset = "0xE5195C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600013D")]
				[Address(RVA = "0x16F8410", Offset = "0x16F8410", VA = "0x16F8410")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5196C", Offset = "0xE5196C")]
				set
				{
				}
			}

			[Token(Token = "0x17000033")]
			public object State
			{
				[Token(Token = "0x600013E")]
				[Address(RVA = "0x16F8418", Offset = "0x16F8418", VA = "0x16F8418")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5197C", Offset = "0xE5197C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600013F")]
				[Address(RVA = "0x16F8420", Offset = "0x16F8420", VA = "0x16F8420")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5198C", Offset = "0xE5198C")]
				set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public ScreenshotType Type
			{
				[Token(Token = "0x6000140")]
				[Address(RVA = "0x16F8428", Offset = "0x16F8428", VA = "0x16F8428")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5199C", Offset = "0xE5199C")]
				get
				{
					return default(ScreenshotType);
				}
				[Token(Token = "0x6000141")]
				[Address(RVA = "0x16F8430", Offset = "0x16F8430", VA = "0x16F8430")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE519AC", Offset = "0xE519AC")]
				set
				{
				}
			}

			[Token(Token = "0x17000035")]
			public int Width
			{
				[Token(Token = "0x6000142")]
				[Address(RVA = "0x16F8438", Offset = "0x16F8438", VA = "0x16F8438")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE519BC", Offset = "0xE519BC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000143")]
				[Address(RVA = "0x16F8440", Offset = "0x16F8440", VA = "0x16F8440")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE519CC", Offset = "0xE519CC")]
				set
				{
				}
			}

			[Token(Token = "0x600012D")]
			[Address(RVA = "0x16F829C", Offset = "0x16F829C", VA = "0x16F829C")]
			public ScreenshotOperation()
			{
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0x16F8448", Offset = "0x16F8448", VA = "0x16F8448")]
			private void EncodeCallback(object state)
			{
			}

			[Token(Token = "0x6000145")]
			[Address(RVA = "0x16F8578", Offset = "0x16F8578", VA = "0x16F8578")]
			private void SavePngToDisk(byte[] byteData)
			{
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0x16F8664", Offset = "0x16F8664", VA = "0x16F8664")]
			private void ScreenshotCallback(AsyncGPUReadbackRequest request)
			{
			}
		}

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int nextIdentifier;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<ScreenshotOperation> operationPool;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2C1F490", Offset = "0x2C1F490", VA = "0x2C1F490")]
		public ScreenshotRecorder()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2C1FCD8", Offset = "0x2C1FCD8", VA = "0x2C1FCD8")]
		private ScreenshotOperation GetOperation()
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2C1FA60", Offset = "0x2C1FA60", VA = "0x2C1FA60")]
		public void Screenshot(int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2C1FAC4", Offset = "0x2C1FAC4", VA = "0x2C1FAC4")]
		public void Screenshot(Camera source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2C1FBC0", Offset = "0x2C1FBC0", VA = "0x2C1FBC0")]
		public void Screenshot(RenderTexture source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2C1FBC4", Offset = "0x2C1FBC4", VA = "0x2C1FBC4")]
		public void Screenshot(Texture2D source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2C1FE70", Offset = "0x2C1FE70", VA = "0x2C1FE70")]
		private void ScreenshotInternal(Texture source, int maximumWidth, int maximumHeight, ScreenshotType type, Action<byte[], object> callback, object state)
		{
		}
	}
	[Token(Token = "0x200003C")]
	public enum ScreenshotType
	{
		[Token(Token = "0x40000F1")]
		Raw,
		[Token(Token = "0x40000F2")]
		Png
	}
}
namespace Unity.Cloud
{
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xE4E304", Offset = "0xE4E304")]
	public class CyclicalList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x200003E")]
		private struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int currentIndex;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private CyclicalList<T> list;

			[Token(Token = "0x1700003A")]
			public T Current
			{
				[Token(Token = "0x600015A")]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x1700003B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600015B")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000159")]
			public Enumerator(CyclicalList<T> list)
			{
			}

			[Token(Token = "0x600015C")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600015D")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600015E")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int count;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] items;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int nextPointer;

		[Token(Token = "0x17000036")]
		public int Capacity
		{
			[Token(Token = "0x6000148")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000037")]
		public int Count
		{
			[Token(Token = "0x6000149")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000038")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600014A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public T Item
		{
			[Token(Token = "0x600014B")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x600014C")]
			set
			{
			}
		}

		[Token(Token = "0x6000147")]
		public CyclicalList(int capacity)
		{
		}

		[Token(Token = "0x600014D")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x600014E")]
		public void Clear()
		{
		}

		[Token(Token = "0x600014F")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000150")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000151")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		public T GetNextEviction()
		{
			return (T)null;
		}

		[Token(Token = "0x6000154")]
		private int GetPointer(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000155")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000156")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000157")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		public void RemoveAt(int index)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public static class Preconditions
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2B3A92C", Offset = "0x2B3A92C", VA = "0x2B3A92C")]
		public static void ArgumentIsLessThanOrEqualToLength(object value, int length, string argumentName)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2B3A9E4", Offset = "0x2B3A9E4", VA = "0x2B3A9E4")]
		public static void ArgumentNotNullOrWhitespace(object value, string argumentName)
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class SerializableException
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50100", Offset = "0xE50100")]
		private string <DetailedProblemIdentifier>k__BackingField;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50110", Offset = "0xE50110")]
		private string <FullText>k__BackingField;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50120", Offset = "0xE50120")]
		private SerializableException <InnerException>k__BackingField;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50130", Offset = "0xE50130")]
		private string <Message>k__BackingField;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50140", Offset = "0xE50140")]
		private string <ProblemIdentifier>k__BackingField;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50150", Offset = "0xE50150")]
		private List<SerializableStackFrame> <StackTrace>k__BackingField;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50160", Offset = "0xE50160")]
		private string <Type>k__BackingField;

		[Token(Token = "0x1700003C")]
		public string DetailedProblemIdentifier
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2C20620", Offset = "0x2C20620", VA = "0x2C20620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE519DC", Offset = "0xE519DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x2C20628", Offset = "0x2C20628", VA = "0x2C20628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE519EC", Offset = "0xE519EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public string FullText
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2C20630", Offset = "0x2C20630", VA = "0x2C20630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE519FC", Offset = "0xE519FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2C20638", Offset = "0x2C20638", VA = "0x2C20638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51A0C", Offset = "0xE51A0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public SerializableException InnerException
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2C20640", Offset = "0x2C20640", VA = "0x2C20640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51A1C", Offset = "0xE51A1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2C20648", Offset = "0x2C20648", VA = "0x2C20648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51A2C", Offset = "0xE51A2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public string Message
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2C20650", Offset = "0x2C20650", VA = "0x2C20650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51A3C", Offset = "0xE51A3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x2C20658", Offset = "0x2C20658", VA = "0x2C20658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51A4C", Offset = "0xE51A4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public string ProblemIdentifier
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2C20660", Offset = "0x2C20660", VA = "0x2C20660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51A5C", Offset = "0xE51A5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x2C20668", Offset = "0x2C20668", VA = "0x2C20668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51A6C", Offset = "0xE51A6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public List<SerializableStackFrame> StackTrace
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2C20670", Offset = "0x2C20670", VA = "0x2C20670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51A7C", Offset = "0xE51A7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x2C20678", Offset = "0x2C20678", VA = "0x2C20678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51A8C", Offset = "0xE51A8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public string Type
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2C20680", Offset = "0x2C20680", VA = "0x2C20680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51A9C", Offset = "0xE51A9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x2C20688", Offset = "0x2C20688", VA = "0x2C20688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51AAC", Offset = "0xE51AAC")]
			set
			{
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2C1FFF8", Offset = "0x2C1FFF8", VA = "0x2C1FFF8")]
		public SerializableException()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2C20000", Offset = "0x2C20000", VA = "0x2C20000")]
		public SerializableException(Exception exception)
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class SerializableStackFrame
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50170", Offset = "0xE50170")]
		private string <DeclaringType>k__BackingField;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50180", Offset = "0xE50180")]
		private int <FileColumn>k__BackingField;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50190", Offset = "0xE50190")]
		private int <FileLine>k__BackingField;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE501A0", Offset = "0xE501A0")]
		private string <FileName>k__BackingField;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE501B0", Offset = "0xE501B0")]
		private string <Method>k__BackingField;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE501C0", Offset = "0xE501C0")]
		private string <MethodName>k__BackingField;

		[Token(Token = "0x17000043")]
		public string DeclaringType
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2C20698", Offset = "0x2C20698", VA = "0x2C20698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51ABC", Offset = "0xE51ABC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x2C206A0", Offset = "0x2C206A0", VA = "0x2C206A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51ACC", Offset = "0xE51ACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public int FileColumn
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x2C206A8", Offset = "0x2C206A8", VA = "0x2C206A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51ADC", Offset = "0xE51ADC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x2C206B0", Offset = "0x2C206B0", VA = "0x2C206B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51AEC", Offset = "0xE51AEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public int FileLine
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2C206B8", Offset = "0x2C206B8", VA = "0x2C206B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51AFC", Offset = "0xE51AFC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x2C206C0", Offset = "0x2C206C0", VA = "0x2C206C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51B0C", Offset = "0xE51B0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public string FileName
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x2C206C8", Offset = "0x2C206C8", VA = "0x2C206C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51B1C", Offset = "0xE51B1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2C206D0", Offset = "0x2C206D0", VA = "0x2C206D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51B2C", Offset = "0xE51B2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public string Method
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2C206D8", Offset = "0x2C206D8", VA = "0x2C206D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51B3C", Offset = "0xE51B3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x2C206E0", Offset = "0x2C206E0", VA = "0x2C206E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51B4C", Offset = "0xE51B4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public string MethodName
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2C206E8", Offset = "0x2C206E8", VA = "0x2C206E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51B5C", Offset = "0xE51B5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2C206F0", Offset = "0x2C206F0", VA = "0x2C206F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51B6C", Offset = "0xE51B6C")]
			set
			{
			}
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2C20690", Offset = "0x2C20690", VA = "0x2C20690")]
		public SerializableStackFrame()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2C204AC", Offset = "0x2C204AC", VA = "0x2C204AC")]
		public SerializableStackFrame(StackFrame stackFrame)
		{
		}
	}
}
namespace Unity.Cloud.Authorization
{
	[Token(Token = "0x2000042")]
	public enum LicenseLevel
	{
		[Token(Token = "0x4000106")]
		None = 0,
		[Token(Token = "0x4000107")]
		Personal = 10,
		[Token(Token = "0x4000108")]
		Plus = 20,
		[Token(Token = "0x4000109")]
		Pro = 30
	}
}
namespace Unity.Cloud.UserReporting
{
	[Token(Token = "0x2000043")]
	public static class AttachmentExtensions
	{
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x255AC88", Offset = "0x255AC88", VA = "0x255AC88")]
		public static void AddJson(this List<UserReportAttachment> instance, string name, string fileName, string contents)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x255AD7C", Offset = "0x255AD7C", VA = "0x255AD7C")]
		public static void AddText(this List<UserReportAttachment> instance, string name, string fileName, string contents)
		{
		}
	}
	[Token(Token = "0x2000044")]
	public static class PngHelper
	{
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2B34140", Offset = "0x2B34140", VA = "0x2B34140")]
		public static int GetPngHeightFromBase64Data(string data)
		{
			return default(int);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2B3430C", Offset = "0x2B3430C", VA = "0x2B3430C")]
		public static int GetPngWidthFromBase64Data(string data)
		{
			return default(int);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2B34234", Offset = "0x2B34234", VA = "0x2B34234")]
		private static byte[] Slice(byte[] source, int start, int end)
		{
			return null;
		}
	}
	[Token(Token = "0x2000045")]
	public class UserReport : UserReportPreview
	{
		[Token(Token = "0x2000046")]
		private class UserReportMetricSorter : IComparer<UserReportMetric>
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x16F88D4", Offset = "0x16F88D4", VA = "0x16F88D4", Slot = "4")]
			public int Compare(UserReportMetric x, UserReportMetric y)
			{
				return default(int);
			}

			[Token(Token = "0x600019A")]
			[Address(RVA = "0x16F0130", Offset = "0x16F0130", VA = "0x16F0130")]
			public UserReportMetricSorter()
			{
			}
		}

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE501D0", Offset = "0xE501D0")]
		private List<UserReportAttachment> <Attachments>k__BackingField;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE501E0", Offset = "0xE501E0")]
		private List<UserReportMetric> <ClientMetrics>k__BackingField;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE501F0", Offset = "0xE501F0")]
		private List<UserReportNamedValue> <DeviceMetadata>k__BackingField;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50200", Offset = "0xE50200")]
		private List<UserReportEvent> <Events>k__BackingField;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50210", Offset = "0xE50210")]
		private List<UserReportNamedValue> <Fields>k__BackingField;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50220", Offset = "0xE50220")]
		private List<UserReportMeasure> <Measures>k__BackingField;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50230", Offset = "0xE50230")]
		private List<UserReportScreenshot> <Screenshots>k__BackingField;

		[Token(Token = "0x17000049")]
		public List<UserReportAttachment> Attachments
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x16EF620", Offset = "0x16EF620", VA = "0x16EF620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51B9C", Offset = "0xE51B9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x16EF628", Offset = "0x16EF628", VA = "0x16EF628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51BAC", Offset = "0xE51BAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public List<UserReportMetric> ClientMetrics
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x16EF630", Offset = "0x16EF630", VA = "0x16EF630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51BBC", Offset = "0xE51BBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x16EF638", Offset = "0x16EF638", VA = "0x16EF638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51BCC", Offset = "0xE51BCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public List<UserReportNamedValue> DeviceMetadata
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x16EF640", Offset = "0x16EF640", VA = "0x16EF640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51BDC", Offset = "0xE51BDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x16EF648", Offset = "0x16EF648", VA = "0x16EF648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51BEC", Offset = "0xE51BEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public List<UserReportEvent> Events
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x16EF650", Offset = "0x16EF650", VA = "0x16EF650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51BFC", Offset = "0xE51BFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x16EF658", Offset = "0x16EF658", VA = "0x16EF658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51C0C", Offset = "0xE51C0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public List<UserReportNamedValue> Fields
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x16EF660", Offset = "0x16EF660", VA = "0x16EF660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51C1C", Offset = "0xE51C1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x16EF668", Offset = "0x16EF668", VA = "0x16EF668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51C2C", Offset = "0xE51C2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public List<UserReportMeasure> Measures
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x16EF670", Offset = "0x16EF670", VA = "0x16EF670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51C3C", Offset = "0xE51C3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x16EF678", Offset = "0x16EF678", VA = "0x16EF678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51C4C", Offset = "0xE51C4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public List<UserReportScreenshot> Screenshots
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x16EF680", Offset = "0x16EF680", VA = "0x16EF680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51C5C", Offset = "0xE51C5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x16EF688", Offset = "0x16EF688", VA = "0x16EF688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51C6C", Offset = "0xE51C6C")]
			set
			{
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x16EF350", Offset = "0x16EF350", VA = "0x16EF350")]
		public UserReport()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x16EF690", Offset = "0x16EF690", VA = "0x16EF690")]
		public UserReport Clone()
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x16EF964", Offset = "0x16EF964", VA = "0x16EF964")]
		public void Complete()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x16F0138", Offset = "0x16F0138", VA = "0x16F0138")]
		public void Fix()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x16F0438", Offset = "0x16F0438", VA = "0x16F0438")]
		public string GetDimensionsString()
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x16F05A4", Offset = "0x16F05A4", VA = "0x16F05A4")]
		public void RemoveScreenshots(int maximumWidth, int maximumHeight, int totalBytes, int ignoreCount)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x16F070C", Offset = "0x16F070C", VA = "0x16F070C")]
		public UserReportPreview ToPreview()
		{
			return null;
		}
	}
	[Token(Token = "0x2000047")]
	public enum UserReportAppearanceHint
	{
		[Token(Token = "0x4000112")]
		Normal,
		[Token(Token = "0x4000113")]
		Landscape,
		[Token(Token = "0x4000114")]
		Portrait,
		[Token(Token = "0x4000115")]
		Large
	}
	[Token(Token = "0x2000048")]
	public struct UserReportAttachment
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50240", Offset = "0xE50240")]
		private string <ContentType>k__BackingField;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50250", Offset = "0xE50250")]
		private string <DataBase64>k__BackingField;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50260", Offset = "0xE50260")]
		private string <DataIdentifier>k__BackingField;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50270", Offset = "0xE50270")]
		private string <FileName>k__BackingField;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50280", Offset = "0xE50280")]
		private string <Name>k__BackingField;

		[Token(Token = "0x17000050")]
		public string ContentType
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x16F0938", Offset = "0x16F0938", VA = "0x16F0938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51C7C", Offset = "0xE51C7C")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x16F0940", Offset = "0x16F0940", VA = "0x16F0940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51CB4", Offset = "0xE51CB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public string DataBase64
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x16F0948", Offset = "0x16F0948", VA = "0x16F0948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51CC4", Offset = "0xE51CC4")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x16F0950", Offset = "0x16F0950", VA = "0x16F0950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51CFC", Offset = "0xE51CFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public string DataIdentifier
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x16F0958", Offset = "0x16F0958", VA = "0x16F0958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51D0C", Offset = "0xE51D0C")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x16F0960", Offset = "0x16F0960", VA = "0x16F0960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51D44", Offset = "0xE51D44")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public string FileName
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x16F0968", Offset = "0x16F0968", VA = "0x16F0968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51D54", Offset = "0xE51D54")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x16F0970", Offset = "0x16F0970", VA = "0x16F0970")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51D8C", Offset = "0xE51D8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public string Name
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x16F0978", Offset = "0x16F0978", VA = "0x16F0978")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51D9C", Offset = "0xE51D9C")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x16F0980", Offset = "0x16F0980", VA = "0x16F0980")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51DD4", Offset = "0xE51DD4")]
			set
			{
			}
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x16F0864", Offset = "0x16F0864", VA = "0x16F0864")]
		public UserReportAttachment(string name, string fileName, string contentType, byte[] data)
		{
		}
	}
	[Token(Token = "0x2000049")]
	public struct UserReportEvent
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50290", Offset = "0xE50290")]
		private SerializableException <Exception>k__BackingField;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE502A0", Offset = "0xE502A0")]
		private int <FrameNumber>k__BackingField;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE502B0", Offset = "0xE502B0")]
		private UserReportEventLevel <Level>k__BackingField;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE502C0", Offset = "0xE502C0")]
		private string <Message>k__BackingField;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE502D0", Offset = "0xE502D0")]
		private string <StackTrace>k__BackingField;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE502E0", Offset = "0xE502E0")]
		private DateTime <Timestamp>k__BackingField;

		[Token(Token = "0x17000055")]
		public SerializableException Exception
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x16F0988", Offset = "0x16F0988", VA = "0x16F0988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51DE4", Offset = "0xE51DE4")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x16F0990", Offset = "0x16F0990", VA = "0x16F0990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51E1C", Offset = "0xE51E1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public int FrameNumber
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x16F0998", Offset = "0x16F0998", VA = "0x16F0998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51E2C", Offset = "0xE51E2C")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x16F09A0", Offset = "0x16F09A0", VA = "0x16F09A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51E64", Offset = "0xE51E64")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public string FullMessage
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x16F09A8", Offset = "0x16F09A8", VA = "0x16F09A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public UserReportEventLevel Level
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x16F0A10", Offset = "0x16F0A10", VA = "0x16F0A10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51E74", Offset = "0xE51E74")]
			readonly get
			{
				return default(UserReportEventLevel);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x16F0A18", Offset = "0x16F0A18", VA = "0x16F0A18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51EAC", Offset = "0xE51EAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public string Message
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x16F0A20", Offset = "0x16F0A20", VA = "0x16F0A20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51EBC", Offset = "0xE51EBC")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x16F0A28", Offset = "0x16F0A28", VA = "0x16F0A28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51EF4", Offset = "0xE51EF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public string StackTrace
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x16F0A30", Offset = "0x16F0A30", VA = "0x16F0A30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51F04", Offset = "0xE51F04")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x16F0A38", Offset = "0x16F0A38", VA = "0x16F0A38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51F3C", Offset = "0xE51F3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public DateTime Timestamp
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x16F0A40", Offset = "0x16F0A40", VA = "0x16F0A40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51F4C", Offset = "0xE51F4C")]
			readonly get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x16F0A48", Offset = "0x16F0A48", VA = "0x16F0A48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51F84", Offset = "0xE51F84")]
			set
			{
			}
		}
	}
	[Token(Token = "0x200004A")]
	public enum UserReportEventLevel
	{
		[Token(Token = "0x4000122")]
		Info,
		[Token(Token = "0x4000123")]
		Success,
		[Token(Token = "0x4000124")]
		Warning,
		[Token(Token = "0x4000125")]
		Error
	}
	[Token(Token = "0x200004B")]
	public class UserReportList
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE502F0", Offset = "0xE502F0")]
		private string <ContinuationToken>k__BackingField;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50300", Offset = "0xE50300")]
		private string <Error>k__BackingField;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50310", Offset = "0xE50310")]
		private bool <HasMore>k__BackingField;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50320", Offset = "0xE50320")]
		private List<UserReportPreview> <UserReportPreviews>k__BackingField;

		[Token(Token = "0x1700005C")]
		public string ContinuationToken
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x16F0AD4", Offset = "0x16F0AD4", VA = "0x16F0AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51F94", Offset = "0xE51F94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x16F0ADC", Offset = "0x16F0ADC", VA = "0x16F0ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51FA4", Offset = "0xE51FA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public string Error
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x16F0AE4", Offset = "0x16F0AE4", VA = "0x16F0AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51FB4", Offset = "0xE51FB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x16F0AEC", Offset = "0x16F0AEC", VA = "0x16F0AEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51FC4", Offset = "0xE51FC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool HasMore
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x16F0AF4", Offset = "0x16F0AF4", VA = "0x16F0AF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51FD4", Offset = "0xE51FD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x16F0AFC", Offset = "0x16F0AFC", VA = "0x16F0AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51FE4", Offset = "0xE51FE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public List<UserReportPreview> UserReportPreviews
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x16F0B08", Offset = "0x16F0B08", VA = "0x16F0B08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE51FF4", Offset = "0xE51FF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x16F0B10", Offset = "0x16F0B10", VA = "0x16F0B10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52004", Offset = "0xE52004")]
			set
			{
			}
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x16F0A50", Offset = "0x16F0A50", VA = "0x16F0A50")]
		public UserReportList()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x16F0B18", Offset = "0x16F0B18", VA = "0x16F0B18")]
		public void Complete(int originalLimit, string continuationToken)
		{
		}
	}
	[Token(Token = "0x200004C")]
	public struct UserReportMeasure
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50330", Offset = "0xE50330")]
		private int <EndFrameNumber>k__BackingField;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50340", Offset = "0xE50340")]
		private List<UserReportNamedValue> <Metadata>k__BackingField;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50350", Offset = "0xE50350")]
		private List<UserReportMetric> <Metrics>k__BackingField;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50360", Offset = "0xE50360")]
		private int <StartFrameNumber>k__BackingField;

		[Token(Token = "0x17000060")]
		public int EndFrameNumber
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x16F0BD0", Offset = "0x16F0BD0", VA = "0x16F0BD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52014", Offset = "0xE52014")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x16F0BD8", Offset = "0x16F0BD8", VA = "0x16F0BD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5204C", Offset = "0xE5204C")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public List<UserReportNamedValue> Metadata
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x16F0BE0", Offset = "0x16F0BE0", VA = "0x16F0BE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5205C", Offset = "0xE5205C")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x16F0BE8", Offset = "0x16F0BE8", VA = "0x16F0BE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52094", Offset = "0xE52094")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public List<UserReportMetric> Metrics
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x16F0BF0", Offset = "0x16F0BF0", VA = "0x16F0BF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE520A4", Offset = "0xE520A4")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x16F0BF8", Offset = "0x16F0BF8", VA = "0x16F0BF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE520DC", Offset = "0xE520DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public int StartFrameNumber
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x16F0C00", Offset = "0x16F0C00", VA = "0x16F0C00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE520EC", Offset = "0xE520EC")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x16F0C08", Offset = "0x16F0C08", VA = "0x16F0C08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52124", Offset = "0xE52124")]
			set
			{
			}
		}
	}
	[Token(Token = "0x200004D")]
	public struct UserReportMetric
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50370", Offset = "0xE50370")]
		private int <Count>k__BackingField;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50380", Offset = "0xE50380")]
		private double <Maximum>k__BackingField;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50390", Offset = "0xE50390")]
		private double <Minimum>k__BackingField;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE503A0", Offset = "0xE503A0")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE503B0", Offset = "0xE503B0")]
		private double <Sum>k__BackingField;

		[Token(Token = "0x17000064")]
		public double Average
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x16F0050", Offset = "0x16F0050", VA = "0x16F0050")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000065")]
		public int Count
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x16F0C10", Offset = "0x16F0C10", VA = "0x16F0C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52134", Offset = "0xE52134")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x16F0C18", Offset = "0x16F0C18", VA = "0x16F0C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5216C", Offset = "0xE5216C")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public double Maximum
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x16F0C20", Offset = "0x16F0C20", VA = "0x16F0C20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5217C", Offset = "0xE5217C")]
			readonly get
			{
				return default(double);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x16F0C28", Offset = "0x16F0C28", VA = "0x16F0C28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE521B4", Offset = "0xE521B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public double Minimum
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x16F0C30", Offset = "0x16F0C30", VA = "0x16F0C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE521C4", Offset = "0xE521C4")]
			readonly get
			{
				return default(double);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x16F0C38", Offset = "0x16F0C38", VA = "0x16F0C38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE521FC", Offset = "0xE521FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public string Name
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x16F0C40", Offset = "0x16F0C40", VA = "0x16F0C40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5220C", Offset = "0xE5220C")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x16F0C48", Offset = "0x16F0C48", VA = "0x16F0C48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52244", Offset = "0xE52244")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public double Sum
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x16F0C50", Offset = "0x16F0C50", VA = "0x16F0C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52254", Offset = "0xE52254")]
			readonly get
			{
				return default(double);
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x16F0C58", Offset = "0x16F0C58", VA = "0x16F0C58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5228C", Offset = "0xE5228C")]
			set
			{
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x16F0064", Offset = "0x16F0064", VA = "0x16F0064")]
		public void Sample(double value)
		{
		}
	}
	[Token(Token = "0x200004E")]
	public struct UserReportNamedValue
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE503C0", Offset = "0xE503C0")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE503D0", Offset = "0xE503D0")]
		private string <Value>k__BackingField;

		[Token(Token = "0x1700006A")]
		public string Name
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x16F0C60", Offset = "0x16F0C60", VA = "0x16F0C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5229C", Offset = "0xE5229C")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x16F0C68", Offset = "0x16F0C68", VA = "0x16F0C68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE522D4", Offset = "0xE522D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public string Value
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x16F0C70", Offset = "0x16F0C70", VA = "0x16F0C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE522E4", Offset = "0xE522E4")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x16F0C78", Offset = "0x16F0C78", VA = "0x16F0C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5231C", Offset = "0xE5231C")]
			set
			{
			}
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x16EE4D8", Offset = "0x16EE4D8", VA = "0x16EE4D8")]
		public UserReportNamedValue(string name, string value)
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class UserReportPreview
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE503E0", Offset = "0xE503E0")]
		private List<UserReportMetric> <AggregateMetrics>k__BackingField;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE503F0", Offset = "0xE503F0")]
		private UserReportAppearanceHint <AppearanceHint>k__BackingField;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50400", Offset = "0xE50400")]
		private long <ContentLength>k__BackingField;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50410", Offset = "0xE50410")]
		private List<UserReportNamedValue> <Dimensions>k__BackingField;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50420", Offset = "0xE50420")]
		private DateTime <ExpiresOn>k__BackingField;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50430", Offset = "0xE50430")]
		private string <GeoCountry>k__BackingField;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50440", Offset = "0xE50440")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50450", Offset = "0xE50450")]
		private string <IPAddress>k__BackingField;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50460", Offset = "0xE50460")]
		private bool <IsHiddenWithoutDimension>k__BackingField;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50470", Offset = "0xE50470")]
		private bool <IsSilent>k__BackingField;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50480", Offset = "0xE50480")]
		private bool <IsTemporary>k__BackingField;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50490", Offset = "0xE50490")]
		private LicenseLevel <LicenseLevel>k__BackingField;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE504A0", Offset = "0xE504A0")]
		private string <ProjectIdentifier>k__BackingField;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE504B0", Offset = "0xE504B0")]
		private DateTime <ReceivedOn>k__BackingField;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE504C0", Offset = "0xE504C0")]
		private string <Summary>k__BackingField;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE504D0", Offset = "0xE504D0")]
		private UserReportScreenshot <Thumbnail>k__BackingField;

		[Token(Token = "0x1700006C")]
		public List<UserReportMetric> AggregateMetrics
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x16F0C80", Offset = "0x16F0C80", VA = "0x16F0C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5232C", Offset = "0xE5232C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x16F0C88", Offset = "0x16F0C88", VA = "0x16F0C88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5233C", Offset = "0xE5233C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public UserReportAppearanceHint AppearanceHint
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x16F0C90", Offset = "0x16F0C90", VA = "0x16F0C90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5234C", Offset = "0xE5234C")]
			get
			{
				return default(UserReportAppearanceHint);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x16F0C98", Offset = "0x16F0C98", VA = "0x16F0C98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5235C", Offset = "0xE5235C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public long ContentLength
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x16F0CA0", Offset = "0x16F0CA0", VA = "0x16F0CA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5236C", Offset = "0xE5236C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x16F0CA8", Offset = "0x16F0CA8", VA = "0x16F0CA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5237C", Offset = "0xE5237C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public List<UserReportNamedValue> Dimensions
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x16F0CB0", Offset = "0x16F0CB0", VA = "0x16F0CB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5238C", Offset = "0xE5238C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x16F0CB8", Offset = "0x16F0CB8", VA = "0x16F0CB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5239C", Offset = "0xE5239C")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public DateTime ExpiresOn
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x16F0CC0", Offset = "0x16F0CC0", VA = "0x16F0CC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE523AC", Offset = "0xE523AC")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x16F0CC8", Offset = "0x16F0CC8", VA = "0x16F0CC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE523BC", Offset = "0xE523BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public string GeoCountry
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x16F0CD0", Offset = "0x16F0CD0", VA = "0x16F0CD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE523CC", Offset = "0xE523CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x16F0CD8", Offset = "0x16F0CD8", VA = "0x16F0CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE523DC", Offset = "0xE523DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public string Identifier
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x16F0CE0", Offset = "0x16F0CE0", VA = "0x16F0CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE523EC", Offset = "0xE523EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x16F0CE8", Offset = "0x16F0CE8", VA = "0x16F0CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE523FC", Offset = "0xE523FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public string IPAddress
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x16F0CF0", Offset = "0x16F0CF0", VA = "0x16F0CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5240C", Offset = "0xE5240C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x16F0CF8", Offset = "0x16F0CF8", VA = "0x16F0CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5241C", Offset = "0xE5241C")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool IsHiddenWithoutDimension
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x16F0D00", Offset = "0x16F0D00", VA = "0x16F0D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5242C", Offset = "0xE5242C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x16F0D08", Offset = "0x16F0D08", VA = "0x16F0D08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5243C", Offset = "0xE5243C")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool IsSilent
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x16F0D14", Offset = "0x16F0D14", VA = "0x16F0D14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5244C", Offset = "0xE5244C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x16F0D1C", Offset = "0x16F0D1C", VA = "0x16F0D1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5245C", Offset = "0xE5245C")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool IsTemporary
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x16F0D28", Offset = "0x16F0D28", VA = "0x16F0D28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5246C", Offset = "0xE5246C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x16F0D30", Offset = "0x16F0D30", VA = "0x16F0D30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5247C", Offset = "0xE5247C")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public LicenseLevel LicenseLevel
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x16F0D3C", Offset = "0x16F0D3C", VA = "0x16F0D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5248C", Offset = "0xE5248C")]
			get
			{
				return default(LicenseLevel);
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x16F0D44", Offset = "0x16F0D44", VA = "0x16F0D44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5249C", Offset = "0xE5249C")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public string ProjectIdentifier
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x16F0D4C", Offset = "0x16F0D4C", VA = "0x16F0D4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE524AC", Offset = "0xE524AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x16F0D54", Offset = "0x16F0D54", VA = "0x16F0D54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE524BC", Offset = "0xE524BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public DateTime ReceivedOn
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x16F0D5C", Offset = "0x16F0D5C", VA = "0x16F0D5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE524CC", Offset = "0xE524CC")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x16F0D64", Offset = "0x16F0D64", VA = "0x16F0D64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE524DC", Offset = "0xE524DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public string Summary
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x16F0D6C", Offset = "0x16F0D6C", VA = "0x16F0D6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE524EC", Offset = "0xE524EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x16F0D74", Offset = "0x16F0D74", VA = "0x16F0D74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE524FC", Offset = "0xE524FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public UserReportScreenshot Thumbnail
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x16F0D7C", Offset = "0x16F0D7C", VA = "0x16F0D7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5250C", Offset = "0xE5250C")]
			get
			{
				return default(UserReportScreenshot);
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x16F0D90", Offset = "0x16F0D90", VA = "0x16F0D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5251C", Offset = "0xE5251C")]
			set
			{
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x16EF59C", Offset = "0x16EF59C", VA = "0x16EF59C")]
		public UserReportPreview()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public struct UserReportScreenshot
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE504E0", Offset = "0xE504E0")]
		private string <DataBase64>k__BackingField;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE504F0", Offset = "0xE504F0")]
		private string <DataIdentifier>k__BackingField;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50500", Offset = "0xE50500")]
		private int <FrameNumber>k__BackingField;

		[Token(Token = "0x1700007C")]
		public string DataBase64
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x16F0DB0", Offset = "0x16F0DB0", VA = "0x16F0DB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE5252C", Offset = "0xE5252C")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x16F0DB8", Offset = "0x16F0DB8", VA = "0x16F0DB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52564", Offset = "0xE52564")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public string DataIdentifier
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x16F0DC0", Offset = "0x16F0DC0", VA = "0x16F0DC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52574", Offset = "0xE52574")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x16F0DC8", Offset = "0x16F0DC8", VA = "0x16F0DC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE525AC", Offset = "0xE525AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public int FrameNumber
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x16F0DD0", Offset = "0x16F0DD0", VA = "0x16F0DD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE525BC", Offset = "0xE525BC")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x16F0DD8", Offset = "0x16F0DD8", VA = "0x16F0DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE525F4", Offset = "0xE525F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public int Height
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x16F0700", Offset = "0x16F0700", VA = "0x16F0700")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000080")]
		public int Width
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x16F06F4", Offset = "0x16F06F4", VA = "0x16F06F4")]
			get
			{
				return default(int);
			}
		}
	}
}
namespace Unity.Cloud.UserReporting.Plugin
{
	[Token(Token = "0x2000051")]
	public static class UnityUserReportParser
	{
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x16EA588", Offset = "0x16EA588", VA = "0x16EA588")]
		public static UserReport ParseUserReport(string json)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x16EA600", Offset = "0x16EA600", VA = "0x16EA600")]
		public static UserReportList ParseUserReportList(string json)
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	public static class UnityUserReporting
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UserReportingClient currentClient;

		[Token(Token = "0x17000081")]
		public static UserReportingClient CurrentClient
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x16EA678", Offset = "0x16EA678", VA = "0x16EA678")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x16EA77C", Offset = "0x16EA77C", VA = "0x16EA77C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x16EA7D0", Offset = "0x16EA7D0", VA = "0x16EA7D0")]
		public static void Configure(string endpoint, string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x16EAFA0", Offset = "0x16EAFA0", VA = "0x16EAFA0")]
		public static void Configure(string endpoint, string projectIdentifier, UserReportingClientConfiguration configuration)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x16EB0B4", Offset = "0x16EB0B4", VA = "0x16EB0B4")]
		public static void Configure(string projectIdentifier, UserReportingClientConfiguration configuration)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x16EB11C", Offset = "0x16EB11C", VA = "0x16EB11C")]
		public static void Configure(string projectIdentifier)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x16EA6D8", Offset = "0x16EA6D8", VA = "0x16EA6D8")]
		public static void Configure()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x16EB1E8", Offset = "0x16EB1E8", VA = "0x16EB1E8")]
		public static void Configure(UserReportingClientConfiguration configuration)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x16EB250", Offset = "0x16EB250", VA = "0x16EB250")]
		public static void Configure(string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x16EB2B4", Offset = "0x16EB2B4", VA = "0x16EB2B4")]
		public static void Configure(IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x16EB320", Offset = "0x16EB320", VA = "0x16EB320")]
		public static void Configure(IUserReportingPlatform platform)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x16EB060", Offset = "0x16EB060", VA = "0x16EB060")]
		private static IUserReportingPlatform GetPlatform()
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x16EB7C8", Offset = "0x16EB7C8", VA = "0x16EB7C8")]
		public static void Use(UserReportingClient client)
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class UnityUserReportingPlatform : IUserReportingPlatform, ILogListener
	{
		[Token(Token = "0x2000054")]
		private struct LogMessage
		{
			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string LogString;

			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public LogType LogType;

			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string StackTrace;
		}

		[Token(Token = "0x2000055")]
		private class PostOperation
		{
			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50510", Offset = "0xE50510")]
			private Action<bool, byte[]> <Callback>k__BackingField;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50520", Offset = "0xE50520")]
			private Action<float, float> <ProgressCallback>k__BackingField;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50530", Offset = "0xE50530")]
			private UnityWebRequest <WebRequest>k__BackingField;

			[Token(Token = "0x17000082")]
			public Action<bool, byte[]> Callback
			{
				[Token(Token = "0x600021C")]
				[Address(RVA = "0x16F87F4", Offset = "0x16F87F4", VA = "0x16F87F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52604", Offset = "0xE52604")]
				get
				{
					return null;
				}
				[Token(Token = "0x600021D")]
				[Address(RVA = "0x16F87FC", Offset = "0x16F87FC", VA = "0x16F87FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52614", Offset = "0xE52614")]
				set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public Action<float, float> ProgressCallback
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0x16F8804", Offset = "0x16F8804", VA = "0x16F8804")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52624", Offset = "0xE52624")]
				get
				{
					return null;
				}
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x16F880C", Offset = "0x16F880C", VA = "0x16F880C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52634", Offset = "0xE52634")]
				set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public UnityWebRequest WebRequest
			{
				[Token(Token = "0x6000220")]
				[Address(RVA = "0x16F8814", Offset = "0x16F8814", VA = "0x16F8814")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52644", Offset = "0xE52644")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000221")]
				[Address(RVA = "0x16F881C", Offset = "0x16F881C", VA = "0x16F881C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52654", Offset = "0xE52654")]
				set
				{
				}
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x16EC484", Offset = "0x16EC484", VA = "0x16EC484")]
			public PostOperation()
			{
			}
		}

		[Token(Token = "0x2000056")]
		private struct ProfilerSampler
		{
			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Recorder Recorder;

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x16ECE70", Offset = "0x16ECE70", VA = "0x16ECE70")]
			public double GetValue()
			{
				return default(double);
			}
		}

		[Token(Token = "0x2000057")]
		private class ScreenshotOperation
		{
			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50540", Offset = "0xE50540")]
			private Action<int, byte[]> <Callback>k__BackingField;

			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50550", Offset = "0xE50550")]
			private int <FrameNumber>k__BackingField;

			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50560", Offset = "0xE50560")]
			private int <MaximumHeight>k__BackingField;

			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50570", Offset = "0xE50570")]
			private int <MaximumWidth>k__BackingField;

			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50580", Offset = "0xE50580")]
			private byte[] <PngData>k__BackingField;

			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50590", Offset = "0xE50590")]
			private object <Source>k__BackingField;

			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE505A0", Offset = "0xE505A0")]
			private ScreenshotStage <Stage>k__BackingField;

			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE505B0", Offset = "0xE505B0")]
			private Texture2D <Texture>k__BackingField;

			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE505C0", Offset = "0xE505C0")]
			private Texture2D <TextureResized>k__BackingField;

			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE505D0", Offset = "0xE505D0")]
			private int <UnityFrame>k__BackingField;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE505E0", Offset = "0xE505E0")]
			private int <WaitFrames>k__BackingField;

			[Token(Token = "0x17000085")]
			public Action<int, byte[]> Callback
			{
				[Token(Token = "0x6000224")]
				[Address(RVA = "0x16F8824", Offset = "0x16F8824", VA = "0x16F8824")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52664", Offset = "0xE52664")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000225")]
				[Address(RVA = "0x16F882C", Offset = "0x16F882C", VA = "0x16F882C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52674", Offset = "0xE52674")]
				set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public int FrameNumber
			{
				[Token(Token = "0x6000226")]
				[Address(RVA = "0x16F8834", Offset = "0x16F8834", VA = "0x16F8834")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52684", Offset = "0xE52684")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000227")]
				[Address(RVA = "0x16F883C", Offset = "0x16F883C", VA = "0x16F883C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52694", Offset = "0xE52694")]
				set
				{
				}
			}

			[Token(Token = "0x17000087")]
			public int MaximumHeight
			{
				[Token(Token = "0x6000228")]
				[Address(RVA = "0x16F8844", Offset = "0x16F8844", VA = "0x16F8844")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE526A4", Offset = "0xE526A4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000229")]
				[Address(RVA = "0x16F884C", Offset = "0x16F884C", VA = "0x16F884C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE526B4", Offset = "0xE526B4")]
				set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public int MaximumWidth
			{
				[Token(Token = "0x600022A")]
				[Address(RVA = "0x16F8854", Offset = "0x16F8854", VA = "0x16F8854")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE526C4", Offset = "0xE526C4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600022B")]
				[Address(RVA = "0x16F885C", Offset = "0x16F885C", VA = "0x16F885C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE526D4", Offset = "0xE526D4")]
				set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public byte[] PngData
			{
				[Token(Token = "0x600022C")]
				[Address(RVA = "0x16F8864", Offset = "0x16F8864", VA = "0x16F8864")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE526E4", Offset = "0xE526E4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600022D")]
				[Address(RVA = "0x16F886C", Offset = "0x16F886C", VA = "0x16F886C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE526F4", Offset = "0xE526F4")]
				set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public object Source
			{
				[Token(Token = "0x600022E")]
				[Address(RVA = "0x16F8874", Offset = "0x16F8874", VA = "0x16F8874")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52704", Offset = "0xE52704")]
				get
				{
					return null;
				}
				[Token(Token = "0x600022F")]
				[Address(RVA = "0x16F887C", Offset = "0x16F887C", VA = "0x16F887C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52714", Offset = "0xE52714")]
				set
				{
				}
			}

			[Token(Token = "0x1700008B")]
			public ScreenshotStage Stage
			{
				[Token(Token = "0x6000230")]
				[Address(RVA = "0x16F8884", Offset = "0x16F8884", VA = "0x16F8884")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52724", Offset = "0xE52724")]
				get
				{
					return default(ScreenshotStage);
				}
				[Token(Token = "0x6000231")]
				[Address(RVA = "0x16F888C", Offset = "0x16F888C", VA = "0x16F888C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52734", Offset = "0xE52734")]
				set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			public Texture2D Texture
			{
				[Token(Token = "0x6000232")]
				[Address(RVA = "0x16F8894", Offset = "0x16F8894", VA = "0x16F8894")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52744", Offset = "0xE52744")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x16F889C", Offset = "0x16F889C", VA = "0x16F889C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52754", Offset = "0xE52754")]
				set
				{
				}
			}

			[Token(Token = "0x1700008D")]
			public Texture2D TextureResized
			{
				[Token(Token = "0x6000234")]
				[Address(RVA = "0x16F88A4", Offset = "0x16F88A4", VA = "0x16F88A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52764", Offset = "0xE52764")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000235")]
				[Address(RVA = "0x16F88AC", Offset = "0x16F88AC", VA = "0x16F88AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52774", Offset = "0xE52774")]
				set
				{
				}
			}

			[Token(Token = "0x1700008E")]
			public int UnityFrame
			{
				[Token(Token = "0x6000236")]
				[Address(RVA = "0x16F88B4", Offset = "0x16F88B4", VA = "0x16F88B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52784", Offset = "0xE52784")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000237")]
				[Address(RVA = "0x16F88BC", Offset = "0x16F88BC", VA = "0x16F88BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52794", Offset = "0xE52794")]
				set
				{
				}
			}

			[Token(Token = "0x1700008F")]
			public int WaitFrames
			{
				[Token(Token = "0x6000238")]
				[Address(RVA = "0x16F88C4", Offset = "0x16F88C4", VA = "0x16F88C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE527A4", Offset = "0xE527A4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000239")]
				[Address(RVA = "0x16F88CC", Offset = "0x16F88CC", VA = "0x16F88CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE527B4", Offset = "0xE527B4")]
				set
				{
				}
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x16EC7E0", Offset = "0x16EC7E0", VA = "0x16EC7E0")]
			public ScreenshotOperation()
			{
			}
		}

		[Token(Token = "0x2000058")]
		private enum ScreenshotStage
		{
			[Token(Token = "0x4000163")]
			Render,
			[Token(Token = "0x4000164")]
			ReadPixels,
			[Token(Token = "0x4000165")]
			GetPixels,
			[Token(Token = "0x4000166")]
			EncodeToPNG,
			[Token(Token = "0x4000167")]
			Done
		}

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<LogMessage> logMessages;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<PostOperation> postOperations;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ProfilerSampler> profilerSamplers;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ScreenshotOperation> screenshotOperations;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Stopwatch screenshotStopwatch;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<PostOperation> taskOperations;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x16EB3C0", Offset = "0x16EB3C0", VA = "0x16EB3C0")]
		public UnityUserReportingPlatform()
		{
		}

		[Token(Token = "0x600020F")]
		public T DeserializeJson<T>(string json)
		{
			return (T)null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x16EB824", Offset = "0x16EB824", VA = "0x16EB824", Slot = "7")]
		public void OnEndOfFrame(UserReportingClient client)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x16EC2B4", Offset = "0x16EC2B4", VA = "0x16EC2B4", Slot = "8")]
		public void Post(string endpoint, string contentType, byte[] content, Action<float, float> progressCallback, Action<bool, byte[]> callback)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x16EC48C", Offset = "0x16EC48C", VA = "0x16EC48C", Slot = "14")]
		public void ReceiveLogMessage(string logString, string stackTrace, LogType logType)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x16EC5FC", Offset = "0x16EC5FC", VA = "0x16EC5FC", Slot = "9")]
		public void RunTask(Func<object> task, Action<object> callback)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x16EC684", Offset = "0x16EC684", VA = "0x16EC684", Slot = "10")]
		public void SendAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x16EC694", Offset = "0x16EC694", VA = "0x16EC694", Slot = "11")]
		public string SerializeJson(object instance)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x16EC6F8", Offset = "0x16EC6F8", VA = "0x16EC6F8", Slot = "12")]
		public void TakeScreenshot(int frameNumber, int maximumWidth, int maximumHeight, object source, Action<int, byte[]> callback)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x16EC7E8", Offset = "0x16EC7E8", VA = "0x16EC7E8", Slot = "13")]
		public void Update(UserReportingClient client)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x16ED0C4", Offset = "0x16ED0C4", VA = "0x16ED0C4", Slot = "15")]
		public virtual IDictionary<string, string> GetDeviceMetadata()
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x16EDAD0", Offset = "0x16EDAD0", VA = "0x16EDAD0", Slot = "16")]
		public virtual Dictionary<string, string> GetSamplerNames()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x16EE008", Offset = "0x16EE008", VA = "0x16EE008", Slot = "17")]
		public virtual void ModifyUserReport(UserReport userReport)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x16EE50C", Offset = "0x16EE50C", VA = "0x16EE50C", Slot = "18")]
		public virtual void SampleAutomaticMetrics(UserReportingClient client)
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class UnityUserReportingUpdater : IEnumerator
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int step;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private WaitForEndOfFrame waitForEndOfFrame;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE505F0", Offset = "0xE505F0")]
		private object <Current>k__BackingField;

		[Token(Token = "0x17000090")]
		public object Current
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x16EE6C0", Offset = "0x16EE6C0", VA = "0x16EE6C0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE527C4", Offset = "0xE527C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x16EE6C8", Offset = "0x16EE6C8", VA = "0x16EE6C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE527D4", Offset = "0xE527D4")]
			private set
			{
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x16EE650", Offset = "0x16EE650", VA = "0x16EE650")]
		public UnityUserReportingUpdater()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x16EE6D0", Offset = "0x16EE6D0", VA = "0x16EE6D0", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x16EF348", Offset = "0x16EF348", VA = "0x16EF348", Slot = "6")]
		public void Reset()
		{
		}
	}
}
namespace Unity.Cloud.UserReporting.Plugin.Version2018_3
{
	[Token(Token = "0x200005A")]
	public class AsyncUnityUserReportingPlatform : IUserReportingPlatform, ILogListener
	{
		[Token(Token = "0x200005B")]
		private struct LogMessage
		{
			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string LogString;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public LogType LogType;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string StackTrace;
		}

		[Token(Token = "0x200005C")]
		private class PostOperation
		{
			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50600", Offset = "0xE50600")]
			private Action<bool, byte[]> <Callback>k__BackingField;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50610", Offset = "0xE50610")]
			private Action<float, float> <ProgressCallback>k__BackingField;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50620", Offset = "0xE50620")]
			private UnityWebRequest <WebRequest>k__BackingField;

			[Token(Token = "0x17000091")]
			public Action<bool, byte[]> Callback
			{
				[Token(Token = "0x600024E")]
				[Address(RVA = "0x16F6420", Offset = "0x16F6420", VA = "0x16F6420")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE527E4", Offset = "0xE527E4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600024F")]
				[Address(RVA = "0x16F6428", Offset = "0x16F6428", VA = "0x16F6428")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE527F4", Offset = "0xE527F4")]
				set
				{
				}
			}

			[Token(Token = "0x17000092")]
			public Action<float, float> ProgressCallback
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x16F6430", Offset = "0x16F6430", VA = "0x16F6430")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52804", Offset = "0xE52804")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000251")]
				[Address(RVA = "0x16F6438", Offset = "0x16F6438", VA = "0x16F6438")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52814", Offset = "0xE52814")]
				set
				{
				}
			}

			[Token(Token = "0x17000093")]
			public UnityWebRequest WebRequest
			{
				[Token(Token = "0x6000252")]
				[Address(RVA = "0x16F6440", Offset = "0x16F6440", VA = "0x16F6440")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52824", Offset = "0xE52824")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000253")]
				[Address(RVA = "0x16F6448", Offset = "0x16F6448", VA = "0x16F6448")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52834", Offset = "0xE52834")]
				set
				{
				}
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x16F6450", Offset = "0x16F6450", VA = "0x16F6450")]
			public PostOperation()
			{
			}
		}

		[Token(Token = "0x200005D")]
		private struct ProfilerSampler
		{
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Recorder Recorder;

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x16F6458", Offset = "0x16F6458", VA = "0x16F6458")]
			public double GetValue()
			{
				return default(double);
			}
		}

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<LogMessage> logMessages;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<PostOperation> postOperations;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ProfilerSampler> profilerSamplers;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ScreenshotManager screenshotManager;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<PostOperation> taskOperations;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x25588F0", Offset = "0x25588F0", VA = "0x25588F0")]
		public AsyncUnityUserReportingPlatform()
		{
		}

		[Token(Token = "0x6000241")]
		public T DeserializeJson<T>(string json)
		{
			return (T)null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2558CAC", Offset = "0x2558CAC", VA = "0x2558CAC", Slot = "7")]
		public void OnEndOfFrame(UserReportingClient client)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2558CC8", Offset = "0x2558CC8", VA = "0x2558CC8", Slot = "8")]
		public void Post(string endpoint, string contentType, byte[] content, Action<float, float> progressCallback, Action<bool, byte[]> callback)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2558E98", Offset = "0x2558E98", VA = "0x2558E98", Slot = "14")]
		public void ReceiveLogMessage(string logString, string stackTrace, LogType logType)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2559008", Offset = "0x2559008", VA = "0x2559008", Slot = "9")]
		public void RunTask(Func<object> task, Action<object> callback)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2559090", Offset = "0x2559090", VA = "0x2559090", Slot = "10")]
		public void SendAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x25590A0", Offset = "0x25590A0", VA = "0x25590A0", Slot = "11")]
		public string SerializeJson(object instance)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2559104", Offset = "0x2559104", VA = "0x2559104", Slot = "12")]
		public void TakeScreenshot(int frameNumber, int maximumWidth, int maximumHeight, object source, Action<int, byte[]> callback)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2559134", Offset = "0x2559134", VA = "0x2559134", Slot = "13")]
		public void Update(UserReportingClient client)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x25597AC", Offset = "0x25597AC", VA = "0x25597AC", Slot = "15")]
		public virtual IDictionary<string, string> GetDeviceMetadata()
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x255A1B8", Offset = "0x255A1B8", VA = "0x255A1B8", Slot = "16")]
		public virtual Dictionary<string, string> GetSamplerNames()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x255A6F0", Offset = "0x255A6F0", VA = "0x255A6F0", Slot = "17")]
		public virtual void ModifyUserReport(UserReport userReport)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x255AB2C", Offset = "0x255AB2C", VA = "0x255AB2C", Slot = "18")]
		public virtual void SampleAutomaticMetrics(UserReportingClient client)
		{
		}
	}
}
namespace Unity.Cloud.UserReporting.Plugin.SimpleJson
{
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "GeneratedCodeAttribute", RVA = "0xE4E34C", Offset = "0xE4E34C")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xE4E34C", Offset = "0xE4E34C")]
	public class JsonArray : List<object>
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2B2E8D0", Offset = "0x2B2E8D0", VA = "0x2B2E8D0")]
		public JsonArray()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2B2E948", Offset = "0x2B2E948", VA = "0x2B2E948")]
		public JsonArray(int capacity)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2B2E9D0", Offset = "0x2B2E9D0", VA = "0x2B2E9D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xE4E3B8", Offset = "0xE4E3B8")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xE4E3B8", Offset = "0xE4E3B8")]
	[AttributeAttribute(Name = "GeneratedCodeAttribute", RVA = "0xE4E3B8", Offset = "0xE4E3B8")]
	public class JsonObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, object> _members;

		[Token(Token = "0x17000094")]
		public object Item
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x2B2EB74", Offset = "0x2B2EB74", VA = "0x2B2EB74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x2B2F034", Offset = "0x2B2F034", VA = "0x2B2F034", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public ICollection<object> Values
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x2B2F158", Offset = "0x2B2F158", VA = "0x2B2F158", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public object Item
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2B2F1AC", Offset = "0x2B2F1AC", VA = "0x2B2F1AC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x2B2F210", Offset = "0x2B2F210", VA = "0x2B2F210", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public int Count
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x2B2F6F0", Offset = "0x2B2F6F0", VA = "0x2B2F6F0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000099")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x2B2F7DC", Offset = "0x2B2F7DC", VA = "0x2B2F7DC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2B2EA5C", Offset = "0x2B2EA5C", VA = "0x2B2EA5C")]
		public JsonObject()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2B2EAE0", Offset = "0x2B2EAE0", VA = "0x2B2EAE0")]
		public JsonObject(IEqualityComparer<string> comparer)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2B2EB7C", Offset = "0x2B2EB7C", VA = "0x2B2EB7C")]
		internal static object GetAtIndex(IDictionary<string, object> obj, int index)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2B2EF64", Offset = "0x2B2EF64", VA = "0x2B2EF64", Slot = "9")]
		public void Add(string key, object value)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2B2EFD0", Offset = "0x2B2EFD0", VA = "0x2B2EFD0", Slot = "8")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2B2F088", Offset = "0x2B2F088", VA = "0x2B2F088", Slot = "10")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2B2F0EC", Offset = "0x2B2F0EC", VA = "0x2B2F0EC", Slot = "11")]
		public bool TryGetValue(string key, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2B2F27C", Offset = "0x2B2F27C", VA = "0x2B2F27C", Slot = "14")]
		public void Add(KeyValuePair<string, object> item)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2B2F300", Offset = "0x2B2F300", VA = "0x2B2F300", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2B2F354", Offset = "0x2B2F354", VA = "0x2B2F354", Slot = "16")]
		public bool Contains(KeyValuePair<string, object> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2B2F414", Offset = "0x2B2F414", VA = "0x2B2F414", Slot = "17")]
		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2B2F7E4", Offset = "0x2B2F7E4", VA = "0x2B2F7E4", Slot = "18")]
		public bool Remove(KeyValuePair<string, object> item)
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2B2F744", Offset = "0x2B2F744", VA = "0x2B2F744", Slot = "19")]
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2B2F854", Offset = "0x2B2F854", VA = "0x2B2F854", Slot = "20")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2B2F8EC", Offset = "0x2B2F8EC", VA = "0x2B2F8EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "GeneratedCodeAttribute", RVA = "0xE4E440", Offset = "0xE4E440")]
	public static class SimpleJson
	{
		[Token(Token = "0x4000179")]
		private const int TOKEN_NONE = 0;

		[Token(Token = "0x400017A")]
		private const int TOKEN_CURLY_OPEN = 1;

		[Token(Token = "0x400017B")]
		private const int TOKEN_CURLY_CLOSE = 2;

		[Token(Token = "0x400017C")]
		private const int TOKEN_SQUARED_OPEN = 3;

		[Token(Token = "0x400017D")]
		private const int TOKEN_SQUARED_CLOSE = 4;

		[Token(Token = "0x400017E")]
		private const int TOKEN_COLON = 5;

		[Token(Token = "0x400017F")]
		private const int TOKEN_COMMA = 6;

		[Token(Token = "0x4000180")]
		private const int TOKEN_STRING = 7;

		[Token(Token = "0x4000181")]
		private const int TOKEN_NUMBER = 8;

		[Token(Token = "0x4000182")]
		private const int TOKEN_TRUE = 9;

		[Token(Token = "0x4000183")]
		private const int TOKEN_FALSE = 10;

		[Token(Token = "0x4000184")]
		private const int TOKEN_NULL = 11;

		[Token(Token = "0x4000185")]
		private const int BUILDER_CAPACITY = 2000;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] EscapeTable;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly char[] EscapeCharacters;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;

		[Token(Token = "0x1700009A")]
		public static IJsonSerializerStrategy CurrentJsonSerializerStrategy
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x2C21158", Offset = "0x2C21158", VA = "0x2C21158")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x2C23B54", Offset = "0x2C23B54", VA = "0x2C23B54")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xE52EBC", Offset = "0xE52EBC")]
		public static PocoJsonSerializerStrategy PocoJsonSerializerStrategy
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x2C23A94", Offset = "0x2C23A94", VA = "0x2C23A94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2C209E8", Offset = "0x2C209E8", VA = "0x2C209E8")]
		static SimpleJson()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2C20BB8", Offset = "0x2C20BB8", VA = "0x2C20BB8")]
		public static object DeserializeObject(string json)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2C20C7C", Offset = "0x2C20C7C", VA = "0x2C20C7C")]
		public static bool TryDeserializeObject(string json, out object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2C20F7C", Offset = "0x2C20F7C", VA = "0x2C20F7C")]
		public static object DeserializeObject(string json, Type type, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2C211F8", Offset = "0x2C211F8", VA = "0x2C211F8")]
		public static object DeserializeObject(string json, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		public static T DeserializeObject<T>(string json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return (T)null;
		}

		[Token(Token = "0x6000275")]
		public static T DeserializeObject<T>(string json)
		{
			return (T)null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2C2126C", Offset = "0x2C2126C", VA = "0x2C2126C")]
		public static string SerializeObject(object json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2C217F0", Offset = "0x2C217F0", VA = "0x2C217F0")]
		public static string SerializeObject(object json)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2C21858", Offset = "0x2C21858", VA = "0x2C21858")]
		public static string EscapeToJavascriptString(string jsonString)
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2C21A28", Offset = "0x2C21A28", VA = "0x2C21A28")]
		private static IDictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2C223F8", Offset = "0x2C223F8", VA = "0x2C223F8")]
		private static JsonArray ParseArray(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2C20D50", Offset = "0x2C20D50", VA = "0x2C20D50")]
		private static object ParseValue(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2C21FCC", Offset = "0x2C21FCC", VA = "0x2C21FCC")]
		private static string ParseString(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2C228CC", Offset = "0x2C228CC", VA = "0x2C228CC")]
		private static string ConvertFromUtf32(int utf32)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2C225A8", Offset = "0x2C225A8", VA = "0x2C225A8")]
		private static object ParseNumber(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2C22A28", Offset = "0x2C22A28", VA = "0x2C22A28")]
		private static int GetLastIndexOfNumber(char[] json, int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2C22818", Offset = "0x2C22818", VA = "0x2C22818")]
		private static void EatWhitespace(char[] json, ref int index)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2C21F54", Offset = "0x2C21F54", VA = "0x2C21F54")]
		private static int LookAhead(char[] json, int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2C21C90", Offset = "0x2C21C90", VA = "0x2C21C90")]
		private static int NextToken(char[] json, ref int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2C2133C", Offset = "0x2C2133C", VA = "0x2C2133C")]
		private static bool SerializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2C22D20", Offset = "0x2C22D20", VA = "0x2C22D20")]
		private static bool SerializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2C2318C", Offset = "0x2C2318C", VA = "0x2C2318C")]
		private static bool SerializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2C22ADC", Offset = "0x2C22ADC", VA = "0x2C22ADC")]
		private static bool SerializeString(string aString, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2C236D0", Offset = "0x2C236D0", VA = "0x2C236D0")]
		private static bool SerializeNumber(object number, StringBuilder builder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2C2352C", Offset = "0x2C2352C", VA = "0x2C2352C")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "GeneratedCodeAttribute", RVA = "0xE4E48C", Offset = "0xE4E48C")]
	public interface IJsonSerializerStrategy
	{
		[Token(Token = "0x600028C")]
		bool TrySerializeNonPrimitiveObject(object input, out object output);

		[Token(Token = "0x600028D")]
		object DeserializeObject(object value, Type type);
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "GeneratedCodeAttribute", RVA = "0xE4E4D8", Offset = "0xE4E4D8")]
	public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IDictionary<Type, ReflectionUtils.ConstructorDelegate> ConstructorCache;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal IDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>> GetCache;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal IDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>> SetCache;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Type[] EmptyTypes;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly Type[] ArrayConstructorParameterTypes;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string[] Iso8601Format;

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2B34400", Offset = "0x2B34400", VA = "0x2B34400")]
		public PocoJsonSerializerStrategy()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2B3461C", Offset = "0x2B3461C", VA = "0x2B3461C", Slot = "6")]
		protected virtual string MapClrMemberNameToJsonFieldName(string clrPropertyName)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2B34624", Offset = "0x2B34624", VA = "0x2B34624", Slot = "7")]
		internal virtual ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(Type key)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2B34770", Offset = "0x2B34770", VA = "0x2B34770", Slot = "8")]
		internal virtual IDictionary<string, ReflectionUtils.GetDelegate> GetterValueFactory(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2B350F4", Offset = "0x2B350F4", VA = "0x2B350F4", Slot = "9")]
		internal virtual IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> SetterValueFactory(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2B35AF4", Offset = "0x2B35AF4", VA = "0x2B35AF4", Slot = "10")]
		public virtual bool TrySerializeNonPrimitiveObject(object input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2B35B60", Offset = "0x2B35B60", VA = "0x2B35B60", Slot = "11")]
		public virtual object DeserializeObject(object value, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2B38B6C", Offset = "0x2B38B6C", VA = "0x2B38B6C", Slot = "12")]
		protected virtual object SerializeEnum(Enum p)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2B38C40", Offset = "0x2B38C40", VA = "0x2B38C40", Slot = "13")]
		protected virtual bool TrySerializeKnownTypes(object input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2B38FA4", Offset = "0x2B38FA4", VA = "0x2B38FA4", Slot = "14")]
		protected virtual bool TrySerializeUnknownTypes(object input, out object output)
		{
			return default(bool);
		}
	}
}
namespace Unity.Cloud.UserReporting.Plugin.SimpleJson.Reflection
{
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "GeneratedCodeAttribute", RVA = "0xE4E524", Offset = "0xE4E524")]
	internal class ReflectionUtils
	{
		[Token(Token = "0x2000064")]
		public delegate object GetDelegate(object source);

		[Token(Token = "0x2000065")]
		public delegate void SetDelegate(object source, object value);

		[Token(Token = "0x2000066")]
		public delegate object ConstructorDelegate(params object[] args);

		[Token(Token = "0x2000067")]
		public delegate TValue ThreadSafeDictionaryValueFactory<TKey, TValue>(TKey key);

		[Token(Token = "0x2000068")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xE4E570", Offset = "0xE4E570")]
		public sealed class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
		{
			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Dictionary<TKey, TValue> _dictionary;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly object _lock;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;

			[Token(Token = "0x1700009C")]
			public int Count
			{
				[Token(Token = "0x60002CA")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700009D")]
			public bool IsReadOnly
			{
				[Token(Token = "0x60002CB")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009E")]
			public TValue Item
			{
				[Token(Token = "0x60002CC")]
				get
				{
					return (TValue)null;
				}
				[Token(Token = "0x60002CD")]
				set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public ICollection<TKey> Keys
			{
				[Token(Token = "0x60002CE")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			public ICollection<TValue> Values
			{
				[Token(Token = "0x60002CF")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C9")]
			public ThreadSafeDictionary(ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
			{
			}

			[Token(Token = "0x60002D0")]
			public void Add(TKey key, TValue value)
			{
			}

			[Token(Token = "0x60002D1")]
			public void Add(KeyValuePair<TKey, TValue> item)
			{
			}

			[Token(Token = "0x60002D2")]
			private TValue AddValue(TKey key)
			{
				return (TValue)null;
			}

			[Token(Token = "0x60002D3")]
			public void Clear()
			{
			}

			[Token(Token = "0x60002D4")]
			public bool Contains(KeyValuePair<TKey, TValue> item)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D5")]
			public bool ContainsKey(TKey key)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D6")]
			public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
			{
			}

			[Token(Token = "0x60002D7")]
			private TValue Get(TKey key)
			{
				return (TValue)null;
			}

			[Token(Token = "0x60002D8")]
			public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002D9")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002DA")]
			public bool Remove(TKey key)
			{
				return default(bool);
			}

			[Token(Token = "0x60002DB")]
			public bool Remove(KeyValuePair<TKey, TValue> item)
			{
				return default(bool);
			}

			[Token(Token = "0x60002DC")]
			public bool TryGetValue(TKey key, out TValue value)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E5A8", Offset = "0xE4E5A8")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ConstructorInfo constructorInfo;

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x16F7464", Offset = "0x16F7464", VA = "0x16F7464")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x16F746C", Offset = "0x16F746C", VA = "0x16F746C")]
			internal object <GetConstructorByReflection>b__0(object[] args)
			{
				return null;
			}
		}

		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E5B8", Offset = "0xE4E5B8")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MethodInfo methodInfo;

			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x16F7488", Offset = "0x16F7488", VA = "0x16F7488")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x16F7490", Offset = "0x16F7490", VA = "0x16F7490")]
			internal object <GetGetMethodByReflection>b__0(object source)
			{
				return null;
			}
		}

		[Token(Token = "0x200006B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E5C8", Offset = "0xE4E5C8")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FieldInfo fieldInfo;

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x16F751C", Offset = "0x16F751C", VA = "0x16F751C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x16F7524", Offset = "0x16F7524", VA = "0x16F7524")]
			internal object <GetGetMethodByReflection>b__0(object source)
			{
				return null;
			}
		}

		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E5D8", Offset = "0xE4E5D8")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MethodInfo methodInfo;

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x16F7548", Offset = "0x16F7548", VA = "0x16F7548")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x16F7550", Offset = "0x16F7550", VA = "0x16F7550")]
			internal void <GetSetMethodByReflection>b__0(object source, object value)
			{
			}
		}

		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E5E8", Offset = "0xE4E5E8")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FieldInfo fieldInfo;

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x16F761C", Offset = "0x16F761C", VA = "0x16F761C")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x16F7624", Offset = "0x16F7624", VA = "0x16F7624")]
			internal void <GetSetMethodByReflection>b__0(object source, object value)
			{
			}
		}

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object[] EmptyObjects;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2B3AFA4", Offset = "0x2B3AFA4", VA = "0x2B3AFA4")]
		public static Type GetTypeInfo(Type type)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2B3AFA8", Offset = "0x2B3AFA8", VA = "0x2B3AFA8")]
		public static Attribute GetAttribute(MemberInfo info, Type type)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2B3860C", Offset = "0x2B3860C", VA = "0x2B3860C")]
		public static Type GetGenericListElementType(Type type)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2B3B0E0", Offset = "0x2B3B0E0", VA = "0x2B3B0E0")]
		public static Attribute GetAttribute(Type objectType, Type attributeType)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2B383BC", Offset = "0x2B383BC", VA = "0x2B383BC")]
		public static Type[] GetGenericTypeArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2B3B06C", Offset = "0x2B3B06C", VA = "0x2B3B06C")]
		public static bool IsTypeGeneric(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2B383DC", Offset = "0x2B383DC", VA = "0x2B383DC")]
		public static bool IsTypeGenericeCollectionInterface(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2B38588", Offset = "0x2B38588", VA = "0x2B38588")]
		public static bool IsAssignableFrom(Type type1, Type type2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2B3824C", Offset = "0x2B3824C", VA = "0x2B3824C")]
		public static bool IsTypeDictionary(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2B38148", Offset = "0x2B38148", VA = "0x2B38148")]
		public static bool IsNullableType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2B38A8C", Offset = "0x2B38A8C", VA = "0x2B38A8C")]
		public static object ToNullableType(object obj, Type nullableType)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2B3B1BC", Offset = "0x2B3B1BC", VA = "0x2B3B1BC")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2B3B228", Offset = "0x2B3B228", VA = "0x2B3B228")]
		public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2B3B240", Offset = "0x2B3B240", VA = "0x2B3B240")]
		public static ConstructorInfo GetConstructorInfo(Type type, params Type[] argsType)
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2B34FC8", Offset = "0x2B34FC8", VA = "0x2B34FC8")]
		public static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2B35070", Offset = "0x2B35070", VA = "0x2B35070")]
		public static IEnumerable<FieldInfo> GetFields(Type type)
		{
			return null;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2B34FEC", Offset = "0x2B34FEC", VA = "0x2B34FEC")]
		public static MethodInfo GetGetterMethodInfo(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2B35A10", Offset = "0x2B35A10", VA = "0x2B35A10")]
		public static MethodInfo GetSetterMethodInfo(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2B3B69C", Offset = "0x2B3B69C", VA = "0x2B3B69C")]
		public static ConstructorDelegate GetContructor(ConstructorInfo constructorInfo)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2B34700", Offset = "0x2B34700", VA = "0x2B34700")]
		public static ConstructorDelegate GetContructor(Type type, params Type[] argsType)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2B3B6FC", Offset = "0x2B3B6FC", VA = "0x2B3B6FC")]
		public static ConstructorDelegate GetConstructorByReflection(ConstructorInfo constructorInfo)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2B3B7B4", Offset = "0x2B3B7B4", VA = "0x2B3B7B4")]
		public static ConstructorDelegate GetConstructorByReflection(Type type, params Type[] argsType)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2B35010", Offset = "0x2B35010", VA = "0x2B35010")]
		public static GetDelegate GetGetMethod(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2B35094", Offset = "0x2B35094", VA = "0x2B35094")]
		public static GetDelegate GetGetMethod(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2B3B8A0", Offset = "0x2B3B8A0", VA = "0x2B3B8A0")]
		public static GetDelegate GetGetMethodByReflection(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2B3B9A0", Offset = "0x2B3B9A0", VA = "0x2B3B9A0")]
		public static GetDelegate GetGetMethodByReflection(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2B35A34", Offset = "0x2B35A34", VA = "0x2B35A34")]
		public static SetDelegate GetSetMethod(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2B35A94", Offset = "0x2B35A94", VA = "0x2B35A94")]
		public static SetDelegate GetSetMethod(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2B3BA58", Offset = "0x2B3BA58", VA = "0x2B3BA58")]
		public static SetDelegate GetSetMethodByReflection(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2B3BB58", Offset = "0x2B3BB58", VA = "0x2B3BB58")]
		public static SetDelegate GetSetMethodByReflection(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2B3BC10", Offset = "0x2B3BC10", VA = "0x2B3BC10")]
		public ReflectionUtils()
		{
		}
	}
}
namespace Unity.Cloud.UserReporting.Client
{
	[Token(Token = "0x200006E")]
	public interface IUserReportingPlatform
	{
		[Token(Token = "0x60002E7")]
		T DeserializeJson<T>(string json);

		[Token(Token = "0x60002E8")]
		IDictionary<string, string> GetDeviceMetadata();

		[Token(Token = "0x60002E9")]
		void ModifyUserReport(UserReport userReport);

		[Token(Token = "0x60002EA")]
		void OnEndOfFrame(UserReportingClient client);

		[Token(Token = "0x60002EB")]
		void Post(string endpoint, string contentType, byte[] content, Action<float, float> progressCallback, Action<bool, byte[]> callback);

		[Token(Token = "0x60002EC")]
		void RunTask(Func<object> task, Action<object> callback);

		[Token(Token = "0x60002ED")]
		void SendAnalyticsEvent(string eventName, Dictionary<string, object> eventData);

		[Token(Token = "0x60002EE")]
		string SerializeJson(object instance);

		[Token(Token = "0x60002EF")]
		void TakeScreenshot(int frameNumber, int maximumWidth, int maximumHeight, object source, Action<int, byte[]> callback);

		[Token(Token = "0x60002F0")]
		void Update(UserReportingClient client);
	}
	[Token(Token = "0x200006F")]
	public enum MetricsGatheringMode
	{
		[Token(Token = "0x400019A")]
		Automatic,
		[Token(Token = "0x400019B")]
		Manual,
		[Token(Token = "0x400019C")]
		Disabled
	}
	[Token(Token = "0x2000070")]
	public class NullUserReportingPlatform : IUserReportingPlatform
	{
		[Token(Token = "0x60002F1")]
		public T DeserializeJson<T>(string json)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2B32E8C", Offset = "0x2B32E8C", VA = "0x2B32E8C", Slot = "5")]
		public IDictionary<string, string> GetDeviceMetadata()
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2B32EF8", Offset = "0x2B32EF8", VA = "0x2B32EF8", Slot = "6")]
		public void ModifyUserReport(UserReport userReport)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2B32EFC", Offset = "0x2B32EFC", VA = "0x2B32EFC", Slot = "7")]
		public void OnEndOfFrame(UserReportingClient client)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2B32F00", Offset = "0x2B32F00", VA = "0x2B32F00", Slot = "8")]
		public void Post(string endpoint, string contentType, byte[] content, Action<float, float> progressCallback, Action<bool, byte[]> callback)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2B32F98", Offset = "0x2B32F98", VA = "0x2B32F98", Slot = "9")]
		public void RunTask(Func<object> task, Action<object> callback)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2B33020", Offset = "0x2B33020", VA = "0x2B33020", Slot = "10")]
		public void SendAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2B33024", Offset = "0x2B33024", VA = "0x2B33024", Slot = "11")]
		public string SerializeJson(object instance)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2B33070", Offset = "0x2B33070", VA = "0x2B33070", Slot = "12")]
		public void TakeScreenshot(int frameNumber, int maximumWidth, int maximumHeight, object source, Action<int, byte[]> callback)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2B330F8", Offset = "0x2B330F8", VA = "0x2B330F8", Slot = "13")]
		public void Update(UserReportingClient client)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2B330FC", Offset = "0x2B330FC", VA = "0x2B330FC")]
		public NullUserReportingPlatform()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class UserReportingClient
	{
		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E5F8", Offset = "0xE4E5F8")]
		private sealed class <>c__DisplayClass48_0
		{
			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UserReportingClient <>4__this;

			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<UserReport> callback;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<object> <>9__1;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<object> <>9__2;

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x16F13C8", Offset = "0x16F13C8", VA = "0x16F13C8")]
			public <>c__DisplayClass48_0()
			{
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x16F88E8", Offset = "0x16F88E8", VA = "0x16F88E8")]
			internal void <CreateUserReport>b__0()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x16F8AA0", Offset = "0x16F8AA0", VA = "0x16F8AA0")]
			internal object <CreateUserReport>b__1()
			{
				return null;
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x16F9174", Offset = "0x16F9174", VA = "0x16F9174")]
			internal void <CreateUserReport>b__2(object result)
			{
			}
		}

		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E608", Offset = "0xE4E608")]
		private sealed class <>c__DisplayClass58_0
		{
			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<float, float> progressCallback;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UserReportingClient <>4__this;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UserReport userReport;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<bool, UserReport> callback;

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x16F1F0C", Offset = "0x16F1F0C", VA = "0x16F1F0C")]
			public <>c__DisplayClass58_0()
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x16F9220", Offset = "0x16F9220", VA = "0x16F9220")]
			internal void <SendUserReport>b__0(float uploadProgress, float downloadProgress)
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x16F9298", Offset = "0x16F9298", VA = "0x16F9298")]
			internal void <SendUserReport>b__1(bool success, byte[] result)
			{
			}
		}

		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E618", Offset = "0xE4E618")]
		private sealed class <>c__DisplayClass58_1
		{
			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool success;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] result;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass58_0 CS$<>8__locals1;

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x16F9384", Offset = "0x16F9384", VA = "0x16F9384")]
			public <>c__DisplayClass58_1()
			{
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x16F938C", Offset = "0x16F938C", VA = "0x16F938C")]
			internal void <SendUserReport>b__2()
			{
			}
		}

		[Token(Token = "0x2000075")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E628", Offset = "0xE4E628")]
		private sealed class <>c__DisplayClass60_0
		{
			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UserReportingClient <>4__this;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<UserReportScreenshot> callback;

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x16F20EC", Offset = "0x16F20EC", VA = "0x16F20EC")]
			public <>c__DisplayClass60_0()
			{
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x16F9848", Offset = "0x16F9848", VA = "0x16F9848")]
			internal void <TakeScreenshotFromSource>b__0(int passedFrameNumber, byte[] data)
			{
			}
		}

		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E638", Offset = "0xE4E638")]
		private sealed class <>c__DisplayClass60_1
		{
			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int passedFrameNumber;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] data;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass60_0 CS$<>8__locals1;

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x16F9930", Offset = "0x16F9930", VA = "0x16F9930")]
			public <>c__DisplayClass60_1()
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x16F9938", Offset = "0x16F9938", VA = "0x16F9938")]
			internal void <TakeScreenshotFromSource>b__1()
			{
			}
		}

		[Token(Token = "0x2000077")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E648", Offset = "0xE4E648")]
		private sealed class <>c__DisplayClass63_0
		{
			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UserReportingClient <>4__this;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int currentScreenshotsTaken;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action callback;

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x16F20F4", Offset = "0x16F20F4", VA = "0x16F20F4")]
			public <>c__DisplayClass63_0()
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x16F9B88", Offset = "0x16F9B88", VA = "0x16F9B88")]
			internal void <WaitForPerforation>b__0()
			{
			}
		}

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, UserReportMetric> clientMetrics;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, string> currentMeasureMetadata;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, UserReportMetric> currentMetrics;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Action> currentSynchronizedActions;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UserReportNamedValue> deviceMetadata;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CyclicalList<UserReportEvent> events;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int frameNumber;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool isMeasureBoundary;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int measureFrames;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CyclicalList<UserReportMeasure> measures;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CyclicalList<UserReportScreenshot> screenshots;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int screenshotsSaved;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int screenshotsTaken;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Action> synchronizedActions;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Stopwatch updateStopwatch;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50630", Offset = "0xE50630")]
		private UserReportingClientConfiguration <Configuration>k__BackingField;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50640", Offset = "0xE50640")]
		private string <Endpoint>k__BackingField;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50650", Offset = "0xE50650")]
		private bool <IsConnectedToLogger>k__BackingField;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50660", Offset = "0xE50660")]
		private bool <IsSelfReporting>k__BackingField;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50670", Offset = "0xE50670")]
		private IUserReportingPlatform <Platform>k__BackingField;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50680", Offset = "0xE50680")]
		private string <ProjectIdentifier>k__BackingField;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE50690", Offset = "0xE50690")]
		private bool <SendEventsToAnalytics>k__BackingField;

		[Token(Token = "0x170000A1")]
		public UserReportingClientConfiguration Configuration
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x16F0F20", Offset = "0x16F0F20", VA = "0x16F0F20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52844", Offset = "0xE52844")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x16F0F28", Offset = "0x16F0F28", VA = "0x16F0F28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52854", Offset = "0xE52854")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public string Endpoint
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x16F0F30", Offset = "0x16F0F30", VA = "0x16F0F30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52864", Offset = "0xE52864")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x16F0F38", Offset = "0x16F0F38", VA = "0x16F0F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52874", Offset = "0xE52874")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool IsConnectedToLogger
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x16F0F40", Offset = "0x16F0F40", VA = "0x16F0F40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52884", Offset = "0xE52884")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x16F0F48", Offset = "0x16F0F48", VA = "0x16F0F48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52894", Offset = "0xE52894")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool IsSelfReporting
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x16F0F54", Offset = "0x16F0F54", VA = "0x16F0F54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE528A4", Offset = "0xE528A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x16F0F5C", Offset = "0x16F0F5C", VA = "0x16F0F5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE528B4", Offset = "0xE528B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public IUserReportingPlatform Platform
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x16F0F68", Offset = "0x16F0F68", VA = "0x16F0F68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE528C4", Offset = "0xE528C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x16F0F70", Offset = "0x16F0F70", VA = "0x16F0F70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE528D4", Offset = "0xE528D4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public string ProjectIdentifier
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x16F0F78", Offset = "0x16F0F78", VA = "0x16F0F78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE528E4", Offset = "0xE528E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x16F0F80", Offset = "0x16F0F80", VA = "0x16F0F80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE528F4", Offset = "0xE528F4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool SendEventsToAnalytics
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x16F0F88", Offset = "0x16F0F88", VA = "0x16F0F88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52904", Offset = "0xE52904")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x16F0F90", Offset = "0x16F0F90", VA = "0x16F0F90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52914", Offset = "0xE52914")]
			set
			{
			}
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x16EA888", Offset = "0x16EA888", VA = "0x16EA888")]
		public UserReportingClient(string endpoint, string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x16F0DE0", Offset = "0x16F0DE0", VA = "0x16F0DE0")]
		public void AddDeviceMetadata(string name, string value)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x16F0F9C", Offset = "0x16F0F9C", VA = "0x16F0F9C")]
		public void AddMeasureMetadata(string name, string value)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x16F106C", Offset = "0x16F106C", VA = "0x16F106C")]
		private void AddSynchronizedAction(Action action)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x16F11C0", Offset = "0x16F11C0", VA = "0x16F11C0")]
		public void ClearScreenshots()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x16F12BC", Offset = "0x16F12BC", VA = "0x16F12BC")]
		public void CreateUserReport(Action<UserReport> callback)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x16F14F4", Offset = "0x16F14F4", VA = "0x16F14F4")]
		public string GetEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x16ED0B8", Offset = "0x16ED0B8", VA = "0x16ED0B8")]
		public void LogEvent(UserReportEventLevel level, string message)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x16ECE68", Offset = "0x16ECE68", VA = "0x16ECE68")]
		public void LogEvent(UserReportEventLevel level, string message, string stackTrace)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x16F1554", Offset = "0x16F1554", VA = "0x16F1554")]
		private void LogEvent(UserReportEventLevel level, string message, string stackTrace, Exception exception)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x16F176C", Offset = "0x16F176C", VA = "0x16F176C")]
		public void LogException(Exception exception)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x16EC0A0", Offset = "0x16EC0A0", VA = "0x16EC0A0")]
		public void SampleClientMetric(string name, double value)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x16ECEA8", Offset = "0x16ECEA8", VA = "0x16ECEA8")]
		public void SampleMetric(string name, double value)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x16F1780", Offset = "0x16F1780", VA = "0x16F1780")]
		public void SaveUserReportToDisk(UserReport userReport)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x16F1894", Offset = "0x16F1894", VA = "0x16F1894")]
		public void SendUserReport(UserReport userReport, Action<bool, UserReport> callback)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x16F18A0", Offset = "0x16F18A0", VA = "0x16F18A0")]
		public void SendUserReport(UserReport userReport, Action<float, float> progressCallback, Action<bool, UserReport> callback)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x16F1F14", Offset = "0x16F1F14", VA = "0x16F1F14")]
		public void TakeScreenshot(int maximumWidth, int maximumHeight, Action<UserReportScreenshot> callback)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x16F1F20", Offset = "0x16F1F20", VA = "0x16F1F20")]
		public void TakeScreenshotFromSource(int maximumWidth, int maximumHeight, object source, Action<UserReportScreenshot> callback)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x16EE77C", Offset = "0x16EE77C", VA = "0x16EE77C")]
		public void Update()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x16EF230", Offset = "0x16EF230", VA = "0x16EF230")]
		public void UpdateOnEndOfFrame()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x16F13D0", Offset = "0x16F13D0", VA = "0x16F13D0")]
		private void WaitForPerforation(int currentScreenshotsTaken, Action callback)
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class UserReportingClientConfiguration
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE506A0", Offset = "0xE506A0")]
		private int <FramesPerMeasure>k__BackingField;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE506B0", Offset = "0xE506B0")]
		private int <MaximumEventCount>k__BackingField;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE506C0", Offset = "0xE506C0")]
		private int <MaximumMeasureCount>k__BackingField;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE506D0", Offset = "0xE506D0")]
		private int <MaximumScreenshotCount>k__BackingField;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE506E0", Offset = "0xE506E0")]
		private MetricsGatheringMode <MetricsGatheringMode>k__BackingField;

		[Token(Token = "0x170000A8")]
		public int FramesPerMeasure
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x16F219C", Offset = "0x16F219C", VA = "0x16F219C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52924", Offset = "0xE52924")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x16F21A4", Offset = "0x16F21A4", VA = "0x16F21A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52934", Offset = "0xE52934")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public int MaximumEventCount
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x16F21AC", Offset = "0x16F21AC", VA = "0x16F21AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52944", Offset = "0xE52944")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x16F21B4", Offset = "0x16F21B4", VA = "0x16F21B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52954", Offset = "0xE52954")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public int MaximumMeasureCount
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x16F21BC", Offset = "0x16F21BC", VA = "0x16F21BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52964", Offset = "0xE52964")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x16F21C4", Offset = "0x16F21C4", VA = "0x16F21C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52974", Offset = "0xE52974")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public int MaximumScreenshotCount
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x16F21CC", Offset = "0x16F21CC", VA = "0x16F21CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52984", Offset = "0xE52984")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x16F21D4", Offset = "0x16F21D4", VA = "0x16F21D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE52994", Offset = "0xE52994")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public MetricsGatheringMode MetricsGatheringMode
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x16F21DC", Offset = "0x16F21DC", VA = "0x16F21DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE529A4", Offset = "0xE529A4")]
			get
			{
				return default(MetricsGatheringMode);
			}
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x16F21E4", Offset = "0x16F21E4", VA = "0x16F21E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE529B4", Offset = "0xE529B4")]
			internal set
			{
			}
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x16EB1B8", Offset = "0x16EB1B8", VA = "0x16EB1B8")]
		public UserReportingClientConfiguration()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x16F20FC", Offset = "0x16F20FC", VA = "0x16F20FC")]
		public UserReportingClientConfiguration(int maximumEventCount, int maximumMeasureCount, int framesPerMeasure, int maximumScreenshotCount)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x16F2148", Offset = "0x16F2148", VA = "0x16F2148")]
		public UserReportingClientConfiguration(int maximumEventCount, MetricsGatheringMode metricsGatheringMode, int maximumMeasureCount, int framesPerMeasure, int maximumScreenshotCount)
		{
		}
	}
}
namespace Unity.Services.Analytics
{
	[Token(Token = "0x2000079")]
	public class AnalyticsEventHandler : MonoBehaviour
	{
		[StructLayout(3)]
		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E658", Offset = "0xE4E658")]
		private struct <Start>d__5 : IAsyncStateMachine
		{
			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<List<string>> <>u__2;

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x16F5D94", Offset = "0x16F5D94", VA = "0x16F5D94", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x16F6250", Offset = "0x16F6250", VA = "0x16F6250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text consoleOutput;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect consoleScrollRect;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2557404", Offset = "0x2557404", VA = "0x2557404")]
		private void Awake()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2557480", Offset = "0x2557480", VA = "0x2557480")]
		private void OnLogMessageReceived(string condition, string stacktrace, LogType type)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x25575C4", Offset = "0x25575C4", VA = "0x25575C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2557640", Offset = "0x2557640", VA = "0x2557640")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xE529C4", Offset = "0xE529C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2557708", Offset = "0x2557708", VA = "0x2557708")]
		public void RecordMinimalAdImpressionEvent()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2557784", Offset = "0x2557784", VA = "0x2557784")]
		public void RecordCompleteAdImpressionEvent()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2557800", Offset = "0x2557800", VA = "0x2557800")]
		public void RecordSaleTransactionWithOnlyRequiredValues()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x255787C", Offset = "0x255787C", VA = "0x255787C")]
		public void RecordSaleTransactionWithRealCurrency()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x25578F8", Offset = "0x25578F8", VA = "0x25578F8")]
		public void RecordSaleTransactionWithVirtualCurrency()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2557974", Offset = "0x2557974", VA = "0x2557974")]
		public void RecordSaleTransactionWithMultipleVirtualCurrencies()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x25579F0", Offset = "0x25579F0", VA = "0x25579F0")]
		public void RecordSaleEventWithOneItem()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x2557A6C", Offset = "0x2557A6C", VA = "0x2557A6C")]
		public void RecordSaleEventWithMultipleItems()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2557AE8", Offset = "0x2557AE8", VA = "0x2557AE8")]
		public void RecordSaleEventWithOptionalParameters()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x2557B64", Offset = "0x2557B64", VA = "0x2557B64")]
		public void RecordAcquisitionSourceEventWithOnlyRequiredValues()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2557BE0", Offset = "0x2557BE0", VA = "0x2557BE0")]
		public void RecordAcquisitionSourceEventWithOptionalParameters()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x2557C5C", Offset = "0x2557C5C", VA = "0x2557C5C")]
		public void RecordPurchaseEventWithOneItem()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x2557CD8", Offset = "0x2557CD8", VA = "0x2557CD8")]
		public void RecordPurchaseEventWithMultipleItems()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2557D54", Offset = "0x2557D54", VA = "0x2557D54")]
		public void RecordPurchaseEventWithMultipleCurrencies()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2557DD0", Offset = "0x2557DD0", VA = "0x2557DD0")]
		public void RecordCustomEventWithNoParameters()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x2557E4C", Offset = "0x2557E4C", VA = "0x2557E4C")]
		public void RecordCustomEventWithParameters()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x2557EC8", Offset = "0x2557EC8", VA = "0x2557EC8")]
		public AnalyticsEventHandler()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public static class CustomEventSample
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x2B257C8", Offset = "0x2B257C8", VA = "0x2B257C8")]
		public static void RecordCustomEventWithNoParameters()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x2B25944", Offset = "0x2B25944", VA = "0x2B25944")]
		public static void RecordCustomEventWithParameters()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class StandardEventSample
	{
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x2C23BC0", Offset = "0x2C23BC0", VA = "0x2C23BC0")]
		public static void RecordMinimalAdImpressionEvent()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x2C23DAC", Offset = "0x2C23DAC", VA = "0x2C23DAC")]
		public static void RecordCompleteAdImpressionEvent()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x2C24180", Offset = "0x2C24180", VA = "0x2C24180")]
		public static void RecordSaleTransactionWithOnlyRequiredValues()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x2C2433C", Offset = "0x2C2433C", VA = "0x2C2433C")]
		public static void RecordSaleTransactionWithRealCurrency()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x2C247A0", Offset = "0x2C247A0", VA = "0x2C247A0")]
		public static void RecordSaleTransactionWithVirtualCurrency()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x2C24B9C", Offset = "0x2C24B9C", VA = "0x2C24B9C")]
		public static void RecordSaleTransactionWithMultipleVirtualCurrencies()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2C24FF0", Offset = "0x2C24FF0", VA = "0x2C24FF0")]
		public static void RecordSaleEventWithOneItem()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x2C253CC", Offset = "0x2C253CC", VA = "0x2C253CC")]
		public static void RecordSaleEventWithMultipleItems()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x2C259BC", Offset = "0x2C259BC", VA = "0x2C259BC")]
		public static void RecordSaleEventWithOptionalParameters()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2C25D5C", Offset = "0x2C25D5C", VA = "0x2C25D5C")]
		public static void RecordAcquisitionSourceEventWithOnlyRequiredValues()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x2C25F64", Offset = "0x2C25F64", VA = "0x2C25F64")]
		public static void RecordAcquisitionSourceEventWithOptionalParameters()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2C26210", Offset = "0x2C26210", VA = "0x2C26210")]
		public static void RecordPurchaseEventWithOneItem()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x2C2667C", Offset = "0x2C2667C", VA = "0x2C2667C")]
		public static void RecordPurchaseEventWithMultipleItems()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2C26AF0", Offset = "0x2C26AF0", VA = "0x2C26AF0")]
		public static void RecordPurchaseEventWithMultipleCurrencies()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x2C26F40", Offset = "0x2C26F40", VA = "0x2C26F40")]
		public StandardEventSample()
		{
		}
	}
}
namespace LIV.SDK.Unity
{
	[Token(Token = "0x200007D")]
	[Flags]
	public enum INVALIDATION_FLAGS : uint
	{
		[Token(Token = "0x40001D2")]
		NONE = 0u,
		[Token(Token = "0x40001D3")]
		HMD_CAMERA = 1u,
		[Token(Token = "0x40001D4")]
		STAGE = 2u,
		[Token(Token = "0x40001D5")]
		MR_CAMERA_PREFAB = 4u,
		[Token(Token = "0x40001D6")]
		EXCLUDE_BEHAVIOURS = 8u
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4E678", Offset = "0xE4E678")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xE4E678", Offset = "0xE4E678")]
	public class LIV : MonoBehaviour
	{
		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E6D8", Offset = "0xE4E6D8")]
		private sealed class <WaitForUnityEndOfFrame>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LIV <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600038D")]
				[Address(RVA = "0x16F6D6C", Offset = "0x16F6D6C", VA = "0x16F6D6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600038F")]
				[Address(RVA = "0x16F6DB4", Offset = "0x16F6DB4", VA = "0x16F6DB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x16F6C5C", Offset = "0x16F6C5C", VA = "0x16F6C5C")]
			[DebuggerHidden]
			public <WaitForUnityEndOfFrame>d__68(int <>1__state)
			{
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x16F6C88", Offset = "0x16F6C88", VA = "0x16F6C88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x16F6C8C", Offset = "0x16F6C8C", VA = "0x16F6C8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x16F6D74", Offset = "0x16F6D74", VA = "0x16F6D74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onActivate;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<SDKRender> onPreRender;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<SDKRender> onPreRenderBackground;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<SDKRender> onPostRenderBackground;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<SDKRender> onPreRenderForeground;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<SDKRender> onPostRenderForeground;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<SDKRender> onPostRender;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action onDeactivate;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE50710", Offset = "0xE50710")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE50710", Offset = "0xE50710")]
		private Transform _stage;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE50780", Offset = "0xE50780")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE50780", Offset = "0xE50780")]
		private Transform _stageTransform;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE507F0", Offset = "0xE507F0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE507F0", Offset = "0xE507F0")]
		private Camera _HMDCamera;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE50860", Offset = "0xE50860")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE50860", Offset = "0xE50860")]
		private Camera _MRCameraPrefab;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE508D0", Offset = "0xE508D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE508D0", Offset = "0xE508D0")]
		private bool _disableStandardAssets;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE50940", Offset = "0xE50940")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE50940", Offset = "0xE50940")]
		[SerializeField]
		private LayerMask _spectatorLayerMask;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE509B0", Offset = "0xE509B0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE509B0", Offset = "0xE509B0")]
		[SerializeField]
		private string[] _excludeBehaviours;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xE50A20", Offset = "0xE50A20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE50A20", Offset = "0xE50A20")]
		private bool _fixPostEffectsAlpha;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _isActive;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private SDKRender _render;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _wasReady;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private INVALIDATION_FLAGS _invalidate;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform _stageCandidate;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Camera _HMDCameraCandidate;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera _MRCameraPrefabCandidate;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string[] _excludeBehavioursCandidate;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _enabled;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Coroutine _waitForEndOfFrameCoroutine;

		[Token(Token = "0x170000AD")]
		public Transform stage
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x2B2F950", Offset = "0x2B2F950", VA = "0x2B2F950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x2B2F9EC", Offset = "0x2B2F9EC", VA = "0x2B2F9EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE52ED0", Offset = "0xE52ED0")]
		public Transform trackedSpaceOrigin
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x2B2FB0C", Offset = "0x2B2FB0C", VA = "0x2B2FB0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x2B2FB10", Offset = "0x2B2FB10", VA = "0x2B2FB10")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public Matrix4x4 stageLocalToWorldMatrix
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x2B2FB14", Offset = "0x2B2FB14", VA = "0x2B2FB14")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x170000B0")]
		public Matrix4x4 stageWorldToLocalMatrix
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x2B2FBE4", Offset = "0x2B2FBE4", VA = "0x2B2FBE4")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x170000B1")]
		public Transform stageTransform
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x2B2FCB4", Offset = "0x2B2FCB4", VA = "0x2B2FCB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x2B2FCBC", Offset = "0x2B2FCBC", VA = "0x2B2FCBC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public Camera HMDCamera
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x2B2FCC4", Offset = "0x2B2FCC4", VA = "0x2B2FCC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x2B2FCCC", Offset = "0x2B2FCCC", VA = "0x2B2FCCC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public Camera MRCameraPrefab
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x2B2FDEC", Offset = "0x2B2FDEC", VA = "0x2B2FDEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x2B2FDF4", Offset = "0x2B2FDF4", VA = "0x2B2FDF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public bool disableStandardAssets
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x2B2FE9C", Offset = "0x2B2FE9C", VA = "0x2B2FE9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x2B2FEA4", Offset = "0x2B2FEA4", VA = "0x2B2FEA4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public LayerMask spectatorLayerMask
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x2B2FEB0", Offset = "0x2B2FEB0", VA = "0x2B2FEB0")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x2B2FEB8", Offset = "0x2B2FEB8", VA = "0x2B2FEB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public string[] excludeBehaviours
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x2B2FEC0", Offset = "0x2B2FEC0", VA = "0x2B2FEC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x2B2FEC8", Offset = "0x2B2FEC8", VA = "0x2B2FEC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public bool fixPostEffectsAlpha
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x2B2FF14", Offset = "0x2B2FF14", VA = "0x2B2FF14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x2B2FF1C", Offset = "0x2B2FF1C", VA = "0x2B2FF1C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public bool isValid
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x2B2FF28", Offset = "0x2B2FF28", VA = "0x2B2FF28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B9")]
		public bool isActive
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x2B300C4", Offset = "0x2B300C4", VA = "0x2B300C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BA")]
		private bool _isReady
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x2B300CC", Offset = "0x2B300CC", VA = "0x2B300CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public SDKRender render
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x2B30150", Offset = "0x2B30150", VA = "0x2B30150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x2B30158", Offset = "0x2B30158", VA = "0x2B30158")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x2B301BC", Offset = "0x2B301BC", VA = "0x2B301BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2B30350", Offset = "0x2B30350", VA = "0x2B30350")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2B30358", Offset = "0x2B30358", VA = "0x2B30358")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE52A34", Offset = "0xE52A34")]
		private IEnumerator WaitForUnityEndOfFrame()
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2B30164", Offset = "0x2B30164", VA = "0x2B30164")]
		private void UpdateSDKReady()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x2B303D0", Offset = "0x2B303D0", VA = "0x2B303D0")]
		private void OnSDKReadyChanged(bool value)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2B303DC", Offset = "0x2B303DC", VA = "0x2B303DC")]
		private void OnSDKActivate()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2B3048C", Offset = "0x2B3048C", VA = "0x2B3048C")]
		private void OnSDKDeactivate()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2B3073C", Offset = "0x2B3073C", VA = "0x2B3073C")]
		private void CreateAssets()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x2B30838", Offset = "0x2B30838", VA = "0x2B30838")]
		private void DestroyAssets()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x2B307AC", Offset = "0x2B307AC", VA = "0x2B307AC")]
		private void StartRenderCoroutine()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x2B307F0", Offset = "0x2B307F0", VA = "0x2B307F0")]
		private void StopRenderCoroutine()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2B3052C", Offset = "0x2B3052C", VA = "0x2B3052C")]
		private void SubmitSDKOutput()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x2B301E0", Offset = "0x2B301E0", VA = "0x2B301E0")]
		private void Invalidate()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2B3087C", Offset = "0x2B3087C", VA = "0x2B3087C")]
		public LIV()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public static class SDKBridge
	{
		[Token(Token = "0x2000081")]
		public struct SDKInjection<T>
		{
			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool active;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action action;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T data;
		}

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SDKInjection<SDKInputFrame> _injection_SDKInputFrame;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static SDKInjection<SDKResolution> _injection_SDKResolution;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static SDKInjection<bool> _injection_IsActive;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static bool _injection_DisableSubmit;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x199")]
		private static bool _injection_DisableSubmitApplicationOutput;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19A")]
		private static bool _injection_DisableAddTexture;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19B")]
		private static bool _injection_DisableCreateFrame;

		[Token(Token = "0x170000BE")]
		public static bool IsActive
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x2C14BD4", Offset = "0x2C14BD4", VA = "0x2C14BD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2C1473C", Offset = "0x2C1473C", VA = "0x2C1473C")]
		public static int AddStringToChannel(int slot, IntPtr str, int length, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2C14744", Offset = "0x2C14744", VA = "0x2C14744")]
		public static int addtexture(IntPtr sourcetexture, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2C1474C", Offset = "0x2C1474C", VA = "0x2C1474C")]
		public static ulong GetObjectTimeStamp(IntPtr obj)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2C14754", Offset = "0x2C14754", VA = "0x2C14754")]
		public static ulong GetCurrentTimeTicks()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2C1475C", Offset = "0x2C1475C", VA = "0x2C1475C")]
		private static bool GetIsCaptureActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x2C14764", Offset = "0x2C14764", VA = "0x2C14764")]
		public static IntPtr GetRenderEventFunc()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2C147A0", Offset = "0x2C147A0", VA = "0x2C147A0")]
		public static IntPtr GetCompositorChannelObject(int slot, ulong tag, ulong timestamp)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x2C147DC", Offset = "0x2C147DC", VA = "0x2C147DC")]
		public static int AddObjectToCompositorChannel(int slot, IntPtr obj, int objectsize, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x2C147E4", Offset = "0x2C147E4", VA = "0x2C147E4")]
		public static int AddObjectToFrame(IntPtr obj, int objectsize, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2C147EC", Offset = "0x2C147EC", VA = "0x2C147EC")]
		public static IntPtr updatinputframe(IntPtr InputFrame)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2C14828", Offset = "0x2C14828", VA = "0x2C14828")]
		public static IntPtr GetViewportTexture()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2C14864", Offset = "0x2C14864", VA = "0x2C14864")]
		public static IntPtr GetChannelObject(int slot, ulong tag, ulong timestamp)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2C148A0", Offset = "0x2C148A0", VA = "0x2C148A0")]
		public static int AddObjectToChannel(int slot, IntPtr obj, int objectsize, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x2C148A8", Offset = "0x2C148A8", VA = "0x2C148A8")]
		public static ulong Tag(string str)
		{
			return default(ulong);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x2C14930", Offset = "0x2C14930", VA = "0x2C14930")]
		public static void AddString(string tag, string value, int slot)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2C14A40", Offset = "0x2C14A40", VA = "0x2C14A40")]
		public static void AddTexture(SDKTexture texture, ulong tag)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2C14B04", Offset = "0x2C14B04", VA = "0x2C14B04")]
		public static ulong GetObjectTime(IntPtr objectptr)
		{
			return default(ulong);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2C14B6C", Offset = "0x2C14B6C", VA = "0x2C14B6C")]
		public static ulong GetCurrentTime()
		{
			return default(ulong);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x2C14C88", Offset = "0x2C14C88", VA = "0x2C14C88")]
		public static void IssuePluginEvent()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2C14D3C", Offset = "0x2C14D3C", VA = "0x2C14D3C")]
		public static void SubmitApplicationOutput(SDKApplicationOutput applicationOutput)
		{
		}

		[Token(Token = "0x60003A5")]
		public static bool GetStructFromGlobalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A6")]
		public static int AddStructToGlobalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x60003A7")]
		public static bool GetStructFromLocalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		public static int AddStructToLocalChannel<T>(ref T mystruct, int channel, ulong tag)
		{
			return default(int);
		}

		[Token(Token = "0x60003A9")]
		public static void AddStructToFrame<T>(ref T mystruct, ulong tag)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2C14F40", Offset = "0x2C14F40", VA = "0x2C14F40")]
		public static bool UpdateInputFrame(ref SDKInputFrame setframe)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2C15350", Offset = "0x2C15350", VA = "0x2C15350")]
		public static SDKTexture GetViewfinderTexture()
		{
			return default(SDKTexture);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2C15570", Offset = "0x2C15570", VA = "0x2C15570")]
		public static void AddTexture(SDKTexture texture)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2C156B4", Offset = "0x2C156B4", VA = "0x2C156B4")]
		public static void CreateFrame(SDKOutputFrame frame)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2C15830", Offset = "0x2C15830", VA = "0x2C15830")]
		public static void SetGroundPlane(SDKPlane groundPlane)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2C158DC", Offset = "0x2C158DC", VA = "0x2C158DC")]
		public static bool GetResolution(ref SDKResolution sdkResolution)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000082")]
	public class SDKRender : IDisposable
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LIV _liv;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SDKOutputFrame _outputFrame;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private SDKInputFrame _inputFrame;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private SDKResolution _resolution;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Camera _cameraInstance;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private SDKPose _requestedPose;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private int _requestedPoseFrameIndex;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private SDKPass _clipPlanePass;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private SDKPass _combineAlphaPass;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private SDKPass _captureTexturePass;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private SDKPass _applyTexturePass;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private SDKPass _optimizedRenderingPass;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private RenderPassEvent _clipPlaneRenderPassEvent;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		private RenderPassEvent _addAlphaRenderPassEvent;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private RenderPassEvent _captureTextureRenderPassEvent;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
		private RenderPassEvent _applyTextureRenderPassEvent;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private RenderPassEvent _optimizedRenderingPassEvent;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private Mesh _clipPlaneMesh;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private Material _clipPlaneSimpleMaterial;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private Material _clipPlaneSimpleDebugMaterial;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private Material _clipPlaneComplexMaterial;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private Material _clipPlaneComplexDebugMaterial;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private Material _writeOpaqueToAlphaMaterial;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private Material _combineAlphaMaterial;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private Material _writeMaterial;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private Material _forceForwardRenderingMaterial;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private RenderTexture _backgroundRenderTexture;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private RenderTexture _foregroundRenderTexture;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private RenderTexture _optimizedRenderTexture;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private RenderTexture _complexClipPlaneRenderTexture;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private UniversalAdditionalCameraData _universalAdditionalCameraData;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private RenderTargetIdentifier _cameraColorTextureIdentifier;

		[Token(Token = "0x170000BF")]
		public LIV liv
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x2C17D3C", Offset = "0x2C17D3C", VA = "0x2C17D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public SDKOutputFrame outputFrame
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x2C17D44", Offset = "0x2C17D44", VA = "0x2C17D44")]
			get
			{
				return default(SDKOutputFrame);
			}
		}

		[Token(Token = "0x170000C1")]
		public SDKInputFrame inputFrame
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x2C17D54", Offset = "0x2C17D54", VA = "0x2C17D54")]
			get
			{
				return default(SDKInputFrame);
			}
		}

		[Token(Token = "0x170000C2")]
		public SDKResolution resolution
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x2C17D64", Offset = "0x2C17D64", VA = "0x2C17D64")]
			get
			{
				return default(SDKResolution);
			}
		}

		[Token(Token = "0x170000C3")]
		public Camera cameraInstance
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x2C17D6C", Offset = "0x2C17D6C", VA = "0x2C17D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public Camera cameraReference
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x2C17D74", Offset = "0x2C17D74", VA = "0x2C17D74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public Camera hmdCamera
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x2C17E0C", Offset = "0x2C17E0C", VA = "0x2C17E0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public Transform stage
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x2C17E28", Offset = "0x2C17E28", VA = "0x2C17E28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public Transform stageTransform
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x2C17E44", Offset = "0x2C17E44", VA = "0x2C17E44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public Matrix4x4 stageLocalToWorldMatrix
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x2C17E60", Offset = "0x2C17E60", VA = "0x2C17E60")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x170000C9")]
		public Matrix4x4 localToWorldMatrix
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x2C17F40", Offset = "0x2C17F40", VA = "0x2C17F40")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x170000CA")]
		public int spectatorLayerMask
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x2C18010", Offset = "0x2C18010", VA = "0x2C18010")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CB")]
		public bool disableStandardAssets
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x2C18030", Offset = "0x2C18030", VA = "0x2C18030")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CC")]
		public bool canSetPose
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x2C1804C", Offset = "0x2C1804C", VA = "0x2C1804C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		private bool useDeferredRendering
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x2C19824", Offset = "0x2C19824", VA = "0x2C19824")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		private bool interlacedRendering
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x2C1987C", Offset = "0x2C1987C", VA = "0x2C1987C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		private bool canRenderBackground
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x2C19888", Offset = "0x2C19888", VA = "0x2C19888")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D0")]
		private bool canRenderForeground
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x2C19920", Offset = "0x2C19920", VA = "0x2C19920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D1")]
		private bool canRenderOptimized
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x2C199CC", Offset = "0x2C199CC", VA = "0x2C199CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2C1806C", Offset = "0x2C1806C", VA = "0x2C1806C")]
		public bool SetPose(Vector3 position, Quaternion rotation, float verticalFieldOfView = 60f, bool useLocalSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2C183F0", Offset = "0x2C183F0", VA = "0x2C183F0")]
		public void SetGroundPlane(float distance, Vector3 normal, bool useLocalSpace = false)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2C185A0", Offset = "0x2C185A0", VA = "0x2C185A0")]
		public void SetGroundPlane(Plane plane, bool useLocalSpace = false)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2C1861C", Offset = "0x2C1861C", VA = "0x2C1861C")]
		public void SetGroundPlane(Transform transform, bool useLocalSpace = false)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2C187A4", Offset = "0x2C187A4", VA = "0x2C187A4")]
		private void ReleaseBridgePoseControl()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2C18814", Offset = "0x2C18814", VA = "0x2C18814")]
		private void UpdateBridgeResolution()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2C18878", Offset = "0x2C18878", VA = "0x2C18878")]
		private void UpdateBridgeInputFrame()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2C18A2C", Offset = "0x2C18A2C", VA = "0x2C18A2C")]
		private void InvokePreRender()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2C18A98", Offset = "0x2C18A98", VA = "0x2C18A98")]
		private void IvokePostRender()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2C18B04", Offset = "0x2C18B04", VA = "0x2C18B04")]
		private void InvokePreRenderBackground()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2C18B70", Offset = "0x2C18B70", VA = "0x2C18B70")]
		private void InvokePostRenderBackground()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2C18BDC", Offset = "0x2C18BDC", VA = "0x2C18BDC")]
		private void InvokePreRenderForeground()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2C18C48", Offset = "0x2C18C48", VA = "0x2C18C48")]
		private void InvokePostRenderForeground()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2C18CB4", Offset = "0x2C18CB4", VA = "0x2C18CB4")]
		private void CreateBackgroundTexture()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x2C18EF0", Offset = "0x2C18EF0", VA = "0x2C18EF0")]
		private void CreateForegroundTexture()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2C18F90", Offset = "0x2C18F90", VA = "0x2C18F90")]
		private void CreateOptimizedTexture()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2C19030", Offset = "0x2C19030", VA = "0x2C19030")]
		private void CreateComplexClipPlaneTexture()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2C190D0", Offset = "0x2C190D0", VA = "0x2C190D0")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2C1944C", Offset = "0x2C1944C", VA = "0x2C1944C")]
		private void SendTextureToBridge(RenderTexture texture, TEXTURE_ID id)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2C19654", Offset = "0x2C19654", VA = "0x2C19654")]
		private Material GetClipPlaneMaterial(bool debugClipPlane, bool complexClipPlane, ColorWriteMask colorWriteMask)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x2C1977C", Offset = "0x2C1977C", VA = "0x2C1977C")]
		private Material GetGroundClipPlaneMaterial(bool debugClipPlane, ColorWriteMask colorWriteMask)
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x2C19A50", Offset = "0x2C19A50", VA = "0x2C19A50")]
		public SDKRender(LIV liv)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x2C1A520", Offset = "0x2C1A520", VA = "0x2C1A520")]
		public void Render()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x2C1A6F4", Offset = "0x2C1A6F4", VA = "0x2C1A6F4")]
		private void RenderBackground()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x2C1AA18", Offset = "0x2C1AA18", VA = "0x2C1AA18")]
		private void RenderForeground()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2C1B460", Offset = "0x2C1B460", VA = "0x2C1B460")]
		private void RenderOptimized()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2C19C28", Offset = "0x2C19C28", VA = "0x2C19C28")]
		private void CreateAssets()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2C1CC0C", Offset = "0x2C1CC0C", VA = "0x2C1CC0C")]
		private void DestroyAssets()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2C1CDE4", Offset = "0x2C1CDE4", VA = "0x2C1CDE4", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000083")]
	internal static class SDKShaders
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int LIV_COLOR_MASK;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int LIV_TESSELLATION_PROPERTY;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int LIV_CLIP_PLANE_HEIGHT_MAP_PROPERTY;

		[Token(Token = "0x4000221")]
		public const string LIV_MR_FOREGROUND_KEYWORD = "LIV_MR_FOREGROUND";

		[Token(Token = "0x4000222")]
		public const string LIV_MR_BACKGROUND_KEYWORD = "LIV_MR_BACKGROUND";

		[Token(Token = "0x4000223")]
		public const string LIV_MR_KEYWORD = "LIV_MR";

		[Token(Token = "0x4000224")]
		public const string LIV_CLIP_PLANE_SIMPLE_SHADER = "Hidden/LIV_ClipPlaneSimple";

		[Token(Token = "0x4000225")]
		public const string LIV_CLIP_PLANE_SIMPLE_DEBUG_SHADER = "Hidden/LIV_ClipPlaneSimpleDebug";

		[Token(Token = "0x4000226")]
		public const string LIV_CLIP_PLANE_COMPLEX_SHADER = "Hidden/LIV_ClipPlaneComplex";

		[Token(Token = "0x4000227")]
		public const string LIV_CLIP_PLANE_COMPLEX_DEBUG_SHADER = "Hidden/LIV_ClipPlaneComplexDebug";

		[Token(Token = "0x4000228")]
		public const string LIV_WRITE_OPAQUE_TO_ALPHA_SHADER = "Hidden/LIV_WriteOpaqueToAlpha";

		[Token(Token = "0x4000229")]
		public const string LIV_COMBINE_ALPHA_SHADER = "Hidden/LIV_CombineAlpha";

		[Token(Token = "0x400022A")]
		public const string LIV_WRITE_SHADER = "Hidden/LIV_Write";

		[Token(Token = "0x400022B")]
		public const string LIV_FORCE_FORWARD_RENDERING_SHADER = "Hidden/LIV_ForceForwardRendering";

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2C1BD18", Offset = "0x2C1BD18", VA = "0x2C1BD18")]
		public static void StartRendering()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2C1BDF0", Offset = "0x2C1BDF0", VA = "0x2C1BDF0")]
		public static void StopRendering()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2C1C28C", Offset = "0x2C1C28C", VA = "0x2C1C28C")]
		public static void StartForegroundRendering()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2C1C2D4", Offset = "0x2C1C2D4", VA = "0x2C1C2D4")]
		public static void StopForegroundRendering()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2C1BD60", Offset = "0x2C1BD60", VA = "0x2C1BD60")]
		public static void StartBackgroundRendering()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2C1BDA8", Offset = "0x2C1BDA8", VA = "0x2C1BDA8")]
		public static void StopBackgroundRendering()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public struct SDKConstants
	{
		[Token(Token = "0x400022C")]
		public const string SDK_ID = "XHYEMXULL51BUMFOBOJOXXP9DAIQ37EL";

		[Token(Token = "0x400022D")]
		public const string SDK_VERSION = "1.5.4";

		[Token(Token = "0x400022E")]
		public const string ENGINE_NAME = "unity";
	}
	[Token(Token = "0x2000085")]
	public enum PRIORITY : sbyte
	{
		[Token(Token = "0x4000230")]
		NONE = 0,
		[Token(Token = "0x4000231")]
		GAME = 63
	}
	[Token(Token = "0x2000086")]
	[Flags]
	public enum FEATURES : ulong
	{
		[Token(Token = "0x4000233")]
		NONE = 0uL,
		[Token(Token = "0x4000234")]
		BACKGROUND_RENDER = 1uL,
		[Token(Token = "0x4000235")]
		FOREGROUND_RENDER = 2uL,
		[Token(Token = "0x4000236")]
		COMPLEX_CLIP_PLANE = 4uL,
		[Token(Token = "0x4000237")]
		BACKGROUND_DEPTH_RENDER = 8uL,
		[Token(Token = "0x4000238")]
		OVERRIDE_POST_PROCESSING = 0x10uL,
		[Token(Token = "0x4000239")]
		FIX_FOREGROUND_ALPHA = 0x20uL,
		[Token(Token = "0x400023A")]
		GROUND_CLIP_PLANE = 0x40uL,
		[Token(Token = "0x400023B")]
		RELEASE_CONTROL = 0x8000uL,
		[Token(Token = "0x400023C")]
		OPTIMIZED_RENDER = 0x10000000uL,
		[Token(Token = "0x400023D")]
		INTERLACED_RENDER = 0x20000000uL,
		[Token(Token = "0x400023E")]
		DEBUG_CLIP_PLANE = 0x1000000000000uL
	}
	[Token(Token = "0x2000087")]
	public enum TEXTURE_ID : uint
	{
		[Token(Token = "0x4000240")]
		UNDEFINED = 0u,
		[Token(Token = "0x4000241")]
		BACKGROUND_COLOR_BUFFER_ID = 10u,
		[Token(Token = "0x4000242")]
		FOREGROUND_COLOR_BUFFER_ID = 20u,
		[Token(Token = "0x4000243")]
		OPTIMIZED_COLOR_BUFFER_ID = 30u
	}
	[Token(Token = "0x2000088")]
	public enum TEXTURE_TYPE : uint
	{
		[Token(Token = "0x4000245")]
		UNDEFINED,
		[Token(Token = "0x4000246")]
		COLOR_BUFFER
	}
	[Token(Token = "0x2000089")]
	public enum TEXTURE_FORMAT : uint
	{
		[Token(Token = "0x4000248")]
		UNDEFINED = 0u,
		[Token(Token = "0x4000249")]
		ARGB32 = 10u
	}
	[Token(Token = "0x200008A")]
	public enum TEXTURE_DEVICE : uint
	{
		[Token(Token = "0x400024B")]
		UNDEFINED,
		[Token(Token = "0x400024C")]
		RAW,
		[Token(Token = "0x400024D")]
		DIRECTX,
		[Token(Token = "0x400024E")]
		OPENGL,
		[Token(Token = "0x400024F")]
		VULKAN,
		[Token(Token = "0x4000250")]
		METAL
	}
	[Token(Token = "0x200008B")]
	public enum TEXTURE_COLOR_SPACE : uint
	{
		[Token(Token = "0x4000252")]
		UNDEFINED,
		[Token(Token = "0x4000253")]
		LINEAR,
		[Token(Token = "0x4000254")]
		SRGB
	}
	[Token(Token = "0x200008C")]
	public enum RENDERING_PIPELINE : uint
	{
		[Token(Token = "0x4000256")]
		UNDEFINED,
		[Token(Token = "0x4000257")]
		FORWARD,
		[Token(Token = "0x4000258")]
		DEFERRED,
		[Token(Token = "0x4000259")]
		VERTEX_LIT,
		[Token(Token = "0x400025A")]
		UNIVERSAL,
		[Token(Token = "0x400025B")]
		HIGH_DEFINITION
	}
	[Token(Token = "0x200008D")]
	public struct SDKResolution
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int width;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int height;

		[Token(Token = "0x170000D2")]
		public static SDKResolution zero
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x2C15BBC", Offset = "0x2C15BBC", VA = "0x2C15BBC")]
			get
			{
				return default(SDKResolution);
			}
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2C1CE28", Offset = "0x2C1CE28", VA = "0x2C1CE28", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200008E")]
	public struct SDKVector3
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x170000D3")]
		public static SDKVector3 zero
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x2C15E88", Offset = "0x2C15E88", VA = "0x2C15E88")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x170000D4")]
		public static SDKVector3 one
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x2C1D644", Offset = "0x2C1D644", VA = "0x2C1D644")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x170000D5")]
		public static SDKVector3 forward
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x2C1DC88", Offset = "0x2C1DC88", VA = "0x2C1DC88")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x170000D6")]
		public static SDKVector3 up
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x2C172DC", Offset = "0x2C172DC", VA = "0x2C172DC")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x170000D7")]
		public static SDKVector3 right
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x2C1DC98", Offset = "0x2C1DC98", VA = "0x2C1DC98")]
			get
			{
				return default(SDKVector3);
			}
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2C1D9FC", Offset = "0x2C1D9FC", VA = "0x2C1D9FC")]
		public static implicit operator Vector3(SDKVector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2C172C4", Offset = "0x2C172C4", VA = "0x2C172C4")]
		public static implicit operator SDKVector3(Vector3 v)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2C1DCA8", Offset = "0x2C1DCA8", VA = "0x2C1DCA8")]
		public static SDKVector3 operator +(SDKVector3 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2C1DCB8", Offset = "0x2C1DCB8", VA = "0x2C1DCB8")]
		public static SDKVector3 operator -(SDKVector3 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2C1DCC8", Offset = "0x2C1DCC8", VA = "0x2C1DCC8")]
		public static SDKVector3 operator *(SDKVector3 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2C1DCD8", Offset = "0x2C1DCD8", VA = "0x2C1DCD8")]
		public static SDKVector3 operator *(SDKVector3 lhs, float rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2C1DCE8", Offset = "0x2C1DCE8", VA = "0x2C1DCE8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200008F")]
	public struct SDKQuaternion
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float w;

		[Token(Token = "0x170000D8")]
		public static SDKQuaternion identity
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x2C15E98", Offset = "0x2C15E98", VA = "0x2C15E98")]
			get
			{
				return default(SDKQuaternion);
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2C17944", Offset = "0x2C17944", VA = "0x2C17944")]
		public static implicit operator Quaternion(SDKQuaternion v)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2C17974", Offset = "0x2C17974", VA = "0x2C17974")]
		public static implicit operator SDKQuaternion(Quaternion v)
		{
			return default(SDKQuaternion);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2C17978", Offset = "0x2C17978", VA = "0x2C17978")]
		public static SDKQuaternion Euler(float pitch, float yaw, float roll)
		{
			return default(SDKQuaternion);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2C17A3C", Offset = "0x2C17A3C", VA = "0x2C17A3C")]
		public static SDKQuaternion operator *(SDKQuaternion lhs, SDKQuaternion rhs)
		{
			return default(SDKQuaternion);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2C17AB0", Offset = "0x2C17AB0", VA = "0x2C17AB0")]
		public static SDKVector3 operator *(SDKQuaternion lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2C17B54", Offset = "0x2C17B54", VA = "0x2C17B54", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000090")]
	public struct SDKMatrix4x4
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m00;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m01;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m02;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m03;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m10;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m11;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m12;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m13;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m20;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m21;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m22;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m23;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m30;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m31;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m32;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m33;

		[Token(Token = "0x170000D9")]
		public static SDKMatrix4x4 identity
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x2C15BF8", Offset = "0x2C15BF8", VA = "0x2C15BF8")]
			get
			{
				return default(SDKMatrix4x4);
			}
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2C16708", Offset = "0x2C16708", VA = "0x2C16708")]
		public static implicit operator Matrix4x4(SDKMatrix4x4 v)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2C1674C", Offset = "0x2C1674C", VA = "0x2C1674C")]
		public static implicit operator SDKMatrix4x4(Matrix4x4 v)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2C16790", Offset = "0x2C16790", VA = "0x2C16790")]
		public static SDKMatrix4x4 Perspective(float vFov, float aspect, float zNear, float zFar)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2C16850", Offset = "0x2C16850", VA = "0x2C16850")]
		public static SDKMatrix4x4 operator *(SDKMatrix4x4 lhs, SDKMatrix4x4 rhs)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2C168FC", Offset = "0x2C168FC", VA = "0x2C168FC")]
		public static SDKVector3 operator *(SDKMatrix4x4 lhs, SDKVector3 rhs)
		{
			return default(SDKVector3);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2C16954", Offset = "0x2C16954", VA = "0x2C16954")]
		public static SDKMatrix4x4 Translate(SDKVector3 value)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2C16990", Offset = "0x2C16990", VA = "0x2C16990")]
		public static SDKMatrix4x4 Rotate(SDKQuaternion value)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2C16A24", Offset = "0x2C16A24", VA = "0x2C16A24")]
		public static SDKMatrix4x4 Scale(SDKVector3 value)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2C16A50", Offset = "0x2C16A50", VA = "0x2C16A50")]
		public static SDKMatrix4x4 TRS(SDKVector3 translation, SDKQuaternion rotation, SDKVector3 scale)
		{
			return default(SDKMatrix4x4);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2C16B3C", Offset = "0x2C16B3C", VA = "0x2C16B3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000091")]
	public struct SDKPlane
	{
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float distance;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SDKVector3 normal;

		[Token(Token = "0x170000DA")]
		public static SDKPlane empty
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x2C172C8", Offset = "0x2C172C8", VA = "0x2C172C8")]
			get
			{
				return default(SDKPlane);
			}
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2C17264", Offset = "0x2C17264", VA = "0x2C17264")]
		public static implicit operator SDKPlane(Plane v)
		{
			return default(SDKPlane);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2C172EC", Offset = "0x2C172EC", VA = "0x2C172EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000092")]
	public struct SDKPriority
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public sbyte pose;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public sbyte clipPlane;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public sbyte stage;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public sbyte resolution;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public sbyte feature;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public sbyte nearFarAdjustment;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public sbyte groundPlane;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public sbyte reserved2;

		[Token(Token = "0x170000DB")]
		public static SDKPriority empty
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x2C16330", Offset = "0x2C16330", VA = "0x2C16330")]
			get
			{
				return default(SDKPriority);
			}
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2C17678", Offset = "0x2C17678", VA = "0x2C17678", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000093")]
	public struct SDKApplicationOutput
	{
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FEATURES supportedFeatures;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string engineName;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string engineVersion;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string applicationName;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string applicationVersion;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string xrDeviceName;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string graphicsAPI;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string sdkID;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string sdkVersion;

		[Token(Token = "0x170000DC")]
		public static SDKApplicationOutput empty
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x2C1433C", Offset = "0x2C1433C", VA = "0x2C1433C")]
			get
			{
				return default(SDKApplicationOutput);
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2C14480", Offset = "0x2C14480", VA = "0x2C14480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000094")]
	public struct SDKInputFrame
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKPose pose;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SDKClipPlane clipPlane;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public SDKTransform stageTransform;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public FEATURES features;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public SDKClipPlane groundClipPlane;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public ulong frameid;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public ulong referenceframe;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public SDKPriority priority;

		[Token(Token = "0x170000DD")]
		public static SDKInputFrame empty
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x2C1521C", Offset = "0x2C1521C", VA = "0x2C1521C")]
			get
			{
				return default(SDKInputFrame);
			}
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2C1633C", Offset = "0x2C1633C", VA = "0x2C1633C")]
		public void ReleaseControl()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2C1634C", Offset = "0x2C1634C", VA = "0x2C1634C")]
		public void ObtainControl()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2C16360", Offset = "0x2C16360", VA = "0x2C16360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000095")]
	public struct SDKOutputFrame
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RENDERING_PIPELINE renderingPipeline;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SDKTrackedSpace trackedSpace;

		[Token(Token = "0x170000DE")]
		public static SDKOutputFrame empty
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x2C170B4", Offset = "0x2C170B4", VA = "0x2C170B4")]
			get
			{
				return default(SDKOutputFrame);
			}
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2C17170", Offset = "0x2C17170", VA = "0x2C17170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000096")]
	public struct SDKTrackedSpace
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKVector3 trackedSpaceWorldPosition;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SDKQuaternion trackedSpaceWorldRotation;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SDKVector3 trackedSpaceLocalScale;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SDKMatrix4x4 trackedSpaceLocalToWorldMatrix;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SDKMatrix4x4 trackedSpaceWorldToLocalMatrix;

		[Token(Token = "0x170000DF")]
		public static SDKTrackedSpace empty
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x2C17114", Offset = "0x2C17114", VA = "0x2C17114")]
			get
			{
				return default(SDKTrackedSpace);
			}
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x2C1D3B8", Offset = "0x2C1D3B8", VA = "0x2C1D3B8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000097")]
	public struct SDKTexture
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TEXTURE_ID id;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr texturePtr;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr SharedHandle;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TEXTURE_DEVICE device;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int dummy;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TEXTURE_TYPE type;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TEXTURE_FORMAT format;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TEXTURE_COLOR_SPACE colorSpace;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int width;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int height;

		[Token(Token = "0x170000E0")]
		public static SDKTexture empty
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x2C15524", Offset = "0x2C15524", VA = "0x2C15524")]
			get
			{
				return default(SDKTexture);
			}
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2C1CF90", Offset = "0x2C1CF90", VA = "0x2C1CF90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000098")]
	public struct SDKTransform
	{
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKVector3 localPosition;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SDKQuaternion localRotation;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SDKVector3 localScale;

		[Token(Token = "0x170000E1")]
		public static SDKTransform empty
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x2C1631C", Offset = "0x2C1631C", VA = "0x2C1631C")]
			get
			{
				return default(SDKTransform);
			}
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x2C1D654", Offset = "0x2C1D654", VA = "0x2C1D654", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000099")]
	public struct SDKClipPlane
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKMatrix4x4 transform;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int width;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int height;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float tesselation;

		[Token(Token = "0x170000E2")]
		public static SDKClipPlane empty
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x2C15BC4", Offset = "0x2C15BC4", VA = "0x2C15BC4")]
			get
			{
				return default(SDKClipPlane);
			}
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2C15C24", Offset = "0x2C15C24", VA = "0x2C15C24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200009A")]
	public struct SDKControllerState
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKVector3 hmdposition;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SDKQuaternion hmdrotation;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SDKVector3 calibrationcameraposition;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SDKQuaternion calibrationcamerarotation;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SDKVector3 cameraposition;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public SDKQuaternion camerarotation;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SDKVector3 leftposition;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SDKQuaternion leftrotation;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SDKVector3 rightposition;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public SDKQuaternion rightrotation;

		[Token(Token = "0x170000E3")]
		public static SDKControllerState empty
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x2C15E3C", Offset = "0x2C15E3C", VA = "0x2C15E3C")]
			get
			{
				return default(SDKControllerState);
			}
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2C15EAC", Offset = "0x2C15EAC", VA = "0x2C15EAC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200009B")]
	public struct SDKPose
	{
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SDKMatrix4x4 projectionMatrix;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SDKVector3 localPosition;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public SDKQuaternion localRotation;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float verticalFieldOfView;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float nearClipPlane;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float farClipPlane;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int unused0;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int unused1;

		[Token(Token = "0x170000E4")]
		public static SDKPose empty
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x2C162A0", Offset = "0x2C162A0", VA = "0x2C162A0")]
			get
			{
				return default(SDKPose);
			}
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x2C173AC", Offset = "0x2C173AC", VA = "0x2C173AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200009C")]
	public class SDKPass : ScriptableRenderPass
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public CommandBuffer commandBuffer;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x2C17230", Offset = "0x2C17230", VA = "0x2C17230", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x2C1725C", Offset = "0x2C1725C", VA = "0x2C1725C")]
		public SDKPass()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class SDKUniversalRenderFeature : ScriptableRendererFeature
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<SDKPass> passes;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x2C1BC8C", Offset = "0x2C1BC8C", VA = "0x2C1BC8C")]
		public static void AddPass(SDKPass pass)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x2C1BE38", Offset = "0x2C1BE38", VA = "0x2C1BE38")]
		public static void ClearPasses()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x2C1D740", Offset = "0x2C1D740", VA = "0x2C1D740", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x2C1D744", Offset = "0x2C1D744", VA = "0x2C1D744", Slot = "6")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x2C1D860", Offset = "0x2C1D860", VA = "0x2C1D860")]
		public SDKUniversalRenderFeature()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public static class SDKUtils
	{
		[Token(Token = "0x170000E5")]
		public static TEXTURE_COLOR_SPACE GetDefaultColorSpace
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x2C1D90C", Offset = "0x2C1D90C", VA = "0x2C1D90C")]
			get
			{
				return default(TEXTURE_COLOR_SPACE);
			}
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x2C1C720", Offset = "0x2C1C720", VA = "0x2C1C720")]
		public static void CreateClipPlane(Mesh mesh, int resX, int resY, bool useQuads, float skirtLength)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x2C1D8F4", Offset = "0x2C1D8F4", VA = "0x2C1D8F4")]
		public static RenderTextureReadWrite GetReadWriteFromColorSpace(TEXTURE_COLOR_SPACE colorSpace)
		{
			return default(RenderTextureReadWrite);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x2C195BC", Offset = "0x2C195BC", VA = "0x2C195BC")]
		public static TEXTURE_COLOR_SPACE GetColorSpace(RenderTexture renderTexture)
		{
			return default(TEXTURE_COLOR_SPACE);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2C1D93C", Offset = "0x2C1D93C", VA = "0x2C1D93C")]
		public static RENDERING_PIPELINE GetRenderingPipeline(RenderingPath renderingPath)
		{
			return default(RENDERING_PIPELINE);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x2C19558", Offset = "0x2C19558", VA = "0x2C19558")]
		public static TEXTURE_DEVICE GetDevice()
		{
			return default(TEXTURE_DEVICE);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2C1D95C", Offset = "0x2C1D95C", VA = "0x2C1D95C")]
		public static bool ContainsFlag(ulong flags, ulong flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x2C1D968", Offset = "0x2C1D968", VA = "0x2C1D968")]
		public static ulong SetFlag(ulong flags, ulong flag, bool enabled)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x2C1D97C", Offset = "0x2C1D97C", VA = "0x2C1D97C")]
		public static void GetCameraPositionAndRotation(SDKPose pose, Matrix4x4 originLocalToWorldMatrix, out Vector3 position, out Quaternion rotation)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x2C1C3B8", Offset = "0x2C1C3B8", VA = "0x2C1C3B8")]
		public static void CleanCameraBehaviours(Camera camera, string[] excludeBehaviours)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x2C1BAA0", Offset = "0x2C1BAA0", VA = "0x2C1BAA0")]
		public static void SetCamera(Camera camera, Transform cameraTransform, SDKInputFrame inputFrame, Matrix4x4 originLocalToWorldMatrix, int layerMask)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x2C1833C", Offset = "0x2C1833C", VA = "0x2C1833C")]
		public static Quaternion RotateQuaternionByMatrix(Matrix4x4 matrix, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x2C1DA00", Offset = "0x2C1DA00", VA = "0x2C1DA00")]
		public static SDKTrackedSpace GetTrackedSpace(Transform transform)
		{
			return default(SDKTrackedSpace);
		}

		[Token(Token = "0x6000436")]
		public static bool DestroyObject<T>(ref T reference) where T : UnityEngine.Object
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		public static bool DisposeObject<T>(ref T reference) where T : IDisposable
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x2C18D54", Offset = "0x2C18D54", VA = "0x2C18D54")]
		public static bool CreateTexture(ref RenderTexture renderTexture, int width, int height, int depth, RenderTextureFormat format)
		{
			return default(bool);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x2C19398", Offset = "0x2C19398", VA = "0x2C19398")]
		public static void DestroyTexture(ref RenderTexture _renderTexture)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x2C1A5F0", Offset = "0x2C1A5F0", VA = "0x2C1A5F0")]
		public static void ApplyUserSpaceTransform(SDKRender render)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x2C1B960", Offset = "0x2C1B960", VA = "0x2C1B960")]
		public static void CreateBridgeOutputFrame(SDKRender render)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2C1938C", Offset = "0x2C1938C", VA = "0x2C1938C")]
		public static bool FeatureEnabled(FEATURES features, FEATURES feature)
		{
			return default(bool);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2C1BEBC", Offset = "0x2C1BEBC", VA = "0x2C1BEBC")]
		public static void DisableStandardAssets(Camera cameraInstance, ref MonoBehaviour[] behaviours, ref bool[] wasBehaviourEnabled)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2C1C31C", Offset = "0x2C1C31C", VA = "0x2C1C31C")]
		public static void RestoreStandardAssets(ref MonoBehaviour[] behaviours, ref bool[] wasBehaviourEnabled)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x2C1C068", Offset = "0x2C1C068", VA = "0x2C1C068")]
		public static void ForceForwardRendering(Camera cameraInstance, Mesh clipPlaneMesh, Material forceForwardRenderingMaterial)
		{
		}
	}
}
namespace CurvedUI
{
	[Token(Token = "0x200009F")]
	public class CUI_AnimateCurvedFillOnStart : MonoBehaviour
	{
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x255F2D8", Offset = "0x255F2D8", VA = "0x255F2D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x255F468", Offset = "0x255F468", VA = "0x255F468")]
		public CUI_AnimateCurvedFillOnStart()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class CUI_CameraController : MonoBehaviour
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform CameraObject;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float rotationMargin;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool runInEditorOnly;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CUI_CameraController Instance;

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x255F470", Offset = "0x255F470", VA = "0x255F470")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x255F4C4", Offset = "0x255F4C4", VA = "0x255F4C4")]
		public CUI_CameraController()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class CUI_CameraRotationOnButtonHeld : MonoBehaviour
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float Sensitivity;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector2 _oldMousePos;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x255F4DC", Offset = "0x255F4DC", VA = "0x255F4DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x255F544", Offset = "0x255F544", VA = "0x255F544")]
		public CUI_CameraRotationOnButtonHeld()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class CUI_ChangeColor : MonoBehaviour
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x255F554", Offset = "0x255F554", VA = "0x255F554")]
		public void ChangeColorToBlue()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x255F5CC", Offset = "0x255F5CC", VA = "0x255F5CC")]
		public void ChangeColorToCyan()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x255F644", Offset = "0x255F644", VA = "0x255F644")]
		public void ChangeColorToWhite()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x255F6BC", Offset = "0x255F6BC", VA = "0x255F6BC")]
		public CUI_ChangeColor()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class CUI_ChangeValueOnHold : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool pressed;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool selected;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image bg;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color SelectedColor;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color NormalColor;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup IntroCG;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup MenuCG;

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x255F6C4", Offset = "0x255F6C4", VA = "0x255F6C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x255F744", Offset = "0x255F744", VA = "0x255F744")]
		private void ChangeVal()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x255F8A8", Offset = "0x255F8A8", VA = "0x255F8A8", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x255F938", Offset = "0x255F938", VA = "0x255F938", Slot = "5")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x255F9C4", Offset = "0x255F9C4", VA = "0x255F9C4")]
		public CUI_ChangeValueOnHold()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class CUI_DragBetweenCanvases : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 dragPoint;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x255F9CC", Offset = "0x255F9CC", VA = "0x255F9CC", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x255FCB8", Offset = "0x255FCB8", VA = "0x255FCB8", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x25600D4", Offset = "0x25600D4", VA = "0x25600D4", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x255FAEC", Offset = "0x255FAEC", VA = "0x255FAEC")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2560148", Offset = "0x2560148", VA = "0x2560148")]
		public CUI_DragBetweenCanvases()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class CUI_GunController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E6F8", Offset = "0xE4E6F8")]
		private sealed class <>c
		{
			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__2_0;

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x16F64F4", Offset = "0x16F64F4", VA = "0x16F64F4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x16F64FC", Offset = "0x16F64FC", VA = "0x16F64FC")]
			internal bool <Update>b__2_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings ControlledCanvas;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2560150", Offset = "0x2560150", VA = "0x2560150")]
		private void Update()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2560564", Offset = "0x2560564", VA = "0x2560564")]
		public CUI_GunController()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class CUI_GunMovement : MonoBehaviour
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUISettings mySettings;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform pivot;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float sensitivity;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector2 lastMouse;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x256056C", Offset = "0x256056C", VA = "0x256056C")]
		private void Start()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x25605D4", Offset = "0x25605D4", VA = "0x25605D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x256074C", Offset = "0x256074C", VA = "0x256074C")]
		public CUI_GunMovement()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class CUI_OrientOnCurvedSpace : MonoBehaviour
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvedUISettings mySettings;

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2560B88", Offset = "0x2560B88", VA = "0x2560B88")]
		private void Awake()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2560BE4", Offset = "0x2560BE4", VA = "0x2560BE4")]
		private void Update()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2560D84", Offset = "0x2560D84", VA = "0x2560D84")]
		public CUI_OrientOnCurvedSpace()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class CUI_PerlinNoisePosition : MonoBehaviour
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 Range;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform rectie;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x2560D8C", Offset = "0x2560D8C", VA = "0x2560D8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x2560E00", Offset = "0x2560E00", VA = "0x2560E00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x2560EF4", Offset = "0x2560EF4", VA = "0x2560EF4")]
		public CUI_PerlinNoisePosition()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class CUI_PerlinNoiseRotation : MonoBehaviour
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float samplingSpeed;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxrotation;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform rectie;

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x2560F04", Offset = "0x2560F04", VA = "0x2560F04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x2560F78", Offset = "0x2560F78", VA = "0x2560F78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x2560FFC", Offset = "0x2560FFC", VA = "0x2560FFC")]
		public CUI_PerlinNoiseRotation()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class CUI_PickImageFromSet : MonoBehaviour
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CUI_PickImageFromSet picked;

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x2561010", Offset = "0x2561010", VA = "0x2561010")]
		public void PickThis()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x2561208", Offset = "0x2561208", VA = "0x2561208")]
		public CUI_PickImageFromSet()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class CUI_RaycastToCanvas : MonoBehaviour
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2561214", Offset = "0x2561214", VA = "0x2561214")]
		private void Start()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2561270", Offset = "0x2561270", VA = "0x2561270")]
		private void Update()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x2561330", Offset = "0x2561330", VA = "0x2561330")]
		public CUI_RaycastToCanvas()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class CUI_RiseChildrenOverTime : MonoBehaviour
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float current;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Speed;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RiseBy;

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2561338", Offset = "0x2561338", VA = "0x2561338")]
		private void Start()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x256133C", Offset = "0x256133C", VA = "0x256133C")]
		private void Update()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x25614AC", Offset = "0x25614AC", VA = "0x25614AC")]
		public CUI_RiseChildrenOverTime()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class CUI_TMPChecker : MonoBehaviour
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject testMsg;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject enabledMsg;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject disabledMsg;

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x25615A0", Offset = "0x25615A0", VA = "0x25615A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x256161C", Offset = "0x256161C", VA = "0x256161C")]
		public CUI_TMPChecker()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class CUI_ViveButtonState : MonoBehaviour
	{
		[Token(Token = "0x20000B0")]
		private enum ViveButton
		{
			[Token(Token = "0x40002E5")]
			Trigger,
			[Token(Token = "0x40002E6")]
			TouchpadTouch,
			[Token(Token = "0x40002E7")]
			TouchpadPress,
			[Token(Token = "0x40002E8")]
			Grip,
			[Token(Token = "0x40002E9")]
			Menu
		}

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color ActiveColor;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color InActiveColor;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ViveButton ShowStateFor;

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2561624", Offset = "0x2561624", VA = "0x2561624")]
		public CUI_ViveButtonState()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class CUI_ViveHapticPulse : MonoBehaviour
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float PulseStrength;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x2561668", Offset = "0x2561668", VA = "0x2561668")]
		private void Start()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x2561674", Offset = "0x2561674", VA = "0x2561674")]
		public void SetPulseStrength(float newStr)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x25616A4", Offset = "0x25616A4", VA = "0x25616A4")]
		public void TriggerPulse()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x25616A8", Offset = "0x25616A8", VA = "0x25616A8")]
		public CUI_ViveHapticPulse()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class CUI_WorldSpaceCursorFollow : MonoBehaviour
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x25616B0", Offset = "0x25616B0", VA = "0x25616B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x25617E0", Offset = "0x25617E0", VA = "0x25617E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2561874", Offset = "0x2561874", VA = "0x2561874")]
		public CUI_WorldSpaceCursorFollow()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class CUI_WorldSpaceMouseMultipleCanvases : MonoBehaviour
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CurvedUISettings> ControlledCanvases;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform WorldSpaceMouse;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CurvedUISettings MouseCanvas;

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x256187C", Offset = "0x256187C", VA = "0x256187C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2561B88", Offset = "0x2561B88", VA = "0x2561B88")]
		public CUI_WorldSpaceMouseMultipleCanvases()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class CUI_draggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector2 savedVector;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isDragged;

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x2561B90", Offset = "0x2561B90", VA = "0x2561B90", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2561E84", Offset = "0x2561E84", VA = "0x2561E84", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2561E88", Offset = "0x2561E88", VA = "0x2561E88", Slot = "5")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2561F08", Offset = "0x2561F08", VA = "0x2561F08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2561CB8", Offset = "0x2561CB8", VA = "0x2561CB8")]
		private void RaycastPosition(out Vector2 newPos)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x2562004", Offset = "0x2562004", VA = "0x2562004")]
		public CUI_draggable()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class CUI_inventory_paralax : MonoBehaviour
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform front;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform back;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 initFG;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 initBG;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float change;

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x256200C", Offset = "0x256200C", VA = "0x256200C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x256205C", Offset = "0x256205C", VA = "0x256205C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x2562260", Offset = "0x2562260", VA = "0x2562260")]
		public CUI_inventory_paralax()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class CurvedUIEventSystem : EventSystem
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CurvedUIEventSystem instance;

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x2567EA4", Offset = "0x2567EA4", VA = "0x2567EA4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2567F04", Offset = "0x2567F04", VA = "0x2567F04")]
		public CurvedUIEventSystem()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public static class CurvedUIExtensionMethods
	{
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2567F68", Offset = "0x2567F68", VA = "0x2567F68")]
		public static bool AlmostEqual(this Vector3 a, Vector3 b, double accuracy = 0.01)
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2560ED8", Offset = "0x2560ED8", VA = "0x2560ED8")]
		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x2567F98", Offset = "0x2567F98", VA = "0x2567F98")]
		public static float RemapAndClamp(this float value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x2567FC8", Offset = "0x2567FC8", VA = "0x2567FC8")]
		public static float Remap(this int value, float from1, float to1, float from2, float to2)
		{
			return default(float);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x2567FE8", Offset = "0x2567FE8", VA = "0x2567FE8")]
		public static double Remap(this double value, double from1, double to1, double from2, double to2)
		{
			return default(double);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x2567FC0", Offset = "0x2567FC0", VA = "0x2567FC0")]
		public static float Clamp(this float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x2568004", Offset = "0x2568004", VA = "0x2568004")]
		public static float Clamp(this int value, int min, int max)
		{
			return default(float);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x2568020", Offset = "0x2568020", VA = "0x2568020")]
		public static int Abs(this int value)
		{
			return default(int);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x2568028", Offset = "0x2568028", VA = "0x2568028")]
		public static float Abs(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x2568030", Offset = "0x2568030", VA = "0x2568030")]
		public static int ToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x2568038", Offset = "0x2568038", VA = "0x2568038")]
		public static int FloorToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x2568040", Offset = "0x2568040", VA = "0x2568040")]
		public static int CeilToInt(this float value)
		{
			return default(int);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x2560554", Offset = "0x2560554", VA = "0x2560554")]
		public static Vector3 ModifyX(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x256055C", Offset = "0x256055C", VA = "0x256055C")]
		public static Vector3 ModifyY(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x256054C", Offset = "0x256054C", VA = "0x256054C")]
		public static Vector3 ModifyZ(this Vector3 trans, float newVal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2568048", Offset = "0x2568048", VA = "0x2568048")]
		public static Vector2 ModifyVectorX(this Vector2 trans, float newVal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2568050", Offset = "0x2568050", VA = "0x2568050")]
		public static Vector2 ModifyVectorY(this Vector2 trans, float newVal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2560078", Offset = "0x2560078", VA = "0x2560078")]
		public static void ResetTransform(this Transform trans)
		{
		}

		[Token(Token = "0x6000497")]
		public static T AddComponentIfMissing<T>(this GameObject go) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		public static T AddComponentIfMissing<T>(this Component go) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x20000B8")]
	public class CurvedUIHandSwitcher : MonoBehaviour
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject LaserBeam;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE50C30", Offset = "0xE50C30")]
		[SerializeField]
		private bool autoSwitchHands;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xE50C7C", Offset = "0xE50C7C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE50C7C", Offset = "0xE50C7C")]
		private Transform leftHandOverride;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE50CEC", Offset = "0xE50CEC")]
		[SerializeField]
		private Transform rightHandOverride;

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2568058", Offset = "0x2568058", VA = "0x2568058")]
		private void Start()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x25683B8", Offset = "0x25683B8", VA = "0x25683B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x25680CC", Offset = "0x25680CC", VA = "0x25680CC")]
		private void SwitchHandTo(CurvedUIInputModule.Hand newHand)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x25685FC", Offset = "0x25685FC", VA = "0x25685FC")]
		public CurvedUIHandSwitcher()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class CurvedUIInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E718", Offset = "0xE4E718")]
		private sealed class <CaretBlinker>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUIInputFieldCaret <>4__this;

			[Token(Token = "0x170000E9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004AF")]
				[Address(RVA = "0x16F671C", Offset = "0x16F671C", VA = "0x16F671C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004B1")]
				[Address(RVA = "0x16F6764", Offset = "0x16F6764", VA = "0x16F6764", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x16F65CC", Offset = "0x16F65CC", VA = "0x16F65CC")]
			[DebuggerHidden]
			public <CaretBlinker>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x16F65F8", Offset = "0x16F65F8", VA = "0x16F65F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x16F65FC", Offset = "0x16F65FC", VA = "0x16F65FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x16F6724", Offset = "0x16F6724", VA = "0x16F6724", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private InputField myField;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int lastCharDist;

		[Token(Token = "0x170000E6")]
		public Color CaretColor
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x2569010", Offset = "0x2569010", VA = "0x2569010")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x256901C", Offset = "0x256901C", VA = "0x256901C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public Color SelectionColor
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x2569028", Offset = "0x2569028", VA = "0x2569028")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x2569034", Offset = "0x2569034", VA = "0x2569034")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x2569040", Offset = "0x2569040", VA = "0x2569040")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x256905C", Offset = "0x256905C", VA = "0x256905C")]
			set
			{
			}
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x256860C", Offset = "0x256860C", VA = "0x256860C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2568668", Offset = "0x2568668", VA = "0x2568668")]
		private void Update()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2568940", Offset = "0x2568940", VA = "0x2568940", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2568D98", Offset = "0x2568D98", VA = "0x2568D98", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2568D20", Offset = "0x2568D20", VA = "0x2568D20")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE52C24", Offset = "0xE52C24")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x25689FC", Offset = "0x25689FC", VA = "0x25689FC")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2568678", Offset = "0x2568678", VA = "0x2568678")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2568DD0", Offset = "0x2568DD0", VA = "0x2568DD0")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2569078", Offset = "0x2569078", VA = "0x2569078")]
		public CurvedUIInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class CurvedUILaserBeam : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E728", Offset = "0xE4E728")]
		private sealed class <>c
		{
			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__3_0;

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x16F67D0", Offset = "0x16F67D0", VA = "0x16F67D0")]
			public <>c()
			{
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x16F67D8", Offset = "0x16F67D8", VA = "0x16F67D8")]
			internal bool <Update>b__3_0(GameObject x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform LaserBeamTransform;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform LaserBeamDot;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool hideWhenNotAimingAtCanvas;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1B46EDC", Offset = "0x1B46EDC", VA = "0x1B46EDC")]
		protected void Update()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1B47424", Offset = "0x1B47424", VA = "0x1B47424")]
		public CurvedUILaserBeam()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class CurvedUIPhysicsRaycaster : BaseRaycaster
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int sortOrder;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private RaycastHit hitInfo;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RaycastResult result;

		[Token(Token = "0x170000EB")]
		public int CompoundEventMask
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1B47734", Offset = "0x1B47734", VA = "0x1B47734")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EC")]
		public override Camera eventCamera
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1B47838", Offset = "0x1B47838", VA = "0x1B47838", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public virtual int Depth
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x1B47908", Offset = "0x1B47908", VA = "0x1B47908", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EE")]
		public override int sortOrderPriority
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x1B479DC", Offset = "0x1B479DC", VA = "0x1B479DC", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1B4742C", Offset = "0x1B4742C", VA = "0x1B4742C")]
		protected CurvedUIPhysicsRaycaster()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1B4743C", Offset = "0x1B4743C", VA = "0x1B4743C", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class CurvedUIPointerEventData : PointerEventData
	{
		[Token(Token = "0x20000BF")]
		public enum ControllerType
		{
			[Token(Token = "0x4000310")]
			NONE = -1,
			[Token(Token = "0x4000311")]
			VIVE
		}

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public GameObject Controller;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Vector2 TouchPadAxis;

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1B479E4", Offset = "0x1B479E4", VA = "0x1B479E4")]
		public CurvedUIPointerEventData(EventSystem eventSystem)
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class CurvedUIRaycaster : GraphicRaycaster
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E738", Offset = "0xE4E738")]
		private sealed class <>c
		{
			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GameObject> <>9__21_0;

			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<Graphic> <>9__32_0;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<Graphic> <>9__55_0;

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x16F6938", Offset = "0x16F6938", VA = "0x16F6938")]
			public <>c()
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x16F6940", Offset = "0x16F6940", VA = "0x16F6940")]
			internal bool <Update>b__21_0(GameObject obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x16F6A0C", Offset = "0x16F6A0C", VA = "0x16F6A0C")]
			internal int <FlatRaycastAndSort>b__32_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x16F6A64", Offset = "0x16F6A64", VA = "0x16F6A64")]
			internal int <GetObjectsHitByRay>b__55_0(Graphic g1, Graphic g2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool showDebug;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool overrideEventData;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas myCanvas;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 cyllinderMidPoint;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<GameObject> objectsUnderPointer;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 lastCanvasPos;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject colliderContainer;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PointerEventData lastFrameEventData;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PointerEventData curEventData;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PointerEventData eventDataToUse;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Ray cachedRay;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Graphic gph;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<GameObject> selectablesUnderGaze;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<GameObject> selectablesUnderGazeLastFrame;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float objectsUnderGazeLastChangeTime;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool gazeClickExecuted;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		private bool pointingAtCanvas;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		private bool pointingAtCanvasLastFrame;

		[NonSerialized]
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Graphic> s_SortedGraphics;

		[Token(Token = "0x170000EF")]
		private Image GazeProgressImage
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1B48A44", Offset = "0x1B48A44", VA = "0x1B48A44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1B4F0E4", Offset = "0x1B4F0E4", VA = "0x1B4F0E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1B47A20", Offset = "0x1B47A20", VA = "0x1B47A20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1B47C6C", Offset = "0x1B47C6C", VA = "0x1B47C6C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1B48488", Offset = "0x1B48488", VA = "0x1B48488", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1B48880", Offset = "0x1B48880", VA = "0x1B48880")]
		private void ProcessGazeTimedClick()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1B48854", Offset = "0x1B48854", VA = "0x1B48854")]
		private void ResetGazeTimedClick()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1B49040", Offset = "0x1B49040", VA = "0x1B49040", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1B4A428", Offset = "0x1B4A428", VA = "0x1B4A428", Slot = "23")]
		public virtual bool RaycastToCyllinderCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1B4AB60", Offset = "0x1B4AB60", VA = "0x1B4AB60", Slot = "24")]
		public virtual bool RaycastToCyllinderVerticalCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1B4B190", Offset = "0x1B4B190", VA = "0x1B4B190", Slot = "25")]
		public virtual bool RaycastToRingCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1B4B6A0", Offset = "0x1B4B6A0", VA = "0x1B4B6A0", Slot = "26")]
		public virtual bool RaycastToSphereCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1B49E64", Offset = "0x1B49E64", VA = "0x1B49E64")]
		private void FlatRaycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1B4C05C", Offset = "0x1B4C05C", VA = "0x1B4C05C")]
		private static void FlatRaycastAndSort(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1B47F00", Offset = "0x1B47F00", VA = "0x1B47F00")]
		protected void CreateCollider()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1B4DB2C", Offset = "0x1B4DB2C", VA = "0x1B4DB2C")]
		private void SetupMeshColliderUsingMesh(Mesh meshie)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1B4C5B4", Offset = "0x1B4C5B4", VA = "0x1B4C5B4")]
		private GameObject CreateConvexCyllinderCollider(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1B4D184", Offset = "0x1B4D184", VA = "0x1B4D184")]
		private Mesh CreateCyllinderColliderMesh(bool vertical = false)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1B4DBE4", Offset = "0x1B4DBE4", VA = "0x1B4DBE4")]
		private Mesh CreateSphereColliderMesh()
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1B4E6A8", Offset = "0x1B4E6A8", VA = "0x1B4E6A8")]
		private bool IsInLayerMask(int layer, LayerMask layermask)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1B4AA54", Offset = "0x1B4AA54", VA = "0x1B4AA54")]
		private LayerMask GetRaycastLayerMask()
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1B4AABC", Offset = "0x1B4AABC", VA = "0x1B4AABC")]
		private float AngleSigned(Vector3 v1, Vector3 v2, Vector3 n)
		{
			return default(float);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1B4E700", Offset = "0x1B4E700", VA = "0x1B4E700")]
		private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1B4E750", Offset = "0x1B4E750", VA = "0x1B4E750", Slot = "27")]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1B497E8", Offset = "0x1B497E8", VA = "0x1B497E8")]
		protected void UpdateSelectedObjects(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1B4E768", Offset = "0x1B4E768", VA = "0x1B4E768")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1B4EE0C", Offset = "0x1B4EE0C", VA = "0x1B4EE0C")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1B4EFB0", Offset = "0x1B4EFB0", VA = "0x1B4EFB0")]
		private bool GetScreenSpacePointByRay(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1B47CF8", Offset = "0x1B47CF8", VA = "0x1B47CF8")]
		private bool CheckEventCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1B4F0EC", Offset = "0x1B4F0EC", VA = "0x1B4F0EC")]
		public void RebuildCollider()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1B4F128", Offset = "0x1B4F128", VA = "0x1B4F128")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1B4F1B0", Offset = "0x1B4F1B0", VA = "0x1B4F1B0")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 screenPos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1B4F298", Offset = "0x1B4F298", VA = "0x1B4F298")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1B48AAC", Offset = "0x1B48AAC", VA = "0x1B48AAC")]
		public void Click()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1B4E37C", Offset = "0x1B4E37C", VA = "0x1B4E37C")]
		private void ModifyQuad(List<Vector3> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1B4F78C", Offset = "0x1B4F78C", VA = "0x1B4F78C")]
		private Vector3 TesselateQuad(List<Vector3> quad, float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1B4F940", Offset = "0x1B4F940", VA = "0x1B4F940")]
		public CurvedUIRaycaster()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4E748", Offset = "0xE4E748")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4E748", Offset = "0xE4E748")]
	public class CurvedUISettings : MonoBehaviour
	{
		[Token(Token = "0x20000C3")]
		public enum CurvedUIShape
		{
			[Token(Token = "0x400033D")]
			CYLINDER,
			[Token(Token = "0x400033E")]
			RING,
			[Token(Token = "0x400033F")]
			SPHERE,
			[Token(Token = "0x4000340")]
			CYLINDER_VERTICAL
		}

		[Token(Token = "0x400032B")]
		public const string Version = "3.3";

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CurvedUIShape shape;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float quality;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool interactable;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool blocksRaycasts;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool forceUseBoxCollider;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int angle;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool preserveAspect;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int vertAngle;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float ringFill;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int ringExternalDiamater;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool ringFlipVertical;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int baseCircleSegments;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 savedRectSize;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float savedRadius;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas myCanvas;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform m_rectTransform;

		[Token(Token = "0x170000F1")]
		private RectTransform RectTransform
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1B4FBB8", Offset = "0x1B4FBB8", VA = "0x1B4FBB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		public int BaseCircleSegments
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x1B51194", Offset = "0x1B51194", VA = "0x1B51194")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F3")]
		public int Angle
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x1B5119C", Offset = "0x1B5119C", VA = "0x1B5119C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x1B511A4", Offset = "0x1B511A4", VA = "0x1B511A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public float Quality
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x1B511B8", Offset = "0x1B511B8", VA = "0x1B511B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x1B511C0", Offset = "0x1B511C0", VA = "0x1B511C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public CurvedUIShape Shape
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x1B511DC", Offset = "0x1B511DC", VA = "0x1B511DC")]
			get
			{
				return default(CurvedUIShape);
			}
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x1B511E4", Offset = "0x1B511E4", VA = "0x1B511E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public int VerticalAngle
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x1B51204", Offset = "0x1B51204", VA = "0x1B51204")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1B5120C", Offset = "0x1B5120C", VA = "0x1B5120C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public float RingFill
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1B5122C", Offset = "0x1B5122C", VA = "0x1B5122C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x1B51234", Offset = "0x1B51234", VA = "0x1B51234")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public float SavedRadius
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x1B505EC", Offset = "0x1B505EC", VA = "0x1B505EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F9")]
		public int RingExternalDiameter
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x1B51250", Offset = "0x1B51250", VA = "0x1B51250")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x1B51258", Offset = "0x1B51258", VA = "0x1B51258")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public bool RingFlipVertical
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x1B51278", Offset = "0x1B51278", VA = "0x1B51278")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x1B51280", Offset = "0x1B51280", VA = "0x1B51280")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public bool PreserveAspect
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x1B512AC", Offset = "0x1B512AC", VA = "0x1B512AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x1B512B4", Offset = "0x1B512B4", VA = "0x1B512B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public bool Interactable
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x1B512E0", Offset = "0x1B512E0", VA = "0x1B512E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x1B512E8", Offset = "0x1B512E8", VA = "0x1B512E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public bool ForceUseBoxCollider
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x1B512F4", Offset = "0x1B512F4", VA = "0x1B512F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x1B512FC", Offset = "0x1B512FC", VA = "0x1B512FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public bool BlocksRaycasts
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x1B51308", Offset = "0x1B51308", VA = "0x1B51308")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1B51310", Offset = "0x1B51310", VA = "0x1B51310")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE52F08", Offset = "0xE52F08")]
		public bool RaycastMyLayerOnly
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1B51400", Offset = "0x1B51400", VA = "0x1B51400")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1B51408", Offset = "0x1B51408", VA = "0x1B51408")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public bool PointingAtCanvas
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1B514C4", Offset = "0x1B514C4", VA = "0x1B514C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000101")]
		public CurvedUIInputModule.CUIControlMethod ControlMethod
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x1B4EDB4", Offset = "0x1B4EDB4", VA = "0x1B4EDB4")]
			get
			{
				return default(CurvedUIInputModule.CUIControlMethod);
			}
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x1B5169C", Offset = "0x1B5169C", VA = "0x1B5169C")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public bool GazeUseTimedClick
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x1B51994", Offset = "0x1B51994", VA = "0x1B51994")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1B519FC", Offset = "0x1B519FC", VA = "0x1B519FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public float GazeClickTimer
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x1B51A6C", Offset = "0x1B51A6C", VA = "0x1B51A6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x1B51AD4", Offset = "0x1B51AD4", VA = "0x1B51AD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public float GazeClickTimerDelay
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x1B51B5C", Offset = "0x1B51B5C", VA = "0x1B51B5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x1B51BC4", Offset = "0x1B51BC4", VA = "0x1B51BC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public float GazeTimerProgress
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x1B51C4C", Offset = "0x1B51C4C", VA = "0x1B51C4C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1B4FB2C", Offset = "0x1B4FB2C", VA = "0x1B4FB2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1B4FC84", Offset = "0x1B4FC84", VA = "0x1B4FC84")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1B50040", Offset = "0x1B50040", VA = "0x1B50040")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1B500EC", Offset = "0x1B500EC", VA = "0x1B500EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1B50198", Offset = "0x1B50198", VA = "0x1B50198")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1B502C4", Offset = "0x1B502C4", VA = "0x1B502C4")]
		private void SetUIAngle(int newAngle)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1B50504", Offset = "0x1B50504", VA = "0x1B50504")]
		private Vector3 CanvasToCyllinder(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1B5061C", Offset = "0x1B5061C", VA = "0x1B5061C")]
		private Vector3 CanvasToCyllinderVertical(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1B50704", Offset = "0x1B50704", VA = "0x1B50704")]
		private Vector3 CanvasToRing(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1B507F4", Offset = "0x1B507F4", VA = "0x1B507F4")]
		private Vector3 CanvasToSphere(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1B50990", Offset = "0x1B50990", VA = "0x1B50990")]
		public void AddEffectToChildren()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1B50D50", Offset = "0x1B50D50", VA = "0x1B50D50")]
		public Vector3 VertexPositionToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1B49DA4", Offset = "0x1B49DA4", VA = "0x1B49DA4")]
		public Vector3 CanvasToCurvedCanvas(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1B50D88", Offset = "0x1B50D88", VA = "0x1B50D88")]
		public Vector3 CanvasToCurvedCanvasNormal(Vector3 pos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1B50F6C", Offset = "0x1B50F6C", VA = "0x1B50F6C")]
		public bool RaycastToCanvasSpace(Ray ray, out Vector2 o_positionOnCanvas)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1B47B34", Offset = "0x1B47B34", VA = "0x1B47B34")]
		public float GetCyllinderRadiusInCanvasSpace()
		{
			return default(float);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1B4E210", Offset = "0x1B4E210", VA = "0x1B4E210")]
		public Vector2 GetTesslationSize(bool modifiedByQuality = true)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1B510F4", Offset = "0x1B510F4", VA = "0x1B510F4")]
		private float GetSegmentsByAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1B5140C", Offset = "0x1B5140C", VA = "0x1B5140C")]
		public void SetAllChildrenDirty(bool recalculateCurveOnly = false)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1B515D8", Offset = "0x1B515D8", VA = "0x1B515D8")]
		public void Click()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1B47320", Offset = "0x1B47320", VA = "0x1B47320")]
		public List<GameObject> GetObjectsUnderPointer()
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1B516FC", Offset = "0x1B516FC", VA = "0x1B516FC")]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 pos, [Optional] Camera eventCamera)
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1B51864", Offset = "0x1B51864", VA = "0x1B51864")]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1B51CB4", Offset = "0x1B51CB4", VA = "0x1B51CB4")]
		public CurvedUISettings()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class CurvedUIVertexEffect : BaseMeshEffect
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE50E38", Offset = "0xE50E38")]
		public bool DoNotTesselate;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Canvas myCanvas;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Graphic myGraphic;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text myText;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI myTMP;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CurvedUITMPSubmesh myTMPSubMesh;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_tesselationRequired;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool curvingRequired;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool TransformMisaligned;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Matrix4x4 CanvasToWorld;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Matrix4x4 CanvasToLocal;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Matrix4x4 MyToWorld;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Matrix4x4 MyToLocal;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<UIVertex> m_tesselatedVerts;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<UIVertex> m_curvedVerts;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<UIVertex> m_vertsInQuads;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private UIVertex m_ret;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private UIVertex[] m_quad;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float[] m_weights;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[HideInInspector]
		private Vector3 savedPos;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[HideInInspector]
		[SerializeField]
		private Vector3 savedUp;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[HideInInspector]
		[SerializeField]
		private Vector2 savedRectSize;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[HideInInspector]
		[SerializeField]
		private Color savedColor;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[SerializeField]
		[HideInInspector]
		private Vector4 savedTextUV0;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[HideInInspector]
		[SerializeField]
		private float savedFill;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Vector4 _uv0;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Vector4 _uv1;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private Vector3 _pos;

		[Token(Token = "0x17000106")]
		private bool tesselationRequired
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x1B544A8", Offset = "0x1B544A8", VA = "0x1B544A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x1B544B0", Offset = "0x1B544B0", VA = "0x1B544B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public bool TesselationRequired
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1B5719C", Offset = "0x1B5719C", VA = "0x1B5719C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x1B57190", Offset = "0x1B57190", VA = "0x1B57190")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool CurvingRequired
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x1B571A4", Offset = "0x1B571A4", VA = "0x1B571A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x1B571AC", Offset = "0x1B571AC", VA = "0x1B571AC")]
			set
			{
			}
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1B544BC", Offset = "0x1B544BC", VA = "0x1B544BC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1B545B4", Offset = "0x1B545B4", VA = "0x1B545B4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1B548C4", Offset = "0x1B548C4", VA = "0x1B548C4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1B54F50", Offset = "0x1B54F50", VA = "0x1B54F50", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1B55108", Offset = "0x1B55108", VA = "0x1B55108")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1B55114", Offset = "0x1B55114", VA = "0x1B55114")]
		private void FontTextureRebuiltCallback(Font fontie)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1B551B4", Offset = "0x1B551B4", VA = "0x1B551B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1B55714", Offset = "0x1B55714", VA = "0x1B55714", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1B52CD0", Offset = "0x1B52CD0", VA = "0x1B52CD0")]
		public void ModifyTMPMesh(ref List<UIVertex> vertexList)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1B55E20", Offset = "0x1B55E20", VA = "0x1B55E20")]
		private bool ShouldModify()
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1B55F20", Offset = "0x1B55F20", VA = "0x1B55F20")]
		private void CheckTextFontMaterial()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1B54790", Offset = "0x1B54790", VA = "0x1B54790")]
		public CurvedUISettings FindParentSettings(bool forceNew = false)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1B56394", Offset = "0x1B56394", VA = "0x1B56394")]
		private UIVertex CurveVertex(UIVertex input, float cylinder_angle, float radius, Vector2 canvasSize)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1B561C4", Offset = "0x1B561C4", VA = "0x1B561C4")]
		private void TesselateGeometry(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1B56954", Offset = "0x1B56954", VA = "0x1B56954")]
		private void ModifyQuad(List<UIVertex> verts, int vertexIndex, Vector2 requiredSize)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1B566BC", Offset = "0x1B566BC", VA = "0x1B566BC")]
		private void TrisToQuads(List<UIVertex> verts)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1B56E2C", Offset = "0x1B56E2C", VA = "0x1B56E2C")]
		private UIVertex TesselateQuad(float x, float y)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1B504F8", Offset = "0x1B504F8", VA = "0x1B504F8")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1B571B8", Offset = "0x1B571B8", VA = "0x1B571B8")]
		public CurvedUIVertexEffect()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class CurvedUIViveController : MonoBehaviour
	{
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x2B257C0", Offset = "0x2B257C0", VA = "0x2B257C0")]
		public CurvedUIViveController()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public struct ViveInputArgs
	{
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint controllerIndex;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float buttonPressure;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 touchpadAxis;
	}
	[Token(Token = "0x20000C7")]
	public delegate void ViveInputEvent(object sender, ViveInputArgs e);
	[Token(Token = "0x20000C8")]
	public delegate void ViveEvent(object sender);
	[Token(Token = "0x20000C9")]
	[ExecuteInEditMode]
	public class CurvedUITMP : MonoBehaviour
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshProUGUI tmpText;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvedUISettings mySettings;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UIVertex> m_UIVerts;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UIVertex m_tempVertex;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private CurvedUITMPSubmesh m_tempSubMsh;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector2 savedSize;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 savedUp;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 savedPos;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 savedLocalScale;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 savedGlobalScale;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<CurvedUITMPSubmesh> subMeshes;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool Dirty;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool curvingRequired;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool tesselationRequired;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF3")]
		private bool quitting;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3[] vertices;

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1B51CF8", Offset = "0x1B51CF8", VA = "0x1B51CF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1B51DB4", Offset = "0x1B51DB4", VA = "0x1B51DB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1B520F8", Offset = "0x1B520F8", VA = "0x1B520F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1B52294", Offset = "0x1B52294", VA = "0x1B52294")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1B522A0", Offset = "0x1B522A0", VA = "0x1B522A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1B52A78", Offset = "0x1B52A78", VA = "0x1B52A78")]
		private void CreateUIVertexList(Mesh mesh)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1B536BC", Offset = "0x1B536BC", VA = "0x1B536BC")]
		private void GetUIVertexFromMesh(ref UIVertex vert, int i)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1B52FE4", Offset = "0x1B52FE4", VA = "0x1B52FE4")]
		private void FillMeshWithUIVertexList(Mesh mesh, List<UIVertex> list)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1B51F88", Offset = "0x1B51F88", VA = "0x1B51F88")]
		private void FindTMP()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1B53158", Offset = "0x1B53158", VA = "0x1B53158")]
		private void FindSubmeshes()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1B527A4", Offset = "0x1B527A4", VA = "0x1B527A4")]
		private bool ShouldTesselate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1B5370C", Offset = "0x1B5370C", VA = "0x1B5370C")]
		private void TMPTextChangedCallback(object obj)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1B53728", Offset = "0x1B53728", VA = "0x1B53728")]
		private void TesselationRequiredCallback()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1B53734", Offset = "0x1B53734", VA = "0x1B53734")]
		public CurvedUITMP()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[ExecuteInEditMode]
	public class CurvedUITMPInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE4E7EC", Offset = "0xE4E7EC")]
		private sealed class <CaretBlinker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvedUITMPInputFieldCaret <>4__this;

			[Token(Token = "0x1700010C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000569")]
				[Address(RVA = "0x16F6C0C", Offset = "0x16F6C0C", VA = "0x16F6C0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600056B")]
				[Address(RVA = "0x16F6C54", Offset = "0x16F6C54", VA = "0x16F6C54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000566")]
			[Address(RVA = "0x16F6ABC", Offset = "0x16F6ABC", VA = "0x16F6ABC")]
			[DebuggerHidden]
			public <CaretBlinker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0x16F6AE8", Offset = "0x16F6AE8", VA = "0x16F6AE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0x16F6AEC", Offset = "0x16F6AEC", VA = "0x16F6AEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x16F6C14", Offset = "0x16F6C14", VA = "0x16F6C14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_InputField myField;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform myCaret;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color origCaretColor;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color origSelectionColor;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool selected;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool selectingText;

		[Token(Token = "0x17000109")]
		public Color CaretColor
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x1B54430", Offset = "0x1B54430", VA = "0x1B54430")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x1B5443C", Offset = "0x1B5443C", VA = "0x1B5443C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public Color SelectionColor
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x1B54448", Offset = "0x1B54448", VA = "0x1B54448")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1B54454", Offset = "0x1B54454", VA = "0x1B54454")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public float CaretBlinkRate
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x1B54460", Offset = "0x1B54460", VA = "0x1B54460")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x1B5447C", Offset = "0x1B5447C", VA = "0x1B5447C")]
			set
			{
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1B53804", Offset = "0x1B53804", VA = "0x1B53804")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1B53C48", Offset = "0x1B53C48", VA = "0x1B53C48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1B53F00", Offset = "0x1B53F00", VA = "0x1B53F00", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1B54378", Offset = "0x1B54378", VA = "0x1B54378", Slot = "5")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1B54300", Offset = "0x1B54300", VA = "0x1B54300")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE52CD4", Offset = "0xE52CD4")]
		private IEnumerator CaretBlinker()
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1B53FBC", Offset = "0x1B53FBC", VA = "0x1B53FBC")]
		private void CreateCaret()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1B53C58", Offset = "0x1B53C58", VA = "0x1B53C58")]
		private void UpdateCaret()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1B543B0", Offset = "0x1B543B0", VA = "0x1B543B0")]
		private Vector2 GetLocalPositionInText(int charNo)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1B538B4", Offset = "0x1B538B4", VA = "0x1B538B4")]
		private void CheckAndConvertMask()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1B54498", Offset = "0x1B54498", VA = "0x1B54498")]
		public CurvedUITMPInputFieldCaret()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[ExecuteInEditMode]
	public class CurvedUITMPSubmesh : MonoBehaviour
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VertexHelper vh;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh straightMesh;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Mesh curvedMesh;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CurvedUIVertexEffect crvdVE;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TMP_SubMeshUI TMPsub;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI TMPtext;

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1B53298", Offset = "0x1B53298", VA = "0x1B53298")]
		public void UpdateSubmesh(bool tesselate, bool curve)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1B544A0", Offset = "0x1B544A0", VA = "0x1B544A0")]
		public CurvedUITMPSubmesh()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xE4E80C", Offset = "0xE4E80C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xE4E80C", Offset = "0xE4E80C")]
	public class OptionalDependencyAttribute : Attribute
	{
		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dependentClass;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string define;

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x2B33104", Offset = "0x2B33104", VA = "0x2B33104")]
		public OptionalDependencyAttribute(string dependentClass, string define)
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x20000CE")]
	public enum AAMode
	{
		[Token(Token = "0x4000384")]
		FXAA2,
		[Token(Token = "0x4000385")]
		FXAA3Console,
		[Token(Token = "0x4000386")]
		FXAA1PresetA,
		[Token(Token = "0x4000387")]
		FXAA1PresetB,
		[Token(Token = "0x4000388")]
		NFAA,
		[Token(Token = "0x4000389")]
		SSAA,
		[Token(Token = "0x400038A")]
		DLAA
	}
	[Token(Token = "0x20000CF")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4E86C", Offset = "0xE4E86C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4E86C", Offset = "0xE4E86C")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x2558168", Offset = "0x2558168", VA = "0x2558168")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x25581CC", Offset = "0x25581CC", VA = "0x25581CC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x2558340", Offset = "0x2558340", VA = "0x2558340")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x25588CC", Offset = "0x25588CC", VA = "0x25588CC")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4E900", Offset = "0xE4E900")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4E900", Offset = "0xE4E900")]
	[ExecuteInEditMode]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x20000D1")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40003C0")]
			Ghosting,
			[Token(Token = "0x40003C1")]
			Anamorphic,
			[Token(Token = "0x40003C2")]
			Combined
		}

		[Token(Token = "0x20000D2")]
		public enum TweakMode
		{
			[Token(Token = "0x40003C4")]
			Basic,
			[Token(Token = "0x40003C5")]
			Complex
		}

		[Token(Token = "0x20000D3")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40003C7")]
			Auto,
			[Token(Token = "0x40003C8")]
			On,
			[Token(Token = "0x40003C9")]
			Off
		}

		[Token(Token = "0x20000D4")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40003CB")]
			Screen,
			[Token(Token = "0x40003CC")]
			Add
		}

		[Token(Token = "0x20000D5")]
		public enum BloomQuality
		{
			[Token(Token = "0x40003CE")]
			Cheap,
			[Token(Token = "0x40003CF")]
			High
		}

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x255AE70", Offset = "0x255AE70", VA = "0x255AE70", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x255AF60", Offset = "0x255AF60", VA = "0x255AF60")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x255C410", Offset = "0x255C410", VA = "0x255C410")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x255C190", Offset = "0x255C190", VA = "0x255C190")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x255BE7C", Offset = "0x255BE7C", VA = "0x255BE7C")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x255BD90", Offset = "0x255BD90", VA = "0x255BD90")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x255BF70", Offset = "0x255BF70", VA = "0x255BF70")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x255C4E0", Offset = "0x255C4E0", VA = "0x255C4E0")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x40003D1")]
		Ghosting,
		[Token(Token = "0x40003D2")]
		Anamorphic,
		[Token(Token = "0x40003D3")]
		Combined
	}
	[Token(Token = "0x20000D7")]
	public enum TweakMode34
	{
		[Token(Token = "0x40003D5")]
		Basic,
		[Token(Token = "0x40003D6")]
		Complex
	}
	[Token(Token = "0x20000D8")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40003D8")]
		Auto,
		[Token(Token = "0x40003D9")]
		On,
		[Token(Token = "0x40003DA")]
		Off
	}
	[Token(Token = "0x20000D9")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40003DC")]
		Screen,
		[Token(Token = "0x40003DD")]
		Add
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4E994", Offset = "0xE4E994")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4E994", Offset = "0xE4E994")]
	[ExecuteInEditMode]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x255C620", Offset = "0x255C620", VA = "0x255C620", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x255C780", Offset = "0x255C780", VA = "0x255C780")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x255D7EC", Offset = "0x255D7EC", VA = "0x255D7EC")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x255D57C", Offset = "0x255D57C", VA = "0x255D57C")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x255D2CC", Offset = "0x255D2CC", VA = "0x255D2CC")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x255D408", Offset = "0x255D408", VA = "0x255D408")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x255D8A8", Offset = "0x255D8A8", VA = "0x255D8A8")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EA28", Offset = "0xE4EA28")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4EA28", Offset = "0xE4EA28")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x20000DC")]
		public enum Resolution
		{
			[Token(Token = "0x4000409")]
			Low,
			[Token(Token = "0x400040A")]
			High
		}

		[Token(Token = "0x20000DD")]
		public enum BlurType
		{
			[Token(Token = "0x400040C")]
			Standard,
			[Token(Token = "0x400040D")]
			Sgx
		}

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE50FC0", Offset = "0xE50FC0")]
		public float threshold;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE50FD8", Offset = "0xE50FD8")]
		public float intensity;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE50FF0", Offset = "0xE50FF0")]
		public float blurSize;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51008", Offset = "0xE51008")]
		public int blurIterations;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x255D9D8", Offset = "0x255D9D8", VA = "0x255D9D8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x255DA50", Offset = "0x255DA50", VA = "0x255DA50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x255DAFC", Offset = "0x255DAFC", VA = "0x255DAFC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x255DEDC", Offset = "0x255DEDC", VA = "0x255DEDC")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EABC", Offset = "0xE4EABC")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51020", Offset = "0xE51020")]
		public int iterations;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51038", Offset = "0xE51038")]
		public float blurSpread;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x1700010E")]
		protected Material material
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x255DF00", Offset = "0x255DF00", VA = "0x255DF00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x255E054", Offset = "0x255E054", VA = "0x255E054")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x255E158", Offset = "0x255E158", VA = "0x255E158")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x255E208", Offset = "0x255E208", VA = "0x255E208")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x255E32C", Offset = "0x255E32C", VA = "0x255E32C")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x255E43C", Offset = "0x255E43C", VA = "0x255E43C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x255E5A4", Offset = "0x255E5A4", VA = "0x255E5A4")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EB08", Offset = "0xE4EB08")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4EB08", Offset = "0xE4EB08")]
	[ExecuteInEditMode]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x20000E0")]
		public enum BlurType
		{
			[Token(Token = "0x4000419")]
			StandardGauss,
			[Token(Token = "0x400041A")]
			SgxGauss
		}

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51050", Offset = "0xE51050")]
		public int downsample;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51068", Offset = "0xE51068")]
		public float blurSize;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51080", Offset = "0xE51080")]
		public int blurIterations;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x255E5C0", Offset = "0x255E5C0", VA = "0x255E5C0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x255E638", Offset = "0x255E638", VA = "0x255E638")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x255E6E4", Offset = "0x255E6E4", VA = "0x255E6E4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x255EA90", Offset = "0x255EA90", VA = "0x255EA90")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EB9C", Offset = "0xE4EB9C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4EB9C", Offset = "0xE4EB9C")]
	[ExecuteInEditMode]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x20000E2")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x400043C")]
			CameraMotion,
			[Token(Token = "0x400043D")]
			LocalBlur,
			[Token(Token = "0x400043E")]
			Reconstruction,
			[Token(Token = "0x400043F")]
			ReconstructionDX11,
			[Token(Token = "0x4000440")]
			ReconstructionDisc
		}

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x25625A0", Offset = "0x25625A0", VA = "0x25625A0")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x25627FC", Offset = "0x25627FC", VA = "0x25627FC")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2562A94", Offset = "0x2562A94", VA = "0x2562A94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2562B68", Offset = "0x2562B68", VA = "0x2562B68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2562D00", Offset = "0x2562D00", VA = "0x2562D00", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2562DB8", Offset = "0x2562DB8", VA = "0x2562DB8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2562938", Offset = "0x2562938", VA = "0x2562938")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2564738", Offset = "0x2564738", VA = "0x2564738")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x25646A8", Offset = "0x25646A8", VA = "0x25646A8")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2564728", Offset = "0x2564728", VA = "0x2564728")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2564AEC", Offset = "0x2564AEC", VA = "0x2564AEC")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EC30", Offset = "0xE4EC30")]
	[ExecuteInEditMode]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x20000E4")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x400045A")]
			Simple,
			[Token(Token = "0x400045B")]
			Advanced
		}

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2564BF4", Offset = "0x2564BF4", VA = "0x2564BF4")]
		private new void Start()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2564C20", Offset = "0x2564C20", VA = "0x2564C20")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2564C24", Offset = "0x2564C24", VA = "0x2564C24", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2564F08", Offset = "0x2564F08", VA = "0x2564F08")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x25652C8", Offset = "0x25652C8", VA = "0x25652C8")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x25652CC", Offset = "0x25652CC", VA = "0x25652CC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2565618", Offset = "0x2565618", VA = "0x2565618")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EC7C", Offset = "0xE4EC7C")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x2565CA8", Offset = "0x2565CA8", VA = "0x2565CA8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x2565D1C", Offset = "0x2565D1C", VA = "0x2565D1C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2565DD8", Offset = "0x2565DD8", VA = "0x2565DD8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2565E84", Offset = "0x2565E84", VA = "0x2565E84")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x25660B8", Offset = "0x25660B8", VA = "0x25660B8")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x2566180", Offset = "0x2566180", VA = "0x2566180")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2566504", Offset = "0x2566504", VA = "0x2566504")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x256671C", Offset = "0x256671C", VA = "0x256671C")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4ECC8", Offset = "0xE4ECC8")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2566778", Offset = "0x2566778", VA = "0x2566778")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2566840", Offset = "0x2566840", VA = "0x2566840")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4ED14", Offset = "0xE4ED14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4ED14", Offset = "0xE4ED14")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51098", Offset = "0xE51098")]
		public float intensity;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE510B0", Offset = "0xE510B0")]
		public float threshold;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE510CC", Offset = "0xE510CC")]
		public float blurSpread;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2566934", Offset = "0x2566934", VA = "0x2566934", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x25669D4", Offset = "0x25669D4", VA = "0x25669D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2566D68", Offset = "0x2566D68", VA = "0x2566D68")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EDA8", Offset = "0xE4EDA8")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE510E4", Offset = "0xE510E4")]
		public float adaptationSpeed;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51100", Offset = "0xE51100")]
		public float limitMinimum;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51118", Offset = "0xE51118")]
		public float limitMaximum;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x1700010F")]
		protected Material materialLum
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x2566D80", Offset = "0x2566D80", VA = "0x2566D80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000110")]
		protected Material materialReduce
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x2566E5C", Offset = "0x2566E5C", VA = "0x2566E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		protected Material materialAdapt
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x2566F38", Offset = "0x2566F38", VA = "0x2566F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		protected Material materialApply
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x2567014", Offset = "0x2567014", VA = "0x2567014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x25670F0", Offset = "0x25670F0", VA = "0x25670F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2567178", Offset = "0x2567178", VA = "0x2567178")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x25672D8", Offset = "0x25672D8", VA = "0x25672D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2567504", Offset = "0x2567504", VA = "0x2567504")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2567768", Offset = "0x2567768", VA = "0x2567768")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2567964", Offset = "0x2567964", VA = "0x2567964")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4EDF4", Offset = "0xE4EDF4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EDF4", Offset = "0xE4EDF4")]
	[ExecuteInEditMode]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x25679E4", Offset = "0x25679E4", VA = "0x25679E4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2567AB4", Offset = "0x2567AB4", VA = "0x2567AB4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2567E88", Offset = "0x2567E88", VA = "0x2567E88")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4EE88", Offset = "0xE4EE88")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EE88", Offset = "0xE4EE88")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x20000EB")]
		public enum BlurType
		{
			[Token(Token = "0x4000498")]
			DiscBlur,
			[Token(Token = "0x4000499")]
			DX11
		}

		[Token(Token = "0x20000EC")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x400049B")]
			Low,
			[Token(Token = "0x400049C")]
			Medium,
			[Token(Token = "0x400049D")]
			High
		}

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2B26304", Offset = "0x2B26304", VA = "0x2B26304", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2B26AD8", Offset = "0x2B26AD8", VA = "0x2B26AD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2B26B5C", Offset = "0x2B26B5C", VA = "0x2B26B5C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2B26C78", Offset = "0x2B26C78", VA = "0x2B26C78")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x2B268C8", Offset = "0x2B268C8", VA = "0x2B268C8")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2B26CD4", Offset = "0x2B26CD4", VA = "0x2B26CD4")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2B26DC4", Offset = "0x2B26DC4", VA = "0x2B26DC4")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2B270F8", Offset = "0x2B270F8", VA = "0x2B270F8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2B28718", Offset = "0x2B28718", VA = "0x2B28718")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EF1C", Offset = "0xE4EF1C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4EF1C", Offset = "0xE4EF1C")]
	[ExecuteInEditMode]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x20000EE")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40004CA")]
			OnlyBackground = 1,
			[Token(Token = "0x40004CB")]
			BackgroundAndForeground
		}

		[Token(Token = "0x20000EF")]
		public enum DofResolution
		{
			[Token(Token = "0x40004CD")]
			High = 2,
			[Token(Token = "0x40004CE")]
			Medium,
			[Token(Token = "0x40004CF")]
			Low
		}

		[Token(Token = "0x20000F0")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40004D1")]
			Low = 1,
			[Token(Token = "0x40004D2")]
			High = 2,
			[Token(Token = "0x40004D3")]
			VeryHigh = 4
		}

		[Token(Token = "0x20000F1")]
		public enum BokehDestination
		{
			[Token(Token = "0x40004D5")]
			Background = 1,
			[Token(Token = "0x40004D6")]
			Foreground,
			[Token(Token = "0x40004D7")]
			BackgroundAndForeground
		}

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2B287FC", Offset = "0x2B287FC", VA = "0x2B287FC")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2B28908", Offset = "0x2B28908", VA = "0x2B28908", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2B28A3C", Offset = "0x2B28A3C", VA = "0x2B28A3C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x2B28C8C", Offset = "0x2B28C8C", VA = "0x2B28C8C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2B28D10", Offset = "0x2B28D10", VA = "0x2B28D10")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2B28E00", Offset = "0x2B28E00", VA = "0x2B28E00")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2B28E24", Offset = "0x2B28E24", VA = "0x2B28E24")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2B28E48", Offset = "0x2B28E48", VA = "0x2B28E48")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2B29D20", Offset = "0x2B29D20", VA = "0x2B29D20")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x2B2A410", Offset = "0x2B2A410", VA = "0x2B2A410")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2B2A888", Offset = "0x2B2A888", VA = "0x2B2A888")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x2B29BC0", Offset = "0x2B29BC0", VA = "0x2B29BC0")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2B29FC4", Offset = "0x2B29FC4", VA = "0x2B29FC4")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2B2A6E0", Offset = "0x2B2A6E0", VA = "0x2B2A6E0")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x2B297F4", Offset = "0x2B297F4", VA = "0x2B297F4")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x2B2AD54", Offset = "0x2B2AD54", VA = "0x2B2AD54")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4EFB0", Offset = "0xE4EFB0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4EFB0", Offset = "0xE4EFB0")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x20000F3")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40004E4")]
			TriangleDepthNormals,
			[Token(Token = "0x40004E5")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40004E6")]
			SobelDepth,
			[Token(Token = "0x40004E7")]
			SobelDepthThin,
			[Token(Token = "0x40004E8")]
			TriangleLuminance
		}

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2B2B858", Offset = "0x2B2B858", VA = "0x2B2B858", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x2B2B9A0", Offset = "0x2B2B9A0", VA = "0x2B2B9A0")]
		private new void Start()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x2B2B8E4", Offset = "0x2B2B8E4", VA = "0x2B2B8E4")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2B2B9AC", Offset = "0x2B2B9AC", VA = "0x2B2B9AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2B2B9B0", Offset = "0x2B2B9B0", VA = "0x2B2B9B0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x2B2BBD8", Offset = "0x2B2BBD8", VA = "0x2B2BBD8")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F044", Offset = "0xE4F044")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F044", Offset = "0xE4F044")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51130", Offset = "0xE51130")]
		public float strengthX;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51148", Offset = "0xE51148")]
		public float strengthY;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x2B2C4B4", Offset = "0x2B2C4B4", VA = "0x2B2C4B4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x2B2C520", Offset = "0x2B2C520", VA = "0x2B2C520")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x2B2C698", Offset = "0x2B2C698", VA = "0x2B2C698")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F0D8", Offset = "0xE4F0D8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F0D8", Offset = "0xE4F0D8")]
	[ExecuteInEditMode]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE51160", Offset = "0xE51160")]
		public bool distanceFog;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE51198", Offset = "0xE51198")]
		public bool excludeFarPixels;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE511D0", Offset = "0xE511D0")]
		public bool useRadialDistance;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE51208", Offset = "0xE51208")]
		public bool heightFog;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE51240", Offset = "0xE51240")]
		public float height;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51278", Offset = "0xE51278")]
		public float heightDensity;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE51294", Offset = "0xE51294")]
		public float startDistance;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x2B2D4F0", Offset = "0x2B2D4F0", VA = "0x2B2D4F0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x2B2D564", Offset = "0x2B2D564", VA = "0x2B2D564")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x2B2DB60", Offset = "0x2B2DB60", VA = "0x2B2DB60")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F16C", Offset = "0xE4F16C")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE512CC", Offset = "0xE512CC")]
		public float rampOffset;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x2B2DB80", Offset = "0x2B2DB80", VA = "0x2B2DB80")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x2B2DD4C", Offset = "0x2B2DD4C", VA = "0x2B2DD4C")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F1B8", Offset = "0xE4F1B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F1B8", Offset = "0xE4F1B8")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000113")]
		protected Material material
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x2B2DC70", Offset = "0x2B2DC70", VA = "0x2B2DC70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x2B2E438", Offset = "0x2B2E438", VA = "0x2B2E438", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x2B2E4D8", Offset = "0x2B2E4D8", VA = "0x2B2E4D8", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2B2DD54", Offset = "0x2B2DD54", VA = "0x2B2DD54")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F23C", Offset = "0xE4F23C")]
	public class ImageEffects
	{
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x2B2E584", Offset = "0x2B2E584", VA = "0x2B2E584")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x2B2E7D0", Offset = "0x2B2E7D0", VA = "0x2B2E7D0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE52DA4", Offset = "0xE52DA4")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x2B2E844", Offset = "0x2B2E844", VA = "0x2B2E844")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE52DDC", Offset = "0xE52DDC")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2B2E8C0", Offset = "0x2B2E8C0", VA = "0x2B2E8C0")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F274", Offset = "0xE4F274")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F274", Offset = "0xE4F274")]
	[ExecuteInEditMode]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE512E4", Offset = "0xE512E4")]
		public float blurAmount;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2B313EC", Offset = "0x2B313EC", VA = "0x2B313EC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2B313F0", Offset = "0x2B313F0", VA = "0x2B313F0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x2B31460", Offset = "0x2B31460", VA = "0x2B31460")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x2B317FC", Offset = "0x2B317FC", VA = "0x2B317FC")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F308", Offset = "0xE4F308")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F308", Offset = "0xE4F308")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2B3199C", Offset = "0x2B3199C", VA = "0x2B3199C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2B31A3C", Offset = "0x2B31A3C", VA = "0x2B31A3C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2B32240", Offset = "0x2B32240", VA = "0x2B32240")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2B32594", Offset = "0x2B32594", VA = "0x2B32594")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F39C", Offset = "0xE4F39C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F39C", Offset = "0xE4F39C")]
	[ExecuteInEditMode]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51300", Offset = "0xE51300")]
		public float grainIntensityMin;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51318", Offset = "0xE51318")]
		public float grainIntensityMax;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51330", Offset = "0xE51330")]
		public float grainSize;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51350", Offset = "0xE51350")]
		public float scratchIntensityMin;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51368", Offset = "0xE51368")]
		public float scratchIntensityMax;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51380", Offset = "0xE51380")]
		public float scratchFPS;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51398", Offset = "0xE51398")]
		public float scratchJitter;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000114")]
		protected Material material
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x2B32768", Offset = "0x2B32768", VA = "0x2B32768")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2B32620", Offset = "0x2B32620", VA = "0x2B32620")]
		protected void Start()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2B328E4", Offset = "0x2B328E4", VA = "0x2B328E4")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2B329E4", Offset = "0x2B329E4", VA = "0x2B329E4")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x2B32AD8", Offset = "0x2B32AD8", VA = "0x2B32AD8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x2B32E58", Offset = "0x2B32E58", VA = "0x2B32E58")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F430", Offset = "0xE4F430")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x2B264A8", Offset = "0x2B264A8", VA = "0x2B264A8")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x2B39724", Offset = "0x2B39724", VA = "0x2B39724")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x2B3992C", Offset = "0x2B3992C", VA = "0x2B3992C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x2B39938", Offset = "0x2B39938", VA = "0x2B39938")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x2B3993C", Offset = "0x2B3993C", VA = "0x2B3993C")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x2B39A0C", Offset = "0x2B39A0C", VA = "0x2B39A0C")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x2B39A14", Offset = "0x2B39A14", VA = "0x2B39A14", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x2B39AD8", Offset = "0x2B39AD8", VA = "0x2B39AD8")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x2B263B0", Offset = "0x2B263B0", VA = "0x2B263B0")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x2B39AE4", Offset = "0x2B39AE4", VA = "0x2B39AE4")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x2B39B40", Offset = "0x2B39B40", VA = "0x2B39B40")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x2B26A1C", Offset = "0x2B26A1C", VA = "0x2B26A1C")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x2B39B48", Offset = "0x2B39B48", VA = "0x2B39B48")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x2B396F8", Offset = "0x2B396F8", VA = "0x2B396F8")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x2B39DBC", Offset = "0x2B39DBC", VA = "0x2B39DBC")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x2B2876C", Offset = "0x2B2876C", VA = "0x2B2876C")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F4A0", Offset = "0xE4F4A0")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x2B3A138", Offset = "0x2B3A138", VA = "0x2B3A138")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x2B3A1AC", Offset = "0x2B3A1AC", VA = "0x2B3A1AC")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x2B3A404", Offset = "0x2B3A404", VA = "0x2B3A404")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x2B3A77C", Offset = "0x2B3A77C", VA = "0x2B3A77C")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x2B3A924", Offset = "0x2B3A924", VA = "0x2B3A924")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	internal class Quads
	{
		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x2B3AAAC", Offset = "0x2B3AAAC", VA = "0x2B3AAAC")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x2B28A94", Offset = "0x2B28A94", VA = "0x2B28A94")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x2B2AAB8", Offset = "0x2B2AAB8", VA = "0x2B2AAB8")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x2B3ABD8", Offset = "0x2B3ABD8", VA = "0x2B3ABD8")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x2B3AF98", Offset = "0x2B3AF98", VA = "0x2B3AF98")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F510", Offset = "0xE4F510")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F510", Offset = "0xE4F510")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x2000100")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x400052D")]
			Additive,
			[Token(Token = "0x400052E")]
			ScreenBlend,
			[Token(Token = "0x400052F")]
			Multiply,
			[Token(Token = "0x4000530")]
			Overlay,
			[Token(Token = "0x4000531")]
			AlphaBlend
		}

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2C1DDB0", Offset = "0x2C1DDB0", VA = "0x2C1DDB0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x2C1DE28", Offset = "0x2C1DE28", VA = "0x2C1DE28")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x2C1DFB0", Offset = "0x2C1DFB0", VA = "0x2C1DFB0")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F5A4", Offset = "0xE4F5A4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F5A4", Offset = "0xE4F5A4")]
	[ExecuteInEditMode]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE513B0", Offset = "0xE513B0")]
		public float intensity;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE513C8", Offset = "0xE513C8")]
		public float radius;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE513E4", Offset = "0xE513E4")]
		public int blurIterations;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE513FC", Offset = "0xE513FC")]
		public float blurFilterDistance;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51414", Offset = "0xE51414")]
		public int downsample;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x2C1DFC4", Offset = "0x2C1DFC4", VA = "0x2C1DFC4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x2C1E044", Offset = "0x2C1E044", VA = "0x2C1E044")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x2C1E0F0", Offset = "0x2C1E0F0", VA = "0x2C1E0F0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x2C1E930", Offset = "0x2C1E930", VA = "0x2C1E930")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F638", Offset = "0xE4F638")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F638", Offset = "0xE4F638")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		public enum SSAOSamples
		{
			[Token(Token = "0x4000546")]
			Low,
			[Token(Token = "0x4000547")]
			Medium,
			[Token(Token = "0x4000548")]
			High
		}

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE5142C", Offset = "0xE5142C")]
		public float m_Radius;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51448", Offset = "0xE51448")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51460", Offset = "0xE51460")]
		public int m_Blur;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51478", Offset = "0xE51478")]
		public int m_Downsampling;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51490", Offset = "0xE51490")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE514AC", Offset = "0xE514AC")]
		public float m_MinZ;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x2C1E950", Offset = "0x2C1E950", VA = "0x2C1E950")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2C1EA08", Offset = "0x2C1EA08", VA = "0x2C1EA08")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2C1EAA0", Offset = "0x2C1EAA0", VA = "0x2C1EAA0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x2C1EAA8", Offset = "0x2C1EAA8", VA = "0x2C1EAA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2C1EC54", Offset = "0x2C1EC54", VA = "0x2C1EC54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2C1EB70", Offset = "0x2C1EB70", VA = "0x2C1EB70")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2C1ECC4", Offset = "0x2C1ECC4", VA = "0x2C1ECC4")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x2C1F33C", Offset = "0x2C1F33C", VA = "0x2C1F33C")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F6CC", Offset = "0xE4F6CC")]
	[ExecuteInEditMode]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x2C1FF60", Offset = "0x2C1FF60", VA = "0x2C1FF60")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x2C1FFF0", Offset = "0x2C1FFF0", VA = "0x2C1FFF0")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F718", Offset = "0xE4F718")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F718", Offset = "0xE4F718")]
	[ExecuteInEditMode]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000106")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000558")]
			Low,
			[Token(Token = "0x4000559")]
			Normal,
			[Token(Token = "0x400055A")]
			High
		}

		[Token(Token = "0x2000107")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x400055C")]
			Screen,
			[Token(Token = "0x400055D")]
			Add
		}

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x2C26F58", Offset = "0x2C26F58", VA = "0x2C26F58", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x2C26FF8", Offset = "0x2C26FF8", VA = "0x2C26FF8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x2C277E0", Offset = "0x2C277E0", VA = "0x2C277E0")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F7AC", Offset = "0xE4F7AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F7AC", Offset = "0xE4F7AC")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000109")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000566")]
			TiltShiftMode,
			[Token(Token = "0x4000567")]
			IrisMode
		}

		[Token(Token = "0x200010A")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000569")]
			Preview,
			[Token(Token = "0x400056A")]
			Low,
			[Token(Token = "0x400056B")]
			Normal,
			[Token(Token = "0x400056C")]
			High
		}

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE514C8", Offset = "0xE514C8")]
		public float blurArea;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE514E0", Offset = "0xE514E0")]
		public float maxBlurSize;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE514F8", Offset = "0xE514F8")]
		public int downsample;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x16E8874", Offset = "0x16E8874", VA = "0x16E8874", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x16E88EC", Offset = "0x16E88EC", VA = "0x16E88EC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x16E8BA8", Offset = "0x16E8BA8", VA = "0x16E8BA8")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F830", Offset = "0xE4F830")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F830", Offset = "0xE4F830")]
	[ExecuteInEditMode]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x200010C")]
		public enum TonemapperType
		{
			[Token(Token = "0x400057B")]
			SimpleReinhard,
			[Token(Token = "0x400057C")]
			UserCurve,
			[Token(Token = "0x400057D")]
			Hable,
			[Token(Token = "0x400057E")]
			Photographic,
			[Token(Token = "0x400057F")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000580")]
			AdaptiveReinhard,
			[Token(Token = "0x4000581")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x200010D")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000583")]
			Square16 = 0x10,
			[Token(Token = "0x4000584")]
			Square32 = 0x20,
			[Token(Token = "0x4000585")]
			Square64 = 0x40,
			[Token(Token = "0x4000586")]
			Square128 = 0x80,
			[Token(Token = "0x4000587")]
			Square256 = 0x100,
			[Token(Token = "0x4000588")]
			Square512 = 0x200,
			[Token(Token = "0x4000589")]
			Square1024 = 0x400
		}

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x16E8BC4", Offset = "0x16E8BC4", VA = "0x16E8BC4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x16E8D3C", Offset = "0x16E8D3C", VA = "0x16E8D3C")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x16E8FF0", Offset = "0x16E8FF0", VA = "0x16E8FF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x16E917C", Offset = "0x16E917C", VA = "0x16E917C")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x16E9284", Offset = "0x16E9284", VA = "0x16E9284")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x16E9AE8", Offset = "0x16E9AE8", VA = "0x16E9AE8")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200010E")]
	internal class Triangles
	{
		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x16E9B18", Offset = "0x16E9B18", VA = "0x16E9B18")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x16E9C5C", Offset = "0x16E9C5C", VA = "0x16E9C5C")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x16E9E54", Offset = "0x16E9E54", VA = "0x16E9E54")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x16EA0F0", Offset = "0x16EA0F0", VA = "0x16EA0F0")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x16EA40C", Offset = "0x16EA40C", VA = "0x16EA40C")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F8C4", Offset = "0xE4F8C4")]
	[ExecuteInEditMode]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xE51510", Offset = "0xE51510")]
		public float angle;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x16EA418", Offset = "0x16EA418", VA = "0x16EA418")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x16EA464", Offset = "0x16EA464", VA = "0x16EA464")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F910", Offset = "0xE4F910")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xE4F910", Offset = "0xE4F910")]
	[ExecuteInEditMode]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x2000111")]
		public enum AberrationMode
		{
			[Token(Token = "0x400059E")]
			Simple,
			[Token(Token = "0x400059F")]
			Advanced
		}

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x16F489C", Offset = "0x16F489C", VA = "0x16F489C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x16F4964", Offset = "0x16F4964", VA = "0x16F4964")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x16F4F54", Offset = "0x16F4F54", VA = "0x16F4F54")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE4F9A4", Offset = "0xE4F9A4")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x16F57A8", Offset = "0x16F57A8", VA = "0x16F57A8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x16F57F4", Offset = "0x16F57F4", VA = "0x16F57F4")]
		public Vortex()
		{
		}
	}
}
