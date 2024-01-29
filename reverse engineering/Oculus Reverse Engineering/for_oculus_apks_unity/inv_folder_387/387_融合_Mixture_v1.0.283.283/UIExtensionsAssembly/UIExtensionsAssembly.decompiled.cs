using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class Packer
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2FD6CA8", Offset = "0x2FD6CA8", VA = "0x2FD6CA8")]
	public static float ToFloat(float x, float y, float z, float w)
	{
		return default(float);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2FD6F68", Offset = "0x2FD6F68", VA = "0x2FD6F68")]
	public static float ToFloat(Vector4 factor)
	{
		return default(float);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2FD6FA4", Offset = "0x2FD6FA4", VA = "0x2FD6FA4")]
	public static float ToFloat(float x, float y, float z)
	{
		return default(float);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2FD71AC", Offset = "0x2FD71AC", VA = "0x2FD71AC")]
	public static float ToFloat(float x, float y)
	{
		return default(float);
	}
}
namespace Coffee.UIExtensions;

[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly List<Vector2> s_Uv0;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly List<Vector2> s_Uv1;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly List<Vector3> s_Vertices;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly List<int> s_Indices;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly List<Vector3> s_Normals;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly List<Vector4> s_Tangents;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly List<Color32> s_Colors;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly VertexHelper s_VertexHelper;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly List<TMP_SubMeshUI> s_SubMeshUIs;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly List<Mesh> s_Meshes;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static readonly Material[] s_EmptyMaterials;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool _initialized;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CanvasRenderer _canvasRenderer;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Graphic _graphic;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material[] _materials;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool _isTextMeshProActive;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TMP_Text _textMeshPro;

	[Token(Token = "0x17000001")]
	public Graphic graphic
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2FD72F4", Offset = "0x2FD72F4", VA = "0x2FD72F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public CanvasRenderer canvasRenderer
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2FD7318", Offset = "0x2FD7318", VA = "0x2FD7318")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public TMP_Text textMeshPro
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2FD733C", Offset = "0x2FD733C", VA = "0x2FD733C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2FD7360", Offset = "0x2FD7360", VA = "0x2FD7360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public virtual AdditionalCanvasShaderChannels requiredChannels
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2FD7384", Offset = "0x2FD7384", VA = "0x2FD7384", Slot = "19")]
		get
		{
			return default(AdditionalCanvasShaderChannels);
		}
	}

	[Token(Token = "0x17000006")]
	public bool isTMPro
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2FD738C", Offset = "0x2FD738C", VA = "0x2FD738C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public virtual Material material
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2FD7400", Offset = "0x2FD7400", VA = "0x2FD7400", Slot = "20")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2FD7508", Offset = "0x2FD7508", VA = "0x2FD7508", Slot = "21")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public virtual Material[] materials
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2FD7620", Offset = "0x2FD7620", VA = "0x2FD7620", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	protected virtual bool isLegacyMeshModifier
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2FD7CA4", Offset = "0x2FD7CA4", VA = "0x2FD7CA4", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2FD77B4", Offset = "0x2FD77B4", VA = "0x2FD77B4", Slot = "23")]
	public virtual void ModifyMesh(Mesh mesh)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2FD77B8", Offset = "0x2FD77B8", VA = "0x2FD77B8", Slot = "24")]
	public virtual void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2FD77BC", Offset = "0x2FD77BC", VA = "0x2FD77BC", Slot = "25")]
	public virtual void SetVerticesDirty()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2FD7CA0", Offset = "0x2FD7CA0", VA = "0x2FD7CA0")]
	public void ShowTMProWarning(Shader shader, Shader mobileShader, Shader spriteShader, Action<Material> onCreatedMaterial)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2FD7CAC", Offset = "0x2FD7CAC", VA = "0x2FD7CAC", Slot = "27")]
	protected virtual void Initialize()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2FD7DE0", Offset = "0x2FD7DE0", VA = "0x2FD7DE0", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2FD8108", Offset = "0x2FD8108", VA = "0x2FD8108", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2FD81E8", Offset = "0x2FD81E8", VA = "0x2FD81E8", Slot = "28")]
	protected virtual void LateUpdate()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2FD82FC", Offset = "0x2FD82FC", VA = "0x2FD82FC", Slot = "13")]
	protected override void OnDidApplyAnimationProperties()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2FD830C", Offset = "0x2FD830C", VA = "0x2FD830C")]
	private void OnTextChanged(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2FD8A80", Offset = "0x2FD8A80", VA = "0x2FD8A80")]
	private void FillVertexHelper(VertexHelper vh, Mesh mesh)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2FD8E90", Offset = "0x2FD8E90", VA = "0x2FD8E90")]
	protected BaseMeshEffect()
	{
	}
}
[Token(Token = "0x2000004")]
public enum EffectArea
{
	[Token(Token = "0x4000014")]
	RectTransform,
	[Token(Token = "0x4000015")]
	Fit,
	[Token(Token = "0x4000016")]
	Character
}
[Token(Token = "0x2000005")]
public static class EffectAreaExtensions
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Rect rectForCharacter;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Vector2[] splitedCharacterPosition;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2FD925C", Offset = "0x2FD925C", VA = "0x2FD925C")]
	public static Rect GetEffectArea(this EffectArea area, VertexHelper vh, Rect rectangle, float aspectRatio = -1f)
	{
		return default(Rect);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2FD9468", Offset = "0x2FD9468", VA = "0x2FD9468")]
	public static void GetPositionFactor(this EffectArea area, int index, Rect rect, Vector2 position, bool isText, bool isTMPro, out float x, out float y)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2FD9628", Offset = "0x2FD9628", VA = "0x2FD9628")]
	public static void GetNormalizedFactor(this EffectArea area, int index, Matrix2x3 matrix, Vector2 position, bool isText, out Vector2 nomalizedPos)
	{
	}
}
[Token(Token = "0x2000006")]
public enum ShadowStyle
{
	[Token(Token = "0x400001A")]
	None,
	[Token(Token = "0x400001B")]
	Shadow,
	[Token(Token = "0x400001C")]
	Outline,
	[Token(Token = "0x400001D")]
	Outline8,
	[Token(Token = "0x400001E")]
	Shadow3
}
[Token(Token = "0x2000007")]
[AddComponentMenu("UI/MeshEffectForTextMeshPro/UIDissolve", 3)]
public class UIDissolve : UIEffectBase
{
	[Token(Token = "0x400001F")]
	public const string shaderName = "UI/Hidden/UI-Effect-Dissolve";

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ParameterTexture _ptex;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Tooltip("Current location[0-1] for dissolve effect. 0 is not dissolved, 1 is completely dissolved.")]
	[FormerlySerializedAs("m_Location")]
	[SerializeField]
	[Range(0f, 1f)]
	private float m_EffectFactor;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Range(0f, 1f)]
	[SerializeField]
	[Tooltip("Edge width.")]
	private float m_Width;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Range(0f, 1f)]
	[SerializeField]
	[Tooltip("Edge softness.")]
	private float m_Softness;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[ColorUsage(false)]
	[SerializeField]
	[Tooltip("Edge color.")]
	private Color m_Color;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Tooltip("Edge color effect mode.")]
	private ColorMode m_ColorMode;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Tooltip("Noise texture for dissolving (single channel texture).")]
	private Texture m_NoiseTexture;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Tooltip("The area for effect.")]
	[SerializeField]
	protected EffectArea m_EffectArea;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[SerializeField]
	[Tooltip("Keep effect aspect ratio.")]
	private bool m_KeepAspectRatio;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Header("Effect Player")]
	private EffectPlayer m_Player;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	[SerializeField]
	[Obsolete]
	[Range(0.1f, 10f)]
	private float m_Duration;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[SerializeField]
	[HideInInspector]
	[Obsolete]
	private AnimatorUpdateMode m_UpdateMode;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private MaterialCache _materialCache;

	[Token(Token = "0x1700000A")]
	public override AdditionalCanvasShaderChannels requiredChannels
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2FD993C", Offset = "0x2FD993C", VA = "0x2FD993C", Slot = "19")]
		get
		{
			return default(AdditionalCanvasShaderChannels);
		}
	}

	[Token(Token = "0x1700000B")]
	[Obsolete("Use effectFactor instead (UnityUpgradable) -> effectFactor")]
	public float location
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2FD9944", Offset = "0x2FD9944", VA = "0x2FD9944")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2FD994C", Offset = "0x2FD994C", VA = "0x2FD994C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public float effectFactor
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2FD9A14", Offset = "0x2FD9A14", VA = "0x2FD9A14")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2FD9A1C", Offset = "0x2FD9A1C", VA = "0x2FD9A1C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public float width
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2FD9AE4", Offset = "0x2FD9AE4", VA = "0x2FD9AE4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2FD9AEC", Offset = "0x2FD9AEC", VA = "0x2FD9AEC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public float softness
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2FD9BB4", Offset = "0x2FD9BB4", VA = "0x2FD9BB4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2FD9BBC", Offset = "0x2FD9BBC", VA = "0x2FD9BBC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public Color color
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2FD9C84", Offset = "0x2FD9C84", VA = "0x2FD9C84")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2FD9C90", Offset = "0x2FD9C90", VA = "0x2FD9C90")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public Texture noiseTexture
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2FD9CF0", Offset = "0x2FD9CF0", VA = "0x2FD9CF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2FD9D68", Offset = "0x2FD9D68", VA = "0x2FD9D68")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public EffectArea effectArea
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2FD9E48", Offset = "0x2FD9E48", VA = "0x2FD9E48")]
		get
		{
			return default(EffectArea);
		}
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2FD9E50", Offset = "0x2FD9E50", VA = "0x2FD9E50")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public bool keepAspectRatio
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2FD9E74", Offset = "0x2FD9E74", VA = "0x2FD9E74")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2FD9E7C", Offset = "0x2FD9E7C", VA = "0x2FD9E7C")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public ColorMode colorMode
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2FD9EA4", Offset = "0x2FD9EA4", VA = "0x2FD9EA4")]
		get
		{
			return default(ColorMode);
		}
	}

	[Token(Token = "0x17000014")]
	[Obsolete("Use Play/Stop method instead")]
	public bool play
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2FD9EAC", Offset = "0x2FD9EAC", VA = "0x2FD9EAC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2FD9F48", Offset = "0x2FD9F48", VA = "0x2FD9F48")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	[Obsolete]
	public bool loop
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2FD9F6C", Offset = "0x2FD9F6C", VA = "0x2FD9F6C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2FD9F88", Offset = "0x2FD9F88", VA = "0x2FD9F88")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public float duration
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2FD9FAC", Offset = "0x2FD9FAC", VA = "0x2FD9FAC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2FD9FC8", Offset = "0x2FD9FC8", VA = "0x2FD9FC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	[Obsolete]
	public float loopDelay
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2FD9FFC", Offset = "0x2FD9FFC", VA = "0x2FD9FFC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2FDA018", Offset = "0x2FDA018", VA = "0x2FDA018")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public AnimatorUpdateMode updateMode
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2FDA048", Offset = "0x2FDA048", VA = "0x2FDA048")]
		get
		{
			return default(AnimatorUpdateMode);
		}
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2FDA064", Offset = "0x2FDA064", VA = "0x2FDA064")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public override ParameterTexture ptex
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2FDA084", Offset = "0x2FDA084", VA = "0x2FDA084", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public EffectPlayer _player
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2FD9EC8", Offset = "0x2FD9EC8", VA = "0x2FD9EC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2FDA0DC", Offset = "0x2FDA0DC", VA = "0x2FDA0DC", Slot = "33")]
	public override void ModifyMaterial()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2FDA6B0", Offset = "0x2FDA6B0", VA = "0x2FDA6B0", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2FDAB10", Offset = "0x2FDAB10", VA = "0x2FDAB10", Slot = "34")]
	protected override void SetDirty()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2FDAE50", Offset = "0x2FDAE50", VA = "0x2FDAE50")]
	public void Play()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2FDAEA0", Offset = "0x2FDAEA0", VA = "0x2FDAEA0")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2FDAED0", Offset = "0x2FDAED0", VA = "0x2FDAED0", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2FDB248", Offset = "0x2FDB248", VA = "0x2FDB248", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2FDB438", Offset = "0x2FDB438", VA = "0x2FDB438")]
	public UIDissolve()
	{
	}
}
[Token(Token = "0x2000008")]
[AddComponentMenu("UI/MeshEffectForTextMeshPro/UIFlip", 102)]
[DisallowMultipleComponent]
public class UIFlip : BaseMeshEffect
{
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Tooltip("Flip horizontally.")]
	[SerializeField]
	private bool m_Horizontal;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	[Tooltip("Flip vertically.")]
	[SerializeField]
	private bool m_Veritical;

	[Token(Token = "0x1700001B")]
	public bool horizontal
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2FDB820", Offset = "0x2FDB820", VA = "0x2FDB820")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2FDB828", Offset = "0x2FDB828", VA = "0x2FDB828")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public bool vertical
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2FDB840", Offset = "0x2FDB840", VA = "0x2FDB840")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2FDB848", Offset = "0x2FDB848", VA = "0x2FDB848")]
		set
		{
		}
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2FDB860", Offset = "0x2FDB860", VA = "0x2FDB860", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2FDB99C", Offset = "0x2FDB99C", VA = "0x2FDB99C")]
	public UIFlip()
	{
	}
}
[Token(Token = "0x2000009")]
[DisallowMultipleComponent]
[AddComponentMenu("UI/MeshEffectForTextMeshPro/UIGradient", 101)]
public class UIGradient : BaseMeshEffect
{
	[Token(Token = "0x200000A")]
	public enum Direction
	{
		[Token(Token = "0x400003C")]
		Horizontal,
		[Token(Token = "0x400003D")]
		Vertical,
		[Token(Token = "0x400003E")]
		Angle,
		[Token(Token = "0x400003F")]
		Diagonal
	}

