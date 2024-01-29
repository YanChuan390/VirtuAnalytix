using System;
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
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace GOE
{
	[Token(Token = "0x2000002")]
	public class Common
	{
		[Token(Token = "0x2000003")]
		public delegate string GetAliasText(string text);

		[Token(Token = "0x4000001")]
		public const string TIME_FORMAT_DEFAULT = "{0,2:D2}:{1,2:D2}";

		[Token(Token = "0x4000002")]
		public const string PERC_FORMAT_DEFAULT = "{0,3:F1}%";

		[Token(Token = "0x4000003")]
		public const string TRUE = "true";

		[Token(Token = "0x4000004")]
		public const string FALSE = "false";

		[Token(Token = "0x4000005")]
		public const string ASSIGN = "=";

		[Token(Token = "0x4000006")]
		public const string TERMINATOR = ";";

		[Token(Token = "0x4000007")]
		public const string ENDLINE = ";\n";

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Color[] COLORS_DEBUG;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Color[] COLOR_ALTERNATE;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xA237EC", Offset = "0xA237EC", VA = "0xA237EC")]
		public static string GetVersionInformation()
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xA23898", Offset = "0xA23898", VA = "0xA23898")]
		public static string GetVersionInformation(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xA23860", Offset = "0xA23860", VA = "0xA23860")]
		public static string GetVersionInformation(Assembly assembly)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xA23910", Offset = "0xA23910", VA = "0xA23910")]
		public static bool IsStringFalse(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xA239AC", Offset = "0xA239AC", VA = "0xA239AC")]
		public static bool IsStringTrue(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xA23A0C", Offset = "0xA23A0C", VA = "0xA23A0C")]
		public static bool IsAlphaNumeric(string label)
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xA23AC0", Offset = "0xA23AC0", VA = "0xA23AC0")]
		public static string ForceAlphaNumeric(string label, string defaultLabel)
		{
			return null;
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xA23B78", Offset = "0xA23B78", VA = "0xA23B78")]
		public static string Format(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xA23BEC", Offset = "0xA23BEC", VA = "0xA23BEC")]
		public static string Format(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xA23C70", Offset = "0xA23C70", VA = "0xA23C70")]
		public static string Format(string key, float value)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xA23CF4", Offset = "0xA23CF4", VA = "0xA23CF4")]
		public static string Format(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xA23DA0", Offset = "0xA23DA0", VA = "0xA23DA0")]
		public static string Format(string key, Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xA23F1C", Offset = "0xA23F1C", VA = "0xA23F1C")]
		public static string Format(string key, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xA240D4", Offset = "0xA240D4", VA = "0xA240D4")]
		public static string Format(string key, Vector4 value)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xA243B4", Offset = "0xA243B4", VA = "0xA243B4")]
		public static string Format(string key, Color value)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xA24694", Offset = "0xA24694", VA = "0xA24694")]
		public static Component GetComponentInChildren(Type t, Component component)
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xA2470C", Offset = "0xA2470C", VA = "0xA2470C")]
		public static Component GetComponentInChildren(Type t, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xA24774", Offset = "0xA24774", VA = "0xA24774")]
		public static Component GetComponentInChildren(Type t, Transform parent, bool includeInactive)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xA247C0", Offset = "0xA247C0", VA = "0xA247C0")]
		public static Component[] GetComponentsInChildren(Type t, Component component)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xA2488C", Offset = "0xA2488C", VA = "0xA2488C")]
		public static Component[] GetComponentsInChildren(Type t, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xA24900", Offset = "0xA24900", VA = "0xA24900")]
		public static Component[] GetComponentsInChildren(Type t, Transform parent, bool includeInactive)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		public static T GetComponent<T>(GameObject obj, bool createIfNotExist) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xA24924", Offset = "0xA24924", VA = "0xA24924")]
		public static bool CheckMask(int flag, int mask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xA24930", Offset = "0xA24930", VA = "0xA24930")]
		public static bool CheckMaskAny(int flag, int mask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xA2493C", Offset = "0xA2493C", VA = "0xA2493C")]
		public static string GetSystemTimeString()
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xA249BC", Offset = "0xA249BC", VA = "0xA249BC")]
		public static string GetTimeString(float time, string timeFormat)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xA24A90", Offset = "0xA24A90", VA = "0xA24A90")]
		public static Bounds GetBounds(Transform target)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xA24B10", Offset = "0xA24B10", VA = "0xA24B10")]
		public static Bounds GetBounds(Transform target, bool onlyStatic)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xA24B9C", Offset = "0xA24B9C", VA = "0xA24B9C")]
		public static Bounds GetBounds(Transform target, bool onlyStatic, bool onlyMeshRenderers)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xA24C34", Offset = "0xA24C34", VA = "0xA24C34")]
		public static Bounds GetBounds(Transform target, bool onlyStatic, bool onlyMeshRenderers, bool includeTerrains)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xA24CD8", Offset = "0xA24CD8", VA = "0xA24CD8")]
		public static Bounds GetBounds(Transform target, bool onlyStatic, bool onlyMeshRenderers, bool includeTerrains, bool includeColliders)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xA24D80", Offset = "0xA24D80", VA = "0xA24D80")]
		public static Bounds GetBounds(Transform target, bool onlyStatic, bool onlyMeshRenderers, bool includeTerrains, bool includeColliders, bool includeInactive)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xA252B4", Offset = "0xA252B4", VA = "0xA252B4")]
		public static void ResetOrigin(Transform target, Vector3 origin, bool isLocal)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xA2589C", Offset = "0xA2589C", VA = "0xA2589C")]
		public static Vector3 InterpolateSpline(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA25A90", Offset = "0xA25A90", VA = "0xA25A90")]
		public static string ReplaceAliases(string text, string aliasPrefix, string aliasSuffix, GetAliasText getAliasText)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xA25B60", Offset = "0xA25B60", VA = "0xA25B60")]
		public static Vector2 Vector2FromString(string str)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xA23E48", Offset = "0xA23E48", VA = "0xA23E48")]
		public static string ToString(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xA25D1C", Offset = "0xA25D1C", VA = "0xA25D1C")]
		public static bool IsVector3(string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xA25D44", Offset = "0xA25D44", VA = "0xA25D44")]
		public static Vector3 Vector3FromString(string str)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xA23FD4", Offset = "0xA23FD4", VA = "0xA23FD4")]
		public static string ToString(Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xA25F44", Offset = "0xA25F44", VA = "0xA25F44")]
		public static Vector4 Vector4FromString(string str)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xA24194", Offset = "0xA24194", VA = "0xA24194")]
		public static string ToString(Vector4 v)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xA2618C", Offset = "0xA2618C", VA = "0xA2618C")]
		public static Color ColorFromString(string str)
		{
			return default(Color);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xA26338", Offset = "0xA26338", VA = "0xA26338")]
		private static float parseColorComponent(string colString)
		{
			return default(float);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xA24474", Offset = "0xA24474", VA = "0xA24474")]
		public static string ToString(Color c)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xA263B8", Offset = "0xA263B8", VA = "0xA263B8")]
		public static string FormatTime(float time)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xA264A0", Offset = "0xA264A0", VA = "0xA264A0")]
		public static GameObject CreateGameObject(string name, bool allowDuplicates)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xA26558", Offset = "0xA26558", VA = "0xA26558")]
		public static string GetUniqueId(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xA267F8", Offset = "0xA267F8", VA = "0xA267F8")]
		public static string GetDataPathBase()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xA26820", Offset = "0xA26820", VA = "0xA26820")]
		public static string GetDataPath(string dataPathRelative)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xA268AC", Offset = "0xA268AC", VA = "0xA268AC")]
		public static string GetDataPath(string dataPathRelative, string filenameNoPath)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xA26948", Offset = "0xA26948", VA = "0xA26948")]
		public static bool CreatePath(string pathAbsolute)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xA269DC", Offset = "0xA269DC", VA = "0xA269DC")]
		public static string CleanResourcePath(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xA26A48", Offset = "0xA26A48", VA = "0xA26A48")]
		public static string CleanResourceFilename(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xA26AD4", Offset = "0xA26AD4", VA = "0xA26AD4")]
		public static string CleanResourceFileNameWithoutExtension(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xA26B84", Offset = "0xA26B84", VA = "0xA26B84")]
		public static string CleanResourceFullPathWithoutExtension(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xA26B2C", Offset = "0xA26B2C", VA = "0xA26B2C")]
		public static string FileNameWithoutExtension(string filename)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xA26BDC", Offset = "0xA26BDC", VA = "0xA26BDC")]
		public static string FullPathWithoutExtension(string filename)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xA26C6C", Offset = "0xA26C6C", VA = "0xA26C6C")]
		public static string BuildFilename(string filenamePrefix, string extension, bool includeTime)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xA26D4C", Offset = "0xA26D4C", VA = "0xA26D4C")]
		public static string BuildFilenamePath(string relativePath, string filenamePrefix, string extension, bool includeTime)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xA26DD0", Offset = "0xA26DD0", VA = "0xA26DD0")]
		public static string BuildFilenameStripPath(string filename, string extension)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xA26E68", Offset = "0xA26E68", VA = "0xA26E68")]
		public static object LoadResource(string resourceName, Type type)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xA26ED4", Offset = "0xA26ED4", VA = "0xA26ED4")]
		public static object[] LoadResourceAll(string resourceName, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xA26F40", Offset = "0xA26F40", VA = "0xA26F40")]
		public static string LoadTextResource(string resourceName)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xA27010", Offset = "0xA27010", VA = "0xA27010")]
		public static string LoadFile(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xA270A4", Offset = "0xA270A4", VA = "0xA270A4")]
		public static bool SaveFile(string filename, string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xA27138", Offset = "0xA27138", VA = "0xA27138")]
		public static bool FileExists(string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xA27140", Offset = "0xA27140", VA = "0xA27140")]
		public static bool MoveFile(string filename, string newFilename)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xA271FC", Offset = "0xA271FC", VA = "0xA271FC")]
		public static bool SaveImageToFile(Texture2D texture, string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA27290", Offset = "0xA27290", VA = "0xA27290")]
		public static Texture2D LoadImageFromFile(Texture2D texture, string filename, int maxBufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xA275A4", Offset = "0xA275A4", VA = "0xA275A4")]
		public static Texture2D LoadImageOrResource(Texture2D texture, string relativeFilename, int maxBufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xA2769C", Offset = "0xA2769C", VA = "0xA2769C")]
		public static Texture2D LoadImageOrResource(Texture2D texture, string dataPath, string relativeFilename, int maxBufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xA277E4", Offset = "0xA277E4", VA = "0xA277E4")]
		public static string LoadFileOrResource(string relativeFilename)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xA2785C", Offset = "0xA2785C", VA = "0xA2785C")]
		public static string LoadFileOrResource(string dataPath, string relativeFilename)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA27920", Offset = "0xA27920", VA = "0xA27920")]
		public static Transform FindChild(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xA27C44", Offset = "0xA27C44", VA = "0xA27C44")]
		public static Transform FindChildRecursive(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xA28270", Offset = "0xA28270", VA = "0xA28270")]
		public static Transform FindChildWithTag(Transform parent, string tag)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xA2857C", Offset = "0xA2857C", VA = "0xA2857C")]
		public static void DisableAllCameras()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xA285D0", Offset = "0xA285D0", VA = "0xA285D0")]
		public static bool SetActiveCamera(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xA28628", Offset = "0xA28628", VA = "0xA28628")]
		public static bool SetActiveCamera(Camera camera, AudioListener audioListener)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xA28690", Offset = "0xA28690", VA = "0xA28690")]
		public static bool SetActiveCamera(Camera camera, AudioListener audioListener, bool attachAudioListener)
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA28910", Offset = "0xA28910", VA = "0xA28910")]
		public static float CalculateMultiplier(float x, Vector3 coefficients)
		{
			return default(float);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xA28928", Offset = "0xA28928", VA = "0xA28928")]
		public static float CalculateMultiplier0(float x, Vector3 coefficients)
		{
			return default(float);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xA28930", Offset = "0xA28930", VA = "0xA28930")]
		public static float CalculateMultiplier1(float x, Vector3 coefficients)
		{
			return default(float);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xA2893C", Offset = "0xA2893C", VA = "0xA2893C")]
		public static Vector3 ExtractCoefficients(string coefficients)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xA28990", Offset = "0xA28990", VA = "0xA28990")]
		public static float ApplyMultiplier(float val, float x, string coefficients)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xA28A18", Offset = "0xA28A18", VA = "0xA28A18")]
		public static float ApplyMultiplier(float val, float x, Vector3 coefficients)
		{
			return default(float);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xA28AA8", Offset = "0xA28AA8", VA = "0xA28AA8")]
		public Common()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000004")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0xA28CC8", Offset = "0xA28CC8", VA = "0xA28CC8")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xA28E7C", Offset = "0xA28E7C", VA = "0xA28E7C")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xA29008", Offset = "0xA29008", VA = "0xA29008")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xA291A8", Offset = "0xA291A8", VA = "0xA291A8")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xA29210", Offset = "0xA29210", VA = "0xA29210")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xA29278", Offset = "0xA29278", VA = "0xA29278")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xA292D0", Offset = "0xA292D0", VA = "0xA292D0")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xA29348", Offset = "0xA29348", VA = "0xA29348")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xA293A0", Offset = "0xA293A0", VA = "0xA293A0")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xA293F8", Offset = "0xA293F8", VA = "0xA293F8")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xA29450", Offset = "0xA29450", VA = "0xA29450")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xA294A8", Offset = "0xA294A8", VA = "0xA294A8")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xA29508", Offset = "0xA29508", VA = "0xA29508")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xA29564", Offset = "0xA29564", VA = "0xA29564")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xA295BC", Offset = "0xA295BC", VA = "0xA295BC")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000008")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0xA296DC", Offset = "0xA296DC", VA = "0xA296DC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xA29894", Offset = "0xA29894", VA = "0xA29894")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xA29A40", Offset = "0xA29A40", VA = "0xA29A40")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xA29BEC", Offset = "0xA29BEC", VA = "0xA29BEC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xA29D98", Offset = "0xA29D98", VA = "0xA29D98")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xA29F4C", Offset = "0xA29F4C", VA = "0xA29F4C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xA2A1B4", Offset = "0xA2A1B4", VA = "0xA2A1B4")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xA2A6C0", Offset = "0xA2A6C0", VA = "0xA2A6C0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xA2A934", Offset = "0xA2A934", VA = "0xA2A934")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xA2ABC8", Offset = "0xA2ABC8", VA = "0xA2ABC8")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xA2AD9C", Offset = "0xA2AD9C", VA = "0xA2AD9C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000014")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0xA2B3B0", Offset = "0xA2B3B0", VA = "0xA2B3B0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xA2B560", Offset = "0xA2B560", VA = "0xA2B560")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xA2B708", Offset = "0xA2B708", VA = "0xA2B708")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xA2B8B0", Offset = "0xA2B8B0", VA = "0xA2B8B0")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xA2BA40", Offset = "0xA2BA40", VA = "0xA2BA40")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xA2BE74", Offset = "0xA2BE74", VA = "0xA2BE74")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xA2C168", Offset = "0xA2C168", VA = "0xA2C168")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xA2C480", Offset = "0xA2C480", VA = "0xA2C480")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xA2C654", Offset = "0xA2C654", VA = "0xA2C654")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200001E")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xA2CC80", Offset = "0xA2CC80", VA = "0xA2CC80")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xA2CE34", Offset = "0xA2CE34", VA = "0xA2CE34")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xA2CFC0", Offset = "0xA2CFC0", VA = "0xA2CFC0")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xA2D19C", Offset = "0xA2D19C", VA = "0xA2D19C")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000022")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000023")]
		public static class Utils
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0xA31F50", Offset = "0xA31F50", VA = "0xA31F50")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xA2D494", Offset = "0xA2D494", VA = "0xA2D494")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xA2D620", Offset = "0xA2D620", VA = "0xA2D620")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xA2D7D4", Offset = "0xA2D7D4", VA = "0xA2D7D4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xA2D960", Offset = "0xA2D960", VA = "0xA2D960")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xA2DB14", Offset = "0xA2DB14", VA = "0xA2DB14")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xA2DCA0", Offset = "0xA2DCA0", VA = "0xA2DCA0")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xA2DE50", Offset = "0xA2DE50", VA = "0xA2DE50")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xA2E034", Offset = "0xA2E034", VA = "0xA2E034")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xA2E1E0", Offset = "0xA2E1E0", VA = "0xA2E1E0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xA2E38C", Offset = "0xA2E38C", VA = "0xA2E38C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xA2E538", Offset = "0xA2E538", VA = "0xA2E538")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA2E6EC", Offset = "0xA2E6EC", VA = "0xA2E6EC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA2E878", Offset = "0xA2E878", VA = "0xA2E878")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xA2EA14", Offset = "0xA2EA14", VA = "0xA2EA14")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xA2EBC0", Offset = "0xA2EBC0", VA = "0xA2EBC0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA2ED64", Offset = "0xA2ED64", VA = "0xA2ED64")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA2EF08", Offset = "0xA2EF08", VA = "0xA2EF08")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA2F0BC", Offset = "0xA2F0BC", VA = "0xA2F0BC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xA2F264", Offset = "0xA2F264", VA = "0xA2F264")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xA2F40C", Offset = "0xA2F40C", VA = "0xA2F40C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA2F5B4", Offset = "0xA2F5B4", VA = "0xA2F5B4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xA2F760", Offset = "0xA2F760", VA = "0xA2F760")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xA2F90C", Offset = "0xA2F90C", VA = "0xA2F90C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xA2FAA8", Offset = "0xA2FAA8", VA = "0xA2FAA8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xA2FC48", Offset = "0xA2FC48", VA = "0xA2FC48")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xA2FDE8", Offset = "0xA2FDE8", VA = "0xA2FDE8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xA2FF94", Offset = "0xA2FF94", VA = "0xA2FF94")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xA30150", Offset = "0xA30150", VA = "0xA30150")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xA30334", Offset = "0xA30334", VA = "0xA30334")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xA30520", Offset = "0xA30520", VA = "0xA30520")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xA30948", Offset = "0xA30948", VA = "0xA30948")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xA30AE8", Offset = "0xA30AE8", VA = "0xA30AE8")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xA30C78", Offset = "0xA30C78", VA = "0xA30C78")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xA30E08", Offset = "0xA30E08", VA = "0xA30E08")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xA30FA4", Offset = "0xA30FA4", VA = "0xA30FA4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xA31158", Offset = "0xA31158", VA = "0xA31158")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA31350", Offset = "0xA31350", VA = "0xA31350")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xA314DC", Offset = "0xA314DC", VA = "0xA314DC")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xA31714", Offset = "0xA31714", VA = "0xA31714")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xA3192C", Offset = "0xA3192C", VA = "0xA3192C")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xA31B44", Offset = "0xA31B44", VA = "0xA31B44")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA31D5C", Offset = "0xA31D5C", VA = "0xA31D5C")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	public static class DOTweenModuleUnityVersion
	{
		[StructLayout(3)]
		[Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600018E")]
			[Address(RVA = "0xA34344", Offset = "0xA34344", VA = "0xA34344", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600018F")]
			[Address(RVA = "0xA3457C", Offset = "0xA3457C", VA = "0xA3457C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000190")]
			[Address(RVA = "0xA34588", Offset = "0xA34588", VA = "0xA34588", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0xA347E4", Offset = "0xA347E4", VA = "0xA347E4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000192")]
			[Address(RVA = "0xA347F0", Offset = "0xA347F0", VA = "0xA347F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0xA34A14", Offset = "0xA34A14", VA = "0xA34A14", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000194")]
			[Address(RVA = "0xA34A20", Offset = "0xA34A20", VA = "0xA34A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0xA34C60", Offset = "0xA34C60", VA = "0xA34C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000196")]
			[Address(RVA = "0xA34C6C", Offset = "0xA34C6C", VA = "0xA34C6C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0xA34EC4", Offset = "0xA34EC4", VA = "0xA34EC4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000055")]
		[CompilerGenerated]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000198")]
			[Address(RVA = "0xA34ED0", Offset = "0xA34ED0", VA = "0xA34ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000199")]
			[Address(RVA = "0xA350FC", Offset = "0xA350FC", VA = "0xA350FC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xA32F10", Offset = "0xA32F10", VA = "0xA32F10")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA330F0", Offset = "0xA330F0", VA = "0xA330F0")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA332DC", Offset = "0xA332DC", VA = "0xA332DC")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA333D8", Offset = "0xA333D8", VA = "0xA333D8")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA334D4", Offset = "0xA334D4", VA = "0xA334D4")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xA335D0", Offset = "0xA335D0", VA = "0xA335D0")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xA336E0", Offset = "0xA336E0", VA = "0xA336E0")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xA33800", Offset = "0xA33800", VA = "0xA33800")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xA338FC", Offset = "0xA338FC", VA = "0xA338FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xA33B08", Offset = "0xA33B08", VA = "0xA33B08")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xA33D14", Offset = "0xA33D14", VA = "0xA33D14")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xA33E00", Offset = "0xA33E00", VA = "0xA33E00")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA33EEC", Offset = "0xA33EEC", VA = "0xA33EEC")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA33FD8", Offset = "0xA33FD8", VA = "0xA33FD8")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xA340CC", Offset = "0xA340CC", VA = "0xA340CC")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xA341C8", Offset = "0xA341C8", VA = "0xA341C8")]
		[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000056")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000057")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000001")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600019A")]
				[Address(RVA = "0xA35108", Offset = "0xA35108", VA = "0xA35108", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0xA333A8", Offset = "0xA333A8", VA = "0xA333A8")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000058")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000002")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600019C")]
				[Address(RVA = "0xA35138", Offset = "0xA35138", VA = "0xA35138", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0xA334A4", Offset = "0xA334A4", VA = "0xA334A4")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000059")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000003")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600019E")]
				[Address(RVA = "0xA35198", Offset = "0xA35198", VA = "0xA35198", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600019F")]
			[Address(RVA = "0xA335A0", Offset = "0xA335A0", VA = "0xA335A0")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200005A")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000004")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60001A0")]
				[Address(RVA = "0xA351B4", Offset = "0xA351B4", VA = "0xA351B4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0xA336A4", Offset = "0xA336A4", VA = "0xA336A4")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200005B")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000005")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60001A2")]
				[Address(RVA = "0xA351F4", Offset = "0xA351F4", VA = "0xA351F4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xA337BC", Offset = "0xA337BC", VA = "0xA337BC")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200005C")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000006")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60001A4")]
				[Address(RVA = "0xA3524C", Offset = "0xA3524C", VA = "0xA3524C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xA338CC", Offset = "0xA338CC", VA = "0xA338CC")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200005D")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x200005E")]
		public static class Physics
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0xA353DC", Offset = "0xA353DC", VA = "0xA353DC")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xA354DC", Offset = "0xA354DC", VA = "0xA354DC")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xA35568", Offset = "0xA35568", VA = "0xA35568")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xA355F4", Offset = "0xA355F4", VA = "0xA355F4")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xA35280", Offset = "0xA35280", VA = "0xA35280")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xA35334", Offset = "0xA35334", VA = "0xA35334")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AddComponentMenu("DOTween/DOTween Animation")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000060")]
		public enum AnimationType
		{
			[Token(Token = "0x40000BA")]
			None,
			[Token(Token = "0x40000BB")]
			Move,
			[Token(Token = "0x40000BC")]
			LocalMove,
			[Token(Token = "0x40000BD")]
			Rotate,
			[Token(Token = "0x40000BE")]
			LocalRotate,
			[Token(Token = "0x40000BF")]
			Scale,
			[Token(Token = "0x40000C0")]
			Color,
			[Token(Token = "0x40000C1")]
			Fade,
			[Token(Token = "0x40000C2")]
			Text,
			[Token(Token = "0x40000C3")]
			PunchPosition,
			[Token(Token = "0x40000C4")]
			PunchRotation,
			[Token(Token = "0x40000C5")]
			PunchScale,
			[Token(Token = "0x40000C6")]
			ShakePosition,
			[Token(Token = "0x40000C7")]
			ShakeRotation,
			[Token(Token = "0x40000C8")]
			ShakeScale,
			[Token(Token = "0x40000C9")]
			CameraAspect,
			[Token(Token = "0x40000CA")]
			CameraBackgroundColor,
			[Token(Token = "0x40000CB")]
			CameraFieldOfView,
			[Token(Token = "0x40000CC")]
			CameraOrthoSize,
			[Token(Token = "0x40000CD")]
			CameraPixelRect,
			[Token(Token = "0x40000CE")]
			CameraRect,
			[Token(Token = "0x40000CF")]
			UIWidthHeight
		}

		[Token(Token = "0x2000061")]
		public enum TargetType
		{
			[Token(Token = "0x40000D1")]
			Unset,
			[Token(Token = "0x40000D2")]
			Camera,
			[Token(Token = "0x40000D3")]
			CanvasGroup,
			[Token(Token = "0x40000D4")]
			Image,
			[Token(Token = "0x40000D5")]
			Light,
			[Token(Token = "0x40000D6")]
			RectTransform,
			[Token(Token = "0x40000D7")]
			Renderer,
			[Token(Token = "0x40000D8")]
			SpriteRenderer,
			[Token(Token = "0x40000D9")]
			Rigidbody,
			[Token(Token = "0x40000DA")]
			Rigidbody2D,
			[Token(Token = "0x40000DB")]
			Text,
			[Token(Token = "0x40000DC")]
			Transform,
			[Token(Token = "0x40000DD")]
			tk2dBaseSprite,
			[Token(Token = "0x40000DE")]
			tk2dTextMesh,
			[Token(Token = "0x40000DF")]
			TextMeshPro,
			[Token(Token = "0x40000E0")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool autoGenerate;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isActive;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		public bool isValid;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool optionalBool1;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenAutoGenerationCalled;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xA357C8", Offset = "0xA357C8", VA = "0xA357C8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xA35894", Offset = "0xA35894", VA = "0xA35894")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xA35960", Offset = "0xA35960", VA = "0xA35960")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xA359CC", Offset = "0xA359CC", VA = "0xA359CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA36FC8", Offset = "0xA36FC8", VA = "0xA36FC8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA37008", Offset = "0xA37008", VA = "0xA37008")]
		private void Reset()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA3700C", Offset = "0xA3700C", VA = "0xA3700C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA37044", Offset = "0xA37044", VA = "0xA37044")]
		public void RewindThenRecreateTween()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xA3707C", Offset = "0xA3707C", VA = "0xA3707C")]
		public void RewindThenRecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA370B4", Offset = "0xA370B4", VA = "0xA370B4")]
		public void RecreateTween()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA370C0", Offset = "0xA370C0", VA = "0xA370C0")]
		public void RecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA35A18", Offset = "0xA35A18", VA = "0xA35A18")]
		public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xA37314", Offset = "0xA37314", VA = "0xA37314")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA3746C", Offset = "0xA3746C", VA = "0xA3746C")]
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA37558", Offset = "0xA37558", VA = "0xA37558", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA375D8", Offset = "0xA375D8", VA = "0xA375D8", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA37658", Offset = "0xA37658", VA = "0xA37658", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xA376D8", Offset = "0xA376D8", VA = "0xA376D8", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xA37758", Offset = "0xA37758", VA = "0xA37758", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xA377D8", Offset = "0xA377D8", VA = "0xA377D8", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA378BC", Offset = "0xA378BC", VA = "0xA378BC", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA378CC", Offset = "0xA378CC", VA = "0xA378CC", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA37C2C", Offset = "0xA37C2C", VA = "0xA37C2C", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA37CB0", Offset = "0xA37CB0", VA = "0xA37CB0", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA37D44", Offset = "0xA37D44", VA = "0xA37D44")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA37DCC", Offset = "0xA37DCC", VA = "0xA37DCC")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA37E24", Offset = "0xA37E24", VA = "0xA37E24")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA37E7C", Offset = "0xA37E7C", VA = "0xA37E7C")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA37F04", Offset = "0xA37F04", VA = "0xA37F04")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA37F5C", Offset = "0xA37F5C", VA = "0xA37F5C")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA37FE4", Offset = "0xA37FE4", VA = "0xA37FE4")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA3803C", Offset = "0xA3803C", VA = "0xA3803C")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xA38178", Offset = "0xA38178", VA = "0xA38178")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xA3820C", Offset = "0xA3820C", VA = "0xA3820C")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xA3827C", Offset = "0xA3827C", VA = "0xA3827C")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xA38314", Offset = "0xA38314", VA = "0xA38314")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xA38388", Offset = "0xA38388", VA = "0xA38388")]
		public void DOKillById(string id)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xA38414", Offset = "0xA38414", VA = "0xA38414")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xA370E4", Offset = "0xA370E4", VA = "0xA370E4")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xA38470", Offset = "0xA38470", VA = "0xA38470")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xA370CC", Offset = "0xA370CC", VA = "0xA370CC")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xA372F4", Offset = "0xA372F4", VA = "0xA372F4")]
		private GameObject GetTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xA379D8", Offset = "0xA379D8", VA = "0xA379D8")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xA384A8", Offset = "0xA384A8", VA = "0xA384A8")]
		public DOTweenAnimation()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x60001D9")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000063")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xA3869C", Offset = "0xA3869C", VA = "0xA3869C")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA386EC", Offset = "0xA386EC", VA = "0xA386EC")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xA38AB0", Offset = "0xA38AB0", VA = "0xA38AB0")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
