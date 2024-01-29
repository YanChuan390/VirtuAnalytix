using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class StreamingVideoTexture : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000007")]
	public class FrameTextureInfo
	{
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF3640C", Offset = "0xF3640C")]
		public string PathToFirstFrame;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x18")]
		public string ShaderProperty;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Texture2D CurrentTexture;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Dictionary<int, string> CachedFrameNames;

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x2B5CC34", Offset = "0x2B5CC34", VA = "0x2B5CC34")]
		public FrameTextureInfo()
		{
		}
	}

	[Token(Token = "0x2000008")]
	public class uScriptEventArgs : EventArgs
	{
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x10")]
		public StreamingVideoTexture _Video;

		[Token(Token = "0x17000001")]
		public StreamingVideoTexture Video
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x2B5CCB4", Offset = "0x2B5CCB4", VA = "0x2B5CCB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x2B5BA90", Offset = "0x2B5BA90", VA = "0x2B5BA90")]
		public uScriptEventArgs(StreamingVideoTexture name)
		{
		}
	}

	[Token(Token = "0x2000009")]
	public delegate void EventDelegate(object sender, uScriptEventArgs args);

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public Animation DrivenAnimation;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF3632C", Offset = "0xF3632C")]
	public int MaterialIndex;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	public FrameTextureInfo[] IntroFrameTextureInfos;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x38")]
	public FrameTextureInfo[] FrameTextureInfos;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x40")]
	public Material CachedMaterial;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF36364", Offset = "0xF36364")]
	public bool Intro;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x4C")]
	public int IntroSheets;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	public int IntroSheetFrameOffset;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF3639C", Offset = "0xF3639C")]
	public int NumSheets;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x58")]
	public int FramesHorizontal;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x5C")]
	public int FramesVertical;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x60")]
	public float FPS;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x64")]
	public bool PlayAutomatically;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x65")]
	public bool Loop;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x66")]
	public bool PreloadTexturesOnAwake;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x67")]
	public bool PreloadFirstTexture;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x68")]
	public float YTilingMult;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x6C")]
	public float XTilingTweak;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x70")]
	public float XOffsetTweak;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xF363D4", Offset = "0xF363D4")]
	public bool Billboard;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x78")]
	public float BillboardPositionOffset;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x7C")]
	public bool FlattenBillboard;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x80")]
	public FPMath.Axis RotationAxisToFlatten;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x84")]
	public FPMath.Axis PositionAxisToFlatten;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x88")]
	public bool CacheTextures;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x8C")]
	private float UVStrideHorizontal;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x90")]
	private float UVStrideVertical;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x94")]
	private float TimeStarted;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x98")]
	private int CurrentSheet;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x9C")]
	private bool IntroDone;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 InitialPos;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0xB0")]
	private Renderer VideoRenderer;

	[Token(Token = "0x14000001")]
	public event EventDelegate OnVideoFinished
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2B5AB88", Offset = "0x2B5AB88", VA = "0x2B5AB88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF36464", Offset = "0xF36464")]
		add
		{
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2B5AC2C", Offset = "0x2B5AC2C", VA = "0x2B5AC2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF36474", Offset = "0xF36474")]
		remove
		{
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2B5ACD0", Offset = "0x2B5ACD0", VA = "0x2B5ACD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2B5AFE8", Offset = "0x2B5AFE8", VA = "0x2B5AFE8")]
	private string RemoveExtension(string path)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2B5B0B4", Offset = "0x2B5B0B4", VA = "0x2B5B0B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2B5B278", Offset = "0x2B5B278", VA = "0x2B5B278")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2B5B428", Offset = "0x2B5B428", VA = "0x2B5B428")]
	private void CheckVisibility(bool visibility)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2B5B23C", Offset = "0x2B5B23C", VA = "0x2B5B23C")]
	public void Play()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2B5B504", Offset = "0x2B5B504", VA = "0x2B5B504")]
	public void Play(bool skipIntro)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2B5B478", Offset = "0x2B5B478", VA = "0x2B5B478")]
	public void Stop()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2B5B6F8", Offset = "0x2B5B6F8", VA = "0x2B5B6F8")]
	public void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2B5C108", Offset = "0x2B5C108", VA = "0x2B5C108")]
	protected void OnWillRenderObject()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2B5C46C", Offset = "0x2B5C46C", VA = "0x2B5C46C")]
	private string GetPathToFrame(int frame, FrameTextureInfo info)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2B5B354", Offset = "0x2B5B354", VA = "0x2B5B354")]
	private void ChangeTexture(string newPath, ref FrameTextureInfo frameTextureInfo)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2B5B548", Offset = "0x2B5B548", VA = "0x2B5B548")]
	private void ChangeTexture(Texture2D texture, ref FrameTextureInfo frameTextureInfo)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2B5AF60", Offset = "0x2B5AF60", VA = "0x2B5AF60")]
	private void PreloadFirstTextures(FrameTextureInfo[] textureInfos)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2B5BF88", Offset = "0x2B5BF88", VA = "0x2B5BF88")]
	private void ChangeAllTextures(FrameTextureInfo[] textureInfos, int nextSheet)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2B5BEF4", Offset = "0x2B5BEF4", VA = "0x2B5BEF4")]
	private void ChangeAllTextures(FrameTextureInfo[] textureInfos, Texture2D newTex)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2B5C024", Offset = "0x2B5C024", VA = "0x2B5C024")]
	private void ApplyTextureOffset(FrameTextureInfo[] textureInfos, Vector2 uvOffset)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2B5C880", Offset = "0x2B5C880", VA = "0x2B5C880")]
	public void EnableTextureCaching()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2B5C88C", Offset = "0x2B5C88C", VA = "0x2B5C88C")]
	public void DisableTextureCaching()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2B5ADD4", Offset = "0x2B5ADD4", VA = "0x2B5ADD4")]
	public void PreloadTextures()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2B5CA40", Offset = "0x2B5CA40", VA = "0x2B5CA40")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2B5CA48", Offset = "0x2B5CA48", VA = "0x2B5CA48")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2B5CB1C", Offset = "0x2B5CB1C", VA = "0x2B5CB1C")]
	public void SetIntroDone(bool done)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2B5CB28", Offset = "0x2B5CB28", VA = "0x2B5CB28")]
	public StreamingVideoTexture()
	{
	}
}
[Token(Token = "0x2000003")]
public static class StreamingVideoTextureCache
{
	[Token(Token = "0x200000A")]
	private class TextureReference
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x10")]
		public Texture2D Texture;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x18")]
		public List<MonoBehaviour> BehavioursUsingTexture;

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x2B5CCBC", Offset = "0x2B5CCBC", VA = "0x2B5CCBC")]
		public TextureReference()
		{
		}
	}

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, TextureReference> References;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2B5C55C", Offset = "0x2B5C55C", VA = "0x2B5C55C")]
	public static Texture2D LoadTexture(string path, MonoBehaviour behaviour)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2B5C900", Offset = "0x2B5C900", VA = "0x2B5C900")]
	public static void UnloadAllTextures(MonoBehaviour behaviour)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2B5C74C", Offset = "0x2B5C74C", VA = "0x2B5C74C")]
	public static void UnloadTexture(string path, MonoBehaviour behaviour)
	{
	}
}
[Token(Token = "0x2000004")]
public class Options_screen : MonoBehaviour
{
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2B5AB78", Offset = "0x2B5AB78", VA = "0x2B5AB78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2B5AB7C", Offset = "0x2B5AB7C", VA = "0x2B5AB7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2B5AB80", Offset = "0x2B5AB80", VA = "0x2B5AB80")]
	public Options_screen()
	{
	}
}
namespace Ludiq.Generated.PropertyProviders
{
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "SerializedPropertyProviderAttribute", RVA = "0xF362A8", Offset = "0xF362A8")]
	public class PropertyProvider_GrabbableHandAnchor_Pose : SerializedPropertyProvider<GrabbableHandAnchor.Pose>
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2B5AB28", Offset = "0x2B5AB28", VA = "0x2B5AB28")]
		public PropertyProvider_GrabbableHandAnchor_Pose()
		{
		}
	}
}
namespace Ludiq.Generated.Aot
{
	[Token(Token = "0x2000006")]
	[Preserve]
	public class AotStubs
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1168170", Offset = "0x1168170", VA = "0x1168170")]
		[Preserve]
		public static void Achievement_op_Equality()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1168240", Offset = "0x1168240", VA = "0x1168240")]
		[Preserve]
		public static void Achievement_op_Implicit()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1168308", Offset = "0x1168308", VA = "0x1168308")]
		[Preserve]
		public static void Achievement_op_Inequality()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x11683D8", Offset = "0x11683D8", VA = "0x11683D8")]
		[Preserve]
		public static void ActivateObjectsSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x11684A8", Offset = "0x11684A8", VA = "0x11684A8")]
		[Preserve]
		public static void ActivateObjectsSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1168570", Offset = "0x1168570", VA = "0x1168570")]
		[Preserve]
		public static void ActivateObjectsSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1168640", Offset = "0x1168640", VA = "0x1168640")]
		[Preserve]
		public static void AlignParticles_op_Equality()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1168710", Offset = "0x1168710", VA = "0x1168710")]
		[Preserve]
		public static void AlignParticles_op_Implicit()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x11687D8", Offset = "0x11687D8", VA = "0x11687D8")]
		[Preserve]
		public static void AlignParticles_op_Inequality()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x11688A8", Offset = "0x11688A8", VA = "0x11688A8")]
		[Preserve]
		public static void AmbiencePlayer_op_Equality()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1168978", Offset = "0x1168978", VA = "0x1168978")]
		[Preserve]
		public static void AmbiencePlayer_op_Implicit()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1168A40", Offset = "0x1168A40", VA = "0x1168A40")]
		[Preserve]
		public static void AmbiencePlayer_op_Inequality()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1168B10", Offset = "0x1168B10", VA = "0x1168B10")]
		[Preserve]
		public static void AnimateAllMaterialProperties_op_Equality()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1168BE0", Offset = "0x1168BE0", VA = "0x1168BE0")]
		[Preserve]
		public static void AnimateAllMaterialProperties_op_Implicit()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1168CA8", Offset = "0x1168CA8", VA = "0x1168CA8")]
		[Preserve]
		public static void AnimateAllMaterialProperties_op_Inequality()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1168D78", Offset = "0x1168D78", VA = "0x1168D78")]
		[Preserve]
		public static void AnimatedUVScroller_op_Equality()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1168E48", Offset = "0x1168E48", VA = "0x1168E48")]
		[Preserve]
		public static void AnimatedUVScroller_op_Implicit()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1168F10", Offset = "0x1168F10", VA = "0x1168F10")]
		[Preserve]
		public static void AnimatedUVScroller_op_Inequality()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1168FE0", Offset = "0x1168FE0", VA = "0x1168FE0")]
		[Preserve]
		public static void AnimateMaterialPropertiesMultiplier_op_Equality()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x11690B0", Offset = "0x11690B0", VA = "0x11690B0")]
		[Preserve]
		public static void AnimateMaterialPropertiesMultiplier_op_Implicit()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1169178", Offset = "0x1169178", VA = "0x1169178")]
		[Preserve]
		public static void AnimateMaterialPropertiesMultiplier_op_Inequality()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1169248", Offset = "0x1169248", VA = "0x1169248")]
		[Preserve]
		public static void AnimateMaterialProperty_1_op_Equality()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1169318", Offset = "0x1169318", VA = "0x1169318")]
		[Preserve]
		public static void AnimateMaterialProperty_1_op_Implicit()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x11693E0", Offset = "0x11693E0", VA = "0x11693E0")]
		[Preserve]
		public static void AnimateMaterialProperty_1_op_Inequality()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x11694B0", Offset = "0x11694B0", VA = "0x11694B0")]
		[Preserve]
		public static void AnimateMaterialProperty_1_ScaleValue()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x11694E4", Offset = "0x11694E4", VA = "0x11694E4")]
		[Preserve]
		public static void AnimateMaterialProperty_2_ColorValue()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1169518", Offset = "0x1169518", VA = "0x1169518")]
		[Preserve]
		public static void AnimateMaterialProperty_2_op_Equality()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x11695E8", Offset = "0x11695E8", VA = "0x11695E8")]
		[Preserve]
		public static void AnimateMaterialProperty_2_op_Implicit()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x11696B0", Offset = "0x11696B0", VA = "0x11696B0")]
		[Preserve]
		public static void AnimateMaterialProperty_2_op_Inequality()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1169780", Offset = "0x1169780", VA = "0x1169780")]
		[Preserve]
		public static void AnimateMaterialProperty_3_op_Equality()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1169850", Offset = "0x1169850", VA = "0x1169850")]
		[Preserve]
		public static void AnimateMaterialProperty_3_op_Implicit()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1169918", Offset = "0x1169918", VA = "0x1169918")]
		[Preserve]
		public static void AnimateMaterialProperty_3_op_Inequality()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x11699E8", Offset = "0x11699E8", VA = "0x11699E8")]
		[Preserve]
		public static void AnimateMaterialProperty_4_op_Equality()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1169AB8", Offset = "0x1169AB8", VA = "0x1169AB8")]
		[Preserve]
		public static void AnimateMaterialProperty_4_op_Implicit()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1169B80", Offset = "0x1169B80", VA = "0x1169B80")]
		[Preserve]
		public static void AnimateMaterialProperty_4_op_Inequality()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1169C50", Offset = "0x1169C50", VA = "0x1169C50")]
		[Preserve]
		public static void AnimateMaterialProperty_5_op_Equality()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1169D20", Offset = "0x1169D20", VA = "0x1169D20")]
		[Preserve]
		public static void AnimateMaterialProperty_5_op_Implicit()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1169DE8", Offset = "0x1169DE8", VA = "0x1169DE8")]
		[Preserve]
		public static void AnimateMaterialProperty_5_op_Inequality()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1169EB8", Offset = "0x1169EB8", VA = "0x1169EB8")]
		[Preserve]
		public static void AnimateMaterialProperty_6_op_Equality()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1169F88", Offset = "0x1169F88", VA = "0x1169F88")]
		[Preserve]
		public static void AnimateMaterialProperty_6_op_Implicit()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x116A050", Offset = "0x116A050", VA = "0x116A050")]
		[Preserve]
		public static void AnimateMaterialProperty_6_op_Inequality()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x116A120", Offset = "0x116A120", VA = "0x116A120")]
		[Preserve]
		public static void AnimateMaterialProperty_7_op_Equality()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x116A1F0", Offset = "0x116A1F0", VA = "0x116A1F0")]
		[Preserve]
		public static void AnimateMaterialProperty_7_op_Implicit()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x116A2B8", Offset = "0x116A2B8", VA = "0x116A2B8")]
		[Preserve]
		public static void AnimateMaterialProperty_7_op_Inequality()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x116A388", Offset = "0x116A388", VA = "0x116A388")]
		[Preserve]
		public static void AnimateMaterialProperty_Base_op_Equality()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x116A458", Offset = "0x116A458", VA = "0x116A458")]
		[Preserve]
		public static void AnimateMaterialProperty_Base_op_Implicit()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x116A520", Offset = "0x116A520", VA = "0x116A520")]
		[Preserve]
		public static void AnimateMaterialProperty_Base_op_Inequality()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x116A5F0", Offset = "0x116A5F0", VA = "0x116A5F0")]
		[Preserve]
		public static void AnimateMultipleMaterials_1_op_Equality()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x116A6C0", Offset = "0x116A6C0", VA = "0x116A6C0")]
		[Preserve]
		public static void AnimateMultipleMaterials_1_op_Implicit()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x116A788", Offset = "0x116A788", VA = "0x116A788")]
		[Preserve]
		public static void AnimateMultipleMaterials_1_op_Inequality()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x116A858", Offset = "0x116A858", VA = "0x116A858")]
		[Preserve]
		public static void AnimateMultipleMaterials_2_op_Equality()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x116A928", Offset = "0x116A928", VA = "0x116A928")]
		[Preserve]
		public static void AnimateMultipleMaterials_2_op_Implicit()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x116A9F0", Offset = "0x116A9F0", VA = "0x116A9F0")]
		[Preserve]
		public static void AnimateMultipleMaterials_2_op_Inequality()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x116AAC0", Offset = "0x116AAC0", VA = "0x116AAC0")]
		[Preserve]
		public static void AnimateMultipleMaterials_3_op_Equality()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x116AB90", Offset = "0x116AB90", VA = "0x116AB90")]
		[Preserve]
		public static void AnimateMultipleMaterials_3_op_Implicit()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x116AC58", Offset = "0x116AC58", VA = "0x116AC58")]
		[Preserve]
		public static void AnimateMultipleMaterials_3_op_Inequality()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x116AD28", Offset = "0x116AD28", VA = "0x116AD28")]
		[Preserve]
		public static void AnimateMultipleMaterials_Base_op_Equality()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x116ADF8", Offset = "0x116ADF8", VA = "0x116ADF8")]
		[Preserve]
		public static void AnimateMultipleMaterials_Base_op_Implicit()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x116AEC0", Offset = "0x116AEC0", VA = "0x116AEC0")]
		[Preserve]
		public static void AnimateMultipleMaterials_Base_op_Inequality()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x116AF90", Offset = "0x116AF90", VA = "0x116AF90")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_op_Equality()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x116B060", Offset = "0x116B060", VA = "0x116B060")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_op_Implicit()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x116B128", Offset = "0x116B128", VA = "0x116B128")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_op_Inequality()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x116B1F8", Offset = "0x116B1F8", VA = "0x116B1F8")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_1_op_Equality()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x116B2C8", Offset = "0x116B2C8", VA = "0x116B2C8")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_1_op_Implicit()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x116B390", Offset = "0x116B390", VA = "0x116B390")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_1_op_Inequality()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x116B460", Offset = "0x116B460", VA = "0x116B460")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_2_op_Equality()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x116B530", Offset = "0x116B530", VA = "0x116B530")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_2_op_Implicit()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x116B5F8", Offset = "0x116B5F8", VA = "0x116B5F8")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_2_op_Inequality()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x116B6C8", Offset = "0x116B6C8", VA = "0x116B6C8")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_3_op_Equality()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x116B798", Offset = "0x116B798", VA = "0x116B798")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_3_op_Implicit()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x116B860", Offset = "0x116B860", VA = "0x116B860")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_3_op_Inequality()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x116B930", Offset = "0x116B930", VA = "0x116B930")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_4_op_Equality()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x116BA00", Offset = "0x116BA00", VA = "0x116BA00")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_4_op_Implicit()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x116BAC8", Offset = "0x116BAC8", VA = "0x116BAC8")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_4_op_Inequality()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x116BB98", Offset = "0x116BB98", VA = "0x116BB98")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_5_op_Equality()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x116BC68", Offset = "0x116BC68", VA = "0x116BC68")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_5_op_Implicit()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x116BD30", Offset = "0x116BD30", VA = "0x116BD30")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_5_op_Inequality()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x116BE00", Offset = "0x116BE00", VA = "0x116BE00")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_6_op_Equality()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x116BED0", Offset = "0x116BED0", VA = "0x116BED0")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_6_op_Implicit()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x116BF98", Offset = "0x116BF98", VA = "0x116BF98")]
		[Preserve]
		public static void AnimateSharedMaterialProperty_6_op_Inequality()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x116C068", Offset = "0x116C068", VA = "0x116C068")]
		[Preserve]
		public static void AnimateUIMaterialProperty_1_op_Equality()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x116C138", Offset = "0x116C138", VA = "0x116C138")]
		[Preserve]
		public static void AnimateUIMaterialProperty_1_op_Implicit()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x116C200", Offset = "0x116C200", VA = "0x116C200")]
		[Preserve]
		public static void AnimateUIMaterialProperty_1_op_Inequality()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x116C2D0", Offset = "0x116C2D0", VA = "0x116C2D0")]
		[Preserve]
		public static void AnimateUIMaterialProperty_2_op_Equality()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x116C3A0", Offset = "0x116C3A0", VA = "0x116C3A0")]
		[Preserve]
		public static void AnimateUIMaterialProperty_2_op_Implicit()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x116C468", Offset = "0x116C468", VA = "0x116C468")]
		[Preserve]
		public static void AnimateUIMaterialProperty_2_op_Inequality()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x116C538", Offset = "0x116C538", VA = "0x116C538")]
		[Preserve]
		public static void AnimateUIMaterialProperty_3_op_Equality()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x116C608", Offset = "0x116C608", VA = "0x116C608")]
		[Preserve]
		public static void AnimateUIMaterialProperty_3_op_Implicit()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x116C6D0", Offset = "0x116C6D0", VA = "0x116C6D0")]
		[Preserve]
		public static void AnimateUIMaterialProperty_3_op_Inequality()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x116C7A0", Offset = "0x116C7A0", VA = "0x116C7A0")]
		[Preserve]
		public static void AnimateUIMaterialProperty_4_op_Equality()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x116C870", Offset = "0x116C870", VA = "0x116C870")]
		[Preserve]
		public static void AnimateUIMaterialProperty_4_op_Implicit()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x116C938", Offset = "0x116C938", VA = "0x116C938")]
		[Preserve]
		public static void AnimateUIMaterialProperty_4_op_Inequality()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x116CA08", Offset = "0x116CA08", VA = "0x116CA08")]
		[Preserve]
		public static void AnimateUIMaterialProperty_Base_op_Equality()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x116CAD8", Offset = "0x116CAD8", VA = "0x116CAD8")]
		[Preserve]
		public static void AnimateUIMaterialProperty_Base_op_Implicit()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x116CBA0", Offset = "0x116CBA0", VA = "0x116CBA0")]
		[Preserve]
		public static void AnimateUIMaterialProperty_Base_op_Inequality()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x116CC70", Offset = "0x116CC70", VA = "0x116CC70")]
		[Preserve]
		public static void AnimationEventSendMessage_op_Equality()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x116CD40", Offset = "0x116CD40", VA = "0x116CD40")]
		[Preserve]
		public static void AnimationEventSendMessage_op_Implicit()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x116CE08", Offset = "0x116CE08", VA = "0x116CE08")]
		[Preserve]
		public static void AnimationEventSendMessage_op_Inequality()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x116CED8", Offset = "0x116CED8", VA = "0x116CED8")]
		[Preserve]
		public static void AnimationFinishedEvent_op_Equality()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x116CFA8", Offset = "0x116CFA8", VA = "0x116CFA8")]
		[Preserve]
		public static void AnimationFinishedEvent_op_Implicit()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x116D070", Offset = "0x116D070", VA = "0x116D070")]
		[Preserve]
		public static void AnimationFinishedEvent_op_Inequality()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x116D140", Offset = "0x116D140", VA = "0x116D140")]
		[Preserve]
		public static void AnimationLooper_op_Equality()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x116D210", Offset = "0x116D210", VA = "0x116D210")]
		[Preserve]
		public static void AnimationLooper_op_Implicit()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x116D2D8", Offset = "0x116D2D8", VA = "0x116D2D8")]
		[Preserve]
		public static void AnimationLooper_op_Inequality()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x116D3A8", Offset = "0x116D3A8", VA = "0x116D3A8")]
		[Preserve]
		public static void AnimationPauser_op_Equality()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x116D478", Offset = "0x116D478", VA = "0x116D478")]
		[Preserve]
		public static void AnimationPauser_op_Implicit()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x116D540", Offset = "0x116D540", VA = "0x116D540")]
		[Preserve]
		public static void AnimationPauser_op_Inequality()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x116D610", Offset = "0x116D610", VA = "0x116D610")]
		[Preserve]
		public static void AnimationSaver_op_Equality()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x116D6E0", Offset = "0x116D6E0", VA = "0x116D6E0")]
		[Preserve]
		public static void AnimationSaver_op_Implicit()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x116D7A8", Offset = "0x116D7A8", VA = "0x116D7A8")]
		[Preserve]
		public static void AnimationSaver_op_Inequality()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x116D878", Offset = "0x116D878", VA = "0x116D878")]
		[Preserve]
		public static void AnimEventPlayClip_op_Equality()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x116D948", Offset = "0x116D948", VA = "0x116D948")]
		[Preserve]
		public static void AnimEventPlayClip_op_Implicit()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x116DA10", Offset = "0x116DA10", VA = "0x116DA10")]
		[Preserve]
		public static void AnimEventPlayClip_op_Inequality()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x116DAE0", Offset = "0x116DAE0", VA = "0x116DAE0")]
		[Preserve]
		public static void AnimEventPlayMultiClips_op_Equality()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x116DBB0", Offset = "0x116DBB0", VA = "0x116DBB0")]
		[Preserve]
		public static void AnimEventPlayMultiClips_op_Implicit()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x116DC78", Offset = "0x116DC78", VA = "0x116DC78")]
		[Preserve]
		public static void AnimEventPlayMultiClips_op_Inequality()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x116DD48", Offset = "0x116DD48", VA = "0x116DD48")]
		[Preserve]
		public static void AnimEventPlayRandomClip_op_Equality()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x116DE18", Offset = "0x116DE18", VA = "0x116DE18")]
		[Preserve]
		public static void AnimEventPlayRandomClip_op_Implicit()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x116DEE0", Offset = "0x116DEE0", VA = "0x116DEE0")]
		[Preserve]
		public static void AnimEventPlayRandomClip_op_Inequality()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x116DFB0", Offset = "0x116DFB0", VA = "0x116DFB0")]
		[Preserve]
		public static void ApplyPostFX_op_Equality()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x116E080", Offset = "0x116E080", VA = "0x116E080")]
		[Preserve]
		public static void ApplyPostFX_op_Implicit()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x116E148", Offset = "0x116E148", VA = "0x116E148")]
		[Preserve]
		public static void ApplyPostFX_op_Inequality()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x116E218", Offset = "0x116E218", VA = "0x116E218")]
		[Preserve]
		public static void AttachAudioToParticles_op_Equality()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x116E2E8", Offset = "0x116E2E8", VA = "0x116E2E8")]
		[Preserve]
		public static void AttachAudioToParticles_op_Implicit()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x116E3B0", Offset = "0x116E3B0", VA = "0x116E3B0")]
		[Preserve]
		public static void AttachAudioToParticles_op_Inequality()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x116E480", Offset = "0x116E480", VA = "0x116E480")]
		[Preserve]
		public static void AudioEventHaptics_op_Equality()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x116E550", Offset = "0x116E550", VA = "0x116E550")]
		[Preserve]
		public static void AudioEventHaptics_op_Implicit()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x116E618", Offset = "0x116E618", VA = "0x116E618")]
		[Preserve]
		public static void AudioEventHaptics_op_Inequality()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x116E6E8", Offset = "0x116E6E8", VA = "0x116E6E8")]
		[Preserve]
		public static void AudioEventHapticsManager_op_Equality()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x116E7B8", Offset = "0x116E7B8", VA = "0x116E7B8")]
		[Preserve]
		public static void AudioEventHapticsManager_op_Implicit()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x116E880", Offset = "0x116E880", VA = "0x116E880")]
		[Preserve]
		public static void AudioEventHapticsManager_op_Inequality()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x116E950", Offset = "0x116E950", VA = "0x116E950")]
		[Preserve]
		public static void AudioGrabReleaseRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x116EA20", Offset = "0x116EA20", VA = "0x116EA20")]
		[Preserve]
		public static void AudioGrabReleaseRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x116EAE8", Offset = "0x116EAE8", VA = "0x116EAE8")]
		[Preserve]
		public static void AudioGrabReleaseRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x116EBB8", Offset = "0x116EBB8", VA = "0x116EBB8")]
		[Preserve]
		public static void AudioLoopLimitedSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x116EC88", Offset = "0x116EC88", VA = "0x116EC88")]
		[Preserve]
		public static void AudioLoopLimitedSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x116ED50", Offset = "0x116ED50", VA = "0x116ED50")]
		[Preserve]
		public static void AudioLoopLimitedSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x116EE20", Offset = "0x116EE20", VA = "0x116EE20")]
		[Preserve]
		public static void AudioLoopRotationModifier_Enabled()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x116EE54", Offset = "0x116EE54", VA = "0x116EE54")]
		[Preserve]
		public static void AudioLoopRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x116EF24", Offset = "0x116EF24", VA = "0x116EF24")]
		[Preserve]
		public static void AudioLoopRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x116EFEC", Offset = "0x116EFEC", VA = "0x116EFEC")]
		[Preserve]
		public static void AudioLoopRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x116F0BC", Offset = "0x116F0BC", VA = "0x116F0BC")]
		[Preserve]
		public static void AudioLoopRotationModifier_StopAudioSource()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x116F0F0", Offset = "0x116F0F0", VA = "0x116F0F0")]
		[Preserve]
		public static void AudioLoopSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x116F1C0", Offset = "0x116F1C0", VA = "0x116F1C0")]
		[Preserve]
		public static void AudioLoopSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x116F288", Offset = "0x116F288", VA = "0x116F288")]
		[Preserve]
		public static void AudioLoopSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x116F358", Offset = "0x116F358", VA = "0x116F358")]
		[Preserve]
		public static void AudioPauser_op_Equality()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x116F428", Offset = "0x116F428", VA = "0x116F428")]
		[Preserve]
		public static void AudioPauser_op_Implicit()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x116F4F0", Offset = "0x116F4F0", VA = "0x116F4F0")]
		[Preserve]
		public static void AudioPauser_op_Inequality()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x116F5C0", Offset = "0x116F5C0", VA = "0x116F5C0")]
		[Preserve]
		public static void AudioSourceSaver_op_Equality()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x116F690", Offset = "0x116F690", VA = "0x116F690")]
		[Preserve]
		public static void AudioSourceSaver_op_Implicit()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x116F758", Offset = "0x116F758", VA = "0x116F758")]
		[Preserve]
		public static void AudioSourceSaver_op_Inequality()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x116F828", Offset = "0x116F828", VA = "0x116F828")]
		[Preserve]
		public static void BillboardWorldUI_op_Equality()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x116F8F8", Offset = "0x116F8F8", VA = "0x116F8F8")]
		[Preserve]
		public static void BillboardWorldUI_op_Implicit()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x116F9C0", Offset = "0x116F9C0", VA = "0x116F9C0")]
		[Preserve]
		public static void BillboardWorldUI_op_Inequality()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x116FA90", Offset = "0x116FA90", VA = "0x116FA90")]
		[Preserve]
		public static void BlendShapeSaver_op_Equality()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x116FB60", Offset = "0x116FB60", VA = "0x116FB60")]
		[Preserve]
		public static void BlendShapeSaver_op_Implicit()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x116FC28", Offset = "0x116FC28", VA = "0x116FC28")]
		[Preserve]
		public static void BlendShapeSaver_op_Inequality()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x116FCF8", Offset = "0x116FCF8", VA = "0x116FCF8")]
		[Preserve]
		public static void BlobShadowSphere_op_Equality()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x116FDC8", Offset = "0x116FDC8", VA = "0x116FDC8")]
		[Preserve]
		public static void BlobShadowSphere_op_Implicit()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x116FE90", Offset = "0x116FE90", VA = "0x116FE90")]
		[Preserve]
		public static void BlobShadowSphere_op_Inequality()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x116FF60", Offset = "0x116FF60", VA = "0x116FF60")]
		[Preserve]
		public static void BlurFX_op_Equality()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1170030", Offset = "0x1170030", VA = "0x1170030")]
		[Preserve]
		public static void BlurFX_op_Implicit()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x11700F8", Offset = "0x11700F8", VA = "0x11700F8")]
		[Preserve]
		public static void BlurFX_op_Inequality()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x11701C8", Offset = "0x11701C8", VA = "0x11701C8")]
		[Preserve]
		public static void BlurRenderTexture_op_Equality()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1170298", Offset = "0x1170298", VA = "0x1170298")]
		[Preserve]
		public static void BlurRenderTexture_op_Implicit()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1170360", Offset = "0x1170360", VA = "0x1170360")]
		[Preserve]
		public static void BlurRenderTexture_op_Inequality()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1170430", Offset = "0x1170430", VA = "0x1170430")]
		[Preserve]
		public static void Bob_op_Equality()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1170500", Offset = "0x1170500", VA = "0x1170500")]
		[Preserve]
		public static void Bob_op_Implicit()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x11705C8", Offset = "0x11705C8", VA = "0x11705C8")]
		[Preserve]
		public static void Bob_op_Inequality()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1170698", Offset = "0x1170698", VA = "0x1170698")]
		[Preserve]
		public static void Bolt_AnimatorMessageListener_op_Equality()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1170768", Offset = "0x1170768", VA = "0x1170768")]
		[Preserve]
		public static void Bolt_AnimatorMessageListener_op_Implicit()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1170830", Offset = "0x1170830", VA = "0x1170830")]
		[Preserve]
		public static void Bolt_AnimatorMessageListener_op_Inequality()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1170900", Offset = "0x1170900", VA = "0x1170900")]
		[Preserve]
		public static void Bolt_FlowMachine_op_Equality()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x11709D0", Offset = "0x11709D0", VA = "0x11709D0")]
		[Preserve]
		public static void Bolt_FlowMachine_op_Implicit()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1170A98", Offset = "0x1170A98", VA = "0x1170A98")]
		[Preserve]
		public static void Bolt_FlowMachine_op_Inequality()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1170B68", Offset = "0x1170B68", VA = "0x1170B68")]
		[Preserve]
		public static void Bolt_FlowMacro_op_Equality()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1170C38", Offset = "0x1170C38", VA = "0x1170C38")]
		[Preserve]
		public static void Bolt_FlowMacro_op_Implicit()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1170D00", Offset = "0x1170D00", VA = "0x1170D00")]
		[Preserve]
		public static void Bolt_FlowMacro_op_Inequality()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1170DD0", Offset = "0x1170DD0", VA = "0x1170DD0")]
		[Preserve]
		public static void Bolt_StateMachine_op_Equality()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1170EA0", Offset = "0x1170EA0", VA = "0x1170EA0")]
		[Preserve]
		public static void Bolt_StateMachine_op_Implicit()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1170F68", Offset = "0x1170F68", VA = "0x1170F68")]
		[Preserve]
		public static void Bolt_StateMachine_op_Inequality()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1171038", Offset = "0x1171038", VA = "0x1171038")]
		[Preserve]
		public static void Bolt_StateMacro_op_Equality()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1171108", Offset = "0x1171108", VA = "0x1171108")]
		[Preserve]
		public static void Bolt_StateMacro_op_Implicit()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x11711D0", Offset = "0x11711D0", VA = "0x11711D0")]
		[Preserve]
		public static void Bolt_StateMacro_op_Inequality()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x11712A0", Offset = "0x11712A0", VA = "0x11712A0")]
		[Preserve]
		public static void BoltVariablesSaver_op_Equality()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1171370", Offset = "0x1171370", VA = "0x1171370")]
		[Preserve]
		public static void BoltVariablesSaver_op_Implicit()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1171438", Offset = "0x1171438", VA = "0x1171438")]
		[Preserve]
		public static void BoltVariablesSaver_op_Inequality()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1171508", Offset = "0x1171508", VA = "0x1171508")]
		[Preserve]
		public static void BoxGrabbableCollider_op_Equality()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x11715D8", Offset = "0x11715D8", VA = "0x11715D8")]
		[Preserve]
		public static void BoxGrabbableCollider_op_Implicit()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x11716A0", Offset = "0x11716A0", VA = "0x11716A0")]
		[Preserve]
		public static void BoxGrabbableCollider_op_Inequality()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1171770", Offset = "0x1171770", VA = "0x1171770")]
		[Preserve]
		public static void BoxTrigger_enabled()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x11717A4", Offset = "0x11717A4", VA = "0x11717A4")]
		[Preserve]
		public static void BoxTrigger_op_Equality()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1171874", Offset = "0x1171874", VA = "0x1171874")]
		[Preserve]
		public static void BoxTrigger_op_Implicit()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x117193C", Offset = "0x117193C", VA = "0x117193C")]
		[Preserve]
		public static void BoxTrigger_op_Inequality()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1171A0C", Offset = "0x1171A0C", VA = "0x1171A0C")]
		[Preserve]
		public static void BugReportAction_op_Equality()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1171ADC", Offset = "0x1171ADC", VA = "0x1171ADC")]
		[Preserve]
		public static void BugReportAction_op_Implicit()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1171BA4", Offset = "0x1171BA4", VA = "0x1171BA4")]
		[Preserve]
		public static void BugReportAction_op_Inequality()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1171C74", Offset = "0x1171C74", VA = "0x1171C74")]
		[Preserve]
		public static void BugReporter_op_Equality()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1171D44", Offset = "0x1171D44", VA = "0x1171D44")]
		[Preserve]
		public static void BugReporter_op_Implicit()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1171E0C", Offset = "0x1171E0C", VA = "0x1171E0C")]
		[Preserve]
		public static void BugReporter_op_Inequality()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1171EDC", Offset = "0x1171EDC", VA = "0x1171EDC")]
		[Preserve]
		public static void BugReporterView_op_Equality()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1171FAC", Offset = "0x1171FAC", VA = "0x1171FAC")]
		[Preserve]
		public static void BugReporterView_op_Implicit()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1172074", Offset = "0x1172074", VA = "0x1172074")]
		[Preserve]
		public static void BugReporterView_op_Inequality()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1172144", Offset = "0x1172144", VA = "0x1172144")]
		[Preserve]
		public static void ButtonGrabbable_op_Equality()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1172214", Offset = "0x1172214", VA = "0x1172214")]
		[Preserve]
		public static void ButtonGrabbable_op_Implicit()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x11722DC", Offset = "0x11722DC", VA = "0x11722DC")]
		[Preserve]
		public static void ButtonGrabbable_op_Inequality()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x11723AC", Offset = "0x11723AC", VA = "0x11723AC")]
		[Preserve]
		public static void CameraDelegateHelper_op_Equality()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x117247C", Offset = "0x117247C", VA = "0x117247C")]
		[Preserve]
		public static void CameraDelegateHelper_op_Implicit()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1172544", Offset = "0x1172544", VA = "0x1172544")]
		[Preserve]
		public static void CameraDelegateHelper_op_Inequality()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1172614", Offset = "0x1172614", VA = "0x1172614")]
		[Preserve]
		public static void CameraShake_op_Equality()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x11726E4", Offset = "0x11726E4", VA = "0x11726E4")]
		[Preserve]
		public static void CameraShake_op_Implicit()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x11727AC", Offset = "0x11727AC", VA = "0x11727AC")]
		[Preserve]
		public static void CameraShake_op_Inequality()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x117287C", Offset = "0x117287C", VA = "0x117287C")]
		[Preserve]
		public static void CameraShakeDefinition_op_Equality()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x117294C", Offset = "0x117294C", VA = "0x117294C")]
		[Preserve]
		public static void CameraShakeDefinition_op_Implicit()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1172A14", Offset = "0x1172A14", VA = "0x1172A14")]
		[Preserve]
		public static void CameraShakeDefinition_op_Inequality()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1172AE4", Offset = "0x1172AE4", VA = "0x1172AE4")]
		[Preserve]
		public static void CameraShakeDefinition_Simple_op_Equality()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1172BB4", Offset = "0x1172BB4", VA = "0x1172BB4")]
		[Preserve]
		public static void CameraShakeDefinition_Simple_op_Implicit()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1172C7C", Offset = "0x1172C7C", VA = "0x1172C7C")]
		[Preserve]
		public static void CameraShakeDefinition_Simple_op_Inequality()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1172D4C", Offset = "0x1172D4C", VA = "0x1172D4C")]
		[Preserve]
		public static void CanvasPhysicalSize_op_Equality()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1172E1C", Offset = "0x1172E1C", VA = "0x1172E1C")]
		[Preserve]
		public static void CanvasPhysicalSize_op_Implicit()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1172EE4", Offset = "0x1172EE4", VA = "0x1172EE4")]
		[Preserve]
		public static void CanvasPhysicalSize_op_Inequality()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1172FB4", Offset = "0x1172FB4", VA = "0x1172FB4")]
		[Preserve]
		public static void CapAngularAccelerationModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1173084", Offset = "0x1173084", VA = "0x1173084")]
		[Preserve]
		public static void CapAngularAccelerationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x117314C", Offset = "0x117314C", VA = "0x117314C")]
		[Preserve]
		public static void CapAngularAccelerationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x117321C", Offset = "0x117321C", VA = "0x117321C")]
		[Preserve]
		public static void CapAngularVelocityModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x11732EC", Offset = "0x11732EC", VA = "0x11732EC")]
		[Preserve]
		public static void CapAngularVelocityModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x11733B4", Offset = "0x11733B4", VA = "0x11733B4")]
		[Preserve]
		public static void CapAngularVelocityModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1173484", Offset = "0x1173484", VA = "0x1173484")]
		[Preserve]
		public static void CapLinearAccelerationModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1173554", Offset = "0x1173554", VA = "0x1173554")]
		[Preserve]
		public static void CapLinearAccelerationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x117361C", Offset = "0x117361C", VA = "0x117361C")]
		[Preserve]
		public static void CapLinearAccelerationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x11736EC", Offset = "0x11736EC", VA = "0x11736EC")]
		[Preserve]
		public static void CapLinearVelocityModifier_op_Equality()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x11737BC", Offset = "0x11737BC", VA = "0x11737BC")]
		[Preserve]
		public static void CapLinearVelocityModifier_op_Implicit()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1173884", Offset = "0x1173884", VA = "0x1173884")]
		[Preserve]
		public static void CapLinearVelocityModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1173954", Offset = "0x1173954", VA = "0x1173954")]
		[Preserve]
		public static void CapsuleGrabbableCollider_op_Equality()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1173A24", Offset = "0x1173A24", VA = "0x1173A24")]
		[Preserve]
		public static void CapsuleGrabbableCollider_op_Implicit()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1173AEC", Offset = "0x1173AEC", VA = "0x1173AEC")]
		[Preserve]
		public static void CapsuleGrabbableCollider_op_Inequality()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1173BBC", Offset = "0x1173BBC", VA = "0x1173BBC")]
		[Preserve]
		public static void CauldronChoppedIngredient_op_Equality()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1173C8C", Offset = "0x1173C8C", VA = "0x1173C8C")]
		[Preserve]
		public static void CauldronChoppedIngredient_op_Implicit()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1173D54", Offset = "0x1173D54", VA = "0x1173D54")]
		[Preserve]
		public static void CauldronChoppedIngredient_op_Inequality()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1173E24", Offset = "0x1173E24", VA = "0x1173E24")]
		[Preserve]
		public static void CauldronChunkCollisionListener_op_Equality()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1173EF4", Offset = "0x1173EF4", VA = "0x1173EF4")]
		[Preserve]
		public static void CauldronChunkCollisionListener_op_Implicit()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1173FBC", Offset = "0x1173FBC", VA = "0x1173FBC")]
		[Preserve]
		public static void CauldronChunkCollisionListener_op_Inequality()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x117408C", Offset = "0x117408C", VA = "0x117408C")]
		[Preserve]
		public static void CauldronChunkedIngredient_op_Equality()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x117415C", Offset = "0x117415C", VA = "0x117415C")]
		[Preserve]
		public static void CauldronChunkedIngredient_op_Implicit()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1174224", Offset = "0x1174224", VA = "0x1174224")]
		[Preserve]
		public static void CauldronChunkedIngredient_op_Inequality()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x11742F4", Offset = "0x11742F4", VA = "0x11742F4")]
		[Preserve]
		public static void CauldronChunkedIngredientBottle_op_Equality()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x11743C4", Offset = "0x11743C4", VA = "0x11743C4")]
		[Preserve]
		public static void CauldronChunkedIngredientBottle_op_Implicit()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x117448C", Offset = "0x117448C", VA = "0x117448C")]
		[Preserve]
		public static void CauldronChunkedIngredientBottle_op_Inequality()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x117455C", Offset = "0x117455C", VA = "0x117455C")]
		[Preserve]
		public static void CauldronChunkedIngredientManager_op_Equality()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x117462C", Offset = "0x117462C", VA = "0x117462C")]
		[Preserve]
		public static void CauldronChunkedIngredientManager_op_Implicit()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x11746F4", Offset = "0x11746F4", VA = "0x11746F4")]
		[Preserve]
		public static void CauldronChunkedIngredientManager_op_Inequality()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x11747C4", Offset = "0x11747C4", VA = "0x11747C4")]
		[Preserve]
		public static void CauldronChunkMeshes_op_Equality()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1174894", Offset = "0x1174894", VA = "0x1174894")]
		[Preserve]
		public static void CauldronChunkMeshes_op_Implicit()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x117495C", Offset = "0x117495C", VA = "0x117495C")]
		[Preserve]
		public static void CauldronChunkMeshes_op_Inequality()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1174A2C", Offset = "0x1174A2C", VA = "0x1174A2C")]
		[Preserve]
		public static void CauldronIngredient_op_Equality()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1174AFC", Offset = "0x1174AFC", VA = "0x1174AFC")]
		[Preserve]
		public static void CauldronIngredient_op_Implicit()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1174BC4", Offset = "0x1174BC4", VA = "0x1174BC4")]
		[Preserve]
		public static void CauldronIngredient_op_Inequality()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1174C94", Offset = "0x1174C94", VA = "0x1174C94")]
		[Preserve]
		public static void CauldronIngredientBottle_op_Equality()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1174D64", Offset = "0x1174D64", VA = "0x1174D64")]
		[Preserve]
		public static void CauldronIngredientBottle_op_Implicit()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1174E2C", Offset = "0x1174E2C", VA = "0x1174E2C")]
		[Preserve]
		public static void CauldronIngredientBottle_op_Inequality()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1174EFC", Offset = "0x1174EFC", VA = "0x1174EFC")]
		[Preserve]
		public static void CauldronPotion_op_Equality()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1174FCC", Offset = "0x1174FCC", VA = "0x1174FCC")]
		[Preserve]
		public static void CauldronPotion_op_Implicit()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1175094", Offset = "0x1175094", VA = "0x1175094")]
		[Preserve]
		public static void CauldronPotion_op_Inequality()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1175164", Offset = "0x1175164", VA = "0x1175164")]
		[Preserve]
		public static void ChapelBounceLight_op_Equality()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1175234", Offset = "0x1175234", VA = "0x1175234")]
		[Preserve]
		public static void ChapelBounceLight_op_Implicit()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x11752FC", Offset = "0x11752FC", VA = "0x11752FC")]
		[Preserve]
		public static void ChapelBounceLight_op_Inequality()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x11753CC", Offset = "0x11753CC", VA = "0x11753CC")]
		[Preserve]
		public static void ChapelLightFilter_op_Equality()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x117549C", Offset = "0x117549C", VA = "0x117549C")]
		[Preserve]
		public static void ChapelLightFilter_op_Implicit()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1175564", Offset = "0x1175564", VA = "0x1175564")]
		[Preserve]
		public static void ChapelLightFilter_op_Inequality()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1175634", Offset = "0x1175634", VA = "0x1175634")]
		[Preserve]
		public static void ChapelLightProjector_op_Equality()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1175704", Offset = "0x1175704", VA = "0x1175704")]
		[Preserve]
		public static void ChapelLightProjector_op_Implicit()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x11757CC", Offset = "0x11757CC", VA = "0x11757CC")]
		[Preserve]
		public static void ChapelLightProjector_op_Inequality()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x117589C", Offset = "0x117589C", VA = "0x117589C")]
		[Preserve]
		public static void ChunkedIngredientDispenser_op_Equality()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x117596C", Offset = "0x117596C", VA = "0x117596C")]
		[Preserve]
		public static void ChunkedIngredientDispenser_op_Implicit()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1175A34", Offset = "0x1175A34", VA = "0x1175A34")]
		[Preserve]
		public static void ChunkedIngredientDispenser_op_Inequality()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1175B04", Offset = "0x1175B04", VA = "0x1175B04")]
		[Preserve]
		public static void ClaimCamera_op_Equality()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1175BD4", Offset = "0x1175BD4", VA = "0x1175BD4")]
		[Preserve]
		public static void ClaimCamera_op_Implicit()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1175C9C", Offset = "0x1175C9C", VA = "0x1175C9C")]
		[Preserve]
		public static void ClaimCamera_op_Inequality()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1175D6C", Offset = "0x1175D6C", VA = "0x1175D6C")]
		[Preserve]
		public static void ClockPodiumController_op_Equality()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1175E3C", Offset = "0x1175E3C", VA = "0x1175E3C")]
		[Preserve]
		public static void ClockPodiumController_op_Implicit()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1175F04", Offset = "0x1175F04", VA = "0x1175F04")]
		[Preserve]
		public static void ClockPodiumController_op_Inequality()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1175FD4", Offset = "0x1175FD4", VA = "0x1175FD4")]
		[Preserve]
		public static void ClockPodiumController_SetActive()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1176008", Offset = "0x1176008", VA = "0x1176008")]
		[Preserve]
		public static void ClockSuperzoomController_op_Equality()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x11760D8", Offset = "0x11760D8", VA = "0x11760D8")]
		[Preserve]
		public static void ClockSuperzoomController_op_Implicit()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x11761A0", Offset = "0x11761A0", VA = "0x11761A0")]
		[Preserve]
		public static void ClockSuperzoomController_op_Inequality()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1176270", Offset = "0x1176270", VA = "0x1176270")]
		[Preserve]
		public static void ClothBoundsFixer_op_Equality()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1176340", Offset = "0x1176340", VA = "0x1176340")]
		[Preserve]
		public static void ClothBoundsFixer_op_Implicit()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1176408", Offset = "0x1176408", VA = "0x1176408")]
		[Preserve]
		public static void ClothBoundsFixer_op_Inequality()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x11764D8", Offset = "0x11764D8", VA = "0x11764D8")]
		[Preserve]
		public static void CogDrivenUVAnimation_op_Equality()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x11765A8", Offset = "0x11765A8", VA = "0x11765A8")]
		[Preserve]
		public static void CogDrivenUVAnimation_op_Implicit()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1176670", Offset = "0x1176670", VA = "0x1176670")]
		[Preserve]
		public static void CogDrivenUVAnimation_op_Inequality()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1176740", Offset = "0x1176740", VA = "0x1176740")]
		[Preserve]
		public static void CogHandle_op_Equality()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1176810", Offset = "0x1176810", VA = "0x1176810")]
		[Preserve]
		public static void CogHandle_op_Implicit()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x11768D8", Offset = "0x11768D8", VA = "0x11768D8")]
		[Preserve]
		public static void CogHandle_op_Inequality()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x11769A8", Offset = "0x11769A8", VA = "0x11769A8")]
		[Preserve]
		public static void CogSlider_op_Equality()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1176A78", Offset = "0x1176A78", VA = "0x1176A78")]
		[Preserve]
		public static void CogSlider_op_Implicit()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1176B40", Offset = "0x1176B40", VA = "0x1176B40")]
		[Preserve]
		public static void CogSlider_op_Inequality()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1176C10", Offset = "0x1176C10", VA = "0x1176C10")]
		[Preserve]
		public static void CollisionProbe_op_Equality()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1176CE0", Offset = "0x1176CE0", VA = "0x1176CE0")]
		[Preserve]
		public static void CollisionProbe_op_Implicit()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1176DA8", Offset = "0x1176DA8", VA = "0x1176DA8")]
		[Preserve]
		public static void CollisionProbe_op_Inequality()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1176E78", Offset = "0x1176E78", VA = "0x1176E78")]
		[Preserve]
		public static void CollisionRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1176F48", Offset = "0x1176F48", VA = "0x1176F48")]
		[Preserve]
		public static void CollisionRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1177010", Offset = "0x1177010", VA = "0x1177010")]
		[Preserve]
		public static void CollisionRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x11770E0", Offset = "0x11770E0", VA = "0x11770E0")]
		[Preserve]
		public static void CollisionSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x11771B0", Offset = "0x11771B0", VA = "0x11771B0")]
		[Preserve]
		public static void CollisionSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1177278", Offset = "0x1177278", VA = "0x1177278")]
		[Preserve]
		public static void CollisionSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1177348", Offset = "0x1177348", VA = "0x1177348")]
		[Preserve]
		public static void ColourCorrection_op_Equality()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1177418", Offset = "0x1177418", VA = "0x1177418")]
		[Preserve]
		public static void ColourCorrection_op_Implicit()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x11774E0", Offset = "0x11774E0", VA = "0x11774E0")]
		[Preserve]
		public static void ColourCorrection_op_Inequality()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x11775B0", Offset = "0x11775B0", VA = "0x11775B0")]
		[Preserve]
		public static void CombinationDial_op_Equality()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1177680", Offset = "0x1177680", VA = "0x1177680")]
		[Preserve]
		public static void CombinationDial_op_Implicit()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1177748", Offset = "0x1177748", VA = "0x1177748")]
		[Preserve]
		public static void CombinationDial_op_Inequality()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1177818", Offset = "0x1177818", VA = "0x1177818")]
		[Preserve]
		public static void CombinationGrabbable_op_Equality()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x11778E8", Offset = "0x11778E8", VA = "0x11778E8")]
		[Preserve]
		public static void CombinationGrabbable_op_Implicit()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x11779B0", Offset = "0x11779B0", VA = "0x11779B0")]
		[Preserve]
		public static void CombinationGrabbable_op_Inequality()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1177A80", Offset = "0x1177A80", VA = "0x1177A80")]
		[Preserve]
		public static void CombinationGrabbable_SetState()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1177AB4", Offset = "0x1177AB4", VA = "0x1177AB4")]
		[Preserve]
		public static void Comment_op_Equality()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1177B84", Offset = "0x1177B84", VA = "0x1177B84")]
		[Preserve]
		public static void Comment_op_Implicit()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1177C4C", Offset = "0x1177C4C", VA = "0x1177C4C")]
		[Preserve]
		public static void Comment_op_Inequality()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1177D1C", Offset = "0x1177D1C", VA = "0x1177D1C")]
		[Preserve]
		public static void ComponentEnabledSaver_op_Equality()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1177DEC", Offset = "0x1177DEC", VA = "0x1177DEC")]
		[Preserve]
		public static void ComponentEnabledSaver_op_Implicit()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1177EB4", Offset = "0x1177EB4", VA = "0x1177EB4")]
		[Preserve]
		public static void ComponentEnabledSaver_op_Inequality()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1177F84", Offset = "0x1177F84", VA = "0x1177F84")]
		[Preserve]
		public static void ComponentEnabledSaver_SetEnabled()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1177FB8", Offset = "0x1177FB8", VA = "0x1177FB8")]
		[Preserve]
		public static void ComponentEnabledSaver_SetMultipleComponentsEnabled()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1178084", Offset = "0x1178084", VA = "0x1178084")]
		[Preserve]
		public static void Controller_op_Equality()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1178154", Offset = "0x1178154", VA = "0x1178154")]
		[Preserve]
		public static void Controller_op_Implicit()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x117821C", Offset = "0x117821C", VA = "0x117821C")]
		[Preserve]
		public static void Controller_op_Inequality()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x11782EC", Offset = "0x11782EC", VA = "0x11782EC")]
		[Preserve]
		public static void ControllerHandTransformMap_op_Equality()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x11783BC", Offset = "0x11783BC", VA = "0x11783BC")]
		[Preserve]
		public static void ControllerHandTransformMap_op_Implicit()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1178484", Offset = "0x1178484", VA = "0x1178484")]
		[Preserve]
		public static void ControllerHandTransformMap_op_Inequality()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1178554", Offset = "0x1178554", VA = "0x1178554")]
		[Preserve]
		public static void ControllerHapticsData_op_Equality()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1178624", Offset = "0x1178624", VA = "0x1178624")]
		[Preserve]
		public static void ControllerHapticsData_op_Implicit()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x11786EC", Offset = "0x11786EC", VA = "0x11786EC")]
		[Preserve]
		public static void ControllerHapticsData_op_Inequality()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x11787BC", Offset = "0x11787BC", VA = "0x11787BC")]
		[Preserve]
		public static void ControllerHapticsDataAnimated_op_Equality()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x117888C", Offset = "0x117888C", VA = "0x117888C")]
		[Preserve]
		public static void ControllerHapticsDataAnimated_op_Implicit()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1178954", Offset = "0x1178954", VA = "0x1178954")]
		[Preserve]
		public static void ControllerHapticsDataAnimated_op_Inequality()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1178A24", Offset = "0x1178A24", VA = "0x1178A24")]
		[Preserve]
		public static void ControllerHapticsDataAudioEvent_op_Equality()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1178AF4", Offset = "0x1178AF4", VA = "0x1178AF4")]
		[Preserve]
		public static void ControllerHapticsDataAudioEvent_op_Implicit()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1178BBC", Offset = "0x1178BBC", VA = "0x1178BBC")]
		[Preserve]
		public static void ControllerHapticsDataAudioEvent_op_Inequality()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1178C8C", Offset = "0x1178C8C", VA = "0x1178C8C")]
		[Preserve]
		public static void ControllerHapticsDataSimple_op_Equality()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1178D5C", Offset = "0x1178D5C", VA = "0x1178D5C")]
		[Preserve]
		public static void ControllerHapticsDataSimple_op_Implicit()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1178E24", Offset = "0x1178E24", VA = "0x1178E24")]
		[Preserve]
		public static void ControllerHapticsDataSimple_op_Inequality()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1178EF4", Offset = "0x1178EF4", VA = "0x1178EF4")]
		[Preserve]
		public static void ControllerLineRenderer_op_Equality()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1178FC4", Offset = "0x1178FC4", VA = "0x1178FC4")]
		[Preserve]
		public static void ControllerLineRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x117908C", Offset = "0x117908C", VA = "0x117908C")]
		[Preserve]
		public static void ControllerLineRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x117915C", Offset = "0x117915C", VA = "0x117915C")]
		[Preserve]
		public static void ControllerSpriteMapping_op_Equality()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x117922C", Offset = "0x117922C", VA = "0x117922C")]
		[Preserve]
		public static void ControllerSpriteMapping_op_Implicit()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x11792F4", Offset = "0x11792F4", VA = "0x11792F4")]
		[Preserve]
		public static void ControllerSpriteMapping_op_Inequality()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x11793C4", Offset = "0x11793C4", VA = "0x11793C4")]
		[Preserve]
		public static void ControllerType_op_Equality()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1179474", Offset = "0x1179474", VA = "0x1179474")]
		[Preserve]
		public static void ControllerType_op_Equality_0()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1179544", Offset = "0x1179544", VA = "0x1179544")]
		[Preserve]
		public static void ControllerType_op_Implicit()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x117960C", Offset = "0x117960C", VA = "0x117960C")]
		[Preserve]
		public static void ControllerType_op_Inequality()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x11796BC", Offset = "0x11796BC", VA = "0x11796BC")]
		[Preserve]
		public static void ControllerType_op_Inequality_0()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x117978C", Offset = "0x117978C", VA = "0x117978C")]
		[Preserve]
		public static void ControlMapScreen_op_Equality()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x117985C", Offset = "0x117985C", VA = "0x117985C")]
		[Preserve]
		public static void ControlMapScreen_op_Implicit()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1179924", Offset = "0x1179924", VA = "0x1179924")]
		[Preserve]
		public static void ControlMapScreen_op_Inequality()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x11799F4", Offset = "0x11799F4", VA = "0x11799F4")]
		[Preserve]
		public static void CoreBugReporterDebugMenu_op_Equality()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1179AC4", Offset = "0x1179AC4", VA = "0x1179AC4")]
		[Preserve]
		public static void CoreBugReporterDebugMenu_op_Implicit()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1179B8C", Offset = "0x1179B8C", VA = "0x1179B8C")]
		[Preserve]
		public static void CoreBugReporterDebugMenu_op_Inequality()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1179C5C", Offset = "0x1179C5C", VA = "0x1179C5C")]
		[Preserve]
		public static void CoroutineDummy_op_Equality()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1179D2C", Offset = "0x1179D2C", VA = "0x1179D2C")]
		[Preserve]
		public static void CoroutineDummy_op_Implicit()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1179DF4", Offset = "0x1179DF4", VA = "0x1179DF4")]
		[Preserve]
		public static void CoroutineDummy_op_Inequality()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1179EC4", Offset = "0x1179EC4", VA = "0x1179EC4")]
		[Preserve]
		public static void CreditsScreen_op_Equality()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1179F94", Offset = "0x1179F94", VA = "0x1179F94")]
		[Preserve]
		public static void CreditsScreen_op_Implicit()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x117A05C", Offset = "0x117A05C", VA = "0x117A05C")]
		[Preserve]
		public static void CreditsScreen_op_Inequality()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x117A12C", Offset = "0x117A12C", VA = "0x117A12C")]
		[Preserve]
		public static void CrystalBallPuzzle_op_Equality()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x117A1FC", Offset = "0x117A1FC", VA = "0x117A1FC")]
		[Preserve]
		public static void CrystalBallPuzzle_op_Implicit()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x117A2C4", Offset = "0x117A2C4", VA = "0x117A2C4")]
		[Preserve]
		public static void CrystalBallPuzzle_op_Inequality()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x117A394", Offset = "0x117A394", VA = "0x117A394")]
		[Preserve]
		public static void CrystalBallPuzzle_StartPuzzle()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x117A3C8", Offset = "0x117A3C8", VA = "0x117A3C8")]
		[Preserve]
		public static void CrystalLookAt_op_Equality()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x117A498", Offset = "0x117A498", VA = "0x117A498")]
		[Preserve]
		public static void CrystalLookAt_op_Implicit()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x117A560", Offset = "0x117A560", VA = "0x117A560")]
		[Preserve]
		public static void CrystalLookAt_op_Inequality()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x117A630", Offset = "0x117A630", VA = "0x117A630")]
		[Preserve]
		public static void CubeMapSetAngle_op_Equality()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x117A700", Offset = "0x117A700", VA = "0x117A700")]
		[Preserve]
		public static void CubeMapSetAngle_op_Implicit()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x117A7C8", Offset = "0x117A7C8", VA = "0x117A7C8")]
		[Preserve]
		public static void CubeMapSetAngle_op_Inequality()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x117A898", Offset = "0x117A898", VA = "0x117A898")]
		[Preserve]
		public static void CustomMouseCursor_op_Equality()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x117A968", Offset = "0x117A968", VA = "0x117A968")]
		[Preserve]
		public static void CustomMouseCursor_op_Implicit()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x117AA30", Offset = "0x117AA30", VA = "0x117AA30")]
		[Preserve]
		public static void CustomMouseCursor_op_Inequality()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x117AB00", Offset = "0x117AB00", VA = "0x117AB00")]
		[Preserve]
		public static void CylinderGrabbableCollider_op_Equality()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x117ABD0", Offset = "0x117ABD0", VA = "0x117ABD0")]
		[Preserve]
		public static void CylinderGrabbableCollider_op_Implicit()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x117AC98", Offset = "0x117AC98", VA = "0x117AC98")]
		[Preserve]
		public static void CylinderGrabbableCollider_op_Inequality()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x117AD68", Offset = "0x117AD68", VA = "0x117AD68")]
		[Preserve]
		public static void DampingRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x117AE38", Offset = "0x117AE38", VA = "0x117AE38")]
		[Preserve]
		public static void DampingRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x117AF00", Offset = "0x117AF00", VA = "0x117AF00")]
		[Preserve]
		public static void DampingRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x117AFD0", Offset = "0x117AFD0", VA = "0x117AFD0")]
		[Preserve]
		public static void DampingSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x117B0A0", Offset = "0x117B0A0", VA = "0x117B0A0")]
		[Preserve]
		public static void DampingSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x117B168", Offset = "0x117B168", VA = "0x117B168")]
		[Preserve]
		public static void DampingSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x117B238", Offset = "0x117B238", VA = "0x117B238")]
		[Preserve]
		public static void DebugClock_op_Equality()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x117B308", Offset = "0x117B308", VA = "0x117B308")]
		[Preserve]
		public static void DebugClock_op_Implicit()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x117B3D0", Offset = "0x117B3D0", VA = "0x117B3D0")]
		[Preserve]
		public static void DebugClock_op_Inequality()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x117B4A0", Offset = "0x117B4A0", VA = "0x117B4A0")]
		[Preserve]
		public static void DebugMenuManager_op_Equality()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x117B570", Offset = "0x117B570", VA = "0x117B570")]
		[Preserve]
		public static void DebugMenuManager_op_Implicit()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x117B638", Offset = "0x117B638", VA = "0x117B638")]
		[Preserve]
		public static void DebugMenuManager_op_Inequality()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x117B708", Offset = "0x117B708", VA = "0x117B708")]
		[Preserve]
		public static void DebugMenuTweakableVariables_op_Equality()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x117B7D8", Offset = "0x117B7D8", VA = "0x117B7D8")]
		[Preserve]
		public static void DebugMenuTweakableVariables_op_Implicit()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x117B8A0", Offset = "0x117B8A0", VA = "0x117B8A0")]
		[Preserve]
		public static void DebugMenuTweakableVariables_op_Inequality()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x117B970", Offset = "0x117B970", VA = "0x117B970")]
		[Preserve]
		public static void DecalFlash_enabled()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x117B9A4", Offset = "0x117B9A4", VA = "0x117B9A4")]
		[Preserve]
		public static void DecalFlash_op_Equality()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x117BA74", Offset = "0x117BA74", VA = "0x117BA74")]
		[Preserve]
		public static void DecalFlash_op_Implicit()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x117BB3C", Offset = "0x117BB3C", VA = "0x117BB3C")]
		[Preserve]
		public static void DecalFlash_op_Inequality()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x117BC0C", Offset = "0x117BC0C", VA = "0x117BC0C")]
		[Preserve]
		public static void DeleteProfileScreen_op_Equality()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x117BCDC", Offset = "0x117BCDC", VA = "0x117BCDC")]
		[Preserve]
		public static void DeleteProfileScreen_op_Implicit()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x117BDA4", Offset = "0x117BDA4", VA = "0x117BDA4")]
		[Preserve]
		public static void DeleteProfileScreen_op_Inequality()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x117BE74", Offset = "0x117BE74", VA = "0x117BE74")]
		[Preserve]
		public static void DesertNoteFlapAudio_op_Equality()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x117BF44", Offset = "0x117BF44", VA = "0x117BF44")]
		[Preserve]
		public static void DesertNoteFlapAudio_op_Implicit()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x117C00C", Offset = "0x117C00C", VA = "0x117C00C")]
		[Preserve]
		public static void DesertNoteFlapAudio_op_Inequality()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x117C0DC", Offset = "0x117C0DC", VA = "0x117C0DC")]
		[Preserve]
		public static void DeskFan_op_Equality()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x117C1AC", Offset = "0x117C1AC", VA = "0x117C1AC")]
		[Preserve]
		public static void DeskFan_op_Implicit()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x117C274", Offset = "0x117C274", VA = "0x117C274")]
		[Preserve]
		public static void DeskFan_op_Inequality()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x117C344", Offset = "0x117C344", VA = "0x117C344")]
		[Preserve]
		public static void DestroyAfter_op_Equality()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x117C414", Offset = "0x117C414", VA = "0x117C414")]
		[Preserve]
		public static void DestroyAfter_op_Implicit()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x117C4DC", Offset = "0x117C4DC", VA = "0x117C4DC")]
		[Preserve]
		public static void DestroyAfter_op_Inequality()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x117C5AC", Offset = "0x117C5AC", VA = "0x117C5AC")]
		[Preserve]
		public static void DisableByDirectXVersion_op_Equality()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x117C67C", Offset = "0x117C67C", VA = "0x117C67C")]
		[Preserve]
		public static void DisableByDirectXVersion_op_Implicit()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x117C744", Offset = "0x117C744", VA = "0x117C744")]
		[Preserve]
		public static void DisableByDirectXVersion_op_Inequality()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x117C814", Offset = "0x117C814", VA = "0x117C814")]
		[Preserve]
		public static void DisableInvisibleCloth_op_Equality()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x117C8E4", Offset = "0x117C8E4", VA = "0x117C8E4")]
		[Preserve]
		public static void DisableInvisibleCloth_op_Implicit()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x117C9AC", Offset = "0x117C9AC", VA = "0x117C9AC")]
		[Preserve]
		public static void DisableInvisibleCloth_op_Inequality()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x117CA7C", Offset = "0x117CA7C", VA = "0x117CA7C")]
		[Preserve]
		public static void DissolvableObject_op_Equality()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x117CB4C", Offset = "0x117CB4C", VA = "0x117CB4C")]
		[Preserve]
		public static void DissolvableObject_op_Implicit()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x117CC14", Offset = "0x117CC14", VA = "0x117CC14")]
		[Preserve]
		public static void DissolvableObject_op_Inequality()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x117CCE4", Offset = "0x117CCE4", VA = "0x117CCE4")]
		[Preserve]
		public static void DissolvableObject_SwitchToDissolvableMaterials()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x117CD18", Offset = "0x117CD18", VA = "0x117CD18")]
		[Preserve]
		public static void DissolveSphere_enabled()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x117CD4C", Offset = "0x117CD4C", VA = "0x117CD4C")]
		[Preserve]
		public static void DissolveSphere_op_Equality()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x117CE1C", Offset = "0x117CE1C", VA = "0x117CE1C")]
		[Preserve]
		public static void DissolveSphere_op_Implicit()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x117CEE4", Offset = "0x117CEE4", VA = "0x117CEE4")]
		[Preserve]
		public static void DissolveSphere_op_Inequality()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x117CFB4", Offset = "0x117CFB4", VA = "0x117CFB4")]
		[Preserve]
		public static void DissolveSphere_Radius()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x117CFE8", Offset = "0x117CFE8", VA = "0x117CFE8")]
		[Preserve]
		public static void DoorSystem_DoorImpact()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x117D01C", Offset = "0x117D01C", VA = "0x117D01C")]
		[Preserve]
		public static void DoorSystem_IsDoorOpen()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x117D050", Offset = "0x117D050", VA = "0x117D050")]
		[Preserve]
		public static void DoorSystem_op_Equality()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x117D120", Offset = "0x117D120", VA = "0x117D120")]
		[Preserve]
		public static void DoorSystem_op_Implicit()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x117D1E8", Offset = "0x117D1E8", VA = "0x117D1E8")]
		[Preserve]
		public static void DoorSystem_op_Inequality()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x117D2B8", Offset = "0x117D2B8", VA = "0x117D2B8")]
		[Preserve]
		public static void DriveDrivenCog_op_Equality()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x117D388", Offset = "0x117D388", VA = "0x117D388")]
		[Preserve]
		public static void DriveDrivenCog_op_Implicit()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x117D450", Offset = "0x117D450", VA = "0x117D450")]
		[Preserve]
		public static void DriveDrivenCog_op_Inequality()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x117D520", Offset = "0x117D520", VA = "0x117D520")]
		[Preserve]
		public static void DrivenCog_AddDrivenObject()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x117D554", Offset = "0x117D554", VA = "0x117D554")]
		[Preserve]
		public static void DrivenCog_ClearDrivenObjects()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x117D588", Offset = "0x117D588", VA = "0x117D588")]
		[Preserve]
		public static void DrivenCog_CogEnabled()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x117D5BC", Offset = "0x117D5BC", VA = "0x117D5BC")]
		[Preserve]
		public static void DrivenCog_op_Equality()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x117D68C", Offset = "0x117D68C", VA = "0x117D68C")]
		[Preserve]
		public static void DrivenCog_op_Implicit()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x117D754", Offset = "0x117D754", VA = "0x117D754")]
		[Preserve]
		public static void DrivenCog_op_Inequality()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x117D824", Offset = "0x117D824", VA = "0x117D824")]
		[Preserve]
		public static void DrivenLocalTranslation_op_Equality()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x117D8F4", Offset = "0x117D8F4", VA = "0x117D8F4")]
		[Preserve]
		public static void DrivenLocalTranslation_op_Implicit()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x117D9BC", Offset = "0x117D9BC", VA = "0x117D9BC")]
		[Preserve]
		public static void DrivenLocalTranslation_op_Inequality()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x117DA8C", Offset = "0x117DA8C", VA = "0x117DA8C")]
		[Preserve]
		public static void DrivenRectTransform_op_Equality()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x117DB5C", Offset = "0x117DB5C", VA = "0x117DB5C")]
		[Preserve]
		public static void DrivenRectTransform_op_Implicit()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x117DC24", Offset = "0x117DC24", VA = "0x117DC24")]
		[Preserve]
		public static void DrivenRectTransform_op_Inequality()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x117DCF4", Offset = "0x117DCF4", VA = "0x117DCF4")]
		[Preserve]
		public static void DrivenRelativeTransform_op_Equality()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x117DDC4", Offset = "0x117DDC4", VA = "0x117DDC4")]
		[Preserve]
		public static void DrivenRelativeTransform_op_Implicit()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x117DE8C", Offset = "0x117DE8C", VA = "0x117DE8C")]
		[Preserve]
		public static void DrivenRelativeTransform_op_Inequality()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x117DF5C", Offset = "0x117DF5C", VA = "0x117DF5C")]
		[Preserve]
		public static void DynamicCogSystem_op_Equality()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x117E02C", Offset = "0x117E02C", VA = "0x117E02C")]
		[Preserve]
		public static void DynamicCogSystem_op_Implicit()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x117E0F4", Offset = "0x117E0F4", VA = "0x117E0F4")]
		[Preserve]
		public static void DynamicCogSystem_op_Inequality()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x117E1C4", Offset = "0x117E1C4", VA = "0x117E1C4")]
		[Preserve]
		public static void EditorTestUI_op_Equality()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x117E294", Offset = "0x117E294", VA = "0x117E294")]
		[Preserve]
		public static void EditorTestUI_op_Implicit()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x117E35C", Offset = "0x117E35C", VA = "0x117E35C")]
		[Preserve]
		public static void EditorTestUI_op_Inequality()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x117E42C", Offset = "0x117E42C", VA = "0x117E42C")]
		[Preserve]
		public static void EgyptButtonPanel_op_Equality()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x117E4FC", Offset = "0x117E4FC", VA = "0x117E4FC")]
		[Preserve]
		public static void EgyptButtonPanel_op_Implicit()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x117E5C4", Offset = "0x117E5C4", VA = "0x117E5C4")]
		[Preserve]
		public static void EgyptButtonPanel_op_Inequality()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x117E694", Offset = "0x117E694", VA = "0x117E694")]
		[Preserve]
		public static void EgyptCanopicJar_op_Equality()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x117E764", Offset = "0x117E764", VA = "0x117E764")]
		[Preserve]
		public static void EgyptCanopicJar_op_Implicit()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x117E82C", Offset = "0x117E82C", VA = "0x117E82C")]
		[Preserve]
		public static void EgyptCanopicJar_op_Inequality()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x117E8FC", Offset = "0x117E8FC", VA = "0x117E8FC")]
		[Preserve]
		public static void EgyptCanopicMaze_IsPuzzleActive()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x117E930", Offset = "0x117E930", VA = "0x117E930")]
		[Preserve]
		public static void EgyptCanopicMaze_IsPuzzleSolved()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x117E964", Offset = "0x117E964", VA = "0x117E964")]
		[Preserve]
		public static void EgyptCanopicMaze_op_Equality()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x117EA34", Offset = "0x117EA34", VA = "0x117EA34")]
		[Preserve]
		public static void EgyptCanopicMaze_op_Implicit()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x117EAFC", Offset = "0x117EAFC", VA = "0x117EAFC")]
		[Preserve]
		public static void EgyptCanopicMaze_op_Inequality()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x117EBCC", Offset = "0x117EBCC", VA = "0x117EBCC")]
		[Preserve]
		public static void EgyptCanopicMaze_SetPuzzleActive()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x117EC00", Offset = "0x117EC00", VA = "0x117EC00")]
		[Preserve]
		public static void EgyptCanopicMaze_SetPuzzleSolved()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x117EC34", Offset = "0x117EC34", VA = "0x117EC34")]
		[Preserve]
		public static void EgyptCanopicMazeSpinner_op_Equality()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x117ED04", Offset = "0x117ED04", VA = "0x117ED04")]
		[Preserve]
		public static void EgyptCanopicMazeSpinner_op_Implicit()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x117EDCC", Offset = "0x117EDCC", VA = "0x117EDCC")]
		[Preserve]
		public static void EgyptCanopicMazeSpinner_op_Inequality()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x117EE9C", Offset = "0x117EE9C", VA = "0x117EE9C")]
		[Preserve]
		public static void EgyptGlobe_IsSolved()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x117EED0", Offset = "0x117EED0", VA = "0x117EED0")]
		[Preserve]
		public static void EgyptGlobe_op_Equality()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x117EFA0", Offset = "0x117EFA0", VA = "0x117EFA0")]
		[Preserve]
		public static void EgyptGlobe_op_Implicit()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x117F068", Offset = "0x117F068", VA = "0x117F068")]
		[Preserve]
		public static void EgyptGlobe_op_Inequality()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x117F138", Offset = "0x117F138", VA = "0x117F138")]
		[Preserve]
		public static void EgyptGoggleSliderSwitches_op_Equality()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x117F208", Offset = "0x117F208", VA = "0x117F208")]
		[Preserve]
		public static void EgyptGoggleSliderSwitches_op_Implicit()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x117F2D0", Offset = "0x117F2D0", VA = "0x117F2D0")]
		[Preserve]
		public static void EgyptGoggleSliderSwitches_op_Inequality()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x117F3A0", Offset = "0x117F3A0", VA = "0x117F3A0")]
		[Preserve]
		public static void EgyptLaserPuzzle_op_Equality()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x117F470", Offset = "0x117F470", VA = "0x117F470")]
		[Preserve]
		public static void EgyptLaserPuzzle_op_Implicit()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x117F538", Offset = "0x117F538", VA = "0x117F538")]
		[Preserve]
		public static void EgyptLaserPuzzle_op_Inequality()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x117F608", Offset = "0x117F608", VA = "0x117F608")]
		[Preserve]
		public static void EgyptLiftClasp_IsPinExtended()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x117F63C", Offset = "0x117F63C", VA = "0x117F63C")]
		[Preserve]
		public static void EgyptLiftClasp_Lock()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x117F670", Offset = "0x117F670", VA = "0x117F670")]
		[Preserve]
		public static void EgyptLiftClasp_op_Equality()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x117F740", Offset = "0x117F740", VA = "0x117F740")]
		[Preserve]
		public static void EgyptLiftClasp_op_Implicit()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x117F808", Offset = "0x117F808", VA = "0x117F808")]
		[Preserve]
		public static void EgyptLiftClasp_op_Inequality()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x117F8D8", Offset = "0x117F8D8", VA = "0x117F8D8")]
		[Preserve]
		public static void EgyptSarcophagus_op_Equality()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x117F9A8", Offset = "0x117F9A8", VA = "0x117F9A8")]
		[Preserve]
		public static void EgyptSarcophagus_op_Implicit()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x117FA70", Offset = "0x117FA70", VA = "0x117FA70")]
		[Preserve]
		public static void EgyptSarcophagus_op_Inequality()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x117FB40", Offset = "0x117FB40", VA = "0x117FB40")]
		[Preserve]
		public static void EgyptSarcophagus_SetPulledOut()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x117FB74", Offset = "0x117FB74", VA = "0x117FB74")]
		[Preserve]
		public static void EgyptSarcSpinners_op_Equality()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x117FC44", Offset = "0x117FC44", VA = "0x117FC44")]
		[Preserve]
		public static void EgyptSarcSpinners_op_Implicit()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x117FD0C", Offset = "0x117FD0C", VA = "0x117FD0C")]
		[Preserve]
		public static void EgyptSarcSpinners_op_Inequality()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x117FDDC", Offset = "0x117FDDC", VA = "0x117FDDC")]
		[Preserve]
		public static void EgyptSarcSpinners_SetState()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x117FE10", Offset = "0x117FE10", VA = "0x117FE10")]
		[Preserve]
		public static void EgyptScalesRope_ActivatePuzzle()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x117FE44", Offset = "0x117FE44", VA = "0x117FE44")]
		[Preserve]
		public static void EgyptScalesRope_op_Equality()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x117FF14", Offset = "0x117FF14", VA = "0x117FF14")]
		[Preserve]
		public static void EgyptScalesRope_op_Implicit()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x117FFDC", Offset = "0x117FFDC", VA = "0x117FFDC")]
		[Preserve]
		public static void EgyptScalesRope_op_Inequality()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x11800AC", Offset = "0x11800AC", VA = "0x11800AC")]
		[Preserve]
		public static void EgyptTabletHoloBlade_op_Equality()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x118017C", Offset = "0x118017C", VA = "0x118017C")]
		[Preserve]
		public static void EgyptTabletHoloBlade_op_Implicit()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1180244", Offset = "0x1180244", VA = "0x1180244")]
		[Preserve]
		public static void EgyptTabletHoloBlade_op_Inequality()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1180314", Offset = "0x1180314", VA = "0x1180314")]
		[Preserve]
		public static void EgyptTabletHoloHammer_op_Equality()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x11803E4", Offset = "0x11803E4", VA = "0x11803E4")]
		[Preserve]
		public static void EgyptTabletHoloHammer_op_Implicit()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x11804AC", Offset = "0x11804AC", VA = "0x11804AC")]
		[Preserve]
		public static void EgyptTabletHoloHammer_op_Inequality()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x118057C", Offset = "0x118057C", VA = "0x118057C")]
		[Preserve]
		public static void EgyptTabletPortal_op_Equality()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x118064C", Offset = "0x118064C", VA = "0x118064C")]
		[Preserve]
		public static void EgyptTabletPortal_op_Implicit()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1180714", Offset = "0x1180714", VA = "0x1180714")]
		[Preserve]
		public static void EgyptTabletPortal_op_Inequality()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x11807E4", Offset = "0x11807E4", VA = "0x11807E4")]
		[Preserve]
		public static void EmissionPulser_Activate()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1180818", Offset = "0x1180818", VA = "0x1180818")]
		[Preserve]
		public static void EmissionPulser_DeActivate()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x118084C", Offset = "0x118084C", VA = "0x118084C")]
		[Preserve]
		public static void EmissionPulser_op_Equality()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x118091C", Offset = "0x118091C", VA = "0x118091C")]
		[Preserve]
		public static void EmissionPulser_op_Implicit()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x11809E4", Offset = "0x11809E4", VA = "0x11809E4")]
		[Preserve]
		public static void EmissionPulser_op_Inequality()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1180AB4", Offset = "0x1180AB4", VA = "0x1180AB4")]
		[Preserve]
		public static void EnableComponentFromQualitySetting_op_Equality()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1180B84", Offset = "0x1180B84", VA = "0x1180B84")]
		[Preserve]
		public static void EnableComponentFromQualitySetting_op_Implicit()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1180C4C", Offset = "0x1180C4C", VA = "0x1180C4C")]
		[Preserve]
		public static void EnableComponentFromQualitySetting_op_Inequality()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1180D1C", Offset = "0x1180D1C", VA = "0x1180D1C")]
		[Preserve]
		public static void EndGameMenuScreen_op_Equality()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1180DEC", Offset = "0x1180DEC", VA = "0x1180DEC")]
		[Preserve]
		public static void EndGameMenuScreen_op_Implicit()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1180EB4", Offset = "0x1180EB4", VA = "0x1180EB4")]
		[Preserve]
		public static void EndGameMenuScreen_op_Inequality()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1180F84", Offset = "0x1180F84", VA = "0x1180F84")]
		[Preserve]
		public static void EventSystemSingleton_op_Equality()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1181054", Offset = "0x1181054", VA = "0x1181054")]
		[Preserve]
		public static void EventSystemSingleton_op_Implicit()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x118111C", Offset = "0x118111C", VA = "0x118111C")]
		[Preserve]
		public static void EventSystemSingleton_op_Inequality()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x11811EC", Offset = "0x11811EC", VA = "0x11811EC")]
		[Preserve]
		public static void EvidenceLocker_op_Equality()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x11812BC", Offset = "0x11812BC", VA = "0x11812BC")]
		[Preserve]
		public static void EvidenceLocker_op_Implicit()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1181384", Offset = "0x1181384", VA = "0x1181384")]
		[Preserve]
		public static void EvidenceLocker_op_Inequality()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1181454", Offset = "0x1181454", VA = "0x1181454")]
		[Preserve]
		public static void FaceCamera_op_Equality()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1181524", Offset = "0x1181524", VA = "0x1181524")]
		[Preserve]
		public static void FaceCamera_op_Implicit()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x11815EC", Offset = "0x11815EC", VA = "0x11815EC")]
		[Preserve]
		public static void FaceCamera_op_Inequality()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x11816BC", Offset = "0x11816BC", VA = "0x11816BC")]
		[Preserve]
		public static void FadeManager_op_Equality()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x118178C", Offset = "0x118178C", VA = "0x118178C")]
		[Preserve]
		public static void FadeManager_op_Implicit()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1181854", Offset = "0x1181854", VA = "0x1181854")]
		[Preserve]
		public static void FadeManager_op_Inequality()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1181924", Offset = "0x1181924", VA = "0x1181924")]
		[Preserve]
		public static void FadeReasons_op_Equality()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x11819F4", Offset = "0x11819F4", VA = "0x11819F4")]
		[Preserve]
		public static void FadeReasons_op_Implicit()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1181ABC", Offset = "0x1181ABC", VA = "0x1181ABC")]
		[Preserve]
		public static void FadeReasons_op_Inequality()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1181B8C", Offset = "0x1181B8C", VA = "0x1181B8C")]
		[Preserve]
		public static void FbxReference_op_Equality()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1181C5C", Offset = "0x1181C5C", VA = "0x1181C5C")]
		[Preserve]
		public static void FbxReference_op_Implicit()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1181D24", Offset = "0x1181D24", VA = "0x1181D24")]
		[Preserve]
		public static void FbxReference_op_Inequality()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1181DF4", Offset = "0x1181DF4", VA = "0x1181DF4")]
		[Preserve]
		public static void FinalRoomTableGroup_op_Equality()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1181EC4", Offset = "0x1181EC4", VA = "0x1181EC4")]
		[Preserve]
		public static void FinalRoomTableGroup_op_Implicit()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1181F8C", Offset = "0x1181F8C", VA = "0x1181F8C")]
		[Preserve]
		public static void FinalRoomTableGroup_op_Inequality()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x118205C", Offset = "0x118205C", VA = "0x118205C")]
		[Preserve]
		public static void FireCube_op_Equality()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x118212C", Offset = "0x118212C", VA = "0x118212C")]
		[Preserve]
		public static void FireCube_op_Implicit()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x11821F4", Offset = "0x11821F4", VA = "0x11821F4")]
		[Preserve]
		public static void FireCube_op_Inequality()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x11822C4", Offset = "0x11822C4", VA = "0x11822C4")]
		[Preserve]
		public static void Fireproof_Audio_AnimationAudio_op_Equality()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1182394", Offset = "0x1182394", VA = "0x1182394")]
		[Preserve]
		public static void Fireproof_Audio_AnimationAudio_op_Implicit()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x118245C", Offset = "0x118245C", VA = "0x118245C")]
		[Preserve]
		public static void Fireproof_Audio_AnimationAudio_op_Inequality()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x118252C", Offset = "0x118252C", VA = "0x118252C")]
		[Preserve]
		public static void Fireproof_Audio_AudioBank_op_Equality()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x11825FC", Offset = "0x11825FC", VA = "0x11825FC")]
		[Preserve]
		public static void Fireproof_Audio_AudioBank_op_Implicit()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x11826C4", Offset = "0x11826C4", VA = "0x11826C4")]
		[Preserve]
		public static void Fireproof_Audio_AudioBank_op_Inequality()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1182794", Offset = "0x1182794", VA = "0x1182794")]
		[Preserve]
		public static void Fireproof_Audio_AudioBankLoader_op_Equality()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1182864", Offset = "0x1182864", VA = "0x1182864")]
		[Preserve]
		public static void Fireproof_Audio_AudioBankLoader_op_Implicit()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x118292C", Offset = "0x118292C", VA = "0x118292C")]
		[Preserve]
		public static void Fireproof_Audio_AudioBankLoader_op_Inequality()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x11829FC", Offset = "0x11829FC", VA = "0x11829FC")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventData_op_Equality()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1182ACC", Offset = "0x1182ACC", VA = "0x1182ACC")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventData_op_Implicit()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1182B94", Offset = "0x1182B94", VA = "0x1182B94")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventData_op_Inequality()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1182C64", Offset = "0x1182C64", VA = "0x1182C64")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventData_SelectRandom_op_Equality()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1182D34", Offset = "0x1182D34", VA = "0x1182D34")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventData_SelectRandom_op_Implicit()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1182DFC", Offset = "0x1182DFC", VA = "0x1182DFC")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventData_SelectRandom_op_Inequality()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1182ECC", Offset = "0x1182ECC", VA = "0x1182ECC")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventData_StartAndLoop_op_Equality()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1182F9C", Offset = "0x1182F9C", VA = "0x1182F9C")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventData_StartAndLoop_op_Implicit()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1183064", Offset = "0x1183064", VA = "0x1183064")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventData_StartAndLoop_op_Inequality()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1183134", Offset = "0x1183134", VA = "0x1183134")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventPropertyController_op_Equality()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1183204", Offset = "0x1183204", VA = "0x1183204")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventPropertyController_op_Implicit()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x11832CC", Offset = "0x11832CC", VA = "0x11832CC")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventPropertyController_op_Inequality()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x118339C", Offset = "0x118339C", VA = "0x118339C")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSource_IsPlaying()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x11833D0", Offset = "0x11833D0", VA = "0x11833D0")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSource_op_Equality()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x11834A0", Offset = "0x11834A0", VA = "0x11834A0")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSource_op_Implicit()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1183568", Offset = "0x1183568", VA = "0x1183568")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSource_op_Inequality()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1183638", Offset = "0x1183638", VA = "0x1183638")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSource_Play()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x118366C", Offset = "0x118366C", VA = "0x118366C")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSource_Stop()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x11836A0", Offset = "0x11836A0", VA = "0x11836A0")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSourceSaver_op_Equality()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1183770", Offset = "0x1183770", VA = "0x1183770")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSourceSaver_op_Implicit()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1183838", Offset = "0x1183838", VA = "0x1183838")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSourceSaver_op_Inequality()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1183908", Offset = "0x1183908", VA = "0x1183908")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSourceVolumeController_Fade()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x118393C", Offset = "0x118393C", VA = "0x118393C")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSourceVolumeController_op_Equality()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1183A0C", Offset = "0x1183A0C", VA = "0x1183A0C")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSourceVolumeController_op_Implicit()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1183AD4", Offset = "0x1183AD4", VA = "0x1183AD4")]
		[Preserve]
		public static void Fireproof_Audio_AudioEventSourceVolumeController_op_Inequality()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1183BA4", Offset = "0x1183BA4", VA = "0x1183BA4")]
		[Preserve]
		public static void Fireproof_Audio_AudioManager_op_Equality()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1183C74", Offset = "0x1183C74", VA = "0x1183C74")]
		[Preserve]
		public static void Fireproof_Audio_AudioManager_op_Implicit()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1183D3C", Offset = "0x1183D3C", VA = "0x1183D3C")]
		[Preserve]
		public static void Fireproof_Audio_AudioManager_op_Inequality()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1183E0C", Offset = "0x1183E0C", VA = "0x1183E0C")]
		[Preserve]
		public static void Fireproof_Audio_AudioManager_Play()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1183F64", Offset = "0x1183F64", VA = "0x1183F64")]
		[Preserve]
		public static void FixedLimitRotationRopeSystem_op_Equality()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1184034", Offset = "0x1184034", VA = "0x1184034")]
		[Preserve]
		public static void FixedLimitRotationRopeSystem_op_Implicit()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x11840FC", Offset = "0x11840FC", VA = "0x11840FC")]
		[Preserve]
		public static void FixedLimitRotationRopeSystem_op_Inequality()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x11841CC", Offset = "0x11841CC", VA = "0x11841CC")]
		[Preserve]
		public static void FlameDeformer_op_Equality()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x118429C", Offset = "0x118429C", VA = "0x118429C")]
		[Preserve]
		public static void FlameDeformer_op_Implicit()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1184364", Offset = "0x1184364", VA = "0x1184364")]
		[Preserve]
		public static void FlameDeformer_op_Inequality()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1184434", Offset = "0x1184434", VA = "0x1184434")]
		[Preserve]
		public static void Flammable_op_Equality()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1184504", Offset = "0x1184504", VA = "0x1184504")]
		[Preserve]
		public static void Flammable_op_Implicit()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x11845CC", Offset = "0x11845CC", VA = "0x11845CC")]
		[Preserve]
		public static void Flammable_op_Inequality()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x118469C", Offset = "0x118469C", VA = "0x118469C")]
		[Preserve]
		public static void Flammable_SetCanLightFlamables()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x11846D0", Offset = "0x11846D0", VA = "0x11846D0")]
		[Preserve]
		public static void Flash_IsAnimatedIn()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1184704", Offset = "0x1184704", VA = "0x1184704")]
		[Preserve]
		public static void Flash_IsFinished()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1184738", Offset = "0x1184738", VA = "0x1184738")]
		[Preserve]
		public static void Flash_op_Equality()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1184808", Offset = "0x1184808", VA = "0x1184808")]
		[Preserve]
		public static void Flash_op_Implicit()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x11848D0", Offset = "0x11848D0", VA = "0x11848D0")]
		[Preserve]
		public static void Flash_op_Inequality()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x11849A0", Offset = "0x11849A0", VA = "0x11849A0")]
		[Preserve]
		public static void Flash_StartFlash()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x11849D4", Offset = "0x11849D4", VA = "0x11849D4")]
		[Preserve]
		public static void float_op_Equality()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1184AAC", Offset = "0x1184AAC", VA = "0x1184AAC")]
		[Preserve]
		public static void float_op_GreaterThan()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1184B84", Offset = "0x1184B84", VA = "0x1184B84")]
		[Preserve]
		public static void float_op_GreaterThanOrEqual()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1184C5C", Offset = "0x1184C5C", VA = "0x1184C5C")]
		[Preserve]
		public static void float_op_Inequality()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1184D34", Offset = "0x1184D34", VA = "0x1184D34")]
		[Preserve]
		public static void float_op_LessThan()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1184E0C", Offset = "0x1184E0C", VA = "0x1184E0C")]
		[Preserve]
		public static void float_op_LessThanOrEqual()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1184EE4", Offset = "0x1184EE4", VA = "0x1184EE4")]
		[Preserve]
		public static void FollowTransformPath_op_Equality()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1184FB4", Offset = "0x1184FB4", VA = "0x1184FB4")]
		[Preserve]
		public static void FollowTransformPath_op_Implicit()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x118507C", Offset = "0x118507C", VA = "0x118507C")]
		[Preserve]
		public static void FollowTransformPath_op_Inequality()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x118514C", Offset = "0x118514C", VA = "0x118514C")]
		[Preserve]
		public static void ForceMipBias_op_Equality()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x118521C", Offset = "0x118521C", VA = "0x118521C")]
		[Preserve]
		public static void ForceMipBias_op_Implicit()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x11852E4", Offset = "0x11852E4", VA = "0x11852E4")]
		[Preserve]
		public static void ForceMipBias_op_Inequality()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x11853B4", Offset = "0x11853B4", VA = "0x11853B4")]
		[Preserve]
		public static void ForceRenderQueue_op_Equality()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1185484", Offset = "0x1185484", VA = "0x1185484")]
		[Preserve]
		public static void ForceRenderQueue_op_Implicit()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x118554C", Offset = "0x118554C", VA = "0x118554C")]
		[Preserve]
		public static void ForceRenderQueue_op_Inequality()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x118561C", Offset = "0x118561C", VA = "0x118561C")]
		[Preserve]
		public static void FPInputBase_op_Equality()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x11856EC", Offset = "0x11856EC", VA = "0x11856EC")]
		[Preserve]
		public static void FPInputBase_op_Implicit()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x11857B4", Offset = "0x11857B4", VA = "0x11857B4")]
		[Preserve]
		public static void FPInputBase_op_Inequality()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1185884", Offset = "0x1185884", VA = "0x1185884")]
		[Preserve]
		public static void FPInputRewired_op_Equality()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1185954", Offset = "0x1185954", VA = "0x1185954")]
		[Preserve]
		public static void FPInputRewired_op_Implicit()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1185A1C", Offset = "0x1185A1C", VA = "0x1185A1C")]
		[Preserve]
		public static void FPInputRewired_op_Inequality()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1185AEC", Offset = "0x1185AEC", VA = "0x1185AEC")]
		[Preserve]
		public static void FrameRateManager_op_Equality()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1185BBC", Offset = "0x1185BBC", VA = "0x1185BBC")]
		[Preserve]
		public static void FrameRateManager_op_Implicit()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1185C84", Offset = "0x1185C84", VA = "0x1185C84")]
		[Preserve]
		public static void FrameRateManager_op_Inequality()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1185D54", Offset = "0x1185D54", VA = "0x1185D54")]
		[Preserve]
		public static void FrameRateWarning_op_Equality()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1185E24", Offset = "0x1185E24", VA = "0x1185E24")]
		[Preserve]
		public static void FrameRateWarning_op_Implicit()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1185EEC", Offset = "0x1185EEC", VA = "0x1185EEC")]
		[Preserve]
		public static void FrameRateWarning_op_Inequality()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1185FBC", Offset = "0x1185FBC", VA = "0x1185FBC")]
		[Preserve]
		public static void FrontendMenuController_op_Equality()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x118608C", Offset = "0x118608C", VA = "0x118608C")]
		[Preserve]
		public static void FrontendMenuController_op_Implicit()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1186154", Offset = "0x1186154", VA = "0x1186154")]
		[Preserve]
		public static void FrontendMenuController_op_Inequality()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1186224", Offset = "0x1186224", VA = "0x1186224")]
		[Preserve]
		public static void FrontEndPointer_op_Equality()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x11862F4", Offset = "0x11862F4", VA = "0x11862F4")]
		[Preserve]
		public static void FrontEndPointer_op_Implicit()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x11863BC", Offset = "0x11863BC", VA = "0x11863BC")]
		[Preserve]
		public static void FrontEndPointer_op_Inequality()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x118648C", Offset = "0x118648C", VA = "0x118648C")]
		[Preserve]
		public static void GameCompleteScreen_op_Equality()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x118655C", Offset = "0x118655C", VA = "0x118655C")]
		[Preserve]
		public static void GameCompleteScreen_op_Implicit()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1186624", Offset = "0x1186624", VA = "0x1186624")]
		[Preserve]
		public static void GameCompleteScreen_op_Inequality()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x11866F4", Offset = "0x11866F4", VA = "0x11866F4")]
		[Preserve]
		public static void GameEventBase_op_Equality()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x11867C4", Offset = "0x11867C4", VA = "0x11867C4")]
		[Preserve]
		public static void GameEventBase_op_Implicit()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x118688C", Offset = "0x118688C", VA = "0x118688C")]
		[Preserve]
		public static void GameEventBase_op_Inequality()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x118695C", Offset = "0x118695C", VA = "0x118695C")]
		[Preserve]
		public static void GameObjectActiveSaver_op_Equality()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1186A2C", Offset = "0x1186A2C", VA = "0x1186A2C")]
		[Preserve]
		public static void GameObjectActiveSaver_op_Implicit()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1186AF4", Offset = "0x1186AF4", VA = "0x1186AF4")]
		[Preserve]
		public static void GameObjectActiveSaver_op_Inequality()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1186BC4", Offset = "0x1186BC4", VA = "0x1186BC4")]
		[Preserve]
		public static void GameStateManager_CacheScreenshotForLevelAchievement()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1186C5C", Offset = "0x1186C5C", VA = "0x1186C5C")]
		[Preserve]
		public static void GameStateManager_GiveCurrentLevelAchievement()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1186CF4", Offset = "0x1186CF4", VA = "0x1186CF4")]
		[Preserve]
		public static void GameStateManager_IsDemoBuild()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1186D94", Offset = "0x1186D94", VA = "0x1186D94")]
		[Preserve]
		public static void GameStateManager_op_Equality()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1186E64", Offset = "0x1186E64", VA = "0x1186E64")]
		[Preserve]
		public static void GameStateManager_op_Implicit()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1186F2C", Offset = "0x1186F2C", VA = "0x1186F2C")]
		[Preserve]
		public static void GameStateManager_op_Inequality()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1186FFC", Offset = "0x1186FFC", VA = "0x1186FFC")]
		[Preserve]
		public static void GameStateManager_SetCurrentLevelComplete()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1187094", Offset = "0x1187094", VA = "0x1187094")]
		[Preserve]
		public static void GarbageCollectionManager_op_Equality()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1187164", Offset = "0x1187164", VA = "0x1187164")]
		[Preserve]
		public static void GarbageCollectionManager_op_Implicit()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x118722C", Offset = "0x118722C", VA = "0x118722C")]
		[Preserve]
		public static void GarbageCollectionManager_op_Inequality()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x11872FC", Offset = "0x11872FC", VA = "0x11872FC")]
		[Preserve]
		public static void GDCMenuScreen_op_Equality()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x11873CC", Offset = "0x11873CC", VA = "0x11873CC")]
		[Preserve]
		public static void GDCMenuScreen_op_Implicit()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1187494", Offset = "0x1187494", VA = "0x1187494")]
		[Preserve]
		public static void GDCMenuScreen_op_Inequality()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1187564", Offset = "0x1187564", VA = "0x1187564")]
		[Preserve]
		public static void GeometryImposter_op_Equality()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1187634", Offset = "0x1187634", VA = "0x1187634")]
		[Preserve]
		public static void GeometryImposter_op_Implicit()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x11876FC", Offset = "0x11876FC", VA = "0x11876FC")]
		[Preserve]
		public static void GeometryImposter_op_Inequality()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x11877CC", Offset = "0x11877CC", VA = "0x11877CC")]
		[Preserve]
		public static void GiveInventoryItemOnStart_op_Equality()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x118789C", Offset = "0x118789C", VA = "0x118789C")]
		[Preserve]
		public static void GiveInventoryItemOnStart_op_Implicit()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1187964", Offset = "0x1187964", VA = "0x1187964")]
		[Preserve]
		public static void GiveInventoryItemOnStart_op_Inequality()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1187A34", Offset = "0x1187A34", VA = "0x1187A34")]
		[Preserve]
		public static void GlobalGameEvent_op_Equality()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1187B04", Offset = "0x1187B04", VA = "0x1187B04")]
		[Preserve]
		public static void GlobalGameEvent_op_Implicit()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1187BCC", Offset = "0x1187BCC", VA = "0x1187BCC")]
		[Preserve]
		public static void GlobalGameEvent_op_Inequality()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1187C9C", Offset = "0x1187C9C", VA = "0x1187C9C")]
		[Preserve]
		public static void GlobalGameEventListener_op_Equality()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1187D6C", Offset = "0x1187D6C", VA = "0x1187D6C")]
		[Preserve]
		public static void GlobalGameEventListener_op_Implicit()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1187E34", Offset = "0x1187E34", VA = "0x1187E34")]
		[Preserve]
		public static void GlobalGameEventListener_op_Inequality()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1187F04", Offset = "0x1187F04", VA = "0x1187F04")]
		[Preserve]
		public static void GoggleDissolveController_op_Equality()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1187FD4", Offset = "0x1187FD4", VA = "0x1187FD4")]
		[Preserve]
		public static void GoggleDissolveController_op_Implicit()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x118809C", Offset = "0x118809C", VA = "0x118809C")]
		[Preserve]
		public static void GoggleDissolveController_op_Inequality()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x118816C", Offset = "0x118816C", VA = "0x118816C")]
		[Preserve]
		public static void GoggleDissolveController_SetActive()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x11881A0", Offset = "0x11881A0", VA = "0x11881A0")]
		[Preserve]
		public static void Goggles_DeactivateGoggles()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x11881D4", Offset = "0x11881D4", VA = "0x11881D4")]
		[Preserve]
		public static void Goggles_GetHasLens()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1188208", Offset = "0x1188208", VA = "0x1188208")]
		[Preserve]
		public static void Goggles_GogglesFogEndDistance()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x118823C", Offset = "0x118823C", VA = "0x118823C")]
		[Preserve]
		public static void Goggles_GogglesFogStartDistance()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1188270", Offset = "0x1188270", VA = "0x1188270")]
		[Preserve]
		public static void Goggles_IsActive()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x11882A4", Offset = "0x11882A4", VA = "0x11882A4")]
		[Preserve]
		public static void Goggles_OnLensEquipped()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x11882D8", Offset = "0x11882D8", VA = "0x11882D8")]
		[Preserve]
		public static void Goggles_op_Equality()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x11883A8", Offset = "0x11883A8", VA = "0x11883A8")]
		[Preserve]
		public static void Goggles_op_Implicit()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1188470", Offset = "0x1188470", VA = "0x1188470")]
		[Preserve]
		public static void Goggles_op_Inequality()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1188540", Offset = "0x1188540", VA = "0x1188540")]
		[Preserve]
		public static void Goggles_UpdateGogglesShader()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1188574", Offset = "0x1188574", VA = "0x1188574")]
		[Preserve]
		public static void GogglesHudManager_EnableGogglesHud()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1188638", Offset = "0x1188638", VA = "0x1188638")]
		[Preserve]
		public static void GogglesHudManager_op_Equality()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1188708", Offset = "0x1188708", VA = "0x1188708")]
		[Preserve]
		public static void GogglesHudManager_op_Implicit()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x11887D0", Offset = "0x11887D0", VA = "0x11887D0")]
		[Preserve]
		public static void GogglesHudManager_op_Inequality()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x11888A0", Offset = "0x11888A0", VA = "0x11888A0")]
		[Preserve]
		public static void GogglesHudManager_SetGogglesFlash()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1188964", Offset = "0x1188964", VA = "0x1188964")]
		[Preserve]
		public static void GogglesItemGrabbable_op_Equality()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1188A34", Offset = "0x1188A34", VA = "0x1188A34")]
		[Preserve]
		public static void GogglesItemGrabbable_op_Implicit()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1188AFC", Offset = "0x1188AFC", VA = "0x1188AFC")]
		[Preserve]
		public static void GogglesItemGrabbable_op_Inequality()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1188BCC", Offset = "0x1188BCC", VA = "0x1188BCC")]
		[Preserve]
		public static void GogglesSheenController_Flash()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1188C00", Offset = "0x1188C00", VA = "0x1188C00")]
		[Preserve]
		public static void GogglesSheenController_op_Equality()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1188CD0", Offset = "0x1188CD0", VA = "0x1188CD0")]
		[Preserve]
		public static void GogglesSheenController_op_Implicit()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1188D98", Offset = "0x1188D98", VA = "0x1188D98")]
		[Preserve]
		public static void GogglesSheenController_op_Inequality()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1188E68", Offset = "0x1188E68", VA = "0x1188E68")]
		[Preserve]
		public static void GogglesSheenController_SetSheen()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1188E9C", Offset = "0x1188E9C", VA = "0x1188E9C")]
		[Preserve]
		public static void GogglesSheenController_SetTargetSheen()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1188ED0", Offset = "0x1188ED0", VA = "0x1188ED0")]
		[Preserve]
		public static void GogglesVisibility_op_Equality()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1188FA0", Offset = "0x1188FA0", VA = "0x1188FA0")]
		[Preserve]
		public static void GogglesVisibility_op_Implicit()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1189068", Offset = "0x1189068", VA = "0x1189068")]
		[Preserve]
		public static void GogglesVisibility_op_Inequality()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1189138", Offset = "0x1189138", VA = "0x1189138")]
		[Preserve]
		public static void GogglesVisibility_SetVisibleWithGoggles()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x118916C", Offset = "0x118916C", VA = "0x118916C")]
		[Preserve]
		public static void GogglesVisibility_SetVisibleWithGogglesLens()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x11891A0", Offset = "0x11891A0", VA = "0x11891A0")]
		[Preserve]
		public static void Goop_Activated()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x11891D4", Offset = "0x11891D4", VA = "0x11891D4")]
		[Preserve]
		public static void Goop_op_Equality()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x11892A4", Offset = "0x11892A4", VA = "0x11892A4")]
		[Preserve]
		public static void Goop_op_Implicit()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x118936C", Offset = "0x118936C", VA = "0x118936C")]
		[Preserve]
		public static void Goop_op_Inequality()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x118943C", Offset = "0x118943C", VA = "0x118943C")]
		[Preserve]
		public static void GoopAutoRipple_op_Equality()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x118950C", Offset = "0x118950C", VA = "0x118950C")]
		[Preserve]
		public static void GoopAutoRipple_op_Implicit()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x11895D4", Offset = "0x11895D4", VA = "0x11895D4")]
		[Preserve]
		public static void GoopAutoRipple_op_Inequality()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x11896A4", Offset = "0x11896A4", VA = "0x11896A4")]
		[Preserve]
		public static void GoopCover_op_Equality()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1189774", Offset = "0x1189774", VA = "0x1189774")]
		[Preserve]
		public static void GoopCover_op_Implicit()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x118983C", Offset = "0x118983C", VA = "0x118983C")]
		[Preserve]
		public static void GoopCover_op_Inequality()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x118990C", Offset = "0x118990C", VA = "0x118990C")]
		[Preserve]
		public static void GoopDisturbance_op_Equality()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x11899DC", Offset = "0x11899DC", VA = "0x11899DC")]
		[Preserve]
		public static void GoopDisturbance_op_Implicit()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1189AA4", Offset = "0x1189AA4", VA = "0x1189AA4")]
		[Preserve]
		public static void GoopDisturbance_op_Inequality()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1189B74", Offset = "0x1189B74", VA = "0x1189B74")]
		[Preserve]
		public static void GoopDisturbanceBase_op_Equality()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1189C44", Offset = "0x1189C44", VA = "0x1189C44")]
		[Preserve]
		public static void GoopDisturbanceBase_op_Implicit()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1189D0C", Offset = "0x1189D0C", VA = "0x1189D0C")]
		[Preserve]
		public static void GoopDisturbanceBase_op_Inequality()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1189DDC", Offset = "0x1189DDC", VA = "0x1189DDC")]
		[Preserve]
		public static void GoopPegBox_op_Equality()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1189EAC", Offset = "0x1189EAC", VA = "0x1189EAC")]
		[Preserve]
		public static void GoopPegBox_op_Implicit()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1189F74", Offset = "0x1189F74", VA = "0x1189F74")]
		[Preserve]
		public static void GoopPegBox_op_Inequality()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x118A044", Offset = "0x118A044", VA = "0x118A044")]
		[Preserve]
		public static void GoopPegSphere_enabled()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x118A078", Offset = "0x118A078", VA = "0x118A078")]
		[Preserve]
		public static void GoopPegSphere_op_Equality()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x118A148", Offset = "0x118A148", VA = "0x118A148")]
		[Preserve]
		public static void GoopPegSphere_op_Implicit()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x118A210", Offset = "0x118A210", VA = "0x118A210")]
		[Preserve]
		public static void GoopPegSphere_op_Inequality()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x118A2E0", Offset = "0x118A2E0", VA = "0x118A2E0")]
		[Preserve]
		public static void GoopRipple_op_Equality()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x118A3B0", Offset = "0x118A3B0", VA = "0x118A3B0")]
		[Preserve]
		public static void GoopRipple_op_Implicit()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x118A478", Offset = "0x118A478", VA = "0x118A478")]
		[Preserve]
		public static void GoopRipple_op_Inequality()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x118A548", Offset = "0x118A548", VA = "0x118A548")]
		[Preserve]
		public static void Grabbable_IsBeingHeld()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x118A57C", Offset = "0x118A57C", VA = "0x118A57C")]
		[Preserve]
		public static void Grabbable_IsInteractionInProgress()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x118A5B0", Offset = "0x118A5B0", VA = "0x118A5B0")]
		[Preserve]
		public static void Grabbable_op_Equality()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x118A680", Offset = "0x118A680", VA = "0x118A680")]
		[Preserve]
		public static void Grabbable_op_Implicit()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x118A748", Offset = "0x118A748", VA = "0x118A748")]
		[Preserve]
		public static void Grabbable_op_Inequality()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x118A818", Offset = "0x118A818", VA = "0x118A818")]
		[Preserve]
		public static void Grabbable_ReleaseGrab()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x118A84C", Offset = "0x118A84C", VA = "0x118A84C")]
		[Preserve]
		public static void Grabbable_SetSimulationState()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x118A880", Offset = "0x118A880", VA = "0x118A880")]
		[Preserve]
		public static void Grabbable_SetState()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x118A8B4", Offset = "0x118A8B4", VA = "0x118A8B4")]
		[Preserve]
		public static void Grabbable_SimulationState()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x118A8E8", Offset = "0x118A8E8", VA = "0x118A8E8")]
		[Preserve]
		public static void GrabbableBlockerCollider_op_Equality()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x118A9B8", Offset = "0x118A9B8", VA = "0x118A9B8")]
		[Preserve]
		public static void GrabbableBlockerCollider_op_Implicit()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x118AA80", Offset = "0x118AA80", VA = "0x118AA80")]
		[Preserve]
		public static void GrabbableBlockerCollider_op_Inequality()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x118AB50", Offset = "0x118AB50", VA = "0x118AB50")]
		[Preserve]
		public static void GrabbableBoxBlockerCollider_op_Equality()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x118AC20", Offset = "0x118AC20", VA = "0x118AC20")]
		[Preserve]
		public static void GrabbableBoxBlockerCollider_op_Implicit()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x118ACE8", Offset = "0x118ACE8", VA = "0x118ACE8")]
		[Preserve]
		public static void GrabbableBoxBlockerCollider_op_Inequality()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x118ADB8", Offset = "0x118ADB8", VA = "0x118ADB8")]
		[Preserve]
		public static void GrabbableCapsuleBlockerCollider_op_Equality()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x118AE88", Offset = "0x118AE88", VA = "0x118AE88")]
		[Preserve]
		public static void GrabbableCapsuleBlockerCollider_op_Implicit()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x118AF50", Offset = "0x118AF50", VA = "0x118AF50")]
		[Preserve]
		public static void GrabbableCapsuleBlockerCollider_op_Inequality()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x118B020", Offset = "0x118B020", VA = "0x118B020")]
		[Preserve]
		public static void GrabbableCollider_op_Equality()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x118B0F0", Offset = "0x118B0F0", VA = "0x118B0F0")]
		[Preserve]
		public static void GrabbableCollider_op_Implicit()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x118B1B8", Offset = "0x118B1B8", VA = "0x118B1B8")]
		[Preserve]
		public static void GrabbableCollider_op_Inequality()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x118B288", Offset = "0x118B288", VA = "0x118B288")]
		[Preserve]
		public static void GrabbableHandAnchor_op_Equality()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x118B358", Offset = "0x118B358", VA = "0x118B358")]
		[Preserve]
		public static void GrabbableHandAnchor_op_Implicit()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x118B420", Offset = "0x118B420", VA = "0x118B420")]
		[Preserve]
		public static void GrabbableHandAnchor_op_Inequality()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x118B4F0", Offset = "0x118B4F0", VA = "0x118B4F0")]
		[Preserve]
		public static void GrabbableHandAnchorCircle_op_Equality()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x118B5C0", Offset = "0x118B5C0", VA = "0x118B5C0")]
		[Preserve]
		public static void GrabbableHandAnchorCircle_op_Implicit()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x118B688", Offset = "0x118B688", VA = "0x118B688")]
		[Preserve]
		public static void GrabbableHandAnchorCircle_op_Inequality()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x118B758", Offset = "0x118B758", VA = "0x118B758")]
		[Preserve]
		public static void GrabbableHandAnchorKey_op_Equality()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x118B828", Offset = "0x118B828", VA = "0x118B828")]
		[Preserve]
		public static void GrabbableHandAnchorKey_op_Implicit()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x118B8F0", Offset = "0x118B8F0", VA = "0x118B8F0")]
		[Preserve]
		public static void GrabbableHandAnchorKey_op_Inequality()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x118B9C0", Offset = "0x118B9C0", VA = "0x118B9C0")]
		[Preserve]
		public static void GrabbableHandAnchorLine_op_Equality()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x118BA90", Offset = "0x118BA90", VA = "0x118BA90")]
		[Preserve]
		public static void GrabbableHandAnchorLine_op_Implicit()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x118BB58", Offset = "0x118BB58", VA = "0x118BB58")]
		[Preserve]
		public static void GrabbableHandAnchorLine_op_Inequality()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x118BC28", Offset = "0x118BC28", VA = "0x118BC28")]
		[Preserve]
		public static void GrabbableHandAnchorPivot_op_Equality()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x118BCF8", Offset = "0x118BCF8", VA = "0x118BCF8")]
		[Preserve]
		public static void GrabbableHandAnchorPivot_op_Implicit()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x118BDC0", Offset = "0x118BDC0", VA = "0x118BDC0")]
		[Preserve]
		public static void GrabbableHandAnchorPivot_op_Inequality()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x118BE90", Offset = "0x118BE90", VA = "0x118BE90")]
		[Preserve]
		public static void GrabbableHandAnchorPoint_op_Equality()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x118BF60", Offset = "0x118BF60", VA = "0x118BF60")]
		[Preserve]
		public static void GrabbableHandAnchorPoint_op_Implicit()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x118C028", Offset = "0x118C028", VA = "0x118C028")]
		[Preserve]
		public static void GrabbableHandAnchorPoint_op_Inequality()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x118C0F8", Offset = "0x118C0F8", VA = "0x118C0F8")]
		[Preserve]
		public static void GrabbableRumbleTrigger_op_Equality()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x118C1C8", Offset = "0x118C1C8", VA = "0x118C1C8")]
		[Preserve]
		public static void GrabbableRumbleTrigger_op_Implicit()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x118C290", Offset = "0x118C290", VA = "0x118C290")]
		[Preserve]
		public static void GrabbableRumbleTrigger_op_Inequality()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x118C360", Offset = "0x118C360", VA = "0x118C360")]
		[Preserve]
		public static void GrabbableSphereBlockerCollider_op_Equality()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x118C430", Offset = "0x118C430", VA = "0x118C430")]
		[Preserve]
		public static void GrabbableSphereBlockerCollider_op_Implicit()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x118C4F8", Offset = "0x118C4F8", VA = "0x118C4F8")]
		[Preserve]
		public static void GrabbableSphereBlockerCollider_op_Inequality()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x118C5C8", Offset = "0x118C5C8", VA = "0x118C5C8")]
		[Preserve]
		public static void GrabbableTrigger_Contains()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x118C5FC", Offset = "0x118C5FC", VA = "0x118C5FC")]
		[Preserve]
		public static void GrabbableTrigger_op_Equality()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x118C6CC", Offset = "0x118C6CC", VA = "0x118C6CC")]
		[Preserve]
		public static void GrabbableTrigger_op_Implicit()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x118C794", Offset = "0x118C794", VA = "0x118C794")]
		[Preserve]
		public static void GrabbableTrigger_op_Inequality()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x118C864", Offset = "0x118C864", VA = "0x118C864")]
		[Preserve]
		public static void GravityRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x118C934", Offset = "0x118C934", VA = "0x118C934")]
		[Preserve]
		public static void GravityRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x118C9FC", Offset = "0x118C9FC", VA = "0x118C9FC")]
		[Preserve]
		public static void GravityRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x118CACC", Offset = "0x118CACC", VA = "0x118CACC")]
		[Preserve]
		public static void GravitySliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x118CB9C", Offset = "0x118CB9C", VA = "0x118CB9C")]
		[Preserve]
		public static void GravitySliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x118CC64", Offset = "0x118CC64", VA = "0x118CC64")]
		[Preserve]
		public static void GravitySliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x118CD34", Offset = "0x118CD34", VA = "0x118CD34")]
		[Preserve]
		public static void GroundCover_op_Equality()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x118CE04", Offset = "0x118CE04", VA = "0x118CE04")]
		[Preserve]
		public static void GroundCover_op_Implicit()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x118CECC", Offset = "0x118CECC", VA = "0x118CECC")]
		[Preserve]
		public static void GroundCover_op_Inequality()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x118CF9C", Offset = "0x118CF9C", VA = "0x118CF9C")]
		[Preserve]
		public static void HandController_op_Equality()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x118D06C", Offset = "0x118D06C", VA = "0x118D06C")]
		[Preserve]
		public static void HandController_op_Implicit()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x118D134", Offset = "0x118D134", VA = "0x118D134")]
		[Preserve]
		public static void HandController_op_Inequality()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x118D204", Offset = "0x118D204", VA = "0x118D204")]
		[Preserve]
		public static void HandPoseDatabase_op_Equality()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x118D2D4", Offset = "0x118D2D4", VA = "0x118D2D4")]
		[Preserve]
		public static void HandPoseDatabase_op_Implicit()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x118D39C", Offset = "0x118D39C", VA = "0x118D39C")]
		[Preserve]
		public static void HandPoseDatabase_op_Inequality()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x118D46C", Offset = "0x118D46C", VA = "0x118D46C")]
		[Preserve]
		public static void HeadCollisionVolume_Disable()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x118D4A0", Offset = "0x118D4A0", VA = "0x118D4A0")]
		[Preserve]
		public static void HeadCollisionVolume_Enable()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x118D4D4", Offset = "0x118D4D4", VA = "0x118D4D4")]
		[Preserve]
		public static void HeadCollisionVolume_op_Equality()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x118D5A4", Offset = "0x118D5A4", VA = "0x118D5A4")]
		[Preserve]
		public static void HeadCollisionVolume_op_Implicit()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x118D66C", Offset = "0x118D66C", VA = "0x118D66C")]
		[Preserve]
		public static void HeadCollisionVolume_op_Inequality()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x118D73C", Offset = "0x118D73C", VA = "0x118D73C")]
		[Preserve]
		public static void HeadInsideGeometryHUD_op_Equality()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x118D80C", Offset = "0x118D80C", VA = "0x118D80C")]
		[Preserve]
		public static void HeadInsideGeometryHUD_op_Implicit()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x118D8D4", Offset = "0x118D8D4", VA = "0x118D8D4")]
		[Preserve]
		public static void HeadInsideGeometryHUD_op_Inequality()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x118D9A4", Offset = "0x118D9A4", VA = "0x118D9A4")]
		[Preserve]
		public static void HintDefinition_op_Equality()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x118DA74", Offset = "0x118DA74", VA = "0x118DA74")]
		[Preserve]
		public static void HintDefinition_op_Implicit()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x118DB3C", Offset = "0x118DB3C", VA = "0x118DB3C")]
		[Preserve]
		public static void HintDefinition_op_Inequality()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x118DC0C", Offset = "0x118DC0C", VA = "0x118DC0C")]
		[Preserve]
		public static void HintHud_op_Equality()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x118DCDC", Offset = "0x118DCDC", VA = "0x118DCDC")]
		[Preserve]
		public static void HintHud_op_Implicit()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x118DDA4", Offset = "0x118DDA4", VA = "0x118DDA4")]
		[Preserve]
		public static void HintHud_op_Inequality()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x118DE74", Offset = "0x118DE74", VA = "0x118DE74")]
		[Preserve]
		public static void HintManager_MarkHintComplete()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x118DF1C", Offset = "0x118DF1C", VA = "0x118DF1C")]
		[Preserve]
		public static void HintManager_MarkHintNotComplete()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x118DFC4", Offset = "0x118DFC4", VA = "0x118DFC4")]
		[Preserve]
		public static void HintManager_MarkHintNotCompleteIgnoreDependants()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x118E06C", Offset = "0x118E06C", VA = "0x118E06C")]
		[Preserve]
		public static void HintManager_op_Equality()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x118E13C", Offset = "0x118E13C", VA = "0x118E13C")]
		[Preserve]
		public static void HintManager_op_Implicit()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x118E204", Offset = "0x118E204", VA = "0x118E204")]
		[Preserve]
		public static void HintManager_op_Inequality()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x118E2D4", Offset = "0x118E2D4", VA = "0x118E2D4")]
		[Preserve]
		public static void HintTab_op_Equality()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x118E3A4", Offset = "0x118E3A4", VA = "0x118E3A4")]
		[Preserve]
		public static void HintTab_op_Implicit()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x118E46C", Offset = "0x118E46C", VA = "0x118E46C")]
		[Preserve]
		public static void HintTab_op_Inequality()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x118E53C", Offset = "0x118E53C", VA = "0x118E53C")]
		[Preserve]
		public static void HintTimer_op_Equality()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x118E60C", Offset = "0x118E60C", VA = "0x118E60C")]
		[Preserve]
		public static void HintTimer_op_Implicit()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x118E6D4", Offset = "0x118E6D4", VA = "0x118E6D4")]
		[Preserve]
		public static void HintTimer_op_Inequality()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x118E7A4", Offset = "0x118E7A4", VA = "0x118E7A4")]
		[Preserve]
		public static void HotSpotPosition_op_Equality()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x118E874", Offset = "0x118E874", VA = "0x118E874")]
		[Preserve]
		public static void HotSpotPosition_op_Implicit()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x118E93C", Offset = "0x118E93C", VA = "0x118E93C")]
		[Preserve]
		public static void HotSpotPosition_op_Inequality()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x118EA0C", Offset = "0x118EA0C", VA = "0x118EA0C")]
		[Preserve]
		public static void HudManager_ClearForcedInventoryPosition()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x118EA40", Offset = "0x118EA40", VA = "0x118EA40")]
		[Preserve]
		public static void HudManager_Hide()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x118EA74", Offset = "0x118EA74", VA = "0x118EA74")]
		[Preserve]
		public static void HudManager_op_Equality()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x118EB44", Offset = "0x118EB44", VA = "0x118EB44")]
		[Preserve]
		public static void HudManager_op_Implicit()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x118EC0C", Offset = "0x118EC0C", VA = "0x118EC0C")]
		[Preserve]
		public static void HudManager_op_Inequality()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x118ECDC", Offset = "0x118ECDC", VA = "0x118ECDC")]
		[Preserve]
		public static void HudManager_SetForcedInventoryPosition()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x118ED10", Offset = "0x118ED10", VA = "0x118ED10")]
		[Preserve]
		public static void HudManager_Show()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x118ED44", Offset = "0x118ED44", VA = "0x118ED44")]
		[Preserve]
		public static void HudManager_ShowAddedToInventoryDescription()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x118ED78", Offset = "0x118ED78", VA = "0x118ED78")]
		[Preserve]
		public static void HudManager_ShowAtPosition()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x118EDAC", Offset = "0x118EDAC", VA = "0x118EDAC")]
		[Preserve]
		public static void HymnSuperzoomLock_op_Equality()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x118EE7C", Offset = "0x118EE7C", VA = "0x118EE7C")]
		[Preserve]
		public static void HymnSuperzoomLock_op_Implicit()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x118EF44", Offset = "0x118EF44", VA = "0x118EF44")]
		[Preserve]
		public static void HymnSuperzoomLock_op_Inequality()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x118F014", Offset = "0x118F014", VA = "0x118F014")]
		[Preserve]
		public static void ICogDriven_op_Equality()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x118F0E4", Offset = "0x118F0E4", VA = "0x118F0E4")]
		[Preserve]
		public static void ICogDriven_op_Implicit()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x118F1AC", Offset = "0x118F1AC", VA = "0x118F1AC")]
		[Preserve]
		public static void ICogDriven_op_Inequality()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x118F27C", Offset = "0x118F27C", VA = "0x118F27C")]
		[Preserve]
		public static void Imposter_op_Equality()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x118F34C", Offset = "0x118F34C", VA = "0x118F34C")]
		[Preserve]
		public static void Imposter_op_Implicit()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x118F414", Offset = "0x118F414", VA = "0x118F414")]
		[Preserve]
		public static void Imposter_op_Inequality()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x118F4E4", Offset = "0x118F4E4", VA = "0x118F4E4")]
		[Preserve]
		public static void Imposter_SetForceDisabled()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x118F518", Offset = "0x118F518", VA = "0x118F518")]
		[Preserve]
		public static void InstantiatePrefab_op_Equality()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x118F5E8", Offset = "0x118F5E8", VA = "0x118F5E8")]
		[Preserve]
		public static void InstantiatePrefab_op_Implicit()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x118F6B0", Offset = "0x118F6B0", VA = "0x118F6B0")]
		[Preserve]
		public static void InstantiatePrefab_op_Inequality()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x118F780", Offset = "0x118F780", VA = "0x118F780")]
		[Preserve]
		public static void int_Equals()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x118F830", Offset = "0x118F830", VA = "0x118F830")]
		[Preserve]
		public static void int_Equals_0()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x118F8E4", Offset = "0x118F8E4", VA = "0x118F8E4")]
		[Preserve]
		public static void Interactable_op_Equality()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x118F9B4", Offset = "0x118F9B4", VA = "0x118F9B4")]
		[Preserve]
		public static void Interactable_op_Implicit()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x118FA7C", Offset = "0x118FA7C", VA = "0x118FA7C")]
		[Preserve]
		public static void Interactable_op_Inequality()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x118FB4C", Offset = "0x118FB4C", VA = "0x118FB4C")]
		[Preserve]
		public static void InTriggerList_op_Equality()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x118FC1C", Offset = "0x118FC1C", VA = "0x118FC1C")]
		[Preserve]
		public static void InTriggerList_op_Implicit()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x118FCE4", Offset = "0x118FCE4", VA = "0x118FCE4")]
		[Preserve]
		public static void InTriggerList_op_Inequality()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x118FDB4", Offset = "0x118FDB4", VA = "0x118FDB4")]
		[Preserve]
		public static void InventoryArc_op_Equality()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x118FE84", Offset = "0x118FE84", VA = "0x118FE84")]
		[Preserve]
		public static void InventoryArc_op_Implicit()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x118FF4C", Offset = "0x118FF4C", VA = "0x118FF4C")]
		[Preserve]
		public static void InventoryArc_op_Inequality()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x119001C", Offset = "0x119001C", VA = "0x119001C")]
		[Preserve]
		public static void InventoryCollisionVolume_op_Equality()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x11900EC", Offset = "0x11900EC", VA = "0x11900EC")]
		[Preserve]
		public static void InventoryCollisionVolume_op_Implicit()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x11901B4", Offset = "0x11901B4", VA = "0x11901B4")]
		[Preserve]
		public static void InventoryCollisionVolume_op_Inequality()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1190284", Offset = "0x1190284", VA = "0x1190284")]
		[Preserve]
		public static void InventoryGridLayout_op_Equality()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1190354", Offset = "0x1190354", VA = "0x1190354")]
		[Preserve]
		public static void InventoryGridLayout_op_Implicit()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x119041C", Offset = "0x119041C", VA = "0x119041C")]
		[Preserve]
		public static void InventoryGridLayout_op_Inequality()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x11904EC", Offset = "0x11904EC", VA = "0x11904EC")]
		[Preserve]
		public static void InventoryHud_op_Equality()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x11905BC", Offset = "0x11905BC", VA = "0x11905BC")]
		[Preserve]
		public static void InventoryHud_op_Implicit()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1190684", Offset = "0x1190684", VA = "0x1190684")]
		[Preserve]
		public static void InventoryHud_op_Inequality()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1190754", Offset = "0x1190754", VA = "0x1190754")]
		[Preserve]
		public static void InventoryItemDescription_op_Equality()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1190824", Offset = "0x1190824", VA = "0x1190824")]
		[Preserve]
		public static void InventoryItemDescription_op_Implicit()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x11908EC", Offset = "0x11908EC", VA = "0x11908EC")]
		[Preserve]
		public static void InventoryItemDescription_op_Inequality()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x11909BC", Offset = "0x11909BC", VA = "0x11909BC")]
		[Preserve]
		public static void InventoryItemGrabbable_Equals()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1190A6C", Offset = "0x1190A6C", VA = "0x1190A6C")]
		[Preserve]
		public static void InventoryItemGrabbable_HasBeenPickedUp()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1190AA0", Offset = "0x1190AA0", VA = "0x1190AA0")]
		[Preserve]
		public static void InventoryItemGrabbable_IsBeingHeld()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1190AD4", Offset = "0x1190AD4", VA = "0x1190AD4")]
		[Preserve]
		public static void InventoryItemGrabbable_IsInInventory()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1190B08", Offset = "0x1190B08", VA = "0x1190B08")]
		[Preserve]
		public static void InventoryItemGrabbable_op_Equality()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1190BD8", Offset = "0x1190BD8", VA = "0x1190BD8")]
		[Preserve]
		public static void InventoryItemGrabbable_op_Implicit()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1190CA0", Offset = "0x1190CA0", VA = "0x1190CA0")]
		[Preserve]
		public static void InventoryItemGrabbable_op_Inequality()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1190D70", Offset = "0x1190D70", VA = "0x1190D70")]
		[Preserve]
		public static void InventoryItemGrabbable_ReturnToInventory()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1190DA4", Offset = "0x1190DA4", VA = "0x1190DA4")]
		[Preserve]
		public static void InventoryItemGrabbable_SetState()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1190DD8", Offset = "0x1190DD8", VA = "0x1190DD8")]
		[Preserve]
		public static void InventoryItemGrabbable_SwapItem()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1190E0C", Offset = "0x1190E0C", VA = "0x1190E0C")]
		[Preserve]
		public static void InventoryItemProxy_ctor()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1190E5C", Offset = "0x1190E5C", VA = "0x1190E5C")]
		[Preserve]
		public static void InventoryItemProxy_op_Equality()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1190F2C", Offset = "0x1190F2C", VA = "0x1190F2C")]
		[Preserve]
		public static void InventoryItemProxy_op_Implicit()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1190FF4", Offset = "0x1190FF4", VA = "0x1190FF4")]
		[Preserve]
		public static void InventoryItemProxy_op_Inequality()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x11910C4", Offset = "0x11910C4", VA = "0x11910C4")]
		[Preserve]
		public static void InventoryItemProxy_SetState()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x11910F8", Offset = "0x11910F8", VA = "0x11910F8")]
		[Preserve]
		public static void InventoryManager_AddItemToInventory()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x119112C", Offset = "0x119112C", VA = "0x119112C")]
		[Preserve]
		public static void InventoryManager_op_Equality()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x11911FC", Offset = "0x11911FC", VA = "0x11911FC")]
		[Preserve]
		public static void InventoryManager_op_Implicit()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x11912C4", Offset = "0x11912C4", VA = "0x11912C4")]
		[Preserve]
		public static void InventoryManager_op_Inequality()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1191394", Offset = "0x1191394", VA = "0x1191394")]
		[Preserve]
		public static void InventoryReceiver_GetCurrentItem()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x11913C8", Offset = "0x11913C8", VA = "0x11913C8")]
		[Preserve]
		public static void InventoryReceiver_HasItem()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x11913FC", Offset = "0x11913FC", VA = "0x11913FC")]
		[Preserve]
		public static void InventoryReceiver_op_Equality()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x11914CC", Offset = "0x11914CC", VA = "0x11914CC")]
		[Preserve]
		public static void InventoryReceiver_op_Implicit()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1191594", Offset = "0x1191594", VA = "0x1191594")]
		[Preserve]
		public static void InventoryReceiver_op_Inequality()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1191664", Offset = "0x1191664", VA = "0x1191664")]
		[Preserve]
		public static void InventoryReceiver_ReturnPlacedItemToPickup()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1191698", Offset = "0x1191698", VA = "0x1191698")]
		[Preserve]
		public static void InventoryReceiver_SetState()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x11916CC", Offset = "0x11916CC", VA = "0x11916CC")]
		[Preserve]
		public static void InventoryReceiver_TransferGrab()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1191700", Offset = "0x1191700", VA = "0x1191700")]
		[Preserve]
		public static void InventorySlot_op_Equality()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x11917D0", Offset = "0x11917D0", VA = "0x11917D0")]
		[Preserve]
		public static void InventorySlot_op_Implicit()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1191898", Offset = "0x1191898", VA = "0x1191898")]
		[Preserve]
		public static void InventorySlot_op_Inequality()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1191968", Offset = "0x1191968", VA = "0x1191968")]
		[Preserve]
		public static void InvisibleReasons_op_Equality()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1191A38", Offset = "0x1191A38", VA = "0x1191A38")]
		[Preserve]
		public static void InvisibleReasons_op_Implicit()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1191B00", Offset = "0x1191B00", VA = "0x1191B00")]
		[Preserve]
		public static void InvisibleReasons_op_Inequality()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1191BD0", Offset = "0x1191BD0", VA = "0x1191BD0")]
		[Preserve]
		public static void JiraBugReportAction_op_Equality()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1191CA0", Offset = "0x1191CA0", VA = "0x1191CA0")]
		[Preserve]
		public static void JiraBugReportAction_op_Implicit()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1191D68", Offset = "0x1191D68", VA = "0x1191D68")]
		[Preserve]
		public static void JiraBugReportAction_op_Inequality()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1191E38", Offset = "0x1191E38", VA = "0x1191E38")]
		[Preserve]
		public static void KeyboardActivator_op_Equality()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1191F08", Offset = "0x1191F08", VA = "0x1191F08")]
		[Preserve]
		public static void KeyboardActivator_op_Implicit()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1191FD0", Offset = "0x1191FD0", VA = "0x1191FD0")]
		[Preserve]
		public static void KeyboardActivator_op_Inequality()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x11920A0", Offset = "0x11920A0", VA = "0x11920A0")]
		[Preserve]
		public static void KeyboardActivator_SetKeyState()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x11920D4", Offset = "0x11920D4", VA = "0x11920D4")]
		[Preserve]
		public static void KeyboardActivator_SetOrganFunctional()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1192108", Offset = "0x1192108", VA = "0x1192108")]
		[Preserve]
		public static void KeyboardHiglighter_op_Equality()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x11921D8", Offset = "0x11921D8", VA = "0x11921D8")]
		[Preserve]
		public static void KeyboardHiglighter_op_Implicit()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x11922A0", Offset = "0x11922A0", VA = "0x11922A0")]
		[Preserve]
		public static void KeyboardHiglighter_op_Inequality()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1192370", Offset = "0x1192370", VA = "0x1192370")]
		[Preserve]
		public static void KeyboardHiglighter_SetActive()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x11923A4", Offset = "0x11923A4", VA = "0x11923A4")]
		[Preserve]
		public static void KeyboardVolume_op_Equality()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1192474", Offset = "0x1192474", VA = "0x1192474")]
		[Preserve]
		public static void KeyboardVolume_op_Implicit()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x119253C", Offset = "0x119253C", VA = "0x119253C")]
		[Preserve]
		public static void KeyboardVolume_op_Inequality()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x119260C", Offset = "0x119260C", VA = "0x119260C")]
		[Preserve]
		public static void KnightShield_IsSolved()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1192640", Offset = "0x1192640", VA = "0x1192640")]
		[Preserve]
		public static void KnightShield_op_Equality()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1192710", Offset = "0x1192710", VA = "0x1192710")]
		[Preserve]
		public static void KnightShield_op_Implicit()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x11927D8", Offset = "0x11927D8", VA = "0x11927D8")]
		[Preserve]
		public static void KnightShield_op_Inequality()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x11928A8", Offset = "0x11928A8", VA = "0x11928A8")]
		[Preserve]
		public static void KnightShield_SetState()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x11928DC", Offset = "0x11928DC", VA = "0x11928DC")]
		[Preserve]
		public static void LayerSaver_op_Equality()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x11929AC", Offset = "0x11929AC", VA = "0x11929AC")]
		[Preserve]
		public static void LayerSaver_op_Implicit()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1192A74", Offset = "0x1192A74", VA = "0x1192A74")]
		[Preserve]
		public static void LayerSaver_op_Inequality()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1192B44", Offset = "0x1192B44", VA = "0x1192B44")]
		[Preserve]
		public static void LevelController_op_Equality()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1192C14", Offset = "0x1192C14", VA = "0x1192C14")]
		[Preserve]
		public static void LevelController_op_Implicit()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1192CDC", Offset = "0x1192CDC", VA = "0x1192CDC")]
		[Preserve]
		public static void LevelController_op_Inequality()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1192DAC", Offset = "0x1192DAC", VA = "0x1192DAC")]
		[Preserve]
		public static void LevelInfo_op_Equality()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1192E7C", Offset = "0x1192E7C", VA = "0x1192E7C")]
		[Preserve]
		public static void LevelInfo_op_Implicit()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1192F44", Offset = "0x1192F44", VA = "0x1192F44")]
		[Preserve]
		public static void LevelInfo_op_Inequality()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1193014", Offset = "0x1193014", VA = "0x1193014")]
		[Preserve]
		public static void LevelLoadSceneController_op_Equality()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x11930E4", Offset = "0x11930E4", VA = "0x11930E4")]
		[Preserve]
		public static void LevelLoadSceneController_op_Implicit()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x11931AC", Offset = "0x11931AC", VA = "0x11931AC")]
		[Preserve]
		public static void LevelLoadSceneController_op_Inequality()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x119327C", Offset = "0x119327C", VA = "0x119327C")]
		[Preserve]
		public static void LevelLoadSceneController_SetLoadingSequenceComplete()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x11932B0", Offset = "0x11932B0", VA = "0x11932B0")]
		[Preserve]
		public static void LevelLoadSceneController_StartLoad()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x11932E4", Offset = "0x11932E4", VA = "0x11932E4")]
		[Preserve]
		public static void LevelSelectScreen_op_Equality()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x11933B4", Offset = "0x11933B4", VA = "0x11933B4")]
		[Preserve]
		public static void LevelSelectScreen_op_Implicit()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x119347C", Offset = "0x119347C", VA = "0x119347C")]
		[Preserve]
		public static void LevelSelectScreen_op_Inequality()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x119354C", Offset = "0x119354C", VA = "0x119354C")]
		[Preserve]
		public static void LightBoxController_op_Equality()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x119361C", Offset = "0x119361C", VA = "0x119361C")]
		[Preserve]
		public static void LightBoxController_op_Implicit()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x11936E4", Offset = "0x11936E4", VA = "0x11936E4")]
		[Preserve]
		public static void LightBoxController_op_Inequality()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x11937B4", Offset = "0x11937B4", VA = "0x11937B4")]
		[Preserve]
		public static void LightBoxController_PauseHandle()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x11937E8", Offset = "0x11937E8", VA = "0x11937E8")]
		[Preserve]
		public static void LightBoxController_ResumeHandle()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x119381C", Offset = "0x119381C", VA = "0x119381C")]
		[Preserve]
		public static void LightBoxController_SetSuperzoomDisabled()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1193850", Offset = "0x1193850", VA = "0x1193850")]
		[Preserve]
		public static void LightCone_op_Equality()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1193920", Offset = "0x1193920", VA = "0x1193920")]
		[Preserve]
		public static void LightCone_op_Implicit()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x11939E8", Offset = "0x11939E8", VA = "0x11939E8")]
		[Preserve]
		public static void LightCone_op_Inequality()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1193AB8", Offset = "0x1193AB8", VA = "0x1193AB8")]
		[Preserve]
		public static void LightManager_op_Equality()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1193B88", Offset = "0x1193B88", VA = "0x1193B88")]
		[Preserve]
		public static void LightManager_op_Implicit()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1193C50", Offset = "0x1193C50", VA = "0x1193C50")]
		[Preserve]
		public static void LightManager_op_Inequality()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1193D20", Offset = "0x1193D20", VA = "0x1193D20")]
		[Preserve]
		public static void LightManager_SwapReflectionProbes()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1193D54", Offset = "0x1193D54", VA = "0x1193D54")]
		[Preserve]
		public static void LightmapSwitcher_op_Equality()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1193E24", Offset = "0x1193E24", VA = "0x1193E24")]
		[Preserve]
		public static void LightmapSwitcher_op_Implicit()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1193EEC", Offset = "0x1193EEC", VA = "0x1193EEC")]
		[Preserve]
		public static void LightmapSwitcher_op_Inequality()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1193FBC", Offset = "0x1193FBC", VA = "0x1193FBC")]
		[Preserve]
		public static void LightmapSwitcher_SwitchLightmap()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1193FF0", Offset = "0x1193FF0", VA = "0x1193FF0")]
		[Preserve]
		public static void Lightning_FireLightning()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1194024", Offset = "0x1194024", VA = "0x1194024")]
		[Preserve]
		public static void Lightning_op_Equality()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x11940F4", Offset = "0x11940F4", VA = "0x11940F4")]
		[Preserve]
		public static void Lightning_op_Implicit()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x11941BC", Offset = "0x11941BC", VA = "0x11941BC")]
		[Preserve]
		public static void Lightning_op_Inequality()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x119428C", Offset = "0x119428C", VA = "0x119428C")]
		[Preserve]
		public static void Lightning_SetRandomLightningEnabled()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x11942C0", Offset = "0x11942C0", VA = "0x11942C0")]
		[Preserve]
		public static void LightSaver_op_Equality()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1194390", Offset = "0x1194390", VA = "0x1194390")]
		[Preserve]
		public static void LightSaver_op_Implicit()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1194458", Offset = "0x1194458", VA = "0x1194458")]
		[Preserve]
		public static void LightSaver_op_Inequality()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1194528", Offset = "0x1194528", VA = "0x1194528")]
		[Preserve]
		public static void LimitRotationModifier_Angle()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x119455C", Offset = "0x119455C", VA = "0x119455C")]
		[Preserve]
		public static void LimitRotationModifier_Enabled()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1194590", Offset = "0x1194590", VA = "0x1194590")]
		[Preserve]
		public static void LimitRotationModifier_IsAtLimit()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x11945C4", Offset = "0x11945C4", VA = "0x11945C4")]
		[Preserve]
		public static void LimitRotationModifier_IsAtLimit_0()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1194690", Offset = "0x1194690", VA = "0x1194690")]
		[Preserve]
		public static void LimitRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1194760", Offset = "0x1194760", VA = "0x1194760")]
		[Preserve]
		public static void LimitRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1194828", Offset = "0x1194828", VA = "0x1194828")]
		[Preserve]
		public static void LimitRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x11948F8", Offset = "0x11948F8", VA = "0x11948F8")]
		[Preserve]
		public static void LimitRotationModifier_SetAllowAudio()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x119492C", Offset = "0x119492C", VA = "0x119492C")]
		[Preserve]
		public static void LimitSliderModifier_IsAtLimit()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1194960", Offset = "0x1194960", VA = "0x1194960")]
		[Preserve]
		public static void LimitSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1194A30", Offset = "0x1194A30", VA = "0x1194A30")]
		[Preserve]
		public static void LimitSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1194AF8", Offset = "0x1194AF8", VA = "0x1194AF8")]
		[Preserve]
		public static void LimitSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1194BC8", Offset = "0x1194BC8", VA = "0x1194BC8")]
		[Preserve]
		public static void LimitSliderModifier_SetUpperDisplacementLimit()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1194BFC", Offset = "0x1194BFC", VA = "0x1194BFC")]
		[Preserve]
		public static void LineRendererTransformMapper_op_Equality()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1194CCC", Offset = "0x1194CCC", VA = "0x1194CCC")]
		[Preserve]
		public static void LineRendererTransformMapper_op_Implicit()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1194D94", Offset = "0x1194D94", VA = "0x1194D94")]
		[Preserve]
		public static void LineRendererTransformMapper_op_Inequality()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1194E64", Offset = "0x1194E64", VA = "0x1194E64")]
		[Preserve]
		public static void LineUpObjectPuzzle_op_Equality()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1194F34", Offset = "0x1194F34", VA = "0x1194F34")]
		[Preserve]
		public static void LineUpObjectPuzzle_op_Implicit()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1194FFC", Offset = "0x1194FFC", VA = "0x1194FFC")]
		[Preserve]
		public static void LineUpObjectPuzzle_op_Inequality()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x11950CC", Offset = "0x11950CC", VA = "0x11950CC")]
		[Preserve]
		public static void LoadingScreen_op_Equality()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x119519C", Offset = "0x119519C", VA = "0x119519C")]
		[Preserve]
		public static void LoadingScreen_op_Implicit()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1195264", Offset = "0x1195264", VA = "0x1195264")]
		[Preserve]
		public static void LoadingScreen_op_Inequality()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1195334", Offset = "0x1195334", VA = "0x1195334")]
		[Preserve]
		public static void LocalisationCategory_op_Equality()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1195404", Offset = "0x1195404", VA = "0x1195404")]
		[Preserve]
		public static void LocalisationCategory_op_Implicit()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x11954CC", Offset = "0x11954CC", VA = "0x11954CC")]
		[Preserve]
		public static void LocalisationCategory_op_Inequality()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x119559C", Offset = "0x119559C", VA = "0x119559C")]
		[Preserve]
		public static void LocalisationSet_op_Equality()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x119566C", Offset = "0x119566C", VA = "0x119566C")]
		[Preserve]
		public static void LocalisationSet_op_Implicit()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1195734", Offset = "0x1195734", VA = "0x1195734")]
		[Preserve]
		public static void LocalisationSet_op_Inequality()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1195804", Offset = "0x1195804", VA = "0x1195804")]
		[Preserve]
		public static void LocaliseAssets_op_Equality()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x11958D4", Offset = "0x11958D4", VA = "0x11958D4")]
		[Preserve]
		public static void LocaliseAssets_op_Implicit()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x119599C", Offset = "0x119599C", VA = "0x119599C")]
		[Preserve]
		public static void LocaliseAssets_op_Inequality()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1195A6C", Offset = "0x1195A6C", VA = "0x1195A6C")]
		[Preserve]
		public static void LocalisedAssetDatabase_op_Equality()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1195B3C", Offset = "0x1195B3C", VA = "0x1195B3C")]
		[Preserve]
		public static void LocalisedAssetDatabase_op_Implicit()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1195C04", Offset = "0x1195C04", VA = "0x1195C04")]
		[Preserve]
		public static void LocalisedAssetDatabase_op_Inequality()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1195CD4", Offset = "0x1195CD4", VA = "0x1195CD4")]
		[Preserve]
		public static void LocalisedText_op_Equality()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1195DA4", Offset = "0x1195DA4", VA = "0x1195DA4")]
		[Preserve]
		public static void LocalisedText_op_Implicit()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1195E6C", Offset = "0x1195E6C", VA = "0x1195E6C")]
		[Preserve]
		public static void LocalisedText_op_Inequality()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1195F3C", Offset = "0x1195F3C", VA = "0x1195F3C")]
		[Preserve]
		public static void LocalisedTextureReferenceHolder_op_Equality()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x119600C", Offset = "0x119600C", VA = "0x119600C")]
		[Preserve]
		public static void LocalisedTextureReferenceHolder_op_Implicit()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x11960D4", Offset = "0x11960D4", VA = "0x11960D4")]
		[Preserve]
		public static void LocalisedTextureReferenceHolder_op_Inequality()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x11961A4", Offset = "0x11961A4", VA = "0x11961A4")]
		[Preserve]
		public static void LocaliseImage_op_Equality()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1196274", Offset = "0x1196274", VA = "0x1196274")]
		[Preserve]
		public static void LocaliseImage_op_Implicit()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x119633C", Offset = "0x119633C", VA = "0x119633C")]
		[Preserve]
		public static void LocaliseImage_op_Inequality()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x119640C", Offset = "0x119640C", VA = "0x119640C")]
		[Preserve]
		public static void LocaliseText_op_Equality()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x11964DC", Offset = "0x11964DC", VA = "0x11964DC")]
		[Preserve]
		public static void LocaliseText_op_Implicit()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x11965A4", Offset = "0x11965A4", VA = "0x11965A4")]
		[Preserve]
		public static void LocaliseText_op_Inequality()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1196674", Offset = "0x1196674", VA = "0x1196674")]
		[Preserve]
		public static void LockFixedUpdateToUpdateRate_op_Equality()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1196744", Offset = "0x1196744", VA = "0x1196744")]
		[Preserve]
		public static void LockFixedUpdateToUpdateRate_op_Implicit()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x119680C", Offset = "0x119680C", VA = "0x119680C")]
		[Preserve]
		public static void LockFixedUpdateToUpdateRate_op_Inequality()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x11968DC", Offset = "0x11968DC", VA = "0x11968DC")]
		[Preserve]
		public static void LockpickPuzzle_op_Equality()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x11969AC", Offset = "0x11969AC", VA = "0x11969AC")]
		[Preserve]
		public static void LockpickPuzzle_op_Implicit()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1196A74", Offset = "0x1196A74", VA = "0x1196A74")]
		[Preserve]
		public static void LockpickPuzzle_op_Inequality()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1196B44", Offset = "0x1196B44", VA = "0x1196B44")]
		[Preserve]
		public static void LodFromLocation_op_Equality()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1196C14", Offset = "0x1196C14", VA = "0x1196C14")]
		[Preserve]
		public static void LodFromLocation_op_Implicit()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1196CDC", Offset = "0x1196CDC", VA = "0x1196CDC")]
		[Preserve]
		public static void LodFromLocation_op_Inequality()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1196DAC", Offset = "0x1196DAC", VA = "0x1196DAC")]
		[Preserve]
		public static void LogPosition_op_Equality()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1196E7C", Offset = "0x1196E7C", VA = "0x1196E7C")]
		[Preserve]
		public static void LogPosition_op_Implicit()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1196F44", Offset = "0x1196F44", VA = "0x1196F44")]
		[Preserve]
		public static void LogPosition_op_Inequality()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1197014", Offset = "0x1197014", VA = "0x1197014")]
		[Preserve]
		public static void LogTextureFormat_op_Equality()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x11970E4", Offset = "0x11970E4", VA = "0x11970E4")]
		[Preserve]
		public static void LogTextureFormat_op_Implicit()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x11971AC", Offset = "0x11971AC", VA = "0x11971AC")]
		[Preserve]
		public static void LogTextureFormat_op_Inequality()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x119727C", Offset = "0x119727C", VA = "0x119727C")]
		[Preserve]
		public static void LookAtCamera_op_Equality()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x119734C", Offset = "0x119734C", VA = "0x119734C")]
		[Preserve]
		public static void LookAtCamera_op_Implicit()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1197414", Offset = "0x1197414", VA = "0x1197414")]
		[Preserve]
		public static void LookAtCamera_op_Inequality()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x11974E4", Offset = "0x11974E4", VA = "0x11974E4")]
		[Preserve]
		public static void LookAtTrigger_op_Equality()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x11975B4", Offset = "0x11975B4", VA = "0x11975B4")]
		[Preserve]
		public static void LookAtTrigger_op_Implicit()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x119767C", Offset = "0x119767C", VA = "0x119767C")]
		[Preserve]
		public static void LookAtTrigger_op_Inequality()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x119774C", Offset = "0x119774C", VA = "0x119774C")]
		[Preserve]
		public static void Ludiq_Generated_PropertyProviders_PropertyProvider_Fireproof_Audio_AudioEventReference_op_Equality()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x119781C", Offset = "0x119781C", VA = "0x119781C")]
		[Preserve]
		public static void Ludiq_Generated_PropertyProviders_PropertyProvider_Fireproof_Audio_AudioEventReference_op_Implicit()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x11978E4", Offset = "0x11978E4", VA = "0x11978E4")]
		[Preserve]
		public static void Ludiq_Generated_PropertyProviders_PropertyProvider_Fireproof_Audio_AudioEventReference_op_Inequality()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x11979B4", Offset = "0x11979B4", VA = "0x11979B4")]
		[Preserve]
		public static void Ludiq_Generated_PropertyProviders_PropertyProvider_GrabbableHandAnchor_Pose_op_Equality()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1197A84", Offset = "0x1197A84", VA = "0x1197A84")]
		[Preserve]
		public static void Ludiq_Generated_PropertyProviders_PropertyProvider_GrabbableHandAnchor_Pose_op_Implicit()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1197B4C", Offset = "0x1197B4C", VA = "0x1197B4C")]
		[Preserve]
		public static void Ludiq_Generated_PropertyProviders_PropertyProvider_GrabbableHandAnchor_Pose_op_Inequality()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1197C1C", Offset = "0x1197C1C", VA = "0x1197C1C")]
		[Preserve]
		public static void Ludiq_LudiqBehaviour_op_Equality()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1197CEC", Offset = "0x1197CEC", VA = "0x1197CEC")]
		[Preserve]
		public static void Ludiq_LudiqBehaviour_op_Implicit()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1197DB4", Offset = "0x1197DB4", VA = "0x1197DB4")]
		[Preserve]
		public static void Ludiq_LudiqBehaviour_op_Inequality()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1197E84", Offset = "0x1197E84", VA = "0x1197E84")]
		[Preserve]
		public static void Ludiq_LudiqScriptableObject_op_Equality()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1197F54", Offset = "0x1197F54", VA = "0x1197F54")]
		[Preserve]
		public static void Ludiq_LudiqScriptableObject_op_Implicit()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x119801C", Offset = "0x119801C", VA = "0x119801C")]
		[Preserve]
		public static void Ludiq_LudiqScriptableObject_op_Inequality()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x11980EC", Offset = "0x11980EC", VA = "0x11980EC")]
		[Preserve]
		public static void LunarCrankAudioPlayer_op_Equality()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x11981BC", Offset = "0x11981BC", VA = "0x11981BC")]
		[Preserve]
		public static void LunarCrankAudioPlayer_op_Implicit()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1198284", Offset = "0x1198284", VA = "0x1198284")]
		[Preserve]
		public static void LunarCrankAudioPlayer_op_Inequality()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1198354", Offset = "0x1198354", VA = "0x1198354")]
		[Preserve]
		public static void MagneticSnapModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1198424", Offset = "0x1198424", VA = "0x1198424")]
		[Preserve]
		public static void MagneticSnapModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x11984EC", Offset = "0x11984EC", VA = "0x11984EC")]
		[Preserve]
		public static void MagneticSnapModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x11985BC", Offset = "0x11985BC", VA = "0x11985BC")]
		[Preserve]
		public static void MainMenuScreen_op_Equality()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x119868C", Offset = "0x119868C", VA = "0x119868C")]
		[Preserve]
		public static void MainMenuScreen_op_Implicit()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1198754", Offset = "0x1198754", VA = "0x1198754")]
		[Preserve]
		public static void MainMenuScreen_op_Inequality()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1198824", Offset = "0x1198824", VA = "0x1198824")]
		[Preserve]
		public static void MainMenuScreenDemo_op_Equality()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x11988F4", Offset = "0x11988F4", VA = "0x11988F4")]
		[Preserve]
		public static void MainMenuScreenDemo_op_Implicit()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x11989BC", Offset = "0x11989BC", VA = "0x11989BC")]
		[Preserve]
		public static void MainMenuScreenDemo_op_Inequality()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1198A8C", Offset = "0x1198A8C", VA = "0x1198A8C")]
		[Preserve]
		public static void MaterialInterface_op_Equality()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1198B5C", Offset = "0x1198B5C", VA = "0x1198B5C")]
		[Preserve]
		public static void MaterialInterface_op_Implicit()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1198C24", Offset = "0x1198C24", VA = "0x1198C24")]
		[Preserve]
		public static void MaterialInterface_op_Inequality()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1198CF4", Offset = "0x1198CF4", VA = "0x1198CF4")]
		[Preserve]
		public static void MaterialLightController_op_Equality()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1198DC4", Offset = "0x1198DC4", VA = "0x1198DC4")]
		[Preserve]
		public static void MaterialLightController_op_Implicit()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1198E8C", Offset = "0x1198E8C", VA = "0x1198E8C")]
		[Preserve]
		public static void MaterialLightController_op_Inequality()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1198F5C", Offset = "0x1198F5C", VA = "0x1198F5C")]
		[Preserve]
		public static void MaterialManager_op_Equality()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x119902C", Offset = "0x119902C", VA = "0x119902C")]
		[Preserve]
		public static void MaterialManager_op_Implicit()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x11990F4", Offset = "0x11990F4", VA = "0x11990F4")]
		[Preserve]
		public static void MaterialManager_op_Inequality()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x11991C4", Offset = "0x11991C4", VA = "0x11991C4")]
		[Preserve]
		public static void MaterialSwitcher_op_Equality()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1199294", Offset = "0x1199294", VA = "0x1199294")]
		[Preserve]
		public static void MaterialSwitcher_op_Implicit()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x119935C", Offset = "0x119935C", VA = "0x119935C")]
		[Preserve]
		public static void MaterialSwitcher_op_Inequality()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x119942C", Offset = "0x119942C", VA = "0x119942C")]
		[Preserve]
		public static void MaterialSwitcher_SwitchToMaterialSet()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1199460", Offset = "0x1199460", VA = "0x1199460")]
		[Preserve]
		public static void MenuButton_op_Equality()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1199530", Offset = "0x1199530", VA = "0x1199530")]
		[Preserve]
		public static void MenuButton_op_Implicit()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x11995F8", Offset = "0x11995F8", VA = "0x11995F8")]
		[Preserve]
		public static void MenuButton_op_Inequality()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x11996C8", Offset = "0x11996C8", VA = "0x11996C8")]
		[Preserve]
		public static void MenuController_enabled()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x11996FC", Offset = "0x11996FC", VA = "0x11996FC")]
		[Preserve]
		public static void MenuController_op_Equality()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x11997CC", Offset = "0x11997CC", VA = "0x11997CC")]
		[Preserve]
		public static void MenuController_op_Implicit()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1199894", Offset = "0x1199894", VA = "0x1199894")]
		[Preserve]
		public static void MenuController_op_Inequality()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1199964", Offset = "0x1199964", VA = "0x1199964")]
		[Preserve]
		public static void MenuGeometryFadeController_op_Equality()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1199A34", Offset = "0x1199A34", VA = "0x1199A34")]
		[Preserve]
		public static void MenuGeometryFadeController_op_Implicit()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1199AFC", Offset = "0x1199AFC", VA = "0x1199AFC")]
		[Preserve]
		public static void MenuGeometryFadeController_op_Inequality()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1199BCC", Offset = "0x1199BCC", VA = "0x1199BCC")]
		[Preserve]
		public static void MenuScreen_op_Equality()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1199C9C", Offset = "0x1199C9C", VA = "0x1199C9C")]
		[Preserve]
		public static void MenuScreen_op_Implicit()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1199D64", Offset = "0x1199D64", VA = "0x1199D64")]
		[Preserve]
		public static void MenuScreen_op_Inequality()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1199E34", Offset = "0x1199E34", VA = "0x1199E34")]
		[Preserve]
		public static void MenuToggle_op_Equality()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1199F04", Offset = "0x1199F04", VA = "0x1199F04")]
		[Preserve]
		public static void MenuToggle_op_Implicit()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1199FCC", Offset = "0x1199FCC", VA = "0x1199FCC")]
		[Preserve]
		public static void MenuToggle_op_Inequality()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x119A09C", Offset = "0x119A09C", VA = "0x119A09C")]
		[Preserve]
		public static void MeshReplacer_op_Equality()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x119A16C", Offset = "0x119A16C", VA = "0x119A16C")]
		[Preserve]
		public static void MeshReplacer_op_Implicit()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x119A234", Offset = "0x119A234", VA = "0x119A234")]
		[Preserve]
		public static void MeshReplacer_op_Inequality()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x119A304", Offset = "0x119A304", VA = "0x119A304")]
		[Preserve]
		public static void MessageBox_DismissMessage()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x119A338", Offset = "0x119A338", VA = "0x119A338")]
		[Preserve]
		public static void MessageBox_DoMessageBox()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x119A36C", Offset = "0x119A36C", VA = "0x119A36C")]
		[Preserve]
		public static void MessageBox_op_Equality()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x119A43C", Offset = "0x119A43C", VA = "0x119A43C")]
		[Preserve]
		public static void MessageBox_op_Implicit()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x119A504", Offset = "0x119A504", VA = "0x119A504")]
		[Preserve]
		public static void MessageBox_op_Inequality()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x119A5D4", Offset = "0x119A5D4", VA = "0x119A5D4")]
		[Preserve]
		public static void MoonCube_op_Equality()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x119A6A4", Offset = "0x119A6A4", VA = "0x119A6A4")]
		[Preserve]
		public static void MoonCube_op_Implicit()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x119A76C", Offset = "0x119A76C", VA = "0x119A76C")]
		[Preserve]
		public static void MoonCube_op_Inequality()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x119A83C", Offset = "0x119A83C", VA = "0x119A83C")]
		[Preserve]
		public static void MorphTargets_op_Equality()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x119A90C", Offset = "0x119A90C", VA = "0x119A90C")]
		[Preserve]
		public static void MorphTargets_op_Implicit()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x119A9D4", Offset = "0x119A9D4", VA = "0x119A9D4")]
		[Preserve]
		public static void MorphTargets_op_Inequality()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x119AAA4", Offset = "0x119AAA4", VA = "0x119AAA4")]
		[Preserve]
		public static void NoteAnimation_op_Equality()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x119AB74", Offset = "0x119AB74", VA = "0x119AB74")]
		[Preserve]
		public static void NoteAnimation_op_Implicit()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x119AC3C", Offset = "0x119AC3C", VA = "0x119AC3C")]
		[Preserve]
		public static void NoteAnimation_op_Inequality()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x119AD0C", Offset = "0x119AD0C", VA = "0x119AD0C")]
		[Preserve]
		public static void NoteSequence_op_Equality()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x119ADDC", Offset = "0x119ADDC", VA = "0x119ADDC")]
		[Preserve]
		public static void NoteSequence_op_Implicit()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x119AEA4", Offset = "0x119AEA4", VA = "0x119AEA4")]
		[Preserve]
		public static void NoteSequence_op_Inequality()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x119AF74", Offset = "0x119AF74", VA = "0x119AF74")]
		[Preserve]
		public static void NoteSequenceManager_op_Equality()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x119B044", Offset = "0x119B044", VA = "0x119B044")]
		[Preserve]
		public static void NoteSequenceManager_op_Implicit()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x119B10C", Offset = "0x119B10C", VA = "0x119B10C")]
		[Preserve]
		public static void NoteSequenceManager_op_Inequality()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x119B1DC", Offset = "0x119B1DC", VA = "0x119B1DC")]
		[Preserve]
		public static void NoteVertexAnimator_op_Equality()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x119B2AC", Offset = "0x119B2AC", VA = "0x119B2AC")]
		[Preserve]
		public static void NoteVertexAnimator_op_Implicit()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x119B374", Offset = "0x119B374", VA = "0x119B374")]
		[Preserve]
		public static void NoteVertexAnimator_op_Inequality()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x119B444", Offset = "0x119B444", VA = "0x119B444")]
		[Preserve]
		public static void NumberTicker_op_Equality()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x119B514", Offset = "0x119B514", VA = "0x119B514")]
		[Preserve]
		public static void NumberTicker_op_Implicit()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x119B5DC", Offset = "0x119B5DC", VA = "0x119B5DC")]
		[Preserve]
		public static void NumberTicker_op_Inequality()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x119B6AC", Offset = "0x119B6AC", VA = "0x119B6AC")]
		[Preserve]
		public static void object_Equals()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x119B75C", Offset = "0x119B75C", VA = "0x119B75C")]
		[Preserve]
		public static void ObjectOnlyPointLight_op_Equality()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x119B82C", Offset = "0x119B82C", VA = "0x119B82C")]
		[Preserve]
		public static void ObjectOnlyPointLight_op_Implicit()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x119B8F4", Offset = "0x119B8F4", VA = "0x119B8F4")]
		[Preserve]
		public static void ObjectOnlyPointLight_op_Inequality()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x119B9C4", Offset = "0x119B9C4", VA = "0x119B9C4")]
		[Preserve]
		public static void OculusEntitlementScreen_op_Equality()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x119BA94", Offset = "0x119BA94", VA = "0x119BA94")]
		[Preserve]
		public static void OculusEntitlementScreen_op_Implicit()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x119BB5C", Offset = "0x119BB5C", VA = "0x119BB5C")]
		[Preserve]
		public static void OculusEntitlementScreen_op_Inequality()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x119BC2C", Offset = "0x119BC2C", VA = "0x119BC2C")]
		[Preserve]
		public static void OculusFadeRenderer_op_Equality()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x119BCFC", Offset = "0x119BCFC", VA = "0x119BCFC")]
		[Preserve]
		public static void OculusFadeRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x119BDC4", Offset = "0x119BDC4", VA = "0x119BDC4")]
		[Preserve]
		public static void OculusFadeRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x119BE94", Offset = "0x119BE94", VA = "0x119BE94")]
		[Preserve]
		public static void OneShotAudioPlayer_op_Equality()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x119BF64", Offset = "0x119BF64", VA = "0x119BF64")]
		[Preserve]
		public static void OneShotAudioPlayer_op_Implicit()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x119C02C", Offset = "0x119C02C", VA = "0x119C02C")]
		[Preserve]
		public static void OneShotAudioPlayer_op_Inequality()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x119C0FC", Offset = "0x119C0FC", VA = "0x119C0FC")]
		[Preserve]
		public static void OneShotAudioPlayer_Play()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x119C130", Offset = "0x119C130", VA = "0x119C130")]
		[Preserve]
		public static void OneWaySliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x119C200", Offset = "0x119C200", VA = "0x119C200")]
		[Preserve]
		public static void OneWaySliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x119C2C8", Offset = "0x119C2C8", VA = "0x119C2C8")]
		[Preserve]
		public static void OneWaySliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x119C398", Offset = "0x119C398", VA = "0x119C398")]
		[Preserve]
		public static void OnWillRenderObjectListener_op_Equality()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x119C468", Offset = "0x119C468", VA = "0x119C468")]
		[Preserve]
		public static void OnWillRenderObjectListener_op_Implicit()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x119C530", Offset = "0x119C530", VA = "0x119C530")]
		[Preserve]
		public static void OnWillRenderObjectListener_op_Inequality()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x119C600", Offset = "0x119C600", VA = "0x119C600")]
		[Preserve]
		public static void Options_screen_op_Equality()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x119C6D0", Offset = "0x119C6D0", VA = "0x119C6D0")]
		[Preserve]
		public static void Options_screen_op_Implicit()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x119C798", Offset = "0x119C798", VA = "0x119C798")]
		[Preserve]
		public static void Options_screen_op_Inequality()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x119C868", Offset = "0x119C868", VA = "0x119C868")]
		[Preserve]
		public static void OptionsScreen_op_Equality()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x119C938", Offset = "0x119C938", VA = "0x119C938")]
		[Preserve]
		public static void OptionsScreen_op_Implicit()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x119CA00", Offset = "0x119CA00", VA = "0x119CA00")]
		[Preserve]
		public static void OptionsScreen_op_Inequality()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x119CAD0", Offset = "0x119CAD0", VA = "0x119CAD0")]
		[Preserve]
		public static void OrganBall_op_Equality()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x119CBA0", Offset = "0x119CBA0", VA = "0x119CBA0")]
		[Preserve]
		public static void OrganBall_op_Implicit()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x119CC68", Offset = "0x119CC68", VA = "0x119CC68")]
		[Preserve]
		public static void OrganBall_op_Inequality()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x119CD38", Offset = "0x119CD38", VA = "0x119CD38")]
		[Preserve]
		public static void OrganBall_SetActive()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x119CD6C", Offset = "0x119CD6C", VA = "0x119CD6C")]
		[Preserve]
		public static void OrganBallGoal_op_Equality()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x119CE3C", Offset = "0x119CE3C", VA = "0x119CE3C")]
		[Preserve]
		public static void OrganBallGoal_op_Implicit()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x119CF04", Offset = "0x119CF04", VA = "0x119CF04")]
		[Preserve]
		public static void OrganBallGoal_op_Inequality()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x119CFD4", Offset = "0x119CFD4", VA = "0x119CFD4")]
		[Preserve]
		public static void OrganBallResetTrigger_op_Equality()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x119D0A4", Offset = "0x119D0A4", VA = "0x119D0A4")]
		[Preserve]
		public static void OrganBallResetTrigger_op_Implicit()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x119D16C", Offset = "0x119D16C", VA = "0x119D16C")]
		[Preserve]
		public static void OrganBallResetTrigger_op_Inequality()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x119D23C", Offset = "0x119D23C", VA = "0x119D23C")]
		[Preserve]
		public static void OrganBellows_op_Equality()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x119D30C", Offset = "0x119D30C", VA = "0x119D30C")]
		[Preserve]
		public static void OrganBellows_op_Implicit()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x119D3D4", Offset = "0x119D3D4", VA = "0x119D3D4")]
		[Preserve]
		public static void OrganBellows_op_Inequality()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x119D4A4", Offset = "0x119D4A4", VA = "0x119D4A4")]
		[Preserve]
		public static void OrganPipeFlashController_op_Equality()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x119D574", Offset = "0x119D574", VA = "0x119D574")]
		[Preserve]
		public static void OrganPipeFlashController_op_Implicit()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x119D63C", Offset = "0x119D63C", VA = "0x119D63C")]
		[Preserve]
		public static void OrganPipeFlashController_op_Inequality()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x119D70C", Offset = "0x119D70C", VA = "0x119D70C")]
		[Preserve]
		public static void OrganPipeFlashController_SetActive()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x119D740", Offset = "0x119D740", VA = "0x119D740")]
		[Preserve]
		public static void OrganSuperzoomBellowsAnimator_op_Equality()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x119D810", Offset = "0x119D810", VA = "0x119D810")]
		[Preserve]
		public static void OrganSuperzoomBellowsAnimator_op_Implicit()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x119D8D8", Offset = "0x119D8D8", VA = "0x119D8D8")]
		[Preserve]
		public static void OrganSuperzoomBellowsAnimator_op_Inequality()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x119D9A8", Offset = "0x119D9A8", VA = "0x119D9A8")]
		[Preserve]
		public static void OrganSuperzoomBellowsAnimator_PlayFinishedAudio()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x119D9DC", Offset = "0x119D9DC", VA = "0x119D9DC")]
		[Preserve]
		public static void OrganSuperzoomBellowsAnimator_ReleaseLeftGear()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x119DA10", Offset = "0x119DA10", VA = "0x119DA10")]
		[Preserve]
		public static void OrganSuperzoomBellowsAnimator_ReleaseRightGear()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x119DA44", Offset = "0x119DA44", VA = "0x119DA44")]
		[Preserve]
		public static void OrganSuperzoomBellowsAnimator_SetActive()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x119DA78", Offset = "0x119DA78", VA = "0x119DA78")]
		[Preserve]
		public static void OrganSuperzoomLocationActivator_op_Equality()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x119DB48", Offset = "0x119DB48", VA = "0x119DB48")]
		[Preserve]
		public static void OrganSuperzoomLocationActivator_op_Implicit()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x119DC10", Offset = "0x119DC10", VA = "0x119DC10")]
		[Preserve]
		public static void OrganSuperzoomLocationActivator_op_Inequality()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x119DCE0", Offset = "0x119DCE0", VA = "0x119DCE0")]
		[Preserve]
		public static void PaintingCheckPoint_op_Equality()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x119DDB0", Offset = "0x119DDB0", VA = "0x119DDB0")]
		[Preserve]
		public static void PaintingCheckPoint_op_Implicit()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x119DE78", Offset = "0x119DE78", VA = "0x119DE78")]
		[Preserve]
		public static void PaintingCheckPoint_op_Inequality()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x119DF48", Offset = "0x119DF48", VA = "0x119DF48")]
		[Preserve]
		public static void PaintingIntermediatePoint_op_Equality()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x119E018", Offset = "0x119E018", VA = "0x119E018")]
		[Preserve]
		public static void PaintingIntermediatePoint_op_Implicit()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x119E0E0", Offset = "0x119E0E0", VA = "0x119E0E0")]
		[Preserve]
		public static void PaintingIntermediatePoint_op_Inequality()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x119E1B0", Offset = "0x119E1B0", VA = "0x119E1B0")]
		[Preserve]
		public static void PaintingProhibitedPoint_op_Equality()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x119E280", Offset = "0x119E280", VA = "0x119E280")]
		[Preserve]
		public static void PaintingProhibitedPoint_op_Implicit()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x119E348", Offset = "0x119E348", VA = "0x119E348")]
		[Preserve]
		public static void PaintingProhibitedPoint_op_Inequality()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x119E418", Offset = "0x119E418", VA = "0x119E418")]
		[Preserve]
		public static void PaintingPuzzle_op_Equality()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x119E4E8", Offset = "0x119E4E8", VA = "0x119E4E8")]
		[Preserve]
		public static void PaintingPuzzle_op_Implicit()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x119E5B0", Offset = "0x119E5B0", VA = "0x119E5B0")]
		[Preserve]
		public static void PaintingPuzzle_op_Inequality()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x119E680", Offset = "0x119E680", VA = "0x119E680")]
		[Preserve]
		public static void PaintingPuzzle_StartPuzzle()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x119E6B4", Offset = "0x119E6B4", VA = "0x119E6B4")]
		[Preserve]
		public static void PaintingPuzzleBrush_op_Equality()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x119E784", Offset = "0x119E784", VA = "0x119E784")]
		[Preserve]
		public static void PaintingPuzzleBrush_op_Implicit()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x119E84C", Offset = "0x119E84C", VA = "0x119E84C")]
		[Preserve]
		public static void PaintingPuzzleBrush_op_Inequality()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x119E91C", Offset = "0x119E91C", VA = "0x119E91C")]
		[Preserve]
		public static void PaintingPuzzleConstellations_op_Equality()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x119E9EC", Offset = "0x119E9EC", VA = "0x119E9EC")]
		[Preserve]
		public static void PaintingPuzzleConstellations_op_Implicit()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x119EAB4", Offset = "0x119EAB4", VA = "0x119EAB4")]
		[Preserve]
		public static void PaintingPuzzleConstellations_op_Inequality()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x119EB84", Offset = "0x119EB84", VA = "0x119EB84")]
		[Preserve]
		public static void PaintingRelativeScale_op_Equality()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x119EC54", Offset = "0x119EC54", VA = "0x119EC54")]
		[Preserve]
		public static void PaintingRelativeScale_op_Implicit()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x119ED1C", Offset = "0x119ED1C", VA = "0x119ED1C")]
		[Preserve]
		public static void PaintingRelativeScale_op_Inequality()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x119EDEC", Offset = "0x119EDEC", VA = "0x119EDEC")]
		[Preserve]
		public static void ParentMomentumRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x119EEBC", Offset = "0x119EEBC", VA = "0x119EEBC")]
		[Preserve]
		public static void ParentMomentumRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x119EF84", Offset = "0x119EF84", VA = "0x119EF84")]
		[Preserve]
		public static void ParentMomentumRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x119F054", Offset = "0x119F054", VA = "0x119F054")]
		[Preserve]
		public static void ParentSaver_op_Equality()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x119F124", Offset = "0x119F124", VA = "0x119F124")]
		[Preserve]
		public static void ParentSaver_op_Implicit()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x119F1EC", Offset = "0x119F1EC", VA = "0x119F1EC")]
		[Preserve]
		public static void ParentSaver_op_Inequality()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x119F2BC", Offset = "0x119F2BC", VA = "0x119F2BC")]
		[Preserve]
		public static void ParticleForceFieldRotation_op_Equality()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x119F38C", Offset = "0x119F38C", VA = "0x119F38C")]
		[Preserve]
		public static void ParticleForceFieldRotation_op_Implicit()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x119F454", Offset = "0x119F454", VA = "0x119F454")]
		[Preserve]
		public static void ParticleForceFieldRotation_op_Inequality()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x119F524", Offset = "0x119F524", VA = "0x119F524")]
		[Preserve]
		public static void ParticleLifetimeEvents_op_Equality()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x119F5F4", Offset = "0x119F5F4", VA = "0x119F5F4")]
		[Preserve]
		public static void ParticleLifetimeEvents_op_Implicit()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x119F6BC", Offset = "0x119F6BC", VA = "0x119F6BC")]
		[Preserve]
		public static void ParticleLifetimeEvents_op_Inequality()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x119F78C", Offset = "0x119F78C", VA = "0x119F78C")]
		[Preserve]
		public static void ParticleMagnet_op_Equality()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x119F85C", Offset = "0x119F85C", VA = "0x119F85C")]
		[Preserve]
		public static void ParticleMagnet_op_Implicit()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x119F924", Offset = "0x119F924", VA = "0x119F924")]
		[Preserve]
		public static void ParticleMagnet_op_Inequality()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x119F9F4", Offset = "0x119F9F4", VA = "0x119F9F4")]
		[Preserve]
		public static void ParticleProfiler_op_Equality()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x119FAC4", Offset = "0x119FAC4", VA = "0x119FAC4")]
		[Preserve]
		public static void ParticleProfiler_op_Implicit()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x119FB8C", Offset = "0x119FB8C", VA = "0x119FB8C")]
		[Preserve]
		public static void ParticleProfiler_op_Inequality()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x119FC5C", Offset = "0x119FC5C", VA = "0x119FC5C")]
		[Preserve]
		public static void ParticleSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x119FD2C", Offset = "0x119FD2C", VA = "0x119FD2C")]
		[Preserve]
		public static void ParticleSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x119FDF4", Offset = "0x119FDF4", VA = "0x119FDF4")]
		[Preserve]
		public static void ParticleSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x119FEC4", Offset = "0x119FEC4", VA = "0x119FEC4")]
		[Preserve]
		public static void ParticleSystemQualitySettings_op_Equality()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x119FF94", Offset = "0x119FF94", VA = "0x119FF94")]
		[Preserve]
		public static void ParticleSystemQualitySettings_op_Implicit()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x11A005C", Offset = "0x11A005C", VA = "0x11A005C")]
		[Preserve]
		public static void ParticleSystemQualitySettings_op_Inequality()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x11A012C", Offset = "0x11A012C", VA = "0x11A012C")]
		[Preserve]
		public static void ParticleSystemSaver_op_Equality()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x11A01FC", Offset = "0x11A01FC", VA = "0x11A01FC")]
		[Preserve]
		public static void ParticleSystemSaver_op_Implicit()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x11A02C4", Offset = "0x11A02C4", VA = "0x11A02C4")]
		[Preserve]
		public static void ParticleSystemSaver_op_Inequality()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x11A0394", Offset = "0x11A0394", VA = "0x11A0394")]
		[Preserve]
		public static void ParticleTarget_op_Equality()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x11A0464", Offset = "0x11A0464", VA = "0x11A0464")]
		[Preserve]
		public static void ParticleTarget_op_Implicit()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x11A052C", Offset = "0x11A052C", VA = "0x11A052C")]
		[Preserve]
		public static void ParticleTarget_op_Inequality()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x11A05FC", Offset = "0x11A05FC", VA = "0x11A05FC")]
		[Preserve]
		public static void PauseInvisibleParticles_op_Equality()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x11A06CC", Offset = "0x11A06CC", VA = "0x11A06CC")]
		[Preserve]
		public static void PauseInvisibleParticles_op_Implicit()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x11A0794", Offset = "0x11A0794", VA = "0x11A0794")]
		[Preserve]
		public static void PauseInvisibleParticles_op_Inequality()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x11A0864", Offset = "0x11A0864", VA = "0x11A0864")]
		[Preserve]
		public static void PauseManager_op_Equality()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x11A0934", Offset = "0x11A0934", VA = "0x11A0934")]
		[Preserve]
		public static void PauseManager_op_Implicit()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x11A09FC", Offset = "0x11A09FC", VA = "0x11A09FC")]
		[Preserve]
		public static void PauseManager_op_Inequality()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x11A0ACC", Offset = "0x11A0ACC", VA = "0x11A0ACC")]
		[Preserve]
		public static void PauseMenuController_op_Equality()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x11A0B9C", Offset = "0x11A0B9C", VA = "0x11A0B9C")]
		[Preserve]
		public static void PauseMenuController_op_Implicit()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x11A0C64", Offset = "0x11A0C64", VA = "0x11A0C64")]
		[Preserve]
		public static void PauseMenuController_op_Inequality()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x11A0D34", Offset = "0x11A0D34", VA = "0x11A0D34")]
		[Preserve]
		public static void PauseMenuScreen_op_Equality()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x11A0E04", Offset = "0x11A0E04", VA = "0x11A0E04")]
		[Preserve]
		public static void PauseMenuScreen_op_Implicit()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x11A0ECC", Offset = "0x11A0ECC", VA = "0x11A0ECC")]
		[Preserve]
		public static void PauseMenuScreen_op_Inequality()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x11A0F9C", Offset = "0x11A0F9C", VA = "0x11A0F9C")]
		[Preserve]
		public static void PauseQuitConfirmScreen_op_Equality()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x11A106C", Offset = "0x11A106C", VA = "0x11A106C")]
		[Preserve]
		public static void PauseQuitConfirmScreen_op_Implicit()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x11A1134", Offset = "0x11A1134", VA = "0x11A1134")]
		[Preserve]
		public static void PauseQuitConfirmScreen_op_Inequality()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x11A1204", Offset = "0x11A1204", VA = "0x11A1204")]
		[Preserve]
		public static void PerformanceTestsMenu_op_Equality()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x11A12D4", Offset = "0x11A12D4", VA = "0x11A12D4")]
		[Preserve]
		public static void PerformanceTestsMenu_op_Implicit()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x11A139C", Offset = "0x11A139C", VA = "0x11A139C")]
		[Preserve]
		public static void PerformanceTestsMenu_op_Inequality()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x11A146C", Offset = "0x11A146C", VA = "0x11A146C")]
		[Preserve]
		public static void PerfTest_op_Equality()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x11A153C", Offset = "0x11A153C", VA = "0x11A153C")]
		[Preserve]
		public static void PerfTest_op_Implicit()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x11A1604", Offset = "0x11A1604", VA = "0x11A1604")]
		[Preserve]
		public static void PerfTest_op_Inequality()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x11A16D4", Offset = "0x11A16D4", VA = "0x11A16D4")]
		[Preserve]
		public static void PerlinAnimateMaterialProperty_op_Equality()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x11A17A4", Offset = "0x11A17A4", VA = "0x11A17A4")]
		[Preserve]
		public static void PerlinAnimateMaterialProperty_op_Implicit()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x11A186C", Offset = "0x11A186C", VA = "0x11A186C")]
		[Preserve]
		public static void PerlinAnimateMaterialProperty_op_Inequality()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x11A193C", Offset = "0x11A193C", VA = "0x11A193C")]
		[Preserve]
		public static void PerlinShake_op_Equality()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x11A1A0C", Offset = "0x11A1A0C", VA = "0x11A1A0C")]
		[Preserve]
		public static void PerlinShake_op_Implicit()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x11A1AD4", Offset = "0x11A1AD4", VA = "0x11A1AD4")]
		[Preserve]
		public static void PerlinShake_op_Inequality()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x11A1BA4", Offset = "0x11A1BA4", VA = "0x11A1BA4")]
		[Preserve]
		public static void PlayableDirectorSaveManager_op_Equality()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x11A1C74", Offset = "0x11A1C74", VA = "0x11A1C74")]
		[Preserve]
		public static void PlayableDirectorSaveManager_op_Implicit()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x11A1D3C", Offset = "0x11A1D3C", VA = "0x11A1D3C")]
		[Preserve]
		public static void PlayableDirectorSaveManager_op_Inequality()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x11A1E0C", Offset = "0x11A1E0C", VA = "0x11A1E0C")]
		[Preserve]
		public static void PlayableDirectorSaver_op_Equality()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x11A1EDC", Offset = "0x11A1EDC", VA = "0x11A1EDC")]
		[Preserve]
		public static void PlayableDirectorSaver_op_Implicit()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x11A1FA4", Offset = "0x11A1FA4", VA = "0x11A1FA4")]
		[Preserve]
		public static void PlayableDirectorSaver_op_Inequality()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x11A2074", Offset = "0x11A2074", VA = "0x11A2074")]
		[Preserve]
		public static void Player_DisableInputFromBolt()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x11A20A8", Offset = "0x11A20A8", VA = "0x11A20A8")]
		[Preserve]
		public static void Player_DisableInputFromBolt_0()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x11A20DC", Offset = "0x11A20DC", VA = "0x11A20DC")]
		[Preserve]
		public static void Player_DisableSaving()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x11A2110", Offset = "0x11A2110", VA = "0x11A2110")]
		[Preserve]
		public static void Player_EnableInputFromBolt()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x11A2144", Offset = "0x11A2144", VA = "0x11A2144")]
		[Preserve]
		public static void Player_EnableInputFromBolt_0()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x11A2178", Offset = "0x11A2178", VA = "0x11A2178")]
		[Preserve]
		public static void Player_EnableSaving()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x11A21AC", Offset = "0x11A21AC", VA = "0x11A21AC")]
		[Preserve]
		public static void Player_GetCurrentPlayerLocation()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x11A21E0", Offset = "0x11A21E0", VA = "0x11A21E0")]
		[Preserve]
		public static void Player_GetLocation()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x11A2214", Offset = "0x11A2214", VA = "0x11A2214")]
		[Preserve]
		public static void Player_GetMonologueMessageBox()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x11A2248", Offset = "0x11A2248", VA = "0x11A2248")]
		[Preserve]
		public static void Player_GetTutorialMessageBox()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x11A227C", Offset = "0x11A227C", VA = "0x11A227C")]
		[Preserve]
		public static void Player_IsTeleporting()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x11A22B0", Offset = "0x11A22B0", VA = "0x11A22B0")]
		[Preserve]
		public static void Player_op_Equality()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x11A2380", Offset = "0x11A2380", VA = "0x11A2380")]
		[Preserve]
		public static void Player_op_Implicit()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x11A2448", Offset = "0x11A2448", VA = "0x11A2448")]
		[Preserve]
		public static void Player_op_Inequality()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x11A2518", Offset = "0x11A2518", VA = "0x11A2518")]
		[Preserve]
		public static void Player_SetSnapTurnAllowed()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x11A254C", Offset = "0x11A254C", VA = "0x11A254C")]
		[Preserve]
		public static void Player_SetTeleportAllowed()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x11A2580", Offset = "0x11A2580", VA = "0x11A2580")]
		[Preserve]
		public static void Player_StartForceHoldingGrabbable()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x11A25B4", Offset = "0x11A25B4", VA = "0x11A25B4")]
		[Preserve]
		public static void Player_StopForceHoldingGrabbable()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x11A25E8", Offset = "0x11A25E8", VA = "0x11A25E8")]
		[Preserve]
		public static void Player_TeleportTo()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x11A261C", Offset = "0x11A261C", VA = "0x11A261C")]
		[Preserve]
		public static void PlayerInteractionState_op_Equality()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x11A26EC", Offset = "0x11A26EC", VA = "0x11A26EC")]
		[Preserve]
		public static void PlayerInteractionState_op_Implicit()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x11A27B4", Offset = "0x11A27B4", VA = "0x11A27B4")]
		[Preserve]
		public static void PlayerInteractionState_op_Inequality()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x11A2884", Offset = "0x11A2884", VA = "0x11A2884")]
		[Preserve]
		public static void PlayerLocation_Equals()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x11A28B8", Offset = "0x11A28B8", VA = "0x11A28B8")]
		[Preserve]
		public static void PlayerLocation_op_Equality()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x11A2988", Offset = "0x11A2988", VA = "0x11A2988")]
		[Preserve]
		public static void PlayerLocation_op_Implicit()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x11A2A50", Offset = "0x11A2A50", VA = "0x11A2A50")]
		[Preserve]
		public static void PlayerLocation_op_Inequality()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x11A2B20", Offset = "0x11A2B20", VA = "0x11A2B20")]
		[Preserve]
		public static void PlayerLocation_SetLocationsActive()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x11A2C0C", Offset = "0x11A2C0C", VA = "0x11A2C0C")]
		[Preserve]
		public static void PlayerLocation_SetState()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x11A2C40", Offset = "0x11A2C40", VA = "0x11A2C40")]
		[Preserve]
		public static void PlayerLocation_SetStateOnAllLocationsExcept()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x11A2D2C", Offset = "0x11A2D2C", VA = "0x11A2D2C")]
		[Preserve]
		public static void PlayerLocationInverted_op_Equality()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x11A2DFC", Offset = "0x11A2DFC", VA = "0x11A2DFC")]
		[Preserve]
		public static void PlayerLocationInverted_op_Implicit()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x11A2EC4", Offset = "0x11A2EC4", VA = "0x11A2EC4")]
		[Preserve]
		public static void PlayerLocationInverted_op_Inequality()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x11A2F94", Offset = "0x11A2F94", VA = "0x11A2F94")]
		[Preserve]
		public static void PlayerLocationQualitySettings_EnabledForGameplayReasons()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x11A2FC8", Offset = "0x11A2FC8", VA = "0x11A2FC8")]
		[Preserve]
		public static void PlayerLocationQualitySettings_op_Equality()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x11A3098", Offset = "0x11A3098", VA = "0x11A3098")]
		[Preserve]
		public static void PlayerLocationQualitySettings_op_Implicit()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x11A3160", Offset = "0x11A3160", VA = "0x11A3160")]
		[Preserve]
		public static void PlayerLocationQualitySettings_op_Inequality()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x11A3230", Offset = "0x11A3230", VA = "0x11A3230")]
		[Preserve]
		public static void PlayerLocationQualitySettingsManager_op_Equality()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x11A3300", Offset = "0x11A3300", VA = "0x11A3300")]
		[Preserve]
		public static void PlayerLocationQualitySettingsManager_op_Implicit()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x11A33C8", Offset = "0x11A33C8", VA = "0x11A33C8")]
		[Preserve]
		public static void PlayerLocationQualitySettingsManager_op_Inequality()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x11A3498", Offset = "0x11A3498", VA = "0x11A3498")]
		[Preserve]
		public static void PlayerLocationSaver_op_Equality()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x11A3568", Offset = "0x11A3568", VA = "0x11A3568")]
		[Preserve]
		public static void PlayerLocationSaver_op_Implicit()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x11A3630", Offset = "0x11A3630", VA = "0x11A3630")]
		[Preserve]
		public static void PlayerLocationSaver_op_Inequality()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x11A3700", Offset = "0x11A3700", VA = "0x11A3700")]
		[Preserve]
		public static void PlayerStartOverride_op_Equality()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x11A37D0", Offset = "0x11A37D0", VA = "0x11A37D0")]
		[Preserve]
		public static void PlayerStartOverride_op_Implicit()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x11A3898", Offset = "0x11A3898", VA = "0x11A3898")]
		[Preserve]
		public static void PlayerStartOverride_op_Inequality()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x11A3968", Offset = "0x11A3968", VA = "0x11A3968")]
		[Preserve]
		public static void PlayRandomClip_op_Equality()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x11A3A38", Offset = "0x11A3A38", VA = "0x11A3A38")]
		[Preserve]
		public static void PlayRandomClip_op_Implicit()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x11A3B00", Offset = "0x11A3B00", VA = "0x11A3B00")]
		[Preserve]
		public static void PlayRandomClip_op_Inequality()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x11A3BD0", Offset = "0x11A3BD0", VA = "0x11A3BD0")]
		[Preserve]
		public static void PlayTestAnimation_op_Equality()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x11A3CA0", Offset = "0x11A3CA0", VA = "0x11A3CA0")]
		[Preserve]
		public static void PlayTestAnimation_op_Implicit()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x11A3D68", Offset = "0x11A3D68", VA = "0x11A3D68")]
		[Preserve]
		public static void PlayTestAnimation_op_Inequality()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x11A3E38", Offset = "0x11A3E38", VA = "0x11A3E38")]
		[Preserve]
		public static void PointLight_enabled()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x11A3E6C", Offset = "0x11A3E6C", VA = "0x11A3E6C")]
		[Preserve]
		public static void PointLight_op_Equality()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x11A3F3C", Offset = "0x11A3F3C", VA = "0x11A3F3C")]
		[Preserve]
		public static void PointLight_op_Implicit()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x11A4004", Offset = "0x11A4004", VA = "0x11A4004")]
		[Preserve]
		public static void PointLight_op_Inequality()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x11A40D4", Offset = "0x11A40D4", VA = "0x11A40D4")]
		[Preserve]
		public static void Portal_Active()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x11A4108", Offset = "0x11A4108", VA = "0x11A4108")]
		[Preserve]
		public static void Portal_op_Equality()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x11A41D8", Offset = "0x11A41D8", VA = "0x11A41D8")]
		[Preserve]
		public static void Portal_op_Implicit()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x11A42A0", Offset = "0x11A42A0", VA = "0x11A42A0")]
		[Preserve]
		public static void Portal_op_Inequality()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x11A4370", Offset = "0x11A4370", VA = "0x11A4370")]
		[Preserve]
		public static void PortalCamera_op_Equality()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x11A4440", Offset = "0x11A4440", VA = "0x11A4440")]
		[Preserve]
		public static void PortalCamera_op_Implicit()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x11A4508", Offset = "0x11A4508", VA = "0x11A4508")]
		[Preserve]
		public static void PortalCamera_op_Inequality()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x11A45D8", Offset = "0x11A45D8", VA = "0x11A45D8")]
		[Preserve]
		public static void PortalDestination_op_Equality()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x11A46A8", Offset = "0x11A46A8", VA = "0x11A46A8")]
		[Preserve]
		public static void PortalDestination_op_Implicit()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x11A4770", Offset = "0x11A4770", VA = "0x11A4770")]
		[Preserve]
		public static void PortalDestination_op_Inequality()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x11A4840", Offset = "0x11A4840", VA = "0x11A4840")]
		[Preserve]
		public static void PortalSource_op_Equality()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x11A4910", Offset = "0x11A4910", VA = "0x11A4910")]
		[Preserve]
		public static void PortalSource_op_Implicit()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x11A49D8", Offset = "0x11A49D8", VA = "0x11A49D8")]
		[Preserve]
		public static void PortalSource_op_Inequality()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x11A4AA8", Offset = "0x11A4AA8", VA = "0x11A4AA8")]
		[Preserve]
		public static void PortalVisibility_Enable()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x11A4ADC", Offset = "0x11A4ADC", VA = "0x11A4ADC")]
		[Preserve]
		public static void PortalVisibility_op_Equality()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x11A4BAC", Offset = "0x11A4BAC", VA = "0x11A4BAC")]
		[Preserve]
		public static void PortalVisibility_op_Implicit()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x11A4C74", Offset = "0x11A4C74", VA = "0x11A4C74")]
		[Preserve]
		public static void PortalVisibility_op_Inequality()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x11A4D44", Offset = "0x11A4D44", VA = "0x11A4D44")]
		[Preserve]
		public static void PostGameScreen_op_Equality()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x11A4E14", Offset = "0x11A4E14", VA = "0x11A4E14")]
		[Preserve]
		public static void PostGameScreen_op_Implicit()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x11A4EDC", Offset = "0x11A4EDC", VA = "0x11A4EDC")]
		[Preserve]
		public static void PostGameScreen_op_Inequality()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x11A4FAC", Offset = "0x11A4FAC", VA = "0x11A4FAC")]
		[Preserve]
		public static void PostureSelectScreen_op_Equality()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x11A507C", Offset = "0x11A507C", VA = "0x11A507C")]
		[Preserve]
		public static void PostureSelectScreen_op_Implicit()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x11A5144", Offset = "0x11A5144", VA = "0x11A5144")]
		[Preserve]
		public static void PostureSelectScreen_op_Inequality()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x11A5214", Offset = "0x11A5214", VA = "0x11A5214")]
		[Preserve]
		public static void PotionBottle_op_Equality()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x11A52E4", Offset = "0x11A52E4", VA = "0x11A52E4")]
		[Preserve]
		public static void PotionBottle_op_Implicit()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x11A53AC", Offset = "0x11A53AC", VA = "0x11A53AC")]
		[Preserve]
		public static void PotionBottle_op_Inequality()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x11A547C", Offset = "0x11A547C", VA = "0x11A547C")]
		[Preserve]
		public static void PotionDispenser_op_Equality()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x11A554C", Offset = "0x11A554C", VA = "0x11A554C")]
		[Preserve]
		public static void PotionDispenser_op_Implicit()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x11A5614", Offset = "0x11A5614", VA = "0x11A5614")]
		[Preserve]
		public static void PotionDispenser_op_Inequality()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x11A56E4", Offset = "0x11A56E4", VA = "0x11A56E4")]
		[Preserve]
		public static void PreventMaterialRevert_op_Equality()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x11A57B4", Offset = "0x11A57B4", VA = "0x11A57B4")]
		[Preserve]
		public static void PreventMaterialRevert_op_Implicit()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x11A587C", Offset = "0x11A587C", VA = "0x11A587C")]
		[Preserve]
		public static void PreventMaterialRevert_op_Inequality()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x11A594C", Offset = "0x11A594C", VA = "0x11A594C")]
		[Preserve]
		public static void PreventTransformRevert_op_Equality()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x11A5A1C", Offset = "0x11A5A1C", VA = "0x11A5A1C")]
		[Preserve]
		public static void PreventTransformRevert_op_Implicit()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x11A5AE4", Offset = "0x11A5AE4", VA = "0x11A5AE4")]
		[Preserve]
		public static void PreventTransformRevert_op_Inequality()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x11A5BB4", Offset = "0x11A5BB4", VA = "0x11A5BB4")]
		[Preserve]
		public static void ProfileBadge_op_Equality()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x11A5C84", Offset = "0x11A5C84", VA = "0x11A5C84")]
		[Preserve]
		public static void ProfileBadge_op_Implicit()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x11A5D4C", Offset = "0x11A5D4C", VA = "0x11A5D4C")]
		[Preserve]
		public static void ProfileBadge_op_Inequality()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x11A5E1C", Offset = "0x11A5E1C", VA = "0x11A5E1C")]
		[Preserve]
		public static void ProfileButton_op_Equality()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x11A5EEC", Offset = "0x11A5EEC", VA = "0x11A5EEC")]
		[Preserve]
		public static void ProfileButton_op_Implicit()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x11A5FB4", Offset = "0x11A5FB4", VA = "0x11A5FB4")]
		[Preserve]
		public static void ProfileButton_op_Inequality()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x11A6084", Offset = "0x11A6084", VA = "0x11A6084")]
		[Preserve]
		public static void ProfileOptionsScreen_op_Equality()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x11A6154", Offset = "0x11A6154", VA = "0x11A6154")]
		[Preserve]
		public static void ProfileOptionsScreen_op_Implicit()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x11A621C", Offset = "0x11A621C", VA = "0x11A621C")]
		[Preserve]
		public static void ProfileOptionsScreen_op_Inequality()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x11A62EC", Offset = "0x11A62EC", VA = "0x11A62EC")]
		[Preserve]
		public static void Ps4SubmissionInfo_op_Equality()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x11A63BC", Offset = "0x11A63BC", VA = "0x11A63BC")]
		[Preserve]
		public static void Ps4SubmissionInfo_op_Implicit()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x11A6484", Offset = "0x11A6484", VA = "0x11A6484")]
		[Preserve]
		public static void Ps4SubmissionInfo_op_Inequality()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x11A6554", Offset = "0x11A6554", VA = "0x11A6554")]
		[Preserve]
		public static void QualityLevelVisibility_op_Equality()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x11A6624", Offset = "0x11A6624", VA = "0x11A6624")]
		[Preserve]
		public static void QualityLevelVisibility_op_Implicit()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x11A66EC", Offset = "0x11A66EC", VA = "0x11A66EC")]
		[Preserve]
		public static void QualityLevelVisibility_op_Inequality()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x11A67BC", Offset = "0x11A67BC", VA = "0x11A67BC")]
		[Preserve]
		public static void QualitySettingsManager_op_Equality()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x11A688C", Offset = "0x11A688C", VA = "0x11A688C")]
		[Preserve]
		public static void QualitySettingsManager_op_Implicit()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x11A6954", Offset = "0x11A6954", VA = "0x11A6954")]
		[Preserve]
		public static void QualitySettingsManager_op_Inequality()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x11A6A24", Offset = "0x11A6A24", VA = "0x11A6A24")]
		[Preserve]
		public static void RandomAudioEmitter_op_Equality()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x11A6AF4", Offset = "0x11A6AF4", VA = "0x11A6AF4")]
		[Preserve]
		public static void RandomAudioEmitter_op_Implicit()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x11A6BBC", Offset = "0x11A6BBC", VA = "0x11A6BBC")]
		[Preserve]
		public static void RandomAudioEmitter_op_Inequality()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x11A6C8C", Offset = "0x11A6C8C", VA = "0x11A6C8C")]
		[Preserve]
		public static void RandomIndex_op_Equality()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x11A6D5C", Offset = "0x11A6D5C", VA = "0x11A6D5C")]
		[Preserve]
		public static void RandomIndex_op_Implicit()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x11A6E24", Offset = "0x11A6E24", VA = "0x11A6E24")]
		[Preserve]
		public static void RandomIndex_op_Inequality()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x11A6EF4", Offset = "0x11A6EF4", VA = "0x11A6EF4")]
		[Preserve]
		public static void ReadyHandPoseVolume_op_Equality()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x11A6FC4", Offset = "0x11A6FC4", VA = "0x11A6FC4")]
		[Preserve]
		public static void ReadyHandPoseVolume_op_Implicit()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x11A708C", Offset = "0x11A708C", VA = "0x11A708C")]
		[Preserve]
		public static void ReadyHandPoseVolume_op_Inequality()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x11A715C", Offset = "0x11A715C", VA = "0x11A715C")]
		[Preserve]
		public static void RealtimeShadowCaster_op_Equality()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x11A722C", Offset = "0x11A722C", VA = "0x11A722C")]
		[Preserve]
		public static void RealtimeShadowCaster_op_Implicit()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x11A72F4", Offset = "0x11A72F4", VA = "0x11A72F4")]
		[Preserve]
		public static void RealtimeShadowCaster_op_Inequality()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x11A73C4", Offset = "0x11A73C4", VA = "0x11A73C4")]
		[Preserve]
		public static void ReflectionPlane_op_Equality()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x11A7494", Offset = "0x11A7494", VA = "0x11A7494")]
		[Preserve]
		public static void ReflectionPlane_op_Implicit()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x11A755C", Offset = "0x11A755C", VA = "0x11A755C")]
		[Preserve]
		public static void ReflectionPlane_op_Inequality()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x11A762C", Offset = "0x11A762C", VA = "0x11A762C")]
		[Preserve]
		public static void ReflectionReceiver_op_Equality()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x11A76FC", Offset = "0x11A76FC", VA = "0x11A76FC")]
		[Preserve]
		public static void ReflectionReceiver_op_Implicit()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x11A77C4", Offset = "0x11A77C4", VA = "0x11A77C4")]
		[Preserve]
		public static void ReflectionReceiver_op_Inequality()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x11A7894", Offset = "0x11A7894", VA = "0x11A7894")]
		[Preserve]
		public static void ReliquaryHoloBridgeRopeSystem_op_Equality()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x11A7964", Offset = "0x11A7964", VA = "0x11A7964")]
		[Preserve]
		public static void ReliquaryHoloBridgeRopeSystem_op_Implicit()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x11A7A2C", Offset = "0x11A7A2C", VA = "0x11A7A2C")]
		[Preserve]
		public static void ReliquaryHoloBridgeRopeSystem_op_Inequality()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x11A7AFC", Offset = "0x11A7AFC", VA = "0x11A7AFC")]
		[Preserve]
		public static void ReliquaryHoloBridgeSegment_op_Equality()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x11A7BCC", Offset = "0x11A7BCC", VA = "0x11A7BCC")]
		[Preserve]
		public static void ReliquaryHoloBridgeSegment_op_Implicit()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x11A7C94", Offset = "0x11A7C94", VA = "0x11A7C94")]
		[Preserve]
		public static void ReliquaryHoloBridgeSegment_op_Inequality()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x11A7D64", Offset = "0x11A7D64", VA = "0x11A7D64")]
		[Preserve]
		public static void ReliquaryHologramJar_op_Equality()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x11A7E34", Offset = "0x11A7E34", VA = "0x11A7E34")]
		[Preserve]
		public static void ReliquaryHologramJar_op_Implicit()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x11A7EFC", Offset = "0x11A7EFC", VA = "0x11A7EFC")]
		[Preserve]
		public static void ReliquaryHologramJar_op_Inequality()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x11A7FCC", Offset = "0x11A7FCC", VA = "0x11A7FCC")]
		[Preserve]
		public static void ReliquaryMaze_op_Equality()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x11A809C", Offset = "0x11A809C", VA = "0x11A809C")]
		[Preserve]
		public static void ReliquaryMaze_op_Implicit()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x11A8164", Offset = "0x11A8164", VA = "0x11A8164")]
		[Preserve]
		public static void ReliquaryMaze_op_Inequality()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x11A8234", Offset = "0x11A8234", VA = "0x11A8234")]
		[Preserve]
		public static void ReliquaryMazeLocationSet_op_Equality()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x11A8304", Offset = "0x11A8304", VA = "0x11A8304")]
		[Preserve]
		public static void ReliquaryMazeLocationSet_op_Implicit()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x11A83CC", Offset = "0x11A83CC", VA = "0x11A83CC")]
		[Preserve]
		public static void ReliquaryMazeLocationSet_op_Inequality()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x11A849C", Offset = "0x11A849C", VA = "0x11A849C")]
		[Preserve]
		public static void ReliquarySuperzoomActivator_ctor()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x11A84EC", Offset = "0x11A84EC", VA = "0x11A84EC")]
		[Preserve]
		public static void ReliquarySuperzoomActivator_op_Equality()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x11A85BC", Offset = "0x11A85BC", VA = "0x11A85BC")]
		[Preserve]
		public static void ReliquarySuperzoomActivator_op_Implicit()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x11A8684", Offset = "0x11A8684", VA = "0x11A8684")]
		[Preserve]
		public static void ReliquarySuperzoomActivator_op_Inequality()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x11A8754", Offset = "0x11A8754", VA = "0x11A8754")]
		[Preserve]
		public static void ReliquarySuperzoomActivator_SetCurrentSuperzoomIndex()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x11A8788", Offset = "0x11A8788", VA = "0x11A8788")]
		[Preserve]
		public static void ReliquarySuperzoomActivator_SetPrimed()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x11A87BC", Offset = "0x11A87BC", VA = "0x11A87BC")]
		[Preserve]
		public static void ReloadOnSave_op_Equality()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x11A888C", Offset = "0x11A888C", VA = "0x11A888C")]
		[Preserve]
		public static void ReloadOnSave_op_Implicit()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x11A8954", Offset = "0x11A8954", VA = "0x11A8954")]
		[Preserve]
		public static void ReloadOnSave_op_Inequality()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x11A8A24", Offset = "0x11A8A24", VA = "0x11A8A24")]
		[Preserve]
		public static void ResetHeight_op_Equality()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x11A8AF4", Offset = "0x11A8AF4", VA = "0x11A8AF4")]
		[Preserve]
		public static void ResetHeight_op_Implicit()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x11A8BBC", Offset = "0x11A8BBC", VA = "0x11A8BBC")]
		[Preserve]
		public static void ResetHeight_op_Inequality()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x11A8C8C", Offset = "0x11A8C8C", VA = "0x11A8C8C")]
		[Preserve]
		public static void ResetViewScreen_op_Equality()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x11A8D5C", Offset = "0x11A8D5C", VA = "0x11A8D5C")]
		[Preserve]
		public static void ResetViewScreen_op_Implicit()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x11A8E24", Offset = "0x11A8E24", VA = "0x11A8E24")]
		[Preserve]
		public static void ResetViewScreen_op_Inequality()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x11A8EF4", Offset = "0x11A8EF4", VA = "0x11A8EF4")]
		[Preserve]
		public static void ResourceStreamer_op_Equality()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x11A8FC4", Offset = "0x11A8FC4", VA = "0x11A8FC4")]
		[Preserve]
		public static void ResourceStreamer_op_Implicit()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x11A908C", Offset = "0x11A908C", VA = "0x11A908C")]
		[Preserve]
		public static void ResourceStreamer_op_Inequality()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x11A915C", Offset = "0x11A915C", VA = "0x11A915C")]
		[Preserve]
		public static void ReturnToPointSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x11A922C", Offset = "0x11A922C", VA = "0x11A922C")]
		[Preserve]
		public static void ReturnToPointSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x11A92F4", Offset = "0x11A92F4", VA = "0x11A92F4")]
		[Preserve]
		public static void ReturnToPointSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x11A93C4", Offset = "0x11A93C4", VA = "0x11A93C4")]
		[Preserve]
		public static void Rewired_ComponentControls_ComponentControl_op_Equality()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x11A9494", Offset = "0x11A9494", VA = "0x11A9494")]
		[Preserve]
		public static void Rewired_ComponentControls_ComponentControl_op_Implicit()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x11A955C", Offset = "0x11A955C", VA = "0x11A955C")]
		[Preserve]
		public static void Rewired_ComponentControls_ComponentControl_op_Inequality()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x11A962C", Offset = "0x11A962C", VA = "0x11A962C")]
		[Preserve]
		public static void Rewired_ComponentControls_ComponentController_op_Equality()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x11A96FC", Offset = "0x11A96FC", VA = "0x11A96FC")]
		[Preserve]
		public static void Rewired_ComponentControls_ComponentController_op_Implicit()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x11A97C4", Offset = "0x11A97C4", VA = "0x11A97C4")]
		[Preserve]
		public static void Rewired_ComponentControls_ComponentController_op_Inequality()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x11A9894", Offset = "0x11A9894", VA = "0x11A9894")]
		[Preserve]
		public static void Rewired_ComponentControls_CustomController_op_Equality()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x11A9964", Offset = "0x11A9964", VA = "0x11A9964")]
		[Preserve]
		public static void Rewired_ComponentControls_CustomController_op_Implicit()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x11A9A2C", Offset = "0x11A9A2C", VA = "0x11A9A2C")]
		[Preserve]
		public static void Rewired_ComponentControls_CustomController_op_Inequality()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x11A9AFC", Offset = "0x11A9AFC", VA = "0x11A9AFC")]
		[Preserve]
		public static void Rewired_ComponentControls_CustomControllerControl_op_Equality()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x11A9BCC", Offset = "0x11A9BCC", VA = "0x11A9BCC")]
		[Preserve]
		public static void Rewired_ComponentControls_CustomControllerControl_op_Implicit()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x11A9C94", Offset = "0x11A9C94", VA = "0x11A9C94")]
		[Preserve]
		public static void Rewired_ComponentControls_CustomControllerControl_op_Inequality()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x11A9D64", Offset = "0x11A9D64", VA = "0x11A9D64")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_RotateAroundAxis_op_Equality()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x11A9E34", Offset = "0x11A9E34", VA = "0x11A9E34")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_RotateAroundAxis_op_Implicit()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x11A9EFC", Offset = "0x11A9EFC", VA = "0x11A9EFC")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_RotateAroundAxis_op_Inequality()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x11A9FCC", Offset = "0x11A9FCC", VA = "0x11A9FCC")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_TouchInteractableTransitioner_op_Equality()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x11AA09C", Offset = "0x11AA09C", VA = "0x11AA09C")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_TouchInteractableTransitioner_op_Implicit()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x11AA164", Offset = "0x11AA164", VA = "0x11AA164")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_TouchInteractableTransitioner_op_Inequality()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x11AA234", Offset = "0x11AA234", VA = "0x11AA234")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_TouchJoystickAngleIndicator_op_Equality()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x11AA304", Offset = "0x11AA304", VA = "0x11AA304")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_TouchJoystickAngleIndicator_op_Implicit()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x11AA3CC", Offset = "0x11AA3CC", VA = "0x11AA3CC")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_TouchJoystickAngleIndicator_op_Inequality()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x11AA49C", Offset = "0x11AA49C", VA = "0x11AA49C")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_TouchJoystickRadialIndicator_op_Equality()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x11AA56C", Offset = "0x11AA56C", VA = "0x11AA56C")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_TouchJoystickRadialIndicator_op_Implicit()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x11AA634", Offset = "0x11AA634", VA = "0x11AA634")]
		[Preserve]
		public static void Rewired_ComponentControls_Effects_TouchJoystickRadialIndicator_op_Inequality()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x11AA704", Offset = "0x11AA704", VA = "0x11AA704")]
		[Preserve]
		public static void Rewired_ComponentControls_TiltControl_op_Equality()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x11AA7D4", Offset = "0x11AA7D4", VA = "0x11AA7D4")]
		[Preserve]
		public static void Rewired_ComponentControls_TiltControl_op_Implicit()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x11AA89C", Offset = "0x11AA89C", VA = "0x11AA89C")]
		[Preserve]
		public static void Rewired_ComponentControls_TiltControl_op_Inequality()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x11AA96C", Offset = "0x11AA96C", VA = "0x11AA96C")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchButton_op_Equality()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x11AAA3C", Offset = "0x11AAA3C", VA = "0x11AAA3C")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchButton_op_Implicit()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x11AAB04", Offset = "0x11AAB04", VA = "0x11AAB04")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchButton_op_Inequality()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x11AABD4", Offset = "0x11AABD4", VA = "0x11AABD4")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchControl_op_Equality()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x11AACA4", Offset = "0x11AACA4", VA = "0x11AACA4")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchControl_op_Implicit()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x11AAD6C", Offset = "0x11AAD6C", VA = "0x11AAD6C")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchControl_op_Inequality()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x11AAE3C", Offset = "0x11AAE3C", VA = "0x11AAE3C")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchController_op_Equality()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x11AAF0C", Offset = "0x11AAF0C", VA = "0x11AAF0C")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchController_op_Implicit()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x11AAFD4", Offset = "0x11AAFD4", VA = "0x11AAFD4")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchController_op_Inequality()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x11AB0A4", Offset = "0x11AB0A4", VA = "0x11AB0A4")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchInteractable_op_Equality()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x11AB174", Offset = "0x11AB174", VA = "0x11AB174")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchInteractable_op_Implicit()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x11AB23C", Offset = "0x11AB23C", VA = "0x11AB23C")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchInteractable_op_Inequality()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x11AB30C", Offset = "0x11AB30C", VA = "0x11AB30C")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchJoystick_op_Equality()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x11AB3DC", Offset = "0x11AB3DC", VA = "0x11AB3DC")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchJoystick_op_Implicit()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x11AB4A4", Offset = "0x11AB4A4", VA = "0x11AB4A4")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchJoystick_op_Inequality()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x11AB574", Offset = "0x11AB574", VA = "0x11AB574")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchPad_op_Equality()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x11AB644", Offset = "0x11AB644", VA = "0x11AB644")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchPad_op_Implicit()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x11AB70C", Offset = "0x11AB70C", VA = "0x11AB70C")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchPad_op_Inequality()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x11AB7DC", Offset = "0x11AB7DC", VA = "0x11AB7DC")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchRegion_op_Equality()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x11AB8AC", Offset = "0x11AB8AC", VA = "0x11AB8AC")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchRegion_op_Implicit()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x11AB974", Offset = "0x11AB974", VA = "0x11AB974")]
		[Preserve]
		public static void Rewired_ComponentControls_TouchRegion_op_Inequality()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x11ABA44", Offset = "0x11ABA44", VA = "0x11ABA44")]
		[Preserve]
		public static void Rewired_Components_PlayerController_op_Equality()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x11ABB14", Offset = "0x11ABB14", VA = "0x11ABB14")]
		[Preserve]
		public static void Rewired_Components_PlayerController_op_Implicit()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x11ABBDC", Offset = "0x11ABBDC", VA = "0x11ABBDC")]
		[Preserve]
		public static void Rewired_Components_PlayerController_op_Inequality()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x11ABCAC", Offset = "0x11ABCAC", VA = "0x11ABCAC")]
		[Preserve]
		public static void Rewired_Components_PlayerMouse_op_Equality()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x11ABD7C", Offset = "0x11ABD7C", VA = "0x11ABD7C")]
		[Preserve]
		public static void Rewired_Components_PlayerMouse_op_Implicit()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x11ABE44", Offset = "0x11ABE44", VA = "0x11ABE44")]
		[Preserve]
		public static void Rewired_Components_PlayerMouse_op_Inequality()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x11ABF14", Offset = "0x11ABF14", VA = "0x11ABF14")]
		[Preserve]
		public static void Rewired_Data_ControllerDataFiles_op_Equality()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x11ABFE4", Offset = "0x11ABFE4", VA = "0x11ABFE4")]
		[Preserve]
		public static void Rewired_Data_ControllerDataFiles_op_Implicit()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x11AC0AC", Offset = "0x11AC0AC", VA = "0x11AC0AC")]
		[Preserve]
		public static void Rewired_Data_ControllerDataFiles_op_Inequality()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x11AC17C", Offset = "0x11AC17C", VA = "0x11AC17C")]
		[Preserve]
		public static void Rewired_Data_EditorPlatformData_op_Equality()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x11AC24C", Offset = "0x11AC24C", VA = "0x11AC24C")]
		[Preserve]
		public static void Rewired_Data_EditorPlatformData_op_Implicit()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x11AC314", Offset = "0x11AC314", VA = "0x11AC314")]
		[Preserve]
		public static void Rewired_Data_EditorPlatformData_op_Inequality()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x11AC3E4", Offset = "0x11AC3E4", VA = "0x11AC3E4")]
		[Preserve]
		public static void Rewired_Data_EditorSettings_op_Equality()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x11AC4B4", Offset = "0x11AC4B4", VA = "0x11AC4B4")]
		[Preserve]
		public static void Rewired_Data_EditorSettings_op_Implicit()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x11AC57C", Offset = "0x11AC57C", VA = "0x11AC57C")]
		[Preserve]
		public static void Rewired_Data_EditorSettings_op_Inequality()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x11AC64C", Offset = "0x11AC64C", VA = "0x11AC64C")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_op_Equality()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x11AC71C", Offset = "0x11AC71C", VA = "0x11AC71C")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_op_Implicit()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x11AC7E4", Offset = "0x11AC7E4", VA = "0x11AC7E4")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_op_Inequality()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x11AC8B4", Offset = "0x11AC8B4", VA = "0x11AC8B4")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_Accelerometer_op_Equality()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x11AC984", Offset = "0x11AC984", VA = "0x11AC984")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_Accelerometer_op_Implicit()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x11ACA4C", Offset = "0x11ACA4C", VA = "0x11ACA4C")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_Accelerometer_op_Inequality()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x11ACB1C", Offset = "0x11ACB1C", VA = "0x11ACB1C")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_CompareElementValues_op_Equality()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x11ACBEC", Offset = "0x11ACBEC", VA = "0x11ACBEC")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_CompareElementValues_op_Implicit()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x11ACCB4", Offset = "0x11ACCB4", VA = "0x11ACCB4")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_CompareElementValues_op_Inequality()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x11ACD84", Offset = "0x11ACD84", VA = "0x11ACD84")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_FirstNonZero_op_Equality()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x11ACE54", Offset = "0x11ACE54", VA = "0x11ACE54")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_FirstNonZero_op_Implicit()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x11ACF1C", Offset = "0x11ACF1C", VA = "0x11ACF1C")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_FirstNonZero_op_Inequality()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x11ACFEC", Offset = "0x11ACFEC", VA = "0x11ACFEC")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_LogitechGRacingWheelPedals_op_Equality()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x11AD0BC", Offset = "0x11AD0BC", VA = "0x11AD0BC")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_LogitechGRacingWheelPedals_op_Implicit()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x11AD184", Offset = "0x11AD184", VA = "0x11AD184")]
		[Preserve]
		public static void Rewired_Data_Mapping_CustomCalculation_LogitechGRacingWheelPedals_op_Inequality()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x11AD254", Offset = "0x11AD254", VA = "0x11AD254")]
		[Preserve]
		public static void Rewired_Data_Mapping_HardwareControllerTemplateMap_op_Equality()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x11AD324", Offset = "0x11AD324", VA = "0x11AD324")]
		[Preserve]
		public static void Rewired_Data_Mapping_HardwareControllerTemplateMap_op_Implicit()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x11AD3EC", Offset = "0x11AD3EC", VA = "0x11AD3EC")]
		[Preserve]
		public static void Rewired_Data_Mapping_HardwareControllerTemplateMap_op_Inequality()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x11AD4BC", Offset = "0x11AD4BC", VA = "0x11AD4BC")]
		[Preserve]
		public static void Rewired_Data_Mapping_HardwareJoystickMap_op_Equality()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x11AD58C", Offset = "0x11AD58C", VA = "0x11AD58C")]
		[Preserve]
		public static void Rewired_Data_Mapping_HardwareJoystickMap_op_Implicit()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x11AD654", Offset = "0x11AD654", VA = "0x11AD654")]
		[Preserve]
		public static void Rewired_Data_Mapping_HardwareJoystickMap_op_Inequality()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x11AD724", Offset = "0x11AD724", VA = "0x11AD724")]
		[Preserve]
		public static void Rewired_Data_Mapping_HardwareJoystickTemplateMap_op_Equality()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x11AD7F4", Offset = "0x11AD7F4", VA = "0x11AD7F4")]
		[Preserve]
		public static void Rewired_Data_Mapping_HardwareJoystickTemplateMap_op_Implicit()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x11AD8BC", Offset = "0x11AD8BC", VA = "0x11AD8BC")]
		[Preserve]
		public static void Rewired_Data_Mapping_HardwareJoystickTemplateMap_op_Inequality()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x11AD98C", Offset = "0x11AD98C", VA = "0x11AD98C")]
		[Preserve]
		public static void Rewired_Data_RuntimeData_op_Equality()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x11ADA5C", Offset = "0x11ADA5C", VA = "0x11ADA5C")]
		[Preserve]
		public static void Rewired_Data_RuntimeData_op_Implicit()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x11ADB24", Offset = "0x11ADB24", VA = "0x11ADB24")]
		[Preserve]
		public static void Rewired_Data_RuntimeData_op_Inequality()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x11ADBF4", Offset = "0x11ADBF4", VA = "0x11ADBF4")]
		[Preserve]
		public static void Rewired_Data_UserDataStore_op_Equality()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x11ADCC4", Offset = "0x11ADCC4", VA = "0x11ADCC4")]
		[Preserve]
		public static void Rewired_Data_UserDataStore_op_Implicit()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x11ADD8C", Offset = "0x11ADD8C", VA = "0x11ADD8C")]
		[Preserve]
		public static void Rewired_Data_UserDataStore_op_Inequality()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x11ADE5C", Offset = "0x11ADE5C", VA = "0x11ADE5C")]
		[Preserve]
		public static void Rewired_Dev_Tools_DebugInformation_op_Equality()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x11ADF2C", Offset = "0x11ADF2C", VA = "0x11ADF2C")]
		[Preserve]
		public static void Rewired_Dev_Tools_DebugInformation_op_Implicit()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x11ADFF4", Offset = "0x11ADFF4", VA = "0x11ADFF4")]
		[Preserve]
		public static void Rewired_Dev_Tools_DebugInformation_op_Inequality()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x11AE0C4", Offset = "0x11AE0C4", VA = "0x11AE0C4")]
		[Preserve]
		public static void Rewired_Dev_Tools_DirectInputJoystickElementIdentifier_op_Equality()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x11AE194", Offset = "0x11AE194", VA = "0x11AE194")]
		[Preserve]
		public static void Rewired_Dev_Tools_DirectInputJoystickElementIdentifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x11AE25C", Offset = "0x11AE25C", VA = "0x11AE25C")]
		[Preserve]
		public static void Rewired_Dev_Tools_DirectInputJoystickElementIdentifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x11AE32C", Offset = "0x11AE32C", VA = "0x11AE32C")]
		[Preserve]
		public static void Rewired_Dev_Tools_JoystickElementIdentifier_op_Equality()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x11AE3FC", Offset = "0x11AE3FC", VA = "0x11AE3FC")]
		[Preserve]
		public static void Rewired_Dev_Tools_JoystickElementIdentifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x11AE4C4", Offset = "0x11AE4C4", VA = "0x11AE4C4")]
		[Preserve]
		public static void Rewired_Dev_Tools_JoystickElementIdentifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x11AE594", Offset = "0x11AE594", VA = "0x11AE594")]
		[Preserve]
		public static void Rewired_Dev_Tools_OSXJoystickElementIdentifier_op_Equality()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x11AE664", Offset = "0x11AE664", VA = "0x11AE664")]
		[Preserve]
		public static void Rewired_Dev_Tools_OSXJoystickElementIdentifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x11AE72C", Offset = "0x11AE72C", VA = "0x11AE72C")]
		[Preserve]
		public static void Rewired_Dev_Tools_OSXJoystickElementIdentifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x11AE7FC", Offset = "0x11AE7FC", VA = "0x11AE7FC")]
		[Preserve]
		public static void Rewired_Dev_Tools_RawInputJoystickElementIdentifier_op_Equality()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x11AE8CC", Offset = "0x11AE8CC", VA = "0x11AE8CC")]
		[Preserve]
		public static void Rewired_Dev_Tools_RawInputJoystickElementIdentifier_op_Implicit()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x11AE994", Offset = "0x11AE994", VA = "0x11AE994")]
		[Preserve]
		public static void Rewired_Dev_Tools_RawInputJoystickElementIdentifier_op_Inequality()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x11AEA64", Offset = "0x11AEA64", VA = "0x11AEA64")]
		[Preserve]
		public static void Rewired_Dev_Tools_UnityJoystickElementIdentifier_op_Equality()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x11AEB34", Offset = "0x11AEB34", VA = "0x11AEB34")]
		[Preserve]
		public static void Rewired_Dev_Tools_UnityJoystickElementIdentifier_op_Implicit()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x11AEBFC", Offset = "0x11AEBFC", VA = "0x11AEBFC")]
		[Preserve]
		public static void Rewired_Dev_Tools_UnityJoystickElementIdentifier_op_Inequality()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x11AECCC", Offset = "0x11AECCC", VA = "0x11AECCC")]
		[Preserve]
		public static void Rewired_Initializer_op_Equality()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x11AED9C", Offset = "0x11AED9C", VA = "0x11AED9C")]
		[Preserve]
		public static void Rewired_Initializer_op_Implicit()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x11AEE64", Offset = "0x11AEE64", VA = "0x11AEE64")]
		[Preserve]
		public static void Rewired_Initializer_op_Inequality()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x11AEF34", Offset = "0x11AEF34", VA = "0x11AEF34")]
		[Preserve]
		public static void Rewired_InputManager_Base_op_Equality()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x11AF004", Offset = "0x11AF004", VA = "0x11AF004")]
		[Preserve]
		public static void Rewired_InputManager_Base_op_Implicit()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x11AF0CC", Offset = "0x11AF0CC", VA = "0x11AF0CC")]
		[Preserve]
		public static void Rewired_InputManager_Base_op_Inequality()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x11AF19C", Offset = "0x11AF19C", VA = "0x11AF19C")]
		[Preserve]
		public static void Rewired_Internal_GUIText_op_Equality()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x11AF26C", Offset = "0x11AF26C", VA = "0x11AF26C")]
		[Preserve]
		public static void Rewired_Internal_GUIText_op_Implicit()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x11AF334", Offset = "0x11AF334", VA = "0x11AF334")]
		[Preserve]
		public static void Rewired_Internal_GUIText_op_Inequality()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x11AF404", Offset = "0x11AF404", VA = "0x11AF404")]
		[Preserve]
		public static void Rewired_Internal_OnGUIHelper_op_Equality()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x11AF4D4", Offset = "0x11AF4D4", VA = "0x11AF4D4")]
		[Preserve]
		public static void Rewired_Internal_OnGUIHelper_op_Implicit()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x11AF59C", Offset = "0x11AF59C", VA = "0x11AF59C")]
		[Preserve]
		public static void Rewired_Internal_OnGUIHelper_op_Inequality()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x11AF66C", Offset = "0x11AF66C", VA = "0x11AF66C")]
		[Preserve]
		public static void Rewired_Utils_Classes_SerializedMethod_op_Equality()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x11AF73C", Offset = "0x11AF73C", VA = "0x11AF73C")]
		[Preserve]
		public static void Rewired_Utils_Classes_SerializedMethod_op_Implicit()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x11AF804", Offset = "0x11AF804", VA = "0x11AF804")]
		[Preserve]
		public static void Rewired_Utils_Classes_SerializedMethod_op_Inequality()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x11AF8D4", Offset = "0x11AF8D4", VA = "0x11AF8D4")]
		[Preserve]
		public static void RewiredConsts_RwAction_INVENTORYLEFT()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x11AF954", Offset = "0x11AF954", VA = "0x11AF954")]
		[Preserve]
		public static void RewiredConsts_RwAction_INVENTORYRIGHT()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x11AF9D4", Offset = "0x11AF9D4", VA = "0x11AF9D4")]
		[Preserve]
		public static void RewiredConsts_RwAction_LEFTGRAB()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x11AFA54", Offset = "0x11AFA54", VA = "0x11AFA54")]
		[Preserve]
		public static void RewiredConsts_RwAction_RIGHTGRAB()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x11AFAD4", Offset = "0x11AFAD4", VA = "0x11AFAD4")]
		[Preserve]
		public static void RewiredConsts_RwAction_SNAPTURNLEFT()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x11AFB54", Offset = "0x11AFB54", VA = "0x11AFB54")]
		[Preserve]
		public static void RewiredConsts_RwAction_SNAPTURNRIGHT()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x11AFBD4", Offset = "0x11AFBD4", VA = "0x11AFBD4")]
		[Preserve]
		public static void RewiredConsts_RwAction_TELEPORTLEFT()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x11AFC54", Offset = "0x11AFC54", VA = "0x11AFC54")]
		[Preserve]
		public static void RewiredConsts_RwAction_TELEPORTRIGHT()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x11AFCD4", Offset = "0x11AFCD4", VA = "0x11AFCD4")]
		[Preserve]
		public static void RigidBodyConstraintBox_op_Equality()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x11AFDA4", Offset = "0x11AFDA4", VA = "0x11AFDA4")]
		[Preserve]
		public static void RigidBodyConstraintBox_op_Implicit()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x11AFE6C", Offset = "0x11AFE6C", VA = "0x11AFE6C")]
		[Preserve]
		public static void RigidBodyConstraintBox_op_Inequality()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x11AFF3C", Offset = "0x11AFF3C", VA = "0x11AFF3C")]
		[Preserve]
		public static void RigidbodySetInitialVelocity_op_Equality()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x11B000C", Offset = "0x11B000C", VA = "0x11B000C")]
		[Preserve]
		public static void RigidbodySetInitialVelocity_op_Implicit()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x11B00D4", Offset = "0x11B00D4", VA = "0x11B00D4")]
		[Preserve]
		public static void RigidbodySetInitialVelocity_op_Inequality()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x11B01A4", Offset = "0x11B01A4", VA = "0x11B01A4")]
		[Preserve]
		public static void RoomVrBugReportAction_op_Equality()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x11B0274", Offset = "0x11B0274", VA = "0x11B0274")]
		[Preserve]
		public static void RoomVrBugReportAction_op_Implicit()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x11B033C", Offset = "0x11B033C", VA = "0x11B033C")]
		[Preserve]
		public static void RoomVrBugReportAction_op_Inequality()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x11B040C", Offset = "0x11B040C", VA = "0x11B040C")]
		[Preserve]
		public static void RoomVrBugReportMenu_op_Equality()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x11B04DC", Offset = "0x11B04DC", VA = "0x11B04DC")]
		[Preserve]
		public static void RoomVrBugReportMenu_op_Implicit()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x11B05A4", Offset = "0x11B05A4", VA = "0x11B05A4")]
		[Preserve]
		public static void RoomVrBugReportMenu_op_Inequality()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x11B0674", Offset = "0x11B0674", VA = "0x11B0674")]
		[Preserve]
		public static void RopeControlledSystem_op_Equality()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x11B0744", Offset = "0x11B0744", VA = "0x11B0744")]
		[Preserve]
		public static void RopeControlledSystem_op_Implicit()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x11B080C", Offset = "0x11B080C", VA = "0x11B080C")]
		[Preserve]
		public static void RopeControlledSystem_op_Inequality()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x11B08DC", Offset = "0x11B08DC", VA = "0x11B08DC")]
		[Preserve]
		public static void RopeGrabbable_op_Equality()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x11B09AC", Offset = "0x11B09AC", VA = "0x11B09AC")]
		[Preserve]
		public static void RopeGrabbable_op_Implicit()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x11B0A74", Offset = "0x11B0A74", VA = "0x11B0A74")]
		[Preserve]
		public static void RopeGrabbable_op_Inequality()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x11B0B44", Offset = "0x11B0B44", VA = "0x11B0B44")]
		[Preserve]
		public static void RopeGrabbable_SetState()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x11B0B78", Offset = "0x11B0B78", VA = "0x11B0B78")]
		[Preserve]
		public static void RopeScaler_op_Equality()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x11B0C48", Offset = "0x11B0C48", VA = "0x11B0C48")]
		[Preserve]
		public static void RopeScaler_op_Implicit()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x11B0D10", Offset = "0x11B0D10", VA = "0x11B0D10")]
		[Preserve]
		public static void RopeScaler_op_Inequality()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x11B0DE0", Offset = "0x11B0DE0", VA = "0x11B0DE0")]
		[Preserve]
		public static void RopeSystem_op_Equality()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x11B0EB0", Offset = "0x11B0EB0", VA = "0x11B0EB0")]
		[Preserve]
		public static void RopeSystem_op_Implicit()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x11B0F78", Offset = "0x11B0F78", VA = "0x11B0F78")]
		[Preserve]
		public static void RopeSystem_op_Inequality()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x11B1048", Offset = "0x11B1048", VA = "0x11B1048")]
		[Preserve]
		public static void RopeSystem_SetConnectedSystem()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x11B107C", Offset = "0x11B107C", VA = "0x11B107C")]
		[Preserve]
		public static void RotateItemClicker_enabled()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x11B10B0", Offset = "0x11B10B0", VA = "0x11B10B0")]
		[Preserve]
		public static void RotateItemClicker_op_Equality()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x11B1180", Offset = "0x11B1180", VA = "0x11B1180")]
		[Preserve]
		public static void RotateItemClicker_op_Implicit()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x11B1248", Offset = "0x11B1248", VA = "0x11B1248")]
		[Preserve]
		public static void RotateItemClicker_op_Inequality()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x11B1318", Offset = "0x11B1318", VA = "0x11B1318")]
		[Preserve]
		public static void RotateUsingKeyboard_op_Equality()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x11B13E8", Offset = "0x11B13E8", VA = "0x11B13E8")]
		[Preserve]
		public static void RotateUsingKeyboard_op_Implicit()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x11B14B0", Offset = "0x11B14B0", VA = "0x11B14B0")]
		[Preserve]
		public static void RotateUsingKeyboard_op_Inequality()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x11B1580", Offset = "0x11B1580", VA = "0x11B1580")]
		[Preserve]
		public static void RotationActivatedAutoMoveModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x11B1650", Offset = "0x11B1650", VA = "0x11B1650")]
		[Preserve]
		public static void RotationActivatedAutoMoveModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x11B1718", Offset = "0x11B1718", VA = "0x11B1718")]
		[Preserve]
		public static void RotationActivatedAutoMoveModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x11B17E8", Offset = "0x11B17E8", VA = "0x11B17E8")]
		[Preserve]
		public static void RotationActivatedAutoRotateModifier_op_Equality()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x11B18B8", Offset = "0x11B18B8", VA = "0x11B18B8")]
		[Preserve]
		public static void RotationActivatedAutoRotateModifier_op_Implicit()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x11B1980", Offset = "0x11B1980", VA = "0x11B1980")]
		[Preserve]
		public static void RotationActivatedAutoRotateModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x11B1A50", Offset = "0x11B1A50", VA = "0x11B1A50")]
		[Preserve]
		public static void RotationDrivenAnimation_op_Equality()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x11B1B20", Offset = "0x11B1B20", VA = "0x11B1B20")]
		[Preserve]
		public static void RotationDrivenAnimation_op_Implicit()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x11B1BE8", Offset = "0x11B1BE8", VA = "0x11B1BE8")]
		[Preserve]
		public static void RotationDrivenAnimation_op_Inequality()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x11B1CB8", Offset = "0x11B1CB8", VA = "0x11B1CB8")]
		[Preserve]
		public static void RotationDrivenPlayable_Enabled()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x11B1CEC", Offset = "0x11B1CEC", VA = "0x11B1CEC")]
		[Preserve]
		public static void RotationDrivenPlayable_IsAtEndLimit()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x11B1D20", Offset = "0x11B1D20", VA = "0x11B1D20")]
		[Preserve]
		public static void RotationDrivenPlayable_op_Equality()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x11B1DF0", Offset = "0x11B1DF0", VA = "0x11B1DF0")]
		[Preserve]
		public static void RotationDrivenPlayable_op_Implicit()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x11B1EB8", Offset = "0x11B1EB8", VA = "0x11B1EB8")]
		[Preserve]
		public static void RotationDrivenPlayable_op_Inequality()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x11B1F88", Offset = "0x11B1F88", VA = "0x11B1F88")]
		[Preserve]
		public static void RotationDrivenRectRotation_op_Equality()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x11B2058", Offset = "0x11B2058", VA = "0x11B2058")]
		[Preserve]
		public static void RotationDrivenRectRotation_op_Implicit()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x11B2120", Offset = "0x11B2120", VA = "0x11B2120")]
		[Preserve]
		public static void RotationDrivenRectRotation_op_Inequality()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x11B21F0", Offset = "0x11B21F0", VA = "0x11B21F0")]
		[Preserve]
		public static void RotationDrivenRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x11B22C0", Offset = "0x11B22C0", VA = "0x11B22C0")]
		[Preserve]
		public static void RotationDrivenRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x11B2388", Offset = "0x11B2388", VA = "0x11B2388")]
		[Preserve]
		public static void RotationDrivenRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x11B2458", Offset = "0x11B2458", VA = "0x11B2458")]
		[Preserve]
		public static void RotationDrivenTranslationModifier_Enabled()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x11B248C", Offset = "0x11B248C", VA = "0x11B248C")]
		[Preserve]
		public static void RotationDrivenTranslationModifier_op_Equality()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x11B255C", Offset = "0x11B255C", VA = "0x11B255C")]
		[Preserve]
		public static void RotationDrivenTranslationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x11B2624", Offset = "0x11B2624", VA = "0x11B2624")]
		[Preserve]
		public static void RotationDrivenTranslationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x11B26F4", Offset = "0x11B26F4", VA = "0x11B26F4")]
		[Preserve]
		public static void RotationGrabbable_GetAngle()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x11B2728", Offset = "0x11B2728", VA = "0x11B2728")]
		[Preserve]
		public static void RotationGrabbable_GetState()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x11B275C", Offset = "0x11B275C", VA = "0x11B275C")]
		[Preserve]
		public static void RotationGrabbable_GetTotalRotation()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x11B2790", Offset = "0x11B2790", VA = "0x11B2790")]
		[Preserve]
		public static void RotationGrabbable_op_Equality()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x11B2860", Offset = "0x11B2860", VA = "0x11B2860")]
		[Preserve]
		public static void RotationGrabbable_op_Implicit()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x11B2928", Offset = "0x11B2928", VA = "0x11B2928")]
		[Preserve]
		public static void RotationGrabbable_op_Inequality()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x11B29F8", Offset = "0x11B29F8", VA = "0x11B29F8")]
		[Preserve]
		public static void RotationGrabbable_ReleaseGrab()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x11B2A2C", Offset = "0x11B2A2C", VA = "0x11B2A2C")]
		[Preserve]
		public static void RotationGrabbable_SetAngularVelocity()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x11B2A60", Offset = "0x11B2A60", VA = "0x11B2A60")]
		[Preserve]
		public static void RotationGrabbable_SetShouldUpdateTransform()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x11B2A94", Offset = "0x11B2A94", VA = "0x11B2A94")]
		[Preserve]
		public static void RotationGrabbable_SetSimulationState()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x11B2AC8", Offset = "0x11B2AC8", VA = "0x11B2AC8")]
		[Preserve]
		public static void RotationGrabbable_SetState()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x11B2AFC", Offset = "0x11B2AFC", VA = "0x11B2AFC")]
		[Preserve]
		public static void RotationGrabbable_SetTotalRotation()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x11B2B30", Offset = "0x11B2B30", VA = "0x11B2B30")]
		[Preserve]
		public static void RotationGrabbable_ShouldUpdateTransform()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x11B2B64", Offset = "0x11B2B64", VA = "0x11B2B64")]
		[Preserve]
		public static void RotationGrabbable_SimulationState()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x11B2B98", Offset = "0x11B2B98", VA = "0x11B2B98")]
		[Preserve]
		public static void RotationGrabbable_TransferGrab()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x11B2BCC", Offset = "0x11B2BCC", VA = "0x11B2BCC")]
		[Preserve]
		public static void RotationGrabbable_UpdateRotationFromCurrentTransform()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x11B2C00", Offset = "0x11B2C00", VA = "0x11B2C00")]
		[Preserve]
		public static void RotationGrabbable_UpdateTransform()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x11B2C34", Offset = "0x11B2C34", VA = "0x11B2C34")]
		[Preserve]
		public static void RotationLimitCollider_op_Equality()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x11B2D04", Offset = "0x11B2D04", VA = "0x11B2D04")]
		[Preserve]
		public static void RotationLimitCollider_op_Implicit()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x11B2DCC", Offset = "0x11B2DCC", VA = "0x11B2DCC")]
		[Preserve]
		public static void RotationLimitCollider_op_Inequality()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x11B2E9C", Offset = "0x11B2E9C", VA = "0x11B2E9C")]
		[Preserve]
		public static void RotationLimitSetter_op_Equality()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x11B2F6C", Offset = "0x11B2F6C", VA = "0x11B2F6C")]
		[Preserve]
		public static void RotationLimitSetter_op_Implicit()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x11B3034", Offset = "0x11B3034", VA = "0x11B3034")]
		[Preserve]
		public static void RotationLimitSetter_op_Inequality()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x11B3104", Offset = "0x11B3104", VA = "0x11B3104")]
		[Preserve]
		public static void RotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x11B31D4", Offset = "0x11B31D4", VA = "0x11B31D4")]
		[Preserve]
		public static void RotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x11B329C", Offset = "0x11B329C", VA = "0x11B329C")]
		[Preserve]
		public static void RotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x11B336C", Offset = "0x11B336C", VA = "0x11B336C")]
		[Preserve]
		public static void RotationTriggerModifier_op_Equality()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x11B343C", Offset = "0x11B343C", VA = "0x11B343C")]
		[Preserve]
		public static void RotationTriggerModifier_op_Implicit()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x11B3504", Offset = "0x11B3504", VA = "0x11B3504")]
		[Preserve]
		public static void RotationTriggerModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x11B35D4", Offset = "0x11B35D4", VA = "0x11B35D4")]
		[Preserve]
		public static void SafeDoor_op_Equality()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x11B36A4", Offset = "0x11B36A4", VA = "0x11B36A4")]
		[Preserve]
		public static void SafeDoor_op_Implicit()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x11B376C", Offset = "0x11B376C", VA = "0x11B376C")]
		[Preserve]
		public static void SafeDoor_op_Inequality()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x11B383C", Offset = "0x11B383C", VA = "0x11B383C")]
		[Preserve]
		public static void SafeDoor_SetExposed()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x11B3870", Offset = "0x11B3870", VA = "0x11B3870")]
		[Preserve]
		public static void SafeDrill_op_Equality()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x11B3940", Offset = "0x11B3940", VA = "0x11B3940")]
		[Preserve]
		public static void SafeDrill_op_Implicit()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x11B3A08", Offset = "0x11B3A08", VA = "0x11B3A08")]
		[Preserve]
		public static void SafeDrill_op_Inequality()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x11B3AD8", Offset = "0x11B3AD8", VA = "0x11B3AD8")]
		[Preserve]
		public static void SafeInventoryPosition_Active()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x11B3B0C", Offset = "0x11B3B0C", VA = "0x11B3B0C")]
		[Preserve]
		public static void SafeInventoryPosition_op_Equality()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x11B3BDC", Offset = "0x11B3BDC", VA = "0x11B3BDC")]
		[Preserve]
		public static void SafeInventoryPosition_op_Implicit()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x11B3CA4", Offset = "0x11B3CA4", VA = "0x11B3CA4")]
		[Preserve]
		public static void SafeInventoryPosition_op_Inequality()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x11B3D74", Offset = "0x11B3D74", VA = "0x11B3D74")]
		[Preserve]
		public static void SafeInventoryPosition_SetPositionActive()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x11B3DA8", Offset = "0x11B3DA8", VA = "0x11B3DA8")]
		[Preserve]
		public static void Sandstorm_op_Equality()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x11B3E78", Offset = "0x11B3E78", VA = "0x11B3E78")]
		[Preserve]
		public static void Sandstorm_op_Implicit()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x11B3F40", Offset = "0x11B3F40", VA = "0x11B3F40")]
		[Preserve]
		public static void Sandstorm_op_Inequality()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x11B4010", Offset = "0x11B4010", VA = "0x11B4010")]
		[Preserve]
		public static void SarcophagusLift_IsAttached()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x11B4044", Offset = "0x11B4044", VA = "0x11B4044")]
		[Preserve]
		public static void SarcophagusLift_IsSarcReady()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x11B4078", Offset = "0x11B4078", VA = "0x11B4078")]
		[Preserve]
		public static void SarcophagusLift_op_Equality()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x11B4148", Offset = "0x11B4148", VA = "0x11B4148")]
		[Preserve]
		public static void SarcophagusLift_op_Implicit()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x11B4210", Offset = "0x11B4210", VA = "0x11B4210")]
		[Preserve]
		public static void SarcophagusLift_op_Inequality()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x11B42E0", Offset = "0x11B42E0", VA = "0x11B42E0")]
		[Preserve]
		public static void SarcophagusLift_SetAttached()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x11B4314", Offset = "0x11B4314", VA = "0x11B4314")]
		[Preserve]
		public static void SarcophagusLift_SetLocked()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x11B4348", Offset = "0x11B4348", VA = "0x11B4348")]
		[Preserve]
		public static void SarcophagusLift_SetSarcReady()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x11B437C", Offset = "0x11B437C", VA = "0x11B437C")]
		[Preserve]
		public static void SarcophagusLift_SwitchToBakedLid()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x11B43B0", Offset = "0x11B43B0", VA = "0x11B43B0")]
		[Preserve]
		public static void SaveableComponent_op_Equality()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x11B4480", Offset = "0x11B4480", VA = "0x11B4480")]
		[Preserve]
		public static void SaveableComponent_op_Implicit()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x11B4548", Offset = "0x11B4548", VA = "0x11B4548")]
		[Preserve]
		public static void SaveableComponent_op_Inequality()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x11B4618", Offset = "0x11B4618", VA = "0x11B4618")]
		[Preserve]
		public static void SaveManager_op_Equality()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x11B46E8", Offset = "0x11B46E8", VA = "0x11B46E8")]
		[Preserve]
		public static void SaveManager_op_Implicit()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x11B47B0", Offset = "0x11B47B0", VA = "0x11B47B0")]
		[Preserve]
		public static void SaveManager_op_Inequality()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x11B4880", Offset = "0x11B4880", VA = "0x11B4880")]
		[Preserve]
		public static void SceneRebaser_op_Equality()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x11B4950", Offset = "0x11B4950", VA = "0x11B4950")]
		[Preserve]
		public static void SceneRebaser_op_Implicit()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x11B4A18", Offset = "0x11B4A18", VA = "0x11B4A18")]
		[Preserve]
		public static void SceneRebaser_op_Inequality()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x11B4AE8", Offset = "0x11B4AE8", VA = "0x11B4AE8")]
		[Preserve]
		public static void SceneSaver_op_Equality()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x11B4BB8", Offset = "0x11B4BB8", VA = "0x11B4BB8")]
		[Preserve]
		public static void SceneSaver_op_Implicit()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x11B4C80", Offset = "0x11B4C80", VA = "0x11B4C80")]
		[Preserve]
		public static void SceneSaver_op_Inequality()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x11B4D50", Offset = "0x11B4D50", VA = "0x11B4D50")]
		[Preserve]
		public static void ScreenShot_op_Equality()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x11B4E20", Offset = "0x11B4E20", VA = "0x11B4E20")]
		[Preserve]
		public static void ScreenShot_op_Implicit()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x11B4EE8", Offset = "0x11B4EE8", VA = "0x11B4EE8")]
		[Preserve]
		public static void ScreenShot_op_Inequality()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x11B4FB8", Offset = "0x11B4FB8", VA = "0x11B4FB8")]
		[Preserve]
		public static void ScrubTimelineVolume_enabled()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x11B4FEC", Offset = "0x11B4FEC", VA = "0x11B4FEC")]
		[Preserve]
		public static void ScrubTimelineVolume_op_Equality()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x11B50BC", Offset = "0x11B50BC", VA = "0x11B50BC")]
		[Preserve]
		public static void ScrubTimelineVolume_op_Implicit()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x11B5184", Offset = "0x11B5184", VA = "0x11B5184")]
		[Preserve]
		public static void ScrubTimelineVolume_op_Inequality()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x11B5254", Offset = "0x11B5254", VA = "0x11B5254")]
		[Preserve]
		public static void ScrubTimelineVolume_Stop()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x11B5288", Offset = "0x11B5288", VA = "0x11B5288")]
		[Preserve]
		public static void SegmentCombo_op_Equality()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x11B5358", Offset = "0x11B5358", VA = "0x11B5358")]
		[Preserve]
		public static void SegmentCombo_op_Implicit()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x11B5420", Offset = "0x11B5420", VA = "0x11B5420")]
		[Preserve]
		public static void SegmentCombo_op_Inequality()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x11B54F0", Offset = "0x11B54F0", VA = "0x11B54F0")]
		[Preserve]
		public static void SegmentSliderModifier_GetClosestSegment()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x11B5524", Offset = "0x11B5524", VA = "0x11B5524")]
		[Preserve]
		public static void SegmentSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x11B55F4", Offset = "0x11B55F4", VA = "0x11B55F4")]
		[Preserve]
		public static void SegmentSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x11B56BC", Offset = "0x11B56BC", VA = "0x11B56BC")]
		[Preserve]
		public static void SegmentSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x11B578C", Offset = "0x11B578C", VA = "0x11B578C")]
		[Preserve]
		public static void SelectProfileScreen_op_Equality()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x11B585C", Offset = "0x11B585C", VA = "0x11B585C")]
		[Preserve]
		public static void SelectProfileScreen_op_Implicit()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x11B5924", Offset = "0x11B5924", VA = "0x11B5924")]
		[Preserve]
		public static void SelectProfileScreen_op_Inequality()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x11B59F4", Offset = "0x11B59F4", VA = "0x11B59F4")]
		[Preserve]
		public static void SetShaderMaxLod_op_Equality()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x11B5AC4", Offset = "0x11B5AC4", VA = "0x11B5AC4")]
		[Preserve]
		public static void SetShaderMaxLod_op_Implicit()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x11B5B8C", Offset = "0x11B5B8C", VA = "0x11B5B8C")]
		[Preserve]
		public static void SetShaderMaxLod_op_Inequality()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x11B5C5C", Offset = "0x11B5C5C", VA = "0x11B5C5C")]
		[Preserve]
		public static void ShaderCompilationManager_op_Equality()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x11B5D2C", Offset = "0x11B5D2C", VA = "0x11B5D2C")]
		[Preserve]
		public static void ShaderCompilationManager_op_Implicit()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x11B5DF4", Offset = "0x11B5DF4", VA = "0x11B5DF4")]
		[Preserve]
		public static void ShaderCompilationManager_op_Inequality()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x11B5EC4", Offset = "0x11B5EC4", VA = "0x11B5EC4")]
		[Preserve]
		public static void ShaderPreWarm_op_Equality()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x11B5F94", Offset = "0x11B5F94", VA = "0x11B5F94")]
		[Preserve]
		public static void ShaderPreWarm_op_Implicit()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x11B605C", Offset = "0x11B605C", VA = "0x11B605C")]
		[Preserve]
		public static void ShaderPreWarm_op_Inequality()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x11B612C", Offset = "0x11B612C", VA = "0x11B612C")]
		[Preserve]
		public static void ShaderPreWarmTarget_op_Equality()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x11B61FC", Offset = "0x11B61FC", VA = "0x11B61FC")]
		[Preserve]
		public static void ShaderPreWarmTarget_op_Implicit()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x11B62C4", Offset = "0x11B62C4", VA = "0x11B62C4")]
		[Preserve]
		public static void ShaderPreWarmTarget_op_Inequality()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x11B6394", Offset = "0x11B6394", VA = "0x11B6394")]
		[Preserve]
		public static void ShaderProgressBar_op_Equality()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x11B6464", Offset = "0x11B6464", VA = "0x11B6464")]
		[Preserve]
		public static void ShaderProgressBar_op_Implicit()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x11B652C", Offset = "0x11B652C", VA = "0x11B652C")]
		[Preserve]
		public static void ShaderProgressBar_op_Inequality()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x11B65FC", Offset = "0x11B65FC", VA = "0x11B65FC")]
		[Preserve]
		public static void ShadowGradient_enabled()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x11B6630", Offset = "0x11B6630", VA = "0x11B6630")]
		[Preserve]
		public static void ShadowGradient_op_Equality()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x11B6700", Offset = "0x11B6700", VA = "0x11B6700")]
		[Preserve]
		public static void ShadowGradient_op_Implicit()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x11B67C8", Offset = "0x11B67C8", VA = "0x11B67C8")]
		[Preserve]
		public static void ShadowGradient_op_Inequality()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x11B6898", Offset = "0x11B6898", VA = "0x11B6898")]
		[Preserve]
		public static void SingletonBase_op_Equality()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x11B6968", Offset = "0x11B6968", VA = "0x11B6968")]
		[Preserve]
		public static void SingletonBase_op_Implicit()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x11B6A30", Offset = "0x11B6A30", VA = "0x11B6A30")]
		[Preserve]
		public static void SingletonBase_op_Inequality()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x11B6B00", Offset = "0x11B6B00", VA = "0x11B6B00")]
		[Preserve]
		public static void SingletonManager_op_Equality()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x11B6BD0", Offset = "0x11B6BD0", VA = "0x11B6BD0")]
		[Preserve]
		public static void SingletonManager_op_Implicit()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x11B6C98", Offset = "0x11B6C98", VA = "0x11B6C98")]
		[Preserve]
		public static void SingletonManager_op_Inequality()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x11B6D68", Offset = "0x11B6D68", VA = "0x11B6D68")]
		[Preserve]
		public static void SittingIndicator_op_Equality()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x11B6E38", Offset = "0x11B6E38", VA = "0x11B6E38")]
		[Preserve]
		public static void SittingIndicator_op_Implicit()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x11B6F00", Offset = "0x11B6F00", VA = "0x11B6F00")]
		[Preserve]
		public static void SittingIndicator_op_Inequality()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x11B6FD0", Offset = "0x11B6FD0", VA = "0x11B6FD0")]
		[Preserve]
		public static void SittingStandingToggle_op_Equality()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x11B70A0", Offset = "0x11B70A0", VA = "0x11B70A0")]
		[Preserve]
		public static void SittingStandingToggle_op_Implicit()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x11B7168", Offset = "0x11B7168", VA = "0x11B7168")]
		[Preserve]
		public static void SittingStandingToggle_op_Inequality()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x11B7238", Offset = "0x11B7238", VA = "0x11B7238")]
		[Preserve]
		public static void SkyboxSwitcher_op_Equality()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x11B7308", Offset = "0x11B7308", VA = "0x11B7308")]
		[Preserve]
		public static void SkyboxSwitcher_op_Implicit()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x11B73D0", Offset = "0x11B73D0", VA = "0x11B73D0")]
		[Preserve]
		public static void SkyboxSwitcher_op_Inequality()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x11B74A0", Offset = "0x11B74A0", VA = "0x11B74A0")]
		[Preserve]
		public static void SlideItemClicker_op_Equality()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x11B7570", Offset = "0x11B7570", VA = "0x11B7570")]
		[Preserve]
		public static void SlideItemClicker_op_Implicit()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x11B7638", Offset = "0x11B7638", VA = "0x11B7638")]
		[Preserve]
		public static void SlideItemClicker_op_Inequality()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x11B7708", Offset = "0x11B7708", VA = "0x11B7708")]
		[Preserve]
		public static void SlideProjector_GetCurrentSlide()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x11B773C", Offset = "0x11B773C", VA = "0x11B773C")]
		[Preserve]
		public static void SlideProjector_op_Equality()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x11B780C", Offset = "0x11B780C", VA = "0x11B780C")]
		[Preserve]
		public static void SlideProjector_op_Implicit()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x11B78D4", Offset = "0x11B78D4", VA = "0x11B78D4")]
		[Preserve]
		public static void SlideProjector_op_Inequality()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x11B79A4", Offset = "0x11B79A4", VA = "0x11B79A4")]
		[Preserve]
		public static void SlideProjectorDisc_op_Equality()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x11B7A74", Offset = "0x11B7A74", VA = "0x11B7A74")]
		[Preserve]
		public static void SlideProjectorDisc_op_Implicit()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x11B7B3C", Offset = "0x11B7B3C", VA = "0x11B7B3C")]
		[Preserve]
		public static void SlideProjectorDisc_op_Inequality()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x11B7C0C", Offset = "0x11B7C0C", VA = "0x11B7C0C")]
		[Preserve]
		public static void SliderDrivenPlayable_Enabled()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x11B7C40", Offset = "0x11B7C40", VA = "0x11B7C40")]
		[Preserve]
		public static void SliderDrivenPlayable_op_Equality()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x11B7D10", Offset = "0x11B7D10", VA = "0x11B7D10")]
		[Preserve]
		public static void SliderDrivenPlayable_op_Implicit()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x11B7DD8", Offset = "0x11B7DD8", VA = "0x11B7DD8")]
		[Preserve]
		public static void SliderDrivenPlayable_op_Inequality()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x11B7EA8", Offset = "0x11B7EA8", VA = "0x11B7EA8")]
		[Preserve]
		public static void SliderDrivenTranslation_op_Equality()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x11B7F78", Offset = "0x11B7F78", VA = "0x11B7F78")]
		[Preserve]
		public static void SliderDrivenTranslation_op_Implicit()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x11B8040", Offset = "0x11B8040", VA = "0x11B8040")]
		[Preserve]
		public static void SliderDrivenTranslation_op_Inequality()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x11B8110", Offset = "0x11B8110", VA = "0x11B8110")]
		[Preserve]
		public static void SliderGrabbable_GetGrabber()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x11B8144", Offset = "0x11B8144", VA = "0x11B8144")]
		[Preserve]
		public static void SliderGrabbable_IsInteractionInProgress()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x11B8178", Offset = "0x11B8178", VA = "0x11B8178")]
		[Preserve]
		public static void SliderGrabbable_op_Equality()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x11B8248", Offset = "0x11B8248", VA = "0x11B8248")]
		[Preserve]
		public static void SliderGrabbable_op_Implicit()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x11B8310", Offset = "0x11B8310", VA = "0x11B8310")]
		[Preserve]
		public static void SliderGrabbable_op_Inequality()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x11B83E0", Offset = "0x11B83E0", VA = "0x11B83E0")]
		[Preserve]
		public static void SliderGrabbable_ReleaseGrab()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x11B8414", Offset = "0x11B8414", VA = "0x11B8414")]
		[Preserve]
		public static void SliderGrabbable_SetSimulationState()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x11B8448", Offset = "0x11B8448", VA = "0x11B8448")]
		[Preserve]
		public static void SliderGrabbable_SetState()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x11B847C", Offset = "0x11B847C", VA = "0x11B847C")]
		[Preserve]
		public static void SliderGrabbable_TransferGrab()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x11B84B0", Offset = "0x11B84B0", VA = "0x11B84B0")]
		[Preserve]
		public static void SliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x11B8580", Offset = "0x11B8580", VA = "0x11B8580")]
		[Preserve]
		public static void SliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x11B8648", Offset = "0x11B8648", VA = "0x11B8648")]
		[Preserve]
		public static void SliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x11B8718", Offset = "0x11B8718", VA = "0x11B8718")]
		[Preserve]
		public static void SliderStickingPointModifier_op_Equality()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x11B87E8", Offset = "0x11B87E8", VA = "0x11B87E8")]
		[Preserve]
		public static void SliderStickingPointModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x11B88B0", Offset = "0x11B88B0", VA = "0x11B88B0")]
		[Preserve]
		public static void SliderStickingPointModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x11B8980", Offset = "0x11B8980", VA = "0x11B8980")]
		[Preserve]
		public static void SliderTrackModifier_op_Equality()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x11B8A50", Offset = "0x11B8A50", VA = "0x11B8A50")]
		[Preserve]
		public static void SliderTrackModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x11B8B18", Offset = "0x11B8B18", VA = "0x11B8B18")]
		[Preserve]
		public static void SliderTrackModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x11B8BE8", Offset = "0x11B8BE8", VA = "0x11B8BE8")]
		[Preserve]
		public static void SliderTriggerModifier_IsAboveThreshold()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x11B8C1C", Offset = "0x11B8C1C", VA = "0x11B8C1C")]
		[Preserve]
		public static void SliderTriggerModifier_op_Equality()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x11B8CEC", Offset = "0x11B8CEC", VA = "0x11B8CEC")]
		[Preserve]
		public static void SliderTriggerModifier_op_Implicit()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x11B8DB4", Offset = "0x11B8DB4", VA = "0x11B8DB4")]
		[Preserve]
		public static void SliderTriggerModifier_op_Inequality()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x11B8E84", Offset = "0x11B8E84", VA = "0x11B8E84")]
		[Preserve]
		public static void SlotManager_op_Equality()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x11B8F54", Offset = "0x11B8F54", VA = "0x11B8F54")]
		[Preserve]
		public static void SlotManager_op_Implicit()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x11B901C", Offset = "0x11B901C", VA = "0x11B901C")]
		[Preserve]
		public static void SlotManager_op_Inequality()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x11B90EC", Offset = "0x11B90EC", VA = "0x11B90EC")]
		[Preserve]
		public static void SlotManager_SaveProgress()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x11B91D8", Offset = "0x11B91D8", VA = "0x11B91D8")]
		[Preserve]
		public static void SnapToTransform_op_Equality()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x11B92A8", Offset = "0x11B92A8", VA = "0x11B92A8")]
		[Preserve]
		public static void SnapToTransform_op_Implicit()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x11B9370", Offset = "0x11B9370", VA = "0x11B9370")]
		[Preserve]
		public static void SnapToTransform_op_Inequality()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x11B9440", Offset = "0x11B9440", VA = "0x11B9440")]
		[Preserve]
		public static void SpeedTrigger_op_Equality()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x11B9510", Offset = "0x11B9510", VA = "0x11B9510")]
		[Preserve]
		public static void SpeedTrigger_op_Implicit()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x11B95D8", Offset = "0x11B95D8", VA = "0x11B95D8")]
		[Preserve]
		public static void SpeedTrigger_op_Inequality()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x11B96A8", Offset = "0x11B96A8", VA = "0x11B96A8")]
		[Preserve]
		public static void SphereGrabbableCollider_op_Equality()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x11B9778", Offset = "0x11B9778", VA = "0x11B9778")]
		[Preserve]
		public static void SphereGrabbableCollider_op_Implicit()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x11B9840", Offset = "0x11B9840", VA = "0x11B9840")]
		[Preserve]
		public static void SphereGrabbableCollider_op_Inequality()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x11B9910", Offset = "0x11B9910", VA = "0x11B9910")]
		[Preserve]
		public static void SphereTrigger_op_Equality()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x11B99E0", Offset = "0x11B99E0", VA = "0x11B99E0")]
		[Preserve]
		public static void SphereTrigger_op_Implicit()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x11B9AA8", Offset = "0x11B9AA8", VA = "0x11B9AA8")]
		[Preserve]
		public static void SphereTrigger_op_Inequality()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x11B9B78", Offset = "0x11B9B78", VA = "0x11B9B78")]
		[Preserve]
		public static void SpookySmoke_op_Equality()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x11B9C48", Offset = "0x11B9C48", VA = "0x11B9C48")]
		[Preserve]
		public static void SpookySmoke_op_Implicit()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x11B9D10", Offset = "0x11B9D10", VA = "0x11B9D10")]
		[Preserve]
		public static void SpookySmoke_op_Inequality()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x11B9DE0", Offset = "0x11B9DE0", VA = "0x11B9DE0")]
		[Preserve]
		public static void SpookySmoke_Play()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x11B9E14", Offset = "0x11B9E14", VA = "0x11B9E14")]
		[Preserve]
		public static void SpookySmoke_Stop()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x11B9E48", Offset = "0x11B9E48", VA = "0x11B9E48")]
		[Preserve]
		public static void Spotlight_enabled()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x11B9E7C", Offset = "0x11B9E7C", VA = "0x11B9E7C")]
		[Preserve]
		public static void Spotlight_op_Equality()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x11B9F4C", Offset = "0x11B9F4C", VA = "0x11B9F4C")]
		[Preserve]
		public static void Spotlight_op_Implicit()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x11BA014", Offset = "0x11BA014", VA = "0x11BA014")]
		[Preserve]
		public static void Spotlight_op_Inequality()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x11BA0E4", Offset = "0x11BA0E4", VA = "0x11BA0E4")]
		[Preserve]
		public static void SpotlightTarget_op_Equality()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x11BA1B4", Offset = "0x11BA1B4", VA = "0x11BA1B4")]
		[Preserve]
		public static void SpotlightTarget_op_Implicit()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x11BA27C", Offset = "0x11BA27C", VA = "0x11BA27C")]
		[Preserve]
		public static void SpotlightTarget_op_Inequality()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x11BA34C", Offset = "0x11BA34C", VA = "0x11BA34C")]
		[Preserve]
		public static void SpringSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x11BA41C", Offset = "0x11BA41C", VA = "0x11BA41C")]
		[Preserve]
		public static void SpringSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x11BA4E4", Offset = "0x11BA4E4", VA = "0x11BA4E4")]
		[Preserve]
		public static void SpringSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x11BA5B4", Offset = "0x11BA5B4", VA = "0x11BA5B4")]
		[Preserve]
		public static void SpringToLimitRotationModifier_Enabled()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x11BA5E8", Offset = "0x11BA5E8", VA = "0x11BA5E8")]
		[Preserve]
		public static void SpringToLimitRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x11BA6B8", Offset = "0x11BA6B8", VA = "0x11BA6B8")]
		[Preserve]
		public static void SpringToLimitRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x11BA780", Offset = "0x11BA780", VA = "0x11BA780")]
		[Preserve]
		public static void SpringToLimitRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x11BA850", Offset = "0x11BA850", VA = "0x11BA850")]
		[Preserve]
		public static void SpringToLimitSliderModifier_op_Equality()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x11BA920", Offset = "0x11BA920", VA = "0x11BA920")]
		[Preserve]
		public static void SpringToLimitSliderModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x11BA9E8", Offset = "0x11BA9E8", VA = "0x11BA9E8")]
		[Preserve]
		public static void SpringToLimitSliderModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x11BAAB8", Offset = "0x11BAAB8", VA = "0x11BAAB8")]
		[Preserve]
		public static void SpringToLimitWhenTiltedRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x11BAB88", Offset = "0x11BAB88", VA = "0x11BAB88")]
		[Preserve]
		public static void SpringToLimitWhenTiltedRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x11BAC50", Offset = "0x11BAC50", VA = "0x11BAC50")]
		[Preserve]
		public static void SpringToLimitWhenTiltedRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x11BAD20", Offset = "0x11BAD20", VA = "0x11BAD20")]
		[Preserve]
		public static void SpringToPointRotationModifier_ctor()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x11BAD70", Offset = "0x11BAD70", VA = "0x11BAD70")]
		[Preserve]
		public static void SpringToPointRotationModifier_Enabled()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x11BADA4", Offset = "0x11BADA4", VA = "0x11BADA4")]
		[Preserve]
		public static void SpringToPointRotationModifier_MaxAngleToSpringFrom()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x11BADD8", Offset = "0x11BADD8", VA = "0x11BADD8")]
		[Preserve]
		public static void SpringToPointRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x11BAEA8", Offset = "0x11BAEA8", VA = "0x11BAEA8")]
		[Preserve]
		public static void SpringToPointRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x11BAF70", Offset = "0x11BAF70", VA = "0x11BAF70")]
		[Preserve]
		public static void SpringToPointRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x11BB040", Offset = "0x11BB040", VA = "0x11BB040")]
		[Preserve]
		public static void SpringToPointRotationModifier_SpringStrength()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x11BB074", Offset = "0x11BB074", VA = "0x11BB074")]
		[Preserve]
		public static void SpringToPointsRotationModifier_GetClosestPoint()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x11BB0A8", Offset = "0x11BB0A8", VA = "0x11BB0A8")]
		[Preserve]
		public static void SpringToPointsRotationModifier_GetCurrentPoint()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x11BB0DC", Offset = "0x11BB0DC", VA = "0x11BB0DC")]
		[Preserve]
		public static void SpringToPointsRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x11BB1AC", Offset = "0x11BB1AC", VA = "0x11BB1AC")]
		[Preserve]
		public static void SpringToPointsRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x11BB274", Offset = "0x11BB274", VA = "0x11BB274")]
		[Preserve]
		public static void SpringToPointsRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x11BB344", Offset = "0x11BB344", VA = "0x11BB344")]
		[Preserve]
		public static void SpringToSegmentRotationModifier_GetCurrentSegment()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x11BB378", Offset = "0x11BB378", VA = "0x11BB378")]
		[Preserve]
		public static void SpringToSegmentRotationModifier_op_Equality()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x11BB448", Offset = "0x11BB448", VA = "0x11BB448")]
		[Preserve]
		public static void SpringToSegmentRotationModifier_op_Implicit()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x11BB510", Offset = "0x11BB510", VA = "0x11BB510")]
		[Preserve]
		public static void SpringToSegmentRotationModifier_op_Inequality()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x11BB5E0", Offset = "0x11BB5E0", VA = "0x11BB5E0")]
		[Preserve]
		public static void SpringToSegmentRotationModifier_SnapToSegment()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x11BB614", Offset = "0x11BB614", VA = "0x11BB614")]
		[Preserve]
		public static void SpriteNativeSizeScale_op_Equality()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x11BB6E4", Offset = "0x11BB6E4", VA = "0x11BB6E4")]
		[Preserve]
		public static void SpriteNativeSizeScale_op_Implicit()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x11BB7AC", Offset = "0x11BB7AC", VA = "0x11BB7AC")]
		[Preserve]
		public static void SpriteNativeSizeScale_op_Inequality()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x11BB87C", Offset = "0x11BB87C", VA = "0x11BB87C")]
		[Preserve]
		public static void SpritePivot_op_Equality()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x11BB94C", Offset = "0x11BB94C", VA = "0x11BB94C")]
		[Preserve]
		public static void SpritePivot_op_Implicit()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x11BBA14", Offset = "0x11BBA14", VA = "0x11BBA14")]
		[Preserve]
		public static void SpritePivot_op_Inequality()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x11BBAE4", Offset = "0x11BBAE4", VA = "0x11BBAE4")]
		[Preserve]
		public static void StainedGlassController_GetState()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x11BBB18", Offset = "0x11BBB18", VA = "0x11BBB18")]
		[Preserve]
		public static void StainedGlassController_IsStateSolvable()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x11BBB4C", Offset = "0x11BBB4C", VA = "0x11BBB4C")]
		[Preserve]
		public static void StainedGlassController_IsStateSolved()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x11BBB80", Offset = "0x11BBB80", VA = "0x11BBB80")]
		[Preserve]
		public static void StainedGlassController_op_Equality()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x11BBC50", Offset = "0x11BBC50", VA = "0x11BBC50")]
		[Preserve]
		public static void StainedGlassController_op_Implicit()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x11BBD18", Offset = "0x11BBD18", VA = "0x11BBD18")]
		[Preserve]
		public static void StainedGlassController_op_Inequality()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x11BBDE8", Offset = "0x11BBDE8", VA = "0x11BBDE8")]
		[Preserve]
		public static void StainedGlassController_SetPatternActive()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x11BBE1C", Offset = "0x11BBE1C", VA = "0x11BBE1C")]
		[Preserve]
		public static void StainedGlassController_SetStateSolved()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x11BBE50", Offset = "0x11BBE50", VA = "0x11BBE50")]
		[Preserve]
		public static void StainedGlassSystem_op_Equality()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x11BBF20", Offset = "0x11BBF20", VA = "0x11BBF20")]
		[Preserve]
		public static void StainedGlassSystem_op_Implicit()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x11BBFE8", Offset = "0x11BBFE8", VA = "0x11BBFE8")]
		[Preserve]
		public static void StainedGlassSystem_op_Inequality()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x11BC0B8", Offset = "0x11BC0B8", VA = "0x11BC0B8")]
		[Preserve]
		public static void StainedGlassTurntable_op_Equality()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x11BC188", Offset = "0x11BC188", VA = "0x11BC188")]
		[Preserve]
		public static void StainedGlassTurntable_op_Implicit()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x11BC250", Offset = "0x11BC250", VA = "0x11BC250")]
		[Preserve]
		public static void StainedGlassTurntable_op_Inequality()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x11BC320", Offset = "0x11BC320", VA = "0x11BC320")]
		[Preserve]
		public static void StandingHeightScreen_op_Equality()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x11BC3F0", Offset = "0x11BC3F0", VA = "0x11BC3F0")]
		[Preserve]
		public static void StandingHeightScreen_op_Implicit()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x11BC4B8", Offset = "0x11BC4B8", VA = "0x11BC4B8")]
		[Preserve]
		public static void StandingHeightScreen_op_Inequality()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x11BC588", Offset = "0x11BC588", VA = "0x11BC588")]
		[Preserve]
		public static void StartLoopEndAudio_op_Equality()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x11BC658", Offset = "0x11BC658", VA = "0x11BC658")]
		[Preserve]
		public static void StartLoopEndAudio_op_Implicit()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x11BC720", Offset = "0x11BC720", VA = "0x11BC720")]
		[Preserve]
		public static void StartLoopEndAudio_op_Inequality()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x11BC7F0", Offset = "0x11BC7F0", VA = "0x11BC7F0")]
		[Preserve]
		public static void StartupMenuController_op_Equality()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x11BC8C0", Offset = "0x11BC8C0", VA = "0x11BC8C0")]
		[Preserve]
		public static void StartupMenuController_op_Implicit()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x11BC988", Offset = "0x11BC988", VA = "0x11BC988")]
		[Preserve]
		public static void StartupMenuController_op_Inequality()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x11BCA58", Offset = "0x11BCA58", VA = "0x11BCA58")]
		[Preserve]
		public static void StartupSplashScreen_op_Equality()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x11BCB28", Offset = "0x11BCB28", VA = "0x11BCB28")]
		[Preserve]
		public static void StartupSplashScreen_op_Implicit()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x11BCBF0", Offset = "0x11BCBF0", VA = "0x11BCBF0")]
		[Preserve]
		public static void StartupSplashScreen_op_Inequality()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x11BCCC0", Offset = "0x11BCCC0", VA = "0x11BCCC0")]
		[Preserve]
		public static void StaticChecker_op_Equality()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x11BCD90", Offset = "0x11BCD90", VA = "0x11BCD90")]
		[Preserve]
		public static void StaticChecker_op_Implicit()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x11BCE58", Offset = "0x11BCE58", VA = "0x11BCE58")]
		[Preserve]
		public static void StaticChecker_op_Inequality()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x11BCF28", Offset = "0x11BCF28", VA = "0x11BCF28")]
		[Preserve]
		public static void StayBehindUI_op_Equality()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x11BCFF8", Offset = "0x11BCFF8", VA = "0x11BCFF8")]
		[Preserve]
		public static void StayBehindUI_op_Implicit()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x11BD0C0", Offset = "0x11BD0C0", VA = "0x11BD0C0")]
		[Preserve]
		public static void StayBehindUI_op_Inequality()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x11BD190", Offset = "0x11BD190", VA = "0x11BD190")]
		[Preserve]
		public static void StayInView_op_Equality()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x11BD260", Offset = "0x11BD260", VA = "0x11BD260")]
		[Preserve]
		public static void StayInView_op_Implicit()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x11BD328", Offset = "0x11BD328", VA = "0x11BD328")]
		[Preserve]
		public static void StayInView_op_Inequality()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x11BD3F8", Offset = "0x11BD3F8", VA = "0x11BD3F8")]
		[Preserve]
		public static void SteamInputRewiredMapping_op_Equality()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x11BD4C8", Offset = "0x11BD4C8", VA = "0x11BD4C8")]
		[Preserve]
		public static void SteamInputRewiredMapping_op_Implicit()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x11BD590", Offset = "0x11BD590", VA = "0x11BD590")]
		[Preserve]
		public static void SteamInputRewiredMapping_op_Inequality()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x11BD660", Offset = "0x11BD660", VA = "0x11BD660")]
		[Preserve]
		public static void SteppedUVScroller_op_Equality()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x11BD730", Offset = "0x11BD730", VA = "0x11BD730")]
		[Preserve]
		public static void SteppedUVScroller_op_Implicit()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x11BD7F8", Offset = "0x11BD7F8", VA = "0x11BD7F8")]
		[Preserve]
		public static void SteppedUVScroller_op_Inequality()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x11BD8C8", Offset = "0x11BD8C8", VA = "0x11BD8C8")]
		[Preserve]
		public static void StreamingVideoTexture_op_Equality()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x11BD998", Offset = "0x11BD998", VA = "0x11BD998")]
		[Preserve]
		public static void StreamingVideoTexture_op_Implicit()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x11BDA60", Offset = "0x11BDA60", VA = "0x11BDA60")]
		[Preserve]
		public static void StreamingVideoTexture_op_Inequality()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x11BDB30", Offset = "0x11BDB30", VA = "0x11BDB30")]
		[Preserve]
		public static void string_Equals()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x11BDBE0", Offset = "0x11BDBE0", VA = "0x11BDBE0")]
		[Preserve]
		public static void string_op_Equality()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x11BDC90", Offset = "0x11BDC90", VA = "0x11BDC90")]
		[Preserve]
		public static void string_op_Inequality()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x11BDD40", Offset = "0x11BDD40", VA = "0x11BDD40")]
		[Preserve]
		public static void Superzoom_ExitFadeTime()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x11BDD74", Offset = "0x11BDD74", VA = "0x11BDD74")]
		[Preserve]
		public static void Superzoom_op_Equality()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x11BDE44", Offset = "0x11BDE44", VA = "0x11BDE44")]
		[Preserve]
		public static void Superzoom_op_Implicit()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x11BDF0C", Offset = "0x11BDF0C", VA = "0x11BDF0C")]
		[Preserve]
		public static void Superzoom_op_Inequality()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x11BDFDC", Offset = "0x11BDFDC", VA = "0x11BDFDC")]
		[Preserve]
		public static void Superzoom_SetState()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x11BE010", Offset = "0x11BE010", VA = "0x11BE010")]
		[Preserve]
		public static void Superzoom_ZoomOut()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x11BE044", Offset = "0x11BE044", VA = "0x11BE044")]
		[Preserve]
		public static void SwitchMaterialSaver_op_Equality()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x11BE114", Offset = "0x11BE114", VA = "0x11BE114")]
		[Preserve]
		public static void SwitchMaterialSaver_op_Implicit()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x11BE1DC", Offset = "0x11BE1DC", VA = "0x11BE1DC")]
		[Preserve]
		public static void SwitchMaterialSaver_op_Inequality()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x11BE2AC", Offset = "0x11BE2AC", VA = "0x11BE2AC")]
		[Preserve]
		public static void SwitchTrigger_op_Equality()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x11BE37C", Offset = "0x11BE37C", VA = "0x11BE37C")]
		[Preserve]
		public static void SwitchTrigger_op_Implicit()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x11BE444", Offset = "0x11BE444", VA = "0x11BE444")]
		[Preserve]
		public static void SwitchTrigger_op_Inequality()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x11BE514", Offset = "0x11BE514", VA = "0x11BE514")]
		[Preserve]
		public static void SymbolDrawingPuzzle_op_Equality()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x11BE5E4", Offset = "0x11BE5E4", VA = "0x11BE5E4")]
		[Preserve]
		public static void SymbolDrawingPuzzle_op_Implicit()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x11BE6AC", Offset = "0x11BE6AC", VA = "0x11BE6AC")]
		[Preserve]
		public static void SymbolDrawingPuzzle_op_Inequality()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x11BE77C", Offset = "0x11BE77C", VA = "0x11BE77C")]
		[Preserve]
		public static void SymbolDrawingSegment_op_Equality()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x11BE84C", Offset = "0x11BE84C", VA = "0x11BE84C")]
		[Preserve]
		public static void SymbolDrawingSegment_op_Implicit()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x11BE914", Offset = "0x11BE914", VA = "0x11BE914")]
		[Preserve]
		public static void SymbolDrawingSegment_op_Inequality()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x11BE9E4", Offset = "0x11BE9E4", VA = "0x11BE9E4")]
		[Preserve]
		public static void SymbolDrawingSolution_op_Equality()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x11BEAB4", Offset = "0x11BEAB4", VA = "0x11BEAB4")]
		[Preserve]
		public static void SymbolDrawingSolution_op_Implicit()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x11BEB7C", Offset = "0x11BEB7C", VA = "0x11BEB7C")]
		[Preserve]
		public static void SymbolDrawingSolution_op_Inequality()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x11BEC4C", Offset = "0x11BEC4C", VA = "0x11BEC4C")]
		[Preserve]
		public static void TeleportPointer_op_Equality()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x11BED1C", Offset = "0x11BED1C", VA = "0x11BED1C")]
		[Preserve]
		public static void TeleportPointer_op_Implicit()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x11BEDE4", Offset = "0x11BEDE4", VA = "0x11BEDE4")]
		[Preserve]
		public static void TeleportPointer_op_Inequality()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x11BEEB4", Offset = "0x11BEEB4", VA = "0x11BEEB4")]
		[Preserve]
		public static void TempleOoze_op_Equality()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x11BEF84", Offset = "0x11BEF84", VA = "0x11BEF84")]
		[Preserve]
		public static void TempleOoze_op_Implicit()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x11BF04C", Offset = "0x11BF04C", VA = "0x11BF04C")]
		[Preserve]
		public static void TempleOoze_op_Inequality()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x11BF11C", Offset = "0x11BF11C", VA = "0x11BF11C")]
		[Preserve]
		public static void TextureAtlas_op_Equality()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x11BF1EC", Offset = "0x11BF1EC", VA = "0x11BF1EC")]
		[Preserve]
		public static void TextureAtlas_op_Implicit()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x11BF2B4", Offset = "0x11BF2B4", VA = "0x11BF2B4")]
		[Preserve]
		public static void TextureAtlas_op_Inequality()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x11BF384", Offset = "0x11BF384", VA = "0x11BF384")]
		[Preserve]
		public static void TheRoomAudioManager_op_Equality()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x11BF454", Offset = "0x11BF454", VA = "0x11BF454")]
		[Preserve]
		public static void TheRoomAudioManager_op_Implicit()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x11BF51C", Offset = "0x11BF51C", VA = "0x11BF51C")]
		[Preserve]
		public static void TheRoomAudioManager_op_Inequality()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x11BF5EC", Offset = "0x11BF5EC", VA = "0x11BF5EC")]
		[Preserve]
		public static void TimelineLoopPropertyRandomiser_op_Equality()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x11BF6BC", Offset = "0x11BF6BC", VA = "0x11BF6BC")]
		[Preserve]
		public static void TimelineLoopPropertyRandomiser_op_Implicit()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x11BF784", Offset = "0x11BF784", VA = "0x11BF784")]
		[Preserve]
		public static void TimelineLoopPropertyRandomiser_op_Inequality()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x11BF854", Offset = "0x11BF854", VA = "0x11BF854")]
		[Preserve]
		public static void Tonemapping_op_Equality()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x11BF924", Offset = "0x11BF924", VA = "0x11BF924")]
		[Preserve]
		public static void Tonemapping_op_Implicit()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x11BF9EC", Offset = "0x11BF9EC", VA = "0x11BF9EC")]
		[Preserve]
		public static void Tonemapping_op_Inequality()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x11BFABC", Offset = "0x11BFABC", VA = "0x11BFABC")]
		[Preserve]
		public static void TrackedControllerInterface_op_Equality()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x11BFB8C", Offset = "0x11BFB8C", VA = "0x11BFB8C")]
		[Preserve]
		public static void TrackedControllerInterface_op_Implicit()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x11BFC54", Offset = "0x11BFC54", VA = "0x11BFC54")]
		[Preserve]
		public static void TrackedControllerInterface_op_Inequality()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x11BFD24", Offset = "0x11BFD24", VA = "0x11BFD24")]
		[Preserve]
		public static void TrackingSpace_op_Equality()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x11BFDF4", Offset = "0x11BFDF4", VA = "0x11BFDF4")]
		[Preserve]
		public static void TrackingSpace_op_Implicit()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x11BFEBC", Offset = "0x11BFEBC", VA = "0x11BFEBC")]
		[Preserve]
		public static void TrackingSpace_op_Inequality()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x11BFF8C", Offset = "0x11BFF8C", VA = "0x11BFF8C")]
		[Preserve]
		public static void TransformSaver_op_Equality()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x11C005C", Offset = "0x11C005C", VA = "0x11C005C")]
		[Preserve]
		public static void TransformSaver_op_Implicit()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x11C0124", Offset = "0x11C0124", VA = "0x11C0124")]
		[Preserve]
		public static void TransformSaver_op_Inequality()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x11C01F4", Offset = "0x11C01F4", VA = "0x11C01F4")]
		[Preserve]
		public static void TransformUVs_op_Equality()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x11C02C4", Offset = "0x11C02C4", VA = "0x11C02C4")]
		[Preserve]
		public static void TransformUVs_op_Implicit()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x11C038C", Offset = "0x11C038C", VA = "0x11C038C")]
		[Preserve]
		public static void TransformUVs_op_Inequality()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x11C045C", Offset = "0x11C045C", VA = "0x11C045C")]
		[Preserve]
		public static void TranslationDrivenTranslation_op_Equality()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x11C052C", Offset = "0x11C052C", VA = "0x11C052C")]
		[Preserve]
		public static void TranslationDrivenTranslation_op_Implicit()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x11C05F4", Offset = "0x11C05F4", VA = "0x11C05F4")]
		[Preserve]
		public static void TranslationDrivenTranslation_op_Inequality()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x11C06C4", Offset = "0x11C06C4", VA = "0x11C06C4")]
		[Preserve]
		public static void TriggerBase_op_Equality()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x11C0794", Offset = "0x11C0794", VA = "0x11C0794")]
		[Preserve]
		public static void TriggerBase_op_Implicit()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x11C085C", Offset = "0x11C085C", VA = "0x11C085C")]
		[Preserve]
		public static void TriggerBase_op_Inequality()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x11C092C", Offset = "0x11C092C", VA = "0x11C092C")]
		[Preserve]
		public static void TutorialMessageBox_DismissMessage()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x11C0960", Offset = "0x11C0960", VA = "0x11C0960")]
		[Preserve]
		public static void TutorialMessageBox_DoTutorialMessageBox()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x11C0994", Offset = "0x11C0994", VA = "0x11C0994")]
		[Preserve]
		public static void TutorialMessageBox_DoTutorialMessageBoxWithAlternate()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x11C09C8", Offset = "0x11C09C8", VA = "0x11C09C8")]
		[Preserve]
		public static void TutorialMessageBox_op_Equality()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x11C0A98", Offset = "0x11C0A98", VA = "0x11C0A98")]
		[Preserve]
		public static void TutorialMessageBox_op_Implicit()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x11C0B60", Offset = "0x11C0B60", VA = "0x11C0B60")]
		[Preserve]
		public static void TutorialMessageBox_op_Inequality()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x11C0C30", Offset = "0x11C0C30", VA = "0x11C0C30")]
		[Preserve]
		public static void UIFadeRenderer_op_Equality()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x11C0D00", Offset = "0x11C0D00", VA = "0x11C0D00")]
		[Preserve]
		public static void UIFadeRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x11C0DC8", Offset = "0x11C0DC8", VA = "0x11C0DC8")]
		[Preserve]
		public static void UIFadeRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x11C0E98", Offset = "0x11C0E98", VA = "0x11C0E98")]
		[Preserve]
		public static void UiOptionSelector_op_Equality()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x11C0F68", Offset = "0x11C0F68", VA = "0x11C0F68")]
		[Preserve]
		public static void UiOptionSelector_op_Implicit()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x11C1030", Offset = "0x11C1030", VA = "0x11C1030")]
		[Preserve]
		public static void UiOptionSelector_op_Inequality()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x11C1100", Offset = "0x11C1100", VA = "0x11C1100")]
		[Preserve]
		public static void UnityEngine_AI_NavMeshAgent_op_Equality()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x11C11D0", Offset = "0x11C11D0", VA = "0x11C11D0")]
		[Preserve]
		public static void UnityEngine_AI_NavMeshAgent_op_Implicit()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x11C1298", Offset = "0x11C1298", VA = "0x11C1298")]
		[Preserve]
		public static void UnityEngine_AI_NavMeshAgent_op_Inequality()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x11C1368", Offset = "0x11C1368", VA = "0x11C1368")]
		[Preserve]
		public static void UnityEngine_AI_NavMeshData_op_Equality()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x11C1438", Offset = "0x11C1438", VA = "0x11C1438")]
		[Preserve]
		public static void UnityEngine_AI_NavMeshData_op_Implicit()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x11C1500", Offset = "0x11C1500", VA = "0x11C1500")]
		[Preserve]
		public static void UnityEngine_AI_NavMeshData_op_Inequality()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x11C15D0", Offset = "0x11C15D0", VA = "0x11C15D0")]
		[Preserve]
		public static void UnityEngine_AI_NavMeshObstacle_op_Equality()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x11C16A0", Offset = "0x11C16A0", VA = "0x11C16A0")]
		[Preserve]
		public static void UnityEngine_AI_NavMeshObstacle_op_Implicit()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x11C1768", Offset = "0x11C1768", VA = "0x11C1768")]
		[Preserve]
		public static void UnityEngine_AI_NavMeshObstacle_op_Inequality()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x11C1838", Offset = "0x11C1838", VA = "0x11C1838")]
		[Preserve]
		public static void UnityEngine_AI_OffMeshLink_op_Equality()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x11C1908", Offset = "0x11C1908", VA = "0x11C1908")]
		[Preserve]
		public static void UnityEngine_AI_OffMeshLink_op_Implicit()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x11C19D0", Offset = "0x11C19D0", VA = "0x11C19D0")]
		[Preserve]
		public static void UnityEngine_AI_OffMeshLink_op_Inequality()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x11C1AA0", Offset = "0x11C1AA0", VA = "0x11C1AA0")]
		[Preserve]
		public static void UnityEngine_AnchoredJoint2D_op_Equality()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x11C1B70", Offset = "0x11C1B70", VA = "0x11C1B70")]
		[Preserve]
		public static void UnityEngine_AnchoredJoint2D_op_Implicit()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x11C1C38", Offset = "0x11C1C38", VA = "0x11C1C38")]
		[Preserve]
		public static void UnityEngine_AnchoredJoint2D_op_Inequality()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x11C1D08", Offset = "0x11C1D08", VA = "0x11C1D08")]
		[Preserve]
		public static void UnityEngine_Animation_op_Equality()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x11C1DD8", Offset = "0x11C1DD8", VA = "0x11C1DD8")]
		[Preserve]
		public static void UnityEngine_Animation_op_Implicit()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x11C1EA0", Offset = "0x11C1EA0", VA = "0x11C1EA0")]
		[Preserve]
		public static void UnityEngine_Animation_op_Inequality()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x11C1F70", Offset = "0x11C1F70", VA = "0x11C1F70")]
		[Preserve]
		public static void UnityEngine_AnimationClip_op_Equality()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x11C2040", Offset = "0x11C2040", VA = "0x11C2040")]
		[Preserve]
		public static void UnityEngine_AnimationClip_op_Implicit()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x11C2108", Offset = "0x11C2108", VA = "0x11C2108")]
		[Preserve]
		public static void UnityEngine_AnimationClip_op_Inequality()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x11C21D8", Offset = "0x11C21D8", VA = "0x11C21D8")]
		[Preserve]
		public static void UnityEngine_Animations_AimConstraint_op_Equality()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x11C22A8", Offset = "0x11C22A8", VA = "0x11C22A8")]
		[Preserve]
		public static void UnityEngine_Animations_AimConstraint_op_Implicit()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x11C2370", Offset = "0x11C2370", VA = "0x11C2370")]
		[Preserve]
		public static void UnityEngine_Animations_AimConstraint_op_Inequality()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x11C2440", Offset = "0x11C2440", VA = "0x11C2440")]
		[Preserve]
		public static void UnityEngine_Animations_LookAtConstraint_op_Equality()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x11C2510", Offset = "0x11C2510", VA = "0x11C2510")]
		[Preserve]
		public static void UnityEngine_Animations_LookAtConstraint_op_Implicit()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x11C25D8", Offset = "0x11C25D8", VA = "0x11C25D8")]
		[Preserve]
		public static void UnityEngine_Animations_LookAtConstraint_op_Inequality()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x11C26A8", Offset = "0x11C26A8", VA = "0x11C26A8")]
		[Preserve]
		public static void UnityEngine_Animations_ParentConstraint_op_Equality()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x11C2778", Offset = "0x11C2778", VA = "0x11C2778")]
		[Preserve]
		public static void UnityEngine_Animations_ParentConstraint_op_Implicit()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x11C2840", Offset = "0x11C2840", VA = "0x11C2840")]
		[Preserve]
		public static void UnityEngine_Animations_ParentConstraint_op_Inequality()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x11C2910", Offset = "0x11C2910", VA = "0x11C2910")]
		[Preserve]
		public static void UnityEngine_Animations_PositionConstraint_op_Equality()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x11C29E0", Offset = "0x11C29E0", VA = "0x11C29E0")]
		[Preserve]
		public static void UnityEngine_Animations_PositionConstraint_op_Implicit()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x11C2AA8", Offset = "0x11C2AA8", VA = "0x11C2AA8")]
		[Preserve]
		public static void UnityEngine_Animations_PositionConstraint_op_Inequality()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x11C2B78", Offset = "0x11C2B78", VA = "0x11C2B78")]
		[Preserve]
		public static void UnityEngine_Animations_RotationConstraint_op_Equality()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x11C2C48", Offset = "0x11C2C48", VA = "0x11C2C48")]
		[Preserve]
		public static void UnityEngine_Animations_RotationConstraint_op_Implicit()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x11C2D10", Offset = "0x11C2D10", VA = "0x11C2D10")]
		[Preserve]
		public static void UnityEngine_Animations_RotationConstraint_op_Inequality()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x11C2DE0", Offset = "0x11C2DE0", VA = "0x11C2DE0")]
		[Preserve]
		public static void UnityEngine_Animations_ScaleConstraint_op_Equality()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x11C2EB0", Offset = "0x11C2EB0", VA = "0x11C2EB0")]
		[Preserve]
		public static void UnityEngine_Animations_ScaleConstraint_op_Implicit()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x11C2F78", Offset = "0x11C2F78", VA = "0x11C2F78")]
		[Preserve]
		public static void UnityEngine_Animations_ScaleConstraint_op_Inequality()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x11C3048", Offset = "0x11C3048", VA = "0x11C3048")]
		[Preserve]
		public static void UnityEngine_Animator_enabled()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x11C307C", Offset = "0x11C307C", VA = "0x11C307C")]
		[Preserve]
		public static void UnityEngine_Animator_op_Equality()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x11C314C", Offset = "0x11C314C", VA = "0x11C314C")]
		[Preserve]
		public static void UnityEngine_Animator_op_Implicit()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x11C3214", Offset = "0x11C3214", VA = "0x11C3214")]
		[Preserve]
		public static void UnityEngine_Animator_op_Inequality()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x11C32E4", Offset = "0x11C32E4", VA = "0x11C32E4")]
		[Preserve]
		public static void UnityEngine_AnimatorOverrideController_op_Equality()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x11C33B4", Offset = "0x11C33B4", VA = "0x11C33B4")]
		[Preserve]
		public static void UnityEngine_AnimatorOverrideController_op_Implicit()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x11C347C", Offset = "0x11C347C", VA = "0x11C347C")]
		[Preserve]
		public static void UnityEngine_AnimatorOverrideController_op_Inequality()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x11C354C", Offset = "0x11C354C", VA = "0x11C354C")]
		[Preserve]
		public static void UnityEngine_AreaEffector2D_op_Equality()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x11C361C", Offset = "0x11C361C", VA = "0x11C361C")]
		[Preserve]
		public static void UnityEngine_AreaEffector2D_op_Implicit()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x11C36E4", Offset = "0x11C36E4", VA = "0x11C36E4")]
		[Preserve]
		public static void UnityEngine_AreaEffector2D_op_Inequality()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x11C37B4", Offset = "0x11C37B4", VA = "0x11C37B4")]
		[Preserve]
		public static void UnityEngine_Audio_AudioMixer_op_Equality()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x11C3884", Offset = "0x11C3884", VA = "0x11C3884")]
		[Preserve]
		public static void UnityEngine_Audio_AudioMixer_op_Implicit()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x11C394C", Offset = "0x11C394C", VA = "0x11C394C")]
		[Preserve]
		public static void UnityEngine_Audio_AudioMixer_op_Inequality()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x11C3A1C", Offset = "0x11C3A1C", VA = "0x11C3A1C")]
		[Preserve]
		public static void UnityEngine_Audio_AudioMixerGroup_op_Equality()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x11C3AEC", Offset = "0x11C3AEC", VA = "0x11C3AEC")]
		[Preserve]
		public static void UnityEngine_Audio_AudioMixerGroup_op_Implicit()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x11C3BB4", Offset = "0x11C3BB4", VA = "0x11C3BB4")]
		[Preserve]
		public static void UnityEngine_Audio_AudioMixerGroup_op_Inequality()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x11C3C84", Offset = "0x11C3C84", VA = "0x11C3C84")]
		[Preserve]
		public static void UnityEngine_Audio_AudioMixerSnapshot_op_Equality()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x11C3D54", Offset = "0x11C3D54", VA = "0x11C3D54")]
		[Preserve]
		public static void UnityEngine_Audio_AudioMixerSnapshot_op_Implicit()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x11C3E1C", Offset = "0x11C3E1C", VA = "0x11C3E1C")]
		[Preserve]
		public static void UnityEngine_Audio_AudioMixerSnapshot_op_Inequality()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x11C3EEC", Offset = "0x11C3EEC", VA = "0x11C3EEC")]
		[Preserve]
		public static void UnityEngine_AudioBehaviour_op_Equality()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x11C3FBC", Offset = "0x11C3FBC", VA = "0x11C3FBC")]
		[Preserve]
		public static void UnityEngine_AudioBehaviour_op_Implicit()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x11C4084", Offset = "0x11C4084", VA = "0x11C4084")]
		[Preserve]
		public static void UnityEngine_AudioBehaviour_op_Inequality()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x11C4154", Offset = "0x11C4154", VA = "0x11C4154")]
		[Preserve]
		public static void UnityEngine_AudioChorusFilter_op_Equality()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x11C4224", Offset = "0x11C4224", VA = "0x11C4224")]
		[Preserve]
		public static void UnityEngine_AudioChorusFilter_op_Implicit()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x11C42EC", Offset = "0x11C42EC", VA = "0x11C42EC")]
		[Preserve]
		public static void UnityEngine_AudioChorusFilter_op_Inequality()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x11C43BC", Offset = "0x11C43BC", VA = "0x11C43BC")]
		[Preserve]
		public static void UnityEngine_AudioClip_op_Equality()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x11C448C", Offset = "0x11C448C", VA = "0x11C448C")]
		[Preserve]
		public static void UnityEngine_AudioClip_op_Implicit()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x11C4554", Offset = "0x11C4554", VA = "0x11C4554")]
		[Preserve]
		public static void UnityEngine_AudioClip_op_Inequality()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x11C4624", Offset = "0x11C4624", VA = "0x11C4624")]
		[Preserve]
		public static void UnityEngine_AudioDistortionFilter_op_Equality()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x11C46F4", Offset = "0x11C46F4", VA = "0x11C46F4")]
		[Preserve]
		public static void UnityEngine_AudioDistortionFilter_op_Implicit()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x11C47BC", Offset = "0x11C47BC", VA = "0x11C47BC")]
		[Preserve]
		public static void UnityEngine_AudioDistortionFilter_op_Inequality()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x11C488C", Offset = "0x11C488C", VA = "0x11C488C")]
		[Preserve]
		public static void UnityEngine_AudioEchoFilter_op_Equality()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x11C495C", Offset = "0x11C495C", VA = "0x11C495C")]
		[Preserve]
		public static void UnityEngine_AudioEchoFilter_op_Implicit()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x11C4A24", Offset = "0x11C4A24", VA = "0x11C4A24")]
		[Preserve]
		public static void UnityEngine_AudioEchoFilter_op_Inequality()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x11C4AF4", Offset = "0x11C4AF4", VA = "0x11C4AF4")]
		[Preserve]
		public static void UnityEngine_AudioHighPassFilter_op_Equality()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x11C4BC4", Offset = "0x11C4BC4", VA = "0x11C4BC4")]
		[Preserve]
		public static void UnityEngine_AudioHighPassFilter_op_Implicit()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x11C4C8C", Offset = "0x11C4C8C", VA = "0x11C4C8C")]
		[Preserve]
		public static void UnityEngine_AudioHighPassFilter_op_Inequality()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x11C4D5C", Offset = "0x11C4D5C", VA = "0x11C4D5C")]
		[Preserve]
		public static void UnityEngine_AudioListener_op_Equality()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x11C4E2C", Offset = "0x11C4E2C", VA = "0x11C4E2C")]
		[Preserve]
		public static void UnityEngine_AudioListener_op_Implicit()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x11C4EF4", Offset = "0x11C4EF4", VA = "0x11C4EF4")]
		[Preserve]
		public static void UnityEngine_AudioListener_op_Inequality()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x11C4FC4", Offset = "0x11C4FC4", VA = "0x11C4FC4")]
		[Preserve]
		public static void UnityEngine_AudioLowPassFilter_op_Equality()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x11C5094", Offset = "0x11C5094", VA = "0x11C5094")]
		[Preserve]
		public static void UnityEngine_AudioLowPassFilter_op_Implicit()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x11C515C", Offset = "0x11C515C", VA = "0x11C515C")]
		[Preserve]
		public static void UnityEngine_AudioLowPassFilter_op_Inequality()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x11C522C", Offset = "0x11C522C", VA = "0x11C522C")]
		[Preserve]
		public static void UnityEngine_AudioReverbFilter_op_Equality()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x11C52FC", Offset = "0x11C52FC", VA = "0x11C52FC")]
		[Preserve]
		public static void UnityEngine_AudioReverbFilter_op_Implicit()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x11C53C4", Offset = "0x11C53C4", VA = "0x11C53C4")]
		[Preserve]
		public static void UnityEngine_AudioReverbFilter_op_Inequality()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x11C5494", Offset = "0x11C5494", VA = "0x11C5494")]
		[Preserve]
		public static void UnityEngine_AudioReverbZone_op_Equality()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x11C5564", Offset = "0x11C5564", VA = "0x11C5564")]
		[Preserve]
		public static void UnityEngine_AudioReverbZone_op_Implicit()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x11C562C", Offset = "0x11C562C", VA = "0x11C562C")]
		[Preserve]
		public static void UnityEngine_AudioReverbZone_op_Inequality()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x11C56FC", Offset = "0x11C56FC", VA = "0x11C56FC")]
		[Preserve]
		public static void UnityEngine_AudioSource_op_Equality()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x11C57CC", Offset = "0x11C57CC", VA = "0x11C57CC")]
		[Preserve]
		public static void UnityEngine_AudioSource_op_Implicit()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x11C5894", Offset = "0x11C5894", VA = "0x11C5894")]
		[Preserve]
		public static void UnityEngine_AudioSource_op_Inequality()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x11C5964", Offset = "0x11C5964", VA = "0x11C5964")]
		[Preserve]
		public static void UnityEngine_Avatar_op_Equality()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x11C5A34", Offset = "0x11C5A34", VA = "0x11C5A34")]
		[Preserve]
		public static void UnityEngine_Avatar_op_Implicit()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x11C5AFC", Offset = "0x11C5AFC", VA = "0x11C5AFC")]
		[Preserve]
		public static void UnityEngine_Avatar_op_Inequality()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x11C5BCC", Offset = "0x11C5BCC", VA = "0x11C5BCC")]
		[Preserve]
		public static void UnityEngine_AvatarMask_op_Equality()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x11C5C9C", Offset = "0x11C5C9C", VA = "0x11C5C9C")]
		[Preserve]
		public static void UnityEngine_AvatarMask_op_Implicit()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x11C5D64", Offset = "0x11C5D64", VA = "0x11C5D64")]
		[Preserve]
		public static void UnityEngine_AvatarMask_op_Inequality()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x11C5E34", Offset = "0x11C5E34", VA = "0x11C5E34")]
		[Preserve]
		public static void UnityEngine_Behaviour_op_Equality()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x11C5F04", Offset = "0x11C5F04", VA = "0x11C5F04")]
		[Preserve]
		public static void UnityEngine_Behaviour_op_Implicit()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x11C5FCC", Offset = "0x11C5FCC", VA = "0x11C5FCC")]
		[Preserve]
		public static void UnityEngine_Behaviour_op_Inequality()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x11C609C", Offset = "0x11C609C", VA = "0x11C609C")]
		[Preserve]
		public static void UnityEngine_BillboardAsset_op_Equality()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x11C616C", Offset = "0x11C616C", VA = "0x11C616C")]
		[Preserve]
		public static void UnityEngine_BillboardAsset_op_Implicit()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x11C6234", Offset = "0x11C6234", VA = "0x11C6234")]
		[Preserve]
		public static void UnityEngine_BillboardAsset_op_Inequality()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x11C6304", Offset = "0x11C6304", VA = "0x11C6304")]
		[Preserve]
		public static void UnityEngine_BillboardRenderer_op_Equality()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x11C63D4", Offset = "0x11C63D4", VA = "0x11C63D4")]
		[Preserve]
		public static void UnityEngine_BillboardRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x11C649C", Offset = "0x11C649C", VA = "0x11C649C")]
		[Preserve]
		public static void UnityEngine_BillboardRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x11C656C", Offset = "0x11C656C", VA = "0x11C656C")]
		[Preserve]
		public static void UnityEngine_Bounds_op_Equality()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x11C6674", Offset = "0x11C6674", VA = "0x11C6674")]
		[Preserve]
		public static void UnityEngine_Bounds_op_Inequality()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x11C677C", Offset = "0x11C677C", VA = "0x11C677C")]
		[Preserve]
		public static void UnityEngine_BoxCollider_enabled()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x11C67B0", Offset = "0x11C67B0", VA = "0x11C67B0")]
		[Preserve]
		public static void UnityEngine_BoxCollider_op_Equality()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x11C6880", Offset = "0x11C6880", VA = "0x11C6880")]
		[Preserve]
		public static void UnityEngine_BoxCollider_op_Implicit()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x11C6948", Offset = "0x11C6948", VA = "0x11C6948")]
		[Preserve]
		public static void UnityEngine_BoxCollider_op_Inequality()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x11C6A18", Offset = "0x11C6A18", VA = "0x11C6A18")]
		[Preserve]
		public static void UnityEngine_BoxCollider2D_op_Equality()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x11C6AE8", Offset = "0x11C6AE8", VA = "0x11C6AE8")]
		[Preserve]
		public static void UnityEngine_BoxCollider2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x11C6BB0", Offset = "0x11C6BB0", VA = "0x11C6BB0")]
		[Preserve]
		public static void UnityEngine_BoxCollider2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x11C6C80", Offset = "0x11C6C80", VA = "0x11C6C80")]
		[Preserve]
		public static void UnityEngine_BuoyancyEffector2D_op_Equality()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x11C6D50", Offset = "0x11C6D50", VA = "0x11C6D50")]
		[Preserve]
		public static void UnityEngine_BuoyancyEffector2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x11C6E18", Offset = "0x11C6E18", VA = "0x11C6E18")]
		[Preserve]
		public static void UnityEngine_BuoyancyEffector2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x11C6EE8", Offset = "0x11C6EE8", VA = "0x11C6EE8")]
		[Preserve]
		public static void UnityEngine_Camera_op_Equality()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x11C6FB8", Offset = "0x11C6FB8", VA = "0x11C6FB8")]
		[Preserve]
		public static void UnityEngine_Camera_op_Implicit()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x11C7080", Offset = "0x11C7080", VA = "0x11C7080")]
		[Preserve]
		public static void UnityEngine_Camera_op_Inequality()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x11C7150", Offset = "0x11C7150", VA = "0x11C7150")]
		[Preserve]
		public static void UnityEngine_Canvas_op_Equality()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x11C7220", Offset = "0x11C7220", VA = "0x11C7220")]
		[Preserve]
		public static void UnityEngine_Canvas_op_Implicit()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x11C72E8", Offset = "0x11C72E8", VA = "0x11C72E8")]
		[Preserve]
		public static void UnityEngine_Canvas_op_Inequality()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x11C73B8", Offset = "0x11C73B8", VA = "0x11C73B8")]
		[Preserve]
		public static void UnityEngine_CanvasGroup_alpha()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x11C73EC", Offset = "0x11C73EC", VA = "0x11C73EC")]
		[Preserve]
		public static void UnityEngine_CanvasGroup_op_Equality()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x11C74BC", Offset = "0x11C74BC", VA = "0x11C74BC")]
		[Preserve]
		public static void UnityEngine_CanvasGroup_op_Implicit()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x11C7584", Offset = "0x11C7584", VA = "0x11C7584")]
		[Preserve]
		public static void UnityEngine_CanvasGroup_op_Inequality()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x11C7654", Offset = "0x11C7654", VA = "0x11C7654")]
		[Preserve]
		public static void UnityEngine_CanvasRenderer_op_Equality()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x11C7724", Offset = "0x11C7724", VA = "0x11C7724")]
		[Preserve]
		public static void UnityEngine_CanvasRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x11C77EC", Offset = "0x11C77EC", VA = "0x11C77EC")]
		[Preserve]
		public static void UnityEngine_CanvasRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x11C78BC", Offset = "0x11C78BC", VA = "0x11C78BC")]
		[Preserve]
		public static void UnityEngine_CapsuleCollider_op_Equality()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x11C798C", Offset = "0x11C798C", VA = "0x11C798C")]
		[Preserve]
		public static void UnityEngine_CapsuleCollider_op_Implicit()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x11C7A54", Offset = "0x11C7A54", VA = "0x11C7A54")]
		[Preserve]
		public static void UnityEngine_CapsuleCollider_op_Inequality()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x11C7B24", Offset = "0x11C7B24", VA = "0x11C7B24")]
		[Preserve]
		public static void UnityEngine_CapsuleCollider2D_op_Equality()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x11C7BF4", Offset = "0x11C7BF4", VA = "0x11C7BF4")]
		[Preserve]
		public static void UnityEngine_CapsuleCollider2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x11C7CBC", Offset = "0x11C7CBC", VA = "0x11C7CBC")]
		[Preserve]
		public static void UnityEngine_CapsuleCollider2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x11C7D8C", Offset = "0x11C7D8C", VA = "0x11C7D8C")]
		[Preserve]
		public static void UnityEngine_CharacterController_op_Equality()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x11C7E5C", Offset = "0x11C7E5C", VA = "0x11C7E5C")]
		[Preserve]
		public static void UnityEngine_CharacterController_op_Implicit()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x11C7F24", Offset = "0x11C7F24", VA = "0x11C7F24")]
		[Preserve]
		public static void UnityEngine_CharacterController_op_Inequality()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x11C7FF4", Offset = "0x11C7FF4", VA = "0x11C7FF4")]
		[Preserve]
		public static void UnityEngine_CharacterJoint_op_Equality()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x11C80C4", Offset = "0x11C80C4", VA = "0x11C80C4")]
		[Preserve]
		public static void UnityEngine_CharacterJoint_op_Implicit()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x11C818C", Offset = "0x11C818C", VA = "0x11C818C")]
		[Preserve]
		public static void UnityEngine_CharacterJoint_op_Inequality()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x11C825C", Offset = "0x11C825C", VA = "0x11C825C")]
		[Preserve]
		public static void UnityEngine_CircleCollider2D_op_Equality()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x11C832C", Offset = "0x11C832C", VA = "0x11C832C")]
		[Preserve]
		public static void UnityEngine_CircleCollider2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x11C83F4", Offset = "0x11C83F4", VA = "0x11C83F4")]
		[Preserve]
		public static void UnityEngine_CircleCollider2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x11C84C4", Offset = "0x11C84C4", VA = "0x11C84C4")]
		[Preserve]
		public static void UnityEngine_Cloth_op_Equality()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x11C8594", Offset = "0x11C8594", VA = "0x11C8594")]
		[Preserve]
		public static void UnityEngine_Cloth_op_Implicit()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x11C865C", Offset = "0x11C865C", VA = "0x11C865C")]
		[Preserve]
		public static void UnityEngine_Cloth_op_Inequality()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x11C872C", Offset = "0x11C872C", VA = "0x11C872C")]
		[Preserve]
		public static void UnityEngine_Collider_op_Equality()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x11C87FC", Offset = "0x11C87FC", VA = "0x11C87FC")]
		[Preserve]
		public static void UnityEngine_Collider_op_Implicit()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x11C88C4", Offset = "0x11C88C4", VA = "0x11C88C4")]
		[Preserve]
		public static void UnityEngine_Collider_op_Inequality()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x11C8994", Offset = "0x11C8994", VA = "0x11C8994")]
		[Preserve]
		public static void UnityEngine_Collider2D_op_Equality()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x11C8A64", Offset = "0x11C8A64", VA = "0x11C8A64")]
		[Preserve]
		public static void UnityEngine_Collider2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x11C8B2C", Offset = "0x11C8B2C", VA = "0x11C8B2C")]
		[Preserve]
		public static void UnityEngine_Collider2D_op_Inequality()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x11C8BFC", Offset = "0x11C8BFC", VA = "0x11C8BFC")]
		[Preserve]
		public static void UnityEngine_Color_op_Addition()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x11C8D04", Offset = "0x11C8D04", VA = "0x11C8D04")]
		[Preserve]
		public static void UnityEngine_Color_op_Division()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x11C8E00", Offset = "0x11C8E00", VA = "0x11C8E00")]
		[Preserve]
		public static void UnityEngine_Color_op_Equality()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x11C8F08", Offset = "0x11C8F08", VA = "0x11C8F08")]
		[Preserve]
		public static void UnityEngine_Color_op_Implicit()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x11C8FE0", Offset = "0x11C8FE0", VA = "0x11C8FE0")]
		[Preserve]
		public static void UnityEngine_Color_op_Implicit_0()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x11C90B8", Offset = "0x11C90B8", VA = "0x11C90B8")]
		[Preserve]
		public static void UnityEngine_Color_op_Inequality()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x11C91C0", Offset = "0x11C91C0", VA = "0x11C91C0")]
		[Preserve]
		public static void UnityEngine_Color_op_Multiply()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x11C92C8", Offset = "0x11C92C8", VA = "0x11C92C8")]
		[Preserve]
		public static void UnityEngine_Color_op_Multiply_0()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x11C93C4", Offset = "0x11C93C4", VA = "0x11C93C4")]
		[Preserve]
		public static void UnityEngine_Color_op_Multiply_1()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x11C94C0", Offset = "0x11C94C0", VA = "0x11C94C0")]
		[Preserve]
		public static void UnityEngine_Color_op_Subtraction()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x11C95C8", Offset = "0x11C95C8", VA = "0x11C95C8")]
		[Preserve]
		public static void UnityEngine_Component_Equals()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x11C9678", Offset = "0x11C9678", VA = "0x11C9678")]
		[Preserve]
		public static void UnityEngine_Component_op_Equality()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x11C9748", Offset = "0x11C9748", VA = "0x11C9748")]
		[Preserve]
		public static void UnityEngine_Component_op_Implicit()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x11C9810", Offset = "0x11C9810", VA = "0x11C9810")]
		[Preserve]
		public static void UnityEngine_Component_op_Inequality()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x11C98E0", Offset = "0x11C98E0", VA = "0x11C98E0")]
		[Preserve]
		public static void UnityEngine_CompositeCollider2D_op_Equality()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x11C99B0", Offset = "0x11C99B0", VA = "0x11C99B0")]
		[Preserve]
		public static void UnityEngine_CompositeCollider2D_op_Implicit()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x11C9A78", Offset = "0x11C9A78", VA = "0x11C9A78")]
		[Preserve]
		public static void UnityEngine_CompositeCollider2D_op_Inequality()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x11C9B48", Offset = "0x11C9B48", VA = "0x11C9B48")]
		[Preserve]
		public static void UnityEngine_ComputeShader_op_Equality()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x11C9C18", Offset = "0x11C9C18", VA = "0x11C9C18")]
		[Preserve]
		public static void UnityEngine_ComputeShader_op_Implicit()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x11C9CE0", Offset = "0x11C9CE0", VA = "0x11C9CE0")]
		[Preserve]
		public static void UnityEngine_ComputeShader_op_Inequality()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x11C9DB0", Offset = "0x11C9DB0", VA = "0x11C9DB0")]
		[Preserve]
		public static void UnityEngine_ConfigurableJoint_op_Equality()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x11C9E80", Offset = "0x11C9E80", VA = "0x11C9E80")]
		[Preserve]
		public static void UnityEngine_ConfigurableJoint_op_Implicit()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x11C9F48", Offset = "0x11C9F48", VA = "0x11C9F48")]
		[Preserve]
		public static void UnityEngine_ConfigurableJoint_op_Inequality()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x11CA018", Offset = "0x11CA018", VA = "0x11CA018")]
		[Preserve]
		public static void UnityEngine_ConstantForce_op_Equality()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x11CA0E8", Offset = "0x11CA0E8", VA = "0x11CA0E8")]
		[Preserve]
		public static void UnityEngine_ConstantForce_op_Implicit()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x11CA1B0", Offset = "0x11CA1B0", VA = "0x11CA1B0")]
		[Preserve]
		public static void UnityEngine_ConstantForce_op_Inequality()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x11CA280", Offset = "0x11CA280", VA = "0x11CA280")]
		[Preserve]
		public static void UnityEngine_ConstantForce2D_op_Equality()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x11CA350", Offset = "0x11CA350", VA = "0x11CA350")]
		[Preserve]
		public static void UnityEngine_ConstantForce2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x11CA418", Offset = "0x11CA418", VA = "0x11CA418")]
		[Preserve]
		public static void UnityEngine_ConstantForce2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x11CA4E8", Offset = "0x11CA4E8", VA = "0x11CA4E8")]
		[Preserve]
		public static void UnityEngine_Cubemap_op_Equality()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x11CA5B8", Offset = "0x11CA5B8", VA = "0x11CA5B8")]
		[Preserve]
		public static void UnityEngine_Cubemap_op_Implicit()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x11CA680", Offset = "0x11CA680", VA = "0x11CA680")]
		[Preserve]
		public static void UnityEngine_Cubemap_op_Inequality()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x11CA750", Offset = "0x11CA750", VA = "0x11CA750")]
		[Preserve]
		public static void UnityEngine_CubemapArray_op_Equality()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x11CA820", Offset = "0x11CA820", VA = "0x11CA820")]
		[Preserve]
		public static void UnityEngine_CubemapArray_op_Implicit()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x11CA8E8", Offset = "0x11CA8E8", VA = "0x11CA8E8")]
		[Preserve]
		public static void UnityEngine_CubemapArray_op_Inequality()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x11CA9B8", Offset = "0x11CA9B8", VA = "0x11CA9B8")]
		[Preserve]
		public static void UnityEngine_CustomRenderTexture_op_Equality()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x11CAA88", Offset = "0x11CAA88", VA = "0x11CAA88")]
		[Preserve]
		public static void UnityEngine_CustomRenderTexture_op_Implicit()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x11CAB50", Offset = "0x11CAB50", VA = "0x11CAB50")]
		[Preserve]
		public static void UnityEngine_CustomRenderTexture_op_Inequality()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x11CAC20", Offset = "0x11CAC20", VA = "0x11CAC20")]
		[Preserve]
		public static void UnityEngine_Debug_Log()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x11CACE8", Offset = "0x11CACE8", VA = "0x11CACE8")]
		[Preserve]
		public static void UnityEngine_DistanceJoint2D_op_Equality()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x11CADB8", Offset = "0x11CADB8", VA = "0x11CADB8")]
		[Preserve]
		public static void UnityEngine_DistanceJoint2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x11CAE80", Offset = "0x11CAE80", VA = "0x11CAE80")]
		[Preserve]
		public static void UnityEngine_DistanceJoint2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x11CAF50", Offset = "0x11CAF50", VA = "0x11CAF50")]
		[Preserve]
		public static void UnityEngine_EdgeCollider2D_op_Equality()
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x11CB020", Offset = "0x11CB020", VA = "0x11CB020")]
		[Preserve]
		public static void UnityEngine_EdgeCollider2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x11CB0E8", Offset = "0x11CB0E8", VA = "0x11CB0E8")]
		[Preserve]
		public static void UnityEngine_EdgeCollider2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x11CB1B8", Offset = "0x11CB1B8", VA = "0x11CB1B8")]
		[Preserve]
		public static void UnityEngine_Effector2D_op_Equality()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x11CB288", Offset = "0x11CB288", VA = "0x11CB288")]
		[Preserve]
		public static void UnityEngine_Effector2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x11CB350", Offset = "0x11CB350", VA = "0x11CB350")]
		[Preserve]
		public static void UnityEngine_Effector2D_op_Inequality()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x11CB420", Offset = "0x11CB420", VA = "0x11CB420")]
		[Preserve]
		public static void UnityEngine_EventSystems_BaseInput_op_Equality()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x11CB4F0", Offset = "0x11CB4F0", VA = "0x11CB4F0")]
		[Preserve]
		public static void UnityEngine_EventSystems_BaseInput_op_Implicit()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x11CB5B8", Offset = "0x11CB5B8", VA = "0x11CB5B8")]
		[Preserve]
		public static void UnityEngine_EventSystems_BaseInput_op_Inequality()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x11CB688", Offset = "0x11CB688", VA = "0x11CB688")]
		[Preserve]
		public static void UnityEngine_EventSystems_BaseInputModule_op_Equality()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x11CB758", Offset = "0x11CB758", VA = "0x11CB758")]
		[Preserve]
		public static void UnityEngine_EventSystems_BaseInputModule_op_Implicit()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x11CB820", Offset = "0x11CB820", VA = "0x11CB820")]
		[Preserve]
		public static void UnityEngine_EventSystems_BaseInputModule_op_Inequality()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x11CB8F0", Offset = "0x11CB8F0", VA = "0x11CB8F0")]
		[Preserve]
		public static void UnityEngine_EventSystems_BaseRaycaster_op_Equality()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x11CB9C0", Offset = "0x11CB9C0", VA = "0x11CB9C0")]
		[Preserve]
		public static void UnityEngine_EventSystems_BaseRaycaster_op_Implicit()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x11CBA88", Offset = "0x11CBA88", VA = "0x11CBA88")]
		[Preserve]
		public static void UnityEngine_EventSystems_BaseRaycaster_op_Inequality()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x11CBB58", Offset = "0x11CBB58", VA = "0x11CBB58")]
		[Preserve]
		public static void UnityEngine_EventSystems_EventSystem_op_Equality()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x11CBC28", Offset = "0x11CBC28", VA = "0x11CBC28")]
		[Preserve]
		public static void UnityEngine_EventSystems_EventSystem_op_Implicit()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x11CBCF0", Offset = "0x11CBCF0", VA = "0x11CBCF0")]
		[Preserve]
		public static void UnityEngine_EventSystems_EventSystem_op_Inequality()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x11CBDC0", Offset = "0x11CBDC0", VA = "0x11CBDC0")]
		[Preserve]
		public static void UnityEngine_EventSystems_EventTrigger_op_Equality()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x11CBE90", Offset = "0x11CBE90", VA = "0x11CBE90")]
		[Preserve]
		public static void UnityEngine_EventSystems_EventTrigger_op_Implicit()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x11CBF58", Offset = "0x11CBF58", VA = "0x11CBF58")]
		[Preserve]
		public static void UnityEngine_EventSystems_EventTrigger_op_Inequality()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x11CC028", Offset = "0x11CC028", VA = "0x11CC028")]
		[Preserve]
		public static void UnityEngine_EventSystems_Physics2DRaycaster_op_Equality()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x11CC0F8", Offset = "0x11CC0F8", VA = "0x11CC0F8")]
		[Preserve]
		public static void UnityEngine_EventSystems_Physics2DRaycaster_op_Implicit()
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x11CC1C0", Offset = "0x11CC1C0", VA = "0x11CC1C0")]
		[Preserve]
		public static void UnityEngine_EventSystems_Physics2DRaycaster_op_Inequality()
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x11CC290", Offset = "0x11CC290", VA = "0x11CC290")]
		[Preserve]
		public static void UnityEngine_EventSystems_PhysicsRaycaster_op_Equality()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x11CC360", Offset = "0x11CC360", VA = "0x11CC360")]
		[Preserve]
		public static void UnityEngine_EventSystems_PhysicsRaycaster_op_Implicit()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x11CC428", Offset = "0x11CC428", VA = "0x11CC428")]
		[Preserve]
		public static void UnityEngine_EventSystems_PhysicsRaycaster_op_Inequality()
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x11CC4F8", Offset = "0x11CC4F8", VA = "0x11CC4F8")]
		[Preserve]
		public static void UnityEngine_EventSystems_PointerInputModule_op_Equality()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x11CC5C8", Offset = "0x11CC5C8", VA = "0x11CC5C8")]
		[Preserve]
		public static void UnityEngine_EventSystems_PointerInputModule_op_Implicit()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x11CC690", Offset = "0x11CC690", VA = "0x11CC690")]
		[Preserve]
		public static void UnityEngine_EventSystems_PointerInputModule_op_Inequality()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x11CC760", Offset = "0x11CC760", VA = "0x11CC760")]
		[Preserve]
		public static void UnityEngine_EventSystems_StandaloneInputModule_op_Equality()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x11CC830", Offset = "0x11CC830", VA = "0x11CC830")]
		[Preserve]
		public static void UnityEngine_EventSystems_StandaloneInputModule_op_Implicit()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x11CC8F8", Offset = "0x11CC8F8", VA = "0x11CC8F8")]
		[Preserve]
		public static void UnityEngine_EventSystems_StandaloneInputModule_op_Inequality()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x11CC9C8", Offset = "0x11CC9C8", VA = "0x11CC9C8")]
		[Preserve]
		public static void UnityEngine_EventSystems_UIBehaviour_op_Equality()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x11CCA98", Offset = "0x11CCA98", VA = "0x11CCA98")]
		[Preserve]
		public static void UnityEngine_EventSystems_UIBehaviour_op_Implicit()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x11CCB60", Offset = "0x11CCB60", VA = "0x11CCB60")]
		[Preserve]
		public static void UnityEngine_EventSystems_UIBehaviour_op_Inequality()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x11CCC30", Offset = "0x11CCC30", VA = "0x11CCC30")]
		[Preserve]
		public static void UnityEngine_EventSystems_VrInputModule_op_Equality()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x11CCD00", Offset = "0x11CCD00", VA = "0x11CCD00")]
		[Preserve]
		public static void UnityEngine_EventSystems_VrInputModule_op_Implicit()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x11CCDC8", Offset = "0x11CCDC8", VA = "0x11CCDC8")]
		[Preserve]
		public static void UnityEngine_EventSystems_VrInputModule_op_Inequality()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x11CCE98", Offset = "0x11CCE98", VA = "0x11CCE98")]
		[Preserve]
		public static void UnityEngine_Experimental_Rendering_RenderPassAttachment_op_Equality()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x11CCF68", Offset = "0x11CCF68", VA = "0x11CCF68")]
		[Preserve]
		public static void UnityEngine_Experimental_Rendering_RenderPassAttachment_op_Implicit()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x11CD030", Offset = "0x11CD030", VA = "0x11CD030")]
		[Preserve]
		public static void UnityEngine_Experimental_Rendering_RenderPassAttachment_op_Inequality()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x11CD100", Offset = "0x11CD100", VA = "0x11CD100")]
		[Preserve]
		public static void UnityEngine_Experimental_Rendering_RenderPipelineAsset_op_Equality()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x11CD1D0", Offset = "0x11CD1D0", VA = "0x11CD1D0")]
		[Preserve]
		public static void UnityEngine_Experimental_Rendering_RenderPipelineAsset_op_Implicit()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x11CD298", Offset = "0x11CD298", VA = "0x11CD298")]
		[Preserve]
		public static void UnityEngine_Experimental_Rendering_RenderPipelineAsset_op_Inequality()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x11CD368", Offset = "0x11CD368", VA = "0x11CD368")]
		[Preserve]
		public static void UnityEngine_Experimental_UIElements_VisualTreeAsset_op_Equality()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x11CD438", Offset = "0x11CD438", VA = "0x11CD438")]
		[Preserve]
		public static void UnityEngine_Experimental_UIElements_VisualTreeAsset_op_Implicit()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x11CD500", Offset = "0x11CD500", VA = "0x11CD500")]
		[Preserve]
		public static void UnityEngine_Experimental_UIElements_VisualTreeAsset_op_Inequality()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x11CD5D0", Offset = "0x11CD5D0", VA = "0x11CD5D0")]
		[Preserve]
		public static void UnityEngine_Experimental_XR_Interaction_BaseArmModel_op_Equality()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x11CD6A0", Offset = "0x11CD6A0", VA = "0x11CD6A0")]
		[Preserve]
		public static void UnityEngine_Experimental_XR_Interaction_BaseArmModel_op_Implicit()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x11CD768", Offset = "0x11CD768", VA = "0x11CD768")]
		[Preserve]
		public static void UnityEngine_Experimental_XR_Interaction_BaseArmModel_op_Inequality()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x11CD838", Offset = "0x11CD838", VA = "0x11CD838")]
		[Preserve]
		public static void UnityEngine_Experimental_XR_Interaction_BasePoseProvider_op_Equality()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x11CD908", Offset = "0x11CD908", VA = "0x11CD908")]
		[Preserve]
		public static void UnityEngine_Experimental_XR_Interaction_BasePoseProvider_op_Implicit()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x11CD9D0", Offset = "0x11CD9D0", VA = "0x11CD9D0")]
		[Preserve]
		public static void UnityEngine_Experimental_XR_Interaction_BasePoseProvider_op_Inequality()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x11CDAA0", Offset = "0x11CDAA0", VA = "0x11CDAA0")]
		[Preserve]
		public static void UnityEngine_FixedJoint_op_Equality()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x11CDB70", Offset = "0x11CDB70", VA = "0x11CDB70")]
		[Preserve]
		public static void UnityEngine_FixedJoint_op_Implicit()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x11CDC38", Offset = "0x11CDC38", VA = "0x11CDC38")]
		[Preserve]
		public static void UnityEngine_FixedJoint_op_Inequality()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x11CDD08", Offset = "0x11CDD08", VA = "0x11CDD08")]
		[Preserve]
		public static void UnityEngine_FixedJoint2D_op_Equality()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x11CDDD8", Offset = "0x11CDDD8", VA = "0x11CDDD8")]
		[Preserve]
		public static void UnityEngine_FixedJoint2D_op_Implicit()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x11CDEA0", Offset = "0x11CDEA0", VA = "0x11CDEA0")]
		[Preserve]
		public static void UnityEngine_FixedJoint2D_op_Inequality()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x11CDF70", Offset = "0x11CDF70", VA = "0x11CDF70")]
		[Preserve]
		public static void UnityEngine_Flare_op_Equality()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x11CE040", Offset = "0x11CE040", VA = "0x11CE040")]
		[Preserve]
		public static void UnityEngine_Flare_op_Implicit()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x11CE108", Offset = "0x11CE108", VA = "0x11CE108")]
		[Preserve]
		public static void UnityEngine_Flare_op_Inequality()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x11CE1D8", Offset = "0x11CE1D8", VA = "0x11CE1D8")]
		[Preserve]
		public static void UnityEngine_FlareLayer_op_Equality()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x11CE2A8", Offset = "0x11CE2A8", VA = "0x11CE2A8")]
		[Preserve]
		public static void UnityEngine_FlareLayer_op_Implicit()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x11CE370", Offset = "0x11CE370", VA = "0x11CE370")]
		[Preserve]
		public static void UnityEngine_FlareLayer_op_Inequality()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x11CE440", Offset = "0x11CE440", VA = "0x11CE440")]
		[Preserve]
		public static void UnityEngine_Font_op_Equality()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x11CE510", Offset = "0x11CE510", VA = "0x11CE510")]
		[Preserve]
		public static void UnityEngine_Font_op_Implicit()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x11CE5D8", Offset = "0x11CE5D8", VA = "0x11CE5D8")]
		[Preserve]
		public static void UnityEngine_Font_op_Inequality()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x11CE6A8", Offset = "0x11CE6A8", VA = "0x11CE6A8")]
		[Preserve]
		public static void UnityEngine_FrictionJoint2D_op_Equality()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x11CE778", Offset = "0x11CE778", VA = "0x11CE778")]
		[Preserve]
		public static void UnityEngine_FrictionJoint2D_op_Implicit()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x11CE840", Offset = "0x11CE840", VA = "0x11CE840")]
		[Preserve]
		public static void UnityEngine_FrictionJoint2D_op_Inequality()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x11CE910", Offset = "0x11CE910", VA = "0x11CE910")]
		[Preserve]
		public static void UnityEngine_GameObject_ctor()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x11CE960", Offset = "0x11CE960", VA = "0x11CE960")]
		[Preserve]
		public static void UnityEngine_GameObject_op_Equality()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x11CEA30", Offset = "0x11CEA30", VA = "0x11CEA30")]
		[Preserve]
		public static void UnityEngine_GameObject_op_Implicit()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x11CEAF8", Offset = "0x11CEAF8", VA = "0x11CEAF8")]
		[Preserve]
		public static void UnityEngine_GameObject_op_Inequality()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x11CEBC8", Offset = "0x11CEBC8", VA = "0x11CEBC8")]
		[Preserve]
		public static void UnityEngine_GameObject_SetActive()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x11CEBFC", Offset = "0x11CEBFC", VA = "0x11CEBFC")]
		[Preserve]
		public static void UnityEngine_GridBrushBase_op_Equality()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x11CECCC", Offset = "0x11CECCC", VA = "0x11CECCC")]
		[Preserve]
		public static void UnityEngine_GridBrushBase_op_Implicit()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x11CED94", Offset = "0x11CED94", VA = "0x11CED94")]
		[Preserve]
		public static void UnityEngine_GridBrushBase_op_Inequality()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x11CEE64", Offset = "0x11CEE64", VA = "0x11CEE64")]
		[Preserve]
		public static void UnityEngine_GUIElement_op_Equality()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x11CEF34", Offset = "0x11CEF34", VA = "0x11CEF34")]
		[Preserve]
		public static void UnityEngine_GUIElement_op_Implicit()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x11CEFFC", Offset = "0x11CEFFC", VA = "0x11CEFFC")]
		[Preserve]
		public static void UnityEngine_GUIElement_op_Inequality()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x11CF0CC", Offset = "0x11CF0CC", VA = "0x11CF0CC")]
		[Preserve]
		public static void UnityEngine_GUISkin_op_Equality()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x11CF19C", Offset = "0x11CF19C", VA = "0x11CF19C")]
		[Preserve]
		public static void UnityEngine_GUISkin_op_Implicit()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x11CF264", Offset = "0x11CF264", VA = "0x11CF264")]
		[Preserve]
		public static void UnityEngine_GUISkin_op_Inequality()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x11CF334", Offset = "0x11CF334", VA = "0x11CF334")]
		[Preserve]
		public static void UnityEngine_HingeJoint_op_Equality()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x11CF404", Offset = "0x11CF404", VA = "0x11CF404")]
		[Preserve]
		public static void UnityEngine_HingeJoint_op_Implicit()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x11CF4CC", Offset = "0x11CF4CC", VA = "0x11CF4CC")]
		[Preserve]
		public static void UnityEngine_HingeJoint_op_Inequality()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x11CF59C", Offset = "0x11CF59C", VA = "0x11CF59C")]
		[Preserve]
		public static void UnityEngine_HingeJoint2D_op_Equality()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x11CF66C", Offset = "0x11CF66C", VA = "0x11CF66C")]
		[Preserve]
		public static void UnityEngine_HingeJoint2D_op_Implicit()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x11CF734", Offset = "0x11CF734", VA = "0x11CF734")]
		[Preserve]
		public static void UnityEngine_HingeJoint2D_op_Inequality()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x11CF804", Offset = "0x11CF804", VA = "0x11CF804")]
		[Preserve]
		public static void UnityEngine_Internal_Experimental_UIElements_PanelWrapper_op_Equality()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x11CF8D4", Offset = "0x11CF8D4", VA = "0x11CF8D4")]
		[Preserve]
		public static void UnityEngine_Internal_Experimental_UIElements_PanelWrapper_op_Implicit()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x11CF99C", Offset = "0x11CF99C", VA = "0x11CF99C")]
		[Preserve]
		public static void UnityEngine_Internal_Experimental_UIElements_PanelWrapper_op_Inequality()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x11CFA6C", Offset = "0x11CFA6C", VA = "0x11CFA6C")]
		[Preserve]
		public static void UnityEngine_Joint_op_Equality()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x11CFB3C", Offset = "0x11CFB3C", VA = "0x11CFB3C")]
		[Preserve]
		public static void UnityEngine_Joint_op_Implicit()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x11CFC04", Offset = "0x11CFC04", VA = "0x11CFC04")]
		[Preserve]
		public static void UnityEngine_Joint_op_Inequality()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x11CFCD4", Offset = "0x11CFCD4", VA = "0x11CFCD4")]
		[Preserve]
		public static void UnityEngine_Joint2D_op_Equality()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x11CFDA4", Offset = "0x11CFDA4", VA = "0x11CFDA4")]
		[Preserve]
		public static void UnityEngine_Joint2D_op_Implicit()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x11CFE6C", Offset = "0x11CFE6C", VA = "0x11CFE6C")]
		[Preserve]
		public static void UnityEngine_Joint2D_op_Inequality()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x11CFF3C", Offset = "0x11CFF3C", VA = "0x11CFF3C")]
		[Preserve]
		public static void UnityEngine_LayerMask_op_Implicit()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x11D0000", Offset = "0x11D0000", VA = "0x11D0000")]
		[Preserve]
		public static void UnityEngine_LayerMask_op_Implicit_0()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x11D00C4", Offset = "0x11D00C4", VA = "0x11D00C4")]
		[Preserve]
		public static void UnityEngine_LensFlare_op_Equality()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x11D0194", Offset = "0x11D0194", VA = "0x11D0194")]
		[Preserve]
		public static void UnityEngine_LensFlare_op_Implicit()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x11D025C", Offset = "0x11D025C", VA = "0x11D025C")]
		[Preserve]
		public static void UnityEngine_LensFlare_op_Inequality()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x11D032C", Offset = "0x11D032C", VA = "0x11D032C")]
		[Preserve]
		public static void UnityEngine_Light_op_Equality()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x11D03FC", Offset = "0x11D03FC", VA = "0x11D03FC")]
		[Preserve]
		public static void UnityEngine_Light_op_Implicit()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x11D04C4", Offset = "0x11D04C4", VA = "0x11D04C4")]
		[Preserve]
		public static void UnityEngine_Light_op_Inequality()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x11D0594", Offset = "0x11D0594", VA = "0x11D0594")]
		[Preserve]
		public static void UnityEngine_LightmapSettings_op_Equality()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x11D0664", Offset = "0x11D0664", VA = "0x11D0664")]
		[Preserve]
		public static void UnityEngine_LightmapSettings_op_Implicit()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x11D072C", Offset = "0x11D072C", VA = "0x11D072C")]
		[Preserve]
		public static void UnityEngine_LightmapSettings_op_Inequality()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x11D07FC", Offset = "0x11D07FC", VA = "0x11D07FC")]
		[Preserve]
		public static void UnityEngine_LightProbeGroup_op_Equality()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x11D08CC", Offset = "0x11D08CC", VA = "0x11D08CC")]
		[Preserve]
		public static void UnityEngine_LightProbeGroup_op_Implicit()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x11D0994", Offset = "0x11D0994", VA = "0x11D0994")]
		[Preserve]
		public static void UnityEngine_LightProbeGroup_op_Inequality()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x11D0A64", Offset = "0x11D0A64", VA = "0x11D0A64")]
		[Preserve]
		public static void UnityEngine_LightProbeProxyVolume_op_Equality()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x11D0B34", Offset = "0x11D0B34", VA = "0x11D0B34")]
		[Preserve]
		public static void UnityEngine_LightProbeProxyVolume_op_Implicit()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x11D0BFC", Offset = "0x11D0BFC", VA = "0x11D0BFC")]
		[Preserve]
		public static void UnityEngine_LightProbeProxyVolume_op_Inequality()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x11D0CCC", Offset = "0x11D0CCC", VA = "0x11D0CCC")]
		[Preserve]
		public static void UnityEngine_LightProbes_op_Equality()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x11D0D9C", Offset = "0x11D0D9C", VA = "0x11D0D9C")]
		[Preserve]
		public static void UnityEngine_LightProbes_op_Implicit()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x11D0E64", Offset = "0x11D0E64", VA = "0x11D0E64")]
		[Preserve]
		public static void UnityEngine_LightProbes_op_Inequality()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x11D0F34", Offset = "0x11D0F34", VA = "0x11D0F34")]
		[Preserve]
		public static void UnityEngine_LineRenderer_op_Equality()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x11D1004", Offset = "0x11D1004", VA = "0x11D1004")]
		[Preserve]
		public static void UnityEngine_LineRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x11D10CC", Offset = "0x11D10CC", VA = "0x11D10CC")]
		[Preserve]
		public static void UnityEngine_LineRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x11D119C", Offset = "0x11D119C", VA = "0x11D119C")]
		[Preserve]
		public static void UnityEngine_LODGroup_op_Equality()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x11D126C", Offset = "0x11D126C", VA = "0x11D126C")]
		[Preserve]
		public static void UnityEngine_LODGroup_op_Implicit()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x11D1334", Offset = "0x11D1334", VA = "0x11D1334")]
		[Preserve]
		public static void UnityEngine_LODGroup_op_Inequality()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x11D1404", Offset = "0x11D1404", VA = "0x11D1404")]
		[Preserve]
		public static void UnityEngine_Material_op_Equality()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x11D14D4", Offset = "0x11D14D4", VA = "0x11D14D4")]
		[Preserve]
		public static void UnityEngine_Material_op_Implicit()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x11D159C", Offset = "0x11D159C", VA = "0x11D159C")]
		[Preserve]
		public static void UnityEngine_Material_op_Inequality()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x11D166C", Offset = "0x11D166C", VA = "0x11D166C")]
		[Preserve]
		public static void UnityEngine_Material_SetFloat()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x11D16A0", Offset = "0x11D16A0", VA = "0x11D16A0")]
		[Preserve]
		public static void UnityEngine_Matrix4x4_op_Equality()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x11D1804", Offset = "0x11D1804", VA = "0x11D1804")]
		[Preserve]
		public static void UnityEngine_Matrix4x4_op_Inequality()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x11D1968", Offset = "0x11D1968", VA = "0x11D1968")]
		[Preserve]
		public static void UnityEngine_Matrix4x4_op_Multiply()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x11D1AD0", Offset = "0x11D1AD0", VA = "0x11D1AD0")]
		[Preserve]
		public static void UnityEngine_Matrix4x4_op_Multiply_0()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x11D1C1C", Offset = "0x11D1C1C", VA = "0x11D1C1C")]
		[Preserve]
		public static void UnityEngine_Mesh_op_Equality()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x11D1CEC", Offset = "0x11D1CEC", VA = "0x11D1CEC")]
		[Preserve]
		public static void UnityEngine_Mesh_op_Implicit()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x11D1DB4", Offset = "0x11D1DB4", VA = "0x11D1DB4")]
		[Preserve]
		public static void UnityEngine_Mesh_op_Inequality()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x11D1E84", Offset = "0x11D1E84", VA = "0x11D1E84")]
		[Preserve]
		public static void UnityEngine_MeshCollider_op_Equality()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x11D1F54", Offset = "0x11D1F54", VA = "0x11D1F54")]
		[Preserve]
		public static void UnityEngine_MeshCollider_op_Implicit()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x11D201C", Offset = "0x11D201C", VA = "0x11D201C")]
		[Preserve]
		public static void UnityEngine_MeshCollider_op_Inequality()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x11D20EC", Offset = "0x11D20EC", VA = "0x11D20EC")]
		[Preserve]
		public static void UnityEngine_MeshFilter_op_Equality()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x11D21BC", Offset = "0x11D21BC", VA = "0x11D21BC")]
		[Preserve]
		public static void UnityEngine_MeshFilter_op_Implicit()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x11D2284", Offset = "0x11D2284", VA = "0x11D2284")]
		[Preserve]
		public static void UnityEngine_MeshFilter_op_Inequality()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x11D2354", Offset = "0x11D2354", VA = "0x11D2354")]
		[Preserve]
		public static void UnityEngine_MeshRenderer_material()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x11D2388", Offset = "0x11D2388", VA = "0x11D2388")]
		[Preserve]
		public static void UnityEngine_MeshRenderer_op_Equality()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x11D2458", Offset = "0x11D2458", VA = "0x11D2458")]
		[Preserve]
		public static void UnityEngine_MeshRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x11D2520", Offset = "0x11D2520", VA = "0x11D2520")]
		[Preserve]
		public static void UnityEngine_MeshRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x11D25F0", Offset = "0x11D25F0", VA = "0x11D25F0")]
		[Preserve]
		public static void UnityEngine_MonoBehaviour_gameObject()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x11D2624", Offset = "0x11D2624", VA = "0x11D2624")]
		[Preserve]
		public static void UnityEngine_MonoBehaviour_op_Equality()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x11D26F4", Offset = "0x11D26F4", VA = "0x11D26F4")]
		[Preserve]
		public static void UnityEngine_MonoBehaviour_op_Implicit()
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x11D27BC", Offset = "0x11D27BC", VA = "0x11D27BC")]
		[Preserve]
		public static void UnityEngine_MonoBehaviour_op_Inequality()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x11D288C", Offset = "0x11D288C", VA = "0x11D288C")]
		[Preserve]
		public static void UnityEngine_Motion_op_Equality()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x11D295C", Offset = "0x11D295C", VA = "0x11D295C")]
		[Preserve]
		public static void UnityEngine_Motion_op_Implicit()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x11D2A24", Offset = "0x11D2A24", VA = "0x11D2A24")]
		[Preserve]
		public static void UnityEngine_Motion_op_Inequality()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x11D2AF4", Offset = "0x11D2AF4", VA = "0x11D2AF4")]
		[Preserve]
		public static void UnityEngine_Networking_PlayerConnection_PlayerConnection_op_Equality()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x11D2BC4", Offset = "0x11D2BC4", VA = "0x11D2BC4")]
		[Preserve]
		public static void UnityEngine_Networking_PlayerConnection_PlayerConnection_op_Implicit()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x11D2C8C", Offset = "0x11D2C8C", VA = "0x11D2C8C")]
		[Preserve]
		public static void UnityEngine_Networking_PlayerConnection_PlayerConnection_op_Inequality()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x11D2D5C", Offset = "0x11D2D5C", VA = "0x11D2D5C")]
		[Preserve]
		public static void UnityEngine_Object_op_Equality()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x11D2E2C", Offset = "0x11D2E2C", VA = "0x11D2E2C")]
		[Preserve]
		public static void UnityEngine_Object_op_Implicit()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x11D2EF4", Offset = "0x11D2EF4", VA = "0x11D2EF4")]
		[Preserve]
		public static void UnityEngine_Object_op_Inequality()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x11D2FC4", Offset = "0x11D2FC4", VA = "0x11D2FC4")]
		[Preserve]
		public static void UnityEngine_OcclusionArea_op_Equality()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x11D3094", Offset = "0x11D3094", VA = "0x11D3094")]
		[Preserve]
		public static void UnityEngine_OcclusionArea_op_Implicit()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x11D315C", Offset = "0x11D315C", VA = "0x11D315C")]
		[Preserve]
		public static void UnityEngine_OcclusionArea_op_Inequality()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x11D322C", Offset = "0x11D322C", VA = "0x11D322C")]
		[Preserve]
		public static void UnityEngine_OcclusionPortal_op_Equality()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x11D32FC", Offset = "0x11D32FC", VA = "0x11D32FC")]
		[Preserve]
		public static void UnityEngine_OcclusionPortal_op_Implicit()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x11D33C4", Offset = "0x11D33C4", VA = "0x11D33C4")]
		[Preserve]
		public static void UnityEngine_OcclusionPortal_op_Inequality()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x11D3494", Offset = "0x11D3494", VA = "0x11D3494")]
		[Preserve]
		public static void UnityEngine_ParticleSystem_Clear()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x11D34C8", Offset = "0x11D34C8", VA = "0x11D34C8")]
		[Preserve]
		public static void UnityEngine_ParticleSystem_Clear_0()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x11D34FC", Offset = "0x11D34FC", VA = "0x11D34FC")]
		[Preserve]
		public static void UnityEngine_ParticleSystem_op_Equality()
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x11D35CC", Offset = "0x11D35CC", VA = "0x11D35CC")]
		[Preserve]
		public static void UnityEngine_ParticleSystem_op_Implicit()
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x11D3694", Offset = "0x11D3694", VA = "0x11D3694")]
		[Preserve]
		public static void UnityEngine_ParticleSystem_op_Inequality()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x11D3764", Offset = "0x11D3764", VA = "0x11D3764")]
		[Preserve]
		public static void UnityEngine_ParticleSystem_Play()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x11D3798", Offset = "0x11D3798", VA = "0x11D3798")]
		[Preserve]
		public static void UnityEngine_ParticleSystem_Stop()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x11D37CC", Offset = "0x11D37CC", VA = "0x11D37CC")]
		[Preserve]
		public static void UnityEngine_ParticleSystemForceField_op_Equality()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x11D389C", Offset = "0x11D389C", VA = "0x11D389C")]
		[Preserve]
		public static void UnityEngine_ParticleSystemForceField_op_Implicit()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x11D3964", Offset = "0x11D3964", VA = "0x11D3964")]
		[Preserve]
		public static void UnityEngine_ParticleSystemForceField_op_Inequality()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x11D3A34", Offset = "0x11D3A34", VA = "0x11D3A34")]
		[Preserve]
		public static void UnityEngine_ParticleSystemRenderer_op_Equality()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x11D3B04", Offset = "0x11D3B04", VA = "0x11D3B04")]
		[Preserve]
		public static void UnityEngine_ParticleSystemRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x11D3BCC", Offset = "0x11D3BCC", VA = "0x11D3BCC")]
		[Preserve]
		public static void UnityEngine_ParticleSystemRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x11D3C9C", Offset = "0x11D3C9C", VA = "0x11D3C9C")]
		[Preserve]
		public static void UnityEngine_PhysicMaterial_op_Equality()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x11D3D6C", Offset = "0x11D3D6C", VA = "0x11D3D6C")]
		[Preserve]
		public static void UnityEngine_PhysicMaterial_op_Implicit()
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x11D3E34", Offset = "0x11D3E34", VA = "0x11D3E34")]
		[Preserve]
		public static void UnityEngine_PhysicMaterial_op_Inequality()
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x11D3F04", Offset = "0x11D3F04", VA = "0x11D3F04")]
		[Preserve]
		public static void UnityEngine_PhysicsMaterial2D_op_Equality()
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x11D3FD4", Offset = "0x11D3FD4", VA = "0x11D3FD4")]
		[Preserve]
		public static void UnityEngine_PhysicsMaterial2D_op_Implicit()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x11D409C", Offset = "0x11D409C", VA = "0x11D409C")]
		[Preserve]
		public static void UnityEngine_PhysicsMaterial2D_op_Inequality()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x11D416C", Offset = "0x11D416C", VA = "0x11D416C")]
		[Preserve]
		public static void UnityEngine_PhysicsUpdateBehaviour2D_op_Equality()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x11D423C", Offset = "0x11D423C", VA = "0x11D423C")]
		[Preserve]
		public static void UnityEngine_PhysicsUpdateBehaviour2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x11D4304", Offset = "0x11D4304", VA = "0x11D4304")]
		[Preserve]
		public static void UnityEngine_PhysicsUpdateBehaviour2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x11D43D4", Offset = "0x11D43D4", VA = "0x11D43D4")]
		[Preserve]
		public static void UnityEngine_PlatformEffector2D_op_Equality()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x11D44A4", Offset = "0x11D44A4", VA = "0x11D44A4")]
		[Preserve]
		public static void UnityEngine_PlatformEffector2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x11D456C", Offset = "0x11D456C", VA = "0x11D456C")]
		[Preserve]
		public static void UnityEngine_PlatformEffector2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x11D463C", Offset = "0x11D463C", VA = "0x11D463C")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableAsset_op_Equality()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x11D470C", Offset = "0x11D470C", VA = "0x11D470C")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableAsset_op_Implicit()
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x11D47D4", Offset = "0x11D47D4", VA = "0x11D47D4")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableAsset_op_Inequality()
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x11D48A4", Offset = "0x11D48A4", VA = "0x11D48A4")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableDirector_duration()
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x11D48D8", Offset = "0x11D48D8", VA = "0x11D48D8")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableDirector_enabled()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x11D490C", Offset = "0x11D490C", VA = "0x11D490C")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableDirector_op_Equality()
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x11D49DC", Offset = "0x11D49DC", VA = "0x11D49DC")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableDirector_op_Implicit()
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x11D4AA4", Offset = "0x11D4AA4", VA = "0x11D4AA4")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableDirector_op_Inequality()
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x11D4B74", Offset = "0x11D4B74", VA = "0x11D4B74")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableDirector_Play()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x11D4BA8", Offset = "0x11D4BA8", VA = "0x11D4BA8")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableDirector_state()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x11D4BDC", Offset = "0x11D4BDC", VA = "0x11D4BDC")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableDirector_Stop()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x11D4C10", Offset = "0x11D4C10", VA = "0x11D4C10")]
		[Preserve]
		public static void UnityEngine_Playables_PlayableDirector_time()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x11D4C44", Offset = "0x11D4C44", VA = "0x11D4C44")]
		[Preserve]
		public static void UnityEngine_PointEffector2D_op_Equality()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x11D4D14", Offset = "0x11D4D14", VA = "0x11D4D14")]
		[Preserve]
		public static void UnityEngine_PointEffector2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x11D4DDC", Offset = "0x11D4DDC", VA = "0x11D4DDC")]
		[Preserve]
		public static void UnityEngine_PointEffector2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x11D4EAC", Offset = "0x11D4EAC", VA = "0x11D4EAC")]
		[Preserve]
		public static void UnityEngine_PolygonCollider2D_op_Equality()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x11D4F7C", Offset = "0x11D4F7C", VA = "0x11D4F7C")]
		[Preserve]
		public static void UnityEngine_PolygonCollider2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x11D5044", Offset = "0x11D5044", VA = "0x11D5044")]
		[Preserve]
		public static void UnityEngine_PolygonCollider2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x11D5114", Offset = "0x11D5114", VA = "0x11D5114")]
		[Preserve]
		public static void UnityEngine_Projector_op_Equality()
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x11D51E4", Offset = "0x11D51E4", VA = "0x11D51E4")]
		[Preserve]
		public static void UnityEngine_Projector_op_Implicit()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x11D52AC", Offset = "0x11D52AC", VA = "0x11D52AC")]
		[Preserve]
		public static void UnityEngine_Projector_op_Inequality()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x11D537C", Offset = "0x11D537C", VA = "0x11D537C")]
		[Preserve]
		public static void UnityEngine_QualitySettings_op_Equality()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x11D544C", Offset = "0x11D544C", VA = "0x11D544C")]
		[Preserve]
		public static void UnityEngine_QualitySettings_op_Implicit()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x11D5514", Offset = "0x11D5514", VA = "0x11D5514")]
		[Preserve]
		public static void UnityEngine_QualitySettings_op_Inequality()
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x11D55E4", Offset = "0x11D55E4", VA = "0x11D55E4")]
		[Preserve]
		public static void UnityEngine_Quaternion_op_Equality()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x11D5704", Offset = "0x11D5704", VA = "0x11D5704")]
		[Preserve]
		public static void UnityEngine_Quaternion_op_Inequality()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x11D5824", Offset = "0x11D5824", VA = "0x11D5824")]
		[Preserve]
		public static void UnityEngine_Quaternion_op_Multiply()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x11D5944", Offset = "0x11D5944", VA = "0x11D5944")]
		[Preserve]
		public static void UnityEngine_Quaternion_op_Multiply_0()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x11D5A64", Offset = "0x11D5A64", VA = "0x11D5A64")]
		[Preserve]
		public static void UnityEngine_RaycastHit2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x11D5B48", Offset = "0x11D5B48", VA = "0x11D5B48")]
		[Preserve]
		public static void UnityEngine_Rect_op_Equality()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x11D5C50", Offset = "0x11D5C50", VA = "0x11D5C50")]
		[Preserve]
		public static void UnityEngine_Rect_op_Inequality()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x11D5D58", Offset = "0x11D5D58", VA = "0x11D5D58")]
		[Preserve]
		public static void UnityEngine_RectTransform_op_Equality()
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x11D5E28", Offset = "0x11D5E28", VA = "0x11D5E28")]
		[Preserve]
		public static void UnityEngine_RectTransform_op_Implicit()
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x11D5EF0", Offset = "0x11D5EF0", VA = "0x11D5EF0")]
		[Preserve]
		public static void UnityEngine_RectTransform_op_Inequality()
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x11D5FC0", Offset = "0x11D5FC0", VA = "0x11D5FC0")]
		[Preserve]
		public static void UnityEngine_ReflectionProbe_op_Equality()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x11D6090", Offset = "0x11D6090", VA = "0x11D6090")]
		[Preserve]
		public static void UnityEngine_ReflectionProbe_op_Implicit()
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x11D6158", Offset = "0x11D6158", VA = "0x11D6158")]
		[Preserve]
		public static void UnityEngine_ReflectionProbe_op_Inequality()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x11D6228", Offset = "0x11D6228", VA = "0x11D6228")]
		[Preserve]
		public static void UnityEngine_RelativeJoint2D_op_Equality()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x11D62F8", Offset = "0x11D62F8", VA = "0x11D62F8")]
		[Preserve]
		public static void UnityEngine_RelativeJoint2D_op_Implicit()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x11D63C0", Offset = "0x11D63C0", VA = "0x11D63C0")]
		[Preserve]
		public static void UnityEngine_RelativeJoint2D_op_Inequality()
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x11D6490", Offset = "0x11D6490", VA = "0x11D6490")]
		[Preserve]
		public static void UnityEngine_Renderer_material()
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x11D64C4", Offset = "0x11D64C4", VA = "0x11D64C4")]
		[Preserve]
		public static void UnityEngine_Renderer_op_Equality()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x11D6594", Offset = "0x11D6594", VA = "0x11D6594")]
		[Preserve]
		public static void UnityEngine_Renderer_op_Implicit()
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x11D665C", Offset = "0x11D665C", VA = "0x11D665C")]
		[Preserve]
		public static void UnityEngine_Renderer_op_Inequality()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x11D672C", Offset = "0x11D672C", VA = "0x11D672C")]
		[Preserve]
		public static void UnityEngine_Rendering_GraphicsSettings_op_Equality()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x11D67FC", Offset = "0x11D67FC", VA = "0x11D67FC")]
		[Preserve]
		public static void UnityEngine_Rendering_GraphicsSettings_op_Implicit()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x11D68C4", Offset = "0x11D68C4", VA = "0x11D68C4")]
		[Preserve]
		public static void UnityEngine_Rendering_GraphicsSettings_op_Inequality()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x11D6994", Offset = "0x11D6994", VA = "0x11D6994")]
		[Preserve]
		public static void UnityEngine_Rendering_SortingGroup_op_Equality()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x11D6A64", Offset = "0x11D6A64", VA = "0x11D6A64")]
		[Preserve]
		public static void UnityEngine_Rendering_SortingGroup_op_Implicit()
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x11D6B2C", Offset = "0x11D6B2C", VA = "0x11D6B2C")]
		[Preserve]
		public static void UnityEngine_Rendering_SortingGroup_op_Inequality()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x11D6BFC", Offset = "0x11D6BFC", VA = "0x11D6BFC")]
		[Preserve]
		public static void UnityEngine_RenderSettings_op_Equality()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x11D6CCC", Offset = "0x11D6CCC", VA = "0x11D6CCC")]
		[Preserve]
		public static void UnityEngine_RenderSettings_op_Implicit()
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x11D6D94", Offset = "0x11D6D94", VA = "0x11D6D94")]
		[Preserve]
		public static void UnityEngine_RenderSettings_op_Inequality()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x11D6E64", Offset = "0x11D6E64", VA = "0x11D6E64")]
		[Preserve]
		public static void UnityEngine_RenderTexture_op_Equality()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x11D6F34", Offset = "0x11D6F34", VA = "0x11D6F34")]
		[Preserve]
		public static void UnityEngine_RenderTexture_op_Implicit()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x11D6FFC", Offset = "0x11D6FFC", VA = "0x11D6FFC")]
		[Preserve]
		public static void UnityEngine_RenderTexture_op_Inequality()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x11D70CC", Offset = "0x11D70CC", VA = "0x11D70CC")]
		[Preserve]
		public static void UnityEngine_Rigidbody_op_Equality()
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x11D719C", Offset = "0x11D719C", VA = "0x11D719C")]
		[Preserve]
		public static void UnityEngine_Rigidbody_op_Implicit()
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x11D7264", Offset = "0x11D7264", VA = "0x11D7264")]
		[Preserve]
		public static void UnityEngine_Rigidbody_op_Inequality()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x11D7334", Offset = "0x11D7334", VA = "0x11D7334")]
		[Preserve]
		public static void UnityEngine_Rigidbody2D_op_Equality()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x11D7404", Offset = "0x11D7404", VA = "0x11D7404")]
		[Preserve]
		public static void UnityEngine_Rigidbody2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x11D74CC", Offset = "0x11D74CC", VA = "0x11D74CC")]
		[Preserve]
		public static void UnityEngine_Rigidbody2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x11D759C", Offset = "0x11D759C", VA = "0x11D759C")]
		[Preserve]
		public static void UnityEngine_RuntimeAnimatorController_op_Equality()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x11D766C", Offset = "0x11D766C", VA = "0x11D766C")]
		[Preserve]
		public static void UnityEngine_RuntimeAnimatorController_op_Implicit()
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x11D7734", Offset = "0x11D7734", VA = "0x11D7734")]
		[Preserve]
		public static void UnityEngine_RuntimeAnimatorController_op_Inequality()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x11D7804", Offset = "0x11D7804", VA = "0x11D7804")]
		[Preserve]
		public static void UnityEngine_SceneManagement_Scene_op_Equality()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x11D78F4", Offset = "0x11D78F4", VA = "0x11D78F4")]
		[Preserve]
		public static void UnityEngine_SceneManagement_Scene_op_Inequality()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x11D79E4", Offset = "0x11D79E4", VA = "0x11D79E4")]
		[Preserve]
		public static void UnityEngine_ScriptableObject_op_Equality()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x11D7AB4", Offset = "0x11D7AB4", VA = "0x11D7AB4")]
		[Preserve]
		public static void UnityEngine_ScriptableObject_op_Implicit()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x11D7B7C", Offset = "0x11D7B7C", VA = "0x11D7B7C")]
		[Preserve]
		public static void UnityEngine_ScriptableObject_op_Inequality()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x11D7C4C", Offset = "0x11D7C4C", VA = "0x11D7C4C")]
		[Preserve]
		public static void UnityEngine_Shader_op_Equality()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x11D7D1C", Offset = "0x11D7D1C", VA = "0x11D7D1C")]
		[Preserve]
		public static void UnityEngine_Shader_op_Implicit()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x11D7DE4", Offset = "0x11D7DE4", VA = "0x11D7DE4")]
		[Preserve]
		public static void UnityEngine_Shader_op_Inequality()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x11D7EB4", Offset = "0x11D7EB4", VA = "0x11D7EB4")]
		[Preserve]
		public static void UnityEngine_ShaderVariantCollection_op_Equality()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x11D7F84", Offset = "0x11D7F84", VA = "0x11D7F84")]
		[Preserve]
		public static void UnityEngine_ShaderVariantCollection_op_Implicit()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x11D804C", Offset = "0x11D804C", VA = "0x11D804C")]
		[Preserve]
		public static void UnityEngine_ShaderVariantCollection_op_Inequality()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x11D811C", Offset = "0x11D811C", VA = "0x11D811C")]
		[Preserve]
		public static void UnityEngine_SkinnedMeshRenderer_op_Equality()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x11D81EC", Offset = "0x11D81EC", VA = "0x11D81EC")]
		[Preserve]
		public static void UnityEngine_SkinnedMeshRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x11D82B4", Offset = "0x11D82B4", VA = "0x11D82B4")]
		[Preserve]
		public static void UnityEngine_SkinnedMeshRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x11D8384", Offset = "0x11D8384", VA = "0x11D8384")]
		[Preserve]
		public static void UnityEngine_Skybox_op_Equality()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x11D8454", Offset = "0x11D8454", VA = "0x11D8454")]
		[Preserve]
		public static void UnityEngine_Skybox_op_Implicit()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x11D851C", Offset = "0x11D851C", VA = "0x11D851C")]
		[Preserve]
		public static void UnityEngine_Skybox_op_Inequality()
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x11D85EC", Offset = "0x11D85EC", VA = "0x11D85EC")]
		[Preserve]
		public static void UnityEngine_SliderJoint2D_op_Equality()
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x11D86BC", Offset = "0x11D86BC", VA = "0x11D86BC")]
		[Preserve]
		public static void UnityEngine_SliderJoint2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x11D8784", Offset = "0x11D8784", VA = "0x11D8784")]
		[Preserve]
		public static void UnityEngine_SliderJoint2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x11D8854", Offset = "0x11D8854", VA = "0x11D8854")]
		[Preserve]
		public static void UnityEngine_SparseTexture_op_Equality()
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x11D8924", Offset = "0x11D8924", VA = "0x11D8924")]
		[Preserve]
		public static void UnityEngine_SparseTexture_op_Implicit()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x11D89EC", Offset = "0x11D89EC", VA = "0x11D89EC")]
		[Preserve]
		public static void UnityEngine_SparseTexture_op_Inequality()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x11D8ABC", Offset = "0x11D8ABC", VA = "0x11D8ABC")]
		[Preserve]
		public static void UnityEngine_SpatialTracking_TrackedPoseDriver_op_Equality()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x11D8B8C", Offset = "0x11D8B8C", VA = "0x11D8B8C")]
		[Preserve]
		public static void UnityEngine_SpatialTracking_TrackedPoseDriver_op_Implicit()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x11D8C54", Offset = "0x11D8C54", VA = "0x11D8C54")]
		[Preserve]
		public static void UnityEngine_SpatialTracking_TrackedPoseDriver_op_Inequality()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x11D8D24", Offset = "0x11D8D24", VA = "0x11D8D24")]
		[Preserve]
		public static void UnityEngine_SphereCollider_op_Equality()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x11D8DF4", Offset = "0x11D8DF4", VA = "0x11D8DF4")]
		[Preserve]
		public static void UnityEngine_SphereCollider_op_Implicit()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x11D8EBC", Offset = "0x11D8EBC", VA = "0x11D8EBC")]
		[Preserve]
		public static void UnityEngine_SphereCollider_op_Inequality()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x11D8F8C", Offset = "0x11D8F8C", VA = "0x11D8F8C")]
		[Preserve]
		public static void UnityEngine_SpringJoint_op_Equality()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x11D905C", Offset = "0x11D905C", VA = "0x11D905C")]
		[Preserve]
		public static void UnityEngine_SpringJoint_op_Implicit()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x11D9124", Offset = "0x11D9124", VA = "0x11D9124")]
		[Preserve]
		public static void UnityEngine_SpringJoint_op_Inequality()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x11D91F4", Offset = "0x11D91F4", VA = "0x11D91F4")]
		[Preserve]
		public static void UnityEngine_SpringJoint2D_op_Equality()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x11D92C4", Offset = "0x11D92C4", VA = "0x11D92C4")]
		[Preserve]
		public static void UnityEngine_SpringJoint2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x11D938C", Offset = "0x11D938C", VA = "0x11D938C")]
		[Preserve]
		public static void UnityEngine_SpringJoint2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x11D945C", Offset = "0x11D945C", VA = "0x11D945C")]
		[Preserve]
		public static void UnityEngine_Sprite_op_Equality()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x11D952C", Offset = "0x11D952C", VA = "0x11D952C")]
		[Preserve]
		public static void UnityEngine_Sprite_op_Implicit()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x11D95F4", Offset = "0x11D95F4", VA = "0x11D95F4")]
		[Preserve]
		public static void UnityEngine_Sprite_op_Inequality()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x11D96C4", Offset = "0x11D96C4", VA = "0x11D96C4")]
		[Preserve]
		public static void UnityEngine_SpriteMask_op_Equality()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x11D9794", Offset = "0x11D9794", VA = "0x11D9794")]
		[Preserve]
		public static void UnityEngine_SpriteMask_op_Implicit()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x11D985C", Offset = "0x11D985C", VA = "0x11D985C")]
		[Preserve]
		public static void UnityEngine_SpriteMask_op_Inequality()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x11D992C", Offset = "0x11D992C", VA = "0x11D992C")]
		[Preserve]
		public static void UnityEngine_SpriteRenderer_op_Equality()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x11D99FC", Offset = "0x11D99FC", VA = "0x11D99FC")]
		[Preserve]
		public static void UnityEngine_SpriteRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x11D9AC4", Offset = "0x11D9AC4", VA = "0x11D9AC4")]
		[Preserve]
		public static void UnityEngine_SpriteRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x11D9B94", Offset = "0x11D9B94", VA = "0x11D9B94")]
		[Preserve]
		public static void UnityEngine_StateMachineBehaviour_op_Equality()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x11D9C64", Offset = "0x11D9C64", VA = "0x11D9C64")]
		[Preserve]
		public static void UnityEngine_StateMachineBehaviour_op_Implicit()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x11D9D2C", Offset = "0x11D9D2C", VA = "0x11D9D2C")]
		[Preserve]
		public static void UnityEngine_StateMachineBehaviour_op_Inequality()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x11D9DFC", Offset = "0x11D9DFC", VA = "0x11D9DFC")]
		[Preserve]
		public static void UnityEngine_SurfaceEffector2D_op_Equality()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x11D9ECC", Offset = "0x11D9ECC", VA = "0x11D9ECC")]
		[Preserve]
		public static void UnityEngine_SurfaceEffector2D_op_Implicit()
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x11D9F94", Offset = "0x11D9F94", VA = "0x11D9F94")]
		[Preserve]
		public static void UnityEngine_SurfaceEffector2D_op_Inequality()
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x11DA064", Offset = "0x11DA064", VA = "0x11DA064")]
		[Preserve]
		public static void UnityEngine_TargetJoint2D_op_Equality()
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x11DA134", Offset = "0x11DA134", VA = "0x11DA134")]
		[Preserve]
		public static void UnityEngine_TargetJoint2D_op_Implicit()
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x11DA1FC", Offset = "0x11DA1FC", VA = "0x11DA1FC")]
		[Preserve]
		public static void UnityEngine_TargetJoint2D_op_Inequality()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x11DA2CC", Offset = "0x11DA2CC", VA = "0x11DA2CC")]
		[Preserve]
		public static void UnityEngine_Terrain_op_Equality()
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x11DA39C", Offset = "0x11DA39C", VA = "0x11DA39C")]
		[Preserve]
		public static void UnityEngine_Terrain_op_Implicit()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x11DA464", Offset = "0x11DA464", VA = "0x11DA464")]
		[Preserve]
		public static void UnityEngine_Terrain_op_Inequality()
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x11DA534", Offset = "0x11DA534", VA = "0x11DA534")]
		[Preserve]
		public static void UnityEngine_TerrainCollider_op_Equality()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x11DA604", Offset = "0x11DA604", VA = "0x11DA604")]
		[Preserve]
		public static void UnityEngine_TerrainCollider_op_Implicit()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x11DA6CC", Offset = "0x11DA6CC", VA = "0x11DA6CC")]
		[Preserve]
		public static void UnityEngine_TerrainCollider_op_Inequality()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x11DA79C", Offset = "0x11DA79C", VA = "0x11DA79C")]
		[Preserve]
		public static void UnityEngine_TerrainData_op_Equality()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x11DA86C", Offset = "0x11DA86C", VA = "0x11DA86C")]
		[Preserve]
		public static void UnityEngine_TerrainData_op_Implicit()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x11DA934", Offset = "0x11DA934", VA = "0x11DA934")]
		[Preserve]
		public static void UnityEngine_TerrainData_op_Inequality()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x11DAA04", Offset = "0x11DAA04", VA = "0x11DAA04")]
		[Preserve]
		public static void UnityEngine_TerrainLayer_op_Equality()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x11DAAD4", Offset = "0x11DAAD4", VA = "0x11DAAD4")]
		[Preserve]
		public static void UnityEngine_TerrainLayer_op_Implicit()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x11DAB9C", Offset = "0x11DAB9C", VA = "0x11DAB9C")]
		[Preserve]
		public static void UnityEngine_TerrainLayer_op_Inequality()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x11DAC6C", Offset = "0x11DAC6C", VA = "0x11DAC6C")]
		[Preserve]
		public static void UnityEngine_TextAsset_op_Equality()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x11DAD3C", Offset = "0x11DAD3C", VA = "0x11DAD3C")]
		[Preserve]
		public static void UnityEngine_TextAsset_op_Implicit()
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x11DAE04", Offset = "0x11DAE04", VA = "0x11DAE04")]
		[Preserve]
		public static void UnityEngine_TextAsset_op_Inequality()
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x11DAED4", Offset = "0x11DAED4", VA = "0x11DAED4")]
		[Preserve]
		public static void UnityEngine_TextMesh_op_Equality()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x11DAFA4", Offset = "0x11DAFA4", VA = "0x11DAFA4")]
		[Preserve]
		public static void UnityEngine_TextMesh_op_Implicit()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x11DB06C", Offset = "0x11DB06C", VA = "0x11DB06C")]
		[Preserve]
		public static void UnityEngine_TextMesh_op_Inequality()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x11DB13C", Offset = "0x11DB13C", VA = "0x11DB13C")]
		[Preserve]
		public static void UnityEngine_Texture_op_Equality()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x11DB20C", Offset = "0x11DB20C", VA = "0x11DB20C")]
		[Preserve]
		public static void UnityEngine_Texture_op_Implicit()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x11DB2D4", Offset = "0x11DB2D4", VA = "0x11DB2D4")]
		[Preserve]
		public static void UnityEngine_Texture_op_Inequality()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x11DB3A4", Offset = "0x11DB3A4", VA = "0x11DB3A4")]
		[Preserve]
		public static void UnityEngine_Texture2D_op_Equality()
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x11DB474", Offset = "0x11DB474", VA = "0x11DB474")]
		[Preserve]
		public static void UnityEngine_Texture2D_op_Implicit()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x11DB53C", Offset = "0x11DB53C", VA = "0x11DB53C")]
		[Preserve]
		public static void UnityEngine_Texture2D_op_Inequality()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x11DB60C", Offset = "0x11DB60C", VA = "0x11DB60C")]
		[Preserve]
		public static void UnityEngine_Texture2DArray_op_Equality()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x11DB6DC", Offset = "0x11DB6DC", VA = "0x11DB6DC")]
		[Preserve]
		public static void UnityEngine_Texture2DArray_op_Implicit()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x11DB7A4", Offset = "0x11DB7A4", VA = "0x11DB7A4")]
		[Preserve]
		public static void UnityEngine_Texture2DArray_op_Inequality()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x11DB874", Offset = "0x11DB874", VA = "0x11DB874")]
		[Preserve]
		public static void UnityEngine_Texture3D_op_Equality()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x11DB944", Offset = "0x11DB944", VA = "0x11DB944")]
		[Preserve]
		public static void UnityEngine_Texture3D_op_Implicit()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x11DBA0C", Offset = "0x11DBA0C", VA = "0x11DBA0C")]
		[Preserve]
		public static void UnityEngine_Texture3D_op_Inequality()
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x11DBADC", Offset = "0x11DBADC", VA = "0x11DBADC")]
		[Preserve]
		public static void UnityEngine_Tilemaps_Tile_op_Equality()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x11DBBAC", Offset = "0x11DBBAC", VA = "0x11DBBAC")]
		[Preserve]
		public static void UnityEngine_Tilemaps_Tile_op_Implicit()
		{
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x11DBC74", Offset = "0x11DBC74", VA = "0x11DBC74")]
		[Preserve]
		public static void UnityEngine_Tilemaps_Tile_op_Inequality()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x11DBD44", Offset = "0x11DBD44", VA = "0x11DBD44")]
		[Preserve]
		public static void UnityEngine_Tilemaps_TileBase_op_Equality()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x11DBE14", Offset = "0x11DBE14", VA = "0x11DBE14")]
		[Preserve]
		public static void UnityEngine_Tilemaps_TileBase_op_Implicit()
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x11DBEDC", Offset = "0x11DBEDC", VA = "0x11DBEDC")]
		[Preserve]
		public static void UnityEngine_Tilemaps_TileBase_op_Inequality()
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x11DBFAC", Offset = "0x11DBFAC", VA = "0x11DBFAC")]
		[Preserve]
		public static void UnityEngine_Tilemaps_Tilemap_op_Equality()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x11DC07C", Offset = "0x11DC07C", VA = "0x11DC07C")]
		[Preserve]
		public static void UnityEngine_Tilemaps_Tilemap_op_Implicit()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x11DC144", Offset = "0x11DC144", VA = "0x11DC144")]
		[Preserve]
		public static void UnityEngine_Tilemaps_Tilemap_op_Inequality()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x11DC214", Offset = "0x11DC214", VA = "0x11DC214")]
		[Preserve]
		public static void UnityEngine_Tilemaps_TilemapCollider2D_op_Equality()
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x11DC2E4", Offset = "0x11DC2E4", VA = "0x11DC2E4")]
		[Preserve]
		public static void UnityEngine_Tilemaps_TilemapCollider2D_op_Implicit()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x11DC3AC", Offset = "0x11DC3AC", VA = "0x11DC3AC")]
		[Preserve]
		public static void UnityEngine_Tilemaps_TilemapCollider2D_op_Inequality()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x11DC47C", Offset = "0x11DC47C", VA = "0x11DC47C")]
		[Preserve]
		public static void UnityEngine_Tilemaps_TilemapRenderer_op_Equality()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x11DC54C", Offset = "0x11DC54C", VA = "0x11DC54C")]
		[Preserve]
		public static void UnityEngine_Tilemaps_TilemapRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x11DC614", Offset = "0x11DC614", VA = "0x11DC614")]
		[Preserve]
		public static void UnityEngine_Tilemaps_TilemapRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x11DC6E4", Offset = "0x11DC6E4", VA = "0x11DC6E4")]
		[Preserve]
		public static void UnityEngine_Timeline_ActivationTrack_op_Equality()
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x11DC7B4", Offset = "0x11DC7B4", VA = "0x11DC7B4")]
		[Preserve]
		public static void UnityEngine_Timeline_ActivationTrack_op_Implicit()
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x11DC87C", Offset = "0x11DC87C", VA = "0x11DC87C")]
		[Preserve]
		public static void UnityEngine_Timeline_ActivationTrack_op_Inequality()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x11DC94C", Offset = "0x11DC94C", VA = "0x11DC94C")]
		[Preserve]
		public static void UnityEngine_Timeline_AnimationPlayableAsset_op_Equality()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x11DCA1C", Offset = "0x11DCA1C", VA = "0x11DCA1C")]
		[Preserve]
		public static void UnityEngine_Timeline_AnimationPlayableAsset_op_Implicit()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x11DCAE4", Offset = "0x11DCAE4", VA = "0x11DCAE4")]
		[Preserve]
		public static void UnityEngine_Timeline_AnimationPlayableAsset_op_Inequality()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x11DCBB4", Offset = "0x11DCBB4", VA = "0x11DCBB4")]
		[Preserve]
		public static void UnityEngine_Timeline_AnimationTrack_op_Equality()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x11DCC84", Offset = "0x11DCC84", VA = "0x11DCC84")]
		[Preserve]
		public static void UnityEngine_Timeline_AnimationTrack_op_Implicit()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x11DCD4C", Offset = "0x11DCD4C", VA = "0x11DCD4C")]
		[Preserve]
		public static void UnityEngine_Timeline_AnimationTrack_op_Inequality()
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x11DCE1C", Offset = "0x11DCE1C", VA = "0x11DCE1C")]
		[Preserve]
		public static void UnityEngine_Timeline_AudioPlayableAsset_op_Equality()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x11DCEEC", Offset = "0x11DCEEC", VA = "0x11DCEEC")]
		[Preserve]
		public static void UnityEngine_Timeline_AudioPlayableAsset_op_Implicit()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x11DCFB4", Offset = "0x11DCFB4", VA = "0x11DCFB4")]
		[Preserve]
		public static void UnityEngine_Timeline_AudioPlayableAsset_op_Inequality()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x11DD084", Offset = "0x11DD084", VA = "0x11DD084")]
		[Preserve]
		public static void UnityEngine_Timeline_AudioTrack_op_Equality()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x11DD154", Offset = "0x11DD154", VA = "0x11DD154")]
		[Preserve]
		public static void UnityEngine_Timeline_AudioTrack_op_Implicit()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x11DD21C", Offset = "0x11DD21C", VA = "0x11DD21C")]
		[Preserve]
		public static void UnityEngine_Timeline_AudioTrack_op_Inequality()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x11DD2EC", Offset = "0x11DD2EC", VA = "0x11DD2EC")]
		[Preserve]
		public static void UnityEngine_Timeline_ControlPlayableAsset_op_Equality()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x11DD3BC", Offset = "0x11DD3BC", VA = "0x11DD3BC")]
		[Preserve]
		public static void UnityEngine_Timeline_ControlPlayableAsset_op_Implicit()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x11DD484", Offset = "0x11DD484", VA = "0x11DD484")]
		[Preserve]
		public static void UnityEngine_Timeline_ControlPlayableAsset_op_Inequality()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x11DD554", Offset = "0x11DD554", VA = "0x11DD554")]
		[Preserve]
		public static void UnityEngine_Timeline_ControlTrack_op_Equality()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x11DD624", Offset = "0x11DD624", VA = "0x11DD624")]
		[Preserve]
		public static void UnityEngine_Timeline_ControlTrack_op_Implicit()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x11DD6EC", Offset = "0x11DD6EC", VA = "0x11DD6EC")]
		[Preserve]
		public static void UnityEngine_Timeline_ControlTrack_op_Inequality()
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x11DD7BC", Offset = "0x11DD7BC", VA = "0x11DD7BC")]
		[Preserve]
		public static void UnityEngine_Timeline_GroupTrack_op_Equality()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x11DD88C", Offset = "0x11DD88C", VA = "0x11DD88C")]
		[Preserve]
		public static void UnityEngine_Timeline_GroupTrack_op_Implicit()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x11DD954", Offset = "0x11DD954", VA = "0x11DD954")]
		[Preserve]
		public static void UnityEngine_Timeline_GroupTrack_op_Inequality()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x11DDA24", Offset = "0x11DDA24", VA = "0x11DDA24")]
		[Preserve]
		public static void UnityEngine_Timeline_PlayableTrack_op_Equality()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x11DDAF4", Offset = "0x11DDAF4", VA = "0x11DDAF4")]
		[Preserve]
		public static void UnityEngine_Timeline_PlayableTrack_op_Implicit()
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x11DDBBC", Offset = "0x11DDBBC", VA = "0x11DDBBC")]
		[Preserve]
		public static void UnityEngine_Timeline_PlayableTrack_op_Inequality()
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x11DDC8C", Offset = "0x11DDC8C", VA = "0x11DDC8C")]
		[Preserve]
		public static void UnityEngine_Timeline_TimelineAsset_op_Equality()
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x11DDD5C", Offset = "0x11DDD5C", VA = "0x11DDD5C")]
		[Preserve]
		public static void UnityEngine_Timeline_TimelineAsset_op_Implicit()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x11DDE24", Offset = "0x11DDE24", VA = "0x11DDE24")]
		[Preserve]
		public static void UnityEngine_Timeline_TimelineAsset_op_Inequality()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x11DDEF4", Offset = "0x11DDEF4", VA = "0x11DDEF4")]
		[Preserve]
		public static void UnityEngine_Timeline_TrackAsset_op_Equality()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x11DDFC4", Offset = "0x11DDFC4", VA = "0x11DDFC4")]
		[Preserve]
		public static void UnityEngine_Timeline_TrackAsset_op_Implicit()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x11DE08C", Offset = "0x11DE08C", VA = "0x11DE08C")]
		[Preserve]
		public static void UnityEngine_Timeline_TrackAsset_op_Inequality()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x11DE15C", Offset = "0x11DE15C", VA = "0x11DE15C")]
		[Preserve]
		public static void UnityEngine_TrailRenderer_op_Equality()
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x11DE22C", Offset = "0x11DE22C", VA = "0x11DE22C")]
		[Preserve]
		public static void UnityEngine_TrailRenderer_op_Implicit()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x11DE2F4", Offset = "0x11DE2F4", VA = "0x11DE2F4")]
		[Preserve]
		public static void UnityEngine_TrailRenderer_op_Inequality()
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x11DE3C4", Offset = "0x11DE3C4", VA = "0x11DE3C4")]
		[Preserve]
		public static void UnityEngine_Transform_op_Equality()
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x11DE494", Offset = "0x11DE494", VA = "0x11DE494")]
		[Preserve]
		public static void UnityEngine_Transform_op_Implicit()
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x11DE55C", Offset = "0x11DE55C", VA = "0x11DE55C")]
		[Preserve]
		public static void UnityEngine_Transform_op_Inequality()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x11DE62C", Offset = "0x11DE62C", VA = "0x11DE62C")]
		[Preserve]
		public static void UnityEngine_Transform_position()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x11DE660", Offset = "0x11DE660", VA = "0x11DE660")]
		[Preserve]
		public static void UnityEngine_Transform_SetParent()
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x11DE694", Offset = "0x11DE694", VA = "0x11DE694")]
		[Preserve]
		public static void UnityEngine_Tree_op_Equality()
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x11DE764", Offset = "0x11DE764", VA = "0x11DE764")]
		[Preserve]
		public static void UnityEngine_Tree_op_Implicit()
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x11DE82C", Offset = "0x11DE82C", VA = "0x11DE82C")]
		[Preserve]
		public static void UnityEngine_Tree_op_Inequality()
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x11DE8FC", Offset = "0x11DE8FC", VA = "0x11DE8FC")]
		[Preserve]
		public static void UnityEngine_U2D_SpriteAtlas_op_Equality()
		{
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x11DE9CC", Offset = "0x11DE9CC", VA = "0x11DE9CC")]
		[Preserve]
		public static void UnityEngine_U2D_SpriteAtlas_op_Implicit()
		{
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x11DEA94", Offset = "0x11DEA94", VA = "0x11DEA94")]
		[Preserve]
		public static void UnityEngine_U2D_SpriteAtlas_op_Inequality()
		{
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x11DEB64", Offset = "0x11DEB64", VA = "0x11DEB64")]
		[Preserve]
		public static void UnityEngine_UI_AspectRatioFitter_op_Equality()
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x11DEC34", Offset = "0x11DEC34", VA = "0x11DEC34")]
		[Preserve]
		public static void UnityEngine_UI_AspectRatioFitter_op_Implicit()
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x11DECFC", Offset = "0x11DECFC", VA = "0x11DECFC")]
		[Preserve]
		public static void UnityEngine_UI_AspectRatioFitter_op_Inequality()
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x11DEDCC", Offset = "0x11DEDCC", VA = "0x11DEDCC")]
		[Preserve]
		public static void UnityEngine_UI_BaseMeshEffect_op_Equality()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x11DEE9C", Offset = "0x11DEE9C", VA = "0x11DEE9C")]
		[Preserve]
		public static void UnityEngine_UI_BaseMeshEffect_op_Implicit()
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x11DEF64", Offset = "0x11DEF64", VA = "0x11DEF64")]
		[Preserve]
		public static void UnityEngine_UI_BaseMeshEffect_op_Inequality()
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x11DF034", Offset = "0x11DF034", VA = "0x11DF034")]
		[Preserve]
		public static void UnityEngine_UI_Button_op_Equality()
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x11DF104", Offset = "0x11DF104", VA = "0x11DF104")]
		[Preserve]
		public static void UnityEngine_UI_Button_op_Implicit()
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x11DF1CC", Offset = "0x11DF1CC", VA = "0x11DF1CC")]
		[Preserve]
		public static void UnityEngine_UI_Button_op_Inequality()
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x11DF29C", Offset = "0x11DF29C", VA = "0x11DF29C")]
		[Preserve]
		public static void UnityEngine_UI_CanvasScaler_op_Equality()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x11DF36C", Offset = "0x11DF36C", VA = "0x11DF36C")]
		[Preserve]
		public static void UnityEngine_UI_CanvasScaler_op_Implicit()
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x11DF434", Offset = "0x11DF434", VA = "0x11DF434")]
		[Preserve]
		public static void UnityEngine_UI_CanvasScaler_op_Inequality()
		{
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x11DF504", Offset = "0x11DF504", VA = "0x11DF504")]
		[Preserve]
		public static void UnityEngine_UI_ContentSizeFitter_op_Equality()
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x11DF5D4", Offset = "0x11DF5D4", VA = "0x11DF5D4")]
		[Preserve]
		public static void UnityEngine_UI_ContentSizeFitter_op_Implicit()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x11DF69C", Offset = "0x11DF69C", VA = "0x11DF69C")]
		[Preserve]
		public static void UnityEngine_UI_ContentSizeFitter_op_Inequality()
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x11DF76C", Offset = "0x11DF76C", VA = "0x11DF76C")]
		[Preserve]
		public static void UnityEngine_UI_Dropdown_op_Equality()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x11DF83C", Offset = "0x11DF83C", VA = "0x11DF83C")]
		[Preserve]
		public static void UnityEngine_UI_Dropdown_op_Implicit()
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x11DF904", Offset = "0x11DF904", VA = "0x11DF904")]
		[Preserve]
		public static void UnityEngine_UI_Dropdown_op_Inequality()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x11DF9D4", Offset = "0x11DF9D4", VA = "0x11DF9D4")]
		[Preserve]
		public static void UnityEngine_UI_Graphic_op_Equality()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x11DFAA4", Offset = "0x11DFAA4", VA = "0x11DFAA4")]
		[Preserve]
		public static void UnityEngine_UI_Graphic_op_Implicit()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x11DFB6C", Offset = "0x11DFB6C", VA = "0x11DFB6C")]
		[Preserve]
		public static void UnityEngine_UI_Graphic_op_Inequality()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x11DFC3C", Offset = "0x11DFC3C", VA = "0x11DFC3C")]
		[Preserve]
		public static void UnityEngine_UI_GraphicRaycaster_op_Equality()
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x11DFD0C", Offset = "0x11DFD0C", VA = "0x11DFD0C")]
		[Preserve]
		public static void UnityEngine_UI_GraphicRaycaster_op_Implicit()
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x11DFDD4", Offset = "0x11DFDD4", VA = "0x11DFDD4")]
		[Preserve]
		public static void UnityEngine_UI_GraphicRaycaster_op_Inequality()
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x11DFEA4", Offset = "0x11DFEA4", VA = "0x11DFEA4")]
		[Preserve]
		public static void UnityEngine_UI_GridLayoutGroup_op_Equality()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x11DFF74", Offset = "0x11DFF74", VA = "0x11DFF74")]
		[Preserve]
		public static void UnityEngine_UI_GridLayoutGroup_op_Implicit()
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x11E003C", Offset = "0x11E003C", VA = "0x11E003C")]
		[Preserve]
		public static void UnityEngine_UI_GridLayoutGroup_op_Inequality()
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x11E010C", Offset = "0x11E010C", VA = "0x11E010C")]
		[Preserve]
		public static void UnityEngine_UI_HorizontalLayoutGroup_op_Equality()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x11E01DC", Offset = "0x11E01DC", VA = "0x11E01DC")]
		[Preserve]
		public static void UnityEngine_UI_HorizontalLayoutGroup_op_Implicit()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x11E02A4", Offset = "0x11E02A4", VA = "0x11E02A4")]
		[Preserve]
		public static void UnityEngine_UI_HorizontalLayoutGroup_op_Inequality()
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x11E0374", Offset = "0x11E0374", VA = "0x11E0374")]
		[Preserve]
		public static void UnityEngine_UI_HorizontalOrVerticalLayoutGroup_op_Equality()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x11E0444", Offset = "0x11E0444", VA = "0x11E0444")]
		[Preserve]
		public static void UnityEngine_UI_HorizontalOrVerticalLayoutGroup_op_Implicit()
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x11E050C", Offset = "0x11E050C", VA = "0x11E050C")]
		[Preserve]
		public static void UnityEngine_UI_HorizontalOrVerticalLayoutGroup_op_Inequality()
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x11E05DC", Offset = "0x11E05DC", VA = "0x11E05DC")]
		[Preserve]
		public static void UnityEngine_UI_Image_op_Equality()
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x11E06AC", Offset = "0x11E06AC", VA = "0x11E06AC")]
		[Preserve]
		public static void UnityEngine_UI_Image_op_Implicit()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x11E0774", Offset = "0x11E0774", VA = "0x11E0774")]
		[Preserve]
		public static void UnityEngine_UI_Image_op_Inequality()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x11E0844", Offset = "0x11E0844", VA = "0x11E0844")]
		[Preserve]
		public static void UnityEngine_UI_InputField_op_Equality()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x11E0914", Offset = "0x11E0914", VA = "0x11E0914")]
		[Preserve]
		public static void UnityEngine_UI_InputField_op_Implicit()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x11E09DC", Offset = "0x11E09DC", VA = "0x11E09DC")]
		[Preserve]
		public static void UnityEngine_UI_InputField_op_Inequality()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x11E0AAC", Offset = "0x11E0AAC", VA = "0x11E0AAC")]
		[Preserve]
		public static void UnityEngine_UI_LayoutElement_op_Equality()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x11E0B7C", Offset = "0x11E0B7C", VA = "0x11E0B7C")]
		[Preserve]
		public static void UnityEngine_UI_LayoutElement_op_Implicit()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x11E0C44", Offset = "0x11E0C44", VA = "0x11E0C44")]
		[Preserve]
		public static void UnityEngine_UI_LayoutElement_op_Inequality()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x11E0D14", Offset = "0x11E0D14", VA = "0x11E0D14")]
		[Preserve]
		public static void UnityEngine_UI_LayoutGroup_op_Equality()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x11E0DE4", Offset = "0x11E0DE4", VA = "0x11E0DE4")]
		[Preserve]
		public static void UnityEngine_UI_LayoutGroup_op_Implicit()
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x11E0EAC", Offset = "0x11E0EAC", VA = "0x11E0EAC")]
		[Preserve]
		public static void UnityEngine_UI_LayoutGroup_op_Inequality()
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x11E0F7C", Offset = "0x11E0F7C", VA = "0x11E0F7C")]
		[Preserve]
		public static void UnityEngine_UI_Mask_op_Equality()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x11E104C", Offset = "0x11E104C", VA = "0x11E104C")]
		[Preserve]
		public static void UnityEngine_UI_Mask_op_Implicit()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x11E1114", Offset = "0x11E1114", VA = "0x11E1114")]
		[Preserve]
		public static void UnityEngine_UI_Mask_op_Inequality()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x11E11E4", Offset = "0x11E11E4", VA = "0x11E11E4")]
		[Preserve]
		public static void UnityEngine_UI_MaskableGraphic_op_Equality()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x11E12B4", Offset = "0x11E12B4", VA = "0x11E12B4")]
		[Preserve]
		public static void UnityEngine_UI_MaskableGraphic_op_Implicit()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x11E137C", Offset = "0x11E137C", VA = "0x11E137C")]
		[Preserve]
		public static void UnityEngine_UI_MaskableGraphic_op_Inequality()
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x11E144C", Offset = "0x11E144C", VA = "0x11E144C")]
		[Preserve]
		public static void UnityEngine_UI_Outline_op_Equality()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x11E151C", Offset = "0x11E151C", VA = "0x11E151C")]
		[Preserve]
		public static void UnityEngine_UI_Outline_op_Implicit()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x11E15E4", Offset = "0x11E15E4", VA = "0x11E15E4")]
		[Preserve]
		public static void UnityEngine_UI_Outline_op_Inequality()
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x11E16B4", Offset = "0x11E16B4", VA = "0x11E16B4")]
		[Preserve]
		public static void UnityEngine_UI_PositionAsUV1_op_Equality()
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x11E1784", Offset = "0x11E1784", VA = "0x11E1784")]
		[Preserve]
		public static void UnityEngine_UI_PositionAsUV1_op_Implicit()
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x11E184C", Offset = "0x11E184C", VA = "0x11E184C")]
		[Preserve]
		public static void UnityEngine_UI_PositionAsUV1_op_Inequality()
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x11E191C", Offset = "0x11E191C", VA = "0x11E191C")]
		[Preserve]
		public static void UnityEngine_UI_RawImage_op_Equality()
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x11E19EC", Offset = "0x11E19EC", VA = "0x11E19EC")]
		[Preserve]
		public static void UnityEngine_UI_RawImage_op_Implicit()
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x11E1AB4", Offset = "0x11E1AB4", VA = "0x11E1AB4")]
		[Preserve]
		public static void UnityEngine_UI_RawImage_op_Inequality()
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x11E1B84", Offset = "0x11E1B84", VA = "0x11E1B84")]
		[Preserve]
		public static void UnityEngine_UI_RectMask2D_op_Equality()
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x11E1C54", Offset = "0x11E1C54", VA = "0x11E1C54")]
		[Preserve]
		public static void UnityEngine_UI_RectMask2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x11E1D1C", Offset = "0x11E1D1C", VA = "0x11E1D1C")]
		[Preserve]
		public static void UnityEngine_UI_RectMask2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x11E1DEC", Offset = "0x11E1DEC", VA = "0x11E1DEC")]
		[Preserve]
		public static void UnityEngine_UI_Scrollbar_op_Equality()
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x11E1EBC", Offset = "0x11E1EBC", VA = "0x11E1EBC")]
		[Preserve]
		public static void UnityEngine_UI_Scrollbar_op_Implicit()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x11E1F84", Offset = "0x11E1F84", VA = "0x11E1F84")]
		[Preserve]
		public static void UnityEngine_UI_Scrollbar_op_Inequality()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x11E2054", Offset = "0x11E2054", VA = "0x11E2054")]
		[Preserve]
		public static void UnityEngine_UI_ScrollRect_op_Equality()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x11E2124", Offset = "0x11E2124", VA = "0x11E2124")]
		[Preserve]
		public static void UnityEngine_UI_ScrollRect_op_Implicit()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x11E21EC", Offset = "0x11E21EC", VA = "0x11E21EC")]
		[Preserve]
		public static void UnityEngine_UI_ScrollRect_op_Inequality()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x11E22BC", Offset = "0x11E22BC", VA = "0x11E22BC")]
		[Preserve]
		public static void UnityEngine_UI_Selectable_op_Equality()
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x11E238C", Offset = "0x11E238C", VA = "0x11E238C")]
		[Preserve]
		public static void UnityEngine_UI_Selectable_op_Implicit()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x11E2454", Offset = "0x11E2454", VA = "0x11E2454")]
		[Preserve]
		public static void UnityEngine_UI_Selectable_op_Inequality()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x11E2524", Offset = "0x11E2524", VA = "0x11E2524")]
		[Preserve]
		public static void UnityEngine_UI_Shadow_op_Equality()
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x11E25F4", Offset = "0x11E25F4", VA = "0x11E25F4")]
		[Preserve]
		public static void UnityEngine_UI_Shadow_op_Implicit()
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x11E26BC", Offset = "0x11E26BC", VA = "0x11E26BC")]
		[Preserve]
		public static void UnityEngine_UI_Shadow_op_Inequality()
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x11E278C", Offset = "0x11E278C", VA = "0x11E278C")]
		[Preserve]
		public static void UnityEngine_UI_Slider_op_Equality()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x11E285C", Offset = "0x11E285C", VA = "0x11E285C")]
		[Preserve]
		public static void UnityEngine_UI_Slider_op_Implicit()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x11E2924", Offset = "0x11E2924", VA = "0x11E2924")]
		[Preserve]
		public static void UnityEngine_UI_Slider_op_Inequality()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x11E29F4", Offset = "0x11E29F4", VA = "0x11E29F4")]
		[Preserve]
		public static void UnityEngine_UI_Text_op_Equality()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x11E2AC4", Offset = "0x11E2AC4", VA = "0x11E2AC4")]
		[Preserve]
		public static void UnityEngine_UI_Text_op_Implicit()
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x11E2B8C", Offset = "0x11E2B8C", VA = "0x11E2B8C")]
		[Preserve]
		public static void UnityEngine_UI_Text_op_Inequality()
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x11E2C5C", Offset = "0x11E2C5C", VA = "0x11E2C5C")]
		[Preserve]
		public static void UnityEngine_UI_Toggle_op_Equality()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x11E2D2C", Offset = "0x11E2D2C", VA = "0x11E2D2C")]
		[Preserve]
		public static void UnityEngine_UI_Toggle_op_Implicit()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x11E2DF4", Offset = "0x11E2DF4", VA = "0x11E2DF4")]
		[Preserve]
		public static void UnityEngine_UI_Toggle_op_Inequality()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x11E2EC4", Offset = "0x11E2EC4", VA = "0x11E2EC4")]
		[Preserve]
		public static void UnityEngine_UI_ToggleGroup_op_Equality()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x11E2F94", Offset = "0x11E2F94", VA = "0x11E2F94")]
		[Preserve]
		public static void UnityEngine_UI_ToggleGroup_op_Implicit()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x11E305C", Offset = "0x11E305C", VA = "0x11E305C")]
		[Preserve]
		public static void UnityEngine_UI_ToggleGroup_op_Inequality()
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x11E312C", Offset = "0x11E312C", VA = "0x11E312C")]
		[Preserve]
		public static void UnityEngine_UI_VerticalLayoutGroup_op_Equality()
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x11E31FC", Offset = "0x11E31FC", VA = "0x11E31FC")]
		[Preserve]
		public static void UnityEngine_UI_VerticalLayoutGroup_op_Implicit()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x11E32C4", Offset = "0x11E32C4", VA = "0x11E32C4")]
		[Preserve]
		public static void UnityEngine_UI_VerticalLayoutGroup_op_Inequality()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x11E3394", Offset = "0x11E3394", VA = "0x11E3394")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Addition()
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x11E34B0", Offset = "0x11E34B0", VA = "0x11E34B0")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Division()
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x11E35CC", Offset = "0x11E35CC", VA = "0x11E35CC")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Division_0()
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x11E36D8", Offset = "0x11E36D8", VA = "0x11E36D8")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Equality()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x11E37F4", Offset = "0x11E37F4", VA = "0x11E37F4")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Implicit()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x11E38EC", Offset = "0x11E38EC", VA = "0x11E38EC")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Implicit_0()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x11E39D4", Offset = "0x11E39D4", VA = "0x11E39D4")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Inequality()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x11E3AF0", Offset = "0x11E3AF0", VA = "0x11E3AF0")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Multiply()
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x11E3C0C", Offset = "0x11E3C0C", VA = "0x11E3C0C")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Multiply_0()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x11E3D18", Offset = "0x11E3D18", VA = "0x11E3D18")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Multiply_1()
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x11E3E2C", Offset = "0x11E3E2C", VA = "0x11E3E2C")]
		[Preserve]
		public static void UnityEngine_Vector2_op_Subtraction()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x11E3F48", Offset = "0x11E3F48", VA = "0x11E3F48")]
		[Preserve]
		public static void UnityEngine_Vector2_op_UnaryNegation()
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x11E4000", Offset = "0x11E4000", VA = "0x11E4000")]
		[Preserve]
		public static void UnityEngine_Vector3_op_Addition()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x11E412C", Offset = "0x11E412C", VA = "0x11E412C")]
		[Preserve]
		public static void UnityEngine_Vector3_op_Division()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x11E4240", Offset = "0x11E4240", VA = "0x11E4240")]
		[Preserve]
		public static void UnityEngine_Vector3_op_Equality()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x11E436C", Offset = "0x11E436C", VA = "0x11E436C")]
		[Preserve]
		public static void UnityEngine_Vector3_op_Inequality()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x11E4498", Offset = "0x11E4498", VA = "0x11E4498")]
		[Preserve]
		public static void UnityEngine_Vector3_op_Multiply()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x11E45AC", Offset = "0x11E45AC", VA = "0x11E45AC")]
		[Preserve]
		public static void UnityEngine_Vector3_op_Multiply_0()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x11E46C8", Offset = "0x11E46C8", VA = "0x11E46C8")]
		[Preserve]
		public static void UnityEngine_Vector3_op_Subtraction()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x11E47F4", Offset = "0x11E47F4", VA = "0x11E47F4")]
		[Preserve]
		public static void UnityEngine_Vector3_op_UnaryNegation()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x11E48B8", Offset = "0x11E48B8", VA = "0x11E48B8")]
		[Preserve]
		public static void UnityEngine_Vector4_op_Addition()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x11E49D8", Offset = "0x11E49D8", VA = "0x11E49D8")]
		[Preserve]
		public static void UnityEngine_Vector4_op_Division()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x11E4AEC", Offset = "0x11E4AEC", VA = "0x11E4AEC")]
		[Preserve]
		public static void UnityEngine_Vector4_op_Equality()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x11E4C0C", Offset = "0x11E4C0C", VA = "0x11E4C0C")]
		[Preserve]
		public static void UnityEngine_Vector4_op_Implicit()
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x11E4D04", Offset = "0x11E4D04", VA = "0x11E4D04")]
		[Preserve]
		public static void UnityEngine_Vector4_op_Implicit_0()
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x11E4DF4", Offset = "0x11E4DF4", VA = "0x11E4DF4")]
		[Preserve]
		public static void UnityEngine_Vector4_op_Implicit_1()
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x11E4EDC", Offset = "0x11E4EDC", VA = "0x11E4EDC")]
		[Preserve]
		public static void UnityEngine_Vector4_op_Inequality()
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x11E4FFC", Offset = "0x11E4FFC", VA = "0x11E4FFC")]
		[Preserve]
		public static void UnityEngine_Vector4_op_Multiply()
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x11E5110", Offset = "0x11E5110", VA = "0x11E5110")]
		[Preserve]
		public static void UnityEngine_Vector4_op_Multiply_0()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x11E522C", Offset = "0x11E522C", VA = "0x11E522C")]
		[Preserve]
		public static void UnityEngine_Vector4_op_Subtraction()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x11E534C", Offset = "0x11E534C", VA = "0x11E534C")]
		[Preserve]
		public static void UnityEngine_Vector4_op_UnaryNegation()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x11E540C", Offset = "0x11E540C", VA = "0x11E540C")]
		[Preserve]
		public static void UnityEngine_Video_VideoClip_op_Equality()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x11E54DC", Offset = "0x11E54DC", VA = "0x11E54DC")]
		[Preserve]
		public static void UnityEngine_Video_VideoClip_op_Implicit()
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x11E55A4", Offset = "0x11E55A4", VA = "0x11E55A4")]
		[Preserve]
		public static void UnityEngine_Video_VideoClip_op_Inequality()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x11E5674", Offset = "0x11E5674", VA = "0x11E5674")]
		[Preserve]
		public static void UnityEngine_Video_VideoPlayer_op_Equality()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x11E5744", Offset = "0x11E5744", VA = "0x11E5744")]
		[Preserve]
		public static void UnityEngine_Video_VideoPlayer_op_Implicit()
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x11E580C", Offset = "0x11E580C", VA = "0x11E580C")]
		[Preserve]
		public static void UnityEngine_Video_VideoPlayer_op_Inequality()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x11E58DC", Offset = "0x11E58DC", VA = "0x11E58DC")]
		[Preserve]
		public static void UnityEngine_WebCamTexture_op_Equality()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x11E59AC", Offset = "0x11E59AC", VA = "0x11E59AC")]
		[Preserve]
		public static void UnityEngine_WebCamTexture_op_Implicit()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x11E5A74", Offset = "0x11E5A74", VA = "0x11E5A74")]
		[Preserve]
		public static void UnityEngine_WebCamTexture_op_Inequality()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x11E5B44", Offset = "0x11E5B44", VA = "0x11E5B44")]
		[Preserve]
		public static void UnityEngine_WheelCollider_op_Equality()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x11E5C14", Offset = "0x11E5C14", VA = "0x11E5C14")]
		[Preserve]
		public static void UnityEngine_WheelCollider_op_Implicit()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x11E5CDC", Offset = "0x11E5CDC", VA = "0x11E5CDC")]
		[Preserve]
		public static void UnityEngine_WheelCollider_op_Inequality()
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x11E5DAC", Offset = "0x11E5DAC", VA = "0x11E5DAC")]
		[Preserve]
		public static void UnityEngine_WheelJoint2D_op_Equality()
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x11E5E7C", Offset = "0x11E5E7C", VA = "0x11E5E7C")]
		[Preserve]
		public static void UnityEngine_WheelJoint2D_op_Implicit()
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x11E5F44", Offset = "0x11E5F44", VA = "0x11E5F44")]
		[Preserve]
		public static void UnityEngine_WheelJoint2D_op_Inequality()
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x11E6014", Offset = "0x11E6014", VA = "0x11E6014")]
		[Preserve]
		public static void UnityEngine_WindZone_op_Equality()
		{
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x11E60E4", Offset = "0x11E60E4", VA = "0x11E60E4")]
		[Preserve]
		public static void UnityEngine_WindZone_op_Implicit()
		{
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x11E61AC", Offset = "0x11E61AC", VA = "0x11E61AC")]
		[Preserve]
		public static void UnityEngine_WindZone_op_Inequality()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x11E627C", Offset = "0x11E627C", VA = "0x11E627C")]
		[Preserve]
		public static void UnityEngine_XR_WSA_WorldAnchor_op_Equality()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x11E634C", Offset = "0x11E634C", VA = "0x11E634C")]
		[Preserve]
		public static void UnityEngine_XR_WSA_WorldAnchor_op_Implicit()
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x11E6414", Offset = "0x11E6414", VA = "0x11E6414")]
		[Preserve]
		public static void UnityEngine_XR_WSA_WorldAnchor_op_Inequality()
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x11E64E4", Offset = "0x11E64E4", VA = "0x11E64E4")]
		[Preserve]
		public static void UVRotator_op_Equality()
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x11E65B4", Offset = "0x11E65B4", VA = "0x11E65B4")]
		[Preserve]
		public static void UVRotator_op_Implicit()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x11E667C", Offset = "0x11E667C", VA = "0x11E667C")]
		[Preserve]
		public static void UVRotator_op_Inequality()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x11E674C", Offset = "0x11E674C", VA = "0x11E674C")]
		[Preserve]
		public static void UVScroller_op_Equality()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x11E681C", Offset = "0x11E681C", VA = "0x11E681C")]
		[Preserve]
		public static void UVScroller_op_Implicit()
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x11E68E4", Offset = "0x11E68E4", VA = "0x11E68E4")]
		[Preserve]
		public static void UVScroller_op_Inequality()
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x11E69B4", Offset = "0x11E69B4", VA = "0x11E69B4")]
		[Preserve]
		public static void VertexShake_op_Equality()
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x11E6A84", Offset = "0x11E6A84", VA = "0x11E6A84")]
		[Preserve]
		public static void VertexShake_op_Implicit()
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x11E6B4C", Offset = "0x11E6B4C", VA = "0x11E6B4C")]
		[Preserve]
		public static void VertexShake_op_Inequality()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x11E6C1C", Offset = "0x11E6C1C", VA = "0x11E6C1C")]
		[Preserve]
		public static void VideoCaptureController_op_Equality()
		{
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x11E6CEC", Offset = "0x11E6CEC", VA = "0x11E6CEC")]
		[Preserve]
		public static void VideoCaptureController_op_Implicit()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x11E6DB4", Offset = "0x11E6DB4", VA = "0x11E6DB4")]
		[Preserve]
		public static void VideoCaptureController_op_Inequality()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x11E6E84", Offset = "0x11E6E84", VA = "0x11E6E84")]
		[Preserve]
		public static void VideoTexture_op_Equality()
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x11E6F54", Offset = "0x11E6F54", VA = "0x11E6F54")]
		[Preserve]
		public static void VideoTexture_op_Implicit()
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x11E701C", Offset = "0x11E701C", VA = "0x11E701C")]
		[Preserve]
		public static void VideoTexture_op_Inequality()
		{
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x11E70EC", Offset = "0x11E70EC", VA = "0x11E70EC")]
		[Preserve]
		public static void VisibilityController_ctor()
		{
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x11E713C", Offset = "0x11E713C", VA = "0x11E713C")]
		[Preserve]
		public static void VisibilityController_op_Equality()
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x11E720C", Offset = "0x11E720C", VA = "0x11E720C")]
		[Preserve]
		public static void VisibilityController_op_Implicit()
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x11E72D4", Offset = "0x11E72D4", VA = "0x11E72D4")]
		[Preserve]
		public static void VisibilityController_op_Inequality()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x11E73A4", Offset = "0x11E73A4", VA = "0x11E73A4")]
		[Preserve]
		public static void VisibilityController_SetVisibility()
		{
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x11E73D8", Offset = "0x11E73D8", VA = "0x11E73D8")]
		[Preserve]
		public static void VisibilityController_SetVisibilityFromBolt()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x11E740C", Offset = "0x11E740C", VA = "0x11E740C")]
		[Preserve]
		public static void VisibilityControllerCollection_op_Equality()
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x11E74DC", Offset = "0x11E74DC", VA = "0x11E74DC")]
		[Preserve]
		public static void VisibilityControllerCollection_op_Implicit()
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x11E75A4", Offset = "0x11E75A4", VA = "0x11E75A4")]
		[Preserve]
		public static void VisibilityControllerCollection_op_Inequality()
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x11E7674", Offset = "0x11E7674", VA = "0x11E7674")]
		[Preserve]
		public static void VisibilityControllerCollection_SetVisibility()
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x11E76A8", Offset = "0x11E76A8", VA = "0x11E76A8")]
		[Preserve]
		public static void VisibilityControllerCollection_SetVisibilityFromBolt()
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x11E76DC", Offset = "0x11E76DC", VA = "0x11E76DC")]
		[Preserve]
		public static void VrCameraRig_op_Equality()
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x11E77AC", Offset = "0x11E77AC", VA = "0x11E77AC")]
		[Preserve]
		public static void VrCameraRig_op_Implicit()
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x11E7874", Offset = "0x11E7874", VA = "0x11E7874")]
		[Preserve]
		public static void VrCameraRig_op_Inequality()
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x11E7944", Offset = "0x11E7944", VA = "0x11E7944")]
		[Preserve]
		public static void VrConsoleHud_op_Equality()
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x11E7A14", Offset = "0x11E7A14", VA = "0x11E7A14")]
		[Preserve]
		public static void VrConsoleHud_op_Implicit()
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x11E7ADC", Offset = "0x11E7ADC", VA = "0x11E7ADC")]
		[Preserve]
		public static void VrConsoleHud_op_Inequality()
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x11E7BAC", Offset = "0x11E7BAC", VA = "0x11E7BAC")]
		[Preserve]
		public static void VrConsoleMessage_op_Equality()
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x11E7C7C", Offset = "0x11E7C7C", VA = "0x11E7C7C")]
		[Preserve]
		public static void VrConsoleMessage_op_Implicit()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x11E7D44", Offset = "0x11E7D44", VA = "0x11E7D44")]
		[Preserve]
		public static void VrConsoleMessage_op_Inequality()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x11E7E14", Offset = "0x11E7E14", VA = "0x11E7E14")]
		[Preserve]
		public static void VrDebugDraw_op_Equality()
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x11E7EE4", Offset = "0x11E7EE4", VA = "0x11E7EE4")]
		[Preserve]
		public static void VrDebugDraw_op_Implicit()
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x11E7FAC", Offset = "0x11E7FAC", VA = "0x11E7FAC")]
		[Preserve]
		public static void VrDebugDraw_op_Inequality()
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x11E807C", Offset = "0x11E807C", VA = "0x11E807C")]
		[Preserve]
		public static void VrDebugHud_op_Equality()
		{
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x11E814C", Offset = "0x11E814C", VA = "0x11E814C")]
		[Preserve]
		public static void VrDebugHud_op_Implicit()
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x11E8214", Offset = "0x11E8214", VA = "0x11E8214")]
		[Preserve]
		public static void VrDebugHud_op_Inequality()
		{
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x11E82E4", Offset = "0x11E82E4", VA = "0x11E82E4")]
		[Preserve]
		public static void VrPlatform_op_Equality()
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x11E83B4", Offset = "0x11E83B4", VA = "0x11E83B4")]
		[Preserve]
		public static void VrPlatform_op_Implicit()
		{
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x11E847C", Offset = "0x11E847C", VA = "0x11E847C")]
		[Preserve]
		public static void VrPlatform_op_Inequality()
		{
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x11E854C", Offset = "0x11E854C", VA = "0x11E854C")]
		[Preserve]
		public static void VrPlatform_Oculus_op_Equality()
		{
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x11E861C", Offset = "0x11E861C", VA = "0x11E861C")]
		[Preserve]
		public static void VrPlatform_Oculus_op_Implicit()
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x11E86E4", Offset = "0x11E86E4", VA = "0x11E86E4")]
		[Preserve]
		public static void VrPlatform_Oculus_op_Inequality()
		{
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x11E87B4", Offset = "0x11E87B4", VA = "0x11E87B4")]
		[Preserve]
		public static void VrPlatform_Steam_op_Equality()
		{
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x11E8884", Offset = "0x11E8884", VA = "0x11E8884")]
		[Preserve]
		public static void VrPlatform_Steam_op_Implicit()
		{
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x11E894C", Offset = "0x11E894C", VA = "0x11E894C")]
		[Preserve]
		public static void VrPlatform_Steam_op_Inequality()
		{
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x11E8A1C", Offset = "0x11E8A1C", VA = "0x11E8A1C")]
		[Preserve]
		public static void VrPlatformManager_GetInstance()
		{
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x11E8AC4", Offset = "0x11E8AC4", VA = "0x11E8AC4")]
		[Preserve]
		public static void VrPlatformManager_HasGoggleButton()
		{
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x11E8AF8", Offset = "0x11E8AF8", VA = "0x11E8AF8")]
		[Preserve]
		public static void VrPlatformManager_op_Equality()
		{
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x11E8BC8", Offset = "0x11E8BC8", VA = "0x11E8BC8")]
		[Preserve]
		public static void VrPlatformManager_op_Implicit()
		{
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x11E8C90", Offset = "0x11E8C90", VA = "0x11E8C90")]
		[Preserve]
		public static void VrPlatformManager_op_Inequality()
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x11E8D60", Offset = "0x11E8D60", VA = "0x11E8D60")]
		[Preserve]
		public static void VrRaycaster_op_Equality()
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x11E8E30", Offset = "0x11E8E30", VA = "0x11E8E30")]
		[Preserve]
		public static void VrRaycaster_op_Implicit()
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x11E8EF8", Offset = "0x11E8EF8", VA = "0x11E8EF8")]
		[Preserve]
		public static void VrRaycaster_op_Inequality()
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x11E8FC8", Offset = "0x11E8FC8", VA = "0x11E8FC8")]
		[Preserve]
		public static void VrScreenFade_op_Equality()
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x11E9098", Offset = "0x11E9098", VA = "0x11E9098")]
		[Preserve]
		public static void VrScreenFade_op_Implicit()
		{
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x11E9160", Offset = "0x11E9160", VA = "0x11E9160")]
		[Preserve]
		public static void VrScreenFade_op_Inequality()
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x11E9230", Offset = "0x11E9230", VA = "0x11E9230")]
		[Preserve]
		public static void WaterLevel_IsFilled()
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x11E9264", Offset = "0x11E9264", VA = "0x11E9264")]
		[Preserve]
		public static void WaterLevel_op_Equality()
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x11E9334", Offset = "0x11E9334", VA = "0x11E9334")]
		[Preserve]
		public static void WaterLevel_op_Implicit()
		{
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x11E93FC", Offset = "0x11E93FC", VA = "0x11E93FC")]
		[Preserve]
		public static void WaterLevel_op_Inequality()
		{
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x11E94CC", Offset = "0x11E94CC", VA = "0x11E94CC")]
		[Preserve]
		public static void WaveSimulation_op_Equality()
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x11E959C", Offset = "0x11E959C", VA = "0x11E959C")]
		[Preserve]
		public static void WaveSimulation_op_Implicit()
		{
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x11E9664", Offset = "0x11E9664", VA = "0x11E9664")]
		[Preserve]
		public static void WaveSimulation_op_Inequality()
		{
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x11E9734", Offset = "0x11E9734", VA = "0x11E9734")]
		[Preserve]
		public static void WitchBeetle_op_Equality()
		{
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x11E9804", Offset = "0x11E9804", VA = "0x11E9804")]
		[Preserve]
		public static void WitchBeetle_op_Implicit()
		{
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x11E98CC", Offset = "0x11E98CC", VA = "0x11E98CC")]
		[Preserve]
		public static void WitchBeetle_op_Inequality()
		{
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x11E999C", Offset = "0x11E999C", VA = "0x11E999C")]
		[Preserve]
		public static void WitchBeetleReceiver_op_Equality()
		{
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x11E9A6C", Offset = "0x11E9A6C", VA = "0x11E9A6C")]
		[Preserve]
		public static void WitchBeetleReceiver_op_Implicit()
		{
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x11E9B34", Offset = "0x11E9B34", VA = "0x11E9B34")]
		[Preserve]
		public static void WitchBeetleReceiver_op_Inequality()
		{
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x11E9C04", Offset = "0x11E9C04", VA = "0x11E9C04")]
		[Preserve]
		public static void WitchBellows_op_Equality()
		{
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x11E9CD4", Offset = "0x11E9CD4", VA = "0x11E9CD4")]
		[Preserve]
		public static void WitchBellows_op_Implicit()
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x11E9D9C", Offset = "0x11E9D9C", VA = "0x11E9D9C")]
		[Preserve]
		public static void WitchBellows_op_Inequality()
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x11E9E6C", Offset = "0x11E9E6C", VA = "0x11E9E6C")]
		[Preserve]
		public static void WitchCandle_op_Equality()
		{
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x11E9F3C", Offset = "0x11E9F3C", VA = "0x11E9F3C")]
		[Preserve]
		public static void WitchCandle_op_Implicit()
		{
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x11EA004", Offset = "0x11EA004", VA = "0x11EA004")]
		[Preserve]
		public static void WitchCandle_op_Inequality()
		{
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x11EA0D4", Offset = "0x11EA0D4", VA = "0x11EA0D4")]
		[Preserve]
		public static void WitchCandleCombination_op_Equality()
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x11EA1A4", Offset = "0x11EA1A4", VA = "0x11EA1A4")]
		[Preserve]
		public static void WitchCandleCombination_op_Implicit()
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x11EA26C", Offset = "0x11EA26C", VA = "0x11EA26C")]
		[Preserve]
		public static void WitchCandleCombination_op_Inequality()
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x11EA33C", Offset = "0x11EA33C", VA = "0x11EA33C")]
		[Preserve]
		public static void WitchCauldron_AddIngredient()
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x11EA370", Offset = "0x11EA370", VA = "0x11EA370")]
		[Preserve]
		public static void WitchCauldron_GetCurrentPreparedRecipe()
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x11EA3A4", Offset = "0x11EA3A4", VA = "0x11EA3A4")]
		[Preserve]
		public static void WitchCauldron_op_Equality()
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x11EA474", Offset = "0x11EA474", VA = "0x11EA474")]
		[Preserve]
		public static void WitchCauldron_op_Implicit()
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x11EA53C", Offset = "0x11EA53C", VA = "0x11EA53C")]
		[Preserve]
		public static void WitchCauldron_op_Inequality()
		{
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x11EA60C", Offset = "0x11EA60C", VA = "0x11EA60C")]
		[Preserve]
		public static void WitchCauldron_ResetCauldron()
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x11EA640", Offset = "0x11EA640", VA = "0x11EA640")]
		[Preserve]
		public static void WitchCauldron_SetRecipeCompleted()
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x11EA674", Offset = "0x11EA674", VA = "0x11EA674")]
		[Preserve]
		public static void WitchDollsHouseLatchFailSafe_op_Equality()
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x11EA744", Offset = "0x11EA744", VA = "0x11EA744")]
		[Preserve]
		public static void WitchDollsHouseLatchFailSafe_op_Implicit()
		{
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x11EA80C", Offset = "0x11EA80C", VA = "0x11EA80C")]
		[Preserve]
		public static void WitchDollsHouseLatchFailSafe_op_Inequality()
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x11EA8DC", Offset = "0x11EA8DC", VA = "0x11EA8DC")]
		[Preserve]
		public static void WitchLantern_op_Equality()
		{
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x11EA9AC", Offset = "0x11EA9AC", VA = "0x11EA9AC")]
		[Preserve]
		public static void WitchLantern_op_Implicit()
		{
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x11EAA74", Offset = "0x11EAA74", VA = "0x11EAA74")]
		[Preserve]
		public static void WitchLantern_op_Inequality()
		{
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x11EAB44", Offset = "0x11EAB44", VA = "0x11EAB44")]
		[Preserve]
		public static void WitchLantern_PlayBaseOpenAudio()
		{
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x11EAB78", Offset = "0x11EAB78", VA = "0x11EAB78")]
		[Preserve]
		public static void WitchLantern_SetSpotlightIndex()
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x11EABAC", Offset = "0x11EABAC", VA = "0x11EABAC")]
		[Preserve]
		public static void WitchMagicMirror_op_Equality()
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x11EAC7C", Offset = "0x11EAC7C", VA = "0x11EAC7C")]
		[Preserve]
		public static void WitchMagicMirror_op_Implicit()
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x11EAD44", Offset = "0x11EAD44", VA = "0x11EAD44")]
		[Preserve]
		public static void WitchMagicMirror_op_Inequality()
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x11EAE14", Offset = "0x11EAE14", VA = "0x11EAE14")]
		[Preserve]
		public static void WitchMagicMirrorTarget_IsSolved()
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x11EAE48", Offset = "0x11EAE48", VA = "0x11EAE48")]
		[Preserve]
		public static void WitchMagicMirrorTarget_op_Equality()
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x11EAF18", Offset = "0x11EAF18", VA = "0x11EAF18")]
		[Preserve]
		public static void WitchMagicMirrorTarget_op_Implicit()
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x11EAFE0", Offset = "0x11EAFE0", VA = "0x11EAFE0")]
		[Preserve]
		public static void WitchMagicMirrorTarget_op_Inequality()
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x11EB0B0", Offset = "0x11EB0B0", VA = "0x11EB0B0")]
		[Preserve]
		public static void WitchMoonBeam_op_Equality()
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x11EB180", Offset = "0x11EB180", VA = "0x11EB180")]
		[Preserve]
		public static void WitchMoonBeam_op_Implicit()
		{
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x11EB248", Offset = "0x11EB248", VA = "0x11EB248")]
		[Preserve]
		public static void WitchMoonBeam_op_Inequality()
		{
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x11EB318", Offset = "0x11EB318", VA = "0x11EB318")]
		[Preserve]
		public static void WitchMoonBeam_SetSunLensInPlace()
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x11EB34C", Offset = "0x11EB34C", VA = "0x11EB34C")]
		[Preserve]
		public static void WitchMoonKey_op_Equality()
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x11EB41C", Offset = "0x11EB41C", VA = "0x11EB41C")]
		[Preserve]
		public static void WitchMoonKey_op_Implicit()
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x11EB4E4", Offset = "0x11EB4E4", VA = "0x11EB4E4")]
		[Preserve]
		public static void WitchMoonKey_op_Inequality()
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x11EB5B4", Offset = "0x11EB5B4", VA = "0x11EB5B4")]
		[Preserve]
		public static void WitchMoonKey_SetPhaseComplete()
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x11EB5E8", Offset = "0x11EB5E8", VA = "0x11EB5E8")]
		[Preserve]
		public static void WitchSoul_op_Equality()
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x11EB6B8", Offset = "0x11EB6B8", VA = "0x11EB6B8")]
		[Preserve]
		public static void WitchSoul_op_Implicit()
		{
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x11EB780", Offset = "0x11EB780", VA = "0x11EB780")]
		[Preserve]
		public static void WitchSoul_op_Inequality()
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x11EB850", Offset = "0x11EB850", VA = "0x11EB850")]
		[Preserve]
		public static void WitchSoulController_GetCurrentSegmentName()
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x11EB884", Offset = "0x11EB884", VA = "0x11EB884")]
		[Preserve]
		public static void WitchSoulController_op_Equality()
		{
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x11EB954", Offset = "0x11EB954", VA = "0x11EB954")]
		[Preserve]
		public static void WitchSoulController_op_Implicit()
		{
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x11EBA1C", Offset = "0x11EBA1C", VA = "0x11EBA1C")]
		[Preserve]
		public static void WitchSoulController_op_Inequality()
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x11EBAEC", Offset = "0x11EBAEC", VA = "0x11EBAEC")]
		[Preserve]
		public static void WitchStarRotator_op_Equality()
		{
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x11EBBBC", Offset = "0x11EBBBC", VA = "0x11EBBBC")]
		[Preserve]
		public static void WitchStarRotator_op_Implicit()
		{
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x11EBC84", Offset = "0x11EBC84", VA = "0x11EBC84")]
		[Preserve]
		public static void WitchStarRotator_op_Inequality()
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x11EBD54", Offset = "0x11EBD54", VA = "0x11EBD54")]
		[Preserve]
		public static void WitchVoidSpaceController_HasCurrentSpaceBeenCompleted()
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x11EBD88", Offset = "0x11EBD88", VA = "0x11EBD88")]
		[Preserve]
		public static void WitchVoidSpaceController_op_Equality()
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x11EBE58", Offset = "0x11EBE58", VA = "0x11EBE58")]
		[Preserve]
		public static void WitchVoidSpaceController_op_Implicit()
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x11EBF20", Offset = "0x11EBF20", VA = "0x11EBF20")]
		[Preserve]
		public static void WitchVoidSpaceController_op_Inequality()
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x11EBFF0", Offset = "0x11EBFF0", VA = "0x11EBFF0")]
		[Preserve]
		public static void WitchVoidSpaceController_SetBurntTarotCardInvisible()
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x11EC024", Offset = "0x11EC024", VA = "0x11EC024")]
		[Preserve]
		public static void WitchVoidSpaceController_SetDoorOpen()
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x11EC058", Offset = "0x11EC058", VA = "0x11EC058")]
		[Preserve]
		public static void YouTrackBugReportAction_op_Equality()
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x11EC128", Offset = "0x11EC128", VA = "0x11EC128")]
		[Preserve]
		public static void YouTrackBugReportAction_op_Implicit()
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x11EC1F0", Offset = "0x11EC1F0", VA = "0x11EC1F0")]
		[Preserve]
		public static void YouTrackBugReportAction_op_Inequality()
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x11EC2C0", Offset = "0x11EC2C0", VA = "0x11EC2C0")]
		public AotStubs()
		{
		}
	}
}