	[Token(Token = "0x200000B")]
	public enum GradientStyle
	{
		[Token(Token = "0x4000041")]
		Rect,
		[Token(Token = "0x4000042")]
		Fit,
		[Token(Token = "0x4000043")]
		Split
	}

	[Token(Token = "0x200000C")]
	private struct Matrix2x3
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m00;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m01;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m02;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m10;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m11;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m12;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2FDC718", Offset = "0x2FDC718", VA = "0x2FDC718")]
		public Matrix2x3(Rect rect, float cos, float sin)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2FDC81C", Offset = "0x2FDC81C", VA = "0x2FDC81C")]
		public static Vector2 operator *(Matrix2x3 m, Vector2 v)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Tooltip("Gradient Direction.")]
	private Direction m_Direction;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Tooltip("Color1: Top or Left.")]
	private Color m_Color1;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Tooltip("Color2: Bottom or Right.")]
	[SerializeField]
	private Color m_Color2;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Color3: For diagonal.")]
	[SerializeField]
	private Color m_Color3;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Tooltip("Color4: For diagonal.")]
	[SerializeField]
	private Color m_Color4;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[Tooltip("Gradient rotation.")]
	[SerializeField]
	[Range(-180f, 180f)]
	private float m_Rotation;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Range(-1f, 1f)]
	[Tooltip("Gradient offset for Horizontal, Vertical or Angle.")]
	private float m_Offset1;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[Tooltip("Gradient offset for Diagonal.")]
	[SerializeField]
	[Range(-1f, 1f)]
	private float m_Offset2;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Tooltip("Gradient style for Text.")]
	[SerializeField]
	private GradientStyle m_GradientStyle;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[Tooltip("Color space to correct color.")]
	[SerializeField]
	private ColorSpace m_ColorSpace;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[Tooltip("Ignore aspect ratio.")]
	[SerializeField]
	private bool m_IgnoreAspectRatio;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector2[] s_SplitedCharacterPosition;

	[Token(Token = "0x1700001D")]
	public Graphic targetGraphic
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2FDB9F0", Offset = "0x2FDB9F0", VA = "0x2FDB9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001E")]
	public Direction direction
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2FDBA14", Offset = "0x2FDBA14", VA = "0x2FDBA14")]
		get
		{
			return default(Direction);
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2FDBA1C", Offset = "0x2FDBA1C", VA = "0x2FDBA1C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public Color color1
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2FDBA40", Offset = "0x2FDBA40", VA = "0x2FDBA40")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2FDBA4C", Offset = "0x2FDBA4C", VA = "0x2FDBA4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public Color color2
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2FDBAAC", Offset = "0x2FDBAAC", VA = "0x2FDBAAC")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2FDBAB8", Offset = "0x2FDBAB8", VA = "0x2FDBAB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public Color color3
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2FDBB18", Offset = "0x2FDBB18", VA = "0x2FDBB18")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2FDBB24", Offset = "0x2FDBB24", VA = "0x2FDBB24")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Color color4
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2FDBB84", Offset = "0x2FDBB84", VA = "0x2FDBB84")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2FDBB90", Offset = "0x2FDBB90", VA = "0x2FDBB90")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public float rotation
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2FDBBF0", Offset = "0x2FDBBF0", VA = "0x2FDBBF0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2FDBC1C", Offset = "0x2FDBC1C", VA = "0x2FDBC1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public float offset
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2FDBCD4", Offset = "0x2FDBCD4", VA = "0x2FDBCD4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2FDBCDC", Offset = "0x2FDBCDC", VA = "0x2FDBCDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Vector2 offset2
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2FDBD00", Offset = "0x2FDBD00", VA = "0x2FDBD00")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2FDBD08", Offset = "0x2FDBD08", VA = "0x2FDBD08")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public GradientStyle gradientStyle
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2FDBD38", Offset = "0x2FDBD38", VA = "0x2FDBD38")]
		get
		{
			return default(GradientStyle);
		}
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2FDBD40", Offset = "0x2FDBD40", VA = "0x2FDBD40")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public ColorSpace colorSpace
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2FDBD64", Offset = "0x2FDBD64", VA = "0x2FDBD64")]
		get
		{
			return default(ColorSpace);
		}
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2FDBD6C", Offset = "0x2FDBD6C", VA = "0x2FDBD6C")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public bool ignoreAspectRatio
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2FDBD90", Offset = "0x2FDBD90", VA = "0x2FDBD90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2FDBD98", Offset = "0x2FDBD98", VA = "0x2FDBD98")]
		set
		{
		}
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2FDBDC0", Offset = "0x2FDBDC0", VA = "0x2FDBDC0", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2FDC84C", Offset = "0x2FDC84C", VA = "0x2FDC84C")]
	public UIGradient()
	{
	}
}
[Token(Token = "0x200000D")]
[AddComponentMenu("UI/MeshEffectForTextMeshPro/UIShadow", 100)]
public class UIShadow : BaseMeshEffect
{
	[Serializable]
	[Token(Token = "0x200000E")]
	[Obsolete]
	public class AdditionalShadow
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("shadowBlur")]
		[Range(0f, 1f)]
		public float blur;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[FormerlySerializedAs("shadowMode")]
		public ShadowStyle style;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("shadowColor")]
		public Color effectColor;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 effectDistance;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useGraphicAlpha;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2FDDEA4", Offset = "0x2FDDEA4", VA = "0x2FDDEA4")]
		public AdditionalShadow()
		{
		}
	}

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Range(0f, 1f)]
	[FormerlySerializedAs("m_Blur")]
	[Tooltip("How far is the blurring shadow from the graphic.")]
	private float m_BlurFactor;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Tooltip("Shadow effect style.")]
	[SerializeField]
	private ShadowStyle m_Style;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	private List<AdditionalShadow> m_AdditionalShadows;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Color m_EffectColor;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Vector2 m_EffectDistance;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private bool m_UseGraphicAlpha;

	[Token(Token = "0x4000050")]
	private const float kMaxEffectDistance = 600f;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int _graphicVertexCount;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly List<UIShadow> tmpShadows;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly List<UIVertex> s_Verts;

	[Token(Token = "0x17000029")]
	public Color effectColor
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2FDCA3C", Offset = "0x2FDCA3C", VA = "0x2FDCA3C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2FDCA48", Offset = "0x2FDCA48", VA = "0x2FDCA48")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public Vector2 effectDistance
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2FDCB2C", Offset = "0x2FDCB2C", VA = "0x2FDCB2C")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2FDCB34", Offset = "0x2FDCB34", VA = "0x2FDCB34")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public bool useGraphicAlpha
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2FDCC48", Offset = "0x2FDCC48", VA = "0x2FDCC48")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2FDCC50", Offset = "0x2FDCC50", VA = "0x2FDCC50")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	[Obsolete("Use blurFactor instead (UnityUpgradable) -> blurFactor")]
	public float blur
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2FDCD18", Offset = "0x2FDCD18", VA = "0x2FDCD18")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2FDCD20", Offset = "0x2FDCD20", VA = "0x2FDCD20")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public float blurFactor
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2FDCDEC", Offset = "0x2FDCDEC", VA = "0x2FDCDEC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2FDCDF4", Offset = "0x2FDCDF4", VA = "0x2FDCDF4")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public ShadowStyle style
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2FDCE10", Offset = "0x2FDCE10", VA = "0x2FDCE10")]
		get
		{
			return default(ShadowStyle);
		}
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2FDCE18", Offset = "0x2FDCE18", VA = "0x2FDCE18")]
		set
		{
		}
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2FDCE20", Offset = "0x2FDCE20", VA = "0x2FDCE20", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2FDCE24", Offset = "0x2FDCE24", VA = "0x2FDCE24", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2FDCE28", Offset = "0x2FDCE28", VA = "0x2FDCE28", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2FDD2BC", Offset = "0x2FDD2BC", VA = "0x2FDD2BC")]
	private void _ApplyShadow(List<UIVertex> verts, Color color, ref int start, ref int end, Vector2 effectDistance, ShadowStyle style, bool useGraphicAlpha)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2FDD664", Offset = "0x2FDD664", VA = "0x2FDD664")]
	private void _ApplyShadowZeroAlloc(List<UIVertex> verts, Color color, ref int start, ref int end, float x, float y, bool useGraphicAlpha)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2FDCD3C", Offset = "0x2FDCD3C", VA = "0x2FDCD3C")]
	private void _SetDirty()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2FDDCD8", Offset = "0x2FDDCD8", VA = "0x2FDDCD8")]
	public UIShadow()
	{
	}
}
[Token(Token = "0x200000F")]
public class UIEffect_Demo : MonoBehaviour
{
	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectMask2D mask;

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2FDDED8", Offset = "0x2FDDED8", VA = "0x2FDDED8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2FDDF5C", Offset = "0x2FDDF5C", VA = "0x2FDDF5C")]
	public void SetTimeScale(float scale)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2FDDF64", Offset = "0x2FDDF64", VA = "0x2FDDF64")]
	public void Open(Animator anim)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2FDE3E8", Offset = "0x2FDE3E8", VA = "0x2FDE3E8")]
	public void Close(Animator anim)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2FDE43C", Offset = "0x2FDE43C", VA = "0x2FDE43C")]
	public void Capture(Animator anim)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2FDE4B8", Offset = "0x2FDE4B8", VA = "0x2FDE4B8")]
	public void SetCanvasOverlay(bool isOverlay)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2FDE524", Offset = "0x2FDE524", VA = "0x2FDE524")]
	public UIEffect_Demo()
	{
	}
}
[Token(Token = "0x2000010")]
public class UIEffect_Demo_Dialog : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator m_Animator;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2FDE52C", Offset = "0x2FDE52C", VA = "0x2FDE52C")]
	public void Open()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2FDE550", Offset = "0x2FDE550", VA = "0x2FDE550")]
	public void Close()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2FDE5A4", Offset = "0x2FDE5A4", VA = "0x2FDE5A4")]
	public void Closed()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2FDE5C8", Offset = "0x2FDE5C8", VA = "0x2FDE5C8")]
	public UIEffect_Demo_Dialog()
	{
	}
}
[Token(Token = "0x2000011")]
public enum BlurMode
{
	[Token(Token = "0x400005C")]
	None,
	[Token(Token = "0x400005D")]
	FastBlur,
	[Token(Token = "0x400005E")]
	MediumBlur,
	[Token(Token = "0x400005F")]
	DetailBlur
}
[Token(Token = "0x2000012")]
public enum ColorMode
{
	[Token(Token = "0x4000061")]
	Multiply,
	[Token(Token = "0x4000062")]
	Fill,
	[Token(Token = "0x4000063")]
	Add,
	[Token(Token = "0x4000064")]
	Subtract
}
[Serializable]
[Token(Token = "0x2000013")]
public class EffectPlayer
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Tooltip("Playing.")]
	public bool play;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[Tooltip("Loop.")]
	public bool loop;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Tooltip("Duration.")]
	[Range(0.01f, 10f)]
	public float duration;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Delay before looping.")]
	[Range(0f, 10f)]
	public float loopDelay;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Update mode")]
	public AnimatorUpdateMode updateMode;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<Action> s_UpdateActions;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float _time;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Action<float> _callback;

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2FDAFF4", Offset = "0x2FDAFF4", VA = "0x2FDAFF4")]
	public void OnEnable([Optional] Action<float> callback)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2FDB354", Offset = "0x2FDB354", VA = "0x2FDB354")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2FDAE84", Offset = "0x2FDAE84", VA = "0x2FDAE84")]
	public void Play([Optional] Action<float> callback)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2FDAEC8", Offset = "0x2FDAEC8", VA = "0x2FDAEC8")]
	public void Stop()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2FDE5D0", Offset = "0x2FDE5D0", VA = "0x2FDE5D0")]
	private void OnWillRenderCanvases()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2FDB428", Offset = "0x2FDB428", VA = "0x2FDB428")]
	public EffectPlayer()
	{
	}
}
[Token(Token = "0x2000015")]
public class MaterialCache
{
	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<MaterialCache> materialCaches;