namespace BezierSolution
{
	[Token(Token = "0x2000066")]
	public class BezierPoint : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000067")]
		public struct ExtraData
		{
			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float c1;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float c2;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float c3;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float c4;

			[Token(Token = "0x6000200")]
			[Address(RVA = "0xA39EF4", Offset = "0xA39EF4", VA = "0xA39EF4")]
			public ExtraData(float c1 = 0f, float c2 = 0f, float c3 = 0f, float c4 = 0f)
			{
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0xA39F00", Offset = "0xA39F00", VA = "0xA39F00")]
			public static ExtraData Lerp(ExtraData a, ExtraData b, float t)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0xA39F4C", Offset = "0xA39F4C", VA = "0xA39F4C")]
			public static ExtraData LerpUnclamped(ExtraData a, ExtraData b, float t)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0xA39F84", Offset = "0xA39F84", VA = "0xA39F84")]
			public static implicit operator ExtraData(Vector2 v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0xA39F90", Offset = "0xA39F90", VA = "0xA39F90")]
			public static implicit operator ExtraData(Vector3 v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0xA39F98", Offset = "0xA39F98", VA = "0xA39F98")]
			public static implicit operator ExtraData(Vector4 v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0xA39F9C", Offset = "0xA39F9C", VA = "0xA39F9C")]
			public static implicit operator ExtraData(Quaternion q)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0xA39FA0", Offset = "0xA39FA0", VA = "0xA39FA0")]
			public static implicit operator ExtraData(Rect r)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000208")]
			[Address(RVA = "0xA3A018", Offset = "0xA3A018", VA = "0xA3A018")]
			public static implicit operator ExtraData(Vector2Int v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000209")]
			[Address(RVA = "0xA3A030", Offset = "0xA3A030", VA = "0xA3A030")]
			public static implicit operator ExtraData(Vector3Int v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x600020A")]
			[Address(RVA = "0xA3A048", Offset = "0xA3A048", VA = "0xA3A048")]
			public static implicit operator ExtraData(RectInt r)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x600020B")]
			[Address(RVA = "0xA3A0B4", Offset = "0xA3A0B4", VA = "0xA3A0B4")]
			public static implicit operator Vector2(ExtraData v)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600020C")]
			[Address(RVA = "0xA3A0B8", Offset = "0xA3A0B8", VA = "0xA3A0B8")]
			public static implicit operator Vector3(ExtraData v)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0xA3A0BC", Offset = "0xA3A0BC", VA = "0xA3A0BC")]
			public static implicit operator Vector4(ExtraData v)
			{
				return default(Vector4);
			}

			[Token(Token = "0x600020E")]
			[Address(RVA = "0xA3A0C0", Offset = "0xA3A0C0", VA = "0xA3A0C0")]
			public static implicit operator Quaternion(ExtraData v)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0xA3A0C4", Offset = "0xA3A0C4", VA = "0xA3A0C4")]
			public static implicit operator Rect(ExtraData v)
			{
				return default(Rect);
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0xA3A0F0", Offset = "0xA3A0F0", VA = "0xA3A0F0")]
			public static implicit operator Vector2Int(ExtraData v)
			{
				return default(Vector2Int);
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0xA3A2A4", Offset = "0xA3A2A4", VA = "0xA3A2A4")]
			public static implicit operator Vector3Int(ExtraData v)
			{
				return default(Vector3Int);
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0xA3A4F0", Offset = "0xA3A4F0", VA = "0xA3A4F0")]
			public static implicit operator RectInt(ExtraData v)
			{
				return default(RectInt);
			}

			[Token(Token = "0x6000213")]
			[Address(RVA = "0xA3A834", Offset = "0xA3A834", VA = "0xA3A834")]
			public static bool operator ==(ExtraData d1, ExtraData d2)
			{
				return default(bool);
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0xA3A864", Offset = "0xA3A864", VA = "0xA3A864")]
			public static bool operator !=(ExtraData d1, ExtraData d2)
			{
				return default(bool);
			}

			[Token(Token = "0x6000215")]
			[Address(RVA = "0xA3A894", Offset = "0xA3A894", VA = "0xA3A894", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0xA3A94C", Offset = "0xA3A94C", VA = "0xA3A94C", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0xA3A998", Offset = "0xA3A998", VA = "0xA3A998", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x2000068")]
		public enum HandleMode
		{
			[Token(Token = "0x40000EF")]
			Free,
			[Token(Token = "0x40000F0")]
			Aligned,
			[Token(Token = "0x40000F1")]
			Mirrored
		}

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private Vector3 m_position;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private Vector3 m_precedingControlPointLocalPosition;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private Vector3 m_precedingControlPointPosition;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private Vector3 m_followingControlPointLocalPosition;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		private Vector3 m_followingControlPointPosition;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[HideInInspector]
		private HandleMode m_handleMode;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ExtraData extraData;

		[Token(Token = "0x17000007")]
		public Vector3 localPosition
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xA38ECC", Offset = "0xA38ECC", VA = "0xA38ECC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xA38EEC", Offset = "0xA38EEC", VA = "0xA38EEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Vector3 position
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xA38F34", Offset = "0xA38F34", VA = "0xA38F34")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xA39008", Offset = "0xA39008", VA = "0xA39008")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public Quaternion localRotation
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xA39050", Offset = "0xA39050", VA = "0xA39050")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xA39070", Offset = "0xA39070", VA = "0xA39070")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Quaternion rotation
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xA390C0", Offset = "0xA390C0", VA = "0xA390C0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xA390E0", Offset = "0xA390E0", VA = "0xA390E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Vector3 localEulerAngles
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xA39130", Offset = "0xA39130", VA = "0xA39130")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xA39150", Offset = "0xA39150", VA = "0xA39150")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Vector3 eulerAngles
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xA39198", Offset = "0xA39198", VA = "0xA39198")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xA391B8", Offset = "0xA391B8", VA = "0xA391B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Vector3 localScale
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xA39200", Offset = "0xA39200", VA = "0xA39200")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xA39220", Offset = "0xA39220", VA = "0xA39220")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Vector3 precedingControlPointLocalPosition
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xA39268", Offset = "0xA39268", VA = "0xA39268")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xA39274", Offset = "0xA39274", VA = "0xA39274")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Vector3 precedingControlPointPosition
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xA3944C", Offset = "0xA3944C", VA = "0xA3944C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xA39488", Offset = "0xA39488", VA = "0xA39488")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 followingControlPointLocalPosition
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xA39710", Offset = "0xA39710", VA = "0xA39710")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xA3971C", Offset = "0xA3971C", VA = "0xA3971C")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Vector3 followingControlPointPosition
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xA398F4", Offset = "0xA398F4", VA = "0xA398F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xA39930", Offset = "0xA39930", VA = "0xA39930")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public HandleMode handleMode
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xA39BB8", Offset = "0xA39BB8", VA = "0xA39BB8")]
			get
			{
				return default(HandleMode);
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xA39BC0", Offset = "0xA39BC0", VA = "0xA39BC0")]
			set
			{
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xA39BE0", Offset = "0xA39BE0", VA = "0xA39BE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xA39C04", Offset = "0xA39C04", VA = "0xA39C04")]
		public void CopyTo(BezierPoint other)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xA38F70", Offset = "0xA38F70", VA = "0xA38F70")]
		private void Revalidate()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xA39CF8", Offset = "0xA39CF8", VA = "0xA39CF8")]
		[Conditional("UNITY_EDITOR")]
		private void SetSplineDirty()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xA39CFC", Offset = "0xA39CFC", VA = "0xA39CFC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA39E58", Offset = "0xA39E58", VA = "0xA39E58")]
		public BezierPoint()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[ExecuteInEditMode]
	public class BezierSpline : MonoBehaviour
	{
		[Token(Token = "0x200006A")]
		public struct PointIndexTuple
		{
			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly int index1;

			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public readonly int index2;

			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly float t;

			[Token(Token = "0x6000239")]
			[Address(RVA = "0xA3E430", Offset = "0xA3E430", VA = "0xA3E430")]
			public PointIndexTuple(int index1, int index2, float t)
			{
			}
		}

		[Token(Token = "0x200006B")]
		public delegate BezierPoint.ExtraData ExtraDataLerpFunction(BezierPoint.ExtraData data1, BezierPoint.ExtraData data2, float normalizedT);

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ExtraDataLerpFunction defaultExtraDataLerpFunction;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material gizmoMaterial;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<BezierPoint> endPoints;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool loop;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool drawGizmos;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color gizmoColor;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float gizmoStep;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_gizmoSmoothness;

		[Token(Token = "0x17000013")]
		public int gizmoSmoothness
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0xA3A9C0", Offset = "0xA3A9C0", VA = "0xA3A9C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xA3A9C8", Offset = "0xA3A9C8", VA = "0xA3A9C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public int Count
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xA3AA40", Offset = "0xA3AA40", VA = "0xA3AA40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		public float Length
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xA3AA88", Offset = "0xA3AA88", VA = "0xA3AA88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000016")]
		public BezierPoint this[int index]
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xA3AC88", Offset = "0xA3AC88", VA = "0xA3AC88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xA3ADB8", Offset = "0xA3ADB8", VA = "0xA3ADB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA3AE50", Offset = "0xA3AE50", VA = "0xA3AE50")]
		public void Initialize(int endPointsCount)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA3ADBC", Offset = "0xA3ADBC", VA = "0xA3ADBC")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xA3B028", Offset = "0xA3B028", VA = "0xA3B028")]
		public BezierPoint InsertNewPointAt(int index)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xA3B47C", Offset = "0xA3B47C", VA = "0xA3B47C")]
		public BezierPoint DuplicatePointAt(int index)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xA3B760", Offset = "0xA3B760", VA = "0xA3B760")]
		public void RemovePointAt(int index)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xA3BAC4", Offset = "0xA3BAC4", VA = "0xA3BAC4")]
		public void SwapPointsAt(int index1, int index2)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xA3BDA0", Offset = "0xA3BDA0", VA = "0xA3BDA0")]
		public void MovePoint(int previousIndex, int newIndex)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xA3BDA4", Offset = "0xA3BDA4", VA = "0xA3BDA4")]
		public void Internal_MovePoint(int previousIndex, int newIndex, string undo)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xA3C118", Offset = "0xA3C118", VA = "0xA3C118")]
		public int IndexOf(BezierPoint point)
		{
			return default(int);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xA3C170", Offset = "0xA3C170", VA = "0xA3C170")]
		public Vector3 GetPoint(float normalizedT)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xA3C378", Offset = "0xA3C378", VA = "0xA3C378")]
		public RotationReference GetTranformOfClosestPoint(float normalizedT)
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xA3C6A0", Offset = "0xA3C6A0", VA = "0xA3C6A0")]
		public Vector3 GetTangent(float normalizedT)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xA3C95C", Offset = "0xA3C95C", VA = "0xA3C95C")]
		public BezierPoint.ExtraData GetExtraData(float normalizedT)
		{
			return default(BezierPoint.ExtraData);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xA3C9CC", Offset = "0xA3C9CC", VA = "0xA3C9CC")]
		public BezierPoint.ExtraData GetExtraData(float normalizedT, ExtraDataLerpFunction lerpFunction)
		{
			return default(BezierPoint.ExtraData);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xA3AA9C", Offset = "0xA3AA9C", VA = "0xA3AA9C")]
		public float GetLengthApproximately(float startNormalizedT, float endNormalizedT, float accuracy = 50f)
		{
			return default(float);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xA3CBA4", Offset = "0xA3CBA4", VA = "0xA3CBA4")]
		public PointIndexTuple GetNearestPointIndicesTo(float normalizedT)
		{
			return default(PointIndexTuple);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA3CCD4", Offset = "0xA3CCD4", VA = "0xA3CCD4")]
		public Vector3 FindNearestPointTo(Vector3 worldPos, float accuracy = 100f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA3CCEC", Offset = "0xA3CCEC", VA = "0xA3CCEC")]
		public Vector3 FindNearestPointTo(Vector3 worldPos, out float normalizedT, float accuracy = 100f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA3CE1C", Offset = "0xA3CE1C", VA = "0xA3CE1C")]
		public Vector3 MoveAlongSpline(ref float normalizedT, float deltaMovement, int accuracy = 3)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA3CF3C", Offset = "0xA3CF3C", VA = "0xA3CF3C")]
		public void ConstructLinearPath()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA3D14C", Offset = "0xA3D14C", VA = "0xA3D14C")]
		public void AutoConstructSpline()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA3DA78", Offset = "0xA3DA78", VA = "0xA3DA78")]
		private static Vector3[] GetFirstControlPoints(Vector3[] rhs)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA3DC78", Offset = "0xA3DC78", VA = "0xA3DC78")]
		public void AutoConstructSpline2()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xA3CB68", Offset = "0xA3CB68", VA = "0xA3CB68")]
		private float AccuracyToStepSize(float accuracy)
		{
			return default(float);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA3DFB0", Offset = "0xA3DFB0", VA = "0xA3DFB0")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xA3E2F0", Offset = "0xA3E2F0", VA = "0xA3E2F0")]
		public BezierSpline()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class RotationReference
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform PointA;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform PointB;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float t;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 epsilon;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xA3E608", Offset = "0xA3E608", VA = "0xA3E608")]
		public Vector3 GetInterpolatedRotation()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA3E738", Offset = "0xA3E738", VA = "0xA3E738")]
		public float GetInterpolatedZ()
		{
			return default(float);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xA3E854", Offset = "0xA3E854", VA = "0xA3E854")]
		public RotationReference()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public enum TravelMode
	{
		[Token(Token = "0x4000102")]
		Once,
		[Token(Token = "0x4000103")]
		Loop,
		[Token(Token = "0x4000104")]
		PingPong
	}
	[Token(Token = "0x200006E")]
	public enum LookAtMode
	{
		[Token(Token = "0x4000106")]
		None,
		[Token(Token = "0x4000107")]
		Forward,
		[Token(Token = "0x4000108")]
		SplineExtraData
	}
	[Token(Token = "0x200006F")]
	public abstract class BezierWalker : MonoBehaviour
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly BezierSpline.ExtraDataLerpFunction extraDataLerpAsQuaternionFunction;

		[Token(Token = "0x17000017")]
		public abstract BezierSpline Spline
		{
			[Token(Token = "0x6000241")]
			get;
		}

		[Token(Token = "0x17000018")]
		public abstract bool MovingForward
		{
			[Token(Token = "0x6000242")]
			get;
		}

		[Token(Token = "0x17000019")]
		public abstract float NormalizedT
		{
			[Token(Token = "0x6000243")]
			get;
			[Token(Token = "0x6000244")]
			set;
		}

		[Token(Token = "0x6000245")]
		public abstract void Execute(float deltaTime);

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xA3E870", Offset = "0xA3E870", VA = "0xA3E870")]
		private static BezierPoint.ExtraData InterpolateExtraDataAsQuaternion(BezierPoint.ExtraData data1, BezierPoint.ExtraData data2, float normalizedT)
		{
			return default(BezierPoint.ExtraData);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xA3E920", Offset = "0xA3E920", VA = "0xA3E920")]
		protected BezierWalker()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class BezierWalkerLocomotion : BezierWalker
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BezierWalker walker;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Transform> tailObjects;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<float> tailObjectDistances;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float movementLerpModifier;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationLerpModifier;

		[NonSerialized]
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Obsolete("Use lookAt instead", true)]
		public bool lookForward;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public LookAtMode lookAt;

		[Token(Token = "0x1700001A")]
		public List<Transform> Tail
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0xA3E9C4", Offset = "0xA3E9C4", VA = "0xA3E9C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public List<float> TailDistances
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xA3E9CC", Offset = "0xA3E9CC", VA = "0xA3E9CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public override BezierSpline Spline
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0xA3E9D4", Offset = "0xA3E9D4", VA = "0xA3E9D4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public override bool MovingForward
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0xA3E9F4", Offset = "0xA3E9F4", VA = "0xA3E9F4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public override float NormalizedT
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0xA3EA14", Offset = "0xA3EA14", VA = "0xA3EA14", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0xA3EA34", Offset = "0xA3EA34", VA = "0xA3EA34", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA3EA54", Offset = "0xA3EA54", VA = "0xA3EA54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xA3EBB4", Offset = "0xA3EBB4", VA = "0xA3EBB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA3EBD8", Offset = "0xA3EBD8", VA = "0xA3EBD8", Slot = "8")]
		public override void Execute(float deltaTime)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA3EF28", Offset = "0xA3EF28", VA = "0xA3EF28")]
		public void AddToTail(Transform transform, float distanceToPreviousObject)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA3F0F4", Offset = "0xA3F0F4", VA = "0xA3F0F4")]
		public void InsertIntoTail(int index, Transform transform, float distanceToPreviousObject)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xA3F220", Offset = "0xA3F220", VA = "0xA3F220")]
		public void RemoveFromTail(Transform transform)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA3F3DC", Offset = "0xA3F3DC", VA = "0xA3F3DC")]
		public BezierWalkerLocomotion()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class BezierWalkerWithSpeed : BezierWalker
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BezierSpline spline;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TravelMode travelMode;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_normalizedT;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float rotationLerpModifier;

		[NonSerialized]
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Obsolete("Use lookAt instead", true)]
		public bool lookForward;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LookAtMode lookAt;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool isGoingForward;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent onPathCompleted;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool onPathCompletedCalledAt1;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool onPathCompletedCalledAt0;

		[Token(Token = "0x1700001F")]
		public override BezierSpline Spline
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xA3F448", Offset = "0xA3F448", VA = "0xA3F448", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public override float NormalizedT
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0xA3F450", Offset = "0xA3F450", VA = "0xA3F450", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xA3F458", Offset = "0xA3F458", VA = "0xA3F458", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public override bool MovingForward
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xA3F460", Offset = "0xA3F460", VA = "0xA3F460", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA3F47C", Offset = "0xA3F47C", VA = "0xA3F47C")]
		private void Update()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA3F4A0", Offset = "0xA3F4A0", VA = "0xA3F4A0", Slot = "8")]
		public override void Execute(float deltaTime)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA3F7E8", Offset = "0xA3F7E8", VA = "0xA3F7E8")]
		public BezierWalkerWithSpeed()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class BezierWalkerWithTime : BezierWalker
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BezierSpline spline;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TravelMode travelMode;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float travelTime;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_normalizedT;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float movementLerpModifier;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float rotationLerpModifier;

		[NonSerialized]
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Obsolete("Use lookAt instead", true)]
		public bool lookForward;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LookAtMode lookAt;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool isGoingForward;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent onPathCompleted;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool onPathCompletedCalledAt1;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool onPathCompletedCalledAt0;

		[Token(Token = "0x17000022")]
		public override BezierSpline Spline
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0xA3F8A0", Offset = "0xA3F8A0", VA = "0xA3F8A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public override float NormalizedT
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xA3F8A8", Offset = "0xA3F8A8", VA = "0xA3F8A8", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xA3F8B0", Offset = "0xA3F8B0", VA = "0xA3F8B0", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public override bool MovingForward
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0xA3F8B8", Offset = "0xA3F8B8", VA = "0xA3F8B8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xA3F8C0", Offset = "0xA3F8C0", VA = "0xA3F8C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA3F8E4", Offset = "0xA3F8E4", VA = "0xA3F8E4", Slot = "8")]
		public override void Execute(float deltaTime)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xA3FC54", Offset = "0xA3FC54", VA = "0xA3FC54")]
		public BezierWalkerWithTime()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[ExecuteInEditMode]
	public class ParticlesFollowBezier : MonoBehaviour
	{
		[Token(Token = "0x2000074")]
		public enum FollowMode
		{
			[Token(Token = "0x4000131")]
			Relaxed,
			[Token(Token = "0x4000132")]
			Strict
		}

		[Token(Token = "0x4000128")]
		private const int MAX_PARTICLE_COUNT = 25000;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BezierSpline spline;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FollowMode followMode;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform cachedTransform;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem cachedPS;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem.MainModule cachedMainModule;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Vector4> particleData;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xA3FD0C", Offset = "0xA3FD0C", VA = "0xA3FD0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA3FE60", Offset = "0xA3FE60", VA = "0xA3FE60")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xA40348", Offset = "0xA40348", VA = "0xA40348")]
		public ParticlesFollowBezier()
		{
		}
	}
}
