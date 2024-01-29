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
	[Address(RVA = "0x29F0A28", Offset = "0x29F0A28", VA = "0x29F0A28")]
	public static float ToFloat(float x, float y, float z, float w)
	{
		return default(float);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x29F0CE8", Offset = "0x29F0CE8", VA = "0x29F0CE8")]
	public static float ToFloat(Vector4 factor)
	{
		return default(float);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x29F0D24", Offset = "0x29F0D24", VA = "0x29F0D24")]
	public static float ToFloat(float x, float y, float z)
	{
		return default(float);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x29F0F2C", Offset = "0x29F0F2C", VA = "0x29F0F2C")]
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
		[Address(RVA = "0x29F1074", Offset = "0x29F1074", VA = "0x29F1074")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public CanvasRenderer canvasRenderer
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x29F1098", Offset = "0x29F1098", VA = "0x29F1098")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public TMP_Text textMeshPro
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x29F10BC", Offset = "0x29F10BC", VA = "0x29F10BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x29F10E0", Offset = "0x29F10E0", VA = "0x29F10E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public virtual AdditionalCanvasShaderChannels requiredChannels
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x29F1104", Offset = "0x29F1104", VA = "0x29F1104", Slot = "19")]
		get
		{
			return default(AdditionalCanvasShaderChannels);
		}
	}

	[Token(Token = "0x17000006")]
	public bool isTMPro
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x29F110C", Offset = "0x29F110C", VA = "0x29F110C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public virtual Material material
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x29F1180", Offset = "0x29F1180", VA = "0x29F1180", Slot = "20")]
		get
		{
			return null;
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x29F1288", Offset = "0x29F1288", VA = "0x29F1288", Slot = "21")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public virtual Material[] materials
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x29F13A0", Offset = "0x29F13A0", VA = "0x29F13A0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	protected virtual bool isLegacyMeshModifier
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x29F1A24", Offset = "0x29F1A24", VA = "0x29F1A24", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x29F1534", Offset = "0x29F1534", VA = "0x29F1534", Slot = "23")]
	public virtual void ModifyMesh(Mesh mesh)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x29F1538", Offset = "0x29F1538", VA = "0x29F1538", Slot = "24")]
	public virtual void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x29F153C", Offset = "0x29F153C", VA = "0x29F153C", Slot = "25")]
	public virtual void SetVerticesDirty()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x29F1A20", Offset = "0x29F1A20", VA = "0x29F1A20")]
	public void ShowTMProWarning(Shader shader, Shader mobileShader, Shader spriteShader, Action<Material> onCreatedMaterial)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x29F1A2C", Offset = "0x29F1A2C", VA = "0x29F1A2C", Slot = "27")]
	protected virtual void Initialize()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x29F1B60", Offset = "0x29F1B60", VA = "0x29F1B60", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x29F1E88", Offset = "0x29F1E88", VA = "0x29F1E88", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x29F1F68", Offset = "0x29F1F68", VA = "0x29F1F68", Slot = "28")]
	protected virtual void LateUpdate()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x29F207C", Offset = "0x29F207C", VA = "0x29F207C", Slot = "13")]
	protected override void OnDidApplyAnimationProperties()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x29F208C", Offset = "0x29F208C", VA = "0x29F208C")]
	private void OnTextChanged(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x29F2800", Offset = "0x29F2800", VA = "0x29F2800")]
	private void FillVertexHelper(VertexHelper vh, Mesh mesh)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x29F2C10", Offset = "0x29F2C10", VA = "0x29F2C10")]
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
	[Address(RVA = "0x29F2FDC", Offset = "0x29F2FDC", VA = "0x29F2FDC")]
	public static Rect GetEffectArea(this EffectArea area, VertexHelper vh, Rect rectangle, float aspectRatio = -1f)
	{
		return default(Rect);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x29F31E8", Offset = "0x29F31E8", VA = "0x29F31E8")]
	public static void GetPositionFactor(this EffectArea area, int index, Rect rect, Vector2 position, bool isText, bool isTMPro, out float x, out float y)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x29F33A8", Offset = "0x29F33A8", VA = "0x29F33A8")]
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
		[Address(RVA = "0x29F36BC", Offset = "0x29F36BC", VA = "0x29F36BC", Slot = "19")]
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
		[Address(RVA = "0x29F36C4", Offset = "0x29F36C4", VA = "0x29F36C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x29F36CC", Offset = "0x29F36CC", VA = "0x29F36CC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public float effectFactor
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x29F3794", Offset = "0x29F3794", VA = "0x29F3794")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x29F379C", Offset = "0x29F379C", VA = "0x29F379C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public float width
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x29F3864", Offset = "0x29F3864", VA = "0x29F3864")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x29F386C", Offset = "0x29F386C", VA = "0x29F386C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public float softness
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x29F3934", Offset = "0x29F3934", VA = "0x29F3934")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x29F393C", Offset = "0x29F393C", VA = "0x29F393C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public Color color
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x29F3A04", Offset = "0x29F3A04", VA = "0x29F3A04")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x29F3A10", Offset = "0x29F3A10", VA = "0x29F3A10")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public Texture noiseTexture
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x29F3A70", Offset = "0x29F3A70", VA = "0x29F3A70")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x29F3AE8", Offset = "0x29F3AE8", VA = "0x29F3AE8")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public EffectArea effectArea
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x29F3BC8", Offset = "0x29F3BC8", VA = "0x29F3BC8")]
		get
		{
			return default(EffectArea);
		}
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x29F3BD0", Offset = "0x29F3BD0", VA = "0x29F3BD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public bool keepAspectRatio
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x29F3BF4", Offset = "0x29F3BF4", VA = "0x29F3BF4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x29F3BFC", Offset = "0x29F3BFC", VA = "0x29F3BFC")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public ColorMode colorMode
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x29F3C24", Offset = "0x29F3C24", VA = "0x29F3C24")]
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
		[Address(RVA = "0x29F3C2C", Offset = "0x29F3C2C", VA = "0x29F3C2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x29F3CC8", Offset = "0x29F3CC8", VA = "0x29F3CC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	[Obsolete]
	public bool loop
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x29F3CEC", Offset = "0x29F3CEC", VA = "0x29F3CEC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x29F3D08", Offset = "0x29F3D08", VA = "0x29F3D08")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public float duration
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x29F3D2C", Offset = "0x29F3D2C", VA = "0x29F3D2C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x29F3D48", Offset = "0x29F3D48", VA = "0x29F3D48")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	[Obsolete]
	public float loopDelay
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x29F3D7C", Offset = "0x29F3D7C", VA = "0x29F3D7C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x29F3D98", Offset = "0x29F3D98", VA = "0x29F3D98")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public AnimatorUpdateMode updateMode
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x29F3DC8", Offset = "0x29F3DC8", VA = "0x29F3DC8")]
		get
		{
			return default(AnimatorUpdateMode);
		}
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x29F3DE4", Offset = "0x29F3DE4", VA = "0x29F3DE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public override ParameterTexture ptex
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x29F3E04", Offset = "0x29F3E04", VA = "0x29F3E04", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public EffectPlayer _player
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x29F3C48", Offset = "0x29F3C48", VA = "0x29F3C48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x29F3E5C", Offset = "0x29F3E5C", VA = "0x29F3E5C", Slot = "33")]
	public override void ModifyMaterial()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x29F4430", Offset = "0x29F4430", VA = "0x29F4430", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x29F4890", Offset = "0x29F4890", VA = "0x29F4890", Slot = "34")]
	protected override void SetDirty()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x29F4BD0", Offset = "0x29F4BD0", VA = "0x29F4BD0")]
	public void Play()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x29F4C20", Offset = "0x29F4C20", VA = "0x29F4C20")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x29F4C50", Offset = "0x29F4C50", VA = "0x29F4C50", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x29F4FC8", Offset = "0x29F4FC8", VA = "0x29F4FC8", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x29F51B8", Offset = "0x29F51B8", VA = "0x29F51B8")]
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
		[Address(RVA = "0x29F55A0", Offset = "0x29F55A0", VA = "0x29F55A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x29F55A8", Offset = "0x29F55A8", VA = "0x29F55A8")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public bool vertical
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x29F55C0", Offset = "0x29F55C0", VA = "0x29F55C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x29F55C8", Offset = "0x29F55C8", VA = "0x29F55C8")]
		set
		{
		}
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x29F55E0", Offset = "0x29F55E0", VA = "0x29F55E0", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x29F571C", Offset = "0x29F571C", VA = "0x29F571C")]
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
		[Address(RVA = "0x29F6498", Offset = "0x29F6498", VA = "0x29F6498")]
		public Matrix2x3(Rect rect, float cos, float sin)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x29F659C", Offset = "0x29F659C", VA = "0x29F659C")]
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
		[Address(RVA = "0x29F5770", Offset = "0x29F5770", VA = "0x29F5770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001E")]
	public Direction direction
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x29F5794", Offset = "0x29F5794", VA = "0x29F5794")]
		get
		{
			return default(Direction);
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x29F579C", Offset = "0x29F579C", VA = "0x29F579C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public Color color1
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x29F57C0", Offset = "0x29F57C0", VA = "0x29F57C0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x29F57CC", Offset = "0x29F57CC", VA = "0x29F57CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public Color color2
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x29F582C", Offset = "0x29F582C", VA = "0x29F582C")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x29F5838", Offset = "0x29F5838", VA = "0x29F5838")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public Color color3
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x29F5898", Offset = "0x29F5898", VA = "0x29F5898")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x29F58A4", Offset = "0x29F58A4", VA = "0x29F58A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Color color4
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x29F5904", Offset = "0x29F5904", VA = "0x29F5904")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x29F5910", Offset = "0x29F5910", VA = "0x29F5910")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public float rotation
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x29F5970", Offset = "0x29F5970", VA = "0x29F5970")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x29F599C", Offset = "0x29F599C", VA = "0x29F599C")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public float offset
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x29F5A54", Offset = "0x29F5A54", VA = "0x29F5A54")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x29F5A5C", Offset = "0x29F5A5C", VA = "0x29F5A5C")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Vector2 offset2
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x29F5A80", Offset = "0x29F5A80", VA = "0x29F5A80")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x29F5A88", Offset = "0x29F5A88", VA = "0x29F5A88")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public GradientStyle gradientStyle
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x29F5AB8", Offset = "0x29F5AB8", VA = "0x29F5AB8")]
		get
		{
			return default(GradientStyle);
		}
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x29F5AC0", Offset = "0x29F5AC0", VA = "0x29F5AC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public ColorSpace colorSpace
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x29F5AE4", Offset = "0x29F5AE4", VA = "0x29F5AE4")]
		get
		{
			return default(ColorSpace);
		}
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x29F5AEC", Offset = "0x29F5AEC", VA = "0x29F5AEC")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public bool ignoreAspectRatio
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x29F5B10", Offset = "0x29F5B10", VA = "0x29F5B10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x29F5B18", Offset = "0x29F5B18", VA = "0x29F5B18")]
		set
		{
		}
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x29F5B40", Offset = "0x29F5B40", VA = "0x29F5B40", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x29F65CC", Offset = "0x29F65CC", VA = "0x29F65CC")]
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
		[Address(RVA = "0x29F7C24", Offset = "0x29F7C24", VA = "0x29F7C24")]
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
		[Address(RVA = "0x29F67BC", Offset = "0x29F67BC", VA = "0x29F67BC")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x29F67C8", Offset = "0x29F67C8", VA = "0x29F67C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public Vector2 effectDistance
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x29F68AC", Offset = "0x29F68AC", VA = "0x29F68AC")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x29F68B4", Offset = "0x29F68B4", VA = "0x29F68B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public bool useGraphicAlpha
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x29F69C8", Offset = "0x29F69C8", VA = "0x29F69C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x29F69D0", Offset = "0x29F69D0", VA = "0x29F69D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	[Obsolete("Use blurFactor instead (UnityUpgradable) -> blurFactor")]
	public float blur
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x29F6A98", Offset = "0x29F6A98", VA = "0x29F6A98")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x29F6AA0", Offset = "0x29F6AA0", VA = "0x29F6AA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public float blurFactor
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x29F6B6C", Offset = "0x29F6B6C", VA = "0x29F6B6C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x29F6B74", Offset = "0x29F6B74", VA = "0x29F6B74")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public ShadowStyle style
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x29F6B90", Offset = "0x29F6B90", VA = "0x29F6B90")]
		get
		{
			return default(ShadowStyle);
		}
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x29F6B98", Offset = "0x29F6B98", VA = "0x29F6B98")]
		set
		{
		}
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x29F6BA0", Offset = "0x29F6BA0", VA = "0x29F6BA0", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x29F6BA4", Offset = "0x29F6BA4", VA = "0x29F6BA4", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x29F6BA8", Offset = "0x29F6BA8", VA = "0x29F6BA8", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x29F703C", Offset = "0x29F703C", VA = "0x29F703C")]
	private void _ApplyShadow(List<UIVertex> verts, Color color, ref int start, ref int end, Vector2 effectDistance, ShadowStyle style, bool useGraphicAlpha)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x29F73E4", Offset = "0x29F73E4", VA = "0x29F73E4")]
	private void _ApplyShadowZeroAlloc(List<UIVertex> verts, Color color, ref int start, ref int end, float x, float y, bool useGraphicAlpha)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x29F6ABC", Offset = "0x29F6ABC", VA = "0x29F6ABC")]
	private void _SetDirty()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x29F7A58", Offset = "0x29F7A58", VA = "0x29F7A58")]
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
	[Address(RVA = "0x29F7C58", Offset = "0x29F7C58", VA = "0x29F7C58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x29F7CDC", Offset = "0x29F7CDC", VA = "0x29F7CDC")]
	public void SetTimeScale(float scale)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x29F7CE4", Offset = "0x29F7CE4", VA = "0x29F7CE4")]
	public void Open(Animator anim)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x29F8168", Offset = "0x29F8168", VA = "0x29F8168")]
	public void Close(Animator anim)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x29F81BC", Offset = "0x29F81BC", VA = "0x29F81BC")]
	public void Capture(Animator anim)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x29F8238", Offset = "0x29F8238", VA = "0x29F8238")]
	public void SetCanvasOverlay(bool isOverlay)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x29F82A4", Offset = "0x29F82A4", VA = "0x29F82A4")]
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
	[Address(RVA = "0x29F82AC", Offset = "0x29F82AC", VA = "0x29F82AC")]
	public void Open()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x29F82D0", Offset = "0x29F82D0", VA = "0x29F82D0")]
	public void Close()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x29F8324", Offset = "0x29F8324", VA = "0x29F8324")]
	public void Closed()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x29F8348", Offset = "0x29F8348", VA = "0x29F8348")]
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
	[Address(RVA = "0x29F4D74", Offset = "0x29F4D74", VA = "0x29F4D74")]
	public void OnEnable([Optional] Action<float> callback)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x29F50D4", Offset = "0x29F50D4", VA = "0x29F50D4")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x29F4C04", Offset = "0x29F4C04", VA = "0x29F4C04")]
	public void Play([Optional] Action<float> callback)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x29F4C48", Offset = "0x29F4C48", VA = "0x29F4C48")]
	public void Stop()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x29F8350", Offset = "0x29F8350", VA = "0x29F8350")]
	private void OnWillRenderCanvases()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x29F51A8", Offset = "0x29F51A8", VA = "0x29F51A8")]
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
		[Address(RVA = "0x29F8544", Offset = "0x29F8544", VA = "0x29F8544")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x29F854C", Offset = "0x29F854C", VA = "0x29F854C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public int referenceCount
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x29F8554", Offset = "0x29F8554", VA = "0x29F8554")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x29F855C", Offset = "0x29F855C", VA = "0x29F855C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public Texture texture
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x29F8564", Offset = "0x29F8564", VA = "0x29F8564")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x29F856C", Offset = "0x29F856C", VA = "0x29F856C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public Material material
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x29F8574", Offset = "0x29F8574", VA = "0x29F8574")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x29F857C", Offset = "0x29F857C", VA = "0x29F857C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x29F4184", Offset = "0x29F4184", VA = "0x29F4184")]
	public static MaterialCache Register(ulong hash, Texture texture, Func<Material> onCreateMaterial)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x29F8594", Offset = "0x29F8594", VA = "0x29F8594")]
	public static MaterialCache Register(ulong hash, Func<Material> onCreateMaterial)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x29F40D0", Offset = "0x29F40D0", VA = "0x29F40D0")]
	public static void Unregister(MaterialCache cache)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x29F858C", Offset = "0x29F858C", VA = "0x29F858C")]
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
	[Address(RVA = "0x29F888C", Offset = "0x29F888C", VA = "0x29F888C")]
	public Matrix2x3(Rect rect, float cos, float sin)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x29F34D8", Offset = "0x29F34D8", VA = "0x29F34D8")]
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
	[Address(RVA = "0x29F532C", Offset = "0x29F532C", VA = "0x29F532C")]
	public ParameterTexture(int channels, int instanceLimit, string propertyName)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x29F8990", Offset = "0x29F8990", VA = "0x29F8990")]
	public void Register(IParameterTexture target)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x29F8E0C", Offset = "0x29F8E0C", VA = "0x29F8E0C")]
	public void Unregister(IParameterTexture target)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x29F8FA4", Offset = "0x29F8FA4", VA = "0x29F8FA4")]
	public void SetData(IParameterTexture target, int channelId, byte value)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x29F4BA0", Offset = "0x29F4BA0", VA = "0x29F4BA0")]
	public void SetData(IParameterTexture target, int channelId, float value)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x29F4B00", Offset = "0x29F4B00", VA = "0x29F4B00")]
	public void RegisterMaterial(Material mat)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x29F47D4", Offset = "0x29F47D4", VA = "0x29F47D4")]
	public float GetNormalizedIndex(IParameterTexture target)
	{
		return default(float);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x29F8AEC", Offset = "0x29F8AEC", VA = "0x29F8AEC")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x29F9104", Offset = "0x29F9104", VA = "0x29F9104")]
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
		[Address(RVA = "0x29F92EC", Offset = "0x29F92EC", VA = "0x29F92EC", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x29F92F4", Offset = "0x29F92F4", VA = "0x29F92F4", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public virtual ParameterTexture ptex
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x29F92FC", Offset = "0x29F92FC", VA = "0x29F92FC", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000037")]
	public Graphic targetGraphic
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x29F9304", Offset = "0x29F9304", VA = "0x29F9304")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000038")]
	public Material effectMaterial
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x29F9328", Offset = "0x29F9328", VA = "0x29F9328")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x29F9330", Offset = "0x29F9330", VA = "0x29F9330", Slot = "33")]
	public virtual void ModifyMaterial()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x29F4CEC", Offset = "0x29F4CEC", VA = "0x29F4CEC", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x29F5058", Offset = "0x29F5058", VA = "0x29F5058", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x29F938C", Offset = "0x29F938C", VA = "0x29F938C", Slot = "34")]
	protected virtual void SetDirty()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x29F939C", Offset = "0x29F939C", VA = "0x29F939C", Slot = "13")]
	protected override void OnDidApplyAnimationProperties()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x29F5238", Offset = "0x29F5238", VA = "0x29F5238")]
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
		[Address(RVA = "0x29F9578", Offset = "0x29F9578", VA = "0x29F9578")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x29F9580", Offset = "0x29F9580", VA = "0x29F9580")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public float effectFactor
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x29F95A8", Offset = "0x29F95A8", VA = "0x29F95A8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x29F95B0", Offset = "0x29F95B0", VA = "0x29F95B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public float colorFactor
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x29F95D8", Offset = "0x29F95D8", VA = "0x29F95D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x29F95E0", Offset = "0x29F95E0", VA = "0x29F95E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	[Obsolete("Use blurFactor instead (UnityUpgradable) -> blurFactor")]
	public float blur
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x29F9608", Offset = "0x29F9608", VA = "0x29F9608")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x29F9610", Offset = "0x29F9610", VA = "0x29F9610")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	[Obsolete("Use effectFactor instead (UnityUpgradable) -> effectFactor")]
	public float blurFactor
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x29F9638", Offset = "0x29F9638", VA = "0x29F9638")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x29F9640", Offset = "0x29F9640", VA = "0x29F9640")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	[Obsolete("Use effectMode instead (UnityUpgradable) -> effectMode")]
	public EffectMode toneMode
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x29F9668", Offset = "0x29F9668", VA = "0x29F9668")]
		get
		{
			return default(EffectMode);
		}
	}

	[Token(Token = "0x1700003F")]
	public EffectMode effectMode
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x29F9670", Offset = "0x29F9670", VA = "0x29F9670")]
		get
		{
			return default(EffectMode);
		}
	}

	[Token(Token = "0x17000040")]
	public ColorMode colorMode
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x29F9678", Offset = "0x29F9678", VA = "0x29F9678")]
		get
		{
			return default(ColorMode);
		}
	}

	[Token(Token = "0x17000041")]
	public BlurMode blurMode
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x29F9680", Offset = "0x29F9680", VA = "0x29F9680")]
		get
		{
			return default(BlurMode);
		}
	}

	[Token(Token = "0x17000042")]
	public Color effectColor
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x29F9688", Offset = "0x29F9688", VA = "0x29F9688")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x29F96C0", Offset = "0x29F96C0", VA = "0x29F96C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public override ParameterTexture ptex
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x29F973C", Offset = "0x29F973C", VA = "0x29F973C", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x29F9794", Offset = "0x29F9794", VA = "0x29F9794", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x29FA0C8", Offset = "0x29FA0C8", VA = "0x29FA0C8", Slot = "34")]
	protected override void SetDirty()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x29F9EE8", Offset = "0x29F9EE8", VA = "0x29F9EE8")]
	private static void GetBounds(List<UIVertex> verts, int start, int count, ref Rect posBounds, ref Rect uvBounds, bool global)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x29FA1EC", Offset = "0x29FA1EC", VA = "0x29FA1EC")]
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
			[Address(RVA = "0x29FB3E0", Offset = "0x29FB3E0", VA = "0x29FB3E0", Slot = "4")]
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
			[Address(RVA = "0x29FB428", Offset = "0x29FB428", VA = "0x29FB428", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x29FB2C8", Offset = "0x29FB2C8", VA = "0x29FB2C8")]
		[DebuggerHidden]
		public <_CoUpdateTextureOnNextFrame>d__95(int <>1__state)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x29FB334", Offset = "0x29FB334", VA = "0x29FB334", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x29FB338", Offset = "0x29FB338", VA = "0x29FB338", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x29FB3E8", Offset = "0x29FB3E8", VA = "0x29FB3E8", Slot = "8")]
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
		[Address(RVA = "0x29FA370", Offset = "0x29FA370", VA = "0x29FA370")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x29FA378", Offset = "0x29FA378", VA = "0x29FA378")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public float effectFactor
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x29FA394", Offset = "0x29FA394", VA = "0x29FA394")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x29FA39C", Offset = "0x29FA39C", VA = "0x29FA39C")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public float colorFactor
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x29FA3B8", Offset = "0x29FA3B8", VA = "0x29FA3B8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x29FA3C0", Offset = "0x29FA3C0", VA = "0x29FA3C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	[Obsolete("Use blurFactor instead (UnityUpgradable) -> blurFactor")]
	public float blur
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x29FA3DC", Offset = "0x29FA3DC", VA = "0x29FA3DC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x29FA3E4", Offset = "0x29FA3E4", VA = "0x29FA3E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public float blurFactor
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x29FA400", Offset = "0x29FA400", VA = "0x29FA400")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x29FA408", Offset = "0x29FA408", VA = "0x29FA408")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	[Obsolete("Use effectMode instead (UnityUpgradable) -> effectMode")]
	public EffectMode toneMode
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x29FA424", Offset = "0x29FA424", VA = "0x29FA424")]
		get
		{
			return default(EffectMode);
		}
	}

	[Token(Token = "0x1700004A")]
	public EffectMode effectMode
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x29FA42C", Offset = "0x29FA42C", VA = "0x29FA42C")]
		get
		{
			return default(EffectMode);
		}
	}

	[Token(Token = "0x1700004B")]
	public ColorMode colorMode
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x29FA434", Offset = "0x29FA434", VA = "0x29FA434")]
		get
		{
			return default(ColorMode);
		}
	}

	[Token(Token = "0x1700004C")]
	public BlurMode blurMode
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x29FA43C", Offset = "0x29FA43C", VA = "0x29FA43C")]
		get
		{
			return default(BlurMode);
		}
	}

	[Token(Token = "0x1700004D")]
	public Color effectColor
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x29FA444", Offset = "0x29FA444", VA = "0x29FA444")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x29FA458", Offset = "0x29FA458", VA = "0x29FA458")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public virtual Material effectMaterial
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x29FA46C", Offset = "0x29FA46C", VA = "0x29FA46C", Slot = "65")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004F")]
	public DesamplingRate desamplingRate
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x29FA474", Offset = "0x29FA474", VA = "0x29FA474")]
		get
		{
			return default(DesamplingRate);
		}
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x29FA47C", Offset = "0x29FA47C", VA = "0x29FA47C")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public DesamplingRate reductionRate
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x29FA484", Offset = "0x29FA484", VA = "0x29FA484")]
		get
		{
			return default(DesamplingRate);
		}
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x29FA48C", Offset = "0x29FA48C", VA = "0x29FA48C")]
		set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public FilterMode filterMode
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x29FA494", Offset = "0x29FA494", VA = "0x29FA494")]
		get
		{
			return default(FilterMode);
		}
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x29FA49C", Offset = "0x29FA49C", VA = "0x29FA49C")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public RenderTexture capturedTexture
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x29FA4A4", Offset = "0x29FA4A4", VA = "0x29FA4A4")]
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
		[Address(RVA = "0x29FA4AC", Offset = "0x29FA4AC", VA = "0x29FA4AC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x29FA4B4", Offset = "0x29FA4B4", VA = "0x29FA4B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public int blurIterations
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x29FA4BC", Offset = "0x29FA4BC", VA = "0x29FA4BC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x29FA4C4", Offset = "0x29FA4C4", VA = "0x29FA4C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	[Obsolete("Use fitToScreen instead (UnityUpgradable) -> fitToScreen")]
	public bool keepCanvasSize
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x29FA4CC", Offset = "0x29FA4CC", VA = "0x29FA4CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x29FA4D4", Offset = "0x29FA4D4", VA = "0x29FA4D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	public bool fitToScreen
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x29FA4E0", Offset = "0x29FA4E0", VA = "0x29FA4E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x29FA4E8", Offset = "0x29FA4E8", VA = "0x29FA4E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	[Obsolete]
	public RenderTexture targetTexture
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x29FA4F4", Offset = "0x29FA4F4", VA = "0x29FA4F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x29FA4FC", Offset = "0x29FA4FC", VA = "0x29FA4FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public bool captureOnEnable
	{
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x29FA500", Offset = "0x29FA500", VA = "0x29FA500")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x29FA508", Offset = "0x29FA508", VA = "0x29FA508")]
		set
		{
		}
	}

	[Token(Token = "0x17000059")]
	public bool immediateCapturing
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x29FA514", Offset = "0x29FA514", VA = "0x29FA514")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x29FA51C", Offset = "0x29FA51C", VA = "0x29FA51C")]
		set
		{
		}
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x29FA528", Offset = "0x29FA528", VA = "0x29FA528", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x29FA560", Offset = "0x29FA560", VA = "0x29FA560", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x29FA660", Offset = "0x29FA660", VA = "0x29FA660", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x29FA6B4", Offset = "0x29FA6B4", VA = "0x29FA6B4", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x29FAA08", Offset = "0x29FAA08", VA = "0x29FAA08")]
	public void GetDesamplingSize(DesamplingRate rate, out int w, out int h)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x29F7D7C", Offset = "0x29F7D7C", VA = "0x29F7D7C")]
	public void Capture()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x29FABDC", Offset = "0x29FABDC", VA = "0x29FABDC")]
	private void SetupCommandBuffer()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x29FA690", Offset = "0x29FA690", VA = "0x29FA690")]
	public void Release()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x29FA5AC", Offset = "0x29FA5AC", VA = "0x29FA5AC")]
	private void _Release(bool releaseRT)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x29FB2C4", Offset = "0x29FB2C4", VA = "0x29FB2C4")]
	[Conditional("UNITY_EDITOR")]
	private void _SetDirty()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x29FAB2C", Offset = "0x29FAB2C", VA = "0x29FAB2C")]
	private void _Release(ref RenderTexture obj)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x29FB250", Offset = "0x29FB250", VA = "0x29FB250")]
	[IteratorStateMachine(typeof(<_CoUpdateTextureOnNextFrame>d__95))]
	private IEnumerator _CoUpdateTextureOnNextFrame()
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x29FB1B4", Offset = "0x29FB1B4", VA = "0x29FB1B4")]
	private void UpdateTexture()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x29FB2F0", Offset = "0x29FB2F0", VA = "0x29FB2F0")]
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
		[Address(RVA = "0x29FB430", Offset = "0x29FB430", VA = "0x29FB430")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x29FB43C", Offset = "0x29FB43C", VA = "0x29FB43C")]
		set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public float range
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x29FB49C", Offset = "0x29FB49C", VA = "0x29FB49C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x29FB4A4", Offset = "0x29FB4A4", VA = "0x29FB4A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700005E")]
	public float saturation
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x29FB56C", Offset = "0x29FB56C", VA = "0x29FB56C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x29FB574", Offset = "0x29FB574", VA = "0x29FB574")]
		set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public float value
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x29FB63C", Offset = "0x29FB63C", VA = "0x29FB63C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x29FB644", Offset = "0x29FB644", VA = "0x29FB644")]
		set
		{
		}
	}

	[Token(Token = "0x17000060")]
	public float hue
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x29FB70C", Offset = "0x29FB70C", VA = "0x29FB70C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x29FB714", Offset = "0x29FB714", VA = "0x29FB714")]
		set
		{
		}
	}

	[Token(Token = "0x17000061")]
	public override ParameterTexture ptex
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x29FB7DC", Offset = "0x29FB7DC", VA = "0x29FB7DC", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x29FB834", Offset = "0x29FB834", VA = "0x29FB834", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x29FB93C", Offset = "0x29FB93C", VA = "0x29FB93C", Slot = "34")]
	protected override void SetDirty()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x29FBC20", Offset = "0x29FBC20", VA = "0x29FBC20")]
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
		[Address(RVA = "0x29FBD2C", Offset = "0x29FBD2C", VA = "0x29FBD2C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x29FBD34", Offset = "0x29FBD34", VA = "0x29FBD34")]
		set
		{
		}
	}

	[Token(Token = "0x17000063")]
	public float effectFactor
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x29FBDFC", Offset = "0x29FBDFC", VA = "0x29FBDFC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x29FBE04", Offset = "0x29FBE04", VA = "0x29FBE04")]
		set
		{
		}
	}

	[Token(Token = "0x17000064")]
	public float width
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x29FBECC", Offset = "0x29FBECC", VA = "0x29FBECC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x29FBED4", Offset = "0x29FBED4", VA = "0x29FBED4")]
		set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public float softness
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x29FBF9C", Offset = "0x29FBF9C", VA = "0x29FBF9C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x29FBFA4", Offset = "0x29FBFA4", VA = "0x29FBFA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000066")]
	[Obsolete("Use brightness instead (UnityUpgradable) -> brightness")]
	public float alpha
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x29FC070", Offset = "0x29FC070", VA = "0x29FC070")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x29FC078", Offset = "0x29FC078", VA = "0x29FC078")]
		set
		{
		}
	}

	[Token(Token = "0x17000067")]
	public float brightness
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x29FC140", Offset = "0x29FC140", VA = "0x29FC140")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x29FC148", Offset = "0x29FC148", VA = "0x29FC148")]
		set
		{
		}
	}

	[Token(Token = "0x17000068")]
	[Obsolete("Use gloss instead (UnityUpgradable) -> gloss")]
	public float highlight
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x29FC210", Offset = "0x29FC210", VA = "0x29FC210")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x29FC218", Offset = "0x29FC218", VA = "0x29FC218")]
		set
		{
		}
	}

	[Token(Token = "0x17000069")]
	public float gloss
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x29FC2E0", Offset = "0x29FC2E0", VA = "0x29FC2E0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x29FC2E8", Offset = "0x29FC2E8", VA = "0x29FC2E8")]
		set
		{
		}
	}

	[Token(Token = "0x1700006A")]
	public float rotation
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x29FC3B0", Offset = "0x29FC3B0", VA = "0x29FC3B0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x29FC3B8", Offset = "0x29FC3B8", VA = "0x29FC3B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700006B")]
	public EffectArea effectArea
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x29FC470", Offset = "0x29FC470", VA = "0x29FC470")]
		get
		{
			return default(EffectArea);
		}
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x29FC478", Offset = "0x29FC478", VA = "0x29FC478")]
		set
		{
		}
	}

	[Token(Token = "0x1700006C")]
	public bool play
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x29FC49C", Offset = "0x29FC49C", VA = "0x29FC49C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x29FC538", Offset = "0x29FC538", VA = "0x29FC538")]
		set
		{
		}
	}

	[Token(Token = "0x1700006D")]
	public bool loop
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x29FC55C", Offset = "0x29FC55C", VA = "0x29FC55C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x29FC578", Offset = "0x29FC578", VA = "0x29FC578")]
		set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public float duration
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x29FC59C", Offset = "0x29FC59C", VA = "0x29FC59C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x29FC5B8", Offset = "0x29FC5B8", VA = "0x29FC5B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	public float loopDelay
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x29FC5EC", Offset = "0x29FC5EC", VA = "0x29FC5EC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x29FC608", Offset = "0x29FC608", VA = "0x29FC608")]
		set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public AnimatorUpdateMode updateMode
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x29FC638", Offset = "0x29FC638", VA = "0x29FC638")]
		get
		{
			return default(AnimatorUpdateMode);
		}
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x29FC654", Offset = "0x29FC654", VA = "0x29FC654")]
		set
		{
		}
	}

	[Token(Token = "0x17000071")]
	public override ParameterTexture ptex
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x29FC674", Offset = "0x29FC674", VA = "0x29FC674", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000072")]
	private EffectPlayer _player
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x29FC4B8", Offset = "0x29FC4B8", VA = "0x29FC4B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x29FC6CC", Offset = "0x29FC6CC", VA = "0x29FC6CC", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x29FC768", Offset = "0x29FC768", VA = "0x29FC768", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x29FC78C", Offset = "0x29FC78C", VA = "0x29FC78C", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x29FCB50", Offset = "0x29FCB50", VA = "0x29FCB50")]
	public void Play()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x29FCB74", Offset = "0x29FCB74", VA = "0x29FCB74")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x29FCB90", Offset = "0x29FCB90", VA = "0x29FCB90", Slot = "34")]
	protected override void SetDirty()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x29FCEA8", Offset = "0x29FCEA8", VA = "0x29FCEA8")]
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
		[Address(RVA = "0x29FCFBC", Offset = "0x29FCFBC", VA = "0x29FCFBC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x29FCFC4", Offset = "0x29FCFC4", VA = "0x29FCFC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public Texture transitionTexture
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x29FD08C", Offset = "0x29FD08C", VA = "0x29FD08C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x29FD094", Offset = "0x29FD094", VA = "0x29FD094")]
		set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public EffectMode effectMode
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x29FD174", Offset = "0x29FD174", VA = "0x29FD174")]
		get
		{
			return default(EffectMode);
		}
	}

	[Token(Token = "0x17000076")]
	public bool keepAspectRatio
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x29FD17C", Offset = "0x29FD17C", VA = "0x29FD17C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x29FD184", Offset = "0x29FD184", VA = "0x29FD184")]
		set
		{
		}
	}

	[Token(Token = "0x17000077")]
	public override ParameterTexture ptex
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x29FD1D8", Offset = "0x29FD1D8", VA = "0x29FD1D8", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000078")]
	public float dissolveWidth
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x29FD230", Offset = "0x29FD230", VA = "0x29FD230")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x29FD238", Offset = "0x29FD238", VA = "0x29FD238")]
		set
		{
		}
	}

	[Token(Token = "0x17000079")]
	public float dissolveSoftness
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x29FD300", Offset = "0x29FD300", VA = "0x29FD300")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x29FD308", Offset = "0x29FD308", VA = "0x29FD308")]
		set
		{
		}
	}

	[Token(Token = "0x1700007A")]
	public Color dissolveColor
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x29FD3D0", Offset = "0x29FD3D0", VA = "0x29FD3D0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x29FD3DC", Offset = "0x29FD3DC", VA = "0x29FD3DC")]
		set
		{
		}
	}

	[Token(Token = "0x1700007B")]
	public float duration
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x29FD43C", Offset = "0x29FD43C", VA = "0x29FD43C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x29FD4D8", Offset = "0x29FD4D8", VA = "0x29FD4D8")]
		set
		{
		}
	}

	[Token(Token = "0x1700007C")]
	public bool passRayOnHidden
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x29FD50C", Offset = "0x29FD50C", VA = "0x29FD50C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x29FD514", Offset = "0x29FD514", VA = "0x29FD514")]
		set
		{
		}
	}

	[Token(Token = "0x1700007D")]
	public AnimatorUpdateMode updateMode
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x29FD520", Offset = "0x29FD520", VA = "0x29FD520")]
		get
		{
			return default(AnimatorUpdateMode);
		}
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x29FD53C", Offset = "0x29FD53C", VA = "0x29FD53C")]
		set
		{
		}
	}

	[Token(Token = "0x1700007E")]
	private EffectPlayer _player
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x29FD458", Offset = "0x29FD458", VA = "0x29FD458")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x29FD55C", Offset = "0x29FD55C", VA = "0x29FD55C")]
	public void Show()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x29FD610", Offset = "0x29FD610", VA = "0x29FD610")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x29FD6C4", Offset = "0x29FD6C4", VA = "0x29FD6C4", Slot = "33")]
	public override void ModifyMaterial()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x29FD95C", Offset = "0x29FD95C", VA = "0x29FD95C", Slot = "24")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x29FDC9C", Offset = "0x29FDC9C", VA = "0x29FDC9C", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x29FDCD8", Offset = "0x29FDCD8", VA = "0x29FDCD8", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x29FDD68", Offset = "0x29FDD68", VA = "0x29FDD68", Slot = "34")]
	protected override void SetDirty()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x29FE010", Offset = "0x29FE010", VA = "0x29FE010")]
	public UITransitionEffect()
	{
	}
}