	[Token(Token = "0x1700002F")]
	public ulong hash
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2FDE7C4", Offset = "0x2FDE7C4", VA = "0x2FDE7C4")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2FDE7CC", Offset = "0x2FDE7CC", VA = "0x2FDE7CC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public int referenceCount
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2FDE7D4", Offset = "0x2FDE7D4", VA = "0x2FDE7D4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2FDE7DC", Offset = "0x2FDE7DC", VA = "0x2FDE7DC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public Texture texture
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2FDE7E4", Offset = "0x2FDE7E4", VA = "0x2FDE7E4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2FDE7EC", Offset = "0x2FDE7EC", VA = "0x2FDE7EC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public Material material
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2FDE7F4", Offset = "0x2FDE7F4", VA = "0x2FDE7F4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2FDE7FC", Offset = "0x2FDE7FC", VA = "0x2FDE7FC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2FDA404", Offset = "0x2FDA404", VA = "0x2FDA404")]
	public static MaterialCache Register(ulong hash, Texture texture, Func<Material> onCreateMaterial)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2FDE814", Offset = "0x2FDE814", VA = "0x2FDE814")]
	public static MaterialCache Register(ulong hash, Func<Material> onCreateMaterial)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2FDA350", Offset = "0x2FDA350", VA = "0x2FDA350")]
	public static void Unregister(MaterialCache cache)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2FDE80C", Offset = "0x2FDE80C", VA = "0x2FDE80C")]
	public MaterialCache()
	{
	}
}
[Token(Token = "0x2000018")]
public struct Matrix2x3
{
	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float m00;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float m01;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float m02;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float m10;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float m11;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float m12;

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2FDEB0C", Offset = "0x2FDEB0C", VA = "0x2FDEB0C")]
	public Matrix2x3(Rect rect, float cos, float sin)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2FD9758", Offset = "0x2FD9758", VA = "0x2FD9758")]
	public static Vector2 operator *(Matrix2x3 m, Vector2 v)
	{
		return default(Vector2);
	}
}
[Token(Token = "0x2000019")]
public interface IParameterTexture
{
	[Token(Token = "0x17000033")]
	int parameterIndex
	{
		[Token(Token = "0x60000A7")]
		get;
		[Token(Token = "0x60000A8")]
		set;
	}

