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
		[Address(RVA = "0x9DC5CC", Offset = "0x9DC5CC", VA = "0x9DC5CC")]
		public static string GetVersionInformation()
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x9DC678", Offset = "0x9DC678", VA = "0x9DC678")]
		public static string GetVersionInformation(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x9DC640", Offset = "0x9DC640", VA = "0x9DC640")]
		public static string GetVersionInformation(Assembly assembly)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x9DC6F0", Offset = "0x9DC6F0", VA = "0x9DC6F0")]
		public static bool IsStringFalse(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x9DC78C", Offset = "0x9DC78C", VA = "0x9DC78C")]
		public static bool IsStringTrue(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x9DC7EC", Offset = "0x9DC7EC", VA = "0x9DC7EC")]
		public static bool IsAlphaNumeric(string label)
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x9DC8A0", Offset = "0x9DC8A0", VA = "0x9DC8A0")]
		public static string ForceAlphaNumeric(string label, string defaultLabel)
		{
			return null;
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x9DC958", Offset = "0x9DC958", VA = "0x9DC958")]
		public static string Format(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x9DC9CC", Offset = "0x9DC9CC", VA = "0x9DC9CC")]
		public static string Format(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x9DCA50", Offset = "0x9DCA50", VA = "0x9DCA50")]
		public static string Format(string key, float value)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x9DCAD4", Offset = "0x9DCAD4", VA = "0x9DCAD4")]
		public static string Format(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x9DCB80", Offset = "0x9DCB80", VA = "0x9DCB80")]
		public static string Format(string key, Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x9DCCFC", Offset = "0x9DCCFC", VA = "0x9DCCFC")]
		public static string Format(string key, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x9DCEB4", Offset = "0x9DCEB4", VA = "0x9DCEB4")]
		public static string Format(string key, Vector4 value)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x9DD194", Offset = "0x9DD194", VA = "0x9DD194")]
		public static string Format(string key, Color value)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x9DD474", Offset = "0x9DD474", VA = "0x9DD474")]
		public static Component GetComponentInChildren(Type t, Component component)
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x9DD4EC", Offset = "0x9DD4EC", VA = "0x9DD4EC")]
		public static Component GetComponentInChildren(Type t, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x9DD554", Offset = "0x9DD554", VA = "0x9DD554")]
		public static Component GetComponentInChildren(Type t, Transform parent, bool includeInactive)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x9DD5A0", Offset = "0x9DD5A0", VA = "0x9DD5A0")]
		public static Component[] GetComponentsInChildren(Type t, Component component)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x9DD66C", Offset = "0x9DD66C", VA = "0x9DD66C")]
		public static Component[] GetComponentsInChildren(Type t, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x9DD6E0", Offset = "0x9DD6E0", VA = "0x9DD6E0")]
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
		[Address(RVA = "0x9DD704", Offset = "0x9DD704", VA = "0x9DD704")]
		public static bool CheckMask(int flag, int mask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x9DD710", Offset = "0x9DD710", VA = "0x9DD710")]
		public static bool CheckMaskAny(int flag, int mask)
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x9DD71C", Offset = "0x9DD71C", VA = "0x9DD71C")]
		public static string GetSystemTimeString()
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x9DD79C", Offset = "0x9DD79C", VA = "0x9DD79C")]
		public static string GetTimeString(float time, string timeFormat)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x9DD870", Offset = "0x9DD870", VA = "0x9DD870")]
		public static Bounds GetBounds(Transform target)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x9DD8F0", Offset = "0x9DD8F0", VA = "0x9DD8F0")]
		public static Bounds GetBounds(Transform target, bool onlyStatic)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x9DD97C", Offset = "0x9DD97C", VA = "0x9DD97C")]
		public static Bounds GetBounds(Transform target, bool onlyStatic, bool onlyMeshRenderers)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x9DDA14", Offset = "0x9DDA14", VA = "0x9DDA14")]
		public static Bounds GetBounds(Transform target, bool onlyStatic, bool onlyMeshRenderers, bool includeTerrains)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x9DDAB8", Offset = "0x9DDAB8", VA = "0x9DDAB8")]
		public static Bounds GetBounds(Transform target, bool onlyStatic, bool onlyMeshRenderers, bool includeTerrains, bool includeColliders)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x9DDB60", Offset = "0x9DDB60", VA = "0x9DDB60")]
		public static Bounds GetBounds(Transform target, bool onlyStatic, bool onlyMeshRenderers, bool includeTerrains, bool includeColliders, bool includeInactive)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x9DE094", Offset = "0x9DE094", VA = "0x9DE094")]
		public static void ResetOrigin(Transform target, Vector3 origin, bool isLocal)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x9DE67C", Offset = "0x9DE67C", VA = "0x9DE67C")]
		public static Vector3 InterpolateSpline(Vector3[] points, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x9DE870", Offset = "0x9DE870", VA = "0x9DE870")]
		public static string ReplaceAliases(string text, string aliasPrefix, string aliasSuffix, GetAliasText getAliasText)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x9DE940", Offset = "0x9DE940", VA = "0x9DE940")]
		public static Vector2 Vector2FromString(string str)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x9DCC28", Offset = "0x9DCC28", VA = "0x9DCC28")]
		public static string ToString(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x9DEAFC", Offset = "0x9DEAFC", VA = "0x9DEAFC")]
		public static bool IsVector3(string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x9DEB24", Offset = "0x9DEB24", VA = "0x9DEB24")]
		public static Vector3 Vector3FromString(string str)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x9DCDB4", Offset = "0x9DCDB4", VA = "0x9DCDB4")]
		public static string ToString(Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x9DED24", Offset = "0x9DED24", VA = "0x9DED24")]
		public static Vector4 Vector4FromString(string str)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x9DCF74", Offset = "0x9DCF74", VA = "0x9DCF74")]
		public static string ToString(Vector4 v)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x9DEF6C", Offset = "0x9DEF6C", VA = "0x9DEF6C")]
		public static Color ColorFromString(string str)
		{
			return default(Color);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x9DF118", Offset = "0x9DF118", VA = "0x9DF118")]
		private static float parseColorComponent(string colString)
		{
			return default(float);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x9DD254", Offset = "0x9DD254", VA = "0x9DD254")]
		public static string ToString(Color c)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x9DF198", Offset = "0x9DF198", VA = "0x9DF198")]
		public static string FormatTime(float time)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x9DF280", Offset = "0x9DF280", VA = "0x9DF280")]
		public static GameObject CreateGameObject(string name, bool allowDuplicates)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x9DF338", Offset = "0x9DF338", VA = "0x9DF338")]
		public static string GetUniqueId(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x9DF5D8", Offset = "0x9DF5D8", VA = "0x9DF5D8")]
		public static string GetDataPathBase()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x9DF600", Offset = "0x9DF600", VA = "0x9DF600")]
		public static string GetDataPath(string dataPathRelative)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x9DF68C", Offset = "0x9DF68C", VA = "0x9DF68C")]
		public static string GetDataPath(string dataPathRelative, string filenameNoPath)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x9DF728", Offset = "0x9DF728", VA = "0x9DF728")]
		public static bool CreatePath(string pathAbsolute)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x9DF7BC", Offset = "0x9DF7BC", VA = "0x9DF7BC")]
		public static string CleanResourcePath(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x9DF828", Offset = "0x9DF828", VA = "0x9DF828")]
		public static string CleanResourceFilename(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x9DF8B4", Offset = "0x9DF8B4", VA = "0x9DF8B4")]
		public static string CleanResourceFileNameWithoutExtension(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x9DF964", Offset = "0x9DF964", VA = "0x9DF964")]
		public static string CleanResourceFullPathWithoutExtension(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x9DF90C", Offset = "0x9DF90C", VA = "0x9DF90C")]
		public static string FileNameWithoutExtension(string filename)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x9DF9BC", Offset = "0x9DF9BC", VA = "0x9DF9BC")]
		public static string FullPathWithoutExtension(string filename)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x9DFA4C", Offset = "0x9DFA4C", VA = "0x9DFA4C")]
		public static string BuildFilename(string filenamePrefix, string extension, bool includeTime)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x9DFB2C", Offset = "0x9DFB2C", VA = "0x9DFB2C")]
		public static string BuildFilenamePath(string relativePath, string filenamePrefix, string extension, bool includeTime)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x9DFBB0", Offset = "0x9DFBB0", VA = "0x9DFBB0")]
		public static string BuildFilenameStripPath(string filename, string extension)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x9DFC48", Offset = "0x9DFC48", VA = "0x9DFC48")]
		public static object LoadResource(string resourceName, Type type)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x9DFCB4", Offset = "0x9DFCB4", VA = "0x9DFCB4")]
		public static object[] LoadResourceAll(string resourceName, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x9DFD20", Offset = "0x9DFD20", VA = "0x9DFD20")]
		public static string LoadTextResource(string resourceName)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x9DFDF0", Offset = "0x9DFDF0", VA = "0x9DFDF0")]
		public static string LoadFile(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x9DFE84", Offset = "0x9DFE84", VA = "0x9DFE84")]
		public static bool SaveFile(string filename, string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x9DFF18", Offset = "0x9DFF18", VA = "0x9DFF18")]
		public static bool FileExists(string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x9DFF20", Offset = "0x9DFF20", VA = "0x9DFF20")]
		public static bool MoveFile(string filename, string newFilename)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x9DFFDC", Offset = "0x9DFFDC", VA = "0x9DFFDC")]
		public static bool SaveImageToFile(Texture2D texture, string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x9E0070", Offset = "0x9E0070", VA = "0x9E0070")]
		public static Texture2D LoadImageFromFile(Texture2D texture, string filename, int maxBufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x9E0384", Offset = "0x9E0384", VA = "0x9E0384")]
		public static Texture2D LoadImageOrResource(Texture2D texture, string relativeFilename, int maxBufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x9E047C", Offset = "0x9E047C", VA = "0x9E047C")]
		public static Texture2D LoadImageOrResource(Texture2D texture, string dataPath, string relativeFilename, int maxBufferSize)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x9E05C4", Offset = "0x9E05C4", VA = "0x9E05C4")]
		public static string LoadFileOrResource(string relativeFilename)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x9E063C", Offset = "0x9E063C", VA = "0x9E063C")]
		public static string LoadFileOrResource(string dataPath, string relativeFilename)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x9E0700", Offset = "0x9E0700", VA = "0x9E0700")]
		public static Transform FindChild(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x9E0A24", Offset = "0x9E0A24", VA = "0x9E0A24")]
		public static Transform FindChildRecursive(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x9E1050", Offset = "0x9E1050", VA = "0x9E1050")]
		public static Transform FindChildWithTag(Transform parent, string tag)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x9E135C", Offset = "0x9E135C", VA = "0x9E135C")]
		public static void DisableAllCameras()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x9E13B0", Offset = "0x9E13B0", VA = "0x9E13B0")]
		public static bool SetActiveCamera(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x9E1408", Offset = "0x9E1408", VA = "0x9E1408")]
		public static bool SetActiveCamera(Camera camera, AudioListener audioListener)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x9E1470", Offset = "0x9E1470", VA = "0x9E1470")]
		public static bool SetActiveCamera(Camera camera, AudioListener audioListener, bool attachAudioListener)
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x9E16F0", Offset = "0x9E16F0", VA = "0x9E16F0")]
		public static float CalculateMultiplier(float x, Vector3 coefficients)
		{
			return default(float);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x9E1708", Offset = "0x9E1708", VA = "0x9E1708")]
		public static float CalculateMultiplier0(float x, Vector3 coefficients)
		{
			return default(float);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x9E1710", Offset = "0x9E1710", VA = "0x9E1710")]
		public static float CalculateMultiplier1(float x, Vector3 coefficients)
		{
			return default(float);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x9E171C", Offset = "0x9E171C", VA = "0x9E171C")]
		public static Vector3 ExtractCoefficients(string coefficients)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x9E1770", Offset = "0x9E1770", VA = "0x9E1770")]
		public static float ApplyMultiplier(float val, float x, string coefficients)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x9E17F8", Offset = "0x9E17F8", VA = "0x9E17F8")]
		public static float ApplyMultiplier(float val, float x, Vector3 coefficients)
		{
			return default(float);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x9E1888", Offset = "0x9E1888", VA = "0x9E1888")]
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
		[Address(RVA = "0x9E1AA8", Offset = "0x9E1AA8", VA = "0x9E1AA8")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x9E1C5C", Offset = "0x9E1C5C", VA = "0x9E1C5C")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x9E1DE8", Offset = "0x9E1DE8", VA = "0x9E1DE8")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x9E1F88", Offset = "0x9E1F88", VA = "0x9E1F88")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x9E1FF0", Offset = "0x9E1FF0", VA = "0x9E1FF0")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x9E2058", Offset = "0x9E2058", VA = "0x9E2058")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x9E20B0", Offset = "0x9E20B0", VA = "0x9E20B0")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x9E2128", Offset = "0x9E2128", VA = "0x9E2128")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x9E2180", Offset = "0x9E2180", VA = "0x9E2180")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x9E21D8", Offset = "0x9E21D8", VA = "0x9E21D8")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x9E2230", Offset = "0x9E2230", VA = "0x9E2230")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x9E2288", Offset = "0x9E2288", VA = "0x9E2288")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x9E22E8", Offset = "0x9E22E8", VA = "0x9E22E8")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x9E2344", Offset = "0x9E2344", VA = "0x9E2344")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x9E239C", Offset = "0x9E239C", VA = "0x9E239C")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000008")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x9E24BC", Offset = "0x9E24BC", VA = "0x9E24BC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x9E2674", Offset = "0x9E2674", VA = "0x9E2674")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x9E2820", Offset = "0x9E2820", VA = "0x9E2820")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x9E29CC", Offset = "0x9E29CC", VA = "0x9E29CC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x9E2B78", Offset = "0x9E2B78", VA = "0x9E2B78")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x9E2D2C", Offset = "0x9E2D2C", VA = "0x9E2D2C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x9E2F94", Offset = "0x9E2F94", VA = "0x9E2F94")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x9E34A0", Offset = "0x9E34A0", VA = "0x9E34A0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x9E3714", Offset = "0x9E3714", VA = "0x9E3714")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x9E39A8", Offset = "0x9E39A8", VA = "0x9E39A8")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x9E3B7C", Offset = "0x9E3B7C", VA = "0x9E3B7C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000014")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x9E4190", Offset = "0x9E4190", VA = "0x9E4190")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x9E4340", Offset = "0x9E4340", VA = "0x9E4340")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x9E44E8", Offset = "0x9E44E8", VA = "0x9E44E8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9E4690", Offset = "0x9E4690", VA = "0x9E4690")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x9E4820", Offset = "0x9E4820", VA = "0x9E4820")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x9E4C54", Offset = "0x9E4C54", VA = "0x9E4C54")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x9E4F48", Offset = "0x9E4F48", VA = "0x9E4F48")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x9E5260", Offset = "0x9E5260", VA = "0x9E5260")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x9E5434", Offset = "0x9E5434", VA = "0x9E5434")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200001E")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x9E5A60", Offset = "0x9E5A60", VA = "0x9E5A60")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x9E5C14", Offset = "0x9E5C14", VA = "0x9E5C14")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x9E5DA0", Offset = "0x9E5DA0", VA = "0x9E5DA0")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x9E5F7C", Offset = "0x9E5F7C", VA = "0x9E5F7C")]
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
			[Address(RVA = "0x9EAD30", Offset = "0x9EAD30", VA = "0x9EAD30")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x9E6274", Offset = "0x9E6274", VA = "0x9E6274")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x9E6400", Offset = "0x9E6400", VA = "0x9E6400")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x9E65B4", Offset = "0x9E65B4", VA = "0x9E65B4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x9E6740", Offset = "0x9E6740", VA = "0x9E6740")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x9E68F4", Offset = "0x9E68F4", VA = "0x9E68F4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x9E6A80", Offset = "0x9E6A80", VA = "0x9E6A80")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x9E6C30", Offset = "0x9E6C30", VA = "0x9E6C30")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x9E6E14", Offset = "0x9E6E14", VA = "0x9E6E14")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x9E6FC0", Offset = "0x9E6FC0", VA = "0x9E6FC0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x9E716C", Offset = "0x9E716C", VA = "0x9E716C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x9E7318", Offset = "0x9E7318", VA = "0x9E7318")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x9E74CC", Offset = "0x9E74CC", VA = "0x9E74CC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x9E7658", Offset = "0x9E7658", VA = "0x9E7658")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x9E77F4", Offset = "0x9E77F4", VA = "0x9E77F4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x9E79A0", Offset = "0x9E79A0", VA = "0x9E79A0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x9E7B44", Offset = "0x9E7B44", VA = "0x9E7B44")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x9E7CE8", Offset = "0x9E7CE8", VA = "0x9E7CE8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x9E7E9C", Offset = "0x9E7E9C", VA = "0x9E7E9C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x9E8044", Offset = "0x9E8044", VA = "0x9E8044")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x9E81EC", Offset = "0x9E81EC", VA = "0x9E81EC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x9E8394", Offset = "0x9E8394", VA = "0x9E8394")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x9E8540", Offset = "0x9E8540", VA = "0x9E8540")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x9E86EC", Offset = "0x9E86EC", VA = "0x9E86EC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x9E8888", Offset = "0x9E8888", VA = "0x9E8888")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x9E8A28", Offset = "0x9E8A28", VA = "0x9E8A28")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x9E8BC8", Offset = "0x9E8BC8", VA = "0x9E8BC8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x9E8D74", Offset = "0x9E8D74", VA = "0x9E8D74")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x9E8F30", Offset = "0x9E8F30", VA = "0x9E8F30")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x9E9114", Offset = "0x9E9114", VA = "0x9E9114")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x9E9300", Offset = "0x9E9300", VA = "0x9E9300")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x9E9728", Offset = "0x9E9728", VA = "0x9E9728")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x9E98C8", Offset = "0x9E98C8", VA = "0x9E98C8")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x9E9A58", Offset = "0x9E9A58", VA = "0x9E9A58")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x9E9BE8", Offset = "0x9E9BE8", VA = "0x9E9BE8")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x9E9D84", Offset = "0x9E9D84", VA = "0x9E9D84")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x9E9F38", Offset = "0x9E9F38", VA = "0x9E9F38")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x9EA130", Offset = "0x9EA130", VA = "0x9EA130")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x9EA2BC", Offset = "0x9EA2BC", VA = "0x9EA2BC")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x9EA4F4", Offset = "0x9EA4F4", VA = "0x9EA4F4")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x9EA70C", Offset = "0x9EA70C", VA = "0x9EA70C")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x9EA924", Offset = "0x9EA924", VA = "0x9EA924")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x9EAB3C", Offset = "0x9EAB3C", VA = "0x9EAB3C")]
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
			[Address(RVA = "0x9ED124", Offset = "0x9ED124", VA = "0x9ED124", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600018F")]
			[Address(RVA = "0x9ED35C", Offset = "0x9ED35C", VA = "0x9ED35C", Slot = "5")]
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
			[Address(RVA = "0x9ED368", Offset = "0x9ED368", VA = "0x9ED368", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x9ED5C4", Offset = "0x9ED5C4", VA = "0x9ED5C4", Slot = "5")]
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
			[Address(RVA = "0x9ED5D0", Offset = "0x9ED5D0", VA = "0x9ED5D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000193")]
			[Address(RVA = "0x9ED7F4", Offset = "0x9ED7F4", VA = "0x9ED7F4", Slot = "5")]
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
			[Address(RVA = "0x9ED800", Offset = "0x9ED800", VA = "0x9ED800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x9EDA40", Offset = "0x9EDA40", VA = "0x9EDA40", Slot = "5")]
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
			[Address(RVA = "0x9EDA4C", Offset = "0x9EDA4C", VA = "0x9EDA4C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x9EDCA4", Offset = "0x9EDCA4", VA = "0x9EDCA4", Slot = "5")]
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
			[Address(RVA = "0x9EDCB0", Offset = "0x9EDCB0", VA = "0x9EDCB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000199")]
			[Address(RVA = "0x9EDEDC", Offset = "0x9EDEDC", VA = "0x9EDEDC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x9EBCF0", Offset = "0x9EBCF0", VA = "0x9EBCF0")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x9EBED0", Offset = "0x9EBED0", VA = "0x9EBED0")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x9EC0BC", Offset = "0x9EC0BC", VA = "0x9EC0BC")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x9EC1B8", Offset = "0x9EC1B8", VA = "0x9EC1B8")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x9EC2B4", Offset = "0x9EC2B4", VA = "0x9EC2B4")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x9EC3B0", Offset = "0x9EC3B0", VA = "0x9EC3B0")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x9EC4C0", Offset = "0x9EC4C0", VA = "0x9EC4C0")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x9EC5E0", Offset = "0x9EC5E0", VA = "0x9EC5E0")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x9EC6DC", Offset = "0x9EC6DC", VA = "0x9EC6DC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x9EC8E8", Offset = "0x9EC8E8", VA = "0x9EC8E8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x9ECAF4", Offset = "0x9ECAF4", VA = "0x9ECAF4")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x9ECBE0", Offset = "0x9ECBE0", VA = "0x9ECBE0")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x9ECCCC", Offset = "0x9ECCCC", VA = "0x9ECCCC")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x9ECDB8", Offset = "0x9ECDB8", VA = "0x9ECDB8")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x9ECEAC", Offset = "0x9ECEAC", VA = "0x9ECEAC")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x9ECFA8", Offset = "0x9ECFA8", VA = "0x9ECFA8")]
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
				[Address(RVA = "0x9EDEE8", Offset = "0x9EDEE8", VA = "0x9EDEE8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600019B")]
			[Address(RVA = "0x9EC188", Offset = "0x9EC188", VA = "0x9EC188")]
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
				[Address(RVA = "0x9EDF18", Offset = "0x9EDF18", VA = "0x9EDF18", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0x9EC284", Offset = "0x9EC284", VA = "0x9EC284")]
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
				[Address(RVA = "0x9EDF78", Offset = "0x9EDF78", VA = "0x9EDF78", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600019F")]
			[Address(RVA = "0x9EC380", Offset = "0x9EC380", VA = "0x9EC380")]
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
				[Address(RVA = "0x9EDF94", Offset = "0x9EDF94", VA = "0x9EDF94", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x9EC484", Offset = "0x9EC484", VA = "0x9EC484")]
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
				[Address(RVA = "0x9EDFD4", Offset = "0x9EDFD4", VA = "0x9EDFD4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x9EC59C", Offset = "0x9EC59C", VA = "0x9EC59C")]
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
				[Address(RVA = "0x9EE02C", Offset = "0x9EE02C", VA = "0x9EE02C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x9EC6AC", Offset = "0x9EC6AC", VA = "0x9EC6AC")]
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
			[Address(RVA = "0x9EE1BC", Offset = "0x9EE1BC", VA = "0x9EE1BC")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x9EE2BC", Offset = "0x9EE2BC", VA = "0x9EE2BC")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x9EE348", Offset = "0x9EE348", VA = "0x9EE348")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x9EE3D4", Offset = "0x9EE3D4", VA = "0x9EE3D4")]
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
		[Address(RVA = "0x9EE060", Offset = "0x9EE060", VA = "0x9EE060")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x9EE114", Offset = "0x9EE114", VA = "0x9EE114")]
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
			[Address(RVA = "0x9EE5A8", Offset = "0x9EE5A8", VA = "0x9EE5A8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x9EE674", Offset = "0x9EE674", VA = "0x9EE674")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x9EE740", Offset = "0x9EE740", VA = "0x9EE740")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x9EE7AC", Offset = "0x9EE7AC", VA = "0x9EE7AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x9EFDA8", Offset = "0x9EFDA8", VA = "0x9EFDA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x9EFDE8", Offset = "0x9EFDE8", VA = "0x9EFDE8")]
		private void Reset()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x9EFDEC", Offset = "0x9EFDEC", VA = "0x9EFDEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x9EFE24", Offset = "0x9EFE24", VA = "0x9EFE24")]
		public void RewindThenRecreateTween()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x9EFE5C", Offset = "0x9EFE5C", VA = "0x9EFE5C")]
		public void RewindThenRecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x9EFE94", Offset = "0x9EFE94", VA = "0x9EFE94")]
		public void RecreateTween()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x9EFEA0", Offset = "0x9EFEA0", VA = "0x9EFEA0")]
		public void RecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x9EE7F8", Offset = "0x9EE7F8", VA = "0x9EE7F8")]
		public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x9F00F4", Offset = "0x9F00F4", VA = "0x9F00F4")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x9F024C", Offset = "0x9F024C", VA = "0x9F024C")]
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x9F0338", Offset = "0x9F0338", VA = "0x9F0338", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x9F03B8", Offset = "0x9F03B8", VA = "0x9F03B8", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x9F0438", Offset = "0x9F0438", VA = "0x9F0438", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x9F04B8", Offset = "0x9F04B8", VA = "0x9F04B8", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x9F0538", Offset = "0x9F0538", VA = "0x9F0538", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x9F05B8", Offset = "0x9F05B8", VA = "0x9F05B8", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x9F069C", Offset = "0x9F069C", VA = "0x9F069C", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x9F06AC", Offset = "0x9F06AC", VA = "0x9F06AC", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x9F0A0C", Offset = "0x9F0A0C", VA = "0x9F0A0C", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x9F0A90", Offset = "0x9F0A90", VA = "0x9F0A90", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x9F0B24", Offset = "0x9F0B24", VA = "0x9F0B24")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x9F0BAC", Offset = "0x9F0BAC", VA = "0x9F0BAC")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x9F0C04", Offset = "0x9F0C04", VA = "0x9F0C04")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x9F0C5C", Offset = "0x9F0C5C", VA = "0x9F0C5C")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x9F0CE4", Offset = "0x9F0CE4", VA = "0x9F0CE4")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x9F0D3C", Offset = "0x9F0D3C", VA = "0x9F0D3C")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x9F0DC4", Offset = "0x9F0DC4", VA = "0x9F0DC4")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x9F0E1C", Offset = "0x9F0E1C", VA = "0x9F0E1C")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x9F0F58", Offset = "0x9F0F58", VA = "0x9F0F58")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x9F0FEC", Offset = "0x9F0FEC", VA = "0x9F0FEC")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x9F105C", Offset = "0x9F105C", VA = "0x9F105C")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x9F10F4", Offset = "0x9F10F4", VA = "0x9F10F4")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x9F1168", Offset = "0x9F1168", VA = "0x9F1168")]
		public void DOKillById(string id)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x9F11F4", Offset = "0x9F11F4", VA = "0x9F11F4")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x9EFEC4", Offset = "0x9EFEC4", VA = "0x9EFEC4")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x9F1250", Offset = "0x9F1250", VA = "0x9F1250")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x9EFEAC", Offset = "0x9EFEAC", VA = "0x9EFEAC")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x9F00D4", Offset = "0x9F00D4", VA = "0x9F00D4")]
		private GameObject GetTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x9F07B8", Offset = "0x9F07B8", VA = "0x9F07B8")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x9F1288", Offset = "0x9F1288", VA = "0x9F1288")]
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
		[Address(RVA = "0x9F147C", Offset = "0x9F147C", VA = "0x9F147C")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x9F14CC", Offset = "0x9F14CC", VA = "0x9F14CC")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x9F1890", Offset = "0x9F1890", VA = "0x9F1890")]
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
			[Address(RVA = "0x9F2CD4", Offset = "0x9F2CD4", VA = "0x9F2CD4")]
			public ExtraData(float c1 = 0f, float c2 = 0f, float c3 = 0f, float c4 = 0f)
			{
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0x9F2CE0", Offset = "0x9F2CE0", VA = "0x9F2CE0")]
			public static ExtraData Lerp(ExtraData a, ExtraData b, float t)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0x9F2D2C", Offset = "0x9F2D2C", VA = "0x9F2D2C")]
			public static ExtraData LerpUnclamped(ExtraData a, ExtraData b, float t)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x9F2D64", Offset = "0x9F2D64", VA = "0x9F2D64")]
			public static implicit operator ExtraData(Vector2 v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x9F2D70", Offset = "0x9F2D70", VA = "0x9F2D70")]
			public static implicit operator ExtraData(Vector3 v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x9F2D78", Offset = "0x9F2D78", VA = "0x9F2D78")]
			public static implicit operator ExtraData(Vector4 v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x9F2D7C", Offset = "0x9F2D7C", VA = "0x9F2D7C")]
			public static implicit operator ExtraData(Quaternion q)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x9F2D80", Offset = "0x9F2D80", VA = "0x9F2D80")]
			public static implicit operator ExtraData(Rect r)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000208")]
			[Address(RVA = "0x9F2DF8", Offset = "0x9F2DF8", VA = "0x9F2DF8")]
			public static implicit operator ExtraData(Vector2Int v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x6000209")]
			[Address(RVA = "0x9F2E10", Offset = "0x9F2E10", VA = "0x9F2E10")]
			public static implicit operator ExtraData(Vector3Int v)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x600020A")]
			[Address(RVA = "0x9F2E28", Offset = "0x9F2E28", VA = "0x9F2E28")]
			public static implicit operator ExtraData(RectInt r)
			{
				return default(ExtraData);
			}

			[Token(Token = "0x600020B")]
			[Address(RVA = "0x9F2E94", Offset = "0x9F2E94", VA = "0x9F2E94")]
			public static implicit operator Vector2(ExtraData v)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600020C")]
			[Address(RVA = "0x9F2E98", Offset = "0x9F2E98", VA = "0x9F2E98")]
			public static implicit operator Vector3(ExtraData v)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0x9F2E9C", Offset = "0x9F2E9C", VA = "0x9F2E9C")]
			public static implicit operator Vector4(ExtraData v)
			{
				return default(Vector4);
			}

			[Token(Token = "0x600020E")]
			[Address(RVA = "0x9F2EA0", Offset = "0x9F2EA0", VA = "0x9F2EA0")]
			public static implicit operator Quaternion(ExtraData v)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0x9F2EA4", Offset = "0x9F2EA4", VA = "0x9F2EA4")]
			public static implicit operator Rect(ExtraData v)
			{
				return default(Rect);
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0x9F2ED0", Offset = "0x9F2ED0", VA = "0x9F2ED0")]
			public static implicit operator Vector2Int(ExtraData v)
			{
				return default(Vector2Int);
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x9F3084", Offset = "0x9F3084", VA = "0x9F3084")]
			public static implicit operator Vector3Int(ExtraData v)
			{
				return default(Vector3Int);
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0x9F32D0", Offset = "0x9F32D0", VA = "0x9F32D0")]
			public static implicit operator RectInt(ExtraData v)
			{
				return default(RectInt);
			}

			[Token(Token = "0x6000213")]
			[Address(RVA = "0x9F3614", Offset = "0x9F3614", VA = "0x9F3614")]
			public static bool operator ==(ExtraData d1, ExtraData d2)
			{
				return default(bool);
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0x9F3644", Offset = "0x9F3644", VA = "0x9F3644")]
			public static bool operator !=(ExtraData d1, ExtraData d2)
			{
				return default(bool);
			}

			[Token(Token = "0x6000215")]
			[Address(RVA = "0x9F3674", Offset = "0x9F3674", VA = "0x9F3674", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0x9F372C", Offset = "0x9F372C", VA = "0x9F372C", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x9F3778", Offset = "0x9F3778", VA = "0x9F3778", Slot = "3")]
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
			[Address(RVA = "0x9F1CAC", Offset = "0x9F1CAC", VA = "0x9F1CAC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x9F1CCC", Offset = "0x9F1CCC", VA = "0x9F1CCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Vector3 position
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x9F1D14", Offset = "0x9F1D14", VA = "0x9F1D14")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x9F1DE8", Offset = "0x9F1DE8", VA = "0x9F1DE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public Quaternion localRotation
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x9F1E30", Offset = "0x9F1E30", VA = "0x9F1E30")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x9F1E50", Offset = "0x9F1E50", VA = "0x9F1E50")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Quaternion rotation
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x9F1EA0", Offset = "0x9F1EA0", VA = "0x9F1EA0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x9F1EC0", Offset = "0x9F1EC0", VA = "0x9F1EC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Vector3 localEulerAngles
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x9F1F10", Offset = "0x9F1F10", VA = "0x9F1F10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x9F1F30", Offset = "0x9F1F30", VA = "0x9F1F30")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Vector3 eulerAngles
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x9F1F78", Offset = "0x9F1F78", VA = "0x9F1F78")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x9F1F98", Offset = "0x9F1F98", VA = "0x9F1F98")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Vector3 localScale
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x9F1FE0", Offset = "0x9F1FE0", VA = "0x9F1FE0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x9F2000", Offset = "0x9F2000", VA = "0x9F2000")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Vector3 precedingControlPointLocalPosition
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x9F2048", Offset = "0x9F2048", VA = "0x9F2048")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x9F2054", Offset = "0x9F2054", VA = "0x9F2054")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Vector3 precedingControlPointPosition
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x9F222C", Offset = "0x9F222C", VA = "0x9F222C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x9F2268", Offset = "0x9F2268", VA = "0x9F2268")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 followingControlPointLocalPosition
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x9F24F0", Offset = "0x9F24F0", VA = "0x9F24F0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x9F24FC", Offset = "0x9F24FC", VA = "0x9F24FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Vector3 followingControlPointPosition
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x9F26D4", Offset = "0x9F26D4", VA = "0x9F26D4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x9F2710", Offset = "0x9F2710", VA = "0x9F2710")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public HandleMode handleMode
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x9F2998", Offset = "0x9F2998", VA = "0x9F2998")]
			get
			{
				return default(HandleMode);
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x9F29A0", Offset = "0x9F29A0", VA = "0x9F29A0")]
			set
			{
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x9F29C0", Offset = "0x9F29C0", VA = "0x9F29C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x9F29E4", Offset = "0x9F29E4", VA = "0x9F29E4")]
		public void CopyTo(BezierPoint other)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x9F1D50", Offset = "0x9F1D50", VA = "0x9F1D50")]
		private void Revalidate()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x9F2AD8", Offset = "0x9F2AD8", VA = "0x9F2AD8")]
		[Conditional("UNITY_EDITOR")]
		private void SetSplineDirty()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x9F2ADC", Offset = "0x9F2ADC", VA = "0x9F2ADC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x9F2C38", Offset = "0x9F2C38", VA = "0x9F2C38")]
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
			[Address(RVA = "0x9F8210", Offset = "0x9F8210", VA = "0x9F8210")]
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
			[Address(RVA = "0x9F37A0", Offset = "0x9F37A0", VA = "0x9F37A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x9F37A8", Offset = "0x9F37A8", VA = "0x9F37A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public int Count
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x9F3820", Offset = "0x9F3820", VA = "0x9F3820")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		public float Length
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x9F3868", Offset = "0x9F3868", VA = "0x9F3868")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000016")]
		public BezierPoint this[int index]
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x9F3A68", Offset = "0x9F3A68", VA = "0x9F3A68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x9F3B98", Offset = "0x9F3B98", VA = "0x9F3B98")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x9F3C30", Offset = "0x9F3C30", VA = "0x9F3C30")]
		public void Initialize(int endPointsCount)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x9F3B9C", Offset = "0x9F3B9C", VA = "0x9F3B9C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x9F3E08", Offset = "0x9F3E08", VA = "0x9F3E08")]
		public BezierPoint InsertNewPointAt(int index)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x9F425C", Offset = "0x9F425C", VA = "0x9F425C")]
		public BezierPoint DuplicatePointAt(int index)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x9F4540", Offset = "0x9F4540", VA = "0x9F4540")]
		public void RemovePointAt(int index)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x9F48A4", Offset = "0x9F48A4", VA = "0x9F48A4")]
		public void SwapPointsAt(int index1, int index2)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x9F4B80", Offset = "0x9F4B80", VA = "0x9F4B80")]
		public void MovePoint(int previousIndex, int newIndex)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x9F4B84", Offset = "0x9F4B84", VA = "0x9F4B84")]
		public void Internal_MovePoint(int previousIndex, int newIndex, string undo)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x9F4EF8", Offset = "0x9F4EF8", VA = "0x9F4EF8")]
		public int IndexOf(BezierPoint point)
		{
			return default(int);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x9F4F50", Offset = "0x9F4F50", VA = "0x9F4F50")]
		public Vector3 GetPoint(float normalizedT)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x9F5158", Offset = "0x9F5158", VA = "0x9F5158")]
		public RotationReference GetTranformOfClosestPoint(float normalizedT)
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x9F5480", Offset = "0x9F5480", VA = "0x9F5480")]
		public Vector3 GetTangent(float normalizedT)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x9F573C", Offset = "0x9F573C", VA = "0x9F573C")]
		public BezierPoint.ExtraData GetExtraData(float normalizedT)
		{
			return default(BezierPoint.ExtraData);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x9F57AC", Offset = "0x9F57AC", VA = "0x9F57AC")]
		public BezierPoint.ExtraData GetExtraData(float normalizedT, ExtraDataLerpFunction lerpFunction)
		{
			return default(BezierPoint.ExtraData);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x9F387C", Offset = "0x9F387C", VA = "0x9F387C")]
		public float GetLengthApproximately(float startNormalizedT, float endNormalizedT, float accuracy = 50f)
		{
			return default(float);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x9F5984", Offset = "0x9F5984", VA = "0x9F5984")]
		public PointIndexTuple GetNearestPointIndicesTo(float normalizedT)
		{
			return default(PointIndexTuple);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x9F5AB4", Offset = "0x9F5AB4", VA = "0x9F5AB4")]
		public Vector3 FindNearestPointTo(Vector3 worldPos, float accuracy = 100f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x9F5ACC", Offset = "0x9F5ACC", VA = "0x9F5ACC")]
		public Vector3 FindNearestPointTo(Vector3 worldPos, out float normalizedT, float accuracy = 100f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x9F5BFC", Offset = "0x9F5BFC", VA = "0x9F5BFC")]
		public Vector3 MoveAlongSpline(ref float normalizedT, float deltaMovement, int accuracy = 3)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x9F5D1C", Offset = "0x9F5D1C", VA = "0x9F5D1C")]
		public void ConstructLinearPath()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x9F5F2C", Offset = "0x9F5F2C", VA = "0x9F5F2C")]
		public void AutoConstructSpline()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x9F6858", Offset = "0x9F6858", VA = "0x9F6858")]
		private static Vector3[] GetFirstControlPoints(Vector3[] rhs)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x9F6A58", Offset = "0x9F6A58", VA = "0x9F6A58")]
		public void AutoConstructSpline2()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x9F5948", Offset = "0x9F5948", VA = "0x9F5948")]
		private float AccuracyToStepSize(float accuracy)
		{
			return default(float);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x9F6D90", Offset = "0x9F6D90", VA = "0x9F6D90")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x9F70D0", Offset = "0x9F70D0", VA = "0x9F70D0")]
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
		[Address(RVA = "0x9F83E8", Offset = "0x9F83E8", VA = "0x9F83E8")]
		public Vector3 GetInterpolatedRotation()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x9F8518", Offset = "0x9F8518", VA = "0x9F8518")]
		public float GetInterpolatedZ()
		{
			return default(float);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x9F8634", Offset = "0x9F8634", VA = "0x9F8634")]
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
		[Address(RVA = "0x9F8650", Offset = "0x9F8650", VA = "0x9F8650")]
		private static BezierPoint.ExtraData InterpolateExtraDataAsQuaternion(BezierPoint.ExtraData data1, BezierPoint.ExtraData data2, float normalizedT)
		{
			return default(BezierPoint.ExtraData);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x9F8700", Offset = "0x9F8700", VA = "0x9F8700")]
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
			[Address(RVA = "0x9F87A4", Offset = "0x9F87A4", VA = "0x9F87A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public List<float> TailDistances
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x9F87AC", Offset = "0x9F87AC", VA = "0x9F87AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public override BezierSpline Spline
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x9F87B4", Offset = "0x9F87B4", VA = "0x9F87B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public override bool MovingForward
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x9F87D4", Offset = "0x9F87D4", VA = "0x9F87D4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public override float NormalizedT
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x9F87F4", Offset = "0x9F87F4", VA = "0x9F87F4", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x9F8814", Offset = "0x9F8814", VA = "0x9F8814", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x9F8834", Offset = "0x9F8834", VA = "0x9F8834")]
		private void Start()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x9F8994", Offset = "0x9F8994", VA = "0x9F8994")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x9F89B8", Offset = "0x9F89B8", VA = "0x9F89B8", Slot = "8")]
		public override void Execute(float deltaTime)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x9F8D08", Offset = "0x9F8D08", VA = "0x9F8D08")]
		public void AddToTail(Transform transform, float distanceToPreviousObject)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x9F8ED4", Offset = "0x9F8ED4", VA = "0x9F8ED4")]
		public void InsertIntoTail(int index, Transform transform, float distanceToPreviousObject)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x9F9000", Offset = "0x9F9000", VA = "0x9F9000")]
		public void RemoveFromTail(Transform transform)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x9F91BC", Offset = "0x9F91BC", VA = "0x9F91BC")]
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
			[Address(RVA = "0x9F9228", Offset = "0x9F9228", VA = "0x9F9228", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public override float NormalizedT
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x9F9230", Offset = "0x9F9230", VA = "0x9F9230", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x9F9238", Offset = "0x9F9238", VA = "0x9F9238", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public override bool MovingForward
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x9F9240", Offset = "0x9F9240", VA = "0x9F9240", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x9F925C", Offset = "0x9F925C", VA = "0x9F925C")]
		private void Update()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x9F9280", Offset = "0x9F9280", VA = "0x9F9280", Slot = "8")]
		public override void Execute(float deltaTime)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x9F95C8", Offset = "0x9F95C8", VA = "0x9F95C8")]
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
			[Address(RVA = "0x9F9680", Offset = "0x9F9680", VA = "0x9F9680", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public override float NormalizedT
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x9F9688", Offset = "0x9F9688", VA = "0x9F9688", Slot = "6")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x9F9690", Offset = "0x9F9690", VA = "0x9F9690", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public override bool MovingForward
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x9F9698", Offset = "0x9F9698", VA = "0x9F9698", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x9F96A0", Offset = "0x9F96A0", VA = "0x9F96A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x9F96C4", Offset = "0x9F96C4", VA = "0x9F96C4", Slot = "8")]
		public override void Execute(float deltaTime)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x9F9A34", Offset = "0x9F9A34", VA = "0x9F9A34")]
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
		[Address(RVA = "0x9F9AEC", Offset = "0x9F9AEC", VA = "0x9F9AEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x9F9C40", Offset = "0x9F9C40", VA = "0x9F9C40")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x9FA128", Offset = "0x9FA128", VA = "0x9FA128")]
		public ParticlesFollowBezier()
		{
		}
	}
}
