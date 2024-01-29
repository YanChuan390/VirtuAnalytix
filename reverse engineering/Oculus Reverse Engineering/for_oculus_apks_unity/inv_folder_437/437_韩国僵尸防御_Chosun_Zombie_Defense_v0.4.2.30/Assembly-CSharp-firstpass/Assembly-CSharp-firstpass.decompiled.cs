using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class I360Render
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material equirectangularConverter;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int paddingX;

	[Token(Token = "0x4000003")]
	private const string XMP_NAMESPACE_JPEG = "http://ns.adobe.com/xap/1.0/";

	[Token(Token = "0x4000004")]
	private const string XMP_CONTENT_TO_FORMAT_JPEG = "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" GPano:UsePanoramaViewer=\"True\" GPano:CaptureSoftware=\"Unity3D\" GPano:StitchingSoftware=\"Unity3D\" GPano:ProjectionType=\"equirectangular\" GPano:PoseHeadingDegrees=\"180.0\" GPano:InitialViewHeadingDegrees=\"0.0\" GPano:InitialViewPitchDegrees=\"0.0\" GPano:InitialViewRollDegrees=\"0.0\" GPano:InitialHorizontalFOVDegrees=\"{0}\" GPano:CroppedAreaLeftPixels=\"0\" GPano:CroppedAreaTopPixels=\"0\" GPano:CroppedAreaImageWidthPixels=\"{1}\" GPano:CroppedAreaImageHeightPixels=\"{2}\" GPano:FullPanoWidthPixels=\"{1}\" GPano:FullPanoHeightPixels=\"{2}\"/></rdf:RDF></x:xmpmeta>";

	[Token(Token = "0x4000005")]
	private const string XMP_CONTENT_TO_FORMAT_PNG = "XML:com.adobe.xmp\0\0\0\0\0<?xpacket begin=\"ï»¿\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\" xmlns:tiff=\"http://ns.adobe.com/tiff/1.0/\" xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"> <GPano:UsePanoramaViewer>True</GPano:UsePanoramaViewer> <GPano:CaptureSoftware>Unity3D</GPano:CaptureSoftware> <GPano:StitchingSoftware>Unity3D</GPano:StitchingSoftware> <GPano:ProjectionType>equirectangular</GPano:ProjectionType> <GPano:PoseHeadingDegrees>180.0</GPano:PoseHeadingDegrees> <GPano:InitialViewHeadingDegrees>0.0</GPano:InitialViewHeadingDegrees> <GPano:InitialViewPitchDegrees>0.0</GPano:InitialViewPitchDegrees> <GPano:InitialViewRollDegrees>0.0</GPano:InitialViewRollDegrees> <GPano:InitialHorizontalFOVDegrees>{0}</GPano:InitialHorizontalFOVDegrees> <GPano:CroppedAreaLeftPixels>0</GPano:CroppedAreaLeftPixels> <GPano:CroppedAreaTopPixels>0</GPano:CroppedAreaTopPixels> <GPano:CroppedAreaImageWidthPixels>{1}</GPano:CroppedAreaImageWidthPixels> <GPano:CroppedAreaImageHeightPixels>{2}</GPano:CroppedAreaImageHeightPixels> <GPano:FullPanoWidthPixels>{1}</GPano:FullPanoWidthPixels> <GPano:FullPanoHeightPixels>{2}</GPano:FullPanoHeightPixels> <tiff:Orientation>1</tiff:Orientation> <exif:PixelXDimension>{1}</exif:PixelXDimension> <exif:PixelYDimension>{2}</exif:PixelYDimension> </rdf:Description></rdf:RDF></x:xmpmeta><?xpacket end=\"w\"?>";

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static uint[] CRC_TABLE_PNG;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xF91300", Offset = "0xF91300", VA = "0xF91300")]
	public static byte[] Capture(int width = 1024, bool encodeAsJPEG = true, [Optional] Camera renderCam, bool faceCameraDirection = true)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xF91984", Offset = "0xF91984", VA = "0xF91984")]
	public static byte[] InsertXMPIntoTexture2D_JPEG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xF91928", Offset = "0xF91928", VA = "0xF91928")]
	public static byte[] InsertXMPIntoTexture2D_PNG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xF919E4", Offset = "0xF919E4", VA = "0xF919E4")]
	private static byte[] DoTheHardWork_JPEG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xF922CC", Offset = "0xF922CC", VA = "0xF922CC")]
	private static bool CheckBytesForXMPNamespace_JPEG(byte[] bytes, int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xF9217C", Offset = "0xF9217C", VA = "0xF9217C")]
	private static bool SearchChunkForXMP_JPEG(byte[] bytes, ref int startIndex, ref int chunkSize)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xF92290", Offset = "0xF92290", VA = "0xF92290")]
	private static int FindIndexToInsertXMPCode_JPEG(byte[] bytes)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xF91DDC", Offset = "0xF91DDC", VA = "0xF91DDC")]
	private static byte[] DoTheHardWork_PNG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xF92398", Offset = "0xF92398", VA = "0xF92398")]
	private static string CalculateCRC_PNG(string xmpContent)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xF9265C", Offset = "0xF9265C", VA = "0xF9265C")]
	private static uint UpdateCRC_PNG(string xmpContent)
	{
		return default(uint);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xF9259C", Offset = "0xF9259C", VA = "0xF9259C")]
	private static void CalculateCRCTable_PNG()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xF92724", Offset = "0xF92724", VA = "0xF92724")]
	private static byte[] CalculateCRCBytes_PNG(uint crc)
	{
		return null;
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000003")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[Tooltip("Apply height-based fog?")]
		public bool heightFog;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Fog top Y coordinate")]
		public float height;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0.001f, 10f)]
		public float heightDensity;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fogShader;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fogMaterial;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xF927B8", Offset = "0xF927B8", VA = "0xF927B8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xF92D68", Offset = "0xF92D68", VA = "0xF92D68")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xF93690", Offset = "0xF93690", VA = "0xF93690")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xF937F0", Offset = "0xF937F0", VA = "0xF937F0")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xF92910", Offset = "0xF92910", VA = "0xF92910")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xF9384C", Offset = "0xF9384C", VA = "0xF9384C")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xF93A30", Offset = "0xF93A30", VA = "0xF93A30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xF93A3C", Offset = "0xF93A3C", VA = "0xF93A3C")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xF93A44", Offset = "0xF93A44", VA = "0xF93A44", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xF93B04", Offset = "0xF93B04", VA = "0xF93B04")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xF9280C", Offset = "0xF9280C", VA = "0xF9280C")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xF93B10", Offset = "0xF93B10", VA = "0xF93B10")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xF93B68", Offset = "0xF93B68", VA = "0xF93B68")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xF92CB0", Offset = "0xF92CB0", VA = "0xF92CB0")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xF93B70", Offset = "0xF93B70", VA = "0xF93B70")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xF9382C", Offset = "0xF9382C", VA = "0xF9382C")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xF93D88", Offset = "0xF93D88", VA = "0xF93D88")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xF93818", Offset = "0xF93818", VA = "0xF93818")]
		public PostEffectsBase()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000005")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000006")]
		public enum Mode
		{
			[Token(Token = "0x4000021")]
			AnimationClips,
			[Token(Token = "0x4000022")]
			AnimationStates,
			[Token(Token = "0x4000023")]
			PlayableDirector,
			[Token(Token = "0x4000024")]
			Realtime
		}

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		[Range(0f, 0.1f)]
		public float keyReductionError;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0xF94210", Offset = "0xF94210", VA = "0xF94210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0xF94218", Offset = "0xF94218", VA = "0xF94218")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xF94224", Offset = "0xF94224", VA = "0xF94224")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xF9422C", Offset = "0xF9422C", VA = "0xF9422C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xF94234", Offset = "0xF94234", VA = "0xF94234")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xF9423C", Offset = "0xF9423C", VA = "0xF9423C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xF94100", Offset = "0xF94100", VA = "0xF94100")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xF94144", Offset = "0xF94144", VA = "0xF94144")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xF94188", Offset = "0xF94188", VA = "0xF94188")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xF941CC", Offset = "0xF941CC", VA = "0xF941CC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000027")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000028")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000029")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x600002A")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x600002B")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xF94244", Offset = "0xF94244", VA = "0xF94244")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xF94248", Offset = "0xF94248", VA = "0xF94248")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xF9424C", Offset = "0xF9424C", VA = "0xF9424C")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xF94250", Offset = "0xF94250", VA = "0xF94250")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xF94348", Offset = "0xF94348", VA = "0xF94348")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xF94764", Offset = "0xF94764", VA = "0xF94764", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xF9476C", Offset = "0xF9476C", VA = "0xF9476C", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xF94958", Offset = "0xF94958", VA = "0xF94958", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xF94BBC", Offset = "0xF94BBC", VA = "0xF94BBC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xF94ED4", Offset = "0xF94ED4", VA = "0xF94ED4", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xF94560", Offset = "0xF94560", VA = "0xF94560")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xF94618", Offset = "0xF94618", VA = "0xF94618")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xF95134", Offset = "0xF95134", VA = "0xF95134")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class TQ
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xF95190", Offset = "0xF95190", VA = "0xF95190")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class AvatarUtility
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0xF951F4", Offset = "0xF951F4", VA = "0xF951F4")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xF95444", Offset = "0xF95444", VA = "0xF95444")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xF95424", Offset = "0xF95424", VA = "0xF95424")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xF95A9C", Offset = "0xF95A9C", VA = "0xF95A9C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0xF95AA4", Offset = "0xF95AA4", VA = "0xF95AA4")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xF95ADC", Offset = "0xF95ADC", VA = "0xF95ADC")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xF95EA0", Offset = "0xF95EA0", VA = "0xF95EA0")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xF96080", Offset = "0xF96080", VA = "0xF96080")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xF96084", Offset = "0xF96084", VA = "0xF96084")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xF96218", Offset = "0xF96218", VA = "0xF96218")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xF964D4", Offset = "0xF964D4", VA = "0xF964D4")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xF96390", Offset = "0xF96390", VA = "0xF96390")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xF9665C", Offset = "0xF9665C", VA = "0xF9665C")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xF969EC", Offset = "0xF969EC", VA = "0xF969EC")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xF96ADC", Offset = "0xF96ADC", VA = "0xF96ADC")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xF96BC0", Offset = "0xF96BC0", VA = "0xF96BC0")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xF96B44", Offset = "0xF96B44", VA = "0xF96B44")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xF96C28", Offset = "0xF96C28", VA = "0xF96C28")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xF96CD0", Offset = "0xF96CD0", VA = "0xF96CD0")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xF96FBC", Offset = "0xF96FBC", VA = "0xF96FBC")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xF97020", Offset = "0xF97020", VA = "0xF97020")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xF97AB4", Offset = "0xF97AB4", VA = "0xF97AB4")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xF97B5C", Offset = "0xF97B5C", VA = "0xF97B5C")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xF97A54", Offset = "0xF97A54", VA = "0xF97A54")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xF97C50", Offset = "0xF97C50", VA = "0xF97C50")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xF97C8C", Offset = "0xF97C8C", VA = "0xF97C8C")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class BakerTransform
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xF946D0", Offset = "0xF946D0", VA = "0xF946D0")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xF94944", Offset = "0xF94944", VA = "0xF94944")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xF94C20", Offset = "0xF94C20", VA = "0xF94C20")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xF97C94", Offset = "0xF97C94", VA = "0xF97C94")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xF9483C", Offset = "0xF9483C", VA = "0xF9483C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xF97F1C", Offset = "0xF97F1C", VA = "0xF97F1C")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xF94F40", Offset = "0xF94F40", VA = "0xF94F40")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xF949C4", Offset = "0xF949C4", VA = "0xF949C4")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(1f, 9f)]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xF97F84", Offset = "0xF97F84", VA = "0xF97F84")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xF9843C", Offset = "0xF9843C", VA = "0xF9843C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xF98458", Offset = "0xF98458", VA = "0xF98458", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xF98534", Offset = "0xF98534", VA = "0xF98534", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xF985F0", Offset = "0xF985F0", VA = "0xF985F0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xF98790", Offset = "0xF98790", VA = "0xF98790", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xF98AA4", Offset = "0xF98AA4", VA = "0xF98AA4")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xF98B7C", Offset = "0xF98B7C", VA = "0xF98B7C")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000010")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000088")]
			Update,
			[Token(Token = "0x4000089")]
			FixedUpdate,
			[Token(Token = "0x400008A")]
			LateUpdate,
			[Token(Token = "0x400008B")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0xF98C20", Offset = "0xF98C20", VA = "0xF98C20")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0xF98C28", Offset = "0xF98C28", VA = "0xF98C28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xF98C30", Offset = "0xF98C30", VA = "0xF98C30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xF98C38", Offset = "0xF98C38", VA = "0xF98C38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xF98C40", Offset = "0xF98C40", VA = "0xF98C40")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xF98C48", Offset = "0xF98C48", VA = "0xF98C48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xF996A0", Offset = "0xF996A0", VA = "0xF996A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xF98C50", Offset = "0xF98C50", VA = "0xF98C50")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xF98C88", Offset = "0xF98C88", VA = "0xF98C88")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xF98C90", Offset = "0xF98C90", VA = "0xF98C90", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xF98DB8", Offset = "0xF98DB8", VA = "0xF98DB8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xF98E00", Offset = "0xF98E00", VA = "0xF98E00", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xF98E58", Offset = "0xF98E58", VA = "0xF98E58", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xF98EB0", Offset = "0xF98EB0", VA = "0xF98EB0")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xF98DE4", Offset = "0xF98DE4", VA = "0xF98DE4")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xF9903C", Offset = "0xF9903C", VA = "0xF9903C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xF99664", Offset = "0xF99664", VA = "0xF99664")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xF9970C", Offset = "0xF9970C", VA = "0xF9970C")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xF997D4", Offset = "0xF997D4", VA = "0xF997D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xF99800", Offset = "0xF99800", VA = "0xF99800")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xF99A24", Offset = "0xF99A24", VA = "0xF99A24")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xF99A60", Offset = "0xF99A60", VA = "0xF99A60")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public enum Axis
	{
		[Token(Token = "0x4000092")]
		X,
		[Token(Token = "0x4000093")]
		Y,
		[Token(Token = "0x4000094")]
		Z
	}
	[Token(Token = "0x2000013")]
	public class AxisTools
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0xF99A7C", Offset = "0xF99A7C", VA = "0xF99A7C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xF99B5C", Offset = "0xF99B5C", VA = "0xF99B5C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xF99B94", Offset = "0xF99B94", VA = "0xF99B94")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xF99CDC", Offset = "0xF99CDC", VA = "0xF99CDC")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xF99C90", Offset = "0xF99C90", VA = "0xF99C90")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xF99DD8", Offset = "0xF99DD8", VA = "0xF99DD8")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xF99E1C", Offset = "0xF99E1C", VA = "0xF99E1C")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xF9A2A8", Offset = "0xF9A2A8", VA = "0xF9A2A8")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000015")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400009B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000087")]
			[Address(RVA = "0xF9A5A4", Offset = "0xF9A5A4", VA = "0xF9A5A4")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xF9A2F0", Offset = "0xF9A2F0", VA = "0xF9A2F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xF9A618", Offset = "0xF9A618", VA = "0xF9A618")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xF9A2B0", Offset = "0xF9A2B0", VA = "0xF9A2B0")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000016")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000017")]
		public enum BoneType
		{
			[Token(Token = "0x40000AF")]
			Unassigned,
			[Token(Token = "0x40000B0")]
			Spine,
			[Token(Token = "0x40000B1")]
			Head,
			[Token(Token = "0x40000B2")]
			Arm,
			[Token(Token = "0x40000B3")]
			Leg,
			[Token(Token = "0x40000B4")]
			Tail,
			[Token(Token = "0x40000B5")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000018")]
		public enum BoneSide
		{
			[Token(Token = "0x40000B7")]
			Center,
			[Token(Token = "0x40000B8")]
			Left,
			[Token(Token = "0x40000B9")]
			Right
		}

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xF9A8CC", Offset = "0xF9A8CC", VA = "0xF9A8CC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xF9AB90", Offset = "0xF9AB90", VA = "0xF9AB90")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xF9ADC4", Offset = "0xF9ADC4", VA = "0xF9ADC4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xF9AE38", Offset = "0xF9AE38", VA = "0xF9AE38")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xF9AECC", Offset = "0xF9AECC", VA = "0xF9AECC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xF9AA78", Offset = "0xF9AA78", VA = "0xF9AA78")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xF9AD3C", Offset = "0xF9AD3C", VA = "0xF9AD3C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xF9B604", Offset = "0xF9B604", VA = "0xF9B604")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xF9B45C", Offset = "0xF9B45C", VA = "0xF9B45C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xF9B530", Offset = "0xF9B530", VA = "0xF9B530")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xF9B0B4", Offset = "0xF9B0B4", VA = "0xF9B0B4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xF9B150", Offset = "0xF9B150", VA = "0xF9B150")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xF9B1EC", Offset = "0xF9B1EC", VA = "0xF9B1EC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xF9B288", Offset = "0xF9B288", VA = "0xF9B288")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xF9B324", Offset = "0xF9B324", VA = "0xF9B324")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xF9B3C0", Offset = "0xF9B3C0", VA = "0xF9B3C0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xF9B7EC", Offset = "0xF9B7EC", VA = "0xF9B7EC")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xF9AFE0", Offset = "0xF9AFE0", VA = "0xF9AFE0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xF9B768", Offset = "0xF9B768", VA = "0xF9B768")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xF9B84C", Offset = "0xF9B84C", VA = "0xF9B84C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xF9B90C", Offset = "0xF9B90C", VA = "0xF9B90C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xF9B6F4", Offset = "0xF9B6F4", VA = "0xF9B6F4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xF9B684", Offset = "0xF9B684", VA = "0xF9B684")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class BipedReferences
	{
		[Token(Token = "0x200001A")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60000B9")]
				[Address(RVA = "0xFA1220", Offset = "0xFA1220", VA = "0xFA1220")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xFA120C", Offset = "0xFA120C", VA = "0xFA120C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xF9D904", Offset = "0xF9D904", VA = "0xF9D904", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xF9DC60", Offset = "0xF9DC60", VA = "0xF9DC60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xF9DC70", Offset = "0xF9DC70", VA = "0xF9DC70", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xF9DFFC", Offset = "0xF9DFFC", VA = "0xF9DFFC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xF9E38C", Offset = "0xF9E38C", VA = "0xF9E38C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xF9E9B0", Offset = "0xF9E9B0", VA = "0xF9E9B0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xF9E5EC", Offset = "0xF9E5EC", VA = "0xF9E5EC")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xF9F1AC", Offset = "0xF9F1AC", VA = "0xF9F1AC")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xF9F28C", Offset = "0xF9F28C", VA = "0xF9F28C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xF9FD04", Offset = "0xF9FD04", VA = "0xF9FD04")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xF9FB24", Offset = "0xF9FB24", VA = "0xF9FB24")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xF9F8C4", Offset = "0xF9F8C4", VA = "0xF9F8C4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xF9F328", Offset = "0xF9F328", VA = "0xF9F328")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xF9FC18", Offset = "0xF9FC18", VA = "0xF9FC18")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xF9FDE4", Offset = "0xF9FDE4", VA = "0xF9FDE4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xFA08A4", Offset = "0xFA08A4", VA = "0xFA08A4")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xFA0364", Offset = "0xFA0364", VA = "0xFA0364")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xFA0B78", Offset = "0xFA0B78", VA = "0xFA0B78")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xFA06B8", Offset = "0xFA06B8", VA = "0xFA06B8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xFA0B80", Offset = "0xFA0B80", VA = "0xFA0B80")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xFA0B88", Offset = "0xFA0B88", VA = "0xFA0B88")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xFA0D3C", Offset = "0xFA0D3C", VA = "0xFA0D3C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xFA11A4", Offset = "0xFA11A4", VA = "0xFA11A4")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xF9E584", Offset = "0xF9E584", VA = "0xF9E584")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xFA1228", Offset = "0xFA1228", VA = "0xFA1228")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xFA1230", Offset = "0xFA1230", VA = "0xFA1230")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xFA1328", Offset = "0xFA1328", VA = "0xFA1328")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Hierarchy
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xFA1120", Offset = "0xFA1120", VA = "0xFA1120")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xFA1014", Offset = "0xFA1014", VA = "0xFA1014")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xF9F404", Offset = "0xF9F404", VA = "0xF9F404")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xF9FA14", Offset = "0xF9FA14", VA = "0xF9FA14")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xF9F684", Offset = "0xF9F684", VA = "0xF9F684")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xFA1338", Offset = "0xFA1338", VA = "0xFA1338")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xF9F534", Offset = "0xF9F534", VA = "0xF9F534")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xFA142C", Offset = "0xFA142C", VA = "0xFA142C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xFA1798", Offset = "0xFA1798", VA = "0xFA1798")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xFA1590", Offset = "0xFA1590", VA = "0xFA1590")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xFA1920", Offset = "0xFA1920", VA = "0xFA1920")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xFA1928", Offset = "0xFA1928", VA = "0xFA1928")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xFA1990", Offset = "0xFA1990", VA = "0xFA1990")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000D3")]
		None,
		[Token(Token = "0x40000D4")]
		InOutCubic,
		[Token(Token = "0x40000D5")]
		InOutQuintic,
		[Token(Token = "0x40000D6")]
		InOutSine,
		[Token(Token = "0x40000D7")]
		InQuintic,
		[Token(Token = "0x40000D8")]
		InQuartic,
		[Token(Token = "0x40000D9")]
		InCubic,
		[Token(Token = "0x40000DA")]
		InQuadratic,
		[Token(Token = "0x40000DB")]
		InElastic,
		[Token(Token = "0x40000DC")]
		InElasticSmall,
		[Token(Token = "0x40000DD")]
		InElasticBig,
		[Token(Token = "0x40000DE")]
		InSine,
		[Token(Token = "0x40000DF")]
		InBack,
		[Token(Token = "0x40000E0")]
		OutQuintic,
		[Token(Token = "0x40000E1")]
		OutQuartic,
		[Token(Token = "0x40000E2")]
		OutCubic,
		[Token(Token = "0x40000E3")]
		OutInCubic,
		[Token(Token = "0x40000E4")]
		OutInQuartic,
		[Token(Token = "0x40000E5")]
		OutElastic,
		[Token(Token = "0x40000E6")]
		OutElasticSmall,
		[Token(Token = "0x40000E7")]
		OutElasticBig,
		[Token(Token = "0x40000E8")]
		OutSine,
		[Token(Token = "0x40000E9")]
		OutBack,
		[Token(Token = "0x40000EA")]
		OutBackCubic,
		[Token(Token = "0x40000EB")]
		OutBackQuartic,
		[Token(Token = "0x40000EC")]
		BackInCubic,
		[Token(Token = "0x40000ED")]
		BackInQuartic
	}
	[Token(Token = "0x2000020")]
	public class Interp
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xFA19F8", Offset = "0xFA19F8", VA = "0xFA19F8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xFA2380", Offset = "0xFA2380", VA = "0xFA2380")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xFA23F0", Offset = "0xFA23F0", VA = "0xFA23F0")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xFA1DF8", Offset = "0xFA1DF8", VA = "0xFA1DF8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xFA1E04", Offset = "0xFA1E04", VA = "0xFA1E04")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xFA1E28", Offset = "0xFA1E28", VA = "0xFA1E28")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xFA1E64", Offset = "0xFA1E64", VA = "0xFA1E64")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xFA1E7C", Offset = "0xFA1E7C", VA = "0xFA1E7C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xFA1E90", Offset = "0xFA1E90", VA = "0xFA1E90")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xFA1EA4", Offset = "0xFA1EA4", VA = "0xFA1EA4")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xFA1EB4", Offset = "0xFA1EB4", VA = "0xFA1EB4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xFA1EFC", Offset = "0xFA1EFC", VA = "0xFA1EFC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xFA1F34", Offset = "0xFA1F34", VA = "0xFA1F34")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xFA1F5C", Offset = "0xFA1F5C", VA = "0xFA1F5C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xFA2460", Offset = "0xFA2460", VA = "0xFA2460")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xFA1F90", Offset = "0xFA1F90", VA = "0xFA1F90")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xFA1FB8", Offset = "0xFA1FB8", VA = "0xFA1FB8")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xFA1FE8", Offset = "0xFA1FE8", VA = "0xFA1FE8")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xFA201C", Offset = "0xFA201C", VA = "0xFA201C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xFA2060", Offset = "0xFA2060", VA = "0xFA2060")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xFA20C4", Offset = "0xFA20C4", VA = "0xFA20C4")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xFA2128", Offset = "0xFA2128", VA = "0xFA2128")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xFA217C", Offset = "0xFA217C", VA = "0xFA217C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xFA21D0", Offset = "0xFA21D0", VA = "0xFA21D0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xFA2208", Offset = "0xFA2208", VA = "0xFA2208")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xFA223C", Offset = "0xFA223C", VA = "0xFA223C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xFA2494", Offset = "0xFA2494", VA = "0xFA2494")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xFA2280", Offset = "0xFA2280", VA = "0xFA2280")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xFA2310", Offset = "0xFA2310", VA = "0xFA2310")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xFA2340", Offset = "0xFA2340", VA = "0xFA2340")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xFA2524", Offset = "0xFA2524", VA = "0xFA2524")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xFA252C", Offset = "0xFA252C", VA = "0xFA252C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xFA2594", Offset = "0xFA2594", VA = "0xFA2594")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000022")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xFA25FC", Offset = "0xFA25FC", VA = "0xFA25FC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xFA2648", Offset = "0xFA2648", VA = "0xFA2648")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xFA2704", Offset = "0xFA2704", VA = "0xFA2704")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xFA265C", Offset = "0xFA265C", VA = "0xFA265C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xFA2718", Offset = "0xFA2718", VA = "0xFA2718")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xFA27A8", Offset = "0xFA27A8", VA = "0xFA27A8")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xFA27D0", Offset = "0xFA27D0", VA = "0xFA27D0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xFA281C", Offset = "0xFA281C", VA = "0xFA281C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xFA2884", Offset = "0xFA2884", VA = "0xFA2884")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xFA29D8", Offset = "0xFA29D8", VA = "0xFA29D8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xFA2B10", Offset = "0xFA2B10", VA = "0xFA2B10")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xFA2B68", Offset = "0xFA2B68", VA = "0xFA2B68")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	public static class QuaTools
	{
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xFA2B8C", Offset = "0xFA2B8C", VA = "0xFA2B8C")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xFA2BE4", Offset = "0xFA2BE4", VA = "0xFA2BE4")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xFA2D14", Offset = "0xFA2D14", VA = "0xFA2D14")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xFA2E94", Offset = "0xFA2E94", VA = "0xFA2E94")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xFA2F70", Offset = "0xFA2F70", VA = "0xFA2F70")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xFA304C", Offset = "0xFA304C", VA = "0xFA304C")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xFA3264", Offset = "0xFA3264", VA = "0xFA3264")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xFA32B0", Offset = "0xFA32B0", VA = "0xFA32B0")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xFA32FC", Offset = "0xFA32FC", VA = "0xFA32FC")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xFA3400", Offset = "0xFA3400", VA = "0xFA3400")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xFA3504", Offset = "0xFA3504", VA = "0xFA3504")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xFA3618", Offset = "0xFA3618", VA = "0xFA3618")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xFA36C0", Offset = "0xFA36C0", VA = "0xFA36C0")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xFA37CC", Offset = "0xFA37CC", VA = "0xFA37CC")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xFA3934", Offset = "0xFA3934", VA = "0xFA3934")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xFA3B18", Offset = "0xFA3B18", VA = "0xFA3B18")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xFA3BE8", Offset = "0xFA3BE8", VA = "0xFA3BE8")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xFA3D6C", Offset = "0xFA3D6C", VA = "0xFA3D6C")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xFA3E78", Offset = "0xFA3E78", VA = "0xFA3E78")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000024")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000D")]
		public static T instance
		{
			[Token(Token = "0x600010A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010B")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600010C")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000E")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xFA3FEC", Offset = "0xFA3FEC", VA = "0xFA3FEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xFA42AC", Offset = "0xFA42AC", VA = "0xFA42AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xFA3ED0", Offset = "0xFA3ED0", VA = "0xFA3ED0")]
		public void Disable()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xFA3F64", Offset = "0xFA3F64", VA = "0xFA3F64", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xFA3F68", Offset = "0xFA3F68", VA = "0xFA3F68", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xFA3F6C", Offset = "0xFA3F6C", VA = "0xFA3F6C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xFA3F70", Offset = "0xFA3F70", VA = "0xFA3F70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xFA3FE8", Offset = "0xFA3FE8", VA = "0xFA3FE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xFA3F98", Offset = "0xFA3F98", VA = "0xFA3F98")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xFA4270", Offset = "0xFA4270", VA = "0xFA4270")]
		private void Update()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xFA40B8", Offset = "0xFA40B8", VA = "0xFA40B8")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xFA4344", Offset = "0xFA4344", VA = "0xFA4344")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xFA4390", Offset = "0xFA4390", VA = "0xFA4390")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xFA43DC", Offset = "0xFA43DC", VA = "0xFA43DC")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xFA4414", Offset = "0xFA4414", VA = "0xFA4414")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xFA4424", Offset = "0xFA4424", VA = "0xFA4424")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xFA44D8", Offset = "0xFA44D8", VA = "0xFA44D8")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xFA458C", Offset = "0xFA458C", VA = "0xFA458C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xFA4640", Offset = "0xFA4640", VA = "0xFA4640")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public static class V2Tools
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xFA4648", Offset = "0xFA4648", VA = "0xFA4648")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xFA4650", Offset = "0xFA4650", VA = "0xFA4650")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xFA46E0", Offset = "0xFA46E0", VA = "0xFA46E0")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xFA4774", Offset = "0xFA4774", VA = "0xFA4774")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xFA4824", Offset = "0xFA4824", VA = "0xFA4824")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000028")]
	public static class V3Tools
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0xFA4880", Offset = "0xFA4880", VA = "0xFA4880")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xFA48A0", Offset = "0xFA48A0", VA = "0xFA48A0")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xFA4974", Offset = "0xFA4974", VA = "0xFA4974")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xFA4A2C", Offset = "0xFA4A2C", VA = "0xFA4A2C")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xFA4A88", Offset = "0xFA4A88", VA = "0xFA4A88")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xFA4AE4", Offset = "0xFA4AE4", VA = "0xFA4AE4")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xFA4BFC", Offset = "0xFA4BFC", VA = "0xFA4BFC")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xFA4C58", Offset = "0xFA4C58", VA = "0xFA4C58")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xFA4C90", Offset = "0xFA4C90", VA = "0xFA4C90")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xFA4DE0", Offset = "0xFA4DE0", VA = "0xFA4DE0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xFA4F5C", Offset = "0xFA4F5C", VA = "0xFA4F5C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xFA518C", Offset = "0xFA518C", VA = "0xFA518C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xFA53DC", Offset = "0xFA53DC", VA = "0xFA53DC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xFA5634", Offset = "0xFA5634", VA = "0xFA5634")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xFA57E0", Offset = "0xFA57E0", VA = "0xFA57E0")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xFA59D8", Offset = "0xFA59D8", VA = "0xFA59D8")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xFA5A54", Offset = "0xFA5A54", VA = "0xFA5A54")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xFA5AE4", Offset = "0xFA5AE4", VA = "0xFA5AE4")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xFA5B7C", Offset = "0xFA5B7C", VA = "0xFA5B7C")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xFA5B6C", Offset = "0xFA5B6C", VA = "0xFA5B6C")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000029")]
	public static class Warning
	{
		[Token(Token = "0x200002A")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xFA5BF8", Offset = "0xFA5BF8", VA = "0xFA5BF8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xF9F0F8", Offset = "0xF9F0F8", VA = "0xF9F0F8")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200002B")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xFA5DA4", Offset = "0xFA5DA4", VA = "0xFA5DA4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xFA5DE8", Offset = "0xFA5DE8", VA = "0xFA5DE8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xFA5E2C", Offset = "0xFA5E2C", VA = "0xFA5E2C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xFA5E70", Offset = "0xFA5E70", VA = "0xFA5E70")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xFA5EB4", Offset = "0xFA5EB4", VA = "0xFA5EB4")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xFA5F4C", Offset = "0xFA5F4C", VA = "0xFA5F4C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xFA5F68", Offset = "0xFA5F68", VA = "0xFA5F68")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xFA5F94", Offset = "0xFA5F94", VA = "0xFA5F94")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xFA5FC0", Offset = "0xFA5FC0", VA = "0xFA5FC0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xFA5FFC", Offset = "0xFA5FFC", VA = "0xFA5FFC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xFA603C", Offset = "0xFA603C", VA = "0xFA603C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xFA605C", Offset = "0xFA605C", VA = "0xFA605C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xFA607C", Offset = "0xFA607C", VA = "0xFA607C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xFA60A0", Offset = "0xFA60A0", VA = "0xFA60A0")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xFA60C8", Offset = "0xFA60C8", VA = "0xFA60C8")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xFA60F0", Offset = "0xFA60F0", VA = "0xFA60F0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xFA5ED0", Offset = "0xFA5ED0", VA = "0xFA5ED0")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xFA6114", Offset = "0xFA6114", VA = "0xFA6114")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xFA6120", Offset = "0xFA6120", VA = "0xFA6120")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xFA612C", Offset = "0xFA612C", VA = "0xFA612C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xFA626C", Offset = "0xFA626C", VA = "0xFA626C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xFA6310", Offset = "0xFA6310", VA = "0xFA6310", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xFA64CC", Offset = "0xFA64CC", VA = "0xFA64CC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xFA6658", Offset = "0xFA6658", VA = "0xFA6658")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xFA667C", Offset = "0xFA667C", VA = "0xFA667C")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000010")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xFA7718", Offset = "0xFA7718", VA = "0xFA7718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xFA7848", Offset = "0xFA7848", VA = "0xFA7848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xFA79FC", Offset = "0xFA79FC", VA = "0xFA79FC")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xFA7B1C", Offset = "0xFA7B1C", VA = "0xFA7B1C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000012")]
		public bool isValid
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xFA7CB0", Offset = "0xFA7CB0", VA = "0xFA7CB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015D")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xFA7D10", Offset = "0xFA7D10", VA = "0xFA7D10")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xFA7D18", Offset = "0xFA7D18", VA = "0xFA7D18", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xFA7DB0", Offset = "0xFA7DB0", VA = "0xFA7DB0")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xFA7DB8", Offset = "0xFA7DB8", VA = "0xFA7DB8")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000013")]
		private bool positionChanged
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xFA7EE4", Offset = "0xFA7EE4", VA = "0xFA7EE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xFA7DE0", Offset = "0xFA7DE0", VA = "0xFA7DE0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xFA7F40", Offset = "0xFA7F40", VA = "0xFA7F40")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xFA7F48", Offset = "0xFA7F48", VA = "0xFA7F48")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xFA7F70", Offset = "0xFA7F70", VA = "0xFA7F70", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xFA7FEC", Offset = "0xFA7FEC", VA = "0xFA7FEC")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xFA7FF4", Offset = "0xFA7FF4", VA = "0xFA7FF4")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000014")]
		private bool rotationChanged
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xFA8120", Offset = "0xFA8120", VA = "0xFA8120")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xFA801C", Offset = "0xFA801C", VA = "0xFA801C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xFA8178", Offset = "0xFA8178", VA = "0xFA8178")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xFA8180", Offset = "0xFA8180", VA = "0xFA8180")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class Constraints
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xFA81A8", Offset = "0xFA81A8", VA = "0xFA81A8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xFA8208", Offset = "0xFA8208", VA = "0xFA8208")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xFA8258", Offset = "0xFA8258", VA = "0xFA8258")]
		public void Update()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xFA7CA8", Offset = "0xFA7CA8", VA = "0xFA7CA8")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000034")]
		public enum DOF
		{
			[Token(Token = "0x400012E")]
			One,
			[Token(Token = "0x400012F")]
			Three
		}

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		[Tooltip("Master Weight for the finger.")]
		public float weight;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		public float rotationWeight;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xFA8550", Offset = "0xFA8550", VA = "0xFA8550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xFA8558", Offset = "0xFA8558", VA = "0xFA8558")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xFA8564", Offset = "0xFA8564", VA = "0xFA8564")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xFA8584", Offset = "0xFA8584", VA = "0xFA8584")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xFA85A4", Offset = "0xFA85A4", VA = "0xFA85A4")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xFA85C4", Offset = "0xFA85C4", VA = "0xFA85C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xFA85E4", Offset = "0xFA85E4", VA = "0xFA85E4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xFA86D0", Offset = "0xFA86D0", VA = "0xFA86D0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xFA8D3C", Offset = "0xFA8D3C", VA = "0xFA8D3C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xFA8E08", Offset = "0xFA8E08", VA = "0xFA8E08")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xFA8EC0", Offset = "0xFA8EC0", VA = "0xFA8EC0")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xFA9458", Offset = "0xFA9458", VA = "0xFA9458")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xFA9468", Offset = "0xFA9468", VA = "0xFA9468")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xFA9470", Offset = "0xFA9470", VA = "0xFA9470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xFA947C", Offset = "0xFA947C", VA = "0xFA947C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xFA94F0", Offset = "0xFA94F0", VA = "0xFA94F0")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xFA97FC", Offset = "0xFA97FC", VA = "0xFA97FC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xFA9968", Offset = "0xFA9968", VA = "0xFA9968")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xFA9714", Offset = "0xFA9714", VA = "0xFA9714")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xFA9ACC", Offset = "0xFA9ACC", VA = "0xFA9ACC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xFA9B74", Offset = "0xFA9B74", VA = "0xFA9B74")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xFA9BD8", Offset = "0xFA9BD8", VA = "0xFA9BD8")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xFA9C40", Offset = "0xFA9C40", VA = "0xFA9C40")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xFA9C9C", Offset = "0xFA9C9C", VA = "0xFA9C9C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xFA9CA0", Offset = "0xFA9CA0", VA = "0xFA9CA0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xFA9CB4", Offset = "0xFA9CB4", VA = "0xFA9CB4")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000037")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xFA9D14", Offset = "0xFA9D14", VA = "0xFA9D14")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xFA9D1C", Offset = "0xFA9D1C", VA = "0xFA9D1C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600018B")]
		public abstract void ResetPosition();

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xFA9D28", Offset = "0xFA9D28", VA = "0xFA9D28")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xFA9FD8", Offset = "0xFA9FD8", VA = "0xFA9FD8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xFA9DEC", Offset = "0xFA9DEC", VA = "0xFA9DEC")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xFAA000", Offset = "0xFAA000", VA = "0xFAA000")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000192")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000193")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xFAA174", Offset = "0xFAA174", VA = "0xFAA174")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xFAA37C", Offset = "0xFAA37C", VA = "0xFAA37C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xFAA3C0", Offset = "0xFAA3C0", VA = "0xFAA3C0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xFAA404", Offset = "0xFAA404", VA = "0xFAA404", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xFAA4E4", Offset = "0xFAA4E4", VA = "0xFAA4E4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xFAA584", Offset = "0xFAA584", VA = "0xFAA584")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xFAA5D8", Offset = "0xFAA5D8", VA = "0xFAA5D8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xFAAB4C", Offset = "0xFAAB4C", VA = "0xFAAB4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xFAAB8C", Offset = "0xFAAB8C", VA = "0xFAAB8C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xFAB204", Offset = "0xFAB204", VA = "0xFAB204")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xFAB32C", Offset = "0xFAB32C", VA = "0xFAB32C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xFAB4FC", Offset = "0xFAB4FC", VA = "0xFAB4FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xFAB6A4", Offset = "0xFAB6A4", VA = "0xFAB6A4")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200003A")]
		public class SpineEffector
		{
			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xFAC33C", Offset = "0xFAC33C", VA = "0xFAC33C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xFAC34C", Offset = "0xFAC34C", VA = "0xFAC34C")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xFAB730", Offset = "0xFAB730", VA = "0xFAB730")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xFAB774", Offset = "0xFAB774", VA = "0xFAB774", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xFAB7B8", Offset = "0xFAB7B8", VA = "0xFAB7B8", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xFAB7FC", Offset = "0xFAB7FC", VA = "0xFAB7FC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xFAB864", Offset = "0xFAB864", VA = "0xFAB864")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xFAB8EC", Offset = "0xFAB8EC", VA = "0xFAB8EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xFABB5C", Offset = "0xFABB5C", VA = "0xFABB5C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xFABB68", Offset = "0xFABB68", VA = "0xFABB68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xFAB948", Offset = "0xFAB948", VA = "0xFAB948")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xFABB74", Offset = "0xFABB74", VA = "0xFABB74")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xFABEE4", Offset = "0xFABEE4", VA = "0xFABEE4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xFAC068", Offset = "0xFAC068", VA = "0xFAC068")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xFAC19C", Offset = "0xFAC19C", VA = "0xFAC19C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xFAC2B0", Offset = "0xFAC2B0", VA = "0xFAC2B0")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xFAC390", Offset = "0xFAC390", VA = "0xFAC390", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xFAC3D4", Offset = "0xFAC3D4", VA = "0xFAC3D4", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xFAC418", Offset = "0xFAC418", VA = "0xFAC418", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xFAC430", Offset = "0xFAC430", VA = "0xFAC430")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xFAC650", Offset = "0xFAC650", VA = "0xFAC650")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xFAC730", Offset = "0xFAC730", VA = "0xFAC730")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xFACE1C", Offset = "0xFACE1C", VA = "0xFACE1C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xFAD27C", Offset = "0xFAD27C", VA = "0xFAD27C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xFAD428", Offset = "0xFAD428", VA = "0xFAD428")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xFAD7B0", Offset = "0xFAD7B0", VA = "0xFAD7B0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xFAD988", Offset = "0xFAD988", VA = "0xFAD988")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xFADB8C", Offset = "0xFADB8C", VA = "0xFADB8C")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200003D")]
		public struct Foot
		{
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xFAE6E8", Offset = "0xFAE6E8", VA = "0xFAE6E8")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xFADC18", Offset = "0xFADC18", VA = "0xFADC18", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xFADC5C", Offset = "0xFADC5C", VA = "0xFADC5C", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xFADCA0", Offset = "0xFADCA0", VA = "0xFADCA0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xFADCC8", Offset = "0xFADCC8", VA = "0xFADCC8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xFADDCC", Offset = "0xFADDCC", VA = "0xFADDCC")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xFADFC4", Offset = "0xFADFC4", VA = "0xFADFC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xFAE028", Offset = "0xFAE028", VA = "0xFAE028")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xFAE080", Offset = "0xFAE080", VA = "0xFAE080")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xFAE394", Offset = "0xFAE394", VA = "0xFAE394")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xFAE71C", Offset = "0xFAE71C", VA = "0xFAE71C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xFAE7AC", Offset = "0xFAE7AC", VA = "0xFAE7AC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xFAEBFC", Offset = "0xFAEBFC", VA = "0xFAEBFC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xFAF2BC", Offset = "0xFAF2BC", VA = "0xFAF2BC")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xFAF574", Offset = "0xFAF574", VA = "0xFAF574")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xFAF6A8", Offset = "0xFAF6A8", VA = "0xFAF6A8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xFAF970", Offset = "0xFAF970", VA = "0xFAF970")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xFAF9A0", Offset = "0xFAF9A0", VA = "0xFAF9A0")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xFAFB9C", Offset = "0xFAFB9C", VA = "0xFAFB9C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xFAFCCC", Offset = "0xFAFCCC", VA = "0xFAFCCC")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xFAFD10", Offset = "0xFAFD10", VA = "0xFAFD10", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xFAFD54", Offset = "0xFAFD54", VA = "0xFAFD54", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xFAFD98", Offset = "0xFAFD98", VA = "0xFAFD98", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xFAFDB0", Offset = "0xFAFDB0", VA = "0xFAFDB0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xFAFE38", Offset = "0xFAFE38", VA = "0xFAFE38")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xFAFE8C", Offset = "0xFAFE8C", VA = "0xFAFE8C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xFB00C4", Offset = "0xFB00C4", VA = "0xFB00C4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xFB02B8", Offset = "0xFB02B8", VA = "0xFB02B8")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xFB033C", Offset = "0xFB033C", VA = "0xFB033C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xFB05D8", Offset = "0xFB05D8", VA = "0xFB05D8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xFB070C", Offset = "0xFB070C", VA = "0xFB070C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xFB08A4", Offset = "0xFB08A4", VA = "0xFB08A4")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000040")]
		public enum Quality
		{
			[Token(Token = "0x4000195")]
			Fastest,
			[Token(Token = "0x4000196")]
			Simple,
			[Token(Token = "0x4000197")]
			Best
		}

		[Token(Token = "0x2000041")]
		public class Leg
		{
			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000022")]
			public bool isGrounded
			{
				[Token(Token = "0x60001F9")]
				[Address(RVA = "0xFB1E38", Offset = "0xFB1E38", VA = "0xFB1E38")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001FA")]
				[Address(RVA = "0xFB1E40", Offset = "0xFB1E40", VA = "0xFB1E40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001FB")]
				[Address(RVA = "0xFB1E4C", Offset = "0xFB1E4C", VA = "0xFB1E4C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001FC")]
				[Address(RVA = "0xFB1E58", Offset = "0xFB1E58", VA = "0xFB1E58")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001FD")]
				[Address(RVA = "0xFB1E64", Offset = "0xFB1E64", VA = "0xFB1E64")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001FE")]
				[Address(RVA = "0xFB1E6C", Offset = "0xFB1E6C", VA = "0xFB1E6C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001FF")]
				[Address(RVA = "0xFB1E78", Offset = "0xFB1E78", VA = "0xFB1E78")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000200")]
				[Address(RVA = "0xFB1E80", Offset = "0xFB1E80", VA = "0xFB1E80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000201")]
				[Address(RVA = "0xFB1E88", Offset = "0xFB1E88", VA = "0xFB1E88")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000202")]
				[Address(RVA = "0xFB1E94", Offset = "0xFB1E94", VA = "0xFB1E94")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x6000203")]
				[Address(RVA = "0xFB1EA0", Offset = "0xFB1EA0", VA = "0xFB1EA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000204")]
				[Address(RVA = "0xFB1EA8", Offset = "0xFB1EA8", VA = "0xFB1EA8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x6000205")]
				[Address(RVA = "0xFB1EB0", Offset = "0xFB1EB0", VA = "0xFB1EB0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000206")]
				[Address(RVA = "0xFB1EB8", Offset = "0xFB1EB8", VA = "0xFB1EB8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000207")]
				[Address(RVA = "0xFB1EC0", Offset = "0xFB1EC0", VA = "0xFB1EC0")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000208")]
				[Address(RVA = "0xFB1ED8", Offset = "0xFB1ED8", VA = "0xFB1ED8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000209")]
				[Address(RVA = "0xFB1EF8", Offset = "0xFB1EF8", VA = "0xFB1EF8")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600020A")]
				[Address(RVA = "0xFB1F10", Offset = "0xFB1F10", VA = "0xFB1F10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x600020B")]
				[Address(RVA = "0xFB1F30", Offset = "0xFB1F30", VA = "0xFB1F30")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000211")]
				[Address(RVA = "0xFB2820", Offset = "0xFB2820", VA = "0xFB2820")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x600021A")]
				[Address(RVA = "0xFB2970", Offset = "0xFB2970", VA = "0xFB2970")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600020C")]
			[Address(RVA = "0xFB1F78", Offset = "0xFB1F78", VA = "0xFB1F78")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0xFB0DB8", Offset = "0xFB0DB8", VA = "0xFB0DB8")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600020E")]
			[Address(RVA = "0xFB1F8C", Offset = "0xFB1F8C", VA = "0xFB1F8C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0xFB1AA8", Offset = "0xFB1AA8", VA = "0xFB1AA8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0xFB0EA8", Offset = "0xFB0EA8", VA = "0xFB0EA8")]
			public void Process()
			{
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0xFB2430", Offset = "0xFB2430", VA = "0xFB2430")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000213")]
			[Address(RVA = "0xFB1FCC", Offset = "0xFB1FCC", VA = "0xFB1FCC")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0xFB28B4", Offset = "0xFB28B4", VA = "0xFB28B4")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000215")]
			[Address(RVA = "0xFB2298", Offset = "0xFB2298", VA = "0xFB2298")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0xFB2318", Offset = "0xFB2318", VA = "0xFB2318")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0xFB2920", Offset = "0xFB2920", VA = "0xFB2920")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0xFB2854", Offset = "0xFB2854", VA = "0xFB2854")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0xFB29FC", Offset = "0xFB29FC", VA = "0xFB29FC")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0xFB0D18", Offset = "0xFB0D18", VA = "0xFB0D18")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000042")]
		public class Pelvis
		{
			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700002E")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600021C")]
				[Address(RVA = "0xFB2BAC", Offset = "0xFB2BAC", VA = "0xFB2BAC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600021D")]
				[Address(RVA = "0xFB2BB8", Offset = "0xFB2BB8", VA = "0xFB2BB8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0xFB2BC4", Offset = "0xFB2BC4", VA = "0xFB2BC4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600021F")]
				[Address(RVA = "0xFB2BCC", Offset = "0xFB2BCC", VA = "0xFB2BCC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0xFB0E80", Offset = "0xFB0E80", VA = "0xFB0E80")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0xFB1A14", Offset = "0xFB1A14", VA = "0xFB1A14")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0xFB2BD4", Offset = "0xFB2BD4", VA = "0xFB2BD4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0xFB1828", Offset = "0xFB1828", VA = "0xFB1828")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0xFB0DB0", Offset = "0xFB0DB0", VA = "0xFB0DB0")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xFB08F8", Offset = "0xFB08F8", VA = "0xFB08F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xFB0900", Offset = "0xFB0900", VA = "0xFB0900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xFB0908", Offset = "0xFB0908", VA = "0xFB0908")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xFB0910", Offset = "0xFB0910", VA = "0xFB0910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xFB0918", Offset = "0xFB0918", VA = "0xFB0918")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xFB0920", Offset = "0xFB0920", VA = "0xFB0920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xFB092C", Offset = "0xFB092C", VA = "0xFB092C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xFB0934", Offset = "0xFB0934", VA = "0xFB0934")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xFB093C", Offset = "0xFB093C", VA = "0xFB093C")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xFB0954", Offset = "0xFB0954", VA = "0xFB0954")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xFB0974", Offset = "0xFB0974", VA = "0xFB0974")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xFAB2C4", Offset = "0xFAB2C4", VA = "0xFAB2C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xFB1B3C", Offset = "0xFB1B3C", VA = "0xFB1B3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xFB09BC", Offset = "0xFB09BC", VA = "0xFB09BC")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xFB0C1C", Offset = "0xFB0C1C", VA = "0xFB0C1C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xFAA8D8", Offset = "0xFAA8D8", VA = "0xFAA8D8")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xFAB004", Offset = "0xFAB004", VA = "0xFAB004")]
		public void Update()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xFACCA4", Offset = "0xFACCA4", VA = "0xFACCA4")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xFAA46C", Offset = "0xFAA46C", VA = "0xFAA46C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xFB0E90", Offset = "0xFB0E90", VA = "0xFB0E90")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xFB1BF0", Offset = "0xFB1BF0", VA = "0xFB1BF0")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xFB1C74", Offset = "0xFB1C74", VA = "0xFB1C74")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xFB1DC8", Offset = "0xFB1DC8", VA = "0xFB1DC8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xFAA22C", Offset = "0xFAA22C", VA = "0xFAA22C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xFB2C28", Offset = "0xFB2C28", VA = "0xFB2C28", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xFB2C6C", Offset = "0xFB2C6C", VA = "0xFB2C6C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xFB2CB0", Offset = "0xFB2CB0", VA = "0xFB2CB0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xFB2CF4", Offset = "0xFB2CF4", VA = "0xFB2CF4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xFB2D38", Offset = "0xFB2D38", VA = "0xFB2D38")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xFB2D7C", Offset = "0xFB2D7C", VA = "0xFB2D7C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xFB2D84", Offset = "0xFB2D84", VA = "0xFB2D84")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xFB2DF4", Offset = "0xFB2DF4", VA = "0xFB2DF4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xFB2E38", Offset = "0xFB2E38", VA = "0xFB2E38", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xFB2E7C", Offset = "0xFB2E7C", VA = "0xFB2E7C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xFB2EC0", Offset = "0xFB2EC0", VA = "0xFB2EC0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xFB2F04", Offset = "0xFB2F04", VA = "0xFB2F04", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xFB2F0C", Offset = "0xFB2F0C", VA = "0xFB2F0C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xFB2F74", Offset = "0xFB2F74", VA = "0xFB2F74", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xFB2FB8", Offset = "0xFB2FB8", VA = "0xFB2FB8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xFB2FFC", Offset = "0xFB2FFC", VA = "0xFB2FFC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xFB3040", Offset = "0xFB3040", VA = "0xFB3040")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xFB3084", Offset = "0xFB3084", VA = "0xFB3084", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xFB308C", Offset = "0xFB308C", VA = "0xFB308C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xFB30F4", Offset = "0xFB30F4", VA = "0xFB30F4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xFB3138", Offset = "0xFB3138", VA = "0xFB3138", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xFB317C", Offset = "0xFB317C", VA = "0xFB317C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xFB31C0", Offset = "0xFB31C0", VA = "0xFB31C0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xFB3204", Offset = "0xFB3204", VA = "0xFB3204", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xFB320C", Offset = "0xFB320C", VA = "0xFB320C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xFB3274", Offset = "0xFB3274", VA = "0xFB3274", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xFB32B8", Offset = "0xFB32B8", VA = "0xFB32B8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xFB32FC", Offset = "0xFB32FC", VA = "0xFB32FC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xFB3340", Offset = "0xFB3340", VA = "0xFB3340")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xFB3384", Offset = "0xFB3384", VA = "0xFB3384", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xFB338C", Offset = "0xFB338C", VA = "0xFB338C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xFB33F4", Offset = "0xFB33F4", VA = "0xFB33F4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xFB3438", Offset = "0xFB3438", VA = "0xFB3438", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xFB347C", Offset = "0xFB347C", VA = "0xFB347C")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xFB34C0", Offset = "0xFB34C0", VA = "0xFB34C0")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xFB3504", Offset = "0xFB3504", VA = "0xFB3504")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xFB3548", Offset = "0xFB3548", VA = "0xFB3548")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xFB358C", Offset = "0xFB358C", VA = "0xFB358C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xFB35B0", Offset = "0xFB35B0", VA = "0xFB35B0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xFB35B8", Offset = "0xFB35B8", VA = "0xFB35B8")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xFB3774", Offset = "0xFB3774", VA = "0xFB3774")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xFB3C24", Offset = "0xFB3C24", VA = "0xFB3C24")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xFB3C44", Offset = "0xFB3C44", VA = "0xFB3C44")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xFB3D1C", Offset = "0xFB3D1C", VA = "0xFB3D1C")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000251")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xFB3DB4", Offset = "0xFB3DB4", VA = "0xFB3DB4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xFB3E2C", Offset = "0xFB3E2C", VA = "0xFB3E2C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xFB3E9C", Offset = "0xFB3E9C", VA = "0xFB3E9C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000255")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000256")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xFB2DEC", Offset = "0xFB2DEC", VA = "0xFB2DEC")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xFB3EEC", Offset = "0xFB3EEC", VA = "0xFB3EEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xFB3F78", Offset = "0xFB3F78", VA = "0xFB3F78")]
		private void Start()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xFB3FDC", Offset = "0xFB3FDC", VA = "0xFB3FDC")]
		private void Update()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xFB407C", Offset = "0xFB407C", VA = "0xFB407C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xFB40A8", Offset = "0xFB40A8", VA = "0xFB40A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xFB4000", Offset = "0xFB4000", VA = "0xFB4000")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xFB412C", Offset = "0xFB412C", VA = "0xFB412C")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xFB4134", Offset = "0xFB4134", VA = "0xFB4134", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xFB4178", Offset = "0xFB4178", VA = "0xFB4178", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xFB41BC", Offset = "0xFB41BC", VA = "0xFB41BC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xFB4200", Offset = "0xFB4200", VA = "0xFB4200")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xFB4244", Offset = "0xFB4244", VA = "0xFB4244", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xFB424C", Offset = "0xFB424C", VA = "0xFB424C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xFB42B4", Offset = "0xFB42B4", VA = "0xFB42B4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xFB42F8", Offset = "0xFB42F8", VA = "0xFB42F8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xFB433C", Offset = "0xFB433C", VA = "0xFB433C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xFB4380", Offset = "0xFB4380", VA = "0xFB4380")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xFB43C4", Offset = "0xFB43C4", VA = "0xFB43C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xFB43CC", Offset = "0xFB43CC", VA = "0xFB43CC")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xFB4434", Offset = "0xFB4434", VA = "0xFB4434", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xFB4478", Offset = "0xFB4478", VA = "0xFB4478", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xFB44BC", Offset = "0xFB44BC", VA = "0xFB44BC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xFB4500", Offset = "0xFB4500", VA = "0xFB4500")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xFB4544", Offset = "0xFB4544", VA = "0xFB4544", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xFB454C", Offset = "0xFB454C", VA = "0xFB454C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xFB45B4", Offset = "0xFB45B4", VA = "0xFB45B4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xFB45F8", Offset = "0xFB45F8", VA = "0xFB45F8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xFB463C", Offset = "0xFB463C", VA = "0xFB463C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xFB4680", Offset = "0xFB4680", VA = "0xFB4680")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xFB46C4", Offset = "0xFB46C4", VA = "0xFB46C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xFB46CC", Offset = "0xFB46CC", VA = "0xFB46CC")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000050")]
		public class References
		{
			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Optional")]
			public Transform chest;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Optional")]
			public Transform rightShoulder;

			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000281")]
				[Address(RVA = "0xFB5000", Offset = "0xFB5000", VA = "0xFB5000")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000282")]
				[Address(RVA = "0xFB4C44", Offset = "0xFB4C44", VA = "0xFB4C44")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0xFB55EC", Offset = "0xFB55EC", VA = "0xFB55EC")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0xFB481C", Offset = "0xFB481C", VA = "0xFB481C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0xFB55E4", Offset = "0xFB55E4", VA = "0xFB55E4")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xFB4734", Offset = "0xFB4734", VA = "0xFB4734", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xFB4778", Offset = "0xFB4778", VA = "0xFB4778", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xFB47BC", Offset = "0xFB47BC", VA = "0xFB47BC")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xFB4800", Offset = "0xFB4800", VA = "0xFB4800")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xFB4BA8", Offset = "0xFB4BA8", VA = "0xFB4BA8")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xFB4BD0", Offset = "0xFB4BD0", VA = "0xFB4BD0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xFB4BD8", Offset = "0xFB4BD8", VA = "0xFB4BD8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xFB53BC", Offset = "0xFB53BC", VA = "0xFB53BC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xFB554C", Offset = "0xFB554C", VA = "0xFB554C")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xFB5A28", Offset = "0xFB5A28", VA = "0xFB5A28")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xFB5AEC", Offset = "0xFB5AEC", VA = "0xFB5AEC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xFB5B0C", Offset = "0xFB5B0C", VA = "0xFB5B0C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xFB5D60", Offset = "0xFB5D60", VA = "0xFB5D60")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xFB5BCC", Offset = "0xFB5BCC", VA = "0xFB5BCC")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xFB5E44", Offset = "0xFB5E44", VA = "0xFB5E44")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xFB5EA4", Offset = "0xFB5EA4", VA = "0xFB5EA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xFB6340", Offset = "0xFB6340", VA = "0xFB6340")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xFB64D4", Offset = "0xFB64D4", VA = "0xFB64D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xFB65E0", Offset = "0xFB65E0", VA = "0xFB65E0")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000054")]
		public class BendBone
		{
			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600029D")]
			[Address(RVA = "0xFB9698", Offset = "0xFB9698", VA = "0xFB9698")]
			public BendBone()
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0xFB96F8", Offset = "0xFB96F8", VA = "0xFB96F8")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0xFB9774", Offset = "0xFB9774", VA = "0xFB9774")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0xFB97A0", Offset = "0xFB97A0", VA = "0xFB97A0")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the head bone after solving")]
		[LargeHeader("Rotation")]
		public float rotationWeight;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		public float CCDWeight;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rolling the bones in towards the target")]
		public float roll;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[LargeHeader("Stretching")]
		[Range(0f, 1f)]
		public float postStretchWeight;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xFB65E8", Offset = "0xFB65E8", VA = "0xFB65E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xFB69D4", Offset = "0xFB69D4", VA = "0xFB69D4")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xFB6E4C", Offset = "0xFB6E4C", VA = "0xFB6E4C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xFB71F4", Offset = "0xFB71F4", VA = "0xFB71F4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xFB7AF0", Offset = "0xFB7AF0", VA = "0xFB7AF0")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xFB7EE8", Offset = "0xFB7EE8", VA = "0xFB7EE8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xFB82F8", Offset = "0xFB82F8", VA = "0xFB82F8")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xFB8C78", Offset = "0xFB8C78", VA = "0xFB8C78")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xFB7834", Offset = "0xFB7834", VA = "0xFB7834")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xFB8EB4", Offset = "0xFB8EB4", VA = "0xFB8EB4")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xFB8B90", Offset = "0xFB8B90", VA = "0xFB8B90")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xFB8A90", Offset = "0xFB8A90", VA = "0xFB8A90")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xFB91B8", Offset = "0xFB91B8", VA = "0xFB91B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xFB94F0", Offset = "0xFB94F0", VA = "0xFB94F0")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000056")]
		public class ChildConstraint
		{
			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000033")]
			public float nominalDistance
			{
				[Token(Token = "0x60002B5")]
				[Address(RVA = "0xFBC6F4", Offset = "0xFBC6F4", VA = "0xFBC6F4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002B6")]
				[Address(RVA = "0xFBC6FC", Offset = "0xFBC6FC", VA = "0xFBC6FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x60002B7")]
				[Address(RVA = "0xFBC704", Offset = "0xFBC704", VA = "0xFBC704")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002B8")]
				[Address(RVA = "0xFBC70C", Offset = "0xFBC70C", VA = "0xFBC70C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xFBC718", Offset = "0xFBC718", VA = "0xFBC718")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xFBA42C", Offset = "0xFBA42C", VA = "0xFBA42C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xFBAAC4", Offset = "0xFBAAC4", VA = "0xFBAAC4")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xFBC4B8", Offset = "0xFBC4B8", VA = "0xFBC4B8")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000057")]
		public enum Smoothing
		{
			[Token(Token = "0x4000239")]
			None,
			[Token(Token = "0x400023A")]
			Exponential,
			[Token(Token = "0x400023B")]
			Cubic
		}

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400022D")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xFB97C8", Offset = "0xFB97C8", VA = "0xFB97C8")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xFB9930", Offset = "0xFB9930", VA = "0xFB9930")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xFB9A64", Offset = "0xFB9A64", VA = "0xFB9A64")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xFB9B9C", Offset = "0xFB9B9C", VA = "0xFB9B9C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xFB9C58", Offset = "0xFB9C58", VA = "0xFB9C58")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xFB9D64", Offset = "0xFB9D64", VA = "0xFB9D64")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xFBA6E0", Offset = "0xFBA6E0", VA = "0xFBA6E0")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xFB9ED0", Offset = "0xFB9ED0", VA = "0xFB9ED0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xFBACA8", Offset = "0xFBACA8", VA = "0xFBACA8")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xFBAF3C", Offset = "0xFBAF3C", VA = "0xFBAF3C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xFBB20C", Offset = "0xFBB20C", VA = "0xFBB20C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xFBBBBC", Offset = "0xFBBBBC", VA = "0xFBBBBC")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xFBC0B4", Offset = "0xFBC0B4", VA = "0xFBC0B4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xFBC2B4", Offset = "0xFBC2B4", VA = "0xFBC2B4")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xFBBFA0", Offset = "0xFBBFA0", VA = "0xFBBFA0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xFBBA5C", Offset = "0xFBBA5C", VA = "0xFBBA5C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xFBBF3C", Offset = "0xFBBF3C", VA = "0xFBBF3C")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xFBC390", Offset = "0xFBC390", VA = "0xFBC390")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xFBBE68", Offset = "0xFBBE68", VA = "0xFBBE68")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xFBC1B8", Offset = "0xFBC1B8", VA = "0xFBC1B8")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xFBCA44", Offset = "0xFBCA44", VA = "0xFBCA44")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xFBCA4C", Offset = "0xFBCA4C", VA = "0xFBCA4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xFBC86C", Offset = "0xFBC86C", VA = "0xFBC86C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xFB98C4", Offset = "0xFB98C4", VA = "0xFB98C4")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xFBCA58", Offset = "0xFBCA58", VA = "0xFBCA58")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xFBA478", Offset = "0xFBA478", VA = "0xFBA478")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xFBA484", Offset = "0xFBA484", VA = "0xFBA484")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xFBCC8C", Offset = "0xFBCC8C", VA = "0xFBCC8C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xFBCFE0", Offset = "0xFBCFE0", VA = "0xFBCFE0")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xFBB444", Offset = "0xFBB444", VA = "0xFBB444")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xFBCB54", Offset = "0xFBCB54", VA = "0xFBCB54")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xFBCBF0", Offset = "0xFBCBF0", VA = "0xFBCBF0")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class IKEffector
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000036")]
		public bool isEndEffector
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xFBD454", Offset = "0xFBD454", VA = "0xFBD454")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xFBD45C", Offset = "0xFBD45C", VA = "0xFBD45C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xFBD3F8", Offset = "0xFBD3F8", VA = "0xFBD3F8")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xFBD468", Offset = "0xFBD468", VA = "0xFBD468")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xFBD4EC", Offset = "0xFBD4EC", VA = "0xFBD4EC")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xFBD68C", Offset = "0xFBD68C", VA = "0xFBD68C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xFBD848", Offset = "0xFBD848", VA = "0xFBD848")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xFBDB3C", Offset = "0xFBDB3C", VA = "0xFBDB3C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xFBDDC8", Offset = "0xFBDDC8", VA = "0xFBDDC8")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xFBDEE0", Offset = "0xFBDEE0", VA = "0xFBDEE0")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xFBDF7C", Offset = "0xFBDF7C", VA = "0xFBDF7C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xFBE61C", Offset = "0xFBE61C", VA = "0xFBE61C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xFBE674", Offset = "0xFBE674", VA = "0xFBE674")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xFBE83C", Offset = "0xFBE83C", VA = "0xFBE83C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xFBEA84", Offset = "0xFBEA84", VA = "0xFBEA84")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		public class BoneMap
		{
			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000037")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002DE")]
				[Address(RVA = "0xFBEFC0", Offset = "0xFBEFC0", VA = "0xFBEFC0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002E1")]
				[Address(RVA = "0xFBF078", Offset = "0xFBF078", VA = "0xFBF078")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002F5")]
				[Address(RVA = "0xFBF434", Offset = "0xFBF434", VA = "0xFBF434")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xFBEF98", Offset = "0xFBEF98", VA = "0xFBEF98")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xFBEFF0", Offset = "0xFBEFF0", VA = "0xFBEFF0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xFBF034", Offset = "0xFBF034", VA = "0xFBF034")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xFBF088", Offset = "0xFBF088", VA = "0xFBF088")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xFBF15C", Offset = "0xFBF15C", VA = "0xFBF15C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xFBF164", Offset = "0xFBF164", VA = "0xFBF164")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xFBF230", Offset = "0xFBF230", VA = "0xFBF230")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0xFBF29C", Offset = "0xFBF29C", VA = "0xFBF29C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xFBF324", Offset = "0xFBF324", VA = "0xFBF324")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xFBF59C", Offset = "0xFBF59C", VA = "0xFBF59C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xFBF5C8", Offset = "0xFBF5C8", VA = "0xFBF5C8")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xFBF5F4", Offset = "0xFBF5F4", VA = "0xFBF5F4")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xFBF61C", Offset = "0xFBF61C", VA = "0xFBF61C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xFBF6DC", Offset = "0xFBF6DC", VA = "0xFBF6DC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xFBF860", Offset = "0xFBF860", VA = "0xFBF860")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xFBF884", Offset = "0xFBF884", VA = "0xFBF884")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xFBF9A4", Offset = "0xFBF9A4", VA = "0xFBF9A4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xFBFA08", Offset = "0xFBFA08", VA = "0xFBFA08")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xFBFB88", Offset = "0xFBFB88", VA = "0xFBFB88")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xFBFD08", Offset = "0xFBFD08", VA = "0xFBFD08")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xFBFD84", Offset = "0xFBFD84", VA = "0xFBFD84")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xFBF750", Offset = "0xFBF750", VA = "0xFBF750")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xFBFEA0", Offset = "0xFBFEA0", VA = "0xFBFEA0")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xFBED34", Offset = "0xFBED34", VA = "0xFBED34", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xFBED3C", Offset = "0xFBED3C", VA = "0xFBED3C", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xFBED40", Offset = "0xFBED40", VA = "0xFBED40")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xFBEE7C", Offset = "0xFBEE7C", VA = "0xFBEE7C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xFBEF90", Offset = "0xFBEF90", VA = "0xFBEF90")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xFBFEBC", Offset = "0xFBFEBC", VA = "0xFBFEBC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xFBFF58", Offset = "0xFBFF58", VA = "0xFBFF58")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xFBFFDC", Offset = "0xFBFFDC", VA = "0xFBFFDC")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xFC0074", Offset = "0xFC0074", VA = "0xFC0074")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xFC008C", Offset = "0xFC008C", VA = "0xFC008C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xFC00A8", Offset = "0xFC00A8", VA = "0xFC00A8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xFC0134", Offset = "0xFC0134", VA = "0xFC0134")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xFC014C", Offset = "0xFC014C", VA = "0xFC014C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200005E")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000293")]
			Parent,
			[Token(Token = "0x4000294")]
			Bone1,
			[Token(Token = "0x4000295")]
			Bone2,
			[Token(Token = "0x4000296")]
			Bone3
		}

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xFC0170", Offset = "0xFC0170", VA = "0xFC0170", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xFC01E4", Offset = "0xFC01E4", VA = "0xFC01E4")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xFC02AC", Offset = "0xFC02AC", VA = "0xFC02AC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xFC0564", Offset = "0xFC0564", VA = "0xFC0564")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xFC0680", Offset = "0xFC0680", VA = "0xFC0680")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xFC07C8", Offset = "0xFC07C8", VA = "0xFC07C8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xFC07D4", Offset = "0xFC07D4", VA = "0xFC07D4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xFC086C", Offset = "0xFC086C", VA = "0xFC086C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xFC0914", Offset = "0xFC0914", VA = "0xFC0914", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xFC0B70", Offset = "0xFC0B70", VA = "0xFC0B70")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xFC0BD0", Offset = "0xFC0BD0", VA = "0xFC0BD0")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xFC0D14", Offset = "0xFC0D14", VA = "0xFC0D14", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xFC1034", Offset = "0xFC1034", VA = "0xFC1034")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xFC1170", Offset = "0xFC1170", VA = "0xFC1170")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xFC12E0", Offset = "0xFC12E0", VA = "0xFC12E0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xFC12F0", Offset = "0xFC12F0", VA = "0xFC12F0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xFC134C", Offset = "0xFC134C", VA = "0xFC134C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xFC13C4", Offset = "0xFC13C4", VA = "0xFC13C4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xFC19D8", Offset = "0xFC19D8", VA = "0xFC19D8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xFC1A10", Offset = "0xFC1A10", VA = "0xFC1A10")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xFC1C74", Offset = "0xFC1C74", VA = "0xFC1C74")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xFC1F94", Offset = "0xFC1F94", VA = "0xFC1F94")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xFC2074", Offset = "0xFC2074", VA = "0xFC2074")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xFC2128", Offset = "0xFC2128", VA = "0xFC2128")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000061")]
		public class Point
		{
			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x600032D")]
			[Address(RVA = "0xFC29F8", Offset = "0xFC29F8", VA = "0xFC29F8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0xFC2A3C", Offset = "0xFC2A3C", VA = "0xFC2A3C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0xFC2B1C", Offset = "0xFC2B1C", VA = "0xFC2B1C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0xFC2B48", Offset = "0xFC2B48", VA = "0xFC2B48")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0xFC2B74", Offset = "0xFC2B74", VA = "0xFC2B74")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0xFC2BB8", Offset = "0xFC2BB8", VA = "0xFC2BB8")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000333")]
			[Address(RVA = "0xFC2BFC", Offset = "0xFC2BFC", VA = "0xFC2BFC")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000062")]
		public class Bone : Point
		{
			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700003B")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000334")]
				[Address(RVA = "0xFC2C5C", Offset = "0xFC2C5C", VA = "0xFC2C5C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000335")]
				[Address(RVA = "0xFC2D3C", Offset = "0xFC2D3C", VA = "0xFC2D3C")]
				set
				{
				}
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0xFC2DB4", Offset = "0xFC2DB4", VA = "0xFC2DB4")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0xFC3020", Offset = "0xFC3020", VA = "0xFC3020")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0xFC32DC", Offset = "0xFC32DC", VA = "0xFC32DC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0xFC34D0", Offset = "0xFC34D0", VA = "0xFC34D0")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0xFC34F8", Offset = "0xFC34F8", VA = "0xFC34F8")]
			public Bone()
			{
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0xFC3564", Offset = "0xFC3564", VA = "0xFC3564")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0xFC35DC", Offset = "0xFC35DC", VA = "0xFC35DC")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000063")]
		public class Node : Point
		{
			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x600033D")]
			[Address(RVA = "0xFC3664", Offset = "0xFC3664", VA = "0xFC3664")]
			public Node()
			{
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0xFB9B78", Offset = "0xFB9B78", VA = "0xFB9B78")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600033F")]
			[Address(RVA = "0xFC3668", Offset = "0xFC3668", VA = "0xFC3668")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000064")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000065")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The positional or the master weight of the solver.")]
		public float IKPositionWeight;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x1700003A")]
		public bool initiated
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0xFC2604", Offset = "0xFC2604", VA = "0xFC2604")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000321")]
			[Address(RVA = "0xFC260C", Offset = "0xFC260C", VA = "0xFC260C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xFC2364", Offset = "0xFC2364", VA = "0xFC2364")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xFC23D8", Offset = "0xFC23D8", VA = "0xFC23D8")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xFC2550", Offset = "0xFC2550", VA = "0xFC2550")]
		public void Update()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xFC25C0", Offset = "0xFC25C0", VA = "0xFC25C0", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xFC25CC", Offset = "0xFC25CC", VA = "0xFC25CC")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xFC25D8", Offset = "0xFC25D8", VA = "0xFC25D8")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xFC25E0", Offset = "0xFC25E0", VA = "0xFC25E0")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xFC25FC", Offset = "0xFC25FC", VA = "0xFC25FC")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000323")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000324")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000325")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000326")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000327")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xFC2618", Offset = "0xFC2618", VA = "0xFC2618")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xFC2630", Offset = "0xFC2630", VA = "0xFC2630")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xFC2754", Offset = "0xFC2754", VA = "0xFC2754")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xFC27EC", Offset = "0xFC27EC", VA = "0xFC27EC")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xFC29E0", Offset = "0xFC29E0", VA = "0xFC29E0")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700003C")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0xFC3A38", Offset = "0xFC3A38", VA = "0xFC3A38")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0xFC3A68", Offset = "0xFC3A68", VA = "0xFC3A68")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0xFC469C", Offset = "0xFC469C", VA = "0xFC469C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0xFC4BDC", Offset = "0xFC4BDC", VA = "0xFC4BDC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xFC3900", Offset = "0xFC3900", VA = "0xFC3900")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xFC3A98", Offset = "0xFC3A98", VA = "0xFC3A98", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xFC3D24", Offset = "0xFC3D24", VA = "0xFC3D24", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xFC45F4", Offset = "0xFC45F4", VA = "0xFC45F4")]
		private void Solve()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xFC4290", Offset = "0xFC4290", VA = "0xFC4290")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xFC46A4", Offset = "0xFC46A4", VA = "0xFC46A4")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xFC4C3C", Offset = "0xFC4C3C", VA = "0xFC4C3C")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xFC4CE0", Offset = "0xFC4CE0", VA = "0xFC4CE0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xFC503C", Offset = "0xFC503C", VA = "0xFC503C")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xFC509C", Offset = "0xFC509C", VA = "0xFC509C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xFC51E0", Offset = "0xFC51E0", VA = "0xFC51E0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xFC5340", Offset = "0xFC5340", VA = "0xFC5340", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xFC5380", Offset = "0xFC5380", VA = "0xFC5380", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xFC53D0", Offset = "0xFC53D0", VA = "0xFC53D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xFC5730", Offset = "0xFC5730", VA = "0xFC5730", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xFC5750", Offset = "0xFC5750", VA = "0xFC5750")]
		private void Solve()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xFC5428", Offset = "0xFC5428", VA = "0xFC5428")]
		private void Read()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xFC57B4", Offset = "0xFC57B4", VA = "0xFC57B4")]
		private void Write()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xFC592C", Offset = "0xFC592C", VA = "0xFC592C")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xFC5AC0", Offset = "0xFC5AC0", VA = "0xFC5AC0")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xFC5B30", Offset = "0xFC5B30", VA = "0xFC5B30", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xFC5BA0", Offset = "0xFC5BA0", VA = "0xFC5BA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xFC5E54", Offset = "0xFC5E54", VA = "0xFC5E54")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xFC64E4", Offset = "0xFC64E4", VA = "0xFC64E4")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000040")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0xFC748C", Offset = "0xFC748C", VA = "0xFC748C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xFC64EC", Offset = "0xFC64EC", VA = "0xFC64EC")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xFC6ACC", Offset = "0xFC6ACC", VA = "0xFC6ACC")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xFC6BFC", Offset = "0xFC6BFC", VA = "0xFC6BFC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xFC6C84", Offset = "0xFC6C84", VA = "0xFC6C84", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xFC7180", Offset = "0xFC7180", VA = "0xFC7180", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xFC7494", Offset = "0xFC7494", VA = "0xFC7494")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xFC65C4", Offset = "0xFC65C4", VA = "0xFC65C4")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xFC6BB4", Offset = "0xFC6BB4", VA = "0xFC6BB4")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xFC7444", Offset = "0xFC7444", VA = "0xFC7444")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xFC6960", Offset = "0xFC6960", VA = "0xFC6960")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xFC7B40", Offset = "0xFC7B40", VA = "0xFC7B40")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xFC7BA8", Offset = "0xFC7BA8", VA = "0xFC7BA8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xFC7C78", Offset = "0xFC7C78", VA = "0xFC7C78")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xFC7D40", Offset = "0xFC7D40", VA = "0xFC7D40")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xFC6EF8", Offset = "0xFC6EF8", VA = "0xFC6EF8")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xFC703C", Offset = "0xFC703C", VA = "0xFC703C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xFC7E30", Offset = "0xFC7E30", VA = "0xFC7E30")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xFC7730", Offset = "0xFC7730", VA = "0xFC7730")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xFC6BA4", Offset = "0xFC6BA4", VA = "0xFC6BA4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xFC84A0", Offset = "0xFC84A0", VA = "0xFC84A0")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xFC7FF0", Offset = "0xFC7FF0", VA = "0xFC7FF0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xFC75B0", Offset = "0xFC75B0", VA = "0xFC75B0")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xFC7680", Offset = "0xFC7680", VA = "0xFC7680")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xFC8558", Offset = "0xFC8558", VA = "0xFC8558")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xFC85DC", Offset = "0xFC85DC", VA = "0xFC85DC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xFC8C30", Offset = "0xFC8C30", VA = "0xFC8C30", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xFC8CBC", Offset = "0xFC8CBC", VA = "0xFC8CBC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xFC8D50", Offset = "0xFC8D50", VA = "0xFC8D50", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xFC8E38", Offset = "0xFC8E38", VA = "0xFC8E38")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xFC8EC8", Offset = "0xFC8EC8", VA = "0xFC8EC8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xFC92C8", Offset = "0xFC92C8", VA = "0xFC92C8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xFC94A0", Offset = "0xFC94A0", VA = "0xFC94A0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xFC9368", Offset = "0xFC9368", VA = "0xFC9368")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xFC90A0", Offset = "0xFC90A0", VA = "0xFC90A0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xFC9524", Offset = "0xFC9524", VA = "0xFC9524")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xFC9594", Offset = "0xFC9594", VA = "0xFC9594")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xFC9670", Offset = "0xFC9670", VA = "0xFC9670")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xFBC758", Offset = "0xFBC758", VA = "0xFBC758")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xFBD3A8", Offset = "0xFBD3A8", VA = "0xFBD3A8")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xFBCAE4", Offset = "0xFBCAE4", VA = "0xFBCAE4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xFC96B8", Offset = "0xFC96B8", VA = "0xFC96B8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xFC9850", Offset = "0xFC9850", VA = "0xFC9850", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xFC99AC", Offset = "0xFC99AC", VA = "0xFC99AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xFC9BA4", Offset = "0xFC9BA4", VA = "0xFC9BA4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xFC9C74", Offset = "0xFC9C74", VA = "0xFC9C74", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xFC9D50", Offset = "0xFC9D50", VA = "0xFC9D50", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xFC9EA8", Offset = "0xFC9EA8", VA = "0xFC9EA8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xFCA040", Offset = "0xFCA040", VA = "0xFCA040", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xFCA264", Offset = "0xFCA264", VA = "0xFCA264", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xFCA520", Offset = "0xFCA520", VA = "0xFCA520", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xFCA554", Offset = "0xFCA554", VA = "0xFCA554", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xFCA62C", Offset = "0xFCA62C", VA = "0xFCA62C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40002F0")]
		Body,
		[Token(Token = "0x40002F1")]
		LeftShoulder,
		[Token(Token = "0x40002F2")]
		RightShoulder,
		[Token(Token = "0x40002F3")]
		LeftThigh,
		[Token(Token = "0x40002F4")]
		RightThigh,
		[Token(Token = "0x40002F5")]
		LeftHand,
		[Token(Token = "0x40002F6")]
		RightHand,
		[Token(Token = "0x40002F7")]
		LeftFoot,
		[Token(Token = "0x40002F8")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40002FA")]
		LeftArm,
		[Token(Token = "0x40002FB")]
		RightArm,
		[Token(Token = "0x40002FC")]
		LeftLeg,
		[Token(Token = "0x40002FD")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0xFCA744", Offset = "0xFCA744", VA = "0xFCA744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0xFCA884", Offset = "0xFCA884", VA = "0xFCA884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0xFCA88C", Offset = "0xFCA88C", VA = "0xFCA88C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0xFCA894", Offset = "0xFCA894", VA = "0xFCA894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0xFCA89C", Offset = "0xFCA89C", VA = "0xFCA89C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0xFCA8A4", Offset = "0xFCA8A4", VA = "0xFCA8A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0xFCA8AC", Offset = "0xFCA8AC", VA = "0xFCA8AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0xFCA8B4", Offset = "0xFCA8B4", VA = "0xFCA8B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0xFCA8BC", Offset = "0xFCA8BC", VA = "0xFCA8BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xFCA8C4", Offset = "0xFCA8C4", VA = "0xFCA8C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xFCA8F0", Offset = "0xFCA8F0", VA = "0xFCA8F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0xFCA91C", Offset = "0xFCA91C", VA = "0xFCA91C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0xFCA948", Offset = "0xFCA948", VA = "0xFCA948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xFCA974", Offset = "0xFCA974", VA = "0xFCA974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xFCA99C", Offset = "0xFCA99C", VA = "0xFCA99C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xFCA9C8", Offset = "0xFCA9C8", VA = "0xFCA9C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xFCA9F4", Offset = "0xFCA9F4", VA = "0xFCA9F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xFCAA20", Offset = "0xFCAA20", VA = "0xFCAA20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xFCC814", Offset = "0xFCC814", VA = "0xFCC814")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xFCC820", Offset = "0xFCC820", VA = "0xFCC820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xFCAA48", Offset = "0xFCAA48", VA = "0xFCAA48")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xFCAB48", Offset = "0xFCAB48", VA = "0xFCAB48")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xFCAA98", Offset = "0xFCAA98", VA = "0xFCAA98")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xFCABC0", Offset = "0xFCABC0", VA = "0xFCABC0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xFCA74C", Offset = "0xFCA74C", VA = "0xFCA74C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xFCAC88", Offset = "0xFCAC88", VA = "0xFCAC88")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xFCAD38", Offset = "0xFCAD38", VA = "0xFCAD38")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xFCADE4", Offset = "0xFCADE4", VA = "0xFCADE4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xFCAE90", Offset = "0xFCAE90", VA = "0xFCAE90")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xFCAE98", Offset = "0xFCAE98", VA = "0xFCAE98")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xFCAEC0", Offset = "0xFCAEC0", VA = "0xFCAEC0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xFCAF80", Offset = "0xFCAF80", VA = "0xFCAF80", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xFCB114", Offset = "0xFCB114", VA = "0xFCB114")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xFCC10C", Offset = "0xFCC10C", VA = "0xFCC10C")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xFCC6BC", Offset = "0xFCC6BC", VA = "0xFCC6BC")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xFCC718", Offset = "0xFCC718", VA = "0xFCC718")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xFCC55C", Offset = "0xFCC55C", VA = "0xFCC55C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xFCC60C", Offset = "0xFCC60C", VA = "0xFCC60C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xFCC82C", Offset = "0xFCC82C", VA = "0xFCC82C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xFCC8F0", Offset = "0xFCC8F0", VA = "0xFCC8F0", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xFCC9C4", Offset = "0xFCC9C4", VA = "0xFCC9C4")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xFCCAE0", Offset = "0xFCCAE0", VA = "0xFCCAE0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xFCCC70", Offset = "0xFCCC70", VA = "0xFCCC70")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xFCCDE8", Offset = "0xFCCDE8", VA = "0xFCCDE8", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xFCD04C", Offset = "0xFCD04C", VA = "0xFCD04C", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xFCD0C8", Offset = "0xFCD0C8", VA = "0xFCD0C8")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000054")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xFCD90C", Offset = "0xFCD90C", VA = "0xFCD90C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xFCD914", Offset = "0xFCD914", VA = "0xFCD914", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xFCD91C", Offset = "0xFCD91C", VA = "0xFCD91C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xFCDDC0", Offset = "0xFCDDC0", VA = "0xFCDDC0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xFCDE7C", Offset = "0xFCDE7C", VA = "0xFCDE7C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xFCD0D8", Offset = "0xFCD0D8", VA = "0xFCD0D8")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xFCD25C", Offset = "0xFCD25C", VA = "0xFCD25C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xFCD388", Offset = "0xFCD388", VA = "0xFCD388", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xFCD3E8", Offset = "0xFCD3E8", VA = "0xFCD3E8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xFCD45C", Offset = "0xFCD45C", VA = "0xFCD45C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xFCD828", Offset = "0xFCD828", VA = "0xFCD828", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xFCD830", Offset = "0xFCD830", VA = "0xFCD830", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xFCD924", Offset = "0xFCD924", VA = "0xFCD924", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xFCD928", Offset = "0xFCD928", VA = "0xFCD928", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xFCD92C", Offset = "0xFCD92C", VA = "0xFCD92C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xFCDEC4", Offset = "0xFCDEC4", VA = "0xFCDEC4")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xFCE27C", Offset = "0xFCE27C", VA = "0xFCE27C")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xFCE510", Offset = "0xFCE510", VA = "0xFCE510")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xFCE578", Offset = "0xFCE578", VA = "0xFCE578", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xFCE8D4", Offset = "0xFCE8D4", VA = "0xFCE8D4")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xFCE938", Offset = "0xFCE938", VA = "0xFCE938", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xFCEA7C", Offset = "0xFCEA7C", VA = "0xFCEA7C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xFCEBDC", Offset = "0xFCEBDC", VA = "0xFCEBDC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xFCEC2C", Offset = "0xFCEC2C", VA = "0xFCEC2C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xFCEC8C", Offset = "0xFCEC8C", VA = "0xFCEC8C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xFCEFE8", Offset = "0xFCEFE8", VA = "0xFCEFE8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xFCF008", Offset = "0xFCF008", VA = "0xFCF008")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xFCECE4", Offset = "0xFCECE4", VA = "0xFCECE4")]
		private void Read()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xFCF094", Offset = "0xFCF094", VA = "0xFCF094")]
		private void Write()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xFCF2CC", Offset = "0xFCF2CC", VA = "0xFCF2CC")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		public enum BendModifier
		{
			[Token(Token = "0x4000328")]
			Animation,
			[Token(Token = "0x4000329")]
			Target,
			[Token(Token = "0x400032A")]
			Parent,
			[Token(Token = "0x400032B")]
			Arm,
			[Token(Token = "0x400032C")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000073")]
		public struct AxisDirection
		{
			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0xFD0850", Offset = "0xFD0850", VA = "0xFD0850")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000059")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xFD0834", Offset = "0xFD0834", VA = "0xFD0834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xFCF464", Offset = "0xFCF464", VA = "0xFCF464")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xFCF4A8", Offset = "0xFCF4A8", VA = "0xFCF4A8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xFCF514", Offset = "0xFCF514", VA = "0xFCF514", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xFCFA5C", Offset = "0xFCFA5C", VA = "0xFCFA5C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xFD0578", Offset = "0xFD0578", VA = "0xFD0578", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xFD0620", Offset = "0xFD0620", VA = "0xFD0620")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xFD07B4", Offset = "0xFD07B4", VA = "0xFD07B4")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xFCF870", Offset = "0xFCF870", VA = "0xFCF870")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xFCFB18", Offset = "0xFCFB18", VA = "0xFCFB18")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000075")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000060")]
			public Vector3 forward
			{
				[Token(Token = "0x600040F")]
				[Address(RVA = "0xFD261C", Offset = "0xFD261C", VA = "0xFD261C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0xFD2C74", Offset = "0xFD2C74", VA = "0xFD2C74")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0xFD177C", Offset = "0xFD177C", VA = "0xFD177C")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0xFD1A2C", Offset = "0xFD1A2C", VA = "0xFD1A2C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0xFD2964", Offset = "0xFD2964", VA = "0xFD2964")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x1700005A")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xFD0F80", Offset = "0xFD0F80", VA = "0xFD0F80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0xFD1128", Offset = "0xFD1128", VA = "0xFD1128")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xFD104C", Offset = "0xFD104C", VA = "0xFD104C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xFD114C", Offset = "0xFD114C", VA = "0xFD114C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xFD105C", Offset = "0xFD105C", VA = "0xFD105C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xFD11B8", Offset = "0xFD11B8", VA = "0xFD11B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xFD09EC", Offset = "0xFD09EC", VA = "0xFD09EC")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xFD0A08", Offset = "0xFD0A08", VA = "0xFD0A08")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xFD0A34", Offset = "0xFD0A34", VA = "0xFD0A34")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xFD0A6C", Offset = "0xFD0A6C", VA = "0xFD0A6C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xFD0AB4", Offset = "0xFD0AB4", VA = "0xFD0AB4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xFD0B0C", Offset = "0xFD0B0C", VA = "0xFD0B0C")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xFD0B7C", Offset = "0xFD0B7C", VA = "0xFD0B7C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xFD0C94", Offset = "0xFD0C94", VA = "0xFD0C94")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xFD0CA0", Offset = "0xFD0CA0", VA = "0xFD0CA0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xFD0DD0", Offset = "0xFD0DD0", VA = "0xFD0DD0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xFD11DC", Offset = "0xFD11DC", VA = "0xFD11DC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xFD1400", Offset = "0xFD1400", VA = "0xFD1400", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xFD1560", Offset = "0xFD1560", VA = "0xFD1560")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xFD17A4", Offset = "0xFD17A4", VA = "0xFD17A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xFD1B18", Offset = "0xFD1B18", VA = "0xFD1B18", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xFD1BDC", Offset = "0xFD1BDC", VA = "0xFD1BDC")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xFD1DF8", Offset = "0xFD1DF8", VA = "0xFD1DF8")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xFD2140", Offset = "0xFD2140", VA = "0xFD2140")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xFD264C", Offset = "0xFD264C", VA = "0xFD264C")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xFD1610", Offset = "0xFD1610", VA = "0xFD1610")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xFD2A6C", Offset = "0xFD2A6C", VA = "0xFD2A6C")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000077")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000427")]
			[Address(RVA = "0xFD3F18", Offset = "0xFD3F18", VA = "0xFD3F18")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0xFD47C0", Offset = "0xFD47C0", VA = "0xFD47C0")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0xFCF4E4", Offset = "0xFCF4E4", VA = "0xFCF4E4")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0xFD485C", Offset = "0xFD485C", VA = "0xFD485C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xFD2C7C", Offset = "0xFD2C7C", VA = "0xFD2C7C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xFD2E10", Offset = "0xFD2E10", VA = "0xFD2E10")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xFD2F90", Offset = "0xFD2F90", VA = "0xFD2F90")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xFD2F9C", Offset = "0xFD2F9C", VA = "0xFD2F9C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xFD2FB8", Offset = "0xFD2FB8", VA = "0xFD2FB8")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xFD2FC4", Offset = "0xFD2FC4", VA = "0xFD2FC4")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xFD2FCC", Offset = "0xFD2FCC", VA = "0xFD2FCC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xFD30B8", Offset = "0xFD30B8", VA = "0xFD30B8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xFD31B0", Offset = "0xFD31B0", VA = "0xFD31B0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xFD31F0", Offset = "0xFD31F0", VA = "0xFD31F0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xFD3240", Offset = "0xFD3240", VA = "0xFD3240", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xFD35E4", Offset = "0xFD35E4", VA = "0xFD35E4")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xFD3630", Offset = "0xFD3630", VA = "0xFD3630")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xFD3B24", Offset = "0xFD3B24", VA = "0xFD3B24")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xFD3C7C", Offset = "0xFD3C7C", VA = "0xFD3C7C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xFD3E28", Offset = "0xFD3E28", VA = "0xFD3E28")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xFD3DA8", Offset = "0xFD3DA8", VA = "0xFD3DA8")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xFD4008", Offset = "0xFD4008", VA = "0xFD4008", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xFD4850", Offset = "0xFD4850", VA = "0xFD4850", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xFD4854", Offset = "0xFD4854", VA = "0xFD4854", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xFD4858", Offset = "0xFD4858", VA = "0xFD4858", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xFD4600", Offset = "0xFD4600", VA = "0xFD4600")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xFD068C", Offset = "0xFD068C", VA = "0xFD068C")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200007A")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000390")]
				YawPitch,
				[Token(Token = "0x4000391")]
				FromTo
			}

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(0f, 1f)]
			[Tooltip("The weight of shoulder rotation")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[Range(0f, 1f)]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400038D")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400038E")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000062")]
			public Vector3 position
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0xFDA144", Offset = "0xFDA144", VA = "0xFDA144")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000448")]
				[Address(RVA = "0xFDA150", Offset = "0xFDA150", VA = "0xFDA150")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000449")]
				[Address(RVA = "0xFDA15C", Offset = "0xFDA15C", VA = "0xFDA15C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600044A")]
				[Address(RVA = "0xFDA168", Offset = "0xFDA168", VA = "0xFDA168")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0xFDA174", Offset = "0xFDA174", VA = "0xFDA174")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0xFDA19C", Offset = "0xFDA19C", VA = "0xFDA19C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0xFDA1D0", Offset = "0xFDA1D0", VA = "0xFDA1D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0xFDA210", Offset = "0xFDA210", VA = "0xFDA210")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0xFDA250", Offset = "0xFDA250", VA = "0xFDA250", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0xFDAB50", Offset = "0xFDAB50", VA = "0xFDAB50", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0xFDADFC", Offset = "0xFDADFC", VA = "0xFDADFC", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0xFDAE20", Offset = "0xFDAE20", VA = "0xFDAE20")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0xFD8088", Offset = "0xFD8088", VA = "0xFD8088")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0xFDB854", Offset = "0xFDB854", VA = "0xFDB854", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0xFDB8AC", Offset = "0xFDB8AC", VA = "0xFDB8AC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0xFDB170", Offset = "0xFDB170", VA = "0xFDB170")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0xFDB1F0", Offset = "0xFDB1F0", VA = "0xFDB1F0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0xFDBAB8", Offset = "0xFDBAB8", VA = "0xFDBAB8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0xFD9FB8", Offset = "0xFD9FB8", VA = "0xFD9FB8")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000068")]
			public float sqrMag
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0xFDBC68", Offset = "0xFDBC68", VA = "0xFDBC68")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000460")]
				[Address(RVA = "0xFDBC70", Offset = "0xFDBC70", VA = "0xFDBC70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0xFDBC78", Offset = "0xFDBC78", VA = "0xFDBC78")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000462")]
				[Address(RVA = "0xFDBC80", Offset = "0xFDBC80", VA = "0xFDBC80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600045A")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600045B")]
			public abstract void PreSolve();

			[Token(Token = "0x600045C")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600045D")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x600045E")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xFDBC88", Offset = "0xFDBC88", VA = "0xFDBC88")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0xFCF20C", Offset = "0xFCF20C", VA = "0xFCF20C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0xFDBC90", Offset = "0xFDBC90", VA = "0xFDBC90")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0xFDBD18", Offset = "0xFDBD18", VA = "0xFDBD18")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0xFDBDB0", Offset = "0xFDBDB0", VA = "0xFDBDB0")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0xFD7F60", Offset = "0xFD7F60", VA = "0xFD7F60")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0xFDB6EC", Offset = "0xFDB6EC", VA = "0xFDB6EC")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0xFDBDF8", Offset = "0xFDBDF8", VA = "0xFDBDF8")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0xFDBF1C", Offset = "0xFDBF1C", VA = "0xFDBF1C")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0xFDBBD0", Offset = "0xFDBBD0", VA = "0xFDBBD0")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public class Footstep
		{
			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700006A")]
			public bool isStepping
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0xFDCF30", Offset = "0xFDCF30", VA = "0xFDCF30")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0xFDCF44", Offset = "0xFDCF44", VA = "0xFDCF44")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600046F")]
				[Address(RVA = "0xFDCF4C", Offset = "0xFDCF4C", VA = "0xFDCF4C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0xFDCF54", Offset = "0xFDCF54", VA = "0xFDCF54")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0xFDD118", Offset = "0xFDD118", VA = "0xFDD118")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0xFDD160", Offset = "0xFDD160", VA = "0xFDD160")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0xFDD3A4", Offset = "0xFDD3A4", VA = "0xFDD3A4")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0xFDD5AC", Offset = "0xFDD5AC", VA = "0xFDD5AC")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0xFDD790", Offset = "0xFDD790", VA = "0xFDD790")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Range(0f, 1f)]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			public float bendToTargetWeight;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			public float legLengthMlp;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700006C")]
			public Vector3 position
			{
				[Token(Token = "0x6000476")]
				[Address(RVA = "0xFDD904", Offset = "0xFDD904", VA = "0xFDD904")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000477")]
				[Address(RVA = "0xFDD910", Offset = "0xFDD910", VA = "0xFDD910")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0xFDD91C", Offset = "0xFDD91C", VA = "0xFDD91C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000479")]
				[Address(RVA = "0xFDD928", Offset = "0xFDD928", VA = "0xFDD928")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0xFDD934", Offset = "0xFDD934", VA = "0xFDD934")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600047B")]
				[Address(RVA = "0xFDD93C", Offset = "0xFDD93C", VA = "0xFDD93C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0xFDD948", Offset = "0xFDD948", VA = "0xFDD948")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x600047D")]
				[Address(RVA = "0xFDD970", Offset = "0xFDD970", VA = "0xFDD970")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x600047E")]
				[Address(RVA = "0xFDD99C", Offset = "0xFDD99C", VA = "0xFDD99C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x600047F")]
				[Address(RVA = "0xFDD9C8", Offset = "0xFDD9C8", VA = "0xFDD9C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000480")]
				[Address(RVA = "0xFDD9F4", Offset = "0xFDD9F4", VA = "0xFDD9F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000481")]
				[Address(RVA = "0xFDDA28", Offset = "0xFDDA28", VA = "0xFDDA28")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000482")]
				[Address(RVA = "0xFDDA34", Offset = "0xFDDA34", VA = "0xFDDA34")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0xFDDA40", Offset = "0xFDDA40", VA = "0xFDDA40", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0xFDDFF8", Offset = "0xFDDFF8", VA = "0xFDDFF8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0xFDE828", Offset = "0xFDE828", VA = "0xFDE828", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0xFDE7D8", Offset = "0xFDE7D8", VA = "0xFDE7D8")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0xFDE58C", Offset = "0xFDE58C", VA = "0xFDE58C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0xFDED04", Offset = "0xFDED04", VA = "0xFDED04")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0xFDF70C", Offset = "0xFDF70C", VA = "0xFDF70C")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0xFDEF4C", Offset = "0xFDEF4C", VA = "0xFDEF4C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0xFDFB64", Offset = "0xFDFB64", VA = "0xFDFB64", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0xFDFD6C", Offset = "0xFDFD6C", VA = "0xFDFD6C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0xFDFE4C", Offset = "0xFDFE4C", VA = "0xFDFE4C")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public class Locomotion
		{
			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Range(0.9f, 1f)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			public float maxBodyYOffset;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x17000075")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600048E")]
				[Address(RVA = "0xFDFF2C", Offset = "0xFDFF2C", VA = "0xFDFF2C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600048F")]
				[Address(RVA = "0xFDFF38", Offset = "0xFDFF38", VA = "0xFDFF38")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0xFE21A8", Offset = "0xFE21A8", VA = "0xFE21A8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000497")]
				[Address(RVA = "0xFE21DC", Offset = "0xFE21DC", VA = "0xFE21DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0xFE2214", Offset = "0xFE2214", VA = "0xFE2214")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000499")]
				[Address(RVA = "0xFE2248", Offset = "0xFE2248", VA = "0xFE2248")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0xFDFF44", Offset = "0xFDFF44", VA = "0xFDFF44")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0xFE024C", Offset = "0xFE024C", VA = "0xFE024C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0xFE0430", Offset = "0xFE0430", VA = "0xFE0430")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0xFE047C", Offset = "0xFE047C", VA = "0xFE047C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0xFE0844", Offset = "0xFE0844", VA = "0xFE0844")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0xFE08FC", Offset = "0xFE08FC", VA = "0xFE08FC")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0xFE1DD8", Offset = "0xFE1DD8", VA = "0xFE1DD8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0xFE1F8C", Offset = "0xFE1F8C", VA = "0xFE1F8C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0xFE1FF8", Offset = "0xFE1FF8", VA = "0xFE1FF8")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0xFE2280", Offset = "0xFE2280", VA = "0xFE2280")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007F")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Range(0f, 1f)]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			public float chestGoalWeight;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Range(0f, 1f)]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			public float headClampWeight;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 180f)]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x1700007A")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x600049E")]
				[Address(RVA = "0xFE1D70", Offset = "0xFE1D70", VA = "0xFE1D70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600049F")]
				[Address(RVA = "0xFE2378", Offset = "0xFE2378", VA = "0xFE2378")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x60004A0")]
				[Address(RVA = "0xFE23AC", Offset = "0xFE23AC", VA = "0xFE23AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x60004A1")]
				[Address(RVA = "0xFE23F4", Offset = "0xFE23F4", VA = "0xFE23F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x60004A2")]
				[Address(RVA = "0xFE1DA4", Offset = "0xFE1DA4", VA = "0xFE1DA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60004A3")]
				[Address(RVA = "0xFE2428", Offset = "0xFE2428", VA = "0xFE2428")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004A4")]
				[Address(RVA = "0xFE243C", Offset = "0xFE243C", VA = "0xFE243C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60004A5")]
				[Address(RVA = "0xFE2450", Offset = "0xFE2450", VA = "0xFE2450")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004A6")]
				[Address(RVA = "0xFE2464", Offset = "0xFE2464", VA = "0xFE2464")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xFE2478", Offset = "0xFE2478", VA = "0xFE2478", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xFE30D8", Offset = "0xFE30D8", VA = "0xFE30D8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xFE32C0", Offset = "0xFE32C0", VA = "0xFE32C0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xFE3A68", Offset = "0xFE3A68", VA = "0xFE3A68")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xFE40A4", Offset = "0xFE40A4", VA = "0xFE40A4")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xFE4A08", Offset = "0xFE4A08", VA = "0xFE4A08")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xFE51B0", Offset = "0xFE51B0", VA = "0xFE51B0")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xFE5790", Offset = "0xFE5790", VA = "0xFE5790", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xFE5960", Offset = "0xFE5960", VA = "0xFE5960", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xFE3CAC", Offset = "0xFE3CAC", VA = "0xFE3CAC")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xFE4ED8", Offset = "0xFE4ED8", VA = "0xFE4ED8")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xFE45E8", Offset = "0xFE45E8", VA = "0xFE45E8")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0xFE5A34", Offset = "0xFE5A34", VA = "0xFE5A34")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0xFE4FB4", Offset = "0xFE4FB4", VA = "0xFE4FB4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xFE4C68", Offset = "0xFE4C68", VA = "0xFE4C68")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xFE5E40", Offset = "0xFE5E40", VA = "0xFE5E40")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000080")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000419")]
			Pelvis,
			[Token(Token = "0x400041A")]
			Chest,
			[Token(Token = "0x400041B")]
			Head,
			[Token(Token = "0x400041C")]
			LeftHand,
			[Token(Token = "0x400041D")]
			RightHand,
			[Token(Token = "0x400041E")]
			LeftFoot,
			[Token(Token = "0x400041F")]
			RightFoot,
			[Token(Token = "0x4000420")]
			LeftHeel,
			[Token(Token = "0x4000421")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000081")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000423")]
			Pelvis,
			[Token(Token = "0x4000424")]
			Chest,
			[Token(Token = "0x4000425")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000082")]
		public class VirtualBone
		{
			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xFDDF68", Offset = "0xFDDF68", VA = "0xFDDF68")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xFDDFD8", Offset = "0xFDDFD8", VA = "0xFDDFD8")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0xFE5F5C", Offset = "0xFE5F5C", VA = "0xFE5F5C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xFE615C", Offset = "0xFE615C", VA = "0xFE615C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xFE5CD0", Offset = "0xFE5CD0", VA = "0xFE5CD0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xFE62BC", Offset = "0xFE62BC", VA = "0xFE62BC")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xFE6464", Offset = "0xFE6464", VA = "0xFE6464")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0xFE65EC", Offset = "0xFE65EC", VA = "0xFE65EC")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xFDF328", Offset = "0xFDF328", VA = "0xFDF328")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xFE6690", Offset = "0xFE6690", VA = "0xFE6690")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xFE53C4", Offset = "0xFE53C4", VA = "0xFE53C4")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xFE67E8", Offset = "0xFE67E8", VA = "0xFE67E8")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xFE68FC", Offset = "0xFE68FC", VA = "0xFE68FC")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		[Range(0f, 2f)]
		public int LOD;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000061")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xFD9D6C", Offset = "0xFD9D6C", VA = "0xFD9D6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000443")]
			[Address(RVA = "0xFD9D74", Offset = "0xFD9D74", VA = "0xFD9D74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xFD4864", Offset = "0xFD4864", VA = "0xFD4864")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xFD4C84", Offset = "0xFD4C84", VA = "0xFD4C84")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xFD4B38", Offset = "0xFD4B38", VA = "0xFD4B38")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xFD5098", Offset = "0xFD5098", VA = "0xFD5098")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xFD51DC", Offset = "0xFD51DC", VA = "0xFD51DC")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xFD521C", Offset = "0xFD521C", VA = "0xFD521C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xFD5340", Offset = "0xFD5340", VA = "0xFD5340")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xFD541C", Offset = "0xFD541C", VA = "0xFD541C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xFD5B94", Offset = "0xFD5B94", VA = "0xFD5B94", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xFD5CE8", Offset = "0xFD5CE8", VA = "0xFD5CE8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xFD5ED4", Offset = "0xFD5ED4", VA = "0xFD5ED4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xFD5F44", Offset = "0xFD5F44", VA = "0xFD5F44", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xFD5FB4", Offset = "0xFD5FB4", VA = "0xFD5FB4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xFD61B0", Offset = "0xFD61B0", VA = "0xFD61B0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xFD4F84", Offset = "0xFD4F84", VA = "0xFD4F84")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xFD5530", Offset = "0xFD5530", VA = "0xFD5530")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xFD6420", Offset = "0xFD6420", VA = "0xFD6420", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xFD645C", Offset = "0xFD645C", VA = "0xFD645C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xFD7A98", Offset = "0xFD7A98", VA = "0xFD7A98")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xFD5680", Offset = "0xFD5680", VA = "0xFD5680")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xFD6868", Offset = "0xFD6868", VA = "0xFD6868")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xFD7EEC", Offset = "0xFD7EEC", VA = "0xFD7EEC")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xFD7F28", Offset = "0xFD7F28", VA = "0xFD7F28")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xFD795C", Offset = "0xFD795C", VA = "0xFD795C")]
		private void Write()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xFD9680", Offset = "0xFD9680", VA = "0xFD9680")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xFD9D7C", Offset = "0xFD9D7C", VA = "0xFD9D7C")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xFE6AB0", Offset = "0xFE6AB0", VA = "0xFE6AB0")]
		public void Start()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xFE70DC", Offset = "0xFE70DC", VA = "0xFE70DC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xFE7670", Offset = "0xFE7670", VA = "0xFE7670")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xFE7720", Offset = "0xFE7720", VA = "0xFE7720")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xFE7838", Offset = "0xFE7838", VA = "0xFE7838")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class TwistSolver
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		[Range(0f, 1f)]
		public float parentChildCrossfade;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
		public float twistAngleOffset;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xFE7890", Offset = "0xFE7890", VA = "0xFE7890")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xFE6C78", Offset = "0xFE6C78", VA = "0xFE6C78")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xFE718C", Offset = "0xFE718C", VA = "0xFE718C")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class InteractionEffector
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000081")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xFE7978", Offset = "0xFE7978", VA = "0xFE7978")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xFE7980", Offset = "0xFE7980", VA = "0xFE7980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0xFE7988", Offset = "0xFE7988", VA = "0xFE7988")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xFE7990", Offset = "0xFE7990", VA = "0xFE7990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xFE799C", Offset = "0xFE799C", VA = "0xFE799C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xFE79A4", Offset = "0xFE79A4", VA = "0xFE79A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0xFE79AC", Offset = "0xFE79AC", VA = "0xFE79AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xFE9B70", Offset = "0xFE9B70", VA = "0xFE9B70")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xFE7A0C", Offset = "0xFE7A0C", VA = "0xFE7A0C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xFE7A9C", Offset = "0xFE7A9C", VA = "0xFE7A9C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xFE7B28", Offset = "0xFE7B28", VA = "0xFE7B28")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xFE7C94", Offset = "0xFE7C94", VA = "0xFE7C94")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xFE8070", Offset = "0xFE8070", VA = "0xFE8070")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xFE8190", Offset = "0xFE8190", VA = "0xFE8190")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xFE81E4", Offset = "0xFE81E4", VA = "0xFE81E4")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xFE8834", Offset = "0xFE8834", VA = "0xFE8834")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xFE9328", Offset = "0xFE9328", VA = "0xFE9328")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xFE9548", Offset = "0xFE9548", VA = "0xFE9548")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xFE9A24", Offset = "0xFE9A24", VA = "0xFE9A24")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xFE9CE4", Offset = "0xFE9CE4", VA = "0xFE9CE4")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xFE9FAC", Offset = "0xFE9FAC", VA = "0xFE9FAC")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xFEA0BC", Offset = "0xFEA0BC", VA = "0xFEA0BC")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xFEA154", Offset = "0xFEA154", VA = "0xFEA154")]
		public void Update()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xFEA344", Offset = "0xFEA344", VA = "0xFEA344")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xFEA3EC", Offset = "0xFEA3EC", VA = "0xFEA3EC")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xFEA498", Offset = "0xFEA498", VA = "0xFEA498")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000088")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000502")]
			[Address(RVA = "0xFE9BA0", Offset = "0xFE9BA0", VA = "0xFE9BA0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0xFEB39C", Offset = "0xFEB39C", VA = "0xFEB39C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public class Message
		{
			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x4000478")]
			private const string empty = "";

			[Token(Token = "0x6000504")]
			[Address(RVA = "0xFEB2A4", Offset = "0xFEB2A4", VA = "0xFEB2A4")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0xFEB3A4", Offset = "0xFEB3A4", VA = "0xFEB3A4")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400047F")]
			private const string empty = "";

			[Token(Token = "0x6000506")]
			[Address(RVA = "0xFEB1C8", Offset = "0xFEB1C8", VA = "0xFEB1C8")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0xFEB3AC", Offset = "0xFEB3AC", VA = "0xFEB3AC")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0xFEB45C", Offset = "0xFEB45C", VA = "0xFEB45C")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0xFEB534", Offset = "0xFEB534", VA = "0xFEB534")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200008C")]
			public enum Type
			{
				[Token(Token = "0x4000483")]
				PositionWeight,
				[Token(Token = "0x4000484")]
				RotationWeight,
				[Token(Token = "0x4000485")]
				PositionOffsetX,
				[Token(Token = "0x4000486")]
				PositionOffsetY,
				[Token(Token = "0x4000487")]
				PositionOffsetZ,
				[Token(Token = "0x4000488")]
				Pull,
				[Token(Token = "0x4000489")]
				Reach,
				[Token(Token = "0x400048A")]
				RotateBoneWeight,
				[Token(Token = "0x400048B")]
				Push,
				[Token(Token = "0x400048C")]
				PushParent,
				[Token(Token = "0x400048D")]
				PoserWeight,
				[Token(Token = "0x400048E")]
				BendGoalWeight
			}

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x600050A")]
			[Address(RVA = "0xFEAAD8", Offset = "0xFEAAD8", VA = "0xFEAAD8")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0xFEB548", Offset = "0xFEB548", VA = "0xFEB548")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public class Multiplier
		{
			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x600050C")]
			[Address(RVA = "0xFEB0E0", Offset = "0xFEB0E0", VA = "0xFEB0E0")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0xFEB550", Offset = "0xFEB550", VA = "0xFEB550")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xFEA6CC", Offset = "0xFEA6CC", VA = "0xFEA6CC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xFEA6D4", Offset = "0xFEA6D4", VA = "0xFEA6D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xFEA6DC", Offset = "0xFEA6DC", VA = "0xFEA6DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xFEA6E4", Offset = "0xFEA6E4", VA = "0xFEA6E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xFEA89C", Offset = "0xFEA89C", VA = "0xFEA89C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xFE9C64", Offset = "0xFE9C64", VA = "0xFE9C64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xFEA4AC", Offset = "0xFEA4AC", VA = "0xFEA4AC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xFEA4F0", Offset = "0xFEA4F0", VA = "0xFEA4F0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xFEA534", Offset = "0xFEA534", VA = "0xFEA534")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xFEA578", Offset = "0xFEA578", VA = "0xFEA578")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xFEA5BC", Offset = "0xFEA5BC", VA = "0xFEA5BC")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xFEA600", Offset = "0xFEA600", VA = "0xFEA600")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xFEA644", Offset = "0xFEA644", VA = "0xFEA644")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xFEA688", Offset = "0xFEA688", VA = "0xFEA688")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xFEA6EC", Offset = "0xFEA6EC", VA = "0xFEA6EC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xFEA91C", Offset = "0xFEA91C", VA = "0xFEA91C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xFE87A0", Offset = "0xFE87A0", VA = "0xFE87A0")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xFEAA6C", Offset = "0xFEAA6C", VA = "0xFEAA6C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xFE8664", Offset = "0xFE8664", VA = "0xFE8664")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xFE8798", Offset = "0xFE8798", VA = "0xFE8798")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xFE8F18", Offset = "0xFE8F18", VA = "0xFE8F18")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xFE9810", Offset = "0xFE9810", VA = "0xFE9810")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xFEB110", Offset = "0xFEB110", VA = "0xFEB110")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xFEAAF4", Offset = "0xFEAAF4", VA = "0xFEAAF4")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xFEAA74", Offset = "0xFEAA74", VA = "0xFEAA74")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xFEB084", Offset = "0xFEB084", VA = "0xFEB084")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xFEB114", Offset = "0xFEB114", VA = "0xFEB114")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xFEB170", Offset = "0xFEB170", VA = "0xFEB170")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008F")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000090")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Triggering")]
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		public Collider characterCollider;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		[Space(10f)]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700008A")]
		public bool inInteraction
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0xFEB780", Offset = "0xFEB780", VA = "0xFEB780")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xFED1E0", Offset = "0xFED1E0", VA = "0xFED1E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000531")]
			[Address(RVA = "0xFED1E8", Offset = "0xFED1E8", VA = "0xFED1E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0xFED1F0", Offset = "0xFED1F0", VA = "0xFED1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000533")]
			[Address(RVA = "0xFED1F8", Offset = "0xFED1F8", VA = "0xFED1F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool initiated
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xFED200", Offset = "0xFED200", VA = "0xFED200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000535")]
			[Address(RVA = "0xFED208", Offset = "0xFED208", VA = "0xFED208")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xFEB560", Offset = "0xFEB560", VA = "0xFEB560")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xFEB5A4", Offset = "0xFEB5A4", VA = "0xFEB5A4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xFEB5E8", Offset = "0xFEB5E8", VA = "0xFEB5E8")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xFEB62C", Offset = "0xFEB62C", VA = "0xFEB62C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xFEB670", Offset = "0xFEB670", VA = "0xFEB670")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xFEB6B4", Offset = "0xFEB6B4", VA = "0xFEB6B4")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xFEB6F8", Offset = "0xFEB6F8", VA = "0xFEB6F8")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xFEB73C", Offset = "0xFEB73C", VA = "0xFEB73C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xFEB8F8", Offset = "0xFEB8F8", VA = "0xFEB8F8")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xFEB9B0", Offset = "0xFEB9B0", VA = "0xFEB9B0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xFEBA68", Offset = "0xFEBA68", VA = "0xFEBA68")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xFEBB00", Offset = "0xFEBB00", VA = "0xFEBB00")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xFEBBE4", Offset = "0xFEBBE4", VA = "0xFEBBE4")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xFEBCDC", Offset = "0xFEBCDC", VA = "0xFEBCDC")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xFEBD60", Offset = "0xFEBD60", VA = "0xFEBD60")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xFEBDE4", Offset = "0xFEBDE4", VA = "0xFEBDE4")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xFEBE68", Offset = "0xFEBE68", VA = "0xFEBE68")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xFEBED0", Offset = "0xFEBED0", VA = "0xFEBED0")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xFEBF38", Offset = "0xFEBF38", VA = "0xFEBF38")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xFEBF94", Offset = "0xFEBF94", VA = "0xFEBF94")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xFEC014", Offset = "0xFEC014", VA = "0xFEC014")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xFEC0BC", Offset = "0xFEC0BC", VA = "0xFEC0BC")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xFEC18C", Offset = "0xFEC18C", VA = "0xFEC18C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xFEC41C", Offset = "0xFEC41C", VA = "0xFEC41C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xFEC5D8", Offset = "0xFEC5D8", VA = "0xFEC5D8")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xFEC840", Offset = "0xFEC840", VA = "0xFEC840")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xFECACC", Offset = "0xFECACC", VA = "0xFECACC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xFECB04", Offset = "0xFECB04", VA = "0xFECB04")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xFECB64", Offset = "0xFECB64", VA = "0xFECB64")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xFECC6C", Offset = "0xFECC6C", VA = "0xFECC6C")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xFECE4C", Offset = "0xFECE4C", VA = "0xFECE4C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xFED0C0", Offset = "0xFED0C0", VA = "0xFED0C0")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xFEC928", Offset = "0xFEC928", VA = "0xFEC928")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xFED214", Offset = "0xFED214", VA = "0xFED214")]
		public void Start()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xFED9AC", Offset = "0xFED9AC", VA = "0xFED9AC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xFED9CC", Offset = "0xFED9CC", VA = "0xFED9CC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xFED9E8", Offset = "0xFED9E8", VA = "0xFED9E8")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xFEDA04", Offset = "0xFEDA04", VA = "0xFEDA04")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xFEDA58", Offset = "0xFEDA58", VA = "0xFEDA58")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xFEDBC4", Offset = "0xFEDBC4", VA = "0xFEDBC4")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xFEDCC0", Offset = "0xFEDCC0", VA = "0xFEDCC0")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xFEDE6C", Offset = "0xFEDE6C", VA = "0xFEDE6C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xFEDF50", Offset = "0xFEDF50", VA = "0xFEDF50")]
		public void Update()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xFEE210", Offset = "0xFEE210", VA = "0xFEE210")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xFED764", Offset = "0xFED764", VA = "0xFED764")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xFEE340", Offset = "0xFEE340", VA = "0xFEE340")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xFEE44C", Offset = "0xFEE44C", VA = "0xFEE44C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xFEE4D4", Offset = "0xFEE4D4", VA = "0xFEE4D4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xFEE594", Offset = "0xFEE594", VA = "0xFEE594")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xFEE5AC", Offset = "0xFEE5AC", VA = "0xFEE5AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xFEB818", Offset = "0xFEB818", VA = "0xFEB818")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xFEC308", Offset = "0xFEC308", VA = "0xFEC308")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xFEE9A4", Offset = "0xFEE9A4", VA = "0xFEE9A4")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public enum RotationMode
		{
			[Token(Token = "0x40004B7")]
			TwoDOF,
			[Token(Token = "0x40004B8")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class Multiplier
		{
			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x600055E")]
			[Address(RVA = "0xFF09FC", Offset = "0xFF09FC", VA = "0xFF09FC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		[Range(0f, 1f)]
		public float threeDOFWeight;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xFF0038", Offset = "0xFF0038", VA = "0xFF0038")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xFF007C", Offset = "0xFF007C", VA = "0xFF007C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xFF00C0", Offset = "0xFF00C0", VA = "0xFF00C0")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xFF0104", Offset = "0xFF0104", VA = "0xFF0104")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xFF0148", Offset = "0xFF0148", VA = "0xFF0148")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xFF018C", Offset = "0xFF018C", VA = "0xFF018C")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xFF01D0", Offset = "0xFF01D0", VA = "0xFF01D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xFF0214", Offset = "0xFF0214", VA = "0xFF0214")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xFF0258", Offset = "0xFF0258", VA = "0xFF0258")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xFF02BC", Offset = "0xFF02BC", VA = "0xFF02BC")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xFF0348", Offset = "0xFF0348", VA = "0xFF0348")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xFF0988", Offset = "0xFF0988", VA = "0xFF0988")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000095")]
		public class CharacterPosition
		{
			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x1700008E")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000566")]
				[Address(RVA = "0xFF0E14", Offset = "0xFF0E14", VA = "0xFF0E14")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000567")]
				[Address(RVA = "0xFF0E20", Offset = "0xFF0E20", VA = "0xFF0E20")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0xFF0EE0", Offset = "0xFF0EE0", VA = "0xFF0EE0")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0xFF1644", Offset = "0xFF1644", VA = "0xFF1644")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000096")]
		public class CameraPosition
		{
			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 180f)]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			public float maxAngle;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x600056A")]
			[Address(RVA = "0xFF1658", Offset = "0xFF1658", VA = "0xFF1658")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0xFF17D0", Offset = "0xFF17D0", VA = "0xFF17D0")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xFF1AD8", Offset = "0xFF1AD8", VA = "0xFF1AD8")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000098")]
			public class Interaction
			{
				[Token(Token = "0x40004CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004CE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600056F")]
				[Address(RVA = "0xFF1B5C", Offset = "0xFF1B5C", VA = "0xFF1B5C")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x600056D")]
			[Address(RVA = "0xFF0D0C", Offset = "0xFF0D0C", VA = "0xFF0D0C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0xFF1B4C", Offset = "0xFF1B4C", VA = "0xFF1B4C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xFF0A04", Offset = "0xFF0A04", VA = "0xFF0A04")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xFF0A48", Offset = "0xFF0A48", VA = "0xFF0A48")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xFF0A8C", Offset = "0xFF0A8C", VA = "0xFF0A8C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xFF0AD0", Offset = "0xFF0AD0", VA = "0xFF0AD0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xFF0B14", Offset = "0xFF0B14", VA = "0xFF0B14")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xFF0B58", Offset = "0xFF0B58", VA = "0xFF0B58")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xFF0DBC", Offset = "0xFF0DBC", VA = "0xFF0DBC")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x200009A")]
		public class Map
		{
			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000577")]
			[Address(RVA = "0xFF1E50", Offset = "0xFF1E50", VA = "0xFF1E50")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0xFF218C", Offset = "0xFF218C", VA = "0xFF218C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0xFF214C", Offset = "0xFF214C", VA = "0xFF214C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0xFF1FD0", Offset = "0xFF1FD0", VA = "0xFF1FD0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xFF1B64", Offset = "0xFF1B64", VA = "0xFF1B64", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xFF1EDC", Offset = "0xFF1EDC", VA = "0xFF1EDC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xFF1EE0", Offset = "0xFF1EE0", VA = "0xFF1EE0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xFF20F0", Offset = "0xFF20F0", VA = "0xFF20F0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xFF1E80", Offset = "0xFF1E80", VA = "0xFF1E80")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xFF1DBC", Offset = "0xFF1DBC", VA = "0xFF1DBC")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xFF21D0", Offset = "0xFF21D0", VA = "0xFF21D0")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xFF21F0", Offset = "0xFF21F0", VA = "0xFF21F0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xFF22AC", Offset = "0xFF22AC", VA = "0xFF22AC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xFF2450", Offset = "0xFF2450", VA = "0xFF2450", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xFF2538", Offset = "0xFF2538", VA = "0xFF2538", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xFF2300", Offset = "0xFF2300", VA = "0xFF2300")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xFF2868", Offset = "0xFF2868", VA = "0xFF2868")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000581")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xFF2878", Offset = "0xFF2878", VA = "0xFF2878")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000583")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000584")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000585")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xFF2884", Offset = "0xFF2884", VA = "0xFF2884", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xFF28C8", Offset = "0xFF28C8", VA = "0xFF28C8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xFF28F4", Offset = "0xFF28F4", VA = "0xFF28F4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xFF21E0", Offset = "0xFF21E0", VA = "0xFF21E0")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class RagdollUtility : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public class Rigidbone
		{
			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xFF2FC0", Offset = "0xFF2FC0", VA = "0xFF2FC0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xFF3B14", Offset = "0xFF3B14", VA = "0xFF3B14")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xFF38D4", Offset = "0xFF38D4", VA = "0xFF38D4")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200009F")]
		public class Child
		{
			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xFF3114", Offset = "0xFF3114", VA = "0xFF3114")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xFF3C30", Offset = "0xFF3C30", VA = "0xFF3C30")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xFF3BE8", Offset = "0xFF3BE8", VA = "0xFF3BE8")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0xFF4134", Offset = "0xFF4134", VA = "0xFF4134", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0xFF417C", Offset = "0xFF417C", VA = "0xFF417C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xFF3170", Offset = "0xFF3170", VA = "0xFF3170")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xFF3F50", Offset = "0xFF3F50", VA = "0xFF3F50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xFF3F54", Offset = "0xFF3F54", VA = "0xFF3F54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xFF413C", Offset = "0xFF413C", VA = "0xFF413C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private IK[] allIKComponents;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool[] fixTransforms;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float ragdollWeight;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float ragdollWeightV;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool fixedFrame;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool IKUsed;

		[Token(Token = "0x17000090")]
		public float RagdollWeight
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0xFF2B94", Offset = "0xFF2B94", VA = "0xFF2B94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xFF2B9C", Offset = "0xFF2B9C", VA = "0xFF2B9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public float RagdollWeightV
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xFF2BA4", Offset = "0xFF2BA4", VA = "0xFF2BA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xFF2BAC", Offset = "0xFF2BAC", VA = "0xFF2BAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0xFF299C", Offset = "0xFF299C", VA = "0xFF299C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		private bool ikUsed
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0xFF34FC", Offset = "0xFF34FC", VA = "0xFF34FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xFF290C", Offset = "0xFF290C", VA = "0xFF290C")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xFF2A00", Offset = "0xFF2A00", VA = "0xFF2A00")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xFF2BB4", Offset = "0xFF2BB4", VA = "0xFF2BB4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xFF2B2C", Offset = "0xFF2B2C", VA = "0xFF2B2C")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__27))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xFF3198", Offset = "0xFF3198", VA = "0xFF3198")]
		private void Update()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xFF33C0", Offset = "0xFF33C0", VA = "0xFF33C0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xFF3460", Offset = "0xFF3460", VA = "0xFF3460")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xFF365C", Offset = "0xFF365C", VA = "0xFF365C")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xFF34D0", Offset = "0xFF34D0", VA = "0xFF34D0")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xFF3628", Offset = "0xFF3628", VA = "0xFF3628")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xFF36DC", Offset = "0xFF36DC", VA = "0xFF36DC")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xFF3680", Offset = "0xFF3680", VA = "0xFF3680")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xFF2AD0", Offset = "0xFF2AD0", VA = "0xFF2AD0")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xFF3C2C", Offset = "0xFF3C2C", VA = "0xFF3C2C")]
		public void OuternalStoreLocalState()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xFF33F4", Offset = "0xFF33F4", VA = "0xFF33F4")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xFF3D40", Offset = "0xFF3D40", VA = "0xFF3D40")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xFF3E58", Offset = "0xFF3E58", VA = "0xFF3E58")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000096")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xFF45E8", Offset = "0xFF45E8", VA = "0xFF45E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000097")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xFF45F4", Offset = "0xFF45F4", VA = "0xFF45F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000098")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xFF4624", Offset = "0xFF4624", VA = "0xFF4624")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xFF462C", Offset = "0xFF462C", VA = "0xFF462C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xFF4184", Offset = "0xFF4184", VA = "0xFF4184")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xFF41C0", Offset = "0xFF41C0", VA = "0xFF41C0")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xFF41D8", Offset = "0xFF41D8", VA = "0xFF41D8")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xFF4558", Offset = "0xFF4558", VA = "0xFF4558")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xFF45BC", Offset = "0xFF45BC", VA = "0xFF45BC")]
		public void Disable()
		{
		}

		[Token(Token = "0x60005B6")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xFF445C", Offset = "0xFF445C", VA = "0xFF445C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xFF4638", Offset = "0xFF4638", VA = "0xFF4638")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xFF463C", Offset = "0xFF463C", VA = "0xFF463C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xFF4664", Offset = "0xFF4664", VA = "0xFF4664")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xFF4738", Offset = "0xFF4738", VA = "0xFF4738")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xFF4990", Offset = "0xFF4990", VA = "0xFF4990")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xFF4AE4", Offset = "0xFF4AE4", VA = "0xFF4AE4")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xFF4B44", Offset = "0xFF4B44", VA = "0xFF4B44")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xFF4B88", Offset = "0xFF4B88", VA = "0xFF4B88")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xFF4BCC", Offset = "0xFF4BCC", VA = "0xFF4BCC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xFF4C10", Offset = "0xFF4C10", VA = "0xFF4C10")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xFF4C54", Offset = "0xFF4C54", VA = "0xFF4C54", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xFF4C8C", Offset = "0xFF4C8C", VA = "0xFF4C8C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xFF4FB0", Offset = "0xFF4FB0", VA = "0xFF4FB0")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xFF4FC0", Offset = "0xFF4FC0", VA = "0xFF4FC0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xFF5004", Offset = "0xFF5004", VA = "0xFF5004")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xFF5048", Offset = "0xFF5048", VA = "0xFF5048")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xFF508C", Offset = "0xFF508C", VA = "0xFF508C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xFF50D0", Offset = "0xFF50D0", VA = "0xFF50D0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xFF50D4", Offset = "0xFF50D4", VA = "0xFF50D4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xFF52F4", Offset = "0xFF52F4", VA = "0xFF52F4")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000A5")]
		public class ReachCone
		{
			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000099")]
			public Vector3 o
			{
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0xFF703C", Offset = "0xFF703C", VA = "0xFF703C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 a
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0xFF7068", Offset = "0xFF7068", VA = "0xFF7068")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public Vector3 b
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0xFF7098", Offset = "0xFF7098", VA = "0xFF7098")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009C")]
			public Vector3 c
			{
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0xFF70C8", Offset = "0xFF70C8", VA = "0xFF70C8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009D")]
			public bool isValid
			{
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0xFF6584", Offset = "0xFF6584", VA = "0xFF6584")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xFF6A28", Offset = "0xFF6A28", VA = "0xFF6A28")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0xFF6B8C", Offset = "0xFF6B8C", VA = "0xFF6B8C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A6")]
		public class LimitPoint
		{
			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xFF6594", Offset = "0xFF6594", VA = "0xFF6594")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xFF530C", Offset = "0xFF530C", VA = "0xFF530C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xFF5350", Offset = "0xFF5350", VA = "0xFF5350")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xFF5394", Offset = "0xFF5394", VA = "0xFF5394")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xFF53D8", Offset = "0xFF53D8", VA = "0xFF53D8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xFF541C", Offset = "0xFF541C", VA = "0xFF541C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xFF5A54", Offset = "0xFF5A54", VA = "0xFF5A54", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xFF5ADC", Offset = "0xFF5ADC", VA = "0xFF5ADC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xFF60BC", Offset = "0xFF60BC", VA = "0xFF60BC")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xFF54A8", Offset = "0xFF54A8", VA = "0xFF54A8")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xFF65F8", Offset = "0xFF65F8", VA = "0xFF65F8")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xFF6E00", Offset = "0xFF6E00", VA = "0xFF6E00")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xFF6E48", Offset = "0xFF6E48", VA = "0xFF6E48")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xFF6EA8", Offset = "0xFF6EA8", VA = "0xFF6EA8")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xFF5E18", Offset = "0xFF5E18", VA = "0xFF5E18")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xFF6F14", Offset = "0xFF6F14", VA = "0xFF6F14")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xFF6FE0", Offset = "0xFF6FE0", VA = "0xFF6FE0")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xFF70F8", Offset = "0xFF70F8", VA = "0xFF70F8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xFF713C", Offset = "0xFF713C", VA = "0xFF713C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xFF7180", Offset = "0xFF7180", VA = "0xFF7180")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xFF71C4", Offset = "0xFF71C4", VA = "0xFF71C4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xFF7208", Offset = "0xFF7208", VA = "0xFF7208")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xFF7224", Offset = "0xFF7224", VA = "0xFF7224", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xFF725C", Offset = "0xFF725C", VA = "0xFF725C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xFF7608", Offset = "0xFF7608", VA = "0xFF7608")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700009F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0xFF85E8", Offset = "0xFF85E8", VA = "0xFF85E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0xFF8630", Offset = "0xFF8630", VA = "0xFF8630", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xFF83F4", Offset = "0xFF83F4", VA = "0xFF83F4")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xFF8500", Offset = "0xFF8500", VA = "0xFF8500", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xFF8504", Offset = "0xFF8504", VA = "0xFF8504", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xFF85F0", Offset = "0xFF85F0", VA = "0xFF85F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight of the IK solver.")]
		public float weight;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x1700009E")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0xFF7690", Offset = "0xFF7690", VA = "0xFF7690")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xFF7614", Offset = "0xFF7614", VA = "0xFF7614")]
		private void Start()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xFF7714", Offset = "0xFF7714", VA = "0xFF7714")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xFF7F64", Offset = "0xFF7F64", VA = "0xFF7F64")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xFF80E8", Offset = "0xFF80E8", VA = "0xFF80E8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xFF838C", Offset = "0xFF838C", VA = "0xFF838C")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xFF841C", Offset = "0xFF841C", VA = "0xFF841C")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AB")]
		public class Pose
		{
			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xFF8708", Offset = "0xFF8708", VA = "0xFF8708")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xFF8C78", Offset = "0xFF8C78", VA = "0xFF8C78")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xFF8C80", Offset = "0xFF8C80", VA = "0xFF8C80")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xFF8638", Offset = "0xFF8638", VA = "0xFF8638")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xFF8BB8", Offset = "0xFF8BB8", VA = "0xFF8BB8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xFF8C18", Offset = "0xFF8C18", VA = "0xFF8C18")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000AD")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000AE")]
			public class EffectorLink
			{
				[Token(Token = "0x400054E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400054F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000604")]
				[Address(RVA = "0xFF9144", Offset = "0xFF9144", VA = "0xFF9144")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xFF8DEC", Offset = "0xFF8DEC", VA = "0xFF8DEC")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0xFF911C", Offset = "0xFF911C", VA = "0xFF911C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0xFF912C", Offset = "0xFF912C", VA = "0xFF912C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xFF8C9C", Offset = "0xFF8C9C", VA = "0xFF8C9C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xFF90FC", Offset = "0xFF90FC", VA = "0xFF90FC")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xFF914C", Offset = "0xFF914C", VA = "0xFF914C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xFF91B4", Offset = "0xFF91B4", VA = "0xFF91B4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xFF9454", Offset = "0xFF9454", VA = "0xFF9454")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xFF9470", Offset = "0xFF9470", VA = "0xFF9470")]
		private void Start()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xFF9540", Offset = "0xFF9540", VA = "0xFF9540")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xFF97D4", Offset = "0xFF97D4", VA = "0xFF97D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xFF98E0", Offset = "0xFF98E0", VA = "0xFF98E0")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x170000A1")]
		public IK ik
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0xFF98F0", Offset = "0xFF98F0", VA = "0xFF98F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0xFF98F8", Offset = "0xFF98F8", VA = "0xFF98F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xFF9900", Offset = "0xFF9900", VA = "0xFF9900")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xFF9A74", Offset = "0xFF9A74", VA = "0xFF9A74")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xFF9CD0", Offset = "0xFF9CD0", VA = "0xFF9CD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xFF9DFC", Offset = "0xFF9DFC", VA = "0xFF9DFC")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xFF9FB0", Offset = "0xFF9FB0", VA = "0xFF9FB0")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xFFA1B4", Offset = "0xFFA1B4", VA = "0xFFA1B4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xFFA428", Offset = "0xFFA428", VA = "0xFFA428")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000A2")]
		public bool poseStored
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0xFF9B50", Offset = "0xFF9B50", VA = "0xFF9B50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xFF9E70", Offset = "0xFF9E70", VA = "0xFF9E70")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xFF9B74", Offset = "0xFF9B74", VA = "0xFF9B74")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xFFA480", Offset = "0xFFA480", VA = "0xFFA480")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A4")]
			public bool inProgress
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0xFFA5A0", Offset = "0xFFA5A0", VA = "0xFFA5A0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A5")]
			protected float crossFader
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0xFFAAE0", Offset = "0xFFAAE0", VA = "0xFFAAE0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061F")]
				[Address(RVA = "0xFFAAE8", Offset = "0xFFAAE8", VA = "0xFFAAE8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected float timer
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0xFFAAF0", Offset = "0xFFAAF0", VA = "0xFFAAF0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000621")]
				[Address(RVA = "0xFFAAF8", Offset = "0xFFAAF8", VA = "0xFFAAF8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 force
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0xFFAB00", Offset = "0xFFAB00", VA = "0xFFAB00")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000623")]
				[Address(RVA = "0xFFAB0C", Offset = "0xFFAB0C", VA = "0xFFAB0C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected Vector3 point
			{
				[Token(Token = "0x6000624")]
				[Address(RVA = "0xFFAB18", Offset = "0xFFAB18", VA = "0xFFAB18")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000625")]
				[Address(RVA = "0xFFAB24", Offset = "0xFFAB24", VA = "0xFFAB24")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0xFFA9A8", Offset = "0xFFA9A8", VA = "0xFFA9A8")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0xFFA674", Offset = "0xFFA674", VA = "0xFFA674")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000628")]
			protected abstract float GetLength();

			[Token(Token = "0x6000629")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600062A")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600062B")]
			[Address(RVA = "0xFFAB30", Offset = "0xFFAB30", VA = "0xFFAB30")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B5")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B6")]
			public class EffectorLink
			{
				[Token(Token = "0x400056D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400056E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x400056F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000570")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000630")]
				[Address(RVA = "0xFFAE64", Offset = "0xFFAE64", VA = "0xFFAE64")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000631")]
				[Address(RVA = "0xFFACC0", Offset = "0xFFACC0", VA = "0xFFACC0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000632")]
				[Address(RVA = "0xFFAF14", Offset = "0xFFAF14", VA = "0xFFAF14")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600062C")]
			[Address(RVA = "0xFFAB44", Offset = "0xFFAB44", VA = "0xFFAB44", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0xFFAC60", Offset = "0xFFAC60", VA = "0xFFAC60", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0xFFACD4", Offset = "0xFFACD4", VA = "0xFFACD4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0xFFAF00", Offset = "0xFFAF00", VA = "0xFFAF00")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B8")]
			public class BoneLink
			{
				[Token(Token = "0x4000574")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x4000575")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x4000576")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000577")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000637")]
				[Address(RVA = "0xFFB1D4", Offset = "0xFFB1D4", VA = "0xFFB1D4")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000638")]
				[Address(RVA = "0xFFB000", Offset = "0xFFB000", VA = "0xFFB000")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000639")]
				[Address(RVA = "0xFFB374", Offset = "0xFFB374", VA = "0xFFB374")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000633")]
			[Address(RVA = "0xFFAF1C", Offset = "0xFFAF1C", VA = "0xFFAF1C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0xFFAFA8", Offset = "0xFFAFA8", VA = "0xFFAFA8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0xFFB00C", Offset = "0xFFB00C", VA = "0xFFB00C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0xFFB360", Offset = "0xFFB360", VA = "0xFFB360")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000A3")]
		public bool inProgress
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0xFFA504", Offset = "0xFFA504", VA = "0xFFA504")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xFFA5B4", Offset = "0xFFA5B4", VA = "0xFFA5B4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xFFA74C", Offset = "0xFFA74C", VA = "0xFFA74C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xFFAAD0", Offset = "0xFFAAD0", VA = "0xFFAAD0")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000BA")]
		public abstract class Offset
		{
			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A9")]
			protected float crossFader
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0xFFB8E4", Offset = "0xFFB8E4", VA = "0xFFB8E4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063E")]
				[Address(RVA = "0xFFB8EC", Offset = "0xFFB8EC", VA = "0xFFB8EC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			protected float timer
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0xFFB8F4", Offset = "0xFFB8F4", VA = "0xFFB8F4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000640")]
				[Address(RVA = "0xFFB8FC", Offset = "0xFFB8FC", VA = "0xFFB8FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			protected Vector3 force
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0xFFB904", Offset = "0xFFB904", VA = "0xFFB904")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000642")]
				[Address(RVA = "0xFFB910", Offset = "0xFFB910", VA = "0xFFB910")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000AC")]
			protected Vector3 point
			{
				[Token(Token = "0x6000643")]
				[Address(RVA = "0xFFB91C", Offset = "0xFFB91C", VA = "0xFFB91C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000644")]
				[Address(RVA = "0xFFB928", Offset = "0xFFB928", VA = "0xFFB928")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xFFB794", Offset = "0xFFB794", VA = "0xFFB794")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0xFFB490", Offset = "0xFFB490", VA = "0xFFB490")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000647")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000648")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000649")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600064A")]
			[Address(RVA = "0xFFB934", Offset = "0xFFB934", VA = "0xFFB934")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BB")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000BC")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000588")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000589")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x400058A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400058B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600064F")]
				[Address(RVA = "0xFFBD18", Offset = "0xFFBD18", VA = "0xFFBD18")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000650")]
				[Address(RVA = "0xFFBB3C", Offset = "0xFFBB3C", VA = "0xFFBB3C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000651")]
				[Address(RVA = "0xFFBDAC", Offset = "0xFFBDAC", VA = "0xFFBDAC")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600064B")]
			[Address(RVA = "0xFFB948", Offset = "0xFFB948", VA = "0xFFB948", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0xFFBADC", Offset = "0xFFBADC", VA = "0xFFBADC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0xFFBB50", Offset = "0xFFBB50", VA = "0xFFBB50", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0xFFBD90", Offset = "0xFFBD90", VA = "0xFFBD90")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000BE")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400058F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000590")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x4000591")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000592")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000656")]
				[Address(RVA = "0xFFC16C", Offset = "0xFFC16C", VA = "0xFFC16C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000657")]
				[Address(RVA = "0xFFBEE4", Offset = "0xFFBEE4", VA = "0xFFBEE4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000658")]
				[Address(RVA = "0xFFC288", Offset = "0xFFC288", VA = "0xFFC288")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000652")]
			[Address(RVA = "0xFFBDB4", Offset = "0xFFBDB4", VA = "0xFFBDB4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0xFFBE8C", Offset = "0xFFBE8C", VA = "0xFFBE8C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0xFFBEF0", Offset = "0xFFBEF0", VA = "0xFFBEF0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0xFFC274", Offset = "0xFFC274", VA = "0xFFC274")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xFFB3D8", Offset = "0xFFB3D8", VA = "0xFFB3D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xFFB570", Offset = "0xFFB570", VA = "0xFFB570")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xFFB8C4", Offset = "0xFFB8C4", VA = "0xFFB8C4")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000C1")]
			public class EffectorLink
			{
				[Token(Token = "0x40005A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x600065F")]
				[Address(RVA = "0xFFC850", Offset = "0xFFC850", VA = "0xFFC850")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600065C")]
			[Address(RVA = "0xFFC358", Offset = "0xFFC358", VA = "0xFFC358")]
			public void Reset()
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xFFC4D8", Offset = "0xFFC4D8", VA = "0xFFC4D8")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0xFFC834", Offset = "0xFFC834", VA = "0xFFC834")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xFFC2EC", Offset = "0xFFC2EC", VA = "0xFFC2EC")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xFFC434", Offset = "0xFFC434", VA = "0xFFC434", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xFFC824", Offset = "0xFFC824", VA = "0xFFC824")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000AD")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0xFFC8C0", Offset = "0xFFC8C0", VA = "0xFFC8C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xFFC858", Offset = "0xFFC858", VA = "0xFFC858")]
		private void Start()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xFFC944", Offset = "0xFFC944", VA = "0xFFC944")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xFFCE44", Offset = "0xFFCE44", VA = "0xFFCE44")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xFFCFC8", Offset = "0xFFCFC8", VA = "0xFFCFC8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xFFD214", Offset = "0xFFD214", VA = "0xFFD214")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public class OffsetLimits
		{
			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x600066E")]
			[Address(RVA = "0xFFD410", Offset = "0xFFD410", VA = "0xFFD410")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0xFFD680", Offset = "0xFFD680", VA = "0xFFD680")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0xFFD6F0", Offset = "0xFFD6F0", VA = "0xFFD6F0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0xFFD738", Offset = "0xFFD738", VA = "0xFFD738")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000675")]
				[Address(RVA = "0xFFD894", Offset = "0xFFD894", VA = "0xFFD894", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000677")]
				[Address(RVA = "0xFFD8DC", Offset = "0xFFD8DC", VA = "0xFFD8DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0xFFD314", Offset = "0xFFD314", VA = "0xFFD314")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0xFFD740", Offset = "0xFFD740", VA = "0xFFD740", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0xFFD744", Offset = "0xFFD744", VA = "0xFFD744", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0xFFD89C", Offset = "0xFFD89C", VA = "0xFFD89C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AE")]
		protected float deltaTime
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xFF8DCC", Offset = "0xFF8DCC", VA = "0xFF8DCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000667")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xFF9194", Offset = "0xFF9194", VA = "0xFF9194", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xFFD2AC", Offset = "0xFFD2AC", VA = "0xFFD2AC")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xFFD33C", Offset = "0xFFD33C", VA = "0xFFD33C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xFFC77C", Offset = "0xFFC77C", VA = "0xFFC77C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xFFD574", Offset = "0xFFD574", VA = "0xFFD574", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xFF910C", Offset = "0xFF910C", VA = "0xFF910C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000682")]
				[Address(RVA = "0xFFDCE8", Offset = "0xFFDCE8", VA = "0xFFDCE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000684")]
				[Address(RVA = "0xFFDD30", Offset = "0xFFDD30", VA = "0xFFDD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0xFFD98C", Offset = "0xFFD98C", VA = "0xFFD98C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0xFFDB94", Offset = "0xFFDB94", VA = "0xFFDB94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0xFFDB98", Offset = "0xFFDB98", VA = "0xFFDB98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0xFFDCF0", Offset = "0xFFDCF0", VA = "0xFFDCF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000B1")]
		protected float deltaTime
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0xFFD8E4", Offset = "0xFFD8E4", VA = "0xFFD8E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000679")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xFFD904", Offset = "0xFFD904", VA = "0xFFD904", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xFFD924", Offset = "0xFFD924", VA = "0xFFD924")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xFFD9B4", Offset = "0xFFD9B4", VA = "0xFFD9B4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xFFDA88", Offset = "0xFFDA88", VA = "0xFFDA88", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xFFB8D4", Offset = "0xFFB8D4", VA = "0xFFB8D4")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public class EffectorLink
		{
			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000688")]
			[Address(RVA = "0xFFDD38", Offset = "0xFFDD38", VA = "0xFFDD38")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0xFFE084", Offset = "0xFFE084", VA = "0xFFE084")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xFF93A0", Offset = "0xFF93A0", VA = "0xFF93A0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xFFDF88", Offset = "0xFFDF88", VA = "0xFFDF88")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xFFE02C", Offset = "0xFFE02C", VA = "0xFFE02C")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000CC")]
			public class EffectorLink
			{
				[Token(Token = "0x40005DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005DE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x6000690")]
				[Address(RVA = "0xFFE6D8", Offset = "0xFFE6D8", VA = "0xFFE6D8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600068C")]
			[Address(RVA = "0xFFE0FC", Offset = "0xFFE0FC", VA = "0xFFE0FC")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0xFFE29C", Offset = "0xFFE29C", VA = "0xFFE29C")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0xFFE3A4", Offset = "0xFFE3A4", VA = "0xFFE3A4")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0xFFE6C4", Offset = "0xFFE6C4", VA = "0xFFE6C4")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xFFE08C", Offset = "0xFFE08C", VA = "0xFFE08C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xFFE28C", Offset = "0xFFE28C", VA = "0xFFE28C")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CE")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000CF")]
			public class EffectorLink
			{
				[Token(Token = "0x40005FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005FD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60006A0")]
				[Address(RVA = "0xFFFA2C", Offset = "0xFFFA2C", VA = "0xFFFA2C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600069D")]
			[Address(RVA = "0xFFE87C", Offset = "0xFFE87C", VA = "0xFFE87C")]
			public void Start()
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0xFFF3D8", Offset = "0xFFF3D8", VA = "0xFFF3D8")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0xFFFA18", Offset = "0xFFFA18", VA = "0xFFFA18")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public enum Handedness
		{
			[Token(Token = "0x40005FF")]
			Right,
			[Token(Token = "0x4000600")]
			Left
		}

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000B4")]
		public bool isFinished
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0xFFE6E0", Offset = "0xFFE6E0", VA = "0xFFE6E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B5")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0xFFF5DC", Offset = "0xFFF5DC", VA = "0xFFF5DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xFFF618", Offset = "0xFFF618", VA = "0xFFF618")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0xFFF5A4", Offset = "0xFFF5A4", VA = "0xFFF5A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0xFFF5C0", Offset = "0xFFF5C0", VA = "0xFFF5C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xFFE704", Offset = "0xFFE704", VA = "0xFFE704")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xFFE730", Offset = "0xFFE730", VA = "0xFFE730")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xFFE950", Offset = "0xFFE950", VA = "0xFFE950", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xFFF654", Offset = "0xFFF654", VA = "0xFFF654")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xFFF76C", Offset = "0xFFF76C", VA = "0xFFF76C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xFFF7BC", Offset = "0xFFF7BC", VA = "0xFFF7BC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xFFF98C", Offset = "0xFFF98C", VA = "0xFFF98C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xFFFA34", Offset = "0xFFFA34", VA = "0xFFFA34")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xFFFB24", Offset = "0xFFFB24", VA = "0xFFFB24")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xFFFC00", Offset = "0xFFFC00", VA = "0xFFFC00")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1000004", Offset = "0x1000004", VA = "0x1000004")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1000038", Offset = "0x1000038", VA = "0x1000038")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1000144", Offset = "0x1000144", VA = "0x1000144")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class Settings
		{
			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1003B90", Offset = "0x1003B90", VA = "0x1003B90")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D4")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000D5")]
			public class Target
			{
				[Token(Token = "0x400061F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000620")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000621")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60006B8")]
				[Address(RVA = "0x1003D2C", Offset = "0x1003D2C", VA = "0x1003D2C")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x1003DE0", Offset = "0x1003DE0", VA = "0x1003DE0")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1003D24", Offset = "0x1003D24", VA = "0x1003D24")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1000158", Offset = "0x1000158", VA = "0x1000158")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1000170", Offset = "0x1000170", VA = "0x1000170")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1000298", Offset = "0x1000298", VA = "0x1000298")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x10001B8", Offset = "0x10001B8", VA = "0x10001B8")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x10002B0", Offset = "0x10002B0", VA = "0x10002B0")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1001510", Offset = "0x1001510", VA = "0x1001510")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1001BC8", Offset = "0x1001BC8", VA = "0x1001BC8")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x10024D8", Offset = "0x10024D8", VA = "0x10024D8")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1002748", Offset = "0x1002748", VA = "0x1002748")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1002964", Offset = "0x1002964", VA = "0x1002964")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1003124", Offset = "0x1003124", VA = "0x1003124")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1002EEC", Offset = "0x1002EEC", VA = "0x1002EEC")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x10033CC", Offset = "0x10033CC", VA = "0x10033CC")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1003764", Offset = "0x1003764", VA = "0x1003764")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1003848", Offset = "0x1003848", VA = "0x1003848")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000D6")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1003E3C", Offset = "0x1003E3C", VA = "0x1003E3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1003E8C", Offset = "0x1003E8C", VA = "0x1003E8C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1003EB4", Offset = "0x1003EB4", VA = "0x1003EB4")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1003FD4", Offset = "0x1003FD4", VA = "0x1003FD4")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B9")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1003FEC", Offset = "0x1003FEC", VA = "0x1003FEC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1003FF8", Offset = "0x1003FF8", VA = "0x1003FF8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1004004", Offset = "0x1004004", VA = "0x1004004")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x10040F8", Offset = "0x10040F8", VA = "0x10040F8")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x10042B8", Offset = "0x10042B8", VA = "0x10042B8")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1004410", Offset = "0x1004410", VA = "0x1004410")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x10047D8", Offset = "0x10047D8", VA = "0x10047D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x10048E4", Offset = "0x10048E4", VA = "0x10048E4")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000D8")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public class Offset
		{
			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x10049A0", Offset = "0x10049A0", VA = "0x10049A0")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1004C08", Offset = "0x1004C08", VA = "0x1004C08")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x10048EC", Offset = "0x10048EC", VA = "0x10048EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x100493C", Offset = "0x100493C", VA = "0x100493C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1004B48", Offset = "0x1004B48", VA = "0x1004B48")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1004C00", Offset = "0x1004C00", VA = "0x1004C00")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1004C10", Offset = "0x1004C10", VA = "0x1004C10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1004C90", Offset = "0x1004C90", VA = "0x1004C90")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1004C98", Offset = "0x1004C98", VA = "0x1004C98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1004D04", Offset = "0x1004D04", VA = "0x1004D04")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1004D64", Offset = "0x1004D64", VA = "0x1004D64")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1004D9C", Offset = "0x1004D9C", VA = "0x1004D9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1005058", Offset = "0x1005058", VA = "0x1005058")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1005060", Offset = "0x1005060", VA = "0x1005060")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1005098", Offset = "0x1005098", VA = "0x1005098")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x10051E4", Offset = "0x10051E4", VA = "0x10051E4")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1005354", Offset = "0x1005354", VA = "0x1005354")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1005538", Offset = "0x1005538", VA = "0x1005538")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x10055C8", Offset = "0x10055C8", VA = "0x10055C8")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x10055DC", Offset = "0x10055DC", VA = "0x10055DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1005748", Offset = "0x1005748", VA = "0x1005748")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1005944", Offset = "0x1005944", VA = "0x1005944")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1005974", Offset = "0x1005974", VA = "0x1005974")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1005DA0", Offset = "0x1005DA0", VA = "0x1005DA0")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000BA")]
		public Vector3 velocity
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x1005DC0", Offset = "0x1005DC0", VA = "0x1005DC0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x1005DCC", Offset = "0x1005DCC", VA = "0x1005DCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1005DD8", Offset = "0x1005DD8", VA = "0x1005DD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1005E08", Offset = "0x1005E08", VA = "0x1005E08")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x100678C", Offset = "0x100678C", VA = "0x100678C")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1006508", Offset = "0x1006508", VA = "0x1006508")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x100689C", Offset = "0x100689C", VA = "0x100689C")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000BB")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x10068C8", Offset = "0x10068C8", VA = "0x10068C8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1006948", Offset = "0x1006948", VA = "0x1006948")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1006C8C", Offset = "0x1006C8C", VA = "0x1006C8C")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000BE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x1007C94", Offset = "0x1007C94", VA = "0x1007C94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x1007CDC", Offset = "0x1007CDC", VA = "0x1007CDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x1007938", Offset = "0x1007938", VA = "0x1007938")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x10079F0", Offset = "0x10079F0", VA = "0x10079F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x10079F4", Offset = "0x10079F4", VA = "0x10079F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x1007C9C", Offset = "0x1007C9C", VA = "0x1007C9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000BC")]
		public bool isStepping
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x1006CA0", Offset = "0x1006CA0", VA = "0x1006CA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		public Vector3 position
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x100686C", Offset = "0x100686C", VA = "0x100686C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x1006CB4", Offset = "0x1006CB4", VA = "0x1006CB4")]
			set
			{
			}
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1006D00", Offset = "0x1006D00", VA = "0x1006D00")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1006F48", Offset = "0x1006F48", VA = "0x1006F48")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1007120", Offset = "0x1007120", VA = "0x1007120")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1007338", Offset = "0x1007338", VA = "0x1007338")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1007598", Offset = "0x1007598", VA = "0x1007598")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1007700", Offset = "0x1007700", VA = "0x1007700")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1007294", Offset = "0x1007294", VA = "0x1007294")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1007960", Offset = "0x1007960", VA = "0x1007960")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1007CE4", Offset = "0x1007CE4", VA = "0x1007CE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1007DB0", Offset = "0x1007DB0", VA = "0x1007DB0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1008024", Offset = "0x1008024", VA = "0x1008024")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		public struct Warp
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public enum EffectorMode
		{
			[Token(Token = "0x400069E")]
			PositionOffset,
			[Token(Token = "0x400069F")]
			Position
		}

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x100802C", Offset = "0x100802C", VA = "0x100802C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x100804C", Offset = "0x100804C", VA = "0x100804C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1008264", Offset = "0x1008264", VA = "0x1008264", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x100851C", Offset = "0x100851C", VA = "0x100851C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x10085B0", Offset = "0x10085B0", VA = "0x10085B0")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x10085B8", Offset = "0x10085B8", VA = "0x10085B8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1008608", Offset = "0x1008608", VA = "0x1008608")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1008810", Offset = "0x1008810", VA = "0x1008810", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1008A38", Offset = "0x1008A38", VA = "0x1008A38")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1008A4C", Offset = "0x1008A4C", VA = "0x1008A4C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1008BE0", Offset = "0x1008BE0", VA = "0x1008BE0", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1008C50", Offset = "0x1008C50", VA = "0x1008C50")]
		private void Read()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1008D88", Offset = "0x1008D88", VA = "0x1008D88")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1008DE4", Offset = "0x1008DE4", VA = "0x1008DE4")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x100942C", Offset = "0x100942C", VA = "0x100942C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1009240", Offset = "0x1009240", VA = "0x1009240")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x10096D0", Offset = "0x10096D0", VA = "0x10096D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x10097DC", Offset = "0x10097DC", VA = "0x10097DC")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x10097F8", Offset = "0x10097F8", VA = "0x10097F8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1009854", Offset = "0x1009854", VA = "0x1009854", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1009BA8", Offset = "0x1009BA8", VA = "0x1009BA8")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1009C98", Offset = "0x1009C98", VA = "0x1009C98")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000C0")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1009EF8", Offset = "0x1009EF8", VA = "0x1009EF8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000C1")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1009F78", Offset = "0x1009F78", VA = "0x1009F78")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1009CA0", Offset = "0x1009CA0", VA = "0x1009CA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1009D08", Offset = "0x1009D08", VA = "0x1009D08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1009FF8", Offset = "0x1009FF8", VA = "0x1009FF8")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x100A000", Offset = "0x100A000", VA = "0x100A000", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x100A45C", Offset = "0x100A45C", VA = "0x100A45C")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x100A464", Offset = "0x100A464", VA = "0x100A464")]
		private void Start()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x100A508", Offset = "0x100A508", VA = "0x100A508")]
		private void Update()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x100A964", Offset = "0x100A964", VA = "0x100A964")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x100AA04", Offset = "0x100AA04", VA = "0x100AA04")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EF")]
		public class Limb
		{
			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x100AB98", Offset = "0x100AB98", VA = "0x100AB98")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x100ACBC", Offset = "0x100ACBC", VA = "0x100ACBC")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x100AA74", Offset = "0x100AA74", VA = "0x100AA74")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x100AC10", Offset = "0x100AC10", VA = "0x100AC10")]
		private void Start()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x100ACA8", Offset = "0x100ACA8", VA = "0x100ACA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x100ACAC", Offset = "0x100ACAC", VA = "0x100ACAC")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x100ACCC", Offset = "0x100ACCC", VA = "0x100ACCC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x100AD34", Offset = "0x100AD34", VA = "0x100AD34")]
		private void Update()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x100ADFC", Offset = "0x100ADFC", VA = "0x100ADFC")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x100AE04", Offset = "0x100AE04", VA = "0x100AE04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x100AE54", Offset = "0x100AE54", VA = "0x100AE54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x100AFEC", Offset = "0x100AFEC", VA = "0x100AFEC")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x100AFF4", Offset = "0x100AFF4", VA = "0x100AFF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x100B0C4", Offset = "0x100B0C4", VA = "0x100B0C4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x100B150", Offset = "0x100B150", VA = "0x100B150")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x100B624", Offset = "0x100B624", VA = "0x100B624")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x100B730", Offset = "0x100B730", VA = "0x100B730")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x100B738", Offset = "0x100B738", VA = "0x100B738")]
		private void Start()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x100B8D4", Offset = "0x100B8D4", VA = "0x100B8D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x100B8E0", Offset = "0x100B8E0", VA = "0x100B8E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x100BBA0", Offset = "0x100BBA0", VA = "0x100BBA0")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x100BE44", Offset = "0x100BE44", VA = "0x100BE44")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x100B9A4", Offset = "0x100B9A4", VA = "0x100B9A4")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x100CAFC", Offset = "0x100CAFC", VA = "0x100CAFC")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x100CB1C", Offset = "0x100CB1C", VA = "0x100CB1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x100CB98", Offset = "0x100CB98", VA = "0x100CB98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x100CC94", Offset = "0x100CC94", VA = "0x100CC94")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x100CD40", Offset = "0x100CD40", VA = "0x100CD40")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x100CD50", Offset = "0x100CD50", VA = "0x100CD50")]
		private void Update()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x100CE94", Offset = "0x100CE94", VA = "0x100CE94")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x100CFF8", Offset = "0x100CFF8", VA = "0x100CFF8")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x100D008", Offset = "0x100D008", VA = "0x100D008")]
		private void Start()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x100D1D4", Offset = "0x100D1D4", VA = "0x100D1D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x100D5E4", Offset = "0x100D5E4", VA = "0x100D5E4")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x100D5F4", Offset = "0x100D5F4", VA = "0x100D5F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x100D6DC", Offset = "0x100D6DC", VA = "0x100D6DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x100D7C8", Offset = "0x100D7C8", VA = "0x100D7C8")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x100D7D0", Offset = "0x100D7D0", VA = "0x100D7D0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x100DCD0", Offset = "0x100DCD0", VA = "0x100DCD0")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x100DCD8", Offset = "0x100DCD8", VA = "0x100DCD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x100DD28", Offset = "0x100DD28", VA = "0x100DD28")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x100DFD4", Offset = "0x100DFD4", VA = "0x100DFD4")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public class Partner
		{
			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000C2")]
			private Transform neck
			{
				[Token(Token = "0x600074C")]
				[Address(RVA = "0x100E7E0", Offset = "0x100E7E0", VA = "0x100E7E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x100E004", Offset = "0x100E004", VA = "0x100E004")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x100E080", Offset = "0x100E080", VA = "0x100E080")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x100E678", Offset = "0x100E678", VA = "0x100E678")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x100E82C", Offset = "0x100E82C", VA = "0x100E82C")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x100DFDC", Offset = "0x100DFDC", VA = "0x100DFDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x100E024", Offset = "0x100E024", VA = "0x100E024")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x100E668", Offset = "0x100E668", VA = "0x100E668")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		public enum Mode
		{
			[Token(Token = "0x400072B")]
			Position,
			[Token(Token = "0x400072C")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000FE")]
		public class Absorber
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x100E9A4", Offset = "0x100E9A4", VA = "0x100E9A4")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x100EB78", Offset = "0x100EB78", VA = "0x100EB78")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x100EB9C", Offset = "0x100EB9C", VA = "0x100EB9C")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x100ECAC", Offset = "0x100ECAC", VA = "0x100ECAC")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x100EE44", Offset = "0x100EE44", VA = "0x100EE44")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x100E840", Offset = "0x100E840", VA = "0x100E840", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x100E924", Offset = "0x100E924", VA = "0x100E924")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x100EA6C", Offset = "0x100EA6C", VA = "0x100EA6C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x100EC30", Offset = "0x100EC30", VA = "0x100EC30")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x100ED1C", Offset = "0x100ED1C", VA = "0x100ED1C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x100EE34", Offset = "0x100EE34", VA = "0x100EE34")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x100EEA4", Offset = "0x100EEA4", VA = "0x100EEA4")]
		private void Start()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x100EF14", Offset = "0x100EF14", VA = "0x100EF14")]
		private void Update()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x100EFE4", Offset = "0x100EFE4", VA = "0x100EFE4")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x100F12C", Offset = "0x100F12C", VA = "0x100F12C")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class EffectorLink
		{
			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x100F3AC", Offset = "0x100F3AC", VA = "0x100F3AC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x100F140", Offset = "0x100F140", VA = "0x100F140", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x100F22C", Offset = "0x100F22C", VA = "0x100F22C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x100F3A4", Offset = "0x100F3A4", VA = "0x100F3A4")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x100F3BC", Offset = "0x100F3BC", VA = "0x100F3BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x100F6BC", Offset = "0x100F6BC", VA = "0x100F6BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x100FEB8", Offset = "0x100FEB8", VA = "0x100FEB8")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000C3")]
		private bool holding
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x10102B0", Offset = "0x10102B0", VA = "0x10102B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C4")]
		private bool holdingLeft
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1010380", Offset = "0x1010380", VA = "0x1010380")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		private bool holdingRight
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x10102D8", Offset = "0x10102D8", VA = "0x10102D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x100FF24", Offset = "0x100FF24", VA = "0x100FF24")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000766")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1010428", Offset = "0x1010428", VA = "0x1010428")]
		private void Start()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x10105E8", Offset = "0x10105E8", VA = "0x10105E8")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1010758", Offset = "0x1010758", VA = "0x1010758")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1010828", Offset = "0x1010828", VA = "0x1010828")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1010954", Offset = "0x1010954", VA = "0x1010954")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1010AD4", Offset = "0x1010AD4", VA = "0x1010AD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1010CD0", Offset = "0x1010CD0", VA = "0x1010CD0")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1010CE4", Offset = "0x1010CE4", VA = "0x1010CE4", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1010EC4", Offset = "0x1010EC4", VA = "0x1010EC4")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1010ED8", Offset = "0x1010ED8", VA = "0x1010ED8", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1010FEC", Offset = "0x1010FEC", VA = "0x1010FEC")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility[] ragdollUtility;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1011000", Offset = "0x1011000", VA = "0x1011000")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1011098", Offset = "0x1011098", VA = "0x1011098")]
		private void Update()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1011208", Offset = "0x1011208", VA = "0x1011208")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1011210", Offset = "0x1011210", VA = "0x1011210")]
		private void Start()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1011260", Offset = "0x1011260", VA = "0x1011260")]
		private void Update()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x10112AC", Offset = "0x10112AC", VA = "0x10112AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1011344", Offset = "0x1011344", VA = "0x1011344")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000109")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000783")]
				[Address(RVA = "0x1011684", Offset = "0x1011684", VA = "0x1011684", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000785")]
				[Address(RVA = "0x10116CC", Offset = "0x10116CC", VA = "0x10116CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0x10114B8", Offset = "0x10114B8", VA = "0x10114B8")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000781")]
			[Address(RVA = "0x10114F0", Offset = "0x10114F0", VA = "0x10114F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x10114F4", Offset = "0x10114F4", VA = "0x10114F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x101168C", Offset = "0x101168C", VA = "0x101168C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1011354", Offset = "0x1011354", VA = "0x1011354")]
		private void Start()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1011404", Offset = "0x1011404", VA = "0x1011404")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1011440", Offset = "0x1011440", VA = "0x1011440")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x10114E0", Offset = "0x10114E0", VA = "0x10114E0")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600078C")]
				[Address(RVA = "0x1011940", Offset = "0x1011940", VA = "0x1011940", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600078E")]
				[Address(RVA = "0x1011988", Offset = "0x1011988", VA = "0x1011988", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x10117E4", Offset = "0x10117E4", VA = "0x10117E4")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x1011814", Offset = "0x1011814", VA = "0x1011814", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x1011818", Offset = "0x1011818", VA = "0x1011818", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x1011948", Offset = "0x1011948", VA = "0x1011948", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x10116D4", Offset = "0x10116D4", VA = "0x10116D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x101177C", Offset = "0x101177C", VA = "0x101177C")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x101180C", Offset = "0x101180C", VA = "0x101180C")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010D")]
		public class EffectorLink
		{
			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x10119F4", Offset = "0x10119F4", VA = "0x10119F4")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1012530", Offset = "0x1012530", VA = "0x1012530")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x1011DB8", Offset = "0x1011DB8", VA = "0x1011DB8")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x1012618", Offset = "0x1012618", VA = "0x1012618")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x10126FC", Offset = "0x10126FC", VA = "0x10126FC")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x1012788", Offset = "0x1012788", VA = "0x1012788")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1012810", Offset = "0x1012810", VA = "0x1012810")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1012370", Offset = "0x1012370", VA = "0x1012370")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1012898", Offset = "0x1012898", VA = "0x1012898")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1011990", Offset = "0x1011990", VA = "0x1011990")]
		private void Start()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1011D58", Offset = "0x1011D58", VA = "0x1011D58")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x10122C0", Offset = "0x10122C0", VA = "0x10122C0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1012528", Offset = "0x1012528", VA = "0x1012528")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The amount of motion to transfer.")]
		public float transferMotion;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x10128D4", Offset = "0x10128D4", VA = "0x10128D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1012904", Offset = "0x1012904", VA = "0x1012904")]
		private void Update()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x10129B4", Offset = "0x10129B4", VA = "0x10129B4")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x10129C8", Offset = "0x10129C8", VA = "0x10129C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1012BAC", Offset = "0x1012BAC", VA = "0x1012BAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1012E48", Offset = "0x1012E48", VA = "0x1012E48")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1012F10", Offset = "0x1012F10", VA = "0x1012F10")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x101301C", Offset = "0x101301C", VA = "0x101301C")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1013024", Offset = "0x1013024", VA = "0x1013024", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x101313C", Offset = "0x101313C", VA = "0x101313C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1013304", Offset = "0x1013304", VA = "0x1013304")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1013320", Offset = "0x1013320", VA = "0x1013320")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1013528", Offset = "0x1013528", VA = "0x1013528")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1013594", Offset = "0x1013594", VA = "0x1013594")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000CA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B3")]
				[Address(RVA = "0x1013CE0", Offset = "0x1013CE0", VA = "0x1013CE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B5")]
				[Address(RVA = "0x1013D28", Offset = "0x1013D28", VA = "0x1013D28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x1013974", Offset = "0x1013974", VA = "0x1013974")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x1013B64", Offset = "0x1013B64", VA = "0x1013B64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x1013B68", Offset = "0x1013B68", VA = "0x1013B68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x1013CE8", Offset = "0x1013CE8", VA = "0x1013CE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x101359C", Offset = "0x101359C", VA = "0x101359C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x10136C0", Offset = "0x10136C0", VA = "0x10136C0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1013658", Offset = "0x1013658", VA = "0x1013658")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x101399C", Offset = "0x101399C", VA = "0x101399C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1013A74", Offset = "0x1013A74", VA = "0x1013A74")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1013B48", Offset = "0x1013B48", VA = "0x1013B48")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1013D30", Offset = "0x1013D30", VA = "0x1013D30")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1013D98", Offset = "0x1013D98", VA = "0x1013D98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1013E44", Offset = "0x1013E44", VA = "0x1013E44")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000116")]
		public class Part
		{
			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x1013EB8", Offset = "0x1013EB8", VA = "0x1013EB8")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x1013FD8", Offset = "0x1013FD8", VA = "0x1013FD8")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1013E54", Offset = "0x1013E54", VA = "0x1013E54")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1013FD0", Offset = "0x1013FD0", VA = "0x1013FD0")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1013FE0", Offset = "0x1013FE0", VA = "0x1013FE0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1014124", Offset = "0x1014124", VA = "0x1014124")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1014288", Offset = "0x1014288", VA = "0x1014288")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Head")]
		[Tooltip("HMD.")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Left Hand Controller")]
		[Header("Hands")]
		public Transform leftHandAnchor;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Multiplies the scale of the root.")]
		[Header("Scale")]
		public float scaleMlp;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1014298", Offset = "0x1014298", VA = "0x1014298")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1014420", Offset = "0x1014420", VA = "0x1014420")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1014490", Offset = "0x1014490", VA = "0x1014490")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x10145E8", Offset = "0x10145E8", VA = "0x10145E8")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1014650", Offset = "0x1014650", VA = "0x1014650")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x10146A0", Offset = "0x10146A0", VA = "0x10146A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1014878", Offset = "0x1014878", VA = "0x1014878")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x10148D0", Offset = "0x10148D0", VA = "0x10148D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1014DF0", Offset = "0x1014DF0", VA = "0x1014DF0")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000CC")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x1014E6C", Offset = "0x1014E6C", VA = "0x1014E6C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1014E4C", Offset = "0x1014E4C", VA = "0x1014E4C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1014E74", Offset = "0x1014E74", VA = "0x1014E74")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1014ED4", Offset = "0x1014ED4", VA = "0x1014ED4", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1009B98", Offset = "0x1009B98", VA = "0x1009B98", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x10152C4", Offset = "0x10152C4", VA = "0x10152C4", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1015058", Offset = "0x1015058", VA = "0x1015058")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x10152D4", Offset = "0x10152D4", VA = "0x10152D4")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x10152EC", Offset = "0x10152EC", VA = "0x10152EC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1015348", Offset = "0x1015348", VA = "0x1015348", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x10153D8", Offset = "0x10153D8", VA = "0x10153D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x10154FC", Offset = "0x10154FC", VA = "0x10154FC")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40007D7")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40007D8")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000CD")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x10155A0", Offset = "0x10155A0", VA = "0x10155A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1015504", Offset = "0x1015504", VA = "0x1015504", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x1015584", Offset = "0x1015584", VA = "0x1015584", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1015694", Offset = "0x1015694", VA = "0x1015694", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1015A88", Offset = "0x1015A88", VA = "0x1015A88")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1015BB0", Offset = "0x1015BB0", VA = "0x1015BB0")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40007E6")]
		protected const float half = 0.5f;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60007DB")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1015BC4", Offset = "0x1015BC4", VA = "0x1015BC4")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1015DB0", Offset = "0x1015DB0", VA = "0x1015DB0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1015F60", Offset = "0x1015F60", VA = "0x1015F60", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1016100", Offset = "0x1016100", VA = "0x1016100")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1016160", Offset = "0x1016160", VA = "0x1016160")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x10162C4", Offset = "0x10162C4", VA = "0x10162C4")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x10164C8", Offset = "0x10164C8", VA = "0x10164C8")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x10164EC", Offset = "0x10164EC", VA = "0x10164EC")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1016510", Offset = "0x1016510", VA = "0x1016510")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x101665C", Offset = "0x101665C", VA = "0x101665C")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000121")]
		public enum MoveMode
		{
			[Token(Token = "0x4000824")]
			Directional,
			[Token(Token = "0x4000825")]
			Strafe
		}

		[Token(Token = "0x2000122")]
		public struct AnimState
		{
			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000123")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000CF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x10190BC", Offset = "0x10190BC", VA = "0x10190BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x1019104", Offset = "0x1019104", VA = "0x1019104", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1018E88", Offset = "0x1018E88", VA = "0x1018E88")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x1018FC4", Offset = "0x1018FC4", VA = "0x1018FC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x1018FC8", Offset = "0x1018FC8", VA = "0x1018FC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x10190C4", Offset = "0x10190C4", VA = "0x10190C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000CE")]
		public bool onGround
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x101667C", Offset = "0x101667C", VA = "0x101667C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x1016684", Offset = "0x1016684", VA = "0x1016684")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1016690", Offset = "0x1016690", VA = "0x1016690", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1016860", Offset = "0x1016860", VA = "0x1016860")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x10168E4", Offset = "0x10168E4", VA = "0x10168E4", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x10169F8", Offset = "0x10169F8", VA = "0x10169F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1017A20", Offset = "0x1017A20", VA = "0x1017A20", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1017EB0", Offset = "0x1017EB0", VA = "0x1017EB0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x10170AC", Offset = "0x10170AC", VA = "0x10170AC")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1017F88", Offset = "0x1017F88", VA = "0x1017F88")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1018610", Offset = "0x1018610", VA = "0x1018610")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1017AAC", Offset = "0x1017AAC", VA = "0x1017AAC")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1018700", Offset = "0x1018700", VA = "0x1018700", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1018B80", Offset = "0x1018B80", VA = "0x1018B80")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1018CA8", Offset = "0x1018CA8", VA = "0x1018CA8", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1018DFC", Offset = "0x1018DFC", VA = "0x1018DFC")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x10174C0", Offset = "0x10174C0", VA = "0x10174C0")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1018EB0", Offset = "0x1018EB0", VA = "0x1018EB0")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000125")]
		public enum RotationMode
		{
			[Token(Token = "0x4000841")]
			Smooth,
			[Token(Token = "0x4000842")]
			Linear
		}

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000D1")]
		public bool isGrounded
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x101910C", Offset = "0x101910C", VA = "0x101910C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1019114", Offset = "0x1019114", VA = "0x1019114")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1019120", Offset = "0x1019120", VA = "0x1019120")]
		private void Start()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x10191B4", Offset = "0x10191B4", VA = "0x10191B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x10197CC", Offset = "0x10197CC", VA = "0x10197CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x10191FC", Offset = "0x10191FC", VA = "0x10191FC")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1019564", Offset = "0x1019564", VA = "0x1019564")]
		private void Move()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x10197FC", Offset = "0x10197FC", VA = "0x10197FC")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1019894", Offset = "0x1019894", VA = "0x1019894")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1019914", Offset = "0x1019914", VA = "0x1019914")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x101993C", Offset = "0x101993C", VA = "0x101993C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1019A58", Offset = "0x1019A58", VA = "0x1019A58", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x101A0BC", Offset = "0x101A0BC", VA = "0x101A0BC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x101A2A8", Offset = "0x101A2A8", VA = "0x101A2A8")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000128")]
		public struct State
		{
			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1019978", Offset = "0x1019978", VA = "0x1019978", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x101A2D4", Offset = "0x101A2D4", VA = "0x101A2D4", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x101A2C4", Offset = "0x101A2C4", VA = "0x101A2C4")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x101A618", Offset = "0x101A618", VA = "0x101A618")]
		private void Update()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x101A650", Offset = "0x101A650", VA = "0x101A650")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x101A658", Offset = "0x101A658", VA = "0x101A658")]
		private void Update()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x101A680", Offset = "0x101A680", VA = "0x101A680")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x101A724", Offset = "0x101A724", VA = "0x101A724")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012B")]
	public class Navigator
	{
		[Token(Token = "0x200012C")]
		public enum State
		{
			[Token(Token = "0x4000864")]
			Idle,
			[Token(Token = "0x4000865")]
			Seeking,
			[Token(Token = "0x4000866")]
			OnPath
		}

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000D2")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x101A738", Offset = "0x101A738", VA = "0x101A738")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x101A744", Offset = "0x101A744", VA = "0x101A744")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public State state
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x101A750", Offset = "0x101A750", VA = "0x101A750")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x101A758", Offset = "0x101A758", VA = "0x101A758")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x10199A4", Offset = "0x10199A4", VA = "0x10199A4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1019C78", Offset = "0x1019C78", VA = "0x1019C78")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x101A838", Offset = "0x101A838", VA = "0x101A838")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x101A89C", Offset = "0x101A89C", VA = "0x101A89C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x101A760", Offset = "0x101A760", VA = "0x101A760")]
		private void Stop()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x101A7BC", Offset = "0x101A7BC", VA = "0x101A7BC")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x101A0E4", Offset = "0x101A0E4", VA = "0x101A0E4")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x101A9D0", Offset = "0x101A9D0", VA = "0x101A9D0")]
		public Navigator()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200012D")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x101AA34", Offset = "0x101AA34", VA = "0x101AA34")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x101ABD0", Offset = "0x101ABD0", VA = "0x101ABD0")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x101AD44", Offset = "0x101AD44", VA = "0x101AD44")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x101AEBC", Offset = "0x101AEBC", VA = "0x101AEBC")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x101AF24", Offset = "0x101AF24", VA = "0x101AF24")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x101AF8C", Offset = "0x101AF8C", VA = "0x101AF8C")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x101AFE4", Offset = "0x101AFE4", VA = "0x101AFE4")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x101B05C", Offset = "0x101B05C", VA = "0x101B05C")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x101B0B4", Offset = "0x101B0B4", VA = "0x101B0B4")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x101B10C", Offset = "0x101B10C", VA = "0x101B10C")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x101B164", Offset = "0x101B164", VA = "0x101B164")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x101B1BC", Offset = "0x101B1BC", VA = "0x101B1BC")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x101B21C", Offset = "0x101B21C", VA = "0x101B21C")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x101B278", Offset = "0x101B278", VA = "0x101B278")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x101B2D0", Offset = "0x101B2D0", VA = "0x101B2D0")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000131")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x101B3F0", Offset = "0x101B3F0", VA = "0x101B3F0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x101B598", Offset = "0x101B598", VA = "0x101B598")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x101B734", Offset = "0x101B734", VA = "0x101B734")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x101B8D0", Offset = "0x101B8D0", VA = "0x101B8D0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x101BA6C", Offset = "0x101BA6C", VA = "0x101BA6C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x101BC10", Offset = "0x101BC10", VA = "0x101BC10")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x101BE68", Offset = "0x101BE68", VA = "0x101BE68")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x101C348", Offset = "0x101C348", VA = "0x101C348")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x101C5AC", Offset = "0x101C5AC", VA = "0x101C5AC")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x101C81C", Offset = "0x101C81C", VA = "0x101C81C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x101C9E0", Offset = "0x101C9E0", VA = "0x101C9E0")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200013D")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x101CFD0", Offset = "0x101CFD0", VA = "0x101CFD0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x101D170", Offset = "0x101D170", VA = "0x101D170")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x101D308", Offset = "0x101D308", VA = "0x101D308")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x101D4A0", Offset = "0x101D4A0", VA = "0x101D4A0")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x101D620", Offset = "0x101D620", VA = "0x101D620")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x101DA28", Offset = "0x101DA28", VA = "0x101DA28")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x101DD08", Offset = "0x101DD08", VA = "0x101DD08")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x101E000", Offset = "0x101E000", VA = "0x101E000")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x101E1BC", Offset = "0x101E1BC", VA = "0x101E1BC")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000147")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x101E7C4", Offset = "0x101E7C4", VA = "0x101E7C4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x101E960", Offset = "0x101E960", VA = "0x101E960")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x101EAD4", Offset = "0x101EAD4", VA = "0x101EAD4")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x101ECB0", Offset = "0x101ECB0", VA = "0x101ECB0")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200014B")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x200014C")]
		public static class Utils
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x10236F4", Offset = "0x10236F4", VA = "0x10236F4")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x101EF90", Offset = "0x101EF90", VA = "0x101EF90")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x101F104", Offset = "0x101F104", VA = "0x101F104")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x101F2A0", Offset = "0x101F2A0", VA = "0x101F2A0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x101F414", Offset = "0x101F414", VA = "0x101F414")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x101F5B0", Offset = "0x101F5B0", VA = "0x101F5B0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x101F724", Offset = "0x101F724", VA = "0x101F724")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x101F8BC", Offset = "0x101F8BC", VA = "0x101F8BC")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x101FAA0", Offset = "0x101FAA0", VA = "0x101FAA0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x101FC3C", Offset = "0x101FC3C", VA = "0x101FC3C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x101FDD8", Offset = "0x101FDD8", VA = "0x101FDD8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x101FF74", Offset = "0x101FF74", VA = "0x101FF74")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x1020110", Offset = "0x1020110", VA = "0x1020110")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x1020284", Offset = "0x1020284", VA = "0x1020284")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x1020408", Offset = "0x1020408", VA = "0x1020408")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x10205A4", Offset = "0x10205A4", VA = "0x10205A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x1020738", Offset = "0x1020738", VA = "0x1020738")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x10208CC", Offset = "0x10208CC", VA = "0x10208CC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x1020A70", Offset = "0x1020A70", VA = "0x1020A70")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x1020C08", Offset = "0x1020C08", VA = "0x1020C08")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x1020DA0", Offset = "0x1020DA0", VA = "0x1020DA0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x1020F38", Offset = "0x1020F38", VA = "0x1020F38")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x10210D4", Offset = "0x10210D4", VA = "0x10210D4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x1021270", Offset = "0x1021270", VA = "0x1021270")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x10213F4", Offset = "0x10213F4", VA = "0x10213F4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x102157C", Offset = "0x102157C", VA = "0x102157C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x1021704", Offset = "0x1021704", VA = "0x1021704")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x10218A0", Offset = "0x10218A0", VA = "0x10218A0")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x1021A44", Offset = "0x1021A44", VA = "0x1021A44")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x1021C10", Offset = "0x1021C10", VA = "0x1021C10")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x1021DE4", Offset = "0x1021DE4", VA = "0x1021DE4")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x10221F0", Offset = "0x10221F0", VA = "0x10221F0")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1022380", Offset = "0x1022380", VA = "0x1022380")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x1022500", Offset = "0x1022500", VA = "0x1022500")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x1022680", Offset = "0x1022680", VA = "0x1022680")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x102280C", Offset = "0x102280C", VA = "0x102280C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x10229A8", Offset = "0x10229A8", VA = "0x10229A8")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1022B84", Offset = "0x1022B84", VA = "0x1022B84")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1022CF8", Offset = "0x1022CF8", VA = "0x1022CF8")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1022F18", Offset = "0x1022F18", VA = "0x1022F18")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x1023118", Offset = "0x1023118", VA = "0x1023118")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1023318", Offset = "0x1023318", VA = "0x1023318")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1023518", Offset = "0x1023518", VA = "0x1023518")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000176")]
	public static class DOTweenModuleUnityVersion
	{
		[StructLayout(3)]
		[Token(Token = "0x2000179")]
		[CompilerGenerated]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000950")]
			[Address(RVA = "0x1025968", Offset = "0x1025968", VA = "0x1025968", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0x1025BA0", Offset = "0x1025BA0", VA = "0x1025BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200017A")]
		[CompilerGenerated]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x1025BAC", Offset = "0x1025BAC", VA = "0x1025BAC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x1025E08", Offset = "0x1025E08", VA = "0x1025E08", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200017B")]
		[CompilerGenerated]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x1025E14", Offset = "0x1025E14", VA = "0x1025E14", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x1026038", Offset = "0x1026038", VA = "0x1026038", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200017C")]
		[CompilerGenerated]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x1026044", Offset = "0x1026044", VA = "0x1026044", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x1026284", Offset = "0x1026284", VA = "0x1026284", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200017D")]
		[CompilerGenerated]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x1026290", Offset = "0x1026290", VA = "0x1026290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x10264E8", Offset = "0x10264E8", VA = "0x10264E8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200017E")]
		[CompilerGenerated]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x10264F4", Offset = "0x10264F4", VA = "0x10264F4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x1026720", Offset = "0x1026720", VA = "0x1026720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x10246B4", Offset = "0x10246B4", VA = "0x10246B4")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x1024894", Offset = "0x1024894", VA = "0x1024894")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1024A80", Offset = "0x1024A80", VA = "0x1024A80")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x1024B68", Offset = "0x1024B68", VA = "0x1024B68")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x1024C50", Offset = "0x1024C50", VA = "0x1024C50")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x1024D38", Offset = "0x1024D38", VA = "0x1024D38")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x1024E30", Offset = "0x1024E30", VA = "0x1024E30")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x1024F38", Offset = "0x1024F38", VA = "0x1024F38")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x1025020", Offset = "0x1025020", VA = "0x1025020")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x1025214", Offset = "0x1025214", VA = "0x1025214")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x1025408", Offset = "0x1025408", VA = "0x1025408")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x10254D0", Offset = "0x10254D0", VA = "0x10254D0")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x1025598", Offset = "0x1025598", VA = "0x1025598")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x1025660", Offset = "0x1025660", VA = "0x1025660")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1025738", Offset = "0x1025738", VA = "0x1025738")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1025810", Offset = "0x1025810", VA = "0x1025810")]
		[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x200017F")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000180")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000D4")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600095C")]
				[Address(RVA = "0x102672C", Offset = "0x102672C", VA = "0x102672C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x1024B40", Offset = "0x1024B40", VA = "0x1024B40")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000181")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000D5")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600095E")]
				[Address(RVA = "0x102675C", Offset = "0x102675C", VA = "0x102675C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x1024C28", Offset = "0x1024C28", VA = "0x1024C28")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000182")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000D6")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000960")]
				[Address(RVA = "0x10267BC", Offset = "0x10267BC", VA = "0x10267BC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0x1024D10", Offset = "0x1024D10", VA = "0x1024D10")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000183")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x170000D7")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000962")]
				[Address(RVA = "0x10267D8", Offset = "0x10267D8", VA = "0x10267D8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x1024E00", Offset = "0x1024E00", VA = "0x1024E00")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000184")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x170000D8")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000964")]
				[Address(RVA = "0x1026818", Offset = "0x1026818", VA = "0x1026818", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0x1024F00", Offset = "0x1024F00", VA = "0x1024F00")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000185")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000D9")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000966")]
				[Address(RVA = "0x1026870", Offset = "0x1026870", VA = "0x1026870", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0x1024FF8", Offset = "0x1024FF8", VA = "0x1024FF8")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000186")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000187")]
		public static class Physics
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x1026A00", Offset = "0x1026A00", VA = "0x1026A00")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0x1026B00", Offset = "0x1026B00", VA = "0x1026B00")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0x1026B8C", Offset = "0x1026B8C", VA = "0x1026B8C")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x1026C18", Offset = "0x1026C18", VA = "0x1026C18")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x10268A4", Offset = "0x10268A4", VA = "0x10268A4")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x1026958", Offset = "0x1026958", VA = "0x1026958")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x2000188")]
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000189")]
		public enum AnimationType
		{
			[Token(Token = "0x4000917")]
			None,
			[Token(Token = "0x4000918")]
			Move,
			[Token(Token = "0x4000919")]
			LocalMove,
			[Token(Token = "0x400091A")]
			Rotate,
			[Token(Token = "0x400091B")]
			LocalRotate,
			[Token(Token = "0x400091C")]
			Scale,
			[Token(Token = "0x400091D")]
			Color,
			[Token(Token = "0x400091E")]
			Fade,
			[Token(Token = "0x400091F")]
			Text,
			[Token(Token = "0x4000920")]
			PunchPosition,
			[Token(Token = "0x4000921")]
			PunchRotation,
			[Token(Token = "0x4000922")]
			PunchScale,
			[Token(Token = "0x4000923")]
			ShakePosition,
			[Token(Token = "0x4000924")]
			ShakeRotation,
			[Token(Token = "0x4000925")]
			ShakeScale,
			[Token(Token = "0x4000926")]
			CameraAspect,
			[Token(Token = "0x4000927")]
			CameraBackgroundColor,
			[Token(Token = "0x4000928")]
			CameraFieldOfView,
			[Token(Token = "0x4000929")]
			CameraOrthoSize,
			[Token(Token = "0x400092A")]
			CameraPixelRect,
			[Token(Token = "0x400092B")]
			CameraRect,
			[Token(Token = "0x400092C")]
			UIWidthHeight
		}

		[Token(Token = "0x200018A")]
		public enum TargetType
		{
			[Token(Token = "0x400092E")]
			Unset,
			[Token(Token = "0x400092F")]
			Camera,
			[Token(Token = "0x4000930")]
			CanvasGroup,
			[Token(Token = "0x4000931")]
			Image,
			[Token(Token = "0x4000932")]
			Light,
			[Token(Token = "0x4000933")]
			RectTransform,
			[Token(Token = "0x4000934")]
			Renderer,
			[Token(Token = "0x4000935")]
			SpriteRenderer,
			[Token(Token = "0x4000936")]
			Rigidbody,
			[Token(Token = "0x4000937")]
			Rigidbody2D,
			[Token(Token = "0x4000938")]
			Text,
			[Token(Token = "0x4000939")]
			Transform,
			[Token(Token = "0x400093A")]
			tk2dBaseSprite,
			[Token(Token = "0x400093B")]
			tk2dTextMesh,
			[Token(Token = "0x400093C")]
			TextMeshPro,
			[Token(Token = "0x400093D")]
			TextMeshProUGUI
		}

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool autoGenerate;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isActive;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		public bool isValid;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool optionalBool1;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenAutoGenerationCalled;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x1026DEC", Offset = "0x1026DEC", VA = "0x1026DEC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x1026EB8", Offset = "0x1026EB8", VA = "0x1026EB8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x1026F84", Offset = "0x1026F84", VA = "0x1026F84")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x1026FF0", Offset = "0x1026FF0", VA = "0x1026FF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x102871C", Offset = "0x102871C", VA = "0x102871C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x102875C", Offset = "0x102875C", VA = "0x102875C")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1028760", Offset = "0x1028760", VA = "0x1028760")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1028790", Offset = "0x1028790", VA = "0x1028790")]
		public void RewindThenRecreateTween()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x10287C8", Offset = "0x10287C8", VA = "0x10287C8")]
		public void RewindThenRecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x1028800", Offset = "0x1028800", VA = "0x1028800")]
		public void RecreateTween()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x102880C", Offset = "0x102880C", VA = "0x102880C")]
		public void RecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x102703C", Offset = "0x102703C", VA = "0x102703C")]
		public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1028A60", Offset = "0x1028A60", VA = "0x1028A60")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x1028BB4", Offset = "0x1028BB4", VA = "0x1028BB4")]
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1028C84", Offset = "0x1028C84", VA = "0x1028C84", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1028D04", Offset = "0x1028D04", VA = "0x1028D04", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x1028D84", Offset = "0x1028D84", VA = "0x1028D84", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1028E04", Offset = "0x1028E04", VA = "0x1028E04", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x1028E84", Offset = "0x1028E84", VA = "0x1028E84", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x1028F04", Offset = "0x1028F04", VA = "0x1028F04", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1028FE8", Offset = "0x1028FE8", VA = "0x1028FE8", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x1028FF8", Offset = "0x1028FF8", VA = "0x1028FF8", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x1029358", Offset = "0x1029358", VA = "0x1029358", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x10293DC", Offset = "0x10293DC", VA = "0x10293DC", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x1029468", Offset = "0x1029468", VA = "0x1029468")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x10294F0", Offset = "0x10294F0", VA = "0x10294F0")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x1029548", Offset = "0x1029548", VA = "0x1029548")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x10295A0", Offset = "0x10295A0", VA = "0x10295A0")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x1029628", Offset = "0x1029628", VA = "0x1029628")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1029680", Offset = "0x1029680", VA = "0x1029680")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1029708", Offset = "0x1029708", VA = "0x1029708")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x1029760", Offset = "0x1029760", VA = "0x1029760")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x102989C", Offset = "0x102989C", VA = "0x102989C")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x1029930", Offset = "0x1029930", VA = "0x1029930")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x10299A0", Offset = "0x10299A0", VA = "0x10299A0")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x1029A38", Offset = "0x1029A38", VA = "0x1029A38")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x1029AAC", Offset = "0x1029AAC", VA = "0x1029AAC")]
		public void DOKillById(string id)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x1029B38", Offset = "0x1029B38", VA = "0x1029B38")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x1028830", Offset = "0x1028830", VA = "0x1028830")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x1029B94", Offset = "0x1029B94", VA = "0x1029B94")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x1028818", Offset = "0x1028818", VA = "0x1028818")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x1028A40", Offset = "0x1028A40", VA = "0x1028A40")]
		private GameObject GetTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x1029104", Offset = "0x1029104", VA = "0x1029104")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x1029BCC", Offset = "0x1029BCC", VA = "0x1029BCC")]
		public DOTweenAnimation()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x600099B")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200018C")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x102AD9C", Offset = "0x102AD9C", VA = "0x102AD9C")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x102ADEC", Offset = "0x102ADEC", VA = "0x102ADEC")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x102B1A0", Offset = "0x102B1A0", VA = "0x102B1A0")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200018F")]
	public enum TMPSkewSpanMode
	{
		[Token(Token = "0x4000941")]
		Default,
		[Token(Token = "0x4000942")]
		AsMaxSkewFactor
	}
	[Token(Token = "0x2000190")]
	public static class ShortcutExtensionsTMPText
	{
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x102B5AC", Offset = "0x102B5AC", VA = "0x102B5AC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this TMP_Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x102B748", Offset = "0x102B748", VA = "0x102B748")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x102B918", Offset = "0x102B918", VA = "0x102B918")]
		public static TweenerCore<Color, Color, ColorOptions> DOOutlineColor(this TMP_Text target, Color32 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x102BAE8", Offset = "0x102BAE8", VA = "0x102BAE8")]
		public static TweenerCore<Color, Color, ColorOptions> DOGlowColor(this TMP_Text target, Color endValue, float duration, bool useSharedMaterial = false)
		{
			return null;
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x102BBD8", Offset = "0x102BBD8", VA = "0x102BBD8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x102BD4C", Offset = "0x102BD4C", VA = "0x102BD4C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFaceFade(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x102BEC0", Offset = "0x102BEC0", VA = "0x102BEC0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x102C054", Offset = "0x102C054", VA = "0x102C054")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this TMP_Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x102C230", Offset = "0x102C230", VA = "0x102C230")]
		public static TweenerCore<float, float, FloatOptions> DOFontSize(this TMP_Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x102C3A4", Offset = "0x102C3A4", VA = "0x102C3A4")]
		public static TweenerCore<int, int, NoOptions> DOMaxVisibleCharacters(this TMP_Text target, int endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x102C520", Offset = "0x102C520", VA = "0x102C520")]
		public static TweenerCore<string, string, StringOptions> DOText(this TMP_Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
	[Token(Token = "0x200019B")]
	public class DOTweenTMPAnimator : IDisposable
	{
		[Token(Token = "0x200019C")]
		private struct CharVertices
		{
			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 bottomLeft;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 topLeft;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 topRight;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 bottomRight;

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x10316AC", Offset = "0x10316AC", VA = "0x10316AC")]
			public CharVertices(Vector3 bottomLeft, Vector3 topLeft, Vector3 topRight, Vector3 bottomRight)
			{
			}
		}

		[Token(Token = "0x200019D")]
		private struct CharTransform
		{
			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int charIndex;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 offset;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Quaternion rotation;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 scale;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 _topLeftShift;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 _topRightShift;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 _bottomLeftShift;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 _bottomRightShift;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 _charMidBaselineOffset;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private int _matIndex;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private int _firstVertexIndex;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private TMP_MeshInfo _meshInfo;

			[Token(Token = "0x170000DC")]
			public bool isVisible
			{
				[Token(Token = "0x60009F8")]
				[Address(RVA = "0x10316DC", Offset = "0x10316DC", VA = "0x10316DC")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x60009F9")]
				[Address(RVA = "0x10316E4", Offset = "0x10316E4", VA = "0x10316E4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x102DD2C", Offset = "0x102DD2C", VA = "0x102DD2C")]
			public CharTransform(int charIndex, TMP_TextInfo textInfo, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x102DBCC", Offset = "0x102DBCC", VA = "0x102DBCC")]
			public void Refresh(TMP_TextInfo textInfo, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x102DF1C", Offset = "0x102DF1C", VA = "0x102DF1C")]
			public void ResetAll(TMP_Text target, TMP_MeshInfo[] meshInfos, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x102DABC", Offset = "0x102DABC", VA = "0x102DABC")]
			public void ResetTransformationData()
			{
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x10316F0", Offset = "0x10316F0", VA = "0x10316F0")]
			public void ResetGeometry(TMP_Text target, TMP_MeshInfo[] cachedMeshInfos)
			{
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x1031874", Offset = "0x1031874", VA = "0x1031874")]
			public void ResetColors(TMP_Text target, TMP_MeshInfo[] meshInfos)
			{
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x102EED8", Offset = "0x102EED8", VA = "0x102EED8")]
			public Color32 GetColor(TMP_MeshInfo[] meshInfos)
			{
				return default(Color32);
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x102E418", Offset = "0x102E418", VA = "0x102E418")]
			public CharVertices GetVertices()
			{
				return default(CharVertices);
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x103226C", Offset = "0x103226C", VA = "0x103226C")]
			public void UpdateAlpha(TMP_Text target, Color alphaColor, TMP_MeshInfo[] meshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x102F2A8", Offset = "0x102F2A8", VA = "0x102F2A8")]
			public void UpdateColor(TMP_Text target, Color32 color, TMP_MeshInfo[] meshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x102F374", Offset = "0x102F374", VA = "0x102F374")]
			public void UpdateGeometry(TMP_Text target, Vector3 offset, Quaternion rotation, Vector3 scale, TMP_MeshInfo[] cachedMeshInfos, bool apply = true)
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x102FBE4", Offset = "0x102FBE4", VA = "0x102FBE4")]
			public void ShiftVertices(TMP_Text target, Vector3 topLeftShift, Vector3 topRightShift, Vector3 bottomLeftShift, Vector3 bottomRightShift)
			{
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x102FE9C", Offset = "0x102FE9C", VA = "0x102FE9C")]
			public void ResetVerticesShift(TMP_Text target)
			{
			}
		}

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<TMP_Text, DOTweenTMPAnimator> _targetToAnimator;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<CharTransform> _charTransforms;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_MeshInfo[] _cachedMeshInfos;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _ignoreTextChangedEvent;

		[Token(Token = "0x170000DA")]
		public TMP_Text target
		{
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x102D290", Offset = "0x102D290", VA = "0x102D290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x102D298", Offset = "0x102D298", VA = "0x102D298")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public TMP_TextInfo textInfo
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x102D2A0", Offset = "0x102D2A0", VA = "0x102D2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x102D2A8", Offset = "0x102D2A8", VA = "0x102D2A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x102D2B0", Offset = "0x102D2B0", VA = "0x102D2B0")]
		public DOTweenTMPAnimator(TMP_Text target)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x102D9B4", Offset = "0x102D9B4", VA = "0x102D9B4")]
		public static void DisposeInstanceFor(TMP_Text target)
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x102D600", Offset = "0x102D600", VA = "0x102D600", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x102D710", Offset = "0x102D710", VA = "0x102D710")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x102DE28", Offset = "0x102DE28", VA = "0x102DE28")]
		public void Reset()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x102DF50", Offset = "0x102DF50", VA = "0x102DF50")]
		private void OnTextChanged(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x102E008", Offset = "0x102E008", VA = "0x102E008")]
		private bool ValidateChar(int charIndex, bool isTween = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x102E198", Offset = "0x102E198", VA = "0x102E198")]
		private bool ValidateSpan(int fromCharIndex, int toCharIndex, out int firstVisibleCharIndex, out int lastVisibleCharIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x102E2D8", Offset = "0x102E2D8", VA = "0x102E2D8")]
		public void SkewSpanX(int fromCharIndex, int toCharIndex, float skewFactor, bool skewTop = true)
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x102E6B8", Offset = "0x102E6B8", VA = "0x102E6B8")]
		public void SkewSpanY(int fromCharIndex, int toCharIndex, float skewFactor, TMPSkewSpanMode mode = TMPSkewSpanMode.Default, bool skewRight = true)
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x102EDD4", Offset = "0x102EDD4", VA = "0x102EDD4")]
		public Color GetCharColor(int charIndex)
		{
			return default(Color);
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x102EF28", Offset = "0x102EF28", VA = "0x102EF28")]
		public Vector3 GetCharOffset(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x102EFE8", Offset = "0x102EFE8", VA = "0x102EFE8")]
		public Vector3 GetCharRotation(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x102F0CC", Offset = "0x102F0CC", VA = "0x102F0CC")]
		public Vector3 GetCharScale(int charIndex)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x102F18C", Offset = "0x102F18C", VA = "0x102F18C")]
		public void SetCharColor(int charIndex, Color32 color)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x102EC84", Offset = "0x102EC84", VA = "0x102EC84")]
		public void SetCharOffset(int charIndex, Vector3 offset)
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x102F788", Offset = "0x102F788", VA = "0x102F788")]
		public void SetCharRotation(int charIndex, Vector3 rotation)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x102F920", Offset = "0x102F920", VA = "0x102F920")]
		public void SetCharScale(int charIndex, Vector3 scale)
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x102FA60", Offset = "0x102FA60", VA = "0x102FA60")]
		public void ShiftCharVertices(int charIndex, Vector3 topLeftShift, Vector3 topRightShift, Vector3 bottomLeftShift, Vector3 bottomRightShift)
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x102E4D4", Offset = "0x102E4D4", VA = "0x102E4D4")]
		public float SkewCharX(int charIndex, float skewFactor, bool skewTop = true)
		{
			return default(float);
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x102EA64", Offset = "0x102EA64", VA = "0x102EA64")]
		public float SkewCharY(int charIndex, float skewFactor, bool skewRight = true, bool fixedSkew = false)
		{
			return default(float);
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x102FD98", Offset = "0x102FD98", VA = "0x102FD98")]
		public void ResetVerticesShift(int charIndex)
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x1030044", Offset = "0x1030044", VA = "0x1030044")]
		public TweenerCore<Color, Color, ColorOptions> DOFadeChar(int charIndex, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x10301C0", Offset = "0x10301C0", VA = "0x10301C0")]
		public TweenerCore<Color, Color, ColorOptions> DOColorChar(int charIndex, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x103036C", Offset = "0x103036C", VA = "0x103036C")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOOffsetChar(int charIndex, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x1030504", Offset = "0x1030504", VA = "0x1030504")]
		public TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateChar(int charIndex, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x1030698", Offset = "0x1030698", VA = "0x1030698")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOScaleChar(int charIndex, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x10306A8", Offset = "0x10306A8", VA = "0x10306A8")]
		public TweenerCore<Vector3, Vector3, VectorOptions> DOScaleChar(int charIndex, Vector3 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x1030840", Offset = "0x1030840", VA = "0x1030840")]
		public Tweener DOPunchCharOffset(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x1030A7C", Offset = "0x1030A7C", VA = "0x1030A7C")]
		public Tweener DOPunchCharRotation(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x1030CB8", Offset = "0x1030CB8", VA = "0x1030CB8")]
		public Tweener DOPunchCharScale(int charIndex, float punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x1030CCC", Offset = "0x1030CCC", VA = "0x1030CCC")]
		public Tweener DOPunchCharScale(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x1030F08", Offset = "0x1030F08", VA = "0x1030F08")]
		public Tweener DOShakeCharOffset(int charIndex, float duration, float strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x1030F1C", Offset = "0x1030F1C", VA = "0x1030F1C")]
		public Tweener DOShakeCharOffset(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x103116C", Offset = "0x103116C", VA = "0x103116C")]
		public Tweener DOShakeCharRotation(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x10313BC", Offset = "0x10313BC", VA = "0x10313BC")]
		public Tweener DOShakeCharScale(int charIndex, float duration, float strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x10313D0", Offset = "0x10313D0", VA = "0x10313D0")]
		public Tweener DOShakeCharScale(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}
	}
}