	[Token(Token = "0x17000034")]
	ParameterTexture ptex
	{
		[Token(Token = "0x60000A9")]
		get;
	}
}
[Serializable]
[Token(Token = "0x200001A")]
public class ParameterTexture
{
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Texture2D _texture;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool _needUpload;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int _propertyId;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string _propertyName;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly int _channels;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private readonly int _instanceLimit;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly byte[] _data;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Stack<int> _stack;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<Action> updates;

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2FDB5AC", Offset = "0x2FDB5AC", VA = "0x2FDB5AC")]
	public ParameterTexture(int channels, int instanceLimit, string propertyName)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x2FDEC10", Offset = "0x2FDEC10", VA = "0x2FDEC10")]
	public void Register(IParameterTexture target)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2FDF08C", Offset = "0x2FDF08C", VA = "0x2FDF08C")]
	public void Unregister(IParameterTexture target)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2FDF224", Offset = "0x2FDF224", VA = "0x2FDF224")]
	public void SetData(IParameterTexture target, int channelId, byte value)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2FDAE20", Offset = "0x2FDAE20", VA = "0x2FDAE20")]
	public void SetData(IParameterTexture target, int channelId, float value)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2FDAD80", Offset = "0x2FDAD80", VA = "0x2FDAD80")]
	public void RegisterMaterial(Material mat)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2FDAA54", Offset = "0x2FDAA54", VA = "0x2FDAA54")]
	public float GetNormalizedIndex(IParameterTexture target)
	{
		return default(float);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2FDED6C", Offset = "0x2FDED6C", VA = "0x2FDED6C")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2FDF384", Offset = "0x2FDF384", VA = "0x2FDF384")]
	private void UpdateParameterTexture()
	{
	}
}
[Token(Token = "0x200001C")]
public enum EffectMode
{
	[Token(Token = "0x4000088")]
	None,
	[Token(Token = "0x4000089")]
	Grayscale,
	[Token(Token = "0x400008A")]
	Sepia,
	[Token(Token = "0x400008B")]
	Nega,
	[Token(Token = "0x400008C")]
	Pixel
}
[Token(Token = "0x200001D")]
[DisallowMultipleComponent]
public abstract class UIEffectBase : BaseMeshEffect, IParameterTexture
{
	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static readonly Vector2[] splitedCharacterPosition;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static readonly List<UIVertex> tempVerts;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[HideInInspector]
	private int m_Version;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected Material m_EffectMaterial;

	[Token(Token = "0x17000035")]
	public int parameterIndex
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2FDF56C", Offset = "0x2FDF56C", VA = "0x2FDF56C", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2FDF574", Offset = "0x2FDF574", VA = "0x2FDF574", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public virtual ParameterTexture ptex
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2FDF57C", Offset = "0x2FDF57C", VA = "0x2FDF57C", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000037")]
	public Graphic targetGraphic
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2FDF584", Offset = "0x2FDF584", VA = "0x2FDF584")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000038")]
	public Material effectMaterial
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2FDF5A8", Offset = "0x2FDF5A8", VA = "0x2FDF5A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2FDF5B0", Offset = "0x2FDF5B0", VA = "0x2FDF5B0", Slot = "33")]
	public virtual void ModifyMaterial()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2FDAF6C", Offset = "0x2FDAF6C", VA = "0x2FDAF6C", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2FDB2D8", Offset = "0x2FDB2D8", VA = "0x2FDB2D8", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2FDF60C", Offset = "0x2FDF60C", VA = "0x2FDF60C", Slot = "34")]
	protected virtual void SetDirty()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x2FDF61C", Offset = "0x2FDF61C", VA = "0x2FDF61C", Slot = "13")]
	protected override void OnDidApplyAnimationProperties()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2FDB4B8", Offset = "0x2FDB4B8", VA = "0x2FDB4B8")]
	protected UIEffectBase()
	{
	}
}
[Token(Token = "0x200001E")]
[DisallowMultipleComponent]
[RequireComponent(typeof(Graphic))]
[ExecuteInEditMode]
[AddComponentMenu("UI/UIEffect/UIEffect", 1)]
public class UIEffect : UIEffectBase
{
	[Token(Token = "0x200001F")]
	public enum BlurEx
	{
		[Token(Token = "0x40000A3")]
		None,
		[Token(Token = "0x40000A4")]
		Ex
	}

	[Token(Token = "0x4000092")]
	public const string shaderName = "UI/Hidden/UI-Effect";

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ParameterTexture _ptex;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Range(0f, 1f)]
	[Tooltip("Effect factor between 0(no effect) and 1(complete effect).")]
	[FormerlySerializedAs("m_ToneLevel")]
	[SerializeField]
	private float m_EffectFactor;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("Color effect factor between 0(no effect) and 1(complete effect).")]
	[SerializeField]
	[Range(0f, 1f)]
	private float m_ColorFactor;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Range(0f, 1f)]
	[SerializeField]
	[Tooltip("How far is the blurring from the graphic.")]
	[FormerlySerializedAs("m_Blur")]
	private float m_BlurFactor;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Tooltip("Effect mode")]
	[FormerlySerializedAs("m_ToneMode")]
	private EffectMode m_EffectMode;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Color effect mode")]
	[SerializeField]
	private ColorMode m_ColorMode;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Blur effect mode")]
	[SerializeField]
	private BlurMode m_BlurMode;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[Tooltip("Advanced blurring remove common artifacts in the blur effect for uGUI.")]
	[SerializeField]
	private bool m_AdvancedBlur;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Obsolete]
	[Range(0f, 1f)]
	[SerializeField]
	[HideInInspector]
	private float m_ShadowBlur;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[HideInInspector]
	[SerializeField]
	[Obsolete]
	private ShadowStyle m_ShadowStyle;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[HideInInspector]
	[Obsolete]
	private Color m_ShadowColor;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	private Vector2 m_EffectDistance;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Obsolete]
	[SerializeField]
	[HideInInspector]
	private bool m_UseGraphicAlpha;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[Obsolete]
	[HideInInspector]
	[SerializeField]
	private Color m_EffectColor;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Obsolete]
	[HideInInspector]
	[SerializeField]
	private List<UIShadow.AdditionalShadow> m_AdditionalShadows;

	[Token(Token = "0x17000039")]
	[Obsolete("Use effectFactor instead (UnityUpgradable) -> effectFactor")]
	public float toneLevel
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2FDF7F8", Offset = "0x2FDF7F8", VA = "0x2FDF7F8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2FDF800", Offset = "0x2FDF800", VA = "0x2FDF800")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public float effectFactor
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2FDF828", Offset = "0x2FDF828", VA = "0x2FDF828")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2FDF830", Offset = "0x2FDF830", VA = "0x2FDF830")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public float colorFactor
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2FDF858", Offset = "0x2FDF858", VA = "0x2FDF858")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2FDF860", Offset = "0x2FDF860", VA = "0x2FDF860")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	[Obsolete("Use blurFactor instead (UnityUpgradable) -> blurFactor")]
	public float blur
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2FDF888", Offset = "0x2FDF888", VA = "0x2FDF888")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2FDF890", Offset = "0x2FDF890", VA = "0x2FDF890")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	[Obsolete("Use effectFactor instead (UnityUpgradable) -> effectFactor")]
	public float blurFactor
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2FDF8B8", Offset = "0x2FDF8B8", VA = "0x2FDF8B8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2FDF8C0", Offset = "0x2FDF8C0", VA = "0x2FDF8C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	[Obsolete("Use effectMode instead (UnityUpgradable) -> effectMode")]
	public EffectMode toneMode
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2FDF8E8", Offset = "0x2FDF8E8", VA = "0x2FDF8E8")]
		get
		{
			return default(EffectMode);
		}
	}

	[Token(Token = "0x1700003F")]
	public EffectMode effectMode
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2FDF8F0", Offset = "0x2FDF8F0", VA = "0x2FDF8F0")]
		get
		{
			return default(EffectMode);
		}
	}

	[Token(Token = "0x17000040")]
	public ColorMode colorMode
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2FDF8F8", Offset = "0x2FDF8F8", VA = "0x2FDF8F8")]
		get
		{
			return default(ColorMode);
		}
	}

	[Token(Token = "0x17000041")]
	public BlurMode blurMode
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2FDF900", Offset = "0x2FDF900", VA = "0x2FDF900")]
		get
		{
			return default(BlurMode);
		}
	}

	[Token(Token = "0x17000042")]
	public Color effectColor
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2FDF908", Offset = "0x2FDF908", VA = "0x2FDF908")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2FDF940", Offset = "0x2FDF940", VA = "0x2FDF940")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public override ParameterTexture ptex
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2FDF9BC", Offset = "0x2FDF9BC", VA = "0x2FDF9BC", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2FDFA14", Offset = "0x2FDFA14", VA = "0x2FDFA14", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2FE0348", Offset = "0x2FE0348", VA = "0x2FE0348", Slot = "34")]
	protected override void SetDirty()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2FE0168", Offset = "0x2FE0168", VA = "0x2FE0168")]
	private static void GetBounds(List<UIVertex> verts, int start, int count, ref Rect posBounds, ref Rect uvBounds, bool global)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2FE046C", Offset = "0x2FE046C", VA = "0x2FE046C")]
	public UIEffect()
	{
	}
}
[Token(Token = "0x2000020")]
[AddComponentMenu("UI/UIEffect/UIEffectCapturedImage", 200)]
public class UIEffectCapturedImage : RawImage
{
	[Token(Token = "0x2000021")]
	public enum DesamplingRate
	{
		[Token(Token = "0x40000BD")]
		None = 0,
		[Token(Token = "0x40000BE")]
		x1 = 1,
		[Token(Token = "0x40000BF")]
		x2 = 2,
		[Token(Token = "0x40000C0")]
		x4 = 4,
		[Token(Token = "0x40000C1")]
		x8 = 8
	}

	[Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class <_CoUpdateTextureOnNextFrame>d__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIEffectCapturedImage <>4__this;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2FE1660", Offset = "0x2FE1660", VA = "0x2FE1660", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x2FE16A8", Offset = "0x2FE16A8", VA = "0x2FE16A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2FE1548", Offset = "0x2FE1548", VA = "0x2FE1548")]
		[DebuggerHidden]
		public <_CoUpdateTextureOnNextFrame>d__95(int <>1__state)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2FE15B4", Offset = "0x2FE15B4", VA = "0x2FE15B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2FE15B8", Offset = "0x2FE15B8", VA = "0x2FE15B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2FE1668", Offset = "0x2FE1668", VA = "0x2FE1668", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A5")]
	public const string shaderName = "UI/Hidden/UI-EffectCapture";

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[Tooltip("Effect factor between 0(no effect) and 1(complete effect).")]
	[FormerlySerializedAs("m_ToneLevel")]
	[SerializeField]
	[Range(0f, 1f)]
	private float m_EffectFactor;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	[Tooltip("Color effect factor between 0(no effect) and 1(complete effect).")]
	[SerializeField]
	[Range(0f, 1f)]
	private float m_ColorFactor;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Range(0f, 1f)]
	[Tooltip("How far is the blurring from the graphic.")]
	[FormerlySerializedAs("m_Blur")]
	[SerializeField]
	private float m_BlurFactor;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	[Tooltip("Effect mode.")]
	[SerializeField]
	[FormerlySerializedAs("m_ToneMode")]
	private EffectMode m_EffectMode;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Tooltip("Color effect mode.")]
	private ColorMode m_ColorMode;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	[SerializeField]
	[Tooltip("Blur effect mode.")]
	private BlurMode m_BlurMode;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[Tooltip("Color for the color effect.")]
	[SerializeField]
	private Color m_EffectColor;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[Tooltip("Desampling rate of the generated RenderTexture.")]
	[SerializeField]
	private DesamplingRate m_DesamplingRate;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	[Tooltip("Desampling rate of reduction buffer to apply effect.")]
	[SerializeField]
	private DesamplingRate m_ReductionRate;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Tooltip("FilterMode for capturing.")]
	private FilterMode m_FilterMode;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Tooltip("Effect material.")]
	private Material m_EffectMaterial;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[Tooltip("Blur iterations.")]
	[Range(1f, 8f)]
	[SerializeField]
	[FormerlySerializedAs("m_Iterations")]
	private int m_BlurIterations;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	[SerializeField]
	[FormerlySerializedAs("m_KeepCanvasSize")]
	[Tooltip("Fits graphic size to screen on captured.")]
	private bool m_FitToScreen;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
	[SerializeField]
	[Tooltip("Capture automatically on enable.")]
	private bool m_CaptureOnEnable;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12E")]
	[SerializeField]
	[Tooltip("Capture immediately.")]
	private bool m_ImmediateCapturing;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private RenderTexture _rt;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int s_CopyId;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int s_EffectId1;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int s_EffectId2;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int s_EffectFactorId;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int s_ColorFactorId;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static CommandBuffer s_CommandBuffer;

	[Token(Token = "0x17000044")]
	[Obsolete("Use effectFactor instead (UnityUpgradable) -> effectFactor")]
	public float toneLevel
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2FE05F0", Offset = "0x2FE05F0", VA = "0x2FE05F0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2FE05F8", Offset = "0x2FE05F8", VA = "0x2FE05F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public float effectFactor
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2FE0614", Offset = "0x2FE0614", VA = "0x2FE0614")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2FE061C", Offset = "0x2FE061C", VA = "0x2FE061C")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public float colorFactor
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2FE0638", Offset = "0x2FE0638", VA = "0x2FE0638")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2FE0640", Offset = "0x2FE0640", VA = "0x2FE0640")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	[Obsolete("Use blurFactor instead (UnityUpgradable) -> blurFactor")]
	public float blur
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2FE065C", Offset = "0x2FE065C", VA = "0x2FE065C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2FE0664", Offset = "0x2FE0664", VA = "0x2FE0664")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public float blurFactor
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2FE0680", Offset = "0x2FE0680", VA = "0x2FE0680")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2FE0688", Offset = "0x2FE0688", VA = "0x2FE0688")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	[Obsolete("Use effectMode instead (UnityUpgradable) -> effectMode")]
	public EffectMode toneMode
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2FE06A4", Offset = "0x2FE06A4", VA = "0x2FE06A4")]
		get
		{
			return default(EffectMode);
		}
	}

	[Token(Token = "0x1700004A")]
	public EffectMode effectMode
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2FE06AC", Offset = "0x2FE06AC", VA = "0x2FE06AC")]
		get
		{
			return default(EffectMode);
		}
	}

	[Token(Token = "0x1700004B")]
	public ColorMode colorMode
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2FE06B4", Offset = "0x2FE06B4", VA = "0x2FE06B4")]
		get
		{
			return default(ColorMode);
		}
	}

	[Token(Token = "0x1700004C")]
	public BlurMode blurMode
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2FE06BC", Offset = "0x2FE06BC", VA = "0x2FE06BC")]
		get
		{
			return default(BlurMode);
		}
	}

	[Token(Token = "0x1700004D")]
	public Color effectColor
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2FE06C4", Offset = "0x2FE06C4", VA = "0x2FE06C4")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2FE06D8", Offset = "0x2FE06D8", VA = "0x2FE06D8")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public virtual Material effectMaterial
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2FE06EC", Offset = "0x2FE06EC", VA = "0x2FE06EC", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004F")]
	public DesamplingRate desamplingRate
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2FE06F4", Offset = "0x2FE06F4", VA = "0x2FE06F4")]
		get
		{
			return default(DesamplingRate);
		}
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2FE06FC", Offset = "0x2FE06FC", VA = "0x2FE06FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public DesamplingRate reductionRate
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2FE0704", Offset = "0x2FE0704", VA = "0x2FE0704")]
		get
		{
			return default(DesamplingRate);
		}
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2FE070C", Offset = "0x2FE070C", VA = "0x2FE070C")]
		set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public FilterMode filterMode
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2FE0714", Offset = "0x2FE0714", VA = "0x2FE0714")]
		get
		{
			return default(FilterMode);
		}
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2FE071C", Offset = "0x2FE071C", VA = "0x2FE071C")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public RenderTexture capturedTexture
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2FE0724", Offset = "0x2FE0724", VA = "0x2FE0724")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000053")]
	[Obsolete("Use blurIterations instead (UnityUpgradable) -> blurIterations")]
	public int iterations
	{
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2FE072C", Offset = "0x2FE072C", VA = "0x2FE072C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2FE0734", Offset = "0x2FE0734", VA = "0x2FE0734")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public int blurIterations
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2FE073C", Offset = "0x2FE073C", VA = "0x2FE073C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2FE0744", Offset = "0x2FE0744", VA = "0x2FE0744")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	[Obsolete("Use fitToScreen instead (UnityUpgradable) -> fitToScreen")]
	public bool keepCanvasSize
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2FE074C", Offset = "0x2FE074C", VA = "0x2FE074C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2FE0754", Offset = "0x2FE0754", VA = "0x2FE0754")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	public bool fitToScreen
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2FE0760", Offset = "0x2FE0760", VA = "0x2FE0760")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2FE0768", Offset = "0x2FE0768", VA = "0x2FE0768")]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	[Obsolete]
	public RenderTexture targetTexture
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2FE0774", Offset = "0x2FE0774", VA = "0x2FE0774")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2FE077C", Offset = "0x2FE077C", VA = "0x2FE077C")]
		set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public bool captureOnEnable
	{
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2FE0780", Offset = "0x2FE0780", VA = "0x2FE0780")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2FE0788", Offset = "0x2FE0788", VA = "0x2FE0788")]
		set
		{
		}
	}

	[Token(Token = "0x17000059")]
	public bool immediateCapturing
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2FE0794", Offset = "0x2FE0794", VA = "0x2FE0794")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2FE079C", Offset = "0x2FE079C", VA = "0x2FE079C")]
		set
		{
		}
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x2FE07A8", Offset = "0x2FE07A8", VA = "0x2FE07A8", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x2FE07E0", Offset = "0x2FE07E0", VA = "0x2FE07E0", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2FE08E0", Offset = "0x2FE08E0", VA = "0x2FE08E0", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x2FE0934", Offset = "0x2FE0934", VA = "0x2FE0934", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2FE0C88", Offset = "0x2FE0C88", VA = "0x2FE0C88")]
	public void GetDesamplingSize(DesamplingRate rate, out int w, out int h)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2FDDFFC", Offset = "0x2FDDFFC", VA = "0x2FDDFFC")]
	public void Capture()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2FE0E5C", Offset = "0x2FE0E5C", VA = "0x2FE0E5C")]
	private void SetupCommandBuffer()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2FE0910", Offset = "0x2FE0910", VA = "0x2FE0910")]
	public void Release()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x2FE082C", Offset = "0x2FE082C", VA = "0x2FE082C")]
	private void _Release(bool releaseRT)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2FE1544", Offset = "0x2FE1544", VA = "0x2FE1544")]
	[Conditional("UNITY_EDITOR")]
	private void _SetDirty()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2FE0DAC", Offset = "0x2FE0DAC", VA = "0x2FE0DAC")]
	private void _Release(ref RenderTexture obj)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x2FE14D0", Offset = "0x2FE14D0", VA = "0x2FE14D0")]
	[IteratorStateMachine(typeof(<_CoUpdateTextureOnNextFrame>d__95))]
	private IEnumerator _CoUpdateTextureOnNextFrame()
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x2FE1434", Offset = "0x2FE1434", VA = "0x2FE1434")]
	private void UpdateTexture()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x2FE1570", Offset = "0x2FE1570", VA = "0x2FE1570")]
	public UIEffectCapturedImage()
	{
	}
}
[Token(Token = "0x2000023")]
[AddComponentMenu("UI/UIEffect/UIHsvModifier", 4)]
public class UIHsvModifier : UIEffectBase
{
	[Token(Token = "0x40000C5")]
	public const string shaderName = "UI/Hidden/UI-Effect-HSV";

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ParameterTexture _ptex;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Header("Target")]
	[Tooltip("Target color to affect hsv shift.")]
	[SerializeField]
	[ColorUsage(false)]
	private Color m_TargetColor;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Color range to affect hsv shift [0 ~ 1].")]
	[SerializeField]
	[Range(0f, 1f)]
	private float m_Range;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Hue shift [-0.5 ~ 0.5].")]
	[SerializeField]
	[Header("Adjustment")]
	[Range(-0.5f, 0.5f)]
	private float m_Hue;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[Tooltip("Saturation shift [-0.5 ~ 0.5].")]
	[SerializeField]
	[Range(-0.5f, 0.5f)]
	private float m_Saturation;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Value shift [-0.5 ~ 0.5].")]
	[Range(-0.5f, 0.5f)]
	[SerializeField]
	private float m_Value;

	[Token(Token = "0x1700005C")]
	public Color targetColor
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2FE16B0", Offset = "0x2FE16B0", VA = "0x2FE16B0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2FE16BC", Offset = "0x2FE16BC", VA = "0x2FE16BC")]
		set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public float range
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2FE171C", Offset = "0x2FE171C", VA = "0x2FE171C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2FE1724", Offset = "0x2FE1724", VA = "0x2FE1724")]
		set
		{
		}
	}

	[Token(Token = "0x1700005E")]
	public float saturation
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2FE17EC", Offset = "0x2FE17EC", VA = "0x2FE17EC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2FE17F4", Offset = "0x2FE17F4", VA = "0x2FE17F4")]
		set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public float value
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2FE18BC", Offset = "0x2FE18BC", VA = "0x2FE18BC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2FE18C4", Offset = "0x2FE18C4", VA = "0x2FE18C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000060")]
	public float hue
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2FE198C", Offset = "0x2FE198C", VA = "0x2FE198C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2FE1994", Offset = "0x2FE1994", VA = "0x2FE1994")]
		set
		{
		}
	}

	[Token(Token = "0x17000061")]
	public override ParameterTexture ptex
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2FE1A5C", Offset = "0x2FE1A5C", VA = "0x2FE1A5C", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x2FE1AB4", Offset = "0x2FE1AB4", VA = "0x2FE1AB4", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2FE1BBC", Offset = "0x2FE1BBC", VA = "0x2FE1BBC", Slot = "34")]
	protected override void SetDirty()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x2FE1EA0", Offset = "0x2FE1EA0", VA = "0x2FE1EA0")]
	public UIHsvModifier()
	{
	}
}
[Token(Token = "0x2000024")]
[AddComponentMenu("UI/UIEffect/UIShiny", 2)]
public class UIShiny : UIEffectBase
{
	[Token(Token = "0x40000CC")]
	public const string shaderName = "UI/Hidden/UI-Effect-Shiny";

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ParameterTexture _ptex;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Tooltip("Location for shiny effect.")]
	[FormerlySerializedAs("m_Location")]
	[SerializeField]
	[Range(0f, 1f)]
	private float m_EffectFactor;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("Width for shiny effect.")]
	[SerializeField]
	[Range(0f, 1f)]
	private float m_Width;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Range(-180f, 180f)]
	[Tooltip("Rotation for shiny effect.")]
	private float m_Rotation;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Softness for shiny effect.")]
	[SerializeField]
	[Range(0.01f, 1f)]
	private float m_Softness;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Range(0f, 1f)]
	[FormerlySerializedAs("m_Alpha")]
	[SerializeField]
	[Tooltip("Brightness for shiny effect.")]
	private float m_Brightness;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Range(0f, 1f)]
	[FormerlySerializedAs("m_Highlight")]
	[Tooltip("Gloss factor for shiny effect.")]
	private float m_Gloss;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[Tooltip("The area for effect.")]
	[SerializeField]
	protected EffectArea m_EffectArea;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private EffectPlayer m_Player;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Obsolete]
	[HideInInspector]
	[SerializeField]
	private bool m_Play;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	[SerializeField]
	[Obsolete]
	[HideInInspector]
	private bool m_Loop;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[Obsolete]
	[SerializeField]
	[Range(0.1f, 10f)]
	[HideInInspector]
	private float m_Duration;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Obsolete]
	[HideInInspector]
	[SerializeField]
	[Range(0f, 10f)]
	private float m_LoopDelay;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[Obsolete]
	[HideInInspector]
	[SerializeField]
	private AnimatorUpdateMode m_UpdateMode;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float _lastRotation;

	[Token(Token = "0x17000062")]
	[Obsolete("Use effectFactor instead (UnityUpgradable) -> effectFactor")]
	public float location
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2FE1FAC", Offset = "0x2FE1FAC", VA = "0x2FE1FAC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2FE1FB4", Offset = "0x2FE1FB4", VA = "0x2FE1FB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000063")]
	public float effectFactor
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2FE207C", Offset = "0x2FE207C", VA = "0x2FE207C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2FE2084", Offset = "0x2FE2084", VA = "0x2FE2084")]
		set
		{
		}
	}

	[Token(Token = "0x17000064")]
	public float width
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2FE214C", Offset = "0x2FE214C", VA = "0x2FE214C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2FE2154", Offset = "0x2FE2154", VA = "0x2FE2154")]
		set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public float softness
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2FE221C", Offset = "0x2FE221C", VA = "0x2FE221C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2FE2224", Offset = "0x2FE2224", VA = "0x2FE2224")]
		set
		{
		}
	}

	[Token(Token = "0x17000066")]
	[Obsolete("Use brightness instead (UnityUpgradable) -> brightness")]
	public float alpha
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2FE22F0", Offset = "0x2FE22F0", VA = "0x2FE22F0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2FE22F8", Offset = "0x2FE22F8", VA = "0x2FE22F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000067")]
	public float brightness
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2FE23C0", Offset = "0x2FE23C0", VA = "0x2FE23C0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2FE23C8", Offset = "0x2FE23C8", VA = "0x2FE23C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000068")]
	[Obsolete("Use gloss instead (UnityUpgradable) -> gloss")]
	public float highlight
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2FE2490", Offset = "0x2FE2490", VA = "0x2FE2490")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2FE2498", Offset = "0x2FE2498", VA = "0x2FE2498")]
		set
		{
		}
	}

	[Token(Token = "0x17000069")]
	public float gloss
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2FE2560", Offset = "0x2FE2560", VA = "0x2FE2560")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2FE2568", Offset = "0x2FE2568", VA = "0x2FE2568")]
		set
		{
		}
	}

	[Token(Token = "0x1700006A")]
	public float rotation
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2FE2630", Offset = "0x2FE2630", VA = "0x2FE2630")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2FE2638", Offset = "0x2FE2638", VA = "0x2FE2638")]
		set
		{
		}
	}

	[Token(Token = "0x1700006B")]
	public EffectArea effectArea
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2FE26F0", Offset = "0x2FE26F0", VA = "0x2FE26F0")]
		get
		{
			return default(EffectArea);
		}
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2FE26F8", Offset = "0x2FE26F8", VA = "0x2FE26F8")]
		set
		{
		}
	}

	[Token(Token = "0x1700006C")]
	public bool play
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2FE271C", Offset = "0x2FE271C", VA = "0x2FE271C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2FE27B8", Offset = "0x2FE27B8", VA = "0x2FE27B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700006D")]
	public bool loop
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2FE27DC", Offset = "0x2FE27DC", VA = "0x2FE27DC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2FE27F8", Offset = "0x2FE27F8", VA = "0x2FE27F8")]
		set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public float duration
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2FE281C", Offset = "0x2FE281C", VA = "0x2FE281C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2FE2838", Offset = "0x2FE2838", VA = "0x2FE2838")]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	public float loopDelay
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2FE286C", Offset = "0x2FE286C", VA = "0x2FE286C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2FE2888", Offset = "0x2FE2888", VA = "0x2FE2888")]
		set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public AnimatorUpdateMode updateMode
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2FE28B8", Offset = "0x2FE28B8", VA = "0x2FE28B8")]
		get
		{
			return default(AnimatorUpdateMode);
		}
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2FE28D4", Offset = "0x2FE28D4", VA = "0x2FE28D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000071")]
	public override ParameterTexture ptex
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2FE28F4", Offset = "0x2FE28F4", VA = "0x2FE28F4", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000072")]
	private EffectPlayer _player
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2FE2738", Offset = "0x2FE2738", VA = "0x2FE2738")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x2FE294C", Offset = "0x2FE294C", VA = "0x2FE294C", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x2FE29E8", Offset = "0x2FE29E8", VA = "0x2FE29E8", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x2FE2A0C", Offset = "0x2FE2A0C", VA = "0x2FE2A0C", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x2FE2DD0", Offset = "0x2FE2DD0", VA = "0x2FE2DD0")]
	public void Play()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x2FE2DF4", Offset = "0x2FE2DF4", VA = "0x2FE2DF4")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x2FE2E10", Offset = "0x2FE2E10", VA = "0x2FE2E10", Slot = "34")]
	protected override void SetDirty()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x2FE3128", Offset = "0x2FE3128", VA = "0x2FE3128")]
	public UIShiny()
	{
	}
}
[Token(Token = "0x2000025")]
[AddComponentMenu("UI/UIEffect/UITransitionEffect", 5)]
public class UITransitionEffect : UIEffectBase
{
	[Token(Token = "0x2000026")]
	public enum EffectMode
	{
		[Token(Token = "0x40000EA")]
		Fade = 1,
		[Token(Token = "0x40000EB")]
		Cutoff,
		[Token(Token = "0x40000EC")]
		Dissolve
	}

	[Token(Token = "0x40000DC")]
	public const string shaderName = "UI/Hidden/UI-Effect-Transition";

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ParameterTexture _ptex;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Tooltip("Effect mode.")]
	private EffectMode m_EffectMode;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("Effect factor between 0(hidden) and 1(shown).")]
	[SerializeField]
	[Range(0f, 1f)]
	private float m_EffectFactor;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Transition texture (single channel texture).")]
	[SerializeField]
	private Texture m_TransitionTexture;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("The area for effect.")]
	[SerializeField]
	private EffectArea m_EffectArea;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[Tooltip("Keep effect aspect ratio.")]
	[SerializeField]
	private bool m_KeepAspectRatio;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Dissolve edge width.")]
	[Range(0f, 1f)]
	[SerializeField]
	private float m_DissolveWidth;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Range(0f, 1f)]
	[Tooltip("Dissolve edge softness.")]
	[SerializeField]
	private float m_DissolveSoftness;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Tooltip("Dissolve edge color.")]
	[SerializeField]
	[ColorUsage(false)]
	private Color m_DissolveColor;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Tooltip("Disable graphic's raycast target on hidden.")]
	[SerializeField]
	private bool m_PassRayOnHidden;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Header("Effect Player")]
	[SerializeField]
	private EffectPlayer m_Player;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private MaterialCache _materialCache;

	[Token(Token = "0x17000073")]
	public float effectFactor
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2FE323C", Offset = "0x2FE323C", VA = "0x2FE323C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2FE3244", Offset = "0x2FE3244", VA = "0x2FE3244")]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public Texture transitionTexture
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2FE330C", Offset = "0x2FE330C", VA = "0x2FE330C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2FE3314", Offset = "0x2FE3314", VA = "0x2FE3314")]
		set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public EffectMode effectMode
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2FE33F4", Offset = "0x2FE33F4", VA = "0x2FE33F4")]
		get
		{
			return default(EffectMode);
		}
	}

	[Token(Token = "0x17000076")]
	public bool keepAspectRatio
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2FE33FC", Offset = "0x2FE33FC", VA = "0x2FE33FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2FE3404", Offset = "0x2FE3404", VA = "0x2FE3404")]
		set
		{
		}
	}

	[Token(Token = "0x17000077")]
	public override ParameterTexture ptex
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2FE3458", Offset = "0x2FE3458", VA = "0x2FE3458", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000078")]
	public float dissolveWidth
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2FE34B0", Offset = "0x2FE34B0", VA = "0x2FE34B0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2FE34B8", Offset = "0x2FE34B8", VA = "0x2FE34B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000079")]
	public float dissolveSoftness
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2FE3580", Offset = "0x2FE3580", VA = "0x2FE3580")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2FE3588", Offset = "0x2FE3588", VA = "0x2FE3588")]
		set
		{
		}
	}

	[Token(Token = "0x1700007A")]
	public Color dissolveColor
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2FE3650", Offset = "0x2FE3650", VA = "0x2FE3650")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2FE365C", Offset = "0x2FE365C", VA = "0x2FE365C")]
		set
		{
		}
	}

	[Token(Token = "0x1700007B")]
	public float duration
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2FE36BC", Offset = "0x2FE36BC", VA = "0x2FE36BC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2FE3758", Offset = "0x2FE3758", VA = "0x2FE3758")]
		set
		{
		}
	}

	[Token(Token = "0x1700007C")]
	public bool passRayOnHidden
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2FE378C", Offset = "0x2FE378C", VA = "0x2FE378C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2FE3794", Offset = "0x2FE3794", VA = "0x2FE3794")]
		set
		{
		}
	}

	[Token(Token = "0x1700007D")]
	public AnimatorUpdateMode updateMode
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2FE37A0", Offset = "0x2FE37A0", VA = "0x2FE37A0")]
		get
		{
			return default(AnimatorUpdateMode);
		}
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2FE37BC", Offset = "0x2FE37BC", VA = "0x2FE37BC")]
		set
		{
		}
	}

	[Token(Token = "0x1700007E")]
	private EffectPlayer _player
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2FE36D8", Offset = "0x2FE36D8", VA = "0x2FE36D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x2FE37DC", Offset = "0x2FE37DC", VA = "0x2FE37DC")]
	public void Show()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2FE3890", Offset = "0x2FE3890", VA = "0x2FE3890")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x2FE3944", Offset = "0x2FE3944", VA = "0x2FE3944", Slot = "33")]
	public override void ModifyMaterial()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x2FE3BDC", Offset = "0x2FE3BDC", VA = "0x2FE3BDC", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x2FE3F1C", Offset = "0x2FE3F1C", VA = "0x2FE3F1C", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x2FE3F58", Offset = "0x2FE3F58", VA = "0x2FE3F58", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x2FE3FE8", Offset = "0x2FE3FE8", VA = "0x2FE3FE8", Slot = "34")]
	protected override void SetDirty()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x2FE4290", Offset = "0x2FE4290", VA = "0x2FE4290")]
	public UITransitionEffect()
	{
	}
}
